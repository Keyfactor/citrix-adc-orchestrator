// Decompiled with JetBrains decompiler
// Type: com.citrix.netscaler.nitro.resource.config.ns.nstimer_autoscalepolicy_binding
// Assembly: nitro, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 6CF5DDEF-E052-4F9D-953F-6644F8378A66


using com.citrix.netscaler.nitro.exception;
using com.citrix.netscaler.nitro.resource.Base;
using com.citrix.netscaler.nitro.service;
using com.citrix.netscaler.nitro.util;

namespace com.citrix.netscaler.nitro.resource.config.ns
{
  public class nstimer_autoscalepolicy_binding : base_resource
  {
    private string policynameField = (string) null;
    private uint? priorityField = new uint?();
    private string gotopriorityexpressionField = (string) null;
    private string vserverField = (string) null;
    private uint? samplesizeField = new uint?();
    private uint? thresholdField = new uint?();
    private string nameField = (string) null;
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

    public uint? threshold
    {
      get => this.thresholdField;
      set => this.thresholdField = value;
    }

    public uint? samplesize
    {
      get => this.samplesizeField;
      set => this.samplesizeField = value;
    }

    public string vserver
    {
      get => this.vserverField;
      set => this.vserverField = value;
    }

    internal override base_resource[] get_nitro_response(
      nitro_service service,
      string response)
    {
      nstimer_autoscalepolicy_binding.nstimer_autoscalepolicy_binding_response autoscalepolicyBindingResponse = new nstimer_autoscalepolicy_binding.nstimer_autoscalepolicy_binding_response();
      nstimer_autoscalepolicy_binding.nstimer_autoscalepolicy_binding_response resource = (nstimer_autoscalepolicy_binding.nstimer_autoscalepolicy_binding_response) service.get_payload_formatter().string_to_resource(autoscalepolicyBindingResponse.GetType(), response);
      if (resource.errorcode != 0)
      {
        if (resource.errorcode == 444)
          service.clear_session();
        if (resource.severity == null)
          throw new nitro_exception(resource.message, resource.errorcode);
        if (resource.severity.Equals("ERROR"))
          throw new nitro_exception(resource.message, resource.errorcode);
      }
      return (base_resource[]) resource.nstimer_autoscalepolicy_binding;
    }

    internal override string get_object_name() => this.name;

    public static base_response add(
      nitro_service client,
      nstimer_autoscalepolicy_binding resource)
    {
      return new nstimer_autoscalepolicy_binding()
      {
        name = resource.name,
        policyname = resource.policyname,
        priority = resource.priority,
        gotopriorityexpression = resource.gotopriorityexpression,
        vserver = resource.vserver,
        samplesize = resource.samplesize,
        threshold = resource.threshold
      }.update_resource(client);
    }

    public static base_responses add(
      nitro_service client,
      nstimer_autoscalepolicy_binding[] resources)
    {
      base_responses baseResponses = (base_responses) null;
      if (resources != null && resources.Length > 0)
      {
        nstimer_autoscalepolicy_binding[] autoscalepolicyBindingArray = new nstimer_autoscalepolicy_binding[resources.Length];
        for (int index = 0; index < resources.Length; ++index)
        {
          autoscalepolicyBindingArray[index] = new nstimer_autoscalepolicy_binding();
          autoscalepolicyBindingArray[index].name = resources[index].name;
          autoscalepolicyBindingArray[index].policyname = resources[index].policyname;
          autoscalepolicyBindingArray[index].priority = resources[index].priority;
          autoscalepolicyBindingArray[index].gotopriorityexpression = resources[index].gotopriorityexpression;
          autoscalepolicyBindingArray[index].vserver = resources[index].vserver;
          autoscalepolicyBindingArray[index].samplesize = resources[index].samplesize;
          autoscalepolicyBindingArray[index].threshold = resources[index].threshold;
        }
        baseResponses = base_resource.update_bulk_request(client, (base_resource[]) autoscalepolicyBindingArray);
      }
      return baseResponses;
    }

    public static base_response delete(
      nitro_service client,
      nstimer_autoscalepolicy_binding resource)
    {
      return new nstimer_autoscalepolicy_binding()
      {
        name = resource.name,
        policyname = resource.policyname
      }.delete_resource(client);
    }

    public static base_responses delete(
      nitro_service client,
      nstimer_autoscalepolicy_binding[] resources)
    {
      base_responses baseResponses = (base_responses) null;
      if (resources != null && resources.Length > 0)
      {
        nstimer_autoscalepolicy_binding[] autoscalepolicyBindingArray = new nstimer_autoscalepolicy_binding[resources.Length];
        for (int index = 0; index < resources.Length; ++index)
        {
          autoscalepolicyBindingArray[index] = new nstimer_autoscalepolicy_binding();
          autoscalepolicyBindingArray[index].name = resources[index].name;
          autoscalepolicyBindingArray[index].policyname = resources[index].policyname;
        }
        baseResponses = base_resource.delete_bulk_request(client, (base_resource[]) autoscalepolicyBindingArray);
      }
      return baseResponses;
    }

    public static nstimer_autoscalepolicy_binding[] get(
      nitro_service service,
      string name)
    {
      return (nstimer_autoscalepolicy_binding[]) new nstimer_autoscalepolicy_binding()
      {
        name = name
      }.get_resources(service, (options) null);
    }

    public static nstimer_autoscalepolicy_binding[] get_filtered(
      nitro_service service,
      string name,
      string filter)
    {
      nstimer_autoscalepolicy_binding autoscalepolicyBinding = new nstimer_autoscalepolicy_binding();
      autoscalepolicyBinding.name = name;
      options option = new options();
      option.set_filter(filter);
      return (nstimer_autoscalepolicy_binding[]) autoscalepolicyBinding.getfiltered(service, option);
    }

    public static nstimer_autoscalepolicy_binding[] get_filtered(
      nitro_service service,
      string name,
      filtervalue[] filter)
    {
      nstimer_autoscalepolicy_binding autoscalepolicyBinding = new nstimer_autoscalepolicy_binding();
      autoscalepolicyBinding.name = name;
      options option = new options();
      option.set_filter(filter);
      return (nstimer_autoscalepolicy_binding[]) autoscalepolicyBinding.getfiltered(service, option);
    }

    public static uint count(nitro_service service, string name)
    {
      nstimer_autoscalepolicy_binding autoscalepolicyBinding = new nstimer_autoscalepolicy_binding();
      autoscalepolicyBinding.name = name;
      options option = new options();
      option.set_count(true);
      nstimer_autoscalepolicy_binding[] resources = (nstimer_autoscalepolicy_binding[]) autoscalepolicyBinding.get_resources(service, option);
      return resources != null && resources.Length > 0 ? resources[0].__count.Value : 0U;
    }

    public static uint count_filtered(nitro_service service, string name, string filter)
    {
      nstimer_autoscalepolicy_binding autoscalepolicyBinding = new nstimer_autoscalepolicy_binding();
      autoscalepolicyBinding.name = name;
      options option = new options();
      option.set_count(true);
      option.set_filter(filter);
      nstimer_autoscalepolicy_binding[] autoscalepolicyBindingArray = (nstimer_autoscalepolicy_binding[]) autoscalepolicyBinding.getfiltered(service, option);
      return autoscalepolicyBindingArray != null && autoscalepolicyBindingArray.Length > 0 ? autoscalepolicyBindingArray[0].__count.Value : 0U;
    }

    public static uint count_filtered(nitro_service service, string name, filtervalue[] filter)
    {
      nstimer_autoscalepolicy_binding autoscalepolicyBinding = new nstimer_autoscalepolicy_binding();
      autoscalepolicyBinding.name = name;
      options option = new options();
      option.set_count(true);
      option.set_filter(filter);
      nstimer_autoscalepolicy_binding[] autoscalepolicyBindingArray = (nstimer_autoscalepolicy_binding[]) autoscalepolicyBinding.getfiltered(service, option);
      return autoscalepolicyBindingArray != null && autoscalepolicyBindingArray.Length > 0 ? autoscalepolicyBindingArray[0].__count.Value : 0U;
    }

    private class nstimer_autoscalepolicy_binding_response : base_response
    {
      public nstimer_autoscalepolicy_binding[] nstimer_autoscalepolicy_binding = (nstimer_autoscalepolicy_binding[]) null;
    }
  }
}
