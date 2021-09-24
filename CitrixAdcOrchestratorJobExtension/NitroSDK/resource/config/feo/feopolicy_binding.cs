// Decompiled with JetBrains decompiler
// Type: com.citrix.netscaler.nitro.resource.config.feo.feopolicy_binding
// Assembly: nitro, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 6CF5DDEF-E052-4F9D-953F-6644F8378A66


using com.citrix.netscaler.nitro.exception;
using com.citrix.netscaler.nitro.resource.Base;
using com.citrix.netscaler.nitro.service;

namespace com.citrix.netscaler.nitro.resource.config.feo
{
  public class feopolicy_binding : base_resource
  {
    private string nameField = (string) null;
    private com.citrix.netscaler.nitro.resource.config.feo.feopolicy_csvserver_binding[] feopolicy_csvserver_bindingField = (com.citrix.netscaler.nitro.resource.config.feo.feopolicy_csvserver_binding[]) null;
    private com.citrix.netscaler.nitro.resource.config.feo.feopolicy_lbvserver_binding[] feopolicy_lbvserver_bindingField = (com.citrix.netscaler.nitro.resource.config.feo.feopolicy_lbvserver_binding[]) null;
    private com.citrix.netscaler.nitro.resource.config.feo.feopolicy_feoglobal_binding[] feopolicy_feoglobal_bindingField = (com.citrix.netscaler.nitro.resource.config.feo.feopolicy_feoglobal_binding[]) null;

    public string name
    {
      get => this.nameField;
      set => this.nameField = value;
    }

    public com.citrix.netscaler.nitro.resource.config.feo.feopolicy_csvserver_binding[] feopolicy_csvserver_binding
    {
      get => this.feopolicy_csvserver_bindingField;
      private set => this.feopolicy_csvserver_bindingField = value;
    }

    public com.citrix.netscaler.nitro.resource.config.feo.feopolicy_lbvserver_binding[] feopolicy_lbvserver_binding
    {
      get => this.feopolicy_lbvserver_bindingField;
      private set => this.feopolicy_lbvserver_bindingField = value;
    }

    public com.citrix.netscaler.nitro.resource.config.feo.feopolicy_feoglobal_binding[] feopolicy_feoglobal_binding
    {
      get => this.feopolicy_feoglobal_bindingField;
      private set => this.feopolicy_feoglobal_bindingField = value;
    }

    internal override base_resource[] get_nitro_response(
      nitro_service service,
      string response)
    {
      feopolicy_binding.feopolicy_binding_response feopolicyBindingResponse = new feopolicy_binding.feopolicy_binding_response();
      feopolicy_binding.feopolicy_binding_response resource = (feopolicy_binding.feopolicy_binding_response) service.get_payload_formatter().string_to_resource(feopolicyBindingResponse.GetType(), response);
      if (resource.errorcode != 0)
      {
        if (resource.errorcode == 444)
          service.clear_session();
        if (resource.severity == null)
          throw new nitro_exception(resource.message, resource.errorcode);
        if (resource.severity.Equals("ERROR"))
          throw new nitro_exception(resource.message, resource.errorcode);
      }
      return (base_resource[]) resource.feopolicy_binding;
    }

    internal override string get_object_name() => this.name;

    public static feopolicy_binding get(nitro_service service, string name) => (feopolicy_binding) new feopolicy_binding()
    {
      name = name
    }.get_resource(service);

    public static feopolicy_binding[] get(nitro_service service, string[] name)
    {
      if (name == null || name.Length <= 0)
        return (feopolicy_binding[]) null;
      feopolicy_binding[] feopolicyBindingArray1 = new feopolicy_binding[name.Length];
      feopolicy_binding[] feopolicyBindingArray2 = new feopolicy_binding[name.Length];
      for (int index = 0; index < name.Length; ++index)
      {
        feopolicyBindingArray2[index] = new feopolicy_binding();
        feopolicyBindingArray2[index].name = name[index];
        feopolicyBindingArray1[index] = (feopolicy_binding) feopolicyBindingArray2[index].get_resource(service);
      }
      return feopolicyBindingArray1;
    }

    private class feopolicy_binding_response : base_response
    {
      public feopolicy_binding[] feopolicy_binding = (feopolicy_binding[]) null;
    }
  }
}
