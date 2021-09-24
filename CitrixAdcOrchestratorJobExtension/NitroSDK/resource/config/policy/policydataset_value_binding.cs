// Decompiled with JetBrains decompiler
// Type: com.citrix.netscaler.nitro.resource.config.policy.policydataset_value_binding
// Assembly: nitro, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 6CF5DDEF-E052-4F9D-953F-6644F8378A66


using com.citrix.netscaler.nitro.exception;
using com.citrix.netscaler.nitro.resource.Base;
using com.citrix.netscaler.nitro.service;
using com.citrix.netscaler.nitro.util;

namespace com.citrix.netscaler.nitro.resource.config.policy
{
  public class policydataset_value_binding : base_resource
  {
    private string valueField = (string) null;
    private uint? indexField = new uint?();
    private string nameField = (string) null;
    private uint? __countField = new uint?();

    public uint? __count
    {
      get => this.__countField;
      set => this.__countField = value;
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

    public uint? index
    {
      get => this.indexField;
      set => this.indexField = value;
    }

    internal override base_resource[] get_nitro_response(
      nitro_service service,
      string response)
    {
      policydataset_value_binding.policydataset_value_binding_response valueBindingResponse = new policydataset_value_binding.policydataset_value_binding_response();
      policydataset_value_binding.policydataset_value_binding_response resource = (policydataset_value_binding.policydataset_value_binding_response) service.get_payload_formatter().string_to_resource(valueBindingResponse.GetType(), response);
      if (resource.errorcode != 0)
      {
        if (resource.errorcode == 444)
          service.clear_session();
        if (resource.severity == null)
          throw new nitro_exception(resource.message, resource.errorcode);
        if (resource.severity.Equals("ERROR"))
          throw new nitro_exception(resource.message, resource.errorcode);
      }
      return (base_resource[]) resource.policydataset_value_binding;
    }

    internal override string get_object_name() => this.name;

    public static base_response add(
      nitro_service client,
      policydataset_value_binding resource)
    {
      return new policydataset_value_binding()
      {
        name = resource.name,
        value = resource.value,
        index = resource.index
      }.update_resource(client);
    }

    public static base_responses add(
      nitro_service client,
      policydataset_value_binding[] resources)
    {
      base_responses baseResponses = (base_responses) null;
      if (resources != null && resources.Length > 0)
      {
        policydataset_value_binding[] policydatasetValueBindingArray = new policydataset_value_binding[resources.Length];
        for (int index = 0; index < resources.Length; ++index)
        {
          policydatasetValueBindingArray[index] = new policydataset_value_binding();
          policydatasetValueBindingArray[index].name = resources[index].name;
          policydatasetValueBindingArray[index].value = resources[index].value;
          policydatasetValueBindingArray[index].index = resources[index].index;
        }
        baseResponses = base_resource.update_bulk_request(client, (base_resource[]) policydatasetValueBindingArray);
      }
      return baseResponses;
    }

    public static base_response delete(
      nitro_service client,
      policydataset_value_binding resource)
    {
      return new policydataset_value_binding()
      {
        name = resource.name,
        value = resource.value
      }.delete_resource(client);
    }

    public static base_responses delete(
      nitro_service client,
      policydataset_value_binding[] resources)
    {
      base_responses baseResponses = (base_responses) null;
      if (resources != null && resources.Length > 0)
      {
        policydataset_value_binding[] policydatasetValueBindingArray = new policydataset_value_binding[resources.Length];
        for (int index = 0; index < resources.Length; ++index)
        {
          policydatasetValueBindingArray[index] = new policydataset_value_binding();
          policydatasetValueBindingArray[index].name = resources[index].name;
          policydatasetValueBindingArray[index].value = resources[index].value;
        }
        baseResponses = base_resource.delete_bulk_request(client, (base_resource[]) policydatasetValueBindingArray);
      }
      return baseResponses;
    }

    public static policydataset_value_binding[] get(
      nitro_service service,
      string name)
    {
      return (policydataset_value_binding[]) new policydataset_value_binding()
      {
        name = name
      }.get_resources(service, (options) null);
    }

    public static policydataset_value_binding[] get_filtered(
      nitro_service service,
      string name,
      string filter)
    {
      policydataset_value_binding policydatasetValueBinding = new policydataset_value_binding();
      policydatasetValueBinding.name = name;
      options option = new options();
      option.set_filter(filter);
      return (policydataset_value_binding[]) policydatasetValueBinding.getfiltered(service, option);
    }

    public static policydataset_value_binding[] get_filtered(
      nitro_service service,
      string name,
      filtervalue[] filter)
    {
      policydataset_value_binding policydatasetValueBinding = new policydataset_value_binding();
      policydatasetValueBinding.name = name;
      options option = new options();
      option.set_filter(filter);
      return (policydataset_value_binding[]) policydatasetValueBinding.getfiltered(service, option);
    }

    public static uint count(nitro_service service, string name)
    {
      policydataset_value_binding policydatasetValueBinding = new policydataset_value_binding();
      policydatasetValueBinding.name = name;
      options option = new options();
      option.set_count(true);
      policydataset_value_binding[] resources = (policydataset_value_binding[]) policydatasetValueBinding.get_resources(service, option);
      return resources != null && resources.Length > 0 ? resources[0].__count.Value : 0U;
    }

    public static uint count_filtered(nitro_service service, string name, string filter)
    {
      policydataset_value_binding policydatasetValueBinding = new policydataset_value_binding();
      policydatasetValueBinding.name = name;
      options option = new options();
      option.set_count(true);
      option.set_filter(filter);
      policydataset_value_binding[] policydatasetValueBindingArray = (policydataset_value_binding[]) policydatasetValueBinding.getfiltered(service, option);
      return policydatasetValueBindingArray != null && policydatasetValueBindingArray.Length > 0 ? policydatasetValueBindingArray[0].__count.Value : 0U;
    }

    public static uint count_filtered(nitro_service service, string name, filtervalue[] filter)
    {
      policydataset_value_binding policydatasetValueBinding = new policydataset_value_binding();
      policydatasetValueBinding.name = name;
      options option = new options();
      option.set_count(true);
      option.set_filter(filter);
      policydataset_value_binding[] policydatasetValueBindingArray = (policydataset_value_binding[]) policydatasetValueBinding.getfiltered(service, option);
      return policydatasetValueBindingArray != null && policydatasetValueBindingArray.Length > 0 ? policydatasetValueBindingArray[0].__count.Value : 0U;
    }

    private class policydataset_value_binding_response : base_response
    {
      public policydataset_value_binding[] policydataset_value_binding = (policydataset_value_binding[]) null;
    }
  }
}
