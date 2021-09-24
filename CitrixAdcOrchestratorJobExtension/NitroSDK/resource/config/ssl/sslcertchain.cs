// Decompiled with JetBrains decompiler
// Type: com.citrix.netscaler.nitro.resource.config.ssl.sslcertchain
// Assembly: nitro, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 6CF5DDEF-E052-4F9D-953F-6644F8378A66


using com.citrix.netscaler.nitro.exception;
using com.citrix.netscaler.nitro.resource.Base;
using com.citrix.netscaler.nitro.service;
using com.citrix.netscaler.nitro.util;

namespace com.citrix.netscaler.nitro.resource.config.ssl
{
  public class sslcertchain : base_resource
  {
    private string certkeynameField = (string) null;
    private uint? __countField = new uint?();

    public uint? __count
    {
      get => this.__countField;
      private set => this.__countField = value;
    }

    public string certkeyname
    {
      get => this.certkeynameField;
      set => this.certkeynameField = value;
    }

    internal override base_resource[] get_nitro_response(
      nitro_service service,
      string response)
    {
      sslcertchain.sslcertchain_response sslcertchainResponse = new sslcertchain.sslcertchain_response();
      sslcertchain.sslcertchain_response resource = (sslcertchain.sslcertchain_response) service.get_payload_formatter().string_to_resource(sslcertchainResponse.GetType(), response);
      if (resource.errorcode != 0)
      {
        if (resource.errorcode == 444)
          service.clear_session();
        if (resource.severity == null)
          throw new nitro_exception(resource.message, resource.errorcode);
        if (resource.severity.Equals("ERROR"))
          throw new nitro_exception(resource.message, resource.errorcode);
      }
      return (base_resource[]) resource.sslcertchain;
    }

    internal override string get_object_name() => this.certkeyname;

    public static sslcertchain[] get(nitro_service service) => (sslcertchain[]) new sslcertchain().get_resources(service, (options) null);

    public static sslcertchain[] get(nitro_service service, options option) => (sslcertchain[]) new sslcertchain().get_resources(service, option);

    public static sslcertchain get(nitro_service service, string certkeyname) => (sslcertchain) new sslcertchain()
    {
      certkeyname = certkeyname
    }.get_resource(service);

    public static sslcertchain[] get(nitro_service service, string[] certkeyname)
    {
      if (certkeyname == null || certkeyname.Length <= 0)
        return (sslcertchain[]) null;
      sslcertchain[] sslcertchainArray1 = new sslcertchain[certkeyname.Length];
      sslcertchain[] sslcertchainArray2 = new sslcertchain[certkeyname.Length];
      for (int index = 0; index < certkeyname.Length; ++index)
      {
        sslcertchainArray2[index] = new sslcertchain();
        sslcertchainArray2[index].certkeyname = certkeyname[index];
        sslcertchainArray1[index] = (sslcertchain) sslcertchainArray2[index].get_resource(service);
      }
      return sslcertchainArray1;
    }

    public static sslcertchain[] get_filtered(nitro_service service, string filter)
    {
      sslcertchain sslcertchain = new sslcertchain();
      options option = new options();
      option.set_filter(filter);
      return (sslcertchain[]) sslcertchain.getfiltered(service, option);
    }

    public static sslcertchain[] get_filtered(
      nitro_service service,
      filtervalue[] filter)
    {
      sslcertchain sslcertchain = new sslcertchain();
      options option = new options();
      option.set_filter(filter);
      return (sslcertchain[]) sslcertchain.getfiltered(service, option);
    }

    public static uint count(nitro_service service)
    {
      sslcertchain sslcertchain = new sslcertchain();
      options option = new options();
      option.set_count(true);
      sslcertchain[] resources = (sslcertchain[]) sslcertchain.get_resources(service, option);
      return resources != null && resources.Length > 0 ? resources[0].__count.Value : 0U;
    }

    public static uint count_filtered(nitro_service service, string filter)
    {
      sslcertchain sslcertchain = new sslcertchain();
      options option = new options();
      option.set_count(true);
      option.set_filter(filter);
      sslcertchain[] sslcertchainArray = (sslcertchain[]) sslcertchain.getfiltered(service, option);
      return sslcertchainArray != null && sslcertchainArray.Length > 0 ? sslcertchainArray[0].__count.Value : 0U;
    }

    public static uint count_filtered(nitro_service service, filtervalue[] filter)
    {
      sslcertchain sslcertchain = new sslcertchain();
      options option = new options();
      option.set_count(true);
      option.set_filter(filter);
      sslcertchain[] sslcertchainArray = (sslcertchain[]) sslcertchain.getfiltered(service, option);
      return sslcertchainArray != null && sslcertchainArray.Length > 0 ? sslcertchainArray[0].__count.Value : 0U;
    }

    private class sslcertchain_response : base_response
    {
      public sslcertchain[] sslcertchain = (sslcertchain[]) null;
    }
  }
}
