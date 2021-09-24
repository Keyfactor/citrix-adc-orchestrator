// Decompiled with JetBrains decompiler
// Type: com.citrix.netscaler.nitro.resource.config.gslb.gslbservice_lbmonitor_binding
// Assembly: nitro, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 6CF5DDEF-E052-4F9D-953F-6644F8378A66


using com.citrix.netscaler.nitro.exception;
using com.citrix.netscaler.nitro.resource.Base;
using com.citrix.netscaler.nitro.service;
using com.citrix.netscaler.nitro.util;

namespace com.citrix.netscaler.nitro.resource.config.gslb
{
  public class gslbservice_lbmonitor_binding : base_resource
  {
    private string monitor_nameField = (string) null;
    private string monstateField = (string) null;
    private string monitor_stateField = (string) null;
    private uint? weightField = new uint?();
    private uint? totalfailedprobesField = new uint?();
    private uint? failedprobesField = new uint?();
    private int? monstatcodeField = new int?();
    private int? monstatparam1Field = new int?();
    private int? monstatparam2Field = new int?();
    private int? monstatparam3Field = new int?();
    private long? responsetimeField = new long?();
    private uint? monitortotalprobesField = new uint?();
    private uint? monitortotalfailedprobesField = new uint?();
    private uint? monitorcurrentfailedprobesField = new uint?();
    private string servicenameField = (string) null;
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

    public string servicename
    {
      get => this.servicenameField;
      set => this.servicenameField = value;
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

    public string monitor_state
    {
      get => this.monitor_stateField;
      private set => this.monitor_stateField = value;
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
      gslbservice_lbmonitor_binding.gslbservice_lbmonitor_binding_response lbmonitorBindingResponse = new gslbservice_lbmonitor_binding.gslbservice_lbmonitor_binding_response();
      gslbservice_lbmonitor_binding.gslbservice_lbmonitor_binding_response resource = (gslbservice_lbmonitor_binding.gslbservice_lbmonitor_binding_response) service.get_payload_formatter().string_to_resource(lbmonitorBindingResponse.GetType(), response);
      if (resource.errorcode != 0)
      {
        if (resource.errorcode == 444)
          service.clear_session();
        if (resource.severity == null)
          throw new nitro_exception(resource.message, resource.errorcode);
        if (resource.severity.Equals("ERROR"))
          throw new nitro_exception(resource.message, resource.errorcode);
      }
      return (base_resource[]) resource.gslbservice_lbmonitor_binding;
    }

    internal override string get_object_name() => this.servicename;

    public static base_response add(
      nitro_service client,
      gslbservice_lbmonitor_binding resource)
    {
      return new gslbservice_lbmonitor_binding()
      {
        servicename = resource.servicename,
        monitor_name = resource.monitor_name,
        monstate = resource.monstate,
        weight = resource.weight
      }.update_resource(client);
    }

    public static base_responses add(
      nitro_service client,
      gslbservice_lbmonitor_binding[] resources)
    {
      base_responses baseResponses = (base_responses) null;
      if (resources != null && resources.Length > 0)
      {
        gslbservice_lbmonitor_binding[] lbmonitorBindingArray = new gslbservice_lbmonitor_binding[resources.Length];
        for (int index = 0; index < resources.Length; ++index)
        {
          lbmonitorBindingArray[index] = new gslbservice_lbmonitor_binding();
          lbmonitorBindingArray[index].servicename = resources[index].servicename;
          lbmonitorBindingArray[index].monitor_name = resources[index].monitor_name;
          lbmonitorBindingArray[index].monstate = resources[index].monstate;
          lbmonitorBindingArray[index].weight = resources[index].weight;
        }
        baseResponses = base_resource.update_bulk_request(client, (base_resource[]) lbmonitorBindingArray);
      }
      return baseResponses;
    }

    public static base_response delete(
      nitro_service client,
      gslbservice_lbmonitor_binding resource)
    {
      return new gslbservice_lbmonitor_binding()
      {
        servicename = resource.servicename,
        monitor_name = resource.monitor_name
      }.delete_resource(client);
    }

    public static base_responses delete(
      nitro_service client,
      gslbservice_lbmonitor_binding[] resources)
    {
      base_responses baseResponses = (base_responses) null;
      if (resources != null && resources.Length > 0)
      {
        gslbservice_lbmonitor_binding[] lbmonitorBindingArray = new gslbservice_lbmonitor_binding[resources.Length];
        for (int index = 0; index < resources.Length; ++index)
        {
          lbmonitorBindingArray[index] = new gslbservice_lbmonitor_binding();
          lbmonitorBindingArray[index].servicename = resources[index].servicename;
          lbmonitorBindingArray[index].monitor_name = resources[index].monitor_name;
        }
        baseResponses = base_resource.delete_bulk_request(client, (base_resource[]) lbmonitorBindingArray);
      }
      return baseResponses;
    }

    public static gslbservice_lbmonitor_binding[] get(
      nitro_service service,
      string servicename)
    {
      return (gslbservice_lbmonitor_binding[]) new gslbservice_lbmonitor_binding()
      {
        servicename = servicename
      }.get_resources(service, (options) null);
    }

    public static gslbservice_lbmonitor_binding[] get_filtered(
      nitro_service service,
      string servicename,
      string filter)
    {
      gslbservice_lbmonitor_binding lbmonitorBinding = new gslbservice_lbmonitor_binding();
      lbmonitorBinding.servicename = servicename;
      options option = new options();
      option.set_filter(filter);
      return (gslbservice_lbmonitor_binding[]) lbmonitorBinding.getfiltered(service, option);
    }

    public static gslbservice_lbmonitor_binding[] get_filtered(
      nitro_service service,
      string servicename,
      filtervalue[] filter)
    {
      gslbservice_lbmonitor_binding lbmonitorBinding = new gslbservice_lbmonitor_binding();
      lbmonitorBinding.servicename = servicename;
      options option = new options();
      option.set_filter(filter);
      return (gslbservice_lbmonitor_binding[]) lbmonitorBinding.getfiltered(service, option);
    }

    public static uint count(nitro_service service, string servicename)
    {
      gslbservice_lbmonitor_binding lbmonitorBinding = new gslbservice_lbmonitor_binding();
      lbmonitorBinding.servicename = servicename;
      options option = new options();
      option.set_count(true);
      gslbservice_lbmonitor_binding[] resources = (gslbservice_lbmonitor_binding[]) lbmonitorBinding.get_resources(service, option);
      return resources != null && resources.Length > 0 ? resources[0].__count.Value : 0U;
    }

    public static uint count_filtered(nitro_service service, string servicename, string filter)
    {
      gslbservice_lbmonitor_binding lbmonitorBinding = new gslbservice_lbmonitor_binding();
      lbmonitorBinding.servicename = servicename;
      options option = new options();
      option.set_count(true);
      option.set_filter(filter);
      gslbservice_lbmonitor_binding[] lbmonitorBindingArray = (gslbservice_lbmonitor_binding[]) lbmonitorBinding.getfiltered(service, option);
      return lbmonitorBindingArray != null && lbmonitorBindingArray.Length > 0 ? lbmonitorBindingArray[0].__count.Value : 0U;
    }

    public static uint count_filtered(
      nitro_service service,
      string servicename,
      filtervalue[] filter)
    {
      gslbservice_lbmonitor_binding lbmonitorBinding = new gslbservice_lbmonitor_binding();
      lbmonitorBinding.servicename = servicename;
      options option = new options();
      option.set_count(true);
      option.set_filter(filter);
      gslbservice_lbmonitor_binding[] lbmonitorBindingArray = (gslbservice_lbmonitor_binding[]) lbmonitorBinding.getfiltered(service, option);
      return lbmonitorBindingArray != null && lbmonitorBindingArray.Length > 0 ? lbmonitorBindingArray[0].__count.Value : 0U;
    }

    private class gslbservice_lbmonitor_binding_response : base_response
    {
      public gslbservice_lbmonitor_binding[] gslbservice_lbmonitor_binding = (gslbservice_lbmonitor_binding[]) null;
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
  }
}
