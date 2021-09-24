// Decompiled with JetBrains decompiler
// Type: com.citrix.netscaler.nitro.resource.config.responder.responderpolicy_binding
// Assembly: nitro, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 6CF5DDEF-E052-4F9D-953F-6644F8378A66


using com.citrix.netscaler.nitro.exception;
using com.citrix.netscaler.nitro.resource.Base;
using com.citrix.netscaler.nitro.service;

namespace com.citrix.netscaler.nitro.resource.config.responder
{
  public class responderpolicy_binding : base_resource
  {
    private string nameField = (string) null;
    private com.citrix.netscaler.nitro.resource.config.responder.responderpolicy_responderpolicylabel_binding[] responderpolicy_responderpolicylabel_bindingField = (com.citrix.netscaler.nitro.resource.config.responder.responderpolicy_responderpolicylabel_binding[]) null;
    private com.citrix.netscaler.nitro.resource.config.responder.responderpolicy_csvserver_binding[] responderpolicy_csvserver_bindingField = (com.citrix.netscaler.nitro.resource.config.responder.responderpolicy_csvserver_binding[]) null;
    private com.citrix.netscaler.nitro.resource.config.responder.responderpolicy_lbvserver_binding[] responderpolicy_lbvserver_bindingField = (com.citrix.netscaler.nitro.resource.config.responder.responderpolicy_lbvserver_binding[]) null;
    private com.citrix.netscaler.nitro.resource.config.responder.responderpolicy_responderglobal_binding[] responderpolicy_responderglobal_bindingField = (com.citrix.netscaler.nitro.resource.config.responder.responderpolicy_responderglobal_binding[]) null;
    private com.citrix.netscaler.nitro.resource.config.responder.responderpolicy_crvserver_binding[] responderpolicy_crvserver_bindingField = (com.citrix.netscaler.nitro.resource.config.responder.responderpolicy_crvserver_binding[]) null;

    public string name
    {
      get => this.nameField;
      set => this.nameField = value;
    }

    public com.citrix.netscaler.nitro.resource.config.responder.responderpolicy_crvserver_binding[] responderpolicy_crvserver_binding
    {
      get => this.responderpolicy_crvserver_bindingField;
      private set => this.responderpolicy_crvserver_bindingField = value;
    }

    public com.citrix.netscaler.nitro.resource.config.responder.responderpolicy_lbvserver_binding[] responderpolicy_lbvserver_binding
    {
      get => this.responderpolicy_lbvserver_bindingField;
      private set => this.responderpolicy_lbvserver_bindingField = value;
    }

    public com.citrix.netscaler.nitro.resource.config.responder.responderpolicy_responderpolicylabel_binding[] responderpolicy_responderpolicylabel_binding
    {
      get => this.responderpolicy_responderpolicylabel_bindingField;
      private set => this.responderpolicy_responderpolicylabel_bindingField = value;
    }

    public com.citrix.netscaler.nitro.resource.config.responder.responderpolicy_responderglobal_binding[] responderpolicy_responderglobal_binding
    {
      get => this.responderpolicy_responderglobal_bindingField;
      private set => this.responderpolicy_responderglobal_bindingField = value;
    }

    public com.citrix.netscaler.nitro.resource.config.responder.responderpolicy_csvserver_binding[] responderpolicy_csvserver_binding
    {
      get => this.responderpolicy_csvserver_bindingField;
      private set => this.responderpolicy_csvserver_bindingField = value;
    }

    internal override base_resource[] get_nitro_response(
      nitro_service service,
      string response)
    {
      responderpolicy_binding.responderpolicy_binding_response responderpolicyBindingResponse = new responderpolicy_binding.responderpolicy_binding_response();
      responderpolicy_binding.responderpolicy_binding_response resource = (responderpolicy_binding.responderpolicy_binding_response) service.get_payload_formatter().string_to_resource(responderpolicyBindingResponse.GetType(), response);
      if (resource.errorcode != 0)
      {
        if (resource.errorcode == 444)
          service.clear_session();
        if (resource.severity == null)
          throw new nitro_exception(resource.message, resource.errorcode);
        if (resource.severity.Equals("ERROR"))
          throw new nitro_exception(resource.message, resource.errorcode);
      }
      return (base_resource[]) resource.responderpolicy_binding;
    }

    internal override string get_object_name() => this.name;

    public static responderpolicy_binding get(
      nitro_service service,
      string name)
    {
      return (responderpolicy_binding) new responderpolicy_binding()
      {
        name = name
      }.get_resource(service);
    }

    public static responderpolicy_binding[] get(
      nitro_service service,
      string[] name)
    {
      if (name == null || name.Length <= 0)
        return (responderpolicy_binding[]) null;
      responderpolicy_binding[] responderpolicyBindingArray1 = new responderpolicy_binding[name.Length];
      responderpolicy_binding[] responderpolicyBindingArray2 = new responderpolicy_binding[name.Length];
      for (int index = 0; index < name.Length; ++index)
      {
        responderpolicyBindingArray2[index] = new responderpolicy_binding();
        responderpolicyBindingArray2[index].name = name[index];
        responderpolicyBindingArray1[index] = (responderpolicy_binding) responderpolicyBindingArray2[index].get_resource(service);
      }
      return responderpolicyBindingArray1;
    }

    private class responderpolicy_binding_response : base_response
    {
      public responderpolicy_binding[] responderpolicy_binding = (responderpolicy_binding[]) null;
    }
  }
}
