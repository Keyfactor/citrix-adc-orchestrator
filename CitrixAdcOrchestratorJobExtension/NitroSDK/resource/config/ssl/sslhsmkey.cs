// Decompiled with JetBrains decompiler
// Type: com.citrix.netscaler.nitro.resource.config.ssl.sslhsmkey
// Assembly: nitro, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 6CF5DDEF-E052-4F9D-953F-6644F8378A66


using com.citrix.netscaler.nitro.exception;
using com.citrix.netscaler.nitro.resource.Base;
using com.citrix.netscaler.nitro.service;
using com.citrix.netscaler.nitro.util;

namespace com.citrix.netscaler.nitro.resource.config.ssl
{
  public class sslhsmkey : base_resource
  {
    private string hsmkeynameField = (string) null;
    private string keyField = (string) null;
    private uint? __countField = new uint?();

    public uint? __count
    {
      get => this.__countField;
      private set => this.__countField = value;
    }

    public string hsmkeyname
    {
      get => this.hsmkeynameField;
      set => this.hsmkeynameField = value;
    }

    public string key
    {
      get => this.keyField;
      set => this.keyField = value;
    }

    internal override base_resource[] get_nitro_response(
      nitro_service service,
      string response)
    {
      sslhsmkey.sslhsmkey_response sslhsmkeyResponse = new sslhsmkey.sslhsmkey_response();
      sslhsmkey.sslhsmkey_response resource = (sslhsmkey.sslhsmkey_response) service.get_payload_formatter().string_to_resource(sslhsmkeyResponse.GetType(), response);
      if (resource.errorcode != 0)
      {
        if (resource.errorcode == 444)
          service.clear_session();
        if (resource.severity == null)
          throw new nitro_exception(resource.message, resource.errorcode);
        if (resource.severity.Equals("ERROR"))
          throw new nitro_exception(resource.message, resource.errorcode);
      }
      return (base_resource[]) resource.sslhsmkey;
    }

    internal override string get_object_name() => this.hsmkeyname;

    public static base_response add(nitro_service client, sslhsmkey resource) => new sslhsmkey()
    {
      hsmkeyname = resource.hsmkeyname,
      key = resource.key
    }.add_resource(client);

    public static base_responses add(nitro_service client, sslhsmkey[] resources)
    {
      base_responses baseResponses = (base_responses) null;
      if (resources != null && resources.Length > 0)
      {
        sslhsmkey[] sslhsmkeyArray = new sslhsmkey[resources.Length];
        for (int index = 0; index < resources.Length; ++index)
        {
          sslhsmkeyArray[index] = new sslhsmkey();
          sslhsmkeyArray[index].hsmkeyname = resources[index].hsmkeyname;
          sslhsmkeyArray[index].key = resources[index].key;
        }
        baseResponses = base_resource.add_bulk_request(client, (base_resource[]) sslhsmkeyArray);
      }
      return baseResponses;
    }

    public static base_response delete(nitro_service client, string hsmkeyname) => new sslhsmkey()
    {
      hsmkeyname = hsmkeyname
    }.delete_resource(client);

    public static base_response delete(nitro_service client, sslhsmkey resource) => new sslhsmkey()
    {
      hsmkeyname = resource.hsmkeyname
    }.delete_resource(client);

    public static base_responses delete(nitro_service client, string[] hsmkeyname)
    {
      base_responses baseResponses = (base_responses) null;
      if (hsmkeyname != null && hsmkeyname.Length > 0)
      {
        sslhsmkey[] sslhsmkeyArray = new sslhsmkey[hsmkeyname.Length];
        for (int index = 0; index < hsmkeyname.Length; ++index)
        {
          sslhsmkeyArray[index] = new sslhsmkey();
          sslhsmkeyArray[index].hsmkeyname = hsmkeyname[index];
        }
        baseResponses = base_resource.delete_bulk_request(client, (base_resource[]) sslhsmkeyArray);
      }
      return baseResponses;
    }

    public static base_responses delete(nitro_service client, sslhsmkey[] resources)
    {
      base_responses baseResponses = (base_responses) null;
      if (resources != null && resources.Length > 0)
      {
        sslhsmkey[] sslhsmkeyArray = new sslhsmkey[resources.Length];
        for (int index = 0; index < resources.Length; ++index)
        {
          sslhsmkeyArray[index] = new sslhsmkey();
          sslhsmkeyArray[index].hsmkeyname = resources[index].hsmkeyname;
        }
        baseResponses = base_resource.delete_bulk_request(client, (base_resource[]) sslhsmkeyArray);
      }
      return baseResponses;
    }

    public static sslhsmkey[] get(nitro_service service) => (sslhsmkey[]) new sslhsmkey().get_resources(service, (options) null);

    public static sslhsmkey[] get(nitro_service service, options option) => (sslhsmkey[]) new sslhsmkey().get_resources(service, option);

    public static sslhsmkey get(nitro_service service, string hsmkeyname) => (sslhsmkey) new sslhsmkey()
    {
      hsmkeyname = hsmkeyname
    }.get_resource(service);

    public static sslhsmkey[] get(nitro_service service, string[] hsmkeyname)
    {
      if (hsmkeyname == null || hsmkeyname.Length <= 0)
        return (sslhsmkey[]) null;
      sslhsmkey[] sslhsmkeyArray1 = new sslhsmkey[hsmkeyname.Length];
      sslhsmkey[] sslhsmkeyArray2 = new sslhsmkey[hsmkeyname.Length];
      for (int index = 0; index < hsmkeyname.Length; ++index)
      {
        sslhsmkeyArray2[index] = new sslhsmkey();
        sslhsmkeyArray2[index].hsmkeyname = hsmkeyname[index];
        sslhsmkeyArray1[index] = (sslhsmkey) sslhsmkeyArray2[index].get_resource(service);
      }
      return sslhsmkeyArray1;
    }

    public static sslhsmkey[] get_filtered(nitro_service service, string filter)
    {
      sslhsmkey sslhsmkey = new sslhsmkey();
      options option = new options();
      option.set_filter(filter);
      return (sslhsmkey[]) sslhsmkey.getfiltered(service, option);
    }

    public static sslhsmkey[] get_filtered(nitro_service service, filtervalue[] filter)
    {
      sslhsmkey sslhsmkey = new sslhsmkey();
      options option = new options();
      option.set_filter(filter);
      return (sslhsmkey[]) sslhsmkey.getfiltered(service, option);
    }

    public static uint count(nitro_service service)
    {
      sslhsmkey sslhsmkey = new sslhsmkey();
      options option = new options();
      option.set_count(true);
      sslhsmkey[] resources = (sslhsmkey[]) sslhsmkey.get_resources(service, option);
      return resources != null && resources.Length > 0 ? resources[0].__count.Value : 0U;
    }

    public static uint count_filtered(nitro_service service, string filter)
    {
      sslhsmkey sslhsmkey = new sslhsmkey();
      options option = new options();
      option.set_count(true);
      option.set_filter(filter);
      sslhsmkey[] sslhsmkeyArray = (sslhsmkey[]) sslhsmkey.getfiltered(service, option);
      return sslhsmkeyArray != null && sslhsmkeyArray.Length > 0 ? sslhsmkeyArray[0].__count.Value : 0U;
    }

    public static uint count_filtered(nitro_service service, filtervalue[] filter)
    {
      sslhsmkey sslhsmkey = new sslhsmkey();
      options option = new options();
      option.set_count(true);
      option.set_filter(filter);
      sslhsmkey[] sslhsmkeyArray = (sslhsmkey[]) sslhsmkey.getfiltered(service, option);
      return sslhsmkeyArray != null && sslhsmkeyArray.Length > 0 ? sslhsmkeyArray[0].__count.Value : 0U;
    }

    private class sslhsmkey_response : base_response
    {
      public sslhsmkey[] sslhsmkey = (sslhsmkey[]) null;
    }
  }
}
