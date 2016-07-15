﻿using Microsoft.Azure;
using Microsoft.Azure.Management.Redis;
using Microsoft.Azure.Management.Redis.Models;
using Microsoft.Azure.Test;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace AzureRedisCache.Tests
{
    public class CreateUpdateDeleteFunctionalTests : TestBase, IUseFixture<TestsFixture>
    {
        private TestsFixture fixture;

        public void SetFixture(TestsFixture data)
        {
            fixture = data;
        }

        [Fact]
        public void CreateUpdateDeleteTest()
        {
            TestUtilities.StartTest();
            
            var _client = RedisCacheManagementTestUtilities.GetRedisManagementClient(this);

            RedisCreateOrUpdateResponse responseCreate = _client.Redis.CreateOrUpdate(resourceGroupName: fixture.ResourceGroupName, name: fixture.RedisCacheName,
                                    parameters: new RedisCreateOrUpdateParameters
                                    {
                                        Location = fixture.Location,
                                        Properties = new RedisProperties
                                        {
                                            Sku = new Sku()
                                            {
                                                Name = SkuName.Basic,
                                                Family = SkuFamily.C,
                                                Capacity = 1
                                            }
                                        }
                                    });

            Assert.NotNull(responseCreate.RequestId);
            Assert.Contains(fixture.RedisCacheName, responseCreate.Resource.Id);
            Assert.Equal(fixture.Location, responseCreate.Resource.Location);
            Assert.Equal(fixture.RedisCacheName, responseCreate.Resource.Name);
            Assert.Equal("Microsoft.Cache/Redis", responseCreate.Resource.Type);

            Assert.True("creating".Equals(responseCreate.Resource.Properties.ProvisioningState, StringComparison.InvariantCultureIgnoreCase));
            Assert.Equal(SkuName.Basic, responseCreate.Resource.Properties.Sku.Name);
            Assert.Equal(SkuFamily.C, responseCreate.Resource.Properties.Sku.Family);
            Assert.Equal(1, responseCreate.Resource.Properties.Sku.Capacity);
            
            Assert.Contains(fixture.RedisCacheName, responseCreate.Resource.Properties.HostName);
            Assert.Equal(6379, responseCreate.Resource.Properties.Port);
            Assert.Equal(6380, responseCreate.Resource.Properties.SslPort);
            Assert.False(responseCreate.Resource.Properties.EnableNonSslPort.Value);
            
            // wait for maximum 30 minutes for cache to create
            for (int i = 0; i < 60; i++)
            {
                TestUtilities.Wait(new TimeSpan(0, 0, 30));
                RedisGetResponse responseGet = _client.Redis.Get(resourceGroupName: fixture.ResourceGroupName, name: fixture.RedisCacheName);
                if ("succeeded".Equals(responseGet.Resource.Properties.ProvisioningState, StringComparison.InvariantCultureIgnoreCase))
                {
                    break;
                }
                Assert.False(i == 60, "Cache is not in succeeded state even after 30 min.");
            }

            RedisCreateOrUpdateResponse responseUpdate = _client.Redis.CreateOrUpdate(resourceGroupName: fixture.ResourceGroupName, name: fixture.RedisCacheName,
                                    parameters: new RedisCreateOrUpdateParameters
                                    {
                                        Location = fixture.Location,
                                        Properties = new RedisProperties
                                        {
                                            Sku = new Sku()
                                            {
                                                Name = SkuName.Basic,
                                                Family = SkuFamily.C,
                                                Capacity = 1
                                            },
                                            RedisConfiguration = new Dictionary<string, string>() { 
                                                {"maxmemory-policy","allkeys-lru"}
                                            },
                                            EnableNonSslPort = true
                                        }
                                    });

            Assert.NotNull(responseUpdate.RequestId);
            Assert.Contains(fixture.RedisCacheName, responseUpdate.Resource.Id);
            Assert.Equal(fixture.Location, responseUpdate.Resource.Location);
            Assert.Equal(fixture.RedisCacheName, responseUpdate.Resource.Name);
            Assert.Equal("Microsoft.Cache/Redis", responseUpdate.Resource.Type);

            Assert.Equal(SkuName.Basic, responseUpdate.Resource.Properties.Sku.Name);
            Assert.Equal(SkuFamily.C, responseUpdate.Resource.Properties.Sku.Family);
            Assert.Equal(1, responseUpdate.Resource.Properties.Sku.Capacity);
            Assert.Equal("allkeys-lru", responseUpdate.Resource.Properties.RedisConfiguration["maxmemory-policy"]);

            Assert.Contains(fixture.RedisCacheName, responseUpdate.Resource.Properties.HostName);
            Assert.Equal(6379, responseUpdate.Resource.Properties.Port);
            Assert.Equal(6380, responseUpdate.Resource.Properties.SslPort);
            Assert.True(responseUpdate.Resource.Properties.EnableNonSslPort.Value);

            AzureOperationResponse responseDelete = _client.Redis.Delete(resourceGroupName: fixture.ResourceGroupName, name: fixture.RedisCacheName);
                
            List<HttpStatusCode> acceptedStatusCodes = new List<HttpStatusCode>();
            acceptedStatusCodes.Add(HttpStatusCode.OK);
            acceptedStatusCodes.Add(HttpStatusCode.Accepted);
            acceptedStatusCodes.Add(HttpStatusCode.NotFound);

            Assert.Contains<HttpStatusCode>(responseDelete.StatusCode, acceptedStatusCodes);
            Assert.NotNull(responseDelete.RequestId);

            TestUtilities.EndTest();
        }

        [Fact]
        public void CreateUpdateDeleteClusterCacheTest()
        {
            TestUtilities.StartTest();

            var _client = RedisCacheManagementTestUtilities.GetRedisManagementClient(this);

            RedisCreateOrUpdateResponse responseCreate = _client.Redis.CreateOrUpdate(resourceGroupName: fixture.ResourceGroupName, name: fixture.RedisClusterCacheName,
                                    parameters: new RedisCreateOrUpdateParameters
                                    {
                                        Location = fixture.ClusterCacheLocation,
                                        Properties = new RedisProperties
                                        {
                                            RedisVersion = "3.0",
                                            Sku = new Sku()
                                            {
                                                Name = SkuName.Premium,
                                                Family = SkuFamily.P,
                                                Capacity = 1
                                            },
                                            ShardCount = 2,
                                            TenantSettings = new Dictionary<string, string>() { {"some-key","some-value"} }
                                        }
                                    });

            Assert.Contains(fixture.RedisClusterCacheName, responseCreate.Resource.Id);
            Assert.Equal(fixture.ClusterCacheLocation, responseCreate.Resource.Location);
            Assert.Equal(fixture.RedisClusterCacheName, responseCreate.Resource.Name);
            Assert.True("creating".Equals(responseCreate.Resource.Properties.ProvisioningState, StringComparison.InvariantCultureIgnoreCase));
            Assert.Equal(SkuName.Premium, responseCreate.Resource.Properties.Sku.Name);
            Assert.Equal(SkuFamily.P, responseCreate.Resource.Properties.Sku.Family);
            Assert.Equal(1, responseCreate.Resource.Properties.Sku.Capacity);
            Assert.Contains(fixture.RedisClusterCacheName, responseCreate.Resource.Properties.HostName);
            Assert.Equal(6379, responseCreate.Resource.Properties.Port);
            Assert.Equal(6380, responseCreate.Resource.Properties.SslPort);
            Assert.False(responseCreate.Resource.Properties.EnableNonSslPort.Value);
            Assert.Equal(2, responseCreate.Resource.Properties.ShardCount.Value);
            Assert.Equal("some-value", responseCreate.Resource.Properties.TenantSettings["some-key"]);

            // wait for maximum 30 minutes for cache to create
            for (int i = 0; i < 60; i++)
            {
                TestUtilities.Wait(new TimeSpan(0, 0, 30));
                RedisGetResponse responseGet = _client.Redis.Get(resourceGroupName: fixture.ResourceGroupName, name: fixture.RedisClusterCacheName);
                if ("succeeded".Equals(responseGet.Resource.Properties.ProvisioningState, StringComparison.InvariantCultureIgnoreCase))
                {
                    break;
                }
                Assert.False(i == 60, "Cache is not in succeeded state even after 30 min.");
            }

            RedisCreateOrUpdateResponse responseUpdate = _client.Redis.CreateOrUpdate(resourceGroupName: fixture.ResourceGroupName, name: fixture.RedisClusterCacheName,
                                    parameters: new RedisCreateOrUpdateParameters
                                    {
                                        Location = fixture.ClusterCacheLocation,
                                        Properties = new RedisProperties
                                        {
                                            Sku = new Sku()
                                            {
                                                Name = SkuName.Premium,
                                                Family = SkuFamily.P,
                                                Capacity = 1
                                            },
                                            TenantSettings = new Dictionary<string, string>() { { "some-key-1", "some-value-1" } }
                                        }
                                    });

            Assert.Equal("some-value-1", responseUpdate.Resource.Properties.TenantSettings["some-key-1"]);
            
            AzureOperationResponse responseDelete = _client.Redis.Delete(resourceGroupName: fixture.ResourceGroupName, name: fixture.RedisClusterCacheName);

            List<HttpStatusCode> acceptedStatusCodes = new List<HttpStatusCode>();
            acceptedStatusCodes.Add(HttpStatusCode.OK);
            acceptedStatusCodes.Add(HttpStatusCode.Accepted);
            acceptedStatusCodes.Add(HttpStatusCode.NotFound);

            Assert.Contains<HttpStatusCode>(responseDelete.StatusCode, acceptedStatusCodes);
            Assert.NotNull(responseDelete.RequestId);

            TestUtilities.EndTest();
        }
    }
}
