// Decompiled with JetBrains decompiler
// Type: com.citrix.netscaler.nitro.resource.config.wi.wisite_translationinternalip_binding
// Assembly: nitro, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 6CF5DDEF-E052-4F9D-953F-6644F8378A66


using com.citrix.netscaler.nitro.exception;
using com.citrix.netscaler.nitro.resource.Base;
using com.citrix.netscaler.nitro.service;
using com.citrix.netscaler.nitro.util;

namespace com.citrix.netscaler.nitro.resource.config.wi
{
  public class wisite_translationinternalip_binding : base_resource
  {
    private string translationinternalipField = (string) null;
    private string accesstypeField = (string) null;
    private ushort? translationinternalportField = new ushort?();
    private string translationexternalipField = (string) null;
    private ushort? translationexternalportField = new ushort?();
    private string sitepathField = (string) null;
    private uint? __countField = new uint?();

    public uint? __count
    {
      get => this.__countField;
      set => this.__countField = value;
    }

    public string sitepath
    {
      get => this.sitepathField;
      set => this.sitepathField = value;
    }

    public string accesstype
    {
      get => this.accesstypeField;
      set => this.accesstypeField = value;
    }

    public ushort? translationexternalport
    {
      get => this.translationexternalportField;
      set => this.translationexternalportField = value;
    }

    public string translationinternalip
    {
      get => this.translationinternalipField;
      set => this.translationinternalipField = value;
    }

    public string translationexternalip
    {
      get => this.translationexternalipField;
      set => this.translationexternalipField = value;
    }

    public ushort? translationinternalport
    {
      get => this.translationinternalportField;
      set => this.translationinternalportField = value;
    }

    internal override base_resource[] get_nitro_response(
      nitro_service service,
      string response)
    {
      wisite_translationinternalip_binding.wisite_translationinternalip_binding_response translationinternalipBindingResponse = new wisite_translationinternalip_binding.wisite_translationinternalip_binding_response();
      wisite_translationinternalip_binding.wisite_translationinternalip_binding_response resource = (wisite_translationinternalip_binding.wisite_translationinternalip_binding_response) service.get_payload_formatter().string_to_resource(translationinternalipBindingResponse.GetType(), response);
      if (resource.errorcode != 0)
      {
        if (resource.errorcode == 444)
          service.clear_session();
        if (resource.severity == null)
          throw new nitro_exception(resource.message, resource.errorcode);
        if (resource.severity.Equals("ERROR"))
          throw new nitro_exception(resource.message, resource.errorcode);
      }
      return (base_resource[]) resource.wisite_translationinternalip_binding;
    }

    internal override string get_object_name() => this.sitepath;

    public static base_response add(
      nitro_service client,
      wisite_translationinternalip_binding resource)
    {
      return new wisite_translationinternalip_binding()
      {
        sitepath = resource.sitepath,
        translationinternalip = resource.translationinternalip,
        translationinternalport = resource.translationinternalport,
        translationexternalip = resource.translationexternalip,
        translationexternalport = resource.translationexternalport,
        accesstype = resource.accesstype
      }.update_resource(client);
    }

    public static base_responses add(
      nitro_service client,
      wisite_translationinternalip_binding[] resources)
    {
      base_responses baseResponses = (base_responses) null;
      if (resources != null && resources.Length > 0)
      {
        wisite_translationinternalip_binding[] translationinternalipBindingArray = new wisite_translationinternalip_binding[resources.Length];
        for (int index = 0; index < resources.Length; ++index)
        {
          translationinternalipBindingArray[index] = new wisite_translationinternalip_binding();
          translationinternalipBindingArray[index].sitepath = resources[index].sitepath;
          translationinternalipBindingArray[index].translationinternalip = resources[index].translationinternalip;
          translationinternalipBindingArray[index].translationinternalport = resources[index].translationinternalport;
          translationinternalipBindingArray[index].translationexternalip = resources[index].translationexternalip;
          translationinternalipBindingArray[index].translationexternalport = resources[index].translationexternalport;
          translationinternalipBindingArray[index].accesstype = resources[index].accesstype;
        }
        baseResponses = base_resource.update_bulk_request(client, (base_resource[]) translationinternalipBindingArray);
      }
      return baseResponses;
    }

    public static base_response delete(
      nitro_service client,
      wisite_translationinternalip_binding resource)
    {
      return new wisite_translationinternalip_binding()
      {
        sitepath = resource.sitepath,
        translationinternalip = resource.translationinternalip,
        translationinternalport = resource.translationinternalport,
        translationexternalip = resource.translationexternalip,
        translationexternalport = resource.translationexternalport
      }.delete_resource(client);
    }

    public static base_responses delete(
      nitro_service client,
      wisite_translationinternalip_binding[] resources)
    {
      base_responses baseResponses = (base_responses) null;
      if (resources != null && resources.Length > 0)
      {
        wisite_translationinternalip_binding[] translationinternalipBindingArray = new wisite_translationinternalip_binding[resources.Length];
        for (int index = 0; index < resources.Length; ++index)
        {
          translationinternalipBindingArray[index] = new wisite_translationinternalip_binding();
          translationinternalipBindingArray[index].sitepath = resources[index].sitepath;
          translationinternalipBindingArray[index].translationinternalip = resources[index].translationinternalip;
          translationinternalipBindingArray[index].translationinternalport = resources[index].translationinternalport;
          translationinternalipBindingArray[index].translationexternalip = resources[index].translationexternalip;
          translationinternalipBindingArray[index].translationexternalport = resources[index].translationexternalport;
        }
        baseResponses = base_resource.delete_bulk_request(client, (base_resource[]) translationinternalipBindingArray);
      }
      return baseResponses;
    }

    public static wisite_translationinternalip_binding[] get(
      nitro_service service,
      string sitepath)
    {
      return (wisite_translationinternalip_binding[]) new wisite_translationinternalip_binding()
      {
        sitepath = sitepath
      }.get_resources(service, (options) null);
    }

    public static wisite_translationinternalip_binding[] get_filtered(
      nitro_service service,
      string sitepath,
      string filter)
    {
      wisite_translationinternalip_binding translationinternalipBinding = new wisite_translationinternalip_binding();
      translationinternalipBinding.sitepath = sitepath;
      options option = new options();
      option.set_filter(filter);
      return (wisite_translationinternalip_binding[]) translationinternalipBinding.getfiltered(service, option);
    }

    public static wisite_translationinternalip_binding[] get_filtered(
      nitro_service service,
      string sitepath,
      filtervalue[] filter)
    {
      wisite_translationinternalip_binding translationinternalipBinding = new wisite_translationinternalip_binding();
      translationinternalipBinding.sitepath = sitepath;
      options option = new options();
      option.set_filter(filter);
      return (wisite_translationinternalip_binding[]) translationinternalipBinding.getfiltered(service, option);
    }

    public static uint count(nitro_service service, string sitepath)
    {
      wisite_translationinternalip_binding translationinternalipBinding = new wisite_translationinternalip_binding();
      translationinternalipBinding.sitepath = sitepath;
      options option = new options();
      option.set_count(true);
      wisite_translationinternalip_binding[] resources = (wisite_translationinternalip_binding[]) translationinternalipBinding.get_resources(service, option);
      return resources != null && resources.Length > 0 ? resources[0].__count.Value : 0U;
    }

    public static uint count_filtered(nitro_service service, string sitepath, string filter)
    {
      wisite_translationinternalip_binding translationinternalipBinding = new wisite_translationinternalip_binding();
      translationinternalipBinding.sitepath = sitepath;
      options option = new options();
      option.set_count(true);
      option.set_filter(filter);
      wisite_translationinternalip_binding[] translationinternalipBindingArray = (wisite_translationinternalip_binding[]) translationinternalipBinding.getfiltered(service, option);
      return translationinternalipBindingArray != null && translationinternalipBindingArray.Length > 0 ? translationinternalipBindingArray[0].__count.Value : 0U;
    }

    public static uint count_filtered(nitro_service service, string sitepath, filtervalue[] filter)
    {
      wisite_translationinternalip_binding translationinternalipBinding = new wisite_translationinternalip_binding();
      translationinternalipBinding.sitepath = sitepath;
      options option = new options();
      option.set_count(true);
      option.set_filter(filter);
      wisite_translationinternalip_binding[] translationinternalipBindingArray = (wisite_translationinternalip_binding[]) translationinternalipBinding.getfiltered(service, option);
      return translationinternalipBindingArray != null && translationinternalipBindingArray.Length > 0 ? translationinternalipBindingArray[0].__count.Value : 0U;
    }

    private class wisite_translationinternalip_binding_response : base_response
    {
      public wisite_translationinternalip_binding[] wisite_translationinternalip_binding = (wisite_translationinternalip_binding[]) null;
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
