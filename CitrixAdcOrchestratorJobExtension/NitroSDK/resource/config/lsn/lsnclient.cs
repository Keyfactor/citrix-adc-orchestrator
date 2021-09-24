// Decompiled with JetBrains decompiler
// Type: com.citrix.netscaler.nitro.resource.config.lsn.lsnclient
// Assembly: nitro, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 6CF5DDEF-E052-4F9D-953F-6644F8378A66


using com.citrix.netscaler.nitro.exception;
using com.citrix.netscaler.nitro.resource.Base;
using com.citrix.netscaler.nitro.service;
using com.citrix.netscaler.nitro.util;

namespace com.citrix.netscaler.nitro.resource.config.lsn
{
  public class lsnclient : base_resource
  {
    private string clientnameField = (string) null;
    private uint? tdField = new uint?();
    private uint? __countField = new uint?();

    public uint? __count
    {
      get => this.__countField;
      private set => this.__countField = value;
    }

    public string clientname
    {
      get => this.clientnameField;
      set => this.clientnameField = value;
    }

    public uint? td
    {
      get => this.tdField;
      private set => this.tdField = value;
    }

    internal override base_resource[] get_nitro_response(
      nitro_service service,
      string response)
    {
      lsnclient.lsnclient_response lsnclientResponse = new lsnclient.lsnclient_response();
      lsnclient.lsnclient_response resource = (lsnclient.lsnclient_response) service.get_payload_formatter().string_to_resource(lsnclientResponse.GetType(), response);
      if (resource.errorcode != 0)
      {
        if (resource.errorcode == 444)
          service.clear_session();
        if (resource.severity == null)
          throw new nitro_exception(resource.message, resource.errorcode);
        if (resource.severity.Equals("ERROR"))
          throw new nitro_exception(resource.message, resource.errorcode);
      }
      return (base_resource[]) resource.lsnclient;
    }

    internal override string get_object_name() => this.clientname;

    public static base_response add(nitro_service client, lsnclient resource) => new lsnclient()
    {
      clientname = resource.clientname
    }.add_resource(client);

    public static base_responses add(nitro_service client, lsnclient[] resources)
    {
      base_responses baseResponses = (base_responses) null;
      if (resources != null && resources.Length > 0)
      {
        lsnclient[] lsnclientArray = new lsnclient[resources.Length];
        for (int index = 0; index < resources.Length; ++index)
        {
          lsnclientArray[index] = new lsnclient();
          lsnclientArray[index].clientname = resources[index].clientname;
        }
        baseResponses = base_resource.add_bulk_request(client, (base_resource[]) lsnclientArray);
      }
      return baseResponses;
    }

    public static base_response delete(nitro_service client, string clientname) => new lsnclient()
    {
      clientname = clientname
    }.delete_resource(client);

    public static base_response delete(nitro_service client, lsnclient resource) => new lsnclient()
    {
      clientname = resource.clientname
    }.delete_resource(client);

    public static base_responses delete(nitro_service client, string[] clientname)
    {
      base_responses baseResponses = (base_responses) null;
      if (clientname != null && clientname.Length > 0)
      {
        lsnclient[] lsnclientArray = new lsnclient[clientname.Length];
        for (int index = 0; index < clientname.Length; ++index)
        {
          lsnclientArray[index] = new lsnclient();
          lsnclientArray[index].clientname = clientname[index];
        }
        baseResponses = base_resource.delete_bulk_request(client, (base_resource[]) lsnclientArray);
      }
      return baseResponses;
    }

    public static base_responses delete(nitro_service client, lsnclient[] resources)
    {
      base_responses baseResponses = (base_responses) null;
      if (resources != null && resources.Length > 0)
      {
        lsnclient[] lsnclientArray = new lsnclient[resources.Length];
        for (int index = 0; index < resources.Length; ++index)
        {
          lsnclientArray[index] = new lsnclient();
          lsnclientArray[index].clientname = resources[index].clientname;
        }
        baseResponses = base_resource.delete_bulk_request(client, (base_resource[]) lsnclientArray);
      }
      return baseResponses;
    }

    public static lsnclient[] get(nitro_service service) => (lsnclient[]) new lsnclient().get_resources(service, (options) null);

    public static lsnclient[] get(nitro_service service, options option) => (lsnclient[]) new lsnclient().get_resources(service, option);

    public static lsnclient get(nitro_service service, string clientname) => (lsnclient) new lsnclient()
    {
      clientname = clientname
    }.get_resource(service);

    public static lsnclient[] get(nitro_service service, string[] clientname)
    {
      if (clientname == null || clientname.Length <= 0)
        return (lsnclient[]) null;
      lsnclient[] lsnclientArray1 = new lsnclient[clientname.Length];
      lsnclient[] lsnclientArray2 = new lsnclient[clientname.Length];
      for (int index = 0; index < clientname.Length; ++index)
      {
        lsnclientArray2[index] = new lsnclient();
        lsnclientArray2[index].clientname = clientname[index];
        lsnclientArray1[index] = (lsnclient) lsnclientArray2[index].get_resource(service);
      }
      return lsnclientArray1;
    }

    public static lsnclient[] get_filtered(nitro_service service, string filter)
    {
      lsnclient lsnclient = new lsnclient();
      options option = new options();
      option.set_filter(filter);
      return (lsnclient[]) lsnclient.getfiltered(service, option);
    }

    public static lsnclient[] get_filtered(nitro_service service, filtervalue[] filter)
    {
      lsnclient lsnclient = new lsnclient();
      options option = new options();
      option.set_filter(filter);
      return (lsnclient[]) lsnclient.getfiltered(service, option);
    }

    public static uint count(nitro_service service)
    {
      lsnclient lsnclient = new lsnclient();
      options option = new options();
      option.set_count(true);
      lsnclient[] resources = (lsnclient[]) lsnclient.get_resources(service, option);
      return resources != null && resources.Length > 0 ? resources[0].__count.Value : 0U;
    }

    public static uint count_filtered(nitro_service service, string filter)
    {
      lsnclient lsnclient = new lsnclient();
      options option = new options();
      option.set_count(true);
      option.set_filter(filter);
      lsnclient[] lsnclientArray = (lsnclient[]) lsnclient.getfiltered(service, option);
      return lsnclientArray != null && lsnclientArray.Length > 0 ? lsnclientArray[0].__count.Value : 0U;
    }

    public static uint count_filtered(nitro_service service, filtervalue[] filter)
    {
      lsnclient lsnclient = new lsnclient();
      options option = new options();
      option.set_count(true);
      option.set_filter(filter);
      lsnclient[] lsnclientArray = (lsnclient[]) lsnclient.getfiltered(service, option);
      return lsnclientArray != null && lsnclientArray.Length > 0 ? lsnclientArray[0].__count.Value : 0U;
    }

    private class lsnclient_response : base_response
    {
      public lsnclient[] lsnclient = (lsnclient[]) null;
    }
  }
}
