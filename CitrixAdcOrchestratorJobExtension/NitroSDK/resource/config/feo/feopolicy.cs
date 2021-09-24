// Decompiled with JetBrains decompiler
// Type: com.citrix.netscaler.nitro.resource.config.feo.feopolicy
// Assembly: nitro, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 6CF5DDEF-E052-4F9D-953F-6644F8378A66


using com.citrix.netscaler.nitro.exception;
using com.citrix.netscaler.nitro.resource.Base;
using com.citrix.netscaler.nitro.service;
using com.citrix.netscaler.nitro.util;

namespace com.citrix.netscaler.nitro.resource.config.feo
{
  public class feopolicy : base_resource
  {
    private string nameField = (string) null;
    private string ruleField = (string) null;
    private string actionField = (string) null;
    private string[] builtinField = (string[]) null;
    private long? hitsField = new long?();
    private long? undefhitsField = new long?();
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

    public string[] builtin
    {
      get => this.builtinField;
      private set => this.builtinField = value;
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

    internal override base_resource[] get_nitro_response(
      nitro_service service,
      string response)
    {
      feopolicy.feopolicy_response feopolicyResponse = new feopolicy.feopolicy_response();
      feopolicy.feopolicy_response resource = (feopolicy.feopolicy_response) service.get_payload_formatter().string_to_resource(feopolicyResponse.GetType(), response);
      if (resource.errorcode != 0)
      {
        if (resource.errorcode == 444)
          service.clear_session();
        if (resource.severity == null)
          throw new nitro_exception(resource.message, resource.errorcode);
        if (resource.severity.Equals("ERROR"))
          throw new nitro_exception(resource.message, resource.errorcode);
      }
      return (base_resource[]) resource.feopolicy;
    }

    internal override string get_object_name() => this.name;

    public static base_response add(nitro_service client, feopolicy resource) => new feopolicy()
    {
      name = resource.name,
      rule = resource.rule,
      action = resource.action
    }.add_resource(client);

    public static base_responses add(nitro_service client, feopolicy[] resources)
    {
      base_responses baseResponses = (base_responses) null;
      if (resources != null && resources.Length > 0)
      {
        feopolicy[] feopolicyArray = new feopolicy[resources.Length];
        for (int index = 0; index < resources.Length; ++index)
        {
          feopolicyArray[index] = new feopolicy();
          feopolicyArray[index].name = resources[index].name;
          feopolicyArray[index].rule = resources[index].rule;
          feopolicyArray[index].action = resources[index].action;
        }
        baseResponses = base_resource.add_bulk_request(client, (base_resource[]) feopolicyArray);
      }
      return baseResponses;
    }

    public static base_response delete(nitro_service client, string name) => new feopolicy()
    {
      name = name
    }.delete_resource(client);

    public static base_response delete(nitro_service client, feopolicy resource) => new feopolicy()
    {
      name = resource.name
    }.delete_resource(client);

    public static base_responses delete(nitro_service client, string[] name)
    {
      base_responses baseResponses = (base_responses) null;
      if (name != null && name.Length > 0)
      {
        feopolicy[] feopolicyArray = new feopolicy[name.Length];
        for (int index = 0; index < name.Length; ++index)
        {
          feopolicyArray[index] = new feopolicy();
          feopolicyArray[index].name = name[index];
        }
        baseResponses = base_resource.delete_bulk_request(client, (base_resource[]) feopolicyArray);
      }
      return baseResponses;
    }

    public static base_responses delete(nitro_service client, feopolicy[] resources)
    {
      base_responses baseResponses = (base_responses) null;
      if (resources != null && resources.Length > 0)
      {
        feopolicy[] feopolicyArray = new feopolicy[resources.Length];
        for (int index = 0; index < resources.Length; ++index)
        {
          feopolicyArray[index] = new feopolicy();
          feopolicyArray[index].name = resources[index].name;
        }
        baseResponses = base_resource.delete_bulk_request(client, (base_resource[]) feopolicyArray);
      }
      return baseResponses;
    }

    public static base_response update(nitro_service client, feopolicy resource) => new feopolicy()
    {
      name = resource.name,
      rule = resource.rule,
      action = resource.action
    }.update_resource(client);

    public static base_responses update(nitro_service client, feopolicy[] resources)
    {
      base_responses baseResponses = (base_responses) null;
      if (resources != null && resources.Length > 0)
      {
        feopolicy[] feopolicyArray = new feopolicy[resources.Length];
        for (int index = 0; index < resources.Length; ++index)
        {
          feopolicyArray[index] = new feopolicy();
          feopolicyArray[index].name = resources[index].name;
          feopolicyArray[index].rule = resources[index].rule;
          feopolicyArray[index].action = resources[index].action;
        }
        baseResponses = base_resource.update_bulk_request(client, (base_resource[]) feopolicyArray);
      }
      return baseResponses;
    }

    public static base_response unset(
      nitro_service client,
      string name,
      string[] args)
    {
      return new feopolicy() { name = name }.unset_resource(client, args);
    }

    public static base_response unset(
      nitro_service client,
      feopolicy resource,
      string[] args)
    {
      return new feopolicy() { name = resource.name }.unset_resource(client, args);
    }

    public static base_responses unset(
      nitro_service client,
      string[] name,
      string[] args)
    {
      base_responses baseResponses = (base_responses) null;
      if (name != null && name.Length > 0)
      {
        feopolicy[] feopolicyArray = new feopolicy[name.Length];
        for (int index = 0; index < name.Length; ++index)
        {
          feopolicyArray[index] = new feopolicy();
          feopolicyArray[index].name = name[index];
        }
        baseResponses = base_resource.unset_bulk_request(client, (base_resource[]) feopolicyArray, args);
      }
      return baseResponses;
    }

    public static base_responses unset(
      nitro_service client,
      feopolicy[] resources,
      string[] args)
    {
      base_responses baseResponses = (base_responses) null;
      if (resources != null && resources.Length > 0)
      {
        feopolicy[] feopolicyArray = new feopolicy[resources.Length];
        for (int index = 0; index < resources.Length; ++index)
        {
          feopolicyArray[index] = new feopolicy();
          feopolicyArray[index].name = resources[index].name;
        }
        baseResponses = base_resource.unset_bulk_request(client, (base_resource[]) feopolicyArray, args);
      }
      return baseResponses;
    }

    public static feopolicy[] get(nitro_service service) => (feopolicy[]) new feopolicy().get_resources(service, (options) null);

    public static feopolicy[] get(nitro_service service, options option) => (feopolicy[]) new feopolicy().get_resources(service, option);

    public static feopolicy get(nitro_service service, string name) => (feopolicy) new feopolicy()
    {
      name = name
    }.get_resource(service);

    public static feopolicy[] get(nitro_service service, string[] name)
    {
      if (name == null || name.Length <= 0)
        return (feopolicy[]) null;
      feopolicy[] feopolicyArray1 = new feopolicy[name.Length];
      feopolicy[] feopolicyArray2 = new feopolicy[name.Length];
      for (int index = 0; index < name.Length; ++index)
      {
        feopolicyArray2[index] = new feopolicy();
        feopolicyArray2[index].name = name[index];
        feopolicyArray1[index] = (feopolicy) feopolicyArray2[index].get_resource(service);
      }
      return feopolicyArray1;
    }

    public static feopolicy[] get_filtered(nitro_service service, string filter)
    {
      feopolicy feopolicy = new feopolicy();
      options option = new options();
      option.set_filter(filter);
      return (feopolicy[]) feopolicy.getfiltered(service, option);
    }

    public static feopolicy[] get_filtered(nitro_service service, filtervalue[] filter)
    {
      feopolicy feopolicy = new feopolicy();
      options option = new options();
      option.set_filter(filter);
      return (feopolicy[]) feopolicy.getfiltered(service, option);
    }

    public static uint count(nitro_service service)
    {
      feopolicy feopolicy = new feopolicy();
      options option = new options();
      option.set_count(true);
      feopolicy[] resources = (feopolicy[]) feopolicy.get_resources(service, option);
      return resources != null && resources.Length > 0 ? resources[0].__count.Value : 0U;
    }

    public static uint count_filtered(nitro_service service, string filter)
    {
      feopolicy feopolicy = new feopolicy();
      options option = new options();
      option.set_count(true);
      option.set_filter(filter);
      feopolicy[] feopolicyArray = (feopolicy[]) feopolicy.getfiltered(service, option);
      return feopolicyArray != null && feopolicyArray.Length > 0 ? feopolicyArray[0].__count.Value : 0U;
    }

    public static uint count_filtered(nitro_service service, filtervalue[] filter)
    {
      feopolicy feopolicy = new feopolicy();
      options option = new options();
      option.set_count(true);
      option.set_filter(filter);
      feopolicy[] feopolicyArray = (feopolicy[]) feopolicy.getfiltered(service, option);
      return feopolicyArray != null && feopolicyArray.Length > 0 ? feopolicyArray[0].__count.Value : 0U;
    }

    private class feopolicy_response : base_response
    {
      public feopolicy[] feopolicy = (feopolicy[]) null;
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
