// Decompiled with JetBrains decompiler
// Type: com.citrix.netscaler.nitro.resource.config.system.systemuser_systemgroup_binding
// Assembly: nitro, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 6CF5DDEF-E052-4F9D-953F-6644F8378A66


using com.citrix.netscaler.nitro.exception;
using com.citrix.netscaler.nitro.resource.Base;
using com.citrix.netscaler.nitro.service;
using com.citrix.netscaler.nitro.util;

namespace com.citrix.netscaler.nitro.resource.config.system
{
  public class systemuser_systemgroup_binding : base_resource
  {
    private string groupnameField = (string) null;
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

    public string groupname
    {
      get => this.groupnameField;
      set => this.groupnameField = value;
    }

    internal override base_resource[] get_nitro_response(
      nitro_service service,
      string response)
    {
      systemuser_systemgroup_binding.systemuser_systemgroup_binding_response systemgroupBindingResponse = new systemuser_systemgroup_binding.systemuser_systemgroup_binding_response();
      systemuser_systemgroup_binding.systemuser_systemgroup_binding_response resource = (systemuser_systemgroup_binding.systemuser_systemgroup_binding_response) service.get_payload_formatter().string_to_resource(systemgroupBindingResponse.GetType(), response);
      if (resource.errorcode != 0)
      {
        if (resource.errorcode == 444)
          service.clear_session();
        if (resource.severity == null)
          throw new nitro_exception(resource.message, resource.errorcode);
        if (resource.severity.Equals("ERROR"))
          throw new nitro_exception(resource.message, resource.errorcode);
      }
      return (base_resource[]) resource.systemuser_systemgroup_binding;
    }

    internal override string get_object_name() => this.username;

    public static systemuser_systemgroup_binding[] get(
      nitro_service service,
      string username)
    {
      return (systemuser_systemgroup_binding[]) new systemuser_systemgroup_binding()
      {
        username = username
      }.get_resources(service, (options) null);
    }

    public static systemuser_systemgroup_binding[] get_filtered(
      nitro_service service,
      string username,
      string filter)
    {
      systemuser_systemgroup_binding systemgroupBinding = new systemuser_systemgroup_binding();
      systemgroupBinding.username = username;
      options option = new options();
      option.set_filter(filter);
      return (systemuser_systemgroup_binding[]) systemgroupBinding.getfiltered(service, option);
    }

    public static systemuser_systemgroup_binding[] get_filtered(
      nitro_service service,
      string username,
      filtervalue[] filter)
    {
      systemuser_systemgroup_binding systemgroupBinding = new systemuser_systemgroup_binding();
      systemgroupBinding.username = username;
      options option = new options();
      option.set_filter(filter);
      return (systemuser_systemgroup_binding[]) systemgroupBinding.getfiltered(service, option);
    }

    public static uint count(nitro_service service, string username)
    {
      systemuser_systemgroup_binding systemgroupBinding = new systemuser_systemgroup_binding();
      systemgroupBinding.username = username;
      options option = new options();
      option.set_count(true);
      systemuser_systemgroup_binding[] resources = (systemuser_systemgroup_binding[]) systemgroupBinding.get_resources(service, option);
      return resources != null && resources.Length > 0 ? resources[0].__count.Value : 0U;
    }

    public static uint count_filtered(nitro_service service, string username, string filter)
    {
      systemuser_systemgroup_binding systemgroupBinding = new systemuser_systemgroup_binding();
      systemgroupBinding.username = username;
      options option = new options();
      option.set_count(true);
      option.set_filter(filter);
      systemuser_systemgroup_binding[] systemgroupBindingArray = (systemuser_systemgroup_binding[]) systemgroupBinding.getfiltered(service, option);
      return systemgroupBindingArray != null && systemgroupBindingArray.Length > 0 ? systemgroupBindingArray[0].__count.Value : 0U;
    }

    public static uint count_filtered(nitro_service service, string username, filtervalue[] filter)
    {
      systemuser_systemgroup_binding systemgroupBinding = new systemuser_systemgroup_binding();
      systemgroupBinding.username = username;
      options option = new options();
      option.set_count(true);
      option.set_filter(filter);
      systemuser_systemgroup_binding[] systemgroupBindingArray = (systemuser_systemgroup_binding[]) systemgroupBinding.getfiltered(service, option);
      return systemgroupBindingArray != null && systemgroupBindingArray.Length > 0 ? systemgroupBindingArray[0].__count.Value : 0U;
    }

    private class systemuser_systemgroup_binding_response : base_response
    {
      public systemuser_systemgroup_binding[] systemuser_systemgroup_binding = (systemuser_systemgroup_binding[]) null;
    }
  }
}
