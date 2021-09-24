// Decompiled with JetBrains decompiler
// Type: com.citrix.netscaler.nitro.resource.config.cs.csaction
// Assembly: nitro, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 6CF5DDEF-E052-4F9D-953F-6644F8378A66


using com.citrix.netscaler.nitro.exception;
using com.citrix.netscaler.nitro.resource.Base;
using com.citrix.netscaler.nitro.service;
using com.citrix.netscaler.nitro.util;

namespace com.citrix.netscaler.nitro.resource.config.cs
{
  public class csaction : base_resource
  {
    private string nameField = (string) null;
    private string targetlbvserverField = (string) null;
    private string targetvserverField = (string) null;
    private string targetvserverexprField = (string) null;
    private string commentField = (string) null;
    private string newnameField = (string) null;
    private long? hitsField = new long?();
    private uint? referencecountField = new uint?();
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

    public string targetlbvserver
    {
      get => this.targetlbvserverField;
      set => this.targetlbvserverField = value;
    }

    public string targetvserver
    {
      get => this.targetvserverField;
      set => this.targetvserverField = value;
    }

    public string targetvserverexpr
    {
      get => this.targetvserverexprField;
      set => this.targetvserverexprField = value;
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

    public uint? referencecount
    {
      get => this.referencecountField;
      private set => this.referencecountField = value;
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
      csaction.csaction_response csactionResponse = new csaction.csaction_response();
      csaction.csaction_response resource = (csaction.csaction_response) service.get_payload_formatter().string_to_resource(csactionResponse.GetType(), response);
      if (resource.errorcode != 0)
      {
        if (resource.errorcode == 444)
          service.clear_session();
        if (resource.severity == null)
          throw new nitro_exception(resource.message, resource.errorcode);
        if (resource.severity.Equals("ERROR"))
          throw new nitro_exception(resource.message, resource.errorcode);
      }
      return (base_resource[]) resource.csaction;
    }

    internal override string get_object_name() => this.name;

    public static base_response add(nitro_service client, csaction resource) => new csaction()
    {
      name = resource.name,
      targetlbvserver = resource.targetlbvserver,
      targetvserver = resource.targetvserver,
      targetvserverexpr = resource.targetvserverexpr,
      comment = resource.comment
    }.add_resource(client);

    public static base_responses add(nitro_service client, csaction[] resources)
    {
      base_responses baseResponses = (base_responses) null;
      if (resources != null && resources.Length > 0)
      {
        csaction[] csactionArray = new csaction[resources.Length];
        for (int index = 0; index < resources.Length; ++index)
        {
          csactionArray[index] = new csaction();
          csactionArray[index].name = resources[index].name;
          csactionArray[index].targetlbvserver = resources[index].targetlbvserver;
          csactionArray[index].targetvserver = resources[index].targetvserver;
          csactionArray[index].targetvserverexpr = resources[index].targetvserverexpr;
          csactionArray[index].comment = resources[index].comment;
        }
        baseResponses = base_resource.add_bulk_request(client, (base_resource[]) csactionArray);
      }
      return baseResponses;
    }

    public static base_response delete(nitro_service client, string name) => new csaction()
    {
      name = name
    }.delete_resource(client);

    public static base_response delete(nitro_service client, csaction resource) => new csaction()
    {
      name = resource.name
    }.delete_resource(client);

    public static base_responses delete(nitro_service client, string[] name)
    {
      base_responses baseResponses = (base_responses) null;
      if (name != null && name.Length > 0)
      {
        csaction[] csactionArray = new csaction[name.Length];
        for (int index = 0; index < name.Length; ++index)
        {
          csactionArray[index] = new csaction();
          csactionArray[index].name = name[index];
        }
        baseResponses = base_resource.delete_bulk_request(client, (base_resource[]) csactionArray);
      }
      return baseResponses;
    }

    public static base_responses delete(nitro_service client, csaction[] resources)
    {
      base_responses baseResponses = (base_responses) null;
      if (resources != null && resources.Length > 0)
      {
        csaction[] csactionArray = new csaction[resources.Length];
        for (int index = 0; index < resources.Length; ++index)
        {
          csactionArray[index] = new csaction();
          csactionArray[index].name = resources[index].name;
        }
        baseResponses = base_resource.delete_bulk_request(client, (base_resource[]) csactionArray);
      }
      return baseResponses;
    }

    public static base_response update(nitro_service client, csaction resource) => new csaction()
    {
      name = resource.name,
      targetlbvserver = resource.targetlbvserver,
      targetvserver = resource.targetvserver,
      targetvserverexpr = resource.targetvserverexpr,
      comment = resource.comment
    }.update_resource(client);

    public static base_responses update(nitro_service client, csaction[] resources)
    {
      base_responses baseResponses = (base_responses) null;
      if (resources != null && resources.Length > 0)
      {
        csaction[] csactionArray = new csaction[resources.Length];
        for (int index = 0; index < resources.Length; ++index)
        {
          csactionArray[index] = new csaction();
          csactionArray[index].name = resources[index].name;
          csactionArray[index].targetlbvserver = resources[index].targetlbvserver;
          csactionArray[index].targetvserver = resources[index].targetvserver;
          csactionArray[index].targetvserverexpr = resources[index].targetvserverexpr;
          csactionArray[index].comment = resources[index].comment;
        }
        baseResponses = base_resource.update_bulk_request(client, (base_resource[]) csactionArray);
      }
      return baseResponses;
    }

    public static base_response unset(
      nitro_service client,
      string name,
      string[] args)
    {
      return new csaction() { name = name }.unset_resource(client, args);
    }

    public static base_response unset(
      nitro_service client,
      csaction resource,
      string[] args)
    {
      return new csaction() { name = resource.name }.unset_resource(client, args);
    }

    public static base_responses unset(
      nitro_service client,
      string[] name,
      string[] args)
    {
      base_responses baseResponses = (base_responses) null;
      if (name != null && name.Length > 0)
      {
        csaction[] csactionArray = new csaction[name.Length];
        for (int index = 0; index < name.Length; ++index)
        {
          csactionArray[index] = new csaction();
          csactionArray[index].name = name[index];
        }
        baseResponses = base_resource.unset_bulk_request(client, (base_resource[]) csactionArray, args);
      }
      return baseResponses;
    }

    public static base_responses unset(
      nitro_service client,
      csaction[] resources,
      string[] args)
    {
      base_responses baseResponses = (base_responses) null;
      if (resources != null && resources.Length > 0)
      {
        csaction[] csactionArray = new csaction[resources.Length];
        for (int index = 0; index < resources.Length; ++index)
        {
          csactionArray[index] = new csaction();
          csactionArray[index].name = resources[index].name;
        }
        baseResponses = base_resource.unset_bulk_request(client, (base_resource[]) csactionArray, args);
      }
      return baseResponses;
    }

    public static base_response rename(
      nitro_service client,
      csaction resource,
      string new_name)
    {
      return new csaction()
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
      return new csaction()
      {
        name = name,
        newname = new_name
      }.rename_resource(client);
    }

    public static csaction[] get(nitro_service service) => (csaction[]) new csaction().get_resources(service, (options) null);

    public static csaction[] get(nitro_service service, options option) => (csaction[]) new csaction().get_resources(service, option);

    public static csaction get(nitro_service service, string name) => (csaction) new csaction()
    {
      name = name
    }.get_resource(service);

    public static csaction[] get(nitro_service service, string[] name)
    {
      if (name == null || name.Length <= 0)
        return (csaction[]) null;
      csaction[] csactionArray1 = new csaction[name.Length];
      csaction[] csactionArray2 = new csaction[name.Length];
      for (int index = 0; index < name.Length; ++index)
      {
        csactionArray2[index] = new csaction();
        csactionArray2[index].name = name[index];
        csactionArray1[index] = (csaction) csactionArray2[index].get_resource(service);
      }
      return csactionArray1;
    }

    public static csaction[] get_filtered(nitro_service service, string filter)
    {
      csaction csaction = new csaction();
      options option = new options();
      option.set_filter(filter);
      return (csaction[]) csaction.getfiltered(service, option);
    }

    public static csaction[] get_filtered(nitro_service service, filtervalue[] filter)
    {
      csaction csaction = new csaction();
      options option = new options();
      option.set_filter(filter);
      return (csaction[]) csaction.getfiltered(service, option);
    }

    public static uint count(nitro_service service)
    {
      csaction csaction = new csaction();
      options option = new options();
      option.set_count(true);
      csaction[] resources = (csaction[]) csaction.get_resources(service, option);
      return resources != null && resources.Length > 0 ? resources[0].__count.Value : 0U;
    }

    public static uint count_filtered(nitro_service service, string filter)
    {
      csaction csaction = new csaction();
      options option = new options();
      option.set_count(true);
      option.set_filter(filter);
      csaction[] csactionArray = (csaction[]) csaction.getfiltered(service, option);
      return csactionArray != null && csactionArray.Length > 0 ? csactionArray[0].__count.Value : 0U;
    }

    public static uint count_filtered(nitro_service service, filtervalue[] filter)
    {
      csaction csaction = new csaction();
      options option = new options();
      option.set_count(true);
      option.set_filter(filter);
      csaction[] csactionArray = (csaction[]) csaction.getfiltered(service, option);
      return csactionArray != null && csactionArray.Length > 0 ? csactionArray[0].__count.Value : 0U;
    }

    private class csaction_response : base_response
    {
      public csaction[] csaction = (csaction[]) null;
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
