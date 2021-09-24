// Decompiled with JetBrains decompiler
// Type: com.citrix.netscaler.nitro.resource.config.network.ptp
// Assembly: nitro, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 6CF5DDEF-E052-4F9D-953F-6644F8378A66


using com.citrix.netscaler.nitro.exception;
using com.citrix.netscaler.nitro.resource.Base;
using com.citrix.netscaler.nitro.service;

namespace com.citrix.netscaler.nitro.resource.config.network
{
  public class ptp : base_resource
  {
    private string stateField = (string) null;

    public string state
    {
      get => this.stateField;
      set => this.stateField = value;
    }

    internal override base_resource[] get_nitro_response(
      nitro_service service,
      string response)
    {
      ptp[] ptpArray = new ptp[1];
      ptp.ptp_response ptpResponse = new ptp.ptp_response();
      ptp.ptp_response resource = (ptp.ptp_response) service.get_payload_formatter().string_to_resource(ptpResponse.GetType(), response);
      if (resource.errorcode != 0)
      {
        if (resource.errorcode == 444)
          service.clear_session();
        if (resource.severity == null)
          throw new nitro_exception(resource.message, resource.errorcode);
        if (resource.severity.Equals("ERROR"))
          throw new nitro_exception(resource.message, resource.errorcode);
      }
      ptpArray[0] = resource.ptp;
      return (base_resource[]) ptpArray;
    }

    internal override string get_object_name() => (string) null;

    public static base_response update(nitro_service client, ptp resource) => new ptp()
    {
      state = resource.state
    }.update_resource(client);

    public static ptp get(nitro_service service) => ((ptp[]) new ptp().get_resources(service, (options) null))[0];

    public static ptp get(nitro_service service, options option) => ((ptp[]) new ptp().get_resources(service, option))[0];

    private class ptp_response : base_response
    {
      public ptp ptp = (ptp) null;
    }

    public static class stateEnum
    {
      public const string DISABLE = "DISABLE";
      public const string ENABLE = "ENABLE";
    }
  }
}
