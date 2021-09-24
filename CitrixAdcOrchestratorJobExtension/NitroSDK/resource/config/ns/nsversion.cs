// Decompiled with JetBrains decompiler
// Type: com.citrix.netscaler.nitro.resource.config.ns.nsversion
// Assembly: nitro, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 6CF5DDEF-E052-4F9D-953F-6644F8378A66


using com.citrix.netscaler.nitro.exception;
using com.citrix.netscaler.nitro.resource.Base;
using com.citrix.netscaler.nitro.service;

namespace com.citrix.netscaler.nitro.resource.config.ns
{
  public class nsversion : base_resource
  {
    private string versionField = (string) null;
    private uint? modeField = new uint?();

    public string version
    {
      get => this.versionField;
      private set => this.versionField = value;
    }

    public uint? mode
    {
      get => this.modeField;
      private set => this.modeField = value;
    }

    internal override base_resource[] get_nitro_response(
      nitro_service service,
      string response)
    {
      nsversion[] nsversionArray = new nsversion[1];
      nsversion.nsversion_response nsversionResponse = new nsversion.nsversion_response();
      nsversion.nsversion_response resource = (nsversion.nsversion_response) service.get_payload_formatter().string_to_resource(nsversionResponse.GetType(), response);
      if (resource.errorcode != 0)
      {
        if (resource.errorcode == 444)
          service.clear_session();
        if (resource.severity == null)
          throw new nitro_exception(resource.message, resource.errorcode);
        if (resource.severity.Equals("ERROR"))
          throw new nitro_exception(resource.message, resource.errorcode);
      }
      nsversionArray[0] = resource.nsversion;
      return (base_resource[]) nsversionArray;
    }

    internal override string get_object_name() => (string) null;

    public static nsversion get(nitro_service service) => ((nsversion[]) new nsversion().get_resources(service, (options) null))[0];

    public static nsversion get(nitro_service service, options option) => ((nsversion[]) new nsversion().get_resources(service, option))[0];

    private class nsversion_response : base_response
    {
      public nsversion nsversion = (nsversion) null;
    }
  }
}
