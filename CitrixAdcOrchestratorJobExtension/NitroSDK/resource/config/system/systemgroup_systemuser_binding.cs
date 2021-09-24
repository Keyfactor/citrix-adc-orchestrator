// Decompiled with JetBrains decompiler
// Type: com.citrix.netscaler.nitro.resource.config.system.systemgroup_systemuser_binding
// Assembly: nitro, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 6CF5DDEF-E052-4F9D-953F-6644F8378A66


using com.citrix.netscaler.nitro.exception;
using com.citrix.netscaler.nitro.resource.Base;
using com.citrix.netscaler.nitro.service;
using com.citrix.netscaler.nitro.util;

namespace com.citrix.netscaler.nitro.resource.config.system
{
  public class systemgroup_systemuser_binding : base_resource
  {
    private string usernameField = (string) null;
    private string groupnameField = (string) null;
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

    public string groupname
    {
      get => this.groupnameField;
      set => this.groupnameField = value;
    }

    internal override base_resource[] get_nitro_response(
      nitro_service service,
      string response)
    {
      systemgroup_systemuser_binding.systemgroup_systemuser_binding_response systemuserBindingResponse = new systemgroup_systemuser_binding.systemgroup_systemuser_binding_response();
      systemgroup_systemuser_binding.systemgroup_systemuser_binding_response resource = (systemgroup_systemuser_binding.systemgroup_systemuser_binding_response) service.get_payload_formatter().string_to_resource(systemuserBindingResponse.GetType(), response);
      if (resource.errorcode != 0)
      {
        if (resource.errorcode == 444)
          service.clear_session();
        if (resource.severity == null)
          throw new nitro_exception(resource.message, resource.errorcode);
        if (resource.severity.Equals("ERROR"))
          throw new nitro_exception(resource.message, resource.errorcode);
      }
      return (base_resource[]) resource.systemgroup_systemuser_binding;
    }

    internal override string get_object_name() => this.groupname;

    public static base_response add(
      nitro_service client,
      systemgroup_systemuser_binding resource)
    {
      return new systemgroup_systemuser_binding()
      {
        groupname = resource.groupname,
        username = resource.username
      }.update_resource(client);
    }

    public static base_responses add(
      nitro_service client,
      systemgroup_systemuser_binding[] resources)
    {
      base_responses baseResponses = (base_responses) null;
      if (resources != null && resources.Length > 0)
      {
        systemgroup_systemuser_binding[] systemuserBindingArray = new systemgroup_systemuser_binding[resources.Length];
        for (int index = 0; index < resources.Length; ++index)
        {
          systemuserBindingArray[index] = new systemgroup_systemuser_binding();
          systemuserBindingArray[index].groupname = resources[index].groupname;
          systemuserBindingArray[index].username = resources[index].username;
        }
        baseResponses = base_resource.update_bulk_request(client, (base_resource[]) systemuserBindingArray);
      }
      return baseResponses;
    }

    public static base_response delete(
      nitro_service client,
      systemgroup_systemuser_binding resource)
    {
      return new systemgroup_systemuser_binding()
      {
        groupname = resource.groupname,
        username = resource.username
      }.delete_resource(client);
    }

    public static base_responses delete(
      nitro_service client,
      systemgroup_systemuser_binding[] resources)
    {
      base_responses baseResponses = (base_responses) null;
      if (resources != null && resources.Length > 0)
      {
        systemgroup_systemuser_binding[] systemuserBindingArray = new systemgroup_systemuser_binding[resources.Length];
        for (int index = 0; index < resources.Length; ++index)
        {
          systemuserBindingArray[index] = new systemgroup_systemuser_binding();
          systemuserBindingArray[index].groupname = resources[index].groupname;
          systemuserBindingArray[index].username = resources[index].username;
        }
        baseResponses = base_resource.delete_bulk_request(client, (base_resource[]) systemuserBindingArray);
      }
      return baseResponses;
    }

    public static systemgroup_systemuser_binding[] get(
      nitro_service service,
      string groupname)
    {
      return (systemgroup_systemuser_binding[]) new systemgroup_systemuser_binding()
      {
        groupname = groupname
      }.get_resources(service, (options) null);
    }

    public static systemgroup_systemuser_binding[] get_filtered(
      nitro_service service,
      string groupname,
      string filter)
    {
      systemgroup_systemuser_binding systemuserBinding = new systemgroup_systemuser_binding();
      systemuserBinding.groupname = groupname;
      options option = new options();
      option.set_filter(filter);
      return (systemgroup_systemuser_binding[]) systemuserBinding.getfiltered(service, option);
    }

    public static systemgroup_systemuser_binding[] get_filtered(
      nitro_service service,
      string groupname,
      filtervalue[] filter)
    {
      systemgroup_systemuser_binding systemuserBinding = new systemgroup_systemuser_binding();
      systemuserBinding.groupname = groupname;
      options option = new options();
      option.set_filter(filter);
      return (systemgroup_systemuser_binding[]) systemuserBinding.getfiltered(service, option);
    }

    public static uint count(nitro_service service, string groupname)
    {
      systemgroup_systemuser_binding systemuserBinding = new systemgroup_systemuser_binding();
      systemuserBinding.groupname = groupname;
      options option = new options();
      option.set_count(true);
      systemgroup_systemuser_binding[] resources = (systemgroup_systemuser_binding[]) systemuserBinding.get_resources(service, option);
      return resources != null && resources.Length > 0 ? resources[0].__count.Value : 0U;
    }

    public static uint count_filtered(nitro_service service, string groupname, string filter)
    {
      systemgroup_systemuser_binding systemuserBinding = new systemgroup_systemuser_binding();
      systemuserBinding.groupname = groupname;
      options option = new options();
      option.set_count(true);
      option.set_filter(filter);
      systemgroup_systemuser_binding[] systemuserBindingArray = (systemgroup_systemuser_binding[]) systemuserBinding.getfiltered(service, option);
      return systemuserBindingArray != null && systemuserBindingArray.Length > 0 ? systemuserBindingArray[0].__count.Value : 0U;
    }

    public static uint count_filtered(
      nitro_service service,
      string groupname,
      filtervalue[] filter)
    {
      systemgroup_systemuser_binding systemuserBinding = new systemgroup_systemuser_binding();
      systemuserBinding.groupname = groupname;
      options option = new options();
      option.set_count(true);
      option.set_filter(filter);
      systemgroup_systemuser_binding[] systemuserBindingArray = (systemgroup_systemuser_binding[]) systemuserBinding.getfiltered(service, option);
      return systemuserBindingArray != null && systemuserBindingArray.Length > 0 ? systemuserBindingArray[0].__count.Value : 0U;
    }

    private class systemgroup_systemuser_binding_response : base_response
    {
      public systemgroup_systemuser_binding[] systemgroup_systemuser_binding = (systemgroup_systemuser_binding[]) null;
    }
  }
}
