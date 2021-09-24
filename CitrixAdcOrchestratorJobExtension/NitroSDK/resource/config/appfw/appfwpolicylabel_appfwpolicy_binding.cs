// Decompiled with JetBrains decompiler
// Type: com.citrix.netscaler.nitro.resource.config.appfw.appfwpolicylabel_appfwpolicy_binding
// Assembly: nitro, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 6CF5DDEF-E052-4F9D-953F-6644F8378A66


using com.citrix.netscaler.nitro.exception;
using com.citrix.netscaler.nitro.resource.Base;
using com.citrix.netscaler.nitro.service;
using com.citrix.netscaler.nitro.util;

namespace com.citrix.netscaler.nitro.resource.config.appfw
{
  public class appfwpolicylabel_appfwpolicy_binding : base_resource
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
      appfwpolicylabel_appfwpolicy_binding.appfwpolicylabel_appfwpolicy_binding_response appfwpolicyBindingResponse = new appfwpolicylabel_appfwpolicy_binding.appfwpolicylabel_appfwpolicy_binding_response();
      appfwpolicylabel_appfwpolicy_binding.appfwpolicylabel_appfwpolicy_binding_response resource = (appfwpolicylabel_appfwpolicy_binding.appfwpolicylabel_appfwpolicy_binding_response) service.get_payload_formatter().string_to_resource(appfwpolicyBindingResponse.GetType(), response);
      if (resource.errorcode != 0)
      {
        if (resource.errorcode == 444)
          service.clear_session();
        if (resource.severity == null)
          throw new nitro_exception(resource.message, resource.errorcode);
        if (resource.severity.Equals("ERROR"))
          throw new nitro_exception(resource.message, resource.errorcode);
      }
      return (base_resource[]) resource.appfwpolicylabel_appfwpolicy_binding;
    }

    internal override string get_object_name() => this.labelname;

    public static base_response add(
      nitro_service client,
      appfwpolicylabel_appfwpolicy_binding resource)
    {
      return new appfwpolicylabel_appfwpolicy_binding()
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
      appfwpolicylabel_appfwpolicy_binding[] resources)
    {
      base_responses baseResponses = (base_responses) null;
      if (resources != null && resources.Length > 0)
      {
        appfwpolicylabel_appfwpolicy_binding[] appfwpolicyBindingArray = new appfwpolicylabel_appfwpolicy_binding[resources.Length];
        for (int index = 0; index < resources.Length; ++index)
        {
          appfwpolicyBindingArray[index] = new appfwpolicylabel_appfwpolicy_binding();
          appfwpolicyBindingArray[index].labelname = resources[index].labelname;
          appfwpolicyBindingArray[index].policyname = resources[index].policyname;
          appfwpolicyBindingArray[index].priority = resources[index].priority;
          appfwpolicyBindingArray[index].gotopriorityexpression = resources[index].gotopriorityexpression;
          appfwpolicyBindingArray[index].invoke = resources[index].invoke;
          appfwpolicyBindingArray[index].labeltype = resources[index].labeltype;
          appfwpolicyBindingArray[index].invoke_labelname = resources[index].invoke_labelname;
        }
        baseResponses = base_resource.update_bulk_request(client, (base_resource[]) appfwpolicyBindingArray);
      }
      return baseResponses;
    }

    public static base_response delete(
      nitro_service client,
      appfwpolicylabel_appfwpolicy_binding resource)
    {
      return new appfwpolicylabel_appfwpolicy_binding()
      {
        labelname = resource.labelname,
        policyname = resource.policyname,
        priority = resource.priority
      }.delete_resource(client);
    }

    public static base_responses delete(
      nitro_service client,
      appfwpolicylabel_appfwpolicy_binding[] resources)
    {
      base_responses baseResponses = (base_responses) null;
      if (resources != null && resources.Length > 0)
      {
        appfwpolicylabel_appfwpolicy_binding[] appfwpolicyBindingArray = new appfwpolicylabel_appfwpolicy_binding[resources.Length];
        for (int index = 0; index < resources.Length; ++index)
        {
          appfwpolicyBindingArray[index] = new appfwpolicylabel_appfwpolicy_binding();
          appfwpolicyBindingArray[index].labelname = resources[index].labelname;
          appfwpolicyBindingArray[index].policyname = resources[index].policyname;
          appfwpolicyBindingArray[index].priority = resources[index].priority;
        }
        baseResponses = base_resource.delete_bulk_request(client, (base_resource[]) appfwpolicyBindingArray);
      }
      return baseResponses;
    }

    public static appfwpolicylabel_appfwpolicy_binding[] get(
      nitro_service service,
      string labelname)
    {
      return (appfwpolicylabel_appfwpolicy_binding[]) new appfwpolicylabel_appfwpolicy_binding()
      {
        labelname = labelname
      }.get_resources(service, (options) null);
    }

    public static appfwpolicylabel_appfwpolicy_binding[] get_filtered(
      nitro_service service,
      string labelname,
      string filter)
    {
      appfwpolicylabel_appfwpolicy_binding appfwpolicyBinding = new appfwpolicylabel_appfwpolicy_binding();
      appfwpolicyBinding.labelname = labelname;
      options option = new options();
      option.set_filter(filter);
      return (appfwpolicylabel_appfwpolicy_binding[]) appfwpolicyBinding.getfiltered(service, option);
    }

    public static appfwpolicylabel_appfwpolicy_binding[] get_filtered(
      nitro_service service,
      string labelname,
      filtervalue[] filter)
    {
      appfwpolicylabel_appfwpolicy_binding appfwpolicyBinding = new appfwpolicylabel_appfwpolicy_binding();
      appfwpolicyBinding.labelname = labelname;
      options option = new options();
      option.set_filter(filter);
      return (appfwpolicylabel_appfwpolicy_binding[]) appfwpolicyBinding.getfiltered(service, option);
    }

    public static uint count(nitro_service service, string labelname)
    {
      appfwpolicylabel_appfwpolicy_binding appfwpolicyBinding = new appfwpolicylabel_appfwpolicy_binding();
      appfwpolicyBinding.labelname = labelname;
      options option = new options();
      option.set_count(true);
      appfwpolicylabel_appfwpolicy_binding[] resources = (appfwpolicylabel_appfwpolicy_binding[]) appfwpolicyBinding.get_resources(service, option);
      return resources != null && resources.Length > 0 ? resources[0].__count.Value : 0U;
    }

    public static uint count_filtered(nitro_service service, string labelname, string filter)
    {
      appfwpolicylabel_appfwpolicy_binding appfwpolicyBinding = new appfwpolicylabel_appfwpolicy_binding();
      appfwpolicyBinding.labelname = labelname;
      options option = new options();
      option.set_count(true);
      option.set_filter(filter);
      appfwpolicylabel_appfwpolicy_binding[] appfwpolicyBindingArray = (appfwpolicylabel_appfwpolicy_binding[]) appfwpolicyBinding.getfiltered(service, option);
      return appfwpolicyBindingArray != null && appfwpolicyBindingArray.Length > 0 ? appfwpolicyBindingArray[0].__count.Value : 0U;
    }

    public static uint count_filtered(
      nitro_service service,
      string labelname,
      filtervalue[] filter)
    {
      appfwpolicylabel_appfwpolicy_binding appfwpolicyBinding = new appfwpolicylabel_appfwpolicy_binding();
      appfwpolicyBinding.labelname = labelname;
      options option = new options();
      option.set_count(true);
      option.set_filter(filter);
      appfwpolicylabel_appfwpolicy_binding[] appfwpolicyBindingArray = (appfwpolicylabel_appfwpolicy_binding[]) appfwpolicyBinding.getfiltered(service, option);
      return appfwpolicyBindingArray != null && appfwpolicyBindingArray.Length > 0 ? appfwpolicyBindingArray[0].__count.Value : 0U;
    }

    private class appfwpolicylabel_appfwpolicy_binding_response : base_response
    {
      public appfwpolicylabel_appfwpolicy_binding[] appfwpolicylabel_appfwpolicy_binding = (appfwpolicylabel_appfwpolicy_binding[]) null;
    }

    public static class labeltypeEnum
    {
      public const string reqvserver = "reqvserver";
      public const string policylabel = "policylabel";
    }
  }
}
