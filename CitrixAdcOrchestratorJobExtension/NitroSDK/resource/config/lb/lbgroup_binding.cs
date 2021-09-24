// Decompiled with JetBrains decompiler
// Type: com.citrix.netscaler.nitro.resource.config.lb.lbgroup_binding
// Assembly: nitro, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 6CF5DDEF-E052-4F9D-953F-6644F8378A66


using com.citrix.netscaler.nitro.exception;
using com.citrix.netscaler.nitro.resource.Base;
using com.citrix.netscaler.nitro.service;

namespace com.citrix.netscaler.nitro.resource.config.lb
{
  public class lbgroup_binding : base_resource
  {
    private string nameField = (string) null;
    private com.citrix.netscaler.nitro.resource.config.lb.lbgroup_lbvserver_binding[] lbgroup_lbvserver_bindingField = (com.citrix.netscaler.nitro.resource.config.lb.lbgroup_lbvserver_binding[]) null;

    public string name
    {
      get => this.nameField;
      set => this.nameField = value;
    }

    public com.citrix.netscaler.nitro.resource.config.lb.lbgroup_lbvserver_binding[] lbgroup_lbvserver_binding
    {
      get => this.lbgroup_lbvserver_bindingField;
      private set => this.lbgroup_lbvserver_bindingField = value;
    }

    internal override base_resource[] get_nitro_response(
      nitro_service service,
      string response)
    {
      lbgroup_binding.lbgroup_binding_response lbgroupBindingResponse = new lbgroup_binding.lbgroup_binding_response();
      lbgroup_binding.lbgroup_binding_response resource = (lbgroup_binding.lbgroup_binding_response) service.get_payload_formatter().string_to_resource(lbgroupBindingResponse.GetType(), response);
      if (resource.errorcode != 0)
      {
        if (resource.errorcode == 444)
          service.clear_session();
        if (resource.severity == null)
          throw new nitro_exception(resource.message, resource.errorcode);
        if (resource.severity.Equals("ERROR"))
          throw new nitro_exception(resource.message, resource.errorcode);
      }
      return (base_resource[]) resource.lbgroup_binding;
    }

    internal override string get_object_name() => this.name;

    public static lbgroup_binding get(nitro_service service, string name) => (lbgroup_binding) new lbgroup_binding()
    {
      name = name
    }.get_resource(service);

    public static lbgroup_binding[] get(nitro_service service, string[] name)
    {
      if (name == null || name.Length <= 0)
        return (lbgroup_binding[]) null;
      lbgroup_binding[] lbgroupBindingArray1 = new lbgroup_binding[name.Length];
      lbgroup_binding[] lbgroupBindingArray2 = new lbgroup_binding[name.Length];
      for (int index = 0; index < name.Length; ++index)
      {
        lbgroupBindingArray2[index] = new lbgroup_binding();
        lbgroupBindingArray2[index].name = name[index];
        lbgroupBindingArray1[index] = (lbgroup_binding) lbgroupBindingArray2[index].get_resource(service);
      }
      return lbgroupBindingArray1;
    }

    private class lbgroup_binding_response : base_response
    {
      public lbgroup_binding[] lbgroup_binding = (lbgroup_binding[]) null;
    }
  }
}
