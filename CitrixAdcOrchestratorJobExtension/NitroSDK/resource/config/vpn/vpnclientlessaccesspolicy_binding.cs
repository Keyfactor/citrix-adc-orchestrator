// Decompiled with JetBrains decompiler
// Type: com.citrix.netscaler.nitro.resource.config.vpn.vpnclientlessaccesspolicy_binding
// Assembly: nitro, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 6CF5DDEF-E052-4F9D-953F-6644F8378A66


using com.citrix.netscaler.nitro.exception;
using com.citrix.netscaler.nitro.resource.Base;
using com.citrix.netscaler.nitro.service;

namespace com.citrix.netscaler.nitro.resource.config.vpn
{
  public class vpnclientlessaccesspolicy_binding : base_resource
  {
    private string nameField = (string) null;
    private com.citrix.netscaler.nitro.resource.config.vpn.vpnclientlessaccesspolicy_vpnglobal_binding[] vpnclientlessaccesspolicy_vpnglobal_bindingField = (com.citrix.netscaler.nitro.resource.config.vpn.vpnclientlessaccesspolicy_vpnglobal_binding[]) null;
    private com.citrix.netscaler.nitro.resource.config.vpn.vpnclientlessaccesspolicy_vpnvserver_binding[] vpnclientlessaccesspolicy_vpnvserver_bindingField = (com.citrix.netscaler.nitro.resource.config.vpn.vpnclientlessaccesspolicy_vpnvserver_binding[]) null;

    public string name
    {
      get => this.nameField;
      set => this.nameField = value;
    }

    public com.citrix.netscaler.nitro.resource.config.vpn.vpnclientlessaccesspolicy_vpnglobal_binding[] vpnclientlessaccesspolicy_vpnglobal_binding
    {
      get => this.vpnclientlessaccesspolicy_vpnglobal_bindingField;
      private set => this.vpnclientlessaccesspolicy_vpnglobal_bindingField = value;
    }

    public com.citrix.netscaler.nitro.resource.config.vpn.vpnclientlessaccesspolicy_vpnvserver_binding[] vpnclientlessaccesspolicy_vpnvserver_binding
    {
      get => this.vpnclientlessaccesspolicy_vpnvserver_bindingField;
      private set => this.vpnclientlessaccesspolicy_vpnvserver_bindingField = value;
    }

    internal override base_resource[] get_nitro_response(
      nitro_service service,
      string response)
    {
      vpnclientlessaccesspolicy_binding.vpnclientlessaccesspolicy_binding_response vpnclientlessaccesspolicyBindingResponse = new vpnclientlessaccesspolicy_binding.vpnclientlessaccesspolicy_binding_response();
      vpnclientlessaccesspolicy_binding.vpnclientlessaccesspolicy_binding_response resource = (vpnclientlessaccesspolicy_binding.vpnclientlessaccesspolicy_binding_response) service.get_payload_formatter().string_to_resource(vpnclientlessaccesspolicyBindingResponse.GetType(), response);
      if (resource.errorcode != 0)
      {
        if (resource.errorcode == 444)
          service.clear_session();
        if (resource.severity == null)
          throw new nitro_exception(resource.message, resource.errorcode);
        if (resource.severity.Equals("ERROR"))
          throw new nitro_exception(resource.message, resource.errorcode);
      }
      return (base_resource[]) resource.vpnclientlessaccesspolicy_binding;
    }

    internal override string get_object_name() => this.name;

    public static vpnclientlessaccesspolicy_binding get(
      nitro_service service,
      string name)
    {
      return (vpnclientlessaccesspolicy_binding) new vpnclientlessaccesspolicy_binding()
      {
        name = name
      }.get_resource(service);
    }

    public static vpnclientlessaccesspolicy_binding[] get(
      nitro_service service,
      string[] name)
    {
      if (name == null || name.Length <= 0)
        return (vpnclientlessaccesspolicy_binding[]) null;
      vpnclientlessaccesspolicy_binding[] vpnclientlessaccesspolicyBindingArray1 = new vpnclientlessaccesspolicy_binding[name.Length];
      vpnclientlessaccesspolicy_binding[] vpnclientlessaccesspolicyBindingArray2 = new vpnclientlessaccesspolicy_binding[name.Length];
      for (int index = 0; index < name.Length; ++index)
      {
        vpnclientlessaccesspolicyBindingArray2[index] = new vpnclientlessaccesspolicy_binding();
        vpnclientlessaccesspolicyBindingArray2[index].name = name[index];
        vpnclientlessaccesspolicyBindingArray1[index] = (vpnclientlessaccesspolicy_binding) vpnclientlessaccesspolicyBindingArray2[index].get_resource(service);
      }
      return vpnclientlessaccesspolicyBindingArray1;
    }

    private class vpnclientlessaccesspolicy_binding_response : base_response
    {
      public vpnclientlessaccesspolicy_binding[] vpnclientlessaccesspolicy_binding = (vpnclientlessaccesspolicy_binding[]) null;
    }
  }
}
