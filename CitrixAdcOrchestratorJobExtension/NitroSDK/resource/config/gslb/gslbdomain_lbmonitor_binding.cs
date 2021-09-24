// Decompiled with JetBrains decompiler
// Type: com.citrix.netscaler.nitro.resource.config.gslb.gslbdomain_lbmonitor_binding
// Assembly: nitro, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 6CF5DDEF-E052-4F9D-953F-6644F8378A66


using com.citrix.netscaler.nitro.exception;
using com.citrix.netscaler.nitro.resource.Base;
using com.citrix.netscaler.nitro.service;
using com.citrix.netscaler.nitro.util;

namespace com.citrix.netscaler.nitro.resource.config.gslb
{
  public class gslbdomain_lbmonitor_binding : base_resource
  {
    private string monitornameField = (string) null;
    private string servicenameField = (string) null;
    private string vservernameField = (string) null;
    private string monstateField = (string) null;
    private string httprequestField = (string) null;
    private string iptunnelField = (string) null;
    private string customheadersField = (string) null;
    private string respcodeField = (string) null;
    private uint? monitortotalprobesField = new uint?();
    private uint? monitortotalfailedprobesField = new uint?();
    private uint? monitorcurrentfailedprobesField = new uint?();
    private long? responsetimeField = new long?();
    private int? monstatcodeField = new int?();
    private string lastresponseField = (string) null;
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

    public string monitorname
    {
      get => this.monitornameField;
      set => this.monitornameField = value;
    }

    public int? monstatcode
    {
      get => this.monstatcodeField;
      private set => this.monstatcodeField = value;
    }

    public string customheaders
    {
      get => this.customheadersField;
      private set => this.customheadersField = value;
    }

    public string iptunnel
    {
      get => this.iptunnelField;
      private set => this.iptunnelField = value;
    }

    public long? responsetime
    {
      get => this.responsetimeField;
      private set => this.responsetimeField = value;
    }

    public string monstate
    {
      get => this.monstateField;
      private set => this.monstateField = value;
    }

    public string lastresponse
    {
      get => this.lastresponseField;
      private set => this.lastresponseField = value;
    }

    public string servicename
    {
      get => this.servicenameField;
      private set => this.servicenameField = value;
    }

    public uint? monitortotalprobes
    {
      get => this.monitortotalprobesField;
      private set => this.monitortotalprobesField = value;
    }

    public string respcode
    {
      get => this.respcodeField;
      private set => this.respcodeField = value;
    }

    public string vservername
    {
      get => this.vservernameField;
      private set => this.vservernameField = value;
    }

    public string httprequest
    {
      get => this.httprequestField;
      private set => this.httprequestField = value;
    }

    public uint? monitortotalfailedprobes
    {
      get => this.monitortotalfailedprobesField;
      private set => this.monitortotalfailedprobesField = value;
    }

    public uint? monitorcurrentfailedprobes
    {
      get => this.monitorcurrentfailedprobesField;
      private set => this.monitorcurrentfailedprobesField = value;
    }

    internal override base_resource[] get_nitro_response(
      nitro_service service,
      string response)
    {
      gslbdomain_lbmonitor_binding.gslbdomain_lbmonitor_binding_response lbmonitorBindingResponse = new gslbdomain_lbmonitor_binding.gslbdomain_lbmonitor_binding_response();
      gslbdomain_lbmonitor_binding.gslbdomain_lbmonitor_binding_response resource = (gslbdomain_lbmonitor_binding.gslbdomain_lbmonitor_binding_response) service.get_payload_formatter().string_to_resource(lbmonitorBindingResponse.GetType(), response);
      if (resource.errorcode != 0)
      {
        if (resource.errorcode == 444)
          service.clear_session();
        if (resource.severity == null)
          throw new nitro_exception(resource.message, resource.errorcode);
        if (resource.severity.Equals("ERROR"))
          throw new nitro_exception(resource.message, resource.errorcode);
      }
      return (base_resource[]) resource.gslbdomain_lbmonitor_binding;
    }

    internal override string get_object_name() => this.name;

    public static gslbdomain_lbmonitor_binding[] get(
      nitro_service service,
      string name)
    {
      return (gslbdomain_lbmonitor_binding[]) new gslbdomain_lbmonitor_binding()
      {
        name = name
      }.get_resources(service, (options) null);
    }

    public static gslbdomain_lbmonitor_binding[] get_filtered(
      nitro_service service,
      string name,
      string filter)
    {
      gslbdomain_lbmonitor_binding lbmonitorBinding = new gslbdomain_lbmonitor_binding();
      lbmonitorBinding.name = name;
      options option = new options();
      option.set_filter(filter);
      return (gslbdomain_lbmonitor_binding[]) lbmonitorBinding.getfiltered(service, option);
    }

    public static gslbdomain_lbmonitor_binding[] get_filtered(
      nitro_service service,
      string name,
      filtervalue[] filter)
    {
      gslbdomain_lbmonitor_binding lbmonitorBinding = new gslbdomain_lbmonitor_binding();
      lbmonitorBinding.name = name;
      options option = new options();
      option.set_filter(filter);
      return (gslbdomain_lbmonitor_binding[]) lbmonitorBinding.getfiltered(service, option);
    }

    public static uint count(nitro_service service, string name)
    {
      gslbdomain_lbmonitor_binding lbmonitorBinding = new gslbdomain_lbmonitor_binding();
      lbmonitorBinding.name = name;
      options option = new options();
      option.set_count(true);
      gslbdomain_lbmonitor_binding[] resources = (gslbdomain_lbmonitor_binding[]) lbmonitorBinding.get_resources(service, option);
      return resources != null && resources.Length > 0 ? resources[0].__count.Value : 0U;
    }

    public static uint count_filtered(nitro_service service, string name, string filter)
    {
      gslbdomain_lbmonitor_binding lbmonitorBinding = new gslbdomain_lbmonitor_binding();
      lbmonitorBinding.name = name;
      options option = new options();
      option.set_count(true);
      option.set_filter(filter);
      gslbdomain_lbmonitor_binding[] lbmonitorBindingArray = (gslbdomain_lbmonitor_binding[]) lbmonitorBinding.getfiltered(service, option);
      return lbmonitorBindingArray != null && lbmonitorBindingArray.Length > 0 ? lbmonitorBindingArray[0].__count.Value : 0U;
    }

    public static uint count_filtered(nitro_service service, string name, filtervalue[] filter)
    {
      gslbdomain_lbmonitor_binding lbmonitorBinding = new gslbdomain_lbmonitor_binding();
      lbmonitorBinding.name = name;
      options option = new options();
      option.set_count(true);
      option.set_filter(filter);
      gslbdomain_lbmonitor_binding[] lbmonitorBindingArray = (gslbdomain_lbmonitor_binding[]) lbmonitorBinding.getfiltered(service, option);
      return lbmonitorBindingArray != null && lbmonitorBindingArray.Length > 0 ? lbmonitorBindingArray[0].__count.Value : 0U;
    }

    private class gslbdomain_lbmonitor_binding_response : base_response
    {
      public gslbdomain_lbmonitor_binding[] gslbdomain_lbmonitor_binding = (gslbdomain_lbmonitor_binding[]) null;
    }

    public static class iptunnelEnum
    {
      public const string YES = "YES";
      public const string NO = "NO";
    }

    public static class monstateEnum
    {
      public const string UP = "UP";
      public const string DOWN = "DOWN";
      public const string UNKNOWN = "UNKNOWN";
      public const string BUSY = "BUSY";
      public const string OUT_OF_SERVICE = "OUT OF SERVICE";
      public const string GOING_OUT_OF_SERVICE = "GOING OUT OF SERVICE";
      public const string DOWN_WHEN_GOING_OUT_OF_SERVICE = "DOWN WHEN GOING OUT OF SERVICE";
      public const string NS_EMPTY_STR = "NS_EMPTY_STR";
      public const string Unknown = "Unknown";
      public const string DISABLED = "DISABLED";
    }
  }
}
