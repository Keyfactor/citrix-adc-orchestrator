﻿// Decompiled with JetBrains decompiler
// Type: com.citrix.netscaler.nitro.resource.config.transform.transformpolicy_transformglobal_binding
// Assembly: nitro, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 6CF5DDEF-E052-4F9D-953F-6644F8378A66


using com.citrix.netscaler.nitro.exception;
using com.citrix.netscaler.nitro.resource.Base;
using com.citrix.netscaler.nitro.service;
using com.citrix.netscaler.nitro.util;

namespace com.citrix.netscaler.nitro.resource.config.transform
{
  public class transformpolicy_transformglobal_binding : base_resource
  {
    private string boundtoField = (string) null;
    private uint? priorityField = new uint?();
    private int? activepolicyField = new int?();
    private string gotopriorityexpressionField = (string) null;
    private string labeltypeField = (string) null;
    private string labelnameField = (string) null;
    private string nameField = (string) null;
    private uint? __countField = new uint?();

    public uint? __count
    {
      get => this.__countField;
      set => this.__countField = value;
    }

    public string name
    {
      get => this.nameField;
      set => this.nameField = value;
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
      transformpolicy_transformglobal_binding.transformpolicy_transformglobal_binding_response transformglobalBindingResponse = new transformpolicy_transformglobal_binding.transformpolicy_transformglobal_binding_response();
      transformpolicy_transformglobal_binding.transformpolicy_transformglobal_binding_response resource = (transformpolicy_transformglobal_binding.transformpolicy_transformglobal_binding_response) service.get_payload_formatter().string_to_resource(transformglobalBindingResponse.GetType(), response);
      if (resource.errorcode != 0)
      {
        if (resource.errorcode == 444)
          service.clear_session();
        if (resource.severity == null)
          throw new nitro_exception(resource.message, resource.errorcode);
        if (resource.severity.Equals("ERROR"))
          throw new nitro_exception(resource.message, resource.errorcode);
      }
      return (base_resource[]) resource.transformpolicy_transformglobal_binding;
    }

    internal override string get_object_name() => this.name;

    public static transformpolicy_transformglobal_binding[] get(
      nitro_service service,
      string name)
    {
      return (transformpolicy_transformglobal_binding[]) new transformpolicy_transformglobal_binding()
      {
        name = name
      }.get_resources(service, (options) null);
    }

    public static transformpolicy_transformglobal_binding[] get_filtered(
      nitro_service service,
      string name,
      string filter)
    {
      transformpolicy_transformglobal_binding transformglobalBinding = new transformpolicy_transformglobal_binding();
      transformglobalBinding.name = name;
      options option = new options();
      option.set_filter(filter);
      return (transformpolicy_transformglobal_binding[]) transformglobalBinding.getfiltered(service, option);
    }

    public static transformpolicy_transformglobal_binding[] get_filtered(
      nitro_service service,
      string name,
      filtervalue[] filter)
    {
      transformpolicy_transformglobal_binding transformglobalBinding = new transformpolicy_transformglobal_binding();
      transformglobalBinding.name = name;
      options option = new options();
      option.set_filter(filter);
      return (transformpolicy_transformglobal_binding[]) transformglobalBinding.getfiltered(service, option);
    }

    public static uint count(nitro_service service, string name)
    {
      transformpolicy_transformglobal_binding transformglobalBinding = new transformpolicy_transformglobal_binding();
      transformglobalBinding.name = name;
      options option = new options();
      option.set_count(true);
      transformpolicy_transformglobal_binding[] resources = (transformpolicy_transformglobal_binding[]) transformglobalBinding.get_resources(service, option);
      return resources != null && resources.Length > 0 ? resources[0].__count.Value : 0U;
    }

    public static uint count_filtered(nitro_service service, string name, string filter)
    {
      transformpolicy_transformglobal_binding transformglobalBinding = new transformpolicy_transformglobal_binding();
      transformglobalBinding.name = name;
      options option = new options();
      option.set_count(true);
      option.set_filter(filter);
      transformpolicy_transformglobal_binding[] transformglobalBindingArray = (transformpolicy_transformglobal_binding[]) transformglobalBinding.getfiltered(service, option);
      return transformglobalBindingArray != null && transformglobalBindingArray.Length > 0 ? transformglobalBindingArray[0].__count.Value : 0U;
    }

    public static uint count_filtered(nitro_service service, string name, filtervalue[] filter)
    {
      transformpolicy_transformglobal_binding transformglobalBinding = new transformpolicy_transformglobal_binding();
      transformglobalBinding.name = name;
      options option = new options();
      option.set_count(true);
      option.set_filter(filter);
      transformpolicy_transformglobal_binding[] transformglobalBindingArray = (transformpolicy_transformglobal_binding[]) transformglobalBinding.getfiltered(service, option);
      return transformglobalBindingArray != null && transformglobalBindingArray.Length > 0 ? transformglobalBindingArray[0].__count.Value : 0U;
    }

    private class transformpolicy_transformglobal_binding_response : base_response
    {
      public transformpolicy_transformglobal_binding[] transformpolicy_transformglobal_binding = (transformpolicy_transformglobal_binding[]) null;
    }

    public static class labeltypeEnum
    {
      public const string reqvserver = "reqvserver";
      public const string policylabel = "policylabel";
    }
  }
}
