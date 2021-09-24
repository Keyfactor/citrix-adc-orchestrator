// Decompiled with JetBrains decompiler
// Type: com.citrix.netscaler.nitro.resource.config.aaa.aaapreauthenticationpolicy_binding
// Assembly: nitro, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 6CF5DDEF-E052-4F9D-953F-6644F8378A66


using com.citrix.netscaler.nitro.exception;
using com.citrix.netscaler.nitro.resource.Base;
using com.citrix.netscaler.nitro.service;

namespace com.citrix.netscaler.nitro.resource.config.aaa
{
  public class aaapreauthenticationpolicy_binding : base_resource
  {
    private string nameField = (string) null;
    private com.citrix.netscaler.nitro.resource.config.aaa.aaapreauthenticationpolicy_vpnvserver_binding[] aaapreauthenticationpolicy_vpnvserver_bindingField = (com.citrix.netscaler.nitro.resource.config.aaa.aaapreauthenticationpolicy_vpnvserver_binding[]) null;
    private com.citrix.netscaler.nitro.resource.config.aaa.aaapreauthenticationpolicy_aaaglobal_binding[] aaapreauthenticationpolicy_aaaglobal_bindingField = (com.citrix.netscaler.nitro.resource.config.aaa.aaapreauthenticationpolicy_aaaglobal_binding[]) null;

    public string name
    {
      get => this.nameField;
      set => this.nameField = value;
    }

    public com.citrix.netscaler.nitro.resource.config.aaa.aaapreauthenticationpolicy_vpnvserver_binding[] aaapreauthenticationpolicy_vpnvserver_binding
    {
      get => this.aaapreauthenticationpolicy_vpnvserver_bindingField;
      private set => this.aaapreauthenticationpolicy_vpnvserver_bindingField = value;
    }

    public com.citrix.netscaler.nitro.resource.config.aaa.aaapreauthenticationpolicy_aaaglobal_binding[] aaapreauthenticationpolicy_aaaglobal_binding
    {
      get => this.aaapreauthenticationpolicy_aaaglobal_bindingField;
      private set => this.aaapreauthenticationpolicy_aaaglobal_bindingField = value;
    }

    internal override base_resource[] get_nitro_response(
      nitro_service service,
      string response)
    {
      aaapreauthenticationpolicy_binding.aaapreauthenticationpolicy_binding_response aaapreauthenticationpolicyBindingResponse = new aaapreauthenticationpolicy_binding.aaapreauthenticationpolicy_binding_response();
      aaapreauthenticationpolicy_binding.aaapreauthenticationpolicy_binding_response resource = (aaapreauthenticationpolicy_binding.aaapreauthenticationpolicy_binding_response) service.get_payload_formatter().string_to_resource(aaapreauthenticationpolicyBindingResponse.GetType(), response);
      if (resource.errorcode != 0)
      {
        if (resource.errorcode == 444)
          service.clear_session();
        if (resource.severity == null)
          throw new nitro_exception(resource.message, resource.errorcode);
        if (resource.severity.Equals("ERROR"))
          throw new nitro_exception(resource.message, resource.errorcode);
      }
      return (base_resource[]) resource.aaapreauthenticationpolicy_binding;
    }

    internal override string get_object_name() => this.name;

    public static aaapreauthenticationpolicy_binding get(
      nitro_service service,
      string name)
    {
      return (aaapreauthenticationpolicy_binding) new aaapreauthenticationpolicy_binding()
      {
        name = name
      }.get_resource(service);
    }

    public static aaapreauthenticationpolicy_binding[] get(
      nitro_service service,
      string[] name)
    {
      if (name == null || name.Length <= 0)
        return (aaapreauthenticationpolicy_binding[]) null;
      aaapreauthenticationpolicy_binding[] aaapreauthenticationpolicyBindingArray1 = new aaapreauthenticationpolicy_binding[name.Length];
      aaapreauthenticationpolicy_binding[] aaapreauthenticationpolicyBindingArray2 = new aaapreauthenticationpolicy_binding[name.Length];
      for (int index = 0; index < name.Length; ++index)
      {
        aaapreauthenticationpolicyBindingArray2[index] = new aaapreauthenticationpolicy_binding();
        aaapreauthenticationpolicyBindingArray2[index].name = name[index];
        aaapreauthenticationpolicyBindingArray1[index] = (aaapreauthenticationpolicy_binding) aaapreauthenticationpolicyBindingArray2[index].get_resource(service);
      }
      return aaapreauthenticationpolicyBindingArray1;
    }

    private class aaapreauthenticationpolicy_binding_response : base_response
    {
      public aaapreauthenticationpolicy_binding[] aaapreauthenticationpolicy_binding = (aaapreauthenticationpolicy_binding[]) null;
    }
  }
}
