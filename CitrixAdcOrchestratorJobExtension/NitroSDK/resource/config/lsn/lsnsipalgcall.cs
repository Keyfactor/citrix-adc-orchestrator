// Decompiled with JetBrains decompiler
// Type: com.citrix.netscaler.nitro.resource.config.lsn.lsnsipalgcall
// Assembly: nitro, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 6CF5DDEF-E052-4F9D-953F-6644F8378A66


using com.citrix.netscaler.nitro.exception;
using com.citrix.netscaler.nitro.resource.Base;
using com.citrix.netscaler.nitro.service;
using com.citrix.netscaler.nitro.util;

namespace com.citrix.netscaler.nitro.resource.config.lsn
{
  public class lsnsipalgcall : base_resource
  {
    private string callidField = (string) null;
    private uint? callflagsField = new uint?();
    private uint? callrefcountField = new uint?();
    private uint? calltimerField = new uint?();
    private uint? __countField = new uint?();

    public uint? __count
    {
      get => this.__countField;
      private set => this.__countField = value;
    }

    public string callid
    {
      get => this.callidField;
      set => this.callidField = value;
    }

    public uint? callflags
    {
      get => this.callflagsField;
      private set => this.callflagsField = value;
    }

    public uint? callrefcount
    {
      get => this.callrefcountField;
      private set => this.callrefcountField = value;
    }

    public uint? calltimer
    {
      get => this.calltimerField;
      private set => this.calltimerField = value;
    }

    internal override base_resource[] get_nitro_response(
      nitro_service service,
      string response)
    {
      lsnsipalgcall.lsnsipalgcall_response lsnsipalgcallResponse = new lsnsipalgcall.lsnsipalgcall_response();
      lsnsipalgcall.lsnsipalgcall_response resource = (lsnsipalgcall.lsnsipalgcall_response) service.get_payload_formatter().string_to_resource(lsnsipalgcallResponse.GetType(), response);
      if (resource.errorcode != 0)
      {
        if (resource.errorcode == 444)
          service.clear_session();
        if (resource.severity == null)
          throw new nitro_exception(resource.message, resource.errorcode);
        if (resource.severity.Equals("ERROR"))
          throw new nitro_exception(resource.message, resource.errorcode);
      }
      return (base_resource[]) resource.lsnsipalgcall;
    }

    internal override string get_object_name() => this.callid;

    public static base_response flush(nitro_service client, lsnsipalgcall resource) => new lsnsipalgcall()
    {
      callid = resource.callid
    }.perform_operation_byaction(client, nameof (flush));

    public static base_responses flush(
      nitro_service client,
      lsnsipalgcall[] resources)
    {
      base_responses baseResponses = (base_responses) null;
      if (resources != null && resources.Length > 0)
      {
        lsnsipalgcall[] lsnsipalgcallArray = new lsnsipalgcall[resources.Length];
        for (int index = 0; index < resources.Length; ++index)
        {
          lsnsipalgcallArray[index] = new lsnsipalgcall();
          lsnsipalgcallArray[index].callid = resources[index].callid;
        }
        baseResponses = base_resource.perform_operation_bulk_request(client, (base_resource[]) lsnsipalgcallArray, nameof (flush));
      }
      return baseResponses;
    }

    public static lsnsipalgcall[] get(nitro_service service) => (lsnsipalgcall[]) new lsnsipalgcall().get_resources(service, (options) null);

    public static lsnsipalgcall[] get(nitro_service service, options option) => (lsnsipalgcall[]) new lsnsipalgcall().get_resources(service, option);

    public static lsnsipalgcall get(nitro_service service, string callid) => (lsnsipalgcall) new lsnsipalgcall()
    {
      callid = callid
    }.get_resource(service);

    public static lsnsipalgcall[] get(nitro_service service, string[] callid)
    {
      if (callid == null || callid.Length <= 0)
        return (lsnsipalgcall[]) null;
      lsnsipalgcall[] lsnsipalgcallArray1 = new lsnsipalgcall[callid.Length];
      lsnsipalgcall[] lsnsipalgcallArray2 = new lsnsipalgcall[callid.Length];
      for (int index = 0; index < callid.Length; ++index)
      {
        lsnsipalgcallArray2[index] = new lsnsipalgcall();
        lsnsipalgcallArray2[index].callid = callid[index];
        lsnsipalgcallArray1[index] = (lsnsipalgcall) lsnsipalgcallArray2[index].get_resource(service);
      }
      return lsnsipalgcallArray1;
    }

    public static lsnsipalgcall[] get_filtered(nitro_service service, string filter)
    {
      lsnsipalgcall lsnsipalgcall = new lsnsipalgcall();
      options option = new options();
      option.set_filter(filter);
      return (lsnsipalgcall[]) lsnsipalgcall.getfiltered(service, option);
    }

    public static lsnsipalgcall[] get_filtered(
      nitro_service service,
      filtervalue[] filter)
    {
      lsnsipalgcall lsnsipalgcall = new lsnsipalgcall();
      options option = new options();
      option.set_filter(filter);
      return (lsnsipalgcall[]) lsnsipalgcall.getfiltered(service, option);
    }

    public static uint count(nitro_service service)
    {
      lsnsipalgcall lsnsipalgcall = new lsnsipalgcall();
      options option = new options();
      option.set_count(true);
      lsnsipalgcall[] resources = (lsnsipalgcall[]) lsnsipalgcall.get_resources(service, option);
      return resources != null && resources.Length > 0 ? resources[0].__count.Value : 0U;
    }

    public static uint count_filtered(nitro_service service, string filter)
    {
      lsnsipalgcall lsnsipalgcall = new lsnsipalgcall();
      options option = new options();
      option.set_count(true);
      option.set_filter(filter);
      lsnsipalgcall[] lsnsipalgcallArray = (lsnsipalgcall[]) lsnsipalgcall.getfiltered(service, option);
      return lsnsipalgcallArray != null && lsnsipalgcallArray.Length > 0 ? lsnsipalgcallArray[0].__count.Value : 0U;
    }

    public static uint count_filtered(nitro_service service, filtervalue[] filter)
    {
      lsnsipalgcall lsnsipalgcall = new lsnsipalgcall();
      options option = new options();
      option.set_count(true);
      option.set_filter(filter);
      lsnsipalgcall[] lsnsipalgcallArray = (lsnsipalgcall[]) lsnsipalgcall.getfiltered(service, option);
      return lsnsipalgcallArray != null && lsnsipalgcallArray.Length > 0 ? lsnsipalgcallArray[0].__count.Value : 0U;
    }

    private class lsnsipalgcall_response : base_response
    {
      public lsnsipalgcall[] lsnsipalgcall = (lsnsipalgcall[]) null;
    }
  }
}
