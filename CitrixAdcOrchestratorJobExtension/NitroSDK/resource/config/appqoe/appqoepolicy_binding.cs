// Decompiled with JetBrains decompiler
// Type: com.citrix.netscaler.nitro.resource.config.appqoe.appqoepolicy_binding
// Assembly: nitro, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 6CF5DDEF-E052-4F9D-953F-6644F8378A66


using com.citrix.netscaler.nitro.exception;
using com.citrix.netscaler.nitro.resource.Base;
using com.citrix.netscaler.nitro.service;

namespace com.citrix.netscaler.nitro.resource.config.appqoe
{
  public class appqoepolicy_binding : base_resource
  {
    private string nameField = (string) null;
    private com.citrix.netscaler.nitro.resource.config.appqoe.appqoepolicy_lbvserver_binding[] appqoepolicy_lbvserver_bindingField = (com.citrix.netscaler.nitro.resource.config.appqoe.appqoepolicy_lbvserver_binding[]) null;

    public string name
    {
      get => this.nameField;
      set => this.nameField = value;
    }

    public com.citrix.netscaler.nitro.resource.config.appqoe.appqoepolicy_lbvserver_binding[] appqoepolicy_lbvserver_binding
    {
      get => this.appqoepolicy_lbvserver_bindingField;
      private set => this.appqoepolicy_lbvserver_bindingField = value;
    }

    internal override base_resource[] get_nitro_response(
      nitro_service service,
      string response)
    {
      appqoepolicy_binding.appqoepolicy_binding_response appqoepolicyBindingResponse = new appqoepolicy_binding.appqoepolicy_binding_response();
      appqoepolicy_binding.appqoepolicy_binding_response resource = (appqoepolicy_binding.appqoepolicy_binding_response) service.get_payload_formatter().string_to_resource(appqoepolicyBindingResponse.GetType(), response);
      if (resource.errorcode != 0)
      {
        if (resource.errorcode == 444)
          service.clear_session();
        if (resource.severity == null)
          throw new nitro_exception(resource.message, resource.errorcode);
        if (resource.severity.Equals("ERROR"))
          throw new nitro_exception(resource.message, resource.errorcode);
      }
      return (base_resource[]) resource.appqoepolicy_binding;
    }

    internal override string get_object_name() => this.name;

    public static appqoepolicy_binding get(nitro_service service, string name) => (appqoepolicy_binding) new appqoepolicy_binding()
    {
      name = name
    }.get_resource(service);

    public static appqoepolicy_binding[] get(
      nitro_service service,
      string[] name)
    {
      if (name == null || name.Length <= 0)
        return (appqoepolicy_binding[]) null;
      appqoepolicy_binding[] appqoepolicyBindingArray1 = new appqoepolicy_binding[name.Length];
      appqoepolicy_binding[] appqoepolicyBindingArray2 = new appqoepolicy_binding[name.Length];
      for (int index = 0; index < name.Length; ++index)
      {
        appqoepolicyBindingArray2[index] = new appqoepolicy_binding();
        appqoepolicyBindingArray2[index].name = name[index];
        appqoepolicyBindingArray1[index] = (appqoepolicy_binding) appqoepolicyBindingArray2[index].get_resource(service);
      }
      return appqoepolicyBindingArray1;
    }

    private class appqoepolicy_binding_response : base_response
    {
      public appqoepolicy_binding[] appqoepolicy_binding = (appqoepolicy_binding[]) null;
    }
  }
}
