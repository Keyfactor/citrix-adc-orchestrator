// Decompiled with JetBrains decompiler
// Type: com.citrix.netscaler.nitro.resource.config.cache.cacheglobal_cachepolicy_binding
// Assembly: nitro, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 6CF5DDEF-E052-4F9D-953F-6644F8378A66


using com.citrix.netscaler.nitro.exception;
using com.citrix.netscaler.nitro.resource.Base;
using com.citrix.netscaler.nitro.service;
using com.citrix.netscaler.nitro.util;

namespace com.citrix.netscaler.nitro.resource.config.cache
{
  public class cacheglobal_cachepolicy_binding : base_resource
  {
    private string policyField = (string) null;
    private string typeField = (string) null;
    private uint? priorityField = new uint?();
    private string gotopriorityexpressionField = (string) null;
    private bool? invokeField = new bool?();
    private string labeltypeField = (string) null;
    private string labelnameField = (string) null;
    private uint? numpolField = new uint?();
    private uint? flowtypeField = new uint?();
    private string globalbindtypeField = (string) null;
    private string precededefrulesField = (string) null;
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

    public string gotopriorityexpression
    {
      get => this.gotopriorityexpressionField;
      set => this.gotopriorityexpressionField = value;
    }

    public string policy
    {
      get => this.policyField;
      set => this.policyField = value;
    }

    public string type
    {
      get => this.typeField;
      set => this.typeField = value;
    }

    public string precededefrules
    {
      get => this.precededefrulesField;
      set => this.precededefrulesField = value;
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

    public uint? flowtype
    {
      get => this.flowtypeField;
      private set => this.flowtypeField = value;
    }

    internal override base_resource[] get_nitro_response(
      nitro_service service,
      string response)
    {
      cacheglobal_cachepolicy_binding.cacheglobal_cachepolicy_binding_response cachepolicyBindingResponse = new cacheglobal_cachepolicy_binding.cacheglobal_cachepolicy_binding_response();
      cacheglobal_cachepolicy_binding.cacheglobal_cachepolicy_binding_response resource = (cacheglobal_cachepolicy_binding.cacheglobal_cachepolicy_binding_response) service.get_payload_formatter().string_to_resource(cachepolicyBindingResponse.GetType(), response);
      if (resource.errorcode != 0)
      {
        if (resource.errorcode == 444)
          service.clear_session();
        if (resource.severity == null)
          throw new nitro_exception(resource.message, resource.errorcode);
        if (resource.severity.Equals("ERROR"))
          throw new nitro_exception(resource.message, resource.errorcode);
      }
      return (base_resource[]) resource.cacheglobal_cachepolicy_binding;
    }

    internal override string get_object_name() => (string) null;

    public static base_response add(
      nitro_service client,
      cacheglobal_cachepolicy_binding resource)
    {
      return new cacheglobal_cachepolicy_binding()
      {
        policy = resource.policy,
        priority = resource.priority,
        precededefrules = resource.precededefrules,
        gotopriorityexpression = resource.gotopriorityexpression,
        type = resource.type,
        invoke = resource.invoke,
        labeltype = resource.labeltype,
        labelname = resource.labelname
      }.update_resource(client);
    }

    public static base_responses add(
      nitro_service client,
      cacheglobal_cachepolicy_binding[] resources)
    {
      base_responses baseResponses = (base_responses) null;
      if (resources != null && resources.Length > 0)
      {
        cacheglobal_cachepolicy_binding[] cachepolicyBindingArray = new cacheglobal_cachepolicy_binding[resources.Length];
        for (int index = 0; index < resources.Length; ++index)
        {
          cachepolicyBindingArray[index] = new cacheglobal_cachepolicy_binding();
          cachepolicyBindingArray[index].policy = resources[index].policy;
          cachepolicyBindingArray[index].priority = resources[index].priority;
          cachepolicyBindingArray[index].precededefrules = resources[index].precededefrules;
          cachepolicyBindingArray[index].gotopriorityexpression = resources[index].gotopriorityexpression;
          cachepolicyBindingArray[index].type = resources[index].type;
          cachepolicyBindingArray[index].invoke = resources[index].invoke;
          cachepolicyBindingArray[index].labeltype = resources[index].labeltype;
          cachepolicyBindingArray[index].labelname = resources[index].labelname;
        }
        baseResponses = base_resource.update_bulk_request(client, (base_resource[]) cachepolicyBindingArray);
      }
      return baseResponses;
    }

    public static base_response delete(
      nitro_service client,
      cacheglobal_cachepolicy_binding resource)
    {
      return new cacheglobal_cachepolicy_binding()
      {
        policy = resource.policy,
        type = resource.type,
        priority = resource.priority
      }.delete_resource(client);
    }

    public static base_responses delete(
      nitro_service client,
      cacheglobal_cachepolicy_binding[] resources)
    {
      base_responses baseResponses = (base_responses) null;
      if (resources != null && resources.Length > 0)
      {
        cacheglobal_cachepolicy_binding[] cachepolicyBindingArray = new cacheglobal_cachepolicy_binding[resources.Length];
        for (int index = 0; index < resources.Length; ++index)
        {
          cachepolicyBindingArray[index] = new cacheglobal_cachepolicy_binding();
          cachepolicyBindingArray[index].policy = resources[index].policy;
          cachepolicyBindingArray[index].type = resources[index].type;
          cachepolicyBindingArray[index].priority = resources[index].priority;
        }
        baseResponses = base_resource.delete_bulk_request(client, (base_resource[]) cachepolicyBindingArray);
      }
      return baseResponses;
    }

    public static cacheglobal_cachepolicy_binding[] get(
      nitro_service service)
    {
      return (cacheglobal_cachepolicy_binding[]) new cacheglobal_cachepolicy_binding().get_resources(service, (options) null);
    }

    public static cacheglobal_cachepolicy_binding[] get_filtered(
      nitro_service service,
      string filter)
    {
      cacheglobal_cachepolicy_binding cachepolicyBinding = new cacheglobal_cachepolicy_binding();
      options option = new options();
      option.set_filter(filter);
      return (cacheglobal_cachepolicy_binding[]) cachepolicyBinding.getfiltered(service, option);
    }

    public static cacheglobal_cachepolicy_binding[] get_filtered(
      nitro_service service,
      filtervalue[] filter)
    {
      cacheglobal_cachepolicy_binding cachepolicyBinding = new cacheglobal_cachepolicy_binding();
      options option = new options();
      option.set_filter(filter);
      return (cacheglobal_cachepolicy_binding[]) cachepolicyBinding.getfiltered(service, option);
    }

    public static uint count(nitro_service service)
    {
      cacheglobal_cachepolicy_binding cachepolicyBinding = new cacheglobal_cachepolicy_binding();
      options option = new options();
      option.set_count(true);
      cacheglobal_cachepolicy_binding[] resources = (cacheglobal_cachepolicy_binding[]) cachepolicyBinding.get_resources(service, option);
      return resources != null && resources.Length > 0 ? resources[0].__count.Value : 0U;
    }

    public static uint count_filtered(nitro_service service, string filter)
    {
      cacheglobal_cachepolicy_binding cachepolicyBinding = new cacheglobal_cachepolicy_binding();
      options option = new options();
      option.set_count(true);
      option.set_filter(filter);
      cacheglobal_cachepolicy_binding[] cachepolicyBindingArray = (cacheglobal_cachepolicy_binding[]) cachepolicyBinding.getfiltered(service, option);
      return cachepolicyBindingArray != null && cachepolicyBindingArray.Length > 0 ? cachepolicyBindingArray[0].__count.Value : 0U;
    }

    public static uint count_filtered(nitro_service service, filtervalue[] filter)
    {
      cacheglobal_cachepolicy_binding cachepolicyBinding = new cacheglobal_cachepolicy_binding();
      options option = new options();
      option.set_count(true);
      option.set_filter(filter);
      cacheglobal_cachepolicy_binding[] cachepolicyBindingArray = (cacheglobal_cachepolicy_binding[]) cachepolicyBinding.getfiltered(service, option);
      return cachepolicyBindingArray != null && cachepolicyBindingArray.Length > 0 ? cachepolicyBindingArray[0].__count.Value : 0U;
    }

    private class cacheglobal_cachepolicy_binding_response : base_response
    {
      public cacheglobal_cachepolicy_binding[] cacheglobal_cachepolicy_binding = (cacheglobal_cachepolicy_binding[]) null;
    }

    public static class globalbindtypeEnum
    {
      public const string SYSTEM_GLOBAL = "SYSTEM_GLOBAL";
      public const string VPN_GLOBAL = "VPN_GLOBAL";
      public const string RNAT_GLOBAL = "RNAT_GLOBAL";
    }

    public static class typeEnum
    {
      public const string REQ_OVERRIDE = "REQ_OVERRIDE";
      public const string REQ_DEFAULT = "REQ_DEFAULT";
      public const string RES_OVERRIDE = "RES_OVERRIDE";
      public const string RES_DEFAULT = "RES_DEFAULT";
    }

    public static class precededefrulesEnum
    {
      public const string YES = "YES";
      public const string NO = "NO";
    }

    public static class labeltypeEnum
    {
      public const string reqvserver = "reqvserver";
      public const string resvserver = "resvserver";
      public const string policylabel = "policylabel";
    }
  }
}
