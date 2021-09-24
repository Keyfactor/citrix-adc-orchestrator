// Decompiled with JetBrains decompiler
// Type: com.citrix.netscaler.nitro.resource.config.vpn.vpnicadtlsconnection
// Assembly: nitro, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 6CF5DDEF-E052-4F9D-953F-6644F8378A66


using com.citrix.netscaler.nitro.exception;
using com.citrix.netscaler.nitro.resource.Base;
using com.citrix.netscaler.nitro.service;
using com.citrix.netscaler.nitro.util;

namespace com.citrix.netscaler.nitro.resource.config.vpn
{
  public class vpnicadtlsconnection : base_resource
  {
    private string usernameField = (string) null;
    private string domainField = (string) null;
    private string srcipField = (string) null;
    private ushort? srcportField = new ushort?();
    private string destipField = (string) null;
    private ushort? destportField = new ushort?();
    private uint? channelnumberField = new uint?();
    private uint? peidField = new uint?();
    private uint? __countField = new uint?();

    public uint? __count
    {
      get => this.__countField;
      private set => this.__countField = value;
    }

    public string username
    {
      get => this.usernameField;
      set => this.usernameField = value;
    }

    public string domain
    {
      get => this.domainField;
      private set => this.domainField = value;
    }

    public string srcip
    {
      get => this.srcipField;
      private set => this.srcipField = value;
    }

    public ushort? srcport
    {
      get => this.srcportField;
      private set => this.srcportField = value;
    }

    public string destip
    {
      get => this.destipField;
      private set => this.destipField = value;
    }

    public ushort? destport
    {
      get => this.destportField;
      private set => this.destportField = value;
    }

    public uint? channelnumber
    {
      get => this.channelnumberField;
      private set => this.channelnumberField = value;
    }

    public uint? peid
    {
      get => this.peidField;
      private set => this.peidField = value;
    }

    internal override base_resource[] get_nitro_response(
      nitro_service service,
      string response)
    {
      vpnicadtlsconnection.vpnicadtlsconnection_response vpnicadtlsconnectionResponse = new vpnicadtlsconnection.vpnicadtlsconnection_response();
      vpnicadtlsconnection.vpnicadtlsconnection_response resource = (vpnicadtlsconnection.vpnicadtlsconnection_response) service.get_payload_formatter().string_to_resource(vpnicadtlsconnectionResponse.GetType(), response);
      if (resource.errorcode != 0)
      {
        if (resource.errorcode == 444)
          service.clear_session();
        if (resource.severity == null)
          throw new nitro_exception(resource.message, resource.errorcode);
        if (resource.severity.Equals("ERROR"))
          throw new nitro_exception(resource.message, resource.errorcode);
      }
      return (base_resource[]) resource.vpnicadtlsconnection;
    }

    internal override string get_object_name() => (string) null;

    public static vpnicadtlsconnection[] get(nitro_service service) => (vpnicadtlsconnection[]) new vpnicadtlsconnection().get_resources(service, (options) null);

    public static vpnicadtlsconnection[] get(
      nitro_service service,
      options option)
    {
      return (vpnicadtlsconnection[]) new vpnicadtlsconnection().get_resources(service, option);
    }

    public static vpnicadtlsconnection[] get(
      nitro_service service,
      vpnicadtlsconnection_args args)
    {
      vpnicadtlsconnection vpnicadtlsconnection = new vpnicadtlsconnection();
      options option = new options();
      option.set_args(nitro_util.object_to_string_withoutquotes((object) args));
      return (vpnicadtlsconnection[]) vpnicadtlsconnection.get_resources(service, option);
    }

    public static vpnicadtlsconnection[] get_filtered(
      nitro_service service,
      string filter)
    {
      vpnicadtlsconnection vpnicadtlsconnection = new vpnicadtlsconnection();
      options option = new options();
      option.set_filter(filter);
      return (vpnicadtlsconnection[]) vpnicadtlsconnection.getfiltered(service, option);
    }

    public static vpnicadtlsconnection[] get_filtered(
      nitro_service service,
      filtervalue[] filter)
    {
      vpnicadtlsconnection vpnicadtlsconnection = new vpnicadtlsconnection();
      options option = new options();
      option.set_filter(filter);
      return (vpnicadtlsconnection[]) vpnicadtlsconnection.getfiltered(service, option);
    }

    public static uint count(nitro_service service)
    {
      vpnicadtlsconnection vpnicadtlsconnection = new vpnicadtlsconnection();
      options option = new options();
      option.set_count(true);
      vpnicadtlsconnection[] resources = (vpnicadtlsconnection[]) vpnicadtlsconnection.get_resources(service, option);
      return resources != null && resources.Length > 0 ? resources[0].__count.Value : 0U;
    }

    public static uint count_filtered(nitro_service service, string filter)
    {
      vpnicadtlsconnection vpnicadtlsconnection = new vpnicadtlsconnection();
      options option = new options();
      option.set_count(true);
      option.set_filter(filter);
      vpnicadtlsconnection[] vpnicadtlsconnectionArray = (vpnicadtlsconnection[]) vpnicadtlsconnection.getfiltered(service, option);
      return vpnicadtlsconnectionArray != null && vpnicadtlsconnectionArray.Length > 0 ? vpnicadtlsconnectionArray[0].__count.Value : 0U;
    }

    public static uint count_filtered(nitro_service service, filtervalue[] filter)
    {
      vpnicadtlsconnection vpnicadtlsconnection = new vpnicadtlsconnection();
      options option = new options();
      option.set_count(true);
      option.set_filter(filter);
      vpnicadtlsconnection[] vpnicadtlsconnectionArray = (vpnicadtlsconnection[]) vpnicadtlsconnection.getfiltered(service, option);
      return vpnicadtlsconnectionArray != null && vpnicadtlsconnectionArray.Length > 0 ? vpnicadtlsconnectionArray[0].__count.Value : 0U;
    }

    private class vpnicadtlsconnection_response : base_response
    {
      public vpnicadtlsconnection[] vpnicadtlsconnection = (vpnicadtlsconnection[]) null;
    }
  }
}
