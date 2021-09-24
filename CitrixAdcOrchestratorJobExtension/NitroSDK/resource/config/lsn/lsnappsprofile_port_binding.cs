// Decompiled with JetBrains decompiler
// Type: com.citrix.netscaler.nitro.resource.config.lsn.lsnappsprofile_port_binding
// Assembly: nitro, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 6CF5DDEF-E052-4F9D-953F-6644F8378A66


using com.citrix.netscaler.nitro.exception;
using com.citrix.netscaler.nitro.resource.Base;
using com.citrix.netscaler.nitro.service;
using com.citrix.netscaler.nitro.util;

namespace com.citrix.netscaler.nitro.resource.config.lsn
{
  public class lsnappsprofile_port_binding : base_resource
  {
    private string lsnportField = (string) null;
    private string appsprofilenameField = (string) null;
    private uint? __countField = new uint?();

    public uint? __count
    {
      get => this.__countField;
      set => this.__countField = value;
    }

    public string appsprofilename
    {
      get => this.appsprofilenameField;
      set => this.appsprofilenameField = value;
    }

    public string lsnport
    {
      get => this.lsnportField;
      set => this.lsnportField = value;
    }

    internal override base_resource[] get_nitro_response(
      nitro_service service,
      string response)
    {
      lsnappsprofile_port_binding.lsnappsprofile_port_binding_response portBindingResponse = new lsnappsprofile_port_binding.lsnappsprofile_port_binding_response();
      lsnappsprofile_port_binding.lsnappsprofile_port_binding_response resource = (lsnappsprofile_port_binding.lsnappsprofile_port_binding_response) service.get_payload_formatter().string_to_resource(portBindingResponse.GetType(), response);
      if (resource.errorcode != 0)
      {
        if (resource.errorcode == 444)
          service.clear_session();
        if (resource.severity == null)
          throw new nitro_exception(resource.message, resource.errorcode);
        if (resource.severity.Equals("ERROR"))
          throw new nitro_exception(resource.message, resource.errorcode);
      }
      return (base_resource[]) resource.lsnappsprofile_port_binding;
    }

    internal override string get_object_name() => this.appsprofilename;

    public static base_response add(
      nitro_service client,
      lsnappsprofile_port_binding resource)
    {
      return new lsnappsprofile_port_binding()
      {
        appsprofilename = resource.appsprofilename,
        lsnport = resource.lsnport
      }.update_resource(client);
    }

    public static base_responses add(
      nitro_service client,
      lsnappsprofile_port_binding[] resources)
    {
      base_responses baseResponses = (base_responses) null;
      if (resources != null && resources.Length > 0)
      {
        lsnappsprofile_port_binding[] lsnappsprofilePortBindingArray = new lsnappsprofile_port_binding[resources.Length];
        for (int index = 0; index < resources.Length; ++index)
        {
          lsnappsprofilePortBindingArray[index] = new lsnappsprofile_port_binding();
          lsnappsprofilePortBindingArray[index].appsprofilename = resources[index].appsprofilename;
          lsnappsprofilePortBindingArray[index].lsnport = resources[index].lsnport;
        }
        baseResponses = base_resource.update_bulk_request(client, (base_resource[]) lsnappsprofilePortBindingArray);
      }
      return baseResponses;
    }

    public static base_response delete(
      nitro_service client,
      lsnappsprofile_port_binding resource)
    {
      return new lsnappsprofile_port_binding()
      {
        appsprofilename = resource.appsprofilename,
        lsnport = resource.lsnport
      }.delete_resource(client);
    }

    public static base_responses delete(
      nitro_service client,
      lsnappsprofile_port_binding[] resources)
    {
      base_responses baseResponses = (base_responses) null;
      if (resources != null && resources.Length > 0)
      {
        lsnappsprofile_port_binding[] lsnappsprofilePortBindingArray = new lsnappsprofile_port_binding[resources.Length];
        for (int index = 0; index < resources.Length; ++index)
        {
          lsnappsprofilePortBindingArray[index] = new lsnappsprofile_port_binding();
          lsnappsprofilePortBindingArray[index].appsprofilename = resources[index].appsprofilename;
          lsnappsprofilePortBindingArray[index].lsnport = resources[index].lsnport;
        }
        baseResponses = base_resource.delete_bulk_request(client, (base_resource[]) lsnappsprofilePortBindingArray);
      }
      return baseResponses;
    }

    public static lsnappsprofile_port_binding[] get(
      nitro_service service,
      string appsprofilename)
    {
      return (lsnappsprofile_port_binding[]) new lsnappsprofile_port_binding()
      {
        appsprofilename = appsprofilename
      }.get_resources(service, (options) null);
    }

    public static lsnappsprofile_port_binding[] get_filtered(
      nitro_service service,
      string appsprofilename,
      string filter)
    {
      lsnappsprofile_port_binding lsnappsprofilePortBinding = new lsnappsprofile_port_binding();
      lsnappsprofilePortBinding.appsprofilename = appsprofilename;
      options option = new options();
      option.set_filter(filter);
      return (lsnappsprofile_port_binding[]) lsnappsprofilePortBinding.getfiltered(service, option);
    }

    public static lsnappsprofile_port_binding[] get_filtered(
      nitro_service service,
      string appsprofilename,
      filtervalue[] filter)
    {
      lsnappsprofile_port_binding lsnappsprofilePortBinding = new lsnappsprofile_port_binding();
      lsnappsprofilePortBinding.appsprofilename = appsprofilename;
      options option = new options();
      option.set_filter(filter);
      return (lsnappsprofile_port_binding[]) lsnappsprofilePortBinding.getfiltered(service, option);
    }

    public static uint count(nitro_service service, string appsprofilename)
    {
      lsnappsprofile_port_binding lsnappsprofilePortBinding = new lsnappsprofile_port_binding();
      lsnappsprofilePortBinding.appsprofilename = appsprofilename;
      options option = new options();
      option.set_count(true);
      lsnappsprofile_port_binding[] resources = (lsnappsprofile_port_binding[]) lsnappsprofilePortBinding.get_resources(service, option);
      return resources != null && resources.Length > 0 ? resources[0].__count.Value : 0U;
    }

    public static uint count_filtered(nitro_service service, string appsprofilename, string filter)
    {
      lsnappsprofile_port_binding lsnappsprofilePortBinding = new lsnappsprofile_port_binding();
      lsnappsprofilePortBinding.appsprofilename = appsprofilename;
      options option = new options();
      option.set_count(true);
      option.set_filter(filter);
      lsnappsprofile_port_binding[] lsnappsprofilePortBindingArray = (lsnappsprofile_port_binding[]) lsnappsprofilePortBinding.getfiltered(service, option);
      return lsnappsprofilePortBindingArray != null && lsnappsprofilePortBindingArray.Length > 0 ? lsnappsprofilePortBindingArray[0].__count.Value : 0U;
    }

    public static uint count_filtered(
      nitro_service service,
      string appsprofilename,
      filtervalue[] filter)
    {
      lsnappsprofile_port_binding lsnappsprofilePortBinding = new lsnappsprofile_port_binding();
      lsnappsprofilePortBinding.appsprofilename = appsprofilename;
      options option = new options();
      option.set_count(true);
      option.set_filter(filter);
      lsnappsprofile_port_binding[] lsnappsprofilePortBindingArray = (lsnappsprofile_port_binding[]) lsnappsprofilePortBinding.getfiltered(service, option);
      return lsnappsprofilePortBindingArray != null && lsnappsprofilePortBindingArray.Length > 0 ? lsnappsprofilePortBindingArray[0].__count.Value : 0U;
    }

    private class lsnappsprofile_port_binding_response : base_response
    {
      public lsnappsprofile_port_binding[] lsnappsprofile_port_binding = (lsnappsprofile_port_binding[]) null;
    }
  }
}
