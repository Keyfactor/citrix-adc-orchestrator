// Decompiled with JetBrains decompiler
// Type: com.citrix.netscaler.nitro.resource.config.tm.tmsessionpolicy_aaagroup_binding
// Assembly: nitro, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 6CF5DDEF-E052-4F9D-953F-6644F8378A66


using com.citrix.netscaler.nitro.exception;
using com.citrix.netscaler.nitro.resource.Base;
using com.citrix.netscaler.nitro.service;
using com.citrix.netscaler.nitro.util;

namespace com.citrix.netscaler.nitro.resource.config.tm
{
  public class tmsessionpolicy_aaagroup_binding : base_resource
  {
    private string boundtoField = (string) null;
    private uint? priorityField = new uint?();
    private uint? activepolicyField = new uint?();
    private string nameField = (string) null;
    private uint? __countField = new uint?();

    public uint? __count
    {
      get => this.__countField;
      set => this.__countField = value;
    }

    public string boundto
    {
      get => this.boundtoField;
      set => this.boundtoField = value;
    }

    public string name
    {
      get => this.nameField;
      set => this.nameField = value;
    }

    public uint? priority
    {
      get => this.priorityField;
      private set => this.priorityField = value;
    }

    public uint? activepolicy
    {
      get => this.activepolicyField;
      private set => this.activepolicyField = value;
    }

    internal override base_resource[] get_nitro_response(
      nitro_service service,
      string response)
    {
      tmsessionpolicy_aaagroup_binding.tmsessionpolicy_aaagroup_binding_response aaagroupBindingResponse = new tmsessionpolicy_aaagroup_binding.tmsessionpolicy_aaagroup_binding_response();
      tmsessionpolicy_aaagroup_binding.tmsessionpolicy_aaagroup_binding_response resource = (tmsessionpolicy_aaagroup_binding.tmsessionpolicy_aaagroup_binding_response) service.get_payload_formatter().string_to_resource(aaagroupBindingResponse.GetType(), response);
      if (resource.errorcode != 0)
      {
        if (resource.errorcode == 444)
          service.clear_session();
        if (resource.severity == null)
          throw new nitro_exception(resource.message, resource.errorcode);
        if (resource.severity.Equals("ERROR"))
          throw new nitro_exception(resource.message, resource.errorcode);
      }
      return (base_resource[]) resource.tmsessionpolicy_aaagroup_binding;
    }

    internal override string get_object_name() => this.name;

    public static tmsessionpolicy_aaagroup_binding[] get(
      nitro_service service,
      string name)
    {
      return (tmsessionpolicy_aaagroup_binding[]) new tmsessionpolicy_aaagroup_binding()
      {
        name = name
      }.get_resources(service, (options) null);
    }

    public static tmsessionpolicy_aaagroup_binding[] get_filtered(
      nitro_service service,
      string name,
      string filter)
    {
      tmsessionpolicy_aaagroup_binding tmsessionpolicyAaagroupBinding = new tmsessionpolicy_aaagroup_binding();
      tmsessionpolicyAaagroupBinding.name = name;
      options option = new options();
      option.set_filter(filter);
      return (tmsessionpolicy_aaagroup_binding[]) tmsessionpolicyAaagroupBinding.getfiltered(service, option);
    }

    public static tmsessionpolicy_aaagroup_binding[] get_filtered(
      nitro_service service,
      string name,
      filtervalue[] filter)
    {
      tmsessionpolicy_aaagroup_binding tmsessionpolicyAaagroupBinding = new tmsessionpolicy_aaagroup_binding();
      tmsessionpolicyAaagroupBinding.name = name;
      options option = new options();
      option.set_filter(filter);
      return (tmsessionpolicy_aaagroup_binding[]) tmsessionpolicyAaagroupBinding.getfiltered(service, option);
    }

    public static uint count(nitro_service service, string name)
    {
      tmsessionpolicy_aaagroup_binding tmsessionpolicyAaagroupBinding = new tmsessionpolicy_aaagroup_binding();
      tmsessionpolicyAaagroupBinding.name = name;
      options option = new options();
      option.set_count(true);
      tmsessionpolicy_aaagroup_binding[] resources = (tmsessionpolicy_aaagroup_binding[]) tmsessionpolicyAaagroupBinding.get_resources(service, option);
      return resources != null && resources.Length > 0 ? resources[0].__count.Value : 0U;
    }

    public static uint count_filtered(nitro_service service, string name, string filter)
    {
      tmsessionpolicy_aaagroup_binding tmsessionpolicyAaagroupBinding = new tmsessionpolicy_aaagroup_binding();
      tmsessionpolicyAaagroupBinding.name = name;
      options option = new options();
      option.set_count(true);
      option.set_filter(filter);
      tmsessionpolicy_aaagroup_binding[] tmsessionpolicyAaagroupBindingArray = (tmsessionpolicy_aaagroup_binding[]) tmsessionpolicyAaagroupBinding.getfiltered(service, option);
      return tmsessionpolicyAaagroupBindingArray != null && tmsessionpolicyAaagroupBindingArray.Length > 0 ? tmsessionpolicyAaagroupBindingArray[0].__count.Value : 0U;
    }

    public static uint count_filtered(nitro_service service, string name, filtervalue[] filter)
    {
      tmsessionpolicy_aaagroup_binding tmsessionpolicyAaagroupBinding = new tmsessionpolicy_aaagroup_binding();
      tmsessionpolicyAaagroupBinding.name = name;
      options option = new options();
      option.set_count(true);
      option.set_filter(filter);
      tmsessionpolicy_aaagroup_binding[] tmsessionpolicyAaagroupBindingArray = (tmsessionpolicy_aaagroup_binding[]) tmsessionpolicyAaagroupBinding.getfiltered(service, option);
      return tmsessionpolicyAaagroupBindingArray != null && tmsessionpolicyAaagroupBindingArray.Length > 0 ? tmsessionpolicyAaagroupBindingArray[0].__count.Value : 0U;
    }

    private class tmsessionpolicy_aaagroup_binding_response : base_response
    {
      public tmsessionpolicy_aaagroup_binding[] tmsessionpolicy_aaagroup_binding = (tmsessionpolicy_aaagroup_binding[]) null;
    }
  }
}
