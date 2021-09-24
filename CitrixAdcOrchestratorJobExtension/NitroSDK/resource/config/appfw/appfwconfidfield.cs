// Decompiled with JetBrains decompiler
// Type: com.citrix.netscaler.nitro.resource.config.appfw.appfwconfidfield
// Assembly: nitro, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 6CF5DDEF-E052-4F9D-953F-6644F8378A66


using com.citrix.netscaler.nitro.exception;
using com.citrix.netscaler.nitro.resource.Base;
using com.citrix.netscaler.nitro.service;
using com.citrix.netscaler.nitro.util;

namespace com.citrix.netscaler.nitro.resource.config.appfw
{
  public class appfwconfidfield : base_resource
  {
    private string fieldnameField = (string) null;
    private string urlField = (string) null;
    private string isregexField = (string) null;
    private string commentField = (string) null;
    private string stateField = (string) null;
    private uint? __countField = new uint?();

    public uint? __count
    {
      get => this.__countField;
      private set => this.__countField = value;
    }

    public string fieldname
    {
      get => this.fieldnameField;
      set => this.fieldnameField = value;
    }

    public string url
    {
      get => this.urlField;
      set => this.urlField = value;
    }

    public string isregex
    {
      get => this.isregexField;
      set => this.isregexField = value;
    }

    public string comment
    {
      get => this.commentField;
      set => this.commentField = value;
    }

    public string state
    {
      get => this.stateField;
      set => this.stateField = value;
    }

    internal override base_resource[] get_nitro_response(
      nitro_service service,
      string response)
    {
      appfwconfidfield.appfwconfidfield_response appfwconfidfieldResponse = new appfwconfidfield.appfwconfidfield_response();
      appfwconfidfield.appfwconfidfield_response resource = (appfwconfidfield.appfwconfidfield_response) service.get_payload_formatter().string_to_resource(appfwconfidfieldResponse.GetType(), response);
      if (resource.errorcode != 0)
      {
        if (resource.errorcode == 444)
          service.clear_session();
        if (resource.severity == null)
          throw new nitro_exception(resource.message, resource.errorcode);
        if (resource.severity.Equals("ERROR"))
          throw new nitro_exception(resource.message, resource.errorcode);
      }
      return (base_resource[]) resource.appfwconfidfield;
    }

    internal override string get_object_name() => this.fieldname;

    public static base_response add(nitro_service client, appfwconfidfield resource) => new appfwconfidfield()
    {
      fieldname = resource.fieldname,
      url = resource.url,
      isregex = resource.isregex,
      comment = resource.comment,
      state = resource.state
    }.add_resource(client);

    public static base_responses add(
      nitro_service client,
      appfwconfidfield[] resources)
    {
      base_responses baseResponses = (base_responses) null;
      if (resources != null && resources.Length > 0)
      {
        appfwconfidfield[] appfwconfidfieldArray = new appfwconfidfield[resources.Length];
        for (int index = 0; index < resources.Length; ++index)
        {
          appfwconfidfieldArray[index] = new appfwconfidfield();
          appfwconfidfieldArray[index].fieldname = resources[index].fieldname;
          appfwconfidfieldArray[index].url = resources[index].url;
          appfwconfidfieldArray[index].isregex = resources[index].isregex;
          appfwconfidfieldArray[index].comment = resources[index].comment;
          appfwconfidfieldArray[index].state = resources[index].state;
        }
        baseResponses = base_resource.add_bulk_request(client, (base_resource[]) appfwconfidfieldArray);
      }
      return baseResponses;
    }

    public static base_response delete(nitro_service client, string fieldname) => new appfwconfidfield()
    {
      fieldname = fieldname
    }.delete_resource(client);

    public static base_response delete(nitro_service client, appfwconfidfield resource) => new appfwconfidfield()
    {
      fieldname = resource.fieldname,
      url = resource.url
    }.delete_resource(client);

    public static base_responses delete(nitro_service client, string[] fieldname)
    {
      base_responses baseResponses = (base_responses) null;
      if (fieldname != null && fieldname.Length > 0)
      {
        appfwconfidfield[] appfwconfidfieldArray = new appfwconfidfield[fieldname.Length];
        for (int index = 0; index < fieldname.Length; ++index)
        {
          appfwconfidfieldArray[index] = new appfwconfidfield();
          appfwconfidfieldArray[index].fieldname = fieldname[index];
        }
        baseResponses = base_resource.delete_bulk_request(client, (base_resource[]) appfwconfidfieldArray);
      }
      return baseResponses;
    }

    public static base_responses delete(
      nitro_service client,
      appfwconfidfield[] resources)
    {
      base_responses baseResponses = (base_responses) null;
      if (resources != null && resources.Length > 0)
      {
        appfwconfidfield[] appfwconfidfieldArray = new appfwconfidfield[resources.Length];
        for (int index = 0; index < resources.Length; ++index)
        {
          appfwconfidfieldArray[index] = new appfwconfidfield();
          appfwconfidfieldArray[index].fieldname = resources[index].fieldname;
          appfwconfidfieldArray[index].url = resources[index].url;
        }
        baseResponses = base_resource.delete_bulk_request(client, (base_resource[]) appfwconfidfieldArray);
      }
      return baseResponses;
    }

    public static base_response update(nitro_service client, appfwconfidfield resource) => new appfwconfidfield()
    {
      fieldname = resource.fieldname,
      url = resource.url,
      comment = resource.comment,
      isregex = resource.isregex,
      state = resource.state
    }.update_resource(client);

    public static base_responses update(
      nitro_service client,
      appfwconfidfield[] resources)
    {
      base_responses baseResponses = (base_responses) null;
      if (resources != null && resources.Length > 0)
      {
        appfwconfidfield[] appfwconfidfieldArray = new appfwconfidfield[resources.Length];
        for (int index = 0; index < resources.Length; ++index)
        {
          appfwconfidfieldArray[index] = new appfwconfidfield();
          appfwconfidfieldArray[index].fieldname = resources[index].fieldname;
          appfwconfidfieldArray[index].url = resources[index].url;
          appfwconfidfieldArray[index].comment = resources[index].comment;
          appfwconfidfieldArray[index].isregex = resources[index].isregex;
          appfwconfidfieldArray[index].state = resources[index].state;
        }
        baseResponses = base_resource.update_bulk_request(client, (base_resource[]) appfwconfidfieldArray);
      }
      return baseResponses;
    }

    public static base_response unset(
      nitro_service client,
      appfwconfidfield resource,
      string[] args)
    {
      return new appfwconfidfield()
      {
        fieldname = resource.fieldname,
        url = resource.url
      }.unset_resource(client, args);
    }

    public static base_responses unset(
      nitro_service client,
      appfwconfidfield[] resources,
      string[] args)
    {
      base_responses baseResponses = (base_responses) null;
      if (resources != null && resources.Length > 0)
      {
        appfwconfidfield[] appfwconfidfieldArray = new appfwconfidfield[resources.Length];
        for (int index = 0; index < resources.Length; ++index)
        {
          appfwconfidfieldArray[index] = new appfwconfidfield();
          appfwconfidfieldArray[index].fieldname = resources[index].fieldname;
          appfwconfidfieldArray[index].url = resources[index].url;
        }
        baseResponses = base_resource.unset_bulk_request(client, (base_resource[]) appfwconfidfieldArray, args);
      }
      return baseResponses;
    }

    public static appfwconfidfield[] get(nitro_service service) => (appfwconfidfield[]) new appfwconfidfield().get_resources(service, (options) null);

    public static appfwconfidfield[] get(nitro_service service, options option) => (appfwconfidfield[]) new appfwconfidfield().get_resources(service, option);

    public static appfwconfidfield get(nitro_service service, appfwconfidfield obj)
    {
      options option = new options();
      option.set_args(nitro_util.object_to_string_withoutquotes((object) obj));
      return (appfwconfidfield) obj.get_resource(service, option);
    }

    public static appfwconfidfield[] get(
      nitro_service service,
      appfwconfidfield[] obj)
    {
      if (obj == null || obj.Length <= 0)
        return (appfwconfidfield[]) null;
      appfwconfidfield[] appfwconfidfieldArray = new appfwconfidfield[obj.Length];
      for (int index = 0; index < obj.Length; ++index)
      {
        options option = new options();
        option.set_args(nitro_util.object_to_string_withoutquotes((object) obj[index]));
        appfwconfidfieldArray[index] = (appfwconfidfield) obj[index].get_resource(service, option);
      }
      return appfwconfidfieldArray;
    }

    public static appfwconfidfield[] get_filtered(
      nitro_service service,
      string filter)
    {
      appfwconfidfield appfwconfidfield = new appfwconfidfield();
      options option = new options();
      option.set_filter(filter);
      return (appfwconfidfield[]) appfwconfidfield.getfiltered(service, option);
    }

    public static appfwconfidfield[] get_filtered(
      nitro_service service,
      filtervalue[] filter)
    {
      appfwconfidfield appfwconfidfield = new appfwconfidfield();
      options option = new options();
      option.set_filter(filter);
      return (appfwconfidfield[]) appfwconfidfield.getfiltered(service, option);
    }

    public static uint count(nitro_service service)
    {
      appfwconfidfield appfwconfidfield = new appfwconfidfield();
      options option = new options();
      option.set_count(true);
      appfwconfidfield[] resources = (appfwconfidfield[]) appfwconfidfield.get_resources(service, option);
      return resources != null && resources.Length > 0 ? resources[0].__count.Value : 0U;
    }

    public static uint count_filtered(nitro_service service, string filter)
    {
      appfwconfidfield appfwconfidfield = new appfwconfidfield();
      options option = new options();
      option.set_count(true);
      option.set_filter(filter);
      appfwconfidfield[] appfwconfidfieldArray = (appfwconfidfield[]) appfwconfidfield.getfiltered(service, option);
      return appfwconfidfieldArray != null && appfwconfidfieldArray.Length > 0 ? appfwconfidfieldArray[0].__count.Value : 0U;
    }

    public static uint count_filtered(nitro_service service, filtervalue[] filter)
    {
      appfwconfidfield appfwconfidfield = new appfwconfidfield();
      options option = new options();
      option.set_count(true);
      option.set_filter(filter);
      appfwconfidfield[] appfwconfidfieldArray = (appfwconfidfield[]) appfwconfidfield.getfiltered(service, option);
      return appfwconfidfieldArray != null && appfwconfidfieldArray.Length > 0 ? appfwconfidfieldArray[0].__count.Value : 0U;
    }

    private class appfwconfidfield_response : base_response
    {
      public appfwconfidfield[] appfwconfidfield = (appfwconfidfield[]) null;
    }

    public static class stateEnum
    {
      public const string ENABLED = "ENABLED";
      public const string DISABLED = "DISABLED";
    }

    public static class isregexEnum
    {
      public const string REGEX = "REGEX";
      public const string NOTREGEX = "NOTREGEX";
    }
  }
}
