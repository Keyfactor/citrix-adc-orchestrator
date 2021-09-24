// Decompiled with JetBrains decompiler
// Type: com.citrix.netscaler.nitro.resource.config.gslb.gslbservice_dnsview_binding
// Assembly: nitro, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 6CF5DDEF-E052-4F9D-953F-6644F8378A66


using com.citrix.netscaler.nitro.exception;
using com.citrix.netscaler.nitro.resource.Base;
using com.citrix.netscaler.nitro.service;
using com.citrix.netscaler.nitro.util;

namespace com.citrix.netscaler.nitro.resource.config.gslb
{
  public class gslbservice_dnsview_binding : base_resource
  {
    private string viewnameField = (string) null;
    private string viewipField = (string) null;
    private string servicenameField = (string) null;
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

    public string servicename
    {
      get => this.servicenameField;
      set => this.servicenameField = value;
    }

    public string viewip
    {
      get => this.viewipField;
      set => this.viewipField = value;
    }

    internal override base_resource[] get_nitro_response(
      nitro_service service,
      string response)
    {
      gslbservice_dnsview_binding.gslbservice_dnsview_binding_response dnsviewBindingResponse = new gslbservice_dnsview_binding.gslbservice_dnsview_binding_response();
      gslbservice_dnsview_binding.gslbservice_dnsview_binding_response resource = (gslbservice_dnsview_binding.gslbservice_dnsview_binding_response) service.get_payload_formatter().string_to_resource(dnsviewBindingResponse.GetType(), response);
      if (resource.errorcode != 0)
      {
        if (resource.errorcode == 444)
          service.clear_session();
        if (resource.severity == null)
          throw new nitro_exception(resource.message, resource.errorcode);
        if (resource.severity.Equals("ERROR"))
          throw new nitro_exception(resource.message, resource.errorcode);
      }
      return (base_resource[]) resource.gslbservice_dnsview_binding;
    }

    internal override string get_object_name() => this.servicename;

    public static base_response add(
      nitro_service client,
      gslbservice_dnsview_binding resource)
    {
      return new gslbservice_dnsview_binding()
      {
        servicename = resource.servicename,
        viewname = resource.viewname,
        viewip = resource.viewip
      }.update_resource(client);
    }

    public static base_responses add(
      nitro_service client,
      gslbservice_dnsview_binding[] resources)
    {
      base_responses baseResponses = (base_responses) null;
      if (resources != null && resources.Length > 0)
      {
        gslbservice_dnsview_binding[] gslbserviceDnsviewBindingArray = new gslbservice_dnsview_binding[resources.Length];
        for (int index = 0; index < resources.Length; ++index)
        {
          gslbserviceDnsviewBindingArray[index] = new gslbservice_dnsview_binding();
          gslbserviceDnsviewBindingArray[index].servicename = resources[index].servicename;
          gslbserviceDnsviewBindingArray[index].viewname = resources[index].viewname;
          gslbserviceDnsviewBindingArray[index].viewip = resources[index].viewip;
        }
        baseResponses = base_resource.update_bulk_request(client, (base_resource[]) gslbserviceDnsviewBindingArray);
      }
      return baseResponses;
    }

    public static base_response delete(
      nitro_service client,
      gslbservice_dnsview_binding resource)
    {
      return new gslbservice_dnsview_binding()
      {
        servicename = resource.servicename,
        viewname = resource.viewname
      }.delete_resource(client);
    }

    public static base_responses delete(
      nitro_service client,
      gslbservice_dnsview_binding[] resources)
    {
      base_responses baseResponses = (base_responses) null;
      if (resources != null && resources.Length > 0)
      {
        gslbservice_dnsview_binding[] gslbserviceDnsviewBindingArray = new gslbservice_dnsview_binding[resources.Length];
        for (int index = 0; index < resources.Length; ++index)
        {
          gslbserviceDnsviewBindingArray[index] = new gslbservice_dnsview_binding();
          gslbserviceDnsviewBindingArray[index].servicename = resources[index].servicename;
          gslbserviceDnsviewBindingArray[index].viewname = resources[index].viewname;
        }
        baseResponses = base_resource.delete_bulk_request(client, (base_resource[]) gslbserviceDnsviewBindingArray);
      }
      return baseResponses;
    }

    public static gslbservice_dnsview_binding[] get(
      nitro_service service,
      string servicename)
    {
      return (gslbservice_dnsview_binding[]) new gslbservice_dnsview_binding()
      {
        servicename = servicename
      }.get_resources(service, (options) null);
    }

    public static gslbservice_dnsview_binding[] get_filtered(
      nitro_service service,
      string servicename,
      string filter)
    {
      gslbservice_dnsview_binding gslbserviceDnsviewBinding = new gslbservice_dnsview_binding();
      gslbserviceDnsviewBinding.servicename = servicename;
      options option = new options();
      option.set_filter(filter);
      return (gslbservice_dnsview_binding[]) gslbserviceDnsviewBinding.getfiltered(service, option);
    }

    public static gslbservice_dnsview_binding[] get_filtered(
      nitro_service service,
      string servicename,
      filtervalue[] filter)
    {
      gslbservice_dnsview_binding gslbserviceDnsviewBinding = new gslbservice_dnsview_binding();
      gslbserviceDnsviewBinding.servicename = servicename;
      options option = new options();
      option.set_filter(filter);
      return (gslbservice_dnsview_binding[]) gslbserviceDnsviewBinding.getfiltered(service, option);
    }

    public static uint count(nitro_service service, string servicename)
    {
      gslbservice_dnsview_binding gslbserviceDnsviewBinding = new gslbservice_dnsview_binding();
      gslbserviceDnsviewBinding.servicename = servicename;
      options option = new options();
      option.set_count(true);
      gslbservice_dnsview_binding[] resources = (gslbservice_dnsview_binding[]) gslbserviceDnsviewBinding.get_resources(service, option);
      return resources != null && resources.Length > 0 ? resources[0].__count.Value : 0U;
    }

    public static uint count_filtered(nitro_service service, string servicename, string filter)
    {
      gslbservice_dnsview_binding gslbserviceDnsviewBinding = new gslbservice_dnsview_binding();
      gslbserviceDnsviewBinding.servicename = servicename;
      options option = new options();
      option.set_count(true);
      option.set_filter(filter);
      gslbservice_dnsview_binding[] gslbserviceDnsviewBindingArray = (gslbservice_dnsview_binding[]) gslbserviceDnsviewBinding.getfiltered(service, option);
      return gslbserviceDnsviewBindingArray != null && gslbserviceDnsviewBindingArray.Length > 0 ? gslbserviceDnsviewBindingArray[0].__count.Value : 0U;
    }

    public static uint count_filtered(
      nitro_service service,
      string servicename,
      filtervalue[] filter)
    {
      gslbservice_dnsview_binding gslbserviceDnsviewBinding = new gslbservice_dnsview_binding();
      gslbserviceDnsviewBinding.servicename = servicename;
      options option = new options();
      option.set_count(true);
      option.set_filter(filter);
      gslbservice_dnsview_binding[] gslbserviceDnsviewBindingArray = (gslbservice_dnsview_binding[]) gslbserviceDnsviewBinding.getfiltered(service, option);
      return gslbserviceDnsviewBindingArray != null && gslbserviceDnsviewBindingArray.Length > 0 ? gslbserviceDnsviewBindingArray[0].__count.Value : 0U;
    }

    private class gslbservice_dnsview_binding_response : base_response
    {
      public gslbservice_dnsview_binding[] gslbservice_dnsview_binding = (gslbservice_dnsview_binding[]) null;
    }

    public static class monstateEnum
    {
      public const string ENABLED = "ENABLED";
      public const string DISABLED = "DISABLED";
    }
  }
}
