// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.Management.Analysis.Models
{
    using Newtonsoft.Json;
    using System.Collections;
    using System.Collections.Generic;
    using System.Linq;

    /// <summary>
    /// An array of firewall rules.
    /// </summary>
    public partial class IPv4FirewallSettings
    {
        /// <summary>
        /// Initializes a new instance of the IPv4FirewallSettings class.
        /// </summary>
        public IPv4FirewallSettings()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the IPv4FirewallSettings class.
        /// </summary>
        /// <param name="firewallRules">An array of firewall rules.</param>
        /// <param name="enablePowerBIService">The indicator of enableing PBI
        /// service.</param>
        public IPv4FirewallSettings(IList<IPv4FirewallRule> firewallRules = default(IList<IPv4FirewallRule>), string enablePowerBIService = default(string))
        {
            FirewallRules = firewallRules;
            EnablePowerBIService = enablePowerBIService;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets an array of firewall rules.
        /// </summary>
        [JsonProperty(PropertyName = "firewallRules")]
        public IList<IPv4FirewallRule> FirewallRules { get; set; }

        /// <summary>
        /// Gets or sets the indicator of enableing PBI service.
        /// </summary>
        [JsonProperty(PropertyName = "enablePowerBIService")]
        public string EnablePowerBIService { get; set; }

    }
}