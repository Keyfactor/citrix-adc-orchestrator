// Decompiled with JetBrains decompiler
// Type: com.citrix.netscaler.nitro.resource.config.lb.lbmetrictable_metric_binding
// Assembly: nitro, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 6CF5DDEF-E052-4F9D-953F-6644F8378A66


using com.citrix.netscaler.nitro.exception;
using com.citrix.netscaler.nitro.resource.Base;
using com.citrix.netscaler.nitro.service;
using com.citrix.netscaler.nitro.util;

namespace com.citrix.netscaler.nitro.resource.config.lb
{
  public class lbmetrictable_metric_binding : base_resource
  {
    private string metricField = (string) null;
    private string SnmpoidField = (string) null;
    private string metrictypeField = (string) null;
    private string metrictableField = (string) null;
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

    public string metrictable
    {
      get => this.metrictableField;
      set => this.metrictableField = value;
    }

    public string Snmpoid
    {
      get => this.SnmpoidField;
      set => this.SnmpoidField = value;
    }

    public string metrictype
    {
      get => this.metrictypeField;
      private set => this.metrictypeField = value;
    }

    internal override base_resource[] get_nitro_response(
      nitro_service service,
      string response)
    {
      lbmetrictable_metric_binding.lbmetrictable_metric_binding_response metricBindingResponse = new lbmetrictable_metric_binding.lbmetrictable_metric_binding_response();
      lbmetrictable_metric_binding.lbmetrictable_metric_binding_response resource = (lbmetrictable_metric_binding.lbmetrictable_metric_binding_response) service.get_payload_formatter().string_to_resource(metricBindingResponse.GetType(), response);
      if (resource.errorcode != 0)
      {
        if (resource.errorcode == 444)
          service.clear_session();
        if (resource.severity == null)
          throw new nitro_exception(resource.message, resource.errorcode);
        if (resource.severity.Equals("ERROR"))
          throw new nitro_exception(resource.message, resource.errorcode);
      }
      return (base_resource[]) resource.lbmetrictable_metric_binding;
    }

    internal override string get_object_name() => this.metrictable;

    public static base_response add(
      nitro_service client,
      lbmetrictable_metric_binding resource)
    {
      return new lbmetrictable_metric_binding()
      {
        metrictable = resource.metrictable,
        metric = resource.metric,
        Snmpoid = resource.Snmpoid
      }.update_resource(client);
    }

    public static base_responses add(
      nitro_service client,
      lbmetrictable_metric_binding[] resources)
    {
      base_responses baseResponses = (base_responses) null;
      if (resources != null && resources.Length > 0)
      {
        lbmetrictable_metric_binding[] lbmetrictableMetricBindingArray = new lbmetrictable_metric_binding[resources.Length];
        for (int index = 0; index < resources.Length; ++index)
        {
          lbmetrictableMetricBindingArray[index] = new lbmetrictable_metric_binding();
          lbmetrictableMetricBindingArray[index].metrictable = resources[index].metrictable;
          lbmetrictableMetricBindingArray[index].metric = resources[index].metric;
          lbmetrictableMetricBindingArray[index].Snmpoid = resources[index].Snmpoid;
        }
        baseResponses = base_resource.update_bulk_request(client, (base_resource[]) lbmetrictableMetricBindingArray);
      }
      return baseResponses;
    }

    public static base_response delete(
      nitro_service client,
      lbmetrictable_metric_binding resource)
    {
      return new lbmetrictable_metric_binding()
      {
        metrictable = resource.metrictable,
        metric = resource.metric
      }.delete_resource(client);
    }

    public static base_responses delete(
      nitro_service client,
      lbmetrictable_metric_binding[] resources)
    {
      base_responses baseResponses = (base_responses) null;
      if (resources != null && resources.Length > 0)
      {
        lbmetrictable_metric_binding[] lbmetrictableMetricBindingArray = new lbmetrictable_metric_binding[resources.Length];
        for (int index = 0; index < resources.Length; ++index)
        {
          lbmetrictableMetricBindingArray[index] = new lbmetrictable_metric_binding();
          lbmetrictableMetricBindingArray[index].metrictable = resources[index].metrictable;
          lbmetrictableMetricBindingArray[index].metric = resources[index].metric;
        }
        baseResponses = base_resource.delete_bulk_request(client, (base_resource[]) lbmetrictableMetricBindingArray);
      }
      return baseResponses;
    }

    public static lbmetrictable_metric_binding[] get(
      nitro_service service,
      string metrictable)
    {
      return (lbmetrictable_metric_binding[]) new lbmetrictable_metric_binding()
      {
        metrictable = metrictable
      }.get_resources(service, (options) null);
    }

    public static lbmetrictable_metric_binding[] get_filtered(
      nitro_service service,
      string metrictable,
      string filter)
    {
      lbmetrictable_metric_binding lbmetrictableMetricBinding = new lbmetrictable_metric_binding();
      lbmetrictableMetricBinding.metrictable = metrictable;
      options option = new options();
      option.set_filter(filter);
      return (lbmetrictable_metric_binding[]) lbmetrictableMetricBinding.getfiltered(service, option);
    }

    public static lbmetrictable_metric_binding[] get_filtered(
      nitro_service service,
      string metrictable,
      filtervalue[] filter)
    {
      lbmetrictable_metric_binding lbmetrictableMetricBinding = new lbmetrictable_metric_binding();
      lbmetrictableMetricBinding.metrictable = metrictable;
      options option = new options();
      option.set_filter(filter);
      return (lbmetrictable_metric_binding[]) lbmetrictableMetricBinding.getfiltered(service, option);
    }

    public static uint count(nitro_service service, string metrictable)
    {
      lbmetrictable_metric_binding lbmetrictableMetricBinding = new lbmetrictable_metric_binding();
      lbmetrictableMetricBinding.metrictable = metrictable;
      options option = new options();
      option.set_count(true);
      lbmetrictable_metric_binding[] resources = (lbmetrictable_metric_binding[]) lbmetrictableMetricBinding.get_resources(service, option);
      return resources != null && resources.Length > 0 ? resources[0].__count.Value : 0U;
    }

    public static uint count_filtered(nitro_service service, string metrictable, string filter)
    {
      lbmetrictable_metric_binding lbmetrictableMetricBinding = new lbmetrictable_metric_binding();
      lbmetrictableMetricBinding.metrictable = metrictable;
      options option = new options();
      option.set_count(true);
      option.set_filter(filter);
      lbmetrictable_metric_binding[] lbmetrictableMetricBindingArray = (lbmetrictable_metric_binding[]) lbmetrictableMetricBinding.getfiltered(service, option);
      return lbmetrictableMetricBindingArray != null && lbmetrictableMetricBindingArray.Length > 0 ? lbmetrictableMetricBindingArray[0].__count.Value : 0U;
    }

    public static uint count_filtered(
      nitro_service service,
      string metrictable,
      filtervalue[] filter)
    {
      lbmetrictable_metric_binding lbmetrictableMetricBinding = new lbmetrictable_metric_binding();
      lbmetrictableMetricBinding.metrictable = metrictable;
      options option = new options();
      option.set_count(true);
      option.set_filter(filter);
      lbmetrictable_metric_binding[] lbmetrictableMetricBindingArray = (lbmetrictable_metric_binding[]) lbmetrictableMetricBinding.getfiltered(service, option);
      return lbmetrictableMetricBindingArray != null && lbmetrictableMetricBindingArray.Length > 0 ? lbmetrictableMetricBindingArray[0].__count.Value : 0U;
    }

    private class lbmetrictable_metric_binding_response : base_response
    {
      public lbmetrictable_metric_binding[] lbmetrictable_metric_binding = (lbmetrictable_metric_binding[]) null;
    }

    public static class metrictypeEnum
    {
      public const string INTERNAL = "INTERNAL";
      public const string CONFIGURED = "CONFIGURED";
    }
  }
}
