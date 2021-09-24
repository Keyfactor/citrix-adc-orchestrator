// Decompiled with JetBrains decompiler
// Type: com.citrix.netscaler.nitro.resource.config.lsn.lsngroup_lsntransportprofile_binding
// Assembly: nitro, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 6CF5DDEF-E052-4F9D-953F-6644F8378A66


using com.citrix.netscaler.nitro.exception;
using com.citrix.netscaler.nitro.resource.Base;
using com.citrix.netscaler.nitro.service;
using com.citrix.netscaler.nitro.util;

namespace com.citrix.netscaler.nitro.resource.config.lsn
{
  public class lsngroup_lsntransportprofile_binding : base_resource
  {
    private string transportprofilenameField = (string) null;
    private string groupnameField = (string) null;
    private uint? __countField = new uint?();

    public uint? __count
    {
      get => this.__countField;
      set => this.__countField = value;
    }

    public string groupname
    {
      get => this.groupnameField;
      set => this.groupnameField = value;
    }

    public string transportprofilename
    {
      get => this.transportprofilenameField;
      set => this.transportprofilenameField = value;
    }

    internal override base_resource[] get_nitro_response(
      nitro_service service,
      string response)
    {
      lsngroup_lsntransportprofile_binding.lsngroup_lsntransportprofile_binding_response lsntransportprofileBindingResponse = new lsngroup_lsntransportprofile_binding.lsngroup_lsntransportprofile_binding_response();
      lsngroup_lsntransportprofile_binding.lsngroup_lsntransportprofile_binding_response resource = (lsngroup_lsntransportprofile_binding.lsngroup_lsntransportprofile_binding_response) service.get_payload_formatter().string_to_resource(lsntransportprofileBindingResponse.GetType(), response);
      if (resource.errorcode != 0)
      {
        if (resource.errorcode == 444)
          service.clear_session();
        if (resource.severity == null)
          throw new nitro_exception(resource.message, resource.errorcode);
        if (resource.severity.Equals("ERROR"))
          throw new nitro_exception(resource.message, resource.errorcode);
      }
      return (base_resource[]) resource.lsngroup_lsntransportprofile_binding;
    }

    internal override string get_object_name() => this.groupname;

    public static base_response add(
      nitro_service client,
      lsngroup_lsntransportprofile_binding resource)
    {
      return new lsngroup_lsntransportprofile_binding()
      {
        groupname = resource.groupname,
        transportprofilename = resource.transportprofilename
      }.update_resource(client);
    }

    public static base_responses add(
      nitro_service client,
      lsngroup_lsntransportprofile_binding[] resources)
    {
      base_responses baseResponses = (base_responses) null;
      if (resources != null && resources.Length > 0)
      {
        lsngroup_lsntransportprofile_binding[] lsntransportprofileBindingArray = new lsngroup_lsntransportprofile_binding[resources.Length];
        for (int index = 0; index < resources.Length; ++index)
        {
          lsntransportprofileBindingArray[index] = new lsngroup_lsntransportprofile_binding();
          lsntransportprofileBindingArray[index].groupname = resources[index].groupname;
          lsntransportprofileBindingArray[index].transportprofilename = resources[index].transportprofilename;
        }
        baseResponses = base_resource.update_bulk_request(client, (base_resource[]) lsntransportprofileBindingArray);
      }
      return baseResponses;
    }

    public static base_response delete(
      nitro_service client,
      lsngroup_lsntransportprofile_binding resource)
    {
      return new lsngroup_lsntransportprofile_binding()
      {
        groupname = resource.groupname,
        transportprofilename = resource.transportprofilename
      }.delete_resource(client);
    }

    public static base_responses delete(
      nitro_service client,
      lsngroup_lsntransportprofile_binding[] resources)
    {
      base_responses baseResponses = (base_responses) null;
      if (resources != null && resources.Length > 0)
      {
        lsngroup_lsntransportprofile_binding[] lsntransportprofileBindingArray = new lsngroup_lsntransportprofile_binding[resources.Length];
        for (int index = 0; index < resources.Length; ++index)
        {
          lsntransportprofileBindingArray[index] = new lsngroup_lsntransportprofile_binding();
          lsntransportprofileBindingArray[index].groupname = resources[index].groupname;
          lsntransportprofileBindingArray[index].transportprofilename = resources[index].transportprofilename;
        }
        baseResponses = base_resource.delete_bulk_request(client, (base_resource[]) lsntransportprofileBindingArray);
      }
      return baseResponses;
    }

    public static lsngroup_lsntransportprofile_binding[] get(
      nitro_service service,
      string groupname)
    {
      return (lsngroup_lsntransportprofile_binding[]) new lsngroup_lsntransportprofile_binding()
      {
        groupname = groupname
      }.get_resources(service, (options) null);
    }

    public static lsngroup_lsntransportprofile_binding[] get_filtered(
      nitro_service service,
      string groupname,
      string filter)
    {
      lsngroup_lsntransportprofile_binding lsntransportprofileBinding = new lsngroup_lsntransportprofile_binding();
      lsntransportprofileBinding.groupname = groupname;
      options option = new options();
      option.set_filter(filter);
      return (lsngroup_lsntransportprofile_binding[]) lsntransportprofileBinding.getfiltered(service, option);
    }

    public static lsngroup_lsntransportprofile_binding[] get_filtered(
      nitro_service service,
      string groupname,
      filtervalue[] filter)
    {
      lsngroup_lsntransportprofile_binding lsntransportprofileBinding = new lsngroup_lsntransportprofile_binding();
      lsntransportprofileBinding.groupname = groupname;
      options option = new options();
      option.set_filter(filter);
      return (lsngroup_lsntransportprofile_binding[]) lsntransportprofileBinding.getfiltered(service, option);
    }

    public static uint count(nitro_service service, string groupname)
    {
      lsngroup_lsntransportprofile_binding lsntransportprofileBinding = new lsngroup_lsntransportprofile_binding();
      lsntransportprofileBinding.groupname = groupname;
      options option = new options();
      option.set_count(true);
      lsngroup_lsntransportprofile_binding[] resources = (lsngroup_lsntransportprofile_binding[]) lsntransportprofileBinding.get_resources(service, option);
      return resources != null && resources.Length > 0 ? resources[0].__count.Value : 0U;
    }

    public static uint count_filtered(nitro_service service, string groupname, string filter)
    {
      lsngroup_lsntransportprofile_binding lsntransportprofileBinding = new lsngroup_lsntransportprofile_binding();
      lsntransportprofileBinding.groupname = groupname;
      options option = new options();
      option.set_count(true);
      option.set_filter(filter);
      lsngroup_lsntransportprofile_binding[] lsntransportprofileBindingArray = (lsngroup_lsntransportprofile_binding[]) lsntransportprofileBinding.getfiltered(service, option);
      return lsntransportprofileBindingArray != null && lsntransportprofileBindingArray.Length > 0 ? lsntransportprofileBindingArray[0].__count.Value : 0U;
    }

    public static uint count_filtered(
      nitro_service service,
      string groupname,
      filtervalue[] filter)
    {
      lsngroup_lsntransportprofile_binding lsntransportprofileBinding = new lsngroup_lsntransportprofile_binding();
      lsntransportprofileBinding.groupname = groupname;
      options option = new options();
      option.set_count(true);
      option.set_filter(filter);
      lsngroup_lsntransportprofile_binding[] lsntransportprofileBindingArray = (lsngroup_lsntransportprofile_binding[]) lsntransportprofileBinding.getfiltered(service, option);
      return lsntransportprofileBindingArray != null && lsntransportprofileBindingArray.Length > 0 ? lsntransportprofileBindingArray[0].__count.Value : 0U;
    }

    private class lsngroup_lsntransportprofile_binding_response : base_response
    {
      public lsngroup_lsntransportprofile_binding[] lsngroup_lsntransportprofile_binding = (lsngroup_lsntransportprofile_binding[]) null;
    }
  }
}
