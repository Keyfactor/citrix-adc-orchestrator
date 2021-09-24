// Decompiled with JetBrains decompiler
// Type: com.citrix.netscaler.nitro.resource.config.stream.streamidentifier_streamsession_binding
// Assembly: nitro, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 6CF5DDEF-E052-4F9D-953F-6644F8378A66


using com.citrix.netscaler.nitro.exception;
using com.citrix.netscaler.nitro.resource.Base;
using com.citrix.netscaler.nitro.service;
using com.citrix.netscaler.nitro.util;

namespace com.citrix.netscaler.nitro.resource.config.stream
{
  public class streamidentifier_streamsession_binding : base_resource
  {
    private string nameField = (string) null;
    private uint? __countField = new uint?();

    public uint? __count
    {
      get => this.__countField;
      set => this.__countField = value;
    }

    public string name
    {
      get => this.nameField;
      set => this.nameField = value;
    }

    internal override base_resource[] get_nitro_response(
      nitro_service service,
      string response)
    {
      streamidentifier_streamsession_binding.streamidentifier_streamsession_binding_response streamsessionBindingResponse = new streamidentifier_streamsession_binding.streamidentifier_streamsession_binding_response();
      streamidentifier_streamsession_binding.streamidentifier_streamsession_binding_response resource = (streamidentifier_streamsession_binding.streamidentifier_streamsession_binding_response) service.get_payload_formatter().string_to_resource(streamsessionBindingResponse.GetType(), response);
      if (resource.errorcode != 0)
      {
        if (resource.errorcode == 444)
          service.clear_session();
        if (resource.severity == null)
          throw new nitro_exception(resource.message, resource.errorcode);
        if (resource.severity.Equals("ERROR"))
          throw new nitro_exception(resource.message, resource.errorcode);
      }
      return (base_resource[]) resource.streamidentifier_streamsession_binding;
    }

    internal override string get_object_name() => (string) null;

    public static streamidentifier_streamsession_binding[] get_filtered(
      nitro_service service,
      streamidentifier_streamsession_binding obj,
      string filter)
    {
      options option = new options();
      option.set_filter(filter);
      option.set_args(nitro_util.object_to_string_withoutquotes((object) obj));
      return (streamidentifier_streamsession_binding[]) obj.getfiltered(service, option);
    }

    public static streamidentifier_streamsession_binding[] get_filtered(
      nitro_service service,
      streamidentifier_streamsession_binding obj,
      filtervalue[] filter)
    {
      options option = new options();
      option.set_filter(filter);
      option.set_args(nitro_util.object_to_string_withoutquotes((object) obj));
      return (streamidentifier_streamsession_binding[]) obj.getfiltered(service, option);
    }

    public static uint count(nitro_service service, streamidentifier_streamsession_binding obj)
    {
      options option = new options();
      option.set_count(true);
      option.set_args(nitro_util.object_to_string_withoutquotes((object) obj));
      streamidentifier_streamsession_binding[] resources = (streamidentifier_streamsession_binding[]) obj.get_resources(service, option);
      return resources != null && resources.Length > 0 ? resources[0].__count.Value : 0U;
    }

    public static uint count_filtered(
      nitro_service service,
      streamidentifier_streamsession_binding obj,
      string filter)
    {
      options option = new options();
      option.set_count(true);
      option.set_filter(filter);
      option.set_args(nitro_util.object_to_string_withoutquotes((object) obj));
      streamidentifier_streamsession_binding[] streamsessionBindingArray = (streamidentifier_streamsession_binding[]) obj.getfiltered(service, option);
      return streamsessionBindingArray != null && streamsessionBindingArray.Length > 0 ? streamsessionBindingArray[0].__count.Value : 0U;
    }

    public static uint count_filtered(
      nitro_service service,
      streamidentifier_streamsession_binding obj,
      filtervalue[] filter)
    {
      options option = new options();
      option.set_count(true);
      option.set_filter(filter);
      option.set_args(nitro_util.object_to_string_withoutquotes((object) obj));
      streamidentifier_streamsession_binding[] streamsessionBindingArray = (streamidentifier_streamsession_binding[]) obj.getfiltered(service, option);
      return streamsessionBindingArray != null && streamsessionBindingArray.Length > 0 ? streamsessionBindingArray[0].__count.Value : 0U;
    }

    private class streamidentifier_streamsession_binding_response : base_response
    {
      public streamidentifier_streamsession_binding[] streamidentifier_streamsession_binding = (streamidentifier_streamsession_binding[]) null;
    }
  }
}
