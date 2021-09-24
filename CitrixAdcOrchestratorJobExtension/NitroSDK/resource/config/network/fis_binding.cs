// Decompiled with JetBrains decompiler
// Type: com.citrix.netscaler.nitro.resource.config.network.fis_binding
// Assembly: nitro, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 6CF5DDEF-E052-4F9D-953F-6644F8378A66


using com.citrix.netscaler.nitro.exception;
using com.citrix.netscaler.nitro.resource.Base;
using com.citrix.netscaler.nitro.service;

namespace com.citrix.netscaler.nitro.resource.config.network
{
  public class fis_binding : base_resource
  {
    private string nameField = (string) null;
    private com.citrix.netscaler.nitro.resource.config.network.fis_channel_binding[] fis_channel_bindingField = (com.citrix.netscaler.nitro.resource.config.network.fis_channel_binding[]) null;

    public string name
    {
      get => this.nameField;
      set => this.nameField = value;
    }

    public com.citrix.netscaler.nitro.resource.config.network.fis_channel_binding[] fis_channel_binding
    {
      get => this.fis_channel_bindingField;
      private set => this.fis_channel_bindingField = value;
    }

    internal override base_resource[] get_nitro_response(
      nitro_service service,
      string response)
    {
      fis_binding.fis_binding_response fisBindingResponse = new fis_binding.fis_binding_response();
      fis_binding.fis_binding_response resource = (fis_binding.fis_binding_response) service.get_payload_formatter().string_to_resource(fisBindingResponse.GetType(), response);
      if (resource.errorcode != 0)
      {
        if (resource.errorcode == 444)
          service.clear_session();
        if (resource.severity == null)
          throw new nitro_exception(resource.message, resource.errorcode);
        if (resource.severity.Equals("ERROR"))
          throw new nitro_exception(resource.message, resource.errorcode);
      }
      return (base_resource[]) resource.fis_binding;
    }

    internal override string get_object_name() => this.name;

    public static fis_binding get(nitro_service service, string name) => (fis_binding) new fis_binding()
    {
      name = name
    }.get_resource(service);

    public static fis_binding[] get(nitro_service service, string[] name)
    {
      if (name == null || name.Length <= 0)
        return (fis_binding[]) null;
      fis_binding[] fisBindingArray1 = new fis_binding[name.Length];
      fis_binding[] fisBindingArray2 = new fis_binding[name.Length];
      for (int index = 0; index < name.Length; ++index)
      {
        fisBindingArray2[index] = new fis_binding();
        fisBindingArray2[index].name = name[index];
        fisBindingArray1[index] = (fis_binding) fisBindingArray2[index].get_resource(service);
      }
      return fisBindingArray1;
    }

    private class fis_binding_response : base_response
    {
      public fis_binding[] fis_binding = (fis_binding[]) null;
    }
  }
}
