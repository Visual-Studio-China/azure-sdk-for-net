// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
// 
// Code generated by Microsoft (R) AutoRest Code Generator 0.16.0.0
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.

namespace Microsoft.Azure.Management.Network.Models
{
    using System;
    using System.Linq;
    using System.Collections.Generic;
    using Newtonsoft.Json;
    using Microsoft.Rest;
    using Microsoft.Rest.Serialization;
    using Microsoft.Rest.Azure;

    /// <summary>
    /// Application gateway backendhealth http settings.
    /// </summary>
    public partial class ApplicationGatewayBackendHealthHttpSettings
    {
        /// <summary>
        /// Initializes a new instance of the
        /// ApplicationGatewayBackendHealthHttpSettings class.
        /// </summary>
        public ApplicationGatewayBackendHealthHttpSettings() { }

        /// <summary>
        /// Initializes a new instance of the
        /// ApplicationGatewayBackendHealthHttpSettings class.
        /// </summary>
        public ApplicationGatewayBackendHealthHttpSettings(ApplicationGatewayBackendHttpSettings backendHttpSettings = default(ApplicationGatewayBackendHttpSettings), IList<ApplicationGatewayBackendHealthServer> servers = default(IList<ApplicationGatewayBackendHealthServer>))
        {
            BackendHttpSettings = backendHttpSettings;
            Servers = servers;
        }

        /// <summary>
        /// Reference of application gateway backend http settings resource.
        /// </summary>
        [JsonProperty(PropertyName = "backendHttpSettings")]
        public ApplicationGatewayBackendHttpSettings BackendHttpSettings { get; set; }

        /// <summary>
        /// List of application gateway backendhealth servers.
        /// </summary>
        [JsonProperty(PropertyName = "servers")]
        public IList<ApplicationGatewayBackendHealthServer> Servers { get; set; }

    }
}
