// Decompiled with JetBrains decompiler
// Type: com.citrix.netscaler.nitro.resource.config.system.systemuser
// Assembly: nitro, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 6CF5DDEF-E052-4F9D-953F-6644F8378A66


using com.citrix.netscaler.nitro.exception;
using com.citrix.netscaler.nitro.resource.Base;
using com.citrix.netscaler.nitro.service;
using com.citrix.netscaler.nitro.util;

namespace com.citrix.netscaler.nitro.resource.config.system
{
  public class systemuser : base_resource
  {
    private string usernameField = (string) null;
    private string passwordField = (string) null;
    private string externalauthField = (string) null;
    private string promptstringField = (string) null;
    private long? timeoutField = new long?();
    private string loggingField = (string) null;
    private uint? maxsessionField = new uint?();
    private bool? encryptedField = new bool?();
    private string promptinheritedfromField = (string) null;
    private string timeoutkindField = (string) null;
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

    public string externalauth
    {
      get => this.externalauthField;
      set => this.externalauthField = value;
    }

    public string promptstring
    {
      get => this.promptstringField;
      set => this.promptstringField = value;
    }

    public long? timeout
    {
      get => this.timeoutField;
      set => this.timeoutField = value;
    }

    public string logging
    {
      get => this.loggingField;
      set => this.loggingField = value;
    }

    public uint? maxsession
    {
      get => this.maxsessionField;
      set => this.maxsessionField = value;
    }

    public bool? encrypted
    {
      get => this.encryptedField;
      private set => this.encryptedField = value;
    }

    public string promptinheritedfrom
    {
      get => this.promptinheritedfromField;
      private set => this.promptinheritedfromField = value;
    }

    public string timeoutkind
    {
      get => this.timeoutkindField;
      private set => this.timeoutkindField = value;
    }

    internal override base_resource[] get_nitro_response(
      nitro_service service,
      string response)
    {
      systemuser.systemuser_response systemuserResponse = new systemuser.systemuser_response();
      systemuser.systemuser_response resource = (systemuser.systemuser_response) service.get_payload_formatter().string_to_resource(systemuserResponse.GetType(), response);
      if (resource.errorcode != 0)
      {
        if (resource.errorcode == 444)
          service.clear_session();
        if (resource.severity == null)
          throw new nitro_exception(resource.message, resource.errorcode);
        if (resource.severity.Equals("ERROR"))
          throw new nitro_exception(resource.message, resource.errorcode);
      }
      return (base_resource[]) resource.systemuser;
    }

    internal override string get_object_name() => this.username;

    public static base_response add(nitro_service client, systemuser resource) => new systemuser()
    {
      username = resource.username,
      password = resource.password,
      externalauth = resource.externalauth,
      promptstring = resource.promptstring,
      timeout = resource.timeout,
      logging = resource.logging,
      maxsession = resource.maxsession
    }.add_resource(client);

    public static base_responses add(nitro_service client, systemuser[] resources)
    {
      base_responses baseResponses = (base_responses) null;
      if (resources != null && resources.Length > 0)
      {
        systemuser[] systemuserArray = new systemuser[resources.Length];
        for (int index = 0; index < resources.Length; ++index)
        {
          systemuserArray[index] = new systemuser();
          systemuserArray[index].username = resources[index].username;
          systemuserArray[index].password = resources[index].password;
          systemuserArray[index].externalauth = resources[index].externalauth;
          systemuserArray[index].promptstring = resources[index].promptstring;
          systemuserArray[index].timeout = resources[index].timeout;
          systemuserArray[index].logging = resources[index].logging;
          systemuserArray[index].maxsession = resources[index].maxsession;
        }
        baseResponses = base_resource.add_bulk_request(client, (base_resource[]) systemuserArray);
      }
      return baseResponses;
    }

    public static base_response delete(nitro_service client, string username) => new systemuser()
    {
      username = username
    }.delete_resource(client);

    public static base_response delete(nitro_service client, systemuser resource) => new systemuser()
    {
      username = resource.username
    }.delete_resource(client);

    public static base_responses delete(nitro_service client, string[] username)
    {
      base_responses baseResponses = (base_responses) null;
      if (username != null && username.Length > 0)
      {
        systemuser[] systemuserArray = new systemuser[username.Length];
        for (int index = 0; index < username.Length; ++index)
        {
          systemuserArray[index] = new systemuser();
          systemuserArray[index].username = username[index];
        }
        baseResponses = base_resource.delete_bulk_request(client, (base_resource[]) systemuserArray);
      }
      return baseResponses;
    }

    public static base_responses delete(nitro_service client, systemuser[] resources)
    {
      base_responses baseResponses = (base_responses) null;
      if (resources != null && resources.Length > 0)
      {
        systemuser[] systemuserArray = new systemuser[resources.Length];
        for (int index = 0; index < resources.Length; ++index)
        {
          systemuserArray[index] = new systemuser();
          systemuserArray[index].username = resources[index].username;
        }
        baseResponses = base_resource.delete_bulk_request(client, (base_resource[]) systemuserArray);
      }
      return baseResponses;
    }

    public static base_response update(nitro_service client, systemuser resource) => new systemuser()
    {
      username = resource.username,
      password = resource.password,
      externalauth = resource.externalauth,
      promptstring = resource.promptstring,
      timeout = resource.timeout,
      logging = resource.logging,
      maxsession = resource.maxsession
    }.update_resource(client);

    public static base_responses update(nitro_service client, systemuser[] resources)
    {
      base_responses baseResponses = (base_responses) null;
      if (resources != null && resources.Length > 0)
      {
        systemuser[] systemuserArray = new systemuser[resources.Length];
        for (int index = 0; index < resources.Length; ++index)
        {
          systemuserArray[index] = new systemuser();
          systemuserArray[index].username = resources[index].username;
          systemuserArray[index].password = resources[index].password;
          systemuserArray[index].externalauth = resources[index].externalauth;
          systemuserArray[index].promptstring = resources[index].promptstring;
          systemuserArray[index].timeout = resources[index].timeout;
          systemuserArray[index].logging = resources[index].logging;
          systemuserArray[index].maxsession = resources[index].maxsession;
        }
        baseResponses = base_resource.update_bulk_request(client, (base_resource[]) systemuserArray);
      }
      return baseResponses;
    }

    public static base_response unset(
      nitro_service client,
      string username,
      string[] args)
    {
      return new systemuser() { username = username }.unset_resource(client, args);
    }

    public static base_response unset(
      nitro_service client,
      systemuser resource,
      string[] args)
    {
      return new systemuser()
      {
        username = resource.username
      }.unset_resource(client, args);
    }

    public static base_responses unset(
      nitro_service client,
      string[] username,
      string[] args)
    {
      base_responses baseResponses = (base_responses) null;
      if (username != null && username.Length > 0)
      {
        systemuser[] systemuserArray = new systemuser[username.Length];
        for (int index = 0; index < username.Length; ++index)
        {
          systemuserArray[index] = new systemuser();
          systemuserArray[index].username = username[index];
        }
        baseResponses = base_resource.unset_bulk_request(client, (base_resource[]) systemuserArray, args);
      }
      return baseResponses;
    }

    public static base_responses unset(
      nitro_service client,
      systemuser[] resources,
      string[] args)
    {
      base_responses baseResponses = (base_responses) null;
      if (resources != null && resources.Length > 0)
      {
        systemuser[] systemuserArray = new systemuser[resources.Length];
        for (int index = 0; index < resources.Length; ++index)
        {
          systemuserArray[index] = new systemuser();
          systemuserArray[index].username = resources[index].username;
        }
        baseResponses = base_resource.unset_bulk_request(client, (base_resource[]) systemuserArray, args);
      }
      return baseResponses;
    }

    public static systemuser[] get(nitro_service service) => (systemuser[]) new systemuser().get_resources(service, (options) null);

    public static systemuser[] get(nitro_service service, options option) => (systemuser[]) new systemuser().get_resources(service, option);

    public static systemuser get(nitro_service service, string username) => (systemuser) new systemuser()
    {
      username = username
    }.get_resource(service);

    public static systemuser[] get(nitro_service service, string[] username)
    {
      if (username == null || username.Length <= 0)
        return (systemuser[]) null;
      systemuser[] systemuserArray1 = new systemuser[username.Length];
      systemuser[] systemuserArray2 = new systemuser[username.Length];
      for (int index = 0; index < username.Length; ++index)
      {
        systemuserArray2[index] = new systemuser();
        systemuserArray2[index].username = username[index];
        systemuserArray1[index] = (systemuser) systemuserArray2[index].get_resource(service);
      }
      return systemuserArray1;
    }

    public static systemuser[] get_filtered(nitro_service service, string filter)
    {
      systemuser systemuser = new systemuser();
      options option = new options();
      option.set_filter(filter);
      return (systemuser[]) systemuser.getfiltered(service, option);
    }

    public static systemuser[] get_filtered(nitro_service service, filtervalue[] filter)
    {
      systemuser systemuser = new systemuser();
      options option = new options();
      option.set_filter(filter);
      return (systemuser[]) systemuser.getfiltered(service, option);
    }

    public static uint count(nitro_service service)
    {
      systemuser systemuser = new systemuser();
      options option = new options();
      option.set_count(true);
      systemuser[] resources = (systemuser[]) systemuser.get_resources(service, option);
      return resources != null && resources.Length > 0 ? resources[0].__count.Value : 0U;
    }

    public static uint count_filtered(nitro_service service, string filter)
    {
      systemuser systemuser = new systemuser();
      options option = new options();
      option.set_count(true);
      option.set_filter(filter);
      systemuser[] systemuserArray = (systemuser[]) systemuser.getfiltered(service, option);
      return systemuserArray != null && systemuserArray.Length > 0 ? systemuserArray[0].__count.Value : 0U;
    }

    public static uint count_filtered(nitro_service service, filtervalue[] filter)
    {
      systemuser systemuser = new systemuser();
      options option = new options();
      option.set_count(true);
      option.set_filter(filter);
      systemuser[] systemuserArray = (systemuser[]) systemuser.getfiltered(service, option);
      return systemuserArray != null && systemuserArray.Length > 0 ? systemuserArray[0].__count.Value : 0U;
    }

    private class systemuser_response : base_response
    {
      public systemuser[] systemuser = (systemuser[]) null;
    }

    public static class timeoutkindEnum
    {
      public const string User = "User";
      public const string Group = "Group";
      public const string Global = "Global";
      public const string Climode = "Climode";
    }

    public static class promptinheritedfromEnum
    {
      public const string User = "User";
      public const string Group = "Group";
      public const string Global = "Global";
      public const string Climode = "Climode";
    }

    public static class loggingEnum
    {
      public const string ENABLED = "ENABLED";
      public const string DISABLED = "DISABLED";
    }

    public static class externalauthEnum
    {
      public const string ENABLED = "ENABLED";
      public const string DISABLED = "DISABLED";
    }
  }
}
