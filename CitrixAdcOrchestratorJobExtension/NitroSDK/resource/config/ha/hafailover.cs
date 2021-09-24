// Decompiled with JetBrains decompiler
// Type: com.citrix.netscaler.nitro.resource.config.ha.hafailover
// Assembly: nitro, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 6CF5DDEF-E052-4F9D-953F-6644F8378A66


using com.citrix.netscaler.nitro.exception;
using com.citrix.netscaler.nitro.resource.Base;
using com.citrix.netscaler.nitro.service;

namespace com.citrix.netscaler.nitro.resource.config.ha
{
  public class hafailover : base_resource
  {
    private bool? forceField = new bool?();

    public bool? force
    {
      get => this.forceField;
      set => this.forceField = value;
    }

    internal override base_resource[] get_nitro_response(
      nitro_service service,
      string response)
    {
      hafailover[] hafailoverArray = new hafailover[1];
      hafailover.hafailover_response hafailoverResponse = new hafailover.hafailover_response();
      hafailover.hafailover_response resource = (hafailover.hafailover_response) service.get_payload_formatter().string_to_resource(hafailoverResponse.GetType(), response);
      if (resource.errorcode != 0)
      {
        if (resource.errorcode == 444)
          service.clear_session();
        if (resource.severity == null)
          throw new nitro_exception(resource.message, resource.errorcode);
        if (resource.severity.Equals("ERROR"))
          throw new nitro_exception(resource.message, resource.errorcode);
      }
      hafailoverArray[0] = resource.hafailover;
      return (base_resource[]) hafailoverArray;
    }

    internal override string get_object_name() => (string) null;

    public static base_response Force(nitro_service client, hafailover resource) => new hafailover()
    {
      force = resource.force
    }.perform_operation_byaction(client, nameof (Force));

    private class hafailover_response : base_response
    {
      public hafailover hafailover = (hafailover) null;
    }
  }
}
