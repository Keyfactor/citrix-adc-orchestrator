// Decompiled with JetBrains decompiler
// Type: com.citrix.netscaler.nitro.resource.config.ssl.sslciphersuite
// Assembly: nitro, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 6CF5DDEF-E052-4F9D-953F-6644F8378A66


using com.citrix.netscaler.nitro.exception;
using com.citrix.netscaler.nitro.resource.Base;
using com.citrix.netscaler.nitro.service;
using com.citrix.netscaler.nitro.util;

namespace com.citrix.netscaler.nitro.resource.config.ssl
{
  public class sslciphersuite : base_resource
  {
    private string ciphernameField = (string) null;
    private string descriptionField = (string) null;
    private uint? __countField = new uint?();

    public uint? __count
    {
      get => this.__countField;
      private set => this.__countField = value;
    }

    public string ciphername
    {
      get => this.ciphernameField;
      set => this.ciphernameField = value;
    }

    public string description
    {
      get => this.descriptionField;
      private set => this.descriptionField = value;
    }

    internal override base_resource[] get_nitro_response(
      nitro_service service,
      string response)
    {
      sslciphersuite.sslciphersuite_response sslciphersuiteResponse = new sslciphersuite.sslciphersuite_response();
      sslciphersuite.sslciphersuite_response resource = (sslciphersuite.sslciphersuite_response) service.get_payload_formatter().string_to_resource(sslciphersuiteResponse.GetType(), response);
      if (resource.errorcode != 0)
      {
        if (resource.errorcode == 444)
          service.clear_session();
        if (resource.severity == null)
          throw new nitro_exception(resource.message, resource.errorcode);
        if (resource.severity.Equals("ERROR"))
          throw new nitro_exception(resource.message, resource.errorcode);
      }
      return (base_resource[]) resource.sslciphersuite;
    }

    internal override string get_object_name() => this.ciphername;

    public static sslciphersuite[] get(nitro_service service) => (sslciphersuite[]) new sslciphersuite().get_resources(service, (options) null);

    public static sslciphersuite[] get(nitro_service service, options option) => (sslciphersuite[]) new sslciphersuite().get_resources(service, option);

    public static sslciphersuite get(nitro_service service, string ciphername) => (sslciphersuite) new sslciphersuite()
    {
      ciphername = ciphername
    }.get_resource(service);

    public static sslciphersuite[] get(nitro_service service, string[] ciphername)
    {
      if (ciphername == null || ciphername.Length <= 0)
        return (sslciphersuite[]) null;
      sslciphersuite[] sslciphersuiteArray1 = new sslciphersuite[ciphername.Length];
      sslciphersuite[] sslciphersuiteArray2 = new sslciphersuite[ciphername.Length];
      for (int index = 0; index < ciphername.Length; ++index)
      {
        sslciphersuiteArray2[index] = new sslciphersuite();
        sslciphersuiteArray2[index].ciphername = ciphername[index];
        sslciphersuiteArray1[index] = (sslciphersuite) sslciphersuiteArray2[index].get_resource(service);
      }
      return sslciphersuiteArray1;
    }

    public static sslciphersuite[] get_filtered(nitro_service service, string filter)
    {
      sslciphersuite sslciphersuite = new sslciphersuite();
      options option = new options();
      option.set_filter(filter);
      return (sslciphersuite[]) sslciphersuite.getfiltered(service, option);
    }

    public static sslciphersuite[] get_filtered(
      nitro_service service,
      filtervalue[] filter)
    {
      sslciphersuite sslciphersuite = new sslciphersuite();
      options option = new options();
      option.set_filter(filter);
      return (sslciphersuite[]) sslciphersuite.getfiltered(service, option);
    }

    public static uint count(nitro_service service)
    {
      sslciphersuite sslciphersuite = new sslciphersuite();
      options option = new options();
      option.set_count(true);
      sslciphersuite[] resources = (sslciphersuite[]) sslciphersuite.get_resources(service, option);
      return resources != null && resources.Length > 0 ? resources[0].__count.Value : 0U;
    }

    public static uint count_filtered(nitro_service service, string filter)
    {
      sslciphersuite sslciphersuite = new sslciphersuite();
      options option = new options();
      option.set_count(true);
      option.set_filter(filter);
      sslciphersuite[] sslciphersuiteArray = (sslciphersuite[]) sslciphersuite.getfiltered(service, option);
      return sslciphersuiteArray != null && sslciphersuiteArray.Length > 0 ? sslciphersuiteArray[0].__count.Value : 0U;
    }

    public static uint count_filtered(nitro_service service, filtervalue[] filter)
    {
      sslciphersuite sslciphersuite = new sslciphersuite();
      options option = new options();
      option.set_count(true);
      option.set_filter(filter);
      sslciphersuite[] sslciphersuiteArray = (sslciphersuite[]) sslciphersuite.getfiltered(service, option);
      return sslciphersuiteArray != null && sslciphersuiteArray.Length > 0 ? sslciphersuiteArray[0].__count.Value : 0U;
    }

    private class sslciphersuite_response : base_response
    {
      public sslciphersuite[] sslciphersuite = (sslciphersuite[]) null;
    }
  }
}
