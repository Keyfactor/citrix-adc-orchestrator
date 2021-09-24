// Decompiled with JetBrains decompiler
// Type: com.citrix.netscaler.nitro.resource.config.transform.transformglobal_transformpolicy_binding
// Assembly: nitro, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 6CF5DDEF-E052-4F9D-953F-6644F8378A66


using com.citrix.netscaler.nitro.exception;
using com.citrix.netscaler.nitro.resource.Base;
using com.citrix.netscaler.nitro.service;
using com.citrix.netscaler.nitro.util;

namespace com.citrix.netscaler.nitro.resource.config.transform
{
  public class transformglobal_transformpolicy_binding : base_resource
  {
    private string policynameField = (string) null;
    private string typeField = (string) null;
    private uint? priorityField = new uint?();
    private string gotopriorityexpressionField = (string) null;
    private bool? invokeField = new bool?();
    private string labeltypeField = (string) null;
    private string labelnameField = (string) null;
    private uint? numpolField = new uint?();
    private uint? flowtypeField = new uint?();
    private string globalbindtypeField = (string) null;
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
      transformglobal_transformpolicy_binding.transformglobal_transformpolicy_binding_response transformpolicyBindingResponse = new transformglobal_transformpolicy_binding.transformglobal_transformpolicy_binding_response();
      transformglobal_transformpolicy_binding.transformglobal_transformpolicy_binding_response resource = (transformglobal_transformpolicy_binding.transformglobal_transformpolicy_binding_response) service.get_payload_formatter().string_to_resource(transformpolicyBindingResponse.GetType(), response);
      if (resource.errorcode != 0)
      {
        if (resource.errorcode == 444)
          service.clear_session();
        if (resource.severity == null)
          throw new nitro_exception(resource.message, resource.errorcode);
        if (resource.severity.Equals("ERROR"))
          throw new nitro_exception(resource.message, resource.errorcode);
      }
      return (base_resource[]) resource.transformglobal_transformpolicy_binding;
    }

    internal override string get_object_name() => (string) null;

    public static base_response add(
      nitro_service client,
      transformglobal_transformpolicy_binding resource)
    {
      return new transformglobal_transformpolicy_binding()
      {
        policyname = resource.policyname,
        priority = resource.priority,
        gotopriorityexpression = resource.gotopriorityexpression,
        type = resource.type,
        invoke = resource.invoke,
        labeltype = resource.labeltype,
        labelname = resource.labelname
      }.update_resource(client);
    }

    public static base_responses add(
      nitro_service client,
      transformglobal_transformpolicy_binding[] resources)
    {
      base_responses baseResponses = (base_responses) null;
      if (resources != null && resources.Length > 0)
      {
        transformglobal_transformpolicy_binding[] transformpolicyBindingArray = new transformglobal_transformpolicy_binding[resources.Length];
        for (int index = 0; index < resources.Length; ++index)
        {
          transformpolicyBindingArray[index] = new transformglobal_transformpolicy_binding();
          transformpolicyBindingArray[index].policyname = resources[index].policyname;
          transformpolicyBindingArray[index].priority = resources[index].priority;
          transformpolicyBindingArray[index].gotopriorityexpression = resources[index].gotopriorityexpression;
          transformpolicyBindingArray[index].type = resources[index].type;
          transformpolicyBindingArray[index].invoke = resources[index].invoke;
          transformpolicyBindingArray[index].labeltype = resources[index].labeltype;
          transformpolicyBindingArray[index].labelname = resources[index].labelname;
        }
        baseResponses = base_resource.update_bulk_request(client, (base_resource[]) transformpolicyBindingArray);
      }
      return baseResponses;
    }

    public static base_response delete(
      nitro_service client,
      transformglobal_transformpolicy_binding resource)
    {
      return new transformglobal_transformpolicy_binding()
      {
        policyname = resource.policyname,
        type = resource.type,
        priority = resource.priority
      }.delete_resource(client);
    }

    public static base_responses delete(
      nitro_service client,
      transformglobal_transformpolicy_binding[] resources)
    {
      base_responses baseResponses = (base_responses) null;
      if (resources != null && resources.Length > 0)
      {
        transformglobal_transformpolicy_binding[] transformpolicyBindingArray = new transformglobal_transformpolicy_binding[resources.Length];
        for (int index = 0; index < resources.Length; ++index)
        {
          transformpolicyBindingArray[index] = new transformglobal_transformpolicy_binding();
          transformpolicyBindingArray[index].policyname = resources[index].policyname;
          transformpolicyBindingArray[index].type = resources[index].type;
          transformpolicyBindingArray[index].priority = resources[index].priority;
        }
        baseResponses = base_resource.delete_bulk_request(client, (base_resource[]) transformpolicyBindingArray);
      }
      return baseResponses;
    }

    public static transformglobal_transformpolicy_binding[] get(
      nitro_service service)
    {
      return (transformglobal_transformpolicy_binding[]) new transformglobal_transformpolicy_binding().get_resources(service, (options) null);
    }

    public static transformglobal_transformpolicy_binding[] get_filtered(
      nitro_service service,
      string filter)
    {
      transformglobal_transformpolicy_binding transformpolicyBinding = new transformglobal_transformpolicy_binding();
      options option = new options();
      option.set_filter(filter);
      return (transformglobal_transformpolicy_binding[]) transformpolicyBinding.getfiltered(service, option);
    }

    public static transformglobal_transformpolicy_binding[] get_filtered(
      nitro_service service,
      filtervalue[] filter)
    {
      transformglobal_transformpolicy_binding transformpolicyBinding = new transformglobal_transformpolicy_binding();
      options option = new options();
      option.set_filter(filter);
      return (transformglobal_transformpolicy_binding[]) transformpolicyBinding.getfiltered(service, option);
    }

    public static uint count(nitro_service service)
    {
      transformglobal_transformpolicy_binding transformpolicyBinding = new transformglobal_transformpolicy_binding();
      options option = new options();
      option.set_count(true);
      transformglobal_transformpolicy_binding[] resources = (transformglobal_transformpolicy_binding[]) transformpolicyBinding.get_resources(service, option);
      return resources != null && resources.Length > 0 ? resources[0].__count.Value : 0U;
    }

    public static uint count_filtered(nitro_service service, string filter)
    {
      transformglobal_transformpolicy_binding transformpolicyBinding = new transformglobal_transformpolicy_binding();
      options option = new options();
      option.set_count(true);
      option.set_filter(filter);
      transformglobal_transformpolicy_binding[] transformpolicyBindingArray = (transformglobal_transformpolicy_binding[]) transformpolicyBinding.getfiltered(service, option);
      return transformpolicyBindingArray != null && transformpolicyBindingArray.Length > 0 ? transformpolicyBindingArray[0].__count.Value : 0U;
    }

    public static uint count_filtered(nitro_service service, filtervalue[] filter)
    {
      transformglobal_transformpolicy_binding transformpolicyBinding = new transformglobal_transformpolicy_binding();
      options option = new options();
      option.set_count(true);
      option.set_filter(filter);
      transformglobal_transformpolicy_binding[] transformpolicyBindingArray = (transformglobal_transformpolicy_binding[]) transformpolicyBinding.getfiltered(service, option);
      return transformpolicyBindingArray != null && transformpolicyBindingArray.Length > 0 ? transformpolicyBindingArray[0].__count.Value : 0U;
    }

    private class transformglobal_transformpolicy_binding_response : base_response
    {
      public transformglobal_transformpolicy_binding[] transformglobal_transformpolicy_binding = (transformglobal_transformpolicy_binding[]) null;
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
    }

    public static class labeltypeEnum
    {
      public const string reqvserver = "reqvserver";
      public const string resvserver = "resvserver";
      public const string policylabel = "policylabel";
    }
  }
}
