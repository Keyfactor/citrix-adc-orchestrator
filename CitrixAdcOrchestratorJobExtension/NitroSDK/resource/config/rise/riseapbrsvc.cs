// Decompiled with JetBrains decompiler
// Type: com.citrix.netscaler.nitro.resource.config.rise.riseapbrsvc
// Assembly: nitro, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 6CF5DDEF-E052-4F9D-953F-6644F8378A66


using com.citrix.netscaler.nitro.exception;
using com.citrix.netscaler.nitro.resource.Base;
using com.citrix.netscaler.nitro.service;
using com.citrix.netscaler.nitro.util;

namespace com.citrix.netscaler.nitro.resource.config.rise
{
  public class riseapbrsvc : base_resource
  {
    private string nameField = (string) null;
    private string risesvctypeField = (string) null;
    private string serveripField = (string) null;
    private string nexthopipField = (string) null;
    private uint? vlanField = new uint?();
    private string protocolField = (string) null;
    private ushort? serverportField = new ushort?();
    private uint? __countField = new uint?();

    public uint? __count
    {
      get => this.__countField;
      private set => this.__countField = value;
    }

    public string name
    {
      get => this.nameField;
      private set => this.nameField = value;
    }

    public string risesvctype
    {
      get => this.risesvctypeField;
      private set => this.risesvctypeField = value;
    }

    public string serverip
    {
      get => this.serveripField;
      private set => this.serveripField = value;
    }

    public string nexthopip
    {
      get => this.nexthopipField;
      private set => this.nexthopipField = value;
    }

    public uint? vlan
    {
      get => this.vlanField;
      private set => this.vlanField = value;
    }

    public string protocol
    {
      get => this.protocolField;
      private set => this.protocolField = value;
    }

    public ushort? serverport
    {
      get => this.serverportField;
      private set => this.serverportField = value;
    }

    internal override base_resource[] get_nitro_response(
      nitro_service service,
      string response)
    {
      riseapbrsvc.riseapbrsvc_response riseapbrsvcResponse = new riseapbrsvc.riseapbrsvc_response();
      riseapbrsvc.riseapbrsvc_response resource = (riseapbrsvc.riseapbrsvc_response) service.get_payload_formatter().string_to_resource(riseapbrsvcResponse.GetType(), response);
      if (resource.errorcode != 0)
      {
        if (resource.errorcode == 444)
          service.clear_session();
        if (resource.severity == null)
          throw new nitro_exception(resource.message, resource.errorcode);
        if (resource.severity.Equals("ERROR"))
          throw new nitro_exception(resource.message, resource.errorcode);
      }
      return (base_resource[]) resource.riseapbrsvc;
    }

    internal override string get_object_name() => (string) null;

    public static riseapbrsvc[] get(nitro_service service) => (riseapbrsvc[]) new riseapbrsvc().get_resources(service, (options) null);

    public static riseapbrsvc[] get(nitro_service service, options option) => (riseapbrsvc[]) new riseapbrsvc().get_resources(service, option);

    public static riseapbrsvc[] get_filtered(nitro_service service, string filter)
    {
      riseapbrsvc riseapbrsvc = new riseapbrsvc();
      options option = new options();
      option.set_filter(filter);
      return (riseapbrsvc[]) riseapbrsvc.getfiltered(service, option);
    }

    public static riseapbrsvc[] get_filtered(nitro_service service, filtervalue[] filter)
    {
      riseapbrsvc riseapbrsvc = new riseapbrsvc();
      options option = new options();
      option.set_filter(filter);
      return (riseapbrsvc[]) riseapbrsvc.getfiltered(service, option);
    }

    public static uint count(nitro_service service)
    {
      riseapbrsvc riseapbrsvc = new riseapbrsvc();
      options option = new options();
      option.set_count(true);
      riseapbrsvc[] resources = (riseapbrsvc[]) riseapbrsvc.get_resources(service, option);
      return resources != null && resources.Length > 0 ? resources[0].__count.Value : 0U;
    }

    public static uint count_filtered(nitro_service service, string filter)
    {
      riseapbrsvc riseapbrsvc = new riseapbrsvc();
      options option = new options();
      option.set_count(true);
      option.set_filter(filter);
      riseapbrsvc[] riseapbrsvcArray = (riseapbrsvc[]) riseapbrsvc.getfiltered(service, option);
      return riseapbrsvcArray != null && riseapbrsvcArray.Length > 0 ? riseapbrsvcArray[0].__count.Value : 0U;
    }

    public static uint count_filtered(nitro_service service, filtervalue[] filter)
    {
      riseapbrsvc riseapbrsvc = new riseapbrsvc();
      options option = new options();
      option.set_count(true);
      option.set_filter(filter);
      riseapbrsvc[] riseapbrsvcArray = (riseapbrsvc[]) riseapbrsvc.getfiltered(service, option);
      return riseapbrsvcArray != null && riseapbrsvcArray.Length > 0 ? riseapbrsvcArray[0].__count.Value : 0U;
    }

    private class riseapbrsvc_response : base_response
    {
      public riseapbrsvc[] riseapbrsvc = (riseapbrsvc[]) null;
    }

    public static class protocolEnum
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

    public static class risesvctypeEnum
    {
      public const string Service = "Service";
      public const string ServiceGroup = "ServiceGroup";
    }
  }
}
