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

    [JsonPropertyName("DeploymentId")]
    public string DeploymentId { get; set; }

    [JsonPropertyName("DeploymentStatus")]
    public string DeploymentStatus { get; set; }
}