// Decompiled with JetBrains decompiler
// Type: com.citrix.netscaler.nitro.resource.config.lb.lbvserver_csvserver_binding
// Assembly: nitro, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 6CF5DDEF-E052-4F9D-953F-6644F8378A66


using com.citrix.netscaler.nitro.exception;
using com.citrix.netscaler.nitro.resource.Base;
using com.citrix.netscaler.nitro.service;
using com.citrix.netscaler.nitro.util;

namespace com.citrix.netscaler.nitro.resource.config.lb
{
  public class lbvserver_csvserver_binding : base_resource
  {
    private string cachevserverField = (string) null;
    private string policynameField = (string) null;
    private string cachetypeField = (string) null;
    private uint? priorityField = new uint?();
    private uint? hitsField = new uint?();
    private uint? pipolicyhitsField = new uint?();
    private uint? policysubtypeField = new uint?();
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

    public string cachevserver
    {
      get => this.cachevserverField;
      set => this.cachevserverField = value;
    }

    public string cachetype
    {
      get => this.cachetypeField;
      private set => this.cachetypeField = value;
    }

    public uint? hits
    {
      get => this.hitsField;
      private set => this.hitsField = value;
    }

    public uint? pipolicyhits
    {
      get => this.pipolicyhitsField;
      private set => this.pipolicyhitsField = value;
    }

    public uint? policysubtype
    {
      get => this.policysubtypeField;
      private set => this.policysubtypeField = value;
    }

    internal override base_resource[] get_nitro_response(
      nitro_service service,
      string response)
    {
      lbvserver_csvserver_binding.lbvserver_csvserver_binding_response csvserverBindingResponse = new lbvserver_csvserver_binding.lbvserver_csvserver_binding_response();
      lbvserver_csvserver_binding.lbvserver_csvserver_binding_response resource = (lbvserver_csvserver_binding.lbvserver_csvserver_binding_response) service.get_payload_formatter().string_to_resource(csvserverBindingResponse.GetType(), response);
      if (resource.errorcode != 0)
      {
        if (resource.errorcode == 444)
          service.clear_session();
        if (resource.severity == null)
          throw new nitro_exception(resource.message, resource.errorcode);
        if (resource.severity.Equals("ERROR"))
          throw new nitro_exception(resource.message, resource.errorcode);
      }
      return (base_resource[]) resource.lbvserver_csvserver_binding;
    }

    internal override string get_object_name() => this.name;

    public static lbvserver_csvserver_binding[] get(
      nitro_service service,
      string name)
    {
      return (lbvserver_csvserver_binding[]) new lbvserver_csvserver_binding()
      {
        name = name
      }.get_resources(service, (options) null);
    }

    public static lbvserver_csvserver_binding[] get_filtered(
      nitro_service service,
      string name,
      string filter)
    {
      lbvserver_csvserver_binding csvserverBinding = new lbvserver_csvserver_binding();
      csvserverBinding.name = name;
      options option = new options();
      option.set_filter(filter);
      return (lbvserver_csvserver_binding[]) csvserverBinding.getfiltered(service, option);
    }

    public static lbvserver_csvserver_binding[] get_filtered(
      nitro_service service,
      string name,
      filtervalue[] filter)
    {
      lbvserver_csvserver_binding csvserverBinding = new lbvserver_csvserver_binding();
      csvserverBinding.name = name;
      options option = new options();
      option.set_filter(filter);
      return (lbvserver_csvserver_binding[]) csvserverBinding.getfiltered(service, option);
    }

    public static uint count(nitro_service service, string name)
    {
      lbvserver_csvserver_binding csvserverBinding = new lbvserver_csvserver_binding();
      csvserverBinding.name = name;
      options option = new options();
      option.set_count(true);
      lbvserver_csvserver_binding[] resources = (lbvserver_csvserver_binding[]) csvserverBinding.get_resources(service, option);
      return resources != null && resources.Length > 0 ? resources[0].__count.Value : 0U;
    }

    public static uint count_filtered(nitro_service service, string name, string filter)
    {
      lbvserver_csvserver_binding csvserverBinding = new lbvserver_csvserver_binding();
      csvserverBinding.name = name;
      options option = new options();
      option.set_count(true);
      option.set_filter(filter);
      lbvserver_csvserver_binding[] csvserverBindingArray = (lbvserver_csvserver_binding[]) csvserverBinding.getfiltered(service, option);
      return csvserverBindingArray != null && csvserverBindingArray.Length > 0 ? csvserverBindingArray[0].__count.Value : 0U;
    }

    public static uint count_filtered(nitro_service service, string name, filtervalue[] filter)
    {
      lbvserver_csvserver_binding csvserverBinding = new lbvserver_csvserver_binding();
      csvserverBinding.name = name;
      options option = new options();
      option.set_count(true);
      option.set_filter(filter);
      lbvserver_csvserver_binding[] csvserverBindingArray = (lbvserver_csvserver_binding[]) csvserverBinding.getfiltered(service, option);
      return csvserverBindingArray != null && csvserverBindingArray.Length > 0 ? csvserverBindingArray[0].__count.Value : 0U;
    }

    private class lbvserver_csvserver_binding_response : base_response
    {
      public lbvserver_csvserver_binding[] lbvserver_csvserver_binding = (lbvserver_csvserver_binding[]) null;
    }

    public static class cachetypeEnum
    {
      public const string TRANSPARENT = "TRANSPARENT";
      public const string REVERSE = "REVERSE";
      public const string FORWARD = "FORWARD";
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
