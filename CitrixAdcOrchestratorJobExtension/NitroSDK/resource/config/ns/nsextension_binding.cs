// Decompiled with JetBrains decompiler
// Type: com.citrix.netscaler.nitro.resource.config.ns.nsextension_binding
// Assembly: nitro, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 6CF5DDEF-E052-4F9D-953F-6644F8378A66


using com.citrix.netscaler.nitro.exception;
using com.citrix.netscaler.nitro.resource.Base;
using com.citrix.netscaler.nitro.service;

namespace com.citrix.netscaler.nitro.resource.config.ns
{
  public class nsextension_binding : base_resource
  {
    private string nameField = (string) null;
    private com.citrix.netscaler.nitro.resource.config.ns.nsextension_extensionfunction_binding[] nsextension_extensionfunction_bindingField = (com.citrix.netscaler.nitro.resource.config.ns.nsextension_extensionfunction_binding[]) null;

    public string name
    {
      get => this.nameField;
      set => this.nameField = value;
    }

    public com.citrix.netscaler.nitro.resource.config.ns.nsextension_extensionfunction_binding[] nsextension_extensionfunction_binding
    {
      get => this.nsextension_extensionfunction_bindingField;
      private set => this.nsextension_extensionfunction_bindingField = value;
    }

    internal override base_resource[] get_nitro_response(
      nitro_service service,
      string response)
    {
      nsextension_binding.nsextension_binding_response nsextensionBindingResponse = new nsextension_binding.nsextension_binding_response();
      nsextension_binding.nsextension_binding_response resource = (nsextension_binding.nsextension_binding_response) service.get_payload_formatter().string_to_resource(nsextensionBindingResponse.GetType(), response);
      if (resource.errorcode != 0)
      {
        if (resource.errorcode == 444)
          service.clear_session();
        if (resource.severity == null)
          throw new nitro_exception(resource.message, resource.errorcode);
        if (resource.severity.Equals("ERROR"))
          throw new nitro_exception(resource.message, resource.errorcode);
      }
      return (base_resource[]) resource.nsextension_binding;
    }

    internal override string get_object_name() => this.name;

    public static nsextension_binding get(nitro_service service, string name) => (nsextension_binding) new nsextension_binding()
    {
      name = name
    }.get_resource(service);

    public static nsextension_binding[] get(nitro_service service, string[] name)
    {
      if (name == null || name.Length <= 0)
        return (nsextension_binding[]) null;
      nsextension_binding[] nsextensionBindingArray1 = new nsextension_binding[name.Length];
      nsextension_binding[] nsextensionBindingArray2 = new nsextension_binding[name.Length];
      for (int index = 0; index < name.Length; ++index)
      {
        nsextensionBindingArray2[index] = new nsextension_binding();
        nsextensionBindingArray2[index].name = name[index];
        nsextensionBindingArray1[index] = (nsextension_binding) nsextensionBindingArray2[index].get_resource(service);
      }
      return nsextensionBindingArray1;
    }

    private class nsextension_binding_response : base_response
    {
      public nsextension_binding[] nsextension_binding = (nsextension_binding[]) null;
    }
  }
}
