// Decompiled with JetBrains decompiler
// Type: com.citrix.netscaler.nitro.resource.config.responder.responderpolicy
// Assembly: nitro, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 6CF5DDEF-E052-4F9D-953F-6644F8378A66


using com.citrix.netscaler.nitro.exception;
using com.citrix.netscaler.nitro.resource.Base;
using com.citrix.netscaler.nitro.service;
using com.citrix.netscaler.nitro.util;

namespace com.citrix.netscaler.nitro.resource.config.responder
{
  public class responderpolicy : base_resource
  {
    private string nameField = (string) null;
    private string ruleField = (string) null;
    private string actionField = (string) null;
    private string undefactionField = (string) null;
    private string commentField = (string) null;
    private string logactionField = (string) null;
    private string appflowactionField = (string) null;
    private string newnameField = (string) null;
    private long? hitsField = new long?();
    private long? undefhitsField = new long?();
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

    public string appflowaction
    {
      get => this.appflowactionField;
      set => this.appflowactionField = value;
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

    public string[] builtin
    {
      get => this.builtinField;
      private set => this.builtinField = value;
    }

    internal override base_resource[] get_nitro_response(
      nitro_service service,
      string response)
    {
      responderpolicy.responderpolicy_response responderpolicyResponse = new responderpolicy.responderpolicy_response();
      responderpolicy.responderpolicy_response resource = (responderpolicy.responderpolicy_response) service.get_payload_formatter().string_to_resource(responderpolicyResponse.GetType(), response);
      if (resource.errorcode != 0)
      {
        if (resource.errorcode == 444)
          service.clear_session();
        if (resource.severity == null)
          throw new nitro_exception(resource.message, resource.errorcode);
        if (resource.severity.Equals("ERROR"))
          throw new nitro_exception(resource.message, resource.errorcode);
      }
      return (base_resource[]) resource.responderpolicy;
    }

    internal override string get_object_name() => this.name;

    public static base_response add(nitro_service client, responderpolicy resource) => new responderpolicy()
    {
      name = resource.name,
      rule = resource.rule,
      action = resource.action,
      undefaction = resource.undefaction,
      comment = resource.comment,
      logaction = resource.logaction,
      appflowaction = resource.appflowaction
    }.add_resource(client);

    public static base_responses add(
      nitro_service client,
      responderpolicy[] resources)
    {
      base_responses baseResponses = (base_responses) null;
      if (resources != null && resources.Length > 0)
      {
        responderpolicy[] responderpolicyArray = new responderpolicy[resources.Length];
        for (int index = 0; index < resources.Length; ++index)
        {
          responderpolicyArray[index] = new responderpolicy();
          responderpolicyArray[index].name = resources[index].name;
          responderpolicyArray[index].rule = resources[index].rule;
          responderpolicyArray[index].action = resources[index].action;
          responderpolicyArray[index].undefaction = resources[index].undefaction;
          responderpolicyArray[index].comment = resources[index].comment;
          responderpolicyArray[index].logaction = resources[index].logaction;
          responderpolicyArray[index].appflowaction = resources[index].appflowaction;
        }
        baseResponses = base_resource.add_bulk_request(client, (base_resource[]) responderpolicyArray);
      }
      return baseResponses;
    }

    public static base_response delete(nitro_service client, string name) => new responderpolicy()
    {
      name = name
    }.delete_resource(client);

    public static base_response delete(nitro_service client, responderpolicy resource) => new responderpolicy()
    {
      name = resource.name
    }.delete_resource(client);

    public static base_responses delete(nitro_service client, string[] name)
    {
      base_responses baseResponses = (base_responses) null;
      if (name != null && name.Length > 0)
      {
        responderpolicy[] responderpolicyArray = new responderpolicy[name.Length];
        for (int index = 0; index < name.Length; ++index)
        {
          responderpolicyArray[index] = new responderpolicy();
          responderpolicyArray[index].name = name[index];
        }
        baseResponses = base_resource.delete_bulk_request(client, (base_resource[]) responderpolicyArray);
      }
      return baseResponses;
    }

    public static base_responses delete(
      nitro_service client,
      responderpolicy[] resources)
    {
      base_responses baseResponses = (base_responses) null;
      if (resources != null && resources.Length > 0)
      {
        responderpolicy[] responderpolicyArray = new responderpolicy[resources.Length];
        for (int index = 0; index < resources.Length; ++index)
        {
          responderpolicyArray[index] = new responderpolicy();
          responderpolicyArray[index].name = resources[index].name;
        }
        baseResponses = base_resource.delete_bulk_request(client, (base_resource[]) responderpolicyArray);
      }
      return baseResponses;
    }

    public static base_response update(nitro_service client, responderpolicy resource) => new responderpolicy()
    {
      name = resource.name,
      rule = resource.rule,
      action = resource.action,
      undefaction = resource.undefaction,
      comment = resource.comment,
      logaction = resource.logaction,
      appflowaction = resource.appflowaction
    }.update_resource(client);

    public static base_responses update(
      nitro_service client,
      responderpolicy[] resources)
    {
      base_responses baseResponses = (base_responses) null;
      if (resources != null && resources.Length > 0)
      {
        responderpolicy[] responderpolicyArray = new responderpolicy[resources.Length];
        for (int index = 0; index < resources.Length; ++index)
        {
          responderpolicyArray[index] = new responderpolicy();
          responderpolicyArray[index].name = resources[index].name;
          responderpolicyArray[index].rule = resources[index].rule;
          responderpolicyArray[index].action = resources[index].action;
          responderpolicyArray[index].undefaction = resources[index].undefaction;
          responderpolicyArray[index].comment = resources[index].comment;
          responderpolicyArray[index].logaction = resources[index].logaction;
          responderpolicyArray[index].appflowaction = resources[index].appflowaction;
        }
        baseResponses = base_resource.update_bulk_request(client, (base_resource[]) responderpolicyArray);
      }
      return baseResponses;
    }

    public static base_response unset(
      nitro_service client,
      string name,
      string[] args)
    {
      return new responderpolicy() { name = name }.unset_resource(client, args);
    }

    public static base_response unset(
      nitro_service client,
      responderpolicy resource,
      string[] args)
    {
      return new responderpolicy() { name = resource.name }.unset_resource(client, args);
    }

    public static base_responses unset(
      nitro_service client,
      string[] name,
      string[] args)
    {
      base_responses baseResponses = (base_responses) null;
      if (name != null && name.Length > 0)
      {
        responderpolicy[] responderpolicyArray = new responderpolicy[name.Length];
        for (int index = 0; index < name.Length; ++index)
        {
          responderpolicyArray[index] = new responderpolicy();
          responderpolicyArray[index].name = name[index];
        }
        baseResponses = base_resource.unset_bulk_request(client, (base_resource[]) responderpolicyArray, args);
      }
      return baseResponses;
    }

    public static base_responses unset(
      nitro_service client,
      responderpolicy[] resources,
      string[] args)
    {
      base_responses baseResponses = (base_responses) null;
      if (resources != null && resources.Length > 0)
      {
        responderpolicy[] responderpolicyArray = new responderpolicy[resources.Length];
        for (int index = 0; index < resources.Length; ++index)
        {
          responderpolicyArray[index] = new responderpolicy();
          responderpolicyArray[index].name = resources[index].name;
        }
        baseResponses = base_resource.unset_bulk_request(client, (base_resource[]) responderpolicyArray, args);
      }
      return baseResponses;
    }

    public static base_response rename(
      nitro_service client,
      responderpolicy resource,
      string new_name)
    {
      return new responderpolicy()
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
      return new responderpolicy()
      {
        name = name,
        newname = new_name
      }.rename_resource(client);
    }

    public static responderpolicy[] get(nitro_service service) => (responderpolicy[]) new responderpolicy().get_resources(service, (options) null);

    public static responderpolicy[] get(nitro_service service, options option) => (responderpolicy[]) new responderpolicy().get_resources(service, option);

    public static responderpolicy get(nitro_service service, string name) => (responderpolicy) new responderpolicy()
    {
      name = name
    }.get_resource(service);

    public static responderpolicy[] get(nitro_service service, string[] name)
    {
      if (name == null || name.Length <= 0)
        return (responderpolicy[]) null;
      responderpolicy[] responderpolicyArray1 = new responderpolicy[name.Length];
      responderpolicy[] responderpolicyArray2 = new responderpolicy[name.Length];
      for (int index = 0; index < name.Length; ++index)
      {
        responderpolicyArray2[index] = new responderpolicy();
        responderpolicyArray2[index].name = name[index];
        responderpolicyArray1[index] = (responderpolicy) responderpolicyArray2[index].get_resource(service);
      }
      return responderpolicyArray1;
    }

    public static responderpolicy[] get_filtered(
      nitro_service service,
      string filter)
    {
      responderpolicy responderpolicy = new responderpolicy();
      options option = new options();
      option.set_filter(filter);
      return (responderpolicy[]) responderpolicy.getfiltered(service, option);
    }

    public static responderpolicy[] get_filtered(
      nitro_service service,
      filtervalue[] filter)
    {
      responderpolicy responderpolicy = new responderpolicy();
      options option = new options();
      option.set_filter(filter);
      return (responderpolicy[]) responderpolicy.getfiltered(service, option);
    }

    public static uint count(nitro_service service)
    {
      responderpolicy responderpolicy = new responderpolicy();
      options option = new options();
      option.set_count(true);
      responderpolicy[] resources = (responderpolicy[]) responderpolicy.get_resources(service, option);
      return resources != null && resources.Length > 0 ? resources[0].__count.Value : 0U;
    }

    public static uint count_filtered(nitro_service service, string filter)
    {
      responderpolicy responderpolicy = new responderpolicy();
      options option = new options();
      option.set_count(true);
      option.set_filter(filter);
      responderpolicy[] responderpolicyArray = (responderpolicy[]) responderpolicy.getfiltered(service, option);
      return responderpolicyArray != null && responderpolicyArray.Length > 0 ? responderpolicyArray[0].__count.Value : 0U;
    }

    public static uint count_filtered(nitro_service service, filtervalue[] filter)
    {
      responderpolicy responderpolicy = new responderpolicy();
      options option = new options();
      option.set_count(true);
      option.set_filter(filter);
      responderpolicy[] responderpolicyArray = (responderpolicy[]) responderpolicy.getfiltered(service, option);
      return responderpolicyArray != null && responderpolicyArray.Length > 0 ? responderpolicyArray[0].__count.Value : 0U;
    }

    private class responderpolicy_response : base_response
    {
      public responderpolicy[] responderpolicy = (responderpolicy[]) null;
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
