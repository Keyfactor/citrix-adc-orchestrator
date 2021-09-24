// Decompiled with JetBrains decompiler
// Type: com.citrix.netscaler.nitro.resource.config.ns.nstimer_binding
// Assembly: nitro, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 6CF5DDEF-E052-4F9D-953F-6644F8378A66


using com.citrix.netscaler.nitro.exception;
using com.citrix.netscaler.nitro.resource.Base;
using com.citrix.netscaler.nitro.service;

namespace com.citrix.netscaler.nitro.resource.config.ns
{
  public class nstimer_binding : base_resource
  {
    private string nameField = (string) null;
    private com.citrix.netscaler.nitro.resource.config.ns.nstimer_autoscalepolicy_binding[] nstimer_autoscalepolicy_bindingField = (com.citrix.netscaler.nitro.resource.config.ns.nstimer_autoscalepolicy_binding[]) null;

    public string name
    {
      get => this.nameField;
      set => this.nameField = value;
    }

    public com.citrix.netscaler.nitro.resource.config.ns.nstimer_autoscalepolicy_binding[] nstimer_autoscalepolicy_binding
    {
      get => this.nstimer_autoscalepolicy_bindingField;
      private set => this.nstimer_autoscalepolicy_bindingField = value;
    }

    internal override base_resource[] get_nitro_response(
      nitro_service service,
      string response)
    {
      nstimer_binding.nstimer_binding_response nstimerBindingResponse = new nstimer_binding.nstimer_binding_response();
      nstimer_binding.nstimer_binding_response resource = (nstimer_binding.nstimer_binding_response) service.get_payload_formatter().string_to_resource(nstimerBindingResponse.GetType(), response);
      if (resource.errorcode != 0)
      {
        if (resource.errorcode == 444)
          service.clear_session();
        if (resource.severity == null)
          throw new nitro_exception(resource.message, resource.errorcode);
        if (resource.severity.Equals("ERROR"))
          throw new nitro_exception(resource.message, resource.errorcode);
      }
      return (base_resource[]) resource.nstimer_binding;
    }

    internal override string get_object_name() => this.name;

    public static nstimer_binding get(nitro_service service, string name) => (nstimer_binding) new nstimer_binding()
    {
      name = name
    }.get_resource(service);

    public static nstimer_binding[] get(nitro_service service, string[] name)
    {
      if (name == null || name.Length <= 0)
        return (nstimer_binding[]) null;
      nstimer_binding[] nstimerBindingArray1 = new nstimer_binding[name.Length];
      nstimer_binding[] nstimerBindingArray2 = new nstimer_binding[name.Length];
      for (int index = 0; index < name.Length; ++index)
      {
        nstimerBindingArray2[index] = new nstimer_binding();
        nstimerBindingArray2[index].name = name[index];
        nstimerBindingArray1[index] = (nstimer_binding) nstimerBindingArray2[index].get_resource(service);
      }
      return nstimerBindingArray1;
    }

    private class nstimer_binding_response : base_response
    {
      public nstimer_binding[] nstimer_binding = (nstimer_binding[]) null;
    }
  }
}
