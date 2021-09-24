// Decompiled with JetBrains decompiler
// Type: com.citrix.netscaler.nitro.resource.config.cache.cachepolicylabel_policybinding_binding
// Assembly: nitro, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 6CF5DDEF-E052-4F9D-953F-6644F8378A66


using com.citrix.netscaler.nitro.exception;
using com.citrix.netscaler.nitro.resource.Base;
using com.citrix.netscaler.nitro.service;
using com.citrix.netscaler.nitro.util;

namespace com.citrix.netscaler.nitro.resource.config.cache
{
  public class cachepolicylabel_policybinding_binding : base_resource
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

    public string invoke_labelname
    {
      get => this.invoke_labelnameField;
      set => this.invoke_labelnameField = value;
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
      cachepolicylabel_policybinding_binding.cachepolicylabel_policybinding_binding_response policybindingBindingResponse = new cachepolicylabel_policybinding_binding.cachepolicylabel_policybinding_binding_response();
      cachepolicylabel_policybinding_binding.cachepolicylabel_policybinding_binding_response resource = (cachepolicylabel_policybinding_binding.cachepolicylabel_policybinding_binding_response) service.get_payload_formatter().string_to_resource(policybindingBindingResponse.GetType(), response);
      if (resource.errorcode != 0)
      {
        if (resource.errorcode == 444)
          service.clear_session();
        if (resource.severity == null)
          throw new nitro_exception(resource.message, resource.errorcode);
        if (resource.severity.Equals("ERROR"))
          throw new nitro_exception(resource.message, resource.errorcode);
      }
      return (base_resource[]) resource.cachepolicylabel_policybinding_binding;
    }

    internal override string get_object_name() => this.labelname;

    public static cachepolicylabel_policybinding_binding[] get(
      nitro_service service,
      string labelname)
    {
      return (cachepolicylabel_policybinding_binding[]) new cachepolicylabel_policybinding_binding()
      {
        labelname = labelname
      }.get_resources(service, (options) null);
    }

    public static cachepolicylabel_policybinding_binding[] get_filtered(
      nitro_service service,
      string labelname,
      string filter)
    {
      cachepolicylabel_policybinding_binding policybindingBinding = new cachepolicylabel_policybinding_binding();
      policybindingBinding.labelname = labelname;
      options option = new options();
      option.set_filter(filter);
      return (cachepolicylabel_policybinding_binding[]) policybindingBinding.getfiltered(service, option);
    }

    public static cachepolicylabel_policybinding_binding[] get_filtered(
      nitro_service service,
      string labelname,
      filtervalue[] filter)
    {
      cachepolicylabel_policybinding_binding policybindingBinding = new cachepolicylabel_policybinding_binding();
      policybindingBinding.labelname = labelname;
      options option = new options();
      option.set_filter(filter);
      return (cachepolicylabel_policybinding_binding[]) policybindingBinding.getfiltered(service, option);
    }

    public static uint count(nitro_service service, string labelname)
    {
      cachepolicylabel_policybinding_binding policybindingBinding = new cachepolicylabel_policybinding_binding();
      policybindingBinding.labelname = labelname;
      options option = new options();
      option.set_count(true);
      cachepolicylabel_policybinding_binding[] resources = (cachepolicylabel_policybinding_binding[]) policybindingBinding.get_resources(service, option);
      return resources != null && resources.Length > 0 ? resources[0].__count.Value : 0U;
    }

    public static uint count_filtered(nitro_service service, string labelname, string filter)
    {
      cachepolicylabel_policybinding_binding policybindingBinding = new cachepolicylabel_policybinding_binding();
      policybindingBinding.labelname = labelname;
      options option = new options();
      option.set_count(true);
      option.set_filter(filter);
      cachepolicylabel_policybinding_binding[] policybindingBindingArray = (cachepolicylabel_policybinding_binding[]) policybindingBinding.getfiltered(service, option);
      return policybindingBindingArray != null && policybindingBindingArray.Length > 0 ? policybindingBindingArray[0].__count.Value : 0U;
    }

    public static uint count_filtered(
      nitro_service service,
      string labelname,
      filtervalue[] filter)
    {
      cachepolicylabel_policybinding_binding policybindingBinding = new cachepolicylabel_policybinding_binding();
      policybindingBinding.labelname = labelname;
      options option = new options();
      option.set_count(true);
      option.set_filter(filter);
      cachepolicylabel_policybinding_binding[] policybindingBindingArray = (cachepolicylabel_policybinding_binding[]) policybindingBinding.getfiltered(service, option);
      return policybindingBindingArray != null && policybindingBindingArray.Length > 0 ? policybindingBindingArray[0].__count.Value : 0U;
    }

    private class cachepolicylabel_policybinding_binding_response : base_response
    {
      public cachepolicylabel_policybinding_binding[] cachepolicylabel_policybinding_binding = (cachepolicylabel_policybinding_binding[]) null;
    }

    public static class labeltypeEnum
    {
      public const string reqvserver = "reqvserver";
      public const string resvserver = "resvserver";
      public const string policylabel = "policylabel";
    }
  }
}
