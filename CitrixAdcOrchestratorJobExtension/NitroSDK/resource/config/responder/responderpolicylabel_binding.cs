// Decompiled with JetBrains decompiler
// Type: com.citrix.netscaler.nitro.resource.config.responder.responderpolicylabel_binding
// Assembly: nitro, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 6CF5DDEF-E052-4F9D-953F-6644F8378A66


using com.citrix.netscaler.nitro.exception;
using com.citrix.netscaler.nitro.resource.Base;
using com.citrix.netscaler.nitro.service;

namespace com.citrix.netscaler.nitro.resource.config.responder
{
  public class responderpolicylabel_binding : base_resource
  {
    private string labelnameField = (string) null;
    private com.citrix.netscaler.nitro.resource.config.responder.responderpolicylabel_policybinding_binding[] responderpolicylabel_policybinding_bindingField = (com.citrix.netscaler.nitro.resource.config.responder.responderpolicylabel_policybinding_binding[]) null;
    private com.citrix.netscaler.nitro.resource.config.responder.responderpolicylabel_responderpolicy_binding[] responderpolicylabel_responderpolicy_bindingField = (com.citrix.netscaler.nitro.resource.config.responder.responderpolicylabel_responderpolicy_binding[]) null;

    public string labelname
    {
      get => this.labelnameField;
      set => this.labelnameField = value;
    }

    public com.citrix.netscaler.nitro.resource.config.responder.responderpolicylabel_responderpolicy_binding[] responderpolicylabel_responderpolicy_binding
    {
      get => this.responderpolicylabel_responderpolicy_bindingField;
      private set => this.responderpolicylabel_responderpolicy_bindingField = value;
    }

    public com.citrix.netscaler.nitro.resource.config.responder.responderpolicylabel_policybinding_binding[] responderpolicylabel_policybinding_binding
    {
      get => this.responderpolicylabel_policybinding_bindingField;
      private set => this.responderpolicylabel_policybinding_bindingField = value;
    }

    internal override base_resource[] get_nitro_response(
      nitro_service service,
      string response)
    {
      responderpolicylabel_binding.responderpolicylabel_binding_response responderpolicylabelBindingResponse = new responderpolicylabel_binding.responderpolicylabel_binding_response();
      responderpolicylabel_binding.responderpolicylabel_binding_response resource = (responderpolicylabel_binding.responderpolicylabel_binding_response) service.get_payload_formatter().string_to_resource(responderpolicylabelBindingResponse.GetType(), response);
      if (resource.errorcode != 0)
      {
        if (resource.errorcode == 444)
          service.clear_session();
        if (resource.severity == null)
          throw new nitro_exception(resource.message, resource.errorcode);
        if (resource.severity.Equals("ERROR"))
          throw new nitro_exception(resource.message, resource.errorcode);
      }
      return (base_resource[]) resource.responderpolicylabel_binding;
    }

    internal override string get_object_name() => this.labelname;

    public static responderpolicylabel_binding get(
      nitro_service service,
      string labelname)
    {
      return (responderpolicylabel_binding) new responderpolicylabel_binding()
      {
        labelname = labelname
      }.get_resource(service);
    }

    public static responderpolicylabel_binding[] get(
      nitro_service service,
      string[] labelname)
    {
      if (labelname == null || labelname.Length <= 0)
        return (responderpolicylabel_binding[]) null;
      responderpolicylabel_binding[] responderpolicylabelBindingArray1 = new responderpolicylabel_binding[labelname.Length];
      responderpolicylabel_binding[] responderpolicylabelBindingArray2 = new responderpolicylabel_binding[labelname.Length];
      for (int index = 0; index < labelname.Length; ++index)
      {
        responderpolicylabelBindingArray2[index] = new responderpolicylabel_binding();
        responderpolicylabelBindingArray2[index].labelname = labelname[index];
        responderpolicylabelBindingArray1[index] = (responderpolicylabel_binding) responderpolicylabelBindingArray2[index].get_resource(service);
      }
      return responderpolicylabelBindingArray1;
    }

    private class responderpolicylabel_binding_response : base_response
    {
      public responderpolicylabel_binding[] responderpolicylabel_binding = (responderpolicylabel_binding[]) null;
    }
  }
}
