// Decompiled with JetBrains decompiler
// Type: com.citrix.netscaler.nitro.resource.config.network.channel_binding
// Assembly: nitro, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 6CF5DDEF-E052-4F9D-953F-6644F8378A66


using com.citrix.netscaler.nitro.exception;
using com.citrix.netscaler.nitro.resource.Base;
using com.citrix.netscaler.nitro.service;

namespace com.citrix.netscaler.nitro.resource.config.network
{
  public class channel_binding : base_resource
  {
    private string idField = (string) null;
    private com.citrix.netscaler.nitro.resource.config.network.channel_interface_binding[] channel_interface_bindingField = (com.citrix.netscaler.nitro.resource.config.network.channel_interface_binding[]) null;

    public string id
    {
      get => this.idField;
      set => this.idField = value;
    }

    public com.citrix.netscaler.nitro.resource.config.network.channel_interface_binding[] channel_interface_binding
    {
      get => this.channel_interface_bindingField;
      private set => this.channel_interface_bindingField = value;
    }

    internal override base_resource[] get_nitro_response(
      nitro_service service,
      string response)
    {
      channel_binding.channel_binding_response channelBindingResponse = new channel_binding.channel_binding_response();
      channel_binding.channel_binding_response resource = (channel_binding.channel_binding_response) service.get_payload_formatter().string_to_resource(channelBindingResponse.GetType(), response);
      if (resource.errorcode != 0)
      {
        if (resource.errorcode == 444)
          service.clear_session();
        if (resource.severity == null)
          throw new nitro_exception(resource.message, resource.errorcode);
        if (resource.severity.Equals("ERROR"))
          throw new nitro_exception(resource.message, resource.errorcode);
      }
      return (base_resource[]) resource.channel_binding;
    }

    internal override string get_object_name() => this.id;

    public static channel_binding get(nitro_service service, string id) => (channel_binding) new channel_binding()
    {
      id = id
    }.get_resource(service);

    public static channel_binding[] get(nitro_service service, string[] id)
    {
      if (id == null || id.Length <= 0)
        return (channel_binding[]) null;
      channel_binding[] channelBindingArray1 = new channel_binding[id.Length];
      channel_binding[] channelBindingArray2 = new channel_binding[id.Length];
      for (int index = 0; index < id.Length; ++index)
      {
        channelBindingArray2[index] = new channel_binding();
        channelBindingArray2[index].id = id[index];
        channelBindingArray1[index] = (channel_binding) channelBindingArray2[index].get_resource(service);
      }
      return channelBindingArray1;
    }

    private class channel_binding_response : base_response
    {
      public channel_binding[] channel_binding = (channel_binding[]) null;
    }
  }
}
