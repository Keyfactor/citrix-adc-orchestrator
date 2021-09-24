﻿// Decompiled with JetBrains decompiler
// Type: com.citrix.netscaler.nitro.resource.config.ssl.sslservice_sslpolicy_binding
// Assembly: nitro, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 6CF5DDEF-E052-4F9D-953F-6644F8378A66


using com.citrix.netscaler.nitro.exception;
using com.citrix.netscaler.nitro.resource.Base;
using com.citrix.netscaler.nitro.service;
using com.citrix.netscaler.nitro.util;

namespace com.citrix.netscaler.nitro.resource.config.ssl
{
  public class sslservice_sslpolicy_binding : base_resource
  {
    private string policynameField = (string) null;
    private uint? priorityField = new uint?();
    private uint? polinheritField = new uint?();
    private string gotopriorityexpressionField = (string) null;
    private bool? invokeField = new bool?();
    private string labeltypeField = (string) null;
    private string labelnameField = (string) null;
    private string servicenameField = (string) null;
    private uint? __countField = new uint?();

    public uint? __count
    {
      get => this.__countField;
      set => this.__countField = value;
    }

    public uint? priority
    {
      get => this.priorityField;
      set => this.priorityField = value;
    }

    public string gotopriorityexpression
    {
      get => this.gotopriorityexpressionField;
      set => this.gotopriorityexpressionField = value;
    }

    public string policyname
    {
      get => this.policynameField;
      set => this.policynameField = value;
    }

    public string servicename
    {
      get => this.servicenameField;
      set => this.servicenameField = value;
    }

    public string labeltype
    {
      get => this.labeltypeField;
      set => this.labeltypeField = value;
    }

    public string labelname
    {
      get => this.labelnameField;
      set => this.labelnameField = value;
    }

    public bool? invoke
    {
      get => this.invokeField;
      set => this.invokeField = value;
    }

    public uint? polinherit
    {
      get => this.polinheritField;
      private set => this.polinheritField = value;
    }

    internal override base_resource[] get_nitro_response(
      nitro_service service,
      string response)
    {
      sslservice_sslpolicy_binding.sslservice_sslpolicy_binding_response sslpolicyBindingResponse = new sslservice_sslpolicy_binding.sslservice_sslpolicy_binding_response();
      sslservice_sslpolicy_binding.sslservice_sslpolicy_binding_response resource = (sslservice_sslpolicy_binding.sslservice_sslpolicy_binding_response) service.get_payload_formatter().string_to_resource(sslpolicyBindingResponse.GetType(), response);
      if (resource.errorcode != 0)
      {
        if (resource.errorcode == 444)
          service.clear_session();
        if (resource.severity == null)
          throw new nitro_exception(resource.message, resource.errorcode);
        if (resource.severity.Equals("ERROR"))
          throw new nitro_exception(resource.message, resource.errorcode);
      }
      return (base_resource[]) resource.sslservice_sslpolicy_binding;
    }

    internal override string get_object_name() => this.servicename;

    public static base_response add(
      nitro_service client,
      sslservice_sslpolicy_binding resource)
    {
      return new sslservice_sslpolicy_binding()
      {
        servicename = resource.servicename,
        policyname = resource.policyname,
        priority = resource.priority,
        gotopriorityexpression = resource.gotopriorityexpression,
        invoke = resource.invoke,
        labeltype = resource.labeltype,
        labelname = resource.labelname
      }.update_resource(client);
    }

    public static base_responses add(
      nitro_service client,
      sslservice_sslpolicy_binding[] resources)
    {
      base_responses baseResponses = (base_responses) null;
      if (resources != null && resources.Length > 0)
      {
        sslservice_sslpolicy_binding[] sslpolicyBindingArray = new sslservice_sslpolicy_binding[resources.Length];
        for (int index = 0; index < resources.Length; ++index)
        {
          sslpolicyBindingArray[index] = new sslservice_sslpolicy_binding();
          sslpolicyBindingArray[index].servicename = resources[index].servicename;
          sslpolicyBindingArray[index].policyname = resources[index].policyname;
          sslpolicyBindingArray[index].priority = resources[index].priority;
          sslpolicyBindingArray[index].gotopriorityexpression = resources[index].gotopriorityexpression;
          sslpolicyBindingArray[index].invoke = resources[index].invoke;
          sslpolicyBindingArray[index].labeltype = resources[index].labeltype;
          sslpolicyBindingArray[index].labelname = resources[index].labelname;
        }
        baseResponses = base_resource.update_bulk_request(client, (base_resource[]) sslpolicyBindingArray);
      }
      return baseResponses;
    }

    public static base_response delete(
      nitro_service client,
      sslservice_sslpolicy_binding resource)
    {
      return new sslservice_sslpolicy_binding()
      {
        servicename = resource.servicename,
        policyname = resource.policyname,
        priority = resource.priority
      }.delete_resource(client);
    }

    public static base_responses delete(
      nitro_service client,
      sslservice_sslpolicy_binding[] resources)
    {
      base_responses baseResponses = (base_responses) null;
      if (resources != null && resources.Length > 0)
      {
        sslservice_sslpolicy_binding[] sslpolicyBindingArray = new sslservice_sslpolicy_binding[resources.Length];
        for (int index = 0; index < resources.Length; ++index)
        {
          sslpolicyBindingArray[index] = new sslservice_sslpolicy_binding();
          sslpolicyBindingArray[index].servicename = resources[index].servicename;
          sslpolicyBindingArray[index].policyname = resources[index].policyname;
          sslpolicyBindingArray[index].priority = resources[index].priority;
        }
        baseResponses = base_resource.delete_bulk_request(client, (base_resource[]) sslpolicyBindingArray);
      }
      return baseResponses;
    }

    public static sslservice_sslpolicy_binding[] get(
      nitro_service service,
      string servicename)
    {
      return (sslservice_sslpolicy_binding[]) new sslservice_sslpolicy_binding()
      {
        servicename = servicename
      }.get_resources(service, (options) null);
    }

    public static sslservice_sslpolicy_binding[] get_filtered(
      nitro_service service,
      string servicename,
      string filter)
    {
      sslservice_sslpolicy_binding sslpolicyBinding = new sslservice_sslpolicy_binding();
      sslpolicyBinding.servicename = servicename;
      options option = new options();
      option.set_filter(filter);
      return (sslservice_sslpolicy_binding[]) sslpolicyBinding.getfiltered(service, option);
    }

    public static sslservice_sslpolicy_binding[] get_filtered(
      nitro_service service,
      string servicename,
      filtervalue[] filter)
    {
      sslservice_sslpolicy_binding sslpolicyBinding = new sslservice_sslpolicy_binding();
      sslpolicyBinding.servicename = servicename;
      options option = new options();
      option.set_filter(filter);
      return (sslservice_sslpolicy_binding[]) sslpolicyBinding.getfiltered(service, option);
    }

    public static uint count(nitro_service service, string servicename)
    {
      sslservice_sslpolicy_binding sslpolicyBinding = new sslservice_sslpolicy_binding();
      sslpolicyBinding.servicename = servicename;
      options option = new options();
      option.set_count(true);
      sslservice_sslpolicy_binding[] resources = (sslservice_sslpolicy_binding[]) sslpolicyBinding.get_resources(service, option);
      return resources != null && resources.Length > 0 ? resources[0].__count.Value : 0U;
    }

    public static uint count_filtered(nitro_service service, string servicename, string filter)
    {
      sslservice_sslpolicy_binding sslpolicyBinding = new sslservice_sslpolicy_binding();
      sslpolicyBinding.servicename = servicename;
      options option = new options();
      option.set_count(true);
      option.set_filter(filter);
      sslservice_sslpolicy_binding[] sslpolicyBindingArray = (sslservice_sslpolicy_binding[]) sslpolicyBinding.getfiltered(service, option);
      return sslpolicyBindingArray != null && sslpolicyBindingArray.Length > 0 ? sslpolicyBindingArray[0].__count.Value : 0U;
    }

    public static uint count_filtered(
      nitro_service service,
      string servicename,
      filtervalue[] filter)
    {
      sslservice_sslpolicy_binding sslpolicyBinding = new sslservice_sslpolicy_binding();
      sslpolicyBinding.servicename = servicename;
      options option = new options();
      option.set_count(true);
      option.set_filter(filter);
      sslservice_sslpolicy_binding[] sslpolicyBindingArray = (sslservice_sslpolicy_binding[]) sslpolicyBinding.getfiltered(service, option);
      return sslpolicyBindingArray != null && sslpolicyBindingArray.Length > 0 ? sslpolicyBindingArray[0].__count.Value : 0U;
    }

    private class sslservice_sslpolicy_binding_response : base_response
    {
      public sslservice_sslpolicy_binding[] sslservice_sslpolicy_binding = (sslservice_sslpolicy_binding[]) null;
    }

    public static class ecccurvenameEnum
    {
      public const string ALL = "ALL";
      public const string P_224 = "P_224";
      public const string P_256 = "P_256";
      public const string P_384 = "P_384";
      public const string P_521 = "P_521";
    }

    public static class labeltypeEnum
    {
      public const string vserver = "vserver";
      public const string service = "service";
      public const string policylabel = "policylabel";
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
