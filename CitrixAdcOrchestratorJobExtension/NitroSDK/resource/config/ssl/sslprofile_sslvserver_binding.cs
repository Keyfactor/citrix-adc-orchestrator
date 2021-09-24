// Decompiled with JetBrains decompiler
// Type: com.citrix.netscaler.nitro.resource.config.ssl.sslprofile_sslvserver_binding
// Assembly: nitro, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 6CF5DDEF-E052-4F9D-953F-6644F8378A66


using com.citrix.netscaler.nitro.exception;
using com.citrix.netscaler.nitro.resource.Base;
using com.citrix.netscaler.nitro.service;
using com.citrix.netscaler.nitro.util;

namespace com.citrix.netscaler.nitro.resource.config.ssl
{
  public class sslprofile_sslvserver_binding : base_resource
  {
    private string servicenameField = (string) null;
    private string descriptionField = (string) null;
    private string nameField = (string) null;
    private uint? cipherpriorityField = new uint?();
    private uint? __countField = new uint?();

    public uint? __count
    {
      get => this.__countField;
      set => this.__countField = value;
    }

    public uint? cipherpriority
    {
      get => this.cipherpriorityField;
      set => this.cipherpriorityField = value;
    }

    public string name
    {
      get => this.nameField;
      set => this.nameField = value;
    }

    public string description
    {
      get => this.descriptionField;
      set => this.descriptionField = value;
    }

    public string servicename
    {
      get => this.servicenameField;
      set => this.servicenameField = value;
    }

    internal override base_resource[] get_nitro_response(
      nitro_service service,
      string response)
    {
      sslprofile_sslvserver_binding.sslprofile_sslvserver_binding_response sslvserverBindingResponse = new sslprofile_sslvserver_binding.sslprofile_sslvserver_binding_response();
      sslprofile_sslvserver_binding.sslprofile_sslvserver_binding_response resource = (sslprofile_sslvserver_binding.sslprofile_sslvserver_binding_response) service.get_payload_formatter().string_to_resource(sslvserverBindingResponse.GetType(), response);
      if (resource.errorcode != 0)
      {
        if (resource.errorcode == 444)
          service.clear_session();
        if (resource.severity == null)
          throw new nitro_exception(resource.message, resource.errorcode);
        if (resource.severity.Equals("ERROR"))
          throw new nitro_exception(resource.message, resource.errorcode);
      }
      return (base_resource[]) resource.sslprofile_sslvserver_binding;
    }

    internal override string get_object_name() => this.name;

    public static sslprofile_sslvserver_binding[] get(
      nitro_service service,
      string name)
    {
      return (sslprofile_sslvserver_binding[]) new sslprofile_sslvserver_binding()
      {
        name = name
      }.get_resources(service, (options) null);
    }

    public static sslprofile_sslvserver_binding[] get_filtered(
      nitro_service service,
      string name,
      string filter)
    {
      sslprofile_sslvserver_binding sslvserverBinding = new sslprofile_sslvserver_binding();
      sslvserverBinding.name = name;
      options option = new options();
      option.set_filter(filter);
      return (sslprofile_sslvserver_binding[]) sslvserverBinding.getfiltered(service, option);
    }

    public static sslprofile_sslvserver_binding[] get_filtered(
      nitro_service service,
      string name,
      filtervalue[] filter)
    {
      sslprofile_sslvserver_binding sslvserverBinding = new sslprofile_sslvserver_binding();
      sslvserverBinding.name = name;
      options option = new options();
      option.set_filter(filter);
      return (sslprofile_sslvserver_binding[]) sslvserverBinding.getfiltered(service, option);
    }

    public static uint count(nitro_service service, string name)
    {
      sslprofile_sslvserver_binding sslvserverBinding = new sslprofile_sslvserver_binding();
      sslvserverBinding.name = name;
      options option = new options();
      option.set_count(true);
      sslprofile_sslvserver_binding[] resources = (sslprofile_sslvserver_binding[]) sslvserverBinding.get_resources(service, option);
      return resources != null && resources.Length > 0 ? resources[0].__count.Value : 0U;
    }

    public static uint count_filtered(nitro_service service, string name, string filter)
    {
      sslprofile_sslvserver_binding sslvserverBinding = new sslprofile_sslvserver_binding();
      sslvserverBinding.name = name;
      options option = new options();
      option.set_count(true);
      option.set_filter(filter);
      sslprofile_sslvserver_binding[] sslvserverBindingArray = (sslprofile_sslvserver_binding[]) sslvserverBinding.getfiltered(service, option);
      return sslvserverBindingArray != null && sslvserverBindingArray.Length > 0 ? sslvserverBindingArray[0].__count.Value : 0U;
    }

    public static uint count_filtered(nitro_service service, string name, filtervalue[] filter)
    {
      sslprofile_sslvserver_binding sslvserverBinding = new sslprofile_sslvserver_binding();
      sslvserverBinding.name = name;
      options option = new options();
      option.set_count(true);
      option.set_filter(filter);
      sslprofile_sslvserver_binding[] sslvserverBindingArray = (sslprofile_sslvserver_binding[]) sslvserverBinding.getfiltered(service, option);
      return sslvserverBindingArray != null && sslvserverBindingArray.Length > 0 ? sslvserverBindingArray[0].__count.Value : 0U;
    }

    private class sslprofile_sslvserver_binding_response : base_response
    {
      public sslprofile_sslvserver_binding[] sslprofile_sslvserver_binding = (sslprofile_sslvserver_binding[]) null;
    }

    public static class ecccurvenameEnum
    {
      public const string ALL = "ALL";
      public const string P_224 = "P_224";
      public const string P_256 = "P_256";
      public const string P_384 = "P_384";
      public const string P_521 = "P_521";
    }
  }
}
