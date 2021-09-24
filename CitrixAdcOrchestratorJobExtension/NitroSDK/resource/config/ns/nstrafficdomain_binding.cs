// Decompiled with JetBrains decompiler
// Type: com.citrix.netscaler.nitro.resource.config.ns.nstrafficdomain_binding
// Assembly: nitro, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 6CF5DDEF-E052-4F9D-953F-6644F8378A66


using com.citrix.netscaler.nitro.exception;
using com.citrix.netscaler.nitro.resource.Base;
using com.citrix.netscaler.nitro.service;

namespace com.citrix.netscaler.nitro.resource.config.ns
{
  public class nstrafficdomain_binding : base_resource
  {
    private uint? tdField = new uint?();
    private com.citrix.netscaler.nitro.resource.config.ns.nstrafficdomain_bridgegroup_binding[] nstrafficdomain_bridgegroup_bindingField = (com.citrix.netscaler.nitro.resource.config.ns.nstrafficdomain_bridgegroup_binding[]) null;
    private com.citrix.netscaler.nitro.resource.config.ns.nstrafficdomain_vlan_binding[] nstrafficdomain_vlan_bindingField = (com.citrix.netscaler.nitro.resource.config.ns.nstrafficdomain_vlan_binding[]) null;
    private com.citrix.netscaler.nitro.resource.config.ns.nstrafficdomain_vxlan_binding[] nstrafficdomain_vxlan_bindingField = (com.citrix.netscaler.nitro.resource.config.ns.nstrafficdomain_vxlan_binding[]) null;

    public uint? td
    {
      get => this.tdField;
      set => this.tdField = value;
    }

    public com.citrix.netscaler.nitro.resource.config.ns.nstrafficdomain_vlan_binding[] nstrafficdomain_vlan_binding
    {
      get => this.nstrafficdomain_vlan_bindingField;
      private set => this.nstrafficdomain_vlan_bindingField = value;
    }

    public com.citrix.netscaler.nitro.resource.config.ns.nstrafficdomain_bridgegroup_binding[] nstrafficdomain_bridgegroup_binding
    {
      get => this.nstrafficdomain_bridgegroup_bindingField;
      private set => this.nstrafficdomain_bridgegroup_bindingField = value;
    }

    public com.citrix.netscaler.nitro.resource.config.ns.nstrafficdomain_vxlan_binding[] nstrafficdomain_vxlan_binding
    {
      get => this.nstrafficdomain_vxlan_bindingField;
      private set => this.nstrafficdomain_vxlan_bindingField = value;
    }

    internal override base_resource[] get_nitro_response(
      nitro_service service,
      string response)
    {
      nstrafficdomain_binding.nstrafficdomain_binding_response nstrafficdomainBindingResponse = new nstrafficdomain_binding.nstrafficdomain_binding_response();
      nstrafficdomain_binding.nstrafficdomain_binding_response resource = (nstrafficdomain_binding.nstrafficdomain_binding_response) service.get_payload_formatter().string_to_resource(nstrafficdomainBindingResponse.GetType(), response);
      if (resource.errorcode != 0)
      {
        if (resource.errorcode == 444)
          service.clear_session();
        if (resource.severity == null)
          throw new nitro_exception(resource.message, resource.errorcode);
        if (resource.severity.Equals("ERROR"))
          throw new nitro_exception(resource.message, resource.errorcode);
      }
      return (base_resource[]) resource.nstrafficdomain_binding;
    }

    internal override string get_object_name() => this.td.HasValue ? this.td.ToString() : (string) null;

    public static nstrafficdomain_binding get(
      nitro_service service,
      uint? td)
    {
      return (nstrafficdomain_binding) new nstrafficdomain_binding()
      {
        td = td
      }.get_resource(service);
    }

    public static nstrafficdomain_binding[] get(
      nitro_service service,
      uint?[] td)
    {
      if (td == null || td.Length <= 0)
        return (nstrafficdomain_binding[]) null;
      nstrafficdomain_binding[] nstrafficdomainBindingArray1 = new nstrafficdomain_binding[td.Length];
      nstrafficdomain_binding[] nstrafficdomainBindingArray2 = new nstrafficdomain_binding[td.Length];
      for (int index = 0; index < td.Length; ++index)
      {
        nstrafficdomainBindingArray2[index] = new nstrafficdomain_binding();
        nstrafficdomainBindingArray2[index].td = td[index];
        nstrafficdomainBindingArray1[index] = (nstrafficdomain_binding) nstrafficdomainBindingArray2[index].get_resource(service);
      }
      return nstrafficdomainBindingArray1;
    }

    private class nstrafficdomain_binding_response : base_response
    {
      public nstrafficdomain_binding[] nstrafficdomain_binding = (nstrafficdomain_binding[]) null;
    }
  }
}
