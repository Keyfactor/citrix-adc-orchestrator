// Decompiled with JetBrains decompiler
// Type: com.citrix.netscaler.nitro.resource.config.authentication.authenticationtacacspolicy
// Assembly: nitro, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 6CF5DDEF-E052-4F9D-953F-6644F8378A66


using com.citrix.netscaler.nitro.exception;
using com.citrix.netscaler.nitro.resource.Base;
using com.citrix.netscaler.nitro.service;
using com.citrix.netscaler.nitro.util;

namespace com.citrix.netscaler.nitro.resource.config.authentication
{
  public class authenticationtacacspolicy : base_resource
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
      authenticationtacacspolicy.authenticationtacacspolicy_response authenticationtacacspolicyResponse = new authenticationtacacspolicy.authenticationtacacspolicy_response();
      authenticationtacacspolicy.authenticationtacacspolicy_response resource = (authenticationtacacspolicy.authenticationtacacspolicy_response) service.get_payload_formatter().string_to_resource(authenticationtacacspolicyResponse.GetType(), response);
      if (resource.errorcode != 0)
      {
        if (resource.errorcode == 444)
          service.clear_session();
        if (resource.severity == null)
          throw new nitro_exception(resource.message, resource.errorcode);
        if (resource.severity.Equals("ERROR"))
          throw new nitro_exception(resource.message, resource.errorcode);
      }
      return (base_resource[]) resource.authenticationtacacspolicy;
    }

    internal override string get_object_name() => this.name;

    public static base_response add(
      nitro_service client,
      authenticationtacacspolicy resource)
    {
      return new authenticationtacacspolicy()
      {
        name = resource.name,
        rule = resource.rule,
        reqaction = resource.reqaction
      }.add_resource(client);
    }

    public static base_responses add(
      nitro_service client,
      authenticationtacacspolicy[] resources)
    {
      base_responses baseResponses = (base_responses) null;
      if (resources != null && resources.Length > 0)
      {
        authenticationtacacspolicy[] authenticationtacacspolicyArray = new authenticationtacacspolicy[resources.Length];
        for (int index = 0; index < resources.Length; ++index)
        {
          authenticationtacacspolicyArray[index] = new authenticationtacacspolicy();
          authenticationtacacspolicyArray[index].name = resources[index].name;
          authenticationtacacspolicyArray[index].rule = resources[index].rule;
          authenticationtacacspolicyArray[index].reqaction = resources[index].reqaction;
        }
        baseResponses = base_resource.add_bulk_request(client, (base_resource[]) authenticationtacacspolicyArray);
      }
      return baseResponses;
    }

    public static base_response delete(nitro_service client, string name) => new authenticationtacacspolicy()
    {
      name = name
    }.delete_resource(client);

    public static base_response delete(
      nitro_service client,
      authenticationtacacspolicy resource)
    {
      return new authenticationtacacspolicy()
      {
        name = resource.name
      }.delete_resource(client);
    }

    public static base_responses delete(nitro_service client, string[] name)
    {
      base_responses baseResponses = (base_responses) null;
      if (name != null && name.Length > 0)
      {
        authenticationtacacspolicy[] authenticationtacacspolicyArray = new authenticationtacacspolicy[name.Length];
        for (int index = 0; index < name.Length; ++index)
        {
          authenticationtacacspolicyArray[index] = new authenticationtacacspolicy();
          authenticationtacacspolicyArray[index].name = name[index];
        }
        baseResponses = base_resource.delete_bulk_request(client, (base_resource[]) authenticationtacacspolicyArray);
      }
      return baseResponses;
    }

    public static base_responses delete(
      nitro_service client,
      authenticationtacacspolicy[] resources)
    {
      base_responses baseResponses = (base_responses) null;
      if (resources != null && resources.Length > 0)
      {
        authenticationtacacspolicy[] authenticationtacacspolicyArray = new authenticationtacacspolicy[resources.Length];
        for (int index = 0; index < resources.Length; ++index)
        {
          authenticationtacacspolicyArray[index] = new authenticationtacacspolicy();
          authenticationtacacspolicyArray[index].name = resources[index].name;
        }
        baseResponses = base_resource.delete_bulk_request(client, (base_resource[]) authenticationtacacspolicyArray);
      }
      return baseResponses;
    }

    public static base_response update(
      nitro_service client,
      authenticationtacacspolicy resource)
    {
      return new authenticationtacacspolicy()
      {
        name = resource.name,
        rule = resource.rule,
        reqaction = resource.reqaction
      }.update_resource(client);
    }

    public static base_responses update(
      nitro_service client,
      authenticationtacacspolicy[] resources)
    {
      base_responses baseResponses = (base_responses) null;
      if (resources != null && resources.Length > 0)
      {
        authenticationtacacspolicy[] authenticationtacacspolicyArray = new authenticationtacacspolicy[resources.Length];
        for (int index = 0; index < resources.Length; ++index)
        {
          authenticationtacacspolicyArray[index] = new authenticationtacacspolicy();
          authenticationtacacspolicyArray[index].name = resources[index].name;
          authenticationtacacspolicyArray[index].rule = resources[index].rule;
          authenticationtacacspolicyArray[index].reqaction = resources[index].reqaction;
        }
        baseResponses = base_resource.update_bulk_request(client, (base_resource[]) authenticationtacacspolicyArray);
      }
      return baseResponses;
    }

    public static base_response unset(
      nitro_service client,
      string name,
      string[] args)
    {
      return new authenticationtacacspolicy()
      {
        name = name
      }.unset_resource(client, args);
    }

    public static base_response unset(
      nitro_service client,
      authenticationtacacspolicy resource,
      string[] args)
    {
      return new authenticationtacacspolicy()
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
        authenticationtacacspolicy[] authenticationtacacspolicyArray = new authenticationtacacspolicy[name.Length];
        for (int index = 0; index < name.Length; ++index)
        {
          authenticationtacacspolicyArray[index] = new authenticationtacacspolicy();
          authenticationtacacspolicyArray[index].name = name[index];
        }
        baseResponses = base_resource.unset_bulk_request(client, (base_resource[]) authenticationtacacspolicyArray, args);
      }
      return baseResponses;
    }

    public static base_responses unset(
      nitro_service client,
      authenticationtacacspolicy[] resources,
      string[] args)
    {
      base_responses baseResponses = (base_responses) null;
      if (resources != null && resources.Length > 0)
      {
        authenticationtacacspolicy[] authenticationtacacspolicyArray = new authenticationtacacspolicy[resources.Length];
        for (int index = 0; index < resources.Length; ++index)
        {
          authenticationtacacspolicyArray[index] = new authenticationtacacspolicy();
          authenticationtacacspolicyArray[index].name = resources[index].name;
        }
        baseResponses = base_resource.unset_bulk_request(client, (base_resource[]) authenticationtacacspolicyArray, args);
      }
      return baseResponses;
    }

    public static authenticationtacacspolicy[] get(nitro_service service) => (authenticationtacacspolicy[]) new authenticationtacacspolicy().get_resources(service, (options) null);

    public static authenticationtacacspolicy[] get(
      nitro_service service,
      options option)
    {
      return (authenticationtacacspolicy[]) new authenticationtacacspolicy().get_resources(service, option);
    }

    public static authenticationtacacspolicy get(
      nitro_service service,
      string name)
    {
      return (authenticationtacacspolicy) new authenticationtacacspolicy()
      {
        name = name
      }.get_resource(service);
    }

    public static authenticationtacacspolicy[] get(
      nitro_service service,
      string[] name)
    {
      if (name == null || name.Length <= 0)
        return (authenticationtacacspolicy[]) null;
      authenticationtacacspolicy[] authenticationtacacspolicyArray1 = new authenticationtacacspolicy[name.Length];
      authenticationtacacspolicy[] authenticationtacacspolicyArray2 = new authenticationtacacspolicy[name.Length];
      for (int index = 0; index < name.Length; ++index)
      {
        authenticationtacacspolicyArray2[index] = new authenticationtacacspolicy();
        authenticationtacacspolicyArray2[index].name = name[index];
        authenticationtacacspolicyArray1[index] = (authenticationtacacspolicy) authenticationtacacspolicyArray2[index].get_resource(service);
      }
      return authenticationtacacspolicyArray1;
    }

    public static authenticationtacacspolicy[] get_filtered(
      nitro_service service,
      string filter)
    {
      authenticationtacacspolicy authenticationtacacspolicy = new authenticationtacacspolicy();
      options option = new options();
      option.set_filter(filter);
      return (authenticationtacacspolicy[]) authenticationtacacspolicy.getfiltered(service, option);
    }

    public static authenticationtacacspolicy[] get_filtered(
      nitro_service service,
      filtervalue[] filter)
    {
      authenticationtacacspolicy authenticationtacacspolicy = new authenticationtacacspolicy();
      options option = new options();
      option.set_filter(filter);
      return (authenticationtacacspolicy[]) authenticationtacacspolicy.getfiltered(service, option);
    }

    public static uint count(nitro_service service)
    {
      authenticationtacacspolicy authenticationtacacspolicy = new authenticationtacacspolicy();
      options option = new options();
      option.set_count(true);
      authenticationtacacspolicy[] resources = (authenticationtacacspolicy[]) authenticationtacacspolicy.get_resources(service, option);
      return resources != null && resources.Length > 0 ? resources[0].__count.Value : 0U;
    }

    public static uint count_filtered(nitro_service service, string filter)
    {
      authenticationtacacspolicy authenticationtacacspolicy = new authenticationtacacspolicy();
      options option = new options();
      option.set_count(true);
      option.set_filter(filter);
      authenticationtacacspolicy[] authenticationtacacspolicyArray = (authenticationtacacspolicy[]) authenticationtacacspolicy.getfiltered(service, option);
      return authenticationtacacspolicyArray != null && authenticationtacacspolicyArray.Length > 0 ? authenticationtacacspolicyArray[0].__count.Value : 0U;
    }

    public static uint count_filtered(nitro_service service, filtervalue[] filter)
    {
      authenticationtacacspolicy authenticationtacacspolicy = new authenticationtacacspolicy();
      options option = new options();
      option.set_count(true);
      option.set_filter(filter);
      authenticationtacacspolicy[] authenticationtacacspolicyArray = (authenticationtacacspolicy[]) authenticationtacacspolicy.getfiltered(service, option);
      return authenticationtacacspolicyArray != null && authenticationtacacspolicyArray.Length > 0 ? authenticationtacacspolicyArray[0].__count.Value : 0U;
    }

    private class authenticationtacacspolicy_response : base_response
    {
      public authenticationtacacspolicy[] authenticationtacacspolicy = (authenticationtacacspolicy[]) null;
    }
  }
}
