// Decompiled with JetBrains decompiler
// Type: com.citrix.netscaler.nitro.resource.config.cs.csvserver_lbvserver_binding
// Assembly: nitro, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 6CF5DDEF-E052-4F9D-953F-6644F8378A66


using com.citrix.netscaler.nitro.exception;
using com.citrix.netscaler.nitro.resource.Base;
using com.citrix.netscaler.nitro.service;
using com.citrix.netscaler.nitro.util;

namespace com.citrix.netscaler.nitro.resource.config.cs
{
  public class csvserver_lbvserver_binding : base_resource
  {
    private string lbvserverField = (string) null;
    private uint? hitsField = new uint?();
    private string nameField = (string) null;
    private string targetvserverField = (string) null;
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

    public string targetvserver
    {
      get => this.targetvserverField;
      set => this.targetvserverField = value;
    }

    public string lbvserver
    {
      get => this.lbvserverField;
      set => this.lbvserverField = value;
    }

    public uint? hits
    {
      get => this.hitsField;
      private set => this.hitsField = value;
    }

    internal override base_resource[] get_nitro_response(
      nitro_service service,
      string response)
    {
      csvserver_lbvserver_binding.csvserver_lbvserver_binding_response lbvserverBindingResponse = new csvserver_lbvserver_binding.csvserver_lbvserver_binding_response();
      csvserver_lbvserver_binding.csvserver_lbvserver_binding_response resource = (csvserver_lbvserver_binding.csvserver_lbvserver_binding_response) service.get_payload_formatter().string_to_resource(lbvserverBindingResponse.GetType(), response);
      if (resource.errorcode != 0)
      {
        if (resource.errorcode == 444)
          service.clear_session();
        if (resource.severity == null)
          throw new nitro_exception(resource.message, resource.errorcode);
        if (resource.severity.Equals("ERROR"))
          throw new nitro_exception(resource.message, resource.errorcode);
      }
      return (base_resource[]) resource.csvserver_lbvserver_binding;
    }

    internal override string get_object_name() => this.name;

    public static base_response add(
      nitro_service client,
      csvserver_lbvserver_binding resource)
    {
      return new csvserver_lbvserver_binding()
      {
        name = resource.name,
        lbvserver = resource.lbvserver,
        targetvserver = resource.targetvserver
      }.update_resource(client);
    }

    public static base_responses add(
      nitro_service client,
      csvserver_lbvserver_binding[] resources)
    {
      base_responses baseResponses = (base_responses) null;
      if (resources != null && resources.Length > 0)
      {
        csvserver_lbvserver_binding[] lbvserverBindingArray = new csvserver_lbvserver_binding[resources.Length];
        for (int index = 0; index < resources.Length; ++index)
        {
          lbvserverBindingArray[index] = new csvserver_lbvserver_binding();
          lbvserverBindingArray[index].name = resources[index].name;
          lbvserverBindingArray[index].lbvserver = resources[index].lbvserver;
          lbvserverBindingArray[index].targetvserver = resources[index].targetvserver;
        }
        baseResponses = base_resource.update_bulk_request(client, (base_resource[]) lbvserverBindingArray);
      }
      return baseResponses;
    }

    public static base_response delete(
      nitro_service client,
      csvserver_lbvserver_binding resource)
    {
      return new csvserver_lbvserver_binding()
      {
        name = resource.name,
        lbvserver = resource.lbvserver
      }.delete_resource(client);
    }

    public static base_responses delete(
      nitro_service client,
      csvserver_lbvserver_binding[] resources)
    {
      base_responses baseResponses = (base_responses) null;
      if (resources != null && resources.Length > 0)
      {
        csvserver_lbvserver_binding[] lbvserverBindingArray = new csvserver_lbvserver_binding[resources.Length];
        for (int index = 0; index < resources.Length; ++index)
        {
          lbvserverBindingArray[index] = new csvserver_lbvserver_binding();
          lbvserverBindingArray[index].name = resources[index].name;
          lbvserverBindingArray[index].lbvserver = resources[index].lbvserver;
        }
        baseResponses = base_resource.delete_bulk_request(client, (base_resource[]) lbvserverBindingArray);
      }
      return baseResponses;
    }

    public static csvserver_lbvserver_binding[] get(
      nitro_service service,
      string name)
    {
      return (csvserver_lbvserver_binding[]) new csvserver_lbvserver_binding()
      {
        name = name
      }.get_resources(service, (options) null);
    }

    public static csvserver_lbvserver_binding[] get_filtered(
      nitro_service service,
      string name,
      string filter)
    {
      csvserver_lbvserver_binding lbvserverBinding = new csvserver_lbvserver_binding();
      lbvserverBinding.name = name;
      options option = new options();
      option.set_filter(filter);
      return (csvserver_lbvserver_binding[]) lbvserverBinding.getfiltered(service, option);
    }

    public static csvserver_lbvserver_binding[] get_filtered(
      nitro_service service,
      string name,
      filtervalue[] filter)
    {
      csvserver_lbvserver_binding lbvserverBinding = new csvserver_lbvserver_binding();
      lbvserverBinding.name = name;
      options option = new options();
      option.set_filter(filter);
      return (csvserver_lbvserver_binding[]) lbvserverBinding.getfiltered(service, option);
    }

    public static uint count(nitro_service service, string name)
    {
      csvserver_lbvserver_binding lbvserverBinding = new csvserver_lbvserver_binding();
      lbvserverBinding.name = name;
      options option = new options();
      option.set_count(true);
      csvserver_lbvserver_binding[] resources = (csvserver_lbvserver_binding[]) lbvserverBinding.get_resources(service, option);
      return resources != null && resources.Length > 0 ? resources[0].__count.Value : 0U;
    }

    public static uint count_filtered(nitro_service service, string name, string filter)
    {
      csvserver_lbvserver_binding lbvserverBinding = new csvserver_lbvserver_binding();
      lbvserverBinding.name = name;
      options option = new options();
      option.set_count(true);
      option.set_filter(filter);
      csvserver_lbvserver_binding[] lbvserverBindingArray = (csvserver_lbvserver_binding[]) lbvserverBinding.getfiltered(service, option);
      return lbvserverBindingArray != null && lbvserverBindingArray.Length > 0 ? lbvserverBindingArray[0].__count.Value : 0U;
    }

    public static uint count_filtered(nitro_service service, string name, filtervalue[] filter)
    {
      csvserver_lbvserver_binding lbvserverBinding = new csvserver_lbvserver_binding();
      lbvserverBinding.name = name;
      options option = new options();
      option.set_count(true);
      option.set_filter(filter);
      csvserver_lbvserver_binding[] lbvserverBindingArray = (csvserver_lbvserver_binding[]) lbvserverBinding.getfiltered(service, option);
      return lbvserverBindingArray != null && lbvserverBindingArray.Length > 0 ? lbvserverBindingArray[0].__count.Value : 0U;
    }

    private class csvserver_lbvserver_binding_response : base_response
    {
      public csvserver_lbvserver_binding[] csvserver_lbvserver_binding = (csvserver_lbvserver_binding[]) null;
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
