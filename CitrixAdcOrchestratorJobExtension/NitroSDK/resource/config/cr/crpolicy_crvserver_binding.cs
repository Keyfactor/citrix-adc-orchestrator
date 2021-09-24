// Decompiled with JetBrains decompiler
// Type: com.citrix.netscaler.nitro.resource.config.cr.crpolicy_crvserver_binding
// Assembly: nitro, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 6CF5DDEF-E052-4F9D-953F-6644F8378A66


using com.citrix.netscaler.nitro.exception;
using com.citrix.netscaler.nitro.resource.Base;
using com.citrix.netscaler.nitro.service;
using com.citrix.netscaler.nitro.util;

namespace com.citrix.netscaler.nitro.resource.config.cr
{
  public class crpolicy_crvserver_binding : base_resource
  {
    private string domainField = (string) null;
    private uint? priorityField = new uint?();
    private uint? hitsField = new uint?();
    private uint? pihitsField = new uint?();
    private uint? pipolicyhitsField = new uint?();
    private string labeltypeField = (string) null;
    private string labelnameField = (string) null;
    private string gotopriorityexpressionField = (string) null;
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

    public string gotopriorityexpression
    {
      get => this.gotopriorityexpressionField;
      private set => this.gotopriorityexpressionField = value;
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

    internal override base_resource[] get_nitro_response(
      nitro_service service,
      string response)
    {
      crpolicy_crvserver_binding.crpolicy_crvserver_binding_response crvserverBindingResponse = new crpolicy_crvserver_binding.crpolicy_crvserver_binding_response();
      crpolicy_crvserver_binding.crpolicy_crvserver_binding_response resource = (crpolicy_crvserver_binding.crpolicy_crvserver_binding_response) service.get_payload_formatter().string_to_resource(crvserverBindingResponse.GetType(), response);
      if (resource.errorcode != 0)
      {
        if (resource.errorcode == 444)
          service.clear_session();
        if (resource.severity == null)
          throw new nitro_exception(resource.message, resource.errorcode);
        if (resource.severity.Equals("ERROR"))
          throw new nitro_exception(resource.message, resource.errorcode);
      }
      return (base_resource[]) resource.crpolicy_crvserver_binding;
    }

    internal override string get_object_name() => this.policyname;

    public static crpolicy_crvserver_binding[] get(
      nitro_service service,
      string policyname)
    {
      return (crpolicy_crvserver_binding[]) new crpolicy_crvserver_binding()
      {
        policyname = policyname
      }.get_resources(service, (options) null);
    }

    public static crpolicy_crvserver_binding[] get_filtered(
      nitro_service service,
      string policyname,
      string filter)
    {
      crpolicy_crvserver_binding crvserverBinding = new crpolicy_crvserver_binding();
      crvserverBinding.policyname = policyname;
      options option = new options();
      option.set_filter(filter);
      return (crpolicy_crvserver_binding[]) crvserverBinding.getfiltered(service, option);
    }

    public static crpolicy_crvserver_binding[] get_filtered(
      nitro_service service,
      string policyname,
      filtervalue[] filter)
    {
      crpolicy_crvserver_binding crvserverBinding = new crpolicy_crvserver_binding();
      crvserverBinding.policyname = policyname;
      options option = new options();
      option.set_filter(filter);
      return (crpolicy_crvserver_binding[]) crvserverBinding.getfiltered(service, option);
    }

    public static uint count(nitro_service service, string policyname)
    {
      crpolicy_crvserver_binding crvserverBinding = new crpolicy_crvserver_binding();
      crvserverBinding.policyname = policyname;
      options option = new options();
      option.set_count(true);
      crpolicy_crvserver_binding[] resources = (crpolicy_crvserver_binding[]) crvserverBinding.get_resources(service, option);
      return resources != null && resources.Length > 0 ? resources[0].__count.Value : 0U;
    }

    public static uint count_filtered(nitro_service service, string policyname, string filter)
    {
      crpolicy_crvserver_binding crvserverBinding = new crpolicy_crvserver_binding();
      crvserverBinding.policyname = policyname;
      options option = new options();
      option.set_count(true);
      option.set_filter(filter);
      crpolicy_crvserver_binding[] crvserverBindingArray = (crpolicy_crvserver_binding[]) crvserverBinding.getfiltered(service, option);
      return crvserverBindingArray != null && crvserverBindingArray.Length > 0 ? crvserverBindingArray[0].__count.Value : 0U;
    }

    public static uint count_filtered(
      nitro_service service,
      string policyname,
      filtervalue[] filter)
    {
      crpolicy_crvserver_binding crvserverBinding = new crpolicy_crvserver_binding();
      crvserverBinding.policyname = policyname;
      options option = new options();
      option.set_count(true);
      option.set_filter(filter);
      crpolicy_crvserver_binding[] crvserverBindingArray = (crpolicy_crvserver_binding[]) crvserverBinding.getfiltered(service, option);
      return crvserverBindingArray != null && crvserverBindingArray.Length > 0 ? crvserverBindingArray[0].__count.Value : 0U;
    }

    private class crpolicy_crvserver_binding_response : base_response
    {
      public crpolicy_crvserver_binding[] crpolicy_crvserver_binding = (crpolicy_crvserver_binding[]) null;
    }

    public static class labeltypeEnum
    {
      public const string reqvserver = "reqvserver";
      public const string resvserver = "resvserver";
      public const string policylabel = "policylabel";
    }
  }
}
