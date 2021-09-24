// Decompiled with JetBrains decompiler
// Type: com.citrix.netscaler.nitro.resource.config.tm.tmglobal_tmsessionpolicy_binding
// Assembly: nitro, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 6CF5DDEF-E052-4F9D-953F-6644F8378A66


using com.citrix.netscaler.nitro.exception;
using com.citrix.netscaler.nitro.resource.Base;
using com.citrix.netscaler.nitro.service;
using com.citrix.netscaler.nitro.util;

namespace com.citrix.netscaler.nitro.resource.config.tm
{
  public class tmglobal_tmsessionpolicy_binding : base_resource
  {
    private string policynameField = (string) null;
    private uint? priorityField = new uint?();
    private uint? bindpolicytypeField = new uint?();
    private string[] builtinField = (string[]) null;
    private string gotopriorityexpressionField = (string) null;
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

    public string[] builtin
    {
      get => this.builtinField;
      set => this.builtinField = value;
    }

    public string policyname
    {
      get => this.policynameField;
      set => this.policynameField = value;
    }

    public uint? bindpolicytype
    {
      get => this.bindpolicytypeField;
      private set => this.bindpolicytypeField = value;
    }

    internal override base_resource[] get_nitro_response(
      nitro_service service,
      string response)
    {
      tmglobal_tmsessionpolicy_binding.tmglobal_tmsessionpolicy_binding_response tmsessionpolicyBindingResponse = new tmglobal_tmsessionpolicy_binding.tmglobal_tmsessionpolicy_binding_response();
      tmglobal_tmsessionpolicy_binding.tmglobal_tmsessionpolicy_binding_response resource = (tmglobal_tmsessionpolicy_binding.tmglobal_tmsessionpolicy_binding_response) service.get_payload_formatter().string_to_resource(tmsessionpolicyBindingResponse.GetType(), response);
      if (resource.errorcode != 0)
      {
        if (resource.errorcode == 444)
          service.clear_session();
        if (resource.severity == null)
          throw new nitro_exception(resource.message, resource.errorcode);
        if (resource.severity.Equals("ERROR"))
          throw new nitro_exception(resource.message, resource.errorcode);
      }
      return (base_resource[]) resource.tmglobal_tmsessionpolicy_binding;
    }

    internal override string get_object_name() => (string) null;

    public static base_response add(
      nitro_service client,
      tmglobal_tmsessionpolicy_binding resource)
    {
      return new tmglobal_tmsessionpolicy_binding()
      {
        policyname = resource.policyname,
        priority = resource.priority,
        gotopriorityexpression = resource.gotopriorityexpression
      }.update_resource(client);
    }

    public static base_responses add(
      nitro_service client,
      tmglobal_tmsessionpolicy_binding[] resources)
    {
      base_responses baseResponses = (base_responses) null;
      if (resources != null && resources.Length > 0)
      {
        tmglobal_tmsessionpolicy_binding[] tmsessionpolicyBindingArray = new tmglobal_tmsessionpolicy_binding[resources.Length];
        for (int index = 0; index < resources.Length; ++index)
        {
          tmsessionpolicyBindingArray[index] = new tmglobal_tmsessionpolicy_binding();
          tmsessionpolicyBindingArray[index].policyname = resources[index].policyname;
          tmsessionpolicyBindingArray[index].priority = resources[index].priority;
          tmsessionpolicyBindingArray[index].gotopriorityexpression = resources[index].gotopriorityexpression;
        }
        baseResponses = base_resource.update_bulk_request(client, (base_resource[]) tmsessionpolicyBindingArray);
      }
      return baseResponses;
    }

    public static base_response delete(
      nitro_service client,
      tmglobal_tmsessionpolicy_binding resource)
    {
      return new tmglobal_tmsessionpolicy_binding()
      {
        policyname = resource.policyname
      }.delete_resource(client);
    }

    public static base_responses delete(
      nitro_service client,
      tmglobal_tmsessionpolicy_binding[] resources)
    {
      base_responses baseResponses = (base_responses) null;
      if (resources != null && resources.Length > 0)
      {
        tmglobal_tmsessionpolicy_binding[] tmsessionpolicyBindingArray = new tmglobal_tmsessionpolicy_binding[resources.Length];
        for (int index = 0; index < resources.Length; ++index)
        {
          tmsessionpolicyBindingArray[index] = new tmglobal_tmsessionpolicy_binding();
          tmsessionpolicyBindingArray[index].policyname = resources[index].policyname;
        }
        baseResponses = base_resource.delete_bulk_request(client, (base_resource[]) tmsessionpolicyBindingArray);
      }
      return baseResponses;
    }

    public static tmglobal_tmsessionpolicy_binding[] get(
      nitro_service service)
    {
      return (tmglobal_tmsessionpolicy_binding[]) new tmglobal_tmsessionpolicy_binding().get_resources(service, (options) null);
    }

    public static tmglobal_tmsessionpolicy_binding[] get_filtered(
      nitro_service service,
      string filter)
    {
      tmglobal_tmsessionpolicy_binding tmsessionpolicyBinding = new tmglobal_tmsessionpolicy_binding();
      options option = new options();
      option.set_filter(filter);
      return (tmglobal_tmsessionpolicy_binding[]) tmsessionpolicyBinding.getfiltered(service, option);
    }

    public static tmglobal_tmsessionpolicy_binding[] get_filtered(
      nitro_service service,
      filtervalue[] filter)
    {
      tmglobal_tmsessionpolicy_binding tmsessionpolicyBinding = new tmglobal_tmsessionpolicy_binding();
      options option = new options();
      option.set_filter(filter);
      return (tmglobal_tmsessionpolicy_binding[]) tmsessionpolicyBinding.getfiltered(service, option);
    }

    public static uint count(nitro_service service)
    {
      tmglobal_tmsessionpolicy_binding tmsessionpolicyBinding = new tmglobal_tmsessionpolicy_binding();
      options option = new options();
      option.set_count(true);
      tmglobal_tmsessionpolicy_binding[] resources = (tmglobal_tmsessionpolicy_binding[]) tmsessionpolicyBinding.get_resources(service, option);
      return resources != null && resources.Length > 0 ? resources[0].__count.Value : 0U;
    }

    public static uint count_filtered(nitro_service service, string filter)
    {
      tmglobal_tmsessionpolicy_binding tmsessionpolicyBinding = new tmglobal_tmsessionpolicy_binding();
      options option = new options();
      option.set_count(true);
      option.set_filter(filter);
      tmglobal_tmsessionpolicy_binding[] tmsessionpolicyBindingArray = (tmglobal_tmsessionpolicy_binding[]) tmsessionpolicyBinding.getfiltered(service, option);
      return tmsessionpolicyBindingArray != null && tmsessionpolicyBindingArray.Length > 0 ? tmsessionpolicyBindingArray[0].__count.Value : 0U;
    }

    public static uint count_filtered(nitro_service service, filtervalue[] filter)
    {
      tmglobal_tmsessionpolicy_binding tmsessionpolicyBinding = new tmglobal_tmsessionpolicy_binding();
      options option = new options();
      option.set_count(true);
      option.set_filter(filter);
      tmglobal_tmsessionpolicy_binding[] tmsessionpolicyBindingArray = (tmglobal_tmsessionpolicy_binding[]) tmsessionpolicyBinding.getfiltered(service, option);
      return tmsessionpolicyBindingArray != null && tmsessionpolicyBindingArray.Length > 0 ? tmsessionpolicyBindingArray[0].__count.Value : 0U;
    }

    private class tmglobal_tmsessionpolicy_binding_response : base_response
    {
      public tmglobal_tmsessionpolicy_binding[] tmglobal_tmsessionpolicy_binding = (tmglobal_tmsessionpolicy_binding[]) null;
    }

    public static class builtinEnum
    {
      public const string MODIFIABLE = "MODIFIABLE";
      public const string DELETABLE = "DELETABLE";
      public const string IMMUTABLE = "IMMUTABLE";
      public const string PARTITION_ALL = "PARTITION_ALL";
    }
  }
}
