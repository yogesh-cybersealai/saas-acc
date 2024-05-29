// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See LICENSE file in the project root for license information.
 
using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Azure;
using Marketplace.SaaS.Accelerator.Services.Models;
using Microsoft.Marketplace.SaaS.Models;
 
namespace Marketplace.SaaS.Accelerator.Services.Contracts;
 
/// <summary>
/// Interface AMPClient.
/// </summary>
public interface IPsaFulfillmentApiServices
{
   
    Task<PsaDeploymentResult> ActivateDeploymentAsync(Guid subscriptionId, string subscriptionPlanID, string userId);
}