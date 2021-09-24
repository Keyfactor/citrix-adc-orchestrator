﻿// Decompiled with JetBrains decompiler
// Type: com.citrix.netscaler.nitro.resource.config.authentication.authenticationwebauthpolicy_authenticationvserver_binding
// Assembly: nitro, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 6CF5DDEF-E052-4F9D-953F-6644F8378A66


using com.citrix.netscaler.nitro.exception;
using com.citrix.netscaler.nitro.resource.Base;
using com.citrix.netscaler.nitro.service;
using com.citrix.netscaler.nitro.util;

namespace com.citrix.netscaler.nitro.resource.config.authentication
{
  public class authenticationwebauthpolicy_authenticationvserver_binding : base_resource
  {
    private string boundtoField = (string) null;
    private uint? priorityField = new uint?();
    private uint? activepolicyField = new uint?();
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

    public uint? activepolicy
    {
      get => this.activepolicyField;
      private set => this.activepolicyField = value;
    }

    internal override base_resource[] get_nitro_response(
      nitro_service service,
      string response)
    {
      authenticationwebauthpolicy_authenticationvserver_binding.authenticationwebauthpolicy_authenticationvserver_binding_response authenticationvserverBindingResponse = new authenticationwebauthpolicy_authenticationvserver_binding.authenticationwebauthpolicy_authenticationvserver_binding_response();
      authenticationwebauthpolicy_authenticationvserver_binding.authenticationwebauthpolicy_authenticationvserver_binding_response resource = (authenticationwebauthpolicy_authenticationvserver_binding.authenticationwebauthpolicy_authenticationvserver_binding_response) service.get_payload_formatter().string_to_resource(authenticationvserverBindingResponse.GetType(), response);
      if (resource.errorcode != 0)
      {
        if (resource.errorcode == 444)
          service.clear_session();
        if (resource.severity == null)
          throw new nitro_exception(resource.message, resource.errorcode);
        if (resource.severity.Equals("ERROR"))
          throw new nitro_exception(resource.message, resource.errorcode);
      }
      return (base_resource[]) resource.authenticationwebauthpolicy_authenticationvserver_binding;
    }

    internal override string get_object_name() => this.name;

    public static authenticationwebauthpolicy_authenticationvserver_binding[] get(
      nitro_service service,
      string name)
    {
      return (authenticationwebauthpolicy_authenticationvserver_binding[]) new authenticationwebauthpolicy_authenticationvserver_binding()
      {
        name = name
      }.get_resources(service, (options) null);
    }

    public static authenticationwebauthpolicy_authenticationvserver_binding[] get_filtered(
      nitro_service service,
      string name,
      string filter)
    {
      authenticationwebauthpolicy_authenticationvserver_binding authenticationvserverBinding = new authenticationwebauthpolicy_authenticationvserver_binding();
      authenticationvserverBinding.name = name;
      options option = new options();
      option.set_filter(filter);
      return (authenticationwebauthpolicy_authenticationvserver_binding[]) authenticationvserverBinding.getfiltered(service, option);
    }

    public static authenticationwebauthpolicy_authenticationvserver_binding[] get_filtered(
      nitro_service service,
      string name,
      filtervalue[] filter)
    {
      authenticationwebauthpolicy_authenticationvserver_binding authenticationvserverBinding = new authenticationwebauthpolicy_authenticationvserver_binding();
      authenticationvserverBinding.name = name;
      options option = new options();
      option.set_filter(filter);
      return (authenticationwebauthpolicy_authenticationvserver_binding[]) authenticationvserverBinding.getfiltered(service, option);
    }

    public static uint count(nitro_service service, string name)
    {
      authenticationwebauthpolicy_authenticationvserver_binding authenticationvserverBinding = new authenticationwebauthpolicy_authenticationvserver_binding();
      authenticationvserverBinding.name = name;
      options option = new options();
      option.set_count(true);
      authenticationwebauthpolicy_authenticationvserver_binding[] resources = (authenticationwebauthpolicy_authenticationvserver_binding[]) authenticationvserverBinding.get_resources(service, option);
      return resources != null && resources.Length > 0 ? resources[0].__count.Value : 0U;
    }

    public static uint count_filtered(nitro_service service, string name, string filter)
    {
      authenticationwebauthpolicy_authenticationvserver_binding authenticationvserverBinding = new authenticationwebauthpolicy_authenticationvserver_binding();
      authenticationvserverBinding.name = name;
      options option = new options();
      option.set_count(true);
      option.set_filter(filter);
      authenticationwebauthpolicy_authenticationvserver_binding[] authenticationvserverBindingArray = (authenticationwebauthpolicy_authenticationvserver_binding[]) authenticationvserverBinding.getfiltered(service, option);
      return authenticationvserverBindingArray != null && authenticationvserverBindingArray.Length > 0 ? authenticationvserverBindingArray[0].__count.Value : 0U;
    }

    public static uint count_filtered(nitro_service service, string name, filtervalue[] filter)
    {
      authenticationwebauthpolicy_authenticationvserver_binding authenticationvserverBinding = new authenticationwebauthpolicy_authenticationvserver_binding();
      authenticationvserverBinding.name = name;
      options option = new options();
      option.set_count(true);
      option.set_filter(filter);
      authenticationwebauthpolicy_authenticationvserver_binding[] authenticationvserverBindingArray = (authenticationwebauthpolicy_authenticationvserver_binding[]) authenticationvserverBinding.getfiltered(service, option);
      return authenticationvserverBindingArray != null && authenticationvserverBindingArray.Length > 0 ? authenticationvserverBindingArray[0].__count.Value : 0U;
    }

    private class authenticationwebauthpolicy_authenticationvserver_binding_response : base_response
    {
      public authenticationwebauthpolicy_authenticationvserver_binding[] authenticationwebauthpolicy_authenticationvserver_binding = (authenticationwebauthpolicy_authenticationvserver_binding[]) null;
    }
  }
}
