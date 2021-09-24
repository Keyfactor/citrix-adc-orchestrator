// Decompiled with JetBrains decompiler
// Type: com.citrix.netscaler.nitro.resource.config.system.systemeventhistory
// Assembly: nitro, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 6CF5DDEF-E052-4F9D-953F-6644F8378A66


using com.citrix.netscaler.nitro.exception;
using com.citrix.netscaler.nitro.resource.Base;
using com.citrix.netscaler.nitro.service;
using com.citrix.netscaler.nitro.util;

namespace com.citrix.netscaler.nitro.resource.config.system
{
  public class systemeventhistory : base_resource
  {
    private string starttimeField = (string) null;
    private string endtimeField = (string) null;
    private int? lastField = new int?();
    private string unitField = (string) null;
    private string datasourceField = (string) null;
    private string responseField = (string) null;

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

    public string response
    {
      get => this.responseField;
      private set => this.responseField = value;
    }

    internal override base_resource[] get_nitro_response(
      nitro_service service,
      string response)
    {
      systemeventhistory[] systemeventhistoryArray = new systemeventhistory[1];
      systemeventhistory.systemeventhistory_response systemeventhistoryResponse = new systemeventhistory.systemeventhistory_response();
      systemeventhistory.systemeventhistory_response resource = (systemeventhistory.systemeventhistory_response) service.get_payload_formatter().string_to_resource(systemeventhistoryResponse.GetType(), response);
      if (resource.errorcode != 0)
      {
        if (resource.errorcode == 444)
          service.clear_session();
        if (resource.severity == null)
          throw new nitro_exception(resource.message, resource.errorcode);
        if (resource.severity.Equals("ERROR"))
          throw new nitro_exception(resource.message, resource.errorcode);
      }
      systemeventhistoryArray[0] = resource.systemeventhistory;
      return (base_resource[]) systemeventhistoryArray;
    }

    internal override string get_object_name() => (string) null;

    public static systemeventhistory get(
      nitro_service service,
      systemeventhistory obj)
    {
      options option = new options();
      option.set_args(nitro_util.object_to_string_withoutquotes((object) obj));
      return (systemeventhistory) obj.get_resource(service, option);
    }

    public static systemeventhistory[] get(
      nitro_service service,
      systemeventhistory_args args)
    {
      systemeventhistory systemeventhistory = new systemeventhistory();
      options option = new options();
      option.set_args(nitro_util.object_to_string_withoutquotes((object) args));
      return (systemeventhistory[]) systemeventhistory.get_resources(service, option);
    }

    private class systemeventhistory_response : base_response
    {
      public systemeventhistory systemeventhistory = (systemeventhistory) null;
    }

    public static class unitEnum
    {
      public const string HOURS = "HOURS";
      public const string DAYS = "DAYS";
      public const string MONTHS = "MONTHS";
    }
  }
}
