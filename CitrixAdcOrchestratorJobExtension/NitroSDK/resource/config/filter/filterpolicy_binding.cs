// Decompiled with JetBrains decompiler
// Type: com.citrix.netscaler.nitro.resource.config.filter.filterpolicy_binding
// Assembly: nitro, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 6CF5DDEF-E052-4F9D-953F-6644F8378A66


using com.citrix.netscaler.nitro.exception;
using com.citrix.netscaler.nitro.resource.Base;
using com.citrix.netscaler.nitro.service;

namespace com.citrix.netscaler.nitro.resource.config.filter
{
  public class filterpolicy_binding : base_resource
  {
    private string nameField = (string) null;
    private com.citrix.netscaler.nitro.resource.config.filter.filterpolicy_csvserver_binding[] filterpolicy_csvserver_bindingField = (com.citrix.netscaler.nitro.resource.config.filter.filterpolicy_csvserver_binding[]) null;
    private com.citrix.netscaler.nitro.resource.config.filter.filterpolicy_lbvserver_binding[] filterpolicy_lbvserver_bindingField = (com.citrix.netscaler.nitro.resource.config.filter.filterpolicy_lbvserver_binding[]) null;
    private com.citrix.netscaler.nitro.resource.config.filter.filterpolicy_crvserver_binding[] filterpolicy_crvserver_bindingField = (com.citrix.netscaler.nitro.resource.config.filter.filterpolicy_crvserver_binding[]) null;
    private com.citrix.netscaler.nitro.resource.config.filter.filterpolicy_filterglobal_binding[] filterpolicy_filterglobal_bindingField = (com.citrix.netscaler.nitro.resource.config.filter.filterpolicy_filterglobal_binding[]) null;

    public string name
    {
      get => this.nameField;
      set => this.nameField = value;
    }

    public com.citrix.netscaler.nitro.resource.config.filter.filterpolicy_crvserver_binding[] filterpolicy_crvserver_binding
    {
      get => this.filterpolicy_crvserver_bindingField;
      private set => this.filterpolicy_crvserver_bindingField = value;
    }

    public com.citrix.netscaler.nitro.resource.config.filter.filterpolicy_lbvserver_binding[] filterpolicy_lbvserver_binding
    {
      get => this.filterpolicy_lbvserver_bindingField;
      private set => this.filterpolicy_lbvserver_bindingField = value;
    }

    public com.citrix.netscaler.nitro.resource.config.filter.filterpolicy_csvserver_binding[] filterpolicy_csvserver_binding
    {
      get => this.filterpolicy_csvserver_bindingField;
      private set => this.filterpolicy_csvserver_bindingField = value;
    }

    public com.citrix.netscaler.nitro.resource.config.filter.filterpolicy_filterglobal_binding[] filterpolicy_filterglobal_binding
    {
      get => this.filterpolicy_filterglobal_bindingField;
      private set => this.filterpolicy_filterglobal_bindingField = value;
    }

    internal override base_resource[] get_nitro_response(
      nitro_service service,
      string response)
    {
      filterpolicy_binding.filterpolicy_binding_response filterpolicyBindingResponse = new filterpolicy_binding.filterpolicy_binding_response();
      filterpolicy_binding.filterpolicy_binding_response resource = (filterpolicy_binding.filterpolicy_binding_response) service.get_payload_formatter().string_to_resource(filterpolicyBindingResponse.GetType(), response);
      if (resource.errorcode != 0)
      {
        if (resource.errorcode == 444)
          service.clear_session();
        if (resource.severity == null)
          throw new nitro_exception(resource.message, resource.errorcode);
        if (resource.severity.Equals("ERROR"))
          throw new nitro_exception(resource.message, resource.errorcode);
      }
      return (base_resource[]) resource.filterpolicy_binding;
    }

    internal override string get_object_name() => this.name;

    public static filterpolicy_binding get(nitro_service service, string name) => (filterpolicy_binding) new filterpolicy_binding()
    {
      name = name
    }.get_resource(service);

    public static filterpolicy_binding[] get(
      nitro_service service,
      string[] name)
    {
      if (name == null || name.Length <= 0)
        return (filterpolicy_binding[]) null;
      filterpolicy_binding[] filterpolicyBindingArray1 = new filterpolicy_binding[name.Length];
      filterpolicy_binding[] filterpolicyBindingArray2 = new filterpolicy_binding[name.Length];
      for (int index = 0; index < name.Length; ++index)
      {
        filterpolicyBindingArray2[index] = new filterpolicy_binding();
        filterpolicyBindingArray2[index].name = name[index];
        filterpolicyBindingArray1[index] = (filterpolicy_binding) filterpolicyBindingArray2[index].get_resource(service);
      }
      return filterpolicyBindingArray1;
    }

    private class filterpolicy_binding_response : base_response
    {
      public filterpolicy_binding[] filterpolicy_binding = (filterpolicy_binding[]) null;
    }
  }
}
