// Decompiled with JetBrains decompiler
// Type: com.citrix.netscaler.nitro.resource.config.cs.cspolicy_csvserver_binding
// Assembly: nitro, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 6CF5DDEF-E052-4F9D-953F-6644F8378A66


using com.citrix.netscaler.nitro.exception;
using com.citrix.netscaler.nitro.resource.Base;
using com.citrix.netscaler.nitro.service;
using com.citrix.netscaler.nitro.util;

namespace com.citrix.netscaler.nitro.resource.config.cs
{
  public class cspolicy_csvserver_binding : base_resource
  {
    private string domainField = (string) null;
    private string actionField = (string) null;
    private string urlField = (string) null;
    private uint? priorityField = new uint?();
    private uint? hitsField = new uint?();
    private uint? pihitsField = new uint?();
    private uint? pipolicyhitsField = new uint?();
    private string labeltypeField = (string) null;
    private string labelnameField = (string) null;
    private string policynameField = (string) null;
    private uint? __countField = new uint?();

    public uint? __count
    {
      get => this.__countField;
      set => this.__countField = value;
    }

    public string policyname
    {
      get => this.policynameField;
      set => this.policynameField = value;
    }

    public string domain
    {
      get => this.domainField;
      set => this.domainField = value;
    }

    public uint? priority
    {
      get => this.priorityField;
      private set => this.priorityField = value;
    }

    public uint? hits
    {
      get => this.hitsField;
      private set => this.hitsField = value;
    }

    public string url
    {
      get => this.urlField;
      private set => this.urlField = value;
    }

    public uint? pipolicyhits
    {
      get => this.pipolicyhitsField;
      private set => this.pipolicyhitsField = value;
    }

    public string labeltype
    {
      get => this.labeltypeField;
      private set => this.labeltypeField = value;
    }

    public string labelname
    {
      get => this.labelnameField;
      private set => this.labelnameField = value;
    }

    public uint? pihits
    {
      get => this.pihitsField;
      private set => this.pihitsField = value;
    }

    public string action
    {
      get => this.actionField;
      private set => this.actionField = value;
    }

    internal override base_resource[] get_nitro_response(
      nitro_service service,
      string response)
    {
      cspolicy_csvserver_binding.cspolicy_csvserver_binding_response csvserverBindingResponse = new cspolicy_csvserver_binding.cspolicy_csvserver_binding_response();
      cspolicy_csvserver_binding.cspolicy_csvserver_binding_response resource = (cspolicy_csvserver_binding.cspolicy_csvserver_binding_response) service.get_payload_formatter().string_to_resource(csvserverBindingResponse.GetType(), response);
      if (resource.errorcode != 0)
      {
        if (resource.errorcode == 444)
          service.clear_session();
        if (resource.severity == null)
          throw new nitro_exception(resource.message, resource.errorcode);
        if (resource.severity.Equals("ERROR"))
          throw new nitro_exception(resource.message, resource.errorcode);
      }
      return (base_resource[]) resource.cspolicy_csvserver_binding;
    }

    internal override string get_object_name() => this.policyname;

    public static cspolicy_csvserver_binding[] get(
      nitro_service service,
      string policyname)
    {
      return (cspolicy_csvserver_binding[]) new cspolicy_csvserver_binding()
      {
        policyname = policyname
      }.get_resources(service, (options) null);
    }

    public static cspolicy_csvserver_binding[] get_filtered(
      nitro_service service,
      string policyname,
      string filter)
    {
      cspolicy_csvserver_binding csvserverBinding = new cspolicy_csvserver_binding();
      csvserverBinding.policyname = policyname;
      options option = new options();
      option.set_filter(filter);
      return (cspolicy_csvserver_binding[]) csvserverBinding.getfiltered(service, option);
    }

    public static cspolicy_csvserver_binding[] get_filtered(
      nitro_service service,
      string policyname,
      filtervalue[] filter)
    {
      cspolicy_csvserver_binding csvserverBinding = new cspolicy_csvserver_binding();
      csvserverBinding.policyname = policyname;
      options option = new options();
      option.set_filter(filter);
      return (cspolicy_csvserver_binding[]) csvserverBinding.getfiltered(service, option);
    }

    public static uint count(nitro_service service, string policyname)
    {
      cspolicy_csvserver_binding csvserverBinding = new cspolicy_csvserver_binding();
      csvserverBinding.policyname = policyname;
      options option = new options();
      option.set_count(true);
      cspolicy_csvserver_binding[] resources = (cspolicy_csvserver_binding[]) csvserverBinding.get_resources(service, option);
      return resources != null && resources.Length > 0 ? resources[0].__count.Value : 0U;
    }

    public static uint count_filtered(nitro_service service, string policyname, string filter)
    {
      cspolicy_csvserver_binding csvserverBinding = new cspolicy_csvserver_binding();
      csvserverBinding.policyname = policyname;
      options option = new options();
      option.set_count(true);
      option.set_filter(filter);
      cspolicy_csvserver_binding[] csvserverBindingArray = (cspolicy_csvserver_binding[]) csvserverBinding.getfiltered(service, option);
      return csvserverBindingArray != null && csvserverBindingArray.Length > 0 ? csvserverBindingArray[0].__count.Value : 0U;
    }

    public static uint count_filtered(
      nitro_service service,
      string policyname,
      filtervalue[] filter)
    {
      cspolicy_csvserver_binding csvserverBinding = new cspolicy_csvserver_binding();
      csvserverBinding.policyname = policyname;
      options option = new options();
      option.set_count(true);
      option.set_filter(filter);
      cspolicy_csvserver_binding[] csvserverBindingArray = (cspolicy_csvserver_binding[]) csvserverBinding.getfiltered(service, option);
      return csvserverBindingArray != null && csvserverBindingArray.Length > 0 ? csvserverBindingArray[0].__count.Value : 0U;
    }

    private class cspolicy_csvserver_binding_response : base_response
    {
      public cspolicy_csvserver_binding[] cspolicy_csvserver_binding = (cspolicy_csvserver_binding[]) null;
    }

    public static class labeltypeEnum
    {
      public const string reqvserver = "reqvserver";
      public const string resvserver = "resvserver";
      public const string policylabel = "policylabel";
    }
  }
}
