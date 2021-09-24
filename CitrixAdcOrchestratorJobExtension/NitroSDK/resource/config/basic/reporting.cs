// Decompiled with JetBrains decompiler
// Type: com.citrix.netscaler.nitro.resource.config.basic.reporting
// Assembly: nitro, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 6CF5DDEF-E052-4F9D-953F-6644F8378A66


using com.citrix.netscaler.nitro.exception;
using com.citrix.netscaler.nitro.resource.Base;
using com.citrix.netscaler.nitro.service;

namespace com.citrix.netscaler.nitro.resource.config.basic
{
  public class reporting : base_resource
  {
    private string stateField = (string) null;

    public string state
    {
      get => this.stateField;
      private set => this.stateField = value;
    }

    internal override base_resource[] get_nitro_response(
      nitro_service service,
      string response)
    {
      reporting[] reportingArray = new reporting[1];
      reporting.reporting_response reportingResponse = new reporting.reporting_response();
      reporting.reporting_response resource = (reporting.reporting_response) service.get_payload_formatter().string_to_resource(reportingResponse.GetType(), response);
      if (resource.errorcode != 0)
      {
        if (resource.errorcode == 444)
          service.clear_session();
        if (resource.severity == null)
          throw new nitro_exception(resource.message, resource.errorcode);
        if (resource.severity.Equals("ERROR"))
          throw new nitro_exception(resource.message, resource.errorcode);
      }
      reportingArray[0] = resource.reporting;
      return (base_resource[]) reportingArray;
    }

    internal override string get_object_name() => (string) null;

    public static base_response enable(nitro_service client) => new reporting().perform_operation_byaction(client, nameof (enable));

    public static base_response disable(nitro_service client) => new reporting().perform_operation_byaction(client, nameof (disable));

    public static reporting get(nitro_service service) => ((reporting[]) new reporting().get_resources(service, (options) null))[0];

    public static reporting get(nitro_service service, options option) => ((reporting[]) new reporting().get_resources(service, option))[0];

    private class reporting_response : base_response
    {
      public reporting reporting = (reporting) null;
    }

    public static class stateEnum
    {
      public const string ENABLED = "ENABLED";
      public const string DISABLED = "DISABLED";
    }
  }
}
