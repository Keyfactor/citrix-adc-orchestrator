// Decompiled with JetBrains decompiler
// Type: com.citrix.netscaler.nitro.resource.config.db.dbuser
// Assembly: nitro, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 6CF5DDEF-E052-4F9D-953F-6644F8378A66


using com.citrix.netscaler.nitro.exception;
using com.citrix.netscaler.nitro.resource.Base;
using com.citrix.netscaler.nitro.service;
using com.citrix.netscaler.nitro.util;

namespace com.citrix.netscaler.nitro.resource.config.db
{
  public class dbuser : base_resource
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
      dbuser.dbuser_response dbuserResponse = new dbuser.dbuser_response();
      dbuser.dbuser_response resource = (dbuser.dbuser_response) service.get_payload_formatter().string_to_resource(dbuserResponse.GetType(), response);
      if (resource.errorcode != 0)
      {
        if (resource.errorcode == 444)
          service.clear_session();
        if (resource.severity == null)
          throw new nitro_exception(resource.message, resource.errorcode);
        if (resource.severity.Equals("ERROR"))
          throw new nitro_exception(resource.message, resource.errorcode);
      }
      return (base_resource[]) resource.dbuser;
    }

    internal override string get_object_name() => this.username;

    public static base_response add(nitro_service client, dbuser resource) => new dbuser()
    {
      username = resource.username,
      password = resource.password
    }.add_resource(client);

    public static base_responses add(nitro_service client, dbuser[] resources)
    {
      base_responses baseResponses = (base_responses) null;
      if (resources != null && resources.Length > 0)
      {
        dbuser[] dbuserArray = new dbuser[resources.Length];
        for (int index = 0; index < resources.Length; ++index)
        {
          dbuserArray[index] = new dbuser();
          dbuserArray[index].username = resources[index].username;
          dbuserArray[index].password = resources[index].password;
        }
        baseResponses = base_resource.add_bulk_request(client, (base_resource[]) dbuserArray);
      }
      return baseResponses;
    }

    public static base_response delete(nitro_service client, string username) => new dbuser()
    {
      username = username
    }.delete_resource(client);

    public static base_response delete(nitro_service client, dbuser resource) => new dbuser()
    {
      username = resource.username
    }.delete_resource(client);

    public static base_responses delete(nitro_service client, string[] username)
    {
      base_responses baseResponses = (base_responses) null;
      if (username != null && username.Length > 0)
      {
        dbuser[] dbuserArray = new dbuser[username.Length];
        for (int index = 0; index < username.Length; ++index)
        {
          dbuserArray[index] = new dbuser();
          dbuserArray[index].username = username[index];
        }
        baseResponses = base_resource.delete_bulk_request(client, (base_resource[]) dbuserArray);
      }
      return baseResponses;
    }

    public static base_responses delete(nitro_service client, dbuser[] resources)
    {
      base_responses baseResponses = (base_responses) null;
      if (resources != null && resources.Length > 0)
      {
        dbuser[] dbuserArray = new dbuser[resources.Length];
        for (int index = 0; index < resources.Length; ++index)
        {
          dbuserArray[index] = new dbuser();
          dbuserArray[index].username = resources[index].username;
        }
        baseResponses = base_resource.delete_bulk_request(client, (base_resource[]) dbuserArray);
      }
      return baseResponses;
    }

    public static base_response update(nitro_service client, dbuser resource) => new dbuser()
    {
      username = resource.username,
      password = resource.password
    }.update_resource(client);

    public static base_responses update(nitro_service client, dbuser[] resources)
    {
      base_responses baseResponses = (base_responses) null;
      if (resources != null && resources.Length > 0)
      {
        dbuser[] dbuserArray = new dbuser[resources.Length];
        for (int index = 0; index < resources.Length; ++index)
        {
          dbuserArray[index] = new dbuser();
          dbuserArray[index].username = resources[index].username;
          dbuserArray[index].password = resources[index].password;
        }
        baseResponses = base_resource.update_bulk_request(client, (base_resource[]) dbuserArray);
      }
      return baseResponses;
    }

    public static dbuser[] get(nitro_service service) => (dbuser[]) new dbuser().get_resources(service, (options) null);

    public static dbuser[] get(nitro_service service, options option) => (dbuser[]) new dbuser().get_resources(service, option);

    public static dbuser[] get(nitro_service service, dbuser_args args)
    {
      dbuser dbuser = new dbuser();
      options option = new options();
      option.set_args(nitro_util.object_to_string_withoutquotes((object) args));
      return (dbuser[]) dbuser.get_resources(service, option);
    }

    public static dbuser get(nitro_service service, string username) => (dbuser) new dbuser()
    {
      username = username
    }.get_resource(service);

    public static dbuser[] get(nitro_service service, string[] username)
    {
      if (username == null || username.Length <= 0)
        return (dbuser[]) null;
      dbuser[] dbuserArray1 = new dbuser[username.Length];
      dbuser[] dbuserArray2 = new dbuser[username.Length];
      for (int index = 0; index < username.Length; ++index)
      {
        dbuserArray2[index] = new dbuser();
        dbuserArray2[index].username = username[index];
        dbuserArray1[index] = (dbuser) dbuserArray2[index].get_resource(service);
      }
      return dbuserArray1;
    }

    public static dbuser[] get_filtered(nitro_service service, string filter)
    {
      dbuser dbuser = new dbuser();
      options option = new options();
      option.set_filter(filter);
      return (dbuser[]) dbuser.getfiltered(service, option);
    }

    public static dbuser[] get_filtered(nitro_service service, filtervalue[] filter)
    {
      dbuser dbuser = new dbuser();
      options option = new options();
      option.set_filter(filter);
      return (dbuser[]) dbuser.getfiltered(service, option);
    }

    public static uint count(nitro_service service)
    {
      dbuser dbuser = new dbuser();
      options option = new options();
      option.set_count(true);
      dbuser[] resources = (dbuser[]) dbuser.get_resources(service, option);
      return resources != null && resources.Length > 0 ? resources[0].__count.Value : 0U;
    }

    public static uint count_filtered(nitro_service service, string filter)
    {
      dbuser dbuser = new dbuser();
      options option = new options();
      option.set_count(true);
      option.set_filter(filter);
      dbuser[] dbuserArray = (dbuser[]) dbuser.getfiltered(service, option);
      return dbuserArray != null && dbuserArray.Length > 0 ? dbuserArray[0].__count.Value : 0U;
    }

    public static uint count_filtered(nitro_service service, filtervalue[] filter)
    {
      dbuser dbuser = new dbuser();
      options option = new options();
      option.set_count(true);
      option.set_filter(filter);
      dbuser[] dbuserArray = (dbuser[]) dbuser.getfiltered(service, option);
      return dbuserArray != null && dbuserArray.Length > 0 ? dbuserArray[0].__count.Value : 0U;
    }

    private class dbuser_response : base_response
    {
      public dbuser[] dbuser = (dbuser[]) null;
    }
  }
}
