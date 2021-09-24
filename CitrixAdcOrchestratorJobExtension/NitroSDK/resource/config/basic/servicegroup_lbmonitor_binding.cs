// Decompiled with JetBrains decompiler
// Type: com.citrix.netscaler.nitro.resource.config.basic.servicegroup_lbmonitor_binding
// Assembly: nitro, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 6CF5DDEF-E052-4F9D-953F-6644F8378A66


using com.citrix.netscaler.nitro.exception;
using com.citrix.netscaler.nitro.resource.Base;
using com.citrix.netscaler.nitro.service;
using com.citrix.netscaler.nitro.util;

namespace com.citrix.netscaler.nitro.resource.config.basic
{
  public class servicegroup_lbmonitor_binding : base_resource
  {
    private string monitor_nameField = (string) null;
    private uint? monweightField = new uint?();
    private string monstateField = (string) null;
    private uint? weightField = new uint?();
    private bool? passiveField = new bool?();
    private string servicegroupnameField = (string) null;
    private ushort? portField = new ushort?();
    private string customserveridField = (string) null;
    private uint? serveridField = new uint?();
    private string stateField = (string) null;
    private uint? hashidField = new uint?();
    private uint? __countField = new uint?();

    public uint? __count
    {
      get => this.__countField;
      set => this.__countField = value;
    }

    public string servicegroupname
    {
      get => this.servicegroupnameField;
      set => this.servicegroupnameField = value;
    }

    public ushort? port
    {
      get => this.portField;
      set => this.portField = value;
    }

    public string state
    {
      get => this.stateField;
      set => this.stateField = value;
    }

    public uint? hashid
    {
      get => this.hashidField;
      set => this.hashidField = value;
    }

    public uint? serverid
    {
      get => this.serveridField;
      set => this.serveridField = value;
    }

    public string customserverid
    {
      get => this.customserveridField;
      set => this.customserveridField = value;
    }

    public uint? weight
    {
      get => this.weightField;
      set => this.weightField = value;
    }

    public string monitor_name
    {
      get => this.monitor_nameField;
      set => this.monitor_nameField = value;
    }

    public bool? passive
    {
      get => this.passiveField;
      set => this.passiveField = value;
    }

    public string monstate
    {
      get => this.monstateField;
      set => this.monstateField = value;
    }

    public uint? monweight
    {
      get => this.monweightField;
      private set => this.monweightField = value;
    }

    internal override base_resource[] get_nitro_response(
      nitro_service service,
      string response)
    {
      servicegroup_lbmonitor_binding.servicegroup_lbmonitor_binding_response lbmonitorBindingResponse = new servicegroup_lbmonitor_binding.servicegroup_lbmonitor_binding_response();
      servicegroup_lbmonitor_binding.servicegroup_lbmonitor_binding_response resource = (servicegroup_lbmonitor_binding.servicegroup_lbmonitor_binding_response) service.get_payload_formatter().string_to_resource(lbmonitorBindingResponse.GetType(), response);
      if (resource.errorcode != 0)
      {
        if (resource.errorcode == 444)
          service.clear_session();
        if (resource.severity == null)
          throw new nitro_exception(resource.message, resource.errorcode);
        if (resource.severity.Equals("ERROR"))
          throw new nitro_exception(resource.message, resource.errorcode);
      }
      return (base_resource[]) resource.servicegroup_lbmonitor_binding;
    }

    internal override string get_object_name() => this.servicegroupname;

    public static base_response add(
      nitro_service client,
      servicegroup_lbmonitor_binding resource)
    {
      return new servicegroup_lbmonitor_binding()
      {
        servicegroupname = resource.servicegroupname,
        port = resource.port,
        monitor_name = resource.monitor_name,
        monstate = resource.monstate,
        passive = resource.passive,
        weight = resource.weight,
        customserverid = resource.customserverid,
        serverid = resource.serverid,
        state = resource.state,
        hashid = resource.hashid
      }.update_resource(client);
    }

    public static base_responses add(
      nitro_service client,
      servicegroup_lbmonitor_binding[] resources)
    {
      base_responses baseResponses = (base_responses) null;
      if (resources != null && resources.Length > 0)
      {
        servicegroup_lbmonitor_binding[] lbmonitorBindingArray = new servicegroup_lbmonitor_binding[resources.Length];
        for (int index = 0; index < resources.Length; ++index)
        {
          lbmonitorBindingArray[index] = new servicegroup_lbmonitor_binding();
          lbmonitorBindingArray[index].servicegroupname = resources[index].servicegroupname;
          lbmonitorBindingArray[index].port = resources[index].port;
          lbmonitorBindingArray[index].monitor_name = resources[index].monitor_name;
          lbmonitorBindingArray[index].monstate = resources[index].monstate;
          lbmonitorBindingArray[index].passive = resources[index].passive;
          lbmonitorBindingArray[index].weight = resources[index].weight;
          lbmonitorBindingArray[index].customserverid = resources[index].customserverid;
          lbmonitorBindingArray[index].serverid = resources[index].serverid;
          lbmonitorBindingArray[index].state = resources[index].state;
          lbmonitorBindingArray[index].hashid = resources[index].hashid;
        }
        baseResponses = base_resource.update_bulk_request(client, (base_resource[]) lbmonitorBindingArray);
      }
      return baseResponses;
    }

    public static base_response delete(
      nitro_service client,
      servicegroup_lbmonitor_binding resource)
    {
      return new servicegroup_lbmonitor_binding()
      {
        servicegroupname = resource.servicegroupname,
        port = resource.port,
        monitor_name = resource.monitor_name
      }.delete_resource(client);
    }

    public static base_responses delete(
      nitro_service client,
      servicegroup_lbmonitor_binding[] resources)
    {
      base_responses baseResponses = (base_responses) null;
      if (resources != null && resources.Length > 0)
      {
        servicegroup_lbmonitor_binding[] lbmonitorBindingArray = new servicegroup_lbmonitor_binding[resources.Length];
        for (int index = 0; index < resources.Length; ++index)
        {
          lbmonitorBindingArray[index] = new servicegroup_lbmonitor_binding();
          lbmonitorBindingArray[index].servicegroupname = resources[index].servicegroupname;
          lbmonitorBindingArray[index].port = resources[index].port;
          lbmonitorBindingArray[index].monitor_name = resources[index].monitor_name;
        }
        baseResponses = base_resource.delete_bulk_request(client, (base_resource[]) lbmonitorBindingArray);
      }
      return baseResponses;
    }

    public static servicegroup_lbmonitor_binding[] get(
      nitro_service service,
      string servicegroupname)
    {
      return (servicegroup_lbmonitor_binding[]) new servicegroup_lbmonitor_binding()
      {
        servicegroupname = servicegroupname
      }.get_resources(service, (options) null);
    }

    public static servicegroup_lbmonitor_binding[] get_filtered(
      nitro_service service,
      string servicegroupname,
      string filter)
    {
      servicegroup_lbmonitor_binding lbmonitorBinding = new servicegroup_lbmonitor_binding();
      lbmonitorBinding.servicegroupname = servicegroupname;
      options option = new options();
      option.set_filter(filter);
      return (servicegroup_lbmonitor_binding[]) lbmonitorBinding.getfiltered(service, option);
    }

    public static servicegroup_lbmonitor_binding[] get_filtered(
      nitro_service service,
      string servicegroupname,
      filtervalue[] filter)
    {
      servicegroup_lbmonitor_binding lbmonitorBinding = new servicegroup_lbmonitor_binding();
      lbmonitorBinding.servicegroupname = servicegroupname;
      options option = new options();
      option.set_filter(filter);
      return (servicegroup_lbmonitor_binding[]) lbmonitorBinding.getfiltered(service, option);
    }

    public static uint count(nitro_service service, string servicegroupname)
    {
      servicegroup_lbmonitor_binding lbmonitorBinding = new servicegroup_lbmonitor_binding();
      lbmonitorBinding.servicegroupname = servicegroupname;
      options option = new options();
      option.set_count(true);
      servicegroup_lbmonitor_binding[] resources = (servicegroup_lbmonitor_binding[]) lbmonitorBinding.get_resources(service, option);
      return resources != null && resources.Length > 0 ? resources[0].__count.Value : 0U;
    }

    public static uint count_filtered(
      nitro_service service,
      string servicegroupname,
      string filter)
    {
      servicegroup_lbmonitor_binding lbmonitorBinding = new servicegroup_lbmonitor_binding();
      lbmonitorBinding.servicegroupname = servicegroupname;
      options option = new options();
      option.set_count(true);
      option.set_filter(filter);
      servicegroup_lbmonitor_binding[] lbmonitorBindingArray = (servicegroup_lbmonitor_binding[]) lbmonitorBinding.getfiltered(service, option);
      return lbmonitorBindingArray != null && lbmonitorBindingArray.Length > 0 ? lbmonitorBindingArray[0].__count.Value : 0U;
    }

    public static uint count_filtered(
      nitro_service service,
      string servicegroupname,
      filtervalue[] filter)
    {
      servicegroup_lbmonitor_binding lbmonitorBinding = new servicegroup_lbmonitor_binding();
      lbmonitorBinding.servicegroupname = servicegroupname;
      options option = new options();
      option.set_count(true);
      option.set_filter(filter);
      servicegroup_lbmonitor_binding[] lbmonitorBindingArray = (servicegroup_lbmonitor_binding[]) lbmonitorBinding.getfiltered(service, option);
      return lbmonitorBindingArray != null && lbmonitorBindingArray.Length > 0 ? lbmonitorBindingArray[0].__count.Value : 0U;
    }

    private class servicegroup_lbmonitor_binding_response : base_response
    {
      public servicegroup_lbmonitor_binding[] servicegroup_lbmonitor_binding = (servicegroup_lbmonitor_binding[]) null;
    }

    public static class stateEnum
    {
      public const string ENABLED = "ENABLED";
      public const string DISABLED = "DISABLED";
    }

    public static class monstateEnum
    {
      public const string ENABLED = "ENABLED";
      public const string DISABLED = "DISABLED";
    }
  }
}
