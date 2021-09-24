// Decompiled with JetBrains decompiler
// Type: com.citrix.netscaler.nitro.resource.config.ca.caglobal_capolicy_binding
// Assembly: nitro, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 6CF5DDEF-E052-4F9D-953F-6644F8378A66


using com.citrix.netscaler.nitro.exception;
using com.citrix.netscaler.nitro.resource.Base;
using com.citrix.netscaler.nitro.service;
using com.citrix.netscaler.nitro.util;

namespace com.citrix.netscaler.nitro.resource.config.ca
{
  public class caglobal_capolicy_binding : base_resource
  {
    private string policynameField = (string) null;
    private string typeField = (string) null;
    private uint? priorityField = new uint?();
    private string gotopriorityexpressionField = (string) null;
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

    public string gotopriorityexpression
    {
      get => this.gotopriorityexpressionField;
      set => this.gotopriorityexpressionField = value;
    }

    public string type
    {
      get => this.typeField;
      set => this.typeField = value;
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
      caglobal_capolicy_binding.caglobal_capolicy_binding_response capolicyBindingResponse = new caglobal_capolicy_binding.caglobal_capolicy_binding_response();
      caglobal_capolicy_binding.caglobal_capolicy_binding_response resource = (caglobal_capolicy_binding.caglobal_capolicy_binding_response) service.get_payload_formatter().string_to_resource(capolicyBindingResponse.GetType(), response);
      if (resource.errorcode != 0)
      {
        if (resource.errorcode == 444)
          service.clear_session();
        if (resource.severity == null)
          throw new nitro_exception(resource.message, resource.errorcode);
        if (resource.severity.Equals("ERROR"))
          throw new nitro_exception(resource.message, resource.errorcode);
      }
      return (base_resource[]) resource.caglobal_capolicy_binding;
    }

    internal override string get_object_name() => (string) null;

    public static base_response add(
      nitro_service client,
      caglobal_capolicy_binding resource)
    {
      return new caglobal_capolicy_binding()
      {
        policyname = resource.policyname,
        priority = resource.priority,
        gotopriorityexpression = resource.gotopriorityexpression,
        type = resource.type
      }.update_resource(client);
    }

    public static base_responses add(
      nitro_service client,
      caglobal_capolicy_binding[] resources)
    {
      base_responses baseResponses = (base_responses) null;
      if (resources != null && resources.Length > 0)
      {
        caglobal_capolicy_binding[] caglobalCapolicyBindingArray = new caglobal_capolicy_binding[resources.Length];
        for (int index = 0; index < resources.Length; ++index)
        {
          caglobalCapolicyBindingArray[index] = new caglobal_capolicy_binding();
          caglobalCapolicyBindingArray[index].policyname = resources[index].policyname;
          caglobalCapolicyBindingArray[index].priority = resources[index].priority;
          caglobalCapolicyBindingArray[index].gotopriorityexpression = resources[index].gotopriorityexpression;
          caglobalCapolicyBindingArray[index].type = resources[index].type;
        }
        baseResponses = base_resource.update_bulk_request(client, (base_resource[]) caglobalCapolicyBindingArray);
      }
      return baseResponses;
    }

    public static base_response delete(
      nitro_service client,
      caglobal_capolicy_binding resource)
    {
      return new caglobal_capolicy_binding()
      {
        policyname = resource.policyname,
        type = resource.type,
        priority = resource.priority
      }.delete_resource(client);
    }

    public static base_responses delete(
      nitro_service client,
      caglobal_capolicy_binding[] resources)
    {
      base_responses baseResponses = (base_responses) null;
      if (resources != null && resources.Length > 0)
      {
        caglobal_capolicy_binding[] caglobalCapolicyBindingArray = new caglobal_capolicy_binding[resources.Length];
        for (int index = 0; index < resources.Length; ++index)
        {
          caglobalCapolicyBindingArray[index] = new caglobal_capolicy_binding();
          caglobalCapolicyBindingArray[index].policyname = resources[index].policyname;
          caglobalCapolicyBindingArray[index].type = resources[index].type;
          caglobalCapolicyBindingArray[index].priority = resources[index].priority;
        }
        baseResponses = base_resource.delete_bulk_request(client, (base_resource[]) caglobalCapolicyBindingArray);
      }
      return baseResponses;
    }

    public static caglobal_capolicy_binding[] get(nitro_service service) => (caglobal_capolicy_binding[]) new caglobal_capolicy_binding().get_resources(service, (options) null);

    public static caglobal_capolicy_binding[] get_filtered(
      nitro_service service,
      string filter)
    {
      caglobal_capolicy_binding caglobalCapolicyBinding = new caglobal_capolicy_binding();
      options option = new options();
      option.set_filter(filter);
      return (caglobal_capolicy_binding[]) caglobalCapolicyBinding.getfiltered(service, option);
    }

    public static caglobal_capolicy_binding[] get_filtered(
      nitro_service service,
      filtervalue[] filter)
    {
      caglobal_capolicy_binding caglobalCapolicyBinding = new caglobal_capolicy_binding();
      options option = new options();
      option.set_filter(filter);
      return (caglobal_capolicy_binding[]) caglobalCapolicyBinding.getfiltered(service, option);
    }

    public static uint count(nitro_service service)
    {
      caglobal_capolicy_binding caglobalCapolicyBinding = new caglobal_capolicy_binding();
      options option = new options();
      option.set_count(true);
      caglobal_capolicy_binding[] resources = (caglobal_capolicy_binding[]) caglobalCapolicyBinding.get_resources(service, option);
      return resources != null && resources.Length > 0 ? resources[0].__count.Value : 0U;
    }

    public static uint count_filtered(nitro_service service, string filter)
    {
      caglobal_capolicy_binding caglobalCapolicyBinding = new caglobal_capolicy_binding();
      options option = new options();
      option.set_count(true);
      option.set_filter(filter);
      caglobal_capolicy_binding[] caglobalCapolicyBindingArray = (caglobal_capolicy_binding[]) caglobalCapolicyBinding.getfiltered(service, option);
      return caglobalCapolicyBindingArray != null && caglobalCapolicyBindingArray.Length > 0 ? caglobalCapolicyBindingArray[0].__count.Value : 0U;
    }

    public static uint count_filtered(nitro_service service, filtervalue[] filter)
    {
      caglobal_capolicy_binding caglobalCapolicyBinding = new caglobal_capolicy_binding();
      options option = new options();
      option.set_count(true);
      option.set_filter(filter);
      caglobal_capolicy_binding[] caglobalCapolicyBindingArray = (caglobal_capolicy_binding[]) caglobalCapolicyBinding.getfiltered(service, option);
      return caglobalCapolicyBindingArray != null && caglobalCapolicyBindingArray.Length > 0 ? caglobalCapolicyBindingArray[0].__count.Value : 0U;
    }

    private class caglobal_capolicy_binding_response : base_response
    {
      public caglobal_capolicy_binding[] caglobal_capolicy_binding = (caglobal_capolicy_binding[]) null;
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
