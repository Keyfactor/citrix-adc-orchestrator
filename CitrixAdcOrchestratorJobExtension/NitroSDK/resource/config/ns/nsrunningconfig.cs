// Decompiled with JetBrains decompiler
// Type: com.citrix.netscaler.nitro.resource.config.ns.nsrunningconfig
// Assembly: nitro, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 6CF5DDEF-E052-4F9D-953F-6644F8378A66


using com.citrix.netscaler.nitro.exception;
using com.citrix.netscaler.nitro.resource.Base;
using com.citrix.netscaler.nitro.service;
using com.citrix.netscaler.nitro.util;

namespace com.citrix.netscaler.nitro.resource.config.ns
{
  public class nsrunningconfig : base_resource
  {
    private bool? withdefaultsField = new bool?();
    private string responseField = (string) null;

    public bool? withdefaults
    {
      get => this.withdefaultsField;
      set => this.withdefaultsField = value;
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
      nsrunningconfig[] nsrunningconfigArray = new nsrunningconfig[1];
      nsrunningconfig.nsrunningconfig_response nsrunningconfigResponse = new nsrunningconfig.nsrunningconfig_response();
      nsrunningconfig.nsrunningconfig_response resource = (nsrunningconfig.nsrunningconfig_response) service.get_payload_formatter().string_to_resource(nsrunningconfigResponse.GetType(), response);
      if (resource.errorcode != 0)
      {
        if (resource.errorcode == 444)
          service.clear_session();
        if (resource.severity == null)
          throw new nitro_exception(resource.message, resource.errorcode);
        if (resource.severity.Equals("ERROR"))
          throw new nitro_exception(resource.message, resource.errorcode);
      }
      nsrunningconfigArray[0] = resource.nsrunningconfig;
      return (base_resource[]) nsrunningconfigArray;
    }

    internal override string get_object_name() => (string) null;

    public static nsrunningconfig get(nitro_service service) => ((nsrunningconfig[]) new nsrunningconfig().get_resources(service, (options) null))[0];

    public static nsrunningconfig get(nitro_service service, options option) => ((nsrunningconfig[]) new nsrunningconfig().get_resources(service, option))[0];

    public static nsrunningconfig[] get(
      nitro_service service,
      nsrunningconfig_args args)
    {
      nsrunningconfig nsrunningconfig = new nsrunningconfig();
      options option = new options();
      option.set_args(nitro_util.object_to_string_withoutquotes((object) args));
      return (nsrunningconfig[]) nsrunningconfig.get_resources(service, option);
    }

    private class nsrunningconfig_response : base_response
    {
      public nsrunningconfig nsrunningconfig = (nsrunningconfig) null;
    }
  }
}
