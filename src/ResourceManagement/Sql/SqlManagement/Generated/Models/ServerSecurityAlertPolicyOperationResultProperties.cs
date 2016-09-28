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
using Microsoft.Azure;

namespace Microsoft.Azure.Management.Sql.Models
{
    /// <summary>
    /// Represents the properties of a create or update request for an Azure
    /// SQL server security alert policy.
    /// </summary>
    public partial class ServerSecurityAlertPolicyOperationResultProperties
    {
        private string _operationId;
        
        /// <summary>
        /// Optional. Gets or sets the operation Id.
        /// </summary>
        public string OperationId
        {
            get { return this._operationId; }
            set { this._operationId = value; }
        }
        
        private string _startTime;
        
        /// <summary>
        /// Optional. Gets or sets the start time of the operation
        /// </summary>
        public string StartTime
        {
            get { return this._startTime; }
            set { this._startTime = value; }
        }
        
        private OperationStatus _state;
        
        /// <summary>
        /// Optional. Gets or sets the status of the operation.
        /// </summary>
        public OperationStatus State
        {
            get { return this._state; }
            set { this._state = value; }
        }
        
        /// <summary>
        /// Initializes a new instance of the
        /// ServerSecurityAlertPolicyOperationResultProperties class.
        /// </summary>
        public ServerSecurityAlertPolicyOperationResultProperties()
        {
        }
    }
}
