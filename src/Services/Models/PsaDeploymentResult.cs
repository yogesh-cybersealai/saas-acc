// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See LICENSE file in the project root for license information.

using System;
using System.Text.Json.Serialization;

namespace Marketplace.SaaS.Accelerator.Services.Models;

    /// <summary>
    /// Subscription object.
    /// </summary>
public class PsaDeploymentResult
{

    [JsonPropertyName("deploymentId")]
    public string DeploymentId { get; set; }

    [JsonPropertyName("saasPlatformLink")]
    public string SaasPlatformLink { get; set; }
}