// Decompiled with JetBrains decompiler
// Type: com.citrix.netscaler.nitro.resource.config.wi.wisite_accessmethod_binding
// Assembly: nitro, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 6CF5DDEF-E052-4F9D-953F-6644F8378A66


using com.citrix.netscaler.nitro.exception;
using com.citrix.netscaler.nitro.resource.Base;
using com.citrix.netscaler.nitro.service;
using com.citrix.netscaler.nitro.util;

namespace com.citrix.netscaler.nitro.resource.config.wi
{
  public class wisite_accessmethod_binding : base_resource
  {
    private string accessmethodField = (string) null;
    private string clientipaddressField = (string) null;
    private string clientnetmaskField = (string) null;
    private string sitepathField = (string) null;
    private uint? __countField = new uint?();

    public uint? __count
    {
      get => this.__countField;
      set => this.__countField = value;
    }

    public string clientipaddress
    {
      get => this.clientipaddressField;
      set => this.clientipaddressField = value;
    }

    public string clientnetmask
    {
      get => this.clientnetmaskField;
      set => this.clientnetmaskField = value;
    }

    public string accessmethod
    {
      get => this.accessmethodField;
      set => this.accessmethodField = value;
    }

    public string sitepath
    {
      get => this.sitepathField;
      set => this.sitepathField = value;
    }

    internal override base_resource[] get_nitro_response(
      nitro_service service,
      string response)
    {
      wisite_accessmethod_binding.wisite_accessmethod_binding_response accessmethodBindingResponse = new wisite_accessmethod_binding.wisite_accessmethod_binding_response();
      wisite_accessmethod_binding.wisite_accessmethod_binding_response resource = (wisite_accessmethod_binding.wisite_accessmethod_binding_response) service.get_payload_formatter().string_to_resource(accessmethodBindingResponse.GetType(), response);
      if (resource.errorcode != 0)
      {
        if (resource.errorcode == 444)
          service.clear_session();
        if (resource.severity == null)
          throw new nitro_exception(resource.message, resource.errorcode);
        if (resource.severity.Equals("ERROR"))
          throw new nitro_exception(resource.message, resource.errorcode);
      }
      return (base_resource[]) resource.wisite_accessmethod_binding;
    }

    internal override string get_object_name() => this.sitepath;

    public static base_response add(
      nitro_service client,
      wisite_accessmethod_binding resource)
    {
      return new wisite_accessmethod_binding()
      {
        sitepath = resource.sitepath,
        accessmethod = resource.accessmethod,
        clientipaddress = resource.clientipaddress,
        clientnetmask = resource.clientnetmask
      }.update_resource(client);
    }

    public static base_responses add(
      nitro_service client,
      wisite_accessmethod_binding[] resources)
    {
      base_responses baseResponses = (base_responses) null;
      if (resources != null && resources.Length > 0)
      {
        wisite_accessmethod_binding[] accessmethodBindingArray = new wisite_accessmethod_binding[resources.Length];
        for (int index = 0; index < resources.Length; ++index)
        {
          accessmethodBindingArray[index] = new wisite_accessmethod_binding();
          accessmethodBindingArray[index].sitepath = resources[index].sitepath;
          accessmethodBindingArray[index].accessmethod = resources[index].accessmethod;
          accessmethodBindingArray[index].clientipaddress = resources[index].clientipaddress;
          accessmethodBindingArray[index].clientnetmask = resources[index].clientnetmask;
        }
        baseResponses = base_resource.update_bulk_request(client, (base_resource[]) accessmethodBindingArray);
      }
      return baseResponses;
    }

    public static base_response delete(
      nitro_service client,
      wisite_accessmethod_binding resource)
    {
      return new wisite_accessmethod_binding()
      {
        sitepath = resource.sitepath,
        clientipaddress = resource.clientipaddress,
        clientnetmask = resource.clientnetmask
      }.delete_resource(client);
    }

    public static base_responses delete(
      nitro_service client,
      wisite_accessmethod_binding[] resources)
    {
      base_responses baseResponses = (base_responses) null;
      if (resources != null && resources.Length > 0)
      {
        wisite_accessmethod_binding[] accessmethodBindingArray = new wisite_accessmethod_binding[resources.Length];
        for (int index = 0; index < resources.Length; ++index)
        {
          accessmethodBindingArray[index] = new wisite_accessmethod_binding();
          accessmethodBindingArray[index].sitepath = resources[index].sitepath;
          accessmethodBindingArray[index].clientipaddress = resources[index].clientipaddress;
          accessmethodBindingArray[index].clientnetmask = resources[index].clientnetmask;
        }
        baseResponses = base_resource.delete_bulk_request(client, (base_resource[]) accessmethodBindingArray);
      }
      return baseResponses;
    }

    public static wisite_accessmethod_binding[] get(
      nitro_service service,
      string sitepath)
    {
      return (wisite_accessmethod_binding[]) new wisite_accessmethod_binding()
      {
        sitepath = sitepath
      }.get_resources(service, (options) null);
    }

    public static wisite_accessmethod_binding[] get_filtered(
      nitro_service service,
      string sitepath,
      string filter)
    {
      wisite_accessmethod_binding accessmethodBinding = new wisite_accessmethod_binding();
      accessmethodBinding.sitepath = sitepath;
      options option = new options();
      option.set_filter(filter);
      return (wisite_accessmethod_binding[]) accessmethodBinding.getfiltered(service, option);
    }

    public static wisite_accessmethod_binding[] get_filtered(
      nitro_service service,
      string sitepath,
      filtervalue[] filter)
    {
      wisite_accessmethod_binding accessmethodBinding = new wisite_accessmethod_binding();
      accessmethodBinding.sitepath = sitepath;
      options option = new options();
      option.set_filter(filter);
      return (wisite_accessmethod_binding[]) accessmethodBinding.getfiltered(service, option);
    }

    public static uint count(nitro_service service, string sitepath)
    {
      wisite_accessmethod_binding accessmethodBinding = new wisite_accessmethod_binding();
      accessmethodBinding.sitepath = sitepath;
      options option = new options();
      option.set_count(true);
      wisite_accessmethod_binding[] resources = (wisite_accessmethod_binding[]) accessmethodBinding.get_resources(service, option);
      return resources != null && resources.Length > 0 ? resources[0].__count.Value : 0U;
    }

    public static uint count_filtered(nitro_service service, string sitepath, string filter)
    {
      wisite_accessmethod_binding accessmethodBinding = new wisite_accessmethod_binding();
      accessmethodBinding.sitepath = sitepath;
      options option = new options();
      option.set_count(true);
      option.set_filter(filter);
      wisite_accessmethod_binding[] accessmethodBindingArray = (wisite_accessmethod_binding[]) accessmethodBinding.getfiltered(service, option);
      return accessmethodBindingArray != null && accessmethodBindingArray.Length > 0 ? accessmethodBindingArray[0].__count.Value : 0U;
    }

    public static uint count_filtered(nitro_service service, string sitepath, filtervalue[] filter)
    {
      wisite_accessmethod_binding accessmethodBinding = new wisite_accessmethod_binding();
      accessmethodBinding.sitepath = sitepath;
      options option = new options();
      option.set_count(true);
      option.set_filter(filter);
      wisite_accessmethod_binding[] accessmethodBindingArray = (wisite_accessmethod_binding[]) accessmethodBinding.getfiltered(service, option);
      return accessmethodBindingArray != null && accessmethodBindingArray.Length > 0 ? accessmethodBindingArray[0].__count.Value : 0U;
    }

    private class wisite_accessmethod_binding_response : base_response
    {
      public wisite_accessmethod_binding[] wisite_accessmethod_binding = (wisite_accessmethod_binding[]) null;
    }

    public static class accessmethodEnum
    {
      public const string Direct = "Direct";
      public const string Alternate = "Alternate";
      public const string Translated = "Translated";
      public const string GatewayDirect = "GatewayDirect";
      public const string GatewayAlternate = "GatewayAlternate";
      public const string GatewayTranslated = "GatewayTranslated";
    }

    public static class accesstypeEnum
    {
      public const string UserDevice = "UserDevice";
      public const string Gateway = "Gateway";
      public const string UserDeviceAndGateway = "UserDeviceAndGateway";
    }

    public static class transportEnum
    {
      public const string HTTP = "HTTP";
      public const string HTTPS = "HTTPS";
      public const string SSLRELAY = "SSLRELAY";
    }

    public static class loadbalanceEnum
    {
      public const string ON = "ON";
      public const string OFF = "OFF";
    }

    public static class recoveryfarmEnum
    {
      public const string ON = "ON";
      public const string OFF = "OFF";
    }
  }
}
