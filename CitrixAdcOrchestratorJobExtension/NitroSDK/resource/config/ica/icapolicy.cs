// Decompiled with JetBrains decompiler
// Type: com.citrix.netscaler.nitro.resource.config.ica.icapolicy
// Assembly: nitro, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 6CF5DDEF-E052-4F9D-953F-6644F8378A66


using com.citrix.netscaler.nitro.exception;
using com.citrix.netscaler.nitro.resource.Base;
using com.citrix.netscaler.nitro.service;
using com.citrix.netscaler.nitro.util;

namespace com.citrix.netscaler.nitro.resource.config.ica
{
  public class icapolicy : base_resource
  {
    private string nameField = (string) null;
    private string ruleField = (string) null;
    private string actionField = (string) null;
    private string commentField = (string) null;
    private string logactionField = (string) null;
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

    public string[] builtin
    {
      get => this.builtinField;
      private set => this.builtinField = value;
    }

    internal override base_resource[] get_nitro_response(
      nitro_service service,
      string response)
    {
      icapolicy.icapolicy_response icapolicyResponse = new icapolicy.icapolicy_response();
      icapolicy.icapolicy_response resource = (icapolicy.icapolicy_response) service.get_payload_formatter().string_to_resource(icapolicyResponse.GetType(), response);
      if (resource.errorcode != 0)
      {
        if (resource.errorcode == 444)
          service.clear_session();
        if (resource.severity == null)
          throw new nitro_exception(resource.message, resource.errorcode);
        if (resource.severity.Equals("ERROR"))
          throw new nitro_exception(resource.message, resource.errorcode);
      }
      return (base_resource[]) resource.icapolicy;
    }

    internal override string get_object_name() => this.name;

    public static base_response add(nitro_service client, icapolicy resource) => new icapolicy()
    {
      name = resource.name,
      rule = resource.rule,
      action = resource.action,
      comment = resource.comment,
      logaction = resource.logaction
    }.add_resource(client);

    public static base_responses add(nitro_service client, icapolicy[] resources)
    {
      base_responses baseResponses = (base_responses) null;
      if (resources != null && resources.Length > 0)
      {
        icapolicy[] icapolicyArray = new icapolicy[resources.Length];
        for (int index = 0; index < resources.Length; ++index)
        {
          icapolicyArray[index] = new icapolicy();
          icapolicyArray[index].name = resources[index].name;
          icapolicyArray[index].rule = resources[index].rule;
          icapolicyArray[index].action = resources[index].action;
          icapolicyArray[index].comment = resources[index].comment;
          icapolicyArray[index].logaction = resources[index].logaction;
        }
        baseResponses = base_resource.add_bulk_request(client, (base_resource[]) icapolicyArray);
      }
      return baseResponses;
    }

    public static base_response delete(nitro_service client, string name) => new icapolicy()
    {
      name = name
    }.delete_resource(client);

    public static base_response delete(nitro_service client, icapolicy resource) => new icapolicy()
    {
      name = resource.name
    }.delete_resource(client);

    public static base_responses delete(nitro_service client, string[] name)
    {
      base_responses baseResponses = (base_responses) null;
      if (name != null && name.Length > 0)
      {
        icapolicy[] icapolicyArray = new icapolicy[name.Length];
        for (int index = 0; index < name.Length; ++index)
        {
          icapolicyArray[index] = new icapolicy();
          icapolicyArray[index].name = name[index];
        }
        baseResponses = base_resource.delete_bulk_request(client, (base_resource[]) icapolicyArray);
      }
      return baseResponses;
    }

    public static base_responses delete(nitro_service client, icapolicy[] resources)
    {
      base_responses baseResponses = (base_responses) null;
      if (resources != null && resources.Length > 0)
      {
        icapolicy[] icapolicyArray = new icapolicy[resources.Length];
        for (int index = 0; index < resources.Length; ++index)
        {
          icapolicyArray[index] = new icapolicy();
          icapolicyArray[index].name = resources[index].name;
        }
        baseResponses = base_resource.delete_bulk_request(client, (base_resource[]) icapolicyArray);
      }
      return baseResponses;
    }

    public static base_response update(nitro_service client, icapolicy resource) => new icapolicy()
    {
      name = resource.name,
      rule = resource.rule,
      action = resource.action,
      comment = resource.comment,
      logaction = resource.logaction
    }.update_resource(client);

    public static base_responses update(nitro_service client, icapolicy[] resources)
    {
      base_responses baseResponses = (base_responses) null;
      if (resources != null && resources.Length > 0)
      {
        icapolicy[] icapolicyArray = new icapolicy[resources.Length];
        for (int index = 0; index < resources.Length; ++index)
        {
          icapolicyArray[index] = new icapolicy();
          icapolicyArray[index].name = resources[index].name;
          icapolicyArray[index].rule = resources[index].rule;
          icapolicyArray[index].action = resources[index].action;
          icapolicyArray[index].comment = resources[index].comment;
          icapolicyArray[index].logaction = resources[index].logaction;
        }
        baseResponses = base_resource.update_bulk_request(client, (base_resource[]) icapolicyArray);
      }
      return baseResponses;
    }

    public static base_response unset(
      nitro_service client,
      string name,
      string[] args)
    {
      return new icapolicy() { name = name }.unset_resource(client, args);
    }

    public static base_response unset(
      nitro_service client,
      icapolicy resource,
      string[] args)
    {
      return new icapolicy() { name = resource.name }.unset_resource(client, args);
    }

    public static base_responses unset(
      nitro_service client,
      string[] name,
      string[] args)
    {
      base_responses baseResponses = (base_responses) null;
      if (name != null && name.Length > 0)
      {
        icapolicy[] icapolicyArray = new icapolicy[name.Length];
        for (int index = 0; index < name.Length; ++index)
        {
          icapolicyArray[index] = new icapolicy();
          icapolicyArray[index].name = name[index];
        }
        baseResponses = base_resource.unset_bulk_request(client, (base_resource[]) icapolicyArray, args);
      }
      return baseResponses;
    }

    public static base_responses unset(
      nitro_service client,
      icapolicy[] resources,
      string[] args)
    {
      base_responses baseResponses = (base_responses) null;
      if (resources != null && resources.Length > 0)
      {
        icapolicy[] icapolicyArray = new icapolicy[resources.Length];
        for (int index = 0; index < resources.Length; ++index)
        {
          icapolicyArray[index] = new icapolicy();
          icapolicyArray[index].name = resources[index].name;
        }
        baseResponses = base_resource.unset_bulk_request(client, (base_resource[]) icapolicyArray, args);
      }
      return baseResponses;
    }

    public static base_response rename(
      nitro_service client,
      icapolicy resource,
      string new_name)
    {
      return new icapolicy()
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
      return new icapolicy()
      {
        name = name,
        newname = new_name
      }.rename_resource(client);
    }

    public static icapolicy[] get(nitro_service service) => (icapolicy[]) new icapolicy().get_resources(service, (options) null);

    public static icapolicy[] get(nitro_service service, options option) => (icapolicy[]) new icapolicy().get_resources(service, option);

    public static icapolicy get(nitro_service service, string name) => (icapolicy) new icapolicy()
    {
      name = name
    }.get_resource(service);

    public static icapolicy[] get(nitro_service service, string[] name)
    {
      if (name == null || name.Length <= 0)
        return (icapolicy[]) null;
      icapolicy[] icapolicyArray1 = new icapolicy[name.Length];
      icapolicy[] icapolicyArray2 = new icapolicy[name.Length];
      for (int index = 0; index < name.Length; ++index)
      {
        icapolicyArray2[index] = new icapolicy();
        icapolicyArray2[index].name = name[index];
        icapolicyArray1[index] = (icapolicy) icapolicyArray2[index].get_resource(service);
      }
      return icapolicyArray1;
    }

    public static icapolicy[] get_filtered(nitro_service service, string filter)
    {
      icapolicy icapolicy = new icapolicy();
      options option = new options();
      option.set_filter(filter);
      return (icapolicy[]) icapolicy.getfiltered(service, option);
    }

    public static icapolicy[] get_filtered(nitro_service service, filtervalue[] filter)
    {
      icapolicy icapolicy = new icapolicy();
      options option = new options();
      option.set_filter(filter);
      return (icapolicy[]) icapolicy.getfiltered(service, option);
    }

    public static uint count(nitro_service service)
    {
      icapolicy icapolicy = new icapolicy();
      options option = new options();
      option.set_count(true);
      icapolicy[] resources = (icapolicy[]) icapolicy.get_resources(service, option);
      return resources != null && resources.Length > 0 ? resources[0].__count.Value : 0U;
    }

    public static uint count_filtered(nitro_service service, string filter)
    {
      icapolicy icapolicy = new icapolicy();
      options option = new options();
      option.set_count(true);
      option.set_filter(filter);
      icapolicy[] icapolicyArray = (icapolicy[]) icapolicy.getfiltered(service, option);
      return icapolicyArray != null && icapolicyArray.Length > 0 ? icapolicyArray[0].__count.Value : 0U;
    }

    public static uint count_filtered(nitro_service service, filtervalue[] filter)
    {
      icapolicy icapolicy = new icapolicy();
      options option = new options();
      option.set_count(true);
      option.set_filter(filter);
      icapolicy[] icapolicyArray = (icapolicy[]) icapolicy.getfiltered(service, option);
      return icapolicyArray != null && icapolicyArray.Length > 0 ? icapolicyArray[0].__count.Value : 0U;
    }

    private class icapolicy_response : base_response
    {
      public icapolicy[] icapolicy = (icapolicy[]) null;
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
