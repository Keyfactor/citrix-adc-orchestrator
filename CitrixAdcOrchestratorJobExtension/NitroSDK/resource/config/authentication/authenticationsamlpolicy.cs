// Decompiled with JetBrains decompiler
// Type: com.citrix.netscaler.nitro.resource.config.authentication.authenticationsamlpolicy
// Assembly: nitro, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 6CF5DDEF-E052-4F9D-953F-6644F8378A66


using com.citrix.netscaler.nitro.exception;
using com.citrix.netscaler.nitro.resource.Base;
using com.citrix.netscaler.nitro.service;
using com.citrix.netscaler.nitro.util;

namespace com.citrix.netscaler.nitro.resource.config.authentication
{
  public class authenticationsamlpolicy : base_resource
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
      authenticationsamlpolicy.authenticationsamlpolicy_response authenticationsamlpolicyResponse = new authenticationsamlpolicy.authenticationsamlpolicy_response();
      authenticationsamlpolicy.authenticationsamlpolicy_response resource = (authenticationsamlpolicy.authenticationsamlpolicy_response) service.get_payload_formatter().string_to_resource(authenticationsamlpolicyResponse.GetType(), response);
      if (resource.errorcode != 0)
      {
        if (resource.errorcode == 444)
          service.clear_session();
        if (resource.severity == null)
          throw new nitro_exception(resource.message, resource.errorcode);
        if (resource.severity.Equals("ERROR"))
          throw new nitro_exception(resource.message, resource.errorcode);
      }
      return (base_resource[]) resource.authenticationsamlpolicy;
    }

    internal override string get_object_name() => this.name;

    public static base_response add(
      nitro_service client,
      authenticationsamlpolicy resource)
    {
      return new authenticationsamlpolicy()
      {
        name = resource.name,
        rule = resource.rule,
        reqaction = resource.reqaction
      }.add_resource(client);
    }

    public static base_responses add(
      nitro_service client,
      authenticationsamlpolicy[] resources)
    {
      base_responses baseResponses = (base_responses) null;
      if (resources != null && resources.Length > 0)
      {
        authenticationsamlpolicy[] authenticationsamlpolicyArray = new authenticationsamlpolicy[resources.Length];
        for (int index = 0; index < resources.Length; ++index)
        {
          authenticationsamlpolicyArray[index] = new authenticationsamlpolicy();
          authenticationsamlpolicyArray[index].name = resources[index].name;
          authenticationsamlpolicyArray[index].rule = resources[index].rule;
          authenticationsamlpolicyArray[index].reqaction = resources[index].reqaction;
        }
        baseResponses = base_resource.add_bulk_request(client, (base_resource[]) authenticationsamlpolicyArray);
      }
      return baseResponses;
    }

    public static base_response delete(nitro_service client, string name) => new authenticationsamlpolicy()
    {
      name = name
    }.delete_resource(client);

    public static base_response delete(
      nitro_service client,
      authenticationsamlpolicy resource)
    {
      return new authenticationsamlpolicy()
      {
        name = resource.name
      }.delete_resource(client);
    }

    public static base_responses delete(nitro_service client, string[] name)
    {
      base_responses baseResponses = (base_responses) null;
      if (name != null && name.Length > 0)
      {
        authenticationsamlpolicy[] authenticationsamlpolicyArray = new authenticationsamlpolicy[name.Length];
        for (int index = 0; index < name.Length; ++index)
        {
          authenticationsamlpolicyArray[index] = new authenticationsamlpolicy();
          authenticationsamlpolicyArray[index].name = name[index];
        }
        baseResponses = base_resource.delete_bulk_request(client, (base_resource[]) authenticationsamlpolicyArray);
      }
      return baseResponses;
    }

    public static base_responses delete(
      nitro_service client,
      authenticationsamlpolicy[] resources)
    {
      base_responses baseResponses = (base_responses) null;
      if (resources != null && resources.Length > 0)
      {
        authenticationsamlpolicy[] authenticationsamlpolicyArray = new authenticationsamlpolicy[resources.Length];
        for (int index = 0; index < resources.Length; ++index)
        {
          authenticationsamlpolicyArray[index] = new authenticationsamlpolicy();
          authenticationsamlpolicyArray[index].name = resources[index].name;
        }
        baseResponses = base_resource.delete_bulk_request(client, (base_resource[]) authenticationsamlpolicyArray);
      }
      return baseResponses;
    }

    public static base_response update(
      nitro_service client,
      authenticationsamlpolicy resource)
    {
      return new authenticationsamlpolicy()
      {
        name = resource.name,
        rule = resource.rule,
        reqaction = resource.reqaction
      }.update_resource(client);
    }

    public static base_responses update(
      nitro_service client,
      authenticationsamlpolicy[] resources)
    {
      base_responses baseResponses = (base_responses) null;
      if (resources != null && resources.Length > 0)
      {
        authenticationsamlpolicy[] authenticationsamlpolicyArray = new authenticationsamlpolicy[resources.Length];
        for (int index = 0; index < resources.Length; ++index)
        {
          authenticationsamlpolicyArray[index] = new authenticationsamlpolicy();
          authenticationsamlpolicyArray[index].name = resources[index].name;
          authenticationsamlpolicyArray[index].rule = resources[index].rule;
          authenticationsamlpolicyArray[index].reqaction = resources[index].reqaction;
        }
        baseResponses = base_resource.update_bulk_request(client, (base_resource[]) authenticationsamlpolicyArray);
      }
      return baseResponses;
    }

    public static base_response unset(
      nitro_service client,
      string name,
      string[] args)
    {
      return new authenticationsamlpolicy() { name = name }.unset_resource(client, args);
    }

    public static base_response unset(
      nitro_service client,
      authenticationsamlpolicy resource,
      string[] args)
    {
      return new authenticationsamlpolicy()
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
        authenticationsamlpolicy[] authenticationsamlpolicyArray = new authenticationsamlpolicy[name.Length];
        for (int index = 0; index < name.Length; ++index)
        {
          authenticationsamlpolicyArray[index] = new authenticationsamlpolicy();
          authenticationsamlpolicyArray[index].name = name[index];
        }
        baseResponses = base_resource.unset_bulk_request(client, (base_resource[]) authenticationsamlpolicyArray, args);
      }
      return baseResponses;
    }

    public static base_responses unset(
      nitro_service client,
      authenticationsamlpolicy[] resources,
      string[] args)
    {
      base_responses baseResponses = (base_responses) null;
      if (resources != null && resources.Length > 0)
      {
        authenticationsamlpolicy[] authenticationsamlpolicyArray = new authenticationsamlpolicy[resources.Length];
        for (int index = 0; index < resources.Length; ++index)
        {
          authenticationsamlpolicyArray[index] = new authenticationsamlpolicy();
          authenticationsamlpolicyArray[index].name = resources[index].name;
        }
        baseResponses = base_resource.unset_bulk_request(client, (base_resource[]) authenticationsamlpolicyArray, args);
      }
      return baseResponses;
    }

    public static authenticationsamlpolicy[] get(nitro_service service) => (authenticationsamlpolicy[]) new authenticationsamlpolicy().get_resources(service, (options) null);

    public static authenticationsamlpolicy[] get(
      nitro_service service,
      options option)
    {
      return (authenticationsamlpolicy[]) new authenticationsamlpolicy().get_resources(service, option);
    }

    public static authenticationsamlpolicy get(
      nitro_service service,
      string name)
    {
      return (authenticationsamlpolicy) new authenticationsamlpolicy()
      {
        name = name
      }.get_resource(service);
    }

    public static authenticationsamlpolicy[] get(
      nitro_service service,
      string[] name)
    {
      if (name == null || name.Length <= 0)
        return (authenticationsamlpolicy[]) null;
      authenticationsamlpolicy[] authenticationsamlpolicyArray1 = new authenticationsamlpolicy[name.Length];
      authenticationsamlpolicy[] authenticationsamlpolicyArray2 = new authenticationsamlpolicy[name.Length];
      for (int index = 0; index < name.Length; ++index)
      {
        authenticationsamlpolicyArray2[index] = new authenticationsamlpolicy();
        authenticationsamlpolicyArray2[index].name = name[index];
        authenticationsamlpolicyArray1[index] = (authenticationsamlpolicy) authenticationsamlpolicyArray2[index].get_resource(service);
      }
      return authenticationsamlpolicyArray1;
    }

    public static authenticationsamlpolicy[] get_filtered(
      nitro_service service,
      string filter)
    {
      authenticationsamlpolicy authenticationsamlpolicy = new authenticationsamlpolicy();
      options option = new options();
      option.set_filter(filter);
      return (authenticationsamlpolicy[]) authenticationsamlpolicy.getfiltered(service, option);
    }

    public static authenticationsamlpolicy[] get_filtered(
      nitro_service service,
      filtervalue[] filter)
    {
      authenticationsamlpolicy authenticationsamlpolicy = new authenticationsamlpolicy();
      options option = new options();
      option.set_filter(filter);
      return (authenticationsamlpolicy[]) authenticationsamlpolicy.getfiltered(service, option);
    }

    public static uint count(nitro_service service)
    {
      authenticationsamlpolicy authenticationsamlpolicy = new authenticationsamlpolicy();
      options option = new options();
      option.set_count(true);
      authenticationsamlpolicy[] resources = (authenticationsamlpolicy[]) authenticationsamlpolicy.get_resources(service, option);
      return resources != null && resources.Length > 0 ? resources[0].__count.Value : 0U;
    }

    public static uint count_filtered(nitro_service service, string filter)
    {
      authenticationsamlpolicy authenticationsamlpolicy = new authenticationsamlpolicy();
      options option = new options();
      option.set_count(true);
      option.set_filter(filter);
      authenticationsamlpolicy[] authenticationsamlpolicyArray = (authenticationsamlpolicy[]) authenticationsamlpolicy.getfiltered(service, option);
      return authenticationsamlpolicyArray != null && authenticationsamlpolicyArray.Length > 0 ? authenticationsamlpolicyArray[0].__count.Value : 0U;
    }

    public static uint count_filtered(nitro_service service, filtervalue[] filter)
    {
      authenticationsamlpolicy authenticationsamlpolicy = new authenticationsamlpolicy();
      options option = new options();
      option.set_count(true);
      option.set_filter(filter);
      authenticationsamlpolicy[] authenticationsamlpolicyArray = (authenticationsamlpolicy[]) authenticationsamlpolicy.getfiltered(service, option);
      return authenticationsamlpolicyArray != null && authenticationsamlpolicyArray.Length > 0 ? authenticationsamlpolicyArray[0].__count.Value : 0U;
    }

    private class authenticationsamlpolicy_response : base_response
    {
      public authenticationsamlpolicy[] authenticationsamlpolicy = (authenticationsamlpolicy[]) null;
    }
  }
}
