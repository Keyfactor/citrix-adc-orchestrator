// Decompiled with JetBrains decompiler
// Type: com.citrix.netscaler.nitro.resource.config.gslb.gslbsite_gslbservice_binding
// Assembly: nitro, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 6CF5DDEF-E052-4F9D-953F-6644F8378A66


using com.citrix.netscaler.nitro.exception;
using com.citrix.netscaler.nitro.resource.Base;
using com.citrix.netscaler.nitro.service;
using com.citrix.netscaler.nitro.util;

namespace com.citrix.netscaler.nitro.resource.config.gslb
{
  public class gslbsite_gslbservice_binding : base_resource
  {
    private string servicenameField = (string) null;
    private string cnameentryField = (string) null;
    private string ipaddressField = (string) null;
    private ushort? portField = new ushort?();
    private string servicetypeField = (string) null;
    private string stateField = (string) null;
    private string sitenameField = (string) null;
    private uint? __countField = new uint?();

    public uint? __count
    {
      get => this.__countField;
      set => this.__countField = value;
    }

    public string servicename
    {
      get => this.servicenameField;
      set => this.servicenameField = value;
    }

    public string sitename
    {
      get => this.sitenameField;
      set => this.sitenameField = value;
    }

    public string cnameentry
    {
      get => this.cnameentryField;
      private set => this.cnameentryField = value;
    }

    public string state
    {
      get => this.stateField;
      private set => this.stateField = value;
    }

    public string servicetype
    {
      get => this.servicetypeField;
      private set => this.servicetypeField = value;
    }

    public ushort? port
    {
      get => this.portField;
      private set => this.portField = value;
    }

    public string ipaddress
    {
      get => this.ipaddressField;
      private set => this.ipaddressField = value;
    }

    internal override base_resource[] get_nitro_response(
      nitro_service service,
      string response)
    {
      gslbsite_gslbservice_binding.gslbsite_gslbservice_binding_response gslbserviceBindingResponse = new gslbsite_gslbservice_binding.gslbsite_gslbservice_binding_response();
      gslbsite_gslbservice_binding.gslbsite_gslbservice_binding_response resource = (gslbsite_gslbservice_binding.gslbsite_gslbservice_binding_response) service.get_payload_formatter().string_to_resource(gslbserviceBindingResponse.GetType(), response);
      if (resource.errorcode != 0)
      {
        if (resource.errorcode == 444)
          service.clear_session();
        if (resource.severity == null)
          throw new nitro_exception(resource.message, resource.errorcode);
        if (resource.severity.Equals("ERROR"))
          throw new nitro_exception(resource.message, resource.errorcode);
      }
      return (base_resource[]) resource.gslbsite_gslbservice_binding;
    }

    internal override string get_object_name() => this.sitename;

    public static gslbsite_gslbservice_binding[] get(
      nitro_service service,
      string sitename)
    {
      return (gslbsite_gslbservice_binding[]) new gslbsite_gslbservice_binding()
      {
        sitename = sitename
      }.get_resources(service, (options) null);
    }

    public static gslbsite_gslbservice_binding[] get_filtered(
      nitro_service service,
      string sitename,
      string filter)
    {
      gslbsite_gslbservice_binding gslbserviceBinding = new gslbsite_gslbservice_binding();
      gslbserviceBinding.sitename = sitename;
      options option = new options();
      option.set_filter(filter);
      return (gslbsite_gslbservice_binding[]) gslbserviceBinding.getfiltered(service, option);
    }

    public static gslbsite_gslbservice_binding[] get_filtered(
      nitro_service service,
      string sitename,
      filtervalue[] filter)
    {
      gslbsite_gslbservice_binding gslbserviceBinding = new gslbsite_gslbservice_binding();
      gslbserviceBinding.sitename = sitename;
      options option = new options();
      option.set_filter(filter);
      return (gslbsite_gslbservice_binding[]) gslbserviceBinding.getfiltered(service, option);
    }

    public static uint count(nitro_service service, string sitename)
    {
      gslbsite_gslbservice_binding gslbserviceBinding = new gslbsite_gslbservice_binding();
      gslbserviceBinding.sitename = sitename;
      options option = new options();
      option.set_count(true);
      gslbsite_gslbservice_binding[] resources = (gslbsite_gslbservice_binding[]) gslbserviceBinding.get_resources(service, option);
      return resources != null && resources.Length > 0 ? resources[0].__count.Value : 0U;
    }

    public static uint count_filtered(nitro_service service, string sitename, string filter)
    {
      gslbsite_gslbservice_binding gslbserviceBinding = new gslbsite_gslbservice_binding();
      gslbserviceBinding.sitename = sitename;
      options option = new options();
      option.set_count(true);
      option.set_filter(filter);
      gslbsite_gslbservice_binding[] gslbserviceBindingArray = (gslbsite_gslbservice_binding[]) gslbserviceBinding.getfiltered(service, option);
      return gslbserviceBindingArray != null && gslbserviceBindingArray.Length > 0 ? gslbserviceBindingArray[0].__count.Value : 0U;
    }

    public static uint count_filtered(nitro_service service, string sitename, filtervalue[] filter)
    {
      gslbsite_gslbservice_binding gslbserviceBinding = new gslbsite_gslbservice_binding();
      gslbserviceBinding.sitename = sitename;
      options option = new options();
      option.set_count(true);
      option.set_filter(filter);
      gslbsite_gslbservice_binding[] gslbserviceBindingArray = (gslbsite_gslbservice_binding[]) gslbserviceBinding.getfiltered(service, option);
      return gslbserviceBindingArray != null && gslbserviceBindingArray.Length > 0 ? gslbserviceBindingArray[0].__count.Value : 0U;
    }

    private class gslbsite_gslbservice_binding_response : base_response
    {
      public gslbsite_gslbservice_binding[] gslbsite_gslbservice_binding = (gslbsite_gslbservice_binding[]) null;
    }

    public static class stateEnum
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

    public static class servicetypeEnum
    {
      public const string HTTP = "HTTP";
      public const string FTP = "FTP";
      public const string TCP = "TCP";
      public const string UDP = "UDP";
      public const string SSL = "SSL";
      public const string SSL_BRIDGE = "SSL_BRIDGE";
      public const string SSL_TCP = "SSL_TCP";
      public const string DTLS = "DTLS";
      public const string NNTP = "NNTP";
      public const string DNS = "DNS";
      public const string DHCPRA = "DHCPRA";
      public const string ANY = "ANY";
      public const string SIP_UDP = "SIP_UDP";
      public const string SIP_TCP = "SIP_TCP";
      public const string SIP_SSL = "SIP_SSL";
      public const string DNS_TCP = "DNS_TCP";
      public const string RTSP = "RTSP";
      public const string PUSH = "PUSH";
      public const string SSL_PUSH = "SSL_PUSH";
      public const string RADIUS = "RADIUS";
      public const string RDP = "RDP";
      public const string MYSQL = "MYSQL";
      public const string MSSQL = "MSSQL";
      public const string DIAMETER = "DIAMETER";
      public const string SSL_DIAMETER = "SSL_DIAMETER";
      public const string TFTP = "TFTP";
      public const string ORACLE = "ORACLE";
      public const string SMPP = "SMPP";
      public const string SYSLOGTCP = "SYSLOGTCP";
      public const string SYSLOGUDP = "SYSLOGUDP";
      public const string FIX = "FIX";
    }
  }
}
