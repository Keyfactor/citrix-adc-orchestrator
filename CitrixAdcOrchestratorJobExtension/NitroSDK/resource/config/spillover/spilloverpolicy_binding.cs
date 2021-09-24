// Decompiled with JetBrains decompiler
// Type: com.citrix.netscaler.nitro.resource.config.spillover.spilloverpolicy_binding
// Assembly: nitro, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 6CF5DDEF-E052-4F9D-953F-6644F8378A66


using com.citrix.netscaler.nitro.exception;
using com.citrix.netscaler.nitro.resource.Base;
using com.citrix.netscaler.nitro.service;

namespace com.citrix.netscaler.nitro.resource.config.spillover
{
  public class spilloverpolicy_binding : base_resource
  {
    private string nameField = (string) null;
    private com.citrix.netscaler.nitro.resource.config.spillover.spilloverpolicy_gslbvserver_binding[] spilloverpolicy_gslbvserver_bindingField = (com.citrix.netscaler.nitro.resource.config.spillover.spilloverpolicy_gslbvserver_binding[]) null;
    private com.citrix.netscaler.nitro.resource.config.spillover.spilloverpolicy_csvserver_binding[] spilloverpolicy_csvserver_bindingField = (com.citrix.netscaler.nitro.resource.config.spillover.spilloverpolicy_csvserver_binding[]) null;
    private com.citrix.netscaler.nitro.resource.config.spillover.spilloverpolicy_lbvserver_binding[] spilloverpolicy_lbvserver_bindingField = (com.citrix.netscaler.nitro.resource.config.spillover.spilloverpolicy_lbvserver_binding[]) null;

    public string name
    {
      get => this.nameField;
      set => this.nameField = value;
    }

    public com.citrix.netscaler.nitro.resource.config.spillover.spilloverpolicy_csvserver_binding[] spilloverpolicy_csvserver_binding
    {
      get => this.spilloverpolicy_csvserver_bindingField;
      private set => this.spilloverpolicy_csvserver_bindingField = value;
    }

    public com.citrix.netscaler.nitro.resource.config.spillover.spilloverpolicy_lbvserver_binding[] spilloverpolicy_lbvserver_binding
    {
      get => this.spilloverpolicy_lbvserver_bindingField;
      private set => this.spilloverpolicy_lbvserver_bindingField = value;
    }

    public com.citrix.netscaler.nitro.resource.config.spillover.spilloverpolicy_gslbvserver_binding[] spilloverpolicy_gslbvserver_binding
    {
      get => this.spilloverpolicy_gslbvserver_bindingField;
      private set => this.spilloverpolicy_gslbvserver_bindingField = value;
    }

    internal override base_resource[] get_nitro_response(
      nitro_service service,
      string response)
    {
      spilloverpolicy_binding.spilloverpolicy_binding_response spilloverpolicyBindingResponse = new spilloverpolicy_binding.spilloverpolicy_binding_response();
      spilloverpolicy_binding.spilloverpolicy_binding_response resource = (spilloverpolicy_binding.spilloverpolicy_binding_response) service.get_payload_formatter().string_to_resource(spilloverpolicyBindingResponse.GetType(), response);
      if (resource.errorcode != 0)
      {
        if (resource.errorcode == 444)
          service.clear_session();
        if (resource.severity == null)
          throw new nitro_exception(resource.message, resource.errorcode);
        if (resource.severity.Equals("ERROR"))
          throw new nitro_exception(resource.message, resource.errorcode);
      }
      return (base_resource[]) resource.spilloverpolicy_binding;
    }

    internal override string get_object_name() => this.name;

    public static spilloverpolicy_binding get(
      nitro_service service,
      string name)
    {
      return (spilloverpolicy_binding) new spilloverpolicy_binding()
      {
        name = name
      }.get_resource(service);
    }

    public static spilloverpolicy_binding[] get(
      nitro_service service,
      string[] name)
    {
      if (name == null || name.Length <= 0)
        return (spilloverpolicy_binding[]) null;
      spilloverpolicy_binding[] spilloverpolicyBindingArray1 = new spilloverpolicy_binding[name.Length];
      spilloverpolicy_binding[] spilloverpolicyBindingArray2 = new spilloverpolicy_binding[name.Length];
      for (int index = 0; index < name.Length; ++index)
      {
        spilloverpolicyBindingArray2[index] = new spilloverpolicy_binding();
        spilloverpolicyBindingArray2[index].name = name[index];
        spilloverpolicyBindingArray1[index] = (spilloverpolicy_binding) spilloverpolicyBindingArray2[index].get_resource(service);
      }
      return spilloverpolicyBindingArray1;
    }

    private class spilloverpolicy_binding_response : base_response
    {
      public spilloverpolicy_binding[] spilloverpolicy_binding = (spilloverpolicy_binding[]) null;
    }
  }
}
