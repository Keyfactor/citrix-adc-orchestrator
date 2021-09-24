// Decompiled with JetBrains decompiler
// Type: com.citrix.netscaler.nitro.resource.config.vpn.vpntrafficpolicy_vpnvserver_binding
// Assembly: nitro, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 6CF5DDEF-E052-4F9D-953F-6644F8378A66


using com.citrix.netscaler.nitro.exception;
using com.citrix.netscaler.nitro.resource.Base;
using com.citrix.netscaler.nitro.service;
using com.citrix.netscaler.nitro.util;

namespace com.citrix.netscaler.nitro.resource.config.vpn
{
  public class vpntrafficpolicy_vpnvserver_binding : base_resource
  {
    private string boundtoField = (string) null;
    private uint? priorityField = new uint?();
    private uint? activepolicyField = new uint?();
    private string nameField = (string) null;
    private uint? __countField = new uint?();

    public uint? __count
    {
      get => this.__countField;
      set => this.__countField = value;
    }

    public string name
    {
      get => this.nameField;
      set => this.nameField = value;
    }

    public string boundto
    {
      get => this.boundtoField;
      set => this.boundtoField = value;
    }

    public uint? priority
    {
      get => this.priorityField;
      private set => this.priorityField = value;
    }

    public uint? activepolicy
    {
      get => this.activepolicyField;
      private set => this.activepolicyField = value;
    }

    internal override base_resource[] get_nitro_response(
      nitro_service service,
      string response)
    {
      vpntrafficpolicy_vpnvserver_binding.vpntrafficpolicy_vpnvserver_binding_response vpnvserverBindingResponse = new vpntrafficpolicy_vpnvserver_binding.vpntrafficpolicy_vpnvserver_binding_response();
      vpntrafficpolicy_vpnvserver_binding.vpntrafficpolicy_vpnvserver_binding_response resource = (vpntrafficpolicy_vpnvserver_binding.vpntrafficpolicy_vpnvserver_binding_response) service.get_payload_formatter().string_to_resource(vpnvserverBindingResponse.GetType(), response);
      if (resource.errorcode != 0)
      {
        if (resource.errorcode == 444)
          service.clear_session();
        if (resource.severity == null)
          throw new nitro_exception(resource.message, resource.errorcode);
        if (resource.severity.Equals("ERROR"))
          throw new nitro_exception(resource.message, resource.errorcode);
      }
      return (base_resource[]) resource.vpntrafficpolicy_vpnvserver_binding;
    }

    internal override string get_object_name() => this.name;

    public static vpntrafficpolicy_vpnvserver_binding[] get(
      nitro_service service,
      string name)
    {
      return (vpntrafficpolicy_vpnvserver_binding[]) new vpntrafficpolicy_vpnvserver_binding()
      {
        name = name
      }.get_resources(service, (options) null);
    }

    public static vpntrafficpolicy_vpnvserver_binding[] get_filtered(
      nitro_service service,
      string name,
      string filter)
    {
      vpntrafficpolicy_vpnvserver_binding vpnvserverBinding = new vpntrafficpolicy_vpnvserver_binding();
      vpnvserverBinding.name = name;
      options option = new options();
      option.set_filter(filter);
      return (vpntrafficpolicy_vpnvserver_binding[]) vpnvserverBinding.getfiltered(service, option);
    }

    public static vpntrafficpolicy_vpnvserver_binding[] get_filtered(
      nitro_service service,
      string name,
      filtervalue[] filter)
    {
      vpntrafficpolicy_vpnvserver_binding vpnvserverBinding = new vpntrafficpolicy_vpnvserver_binding();
      vpnvserverBinding.name = name;
      options option = new options();
      option.set_filter(filter);
      return (vpntrafficpolicy_vpnvserver_binding[]) vpnvserverBinding.getfiltered(service, option);
    }

    public static uint count(nitro_service service, string name)
    {
      vpntrafficpolicy_vpnvserver_binding vpnvserverBinding = new vpntrafficpolicy_vpnvserver_binding();
      vpnvserverBinding.name = name;
      options option = new options();
      option.set_count(true);
      vpntrafficpolicy_vpnvserver_binding[] resources = (vpntrafficpolicy_vpnvserver_binding[]) vpnvserverBinding.get_resources(service, option);
      return resources != null && resources.Length > 0 ? resources[0].__count.Value : 0U;
    }

    public static uint count_filtered(nitro_service service, string name, string filter)
    {
      vpntrafficpolicy_vpnvserver_binding vpnvserverBinding = new vpntrafficpolicy_vpnvserver_binding();
      vpnvserverBinding.name = name;
      options option = new options();
      option.set_count(true);
      option.set_filter(filter);
      vpntrafficpolicy_vpnvserver_binding[] vpnvserverBindingArray = (vpntrafficpolicy_vpnvserver_binding[]) vpnvserverBinding.getfiltered(service, option);
      return vpnvserverBindingArray != null && vpnvserverBindingArray.Length > 0 ? vpnvserverBindingArray[0].__count.Value : 0U;
    }

    public static uint count_filtered(nitro_service service, string name, filtervalue[] filter)
    {
      vpntrafficpolicy_vpnvserver_binding vpnvserverBinding = new vpntrafficpolicy_vpnvserver_binding();
      vpnvserverBinding.name = name;
      options option = new options();
      option.set_count(true);
      option.set_filter(filter);
      vpntrafficpolicy_vpnvserver_binding[] vpnvserverBindingArray = (vpntrafficpolicy_vpnvserver_binding[]) vpnvserverBinding.getfiltered(service, option);
      return vpnvserverBindingArray != null && vpnvserverBindingArray.Length > 0 ? vpnvserverBindingArray[0].__count.Value : 0U;
    }

    private class vpntrafficpolicy_vpnvserver_binding_response : base_response
    {
      public vpntrafficpolicy_vpnvserver_binding[] vpntrafficpolicy_vpnvserver_binding = (vpntrafficpolicy_vpnvserver_binding[]) null;
    }
  }
}
