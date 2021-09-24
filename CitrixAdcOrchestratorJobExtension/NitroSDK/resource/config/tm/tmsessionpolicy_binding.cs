// Decompiled with JetBrains decompiler
// Type: com.citrix.netscaler.nitro.resource.config.tm.tmsessionpolicy_binding
// Assembly: nitro, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 6CF5DDEF-E052-4F9D-953F-6644F8378A66


using com.citrix.netscaler.nitro.exception;
using com.citrix.netscaler.nitro.resource.Base;
using com.citrix.netscaler.nitro.service;

namespace com.citrix.netscaler.nitro.resource.config.tm
{
  public class tmsessionpolicy_binding : base_resource
  {
    private string nameField = (string) null;
    private com.citrix.netscaler.nitro.resource.config.tm.tmsessionpolicy_authenticationvserver_binding[] tmsessionpolicy_authenticationvserver_bindingField = (com.citrix.netscaler.nitro.resource.config.tm.tmsessionpolicy_authenticationvserver_binding[]) null;
    private com.citrix.netscaler.nitro.resource.config.tm.tmsessionpolicy_aaagroup_binding[] tmsessionpolicy_aaagroup_bindingField = (com.citrix.netscaler.nitro.resource.config.tm.tmsessionpolicy_aaagroup_binding[]) null;
    private com.citrix.netscaler.nitro.resource.config.tm.tmsessionpolicy_aaauser_binding[] tmsessionpolicy_aaauser_bindingField = (com.citrix.netscaler.nitro.resource.config.tm.tmsessionpolicy_aaauser_binding[]) null;
    private com.citrix.netscaler.nitro.resource.config.tm.tmsessionpolicy_tmglobal_binding[] tmsessionpolicy_tmglobal_bindingField = (com.citrix.netscaler.nitro.resource.config.tm.tmsessionpolicy_tmglobal_binding[]) null;

    public string name
    {
      get => this.nameField;
      set => this.nameField = value;
    }

    public com.citrix.netscaler.nitro.resource.config.tm.tmsessionpolicy_aaauser_binding[] tmsessionpolicy_aaauser_binding
    {
      get => this.tmsessionpolicy_aaauser_bindingField;
      private set => this.tmsessionpolicy_aaauser_bindingField = value;
    }

    public com.citrix.netscaler.nitro.resource.config.tm.tmsessionpolicy_tmglobal_binding[] tmsessionpolicy_tmglobal_binding
    {
      get => this.tmsessionpolicy_tmglobal_bindingField;
      private set => this.tmsessionpolicy_tmglobal_bindingField = value;
    }

    public com.citrix.netscaler.nitro.resource.config.tm.tmsessionpolicy_authenticationvserver_binding[] tmsessionpolicy_authenticationvserver_binding
    {
      get => this.tmsessionpolicy_authenticationvserver_bindingField;
      private set => this.tmsessionpolicy_authenticationvserver_bindingField = value;
    }

    public com.citrix.netscaler.nitro.resource.config.tm.tmsessionpolicy_aaagroup_binding[] tmsessionpolicy_aaagroup_binding
    {
      get => this.tmsessionpolicy_aaagroup_bindingField;
      private set => this.tmsessionpolicy_aaagroup_bindingField = value;
    }

    internal override base_resource[] get_nitro_response(
      nitro_service service,
      string response)
    {
      tmsessionpolicy_binding.tmsessionpolicy_binding_response tmsessionpolicyBindingResponse = new tmsessionpolicy_binding.tmsessionpolicy_binding_response();
      tmsessionpolicy_binding.tmsessionpolicy_binding_response resource = (tmsessionpolicy_binding.tmsessionpolicy_binding_response) service.get_payload_formatter().string_to_resource(tmsessionpolicyBindingResponse.GetType(), response);
      if (resource.errorcode != 0)
      {
        if (resource.errorcode == 444)
          service.clear_session();
        if (resource.severity == null)
          throw new nitro_exception(resource.message, resource.errorcode);
        if (resource.severity.Equals("ERROR"))
          throw new nitro_exception(resource.message, resource.errorcode);
      }
      return (base_resource[]) resource.tmsessionpolicy_binding;
    }

    internal override string get_object_name() => this.name;

    public static tmsessionpolicy_binding get(
      nitro_service service,
      string name)
    {
      return (tmsessionpolicy_binding) new tmsessionpolicy_binding()
      {
        name = name
      }.get_resource(service);
    }

    public static tmsessionpolicy_binding[] get(
      nitro_service service,
      string[] name)
    {
      if (name == null || name.Length <= 0)
        return (tmsessionpolicy_binding[]) null;
      tmsessionpolicy_binding[] tmsessionpolicyBindingArray1 = new tmsessionpolicy_binding[name.Length];
      tmsessionpolicy_binding[] tmsessionpolicyBindingArray2 = new tmsessionpolicy_binding[name.Length];
      for (int index = 0; index < name.Length; ++index)
      {
        tmsessionpolicyBindingArray2[index] = new tmsessionpolicy_binding();
        tmsessionpolicyBindingArray2[index].name = name[index];
        tmsessionpolicyBindingArray1[index] = (tmsessionpolicy_binding) tmsessionpolicyBindingArray2[index].get_resource(service);
      }
      return tmsessionpolicyBindingArray1;
    }

    private class tmsessionpolicy_binding_response : base_response
    {
      public tmsessionpolicy_binding[] tmsessionpolicy_binding = (tmsessionpolicy_binding[]) null;
    }
  }
}
