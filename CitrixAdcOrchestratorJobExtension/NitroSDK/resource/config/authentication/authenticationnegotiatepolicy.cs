// Decompiled with JetBrains decompiler
// Type: com.citrix.netscaler.nitro.resource.config.authentication.authenticationnegotiatepolicy
// Assembly: nitro, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 6CF5DDEF-E052-4F9D-953F-6644F8378A66


using com.citrix.netscaler.nitro.exception;
using com.citrix.netscaler.nitro.resource.Base;
using com.citrix.netscaler.nitro.service;
using com.citrix.netscaler.nitro.util;

namespace com.citrix.netscaler.nitro.resource.config.authentication
{
  public class authenticationnegotiatepolicy : base_resource
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
      authenticationnegotiatepolicy.authenticationnegotiatepolicy_response authenticationnegotiatepolicyResponse = new authenticationnegotiatepolicy.authenticationnegotiatepolicy_response();
      authenticationnegotiatepolicy.authenticationnegotiatepolicy_response resource = (authenticationnegotiatepolicy.authenticationnegotiatepolicy_response) service.get_payload_formatter().string_to_resource(authenticationnegotiatepolicyResponse.GetType(), response);
      if (resource.errorcode != 0)
      {
        if (resource.errorcode == 444)
          service.clear_session();
        if (resource.severity == null)
          throw new nitro_exception(resource.message, resource.errorcode);
        if (resource.severity.Equals("ERROR"))
          throw new nitro_exception(resource.message, resource.errorcode);
      }
      return (base_resource[]) resource.authenticationnegotiatepolicy;
    }

    internal override string get_object_name() => this.name;

    public static base_response add(
      nitro_service client,
      authenticationnegotiatepolicy resource)
    {
      return new authenticationnegotiatepolicy()
      {
        name = resource.name,
        rule = resource.rule,
        reqaction = resource.reqaction
      }.add_resource(client);
    }

    public static base_responses add(
      nitro_service client,
      authenticationnegotiatepolicy[] resources)
    {
      base_responses baseResponses = (base_responses) null;
      if (resources != null && resources.Length > 0)
      {
        authenticationnegotiatepolicy[] authenticationnegotiatepolicyArray = new authenticationnegotiatepolicy[resources.Length];
        for (int index = 0; index < resources.Length; ++index)
        {
          authenticationnegotiatepolicyArray[index] = new authenticationnegotiatepolicy();
          authenticationnegotiatepolicyArray[index].name = resources[index].name;
          authenticationnegotiatepolicyArray[index].rule = resources[index].rule;
          authenticationnegotiatepolicyArray[index].reqaction = resources[index].reqaction;
        }
        baseResponses = base_resource.add_bulk_request(client, (base_resource[]) authenticationnegotiatepolicyArray);
      }
      return baseResponses;
    }

    public static base_response delete(nitro_service client, string name) => new authenticationnegotiatepolicy()
    {
      name = name
    }.delete_resource(client);

    public static base_response delete(
      nitro_service client,
      authenticationnegotiatepolicy resource)
    {
      return new authenticationnegotiatepolicy()
      {
        name = resource.name
      }.delete_resource(client);
    }

    public static base_responses delete(nitro_service client, string[] name)
    {
      base_responses baseResponses = (base_responses) null;
      if (name != null && name.Length > 0)
      {
        authenticationnegotiatepolicy[] authenticationnegotiatepolicyArray = new authenticationnegotiatepolicy[name.Length];
        for (int index = 0; index < name.Length; ++index)
        {
          authenticationnegotiatepolicyArray[index] = new authenticationnegotiatepolicy();
          authenticationnegotiatepolicyArray[index].name = name[index];
        }
        baseResponses = base_resource.delete_bulk_request(client, (base_resource[]) authenticationnegotiatepolicyArray);
      }
      return baseResponses;
    }

    public static base_responses delete(
      nitro_service client,
      authenticationnegotiatepolicy[] resources)
    {
      base_responses baseResponses = (base_responses) null;
      if (resources != null && resources.Length > 0)
      {
        authenticationnegotiatepolicy[] authenticationnegotiatepolicyArray = new authenticationnegotiatepolicy[resources.Length];
        for (int index = 0; index < resources.Length; ++index)
        {
          authenticationnegotiatepolicyArray[index] = new authenticationnegotiatepolicy();
          authenticationnegotiatepolicyArray[index].name = resources[index].name;
        }
        baseResponses = base_resource.delete_bulk_request(client, (base_resource[]) authenticationnegotiatepolicyArray);
      }
      return baseResponses;
    }

    public static base_response update(
      nitro_service client,
      authenticationnegotiatepolicy resource)
    {
      return new authenticationnegotiatepolicy()
      {
        name = resource.name,
        rule = resource.rule,
        reqaction = resource.reqaction
      }.update_resource(client);
    }

    public static base_responses update(
      nitro_service client,
      authenticationnegotiatepolicy[] resources)
    {
      base_responses baseResponses = (base_responses) null;
      if (resources != null && resources.Length > 0)
      {
        authenticationnegotiatepolicy[] authenticationnegotiatepolicyArray = new authenticationnegotiatepolicy[resources.Length];
        for (int index = 0; index < resources.Length; ++index)
        {
          authenticationnegotiatepolicyArray[index] = new authenticationnegotiatepolicy();
          authenticationnegotiatepolicyArray[index].name = resources[index].name;
          authenticationnegotiatepolicyArray[index].rule = resources[index].rule;
          authenticationnegotiatepolicyArray[index].reqaction = resources[index].reqaction;
        }
        baseResponses = base_resource.update_bulk_request(client, (base_resource[]) authenticationnegotiatepolicyArray);
      }
      return baseResponses;
    }

    public static authenticationnegotiatepolicy[] get(
      nitro_service service)
    {
      return (authenticationnegotiatepolicy[]) new authenticationnegotiatepolicy().get_resources(service, (options) null);
    }

    public static authenticationnegotiatepolicy[] get(
      nitro_service service,
      options option)
    {
      return (authenticationnegotiatepolicy[]) new authenticationnegotiatepolicy().get_resources(service, option);
    }

    public static authenticationnegotiatepolicy get(
      nitro_service service,
      string name)
    {
      return (authenticationnegotiatepolicy) new authenticationnegotiatepolicy()
      {
        name = name
      }.get_resource(service);
    }

    public static authenticationnegotiatepolicy[] get(
      nitro_service service,
      string[] name)
    {
      if (name == null || name.Length <= 0)
        return (authenticationnegotiatepolicy[]) null;
      authenticationnegotiatepolicy[] authenticationnegotiatepolicyArray1 = new authenticationnegotiatepolicy[name.Length];
      authenticationnegotiatepolicy[] authenticationnegotiatepolicyArray2 = new authenticationnegotiatepolicy[name.Length];
      for (int index = 0; index < name.Length; ++index)
      {
        authenticationnegotiatepolicyArray2[index] = new authenticationnegotiatepolicy();
        authenticationnegotiatepolicyArray2[index].name = name[index];
        authenticationnegotiatepolicyArray1[index] = (authenticationnegotiatepolicy) authenticationnegotiatepolicyArray2[index].get_resource(service);
      }
      return authenticationnegotiatepolicyArray1;
    }

    public static authenticationnegotiatepolicy[] get_filtered(
      nitro_service service,
      string filter)
    {
      authenticationnegotiatepolicy authenticationnegotiatepolicy = new authenticationnegotiatepolicy();
      options option = new options();
      option.set_filter(filter);
      return (authenticationnegotiatepolicy[]) authenticationnegotiatepolicy.getfiltered(service, option);
    }

    public static authenticationnegotiatepolicy[] get_filtered(
      nitro_service service,
      filtervalue[] filter)
    {
      authenticationnegotiatepolicy authenticationnegotiatepolicy = new authenticationnegotiatepolicy();
      options option = new options();
      option.set_filter(filter);
      return (authenticationnegotiatepolicy[]) authenticationnegotiatepolicy.getfiltered(service, option);
    }

    public static uint count(nitro_service service)
    {
      authenticationnegotiatepolicy authenticationnegotiatepolicy = new authenticationnegotiatepolicy();
      options option = new options();
      option.set_count(true);
      authenticationnegotiatepolicy[] resources = (authenticationnegotiatepolicy[]) authenticationnegotiatepolicy.get_resources(service, option);
      return resources != null && resources.Length > 0 ? resources[0].__count.Value : 0U;
    }

    public static uint count_filtered(nitro_service service, string filter)
    {
      authenticationnegotiatepolicy authenticationnegotiatepolicy = new authenticationnegotiatepolicy();
      options option = new options();
      option.set_count(true);
      option.set_filter(filter);
      authenticationnegotiatepolicy[] authenticationnegotiatepolicyArray = (authenticationnegotiatepolicy[]) authenticationnegotiatepolicy.getfiltered(service, option);
      return authenticationnegotiatepolicyArray != null && authenticationnegotiatepolicyArray.Length > 0 ? authenticationnegotiatepolicyArray[0].__count.Value : 0U;
    }

    public static uint count_filtered(nitro_service service, filtervalue[] filter)
    {
      authenticationnegotiatepolicy authenticationnegotiatepolicy = new authenticationnegotiatepolicy();
      options option = new options();
      option.set_count(true);
      option.set_filter(filter);
      authenticationnegotiatepolicy[] authenticationnegotiatepolicyArray = (authenticationnegotiatepolicy[]) authenticationnegotiatepolicy.getfiltered(service, option);
      return authenticationnegotiatepolicyArray != null && authenticationnegotiatepolicyArray.Length > 0 ? authenticationnegotiatepolicyArray[0].__count.Value : 0U;
    }

    private class authenticationnegotiatepolicy_response : base_response
    {
      public authenticationnegotiatepolicy[] authenticationnegotiatepolicy = (authenticationnegotiatepolicy[]) null;
    }
  }
}
