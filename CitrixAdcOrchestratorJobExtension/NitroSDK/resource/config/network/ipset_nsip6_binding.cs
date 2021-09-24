// Decompiled with JetBrains decompiler
// Type: com.citrix.netscaler.nitro.resource.config.network.ipset_nsip6_binding
// Assembly: nitro, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 6CF5DDEF-E052-4F9D-953F-6644F8378A66


using com.citrix.netscaler.nitro.exception;
using com.citrix.netscaler.nitro.resource.Base;
using com.citrix.netscaler.nitro.service;
using com.citrix.netscaler.nitro.util;

namespace com.citrix.netscaler.nitro.resource.config.network
{
  public class ipset_nsip6_binding : base_resource
  {
    private string ipaddressField = (string) null;
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

    public string ipaddress
    {
      get => this.ipaddressField;
      set => this.ipaddressField = value;
    }

    internal override base_resource[] get_nitro_response(
      nitro_service service,
      string response)
    {
      ipset_nsip6_binding.ipset_nsip6_binding_response nsip6BindingResponse = new ipset_nsip6_binding.ipset_nsip6_binding_response();
      ipset_nsip6_binding.ipset_nsip6_binding_response resource = (ipset_nsip6_binding.ipset_nsip6_binding_response) service.get_payload_formatter().string_to_resource(nsip6BindingResponse.GetType(), response);
      if (resource.errorcode != 0)
      {
        if (resource.errorcode == 444)
          service.clear_session();
        if (resource.severity == null)
          throw new nitro_exception(resource.message, resource.errorcode);
        if (resource.severity.Equals("ERROR"))
          throw new nitro_exception(resource.message, resource.errorcode);
      }
      return (base_resource[]) resource.ipset_nsip6_binding;
    }

    internal override string get_object_name() => this.name;

    public static base_response add(nitro_service client, ipset_nsip6_binding resource) => new ipset_nsip6_binding()
    {
      name = resource.name,
      ipaddress = resource.ipaddress
    }.update_resource(client);

    public static base_responses add(
      nitro_service client,
      ipset_nsip6_binding[] resources)
    {
      base_responses baseResponses = (base_responses) null;
      if (resources != null && resources.Length > 0)
      {
        ipset_nsip6_binding[] ipsetNsip6BindingArray = new ipset_nsip6_binding[resources.Length];
        for (int index = 0; index < resources.Length; ++index)
        {
          ipsetNsip6BindingArray[index] = new ipset_nsip6_binding();
          ipsetNsip6BindingArray[index].name = resources[index].name;
          ipsetNsip6BindingArray[index].ipaddress = resources[index].ipaddress;
        }
        baseResponses = base_resource.update_bulk_request(client, (base_resource[]) ipsetNsip6BindingArray);
      }
      return baseResponses;
    }

    public static base_response delete(
      nitro_service client,
      ipset_nsip6_binding resource)
    {
      return new ipset_nsip6_binding()
      {
        name = resource.name,
        ipaddress = resource.ipaddress
      }.delete_resource(client);
    }

    public static base_responses delete(
      nitro_service client,
      ipset_nsip6_binding[] resources)
    {
      base_responses baseResponses = (base_responses) null;
      if (resources != null && resources.Length > 0)
      {
        ipset_nsip6_binding[] ipsetNsip6BindingArray = new ipset_nsip6_binding[resources.Length];
        for (int index = 0; index < resources.Length; ++index)
        {
          ipsetNsip6BindingArray[index] = new ipset_nsip6_binding();
          ipsetNsip6BindingArray[index].name = resources[index].name;
          ipsetNsip6BindingArray[index].ipaddress = resources[index].ipaddress;
        }
        baseResponses = base_resource.delete_bulk_request(client, (base_resource[]) ipsetNsip6BindingArray);
      }
      return baseResponses;
    }

    public static ipset_nsip6_binding[] get(nitro_service service, string name) => (ipset_nsip6_binding[]) new ipset_nsip6_binding()
    {
      name = name
    }.get_resources(service, (options) null);

    public static ipset_nsip6_binding[] get_filtered(
      nitro_service service,
      string name,
      string filter)
    {
      ipset_nsip6_binding ipsetNsip6Binding = new ipset_nsip6_binding();
      ipsetNsip6Binding.name = name;
      options option = new options();
      option.set_filter(filter);
      return (ipset_nsip6_binding[]) ipsetNsip6Binding.getfiltered(service, option);
    }

    public static ipset_nsip6_binding[] get_filtered(
      nitro_service service,
      string name,
      filtervalue[] filter)
    {
      ipset_nsip6_binding ipsetNsip6Binding = new ipset_nsip6_binding();
      ipsetNsip6Binding.name = name;
      options option = new options();
      option.set_filter(filter);
      return (ipset_nsip6_binding[]) ipsetNsip6Binding.getfiltered(service, option);
    }

    public static uint count(nitro_service service, string name)
    {
      ipset_nsip6_binding ipsetNsip6Binding = new ipset_nsip6_binding();
      ipsetNsip6Binding.name = name;
      options option = new options();
      option.set_count(true);
      ipset_nsip6_binding[] resources = (ipset_nsip6_binding[]) ipsetNsip6Binding.get_resources(service, option);
      return resources != null && resources.Length > 0 ? resources[0].__count.Value : 0U;
    }

    public static uint count_filtered(nitro_service service, string name, string filter)
    {
      ipset_nsip6_binding ipsetNsip6Binding = new ipset_nsip6_binding();
      ipsetNsip6Binding.name = name;
      options option = new options();
      option.set_count(true);
      option.set_filter(filter);
      ipset_nsip6_binding[] ipsetNsip6BindingArray = (ipset_nsip6_binding[]) ipsetNsip6Binding.getfiltered(service, option);
      return ipsetNsip6BindingArray != null && ipsetNsip6BindingArray.Length > 0 ? ipsetNsip6BindingArray[0].__count.Value : 0U;
    }

    public static uint count_filtered(nitro_service service, string name, filtervalue[] filter)
    {
      ipset_nsip6_binding ipsetNsip6Binding = new ipset_nsip6_binding();
      ipsetNsip6Binding.name = name;
      options option = new options();
      option.set_count(true);
      option.set_filter(filter);
      ipset_nsip6_binding[] ipsetNsip6BindingArray = (ipset_nsip6_binding[]) ipsetNsip6Binding.getfiltered(service, option);
      return ipsetNsip6BindingArray != null && ipsetNsip6BindingArray.Length > 0 ? ipsetNsip6BindingArray[0].__count.Value : 0U;
    }

    private class ipset_nsip6_binding_response : base_response
    {
      public ipset_nsip6_binding[] ipset_nsip6_binding = (ipset_nsip6_binding[]) null;
    }
  }
}
