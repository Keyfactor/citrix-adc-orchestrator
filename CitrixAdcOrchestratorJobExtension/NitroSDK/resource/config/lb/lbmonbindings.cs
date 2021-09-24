// Decompiled with JetBrains decompiler
// Type: com.citrix.netscaler.nitro.resource.config.lb.lbmonbindings
// Assembly: nitro, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 6CF5DDEF-E052-4F9D-953F-6644F8378A66


using com.citrix.netscaler.nitro.exception;
using com.citrix.netscaler.nitro.resource.Base;
using com.citrix.netscaler.nitro.service;
using com.citrix.netscaler.nitro.util;

namespace com.citrix.netscaler.nitro.resource.config.lb
{
  public class lbmonbindings : base_resource
  {
    private string monitornameField = (string) null;
    private string typeField = (string) null;
    private string stateField = (string) null;
    private uint? __countField = new uint?();

    public uint? __count
    {
      get => this.__countField;
      private set => this.__countField = value;
    }

    public string monitorname
    {
      get => this.monitornameField;
      set => this.monitornameField = value;
    }

    public string type
    {
      get => this.typeField;
      private set => this.typeField = value;
    }

    public string state
    {
      get => this.stateField;
      private set => this.stateField = value;
    }

    internal override base_resource[] get_nitro_response(
      nitro_service service,
      string response)
    {
      lbmonbindings.lbmonbindings_response lbmonbindingsResponse = new lbmonbindings.lbmonbindings_response();
      lbmonbindings.lbmonbindings_response resource = (lbmonbindings.lbmonbindings_response) service.get_payload_formatter().string_to_resource(lbmonbindingsResponse.GetType(), response);
      if (resource.errorcode != 0)
      {
        if (resource.errorcode == 444)
          service.clear_session();
        if (resource.severity == null)
          throw new nitro_exception(resource.message, resource.errorcode);
        if (resource.severity.Equals("ERROR"))
          throw new nitro_exception(resource.message, resource.errorcode);
      }
      return (base_resource[]) resource.lbmonbindings;
    }

    internal override string get_object_name() => this.monitorname;

    public static lbmonbindings get(nitro_service service, string monitorname) => (lbmonbindings) new lbmonbindings()
    {
      monitorname = monitorname
    }.get_resource(service);

    public static lbmonbindings[] get(nitro_service service, string[] monitorname)
    {
      if (monitorname == null || monitorname.Length <= 0)
        return (lbmonbindings[]) null;
      lbmonbindings[] lbmonbindingsArray1 = new lbmonbindings[monitorname.Length];
      lbmonbindings[] lbmonbindingsArray2 = new lbmonbindings[monitorname.Length];
      for (int index = 0; index < monitorname.Length; ++index)
      {
        lbmonbindingsArray2[index] = new lbmonbindings();
        lbmonbindingsArray2[index].monitorname = monitorname[index];
        lbmonbindingsArray1[index] = (lbmonbindings) lbmonbindingsArray2[index].get_resource(service);
      }
      return lbmonbindingsArray1;
    }

    public static lbmonbindings[] get_filtered(
      nitro_service service,
      lbmonbindings obj,
      string filter)
    {
      options option = new options();
      option.set_filter(filter);
      option.set_args(nitro_util.object_to_string_withoutquotes((object) obj));
      return (lbmonbindings[]) obj.getfiltered(service, option);
    }

    public static lbmonbindings[] get_filtered(
      nitro_service service,
      lbmonbindings obj,
      filtervalue[] filter)
    {
      options option = new options();
      option.set_filter(filter);
      option.set_args(nitro_util.object_to_string_withoutquotes((object) obj));
      return (lbmonbindings[]) obj.getfiltered(service, option);
    }

    public static uint count(nitro_service service, lbmonbindings obj)
    {
      options option = new options();
      option.set_count(true);
      option.set_args(nitro_util.object_to_string_withoutquotes((object) obj));
      lbmonbindings[] resources = (lbmonbindings[]) obj.get_resources(service, option);
      return resources != null && resources.Length > 0 ? resources[0].__count.Value : 0U;
    }

    public static uint count_filtered(nitro_service service, lbmonbindings obj, string filter)
    {
      options option = new options();
      option.set_count(true);
      option.set_filter(filter);
      option.set_args(nitro_util.object_to_string_withoutquotes((object) obj));
      lbmonbindings[] lbmonbindingsArray = (lbmonbindings[]) obj.getfiltered(service, option);
      return lbmonbindingsArray != null && lbmonbindingsArray.Length > 0 ? lbmonbindingsArray[0].__count.Value : 0U;
    }

    public static uint count_filtered(
      nitro_service service,
      lbmonbindings obj,
      filtervalue[] filter)
    {
      options option = new options();
      option.set_count(true);
      option.set_filter(filter);
      option.set_args(nitro_util.object_to_string_withoutquotes((object) obj));
      lbmonbindings[] lbmonbindingsArray = (lbmonbindings[]) obj.getfiltered(service, option);
      return lbmonbindingsArray != null && lbmonbindingsArray.Length > 0 ? lbmonbindingsArray[0].__count.Value : 0U;
    }

    private class lbmonbindings_response : base_response
    {
      public lbmonbindings[] lbmonbindings = (lbmonbindings[]) null;
    }

    public static class stateEnum
    {
      public const string ENABLED = "ENABLED";
      public const string DISABLED = "DISABLED";
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
