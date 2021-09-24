// Decompiled with JetBrains decompiler
// Type: com.citrix.netscaler.nitro.resource.config.cluster.clusternodegroup_streamidentifier_binding
// Assembly: nitro, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 6CF5DDEF-E052-4F9D-953F-6644F8378A66


using com.citrix.netscaler.nitro.exception;
using com.citrix.netscaler.nitro.resource.Base;
using com.citrix.netscaler.nitro.service;
using com.citrix.netscaler.nitro.util;

namespace com.citrix.netscaler.nitro.resource.config.cluster
{
  public class clusternodegroup_streamidentifier_binding : base_resource
  {
    private string identifiernameField = (string) null;
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

    public string identifiername
    {
      get => this.identifiernameField;
      set => this.identifiernameField = value;
    }

    internal override base_resource[] get_nitro_response(
      nitro_service service,
      string response)
    {
      clusternodegroup_streamidentifier_binding.clusternodegroup_streamidentifier_binding_response streamidentifierBindingResponse = new clusternodegroup_streamidentifier_binding.clusternodegroup_streamidentifier_binding_response();
      clusternodegroup_streamidentifier_binding.clusternodegroup_streamidentifier_binding_response resource = (clusternodegroup_streamidentifier_binding.clusternodegroup_streamidentifier_binding_response) service.get_payload_formatter().string_to_resource(streamidentifierBindingResponse.GetType(), response);
      if (resource.errorcode != 0)
      {
        if (resource.errorcode == 444)
          service.clear_session();
        if (resource.severity == null)
          throw new nitro_exception(resource.message, resource.errorcode);
        if (resource.severity.Equals("ERROR"))
          throw new nitro_exception(resource.message, resource.errorcode);
      }
      return (base_resource[]) resource.clusternodegroup_streamidentifier_binding;
    }

    internal override string get_object_name() => this.name;

    public static base_response add(
      nitro_service client,
      clusternodegroup_streamidentifier_binding resource)
    {
      return new clusternodegroup_streamidentifier_binding()
      {
        name = resource.name,
        identifiername = resource.identifiername
      }.update_resource(client);
    }

    public static base_responses add(
      nitro_service client,
      clusternodegroup_streamidentifier_binding[] resources)
    {
      base_responses baseResponses = (base_responses) null;
      if (resources != null && resources.Length > 0)
      {
        clusternodegroup_streamidentifier_binding[] streamidentifierBindingArray = new clusternodegroup_streamidentifier_binding[resources.Length];
        for (int index = 0; index < resources.Length; ++index)
        {
          streamidentifierBindingArray[index] = new clusternodegroup_streamidentifier_binding();
          streamidentifierBindingArray[index].name = resources[index].name;
          streamidentifierBindingArray[index].identifiername = resources[index].identifiername;
        }
        baseResponses = base_resource.update_bulk_request(client, (base_resource[]) streamidentifierBindingArray);
      }
      return baseResponses;
    }

    public static base_response delete(
      nitro_service client,
      clusternodegroup_streamidentifier_binding resource)
    {
      return new clusternodegroup_streamidentifier_binding()
      {
        name = resource.name,
        identifiername = resource.identifiername
      }.delete_resource(client);
    }

    public static base_responses delete(
      nitro_service client,
      clusternodegroup_streamidentifier_binding[] resources)
    {
      base_responses baseResponses = (base_responses) null;
      if (resources != null && resources.Length > 0)
      {
        clusternodegroup_streamidentifier_binding[] streamidentifierBindingArray = new clusternodegroup_streamidentifier_binding[resources.Length];
        for (int index = 0; index < resources.Length; ++index)
        {
          streamidentifierBindingArray[index] = new clusternodegroup_streamidentifier_binding();
          streamidentifierBindingArray[index].name = resources[index].name;
          streamidentifierBindingArray[index].identifiername = resources[index].identifiername;
        }
        baseResponses = base_resource.delete_bulk_request(client, (base_resource[]) streamidentifierBindingArray);
      }
      return baseResponses;
    }

    public static clusternodegroup_streamidentifier_binding[] get(
      nitro_service service,
      string name)
    {
      return (clusternodegroup_streamidentifier_binding[]) new clusternodegroup_streamidentifier_binding()
      {
        name = name
      }.get_resources(service, (options) null);
    }

    public static clusternodegroup_streamidentifier_binding[] get_filtered(
      nitro_service service,
      string name,
      string filter)
    {
      clusternodegroup_streamidentifier_binding streamidentifierBinding = new clusternodegroup_streamidentifier_binding();
      streamidentifierBinding.name = name;
      options option = new options();
      option.set_filter(filter);
      return (clusternodegroup_streamidentifier_binding[]) streamidentifierBinding.getfiltered(service, option);
    }

    public static clusternodegroup_streamidentifier_binding[] get_filtered(
      nitro_service service,
      string name,
      filtervalue[] filter)
    {
      clusternodegroup_streamidentifier_binding streamidentifierBinding = new clusternodegroup_streamidentifier_binding();
      streamidentifierBinding.name = name;
      options option = new options();
      option.set_filter(filter);
      return (clusternodegroup_streamidentifier_binding[]) streamidentifierBinding.getfiltered(service, option);
    }

    public static uint count(nitro_service service, string name)
    {
      clusternodegroup_streamidentifier_binding streamidentifierBinding = new clusternodegroup_streamidentifier_binding();
      streamidentifierBinding.name = name;
      options option = new options();
      option.set_count(true);
      clusternodegroup_streamidentifier_binding[] resources = (clusternodegroup_streamidentifier_binding[]) streamidentifierBinding.get_resources(service, option);
      return resources != null && resources.Length > 0 ? resources[0].__count.Value : 0U;
    }

    public static uint count_filtered(nitro_service service, string name, string filter)
    {
      clusternodegroup_streamidentifier_binding streamidentifierBinding = new clusternodegroup_streamidentifier_binding();
      streamidentifierBinding.name = name;
      options option = new options();
      option.set_count(true);
      option.set_filter(filter);
      clusternodegroup_streamidentifier_binding[] streamidentifierBindingArray = (clusternodegroup_streamidentifier_binding[]) streamidentifierBinding.getfiltered(service, option);
      return streamidentifierBindingArray != null && streamidentifierBindingArray.Length > 0 ? streamidentifierBindingArray[0].__count.Value : 0U;
    }

    public static uint count_filtered(nitro_service service, string name, filtervalue[] filter)
    {
      clusternodegroup_streamidentifier_binding streamidentifierBinding = new clusternodegroup_streamidentifier_binding();
      streamidentifierBinding.name = name;
      options option = new options();
      option.set_count(true);
      option.set_filter(filter);
      clusternodegroup_streamidentifier_binding[] streamidentifierBindingArray = (clusternodegroup_streamidentifier_binding[]) streamidentifierBinding.getfiltered(service, option);
      return streamidentifierBindingArray != null && streamidentifierBindingArray.Length > 0 ? streamidentifierBindingArray[0].__count.Value : 0U;
    }

    private class clusternodegroup_streamidentifier_binding_response : base_response
    {
      public clusternodegroup_streamidentifier_binding[] clusternodegroup_streamidentifier_binding = (clusternodegroup_streamidentifier_binding[]) null;
    }
  }
}
