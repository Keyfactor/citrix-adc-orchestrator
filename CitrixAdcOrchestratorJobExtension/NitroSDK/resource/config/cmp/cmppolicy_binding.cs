// Decompiled with JetBrains decompiler
// Type: com.citrix.netscaler.nitro.resource.config.cmp.cmppolicy_binding
// Assembly: nitro, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 6CF5DDEF-E052-4F9D-953F-6644F8378A66


using com.citrix.netscaler.nitro.exception;
using com.citrix.netscaler.nitro.resource.Base;
using com.citrix.netscaler.nitro.service;

namespace com.citrix.netscaler.nitro.resource.config.cmp
{
  public class cmppolicy_binding : base_resource
  {
    private string nameField = (string) null;
    private com.citrix.netscaler.nitro.resource.config.cmp.cmppolicy_lbvserver_binding[] cmppolicy_lbvserver_bindingField = (com.citrix.netscaler.nitro.resource.config.cmp.cmppolicy_lbvserver_binding[]) null;
    private com.citrix.netscaler.nitro.resource.config.cmp.cmppolicy_cmpglobal_binding[] cmppolicy_cmpglobal_bindingField = (com.citrix.netscaler.nitro.resource.config.cmp.cmppolicy_cmpglobal_binding[]) null;
    private com.citrix.netscaler.nitro.resource.config.cmp.cmppolicy_crvserver_binding[] cmppolicy_crvserver_bindingField = (com.citrix.netscaler.nitro.resource.config.cmp.cmppolicy_crvserver_binding[]) null;
    private com.citrix.netscaler.nitro.resource.config.cmp.cmppolicy_csvserver_binding[] cmppolicy_csvserver_bindingField = (com.citrix.netscaler.nitro.resource.config.cmp.cmppolicy_csvserver_binding[]) null;
    private com.citrix.netscaler.nitro.resource.config.cmp.cmppolicy_cmppolicylabel_binding[] cmppolicy_cmppolicylabel_bindingField = (com.citrix.netscaler.nitro.resource.config.cmp.cmppolicy_cmppolicylabel_binding[]) null;

    public string name
    {
      get => this.nameField;
      set => this.nameField = value;
    }

    public com.citrix.netscaler.nitro.resource.config.cmp.cmppolicy_crvserver_binding[] cmppolicy_crvserver_binding
    {
      get => this.cmppolicy_crvserver_bindingField;
      private set => this.cmppolicy_crvserver_bindingField = value;
    }

    public com.citrix.netscaler.nitro.resource.config.cmp.cmppolicy_csvserver_binding[] cmppolicy_csvserver_binding
    {
      get => this.cmppolicy_csvserver_bindingField;
      private set => this.cmppolicy_csvserver_bindingField = value;
    }

    public com.citrix.netscaler.nitro.resource.config.cmp.cmppolicy_cmpglobal_binding[] cmppolicy_cmpglobal_binding
    {
      get => this.cmppolicy_cmpglobal_bindingField;
      private set => this.cmppolicy_cmpglobal_bindingField = value;
    }

    public com.citrix.netscaler.nitro.resource.config.cmp.cmppolicy_lbvserver_binding[] cmppolicy_lbvserver_binding
    {
      get => this.cmppolicy_lbvserver_bindingField;
      private set => this.cmppolicy_lbvserver_bindingField = value;
    }

    public com.citrix.netscaler.nitro.resource.config.cmp.cmppolicy_cmppolicylabel_binding[] cmppolicy_cmppolicylabel_binding
    {
      get => this.cmppolicy_cmppolicylabel_bindingField;
      private set => this.cmppolicy_cmppolicylabel_bindingField = value;
    }

    internal override base_resource[] get_nitro_response(
      nitro_service service,
      string response)
    {
      cmppolicy_binding.cmppolicy_binding_response cmppolicyBindingResponse = new cmppolicy_binding.cmppolicy_binding_response();
      cmppolicy_binding.cmppolicy_binding_response resource = (cmppolicy_binding.cmppolicy_binding_response) service.get_payload_formatter().string_to_resource(cmppolicyBindingResponse.GetType(), response);
      if (resource.errorcode != 0)
      {
        if (resource.errorcode == 444)
          service.clear_session();
        if (resource.severity == null)
          throw new nitro_exception(resource.message, resource.errorcode);
        if (resource.severity.Equals("ERROR"))
          throw new nitro_exception(resource.message, resource.errorcode);
      }
      return (base_resource[]) resource.cmppolicy_binding;
    }

    internal override string get_object_name() => this.name;

    public static cmppolicy_binding get(nitro_service service, string name) => (cmppolicy_binding) new cmppolicy_binding()
    {
      name = name
    }.get_resource(service);

    public static cmppolicy_binding[] get(nitro_service service, string[] name)
    {
      if (name == null || name.Length <= 0)
        return (cmppolicy_binding[]) null;
      cmppolicy_binding[] cmppolicyBindingArray1 = new cmppolicy_binding[name.Length];
      cmppolicy_binding[] cmppolicyBindingArray2 = new cmppolicy_binding[name.Length];
      for (int index = 0; index < name.Length; ++index)
      {
        cmppolicyBindingArray2[index] = new cmppolicy_binding();
        cmppolicyBindingArray2[index].name = name[index];
        cmppolicyBindingArray1[index] = (cmppolicy_binding) cmppolicyBindingArray2[index].get_resource(service);
      }
      return cmppolicyBindingArray1;
    }

    private class cmppolicy_binding_response : base_response
    {
      public cmppolicy_binding[] cmppolicy_binding = (cmppolicy_binding[]) null;
    }
  }
}
