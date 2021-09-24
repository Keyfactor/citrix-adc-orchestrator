// Decompiled with JetBrains decompiler
// Type: com.citrix.netscaler.nitro.resource.config.appfw.appfwfieldtype
// Assembly: nitro, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 6CF5DDEF-E052-4F9D-953F-6644F8378A66


using com.citrix.netscaler.nitro.exception;
using com.citrix.netscaler.nitro.resource.Base;
using com.citrix.netscaler.nitro.service;
using com.citrix.netscaler.nitro.util;

namespace com.citrix.netscaler.nitro.resource.config.appfw
{
  public class appfwfieldtype : base_resource
  {
    private string nameField = (string) null;
    private string regexField = (string) null;
    private uint? priorityField = new uint?();
    private string commentField = (string) null;
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

    public string regex
    {
      get => this.regexField;
      set => this.regexField = value;
    }

    public uint? priority
    {
      get => this.priorityField;
      set => this.priorityField = value;
    }

    public string comment
    {
      get => this.commentField;
      set => this.commentField = value;
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
      appfwfieldtype.appfwfieldtype_response appfwfieldtypeResponse = new appfwfieldtype.appfwfieldtype_response();
      appfwfieldtype.appfwfieldtype_response resource = (appfwfieldtype.appfwfieldtype_response) service.get_payload_formatter().string_to_resource(appfwfieldtypeResponse.GetType(), response);
      if (resource.errorcode != 0)
      {
        if (resource.errorcode == 444)
          service.clear_session();
        if (resource.severity == null)
          throw new nitro_exception(resource.message, resource.errorcode);
        if (resource.severity.Equals("ERROR"))
          throw new nitro_exception(resource.message, resource.errorcode);
      }
      return (base_resource[]) resource.appfwfieldtype;
    }

    internal override string get_object_name() => this.name;

    public static base_response add(nitro_service client, appfwfieldtype resource) => new appfwfieldtype()
    {
      name = resource.name,
      regex = resource.regex,
      priority = resource.priority,
      comment = resource.comment
    }.add_resource(client);

    public static base_responses add(nitro_service client, appfwfieldtype[] resources)
    {
      base_responses baseResponses = (base_responses) null;
      if (resources != null && resources.Length > 0)
      {
        appfwfieldtype[] appfwfieldtypeArray = new appfwfieldtype[resources.Length];
        for (int index = 0; index < resources.Length; ++index)
        {
          appfwfieldtypeArray[index] = new appfwfieldtype();
          appfwfieldtypeArray[index].name = resources[index].name;
          appfwfieldtypeArray[index].regex = resources[index].regex;
          appfwfieldtypeArray[index].priority = resources[index].priority;
          appfwfieldtypeArray[index].comment = resources[index].comment;
        }
        baseResponses = base_resource.add_bulk_request(client, (base_resource[]) appfwfieldtypeArray);
      }
      return baseResponses;
    }

    public static base_response delete(nitro_service client, string name) => new appfwfieldtype()
    {
      name = name
    }.delete_resource(client);

    public static base_response delete(nitro_service client, appfwfieldtype resource) => new appfwfieldtype()
    {
      name = resource.name
    }.delete_resource(client);

    public static base_responses delete(nitro_service client, string[] name)
    {
      base_responses baseResponses = (base_responses) null;
      if (name != null && name.Length > 0)
      {
        appfwfieldtype[] appfwfieldtypeArray = new appfwfieldtype[name.Length];
        for (int index = 0; index < name.Length; ++index)
        {
          appfwfieldtypeArray[index] = new appfwfieldtype();
          appfwfieldtypeArray[index].name = name[index];
        }
        baseResponses = base_resource.delete_bulk_request(client, (base_resource[]) appfwfieldtypeArray);
      }
      return baseResponses;
    }

    public static base_responses delete(
      nitro_service client,
      appfwfieldtype[] resources)
    {
      base_responses baseResponses = (base_responses) null;
      if (resources != null && resources.Length > 0)
      {
        appfwfieldtype[] appfwfieldtypeArray = new appfwfieldtype[resources.Length];
        for (int index = 0; index < resources.Length; ++index)
        {
          appfwfieldtypeArray[index] = new appfwfieldtype();
          appfwfieldtypeArray[index].name = resources[index].name;
        }
        baseResponses = base_resource.delete_bulk_request(client, (base_resource[]) appfwfieldtypeArray);
      }
      return baseResponses;
    }

    public static base_response update(nitro_service client, appfwfieldtype resource) => new appfwfieldtype()
    {
      name = resource.name,
      regex = resource.regex,
      priority = resource.priority,
      comment = resource.comment
    }.update_resource(client);

    public static base_responses update(
      nitro_service client,
      appfwfieldtype[] resources)
    {
      base_responses baseResponses = (base_responses) null;
      if (resources != null && resources.Length > 0)
      {
        appfwfieldtype[] appfwfieldtypeArray = new appfwfieldtype[resources.Length];
        for (int index = 0; index < resources.Length; ++index)
        {
          appfwfieldtypeArray[index] = new appfwfieldtype();
          appfwfieldtypeArray[index].name = resources[index].name;
          appfwfieldtypeArray[index].regex = resources[index].regex;
          appfwfieldtypeArray[index].priority = resources[index].priority;
          appfwfieldtypeArray[index].comment = resources[index].comment;
        }
        baseResponses = base_resource.update_bulk_request(client, (base_resource[]) appfwfieldtypeArray);
      }
      return baseResponses;
    }

    public static appfwfieldtype[] get(nitro_service service) => (appfwfieldtype[]) new appfwfieldtype().get_resources(service, (options) null);

    public static appfwfieldtype[] get(nitro_service service, options option) => (appfwfieldtype[]) new appfwfieldtype().get_resources(service, option);

    public static appfwfieldtype get(nitro_service service, string name) => (appfwfieldtype) new appfwfieldtype()
    {
      name = name
    }.get_resource(service);

    public static appfwfieldtype[] get(nitro_service service, string[] name)
    {
      if (name == null || name.Length <= 0)
        return (appfwfieldtype[]) null;
      appfwfieldtype[] appfwfieldtypeArray1 = new appfwfieldtype[name.Length];
      appfwfieldtype[] appfwfieldtypeArray2 = new appfwfieldtype[name.Length];
      for (int index = 0; index < name.Length; ++index)
      {
        appfwfieldtypeArray2[index] = new appfwfieldtype();
        appfwfieldtypeArray2[index].name = name[index];
        appfwfieldtypeArray1[index] = (appfwfieldtype) appfwfieldtypeArray2[index].get_resource(service);
      }
      return appfwfieldtypeArray1;
    }

    public static appfwfieldtype[] get_filtered(nitro_service service, string filter)
    {
      appfwfieldtype appfwfieldtype = new appfwfieldtype();
      options option = new options();
      option.set_filter(filter);
      return (appfwfieldtype[]) appfwfieldtype.getfiltered(service, option);
    }

    public static appfwfieldtype[] get_filtered(
      nitro_service service,
      filtervalue[] filter)
    {
      appfwfieldtype appfwfieldtype = new appfwfieldtype();
      options option = new options();
      option.set_filter(filter);
      return (appfwfieldtype[]) appfwfieldtype.getfiltered(service, option);
    }

    public static uint count(nitro_service service)
    {
      appfwfieldtype appfwfieldtype = new appfwfieldtype();
      options option = new options();
      option.set_count(true);
      appfwfieldtype[] resources = (appfwfieldtype[]) appfwfieldtype.get_resources(service, option);
      return resources != null && resources.Length > 0 ? resources[0].__count.Value : 0U;
    }

    public static uint count_filtered(nitro_service service, string filter)
    {
      appfwfieldtype appfwfieldtype = new appfwfieldtype();
      options option = new options();
      option.set_count(true);
      option.set_filter(filter);
      appfwfieldtype[] appfwfieldtypeArray = (appfwfieldtype[]) appfwfieldtype.getfiltered(service, option);
      return appfwfieldtypeArray != null && appfwfieldtypeArray.Length > 0 ? appfwfieldtypeArray[0].__count.Value : 0U;
    }

    public static uint count_filtered(nitro_service service, filtervalue[] filter)
    {
      appfwfieldtype appfwfieldtype = new appfwfieldtype();
      options option = new options();
      option.set_count(true);
      option.set_filter(filter);
      appfwfieldtype[] appfwfieldtypeArray = (appfwfieldtype[]) appfwfieldtype.getfiltered(service, option);
      return appfwfieldtypeArray != null && appfwfieldtypeArray.Length > 0 ? appfwfieldtypeArray[0].__count.Value : 0U;
    }

    private class appfwfieldtype_response : base_response
    {
      public appfwfieldtype[] appfwfieldtype = (appfwfieldtype[]) null;
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
