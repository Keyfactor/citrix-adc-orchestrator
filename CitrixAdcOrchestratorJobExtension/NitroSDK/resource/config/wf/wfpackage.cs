// Decompiled with JetBrains decompiler
// Type: com.citrix.netscaler.nitro.resource.config.wf.wfpackage
// Assembly: nitro, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 6CF5DDEF-E052-4F9D-953F-6644F8378A66


using com.citrix.netscaler.nitro.exception;
using com.citrix.netscaler.nitro.resource.Base;
using com.citrix.netscaler.nitro.service;

namespace com.citrix.netscaler.nitro.resource.config.wf
{
  public class wfpackage : base_resource
  {
    private string jreField = (string) null;
    private string wfField = (string) null;

    public string jre
    {
      get => this.jreField;
      set => this.jreField = value;
    }

    public string wf
    {
      get => this.wfField;
      set => this.wfField = value;
    }

    internal override base_resource[] get_nitro_response(
      nitro_service service,
      string response)
    {
      wfpackage[] wfpackageArray = new wfpackage[1];
      wfpackage.wfpackage_response wfpackageResponse = new wfpackage.wfpackage_response();
      wfpackage.wfpackage_response resource = (wfpackage.wfpackage_response) service.get_payload_formatter().string_to_resource(wfpackageResponse.GetType(), response);
      if (resource.errorcode != 0)
      {
        if (resource.errorcode == 444)
          service.clear_session();
        if (resource.severity == null)
          throw new nitro_exception(resource.message, resource.errorcode);
        if (resource.severity.Equals("ERROR"))
          throw new nitro_exception(resource.message, resource.errorcode);
      }
      wfpackageArray[0] = resource.wfpackage;
      return (base_resource[]) wfpackageArray;
    }

    internal override string get_object_name() => (string) null;

    public static base_response Install(nitro_service client, wfpackage resource) => new wfpackage()
    {
      jre = resource.jre,
      wf = resource.wf
    }.perform_operation_byaction(client, nameof (Install));

    public static wfpackage get(nitro_service service) => ((wfpackage[]) new wfpackage().get_resources(service, (options) null))[0];

    public static wfpackage get(nitro_service service, options option) => ((wfpackage[]) new wfpackage().get_resources(service, option))[0];

    private class wfpackage_response : base_response
    {
      public wfpackage wfpackage = (wfpackage) null;
    }
  }
}
