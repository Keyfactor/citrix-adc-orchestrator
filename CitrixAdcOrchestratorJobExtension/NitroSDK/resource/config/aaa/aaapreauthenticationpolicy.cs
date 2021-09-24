// Decompiled with JetBrains decompiler
// Type: com.citrix.netscaler.nitro.resource.config.aaa.aaapreauthenticationpolicy
// Assembly: nitro, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 6CF5DDEF-E052-4F9D-953F-6644F8378A66


using com.citrix.netscaler.nitro.exception;
using com.citrix.netscaler.nitro.resource.Base;
using com.citrix.netscaler.nitro.service;
using com.citrix.netscaler.nitro.util;

namespace com.citrix.netscaler.nitro.resource.config.aaa
{
  public class aaapreauthenticationpolicy : base_resource
  {
    private string nameField = (string) null;
    private string ruleField = (string) null;
    private string reqactionField = (string) null;
    private long? hitsField = new long?();
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

    public string reqaction
    {
      get => this.reqactionField;
      set => this.reqactionField = value;
    }

    public long? hits
    {
      get => this.hitsField;
      private set => this.hitsField = value;
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
      aaapreauthenticationpolicy.aaapreauthenticationpolicy_response aaapreauthenticationpolicyResponse = new aaapreauthenticationpolicy.aaapreauthenticationpolicy_response();
      aaapreauthenticationpolicy.aaapreauthenticationpolicy_response resource = (aaapreauthenticationpolicy.aaapreauthenticationpolicy_response) service.get_payload_formatter().string_to_resource(aaapreauthenticationpolicyResponse.GetType(), response);
      if (resource.errorcode != 0)
      {
        if (resource.errorcode == 444)
          service.clear_session();
        if (resource.severity == null)
          throw new nitro_exception(resource.message, resource.errorcode);
        if (resource.severity.Equals("ERROR"))
          throw new nitro_exception(resource.message, resource.errorcode);
      }
      return (base_resource[]) resource.aaapreauthenticationpolicy;
    }

    internal override string get_object_name() => this.name;

    public static base_response add(
      nitro_service client,
      aaapreauthenticationpolicy resource)
    {
      return new aaapreauthenticationpolicy()
      {
        name = resource.name,
        rule = resource.rule,
        reqaction = resource.reqaction
      }.add_resource(client);
    }

    public static base_responses add(
      nitro_service client,
      aaapreauthenticationpolicy[] resources)
    {
      base_responses baseResponses = (base_responses) null;
      if (resources != null && resources.Length > 0)
      {
        aaapreauthenticationpolicy[] aaapreauthenticationpolicyArray = new aaapreauthenticationpolicy[resources.Length];
        for (int index = 0; index < resources.Length; ++index)
        {
          aaapreauthenticationpolicyArray[index] = new aaapreauthenticationpolicy();
          aaapreauthenticationpolicyArray[index].name = resources[index].name;
          aaapreauthenticationpolicyArray[index].rule = resources[index].rule;
          aaapreauthenticationpolicyArray[index].reqaction = resources[index].reqaction;
        }
        baseResponses = base_resource.add_bulk_request(client, (base_resource[]) aaapreauthenticationpolicyArray);
      }
      return baseResponses;
    }

    public static base_response delete(nitro_service client, string name) => new aaapreauthenticationpolicy()
    {
      name = name
    }.delete_resource(client);

    public static base_response delete(
      nitro_service client,
      aaapreauthenticationpolicy resource)
    {
      return new aaapreauthenticationpolicy()
      {
        name = resource.name
      }.delete_resource(client);
    }

    public static base_responses delete(nitro_service client, string[] name)
    {
      base_responses baseResponses = (base_responses) null;
      if (name != null && name.Length > 0)
      {
        aaapreauthenticationpolicy[] aaapreauthenticationpolicyArray = new aaapreauthenticationpolicy[name.Length];
        for (int index = 0; index < name.Length; ++index)
        {
          aaapreauthenticationpolicyArray[index] = new aaapreauthenticationpolicy();
          aaapreauthenticationpolicyArray[index].name = name[index];
        }
        baseResponses = base_resource.delete_bulk_request(client, (base_resource[]) aaapreauthenticationpolicyArray);
      }
      return baseResponses;
    }

    public static base_responses delete(
      nitro_service client,
      aaapreauthenticationpolicy[] resources)
    {
      base_responses baseResponses = (base_responses) null;
      if (resources != null && resources.Length > 0)
      {
        aaapreauthenticationpolicy[] aaapreauthenticationpolicyArray = new aaapreauthenticationpolicy[resources.Length];
        for (int index = 0; index < resources.Length; ++index)
        {
          aaapreauthenticationpolicyArray[index] = new aaapreauthenticationpolicy();
          aaapreauthenticationpolicyArray[index].name = resources[index].name;
        }
        baseResponses = base_resource.delete_bulk_request(client, (base_resource[]) aaapreauthenticationpolicyArray);
      }
      return baseResponses;
    }

    public static base_response update(
      nitro_service client,
      aaapreauthenticationpolicy resource)
    {
      return new aaapreauthenticationpolicy()
      {
        name = resource.name,
        rule = resource.rule,
        reqaction = resource.reqaction
      }.update_resource(client);
    }

    public static base_responses update(
      nitro_service client,
      aaapreauthenticationpolicy[] resources)
    {
      base_responses baseResponses = (base_responses) null;
      if (resources != null && resources.Length > 0)
      {
        aaapreauthenticationpolicy[] aaapreauthenticationpolicyArray = new aaapreauthenticationpolicy[resources.Length];
        for (int index = 0; index < resources.Length; ++index)
        {
          aaapreauthenticationpolicyArray[index] = new aaapreauthenticationpolicy();
          aaapreauthenticationpolicyArray[index].name = resources[index].name;
          aaapreauthenticationpolicyArray[index].rule = resources[index].rule;
          aaapreauthenticationpolicyArray[index].reqaction = resources[index].reqaction;
        }
        baseResponses = base_resource.update_bulk_request(client, (base_resource[]) aaapreauthenticationpolicyArray);
      }
      return baseResponses;
    }

    public static aaapreauthenticationpolicy[] get(nitro_service service) => (aaapreauthenticationpolicy[]) new aaapreauthenticationpolicy().get_resources(service, (options) null);

    public static aaapreauthenticationpolicy[] get(
      nitro_service service,
      options option)
    {
      return (aaapreauthenticationpolicy[]) new aaapreauthenticationpolicy().get_resources(service, option);
    }

    public static aaapreauthenticationpolicy get(
      nitro_service service,
      string name)
    {
      return (aaapreauthenticationpolicy) new aaapreauthenticationpolicy()
      {
        name = name
      }.get_resource(service);
    }

    public static aaapreauthenticationpolicy[] get(
      nitro_service service,
      string[] name)
    {
      if (name == null || name.Length <= 0)
        return (aaapreauthenticationpolicy[]) null;
      aaapreauthenticationpolicy[] aaapreauthenticationpolicyArray1 = new aaapreauthenticationpolicy[name.Length];
      aaapreauthenticationpolicy[] aaapreauthenticationpolicyArray2 = new aaapreauthenticationpolicy[name.Length];
      for (int index = 0; index < name.Length; ++index)
      {
        aaapreauthenticationpolicyArray2[index] = new aaapreauthenticationpolicy();
        aaapreauthenticationpolicyArray2[index].name = name[index];
        aaapreauthenticationpolicyArray1[index] = (aaapreauthenticationpolicy) aaapreauthenticationpolicyArray2[index].get_resource(service);
      }
      return aaapreauthenticationpolicyArray1;
    }

    public static aaapreauthenticationpolicy[] get_filtered(
      nitro_service service,
      string filter)
    {
      aaapreauthenticationpolicy aaapreauthenticationpolicy = new aaapreauthenticationpolicy();
      options option = new options();
      option.set_filter(filter);
      return (aaapreauthenticationpolicy[]) aaapreauthenticationpolicy.getfiltered(service, option);
    }

    public static aaapreauthenticationpolicy[] get_filtered(
      nitro_service service,
      filtervalue[] filter)
    {
      aaapreauthenticationpolicy aaapreauthenticationpolicy = new aaapreauthenticationpolicy();
      options option = new options();
      option.set_filter(filter);
      return (aaapreauthenticationpolicy[]) aaapreauthenticationpolicy.getfiltered(service, option);
    }

    public static uint count(nitro_service service)
    {
      aaapreauthenticationpolicy aaapreauthenticationpolicy = new aaapreauthenticationpolicy();
      options option = new options();
      option.set_count(true);
      aaapreauthenticationpolicy[] resources = (aaapreauthenticationpolicy[]) aaapreauthenticationpolicy.get_resources(service, option);
      return resources != null && resources.Length > 0 ? resources[0].__count.Value : 0U;
    }

    public static uint count_filtered(nitro_service service, string filter)
    {
      aaapreauthenticationpolicy aaapreauthenticationpolicy = new aaapreauthenticationpolicy();
      options option = new options();
      option.set_count(true);
      option.set_filter(filter);
      aaapreauthenticationpolicy[] aaapreauthenticationpolicyArray = (aaapreauthenticationpolicy[]) aaapreauthenticationpolicy.getfiltered(service, option);
      return aaapreauthenticationpolicyArray != null && aaapreauthenticationpolicyArray.Length > 0 ? aaapreauthenticationpolicyArray[0].__count.Value : 0U;
    }

    public static uint count_filtered(nitro_service service, filtervalue[] filter)
    {
      aaapreauthenticationpolicy aaapreauthenticationpolicy = new aaapreauthenticationpolicy();
      options option = new options();
      option.set_count(true);
      option.set_filter(filter);
      aaapreauthenticationpolicy[] aaapreauthenticationpolicyArray = (aaapreauthenticationpolicy[]) aaapreauthenticationpolicy.getfiltered(service, option);
      return aaapreauthenticationpolicyArray != null && aaapreauthenticationpolicyArray.Length > 0 ? aaapreauthenticationpolicyArray[0].__count.Value : 0U;
    }

    private class aaapreauthenticationpolicy_response : base_response
    {
      public aaapreauthenticationpolicy[] aaapreauthenticationpolicy = (aaapreauthenticationpolicy[]) null;
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
