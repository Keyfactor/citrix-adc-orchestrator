// Decompiled with JetBrains decompiler
// Type: com.citrix.netscaler.nitro.resource.config.spillover.spilloverpolicy
// Assembly: nitro, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 6CF5DDEF-E052-4F9D-953F-6644F8378A66


using com.citrix.netscaler.nitro.exception;
using com.citrix.netscaler.nitro.resource.Base;
using com.citrix.netscaler.nitro.service;
using com.citrix.netscaler.nitro.util;

namespace com.citrix.netscaler.nitro.resource.config.spillover
{
  public class spilloverpolicy : base_resource
  {
    private string nameField = (string) null;
    private string ruleField = (string) null;
    private string actionField = (string) null;
    private string commentField = (string) null;
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

    public string comment
    {
      get => this.commentField;
      set => this.commentField = value;
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
      spilloverpolicy.spilloverpolicy_response spilloverpolicyResponse = new spilloverpolicy.spilloverpolicy_response();
      spilloverpolicy.spilloverpolicy_response resource = (spilloverpolicy.spilloverpolicy_response) service.get_payload_formatter().string_to_resource(spilloverpolicyResponse.GetType(), response);
      if (resource.errorcode != 0)
      {
        if (resource.errorcode == 444)
          service.clear_session();
        if (resource.severity == null)
          throw new nitro_exception(resource.message, resource.errorcode);
        if (resource.severity.Equals("ERROR"))
          throw new nitro_exception(resource.message, resource.errorcode);
      }
      return (base_resource[]) resource.spilloverpolicy;
    }

    internal override string get_object_name() => this.name;

    public static base_response add(nitro_service client, spilloverpolicy resource) => new spilloverpolicy()
    {
      name = resource.name,
      rule = resource.rule,
      action = resource.action,
      comment = resource.comment
    }.add_resource(client);

    public static base_responses add(
      nitro_service client,
      spilloverpolicy[] resources)
    {
      base_responses baseResponses = (base_responses) null;
      if (resources != null && resources.Length > 0)
      {
        spilloverpolicy[] spilloverpolicyArray = new spilloverpolicy[resources.Length];
        for (int index = 0; index < resources.Length; ++index)
        {
          spilloverpolicyArray[index] = new spilloverpolicy();
          spilloverpolicyArray[index].name = resources[index].name;
          spilloverpolicyArray[index].rule = resources[index].rule;
          spilloverpolicyArray[index].action = resources[index].action;
          spilloverpolicyArray[index].comment = resources[index].comment;
        }
        baseResponses = base_resource.add_bulk_request(client, (base_resource[]) spilloverpolicyArray);
      }
      return baseResponses;
    }

    public static base_response delete(nitro_service client, string name) => new spilloverpolicy()
    {
      name = name
    }.delete_resource(client);

    public static base_response delete(nitro_service client, spilloverpolicy resource) => new spilloverpolicy()
    {
      name = resource.name
    }.delete_resource(client);

    public static base_responses delete(nitro_service client, string[] name)
    {
      base_responses baseResponses = (base_responses) null;
      if (name != null && name.Length > 0)
      {
        spilloverpolicy[] spilloverpolicyArray = new spilloverpolicy[name.Length];
        for (int index = 0; index < name.Length; ++index)
        {
          spilloverpolicyArray[index] = new spilloverpolicy();
          spilloverpolicyArray[index].name = name[index];
        }
        baseResponses = base_resource.delete_bulk_request(client, (base_resource[]) spilloverpolicyArray);
      }
      return baseResponses;
    }

    public static base_responses delete(
      nitro_service client,
      spilloverpolicy[] resources)
    {
      base_responses baseResponses = (base_responses) null;
      if (resources != null && resources.Length > 0)
      {
        spilloverpolicy[] spilloverpolicyArray = new spilloverpolicy[resources.Length];
        for (int index = 0; index < resources.Length; ++index)
        {
          spilloverpolicyArray[index] = new spilloverpolicy();
          spilloverpolicyArray[index].name = resources[index].name;
        }
        baseResponses = base_resource.delete_bulk_request(client, (base_resource[]) spilloverpolicyArray);
      }
      return baseResponses;
    }

    public static base_response update(nitro_service client, spilloverpolicy resource) => new spilloverpolicy()
    {
      name = resource.name,
      rule = resource.rule,
      action = resource.action,
      comment = resource.comment
    }.update_resource(client);

    public static base_responses update(
      nitro_service client,
      spilloverpolicy[] resources)
    {
      base_responses baseResponses = (base_responses) null;
      if (resources != null && resources.Length > 0)
      {
        spilloverpolicy[] spilloverpolicyArray = new spilloverpolicy[resources.Length];
        for (int index = 0; index < resources.Length; ++index)
        {
          spilloverpolicyArray[index] = new spilloverpolicy();
          spilloverpolicyArray[index].name = resources[index].name;
          spilloverpolicyArray[index].rule = resources[index].rule;
          spilloverpolicyArray[index].action = resources[index].action;
          spilloverpolicyArray[index].comment = resources[index].comment;
        }
        baseResponses = base_resource.update_bulk_request(client, (base_resource[]) spilloverpolicyArray);
      }
      return baseResponses;
    }

    public static base_response unset(
      nitro_service client,
      string name,
      string[] args)
    {
      return new spilloverpolicy() { name = name }.unset_resource(client, args);
    }

    public static base_response unset(
      nitro_service client,
      spilloverpolicy resource,
      string[] args)
    {
      return new spilloverpolicy() { name = resource.name }.unset_resource(client, args);
    }

    public static base_responses unset(
      nitro_service client,
      string[] name,
      string[] args)
    {
      base_responses baseResponses = (base_responses) null;
      if (name != null && name.Length > 0)
      {
        spilloverpolicy[] spilloverpolicyArray = new spilloverpolicy[name.Length];
        for (int index = 0; index < name.Length; ++index)
        {
          spilloverpolicyArray[index] = new spilloverpolicy();
          spilloverpolicyArray[index].name = name[index];
        }
        baseResponses = base_resource.unset_bulk_request(client, (base_resource[]) spilloverpolicyArray, args);
      }
      return baseResponses;
    }

    public static base_responses unset(
      nitro_service client,
      spilloverpolicy[] resources,
      string[] args)
    {
      base_responses baseResponses = (base_responses) null;
      if (resources != null && resources.Length > 0)
      {
        spilloverpolicy[] spilloverpolicyArray = new spilloverpolicy[resources.Length];
        for (int index = 0; index < resources.Length; ++index)
        {
          spilloverpolicyArray[index] = new spilloverpolicy();
          spilloverpolicyArray[index].name = resources[index].name;
        }
        baseResponses = base_resource.unset_bulk_request(client, (base_resource[]) spilloverpolicyArray, args);
      }
      return baseResponses;
    }

    public static base_response rename(
      nitro_service client,
      spilloverpolicy resource,
      string new_name)
    {
      return new spilloverpolicy()
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
      return new spilloverpolicy()
      {
        name = name,
        newname = new_name
      }.rename_resource(client);
    }

    public static spilloverpolicy[] get(nitro_service service) => (spilloverpolicy[]) new spilloverpolicy().get_resources(service, (options) null);

    public static spilloverpolicy[] get(nitro_service service, options option) => (spilloverpolicy[]) new spilloverpolicy().get_resources(service, option);

    public static spilloverpolicy get(nitro_service service, string name) => (spilloverpolicy) new spilloverpolicy()
    {
      name = name
    }.get_resource(service);

    public static spilloverpolicy[] get(nitro_service service, string[] name)
    {
      if (name == null || name.Length <= 0)
        return (spilloverpolicy[]) null;
      spilloverpolicy[] spilloverpolicyArray1 = new spilloverpolicy[name.Length];
      spilloverpolicy[] spilloverpolicyArray2 = new spilloverpolicy[name.Length];
      for (int index = 0; index < name.Length; ++index)
      {
        spilloverpolicyArray2[index] = new spilloverpolicy();
        spilloverpolicyArray2[index].name = name[index];
        spilloverpolicyArray1[index] = (spilloverpolicy) spilloverpolicyArray2[index].get_resource(service);
      }
      return spilloverpolicyArray1;
    }

    public static spilloverpolicy[] get_filtered(
      nitro_service service,
      string filter)
    {
      spilloverpolicy spilloverpolicy = new spilloverpolicy();
      options option = new options();
      option.set_filter(filter);
      return (spilloverpolicy[]) spilloverpolicy.getfiltered(service, option);
    }

    public static spilloverpolicy[] get_filtered(
      nitro_service service,
      filtervalue[] filter)
    {
      spilloverpolicy spilloverpolicy = new spilloverpolicy();
      options option = new options();
      option.set_filter(filter);
      return (spilloverpolicy[]) spilloverpolicy.getfiltered(service, option);
    }

    public static uint count(nitro_service service)
    {
      spilloverpolicy spilloverpolicy = new spilloverpolicy();
      options option = new options();
      option.set_count(true);
      spilloverpolicy[] resources = (spilloverpolicy[]) spilloverpolicy.get_resources(service, option);
      return resources != null && resources.Length > 0 ? resources[0].__count.Value : 0U;
    }

    public static uint count_filtered(nitro_service service, string filter)
    {
      spilloverpolicy spilloverpolicy = new spilloverpolicy();
      options option = new options();
      option.set_count(true);
      option.set_filter(filter);
      spilloverpolicy[] spilloverpolicyArray = (spilloverpolicy[]) spilloverpolicy.getfiltered(service, option);
      return spilloverpolicyArray != null && spilloverpolicyArray.Length > 0 ? spilloverpolicyArray[0].__count.Value : 0U;
    }

    public static uint count_filtered(nitro_service service, filtervalue[] filter)
    {
      spilloverpolicy spilloverpolicy = new spilloverpolicy();
      options option = new options();
      option.set_count(true);
      option.set_filter(filter);
      spilloverpolicy[] spilloverpolicyArray = (spilloverpolicy[]) spilloverpolicy.getfiltered(service, option);
      return spilloverpolicyArray != null && spilloverpolicyArray.Length > 0 ? spilloverpolicyArray[0].__count.Value : 0U;
    }

    private class spilloverpolicy_response : base_response
    {
      public spilloverpolicy[] spilloverpolicy = (spilloverpolicy[]) null;
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
