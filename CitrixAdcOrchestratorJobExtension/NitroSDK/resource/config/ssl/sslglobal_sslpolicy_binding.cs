// Decompiled with JetBrains decompiler
// Type: com.citrix.netscaler.nitro.resource.config.ssl.sslglobal_sslpolicy_binding
// Assembly: nitro, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 6CF5DDEF-E052-4F9D-953F-6644F8378A66


using com.citrix.netscaler.nitro.exception;
using com.citrix.netscaler.nitro.resource.Base;
using com.citrix.netscaler.nitro.service;
using com.citrix.netscaler.nitro.util;

namespace com.citrix.netscaler.nitro.resource.config.ssl
{
  public class sslglobal_sslpolicy_binding : base_resource
  {
    private string policynameField = (string) null;
    private string typeField = (string) null;
    private uint? priorityField = new uint?();
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

    internal override base_resource[] get_nitro_response(
      nitro_service service,
      string response)
    {
      sslglobal_sslpolicy_binding.sslglobal_sslpolicy_binding_response sslpolicyBindingResponse = new sslglobal_sslpolicy_binding.sslglobal_sslpolicy_binding_response();
      sslglobal_sslpolicy_binding.sslglobal_sslpolicy_binding_response resource = (sslglobal_sslpolicy_binding.sslglobal_sslpolicy_binding_response) service.get_payload_formatter().string_to_resource(sslpolicyBindingResponse.GetType(), response);
      if (resource.errorcode != 0)
      {
        if (resource.errorcode == 444)
          service.clear_session();
        if (resource.severity == null)
          throw new nitro_exception(resource.message, resource.errorcode);
        if (resource.severity.Equals("ERROR"))
          throw new nitro_exception(resource.message, resource.errorcode);
      }
      return (base_resource[]) resource.sslglobal_sslpolicy_binding;
    }

    internal override string get_object_name() => (string) null;

    public static base_response add(
      nitro_service client,
      sslglobal_sslpolicy_binding resource)
    {
      return new sslglobal_sslpolicy_binding()
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
      sslglobal_sslpolicy_binding[] resources)
    {
      base_responses baseResponses = (base_responses) null;
      if (resources != null && resources.Length > 0)
      {
        sslglobal_sslpolicy_binding[] sslpolicyBindingArray = new sslglobal_sslpolicy_binding[resources.Length];
        for (int index = 0; index < resources.Length; ++index)
        {
          sslpolicyBindingArray[index] = new sslglobal_sslpolicy_binding();
          sslpolicyBindingArray[index].policyname = resources[index].policyname;
          sslpolicyBindingArray[index].priority = resources[index].priority;
          sslpolicyBindingArray[index].gotopriorityexpression = resources[index].gotopriorityexpression;
          sslpolicyBindingArray[index].type = resources[index].type;
          sslpolicyBindingArray[index].invoke = resources[index].invoke;
          sslpolicyBindingArray[index].labeltype = resources[index].labeltype;
          sslpolicyBindingArray[index].labelname = resources[index].labelname;
        }
        baseResponses = base_resource.update_bulk_request(client, (base_resource[]) sslpolicyBindingArray);
      }
      return baseResponses;
    }

    public static base_response delete(
      nitro_service client,
      sslglobal_sslpolicy_binding resource)
    {
      return new sslglobal_sslpolicy_binding()
      {
        policyname = resource.policyname,
        type = resource.type,
        priority = resource.priority
      }.delete_resource(client);
    }

    public static base_responses delete(
      nitro_service client,
      sslglobal_sslpolicy_binding[] resources)
    {
      base_responses baseResponses = (base_responses) null;
      if (resources != null && resources.Length > 0)
      {
        sslglobal_sslpolicy_binding[] sslpolicyBindingArray = new sslglobal_sslpolicy_binding[resources.Length];
        for (int index = 0; index < resources.Length; ++index)
        {
          sslpolicyBindingArray[index] = new sslglobal_sslpolicy_binding();
          sslpolicyBindingArray[index].policyname = resources[index].policyname;
          sslpolicyBindingArray[index].type = resources[index].type;
          sslpolicyBindingArray[index].priority = resources[index].priority;
        }
        baseResponses = base_resource.delete_bulk_request(client, (base_resource[]) sslpolicyBindingArray);
      }
      return baseResponses;
    }

    public static sslglobal_sslpolicy_binding[] get(nitro_service service) => (sslglobal_sslpolicy_binding[]) new sslglobal_sslpolicy_binding().get_resources(service, (options) null);

    public static sslglobal_sslpolicy_binding[] get_filtered(
      nitro_service service,
      string filter)
    {
      sslglobal_sslpolicy_binding sslpolicyBinding = new sslglobal_sslpolicy_binding();
      options option = new options();
      option.set_filter(filter);
      return (sslglobal_sslpolicy_binding[]) sslpolicyBinding.getfiltered(service, option);
    }

    public static sslglobal_sslpolicy_binding[] get_filtered(
      nitro_service service,
      filtervalue[] filter)
    {
      sslglobal_sslpolicy_binding sslpolicyBinding = new sslglobal_sslpolicy_binding();
      options option = new options();
      option.set_filter(filter);
      return (sslglobal_sslpolicy_binding[]) sslpolicyBinding.getfiltered(service, option);
    }

    public static uint count(nitro_service service)
    {
      sslglobal_sslpolicy_binding sslpolicyBinding = new sslglobal_sslpolicy_binding();
      options option = new options();
      option.set_count(true);
      sslglobal_sslpolicy_binding[] resources = (sslglobal_sslpolicy_binding[]) sslpolicyBinding.get_resources(service, option);
      return resources != null && resources.Length > 0 ? resources[0].__count.Value : 0U;
    }

    public static uint count_filtered(nitro_service service, string filter)
    {
      sslglobal_sslpolicy_binding sslpolicyBinding = new sslglobal_sslpolicy_binding();
      options option = new options();
      option.set_count(true);
      option.set_filter(filter);
      sslglobal_sslpolicy_binding[] sslpolicyBindingArray = (sslglobal_sslpolicy_binding[]) sslpolicyBinding.getfiltered(service, option);
      return sslpolicyBindingArray != null && sslpolicyBindingArray.Length > 0 ? sslpolicyBindingArray[0].__count.Value : 0U;
    }

    public static uint count_filtered(nitro_service service, filtervalue[] filter)
    {
      sslglobal_sslpolicy_binding sslpolicyBinding = new sslglobal_sslpolicy_binding();
      options option = new options();
      option.set_count(true);
      option.set_filter(filter);
      sslglobal_sslpolicy_binding[] sslpolicyBindingArray = (sslglobal_sslpolicy_binding[]) sslpolicyBinding.getfiltered(service, option);
      return sslpolicyBindingArray != null && sslpolicyBindingArray.Length > 0 ? sslpolicyBindingArray[0].__count.Value : 0U;
    }

    private class sslglobal_sslpolicy_binding_response : base_response
    {
      public sslglobal_sslpolicy_binding[] sslglobal_sslpolicy_binding = (sslglobal_sslpolicy_binding[]) null;
    }

    public static class globalbindtypeEnum
    {
      public const string SYSTEM_GLOBAL = "SYSTEM_GLOBAL";
      public const string VPN_GLOBAL = "VPN_GLOBAL";
      public const string RNAT_GLOBAL = "RNAT_GLOBAL";
    }

    public static class typeEnum
    {
      public const string CONTROL_OVERRIDE = "CONTROL_OVERRIDE";
      public const string CONTROL_DEFAULT = "CONTROL_DEFAULT";
      public const string DATA_OVERRIDE = "DATA_OVERRIDE";
      public const string DATA_DEFAULT = "DATA_DEFAULT";
    }

    public static class labeltypeEnum
    {
      public const string vserver = "vserver";
      public const string service = "service";
      public const string policylabel = "policylabel";
    }
  }
}
