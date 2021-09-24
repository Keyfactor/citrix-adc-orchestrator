// Decompiled with JetBrains decompiler
// Type: com.citrix.netscaler.nitro.resource.config.ca.caaction
// Assembly: nitro, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 6CF5DDEF-E052-4F9D-953F-6644F8378A66


using com.citrix.netscaler.nitro.exception;
using com.citrix.netscaler.nitro.resource.Base;
using com.citrix.netscaler.nitro.service;
using com.citrix.netscaler.nitro.util;

namespace com.citrix.netscaler.nitro.resource.config.ca
{
  public class caaction : base_resource
  {
    private string nameField = (string) null;
    private long? accumressizeField = new long?();
    private string lbvserverField = (string) null;
    private string commentField = (string) null;
    private string typeField = (string) null;
    private string newnameField = (string) null;
    private bool? isdefaultField = new bool?();
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

    public long? accumressize
    {
      get => this.accumressizeField;
      set => this.accumressizeField = value;
    }

    public string lbvserver
    {
      get => this.lbvserverField;
      set => this.lbvserverField = value;
    }

    public string comment
    {
      get => this.commentField;
      set => this.commentField = value;
    }

    public string type
    {
      get => this.typeField;
      set => this.typeField = value;
    }

    public string newname
    {
      get => this.newnameField;
      set => this.newnameField = value;
    }

    public bool? isdefault
    {
      get => this.isdefaultField;
      private set => this.isdefaultField = value;
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
      caaction.caaction_response caactionResponse = new caaction.caaction_response();
      caaction.caaction_response resource = (caaction.caaction_response) service.get_payload_formatter().string_to_resource(caactionResponse.GetType(), response);
      if (resource.errorcode != 0)
      {
        if (resource.errorcode == 444)
          service.clear_session();
        if (resource.severity == null)
          throw new nitro_exception(resource.message, resource.errorcode);
        if (resource.severity.Equals("ERROR"))
          throw new nitro_exception(resource.message, resource.errorcode);
      }
      return (base_resource[]) resource.caaction;
    }

    internal override string get_object_name() => this.name;

    public static base_response add(nitro_service client, caaction resource) => new caaction()
    {
      name = resource.name,
      accumressize = resource.accumressize,
      lbvserver = resource.lbvserver,
      comment = resource.comment,
      type = resource.type
    }.add_resource(client);

    public static base_responses add(nitro_service client, caaction[] resources)
    {
      base_responses baseResponses = (base_responses) null;
      if (resources != null && resources.Length > 0)
      {
        caaction[] caactionArray = new caaction[resources.Length];
        for (int index = 0; index < resources.Length; ++index)
        {
          caactionArray[index] = new caaction();
          caactionArray[index].name = resources[index].name;
          caactionArray[index].accumressize = resources[index].accumressize;
          caactionArray[index].lbvserver = resources[index].lbvserver;
          caactionArray[index].comment = resources[index].comment;
          caactionArray[index].type = resources[index].type;
        }
        baseResponses = base_resource.add_bulk_request(client, (base_resource[]) caactionArray);
      }
      return baseResponses;
    }

    public static base_response update(nitro_service client, caaction resource) => new caaction()
    {
      name = resource.name,
      accumressize = resource.accumressize,
      type = resource.type,
      lbvserver = resource.lbvserver,
      comment = resource.comment
    }.update_resource(client);

    public static base_responses update(nitro_service client, caaction[] resources)
    {
      base_responses baseResponses = (base_responses) null;
      if (resources != null && resources.Length > 0)
      {
        caaction[] caactionArray = new caaction[resources.Length];
        for (int index = 0; index < resources.Length; ++index)
        {
          caactionArray[index] = new caaction();
          caactionArray[index].name = resources[index].name;
          caactionArray[index].accumressize = resources[index].accumressize;
          caactionArray[index].type = resources[index].type;
          caactionArray[index].lbvserver = resources[index].lbvserver;
          caactionArray[index].comment = resources[index].comment;
        }
        baseResponses = base_resource.update_bulk_request(client, (base_resource[]) caactionArray);
      }
      return baseResponses;
    }

    public static base_response unset(
      nitro_service client,
      string name,
      string[] args)
    {
      return new caaction() { name = name }.unset_resource(client, args);
    }

    public static base_response unset(
      nitro_service client,
      caaction resource,
      string[] args)
    {
      return new caaction() { name = resource.name }.unset_resource(client, args);
    }

    public static base_responses unset(
      nitro_service client,
      string[] name,
      string[] args)
    {
      base_responses baseResponses = (base_responses) null;
      if (name != null && name.Length > 0)
      {
        caaction[] caactionArray = new caaction[name.Length];
        for (int index = 0; index < name.Length; ++index)
        {
          caactionArray[index] = new caaction();
          caactionArray[index].name = name[index];
        }
        baseResponses = base_resource.unset_bulk_request(client, (base_resource[]) caactionArray, args);
      }
      return baseResponses;
    }

    public static base_responses unset(
      nitro_service client,
      caaction[] resources,
      string[] args)
    {
      base_responses baseResponses = (base_responses) null;
      if (resources != null && resources.Length > 0)
      {
        caaction[] caactionArray = new caaction[resources.Length];
        for (int index = 0; index < resources.Length; ++index)
        {
          caactionArray[index] = new caaction();
          caactionArray[index].name = resources[index].name;
        }
        baseResponses = base_resource.unset_bulk_request(client, (base_resource[]) caactionArray, args);
      }
      return baseResponses;
    }

    public static base_response delete(nitro_service client, string name) => new caaction()
    {
      name = name
    }.delete_resource(client);

    public static base_response delete(nitro_service client, caaction resource) => new caaction()
    {
      name = resource.name
    }.delete_resource(client);

    public static base_responses delete(nitro_service client, string[] name)
    {
      base_responses baseResponses = (base_responses) null;
      if (name != null && name.Length > 0)
      {
        caaction[] caactionArray = new caaction[name.Length];
        for (int index = 0; index < name.Length; ++index)
        {
          caactionArray[index] = new caaction();
          caactionArray[index].name = name[index];
        }
        baseResponses = base_resource.delete_bulk_request(client, (base_resource[]) caactionArray);
      }
      return baseResponses;
    }

    public static base_responses delete(nitro_service client, caaction[] resources)
    {
      base_responses baseResponses = (base_responses) null;
      if (resources != null && resources.Length > 0)
      {
        caaction[] caactionArray = new caaction[resources.Length];
        for (int index = 0; index < resources.Length; ++index)
        {
          caactionArray[index] = new caaction();
          caactionArray[index].name = resources[index].name;
        }
        baseResponses = base_resource.delete_bulk_request(client, (base_resource[]) caactionArray);
      }
      return baseResponses;
    }

    public static base_response rename(
      nitro_service client,
      caaction resource,
      string new_name)
    {
      return new caaction()
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
      return new caaction()
      {
        name = name,
        newname = new_name
      }.rename_resource(client);
    }

    public static caaction[] get(nitro_service service) => (caaction[]) new caaction().get_resources(service, (options) null);

    public static caaction[] get(nitro_service service, options option) => (caaction[]) new caaction().get_resources(service, option);

    public static caaction get(nitro_service service, string name) => (caaction) new caaction()
    {
      name = name
    }.get_resource(service);

    public static caaction[] get(nitro_service service, string[] name)
    {
      if (name == null || name.Length <= 0)
        return (caaction[]) null;
      caaction[] caactionArray1 = new caaction[name.Length];
      caaction[] caactionArray2 = new caaction[name.Length];
      for (int index = 0; index < name.Length; ++index)
      {
        caactionArray2[index] = new caaction();
        caactionArray2[index].name = name[index];
        caactionArray1[index] = (caaction) caactionArray2[index].get_resource(service);
      }
      return caactionArray1;
    }

    public static caaction[] get_filtered(nitro_service service, string filter)
    {
      caaction caaction = new caaction();
      options option = new options();
      option.set_filter(filter);
      return (caaction[]) caaction.getfiltered(service, option);
    }

    public static caaction[] get_filtered(nitro_service service, filtervalue[] filter)
    {
      caaction caaction = new caaction();
      options option = new options();
      option.set_filter(filter);
      return (caaction[]) caaction.getfiltered(service, option);
    }

    public static uint count(nitro_service service)
    {
      caaction caaction = new caaction();
      options option = new options();
      option.set_count(true);
      caaction[] resources = (caaction[]) caaction.get_resources(service, option);
      return resources != null && resources.Length > 0 ? resources[0].__count.Value : 0U;
    }

    public static uint count_filtered(nitro_service service, string filter)
    {
      caaction caaction = new caaction();
      options option = new options();
      option.set_count(true);
      option.set_filter(filter);
      caaction[] caactionArray = (caaction[]) caaction.getfiltered(service, option);
      return caactionArray != null && caactionArray.Length > 0 ? caactionArray[0].__count.Value : 0U;
    }

    public static uint count_filtered(nitro_service service, filtervalue[] filter)
    {
      caaction caaction = new caaction();
      options option = new options();
      option.set_count(true);
      option.set_filter(filter);
      caaction[] caactionArray = (caaction[]) caaction.getfiltered(service, option);
      return caactionArray != null && caactionArray.Length > 0 ? caactionArray[0].__count.Value : 0U;
    }

    private class caaction_response : base_response
    {
      public caaction[] caaction = (caaction[]) null;
    }

    public static class builtinEnum
    {
      public const string MODIFIABLE = "MODIFIABLE";
      public const string DELETABLE = "DELETABLE";
      public const string IMMUTABLE = "IMMUTABLE";
      public const string PARTITION_ALL = "PARTITION_ALL";
    }

    public static class typeEnum
    {
      public const string nolookup = "nolookup";
      public const string lookup = "lookup";
      public const string noop = "noop";
    }
  }
}
