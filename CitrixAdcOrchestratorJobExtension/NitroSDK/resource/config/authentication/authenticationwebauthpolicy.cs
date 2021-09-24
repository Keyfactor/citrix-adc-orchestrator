// Decompiled with JetBrains decompiler
// Type: com.citrix.netscaler.nitro.resource.config.authentication.authenticationwebauthpolicy
// Assembly: nitro, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 6CF5DDEF-E052-4F9D-953F-6644F8378A66


using com.citrix.netscaler.nitro.exception;
using com.citrix.netscaler.nitro.resource.Base;
using com.citrix.netscaler.nitro.service;
using com.citrix.netscaler.nitro.util;

namespace com.citrix.netscaler.nitro.resource.config.authentication
{
  public class authenticationwebauthpolicy : base_resource
  {
    private string nameField = (string) null;
    private string ruleField = (string) null;
    private string actionField = (string) null;
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

    internal override base_resource[] get_nitro_response(
      nitro_service service,
      string response)
    {
      authenticationwebauthpolicy.authenticationwebauthpolicy_response authenticationwebauthpolicyResponse = new authenticationwebauthpolicy.authenticationwebauthpolicy_response();
      authenticationwebauthpolicy.authenticationwebauthpolicy_response resource = (authenticationwebauthpolicy.authenticationwebauthpolicy_response) service.get_payload_formatter().string_to_resource(authenticationwebauthpolicyResponse.GetType(), response);
      if (resource.errorcode != 0)
      {
        if (resource.errorcode == 444)
          service.clear_session();
        if (resource.severity == null)
          throw new nitro_exception(resource.message, resource.errorcode);
        if (resource.severity.Equals("ERROR"))
          throw new nitro_exception(resource.message, resource.errorcode);
      }
      return (base_resource[]) resource.authenticationwebauthpolicy;
    }

    internal override string get_object_name() => this.name;

    public static base_response add(
      nitro_service client,
      authenticationwebauthpolicy resource)
    {
      return new authenticationwebauthpolicy()
      {
        name = resource.name,
        rule = resource.rule,
        action = resource.action
      }.add_resource(client);
    }

    public static base_responses add(
      nitro_service client,
      authenticationwebauthpolicy[] resources)
    {
      base_responses baseResponses = (base_responses) null;
      if (resources != null && resources.Length > 0)
      {
        authenticationwebauthpolicy[] authenticationwebauthpolicyArray = new authenticationwebauthpolicy[resources.Length];
        for (int index = 0; index < resources.Length; ++index)
        {
          authenticationwebauthpolicyArray[index] = new authenticationwebauthpolicy();
          authenticationwebauthpolicyArray[index].name = resources[index].name;
          authenticationwebauthpolicyArray[index].rule = resources[index].rule;
          authenticationwebauthpolicyArray[index].action = resources[index].action;
        }
        baseResponses = base_resource.add_bulk_request(client, (base_resource[]) authenticationwebauthpolicyArray);
      }
      return baseResponses;
    }

    public static base_response delete(nitro_service client, string name) => new authenticationwebauthpolicy()
    {
      name = name
    }.delete_resource(client);

    public static base_response delete(
      nitro_service client,
      authenticationwebauthpolicy resource)
    {
      return new authenticationwebauthpolicy()
      {
        name = resource.name
      }.delete_resource(client);
    }

    public static base_responses delete(nitro_service client, string[] name)
    {
      base_responses baseResponses = (base_responses) null;
      if (name != null && name.Length > 0)
      {
        authenticationwebauthpolicy[] authenticationwebauthpolicyArray = new authenticationwebauthpolicy[name.Length];
        for (int index = 0; index < name.Length; ++index)
        {
          authenticationwebauthpolicyArray[index] = new authenticationwebauthpolicy();
          authenticationwebauthpolicyArray[index].name = name[index];
        }
        baseResponses = base_resource.delete_bulk_request(client, (base_resource[]) authenticationwebauthpolicyArray);
      }
      return baseResponses;
    }

    public static base_responses delete(
      nitro_service client,
      authenticationwebauthpolicy[] resources)
    {
      base_responses baseResponses = (base_responses) null;
      if (resources != null && resources.Length > 0)
      {
        authenticationwebauthpolicy[] authenticationwebauthpolicyArray = new authenticationwebauthpolicy[resources.Length];
        for (int index = 0; index < resources.Length; ++index)
        {
          authenticationwebauthpolicyArray[index] = new authenticationwebauthpolicy();
          authenticationwebauthpolicyArray[index].name = resources[index].name;
        }
        baseResponses = base_resource.delete_bulk_request(client, (base_resource[]) authenticationwebauthpolicyArray);
      }
      return baseResponses;
    }

    public static base_response update(
      nitro_service client,
      authenticationwebauthpolicy resource)
    {
      return new authenticationwebauthpolicy()
      {
        name = resource.name,
        rule = resource.rule,
        action = resource.action
      }.update_resource(client);
    }

    public static base_responses update(
      nitro_service client,
      authenticationwebauthpolicy[] resources)
    {
      base_responses baseResponses = (base_responses) null;
      if (resources != null && resources.Length > 0)
      {
        authenticationwebauthpolicy[] authenticationwebauthpolicyArray = new authenticationwebauthpolicy[resources.Length];
        for (int index = 0; index < resources.Length; ++index)
        {
          authenticationwebauthpolicyArray[index] = new authenticationwebauthpolicy();
          authenticationwebauthpolicyArray[index].name = resources[index].name;
          authenticationwebauthpolicyArray[index].rule = resources[index].rule;
          authenticationwebauthpolicyArray[index].action = resources[index].action;
        }
        baseResponses = base_resource.update_bulk_request(client, (base_resource[]) authenticationwebauthpolicyArray);
      }
      return baseResponses;
    }

    public static authenticationwebauthpolicy[] get(nitro_service service) => (authenticationwebauthpolicy[]) new authenticationwebauthpolicy().get_resources(service, (options) null);

    public static authenticationwebauthpolicy[] get(
      nitro_service service,
      options option)
    {
      return (authenticationwebauthpolicy[]) new authenticationwebauthpolicy().get_resources(service, option);
    }

    public static authenticationwebauthpolicy get(
      nitro_service service,
      string name)
    {
      return (authenticationwebauthpolicy) new authenticationwebauthpolicy()
      {
        name = name
      }.get_resource(service);
    }

    public static authenticationwebauthpolicy[] get(
      nitro_service service,
      string[] name)
    {
      if (name == null || name.Length <= 0)
        return (authenticationwebauthpolicy[]) null;
      authenticationwebauthpolicy[] authenticationwebauthpolicyArray1 = new authenticationwebauthpolicy[name.Length];
      authenticationwebauthpolicy[] authenticationwebauthpolicyArray2 = new authenticationwebauthpolicy[name.Length];
      for (int index = 0; index < name.Length; ++index)
      {
        authenticationwebauthpolicyArray2[index] = new authenticationwebauthpolicy();
        authenticationwebauthpolicyArray2[index].name = name[index];
        authenticationwebauthpolicyArray1[index] = (authenticationwebauthpolicy) authenticationwebauthpolicyArray2[index].get_resource(service);
      }
      return authenticationwebauthpolicyArray1;
    }

    public static authenticationwebauthpolicy[] get_filtered(
      nitro_service service,
      string filter)
    {
      authenticationwebauthpolicy authenticationwebauthpolicy = new authenticationwebauthpolicy();
      options option = new options();
      option.set_filter(filter);
      return (authenticationwebauthpolicy[]) authenticationwebauthpolicy.getfiltered(service, option);
    }

    public static authenticationwebauthpolicy[] get_filtered(
      nitro_service service,
      filtervalue[] filter)
    {
      authenticationwebauthpolicy authenticationwebauthpolicy = new authenticationwebauthpolicy();
      options option = new options();
      option.set_filter(filter);
      return (authenticationwebauthpolicy[]) authenticationwebauthpolicy.getfiltered(service, option);
    }

    public static uint count(nitro_service service)
    {
      authenticationwebauthpolicy authenticationwebauthpolicy = new authenticationwebauthpolicy();
      options option = new options();
      option.set_count(true);
      authenticationwebauthpolicy[] resources = (authenticationwebauthpolicy[]) authenticationwebauthpolicy.get_resources(service, option);
      return resources != null && resources.Length > 0 ? resources[0].__count.Value : 0U;
    }

    public static uint count_filtered(nitro_service service, string filter)
    {
      authenticationwebauthpolicy authenticationwebauthpolicy = new authenticationwebauthpolicy();
      options option = new options();
      option.set_count(true);
      option.set_filter(filter);
      authenticationwebauthpolicy[] authenticationwebauthpolicyArray = (authenticationwebauthpolicy[]) authenticationwebauthpolicy.getfiltered(service, option);
      return authenticationwebauthpolicyArray != null && authenticationwebauthpolicyArray.Length > 0 ? authenticationwebauthpolicyArray[0].__count.Value : 0U;
    }

    public static uint count_filtered(nitro_service service, filtervalue[] filter)
    {
      authenticationwebauthpolicy authenticationwebauthpolicy = new authenticationwebauthpolicy();
      options option = new options();
      option.set_count(true);
      option.set_filter(filter);
      authenticationwebauthpolicy[] authenticationwebauthpolicyArray = (authenticationwebauthpolicy[]) authenticationwebauthpolicy.getfiltered(service, option);
      return authenticationwebauthpolicyArray != null && authenticationwebauthpolicyArray.Length > 0 ? authenticationwebauthpolicyArray[0].__count.Value : 0U;
    }

    private class authenticationwebauthpolicy_response : base_response
    {
      public authenticationwebauthpolicy[] authenticationwebauthpolicy = (authenticationwebauthpolicy[]) null;
    }
  }
}
