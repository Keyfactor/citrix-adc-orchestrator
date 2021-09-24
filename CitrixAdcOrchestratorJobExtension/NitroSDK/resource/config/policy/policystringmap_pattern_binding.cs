// Decompiled with JetBrains decompiler
// Type: com.citrix.netscaler.nitro.resource.config.policy.policystringmap_pattern_binding
// Assembly: nitro, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 6CF5DDEF-E052-4F9D-953F-6644F8378A66


using com.citrix.netscaler.nitro.exception;
using com.citrix.netscaler.nitro.resource.Base;
using com.citrix.netscaler.nitro.service;
using com.citrix.netscaler.nitro.util;

namespace com.citrix.netscaler.nitro.resource.config.policy
{
  public class policystringmap_pattern_binding : base_resource
  {
    private string keyField = (string) null;
    private string valueField = (string) null;
    private string nameField = (string) null;
    private uint? __countField = new uint?();

    public uint? __count
    {
      get => this.__countField;
      set => this.__countField = value;
    }

    public string key
    {
      get => this.keyField;
      set => this.keyField = value;
    }

    public string value
    {
      get => this.valueField;
      set => this.valueField = value;
    }

    public string name
    {
      get => this.nameField;
      set => this.nameField = value;
    }

    internal override base_resource[] get_nitro_response(
      nitro_service service,
      string response)
    {
      policystringmap_pattern_binding.policystringmap_pattern_binding_response patternBindingResponse = new policystringmap_pattern_binding.policystringmap_pattern_binding_response();
      policystringmap_pattern_binding.policystringmap_pattern_binding_response resource = (policystringmap_pattern_binding.policystringmap_pattern_binding_response) service.get_payload_formatter().string_to_resource(patternBindingResponse.GetType(), response);
      if (resource.errorcode != 0)
      {
        if (resource.errorcode == 444)
          service.clear_session();
        if (resource.severity == null)
          throw new nitro_exception(resource.message, resource.errorcode);
        if (resource.severity.Equals("ERROR"))
          throw new nitro_exception(resource.message, resource.errorcode);
      }
      return (base_resource[]) resource.policystringmap_pattern_binding;
    }

    internal override string get_object_name() => this.name;

    public static base_response add(
      nitro_service client,
      policystringmap_pattern_binding resource)
    {
      return new policystringmap_pattern_binding()
      {
        name = resource.name,
        key = resource.key,
        value = resource.value
      }.update_resource(client);
    }

    public static base_responses add(
      nitro_service client,
      policystringmap_pattern_binding[] resources)
    {
      base_responses baseResponses = (base_responses) null;
      if (resources != null && resources.Length > 0)
      {
        policystringmap_pattern_binding[] policystringmapPatternBindingArray = new policystringmap_pattern_binding[resources.Length];
        for (int index = 0; index < resources.Length; ++index)
        {
          policystringmapPatternBindingArray[index] = new policystringmap_pattern_binding();
          policystringmapPatternBindingArray[index].name = resources[index].name;
          policystringmapPatternBindingArray[index].key = resources[index].key;
          policystringmapPatternBindingArray[index].value = resources[index].value;
        }
        baseResponses = base_resource.update_bulk_request(client, (base_resource[]) policystringmapPatternBindingArray);
      }
      return baseResponses;
    }

    public static base_response delete(
      nitro_service client,
      policystringmap_pattern_binding resource)
    {
      return new policystringmap_pattern_binding()
      {
        name = resource.name,
        key = resource.key
      }.delete_resource(client);
    }

    public static base_responses delete(
      nitro_service client,
      policystringmap_pattern_binding[] resources)
    {
      base_responses baseResponses = (base_responses) null;
      if (resources != null && resources.Length > 0)
      {
        policystringmap_pattern_binding[] policystringmapPatternBindingArray = new policystringmap_pattern_binding[resources.Length];
        for (int index = 0; index < resources.Length; ++index)
        {
          policystringmapPatternBindingArray[index] = new policystringmap_pattern_binding();
          policystringmapPatternBindingArray[index].name = resources[index].name;
          policystringmapPatternBindingArray[index].key = resources[index].key;
        }
        baseResponses = base_resource.delete_bulk_request(client, (base_resource[]) policystringmapPatternBindingArray);
      }
      return baseResponses;
    }

    public static policystringmap_pattern_binding[] get(
      nitro_service service,
      string name)
    {
      return (policystringmap_pattern_binding[]) new policystringmap_pattern_binding()
      {
        name = name
      }.get_resources(service, (options) null);
    }

    public static policystringmap_pattern_binding[] get_filtered(
      nitro_service service,
      string name,
      string filter)
    {
      policystringmap_pattern_binding policystringmapPatternBinding = new policystringmap_pattern_binding();
      policystringmapPatternBinding.name = name;
      options option = new options();
      option.set_filter(filter);
      return (policystringmap_pattern_binding[]) policystringmapPatternBinding.getfiltered(service, option);
    }

    public static policystringmap_pattern_binding[] get_filtered(
      nitro_service service,
      string name,
      filtervalue[] filter)
    {
      policystringmap_pattern_binding policystringmapPatternBinding = new policystringmap_pattern_binding();
      policystringmapPatternBinding.name = name;
      options option = new options();
      option.set_filter(filter);
      return (policystringmap_pattern_binding[]) policystringmapPatternBinding.getfiltered(service, option);
    }

    public static uint count(nitro_service service, string name)
    {
      policystringmap_pattern_binding policystringmapPatternBinding = new policystringmap_pattern_binding();
      policystringmapPatternBinding.name = name;
      options option = new options();
      option.set_count(true);
      policystringmap_pattern_binding[] resources = (policystringmap_pattern_binding[]) policystringmapPatternBinding.get_resources(service, option);
      return resources != null && resources.Length > 0 ? resources[0].__count.Value : 0U;
    }

    public static uint count_filtered(nitro_service service, string name, string filter)
    {
      policystringmap_pattern_binding policystringmapPatternBinding = new policystringmap_pattern_binding();
      policystringmapPatternBinding.name = name;
      options option = new options();
      option.set_count(true);
      option.set_filter(filter);
      policystringmap_pattern_binding[] policystringmapPatternBindingArray = (policystringmap_pattern_binding[]) policystringmapPatternBinding.getfiltered(service, option);
      return policystringmapPatternBindingArray != null && policystringmapPatternBindingArray.Length > 0 ? policystringmapPatternBindingArray[0].__count.Value : 0U;
    }

    public static uint count_filtered(nitro_service service, string name, filtervalue[] filter)
    {
      policystringmap_pattern_binding policystringmapPatternBinding = new policystringmap_pattern_binding();
      policystringmapPatternBinding.name = name;
      options option = new options();
      option.set_count(true);
      option.set_filter(filter);
      policystringmap_pattern_binding[] policystringmapPatternBindingArray = (policystringmap_pattern_binding[]) policystringmapPatternBinding.getfiltered(service, option);
      return policystringmapPatternBindingArray != null && policystringmapPatternBindingArray.Length > 0 ? policystringmapPatternBindingArray[0].__count.Value : 0U;
    }

    private class policystringmap_pattern_binding_response : base_response
    {
      public policystringmap_pattern_binding[] policystringmap_pattern_binding = (policystringmap_pattern_binding[]) null;
    }
  }
}
