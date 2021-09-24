// Decompiled with JetBrains decompiler
// Type: com.citrix.netscaler.nitro.resource.config.transform.transformprofile_binding
// Assembly: nitro, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 6CF5DDEF-E052-4F9D-953F-6644F8378A66


using com.citrix.netscaler.nitro.exception;
using com.citrix.netscaler.nitro.resource.Base;
using com.citrix.netscaler.nitro.service;

namespace com.citrix.netscaler.nitro.resource.config.transform
{
  public class transformprofile_binding : base_resource
  {
    private string nameField = (string) null;
    private com.citrix.netscaler.nitro.resource.config.transform.transformprofile_transformaction_binding[] transformprofile_transformaction_bindingField = (com.citrix.netscaler.nitro.resource.config.transform.transformprofile_transformaction_binding[]) null;

    public string name
    {
      get => this.nameField;
      set => this.nameField = value;
    }

    public com.citrix.netscaler.nitro.resource.config.transform.transformprofile_transformaction_binding[] transformprofile_transformaction_binding
    {
      get => this.transformprofile_transformaction_bindingField;
      private set => this.transformprofile_transformaction_bindingField = value;
    }

    internal override base_resource[] get_nitro_response(
      nitro_service service,
      string response)
    {
      transformprofile_binding.transformprofile_binding_response transformprofileBindingResponse = new transformprofile_binding.transformprofile_binding_response();
      transformprofile_binding.transformprofile_binding_response resource = (transformprofile_binding.transformprofile_binding_response) service.get_payload_formatter().string_to_resource(transformprofileBindingResponse.GetType(), response);
      if (resource.errorcode != 0)
      {
        if (resource.errorcode == 444)
          service.clear_session();
        if (resource.severity == null)
          throw new nitro_exception(resource.message, resource.errorcode);
        if (resource.severity.Equals("ERROR"))
          throw new nitro_exception(resource.message, resource.errorcode);
      }
      return (base_resource[]) resource.transformprofile_binding;
    }

    internal override string get_object_name() => this.name;

    public static transformprofile_binding get(
      nitro_service service,
      string name)
    {
      return (transformprofile_binding) new transformprofile_binding()
      {
        name = name
      }.get_resource(service);
    }

    public static transformprofile_binding[] get(
      nitro_service service,
      string[] name)
    {
      if (name == null || name.Length <= 0)
        return (transformprofile_binding[]) null;
      transformprofile_binding[] transformprofileBindingArray1 = new transformprofile_binding[name.Length];
      transformprofile_binding[] transformprofileBindingArray2 = new transformprofile_binding[name.Length];
      for (int index = 0; index < name.Length; ++index)
      {
        transformprofileBindingArray2[index] = new transformprofile_binding();
        transformprofileBindingArray2[index].name = name[index];
        transformprofileBindingArray1[index] = (transformprofile_binding) transformprofileBindingArray2[index].get_resource(service);
      }
      return transformprofileBindingArray1;
    }

    private class transformprofile_binding_response : base_response
    {
      public transformprofile_binding[] transformprofile_binding = (transformprofile_binding[]) null;
    }
  }
}
