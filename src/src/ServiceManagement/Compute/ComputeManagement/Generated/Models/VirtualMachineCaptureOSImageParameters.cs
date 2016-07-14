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
using Microsoft.WindowsAzure.Management.Compute.Models;

namespace Microsoft.WindowsAzure.Management.Compute.Models
{
    /// <summary>
    /// Parameters supplied to the Capture Virtual Machine operation.
    /// </summary>
    public partial class VirtualMachineCaptureOSImageParameters
    {
        private PostCaptureAction _postCaptureAction;
        
        /// <summary>
        /// Required. Specifies the action that is performed after the capture
        /// operation finishes. Possible values are: Delete - this value
        /// causes the virtual machine to be deleted after the image has been
        /// captured; or Reprovision - this value causes the virtual machine
        /// to be redeployed after the image is captured by using the
        /// specified information in ProvisioningConfiguration.
        /// </summary>
        public PostCaptureAction PostCaptureAction
        {
            get { return this._postCaptureAction; }
            set { this._postCaptureAction = value; }
        }
        
        private ConfigurationSet _provisioningConfiguration;
        
        /// <summary>
        /// Optional. Provides information to be used to redeploy the virtual
        /// machine after the image has been captured. This element is only
        /// used when the PostCaptureAction is set to Reprovision.
        /// </summary>
        public ConfigurationSet ProvisioningConfiguration
        {
            get { return this._provisioningConfiguration; }
            set { this._provisioningConfiguration = value; }
        }
        
        private string _targetImageLabel;
        
        /// <summary>
        /// Required. Specifies the friendly name of the captured image. This
        /// is the value that appears in the Name column for the image in the
        /// Azure Management Portal.
        /// </summary>
        public string TargetImageLabel
        {
            get { return this._targetImageLabel; }
            set { this._targetImageLabel = value; }
        }
        
        private string _targetImageName;
        
        /// <summary>
        /// Required. Specifies the image name of the captured image.
        /// </summary>
        public string TargetImageName
        {
            get { return this._targetImageName; }
            set { this._targetImageName = value; }
        }
        
        /// <summary>
        /// Initializes a new instance of the
        /// VirtualMachineCaptureOSImageParameters class.
        /// </summary>
        public VirtualMachineCaptureOSImageParameters()
        {
        }
        
        /// <summary>
        /// Initializes a new instance of the
        /// VirtualMachineCaptureOSImageParameters class with required
        /// arguments.
        /// </summary>
        public VirtualMachineCaptureOSImageParameters(PostCaptureAction postCaptureAction, string targetImageLabel, string targetImageName)
            : this()
        {
            if (targetImageLabel == null)
            {
                throw new ArgumentNullException("targetImageLabel");
            }
            if (targetImageName == null)
            {
                throw new ArgumentNullException("targetImageName");
            }
            this.PostCaptureAction = postCaptureAction;
            this.TargetImageLabel = targetImageLabel;
            this.TargetImageName = targetImageName;
        }
    }
}
