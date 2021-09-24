// Decompiled with JetBrains decompiler
// Type: com.citrix.netscaler.nitro.resource.config.network.ipset_binding
// Assembly: nitro, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 6CF5DDEF-E052-4F9D-953F-6644F8378A66


using com.citrix.netscaler.nitro.exception;
using com.citrix.netscaler.nitro.resource.Base;
using com.citrix.netscaler.nitro.service;

namespace com.citrix.netscaler.nitro.resource.config.network
{
  public class ipset_binding : base_resource
  {
    private string nameField = (string) null;
    private com.citrix.netscaler.nitro.resource.config.network.ipset_nsip_binding[] ipset_nsip_bindingField = (com.citrix.netscaler.nitro.resource.config.network.ipset_nsip_binding[]) null;
    private com.citrix.netscaler.nitro.resource.config.network.ipset_nsip6_binding[] ipset_nsip6_bindingField = (com.citrix.netscaler.nitro.resource.config.network.ipset_nsip6_binding[]) null;

    public string name
    {
      get => this.nameField;
      set => this.nameField = value;
    }

    public com.citrix.netscaler.nitro.resource.config.network.ipset_nsip_binding[] ipset_nsip_binding
    {
      get => this.ipset_nsip_bindingField;
      private set => this.ipset_nsip_bindingField = value;
    }

    public com.citrix.netscaler.nitro.resource.config.network.ipset_nsip6_binding[] ipset_nsip6_binding
    {
      get => this.ipset_nsip6_bindingField;
      private set => this.ipset_nsip6_bindingField = value;
    }

    internal override base_resource[] get_nitro_response(
      nitro_service service,
      string response)
    {
      ipset_binding.ipset_binding_response ipsetBindingResponse = new ipset_binding.ipset_binding_response();
      ipset_binding.ipset_binding_response resource = (ipset_binding.ipset_binding_response) service.get_payload_formatter().string_to_resource(ipsetBindingResponse.GetType(), response);
      if (resource.errorcode != 0)
      {
        if (resource.errorcode == 444)
          service.clear_session();
        if (resource.severity == null)
          throw new nitro_exception(resource.message, resource.errorcode);
        if (resource.severity.Equals("ERROR"))
          throw new nitro_exception(resource.message, resource.errorcode);
      }
      return (base_resource[]) resource.ipset_binding;
    }

    internal override string get_object_name() => this.name;

    public static ipset_binding get(nitro_service service, string name) => (ipset_binding) new ipset_binding()
    {
      name = name
    }.get_resource(service);

    public static ipset_binding[] get(nitro_service service, string[] name)
    {
      if (name == null || name.Length <= 0)
        return (ipset_binding[]) null;
      ipset_binding[] ipsetBindingArray1 = new ipset_binding[name.Length];
      ipset_binding[] ipsetBindingArray2 = new ipset_binding[name.Length];
      for (int index = 0; index < name.Length; ++index)
      {
        ipsetBindingArray2[index] = new ipset_binding();
        ipsetBindingArray2[index].name = name[index];
        ipsetBindingArray1[index] = (ipset_binding) ipsetBindingArray2[index].get_resource(service);
      }
      return ipsetBindingArray1;
    }

    private class ipset_binding_response : base_response
    {
      public ipset_binding[] ipset_binding = (ipset_binding[]) null;
    }
  }
}
