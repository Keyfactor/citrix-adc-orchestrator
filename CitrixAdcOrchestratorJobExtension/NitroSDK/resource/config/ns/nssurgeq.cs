// Decompiled with JetBrains decompiler
// Type: com.citrix.netscaler.nitro.resource.config.ns.nssurgeq
// Assembly: nitro, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 6CF5DDEF-E052-4F9D-953F-6644F8378A66


using com.citrix.netscaler.nitro.exception;
using com.citrix.netscaler.nitro.resource.Base;
using com.citrix.netscaler.nitro.service;

namespace com.citrix.netscaler.nitro.resource.config.ns
{
  public class nssurgeq : base_resource
  {
    private string nameField = (string) null;
    private string servernameField = (string) null;
    private ushort? portField = new ushort?();

    public string name
    {
      get => this.nameField;
      set => this.nameField = value;
    }

    public string servername
    {
      get => this.servernameField;
      set => this.servernameField = value;
    }

    public ushort? port
    {
      get => this.portField;
      set => this.portField = value;
    }

    internal override base_resource[] get_nitro_response(
      nitro_service service,
      string response)
    {
      nssurgeq[] nssurgeqArray = new nssurgeq[1];
      nssurgeq.nssurgeq_response nssurgeqResponse = new nssurgeq.nssurgeq_response();
      nssurgeq.nssurgeq_response resource = (nssurgeq.nssurgeq_response) service.get_payload_formatter().string_to_resource(nssurgeqResponse.GetType(), response);
      if (resource.errorcode != 0)
      {
        if (resource.errorcode == 444)
          service.clear_session();
        if (resource.severity == null)
          throw new nitro_exception(resource.message, resource.errorcode);
        if (resource.severity.Equals("ERROR"))
          throw new nitro_exception(resource.message, resource.errorcode);
      }
      nssurgeqArray[0] = resource.nssurgeq;
      return (base_resource[]) nssurgeqArray;
    }

    internal override string get_object_name() => (string) null;

    public static base_response flush(nitro_service client, nssurgeq resource) => new nssurgeq()
    {
      name = resource.name,
      servername = resource.servername,
      port = resource.port
    }.perform_operation_byaction(client, nameof (flush));

    private class nssurgeq_response : base_response
    {
      public nssurgeq nssurgeq = (nssurgeq) null;
    }
  }
}
