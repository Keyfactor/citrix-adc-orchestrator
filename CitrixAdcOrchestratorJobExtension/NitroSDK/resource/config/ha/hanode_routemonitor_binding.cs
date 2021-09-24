// Decompiled with JetBrains decompiler
// Type: com.citrix.netscaler.nitro.resource.config.ha.hanode_routemonitor_binding
// Assembly: nitro, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 6CF5DDEF-E052-4F9D-953F-6644F8378A66


using com.citrix.netscaler.nitro.exception;
using com.citrix.netscaler.nitro.resource.Base;
using com.citrix.netscaler.nitro.service;
using com.citrix.netscaler.nitro.util;

namespace com.citrix.netscaler.nitro.resource.config.ha
{
  public class hanode_routemonitor_binding : base_resource
  {
    private string routemonitorField = (string) null;
    private string netmaskField = (string) null;
    private uint? flagsField = new uint?();
    private string routemonitorstateField = (string) null;
    private uint? idField = new uint?();
    private uint? __countField = new uint?();

    public uint? __count
    {
      get => this.__countField;
      set => this.__countField = value;
    }

    public string routemonitor
    {
      get => this.routemonitorField;
      set => this.routemonitorField = value;
    }

    public uint? id
    {
      get => this.idField;
      set => this.idField = value;
    }

    public string netmask
    {
      get => this.netmaskField;
      set => this.netmaskField = value;
    }

    public string routemonitorstate
    {
      get => this.routemonitorstateField;
      private set => this.routemonitorstateField = value;
    }

    public uint? flags
    {
      get => this.flagsField;
      private set => this.flagsField = value;
    }

    internal override base_resource[] get_nitro_response(
      nitro_service service,
      string response)
    {
      hanode_routemonitor_binding.hanode_routemonitor_binding_response routemonitorBindingResponse = new hanode_routemonitor_binding.hanode_routemonitor_binding_response();
      hanode_routemonitor_binding.hanode_routemonitor_binding_response resource = (hanode_routemonitor_binding.hanode_routemonitor_binding_response) service.get_payload_formatter().string_to_resource(routemonitorBindingResponse.GetType(), response);
      if (resource.errorcode != 0)
      {
        if (resource.errorcode == 444)
          service.clear_session();
        if (resource.severity == null)
          throw new nitro_exception(resource.message, resource.errorcode);
        if (resource.severity.Equals("ERROR"))
          throw new nitro_exception(resource.message, resource.errorcode);
      }
      return (base_resource[]) resource.hanode_routemonitor_binding;
    }

    internal override string get_object_name() => this.id.HasValue ? this.id.ToString() : (string) null;

    public static base_response add(
      nitro_service client,
      hanode_routemonitor_binding resource)
    {
      return new hanode_routemonitor_binding()
      {
        id = resource.id,
        routemonitor = resource.routemonitor,
        netmask = resource.netmask
      }.update_resource(client);
    }

    public static base_responses add(
      nitro_service client,
      hanode_routemonitor_binding[] resources)
    {
      base_responses baseResponses = (base_responses) null;
      if (resources != null && resources.Length > 0)
      {
        hanode_routemonitor_binding[] routemonitorBindingArray = new hanode_routemonitor_binding[resources.Length];
        for (int index = 0; index < resources.Length; ++index)
        {
          routemonitorBindingArray[index] = new hanode_routemonitor_binding();
          routemonitorBindingArray[index].id = resources[index].id;
          routemonitorBindingArray[index].routemonitor = resources[index].routemonitor;
          routemonitorBindingArray[index].netmask = resources[index].netmask;
        }
        baseResponses = base_resource.update_bulk_request(client, (base_resource[]) routemonitorBindingArray);
      }
      return baseResponses;
    }

    public static base_response delete(
      nitro_service client,
      hanode_routemonitor_binding resource)
    {
      return new hanode_routemonitor_binding()
      {
        id = resource.id,
        routemonitor = resource.routemonitor,
        netmask = resource.netmask
      }.delete_resource(client);
    }

    public static base_responses delete(
      nitro_service client,
      hanode_routemonitor_binding[] resources)
    {
      base_responses baseResponses = (base_responses) null;
      if (resources != null && resources.Length > 0)
      {
        hanode_routemonitor_binding[] routemonitorBindingArray = new hanode_routemonitor_binding[resources.Length];
        for (int index = 0; index < resources.Length; ++index)
        {
          routemonitorBindingArray[index] = new hanode_routemonitor_binding();
          routemonitorBindingArray[index].id = resources[index].id;
          routemonitorBindingArray[index].routemonitor = resources[index].routemonitor;
          routemonitorBindingArray[index].netmask = resources[index].netmask;
        }
        baseResponses = base_resource.delete_bulk_request(client, (base_resource[]) routemonitorBindingArray);
      }
      return baseResponses;
    }

    public static hanode_routemonitor_binding[] get(
      nitro_service service,
      uint? id)
    {
      return (hanode_routemonitor_binding[]) new hanode_routemonitor_binding()
      {
        id = id
      }.get_resources(service, (options) null);
    }

    public static hanode_routemonitor_binding[] get_filtered(
      nitro_service service,
      uint? id,
      string filter)
    {
      hanode_routemonitor_binding routemonitorBinding = new hanode_routemonitor_binding();
      routemonitorBinding.id = id;
      options option = new options();
      option.set_filter(filter);
      return (hanode_routemonitor_binding[]) routemonitorBinding.getfiltered(service, option);
    }

    public static hanode_routemonitor_binding[] get_filtered(
      nitro_service service,
      uint? id,
      filtervalue[] filter)
    {
      hanode_routemonitor_binding routemonitorBinding = new hanode_routemonitor_binding();
      routemonitorBinding.id = id;
      options option = new options();
      option.set_filter(filter);
      return (hanode_routemonitor_binding[]) routemonitorBinding.getfiltered(service, option);
    }

    public static uint count(nitro_service service, uint? id)
    {
      hanode_routemonitor_binding routemonitorBinding = new hanode_routemonitor_binding();
      routemonitorBinding.id = id;
      options option = new options();
      option.set_count(true);
      hanode_routemonitor_binding[] resources = (hanode_routemonitor_binding[]) routemonitorBinding.get_resources(service, option);
      return resources != null && resources.Length > 0 ? resources[0].__count.Value : 0U;
    }

    public static uint count_filtered(nitro_service service, uint? id, string filter)
    {
      hanode_routemonitor_binding routemonitorBinding = new hanode_routemonitor_binding();
      routemonitorBinding.id = id;
      options option = new options();
      option.set_count(true);
      option.set_filter(filter);
      hanode_routemonitor_binding[] routemonitorBindingArray = (hanode_routemonitor_binding[]) routemonitorBinding.getfiltered(service, option);
      return routemonitorBindingArray != null && routemonitorBindingArray.Length > 0 ? routemonitorBindingArray[0].__count.Value : 0U;
    }

    public static uint count_filtered(nitro_service service, uint? id, filtervalue[] filter)
    {
      hanode_routemonitor_binding routemonitorBinding = new hanode_routemonitor_binding();
      routemonitorBinding.id = id;
      options option = new options();
      option.set_count(true);
      option.set_filter(filter);
      hanode_routemonitor_binding[] routemonitorBindingArray = (hanode_routemonitor_binding[]) routemonitorBinding.getfiltered(service, option);
      return routemonitorBindingArray != null && routemonitorBindingArray.Length > 0 ? routemonitorBindingArray[0].__count.Value : 0U;
    }

    private class hanode_routemonitor_binding_response : base_response
    {
      public hanode_routemonitor_binding[] hanode_routemonitor_binding = (hanode_routemonitor_binding[]) null;
    }

    public static class routemonitorstateEnum
    {
      public const string UP = "UP";
      public const string DOWN = "DOWN";
    }
  }
}
