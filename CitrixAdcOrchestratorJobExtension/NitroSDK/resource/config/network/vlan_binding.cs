// Decompiled with JetBrains decompiler
// Type: com.citrix.netscaler.nitro.resource.config.network.vlan_binding
// Assembly: nitro, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 6CF5DDEF-E052-4F9D-953F-6644F8378A66


using com.citrix.netscaler.nitro.exception;
using com.citrix.netscaler.nitro.resource.Base;
using com.citrix.netscaler.nitro.service;

namespace com.citrix.netscaler.nitro.resource.config.network
{
  public class vlan_binding : base_resource
  {
    private uint? idField = new uint?();
    private com.citrix.netscaler.nitro.resource.config.network.vlan_channel_binding[] vlan_channel_bindingField = (com.citrix.netscaler.nitro.resource.config.network.vlan_channel_binding[]) null;
    private com.citrix.netscaler.nitro.resource.config.network.vlan_nsip_binding[] vlan_nsip_bindingField = (com.citrix.netscaler.nitro.resource.config.network.vlan_nsip_binding[]) null;
    private com.citrix.netscaler.nitro.resource.config.network.vlan_interface_binding[] vlan_interface_bindingField = (com.citrix.netscaler.nitro.resource.config.network.vlan_interface_binding[]) null;
    private com.citrix.netscaler.nitro.resource.config.network.vlan_linkset_binding[] vlan_linkset_bindingField = (com.citrix.netscaler.nitro.resource.config.network.vlan_linkset_binding[]) null;
    private com.citrix.netscaler.nitro.resource.config.network.vlan_nsip6_binding[] vlan_nsip6_bindingField = (com.citrix.netscaler.nitro.resource.config.network.vlan_nsip6_binding[]) null;

    public uint? id
    {
      get => this.idField;
      set => this.idField = value;
    }

    public com.citrix.netscaler.nitro.resource.config.network.vlan_interface_binding[] vlan_interface_binding
    {
      get => this.vlan_interface_bindingField;
      private set => this.vlan_interface_bindingField = value;
    }

    public com.citrix.netscaler.nitro.resource.config.network.vlan_nsip6_binding[] vlan_nsip6_binding
    {
      get => this.vlan_nsip6_bindingField;
      private set => this.vlan_nsip6_bindingField = value;
    }

    public com.citrix.netscaler.nitro.resource.config.network.vlan_nsip_binding[] vlan_nsip_binding
    {
      get => this.vlan_nsip_bindingField;
      private set => this.vlan_nsip_bindingField = value;
    }

    public com.citrix.netscaler.nitro.resource.config.network.vlan_linkset_binding[] vlan_linkset_binding
    {
      get => this.vlan_linkset_bindingField;
      private set => this.vlan_linkset_bindingField = value;
    }

    public com.citrix.netscaler.nitro.resource.config.network.vlan_channel_binding[] vlan_channel_binding
    {
      get => this.vlan_channel_bindingField;
      private set => this.vlan_channel_bindingField = value;
    }

    internal override base_resource[] get_nitro_response(
      nitro_service service,
      string response)
    {
      vlan_binding.vlan_binding_response vlanBindingResponse = new vlan_binding.vlan_binding_response();
      vlan_binding.vlan_binding_response resource = (vlan_binding.vlan_binding_response) service.get_payload_formatter().string_to_resource(vlanBindingResponse.GetType(), response);
      if (resource.errorcode != 0)
      {
        if (resource.errorcode == 444)
          service.clear_session();
        if (resource.severity == null)
          throw new nitro_exception(resource.message, resource.errorcode);
        if (resource.severity.Equals("ERROR"))
          throw new nitro_exception(resource.message, resource.errorcode);
      }
      return (base_resource[]) resource.vlan_binding;
    }

    internal override string get_object_name() => this.id.HasValue ? this.id.ToString() : (string) null;

    public static vlan_binding get(nitro_service service, uint? id) => (vlan_binding) new vlan_binding()
    {
      id = id
    }.get_resource(service);

    public static vlan_binding[] get(nitro_service service, uint?[] id)
    {
      if (id == null || id.Length <= 0)
        return (vlan_binding[]) null;
      vlan_binding[] vlanBindingArray1 = new vlan_binding[id.Length];
      vlan_binding[] vlanBindingArray2 = new vlan_binding[id.Length];
      for (int index = 0; index < id.Length; ++index)
      {
        vlanBindingArray2[index] = new vlan_binding();
        vlanBindingArray2[index].id = id[index];
        vlanBindingArray1[index] = (vlan_binding) vlanBindingArray2[index].get_resource(service);
      }
      return vlanBindingArray1;
    }

    private class vlan_binding_response : base_response
    {
      public vlan_binding[] vlan_binding = (vlan_binding[]) null;
    }
  }
}
