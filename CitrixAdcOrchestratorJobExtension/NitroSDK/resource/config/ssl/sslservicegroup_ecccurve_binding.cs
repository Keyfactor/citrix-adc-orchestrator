﻿// Decompiled with JetBrains decompiler
// Type: com.citrix.netscaler.nitro.resource.config.ssl.sslservicegroup_ecccurve_binding
// Assembly: nitro, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 6CF5DDEF-E052-4F9D-953F-6644F8378A66


using com.citrix.netscaler.nitro.exception;
using com.citrix.netscaler.nitro.resource.Base;
using com.citrix.netscaler.nitro.service;
using com.citrix.netscaler.nitro.util;

namespace com.citrix.netscaler.nitro.resource.config.ssl
{
  public class sslservicegroup_ecccurve_binding : base_resource
  {
    private string ecccurvenameField = (string) null;
    private string servicegroupnameField = (string) null;
    private uint? __countField = new uint?();

    public uint? __count
    {
      get => this.__countField;
      set => this.__countField = value;
    }

    public string servicegroupname
    {
      get => this.servicegroupnameField;
      set => this.servicegroupnameField = value;
    }

    public string ecccurvename
    {
      get => this.ecccurvenameField;
      set => this.ecccurvenameField = value;
    }

    internal override base_resource[] get_nitro_response(
      nitro_service service,
      string response)
    {
      sslservicegroup_ecccurve_binding.sslservicegroup_ecccurve_binding_response ecccurveBindingResponse = new sslservicegroup_ecccurve_binding.sslservicegroup_ecccurve_binding_response();
      sslservicegroup_ecccurve_binding.sslservicegroup_ecccurve_binding_response resource = (sslservicegroup_ecccurve_binding.sslservicegroup_ecccurve_binding_response) service.get_payload_formatter().string_to_resource(ecccurveBindingResponse.GetType(), response);
      if (resource.errorcode != 0)
      {
        if (resource.errorcode == 444)
          service.clear_session();
        if (resource.severity == null)
          throw new nitro_exception(resource.message, resource.errorcode);
        if (resource.severity.Equals("ERROR"))
          throw new nitro_exception(resource.message, resource.errorcode);
      }
      return (base_resource[]) resource.sslservicegroup_ecccurve_binding;
    }

    internal override string get_object_name() => this.servicegroupname;

    public static base_response add(
      nitro_service client,
      sslservicegroup_ecccurve_binding resource)
    {
      return new sslservicegroup_ecccurve_binding()
      {
        servicegroupname = resource.servicegroupname,
        ecccurvename = resource.ecccurvename
      }.update_resource(client);
    }

    public static base_responses add(
      nitro_service client,
      sslservicegroup_ecccurve_binding[] resources)
    {
      base_responses baseResponses = (base_responses) null;
      if (resources != null && resources.Length > 0)
      {
        sslservicegroup_ecccurve_binding[] sslservicegroupEcccurveBindingArray = new sslservicegroup_ecccurve_binding[resources.Length];
        for (int index = 0; index < resources.Length; ++index)
        {
          sslservicegroupEcccurveBindingArray[index] = new sslservicegroup_ecccurve_binding();
          sslservicegroupEcccurveBindingArray[index].servicegroupname = resources[index].servicegroupname;
          sslservicegroupEcccurveBindingArray[index].ecccurvename = resources[index].ecccurvename;
        }
        baseResponses = base_resource.update_bulk_request(client, (base_resource[]) sslservicegroupEcccurveBindingArray);
      }
      return baseResponses;
    }

    public static base_response delete(
      nitro_service client,
      sslservicegroup_ecccurve_binding resource)
    {
      return new sslservicegroup_ecccurve_binding()
      {
        servicegroupname = resource.servicegroupname,
        ecccurvename = resource.ecccurvename
      }.delete_resource(client);
    }

    public static base_responses delete(
      nitro_service client,
      sslservicegroup_ecccurve_binding[] resources)
    {
      base_responses baseResponses = (base_responses) null;
      if (resources != null && resources.Length > 0)
      {
        sslservicegroup_ecccurve_binding[] sslservicegroupEcccurveBindingArray = new sslservicegroup_ecccurve_binding[resources.Length];
        for (int index = 0; index < resources.Length; ++index)
        {
          sslservicegroupEcccurveBindingArray[index] = new sslservicegroup_ecccurve_binding();
          sslservicegroupEcccurveBindingArray[index].servicegroupname = resources[index].servicegroupname;
          sslservicegroupEcccurveBindingArray[index].ecccurvename = resources[index].ecccurvename;
        }
        baseResponses = base_resource.delete_bulk_request(client, (base_resource[]) sslservicegroupEcccurveBindingArray);
      }
      return baseResponses;
    }

    public static sslservicegroup_ecccurve_binding[] get(
      nitro_service service,
      string servicegroupname)
    {
      return (sslservicegroup_ecccurve_binding[]) new sslservicegroup_ecccurve_binding()
      {
        servicegroupname = servicegroupname
      }.get_resources(service, (options) null);
    }

    public static sslservicegroup_ecccurve_binding[] get_filtered(
      nitro_service service,
      string servicegroupname,
      string filter)
    {
      sslservicegroup_ecccurve_binding sslservicegroupEcccurveBinding = new sslservicegroup_ecccurve_binding();
      sslservicegroupEcccurveBinding.servicegroupname = servicegroupname;
      options option = new options();
      option.set_filter(filter);
      return (sslservicegroup_ecccurve_binding[]) sslservicegroupEcccurveBinding.getfiltered(service, option);
    }

    public static sslservicegroup_ecccurve_binding[] get_filtered(
      nitro_service service,
      string servicegroupname,
      filtervalue[] filter)
    {
      sslservicegroup_ecccurve_binding sslservicegroupEcccurveBinding = new sslservicegroup_ecccurve_binding();
      sslservicegroupEcccurveBinding.servicegroupname = servicegroupname;
      options option = new options();
      option.set_filter(filter);
      return (sslservicegroup_ecccurve_binding[]) sslservicegroupEcccurveBinding.getfiltered(service, option);
    }

    public static uint count(nitro_service service, string servicegroupname)
    {
      sslservicegroup_ecccurve_binding sslservicegroupEcccurveBinding = new sslservicegroup_ecccurve_binding();
      sslservicegroupEcccurveBinding.servicegroupname = servicegroupname;
      options option = new options();
      option.set_count(true);
      sslservicegroup_ecccurve_binding[] resources = (sslservicegroup_ecccurve_binding[]) sslservicegroupEcccurveBinding.get_resources(service, option);
      return resources != null && resources.Length > 0 ? resources[0].__count.Value : 0U;
    }

    public static uint count_filtered(
      nitro_service service,
      string servicegroupname,
      string filter)
    {
      sslservicegroup_ecccurve_binding sslservicegroupEcccurveBinding = new sslservicegroup_ecccurve_binding();
      sslservicegroupEcccurveBinding.servicegroupname = servicegroupname;
      options option = new options();
      option.set_count(true);
      option.set_filter(filter);
      sslservicegroup_ecccurve_binding[] sslservicegroupEcccurveBindingArray = (sslservicegroup_ecccurve_binding[]) sslservicegroupEcccurveBinding.getfiltered(service, option);
      return sslservicegroupEcccurveBindingArray != null && sslservicegroupEcccurveBindingArray.Length > 0 ? sslservicegroupEcccurveBindingArray[0].__count.Value : 0U;
    }

    public static uint count_filtered(
      nitro_service service,
      string servicegroupname,
      filtervalue[] filter)
    {
      sslservicegroup_ecccurve_binding sslservicegroupEcccurveBinding = new sslservicegroup_ecccurve_binding();
      sslservicegroupEcccurveBinding.servicegroupname = servicegroupname;
      options option = new options();
      option.set_count(true);
      option.set_filter(filter);
      sslservicegroup_ecccurve_binding[] sslservicegroupEcccurveBindingArray = (sslservicegroup_ecccurve_binding[]) sslservicegroupEcccurveBinding.getfiltered(service, option);
      return sslservicegroupEcccurveBindingArray != null && sslservicegroupEcccurveBindingArray.Length > 0 ? sslservicegroupEcccurveBindingArray[0].__count.Value : 0U;
    }

    private class sslservicegroup_ecccurve_binding_response : base_response
    {
      public sslservicegroup_ecccurve_binding[] sslservicegroup_ecccurve_binding = (sslservicegroup_ecccurve_binding[]) null;
    }

    public static class ecccurvenameEnum
    {
      public const string ALL = "ALL";
      public const string P_224 = "P_224";
      public const string P_256 = "P_256";
      public const string P_384 = "P_384";
      public const string P_521 = "P_521";
    }

    public static class crlcheckEnum
    {
      public const string Mandatory = "Mandatory";
      public const string Optional = "Optional";
    }

    public static class ocspcheckEnum
    {
      public const string Mandatory = "Mandatory";
      public const string Optional = "Optional";
    }
  }
}
