// Decompiled with JetBrains decompiler
// Type: com.citrix.netscaler.nitro.resource.config.lb.lbmonitor_metric_binding
// Assembly: nitro, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 6CF5DDEF-E052-4F9D-953F-6644F8378A66


using com.citrix.netscaler.nitro.exception;
using com.citrix.netscaler.nitro.resource.Base;
using com.citrix.netscaler.nitro.service;
using com.citrix.netscaler.nitro.util;

namespace com.citrix.netscaler.nitro.resource.config.lb
{
  public class lbmonitor_metric_binding : base_resource
  {
    private string metricField = (string) null;
    private string metrictableField = (string) null;
    private string metric_unitField = (string) null;
    private uint? metricweightField = new uint?();
    private long? metricthresholdField = new long?();
    private string monitornameField = (string) null;
    private uint? __countField = new uint?();

    public uint? __count
    {
      get => this.__countField;
      set => this.__countField = value;
    }

    public string metric
    {
      get => this.metricField;
      set => this.metricField = value;
    }

    public long? metricthreshold
    {
      get => this.metricthresholdField;
      set => this.metricthresholdField = value;
    }

    public uint? metricweight
    {
      get => this.metricweightField;
      set => this.metricweightField = value;
    }

    public string monitorname
    {
      get => this.monitornameField;
      set => this.monitornameField = value;
    }

    public string metric_unit
    {
      get => this.metric_unitField;
      private set => this.metric_unitField = value;
    }

    public string metrictable
    {
      get => this.metrictableField;
      private set => this.metrictableField = value;
    }

    internal override base_resource[] get_nitro_response(
      nitro_service service,
      string response)
    {
      lbmonitor_metric_binding.lbmonitor_metric_binding_response metricBindingResponse = new lbmonitor_metric_binding.lbmonitor_metric_binding_response();
      lbmonitor_metric_binding.lbmonitor_metric_binding_response resource = (lbmonitor_metric_binding.lbmonitor_metric_binding_response) service.get_payload_formatter().string_to_resource(metricBindingResponse.GetType(), response);
      if (resource.errorcode != 0)
      {
        if (resource.errorcode == 444)
          service.clear_session();
        if (resource.severity == null)
          throw new nitro_exception(resource.message, resource.errorcode);
        if (resource.severity.Equals("ERROR"))
          throw new nitro_exception(resource.message, resource.errorcode);
      }
      return (base_resource[]) resource.lbmonitor_metric_binding;
    }

    internal override string get_object_name() => this.monitorname;

    public static base_response add(
      nitro_service client,
      lbmonitor_metric_binding resource)
    {
      return new lbmonitor_metric_binding()
      {
        monitorname = resource.monitorname,
        metric = resource.metric,
        metricthreshold = resource.metricthreshold,
        metricweight = resource.metricweight
      }.update_resource(client);
    }

    public static base_responses add(
      nitro_service client,
      lbmonitor_metric_binding[] resources)
    {
      base_responses baseResponses = (base_responses) null;
      if (resources != null && resources.Length > 0)
      {
        lbmonitor_metric_binding[] lbmonitorMetricBindingArray = new lbmonitor_metric_binding[resources.Length];
        for (int index = 0; index < resources.Length; ++index)
        {
          lbmonitorMetricBindingArray[index] = new lbmonitor_metric_binding();
          lbmonitorMetricBindingArray[index].monitorname = resources[index].monitorname;
          lbmonitorMetricBindingArray[index].metric = resources[index].metric;
          lbmonitorMetricBindingArray[index].metricthreshold = resources[index].metricthreshold;
          lbmonitorMetricBindingArray[index].metricweight = resources[index].metricweight;
        }
        baseResponses = base_resource.update_bulk_request(client, (base_resource[]) lbmonitorMetricBindingArray);
      }
      return baseResponses;
    }

    public static base_response delete(
      nitro_service client,
      lbmonitor_metric_binding resource)
    {
      return new lbmonitor_metric_binding()
      {
        monitorname = resource.monitorname,
        metric = resource.metric
      }.delete_resource(client);
    }

    public static base_responses delete(
      nitro_service client,
      lbmonitor_metric_binding[] resources)
    {
      base_responses baseResponses = (base_responses) null;
      if (resources != null && resources.Length > 0)
      {
        lbmonitor_metric_binding[] lbmonitorMetricBindingArray = new lbmonitor_metric_binding[resources.Length];
        for (int index = 0; index < resources.Length; ++index)
        {
          lbmonitorMetricBindingArray[index] = new lbmonitor_metric_binding();
          lbmonitorMetricBindingArray[index].monitorname = resources[index].monitorname;
          lbmonitorMetricBindingArray[index].metric = resources[index].metric;
        }
        baseResponses = base_resource.delete_bulk_request(client, (base_resource[]) lbmonitorMetricBindingArray);
      }
      return baseResponses;
    }

    public static lbmonitor_metric_binding[] get(
      nitro_service service,
      string monitorname)
    {
      return (lbmonitor_metric_binding[]) new lbmonitor_metric_binding()
      {
        monitorname = monitorname
      }.get_resources(service, (options) null);
    }

    public static lbmonitor_metric_binding[] get_filtered(
      nitro_service service,
      string monitorname,
      string filter)
    {
      lbmonitor_metric_binding lbmonitorMetricBinding = new lbmonitor_metric_binding();
      lbmonitorMetricBinding.monitorname = monitorname;
      options option = new options();
      option.set_filter(filter);
      return (lbmonitor_metric_binding[]) lbmonitorMetricBinding.getfiltered(service, option);
    }

    public static lbmonitor_metric_binding[] get_filtered(
      nitro_service service,
      string monitorname,
      filtervalue[] filter)
    {
      lbmonitor_metric_binding lbmonitorMetricBinding = new lbmonitor_metric_binding();
      lbmonitorMetricBinding.monitorname = monitorname;
      options option = new options();
      option.set_filter(filter);
      return (lbmonitor_metric_binding[]) lbmonitorMetricBinding.getfiltered(service, option);
    }

    public static uint count(nitro_service service, string monitorname)
    {
      lbmonitor_metric_binding lbmonitorMetricBinding = new lbmonitor_metric_binding();
      lbmonitorMetricBinding.monitorname = monitorname;
      options option = new options();
      option.set_count(true);
      lbmonitor_metric_binding[] resources = (lbmonitor_metric_binding[]) lbmonitorMetricBinding.get_resources(service, option);
      return resources != null && resources.Length > 0 ? resources[0].__count.Value : 0U;
    }

    public static uint count_filtered(nitro_service service, string monitorname, string filter)
    {
      lbmonitor_metric_binding lbmonitorMetricBinding = new lbmonitor_metric_binding();
      lbmonitorMetricBinding.monitorname = monitorname;
      options option = new options();
      option.set_count(true);
      option.set_filter(filter);
      lbmonitor_metric_binding[] lbmonitorMetricBindingArray = (lbmonitor_metric_binding[]) lbmonitorMetricBinding.getfiltered(service, option);
      return lbmonitorMetricBindingArray != null && lbmonitorMetricBindingArray.Length > 0 ? lbmonitorMetricBindingArray[0].__count.Value : 0U;
    }

    public static uint count_filtered(
      nitro_service service,
      string monitorname,
      filtervalue[] filter)
    {
      lbmonitor_metric_binding lbmonitorMetricBinding = new lbmonitor_metric_binding();
      lbmonitorMetricBinding.monitorname = monitorname;
      options option = new options();
      option.set_count(true);
      option.set_filter(filter);
      lbmonitor_metric_binding[] lbmonitorMetricBindingArray = (lbmonitor_metric_binding[]) lbmonitorMetricBinding.getfiltered(service, option);
      return lbmonitorMetricBindingArray != null && lbmonitorMetricBindingArray.Length > 0 ? lbmonitorMetricBindingArray[0].__count.Value : 0U;
    }

    private class lbmonitor_metric_binding_response : base_response
    {
      public lbmonitor_metric_binding[] lbmonitor_metric_binding = (lbmonitor_metric_binding[]) null;
    }

    public static class dup_stateEnum
    {
      public const string ENABLED = "ENABLED";
      public const string DISABLED = "DISABLED";
    }

    public static class stateEnum
    {
      public const string ENABLED = "ENABLED";
      public const string DISABLED = "DISABLED";
    }

    public static class metric_unitEnum
    {
      public const string Bytes_s = "Bytes/s";
      public const string ms = "ms";
      public const string pkts_s = "pkts/s";
      public const string users = "users";
    }
  }
}
