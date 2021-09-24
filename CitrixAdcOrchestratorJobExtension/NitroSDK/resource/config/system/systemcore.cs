// Decompiled with JetBrains decompiler
// Type: com.citrix.netscaler.nitro.resource.config.system.systemcore
// Assembly: nitro, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 6CF5DDEF-E052-4F9D-953F-6644F8378A66


using com.citrix.netscaler.nitro.exception;
using com.citrix.netscaler.nitro.resource.Base;
using com.citrix.netscaler.nitro.service;
using com.citrix.netscaler.nitro.util;

namespace com.citrix.netscaler.nitro.resource.config.system
{
  public class systemcore : base_resource
  {
    private string datasourceField = (string) null;
    private string responseField = (string) null;

    public string datasource
    {
      get => this.datasourceField;
      set => this.datasourceField = value;
    }

    public string response
    {
      get => this.responseField;
      private set => this.responseField = value;
    }

    internal override base_resource[] get_nitro_response(
      nitro_service service,
      string response)
    {
      systemcore[] systemcoreArray = new systemcore[1];
      systemcore.systemcore_response systemcoreResponse = new systemcore.systemcore_response();
      systemcore.systemcore_response resource = (systemcore.systemcore_response) service.get_payload_formatter().string_to_resource(systemcoreResponse.GetType(), response);
      if (resource.errorcode != 0)
      {
        if (resource.errorcode == 444)
          service.clear_session();
        if (resource.severity == null)
          throw new nitro_exception(resource.message, resource.errorcode);
        if (resource.severity.Equals("ERROR"))
          throw new nitro_exception(resource.message, resource.errorcode);
      }
      systemcoreArray[0] = resource.systemcore;
      return (base_resource[]) systemcoreArray;
    }

    internal override string get_object_name() => (string) null;

    public static systemcore get(nitro_service service) => ((systemcore[]) new systemcore().get_resources(service, (options) null))[0];

    public static systemcore get(nitro_service service, options option) => ((systemcore[]) new systemcore().get_resources(service, option))[0];

    public static systemcore[] get(nitro_service service, systemcore_args args)
    {
      systemcore systemcore = new systemcore();
      options option = new options();
      option.set_args(nitro_util.object_to_string_withoutquotes((object) args));
      return (systemcore[]) systemcore.get_resources(service, option);
    }

    private class systemcore_response : base_response
    {
      public systemcore systemcore = (systemcore) null;
    }
  }
}
