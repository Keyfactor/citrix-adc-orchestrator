// Decompiled with JetBrains decompiler
// Type: com.citrix.netscaler.nitro.resource.config.appflow.appflowpolicylabel_appflowpolicy_binding
// Assembly: nitro, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 6CF5DDEF-E052-4F9D-953F-6644F8378A66


using com.citrix.netscaler.nitro.exception;
using com.citrix.netscaler.nitro.resource.Base;
using com.citrix.netscaler.nitro.service;
using com.citrix.netscaler.nitro.util;

namespace com.citrix.netscaler.nitro.resource.config.appflow
{
  public class appflowpolicylabel_appflowpolicy_binding : base_resource
  {
    private string policynameField = (string) null;
    private uint? priorityField = new uint?();
    private string gotopriorityexpressionField = (string) null;
    private bool? invokeField = new bool?();
    private string labeltypeField = (string) null;
    private string invoke_labelnameField = (string) null;
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

    public string invoke_labelname
    {
      get => this.invoke_labelnameField;
      set => this.invoke_labelnameField = value;
    }

    public bool? invoke
    {
      get => this.invokeField;
      set => this.invokeField = value;
    }

    internal override base_resource[] get_nitro_response(
      nitro_service service,
      string response)
    {
      appflowpolicylabel_appflowpolicy_binding.appflowpolicylabel_appflowpolicy_binding_response appflowpolicyBindingResponse = new appflowpolicylabel_appflowpolicy_binding.appflowpolicylabel_appflowpolicy_binding_response();
      appflowpolicylabel_appflowpolicy_binding.appflowpolicylabel_appflowpolicy_binding_response resource = (appflowpolicylabel_appflowpolicy_binding.appflowpolicylabel_appflowpolicy_binding_response) service.get_payload_formatter().string_to_resource(appflowpolicyBindingResponse.GetType(), response);
      if (resource.errorcode != 0)
      {
        if (resource.errorcode == 444)
          service.clear_session();
        if (resource.severity == null)
          throw new nitro_exception(resource.message, resource.errorcode);
        if (resource.severity.Equals("ERROR"))
          throw new nitro_exception(resource.message, resource.errorcode);
      }
      return (base_resource[]) resource.appflowpolicylabel_appflowpolicy_binding;
    }

    internal override string get_object_name() => this.labelname;

    public static base_response add(
      nitro_service client,
      appflowpolicylabel_appflowpolicy_binding resource)
    {
      return new appflowpolicylabel_appflowpolicy_binding()
      {
        labelname = resource.labelname,
        policyname = resource.policyname,
        priority = resource.priority,
        gotopriorityexpression = resource.gotopriorityexpression,
        invoke = resource.invoke,
        labeltype = resource.labeltype,
        invoke_labelname = resource.invoke_labelname
      }.update_resource(client);
    }

    public static base_responses add(
      nitro_service client,
      appflowpolicylabel_appflowpolicy_binding[] resources)
    {
      base_responses baseResponses = (base_responses) null;
      if (resources != null && resources.Length > 0)
      {
        appflowpolicylabel_appflowpolicy_binding[] appflowpolicyBindingArray = new appflowpolicylabel_appflowpolicy_binding[resources.Length];
        for (int index = 0; index < resources.Length; ++index)
        {
          appflowpolicyBindingArray[index] = new appflowpolicylabel_appflowpolicy_binding();
          appflowpolicyBindingArray[index].labelname = resources[index].labelname;
          appflowpolicyBindingArray[index].policyname = resources[index].policyname;
          appflowpolicyBindingArray[index].priority = resources[index].priority;
          appflowpolicyBindingArray[index].gotopriorityexpression = resources[index].gotopriorityexpression;
          appflowpolicyBindingArray[index].invoke = resources[index].invoke;
          appflowpolicyBindingArray[index].labeltype = resources[index].labeltype;
          appflowpolicyBindingArray[index].invoke_labelname = resources[index].invoke_labelname;
        }
        baseResponses = base_resource.update_bulk_request(client, (base_resource[]) appflowpolicyBindingArray);
      }
      return baseResponses;
    }

    public static base_response delete(
      nitro_service client,
      appflowpolicylabel_appflowpolicy_binding resource)
    {
      return new appflowpolicylabel_appflowpolicy_binding()
      {
        labelname = resource.labelname,
        policyname = resource.policyname,
        priority = resource.priority
      }.delete_resource(client);
    }

    public static base_responses delete(
      nitro_service client,
      appflowpolicylabel_appflowpolicy_binding[] resources)
    {
      base_responses baseResponses = (base_responses) null;
      if (resources != null && resources.Length > 0)
      {
        appflowpolicylabel_appflowpolicy_binding[] appflowpolicyBindingArray = new appflowpolicylabel_appflowpolicy_binding[resources.Length];
        for (int index = 0; index < resources.Length; ++index)
        {
          appflowpolicyBindingArray[index] = new appflowpolicylabel_appflowpolicy_binding();
          appflowpolicyBindingArray[index].labelname = resources[index].labelname;
          appflowpolicyBindingArray[index].policyname = resources[index].policyname;
          appflowpolicyBindingArray[index].priority = resources[index].priority;
        }
        baseResponses = base_resource.delete_bulk_request(client, (base_resource[]) appflowpolicyBindingArray);
      }
      return baseResponses;
    }

    public static appflowpolicylabel_appflowpolicy_binding[] get(
      nitro_service service,
      string labelname)
    {
      return (appflowpolicylabel_appflowpolicy_binding[]) new appflowpolicylabel_appflowpolicy_binding()
      {
        labelname = labelname
      }.get_resources(service, (options) null);
    }

    public static appflowpolicylabel_appflowpolicy_binding[] get_filtered(
      nitro_service service,
      string labelname,
      string filter)
    {
      appflowpolicylabel_appflowpolicy_binding appflowpolicyBinding = new appflowpolicylabel_appflowpolicy_binding();
      appflowpolicyBinding.labelname = labelname;
      options option = new options();
      option.set_filter(filter);
      return (appflowpolicylabel_appflowpolicy_binding[]) appflowpolicyBinding.getfiltered(service, option);
    }

    public static appflowpolicylabel_appflowpolicy_binding[] get_filtered(
      nitro_service service,
      string labelname,
      filtervalue[] filter)
    {
      appflowpolicylabel_appflowpolicy_binding appflowpolicyBinding = new appflowpolicylabel_appflowpolicy_binding();
      appflowpolicyBinding.labelname = labelname;
      options option = new options();
      option.set_filter(filter);
      return (appflowpolicylabel_appflowpolicy_binding[]) appflowpolicyBinding.getfiltered(service, option);
    }

    public static uint count(nitro_service service, string labelname)
    {
      appflowpolicylabel_appflowpolicy_binding appflowpolicyBinding = new appflowpolicylabel_appflowpolicy_binding();
      appflowpolicyBinding.labelname = labelname;
      options option = new options();
      option.set_count(true);
      appflowpolicylabel_appflowpolicy_binding[] resources = (appflowpolicylabel_appflowpolicy_binding[]) appflowpolicyBinding.get_resources(service, option);
      return resources != null && resources.Length > 0 ? resources[0].__count.Value : 0U;
    }

    public static uint count_filtered(nitro_service service, string labelname, string filter)
    {
      appflowpolicylabel_appflowpolicy_binding appflowpolicyBinding = new appflowpolicylabel_appflowpolicy_binding();
      appflowpolicyBinding.labelname = labelname;
      options option = new options();
      option.set_count(true);
      option.set_filter(filter);
      appflowpolicylabel_appflowpolicy_binding[] appflowpolicyBindingArray = (appflowpolicylabel_appflowpolicy_binding[]) appflowpolicyBinding.getfiltered(service, option);
      return appflowpolicyBindingArray != null && appflowpolicyBindingArray.Length > 0 ? appflowpolicyBindingArray[0].__count.Value : 0U;
    }

    public static uint count_filtered(
      nitro_service service,
      string labelname,
      filtervalue[] filter)
    {
      appflowpolicylabel_appflowpolicy_binding appflowpolicyBinding = new appflowpolicylabel_appflowpolicy_binding();
      appflowpolicyBinding.labelname = labelname;
      options option = new options();
      option.set_count(true);
      option.set_filter(filter);
      appflowpolicylabel_appflowpolicy_binding[] appflowpolicyBindingArray = (appflowpolicylabel_appflowpolicy_binding[]) appflowpolicyBinding.getfiltered(service, option);
      return appflowpolicyBindingArray != null && appflowpolicyBindingArray.Length > 0 ? appflowpolicyBindingArray[0].__count.Value : 0U;
    }

    private class appflowpolicylabel_appflowpolicy_binding_response : base_response
    {
      public appflowpolicylabel_appflowpolicy_binding[] appflowpolicylabel_appflowpolicy_binding = (appflowpolicylabel_appflowpolicy_binding[]) null;
    }

    public static class labeltypeEnum
    {
      public const string vserver = "vserver";
      public const string policylabel = "policylabel";
    }
  }
}
