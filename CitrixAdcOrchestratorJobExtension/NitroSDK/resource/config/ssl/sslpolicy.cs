// Decompiled with JetBrains decompiler
// Type: com.citrix.netscaler.nitro.resource.config.ssl.sslpolicy
// Assembly: nitro, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 6CF5DDEF-E052-4F9D-953F-6644F8378A66


using com.citrix.netscaler.nitro.exception;
using com.citrix.netscaler.nitro.resource.Base;
using com.citrix.netscaler.nitro.service;
using com.citrix.netscaler.nitro.util;

namespace com.citrix.netscaler.nitro.resource.config.ssl
{
  public class sslpolicy : base_resource
  {
    private string nameField = (string) null;
    private string ruleField = (string) null;
    private string reqactionField = (string) null;
    private string actionField = (string) null;
    private string undefactionField = (string) null;
    private string commentField = (string) null;
    private long? hitsField = new long?();
    private long? undefhitsField = new long?();
    private string descriptionField = (string) null;
    private string policytypeField = (string) null;
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

    public string action
    {
      get => this.actionField;
      set => this.actionField = value;
    }

    public string undefaction
    {
      get => this.undefactionField;
      set => this.undefactionField = value;
    }

    public string comment
    {
      get => this.commentField;
      set => this.commentField = value;
    }

    public long? hits
    {
      get => this.hitsField;
      private set => this.hitsField = value;
    }

    public long? undefhits
    {
      get => this.undefhitsField;
      private set => this.undefhitsField = value;
    }

    public string description
    {
      get => this.descriptionField;
      private set => this.descriptionField = value;
    }

    public string policytype
    {
      get => this.policytypeField;
      private set => this.policytypeField = value;
    }

    internal override base_resource[] get_nitro_response(
      nitro_service service,
      string response)
    {
      sslpolicy.sslpolicy_response sslpolicyResponse = new sslpolicy.sslpolicy_response();
      sslpolicy.sslpolicy_response resource = (sslpolicy.sslpolicy_response) service.get_payload_formatter().string_to_resource(sslpolicyResponse.GetType(), response);
      if (resource.errorcode != 0)
      {
        if (resource.errorcode == 444)
          service.clear_session();
        if (resource.severity == null)
          throw new nitro_exception(resource.message, resource.errorcode);
        if (resource.severity.Equals("ERROR"))
          throw new nitro_exception(resource.message, resource.errorcode);
      }
      return (base_resource[]) resource.sslpolicy;
    }

    internal override string get_object_name() => this.name;

    public static base_response add(nitro_service client, sslpolicy resource) => new sslpolicy()
    {
      name = resource.name,
      rule = resource.rule,
      reqaction = resource.reqaction,
      action = resource.action,
      undefaction = resource.undefaction,
      comment = resource.comment
    }.add_resource(client);

    public static base_responses add(nitro_service client, sslpolicy[] resources)
    {
      base_responses baseResponses = (base_responses) null;
      if (resources != null && resources.Length > 0)
      {
        sslpolicy[] sslpolicyArray = new sslpolicy[resources.Length];
        for (int index = 0; index < resources.Length; ++index)
        {
          sslpolicyArray[index] = new sslpolicy();
          sslpolicyArray[index].name = resources[index].name;
          sslpolicyArray[index].rule = resources[index].rule;
          sslpolicyArray[index].reqaction = resources[index].reqaction;
          sslpolicyArray[index].action = resources[index].action;
          sslpolicyArray[index].undefaction = resources[index].undefaction;
          sslpolicyArray[index].comment = resources[index].comment;
        }
        baseResponses = base_resource.add_bulk_request(client, (base_resource[]) sslpolicyArray);
      }
      return baseResponses;
    }

    public static base_response delete(nitro_service client, string name) => new sslpolicy()
    {
      name = name
    }.delete_resource(client);

    public static base_response delete(nitro_service client, sslpolicy resource) => new sslpolicy()
    {
      name = resource.name
    }.delete_resource(client);

    public static base_responses delete(nitro_service client, string[] name)
    {
      base_responses baseResponses = (base_responses) null;
      if (name != null && name.Length > 0)
      {
        sslpolicy[] sslpolicyArray = new sslpolicy[name.Length];
        for (int index = 0; index < name.Length; ++index)
        {
          sslpolicyArray[index] = new sslpolicy();
          sslpolicyArray[index].name = name[index];
        }
        baseResponses = base_resource.delete_bulk_request(client, (base_resource[]) sslpolicyArray);
      }
      return baseResponses;
    }

    public static base_responses delete(nitro_service client, sslpolicy[] resources)
    {
      base_responses baseResponses = (base_responses) null;
      if (resources != null && resources.Length > 0)
      {
        sslpolicy[] sslpolicyArray = new sslpolicy[resources.Length];
        for (int index = 0; index < resources.Length; ++index)
        {
          sslpolicyArray[index] = new sslpolicy();
          sslpolicyArray[index].name = resources[index].name;
        }
        baseResponses = base_resource.delete_bulk_request(client, (base_resource[]) sslpolicyArray);
      }
      return baseResponses;
    }

    public static base_response update(nitro_service client, sslpolicy resource) => new sslpolicy()
    {
      name = resource.name,
      rule = resource.rule,
      action = resource.action,
      undefaction = resource.undefaction,
      comment = resource.comment
    }.update_resource(client);

    public static base_responses update(nitro_service client, sslpolicy[] resources)
    {
      base_responses baseResponses = (base_responses) null;
      if (resources != null && resources.Length > 0)
      {
        sslpolicy[] sslpolicyArray = new sslpolicy[resources.Length];
        for (int index = 0; index < resources.Length; ++index)
        {
          sslpolicyArray[index] = new sslpolicy();
          sslpolicyArray[index].name = resources[index].name;
          sslpolicyArray[index].rule = resources[index].rule;
          sslpolicyArray[index].action = resources[index].action;
          sslpolicyArray[index].undefaction = resources[index].undefaction;
          sslpolicyArray[index].comment = resources[index].comment;
        }
        baseResponses = base_resource.update_bulk_request(client, (base_resource[]) sslpolicyArray);
      }
      return baseResponses;
    }

    public static base_response unset(
      nitro_service client,
      string name,
      string[] args)
    {
      return new sslpolicy() { name = name }.unset_resource(client, args);
    }

    public static base_response unset(
      nitro_service client,
      sslpolicy resource,
      string[] args)
    {
      return new sslpolicy() { name = resource.name }.unset_resource(client, args);
    }

    public static base_responses unset(
      nitro_service client,
      string[] name,
      string[] args)
    {
      base_responses baseResponses = (base_responses) null;
      if (name != null && name.Length > 0)
      {
        sslpolicy[] sslpolicyArray = new sslpolicy[name.Length];
        for (int index = 0; index < name.Length; ++index)
        {
          sslpolicyArray[index] = new sslpolicy();
          sslpolicyArray[index].name = name[index];
        }
        baseResponses = base_resource.unset_bulk_request(client, (base_resource[]) sslpolicyArray, args);
      }
      return baseResponses;
    }

    public static base_responses unset(
      nitro_service client,
      sslpolicy[] resources,
      string[] args)
    {
      base_responses baseResponses = (base_responses) null;
      if (resources != null && resources.Length > 0)
      {
        sslpolicy[] sslpolicyArray = new sslpolicy[resources.Length];
        for (int index = 0; index < resources.Length; ++index)
        {
          sslpolicyArray[index] = new sslpolicy();
          sslpolicyArray[index].name = resources[index].name;
        }
        baseResponses = base_resource.unset_bulk_request(client, (base_resource[]) sslpolicyArray, args);
      }
      return baseResponses;
    }

    public static sslpolicy[] get(nitro_service service) => (sslpolicy[]) new sslpolicy().get_resources(service, (options) null);

    public static sslpolicy[] get(nitro_service service, options option) => (sslpolicy[]) new sslpolicy().get_resources(service, option);

    public static sslpolicy get(nitro_service service, string name) => (sslpolicy) new sslpolicy()
    {
      name = name
    }.get_resource(service);

    public static sslpolicy[] get(nitro_service service, string[] name)
    {
      if (name == null || name.Length <= 0)
        return (sslpolicy[]) null;
      sslpolicy[] sslpolicyArray1 = new sslpolicy[name.Length];
      sslpolicy[] sslpolicyArray2 = new sslpolicy[name.Length];
      for (int index = 0; index < name.Length; ++index)
      {
        sslpolicyArray2[index] = new sslpolicy();
        sslpolicyArray2[index].name = name[index];
        sslpolicyArray1[index] = (sslpolicy) sslpolicyArray2[index].get_resource(service);
      }
      return sslpolicyArray1;
    }

    public static sslpolicy[] get_filtered(nitro_service service, string filter)
    {
      sslpolicy sslpolicy = new sslpolicy();
      options option = new options();
      option.set_filter(filter);
      return (sslpolicy[]) sslpolicy.getfiltered(service, option);
    }

    public static sslpolicy[] get_filtered(nitro_service service, filtervalue[] filter)
    {
      sslpolicy sslpolicy = new sslpolicy();
      options option = new options();
      option.set_filter(filter);
      return (sslpolicy[]) sslpolicy.getfiltered(service, option);
    }

    public static uint count(nitro_service service)
    {
      sslpolicy sslpolicy = new sslpolicy();
      options option = new options();
      option.set_count(true);
      sslpolicy[] resources = (sslpolicy[]) sslpolicy.get_resources(service, option);
      return resources != null && resources.Length > 0 ? resources[0].__count.Value : 0U;
    }

    public static uint count_filtered(nitro_service service, string filter)
    {
      sslpolicy sslpolicy = new sslpolicy();
      options option = new options();
      option.set_count(true);
      option.set_filter(filter);
      sslpolicy[] sslpolicyArray = (sslpolicy[]) sslpolicy.getfiltered(service, option);
      return sslpolicyArray != null && sslpolicyArray.Length > 0 ? sslpolicyArray[0].__count.Value : 0U;
    }

    public static uint count_filtered(nitro_service service, filtervalue[] filter)
    {
      sslpolicy sslpolicy = new sslpolicy();
      options option = new options();
      option.set_count(true);
      option.set_filter(filter);
      sslpolicy[] sslpolicyArray = (sslpolicy[]) sslpolicy.getfiltered(service, option);
      return sslpolicyArray != null && sslpolicyArray.Length > 0 ? sslpolicyArray[0].__count.Value : 0U;
    }

    private class sslpolicy_response : base_response
    {
      public sslpolicy[] sslpolicy = (sslpolicy[]) null;
    }

    public static class policytypeEnum
    {
      public const string Classic_Policy = "Classic Policy";
      public const string Advanced_Policy = "Advanced Policy";
    }
  }
}
