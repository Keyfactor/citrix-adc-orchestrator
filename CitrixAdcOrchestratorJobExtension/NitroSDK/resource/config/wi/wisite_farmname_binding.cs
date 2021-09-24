// Decompiled with JetBrains decompiler
// Type: com.citrix.netscaler.nitro.resource.config.wi.wisite_farmname_binding
// Assembly: nitro, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 6CF5DDEF-E052-4F9D-953F-6644F8378A66


using com.citrix.netscaler.nitro.exception;
using com.citrix.netscaler.nitro.resource.Base;
using com.citrix.netscaler.nitro.service;
using com.citrix.netscaler.nitro.util;

namespace com.citrix.netscaler.nitro.resource.config.wi
{
  public class wisite_farmname_binding : base_resource
  {
    private string farmnameField = (string) null;
    private string xmlserveraddressesField = (string) null;
    private uint? xmlportField = new uint?();
    private string transportField = (string) null;
    private uint? sslrelayportField = new uint?();
    private string loadbalanceField = (string) null;
    private string groupsField = (string) null;
    private string recoveryfarmField = (string) null;
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

    public string groups
    {
      get => this.groupsField;
      set => this.groupsField = value;
    }

    public uint? xmlport
    {
      get => this.xmlportField;
      set => this.xmlportField = value;
    }

    public string transport
    {
      get => this.transportField;
      set => this.transportField = value;
    }

    public uint? sslrelayport
    {
      get => this.sslrelayportField;
      set => this.sslrelayportField = value;
    }

    public string farmname
    {
      get => this.farmnameField;
      set => this.farmnameField = value;
    }

    public string loadbalance
    {
      get => this.loadbalanceField;
      set => this.loadbalanceField = value;
    }

    public string recoveryfarm
    {
      get => this.recoveryfarmField;
      set => this.recoveryfarmField = value;
    }

    public string xmlserveraddresses
    {
      get => this.xmlserveraddressesField;
      set => this.xmlserveraddressesField = value;
    }

    internal override base_resource[] get_nitro_response(
      nitro_service service,
      string response)
    {
      wisite_farmname_binding.wisite_farmname_binding_response farmnameBindingResponse = new wisite_farmname_binding.wisite_farmname_binding_response();
      wisite_farmname_binding.wisite_farmname_binding_response resource = (wisite_farmname_binding.wisite_farmname_binding_response) service.get_payload_formatter().string_to_resource(farmnameBindingResponse.GetType(), response);
      if (resource.errorcode != 0)
      {
        if (resource.errorcode == 444)
          service.clear_session();
        if (resource.severity == null)
          throw new nitro_exception(resource.message, resource.errorcode);
        if (resource.severity.Equals("ERROR"))
          throw new nitro_exception(resource.message, resource.errorcode);
      }
      return (base_resource[]) resource.wisite_farmname_binding;
    }

    internal override string get_object_name() => this.sitepath;

    public static base_response add(
      nitro_service client,
      wisite_farmname_binding resource)
    {
      return new wisite_farmname_binding()
      {
        sitepath = resource.sitepath,
        farmname = resource.farmname,
        xmlserveraddresses = resource.xmlserveraddresses,
        groups = resource.groups,
        recoveryfarm = resource.recoveryfarm,
        xmlport = resource.xmlport,
        transport = resource.transport,
        sslrelayport = resource.sslrelayport,
        loadbalance = resource.loadbalance
      }.update_resource(client);
    }

    public static base_responses add(
      nitro_service client,
      wisite_farmname_binding[] resources)
    {
      base_responses baseResponses = (base_responses) null;
      if (resources != null && resources.Length > 0)
      {
        wisite_farmname_binding[] wisiteFarmnameBindingArray = new wisite_farmname_binding[resources.Length];
        for (int index = 0; index < resources.Length; ++index)
        {
          wisiteFarmnameBindingArray[index] = new wisite_farmname_binding();
          wisiteFarmnameBindingArray[index].sitepath = resources[index].sitepath;
          wisiteFarmnameBindingArray[index].farmname = resources[index].farmname;
          wisiteFarmnameBindingArray[index].xmlserveraddresses = resources[index].xmlserveraddresses;
          wisiteFarmnameBindingArray[index].groups = resources[index].groups;
          wisiteFarmnameBindingArray[index].recoveryfarm = resources[index].recoveryfarm;
          wisiteFarmnameBindingArray[index].xmlport = resources[index].xmlport;
          wisiteFarmnameBindingArray[index].transport = resources[index].transport;
          wisiteFarmnameBindingArray[index].sslrelayport = resources[index].sslrelayport;
          wisiteFarmnameBindingArray[index].loadbalance = resources[index].loadbalance;
        }
        baseResponses = base_resource.update_bulk_request(client, (base_resource[]) wisiteFarmnameBindingArray);
      }
      return baseResponses;
    }

    public static base_response delete(
      nitro_service client,
      wisite_farmname_binding resource)
    {
      return new wisite_farmname_binding()
      {
        sitepath = resource.sitepath,
        farmname = resource.farmname
      }.delete_resource(client);
    }

    public static base_responses delete(
      nitro_service client,
      wisite_farmname_binding[] resources)
    {
      base_responses baseResponses = (base_responses) null;
      if (resources != null && resources.Length > 0)
      {
        wisite_farmname_binding[] wisiteFarmnameBindingArray = new wisite_farmname_binding[resources.Length];
        for (int index = 0; index < resources.Length; ++index)
        {
          wisiteFarmnameBindingArray[index] = new wisite_farmname_binding();
          wisiteFarmnameBindingArray[index].sitepath = resources[index].sitepath;
          wisiteFarmnameBindingArray[index].farmname = resources[index].farmname;
        }
        baseResponses = base_resource.delete_bulk_request(client, (base_resource[]) wisiteFarmnameBindingArray);
      }
      return baseResponses;
    }

    public static wisite_farmname_binding[] get(
      nitro_service service,
      string sitepath)
    {
      return (wisite_farmname_binding[]) new wisite_farmname_binding()
      {
        sitepath = sitepath
      }.get_resources(service, (options) null);
    }

    public static wisite_farmname_binding[] get_filtered(
      nitro_service service,
      string sitepath,
      string filter)
    {
      wisite_farmname_binding wisiteFarmnameBinding = new wisite_farmname_binding();
      wisiteFarmnameBinding.sitepath = sitepath;
      options option = new options();
      option.set_filter(filter);
      return (wisite_farmname_binding[]) wisiteFarmnameBinding.getfiltered(service, option);
    }

    public static wisite_farmname_binding[] get_filtered(
      nitro_service service,
      string sitepath,
      filtervalue[] filter)
    {
      wisite_farmname_binding wisiteFarmnameBinding = new wisite_farmname_binding();
      wisiteFarmnameBinding.sitepath = sitepath;
      options option = new options();
      option.set_filter(filter);
      return (wisite_farmname_binding[]) wisiteFarmnameBinding.getfiltered(service, option);
    }

    public static uint count(nitro_service service, string sitepath)
    {
      wisite_farmname_binding wisiteFarmnameBinding = new wisite_farmname_binding();
      wisiteFarmnameBinding.sitepath = sitepath;
      options option = new options();
      option.set_count(true);
      wisite_farmname_binding[] resources = (wisite_farmname_binding[]) wisiteFarmnameBinding.get_resources(service, option);
      return resources != null && resources.Length > 0 ? resources[0].__count.Value : 0U;
    }

    public static uint count_filtered(nitro_service service, string sitepath, string filter)
    {
      wisite_farmname_binding wisiteFarmnameBinding = new wisite_farmname_binding();
      wisiteFarmnameBinding.sitepath = sitepath;
      options option = new options();
      option.set_count(true);
      option.set_filter(filter);
      wisite_farmname_binding[] wisiteFarmnameBindingArray = (wisite_farmname_binding[]) wisiteFarmnameBinding.getfiltered(service, option);
      return wisiteFarmnameBindingArray != null && wisiteFarmnameBindingArray.Length > 0 ? wisiteFarmnameBindingArray[0].__count.Value : 0U;
    }

    public static uint count_filtered(nitro_service service, string sitepath, filtervalue[] filter)
    {
      wisite_farmname_binding wisiteFarmnameBinding = new wisite_farmname_binding();
      wisiteFarmnameBinding.sitepath = sitepath;
      options option = new options();
      option.set_count(true);
      option.set_filter(filter);
      wisite_farmname_binding[] wisiteFarmnameBindingArray = (wisite_farmname_binding[]) wisiteFarmnameBinding.getfiltered(service, option);
      return wisiteFarmnameBindingArray != null && wisiteFarmnameBindingArray.Length > 0 ? wisiteFarmnameBindingArray[0].__count.Value : 0U;
    }

    private class wisite_farmname_binding_response : base_response
    {
      public wisite_farmname_binding[] wisite_farmname_binding = (wisite_farmname_binding[]) null;
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
