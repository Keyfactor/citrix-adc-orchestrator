// Decompiled with JetBrains decompiler
// Type: com.citrix.netscaler.nitro.resource.config.ssl.sslfipssimtarget
// Assembly: nitro, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 6CF5DDEF-E052-4F9D-953F-6644F8378A66


using com.citrix.netscaler.nitro.exception;
using com.citrix.netscaler.nitro.resource.Base;
using com.citrix.netscaler.nitro.service;

namespace com.citrix.netscaler.nitro.resource.config.ssl
{
  public class sslfipssimtarget : base_resource
  {
    private string keyvectorField = (string) null;
    private string sourcesecretField = (string) null;
    private string certfileField = (string) null;
    private string targetsecretField = (string) null;

    public string keyvector
    {
      get => this.keyvectorField;
      set => this.keyvectorField = value;
    }

    public string sourcesecret
    {
      get => this.sourcesecretField;
      set => this.sourcesecretField = value;
    }

    public string certfile
    {
      get => this.certfileField;
      set => this.certfileField = value;
    }

    public string targetsecret
    {
      get => this.targetsecretField;
      set => this.targetsecretField = value;
    }

    internal override base_resource[] get_nitro_response(
      nitro_service service,
      string response)
    {
      sslfipssimtarget[] sslfipssimtargetArray = new sslfipssimtarget[1];
      sslfipssimtarget.sslfipssimtarget_response sslfipssimtargetResponse = new sslfipssimtarget.sslfipssimtarget_response();
      sslfipssimtarget.sslfipssimtarget_response resource = (sslfipssimtarget.sslfipssimtarget_response) service.get_payload_formatter().string_to_resource(sslfipssimtargetResponse.GetType(), response);
      if (resource.errorcode != 0)
      {
        if (resource.errorcode == 444)
          service.clear_session();
        if (resource.severity == null)
          throw new nitro_exception(resource.message, resource.errorcode);
        if (resource.severity.Equals("ERROR"))
          throw new nitro_exception(resource.message, resource.errorcode);
      }
      sslfipssimtargetArray[0] = resource.sslfipssimtarget;
      return (base_resource[]) sslfipssimtargetArray;
    }

    internal override string get_object_name() => (string) null;

    public static base_response enable(nitro_service client, sslfipssimtarget resource) => new sslfipssimtarget()
    {
      keyvector = resource.keyvector,
      sourcesecret = resource.sourcesecret
    }.perform_operation_byaction(client, nameof (enable));

    public static base_response init(nitro_service client, sslfipssimtarget resource) => new sslfipssimtarget()
    {
      certfile = resource.certfile,
      keyvector = resource.keyvector,
      targetsecret = resource.targetsecret
    }.perform_operation_byaction(client, nameof (init));

    private class sslfipssimtarget_response : base_response
    {
      public sslfipssimtarget sslfipssimtarget = (sslfipssimtarget) null;
    }
  }
}
