﻿// Decompiled with JetBrains decompiler
// Type: com.citrix.netscaler.nitro.resource.config.ssl.sslpolicy_sslglobal_binding
// Assembly: nitro, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 6CF5DDEF-E052-4F9D-953F-6644F8378A66


using com.citrix.netscaler.nitro.exception;
using com.citrix.netscaler.nitro.resource.Base;
using com.citrix.netscaler.nitro.service;
using com.citrix.netscaler.nitro.util;

namespace com.citrix.netscaler.nitro.resource.config.ssl
{
  public class sslpolicy_sslglobal_binding : base_resource
  {
    private string boundtoField = (string) null;
    private uint? priorityField = new uint?();
    private uint? activepolicyField = new uint?();
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

    public uint? activepolicy
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
      sslpolicy_sslglobal_binding.sslpolicy_sslglobal_binding_response sslglobalBindingResponse = new sslpolicy_sslglobal_binding.sslpolicy_sslglobal_binding_response();
      sslpolicy_sslglobal_binding.sslpolicy_sslglobal_binding_response resource = (sslpolicy_sslglobal_binding.sslpolicy_sslglobal_binding_response) service.get_payload_formatter().string_to_resource(sslglobalBindingResponse.GetType(), response);
      if (resource.errorcode != 0)
      {
        if (resource.errorcode == 444)
          service.clear_session();
        if (resource.severity == null)
          throw new nitro_exception(resource.message, resource.errorcode);
        if (resource.severity.Equals("ERROR"))
          throw new nitro_exception(resource.message, resource.errorcode);
      }
      return (base_resource[]) resource.sslpolicy_sslglobal_binding;
    }

    internal override string get_object_name() => this.name;

    public static sslpolicy_sslglobal_binding[] get(
      nitro_service service,
      string name)
    {
      return (sslpolicy_sslglobal_binding[]) new sslpolicy_sslglobal_binding()
      {
        name = name
      }.get_resources(service, (options) null);
    }

    public static sslpolicy_sslglobal_binding[] get_filtered(
      nitro_service service,
      string name,
      string filter)
    {
      sslpolicy_sslglobal_binding sslglobalBinding = new sslpolicy_sslglobal_binding();
      sslglobalBinding.name = name;
      options option = new options();
      option.set_filter(filter);
      return (sslpolicy_sslglobal_binding[]) sslglobalBinding.getfiltered(service, option);
    }

    public static sslpolicy_sslglobal_binding[] get_filtered(
      nitro_service service,
      string name,
      filtervalue[] filter)
    {
      sslpolicy_sslglobal_binding sslglobalBinding = new sslpolicy_sslglobal_binding();
      sslglobalBinding.name = name;
      options option = new options();
      option.set_filter(filter);
      return (sslpolicy_sslglobal_binding[]) sslglobalBinding.getfiltered(service, option);
    }

    public static uint count(nitro_service service, string name)
    {
      sslpolicy_sslglobal_binding sslglobalBinding = new sslpolicy_sslglobal_binding();
      sslglobalBinding.name = name;
      options option = new options();
      option.set_count(true);
      sslpolicy_sslglobal_binding[] resources = (sslpolicy_sslglobal_binding[]) sslglobalBinding.get_resources(service, option);
      return resources != null && resources.Length > 0 ? resources[0].__count.Value : 0U;
    }

    public static uint count_filtered(nitro_service service, string name, string filter)
    {
      sslpolicy_sslglobal_binding sslglobalBinding = new sslpolicy_sslglobal_binding();
      sslglobalBinding.name = name;
      options option = new options();
      option.set_count(true);
      option.set_filter(filter);
      sslpolicy_sslglobal_binding[] sslglobalBindingArray = (sslpolicy_sslglobal_binding[]) sslglobalBinding.getfiltered(service, option);
      return sslglobalBindingArray != null && sslglobalBindingArray.Length > 0 ? sslglobalBindingArray[0].__count.Value : 0U;
    }

    public static uint count_filtered(nitro_service service, string name, filtervalue[] filter)
    {
      sslpolicy_sslglobal_binding sslglobalBinding = new sslpolicy_sslglobal_binding();
      sslglobalBinding.name = name;
      options option = new options();
      option.set_count(true);
      option.set_filter(filter);
      sslpolicy_sslglobal_binding[] sslglobalBindingArray = (sslpolicy_sslglobal_binding[]) sslglobalBinding.getfiltered(service, option);
      return sslglobalBindingArray != null && sslglobalBindingArray.Length > 0 ? sslglobalBindingArray[0].__count.Value : 0U;
    }

    private class sslpolicy_sslglobal_binding_response : base_response
    {
      public sslpolicy_sslglobal_binding[] sslpolicy_sslglobal_binding = (sslpolicy_sslglobal_binding[]) null;
    }

    public static class labeltypeEnum
    {
      public const string vserver = "vserver";
      public const string service = "service";
      public const string policylabel = "policylabel";
    }
  }
}
