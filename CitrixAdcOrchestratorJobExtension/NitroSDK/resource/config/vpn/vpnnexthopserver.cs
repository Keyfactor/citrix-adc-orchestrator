// Decompiled with JetBrains decompiler
// Type: com.citrix.netscaler.nitro.resource.config.vpn.vpnnexthopserver
// Assembly: nitro, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 6CF5DDEF-E052-4F9D-953F-6644F8378A66


using com.citrix.netscaler.nitro.exception;
using com.citrix.netscaler.nitro.resource.Base;
using com.citrix.netscaler.nitro.service;
using com.citrix.netscaler.nitro.util;

namespace com.citrix.netscaler.nitro.resource.config.vpn
{
  public class vpnnexthopserver : base_resource
  {
    private string nameField = (string) null;
    private string nexthopipField = (string) null;
    private string nexthopfqdnField = (string) null;
    private string resaddresstypeField = (string) null;
    private ushort? nexthopportField = new ushort?();
    private string secureField = (string) null;
    private uint? __countField = new uint?();

    public uint? __count
    {
      get => this.__countField;
      private set => this.__countField = value;
    }

    public string name
    {
      get => this.nameField;
      set => this.nameField = value;
    }

    public string nexthopip
    {
      get => this.nexthopipField;
      set => this.nexthopipField = value;
    }

    public string nexthopfqdn
    {
      get => this.nexthopfqdnField;
      set => this.nexthopfqdnField = value;
    }

    public string resaddresstype
    {
      get => this.resaddresstypeField;
      set => this.resaddresstypeField = value;
    }

    public ushort? nexthopport
    {
      get => this.nexthopportField;
      set => this.nexthopportField = value;
    }

    public string secure
    {
      get => this.secureField;
      set => this.secureField = value;
    }

    internal override base_resource[] get_nitro_response(
      nitro_service service,
      string response)
    {
      vpnnexthopserver.vpnnexthopserver_response vpnnexthopserverResponse = new vpnnexthopserver.vpnnexthopserver_response();
      vpnnexthopserver.vpnnexthopserver_response resource = (vpnnexthopserver.vpnnexthopserver_response) service.get_payload_formatter().string_to_resource(vpnnexthopserverResponse.GetType(), response);
      if (resource.errorcode != 0)
      {
        if (resource.errorcode == 444)
          service.clear_session();
        if (resource.severity == null)
          throw new nitro_exception(resource.message, resource.errorcode);
        if (resource.severity.Equals("ERROR"))
          throw new nitro_exception(resource.message, resource.errorcode);
      }
      return (base_resource[]) resource.vpnnexthopserver;
    }

    internal override string get_object_name() => this.name;

    public static base_response add(nitro_service client, vpnnexthopserver resource) => new vpnnexthopserver()
    {
      name = resource.name,
      nexthopip = resource.nexthopip,
      nexthopfqdn = resource.nexthopfqdn,
      resaddresstype = resource.resaddresstype,
      nexthopport = resource.nexthopport,
      secure = resource.secure
    }.add_resource(client);

    public static base_responses add(
      nitro_service client,
      vpnnexthopserver[] resources)
    {
      base_responses baseResponses = (base_responses) null;
      if (resources != null && resources.Length > 0)
      {
        vpnnexthopserver[] vpnnexthopserverArray = new vpnnexthopserver[resources.Length];
        for (int index = 0; index < resources.Length; ++index)
        {
          vpnnexthopserverArray[index] = new vpnnexthopserver();
          vpnnexthopserverArray[index].name = resources[index].name;
          vpnnexthopserverArray[index].nexthopip = resources[index].nexthopip;
          vpnnexthopserverArray[index].nexthopfqdn = resources[index].nexthopfqdn;
          vpnnexthopserverArray[index].resaddresstype = resources[index].resaddresstype;
          vpnnexthopserverArray[index].nexthopport = resources[index].nexthopport;
          vpnnexthopserverArray[index].secure = resources[index].secure;
        }
        baseResponses = base_resource.add_bulk_request(client, (base_resource[]) vpnnexthopserverArray);
      }
      return baseResponses;
    }

    public static base_response delete(nitro_service client, string name) => new vpnnexthopserver()
    {
      name = name
    }.delete_resource(client);

    public static base_response delete(nitro_service client, vpnnexthopserver resource) => new vpnnexthopserver()
    {
      name = resource.name
    }.delete_resource(client);

    public static base_responses delete(nitro_service client, string[] name)
    {
      base_responses baseResponses = (base_responses) null;
      if (name != null && name.Length > 0)
      {
        vpnnexthopserver[] vpnnexthopserverArray = new vpnnexthopserver[name.Length];
        for (int index = 0; index < name.Length; ++index)
        {
          vpnnexthopserverArray[index] = new vpnnexthopserver();
          vpnnexthopserverArray[index].name = name[index];
        }
        baseResponses = base_resource.delete_bulk_request(client, (base_resource[]) vpnnexthopserverArray);
      }
      return baseResponses;
    }

    public static base_responses delete(
      nitro_service client,
      vpnnexthopserver[] resources)
    {
      base_responses baseResponses = (base_responses) null;
      if (resources != null && resources.Length > 0)
      {
        vpnnexthopserver[] vpnnexthopserverArray = new vpnnexthopserver[resources.Length];
        for (int index = 0; index < resources.Length; ++index)
        {
          vpnnexthopserverArray[index] = new vpnnexthopserver();
          vpnnexthopserverArray[index].name = resources[index].name;
        }
        baseResponses = base_resource.delete_bulk_request(client, (base_resource[]) vpnnexthopserverArray);
      }
      return baseResponses;
    }

    public static vpnnexthopserver[] get(nitro_service service) => (vpnnexthopserver[]) new vpnnexthopserver().get_resources(service, (options) null);

    public static vpnnexthopserver[] get(nitro_service service, options option) => (vpnnexthopserver[]) new vpnnexthopserver().get_resources(service, option);

    public static vpnnexthopserver get(nitro_service service, string name) => (vpnnexthopserver) new vpnnexthopserver()
    {
      name = name
    }.get_resource(service);

    public static vpnnexthopserver[] get(nitro_service service, string[] name)
    {
      if (name == null || name.Length <= 0)
        return (vpnnexthopserver[]) null;
      vpnnexthopserver[] vpnnexthopserverArray1 = new vpnnexthopserver[name.Length];
      vpnnexthopserver[] vpnnexthopserverArray2 = new vpnnexthopserver[name.Length];
      for (int index = 0; index < name.Length; ++index)
      {
        vpnnexthopserverArray2[index] = new vpnnexthopserver();
        vpnnexthopserverArray2[index].name = name[index];
        vpnnexthopserverArray1[index] = (vpnnexthopserver) vpnnexthopserverArray2[index].get_resource(service);
      }
      return vpnnexthopserverArray1;
    }

    public static vpnnexthopserver[] get_filtered(
      nitro_service service,
      string filter)
    {
      vpnnexthopserver vpnnexthopserver = new vpnnexthopserver();
      options option = new options();
      option.set_filter(filter);
      return (vpnnexthopserver[]) vpnnexthopserver.getfiltered(service, option);
    }

    public static vpnnexthopserver[] get_filtered(
      nitro_service service,
      filtervalue[] filter)
    {
      vpnnexthopserver vpnnexthopserver = new vpnnexthopserver();
      options option = new options();
      option.set_filter(filter);
      return (vpnnexthopserver[]) vpnnexthopserver.getfiltered(service, option);
    }

    public static uint count(nitro_service service)
    {
      vpnnexthopserver vpnnexthopserver = new vpnnexthopserver();
      options option = new options();
      option.set_count(true);
      vpnnexthopserver[] resources = (vpnnexthopserver[]) vpnnexthopserver.get_resources(service, option);
      return resources != null && resources.Length > 0 ? resources[0].__count.Value : 0U;
    }

    public static uint count_filtered(nitro_service service, string filter)
    {
      vpnnexthopserver vpnnexthopserver = new vpnnexthopserver();
      options option = new options();
      option.set_count(true);
      option.set_filter(filter);
      vpnnexthopserver[] vpnnexthopserverArray = (vpnnexthopserver[]) vpnnexthopserver.getfiltered(service, option);
      return vpnnexthopserverArray != null && vpnnexthopserverArray.Length > 0 ? vpnnexthopserverArray[0].__count.Value : 0U;
    }

    public static uint count_filtered(nitro_service service, filtervalue[] filter)
    {
      vpnnexthopserver vpnnexthopserver = new vpnnexthopserver();
      options option = new options();
      option.set_count(true);
      option.set_filter(filter);
      vpnnexthopserver[] vpnnexthopserverArray = (vpnnexthopserver[]) vpnnexthopserver.getfiltered(service, option);
      return vpnnexthopserverArray != null && vpnnexthopserverArray.Length > 0 ? vpnnexthopserverArray[0].__count.Value : 0U;
    }

    private class vpnnexthopserver_response : base_response
    {
      public vpnnexthopserver[] vpnnexthopserver = (vpnnexthopserver[]) null;
    }

    public static class secureEnum
    {
      public const string ON = "ON";
      public const string OFF = "OFF";
    }

    public static class resaddresstypeEnum
    {
      public const string IPV4 = "IPV4";
      public const string IPV6 = "IPV6";
    }
  }
}
