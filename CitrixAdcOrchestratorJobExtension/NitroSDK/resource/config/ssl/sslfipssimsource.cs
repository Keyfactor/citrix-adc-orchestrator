// Decompiled with JetBrains decompiler
// Type: com.citrix.netscaler.nitro.resource.config.ssl.sslfipssimsource
// Assembly: nitro, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 6CF5DDEF-E052-4F9D-953F-6644F8378A66


using com.citrix.netscaler.nitro.exception;
using com.citrix.netscaler.nitro.resource.Base;
using com.citrix.netscaler.nitro.service;

namespace com.citrix.netscaler.nitro.resource.config.ssl
{
  public class sslfipssimsource : base_resource
  {
    private string targetsecretField = (string) null;
    private string sourcesecretField = (string) null;
    private string certfileField = (string) null;

    public string targetsecret
    {
      get => this.targetsecretField;
      set => this.targetsecretField = value;
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

    internal override base_resource[] get_nitro_response(
      nitro_service service,
      string response)
    {
      sslfipssimsource[] sslfipssimsourceArray = new sslfipssimsource[1];
      sslfipssimsource.sslfipssimsource_response sslfipssimsourceResponse = new sslfipssimsource.sslfipssimsource_response();
      sslfipssimsource.sslfipssimsource_response resource = (sslfipssimsource.sslfipssimsource_response) service.get_payload_formatter().string_to_resource(sslfipssimsourceResponse.GetType(), response);
      if (resource.errorcode != 0)
      {
        if (resource.errorcode == 444)
          service.clear_session();
        if (resource.severity == null)
          throw new nitro_exception(resource.message, resource.errorcode);
        if (resource.severity.Equals("ERROR"))
          throw new nitro_exception(resource.message, resource.errorcode);
      }
      sslfipssimsourceArray[0] = resource.sslfipssimsource;
      return (base_resource[]) sslfipssimsourceArray;
    }

    internal override string get_object_name() => (string) null;

    public static base_response enable(nitro_service client, sslfipssimsource resource) => new sslfipssimsource()
    {
      targetsecret = resource.targetsecret,
      sourcesecret = resource.sourcesecret
    }.perform_operation_byaction(client, nameof (enable));

    public static base_response init(nitro_service client, sslfipssimsource resource) => new sslfipssimsource()
    {
      certfile = resource.certfile
    }.perform_operation_byaction(client, nameof (init));

    private class sslfipssimsource_response : base_response
    {
      public sslfipssimsource sslfipssimsource = (sslfipssimsource) null;
    }
  }
}
