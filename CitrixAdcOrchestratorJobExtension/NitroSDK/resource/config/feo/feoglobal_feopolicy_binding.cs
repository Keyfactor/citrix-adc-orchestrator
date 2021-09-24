// Decompiled with JetBrains decompiler
// Type: com.citrix.netscaler.nitro.resource.config.feo.feoglobal_feopolicy_binding
// Assembly: nitro, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 6CF5DDEF-E052-4F9D-953F-6644F8378A66


using com.citrix.netscaler.nitro.exception;
using com.citrix.netscaler.nitro.resource.Base;
using com.citrix.netscaler.nitro.service;
using com.citrix.netscaler.nitro.util;

namespace com.citrix.netscaler.nitro.resource.config.feo
{
  public class feoglobal_feopolicy_binding : base_resource
  {
    private string policynameField = (string) null;
    private uint? priorityField = new uint?();
    private string gotopriorityexpressionField = (string) null;
    private string typeField = (string) null;
    private uint? numpolField = new uint?();
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

    public uint? numpol
    {
      get => this.numpolField;
      private set => this.numpolField = value;
    }

    internal override base_resource[] get_nitro_response(
      nitro_service service,
      string response)
    {
      feoglobal_feopolicy_binding.feoglobal_feopolicy_binding_response feopolicyBindingResponse = new feoglobal_feopolicy_binding.feoglobal_feopolicy_binding_response();
      feoglobal_feopolicy_binding.feoglobal_feopolicy_binding_response resource = (feoglobal_feopolicy_binding.feoglobal_feopolicy_binding_response) service.get_payload_formatter().string_to_resource(feopolicyBindingResponse.GetType(), response);
      if (resource.errorcode != 0)
      {
        if (resource.errorcode == 444)
          service.clear_session();
        if (resource.severity == null)
          throw new nitro_exception(resource.message, resource.errorcode);
        if (resource.severity.Equals("ERROR"))
          throw new nitro_exception(resource.message, resource.errorcode);
      }
      return (base_resource[]) resource.feoglobal_feopolicy_binding;
    }

    internal override string get_object_name() => (string) null;

    public static base_response add(
      nitro_service client,
      feoglobal_feopolicy_binding resource)
    {
      return new feoglobal_feopolicy_binding()
      {
        policyname = resource.policyname,
        priority = resource.priority,
        type = resource.type,
        gotopriorityexpression = resource.gotopriorityexpression
      }.update_resource(client);
    }

    public static base_responses add(
      nitro_service client,
      feoglobal_feopolicy_binding[] resources)
    {
      base_responses baseResponses = (base_responses) null;
      if (resources != null && resources.Length > 0)
      {
        feoglobal_feopolicy_binding[] feopolicyBindingArray = new feoglobal_feopolicy_binding[resources.Length];
        for (int index = 0; index < resources.Length; ++index)
        {
          feopolicyBindingArray[index] = new feoglobal_feopolicy_binding();
          feopolicyBindingArray[index].policyname = resources[index].policyname;
          feopolicyBindingArray[index].priority = resources[index].priority;
          feopolicyBindingArray[index].type = resources[index].type;
          feopolicyBindingArray[index].gotopriorityexpression = resources[index].gotopriorityexpression;
        }
        baseResponses = base_resource.update_bulk_request(client, (base_resource[]) feopolicyBindingArray);
      }
      return baseResponses;
    }

    public static base_response delete(
      nitro_service client,
      feoglobal_feopolicy_binding resource)
    {
      return new feoglobal_feopolicy_binding()
      {
        policyname = resource.policyname,
        type = resource.type,
        priority = resource.priority
      }.delete_resource(client);
    }

    public static base_responses delete(
      nitro_service client,
      feoglobal_feopolicy_binding[] resources)
    {
      base_responses baseResponses = (base_responses) null;
      if (resources != null && resources.Length > 0)
      {
        feoglobal_feopolicy_binding[] feopolicyBindingArray = new feoglobal_feopolicy_binding[resources.Length];
        for (int index = 0; index < resources.Length; ++index)
        {
          feopolicyBindingArray[index] = new feoglobal_feopolicy_binding();
          feopolicyBindingArray[index].policyname = resources[index].policyname;
          feopolicyBindingArray[index].type = resources[index].type;
          feopolicyBindingArray[index].priority = resources[index].priority;
        }
        baseResponses = base_resource.delete_bulk_request(client, (base_resource[]) feopolicyBindingArray);
      }
      return baseResponses;
    }

    public static feoglobal_feopolicy_binding[] get(nitro_service service) => (feoglobal_feopolicy_binding[]) new feoglobal_feopolicy_binding().get_resources(service, (options) null);

    public static feoglobal_feopolicy_binding[] get_filtered(
      nitro_service service,
      string filter)
    {
      feoglobal_feopolicy_binding feopolicyBinding = new feoglobal_feopolicy_binding();
      options option = new options();
      option.set_filter(filter);
      return (feoglobal_feopolicy_binding[]) feopolicyBinding.getfiltered(service, option);
    }

    public static feoglobal_feopolicy_binding[] get_filtered(
      nitro_service service,
      filtervalue[] filter)
    {
      feoglobal_feopolicy_binding feopolicyBinding = new feoglobal_feopolicy_binding();
      options option = new options();
      option.set_filter(filter);
      return (feoglobal_feopolicy_binding[]) feopolicyBinding.getfiltered(service, option);
    }

    public static uint count(nitro_service service)
    {
      feoglobal_feopolicy_binding feopolicyBinding = new feoglobal_feopolicy_binding();
      options option = new options();
      option.set_count(true);
      feoglobal_feopolicy_binding[] resources = (feoglobal_feopolicy_binding[]) feopolicyBinding.get_resources(service, option);
      return resources != null && resources.Length > 0 ? resources[0].__count.Value : 0U;
    }

    public static uint count_filtered(nitro_service service, string filter)
    {
      feoglobal_feopolicy_binding feopolicyBinding = new feoglobal_feopolicy_binding();
      options option = new options();
      option.set_count(true);
      option.set_filter(filter);
      feoglobal_feopolicy_binding[] feopolicyBindingArray = (feoglobal_feopolicy_binding[]) feopolicyBinding.getfiltered(service, option);
      return feopolicyBindingArray != null && feopolicyBindingArray.Length > 0 ? feopolicyBindingArray[0].__count.Value : 0U;
    }

    public static uint count_filtered(nitro_service service, filtervalue[] filter)
    {
      feoglobal_feopolicy_binding feopolicyBinding = new feoglobal_feopolicy_binding();
      options option = new options();
      option.set_count(true);
      option.set_filter(filter);
      feoglobal_feopolicy_binding[] feopolicyBindingArray = (feoglobal_feopolicy_binding[]) feopolicyBinding.getfiltered(service, option);
      return feopolicyBindingArray != null && feopolicyBindingArray.Length > 0 ? feopolicyBindingArray[0].__count.Value : 0U;
    }

    private class feoglobal_feopolicy_binding_response : base_response
    {
      public feoglobal_feopolicy_binding[] feoglobal_feopolicy_binding = (feoglobal_feopolicy_binding[]) null;
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
      public const string NONE = "NONE";
    }
  }
}
