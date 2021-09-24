// Decompiled with JetBrains decompiler
// Type: com.citrix.netscaler.nitro.resource.config.aaa.aaagroup_vpntrafficpolicy_binding
// Assembly: nitro, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 6CF5DDEF-E052-4F9D-953F-6644F8378A66


using com.citrix.netscaler.nitro.exception;
using com.citrix.netscaler.nitro.resource.Base;
using com.citrix.netscaler.nitro.service;
using com.citrix.netscaler.nitro.util;

namespace com.citrix.netscaler.nitro.resource.config.aaa
{
  public class aaagroup_vpntrafficpolicy_binding : base_resource
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
      aaagroup_vpntrafficpolicy_binding.aaagroup_vpntrafficpolicy_binding_response vpntrafficpolicyBindingResponse = new aaagroup_vpntrafficpolicy_binding.aaagroup_vpntrafficpolicy_binding_response();
      aaagroup_vpntrafficpolicy_binding.aaagroup_vpntrafficpolicy_binding_response resource = (aaagroup_vpntrafficpolicy_binding.aaagroup_vpntrafficpolicy_binding_response) service.get_payload_formatter().string_to_resource(vpntrafficpolicyBindingResponse.GetType(), response);
      if (resource.errorcode != 0)
      {
        if (resource.errorcode == 444)
          service.clear_session();
        if (resource.severity == null)
          throw new nitro_exception(resource.message, resource.errorcode);
        if (resource.severity.Equals("ERROR"))
          throw new nitro_exception(resource.message, resource.errorcode);
      }
      return (base_resource[]) resource.aaagroup_vpntrafficpolicy_binding;
    }

    internal override string get_object_name() => this.groupname;

    public static base_response add(
      nitro_service client,
      aaagroup_vpntrafficpolicy_binding resource)
    {
      return new aaagroup_vpntrafficpolicy_binding()
      {
        groupname = resource.groupname,
        policy = resource.policy,
        priority = resource.priority,
        gotopriorityexpression = resource.gotopriorityexpression
      }.update_resource(client);
    }

    public static base_responses add(
      nitro_service client,
      aaagroup_vpntrafficpolicy_binding[] resources)
    {
      base_responses baseResponses = (base_responses) null;
      if (resources != null && resources.Length > 0)
      {
        aaagroup_vpntrafficpolicy_binding[] vpntrafficpolicyBindingArray = new aaagroup_vpntrafficpolicy_binding[resources.Length];
        for (int index = 0; index < resources.Length; ++index)
        {
          vpntrafficpolicyBindingArray[index] = new aaagroup_vpntrafficpolicy_binding();
          vpntrafficpolicyBindingArray[index].groupname = resources[index].groupname;
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
      aaagroup_vpntrafficpolicy_binding resource)
    {
      return new aaagroup_vpntrafficpolicy_binding()
      {
        groupname = resource.groupname,
        policy = resource.policy
      }.delete_resource(client);
    }

    public static base_responses delete(
      nitro_service client,
      aaagroup_vpntrafficpolicy_binding[] resources)
    {
      base_responses baseResponses = (base_responses) null;
      if (resources != null && resources.Length > 0)
      {
        aaagroup_vpntrafficpolicy_binding[] vpntrafficpolicyBindingArray = new aaagroup_vpntrafficpolicy_binding[resources.Length];
        for (int index = 0; index < resources.Length; ++index)
        {
          vpntrafficpolicyBindingArray[index] = new aaagroup_vpntrafficpolicy_binding();
          vpntrafficpolicyBindingArray[index].groupname = resources[index].groupname;
          vpntrafficpolicyBindingArray[index].policy = resources[index].policy;
        }
        baseResponses = base_resource.delete_bulk_request(client, (base_resource[]) vpntrafficpolicyBindingArray);
      }
      return baseResponses;
    }

    public static aaagroup_vpntrafficpolicy_binding[] get(
      nitro_service service,
      string groupname)
    {
      return (aaagroup_vpntrafficpolicy_binding[]) new aaagroup_vpntrafficpolicy_binding()
      {
        groupname = groupname
      }.get_resources(service, (options) null);
    }

    public static aaagroup_vpntrafficpolicy_binding[] get_filtered(
      nitro_service service,
      string groupname,
      string filter)
    {
      aaagroup_vpntrafficpolicy_binding vpntrafficpolicyBinding = new aaagroup_vpntrafficpolicy_binding();
      vpntrafficpolicyBinding.groupname = groupname;
      options option = new options();
      option.set_filter(filter);
      return (aaagroup_vpntrafficpolicy_binding[]) vpntrafficpolicyBinding.getfiltered(service, option);
    }

    public static aaagroup_vpntrafficpolicy_binding[] get_filtered(
      nitro_service service,
      string groupname,
      filtervalue[] filter)
    {
      aaagroup_vpntrafficpolicy_binding vpntrafficpolicyBinding = new aaagroup_vpntrafficpolicy_binding();
      vpntrafficpolicyBinding.groupname = groupname;
      options option = new options();
      option.set_filter(filter);
      return (aaagroup_vpntrafficpolicy_binding[]) vpntrafficpolicyBinding.getfiltered(service, option);
    }

    public static uint count(nitro_service service, string groupname)
    {
      aaagroup_vpntrafficpolicy_binding vpntrafficpolicyBinding = new aaagroup_vpntrafficpolicy_binding();
      vpntrafficpolicyBinding.groupname = groupname;
      options option = new options();
      option.set_count(true);
      aaagroup_vpntrafficpolicy_binding[] resources = (aaagroup_vpntrafficpolicy_binding[]) vpntrafficpolicyBinding.get_resources(service, option);
      return resources != null && resources.Length > 0 ? resources[0].__count.Value : 0U;
    }

    public static uint count_filtered(nitro_service service, string groupname, string filter)
    {
      aaagroup_vpntrafficpolicy_binding vpntrafficpolicyBinding = new aaagroup_vpntrafficpolicy_binding();
      vpntrafficpolicyBinding.groupname = groupname;
      options option = new options();
      option.set_count(true);
      option.set_filter(filter);
      aaagroup_vpntrafficpolicy_binding[] vpntrafficpolicyBindingArray = (aaagroup_vpntrafficpolicy_binding[]) vpntrafficpolicyBinding.getfiltered(service, option);
      return vpntrafficpolicyBindingArray != null && vpntrafficpolicyBindingArray.Length > 0 ? vpntrafficpolicyBindingArray[0].__count.Value : 0U;
    }

    public static uint count_filtered(
      nitro_service service,
      string groupname,
      filtervalue[] filter)
    {
      aaagroup_vpntrafficpolicy_binding vpntrafficpolicyBinding = new aaagroup_vpntrafficpolicy_binding();
      vpntrafficpolicyBinding.groupname = groupname;
      options option = new options();
      option.set_count(true);
      option.set_filter(filter);
      aaagroup_vpntrafficpolicy_binding[] vpntrafficpolicyBindingArray = (aaagroup_vpntrafficpolicy_binding[]) vpntrafficpolicyBinding.getfiltered(service, option);
      return vpntrafficpolicyBindingArray != null && vpntrafficpolicyBindingArray.Length > 0 ? vpntrafficpolicyBindingArray[0].__count.Value : 0U;
    }

    private class aaagroup_vpntrafficpolicy_binding_response : base_response
    {
      public aaagroup_vpntrafficpolicy_binding[] aaagroup_vpntrafficpolicy_binding = (aaagroup_vpntrafficpolicy_binding[]) null;
    }
  }
}
