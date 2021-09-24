// Decompiled with JetBrains decompiler
// Type: com.citrix.netscaler.nitro.resource.config.dns.dnsview_gslbservice_binding
// Assembly: nitro, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 6CF5DDEF-E052-4F9D-953F-6644F8378A66


using com.citrix.netscaler.nitro.exception;
using com.citrix.netscaler.nitro.resource.Base;
using com.citrix.netscaler.nitro.service;
using com.citrix.netscaler.nitro.util;

namespace com.citrix.netscaler.nitro.resource.config.dns
{
  public class dnsview_gslbservice_binding : base_resource
  {
    private string gslbservicenameField = (string) null;
    private string ipaddressField = (string) null;
    private string viewnameField = (string) null;
    private uint? __countField = new uint?();

    public uint? __count
    {
      get => this.__countField;
      set => this.__countField = value;
    }

    public string viewname
    {
      get => this.viewnameField;
      set => this.viewnameField = value;
    }

    public string gslbservicename
    {
      get => this.gslbservicenameField;
      set => this.gslbservicenameField = value;
    }

    public string ipaddress
    {
      get => this.ipaddressField;
      private set => this.ipaddressField = value;
    }

    internal override base_resource[] get_nitro_response(
      nitro_service service,
      string response)
    {
      dnsview_gslbservice_binding.dnsview_gslbservice_binding_response gslbserviceBindingResponse = new dnsview_gslbservice_binding.dnsview_gslbservice_binding_response();
      dnsview_gslbservice_binding.dnsview_gslbservice_binding_response resource = (dnsview_gslbservice_binding.dnsview_gslbservice_binding_response) service.get_payload_formatter().string_to_resource(gslbserviceBindingResponse.GetType(), response);
      if (resource.errorcode != 0)
      {
        if (resource.errorcode == 444)
          service.clear_session();
        if (resource.severity == null)
          throw new nitro_exception(resource.message, resource.errorcode);
        if (resource.severity.Equals("ERROR"))
          throw new nitro_exception(resource.message, resource.errorcode);
      }
      return (base_resource[]) resource.dnsview_gslbservice_binding;
    }

    internal override string get_object_name() => this.viewname;

    public static dnsview_gslbservice_binding[] get(
      nitro_service service,
      string viewname)
    {
      return (dnsview_gslbservice_binding[]) new dnsview_gslbservice_binding()
      {
        viewname = viewname
      }.get_resources(service, (options) null);
    }

    public static dnsview_gslbservice_binding[] get_filtered(
      nitro_service service,
      string viewname,
      string filter)
    {
      dnsview_gslbservice_binding gslbserviceBinding = new dnsview_gslbservice_binding();
      gslbserviceBinding.viewname = viewname;
      options option = new options();
      option.set_filter(filter);
      return (dnsview_gslbservice_binding[]) gslbserviceBinding.getfiltered(service, option);
    }

    public static dnsview_gslbservice_binding[] get_filtered(
      nitro_service service,
      string viewname,
      filtervalue[] filter)
    {
      dnsview_gslbservice_binding gslbserviceBinding = new dnsview_gslbservice_binding();
      gslbserviceBinding.viewname = viewname;
      options option = new options();
      option.set_filter(filter);
      return (dnsview_gslbservice_binding[]) gslbserviceBinding.getfiltered(service, option);
    }

    public static uint count(nitro_service service, string viewname)
    {
      dnsview_gslbservice_binding gslbserviceBinding = new dnsview_gslbservice_binding();
      gslbserviceBinding.viewname = viewname;
      options option = new options();
      option.set_count(true);
      dnsview_gslbservice_binding[] resources = (dnsview_gslbservice_binding[]) gslbserviceBinding.get_resources(service, option);
      return resources != null && resources.Length > 0 ? resources[0].__count.Value : 0U;
    }

    public static uint count_filtered(nitro_service service, string viewname, string filter)
    {
      dnsview_gslbservice_binding gslbserviceBinding = new dnsview_gslbservice_binding();
      gslbserviceBinding.viewname = viewname;
      options option = new options();
      option.set_count(true);
      option.set_filter(filter);
      dnsview_gslbservice_binding[] gslbserviceBindingArray = (dnsview_gslbservice_binding[]) gslbserviceBinding.getfiltered(service, option);
      return gslbserviceBindingArray != null && gslbserviceBindingArray.Length > 0 ? gslbserviceBindingArray[0].__count.Value : 0U;
    }

    public static uint count_filtered(nitro_service service, string viewname, filtervalue[] filter)
    {
      dnsview_gslbservice_binding gslbserviceBinding = new dnsview_gslbservice_binding();
      gslbserviceBinding.viewname = viewname;
      options option = new options();
      option.set_count(true);
      option.set_filter(filter);
      dnsview_gslbservice_binding[] gslbserviceBindingArray = (dnsview_gslbservice_binding[]) gslbserviceBinding.getfiltered(service, option);
      return gslbserviceBindingArray != null && gslbserviceBindingArray.Length > 0 ? gslbserviceBindingArray[0].__count.Value : 0U;
    }

    private class dnsview_gslbservice_binding_response : base_response
    {
      public dnsview_gslbservice_binding[] dnsview_gslbservice_binding = (dnsview_gslbservice_binding[]) null;
    }
  }
}
