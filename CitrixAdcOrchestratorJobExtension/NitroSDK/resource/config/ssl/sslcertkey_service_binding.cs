// Decompiled with JetBrains decompiler
// Type: com.citrix.netscaler.nitro.resource.config.ssl.sslcertkey_service_binding
// Assembly: nitro, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 6CF5DDEF-E052-4F9D-953F-6644F8378A66


using com.citrix.netscaler.nitro.exception;
using com.citrix.netscaler.nitro.resource.Base;
using com.citrix.netscaler.nitro.service;
using com.citrix.netscaler.nitro.util;

namespace com.citrix.netscaler.nitro.resource.config.ssl
{
  public class sslcertkey_service_binding : base_resource
  {
    private string servicenameField = (string) null;
    private uint? dataField = new uint?();
    private int? versionField = new int?();
    private string certkeyField = (string) null;
    private bool? serviceField = new bool?();
    private string servicegroupnameField = (string) null;
    private bool? caField = new bool?();
    private string crlcheckField = (string) null;
    private uint? __countField = new uint?();

    public uint? __count
    {
      get => this.__countField;
      set => this.__countField = value;
    }

    public string servicegroupname
    {
      get => this.servicegroupnameField;
      set => this.servicegroupnameField = value;
    }

    public string crlcheck
    {
      get => this.crlcheckField;
      set => this.crlcheckField = value;
    }

    public bool? ca
    {
      get => this.caField;
      set => this.caField = value;
    }

    public bool? service
    {
      get => this.serviceField;
      set => this.serviceField = value;
    }

    public string servicename
    {
      get => this.servicenameField;
      set => this.servicenameField = value;
    }

    public string certkey
    {
      get => this.certkeyField;
      set => this.certkeyField = value;
    }

    public int? version
    {
      get => this.versionField;
      private set => this.versionField = value;
    }

    public uint? data
    {
      get => this.dataField;
      private set => this.dataField = value;
    }

    internal override base_resource[] get_nitro_response(
      nitro_service service,
      string response)
    {
      sslcertkey_service_binding.sslcertkey_service_binding_response serviceBindingResponse = new sslcertkey_service_binding.sslcertkey_service_binding_response();
      sslcertkey_service_binding.sslcertkey_service_binding_response resource = (sslcertkey_service_binding.sslcertkey_service_binding_response) service.get_payload_formatter().string_to_resource(serviceBindingResponse.GetType(), response);
      if (resource.errorcode != 0)
      {
        if (resource.errorcode == 444)
          service.clear_session();
        if (resource.severity == null)
          throw new nitro_exception(resource.message, resource.errorcode);
        if (resource.severity.Equals("ERROR"))
          throw new nitro_exception(resource.message, resource.errorcode);
      }
      return (base_resource[]) resource.sslcertkey_service_binding;
    }

    internal override string get_object_name() => this.certkey;

    public static sslcertkey_service_binding[] get(
      nitro_service service,
      string certkey)
    {
      return (sslcertkey_service_binding[]) new sslcertkey_service_binding()
      {
        certkey = certkey
      }.get_resources(service, (options) null);
    }

    public static sslcertkey_service_binding[] get_filtered(
      nitro_service service,
      string certkey,
      string filter)
    {
      sslcertkey_service_binding sslcertkeyServiceBinding = new sslcertkey_service_binding();
      sslcertkeyServiceBinding.certkey = certkey;
      options option = new options();
      option.set_filter(filter);
      return (sslcertkey_service_binding[]) sslcertkeyServiceBinding.getfiltered(service, option);
    }

    public static sslcertkey_service_binding[] get_filtered(
      nitro_service service,
      string certkey,
      filtervalue[] filter)
    {
      sslcertkey_service_binding sslcertkeyServiceBinding = new sslcertkey_service_binding();
      sslcertkeyServiceBinding.certkey = certkey;
      options option = new options();
      option.set_filter(filter);
      return (sslcertkey_service_binding[]) sslcertkeyServiceBinding.getfiltered(service, option);
    }

    public static uint count(nitro_service service, string certkey)
    {
      sslcertkey_service_binding sslcertkeyServiceBinding = new sslcertkey_service_binding();
      sslcertkeyServiceBinding.certkey = certkey;
      options option = new options();
      option.set_count(true);
      sslcertkey_service_binding[] resources = (sslcertkey_service_binding[]) sslcertkeyServiceBinding.get_resources(service, option);
      return resources != null && resources.Length > 0 ? resources[0].__count.Value : 0U;
    }

    public static uint count_filtered(nitro_service service, string certkey, string filter)
    {
      sslcertkey_service_binding sslcertkeyServiceBinding = new sslcertkey_service_binding();
      sslcertkeyServiceBinding.certkey = certkey;
      options option = new options();
      option.set_count(true);
      option.set_filter(filter);
      sslcertkey_service_binding[] sslcertkeyServiceBindingArray = (sslcertkey_service_binding[]) sslcertkeyServiceBinding.getfiltered(service, option);
      return sslcertkeyServiceBindingArray != null && sslcertkeyServiceBindingArray.Length > 0 ? sslcertkeyServiceBindingArray[0].__count.Value : 0U;
    }

    public static uint count_filtered(nitro_service service, string certkey, filtervalue[] filter)
    {
      sslcertkey_service_binding sslcertkeyServiceBinding = new sslcertkey_service_binding();
      sslcertkeyServiceBinding.certkey = certkey;
      options option = new options();
      option.set_count(true);
      option.set_filter(filter);
      sslcertkey_service_binding[] sslcertkeyServiceBindingArray = (sslcertkey_service_binding[]) sslcertkeyServiceBinding.getfiltered(service, option);
      return sslcertkeyServiceBindingArray != null && sslcertkeyServiceBindingArray.Length > 0 ? sslcertkeyServiceBindingArray[0].__count.Value : 0U;
    }

    private class sslcertkey_service_binding_response : base_response
    {
      public sslcertkey_service_binding[] sslcertkey_service_binding = (sslcertkey_service_binding[]) null;
    }

    public static class crlcheckEnum
    {
      public const string Mandatory = "Mandatory";
      public const string Optional = "Optional";
    }
  }
}
