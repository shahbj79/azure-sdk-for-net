// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.Management.AlertsManagement.Models
{
    using Newtonsoft.Json;
    using Newtonsoft.Json.Converters;
    using System.Runtime;
    using System.Runtime.Serialization;

    /// <summary>
    /// Defines values for AlertModificationEvent.
    /// </summary>
    [JsonConverter(typeof(StringEnumConverter))]
    public enum AlertModificationEvent
    {
        [EnumMember(Value = "AlertCreated")]
        AlertCreated,
        [EnumMember(Value = "StateChange")]
        StateChange,
        [EnumMember(Value = "MonitorConditionChange")]
        MonitorConditionChange
    }
    internal static class AlertModificationEventEnumExtension
    {
        internal static string ToSerializedValue(this AlertModificationEvent? value)
        {
            return value == null ? null : ((AlertModificationEvent)value).ToSerializedValue();
        }

        internal static string ToSerializedValue(this AlertModificationEvent value)
        {
            switch( value )
            {
                case AlertModificationEvent.AlertCreated:
                    return "AlertCreated";
                case AlertModificationEvent.StateChange:
                    return "StateChange";
                case AlertModificationEvent.MonitorConditionChange:
                    return "MonitorConditionChange";
            }
            return null;
        }

        internal static AlertModificationEvent? ParseAlertModificationEvent(this string value)
        {
            switch( value )
            {
                case "AlertCreated":
                    return AlertModificationEvent.AlertCreated;
                case "StateChange":
                    return AlertModificationEvent.StateChange;
                case "MonitorConditionChange":
                    return AlertModificationEvent.MonitorConditionChange;
            }
            return null;
        }
    }
}