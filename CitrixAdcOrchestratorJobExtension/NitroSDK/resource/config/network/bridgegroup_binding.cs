// Decompiled with JetBrains decompiler
// Type: com.citrix.netscaler.nitro.resource.config.network.bridgegroup_binding
// Assembly: nitro, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 6CF5DDEF-E052-4F9D-953F-6644F8378A66


using com.citrix.netscaler.nitro.exception;
using com.citrix.netscaler.nitro.resource.Base;
using com.citrix.netscaler.nitro.service;

namespace com.citrix.netscaler.nitro.resource.config.network
{
  public class bridgegroup_binding : base_resource
  {
    private uint? idField = new uint?();
    private com.citrix.netscaler.nitro.resource.config.network.bridgegroup_nsip_binding[] bridgegroup_nsip_bindingField = (com.citrix.netscaler.nitro.resource.config.network.bridgegroup_nsip_binding[]) null;
    private com.citrix.netscaler.nitro.resource.config.network.bridgegroup_vlan_binding[] bridgegroup_vlan_bindingField = (com.citrix.netscaler.nitro.resource.config.network.bridgegroup_vlan_binding[]) null;
    private com.citrix.netscaler.nitro.resource.config.network.bridgegroup_nsip6_binding[] bridgegroup_nsip6_bindingField = (com.citrix.netscaler.nitro.resource.config.network.bridgegroup_nsip6_binding[]) null;

    public uint? id
    {
      get => this.idField;
      set => this.idField = value;
    }

    public com.citrix.netscaler.nitro.resource.config.network.bridgegroup_vlan_binding[] bridgegroup_vlan_binding
    {
      get => this.bridgegroup_vlan_bindingField;
      private set => this.bridgegroup_vlan_bindingField = value;
    }

    public com.citrix.netscaler.nitro.resource.config.network.bridgegroup_nsip_binding[] bridgegroup_nsip_binding
    {
      get => this.bridgegroup_nsip_bindingField;
      private set => this.bridgegroup_nsip_bindingField = value;
    }

    public com.citrix.netscaler.nitro.resource.config.network.bridgegroup_nsip6_binding[] bridgegroup_nsip6_binding
    {
      get => this.bridgegroup_nsip6_bindingField;
      private set => this.bridgegroup_nsip6_bindingField = value;
    }

    internal override base_resource[] get_nitro_response(
      nitro_service service,
      string response)
    {
      bridgegroup_binding.bridgegroup_binding_response bridgegroupBindingResponse = new bridgegroup_binding.bridgegroup_binding_response();
      bridgegroup_binding.bridgegroup_binding_response resource = (bridgegroup_binding.bridgegroup_binding_response) service.get_payload_formatter().string_to_resource(bridgegroupBindingResponse.GetType(), response);
      if (resource.errorcode != 0)
      {
        if (resource.errorcode == 444)
          service.clear_session();
        if (resource.severity == null)
          throw new nitro_exception(resource.message, resource.errorcode);
        if (resource.severity.Equals("ERROR"))
          throw new nitro_exception(resource.message, resource.errorcode);
      }
      return (base_resource[]) resource.bridgegroup_binding;
    }

    internal override string get_object_name() => this.id.HasValue ? this.id.ToString() : (string) null;

    public static bridgegroup_binding get(nitro_service service, uint? id) => (bridgegroup_binding) new bridgegroup_binding()
    {
      id = id
    }.get_resource(service);

    public static bridgegroup_binding[] get(nitro_service service, uint?[] id)
    {
      if (id == null || id.Length <= 0)
        return (bridgegroup_binding[]) null;
      bridgegroup_binding[] bridgegroupBindingArray1 = new bridgegroup_binding[id.Length];
      bridgegroup_binding[] bridgegroupBindingArray2 = new bridgegroup_binding[id.Length];
      for (int index = 0; index < id.Length; ++index)
      {
        bridgegroupBindingArray2[index] = new bridgegroup_binding();
        bridgegroupBindingArray2[index].id = id[index];
        bridgegroupBindingArray1[index] = (bridgegroup_binding) bridgegroupBindingArray2[index].get_resource(service);
      }
      return bridgegroupBindingArray1;
    }

    private class bridgegroup_binding_response : base_response
    {
      public bridgegroup_binding[] bridgegroup_binding = (bridgegroup_binding[]) null;
    }
  }
}
