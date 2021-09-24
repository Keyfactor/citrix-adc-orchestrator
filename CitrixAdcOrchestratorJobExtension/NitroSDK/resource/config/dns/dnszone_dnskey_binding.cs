// Decompiled with JetBrains decompiler
// Type: com.citrix.netscaler.nitro.resource.config.dns.dnszone_dnskey_binding
// Assembly: nitro, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 6CF5DDEF-E052-4F9D-953F-6644F8378A66


using com.citrix.netscaler.nitro.exception;
using com.citrix.netscaler.nitro.resource.Base;
using com.citrix.netscaler.nitro.service;
using com.citrix.netscaler.nitro.util;

namespace com.citrix.netscaler.nitro.resource.config.dns
{
  public class dnszone_dnskey_binding : base_resource
  {
    private string[] keynameField = (string[]) null;
    private uint?[] siginceptiontimeField = (uint?[]) null;
    private uint? signedField = new uint?();
    private uint? expiresField = new uint?();
    private string zonenameField = (string) null;
    private uint? __countField = new uint?();

    public uint? __count
    {
      get => this.__countField;
      set => this.__countField = value;
    }

    public string zonename
    {
      get => this.zonenameField;
      set => this.zonenameField = value;
    }

    public string[] keyname
    {
      get => this.keynameField;
      set => this.keynameField = value;
    }

    public uint?[] siginceptiontime
    {
      get => this.siginceptiontimeField;
      private set => this.siginceptiontimeField = value;
    }

    public uint? signed
    {
      get => this.signedField;
      private set => this.signedField = value;
    }

    public uint? expires
    {
      get => this.expiresField;
      private set => this.expiresField = value;
    }

    internal override base_resource[] get_nitro_response(
      nitro_service service,
      string response)
    {
      dnszone_dnskey_binding.dnszone_dnskey_binding_response dnskeyBindingResponse = new dnszone_dnskey_binding.dnszone_dnskey_binding_response();
      dnszone_dnskey_binding.dnszone_dnskey_binding_response resource = (dnszone_dnskey_binding.dnszone_dnskey_binding_response) service.get_payload_formatter().string_to_resource(dnskeyBindingResponse.GetType(), response);
      if (resource.errorcode != 0)
      {
        if (resource.errorcode == 444)
          service.clear_session();
        if (resource.severity == null)
          throw new nitro_exception(resource.message, resource.errorcode);
        if (resource.severity.Equals("ERROR"))
          throw new nitro_exception(resource.message, resource.errorcode);
      }
      return (base_resource[]) resource.dnszone_dnskey_binding;
    }

    internal override string get_object_name() => this.zonename;

    public static dnszone_dnskey_binding[] get(
      nitro_service service,
      string zonename)
    {
      return (dnszone_dnskey_binding[]) new dnszone_dnskey_binding()
      {
        zonename = zonename
      }.get_resources(service, (options) null);
    }

    public static dnszone_dnskey_binding[] get_filtered(
      nitro_service service,
      string zonename,
      string filter)
    {
      dnszone_dnskey_binding dnszoneDnskeyBinding = new dnszone_dnskey_binding();
      dnszoneDnskeyBinding.zonename = zonename;
      options option = new options();
      option.set_filter(filter);
      return (dnszone_dnskey_binding[]) dnszoneDnskeyBinding.getfiltered(service, option);
    }

    public static dnszone_dnskey_binding[] get_filtered(
      nitro_service service,
      string zonename,
      filtervalue[] filter)
    {
      dnszone_dnskey_binding dnszoneDnskeyBinding = new dnszone_dnskey_binding();
      dnszoneDnskeyBinding.zonename = zonename;
      options option = new options();
      option.set_filter(filter);
      return (dnszone_dnskey_binding[]) dnszoneDnskeyBinding.getfiltered(service, option);
    }

    public static uint count(nitro_service service, string zonename)
    {
      dnszone_dnskey_binding dnszoneDnskeyBinding = new dnszone_dnskey_binding();
      dnszoneDnskeyBinding.zonename = zonename;
      options option = new options();
      option.set_count(true);
      dnszone_dnskey_binding[] resources = (dnszone_dnskey_binding[]) dnszoneDnskeyBinding.get_resources(service, option);
      return resources != null && resources.Length > 0 ? resources[0].__count.Value : 0U;
    }

    public static uint count_filtered(nitro_service service, string zonename, string filter)
    {
      dnszone_dnskey_binding dnszoneDnskeyBinding = new dnszone_dnskey_binding();
      dnszoneDnskeyBinding.zonename = zonename;
      options option = new options();
      option.set_count(true);
      option.set_filter(filter);
      dnszone_dnskey_binding[] dnszoneDnskeyBindingArray = (dnszone_dnskey_binding[]) dnszoneDnskeyBinding.getfiltered(service, option);
      return dnszoneDnskeyBindingArray != null && dnszoneDnskeyBindingArray.Length > 0 ? dnszoneDnskeyBindingArray[0].__count.Value : 0U;
    }

    public static uint count_filtered(nitro_service service, string zonename, filtervalue[] filter)
    {
      dnszone_dnskey_binding dnszoneDnskeyBinding = new dnszone_dnskey_binding();
      dnszoneDnskeyBinding.zonename = zonename;
      options option = new options();
      option.set_count(true);
      option.set_filter(filter);
      dnszone_dnskey_binding[] dnszoneDnskeyBindingArray = (dnszone_dnskey_binding[]) dnszoneDnskeyBinding.getfiltered(service, option);
      return dnszoneDnskeyBindingArray != null && dnszoneDnskeyBindingArray.Length > 0 ? dnszoneDnskeyBindingArray[0].__count.Value : 0U;
    }

    private class dnszone_dnskey_binding_response : base_response
    {
      public dnszone_dnskey_binding[] dnszone_dnskey_binding = (dnszone_dnskey_binding[]) null;
    }
  }
}
