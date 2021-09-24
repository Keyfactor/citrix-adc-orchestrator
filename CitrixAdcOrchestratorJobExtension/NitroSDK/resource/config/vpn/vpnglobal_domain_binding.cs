// Decompiled with JetBrains decompiler
// Type: com.citrix.netscaler.nitro.resource.config.vpn.vpnglobal_domain_binding
// Assembly: nitro, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 6CF5DDEF-E052-4F9D-953F-6644F8378A66


using com.citrix.netscaler.nitro.exception;
using com.citrix.netscaler.nitro.resource.Base;
using com.citrix.netscaler.nitro.service;
using com.citrix.netscaler.nitro.util;

namespace com.citrix.netscaler.nitro.resource.config.vpn
{
  public class vpnglobal_domain_binding : base_resource
  {
    private string intranetdomainField = (string) null;
    private uint? __countField = new uint?();

    public uint? __count
    {
      get => this.__countField;
      set => this.__countField = value;
    }

    public string intranetdomain
    {
      get => this.intranetdomainField;
      set => this.intranetdomainField = value;
    }

    internal override base_resource[] get_nitro_response(
      nitro_service service,
      string response)
    {
      vpnglobal_domain_binding.vpnglobal_domain_binding_response domainBindingResponse = new vpnglobal_domain_binding.vpnglobal_domain_binding_response();
      vpnglobal_domain_binding.vpnglobal_domain_binding_response resource = (vpnglobal_domain_binding.vpnglobal_domain_binding_response) service.get_payload_formatter().string_to_resource(domainBindingResponse.GetType(), response);
      if (resource.errorcode != 0)
      {
        if (resource.errorcode == 444)
          service.clear_session();
        if (resource.severity == null)
          throw new nitro_exception(resource.message, resource.errorcode);
        if (resource.severity.Equals("ERROR"))
          throw new nitro_exception(resource.message, resource.errorcode);
      }
      return (base_resource[]) resource.vpnglobal_domain_binding;
    }

    internal override string get_object_name() => (string) null;

    public static base_response add(
      nitro_service client,
      vpnglobal_domain_binding resource)
    {
      return new vpnglobal_domain_binding()
      {
        intranetdomain = resource.intranetdomain
      }.update_resource(client);
    }

    public static base_responses add(
      nitro_service client,
      vpnglobal_domain_binding[] resources)
    {
      base_responses baseResponses = (base_responses) null;
      if (resources != null && resources.Length > 0)
      {
        vpnglobal_domain_binding[] vpnglobalDomainBindingArray = new vpnglobal_domain_binding[resources.Length];
        for (int index = 0; index < resources.Length; ++index)
        {
          vpnglobalDomainBindingArray[index] = new vpnglobal_domain_binding();
          vpnglobalDomainBindingArray[index].intranetdomain = resources[index].intranetdomain;
        }
        baseResponses = base_resource.update_bulk_request(client, (base_resource[]) vpnglobalDomainBindingArray);
      }
      return baseResponses;
    }

    public static base_response delete(
      nitro_service client,
      vpnglobal_domain_binding resource)
    {
      return new vpnglobal_domain_binding()
      {
        intranetdomain = resource.intranetdomain
      }.delete_resource(client);
    }

    public static base_responses delete(
      nitro_service client,
      vpnglobal_domain_binding[] resources)
    {
      base_responses baseResponses = (base_responses) null;
      if (resources != null && resources.Length > 0)
      {
        vpnglobal_domain_binding[] vpnglobalDomainBindingArray = new vpnglobal_domain_binding[resources.Length];
        for (int index = 0; index < resources.Length; ++index)
        {
          vpnglobalDomainBindingArray[index] = new vpnglobal_domain_binding();
          vpnglobalDomainBindingArray[index].intranetdomain = resources[index].intranetdomain;
        }
        baseResponses = base_resource.delete_bulk_request(client, (base_resource[]) vpnglobalDomainBindingArray);
      }
      return baseResponses;
    }

    public static vpnglobal_domain_binding[] get(nitro_service service) => (vpnglobal_domain_binding[]) new vpnglobal_domain_binding().get_resources(service, (options) null);

    public static vpnglobal_domain_binding[] get_filtered(
      nitro_service service,
      string filter)
    {
      vpnglobal_domain_binding vpnglobalDomainBinding = new vpnglobal_domain_binding();
      options option = new options();
      option.set_filter(filter);
      return (vpnglobal_domain_binding[]) vpnglobalDomainBinding.getfiltered(service, option);
    }

    public static vpnglobal_domain_binding[] get_filtered(
      nitro_service service,
      filtervalue[] filter)
    {
      vpnglobal_domain_binding vpnglobalDomainBinding = new vpnglobal_domain_binding();
      options option = new options();
      option.set_filter(filter);
      return (vpnglobal_domain_binding[]) vpnglobalDomainBinding.getfiltered(service, option);
    }

    public static uint count(nitro_service service)
    {
      vpnglobal_domain_binding vpnglobalDomainBinding = new vpnglobal_domain_binding();
      options option = new options();
      option.set_count(true);
      vpnglobal_domain_binding[] resources = (vpnglobal_domain_binding[]) vpnglobalDomainBinding.get_resources(service, option);
      return resources != null && resources.Length > 0 ? resources[0].__count.Value : 0U;
    }

    public static uint count_filtered(nitro_service service, string filter)
    {
      vpnglobal_domain_binding vpnglobalDomainBinding = new vpnglobal_domain_binding();
      options option = new options();
      option.set_count(true);
      option.set_filter(filter);
      vpnglobal_domain_binding[] vpnglobalDomainBindingArray = (vpnglobal_domain_binding[]) vpnglobalDomainBinding.getfiltered(service, option);
      return vpnglobalDomainBindingArray != null && vpnglobalDomainBindingArray.Length > 0 ? vpnglobalDomainBindingArray[0].__count.Value : 0U;
    }

    public static uint count_filtered(nitro_service service, filtervalue[] filter)
    {
      vpnglobal_domain_binding vpnglobalDomainBinding = new vpnglobal_domain_binding();
      options option = new options();
      option.set_count(true);
      option.set_filter(filter);
      vpnglobal_domain_binding[] vpnglobalDomainBindingArray = (vpnglobal_domain_binding[]) vpnglobalDomainBinding.getfiltered(service, option);
      return vpnglobalDomainBindingArray != null && vpnglobalDomainBindingArray.Length > 0 ? vpnglobalDomainBindingArray[0].__count.Value : 0U;
    }

    private class vpnglobal_domain_binding_response : base_response
    {
      public vpnglobal_domain_binding[] vpnglobal_domain_binding = (vpnglobal_domain_binding[]) null;
    }
  }
}
