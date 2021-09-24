// Decompiled with JetBrains decompiler
// Type: com.citrix.netscaler.nitro.resource.config.authentication.authenticationloginschema
// Assembly: nitro, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 6CF5DDEF-E052-4F9D-953F-6644F8378A66


using com.citrix.netscaler.nitro.exception;
using com.citrix.netscaler.nitro.resource.Base;
using com.citrix.netscaler.nitro.service;
using com.citrix.netscaler.nitro.util;

namespace com.citrix.netscaler.nitro.resource.config.authentication
{
  public class authenticationloginschema : base_resource
  {
    private string nameField = (string) null;
    private string authenticationschemaField = (string) null;
    private string userexpressionField = (string) null;
    private string passwdexpressionField = (string) null;
    private uint? usercredentialindexField = new uint?();
    private uint? passwordcredentialindexField = new uint?();
    private uint? authenticationstrengthField = new uint?();
    private string[] builtinField = (string[]) null;
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

    public string authenticationschema
    {
      get => this.authenticationschemaField;
      set => this.authenticationschemaField = value;
    }

    public string userexpression
    {
      get => this.userexpressionField;
      set => this.userexpressionField = value;
    }

    public string passwdexpression
    {
      get => this.passwdexpressionField;
      set => this.passwdexpressionField = value;
    }

    public uint? usercredentialindex
    {
      get => this.usercredentialindexField;
      set => this.usercredentialindexField = value;
    }

    public uint? passwordcredentialindex
    {
      get => this.passwordcredentialindexField;
      set => this.passwordcredentialindexField = value;
    }

    public uint? authenticationstrength
    {
      get => this.authenticationstrengthField;
      set => this.authenticationstrengthField = value;
    }

    public string[] builtin
    {
      get => this.builtinField;
      private set => this.builtinField = value;
    }

    internal override base_resource[] get_nitro_response(
      nitro_service service,
      string response)
    {
      authenticationloginschema.authenticationloginschema_response authenticationloginschemaResponse = new authenticationloginschema.authenticationloginschema_response();
      authenticationloginschema.authenticationloginschema_response resource = (authenticationloginschema.authenticationloginschema_response) service.get_payload_formatter().string_to_resource(authenticationloginschemaResponse.GetType(), response);
      if (resource.errorcode != 0)
      {
        if (resource.errorcode == 444)
          service.clear_session();
        if (resource.severity == null)
          throw new nitro_exception(resource.message, resource.errorcode);
        if (resource.severity.Equals("ERROR"))
          throw new nitro_exception(resource.message, resource.errorcode);
      }
      return (base_resource[]) resource.authenticationloginschema;
    }

    internal override string get_object_name() => this.name;

    public static base_response add(
      nitro_service client,
      authenticationloginschema resource)
    {
      return new authenticationloginschema()
      {
        name = resource.name,
        authenticationschema = resource.authenticationschema,
        userexpression = resource.userexpression,
        passwdexpression = resource.passwdexpression,
        usercredentialindex = resource.usercredentialindex,
        passwordcredentialindex = resource.passwordcredentialindex,
        authenticationstrength = resource.authenticationstrength
      }.add_resource(client);
    }

    public static base_responses add(
      nitro_service client,
      authenticationloginschema[] resources)
    {
      base_responses baseResponses = (base_responses) null;
      if (resources != null && resources.Length > 0)
      {
        authenticationloginschema[] authenticationloginschemaArray = new authenticationloginschema[resources.Length];
        for (int index = 0; index < resources.Length; ++index)
        {
          authenticationloginschemaArray[index] = new authenticationloginschema();
          authenticationloginschemaArray[index].name = resources[index].name;
          authenticationloginschemaArray[index].authenticationschema = resources[index].authenticationschema;
          authenticationloginschemaArray[index].userexpression = resources[index].userexpression;
          authenticationloginschemaArray[index].passwdexpression = resources[index].passwdexpression;
          authenticationloginschemaArray[index].usercredentialindex = resources[index].usercredentialindex;
          authenticationloginschemaArray[index].passwordcredentialindex = resources[index].passwordcredentialindex;
          authenticationloginschemaArray[index].authenticationstrength = resources[index].authenticationstrength;
        }
        baseResponses = base_resource.add_bulk_request(client, (base_resource[]) authenticationloginschemaArray);
      }
      return baseResponses;
    }

    public static base_response delete(nitro_service client, string name) => new authenticationloginschema()
    {
      name = name
    }.delete_resource(client);

    public static base_response delete(
      nitro_service client,
      authenticationloginschema resource)
    {
      return new authenticationloginschema()
      {
        name = resource.name
      }.delete_resource(client);
    }

    public static base_responses delete(nitro_service client, string[] name)
    {
      base_responses baseResponses = (base_responses) null;
      if (name != null && name.Length > 0)
      {
        authenticationloginschema[] authenticationloginschemaArray = new authenticationloginschema[name.Length];
        for (int index = 0; index < name.Length; ++index)
        {
          authenticationloginschemaArray[index] = new authenticationloginschema();
          authenticationloginschemaArray[index].name = name[index];
        }
        baseResponses = base_resource.delete_bulk_request(client, (base_resource[]) authenticationloginschemaArray);
      }
      return baseResponses;
    }

    public static base_responses delete(
      nitro_service client,
      authenticationloginschema[] resources)
    {
      base_responses baseResponses = (base_responses) null;
      if (resources != null && resources.Length > 0)
      {
        authenticationloginschema[] authenticationloginschemaArray = new authenticationloginschema[resources.Length];
        for (int index = 0; index < resources.Length; ++index)
        {
          authenticationloginschemaArray[index] = new authenticationloginschema();
          authenticationloginschemaArray[index].name = resources[index].name;
        }
        baseResponses = base_resource.delete_bulk_request(client, (base_resource[]) authenticationloginschemaArray);
      }
      return baseResponses;
    }

    public static base_response update(
      nitro_service client,
      authenticationloginschema resource)
    {
      return new authenticationloginschema()
      {
        name = resource.name,
        authenticationschema = resource.authenticationschema,
        userexpression = resource.userexpression,
        passwdexpression = resource.passwdexpression,
        usercredentialindex = resource.usercredentialindex,
        passwordcredentialindex = resource.passwordcredentialindex,
        authenticationstrength = resource.authenticationstrength
      }.update_resource(client);
    }

    public static base_responses update(
      nitro_service client,
      authenticationloginschema[] resources)
    {
      base_responses baseResponses = (base_responses) null;
      if (resources != null && resources.Length > 0)
      {
        authenticationloginschema[] authenticationloginschemaArray = new authenticationloginschema[resources.Length];
        for (int index = 0; index < resources.Length; ++index)
        {
          authenticationloginschemaArray[index] = new authenticationloginschema();
          authenticationloginschemaArray[index].name = resources[index].name;
          authenticationloginschemaArray[index].authenticationschema = resources[index].authenticationschema;
          authenticationloginschemaArray[index].userexpression = resources[index].userexpression;
          authenticationloginschemaArray[index].passwdexpression = resources[index].passwdexpression;
          authenticationloginschemaArray[index].usercredentialindex = resources[index].usercredentialindex;
          authenticationloginschemaArray[index].passwordcredentialindex = resources[index].passwordcredentialindex;
          authenticationloginschemaArray[index].authenticationstrength = resources[index].authenticationstrength;
        }
        baseResponses = base_resource.update_bulk_request(client, (base_resource[]) authenticationloginschemaArray);
      }
      return baseResponses;
    }

    public static base_response unset(
      nitro_service client,
      string name,
      string[] args)
    {
      return new authenticationloginschema() { name = name }.unset_resource(client, args);
    }

    public static base_response unset(
      nitro_service client,
      authenticationloginschema resource,
      string[] args)
    {
      return new authenticationloginschema()
      {
        name = resource.name
      }.unset_resource(client, args);
    }

    public static base_responses unset(
      nitro_service client,
      string[] name,
      string[] args)
    {
      base_responses baseResponses = (base_responses) null;
      if (name != null && name.Length > 0)
      {
        authenticationloginschema[] authenticationloginschemaArray = new authenticationloginschema[name.Length];
        for (int index = 0; index < name.Length; ++index)
        {
          authenticationloginschemaArray[index] = new authenticationloginschema();
          authenticationloginschemaArray[index].name = name[index];
        }
        baseResponses = base_resource.unset_bulk_request(client, (base_resource[]) authenticationloginschemaArray, args);
      }
      return baseResponses;
    }

    public static base_responses unset(
      nitro_service client,
      authenticationloginschema[] resources,
      string[] args)
    {
      base_responses baseResponses = (base_responses) null;
      if (resources != null && resources.Length > 0)
      {
        authenticationloginschema[] authenticationloginschemaArray = new authenticationloginschema[resources.Length];
        for (int index = 0; index < resources.Length; ++index)
        {
          authenticationloginschemaArray[index] = new authenticationloginschema();
          authenticationloginschemaArray[index].name = resources[index].name;
        }
        baseResponses = base_resource.unset_bulk_request(client, (base_resource[]) authenticationloginschemaArray, args);
      }
      return baseResponses;
    }

    public static authenticationloginschema[] get(nitro_service service) => (authenticationloginschema[]) new authenticationloginschema().get_resources(service, (options) null);

    public static authenticationloginschema[] get(
      nitro_service service,
      options option)
    {
      return (authenticationloginschema[]) new authenticationloginschema().get_resources(service, option);
    }

    public static authenticationloginschema get(
      nitro_service service,
      string name)
    {
      return (authenticationloginschema) new authenticationloginschema()
      {
        name = name
      }.get_resource(service);
    }

    public static authenticationloginschema[] get(
      nitro_service service,
      string[] name)
    {
      if (name == null || name.Length <= 0)
        return (authenticationloginschema[]) null;
      authenticationloginschema[] authenticationloginschemaArray1 = new authenticationloginschema[name.Length];
      authenticationloginschema[] authenticationloginschemaArray2 = new authenticationloginschema[name.Length];
      for (int index = 0; index < name.Length; ++index)
      {
        authenticationloginschemaArray2[index] = new authenticationloginschema();
        authenticationloginschemaArray2[index].name = name[index];
        authenticationloginschemaArray1[index] = (authenticationloginschema) authenticationloginschemaArray2[index].get_resource(service);
      }
      return authenticationloginschemaArray1;
    }

    public static authenticationloginschema[] get_filtered(
      nitro_service service,
      string filter)
    {
      authenticationloginschema authenticationloginschema = new authenticationloginschema();
      options option = new options();
      option.set_filter(filter);
      return (authenticationloginschema[]) authenticationloginschema.getfiltered(service, option);
    }

    public static authenticationloginschema[] get_filtered(
      nitro_service service,
      filtervalue[] filter)
    {
      authenticationloginschema authenticationloginschema = new authenticationloginschema();
      options option = new options();
      option.set_filter(filter);
      return (authenticationloginschema[]) authenticationloginschema.getfiltered(service, option);
    }

    public static uint count(nitro_service service)
    {
      authenticationloginschema authenticationloginschema = new authenticationloginschema();
      options option = new options();
      option.set_count(true);
      authenticationloginschema[] resources = (authenticationloginschema[]) authenticationloginschema.get_resources(service, option);
      return resources != null && resources.Length > 0 ? resources[0].__count.Value : 0U;
    }

    public static uint count_filtered(nitro_service service, string filter)
    {
      authenticationloginschema authenticationloginschema = new authenticationloginschema();
      options option = new options();
      option.set_count(true);
      option.set_filter(filter);
      authenticationloginschema[] authenticationloginschemaArray = (authenticationloginschema[]) authenticationloginschema.getfiltered(service, option);
      return authenticationloginschemaArray != null && authenticationloginschemaArray.Length > 0 ? authenticationloginschemaArray[0].__count.Value : 0U;
    }

    public static uint count_filtered(nitro_service service, filtervalue[] filter)
    {
      authenticationloginschema authenticationloginschema = new authenticationloginschema();
      options option = new options();
      option.set_count(true);
      option.set_filter(filter);
      authenticationloginschema[] authenticationloginschemaArray = (authenticationloginschema[]) authenticationloginschema.getfiltered(service, option);
      return authenticationloginschemaArray != null && authenticationloginschemaArray.Length > 0 ? authenticationloginschemaArray[0].__count.Value : 0U;
    }

    private class authenticationloginschema_response : base_response
    {
      public authenticationloginschema[] authenticationloginschema = (authenticationloginschema[]) null;
    }

    public static class builtinEnum
    {
      public const string MODIFIABLE = "MODIFIABLE";
      public const string DELETABLE = "DELETABLE";
      public const string IMMUTABLE = "IMMUTABLE";
      public const string PARTITION_ALL = "PARTITION_ALL";
    }
  }
}
