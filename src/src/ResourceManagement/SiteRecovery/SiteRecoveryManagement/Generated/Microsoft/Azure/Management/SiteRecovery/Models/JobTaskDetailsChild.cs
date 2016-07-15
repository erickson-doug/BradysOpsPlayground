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
using Microsoft.Azure.Management.SiteRecovery.Models;

namespace Microsoft.Azure.Management.SiteRecovery.Models
{
    /// <summary>
    /// Model class for job task details object which is actually a job.
    /// </summary>
    public partial class JobTaskDetailsChild : TaskTypeDetailsChild
    {
        private JobEntity _jobTask;
        
        /// <summary>
        /// Required. Job task.
        /// </summary>
        public JobEntity JobTask
        {
            get { return this._jobTask; }
            set { this._jobTask = value; }
        }
        
        /// <summary>
        /// Initializes a new instance of the JobTaskDetailsChild class.
        /// </summary>
        public JobTaskDetailsChild()
        {
        }
        
        /// <summary>
        /// Initializes a new instance of the JobTaskDetailsChild class with
        /// required arguments.
        /// </summary>
        public JobTaskDetailsChild(JobEntity jobTask, string type)
            : this()
        {
            if (jobTask == null)
            {
                throw new ArgumentNullException("jobTask");
            }
            if (type == null)
            {
                throw new ArgumentNullException("type");
            }
            this.JobTask = jobTask;
            this.Type = type;
        }
    }
}
