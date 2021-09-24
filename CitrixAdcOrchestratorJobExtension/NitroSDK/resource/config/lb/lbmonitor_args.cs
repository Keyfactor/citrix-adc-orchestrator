// Decompiled with JetBrains decompiler
// Type: com.citrix.netscaler.nitro.resource.config.lb.lbmonitor_args
// Assembly: nitro, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 6CF5DDEF-E052-4F9D-953F-6644F8378A66


namespace com.citrix.netscaler.nitro.resource.config.lb
{
  public class lbmonitor_args
  {
    private string typeField = (string) null;

    public string type
    {
      get => this.typeField;
      set => this.typeField = value;
    }

    public static class typeEnum
    {
      public const string PING = "PING";
      public const string TCP = "TCP";
      public const string HTTP = "HTTP";
      public const string TCP_ECV = "TCP-ECV";
      public const string HTTP_ECV = "HTTP-ECV";
      public const string UDP_ECV = "UDP-ECV";
      public const string DNS = "DNS";
      public const string FTP = "FTP";
      public const string LDNS_PING = "LDNS-PING";
      public const string LDNS_TCP = "LDNS-TCP";
      public const string LDNS_DNS = "LDNS-DNS";
      public const string RADIUS = "RADIUS";
      public const string USER = "USER";
      public const string HTTP_INLINE = "HTTP-INLINE";
      public const string SIP_UDP = "SIP-UDP";
      public const string SIP_TCP = "SIP-TCP";
      public const string LOAD = "LOAD";
      public const string FTP_EXTENDED = "FTP-EXTENDED";
      public const string SMTP = "SMTP";
      public const string SNMP = "SNMP";
      public const string NNTP = "NNTP";
      public const string MYSQL = "MYSQL";
      public const string MYSQL_ECV = "MYSQL-ECV";
      public const string MSSQL_ECV = "MSSQL-ECV";
      public const string ORACLE_ECV = "ORACLE-ECV";
      public const string LDAP = "LDAP";
      public const string POP3 = "POP3";
      public const string CITRIX_XML_SERVICE = "CITRIX-XML-SERVICE";
      public const string CITRIX_WEB_INTERFACE = "CITRIX-WEB-INTERFACE";
      public const string DNS_TCP = "DNS-TCP";
      public const string RTSP = "RTSP";
      public const string ARP = "ARP";
      public const string CITRIX_AG = "CITRIX-AG";
      public const string CITRIX_AAC_LOGINPAGE = "CITRIX-AAC-LOGINPAGE";
      public const string CITRIX_AAC_LAS = "CITRIX-AAC-LAS";
      public const string CITRIX_XD_DDC = "CITRIX-XD-DDC";
      public const string ND6 = "ND6";
      public const string CITRIX_WI_EXTENDED = "CITRIX-WI-EXTENDED";
      public const string DIAMETER = "DIAMETER";
      public const string RADIUS_ACCOUNTING = "RADIUS_ACCOUNTING";
      public const string STOREFRONT = "STOREFRONT";
      public const string APPC = "APPC";
      public const string SMPP = "SMPP";
      public const string CITRIX_XNC_ECV = "CITRIX-XNC-ECV";
      public const string CITRIX_XDM = "CITRIX-XDM";
    }
  }
}
