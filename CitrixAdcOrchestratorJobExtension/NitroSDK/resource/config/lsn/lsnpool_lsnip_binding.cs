// Decompiled with JetBrains decompiler
// Type: com.citrix.netscaler.nitro.resource.config.lsn.lsnpool_lsnip_binding
// Assembly: nitro, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 6CF5DDEF-E052-4F9D-953F-6644F8378A66


using com.citrix.netscaler.nitro.exception;
using com.citrix.netscaler.nitro.resource.Base;
using com.citrix.netscaler.nitro.service;
using com.citrix.netscaler.nitro.util;

namespace com.citrix.netscaler.nitro.resource.config.lsn
{
  public class lsnpool_lsnip_binding : base_resource
  {
    private string lsnipField = (string) null;
    private string poolnameField = (string) null;
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

    public string lsnip
    {
      get => this.lsnipField;
      set => this.lsnipField = value;
    }

    internal override base_resource[] get_nitro_response(
      nitro_service service,
      string response)
    {
      lsnpool_lsnip_binding.lsnpool_lsnip_binding_response lsnipBindingResponse = new lsnpool_lsnip_binding.lsnpool_lsnip_binding_response();
      lsnpool_lsnip_binding.lsnpool_lsnip_binding_response resource = (lsnpool_lsnip_binding.lsnpool_lsnip_binding_response) service.get_payload_formatter().string_to_resource(lsnipBindingResponse.GetType(), response);
      if (resource.errorcode != 0)
      {
        if (resource.errorcode == 444)
          service.clear_session();
        if (resource.severity == null)
          throw new nitro_exception(resource.message, resource.errorcode);
        if (resource.severity.Equals("ERROR"))
          throw new nitro_exception(resource.message, resource.errorcode);
      }
      return (base_resource[]) resource.lsnpool_lsnip_binding;
    }

    internal override string get_object_name() => this.poolname;

    public static base_response add(
      nitro_service client,
      lsnpool_lsnip_binding resource)
    {
      return new lsnpool_lsnip_binding()
      {
        poolname = resource.poolname,
        lsnip = resource.lsnip
      }.update_resource(client);
    }

    public static base_responses add(
      nitro_service client,
      lsnpool_lsnip_binding[] resources)
    {
      base_responses baseResponses = (base_responses) null;
      if (resources != null && resources.Length > 0)
      {
        lsnpool_lsnip_binding[] lsnpoolLsnipBindingArray = new lsnpool_lsnip_binding[resources.Length];
        for (int index = 0; index < resources.Length; ++index)
        {
          lsnpoolLsnipBindingArray[index] = new lsnpool_lsnip_binding();
          lsnpoolLsnipBindingArray[index].poolname = resources[index].poolname;
          lsnpoolLsnipBindingArray[index].lsnip = resources[index].lsnip;
        }
        baseResponses = base_resource.update_bulk_request(client, (base_resource[]) lsnpoolLsnipBindingArray);
      }
      return baseResponses;
    }

    public static base_response delete(
      nitro_service client,
      lsnpool_lsnip_binding resource)
    {
      return new lsnpool_lsnip_binding()
      {
        poolname = resource.poolname,
        lsnip = resource.lsnip
      }.delete_resource(client);
    }

    public static base_responses delete(
      nitro_service client,
      lsnpool_lsnip_binding[] resources)
    {
      base_responses baseResponses = (base_responses) null;
      if (resources != null && resources.Length > 0)
      {
        lsnpool_lsnip_binding[] lsnpoolLsnipBindingArray = new lsnpool_lsnip_binding[resources.Length];
        for (int index = 0; index < resources.Length; ++index)
        {
          lsnpoolLsnipBindingArray[index] = new lsnpool_lsnip_binding();
          lsnpoolLsnipBindingArray[index].poolname = resources[index].poolname;
          lsnpoolLsnipBindingArray[index].lsnip = resources[index].lsnip;
        }
        baseResponses = base_resource.delete_bulk_request(client, (base_resource[]) lsnpoolLsnipBindingArray);
      }
      return baseResponses;
    }

    public static lsnpool_lsnip_binding[] get(
      nitro_service service,
      string poolname)
    {
      return (lsnpool_lsnip_binding[]) new lsnpool_lsnip_binding()
      {
        poolname = poolname
      }.get_resources(service, (options) null);
    }

    public static lsnpool_lsnip_binding[] get_filtered(
      nitro_service service,
      string poolname,
      string filter)
    {
      lsnpool_lsnip_binding lsnpoolLsnipBinding = new lsnpool_lsnip_binding();
      lsnpoolLsnipBinding.poolname = poolname;
      options option = new options();
      option.set_filter(filter);
      return (lsnpool_lsnip_binding[]) lsnpoolLsnipBinding.getfiltered(service, option);
    }

    public static lsnpool_lsnip_binding[] get_filtered(
      nitro_service service,
      string poolname,
      filtervalue[] filter)
    {
      lsnpool_lsnip_binding lsnpoolLsnipBinding = new lsnpool_lsnip_binding();
      lsnpoolLsnipBinding.poolname = poolname;
      options option = new options();
      option.set_filter(filter);
      return (lsnpool_lsnip_binding[]) lsnpoolLsnipBinding.getfiltered(service, option);
    }

    public static uint count(nitro_service service, string poolname)
    {
      lsnpool_lsnip_binding lsnpoolLsnipBinding = new lsnpool_lsnip_binding();
      lsnpoolLsnipBinding.poolname = poolname;
      options option = new options();
      option.set_count(true);
      lsnpool_lsnip_binding[] resources = (lsnpool_lsnip_binding[]) lsnpoolLsnipBinding.get_resources(service, option);
      return resources != null && resources.Length > 0 ? resources[0].__count.Value : 0U;
    }

    public static uint count_filtered(nitro_service service, string poolname, string filter)
    {
      lsnpool_lsnip_binding lsnpoolLsnipBinding = new lsnpool_lsnip_binding();
      lsnpoolLsnipBinding.poolname = poolname;
      options option = new options();
      option.set_count(true);
      option.set_filter(filter);
      lsnpool_lsnip_binding[] lsnpoolLsnipBindingArray = (lsnpool_lsnip_binding[]) lsnpoolLsnipBinding.getfiltered(service, option);
      return lsnpoolLsnipBindingArray != null && lsnpoolLsnipBindingArray.Length > 0 ? lsnpoolLsnipBindingArray[0].__count.Value : 0U;
    }

    public static uint count_filtered(nitro_service service, string poolname, filtervalue[] filter)
    {
      lsnpool_lsnip_binding lsnpoolLsnipBinding = new lsnpool_lsnip_binding();
      lsnpoolLsnipBinding.poolname = poolname;
      options option = new options();
      option.set_count(true);
      option.set_filter(filter);
      lsnpool_lsnip_binding[] lsnpoolLsnipBindingArray = (lsnpool_lsnip_binding[]) lsnpoolLsnipBinding.getfiltered(service, option);
      return lsnpoolLsnipBindingArray != null && lsnpoolLsnipBindingArray.Length > 0 ? lsnpoolLsnipBindingArray[0].__count.Value : 0U;
    }

    private class lsnpool_lsnip_binding_response : base_response
    {
      public lsnpool_lsnip_binding[] lsnpool_lsnip_binding = (lsnpool_lsnip_binding[]) null;
    }
  }
}
