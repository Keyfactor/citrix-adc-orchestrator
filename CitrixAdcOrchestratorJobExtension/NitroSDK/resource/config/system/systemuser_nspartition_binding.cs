// Decompiled with JetBrains decompiler
// Type: com.citrix.netscaler.nitro.resource.config.system.systemuser_nspartition_binding
// Assembly: nitro, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 6CF5DDEF-E052-4F9D-953F-6644F8378A66


using com.citrix.netscaler.nitro.exception;
using com.citrix.netscaler.nitro.resource.Base;
using com.citrix.netscaler.nitro.service;
using com.citrix.netscaler.nitro.util;

namespace com.citrix.netscaler.nitro.resource.config.system
{
  public class systemuser_nspartition_binding : base_resource
  {
    private string partitionnameField = (string) null;
    private string usernameField = (string) null;
    private uint? __countField = new uint?();

    public uint? __count
    {
      get => this.__countField;
      set => this.__countField = value;
    }

    public string username
    {
      get => this.usernameField;
      set => this.usernameField = value;
    }

    public string partitionname
    {
      get => this.partitionnameField;
      set => this.partitionnameField = value;
    }

    internal override base_resource[] get_nitro_response(
      nitro_service service,
      string response)
    {
      systemuser_nspartition_binding.systemuser_nspartition_binding_response nspartitionBindingResponse = new systemuser_nspartition_binding.systemuser_nspartition_binding_response();
      systemuser_nspartition_binding.systemuser_nspartition_binding_response resource = (systemuser_nspartition_binding.systemuser_nspartition_binding_response) service.get_payload_formatter().string_to_resource(nspartitionBindingResponse.GetType(), response);
      if (resource.errorcode != 0)
      {
        if (resource.errorcode == 444)
          service.clear_session();
        if (resource.severity == null)
          throw new nitro_exception(resource.message, resource.errorcode);
        if (resource.severity.Equals("ERROR"))
          throw new nitro_exception(resource.message, resource.errorcode);
      }
      return (base_resource[]) resource.systemuser_nspartition_binding;
    }

    internal override string get_object_name() => this.username;

    public static base_response add(
      nitro_service client,
      systemuser_nspartition_binding resource)
    {
      return new systemuser_nspartition_binding()
      {
        username = resource.username,
        partitionname = resource.partitionname
      }.update_resource(client);
    }

    public static base_responses add(
      nitro_service client,
      systemuser_nspartition_binding[] resources)
    {
      base_responses baseResponses = (base_responses) null;
      if (resources != null && resources.Length > 0)
      {
        systemuser_nspartition_binding[] nspartitionBindingArray = new systemuser_nspartition_binding[resources.Length];
        for (int index = 0; index < resources.Length; ++index)
        {
          nspartitionBindingArray[index] = new systemuser_nspartition_binding();
          nspartitionBindingArray[index].username = resources[index].username;
          nspartitionBindingArray[index].partitionname = resources[index].partitionname;
        }
        baseResponses = base_resource.update_bulk_request(client, (base_resource[]) nspartitionBindingArray);
      }
      return baseResponses;
    }

    public static base_response delete(
      nitro_service client,
      systemuser_nspartition_binding resource)
    {
      return new systemuser_nspartition_binding()
      {
        username = resource.username,
        partitionname = resource.partitionname
      }.delete_resource(client);
    }

    public static base_responses delete(
      nitro_service client,
      systemuser_nspartition_binding[] resources)
    {
      base_responses baseResponses = (base_responses) null;
      if (resources != null && resources.Length > 0)
      {
        systemuser_nspartition_binding[] nspartitionBindingArray = new systemuser_nspartition_binding[resources.Length];
        for (int index = 0; index < resources.Length; ++index)
        {
          nspartitionBindingArray[index] = new systemuser_nspartition_binding();
          nspartitionBindingArray[index].username = resources[index].username;
          nspartitionBindingArray[index].partitionname = resources[index].partitionname;
        }
        baseResponses = base_resource.delete_bulk_request(client, (base_resource[]) nspartitionBindingArray);
      }
      return baseResponses;
    }

    public static systemuser_nspartition_binding[] get(
      nitro_service service,
      string username)
    {
      return (systemuser_nspartition_binding[]) new systemuser_nspartition_binding()
      {
        username = username
      }.get_resources(service, (options) null);
    }

    public static systemuser_nspartition_binding[] get_filtered(
      nitro_service service,
      string username,
      string filter)
    {
      systemuser_nspartition_binding nspartitionBinding = new systemuser_nspartition_binding();
      nspartitionBinding.username = username;
      options option = new options();
      option.set_filter(filter);
      return (systemuser_nspartition_binding[]) nspartitionBinding.getfiltered(service, option);
    }

    public static systemuser_nspartition_binding[] get_filtered(
      nitro_service service,
      string username,
      filtervalue[] filter)
    {
      systemuser_nspartition_binding nspartitionBinding = new systemuser_nspartition_binding();
      nspartitionBinding.username = username;
      options option = new options();
      option.set_filter(filter);
      return (systemuser_nspartition_binding[]) nspartitionBinding.getfiltered(service, option);
    }

    public static uint count(nitro_service service, string username)
    {
      systemuser_nspartition_binding nspartitionBinding = new systemuser_nspartition_binding();
      nspartitionBinding.username = username;
      options option = new options();
      option.set_count(true);
      systemuser_nspartition_binding[] resources = (systemuser_nspartition_binding[]) nspartitionBinding.get_resources(service, option);
      return resources != null && resources.Length > 0 ? resources[0].__count.Value : 0U;
    }

    public static uint count_filtered(nitro_service service, string username, string filter)
    {
      systemuser_nspartition_binding nspartitionBinding = new systemuser_nspartition_binding();
      nspartitionBinding.username = username;
      options option = new options();
      option.set_count(true);
      option.set_filter(filter);
      systemuser_nspartition_binding[] nspartitionBindingArray = (systemuser_nspartition_binding[]) nspartitionBinding.getfiltered(service, option);
      return nspartitionBindingArray != null && nspartitionBindingArray.Length > 0 ? nspartitionBindingArray[0].__count.Value : 0U;
    }

    public static uint count_filtered(nitro_service service, string username, filtervalue[] filter)
    {
      systemuser_nspartition_binding nspartitionBinding = new systemuser_nspartition_binding();
      nspartitionBinding.username = username;
      options option = new options();
      option.set_count(true);
      option.set_filter(filter);
      systemuser_nspartition_binding[] nspartitionBindingArray = (systemuser_nspartition_binding[]) nspartitionBinding.getfiltered(service, option);
      return nspartitionBindingArray != null && nspartitionBindingArray.Length > 0 ? nspartitionBindingArray[0].__count.Value : 0U;
    }

    private class systemuser_nspartition_binding_response : base_response
    {
      public systemuser_nspartition_binding[] systemuser_nspartition_binding = (systemuser_nspartition_binding[]) null;
    }
  }
}
