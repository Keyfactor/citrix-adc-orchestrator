﻿// Decompiled with JetBrains decompiler
// Type: com.citrix.netscaler.nitro.resource.config.authentication.authenticationvserver_authenticationlocalpolicy_binding
// Assembly: nitro, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 6CF5DDEF-E052-4F9D-953F-6644F8378A66


using com.citrix.netscaler.nitro.exception;
using com.citrix.netscaler.nitro.resource.Base;
using com.citrix.netscaler.nitro.service;
using com.citrix.netscaler.nitro.util;

namespace com.citrix.netscaler.nitro.resource.config.authentication
{
  public class authenticationvserver_authenticationlocalpolicy_binding : base_resource
  {
    private string policyField = (string) null;
    private uint? priorityField = new uint?();
    private uint? acttypeField = new uint?();
    private bool? secondaryField = new bool?();
    private string nameField = (string) null;
    private bool? groupextractionField = new bool?();
    private string nextfactorField = (string) null;
    private string gotopriorityexpressionField = (string) null;
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

    public string name
    {
      get => this.nameField;
      set => this.nameField = value;
    }

    public string nextfactor
    {
      get => this.nextfactorField;
      set => this.nextfactorField = value;
    }

    public string gotopriorityexpression
    {
      get => this.gotopriorityexpressionField;
      set => this.gotopriorityexpressionField = value;
    }

    public bool? secondary
    {
      get => this.secondaryField;
      set => this.secondaryField = value;
    }

    public string policy
    {
      get => this.policyField;
      set => this.policyField = value;
    }

    public bool? groupextraction
    {
      get => this.groupextractionField;
      set => this.groupextractionField = value;
    }

    public uint? acttype
    {
      get => this.acttypeField;
      private set => this.acttypeField = value;
    }

    internal override base_resource[] get_nitro_response(
      nitro_service service,
      string response)
    {
      authenticationvserver_authenticationlocalpolicy_binding.authenticationvserver_authenticationlocalpolicy_binding_response authenticationlocalpolicyBindingResponse = new authenticationvserver_authenticationlocalpolicy_binding.authenticationvserver_authenticationlocalpolicy_binding_response();
      authenticationvserver_authenticationlocalpolicy_binding.authenticationvserver_authenticationlocalpolicy_binding_response resource = (authenticationvserver_authenticationlocalpolicy_binding.authenticationvserver_authenticationlocalpolicy_binding_response) service.get_payload_formatter().string_to_resource(authenticationlocalpolicyBindingResponse.GetType(), response);
      if (resource.errorcode != 0)
      {
        if (resource.errorcode == 444)
          service.clear_session();
        if (resource.severity == null)
          throw new nitro_exception(resource.message, resource.errorcode);
        if (resource.severity.Equals("ERROR"))
          throw new nitro_exception(resource.message, resource.errorcode);
      }
      return (base_resource[]) resource.authenticationvserver_authenticationlocalpolicy_binding;
    }

    internal override string get_object_name() => this.name;

    public static base_response add(
      nitro_service client,
      authenticationvserver_authenticationlocalpolicy_binding resource)
    {
      return new authenticationvserver_authenticationlocalpolicy_binding()
      {
        name = resource.name,
        policy = resource.policy,
        priority = resource.priority,
        secondary = resource.secondary,
        groupextraction = resource.groupextraction,
        nextfactor = resource.nextfactor,
        gotopriorityexpression = resource.gotopriorityexpression
      }.update_resource(client);
    }

    public static base_responses add(
      nitro_service client,
      authenticationvserver_authenticationlocalpolicy_binding[] resources)
    {
      base_responses baseResponses = (base_responses) null;
      if (resources != null && resources.Length > 0)
      {
        authenticationvserver_authenticationlocalpolicy_binding[] authenticationlocalpolicyBindingArray = new authenticationvserver_authenticationlocalpolicy_binding[resources.Length];
        for (int index = 0; index < resources.Length; ++index)
        {
          authenticationlocalpolicyBindingArray[index] = new authenticationvserver_authenticationlocalpolicy_binding();
          authenticationlocalpolicyBindingArray[index].name = resources[index].name;
          authenticationlocalpolicyBindingArray[index].policy = resources[index].policy;
          authenticationlocalpolicyBindingArray[index].priority = resources[index].priority;
          authenticationlocalpolicyBindingArray[index].secondary = resources[index].secondary;
          authenticationlocalpolicyBindingArray[index].groupextraction = resources[index].groupextraction;
          authenticationlocalpolicyBindingArray[index].nextfactor = resources[index].nextfactor;
          authenticationlocalpolicyBindingArray[index].gotopriorityexpression = resources[index].gotopriorityexpression;
        }
        baseResponses = base_resource.update_bulk_request(client, (base_resource[]) authenticationlocalpolicyBindingArray);
      }
      return baseResponses;
    }

    public static base_response delete(
      nitro_service client,
      authenticationvserver_authenticationlocalpolicy_binding resource)
    {
      return new authenticationvserver_authenticationlocalpolicy_binding()
      {
        name = resource.name,
        policy = resource.policy,
        secondary = resource.secondary,
        groupextraction = resource.groupextraction
      }.delete_resource(client);
    }

    public static base_responses delete(
      nitro_service client,
      authenticationvserver_authenticationlocalpolicy_binding[] resources)
    {
      base_responses baseResponses = (base_responses) null;
      if (resources != null && resources.Length > 0)
      {
        authenticationvserver_authenticationlocalpolicy_binding[] authenticationlocalpolicyBindingArray = new authenticationvserver_authenticationlocalpolicy_binding[resources.Length];
        for (int index = 0; index < resources.Length; ++index)
        {
          authenticationlocalpolicyBindingArray[index] = new authenticationvserver_authenticationlocalpolicy_binding();
          authenticationlocalpolicyBindingArray[index].name = resources[index].name;
          authenticationlocalpolicyBindingArray[index].policy = resources[index].policy;
          authenticationlocalpolicyBindingArray[index].secondary = resources[index].secondary;
          authenticationlocalpolicyBindingArray[index].groupextraction = resources[index].groupextraction;
        }
        baseResponses = base_resource.delete_bulk_request(client, (base_resource[]) authenticationlocalpolicyBindingArray);
      }
      return baseResponses;
    }

    public static authenticationvserver_authenticationlocalpolicy_binding[] get(
      nitro_service service,
      string name)
    {
      return (authenticationvserver_authenticationlocalpolicy_binding[]) new authenticationvserver_authenticationlocalpolicy_binding()
      {
        name = name
      }.get_resources(service, (options) null);
    }

    public static authenticationvserver_authenticationlocalpolicy_binding[] get_filtered(
      nitro_service service,
      string name,
      string filter)
    {
      authenticationvserver_authenticationlocalpolicy_binding authenticationlocalpolicyBinding = new authenticationvserver_authenticationlocalpolicy_binding();
      authenticationlocalpolicyBinding.name = name;
      options option = new options();
      option.set_filter(filter);
      return (authenticationvserver_authenticationlocalpolicy_binding[]) authenticationlocalpolicyBinding.getfiltered(service, option);
    }

    public static authenticationvserver_authenticationlocalpolicy_binding[] get_filtered(
      nitro_service service,
      string name,
      filtervalue[] filter)
    {
      authenticationvserver_authenticationlocalpolicy_binding authenticationlocalpolicyBinding = new authenticationvserver_authenticationlocalpolicy_binding();
      authenticationlocalpolicyBinding.name = name;
      options option = new options();
      option.set_filter(filter);
      return (authenticationvserver_authenticationlocalpolicy_binding[]) authenticationlocalpolicyBinding.getfiltered(service, option);
    }

    public static uint count(nitro_service service, string name)
    {
      authenticationvserver_authenticationlocalpolicy_binding authenticationlocalpolicyBinding = new authenticationvserver_authenticationlocalpolicy_binding();
      authenticationlocalpolicyBinding.name = name;
      options option = new options();
      option.set_count(true);
      authenticationvserver_authenticationlocalpolicy_binding[] resources = (authenticationvserver_authenticationlocalpolicy_binding[]) authenticationlocalpolicyBinding.get_resources(service, option);
      return resources != null && resources.Length > 0 ? resources[0].__count.Value : 0U;
    }

    public static uint count_filtered(nitro_service service, string name, string filter)
    {
      authenticationvserver_authenticationlocalpolicy_binding authenticationlocalpolicyBinding = new authenticationvserver_authenticationlocalpolicy_binding();
      authenticationlocalpolicyBinding.name = name;
      options option = new options();
      option.set_count(true);
      option.set_filter(filter);
      authenticationvserver_authenticationlocalpolicy_binding[] authenticationlocalpolicyBindingArray = (authenticationvserver_authenticationlocalpolicy_binding[]) authenticationlocalpolicyBinding.getfiltered(service, option);
      return authenticationlocalpolicyBindingArray != null && authenticationlocalpolicyBindingArray.Length > 0 ? authenticationlocalpolicyBindingArray[0].__count.Value : 0U;
    }

    public static uint count_filtered(nitro_service service, string name, filtervalue[] filter)
    {
      authenticationvserver_authenticationlocalpolicy_binding authenticationlocalpolicyBinding = new authenticationvserver_authenticationlocalpolicy_binding();
      authenticationlocalpolicyBinding.name = name;
      options option = new options();
      option.set_count(true);
      option.set_filter(filter);
      authenticationvserver_authenticationlocalpolicy_binding[] authenticationlocalpolicyBindingArray = (authenticationvserver_authenticationlocalpolicy_binding[]) authenticationlocalpolicyBinding.getfiltered(service, option);
      return authenticationlocalpolicyBindingArray != null && authenticationlocalpolicyBindingArray.Length > 0 ? authenticationlocalpolicyBindingArray[0].__count.Value : 0U;
    }

    private class authenticationvserver_authenticationlocalpolicy_binding_response : base_response
    {
      public authenticationvserver_authenticationlocalpolicy_binding[] authenticationvserver_authenticationlocalpolicy_binding = (authenticationvserver_authenticationlocalpolicy_binding[]) null;
    }
  }
}
