// Decompiled with JetBrains decompiler
// Type: com.citrix.netscaler.nitro.resource.config.rewrite.rewriteglobal_rewritepolicy_binding
// Assembly: nitro, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 6CF5DDEF-E052-4F9D-953F-6644F8378A66


using com.citrix.netscaler.nitro.exception;
using com.citrix.netscaler.nitro.resource.Base;
using com.citrix.netscaler.nitro.service;
using com.citrix.netscaler.nitro.util;

namespace com.citrix.netscaler.nitro.resource.config.rewrite
{
  public class rewriteglobal_rewritepolicy_binding : base_resource
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

    public uint? flowtype
    {
      get => this.flowtypeField;
      private set => this.flowtypeField = value;
    }

    public uint? numpol
    {
      get => this.numpolField;
      private set => this.numpolField = value;
    }

    internal override base_resource[] get_nitro_response(
      nitro_service service,
      string response)
    {
      rewriteglobal_rewritepolicy_binding.rewriteglobal_rewritepolicy_binding_response rewritepolicyBindingResponse = new rewriteglobal_rewritepolicy_binding.rewriteglobal_rewritepolicy_binding_response();
      rewriteglobal_rewritepolicy_binding.rewriteglobal_rewritepolicy_binding_response resource = (rewriteglobal_rewritepolicy_binding.rewriteglobal_rewritepolicy_binding_response) service.get_payload_formatter().string_to_resource(rewritepolicyBindingResponse.GetType(), response);
      if (resource.errorcode != 0)
      {
        if (resource.errorcode == 444)
          service.clear_session();
        if (resource.severity == null)
          throw new nitro_exception(resource.message, resource.errorcode);
        if (resource.severity.Equals("ERROR"))
          throw new nitro_exception(resource.message, resource.errorcode);
      }
      return (base_resource[]) resource.rewriteglobal_rewritepolicy_binding;
    }

    internal override string get_object_name() => (string) null;

    public static base_response add(
      nitro_service client,
      rewriteglobal_rewritepolicy_binding resource)
    {
      return new rewriteglobal_rewritepolicy_binding()
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
      rewriteglobal_rewritepolicy_binding[] resources)
    {
      base_responses baseResponses = (base_responses) null;
      if (resources != null && resources.Length > 0)
      {
        rewriteglobal_rewritepolicy_binding[] rewritepolicyBindingArray = new rewriteglobal_rewritepolicy_binding[resources.Length];
        for (int index = 0; index < resources.Length; ++index)
        {
          rewritepolicyBindingArray[index] = new rewriteglobal_rewritepolicy_binding();
          rewritepolicyBindingArray[index].policyname = resources[index].policyname;
          rewritepolicyBindingArray[index].priority = resources[index].priority;
          rewritepolicyBindingArray[index].gotopriorityexpression = resources[index].gotopriorityexpression;
          rewritepolicyBindingArray[index].type = resources[index].type;
          rewritepolicyBindingArray[index].invoke = resources[index].invoke;
          rewritepolicyBindingArray[index].labeltype = resources[index].labeltype;
          rewritepolicyBindingArray[index].labelname = resources[index].labelname;
        }
        baseResponses = base_resource.update_bulk_request(client, (base_resource[]) rewritepolicyBindingArray);
      }
      return baseResponses;
    }

    public static base_response delete(
      nitro_service client,
      rewriteglobal_rewritepolicy_binding resource)
    {
      return new rewriteglobal_rewritepolicy_binding()
      {
        policyname = resource.policyname,
        type = resource.type,
        priority = resource.priority
      }.delete_resource(client);
    }

    public static base_responses delete(
      nitro_service client,
      rewriteglobal_rewritepolicy_binding[] resources)
    {
      base_responses baseResponses = (base_responses) null;
      if (resources != null && resources.Length > 0)
      {
        rewriteglobal_rewritepolicy_binding[] rewritepolicyBindingArray = new rewriteglobal_rewritepolicy_binding[resources.Length];
        for (int index = 0; index < resources.Length; ++index)
        {
          rewritepolicyBindingArray[index] = new rewriteglobal_rewritepolicy_binding();
          rewritepolicyBindingArray[index].policyname = resources[index].policyname;
          rewritepolicyBindingArray[index].type = resources[index].type;
          rewritepolicyBindingArray[index].priority = resources[index].priority;
        }
        baseResponses = base_resource.delete_bulk_request(client, (base_resource[]) rewritepolicyBindingArray);
      }
      return baseResponses;
    }

    public static rewriteglobal_rewritepolicy_binding[] get(
      nitro_service service)
    {
      return (rewriteglobal_rewritepolicy_binding[]) new rewriteglobal_rewritepolicy_binding().get_resources(service, (options) null);
    }

    public static rewriteglobal_rewritepolicy_binding[] get_filtered(
      nitro_service service,
      string filter)
    {
      rewriteglobal_rewritepolicy_binding rewritepolicyBinding = new rewriteglobal_rewritepolicy_binding();
      options option = new options();
      option.set_filter(filter);
      return (rewriteglobal_rewritepolicy_binding[]) rewritepolicyBinding.getfiltered(service, option);
    }

    public static rewriteglobal_rewritepolicy_binding[] get_filtered(
      nitro_service service,
      filtervalue[] filter)
    {
      rewriteglobal_rewritepolicy_binding rewritepolicyBinding = new rewriteglobal_rewritepolicy_binding();
      options option = new options();
      option.set_filter(filter);
      return (rewriteglobal_rewritepolicy_binding[]) rewritepolicyBinding.getfiltered(service, option);
    }

    public static uint count(nitro_service service)
    {
      rewriteglobal_rewritepolicy_binding rewritepolicyBinding = new rewriteglobal_rewritepolicy_binding();
      options option = new options();
      option.set_count(true);
      rewriteglobal_rewritepolicy_binding[] resources = (rewriteglobal_rewritepolicy_binding[]) rewritepolicyBinding.get_resources(service, option);
      return resources != null && resources.Length > 0 ? resources[0].__count.Value : 0U;
    }

    public static uint count_filtered(nitro_service service, string filter)
    {
      rewriteglobal_rewritepolicy_binding rewritepolicyBinding = new rewriteglobal_rewritepolicy_binding();
      options option = new options();
      option.set_count(true);
      option.set_filter(filter);
      rewriteglobal_rewritepolicy_binding[] rewritepolicyBindingArray = (rewriteglobal_rewritepolicy_binding[]) rewritepolicyBinding.getfiltered(service, option);
      return rewritepolicyBindingArray != null && rewritepolicyBindingArray.Length > 0 ? rewritepolicyBindingArray[0].__count.Value : 0U;
    }

    public static uint count_filtered(nitro_service service, filtervalue[] filter)
    {
      rewriteglobal_rewritepolicy_binding rewritepolicyBinding = new rewriteglobal_rewritepolicy_binding();
      options option = new options();
      option.set_count(true);
      option.set_filter(filter);
      rewriteglobal_rewritepolicy_binding[] rewritepolicyBindingArray = (rewriteglobal_rewritepolicy_binding[]) rewritepolicyBinding.getfiltered(service, option);
      return rewritepolicyBindingArray != null && rewritepolicyBindingArray.Length > 0 ? rewritepolicyBindingArray[0].__count.Value : 0U;
    }

    private class rewriteglobal_rewritepolicy_binding_response : base_response
    {
      public rewriteglobal_rewritepolicy_binding[] rewriteglobal_rewritepolicy_binding = (rewriteglobal_rewritepolicy_binding[]) null;
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
      public const string OTHERTCP_REQ_OVERRIDE = "OTHERTCP_REQ_OVERRIDE";
      public const string OTHERTCP_REQ_DEFAULT = "OTHERTCP_REQ_DEFAULT";
      public const string OTHERTCP_RES_OVERRIDE = "OTHERTCP_RES_OVERRIDE";
      public const string OTHERTCP_RES_DEFAULT = "OTHERTCP_RES_DEFAULT";
      public const string SIPUDP_REQ_OVERRIDE = "SIPUDP_REQ_OVERRIDE";
      public const string SIPUDP_REQ_DEFAULT = "SIPUDP_REQ_DEFAULT";
      public const string SIPUDP_RES_OVERRIDE = "SIPUDP_RES_OVERRIDE";
      public const string SIPUDP_RES_DEFAULT = "SIPUDP_RES_DEFAULT";
      public const string SIPTCP_REQ_OVERRIDE = "SIPTCP_REQ_OVERRIDE";
      public const string SIPTCP_REQ_DEFAULT = "SIPTCP_REQ_DEFAULT";
      public const string SIPTCP_RES_OVERRIDE = "SIPTCP_RES_OVERRIDE";
      public const string SIPTCP_RES_DEFAULT = "SIPTCP_RES_DEFAULT";
      public const string DIAMETER_REQ_OVERRIDE = "DIAMETER_REQ_OVERRIDE";
      public const string DIAMETER_REQ_DEFAULT = "DIAMETER_REQ_DEFAULT";
      public const string DIAMETER_RES_OVERRIDE = "DIAMETER_RES_OVERRIDE";
      public const string DIAMETER_RES_DEFAULT = "DIAMETER_RES_DEFAULT";
      public const string RADIUS_REQ_OVERRIDE = "RADIUS_REQ_OVERRIDE";
      public const string RADIUS_REQ_DEFAULT = "RADIUS_REQ_DEFAULT";
      public const string RADIUS_RES_OVERRIDE = "RADIUS_RES_OVERRIDE";
      public const string RADIUS_RES_DEFAULT = "RADIUS_RES_DEFAULT";
      public const string DNS_REQ_OVERRIDE = "DNS_REQ_OVERRIDE";
      public const string DNS_REQ_DEFAULT = "DNS_REQ_DEFAULT";
      public const string DNS_RES_OVERRIDE = "DNS_RES_OVERRIDE";
      public const string DNS_RES_DEFAULT = "DNS_RES_DEFAULT";
    }

    public static class labeltypeEnum
    {
      public const string reqvserver = "reqvserver";
      public const string resvserver = "resvserver";
      public const string policylabel = "policylabel";
    }
  }
}
