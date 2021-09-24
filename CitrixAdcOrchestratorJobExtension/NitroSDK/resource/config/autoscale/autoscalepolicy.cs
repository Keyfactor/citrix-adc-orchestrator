// Decompiled with JetBrains decompiler
// Type: com.citrix.netscaler.nitro.resource.config.autoscale.autoscalepolicy
// Assembly: nitro, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 6CF5DDEF-E052-4F9D-953F-6644F8378A66


using com.citrix.netscaler.nitro.exception;
using com.citrix.netscaler.nitro.resource.Base;
using com.citrix.netscaler.nitro.service;
using com.citrix.netscaler.nitro.util;

namespace com.citrix.netscaler.nitro.resource.config.autoscale
{
  public class autoscalepolicy : base_resource
  {
    private string nameField = (string) null;
    private string ruleField = (string) null;
    private string actionField = (string) null;
    private string commentField = (string) null;
    private string logactionField = (string) null;
    private string newnameField = (string) null;
    private long? hitsField = new long?();
    private long? undefhitsField = new long?();
    private uint? priorityField = new uint?();
    private int? activepolicyField = new int?();
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

    public uint? priority
    {
      get => this.priorityField;
      private set => this.priorityField = value;
    }

    public int? activepolicy
    {
      get => this.activepolicyField;
      private set => this.activepolicyField = value;
    }

    internal override base_resource[] get_nitro_response(
      nitro_service service,
      string response)
    {
      autoscalepolicy.autoscalepolicy_response autoscalepolicyResponse = new autoscalepolicy.autoscalepolicy_response();
      autoscalepolicy.autoscalepolicy_response resource = (autoscalepolicy.autoscalepolicy_response) service.get_payload_formatter().string_to_resource(autoscalepolicyResponse.GetType(), response);
      if (resource.errorcode != 0)
      {
        if (resource.errorcode == 444)
          service.clear_session();
        if (resource.severity == null)
          throw new nitro_exception(resource.message, resource.errorcode);
        if (resource.severity.Equals("ERROR"))
          throw new nitro_exception(resource.message, resource.errorcode);
      }
      return (base_resource[]) resource.autoscalepolicy;
    }

    internal override string get_object_name() => this.name;

    public static base_response add(nitro_service client, autoscalepolicy resource) => new autoscalepolicy()
    {
      name = resource.name,
      rule = resource.rule,
      action = resource.action,
      comment = resource.comment,
      logaction = resource.logaction
    }.add_resource(client);

    public static base_responses add(
      nitro_service client,
      autoscalepolicy[] resources)
    {
      base_responses baseResponses = (base_responses) null;
      if (resources != null && resources.Length > 0)
      {
        autoscalepolicy[] autoscalepolicyArray = new autoscalepolicy[resources.Length];
        for (int index = 0; index < resources.Length; ++index)
        {
          autoscalepolicyArray[index] = new autoscalepolicy();
          autoscalepolicyArray[index].name = resources[index].name;
          autoscalepolicyArray[index].rule = resources[index].rule;
          autoscalepolicyArray[index].action = resources[index].action;
          autoscalepolicyArray[index].comment = resources[index].comment;
          autoscalepolicyArray[index].logaction = resources[index].logaction;
        }
        baseResponses = base_resource.add_bulk_request(client, (base_resource[]) autoscalepolicyArray);
      }
      return baseResponses;
    }

    public static base_response delete(nitro_service client, string name) => new autoscalepolicy()
    {
      name = name
    }.delete_resource(client);

    public static base_response delete(nitro_service client, autoscalepolicy resource) => new autoscalepolicy()
    {
      name = resource.name
    }.delete_resource(client);

    public static base_responses delete(nitro_service client, string[] name)
    {
      base_responses baseResponses = (base_responses) null;
      if (name != null && name.Length > 0)
      {
        autoscalepolicy[] autoscalepolicyArray = new autoscalepolicy[name.Length];
        for (int index = 0; index < name.Length; ++index)
        {
          autoscalepolicyArray[index] = new autoscalepolicy();
          autoscalepolicyArray[index].name = name[index];
        }
        baseResponses = base_resource.delete_bulk_request(client, (base_resource[]) autoscalepolicyArray);
      }
      return baseResponses;
    }

    public static base_responses delete(
      nitro_service client,
      autoscalepolicy[] resources)
    {
      base_responses baseResponses = (base_responses) null;
      if (resources != null && resources.Length > 0)
      {
        autoscalepolicy[] autoscalepolicyArray = new autoscalepolicy[resources.Length];
        for (int index = 0; index < resources.Length; ++index)
        {
          autoscalepolicyArray[index] = new autoscalepolicy();
          autoscalepolicyArray[index].name = resources[index].name;
        }
        baseResponses = base_resource.delete_bulk_request(client, (base_resource[]) autoscalepolicyArray);
      }
      return baseResponses;
    }

    public static base_response update(nitro_service client, autoscalepolicy resource) => new autoscalepolicy()
    {
      name = resource.name,
      rule = resource.rule,
      action = resource.action,
      comment = resource.comment,
      logaction = resource.logaction
    }.update_resource(client);

    public static base_responses update(
      nitro_service client,
      autoscalepolicy[] resources)
    {
      base_responses baseResponses = (base_responses) null;
      if (resources != null && resources.Length > 0)
      {
        autoscalepolicy[] autoscalepolicyArray = new autoscalepolicy[resources.Length];
        for (int index = 0; index < resources.Length; ++index)
        {
          autoscalepolicyArray[index] = new autoscalepolicy();
          autoscalepolicyArray[index].name = resources[index].name;
          autoscalepolicyArray[index].rule = resources[index].rule;
          autoscalepolicyArray[index].action = resources[index].action;
          autoscalepolicyArray[index].comment = resources[index].comment;
          autoscalepolicyArray[index].logaction = resources[index].logaction;
        }
        baseResponses = base_resource.update_bulk_request(client, (base_resource[]) autoscalepolicyArray);
      }
      return baseResponses;
    }

    public static base_response unset(
      nitro_service client,
      string name,
      string[] args)
    {
      return new autoscalepolicy() { name = name }.unset_resource(client, args);
    }

    public static base_response unset(
      nitro_service client,
      autoscalepolicy resource,
      string[] args)
    {
      return new autoscalepolicy()
      {
        name = resource.name,
        rule = resource.rule,
        action = resource.action,
        comment = resource.comment,
        logaction = resource.logaction
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
        autoscalepolicy[] autoscalepolicyArray = new autoscalepolicy[name.Length];
        for (int index = 0; index < name.Length; ++index)
        {
          autoscalepolicyArray[index] = new autoscalepolicy();
          autoscalepolicyArray[index].name = name[index];
        }
        baseResponses = base_resource.unset_bulk_request(client, (base_resource[]) autoscalepolicyArray, args);
      }
      return baseResponses;
    }

    public static base_responses unset(
      nitro_service client,
      autoscalepolicy[] resources,
      string[] args)
    {
      base_responses baseResponses = (base_responses) null;
      if (resources != null && resources.Length > 0)
      {
        autoscalepolicy[] autoscalepolicyArray = new autoscalepolicy[resources.Length];
        for (int index = 0; index < resources.Length; ++index)
        {
          autoscalepolicyArray[index] = new autoscalepolicy();
          autoscalepolicyArray[index].name = resources[index].name;
          autoscalepolicyArray[index].rule = resources[index].rule;
          autoscalepolicyArray[index].action = resources[index].action;
          autoscalepolicyArray[index].comment = resources[index].comment;
          autoscalepolicyArray[index].logaction = resources[index].logaction;
        }
        baseResponses = base_resource.unset_bulk_request(client, (base_resource[]) autoscalepolicyArray, args);
      }
      return baseResponses;
    }

    public static base_response rename(
      nitro_service client,
      autoscalepolicy resource,
      string new_name)
    {
      return new autoscalepolicy()
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
      return new autoscalepolicy()
      {
        name = name,
        newname = new_name
      }.rename_resource(client);
    }

    public static autoscalepolicy[] get(nitro_service service) => (autoscalepolicy[]) new autoscalepolicy().get_resources(service, (options) null);

    public static autoscalepolicy[] get(nitro_service service, options option) => (autoscalepolicy[]) new autoscalepolicy().get_resources(service, option);

    public static autoscalepolicy get(nitro_service service, string name) => (autoscalepolicy) new autoscalepolicy()
    {
      name = name
    }.get_resource(service);

    public static autoscalepolicy[] get(nitro_service service, string[] name)
    {
      if (name == null || name.Length <= 0)
        return (autoscalepolicy[]) null;
      autoscalepolicy[] autoscalepolicyArray1 = new autoscalepolicy[name.Length];
      autoscalepolicy[] autoscalepolicyArray2 = new autoscalepolicy[name.Length];
      for (int index = 0; index < name.Length; ++index)
      {
        autoscalepolicyArray2[index] = new autoscalepolicy();
        autoscalepolicyArray2[index].name = name[index];
        autoscalepolicyArray1[index] = (autoscalepolicy) autoscalepolicyArray2[index].get_resource(service);
      }
      return autoscalepolicyArray1;
    }

    public static autoscalepolicy[] get_filtered(
      nitro_service service,
      string filter)
    {
      autoscalepolicy autoscalepolicy = new autoscalepolicy();
      options option = new options();
      option.set_filter(filter);
      return (autoscalepolicy[]) autoscalepolicy.getfiltered(service, option);
    }

    public static autoscalepolicy[] get_filtered(
      nitro_service service,
      filtervalue[] filter)
    {
      autoscalepolicy autoscalepolicy = new autoscalepolicy();
      options option = new options();
      option.set_filter(filter);
      return (autoscalepolicy[]) autoscalepolicy.getfiltered(service, option);
    }

    public static uint count(nitro_service service)
    {
      autoscalepolicy autoscalepolicy = new autoscalepolicy();
      options option = new options();
      option.set_count(true);
      autoscalepolicy[] resources = (autoscalepolicy[]) autoscalepolicy.get_resources(service, option);
      return resources != null && resources.Length > 0 ? resources[0].__count.Value : 0U;
    }

    public static uint count_filtered(nitro_service service, string filter)
    {
      autoscalepolicy autoscalepolicy = new autoscalepolicy();
      options option = new options();
      option.set_count(true);
      option.set_filter(filter);
      autoscalepolicy[] autoscalepolicyArray = (autoscalepolicy[]) autoscalepolicy.getfiltered(service, option);
      return autoscalepolicyArray != null && autoscalepolicyArray.Length > 0 ? autoscalepolicyArray[0].__count.Value : 0U;
    }

    public static uint count_filtered(nitro_service service, filtervalue[] filter)
    {
      autoscalepolicy autoscalepolicy = new autoscalepolicy();
      options option = new options();
      option.set_count(true);
      option.set_filter(filter);
      autoscalepolicy[] autoscalepolicyArray = (autoscalepolicy[]) autoscalepolicy.getfiltered(service, option);
      return autoscalepolicyArray != null && autoscalepolicyArray.Length > 0 ? autoscalepolicyArray[0].__count.Value : 0U;
    }

    private class autoscalepolicy_response : base_response
    {
      public autoscalepolicy[] autoscalepolicy = (autoscalepolicy[]) null;
    }
  }
}
