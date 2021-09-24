// Decompiled with JetBrains decompiler
// Type: com.citrix.netscaler.nitro.resource.config.responder.responderpolicylabel_responderpolicy_binding
// Assembly: nitro, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 6CF5DDEF-E052-4F9D-953F-6644F8378A66


using com.citrix.netscaler.nitro.exception;
using com.citrix.netscaler.nitro.resource.Base;
using com.citrix.netscaler.nitro.service;
using com.citrix.netscaler.nitro.util;

namespace com.citrix.netscaler.nitro.resource.config.responder
{
  public class responderpolicylabel_responderpolicy_binding : base_resource
  {
    private string policynameField = (string) null;
    private uint? priorityField = new uint?();
    private string gotopriorityexpressionField = (string) null;
    private bool? invokeField = new bool?();
    private string labeltypeField = (string) null;
    private string invoke_labelnameField = (string) null;
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

    public string policyname
    {
      get => this.policynameField;
      set => this.policynameField = value;
    }

    public string labelname
    {
      get => this.labelnameField;
      set => this.labelnameField = value;
    }

    public string invoke_labelname
    {
      get => this.invoke_labelnameField;
      set => this.invoke_labelnameField = value;
    }

    public string gotopriorityexpression
    {
      get => this.gotopriorityexpressionField;
      set => this.gotopriorityexpressionField = value;
    }

    public bool? invoke
    {
      get => this.invokeField;
      set => this.invokeField = value;
    }

    public string labeltype
    {
      get => this.labeltypeField;
      set => this.labeltypeField = value;
    }

    internal override base_resource[] get_nitro_response(
      nitro_service service,
      string response)
    {
      responderpolicylabel_responderpolicy_binding.responderpolicylabel_responderpolicy_binding_response responderpolicyBindingResponse = new responderpolicylabel_responderpolicy_binding.responderpolicylabel_responderpolicy_binding_response();
      responderpolicylabel_responderpolicy_binding.responderpolicylabel_responderpolicy_binding_response resource = (responderpolicylabel_responderpolicy_binding.responderpolicylabel_responderpolicy_binding_response) service.get_payload_formatter().string_to_resource(responderpolicyBindingResponse.GetType(), response);
      if (resource.errorcode != 0)
      {
        if (resource.errorcode == 444)
          service.clear_session();
        if (resource.severity == null)
          throw new nitro_exception(resource.message, resource.errorcode);
        if (resource.severity.Equals("ERROR"))
          throw new nitro_exception(resource.message, resource.errorcode);
      }
      return (base_resource[]) resource.responderpolicylabel_responderpolicy_binding;
    }

    internal override string get_object_name() => this.labelname;

    public static base_response add(
      nitro_service client,
      responderpolicylabel_responderpolicy_binding resource)
    {
      return new responderpolicylabel_responderpolicy_binding()
      {
        labelname = resource.labelname,
        policyname = resource.policyname,
        priority = resource.priority,
        gotopriorityexpression = resource.gotopriorityexpression,
        invoke = resource.invoke,
        labeltype = resource.labeltype,
        invoke_labelname = resource.invoke_labelname
      }.update_resource(client);
    }

    public static base_responses add(
      nitro_service client,
      responderpolicylabel_responderpolicy_binding[] resources)
    {
      base_responses baseResponses = (base_responses) null;
      if (resources != null && resources.Length > 0)
      {
        responderpolicylabel_responderpolicy_binding[] responderpolicyBindingArray = new responderpolicylabel_responderpolicy_binding[resources.Length];
        for (int index = 0; index < resources.Length; ++index)
        {
          responderpolicyBindingArray[index] = new responderpolicylabel_responderpolicy_binding();
          responderpolicyBindingArray[index].labelname = resources[index].labelname;
          responderpolicyBindingArray[index].policyname = resources[index].policyname;
          responderpolicyBindingArray[index].priority = resources[index].priority;
          responderpolicyBindingArray[index].gotopriorityexpression = resources[index].gotopriorityexpression;
          responderpolicyBindingArray[index].invoke = resources[index].invoke;
          responderpolicyBindingArray[index].labeltype = resources[index].labeltype;
          responderpolicyBindingArray[index].invoke_labelname = resources[index].invoke_labelname;
        }
        baseResponses = base_resource.update_bulk_request(client, (base_resource[]) responderpolicyBindingArray);
      }
      return baseResponses;
    }

    public static base_response delete(
      nitro_service client,
      responderpolicylabel_responderpolicy_binding resource)
    {
      return new responderpolicylabel_responderpolicy_binding()
      {
        labelname = resource.labelname,
        policyname = resource.policyname,
        priority = resource.priority
      }.delete_resource(client);
    }

    public static base_responses delete(
      nitro_service client,
      responderpolicylabel_responderpolicy_binding[] resources)
    {
      base_responses baseResponses = (base_responses) null;
      if (resources != null && resources.Length > 0)
      {
        responderpolicylabel_responderpolicy_binding[] responderpolicyBindingArray = new responderpolicylabel_responderpolicy_binding[resources.Length];
        for (int index = 0; index < resources.Length; ++index)
        {
          responderpolicyBindingArray[index] = new responderpolicylabel_responderpolicy_binding();
          responderpolicyBindingArray[index].labelname = resources[index].labelname;
          responderpolicyBindingArray[index].policyname = resources[index].policyname;
          responderpolicyBindingArray[index].priority = resources[index].priority;
        }
        baseResponses = base_resource.delete_bulk_request(client, (base_resource[]) responderpolicyBindingArray);
      }
      return baseResponses;
    }

    public static responderpolicylabel_responderpolicy_binding[] get(
      nitro_service service,
      string labelname)
    {
      return (responderpolicylabel_responderpolicy_binding[]) new responderpolicylabel_responderpolicy_binding()
      {
        labelname = labelname
      }.get_resources(service, (options) null);
    }

    public static responderpolicylabel_responderpolicy_binding[] get_filtered(
      nitro_service service,
      string labelname,
      string filter)
    {
      responderpolicylabel_responderpolicy_binding responderpolicyBinding = new responderpolicylabel_responderpolicy_binding();
      responderpolicyBinding.labelname = labelname;
      options option = new options();
      option.set_filter(filter);
      return (responderpolicylabel_responderpolicy_binding[]) responderpolicyBinding.getfiltered(service, option);
    }

    public static responderpolicylabel_responderpolicy_binding[] get_filtered(
      nitro_service service,
      string labelname,
      filtervalue[] filter)
    {
      responderpolicylabel_responderpolicy_binding responderpolicyBinding = new responderpolicylabel_responderpolicy_binding();
      responderpolicyBinding.labelname = labelname;
      options option = new options();
      option.set_filter(filter);
      return (responderpolicylabel_responderpolicy_binding[]) responderpolicyBinding.getfiltered(service, option);
    }

    public static uint count(nitro_service service, string labelname)
    {
      responderpolicylabel_responderpolicy_binding responderpolicyBinding = new responderpolicylabel_responderpolicy_binding();
      responderpolicyBinding.labelname = labelname;
      options option = new options();
      option.set_count(true);
      responderpolicylabel_responderpolicy_binding[] resources = (responderpolicylabel_responderpolicy_binding[]) responderpolicyBinding.get_resources(service, option);
      return resources != null && resources.Length > 0 ? resources[0].__count.Value : 0U;
    }

    public static uint count_filtered(nitro_service service, string labelname, string filter)
    {
      responderpolicylabel_responderpolicy_binding responderpolicyBinding = new responderpolicylabel_responderpolicy_binding();
      responderpolicyBinding.labelname = labelname;
      options option = new options();
      option.set_count(true);
      option.set_filter(filter);
      responderpolicylabel_responderpolicy_binding[] responderpolicyBindingArray = (responderpolicylabel_responderpolicy_binding[]) responderpolicyBinding.getfiltered(service, option);
      return responderpolicyBindingArray != null && responderpolicyBindingArray.Length > 0 ? responderpolicyBindingArray[0].__count.Value : 0U;
    }

    public static uint count_filtered(
      nitro_service service,
      string labelname,
      filtervalue[] filter)
    {
      responderpolicylabel_responderpolicy_binding responderpolicyBinding = new responderpolicylabel_responderpolicy_binding();
      responderpolicyBinding.labelname = labelname;
      options option = new options();
      option.set_count(true);
      option.set_filter(filter);
      responderpolicylabel_responderpolicy_binding[] responderpolicyBindingArray = (responderpolicylabel_responderpolicy_binding[]) responderpolicyBinding.getfiltered(service, option);
      return responderpolicyBindingArray != null && responderpolicyBindingArray.Length > 0 ? responderpolicyBindingArray[0].__count.Value : 0U;
    }

    private class responderpolicylabel_responderpolicy_binding_response : base_response
    {
      public responderpolicylabel_responderpolicy_binding[] responderpolicylabel_responderpolicy_binding = (responderpolicylabel_responderpolicy_binding[]) null;
    }

    public static class labeltypeEnum
    {
      public const string vserver = "vserver";
      public const string policylabel = "policylabel";
    }
  }
}
