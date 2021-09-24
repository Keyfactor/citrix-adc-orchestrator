// Decompiled with JetBrains decompiler
// Type: com.citrix.netscaler.nitro.resource.config.cmp.cmpglobal_cmppolicy_binding
// Assembly: nitro, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 6CF5DDEF-E052-4F9D-953F-6644F8378A66


using com.citrix.netscaler.nitro.exception;
using com.citrix.netscaler.nitro.resource.Base;
using com.citrix.netscaler.nitro.service;
using com.citrix.netscaler.nitro.util;

namespace com.citrix.netscaler.nitro.resource.config.cmp
{
  public class cmpglobal_cmppolicy_binding : base_resource
  {
    private string policynameField = (string) null;
    private uint? priorityField = new uint?();
    private string stateField = (string) null;
    private string typeField = (string) null;
    private uint? numpolField = new uint?();
    private string policytypeField = (string) null;
    private string globalbindtypeField = (string) null;
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

    public string globalbindtype
    {
      get => this.globalbindtypeField;
      set => this.globalbindtypeField = value;
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

    public string policyname
    {
      get => this.policynameField;
      set => this.policynameField = value;
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

    public uint? numpol
    {
      get => this.numpolField;
      private set => this.numpolField = value;
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
      cmpglobal_cmppolicy_binding.cmpglobal_cmppolicy_binding_response cmppolicyBindingResponse = new cmpglobal_cmppolicy_binding.cmpglobal_cmppolicy_binding_response();
      cmpglobal_cmppolicy_binding.cmpglobal_cmppolicy_binding_response resource = (cmpglobal_cmppolicy_binding.cmpglobal_cmppolicy_binding_response) service.get_payload_formatter().string_to_resource(cmppolicyBindingResponse.GetType(), response);
      if (resource.errorcode != 0)
      {
        if (resource.errorcode == 444)
          service.clear_session();
        if (resource.severity == null)
          throw new nitro_exception(resource.message, resource.errorcode);
        if (resource.severity.Equals("ERROR"))
          throw new nitro_exception(resource.message, resource.errorcode);
      }
      return (base_resource[]) resource.cmpglobal_cmppolicy_binding;
    }

    internal override string get_object_name() => (string) null;

    public static base_response add(
      nitro_service client,
      cmpglobal_cmppolicy_binding resource)
    {
      return new cmpglobal_cmppolicy_binding()
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
      cmpglobal_cmppolicy_binding[] resources)
    {
      base_responses baseResponses = (base_responses) null;
      if (resources != null && resources.Length > 0)
      {
        cmpglobal_cmppolicy_binding[] cmppolicyBindingArray = new cmpglobal_cmppolicy_binding[resources.Length];
        for (int index = 0; index < resources.Length; ++index)
        {
          cmppolicyBindingArray[index] = new cmpglobal_cmppolicy_binding();
          cmppolicyBindingArray[index].policyname = resources[index].policyname;
          cmppolicyBindingArray[index].priority = resources[index].priority;
          cmppolicyBindingArray[index].state = resources[index].state;
          cmppolicyBindingArray[index].gotopriorityexpression = resources[index].gotopriorityexpression;
          cmppolicyBindingArray[index].type = resources[index].type;
          cmppolicyBindingArray[index].invoke = resources[index].invoke;
          cmppolicyBindingArray[index].labeltype = resources[index].labeltype;
          cmppolicyBindingArray[index].labelname = resources[index].labelname;
        }
        baseResponses = base_resource.update_bulk_request(client, (base_resource[]) cmppolicyBindingArray);
      }
      return baseResponses;
    }

    public static base_response delete(
      nitro_service client,
      cmpglobal_cmppolicy_binding resource)
    {
      return new cmpglobal_cmppolicy_binding()
      {
        policyname = resource.policyname,
        type = resource.type,
        priority = resource.priority
      }.delete_resource(client);
    }

    public static base_responses delete(
      nitro_service client,
      cmpglobal_cmppolicy_binding[] resources)
    {
      base_responses baseResponses = (base_responses) null;
      if (resources != null && resources.Length > 0)
      {
        cmpglobal_cmppolicy_binding[] cmppolicyBindingArray = new cmpglobal_cmppolicy_binding[resources.Length];
        for (int index = 0; index < resources.Length; ++index)
        {
          cmppolicyBindingArray[index] = new cmpglobal_cmppolicy_binding();
          cmppolicyBindingArray[index].policyname = resources[index].policyname;
          cmppolicyBindingArray[index].type = resources[index].type;
          cmppolicyBindingArray[index].priority = resources[index].priority;
        }
        baseResponses = base_resource.delete_bulk_request(client, (base_resource[]) cmppolicyBindingArray);
      }
      return baseResponses;
    }

    public static cmpglobal_cmppolicy_binding[] get(nitro_service service) => (cmpglobal_cmppolicy_binding[]) new cmpglobal_cmppolicy_binding().get_resources(service, (options) null);

    public static cmpglobal_cmppolicy_binding[] get_filtered(
      nitro_service service,
      string filter)
    {
      cmpglobal_cmppolicy_binding cmppolicyBinding = new cmpglobal_cmppolicy_binding();
      options option = new options();
      option.set_filter(filter);
      return (cmpglobal_cmppolicy_binding[]) cmppolicyBinding.getfiltered(service, option);
    }

    public static cmpglobal_cmppolicy_binding[] get_filtered(
      nitro_service service,
      filtervalue[] filter)
    {
      cmpglobal_cmppolicy_binding cmppolicyBinding = new cmpglobal_cmppolicy_binding();
      options option = new options();
      option.set_filter(filter);
      return (cmpglobal_cmppolicy_binding[]) cmppolicyBinding.getfiltered(service, option);
    }

    public static uint count(nitro_service service)
    {
      cmpglobal_cmppolicy_binding cmppolicyBinding = new cmpglobal_cmppolicy_binding();
      options option = new options();
      option.set_count(true);
      cmpglobal_cmppolicy_binding[] resources = (cmpglobal_cmppolicy_binding[]) cmppolicyBinding.get_resources(service, option);
      return resources != null && resources.Length > 0 ? resources[0].__count.Value : 0U;
    }

    public static uint count_filtered(nitro_service service, string filter)
    {
      cmpglobal_cmppolicy_binding cmppolicyBinding = new cmpglobal_cmppolicy_binding();
      options option = new options();
      option.set_count(true);
      option.set_filter(filter);
      cmpglobal_cmppolicy_binding[] cmppolicyBindingArray = (cmpglobal_cmppolicy_binding[]) cmppolicyBinding.getfiltered(service, option);
      return cmppolicyBindingArray != null && cmppolicyBindingArray.Length > 0 ? cmppolicyBindingArray[0].__count.Value : 0U;
    }

    public static uint count_filtered(nitro_service service, filtervalue[] filter)
    {
      cmpglobal_cmppolicy_binding cmppolicyBinding = new cmpglobal_cmppolicy_binding();
      options option = new options();
      option.set_count(true);
      option.set_filter(filter);
      cmpglobal_cmppolicy_binding[] cmppolicyBindingArray = (cmpglobal_cmppolicy_binding[]) cmppolicyBinding.getfiltered(service, option);
      return cmppolicyBindingArray != null && cmppolicyBindingArray.Length > 0 ? cmppolicyBindingArray[0].__count.Value : 0U;
    }

    private class cmpglobal_cmppolicy_binding_response : base_response
    {
      public cmpglobal_cmppolicy_binding[] cmpglobal_cmppolicy_binding = (cmpglobal_cmppolicy_binding[]) null;
    }

    public static class globalbindtypeEnum
    {
      public const string SYSTEM_GLOBAL = "SYSTEM_GLOBAL";
      public const string VPN_GLOBAL = "VPN_GLOBAL";
      public const string RNAT_GLOBAL = "RNAT_GLOBAL";
    }

    public static class stateEnum
    {
      public const string ENABLED = "ENABLED";
      public const string DISABLED = "DISABLED";
    }

    public static class typeEnum
    {
      public const string REQ_OVERRIDE = "REQ_OVERRIDE";
      public const string REQ_DEFAULT = "REQ_DEFAULT";
      public const string RES_OVERRIDE = "RES_OVERRIDE";
      public const string RES_DEFAULT = "RES_DEFAULT";
    }

    public static class labeltypeEnum
    {
      public const string reqvserver = "reqvserver";
      public const string resvserver = "resvserver";
      public const string policylabel = "policylabel";
    }

    public static class policytypeEnum
    {
      public const string Classic_Policy = "Classic Policy";
      public const string Advanced_Policy = "Advanced Policy";
    }
  }
}
