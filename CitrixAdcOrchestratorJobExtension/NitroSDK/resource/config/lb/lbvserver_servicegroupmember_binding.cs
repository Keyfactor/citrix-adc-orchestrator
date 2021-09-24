// Decompiled with JetBrains decompiler
// Type: com.citrix.netscaler.nitro.resource.config.lb.lbvserver_servicegroupmember_binding
// Assembly: nitro, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 6CF5DDEF-E052-4F9D-953F-6644F8378A66


using com.citrix.netscaler.nitro.exception;
using com.citrix.netscaler.nitro.resource.Base;
using com.citrix.netscaler.nitro.service;
using com.citrix.netscaler.nitro.util;

namespace com.citrix.netscaler.nitro.resource.config.lb
{
  public class lbvserver_servicegroupmember_binding : base_resource
  {
    private string servicegroupnameField = (string) null;
    private string ipv46Field = (string) null;
    private ushort? portField = new ushort?();
    private string servicetypeField = (string) null;
    private string curstateField = (string) null;
    private uint? weightField = new uint?();
    private uint? dynamicweightField = new uint?();
    private string cookieipportField = (string) null;
    private string cookienameField = (string) null;
    private string vserveridField = (string) null;
    private string preferredlocationField = (string) null;
    private string nameField = (string) null;
    private uint? __countField = new uint?();

    public uint? __count
    {
      get => this.__countField;
      set => this.__countField = value;
    }

    public uint? weight
    {
      get => this.weightField;
      set => this.weightField = value;
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

    public string preferredlocation
    {
      get => this.preferredlocationField;
      private set => this.preferredlocationField = value;
    }

    public string vserverid
    {
      get => this.vserveridField;
      private set => this.vserveridField = value;
    }

    public string cookiename
    {
      get => this.cookienameField;
      private set => this.cookienameField = value;
    }

    public string servicetype
    {
      get => this.servicetypeField;
      private set => this.servicetypeField = value;
    }

    public string cookieipport
    {
      get => this.cookieipportField;
      private set => this.cookieipportField = value;
    }

    public ushort? port
    {
      get => this.portField;
      private set => this.portField = value;
    }

    public string curstate
    {
      get => this.curstateField;
      private set => this.curstateField = value;
    }

    public string ipv46
    {
      get => this.ipv46Field;
      private set => this.ipv46Field = value;
    }

    public uint? dynamicweight
    {
      get => this.dynamicweightField;
      private set => this.dynamicweightField = value;
    }

    internal override base_resource[] get_nitro_response(
      nitro_service service,
      string response)
    {
      lbvserver_servicegroupmember_binding.lbvserver_servicegroupmember_binding_response servicegroupmemberBindingResponse = new lbvserver_servicegroupmember_binding.lbvserver_servicegroupmember_binding_response();
      lbvserver_servicegroupmember_binding.lbvserver_servicegroupmember_binding_response resource = (lbvserver_servicegroupmember_binding.lbvserver_servicegroupmember_binding_response) service.get_payload_formatter().string_to_resource(servicegroupmemberBindingResponse.GetType(), response);
      if (resource.errorcode != 0)
      {
        if (resource.errorcode == 444)
          service.clear_session();
        if (resource.severity == null)
          throw new nitro_exception(resource.message, resource.errorcode);
        if (resource.severity.Equals("ERROR"))
          throw new nitro_exception(resource.message, resource.errorcode);
      }
      return (base_resource[]) resource.lbvserver_servicegroupmember_binding;
    }

    internal override string get_object_name() => this.name;

    public static lbvserver_servicegroupmember_binding[] get(
      nitro_service service,
      string name)
    {
      return (lbvserver_servicegroupmember_binding[]) new lbvserver_servicegroupmember_binding()
      {
        name = name
      }.get_resources(service, (options) null);
    }

    public static lbvserver_servicegroupmember_binding[] get_filtered(
      nitro_service service,
      string name,
      string filter)
    {
      lbvserver_servicegroupmember_binding servicegroupmemberBinding = new lbvserver_servicegroupmember_binding();
      servicegroupmemberBinding.name = name;
      options option = new options();
      option.set_filter(filter);
      return (lbvserver_servicegroupmember_binding[]) servicegroupmemberBinding.getfiltered(service, option);
    }

    public static lbvserver_servicegroupmember_binding[] get_filtered(
      nitro_service service,
      string name,
      filtervalue[] filter)
    {
      lbvserver_servicegroupmember_binding servicegroupmemberBinding = new lbvserver_servicegroupmember_binding();
      servicegroupmemberBinding.name = name;
      options option = new options();
      option.set_filter(filter);
      return (lbvserver_servicegroupmember_binding[]) servicegroupmemberBinding.getfiltered(service, option);
    }

    public static uint count(nitro_service service, string name)
    {
      lbvserver_servicegroupmember_binding servicegroupmemberBinding = new lbvserver_servicegroupmember_binding();
      servicegroupmemberBinding.name = name;
      options option = new options();
      option.set_count(true);
      lbvserver_servicegroupmember_binding[] resources = (lbvserver_servicegroupmember_binding[]) servicegroupmemberBinding.get_resources(service, option);
      return resources != null && resources.Length > 0 ? resources[0].__count.Value : 0U;
    }

    public static uint count_filtered(nitro_service service, string name, string filter)
    {
      lbvserver_servicegroupmember_binding servicegroupmemberBinding = new lbvserver_servicegroupmember_binding();
      servicegroupmemberBinding.name = name;
      options option = new options();
      option.set_count(true);
      option.set_filter(filter);
      lbvserver_servicegroupmember_binding[] servicegroupmemberBindingArray = (lbvserver_servicegroupmember_binding[]) servicegroupmemberBinding.getfiltered(service, option);
      return servicegroupmemberBindingArray != null && servicegroupmemberBindingArray.Length > 0 ? servicegroupmemberBindingArray[0].__count.Value : 0U;
    }

    public static uint count_filtered(nitro_service service, string name, filtervalue[] filter)
    {
      lbvserver_servicegroupmember_binding servicegroupmemberBinding = new lbvserver_servicegroupmember_binding();
      servicegroupmemberBinding.name = name;
      options option = new options();
      option.set_count(true);
      option.set_filter(filter);
      lbvserver_servicegroupmember_binding[] servicegroupmemberBindingArray = (lbvserver_servicegroupmember_binding[]) servicegroupmemberBinding.getfiltered(service, option);
      return servicegroupmemberBindingArray != null && servicegroupmemberBindingArray.Length > 0 ? servicegroupmemberBindingArray[0].__count.Value : 0U;
    }

    private class lbvserver_servicegroupmember_binding_response : base_response
    {
      public lbvserver_servicegroupmember_binding[] lbvserver_servicegroupmember_binding = (lbvserver_servicegroupmember_binding[]) null;
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

    public static class bindpointEnum
    {
      public const string REQUEST = "REQUEST";
      public const string RESPONSE = "RESPONSE";
    }

    public static class labeltypeEnum
    {
      public const string reqvserver = "reqvserver";
      public const string resvserver = "resvserver";
      public const string policylabel = "policylabel";
    }

    public static class curstateEnum
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
