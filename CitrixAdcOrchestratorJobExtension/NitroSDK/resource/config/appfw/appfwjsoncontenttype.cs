// Decompiled with JetBrains decompiler
// Type: com.citrix.netscaler.nitro.resource.config.appfw.appfwjsoncontenttype
// Assembly: nitro, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 6CF5DDEF-E052-4F9D-953F-6644F8378A66


using com.citrix.netscaler.nitro.exception;
using com.citrix.netscaler.nitro.resource.Base;
using com.citrix.netscaler.nitro.service;
using com.citrix.netscaler.nitro.util;

namespace com.citrix.netscaler.nitro.resource.config.appfw
{
  public class appfwjsoncontenttype : base_resource
  {
    private string jsoncontenttypevalueField = (string) null;
    private string isregexField = (string) null;
    private string[] builtinField = (string[]) null;
    private uint? __countField = new uint?();

    public uint? __count
    {
      get => this.__countField;
      private set => this.__countField = value;
    }

    public string jsoncontenttypevalue
    {
      get => this.jsoncontenttypevalueField;
      set => this.jsoncontenttypevalueField = value;
    }

    public string isregex
    {
      get => this.isregexField;
      set => this.isregexField = value;
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
      appfwjsoncontenttype.appfwjsoncontenttype_response appfwjsoncontenttypeResponse = new appfwjsoncontenttype.appfwjsoncontenttype_response();
      appfwjsoncontenttype.appfwjsoncontenttype_response resource = (appfwjsoncontenttype.appfwjsoncontenttype_response) service.get_payload_formatter().string_to_resource(appfwjsoncontenttypeResponse.GetType(), response);
      if (resource.errorcode != 0)
      {
        if (resource.errorcode == 444)
          service.clear_session();
        if (resource.severity == null)
          throw new nitro_exception(resource.message, resource.errorcode);
        if (resource.severity.Equals("ERROR"))
          throw new nitro_exception(resource.message, resource.errorcode);
      }
      return (base_resource[]) resource.appfwjsoncontenttype;
    }

    internal override string get_object_name() => this.jsoncontenttypevalue;

    public static base_response add(
      nitro_service client,
      appfwjsoncontenttype resource)
    {
      return new appfwjsoncontenttype()
      {
        jsoncontenttypevalue = resource.jsoncontenttypevalue,
        isregex = resource.isregex
      }.add_resource(client);
    }

    public static base_responses add(
      nitro_service client,
      appfwjsoncontenttype[] resources)
    {
      base_responses baseResponses = (base_responses) null;
      if (resources != null && resources.Length > 0)
      {
        appfwjsoncontenttype[] appfwjsoncontenttypeArray = new appfwjsoncontenttype[resources.Length];
        for (int index = 0; index < resources.Length; ++index)
        {
          appfwjsoncontenttypeArray[index] = new appfwjsoncontenttype();
          appfwjsoncontenttypeArray[index].jsoncontenttypevalue = resources[index].jsoncontenttypevalue;
          appfwjsoncontenttypeArray[index].isregex = resources[index].isregex;
        }
        baseResponses = base_resource.add_bulk_request(client, (base_resource[]) appfwjsoncontenttypeArray);
      }
      return baseResponses;
    }

    public static base_response delete(
      nitro_service client,
      string jsoncontenttypevalue)
    {
      return new appfwjsoncontenttype()
      {
        jsoncontenttypevalue = jsoncontenttypevalue
      }.delete_resource(client);
    }

    public static base_response delete(
      nitro_service client,
      appfwjsoncontenttype resource)
    {
      return new appfwjsoncontenttype()
      {
        jsoncontenttypevalue = resource.jsoncontenttypevalue
      }.delete_resource(client);
    }

    public static base_responses delete(
      nitro_service client,
      string[] jsoncontenttypevalue)
    {
      base_responses baseResponses = (base_responses) null;
      if (jsoncontenttypevalue != null && jsoncontenttypevalue.Length > 0)
      {
        appfwjsoncontenttype[] appfwjsoncontenttypeArray = new appfwjsoncontenttype[jsoncontenttypevalue.Length];
        for (int index = 0; index < jsoncontenttypevalue.Length; ++index)
        {
          appfwjsoncontenttypeArray[index] = new appfwjsoncontenttype();
          appfwjsoncontenttypeArray[index].jsoncontenttypevalue = jsoncontenttypevalue[index];
        }
        baseResponses = base_resource.delete_bulk_request(client, (base_resource[]) appfwjsoncontenttypeArray);
      }
      return baseResponses;
    }

    public static base_responses delete(
      nitro_service client,
      appfwjsoncontenttype[] resources)
    {
      base_responses baseResponses = (base_responses) null;
      if (resources != null && resources.Length > 0)
      {
        appfwjsoncontenttype[] appfwjsoncontenttypeArray = new appfwjsoncontenttype[resources.Length];
        for (int index = 0; index < resources.Length; ++index)
        {
          appfwjsoncontenttypeArray[index] = new appfwjsoncontenttype();
          appfwjsoncontenttypeArray[index].jsoncontenttypevalue = resources[index].jsoncontenttypevalue;
        }
        baseResponses = base_resource.delete_bulk_request(client, (base_resource[]) appfwjsoncontenttypeArray);
      }
      return baseResponses;
    }

    public static appfwjsoncontenttype[] get(nitro_service service) => (appfwjsoncontenttype[]) new appfwjsoncontenttype().get_resources(service, (options) null);

    public static appfwjsoncontenttype[] get(
      nitro_service service,
      options option)
    {
      return (appfwjsoncontenttype[]) new appfwjsoncontenttype().get_resources(service, option);
    }

    public static appfwjsoncontenttype get(
      nitro_service service,
      string jsoncontenttypevalue)
    {
      return (appfwjsoncontenttype) new appfwjsoncontenttype()
      {
        jsoncontenttypevalue = jsoncontenttypevalue
      }.get_resource(service);
    }

    public static appfwjsoncontenttype[] get(
      nitro_service service,
      string[] jsoncontenttypevalue)
    {
      if (jsoncontenttypevalue == null || jsoncontenttypevalue.Length <= 0)
        return (appfwjsoncontenttype[]) null;
      appfwjsoncontenttype[] appfwjsoncontenttypeArray1 = new appfwjsoncontenttype[jsoncontenttypevalue.Length];
      appfwjsoncontenttype[] appfwjsoncontenttypeArray2 = new appfwjsoncontenttype[jsoncontenttypevalue.Length];
      for (int index = 0; index < jsoncontenttypevalue.Length; ++index)
      {
        appfwjsoncontenttypeArray2[index] = new appfwjsoncontenttype();
        appfwjsoncontenttypeArray2[index].jsoncontenttypevalue = jsoncontenttypevalue[index];
        appfwjsoncontenttypeArray1[index] = (appfwjsoncontenttype) appfwjsoncontenttypeArray2[index].get_resource(service);
      }
      return appfwjsoncontenttypeArray1;
    }

    public static appfwjsoncontenttype[] get_filtered(
      nitro_service service,
      string filter)
    {
      appfwjsoncontenttype appfwjsoncontenttype = new appfwjsoncontenttype();
      options option = new options();
      option.set_filter(filter);
      return (appfwjsoncontenttype[]) appfwjsoncontenttype.getfiltered(service, option);
    }

    public static appfwjsoncontenttype[] get_filtered(
      nitro_service service,
      filtervalue[] filter)
    {
      appfwjsoncontenttype appfwjsoncontenttype = new appfwjsoncontenttype();
      options option = new options();
      option.set_filter(filter);
      return (appfwjsoncontenttype[]) appfwjsoncontenttype.getfiltered(service, option);
    }

    public static uint count(nitro_service service)
    {
      appfwjsoncontenttype appfwjsoncontenttype = new appfwjsoncontenttype();
      options option = new options();
      option.set_count(true);
      appfwjsoncontenttype[] resources = (appfwjsoncontenttype[]) appfwjsoncontenttype.get_resources(service, option);
      return resources != null && resources.Length > 0 ? resources[0].__count.Value : 0U;
    }

    public static uint count_filtered(nitro_service service, string filter)
    {
      appfwjsoncontenttype appfwjsoncontenttype = new appfwjsoncontenttype();
      options option = new options();
      option.set_count(true);
      option.set_filter(filter);
      appfwjsoncontenttype[] appfwjsoncontenttypeArray = (appfwjsoncontenttype[]) appfwjsoncontenttype.getfiltered(service, option);
      return appfwjsoncontenttypeArray != null && appfwjsoncontenttypeArray.Length > 0 ? appfwjsoncontenttypeArray[0].__count.Value : 0U;
    }

    public static uint count_filtered(nitro_service service, filtervalue[] filter)
    {
      appfwjsoncontenttype appfwjsoncontenttype = new appfwjsoncontenttype();
      options option = new options();
      option.set_count(true);
      option.set_filter(filter);
      appfwjsoncontenttype[] appfwjsoncontenttypeArray = (appfwjsoncontenttype[]) appfwjsoncontenttype.getfiltered(service, option);
      return appfwjsoncontenttypeArray != null && appfwjsoncontenttypeArray.Length > 0 ? appfwjsoncontenttypeArray[0].__count.Value : 0U;
    }

    private class appfwjsoncontenttype_response : base_response
    {
      public appfwjsoncontenttype[] appfwjsoncontenttype = (appfwjsoncontenttype[]) null;
    }

    public static class builtinEnum
    {
      public const string MODIFIABLE = "MODIFIABLE";
      public const string DELETABLE = "DELETABLE";
      public const string IMMUTABLE = "IMMUTABLE";
      public const string PARTITION_ALL = "PARTITION_ALL";
    }

    public static class isregexEnum
    {
      public const string REGEX = "REGEX";
      public const string NOTREGEX = "NOTREGEX";
    }
  }
}
