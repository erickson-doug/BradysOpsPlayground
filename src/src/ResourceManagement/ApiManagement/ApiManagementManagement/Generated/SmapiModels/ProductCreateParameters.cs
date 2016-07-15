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

using System;
using System.Linq;
using Microsoft.Azure.Management.ApiManagement.SmapiModels;

namespace Microsoft.Azure.Management.ApiManagement.SmapiModels
{
    /// <summary>
    /// Parameters supplied to the CreateOrUpdate Product operation.
    /// </summary>
    public partial class ProductCreateParameters
    {
        private ProductContract _productContract;
        
        /// <summary>
        /// Required. Gets or sets product details.
        /// </summary>
        public ProductContract ProductContract
        {
            get { return this._productContract; }
            set { this._productContract = value; }
        }
        
        /// <summary>
        /// Initializes a new instance of the ProductCreateParameters class.
        /// </summary>
        public ProductCreateParameters()
        {
        }
        
        /// <summary>
        /// Initializes a new instance of the ProductCreateParameters class
        /// with required arguments.
        /// </summary>
        public ProductCreateParameters(ProductContract productContract)
            : this()
        {
            if (productContract == null)
            {
                throw new ArgumentNullException("productContract");
            }
            this.ProductContract = productContract;
        }
    }
}
