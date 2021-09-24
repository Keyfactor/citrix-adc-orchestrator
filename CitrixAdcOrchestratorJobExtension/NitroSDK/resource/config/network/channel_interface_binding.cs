// Decompiled with JetBrains decompiler
// Type: com.citrix.netscaler.nitro.resource.config.network.channel_interface_binding
// Assembly: nitro, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 6CF5DDEF-E052-4F9D-953F-6644F8378A66


using com.citrix.netscaler.nitro.exception;
using com.citrix.netscaler.nitro.resource.Base;
using com.citrix.netscaler.nitro.service;
using com.citrix.netscaler.nitro.util;

namespace com.citrix.netscaler.nitro.resource.config.network
{
  public class channel_interface_binding : base_resource
  {
    private string[] ifnumField = (string[]) null;
    private string lamodeField = (string) null;
    private uint? slavestateField = new uint?();
    private uint? slavemediaField = new uint?();
    private uint? slavespeedField = new uint?();
    private uint? slaveduplexField = new uint?();
    private uint? slaveflowctlField = new uint?();
    private uint? slavetimeField = new uint?();
    private bool? lractiveintfField = new bool?();
    private string idField = (string) null;
    private uint? __countField = new uint?();

    public uint? __count
    {
      get => this.__countField;
      set => this.__countField = value;
    }

    public string id
    {
      get => this.idField;
      set => this.idField = value;
    }

    public string[] ifnum
    {
      get => this.ifnumField;
      set => this.ifnumField = value;
    }

    public string lamode
    {
      get => this.lamodeField;
      private set => this.lamodeField = value;
    }

    public uint? slaveduplex
    {
      get => this.slaveduplexField;
      private set => this.slaveduplexField = value;
    }

    public uint? slaveflowctl
    {
      get => this.slaveflowctlField;
      private set => this.slaveflowctlField = value;
    }

    public uint? slavetime
    {
      get => this.slavetimeField;
      private set => this.slavetimeField = value;
    }

    public uint? slavestate
    {
      get => this.slavestateField;
      private set => this.slavestateField = value;
    }

    public uint? slavespeed
    {
      get => this.slavespeedField;
      private set => this.slavespeedField = value;
    }

    public uint? slavemedia
    {
      get => this.slavemediaField;
      private set => this.slavemediaField = value;
    }

    public bool? lractiveintf
    {
      get => this.lractiveintfField;
      private set => this.lractiveintfField = value;
    }

    internal override base_resource[] get_nitro_response(
      nitro_service service,
      string response)
    {
      channel_interface_binding.channel_interface_binding_response interfaceBindingResponse = new channel_interface_binding.channel_interface_binding_response();
      channel_interface_binding.channel_interface_binding_response resource = (channel_interface_binding.channel_interface_binding_response) service.get_payload_formatter().string_to_resource(interfaceBindingResponse.GetType(), response);
      if (resource.errorcode != 0)
      {
        if (resource.errorcode == 444)
          service.clear_session();
        if (resource.severity == null)
          throw new nitro_exception(resource.message, resource.errorcode);
        if (resource.severity.Equals("ERROR"))
          throw new nitro_exception(resource.message, resource.errorcode);
      }
      return (base_resource[]) resource.channel_interface_binding;
    }

    internal override string get_object_name() => this.id;

    public static base_response add(
      nitro_service client,
      channel_interface_binding resource)
    {
      return new channel_interface_binding()
      {
        id = resource.id,
        ifnum = resource.ifnum
      }.update_resource(client);
    }

    public static base_responses add(
      nitro_service client,
      channel_interface_binding[] resources)
    {
      base_responses baseResponses = (base_responses) null;
      if (resources != null && resources.Length > 0)
      {
        channel_interface_binding[] interfaceBindingArray = new channel_interface_binding[resources.Length];
        for (int index = 0; index < resources.Length; ++index)
        {
          interfaceBindingArray[index] = new channel_interface_binding();
          interfaceBindingArray[index].id = resources[index].id;
          interfaceBindingArray[index].ifnum = resources[index].ifnum;
        }
        baseResponses = base_resource.update_bulk_request(client, (base_resource[]) interfaceBindingArray);
      }
      return baseResponses;
    }

    public static base_response delete(
      nitro_service client,
      channel_interface_binding resource)
    {
      return new channel_interface_binding()
      {
        id = resource.id,
        ifnum = resource.ifnum
      }.delete_resource(client);
    }

    public static base_responses delete(
      nitro_service client,
      channel_interface_binding[] resources)
    {
      base_responses baseResponses = (base_responses) null;
      if (resources != null && resources.Length > 0)
      {
        channel_interface_binding[] interfaceBindingArray = new channel_interface_binding[resources.Length];
        for (int index = 0; index < resources.Length; ++index)
        {
          interfaceBindingArray[index] = new channel_interface_binding();
          interfaceBindingArray[index].id = resources[index].id;
          interfaceBindingArray[index].ifnum = resources[index].ifnum;
        }
        baseResponses = base_resource.delete_bulk_request(client, (base_resource[]) interfaceBindingArray);
      }
      return baseResponses;
    }

    public static channel_interface_binding[] get(
      nitro_service service,
      string id)
    {
      return (channel_interface_binding[]) new channel_interface_binding()
      {
        id = id
      }.get_resources(service, (options) null);
    }

    public static channel_interface_binding[] get_filtered(
      nitro_service service,
      string id,
      string filter)
    {
      channel_interface_binding interfaceBinding = new channel_interface_binding();
      interfaceBinding.id = id;
      options option = new options();
      option.set_filter(filter);
      return (channel_interface_binding[]) interfaceBinding.getfiltered(service, option);
    }

    public static channel_interface_binding[] get_filtered(
      nitro_service service,
      string id,
      filtervalue[] filter)
    {
      channel_interface_binding interfaceBinding = new channel_interface_binding();
      interfaceBinding.id = id;
      options option = new options();
      option.set_filter(filter);
      return (channel_interface_binding[]) interfaceBinding.getfiltered(service, option);
    }

    public static uint count(nitro_service service, string id)
    {
      channel_interface_binding interfaceBinding = new channel_interface_binding();
      interfaceBinding.id = id;
      options option = new options();
      option.set_count(true);
      channel_interface_binding[] resources = (channel_interface_binding[]) interfaceBinding.get_resources(service, option);
      return resources != null && resources.Length > 0 ? resources[0].__count.Value : 0U;
    }

    public static uint count_filtered(nitro_service service, string id, string filter)
    {
      channel_interface_binding interfaceBinding = new channel_interface_binding();
      interfaceBinding.id = id;
      options option = new options();
      option.set_count(true);
      option.set_filter(filter);
      channel_interface_binding[] interfaceBindingArray = (channel_interface_binding[]) interfaceBinding.getfiltered(service, option);
      return interfaceBindingArray != null && interfaceBindingArray.Length > 0 ? interfaceBindingArray[0].__count.Value : 0U;
    }

    public static uint count_filtered(nitro_service service, string id, filtervalue[] filter)
    {
      channel_interface_binding interfaceBinding = new channel_interface_binding();
      interfaceBinding.id = id;
      options option = new options();
      option.set_count(true);
      option.set_filter(filter);
      channel_interface_binding[] interfaceBindingArray = (channel_interface_binding[]) interfaceBinding.getfiltered(service, option);
      return interfaceBindingArray != null && interfaceBindingArray.Length > 0 ? interfaceBindingArray[0].__count.Value : 0U;
    }

    private class channel_interface_binding_response : base_response
    {
      public channel_interface_binding[] channel_interface_binding = (channel_interface_binding[]) null;
    }

    public static class lamodeEnum
    {
      public const string MANUAL = "MANUAL";
      public const string AUTO = "AUTO";
    }
  }
}
