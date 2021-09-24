// Decompiled with JetBrains decompiler
// Type: com.citrix.netscaler.nitro.resource.config.gslb.gslbvserver_spilloverpolicy_binding
// Assembly: nitro, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 6CF5DDEF-E052-4F9D-953F-6644F8378A66


using com.citrix.netscaler.nitro.exception;
using com.citrix.netscaler.nitro.resource.Base;
using com.citrix.netscaler.nitro.service;
using com.citrix.netscaler.nitro.util;

namespace com.citrix.netscaler.nitro.resource.config.gslb
{
  public class gslbvserver_spilloverpolicy_binding : base_resource
  {
    private string policynameField = (string) null;
    private string gotopriorityexpressionField = (string) null;
    private string typeField = (string) null;
    private uint? priorityField = new uint?();
    private string nameField = (string) null;
    private uint? __countField = new uint?();

    public uint? __count
    {
      get => this.__countField;
      set => this.__countField = value;
    }

    public uint? priority
    {
      get => this.priorityField;
      set => this.priorityField = value;
    }

    public string gotopriorityexpression
    {
      get => this.gotopriorityexpressionField;
      set => this.gotopriorityexpressionField = value;
    }

    public string policyname
    {
      get => this.policynameField;
      set => this.policynameField = value;
    }

    public string name
    {
      get => this.nameField;
      set => this.nameField = value;
    }

    public string type
    {
      get => this.typeField;
      set => this.typeField = value;
    }

    internal override base_resource[] get_nitro_response(
      nitro_service service,
      string response)
    {
      gslbvserver_spilloverpolicy_binding.gslbvserver_spilloverpolicy_binding_response spilloverpolicyBindingResponse = new gslbvserver_spilloverpolicy_binding.gslbvserver_spilloverpolicy_binding_response();
      gslbvserver_spilloverpolicy_binding.gslbvserver_spilloverpolicy_binding_response resource = (gslbvserver_spilloverpolicy_binding.gslbvserver_spilloverpolicy_binding_response) service.get_payload_formatter().string_to_resource(spilloverpolicyBindingResponse.GetType(), response);
      if (resource.errorcode != 0)
      {
        if (resource.errorcode == 444)
          service.clear_session();
        if (resource.severity == null)
          throw new nitro_exception(resource.message, resource.errorcode);
        if (resource.severity.Equals("ERROR"))
          throw new nitro_exception(resource.message, resource.errorcode);
      }
      return (base_resource[]) resource.gslbvserver_spilloverpolicy_binding;
    }

    internal override string get_object_name() => this.name;

    public static base_response add(
      nitro_service client,
      gslbvserver_spilloverpolicy_binding resource)
    {
      return new gslbvserver_spilloverpolicy_binding()
      {
        name = resource.name,
        policyname = resource.policyname,
        priority = resource.priority,
        gotopriorityexpression = resource.gotopriorityexpression,
        type = resource.type
      }.update_resource(client);
    }

    public static base_responses add(
      nitro_service client,
      gslbvserver_spilloverpolicy_binding[] resources)
    {
      base_responses baseResponses = (base_responses) null;
      if (resources != null && resources.Length > 0)
      {
        gslbvserver_spilloverpolicy_binding[] spilloverpolicyBindingArray = new gslbvserver_spilloverpolicy_binding[resources.Length];
        for (int index = 0; index < resources.Length; ++index)
        {
          spilloverpolicyBindingArray[index] = new gslbvserver_spilloverpolicy_binding();
          spilloverpolicyBindingArray[index].name = resources[index].name;
          spilloverpolicyBindingArray[index].policyname = resources[index].policyname;
          spilloverpolicyBindingArray[index].priority = resources[index].priority;
          spilloverpolicyBindingArray[index].gotopriorityexpression = resources[index].gotopriorityexpression;
          spilloverpolicyBindingArray[index].type = resources[index].type;
        }
        baseResponses = base_resource.update_bulk_request(client, (base_resource[]) spilloverpolicyBindingArray);
      }
      return baseResponses;
    }

    public static base_response delete(
      nitro_service client,
      gslbvserver_spilloverpolicy_binding resource)
    {
      return new gslbvserver_spilloverpolicy_binding()
      {
        name = resource.name,
        policyname = resource.policyname
      }.delete_resource(client);
    }

    public static base_responses delete(
      nitro_service client,
      gslbvserver_spilloverpolicy_binding[] resources)
    {
      base_responses baseResponses = (base_responses) null;
      if (resources != null && resources.Length > 0)
      {
        gslbvserver_spilloverpolicy_binding[] spilloverpolicyBindingArray = new gslbvserver_spilloverpolicy_binding[resources.Length];
        for (int index = 0; index < resources.Length; ++index)
        {
          spilloverpolicyBindingArray[index] = new gslbvserver_spilloverpolicy_binding();
          spilloverpolicyBindingArray[index].name = resources[index].name;
          spilloverpolicyBindingArray[index].policyname = resources[index].policyname;
        }
        baseResponses = base_resource.delete_bulk_request(client, (base_resource[]) spilloverpolicyBindingArray);
      }
      return baseResponses;
    }

    public static gslbvserver_spilloverpolicy_binding[] get(
      nitro_service service,
      string name)
    {
      return (gslbvserver_spilloverpolicy_binding[]) new gslbvserver_spilloverpolicy_binding()
      {
        name = name
      }.get_resources(service, (options) null);
    }

    public static gslbvserver_spilloverpolicy_binding[] get_filtered(
      nitro_service service,
      string name,
      string filter)
    {
      gslbvserver_spilloverpolicy_binding spilloverpolicyBinding = new gslbvserver_spilloverpolicy_binding();
      spilloverpolicyBinding.name = name;
      options option = new options();
      option.set_filter(filter);
      return (gslbvserver_spilloverpolicy_binding[]) spilloverpolicyBinding.getfiltered(service, option);
    }

    public static gslbvserver_spilloverpolicy_binding[] get_filtered(
      nitro_service service,
      string name,
      filtervalue[] filter)
    {
      gslbvserver_spilloverpolicy_binding spilloverpolicyBinding = new gslbvserver_spilloverpolicy_binding();
      spilloverpolicyBinding.name = name;
      options option = new options();
      option.set_filter(filter);
      return (gslbvserver_spilloverpolicy_binding[]) spilloverpolicyBinding.getfiltered(service, option);
    }

    public static uint count(nitro_service service, string name)
    {
      gslbvserver_spilloverpolicy_binding spilloverpolicyBinding = new gslbvserver_spilloverpolicy_binding();
      spilloverpolicyBinding.name = name;
      options option = new options();
      option.set_count(true);
      gslbvserver_spilloverpolicy_binding[] resources = (gslbvserver_spilloverpolicy_binding[]) spilloverpolicyBinding.get_resources(service, option);
      return resources != null && resources.Length > 0 ? resources[0].__count.Value : 0U;
    }

    public static uint count_filtered(nitro_service service, string name, string filter)
    {
      gslbvserver_spilloverpolicy_binding spilloverpolicyBinding = new gslbvserver_spilloverpolicy_binding();
      spilloverpolicyBinding.name = name;
      options option = new options();
      option.set_count(true);
      option.set_filter(filter);
      gslbvserver_spilloverpolicy_binding[] spilloverpolicyBindingArray = (gslbvserver_spilloverpolicy_binding[]) spilloverpolicyBinding.getfiltered(service, option);
      return spilloverpolicyBindingArray != null && spilloverpolicyBindingArray.Length > 0 ? spilloverpolicyBindingArray[0].__count.Value : 0U;
    }

    public static uint count_filtered(nitro_service service, string name, filtervalue[] filter)
    {
      gslbvserver_spilloverpolicy_binding spilloverpolicyBinding = new gslbvserver_spilloverpolicy_binding();
      spilloverpolicyBinding.name = name;
      options option = new options();
      option.set_count(true);
      option.set_filter(filter);
      gslbvserver_spilloverpolicy_binding[] spilloverpolicyBindingArray = (gslbvserver_spilloverpolicy_binding[]) spilloverpolicyBinding.getfiltered(service, option);
      return spilloverpolicyBindingArray != null && spilloverpolicyBindingArray.Length > 0 ? spilloverpolicyBindingArray[0].__count.Value : 0U;
    }

    private class gslbvserver_spilloverpolicy_binding_response : base_response
    {
      public gslbvserver_spilloverpolicy_binding[] gslbvserver_spilloverpolicy_binding = (gslbvserver_spilloverpolicy_binding[]) null;
    }

    public static class typeEnum
    {
      public const string REQUEST = "REQUEST";
      public const string RESPONSE = "RESPONSE";
    }
  }
}
