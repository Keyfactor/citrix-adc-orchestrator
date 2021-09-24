// Decompiled with JetBrains decompiler
// Type: com.citrix.netscaler.nitro.resource.config.network.netbridge_binding
// Assembly: nitro, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 6CF5DDEF-E052-4F9D-953F-6644F8378A66


using com.citrix.netscaler.nitro.exception;
using com.citrix.netscaler.nitro.resource.Base;
using com.citrix.netscaler.nitro.service;

namespace com.citrix.netscaler.nitro.resource.config.network
{
  public class netbridge_binding : base_resource
  {
    private string nameField = (string) null;
    private com.citrix.netscaler.nitro.resource.config.network.netbridge_iptunnel_binding[] netbridge_iptunnel_bindingField = (com.citrix.netscaler.nitro.resource.config.network.netbridge_iptunnel_binding[]) null;
    private com.citrix.netscaler.nitro.resource.config.network.netbridge_nsip_binding[] netbridge_nsip_bindingField = (com.citrix.netscaler.nitro.resource.config.network.netbridge_nsip_binding[]) null;
    private com.citrix.netscaler.nitro.resource.config.network.netbridge_vlan_binding[] netbridge_vlan_bindingField = (com.citrix.netscaler.nitro.resource.config.network.netbridge_vlan_binding[]) null;
    private com.citrix.netscaler.nitro.resource.config.network.netbridge_nsip6_binding[] netbridge_nsip6_bindingField = (com.citrix.netscaler.nitro.resource.config.network.netbridge_nsip6_binding[]) null;

    public string name
    {
      get => this.nameField;
      set => this.nameField = value;
    }

    public com.citrix.netscaler.nitro.resource.config.network.netbridge_nsip6_binding[] netbridge_nsip6_binding
    {
      get => this.netbridge_nsip6_bindingField;
      private set => this.netbridge_nsip6_bindingField = value;
    }

    public com.citrix.netscaler.nitro.resource.config.network.netbridge_iptunnel_binding[] netbridge_iptunnel_binding
    {
      get => this.netbridge_iptunnel_bindingField;
      private set => this.netbridge_iptunnel_bindingField = value;
    }

    public com.citrix.netscaler.nitro.resource.config.network.netbridge_vlan_binding[] netbridge_vlan_binding
    {
      get => this.netbridge_vlan_bindingField;
      private set => this.netbridge_vlan_bindingField = value;
    }

    public com.citrix.netscaler.nitro.resource.config.network.netbridge_nsip_binding[] netbridge_nsip_binding
    {
      get => this.netbridge_nsip_bindingField;
      private set => this.netbridge_nsip_bindingField = value;
    }

    internal override base_resource[] get_nitro_response(
      nitro_service service,
      string response)
    {
      netbridge_binding.netbridge_binding_response netbridgeBindingResponse = new netbridge_binding.netbridge_binding_response();
      netbridge_binding.netbridge_binding_response resource = (netbridge_binding.netbridge_binding_response) service.get_payload_formatter().string_to_resource(netbridgeBindingResponse.GetType(), response);
      if (resource.errorcode != 0)
      {
        if (resource.errorcode == 444)
          service.clear_session();
        if (resource.severity == null)
          throw new nitro_exception(resource.message, resource.errorcode);
        if (resource.severity.Equals("ERROR"))
          throw new nitro_exception(resource.message, resource.errorcode);
      }
      return (base_resource[]) resource.netbridge_binding;
    }

    internal override string get_object_name() => this.name;

    public static netbridge_binding get(nitro_service service, string name) => (netbridge_binding) new netbridge_binding()
    {
      name = name
    }.get_resource(service);

    public static netbridge_binding[] get(nitro_service service, string[] name)
    {
      if (name == null || name.Length <= 0)
        return (netbridge_binding[]) null;
      netbridge_binding[] netbridgeBindingArray1 = new netbridge_binding[name.Length];
      netbridge_binding[] netbridgeBindingArray2 = new netbridge_binding[name.Length];
      for (int index = 0; index < name.Length; ++index)
      {
        netbridgeBindingArray2[index] = new netbridge_binding();
        netbridgeBindingArray2[index].name = name[index];
        netbridgeBindingArray1[index] = (netbridge_binding) netbridgeBindingArray2[index].get_resource(service);
      }
      return netbridgeBindingArray1;
    }

    private class netbridge_binding_response : base_response
    {
      public netbridge_binding[] netbridge_binding = (netbridge_binding[]) null;
    }
  }
}
