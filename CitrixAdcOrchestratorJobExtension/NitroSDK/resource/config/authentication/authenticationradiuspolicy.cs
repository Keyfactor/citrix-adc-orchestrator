// Decompiled with JetBrains decompiler
// Type: com.citrix.netscaler.nitro.resource.config.authentication.authenticationradiuspolicy
// Assembly: nitro, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 6CF5DDEF-E052-4F9D-953F-6644F8378A66


using com.citrix.netscaler.nitro.exception;
using com.citrix.netscaler.nitro.resource.Base;
using com.citrix.netscaler.nitro.service;
using com.citrix.netscaler.nitro.util;

namespace com.citrix.netscaler.nitro.resource.config.authentication
{
  public class authenticationradiuspolicy : base_resource
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
      authenticationradiuspolicy.authenticationradiuspolicy_response authenticationradiuspolicyResponse = new authenticationradiuspolicy.authenticationradiuspolicy_response();
      authenticationradiuspolicy.authenticationradiuspolicy_response resource = (authenticationradiuspolicy.authenticationradiuspolicy_response) service.get_payload_formatter().string_to_resource(authenticationradiuspolicyResponse.GetType(), response);
      if (resource.errorcode != 0)
      {
        if (resource.errorcode == 444)
          service.clear_session();
        if (resource.severity == null)
          throw new nitro_exception(resource.message, resource.errorcode);
        if (resource.severity.Equals("ERROR"))
          throw new nitro_exception(resource.message, resource.errorcode);
      }
      return (base_resource[]) resource.authenticationradiuspolicy;
    }

    internal override string get_object_name() => this.name;

    public static base_response add(
      nitro_service client,
      authenticationradiuspolicy resource)
    {
      return new authenticationradiuspolicy()
      {
        name = resource.name,
        rule = resource.rule,
        reqaction = resource.reqaction
      }.add_resource(client);
    }

    public static base_responses add(
      nitro_service client,
      authenticationradiuspolicy[] resources)
    {
      base_responses baseResponses = (base_responses) null;
      if (resources != null && resources.Length > 0)
      {
        authenticationradiuspolicy[] authenticationradiuspolicyArray = new authenticationradiuspolicy[resources.Length];
        for (int index = 0; index < resources.Length; ++index)
        {
          authenticationradiuspolicyArray[index] = new authenticationradiuspolicy();
          authenticationradiuspolicyArray[index].name = resources[index].name;
          authenticationradiuspolicyArray[index].rule = resources[index].rule;
          authenticationradiuspolicyArray[index].reqaction = resources[index].reqaction;
        }
        baseResponses = base_resource.add_bulk_request(client, (base_resource[]) authenticationradiuspolicyArray);
      }
      return baseResponses;
    }

    public static base_response delete(nitro_service client, string name) => new authenticationradiuspolicy()
    {
      name = name
    }.delete_resource(client);

    public static base_response delete(
      nitro_service client,
      authenticationradiuspolicy resource)
    {
      return new authenticationradiuspolicy()
      {
        name = resource.name
      }.delete_resource(client);
    }

    public static base_responses delete(nitro_service client, string[] name)
    {
      base_responses baseResponses = (base_responses) null;
      if (name != null && name.Length > 0)
      {
        authenticationradiuspolicy[] authenticationradiuspolicyArray = new authenticationradiuspolicy[name.Length];
        for (int index = 0; index < name.Length; ++index)
        {
          authenticationradiuspolicyArray[index] = new authenticationradiuspolicy();
          authenticationradiuspolicyArray[index].name = name[index];
        }
        baseResponses = base_resource.delete_bulk_request(client, (base_resource[]) authenticationradiuspolicyArray);
      }
      return baseResponses;
    }

    public static base_responses delete(
      nitro_service client,
      authenticationradiuspolicy[] resources)
    {
      base_responses baseResponses = (base_responses) null;
      if (resources != null && resources.Length > 0)
      {
        authenticationradiuspolicy[] authenticationradiuspolicyArray = new authenticationradiuspolicy[resources.Length];
        for (int index = 0; index < resources.Length; ++index)
        {
          authenticationradiuspolicyArray[index] = new authenticationradiuspolicy();
          authenticationradiuspolicyArray[index].name = resources[index].name;
        }
        baseResponses = base_resource.delete_bulk_request(client, (base_resource[]) authenticationradiuspolicyArray);
      }
      return baseResponses;
    }

    public static base_response update(
      nitro_service client,
      authenticationradiuspolicy resource)
    {
      return new authenticationradiuspolicy()
      {
        name = resource.name,
        rule = resource.rule,
        reqaction = resource.reqaction
      }.update_resource(client);
    }

    public static base_responses update(
      nitro_service client,
      authenticationradiuspolicy[] resources)
    {
      base_responses baseResponses = (base_responses) null;
      if (resources != null && resources.Length > 0)
      {
        authenticationradiuspolicy[] authenticationradiuspolicyArray = new authenticationradiuspolicy[resources.Length];
        for (int index = 0; index < resources.Length; ++index)
        {
          authenticationradiuspolicyArray[index] = new authenticationradiuspolicy();
          authenticationradiuspolicyArray[index].name = resources[index].name;
          authenticationradiuspolicyArray[index].rule = resources[index].rule;
          authenticationradiuspolicyArray[index].reqaction = resources[index].reqaction;
        }
        baseResponses = base_resource.update_bulk_request(client, (base_resource[]) authenticationradiuspolicyArray);
      }
      return baseResponses;
    }

    public static base_response unset(
      nitro_service client,
      string name,
      string[] args)
    {
      return new authenticationradiuspolicy()
      {
        name = name
      }.unset_resource(client, args);
    }

    public static base_response unset(
      nitro_service client,
      authenticationradiuspolicy resource,
      string[] args)
    {
      return new authenticationradiuspolicy()
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
        authenticationradiuspolicy[] authenticationradiuspolicyArray = new authenticationradiuspolicy[name.Length];
        for (int index = 0; index < name.Length; ++index)
        {
          authenticationradiuspolicyArray[index] = new authenticationradiuspolicy();
          authenticationradiuspolicyArray[index].name = name[index];
        }
        baseResponses = base_resource.unset_bulk_request(client, (base_resource[]) authenticationradiuspolicyArray, args);
      }
      return baseResponses;
    }

    public static base_responses unset(
      nitro_service client,
      authenticationradiuspolicy[] resources,
      string[] args)
    {
      base_responses baseResponses = (base_responses) null;
      if (resources != null && resources.Length > 0)
      {
        authenticationradiuspolicy[] authenticationradiuspolicyArray = new authenticationradiuspolicy[resources.Length];
        for (int index = 0; index < resources.Length; ++index)
        {
          authenticationradiuspolicyArray[index] = new authenticationradiuspolicy();
          authenticationradiuspolicyArray[index].name = resources[index].name;
        }
        baseResponses = base_resource.unset_bulk_request(client, (base_resource[]) authenticationradiuspolicyArray, args);
      }
      return baseResponses;
    }

    public static authenticationradiuspolicy[] get(nitro_service service) => (authenticationradiuspolicy[]) new authenticationradiuspolicy().get_resources(service, (options) null);

    public static authenticationradiuspolicy[] get(
      nitro_service service,
      options option)
    {
      return (authenticationradiuspolicy[]) new authenticationradiuspolicy().get_resources(service, option);
    }

    public static authenticationradiuspolicy get(
      nitro_service service,
      string name)
    {
      return (authenticationradiuspolicy) new authenticationradiuspolicy()
      {
        name = name
      }.get_resource(service);
    }

    public static authenticationradiuspolicy[] get(
      nitro_service service,
      string[] name)
    {
      if (name == null || name.Length <= 0)
        return (authenticationradiuspolicy[]) null;
      authenticationradiuspolicy[] authenticationradiuspolicyArray1 = new authenticationradiuspolicy[name.Length];
      authenticationradiuspolicy[] authenticationradiuspolicyArray2 = new authenticationradiuspolicy[name.Length];
      for (int index = 0; index < name.Length; ++index)
      {
        authenticationradiuspolicyArray2[index] = new authenticationradiuspolicy();
        authenticationradiuspolicyArray2[index].name = name[index];
        authenticationradiuspolicyArray1[index] = (authenticationradiuspolicy) authenticationradiuspolicyArray2[index].get_resource(service);
      }
      return authenticationradiuspolicyArray1;
    }

    public static authenticationradiuspolicy[] get_filtered(
      nitro_service service,
      string filter)
    {
      authenticationradiuspolicy authenticationradiuspolicy = new authenticationradiuspolicy();
      options option = new options();
      option.set_filter(filter);
      return (authenticationradiuspolicy[]) authenticationradiuspolicy.getfiltered(service, option);
    }

    public static authenticationradiuspolicy[] get_filtered(
      nitro_service service,
      filtervalue[] filter)
    {
      authenticationradiuspolicy authenticationradiuspolicy = new authenticationradiuspolicy();
      options option = new options();
      option.set_filter(filter);
      return (authenticationradiuspolicy[]) authenticationradiuspolicy.getfiltered(service, option);
    }

    public static uint count(nitro_service service)
    {
      authenticationradiuspolicy authenticationradiuspolicy = new authenticationradiuspolicy();
      options option = new options();
      option.set_count(true);
      authenticationradiuspolicy[] resources = (authenticationradiuspolicy[]) authenticationradiuspolicy.get_resources(service, option);
      return resources != null && resources.Length > 0 ? resources[0].__count.Value : 0U;
    }

    public static uint count_filtered(nitro_service service, string filter)
    {
      authenticationradiuspolicy authenticationradiuspolicy = new authenticationradiuspolicy();
      options option = new options();
      option.set_count(true);
      option.set_filter(filter);
      authenticationradiuspolicy[] authenticationradiuspolicyArray = (authenticationradiuspolicy[]) authenticationradiuspolicy.getfiltered(service, option);
      return authenticationradiuspolicyArray != null && authenticationradiuspolicyArray.Length > 0 ? authenticationradiuspolicyArray[0].__count.Value : 0U;
    }

    public static uint count_filtered(nitro_service service, filtervalue[] filter)
    {
      authenticationradiuspolicy authenticationradiuspolicy = new authenticationradiuspolicy();
      options option = new options();
      option.set_count(true);
      option.set_filter(filter);
      authenticationradiuspolicy[] authenticationradiuspolicyArray = (authenticationradiuspolicy[]) authenticationradiuspolicy.getfiltered(service, option);
      return authenticationradiuspolicyArray != null && authenticationradiuspolicyArray.Length > 0 ? authenticationradiuspolicyArray[0].__count.Value : 0U;
    }

    private class authenticationradiuspolicy_response : base_response
    {
      public authenticationradiuspolicy[] authenticationradiuspolicy = (authenticationradiuspolicy[]) null;
    }
  }
}
