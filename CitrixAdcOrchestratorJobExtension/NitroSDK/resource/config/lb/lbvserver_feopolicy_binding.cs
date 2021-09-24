﻿// Decompiled with JetBrains decompiler
// Type: com.citrix.netscaler.nitro.resource.config.lb.lbvserver_feopolicy_binding
// Assembly: nitro, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 6CF5DDEF-E052-4F9D-953F-6644F8378A66


using com.citrix.netscaler.nitro.exception;
using com.citrix.netscaler.nitro.resource.Base;
using com.citrix.netscaler.nitro.service;
using com.citrix.netscaler.nitro.util;

namespace com.citrix.netscaler.nitro.resource.config.lb
{
  public class lbvserver_feopolicy_binding : base_resource
  {
    private string policynameField = (string) null;
    private uint? priorityField = new uint?();
    private string gotopriorityexpressionField = (string) null;
    private string bindpointField = (string) null;
    private string nameField = (string) null;
    private bool? invokeField = new bool?();
    private string labeltypeField = (string) null;
    private string labelnameField = (string) null;
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

    public string name
    {
      get => this.nameField;
      set => this.nameField = value;
    }

    public string bindpoint
    {
      get => this.bindpointField;
      set => this.bindpointField = value;
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

    internal override base_resource[] get_nitro_response(
      nitro_service service,
      string response)
    {
      lbvserver_feopolicy_binding.lbvserver_feopolicy_binding_response feopolicyBindingResponse = new lbvserver_feopolicy_binding.lbvserver_feopolicy_binding_response();
      lbvserver_feopolicy_binding.lbvserver_feopolicy_binding_response resource = (lbvserver_feopolicy_binding.lbvserver_feopolicy_binding_response) service.get_payload_formatter().string_to_resource(feopolicyBindingResponse.GetType(), response);
      if (resource.errorcode != 0)
      {
        if (resource.errorcode == 444)
          service.clear_session();
        if (resource.severity == null)
          throw new nitro_exception(resource.message, resource.errorcode);
        if (resource.severity.Equals("ERROR"))
          throw new nitro_exception(resource.message, resource.errorcode);
      }
      return (base_resource[]) resource.lbvserver_feopolicy_binding;
    }

    internal override string get_object_name() => this.name;

    public static base_response add(
      nitro_service client,
      lbvserver_feopolicy_binding resource)
    {
      return new lbvserver_feopolicy_binding()
      {
        name = resource.name,
        policyname = resource.policyname,
        priority = resource.priority,
        gotopriorityexpression = resource.gotopriorityexpression,
        bindpoint = resource.bindpoint,
        invoke = resource.invoke,
        labeltype = resource.labeltype,
        labelname = resource.labelname
      }.update_resource(client);
    }

    public static base_responses add(
      nitro_service client,
      lbvserver_feopolicy_binding[] resources)
    {
      base_responses baseResponses = (base_responses) null;
      if (resources != null && resources.Length > 0)
      {
        lbvserver_feopolicy_binding[] feopolicyBindingArray = new lbvserver_feopolicy_binding[resources.Length];
        for (int index = 0; index < resources.Length; ++index)
        {
          feopolicyBindingArray[index] = new lbvserver_feopolicy_binding();
          feopolicyBindingArray[index].name = resources[index].name;
          feopolicyBindingArray[index].policyname = resources[index].policyname;
          feopolicyBindingArray[index].priority = resources[index].priority;
          feopolicyBindingArray[index].gotopriorityexpression = resources[index].gotopriorityexpression;
          feopolicyBindingArray[index].bindpoint = resources[index].bindpoint;
          feopolicyBindingArray[index].invoke = resources[index].invoke;
          feopolicyBindingArray[index].labeltype = resources[index].labeltype;
          feopolicyBindingArray[index].labelname = resources[index].labelname;
        }
        baseResponses = base_resource.update_bulk_request(client, (base_resource[]) feopolicyBindingArray);
      }
      return baseResponses;
    }

    public static base_response delete(
      nitro_service client,
      lbvserver_feopolicy_binding resource)
    {
      return new lbvserver_feopolicy_binding()
      {
        name = resource.name,
        policyname = resource.policyname,
        bindpoint = resource.bindpoint,
        priority = resource.priority
      }.delete_resource(client);
    }

    public static base_responses delete(
      nitro_service client,
      lbvserver_feopolicy_binding[] resources)
    {
      base_responses baseResponses = (base_responses) null;
      if (resources != null && resources.Length > 0)
      {
        lbvserver_feopolicy_binding[] feopolicyBindingArray = new lbvserver_feopolicy_binding[resources.Length];
        for (int index = 0; index < resources.Length; ++index)
        {
          feopolicyBindingArray[index] = new lbvserver_feopolicy_binding();
          feopolicyBindingArray[index].name = resources[index].name;
          feopolicyBindingArray[index].policyname = resources[index].policyname;
          feopolicyBindingArray[index].bindpoint = resources[index].bindpoint;
          feopolicyBindingArray[index].priority = resources[index].priority;
        }
        baseResponses = base_resource.delete_bulk_request(client, (base_resource[]) feopolicyBindingArray);
      }
      return baseResponses;
    }

    public static lbvserver_feopolicy_binding[] get(
      nitro_service service,
      string name)
    {
      return (lbvserver_feopolicy_binding[]) new lbvserver_feopolicy_binding()
      {
        name = name
      }.get_resources(service, (options) null);
    }

    public static lbvserver_feopolicy_binding[] get_filtered(
      nitro_service service,
      string name,
      string filter)
    {
      lbvserver_feopolicy_binding feopolicyBinding = new lbvserver_feopolicy_binding();
      feopolicyBinding.name = name;
      options option = new options();
      option.set_filter(filter);
      return (lbvserver_feopolicy_binding[]) feopolicyBinding.getfiltered(service, option);
    }

    public static lbvserver_feopolicy_binding[] get_filtered(
      nitro_service service,
      string name,
      filtervalue[] filter)
    {
      lbvserver_feopolicy_binding feopolicyBinding = new lbvserver_feopolicy_binding();
      feopolicyBinding.name = name;
      options option = new options();
      option.set_filter(filter);
      return (lbvserver_feopolicy_binding[]) feopolicyBinding.getfiltered(service, option);
    }

    public static uint count(nitro_service service, string name)
    {
      lbvserver_feopolicy_binding feopolicyBinding = new lbvserver_feopolicy_binding();
      feopolicyBinding.name = name;
      options option = new options();
      option.set_count(true);
      lbvserver_feopolicy_binding[] resources = (lbvserver_feopolicy_binding[]) feopolicyBinding.get_resources(service, option);
      return resources != null && resources.Length > 0 ? resources[0].__count.Value : 0U;
    }

    public static uint count_filtered(nitro_service service, string name, string filter)
    {
      lbvserver_feopolicy_binding feopolicyBinding = new lbvserver_feopolicy_binding();
      feopolicyBinding.name = name;
      options option = new options();
      option.set_count(true);
      option.set_filter(filter);
      lbvserver_feopolicy_binding[] feopolicyBindingArray = (lbvserver_feopolicy_binding[]) feopolicyBinding.getfiltered(service, option);
      return feopolicyBindingArray != null && feopolicyBindingArray.Length > 0 ? feopolicyBindingArray[0].__count.Value : 0U;
    }

    public static uint count_filtered(nitro_service service, string name, filtervalue[] filter)
    {
      lbvserver_feopolicy_binding feopolicyBinding = new lbvserver_feopolicy_binding();
      feopolicyBinding.name = name;
      options option = new options();
      option.set_count(true);
      option.set_filter(filter);
      lbvserver_feopolicy_binding[] feopolicyBindingArray = (lbvserver_feopolicy_binding[]) feopolicyBinding.getfiltered(service, option);
      return feopolicyBindingArray != null && feopolicyBindingArray.Length > 0 ? feopolicyBindingArray[0].__count.Value : 0U;
    }

    private class lbvserver_feopolicy_binding_response : base_response
    {
      public lbvserver_feopolicy_binding[] lbvserver_feopolicy_binding = (lbvserver_feopolicy_binding[]) null;
    }

    public static class bindpointEnum
    {
      public const string REQUEST = "REQUEST";
      public const string RESPONSE = "RESPONSE";
    }

    public static class labeltypeEnum
    {
      public const string reqvserver = "reqvserver";
      public const string resvserver = "resvserver";
      public const string policylabel = "policylabel";
    }
  }
}
