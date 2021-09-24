// Decompiled with JetBrains decompiler
// Type: com.citrix.netscaler.nitro.resource.config.network.vrid_binding
// Assembly: nitro, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 6CF5DDEF-E052-4F9D-953F-6644F8378A66


using com.citrix.netscaler.nitro.exception;
using com.citrix.netscaler.nitro.resource.Base;
using com.citrix.netscaler.nitro.service;

namespace com.citrix.netscaler.nitro.resource.config.network
{
  public class vrid_binding : base_resource
  {
    private uint? idField = new uint?();
    private com.citrix.netscaler.nitro.resource.config.network.vrid_nsip6_binding[] vrid_nsip6_bindingField = (com.citrix.netscaler.nitro.resource.config.network.vrid_nsip6_binding[]) null;
    private com.citrix.netscaler.nitro.resource.config.network.vrid_interface_binding[] vrid_interface_bindingField = (com.citrix.netscaler.nitro.resource.config.network.vrid_interface_binding[]) null;
    private com.citrix.netscaler.nitro.resource.config.network.vrid_nsip_binding[] vrid_nsip_bindingField = (com.citrix.netscaler.nitro.resource.config.network.vrid_nsip_binding[]) null;

    public uint? id
    {
      get => this.idField;
      set => this.idField = value;
    }

    public com.citrix.netscaler.nitro.resource.config.network.vrid_nsip6_binding[] vrid_nsip6_binding
    {
      get => this.vrid_nsip6_bindingField;
      private set => this.vrid_nsip6_bindingField = value;
    }

    public com.citrix.netscaler.nitro.resource.config.network.vrid_nsip_binding[] vrid_nsip_binding
    {
      get => this.vrid_nsip_bindingField;
      private set => this.vrid_nsip_bindingField = value;
    }

    public com.citrix.netscaler.nitro.resource.config.network.vrid_interface_binding[] vrid_interface_binding
    {
      get => this.vrid_interface_bindingField;
      private set => this.vrid_interface_bindingField = value;
    }

    internal override base_resource[] get_nitro_response(
      nitro_service service,
      string response)
    {
      vrid_binding.vrid_binding_response vridBindingResponse = new vrid_binding.vrid_binding_response();
      vrid_binding.vrid_binding_response resource = (vrid_binding.vrid_binding_response) service.get_payload_formatter().string_to_resource(vridBindingResponse.GetType(), response);
      if (resource.errorcode != 0)
      {
        if (resource.errorcode == 444)
          service.clear_session();
        if (resource.severity == null)
          throw new nitro_exception(resource.message, resource.errorcode);
        if (resource.severity.Equals("ERROR"))
          throw new nitro_exception(resource.message, resource.errorcode);
      }
      return (base_resource[]) resource.vrid_binding;
    }

    internal override string get_object_name() => this.id.HasValue ? this.id.ToString() : (string) null;

    public static vrid_binding get(nitro_service service, uint? id) => (vrid_binding) new vrid_binding()
    {
      id = id
    }.get_resource(service);

    public static vrid_binding[] get(nitro_service service, uint?[] id)
    {
      if (id == null || id.Length <= 0)
        return (vrid_binding[]) null;
      vrid_binding[] vridBindingArray1 = new vrid_binding[id.Length];
      vrid_binding[] vridBindingArray2 = new vrid_binding[id.Length];
      for (int index = 0; index < id.Length; ++index)
      {
        vridBindingArray2[index] = new vrid_binding();
        vridBindingArray2[index].id = id[index];
        vridBindingArray1[index] = (vrid_binding) vridBindingArray2[index].get_resource(service);
      }
      return vridBindingArray1;
    }

    private class vrid_binding_response : base_response
    {
      public vrid_binding[] vrid_binding = (vrid_binding[]) null;
    }
  }
}
