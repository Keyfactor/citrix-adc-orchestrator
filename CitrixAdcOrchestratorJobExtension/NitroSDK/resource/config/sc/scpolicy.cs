// Decompiled with JetBrains decompiler
// Type: com.citrix.netscaler.nitro.resource.config.sc.scpolicy
// Assembly: nitro, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 6CF5DDEF-E052-4F9D-953F-6644F8378A66


using com.citrix.netscaler.nitro.exception;
using com.citrix.netscaler.nitro.resource.Base;
using com.citrix.netscaler.nitro.service;
using com.citrix.netscaler.nitro.util;

namespace com.citrix.netscaler.nitro.resource.config.sc
{
  public class scpolicy : base_resource
  {
    private string nameField = (string) null;
    private string urlField = (string) null;
    private string ruleField = (string) null;
    private uint? delayField = new uint?();
    private uint? maxconnField = new uint?();
    private string actionField = (string) null;
    private string altcontentsvcnameField = (string) null;
    private string altcontentpathField = (string) null;
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

    public string url
    {
      get => this.urlField;
      set => this.urlField = value;
    }

    public string rule
    {
      get => this.ruleField;
      set => this.ruleField = value;
    }

    public uint? delay
    {
      get => this.delayField;
      set => this.delayField = value;
    }

    public uint? maxconn
    {
      get => this.maxconnField;
      set => this.maxconnField = value;
    }

    public string action
    {
      get => this.actionField;
      set => this.actionField = value;
    }

    public string altcontentsvcname
    {
      get => this.altcontentsvcnameField;
      set => this.altcontentsvcnameField = value;
    }

    public string altcontentpath
    {
      get => this.altcontentpathField;
      set => this.altcontentpathField = value;
    }

    internal override base_resource[] get_nitro_response(
      nitro_service service,
      string response)
    {
      scpolicy.scpolicy_response scpolicyResponse = new scpolicy.scpolicy_response();
      scpolicy.scpolicy_response resource = (scpolicy.scpolicy_response) service.get_payload_formatter().string_to_resource(scpolicyResponse.GetType(), response);
      if (resource.errorcode != 0)
      {
        if (resource.errorcode == 444)
          service.clear_session();
        if (resource.severity == null)
          throw new nitro_exception(resource.message, resource.errorcode);
        if (resource.severity.Equals("ERROR"))
          throw new nitro_exception(resource.message, resource.errorcode);
      }
      return (base_resource[]) resource.scpolicy;
    }

    internal override string get_object_name() => this.name;

    public static base_response add(nitro_service client, scpolicy resource) => new scpolicy()
    {
      name = resource.name,
      url = resource.url,
      rule = resource.rule,
      delay = resource.delay,
      maxconn = resource.maxconn,
      action = resource.action,
      altcontentsvcname = resource.altcontentsvcname,
      altcontentpath = resource.altcontentpath
    }.add_resource(client);

    public static base_responses add(nitro_service client, scpolicy[] resources)
    {
      base_responses baseResponses = (base_responses) null;
      if (resources != null && resources.Length > 0)
      {
        scpolicy[] scpolicyArray = new scpolicy[resources.Length];
        for (int index = 0; index < resources.Length; ++index)
        {
          scpolicyArray[index] = new scpolicy();
          scpolicyArray[index].name = resources[index].name;
          scpolicyArray[index].url = resources[index].url;
          scpolicyArray[index].rule = resources[index].rule;
          scpolicyArray[index].delay = resources[index].delay;
          scpolicyArray[index].maxconn = resources[index].maxconn;
          scpolicyArray[index].action = resources[index].action;
          scpolicyArray[index].altcontentsvcname = resources[index].altcontentsvcname;
          scpolicyArray[index].altcontentpath = resources[index].altcontentpath;
        }
        baseResponses = base_resource.add_bulk_request(client, (base_resource[]) scpolicyArray);
      }
      return baseResponses;
    }

    public static base_response delete(nitro_service client, string name) => new scpolicy()
    {
      name = name
    }.delete_resource(client);

    public static base_response delete(nitro_service client, scpolicy resource) => new scpolicy()
    {
      name = resource.name
    }.delete_resource(client);

    public static base_responses delete(nitro_service client, string[] name)
    {
      base_responses baseResponses = (base_responses) null;
      if (name != null && name.Length > 0)
      {
        scpolicy[] scpolicyArray = new scpolicy[name.Length];
        for (int index = 0; index < name.Length; ++index)
        {
          scpolicyArray[index] = new scpolicy();
          scpolicyArray[index].name = name[index];
        }
        baseResponses = base_resource.delete_bulk_request(client, (base_resource[]) scpolicyArray);
      }
      return baseResponses;
    }

    public static base_responses delete(nitro_service client, scpolicy[] resources)
    {
      base_responses baseResponses = (base_responses) null;
      if (resources != null && resources.Length > 0)
      {
        scpolicy[] scpolicyArray = new scpolicy[resources.Length];
        for (int index = 0; index < resources.Length; ++index)
        {
          scpolicyArray[index] = new scpolicy();
          scpolicyArray[index].name = resources[index].name;
        }
        baseResponses = base_resource.delete_bulk_request(client, (base_resource[]) scpolicyArray);
      }
      return baseResponses;
    }

    public static base_response update(nitro_service client, scpolicy resource) => new scpolicy()
    {
      name = resource.name,
      url = resource.url,
      rule = resource.rule,
      delay = resource.delay,
      maxconn = resource.maxconn,
      action = resource.action,
      altcontentsvcname = resource.altcontentsvcname,
      altcontentpath = resource.altcontentpath
    }.update_resource(client);

    public static base_responses update(nitro_service client, scpolicy[] resources)
    {
      base_responses baseResponses = (base_responses) null;
      if (resources != null && resources.Length > 0)
      {
        scpolicy[] scpolicyArray = new scpolicy[resources.Length];
        for (int index = 0; index < resources.Length; ++index)
        {
          scpolicyArray[index] = new scpolicy();
          scpolicyArray[index].name = resources[index].name;
          scpolicyArray[index].url = resources[index].url;
          scpolicyArray[index].rule = resources[index].rule;
          scpolicyArray[index].delay = resources[index].delay;
          scpolicyArray[index].maxconn = resources[index].maxconn;
          scpolicyArray[index].action = resources[index].action;
          scpolicyArray[index].altcontentsvcname = resources[index].altcontentsvcname;
          scpolicyArray[index].altcontentpath = resources[index].altcontentpath;
        }
        baseResponses = base_resource.update_bulk_request(client, (base_resource[]) scpolicyArray);
      }
      return baseResponses;
    }

    public static base_response unset(
      nitro_service client,
      string name,
      string[] args)
    {
      return new scpolicy() { name = name }.unset_resource(client, args);
    }

    public static base_response unset(
      nitro_service client,
      scpolicy resource,
      string[] args)
    {
      return new scpolicy() { name = resource.name }.unset_resource(client, args);
    }

    public static base_responses unset(
      nitro_service client,
      string[] name,
      string[] args)
    {
      base_responses baseResponses = (base_responses) null;
      if (name != null && name.Length > 0)
      {
        scpolicy[] scpolicyArray = new scpolicy[name.Length];
        for (int index = 0; index < name.Length; ++index)
        {
          scpolicyArray[index] = new scpolicy();
          scpolicyArray[index].name = name[index];
        }
        baseResponses = base_resource.unset_bulk_request(client, (base_resource[]) scpolicyArray, args);
      }
      return baseResponses;
    }

    public static base_responses unset(
      nitro_service client,
      scpolicy[] resources,
      string[] args)
    {
      base_responses baseResponses = (base_responses) null;
      if (resources != null && resources.Length > 0)
      {
        scpolicy[] scpolicyArray = new scpolicy[resources.Length];
        for (int index = 0; index < resources.Length; ++index)
        {
          scpolicyArray[index] = new scpolicy();
          scpolicyArray[index].name = resources[index].name;
        }
        baseResponses = base_resource.unset_bulk_request(client, (base_resource[]) scpolicyArray, args);
      }
      return baseResponses;
    }

    public static scpolicy[] get(nitro_service service) => (scpolicy[]) new scpolicy().get_resources(service, (options) null);

    public static scpolicy[] get(nitro_service service, options option) => (scpolicy[]) new scpolicy().get_resources(service, option);

    public static scpolicy get(nitro_service service, string name) => (scpolicy) new scpolicy()
    {
      name = name
    }.get_resource(service);

    public static scpolicy[] get(nitro_service service, string[] name)
    {
      if (name == null || name.Length <= 0)
        return (scpolicy[]) null;
      scpolicy[] scpolicyArray1 = new scpolicy[name.Length];
      scpolicy[] scpolicyArray2 = new scpolicy[name.Length];
      for (int index = 0; index < name.Length; ++index)
      {
        scpolicyArray2[index] = new scpolicy();
        scpolicyArray2[index].name = name[index];
        scpolicyArray1[index] = (scpolicy) scpolicyArray2[index].get_resource(service);
      }
      return scpolicyArray1;
    }

    public static scpolicy[] get_filtered(nitro_service service, string filter)
    {
      scpolicy scpolicy = new scpolicy();
      options option = new options();
      option.set_filter(filter);
      return (scpolicy[]) scpolicy.getfiltered(service, option);
    }

    public static scpolicy[] get_filtered(nitro_service service, filtervalue[] filter)
    {
      scpolicy scpolicy = new scpolicy();
      options option = new options();
      option.set_filter(filter);
      return (scpolicy[]) scpolicy.getfiltered(service, option);
    }

    public static uint count(nitro_service service)
    {
      scpolicy scpolicy = new scpolicy();
      options option = new options();
      option.set_count(true);
      scpolicy[] resources = (scpolicy[]) scpolicy.get_resources(service, option);
      return resources != null && resources.Length > 0 ? resources[0].__count.Value : 0U;
    }

    public static uint count_filtered(nitro_service service, string filter)
    {
      scpolicy scpolicy = new scpolicy();
      options option = new options();
      option.set_count(true);
      option.set_filter(filter);
      scpolicy[] scpolicyArray = (scpolicy[]) scpolicy.getfiltered(service, option);
      return scpolicyArray != null && scpolicyArray.Length > 0 ? scpolicyArray[0].__count.Value : 0U;
    }

    public static uint count_filtered(nitro_service service, filtervalue[] filter)
    {
      scpolicy scpolicy = new scpolicy();
      options option = new options();
      option.set_count(true);
      option.set_filter(filter);
      scpolicy[] scpolicyArray = (scpolicy[]) scpolicy.getfiltered(service, option);
      return scpolicyArray != null && scpolicyArray.Length > 0 ? scpolicyArray[0].__count.Value : 0U;
    }

    private class scpolicy_response : base_response
    {
      public scpolicy[] scpolicy = (scpolicy[]) null;
    }

    public static class actionEnum
    {
      public const string ACS = "ACS";
      public const string NS = "NS";
      public const string NOACTION = "NOACTION";
    }
  }
}
