﻿// Decompiled with JetBrains decompiler
// Type: com.citrix.netscaler.nitro.resource.config.aaa.aaagroup_auditsyslogpolicy_binding
// Assembly: nitro, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 6CF5DDEF-E052-4F9D-953F-6644F8378A66


using com.citrix.netscaler.nitro.exception;
using com.citrix.netscaler.nitro.resource.Base;
using com.citrix.netscaler.nitro.service;
using com.citrix.netscaler.nitro.util;

namespace com.citrix.netscaler.nitro.resource.config.aaa
{
  public class aaagroup_auditsyslogpolicy_binding : base_resource
  {
    private string policyField = (string) null;
    private uint? priorityField = new uint?();
    private uint? acttypeField = new uint?();
    private string groupnameField = (string) null;
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

    public string gotopriorityexpression
    {
      get => this.gotopriorityexpressionField;
      set => this.gotopriorityexpressionField = value;
    }

    public string policy
    {
      get => this.policyField;
      set => this.policyField = value;
    }

    public string groupname
    {
      get => this.groupnameField;
      set => this.groupnameField = value;
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
      aaagroup_auditsyslogpolicy_binding.aaagroup_auditsyslogpolicy_binding_response auditsyslogpolicyBindingResponse = new aaagroup_auditsyslogpolicy_binding.aaagroup_auditsyslogpolicy_binding_response();
      aaagroup_auditsyslogpolicy_binding.aaagroup_auditsyslogpolicy_binding_response resource = (aaagroup_auditsyslogpolicy_binding.aaagroup_auditsyslogpolicy_binding_response) service.get_payload_formatter().string_to_resource(auditsyslogpolicyBindingResponse.GetType(), response);
      if (resource.errorcode != 0)
      {
        if (resource.errorcode == 444)
          service.clear_session();
        if (resource.severity == null)
          throw new nitro_exception(resource.message, resource.errorcode);
        if (resource.severity.Equals("ERROR"))
          throw new nitro_exception(resource.message, resource.errorcode);
      }
      return (base_resource[]) resource.aaagroup_auditsyslogpolicy_binding;
    }

    internal override string get_object_name() => this.groupname;

    public static base_response add(
      nitro_service client,
      aaagroup_auditsyslogpolicy_binding resource)
    {
      return new aaagroup_auditsyslogpolicy_binding()
      {
        groupname = resource.groupname,
        policy = resource.policy,
        priority = resource.priority,
        gotopriorityexpression = resource.gotopriorityexpression
      }.update_resource(client);
    }

    public static base_responses add(
      nitro_service client,
      aaagroup_auditsyslogpolicy_binding[] resources)
    {
      base_responses baseResponses = (base_responses) null;
      if (resources != null && resources.Length > 0)
      {
        aaagroup_auditsyslogpolicy_binding[] auditsyslogpolicyBindingArray = new aaagroup_auditsyslogpolicy_binding[resources.Length];
        for (int index = 0; index < resources.Length; ++index)
        {
          auditsyslogpolicyBindingArray[index] = new aaagroup_auditsyslogpolicy_binding();
          auditsyslogpolicyBindingArray[index].groupname = resources[index].groupname;
          auditsyslogpolicyBindingArray[index].policy = resources[index].policy;
          auditsyslogpolicyBindingArray[index].priority = resources[index].priority;
          auditsyslogpolicyBindingArray[index].gotopriorityexpression = resources[index].gotopriorityexpression;
        }
        baseResponses = base_resource.update_bulk_request(client, (base_resource[]) auditsyslogpolicyBindingArray);
      }
      return baseResponses;
    }

    public static base_response delete(
      nitro_service client,
      aaagroup_auditsyslogpolicy_binding resource)
    {
      return new aaagroup_auditsyslogpolicy_binding()
      {
        groupname = resource.groupname,
        policy = resource.policy
      }.delete_resource(client);
    }

    public static base_responses delete(
      nitro_service client,
      aaagroup_auditsyslogpolicy_binding[] resources)
    {
      base_responses baseResponses = (base_responses) null;
      if (resources != null && resources.Length > 0)
      {
        aaagroup_auditsyslogpolicy_binding[] auditsyslogpolicyBindingArray = new aaagroup_auditsyslogpolicy_binding[resources.Length];
        for (int index = 0; index < resources.Length; ++index)
        {
          auditsyslogpolicyBindingArray[index] = new aaagroup_auditsyslogpolicy_binding();
          auditsyslogpolicyBindingArray[index].groupname = resources[index].groupname;
          auditsyslogpolicyBindingArray[index].policy = resources[index].policy;
        }
        baseResponses = base_resource.delete_bulk_request(client, (base_resource[]) auditsyslogpolicyBindingArray);
      }
      return baseResponses;
    }

    public static aaagroup_auditsyslogpolicy_binding[] get(
      nitro_service service,
      string groupname)
    {
      return (aaagroup_auditsyslogpolicy_binding[]) new aaagroup_auditsyslogpolicy_binding()
      {
        groupname = groupname
      }.get_resources(service, (options) null);
    }

    public static aaagroup_auditsyslogpolicy_binding[] get_filtered(
      nitro_service service,
      string groupname,
      string filter)
    {
      aaagroup_auditsyslogpolicy_binding auditsyslogpolicyBinding = new aaagroup_auditsyslogpolicy_binding();
      auditsyslogpolicyBinding.groupname = groupname;
      options option = new options();
      option.set_filter(filter);
      return (aaagroup_auditsyslogpolicy_binding[]) auditsyslogpolicyBinding.getfiltered(service, option);
    }

    public static aaagroup_auditsyslogpolicy_binding[] get_filtered(
      nitro_service service,
      string groupname,
      filtervalue[] filter)
    {
      aaagroup_auditsyslogpolicy_binding auditsyslogpolicyBinding = new aaagroup_auditsyslogpolicy_binding();
      auditsyslogpolicyBinding.groupname = groupname;
      options option = new options();
      option.set_filter(filter);
      return (aaagroup_auditsyslogpolicy_binding[]) auditsyslogpolicyBinding.getfiltered(service, option);
    }

    public static uint count(nitro_service service, string groupname)
    {
      aaagroup_auditsyslogpolicy_binding auditsyslogpolicyBinding = new aaagroup_auditsyslogpolicy_binding();
      auditsyslogpolicyBinding.groupname = groupname;
      options option = new options();
      option.set_count(true);
      aaagroup_auditsyslogpolicy_binding[] resources = (aaagroup_auditsyslogpolicy_binding[]) auditsyslogpolicyBinding.get_resources(service, option);
      return resources != null && resources.Length > 0 ? resources[0].__count.Value : 0U;
    }

    public static uint count_filtered(nitro_service service, string groupname, string filter)
    {
      aaagroup_auditsyslogpolicy_binding auditsyslogpolicyBinding = new aaagroup_auditsyslogpolicy_binding();
      auditsyslogpolicyBinding.groupname = groupname;
      options option = new options();
      option.set_count(true);
      option.set_filter(filter);
      aaagroup_auditsyslogpolicy_binding[] auditsyslogpolicyBindingArray = (aaagroup_auditsyslogpolicy_binding[]) auditsyslogpolicyBinding.getfiltered(service, option);
      return auditsyslogpolicyBindingArray != null && auditsyslogpolicyBindingArray.Length > 0 ? auditsyslogpolicyBindingArray[0].__count.Value : 0U;
    }

    public static uint count_filtered(
      nitro_service service,
      string groupname,
      filtervalue[] filter)
    {
      aaagroup_auditsyslogpolicy_binding auditsyslogpolicyBinding = new aaagroup_auditsyslogpolicy_binding();
      auditsyslogpolicyBinding.groupname = groupname;
      options option = new options();
      option.set_count(true);
      option.set_filter(filter);
      aaagroup_auditsyslogpolicy_binding[] auditsyslogpolicyBindingArray = (aaagroup_auditsyslogpolicy_binding[]) auditsyslogpolicyBinding.getfiltered(service, option);
      return auditsyslogpolicyBindingArray != null && auditsyslogpolicyBindingArray.Length > 0 ? auditsyslogpolicyBindingArray[0].__count.Value : 0U;
    }

    private class aaagroup_auditsyslogpolicy_binding_response : base_response
    {
      public aaagroup_auditsyslogpolicy_binding[] aaagroup_auditsyslogpolicy_binding = (aaagroup_auditsyslogpolicy_binding[]) null;
    }
  }
}
