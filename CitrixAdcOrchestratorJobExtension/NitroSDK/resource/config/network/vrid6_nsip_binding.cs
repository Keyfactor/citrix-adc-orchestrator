// Decompiled with JetBrains decompiler
// Type: com.citrix.netscaler.nitro.resource.config.network.vrid6_nsip_binding
// Assembly: nitro, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 6CF5DDEF-E052-4F9D-953F-6644F8378A66


using com.citrix.netscaler.nitro.exception;
using com.citrix.netscaler.nitro.resource.Base;
using com.citrix.netscaler.nitro.service;
using com.citrix.netscaler.nitro.util;

namespace com.citrix.netscaler.nitro.resource.config.network
{
  public class vrid6_nsip_binding : base_resource
  {
    private string ipaddressField = (string) null;
    private uint? flagsField = new uint?();
    private uint? idField = new uint?();
    private string ifnumField = (string) null;
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

    public string ifnum
    {
      get => this.ifnumField;
      set => this.ifnumField = value;
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
      vrid6_nsip_binding.vrid6_nsip_binding_response nsipBindingResponse = new vrid6_nsip_binding.vrid6_nsip_binding_response();
      vrid6_nsip_binding.vrid6_nsip_binding_response resource = (vrid6_nsip_binding.vrid6_nsip_binding_response) service.get_payload_formatter().string_to_resource(nsipBindingResponse.GetType(), response);
      if (resource.errorcode != 0)
      {
        if (resource.errorcode == 444)
          service.clear_session();
        if (resource.severity == null)
          throw new nitro_exception(resource.message, resource.errorcode);
        if (resource.severity.Equals("ERROR"))
          throw new nitro_exception(resource.message, resource.errorcode);
      }
      return (base_resource[]) resource.vrid6_nsip_binding;
    }

    internal override string get_object_name() => this.id.HasValue ? this.id.ToString() : (string) null;

    public static vrid6_nsip_binding[] get(nitro_service service, uint? id) => (vrid6_nsip_binding[]) new vrid6_nsip_binding()
    {
      id = id
    }.get_resources(service, (options) null);

    public static vrid6_nsip_binding[] get_filtered(
      nitro_service service,
      uint? id,
      string filter)
    {
      vrid6_nsip_binding vrid6NsipBinding = new vrid6_nsip_binding();
      vrid6NsipBinding.id = id;
      options option = new options();
      option.set_filter(filter);
      return (vrid6_nsip_binding[]) vrid6NsipBinding.getfiltered(service, option);
    }

    public static vrid6_nsip_binding[] get_filtered(
      nitro_service service,
      uint? id,
      filtervalue[] filter)
    {
      vrid6_nsip_binding vrid6NsipBinding = new vrid6_nsip_binding();
      vrid6NsipBinding.id = id;
      options option = new options();
      option.set_filter(filter);
      return (vrid6_nsip_binding[]) vrid6NsipBinding.getfiltered(service, option);
    }

    public static uint count(nitro_service service, uint? id)
    {
      vrid6_nsip_binding vrid6NsipBinding = new vrid6_nsip_binding();
      vrid6NsipBinding.id = id;
      options option = new options();
      option.set_count(true);
      vrid6_nsip_binding[] resources = (vrid6_nsip_binding[]) vrid6NsipBinding.get_resources(service, option);
      return resources != null && resources.Length > 0 ? resources[0].__count.Value : 0U;
    }

    public static uint count_filtered(nitro_service service, uint? id, string filter)
    {
      vrid6_nsip_binding vrid6NsipBinding = new vrid6_nsip_binding();
      vrid6NsipBinding.id = id;
      options option = new options();
      option.set_count(true);
      option.set_filter(filter);
      vrid6_nsip_binding[] vrid6NsipBindingArray = (vrid6_nsip_binding[]) vrid6NsipBinding.getfiltered(service, option);
      return vrid6NsipBindingArray != null && vrid6NsipBindingArray.Length > 0 ? vrid6NsipBindingArray[0].__count.Value : 0U;
    }

    public static uint count_filtered(nitro_service service, uint? id, filtervalue[] filter)
    {
      vrid6_nsip_binding vrid6NsipBinding = new vrid6_nsip_binding();
      vrid6NsipBinding.id = id;
      options option = new options();
      option.set_count(true);
      option.set_filter(filter);
      vrid6_nsip_binding[] vrid6NsipBindingArray = (vrid6_nsip_binding[]) vrid6NsipBinding.getfiltered(service, option);
      return vrid6NsipBindingArray != null && vrid6NsipBindingArray.Length > 0 ? vrid6NsipBindingArray[0].__count.Value : 0U;
    }

    private class vrid6_nsip_binding_response : base_response
    {
      public vrid6_nsip_binding[] vrid6_nsip_binding = (vrid6_nsip_binding[]) null;
    }
  }
}
