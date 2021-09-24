// Decompiled with JetBrains decompiler
// Type: com.citrix.netscaler.nitro.resource.config.vpn.vpntrafficpolicy
// Assembly: nitro, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 6CF5DDEF-E052-4F9D-953F-6644F8378A66


using com.citrix.netscaler.nitro.exception;
using com.citrix.netscaler.nitro.resource.Base;
using com.citrix.netscaler.nitro.service;
using com.citrix.netscaler.nitro.util;

namespace com.citrix.netscaler.nitro.resource.config.vpn
{
  public class vpntrafficpolicy : base_resource
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
      vpntrafficpolicy.vpntrafficpolicy_response vpntrafficpolicyResponse = new vpntrafficpolicy.vpntrafficpolicy_response();
      vpntrafficpolicy.vpntrafficpolicy_response resource = (vpntrafficpolicy.vpntrafficpolicy_response) service.get_payload_formatter().string_to_resource(vpntrafficpolicyResponse.GetType(), response);
      if (resource.errorcode != 0)
      {
        if (resource.errorcode == 444)
          service.clear_session();
        if (resource.severity == null)
          throw new nitro_exception(resource.message, resource.errorcode);
        if (resource.severity.Equals("ERROR"))
          throw new nitro_exception(resource.message, resource.errorcode);
      }
      return (base_resource[]) resource.vpntrafficpolicy;
    }

    internal override string get_object_name() => this.name;

    public static base_response add(nitro_service client, vpntrafficpolicy resource) => new vpntrafficpolicy()
    {
      name = resource.name,
      rule = resource.rule,
      action = resource.action
    }.add_resource(client);

    public static base_responses add(
      nitro_service client,
      vpntrafficpolicy[] resources)
    {
      base_responses baseResponses = (base_responses) null;
      if (resources != null && resources.Length > 0)
      {
        vpntrafficpolicy[] vpntrafficpolicyArray = new vpntrafficpolicy[resources.Length];
        for (int index = 0; index < resources.Length; ++index)
        {
          vpntrafficpolicyArray[index] = new vpntrafficpolicy();
          vpntrafficpolicyArray[index].name = resources[index].name;
          vpntrafficpolicyArray[index].rule = resources[index].rule;
          vpntrafficpolicyArray[index].action = resources[index].action;
        }
        baseResponses = base_resource.add_bulk_request(client, (base_resource[]) vpntrafficpolicyArray);
      }
      return baseResponses;
    }

    public static base_response delete(nitro_service client, string name) => new vpntrafficpolicy()
    {
      name = name
    }.delete_resource(client);

    public static base_response delete(nitro_service client, vpntrafficpolicy resource) => new vpntrafficpolicy()
    {
      name = resource.name
    }.delete_resource(client);

    public static base_responses delete(nitro_service client, string[] name)
    {
      base_responses baseResponses = (base_responses) null;
      if (name != null && name.Length > 0)
      {
        vpntrafficpolicy[] vpntrafficpolicyArray = new vpntrafficpolicy[name.Length];
        for (int index = 0; index < name.Length; ++index)
        {
          vpntrafficpolicyArray[index] = new vpntrafficpolicy();
          vpntrafficpolicyArray[index].name = name[index];
        }
        baseResponses = base_resource.delete_bulk_request(client, (base_resource[]) vpntrafficpolicyArray);
      }
      return baseResponses;
    }

    public static base_responses delete(
      nitro_service client,
      vpntrafficpolicy[] resources)
    {
      base_responses baseResponses = (base_responses) null;
      if (resources != null && resources.Length > 0)
      {
        vpntrafficpolicy[] vpntrafficpolicyArray = new vpntrafficpolicy[resources.Length];
        for (int index = 0; index < resources.Length; ++index)
        {
          vpntrafficpolicyArray[index] = new vpntrafficpolicy();
          vpntrafficpolicyArray[index].name = resources[index].name;
        }
        baseResponses = base_resource.delete_bulk_request(client, (base_resource[]) vpntrafficpolicyArray);
      }
      return baseResponses;
    }

    public static base_response update(nitro_service client, vpntrafficpolicy resource) => new vpntrafficpolicy()
    {
      name = resource.name,
      rule = resource.rule,
      action = resource.action
    }.update_resource(client);

    public static base_responses update(
      nitro_service client,
      vpntrafficpolicy[] resources)
    {
      base_responses baseResponses = (base_responses) null;
      if (resources != null && resources.Length > 0)
      {
        vpntrafficpolicy[] vpntrafficpolicyArray = new vpntrafficpolicy[resources.Length];
        for (int index = 0; index < resources.Length; ++index)
        {
          vpntrafficpolicyArray[index] = new vpntrafficpolicy();
          vpntrafficpolicyArray[index].name = resources[index].name;
          vpntrafficpolicyArray[index].rule = resources[index].rule;
          vpntrafficpolicyArray[index].action = resources[index].action;
        }
        baseResponses = base_resource.update_bulk_request(client, (base_resource[]) vpntrafficpolicyArray);
      }
      return baseResponses;
    }

    public static base_response unset(
      nitro_service client,
      string name,
      string[] args)
    {
      return new vpntrafficpolicy() { name = name }.unset_resource(client, args);
    }

    public static base_response unset(
      nitro_service client,
      vpntrafficpolicy resource,
      string[] args)
    {
      return new vpntrafficpolicy() { name = resource.name }.unset_resource(client, args);
    }

    public static base_responses unset(
      nitro_service client,
      string[] name,
      string[] args)
    {
      base_responses baseResponses = (base_responses) null;
      if (name != null && name.Length > 0)
      {
        vpntrafficpolicy[] vpntrafficpolicyArray = new vpntrafficpolicy[name.Length];
        for (int index = 0; index < name.Length; ++index)
        {
          vpntrafficpolicyArray[index] = new vpntrafficpolicy();
          vpntrafficpolicyArray[index].name = name[index];
        }
        baseResponses = base_resource.unset_bulk_request(client, (base_resource[]) vpntrafficpolicyArray, args);
      }
      return baseResponses;
    }

    public static base_responses unset(
      nitro_service client,
      vpntrafficpolicy[] resources,
      string[] args)
    {
      base_responses baseResponses = (base_responses) null;
      if (resources != null && resources.Length > 0)
      {
        vpntrafficpolicy[] vpntrafficpolicyArray = new vpntrafficpolicy[resources.Length];
        for (int index = 0; index < resources.Length; ++index)
        {
          vpntrafficpolicyArray[index] = new vpntrafficpolicy();
          vpntrafficpolicyArray[index].name = resources[index].name;
        }
        baseResponses = base_resource.unset_bulk_request(client, (base_resource[]) vpntrafficpolicyArray, args);
      }
      return baseResponses;
    }

    public static vpntrafficpolicy[] get(nitro_service service) => (vpntrafficpolicy[]) new vpntrafficpolicy().get_resources(service, (options) null);

    public static vpntrafficpolicy[] get(nitro_service service, options option) => (vpntrafficpolicy[]) new vpntrafficpolicy().get_resources(service, option);

    public static vpntrafficpolicy get(nitro_service service, string name) => (vpntrafficpolicy) new vpntrafficpolicy()
    {
      name = name
    }.get_resource(service);

    public static vpntrafficpolicy[] get(nitro_service service, string[] name)
    {
      if (name == null || name.Length <= 0)
        return (vpntrafficpolicy[]) null;
      vpntrafficpolicy[] vpntrafficpolicyArray1 = new vpntrafficpolicy[name.Length];
      vpntrafficpolicy[] vpntrafficpolicyArray2 = new vpntrafficpolicy[name.Length];
      for (int index = 0; index < name.Length; ++index)
      {
        vpntrafficpolicyArray2[index] = new vpntrafficpolicy();
        vpntrafficpolicyArray2[index].name = name[index];
        vpntrafficpolicyArray1[index] = (vpntrafficpolicy) vpntrafficpolicyArray2[index].get_resource(service);
      }
      return vpntrafficpolicyArray1;
    }

    public static vpntrafficpolicy[] get_filtered(
      nitro_service service,
      string filter)
    {
      vpntrafficpolicy vpntrafficpolicy = new vpntrafficpolicy();
      options option = new options();
      option.set_filter(filter);
      return (vpntrafficpolicy[]) vpntrafficpolicy.getfiltered(service, option);
    }

    public static vpntrafficpolicy[] get_filtered(
      nitro_service service,
      filtervalue[] filter)
    {
      vpntrafficpolicy vpntrafficpolicy = new vpntrafficpolicy();
      options option = new options();
      option.set_filter(filter);
      return (vpntrafficpolicy[]) vpntrafficpolicy.getfiltered(service, option);
    }

    public static uint count(nitro_service service)
    {
      vpntrafficpolicy vpntrafficpolicy = new vpntrafficpolicy();
      options option = new options();
      option.set_count(true);
      vpntrafficpolicy[] resources = (vpntrafficpolicy[]) vpntrafficpolicy.get_resources(service, option);
      return resources != null && resources.Length > 0 ? resources[0].__count.Value : 0U;
    }

    public static uint count_filtered(nitro_service service, string filter)
    {
      vpntrafficpolicy vpntrafficpolicy = new vpntrafficpolicy();
      options option = new options();
      option.set_count(true);
      option.set_filter(filter);
      vpntrafficpolicy[] vpntrafficpolicyArray = (vpntrafficpolicy[]) vpntrafficpolicy.getfiltered(service, option);
      return vpntrafficpolicyArray != null && vpntrafficpolicyArray.Length > 0 ? vpntrafficpolicyArray[0].__count.Value : 0U;
    }

    public static uint count_filtered(nitro_service service, filtervalue[] filter)
    {
      vpntrafficpolicy vpntrafficpolicy = new vpntrafficpolicy();
      options option = new options();
      option.set_count(true);
      option.set_filter(filter);
      vpntrafficpolicy[] vpntrafficpolicyArray = (vpntrafficpolicy[]) vpntrafficpolicy.getfiltered(service, option);
      return vpntrafficpolicyArray != null && vpntrafficpolicyArray.Length > 0 ? vpntrafficpolicyArray[0].__count.Value : 0U;
    }

    private class vpntrafficpolicy_response : base_response
    {
      public vpntrafficpolicy[] vpntrafficpolicy = (vpntrafficpolicy[]) null;
    }
  }
}
