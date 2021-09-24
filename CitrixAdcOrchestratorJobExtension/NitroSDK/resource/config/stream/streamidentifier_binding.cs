// Decompiled with JetBrains decompiler
// Type: com.citrix.netscaler.nitro.resource.config.stream.streamidentifier_binding
// Assembly: nitro, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 6CF5DDEF-E052-4F9D-953F-6644F8378A66


using com.citrix.netscaler.nitro.exception;
using com.citrix.netscaler.nitro.resource.Base;
using com.citrix.netscaler.nitro.service;

namespace com.citrix.netscaler.nitro.resource.config.stream
{
  public class streamidentifier_binding : base_resource
  {
    private string nameField = (string) null;
    private com.citrix.netscaler.nitro.resource.config.stream.streamidentifier_streamsession_binding[] streamidentifier_streamsession_bindingField = (com.citrix.netscaler.nitro.resource.config.stream.streamidentifier_streamsession_binding[]) null;

    public string name
    {
      get => this.nameField;
      set => this.nameField = value;
    }

    public com.citrix.netscaler.nitro.resource.config.stream.streamidentifier_streamsession_binding[] streamidentifier_streamsession_binding
    {
      get => this.streamidentifier_streamsession_bindingField;
      private set => this.streamidentifier_streamsession_bindingField = value;
    }

    internal override base_resource[] get_nitro_response(
      nitro_service service,
      string response)
    {
      streamidentifier_binding.streamidentifier_binding_response streamidentifierBindingResponse = new streamidentifier_binding.streamidentifier_binding_response();
      streamidentifier_binding.streamidentifier_binding_response resource = (streamidentifier_binding.streamidentifier_binding_response) service.get_payload_formatter().string_to_resource(streamidentifierBindingResponse.GetType(), response);
      if (resource.errorcode != 0)
      {
        if (resource.errorcode == 444)
          service.clear_session();
        if (resource.severity == null)
          throw new nitro_exception(resource.message, resource.errorcode);
        if (resource.severity.Equals("ERROR"))
          throw new nitro_exception(resource.message, resource.errorcode);
      }
      return (base_resource[]) resource.streamidentifier_binding;
    }

    internal override string get_object_name() => this.name;

    public static streamidentifier_binding get(
      nitro_service service,
      string name)
    {
      return (streamidentifier_binding) new streamidentifier_binding()
      {
        name = name
      }.get_resource(service);
    }

    public static streamidentifier_binding[] get(
      nitro_service service,
      string[] name)
    {
      if (name == null || name.Length <= 0)
        return (streamidentifier_binding[]) null;
      streamidentifier_binding[] streamidentifierBindingArray1 = new streamidentifier_binding[name.Length];
      streamidentifier_binding[] streamidentifierBindingArray2 = new streamidentifier_binding[name.Length];
      for (int index = 0; index < name.Length; ++index)
      {
        streamidentifierBindingArray2[index] = new streamidentifier_binding();
        streamidentifierBindingArray2[index].name = name[index];
        streamidentifierBindingArray1[index] = (streamidentifier_binding) streamidentifierBindingArray2[index].get_resource(service);
      }
      return streamidentifierBindingArray1;
    }

    private class streamidentifier_binding_response : base_response
    {
      public streamidentifier_binding[] streamidentifier_binding = (streamidentifier_binding[]) null;
    }
  }
}
