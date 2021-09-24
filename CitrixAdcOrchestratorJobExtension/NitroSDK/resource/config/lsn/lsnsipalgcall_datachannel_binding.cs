// Decompiled with JetBrains decompiler
// Type: com.citrix.netscaler.nitro.resource.config.lsn.lsnsipalgcall_datachannel_binding
// Assembly: nitro, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 6CF5DDEF-E052-4F9D-953F-6644F8378A66


using com.citrix.netscaler.nitro.exception;
using com.citrix.netscaler.nitro.resource.Base;
using com.citrix.netscaler.nitro.service;
using com.citrix.netscaler.nitro.util;

namespace com.citrix.netscaler.nitro.resource.config.lsn
{
  public class lsnsipalgcall_datachannel_binding : base_resource
  {
    private string channelipField = (string) null;
    private string channelnatipField = (string) null;
    private ushort? channelportField = new ushort?();
    private ushort? channelnatportField = new ushort?();
    private string channelprotocolField = (string) null;
    private uint? channelflagsField = new uint?();
    private uint? channeltimeoutField = new uint?();
    private string callidField = (string) null;
    private uint? __countField = new uint?();

    public uint? __count
    {
      get => this.__countField;
      set => this.__countField = value;
    }

    public string channelip
    {
      get => this.channelipField;
      set => this.channelipField = value;
    }

    public string callid
    {
      get => this.callidField;
      set => this.callidField = value;
    }

    public string channelnatip
    {
      get => this.channelnatipField;
      private set => this.channelnatipField = value;
    }

    public ushort? channelport
    {
      get => this.channelportField;
      private set => this.channelportField = value;
    }

    public uint? channelflags
    {
      get => this.channelflagsField;
      private set => this.channelflagsField = value;
    }

    public uint? channeltimeout
    {
      get => this.channeltimeoutField;
      private set => this.channeltimeoutField = value;
    }

    public ushort? channelnatport
    {
      get => this.channelnatportField;
      private set => this.channelnatportField = value;
    }

    public string channelprotocol
    {
      get => this.channelprotocolField;
      private set => this.channelprotocolField = value;
    }

    internal override base_resource[] get_nitro_response(
      nitro_service service,
      string response)
    {
      lsnsipalgcall_datachannel_binding.lsnsipalgcall_datachannel_binding_response datachannelBindingResponse = new lsnsipalgcall_datachannel_binding.lsnsipalgcall_datachannel_binding_response();
      lsnsipalgcall_datachannel_binding.lsnsipalgcall_datachannel_binding_response resource = (lsnsipalgcall_datachannel_binding.lsnsipalgcall_datachannel_binding_response) service.get_payload_formatter().string_to_resource(datachannelBindingResponse.GetType(), response);
      if (resource.errorcode != 0)
      {
        if (resource.errorcode == 444)
          service.clear_session();
        if (resource.severity == null)
          throw new nitro_exception(resource.message, resource.errorcode);
        if (resource.severity.Equals("ERROR"))
          throw new nitro_exception(resource.message, resource.errorcode);
      }
      return (base_resource[]) resource.lsnsipalgcall_datachannel_binding;
    }

    internal override string get_object_name() => this.callid;

    public static lsnsipalgcall_datachannel_binding[] get(
      nitro_service service,
      string callid)
    {
      return (lsnsipalgcall_datachannel_binding[]) new lsnsipalgcall_datachannel_binding()
      {
        callid = callid
      }.get_resources(service, (options) null);
    }

    public static lsnsipalgcall_datachannel_binding[] get_filtered(
      nitro_service service,
      string callid,
      string filter)
    {
      lsnsipalgcall_datachannel_binding datachannelBinding = new lsnsipalgcall_datachannel_binding();
      datachannelBinding.callid = callid;
      options option = new options();
      option.set_filter(filter);
      return (lsnsipalgcall_datachannel_binding[]) datachannelBinding.getfiltered(service, option);
    }

    public static lsnsipalgcall_datachannel_binding[] get_filtered(
      nitro_service service,
      string callid,
      filtervalue[] filter)
    {
      lsnsipalgcall_datachannel_binding datachannelBinding = new lsnsipalgcall_datachannel_binding();
      datachannelBinding.callid = callid;
      options option = new options();
      option.set_filter(filter);
      return (lsnsipalgcall_datachannel_binding[]) datachannelBinding.getfiltered(service, option);
    }

    public static uint count(nitro_service service, string callid)
    {
      lsnsipalgcall_datachannel_binding datachannelBinding = new lsnsipalgcall_datachannel_binding();
      datachannelBinding.callid = callid;
      options option = new options();
      option.set_count(true);
      lsnsipalgcall_datachannel_binding[] resources = (lsnsipalgcall_datachannel_binding[]) datachannelBinding.get_resources(service, option);
      return resources != null && resources.Length > 0 ? resources[0].__count.Value : 0U;
    }

    public static uint count_filtered(nitro_service service, string callid, string filter)
    {
      lsnsipalgcall_datachannel_binding datachannelBinding = new lsnsipalgcall_datachannel_binding();
      datachannelBinding.callid = callid;
      options option = new options();
      option.set_count(true);
      option.set_filter(filter);
      lsnsipalgcall_datachannel_binding[] datachannelBindingArray = (lsnsipalgcall_datachannel_binding[]) datachannelBinding.getfiltered(service, option);
      return datachannelBindingArray != null && datachannelBindingArray.Length > 0 ? datachannelBindingArray[0].__count.Value : 0U;
    }

    public static uint count_filtered(nitro_service service, string callid, filtervalue[] filter)
    {
      lsnsipalgcall_datachannel_binding datachannelBinding = new lsnsipalgcall_datachannel_binding();
      datachannelBinding.callid = callid;
      options option = new options();
      option.set_count(true);
      option.set_filter(filter);
      lsnsipalgcall_datachannel_binding[] datachannelBindingArray = (lsnsipalgcall_datachannel_binding[]) datachannelBinding.getfiltered(service, option);
      return datachannelBindingArray != null && datachannelBindingArray.Length > 0 ? datachannelBindingArray[0].__count.Value : 0U;
    }

    private class lsnsipalgcall_datachannel_binding_response : base_response
    {
      public lsnsipalgcall_datachannel_binding[] lsnsipalgcall_datachannel_binding = (lsnsipalgcall_datachannel_binding[]) null;
    }

    public static class channelprotocolEnum
    {
      public const string HTTP = "HTTP";
      public const string FTP = "FTP";
      public const string TCP = "TCP";
      public const string UDP = "UDP";
      public const string SSL = "SSL";
      public const string SSL_BRIDGE = "SSL_BRIDGE";
      public const string SSL_TCP = "SSL_TCP";
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
      public const string HTTPSVR = "HTTPSVR";
      public const string HTTPCLIENT = "HTTPCLIENT";
      public const string NAT = "NAT";
      public const string HA = "HA";
      public const string AAA = "AAA";
      public const string SINCTCP = "SINCTCP";
      public const string VPN_AFTP = "VPN AFTP";
      public const string MONITORS = "MONITORS";
      public const string SSLVPN_UDP = "SSLVPN UDP";
      public const string SINCUDP = "SINCUDP";
      public const string RIP = "RIP";
      public const string UDP_CLNT = "UDP CLNT";
      public const string SASP = "SASP";
      public const string RPCCLNTS = "RPCCLNTS";
      public const string ROUTE = "ROUTE";
      public const string AUDIT = "AUDIT";
      public const string STA_HTTP = "STA HTTP";
      public const string STA_SSL = "STA SSL";
      public const string DNS_RESOLVE = "DNS RESOLVE";
      public const string RDP = "RDP";
      public const string MYSQL = "MYSQL";
      public const string MSSQL = "MSSQL";
      public const string DIAMETER = "DIAMETER";
      public const string SSL_DIAMETER = "SSL_DIAMETER";
      public const string TFTP = "TFTP";
      public const string ORACLE = "ORACLE";
      public const string ICA = "ICA";
      public const string RADIUS = "RADIUS";
      public const string RADIUSListener = "RADIUSListener";
      public const string SMPP = "SMPP";
      public const string PPTP = "PPTP";
      public const string GRE = "GRE";
      public const string SYSLOGTCP = "SYSLOGTCP";
      public const string SYSLOGUDP = "SYSLOGUDP";
      public const string FIX = "FIX";
      public const string TFTP_DATA = "TFTP_DATA";
    }
  }
}
