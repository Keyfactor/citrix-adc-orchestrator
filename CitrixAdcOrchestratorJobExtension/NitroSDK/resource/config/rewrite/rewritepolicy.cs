// Decompiled with JetBrains decompiler
// Type: com.citrix.netscaler.nitro.resource.config.rewrite.rewritepolicy
// Assembly: nitro, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 6CF5DDEF-E052-4F9D-953F-6644F8378A66


using com.citrix.netscaler.nitro.exception;
using com.citrix.netscaler.nitro.resource.Base;
using com.citrix.netscaler.nitro.service;
using com.citrix.netscaler.nitro.util;

namespace com.citrix.netscaler.nitro.resource.config.rewrite
{
  public class rewritepolicy : base_resource
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
    private string descriptionField = (string) null;
    private bool? isdefaultField = new bool?();
    private string[] builtinField = (string[]) null;
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

    public string description
    {
      get => this.descriptionField;
      private set => this.descriptionField = value;
    }

    public bool? isdefault
    {
      get => this.isdefaultField;
      private set => this.isdefaultField = value;
    }

    public string[] builtin
    {
      get => this.builtinField;
      private set => this.builtinField = value;
    }

    internal override base_resource[] get_nitro_response(
      nitro_service service,
      string response)
    {
      rewritepolicy.rewritepolicy_response rewritepolicyResponse = new rewritepolicy.rewritepolicy_response();
      rewritepolicy.rewritepolicy_response resource = (rewritepolicy.rewritepolicy_response) service.get_payload_formatter().string_to_resource(rewritepolicyResponse.GetType(), response);
      if (resource.errorcode != 0)
      {
        if (resource.errorcode == 444)
          service.clear_session();
        if (resource.severity == null)
          throw new nitro_exception(resource.message, resource.errorcode);
        if (resource.severity.Equals("ERROR"))
          throw new nitro_exception(resource.message, resource.errorcode);
      }
      return (base_resource[]) resource.rewritepolicy;
    }

    internal override string get_object_name() => this.name;

    public static base_response add(nitro_service client, rewritepolicy resource) => new rewritepolicy()
    {
      name = resource.name,
      rule = resource.rule,
      action = resource.action,
      undefaction = resource.undefaction,
      comment = resource.comment,
      logaction = resource.logaction
    }.add_resource(client);

    public static base_responses add(nitro_service client, rewritepolicy[] resources)
    {
      base_responses baseResponses = (base_responses) null;
      if (resources != null && resources.Length > 0)
      {
        rewritepolicy[] rewritepolicyArray = new rewritepolicy[resources.Length];
        for (int index = 0; index < resources.Length; ++index)
        {
          rewritepolicyArray[index] = new rewritepolicy();
          rewritepolicyArray[index].name = resources[index].name;
          rewritepolicyArray[index].rule = resources[index].rule;
          rewritepolicyArray[index].action = resources[index].action;
          rewritepolicyArray[index].undefaction = resources[index].undefaction;
          rewritepolicyArray[index].comment = resources[index].comment;
          rewritepolicyArray[index].logaction = resources[index].logaction;
        }
        baseResponses = base_resource.add_bulk_request(client, (base_resource[]) rewritepolicyArray);
      }
      return baseResponses;
    }

    public static base_response delete(nitro_service client, string name) => new rewritepolicy()
    {
      name = name
    }.delete_resource(client);

    public static base_response delete(nitro_service client, rewritepolicy resource) => new rewritepolicy()
    {
      name = resource.name
    }.delete_resource(client);

    public static base_responses delete(nitro_service client, string[] name)
    {
      base_responses baseResponses = (base_responses) null;
      if (name != null && name.Length > 0)
      {
        rewritepolicy[] rewritepolicyArray = new rewritepolicy[name.Length];
        for (int index = 0; index < name.Length; ++index)
        {
          rewritepolicyArray[index] = new rewritepolicy();
          rewritepolicyArray[index].name = name[index];
        }
        baseResponses = base_resource.delete_bulk_request(client, (base_resource[]) rewritepolicyArray);
      }
      return baseResponses;
    }

    public static base_responses delete(
      nitro_service client,
      rewritepolicy[] resources)
    {
      base_responses baseResponses = (base_responses) null;
      if (resources != null && resources.Length > 0)
      {
        rewritepolicy[] rewritepolicyArray = new rewritepolicy[resources.Length];
        for (int index = 0; index < resources.Length; ++index)
        {
          rewritepolicyArray[index] = new rewritepolicy();
          rewritepolicyArray[index].name = resources[index].name;
        }
        baseResponses = base_resource.delete_bulk_request(client, (base_resource[]) rewritepolicyArray);
      }
      return baseResponses;
    }

    public static base_response update(nitro_service client, rewritepolicy resource) => new rewritepolicy()
    {
      name = resource.name,
      rule = resource.rule,
      action = resource.action,
      undefaction = resource.undefaction,
      comment = resource.comment,
      logaction = resource.logaction
    }.update_resource(client);

    public static base_responses update(
      nitro_service client,
      rewritepolicy[] resources)
    {
      base_responses baseResponses = (base_responses) null;
      if (resources != null && resources.Length > 0)
      {
        rewritepolicy[] rewritepolicyArray = new rewritepolicy[resources.Length];
        for (int index = 0; index < resources.Length; ++index)
        {
          rewritepolicyArray[index] = new rewritepolicy();
          rewritepolicyArray[index].name = resources[index].name;
          rewritepolicyArray[index].rule = resources[index].rule;
          rewritepolicyArray[index].action = resources[index].action;
          rewritepolicyArray[index].undefaction = resources[index].undefaction;
          rewritepolicyArray[index].comment = resources[index].comment;
          rewritepolicyArray[index].logaction = resources[index].logaction;
        }
        baseResponses = base_resource.update_bulk_request(client, (base_resource[]) rewritepolicyArray);
      }
      return baseResponses;
    }

    public static base_response unset(
      nitro_service client,
      string name,
      string[] args)
    {
      return new rewritepolicy() { name = name }.unset_resource(client, args);
    }

    public static base_response unset(
      nitro_service client,
      rewritepolicy resource,
      string[] args)
    {
      return new rewritepolicy() { name = resource.name }.unset_resource(client, args);
    }

    public static base_responses unset(
      nitro_service client,
      string[] name,
      string[] args)
    {
      base_responses baseResponses = (base_responses) null;
      if (name != null && name.Length > 0)
      {
        rewritepolicy[] rewritepolicyArray = new rewritepolicy[name.Length];
        for (int index = 0; index < name.Length; ++index)
        {
          rewritepolicyArray[index] = new rewritepolicy();
          rewritepolicyArray[index].name = name[index];
        }
        baseResponses = base_resource.unset_bulk_request(client, (base_resource[]) rewritepolicyArray, args);
      }
      return baseResponses;
    }

    public static base_responses unset(
      nitro_service client,
      rewritepolicy[] resources,
      string[] args)
    {
      base_responses baseResponses = (base_responses) null;
      if (resources != null && resources.Length > 0)
      {
        rewritepolicy[] rewritepolicyArray = new rewritepolicy[resources.Length];
        for (int index = 0; index < resources.Length; ++index)
        {
          rewritepolicyArray[index] = new rewritepolicy();
          rewritepolicyArray[index].name = resources[index].name;
        }
        baseResponses = base_resource.unset_bulk_request(client, (base_resource[]) rewritepolicyArray, args);
      }
      return baseResponses;
    }

    public static base_response rename(
      nitro_service client,
      rewritepolicy resource,
      string new_name)
    {
      return new rewritepolicy()
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
      return new rewritepolicy()
      {
        name = name,
        newname = new_name
      }.rename_resource(client);
    }

    public static rewritepolicy[] get(nitro_service service) => (rewritepolicy[]) new rewritepolicy().get_resources(service, (options) null);

    public static rewritepolicy[] get(nitro_service service, options option) => (rewritepolicy[]) new rewritepolicy().get_resources(service, option);

    public static rewritepolicy get(nitro_service service, string name) => (rewritepolicy) new rewritepolicy()
    {
      name = name
    }.get_resource(service);

    public static rewritepolicy[] get(nitro_service service, string[] name)
    {
      if (name == null || name.Length <= 0)
        return (rewritepolicy[]) null;
      rewritepolicy[] rewritepolicyArray1 = new rewritepolicy[name.Length];
      rewritepolicy[] rewritepolicyArray2 = new rewritepolicy[name.Length];
      for (int index = 0; index < name.Length; ++index)
      {
        rewritepolicyArray2[index] = new rewritepolicy();
        rewritepolicyArray2[index].name = name[index];
        rewritepolicyArray1[index] = (rewritepolicy) rewritepolicyArray2[index].get_resource(service);
      }
      return rewritepolicyArray1;
    }

    public static rewritepolicy[] get_filtered(nitro_service service, string filter)
    {
      rewritepolicy rewritepolicy = new rewritepolicy();
      options option = new options();
      option.set_filter(filter);
      return (rewritepolicy[]) rewritepolicy.getfiltered(service, option);
    }

    public static rewritepolicy[] get_filtered(
      nitro_service service,
      filtervalue[] filter)
    {
      rewritepolicy rewritepolicy = new rewritepolicy();
      options option = new options();
      option.set_filter(filter);
      return (rewritepolicy[]) rewritepolicy.getfiltered(service, option);
    }

    public static uint count(nitro_service service)
    {
      rewritepolicy rewritepolicy = new rewritepolicy();
      options option = new options();
      option.set_count(true);
      rewritepolicy[] resources = (rewritepolicy[]) rewritepolicy.get_resources(service, option);
      return resources != null && resources.Length > 0 ? resources[0].__count.Value : 0U;
    }

    public static uint count_filtered(nitro_service service, string filter)
    {
      rewritepolicy rewritepolicy = new rewritepolicy();
      options option = new options();
      option.set_count(true);
      option.set_filter(filter);
      rewritepolicy[] rewritepolicyArray = (rewritepolicy[]) rewritepolicy.getfiltered(service, option);
      return rewritepolicyArray != null && rewritepolicyArray.Length > 0 ? rewritepolicyArray[0].__count.Value : 0U;
    }

    public static uint count_filtered(nitro_service service, filtervalue[] filter)
    {
      rewritepolicy rewritepolicy = new rewritepolicy();
      options option = new options();
      option.set_count(true);
      option.set_filter(filter);
      rewritepolicy[] rewritepolicyArray = (rewritepolicy[]) rewritepolicy.getfiltered(service, option);
      return rewritepolicyArray != null && rewritepolicyArray.Length > 0 ? rewritepolicyArray[0].__count.Value : 0U;
    }

    private class rewritepolicy_response : base_response
    {
      public rewritepolicy[] rewritepolicy = (rewritepolicy[]) null;
    }

    public static class builtinEnum
    {
      public const string MODIFIABLE = "MODIFIABLE";
      public const string DELETABLE = "DELETABLE";
      public const string IMMUTABLE = "IMMUTABLE";
      public const string PARTITION_ALL = "PARTITION_ALL";
    }
  }
}
