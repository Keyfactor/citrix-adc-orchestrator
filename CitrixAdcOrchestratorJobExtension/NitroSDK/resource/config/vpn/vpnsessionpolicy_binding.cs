// Decompiled with JetBrains decompiler
// Type: com.citrix.netscaler.nitro.resource.config.vpn.vpnsessionpolicy_binding
// Assembly: nitro, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 6CF5DDEF-E052-4F9D-953F-6644F8378A66


using com.citrix.netscaler.nitro.exception;
using com.citrix.netscaler.nitro.resource.Base;
using com.citrix.netscaler.nitro.service;

namespace com.citrix.netscaler.nitro.resource.config.vpn
{
  public class vpnsessionpolicy_binding : base_resource
  {
    private string nameField = (string) null;
    private com.citrix.netscaler.nitro.resource.config.vpn.vpnsessionpolicy_aaauser_binding[] vpnsessionpolicy_aaauser_bindingField = (com.citrix.netscaler.nitro.resource.config.vpn.vpnsessionpolicy_aaauser_binding[]) null;
    private com.citrix.netscaler.nitro.resource.config.vpn.vpnsessionpolicy_vpnglobal_binding[] vpnsessionpolicy_vpnglobal_bindingField = (com.citrix.netscaler.nitro.resource.config.vpn.vpnsessionpolicy_vpnglobal_binding[]) null;
    private com.citrix.netscaler.nitro.resource.config.vpn.vpnsessionpolicy_vpnvserver_binding[] vpnsessionpolicy_vpnvserver_bindingField = (com.citrix.netscaler.nitro.resource.config.vpn.vpnsessionpolicy_vpnvserver_binding[]) null;
    private com.citrix.netscaler.nitro.resource.config.vpn.vpnsessionpolicy_aaagroup_binding[] vpnsessionpolicy_aaagroup_bindingField = (com.citrix.netscaler.nitro.resource.config.vpn.vpnsessionpolicy_aaagroup_binding[]) null;

    public string name
    {
      get => this.nameField;
      set => this.nameField = value;
    }

    public com.citrix.netscaler.nitro.resource.config.vpn.vpnsessionpolicy_aaauser_binding[] vpnsessionpolicy_aaauser_binding
    {
      get => this.vpnsessionpolicy_aaauser_bindingField;
      private set => this.vpnsessionpolicy_aaauser_bindingField = value;
    }

    public com.citrix.netscaler.nitro.resource.config.vpn.vpnsessionpolicy_vpnglobal_binding[] vpnsessionpolicy_vpnglobal_binding
    {
      get => this.vpnsessionpolicy_vpnglobal_bindingField;
      private set => this.vpnsessionpolicy_vpnglobal_bindingField = value;
    }

    public com.citrix.netscaler.nitro.resource.config.vpn.vpnsessionpolicy_vpnvserver_binding[] vpnsessionpolicy_vpnvserver_binding
    {
      get => this.vpnsessionpolicy_vpnvserver_bindingField;
      private set => this.vpnsessionpolicy_vpnvserver_bindingField = value;
    }

    public com.citrix.netscaler.nitro.resource.config.vpn.vpnsessionpolicy_aaagroup_binding[] vpnsessionpolicy_aaagroup_binding
    {
      get => this.vpnsessionpolicy_aaagroup_bindingField;
      private set => this.vpnsessionpolicy_aaagroup_bindingField = value;
    }

    internal override base_resource[] get_nitro_response(
      nitro_service service,
      string response)
    {
      vpnsessionpolicy_binding.vpnsessionpolicy_binding_response vpnsessionpolicyBindingResponse = new vpnsessionpolicy_binding.vpnsessionpolicy_binding_response();
      vpnsessionpolicy_binding.vpnsessionpolicy_binding_response resource = (vpnsessionpolicy_binding.vpnsessionpolicy_binding_response) service.get_payload_formatter().string_to_resource(vpnsessionpolicyBindingResponse.GetType(), response);
      if (resource.errorcode != 0)
      {
        if (resource.errorcode == 444)
          service.clear_session();
        if (resource.severity == null)
          throw new nitro_exception(resource.message, resource.errorcode);
        if (resource.severity.Equals("ERROR"))
          throw new nitro_exception(resource.message, resource.errorcode);
      }
      return (base_resource[]) resource.vpnsessionpolicy_binding;
    }

    internal override string get_object_name() => this.name;

    public static vpnsessionpolicy_binding get(
      nitro_service service,
      string name)
    {
      return (vpnsessionpolicy_binding) new vpnsessionpolicy_binding()
      {
        name = name
      }.get_resource(service);
    }

    public static vpnsessionpolicy_binding[] get(
      nitro_service service,
      string[] name)
    {
      if (name == null || name.Length <= 0)
        return (vpnsessionpolicy_binding[]) null;
      vpnsessionpolicy_binding[] vpnsessionpolicyBindingArray1 = new vpnsessionpolicy_binding[name.Length];
      vpnsessionpolicy_binding[] vpnsessionpolicyBindingArray2 = new vpnsessionpolicy_binding[name.Length];
      for (int index = 0; index < name.Length; ++index)
      {
        vpnsessionpolicyBindingArray2[index] = new vpnsessionpolicy_binding();
        vpnsessionpolicyBindingArray2[index].name = name[index];
        vpnsessionpolicyBindingArray1[index] = (vpnsessionpolicy_binding) vpnsessionpolicyBindingArray2[index].get_resource(service);
      }
      return vpnsessionpolicyBindingArray1;
    }

    private class vpnsessionpolicy_binding_response : base_response
    {
      public vpnsessionpolicy_binding[] vpnsessionpolicy_binding = (vpnsessionpolicy_binding[]) null;
    }
  }
}
