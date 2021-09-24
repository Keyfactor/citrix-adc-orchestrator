﻿// Decompiled with JetBrains decompiler
// Type: com.citrix.netscaler.nitro.resource.config.lsn.lsngroup_lsnlogprofile_binding
// Assembly: nitro, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 6CF5DDEF-E052-4F9D-953F-6644F8378A66


using com.citrix.netscaler.nitro.exception;
using com.citrix.netscaler.nitro.resource.Base;
using com.citrix.netscaler.nitro.service;
using com.citrix.netscaler.nitro.util;

namespace com.citrix.netscaler.nitro.resource.config.lsn
{
  public class lsngroup_lsnlogprofile_binding : base_resource
  {
    private string logprofilenameField = (string) null;
    private string groupnameField = (string) null;
    private uint? __countField = new uint?();

    public uint? __count
    {
      get => this.__countField;
      set => this.__countField = value;
    }

    public string logprofilename
    {
      get => this.logprofilenameField;
      set => this.logprofilenameField = value;
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
      lsngroup_lsnlogprofile_binding.lsngroup_lsnlogprofile_binding_response lsnlogprofileBindingResponse = new lsngroup_lsnlogprofile_binding.lsngroup_lsnlogprofile_binding_response();
      lsngroup_lsnlogprofile_binding.lsngroup_lsnlogprofile_binding_response resource = (lsngroup_lsnlogprofile_binding.lsngroup_lsnlogprofile_binding_response) service.get_payload_formatter().string_to_resource(lsnlogprofileBindingResponse.GetType(), response);
      if (resource.errorcode != 0)
      {
        if (resource.errorcode == 444)
          service.clear_session();
        if (resource.severity == null)
          throw new nitro_exception(resource.message, resource.errorcode);
        if (resource.severity.Equals("ERROR"))
          throw new nitro_exception(resource.message, resource.errorcode);
      }
      return (base_resource[]) resource.lsngroup_lsnlogprofile_binding;
    }

    internal override string get_object_name() => this.groupname;

    public static base_response add(
      nitro_service client,
      lsngroup_lsnlogprofile_binding resource)
    {
      return new lsngroup_lsnlogprofile_binding()
      {
        groupname = resource.groupname,
        logprofilename = resource.logprofilename
      }.update_resource(client);
    }

    public static base_responses add(
      nitro_service client,
      lsngroup_lsnlogprofile_binding[] resources)
    {
      base_responses baseResponses = (base_responses) null;
      if (resources != null && resources.Length > 0)
      {
        lsngroup_lsnlogprofile_binding[] lsnlogprofileBindingArray = new lsngroup_lsnlogprofile_binding[resources.Length];
        for (int index = 0; index < resources.Length; ++index)
        {
          lsnlogprofileBindingArray[index] = new lsngroup_lsnlogprofile_binding();
          lsnlogprofileBindingArray[index].groupname = resources[index].groupname;
          lsnlogprofileBindingArray[index].logprofilename = resources[index].logprofilename;
        }
        baseResponses = base_resource.update_bulk_request(client, (base_resource[]) lsnlogprofileBindingArray);
      }
      return baseResponses;
    }

    public static base_response delete(
      nitro_service client,
      lsngroup_lsnlogprofile_binding resource)
    {
      return new lsngroup_lsnlogprofile_binding()
      {
        groupname = resource.groupname,
        logprofilename = resource.logprofilename
      }.delete_resource(client);
    }

    public static base_responses delete(
      nitro_service client,
      lsngroup_lsnlogprofile_binding[] resources)
    {
      base_responses baseResponses = (base_responses) null;
      if (resources != null && resources.Length > 0)
      {
        lsngroup_lsnlogprofile_binding[] lsnlogprofileBindingArray = new lsngroup_lsnlogprofile_binding[resources.Length];
        for (int index = 0; index < resources.Length; ++index)
        {
          lsnlogprofileBindingArray[index] = new lsngroup_lsnlogprofile_binding();
          lsnlogprofileBindingArray[index].groupname = resources[index].groupname;
          lsnlogprofileBindingArray[index].logprofilename = resources[index].logprofilename;
        }
        baseResponses = base_resource.delete_bulk_request(client, (base_resource[]) lsnlogprofileBindingArray);
      }
      return baseResponses;
    }

    public static lsngroup_lsnlogprofile_binding[] get(
      nitro_service service,
      string groupname)
    {
      return (lsngroup_lsnlogprofile_binding[]) new lsngroup_lsnlogprofile_binding()
      {
        groupname = groupname
      }.get_resources(service, (options) null);
    }

    public static lsngroup_lsnlogprofile_binding[] get_filtered(
      nitro_service service,
      string groupname,
      string filter)
    {
      lsngroup_lsnlogprofile_binding lsnlogprofileBinding = new lsngroup_lsnlogprofile_binding();
      lsnlogprofileBinding.groupname = groupname;
      options option = new options();
      option.set_filter(filter);
      return (lsngroup_lsnlogprofile_binding[]) lsnlogprofileBinding.getfiltered(service, option);
    }

    public static lsngroup_lsnlogprofile_binding[] get_filtered(
      nitro_service service,
      string groupname,
      filtervalue[] filter)
    {
      lsngroup_lsnlogprofile_binding lsnlogprofileBinding = new lsngroup_lsnlogprofile_binding();
      lsnlogprofileBinding.groupname = groupname;
      options option = new options();
      option.set_filter(filter);
      return (lsngroup_lsnlogprofile_binding[]) lsnlogprofileBinding.getfiltered(service, option);
    }

    public static uint count(nitro_service service, string groupname)
    {
      lsngroup_lsnlogprofile_binding lsnlogprofileBinding = new lsngroup_lsnlogprofile_binding();
      lsnlogprofileBinding.groupname = groupname;
      options option = new options();
      option.set_count(true);
      lsngroup_lsnlogprofile_binding[] resources = (lsngroup_lsnlogprofile_binding[]) lsnlogprofileBinding.get_resources(service, option);
      return resources != null && resources.Length > 0 ? resources[0].__count.Value : 0U;
    }

    public static uint count_filtered(nitro_service service, string groupname, string filter)
    {
      lsngroup_lsnlogprofile_binding lsnlogprofileBinding = new lsngroup_lsnlogprofile_binding();
      lsnlogprofileBinding.groupname = groupname;
      options option = new options();
      option.set_count(true);
      option.set_filter(filter);
      lsngroup_lsnlogprofile_binding[] lsnlogprofileBindingArray = (lsngroup_lsnlogprofile_binding[]) lsnlogprofileBinding.getfiltered(service, option);
      return lsnlogprofileBindingArray != null && lsnlogprofileBindingArray.Length > 0 ? lsnlogprofileBindingArray[0].__count.Value : 0U;
    }

    public static uint count_filtered(
      nitro_service service,
      string groupname,
      filtervalue[] filter)
    {
      lsngroup_lsnlogprofile_binding lsnlogprofileBinding = new lsngroup_lsnlogprofile_binding();
      lsnlogprofileBinding.groupname = groupname;
      options option = new options();
      option.set_count(true);
      option.set_filter(filter);
      lsngroup_lsnlogprofile_binding[] lsnlogprofileBindingArray = (lsngroup_lsnlogprofile_binding[]) lsnlogprofileBinding.getfiltered(service, option);
      return lsnlogprofileBindingArray != null && lsnlogprofileBindingArray.Length > 0 ? lsnlogprofileBindingArray[0].__count.Value : 0U;
    }

    private class lsngroup_lsnlogprofile_binding_response : base_response
    {
      public lsngroup_lsnlogprofile_binding[] lsngroup_lsnlogprofile_binding = (lsngroup_lsnlogprofile_binding[]) null;
    }
  }
}
