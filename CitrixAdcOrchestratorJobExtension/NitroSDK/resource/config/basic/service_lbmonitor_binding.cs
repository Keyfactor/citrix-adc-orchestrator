// Decompiled with JetBrains decompiler
// Type: com.citrix.netscaler.nitro.resource.config.basic.service_lbmonitor_binding
// Assembly: nitro, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 6CF5DDEF-E052-4F9D-953F-6644F8378A66


using com.citrix.netscaler.nitro.exception;
using com.citrix.netscaler.nitro.resource.Base;
using com.citrix.netscaler.nitro.service;
using com.citrix.netscaler.nitro.util;

namespace com.citrix.netscaler.nitro.resource.config.basic
{
  public class service_lbmonitor_binding : base_resource
  {
    private string monitor_nameField = (string) null;
    private string monstateField = (string) null;
    private string monitor_stateField = (string) null;
    private string dup_stateField = (string) null;
    private uint? weightField = new uint?();
    private uint? dup_weightField = new uint?();
    private uint? totalprobesField = new uint?();
    private uint? totalfailedprobesField = new uint?();
    private uint? failedprobesField = new uint?();
    private int? monstatcodeField = new int?();
    private string lastresponseField = (string) null;
    private int? monstatparam1Field = new int?();
    private int? monstatparam2Field = new int?();
    private int? monstatparam3Field = new int?();
    private long? responsetimeField = new long?();
    private uint? monitortotalprobesField = new uint?();
    private uint? monitortotalfailedprobesField = new uint?();
    private uint? monitorcurrentfailedprobesField = new uint?();
    private bool? passiveField = new bool?();
    private string nameField = (string) null;
    private uint? __countField = new uint?();

    public uint? __count
    {
      get => this.__countField;
      set => this.__countField = value;
    }

    public uint? weight
    {
      get => this.weightField;
      set => this.weightField = value;
    }

    public string name
    {
      get => this.nameField;
      set => this.nameField = value;
    }

    public bool? passive
    {
      get => this.passiveField;
      set => this.passiveField = value;
    }

    public string monitor_name
    {
      get => this.monitor_nameField;
      set => this.monitor_nameField = value;
    }

    public string monstate
    {
      get => this.monstateField;
      set => this.monstateField = value;
    }

    public int? monstatcode
    {
      get => this.monstatcodeField;
      private set => this.monstatcodeField = value;
    }

    public uint? dup_weight
    {
      get => this.dup_weightField;
      private set => this.dup_weightField = value;
    }

    public long? responsetime
    {
      get => this.responsetimeField;
      private set => this.responsetimeField = value;
    }

    public uint? totalfailedprobes
    {
      get => this.totalfailedprobesField;
      private set => this.totalfailedprobesField = value;
    }

    public int? monstatparam2
    {
      get => this.monstatparam2Field;
      private set => this.monstatparam2Field = value;
    }

    public string lastresponse
    {
      get => this.lastresponseField;
      private set => this.lastresponseField = value;
    }

    public uint? failedprobes
    {
      get => this.failedprobesField;
      private set => this.failedprobesField = value;
    }

    public int? monstatparam3
    {
      get => this.monstatparam3Field;
      private set => this.monstatparam3Field = value;
    }

    public uint? totalprobes
    {
      get => this.totalprobesField;
      private set => this.totalprobesField = value;
    }

    public string monitor_state
    {
      get => this.monitor_stateField;
      private set => this.monitor_stateField = value;
    }

    public string dup_state
    {
      get => this.dup_stateField;
      private set => this.dup_stateField = value;
    }

    public uint? monitortotalprobes
    {
      get => this.monitortotalprobesField;
      private set => this.monitortotalprobesField = value;
    }

    public int? monstatparam1
    {
      get => this.monstatparam1Field;
      private set => this.monstatparam1Field = value;
    }

    public uint? monitortotalfailedprobes
    {
      get => this.monitortotalfailedprobesField;
      private set => this.monitortotalfailedprobesField = value;
    }

    public uint? monitorcurrentfailedprobes
    {
      get => this.monitorcurrentfailedprobesField;
      private set => this.monitorcurrentfailedprobesField = value;
    }

    internal override base_resource[] get_nitro_response(
      nitro_service service,
      string response)
    {
      service_lbmonitor_binding.service_lbmonitor_binding_response lbmonitorBindingResponse = new service_lbmonitor_binding.service_lbmonitor_binding_response();
      service_lbmonitor_binding.service_lbmonitor_binding_response resource = (service_lbmonitor_binding.service_lbmonitor_binding_response) service.get_payload_formatter().string_to_resource(lbmonitorBindingResponse.GetType(), response);
      if (resource.errorcode != 0)
      {
        if (resource.errorcode == 444)
          service.clear_session();
        if (resource.severity == null)
          throw new nitro_exception(resource.message, resource.errorcode);
        if (resource.severity.Equals("ERROR"))
          throw new nitro_exception(resource.message, resource.errorcode);
      }
      return (base_resource[]) resource.service_lbmonitor_binding;
    }

    internal override string get_object_name() => this.name;

    public static base_response add(
      nitro_service client,
      service_lbmonitor_binding resource)
    {
      return new service_lbmonitor_binding()
      {
        name = resource.name,
        monitor_name = resource.monitor_name,
        monstate = resource.monstate,
        weight = resource.weight,
        passive = resource.passive
      }.update_resource(client);
    }

    public static base_responses add(
      nitro_service client,
      service_lbmonitor_binding[] resources)
    {
      base_responses baseResponses = (base_responses) null;
      if (resources != null && resources.Length > 0)
      {
        service_lbmonitor_binding[] lbmonitorBindingArray = new service_lbmonitor_binding[resources.Length];
        for (int index = 0; index < resources.Length; ++index)
        {
          lbmonitorBindingArray[index] = new service_lbmonitor_binding();
          lbmonitorBindingArray[index].name = resources[index].name;
          lbmonitorBindingArray[index].monitor_name = resources[index].monitor_name;
          lbmonitorBindingArray[index].monstate = resources[index].monstate;
          lbmonitorBindingArray[index].weight = resources[index].weight;
          lbmonitorBindingArray[index].passive = resources[index].passive;
        }
        baseResponses = base_resource.update_bulk_request(client, (base_resource[]) lbmonitorBindingArray);
      }
      return baseResponses;
    }

    public static base_response delete(
      nitro_service client,
      service_lbmonitor_binding resource)
    {
      return new service_lbmonitor_binding()
      {
        name = resource.name,
        monitor_name = resource.monitor_name
      }.delete_resource(client);
    }

    public static base_responses delete(
      nitro_service client,
      service_lbmonitor_binding[] resources)
    {
      base_responses baseResponses = (base_responses) null;
      if (resources != null && resources.Length > 0)
      {
        service_lbmonitor_binding[] lbmonitorBindingArray = new service_lbmonitor_binding[resources.Length];
        for (int index = 0; index < resources.Length; ++index)
        {
          lbmonitorBindingArray[index] = new service_lbmonitor_binding();
          lbmonitorBindingArray[index].name = resources[index].name;
          lbmonitorBindingArray[index].monitor_name = resources[index].monitor_name;
        }
        baseResponses = base_resource.delete_bulk_request(client, (base_resource[]) lbmonitorBindingArray);
      }
      return baseResponses;
    }

    public static service_lbmonitor_binding[] get(
      nitro_service service,
      string name)
    {
      return (service_lbmonitor_binding[]) new service_lbmonitor_binding()
      {
        name = name
      }.get_resources(service, (options) null);
    }

    public static service_lbmonitor_binding[] get_filtered(
      nitro_service service,
      string name,
      string filter)
    {
      service_lbmonitor_binding lbmonitorBinding = new service_lbmonitor_binding();
      lbmonitorBinding.name = name;
      options option = new options();
      option.set_filter(filter);
      return (service_lbmonitor_binding[]) lbmonitorBinding.getfiltered(service, option);
    }

    public static service_lbmonitor_binding[] get_filtered(
      nitro_service service,
      string name,
      filtervalue[] filter)
    {
      service_lbmonitor_binding lbmonitorBinding = new service_lbmonitor_binding();
      lbmonitorBinding.name = name;
      options option = new options();
      option.set_filter(filter);
      return (service_lbmonitor_binding[]) lbmonitorBinding.getfiltered(service, option);
    }

    public static uint count(nitro_service service, string name)
    {
      service_lbmonitor_binding lbmonitorBinding = new service_lbmonitor_binding();
      lbmonitorBinding.name = name;
      options option = new options();
      option.set_count(true);
      service_lbmonitor_binding[] resources = (service_lbmonitor_binding[]) lbmonitorBinding.get_resources(service, option);
      return resources != null && resources.Length > 0 ? resources[0].__count.Value : 0U;
    }

    public static uint count_filtered(nitro_service service, string name, string filter)
    {
      service_lbmonitor_binding lbmonitorBinding = new service_lbmonitor_binding();
      lbmonitorBinding.name = name;
      options option = new options();
      option.set_count(true);
      option.set_filter(filter);
      service_lbmonitor_binding[] lbmonitorBindingArray = (service_lbmonitor_binding[]) lbmonitorBinding.getfiltered(service, option);
      return lbmonitorBindingArray != null && lbmonitorBindingArray.Length > 0 ? lbmonitorBindingArray[0].__count.Value : 0U;
    }

    public static uint count_filtered(nitro_service service, string name, filtervalue[] filter)
    {
      service_lbmonitor_binding lbmonitorBinding = new service_lbmonitor_binding();
      lbmonitorBinding.name = name;
      options option = new options();
      option.set_count(true);
      option.set_filter(filter);
      service_lbmonitor_binding[] lbmonitorBindingArray = (service_lbmonitor_binding[]) lbmonitorBinding.getfiltered(service, option);
      return lbmonitorBindingArray != null && lbmonitorBindingArray.Length > 0 ? lbmonitorBindingArray[0].__count.Value : 0U;
    }

    private class service_lbmonitor_binding_response : base_response
    {
      public service_lbmonitor_binding[] service_lbmonitor_binding = (service_lbmonitor_binding[]) null;
    }

    public static class monitor_stateEnum
    {
      public const string UP = "UP";
      public const string DOWN = "DOWN";
      public const string UNKNOWN = "UNKNOWN";
      public const string BUSY = "BUSY";
      public const string OUT_OF_SERVICE = "OUT OF SERVICE";
      public const string GOING_OUT_OF_SERVICE = "GOING OUT OF SERVICE";
      public const string DOWN_WHEN_GOING_OUT_OF_SERVICE = "DOWN WHEN GOING OUT OF SERVICE";
      public const string NS_EMPTY_STR = "NS_EMPTY_STR";
      public const string Unknown = "Unknown";
      public const string DISABLED = "DISABLED";
    }

    public static class monstateEnum
    {
      public const string ENABLED = "ENABLED";
      public const string DISABLED = "DISABLED";
    }

    public static class dup_stateEnum
    {
      public const string ENABLED = "ENABLED";
      public const string DISABLED = "DISABLED";
    }
  }
}
