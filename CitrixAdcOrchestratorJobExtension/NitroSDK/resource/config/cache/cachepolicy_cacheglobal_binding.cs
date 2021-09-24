// Decompiled with JetBrains decompiler
// Type: com.citrix.netscaler.nitro.resource.config.cache.cachepolicy_cacheglobal_binding
// Assembly: nitro, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 6CF5DDEF-E052-4F9D-953F-6644F8378A66


using com.citrix.netscaler.nitro.exception;
using com.citrix.netscaler.nitro.resource.Base;
using com.citrix.netscaler.nitro.service;
using com.citrix.netscaler.nitro.util;

namespace com.citrix.netscaler.nitro.resource.config.cache
{
  public class cachepolicy_cacheglobal_binding : base_resource
  {
    private string boundtoField = (string) null;
    private uint? priorityField = new uint?();
    private int? activepolicyField = new int?();
    private string gotopriorityexpressionField = (string) null;
    private string labeltypeField = (string) null;
    private string labelnameField = (string) null;
    private string policynameField = (string) null;
    private uint? __countField = new uint?();

    public uint? __count
    {
      get => this.__countField;
      set => this.__countField = value;
    }

    public string policyname
    {
      get => this.policynameField;
      set => this.policynameField = value;
    }

    public string boundto
    {
      get => this.boundtoField;
      set => this.boundtoField = value;
    }

    public uint? priority
    {
      get => this.priorityField;
      private set => this.priorityField = value;
    }

    public string gotopriorityexpression
    {
      get => this.gotopriorityexpressionField;
      private set => this.gotopriorityexpressionField = value;
    }

    public string labeltype
    {
      get => this.labeltypeField;
      private set => this.labeltypeField = value;
    }

    public int? activepolicy
    {
      get => this.activepolicyField;
      private set => this.activepolicyField = value;
    }

    public string labelname
    {
      get => this.labelnameField;
      private set => this.labelnameField = value;
    }

    internal override base_resource[] get_nitro_response(
      nitro_service service,
      string response)
    {
      cachepolicy_cacheglobal_binding.cachepolicy_cacheglobal_binding_response cacheglobalBindingResponse = new cachepolicy_cacheglobal_binding.cachepolicy_cacheglobal_binding_response();
      cachepolicy_cacheglobal_binding.cachepolicy_cacheglobal_binding_response resource = (cachepolicy_cacheglobal_binding.cachepolicy_cacheglobal_binding_response) service.get_payload_formatter().string_to_resource(cacheglobalBindingResponse.GetType(), response);
      if (resource.errorcode != 0)
      {
        if (resource.errorcode == 444)
          service.clear_session();
        if (resource.severity == null)
          throw new nitro_exception(resource.message, resource.errorcode);
        if (resource.severity.Equals("ERROR"))
          throw new nitro_exception(resource.message, resource.errorcode);
      }
      return (base_resource[]) resource.cachepolicy_cacheglobal_binding;
    }

    internal override string get_object_name() => this.policyname;

    public static cachepolicy_cacheglobal_binding[] get(
      nitro_service service,
      string policyname)
    {
      return (cachepolicy_cacheglobal_binding[]) new cachepolicy_cacheglobal_binding()
      {
        policyname = policyname
      }.get_resources(service, (options) null);
    }

    public static cachepolicy_cacheglobal_binding[] get_filtered(
      nitro_service service,
      string policyname,
      string filter)
    {
      cachepolicy_cacheglobal_binding cacheglobalBinding = new cachepolicy_cacheglobal_binding();
      cacheglobalBinding.policyname = policyname;
      options option = new options();
      option.set_filter(filter);
      return (cachepolicy_cacheglobal_binding[]) cacheglobalBinding.getfiltered(service, option);
    }

    public static cachepolicy_cacheglobal_binding[] get_filtered(
      nitro_service service,
      string policyname,
      filtervalue[] filter)
    {
      cachepolicy_cacheglobal_binding cacheglobalBinding = new cachepolicy_cacheglobal_binding();
      cacheglobalBinding.policyname = policyname;
      options option = new options();
      option.set_filter(filter);
      return (cachepolicy_cacheglobal_binding[]) cacheglobalBinding.getfiltered(service, option);
    }

    public static uint count(nitro_service service, string policyname)
    {
      cachepolicy_cacheglobal_binding cacheglobalBinding = new cachepolicy_cacheglobal_binding();
      cacheglobalBinding.policyname = policyname;
      options option = new options();
      option.set_count(true);
      cachepolicy_cacheglobal_binding[] resources = (cachepolicy_cacheglobal_binding[]) cacheglobalBinding.get_resources(service, option);
      return resources != null && resources.Length > 0 ? resources[0].__count.Value : 0U;
    }

    public static uint count_filtered(nitro_service service, string policyname, string filter)
    {
      cachepolicy_cacheglobal_binding cacheglobalBinding = new cachepolicy_cacheglobal_binding();
      cacheglobalBinding.policyname = policyname;
      options option = new options();
      option.set_count(true);
      option.set_filter(filter);
      cachepolicy_cacheglobal_binding[] cacheglobalBindingArray = (cachepolicy_cacheglobal_binding[]) cacheglobalBinding.getfiltered(service, option);
      return cacheglobalBindingArray != null && cacheglobalBindingArray.Length > 0 ? cacheglobalBindingArray[0].__count.Value : 0U;
    }

    public static uint count_filtered(
      nitro_service service,
      string policyname,
      filtervalue[] filter)
    {
      cachepolicy_cacheglobal_binding cacheglobalBinding = new cachepolicy_cacheglobal_binding();
      cacheglobalBinding.policyname = policyname;
      options option = new options();
      option.set_count(true);
      option.set_filter(filter);
      cachepolicy_cacheglobal_binding[] cacheglobalBindingArray = (cachepolicy_cacheglobal_binding[]) cacheglobalBinding.getfiltered(service, option);
      return cacheglobalBindingArray != null && cacheglobalBindingArray.Length > 0 ? cacheglobalBindingArray[0].__count.Value : 0U;
    }

    private class cachepolicy_cacheglobal_binding_response : base_response
    {
      public cachepolicy_cacheglobal_binding[] cachepolicy_cacheglobal_binding = (cachepolicy_cacheglobal_binding[]) null;
    }

    public static class labeltypeEnum
    {
      public const string reqvserver = "reqvserver";
      public const string resvserver = "resvserver";
      public const string policylabel = "policylabel";
    }
  }
}
