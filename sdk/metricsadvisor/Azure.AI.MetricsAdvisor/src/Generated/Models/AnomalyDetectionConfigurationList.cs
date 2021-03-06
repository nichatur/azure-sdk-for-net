// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using System.Linq;

namespace Azure.AI.MetricsAdvisor.Models
{
    /// <summary> The AnomalyDetectionConfigurationList. </summary>
    internal partial class AnomalyDetectionConfigurationList
    {
        /// <summary> Initializes a new instance of AnomalyDetectionConfigurationList. </summary>
        /// <param name="value"> . </param>
        /// <exception cref="ArgumentNullException"> <paramref name="value"/> is null. </exception>
        internal AnomalyDetectionConfigurationList(IEnumerable<AnomalyDetectionConfiguration> value)
        {
            if (value == null)
            {
                throw new ArgumentNullException(nameof(value));
            }

            Value = value.ToList();
        }

        /// <summary> Initializes a new instance of AnomalyDetectionConfigurationList. </summary>
        /// <param name="value"> . </param>
        internal AnomalyDetectionConfigurationList(IReadOnlyList<AnomalyDetectionConfiguration> value)
        {
            Value = value;
        }

        public IReadOnlyList<AnomalyDetectionConfiguration> Value { get; }
    }
}
