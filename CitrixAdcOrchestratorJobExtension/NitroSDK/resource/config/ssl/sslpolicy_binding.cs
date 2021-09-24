// Decompiled with JetBrains decompiler
// Type: com.citrix.netscaler.nitro.resource.config.ssl.sslpolicy_binding
// Assembly: nitro, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 6CF5DDEF-E052-4F9D-953F-6644F8378A66


using com.citrix.netscaler.nitro.exception;
using com.citrix.netscaler.nitro.resource.Base;
using com.citrix.netscaler.nitro.service;

namespace com.citrix.netscaler.nitro.resource.config.ssl
{
  public class sslpolicy_binding : base_resource
  {
    private string nameField = (string) null;
    private com.citrix.netscaler.nitro.resource.config.ssl.sslpolicy_sslservice_binding[] sslpolicy_sslservice_bindingField = (com.citrix.netscaler.nitro.resource.config.ssl.sslpolicy_sslservice_binding[]) null;
    private com.citrix.netscaler.nitro.resource.config.ssl.sslpolicy_lbvserver_binding[] sslpolicy_lbvserver_bindingField = (com.citrix.netscaler.nitro.resource.config.ssl.sslpolicy_lbvserver_binding[]) null;
    private com.citrix.netscaler.nitro.resource.config.ssl.sslpolicy_sslvserver_binding[] sslpolicy_sslvserver_bindingField = (com.citrix.netscaler.nitro.resource.config.ssl.sslpolicy_sslvserver_binding[]) null;
    private com.citrix.netscaler.nitro.resource.config.ssl.sslpolicy_csvserver_binding[] sslpolicy_csvserver_bindingField = (com.citrix.netscaler.nitro.resource.config.ssl.sslpolicy_csvserver_binding[]) null;
    private com.citrix.netscaler.nitro.resource.config.ssl.sslpolicy_sslpolicylabel_binding[] sslpolicy_sslpolicylabel_bindingField = (com.citrix.netscaler.nitro.resource.config.ssl.sslpolicy_sslpolicylabel_binding[]) null;
    private com.citrix.netscaler.nitro.resource.config.ssl.sslpolicy_sslglobal_binding[] sslpolicy_sslglobal_bindingField = (com.citrix.netscaler.nitro.resource.config.ssl.sslpolicy_sslglobal_binding[]) null;

    public string name
    {
      get => this.nameField;
      set => this.nameField = value;
    }

    public com.citrix.netscaler.nitro.resource.config.ssl.sslpolicy_sslvserver_binding[] sslpolicy_sslvserver_binding
    {
      get => this.sslpolicy_sslvserver_bindingField;
      private set => this.sslpolicy_sslvserver_bindingField = value;
    }

    public com.citrix.netscaler.nitro.resource.config.ssl.sslpolicy_csvserver_binding[] sslpolicy_csvserver_binding
    {
      get => this.sslpolicy_csvserver_bindingField;
      private set => this.sslpolicy_csvserver_bindingField = value;
    }

    public com.citrix.netscaler.nitro.resource.config.ssl.sslpolicy_lbvserver_binding[] sslpolicy_lbvserver_binding
    {
      get => this.sslpolicy_lbvserver_bindingField;
      private set => this.sslpolicy_lbvserver_bindingField = value;
    }

    public com.citrix.netscaler.nitro.resource.config.ssl.sslpolicy_sslservice_binding[] sslpolicy_sslservice_binding
    {
      get => this.sslpolicy_sslservice_bindingField;
      private set => this.sslpolicy_sslservice_bindingField = value;
    }

    public com.citrix.netscaler.nitro.resource.config.ssl.sslpolicy_sslpolicylabel_binding[] sslpolicy_sslpolicylabel_binding
    {
      get => this.sslpolicy_sslpolicylabel_bindingField;
      private set => this.sslpolicy_sslpolicylabel_bindingField = value;
    }

    public com.citrix.netscaler.nitro.resource.config.ssl.sslpolicy_sslglobal_binding[] sslpolicy_sslglobal_binding
    {
      get => this.sslpolicy_sslglobal_bindingField;
      private set => this.sslpolicy_sslglobal_bindingField = value;
    }

    internal override base_resource[] get_nitro_response(
      nitro_service service,
      string response)
    {
      sslpolicy_binding.sslpolicy_binding_response sslpolicyBindingResponse = new sslpolicy_binding.sslpolicy_binding_response();
      sslpolicy_binding.sslpolicy_binding_response resource = (sslpolicy_binding.sslpolicy_binding_response) service.get_payload_formatter().string_to_resource(sslpolicyBindingResponse.GetType(), response);
      if (resource.errorcode != 0)
      {
        if (resource.errorcode == 444)
          service.clear_session();
        if (resource.severity == null)
          throw new nitro_exception(resource.message, resource.errorcode);
        if (resource.severity.Equals("ERROR"))
          throw new nitro_exception(resource.message, resource.errorcode);
      }
      return (base_resource[]) resource.sslpolicy_binding;
    }

    internal override string get_object_name() => this.name;

    public static sslpolicy_binding get(nitro_service service, string name) => (sslpolicy_binding) new sslpolicy_binding()
    {
      name = name
    }.get_resource(service);

    public static sslpolicy_binding[] get(nitro_service service, string[] name)
    {
      if (name == null || name.Length <= 0)
        return (sslpolicy_binding[]) null;
      sslpolicy_binding[] sslpolicyBindingArray1 = new sslpolicy_binding[name.Length];
      sslpolicy_binding[] sslpolicyBindingArray2 = new sslpolicy_binding[name.Length];
      for (int index = 0; index < name.Length; ++index)
      {
        sslpolicyBindingArray2[index] = new sslpolicy_binding();
        sslpolicyBindingArray2[index].name = name[index];
        sslpolicyBindingArray1[index] = (sslpolicy_binding) sslpolicyBindingArray2[index].get_resource(service);
      }
      return sslpolicyBindingArray1;
    }

    private class sslpolicy_binding_response : base_response
    {
      public sslpolicy_binding[] sslpolicy_binding = (sslpolicy_binding[]) null;
    }
  }
}
