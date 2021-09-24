// Decompiled with JetBrains decompiler
// Type: com.citrix.netscaler.nitro.resource.config.ssl.sslcertchain_sslcertkey_binding
// Assembly: nitro, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 6CF5DDEF-E052-4F9D-953F-6644F8378A66


using com.citrix.netscaler.nitro.exception;
using com.citrix.netscaler.nitro.resource.Base;
using com.citrix.netscaler.nitro.service;
using com.citrix.netscaler.nitro.util;

namespace com.citrix.netscaler.nitro.resource.config.ssl
{
  public class sslcertchain_sslcertkey_binding : base_resource
  {
    private string linkcertkeynameField = (string) null;
    private bool? islinkedField = new bool?();
    private bool? iscaField = new bool?();
    private bool? addsubjectField = new bool?();
    private string certkeynameField = (string) null;
    private uint? __countField = new uint?();

    public uint? __count
    {
      get => this.__countField;
      set => this.__countField = value;
    }

    public string linkcertkeyname
    {
      get => this.linkcertkeynameField;
      set => this.linkcertkeynameField = value;
    }

    public string certkeyname
    {
      get => this.certkeynameField;
      set => this.certkeynameField = value;
    }

    public bool? isca
    {
      get => this.iscaField;
      private set => this.iscaField = value;
    }

    public bool? islinked
    {
      get => this.islinkedField;
      private set => this.islinkedField = value;
    }

    public bool? addsubject
    {
      get => this.addsubjectField;
      private set => this.addsubjectField = value;
    }

    internal override base_resource[] get_nitro_response(
      nitro_service service,
      string response)
    {
      sslcertchain_sslcertkey_binding.sslcertchain_sslcertkey_binding_response sslcertkeyBindingResponse = new sslcertchain_sslcertkey_binding.sslcertchain_sslcertkey_binding_response();
      sslcertchain_sslcertkey_binding.sslcertchain_sslcertkey_binding_response resource = (sslcertchain_sslcertkey_binding.sslcertchain_sslcertkey_binding_response) service.get_payload_formatter().string_to_resource(sslcertkeyBindingResponse.GetType(), response);
      if (resource.errorcode != 0)
      {
        if (resource.errorcode == 444)
          service.clear_session();
        if (resource.severity == null)
          throw new nitro_exception(resource.message, resource.errorcode);
        if (resource.severity.Equals("ERROR"))
          throw new nitro_exception(resource.message, resource.errorcode);
      }
      return (base_resource[]) resource.sslcertchain_sslcertkey_binding;
    }

    internal override string get_object_name() => this.certkeyname;

    public static sslcertchain_sslcertkey_binding[] get(
      nitro_service service,
      string certkeyname)
    {
      return (sslcertchain_sslcertkey_binding[]) new sslcertchain_sslcertkey_binding()
      {
        certkeyname = certkeyname
      }.get_resources(service, (options) null);
    }

    public static sslcertchain_sslcertkey_binding[] get_filtered(
      nitro_service service,
      string certkeyname,
      string filter)
    {
      sslcertchain_sslcertkey_binding sslcertkeyBinding = new sslcertchain_sslcertkey_binding();
      sslcertkeyBinding.certkeyname = certkeyname;
      options option = new options();
      option.set_filter(filter);
      return (sslcertchain_sslcertkey_binding[]) sslcertkeyBinding.getfiltered(service, option);
    }

    public static sslcertchain_sslcertkey_binding[] get_filtered(
      nitro_service service,
      string certkeyname,
      filtervalue[] filter)
    {
      sslcertchain_sslcertkey_binding sslcertkeyBinding = new sslcertchain_sslcertkey_binding();
      sslcertkeyBinding.certkeyname = certkeyname;
      options option = new options();
      option.set_filter(filter);
      return (sslcertchain_sslcertkey_binding[]) sslcertkeyBinding.getfiltered(service, option);
    }

    public static uint count(nitro_service service, string certkeyname)
    {
      sslcertchain_sslcertkey_binding sslcertkeyBinding = new sslcertchain_sslcertkey_binding();
      sslcertkeyBinding.certkeyname = certkeyname;
      options option = new options();
      option.set_count(true);
      sslcertchain_sslcertkey_binding[] resources = (sslcertchain_sslcertkey_binding[]) sslcertkeyBinding.get_resources(service, option);
      return resources != null && resources.Length > 0 ? resources[0].__count.Value : 0U;
    }

    public static uint count_filtered(nitro_service service, string certkeyname, string filter)
    {
      sslcertchain_sslcertkey_binding sslcertkeyBinding = new sslcertchain_sslcertkey_binding();
      sslcertkeyBinding.certkeyname = certkeyname;
      options option = new options();
      option.set_count(true);
      option.set_filter(filter);
      sslcertchain_sslcertkey_binding[] sslcertkeyBindingArray = (sslcertchain_sslcertkey_binding[]) sslcertkeyBinding.getfiltered(service, option);
      return sslcertkeyBindingArray != null && sslcertkeyBindingArray.Length > 0 ? sslcertkeyBindingArray[0].__count.Value : 0U;
    }

    public static uint count_filtered(
      nitro_service service,
      string certkeyname,
      filtervalue[] filter)
    {
      sslcertchain_sslcertkey_binding sslcertkeyBinding = new sslcertchain_sslcertkey_binding();
      sslcertkeyBinding.certkeyname = certkeyname;
      options option = new options();
      option.set_count(true);
      option.set_filter(filter);
      sslcertchain_sslcertkey_binding[] sslcertkeyBindingArray = (sslcertchain_sslcertkey_binding[]) sslcertkeyBinding.getfiltered(service, option);
      return sslcertkeyBindingArray != null && sslcertkeyBindingArray.Length > 0 ? sslcertkeyBindingArray[0].__count.Value : 0U;
    }

    private class sslcertchain_sslcertkey_binding_response : base_response
    {
      public sslcertchain_sslcertkey_binding[] sslcertchain_sslcertkey_binding = (sslcertchain_sslcertkey_binding[]) null;
    }
  }
}
