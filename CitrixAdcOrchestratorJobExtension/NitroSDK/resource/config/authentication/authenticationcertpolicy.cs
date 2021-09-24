// Decompiled with JetBrains decompiler
// Type: com.citrix.netscaler.nitro.resource.config.authentication.authenticationcertpolicy
// Assembly: nitro, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 6CF5DDEF-E052-4F9D-953F-6644F8378A66


using com.citrix.netscaler.nitro.exception;
using com.citrix.netscaler.nitro.resource.Base;
using com.citrix.netscaler.nitro.service;
using com.citrix.netscaler.nitro.util;

namespace com.citrix.netscaler.nitro.resource.config.authentication
{
  public class authenticationcertpolicy : base_resource
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
      authenticationcertpolicy.authenticationcertpolicy_response authenticationcertpolicyResponse = new authenticationcertpolicy.authenticationcertpolicy_response();
      authenticationcertpolicy.authenticationcertpolicy_response resource = (authenticationcertpolicy.authenticationcertpolicy_response) service.get_payload_formatter().string_to_resource(authenticationcertpolicyResponse.GetType(), response);
      if (resource.errorcode != 0)
      {
        if (resource.errorcode == 444)
          service.clear_session();
        if (resource.severity == null)
          throw new nitro_exception(resource.message, resource.errorcode);
        if (resource.severity.Equals("ERROR"))
          throw new nitro_exception(resource.message, resource.errorcode);
      }
      return (base_resource[]) resource.authenticationcertpolicy;
    }

    internal override string get_object_name() => this.name;

    public static base_response add(
      nitro_service client,
      authenticationcertpolicy resource)
    {
      return new authenticationcertpolicy()
      {
        name = resource.name,
        rule = resource.rule,
        reqaction = resource.reqaction
      }.add_resource(client);
    }

    public static base_responses add(
      nitro_service client,
      authenticationcertpolicy[] resources)
    {
      base_responses baseResponses = (base_responses) null;
      if (resources != null && resources.Length > 0)
      {
        authenticationcertpolicy[] authenticationcertpolicyArray = new authenticationcertpolicy[resources.Length];
        for (int index = 0; index < resources.Length; ++index)
        {
          authenticationcertpolicyArray[index] = new authenticationcertpolicy();
          authenticationcertpolicyArray[index].name = resources[index].name;
          authenticationcertpolicyArray[index].rule = resources[index].rule;
          authenticationcertpolicyArray[index].reqaction = resources[index].reqaction;
        }
        baseResponses = base_resource.add_bulk_request(client, (base_resource[]) authenticationcertpolicyArray);
      }
      return baseResponses;
    }

    public static base_response delete(nitro_service client, string name) => new authenticationcertpolicy()
    {
      name = name
    }.delete_resource(client);

    public static base_response delete(
      nitro_service client,
      authenticationcertpolicy resource)
    {
      return new authenticationcertpolicy()
      {
        name = resource.name
      }.delete_resource(client);
    }

    public static base_responses delete(nitro_service client, string[] name)
    {
      base_responses baseResponses = (base_responses) null;
      if (name != null && name.Length > 0)
      {
        authenticationcertpolicy[] authenticationcertpolicyArray = new authenticationcertpolicy[name.Length];
        for (int index = 0; index < name.Length; ++index)
        {
          authenticationcertpolicyArray[index] = new authenticationcertpolicy();
          authenticationcertpolicyArray[index].name = name[index];
        }
        baseResponses = base_resource.delete_bulk_request(client, (base_resource[]) authenticationcertpolicyArray);
      }
      return baseResponses;
    }

    public static base_responses delete(
      nitro_service client,
      authenticationcertpolicy[] resources)
    {
      base_responses baseResponses = (base_responses) null;
      if (resources != null && resources.Length > 0)
      {
        authenticationcertpolicy[] authenticationcertpolicyArray = new authenticationcertpolicy[resources.Length];
        for (int index = 0; index < resources.Length; ++index)
        {
          authenticationcertpolicyArray[index] = new authenticationcertpolicy();
          authenticationcertpolicyArray[index].name = resources[index].name;
        }
        baseResponses = base_resource.delete_bulk_request(client, (base_resource[]) authenticationcertpolicyArray);
      }
      return baseResponses;
    }

    public static base_response update(
      nitro_service client,
      authenticationcertpolicy resource)
    {
      return new authenticationcertpolicy()
      {
        name = resource.name,
        rule = resource.rule,
        reqaction = resource.reqaction
      }.update_resource(client);
    }

    public static base_responses update(
      nitro_service client,
      authenticationcertpolicy[] resources)
    {
      base_responses baseResponses = (base_responses) null;
      if (resources != null && resources.Length > 0)
      {
        authenticationcertpolicy[] authenticationcertpolicyArray = new authenticationcertpolicy[resources.Length];
        for (int index = 0; index < resources.Length; ++index)
        {
          authenticationcertpolicyArray[index] = new authenticationcertpolicy();
          authenticationcertpolicyArray[index].name = resources[index].name;
          authenticationcertpolicyArray[index].rule = resources[index].rule;
          authenticationcertpolicyArray[index].reqaction = resources[index].reqaction;
        }
        baseResponses = base_resource.update_bulk_request(client, (base_resource[]) authenticationcertpolicyArray);
      }
      return baseResponses;
    }

    public static base_response unset(
      nitro_service client,
      string name,
      string[] args)
    {
      return new authenticationcertpolicy() { name = name }.unset_resource(client, args);
    }

    public static base_response unset(
      nitro_service client,
      authenticationcertpolicy resource,
      string[] args)
    {
      return new authenticationcertpolicy()
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
        authenticationcertpolicy[] authenticationcertpolicyArray = new authenticationcertpolicy[name.Length];
        for (int index = 0; index < name.Length; ++index)
        {
          authenticationcertpolicyArray[index] = new authenticationcertpolicy();
          authenticationcertpolicyArray[index].name = name[index];
        }
        baseResponses = base_resource.unset_bulk_request(client, (base_resource[]) authenticationcertpolicyArray, args);
      }
      return baseResponses;
    }

    public static base_responses unset(
      nitro_service client,
      authenticationcertpolicy[] resources,
      string[] args)
    {
      base_responses baseResponses = (base_responses) null;
      if (resources != null && resources.Length > 0)
      {
        authenticationcertpolicy[] authenticationcertpolicyArray = new authenticationcertpolicy[resources.Length];
        for (int index = 0; index < resources.Length; ++index)
        {
          authenticationcertpolicyArray[index] = new authenticationcertpolicy();
          authenticationcertpolicyArray[index].name = resources[index].name;
        }
        baseResponses = base_resource.unset_bulk_request(client, (base_resource[]) authenticationcertpolicyArray, args);
      }
      return baseResponses;
    }

    public static authenticationcertpolicy[] get(nitro_service service) => (authenticationcertpolicy[]) new authenticationcertpolicy().get_resources(service, (options) null);

    public static authenticationcertpolicy[] get(
      nitro_service service,
      options option)
    {
      return (authenticationcertpolicy[]) new authenticationcertpolicy().get_resources(service, option);
    }

    public static authenticationcertpolicy get(
      nitro_service service,
      string name)
    {
      return (authenticationcertpolicy) new authenticationcertpolicy()
      {
        name = name
      }.get_resource(service);
    }

    public static authenticationcertpolicy[] get(
      nitro_service service,
      string[] name)
    {
      if (name == null || name.Length <= 0)
        return (authenticationcertpolicy[]) null;
      authenticationcertpolicy[] authenticationcertpolicyArray1 = new authenticationcertpolicy[name.Length];
      authenticationcertpolicy[] authenticationcertpolicyArray2 = new authenticationcertpolicy[name.Length];
      for (int index = 0; index < name.Length; ++index)
      {
        authenticationcertpolicyArray2[index] = new authenticationcertpolicy();
        authenticationcertpolicyArray2[index].name = name[index];
        authenticationcertpolicyArray1[index] = (authenticationcertpolicy) authenticationcertpolicyArray2[index].get_resource(service);
      }
      return authenticationcertpolicyArray1;
    }

    public static authenticationcertpolicy[] get_filtered(
      nitro_service service,
      string filter)
    {
      authenticationcertpolicy authenticationcertpolicy = new authenticationcertpolicy();
      options option = new options();
      option.set_filter(filter);
      return (authenticationcertpolicy[]) authenticationcertpolicy.getfiltered(service, option);
    }

    public static authenticationcertpolicy[] get_filtered(
      nitro_service service,
      filtervalue[] filter)
    {
      authenticationcertpolicy authenticationcertpolicy = new authenticationcertpolicy();
      options option = new options();
      option.set_filter(filter);
      return (authenticationcertpolicy[]) authenticationcertpolicy.getfiltered(service, option);
    }

    public static uint count(nitro_service service)
    {
      authenticationcertpolicy authenticationcertpolicy = new authenticationcertpolicy();
      options option = new options();
      option.set_count(true);
      authenticationcertpolicy[] resources = (authenticationcertpolicy[]) authenticationcertpolicy.get_resources(service, option);
      return resources != null && resources.Length > 0 ? resources[0].__count.Value : 0U;
    }

    public static uint count_filtered(nitro_service service, string filter)
    {
      authenticationcertpolicy authenticationcertpolicy = new authenticationcertpolicy();
      options option = new options();
      option.set_count(true);
      option.set_filter(filter);
      authenticationcertpolicy[] authenticationcertpolicyArray = (authenticationcertpolicy[]) authenticationcertpolicy.getfiltered(service, option);
      return authenticationcertpolicyArray != null && authenticationcertpolicyArray.Length > 0 ? authenticationcertpolicyArray[0].__count.Value : 0U;
    }

    public static uint count_filtered(nitro_service service, filtervalue[] filter)
    {
      authenticationcertpolicy authenticationcertpolicy = new authenticationcertpolicy();
      options option = new options();
      option.set_count(true);
      option.set_filter(filter);
      authenticationcertpolicy[] authenticationcertpolicyArray = (authenticationcertpolicy[]) authenticationcertpolicy.getfiltered(service, option);
      return authenticationcertpolicyArray != null && authenticationcertpolicyArray.Length > 0 ? authenticationcertpolicyArray[0].__count.Value : 0U;
    }

    private class authenticationcertpolicy_response : base_response
    {
      public authenticationcertpolicy[] authenticationcertpolicy = (authenticationcertpolicy[]) null;
    }
  }
}
