// Decompiled with JetBrains decompiler
// Type: com.citrix.netscaler.nitro.resource.config.network.nd6ravariables_binding
// Assembly: nitro, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 6CF5DDEF-E052-4F9D-953F-6644F8378A66


using com.citrix.netscaler.nitro.exception;
using com.citrix.netscaler.nitro.resource.Base;
using com.citrix.netscaler.nitro.service;

namespace com.citrix.netscaler.nitro.resource.config.network
{
  public class nd6ravariables_binding : base_resource
  {
    private uint? vlanField = new uint?();
    private com.citrix.netscaler.nitro.resource.config.network.nd6ravariables_onlinkipv6prefix_binding[] nd6ravariables_onlinkipv6prefix_bindingField = (com.citrix.netscaler.nitro.resource.config.network.nd6ravariables_onlinkipv6prefix_binding[]) null;

    public uint? vlan
    {
      get => this.vlanField;
      set => this.vlanField = value;
    }

    public com.citrix.netscaler.nitro.resource.config.network.nd6ravariables_onlinkipv6prefix_binding[] nd6ravariables_onlinkipv6prefix_binding
    {
      get => this.nd6ravariables_onlinkipv6prefix_bindingField;
      private set => this.nd6ravariables_onlinkipv6prefix_bindingField = value;
    }

    internal override base_resource[] get_nitro_response(
      nitro_service service,
      string response)
    {
      nd6ravariables_binding.nd6ravariables_binding_response nd6ravariablesBindingResponse = new nd6ravariables_binding.nd6ravariables_binding_response();
      nd6ravariables_binding.nd6ravariables_binding_response resource = (nd6ravariables_binding.nd6ravariables_binding_response) service.get_payload_formatter().string_to_resource(nd6ravariablesBindingResponse.GetType(), response);
      if (resource.errorcode != 0)
      {
        if (resource.errorcode == 444)
          service.clear_session();
        if (resource.severity == null)
          throw new nitro_exception(resource.message, resource.errorcode);
        if (resource.severity.Equals("ERROR"))
          throw new nitro_exception(resource.message, resource.errorcode);
      }
      return (base_resource[]) resource.nd6ravariables_binding;
    }

    internal override string get_object_name() => this.vlan.HasValue ? this.vlan.ToString() : (string) null;

    public static nd6ravariables_binding get(
      nitro_service service,
      uint? vlan)
    {
      return (nd6ravariables_binding) new nd6ravariables_binding()
      {
        vlan = vlan
      }.get_resource(service);
    }

    public static nd6ravariables_binding[] get(
      nitro_service service,
      uint?[] vlan)
    {
      if (vlan == null || vlan.Length <= 0)
        return (nd6ravariables_binding[]) null;
      nd6ravariables_binding[] nd6ravariablesBindingArray1 = new nd6ravariables_binding[vlan.Length];
      nd6ravariables_binding[] nd6ravariablesBindingArray2 = new nd6ravariables_binding[vlan.Length];
      for (int index = 0; index < vlan.Length; ++index)
      {
        nd6ravariablesBindingArray2[index] = new nd6ravariables_binding();
        nd6ravariablesBindingArray2[index].vlan = vlan[index];
        nd6ravariablesBindingArray1[index] = (nd6ravariables_binding) nd6ravariablesBindingArray2[index].get_resource(service);
      }
      return nd6ravariablesBindingArray1;
    }

    private class nd6ravariables_binding_response : base_response
    {
      public nd6ravariables_binding[] nd6ravariables_binding = (nd6ravariables_binding[]) null;
    }
  }
}
