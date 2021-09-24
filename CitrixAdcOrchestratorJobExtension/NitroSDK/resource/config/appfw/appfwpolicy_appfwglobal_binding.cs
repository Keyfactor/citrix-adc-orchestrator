﻿// Decompiled with JetBrains decompiler
// Type: com.citrix.netscaler.nitro.resource.config.appfw.appfwpolicy_appfwglobal_binding
// Assembly: nitro, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 6CF5DDEF-E052-4F9D-953F-6644F8378A66


using com.citrix.netscaler.nitro.exception;
using com.citrix.netscaler.nitro.resource.Base;
using com.citrix.netscaler.nitro.service;
using com.citrix.netscaler.nitro.util;

namespace com.citrix.netscaler.nitro.resource.config.appfw
{
  public class appfwpolicy_appfwglobal_binding : base_resource
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
      appfwpolicy_appfwglobal_binding.appfwpolicy_appfwglobal_binding_response appfwglobalBindingResponse = new appfwpolicy_appfwglobal_binding.appfwpolicy_appfwglobal_binding_response();
      appfwpolicy_appfwglobal_binding.appfwpolicy_appfwglobal_binding_response resource = (appfwpolicy_appfwglobal_binding.appfwpolicy_appfwglobal_binding_response) service.get_payload_formatter().string_to_resource(appfwglobalBindingResponse.GetType(), response);
      if (resource.errorcode != 0)
      {
        if (resource.errorcode == 444)
          service.clear_session();
        if (resource.severity == null)
          throw new nitro_exception(resource.message, resource.errorcode);
        if (resource.severity.Equals("ERROR"))
          throw new nitro_exception(resource.message, resource.errorcode);
      }
      return (base_resource[]) resource.appfwpolicy_appfwglobal_binding;
    }

    internal override string get_object_name() => this.name;

    public static appfwpolicy_appfwglobal_binding[] get(
      nitro_service service,
      string name)
    {
      return (appfwpolicy_appfwglobal_binding[]) new appfwpolicy_appfwglobal_binding()
      {
        name = name
      }.get_resources(service, (options) null);
    }

    public static appfwpolicy_appfwglobal_binding[] get_filtered(
      nitro_service service,
      string name,
      string filter)
    {
      appfwpolicy_appfwglobal_binding appfwglobalBinding = new appfwpolicy_appfwglobal_binding();
      appfwglobalBinding.name = name;
      options option = new options();
      option.set_filter(filter);
      return (appfwpolicy_appfwglobal_binding[]) appfwglobalBinding.getfiltered(service, option);
    }

    public static appfwpolicy_appfwglobal_binding[] get_filtered(
      nitro_service service,
      string name,
      filtervalue[] filter)
    {
      appfwpolicy_appfwglobal_binding appfwglobalBinding = new appfwpolicy_appfwglobal_binding();
      appfwglobalBinding.name = name;
      options option = new options();
      option.set_filter(filter);
      return (appfwpolicy_appfwglobal_binding[]) appfwglobalBinding.getfiltered(service, option);
    }

    public static uint count(nitro_service service, string name)
    {
      appfwpolicy_appfwglobal_binding appfwglobalBinding = new appfwpolicy_appfwglobal_binding();
      appfwglobalBinding.name = name;
      options option = new options();
      option.set_count(true);
      appfwpolicy_appfwglobal_binding[] resources = (appfwpolicy_appfwglobal_binding[]) appfwglobalBinding.get_resources(service, option);
      return resources != null && resources.Length > 0 ? resources[0].__count.Value : 0U;
    }

    public static uint count_filtered(nitro_service service, string name, string filter)
    {
      appfwpolicy_appfwglobal_binding appfwglobalBinding = new appfwpolicy_appfwglobal_binding();
      appfwglobalBinding.name = name;
      options option = new options();
      option.set_count(true);
      option.set_filter(filter);
      appfwpolicy_appfwglobal_binding[] appfwglobalBindingArray = (appfwpolicy_appfwglobal_binding[]) appfwglobalBinding.getfiltered(service, option);
      return appfwglobalBindingArray != null && appfwglobalBindingArray.Length > 0 ? appfwglobalBindingArray[0].__count.Value : 0U;
    }

    public static uint count_filtered(nitro_service service, string name, filtervalue[] filter)
    {
      appfwpolicy_appfwglobal_binding appfwglobalBinding = new appfwpolicy_appfwglobal_binding();
      appfwglobalBinding.name = name;
      options option = new options();
      option.set_count(true);
      option.set_filter(filter);
      appfwpolicy_appfwglobal_binding[] appfwglobalBindingArray = (appfwpolicy_appfwglobal_binding[]) appfwglobalBinding.getfiltered(service, option);
      return appfwglobalBindingArray != null && appfwglobalBindingArray.Length > 0 ? appfwglobalBindingArray[0].__count.Value : 0U;
    }

    private class appfwpolicy_appfwglobal_binding_response : base_response
    {
      public appfwpolicy_appfwglobal_binding[] appfwpolicy_appfwglobal_binding = (appfwpolicy_appfwglobal_binding[]) null;
    }

    public static class labeltypeEnum
    {
      public const string reqvserver = "reqvserver";
      public const string resvserver = "resvserver";
      public const string policylabel = "policylabel";
    }
  }
}
