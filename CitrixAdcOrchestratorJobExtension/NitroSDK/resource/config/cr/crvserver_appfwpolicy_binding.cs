// Decompiled with JetBrains decompiler
// Type: com.citrix.netscaler.nitro.resource.config.cr.crvserver_appfwpolicy_binding
// Assembly: nitro, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 6CF5DDEF-E052-4F9D-953F-6644F8378A66


using com.citrix.netscaler.nitro.exception;
using com.citrix.netscaler.nitro.resource.Base;
using com.citrix.netscaler.nitro.service;
using com.citrix.netscaler.nitro.util;

namespace com.citrix.netscaler.nitro.resource.config.cr
{
  public class crvserver_appfwpolicy_binding : base_resource
  {
    private string policynameField = (string) null;
    private uint? priorityField = new uint?();
    private string gotopriorityexpressionField = (string) null;
    private string scField = (string) null;
    private string bindpointField = (string) null;
    private bool? invokeField = new bool?();
    private string labeltypeField = (string) null;
    private string labelnameField = (string) null;
    private string nameField = (string) null;
    private string targetvserverField = (string) null;
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

    public string sc
    {
      get => this.scField;
      private set => this.scField = value;
    }

    internal override base_resource[] get_nitro_response(
      nitro_service service,
      string response)
    {
      crvserver_appfwpolicy_binding.crvserver_appfwpolicy_binding_response appfwpolicyBindingResponse = new crvserver_appfwpolicy_binding.crvserver_appfwpolicy_binding_response();
      crvserver_appfwpolicy_binding.crvserver_appfwpolicy_binding_response resource = (crvserver_appfwpolicy_binding.crvserver_appfwpolicy_binding_response) service.get_payload_formatter().string_to_resource(appfwpolicyBindingResponse.GetType(), response);
      if (resource.errorcode != 0)
      {
        if (resource.errorcode == 444)
          service.clear_session();
        if (resource.severity == null)
          throw new nitro_exception(resource.message, resource.errorcode);
        if (resource.severity.Equals("ERROR"))
          throw new nitro_exception(resource.message, resource.errorcode);
      }
      return (base_resource[]) resource.crvserver_appfwpolicy_binding;
    }

    internal override string get_object_name() => this.name;

    public static base_response add(
      nitro_service client,
      crvserver_appfwpolicy_binding resource)
    {
      return new crvserver_appfwpolicy_binding()
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
      crvserver_appfwpolicy_binding[] resources)
    {
      base_responses baseResponses = (base_responses) null;
      if (resources != null && resources.Length > 0)
      {
        crvserver_appfwpolicy_binding[] appfwpolicyBindingArray = new crvserver_appfwpolicy_binding[resources.Length];
        for (int index = 0; index < resources.Length; ++index)
        {
          appfwpolicyBindingArray[index] = new crvserver_appfwpolicy_binding();
          appfwpolicyBindingArray[index].name = resources[index].name;
          appfwpolicyBindingArray[index].policyname = resources[index].policyname;
          appfwpolicyBindingArray[index].targetvserver = resources[index].targetvserver;
          appfwpolicyBindingArray[index].priority = resources[index].priority;
          appfwpolicyBindingArray[index].gotopriorityexpression = resources[index].gotopriorityexpression;
          appfwpolicyBindingArray[index].bindpoint = resources[index].bindpoint;
          appfwpolicyBindingArray[index].invoke = resources[index].invoke;
          appfwpolicyBindingArray[index].labeltype = resources[index].labeltype;
          appfwpolicyBindingArray[index].labelname = resources[index].labelname;
        }
        baseResponses = base_resource.update_bulk_request(client, (base_resource[]) appfwpolicyBindingArray);
      }
      return baseResponses;
    }

    public static base_response delete(
      nitro_service client,
      crvserver_appfwpolicy_binding resource)
    {
      return new crvserver_appfwpolicy_binding()
      {
        name = resource.name,
        policyname = resource.policyname,
        bindpoint = resource.bindpoint,
        priority = resource.priority
      }.delete_resource(client);
    }

    public static base_responses delete(
      nitro_service client,
      crvserver_appfwpolicy_binding[] resources)
    {
      base_responses baseResponses = (base_responses) null;
      if (resources != null && resources.Length > 0)
      {
        crvserver_appfwpolicy_binding[] appfwpolicyBindingArray = new crvserver_appfwpolicy_binding[resources.Length];
        for (int index = 0; index < resources.Length; ++index)
        {
          appfwpolicyBindingArray[index] = new crvserver_appfwpolicy_binding();
          appfwpolicyBindingArray[index].name = resources[index].name;
          appfwpolicyBindingArray[index].policyname = resources[index].policyname;
          appfwpolicyBindingArray[index].bindpoint = resources[index].bindpoint;
          appfwpolicyBindingArray[index].priority = resources[index].priority;
        }
        baseResponses = base_resource.delete_bulk_request(client, (base_resource[]) appfwpolicyBindingArray);
      }
      return baseResponses;
    }

    public static crvserver_appfwpolicy_binding[] get(
      nitro_service service,
      string name)
    {
      return (crvserver_appfwpolicy_binding[]) new crvserver_appfwpolicy_binding()
      {
        name = name
      }.get_resources(service, (options) null);
    }

    public static crvserver_appfwpolicy_binding[] get_filtered(
      nitro_service service,
      string name,
      string filter)
    {
      crvserver_appfwpolicy_binding appfwpolicyBinding = new crvserver_appfwpolicy_binding();
      appfwpolicyBinding.name = name;
      options option = new options();
      option.set_filter(filter);
      return (crvserver_appfwpolicy_binding[]) appfwpolicyBinding.getfiltered(service, option);
    }

    public static crvserver_appfwpolicy_binding[] get_filtered(
      nitro_service service,
      string name,
      filtervalue[] filter)
    {
      crvserver_appfwpolicy_binding appfwpolicyBinding = new crvserver_appfwpolicy_binding();
      appfwpolicyBinding.name = name;
      options option = new options();
      option.set_filter(filter);
      return (crvserver_appfwpolicy_binding[]) appfwpolicyBinding.getfiltered(service, option);
    }

    public static uint count(nitro_service service, string name)
    {
      crvserver_appfwpolicy_binding appfwpolicyBinding = new crvserver_appfwpolicy_binding();
      appfwpolicyBinding.name = name;
      options option = new options();
      option.set_count(true);
      crvserver_appfwpolicy_binding[] resources = (crvserver_appfwpolicy_binding[]) appfwpolicyBinding.get_resources(service, option);
      return resources != null && resources.Length > 0 ? resources[0].__count.Value : 0U;
    }

    public static uint count_filtered(nitro_service service, string name, string filter)
    {
      crvserver_appfwpolicy_binding appfwpolicyBinding = new crvserver_appfwpolicy_binding();
      appfwpolicyBinding.name = name;
      options option = new options();
      option.set_count(true);
      option.set_filter(filter);
      crvserver_appfwpolicy_binding[] appfwpolicyBindingArray = (crvserver_appfwpolicy_binding[]) appfwpolicyBinding.getfiltered(service, option);
      return appfwpolicyBindingArray != null && appfwpolicyBindingArray.Length > 0 ? appfwpolicyBindingArray[0].__count.Value : 0U;
    }

    public static uint count_filtered(nitro_service service, string name, filtervalue[] filter)
    {
      crvserver_appfwpolicy_binding appfwpolicyBinding = new crvserver_appfwpolicy_binding();
      appfwpolicyBinding.name = name;
      options option = new options();
      option.set_count(true);
      option.set_filter(filter);
      crvserver_appfwpolicy_binding[] appfwpolicyBindingArray = (crvserver_appfwpolicy_binding[]) appfwpolicyBinding.getfiltered(service, option);
      return appfwpolicyBindingArray != null && appfwpolicyBindingArray.Length > 0 ? appfwpolicyBindingArray[0].__count.Value : 0U;
    }

    private class crvserver_appfwpolicy_binding_response : base_response
    {
      public crvserver_appfwpolicy_binding[] crvserver_appfwpolicy_binding = (crvserver_appfwpolicy_binding[]) null;
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
