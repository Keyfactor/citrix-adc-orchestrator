// Decompiled with JetBrains decompiler
// Type: com.citrix.netscaler.nitro.resource.config.authentication.authenticationloginschemapolicy_authenticationvserver_binding
// Assembly: nitro, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 6CF5DDEF-E052-4F9D-953F-6644F8378A66


using com.citrix.netscaler.nitro.exception;
using com.citrix.netscaler.nitro.resource.Base;
using com.citrix.netscaler.nitro.service;
using com.citrix.netscaler.nitro.util;

namespace com.citrix.netscaler.nitro.resource.config.authentication
{
  public class authenticationloginschemapolicy_authenticationvserver_binding : base_resource
  {
    private string boundtoField = (string) null;
    private uint? priorityField = new uint?();
    private uint? activepolicyField = new uint?();
    private string gotopriorityexpressionField = (string) null;
    private string labeltypeField = (string) null;
    private string labelnameField = (string) null;
    private string nameField = (string) null;
    private uint? __countField = new uint?();

    public uint? __count
    {
      get => this.__countField;
      set => this.__countField = value;
    }

    public string boundto
    {
      get => this.boundtoField;
      set => this.boundtoField = value;
    }

    public string name
    {
      get => this.nameField;
      set => this.nameField = value;
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

    public string labeltype
    {
      get => this.labeltypeField;
      private set => this.labeltypeField = value;
    }

    public uint? activepolicy
    {
      get => this.activepolicyField;
      private set => this.activepolicyField = value;
    }

    public string labelname
    {
      get => this.labelnameField;
      private set => this.labelnameField = value;
    }

    internal override base_resource[] get_nitro_response(
      nitro_service service,
      string response)
    {
      authenticationloginschemapolicy_authenticationvserver_binding.authenticationloginschemapolicy_authenticationvserver_binding_response authenticationvserverBindingResponse = new authenticationloginschemapolicy_authenticationvserver_binding.authenticationloginschemapolicy_authenticationvserver_binding_response();
      authenticationloginschemapolicy_authenticationvserver_binding.authenticationloginschemapolicy_authenticationvserver_binding_response resource = (authenticationloginschemapolicy_authenticationvserver_binding.authenticationloginschemapolicy_authenticationvserver_binding_response) service.get_payload_formatter().string_to_resource(authenticationvserverBindingResponse.GetType(), response);
      if (resource.errorcode != 0)
      {
        if (resource.errorcode == 444)
          service.clear_session();
        if (resource.severity == null)
          throw new nitro_exception(resource.message, resource.errorcode);
        if (resource.severity.Equals("ERROR"))
          throw new nitro_exception(resource.message, resource.errorcode);
      }
      return (base_resource[]) resource.authenticationloginschemapolicy_authenticationvserver_binding;
    }

    internal override string get_object_name() => this.name;

    public static authenticationloginschemapolicy_authenticationvserver_binding[] get(
      nitro_service service,
      string name)
    {
      return (authenticationloginschemapolicy_authenticationvserver_binding[]) new authenticationloginschemapolicy_authenticationvserver_binding()
      {
        name = name
      }.get_resources(service, (options) null);
    }

    public static authenticationloginschemapolicy_authenticationvserver_binding[] get_filtered(
      nitro_service service,
      string name,
      string filter)
    {
      authenticationloginschemapolicy_authenticationvserver_binding authenticationvserverBinding = new authenticationloginschemapolicy_authenticationvserver_binding();
      authenticationvserverBinding.name = name;
      options option = new options();
      option.set_filter(filter);
      return (authenticationloginschemapolicy_authenticationvserver_binding[]) authenticationvserverBinding.getfiltered(service, option);
    }

    public static authenticationloginschemapolicy_authenticationvserver_binding[] get_filtered(
      nitro_service service,
      string name,
      filtervalue[] filter)
    {
      authenticationloginschemapolicy_authenticationvserver_binding authenticationvserverBinding = new authenticationloginschemapolicy_authenticationvserver_binding();
      authenticationvserverBinding.name = name;
      options option = new options();
      option.set_filter(filter);
      return (authenticationloginschemapolicy_authenticationvserver_binding[]) authenticationvserverBinding.getfiltered(service, option);
    }

    public static uint count(nitro_service service, string name)
    {
      authenticationloginschemapolicy_authenticationvserver_binding authenticationvserverBinding = new authenticationloginschemapolicy_authenticationvserver_binding();
      authenticationvserverBinding.name = name;
      options option = new options();
      option.set_count(true);
      authenticationloginschemapolicy_authenticationvserver_binding[] resources = (authenticationloginschemapolicy_authenticationvserver_binding[]) authenticationvserverBinding.get_resources(service, option);
      return resources != null && resources.Length > 0 ? resources[0].__count.Value : 0U;
    }

    public static uint count_filtered(nitro_service service, string name, string filter)
    {
      authenticationloginschemapolicy_authenticationvserver_binding authenticationvserverBinding = new authenticationloginschemapolicy_authenticationvserver_binding();
      authenticationvserverBinding.name = name;
      options option = new options();
      option.set_count(true);
      option.set_filter(filter);
      authenticationloginschemapolicy_authenticationvserver_binding[] authenticationvserverBindingArray = (authenticationloginschemapolicy_authenticationvserver_binding[]) authenticationvserverBinding.getfiltered(service, option);
      return authenticationvserverBindingArray != null && authenticationvserverBindingArray.Length > 0 ? authenticationvserverBindingArray[0].__count.Value : 0U;
    }

    public static uint count_filtered(nitro_service service, string name, filtervalue[] filter)
    {
      authenticationloginschemapolicy_authenticationvserver_binding authenticationvserverBinding = new authenticationloginschemapolicy_authenticationvserver_binding();
      authenticationvserverBinding.name = name;
      options option = new options();
      option.set_count(true);
      option.set_filter(filter);
      authenticationloginschemapolicy_authenticationvserver_binding[] authenticationvserverBindingArray = (authenticationloginschemapolicy_authenticationvserver_binding[]) authenticationvserverBinding.getfiltered(service, option);
      return authenticationvserverBindingArray != null && authenticationvserverBindingArray.Length > 0 ? authenticationvserverBindingArray[0].__count.Value : 0U;
    }

    private class authenticationloginschemapolicy_authenticationvserver_binding_response : 
      base_response
    {
      public authenticationloginschemapolicy_authenticationvserver_binding[] authenticationloginschemapolicy_authenticationvserver_binding = (authenticationloginschemapolicy_authenticationvserver_binding[]) null;
    }

    public static class labeltypeEnum
    {
      public const string reqvserver = "reqvserver";
      public const string resvserver = "resvserver";
      public const string policylabel = "policylabel";
    }
  }
}
