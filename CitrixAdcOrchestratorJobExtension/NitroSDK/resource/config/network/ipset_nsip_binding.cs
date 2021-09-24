// Decompiled with JetBrains decompiler
// Type: com.citrix.netscaler.nitro.resource.config.network.ipset_nsip_binding
// Assembly: nitro, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 6CF5DDEF-E052-4F9D-953F-6644F8378A66


using com.citrix.netscaler.nitro.exception;
using com.citrix.netscaler.nitro.resource.Base;
using com.citrix.netscaler.nitro.service;
using com.citrix.netscaler.nitro.util;

namespace com.citrix.netscaler.nitro.resource.config.network
{
  public class ipset_nsip_binding : base_resource
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
      ipset_nsip_binding.ipset_nsip_binding_response nsipBindingResponse = new ipset_nsip_binding.ipset_nsip_binding_response();
      ipset_nsip_binding.ipset_nsip_binding_response resource = (ipset_nsip_binding.ipset_nsip_binding_response) service.get_payload_formatter().string_to_resource(nsipBindingResponse.GetType(), response);
      if (resource.errorcode != 0)
      {
        if (resource.errorcode == 444)
          service.clear_session();
        if (resource.severity == null)
          throw new nitro_exception(resource.message, resource.errorcode);
        if (resource.severity.Equals("ERROR"))
          throw new nitro_exception(resource.message, resource.errorcode);
      }
      return (base_resource[]) resource.ipset_nsip_binding;
    }

    internal override string get_object_name() => this.name;

    public static base_response add(nitro_service client, ipset_nsip_binding resource) => new ipset_nsip_binding()
    {
      name = resource.name,
      ipaddress = resource.ipaddress
    }.update_resource(client);

    public static base_responses add(
      nitro_service client,
      ipset_nsip_binding[] resources)
    {
      base_responses baseResponses = (base_responses) null;
      if (resources != null && resources.Length > 0)
      {
        ipset_nsip_binding[] ipsetNsipBindingArray = new ipset_nsip_binding[resources.Length];
        for (int index = 0; index < resources.Length; ++index)
        {
          ipsetNsipBindingArray[index] = new ipset_nsip_binding();
          ipsetNsipBindingArray[index].name = resources[index].name;
          ipsetNsipBindingArray[index].ipaddress = resources[index].ipaddress;
        }
        baseResponses = base_resource.update_bulk_request(client, (base_resource[]) ipsetNsipBindingArray);
      }
      return baseResponses;
    }

    public static base_response delete(
      nitro_service client,
      ipset_nsip_binding resource)
    {
      return new ipset_nsip_binding()
      {
        name = resource.name,
        ipaddress = resource.ipaddress
      }.delete_resource(client);
    }

    public static base_responses delete(
      nitro_service client,
      ipset_nsip_binding[] resources)
    {
      base_responses baseResponses = (base_responses) null;
      if (resources != null && resources.Length > 0)
      {
        ipset_nsip_binding[] ipsetNsipBindingArray = new ipset_nsip_binding[resources.Length];
        for (int index = 0; index < resources.Length; ++index)
        {
          ipsetNsipBindingArray[index] = new ipset_nsip_binding();
          ipsetNsipBindingArray[index].name = resources[index].name;
          ipsetNsipBindingArray[index].ipaddress = resources[index].ipaddress;
        }
        baseResponses = base_resource.delete_bulk_request(client, (base_resource[]) ipsetNsipBindingArray);
      }
      return baseResponses;
    }

    public static ipset_nsip_binding[] get(nitro_service service, string name) => (ipset_nsip_binding[]) new ipset_nsip_binding()
    {
      name = name
    }.get_resources(service, (options) null);

    public static ipset_nsip_binding[] get_filtered(
      nitro_service service,
      string name,
      string filter)
    {
      ipset_nsip_binding ipsetNsipBinding = new ipset_nsip_binding();
      ipsetNsipBinding.name = name;
      options option = new options();
      option.set_filter(filter);
      return (ipset_nsip_binding[]) ipsetNsipBinding.getfiltered(service, option);
    }

    public static ipset_nsip_binding[] get_filtered(
      nitro_service service,
      string name,
      filtervalue[] filter)
    {
      ipset_nsip_binding ipsetNsipBinding = new ipset_nsip_binding();
      ipsetNsipBinding.name = name;
      options option = new options();
      option.set_filter(filter);
      return (ipset_nsip_binding[]) ipsetNsipBinding.getfiltered(service, option);
    }

    public static uint count(nitro_service service, string name)
    {
      ipset_nsip_binding ipsetNsipBinding = new ipset_nsip_binding();
      ipsetNsipBinding.name = name;
      options option = new options();
      option.set_count(true);
      ipset_nsip_binding[] resources = (ipset_nsip_binding[]) ipsetNsipBinding.get_resources(service, option);
      return resources != null && resources.Length > 0 ? resources[0].__count.Value : 0U;
    }

    public static uint count_filtered(nitro_service service, string name, string filter)
    {
      ipset_nsip_binding ipsetNsipBinding = new ipset_nsip_binding();
      ipsetNsipBinding.name = name;
      options option = new options();
      option.set_count(true);
      option.set_filter(filter);
      ipset_nsip_binding[] ipsetNsipBindingArray = (ipset_nsip_binding[]) ipsetNsipBinding.getfiltered(service, option);
      return ipsetNsipBindingArray != null && ipsetNsipBindingArray.Length > 0 ? ipsetNsipBindingArray[0].__count.Value : 0U;
    }

    public static uint count_filtered(nitro_service service, string name, filtervalue[] filter)
    {
      ipset_nsip_binding ipsetNsipBinding = new ipset_nsip_binding();
      ipsetNsipBinding.name = name;
      options option = new options();
      option.set_count(true);
      option.set_filter(filter);
      ipset_nsip_binding[] ipsetNsipBindingArray = (ipset_nsip_binding[]) ipsetNsipBinding.getfiltered(service, option);
      return ipsetNsipBindingArray != null && ipsetNsipBindingArray.Length > 0 ? ipsetNsipBindingArray[0].__count.Value : 0U;
    }

    private class ipset_nsip_binding_response : base_response
    {
      public ipset_nsip_binding[] ipset_nsip_binding = (ipset_nsip_binding[]) null;
    }
  }
}
