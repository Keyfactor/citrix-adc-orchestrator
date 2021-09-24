// Decompiled with JetBrains decompiler
// Type: com.citrix.netscaler.nitro.resource.config.system.systemcountergroup
// Assembly: nitro, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 6CF5DDEF-E052-4F9D-953F-6644F8378A66


using com.citrix.netscaler.nitro.exception;
using com.citrix.netscaler.nitro.resource.Base;
using com.citrix.netscaler.nitro.service;
using com.citrix.netscaler.nitro.util;

namespace com.citrix.netscaler.nitro.resource.config.system
{
  public class systemcountergroup : base_resource
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
      systemcountergroup[] systemcountergroupArray = new systemcountergroup[1];
      systemcountergroup.systemcountergroup_response systemcountergroupResponse = new systemcountergroup.systemcountergroup_response();
      systemcountergroup.systemcountergroup_response resource = (systemcountergroup.systemcountergroup_response) service.get_payload_formatter().string_to_resource(systemcountergroupResponse.GetType(), response);
      if (resource.errorcode != 0)
      {
        if (resource.errorcode == 444)
          service.clear_session();
        if (resource.severity == null)
          throw new nitro_exception(resource.message, resource.errorcode);
        if (resource.severity.Equals("ERROR"))
          throw new nitro_exception(resource.message, resource.errorcode);
      }
      systemcountergroupArray[0] = resource.systemcountergroup;
      return (base_resource[]) systemcountergroupArray;
    }

    internal override string get_object_name() => (string) null;

    public static systemcountergroup get(nitro_service service) => ((systemcountergroup[]) new systemcountergroup().get_resources(service, (options) null))[0];

    public static systemcountergroup get(nitro_service service, options option) => ((systemcountergroup[]) new systemcountergroup().get_resources(service, option))[0];

    public static systemcountergroup[] get(
      nitro_service service,
      systemcountergroup_args args)
    {
      systemcountergroup systemcountergroup = new systemcountergroup();
      options option = new options();
      option.set_args(nitro_util.object_to_string_withoutquotes((object) args));
      return (systemcountergroup[]) systemcountergroup.get_resources(service, option);
    }

    private class systemcountergroup_response : base_response
    {
      public systemcountergroup systemcountergroup = (systemcountergroup) null;
    }
  }
}
