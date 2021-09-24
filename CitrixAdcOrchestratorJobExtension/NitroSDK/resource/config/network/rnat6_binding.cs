// Decompiled with JetBrains decompiler
// Type: com.citrix.netscaler.nitro.resource.config.network.rnat6_binding
// Assembly: nitro, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 6CF5DDEF-E052-4F9D-953F-6644F8378A66


using com.citrix.netscaler.nitro.exception;
using com.citrix.netscaler.nitro.resource.Base;
using com.citrix.netscaler.nitro.service;

namespace com.citrix.netscaler.nitro.resource.config.network
{
  public class rnat6_binding : base_resource
  {
    private string nameField = (string) null;
    private com.citrix.netscaler.nitro.resource.config.network.rnat6_nsip6_binding[] rnat6_nsip6_bindingField = (com.citrix.netscaler.nitro.resource.config.network.rnat6_nsip6_binding[]) null;

    public string name
    {
      get => this.nameField;
      set => this.nameField = value;
    }

    public com.citrix.netscaler.nitro.resource.config.network.rnat6_nsip6_binding[] rnat6_nsip6_binding
    {
      get => this.rnat6_nsip6_bindingField;
      private set => this.rnat6_nsip6_bindingField = value;
    }

    internal override base_resource[] get_nitro_response(
      nitro_service service,
      string response)
    {
      rnat6_binding.rnat6_binding_response rnat6BindingResponse = new rnat6_binding.rnat6_binding_response();
      rnat6_binding.rnat6_binding_response resource = (rnat6_binding.rnat6_binding_response) service.get_payload_formatter().string_to_resource(rnat6BindingResponse.GetType(), response);
      if (resource.errorcode != 0)
      {
        if (resource.errorcode == 444)
          service.clear_session();
        if (resource.severity == null)
          throw new nitro_exception(resource.message, resource.errorcode);
        if (resource.severity.Equals("ERROR"))
          throw new nitro_exception(resource.message, resource.errorcode);
      }
      return (base_resource[]) resource.rnat6_binding;
    }

    internal override string get_object_name() => this.name;

    public static rnat6_binding get(nitro_service service, string name) => (rnat6_binding) new rnat6_binding()
    {
      name = name
    }.get_resource(service);

    public static rnat6_binding[] get(nitro_service service, string[] name)
    {
      if (name == null || name.Length <= 0)
        return (rnat6_binding[]) null;
      rnat6_binding[] rnat6BindingArray1 = new rnat6_binding[name.Length];
      rnat6_binding[] rnat6BindingArray2 = new rnat6_binding[name.Length];
      for (int index = 0; index < name.Length; ++index)
      {
        rnat6BindingArray2[index] = new rnat6_binding();
        rnat6BindingArray2[index].name = name[index];
        rnat6BindingArray1[index] = (rnat6_binding) rnat6BindingArray2[index].get_resource(service);
      }
      return rnat6BindingArray1;
    }

    private class rnat6_binding_response : base_response
    {
      public rnat6_binding[] rnat6_binding = (rnat6_binding[]) null;
    }
  }
}
