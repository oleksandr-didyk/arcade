// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.

using System;
using System.Collections.Immutable;
using Newtonsoft.Json;

namespace Microsoft.DotNet.Helix.Client.Models
{
    public partial class FailureReasonPart
    {
        public FailureReasonPart()
        {
        }

        [JsonProperty("Display")]
        public string Display { get; set; }

        [JsonProperty("Link")]
        public string Link { get; set; }
    }
}
