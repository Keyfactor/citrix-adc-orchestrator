// Decompiled with JetBrains decompiler
// Type: com.citrix.netscaler.nitro.resource.config.lsn.lsnclient_nsacl_binding
// Assembly: nitro, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 6CF5DDEF-E052-4F9D-953F-6644F8378A66


using com.citrix.netscaler.nitro.exception;
using com.citrix.netscaler.nitro.resource.Base;
using com.citrix.netscaler.nitro.service;
using com.citrix.netscaler.nitro.util;

namespace com.citrix.netscaler.nitro.resource.config.lsn
{
  public class lsnclient_nsacl_binding : base_resource
  {
    private string aclnameField = (string) null;
    private string clientnameField = (string) null;
    private uint? tdField = new uint?();
    private uint? __countField = new uint?();

    public uint? __count
    {
      get => this.__countField;
      set => this.__countField = value;
    }

    public string clientname
    {
      get => this.clientnameField;
      set => this.clientnameField = value;
    }

    public string aclname
    {
      get => this.aclnameField;
      set => this.aclnameField = value;
    }

    public uint? td
    {
      get => this.tdField;
      set => this.tdField = value;
    }

    internal override base_resource[] get_nitro_response(
      nitro_service service,
      string response)
    {
      lsnclient_nsacl_binding.lsnclient_nsacl_binding_response nsaclBindingResponse = new lsnclient_nsacl_binding.lsnclient_nsacl_binding_response();
      lsnclient_nsacl_binding.lsnclient_nsacl_binding_response resource = (lsnclient_nsacl_binding.lsnclient_nsacl_binding_response) service.get_payload_formatter().string_to_resource(nsaclBindingResponse.GetType(), response);
      if (resource.errorcode != 0)
      {
        if (resource.errorcode == 444)
          service.clear_session();
        if (resource.severity == null)
          throw new nitro_exception(resource.message, resource.errorcode);
        if (resource.severity.Equals("ERROR"))
          throw new nitro_exception(resource.message, resource.errorcode);
      }
      return (base_resource[]) resource.lsnclient_nsacl_binding;
    }

    internal override string get_object_name() => this.clientname;

    public static base_response add(
      nitro_service client,
      lsnclient_nsacl_binding resource)
    {
      return new lsnclient_nsacl_binding()
      {
        clientname = resource.clientname,
        aclname = resource.aclname,
        td = resource.td
      }.update_resource(client);
    }

    public static base_responses add(
      nitro_service client,
      lsnclient_nsacl_binding[] resources)
    {
      base_responses baseResponses = (base_responses) null;
      if (resources != null && resources.Length > 0)
      {
        lsnclient_nsacl_binding[] lsnclientNsaclBindingArray = new lsnclient_nsacl_binding[resources.Length];
        for (int index = 0; index < resources.Length; ++index)
        {
          lsnclientNsaclBindingArray[index] = new lsnclient_nsacl_binding();
          lsnclientNsaclBindingArray[index].clientname = resources[index].clientname;
          lsnclientNsaclBindingArray[index].aclname = resources[index].aclname;
          lsnclientNsaclBindingArray[index].td = resources[index].td;
        }
        baseResponses = base_resource.update_bulk_request(client, (base_resource[]) lsnclientNsaclBindingArray);
      }
      return baseResponses;
    }

    public static base_response delete(
      nitro_service client,
      lsnclient_nsacl_binding resource)
    {
      return new lsnclient_nsacl_binding()
      {
        clientname = resource.clientname,
        aclname = resource.aclname,
        td = resource.td
      }.delete_resource(client);
    }

    public static base_responses delete(
      nitro_service client,
      lsnclient_nsacl_binding[] resources)
    {
      base_responses baseResponses = (base_responses) null;
      if (resources != null && resources.Length > 0)
      {
        lsnclient_nsacl_binding[] lsnclientNsaclBindingArray = new lsnclient_nsacl_binding[resources.Length];
        for (int index = 0; index < resources.Length; ++index)
        {
          lsnclientNsaclBindingArray[index] = new lsnclient_nsacl_binding();
          lsnclientNsaclBindingArray[index].clientname = resources[index].clientname;
          lsnclientNsaclBindingArray[index].aclname = resources[index].aclname;
          lsnclientNsaclBindingArray[index].td = resources[index].td;
        }
        baseResponses = base_resource.delete_bulk_request(client, (base_resource[]) lsnclientNsaclBindingArray);
      }
      return baseResponses;
    }

    public static lsnclient_nsacl_binding[] get(
      nitro_service service,
      string clientname)
    {
      return (lsnclient_nsacl_binding[]) new lsnclient_nsacl_binding()
      {
        clientname = clientname
      }.get_resources(service, (options) null);
    }

    public static lsnclient_nsacl_binding[] get_filtered(
      nitro_service service,
      string clientname,
      string filter)
    {
      lsnclient_nsacl_binding lsnclientNsaclBinding = new lsnclient_nsacl_binding();
      lsnclientNsaclBinding.clientname = clientname;
      options option = new options();
      option.set_filter(filter);
      return (lsnclient_nsacl_binding[]) lsnclientNsaclBinding.getfiltered(service, option);
    }

    public static lsnclient_nsacl_binding[] get_filtered(
      nitro_service service,
      string clientname,
      filtervalue[] filter)
    {
      lsnclient_nsacl_binding lsnclientNsaclBinding = new lsnclient_nsacl_binding();
      lsnclientNsaclBinding.clientname = clientname;
      options option = new options();
      option.set_filter(filter);
      return (lsnclient_nsacl_binding[]) lsnclientNsaclBinding.getfiltered(service, option);
    }

    public static uint count(nitro_service service, string clientname)
    {
      lsnclient_nsacl_binding lsnclientNsaclBinding = new lsnclient_nsacl_binding();
      lsnclientNsaclBinding.clientname = clientname;
      options option = new options();
      option.set_count(true);
      lsnclient_nsacl_binding[] resources = (lsnclient_nsacl_binding[]) lsnclientNsaclBinding.get_resources(service, option);
      return resources != null && resources.Length > 0 ? resources[0].__count.Value : 0U;
    }

    public static uint count_filtered(nitro_service service, string clientname, string filter)
    {
      lsnclient_nsacl_binding lsnclientNsaclBinding = new lsnclient_nsacl_binding();
      lsnclientNsaclBinding.clientname = clientname;
      options option = new options();
      option.set_count(true);
      option.set_filter(filter);
      lsnclient_nsacl_binding[] lsnclientNsaclBindingArray = (lsnclient_nsacl_binding[]) lsnclientNsaclBinding.getfiltered(service, option);
      return lsnclientNsaclBindingArray != null && lsnclientNsaclBindingArray.Length > 0 ? lsnclientNsaclBindingArray[0].__count.Value : 0U;
    }

    public static uint count_filtered(
      nitro_service service,
      string clientname,
      filtervalue[] filter)
    {
      lsnclient_nsacl_binding lsnclientNsaclBinding = new lsnclient_nsacl_binding();
      lsnclientNsaclBinding.clientname = clientname;
      options option = new options();
      option.set_count(true);
      option.set_filter(filter);
      lsnclient_nsacl_binding[] lsnclientNsaclBindingArray = (lsnclient_nsacl_binding[]) lsnclientNsaclBinding.getfiltered(service, option);
      return lsnclientNsaclBindingArray != null && lsnclientNsaclBindingArray.Length > 0 ? lsnclientNsaclBindingArray[0].__count.Value : 0U;
    }

    private class lsnclient_nsacl_binding_response : base_response
    {
      public lsnclient_nsacl_binding[] lsnclient_nsacl_binding = (lsnclient_nsacl_binding[]) null;
    }
  }
}
