// Decompiled with JetBrains decompiler
// Type: com.citrix.netscaler.nitro.resource.config.vpn.vpnvserver_appcontroller_binding
// Assembly: nitro, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 6CF5DDEF-E052-4F9D-953F-6644F8378A66


using com.citrix.netscaler.nitro.exception;
using com.citrix.netscaler.nitro.resource.Base;
using com.citrix.netscaler.nitro.service;
using com.citrix.netscaler.nitro.util;

namespace com.citrix.netscaler.nitro.resource.config.vpn
{
  public class vpnvserver_appcontroller_binding : base_resource
  {
    private string appcontrollerField = (string) null;
    private uint? acttypeField = new uint?();
    private string nameField = (string) null;
    private uint? __countField = new uint?();

    public uint? __count
    {
      get => this.__countField;
      set => this.__countField = value;
    }

    public string appcontroller
    {
      get => this.appcontrollerField;
      set => this.appcontrollerField = value;
    }

    public string name
    {
      get => this.nameField;
      set => this.nameField = value;
    }

    public uint? acttype
    {
      get => this.acttypeField;
      private set => this.acttypeField = value;
    }

    internal override base_resource[] get_nitro_response(
      nitro_service service,
      string response)
    {
      vpnvserver_appcontroller_binding.vpnvserver_appcontroller_binding_response appcontrollerBindingResponse = new vpnvserver_appcontroller_binding.vpnvserver_appcontroller_binding_response();
      vpnvserver_appcontroller_binding.vpnvserver_appcontroller_binding_response resource = (vpnvserver_appcontroller_binding.vpnvserver_appcontroller_binding_response) service.get_payload_formatter().string_to_resource(appcontrollerBindingResponse.GetType(), response);
      if (resource.errorcode != 0)
      {
        if (resource.errorcode == 444)
          service.clear_session();
        if (resource.severity == null)
          throw new nitro_exception(resource.message, resource.errorcode);
        if (resource.severity.Equals("ERROR"))
          throw new nitro_exception(resource.message, resource.errorcode);
      }
      return (base_resource[]) resource.vpnvserver_appcontroller_binding;
    }

    internal override string get_object_name() => this.name;

    public static base_response add(
      nitro_service client,
      vpnvserver_appcontroller_binding resource)
    {
      return new vpnvserver_appcontroller_binding()
      {
        name = resource.name,
        appcontroller = resource.appcontroller
      }.update_resource(client);
    }

    public static base_responses add(
      nitro_service client,
      vpnvserver_appcontroller_binding[] resources)
    {
      base_responses baseResponses = (base_responses) null;
      if (resources != null && resources.Length > 0)
      {
        vpnvserver_appcontroller_binding[] appcontrollerBindingArray = new vpnvserver_appcontroller_binding[resources.Length];
        for (int index = 0; index < resources.Length; ++index)
        {
          appcontrollerBindingArray[index] = new vpnvserver_appcontroller_binding();
          appcontrollerBindingArray[index].name = resources[index].name;
          appcontrollerBindingArray[index].appcontroller = resources[index].appcontroller;
        }
        baseResponses = base_resource.update_bulk_request(client, (base_resource[]) appcontrollerBindingArray);
      }
      return baseResponses;
    }

    public static base_response delete(
      nitro_service client,
      vpnvserver_appcontroller_binding resource)
    {
      return new vpnvserver_appcontroller_binding()
      {
        name = resource.name,
        appcontroller = resource.appcontroller
      }.delete_resource(client);
    }

    public static base_responses delete(
      nitro_service client,
      vpnvserver_appcontroller_binding[] resources)
    {
      base_responses baseResponses = (base_responses) null;
      if (resources != null && resources.Length > 0)
      {
        vpnvserver_appcontroller_binding[] appcontrollerBindingArray = new vpnvserver_appcontroller_binding[resources.Length];
        for (int index = 0; index < resources.Length; ++index)
        {
          appcontrollerBindingArray[index] = new vpnvserver_appcontroller_binding();
          appcontrollerBindingArray[index].name = resources[index].name;
          appcontrollerBindingArray[index].appcontroller = resources[index].appcontroller;
        }
        baseResponses = base_resource.delete_bulk_request(client, (base_resource[]) appcontrollerBindingArray);
      }
      return baseResponses;
    }

    public static vpnvserver_appcontroller_binding[] get(
      nitro_service service,
      string name)
    {
      return (vpnvserver_appcontroller_binding[]) new vpnvserver_appcontroller_binding()
      {
        name = name
      }.get_resources(service, (options) null);
    }

    public static vpnvserver_appcontroller_binding[] get_filtered(
      nitro_service service,
      string name,
      string filter)
    {
      vpnvserver_appcontroller_binding appcontrollerBinding = new vpnvserver_appcontroller_binding();
      appcontrollerBinding.name = name;
      options option = new options();
      option.set_filter(filter);
      return (vpnvserver_appcontroller_binding[]) appcontrollerBinding.getfiltered(service, option);
    }

    public static vpnvserver_appcontroller_binding[] get_filtered(
      nitro_service service,
      string name,
      filtervalue[] filter)
    {
      vpnvserver_appcontroller_binding appcontrollerBinding = new vpnvserver_appcontroller_binding();
      appcontrollerBinding.name = name;
      options option = new options();
      option.set_filter(filter);
      return (vpnvserver_appcontroller_binding[]) appcontrollerBinding.getfiltered(service, option);
    }

    public static uint count(nitro_service service, string name)
    {
      vpnvserver_appcontroller_binding appcontrollerBinding = new vpnvserver_appcontroller_binding();
      appcontrollerBinding.name = name;
      options option = new options();
      option.set_count(true);
      vpnvserver_appcontroller_binding[] resources = (vpnvserver_appcontroller_binding[]) appcontrollerBinding.get_resources(service, option);
      return resources != null && resources.Length > 0 ? resources[0].__count.Value : 0U;
    }

    public static uint count_filtered(nitro_service service, string name, string filter)
    {
      vpnvserver_appcontroller_binding appcontrollerBinding = new vpnvserver_appcontroller_binding();
      appcontrollerBinding.name = name;
      options option = new options();
      option.set_count(true);
      option.set_filter(filter);
      vpnvserver_appcontroller_binding[] appcontrollerBindingArray = (vpnvserver_appcontroller_binding[]) appcontrollerBinding.getfiltered(service, option);
      return appcontrollerBindingArray != null && appcontrollerBindingArray.Length > 0 ? appcontrollerBindingArray[0].__count.Value : 0U;
    }

    public static uint count_filtered(nitro_service service, string name, filtervalue[] filter)
    {
      vpnvserver_appcontroller_binding appcontrollerBinding = new vpnvserver_appcontroller_binding();
      appcontrollerBinding.name = name;
      options option = new options();
      option.set_count(true);
      option.set_filter(filter);
      vpnvserver_appcontroller_binding[] appcontrollerBindingArray = (vpnvserver_appcontroller_binding[]) appcontrollerBinding.getfiltered(service, option);
      return appcontrollerBindingArray != null && appcontrollerBindingArray.Length > 0 ? appcontrollerBindingArray[0].__count.Value : 0U;
    }

    private class vpnvserver_appcontroller_binding_response : base_response
    {
      public vpnvserver_appcontroller_binding[] vpnvserver_appcontroller_binding = (vpnvserver_appcontroller_binding[]) null;
    }

    public static class staaddresstypeEnum
    {
      public const string IPV4 = "IPV4";
      public const string IPV6 = "IPV6";
    }

    public static class bindpointEnum
    {
      public const string REQUEST = "REQUEST";
      public const string RESPONSE = "RESPONSE";
      public const string ICA_REQUEST = "ICA_REQUEST";
      public const string OTHERTCP_REQUEST = "OTHERTCP_REQUEST";
    }
  }
}
