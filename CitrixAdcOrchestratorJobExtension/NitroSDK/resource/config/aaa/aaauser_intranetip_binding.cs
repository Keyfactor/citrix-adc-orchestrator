// Decompiled with JetBrains decompiler
// Type: com.citrix.netscaler.nitro.resource.config.aaa.aaauser_intranetip_binding
// Assembly: nitro, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 6CF5DDEF-E052-4F9D-953F-6644F8378A66


using com.citrix.netscaler.nitro.exception;
using com.citrix.netscaler.nitro.resource.Base;
using com.citrix.netscaler.nitro.service;
using com.citrix.netscaler.nitro.util;

namespace com.citrix.netscaler.nitro.resource.config.aaa
{
  public class aaauser_intranetip_binding : base_resource
  {
    private string intranetipField = (string) null;
    private string netmaskField = (string) null;
    private string usernameField = (string) null;
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

    public string intranetip
    {
      get => this.intranetipField;
      set => this.intranetipField = value;
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
      aaauser_intranetip_binding.aaauser_intranetip_binding_response intranetipBindingResponse = new aaauser_intranetip_binding.aaauser_intranetip_binding_response();
      aaauser_intranetip_binding.aaauser_intranetip_binding_response resource = (aaauser_intranetip_binding.aaauser_intranetip_binding_response) service.get_payload_formatter().string_to_resource(intranetipBindingResponse.GetType(), response);
      if (resource.errorcode != 0)
      {
        if (resource.errorcode == 444)
          service.clear_session();
        if (resource.severity == null)
          throw new nitro_exception(resource.message, resource.errorcode);
        if (resource.severity.Equals("ERROR"))
          throw new nitro_exception(resource.message, resource.errorcode);
      }
      return (base_resource[]) resource.aaauser_intranetip_binding;
    }

    internal override string get_object_name() => this.username;

    public static base_response add(
      nitro_service client,
      aaauser_intranetip_binding resource)
    {
      return new aaauser_intranetip_binding()
      {
        username = resource.username,
        intranetip = resource.intranetip,
        netmask = resource.netmask,
        gotopriorityexpression = resource.gotopriorityexpression
      }.update_resource(client);
    }

    public static base_responses add(
      nitro_service client,
      aaauser_intranetip_binding[] resources)
    {
      base_responses baseResponses = (base_responses) null;
      if (resources != null && resources.Length > 0)
      {
        aaauser_intranetip_binding[] intranetipBindingArray = new aaauser_intranetip_binding[resources.Length];
        for (int index = 0; index < resources.Length; ++index)
        {
          intranetipBindingArray[index] = new aaauser_intranetip_binding();
          intranetipBindingArray[index].username = resources[index].username;
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
      aaauser_intranetip_binding resource)
    {
      return new aaauser_intranetip_binding()
      {
        username = resource.username,
        intranetip = resource.intranetip,
        netmask = resource.netmask
      }.delete_resource(client);
    }

    public static base_responses delete(
      nitro_service client,
      aaauser_intranetip_binding[] resources)
    {
      base_responses baseResponses = (base_responses) null;
      if (resources != null && resources.Length > 0)
      {
        aaauser_intranetip_binding[] intranetipBindingArray = new aaauser_intranetip_binding[resources.Length];
        for (int index = 0; index < resources.Length; ++index)
        {
          intranetipBindingArray[index] = new aaauser_intranetip_binding();
          intranetipBindingArray[index].username = resources[index].username;
          intranetipBindingArray[index].intranetip = resources[index].intranetip;
          intranetipBindingArray[index].netmask = resources[index].netmask;
        }
        baseResponses = base_resource.delete_bulk_request(client, (base_resource[]) intranetipBindingArray);
      }
      return baseResponses;
    }

    public static aaauser_intranetip_binding[] get(
      nitro_service service,
      string username)
    {
      return (aaauser_intranetip_binding[]) new aaauser_intranetip_binding()
      {
        username = username
      }.get_resources(service, (options) null);
    }

    public static aaauser_intranetip_binding[] get_filtered(
      nitro_service service,
      string username,
      string filter)
    {
      aaauser_intranetip_binding intranetipBinding = new aaauser_intranetip_binding();
      intranetipBinding.username = username;
      options option = new options();
      option.set_filter(filter);
      return (aaauser_intranetip_binding[]) intranetipBinding.getfiltered(service, option);
    }

    public static aaauser_intranetip_binding[] get_filtered(
      nitro_service service,
      string username,
      filtervalue[] filter)
    {
      aaauser_intranetip_binding intranetipBinding = new aaauser_intranetip_binding();
      intranetipBinding.username = username;
      options option = new options();
      option.set_filter(filter);
      return (aaauser_intranetip_binding[]) intranetipBinding.getfiltered(service, option);
    }

    public static uint count(nitro_service service, string username)
    {
      aaauser_intranetip_binding intranetipBinding = new aaauser_intranetip_binding();
      intranetipBinding.username = username;
      options option = new options();
      option.set_count(true);
      aaauser_intranetip_binding[] resources = (aaauser_intranetip_binding[]) intranetipBinding.get_resources(service, option);
      return resources != null && resources.Length > 0 ? resources[0].__count.Value : 0U;
    }

    public static uint count_filtered(nitro_service service, string username, string filter)
    {
      aaauser_intranetip_binding intranetipBinding = new aaauser_intranetip_binding();
      intranetipBinding.username = username;
      options option = new options();
      option.set_count(true);
      option.set_filter(filter);
      aaauser_intranetip_binding[] intranetipBindingArray = (aaauser_intranetip_binding[]) intranetipBinding.getfiltered(service, option);
      return intranetipBindingArray != null && intranetipBindingArray.Length > 0 ? intranetipBindingArray[0].__count.Value : 0U;
    }

    public static uint count_filtered(nitro_service service, string username, filtervalue[] filter)
    {
      aaauser_intranetip_binding intranetipBinding = new aaauser_intranetip_binding();
      intranetipBinding.username = username;
      options option = new options();
      option.set_count(true);
      option.set_filter(filter);
      aaauser_intranetip_binding[] intranetipBindingArray = (aaauser_intranetip_binding[]) intranetipBinding.getfiltered(service, option);
      return intranetipBindingArray != null && intranetipBindingArray.Length > 0 ? intranetipBindingArray[0].__count.Value : 0U;
    }

    private class aaauser_intranetip_binding_response : base_response
    {
      public aaauser_intranetip_binding[] aaauser_intranetip_binding = (aaauser_intranetip_binding[]) null;
    }
  }
}
