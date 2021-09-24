// Decompiled with JetBrains decompiler
// Type: com.citrix.netscaler.nitro.resource.config.authorization.authorizationpolicylabel_binding
// Assembly: nitro, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 6CF5DDEF-E052-4F9D-953F-6644F8378A66


using com.citrix.netscaler.nitro.exception;
using com.citrix.netscaler.nitro.resource.Base;
using com.citrix.netscaler.nitro.service;

namespace com.citrix.netscaler.nitro.resource.config.authorization
{
  public class authorizationpolicylabel_binding : base_resource
  {
    private string labelnameField = (string) null;
    private com.citrix.netscaler.nitro.resource.config.authorization.authorizationpolicylabel_authorizationpolicy_binding[] authorizationpolicylabel_authorizationpolicy_bindingField = (com.citrix.netscaler.nitro.resource.config.authorization.authorizationpolicylabel_authorizationpolicy_binding[]) null;

    public string labelname
    {
      get => this.labelnameField;
      set => this.labelnameField = value;
    }

    public com.citrix.netscaler.nitro.resource.config.authorization.authorizationpolicylabel_authorizationpolicy_binding[] authorizationpolicylabel_authorizationpolicy_binding
    {
      get => this.authorizationpolicylabel_authorizationpolicy_bindingField;
      private set => this.authorizationpolicylabel_authorizationpolicy_bindingField = value;
    }

    internal override base_resource[] get_nitro_response(
      nitro_service service,
      string response)
    {
      authorizationpolicylabel_binding.authorizationpolicylabel_binding_response authorizationpolicylabelBindingResponse = new authorizationpolicylabel_binding.authorizationpolicylabel_binding_response();
      authorizationpolicylabel_binding.authorizationpolicylabel_binding_response resource = (authorizationpolicylabel_binding.authorizationpolicylabel_binding_response) service.get_payload_formatter().string_to_resource(authorizationpolicylabelBindingResponse.GetType(), response);
      if (resource.errorcode != 0)
      {
        if (resource.errorcode == 444)
          service.clear_session();
        if (resource.severity == null)
          throw new nitro_exception(resource.message, resource.errorcode);
        if (resource.severity.Equals("ERROR"))
          throw new nitro_exception(resource.message, resource.errorcode);
      }
      return (base_resource[]) resource.authorizationpolicylabel_binding;
    }

    internal override string get_object_name() => this.labelname;

    public static authorizationpolicylabel_binding get(
      nitro_service service,
      string labelname)
    {
      return (authorizationpolicylabel_binding) new authorizationpolicylabel_binding()
      {
        labelname = labelname
      }.get_resource(service);
    }

    public static authorizationpolicylabel_binding[] get(
      nitro_service service,
      string[] labelname)
    {
      if (labelname == null || labelname.Length <= 0)
        return (authorizationpolicylabel_binding[]) null;
      authorizationpolicylabel_binding[] authorizationpolicylabelBindingArray1 = new authorizationpolicylabel_binding[labelname.Length];
      authorizationpolicylabel_binding[] authorizationpolicylabelBindingArray2 = new authorizationpolicylabel_binding[labelname.Length];
      for (int index = 0; index < labelname.Length; ++index)
      {
        authorizationpolicylabelBindingArray2[index] = new authorizationpolicylabel_binding();
        authorizationpolicylabelBindingArray2[index].labelname = labelname[index];
        authorizationpolicylabelBindingArray1[index] = (authorizationpolicylabel_binding) authorizationpolicylabelBindingArray2[index].get_resource(service);
      }
      return authorizationpolicylabelBindingArray1;
    }

    private class authorizationpolicylabel_binding_response : base_response
    {
      public authorizationpolicylabel_binding[] authorizationpolicylabel_binding = (authorizationpolicylabel_binding[]) null;
    }
  }
}
