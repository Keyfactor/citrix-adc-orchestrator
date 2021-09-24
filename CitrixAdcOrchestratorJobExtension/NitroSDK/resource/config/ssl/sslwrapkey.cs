// Decompiled with JetBrains decompiler
// Type: com.citrix.netscaler.nitro.resource.config.ssl.sslwrapkey
// Assembly: nitro, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 6CF5DDEF-E052-4F9D-953F-6644F8378A66


using com.citrix.netscaler.nitro.exception;
using com.citrix.netscaler.nitro.resource.Base;
using com.citrix.netscaler.nitro.service;
using com.citrix.netscaler.nitro.util;

namespace com.citrix.netscaler.nitro.resource.config.ssl
{
  public class sslwrapkey : base_resource
  {
    private string wrapkeynameField = (string) null;
    private string passwordField = (string) null;
    private string saltField = (string) null;
    private uint? __countField = new uint?();

    public uint? __count
    {
      get => this.__countField;
      private set => this.__countField = value;
    }

    public string wrapkeyname
    {
      get => this.wrapkeynameField;
      set => this.wrapkeynameField = value;
    }

    public string password
    {
      get => this.passwordField;
      set => this.passwordField = value;
    }

    public string salt
    {
      get => this.saltField;
      set => this.saltField = value;
    }

    internal override base_resource[] get_nitro_response(
      nitro_service service,
      string response)
    {
      sslwrapkey.sslwrapkey_response sslwrapkeyResponse = new sslwrapkey.sslwrapkey_response();
      sslwrapkey.sslwrapkey_response resource = (sslwrapkey.sslwrapkey_response) service.get_payload_formatter().string_to_resource(sslwrapkeyResponse.GetType(), response);
      if (resource.errorcode != 0)
      {
        if (resource.errorcode == 444)
          service.clear_session();
        if (resource.severity == null)
          throw new nitro_exception(resource.message, resource.errorcode);
        if (resource.severity.Equals("ERROR"))
          throw new nitro_exception(resource.message, resource.errorcode);
      }
      return (base_resource[]) resource.sslwrapkey;
    }

    internal override string get_object_name() => this.wrapkeyname;

    public static base_response create(nitro_service client, sslwrapkey resource) => new sslwrapkey()
    {
      wrapkeyname = resource.wrapkeyname,
      password = resource.password,
      salt = resource.salt
    }.perform_operation_byaction(client, nameof (create));

    public static base_responses create(nitro_service client, sslwrapkey[] resources)
    {
      base_responses baseResponses = (base_responses) null;
      if (resources != null && resources.Length > 0)
      {
        sslwrapkey[] sslwrapkeyArray = new sslwrapkey[resources.Length];
        for (int index = 0; index < resources.Length; ++index)
        {
          sslwrapkeyArray[index] = new sslwrapkey();
          sslwrapkeyArray[index].wrapkeyname = resources[index].wrapkeyname;
          sslwrapkeyArray[index].password = resources[index].password;
          sslwrapkeyArray[index].salt = resources[index].salt;
        }
        baseResponses = base_resource.perform_operation_bulk_request(client, (base_resource[]) sslwrapkeyArray, nameof (create));
      }
      return baseResponses;
    }

    public static base_response delete(nitro_service client, string wrapkeyname) => new sslwrapkey()
    {
      wrapkeyname = wrapkeyname
    }.delete_resource(client);

    public static base_response delete(nitro_service client, sslwrapkey resource) => new sslwrapkey()
    {
      wrapkeyname = resource.wrapkeyname
    }.delete_resource(client);

    public static base_responses delete(nitro_service client, string[] wrapkeyname)
    {
      base_responses baseResponses = (base_responses) null;
      if (wrapkeyname != null && wrapkeyname.Length > 0)
      {
        sslwrapkey[] sslwrapkeyArray = new sslwrapkey[wrapkeyname.Length];
        for (int index = 0; index < wrapkeyname.Length; ++index)
        {
          sslwrapkeyArray[index] = new sslwrapkey();
          sslwrapkeyArray[index].wrapkeyname = wrapkeyname[index];
        }
        baseResponses = base_resource.delete_bulk_request(client, (base_resource[]) sslwrapkeyArray);
      }
      return baseResponses;
    }

    public static base_responses delete(nitro_service client, sslwrapkey[] resources)
    {
      base_responses baseResponses = (base_responses) null;
      if (resources != null && resources.Length > 0)
      {
        sslwrapkey[] sslwrapkeyArray = new sslwrapkey[resources.Length];
        for (int index = 0; index < resources.Length; ++index)
        {
          sslwrapkeyArray[index] = new sslwrapkey();
          sslwrapkeyArray[index].wrapkeyname = resources[index].wrapkeyname;
        }
        baseResponses = base_resource.delete_bulk_request(client, (base_resource[]) sslwrapkeyArray);
      }
      return baseResponses;
    }

    public static sslwrapkey[] get(nitro_service service) => (sslwrapkey[]) new sslwrapkey().get_resources(service, (options) null);

    public static sslwrapkey[] get(nitro_service service, options option) => (sslwrapkey[]) new sslwrapkey().get_resources(service, option);

    public static sslwrapkey[] get_filtered(nitro_service service, string filter)
    {
      sslwrapkey sslwrapkey = new sslwrapkey();
      options option = new options();
      option.set_filter(filter);
      return (sslwrapkey[]) sslwrapkey.getfiltered(service, option);
    }

    public static sslwrapkey[] get_filtered(nitro_service service, filtervalue[] filter)
    {
      sslwrapkey sslwrapkey = new sslwrapkey();
      options option = new options();
      option.set_filter(filter);
      return (sslwrapkey[]) sslwrapkey.getfiltered(service, option);
    }

    public static uint count(nitro_service service)
    {
      sslwrapkey sslwrapkey = new sslwrapkey();
      options option = new options();
      option.set_count(true);
      sslwrapkey[] resources = (sslwrapkey[]) sslwrapkey.get_resources(service, option);
      return resources != null && resources.Length > 0 ? resources[0].__count.Value : 0U;
    }

    public static uint count_filtered(nitro_service service, string filter)
    {
      sslwrapkey sslwrapkey = new sslwrapkey();
      options option = new options();
      option.set_count(true);
      option.set_filter(filter);
      sslwrapkey[] sslwrapkeyArray = (sslwrapkey[]) sslwrapkey.getfiltered(service, option);
      return sslwrapkeyArray != null && sslwrapkeyArray.Length > 0 ? sslwrapkeyArray[0].__count.Value : 0U;
    }

    public static uint count_filtered(nitro_service service, filtervalue[] filter)
    {
      sslwrapkey sslwrapkey = new sslwrapkey();
      options option = new options();
      option.set_count(true);
      option.set_filter(filter);
      sslwrapkey[] sslwrapkeyArray = (sslwrapkey[]) sslwrapkey.getfiltered(service, option);
      return sslwrapkeyArray != null && sslwrapkeyArray.Length > 0 ? sslwrapkeyArray[0].__count.Value : 0U;
    }

    private class sslwrapkey_response : base_response
    {
      public sslwrapkey[] sslwrapkey = (sslwrapkey[]) null;
    }
  }
}
