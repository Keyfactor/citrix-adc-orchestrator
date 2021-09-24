// Decompiled with JetBrains decompiler
// Type: com.citrix.netscaler.nitro.resource.config.ca.capolicy
// Assembly: nitro, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 6CF5DDEF-E052-4F9D-953F-6644F8378A66


using com.citrix.netscaler.nitro.exception;
using com.citrix.netscaler.nitro.resource.Base;
using com.citrix.netscaler.nitro.service;
using com.citrix.netscaler.nitro.util;

namespace com.citrix.netscaler.nitro.resource.config.ca
{
  public class capolicy : base_resource
  {
    private string nameField = (string) null;
    private string ruleField = (string) null;
    private string actionField = (string) null;
    private string undefactionField = (string) null;
    private string commentField = (string) null;
    private string logactionField = (string) null;
    private string newnameField = (string) null;
    private long? hitsField = new long?();
    private long? undefhitsField = new long?();
    private bool? isdefaultField = new bool?();
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

    public string logaction
    {
      get => this.logactionField;
      set => this.logactionField = value;
    }

    public string newname
    {
      get => this.newnameField;
      set => this.newnameField = value;
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

    public bool? isdefault
    {
      get => this.isdefaultField;
      private set => this.isdefaultField = value;
    }

    internal override base_resource[] get_nitro_response(
      nitro_service service,
      string response)
    {
      capolicy.capolicy_response capolicyResponse = new capolicy.capolicy_response();
      capolicy.capolicy_response resource = (capolicy.capolicy_response) service.get_payload_formatter().string_to_resource(capolicyResponse.GetType(), response);
      if (resource.errorcode != 0)
      {
        if (resource.errorcode == 444)
          service.clear_session();
        if (resource.severity == null)
          throw new nitro_exception(resource.message, resource.errorcode);
        if (resource.severity.Equals("ERROR"))
          throw new nitro_exception(resource.message, resource.errorcode);
      }
      return (base_resource[]) resource.capolicy;
    }

    internal override string get_object_name() => this.name;

    public static base_response add(nitro_service client, capolicy resource) => new capolicy()
    {
      name = resource.name,
      rule = resource.rule,
      action = resource.action,
      undefaction = resource.undefaction,
      comment = resource.comment,
      logaction = resource.logaction
    }.add_resource(client);

    public static base_responses add(nitro_service client, capolicy[] resources)
    {
      base_responses baseResponses = (base_responses) null;
      if (resources != null && resources.Length > 0)
      {
        capolicy[] capolicyArray = new capolicy[resources.Length];
        for (int index = 0; index < resources.Length; ++index)
        {
          capolicyArray[index] = new capolicy();
          capolicyArray[index].name = resources[index].name;
          capolicyArray[index].rule = resources[index].rule;
          capolicyArray[index].action = resources[index].action;
          capolicyArray[index].undefaction = resources[index].undefaction;
          capolicyArray[index].comment = resources[index].comment;
          capolicyArray[index].logaction = resources[index].logaction;
        }
        baseResponses = base_resource.add_bulk_request(client, (base_resource[]) capolicyArray);
      }
      return baseResponses;
    }

    public static base_response delete(nitro_service client, string name) => new capolicy()
    {
      name = name
    }.delete_resource(client);

    public static base_response delete(nitro_service client, capolicy resource) => new capolicy()
    {
      name = resource.name
    }.delete_resource(client);

    public static base_responses delete(nitro_service client, string[] name)
    {
      base_responses baseResponses = (base_responses) null;
      if (name != null && name.Length > 0)
      {
        capolicy[] capolicyArray = new capolicy[name.Length];
        for (int index = 0; index < name.Length; ++index)
        {
          capolicyArray[index] = new capolicy();
          capolicyArray[index].name = name[index];
        }
        baseResponses = base_resource.delete_bulk_request(client, (base_resource[]) capolicyArray);
      }
      return baseResponses;
    }

    public static base_responses delete(nitro_service client, capolicy[] resources)
    {
      base_responses baseResponses = (base_responses) null;
      if (resources != null && resources.Length > 0)
      {
        capolicy[] capolicyArray = new capolicy[resources.Length];
        for (int index = 0; index < resources.Length; ++index)
        {
          capolicyArray[index] = new capolicy();
          capolicyArray[index].name = resources[index].name;
        }
        baseResponses = base_resource.delete_bulk_request(client, (base_resource[]) capolicyArray);
      }
      return baseResponses;
    }

    public static base_response update(nitro_service client, capolicy resource) => new capolicy()
    {
      name = resource.name,
      rule = resource.rule,
      action = resource.action,
      comment = resource.comment,
      logaction = resource.logaction,
      undefaction = resource.undefaction
    }.update_resource(client);

    public static base_responses update(nitro_service client, capolicy[] resources)
    {
      base_responses baseResponses = (base_responses) null;
      if (resources != null && resources.Length > 0)
      {
        capolicy[] capolicyArray = new capolicy[resources.Length];
        for (int index = 0; index < resources.Length; ++index)
        {
          capolicyArray[index] = new capolicy();
          capolicyArray[index].name = resources[index].name;
          capolicyArray[index].rule = resources[index].rule;
          capolicyArray[index].action = resources[index].action;
          capolicyArray[index].comment = resources[index].comment;
          capolicyArray[index].logaction = resources[index].logaction;
          capolicyArray[index].undefaction = resources[index].undefaction;
        }
        baseResponses = base_resource.update_bulk_request(client, (base_resource[]) capolicyArray);
      }
      return baseResponses;
    }

    public static base_response unset(
      nitro_service client,
      string name,
      string[] args)
    {
      return new capolicy() { name = name }.unset_resource(client, args);
    }

    public static base_response unset(
      nitro_service client,
      capolicy resource,
      string[] args)
    {
      return new capolicy() { name = resource.name }.unset_resource(client, args);
    }

    public static base_responses unset(
      nitro_service client,
      string[] name,
      string[] args)
    {
      base_responses baseResponses = (base_responses) null;
      if (name != null && name.Length > 0)
      {
        capolicy[] capolicyArray = new capolicy[name.Length];
        for (int index = 0; index < name.Length; ++index)
        {
          capolicyArray[index] = new capolicy();
          capolicyArray[index].name = name[index];
        }
        baseResponses = base_resource.unset_bulk_request(client, (base_resource[]) capolicyArray, args);
      }
      return baseResponses;
    }

    public static base_responses unset(
      nitro_service client,
      capolicy[] resources,
      string[] args)
    {
      base_responses baseResponses = (base_responses) null;
      if (resources != null && resources.Length > 0)
      {
        capolicy[] capolicyArray = new capolicy[resources.Length];
        for (int index = 0; index < resources.Length; ++index)
        {
          capolicyArray[index] = new capolicy();
          capolicyArray[index].name = resources[index].name;
        }
        baseResponses = base_resource.unset_bulk_request(client, (base_resource[]) capolicyArray, args);
      }
      return baseResponses;
    }

    public static base_response rename(
      nitro_service client,
      capolicy resource,
      string new_name)
    {
      return new capolicy()
      {
        name = resource.name,
        newname = new_name
      }.rename_resource(client);
    }

    public static base_response rename(
      nitro_service client,
      string name,
      string new_name)
    {
      return new capolicy()
      {
        name = name,
        newname = new_name
      }.rename_resource(client);
    }

    public static capolicy[] get(nitro_service service) => (capolicy[]) new capolicy().get_resources(service, (options) null);

    public static capolicy[] get(nitro_service service, options option) => (capolicy[]) new capolicy().get_resources(service, option);

    public static capolicy get(nitro_service service, string name) => (capolicy) new capolicy()
    {
      name = name
    }.get_resource(service);

    public static capolicy[] get(nitro_service service, string[] name)
    {
      if (name == null || name.Length <= 0)
        return (capolicy[]) null;
      capolicy[] capolicyArray1 = new capolicy[name.Length];
      capolicy[] capolicyArray2 = new capolicy[name.Length];
      for (int index = 0; index < name.Length; ++index)
      {
        capolicyArray2[index] = new capolicy();
        capolicyArray2[index].name = name[index];
        capolicyArray1[index] = (capolicy) capolicyArray2[index].get_resource(service);
      }
      return capolicyArray1;
    }

    public static capolicy[] get_filtered(nitro_service service, string filter)
    {
      capolicy capolicy = new capolicy();
      options option = new options();
      option.set_filter(filter);
      return (capolicy[]) capolicy.getfiltered(service, option);
    }

    public static capolicy[] get_filtered(nitro_service service, filtervalue[] filter)
    {
      capolicy capolicy = new capolicy();
      options option = new options();
      option.set_filter(filter);
      return (capolicy[]) capolicy.getfiltered(service, option);
    }

    public static uint count(nitro_service service)
    {
      capolicy capolicy = new capolicy();
      options option = new options();
      option.set_count(true);
      capolicy[] resources = (capolicy[]) capolicy.get_resources(service, option);
      return resources != null && resources.Length > 0 ? resources[0].__count.Value : 0U;
    }

    public static uint count_filtered(nitro_service service, string filter)
    {
      capolicy capolicy = new capolicy();
      options option = new options();
      option.set_count(true);
      option.set_filter(filter);
      capolicy[] capolicyArray = (capolicy[]) capolicy.getfiltered(service, option);
      return capolicyArray != null && capolicyArray.Length > 0 ? capolicyArray[0].__count.Value : 0U;
    }

    public static uint count_filtered(nitro_service service, filtervalue[] filter)
    {
      capolicy capolicy = new capolicy();
      options option = new options();
      option.set_count(true);
      option.set_filter(filter);
      capolicy[] capolicyArray = (capolicy[]) capolicy.getfiltered(service, option);
      return capolicyArray != null && capolicyArray.Length > 0 ? capolicyArray[0].__count.Value : 0U;
    }

    private class capolicy_response : base_response
    {
      public capolicy[] capolicy = (capolicy[]) null;
    }
  }
}
