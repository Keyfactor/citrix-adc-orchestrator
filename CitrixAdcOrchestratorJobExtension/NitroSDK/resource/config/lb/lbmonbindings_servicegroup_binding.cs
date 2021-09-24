// Decompiled with JetBrains decompiler
// Type: com.citrix.netscaler.nitro.resource.config.lb.lbmonbindings_servicegroup_binding
// Assembly: nitro, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 6CF5DDEF-E052-4F9D-953F-6644F8378A66


using com.citrix.netscaler.nitro.exception;
using com.citrix.netscaler.nitro.resource.Base;
using com.citrix.netscaler.nitro.service;
using com.citrix.netscaler.nitro.util;

namespace com.citrix.netscaler.nitro.resource.config.lb
{
  public class lbmonbindings_servicegroup_binding : base_resource
  {
    private string servicegroupnameField = (string) null;
    private string servicetypeField = (string) null;
    private string boundservicegroupsvrstateField = (string) null;
    private string monstateField = (string) null;
    private string monitornameField = (string) null;
    private uint? __countField = new uint?();

    public uint? __count
    {
      get => this.__countField;
      set => this.__countField = value;
    }

    public string monitorname
    {
      get => this.monitornameField;
      set => this.monitornameField = value;
    }

    public string servicegroupname
    {
      get => this.servicegroupnameField;
      set => this.servicegroupnameField = value;
    }

    public string boundservicegroupsvrstate
    {
      get => this.boundservicegroupsvrstateField;
      private set => this.boundservicegroupsvrstateField = value;
    }

    public string monstate
    {
      get => this.monstateField;
      private set => this.monstateField = value;
    }

    public string servicetype
    {
      get => this.servicetypeField;
      private set => this.servicetypeField = value;
    }

    internal override base_resource[] get_nitro_response(
      nitro_service service,
      string response)
    {
      lbmonbindings_servicegroup_binding.lbmonbindings_servicegroup_binding_response servicegroupBindingResponse = new lbmonbindings_servicegroup_binding.lbmonbindings_servicegroup_binding_response();
      lbmonbindings_servicegroup_binding.lbmonbindings_servicegroup_binding_response resource = (lbmonbindings_servicegroup_binding.lbmonbindings_servicegroup_binding_response) service.get_payload_formatter().string_to_resource(servicegroupBindingResponse.GetType(), response);
      if (resource.errorcode != 0)
      {
        if (resource.errorcode == 444)
          service.clear_session();
        if (resource.severity == null)
          throw new nitro_exception(resource.message, resource.errorcode);
        if (resource.severity.Equals("ERROR"))
          throw new nitro_exception(resource.message, resource.errorcode);
      }
      return (base_resource[]) resource.lbmonbindings_servicegroup_binding;
    }

    internal override string get_object_name() => this.monitorname;

    public static lbmonbindings_servicegroup_binding[] get(
      nitro_service service,
      string monitorname)
    {
      return (lbmonbindings_servicegroup_binding[]) new lbmonbindings_servicegroup_binding()
      {
        monitorname = monitorname
      }.get_resources(service, (options) null);
    }

    public static lbmonbindings_servicegroup_binding[] get_filtered(
      nitro_service service,
      string monitorname,
      string filter)
    {
      lbmonbindings_servicegroup_binding servicegroupBinding = new lbmonbindings_servicegroup_binding();
      servicegroupBinding.monitorname = monitorname;
      options option = new options();
      option.set_filter(filter);
      return (lbmonbindings_servicegroup_binding[]) servicegroupBinding.getfiltered(service, option);
    }

    public static lbmonbindings_servicegroup_binding[] get_filtered(
      nitro_service service,
      string monitorname,
      filtervalue[] filter)
    {
      lbmonbindings_servicegroup_binding servicegroupBinding = new lbmonbindings_servicegroup_binding();
      servicegroupBinding.monitorname = monitorname;
      options option = new options();
      option.set_filter(filter);
      return (lbmonbindings_servicegroup_binding[]) servicegroupBinding.getfiltered(service, option);
    }

    public static uint count(nitro_service service, string monitorname)
    {
      lbmonbindings_servicegroup_binding servicegroupBinding = new lbmonbindings_servicegroup_binding();
      servicegroupBinding.monitorname = monitorname;
      options option = new options();
      option.set_count(true);
      lbmonbindings_servicegroup_binding[] resources = (lbmonbindings_servicegroup_binding[]) servicegroupBinding.get_resources(service, option);
      return resources != null && resources.Length > 0 ? resources[0].__count.Value : 0U;
    }

    public static uint count_filtered(nitro_service service, string monitorname, string filter)
    {
      lbmonbindings_servicegroup_binding servicegroupBinding = new lbmonbindings_servicegroup_binding();
      servicegroupBinding.monitorname = monitorname;
      options option = new options();
      option.set_count(true);
      option.set_filter(filter);
      lbmonbindings_servicegroup_binding[] servicegroupBindingArray = (lbmonbindings_servicegroup_binding[]) servicegroupBinding.getfiltered(service, option);
      return servicegroupBindingArray != null && servicegroupBindingArray.Length > 0 ? servicegroupBindingArray[0].__count.Value : 0U;
    }

    public static uint count_filtered(
      nitro_service service,
      string monitorname,
      filtervalue[] filter)
    {
      lbmonbindings_servicegroup_binding servicegroupBinding = new lbmonbindings_servicegroup_binding();
      servicegroupBinding.monitorname = monitorname;
      options option = new options();
      option.set_count(true);
      option.set_filter(filter);
      lbmonbindings_servicegroup_binding[] servicegroupBindingArray = (lbmonbindings_servicegroup_binding[]) servicegroupBinding.getfiltered(service, option);
      return servicegroupBindingArray != null && servicegroupBindingArray.Length > 0 ? servicegroupBindingArray[0].__count.Value : 0U;
    }

    private class lbmonbindings_servicegroup_binding_response : base_response
    {
      public lbmonbindings_servicegroup_binding[] lbmonbindings_servicegroup_binding = (lbmonbindings_servicegroup_binding[]) null;
    }

    public static class boundservicegroupsvrstateEnum
    {
      public const string ENABLED = "ENABLED";
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

    public static class monstateEnum
    {
      public const string ENABLED = "ENABLED";
      public const string DISABLED = "DISABLED";
    }
  }
}
