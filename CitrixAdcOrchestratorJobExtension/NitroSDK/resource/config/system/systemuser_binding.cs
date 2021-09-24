// Decompiled with JetBrains decompiler
// Type: com.citrix.netscaler.nitro.resource.config.system.systemuser_binding
// Assembly: nitro, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 6CF5DDEF-E052-4F9D-953F-6644F8378A66


using com.citrix.netscaler.nitro.exception;
using com.citrix.netscaler.nitro.resource.Base;
using com.citrix.netscaler.nitro.service;

namespace com.citrix.netscaler.nitro.resource.config.system
{
  public class systemuser_binding : base_resource
  {
    private string usernameField = (string) null;
    private com.citrix.netscaler.nitro.resource.config.system.systemuser_systemgroup_binding[] systemuser_systemgroup_bindingField = (com.citrix.netscaler.nitro.resource.config.system.systemuser_systemgroup_binding[]) null;
    private com.citrix.netscaler.nitro.resource.config.system.systemuser_nspartition_binding[] systemuser_nspartition_bindingField = (com.citrix.netscaler.nitro.resource.config.system.systemuser_nspartition_binding[]) null;
    private com.citrix.netscaler.nitro.resource.config.system.systemuser_systemcmdpolicy_binding[] systemuser_systemcmdpolicy_bindingField = (com.citrix.netscaler.nitro.resource.config.system.systemuser_systemcmdpolicy_binding[]) null;

    public string username
    {
      get => this.usernameField;
      set => this.usernameField = value;
    }

    public com.citrix.netscaler.nitro.resource.config.system.systemuser_systemgroup_binding[] systemuser_systemgroup_binding
    {
      get => this.systemuser_systemgroup_bindingField;
      private set => this.systemuser_systemgroup_bindingField = value;
    }

    public com.citrix.netscaler.nitro.resource.config.system.systemuser_nspartition_binding[] systemuser_nspartition_binding
    {
      get => this.systemuser_nspartition_bindingField;
      private set => this.systemuser_nspartition_bindingField = value;
    }

    public com.citrix.netscaler.nitro.resource.config.system.systemuser_systemcmdpolicy_binding[] systemuser_systemcmdpolicy_binding
    {
      get => this.systemuser_systemcmdpolicy_bindingField;
      private set => this.systemuser_systemcmdpolicy_bindingField = value;
    }

    internal override base_resource[] get_nitro_response(
      nitro_service service,
      string response)
    {
      systemuser_binding.systemuser_binding_response systemuserBindingResponse = new systemuser_binding.systemuser_binding_response();
      systemuser_binding.systemuser_binding_response resource = (systemuser_binding.systemuser_binding_response) service.get_payload_formatter().string_to_resource(systemuserBindingResponse.GetType(), response);
      if (resource.errorcode != 0)
      {
        if (resource.errorcode == 444)
          service.clear_session();
        if (resource.severity == null)
          throw new nitro_exception(resource.message, resource.errorcode);
        if (resource.severity.Equals("ERROR"))
          throw new nitro_exception(resource.message, resource.errorcode);
      }
      return (base_resource[]) resource.systemuser_binding;
    }

    internal override string get_object_name() => this.username;

    public static systemuser_binding get(nitro_service service, string username) => (systemuser_binding) new systemuser_binding()
    {
      username = username
    }.get_resource(service);

    public static systemuser_binding[] get(
      nitro_service service,
      string[] username)
    {
      if (username == null || username.Length <= 0)
        return (systemuser_binding[]) null;
      systemuser_binding[] systemuserBindingArray1 = new systemuser_binding[username.Length];
      systemuser_binding[] systemuserBindingArray2 = new systemuser_binding[username.Length];
      for (int index = 0; index < username.Length; ++index)
      {
        systemuserBindingArray2[index] = new systemuser_binding();
        systemuserBindingArray2[index].username = username[index];
        systemuserBindingArray1[index] = (systemuser_binding) systemuserBindingArray2[index].get_resource(service);
      }
      return systemuserBindingArray1;
    }

    private class systemuser_binding_response : base_response
    {
      public systemuser_binding[] systemuser_binding = (systemuser_binding[]) null;
    }
  }
}
