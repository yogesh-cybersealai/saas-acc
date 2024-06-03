// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See LICENSE file in the project root for license information.
namespace Marketplace.SaaS.Accelerator.Services.Models;

/// <summary>
/// Sets Subscription Operation Status..
/// </summary>
public enum DeploymentStatusEnum
{
    /// <summary>
    /// Pending Activation
    /// </summary>
    PendingActivation,
    /// <summary>
    /// The pending fulfillment start
    /// </summary>
    Active,

    /// <summary>
    /// The subscribed
    /// </summary>
    Inactive,

    /// <summary>
    /// Pending Activation
    /// </summary>
    Suspended,

}