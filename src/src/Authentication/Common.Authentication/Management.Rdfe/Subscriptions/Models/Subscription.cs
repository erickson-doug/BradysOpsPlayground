﻿// 
// Copyright (c) Microsoft and contributors.  All rights reserved.
// 
// Licensed under the Apache License, Version 2.0 (the "License");
// you may not use this file except in compliance with the License.
// You may obtain a copy of the License at
//   http://www.apache.org/licenses/LICENSE-2.0
// 
// Unless required by applicable law or agreed to in writing, software
// distributed under the License is distributed on an "AS IS" BASIS,
// WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
// 
// See the License for the specific language governing permissions and
// limitations under the License.
// 

// Warning: This code was generated by a tool.
// 
// Changes to this file may cause incorrect behavior and will be lost if the
// code is regenerated.

using System;

namespace Microsoft.Azure.Subscriptions.Rdfe.Models
{
    public partial class Subscription
    {
        private string _accountAdminLiveEmailId;

        /// <summary>
        /// Optional.
        /// </summary>
        public string AccountAdminLiveEmailId
        {
            get { return this._accountAdminLiveEmailId; }
            set { this._accountAdminLiveEmailId = value; }
        }

        private string _activeDirectoryTenantId;

        /// <summary>
        /// Optional.
        /// </summary>
        public string ActiveDirectoryTenantId
        {
            get { return this._activeDirectoryTenantId; }
            set { this._activeDirectoryTenantId = value; }
        }

        private DateTime _created;

        /// <summary>
        /// Optional.
        /// </summary>
        public DateTime Created
        {
            get { return this._created; }
            set { this._created = value; }
        }

        private int _currentCoreCount;

        /// <summary>
        /// Optional.
        /// </summary>
        public int CurrentCoreCount
        {
            get { return this._currentCoreCount; }
            set { this._currentCoreCount = value; }
        }

        private int _currentHostedServices;

        /// <summary>
        /// Optional.
        /// </summary>
        public int CurrentHostedServices
        {
            get { return this._currentHostedServices; }
            set { this._currentHostedServices = value; }
        }

        private int _currentStorageAccounts;

        /// <summary>
        /// Optional.
        /// </summary>
        public int CurrentStorageAccounts
        {
            get { return this._currentStorageAccounts; }
            set { this._currentStorageAccounts = value; }
        }

        private int _maximumCoreCount;

        /// <summary>
        /// Optional.
        /// </summary>
        public int MaximumCoreCount
        {
            get { return this._maximumCoreCount; }
            set { this._maximumCoreCount = value; }
        }

        private int _maximumDnsServers;

        /// <summary>
        /// Optional.
        /// </summary>
        public int MaximumDnsServers
        {
            get { return this._maximumDnsServers; }
            set { this._maximumDnsServers = value; }
        }

        private int _maximumExtraVirtualIPCount;

        /// <summary>
        /// Optional.
        /// </summary>
        public int MaximumExtraVirtualIPCount
        {
            get { return this._maximumExtraVirtualIPCount; }
            set { this._maximumExtraVirtualIPCount = value; }
        }

        private int _maximumHostedServices;

        /// <summary>
        /// Optional.
        /// </summary>
        public int MaximumHostedServices
        {
            get { return this._maximumHostedServices; }
            set { this._maximumHostedServices = value; }
        }

        private int _maximumLocalNetworkSites;

        /// <summary>
        /// Optional.
        /// </summary>
        public int MaximumLocalNetworkSites
        {
            get { return this._maximumLocalNetworkSites; }
            set { this._maximumLocalNetworkSites = value; }
        }

        private int _maximumStorageAccounts;

        /// <summary>
        /// Optional.
        /// </summary>
        public int MaximumStorageAccounts
        {
            get { return this._maximumStorageAccounts; }
            set { this._maximumStorageAccounts = value; }
        }

        private int _maximumVirtualNetworkSites;

        /// <summary>
        /// Optional.
        /// </summary>
        public int MaximumVirtualNetworkSites
        {
            get { return this._maximumVirtualNetworkSites; }
            set { this._maximumVirtualNetworkSites = value; }
        }

        private string _serviceAdminLiveEmailId;

        /// <summary>
        /// Optional.
        /// </summary>
        public string ServiceAdminLiveEmailId
        {
            get { return this._serviceAdminLiveEmailId; }
            set { this._serviceAdminLiveEmailId = value; }
        }

        private string _subscriptionId;

        /// <summary>
        /// Optional.
        /// </summary>
        public string SubscriptionId
        {
            get { return this._subscriptionId; }
            set { this._subscriptionId = value; }
        }

        private string _subscriptionName;

        /// <summary>
        /// Optional.
        /// </summary>
        public string SubscriptionName
        {
            get { return this._subscriptionName; }
            set { this._subscriptionName = value; }
        }

        private SubscriptionStatus _subscriptionStatus;

        /// <summary>
        /// Optional.
        /// </summary>
        public SubscriptionStatus SubscriptionStatus
        {
            get { return this._subscriptionStatus; }
            set { this._subscriptionStatus = value; }
        }

        /// <summary>
        /// Initializes a new instance of the Subscription class.
        /// </summary>
        public Subscription()
        {
        }
    }
}
