// Decompiled with JetBrains decompiler
// Type: com.citrix.netscaler.nitro.resource.config.cs.cspolicylabel_cspolicy_binding
// Assembly: nitro, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 6CF5DDEF-E052-4F9D-953F-6644F8378A66


using com.citrix.netscaler.nitro.exception;
using com.citrix.netscaler.nitro.resource.Base;
using com.citrix.netscaler.nitro.service;
using com.citrix.netscaler.nitro.util;

namespace com.citrix.netscaler.nitro.resource.config.cs
{
  public class cspolicylabel_cspolicy_binding : base_resource
  {
    private string policynameField = (string) null;
    private uint? priorityField = new uint?();
    private string targetvserverField = (string) null;
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
      cspolicylabel_cspolicy_binding.cspolicylabel_cspolicy_binding_response cspolicyBindingResponse = new cspolicylabel_cspolicy_binding.cspolicylabel_cspolicy_binding_response();
      cspolicylabel_cspolicy_binding.cspolicylabel_cspolicy_binding_response resource = (cspolicylabel_cspolicy_binding.cspolicylabel_cspolicy_binding_response) service.get_payload_formatter().string_to_resource(cspolicyBindingResponse.GetType(), response);
      if (resource.errorcode != 0)
      {
        if (resource.errorcode == 444)
          service.clear_session();
        if (resource.severity == null)
          throw new nitro_exception(resource.message, resource.errorcode);
        if (resource.severity.Equals("ERROR"))
          throw new nitro_exception(resource.message, resource.errorcode);
      }
      return (base_resource[]) resource.cspolicylabel_cspolicy_binding;
    }

    internal override string get_object_name() => this.labelname;

    public static base_response add(
      nitro_service client,
      cspolicylabel_cspolicy_binding resource)
    {
      return new cspolicylabel_cspolicy_binding()
      {
        labelname = resource.labelname,
        policyname = resource.policyname,
        priority = resource.priority,
        targetvserver = resource.targetvserver,
        gotopriorityexpression = resource.gotopriorityexpression,
        invoke = resource.invoke,
        labeltype = resource.labeltype,
        invoke_labelname = resource.invoke_labelname
      }.update_resource(client);
    }

    public static base_responses add(
      nitro_service client,
      cspolicylabel_cspolicy_binding[] resources)
    {
      base_responses baseResponses = (base_responses) null;
      if (resources != null && resources.Length > 0)
      {
        cspolicylabel_cspolicy_binding[] cspolicylabelCspolicyBindingArray = new cspolicylabel_cspolicy_binding[resources.Length];
        for (int index = 0; index < resources.Length; ++index)
        {
          cspolicylabelCspolicyBindingArray[index] = new cspolicylabel_cspolicy_binding();
          cspolicylabelCspolicyBindingArray[index].labelname = resources[index].labelname;
          cspolicylabelCspolicyBindingArray[index].policyname = resources[index].policyname;
          cspolicylabelCspolicyBindingArray[index].priority = resources[index].priority;
          cspolicylabelCspolicyBindingArray[index].targetvserver = resources[index].targetvserver;
          cspolicylabelCspolicyBindingArray[index].gotopriorityexpression = resources[index].gotopriorityexpression;
          cspolicylabelCspolicyBindingArray[index].invoke = resources[index].invoke;
          cspolicylabelCspolicyBindingArray[index].labeltype = resources[index].labeltype;
          cspolicylabelCspolicyBindingArray[index].invoke_labelname = resources[index].invoke_labelname;
        }
        baseResponses = base_resource.update_bulk_request(client, (base_resource[]) cspolicylabelCspolicyBindingArray);
      }
      return baseResponses;
    }

    public static base_response delete(
      nitro_service client,
      cspolicylabel_cspolicy_binding resource)
    {
      return new cspolicylabel_cspolicy_binding()
      {
        labelname = resource.labelname,
        policyname = resource.policyname
      }.delete_resource(client);
    }

    public static base_responses delete(
      nitro_service client,
      cspolicylabel_cspolicy_binding[] resources)
    {
      base_responses baseResponses = (base_responses) null;
      if (resources != null && resources.Length > 0)
      {
        cspolicylabel_cspolicy_binding[] cspolicylabelCspolicyBindingArray = new cspolicylabel_cspolicy_binding[resources.Length];
        for (int index = 0; index < resources.Length; ++index)
        {
          cspolicylabelCspolicyBindingArray[index] = new cspolicylabel_cspolicy_binding();
          cspolicylabelCspolicyBindingArray[index].labelname = resources[index].labelname;
          cspolicylabelCspolicyBindingArray[index].policyname = resources[index].policyname;
        }
        baseResponses = base_resource.delete_bulk_request(client, (base_resource[]) cspolicylabelCspolicyBindingArray);
      }
      return baseResponses;
    }

    public static cspolicylabel_cspolicy_binding[] get(
      nitro_service service,
      string labelname)
    {
      return (cspolicylabel_cspolicy_binding[]) new cspolicylabel_cspolicy_binding()
      {
        labelname = labelname
      }.get_resources(service, (options) null);
    }

    public static cspolicylabel_cspolicy_binding[] get_filtered(
      nitro_service service,
      string labelname,
      string filter)
    {
      cspolicylabel_cspolicy_binding cspolicylabelCspolicyBinding = new cspolicylabel_cspolicy_binding();
      cspolicylabelCspolicyBinding.labelname = labelname;
      options option = new options();
      option.set_filter(filter);
      return (cspolicylabel_cspolicy_binding[]) cspolicylabelCspolicyBinding.getfiltered(service, option);
    }

    public static cspolicylabel_cspolicy_binding[] get_filtered(
      nitro_service service,
      string labelname,
      filtervalue[] filter)
    {
      cspolicylabel_cspolicy_binding cspolicylabelCspolicyBinding = new cspolicylabel_cspolicy_binding();
      cspolicylabelCspolicyBinding.labelname = labelname;
      options option = new options();
      option.set_filter(filter);
      return (cspolicylabel_cspolicy_binding[]) cspolicylabelCspolicyBinding.getfiltered(service, option);
    }

    public static uint count(nitro_service service, string labelname)
    {
      cspolicylabel_cspolicy_binding cspolicylabelCspolicyBinding = new cspolicylabel_cspolicy_binding();
      cspolicylabelCspolicyBinding.labelname = labelname;
      options option = new options();
      option.set_count(true);
      cspolicylabel_cspolicy_binding[] resources = (cspolicylabel_cspolicy_binding[]) cspolicylabelCspolicyBinding.get_resources(service, option);
      return resources != null && resources.Length > 0 ? resources[0].__count.Value : 0U;
    }

    public static uint count_filtered(nitro_service service, string labelname, string filter)
    {
      cspolicylabel_cspolicy_binding cspolicylabelCspolicyBinding = new cspolicylabel_cspolicy_binding();
      cspolicylabelCspolicyBinding.labelname = labelname;
      options option = new options();
      option.set_count(true);
      option.set_filter(filter);
      cspolicylabel_cspolicy_binding[] cspolicylabelCspolicyBindingArray = (cspolicylabel_cspolicy_binding[]) cspolicylabelCspolicyBinding.getfiltered(service, option);
      return cspolicylabelCspolicyBindingArray != null && cspolicylabelCspolicyBindingArray.Length > 0 ? cspolicylabelCspolicyBindingArray[0].__count.Value : 0U;
    }

    public static uint count_filtered(
      nitro_service service,
      string labelname,
      filtervalue[] filter)
    {
      cspolicylabel_cspolicy_binding cspolicylabelCspolicyBinding = new cspolicylabel_cspolicy_binding();
      cspolicylabelCspolicyBinding.labelname = labelname;
      options option = new options();
      option.set_count(true);
      option.set_filter(filter);
      cspolicylabel_cspolicy_binding[] cspolicylabelCspolicyBindingArray = (cspolicylabel_cspolicy_binding[]) cspolicylabelCspolicyBinding.getfiltered(service, option);
      return cspolicylabelCspolicyBindingArray != null && cspolicylabelCspolicyBindingArray.Length > 0 ? cspolicylabelCspolicyBindingArray[0].__count.Value : 0U;
    }

    private class cspolicylabel_cspolicy_binding_response : base_response
    {
      public cspolicylabel_cspolicy_binding[] cspolicylabel_cspolicy_binding = (cspolicylabel_cspolicy_binding[]) null;
    }

    public static class labeltypeEnum
    {
      public const string policylabel = "policylabel";
    }
  }
}
