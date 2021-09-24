// Decompiled with JetBrains decompiler
// Type: com.citrix.netscaler.nitro.resource.config.aaa.aaagroup_intranetip6_binding
// Assembly: nitro, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 6CF5DDEF-E052-4F9D-953F-6644F8378A66


using com.citrix.netscaler.nitro.exception;
using com.citrix.netscaler.nitro.resource.Base;
using com.citrix.netscaler.nitro.service;
using com.citrix.netscaler.nitro.util;

namespace com.citrix.netscaler.nitro.resource.config.aaa
{
  public class aaagroup_intranetip6_binding : base_resource
  {
    private string intranetip6Field = (string) null;
    private uint? numaddrField = new uint?();
    private string groupnameField = (string) null;
    private string gotopriorityexpressionField = (string) null;
    private uint? __countField = new uint?();

    public uint? __count
    {
      get => this.__countField;
      set => this.__countField = value;
    }

    public string intranetip6
    {
      get => this.intranetip6Field;
      set => this.intranetip6Field = value;
    }

    public string gotopriorityexpression
    {
      get => this.gotopriorityexpressionField;
      set => this.gotopriorityexpressionField = value;
    }

    public uint? numaddr
    {
      get => this.numaddrField;
      set => this.numaddrField = value;
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
      aaagroup_intranetip6_binding.aaagroup_intranetip6_binding_response intranetip6BindingResponse = new aaagroup_intranetip6_binding.aaagroup_intranetip6_binding_response();
      aaagroup_intranetip6_binding.aaagroup_intranetip6_binding_response resource = (aaagroup_intranetip6_binding.aaagroup_intranetip6_binding_response) service.get_payload_formatter().string_to_resource(intranetip6BindingResponse.GetType(), response);
      if (resource.errorcode != 0)
      {
        if (resource.errorcode == 444)
          service.clear_session();
        if (resource.severity == null)
          throw new nitro_exception(resource.message, resource.errorcode);
        if (resource.severity.Equals("ERROR"))
          throw new nitro_exception(resource.message, resource.errorcode);
      }
      return (base_resource[]) resource.aaagroup_intranetip6_binding;
    }

    internal override string get_object_name() => this.groupname;

    public static base_response add(
      nitro_service client,
      aaagroup_intranetip6_binding resource)
    {
      return new aaagroup_intranetip6_binding()
      {
        groupname = resource.groupname,
        gotopriorityexpression = resource.gotopriorityexpression,
        intranetip6 = resource.intranetip6,
        numaddr = resource.numaddr
      }.update_resource(client);
    }

    public static base_responses add(
      nitro_service client,
      aaagroup_intranetip6_binding[] resources)
    {
      base_responses baseResponses = (base_responses) null;
      if (resources != null && resources.Length > 0)
      {
        aaagroup_intranetip6_binding[] intranetip6BindingArray = new aaagroup_intranetip6_binding[resources.Length];
        for (int index = 0; index < resources.Length; ++index)
        {
          intranetip6BindingArray[index] = new aaagroup_intranetip6_binding();
          intranetip6BindingArray[index].groupname = resources[index].groupname;
          intranetip6BindingArray[index].gotopriorityexpression = resources[index].gotopriorityexpression;
          intranetip6BindingArray[index].intranetip6 = resources[index].intranetip6;
          intranetip6BindingArray[index].numaddr = resources[index].numaddr;
        }
        baseResponses = base_resource.update_bulk_request(client, (base_resource[]) intranetip6BindingArray);
      }
      return baseResponses;
    }

    public static base_response delete(
      nitro_service client,
      aaagroup_intranetip6_binding resource)
    {
      return new aaagroup_intranetip6_binding()
      {
        groupname = resource.groupname,
        intranetip6 = resource.intranetip6,
        numaddr = resource.numaddr
      }.delete_resource(client);
    }

    public static base_responses delete(
      nitro_service client,
      aaagroup_intranetip6_binding[] resources)
    {
      base_responses baseResponses = (base_responses) null;
      if (resources != null && resources.Length > 0)
      {
        aaagroup_intranetip6_binding[] intranetip6BindingArray = new aaagroup_intranetip6_binding[resources.Length];
        for (int index = 0; index < resources.Length; ++index)
        {
          intranetip6BindingArray[index] = new aaagroup_intranetip6_binding();
          intranetip6BindingArray[index].groupname = resources[index].groupname;
          intranetip6BindingArray[index].intranetip6 = resources[index].intranetip6;
          intranetip6BindingArray[index].numaddr = resources[index].numaddr;
        }
        baseResponses = base_resource.delete_bulk_request(client, (base_resource[]) intranetip6BindingArray);
      }
      return baseResponses;
    }

    public static aaagroup_intranetip6_binding[] get(
      nitro_service service,
      string groupname)
    {
      return (aaagroup_intranetip6_binding[]) new aaagroup_intranetip6_binding()
      {
        groupname = groupname
      }.get_resources(service, (options) null);
    }

    public static aaagroup_intranetip6_binding[] get_filtered(
      nitro_service service,
      string groupname,
      string filter)
    {
      aaagroup_intranetip6_binding intranetip6Binding = new aaagroup_intranetip6_binding();
      intranetip6Binding.groupname = groupname;
      options option = new options();
      option.set_filter(filter);
      return (aaagroup_intranetip6_binding[]) intranetip6Binding.getfiltered(service, option);
    }

    public static aaagroup_intranetip6_binding[] get_filtered(
      nitro_service service,
      string groupname,
      filtervalue[] filter)
    {
      aaagroup_intranetip6_binding intranetip6Binding = new aaagroup_intranetip6_binding();
      intranetip6Binding.groupname = groupname;
      options option = new options();
      option.set_filter(filter);
      return (aaagroup_intranetip6_binding[]) intranetip6Binding.getfiltered(service, option);
    }

    public static uint count(nitro_service service, string groupname)
    {
      aaagroup_intranetip6_binding intranetip6Binding = new aaagroup_intranetip6_binding();
      intranetip6Binding.groupname = groupname;
      options option = new options();
      option.set_count(true);
      aaagroup_intranetip6_binding[] resources = (aaagroup_intranetip6_binding[]) intranetip6Binding.get_resources(service, option);
      return resources != null && resources.Length > 0 ? resources[0].__count.Value : 0U;
    }

    public static uint count_filtered(nitro_service service, string groupname, string filter)
    {
      aaagroup_intranetip6_binding intranetip6Binding = new aaagroup_intranetip6_binding();
      intranetip6Binding.groupname = groupname;
      options option = new options();
      option.set_count(true);
      option.set_filter(filter);
      aaagroup_intranetip6_binding[] intranetip6BindingArray = (aaagroup_intranetip6_binding[]) intranetip6Binding.getfiltered(service, option);
      return intranetip6BindingArray != null && intranetip6BindingArray.Length > 0 ? intranetip6BindingArray[0].__count.Value : 0U;
    }

    public static uint count_filtered(
      nitro_service service,
      string groupname,
      filtervalue[] filter)
    {
      aaagroup_intranetip6_binding intranetip6Binding = new aaagroup_intranetip6_binding();
      intranetip6Binding.groupname = groupname;
      options option = new options();
      option.set_count(true);
      option.set_filter(filter);
      aaagroup_intranetip6_binding[] intranetip6BindingArray = (aaagroup_intranetip6_binding[]) intranetip6Binding.getfiltered(service, option);
      return intranetip6BindingArray != null && intranetip6BindingArray.Length > 0 ? intranetip6BindingArray[0].__count.Value : 0U;
    }

    private class aaagroup_intranetip6_binding_response : base_response
    {
      public aaagroup_intranetip6_binding[] aaagroup_intranetip6_binding = (aaagroup_intranetip6_binding[]) null;
    }
  }
}
