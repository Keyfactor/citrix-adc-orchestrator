// Decompiled with JetBrains decompiler
// Type: com.citrix.netscaler.nitro.resource.config.basic.locationparameter
// Assembly: nitro, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 6CF5DDEF-E052-4F9D-953F-6644F8378A66


using com.citrix.netscaler.nitro.exception;
using com.citrix.netscaler.nitro.resource.Base;
using com.citrix.netscaler.nitro.service;

namespace com.citrix.netscaler.nitro.resource.config.basic
{
  public class locationparameter : base_resource
  {
    private string contextField = (string) null;
    private string q1labelField = (string) null;
    private string q2labelField = (string) null;
    private string q3labelField = (string) null;
    private string q4labelField = (string) null;
    private string q5labelField = (string) null;
    private string q6labelField = (string) null;
    private string LocationfileField = (string) null;
    private string formatField = (string) null;
    private uint? customField = new uint?();
    private uint? StaticField = new uint?();
    private uint? linesField = new uint?();
    private uint? errorsField = new uint?();
    private uint? warningsField = new uint?();
    private uint? entriesField = new uint?();
    private string locationfile6Field = (string) null;
    private string format6Field = (string) null;
    private uint? custom6Field = new uint?();
    private uint? static6Field = new uint?();
    private uint? lines6Field = new uint?();
    private uint? errors6Field = new uint?();
    private uint? warnings6Field = new uint?();
    private uint? entries6Field = new uint?();
    private uint? flagsField = new uint?();
    private uint? statusField = new uint?();
    private string databasemodeField = (string) null;
    private string flushingField = (string) null;
    private string loadingField = (string) null;

    public string context
    {
      get => this.contextField;
      set => this.contextField = value;
    }

    public string q1label
    {
      get => this.q1labelField;
      set => this.q1labelField = value;
    }

    public string q2label
    {
      get => this.q2labelField;
      set => this.q2labelField = value;
    }

    public string q3label
    {
      get => this.q3labelField;
      set => this.q3labelField = value;
    }

    public string q4label
    {
      get => this.q4labelField;
      set => this.q4labelField = value;
    }

    public string q5label
    {
      get => this.q5labelField;
      set => this.q5labelField = value;
    }

    public string q6label
    {
      get => this.q6labelField;
      set => this.q6labelField = value;
    }

    public string Locationfile
    {
      get => this.LocationfileField;
      private set => this.LocationfileField = value;
    }

    public string format
    {
      get => this.formatField;
      private set => this.formatField = value;
    }

    public uint? custom
    {
      get => this.customField;
      private set => this.customField = value;
    }

    public uint? Static
    {
      get => this.StaticField;
      private set => this.StaticField = value;
    }

    public uint? lines
    {
      get => this.linesField;
      private set => this.linesField = value;
    }

    public uint? errors
    {
      get => this.errorsField;
      private set => this.errorsField = value;
    }

    public uint? warnings
    {
      get => this.warningsField;
      private set => this.warningsField = value;
    }

    public uint? entries
    {
      get => this.entriesField;
      private set => this.entriesField = value;
    }

    public string locationfile6
    {
      get => this.locationfile6Field;
      private set => this.locationfile6Field = value;
    }

    public string format6
    {
      get => this.format6Field;
      private set => this.format6Field = value;
    }

    public uint? custom6
    {
      get => this.custom6Field;
      private set => this.custom6Field = value;
    }

    public uint? static6
    {
      get => this.static6Field;
      private set => this.static6Field = value;
    }

    public uint? lines6
    {
      get => this.lines6Field;
      private set => this.lines6Field = value;
    }

    public uint? errors6
    {
      get => this.errors6Field;
      private set => this.errors6Field = value;
    }

    public uint? warnings6
    {
      get => this.warnings6Field;
      private set => this.warnings6Field = value;
    }

    public uint? entries6
    {
      get => this.entries6Field;
      private set => this.entries6Field = value;
    }

    public uint? flags
    {
      get => this.flagsField;
      private set => this.flagsField = value;
    }

    public uint? status
    {
      get => this.statusField;
      private set => this.statusField = value;
    }

    public string databasemode
    {
      get => this.databasemodeField;
      private set => this.databasemodeField = value;
    }

    public string flushing
    {
      get => this.flushingField;
      private set => this.flushingField = value;
    }

    public string loading
    {
      get => this.loadingField;
      private set => this.loadingField = value;
    }

    internal override base_resource[] get_nitro_response(
      nitro_service service,
      string response)
    {
      locationparameter[] locationparameterArray = new locationparameter[1];
      locationparameter.locationparameter_response locationparameterResponse = new locationparameter.locationparameter_response();
      locationparameter.locationparameter_response resource = (locationparameter.locationparameter_response) service.get_payload_formatter().string_to_resource(locationparameterResponse.GetType(), response);
      if (resource.errorcode != 0)
      {
        if (resource.errorcode == 444)
          service.clear_session();
        if (resource.severity == null)
          throw new nitro_exception(resource.message, resource.errorcode);
        if (resource.severity.Equals("ERROR"))
          throw new nitro_exception(resource.message, resource.errorcode);
      }
      locationparameterArray[0] = resource.locationparameter;
      return (base_resource[]) locationparameterArray;
    }

    internal override string get_object_name() => (string) null;

    public static base_response update(
      nitro_service client,
      locationparameter resource)
    {
      return new locationparameter()
      {
        context = resource.context,
        q1label = resource.q1label,
        q2label = resource.q2label,
        q3label = resource.q3label,
        q4label = resource.q4label,
        q5label = resource.q5label,
        q6label = resource.q6label
      }.update_resource(client);
    }

    public static base_response unset(
      nitro_service client,
      locationparameter resource,
      string[] args)
    {
      return new locationparameter().unset_resource(client, args);
    }

    public static locationparameter get(nitro_service service) => ((locationparameter[]) new locationparameter().get_resources(service, (options) null))[0];

    public static locationparameter get(nitro_service service, options option) => ((locationparameter[]) new locationparameter().get_resources(service, option))[0];

    private class locationparameter_response : base_response
    {
      public locationparameter locationparameter = (locationparameter) null;
    }

    public static class loadingEnum
    {
      public const string In_progress = "In progress";
      public const string Idle = "Idle";
    }

    public static class databasemodeEnum
    {
      public const string File = "File";
      public const string Internal = "Internal";
      public const string Not_applicable = "Not applicable";
    }

    public static class formatEnum
    {
      public const string netscaler = "netscaler";
      public const string ip_country = "ip-country";
      public const string ip_country_isp = "ip-country-isp";
      public const string ip_country_region_city = "ip-country-region-city";
      public const string ip_country_region_city_isp = "ip-country-region-city-isp";
      public const string geoip_country = "geoip-country";
      public const string geoip_region = "geoip-region";
      public const string geoip_city = "geoip-city";
      public const string geoip_country_org = "geoip-country-org";
      public const string geoip_country_isp = "geoip-country-isp";
      public const string geoip_city_isp_org = "geoip-city-isp-org";
    }

    public static class contextEnum
    {
      public const string geographic = "geographic";
      public const string custom = "custom";
    }

    public static class flushingEnum
    {
      public const string In_progress = "In progress";
      public const string Idle = "Idle";
    }

    public static class format6Enum
    {
      public const string netscaler6 = "netscaler6";
      public const string geoip_country6 = "geoip-country6";
    }
  }
}
