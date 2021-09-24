// Decompiled with JetBrains decompiler
// Type: com.citrix.netscaler.nitro.resource.config.cs.csvserver_authorizationpolicy_binding
// Assembly: nitro, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 6CF5DDEF-E052-4F9D-953F-6644F8378A66


using com.citrix.netscaler.nitro.exception;
using com.citrix.netscaler.nitro.resource.Base;
using com.citrix.netscaler.nitro.service;
using com.citrix.netscaler.nitro.util;

namespace com.citrix.netscaler.nitro.resource.config.cs
{
  public class csvserver_authorizationpolicy_binding : base_resource
  {
    private string policynameField = (string) null;
    private uint? priorityField = new uint?();
    private string scField = (string) null;
    private string gotopriorityexpressionField = (string) null;
    private string bindpointField = (string) null;
    private bool? invokeField = new bool?();
    private string labeltypeField = (string) null;
    private string labelnameField = (string) null;
    private string nameField = (string) null;
    private string targetlbvserverField = (string) null;
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

    public string bindpoint
    {
      get => this.bindpointField;
      set => this.bindpointField = value;
    }

    public string policyname
    {
      get => this.policynameField;
      set => this.policynameField = value;
    }

    public string labelname
    {
      get => this.labelnameField;
      set => this.labelnameField = value;
    }

    public string name
    {
      get => this.nameField;
      set => this.nameField = value;
    }

    public string targetlbvserver
    {
      get => this.targetlbvserverField;
      set => this.targetlbvserverField = value;
    }

    public string gotopriorityexpression
    {
      get => this.gotopriorityexpressionField;
      set => this.gotopriorityexpressionField = value;
    }

    public bool? invoke
    {
      get => this.invokeField;
      set => this.invokeField = value;
    }

    public string labeltype
    {
      get => this.labeltypeField;
      set => this.labeltypeField = value;
    }

    public string sc
    {
      get => this.scField;
      private set => this.scField = value;
    }

    internal override base_resource[] get_nitro_response(
      nitro_service service,
      string response)
    {
      csvserver_authorizationpolicy_binding.csvserver_authorizationpolicy_binding_response authorizationpolicyBindingResponse = new csvserver_authorizationpolicy_binding.csvserver_authorizationpolicy_binding_response();
      csvserver_authorizationpolicy_binding.csvserver_authorizationpolicy_binding_response resource = (csvserver_authorizationpolicy_binding.csvserver_authorizationpolicy_binding_response) service.get_payload_formatter().string_to_resource(authorizationpolicyBindingResponse.GetType(), response);
      if (resource.errorcode != 0)
      {
        if (resource.errorcode == 444)
          service.clear_session();
        if (resource.severity == null)
          throw new nitro_exception(resource.message, resource.errorcode);
        if (resource.severity.Equals("ERROR"))
          throw new nitro_exception(resource.message, resource.errorcode);
      }
      return (base_resource[]) resource.csvserver_authorizationpolicy_binding;
    }

    internal override string get_object_name() => this.name;

    public static base_response add(
      nitro_service client,
      csvserver_authorizationpolicy_binding resource)
    {
      return new csvserver_authorizationpolicy_binding()
      {
        name = resource.name,
        policyname = resource.policyname,
        targetlbvserver = resource.targetlbvserver,
        priority = resource.priority,
        gotopriorityexpression = resource.gotopriorityexpression,
        bindpoint = resource.bindpoint,
        invoke = resource.invoke,
        labeltype = resource.labeltype,
        labelname = resource.labelname
      }.update_resource(client);
    }

    public static base_responses add(
      nitro_service client,
      csvserver_authorizationpolicy_binding[] resources)
    {
      base_responses baseResponses = (base_responses) null;
      if (resources != null && resources.Length > 0)
      {
        csvserver_authorizationpolicy_binding[] authorizationpolicyBindingArray = new csvserver_authorizationpolicy_binding[resources.Length];
        for (int index = 0; index < resources.Length; ++index)
        {
          authorizationpolicyBindingArray[index] = new csvserver_authorizationpolicy_binding();
          authorizationpolicyBindingArray[index].name = resources[index].name;
          authorizationpolicyBindingArray[index].policyname = resources[index].policyname;
          authorizationpolicyBindingArray[index].targetlbvserver = resources[index].targetlbvserver;
          authorizationpolicyBindingArray[index].priority = resources[index].priority;
          authorizationpolicyBindingArray[index].gotopriorityexpression = resources[index].gotopriorityexpression;
          authorizationpolicyBindingArray[index].bindpoint = resources[index].bindpoint;
          authorizationpolicyBindingArray[index].invoke = resources[index].invoke;
          authorizationpolicyBindingArray[index].labeltype = resources[index].labeltype;
          authorizationpolicyBindingArray[index].labelname = resources[index].labelname;
        }
        baseResponses = base_resource.update_bulk_request(client, (base_resource[]) authorizationpolicyBindingArray);
      }
      return baseResponses;
    }

    public static base_response delete(
      nitro_service client,
      csvserver_authorizationpolicy_binding resource)
    {
      return new csvserver_authorizationpolicy_binding()
      {
        name = resource.name,
        policyname = resource.policyname,
        bindpoint = resource.bindpoint,
        priority = resource.priority
      }.delete_resource(client);
    }

    public static base_responses delete(
      nitro_service client,
      csvserver_authorizationpolicy_binding[] resources)
    {
      base_responses baseResponses = (base_responses) null;
      if (resources != null && resources.Length > 0)
      {
        csvserver_authorizationpolicy_binding[] authorizationpolicyBindingArray = new csvserver_authorizationpolicy_binding[resources.Length];
        for (int index = 0; index < resources.Length; ++index)
        {
          authorizationpolicyBindingArray[index] = new csvserver_authorizationpolicy_binding();
          authorizationpolicyBindingArray[index].name = resources[index].name;
          authorizationpolicyBindingArray[index].policyname = resources[index].policyname;
          authorizationpolicyBindingArray[index].bindpoint = resources[index].bindpoint;
          authorizationpolicyBindingArray[index].priority = resources[index].priority;
        }
        baseResponses = base_resource.delete_bulk_request(client, (base_resource[]) authorizationpolicyBindingArray);
      }
      return baseResponses;
    }

    public static csvserver_authorizationpolicy_binding[] get(
      nitro_service service,
      string name)
    {
      return (csvserver_authorizationpolicy_binding[]) new csvserver_authorizationpolicy_binding()
      {
        name = name
      }.get_resources(service, (options) null);
    }

    public static csvserver_authorizationpolicy_binding[] get_filtered(
      nitro_service service,
      string name,
      string filter)
    {
      csvserver_authorizationpolicy_binding authorizationpolicyBinding = new csvserver_authorizationpolicy_binding();
      authorizationpolicyBinding.name = name;
      options option = new options();
      option.set_filter(filter);
      return (csvserver_authorizationpolicy_binding[]) authorizationpolicyBinding.getfiltered(service, option);
    }

    public static csvserver_authorizationpolicy_binding[] get_filtered(
      nitro_service service,
      string name,
      filtervalue[] filter)
    {
      csvserver_authorizationpolicy_binding authorizationpolicyBinding = new csvserver_authorizationpolicy_binding();
      authorizationpolicyBinding.name = name;
      options option = new options();
      option.set_filter(filter);
      return (csvserver_authorizationpolicy_binding[]) authorizationpolicyBinding.getfiltered(service, option);
    }

    public static uint count(nitro_service service, string name)
    {
      csvserver_authorizationpolicy_binding authorizationpolicyBinding = new csvserver_authorizationpolicy_binding();
      authorizationpolicyBinding.name = name;
      options option = new options();
      option.set_count(true);
      csvserver_authorizationpolicy_binding[] resources = (csvserver_authorizationpolicy_binding[]) authorizationpolicyBinding.get_resources(service, option);
      return resources != null && resources.Length > 0 ? resources[0].__count.Value : 0U;
    }

    public static uint count_filtered(nitro_service service, string name, string filter)
    {
      csvserver_authorizationpolicy_binding authorizationpolicyBinding = new csvserver_authorizationpolicy_binding();
      authorizationpolicyBinding.name = name;
      options option = new options();
      option.set_count(true);
      option.set_filter(filter);
      csvserver_authorizationpolicy_binding[] authorizationpolicyBindingArray = (csvserver_authorizationpolicy_binding[]) authorizationpolicyBinding.getfiltered(service, option);
      return authorizationpolicyBindingArray != null && authorizationpolicyBindingArray.Length > 0 ? authorizationpolicyBindingArray[0].__count.Value : 0U;
    }

    public static uint count_filtered(nitro_service service, string name, filtervalue[] filter)
    {
      csvserver_authorizationpolicy_binding authorizationpolicyBinding = new csvserver_authorizationpolicy_binding();
      authorizationpolicyBinding.name = name;
      options option = new options();
      option.set_count(true);
      option.set_filter(filter);
      csvserver_authorizationpolicy_binding[] authorizationpolicyBindingArray = (csvserver_authorizationpolicy_binding[]) authorizationpolicyBinding.getfiltered(service, option);
      return authorizationpolicyBindingArray != null && authorizationpolicyBindingArray.Length > 0 ? authorizationpolicyBindingArray[0].__count.Value : 0U;
    }

    private class csvserver_authorizationpolicy_binding_response : base_response
    {
      public csvserver_authorizationpolicy_binding[] csvserver_authorizationpolicy_binding = (csvserver_authorizationpolicy_binding[]) null;
    }

    public static class scEnum
    {
      public const string ON = "ON";
      public const string OFF = "OFF";
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
