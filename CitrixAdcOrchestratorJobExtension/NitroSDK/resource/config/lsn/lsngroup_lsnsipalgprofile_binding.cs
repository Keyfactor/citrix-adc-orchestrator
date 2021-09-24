// Decompiled with JetBrains decompiler
// Type: com.citrix.netscaler.nitro.resource.config.lsn.lsngroup_lsnsipalgprofile_binding
// Assembly: nitro, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 6CF5DDEF-E052-4F9D-953F-6644F8378A66


using com.citrix.netscaler.nitro.exception;
using com.citrix.netscaler.nitro.resource.Base;
using com.citrix.netscaler.nitro.service;
using com.citrix.netscaler.nitro.util;

namespace com.citrix.netscaler.nitro.resource.config.lsn
{
  public class lsngroup_lsnsipalgprofile_binding : base_resource
  {
    private string sipalgprofilenameField = (string) null;
    private string groupnameField = (string) null;
    private uint? __countField = new uint?();

    public uint? __count
    {
      get => this.__countField;
      set => this.__countField = value;
    }

    public string sipalgprofilename
    {
      get => this.sipalgprofilenameField;
      set => this.sipalgprofilenameField = value;
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
      lsngroup_lsnsipalgprofile_binding.lsngroup_lsnsipalgprofile_binding_response lsnsipalgprofileBindingResponse = new lsngroup_lsnsipalgprofile_binding.lsngroup_lsnsipalgprofile_binding_response();
      lsngroup_lsnsipalgprofile_binding.lsngroup_lsnsipalgprofile_binding_response resource = (lsngroup_lsnsipalgprofile_binding.lsngroup_lsnsipalgprofile_binding_response) service.get_payload_formatter().string_to_resource(lsnsipalgprofileBindingResponse.GetType(), response);
      if (resource.errorcode != 0)
      {
        if (resource.errorcode == 444)
          service.clear_session();
        if (resource.severity == null)
          throw new nitro_exception(resource.message, resource.errorcode);
        if (resource.severity.Equals("ERROR"))
          throw new nitro_exception(resource.message, resource.errorcode);
      }
      return (base_resource[]) resource.lsngroup_lsnsipalgprofile_binding;
    }

    internal override string get_object_name() => this.groupname;

    public static base_response add(
      nitro_service client,
      lsngroup_lsnsipalgprofile_binding resource)
    {
      return new lsngroup_lsnsipalgprofile_binding()
      {
        groupname = resource.groupname,
        sipalgprofilename = resource.sipalgprofilename
      }.update_resource(client);
    }

    public static base_responses add(
      nitro_service client,
      lsngroup_lsnsipalgprofile_binding[] resources)
    {
      base_responses baseResponses = (base_responses) null;
      if (resources != null && resources.Length > 0)
      {
        lsngroup_lsnsipalgprofile_binding[] lsnsipalgprofileBindingArray = new lsngroup_lsnsipalgprofile_binding[resources.Length];
        for (int index = 0; index < resources.Length; ++index)
        {
          lsnsipalgprofileBindingArray[index] = new lsngroup_lsnsipalgprofile_binding();
          lsnsipalgprofileBindingArray[index].groupname = resources[index].groupname;
          lsnsipalgprofileBindingArray[index].sipalgprofilename = resources[index].sipalgprofilename;
        }
        baseResponses = base_resource.update_bulk_request(client, (base_resource[]) lsnsipalgprofileBindingArray);
      }
      return baseResponses;
    }

    public static base_response delete(
      nitro_service client,
      lsngroup_lsnsipalgprofile_binding resource)
    {
      return new lsngroup_lsnsipalgprofile_binding()
      {
        groupname = resource.groupname,
        sipalgprofilename = resource.sipalgprofilename
      }.delete_resource(client);
    }

    public static base_responses delete(
      nitro_service client,
      lsngroup_lsnsipalgprofile_binding[] resources)
    {
      base_responses baseResponses = (base_responses) null;
      if (resources != null && resources.Length > 0)
      {
        lsngroup_lsnsipalgprofile_binding[] lsnsipalgprofileBindingArray = new lsngroup_lsnsipalgprofile_binding[resources.Length];
        for (int index = 0; index < resources.Length; ++index)
        {
          lsnsipalgprofileBindingArray[index] = new lsngroup_lsnsipalgprofile_binding();
          lsnsipalgprofileBindingArray[index].groupname = resources[index].groupname;
          lsnsipalgprofileBindingArray[index].sipalgprofilename = resources[index].sipalgprofilename;
        }
        baseResponses = base_resource.delete_bulk_request(client, (base_resource[]) lsnsipalgprofileBindingArray);
      }
      return baseResponses;
    }

    public static lsngroup_lsnsipalgprofile_binding[] get(
      nitro_service service,
      string groupname)
    {
      return (lsngroup_lsnsipalgprofile_binding[]) new lsngroup_lsnsipalgprofile_binding()
      {
        groupname = groupname
      }.get_resources(service, (options) null);
    }

    public static lsngroup_lsnsipalgprofile_binding[] get_filtered(
      nitro_service service,
      string groupname,
      string filter)
    {
      lsngroup_lsnsipalgprofile_binding lsnsipalgprofileBinding = new lsngroup_lsnsipalgprofile_binding();
      lsnsipalgprofileBinding.groupname = groupname;
      options option = new options();
      option.set_filter(filter);
      return (lsngroup_lsnsipalgprofile_binding[]) lsnsipalgprofileBinding.getfiltered(service, option);
    }

    public static lsngroup_lsnsipalgprofile_binding[] get_filtered(
      nitro_service service,
      string groupname,
      filtervalue[] filter)
    {
      lsngroup_lsnsipalgprofile_binding lsnsipalgprofileBinding = new lsngroup_lsnsipalgprofile_binding();
      lsnsipalgprofileBinding.groupname = groupname;
      options option = new options();
      option.set_filter(filter);
      return (lsngroup_lsnsipalgprofile_binding[]) lsnsipalgprofileBinding.getfiltered(service, option);
    }

    public static uint count(nitro_service service, string groupname)
    {
      lsngroup_lsnsipalgprofile_binding lsnsipalgprofileBinding = new lsngroup_lsnsipalgprofile_binding();
      lsnsipalgprofileBinding.groupname = groupname;
      options option = new options();
      option.set_count(true);
      lsngroup_lsnsipalgprofile_binding[] resources = (lsngroup_lsnsipalgprofile_binding[]) lsnsipalgprofileBinding.get_resources(service, option);
      return resources != null && resources.Length > 0 ? resources[0].__count.Value : 0U;
    }

    public static uint count_filtered(nitro_service service, string groupname, string filter)
    {
      lsngroup_lsnsipalgprofile_binding lsnsipalgprofileBinding = new lsngroup_lsnsipalgprofile_binding();
      lsnsipalgprofileBinding.groupname = groupname;
      options option = new options();
      option.set_count(true);
      option.set_filter(filter);
      lsngroup_lsnsipalgprofile_binding[] lsnsipalgprofileBindingArray = (lsngroup_lsnsipalgprofile_binding[]) lsnsipalgprofileBinding.getfiltered(service, option);
      return lsnsipalgprofileBindingArray != null && lsnsipalgprofileBindingArray.Length > 0 ? lsnsipalgprofileBindingArray[0].__count.Value : 0U;
    }

    public static uint count_filtered(
      nitro_service service,
      string groupname,
      filtervalue[] filter)
    {
      lsngroup_lsnsipalgprofile_binding lsnsipalgprofileBinding = new lsngroup_lsnsipalgprofile_binding();
      lsnsipalgprofileBinding.groupname = groupname;
      options option = new options();
      option.set_count(true);
      option.set_filter(filter);
      lsngroup_lsnsipalgprofile_binding[] lsnsipalgprofileBindingArray = (lsngroup_lsnsipalgprofile_binding[]) lsnsipalgprofileBinding.getfiltered(service, option);
      return lsnsipalgprofileBindingArray != null && lsnsipalgprofileBindingArray.Length > 0 ? lsnsipalgprofileBindingArray[0].__count.Value : 0U;
    }

    private class lsngroup_lsnsipalgprofile_binding_response : base_response
    {
      public lsngroup_lsnsipalgprofile_binding[] lsngroup_lsnsipalgprofile_binding = (lsngroup_lsnsipalgprofile_binding[]) null;
    }
  }
}
