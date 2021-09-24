// Decompiled with JetBrains decompiler
// Type: com.citrix.netscaler.nitro.resource.config.authentication.authenticationdfapolicy
// Assembly: nitro, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 6CF5DDEF-E052-4F9D-953F-6644F8378A66


using com.citrix.netscaler.nitro.exception;
using com.citrix.netscaler.nitro.resource.Base;
using com.citrix.netscaler.nitro.service;
using com.citrix.netscaler.nitro.util;

namespace com.citrix.netscaler.nitro.resource.config.authentication
{
  public class authenticationdfapolicy : base_resource
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
      authenticationdfapolicy.authenticationdfapolicy_response authenticationdfapolicyResponse = new authenticationdfapolicy.authenticationdfapolicy_response();
      authenticationdfapolicy.authenticationdfapolicy_response resource = (authenticationdfapolicy.authenticationdfapolicy_response) service.get_payload_formatter().string_to_resource(authenticationdfapolicyResponse.GetType(), response);
      if (resource.errorcode != 0)
      {
        if (resource.errorcode == 444)
          service.clear_session();
        if (resource.severity == null)
          throw new nitro_exception(resource.message, resource.errorcode);
        if (resource.severity.Equals("ERROR"))
          throw new nitro_exception(resource.message, resource.errorcode);
      }
      return (base_resource[]) resource.authenticationdfapolicy;
    }

    internal override string get_object_name() => this.name;

    public static base_response add(
      nitro_service client,
      authenticationdfapolicy resource)
    {
      return new authenticationdfapolicy()
      {
        name = resource.name,
        rule = resource.rule,
        action = resource.action
      }.add_resource(client);
    }

    public static base_responses add(
      nitro_service client,
      authenticationdfapolicy[] resources)
    {
      base_responses baseResponses = (base_responses) null;
      if (resources != null && resources.Length > 0)
      {
        authenticationdfapolicy[] authenticationdfapolicyArray = new authenticationdfapolicy[resources.Length];
        for (int index = 0; index < resources.Length; ++index)
        {
          authenticationdfapolicyArray[index] = new authenticationdfapolicy();
          authenticationdfapolicyArray[index].name = resources[index].name;
          authenticationdfapolicyArray[index].rule = resources[index].rule;
          authenticationdfapolicyArray[index].action = resources[index].action;
        }
        baseResponses = base_resource.add_bulk_request(client, (base_resource[]) authenticationdfapolicyArray);
      }
      return baseResponses;
    }

    public static base_response delete(nitro_service client, string name) => new authenticationdfapolicy()
    {
      name = name
    }.delete_resource(client);

    public static base_response delete(
      nitro_service client,
      authenticationdfapolicy resource)
    {
      return new authenticationdfapolicy()
      {
        name = resource.name
      }.delete_resource(client);
    }

    public static base_responses delete(nitro_service client, string[] name)
    {
      base_responses baseResponses = (base_responses) null;
      if (name != null && name.Length > 0)
      {
        authenticationdfapolicy[] authenticationdfapolicyArray = new authenticationdfapolicy[name.Length];
        for (int index = 0; index < name.Length; ++index)
        {
          authenticationdfapolicyArray[index] = new authenticationdfapolicy();
          authenticationdfapolicyArray[index].name = name[index];
        }
        baseResponses = base_resource.delete_bulk_request(client, (base_resource[]) authenticationdfapolicyArray);
      }
      return baseResponses;
    }

    public static base_responses delete(
      nitro_service client,
      authenticationdfapolicy[] resources)
    {
      base_responses baseResponses = (base_responses) null;
      if (resources != null && resources.Length > 0)
      {
        authenticationdfapolicy[] authenticationdfapolicyArray = new authenticationdfapolicy[resources.Length];
        for (int index = 0; index < resources.Length; ++index)
        {
          authenticationdfapolicyArray[index] = new authenticationdfapolicy();
          authenticationdfapolicyArray[index].name = resources[index].name;
        }
        baseResponses = base_resource.delete_bulk_request(client, (base_resource[]) authenticationdfapolicyArray);
      }
      return baseResponses;
    }

    public static base_response update(
      nitro_service client,
      authenticationdfapolicy resource)
    {
      return new authenticationdfapolicy()
      {
        name = resource.name,
        rule = resource.rule,
        action = resource.action
      }.update_resource(client);
    }

    public static base_responses update(
      nitro_service client,
      authenticationdfapolicy[] resources)
    {
      base_responses baseResponses = (base_responses) null;
      if (resources != null && resources.Length > 0)
      {
        authenticationdfapolicy[] authenticationdfapolicyArray = new authenticationdfapolicy[resources.Length];
        for (int index = 0; index < resources.Length; ++index)
        {
          authenticationdfapolicyArray[index] = new authenticationdfapolicy();
          authenticationdfapolicyArray[index].name = resources[index].name;
          authenticationdfapolicyArray[index].rule = resources[index].rule;
          authenticationdfapolicyArray[index].action = resources[index].action;
        }
        baseResponses = base_resource.update_bulk_request(client, (base_resource[]) authenticationdfapolicyArray);
      }
      return baseResponses;
    }

    public static authenticationdfapolicy[] get(nitro_service service) => (authenticationdfapolicy[]) new authenticationdfapolicy().get_resources(service, (options) null);

    public static authenticationdfapolicy[] get(
      nitro_service service,
      options option)
    {
      return (authenticationdfapolicy[]) new authenticationdfapolicy().get_resources(service, option);
    }

    public static authenticationdfapolicy get(
      nitro_service service,
      string name)
    {
      return (authenticationdfapolicy) new authenticationdfapolicy()
      {
        name = name
      }.get_resource(service);
    }

    public static authenticationdfapolicy[] get(
      nitro_service service,
      string[] name)
    {
      if (name == null || name.Length <= 0)
        return (authenticationdfapolicy[]) null;
      authenticationdfapolicy[] authenticationdfapolicyArray1 = new authenticationdfapolicy[name.Length];
      authenticationdfapolicy[] authenticationdfapolicyArray2 = new authenticationdfapolicy[name.Length];
      for (int index = 0; index < name.Length; ++index)
      {
        authenticationdfapolicyArray2[index] = new authenticationdfapolicy();
        authenticationdfapolicyArray2[index].name = name[index];
        authenticationdfapolicyArray1[index] = (authenticationdfapolicy) authenticationdfapolicyArray2[index].get_resource(service);
      }
      return authenticationdfapolicyArray1;
    }

    public static authenticationdfapolicy[] get_filtered(
      nitro_service service,
      string filter)
    {
      authenticationdfapolicy authenticationdfapolicy = new authenticationdfapolicy();
      options option = new options();
      option.set_filter(filter);
      return (authenticationdfapolicy[]) authenticationdfapolicy.getfiltered(service, option);
    }

    public static authenticationdfapolicy[] get_filtered(
      nitro_service service,
      filtervalue[] filter)
    {
      authenticationdfapolicy authenticationdfapolicy = new authenticationdfapolicy();
      options option = new options();
      option.set_filter(filter);
      return (authenticationdfapolicy[]) authenticationdfapolicy.getfiltered(service, option);
    }

    public static uint count(nitro_service service)
    {
      authenticationdfapolicy authenticationdfapolicy = new authenticationdfapolicy();
      options option = new options();
      option.set_count(true);
      authenticationdfapolicy[] resources = (authenticationdfapolicy[]) authenticationdfapolicy.get_resources(service, option);
      return resources != null && resources.Length > 0 ? resources[0].__count.Value : 0U;
    }

    public static uint count_filtered(nitro_service service, string filter)
    {
      authenticationdfapolicy authenticationdfapolicy = new authenticationdfapolicy();
      options option = new options();
      option.set_count(true);
      option.set_filter(filter);
      authenticationdfapolicy[] authenticationdfapolicyArray = (authenticationdfapolicy[]) authenticationdfapolicy.getfiltered(service, option);
      return authenticationdfapolicyArray != null && authenticationdfapolicyArray.Length > 0 ? authenticationdfapolicyArray[0].__count.Value : 0U;
    }

    public static uint count_filtered(nitro_service service, filtervalue[] filter)
    {
      authenticationdfapolicy authenticationdfapolicy = new authenticationdfapolicy();
      options option = new options();
      option.set_count(true);
      option.set_filter(filter);
      authenticationdfapolicy[] authenticationdfapolicyArray = (authenticationdfapolicy[]) authenticationdfapolicy.getfiltered(service, option);
      return authenticationdfapolicyArray != null && authenticationdfapolicyArray.Length > 0 ? authenticationdfapolicyArray[0].__count.Value : 0U;
    }

    private class authenticationdfapolicy_response : base_response
    {
      public authenticationdfapolicy[] authenticationdfapolicy = (authenticationdfapolicy[]) null;
    }
  }
}
