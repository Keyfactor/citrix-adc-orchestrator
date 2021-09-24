// Decompiled with JetBrains decompiler
// Type: com.citrix.netscaler.nitro.resource.config.authentication.authenticationldappolicy
// Assembly: nitro, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 6CF5DDEF-E052-4F9D-953F-6644F8378A66


using com.citrix.netscaler.nitro.exception;
using com.citrix.netscaler.nitro.resource.Base;
using com.citrix.netscaler.nitro.service;
using com.citrix.netscaler.nitro.util;

namespace com.citrix.netscaler.nitro.resource.config.authentication
{
  public class authenticationldappolicy : base_resource
  {
    private string nameField = (string) null;
    private string ruleField = (string) null;
    private string reqactionField = (string) null;
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

    public string reqaction
    {
      get => this.reqactionField;
      set => this.reqactionField = value;
    }

    internal override base_resource[] get_nitro_response(
      nitro_service service,
      string response)
    {
      authenticationldappolicy.authenticationldappolicy_response authenticationldappolicyResponse = new authenticationldappolicy.authenticationldappolicy_response();
      authenticationldappolicy.authenticationldappolicy_response resource = (authenticationldappolicy.authenticationldappolicy_response) service.get_payload_formatter().string_to_resource(authenticationldappolicyResponse.GetType(), response);
      if (resource.errorcode != 0)
      {
        if (resource.errorcode == 444)
          service.clear_session();
        if (resource.severity == null)
          throw new nitro_exception(resource.message, resource.errorcode);
        if (resource.severity.Equals("ERROR"))
          throw new nitro_exception(resource.message, resource.errorcode);
      }
      return (base_resource[]) resource.authenticationldappolicy;
    }

    internal override string get_object_name() => this.name;

    public static base_response add(
      nitro_service client,
      authenticationldappolicy resource)
    {
      return new authenticationldappolicy()
      {
        name = resource.name,
        rule = resource.rule,
        reqaction = resource.reqaction
      }.add_resource(client);
    }

    public static base_responses add(
      nitro_service client,
      authenticationldappolicy[] resources)
    {
      base_responses baseResponses = (base_responses) null;
      if (resources != null && resources.Length > 0)
      {
        authenticationldappolicy[] authenticationldappolicyArray = new authenticationldappolicy[resources.Length];
        for (int index = 0; index < resources.Length; ++index)
        {
          authenticationldappolicyArray[index] = new authenticationldappolicy();
          authenticationldappolicyArray[index].name = resources[index].name;
          authenticationldappolicyArray[index].rule = resources[index].rule;
          authenticationldappolicyArray[index].reqaction = resources[index].reqaction;
        }
        baseResponses = base_resource.add_bulk_request(client, (base_resource[]) authenticationldappolicyArray);
      }
      return baseResponses;
    }

    public static base_response delete(nitro_service client, string name) => new authenticationldappolicy()
    {
      name = name
    }.delete_resource(client);

    public static base_response delete(
      nitro_service client,
      authenticationldappolicy resource)
    {
      return new authenticationldappolicy()
      {
        name = resource.name
      }.delete_resource(client);
    }

    public static base_responses delete(nitro_service client, string[] name)
    {
      base_responses baseResponses = (base_responses) null;
      if (name != null && name.Length > 0)
      {
        authenticationldappolicy[] authenticationldappolicyArray = new authenticationldappolicy[name.Length];
        for (int index = 0; index < name.Length; ++index)
        {
          authenticationldappolicyArray[index] = new authenticationldappolicy();
          authenticationldappolicyArray[index].name = name[index];
        }
        baseResponses = base_resource.delete_bulk_request(client, (base_resource[]) authenticationldappolicyArray);
      }
      return baseResponses;
    }

    public static base_responses delete(
      nitro_service client,
      authenticationldappolicy[] resources)
    {
      base_responses baseResponses = (base_responses) null;
      if (resources != null && resources.Length > 0)
      {
        authenticationldappolicy[] authenticationldappolicyArray = new authenticationldappolicy[resources.Length];
        for (int index = 0; index < resources.Length; ++index)
        {
          authenticationldappolicyArray[index] = new authenticationldappolicy();
          authenticationldappolicyArray[index].name = resources[index].name;
        }
        baseResponses = base_resource.delete_bulk_request(client, (base_resource[]) authenticationldappolicyArray);
      }
      return baseResponses;
    }

    public static base_response update(
      nitro_service client,
      authenticationldappolicy resource)
    {
      return new authenticationldappolicy()
      {
        name = resource.name,
        rule = resource.rule,
        reqaction = resource.reqaction
      }.update_resource(client);
    }

    public static base_responses update(
      nitro_service client,
      authenticationldappolicy[] resources)
    {
      base_responses baseResponses = (base_responses) null;
      if (resources != null && resources.Length > 0)
      {
        authenticationldappolicy[] authenticationldappolicyArray = new authenticationldappolicy[resources.Length];
        for (int index = 0; index < resources.Length; ++index)
        {
          authenticationldappolicyArray[index] = new authenticationldappolicy();
          authenticationldappolicyArray[index].name = resources[index].name;
          authenticationldappolicyArray[index].rule = resources[index].rule;
          authenticationldappolicyArray[index].reqaction = resources[index].reqaction;
        }
        baseResponses = base_resource.update_bulk_request(client, (base_resource[]) authenticationldappolicyArray);
      }
      return baseResponses;
    }

    public static base_response unset(
      nitro_service client,
      string name,
      string[] args)
    {
      return new authenticationldappolicy() { name = name }.unset_resource(client, args);
    }

    public static base_response unset(
      nitro_service client,
      authenticationldappolicy resource,
      string[] args)
    {
      return new authenticationldappolicy()
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
        authenticationldappolicy[] authenticationldappolicyArray = new authenticationldappolicy[name.Length];
        for (int index = 0; index < name.Length; ++index)
        {
          authenticationldappolicyArray[index] = new authenticationldappolicy();
          authenticationldappolicyArray[index].name = name[index];
        }
        baseResponses = base_resource.unset_bulk_request(client, (base_resource[]) authenticationldappolicyArray, args);
      }
      return baseResponses;
    }

    public static base_responses unset(
      nitro_service client,
      authenticationldappolicy[] resources,
      string[] args)
    {
      base_responses baseResponses = (base_responses) null;
      if (resources != null && resources.Length > 0)
      {
        authenticationldappolicy[] authenticationldappolicyArray = new authenticationldappolicy[resources.Length];
        for (int index = 0; index < resources.Length; ++index)
        {
          authenticationldappolicyArray[index] = new authenticationldappolicy();
          authenticationldappolicyArray[index].name = resources[index].name;
        }
        baseResponses = base_resource.unset_bulk_request(client, (base_resource[]) authenticationldappolicyArray, args);
      }
      return baseResponses;
    }

    public static authenticationldappolicy[] get(nitro_service service) => (authenticationldappolicy[]) new authenticationldappolicy().get_resources(service, (options) null);

    public static authenticationldappolicy[] get(
      nitro_service service,
      options option)
    {
      return (authenticationldappolicy[]) new authenticationldappolicy().get_resources(service, option);
    }

    public static authenticationldappolicy get(
      nitro_service service,
      string name)
    {
      return (authenticationldappolicy) new authenticationldappolicy()
      {
        name = name
      }.get_resource(service);
    }

    public static authenticationldappolicy[] get(
      nitro_service service,
      string[] name)
    {
      if (name == null || name.Length <= 0)
        return (authenticationldappolicy[]) null;
      authenticationldappolicy[] authenticationldappolicyArray1 = new authenticationldappolicy[name.Length];
      authenticationldappolicy[] authenticationldappolicyArray2 = new authenticationldappolicy[name.Length];
      for (int index = 0; index < name.Length; ++index)
      {
        authenticationldappolicyArray2[index] = new authenticationldappolicy();
        authenticationldappolicyArray2[index].name = name[index];
        authenticationldappolicyArray1[index] = (authenticationldappolicy) authenticationldappolicyArray2[index].get_resource(service);
      }
      return authenticationldappolicyArray1;
    }

    public static authenticationldappolicy[] get_filtered(
      nitro_service service,
      string filter)
    {
      authenticationldappolicy authenticationldappolicy = new authenticationldappolicy();
      options option = new options();
      option.set_filter(filter);
      return (authenticationldappolicy[]) authenticationldappolicy.getfiltered(service, option);
    }

    public static authenticationldappolicy[] get_filtered(
      nitro_service service,
      filtervalue[] filter)
    {
      authenticationldappolicy authenticationldappolicy = new authenticationldappolicy();
      options option = new options();
      option.set_filter(filter);
      return (authenticationldappolicy[]) authenticationldappolicy.getfiltered(service, option);
    }

    public static uint count(nitro_service service)
    {
      authenticationldappolicy authenticationldappolicy = new authenticationldappolicy();
      options option = new options();
      option.set_count(true);
      authenticationldappolicy[] resources = (authenticationldappolicy[]) authenticationldappolicy.get_resources(service, option);
      return resources != null && resources.Length > 0 ? resources[0].__count.Value : 0U;
    }

    public static uint count_filtered(nitro_service service, string filter)
    {
      authenticationldappolicy authenticationldappolicy = new authenticationldappolicy();
      options option = new options();
      option.set_count(true);
      option.set_filter(filter);
      authenticationldappolicy[] authenticationldappolicyArray = (authenticationldappolicy[]) authenticationldappolicy.getfiltered(service, option);
      return authenticationldappolicyArray != null && authenticationldappolicyArray.Length > 0 ? authenticationldappolicyArray[0].__count.Value : 0U;
    }

    public static uint count_filtered(nitro_service service, filtervalue[] filter)
    {
      authenticationldappolicy authenticationldappolicy = new authenticationldappolicy();
      options option = new options();
      option.set_count(true);
      option.set_filter(filter);
      authenticationldappolicy[] authenticationldappolicyArray = (authenticationldappolicy[]) authenticationldappolicy.getfiltered(service, option);
      return authenticationldappolicyArray != null && authenticationldappolicyArray.Length > 0 ? authenticationldappolicyArray[0].__count.Value : 0U;
    }

    private class authenticationldappolicy_response : base_response
    {
      public authenticationldappolicy[] authenticationldappolicy = (authenticationldappolicy[]) null;
    }
  }
}
