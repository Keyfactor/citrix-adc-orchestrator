// Decompiled with JetBrains decompiler
// Type: com.citrix.netscaler.nitro.resource.config.ssl.sslcertlink
// Assembly: nitro, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 6CF5DDEF-E052-4F9D-953F-6644F8378A66


using com.citrix.netscaler.nitro.exception;
using com.citrix.netscaler.nitro.resource.Base;
using com.citrix.netscaler.nitro.service;
using com.citrix.netscaler.nitro.util;

namespace com.citrix.netscaler.nitro.resource.config.ssl
{
  public class sslcertlink : base_resource
  {
    private string certkeynameField = (string) null;
    private string linkcertkeynameField = (string) null;
    private uint? __countField = new uint?();

    public uint? __count
    {
      get => this.__countField;
      private set => this.__countField = value;
    }

    public string certkeyname
    {
      get => this.certkeynameField;
      private set => this.certkeynameField = value;
    }

    public string linkcertkeyname
    {
      get => this.linkcertkeynameField;
      private set => this.linkcertkeynameField = value;
    }

    internal override base_resource[] get_nitro_response(
      nitro_service service,
      string response)
    {
      sslcertlink.sslcertlink_response sslcertlinkResponse = new sslcertlink.sslcertlink_response();
      sslcertlink.sslcertlink_response resource = (sslcertlink.sslcertlink_response) service.get_payload_formatter().string_to_resource(sslcertlinkResponse.GetType(), response);
      if (resource.errorcode != 0)
      {
        if (resource.errorcode == 444)
          service.clear_session();
        if (resource.severity == null)
          throw new nitro_exception(resource.message, resource.errorcode);
        if (resource.severity.Equals("ERROR"))
          throw new nitro_exception(resource.message, resource.errorcode);
      }
      return (base_resource[]) resource.sslcertlink;
    }

    internal override string get_object_name() => (string) null;

    public static sslcertlink[] get(nitro_service service) => (sslcertlink[]) new sslcertlink().get_resources(service, (options) null);

    public static sslcertlink[] get(nitro_service service, options option) => (sslcertlink[]) new sslcertlink().get_resources(service, option);

    public static sslcertlink[] get_filtered(nitro_service service, string filter)
    {
      sslcertlink sslcertlink = new sslcertlink();
      options option = new options();
      option.set_filter(filter);
      return (sslcertlink[]) sslcertlink.getfiltered(service, option);
    }

    public static sslcertlink[] get_filtered(nitro_service service, filtervalue[] filter)
    {
      sslcertlink sslcertlink = new sslcertlink();
      options option = new options();
      option.set_filter(filter);
      return (sslcertlink[]) sslcertlink.getfiltered(service, option);
    }

    public static uint count(nitro_service service)
    {
      sslcertlink sslcertlink = new sslcertlink();
      options option = new options();
      option.set_count(true);
      sslcertlink[] resources = (sslcertlink[]) sslcertlink.get_resources(service, option);
      return resources != null && resources.Length > 0 ? resources[0].__count.Value : 0U;
    }

    public static uint count_filtered(nitro_service service, string filter)
    {
      sslcertlink sslcertlink = new sslcertlink();
      options option = new options();
      option.set_count(true);
      option.set_filter(filter);
      sslcertlink[] sslcertlinkArray = (sslcertlink[]) sslcertlink.getfiltered(service, option);
      return sslcertlinkArray != null && sslcertlinkArray.Length > 0 ? sslcertlinkArray[0].__count.Value : 0U;
    }

    public static uint count_filtered(nitro_service service, filtervalue[] filter)
    {
      sslcertlink sslcertlink = new sslcertlink();
      options option = new options();
      option.set_count(true);
      option.set_filter(filter);
      sslcertlink[] sslcertlinkArray = (sslcertlink[]) sslcertlink.getfiltered(service, option);
      return sslcertlinkArray != null && sslcertlinkArray.Length > 0 ? sslcertlinkArray[0].__count.Value : 0U;
    }

    private class sslcertlink_response : base_response
    {
      public sslcertlink[] sslcertlink = (sslcertlink[]) null;
    }
  }
}
