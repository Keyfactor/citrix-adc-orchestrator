// Decompiled with JetBrains decompiler
// Type: com.citrix.netscaler.nitro.resource.config.cmp.cmppolicy
// Assembly: nitro, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 6CF5DDEF-E052-4F9D-953F-6644F8378A66


using com.citrix.netscaler.nitro.exception;
using com.citrix.netscaler.nitro.resource.Base;
using com.citrix.netscaler.nitro.service;
using com.citrix.netscaler.nitro.util;

namespace com.citrix.netscaler.nitro.resource.config.cmp
{
  public class cmppolicy : base_resource
  {
    private string nameField = (string) null;
    private string ruleField = (string) null;
    private string resactionField = (string) null;
    private string newnameField = (string) null;
    private string expressiontypeField = (string) null;
    private string reqactionField = (string) null;
    private long? hitsField = new long?();
    private long? txbytesField = new long?();
    private long? rxbytesField = new long?();
    private long? clientttlbField = new long?();
    private long? clienttransactionsField = new long?();
    private long? serverttlbField = new long?();
    private long? servertransactionsField = new long?();
    private string descriptionField = (string) null;
    private string[] builtinField = (string[]) null;
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

    public string resaction
    {
      get => this.resactionField;
      set => this.resactionField = value;
    }

    public string newname
    {
      get => this.newnameField;
      set => this.newnameField = value;
    }

    public string expressiontype
    {
      get => this.expressiontypeField;
      private set => this.expressiontypeField = value;
    }

    public string reqaction
    {
      get => this.reqactionField;
      private set => this.reqactionField = value;
    }

    public long? hits
    {
      get => this.hitsField;
      private set => this.hitsField = value;
    }

    public long? txbytes
    {
      get => this.txbytesField;
      private set => this.txbytesField = value;
    }

    public long? rxbytes
    {
      get => this.rxbytesField;
      private set => this.rxbytesField = value;
    }

    public long? clientttlb
    {
      get => this.clientttlbField;
      private set => this.clientttlbField = value;
    }

    public long? clienttransactions
    {
      get => this.clienttransactionsField;
      private set => this.clienttransactionsField = value;
    }

    public long? serverttlb
    {
      get => this.serverttlbField;
      private set => this.serverttlbField = value;
    }

    public long? servertransactions
    {
      get => this.servertransactionsField;
      private set => this.servertransactionsField = value;
    }

    public string description
    {
      get => this.descriptionField;
      private set => this.descriptionField = value;
    }

    public string[] builtin
    {
      get => this.builtinField;
      private set => this.builtinField = value;
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
      cmppolicy.cmppolicy_response cmppolicyResponse = new cmppolicy.cmppolicy_response();
      cmppolicy.cmppolicy_response resource = (cmppolicy.cmppolicy_response) service.get_payload_formatter().string_to_resource(cmppolicyResponse.GetType(), response);
      if (resource.errorcode != 0)
      {
        if (resource.errorcode == 444)
          service.clear_session();
        if (resource.severity == null)
          throw new nitro_exception(resource.message, resource.errorcode);
        if (resource.severity.Equals("ERROR"))
          throw new nitro_exception(resource.message, resource.errorcode);
      }
      return (base_resource[]) resource.cmppolicy;
    }

    internal override string get_object_name() => this.name;

    public static base_response add(nitro_service client, cmppolicy resource) => new cmppolicy()
    {
      name = resource.name,
      rule = resource.rule,
      resaction = resource.resaction
    }.add_resource(client);

    public static base_responses add(nitro_service client, cmppolicy[] resources)
    {
      base_responses baseResponses = (base_responses) null;
      if (resources != null && resources.Length > 0)
      {
        cmppolicy[] cmppolicyArray = new cmppolicy[resources.Length];
        for (int index = 0; index < resources.Length; ++index)
        {
          cmppolicyArray[index] = new cmppolicy();
          cmppolicyArray[index].name = resources[index].name;
          cmppolicyArray[index].rule = resources[index].rule;
          cmppolicyArray[index].resaction = resources[index].resaction;
        }
        baseResponses = base_resource.add_bulk_request(client, (base_resource[]) cmppolicyArray);
      }
      return baseResponses;
    }

    public static base_response delete(nitro_service client, string name) => new cmppolicy()
    {
      name = name
    }.delete_resource(client);

    public static base_response delete(nitro_service client, cmppolicy resource) => new cmppolicy()
    {
      name = resource.name
    }.delete_resource(client);

    public static base_responses delete(nitro_service client, string[] name)
    {
      base_responses baseResponses = (base_responses) null;
      if (name != null && name.Length > 0)
      {
        cmppolicy[] cmppolicyArray = new cmppolicy[name.Length];
        for (int index = 0; index < name.Length; ++index)
        {
          cmppolicyArray[index] = new cmppolicy();
          cmppolicyArray[index].name = name[index];
        }
        baseResponses = base_resource.delete_bulk_request(client, (base_resource[]) cmppolicyArray);
      }
      return baseResponses;
    }

    public static base_responses delete(nitro_service client, cmppolicy[] resources)
    {
      base_responses baseResponses = (base_responses) null;
      if (resources != null && resources.Length > 0)
      {
        cmppolicy[] cmppolicyArray = new cmppolicy[resources.Length];
        for (int index = 0; index < resources.Length; ++index)
        {
          cmppolicyArray[index] = new cmppolicy();
          cmppolicyArray[index].name = resources[index].name;
        }
        baseResponses = base_resource.delete_bulk_request(client, (base_resource[]) cmppolicyArray);
      }
      return baseResponses;
    }

    public static base_response update(nitro_service client, cmppolicy resource) => new cmppolicy()
    {
      name = resource.name,
      rule = resource.rule,
      resaction = resource.resaction
    }.update_resource(client);

    public static base_responses update(nitro_service client, cmppolicy[] resources)
    {
      base_responses baseResponses = (base_responses) null;
      if (resources != null && resources.Length > 0)
      {
        cmppolicy[] cmppolicyArray = new cmppolicy[resources.Length];
        for (int index = 0; index < resources.Length; ++index)
        {
          cmppolicyArray[index] = new cmppolicy();
          cmppolicyArray[index].name = resources[index].name;
          cmppolicyArray[index].rule = resources[index].rule;
          cmppolicyArray[index].resaction = resources[index].resaction;
        }
        baseResponses = base_resource.update_bulk_request(client, (base_resource[]) cmppolicyArray);
      }
      return baseResponses;
    }

    public static base_response rename(
      nitro_service client,
      cmppolicy resource,
      string new_name)
    {
      return new cmppolicy()
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
      return new cmppolicy()
      {
        name = name,
        newname = new_name
      }.rename_resource(client);
    }

    public static cmppolicy[] get(nitro_service service) => (cmppolicy[]) new cmppolicy().get_resources(service, (options) null);

    public static cmppolicy[] get(nitro_service service, options option) => (cmppolicy[]) new cmppolicy().get_resources(service, option);

    public static cmppolicy get(nitro_service service, string name) => (cmppolicy) new cmppolicy()
    {
      name = name
    }.get_resource(service);

    public static cmppolicy[] get(nitro_service service, string[] name)
    {
      if (name == null || name.Length <= 0)
        return (cmppolicy[]) null;
      cmppolicy[] cmppolicyArray1 = new cmppolicy[name.Length];
      cmppolicy[] cmppolicyArray2 = new cmppolicy[name.Length];
      for (int index = 0; index < name.Length; ++index)
      {
        cmppolicyArray2[index] = new cmppolicy();
        cmppolicyArray2[index].name = name[index];
        cmppolicyArray1[index] = (cmppolicy) cmppolicyArray2[index].get_resource(service);
      }
      return cmppolicyArray1;
    }

    public static cmppolicy[] get_filtered(nitro_service service, string filter)
    {
      cmppolicy cmppolicy = new cmppolicy();
      options option = new options();
      option.set_filter(filter);
      return (cmppolicy[]) cmppolicy.getfiltered(service, option);
    }

    public static cmppolicy[] get_filtered(nitro_service service, filtervalue[] filter)
    {
      cmppolicy cmppolicy = new cmppolicy();
      options option = new options();
      option.set_filter(filter);
      return (cmppolicy[]) cmppolicy.getfiltered(service, option);
    }

    public static uint count(nitro_service service)
    {
      cmppolicy cmppolicy = new cmppolicy();
      options option = new options();
      option.set_count(true);
      cmppolicy[] resources = (cmppolicy[]) cmppolicy.get_resources(service, option);
      return resources != null && resources.Length > 0 ? resources[0].__count.Value : 0U;
    }

    public static uint count_filtered(nitro_service service, string filter)
    {
      cmppolicy cmppolicy = new cmppolicy();
      options option = new options();
      option.set_count(true);
      option.set_filter(filter);
      cmppolicy[] cmppolicyArray = (cmppolicy[]) cmppolicy.getfiltered(service, option);
      return cmppolicyArray != null && cmppolicyArray.Length > 0 ? cmppolicyArray[0].__count.Value : 0U;
    }

    public static uint count_filtered(nitro_service service, filtervalue[] filter)
    {
      cmppolicy cmppolicy = new cmppolicy();
      options option = new options();
      option.set_count(true);
      option.set_filter(filter);
      cmppolicy[] cmppolicyArray = (cmppolicy[]) cmppolicy.getfiltered(service, option);
      return cmppolicyArray != null && cmppolicyArray.Length > 0 ? cmppolicyArray[0].__count.Value : 0U;
    }

    private class cmppolicy_response : base_response
    {
      public cmppolicy[] cmppolicy = (cmppolicy[]) null;
    }

    public static class expressiontypeEnum
    {
      public const string Classic_Policy = "Classic Policy";
      public const string Advanced_Policy = "Advanced Policy";
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
