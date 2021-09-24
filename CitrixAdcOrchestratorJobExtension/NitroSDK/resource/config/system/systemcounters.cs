// Decompiled with JetBrains decompiler
// Type: com.citrix.netscaler.nitro.resource.config.system.systemcounters
// Assembly: nitro, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 6CF5DDEF-E052-4F9D-953F-6644F8378A66


using com.citrix.netscaler.nitro.exception;
using com.citrix.netscaler.nitro.resource.Base;
using com.citrix.netscaler.nitro.service;
using com.citrix.netscaler.nitro.util;

namespace com.citrix.netscaler.nitro.resource.config.system
{
  public class systemcounters : base_resource
  {
    private string countergroupField = (string) null;
    private string datasourceField = (string) null;
    private string responseField = (string) null;

    public string countergroup
    {
      get => this.countergroupField;
      set => this.countergroupField = value;
    }

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
      systemcounters[] systemcountersArray = new systemcounters[1];
      systemcounters.systemcounters_response systemcountersResponse = new systemcounters.systemcounters_response();
      systemcounters.systemcounters_response resource = (systemcounters.systemcounters_response) service.get_payload_formatter().string_to_resource(systemcountersResponse.GetType(), response);
      if (resource.errorcode != 0)
      {
        if (resource.errorcode == 444)
          service.clear_session();
        if (resource.severity == null)
          throw new nitro_exception(resource.message, resource.errorcode);
        if (resource.severity.Equals("ERROR"))
          throw new nitro_exception(resource.message, resource.errorcode);
      }
      systemcountersArray[0] = resource.systemcounters;
      return (base_resource[]) systemcountersArray;
    }

    internal override string get_object_name() => (string) null;

    public static systemcounters get(nitro_service service) => ((systemcounters[]) new systemcounters().get_resources(service, (options) null))[0];

    public static systemcounters get(nitro_service service, options option) => ((systemcounters[]) new systemcounters().get_resources(service, option))[0];

    public static systemcounters[] get(
      nitro_service service,
      systemcounters_args args)
    {
      systemcounters systemcounters = new systemcounters();
      options option = new options();
      option.set_args(nitro_util.object_to_string_withoutquotes((object) args));
      return (systemcounters[]) systemcounters.get_resources(service, option);
    }

    private class systemcounters_response : base_response
    {
      public systemcounters systemcounters = (systemcounters) null;
    }
  }
}
