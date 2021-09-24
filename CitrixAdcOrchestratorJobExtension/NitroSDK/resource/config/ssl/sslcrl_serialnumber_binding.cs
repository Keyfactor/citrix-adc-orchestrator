// Decompiled with JetBrains decompiler
// Type: com.citrix.netscaler.nitro.resource.config.ssl.sslcrl_serialnumber_binding
// Assembly: nitro, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 6CF5DDEF-E052-4F9D-953F-6644F8378A66


using com.citrix.netscaler.nitro.exception;
using com.citrix.netscaler.nitro.resource.Base;
using com.citrix.netscaler.nitro.service;
using com.citrix.netscaler.nitro.util;

namespace com.citrix.netscaler.nitro.resource.config.ssl
{
  public class sslcrl_serialnumber_binding : base_resource
  {
    private string numberField = (string) null;
    private string dateField = (string) null;
    private string crlnameField = (string) null;
    private uint? __countField = new uint?();

    public uint? __count
    {
      get => this.__countField;
      set => this.__countField = value;
    }

    public string number
    {
      get => this.numberField;
      set => this.numberField = value;
    }

    public string crlname
    {
      get => this.crlnameField;
      set => this.crlnameField = value;
    }

    public string date
    {
      get => this.dateField;
      private set => this.dateField = value;
    }

    internal override base_resource[] get_nitro_response(
      nitro_service service,
      string response)
    {
      sslcrl_serialnumber_binding.sslcrl_serialnumber_binding_response serialnumberBindingResponse = new sslcrl_serialnumber_binding.sslcrl_serialnumber_binding_response();
      sslcrl_serialnumber_binding.sslcrl_serialnumber_binding_response resource = (sslcrl_serialnumber_binding.sslcrl_serialnumber_binding_response) service.get_payload_formatter().string_to_resource(serialnumberBindingResponse.GetType(), response);
      if (resource.errorcode != 0)
      {
        if (resource.errorcode == 444)
          service.clear_session();
        if (resource.severity == null)
          throw new nitro_exception(resource.message, resource.errorcode);
        if (resource.severity.Equals("ERROR"))
          throw new nitro_exception(resource.message, resource.errorcode);
      }
      return (base_resource[]) resource.sslcrl_serialnumber_binding;
    }

    internal override string get_object_name() => this.crlname;

    public static sslcrl_serialnumber_binding[] get(
      nitro_service service,
      string crlname)
    {
      return (sslcrl_serialnumber_binding[]) new sslcrl_serialnumber_binding()
      {
        crlname = crlname
      }.get_resources(service, (options) null);
    }

    public static sslcrl_serialnumber_binding[] get_filtered(
      nitro_service service,
      string crlname,
      string filter)
    {
      sslcrl_serialnumber_binding serialnumberBinding = new sslcrl_serialnumber_binding();
      serialnumberBinding.crlname = crlname;
      options option = new options();
      option.set_filter(filter);
      return (sslcrl_serialnumber_binding[]) serialnumberBinding.getfiltered(service, option);
    }

    public static sslcrl_serialnumber_binding[] get_filtered(
      nitro_service service,
      string crlname,
      filtervalue[] filter)
    {
      sslcrl_serialnumber_binding serialnumberBinding = new sslcrl_serialnumber_binding();
      serialnumberBinding.crlname = crlname;
      options option = new options();
      option.set_filter(filter);
      return (sslcrl_serialnumber_binding[]) serialnumberBinding.getfiltered(service, option);
    }

    public static uint count(nitro_service service, string crlname)
    {
      sslcrl_serialnumber_binding serialnumberBinding = new sslcrl_serialnumber_binding();
      serialnumberBinding.crlname = crlname;
      options option = new options();
      option.set_count(true);
      sslcrl_serialnumber_binding[] resources = (sslcrl_serialnumber_binding[]) serialnumberBinding.get_resources(service, option);
      return resources != null && resources.Length > 0 ? resources[0].__count.Value : 0U;
    }

    public static uint count_filtered(nitro_service service, string crlname, string filter)
    {
      sslcrl_serialnumber_binding serialnumberBinding = new sslcrl_serialnumber_binding();
      serialnumberBinding.crlname = crlname;
      options option = new options();
      option.set_count(true);
      option.set_filter(filter);
      sslcrl_serialnumber_binding[] serialnumberBindingArray = (sslcrl_serialnumber_binding[]) serialnumberBinding.getfiltered(service, option);
      return serialnumberBindingArray != null && serialnumberBindingArray.Length > 0 ? serialnumberBindingArray[0].__count.Value : 0U;
    }

    public static uint count_filtered(nitro_service service, string crlname, filtervalue[] filter)
    {
      sslcrl_serialnumber_binding serialnumberBinding = new sslcrl_serialnumber_binding();
      serialnumberBinding.crlname = crlname;
      options option = new options();
      option.set_count(true);
      option.set_filter(filter);
      sslcrl_serialnumber_binding[] serialnumberBindingArray = (sslcrl_serialnumber_binding[]) serialnumberBinding.getfiltered(service, option);
      return serialnumberBindingArray != null && serialnumberBindingArray.Length > 0 ? serialnumberBindingArray[0].__count.Value : 0U;
    }

    private class sslcrl_serialnumber_binding_response : base_response
    {
      public sslcrl_serialnumber_binding[] sslcrl_serialnumber_binding = (sslcrl_serialnumber_binding[]) null;
    }
  }
}
