// Decompiled with JetBrains decompiler
// Type: com.citrix.netscaler.nitro.resource.config.aaa.aaauser
// Assembly: nitro, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 6CF5DDEF-E052-4F9D-953F-6644F8378A66


using com.citrix.netscaler.nitro.exception;
using com.citrix.netscaler.nitro.resource.Base;
using com.citrix.netscaler.nitro.service;
using com.citrix.netscaler.nitro.util;

namespace com.citrix.netscaler.nitro.resource.config.aaa
{
  public class aaauser : base_resource
  {
    private string usernameField = (string) null;
    private string passwordField = (string) null;
    private bool? loggedinField = new bool?();
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

    public bool? loggedin
    {
      get => this.loggedinField;
      set => this.loggedinField = value;
    }

    internal override base_resource[] get_nitro_response(
      nitro_service service,
      string response)
    {
      aaauser.aaauser_response aaauserResponse = new aaauser.aaauser_response();
      aaauser.aaauser_response resource = (aaauser.aaauser_response) service.get_payload_formatter().string_to_resource(aaauserResponse.GetType(), response);
      if (resource.errorcode != 0)
      {
        if (resource.errorcode == 444)
          service.clear_session();
        if (resource.severity == null)
          throw new nitro_exception(resource.message, resource.errorcode);
        if (resource.severity.Equals("ERROR"))
          throw new nitro_exception(resource.message, resource.errorcode);
      }
      return (base_resource[]) resource.aaauser;
    }

    internal override string get_object_name() => this.username;

    public static base_response add(nitro_service client, aaauser resource) => new aaauser()
    {
      username = resource.username,
      password = resource.password
    }.add_resource(client);

    public static base_responses add(nitro_service client, aaauser[] resources)
    {
      base_responses baseResponses = (base_responses) null;
      if (resources != null && resources.Length > 0)
      {
        aaauser[] aaauserArray = new aaauser[resources.Length];
        for (int index = 0; index < resources.Length; ++index)
        {
          aaauserArray[index] = new aaauser();
          aaauserArray[index].username = resources[index].username;
          aaauserArray[index].password = resources[index].password;
        }
        baseResponses = base_resource.add_bulk_request(client, (base_resource[]) aaauserArray);
      }
      return baseResponses;
    }

    public static base_response delete(nitro_service client, string username) => new aaauser()
    {
      username = username
    }.delete_resource(client);

    public static base_response delete(nitro_service client, aaauser resource) => new aaauser()
    {
      username = resource.username
    }.delete_resource(client);

    public static base_responses delete(nitro_service client, string[] username)
    {
      base_responses baseResponses = (base_responses) null;
      if (username != null && username.Length > 0)
      {
        aaauser[] aaauserArray = new aaauser[username.Length];
        for (int index = 0; index < username.Length; ++index)
        {
          aaauserArray[index] = new aaauser();
          aaauserArray[index].username = username[index];
        }
        baseResponses = base_resource.delete_bulk_request(client, (base_resource[]) aaauserArray);
      }
      return baseResponses;
    }

    public static base_responses delete(nitro_service client, aaauser[] resources)
    {
      base_responses baseResponses = (base_responses) null;
      if (resources != null && resources.Length > 0)
      {
        aaauser[] aaauserArray = new aaauser[resources.Length];
        for (int index = 0; index < resources.Length; ++index)
        {
          aaauserArray[index] = new aaauser();
          aaauserArray[index].username = resources[index].username;
        }
        baseResponses = base_resource.delete_bulk_request(client, (base_resource[]) aaauserArray);
      }
      return baseResponses;
    }

    public static base_response update(nitro_service client, aaauser resource) => new aaauser()
    {
      username = resource.username,
      password = resource.password
    }.update_resource(client);

    public static base_responses update(nitro_service client, aaauser[] resources)
    {
      base_responses baseResponses = (base_responses) null;
      if (resources != null && resources.Length > 0)
      {
        aaauser[] aaauserArray = new aaauser[resources.Length];
        for (int index = 0; index < resources.Length; ++index)
        {
          aaauserArray[index] = new aaauser();
          aaauserArray[index].username = resources[index].username;
          aaauserArray[index].password = resources[index].password;
        }
        baseResponses = base_resource.update_bulk_request(client, (base_resource[]) aaauserArray);
      }
      return baseResponses;
    }

    public static base_response unlock(nitro_service client, aaauser resource) => new aaauser()
    {
      username = resource.username
    }.perform_operation_byaction(client, nameof (unlock));

    public static base_responses unlock(nitro_service client, aaauser[] resources)
    {
      base_responses baseResponses = (base_responses) null;
      if (resources != null && resources.Length > 0)
      {
        aaauser[] aaauserArray = new aaauser[resources.Length];
        for (int index = 0; index < resources.Length; ++index)
        {
          aaauserArray[index] = new aaauser();
          aaauserArray[index].username = resources[index].username;
        }
        baseResponses = base_resource.perform_operation_bulk_request(client, (base_resource[]) aaauserArray, nameof (unlock));
      }
      return baseResponses;
    }

    public static aaauser[] get(nitro_service service) => (aaauser[]) new aaauser().get_resources(service, (options) null);

    public static aaauser[] get(nitro_service service, options option) => (aaauser[]) new aaauser().get_resources(service, option);

    public static aaauser[] get(nitro_service service, aaauser_args args)
    {
      aaauser aaauser = new aaauser();
      options option = new options();
      option.set_args(nitro_util.object_to_string_withoutquotes((object) args));
      return (aaauser[]) aaauser.get_resources(service, option);
    }

    public static aaauser get(nitro_service service, string username) => (aaauser) new aaauser()
    {
      username = username
    }.get_resource(service);

    public static aaauser[] get(nitro_service service, string[] username)
    {
      if (username == null || username.Length <= 0)
        return (aaauser[]) null;
      aaauser[] aaauserArray1 = new aaauser[username.Length];
      aaauser[] aaauserArray2 = new aaauser[username.Length];
      for (int index = 0; index < username.Length; ++index)
      {
        aaauserArray2[index] = new aaauser();
        aaauserArray2[index].username = username[index];
        aaauserArray1[index] = (aaauser) aaauserArray2[index].get_resource(service);
      }
      return aaauserArray1;
    }

    public static aaauser[] get_filtered(nitro_service service, string filter)
    {
      aaauser aaauser = new aaauser();
      options option = new options();
      option.set_filter(filter);
      return (aaauser[]) aaauser.getfiltered(service, option);
    }

    public static aaauser[] get_filtered(nitro_service service, filtervalue[] filter)
    {
      aaauser aaauser = new aaauser();
      options option = new options();
      option.set_filter(filter);
      return (aaauser[]) aaauser.getfiltered(service, option);
    }

    public static uint count(nitro_service service)
    {
      aaauser aaauser = new aaauser();
      options option = new options();
      option.set_count(true);
      aaauser[] resources = (aaauser[]) aaauser.get_resources(service, option);
      return resources != null && resources.Length > 0 ? resources[0].__count.Value : 0U;
    }

    public static uint count_filtered(nitro_service service, string filter)
    {
      aaauser aaauser = new aaauser();
      options option = new options();
      option.set_count(true);
      option.set_filter(filter);
      aaauser[] aaauserArray = (aaauser[]) aaauser.getfiltered(service, option);
      return aaauserArray != null && aaauserArray.Length > 0 ? aaauserArray[0].__count.Value : 0U;
    }

    public static uint count_filtered(nitro_service service, filtervalue[] filter)
    {
      aaauser aaauser = new aaauser();
      options option = new options();
      option.set_count(true);
      option.set_filter(filter);
      aaauser[] aaauserArray = (aaauser[]) aaauser.getfiltered(service, option);
      return aaauserArray != null && aaauserArray.Length > 0 ? aaauserArray[0].__count.Value : 0U;
    }

    private class aaauser_response : base_response
    {
      public aaauser[] aaauser = (aaauser[]) null;
    }
  }
}
