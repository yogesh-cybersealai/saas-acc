// Licensed under the MIT License. See LICENSE file in the project root for license information.
namespace Marketplace.SaaS.Accelerator.Services.Models;

/// <summary>
/// Sets Subscription Operation Status..
/// </summary>
public enum DeploymentStatusEnumExtension
{
    /// <summary>
    /// The pending fulfillment start
    /// </summary>
    /// 
    Active,

    /// <summary>
    /// The subscribed
    /// </summary>
    Inactive,

    /// <summary>
    /// The unsubscribed
    /// </summary>
    Suspended,

    /// <summary>
    /// Pending Activation
    /// </summary>
    PendingActivation,

    /// <summary>
    /// The pending unsubscribe
    /// </summary>
    PendingSuspension,

    /// <summary>
    /// The activation failed
    /// </summary>
    ActivationFailed,

    /// <summary>
    /// The unsubscribe failed
    /// </summary>
    SuspensionFailed,

}