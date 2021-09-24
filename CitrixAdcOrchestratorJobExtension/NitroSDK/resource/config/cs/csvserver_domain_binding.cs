// Decompiled with JetBrains decompiler
// Type: com.citrix.netscaler.nitro.resource.config.cs.csvserver_domain_binding
// Assembly: nitro, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 6CF5DDEF-E052-4F9D-953F-6644F8378A66


using com.citrix.netscaler.nitro.exception;
using com.citrix.netscaler.nitro.resource.Base;
using com.citrix.netscaler.nitro.service;
using com.citrix.netscaler.nitro.util;

namespace com.citrix.netscaler.nitro.resource.config.cs
{
  public class csvserver_domain_binding : base_resource
  {
    private string domainnameField = (string) null;
    private long? ttlField = new long?();
    private string backupipField = (string) null;
    private string cookiedomainField = (string) null;
    private uint? cookietimeoutField = new uint?();
    private long? sitedomainttlField = new long?();
    private string appflowlogField = (string) null;
    private string nameField = (string) null;
    private uint? __countField = new uint?();

    public uint? __count
    {
      get => this.__countField;
      set => this.__countField = value;
    }

    public string backupip
    {
      get => this.backupipField;
      set => this.backupipField = value;
    }

    public long? ttl
    {
      get => this.ttlField;
      set => this.ttlField = value;
    }

    public string name
    {
      get => this.nameField;
      set => this.nameField = value;
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

    public string cookiedomain
    {
      get => this.cookiedomainField;
      set => this.cookiedomainField = value;
    }

    public uint? cookietimeout
    {
      get => this.cookietimeoutField;
      set => this.cookietimeoutField = value;
    }

    public string appflowlog
    {
      get => this.appflowlogField;
      private set => this.appflowlogField = value;
    }

    internal override base_resource[] get_nitro_response(
      nitro_service service,
      string response)
    {
      csvserver_domain_binding.csvserver_domain_binding_response domainBindingResponse = new csvserver_domain_binding.csvserver_domain_binding_response();
      csvserver_domain_binding.csvserver_domain_binding_response resource = (csvserver_domain_binding.csvserver_domain_binding_response) service.get_payload_formatter().string_to_resource(domainBindingResponse.GetType(), response);
      if (resource.errorcode != 0)
      {
        if (resource.errorcode == 444)
          service.clear_session();
        if (resource.severity == null)
          throw new nitro_exception(resource.message, resource.errorcode);
        if (resource.severity.Equals("ERROR"))
          throw new nitro_exception(resource.message, resource.errorcode);
      }
      return (base_resource[]) resource.csvserver_domain_binding;
    }

    internal override string get_object_name() => this.name;

    public static base_response add(
      nitro_service client,
      csvserver_domain_binding resource)
    {
      return new csvserver_domain_binding()
      {
        name = resource.name,
        domainname = resource.domainname,
        ttl = resource.ttl,
        backupip = resource.backupip,
        cookiedomain = resource.cookiedomain,
        cookietimeout = resource.cookietimeout,
        sitedomainttl = resource.sitedomainttl
      }.update_resource(client);
    }

    public static base_responses add(
      nitro_service client,
      csvserver_domain_binding[] resources)
    {
      base_responses baseResponses = (base_responses) null;
      if (resources != null && resources.Length > 0)
      {
        csvserver_domain_binding[] csvserverDomainBindingArray = new csvserver_domain_binding[resources.Length];
        for (int index = 0; index < resources.Length; ++index)
        {
          csvserverDomainBindingArray[index] = new csvserver_domain_binding();
          csvserverDomainBindingArray[index].name = resources[index].name;
          csvserverDomainBindingArray[index].domainname = resources[index].domainname;
          csvserverDomainBindingArray[index].ttl = resources[index].ttl;
          csvserverDomainBindingArray[index].backupip = resources[index].backupip;
          csvserverDomainBindingArray[index].cookiedomain = resources[index].cookiedomain;
          csvserverDomainBindingArray[index].cookietimeout = resources[index].cookietimeout;
          csvserverDomainBindingArray[index].sitedomainttl = resources[index].sitedomainttl;
        }
        baseResponses = base_resource.update_bulk_request(client, (base_resource[]) csvserverDomainBindingArray);
      }
      return baseResponses;
    }

    public static base_response delete(
      nitro_service client,
      csvserver_domain_binding resource)
    {
      return new csvserver_domain_binding()
      {
        name = resource.name,
        domainname = resource.domainname
      }.delete_resource(client);
    }

    public static base_responses delete(
      nitro_service client,
      csvserver_domain_binding[] resources)
    {
      base_responses baseResponses = (base_responses) null;
      if (resources != null && resources.Length > 0)
      {
        csvserver_domain_binding[] csvserverDomainBindingArray = new csvserver_domain_binding[resources.Length];
        for (int index = 0; index < resources.Length; ++index)
        {
          csvserverDomainBindingArray[index] = new csvserver_domain_binding();
          csvserverDomainBindingArray[index].name = resources[index].name;
          csvserverDomainBindingArray[index].domainname = resources[index].domainname;
        }
        baseResponses = base_resource.delete_bulk_request(client, (base_resource[]) csvserverDomainBindingArray);
      }
      return baseResponses;
    }

    public static csvserver_domain_binding[] get(
      nitro_service service,
      string name)
    {
      return (csvserver_domain_binding[]) new csvserver_domain_binding()
      {
        name = name
      }.get_resources(service, (options) null);
    }

    public static csvserver_domain_binding[] get_filtered(
      nitro_service service,
      string name,
      string filter)
    {
      csvserver_domain_binding csvserverDomainBinding = new csvserver_domain_binding();
      csvserverDomainBinding.name = name;
      options option = new options();
      option.set_filter(filter);
      return (csvserver_domain_binding[]) csvserverDomainBinding.getfiltered(service, option);
    }

    public static csvserver_domain_binding[] get_filtered(
      nitro_service service,
      string name,
      filtervalue[] filter)
    {
      csvserver_domain_binding csvserverDomainBinding = new csvserver_domain_binding();
      csvserverDomainBinding.name = name;
      options option = new options();
      option.set_filter(filter);
      return (csvserver_domain_binding[]) csvserverDomainBinding.getfiltered(service, option);
    }

    public static uint count(nitro_service service, string name)
    {
      csvserver_domain_binding csvserverDomainBinding = new csvserver_domain_binding();
      csvserverDomainBinding.name = name;
      options option = new options();
      option.set_count(true);
      csvserver_domain_binding[] resources = (csvserver_domain_binding[]) csvserverDomainBinding.get_resources(service, option);
      return resources != null && resources.Length > 0 ? resources[0].__count.Value : 0U;
    }

    public static uint count_filtered(nitro_service service, string name, string filter)
    {
      csvserver_domain_binding csvserverDomainBinding = new csvserver_domain_binding();
      csvserverDomainBinding.name = name;
      options option = new options();
      option.set_count(true);
      option.set_filter(filter);
      csvserver_domain_binding[] csvserverDomainBindingArray = (csvserver_domain_binding[]) csvserverDomainBinding.getfiltered(service, option);
      return csvserverDomainBindingArray != null && csvserverDomainBindingArray.Length > 0 ? csvserverDomainBindingArray[0].__count.Value : 0U;
    }

    public static uint count_filtered(nitro_service service, string name, filtervalue[] filter)
    {
      csvserver_domain_binding csvserverDomainBinding = new csvserver_domain_binding();
      csvserverDomainBinding.name = name;
      options option = new options();
      option.set_count(true);
      option.set_filter(filter);
      csvserver_domain_binding[] csvserverDomainBindingArray = (csvserver_domain_binding[]) csvserverDomainBinding.getfiltered(service, option);
      return csvserverDomainBindingArray != null && csvserverDomainBindingArray.Length > 0 ? csvserverDomainBindingArray[0].__count.Value : 0U;
    }

    private class csvserver_domain_binding_response : base_response
    {
      public csvserver_domain_binding[] csvserver_domain_binding = (csvserver_domain_binding[]) null;
    }

    public static class bindpointEnum
    {
      public const string REQUEST = "REQUEST";
      public const string RESPONSE = "RESPONSE";
    }

    public static class appflowlogEnum
    {
      public const string ENABLED = "ENABLED";
      public const string DISABLED = "DISABLED";
    }

    public static class labeltypeEnum
    {
      public const string reqvserver = "reqvserver";
      public const string resvserver = "resvserver";
      public const string policylabel = "policylabel";
    }
  }
}
