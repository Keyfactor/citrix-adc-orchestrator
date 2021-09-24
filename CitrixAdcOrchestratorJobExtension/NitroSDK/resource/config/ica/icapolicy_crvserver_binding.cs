﻿// Decompiled with JetBrains decompiler
// Type: com.citrix.netscaler.nitro.resource.config.ica.icapolicy_crvserver_binding
// Assembly: nitro, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 6CF5DDEF-E052-4F9D-953F-6644F8378A66


using com.citrix.netscaler.nitro.exception;
using com.citrix.netscaler.nitro.resource.Base;
using com.citrix.netscaler.nitro.service;
using com.citrix.netscaler.nitro.util;

namespace com.citrix.netscaler.nitro.resource.config.ica
{
  public class icapolicy_crvserver_binding : base_resource
  {
    private string boundtoField = (string) null;
    private uint? priorityField = new uint?();
    private int? activepolicyField = new int?();
    private string gotopriorityexpressionField = (string) null;
    private string nameField = (string) null;
    private uint? __countField = new uint?();

    public uint? __count
    {
      get => this.__countField;
      set => this.__countField = value;
    }

    public string boundto
    {
      get => this.boundtoField;
      set => this.boundtoField = value;
    }

    public string name
    {
      get => this.nameField;
      set => this.nameField = value;
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

    public int? activepolicy
    {
      get => this.activepolicyField;
      private set => this.activepolicyField = value;
    }

    internal override base_resource[] get_nitro_response(
      nitro_service service,
      string response)
    {
      icapolicy_crvserver_binding.icapolicy_crvserver_binding_response crvserverBindingResponse = new icapolicy_crvserver_binding.icapolicy_crvserver_binding_response();
      icapolicy_crvserver_binding.icapolicy_crvserver_binding_response resource = (icapolicy_crvserver_binding.icapolicy_crvserver_binding_response) service.get_payload_formatter().string_to_resource(crvserverBindingResponse.GetType(), response);
      if (resource.errorcode != 0)
      {
        if (resource.errorcode == 444)
          service.clear_session();
        if (resource.severity == null)
          throw new nitro_exception(resource.message, resource.errorcode);
        if (resource.severity.Equals("ERROR"))
          throw new nitro_exception(resource.message, resource.errorcode);
      }
      return (base_resource[]) resource.icapolicy_crvserver_binding;
    }

    internal override string get_object_name() => this.name;

    public static icapolicy_crvserver_binding[] get(
      nitro_service service,
      string name)
    {
      return (icapolicy_crvserver_binding[]) new icapolicy_crvserver_binding()
      {
        name = name
      }.get_resources(service, (options) null);
    }

    public static icapolicy_crvserver_binding[] get_filtered(
      nitro_service service,
      string name,
      string filter)
    {
      icapolicy_crvserver_binding crvserverBinding = new icapolicy_crvserver_binding();
      crvserverBinding.name = name;
      options option = new options();
      option.set_filter(filter);
      return (icapolicy_crvserver_binding[]) crvserverBinding.getfiltered(service, option);
    }

    public static icapolicy_crvserver_binding[] get_filtered(
      nitro_service service,
      string name,
      filtervalue[] filter)
    {
      icapolicy_crvserver_binding crvserverBinding = new icapolicy_crvserver_binding();
      crvserverBinding.name = name;
      options option = new options();
      option.set_filter(filter);
      return (icapolicy_crvserver_binding[]) crvserverBinding.getfiltered(service, option);
    }

    public static uint count(nitro_service service, string name)
    {
      icapolicy_crvserver_binding crvserverBinding = new icapolicy_crvserver_binding();
      crvserverBinding.name = name;
      options option = new options();
      option.set_count(true);
      icapolicy_crvserver_binding[] resources = (icapolicy_crvserver_binding[]) crvserverBinding.get_resources(service, option);
      return resources != null && resources.Length > 0 ? resources[0].__count.Value : 0U;
    }

    public static uint count_filtered(nitro_service service, string name, string filter)
    {
      icapolicy_crvserver_binding crvserverBinding = new icapolicy_crvserver_binding();
      crvserverBinding.name = name;
      options option = new options();
      option.set_count(true);
      option.set_filter(filter);
      icapolicy_crvserver_binding[] crvserverBindingArray = (icapolicy_crvserver_binding[]) crvserverBinding.getfiltered(service, option);
      return crvserverBindingArray != null && crvserverBindingArray.Length > 0 ? crvserverBindingArray[0].__count.Value : 0U;
    }

    public static uint count_filtered(nitro_service service, string name, filtervalue[] filter)
    {
      icapolicy_crvserver_binding crvserverBinding = new icapolicy_crvserver_binding();
      crvserverBinding.name = name;
      options option = new options();
      option.set_count(true);
      option.set_filter(filter);
      icapolicy_crvserver_binding[] crvserverBindingArray = (icapolicy_crvserver_binding[]) crvserverBinding.getfiltered(service, option);
      return crvserverBindingArray != null && crvserverBindingArray.Length > 0 ? crvserverBindingArray[0].__count.Value : 0U;
    }

    private class icapolicy_crvserver_binding_response : base_response
    {
      public icapolicy_crvserver_binding[] icapolicy_crvserver_binding = (icapolicy_crvserver_binding[]) null;
    }
  }
}
