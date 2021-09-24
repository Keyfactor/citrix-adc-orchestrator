// Decompiled with JetBrains decompiler
// Type: com.citrix.netscaler.nitro.resource.config.ns.nsconnectiontable
// Assembly: nitro, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 6CF5DDEF-E052-4F9D-953F-6644F8378A66


using com.citrix.netscaler.nitro.exception;
using com.citrix.netscaler.nitro.resource.Base;
using com.citrix.netscaler.nitro.service;
using com.citrix.netscaler.nitro.util;

namespace com.citrix.netscaler.nitro.resource.config.ns
{
  public class nsconnectiontable : base_resource
  {
    private string filterexpressionField = (string) null;
    private bool? linkField = new bool?();
    private bool? nameField = new bool?();
    private string[] detailField = (string[]) null;
    private bool? listenField = new bool?();
    private string sourceipField = (string) null;
    private ushort? sourceportField = new ushort?();
    private string destipField = (string) null;
    private ushort? destportField = new ushort?();
    private string svctypeField = (string) null;
    private int? idletimeField = new int?();
    private string stateField = (string) null;
    private string linksourceipField = (string) null;
    private ushort? linksourceportField = new ushort?();
    private string linkdestipField = (string) null;
    private ushort? linkdestportField = new ushort?();
    private string linkservicetypeField = (string) null;
    private int? linkidletimeField = new int?();
    private string linkstateField = (string) null;
    private string entitynameField = (string) null;
    private string linkentitynameField = (string) null;
    private long? connidField = new long?();
    private long? linkconnidField = new long?();
    private string[] connpropertiesField = (string[]) null;
    private string[] optionflagsField = (string[]) null;
    private uint? nswsvalueField = new uint?();
    private uint? peerwsvalueField = new uint?();
    private int? mssField = new int?();
    private int? retxretrycntField = new int?();
    private int? rcvwndField = new int?();
    private int? advwndField = new int?();
    private int? sndcwndField = new int?();
    private int? issField = new int?();
    private int? irsField = new int?();
    private int? rcvnxtField = new int?();
    private int? maxackField = new int?();
    private int? sndnxtField = new int?();
    private int? sndunackField = new int?();
    private int? httpendseqField = new int?();
    private string httpstateField = (string) null;
    private int? trcountField = new int?();
    private string priorityField = (string) null;
    private string httpreqverField = (string) null;
    private string httprequestField = (string) null;
    private int? httprspcodeField = new int?();
    private int? rttsmoothedField = new int?();
    private int? rttvarianceField = new int?();
    private int? outoforderpktsField = new int?();
    private string[] linkoptionflagField = (string[]) null;
    private uint? linknswsvalueField = new uint?();
    private uint? linkpeerwsvalueField = new uint?();
    private int? targetnodeidnnmField = new int?();
    private int? sourcenodeidnnmField = new int?();
    private uint? channelidnnmField = new uint?();
    private uint? msgversionnnmField = new uint?();
    private uint? tdField = new uint?();
    private uint? __countField = new uint?();

    public uint? __count
    {
      get => this.__countField;
      private set => this.__countField = value;
    }

    public string filterexpression
    {
      get => this.filterexpressionField;
      set => this.filterexpressionField = value;
    }

    public bool? link
    {
      get => this.linkField;
      set => this.linkField = value;
    }

    public bool? name
    {
      get => this.nameField;
      set => this.nameField = value;
    }

    public string[] detail
    {
      get => this.detailField;
      set => this.detailField = value;
    }

    public bool? listen
    {
      get => this.listenField;
      set => this.listenField = value;
    }

    public string sourceip
    {
      get => this.sourceipField;
      private set => this.sourceipField = value;
    }

    public ushort? sourceport
    {
      get => this.sourceportField;
      private set => this.sourceportField = value;
    }

    public string destip
    {
      get => this.destipField;
      private set => this.destipField = value;
    }

    public ushort? destport
    {
      get => this.destportField;
      private set => this.destportField = value;
    }

    public string svctype
    {
      get => this.svctypeField;
      private set => this.svctypeField = value;
    }

    public int? idletime
    {
      get => this.idletimeField;
      private set => this.idletimeField = value;
    }

    public string state
    {
      get => this.stateField;
      private set => this.stateField = value;
    }

    public string linksourceip
    {
      get => this.linksourceipField;
      private set => this.linksourceipField = value;
    }

    public ushort? linksourceport
    {
      get => this.linksourceportField;
      private set => this.linksourceportField = value;
    }

    public string linkdestip
    {
      get => this.linkdestipField;
      private set => this.linkdestipField = value;
    }

    public ushort? linkdestport
    {
      get => this.linkdestportField;
      private set => this.linkdestportField = value;
    }

    public string linkservicetype
    {
      get => this.linkservicetypeField;
      private set => this.linkservicetypeField = value;
    }

    public int? linkidletime
    {
      get => this.linkidletimeField;
      private set => this.linkidletimeField = value;
    }

    public string linkstate
    {
      get => this.linkstateField;
      private set => this.linkstateField = value;
    }

    public string entityname
    {
      get => this.entitynameField;
      private set => this.entitynameField = value;
    }

    public string linkentityname
    {
      get => this.linkentitynameField;
      private set => this.linkentitynameField = value;
    }

    public long? connid
    {
      get => this.connidField;
      private set => this.connidField = value;
    }

    public long? linkconnid
    {
      get => this.linkconnidField;
      private set => this.linkconnidField = value;
    }

    public string[] connproperties
    {
      get => this.connpropertiesField;
      private set => this.connpropertiesField = value;
    }

    public string[] optionflags
    {
      get => this.optionflagsField;
      private set => this.optionflagsField = value;
    }

    public uint? nswsvalue
    {
      get => this.nswsvalueField;
      private set => this.nswsvalueField = value;
    }

    public uint? peerwsvalue
    {
      get => this.peerwsvalueField;
      private set => this.peerwsvalueField = value;
    }

    public int? mss
    {
      get => this.mssField;
      private set => this.mssField = value;
    }

    public int? retxretrycnt
    {
      get => this.retxretrycntField;
      private set => this.retxretrycntField = value;
    }

    public int? rcvwnd
    {
      get => this.rcvwndField;
      private set => this.rcvwndField = value;
    }

    public int? advwnd
    {
      get => this.advwndField;
      private set => this.advwndField = value;
    }

    public int? sndcwnd
    {
      get => this.sndcwndField;
      private set => this.sndcwndField = value;
    }

    public int? iss
    {
      get => this.issField;
      private set => this.issField = value;
    }

    public int? irs
    {
      get => this.irsField;
      private set => this.irsField = value;
    }

    public int? rcvnxt
    {
      get => this.rcvnxtField;
      private set => this.rcvnxtField = value;
    }

    public int? maxack
    {
      get => this.maxackField;
      private set => this.maxackField = value;
    }

    public int? sndnxt
    {
      get => this.sndnxtField;
      private set => this.sndnxtField = value;
    }

    public int? sndunack
    {
      get => this.sndunackField;
      private set => this.sndunackField = value;
    }

    public int? httpendseq
    {
      get => this.httpendseqField;
      private set => this.httpendseqField = value;
    }

    public string httpstate
    {
      get => this.httpstateField;
      private set => this.httpstateField = value;
    }

    public int? trcount
    {
      get => this.trcountField;
      private set => this.trcountField = value;
    }

    public string priority
    {
      get => this.priorityField;
      private set => this.priorityField = value;
    }

    public string httpreqver
    {
      get => this.httpreqverField;
      private set => this.httpreqverField = value;
    }

    public string httprequest
    {
      get => this.httprequestField;
      private set => this.httprequestField = value;
    }

    public int? httprspcode
    {
      get => this.httprspcodeField;
      private set => this.httprspcodeField = value;
    }

    public int? rttsmoothed
    {
      get => this.rttsmoothedField;
      private set => this.rttsmoothedField = value;
    }

    public int? rttvariance
    {
      get => this.rttvarianceField;
      private set => this.rttvarianceField = value;
    }

    public int? outoforderpkts
    {
      get => this.outoforderpktsField;
      private set => this.outoforderpktsField = value;
    }

    public string[] linkoptionflag
    {
      get => this.linkoptionflagField;
      private set => this.linkoptionflagField = value;
    }

    public uint? linknswsvalue
    {
      get => this.linknswsvalueField;
      private set => this.linknswsvalueField = value;
    }

    public uint? linkpeerwsvalue
    {
      get => this.linkpeerwsvalueField;
      private set => this.linkpeerwsvalueField = value;
    }

    public int? targetnodeidnnm
    {
      get => this.targetnodeidnnmField;
      private set => this.targetnodeidnnmField = value;
    }

    public int? sourcenodeidnnm
    {
      get => this.sourcenodeidnnmField;
      private set => this.sourcenodeidnnmField = value;
    }

    public uint? channelidnnm
    {
      get => this.channelidnnmField;
      private set => this.channelidnnmField = value;
    }

    public uint? msgversionnnm
    {
      get => this.msgversionnnmField;
      private set => this.msgversionnnmField = value;
    }

    public uint? td
    {
      get => this.tdField;
      private set => this.tdField = value;
    }

    internal override base_resource[] get_nitro_response(
      nitro_service service,
      string response)
    {
      nsconnectiontable.nsconnectiontable_response nsconnectiontableResponse = new nsconnectiontable.nsconnectiontable_response();
      nsconnectiontable.nsconnectiontable_response resource = (nsconnectiontable.nsconnectiontable_response) service.get_payload_formatter().string_to_resource(nsconnectiontableResponse.GetType(), response);
      if (resource.errorcode != 0)
      {
        if (resource.errorcode == 444)
          service.clear_session();
        if (resource.severity == null)
          throw new nitro_exception(resource.message, resource.errorcode);
        if (resource.severity.Equals("ERROR"))
          throw new nitro_exception(resource.message, resource.errorcode);
      }
      return (base_resource[]) resource.nsconnectiontable;
    }

    internal override string get_object_name() => (string) null;

    public static nsconnectiontable[] get(nitro_service service) => (nsconnectiontable[]) new nsconnectiontable().get_resources(service, (options) null);

    public static nsconnectiontable[] get(nitro_service service, options option) => (nsconnectiontable[]) new nsconnectiontable().get_resources(service, option);

    public static nsconnectiontable[] get(
      nitro_service service,
      nsconnectiontable_args args)
    {
      nsconnectiontable nsconnectiontable = new nsconnectiontable();
      options option = new options();
      option.set_args(nitro_util.object_to_string_withoutquotes((object) args));
      return (nsconnectiontable[]) nsconnectiontable.get_resources(service, option);
    }

    public static nsconnectiontable[] get_filtered(
      nitro_service service,
      string filter)
    {
      nsconnectiontable nsconnectiontable = new nsconnectiontable();
      options option = new options();
      option.set_filter(filter);
      return (nsconnectiontable[]) nsconnectiontable.getfiltered(service, option);
    }

    public static nsconnectiontable[] get_filtered(
      nitro_service service,
      filtervalue[] filter)
    {
      nsconnectiontable nsconnectiontable = new nsconnectiontable();
      options option = new options();
      option.set_filter(filter);
      return (nsconnectiontable[]) nsconnectiontable.getfiltered(service, option);
    }

    public static uint count(nitro_service service)
    {
      nsconnectiontable nsconnectiontable = new nsconnectiontable();
      options option = new options();
      option.set_count(true);
      nsconnectiontable[] resources = (nsconnectiontable[]) nsconnectiontable.get_resources(service, option);
      return resources != null && resources.Length > 0 ? resources[0].__count.Value : 0U;
    }

    public static uint count_filtered(nitro_service service, string filter)
    {
      nsconnectiontable nsconnectiontable = new nsconnectiontable();
      options option = new options();
      option.set_count(true);
      option.set_filter(filter);
      nsconnectiontable[] nsconnectiontableArray = (nsconnectiontable[]) nsconnectiontable.getfiltered(service, option);
      return nsconnectiontableArray != null && nsconnectiontableArray.Length > 0 ? nsconnectiontableArray[0].__count.Value : 0U;
    }

    public static uint count_filtered(nitro_service service, filtervalue[] filter)
    {
      nsconnectiontable nsconnectiontable = new nsconnectiontable();
      options option = new options();
      option.set_count(true);
      option.set_filter(filter);
      nsconnectiontable[] nsconnectiontableArray = (nsconnectiontable[]) nsconnectiontable.getfiltered(service, option);
      return nsconnectiontableArray != null && nsconnectiontableArray.Length > 0 ? nsconnectiontableArray[0].__count.Value : 0U;
    }

    private class nsconnectiontable_response : base_response
    {
      public nsconnectiontable[] nsconnectiontable = (nsconnectiontable[]) null;
    }

    public static class priorityEnum
    {
      public const string SC_Priority = "SC Priority";
      public const string Priority_queue1 = "Priority queue1";
      public const string priority_queue2 = "priority queue2";
      public const string priority_queue3 = "priority queue3";
      public const string DoS_Priority = "DoS Priority";
      public const string Surge_Priority = "Surge Priority";
    }

    public static class linkoptionflagEnum
    {
      public const string sack = "sack";
      public const string timstmp = "timstmp";
      public const string ws = "ws";
    }

    public static class stateEnum
    {
      public const string CLOSED = "CLOSED";
      public const string LISTEN = "LISTEN";
      public const string SYN_SENT = "SYN_SENT";
      public const string SYN_RECEIVED = "SYN_RECEIVED";
      public const string ESTABLISHED = "ESTABLISHED";
      public const string CLOSE_WAIT = "CLOSE_WAIT";
      public const string FIN_WAIT_1 = "FIN_WAIT_1";
      public const string CLOSING = "CLOSING";
      public const string LAST_ACK = "LAST_ACK";
      public const string FIN_WAIT_2 = "FIN_WAIT_2";
      public const string TIME_WAIT = "TIME_WAIT";
      public const string NA = "NA";
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

    public static class connpropertiesEnum
    {
      public const string LINK = "LINK";
      public const string HASLINK = "HASLINK";
      public const string CLIENT = "CLIENT";
      public const string SERVER = "SERVER";
      public const string NNM = "NNM";
      public const string MPTCP = "MPTCP";
      public const string SUBFLOW = "SUBFLOW";
    }

    public static class httpreqverEnum
    {
      public const string HTTP_1_0 = "HTTP_1_0";
      public const string HTTP_1_1 = "HTTP_1_1";
      public const string HTTP_0_9 = "HTTP_0_9";
      public const string RTSP_1_0 = "RTSP_1_0";
      public const string SIP_2_0 = "SIP_2_0";
      public const string VPN_ICA_SOCKS = "VPN_ICA_SOCKS";
      public const string VPN_ICA_CGP = "VPN_ICA_CGP";
    }

    public static class httprequestEnum
    {
      public const string OPTIONS = "OPTIONS";
      public const string GET = "GET";
      public const string HEAD = "HEAD";
      public const string POST = "POST";
      public const string PUT = "PUT";
      public const string DELETE = "DELETE";
      public const string TRACE = "TRACE";
      public const string CONNECT = "CONNECT";
      public const string RPCCONNECT = "RPCCONNECT";
    }

    public static class httpstateEnum
    {
      public const string INITIALIZED = "INITIALIZED";
      public const string CONTENT_LENGTH = "CONTENT_LENGTH";
      public const string CHUNKED = "CHUNKED";
      public const string WAIT_FINAL_ACK = "WAIT_FINAL_ACK";
      public const string UNKNOWN = "UNKNOWN";
      public const string DONE = "DONE";
      public const string WAIT_FIN = "WAIT_FIN";
    }

    public static class linkstateEnum
    {
      public const string CLOSED = "CLOSED";
      public const string LISTEN = "LISTEN";
      public const string SYN_SENT = "SYN_SENT";
      public const string SYN_RECEIVED = "SYN_RECEIVED";
      public const string ESTABLISHED = "ESTABLISHED";
      public const string CLOSE_WAIT = "CLOSE_WAIT";
      public const string FIN_WAIT_1 = "FIN_WAIT_1";
      public const string CLOSING = "CLOSING";
      public const string LAST_ACK = "LAST_ACK";
      public const string FIN_WAIT_2 = "FIN_WAIT_2";
      public const string TIME_WAIT = "TIME_WAIT";
      public const string NA = "NA";
    }

    public static class optionflagsEnum
    {
      public const string sack = "sack";
      public const string timstmp = "timstmp";
      public const string ws = "ws";
    }

    public static class detailEnum
    {
      public const string LINK = "LINK";
      public const string NAME = "NAME";
      public const string CONNFAILOVER = "CONNFAILOVER";
      public const string FULL = "FULL";
      public const string NNM = "NNM";
    }

    public static class linkservicetypeEnum
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
