// Decompiled with JetBrains decompiler
// Type: com.citrix.netscaler.nitro.resource.config.appfw.appfwxmlcontenttype
// Assembly: nitro, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 6CF5DDEF-E052-4F9D-953F-6644F8378A66


using com.citrix.netscaler.nitro.exception;
using com.citrix.netscaler.nitro.resource.Base;
using com.citrix.netscaler.nitro.service;
using com.citrix.netscaler.nitro.util;

namespace com.citrix.netscaler.nitro.resource.config.appfw
{
  public class appfwxmlcontenttype : base_resource
  {
    private string xmlcontenttypevalueField = (string) null;
    private string isregexField = (string) null;
    private string[] builtinField = (string[]) null;
    private uint? __countField = new uint?();

    public uint? __count
    {
      get => this.__countField;
      private set => this.__countField = value;
    }

    public string xmlcontenttypevalue
    {
      get => this.xmlcontenttypevalueField;
      set => this.xmlcontenttypevalueField = value;
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
      appfwxmlcontenttype.appfwxmlcontenttype_response appfwxmlcontenttypeResponse = new appfwxmlcontenttype.appfwxmlcontenttype_response();
      appfwxmlcontenttype.appfwxmlcontenttype_response resource = (appfwxmlcontenttype.appfwxmlcontenttype_response) service.get_payload_formatter().string_to_resource(appfwxmlcontenttypeResponse.GetType(), response);
      if (resource.errorcode != 0)
      {
        if (resource.errorcode == 444)
          service.clear_session();
        if (resource.severity == null)
          throw new nitro_exception(resource.message, resource.errorcode);
        if (resource.severity.Equals("ERROR"))
          throw new nitro_exception(resource.message, resource.errorcode);
      }
      return (base_resource[]) resource.appfwxmlcontenttype;
    }

    internal override string get_object_name() => this.xmlcontenttypevalue;

    public static base_response add(nitro_service client, appfwxmlcontenttype resource) => new appfwxmlcontenttype()
    {
      xmlcontenttypevalue = resource.xmlcontenttypevalue,
      isregex = resource.isregex
    }.add_resource(client);

    public static base_responses add(
      nitro_service client,
      appfwxmlcontenttype[] resources)
    {
      base_responses baseResponses = (base_responses) null;
      if (resources != null && resources.Length > 0)
      {
        appfwxmlcontenttype[] appfwxmlcontenttypeArray = new appfwxmlcontenttype[resources.Length];
        for (int index = 0; index < resources.Length; ++index)
        {
          appfwxmlcontenttypeArray[index] = new appfwxmlcontenttype();
          appfwxmlcontenttypeArray[index].xmlcontenttypevalue = resources[index].xmlcontenttypevalue;
          appfwxmlcontenttypeArray[index].isregex = resources[index].isregex;
        }
        baseResponses = base_resource.add_bulk_request(client, (base_resource[]) appfwxmlcontenttypeArray);
      }
      return baseResponses;
    }

    public static base_response delete(
      nitro_service client,
      string xmlcontenttypevalue)
    {
      return new appfwxmlcontenttype()
      {
        xmlcontenttypevalue = xmlcontenttypevalue
      }.delete_resource(client);
    }

    public static base_response delete(
      nitro_service client,
      appfwxmlcontenttype resource)
    {
      return new appfwxmlcontenttype()
      {
        xmlcontenttypevalue = resource.xmlcontenttypevalue
      }.delete_resource(client);
    }

    public static base_responses delete(
      nitro_service client,
      string[] xmlcontenttypevalue)
    {
      base_responses baseResponses = (base_responses) null;
      if (xmlcontenttypevalue != null && xmlcontenttypevalue.Length > 0)
      {
        appfwxmlcontenttype[] appfwxmlcontenttypeArray = new appfwxmlcontenttype[xmlcontenttypevalue.Length];
        for (int index = 0; index < xmlcontenttypevalue.Length; ++index)
        {
          appfwxmlcontenttypeArray[index] = new appfwxmlcontenttype();
          appfwxmlcontenttypeArray[index].xmlcontenttypevalue = xmlcontenttypevalue[index];
        }
        baseResponses = base_resource.delete_bulk_request(client, (base_resource[]) appfwxmlcontenttypeArray);
      }
      return baseResponses;
    }

    public static base_responses delete(
      nitro_service client,
      appfwxmlcontenttype[] resources)
    {
      base_responses baseResponses = (base_responses) null;
      if (resources != null && resources.Length > 0)
      {
        appfwxmlcontenttype[] appfwxmlcontenttypeArray = new appfwxmlcontenttype[resources.Length];
        for (int index = 0; index < resources.Length; ++index)
        {
          appfwxmlcontenttypeArray[index] = new appfwxmlcontenttype();
          appfwxmlcontenttypeArray[index].xmlcontenttypevalue = resources[index].xmlcontenttypevalue;
        }
        baseResponses = base_resource.delete_bulk_request(client, (base_resource[]) appfwxmlcontenttypeArray);
      }
      return baseResponses;
    }

    public static appfwxmlcontenttype[] get(nitro_service service) => (appfwxmlcontenttype[]) new appfwxmlcontenttype().get_resources(service, (options) null);

    public static appfwxmlcontenttype[] get(
      nitro_service service,
      options option)
    {
      return (appfwxmlcontenttype[]) new appfwxmlcontenttype().get_resources(service, option);
    }

    public static appfwxmlcontenttype get(
      nitro_service service,
      string xmlcontenttypevalue)
    {
      return (appfwxmlcontenttype) new appfwxmlcontenttype()
      {
        xmlcontenttypevalue = xmlcontenttypevalue
      }.get_resource(service);
    }

    public static appfwxmlcontenttype[] get(
      nitro_service service,
      string[] xmlcontenttypevalue)
    {
      if (xmlcontenttypevalue == null || xmlcontenttypevalue.Length <= 0)
        return (appfwxmlcontenttype[]) null;
      appfwxmlcontenttype[] appfwxmlcontenttypeArray1 = new appfwxmlcontenttype[xmlcontenttypevalue.Length];
      appfwxmlcontenttype[] appfwxmlcontenttypeArray2 = new appfwxmlcontenttype[xmlcontenttypevalue.Length];
      for (int index = 0; index < xmlcontenttypevalue.Length; ++index)
      {
        appfwxmlcontenttypeArray2[index] = new appfwxmlcontenttype();
        appfwxmlcontenttypeArray2[index].xmlcontenttypevalue = xmlcontenttypevalue[index];
        appfwxmlcontenttypeArray1[index] = (appfwxmlcontenttype) appfwxmlcontenttypeArray2[index].get_resource(service);
      }
      return appfwxmlcontenttypeArray1;
    }

    public static appfwxmlcontenttype[] get_filtered(
      nitro_service service,
      string filter)
    {
      appfwxmlcontenttype appfwxmlcontenttype = new appfwxmlcontenttype();
      options option = new options();
      option.set_filter(filter);
      return (appfwxmlcontenttype[]) appfwxmlcontenttype.getfiltered(service, option);
    }

    public static appfwxmlcontenttype[] get_filtered(
      nitro_service service,
      filtervalue[] filter)
    {
      appfwxmlcontenttype appfwxmlcontenttype = new appfwxmlcontenttype();
      options option = new options();
      option.set_filter(filter);
      return (appfwxmlcontenttype[]) appfwxmlcontenttype.getfiltered(service, option);
    }

    public static uint count(nitro_service service)
    {
      appfwxmlcontenttype appfwxmlcontenttype = new appfwxmlcontenttype();
      options option = new options();
      option.set_count(true);
      appfwxmlcontenttype[] resources = (appfwxmlcontenttype[]) appfwxmlcontenttype.get_resources(service, option);
      return resources != null && resources.Length > 0 ? resources[0].__count.Value : 0U;
    }

    public static uint count_filtered(nitro_service service, string filter)
    {
      appfwxmlcontenttype appfwxmlcontenttype = new appfwxmlcontenttype();
      options option = new options();
      option.set_count(true);
      option.set_filter(filter);
      appfwxmlcontenttype[] appfwxmlcontenttypeArray = (appfwxmlcontenttype[]) appfwxmlcontenttype.getfiltered(service, option);
      return appfwxmlcontenttypeArray != null && appfwxmlcontenttypeArray.Length > 0 ? appfwxmlcontenttypeArray[0].__count.Value : 0U;
    }

    public static uint count_filtered(nitro_service service, filtervalue[] filter)
    {
      appfwxmlcontenttype appfwxmlcontenttype = new appfwxmlcontenttype();
      options option = new options();
      option.set_count(true);
      option.set_filter(filter);
      appfwxmlcontenttype[] appfwxmlcontenttypeArray = (appfwxmlcontenttype[]) appfwxmlcontenttype.getfiltered(service, option);
      return appfwxmlcontenttypeArray != null && appfwxmlcontenttypeArray.Length > 0 ? appfwxmlcontenttypeArray[0].__count.Value : 0U;
    }

    private class appfwxmlcontenttype_response : base_response
    {
      public appfwxmlcontenttype[] appfwxmlcontenttype = (appfwxmlcontenttype[]) null;
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
