// Decompiled with JetBrains decompiler
// Type: com.citrix.netscaler.nitro.resource.config.rise.riserhi
// Assembly: nitro, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 6CF5DDEF-E052-4F9D-953F-6644F8378A66


using com.citrix.netscaler.nitro.exception;
using com.citrix.netscaler.nitro.resource.Base;
using com.citrix.netscaler.nitro.service;
using com.citrix.netscaler.nitro.util;

namespace com.citrix.netscaler.nitro.resource.config.rise
{
  public class riserhi : base_resource
  {
    private string ipaddressField = (string) null;
    private uint? prefixlenField = new uint?();
    private string hostrtgwField = (string) null;
    private uint? nexthopvlanField = new uint?();
    private uint? weightField = new uint?();
    private string vserverrhilevelField = (string) null;
    private uint? __countField = new uint?();

    public uint? __count
    {
      get => this.__countField;
      private set => this.__countField = value;
    }

    public string ipaddress
    {
      get => this.ipaddressField;
      private set => this.ipaddressField = value;
    }

    public uint? prefixlen
    {
      get => this.prefixlenField;
      private set => this.prefixlenField = value;
    }

    public string hostrtgw
    {
      get => this.hostrtgwField;
      private set => this.hostrtgwField = value;
    }

    public uint? nexthopvlan
    {
      get => this.nexthopvlanField;
      private set => this.nexthopvlanField = value;
    }

    public uint? weight
    {
      get => this.weightField;
      private set => this.weightField = value;
    }

    public string vserverrhilevel
    {
      get => this.vserverrhilevelField;
      private set => this.vserverrhilevelField = value;
    }

    internal override base_resource[] get_nitro_response(
      nitro_service service,
      string response)
    {
      riserhi.riserhi_response riserhiResponse = new riserhi.riserhi_response();
      riserhi.riserhi_response resource = (riserhi.riserhi_response) service.get_payload_formatter().string_to_resource(riserhiResponse.GetType(), response);
      if (resource.errorcode != 0)
      {
        if (resource.errorcode == 444)
          service.clear_session();
        if (resource.severity == null)
          throw new nitro_exception(resource.message, resource.errorcode);
        if (resource.severity.Equals("ERROR"))
          throw new nitro_exception(resource.message, resource.errorcode);
      }
      return (base_resource[]) resource.riserhi;
    }

    internal override string get_object_name() => (string) null;

    public static riserhi[] get(nitro_service service) => (riserhi[]) new riserhi().get_resources(service, (options) null);

    public static riserhi[] get(nitro_service service, options option) => (riserhi[]) new riserhi().get_resources(service, option);

    public static riserhi[] get_filtered(nitro_service service, string filter)
    {
      riserhi riserhi = new riserhi();
      options option = new options();
      option.set_filter(filter);
      return (riserhi[]) riserhi.getfiltered(service, option);
    }

    public static riserhi[] get_filtered(nitro_service service, filtervalue[] filter)
    {
      riserhi riserhi = new riserhi();
      options option = new options();
      option.set_filter(filter);
      return (riserhi[]) riserhi.getfiltered(service, option);
    }

    public static uint count(nitro_service service)
    {
      riserhi riserhi = new riserhi();
      options option = new options();
      option.set_count(true);
      riserhi[] resources = (riserhi[]) riserhi.get_resources(service, option);
      return resources != null && resources.Length > 0 ? resources[0].__count.Value : 0U;
    }

    public static uint count_filtered(nitro_service service, string filter)
    {
      riserhi riserhi = new riserhi();
      options option = new options();
      option.set_count(true);
      option.set_filter(filter);
      riserhi[] riserhiArray = (riserhi[]) riserhi.getfiltered(service, option);
      return riserhiArray != null && riserhiArray.Length > 0 ? riserhiArray[0].__count.Value : 0U;
    }

    public static uint count_filtered(nitro_service service, filtervalue[] filter)
    {
      riserhi riserhi = new riserhi();
      options option = new options();
      option.set_count(true);
      option.set_filter(filter);
      riserhi[] riserhiArray = (riserhi[]) riserhi.getfiltered(service, option);
      return riserhiArray != null && riserhiArray.Length > 0 ? riserhiArray[0].__count.Value : 0U;
    }

    private class riserhi_response : base_response
    {
      public riserhi[] riserhi = (riserhi[]) null;
    }

    public static class vserverrhilevelEnum
    {
      public const string ONE_VSERVER = "ONE_VSERVER";
      public const string ALL_VSERVERS = "ALL_VSERVERS";
      public const string NONE = "NONE";
      public const string VSVR_CNTRLD = "VSVR_CNTRLD";
    }
  }
}
