// Decompiled with JetBrains decompiler
// Type: com.citrix.netscaler.nitro.resource.config.autoscale.autoscalepolicy_binding
// Assembly: nitro, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 6CF5DDEF-E052-4F9D-953F-6644F8378A66


using com.citrix.netscaler.nitro.exception;
using com.citrix.netscaler.nitro.resource.Base;
using com.citrix.netscaler.nitro.service;

namespace com.citrix.netscaler.nitro.resource.config.autoscale
{
  public class autoscalepolicy_binding : base_resource
  {
    private string nameField = (string) null;
    private com.citrix.netscaler.nitro.resource.config.autoscale.autoscalepolicy_nstimer_binding[] autoscalepolicy_nstimer_bindingField = (com.citrix.netscaler.nitro.resource.config.autoscale.autoscalepolicy_nstimer_binding[]) null;

    public string name
    {
      get => this.nameField;
      set => this.nameField = value;
    }

    public com.citrix.netscaler.nitro.resource.config.autoscale.autoscalepolicy_nstimer_binding[] autoscalepolicy_nstimer_binding
    {
      get => this.autoscalepolicy_nstimer_bindingField;
      private set => this.autoscalepolicy_nstimer_bindingField = value;
    }

    internal override base_resource[] get_nitro_response(
      nitro_service service,
      string response)
    {
      autoscalepolicy_binding.autoscalepolicy_binding_response autoscalepolicyBindingResponse = new autoscalepolicy_binding.autoscalepolicy_binding_response();
      autoscalepolicy_binding.autoscalepolicy_binding_response resource = (autoscalepolicy_binding.autoscalepolicy_binding_response) service.get_payload_formatter().string_to_resource(autoscalepolicyBindingResponse.GetType(), response);
      if (resource.errorcode != 0)
      {
        if (resource.errorcode == 444)
          service.clear_session();
        if (resource.severity == null)
          throw new nitro_exception(resource.message, resource.errorcode);
        if (resource.severity.Equals("ERROR"))
          throw new nitro_exception(resource.message, resource.errorcode);
      }
      return (base_resource[]) resource.autoscalepolicy_binding;
    }

    internal override string get_object_name() => this.name;

    public static autoscalepolicy_binding get(
      nitro_service service,
      string name)
    {
      return (autoscalepolicy_binding) new autoscalepolicy_binding()
      {
        name = name
      }.get_resource(service);
    }

    public static autoscalepolicy_binding[] get(
      nitro_service service,
      string[] name)
    {
      if (name == null || name.Length <= 0)
        return (autoscalepolicy_binding[]) null;
      autoscalepolicy_binding[] autoscalepolicyBindingArray1 = new autoscalepolicy_binding[name.Length];
      autoscalepolicy_binding[] autoscalepolicyBindingArray2 = new autoscalepolicy_binding[name.Length];
      for (int index = 0; index < name.Length; ++index)
      {
        autoscalepolicyBindingArray2[index] = new autoscalepolicy_binding();
        autoscalepolicyBindingArray2[index].name = name[index];
        autoscalepolicyBindingArray1[index] = (autoscalepolicy_binding) autoscalepolicyBindingArray2[index].get_resource(service);
      }
      return autoscalepolicyBindingArray1;
    }

    private class autoscalepolicy_binding_response : base_response
    {
      public autoscalepolicy_binding[] autoscalepolicy_binding = (autoscalepolicy_binding[]) null;
    }
  }
}
