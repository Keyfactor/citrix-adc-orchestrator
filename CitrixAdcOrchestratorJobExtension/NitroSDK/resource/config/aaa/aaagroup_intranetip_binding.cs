// Decompiled with JetBrains decompiler
// Type: com.citrix.netscaler.nitro.resource.config.aaa.aaagroup_intranetip_binding
// Assembly: nitro, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 6CF5DDEF-E052-4F9D-953F-6644F8378A66


using com.citrix.netscaler.nitro.exception;
using com.citrix.netscaler.nitro.resource.Base;
using com.citrix.netscaler.nitro.service;
using com.citrix.netscaler.nitro.util;

namespace com.citrix.netscaler.nitro.resource.config.aaa
{
  public class aaagroup_intranetip_binding : base_resource
  {
    private string intranetipField = (string) null;
    private string netmaskField = (string) null;
    private string groupnameField = (string) null;
    private string gotopriorityexpressionField = (string) null;
    private uint? __countField = new uint?();

    public uint? __count
    {
      get => this.__countField;
      set => this.__countField = value;
    }

    public string gotopriorityexpression
    {
      get => this.gotopriorityexpressionField;
      set => this.gotopriorityexpressionField = value;
    }

    public string intranetip
    {
      get => this.intranetipField;
      set => this.intranetipField = value;
    }

    public string groupname
    {
      get => this.groupnameField;
      set => this.groupnameField = value;
    }

    public string netmask
    {
      get => this.netmaskField;
      set => this.netmaskField = value;
    }

    internal override base_resource[] get_nitro_response(
      nitro_service service,
      string response)
    {
      aaagroup_intranetip_binding.aaagroup_intranetip_binding_response intranetipBindingResponse = new aaagroup_intranetip_binding.aaagroup_intranetip_binding_response();
      aaagroup_intranetip_binding.aaagroup_intranetip_binding_response resource = (aaagroup_intranetip_binding.aaagroup_intranetip_binding_response) service.get_payload_formatter().string_to_resource(intranetipBindingResponse.GetType(), response);
      if (resource.errorcode != 0)
      {
        if (resource.errorcode == 444)
          service.clear_session();
        if (resource.severity == null)
          throw new nitro_exception(resource.message, resource.errorcode);
        if (resource.severity.Equals("ERROR"))
          throw new nitro_exception(resource.message, resource.errorcode);
      }
      return (base_resource[]) resource.aaagroup_intranetip_binding;
    }

    internal override string get_object_name() => this.groupname;

    public static base_response add(
      nitro_service client,
      aaagroup_intranetip_binding resource)
    {
      return new aaagroup_intranetip_binding()
      {
        groupname = resource.groupname,
        intranetip = resource.intranetip,
        netmask = resource.netmask,
        gotopriorityexpression = resource.gotopriorityexpression
      }.update_resource(client);
    }

    public static base_responses add(
      nitro_service client,
      aaagroup_intranetip_binding[] resources)
    {
      base_responses baseResponses = (base_responses) null;
      if (resources != null && resources.Length > 0)
      {
        aaagroup_intranetip_binding[] intranetipBindingArray = new aaagroup_intranetip_binding[resources.Length];
        for (int index = 0; index < resources.Length; ++index)
        {
          intranetipBindingArray[index] = new aaagroup_intranetip_binding();
          intranetipBindingArray[index].groupname = resources[index].groupname;
          intranetipBindingArray[index].intranetip = resources[index].intranetip;
          intranetipBindingArray[index].netmask = resources[index].netmask;
          intranetipBindingArray[index].gotopriorityexpression = resources[index].gotopriorityexpression;
        }
        baseResponses = base_resource.update_bulk_request(client, (base_resource[]) intranetipBindingArray);
      }
      return baseResponses;
    }

    public static base_response delete(
      nitro_service client,
      aaagroup_intranetip_binding resource)
    {
      return new aaagroup_intranetip_binding()
      {
        groupname = resource.groupname,
        intranetip = resource.intranetip,
        netmask = resource.netmask
      }.delete_resource(client);
    }

    public static base_responses delete(
      nitro_service client,
      aaagroup_intranetip_binding[] resources)
    {
      base_responses baseResponses = (base_responses) null;
      if (resources != null && resources.Length > 0)
      {
        aaagroup_intranetip_binding[] intranetipBindingArray = new aaagroup_intranetip_binding[resources.Length];
        for (int index = 0; index < resources.Length; ++index)
        {
          intranetipBindingArray[index] = new aaagroup_intranetip_binding();
          intranetipBindingArray[index].groupname = resources[index].groupname;
          intranetipBindingArray[index].intranetip = resources[index].intranetip;
          intranetipBindingArray[index].netmask = resources[index].netmask;
        }
        baseResponses = base_resource.delete_bulk_request(client, (base_resource[]) intranetipBindingArray);
      }
      return baseResponses;
    }

    public static aaagroup_intranetip_binding[] get(
      nitro_service service,
      string groupname)
    {
      return (aaagroup_intranetip_binding[]) new aaagroup_intranetip_binding()
      {
        groupname = groupname
      }.get_resources(service, (options) null);
    }

    public static aaagroup_intranetip_binding[] get_filtered(
      nitro_service service,
      string groupname,
      string filter)
    {
      aaagroup_intranetip_binding intranetipBinding = new aaagroup_intranetip_binding();
      intranetipBinding.groupname = groupname;
      options option = new options();
      option.set_filter(filter);
      return (aaagroup_intranetip_binding[]) intranetipBinding.getfiltered(service, option);
    }

    public static aaagroup_intranetip_binding[] get_filtered(
      nitro_service service,
      string groupname,
      filtervalue[] filter)
    {
      aaagroup_intranetip_binding intranetipBinding = new aaagroup_intranetip_binding();
      intranetipBinding.groupname = groupname;
      options option = new options();
      option.set_filter(filter);
      return (aaagroup_intranetip_binding[]) intranetipBinding.getfiltered(service, option);
    }

    public static uint count(nitro_service service, string groupname)
    {
      aaagroup_intranetip_binding intranetipBinding = new aaagroup_intranetip_binding();
      intranetipBinding.groupname = groupname;
      options option = new options();
      option.set_count(true);
      aaagroup_intranetip_binding[] resources = (aaagroup_intranetip_binding[]) intranetipBinding.get_resources(service, option);
      return resources != null && resources.Length > 0 ? resources[0].__count.Value : 0U;
    }

    public static uint count_filtered(nitro_service service, string groupname, string filter)
    {
      aaagroup_intranetip_binding intranetipBinding = new aaagroup_intranetip_binding();
      intranetipBinding.groupname = groupname;
      options option = new options();
      option.set_count(true);
      option.set_filter(filter);
      aaagroup_intranetip_binding[] intranetipBindingArray = (aaagroup_intranetip_binding[]) intranetipBinding.getfiltered(service, option);
      return intranetipBindingArray != null && intranetipBindingArray.Length > 0 ? intranetipBindingArray[0].__count.Value : 0U;
    }

    public static uint count_filtered(
      nitro_service service,
      string groupname,
      filtervalue[] filter)
    {
      aaagroup_intranetip_binding intranetipBinding = new aaagroup_intranetip_binding();
      intranetipBinding.groupname = groupname;
      options option = new options();
      option.set_count(true);
      option.set_filter(filter);
      aaagroup_intranetip_binding[] intranetipBindingArray = (aaagroup_intranetip_binding[]) intranetipBinding.getfiltered(service, option);
      return intranetipBindingArray != null && intranetipBindingArray.Length > 0 ? intranetipBindingArray[0].__count.Value : 0U;
    }

    private class aaagroup_intranetip_binding_response : base_response
    {
      public aaagroup_intranetip_binding[] aaagroup_intranetip_binding = (aaagroup_intranetip_binding[]) null;
    }
  }
}
