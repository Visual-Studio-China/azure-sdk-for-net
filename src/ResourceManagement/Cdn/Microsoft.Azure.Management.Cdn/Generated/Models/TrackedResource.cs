// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
// 
// Code generated by Microsoft (R) AutoRest Code Generator 0.16.0.0
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.

namespace Microsoft.Azure.Management.Cdn.Models
{
    using System;
    using System.Linq;
    using System.Collections.Generic;
    using Newtonsoft.Json;
    using Microsoft.Rest;
    using Microsoft.Rest.Serialization;
    using Microsoft.Rest.Azure;

    /// <summary>
    /// ARM tracked resource
    /// </summary>
    public partial class TrackedResource : Resource
    {
        /// <summary>
        /// Initializes a new instance of the TrackedResource class.
        /// </summary>
        public TrackedResource() { }

        /// <summary>
        /// Initializes a new instance of the TrackedResource class.
        /// </summary>
        public TrackedResource(string location, IDictionary<string, string> tags, string id = default(string), string name = default(string), string type = default(string))
            : base(id, name, type)
        {
            Location = location;
            Tags = tags;
        }

        /// <summary>
        /// Resource location
        /// </summary>
        [JsonProperty(PropertyName = "location")]
        public string Location { get; set; }

        /// <summary>
        /// Resource tags
        /// </summary>
        [JsonProperty(PropertyName = "tags")]
        public IDictionary<string, string> Tags { get; set; }

        /// <summary>
        /// Validate the object. Throws ValidationException if validation fails.
        /// </summary>
        public virtual void Validate()
        {
            if (Location == null)
            {
                throw new ValidationException(ValidationRules.CannotBeNull, "Location");
            }
            if (Tags == null)
            {
                throw new ValidationException(ValidationRules.CannotBeNull, "Tags");
            }
        }
    }
}
