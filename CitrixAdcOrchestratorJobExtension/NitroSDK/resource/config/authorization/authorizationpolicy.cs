// Decompiled with JetBrains decompiler
// Type: com.citrix.netscaler.nitro.resource.config.authorization.authorizationpolicy
// Assembly: nitro, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 6CF5DDEF-E052-4F9D-953F-6644F8378A66


using com.citrix.netscaler.nitro.exception;
using com.citrix.netscaler.nitro.resource.Base;
using com.citrix.netscaler.nitro.service;
using com.citrix.netscaler.nitro.util;

namespace com.citrix.netscaler.nitro.resource.config.authorization
{
  public class authorizationpolicy : base_resource
  {
    private string nameField = (string) null;
    private string ruleField = (string) null;
    private string actionField = (string) null;
    private string newnameField = (string) null;
    private uint? activepolicyField = new uint?();
    private string expressiontypeField = (string) null;
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

    public string rule
    {
      get => this.ruleField;
      set => this.ruleField = value;
    }

    public string action
    {
      get => this.actionField;
      set => this.actionField = value;
    }

    public string newname
    {
      get => this.newnameField;
      set => this.newnameField = value;
    }

    public uint? activepolicy
    {
      get => this.activepolicyField;
      private set => this.activepolicyField = value;
    }

    public string expressiontype
    {
      get => this.expressiontypeField;
      private set => this.expressiontypeField = value;
    }

    internal override base_resource[] get_nitro_response(
      nitro_service service,
      string response)
    {
      authorizationpolicy.authorizationpolicy_response authorizationpolicyResponse = new authorizationpolicy.authorizationpolicy_response();
      authorizationpolicy.authorizationpolicy_response resource = (authorizationpolicy.authorizationpolicy_response) service.get_payload_formatter().string_to_resource(authorizationpolicyResponse.GetType(), response);
      if (resource.errorcode != 0)
      {
        if (resource.errorcode == 444)
          service.clear_session();
        if (resource.severity == null)
          throw new nitro_exception(resource.message, resource.errorcode);
        if (resource.severity.Equals("ERROR"))
          throw new nitro_exception(resource.message, resource.errorcode);
      }
      return (base_resource[]) resource.authorizationpolicy;
    }

    internal override string get_object_name() => this.name;

    public static base_response add(nitro_service client, authorizationpolicy resource) => new authorizationpolicy()
    {
      name = resource.name,
      rule = resource.rule,
      action = resource.action
    }.add_resource(client);

    public static base_responses add(
      nitro_service client,
      authorizationpolicy[] resources)
    {
      base_responses baseResponses = (base_responses) null;
      if (resources != null && resources.Length > 0)
      {
        authorizationpolicy[] authorizationpolicyArray = new authorizationpolicy[resources.Length];
        for (int index = 0; index < resources.Length; ++index)
        {
          authorizationpolicyArray[index] = new authorizationpolicy();
          authorizationpolicyArray[index].name = resources[index].name;
          authorizationpolicyArray[index].rule = resources[index].rule;
          authorizationpolicyArray[index].action = resources[index].action;
        }
        baseResponses = base_resource.add_bulk_request(client, (base_resource[]) authorizationpolicyArray);
      }
      return baseResponses;
    }

    public static base_response delete(nitro_service client, string name) => new authorizationpolicy()
    {
      name = name
    }.delete_resource(client);

    public static base_response delete(
      nitro_service client,
      authorizationpolicy resource)
    {
      return new authorizationpolicy()
      {
        name = resource.name
      }.delete_resource(client);
    }

    public static base_responses delete(nitro_service client, string[] name)
    {
      base_responses baseResponses = (base_responses) null;
      if (name != null && name.Length > 0)
      {
        authorizationpolicy[] authorizationpolicyArray = new authorizationpolicy[name.Length];
        for (int index = 0; index < name.Length; ++index)
        {
          authorizationpolicyArray[index] = new authorizationpolicy();
          authorizationpolicyArray[index].name = name[index];
        }
        baseResponses = base_resource.delete_bulk_request(client, (base_resource[]) authorizationpolicyArray);
      }
      return baseResponses;
    }

    public static base_responses delete(
      nitro_service client,
      authorizationpolicy[] resources)
    {
      base_responses baseResponses = (base_responses) null;
      if (resources != null && resources.Length > 0)
      {
        authorizationpolicy[] authorizationpolicyArray = new authorizationpolicy[resources.Length];
        for (int index = 0; index < resources.Length; ++index)
        {
          authorizationpolicyArray[index] = new authorizationpolicy();
          authorizationpolicyArray[index].name = resources[index].name;
        }
        baseResponses = base_resource.delete_bulk_request(client, (base_resource[]) authorizationpolicyArray);
      }
      return baseResponses;
    }

    public static base_response update(
      nitro_service client,
      authorizationpolicy resource)
    {
      return new authorizationpolicy()
      {
        name = resource.name,
        rule = resource.rule,
        action = resource.action
      }.update_resource(client);
    }

    public static base_responses update(
      nitro_service client,
      authorizationpolicy[] resources)
    {
      base_responses baseResponses = (base_responses) null;
      if (resources != null && resources.Length > 0)
      {
        authorizationpolicy[] authorizationpolicyArray = new authorizationpolicy[resources.Length];
        for (int index = 0; index < resources.Length; ++index)
        {
          authorizationpolicyArray[index] = new authorizationpolicy();
          authorizationpolicyArray[index].name = resources[index].name;
          authorizationpolicyArray[index].rule = resources[index].rule;
          authorizationpolicyArray[index].action = resources[index].action;
        }
        baseResponses = base_resource.update_bulk_request(client, (base_resource[]) authorizationpolicyArray);
      }
      return baseResponses;
    }

    public static base_response rename(
      nitro_service client,
      authorizationpolicy resource,
      string new_name)
    {
      return new authorizationpolicy()
      {
        name = resource.name,
        newname = new_name
      }.rename_resource(client);
    }

    public static base_response rename(
      nitro_service client,
      string name,
      string new_name)
    {
      return new authorizationpolicy()
      {
        name = name,
        newname = new_name
      }.rename_resource(client);
    }

    public static authorizationpolicy[] get(nitro_service service) => (authorizationpolicy[]) new authorizationpolicy().get_resources(service, (options) null);

    public static authorizationpolicy[] get(
      nitro_service service,
      options option)
    {
      return (authorizationpolicy[]) new authorizationpolicy().get_resources(service, option);
    }

    public static authorizationpolicy get(nitro_service service, string name) => (authorizationpolicy) new authorizationpolicy()
    {
      name = name
    }.get_resource(service);

    public static authorizationpolicy[] get(nitro_service service, string[] name)
    {
      if (name == null || name.Length <= 0)
        return (authorizationpolicy[]) null;
      authorizationpolicy[] authorizationpolicyArray1 = new authorizationpolicy[name.Length];
      authorizationpolicy[] authorizationpolicyArray2 = new authorizationpolicy[name.Length];
      for (int index = 0; index < name.Length; ++index)
      {
        authorizationpolicyArray2[index] = new authorizationpolicy();
        authorizationpolicyArray2[index].name = name[index];
        authorizationpolicyArray1[index] = (authorizationpolicy) authorizationpolicyArray2[index].get_resource(service);
      }
      return authorizationpolicyArray1;
    }

    public static authorizationpolicy[] get_filtered(
      nitro_service service,
      string filter)
    {
      authorizationpolicy authorizationpolicy = new authorizationpolicy();
      options option = new options();
      option.set_filter(filter);
      return (authorizationpolicy[]) authorizationpolicy.getfiltered(service, option);
    }

    public static authorizationpolicy[] get_filtered(
      nitro_service service,
      filtervalue[] filter)
    {
      authorizationpolicy authorizationpolicy = new authorizationpolicy();
      options option = new options();
      option.set_filter(filter);
      return (authorizationpolicy[]) authorizationpolicy.getfiltered(service, option);
    }

    public static uint count(nitro_service service)
    {
      authorizationpolicy authorizationpolicy = new authorizationpolicy();
      options option = new options();
      option.set_count(true);
      authorizationpolicy[] resources = (authorizationpolicy[]) authorizationpolicy.get_resources(service, option);
      return resources != null && resources.Length > 0 ? resources[0].__count.Value : 0U;
    }

    public static uint count_filtered(nitro_service service, string filter)
    {
      authorizationpolicy authorizationpolicy = new authorizationpolicy();
      options option = new options();
      option.set_count(true);
      option.set_filter(filter);
      authorizationpolicy[] authorizationpolicyArray = (authorizationpolicy[]) authorizationpolicy.getfiltered(service, option);
      return authorizationpolicyArray != null && authorizationpolicyArray.Length > 0 ? authorizationpolicyArray[0].__count.Value : 0U;
    }

    public static uint count_filtered(nitro_service service, filtervalue[] filter)
    {
      authorizationpolicy authorizationpolicy = new authorizationpolicy();
      options option = new options();
      option.set_count(true);
      option.set_filter(filter);
      authorizationpolicy[] authorizationpolicyArray = (authorizationpolicy[]) authorizationpolicy.getfiltered(service, option);
      return authorizationpolicyArray != null && authorizationpolicyArray.Length > 0 ? authorizationpolicyArray[0].__count.Value : 0U;
    }

    private class authorizationpolicy_response : base_response
    {
      public authorizationpolicy[] authorizationpolicy = (authorizationpolicy[]) null;
    }

    public static class expressiontypeEnum
    {
      public const string Classic_Policy = "Classic Policy";
      public const string Advanced_Policy = "Advanced Policy";
    }
  }
}
