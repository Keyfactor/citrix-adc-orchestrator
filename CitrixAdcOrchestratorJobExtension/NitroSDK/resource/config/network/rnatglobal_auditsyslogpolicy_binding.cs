// Decompiled with JetBrains decompiler
// Type: com.citrix.netscaler.nitro.resource.config.network.rnatglobal_auditsyslogpolicy_binding
// Assembly: nitro, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 6CF5DDEF-E052-4F9D-953F-6644F8378A66


using com.citrix.netscaler.nitro.exception;
using com.citrix.netscaler.nitro.resource.Base;
using com.citrix.netscaler.nitro.service;
using com.citrix.netscaler.nitro.util;

namespace com.citrix.netscaler.nitro.resource.config.network
{
  public class rnatglobal_auditsyslogpolicy_binding : base_resource
  {
    private string policyField = (string) null;
    private uint? priorityField = new uint?();
    private bool? allField = new bool?();
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

    public string policy
    {
      get => this.policyField;
      set => this.policyField = value;
    }

    public bool? all
    {
      get => this.allField;
      set => this.allField = value;
    }

    internal override base_resource[] get_nitro_response(
      nitro_service service,
      string response)
    {
      rnatglobal_auditsyslogpolicy_binding.rnatglobal_auditsyslogpolicy_binding_response auditsyslogpolicyBindingResponse = new rnatglobal_auditsyslogpolicy_binding.rnatglobal_auditsyslogpolicy_binding_response();
      rnatglobal_auditsyslogpolicy_binding.rnatglobal_auditsyslogpolicy_binding_response resource = (rnatglobal_auditsyslogpolicy_binding.rnatglobal_auditsyslogpolicy_binding_response) service.get_payload_formatter().string_to_resource(auditsyslogpolicyBindingResponse.GetType(), response);
      if (resource.errorcode != 0)
      {
        if (resource.errorcode == 444)
          service.clear_session();
        if (resource.severity == null)
          throw new nitro_exception(resource.message, resource.errorcode);
        if (resource.severity.Equals("ERROR"))
          throw new nitro_exception(resource.message, resource.errorcode);
      }
      return (base_resource[]) resource.rnatglobal_auditsyslogpolicy_binding;
    }

    internal override string get_object_name() => (string) null;

    public static base_response add(
      nitro_service client,
      rnatglobal_auditsyslogpolicy_binding resource)
    {
      return new rnatglobal_auditsyslogpolicy_binding()
      {
        policy = resource.policy,
        priority = resource.priority
      }.update_resource(client);
    }

    public static base_responses add(
      nitro_service client,
      rnatglobal_auditsyslogpolicy_binding[] resources)
    {
      base_responses baseResponses = (base_responses) null;
      if (resources != null && resources.Length > 0)
      {
        rnatglobal_auditsyslogpolicy_binding[] auditsyslogpolicyBindingArray = new rnatglobal_auditsyslogpolicy_binding[resources.Length];
        for (int index = 0; index < resources.Length; ++index)
        {
          auditsyslogpolicyBindingArray[index] = new rnatglobal_auditsyslogpolicy_binding();
          auditsyslogpolicyBindingArray[index].policy = resources[index].policy;
          auditsyslogpolicyBindingArray[index].priority = resources[index].priority;
        }
        baseResponses = base_resource.update_bulk_request(client, (base_resource[]) auditsyslogpolicyBindingArray);
      }
      return baseResponses;
    }

    public static base_response delete(
      nitro_service client,
      rnatglobal_auditsyslogpolicy_binding resource)
    {
      return new rnatglobal_auditsyslogpolicy_binding()
      {
        policy = resource.policy,
        all = resource.all
      }.delete_resource(client);
    }

    public static base_responses delete(
      nitro_service client,
      rnatglobal_auditsyslogpolicy_binding[] resources)
    {
      base_responses baseResponses = (base_responses) null;
      if (resources != null && resources.Length > 0)
      {
        rnatglobal_auditsyslogpolicy_binding[] auditsyslogpolicyBindingArray = new rnatglobal_auditsyslogpolicy_binding[resources.Length];
        for (int index = 0; index < resources.Length; ++index)
        {
          auditsyslogpolicyBindingArray[index] = new rnatglobal_auditsyslogpolicy_binding();
          auditsyslogpolicyBindingArray[index].policy = resources[index].policy;
          auditsyslogpolicyBindingArray[index].all = resources[index].all;
        }
        baseResponses = base_resource.delete_bulk_request(client, (base_resource[]) auditsyslogpolicyBindingArray);
      }
      return baseResponses;
    }

    public static rnatglobal_auditsyslogpolicy_binding[] get(
      nitro_service service)
    {
      return (rnatglobal_auditsyslogpolicy_binding[]) new rnatglobal_auditsyslogpolicy_binding().get_resources(service, (options) null);
    }

    public static rnatglobal_auditsyslogpolicy_binding[] get_filtered(
      nitro_service service,
      string filter)
    {
      rnatglobal_auditsyslogpolicy_binding auditsyslogpolicyBinding = new rnatglobal_auditsyslogpolicy_binding();
      options option = new options();
      option.set_filter(filter);
      return (rnatglobal_auditsyslogpolicy_binding[]) auditsyslogpolicyBinding.getfiltered(service, option);
    }

    public static rnatglobal_auditsyslogpolicy_binding[] get_filtered(
      nitro_service service,
      filtervalue[] filter)
    {
      rnatglobal_auditsyslogpolicy_binding auditsyslogpolicyBinding = new rnatglobal_auditsyslogpolicy_binding();
      options option = new options();
      option.set_filter(filter);
      return (rnatglobal_auditsyslogpolicy_binding[]) auditsyslogpolicyBinding.getfiltered(service, option);
    }

    public static uint count(nitro_service service)
    {
      rnatglobal_auditsyslogpolicy_binding auditsyslogpolicyBinding = new rnatglobal_auditsyslogpolicy_binding();
      options option = new options();
      option.set_count(true);
      rnatglobal_auditsyslogpolicy_binding[] resources = (rnatglobal_auditsyslogpolicy_binding[]) auditsyslogpolicyBinding.get_resources(service, option);
      return resources != null && resources.Length > 0 ? resources[0].__count.Value : 0U;
    }

    public static uint count_filtered(nitro_service service, string filter)
    {
      rnatglobal_auditsyslogpolicy_binding auditsyslogpolicyBinding = new rnatglobal_auditsyslogpolicy_binding();
      options option = new options();
      option.set_count(true);
      option.set_filter(filter);
      rnatglobal_auditsyslogpolicy_binding[] auditsyslogpolicyBindingArray = (rnatglobal_auditsyslogpolicy_binding[]) auditsyslogpolicyBinding.getfiltered(service, option);
      return auditsyslogpolicyBindingArray != null && auditsyslogpolicyBindingArray.Length > 0 ? auditsyslogpolicyBindingArray[0].__count.Value : 0U;
    }

    public static uint count_filtered(nitro_service service, filtervalue[] filter)
    {
      rnatglobal_auditsyslogpolicy_binding auditsyslogpolicyBinding = new rnatglobal_auditsyslogpolicy_binding();
      options option = new options();
      option.set_count(true);
      option.set_filter(filter);
      rnatglobal_auditsyslogpolicy_binding[] auditsyslogpolicyBindingArray = (rnatglobal_auditsyslogpolicy_binding[]) auditsyslogpolicyBinding.getfiltered(service, option);
      return auditsyslogpolicyBindingArray != null && auditsyslogpolicyBindingArray.Length > 0 ? auditsyslogpolicyBindingArray[0].__count.Value : 0U;
    }

    private class rnatglobal_auditsyslogpolicy_binding_response : base_response
    {
      public rnatglobal_auditsyslogpolicy_binding[] rnatglobal_auditsyslogpolicy_binding = (rnatglobal_auditsyslogpolicy_binding[]) null;
    }
  }
}
