// Decompiled with JetBrains decompiler
// Type: com.citrix.netscaler.nitro.resource.config.network.fis_channel_binding
// Assembly: nitro, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 6CF5DDEF-E052-4F9D-953F-6644F8378A66


using com.citrix.netscaler.nitro.exception;
using com.citrix.netscaler.nitro.resource.Base;
using com.citrix.netscaler.nitro.service;
using com.citrix.netscaler.nitro.util;

namespace com.citrix.netscaler.nitro.resource.config.network
{
  public class fis_channel_binding : base_resource
  {
    private string ifnumField = (string) null;
    private uint? ownernodeField = new uint?();
    private string nameField = (string) null;
    private uint? __countField = new uint?();

    public uint? __count
    {
      get => this.__countField;
      set => this.__countField = value;
    }

    public uint? ownernode
    {
      get => this.ownernodeField;
      set => this.ownernodeField = value;
    }

    public string name
    {
      get => this.nameField;
      set => this.nameField = value;
    }

    public string ifnum
    {
      get => this.ifnumField;
      set => this.ifnumField = value;
    }

    internal override base_resource[] get_nitro_response(
      nitro_service service,
      string response)
    {
      fis_channel_binding.fis_channel_binding_response channelBindingResponse = new fis_channel_binding.fis_channel_binding_response();
      fis_channel_binding.fis_channel_binding_response resource = (fis_channel_binding.fis_channel_binding_response) service.get_payload_formatter().string_to_resource(channelBindingResponse.GetType(), response);
      if (resource.errorcode != 0)
      {
        if (resource.errorcode == 444)
          service.clear_session();
        if (resource.severity == null)
          throw new nitro_exception(resource.message, resource.errorcode);
        if (resource.severity.Equals("ERROR"))
          throw new nitro_exception(resource.message, resource.errorcode);
      }
      return (base_resource[]) resource.fis_channel_binding;
    }

    internal override string get_object_name() => this.name;

    public static base_response add(nitro_service client, fis_channel_binding resource) => new fis_channel_binding()
    {
      name = resource.name,
      ifnum = resource.ifnum
    }.update_resource(client);

    public static base_responses add(
      nitro_service client,
      fis_channel_binding[] resources)
    {
      base_responses baseResponses = (base_responses) null;
      if (resources != null && resources.Length > 0)
      {
        fis_channel_binding[] fisChannelBindingArray = new fis_channel_binding[resources.Length];
        for (int index = 0; index < resources.Length; ++index)
        {
          fisChannelBindingArray[index] = new fis_channel_binding();
          fisChannelBindingArray[index].name = resources[index].name;
          fisChannelBindingArray[index].ifnum = resources[index].ifnum;
        }
        baseResponses = base_resource.update_bulk_request(client, (base_resource[]) fisChannelBindingArray);
      }
      return baseResponses;
    }

    public static base_response delete(
      nitro_service client,
      fis_channel_binding resource)
    {
      return new fis_channel_binding()
      {
        name = resource.name,
        ifnum = resource.ifnum
      }.delete_resource(client);
    }

    public static base_responses delete(
      nitro_service client,
      fis_channel_binding[] resources)
    {
      base_responses baseResponses = (base_responses) null;
      if (resources != null && resources.Length > 0)
      {
        fis_channel_binding[] fisChannelBindingArray = new fis_channel_binding[resources.Length];
        for (int index = 0; index < resources.Length; ++index)
        {
          fisChannelBindingArray[index] = new fis_channel_binding();
          fisChannelBindingArray[index].name = resources[index].name;
          fisChannelBindingArray[index].ifnum = resources[index].ifnum;
        }
        baseResponses = base_resource.delete_bulk_request(client, (base_resource[]) fisChannelBindingArray);
      }
      return baseResponses;
    }

    public static fis_channel_binding[] get(nitro_service service, string name) => (fis_channel_binding[]) new fis_channel_binding()
    {
      name = name
    }.get_resources(service, (options) null);

    public static fis_channel_binding[] get_filtered(
      nitro_service service,
      string name,
      string filter)
    {
      fis_channel_binding fisChannelBinding = new fis_channel_binding();
      fisChannelBinding.name = name;
      options option = new options();
      option.set_filter(filter);
      return (fis_channel_binding[]) fisChannelBinding.getfiltered(service, option);
    }

    public static fis_channel_binding[] get_filtered(
      nitro_service service,
      string name,
      filtervalue[] filter)
    {
      fis_channel_binding fisChannelBinding = new fis_channel_binding();
      fisChannelBinding.name = name;
      options option = new options();
      option.set_filter(filter);
      return (fis_channel_binding[]) fisChannelBinding.getfiltered(service, option);
    }

    public static uint count(nitro_service service, string name)
    {
      fis_channel_binding fisChannelBinding = new fis_channel_binding();
      fisChannelBinding.name = name;
      options option = new options();
      option.set_count(true);
      fis_channel_binding[] resources = (fis_channel_binding[]) fisChannelBinding.get_resources(service, option);
      return resources != null && resources.Length > 0 ? resources[0].__count.Value : 0U;
    }

    public static uint count_filtered(nitro_service service, string name, string filter)
    {
      fis_channel_binding fisChannelBinding = new fis_channel_binding();
      fisChannelBinding.name = name;
      options option = new options();
      option.set_count(true);
      option.set_filter(filter);
      fis_channel_binding[] fisChannelBindingArray = (fis_channel_binding[]) fisChannelBinding.getfiltered(service, option);
      return fisChannelBindingArray != null && fisChannelBindingArray.Length > 0 ? fisChannelBindingArray[0].__count.Value : 0U;
    }

    public static uint count_filtered(nitro_service service, string name, filtervalue[] filter)
    {
      fis_channel_binding fisChannelBinding = new fis_channel_binding();
      fisChannelBinding.name = name;
      options option = new options();
      option.set_count(true);
      option.set_filter(filter);
      fis_channel_binding[] fisChannelBindingArray = (fis_channel_binding[]) fisChannelBinding.getfiltered(service, option);
      return fisChannelBindingArray != null && fisChannelBindingArray.Length > 0 ? fisChannelBindingArray[0].__count.Value : 0U;
    }

    private class fis_channel_binding_response : base_response
    {
      public fis_channel_binding[] fis_channel_binding = (fis_channel_binding[]) null;
    }
  }
}
