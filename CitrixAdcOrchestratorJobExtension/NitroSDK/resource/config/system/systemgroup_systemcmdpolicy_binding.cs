﻿// Decompiled with JetBrains decompiler
// Type: com.citrix.netscaler.nitro.resource.config.system.systemgroup_systemcmdpolicy_binding
// Assembly: nitro, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 6CF5DDEF-E052-4F9D-953F-6644F8378A66


using com.citrix.netscaler.nitro.exception;
using com.citrix.netscaler.nitro.resource.Base;
using com.citrix.netscaler.nitro.service;
using com.citrix.netscaler.nitro.util;

namespace com.citrix.netscaler.nitro.resource.config.system
{
  public class systemgroup_systemcmdpolicy_binding : base_resource
  {
    private string policynameField = (string) null;
    private uint? priorityField = new uint?();
    private string groupnameField = (string) null;
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

    public string policyname
    {
      get => this.policynameField;
      set => this.policynameField = value;
    }

    public string groupname
    {
      get => this.groupnameField;
      set => this.groupnameField = value;
    }

    internal override base_resource[] get_nitro_response(
      nitro_service service,
      string response)
    {
      systemgroup_systemcmdpolicy_binding.systemgroup_systemcmdpolicy_binding_response systemcmdpolicyBindingResponse = new systemgroup_systemcmdpolicy_binding.systemgroup_systemcmdpolicy_binding_response();
      systemgroup_systemcmdpolicy_binding.systemgroup_systemcmdpolicy_binding_response resource = (systemgroup_systemcmdpolicy_binding.systemgroup_systemcmdpolicy_binding_response) service.get_payload_formatter().string_to_resource(systemcmdpolicyBindingResponse.GetType(), response);
      if (resource.errorcode != 0)
      {
        if (resource.errorcode == 444)
          service.clear_session();
        if (resource.severity == null)
          throw new nitro_exception(resource.message, resource.errorcode);
        if (resource.severity.Equals("ERROR"))
          throw new nitro_exception(resource.message, resource.errorcode);
      }
      return (base_resource[]) resource.systemgroup_systemcmdpolicy_binding;
    }

    internal override string get_object_name() => this.groupname;

    public static base_response add(
      nitro_service client,
      systemgroup_systemcmdpolicy_binding resource)
    {
      return new systemgroup_systemcmdpolicy_binding()
      {
        groupname = resource.groupname,
        policyname = resource.policyname,
        priority = resource.priority
      }.update_resource(client);
    }

    public static base_responses add(
      nitro_service client,
      systemgroup_systemcmdpolicy_binding[] resources)
    {
      base_responses baseResponses = (base_responses) null;
      if (resources != null && resources.Length > 0)
      {
        systemgroup_systemcmdpolicy_binding[] systemcmdpolicyBindingArray = new systemgroup_systemcmdpolicy_binding[resources.Length];
        for (int index = 0; index < resources.Length; ++index)
        {
          systemcmdpolicyBindingArray[index] = new systemgroup_systemcmdpolicy_binding();
          systemcmdpolicyBindingArray[index].groupname = resources[index].groupname;
          systemcmdpolicyBindingArray[index].policyname = resources[index].policyname;
          systemcmdpolicyBindingArray[index].priority = resources[index].priority;
        }
        baseResponses = base_resource.update_bulk_request(client, (base_resource[]) systemcmdpolicyBindingArray);
      }
      return baseResponses;
    }

    public static base_response delete(
      nitro_service client,
      systemgroup_systemcmdpolicy_binding resource)
    {
      return new systemgroup_systemcmdpolicy_binding()
      {
        groupname = resource.groupname,
        policyname = resource.policyname
      }.delete_resource(client);
    }

    public static base_responses delete(
      nitro_service client,
      systemgroup_systemcmdpolicy_binding[] resources)
    {
      base_responses baseResponses = (base_responses) null;
      if (resources != null && resources.Length > 0)
      {
        systemgroup_systemcmdpolicy_binding[] systemcmdpolicyBindingArray = new systemgroup_systemcmdpolicy_binding[resources.Length];
        for (int index = 0; index < resources.Length; ++index)
        {
          systemcmdpolicyBindingArray[index] = new systemgroup_systemcmdpolicy_binding();
          systemcmdpolicyBindingArray[index].groupname = resources[index].groupname;
          systemcmdpolicyBindingArray[index].policyname = resources[index].policyname;
        }
        baseResponses = base_resource.delete_bulk_request(client, (base_resource[]) systemcmdpolicyBindingArray);
      }
      return baseResponses;
    }

    public static systemgroup_systemcmdpolicy_binding[] get(
      nitro_service service,
      string groupname)
    {
      return (systemgroup_systemcmdpolicy_binding[]) new systemgroup_systemcmdpolicy_binding()
      {
        groupname = groupname
      }.get_resources(service, (options) null);
    }

    public static systemgroup_systemcmdpolicy_binding[] get_filtered(
      nitro_service service,
      string groupname,
      string filter)
    {
      systemgroup_systemcmdpolicy_binding systemcmdpolicyBinding = new systemgroup_systemcmdpolicy_binding();
      systemcmdpolicyBinding.groupname = groupname;
      options option = new options();
      option.set_filter(filter);
      return (systemgroup_systemcmdpolicy_binding[]) systemcmdpolicyBinding.getfiltered(service, option);
    }

    public static systemgroup_systemcmdpolicy_binding[] get_filtered(
      nitro_service service,
      string groupname,
      filtervalue[] filter)
    {
      systemgroup_systemcmdpolicy_binding systemcmdpolicyBinding = new systemgroup_systemcmdpolicy_binding();
      systemcmdpolicyBinding.groupname = groupname;
      options option = new options();
      option.set_filter(filter);
      return (systemgroup_systemcmdpolicy_binding[]) systemcmdpolicyBinding.getfiltered(service, option);
    }

    public static uint count(nitro_service service, string groupname)
    {
      systemgroup_systemcmdpolicy_binding systemcmdpolicyBinding = new systemgroup_systemcmdpolicy_binding();
      systemcmdpolicyBinding.groupname = groupname;
      options option = new options();
      option.set_count(true);
      systemgroup_systemcmdpolicy_binding[] resources = (systemgroup_systemcmdpolicy_binding[]) systemcmdpolicyBinding.get_resources(service, option);
      return resources != null && resources.Length > 0 ? resources[0].__count.Value : 0U;
    }

    public static uint count_filtered(nitro_service service, string groupname, string filter)
    {
      systemgroup_systemcmdpolicy_binding systemcmdpolicyBinding = new systemgroup_systemcmdpolicy_binding();
      systemcmdpolicyBinding.groupname = groupname;
      options option = new options();
      option.set_count(true);
      option.set_filter(filter);
      systemgroup_systemcmdpolicy_binding[] systemcmdpolicyBindingArray = (systemgroup_systemcmdpolicy_binding[]) systemcmdpolicyBinding.getfiltered(service, option);
      return systemcmdpolicyBindingArray != null && systemcmdpolicyBindingArray.Length > 0 ? systemcmdpolicyBindingArray[0].__count.Value : 0U;
    }

    public static uint count_filtered(
      nitro_service service,
      string groupname,
      filtervalue[] filter)
    {
      systemgroup_systemcmdpolicy_binding systemcmdpolicyBinding = new systemgroup_systemcmdpolicy_binding();
      systemcmdpolicyBinding.groupname = groupname;
      options option = new options();
      option.set_count(true);
      option.set_filter(filter);
      systemgroup_systemcmdpolicy_binding[] systemcmdpolicyBindingArray = (systemgroup_systemcmdpolicy_binding[]) systemcmdpolicyBinding.getfiltered(service, option);
      return systemcmdpolicyBindingArray != null && systemcmdpolicyBindingArray.Length > 0 ? systemcmdpolicyBindingArray[0].__count.Value : 0U;
    }

    private class systemgroup_systemcmdpolicy_binding_response : base_response
    {
      public systemgroup_systemcmdpolicy_binding[] systemgroup_systemcmdpolicy_binding = (systemgroup_systemcmdpolicy_binding[]) null;
    }
  }
}
