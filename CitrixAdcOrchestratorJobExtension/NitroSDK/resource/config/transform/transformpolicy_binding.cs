// Decompiled with JetBrains decompiler
// Type: com.citrix.netscaler.nitro.resource.config.transform.transformpolicy_binding
// Assembly: nitro, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 6CF5DDEF-E052-4F9D-953F-6644F8378A66


using com.citrix.netscaler.nitro.exception;
using com.citrix.netscaler.nitro.resource.Base;
using com.citrix.netscaler.nitro.service;

namespace com.citrix.netscaler.nitro.resource.config.transform
{
  public class transformpolicy_binding : base_resource
  {
    private string nameField = (string) null;
    private com.citrix.netscaler.nitro.resource.config.transform.transformpolicy_lbvserver_binding[] transformpolicy_lbvserver_bindingField = (com.citrix.netscaler.nitro.resource.config.transform.transformpolicy_lbvserver_binding[]) null;
    private com.citrix.netscaler.nitro.resource.config.transform.transformpolicy_transformglobal_binding[] transformpolicy_transformglobal_bindingField = (com.citrix.netscaler.nitro.resource.config.transform.transformpolicy_transformglobal_binding[]) null;
    private com.citrix.netscaler.nitro.resource.config.transform.transformpolicy_csvserver_binding[] transformpolicy_csvserver_bindingField = (com.citrix.netscaler.nitro.resource.config.transform.transformpolicy_csvserver_binding[]) null;
    private com.citrix.netscaler.nitro.resource.config.transform.transformpolicy_transformpolicylabel_binding[] transformpolicy_transformpolicylabel_bindingField = (com.citrix.netscaler.nitro.resource.config.transform.transformpolicy_transformpolicylabel_binding[]) null;

    public string name
    {
      get => this.nameField;
      set => this.nameField = value;
    }

    public com.citrix.netscaler.nitro.resource.config.transform.transformpolicy_transformglobal_binding[] transformpolicy_transformglobal_binding
    {
      get => this.transformpolicy_transformglobal_bindingField;
      private set => this.transformpolicy_transformglobal_bindingField = value;
    }

    public com.citrix.netscaler.nitro.resource.config.transform.transformpolicy_lbvserver_binding[] transformpolicy_lbvserver_binding
    {
      get => this.transformpolicy_lbvserver_bindingField;
      private set => this.transformpolicy_lbvserver_bindingField = value;
    }

    public com.citrix.netscaler.nitro.resource.config.transform.transformpolicy_csvserver_binding[] transformpolicy_csvserver_binding
    {
      get => this.transformpolicy_csvserver_bindingField;
      private set => this.transformpolicy_csvserver_bindingField = value;
    }

    public com.citrix.netscaler.nitro.resource.config.transform.transformpolicy_transformpolicylabel_binding[] transformpolicy_transformpolicylabel_binding
    {
      get => this.transformpolicy_transformpolicylabel_bindingField;
      private set => this.transformpolicy_transformpolicylabel_bindingField = value;
    }

    internal override base_resource[] get_nitro_response(
      nitro_service service,
      string response)
    {
      transformpolicy_binding.transformpolicy_binding_response transformpolicyBindingResponse = new transformpolicy_binding.transformpolicy_binding_response();
      transformpolicy_binding.transformpolicy_binding_response resource = (transformpolicy_binding.transformpolicy_binding_response) service.get_payload_formatter().string_to_resource(transformpolicyBindingResponse.GetType(), response);
      if (resource.errorcode != 0)
      {
        if (resource.errorcode == 444)
          service.clear_session();
        if (resource.severity == null)
          throw new nitro_exception(resource.message, resource.errorcode);
        if (resource.severity.Equals("ERROR"))
          throw new nitro_exception(resource.message, resource.errorcode);
      }
      return (base_resource[]) resource.transformpolicy_binding;
    }

    internal override string get_object_name() => this.name;

    public static transformpolicy_binding get(
      nitro_service service,
      string name)
    {
      return (transformpolicy_binding) new transformpolicy_binding()
      {
        name = name
      }.get_resource(service);
    }

    public static transformpolicy_binding[] get(
      nitro_service service,
      string[] name)
    {
      if (name == null || name.Length <= 0)
        return (transformpolicy_binding[]) null;
      transformpolicy_binding[] transformpolicyBindingArray1 = new transformpolicy_binding[name.Length];
      transformpolicy_binding[] transformpolicyBindingArray2 = new transformpolicy_binding[name.Length];
      for (int index = 0; index < name.Length; ++index)
      {
        transformpolicyBindingArray2[index] = new transformpolicy_binding();
        transformpolicyBindingArray2[index].name = name[index];
        transformpolicyBindingArray1[index] = (transformpolicy_binding) transformpolicyBindingArray2[index].get_resource(service);
      }
      return transformpolicyBindingArray1;
    }

    private class transformpolicy_binding_response : base_response
    {
      public transformpolicy_binding[] transformpolicy_binding = (transformpolicy_binding[]) null;
    }
  }
}
