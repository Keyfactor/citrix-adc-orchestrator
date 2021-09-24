// Decompiled with JetBrains decompiler
// Type: com.citrix.netscaler.nitro.resource.config.lb.lbvserver_servicegroup_binding
// Assembly: nitro, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 6CF5DDEF-E052-4F9D-953F-6644F8378A66


using com.citrix.netscaler.nitro.exception;
using com.citrix.netscaler.nitro.resource.Base;
using com.citrix.netscaler.nitro.service;
using com.citrix.netscaler.nitro.util;

namespace com.citrix.netscaler.nitro.resource.config.lb
{
  public class lbvserver_servicegroup_binding : base_resource
  {
    private string servicegroupnameField = (string) null;
    private string servicenameField = (string) null;
    private string nameField = (string) null;
    private uint? weightField = new uint?();
    private uint? __countField = new uint?();

    public uint? __count
    {
      get => this.__countField;
      set => this.__countField = value;
    }

    public uint? weight
    {
      get => this.weightField;
      set => this.weightField = value;
    }

    public string name
    {
      get => this.nameField;
      set => this.nameField = value;
    }

    public string servicename
    {
      get => this.servicenameField;
      set => this.servicenameField = value;
    }

    public string servicegroupname
    {
      get => this.servicegroupnameField;
      set => this.servicegroupnameField = value;
    }

    internal override base_resource[] get_nitro_response(
      nitro_service service,
      string response)
    {
      lbvserver_servicegroup_binding.lbvserver_servicegroup_binding_response servicegroupBindingResponse = new lbvserver_servicegroup_binding.lbvserver_servicegroup_binding_response();
      lbvserver_servicegroup_binding.lbvserver_servicegroup_binding_response resource = (lbvserver_servicegroup_binding.lbvserver_servicegroup_binding_response) service.get_payload_formatter().string_to_resource(servicegroupBindingResponse.GetType(), response);
      if (resource.errorcode != 0)
      {
        if (resource.errorcode == 444)
          service.clear_session();
        if (resource.severity == null)
          throw new nitro_exception(resource.message, resource.errorcode);
        if (resource.severity.Equals("ERROR"))
          throw new nitro_exception(resource.message, resource.errorcode);
      }
      return (base_resource[]) resource.lbvserver_servicegroup_binding;
    }

    internal override string get_object_name() => this.name;

    public static base_response add(
      nitro_service client,
      lbvserver_servicegroup_binding resource)
    {
      return new lbvserver_servicegroup_binding()
      {
        name = resource.name,
        servicename = resource.servicename,
        weight = resource.weight,
        servicegroupname = resource.servicegroupname
      }.update_resource(client);
    }

    public static base_responses add(
      nitro_service client,
      lbvserver_servicegroup_binding[] resources)
    {
      base_responses baseResponses = (base_responses) null;
      if (resources != null && resources.Length > 0)
      {
        lbvserver_servicegroup_binding[] servicegroupBindingArray = new lbvserver_servicegroup_binding[resources.Length];
        for (int index = 0; index < resources.Length; ++index)
        {
          servicegroupBindingArray[index] = new lbvserver_servicegroup_binding();
          servicegroupBindingArray[index].name = resources[index].name;
          servicegroupBindingArray[index].servicename = resources[index].servicename;
          servicegroupBindingArray[index].weight = resources[index].weight;
          servicegroupBindingArray[index].servicegroupname = resources[index].servicegroupname;
        }
        baseResponses = base_resource.update_bulk_request(client, (base_resource[]) servicegroupBindingArray);
      }
      return baseResponses;
    }

    public static base_response delete(
      nitro_service client,
      lbvserver_servicegroup_binding resource)
    {
      return new lbvserver_servicegroup_binding()
      {
        name = resource.name,
        servicename = resource.servicename,
        servicegroupname = resource.servicegroupname
      }.delete_resource(client);
    }

    public static base_responses delete(
      nitro_service client,
      lbvserver_servicegroup_binding[] resources)
    {
      base_responses baseResponses = (base_responses) null;
      if (resources != null && resources.Length > 0)
      {
        lbvserver_servicegroup_binding[] servicegroupBindingArray = new lbvserver_servicegroup_binding[resources.Length];
        for (int index = 0; index < resources.Length; ++index)
        {
          servicegroupBindingArray[index] = new lbvserver_servicegroup_binding();
          servicegroupBindingArray[index].name = resources[index].name;
          servicegroupBindingArray[index].servicename = resources[index].servicename;
          servicegroupBindingArray[index].servicegroupname = resources[index].servicegroupname;
        }
        baseResponses = base_resource.delete_bulk_request(client, (base_resource[]) servicegroupBindingArray);
      }
      return baseResponses;
    }

    public static lbvserver_servicegroup_binding[] get(
      nitro_service service,
      string name)
    {
      return (lbvserver_servicegroup_binding[]) new lbvserver_servicegroup_binding()
      {
        name = name
      }.get_resources(service, (options) null);
    }

    public static lbvserver_servicegroup_binding[] get_filtered(
      nitro_service service,
      string name,
      string filter)
    {
      lbvserver_servicegroup_binding servicegroupBinding = new lbvserver_servicegroup_binding();
      servicegroupBinding.name = name;
      options option = new options();
      option.set_filter(filter);
      return (lbvserver_servicegroup_binding[]) servicegroupBinding.getfiltered(service, option);
    }

    public static lbvserver_servicegroup_binding[] get_filtered(
      nitro_service service,
      string name,
      filtervalue[] filter)
    {
      lbvserver_servicegroup_binding servicegroupBinding = new lbvserver_servicegroup_binding();
      servicegroupBinding.name = name;
      options option = new options();
      option.set_filter(filter);
      return (lbvserver_servicegroup_binding[]) servicegroupBinding.getfiltered(service, option);
    }

    public static uint count(nitro_service service, string name)
    {
      lbvserver_servicegroup_binding servicegroupBinding = new lbvserver_servicegroup_binding();
      servicegroupBinding.name = name;
      options option = new options();
      option.set_count(true);
      lbvserver_servicegroup_binding[] resources = (lbvserver_servicegroup_binding[]) servicegroupBinding.get_resources(service, option);
      return resources != null && resources.Length > 0 ? resources[0].__count.Value : 0U;
    }

    public static uint count_filtered(nitro_service service, string name, string filter)
    {
      lbvserver_servicegroup_binding servicegroupBinding = new lbvserver_servicegroup_binding();
      servicegroupBinding.name = name;
      options option = new options();
      option.set_count(true);
      option.set_filter(filter);
      lbvserver_servicegroup_binding[] servicegroupBindingArray = (lbvserver_servicegroup_binding[]) servicegroupBinding.getfiltered(service, option);
      return servicegroupBindingArray != null && servicegroupBindingArray.Length > 0 ? servicegroupBindingArray[0].__count.Value : 0U;
    }

    public static uint count_filtered(nitro_service service, string name, filtervalue[] filter)
    {
      lbvserver_servicegroup_binding servicegroupBinding = new lbvserver_servicegroup_binding();
      servicegroupBinding.name = name;
      options option = new options();
      option.set_count(true);
      option.set_filter(filter);
      lbvserver_servicegroup_binding[] servicegroupBindingArray = (lbvserver_servicegroup_binding[]) servicegroupBinding.getfiltered(service, option);
      return servicegroupBindingArray != null && servicegroupBindingArray.Length > 0 ? servicegroupBindingArray[0].__count.Value : 0U;
    }

    private class lbvserver_servicegroup_binding_response : base_response
    {
      public lbvserver_servicegroup_binding[] lbvserver_servicegroup_binding = (lbvserver_servicegroup_binding[]) null;
    }

    public static class bindpointEnum
    {
      public const string REQUEST = "REQUEST";
      public const string RESPONSE = "RESPONSE";
    }

    public static class labeltypeEnum
    {
      public const string reqvserver = "reqvserver";
      public const string resvserver = "resvserver";
      public const string policylabel = "policylabel";
    }
  }
}
