// 
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


namespace Microsoft.Azure.Management.Rdfe.Models
{
    /// <summary>
    /// The Get Subscription operation response.
    /// </summary>
    public partial class SubscriptionGetResponse : AzureOperationResponse
    {
        private string _accountAdminLiveEmailId;
        
        /// <summary>
        /// Optional. The live ID of the account administrator.
        /// </summary>
        public string AccountAdminLiveEmailId
        {
            get { return this._accountAdminLiveEmailId; }
            set { this._accountAdminLiveEmailId = value; }
        }
        
        private int _currentCoreCount;
        
        /// <summary>
        /// Optional. The number of currently allocated cores.
        /// </summary>
        public int CurrentCoreCount
        {
            get { return this._currentCoreCount; }
            set { this._currentCoreCount = value; }
        }
        
        private int _currentDnsServers;
        
        /// <summary>
        /// Optional. The current number of DNS servers allocated on this
        /// subscription.
        /// </summary>
        public int CurrentDnsServers
        {
            get { return this._currentDnsServers; }
            set { this._currentDnsServers = value; }
        }
        
        private int _currentHostedServices;
        
        /// <summary>
        /// Optional. The number of currently allocated cloud services.
        /// </summary>
        public int CurrentHostedServices
        {
            get { return this._currentHostedServices; }
            set { this._currentHostedServices = value; }
        }
        
        private int _currentLocalNetworkSites;
        
        /// <summary>
        /// Optional. The current number of local virtual network sites that
        /// are allocated on this subscription.
        /// </summary>
        public int CurrentLocalNetworkSites
        {
            get { return this._currentLocalNetworkSites; }
            set { this._currentLocalNetworkSites = value; }
        }
        
        private int _currentStorageAccounts;
        
        /// <summary>
        /// Optional. The number of currently allocated storage accounts.
        /// </summary>
        public int CurrentStorageAccounts
        {
            get { return this._currentStorageAccounts; }
            set { this._currentStorageAccounts = value; }
        }
        
        private int _currentVirtualNetworkSites;
        
        /// <summary>
        /// Optional. The number of currently allocated virtual network sites.
        /// </summary>
        public int CurrentVirtualNetworkSites
        {
            get { return this._currentVirtualNetworkSites; }
            set { this._currentVirtualNetworkSites = value; }
        }
        
        private int _maximumCoreCount;
        
        /// <summary>
        /// Optional. The maximum number of cores that can be allocated on this
        /// subscription.
        /// </summary>
        public int MaximumCoreCount
        {
            get { return this._maximumCoreCount; }
            set { this._maximumCoreCount = value; }
        }
        
        private int _maximumDnsServers;
        
        /// <summary>
        /// Optional. The maximum number of DNS servers that can be allocated
        /// on this subscription.
        /// </summary>
        public int MaximumDnsServers
        {
            get { return this._maximumDnsServers; }
            set { this._maximumDnsServers = value; }
        }
        
        private int _maximumHostedServices;
        
        /// <summary>
        /// Optional. The maximum number of cloud services that can be
        /// allocated on this subscription.
        /// </summary>
        public int MaximumHostedServices
        {
            get { return this._maximumHostedServices; }
            set { this._maximumHostedServices = value; }
        }
        
        private int _maximumLocalNetworkSites;
        
        /// <summary>
        /// Optional. The maximum number of local virtual network sites that
        /// can be allocated on this subscription.
        /// </summary>
        public int MaximumLocalNetworkSites
        {
            get { return this._maximumLocalNetworkSites; }
            set { this._maximumLocalNetworkSites = value; }
        }
        
        private int _maximumStorageAccounts;
        
        /// <summary>
        /// Optional. The maximum number of storage accounts that can be
        /// allocated on this subscription.
        /// </summary>
        public int MaximumStorageAccounts
        {
            get { return this._maximumStorageAccounts; }
            set { this._maximumStorageAccounts = value; }
        }
        
        private int _maximumVirtualNetworkSites;
        
        /// <summary>
        /// Optional. The maximum number of virtual network sites that can be
        /// allocated on this subscription.
        /// </summary>
        public int MaximumVirtualNetworkSites
        {
            get { return this._maximumVirtualNetworkSites; }
            set { this._maximumVirtualNetworkSites = value; }
        }
        
        private string _serviceAdminLiveEmailId;
        
        /// <summary>
        /// Optional. The live ID of the subscription administrator.
        /// </summary>
        public string ServiceAdminLiveEmailId
        {
            get { return this._serviceAdminLiveEmailId; }
            set { this._serviceAdminLiveEmailId = value; }
        }
        
        private string _subscriptionID;
        
        /// <summary>
        /// Optional. The subscription ID that the operation was called on.
        /// </summary>
        public string SubscriptionID
        {
            get { return this._subscriptionID; }
            set { this._subscriptionID = value; }
        }
        
        private string _subscriptionName;
        
        /// <summary>
        /// Optional. The user-supplied name for the subscription.
        /// </summary>
        public string SubscriptionName
        {
            get { return this._subscriptionName; }
            set { this._subscriptionName = value; }
        }
        
        private SubscriptionStatus _subscriptionStatus;
        
        /// <summary>
        /// Optional. The subscription status.
        /// </summary>
        public SubscriptionStatus SubscriptionStatus
        {
            get { return this._subscriptionStatus; }
            set { this._subscriptionStatus = value; }
        }
        
        /// <summary>
        /// Initializes a new instance of the SubscriptionGetResponse class.
        /// </summary>
        public SubscriptionGetResponse()
        {
        }
    }
}
