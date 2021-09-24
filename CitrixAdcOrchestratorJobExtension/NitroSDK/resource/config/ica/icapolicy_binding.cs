// Decompiled with JetBrains decompiler
// Type: com.citrix.netscaler.nitro.resource.config.ica.icapolicy_binding
// Assembly: nitro, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 6CF5DDEF-E052-4F9D-953F-6644F8378A66


using com.citrix.netscaler.nitro.exception;
using com.citrix.netscaler.nitro.resource.Base;
using com.citrix.netscaler.nitro.service;

namespace com.citrix.netscaler.nitro.resource.config.ica
{
  public class icapolicy_binding : base_resource
  {
    private string nameField = (string) null;
    private com.citrix.netscaler.nitro.resource.config.ica.icapolicy_vpnvserver_binding[] icapolicy_vpnvserver_bindingField = (com.citrix.netscaler.nitro.resource.config.ica.icapolicy_vpnvserver_binding[]) null;
    private com.citrix.netscaler.nitro.resource.config.ica.icapolicy_icaglobal_binding[] icapolicy_icaglobal_bindingField = (com.citrix.netscaler.nitro.resource.config.ica.icapolicy_icaglobal_binding[]) null;
    private com.citrix.netscaler.nitro.resource.config.ica.icapolicy_crvserver_binding[] icapolicy_crvserver_bindingField = (com.citrix.netscaler.nitro.resource.config.ica.icapolicy_crvserver_binding[]) null;

    public string name
    {
      get => this.nameField;
      set => this.nameField = value;
    }

    public com.citrix.netscaler.nitro.resource.config.ica.icapolicy_crvserver_binding[] icapolicy_crvserver_binding
    {
      get => this.icapolicy_crvserver_bindingField;
      private set => this.icapolicy_crvserver_bindingField = value;
    }

    public com.citrix.netscaler.nitro.resource.config.ica.icapolicy_icaglobal_binding[] icapolicy_icaglobal_binding
    {
      get => this.icapolicy_icaglobal_bindingField;
      private set => this.icapolicy_icaglobal_bindingField = value;
    }

    public com.citrix.netscaler.nitro.resource.config.ica.icapolicy_vpnvserver_binding[] icapolicy_vpnvserver_binding
    {
      get => this.icapolicy_vpnvserver_bindingField;
      private set => this.icapolicy_vpnvserver_bindingField = value;
    }

    internal override base_resource[] get_nitro_response(
      nitro_service service,
      string response)
    {
      icapolicy_binding.icapolicy_binding_response icapolicyBindingResponse = new icapolicy_binding.icapolicy_binding_response();
      icapolicy_binding.icapolicy_binding_response resource = (icapolicy_binding.icapolicy_binding_response) service.get_payload_formatter().string_to_resource(icapolicyBindingResponse.GetType(), response);
      if (resource.errorcode != 0)
      {
        if (resource.errorcode == 444)
          service.clear_session();
        if (resource.severity == null)
          throw new nitro_exception(resource.message, resource.errorcode);
        if (resource.severity.Equals("ERROR"))
          throw new nitro_exception(resource.message, resource.errorcode);
      }
      return (base_resource[]) resource.icapolicy_binding;
    }

    internal override string get_object_name() => this.name;

    public static icapolicy_binding get(nitro_service service, string name) => (icapolicy_binding) new icapolicy_binding()
    {
      name = name
    }.get_resource(service);

    public static icapolicy_binding[] get(nitro_service service, string[] name)
    {
      if (name == null || name.Length <= 0)
        return (icapolicy_binding[]) null;
      icapolicy_binding[] icapolicyBindingArray1 = new icapolicy_binding[name.Length];
      icapolicy_binding[] icapolicyBindingArray2 = new icapolicy_binding[name.Length];
      for (int index = 0; index < name.Length; ++index)
      {
        icapolicyBindingArray2[index] = new icapolicy_binding();
        icapolicyBindingArray2[index].name = name[index];
        icapolicyBindingArray1[index] = (icapolicy_binding) icapolicyBindingArray2[index].get_resource(service);
      }
      return icapolicyBindingArray1;
    }

    private class icapolicy_binding_response : base_response
    {
      public icapolicy_binding[] icapolicy_binding = (icapolicy_binding[]) null;
    }
  }
}
