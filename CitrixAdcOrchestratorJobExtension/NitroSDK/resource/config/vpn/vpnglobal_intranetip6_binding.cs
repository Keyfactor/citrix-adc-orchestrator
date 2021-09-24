// Decompiled with JetBrains decompiler
// Type: com.citrix.netscaler.nitro.resource.config.vpn.vpnglobal_intranetip6_binding
// Assembly: nitro, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 6CF5DDEF-E052-4F9D-953F-6644F8378A66


using com.citrix.netscaler.nitro.exception;
using com.citrix.netscaler.nitro.resource.Base;
using com.citrix.netscaler.nitro.service;
using com.citrix.netscaler.nitro.util;

namespace com.citrix.netscaler.nitro.resource.config.vpn
{
  public class vpnglobal_intranetip6_binding : base_resource
  {
    private string intranetip6Field = (string) null;
    private uint? numaddrField = new uint?();
    private uint? __countField = new uint?();

    public uint? __count
    {
      get => this.__countField;
      set => this.__countField = value;
    }

    public string intranetip6
    {
      get => this.intranetip6Field;
      set => this.intranetip6Field = value;
    }

    public uint? numaddr
    {
      get => this.numaddrField;
      set => this.numaddrField = value;
    }

    internal override base_resource[] get_nitro_response(
      nitro_service service,
      string response)
    {
      vpnglobal_intranetip6_binding.vpnglobal_intranetip6_binding_response intranetip6BindingResponse = new vpnglobal_intranetip6_binding.vpnglobal_intranetip6_binding_response();
      vpnglobal_intranetip6_binding.vpnglobal_intranetip6_binding_response resource = (vpnglobal_intranetip6_binding.vpnglobal_intranetip6_binding_response) service.get_payload_formatter().string_to_resource(intranetip6BindingResponse.GetType(), response);
      if (resource.errorcode != 0)
      {
        if (resource.errorcode == 444)
          service.clear_session();
        if (resource.severity == null)
          throw new nitro_exception(resource.message, resource.errorcode);
        if (resource.severity.Equals("ERROR"))
          throw new nitro_exception(resource.message, resource.errorcode);
      }
      return (base_resource[]) resource.vpnglobal_intranetip6_binding;
    }

    internal override string get_object_name() => (string) null;

    public static base_response add(
      nitro_service client,
      vpnglobal_intranetip6_binding resource)
    {
      return new vpnglobal_intranetip6_binding()
      {
        intranetip6 = resource.intranetip6,
        numaddr = resource.numaddr
      }.update_resource(client);
    }

    public static base_responses add(
      nitro_service client,
      vpnglobal_intranetip6_binding[] resources)
    {
      base_responses baseResponses = (base_responses) null;
      if (resources != null && resources.Length > 0)
      {
        vpnglobal_intranetip6_binding[] intranetip6BindingArray = new vpnglobal_intranetip6_binding[resources.Length];
        for (int index = 0; index < resources.Length; ++index)
        {
          intranetip6BindingArray[index] = new vpnglobal_intranetip6_binding();
          intranetip6BindingArray[index].intranetip6 = resources[index].intranetip6;
          intranetip6BindingArray[index].numaddr = resources[index].numaddr;
        }
        baseResponses = base_resource.update_bulk_request(client, (base_resource[]) intranetip6BindingArray);
      }
      return baseResponses;
    }

    public static base_response delete(
      nitro_service client,
      vpnglobal_intranetip6_binding resource)
    {
      return new vpnglobal_intranetip6_binding()
      {
        intranetip6 = resource.intranetip6,
        numaddr = resource.numaddr
      }.delete_resource(client);
    }

    public static base_responses delete(
      nitro_service client,
      vpnglobal_intranetip6_binding[] resources)
    {
      base_responses baseResponses = (base_responses) null;
      if (resources != null && resources.Length > 0)
      {
        vpnglobal_intranetip6_binding[] intranetip6BindingArray = new vpnglobal_intranetip6_binding[resources.Length];
        for (int index = 0; index < resources.Length; ++index)
        {
          intranetip6BindingArray[index] = new vpnglobal_intranetip6_binding();
          intranetip6BindingArray[index].intranetip6 = resources[index].intranetip6;
          intranetip6BindingArray[index].numaddr = resources[index].numaddr;
        }
        baseResponses = base_resource.delete_bulk_request(client, (base_resource[]) intranetip6BindingArray);
      }
      return baseResponses;
    }

    public static vpnglobal_intranetip6_binding[] get(
      nitro_service service)
    {
      return (vpnglobal_intranetip6_binding[]) new vpnglobal_intranetip6_binding().get_resources(service, (options) null);
    }

    public static vpnglobal_intranetip6_binding[] get_filtered(
      nitro_service service,
      string filter)
    {
      vpnglobal_intranetip6_binding intranetip6Binding = new vpnglobal_intranetip6_binding();
      options option = new options();
      option.set_filter(filter);
      return (vpnglobal_intranetip6_binding[]) intranetip6Binding.getfiltered(service, option);
    }

    public static vpnglobal_intranetip6_binding[] get_filtered(
      nitro_service service,
      filtervalue[] filter)
    {
      vpnglobal_intranetip6_binding intranetip6Binding = new vpnglobal_intranetip6_binding();
      options option = new options();
      option.set_filter(filter);
      return (vpnglobal_intranetip6_binding[]) intranetip6Binding.getfiltered(service, option);
    }

    public static uint count(nitro_service service)
    {
      vpnglobal_intranetip6_binding intranetip6Binding = new vpnglobal_intranetip6_binding();
      options option = new options();
      option.set_count(true);
      vpnglobal_intranetip6_binding[] resources = (vpnglobal_intranetip6_binding[]) intranetip6Binding.get_resources(service, option);
      return resources != null && resources.Length > 0 ? resources[0].__count.Value : 0U;
    }

    public static uint count_filtered(nitro_service service, string filter)
    {
      vpnglobal_intranetip6_binding intranetip6Binding = new vpnglobal_intranetip6_binding();
      options option = new options();
      option.set_count(true);
      option.set_filter(filter);
      vpnglobal_intranetip6_binding[] intranetip6BindingArray = (vpnglobal_intranetip6_binding[]) intranetip6Binding.getfiltered(service, option);
      return intranetip6BindingArray != null && intranetip6BindingArray.Length > 0 ? intranetip6BindingArray[0].__count.Value : 0U;
    }

    public static uint count_filtered(nitro_service service, filtervalue[] filter)
    {
      vpnglobal_intranetip6_binding intranetip6Binding = new vpnglobal_intranetip6_binding();
      options option = new options();
      option.set_count(true);
      option.set_filter(filter);
      vpnglobal_intranetip6_binding[] intranetip6BindingArray = (vpnglobal_intranetip6_binding[]) intranetip6Binding.getfiltered(service, option);
      return intranetip6BindingArray != null && intranetip6BindingArray.Length > 0 ? intranetip6BindingArray[0].__count.Value : 0U;
    }

    private class vpnglobal_intranetip6_binding_response : base_response
    {
      public vpnglobal_intranetip6_binding[] vpnglobal_intranetip6_binding = (vpnglobal_intranetip6_binding[]) null;
    }
  }
}
