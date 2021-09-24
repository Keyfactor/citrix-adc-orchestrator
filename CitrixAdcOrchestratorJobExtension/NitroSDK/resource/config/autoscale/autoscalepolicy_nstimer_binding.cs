// Decompiled with JetBrains decompiler
// Type: com.citrix.netscaler.nitro.resource.config.autoscale.autoscalepolicy_nstimer_binding
// Assembly: nitro, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 6CF5DDEF-E052-4F9D-953F-6644F8378A66


using com.citrix.netscaler.nitro.exception;
using com.citrix.netscaler.nitro.resource.Base;
using com.citrix.netscaler.nitro.service;
using com.citrix.netscaler.nitro.util;

namespace com.citrix.netscaler.nitro.resource.config.autoscale
{
  public class autoscalepolicy_nstimer_binding : base_resource
  {
    private string boundtoField = (string) null;
    private uint? priorityField = new uint?();
    private int? activepolicyField = new int?();
    private string gotopriorityexpressionField = (string) null;
    private string nameField = (string) null;
    private uint? __countField = new uint?();

    public uint? __count
    {
      get => this.__countField;
      set => this.__countField = value;
    }

    public string name
    {
      get => this.nameField;
      set => this.nameField = value;
    }

    public string boundto
    {
      get => this.boundtoField;
      set => this.boundtoField = value;
    }

    public uint? priority
    {
      get => this.priorityField;
      private set => this.priorityField = value;
    }

    public string gotopriorityexpression
    {
      get => this.gotopriorityexpressionField;
      private set => this.gotopriorityexpressionField = value;
    }

    public int? activepolicy
    {
      get => this.activepolicyField;
      private set => this.activepolicyField = value;
    }

    internal override base_resource[] get_nitro_response(
      nitro_service service,
      string response)
    {
      autoscalepolicy_nstimer_binding.autoscalepolicy_nstimer_binding_response nstimerBindingResponse = new autoscalepolicy_nstimer_binding.autoscalepolicy_nstimer_binding_response();
      autoscalepolicy_nstimer_binding.autoscalepolicy_nstimer_binding_response resource = (autoscalepolicy_nstimer_binding.autoscalepolicy_nstimer_binding_response) service.get_payload_formatter().string_to_resource(nstimerBindingResponse.GetType(), response);
      if (resource.errorcode != 0)
      {
        if (resource.errorcode == 444)
          service.clear_session();
        if (resource.severity == null)
          throw new nitro_exception(resource.message, resource.errorcode);
        if (resource.severity.Equals("ERROR"))
          throw new nitro_exception(resource.message, resource.errorcode);
      }
      return (base_resource[]) resource.autoscalepolicy_nstimer_binding;
    }

    internal override string get_object_name() => this.name;

    public static autoscalepolicy_nstimer_binding[] get(
      nitro_service service,
      string name)
    {
      return (autoscalepolicy_nstimer_binding[]) new autoscalepolicy_nstimer_binding()
      {
        name = name
      }.get_resources(service, (options) null);
    }

    public static autoscalepolicy_nstimer_binding[] get_filtered(
      nitro_service service,
      string name,
      string filter)
    {
      autoscalepolicy_nstimer_binding autoscalepolicyNstimerBinding = new autoscalepolicy_nstimer_binding();
      autoscalepolicyNstimerBinding.name = name;
      options option = new options();
      option.set_filter(filter);
      return (autoscalepolicy_nstimer_binding[]) autoscalepolicyNstimerBinding.getfiltered(service, option);
    }

    public static autoscalepolicy_nstimer_binding[] get_filtered(
      nitro_service service,
      string name,
      filtervalue[] filter)
    {
      autoscalepolicy_nstimer_binding autoscalepolicyNstimerBinding = new autoscalepolicy_nstimer_binding();
      autoscalepolicyNstimerBinding.name = name;
      options option = new options();
      option.set_filter(filter);
      return (autoscalepolicy_nstimer_binding[]) autoscalepolicyNstimerBinding.getfiltered(service, option);
    }

    public static uint count(nitro_service service, string name)
    {
      autoscalepolicy_nstimer_binding autoscalepolicyNstimerBinding = new autoscalepolicy_nstimer_binding();
      autoscalepolicyNstimerBinding.name = name;
      options option = new options();
      option.set_count(true);
      autoscalepolicy_nstimer_binding[] resources = (autoscalepolicy_nstimer_binding[]) autoscalepolicyNstimerBinding.get_resources(service, option);
      return resources != null && resources.Length > 0 ? resources[0].__count.Value : 0U;
    }

    public static uint count_filtered(nitro_service service, string name, string filter)
    {
      autoscalepolicy_nstimer_binding autoscalepolicyNstimerBinding = new autoscalepolicy_nstimer_binding();
      autoscalepolicyNstimerBinding.name = name;
      options option = new options();
      option.set_count(true);
      option.set_filter(filter);
      autoscalepolicy_nstimer_binding[] autoscalepolicyNstimerBindingArray = (autoscalepolicy_nstimer_binding[]) autoscalepolicyNstimerBinding.getfiltered(service, option);
      return autoscalepolicyNstimerBindingArray != null && autoscalepolicyNstimerBindingArray.Length > 0 ? autoscalepolicyNstimerBindingArray[0].__count.Value : 0U;
    }

    public static uint count_filtered(nitro_service service, string name, filtervalue[] filter)
    {
      autoscalepolicy_nstimer_binding autoscalepolicyNstimerBinding = new autoscalepolicy_nstimer_binding();
      autoscalepolicyNstimerBinding.name = name;
      options option = new options();
      option.set_count(true);
      option.set_filter(filter);
      autoscalepolicy_nstimer_binding[] autoscalepolicyNstimerBindingArray = (autoscalepolicy_nstimer_binding[]) autoscalepolicyNstimerBinding.getfiltered(service, option);
      return autoscalepolicyNstimerBindingArray != null && autoscalepolicyNstimerBindingArray.Length > 0 ? autoscalepolicyNstimerBindingArray[0].__count.Value : 0U;
    }

    private class autoscalepolicy_nstimer_binding_response : base_response
    {
      public autoscalepolicy_nstimer_binding[] autoscalepolicy_nstimer_binding = (autoscalepolicy_nstimer_binding[]) null;
    }
  }
}
