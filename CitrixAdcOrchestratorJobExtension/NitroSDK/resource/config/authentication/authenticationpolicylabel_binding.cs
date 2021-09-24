// Decompiled with JetBrains decompiler
// Type: com.citrix.netscaler.nitro.resource.config.authentication.authenticationpolicylabel_binding
// Assembly: nitro, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 6CF5DDEF-E052-4F9D-953F-6644F8378A66


using com.citrix.netscaler.nitro.exception;
using com.citrix.netscaler.nitro.resource.Base;
using com.citrix.netscaler.nitro.service;

namespace com.citrix.netscaler.nitro.resource.config.authentication
{
  public class authenticationpolicylabel_binding : base_resource
  {
    private string labelnameField = (string) null;
    private com.citrix.netscaler.nitro.resource.config.authentication.authenticationpolicylabel_authenticationpolicy_binding[] authenticationpolicylabel_authenticationpolicy_bindingField = (com.citrix.netscaler.nitro.resource.config.authentication.authenticationpolicylabel_authenticationpolicy_binding[]) null;

    public string labelname
    {
      get => this.labelnameField;
      set => this.labelnameField = value;
    }

    public com.citrix.netscaler.nitro.resource.config.authentication.authenticationpolicylabel_authenticationpolicy_binding[] authenticationpolicylabel_authenticationpolicy_binding
    {
      get => this.authenticationpolicylabel_authenticationpolicy_bindingField;
      private set => this.authenticationpolicylabel_authenticationpolicy_bindingField = value;
    }

    internal override base_resource[] get_nitro_response(
      nitro_service service,
      string response)
    {
      authenticationpolicylabel_binding.authenticationpolicylabel_binding_response authenticationpolicylabelBindingResponse = new authenticationpolicylabel_binding.authenticationpolicylabel_binding_response();
      authenticationpolicylabel_binding.authenticationpolicylabel_binding_response resource = (authenticationpolicylabel_binding.authenticationpolicylabel_binding_response) service.get_payload_formatter().string_to_resource(authenticationpolicylabelBindingResponse.GetType(), response);
      if (resource.errorcode != 0)
      {
        if (resource.errorcode == 444)
          service.clear_session();
        if (resource.severity == null)
          throw new nitro_exception(resource.message, resource.errorcode);
        if (resource.severity.Equals("ERROR"))
          throw new nitro_exception(resource.message, resource.errorcode);
      }
      return (base_resource[]) resource.authenticationpolicylabel_binding;
    }

    internal override string get_object_name() => this.labelname;

    public static authenticationpolicylabel_binding get(
      nitro_service service,
      string labelname)
    {
      return (authenticationpolicylabel_binding) new authenticationpolicylabel_binding()
      {
        labelname = labelname
      }.get_resource(service);
    }

    public static authenticationpolicylabel_binding[] get(
      nitro_service service,
      string[] labelname)
    {
      if (labelname == null || labelname.Length <= 0)
        return (authenticationpolicylabel_binding[]) null;
      authenticationpolicylabel_binding[] authenticationpolicylabelBindingArray1 = new authenticationpolicylabel_binding[labelname.Length];
      authenticationpolicylabel_binding[] authenticationpolicylabelBindingArray2 = new authenticationpolicylabel_binding[labelname.Length];
      for (int index = 0; index < labelname.Length; ++index)
      {
        authenticationpolicylabelBindingArray2[index] = new authenticationpolicylabel_binding();
        authenticationpolicylabelBindingArray2[index].labelname = labelname[index];
        authenticationpolicylabelBindingArray1[index] = (authenticationpolicylabel_binding) authenticationpolicylabelBindingArray2[index].get_resource(service);
      }
      return authenticationpolicylabelBindingArray1;
    }

    private class authenticationpolicylabel_binding_response : base_response
    {
      public authenticationpolicylabel_binding[] authenticationpolicylabel_binding = (authenticationpolicylabel_binding[]) null;
    }
  }
}
