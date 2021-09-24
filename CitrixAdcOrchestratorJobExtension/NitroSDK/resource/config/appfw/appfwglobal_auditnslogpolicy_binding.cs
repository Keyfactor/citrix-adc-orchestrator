// Decompiled with JetBrains decompiler
// Type: com.citrix.netscaler.nitro.resource.config.appfw.appfwglobal_auditnslogpolicy_binding
// Assembly: nitro, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 6CF5DDEF-E052-4F9D-953F-6644F8378A66


using com.citrix.netscaler.nitro.exception;
using com.citrix.netscaler.nitro.resource.Base;
using com.citrix.netscaler.nitro.service;
using com.citrix.netscaler.nitro.util;

namespace com.citrix.netscaler.nitro.resource.config.appfw
{
  public class appfwglobal_auditnslogpolicy_binding : base_resource
  {
    private string policynameField = (string) null;
    private uint? priorityField = new uint?();
    private string stateField = (string) null;
    private string typeField = (string) null;
    private string policytypeField = (string) null;
    private string gotopriorityexpressionField = (string) null;
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

    public string state
    {
      get => this.stateField;
      set => this.stateField = value;
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

    public string type
    {
      get => this.typeField;
      set => this.typeField = value;
    }

    public string labeltype
    {
      get => this.labeltypeField;
      set => this.labeltypeField = value;
    }

    public string policytype
    {
      get => this.policytypeField;
      private set => this.policytypeField = value;
    }

    internal override base_resource[] get_nitro_response(
      nitro_service service,
      string response)
    {
      appfwglobal_auditnslogpolicy_binding.appfwglobal_auditnslogpolicy_binding_response auditnslogpolicyBindingResponse = new appfwglobal_auditnslogpolicy_binding.appfwglobal_auditnslogpolicy_binding_response();
      appfwglobal_auditnslogpolicy_binding.appfwglobal_auditnslogpolicy_binding_response resource = (appfwglobal_auditnslogpolicy_binding.appfwglobal_auditnslogpolicy_binding_response) service.get_payload_formatter().string_to_resource(auditnslogpolicyBindingResponse.GetType(), response);
      if (resource.errorcode != 0)
      {
        if (resource.errorcode == 444)
          service.clear_session();
        if (resource.severity == null)
          throw new nitro_exception(resource.message, resource.errorcode);
        if (resource.severity.Equals("ERROR"))
          throw new nitro_exception(resource.message, resource.errorcode);
      }
      return (base_resource[]) resource.appfwglobal_auditnslogpolicy_binding;
    }

    internal override string get_object_name() => (string) null;

    public static base_response add(
      nitro_service client,
      appfwglobal_auditnslogpolicy_binding resource)
    {
      return new appfwglobal_auditnslogpolicy_binding()
      {
        policyname = resource.policyname,
        priority = resource.priority,
        state = resource.state,
        gotopriorityexpression = resource.gotopriorityexpression,
        type = resource.type,
        invoke = resource.invoke,
        labeltype = resource.labeltype,
        labelname = resource.labelname
      }.update_resource(client);
    }

    public static base_responses add(
      nitro_service client,
      appfwglobal_auditnslogpolicy_binding[] resources)
    {
      base_responses baseResponses = (base_responses) null;
      if (resources != null && resources.Length > 0)
      {
        appfwglobal_auditnslogpolicy_binding[] auditnslogpolicyBindingArray = new appfwglobal_auditnslogpolicy_binding[resources.Length];
        for (int index = 0; index < resources.Length; ++index)
        {
          auditnslogpolicyBindingArray[index] = new appfwglobal_auditnslogpolicy_binding();
          auditnslogpolicyBindingArray[index].policyname = resources[index].policyname;
          auditnslogpolicyBindingArray[index].priority = resources[index].priority;
          auditnslogpolicyBindingArray[index].state = resources[index].state;
          auditnslogpolicyBindingArray[index].gotopriorityexpression = resources[index].gotopriorityexpression;
          auditnslogpolicyBindingArray[index].type = resources[index].type;
          auditnslogpolicyBindingArray[index].invoke = resources[index].invoke;
          auditnslogpolicyBindingArray[index].labeltype = resources[index].labeltype;
          auditnslogpolicyBindingArray[index].labelname = resources[index].labelname;
        }
        baseResponses = base_resource.update_bulk_request(client, (base_resource[]) auditnslogpolicyBindingArray);
      }
      return baseResponses;
    }

    public static base_response delete(
      nitro_service client,
      appfwglobal_auditnslogpolicy_binding resource)
    {
      return new appfwglobal_auditnslogpolicy_binding()
      {
        policyname = resource.policyname,
        type = resource.type,
        priority = resource.priority
      }.delete_resource(client);
    }

    public static base_responses delete(
      nitro_service client,
      appfwglobal_auditnslogpolicy_binding[] resources)
    {
      base_responses baseResponses = (base_responses) null;
      if (resources != null && resources.Length > 0)
      {
        appfwglobal_auditnslogpolicy_binding[] auditnslogpolicyBindingArray = new appfwglobal_auditnslogpolicy_binding[resources.Length];
        for (int index = 0; index < resources.Length; ++index)
        {
          auditnslogpolicyBindingArray[index] = new appfwglobal_auditnslogpolicy_binding();
          auditnslogpolicyBindingArray[index].policyname = resources[index].policyname;
          auditnslogpolicyBindingArray[index].type = resources[index].type;
          auditnslogpolicyBindingArray[index].priority = resources[index].priority;
        }
        baseResponses = base_resource.delete_bulk_request(client, (base_resource[]) auditnslogpolicyBindingArray);
      }
      return baseResponses;
    }

    public static appfwglobal_auditnslogpolicy_binding[] get(
      nitro_service service)
    {
      return (appfwglobal_auditnslogpolicy_binding[]) new appfwglobal_auditnslogpolicy_binding().get_resources(service, (options) null);
    }

    public static appfwglobal_auditnslogpolicy_binding[] get_filtered(
      nitro_service service,
      string filter)
    {
      appfwglobal_auditnslogpolicy_binding auditnslogpolicyBinding = new appfwglobal_auditnslogpolicy_binding();
      options option = new options();
      option.set_filter(filter);
      return (appfwglobal_auditnslogpolicy_binding[]) auditnslogpolicyBinding.getfiltered(service, option);
    }

    public static appfwglobal_auditnslogpolicy_binding[] get_filtered(
      nitro_service service,
      filtervalue[] filter)
    {
      appfwglobal_auditnslogpolicy_binding auditnslogpolicyBinding = new appfwglobal_auditnslogpolicy_binding();
      options option = new options();
      option.set_filter(filter);
      return (appfwglobal_auditnslogpolicy_binding[]) auditnslogpolicyBinding.getfiltered(service, option);
    }

    public static uint count(nitro_service service)
    {
      appfwglobal_auditnslogpolicy_binding auditnslogpolicyBinding = new appfwglobal_auditnslogpolicy_binding();
      options option = new options();
      option.set_count(true);
      appfwglobal_auditnslogpolicy_binding[] resources = (appfwglobal_auditnslogpolicy_binding[]) auditnslogpolicyBinding.get_resources(service, option);
      return resources != null && resources.Length > 0 ? resources[0].__count.Value : 0U;
    }

    public static uint count_filtered(nitro_service service, string filter)
    {
      appfwglobal_auditnslogpolicy_binding auditnslogpolicyBinding = new appfwglobal_auditnslogpolicy_binding();
      options option = new options();
      option.set_count(true);
      option.set_filter(filter);
      appfwglobal_auditnslogpolicy_binding[] auditnslogpolicyBindingArray = (appfwglobal_auditnslogpolicy_binding[]) auditnslogpolicyBinding.getfiltered(service, option);
      return auditnslogpolicyBindingArray != null && auditnslogpolicyBindingArray.Length > 0 ? auditnslogpolicyBindingArray[0].__count.Value : 0U;
    }

    public static uint count_filtered(nitro_service service, filtervalue[] filter)
    {
      appfwglobal_auditnslogpolicy_binding auditnslogpolicyBinding = new appfwglobal_auditnslogpolicy_binding();
      options option = new options();
      option.set_count(true);
      option.set_filter(filter);
      appfwglobal_auditnslogpolicy_binding[] auditnslogpolicyBindingArray = (appfwglobal_auditnslogpolicy_binding[]) auditnslogpolicyBinding.getfiltered(service, option);
      return auditnslogpolicyBindingArray != null && auditnslogpolicyBindingArray.Length > 0 ? auditnslogpolicyBindingArray[0].__count.Value : 0U;
    }

    private class appfwglobal_auditnslogpolicy_binding_response : base_response
    {
      public appfwglobal_auditnslogpolicy_binding[] appfwglobal_auditnslogpolicy_binding = (appfwglobal_auditnslogpolicy_binding[]) null;
    }

    public static class typeEnum
    {
      public const string REQ_OVERRIDE = "REQ_OVERRIDE";
      public const string REQ_DEFAULT = "REQ_DEFAULT";
      public const string NONE = "NONE";
    }

    public static class labeltypeEnum
    {
      public const string reqvserver = "reqvserver";
      public const string policylabel = "policylabel";
    }

    public static class policytypeEnum
    {
      public const string Classic_Policy = "Classic Policy";
      public const string Advanced_Policy = "Advanced Policy";
    }

    public static class stateEnum
    {
      public const string ENABLED = "ENABLED";
      public const string DISABLED = "DISABLED";
    }
  }
}
