// Decompiled with JetBrains decompiler
// Type: com.citrix.netscaler.nitro.resource.config.basic.server_servicegroup_binding
// Assembly: nitro, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 6CF5DDEF-E052-4F9D-953F-6644F8378A66


using com.citrix.netscaler.nitro.exception;
using com.citrix.netscaler.nitro.resource.Base;
using com.citrix.netscaler.nitro.service;
using com.citrix.netscaler.nitro.util;

namespace com.citrix.netscaler.nitro.resource.config.basic
{
  public class server_servicegroup_binding : base_resource
  {
    private string servicegroupnameField = (string) null;
    private string svctypeField = (string) null;
    private string serviceipaddressField = (string) null;
    private ushort? portField = new ushort?();
    private string customserveridField = (string) null;
    private string svrstateField = (string) null;
    private string dup_svctypeField = (string) null;
    private ushort? dup_portField = new ushort?();
    private uint? svrcfgflagsField = new uint?();
    private string serviceipstrField = (string) null;
    private uint? monthresholdField = new uint?();
    private uint? maxclientField = new uint?();
    private uint? maxreqField = new uint?();
    private uint? maxbandwidthField = new uint?();
    private string usipField = (string) null;
    private string ckaField = (string) null;
    private string tcpbField = (string) null;
    private string cmpField = (string) null;
    private long? clttimeoutField = new long?();
    private long? svrtimeoutField = new long?();
    private string cipheaderField = (string) null;
    private string cipField = (string) null;
    private string cacheableField = (string) null;
    private string scField = (string) null;
    private string spField = (string) null;
    private string downstateflushField = (string) null;
    private string appflowlogField = (string) null;
    private uint? boundtdField = new uint?();
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

    public string servicegroupname
    {
      get => this.servicegroupnameField;
      set => this.servicegroupnameField = value;
    }

    public string sp
    {
      get => this.spField;
      private set => this.spField = value;
    }

    public string sc
    {
      get => this.scField;
      private set => this.scField = value;
    }

    public long? svrtimeout
    {
      get => this.svrtimeoutField;
      private set => this.svrtimeoutField = value;
    }

    public string serviceipstr
    {
      get => this.serviceipstrField;
      private set => this.serviceipstrField = value;
    }

    public string tcpb
    {
      get => this.tcpbField;
      private set => this.tcpbField = value;
    }

    public string cip
    {
      get => this.cipField;
      private set => this.cipField = value;
    }

    public ushort? dup_port
    {
      get => this.dup_portField;
      private set => this.dup_portField = value;
    }

    public string customserverid
    {
      get => this.customserveridField;
      private set => this.customserveridField = value;
    }

    public uint? boundtd
    {
      get => this.boundtdField;
      private set => this.boundtdField = value;
    }

    public string downstateflush
    {
      get => this.downstateflushField;
      private set => this.downstateflushField = value;
    }

    public string svctype
    {
      get => this.svctypeField;
      private set => this.svctypeField = value;
    }

    public string cka
    {
      get => this.ckaField;
      private set => this.ckaField = value;
    }

    public string svrstate
    {
      get => this.svrstateField;
      private set => this.svrstateField = value;
    }

    public string appflowlog
    {
      get => this.appflowlogField;
      private set => this.appflowlogField = value;
    }

    public string cipheader
    {
      get => this.cipheaderField;
      private set => this.cipheaderField = value;
    }

    public uint? maxclient
    {
      get => this.maxclientField;
      private set => this.maxclientField = value;
    }

    public long? clttimeout
    {
      get => this.clttimeoutField;
      private set => this.clttimeoutField = value;
    }

    public ushort? port
    {
      get => this.portField;
      private set => this.portField = value;
    }

    public string dup_svctype
    {
      get => this.dup_svctypeField;
      private set => this.dup_svctypeField = value;
    }

    public string cmp
    {
      get => this.cmpField;
      private set => this.cmpField = value;
    }

    public uint? monthreshold
    {
      get => this.monthresholdField;
      private set => this.monthresholdField = value;
    }

    public uint? maxreq
    {
      get => this.maxreqField;
      private set => this.maxreqField = value;
    }

    public string serviceipaddress
    {
      get => this.serviceipaddressField;
      private set => this.serviceipaddressField = value;
    }

    public string usip
    {
      get => this.usipField;
      private set => this.usipField = value;
    }

    public string cacheable
    {
      get => this.cacheableField;
      private set => this.cacheableField = value;
    }

    public uint? maxbandwidth
    {
      get => this.maxbandwidthField;
      private set => this.maxbandwidthField = value;
    }

    public uint? svrcfgflags
    {
      get => this.svrcfgflagsField;
      private set => this.svrcfgflagsField = value;
    }

    internal override base_resource[] get_nitro_response(
      nitro_service service,
      string response)
    {
      server_servicegroup_binding.server_servicegroup_binding_response servicegroupBindingResponse = new server_servicegroup_binding.server_servicegroup_binding_response();
      server_servicegroup_binding.server_servicegroup_binding_response resource = (server_servicegroup_binding.server_servicegroup_binding_response) service.get_payload_formatter().string_to_resource(servicegroupBindingResponse.GetType(), response);
      if (resource.errorcode != 0)
      {
        if (resource.errorcode == 444)
          service.clear_session();
        if (resource.severity == null)
          throw new nitro_exception(resource.message, resource.errorcode);
        if (resource.severity.Equals("ERROR"))
          throw new nitro_exception(resource.message, resource.errorcode);
      }
      return (base_resource[]) resource.server_servicegroup_binding;
    }

    internal override string get_object_name() => this.name;

    public static server_servicegroup_binding[] get(
      nitro_service service,
      string name)
    {
      return (server_servicegroup_binding[]) new server_servicegroup_binding()
      {
        name = name
      }.get_resources(service, (options) null);
    }

    public static server_servicegroup_binding[] get_filtered(
      nitro_service service,
      string name,
      string filter)
    {
      server_servicegroup_binding servicegroupBinding = new server_servicegroup_binding();
      servicegroupBinding.name = name;
      options option = new options();
      option.set_filter(filter);
      return (server_servicegroup_binding[]) servicegroupBinding.getfiltered(service, option);
    }

    public static server_servicegroup_binding[] get_filtered(
      nitro_service service,
      string name,
      filtervalue[] filter)
    {
      server_servicegroup_binding servicegroupBinding = new server_servicegroup_binding();
      servicegroupBinding.name = name;
      options option = new options();
      option.set_filter(filter);
      return (server_servicegroup_binding[]) servicegroupBinding.getfiltered(service, option);
    }

    public static uint count(nitro_service service, string name)
    {
      server_servicegroup_binding servicegroupBinding = new server_servicegroup_binding();
      servicegroupBinding.name = name;
      options option = new options();
      option.set_count(true);
      server_servicegroup_binding[] resources = (server_servicegroup_binding[]) servicegroupBinding.get_resources(service, option);
      return resources != null && resources.Length > 0 ? resources[0].__count.Value : 0U;
    }

    public static uint count_filtered(nitro_service service, string name, string filter)
    {
      server_servicegroup_binding servicegroupBinding = new server_servicegroup_binding();
      servicegroupBinding.name = name;
      options option = new options();
      option.set_count(true);
      option.set_filter(filter);
      server_servicegroup_binding[] servicegroupBindingArray = (server_servicegroup_binding[]) servicegroupBinding.getfiltered(service, option);
      return servicegroupBindingArray != null && servicegroupBindingArray.Length > 0 ? servicegroupBindingArray[0].__count.Value : 0U;
    }

    public static uint count_filtered(nitro_service service, string name, filtervalue[] filter)
    {
      server_servicegroup_binding servicegroupBinding = new server_servicegroup_binding();
      servicegroupBinding.name = name;
      options option = new options();
      option.set_count(true);
      option.set_filter(filter);
      server_servicegroup_binding[] servicegroupBindingArray = (server_servicegroup_binding[]) servicegroupBinding.getfiltered(service, option);
      return servicegroupBindingArray != null && servicegroupBindingArray.Length > 0 ? servicegroupBindingArray[0].__count.Value : 0U;
    }

    private class server_servicegroup_binding_response : base_response
    {
      public server_servicegroup_binding[] server_servicegroup_binding = (server_servicegroup_binding[]) null;
    }

    public static class spEnum
    {
      public const string ON = "ON";
      public const string OFF = "OFF";
    }

    public static class scEnum
    {
      public const string ON = "ON";
      public const string OFF = "OFF";
    }

    public static class downstateflushEnum
    {
      public const string ENABLED = "ENABLED";
      public const string DISABLED = "DISABLED";
    }

    public static class svctypeEnum
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
      public const string RPCSVR = "RPCSVR";
      public const string DNS = "DNS";
      public const string ADNS = "ADNS";
      public const string SNMP = "SNMP";
      public const string RTSP = "RTSP";
      public const string DHCPRA = "DHCPRA";
      public const string ANY = "ANY";
      public const string SIP_UDP = "SIP_UDP";
      public const string SIP_TCP = "SIP_TCP";
      public const string SIP_SSL = "SIP_SSL";
      public const string DNS_TCP = "DNS_TCP";
      public const string ADNS_TCP = "ADNS_TCP";
      public const string MYSQL = "MYSQL";
      public const string MSSQL = "MSSQL";
      public const string ORACLE = "ORACLE";
      public const string RADIUS = "RADIUS";
      public const string RADIUSListener = "RADIUSListener";
      public const string RDP = "RDP";
      public const string DIAMETER = "DIAMETER";
      public const string SSL_DIAMETER = "SSL_DIAMETER";
      public const string TFTP = "TFTP";
      public const string SMPP = "SMPP";
      public const string PPTP = "PPTP";
      public const string GRE = "GRE";
      public const string SYSLOGTCP = "SYSLOGTCP";
      public const string SYSLOGUDP = "SYSLOGUDP";
      public const string FIX = "FIX";
    }

    public static class svrstateEnum
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

    public static class dup_svctypeEnum
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
      public const string RPCSVR = "RPCSVR";
      public const string DNS = "DNS";
      public const string ADNS = "ADNS";
      public const string SNMP = "SNMP";
      public const string RTSP = "RTSP";
      public const string DHCPRA = "DHCPRA";
      public const string ANY = "ANY";
      public const string SIP_UDP = "SIP_UDP";
      public const string SIP_TCP = "SIP_TCP";
      public const string SIP_SSL = "SIP_SSL";
      public const string DNS_TCP = "DNS_TCP";
      public const string ADNS_TCP = "ADNS_TCP";
      public const string MYSQL = "MYSQL";
      public const string MSSQL = "MSSQL";
      public const string ORACLE = "ORACLE";
      public const string RADIUS = "RADIUS";
      public const string RADIUSListener = "RADIUSListener";
      public const string RDP = "RDP";
      public const string DIAMETER = "DIAMETER";
      public const string SSL_DIAMETER = "SSL_DIAMETER";
      public const string TFTP = "TFTP";
      public const string SMPP = "SMPP";
      public const string PPTP = "PPTP";
      public const string GRE = "GRE";
      public const string SYSLOGTCP = "SYSLOGTCP";
      public const string SYSLOGUDP = "SYSLOGUDP";
      public const string FIX = "FIX";
    }

    public static class usipEnum
    {
      public const string YES = "YES";
      public const string NO = "NO";
    }

    public static class cacheableEnum
    {
      public const string YES = "YES";
      public const string NO = "NO";
    }

    public static class tcpbEnum
    {
      public const string YES = "YES";
      public const string NO = "NO";
    }

    public static class cipEnum
    {
      public const string ENABLED = "ENABLED";
      public const string DISABLED = "DISABLED";
    }

    public static class ckaEnum
    {
      public const string YES = "YES";
      public const string NO = "NO";
    }

    public static class appflowlogEnum
    {
      public const string ENABLED = "ENABLED";
      public const string DISABLED = "DISABLED";
    }

    public static class cmpEnum
    {
      public const string YES = "YES";
      public const string NO = "NO";
    }
  }
}
