// Decompiled with JetBrains decompiler
// Type: com.citrix.netscaler.nitro.resource.config.tm.tmglobal_tmtrafficpolicy_binding
// Assembly: nitro, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 6CF5DDEF-E052-4F9D-953F-6644F8378A66


using com.citrix.netscaler.nitro.exception;
using com.citrix.netscaler.nitro.resource.Base;
using com.citrix.netscaler.nitro.service;
using com.citrix.netscaler.nitro.util;

namespace com.citrix.netscaler.nitro.resource.config.tm
{
  public class tmglobal_tmtrafficpolicy_binding : base_resource
  {
    private string policynameField = (string) null;
    private uint? priorityField = new uint?();
    private uint? bindpolicytypeField = new uint?();
    private string typeField = (string) null;
    private string globalbindtypeField = (string) null;
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

    public uint? bindpolicytype
    {
      get => this.bindpolicytypeField;
      private set => this.bindpolicytypeField = value;
    }

    internal override base_resource[] get_nitro_response(
      nitro_service service,
      string response)
    {
      tmglobal_tmtrafficpolicy_binding.tmglobal_tmtrafficpolicy_binding_response tmtrafficpolicyBindingResponse = new tmglobal_tmtrafficpolicy_binding.tmglobal_tmtrafficpolicy_binding_response();
      tmglobal_tmtrafficpolicy_binding.tmglobal_tmtrafficpolicy_binding_response resource = (tmglobal_tmtrafficpolicy_binding.tmglobal_tmtrafficpolicy_binding_response) service.get_payload_formatter().string_to_resource(tmtrafficpolicyBindingResponse.GetType(), response);
      if (resource.errorcode != 0)
      {
        if (resource.errorcode == 444)
          service.clear_session();
        if (resource.severity == null)
          throw new nitro_exception(resource.message, resource.errorcode);
        if (resource.severity.Equals("ERROR"))
          throw new nitro_exception(resource.message, resource.errorcode);
      }
      return (base_resource[]) resource.tmglobal_tmtrafficpolicy_binding;
    }

    internal override string get_object_name() => (string) null;

    public static base_response add(
      nitro_service client,
      tmglobal_tmtrafficpolicy_binding resource)
    {
      return new tmglobal_tmtrafficpolicy_binding()
      {
        policyname = resource.policyname,
        priority = resource.priority,
        gotopriorityexpression = resource.gotopriorityexpression
      }.update_resource(client);
    }

    public static base_responses add(
      nitro_service client,
      tmglobal_tmtrafficpolicy_binding[] resources)
    {
      base_responses baseResponses = (base_responses) null;
      if (resources != null && resources.Length > 0)
      {
        tmglobal_tmtrafficpolicy_binding[] tmtrafficpolicyBindingArray = new tmglobal_tmtrafficpolicy_binding[resources.Length];
        for (int index = 0; index < resources.Length; ++index)
        {
          tmtrafficpolicyBindingArray[index] = new tmglobal_tmtrafficpolicy_binding();
          tmtrafficpolicyBindingArray[index].policyname = resources[index].policyname;
          tmtrafficpolicyBindingArray[index].priority = resources[index].priority;
          tmtrafficpolicyBindingArray[index].gotopriorityexpression = resources[index].gotopriorityexpression;
        }
        baseResponses = base_resource.update_bulk_request(client, (base_resource[]) tmtrafficpolicyBindingArray);
      }
      return baseResponses;
    }

    public static base_response delete(
      nitro_service client,
      tmglobal_tmtrafficpolicy_binding resource)
    {
      return new tmglobal_tmtrafficpolicy_binding()
      {
        policyname = resource.policyname
      }.delete_resource(client);
    }

    public static base_responses delete(
      nitro_service client,
      tmglobal_tmtrafficpolicy_binding[] resources)
    {
      base_responses baseResponses = (base_responses) null;
      if (resources != null && resources.Length > 0)
      {
        tmglobal_tmtrafficpolicy_binding[] tmtrafficpolicyBindingArray = new tmglobal_tmtrafficpolicy_binding[resources.Length];
        for (int index = 0; index < resources.Length; ++index)
        {
          tmtrafficpolicyBindingArray[index] = new tmglobal_tmtrafficpolicy_binding();
          tmtrafficpolicyBindingArray[index].policyname = resources[index].policyname;
        }
        baseResponses = base_resource.delete_bulk_request(client, (base_resource[]) tmtrafficpolicyBindingArray);
      }
      return baseResponses;
    }

    public static tmglobal_tmtrafficpolicy_binding[] get(
      nitro_service service)
    {
      return (tmglobal_tmtrafficpolicy_binding[]) new tmglobal_tmtrafficpolicy_binding().get_resources(service, (options) null);
    }

    public static tmglobal_tmtrafficpolicy_binding[] get_filtered(
      nitro_service service,
      string filter)
    {
      tmglobal_tmtrafficpolicy_binding tmtrafficpolicyBinding = new tmglobal_tmtrafficpolicy_binding();
      options option = new options();
      option.set_filter(filter);
      return (tmglobal_tmtrafficpolicy_binding[]) tmtrafficpolicyBinding.getfiltered(service, option);
    }

    public static tmglobal_tmtrafficpolicy_binding[] get_filtered(
      nitro_service service,
      filtervalue[] filter)
    {
      tmglobal_tmtrafficpolicy_binding tmtrafficpolicyBinding = new tmglobal_tmtrafficpolicy_binding();
      options option = new options();
      option.set_filter(filter);
      return (tmglobal_tmtrafficpolicy_binding[]) tmtrafficpolicyBinding.getfiltered(service, option);
    }

    public static uint count(nitro_service service)
    {
      tmglobal_tmtrafficpolicy_binding tmtrafficpolicyBinding = new tmglobal_tmtrafficpolicy_binding();
      options option = new options();
      option.set_count(true);
      tmglobal_tmtrafficpolicy_binding[] resources = (tmglobal_tmtrafficpolicy_binding[]) tmtrafficpolicyBinding.get_resources(service, option);
      return resources != null && resources.Length > 0 ? resources[0].__count.Value : 0U;
    }

    public static uint count_filtered(nitro_service service, string filter)
    {
      tmglobal_tmtrafficpolicy_binding tmtrafficpolicyBinding = new tmglobal_tmtrafficpolicy_binding();
      options option = new options();
      option.set_count(true);
      option.set_filter(filter);
      tmglobal_tmtrafficpolicy_binding[] tmtrafficpolicyBindingArray = (tmglobal_tmtrafficpolicy_binding[]) tmtrafficpolicyBinding.getfiltered(service, option);
      return tmtrafficpolicyBindingArray != null && tmtrafficpolicyBindingArray.Length > 0 ? tmtrafficpolicyBindingArray[0].__count.Value : 0U;
    }

    public static uint count_filtered(nitro_service service, filtervalue[] filter)
    {
      tmglobal_tmtrafficpolicy_binding tmtrafficpolicyBinding = new tmglobal_tmtrafficpolicy_binding();
      options option = new options();
      option.set_count(true);
      option.set_filter(filter);
      tmglobal_tmtrafficpolicy_binding[] tmtrafficpolicyBindingArray = (tmglobal_tmtrafficpolicy_binding[]) tmtrafficpolicyBinding.getfiltered(service, option);
      return tmtrafficpolicyBindingArray != null && tmtrafficpolicyBindingArray.Length > 0 ? tmtrafficpolicyBindingArray[0].__count.Value : 0U;
    }

    private class tmglobal_tmtrafficpolicy_binding_response : base_response
    {
      public tmglobal_tmtrafficpolicy_binding[] tmglobal_tmtrafficpolicy_binding = (tmglobal_tmtrafficpolicy_binding[]) null;
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
  }
}
