﻿//-----------------------------------------------------------------------
// <copyright file="ContainerHttpResponseParsers.Common.cs" company="Microsoft">
//    Copyright 2013 Microsoft Corporation
//
//    Licensed under the Apache License, Version 2.0 (the "License");
//    you may not use this file except in compliance with the License.
//    You may obtain a copy of the License at
//      http://www.apache.org/licenses/LICENSE-2.0
//
//    Unless required by applicable law or agreed to in writing, software
//    distributed under the License is distributed on an "AS IS" BASIS,
//    WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
//    See the License for the specific language governing permissions and
//    limitations under the License.
// </copyright>
//-----------------------------------------------------------------------

namespace Microsoft.WindowsAzure.Storage.Blob.Protocol
{
    using Microsoft.WindowsAzure.Storage.Core;
    using Microsoft.WindowsAzure.Storage.Core.Util;
    using Microsoft.WindowsAzure.Storage.Shared.Protocol;
    using System;
    using System.Diagnostics.CodeAnalysis;
    using System.Globalization;
    using System.IO;

#if WINDOWS_RT
    internal
#else
    public
#endif
        static partial class ContainerHttpResponseParsers
    {
        /// <summary>
        /// Reads the share access policies from a stream in XML.
        /// </summary>
        /// <param name="inputStream">The stream of XML policies.</param>
        /// <param name="permissions">The permissions object to which the policies are to be written.</param>
        public static void ReadSharedAccessIdentifiers(Stream inputStream, BlobContainerPermissions permissions)
        {
            CommonUtility.AssertNotNull("permissions", permissions);

            Response.ReadSharedAccessIdentifiers(permissions.SharedAccessPolicies, new BlobAccessPolicyResponse(inputStream));
        }

        /// <summary>
        /// Converts the ACL string to a <see cref="BlobContainerPermissions"/> object.
        /// </summary>
        /// <param name="acl">The string to convert.</param>
        /// <returns>The resulting <see cref="BlobContainerPermissions"/> object.</returns>
        [SuppressMessage("Microsoft.Globalization", "CA1304:SpecifyCultureInfo", MessageId = "System.String.ToLower", Justification = "ToLower(CultureInfo) is not present in RT and ToLowerInvariant() also violates FxCop")]      
        private static BlobContainerPublicAccessType GetContainerAcl(string acl)
        {
            BlobContainerPublicAccessType accessType = BlobContainerPublicAccessType.Off;

            if (!string.IsNullOrEmpty(acl))
            {
                switch (acl.ToLower())
                {
                    case "container":
                        accessType = BlobContainerPublicAccessType.Container;
                        break;

                    case "blob":
                        accessType = BlobContainerPublicAccessType.Blob;
                        break;

                    default:
                        string errorMessage = string.Format(CultureInfo.CurrentCulture, SR.InvalidAclType, acl);
                        throw new InvalidOperationException(errorMessage);
                }
            }

            return accessType;
        }
    }
}
