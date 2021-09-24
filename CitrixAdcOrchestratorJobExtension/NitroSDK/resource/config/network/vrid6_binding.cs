// Decompiled with JetBrains decompiler
// Type: com.citrix.netscaler.nitro.resource.config.network.vrid6_binding
// Assembly: nitro, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 6CF5DDEF-E052-4F9D-953F-6644F8378A66


using com.citrix.netscaler.nitro.exception;
using com.citrix.netscaler.nitro.resource.Base;
using com.citrix.netscaler.nitro.service;

namespace com.citrix.netscaler.nitro.resource.config.network
{
  public class vrid6_binding : base_resource
  {
    private uint? idField = new uint?();
    private com.citrix.netscaler.nitro.resource.config.network.vrid6_interface_binding[] vrid6_interface_bindingField = (com.citrix.netscaler.nitro.resource.config.network.vrid6_interface_binding[]) null;
    private com.citrix.netscaler.nitro.resource.config.network.vrid6_nsip_binding[] vrid6_nsip_bindingField = (com.citrix.netscaler.nitro.resource.config.network.vrid6_nsip_binding[]) null;
    private com.citrix.netscaler.nitro.resource.config.network.vrid6_nsip6_binding[] vrid6_nsip6_bindingField = (com.citrix.netscaler.nitro.resource.config.network.vrid6_nsip6_binding[]) null;

    public uint? id
    {
      get => this.idField;
      set => this.idField = value;
    }

    public com.citrix.netscaler.nitro.resource.config.network.vrid6_nsip6_binding[] vrid6_nsip6_binding
    {
      get => this.vrid6_nsip6_bindingField;
      private set => this.vrid6_nsip6_bindingField = value;
    }

    public com.citrix.netscaler.nitro.resource.config.network.vrid6_nsip_binding[] vrid6_nsip_binding
    {
      get => this.vrid6_nsip_bindingField;
      private set => this.vrid6_nsip_bindingField = value;
    }

    public com.citrix.netscaler.nitro.resource.config.network.vrid6_interface_binding[] vrid6_interface_binding
    {
      get => this.vrid6_interface_bindingField;
      private set => this.vrid6_interface_bindingField = value;
    }

    internal override base_resource[] get_nitro_response(
      nitro_service service,
      string response)
    {
      vrid6_binding.vrid6_binding_response vrid6BindingResponse = new vrid6_binding.vrid6_binding_response();
      vrid6_binding.vrid6_binding_response resource = (vrid6_binding.vrid6_binding_response) service.get_payload_formatter().string_to_resource(vrid6BindingResponse.GetType(), response);
      if (resource.errorcode != 0)
      {
        if (resource.errorcode == 444)
          service.clear_session();
        if (resource.severity == null)
          throw new nitro_exception(resource.message, resource.errorcode);
        if (resource.severity.Equals("ERROR"))
          throw new nitro_exception(resource.message, resource.errorcode);
      }
      return (base_resource[]) resource.vrid6_binding;
    }

    internal override string get_object_name() => this.id.HasValue ? this.id.ToString() : (string) null;

    public static vrid6_binding get(nitro_service service, uint? id) => (vrid6_binding) new vrid6_binding()
    {
      id = id
    }.get_resource(service);

    public static vrid6_binding[] get(nitro_service service, uint?[] id)
    {
      if (id == null || id.Length <= 0)
        return (vrid6_binding[]) null;
      vrid6_binding[] vrid6BindingArray1 = new vrid6_binding[id.Length];
      vrid6_binding[] vrid6BindingArray2 = new vrid6_binding[id.Length];
      for (int index = 0; index < id.Length; ++index)
      {
        vrid6BindingArray2[index] = new vrid6_binding();
        vrid6BindingArray2[index].id = id[index];
        vrid6BindingArray1[index] = (vrid6_binding) vrid6BindingArray2[index].get_resource(service);
      }
      return vrid6BindingArray1;
    }

    private class vrid6_binding_response : base_response
    {
      public vrid6_binding[] vrid6_binding = (vrid6_binding[]) null;
    }
  }
}
