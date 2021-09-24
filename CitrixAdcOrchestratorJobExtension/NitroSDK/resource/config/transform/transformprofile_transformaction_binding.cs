// Decompiled with JetBrains decompiler
// Type: com.citrix.netscaler.nitro.resource.config.transform.transformprofile_transformaction_binding
// Assembly: nitro, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 6CF5DDEF-E052-4F9D-953F-6644F8378A66


using com.citrix.netscaler.nitro.exception;
using com.citrix.netscaler.nitro.resource.Base;
using com.citrix.netscaler.nitro.service;
using com.citrix.netscaler.nitro.util;

namespace com.citrix.netscaler.nitro.resource.config.transform
{
  public class transformprofile_transformaction_binding : base_resource
  {
    private string actionnameField = (string) null;
    private uint? priorityField = new uint?();
    private string stateField = (string) null;
    private string profilenameField = (string) null;
    private string requrlfromField = (string) null;
    private string requrlintoField = (string) null;
    private string resurlfromField = (string) null;
    private string resurlintoField = (string) null;
    private string cookiedomainfromField = (string) null;
    private string cookiedomainintoField = (string) null;
    private string actioncommentField = (string) null;
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

    public string actionname
    {
      get => this.actionnameField;
      set => this.actionnameField = value;
    }

    public uint? priority
    {
      get => this.priorityField;
      private set => this.priorityField = value;
    }

    public string resurlfrom
    {
      get => this.resurlfromField;
      private set => this.resurlfromField = value;
    }

    public string profilename
    {
      get => this.profilenameField;
      private set => this.profilenameField = value;
    }

    public string state
    {
      get => this.stateField;
      private set => this.stateField = value;
    }

    public string actioncomment
    {
      get => this.actioncommentField;
      private set => this.actioncommentField = value;
    }

    public string requrlinto
    {
      get => this.requrlintoField;
      private set => this.requrlintoField = value;
    }

    public string cookiedomainfrom
    {
      get => this.cookiedomainfromField;
      private set => this.cookiedomainfromField = value;
    }

    public string cookiedomaininto
    {
      get => this.cookiedomainintoField;
      private set => this.cookiedomainintoField = value;
    }

    public string resurlinto
    {
      get => this.resurlintoField;
      private set => this.resurlintoField = value;
    }

    public string requrlfrom
    {
      get => this.requrlfromField;
      private set => this.requrlfromField = value;
    }

    internal override base_resource[] get_nitro_response(
      nitro_service service,
      string response)
    {
      transformprofile_transformaction_binding.transformprofile_transformaction_binding_response transformactionBindingResponse = new transformprofile_transformaction_binding.transformprofile_transformaction_binding_response();
      transformprofile_transformaction_binding.transformprofile_transformaction_binding_response resource = (transformprofile_transformaction_binding.transformprofile_transformaction_binding_response) service.get_payload_formatter().string_to_resource(transformactionBindingResponse.GetType(), response);
      if (resource.errorcode != 0)
      {
        if (resource.errorcode == 444)
          service.clear_session();
        if (resource.severity == null)
          throw new nitro_exception(resource.message, resource.errorcode);
        if (resource.severity.Equals("ERROR"))
          throw new nitro_exception(resource.message, resource.errorcode);
      }
      return (base_resource[]) resource.transformprofile_transformaction_binding;
    }

    internal override string get_object_name() => this.name;

    public static transformprofile_transformaction_binding[] get(
      nitro_service service,
      string name)
    {
      return (transformprofile_transformaction_binding[]) new transformprofile_transformaction_binding()
      {
        name = name
      }.get_resources(service, (options) null);
    }

    public static transformprofile_transformaction_binding[] get_filtered(
      nitro_service service,
      string name,
      string filter)
    {
      transformprofile_transformaction_binding transformactionBinding = new transformprofile_transformaction_binding();
      transformactionBinding.name = name;
      options option = new options();
      option.set_filter(filter);
      return (transformprofile_transformaction_binding[]) transformactionBinding.getfiltered(service, option);
    }

    public static transformprofile_transformaction_binding[] get_filtered(
      nitro_service service,
      string name,
      filtervalue[] filter)
    {
      transformprofile_transformaction_binding transformactionBinding = new transformprofile_transformaction_binding();
      transformactionBinding.name = name;
      options option = new options();
      option.set_filter(filter);
      return (transformprofile_transformaction_binding[]) transformactionBinding.getfiltered(service, option);
    }

    public static uint count(nitro_service service, string name)
    {
      transformprofile_transformaction_binding transformactionBinding = new transformprofile_transformaction_binding();
      transformactionBinding.name = name;
      options option = new options();
      option.set_count(true);
      transformprofile_transformaction_binding[] resources = (transformprofile_transformaction_binding[]) transformactionBinding.get_resources(service, option);
      return resources != null && resources.Length > 0 ? resources[0].__count.Value : 0U;
    }

    public static uint count_filtered(nitro_service service, string name, string filter)
    {
      transformprofile_transformaction_binding transformactionBinding = new transformprofile_transformaction_binding();
      transformactionBinding.name = name;
      options option = new options();
      option.set_count(true);
      option.set_filter(filter);
      transformprofile_transformaction_binding[] transformactionBindingArray = (transformprofile_transformaction_binding[]) transformactionBinding.getfiltered(service, option);
      return transformactionBindingArray != null && transformactionBindingArray.Length > 0 ? transformactionBindingArray[0].__count.Value : 0U;
    }

    public static uint count_filtered(nitro_service service, string name, filtervalue[] filter)
    {
      transformprofile_transformaction_binding transformactionBinding = new transformprofile_transformaction_binding();
      transformactionBinding.name = name;
      options option = new options();
      option.set_count(true);
      option.set_filter(filter);
      transformprofile_transformaction_binding[] transformactionBindingArray = (transformprofile_transformaction_binding[]) transformactionBinding.getfiltered(service, option);
      return transformactionBindingArray != null && transformactionBindingArray.Length > 0 ? transformactionBindingArray[0].__count.Value : 0U;
    }

    private class transformprofile_transformaction_binding_response : base_response
    {
      public transformprofile_transformaction_binding[] transformprofile_transformaction_binding = (transformprofile_transformaction_binding[]) null;
    }

    public static class stateEnum
    {
      public const string ENABLED = "ENABLED";
      public const string DISABLED = "DISABLED";
    }
  }
}
