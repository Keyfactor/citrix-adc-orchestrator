// Decompiled with JetBrains decompiler
// Type: com.citrix.netscaler.nitro.resource.config.network.netprofile_srcportset_binding
// Assembly: nitro, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 6CF5DDEF-E052-4F9D-953F-6644F8378A66


using com.citrix.netscaler.nitro.exception;
using com.citrix.netscaler.nitro.resource.Base;
using com.citrix.netscaler.nitro.service;
using com.citrix.netscaler.nitro.util;

namespace com.citrix.netscaler.nitro.resource.config.network
{
  public class netprofile_srcportset_binding : base_resource
  {
    private string srcportrangeField = (string) null;
    private string nameField = (string) null;
    private uint? __countField = new uint?();

    public uint? __count
    {
      get => this.__countField;
      set => this.__countField = value;
    }

    public string srcportrange
    {
      get => this.srcportrangeField;
      set => this.srcportrangeField = value;
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
      netprofile_srcportset_binding.netprofile_srcportset_binding_response srcportsetBindingResponse = new netprofile_srcportset_binding.netprofile_srcportset_binding_response();
      netprofile_srcportset_binding.netprofile_srcportset_binding_response resource = (netprofile_srcportset_binding.netprofile_srcportset_binding_response) service.get_payload_formatter().string_to_resource(srcportsetBindingResponse.GetType(), response);
      if (resource.errorcode != 0)
      {
        if (resource.errorcode == 444)
          service.clear_session();
        if (resource.severity == null)
          throw new nitro_exception(resource.message, resource.errorcode);
        if (resource.severity.Equals("ERROR"))
          throw new nitro_exception(resource.message, resource.errorcode);
      }
      return (base_resource[]) resource.netprofile_srcportset_binding;
    }

    internal override string get_object_name() => this.name;

    public static base_response add(
      nitro_service client,
      netprofile_srcportset_binding resource)
    {
      return new netprofile_srcportset_binding()
      {
        name = resource.name,
        srcportrange = resource.srcportrange
      }.update_resource(client);
    }

    public static base_responses add(
      nitro_service client,
      netprofile_srcportset_binding[] resources)
    {
      base_responses baseResponses = (base_responses) null;
      if (resources != null && resources.Length > 0)
      {
        netprofile_srcportset_binding[] srcportsetBindingArray = new netprofile_srcportset_binding[resources.Length];
        for (int index = 0; index < resources.Length; ++index)
        {
          srcportsetBindingArray[index] = new netprofile_srcportset_binding();
          srcportsetBindingArray[index].name = resources[index].name;
          srcportsetBindingArray[index].srcportrange = resources[index].srcportrange;
        }
        baseResponses = base_resource.update_bulk_request(client, (base_resource[]) srcportsetBindingArray);
      }
      return baseResponses;
    }

    public static base_response delete(
      nitro_service client,
      netprofile_srcportset_binding resource)
    {
      return new netprofile_srcportset_binding()
      {
        name = resource.name,
        srcportrange = resource.srcportrange
      }.delete_resource(client);
    }

    public static base_responses delete(
      nitro_service client,
      netprofile_srcportset_binding[] resources)
    {
      base_responses baseResponses = (base_responses) null;
      if (resources != null && resources.Length > 0)
      {
        netprofile_srcportset_binding[] srcportsetBindingArray = new netprofile_srcportset_binding[resources.Length];
        for (int index = 0; index < resources.Length; ++index)
        {
          srcportsetBindingArray[index] = new netprofile_srcportset_binding();
          srcportsetBindingArray[index].name = resources[index].name;
          srcportsetBindingArray[index].srcportrange = resources[index].srcportrange;
        }
        baseResponses = base_resource.delete_bulk_request(client, (base_resource[]) srcportsetBindingArray);
      }
      return baseResponses;
    }

    public static netprofile_srcportset_binding[] get(
      nitro_service service,
      string name)
    {
      return (netprofile_srcportset_binding[]) new netprofile_srcportset_binding()
      {
        name = name
      }.get_resources(service, (options) null);
    }

    public static netprofile_srcportset_binding[] get_filtered(
      nitro_service service,
      string name,
      string filter)
    {
      netprofile_srcportset_binding srcportsetBinding = new netprofile_srcportset_binding();
      srcportsetBinding.name = name;
      options option = new options();
      option.set_filter(filter);
      return (netprofile_srcportset_binding[]) srcportsetBinding.getfiltered(service, option);
    }

    public static netprofile_srcportset_binding[] get_filtered(
      nitro_service service,
      string name,
      filtervalue[] filter)
    {
      netprofile_srcportset_binding srcportsetBinding = new netprofile_srcportset_binding();
      srcportsetBinding.name = name;
      options option = new options();
      option.set_filter(filter);
      return (netprofile_srcportset_binding[]) srcportsetBinding.getfiltered(service, option);
    }

    public static uint count(nitro_service service, string name)
    {
      netprofile_srcportset_binding srcportsetBinding = new netprofile_srcportset_binding();
      srcportsetBinding.name = name;
      options option = new options();
      option.set_count(true);
      netprofile_srcportset_binding[] resources = (netprofile_srcportset_binding[]) srcportsetBinding.get_resources(service, option);
      return resources != null && resources.Length > 0 ? resources[0].__count.Value : 0U;
    }

    public static uint count_filtered(nitro_service service, string name, string filter)
    {
      netprofile_srcportset_binding srcportsetBinding = new netprofile_srcportset_binding();
      srcportsetBinding.name = name;
      options option = new options();
      option.set_count(true);
      option.set_filter(filter);
      netprofile_srcportset_binding[] srcportsetBindingArray = (netprofile_srcportset_binding[]) srcportsetBinding.getfiltered(service, option);
      return srcportsetBindingArray != null && srcportsetBindingArray.Length > 0 ? srcportsetBindingArray[0].__count.Value : 0U;
    }

    public static uint count_filtered(nitro_service service, string name, filtervalue[] filter)
    {
      netprofile_srcportset_binding srcportsetBinding = new netprofile_srcportset_binding();
      srcportsetBinding.name = name;
      options option = new options();
      option.set_count(true);
      option.set_filter(filter);
      netprofile_srcportset_binding[] srcportsetBindingArray = (netprofile_srcportset_binding[]) srcportsetBinding.getfiltered(service, option);
      return srcportsetBindingArray != null && srcportsetBindingArray.Length > 0 ? srcportsetBindingArray[0].__count.Value : 0U;
    }

    private class netprofile_srcportset_binding_response : base_response
    {
      public netprofile_srcportset_binding[] netprofile_srcportset_binding = (netprofile_srcportset_binding[]) null;
    }
  }
}
