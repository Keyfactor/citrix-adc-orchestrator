// Decompiled with JetBrains decompiler
// Type: com.citrix.netscaler.nitro.resource.config.ha.hanode_routemonitor6_binding
// Assembly: nitro, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 6CF5DDEF-E052-4F9D-953F-6644F8378A66


using com.citrix.netscaler.nitro.exception;
using com.citrix.netscaler.nitro.resource.Base;
using com.citrix.netscaler.nitro.service;
using com.citrix.netscaler.nitro.util;

namespace com.citrix.netscaler.nitro.resource.config.ha
{
  public class hanode_routemonitor6_binding : base_resource
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
      hanode_routemonitor6_binding.hanode_routemonitor6_binding_response routemonitor6BindingResponse = new hanode_routemonitor6_binding.hanode_routemonitor6_binding_response();
      hanode_routemonitor6_binding.hanode_routemonitor6_binding_response resource = (hanode_routemonitor6_binding.hanode_routemonitor6_binding_response) service.get_payload_formatter().string_to_resource(routemonitor6BindingResponse.GetType(), response);
      if (resource.errorcode != 0)
      {
        if (resource.errorcode == 444)
          service.clear_session();
        if (resource.severity == null)
          throw new nitro_exception(resource.message, resource.errorcode);
        if (resource.severity.Equals("ERROR"))
          throw new nitro_exception(resource.message, resource.errorcode);
      }
      return (base_resource[]) resource.hanode_routemonitor6_binding;
    }

    internal override string get_object_name() => this.id.HasValue ? this.id.ToString() : (string) null;

    public static base_response add(
      nitro_service client,
      hanode_routemonitor6_binding resource)
    {
      return new hanode_routemonitor6_binding()
      {
        id = resource.id,
        routemonitor = resource.routemonitor,
        netmask = resource.netmask
      }.update_resource(client);
    }

    public static base_responses add(
      nitro_service client,
      hanode_routemonitor6_binding[] resources)
    {
      base_responses baseResponses = (base_responses) null;
      if (resources != null && resources.Length > 0)
      {
        hanode_routemonitor6_binding[] routemonitor6BindingArray = new hanode_routemonitor6_binding[resources.Length];
        for (int index = 0; index < resources.Length; ++index)
        {
          routemonitor6BindingArray[index] = new hanode_routemonitor6_binding();
          routemonitor6BindingArray[index].id = resources[index].id;
          routemonitor6BindingArray[index].routemonitor = resources[index].routemonitor;
          routemonitor6BindingArray[index].netmask = resources[index].netmask;
        }
        baseResponses = base_resource.update_bulk_request(client, (base_resource[]) routemonitor6BindingArray);
      }
      return baseResponses;
    }

    public static base_response delete(
      nitro_service client,
      hanode_routemonitor6_binding resource)
    {
      return new hanode_routemonitor6_binding()
      {
        id = resource.id,
        routemonitor = resource.routemonitor,
        netmask = resource.netmask
      }.delete_resource(client);
    }

    public static base_responses delete(
      nitro_service client,
      hanode_routemonitor6_binding[] resources)
    {
      base_responses baseResponses = (base_responses) null;
      if (resources != null && resources.Length > 0)
      {
        hanode_routemonitor6_binding[] routemonitor6BindingArray = new hanode_routemonitor6_binding[resources.Length];
        for (int index = 0; index < resources.Length; ++index)
        {
          routemonitor6BindingArray[index] = new hanode_routemonitor6_binding();
          routemonitor6BindingArray[index].id = resources[index].id;
          routemonitor6BindingArray[index].routemonitor = resources[index].routemonitor;
          routemonitor6BindingArray[index].netmask = resources[index].netmask;
        }
        baseResponses = base_resource.delete_bulk_request(client, (base_resource[]) routemonitor6BindingArray);
      }
      return baseResponses;
    }

    public static hanode_routemonitor6_binding[] get(
      nitro_service service,
      uint? id)
    {
      return (hanode_routemonitor6_binding[]) new hanode_routemonitor6_binding()
      {
        id = id
      }.get_resources(service, (options) null);
    }

    public static hanode_routemonitor6_binding[] get_filtered(
      nitro_service service,
      uint? id,
      string filter)
    {
      hanode_routemonitor6_binding routemonitor6Binding = new hanode_routemonitor6_binding();
      routemonitor6Binding.id = id;
      options option = new options();
      option.set_filter(filter);
      return (hanode_routemonitor6_binding[]) routemonitor6Binding.getfiltered(service, option);
    }

    public static hanode_routemonitor6_binding[] get_filtered(
      nitro_service service,
      uint? id,
      filtervalue[] filter)
    {
      hanode_routemonitor6_binding routemonitor6Binding = new hanode_routemonitor6_binding();
      routemonitor6Binding.id = id;
      options option = new options();
      option.set_filter(filter);
      return (hanode_routemonitor6_binding[]) routemonitor6Binding.getfiltered(service, option);
    }

    public static uint count(nitro_service service, uint? id)
    {
      hanode_routemonitor6_binding routemonitor6Binding = new hanode_routemonitor6_binding();
      routemonitor6Binding.id = id;
      options option = new options();
      option.set_count(true);
      hanode_routemonitor6_binding[] resources = (hanode_routemonitor6_binding[]) routemonitor6Binding.get_resources(service, option);
      return resources != null && resources.Length > 0 ? resources[0].__count.Value : 0U;
    }

    public static uint count_filtered(nitro_service service, uint? id, string filter)
    {
      hanode_routemonitor6_binding routemonitor6Binding = new hanode_routemonitor6_binding();
      routemonitor6Binding.id = id;
      options option = new options();
      option.set_count(true);
      option.set_filter(filter);
      hanode_routemonitor6_binding[] routemonitor6BindingArray = (hanode_routemonitor6_binding[]) routemonitor6Binding.getfiltered(service, option);
      return routemonitor6BindingArray != null && routemonitor6BindingArray.Length > 0 ? routemonitor6BindingArray[0].__count.Value : 0U;
    }

    public static uint count_filtered(nitro_service service, uint? id, filtervalue[] filter)
    {
      hanode_routemonitor6_binding routemonitor6Binding = new hanode_routemonitor6_binding();
      routemonitor6Binding.id = id;
      options option = new options();
      option.set_count(true);
      option.set_filter(filter);
      hanode_routemonitor6_binding[] routemonitor6BindingArray = (hanode_routemonitor6_binding[]) routemonitor6Binding.getfiltered(service, option);
      return routemonitor6BindingArray != null && routemonitor6BindingArray.Length > 0 ? routemonitor6BindingArray[0].__count.Value : 0U;
    }

    private class hanode_routemonitor6_binding_response : base_response
    {
      public hanode_routemonitor6_binding[] hanode_routemonitor6_binding = (hanode_routemonitor6_binding[]) null;
    }

    public static class routemonitorstateEnum
    {
      public const string UP = "UP";
      public const string DOWN = "DOWN";
    }
  }
}
