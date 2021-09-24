// Decompiled with JetBrains decompiler
// Type: com.citrix.netscaler.nitro.resource.config.vpn.vpnportaltheme
// Assembly: nitro, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 6CF5DDEF-E052-4F9D-953F-6644F8378A66


using com.citrix.netscaler.nitro.exception;
using com.citrix.netscaler.nitro.resource.Base;
using com.citrix.netscaler.nitro.service;
using com.citrix.netscaler.nitro.util;

namespace com.citrix.netscaler.nitro.resource.config.vpn
{
  public class vpnportaltheme : base_resource
  {
    private string nameField = (string) null;
    private string basethemeField = (string) null;
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

    public string basetheme
    {
      get => this.basethemeField;
      set => this.basethemeField = value;
    }

    internal override base_resource[] get_nitro_response(
      nitro_service service,
      string response)
    {
      vpnportaltheme.vpnportaltheme_response vpnportalthemeResponse = new vpnportaltheme.vpnportaltheme_response();
      vpnportaltheme.vpnportaltheme_response resource = (vpnportaltheme.vpnportaltheme_response) service.get_payload_formatter().string_to_resource(vpnportalthemeResponse.GetType(), response);
      if (resource.errorcode != 0)
      {
        if (resource.errorcode == 444)
          service.clear_session();
        if (resource.severity == null)
          throw new nitro_exception(resource.message, resource.errorcode);
        if (resource.severity.Equals("ERROR"))
          throw new nitro_exception(resource.message, resource.errorcode);
      }
      return (base_resource[]) resource.vpnportaltheme;
    }

    internal override string get_object_name() => this.name;

    public static base_response add(nitro_service client, vpnportaltheme resource) => new vpnportaltheme()
    {
      name = resource.name,
      basetheme = resource.basetheme
    }.add_resource(client);

    public static base_responses add(nitro_service client, vpnportaltheme[] resources)
    {
      base_responses baseResponses = (base_responses) null;
      if (resources != null && resources.Length > 0)
      {
        vpnportaltheme[] vpnportalthemeArray = new vpnportaltheme[resources.Length];
        for (int index = 0; index < resources.Length; ++index)
        {
          vpnportalthemeArray[index] = new vpnportaltheme();
          vpnportalthemeArray[index].name = resources[index].name;
          vpnportalthemeArray[index].basetheme = resources[index].basetheme;
        }
        baseResponses = base_resource.add_bulk_request(client, (base_resource[]) vpnportalthemeArray);
      }
      return baseResponses;
    }

    public static base_response delete(nitro_service client, string name) => new vpnportaltheme()
    {
      name = name
    }.delete_resource(client);

    public static base_response delete(nitro_service client, vpnportaltheme resource) => new vpnportaltheme()
    {
      name = resource.name
    }.delete_resource(client);

    public static base_responses delete(nitro_service client, string[] name)
    {
      base_responses baseResponses = (base_responses) null;
      if (name != null && name.Length > 0)
      {
        vpnportaltheme[] vpnportalthemeArray = new vpnportaltheme[name.Length];
        for (int index = 0; index < name.Length; ++index)
        {
          vpnportalthemeArray[index] = new vpnportaltheme();
          vpnportalthemeArray[index].name = name[index];
        }
        baseResponses = base_resource.delete_bulk_request(client, (base_resource[]) vpnportalthemeArray);
      }
      return baseResponses;
    }

    public static base_responses delete(
      nitro_service client,
      vpnportaltheme[] resources)
    {
      base_responses baseResponses = (base_responses) null;
      if (resources != null && resources.Length > 0)
      {
        vpnportaltheme[] vpnportalthemeArray = new vpnportaltheme[resources.Length];
        for (int index = 0; index < resources.Length; ++index)
        {
          vpnportalthemeArray[index] = new vpnportaltheme();
          vpnportalthemeArray[index].name = resources[index].name;
        }
        baseResponses = base_resource.delete_bulk_request(client, (base_resource[]) vpnportalthemeArray);
      }
      return baseResponses;
    }

    public static vpnportaltheme[] get(nitro_service service) => (vpnportaltheme[]) new vpnportaltheme().get_resources(service, (options) null);

    public static vpnportaltheme[] get(nitro_service service, options option) => (vpnportaltheme[]) new vpnportaltheme().get_resources(service, option);

    public static vpnportaltheme get(nitro_service service, string name) => (vpnportaltheme) new vpnportaltheme()
    {
      name = name
    }.get_resource(service);

    public static vpnportaltheme[] get(nitro_service service, string[] name)
    {
      if (name == null || name.Length <= 0)
        return (vpnportaltheme[]) null;
      vpnportaltheme[] vpnportalthemeArray1 = new vpnportaltheme[name.Length];
      vpnportaltheme[] vpnportalthemeArray2 = new vpnportaltheme[name.Length];
      for (int index = 0; index < name.Length; ++index)
      {
        vpnportalthemeArray2[index] = new vpnportaltheme();
        vpnportalthemeArray2[index].name = name[index];
        vpnportalthemeArray1[index] = (vpnportaltheme) vpnportalthemeArray2[index].get_resource(service);
      }
      return vpnportalthemeArray1;
    }

    public static vpnportaltheme[] get_filtered(nitro_service service, string filter)
    {
      vpnportaltheme vpnportaltheme = new vpnportaltheme();
      options option = new options();
      option.set_filter(filter);
      return (vpnportaltheme[]) vpnportaltheme.getfiltered(service, option);
    }

    public static vpnportaltheme[] get_filtered(
      nitro_service service,
      filtervalue[] filter)
    {
      vpnportaltheme vpnportaltheme = new vpnportaltheme();
      options option = new options();
      option.set_filter(filter);
      return (vpnportaltheme[]) vpnportaltheme.getfiltered(service, option);
    }

    public static uint count(nitro_service service)
    {
      vpnportaltheme vpnportaltheme = new vpnportaltheme();
      options option = new options();
      option.set_count(true);
      vpnportaltheme[] resources = (vpnportaltheme[]) vpnportaltheme.get_resources(service, option);
      return resources != null && resources.Length > 0 ? resources[0].__count.Value : 0U;
    }

    public static uint count_filtered(nitro_service service, string filter)
    {
      vpnportaltheme vpnportaltheme = new vpnportaltheme();
      options option = new options();
      option.set_count(true);
      option.set_filter(filter);
      vpnportaltheme[] vpnportalthemeArray = (vpnportaltheme[]) vpnportaltheme.getfiltered(service, option);
      return vpnportalthemeArray != null && vpnportalthemeArray.Length > 0 ? vpnportalthemeArray[0].__count.Value : 0U;
    }

    public static uint count_filtered(nitro_service service, filtervalue[] filter)
    {
      vpnportaltheme vpnportaltheme = new vpnportaltheme();
      options option = new options();
      option.set_count(true);
      option.set_filter(filter);
      vpnportaltheme[] vpnportalthemeArray = (vpnportaltheme[]) vpnportaltheme.getfiltered(service, option);
      return vpnportalthemeArray != null && vpnportalthemeArray.Length > 0 ? vpnportalthemeArray[0].__count.Value : 0U;
    }

    private class vpnportaltheme_response : base_response
    {
      public vpnportaltheme[] vpnportaltheme = (vpnportaltheme[]) null;
    }

    public static class basethemeEnum
    {
      public const string Default = "Default";
      public const string Greenbubble = "Greenbubble";
      public const string X1 = "X1";
    }
  }
}
