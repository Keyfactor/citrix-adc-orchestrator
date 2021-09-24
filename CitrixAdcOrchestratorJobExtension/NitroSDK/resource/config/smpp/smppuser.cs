// Decompiled with JetBrains decompiler
// Type: com.citrix.netscaler.nitro.resource.config.smpp.smppuser
// Assembly: nitro, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 6CF5DDEF-E052-4F9D-953F-6644F8378A66


using com.citrix.netscaler.nitro.exception;
using com.citrix.netscaler.nitro.resource.Base;
using com.citrix.netscaler.nitro.service;
using com.citrix.netscaler.nitro.util;

namespace com.citrix.netscaler.nitro.resource.config.smpp
{
  public class smppuser : base_resource
  {
    private string usernameField = (string) null;
    private string passwordField = (string) null;
    private uint? __countField = new uint?();

    public uint? __count
    {
      get => this.__countField;
      private set => this.__countField = value;
    }

    public string username
    {
      get => this.usernameField;
      set => this.usernameField = value;
    }

    public string password
    {
      get => this.passwordField;
      set => this.passwordField = value;
    }

    internal override base_resource[] get_nitro_response(
      nitro_service service,
      string response)
    {
      smppuser.smppuser_response smppuserResponse = new smppuser.smppuser_response();
      smppuser.smppuser_response resource = (smppuser.smppuser_response) service.get_payload_formatter().string_to_resource(smppuserResponse.GetType(), response);
      if (resource.errorcode != 0)
      {
        if (resource.errorcode == 444)
          service.clear_session();
        if (resource.severity == null)
          throw new nitro_exception(resource.message, resource.errorcode);
        if (resource.severity.Equals("ERROR"))
          throw new nitro_exception(resource.message, resource.errorcode);
      }
      return (base_resource[]) resource.smppuser;
    }

    internal override string get_object_name() => this.username;

    public static base_response add(nitro_service client, smppuser resource) => new smppuser()
    {
      username = resource.username,
      password = resource.password
    }.add_resource(client);

    public static base_responses add(nitro_service client, smppuser[] resources)
    {
      base_responses baseResponses = (base_responses) null;
      if (resources != null && resources.Length > 0)
      {
        smppuser[] smppuserArray = new smppuser[resources.Length];
        for (int index = 0; index < resources.Length; ++index)
        {
          smppuserArray[index] = new smppuser();
          smppuserArray[index].username = resources[index].username;
          smppuserArray[index].password = resources[index].password;
        }
        baseResponses = base_resource.add_bulk_request(client, (base_resource[]) smppuserArray);
      }
      return baseResponses;
    }

    public static base_response delete(nitro_service client, string username) => new smppuser()
    {
      username = username
    }.delete_resource(client);

    public static base_response delete(nitro_service client, smppuser resource) => new smppuser()
    {
      username = resource.username
    }.delete_resource(client);

    public static base_responses delete(nitro_service client, string[] username)
    {
      base_responses baseResponses = (base_responses) null;
      if (username != null && username.Length > 0)
      {
        smppuser[] smppuserArray = new smppuser[username.Length];
        for (int index = 0; index < username.Length; ++index)
        {
          smppuserArray[index] = new smppuser();
          smppuserArray[index].username = username[index];
        }
        baseResponses = base_resource.delete_bulk_request(client, (base_resource[]) smppuserArray);
      }
      return baseResponses;
    }

    public static base_responses delete(nitro_service client, smppuser[] resources)
    {
      base_responses baseResponses = (base_responses) null;
      if (resources != null && resources.Length > 0)
      {
        smppuser[] smppuserArray = new smppuser[resources.Length];
        for (int index = 0; index < resources.Length; ++index)
        {
          smppuserArray[index] = new smppuser();
          smppuserArray[index].username = resources[index].username;
        }
        baseResponses = base_resource.delete_bulk_request(client, (base_resource[]) smppuserArray);
      }
      return baseResponses;
    }

    public static base_response update(nitro_service client, smppuser resource) => new smppuser()
    {
      username = resource.username,
      password = resource.password
    }.update_resource(client);

    public static base_responses update(nitro_service client, smppuser[] resources)
    {
      base_responses baseResponses = (base_responses) null;
      if (resources != null && resources.Length > 0)
      {
        smppuser[] smppuserArray = new smppuser[resources.Length];
        for (int index = 0; index < resources.Length; ++index)
        {
          smppuserArray[index] = new smppuser();
          smppuserArray[index].username = resources[index].username;
          smppuserArray[index].password = resources[index].password;
        }
        baseResponses = base_resource.update_bulk_request(client, (base_resource[]) smppuserArray);
      }
      return baseResponses;
    }

    public static smppuser[] get(nitro_service service) => (smppuser[]) new smppuser().get_resources(service, (options) null);

    public static smppuser[] get(nitro_service service, options option) => (smppuser[]) new smppuser().get_resources(service, option);

    public static smppuser get(nitro_service service, string username) => (smppuser) new smppuser()
    {
      username = username
    }.get_resource(service);

    public static smppuser[] get(nitro_service service, string[] username)
    {
      if (username == null || username.Length <= 0)
        return (smppuser[]) null;
      smppuser[] smppuserArray1 = new smppuser[username.Length];
      smppuser[] smppuserArray2 = new smppuser[username.Length];
      for (int index = 0; index < username.Length; ++index)
      {
        smppuserArray2[index] = new smppuser();
        smppuserArray2[index].username = username[index];
        smppuserArray1[index] = (smppuser) smppuserArray2[index].get_resource(service);
      }
      return smppuserArray1;
    }

    public static smppuser[] get_filtered(nitro_service service, string filter)
    {
      smppuser smppuser = new smppuser();
      options option = new options();
      option.set_filter(filter);
      return (smppuser[]) smppuser.getfiltered(service, option);
    }

    public static smppuser[] get_filtered(nitro_service service, filtervalue[] filter)
    {
      smppuser smppuser = new smppuser();
      options option = new options();
      option.set_filter(filter);
      return (smppuser[]) smppuser.getfiltered(service, option);
    }

    public static uint count(nitro_service service)
    {
      smppuser smppuser = new smppuser();
      options option = new options();
      option.set_count(true);
      smppuser[] resources = (smppuser[]) smppuser.get_resources(service, option);
      return resources != null && resources.Length > 0 ? resources[0].__count.Value : 0U;
    }

    public static uint count_filtered(nitro_service service, string filter)
    {
      smppuser smppuser = new smppuser();
      options option = new options();
      option.set_count(true);
      option.set_filter(filter);
      smppuser[] smppuserArray = (smppuser[]) smppuser.getfiltered(service, option);
      return smppuserArray != null && smppuserArray.Length > 0 ? smppuserArray[0].__count.Value : 0U;
    }

    public static uint count_filtered(nitro_service service, filtervalue[] filter)
    {
      smppuser smppuser = new smppuser();
      options option = new options();
      option.set_count(true);
      option.set_filter(filter);
      smppuser[] smppuserArray = (smppuser[]) smppuser.getfiltered(service, option);
      return smppuserArray != null && smppuserArray.Length > 0 ? smppuserArray[0].__count.Value : 0U;
    }

    private class smppuser_response : base_response
    {
      public smppuser[] smppuser = (smppuser[]) null;
    }
  }
}
