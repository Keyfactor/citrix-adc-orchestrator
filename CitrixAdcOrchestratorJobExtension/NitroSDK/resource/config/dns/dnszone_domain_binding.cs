// Decompiled with JetBrains decompiler
// Type: com.citrix.netscaler.nitro.resource.config.dns.dnszone_domain_binding
// Assembly: nitro, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 6CF5DDEF-E052-4F9D-953F-6644F8378A66


using com.citrix.netscaler.nitro.exception;
using com.citrix.netscaler.nitro.resource.Base;
using com.citrix.netscaler.nitro.service;
using com.citrix.netscaler.nitro.util;

namespace com.citrix.netscaler.nitro.resource.config.dns
{
  public class dnszone_domain_binding : base_resource
  {
    private string domainField = (string) null;
    private string[] nextrecsField = (string[]) null;
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

    public string domain
    {
      get => this.domainField;
      set => this.domainField = value;
    }

    public string[] nextrecs
    {
      get => this.nextrecsField;
      private set => this.nextrecsField = value;
    }

    internal override base_resource[] get_nitro_response(
      nitro_service service,
      string response)
    {
      dnszone_domain_binding.dnszone_domain_binding_response domainBindingResponse = new dnszone_domain_binding.dnszone_domain_binding_response();
      dnszone_domain_binding.dnszone_domain_binding_response resource = (dnszone_domain_binding.dnszone_domain_binding_response) service.get_payload_formatter().string_to_resource(domainBindingResponse.GetType(), response);
      if (resource.errorcode != 0)
      {
        if (resource.errorcode == 444)
          service.clear_session();
        if (resource.severity == null)
          throw new nitro_exception(resource.message, resource.errorcode);
        if (resource.severity.Equals("ERROR"))
          throw new nitro_exception(resource.message, resource.errorcode);
      }
      return (base_resource[]) resource.dnszone_domain_binding;
    }

    internal override string get_object_name() => this.zonename;

    public static dnszone_domain_binding[] get(
      nitro_service service,
      string zonename)
    {
      return (dnszone_domain_binding[]) new dnszone_domain_binding()
      {
        zonename = zonename
      }.get_resources(service, (options) null);
    }

    public static dnszone_domain_binding[] get_filtered(
      nitro_service service,
      string zonename,
      string filter)
    {
      dnszone_domain_binding dnszoneDomainBinding = new dnszone_domain_binding();
      dnszoneDomainBinding.zonename = zonename;
      options option = new options();
      option.set_filter(filter);
      return (dnszone_domain_binding[]) dnszoneDomainBinding.getfiltered(service, option);
    }

    public static dnszone_domain_binding[] get_filtered(
      nitro_service service,
      string zonename,
      filtervalue[] filter)
    {
      dnszone_domain_binding dnszoneDomainBinding = new dnszone_domain_binding();
      dnszoneDomainBinding.zonename = zonename;
      options option = new options();
      option.set_filter(filter);
      return (dnszone_domain_binding[]) dnszoneDomainBinding.getfiltered(service, option);
    }

    public static uint count(nitro_service service, string zonename)
    {
      dnszone_domain_binding dnszoneDomainBinding = new dnszone_domain_binding();
      dnszoneDomainBinding.zonename = zonename;
      options option = new options();
      option.set_count(true);
      dnszone_domain_binding[] resources = (dnszone_domain_binding[]) dnszoneDomainBinding.get_resources(service, option);
      return resources != null && resources.Length > 0 ? resources[0].__count.Value : 0U;
    }

    public static uint count_filtered(nitro_service service, string zonename, string filter)
    {
      dnszone_domain_binding dnszoneDomainBinding = new dnszone_domain_binding();
      dnszoneDomainBinding.zonename = zonename;
      options option = new options();
      option.set_count(true);
      option.set_filter(filter);
      dnszone_domain_binding[] dnszoneDomainBindingArray = (dnszone_domain_binding[]) dnszoneDomainBinding.getfiltered(service, option);
      return dnszoneDomainBindingArray != null && dnszoneDomainBindingArray.Length > 0 ? dnszoneDomainBindingArray[0].__count.Value : 0U;
    }

    public static uint count_filtered(nitro_service service, string zonename, filtervalue[] filter)
    {
      dnszone_domain_binding dnszoneDomainBinding = new dnszone_domain_binding();
      dnszoneDomainBinding.zonename = zonename;
      options option = new options();
      option.set_count(true);
      option.set_filter(filter);
      dnszone_domain_binding[] dnszoneDomainBindingArray = (dnszone_domain_binding[]) dnszoneDomainBinding.getfiltered(service, option);
      return dnszoneDomainBindingArray != null && dnszoneDomainBindingArray.Length > 0 ? dnszoneDomainBindingArray[0].__count.Value : 0U;
    }

    private class dnszone_domain_binding_response : base_response
    {
      public dnszone_domain_binding[] dnszone_domain_binding = (dnszone_domain_binding[]) null;
    }

    public static class nextrecsEnum
    {
      public const string A = "A";
      public const string NS = "NS";
      public const string CNAME = "CNAME";
      public const string SOA = "SOA";
      public const string MX = "MX";
      public const string AAAA = "AAAA";
      public const string SRV = "SRV";
      public const string RRSIG = "RRSIG";
      public const string NSEC = "NSEC";
      public const string DNSKEY = "DNSKEY";
      public const string PTR = "PTR";
      public const string TXT = "TXT";
      public const string NAPTR = "NAPTR";
    }
  }
}
