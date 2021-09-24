// Decompiled with JetBrains decompiler
// Type: com.citrix.netscaler.nitro.resource.config.stream.streamsession
// Assembly: nitro, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 6CF5DDEF-E052-4F9D-953F-6644F8378A66


using com.citrix.netscaler.nitro.exception;
using com.citrix.netscaler.nitro.resource.Base;
using com.citrix.netscaler.nitro.service;

namespace com.citrix.netscaler.nitro.resource.config.stream
{
  public class streamsession : base_resource
  {
    private string nameField = (string) null;

    public string name
    {
      get => this.nameField;
      set => this.nameField = value;
    }

    internal override base_resource[] get_nitro_response(
      nitro_service service,
      string response)
    {
      streamsession[] streamsessionArray = new streamsession[1];
      streamsession.streamsession_response streamsessionResponse = new streamsession.streamsession_response();
      streamsession.streamsession_response resource = (streamsession.streamsession_response) service.get_payload_formatter().string_to_resource(streamsessionResponse.GetType(), response);
      if (resource.errorcode != 0)
      {
        if (resource.errorcode == 444)
          service.clear_session();
        if (resource.severity == null)
          throw new nitro_exception(resource.message, resource.errorcode);
        if (resource.severity.Equals("ERROR"))
          throw new nitro_exception(resource.message, resource.errorcode);
      }
      streamsessionArray[0] = resource.streamsession;
      return (base_resource[]) streamsessionArray;
    }

    internal override string get_object_name() => (string) null;

    public static base_response clear(nitro_service client, streamsession resource) => new streamsession()
    {
      name = resource.name
    }.perform_operation_byaction(client, nameof (clear));

    private class streamsession_response : base_response
    {
      public streamsession streamsession = (streamsession) null;
    }
  }
}
