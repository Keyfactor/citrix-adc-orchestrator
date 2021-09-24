// Decompiled with JetBrains decompiler
// Type: com.citrix.netscaler.nitro.resource.config.lsn.lsngroup_lsnpool_binding
// Assembly: nitro, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 6CF5DDEF-E052-4F9D-953F-6644F8378A66


using com.citrix.netscaler.nitro.exception;
using com.citrix.netscaler.nitro.resource.Base;
using com.citrix.netscaler.nitro.service;
using com.citrix.netscaler.nitro.util;

namespace com.citrix.netscaler.nitro.resource.config.lsn
{
  public class lsngroup_lsnpool_binding : base_resource
  {
    private string poolnameField = (string) null;
    private string groupnameField = (string) null;
    private uint? __countField = new uint?();

    public uint? __count
    {
      get => this.__countField;
      set => this.__countField = value;
    }

    public string poolname
    {
      get => this.poolnameField;
      set => this.poolnameField = value;
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
      lsngroup_lsnpool_binding.lsngroup_lsnpool_binding_response lsnpoolBindingResponse = new lsngroup_lsnpool_binding.lsngroup_lsnpool_binding_response();
      lsngroup_lsnpool_binding.lsngroup_lsnpool_binding_response resource = (lsngroup_lsnpool_binding.lsngroup_lsnpool_binding_response) service.get_payload_formatter().string_to_resource(lsnpoolBindingResponse.GetType(), response);
      if (resource.errorcode != 0)
      {
        if (resource.errorcode == 444)
          service.clear_session();
        if (resource.severity == null)
          throw new nitro_exception(resource.message, resource.errorcode);
        if (resource.severity.Equals("ERROR"))
          throw new nitro_exception(resource.message, resource.errorcode);
      }
      return (base_resource[]) resource.lsngroup_lsnpool_binding;
    }

    internal override string get_object_name() => this.groupname;

    public static base_response add(
      nitro_service client,
      lsngroup_lsnpool_binding resource)
    {
      return new lsngroup_lsnpool_binding()
      {
        groupname = resource.groupname,
        poolname = resource.poolname
      }.update_resource(client);
    }

    public static base_responses add(
      nitro_service client,
      lsngroup_lsnpool_binding[] resources)
    {
      base_responses baseResponses = (base_responses) null;
      if (resources != null && resources.Length > 0)
      {
        lsngroup_lsnpool_binding[] lsngroupLsnpoolBindingArray = new lsngroup_lsnpool_binding[resources.Length];
        for (int index = 0; index < resources.Length; ++index)
        {
          lsngroupLsnpoolBindingArray[index] = new lsngroup_lsnpool_binding();
          lsngroupLsnpoolBindingArray[index].groupname = resources[index].groupname;
          lsngroupLsnpoolBindingArray[index].poolname = resources[index].poolname;
        }
        baseResponses = base_resource.update_bulk_request(client, (base_resource[]) lsngroupLsnpoolBindingArray);
      }
      return baseResponses;
    }

    public static base_response delete(
      nitro_service client,
      lsngroup_lsnpool_binding resource)
    {
      return new lsngroup_lsnpool_binding()
      {
        groupname = resource.groupname,
        poolname = resource.poolname
      }.delete_resource(client);
    }

    public static base_responses delete(
      nitro_service client,
      lsngroup_lsnpool_binding[] resources)
    {
      base_responses baseResponses = (base_responses) null;
      if (resources != null && resources.Length > 0)
      {
        lsngroup_lsnpool_binding[] lsngroupLsnpoolBindingArray = new lsngroup_lsnpool_binding[resources.Length];
        for (int index = 0; index < resources.Length; ++index)
        {
          lsngroupLsnpoolBindingArray[index] = new lsngroup_lsnpool_binding();
          lsngroupLsnpoolBindingArray[index].groupname = resources[index].groupname;
          lsngroupLsnpoolBindingArray[index].poolname = resources[index].poolname;
        }
        baseResponses = base_resource.delete_bulk_request(client, (base_resource[]) lsngroupLsnpoolBindingArray);
      }
      return baseResponses;
    }

    public static lsngroup_lsnpool_binding[] get(
      nitro_service service,
      string groupname)
    {
      return (lsngroup_lsnpool_binding[]) new lsngroup_lsnpool_binding()
      {
        groupname = groupname
      }.get_resources(service, (options) null);
    }

    public static lsngroup_lsnpool_binding[] get_filtered(
      nitro_service service,
      string groupname,
      string filter)
    {
      lsngroup_lsnpool_binding lsngroupLsnpoolBinding = new lsngroup_lsnpool_binding();
      lsngroupLsnpoolBinding.groupname = groupname;
      options option = new options();
      option.set_filter(filter);
      return (lsngroup_lsnpool_binding[]) lsngroupLsnpoolBinding.getfiltered(service, option);
    }

    public static lsngroup_lsnpool_binding[] get_filtered(
      nitro_service service,
      string groupname,
      filtervalue[] filter)
    {
      lsngroup_lsnpool_binding lsngroupLsnpoolBinding = new lsngroup_lsnpool_binding();
      lsngroupLsnpoolBinding.groupname = groupname;
      options option = new options();
      option.set_filter(filter);
      return (lsngroup_lsnpool_binding[]) lsngroupLsnpoolBinding.getfiltered(service, option);
    }

    public static uint count(nitro_service service, string groupname)
    {
      lsngroup_lsnpool_binding lsngroupLsnpoolBinding = new lsngroup_lsnpool_binding();
      lsngroupLsnpoolBinding.groupname = groupname;
      options option = new options();
      option.set_count(true);
      lsngroup_lsnpool_binding[] resources = (lsngroup_lsnpool_binding[]) lsngroupLsnpoolBinding.get_resources(service, option);
      return resources != null && resources.Length > 0 ? resources[0].__count.Value : 0U;
    }

    public static uint count_filtered(nitro_service service, string groupname, string filter)
    {
      lsngroup_lsnpool_binding lsngroupLsnpoolBinding = new lsngroup_lsnpool_binding();
      lsngroupLsnpoolBinding.groupname = groupname;
      options option = new options();
      option.set_count(true);
      option.set_filter(filter);
      lsngroup_lsnpool_binding[] lsngroupLsnpoolBindingArray = (lsngroup_lsnpool_binding[]) lsngroupLsnpoolBinding.getfiltered(service, option);
      return lsngroupLsnpoolBindingArray != null && lsngroupLsnpoolBindingArray.Length > 0 ? lsngroupLsnpoolBindingArray[0].__count.Value : 0U;
    }

    public static uint count_filtered(
      nitro_service service,
      string groupname,
      filtervalue[] filter)
    {
      lsngroup_lsnpool_binding lsngroupLsnpoolBinding = new lsngroup_lsnpool_binding();
      lsngroupLsnpoolBinding.groupname = groupname;
      options option = new options();
      option.set_count(true);
      option.set_filter(filter);
      lsngroup_lsnpool_binding[] lsngroupLsnpoolBindingArray = (lsngroup_lsnpool_binding[]) lsngroupLsnpoolBinding.getfiltered(service, option);
      return lsngroupLsnpoolBindingArray != null && lsngroupLsnpoolBindingArray.Length > 0 ? lsngroupLsnpoolBindingArray[0].__count.Value : 0U;
    }

    private class lsngroup_lsnpool_binding_response : base_response
    {
      public lsngroup_lsnpool_binding[] lsngroup_lsnpool_binding = (lsngroup_lsnpool_binding[]) null;
    }
  }
}
