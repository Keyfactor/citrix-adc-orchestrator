// Decompiled with JetBrains decompiler
// Type: com.citrix.netscaler.nitro.resource.config.system.systemglobaldata
// Assembly: nitro, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 6CF5DDEF-E052-4F9D-953F-6644F8378A66


using com.citrix.netscaler.nitro.exception;
using com.citrix.netscaler.nitro.resource.Base;
using com.citrix.netscaler.nitro.service;
using com.citrix.netscaler.nitro.util;

namespace com.citrix.netscaler.nitro.resource.config.system
{
  public class systemglobaldata : base_resource
  {
    private string countersField = (string) null;
    private string countergroupField = (string) null;
    private string starttimeField = (string) null;
    private string endtimeField = (string) null;
    private int? lastField = new int?();
    private string unitField = (string) null;
    private string datasourceField = (string) null;
    private int? coreField = new int?();
    private string responseField = (string) null;
    private uint? startupdateField = new uint?();
    private uint? lastupdateField = new uint?();

    public string counters
    {
      get => this.countersField;
      set => this.countersField = value;
    }

    public string countergroup
    {
      get => this.countergroupField;
      set => this.countergroupField = value;
    }

    public string starttime
    {
      get => this.starttimeField;
      set => this.starttimeField = value;
    }

    public string endtime
    {
      get => this.endtimeField;
      set => this.endtimeField = value;
    }

    public int? last
    {
      get => this.lastField;
      set => this.lastField = value;
    }

    public string unit
    {
      get => this.unitField;
      set => this.unitField = value;
    }

    public string datasource
    {
      get => this.datasourceField;
      set => this.datasourceField = value;
    }

    public int? core
    {
      get => this.coreField;
      set => this.coreField = value;
    }

    public string response
    {
      get => this.responseField;
      private set => this.responseField = value;
    }

    public uint? startupdate
    {
      get => this.startupdateField;
      private set => this.startupdateField = value;
    }

    public uint? lastupdate
    {
      get => this.lastupdateField;
      private set => this.lastupdateField = value;
    }

    internal override base_resource[] get_nitro_response(
      nitro_service service,
      string response)
    {
      systemglobaldata[] systemglobaldataArray = new systemglobaldata[1];
      systemglobaldata.systemglobaldata_response systemglobaldataResponse = new systemglobaldata.systemglobaldata_response();
      systemglobaldata.systemglobaldata_response resource = (systemglobaldata.systemglobaldata_response) service.get_payload_formatter().string_to_resource(systemglobaldataResponse.GetType(), response);
      if (resource.errorcode != 0)
      {
        if (resource.errorcode == 444)
          service.clear_session();
        if (resource.severity == null)
          throw new nitro_exception(resource.message, resource.errorcode);
        if (resource.severity.Equals("ERROR"))
          throw new nitro_exception(resource.message, resource.errorcode);
      }
      systemglobaldataArray[0] = resource.systemglobaldata;
      return (base_resource[]) systemglobaldataArray;
    }

    internal override string get_object_name() => (string) null;

    public static systemglobaldata get(nitro_service service, systemglobaldata obj)
    {
      options option = new options();
      option.set_args(nitro_util.object_to_string_withoutquotes((object) obj));
      return (systemglobaldata) obj.get_resource(service, option);
    }

    public static systemglobaldata[] get(
      nitro_service service,
      systemglobaldata_args args)
    {
      systemglobaldata systemglobaldata = new systemglobaldata();
      options option = new options();
      option.set_args(nitro_util.object_to_string_withoutquotes((object) args));
      return (systemglobaldata[]) systemglobaldata.get_resources(service, option);
    }

    private class systemglobaldata_response : base_response
    {
      public systemglobaldata systemglobaldata = (systemglobaldata) null;
    }

    public static class unitEnum
    {
      public const string HOURS = "HOURS";
      public const string DAYS = "DAYS";
      public const string MONTHS = "MONTHS";
    }
  }
}
