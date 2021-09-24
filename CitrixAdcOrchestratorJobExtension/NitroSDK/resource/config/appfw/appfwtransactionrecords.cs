// Decompiled with JetBrains decompiler
// Type: com.citrix.netscaler.nitro.resource.config.appfw.appfwtransactionrecords
// Assembly: nitro, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 6CF5DDEF-E052-4F9D-953F-6644F8378A66


using com.citrix.netscaler.nitro.exception;
using com.citrix.netscaler.nitro.resource.Base;
using com.citrix.netscaler.nitro.service;
using com.citrix.netscaler.nitro.util;

namespace com.citrix.netscaler.nitro.resource.config.appfw
{
  public class appfwtransactionrecords : base_resource
  {
    private uint? httptransactionidField = new uint?();
    private int? packetengineidField = new int?();
    private string appfwsessionidField = (string) null;
    private string profilenameField = (string) null;
    private string urlField = (string) null;
    private string clientipField = (string) null;
    private string destipField = (string) null;
    private string starttimeField = (string) null;
    private string endtimeField = (string) null;
    private int? requestcontentlengthField = new int?();
    private uint? requestyieldsField = new uint?();
    private uint? requestmaxprocessingtimeField = new uint?();
    private int? responsecontentlengthField = new int?();
    private uint? responseyieldsField = new uint?();
    private uint? responsemaxprocessingtimeField = new uint?();
    private uint? __countField = new uint?();

    public uint? __count
    {
      get => this.__countField;
      private set => this.__countField = value;
    }

    public uint? httptransactionid
    {
      get => this.httptransactionidField;
      private set => this.httptransactionidField = value;
    }

    public int? packetengineid
    {
      get => this.packetengineidField;
      private set => this.packetengineidField = value;
    }

    public string appfwsessionid
    {
      get => this.appfwsessionidField;
      private set => this.appfwsessionidField = value;
    }

    public string profilename
    {
      get => this.profilenameField;
      private set => this.profilenameField = value;
    }

    public string url
    {
      get => this.urlField;
      private set => this.urlField = value;
    }

    public string clientip
    {
      get => this.clientipField;
      private set => this.clientipField = value;
    }

    public string destip
    {
      get => this.destipField;
      private set => this.destipField = value;
    }

    public string starttime
    {
      get => this.starttimeField;
      private set => this.starttimeField = value;
    }

    public string endtime
    {
      get => this.endtimeField;
      private set => this.endtimeField = value;
    }

    public int? requestcontentlength
    {
      get => this.requestcontentlengthField;
      private set => this.requestcontentlengthField = value;
    }

    public uint? requestyields
    {
      get => this.requestyieldsField;
      private set => this.requestyieldsField = value;
    }

    public uint? requestmaxprocessingtime
    {
      get => this.requestmaxprocessingtimeField;
      private set => this.requestmaxprocessingtimeField = value;
    }

    public int? responsecontentlength
    {
      get => this.responsecontentlengthField;
      private set => this.responsecontentlengthField = value;
    }

    public uint? responseyields
    {
      get => this.responseyieldsField;
      private set => this.responseyieldsField = value;
    }

    public uint? responsemaxprocessingtime
    {
      get => this.responsemaxprocessingtimeField;
      private set => this.responsemaxprocessingtimeField = value;
    }

    internal override base_resource[] get_nitro_response(
      nitro_service service,
      string response)
    {
      appfwtransactionrecords.appfwtransactionrecords_response appfwtransactionrecordsResponse = new appfwtransactionrecords.appfwtransactionrecords_response();
      appfwtransactionrecords.appfwtransactionrecords_response resource = (appfwtransactionrecords.appfwtransactionrecords_response) service.get_payload_formatter().string_to_resource(appfwtransactionrecordsResponse.GetType(), response);
      if (resource.errorcode != 0)
      {
        if (resource.errorcode == 444)
          service.clear_session();
        if (resource.severity == null)
          throw new nitro_exception(resource.message, resource.errorcode);
        if (resource.severity.Equals("ERROR"))
          throw new nitro_exception(resource.message, resource.errorcode);
      }
      return (base_resource[]) resource.appfwtransactionrecords;
    }

    internal override string get_object_name() => (string) null;

    public static appfwtransactionrecords[] get(nitro_service service) => (appfwtransactionrecords[]) new appfwtransactionrecords().get_resources(service, (options) null);

    public static appfwtransactionrecords[] get(
      nitro_service service,
      options option)
    {
      return (appfwtransactionrecords[]) new appfwtransactionrecords().get_resources(service, option);
    }

    public static appfwtransactionrecords[] get_filtered(
      nitro_service service,
      string filter)
    {
      appfwtransactionrecords appfwtransactionrecords = new appfwtransactionrecords();
      options option = new options();
      option.set_filter(filter);
      return (appfwtransactionrecords[]) appfwtransactionrecords.getfiltered(service, option);
    }

    public static appfwtransactionrecords[] get_filtered(
      nitro_service service,
      filtervalue[] filter)
    {
      appfwtransactionrecords appfwtransactionrecords = new appfwtransactionrecords();
      options option = new options();
      option.set_filter(filter);
      return (appfwtransactionrecords[]) appfwtransactionrecords.getfiltered(service, option);
    }

    public static uint count(nitro_service service)
    {
      appfwtransactionrecords appfwtransactionrecords = new appfwtransactionrecords();
      options option = new options();
      option.set_count(true);
      appfwtransactionrecords[] resources = (appfwtransactionrecords[]) appfwtransactionrecords.get_resources(service, option);
      return resources != null && resources.Length > 0 ? resources[0].__count.Value : 0U;
    }

    public static uint count_filtered(nitro_service service, string filter)
    {
      appfwtransactionrecords appfwtransactionrecords = new appfwtransactionrecords();
      options option = new options();
      option.set_count(true);
      option.set_filter(filter);
      appfwtransactionrecords[] appfwtransactionrecordsArray = (appfwtransactionrecords[]) appfwtransactionrecords.getfiltered(service, option);
      return appfwtransactionrecordsArray != null && appfwtransactionrecordsArray.Length > 0 ? appfwtransactionrecordsArray[0].__count.Value : 0U;
    }

    public static uint count_filtered(nitro_service service, filtervalue[] filter)
    {
      appfwtransactionrecords appfwtransactionrecords = new appfwtransactionrecords();
      options option = new options();
      option.set_count(true);
      option.set_filter(filter);
      appfwtransactionrecords[] appfwtransactionrecordsArray = (appfwtransactionrecords[]) appfwtransactionrecords.getfiltered(service, option);
      return appfwtransactionrecordsArray != null && appfwtransactionrecordsArray.Length > 0 ? appfwtransactionrecordsArray[0].__count.Value : 0U;
    }

    private class appfwtransactionrecords_response : base_response
    {
      public appfwtransactionrecords[] appfwtransactionrecords = (appfwtransactionrecords[]) null;
    }
  }
}
