// Decompiled with JetBrains decompiler
// Type: com.citrix.netscaler.nitro.resource.config.rise.riseprofile_interface_binding
// Assembly: nitro, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 6CF5DDEF-E052-4F9D-953F-6644F8378A66


using com.citrix.netscaler.nitro.exception;
using com.citrix.netscaler.nitro.resource.Base;
using com.citrix.netscaler.nitro.service;
using com.citrix.netscaler.nitro.util;

namespace com.citrix.netscaler.nitro.resource.config.rise
{
  public class riseprofile_interface_binding : base_resource
  {
    private string memberinterfaceField = (string) null;
    private string profilenameField = (string) null;
    private uint? __countField = new uint?();

    public uint? __count
    {
      get => this.__countField;
      set => this.__countField = value;
    }

    public string memberinterface
    {
      get => this.memberinterfaceField;
      set => this.memberinterfaceField = value;
    }

    public string profilename
    {
      get => this.profilenameField;
      set => this.profilenameField = value;
    }

    internal override base_resource[] get_nitro_response(
      nitro_service service,
      string response)
    {
      riseprofile_interface_binding.riseprofile_interface_binding_response interfaceBindingResponse = new riseprofile_interface_binding.riseprofile_interface_binding_response();
      riseprofile_interface_binding.riseprofile_interface_binding_response resource = (riseprofile_interface_binding.riseprofile_interface_binding_response) service.get_payload_formatter().string_to_resource(interfaceBindingResponse.GetType(), response);
      if (resource.errorcode != 0)
      {
        if (resource.errorcode == 444)
          service.clear_session();
        if (resource.severity == null)
          throw new nitro_exception(resource.message, resource.errorcode);
        if (resource.severity.Equals("ERROR"))
          throw new nitro_exception(resource.message, resource.errorcode);
      }
      return (base_resource[]) resource.riseprofile_interface_binding;
    }

    internal override string get_object_name() => this.profilename;

    public static riseprofile_interface_binding[] get(
      nitro_service service,
      string profilename)
    {
      return (riseprofile_interface_binding[]) new riseprofile_interface_binding()
      {
        profilename = profilename
      }.get_resources(service, (options) null);
    }

    public static riseprofile_interface_binding[] get_filtered(
      nitro_service service,
      string profilename,
      string filter)
    {
      riseprofile_interface_binding interfaceBinding = new riseprofile_interface_binding();
      interfaceBinding.profilename = profilename;
      options option = new options();
      option.set_filter(filter);
      return (riseprofile_interface_binding[]) interfaceBinding.getfiltered(service, option);
    }

    public static riseprofile_interface_binding[] get_filtered(
      nitro_service service,
      string profilename,
      filtervalue[] filter)
    {
      riseprofile_interface_binding interfaceBinding = new riseprofile_interface_binding();
      interfaceBinding.profilename = profilename;
      options option = new options();
      option.set_filter(filter);
      return (riseprofile_interface_binding[]) interfaceBinding.getfiltered(service, option);
    }

    public static uint count(nitro_service service, string profilename)
    {
      riseprofile_interface_binding interfaceBinding = new riseprofile_interface_binding();
      interfaceBinding.profilename = profilename;
      options option = new options();
      option.set_count(true);
      riseprofile_interface_binding[] resources = (riseprofile_interface_binding[]) interfaceBinding.get_resources(service, option);
      return resources != null && resources.Length > 0 ? resources[0].__count.Value : 0U;
    }

    public static uint count_filtered(nitro_service service, string profilename, string filter)
    {
      riseprofile_interface_binding interfaceBinding = new riseprofile_interface_binding();
      interfaceBinding.profilename = profilename;
      options option = new options();
      option.set_count(true);
      option.set_filter(filter);
      riseprofile_interface_binding[] interfaceBindingArray = (riseprofile_interface_binding[]) interfaceBinding.getfiltered(service, option);
      return interfaceBindingArray != null && interfaceBindingArray.Length > 0 ? interfaceBindingArray[0].__count.Value : 0U;
    }

    public static uint count_filtered(
      nitro_service service,
      string profilename,
      filtervalue[] filter)
    {
      riseprofile_interface_binding interfaceBinding = new riseprofile_interface_binding();
      interfaceBinding.profilename = profilename;
      options option = new options();
      option.set_count(true);
      option.set_filter(filter);
      riseprofile_interface_binding[] interfaceBindingArray = (riseprofile_interface_binding[]) interfaceBinding.getfiltered(service, option);
      return interfaceBindingArray != null && interfaceBindingArray.Length > 0 ? interfaceBindingArray[0].__count.Value : 0U;
    }

    private class riseprofile_interface_binding_response : base_response
    {
      public riseprofile_interface_binding[] riseprofile_interface_binding = (riseprofile_interface_binding[]) null;
    }
  }
}
