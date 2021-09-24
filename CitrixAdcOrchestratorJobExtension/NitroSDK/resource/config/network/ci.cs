// Decompiled with JetBrains decompiler
// Type: com.citrix.netscaler.nitro.resource.config.network.ci
// Assembly: nitro, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 6CF5DDEF-E052-4F9D-953F-6644F8378A66


using com.citrix.netscaler.nitro.exception;
using com.citrix.netscaler.nitro.resource.Base;
using com.citrix.netscaler.nitro.service;
using com.citrix.netscaler.nitro.util;

namespace com.citrix.netscaler.nitro.resource.config.network
{
  public class ci : base_resource
  {
    private string ifacesField = (string) null;
    private uint? __countField = new uint?();

    public uint? __count
    {
      get => this.__countField;
      private set => this.__countField = value;
    }

    public string ifaces
    {
      get => this.ifacesField;
      private set => this.ifacesField = value;
    }

    internal override base_resource[] get_nitro_response(
      nitro_service service,
      string response)
    {
      ci.ci_response ciResponse = new ci.ci_response();
      ci.ci_response resource = (ci.ci_response) service.get_payload_formatter().string_to_resource(ciResponse.GetType(), response);
      if (resource.errorcode != 0)
      {
        if (resource.errorcode == 444)
          service.clear_session();
        if (resource.severity == null)
          throw new nitro_exception(resource.message, resource.errorcode);
        if (resource.severity.Equals("ERROR"))
          throw new nitro_exception(resource.message, resource.errorcode);
      }
      return (base_resource[]) resource.ci;
    }

    internal override string get_object_name() => (string) null;

    public static ci[] get(nitro_service service) => (ci[]) new ci().get_resources(service, (options) null);

    public static ci[] get(nitro_service service, options option) => (ci[]) new ci().get_resources(service, option);

    public static ci[] get_filtered(nitro_service service, string filter)
    {
      ci ci = new ci();
      options option = new options();
      option.set_filter(filter);
      return (ci[]) ci.getfiltered(service, option);
    }

    public static ci[] get_filtered(nitro_service service, filtervalue[] filter)
    {
      ci ci = new ci();
      options option = new options();
      option.set_filter(filter);
      return (ci[]) ci.getfiltered(service, option);
    }

    public static uint count(nitro_service service)
    {
      ci ci = new ci();
      options option = new options();
      option.set_count(true);
      ci[] resources = (ci[]) ci.get_resources(service, option);
      return resources != null && resources.Length > 0 ? resources[0].__count.Value : 0U;
    }

    public static uint count_filtered(nitro_service service, string filter)
    {
      ci ci = new ci();
      options option = new options();
      option.set_count(true);
      option.set_filter(filter);
      ci[] ciArray = (ci[]) ci.getfiltered(service, option);
      return ciArray != null && ciArray.Length > 0 ? ciArray[0].__count.Value : 0U;
    }

    public static uint count_filtered(nitro_service service, filtervalue[] filter)
    {
      ci ci = new ci();
      options option = new options();
      option.set_count(true);
      option.set_filter(filter);
      ci[] ciArray = (ci[]) ci.getfiltered(service, option);
      return ciArray != null && ciArray.Length > 0 ? ciArray[0].__count.Value : 0U;
    }

    private class ci_response : base_response
    {
      public ci[] ci = (ci[]) null;
    }
  }
}
