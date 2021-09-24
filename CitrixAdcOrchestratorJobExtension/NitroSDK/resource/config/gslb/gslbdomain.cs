// Decompiled with JetBrains decompiler
// Type: com.citrix.netscaler.nitro.resource.config.gslb.gslbdomain
// Assembly: nitro, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 6CF5DDEF-E052-4F9D-953F-6644F8378A66


using com.citrix.netscaler.nitro.exception;
using com.citrix.netscaler.nitro.resource.Base;
using com.citrix.netscaler.nitro.service;
using com.citrix.netscaler.nitro.util;

namespace com.citrix.netscaler.nitro.resource.config.gslb
{
  public class gslbdomain : base_resource
  {
    private string nameField = (string) null;
    private uint? __countField = new uint?();

    public uint? __count
    {
      get => this.__countField;
      private set => this.__countField = value;
    }

    public string name
    {
      get => this.nameField;
      set => this.nameField = value;
    }

    internal override base_resource[] get_nitro_response(
      nitro_service service,
      string response)
    {
      gslbdomain.gslbdomain_response gslbdomainResponse = new gslbdomain.gslbdomain_response();
      gslbdomain.gslbdomain_response resource = (gslbdomain.gslbdomain_response) service.get_payload_formatter().string_to_resource(gslbdomainResponse.GetType(), response);
      if (resource.errorcode != 0)
      {
        if (resource.errorcode == 444)
          service.clear_session();
        if (resource.severity == null)
          throw new nitro_exception(resource.message, resource.errorcode);
        if (resource.severity.Equals("ERROR"))
          throw new nitro_exception(resource.message, resource.errorcode);
      }
      return (base_resource[]) resource.gslbdomain;
    }

    internal override string get_object_name() => this.name;

    public static gslbdomain[] get(nitro_service service) => (gslbdomain[]) new gslbdomain().get_resources(service, (options) null);

    public static gslbdomain[] get(nitro_service service, options option) => (gslbdomain[]) new gslbdomain().get_resources(service, option);

    public static gslbdomain get(nitro_service service, string name) => (gslbdomain) new gslbdomain()
    {
      name = name
    }.get_resource(service);

    public static gslbdomain[] get(nitro_service service, string[] name)
    {
      if (name == null || name.Length <= 0)
        return (gslbdomain[]) null;
      gslbdomain[] gslbdomainArray1 = new gslbdomain[name.Length];
      gslbdomain[] gslbdomainArray2 = new gslbdomain[name.Length];
      for (int index = 0; index < name.Length; ++index)
      {
        gslbdomainArray2[index] = new gslbdomain();
        gslbdomainArray2[index].name = name[index];
        gslbdomainArray1[index] = (gslbdomain) gslbdomainArray2[index].get_resource(service);
      }
      return gslbdomainArray1;
    }

    public static gslbdomain[] get_filtered(nitro_service service, string filter)
    {
      gslbdomain gslbdomain = new gslbdomain();
      options option = new options();
      option.set_filter(filter);
      return (gslbdomain[]) gslbdomain.getfiltered(service, option);
    }

    public static gslbdomain[] get_filtered(nitro_service service, filtervalue[] filter)
    {
      gslbdomain gslbdomain = new gslbdomain();
      options option = new options();
      option.set_filter(filter);
      return (gslbdomain[]) gslbdomain.getfiltered(service, option);
    }

    public static uint count(nitro_service service)
    {
      gslbdomain gslbdomain = new gslbdomain();
      options option = new options();
      option.set_count(true);
      gslbdomain[] resources = (gslbdomain[]) gslbdomain.get_resources(service, option);
      return resources != null && resources.Length > 0 ? resources[0].__count.Value : 0U;
    }

    public static uint count_filtered(nitro_service service, string filter)
    {
      gslbdomain gslbdomain = new gslbdomain();
      options option = new options();
      option.set_count(true);
      option.set_filter(filter);
      gslbdomain[] gslbdomainArray = (gslbdomain[]) gslbdomain.getfiltered(service, option);
      return gslbdomainArray != null && gslbdomainArray.Length > 0 ? gslbdomainArray[0].__count.Value : 0U;
    }

    public static uint count_filtered(nitro_service service, filtervalue[] filter)
    {
      gslbdomain gslbdomain = new gslbdomain();
      options option = new options();
      option.set_count(true);
      option.set_filter(filter);
      gslbdomain[] gslbdomainArray = (gslbdomain[]) gslbdomain.getfiltered(service, option);
      return gslbdomainArray != null && gslbdomainArray.Length > 0 ? gslbdomainArray[0].__count.Value : 0U;
    }

    private class gslbdomain_response : base_response
    {
      public gslbdomain[] gslbdomain = (gslbdomain[]) null;
    }
  }
}
