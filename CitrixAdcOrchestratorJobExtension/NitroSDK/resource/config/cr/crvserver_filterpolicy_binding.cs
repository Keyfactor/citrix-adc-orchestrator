// Decompiled with JetBrains decompiler
// Type: com.citrix.netscaler.nitro.resource.config.cr.crvserver_filterpolicy_binding
// Assembly: nitro, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 6CF5DDEF-E052-4F9D-953F-6644F8378A66


using com.citrix.netscaler.nitro.exception;
using com.citrix.netscaler.nitro.resource.Base;
using com.citrix.netscaler.nitro.service;
using com.citrix.netscaler.nitro.util;

namespace com.citrix.netscaler.nitro.resource.config.cr
{
  public class crvserver_filterpolicy_binding : base_resource
  {
    private string policynameField = (string) null;
    private uint? priorityField = new uint?();
    private string inheritedField = (string) null;
    private string nameField = (string) null;
    private string targetvserverField = (string) null;
    private string gotopriorityexpressionField = (string) null;
    private string bindpointField = (string) null;
    private bool? invokeField = new bool?();
    private string labeltypeField = (string) null;
    private string labelnameField = (string) null;
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

    public string bindpoint
    {
      get => this.bindpointField;
      set => this.bindpointField = value;
    }

    public string targetvserver
    {
      get => this.targetvserverField;
      set => this.targetvserverField = value;
    }

    public string labeltype
    {
      get => this.labeltypeField;
      set => this.labeltypeField = value;
    }

    public string labelname
    {
      get => this.labelnameField;
      set => this.labelnameField = value;
    }

    public bool? invoke
    {
      get => this.invokeField;
      set => this.invokeField = value;
    }

    public string inherited
    {
      get => this.inheritedField;
      private set => this.inheritedField = value;
    }

    internal override base_resource[] get_nitro_response(
      nitro_service service,
      string response)
    {
      crvserver_filterpolicy_binding.crvserver_filterpolicy_binding_response filterpolicyBindingResponse = new crvserver_filterpolicy_binding.crvserver_filterpolicy_binding_response();
      crvserver_filterpolicy_binding.crvserver_filterpolicy_binding_response resource = (crvserver_filterpolicy_binding.crvserver_filterpolicy_binding_response) service.get_payload_formatter().string_to_resource(filterpolicyBindingResponse.GetType(), response);
      if (resource.errorcode != 0)
      {
        if (resource.errorcode == 444)
          service.clear_session();
        if (resource.severity == null)
          throw new nitro_exception(resource.message, resource.errorcode);
        if (resource.severity.Equals("ERROR"))
          throw new nitro_exception(resource.message, resource.errorcode);
      }
      return (base_resource[]) resource.crvserver_filterpolicy_binding;
    }

    internal override string get_object_name() => this.name;

    public static base_response add(
      nitro_service client,
      crvserver_filterpolicy_binding resource)
    {
      return new crvserver_filterpolicy_binding()
      {
        name = resource.name,
        policyname = resource.policyname,
        targetvserver = resource.targetvserver,
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
      crvserver_filterpolicy_binding[] resources)
    {
      base_responses baseResponses = (base_responses) null;
      if (resources != null && resources.Length > 0)
      {
        crvserver_filterpolicy_binding[] filterpolicyBindingArray = new crvserver_filterpolicy_binding[resources.Length];
        for (int index = 0; index < resources.Length; ++index)
        {
          filterpolicyBindingArray[index] = new crvserver_filterpolicy_binding();
          filterpolicyBindingArray[index].name = resources[index].name;
          filterpolicyBindingArray[index].policyname = resources[index].policyname;
          filterpolicyBindingArray[index].targetvserver = resources[index].targetvserver;
          filterpolicyBindingArray[index].priority = resources[index].priority;
          filterpolicyBindingArray[index].gotopriorityexpression = resources[index].gotopriorityexpression;
          filterpolicyBindingArray[index].bindpoint = resources[index].bindpoint;
          filterpolicyBindingArray[index].invoke = resources[index].invoke;
          filterpolicyBindingArray[index].labeltype = resources[index].labeltype;
          filterpolicyBindingArray[index].labelname = resources[index].labelname;
        }
        baseResponses = base_resource.update_bulk_request(client, (base_resource[]) filterpolicyBindingArray);
      }
      return baseResponses;
    }

    public static base_response delete(
      nitro_service client,
      crvserver_filterpolicy_binding resource)
    {
      return new crvserver_filterpolicy_binding()
      {
        name = resource.name,
        policyname = resource.policyname,
        bindpoint = resource.bindpoint,
        priority = resource.priority
      }.delete_resource(client);
    }

    public static base_responses delete(
      nitro_service client,
      crvserver_filterpolicy_binding[] resources)
    {
      base_responses baseResponses = (base_responses) null;
      if (resources != null && resources.Length > 0)
      {
        crvserver_filterpolicy_binding[] filterpolicyBindingArray = new crvserver_filterpolicy_binding[resources.Length];
        for (int index = 0; index < resources.Length; ++index)
        {
          filterpolicyBindingArray[index] = new crvserver_filterpolicy_binding();
          filterpolicyBindingArray[index].name = resources[index].name;
          filterpolicyBindingArray[index].policyname = resources[index].policyname;
          filterpolicyBindingArray[index].bindpoint = resources[index].bindpoint;
          filterpolicyBindingArray[index].priority = resources[index].priority;
        }
        baseResponses = base_resource.delete_bulk_request(client, (base_resource[]) filterpolicyBindingArray);
      }
      return baseResponses;
    }

    public static crvserver_filterpolicy_binding[] get(
      nitro_service service,
      string name)
    {
      return (crvserver_filterpolicy_binding[]) new crvserver_filterpolicy_binding()
      {
        name = name
      }.get_resources(service, (options) null);
    }

    public static crvserver_filterpolicy_binding[] get_filtered(
      nitro_service service,
      string name,
      string filter)
    {
      crvserver_filterpolicy_binding filterpolicyBinding = new crvserver_filterpolicy_binding();
      filterpolicyBinding.name = name;
      options option = new options();
      option.set_filter(filter);
      return (crvserver_filterpolicy_binding[]) filterpolicyBinding.getfiltered(service, option);
    }

    public static crvserver_filterpolicy_binding[] get_filtered(
      nitro_service service,
      string name,
      filtervalue[] filter)
    {
      crvserver_filterpolicy_binding filterpolicyBinding = new crvserver_filterpolicy_binding();
      filterpolicyBinding.name = name;
      options option = new options();
      option.set_filter(filter);
      return (crvserver_filterpolicy_binding[]) filterpolicyBinding.getfiltered(service, option);
    }

    public static uint count(nitro_service service, string name)
    {
      crvserver_filterpolicy_binding filterpolicyBinding = new crvserver_filterpolicy_binding();
      filterpolicyBinding.name = name;
      options option = new options();
      option.set_count(true);
      crvserver_filterpolicy_binding[] resources = (crvserver_filterpolicy_binding[]) filterpolicyBinding.get_resources(service, option);
      return resources != null && resources.Length > 0 ? resources[0].__count.Value : 0U;
    }

    public static uint count_filtered(nitro_service service, string name, string filter)
    {
      crvserver_filterpolicy_binding filterpolicyBinding = new crvserver_filterpolicy_binding();
      filterpolicyBinding.name = name;
      options option = new options();
      option.set_count(true);
      option.set_filter(filter);
      crvserver_filterpolicy_binding[] filterpolicyBindingArray = (crvserver_filterpolicy_binding[]) filterpolicyBinding.getfiltered(service, option);
      return filterpolicyBindingArray != null && filterpolicyBindingArray.Length > 0 ? filterpolicyBindingArray[0].__count.Value : 0U;
    }

    public static uint count_filtered(nitro_service service, string name, filtervalue[] filter)
    {
      crvserver_filterpolicy_binding filterpolicyBinding = new crvserver_filterpolicy_binding();
      filterpolicyBinding.name = name;
      options option = new options();
      option.set_count(true);
      option.set_filter(filter);
      crvserver_filterpolicy_binding[] filterpolicyBindingArray = (crvserver_filterpolicy_binding[]) filterpolicyBinding.getfiltered(service, option);
      return filterpolicyBindingArray != null && filterpolicyBindingArray.Length > 0 ? filterpolicyBindingArray[0].__count.Value : 0U;
    }

    private class crvserver_filterpolicy_binding_response : base_response
    {
      public crvserver_filterpolicy_binding[] crvserver_filterpolicy_binding = (crvserver_filterpolicy_binding[]) null;
    }

    public static class inheritedEnum
    {
      public const string ON = "ON";
      public const string OFF = "OFF";
    }

    public static class bindpointEnum
    {
      public const string REQUEST = "REQUEST";
      public const string RESPONSE = "RESPONSE";
      public const string ICA_REQUEST = "ICA_REQUEST";
    }

    public static class labeltypeEnum
    {
      public const string reqvserver = "reqvserver";
      public const string resvserver = "resvserver";
      public const string policylabel = "policylabel";
    }
  }
}
