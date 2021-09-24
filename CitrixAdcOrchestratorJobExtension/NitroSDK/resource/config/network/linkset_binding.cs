// Decompiled with JetBrains decompiler
// Type: com.citrix.netscaler.nitro.resource.config.network.linkset_binding
// Assembly: nitro, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 6CF5DDEF-E052-4F9D-953F-6644F8378A66


using com.citrix.netscaler.nitro.exception;
using com.citrix.netscaler.nitro.resource.Base;
using com.citrix.netscaler.nitro.service;

namespace com.citrix.netscaler.nitro.resource.config.network
{
  public class linkset_binding : base_resource
  {
    private string idField = (string) null;
    private com.citrix.netscaler.nitro.resource.config.network.linkset_interface_binding[] linkset_interface_bindingField = (com.citrix.netscaler.nitro.resource.config.network.linkset_interface_binding[]) null;
    private com.citrix.netscaler.nitro.resource.config.network.linkset_channel_binding[] linkset_channel_bindingField = (com.citrix.netscaler.nitro.resource.config.network.linkset_channel_binding[]) null;

    public string id
    {
      get => this.idField;
      set => this.idField = value;
    }

    public com.citrix.netscaler.nitro.resource.config.network.linkset_interface_binding[] linkset_interface_binding
    {
      get => this.linkset_interface_bindingField;
      private set => this.linkset_interface_bindingField = value;
    }

    public com.citrix.netscaler.nitro.resource.config.network.linkset_channel_binding[] linkset_channel_binding
    {
      get => this.linkset_channel_bindingField;
      private set => this.linkset_channel_bindingField = value;
    }

    internal override base_resource[] get_nitro_response(
      nitro_service service,
      string response)
    {
      linkset_binding.linkset_binding_response linksetBindingResponse = new linkset_binding.linkset_binding_response();
      linkset_binding.linkset_binding_response resource = (linkset_binding.linkset_binding_response) service.get_payload_formatter().string_to_resource(linksetBindingResponse.GetType(), response);
      if (resource.errorcode != 0)
      {
        if (resource.errorcode == 444)
          service.clear_session();
        if (resource.severity == null)
          throw new nitro_exception(resource.message, resource.errorcode);
        if (resource.severity.Equals("ERROR"))
          throw new nitro_exception(resource.message, resource.errorcode);
      }
      return (base_resource[]) resource.linkset_binding;
    }

    internal override string get_object_name() => this.id;

    public static linkset_binding get(nitro_service service, string id) => (linkset_binding) new linkset_binding()
    {
      id = id
    }.get_resource(service);

    public static linkset_binding[] get(nitro_service service, string[] id)
    {
      if (id == null || id.Length <= 0)
        return (linkset_binding[]) null;
      linkset_binding[] linksetBindingArray1 = new linkset_binding[id.Length];
      linkset_binding[] linksetBindingArray2 = new linkset_binding[id.Length];
      for (int index = 0; index < id.Length; ++index)
      {
        linksetBindingArray2[index] = new linkset_binding();
        linksetBindingArray2[index].id = id[index];
        linksetBindingArray1[index] = (linkset_binding) linksetBindingArray2[index].get_resource(service);
      }
      return linksetBindingArray1;
    }

    private class linkset_binding_response : base_response
    {
      public linkset_binding[] linkset_binding = (linkset_binding[]) null;
    }
  }
}
