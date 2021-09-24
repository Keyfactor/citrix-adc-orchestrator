// Decompiled with JetBrains decompiler
// Type: com.citrix.netscaler.nitro.resource.config.network.rnat6_nsip6_binding
// Assembly: nitro, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 6CF5DDEF-E052-4F9D-953F-6644F8378A66


using com.citrix.netscaler.nitro.exception;
using com.citrix.netscaler.nitro.resource.Base;
using com.citrix.netscaler.nitro.service;
using com.citrix.netscaler.nitro.util;

namespace com.citrix.netscaler.nitro.resource.config.network
{
  public class rnat6_nsip6_binding : base_resource
  {
    private string natip6Field = (string) null;
    private string nameField = (string) null;
    private uint? __countField = new uint?();

    public uint? __count
    {
      get => this.__countField;
      set => this.__countField = value;
    }

    public string name
    {
      get => this.nameField;
      set => this.nameField = value;
    }

    public string natip6
    {
      get => this.natip6Field;
      set => this.natip6Field = value;
    }

    internal override base_resource[] get_nitro_response(
      nitro_service service,
      string response)
    {
      rnat6_nsip6_binding.rnat6_nsip6_binding_response nsip6BindingResponse = new rnat6_nsip6_binding.rnat6_nsip6_binding_response();
      rnat6_nsip6_binding.rnat6_nsip6_binding_response resource = (rnat6_nsip6_binding.rnat6_nsip6_binding_response) service.get_payload_formatter().string_to_resource(nsip6BindingResponse.GetType(), response);
      if (resource.errorcode != 0)
      {
        if (resource.errorcode == 444)
          service.clear_session();
        if (resource.severity == null)
          throw new nitro_exception(resource.message, resource.errorcode);
        if (resource.severity.Equals("ERROR"))
          throw new nitro_exception(resource.message, resource.errorcode);
      }
      return (base_resource[]) resource.rnat6_nsip6_binding;
    }

    internal override string get_object_name() => this.name;

    public static base_response add(nitro_service client, rnat6_nsip6_binding resource) => new rnat6_nsip6_binding()
    {
      name = resource.name,
      natip6 = resource.natip6
    }.update_resource(client);

    public static base_responses add(
      nitro_service client,
      rnat6_nsip6_binding[] resources)
    {
      base_responses baseResponses = (base_responses) null;
      if (resources != null && resources.Length > 0)
      {
        rnat6_nsip6_binding[] rnat6Nsip6BindingArray = new rnat6_nsip6_binding[resources.Length];
        for (int index = 0; index < resources.Length; ++index)
        {
          rnat6Nsip6BindingArray[index] = new rnat6_nsip6_binding();
          rnat6Nsip6BindingArray[index].name = resources[index].name;
          rnat6Nsip6BindingArray[index].natip6 = resources[index].natip6;
        }
        baseResponses = base_resource.update_bulk_request(client, (base_resource[]) rnat6Nsip6BindingArray);
      }
      return baseResponses;
    }

    public static base_response delete(
      nitro_service client,
      rnat6_nsip6_binding resource)
    {
      return new rnat6_nsip6_binding()
      {
        name = resource.name,
        natip6 = resource.natip6
      }.delete_resource(client);
    }

    public static base_responses delete(
      nitro_service client,
      rnat6_nsip6_binding[] resources)
    {
      base_responses baseResponses = (base_responses) null;
      if (resources != null && resources.Length > 0)
      {
        rnat6_nsip6_binding[] rnat6Nsip6BindingArray = new rnat6_nsip6_binding[resources.Length];
        for (int index = 0; index < resources.Length; ++index)
        {
          rnat6Nsip6BindingArray[index] = new rnat6_nsip6_binding();
          rnat6Nsip6BindingArray[index].name = resources[index].name;
          rnat6Nsip6BindingArray[index].natip6 = resources[index].natip6;
        }
        baseResponses = base_resource.delete_bulk_request(client, (base_resource[]) rnat6Nsip6BindingArray);
      }
      return baseResponses;
    }

    public static rnat6_nsip6_binding[] get(nitro_service service, string name) => (rnat6_nsip6_binding[]) new rnat6_nsip6_binding()
    {
      name = name
    }.get_resources(service, (options) null);

    public static rnat6_nsip6_binding[] get_filtered(
      nitro_service service,
      string name,
      string filter)
    {
      rnat6_nsip6_binding rnat6Nsip6Binding = new rnat6_nsip6_binding();
      rnat6Nsip6Binding.name = name;
      options option = new options();
      option.set_filter(filter);
      return (rnat6_nsip6_binding[]) rnat6Nsip6Binding.getfiltered(service, option);
    }

    public static rnat6_nsip6_binding[] get_filtered(
      nitro_service service,
      string name,
      filtervalue[] filter)
    {
      rnat6_nsip6_binding rnat6Nsip6Binding = new rnat6_nsip6_binding();
      rnat6Nsip6Binding.name = name;
      options option = new options();
      option.set_filter(filter);
      return (rnat6_nsip6_binding[]) rnat6Nsip6Binding.getfiltered(service, option);
    }

    public static uint count(nitro_service service, string name)
    {
      rnat6_nsip6_binding rnat6Nsip6Binding = new rnat6_nsip6_binding();
      rnat6Nsip6Binding.name = name;
      options option = new options();
      option.set_count(true);
      rnat6_nsip6_binding[] resources = (rnat6_nsip6_binding[]) rnat6Nsip6Binding.get_resources(service, option);
      return resources != null && resources.Length > 0 ? resources[0].__count.Value : 0U;
    }

    public static uint count_filtered(nitro_service service, string name, string filter)
    {
      rnat6_nsip6_binding rnat6Nsip6Binding = new rnat6_nsip6_binding();
      rnat6Nsip6Binding.name = name;
      options option = new options();
      option.set_count(true);
      option.set_filter(filter);
      rnat6_nsip6_binding[] rnat6Nsip6BindingArray = (rnat6_nsip6_binding[]) rnat6Nsip6Binding.getfiltered(service, option);
      return rnat6Nsip6BindingArray != null && rnat6Nsip6BindingArray.Length > 0 ? rnat6Nsip6BindingArray[0].__count.Value : 0U;
    }

    public static uint count_filtered(nitro_service service, string name, filtervalue[] filter)
    {
      rnat6_nsip6_binding rnat6Nsip6Binding = new rnat6_nsip6_binding();
      rnat6Nsip6Binding.name = name;
      options option = new options();
      option.set_count(true);
      option.set_filter(filter);
      rnat6_nsip6_binding[] rnat6Nsip6BindingArray = (rnat6_nsip6_binding[]) rnat6Nsip6Binding.getfiltered(service, option);
      return rnat6Nsip6BindingArray != null && rnat6Nsip6BindingArray.Length > 0 ? rnat6Nsip6BindingArray[0].__count.Value : 0U;
    }

    private class rnat6_nsip6_binding_response : base_response
    {
      public rnat6_nsip6_binding[] rnat6_nsip6_binding = (rnat6_nsip6_binding[]) null;
    }
  }
}
