// Decompiled with JetBrains decompiler
// Type: com.citrix.netscaler.nitro.resource.config.aaa.aaaglobal_binding
// Assembly: nitro, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 6CF5DDEF-E052-4F9D-953F-6644F8378A66


using com.citrix.netscaler.nitro.exception;
using com.citrix.netscaler.nitro.resource.Base;
using com.citrix.netscaler.nitro.service;

namespace com.citrix.netscaler.nitro.resource.config.aaa
{
  public class aaaglobal_binding : base_resource
  {
    private com.citrix.netscaler.nitro.resource.config.aaa.aaaglobal_authenticationnegotiateaction_binding[] aaaglobal_authenticationnegotiateaction_bindingField = (com.citrix.netscaler.nitro.resource.config.aaa.aaaglobal_authenticationnegotiateaction_binding[]) null;
    private com.citrix.netscaler.nitro.resource.config.aaa.aaaglobal_aaapreauthenticationpolicy_binding[] aaaglobal_aaapreauthenticationpolicy_bindingField = (com.citrix.netscaler.nitro.resource.config.aaa.aaaglobal_aaapreauthenticationpolicy_binding[]) null;

    public com.citrix.netscaler.nitro.resource.config.aaa.aaaglobal_authenticationnegotiateaction_binding[] aaaglobal_authenticationnegotiateaction_binding
    {
      get => this.aaaglobal_authenticationnegotiateaction_bindingField;
      private set => this.aaaglobal_authenticationnegotiateaction_bindingField = value;
    }

    public com.citrix.netscaler.nitro.resource.config.aaa.aaaglobal_aaapreauthenticationpolicy_binding[] aaaglobal_aaapreauthenticationpolicy_binding
    {
      get => this.aaaglobal_aaapreauthenticationpolicy_bindingField;
      private set => this.aaaglobal_aaapreauthenticationpolicy_bindingField = value;
    }

    internal override base_resource[] get_nitro_response(
      nitro_service service,
      string response)
    {
      aaaglobal_binding.aaaglobal_binding_response aaaglobalBindingResponse = new aaaglobal_binding.aaaglobal_binding_response();
      aaaglobal_binding.aaaglobal_binding_response resource = (aaaglobal_binding.aaaglobal_binding_response) service.get_payload_formatter().string_to_resource(aaaglobalBindingResponse.GetType(), response);
      if (resource.errorcode != 0)
      {
        if (resource.errorcode == 444)
          service.clear_session();
        if (resource.severity == null)
          throw new nitro_exception(resource.message, resource.errorcode);
        if (resource.severity.Equals("ERROR"))
          throw new nitro_exception(resource.message, resource.errorcode);
      }
      return (base_resource[]) resource.aaaglobal_binding;
    }

    internal override string get_object_name() => (string) null;

    public static aaaglobal_binding get(nitro_service service) => (aaaglobal_binding) new aaaglobal_binding().get_resource(service);

    private class aaaglobal_binding_response : base_response
    {
      public aaaglobal_binding[] aaaglobal_binding = (aaaglobal_binding[]) null;
    }
  }
}
