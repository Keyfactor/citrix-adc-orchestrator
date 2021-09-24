// Decompiled with JetBrains decompiler
// Type: com.citrix.netscaler.nitro.resource.config.aaa.aaagroup_aaauser_binding
// Assembly: nitro, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 6CF5DDEF-E052-4F9D-953F-6644F8378A66


using com.citrix.netscaler.nitro.exception;
using com.citrix.netscaler.nitro.resource.Base;
using com.citrix.netscaler.nitro.service;
using com.citrix.netscaler.nitro.util;

namespace com.citrix.netscaler.nitro.resource.config.aaa
{
  public class aaagroup_aaauser_binding : base_resource
  {
    private string usernameField = (string) null;
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

    public string username
    {
      get => this.usernameField;
      set => this.usernameField = value;
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
      aaagroup_aaauser_binding.aaagroup_aaauser_binding_response aaauserBindingResponse = new aaagroup_aaauser_binding.aaagroup_aaauser_binding_response();
      aaagroup_aaauser_binding.aaagroup_aaauser_binding_response resource = (aaagroup_aaauser_binding.aaagroup_aaauser_binding_response) service.get_payload_formatter().string_to_resource(aaauserBindingResponse.GetType(), response);
      if (resource.errorcode != 0)
      {
        if (resource.errorcode == 444)
          service.clear_session();
        if (resource.severity == null)
          throw new nitro_exception(resource.message, resource.errorcode);
        if (resource.severity.Equals("ERROR"))
          throw new nitro_exception(resource.message, resource.errorcode);
      }
      return (base_resource[]) resource.aaagroup_aaauser_binding;
    }

    internal override string get_object_name() => this.groupname;

    public static base_response add(
      nitro_service client,
      aaagroup_aaauser_binding resource)
    {
      return new aaagroup_aaauser_binding()
      {
        groupname = resource.groupname,
        username = resource.username,
        gotopriorityexpression = resource.gotopriorityexpression
      }.update_resource(client);
    }

    public static base_responses add(
      nitro_service client,
      aaagroup_aaauser_binding[] resources)
    {
      base_responses baseResponses = (base_responses) null;
      if (resources != null && resources.Length > 0)
      {
        aaagroup_aaauser_binding[] aaagroupAaauserBindingArray = new aaagroup_aaauser_binding[resources.Length];
        for (int index = 0; index < resources.Length; ++index)
        {
          aaagroupAaauserBindingArray[index] = new aaagroup_aaauser_binding();
          aaagroupAaauserBindingArray[index].groupname = resources[index].groupname;
          aaagroupAaauserBindingArray[index].username = resources[index].username;
          aaagroupAaauserBindingArray[index].gotopriorityexpression = resources[index].gotopriorityexpression;
        }
        baseResponses = base_resource.update_bulk_request(client, (base_resource[]) aaagroupAaauserBindingArray);
      }
      return baseResponses;
    }

    public static base_response delete(
      nitro_service client,
      aaagroup_aaauser_binding resource)
    {
      return new aaagroup_aaauser_binding()
      {
        groupname = resource.groupname,
        username = resource.username
      }.delete_resource(client);
    }

    public static base_responses delete(
      nitro_service client,
      aaagroup_aaauser_binding[] resources)
    {
      base_responses baseResponses = (base_responses) null;
      if (resources != null && resources.Length > 0)
      {
        aaagroup_aaauser_binding[] aaagroupAaauserBindingArray = new aaagroup_aaauser_binding[resources.Length];
        for (int index = 0; index < resources.Length; ++index)
        {
          aaagroupAaauserBindingArray[index] = new aaagroup_aaauser_binding();
          aaagroupAaauserBindingArray[index].groupname = resources[index].groupname;
          aaagroupAaauserBindingArray[index].username = resources[index].username;
        }
        baseResponses = base_resource.delete_bulk_request(client, (base_resource[]) aaagroupAaauserBindingArray);
      }
      return baseResponses;
    }

    public static aaagroup_aaauser_binding[] get(
      nitro_service service,
      string groupname)
    {
      return (aaagroup_aaauser_binding[]) new aaagroup_aaauser_binding()
      {
        groupname = groupname
      }.get_resources(service, (options) null);
    }

    public static aaagroup_aaauser_binding[] get_filtered(
      nitro_service service,
      string groupname,
      string filter)
    {
      aaagroup_aaauser_binding aaagroupAaauserBinding = new aaagroup_aaauser_binding();
      aaagroupAaauserBinding.groupname = groupname;
      options option = new options();
      option.set_filter(filter);
      return (aaagroup_aaauser_binding[]) aaagroupAaauserBinding.getfiltered(service, option);
    }

    public static aaagroup_aaauser_binding[] get_filtered(
      nitro_service service,
      string groupname,
      filtervalue[] filter)
    {
      aaagroup_aaauser_binding aaagroupAaauserBinding = new aaagroup_aaauser_binding();
      aaagroupAaauserBinding.groupname = groupname;
      options option = new options();
      option.set_filter(filter);
      return (aaagroup_aaauser_binding[]) aaagroupAaauserBinding.getfiltered(service, option);
    }

    public static uint count(nitro_service service, string groupname)
    {
      aaagroup_aaauser_binding aaagroupAaauserBinding = new aaagroup_aaauser_binding();
      aaagroupAaauserBinding.groupname = groupname;
      options option = new options();
      option.set_count(true);
      aaagroup_aaauser_binding[] resources = (aaagroup_aaauser_binding[]) aaagroupAaauserBinding.get_resources(service, option);
      return resources != null && resources.Length > 0 ? resources[0].__count.Value : 0U;
    }

    public static uint count_filtered(nitro_service service, string groupname, string filter)
    {
      aaagroup_aaauser_binding aaagroupAaauserBinding = new aaagroup_aaauser_binding();
      aaagroupAaauserBinding.groupname = groupname;
      options option = new options();
      option.set_count(true);
      option.set_filter(filter);
      aaagroup_aaauser_binding[] aaagroupAaauserBindingArray = (aaagroup_aaauser_binding[]) aaagroupAaauserBinding.getfiltered(service, option);
      return aaagroupAaauserBindingArray != null && aaagroupAaauserBindingArray.Length > 0 ? aaagroupAaauserBindingArray[0].__count.Value : 0U;
    }

    public static uint count_filtered(
      nitro_service service,
      string groupname,
      filtervalue[] filter)
    {
      aaagroup_aaauser_binding aaagroupAaauserBinding = new aaagroup_aaauser_binding();
      aaagroupAaauserBinding.groupname = groupname;
      options option = new options();
      option.set_count(true);
      option.set_filter(filter);
      aaagroup_aaauser_binding[] aaagroupAaauserBindingArray = (aaagroup_aaauser_binding[]) aaagroupAaauserBinding.getfiltered(service, option);
      return aaagroupAaauserBindingArray != null && aaagroupAaauserBindingArray.Length > 0 ? aaagroupAaauserBindingArray[0].__count.Value : 0U;
    }

    private class aaagroup_aaauser_binding_response : base_response
    {
      public aaagroup_aaauser_binding[] aaagroup_aaauser_binding = (aaagroup_aaauser_binding[]) null;
    }
  }
}
