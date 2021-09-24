// Decompiled with JetBrains decompiler
// Type: com.citrix.netscaler.nitro.resource.config.network.vxlan_binding
// Assembly: nitro, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 6CF5DDEF-E052-4F9D-953F-6644F8378A66


using com.citrix.netscaler.nitro.exception;
using com.citrix.netscaler.nitro.resource.Base;
using com.citrix.netscaler.nitro.service;

namespace com.citrix.netscaler.nitro.resource.config.network
{
  public class vxlan_binding : base_resource
  {
    private uint? idField = new uint?();
    private com.citrix.netscaler.nitro.resource.config.network.vxlan_iptunnel_binding[] vxlan_iptunnel_bindingField = (com.citrix.netscaler.nitro.resource.config.network.vxlan_iptunnel_binding[]) null;
    private com.citrix.netscaler.nitro.resource.config.network.vxlan_nsip_binding[] vxlan_nsip_bindingField = (com.citrix.netscaler.nitro.resource.config.network.vxlan_nsip_binding[]) null;
    private com.citrix.netscaler.nitro.resource.config.network.vxlan_nsip6_binding[] vxlan_nsip6_bindingField = (com.citrix.netscaler.nitro.resource.config.network.vxlan_nsip6_binding[]) null;

    public uint? id
    {
      get => this.idField;
      set => this.idField = value;
    }

    public com.citrix.netscaler.nitro.resource.config.network.vxlan_nsip6_binding[] vxlan_nsip6_binding
    {
      get => this.vxlan_nsip6_bindingField;
      private set => this.vxlan_nsip6_bindingField = value;
    }

    public com.citrix.netscaler.nitro.resource.config.network.vxlan_nsip_binding[] vxlan_nsip_binding
    {
      get => this.vxlan_nsip_bindingField;
      private set => this.vxlan_nsip_bindingField = value;
    }

    public com.citrix.netscaler.nitro.resource.config.network.vxlan_iptunnel_binding[] vxlan_iptunnel_binding
    {
      get => this.vxlan_iptunnel_bindingField;
      private set => this.vxlan_iptunnel_bindingField = value;
    }

    internal override base_resource[] get_nitro_response(
      nitro_service service,
      string response)
    {
      vxlan_binding.vxlan_binding_response vxlanBindingResponse = new vxlan_binding.vxlan_binding_response();
      vxlan_binding.vxlan_binding_response resource = (vxlan_binding.vxlan_binding_response) service.get_payload_formatter().string_to_resource(vxlanBindingResponse.GetType(), response);
      if (resource.errorcode != 0)
      {
        if (resource.errorcode == 444)
          service.clear_session();
        if (resource.severity == null)
          throw new nitro_exception(resource.message, resource.errorcode);
        if (resource.severity.Equals("ERROR"))
          throw new nitro_exception(resource.message, resource.errorcode);
      }
      return (base_resource[]) resource.vxlan_binding;
    }

    internal override string get_object_name() => this.id.HasValue ? this.id.ToString() : (string) null;

    public static vxlan_binding get(nitro_service service, uint? id) => (vxlan_binding) new vxlan_binding()
    {
      id = id
    }.get_resource(service);

    public static vxlan_binding[] get(nitro_service service, uint?[] id)
    {
      if (id == null || id.Length <= 0)
        return (vxlan_binding[]) null;
      vxlan_binding[] vxlanBindingArray1 = new vxlan_binding[id.Length];
      vxlan_binding[] vxlanBindingArray2 = new vxlan_binding[id.Length];
      for (int index = 0; index < id.Length; ++index)
      {
        vxlanBindingArray2[index] = new vxlan_binding();
        vxlanBindingArray2[index].id = id[index];
        vxlanBindingArray1[index] = (vxlan_binding) vxlanBindingArray2[index].get_resource(service);
      }
      return vxlanBindingArray1;
    }

    private class vxlan_binding_response : base_response
    {
      public vxlan_binding[] vxlan_binding = (vxlan_binding[]) null;
    }
  }
}
