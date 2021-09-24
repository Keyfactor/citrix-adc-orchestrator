// Decompiled with JetBrains decompiler
// Type: com.citrix.netscaler.nitro.resource.config.vpn.vpnvserver_sharefileserver_binding
// Assembly: nitro, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 6CF5DDEF-E052-4F9D-953F-6644F8378A66


using com.citrix.netscaler.nitro.exception;
using com.citrix.netscaler.nitro.resource.Base;
using com.citrix.netscaler.nitro.service;
using com.citrix.netscaler.nitro.util;

namespace com.citrix.netscaler.nitro.resource.config.vpn
{
  public class vpnvserver_sharefileserver_binding : base_resource
  {
    private string sharefileField = (string) null;
    private uint? acttypeField = new uint?();
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

    public string sharefile
    {
      get => this.sharefileField;
      set => this.sharefileField = value;
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
      vpnvserver_sharefileserver_binding.vpnvserver_sharefileserver_binding_response sharefileserverBindingResponse = new vpnvserver_sharefileserver_binding.vpnvserver_sharefileserver_binding_response();
      vpnvserver_sharefileserver_binding.vpnvserver_sharefileserver_binding_response resource = (vpnvserver_sharefileserver_binding.vpnvserver_sharefileserver_binding_response) service.get_payload_formatter().string_to_resource(sharefileserverBindingResponse.GetType(), response);
      if (resource.errorcode != 0)
      {
        if (resource.errorcode == 444)
          service.clear_session();
        if (resource.severity == null)
          throw new nitro_exception(resource.message, resource.errorcode);
        if (resource.severity.Equals("ERROR"))
          throw new nitro_exception(resource.message, resource.errorcode);
      }
      return (base_resource[]) resource.vpnvserver_sharefileserver_binding;
    }

    internal override string get_object_name() => this.name;

    public static base_response add(
      nitro_service client,
      vpnvserver_sharefileserver_binding resource)
    {
      return new vpnvserver_sharefileserver_binding()
      {
        name = resource.name,
        sharefile = resource.sharefile
      }.update_resource(client);
    }

    public static base_responses add(
      nitro_service client,
      vpnvserver_sharefileserver_binding[] resources)
    {
      base_responses baseResponses = (base_responses) null;
      if (resources != null && resources.Length > 0)
      {
        vpnvserver_sharefileserver_binding[] sharefileserverBindingArray = new vpnvserver_sharefileserver_binding[resources.Length];
        for (int index = 0; index < resources.Length; ++index)
        {
          sharefileserverBindingArray[index] = new vpnvserver_sharefileserver_binding();
          sharefileserverBindingArray[index].name = resources[index].name;
          sharefileserverBindingArray[index].sharefile = resources[index].sharefile;
        }
        baseResponses = base_resource.update_bulk_request(client, (base_resource[]) sharefileserverBindingArray);
      }
      return baseResponses;
    }

    public static base_response delete(
      nitro_service client,
      vpnvserver_sharefileserver_binding resource)
    {
      return new vpnvserver_sharefileserver_binding()
      {
        name = resource.name,
        sharefile = resource.sharefile
      }.delete_resource(client);
    }

    public static base_responses delete(
      nitro_service client,
      vpnvserver_sharefileserver_binding[] resources)
    {
      base_responses baseResponses = (base_responses) null;
      if (resources != null && resources.Length > 0)
      {
        vpnvserver_sharefileserver_binding[] sharefileserverBindingArray = new vpnvserver_sharefileserver_binding[resources.Length];
        for (int index = 0; index < resources.Length; ++index)
        {
          sharefileserverBindingArray[index] = new vpnvserver_sharefileserver_binding();
          sharefileserverBindingArray[index].name = resources[index].name;
          sharefileserverBindingArray[index].sharefile = resources[index].sharefile;
        }
        baseResponses = base_resource.delete_bulk_request(client, (base_resource[]) sharefileserverBindingArray);
      }
      return baseResponses;
    }

    public static vpnvserver_sharefileserver_binding[] get(
      nitro_service service,
      string name)
    {
      return (vpnvserver_sharefileserver_binding[]) new vpnvserver_sharefileserver_binding()
      {
        name = name
      }.get_resources(service, (options) null);
    }

    public static vpnvserver_sharefileserver_binding[] get_filtered(
      nitro_service service,
      string name,
      string filter)
    {
      vpnvserver_sharefileserver_binding sharefileserverBinding = new vpnvserver_sharefileserver_binding();
      sharefileserverBinding.name = name;
      options option = new options();
      option.set_filter(filter);
      return (vpnvserver_sharefileserver_binding[]) sharefileserverBinding.getfiltered(service, option);
    }

    public static vpnvserver_sharefileserver_binding[] get_filtered(
      nitro_service service,
      string name,
      filtervalue[] filter)
    {
      vpnvserver_sharefileserver_binding sharefileserverBinding = new vpnvserver_sharefileserver_binding();
      sharefileserverBinding.name = name;
      options option = new options();
      option.set_filter(filter);
      return (vpnvserver_sharefileserver_binding[]) sharefileserverBinding.getfiltered(service, option);
    }

    public static uint count(nitro_service service, string name)
    {
      vpnvserver_sharefileserver_binding sharefileserverBinding = new vpnvserver_sharefileserver_binding();
      sharefileserverBinding.name = name;
      options option = new options();
      option.set_count(true);
      vpnvserver_sharefileserver_binding[] resources = (vpnvserver_sharefileserver_binding[]) sharefileserverBinding.get_resources(service, option);
      return resources != null && resources.Length > 0 ? resources[0].__count.Value : 0U;
    }

    public static uint count_filtered(nitro_service service, string name, string filter)
    {
      vpnvserver_sharefileserver_binding sharefileserverBinding = new vpnvserver_sharefileserver_binding();
      sharefileserverBinding.name = name;
      options option = new options();
      option.set_count(true);
      option.set_filter(filter);
      vpnvserver_sharefileserver_binding[] sharefileserverBindingArray = (vpnvserver_sharefileserver_binding[]) sharefileserverBinding.getfiltered(service, option);
      return sharefileserverBindingArray != null && sharefileserverBindingArray.Length > 0 ? sharefileserverBindingArray[0].__count.Value : 0U;
    }

    public static uint count_filtered(nitro_service service, string name, filtervalue[] filter)
    {
      vpnvserver_sharefileserver_binding sharefileserverBinding = new vpnvserver_sharefileserver_binding();
      sharefileserverBinding.name = name;
      options option = new options();
      option.set_count(true);
      option.set_filter(filter);
      vpnvserver_sharefileserver_binding[] sharefileserverBindingArray = (vpnvserver_sharefileserver_binding[]) sharefileserverBinding.getfiltered(service, option);
      return sharefileserverBindingArray != null && sharefileserverBindingArray.Length > 0 ? sharefileserverBindingArray[0].__count.Value : 0U;
    }

    private class vpnvserver_sharefileserver_binding_response : base_response
    {
      public vpnvserver_sharefileserver_binding[] vpnvserver_sharefileserver_binding = (vpnvserver_sharefileserver_binding[]) null;
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
