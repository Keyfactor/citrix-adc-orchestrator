// Decompiled with JetBrains decompiler
// Type: com.citrix.netscaler.nitro.resource.config.tm.tmtrafficpolicy_binding
// Assembly: nitro, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 6CF5DDEF-E052-4F9D-953F-6644F8378A66


using com.citrix.netscaler.nitro.exception;
using com.citrix.netscaler.nitro.resource.Base;
using com.citrix.netscaler.nitro.service;

namespace com.citrix.netscaler.nitro.resource.config.tm
{
  public class tmtrafficpolicy_binding : base_resource
  {
    private string nameField = (string) null;
    private com.citrix.netscaler.nitro.resource.config.tm.tmtrafficpolicy_csvserver_binding[] tmtrafficpolicy_csvserver_bindingField = (com.citrix.netscaler.nitro.resource.config.tm.tmtrafficpolicy_csvserver_binding[]) null;
    private com.citrix.netscaler.nitro.resource.config.tm.tmtrafficpolicy_lbvserver_binding[] tmtrafficpolicy_lbvserver_bindingField = (com.citrix.netscaler.nitro.resource.config.tm.tmtrafficpolicy_lbvserver_binding[]) null;
    private com.citrix.netscaler.nitro.resource.config.tm.tmtrafficpolicy_tmglobal_binding[] tmtrafficpolicy_tmglobal_bindingField = (com.citrix.netscaler.nitro.resource.config.tm.tmtrafficpolicy_tmglobal_binding[]) null;

    public string name
    {
      get => this.nameField;
      set => this.nameField = value;
    }

    public com.citrix.netscaler.nitro.resource.config.tm.tmtrafficpolicy_csvserver_binding[] tmtrafficpolicy_csvserver_binding
    {
      get => this.tmtrafficpolicy_csvserver_bindingField;
      private set => this.tmtrafficpolicy_csvserver_bindingField = value;
    }

    public com.citrix.netscaler.nitro.resource.config.tm.tmtrafficpolicy_lbvserver_binding[] tmtrafficpolicy_lbvserver_binding
    {
      get => this.tmtrafficpolicy_lbvserver_bindingField;
      private set => this.tmtrafficpolicy_lbvserver_bindingField = value;
    }

    public com.citrix.netscaler.nitro.resource.config.tm.tmtrafficpolicy_tmglobal_binding[] tmtrafficpolicy_tmglobal_binding
    {
      get => this.tmtrafficpolicy_tmglobal_bindingField;
      private set => this.tmtrafficpolicy_tmglobal_bindingField = value;
    }

    internal override base_resource[] get_nitro_response(
      nitro_service service,
      string response)
    {
      tmtrafficpolicy_binding.tmtrafficpolicy_binding_response tmtrafficpolicyBindingResponse = new tmtrafficpolicy_binding.tmtrafficpolicy_binding_response();
      tmtrafficpolicy_binding.tmtrafficpolicy_binding_response resource = (tmtrafficpolicy_binding.tmtrafficpolicy_binding_response) service.get_payload_formatter().string_to_resource(tmtrafficpolicyBindingResponse.GetType(), response);
      if (resource.errorcode != 0)
      {
        if (resource.errorcode == 444)
          service.clear_session();
        if (resource.severity == null)
          throw new nitro_exception(resource.message, resource.errorcode);
        if (resource.severity.Equals("ERROR"))
          throw new nitro_exception(resource.message, resource.errorcode);
      }
      return (base_resource[]) resource.tmtrafficpolicy_binding;
    }

    internal override string get_object_name() => this.name;

    public static tmtrafficpolicy_binding get(
      nitro_service service,
      string name)
    {
      return (tmtrafficpolicy_binding) new tmtrafficpolicy_binding()
      {
        name = name
      }.get_resource(service);
    }

    public static tmtrafficpolicy_binding[] get(
      nitro_service service,
      string[] name)
    {
      if (name == null || name.Length <= 0)
        return (tmtrafficpolicy_binding[]) null;
      tmtrafficpolicy_binding[] tmtrafficpolicyBindingArray1 = new tmtrafficpolicy_binding[name.Length];
      tmtrafficpolicy_binding[] tmtrafficpolicyBindingArray2 = new tmtrafficpolicy_binding[name.Length];
      for (int index = 0; index < name.Length; ++index)
      {
        tmtrafficpolicyBindingArray2[index] = new tmtrafficpolicy_binding();
        tmtrafficpolicyBindingArray2[index].name = name[index];
        tmtrafficpolicyBindingArray1[index] = (tmtrafficpolicy_binding) tmtrafficpolicyBindingArray2[index].get_resource(service);
      }
      return tmtrafficpolicyBindingArray1;
    }

    private class tmtrafficpolicy_binding_response : base_response
    {
      public tmtrafficpolicy_binding[] tmtrafficpolicy_binding = (tmtrafficpolicy_binding[]) null;
    }
  }
}
