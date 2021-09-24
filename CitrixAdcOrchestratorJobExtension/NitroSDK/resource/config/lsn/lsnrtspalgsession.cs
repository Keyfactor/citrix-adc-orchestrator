// Decompiled with JetBrains decompiler
// Type: com.citrix.netscaler.nitro.resource.config.lsn.lsnrtspalgsession
// Assembly: nitro, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 6CF5DDEF-E052-4F9D-953F-6644F8378A66


using com.citrix.netscaler.nitro.exception;
using com.citrix.netscaler.nitro.resource.Base;
using com.citrix.netscaler.nitro.service;
using com.citrix.netscaler.nitro.util;

namespace com.citrix.netscaler.nitro.resource.config.lsn
{
  public class lsnrtspalgsession : base_resource
  {
    private string sessionidField = (string) null;
    private uint? callflagsField = new uint?();
    private uint? callrefcountField = new uint?();
    private uint? calltimerField = new uint?();
    private uint? __countField = new uint?();

    public uint? __count
    {
      get => this.__countField;
      private set => this.__countField = value;
    }

    public string sessionid
    {
      get => this.sessionidField;
      set => this.sessionidField = value;
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
      lsnrtspalgsession.lsnrtspalgsession_response lsnrtspalgsessionResponse = new lsnrtspalgsession.lsnrtspalgsession_response();
      lsnrtspalgsession.lsnrtspalgsession_response resource = (lsnrtspalgsession.lsnrtspalgsession_response) service.get_payload_formatter().string_to_resource(lsnrtspalgsessionResponse.GetType(), response);
      if (resource.errorcode != 0)
      {
        if (resource.errorcode == 444)
          service.clear_session();
        if (resource.severity == null)
          throw new nitro_exception(resource.message, resource.errorcode);
        if (resource.severity.Equals("ERROR"))
          throw new nitro_exception(resource.message, resource.errorcode);
      }
      return (base_resource[]) resource.lsnrtspalgsession;
    }

    internal override string get_object_name() => this.sessionid;

    public static base_response flush(nitro_service client, lsnrtspalgsession resource) => new lsnrtspalgsession()
    {
      sessionid = resource.sessionid
    }.perform_operation_byaction(client, nameof (flush));

    public static base_responses flush(
      nitro_service client,
      lsnrtspalgsession[] resources)
    {
      base_responses baseResponses = (base_responses) null;
      if (resources != null && resources.Length > 0)
      {
        lsnrtspalgsession[] lsnrtspalgsessionArray = new lsnrtspalgsession[resources.Length];
        for (int index = 0; index < resources.Length; ++index)
        {
          lsnrtspalgsessionArray[index] = new lsnrtspalgsession();
          lsnrtspalgsessionArray[index].sessionid = resources[index].sessionid;
        }
        baseResponses = base_resource.perform_operation_bulk_request(client, (base_resource[]) lsnrtspalgsessionArray, nameof (flush));
      }
      return baseResponses;
    }

    public static lsnrtspalgsession[] get(nitro_service service) => (lsnrtspalgsession[]) new lsnrtspalgsession().get_resources(service, (options) null);

    public static lsnrtspalgsession[] get(nitro_service service, options option) => (lsnrtspalgsession[]) new lsnrtspalgsession().get_resources(service, option);

    public static lsnrtspalgsession get(nitro_service service, string sessionid) => (lsnrtspalgsession) new lsnrtspalgsession()
    {
      sessionid = sessionid
    }.get_resource(service);

    public static lsnrtspalgsession[] get(
      nitro_service service,
      string[] sessionid)
    {
      if (sessionid == null || sessionid.Length <= 0)
        return (lsnrtspalgsession[]) null;
      lsnrtspalgsession[] lsnrtspalgsessionArray1 = new lsnrtspalgsession[sessionid.Length];
      lsnrtspalgsession[] lsnrtspalgsessionArray2 = new lsnrtspalgsession[sessionid.Length];
      for (int index = 0; index < sessionid.Length; ++index)
      {
        lsnrtspalgsessionArray2[index] = new lsnrtspalgsession();
        lsnrtspalgsessionArray2[index].sessionid = sessionid[index];
        lsnrtspalgsessionArray1[index] = (lsnrtspalgsession) lsnrtspalgsessionArray2[index].get_resource(service);
      }
      return lsnrtspalgsessionArray1;
    }

    public static lsnrtspalgsession[] get_filtered(
      nitro_service service,
      string filter)
    {
      lsnrtspalgsession lsnrtspalgsession = new lsnrtspalgsession();
      options option = new options();
      option.set_filter(filter);
      return (lsnrtspalgsession[]) lsnrtspalgsession.getfiltered(service, option);
    }

    public static lsnrtspalgsession[] get_filtered(
      nitro_service service,
      filtervalue[] filter)
    {
      lsnrtspalgsession lsnrtspalgsession = new lsnrtspalgsession();
      options option = new options();
      option.set_filter(filter);
      return (lsnrtspalgsession[]) lsnrtspalgsession.getfiltered(service, option);
    }

    public static uint count(nitro_service service)
    {
      lsnrtspalgsession lsnrtspalgsession = new lsnrtspalgsession();
      options option = new options();
      option.set_count(true);
      lsnrtspalgsession[] resources = (lsnrtspalgsession[]) lsnrtspalgsession.get_resources(service, option);
      return resources != null && resources.Length > 0 ? resources[0].__count.Value : 0U;
    }

    public static uint count_filtered(nitro_service service, string filter)
    {
      lsnrtspalgsession lsnrtspalgsession = new lsnrtspalgsession();
      options option = new options();
      option.set_count(true);
      option.set_filter(filter);
      lsnrtspalgsession[] lsnrtspalgsessionArray = (lsnrtspalgsession[]) lsnrtspalgsession.getfiltered(service, option);
      return lsnrtspalgsessionArray != null && lsnrtspalgsessionArray.Length > 0 ? lsnrtspalgsessionArray[0].__count.Value : 0U;
    }

    public static uint count_filtered(nitro_service service, filtervalue[] filter)
    {
      lsnrtspalgsession lsnrtspalgsession = new lsnrtspalgsession();
      options option = new options();
      option.set_count(true);
      option.set_filter(filter);
      lsnrtspalgsession[] lsnrtspalgsessionArray = (lsnrtspalgsession[]) lsnrtspalgsession.getfiltered(service, option);
      return lsnrtspalgsessionArray != null && lsnrtspalgsessionArray.Length > 0 ? lsnrtspalgsessionArray[0].__count.Value : 0U;
    }

    private class lsnrtspalgsession_response : base_response
    {
      public lsnrtspalgsession[] lsnrtspalgsession = (lsnrtspalgsession[]) null;
    }
  }
}
