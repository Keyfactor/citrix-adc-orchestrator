// Decompiled with JetBrains decompiler
// Type: com.citrix.netscaler.nitro.resource.config.ssl.sslcertkey_sslvserver_binding
// Assembly: nitro, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 6CF5DDEF-E052-4F9D-953F-6644F8378A66


using com.citrix.netscaler.nitro.exception;
using com.citrix.netscaler.nitro.resource.Base;
using com.citrix.netscaler.nitro.service;
using com.citrix.netscaler.nitro.util;

namespace com.citrix.netscaler.nitro.resource.config.ssl
{
  public class sslcertkey_sslvserver_binding : base_resource
  {
    private string servernameField = (string) null;
    private uint? dataField = new uint?();
    private int? versionField = new int?();
    private string certkeyField = (string) null;
    private string vservernameField = (string) null;
    private bool? vserverField = new bool?();
    private bool? caField = new bool?();
    private string crlcheckField = (string) null;
    private uint? __countField = new uint?();

    public uint? __count
    {
      get => this.__countField;
      set => this.__countField = value;
    }

    public bool? vserver
    {
      get => this.vserverField;
      set => this.vserverField = value;
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

    public string vservername
    {
      get => this.vservernameField;
      set => this.vservernameField = value;
    }

    public string servername
    {
      get => this.servernameField;
      set => this.servernameField = value;
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
      sslcertkey_sslvserver_binding.sslcertkey_sslvserver_binding_response sslvserverBindingResponse = new sslcertkey_sslvserver_binding.sslcertkey_sslvserver_binding_response();
      sslcertkey_sslvserver_binding.sslcertkey_sslvserver_binding_response resource = (sslcertkey_sslvserver_binding.sslcertkey_sslvserver_binding_response) service.get_payload_formatter().string_to_resource(sslvserverBindingResponse.GetType(), response);
      if (resource.errorcode != 0)
      {
        if (resource.errorcode == 444)
          service.clear_session();
        if (resource.severity == null)
          throw new nitro_exception(resource.message, resource.errorcode);
        if (resource.severity.Equals("ERROR"))
          throw new nitro_exception(resource.message, resource.errorcode);
      }
      return (base_resource[]) resource.sslcertkey_sslvserver_binding;
    }

    internal override string get_object_name() => this.certkey;

    public static sslcertkey_sslvserver_binding[] get(
      nitro_service service,
      string certkey)
    {
      return (sslcertkey_sslvserver_binding[]) new sslcertkey_sslvserver_binding()
      {
        certkey = certkey
      }.get_resources(service, (options) null);
    }

    public static sslcertkey_sslvserver_binding[] get_filtered(
      nitro_service service,
      string certkey,
      string filter)
    {
      sslcertkey_sslvserver_binding sslvserverBinding = new sslcertkey_sslvserver_binding();
      sslvserverBinding.certkey = certkey;
      options option = new options();
      option.set_filter(filter);
      return (sslcertkey_sslvserver_binding[]) sslvserverBinding.getfiltered(service, option);
    }

    public static sslcertkey_sslvserver_binding[] get_filtered(
      nitro_service service,
      string certkey,
      filtervalue[] filter)
    {
      sslcertkey_sslvserver_binding sslvserverBinding = new sslcertkey_sslvserver_binding();
      sslvserverBinding.certkey = certkey;
      options option = new options();
      option.set_filter(filter);
      return (sslcertkey_sslvserver_binding[]) sslvserverBinding.getfiltered(service, option);
    }

    public static uint count(nitro_service service, string certkey)
    {
      sslcertkey_sslvserver_binding sslvserverBinding = new sslcertkey_sslvserver_binding();
      sslvserverBinding.certkey = certkey;
      options option = new options();
      option.set_count(true);
      sslcertkey_sslvserver_binding[] resources = (sslcertkey_sslvserver_binding[]) sslvserverBinding.get_resources(service, option);
      return resources != null && resources.Length > 0 ? resources[0].__count.Value : 0U;
    }

    public static uint count_filtered(nitro_service service, string certkey, string filter)
    {
      sslcertkey_sslvserver_binding sslvserverBinding = new sslcertkey_sslvserver_binding();
      sslvserverBinding.certkey = certkey;
      options option = new options();
      option.set_count(true);
      option.set_filter(filter);
      sslcertkey_sslvserver_binding[] sslvserverBindingArray = (sslcertkey_sslvserver_binding[]) sslvserverBinding.getfiltered(service, option);
      return sslvserverBindingArray != null && sslvserverBindingArray.Length > 0 ? sslvserverBindingArray[0].__count.Value : 0U;
    }

    public static uint count_filtered(nitro_service service, string certkey, filtervalue[] filter)
    {
      sslcertkey_sslvserver_binding sslvserverBinding = new sslcertkey_sslvserver_binding();
      sslvserverBinding.certkey = certkey;
      options option = new options();
      option.set_count(true);
      option.set_filter(filter);
      sslcertkey_sslvserver_binding[] sslvserverBindingArray = (sslcertkey_sslvserver_binding[]) sslvserverBinding.getfiltered(service, option);
      return sslvserverBindingArray != null && sslvserverBindingArray.Length > 0 ? sslvserverBindingArray[0].__count.Value : 0U;
    }

    private class sslcertkey_sslvserver_binding_response : base_response
    {
      public sslcertkey_sslvserver_binding[] sslcertkey_sslvserver_binding = (sslcertkey_sslvserver_binding[]) null;
    }

    public static class crlcheckEnum
    {
      public const string Mandatory = "Mandatory";
      public const string Optional = "Optional";
    }
  }
}
