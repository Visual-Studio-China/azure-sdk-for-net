// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
// 
// Code generated by Microsoft (R) AutoRest Code Generator 0.17.0.0
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.

namespace Microsoft.Azure.Management.DataLake.Analytics.Models
{
    using System;
    using System.Linq;
    using System.Collections.Generic;
    using Newtonsoft.Json;
    using Microsoft.Rest;
    using Microsoft.Rest.Serialization;
    using Microsoft.Rest.Azure;

    /// <summary>
    /// The response body contains the status of the specified asynchronous
    /// operation, indicating whether it has succeeded, is inprogress, or has
    /// failed. Note that this status is distinct from the HTTP status code
    /// returned for the Get Operation Status operation itself. If the
    /// asynchronous operation succeeded, the response body includes the HTTP
    /// status code for the successful request. If the asynchronous operation
    /// failed, the response body includes the HTTP status code for the
    /// failed request and error information regarding the failure.
    /// </summary>
    public partial class AzureAsyncOperationResult
    {
        /// <summary>
        /// Initializes a new instance of the AzureAsyncOperationResult class.
        /// </summary>
        public AzureAsyncOperationResult() { }

        /// <summary>
        /// Initializes a new instance of the AzureAsyncOperationResult class.
        /// </summary>
        /// <param name="status">the status of the AzureAsuncOperation.
        /// Possible values include: 'InProgress', 'Succeeded',
        /// 'Failed'</param>
        public AzureAsyncOperationResult(OperationStatus? status = default(OperationStatus?), Error error = default(Error))
        {
            Status = status;
            Error = error;
        }

        /// <summary>
        /// Gets the status of the AzureAsuncOperation. Possible values
        /// include: 'InProgress', 'Succeeded', 'Failed'
        /// </summary>
        [JsonProperty(PropertyName = "status")]
        public OperationStatus? Status { get; private set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "error")]
        public Error Error { get; private set; }

    }
}
