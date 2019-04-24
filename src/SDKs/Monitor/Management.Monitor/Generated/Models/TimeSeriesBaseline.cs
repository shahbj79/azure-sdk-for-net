// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.Management.Monitor.Models
{
    using Microsoft.Rest;
    using Newtonsoft.Json;
    using System.Collections;
    using System.Collections.Generic;
    using System.Linq;

    /// <summary>
    /// The baseline values for a single time series.
    /// </summary>
    public partial class TimeSeriesBaseline
    {
        /// <summary>
        /// Initializes a new instance of the TimeSeriesBaseline class.
        /// </summary>
        public TimeSeriesBaseline()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the TimeSeriesBaseline class.
        /// </summary>
        /// <param name="aggregation">The aggregation type of the
        /// metric.</param>
        /// <param name="timestamps">The list of timestamps of the
        /// baselines.</param>
        /// <param name="data">The baseline values for each
        /// sensitivity.</param>
        /// <param name="dimensions">The dimensions of this time
        /// series.</param>
        /// <param name="metadata">The baseline metadata values.</param>
        public TimeSeriesBaseline(string aggregation, IList<System.DateTime?> timestamps, IList<SingleBaseline> data, IList<MetricSingleDimension> dimensions = default(IList<MetricSingleDimension>), IList<BaselineMetadata> metadata = default(IList<BaselineMetadata>))
        {
            Aggregation = aggregation;
            Dimensions = dimensions;
            Timestamps = timestamps;
            Data = data;
            Metadata = metadata;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets the aggregation type of the metric.
        /// </summary>
        [JsonProperty(PropertyName = "aggregation")]
        public string Aggregation { get; set; }

        /// <summary>
        /// Gets or sets the dimensions of this time series.
        /// </summary>
        [JsonProperty(PropertyName = "dimensions")]
        public IList<MetricSingleDimension> Dimensions { get; set; }

        /// <summary>
        /// Gets or sets the list of timestamps of the baselines.
        /// </summary>
        [JsonProperty(PropertyName = "timestamps")]
        public IList<System.DateTime?> Timestamps { get; set; }

        /// <summary>
        /// Gets or sets the baseline values for each sensitivity.
        /// </summary>
        [JsonProperty(PropertyName = "data")]
        public IList<SingleBaseline> Data { get; set; }

        /// <summary>
        /// Gets or sets the baseline metadata values.
        /// </summary>
        [JsonProperty(PropertyName = "metadata")]
        public IList<BaselineMetadata> Metadata { get; set; }

        /// <summary>
        /// Validate the object.
        /// </summary>
        /// <exception cref="ValidationException">
        /// Thrown if validation fails
        /// </exception>
        public virtual void Validate()
        {
            if (Aggregation == null)
            {
                throw new ValidationException(ValidationRules.CannotBeNull, "Aggregation");
            }
            if (Timestamps == null)
            {
                throw new ValidationException(ValidationRules.CannotBeNull, "Timestamps");
            }
            if (Data == null)
            {
                throw new ValidationException(ValidationRules.CannotBeNull, "Data");
            }
            if (Dimensions != null)
            {
                foreach (var element in Dimensions)
                {
                    if (element != null)
                    {
                        element.Validate();
                    }
                }
            }
            if (Data != null)
            {
                foreach (var element1 in Data)
                {
                    if (element1 != null)
                    {
                        element1.Validate();
                    }
                }
            }
            if (Metadata != null)
            {
                foreach (var element2 in Metadata)
                {
                    if (element2 != null)
                    {
                        element2.Validate();
                    }
                }
            }
        }
    }
}