// Decompiled with JetBrains decompiler
// Type: com.citrix.netscaler.nitro.resource.config.system.systementitydata
// Assembly: nitro, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 6CF5DDEF-E052-4F9D-953F-6644F8378A66


using com.citrix.netscaler.nitro.exception;
using com.citrix.netscaler.nitro.resource.Base;
using com.citrix.netscaler.nitro.service;
using com.citrix.netscaler.nitro.util;

namespace com.citrix.netscaler.nitro.resource.config.system
{
  public class systementitydata : base_resource
  {
    private string typeField = (string) null;
    private string nameField = (string) null;
    private bool? alldeletedField = new bool?();
    private bool? allinactiveField = new bool?();
    private string datasourceField = (string) null;
    private int? coreField = new int?();
    private string countersField = (string) null;
    private string starttimeField = (string) null;
    private string endtimeField = (string) null;
    private int? lastField = new int?();
    private string unitField = (string) null;
    private string responseField = (string) null;
    private uint? startupdateField = new uint?();
    private uint? lastupdateField = new uint?();

    public string type
    {
      get => this.typeField;
      set => this.typeField = value;
    }

    public string name
    {
      get => this.nameField;
      set => this.nameField = value;
    }

    public bool? alldeleted
    {
      get => this.alldeletedField;
      set => this.alldeletedField = value;
    }

    public bool? allinactive
    {
      get => this.allinactiveField;
      set => this.allinactiveField = value;
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

    public string counters
    {
      get => this.countersField;
      set => this.countersField = value;
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
      systementitydata[] systementitydataArray = new systementitydata[1];
      systementitydata.systementitydata_response systementitydataResponse = new systementitydata.systementitydata_response();
      systementitydata.systementitydata_response resource = (systementitydata.systementitydata_response) service.get_payload_formatter().string_to_resource(systementitydataResponse.GetType(), response);
      if (resource.errorcode != 0)
      {
        if (resource.errorcode == 444)
          service.clear_session();
        if (resource.severity == null)
          throw new nitro_exception(resource.message, resource.errorcode);
        if (resource.severity.Equals("ERROR"))
          throw new nitro_exception(resource.message, resource.errorcode);
      }
      systementitydataArray[0] = resource.systementitydata;
      return (base_resource[]) systementitydataArray;
    }

    internal override string get_object_name() => (string) null;

    public static base_response delete(nitro_service client, systementitydata resource) => new systementitydata()
    {
      type = resource.type,
      name = resource.name,
      alldeleted = resource.alldeleted,
      allinactive = resource.allinactive,
      datasource = resource.datasource,
      core = resource.core
    }.delete_resource(client);

    public static systementitydata get(nitro_service service, systementitydata obj)
    {
      options option = new options();
      option.set_args(nitro_util.object_to_string_withoutquotes((object) obj));
      return (systementitydata) obj.get_resource(service, option);
    }

    public static systementitydata[] get(
      nitro_service service,
      systementitydata_args args)
    {
      systementitydata systementitydata = new systementitydata();
      options option = new options();
      option.set_args(nitro_util.object_to_string_withoutquotes((object) args));
      return (systementitydata[]) systementitydata.get_resources(service, option);
    }

    private class systementitydata_response : base_response
    {
      public systementitydata systementitydata = (systementitydata) null;
    }

    public static class unitEnum
    {
      public const string HOURS = "HOURS";
      public const string DAYS = "DAYS";
      public const string MONTHS = "MONTHS";
    }
  }
}
