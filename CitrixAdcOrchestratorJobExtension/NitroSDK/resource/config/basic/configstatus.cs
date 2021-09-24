// Decompiled with JetBrains decompiler
// Type: com.citrix.netscaler.nitro.resource.config.basic.configstatus
// Assembly: nitro, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 6CF5DDEF-E052-4F9D-953F-6644F8378A66


using com.citrix.netscaler.nitro.exception;
using com.citrix.netscaler.nitro.resource.Base;
using com.citrix.netscaler.nitro.service;
using com.citrix.netscaler.nitro.util;

namespace com.citrix.netscaler.nitro.resource.config.basic
{
  public class configstatus : base_resource
  {
    private string consistentField = (string) null;
    private uint? culpritcoreField = new uint?();
    private uint? coreField = new uint?();
    private string culpritcoreconfstringField = (string) null;
    private string coreconfstringField = (string) null;
    private uint? __countField = new uint?();

    public uint? __count
    {
      get => this.__countField;
      private set => this.__countField = value;
    }

    public string consistent
    {
      get => this.consistentField;
      private set => this.consistentField = value;
    }

    public uint? culpritcore
    {
      get => this.culpritcoreField;
      private set => this.culpritcoreField = value;
    }

    public uint? core
    {
      get => this.coreField;
      private set => this.coreField = value;
    }

    public string culpritcoreconfstring
    {
      get => this.culpritcoreconfstringField;
      private set => this.culpritcoreconfstringField = value;
    }

    public string coreconfstring
    {
      get => this.coreconfstringField;
      private set => this.coreconfstringField = value;
    }

    internal override base_resource[] get_nitro_response(
      nitro_service service,
      string response)
    {
      configstatus.configstatus_response configstatusResponse = new configstatus.configstatus_response();
      configstatus.configstatus_response resource = (configstatus.configstatus_response) service.get_payload_formatter().string_to_resource(configstatusResponse.GetType(), response);
      if (resource.errorcode != 0)
      {
        if (resource.errorcode == 444)
          service.clear_session();
        if (resource.severity == null)
          throw new nitro_exception(resource.message, resource.errorcode);
        if (resource.severity.Equals("ERROR"))
          throw new nitro_exception(resource.message, resource.errorcode);
      }
      return (base_resource[]) resource.configstatus;
    }

    internal override string get_object_name() => (string) null;

    public static configstatus[] get(nitro_service service) => (configstatus[]) new configstatus().get_resources(service, (options) null);

    public static configstatus[] get(nitro_service service, options option) => (configstatus[]) new configstatus().get_resources(service, option);

    public static configstatus[] get_filtered(nitro_service service, string filter)
    {
      configstatus configstatus = new configstatus();
      options option = new options();
      option.set_filter(filter);
      return (configstatus[]) configstatus.getfiltered(service, option);
    }

    public static configstatus[] get_filtered(
      nitro_service service,
      filtervalue[] filter)
    {
      configstatus configstatus = new configstatus();
      options option = new options();
      option.set_filter(filter);
      return (configstatus[]) configstatus.getfiltered(service, option);
    }

    public static uint count(nitro_service service)
    {
      configstatus configstatus = new configstatus();
      options option = new options();
      option.set_count(true);
      configstatus[] resources = (configstatus[]) configstatus.get_resources(service, option);
      return resources != null && resources.Length > 0 ? resources[0].__count.Value : 0U;
    }

    public static uint count_filtered(nitro_service service, string filter)
    {
      configstatus configstatus = new configstatus();
      options option = new options();
      option.set_count(true);
      option.set_filter(filter);
      configstatus[] configstatusArray = (configstatus[]) configstatus.getfiltered(service, option);
      return configstatusArray != null && configstatusArray.Length > 0 ? configstatusArray[0].__count.Value : 0U;
    }

    public static uint count_filtered(nitro_service service, filtervalue[] filter)
    {
      configstatus configstatus = new configstatus();
      options option = new options();
      option.set_count(true);
      option.set_filter(filter);
      configstatus[] configstatusArray = (configstatus[]) configstatus.getfiltered(service, option);
      return configstatusArray != null && configstatusArray.Length > 0 ? configstatusArray[0].__count.Value : 0U;
    }

    private class configstatus_response : base_response
    {
      public configstatus[] configstatus = (configstatus[]) null;
    }

    public static class consistentEnum
    {
      public const string YES = "YES";
      public const string NO = "NO";
    }
  }
}
