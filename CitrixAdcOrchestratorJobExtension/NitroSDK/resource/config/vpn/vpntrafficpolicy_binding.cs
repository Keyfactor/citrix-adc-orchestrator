// Decompiled with JetBrains decompiler
// Type: com.citrix.netscaler.nitro.resource.config.vpn.vpntrafficpolicy_binding
// Assembly: nitro, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 6CF5DDEF-E052-4F9D-953F-6644F8378A66


using com.citrix.netscaler.nitro.exception;
using com.citrix.netscaler.nitro.resource.Base;
using com.citrix.netscaler.nitro.service;

namespace com.citrix.netscaler.nitro.resource.config.vpn
{
  public class vpntrafficpolicy_binding : base_resource
  {
    private string nameField = (string) null;
    private com.citrix.netscaler.nitro.resource.config.vpn.vpntrafficpolicy_aaauser_binding[] vpntrafficpolicy_aaauser_bindingField = (com.citrix.netscaler.nitro.resource.config.vpn.vpntrafficpolicy_aaauser_binding[]) null;
    private com.citrix.netscaler.nitro.resource.config.vpn.vpntrafficpolicy_vpnglobal_binding[] vpntrafficpolicy_vpnglobal_bindingField = (com.citrix.netscaler.nitro.resource.config.vpn.vpntrafficpolicy_vpnglobal_binding[]) null;
    private com.citrix.netscaler.nitro.resource.config.vpn.vpntrafficpolicy_vpnvserver_binding[] vpntrafficpolicy_vpnvserver_bindingField = (com.citrix.netscaler.nitro.resource.config.vpn.vpntrafficpolicy_vpnvserver_binding[]) null;
    private com.citrix.netscaler.nitro.resource.config.vpn.vpntrafficpolicy_aaagroup_binding[] vpntrafficpolicy_aaagroup_bindingField = (com.citrix.netscaler.nitro.resource.config.vpn.vpntrafficpolicy_aaagroup_binding[]) null;

    public string name
    {
      get => this.nameField;
      set => this.nameField = value;
    }

    public com.citrix.netscaler.nitro.resource.config.vpn.vpntrafficpolicy_aaagroup_binding[] vpntrafficpolicy_aaagroup_binding
    {
      get => this.vpntrafficpolicy_aaagroup_bindingField;
      private set => this.vpntrafficpolicy_aaagroup_bindingField = value;
    }

    public com.citrix.netscaler.nitro.resource.config.vpn.vpntrafficpolicy_aaauser_binding[] vpntrafficpolicy_aaauser_binding
    {
      get => this.vpntrafficpolicy_aaauser_bindingField;
      private set => this.vpntrafficpolicy_aaauser_bindingField = value;
    }

    public com.citrix.netscaler.nitro.resource.config.vpn.vpntrafficpolicy_vpnvserver_binding[] vpntrafficpolicy_vpnvserver_binding
    {
      get => this.vpntrafficpolicy_vpnvserver_bindingField;
      private set => this.vpntrafficpolicy_vpnvserver_bindingField = value;
    }

    public com.citrix.netscaler.nitro.resource.config.vpn.vpntrafficpolicy_vpnglobal_binding[] vpntrafficpolicy_vpnglobal_binding
    {
      get => this.vpntrafficpolicy_vpnglobal_bindingField;
      private set => this.vpntrafficpolicy_vpnglobal_bindingField = value;
    }

    internal override base_resource[] get_nitro_response(
      nitro_service service,
      string response)
    {
      vpntrafficpolicy_binding.vpntrafficpolicy_binding_response vpntrafficpolicyBindingResponse = new vpntrafficpolicy_binding.vpntrafficpolicy_binding_response();
      vpntrafficpolicy_binding.vpntrafficpolicy_binding_response resource = (vpntrafficpolicy_binding.vpntrafficpolicy_binding_response) service.get_payload_formatter().string_to_resource(vpntrafficpolicyBindingResponse.GetType(), response);
      if (resource.errorcode != 0)
      {
        if (resource.errorcode == 444)
          service.clear_session();
        if (resource.severity == null)
          throw new nitro_exception(resource.message, resource.errorcode);
        if (resource.severity.Equals("ERROR"))
          throw new nitro_exception(resource.message, resource.errorcode);
      }
      return (base_resource[]) resource.vpntrafficpolicy_binding;
    }

    internal override string get_object_name() => this.name;

    public static vpntrafficpolicy_binding get(
      nitro_service service,
      string name)
    {
      return (vpntrafficpolicy_binding) new vpntrafficpolicy_binding()
      {
        name = name
      }.get_resource(service);
    }

    public static vpntrafficpolicy_binding[] get(
      nitro_service service,
      string[] name)
    {
      if (name == null || name.Length <= 0)
        return (vpntrafficpolicy_binding[]) null;
      vpntrafficpolicy_binding[] vpntrafficpolicyBindingArray1 = new vpntrafficpolicy_binding[name.Length];
      vpntrafficpolicy_binding[] vpntrafficpolicyBindingArray2 = new vpntrafficpolicy_binding[name.Length];
      for (int index = 0; index < name.Length; ++index)
      {
        vpntrafficpolicyBindingArray2[index] = new vpntrafficpolicy_binding();
        vpntrafficpolicyBindingArray2[index].name = name[index];
        vpntrafficpolicyBindingArray1[index] = (vpntrafficpolicy_binding) vpntrafficpolicyBindingArray2[index].get_resource(service);
      }
      return vpntrafficpolicyBindingArray1;
    }

    private class vpntrafficpolicy_binding_response : base_response
    {
      public vpntrafficpolicy_binding[] vpntrafficpolicy_binding = (vpntrafficpolicy_binding[]) null;
    }
  }
}
