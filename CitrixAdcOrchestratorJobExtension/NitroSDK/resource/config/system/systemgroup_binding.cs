// Decompiled with JetBrains decompiler
// Type: com.citrix.netscaler.nitro.resource.config.system.systemgroup_binding
// Assembly: nitro, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 6CF5DDEF-E052-4F9D-953F-6644F8378A66


using com.citrix.netscaler.nitro.exception;
using com.citrix.netscaler.nitro.resource.Base;
using com.citrix.netscaler.nitro.service;

namespace com.citrix.netscaler.nitro.resource.config.system
{
  public class systemgroup_binding : base_resource
  {
    private string groupnameField = (string) null;
    private com.citrix.netscaler.nitro.resource.config.system.systemgroup_systemuser_binding[] systemgroup_systemuser_bindingField = (com.citrix.netscaler.nitro.resource.config.system.systemgroup_systemuser_binding[]) null;
    private com.citrix.netscaler.nitro.resource.config.system.systemgroup_systemcmdpolicy_binding[] systemgroup_systemcmdpolicy_bindingField = (com.citrix.netscaler.nitro.resource.config.system.systemgroup_systemcmdpolicy_binding[]) null;

    public string groupname
    {
      get => this.groupnameField;
      set => this.groupnameField = value;
    }

    public com.citrix.netscaler.nitro.resource.config.system.systemgroup_systemcmdpolicy_binding[] systemgroup_systemcmdpolicy_binding
    {
      get => this.systemgroup_systemcmdpolicy_bindingField;
      private set => this.systemgroup_systemcmdpolicy_bindingField = value;
    }

    public com.citrix.netscaler.nitro.resource.config.system.systemgroup_systemuser_binding[] systemgroup_systemuser_binding
    {
      get => this.systemgroup_systemuser_bindingField;
      private set => this.systemgroup_systemuser_bindingField = value;
    }

    internal override base_resource[] get_nitro_response(
      nitro_service service,
      string response)
    {
      systemgroup_binding.systemgroup_binding_response systemgroupBindingResponse = new systemgroup_binding.systemgroup_binding_response();
      systemgroup_binding.systemgroup_binding_response resource = (systemgroup_binding.systemgroup_binding_response) service.get_payload_formatter().string_to_resource(systemgroupBindingResponse.GetType(), response);
      if (resource.errorcode != 0)
      {
        if (resource.errorcode == 444)
          service.clear_session();
        if (resource.severity == null)
          throw new nitro_exception(resource.message, resource.errorcode);
        if (resource.severity.Equals("ERROR"))
          throw new nitro_exception(resource.message, resource.errorcode);
      }
      return (base_resource[]) resource.systemgroup_binding;
    }

    internal override string get_object_name() => this.groupname;

    public static systemgroup_binding get(
      nitro_service service,
      string groupname)
    {
      return (systemgroup_binding) new systemgroup_binding()
      {
        groupname = groupname
      }.get_resource(service);
    }

    public static systemgroup_binding[] get(
      nitro_service service,
      string[] groupname)
    {
      if (groupname == null || groupname.Length <= 0)
        return (systemgroup_binding[]) null;
      systemgroup_binding[] systemgroupBindingArray1 = new systemgroup_binding[groupname.Length];
      systemgroup_binding[] systemgroupBindingArray2 = new systemgroup_binding[groupname.Length];
      for (int index = 0; index < groupname.Length; ++index)
      {
        systemgroupBindingArray2[index] = new systemgroup_binding();
        systemgroupBindingArray2[index].groupname = groupname[index];
        systemgroupBindingArray1[index] = (systemgroup_binding) systemgroupBindingArray2[index].get_resource(service);
      }
      return systemgroupBindingArray1;
    }

    private class systemgroup_binding_response : base_response
    {
      public systemgroup_binding[] systemgroup_binding = (systemgroup_binding[]) null;
    }
  }
}
