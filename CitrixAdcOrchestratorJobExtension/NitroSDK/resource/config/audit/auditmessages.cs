// Decompiled with JetBrains decompiler
// Type: com.citrix.netscaler.nitro.resource.config.audit.auditmessages
// Assembly: nitro, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 6CF5DDEF-E052-4F9D-953F-6644F8378A66


using com.citrix.netscaler.nitro.exception;
using com.citrix.netscaler.nitro.resource.Base;
using com.citrix.netscaler.nitro.service;
using com.citrix.netscaler.nitro.util;

namespace com.citrix.netscaler.nitro.resource.config.audit
{
  public class auditmessages : base_resource
  {
    private string[] loglevelField = (string[]) null;
    private uint? numofmesgsField = new uint?();
    private string valueField = (string) null;
    private uint? __countField = new uint?();

    public uint? __count
    {
      get => this.__countField;
      private set => this.__countField = value;
    }

    public string[] loglevel
    {
      get => this.loglevelField;
      set => this.loglevelField = value;
    }

    public uint? numofmesgs
    {
      get => this.numofmesgsField;
      set => this.numofmesgsField = value;
    }

    public string value
    {
      get => this.valueField;
      private set => this.valueField = value;
    }

    internal override base_resource[] get_nitro_response(
      nitro_service service,
      string response)
    {
      auditmessages.auditmessages_response auditmessagesResponse = new auditmessages.auditmessages_response();
      auditmessages.auditmessages_response resource = (auditmessages.auditmessages_response) service.get_payload_formatter().string_to_resource(auditmessagesResponse.GetType(), response);
      if (resource.errorcode != 0)
      {
        if (resource.errorcode == 444)
          service.clear_session();
        if (resource.severity == null)
          throw new nitro_exception(resource.message, resource.errorcode);
        if (resource.severity.Equals("ERROR"))
          throw new nitro_exception(resource.message, resource.errorcode);
      }
      return (base_resource[]) resource.auditmessages;
    }

    internal override string get_object_name() => (string) null;

    public static auditmessages[] get(nitro_service service) => (auditmessages[]) new auditmessages().get_resources(service, (options) null);

    public static auditmessages[] get(nitro_service service, options option) => (auditmessages[]) new auditmessages().get_resources(service, option);

    public static auditmessages[] get(nitro_service service, auditmessages_args args)
    {
      auditmessages auditmessages = new auditmessages();
      options option = new options();
      option.set_args(nitro_util.object_to_string_withoutquotes((object) args));
      return (auditmessages[]) auditmessages.get_resources(service, option);
    }

    public static auditmessages[] get_filtered(nitro_service service, string filter)
    {
      auditmessages auditmessages = new auditmessages();
      options option = new options();
      option.set_filter(filter);
      return (auditmessages[]) auditmessages.getfiltered(service, option);
    }

    public static auditmessages[] get_filtered(
      nitro_service service,
      filtervalue[] filter)
    {
      auditmessages auditmessages = new auditmessages();
      options option = new options();
      option.set_filter(filter);
      return (auditmessages[]) auditmessages.getfiltered(service, option);
    }

    public static uint count(nitro_service service)
    {
      auditmessages auditmessages = new auditmessages();
      options option = new options();
      option.set_count(true);
      auditmessages[] resources = (auditmessages[]) auditmessages.get_resources(service, option);
      return resources != null && resources.Length > 0 ? resources[0].__count.Value : 0U;
    }

    public static uint count_filtered(nitro_service service, string filter)
    {
      auditmessages auditmessages = new auditmessages();
      options option = new options();
      option.set_count(true);
      option.set_filter(filter);
      auditmessages[] auditmessagesArray = (auditmessages[]) auditmessages.getfiltered(service, option);
      return auditmessagesArray != null && auditmessagesArray.Length > 0 ? auditmessagesArray[0].__count.Value : 0U;
    }

    public static uint count_filtered(nitro_service service, filtervalue[] filter)
    {
      auditmessages auditmessages = new auditmessages();
      options option = new options();
      option.set_count(true);
      option.set_filter(filter);
      auditmessages[] auditmessagesArray = (auditmessages[]) auditmessages.getfiltered(service, option);
      return auditmessagesArray != null && auditmessagesArray.Length > 0 ? auditmessagesArray[0].__count.Value : 0U;
    }

    private class auditmessages_response : base_response
    {
      public auditmessages[] auditmessages = (auditmessages[]) null;
    }

    public static class loglevelEnum
    {
      public const string ALL = "ALL";
      public const string EMERGENCY = "EMERGENCY";
      public const string ALERT = "ALERT";
      public const string CRITICAL = "CRITICAL";
      public const string ERROR = "ERROR";
      public const string WARNING = "WARNING";
      public const string NOTICE = "NOTICE";
      public const string INFORMATIONAL = "INFORMATIONAL";
      public const string DEBUG = "DEBUG";
    }
  }
}
