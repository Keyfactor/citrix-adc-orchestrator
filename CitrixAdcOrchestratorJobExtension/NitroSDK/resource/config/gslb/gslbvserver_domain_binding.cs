// Decompiled with JetBrains decompiler
// Type: com.citrix.netscaler.nitro.resource.config.gslb.gslbvserver_domain_binding
// Assembly: nitro, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 6CF5DDEF-E052-4F9D-953F-6644F8378A66


using com.citrix.netscaler.nitro.exception;
using com.citrix.netscaler.nitro.resource.Base;
using com.citrix.netscaler.nitro.service;
using com.citrix.netscaler.nitro.util;

namespace com.citrix.netscaler.nitro.resource.config.gslb
{
  public class gslbvserver_domain_binding : base_resource
  {
    private string domainnameField = (string) null;
    private long? ttlField = new long?();
    private string backupipField = (string) null;
    private string cookie_domainField = (string) null;
    private uint? cookietimeoutField = new uint?();
    private long? sitedomainttlField = new long?();
    private string nameField = (string) null;
    private bool? backupipflagField = new bool?();
    private bool? cookie_domainflagField = new bool?();
    private uint? __countField = new uint?();

    public uint? __count
    {
      get => this.__countField;
      set => this.__countField = value;
    }

    public bool? backupipflag
    {
      get => this.backupipflagField;
      set => this.backupipflagField = value;
    }

    public uint? cookietimeout
    {
      get => this.cookietimeoutField;
      set => this.cookietimeoutField = value;
    }

    public string backupip
    {
      get => this.backupipField;
      set => this.backupipField = value;
    }

    public string name
    {
      get => this.nameField;
      set => this.nameField = value;
    }

    public long? ttl
    {
      get => this.ttlField;
      set => this.ttlField = value;
    }

    public string domainname
    {
      get => this.domainnameField;
      set => this.domainnameField = value;
    }

    public long? sitedomainttl
    {
      get => this.sitedomainttlField;
      set => this.sitedomainttlField = value;
    }

    public bool? cookie_domainflag
    {
      get => this.cookie_domainflagField;
      set => this.cookie_domainflagField = value;
    }

    public string cookie_domain
    {
      get => this.cookie_domainField;
      set => this.cookie_domainField = value;
    }

    internal override base_resource[] get_nitro_response(
      nitro_service service,
      string response)
    {
      gslbvserver_domain_binding.gslbvserver_domain_binding_response domainBindingResponse = new gslbvserver_domain_binding.gslbvserver_domain_binding_response();
      gslbvserver_domain_binding.gslbvserver_domain_binding_response resource = (gslbvserver_domain_binding.gslbvserver_domain_binding_response) service.get_payload_formatter().string_to_resource(domainBindingResponse.GetType(), response);
      if (resource.errorcode != 0)
      {
        if (resource.errorcode == 444)
          service.clear_session();
        if (resource.severity == null)
          throw new nitro_exception(resource.message, resource.errorcode);
        if (resource.severity.Equals("ERROR"))
          throw new nitro_exception(resource.message, resource.errorcode);
      }
      return (base_resource[]) resource.gslbvserver_domain_binding;
    }

    internal override string get_object_name() => this.name;

    public static base_response add(
      nitro_service client,
      gslbvserver_domain_binding resource)
    {
      return new gslbvserver_domain_binding()
      {
        name = resource.name,
        domainname = resource.domainname,
        ttl = resource.ttl,
        backupip = resource.backupip,
        cookie_domain = resource.cookie_domain,
        cookietimeout = resource.cookietimeout,
        sitedomainttl = resource.sitedomainttl
      }.update_resource(client);
    }

    public static base_responses add(
      nitro_service client,
      gslbvserver_domain_binding[] resources)
    {
      base_responses baseResponses = (base_responses) null;
      if (resources != null && resources.Length > 0)
      {
        gslbvserver_domain_binding[] gslbvserverDomainBindingArray = new gslbvserver_domain_binding[resources.Length];
        for (int index = 0; index < resources.Length; ++index)
        {
          gslbvserverDomainBindingArray[index] = new gslbvserver_domain_binding();
          gslbvserverDomainBindingArray[index].name = resources[index].name;
          gslbvserverDomainBindingArray[index].domainname = resources[index].domainname;
          gslbvserverDomainBindingArray[index].ttl = resources[index].ttl;
          gslbvserverDomainBindingArray[index].backupip = resources[index].backupip;
          gslbvserverDomainBindingArray[index].cookie_domain = resources[index].cookie_domain;
          gslbvserverDomainBindingArray[index].cookietimeout = resources[index].cookietimeout;
          gslbvserverDomainBindingArray[index].sitedomainttl = resources[index].sitedomainttl;
        }
        baseResponses = base_resource.update_bulk_request(client, (base_resource[]) gslbvserverDomainBindingArray);
      }
      return baseResponses;
    }

    public static base_response delete(
      nitro_service client,
      gslbvserver_domain_binding resource)
    {
      return new gslbvserver_domain_binding()
      {
        name = resource.name,
        domainname = resource.domainname,
        backupipflag = resource.backupipflag,
        cookie_domainflag = resource.cookie_domainflag
      }.delete_resource(client);
    }

    public static base_responses delete(
      nitro_service client,
      gslbvserver_domain_binding[] resources)
    {
      base_responses baseResponses = (base_responses) null;
      if (resources != null && resources.Length > 0)
      {
        gslbvserver_domain_binding[] gslbvserverDomainBindingArray = new gslbvserver_domain_binding[resources.Length];
        for (int index = 0; index < resources.Length; ++index)
        {
          gslbvserverDomainBindingArray[index] = new gslbvserver_domain_binding();
          gslbvserverDomainBindingArray[index].name = resources[index].name;
          gslbvserverDomainBindingArray[index].domainname = resources[index].domainname;
          gslbvserverDomainBindingArray[index].backupipflag = resources[index].backupipflag;
          gslbvserverDomainBindingArray[index].cookie_domainflag = resources[index].cookie_domainflag;
        }
        baseResponses = base_resource.delete_bulk_request(client, (base_resource[]) gslbvserverDomainBindingArray);
      }
      return baseResponses;
    }

    public static gslbvserver_domain_binding[] get(
      nitro_service service,
      string name)
    {
      return (gslbvserver_domain_binding[]) new gslbvserver_domain_binding()
      {
        name = name
      }.get_resources(service, (options) null);
    }

    public static gslbvserver_domain_binding[] get_filtered(
      nitro_service service,
      string name,
      string filter)
    {
      gslbvserver_domain_binding gslbvserverDomainBinding = new gslbvserver_domain_binding();
      gslbvserverDomainBinding.name = name;
      options option = new options();
      option.set_filter(filter);
      return (gslbvserver_domain_binding[]) gslbvserverDomainBinding.getfiltered(service, option);
    }

    public static gslbvserver_domain_binding[] get_filtered(
      nitro_service service,
      string name,
      filtervalue[] filter)
    {
      gslbvserver_domain_binding gslbvserverDomainBinding = new gslbvserver_domain_binding();
      gslbvserverDomainBinding.name = name;
      options option = new options();
      option.set_filter(filter);
      return (gslbvserver_domain_binding[]) gslbvserverDomainBinding.getfiltered(service, option);
    }

    public static uint count(nitro_service service, string name)
    {
      gslbvserver_domain_binding gslbvserverDomainBinding = new gslbvserver_domain_binding();
      gslbvserverDomainBinding.name = name;
      options option = new options();
      option.set_count(true);
      gslbvserver_domain_binding[] resources = (gslbvserver_domain_binding[]) gslbvserverDomainBinding.get_resources(service, option);
      return resources != null && resources.Length > 0 ? resources[0].__count.Value : 0U;
    }

    public static uint count_filtered(nitro_service service, string name, string filter)
    {
      gslbvserver_domain_binding gslbvserverDomainBinding = new gslbvserver_domain_binding();
      gslbvserverDomainBinding.name = name;
      options option = new options();
      option.set_count(true);
      option.set_filter(filter);
      gslbvserver_domain_binding[] gslbvserverDomainBindingArray = (gslbvserver_domain_binding[]) gslbvserverDomainBinding.getfiltered(service, option);
      return gslbvserverDomainBindingArray != null && gslbvserverDomainBindingArray.Length > 0 ? gslbvserverDomainBindingArray[0].__count.Value : 0U;
    }

    public static uint count_filtered(nitro_service service, string name, filtervalue[] filter)
    {
      gslbvserver_domain_binding gslbvserverDomainBinding = new gslbvserver_domain_binding();
      gslbvserverDomainBinding.name = name;
      options option = new options();
      option.set_count(true);
      option.set_filter(filter);
      gslbvserver_domain_binding[] gslbvserverDomainBindingArray = (gslbvserver_domain_binding[]) gslbvserverDomainBinding.getfiltered(service, option);
      return gslbvserverDomainBindingArray != null && gslbvserverDomainBindingArray.Length > 0 ? gslbvserverDomainBindingArray[0].__count.Value : 0U;
    }

    private class gslbvserver_domain_binding_response : base_response
    {
      public gslbvserver_domain_binding[] gslbvserver_domain_binding = (gslbvserver_domain_binding[]) null;
    }

    public static class typeEnum
    {
      public const string REQUEST = "REQUEST";
      public const string RESPONSE = "RESPONSE";
    }
  }
}
