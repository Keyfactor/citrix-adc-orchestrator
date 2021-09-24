// Decompiled with JetBrains decompiler
// Type: com.citrix.netscaler.nitro.resource.config.aaa.aaauser_tmsessionpolicy_binding
// Assembly: nitro, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 6CF5DDEF-E052-4F9D-953F-6644F8378A66


using com.citrix.netscaler.nitro.exception;
using com.citrix.netscaler.nitro.resource.Base;
using com.citrix.netscaler.nitro.service;
using com.citrix.netscaler.nitro.util;

namespace com.citrix.netscaler.nitro.resource.config.aaa
{
  public class aaauser_tmsessionpolicy_binding : base_resource
  {
    private string policyField = (string) null;
    private uint? priorityField = new uint?();
    private uint? acttypeField = new uint?();
    private string gotopriorityexpressionField = (string) null;
    private string usernameField = (string) null;
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

    public string username
    {
      get => this.usernameField;
      set => this.usernameField = value;
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
      aaauser_tmsessionpolicy_binding.aaauser_tmsessionpolicy_binding_response tmsessionpolicyBindingResponse = new aaauser_tmsessionpolicy_binding.aaauser_tmsessionpolicy_binding_response();
      aaauser_tmsessionpolicy_binding.aaauser_tmsessionpolicy_binding_response resource = (aaauser_tmsessionpolicy_binding.aaauser_tmsessionpolicy_binding_response) service.get_payload_formatter().string_to_resource(tmsessionpolicyBindingResponse.GetType(), response);
      if (resource.errorcode != 0)
      {
        if (resource.errorcode == 444)
          service.clear_session();
        if (resource.severity == null)
          throw new nitro_exception(resource.message, resource.errorcode);
        if (resource.severity.Equals("ERROR"))
          throw new nitro_exception(resource.message, resource.errorcode);
      }
      return (base_resource[]) resource.aaauser_tmsessionpolicy_binding;
    }

    internal override string get_object_name() => this.username;

    public static base_response add(
      nitro_service client,
      aaauser_tmsessionpolicy_binding resource)
    {
      return new aaauser_tmsessionpolicy_binding()
      {
        username = resource.username,
        policy = resource.policy,
        priority = resource.priority,
        gotopriorityexpression = resource.gotopriorityexpression
      }.update_resource(client);
    }

    public static base_responses add(
      nitro_service client,
      aaauser_tmsessionpolicy_binding[] resources)
    {
      base_responses baseResponses = (base_responses) null;
      if (resources != null && resources.Length > 0)
      {
        aaauser_tmsessionpolicy_binding[] tmsessionpolicyBindingArray = new aaauser_tmsessionpolicy_binding[resources.Length];
        for (int index = 0; index < resources.Length; ++index)
        {
          tmsessionpolicyBindingArray[index] = new aaauser_tmsessionpolicy_binding();
          tmsessionpolicyBindingArray[index].username = resources[index].username;
          tmsessionpolicyBindingArray[index].policy = resources[index].policy;
          tmsessionpolicyBindingArray[index].priority = resources[index].priority;
          tmsessionpolicyBindingArray[index].gotopriorityexpression = resources[index].gotopriorityexpression;
        }
        baseResponses = base_resource.update_bulk_request(client, (base_resource[]) tmsessionpolicyBindingArray);
      }
      return baseResponses;
    }

    public static base_response delete(
      nitro_service client,
      aaauser_tmsessionpolicy_binding resource)
    {
      return new aaauser_tmsessionpolicy_binding()
      {
        username = resource.username,
        policy = resource.policy
      }.delete_resource(client);
    }

    public static base_responses delete(
      nitro_service client,
      aaauser_tmsessionpolicy_binding[] resources)
    {
      base_responses baseResponses = (base_responses) null;
      if (resources != null && resources.Length > 0)
      {
        aaauser_tmsessionpolicy_binding[] tmsessionpolicyBindingArray = new aaauser_tmsessionpolicy_binding[resources.Length];
        for (int index = 0; index < resources.Length; ++index)
        {
          tmsessionpolicyBindingArray[index] = new aaauser_tmsessionpolicy_binding();
          tmsessionpolicyBindingArray[index].username = resources[index].username;
          tmsessionpolicyBindingArray[index].policy = resources[index].policy;
        }
        baseResponses = base_resource.delete_bulk_request(client, (base_resource[]) tmsessionpolicyBindingArray);
      }
      return baseResponses;
    }

    public static aaauser_tmsessionpolicy_binding[] get(
      nitro_service service,
      string username)
    {
      return (aaauser_tmsessionpolicy_binding[]) new aaauser_tmsessionpolicy_binding()
      {
        username = username
      }.get_resources(service, (options) null);
    }

    public static aaauser_tmsessionpolicy_binding[] get_filtered(
      nitro_service service,
      string username,
      string filter)
    {
      aaauser_tmsessionpolicy_binding tmsessionpolicyBinding = new aaauser_tmsessionpolicy_binding();
      tmsessionpolicyBinding.username = username;
      options option = new options();
      option.set_filter(filter);
      return (aaauser_tmsessionpolicy_binding[]) tmsessionpolicyBinding.getfiltered(service, option);
    }

    public static aaauser_tmsessionpolicy_binding[] get_filtered(
      nitro_service service,
      string username,
      filtervalue[] filter)
    {
      aaauser_tmsessionpolicy_binding tmsessionpolicyBinding = new aaauser_tmsessionpolicy_binding();
      tmsessionpolicyBinding.username = username;
      options option = new options();
      option.set_filter(filter);
      return (aaauser_tmsessionpolicy_binding[]) tmsessionpolicyBinding.getfiltered(service, option);
    }

    public static uint count(nitro_service service, string username)
    {
      aaauser_tmsessionpolicy_binding tmsessionpolicyBinding = new aaauser_tmsessionpolicy_binding();
      tmsessionpolicyBinding.username = username;
      options option = new options();
      option.set_count(true);
      aaauser_tmsessionpolicy_binding[] resources = (aaauser_tmsessionpolicy_binding[]) tmsessionpolicyBinding.get_resources(service, option);
      return resources != null && resources.Length > 0 ? resources[0].__count.Value : 0U;
    }

    public static uint count_filtered(nitro_service service, string username, string filter)
    {
      aaauser_tmsessionpolicy_binding tmsessionpolicyBinding = new aaauser_tmsessionpolicy_binding();
      tmsessionpolicyBinding.username = username;
      options option = new options();
      option.set_count(true);
      option.set_filter(filter);
      aaauser_tmsessionpolicy_binding[] tmsessionpolicyBindingArray = (aaauser_tmsessionpolicy_binding[]) tmsessionpolicyBinding.getfiltered(service, option);
      return tmsessionpolicyBindingArray != null && tmsessionpolicyBindingArray.Length > 0 ? tmsessionpolicyBindingArray[0].__count.Value : 0U;
    }

    public static uint count_filtered(nitro_service service, string username, filtervalue[] filter)
    {
      aaauser_tmsessionpolicy_binding tmsessionpolicyBinding = new aaauser_tmsessionpolicy_binding();
      tmsessionpolicyBinding.username = username;
      options option = new options();
      option.set_count(true);
      option.set_filter(filter);
      aaauser_tmsessionpolicy_binding[] tmsessionpolicyBindingArray = (aaauser_tmsessionpolicy_binding[]) tmsessionpolicyBinding.getfiltered(service, option);
      return tmsessionpolicyBindingArray != null && tmsessionpolicyBindingArray.Length > 0 ? tmsessionpolicyBindingArray[0].__count.Value : 0U;
    }

    private class aaauser_tmsessionpolicy_binding_response : base_response
    {
      public aaauser_tmsessionpolicy_binding[] aaauser_tmsessionpolicy_binding = (aaauser_tmsessionpolicy_binding[]) null;
    }
  }
}
