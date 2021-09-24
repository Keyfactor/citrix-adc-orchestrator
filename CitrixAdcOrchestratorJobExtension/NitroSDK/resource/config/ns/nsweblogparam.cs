// Decompiled with JetBrains decompiler
// Type: com.citrix.netscaler.nitro.resource.config.ns.nsweblogparam
// Assembly: nitro, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 6CF5DDEF-E052-4F9D-953F-6644F8378A66


using com.citrix.netscaler.nitro.exception;
using com.citrix.netscaler.nitro.resource.Base;
using com.citrix.netscaler.nitro.service;

namespace com.citrix.netscaler.nitro.resource.config.ns
{
  public class nsweblogparam : base_resource
  {
    private uint? buffersizembField = new uint?();
    private string[] customreqhdrsField = (string[]) null;
    private string[] customrsphdrsField = (string[]) null;

    public uint? buffersizemb
    {
      get => this.buffersizembField;
      set => this.buffersizembField = value;
    }

    public string[] customreqhdrs
    {
      get => this.customreqhdrsField;
      set => this.customreqhdrsField = value;
    }

    public string[] customrsphdrs
    {
      get => this.customrsphdrsField;
      set => this.customrsphdrsField = value;
    }

    internal override base_resource[] get_nitro_response(
      nitro_service service,
      string response)
    {
      nsweblogparam[] nsweblogparamArray = new nsweblogparam[1];
      nsweblogparam.nsweblogparam_response nsweblogparamResponse = new nsweblogparam.nsweblogparam_response();
      nsweblogparam.nsweblogparam_response resource = (nsweblogparam.nsweblogparam_response) service.get_payload_formatter().string_to_resource(nsweblogparamResponse.GetType(), response);
      if (resource.errorcode != 0)
      {
        if (resource.errorcode == 444)
          service.clear_session();
        if (resource.severity == null)
          throw new nitro_exception(resource.message, resource.errorcode);
        if (resource.severity.Equals("ERROR"))
          throw new nitro_exception(resource.message, resource.errorcode);
      }
      nsweblogparamArray[0] = resource.nsweblogparam;
      return (base_resource[]) nsweblogparamArray;
    }

    internal override string get_object_name() => (string) null;

    public static base_response update(nitro_service client, nsweblogparam resource) => new nsweblogparam()
    {
      buffersizemb = resource.buffersizemb,
      customreqhdrs = resource.customreqhdrs,
      customrsphdrs = resource.customrsphdrs
    }.update_resource(client);

    public static base_response unset(
      nitro_service client,
      nsweblogparam resource,
      string[] args)
    {
      return new nsweblogparam().unset_resource(client, args);
    }

    public static nsweblogparam get(nitro_service service) => ((nsweblogparam[]) new nsweblogparam().get_resources(service, (options) null))[0];

    public static nsweblogparam get(nitro_service service, options option) => ((nsweblogparam[]) new nsweblogparam().get_resources(service, option))[0];

    private class nsweblogparam_response : base_response
    {
      public nsweblogparam nsweblogparam = (nsweblogparam) null;
    }
  }
}
