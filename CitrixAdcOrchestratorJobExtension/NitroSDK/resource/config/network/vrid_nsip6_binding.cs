// Decompiled with JetBrains decompiler
// Type: com.citrix.netscaler.nitro.resource.config.network.vrid_nsip6_binding
// Assembly: nitro, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 6CF5DDEF-E052-4F9D-953F-6644F8378A66


using com.citrix.netscaler.nitro.exception;
using com.citrix.netscaler.nitro.resource.Base;
using com.citrix.netscaler.nitro.service;
using com.citrix.netscaler.nitro.util;

namespace com.citrix.netscaler.nitro.resource.config.network
{
  public class vrid_nsip6_binding : base_resource
  {
    private string ipaddressField = (string) null;
    private uint? flagsField = new uint?();
    private uint? idField = new uint?();
    private uint? __countField = new uint?();

    public uint? __count
    {
      get => this.__countField;
      set => this.__countField = value;
    }

    public uint? id
    {
      get => this.idField;
      set => this.idField = value;
    }

    public string ipaddress
    {
      get => this.ipaddressField;
      set => this.ipaddressField = value;
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
      vrid_nsip6_binding.vrid_nsip6_binding_response nsip6BindingResponse = new vrid_nsip6_binding.vrid_nsip6_binding_response();
      vrid_nsip6_binding.vrid_nsip6_binding_response resource = (vrid_nsip6_binding.vrid_nsip6_binding_response) service.get_payload_formatter().string_to_resource(nsip6BindingResponse.GetType(), response);
      if (resource.errorcode != 0)
      {
        if (resource.errorcode == 444)
          service.clear_session();
        if (resource.severity == null)
          throw new nitro_exception(resource.message, resource.errorcode);
        if (resource.severity.Equals("ERROR"))
          throw new nitro_exception(resource.message, resource.errorcode);
      }
      return (base_resource[]) resource.vrid_nsip6_binding;
    }

    internal override string get_object_name() => this.id.HasValue ? this.id.ToString() : (string) null;

    public static vrid_nsip6_binding[] get(nitro_service service, uint? id) => (vrid_nsip6_binding[]) new vrid_nsip6_binding()
    {
      id = id
    }.get_resources(service, (options) null);

    public static vrid_nsip6_binding[] get_filtered(
      nitro_service service,
      uint? id,
      string filter)
    {
      vrid_nsip6_binding vridNsip6Binding = new vrid_nsip6_binding();
      vridNsip6Binding.id = id;
      options option = new options();
      option.set_filter(filter);
      return (vrid_nsip6_binding[]) vridNsip6Binding.getfiltered(service, option);
    }

    public static vrid_nsip6_binding[] get_filtered(
      nitro_service service,
      uint? id,
      filtervalue[] filter)
    {
      vrid_nsip6_binding vridNsip6Binding = new vrid_nsip6_binding();
      vridNsip6Binding.id = id;
      options option = new options();
      option.set_filter(filter);
      return (vrid_nsip6_binding[]) vridNsip6Binding.getfiltered(service, option);
    }

    public static uint count(nitro_service service, uint? id)
    {
      vrid_nsip6_binding vridNsip6Binding = new vrid_nsip6_binding();
      vridNsip6Binding.id = id;
      options option = new options();
      option.set_count(true);
      vrid_nsip6_binding[] resources = (vrid_nsip6_binding[]) vridNsip6Binding.get_resources(service, option);
      return resources != null && resources.Length > 0 ? resources[0].__count.Value : 0U;
    }

    public static uint count_filtered(nitro_service service, uint? id, string filter)
    {
      vrid_nsip6_binding vridNsip6Binding = new vrid_nsip6_binding();
      vridNsip6Binding.id = id;
      options option = new options();
      option.set_count(true);
      option.set_filter(filter);
      vrid_nsip6_binding[] vridNsip6BindingArray = (vrid_nsip6_binding[]) vridNsip6Binding.getfiltered(service, option);
      return vridNsip6BindingArray != null && vridNsip6BindingArray.Length > 0 ? vridNsip6BindingArray[0].__count.Value : 0U;
    }

    public static uint count_filtered(nitro_service service, uint? id, filtervalue[] filter)
    {
      vrid_nsip6_binding vridNsip6Binding = new vrid_nsip6_binding();
      vridNsip6Binding.id = id;
      options option = new options();
      option.set_count(true);
      option.set_filter(filter);
      vrid_nsip6_binding[] vridNsip6BindingArray = (vrid_nsip6_binding[]) vridNsip6Binding.getfiltered(service, option);
      return vridNsip6BindingArray != null && vridNsip6BindingArray.Length > 0 ? vridNsip6BindingArray[0].__count.Value : 0U;
    }

    private class vrid_nsip6_binding_response : base_response
    {
      public vrid_nsip6_binding[] vrid_nsip6_binding = (vrid_nsip6_binding[]) null;
    }
  }
}
