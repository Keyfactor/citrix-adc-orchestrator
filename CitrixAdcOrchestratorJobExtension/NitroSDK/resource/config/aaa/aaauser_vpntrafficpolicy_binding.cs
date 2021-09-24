// Decompiled with JetBrains decompiler
// Type: com.citrix.netscaler.nitro.resource.config.aaa.aaauser_vpntrafficpolicy_binding
// Assembly: nitro, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 6CF5DDEF-E052-4F9D-953F-6644F8378A66


using com.citrix.netscaler.nitro.exception;
using com.citrix.netscaler.nitro.resource.Base;
using com.citrix.netscaler.nitro.service;
using com.citrix.netscaler.nitro.util;

namespace com.citrix.netscaler.nitro.resource.config.aaa
{
  public class aaauser_vpntrafficpolicy_binding : base_resource
  {
    private string policyField = (string) null;
    private uint? priorityField = new uint?();
    private uint? acttypeField = new uint?();
    private string usernameField = (string) null;
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
      aaauser_vpntrafficpolicy_binding.aaauser_vpntrafficpolicy_binding_response vpntrafficpolicyBindingResponse = new aaauser_vpntrafficpolicy_binding.aaauser_vpntrafficpolicy_binding_response();
      aaauser_vpntrafficpolicy_binding.aaauser_vpntrafficpolicy_binding_response resource = (aaauser_vpntrafficpolicy_binding.aaauser_vpntrafficpolicy_binding_response) service.get_payload_formatter().string_to_resource(vpntrafficpolicyBindingResponse.GetType(), response);
      if (resource.errorcode != 0)
      {
        if (resource.errorcode == 444)
          service.clear_session();
        if (resource.severity == null)
          throw new nitro_exception(resource.message, resource.errorcode);
        if (resource.severity.Equals("ERROR"))
          throw new nitro_exception(resource.message, resource.errorcode);
      }
      return (base_resource[]) resource.aaauser_vpntrafficpolicy_binding;
    }

    internal override string get_object_name() => this.username;

    public static base_response add(
      nitro_service client,
      aaauser_vpntrafficpolicy_binding resource)
    {
      return new aaauser_vpntrafficpolicy_binding()
      {
        username = resource.username,
        policy = resource.policy,
        priority = resource.priority,
        gotopriorityexpression = resource.gotopriorityexpression
      }.update_resource(client);
    }

    public static base_responses add(
      nitro_service client,
      aaauser_vpntrafficpolicy_binding[] resources)
    {
      base_responses baseResponses = (base_responses) null;
      if (resources != null && resources.Length > 0)
      {
        aaauser_vpntrafficpolicy_binding[] vpntrafficpolicyBindingArray = new aaauser_vpntrafficpolicy_binding[resources.Length];
        for (int index = 0; index < resources.Length; ++index)
        {
          vpntrafficpolicyBindingArray[index] = new aaauser_vpntrafficpolicy_binding();
          vpntrafficpolicyBindingArray[index].username = resources[index].username;
          vpntrafficpolicyBindingArray[index].policy = resources[index].policy;
          vpntrafficpolicyBindingArray[index].priority = resources[index].priority;
          vpntrafficpolicyBindingArray[index].gotopriorityexpression = resources[index].gotopriorityexpression;
        }
        baseResponses = base_resource.update_bulk_request(client, (base_resource[]) vpntrafficpolicyBindingArray);
      }
      return baseResponses;
    }

    public static base_response delete(
      nitro_service client,
      aaauser_vpntrafficpolicy_binding resource)
    {
      return new aaauser_vpntrafficpolicy_binding()
      {
        username = resource.username,
        policy = resource.policy
      }.delete_resource(client);
    }

    public static base_responses delete(
      nitro_service client,
      aaauser_vpntrafficpolicy_binding[] resources)
    {
      base_responses baseResponses = (base_responses) null;
      if (resources != null && resources.Length > 0)
      {
        aaauser_vpntrafficpolicy_binding[] vpntrafficpolicyBindingArray = new aaauser_vpntrafficpolicy_binding[resources.Length];
        for (int index = 0; index < resources.Length; ++index)
        {
          vpntrafficpolicyBindingArray[index] = new aaauser_vpntrafficpolicy_binding();
          vpntrafficpolicyBindingArray[index].username = resources[index].username;
          vpntrafficpolicyBindingArray[index].policy = resources[index].policy;
        }
        baseResponses = base_resource.delete_bulk_request(client, (base_resource[]) vpntrafficpolicyBindingArray);
      }
      return baseResponses;
    }

    public static aaauser_vpntrafficpolicy_binding[] get(
      nitro_service service,
      string username)
    {
      return (aaauser_vpntrafficpolicy_binding[]) new aaauser_vpntrafficpolicy_binding()
      {
        username = username
      }.get_resources(service, (options) null);
    }

    public static aaauser_vpntrafficpolicy_binding[] get_filtered(
      nitro_service service,
      string username,
      string filter)
    {
      aaauser_vpntrafficpolicy_binding vpntrafficpolicyBinding = new aaauser_vpntrafficpolicy_binding();
      vpntrafficpolicyBinding.username = username;
      options option = new options();
      option.set_filter(filter);
      return (aaauser_vpntrafficpolicy_binding[]) vpntrafficpolicyBinding.getfiltered(service, option);
    }

    public static aaauser_vpntrafficpolicy_binding[] get_filtered(
      nitro_service service,
      string username,
      filtervalue[] filter)
    {
      aaauser_vpntrafficpolicy_binding vpntrafficpolicyBinding = new aaauser_vpntrafficpolicy_binding();
      vpntrafficpolicyBinding.username = username;
      options option = new options();
      option.set_filter(filter);
      return (aaauser_vpntrafficpolicy_binding[]) vpntrafficpolicyBinding.getfiltered(service, option);
    }

    public static uint count(nitro_service service, string username)
    {
      aaauser_vpntrafficpolicy_binding vpntrafficpolicyBinding = new aaauser_vpntrafficpolicy_binding();
      vpntrafficpolicyBinding.username = username;
      options option = new options();
      option.set_count(true);
      aaauser_vpntrafficpolicy_binding[] resources = (aaauser_vpntrafficpolicy_binding[]) vpntrafficpolicyBinding.get_resources(service, option);
      return resources != null && resources.Length > 0 ? resources[0].__count.Value : 0U;
    }

    public static uint count_filtered(nitro_service service, string username, string filter)
    {
      aaauser_vpntrafficpolicy_binding vpntrafficpolicyBinding = new aaauser_vpntrafficpolicy_binding();
      vpntrafficpolicyBinding.username = username;
      options option = new options();
      option.set_count(true);
      option.set_filter(filter);
      aaauser_vpntrafficpolicy_binding[] vpntrafficpolicyBindingArray = (aaauser_vpntrafficpolicy_binding[]) vpntrafficpolicyBinding.getfiltered(service, option);
      return vpntrafficpolicyBindingArray != null && vpntrafficpolicyBindingArray.Length > 0 ? vpntrafficpolicyBindingArray[0].__count.Value : 0U;
    }

    public static uint count_filtered(nitro_service service, string username, filtervalue[] filter)
    {
      aaauser_vpntrafficpolicy_binding vpntrafficpolicyBinding = new aaauser_vpntrafficpolicy_binding();
      vpntrafficpolicyBinding.username = username;
      options option = new options();
      option.set_count(true);
      option.set_filter(filter);
      aaauser_vpntrafficpolicy_binding[] vpntrafficpolicyBindingArray = (aaauser_vpntrafficpolicy_binding[]) vpntrafficpolicyBinding.getfiltered(service, option);
      return vpntrafficpolicyBindingArray != null && vpntrafficpolicyBindingArray.Length > 0 ? vpntrafficpolicyBindingArray[0].__count.Value : 0U;
    }

    private class aaauser_vpntrafficpolicy_binding_response : base_response
    {
      public aaauser_vpntrafficpolicy_binding[] aaauser_vpntrafficpolicy_binding = (aaauser_vpntrafficpolicy_binding[]) null;
    }
  }
}
