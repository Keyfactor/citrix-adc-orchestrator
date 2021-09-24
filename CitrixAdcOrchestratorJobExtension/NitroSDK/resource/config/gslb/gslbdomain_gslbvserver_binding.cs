// Decompiled with JetBrains decompiler
// Type: com.citrix.netscaler.nitro.resource.config.gslb.gslbdomain_gslbvserver_binding
// Assembly: nitro, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 6CF5DDEF-E052-4F9D-953F-6644F8378A66


using com.citrix.netscaler.nitro.exception;
using com.citrix.netscaler.nitro.resource.Base;
using com.citrix.netscaler.nitro.service;
using com.citrix.netscaler.nitro.util;

namespace com.citrix.netscaler.nitro.resource.config.gslb
{
  public class gslbdomain_gslbvserver_binding : base_resource
  {
    private string vservernameField = (string) null;
    private string servicetypeField = (string) null;
    private string stateField = (string) null;
    private string lbmethodField = (string) null;
    private string dnsrecordtypeField = (string) null;
    private string backuplbmethodField = (string) null;
    private string persistencetypeField = (string) null;
    private string edrField = (string) null;
    private string mirField = (string) null;
    private string dynamicweightField = (string) null;
    private string statechangetimesecField = (string) null;
    private string cipField = (string) null;
    private uint? persistenceidField = new uint?();
    private string netmaskField = (string) null;
    private uint? v6netmasklenField = new uint?();
    private string sitenameField = (string) null;
    private string sitepersistenceField = (string) null;
    private string siteprefixField = (string) null;
    private string customheadersField = (string) null;
    private string persistmaskField = (string) null;
    private uint? v6persistmasklenField = new uint?();
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

    public string vservername
    {
      get => this.vservernameField;
      set => this.vservernameField = value;
    }

    public string sitename
    {
      get => this.sitenameField;
      private set => this.sitenameField = value;
    }

    public string backuplbmethod
    {
      get => this.backuplbmethodField;
      private set => this.backuplbmethodField = value;
    }

    public string customheaders
    {
      get => this.customheadersField;
      private set => this.customheadersField = value;
    }

    public uint? persistenceid
    {
      get => this.persistenceidField;
      private set => this.persistenceidField = value;
    }

    public string state
    {
      get => this.stateField;
      private set => this.stateField = value;
    }

    public string lbmethod
    {
      get => this.lbmethodField;
      private set => this.lbmethodField = value;
    }

    public string edr
    {
      get => this.edrField;
      private set => this.edrField = value;
    }

    public string cip
    {
      get => this.cipField;
      private set => this.cipField = value;
    }

    public string statechangetimesec
    {
      get => this.statechangetimesecField;
      private set => this.statechangetimesecField = value;
    }

    public string netmask
    {
      get => this.netmaskField;
      private set => this.netmaskField = value;
    }

    public string dnsrecordtype
    {
      get => this.dnsrecordtypeField;
      private set => this.dnsrecordtypeField = value;
    }

    public string persistmask
    {
      get => this.persistmaskField;
      private set => this.persistmaskField = value;
    }

    public string sitepersistence
    {
      get => this.sitepersistenceField;
      private set => this.sitepersistenceField = value;
    }

    public string servicetype
    {
      get => this.servicetypeField;
      private set => this.servicetypeField = value;
    }

    public uint? v6persistmasklen
    {
      get => this.v6persistmasklenField;
      private set => this.v6persistmasklenField = value;
    }

    public uint? v6netmasklen
    {
      get => this.v6netmasklenField;
      private set => this.v6netmasklenField = value;
    }

    public string persistencetype
    {
      get => this.persistencetypeField;
      private set => this.persistencetypeField = value;
    }

    public string siteprefix
    {
      get => this.siteprefixField;
      private set => this.siteprefixField = value;
    }

    public string dynamicweight
    {
      get => this.dynamicweightField;
      private set => this.dynamicweightField = value;
    }

    public string mir
    {
      get => this.mirField;
      private set => this.mirField = value;
    }

    internal override base_resource[] get_nitro_response(
      nitro_service service,
      string response)
    {
      gslbdomain_gslbvserver_binding.gslbdomain_gslbvserver_binding_response gslbvserverBindingResponse = new gslbdomain_gslbvserver_binding.gslbdomain_gslbvserver_binding_response();
      gslbdomain_gslbvserver_binding.gslbdomain_gslbvserver_binding_response resource = (gslbdomain_gslbvserver_binding.gslbdomain_gslbvserver_binding_response) service.get_payload_formatter().string_to_resource(gslbvserverBindingResponse.GetType(), response);
      if (resource.errorcode != 0)
      {
        if (resource.errorcode == 444)
          service.clear_session();
        if (resource.severity == null)
          throw new nitro_exception(resource.message, resource.errorcode);
        if (resource.severity.Equals("ERROR"))
          throw new nitro_exception(resource.message, resource.errorcode);
      }
      return (base_resource[]) resource.gslbdomain_gslbvserver_binding;
    }

    internal override string get_object_name() => this.name;

    public static gslbdomain_gslbvserver_binding[] get(
      nitro_service service,
      string name)
    {
      return (gslbdomain_gslbvserver_binding[]) new gslbdomain_gslbvserver_binding()
      {
        name = name
      }.get_resources(service, (options) null);
    }

    public static gslbdomain_gslbvserver_binding[] get_filtered(
      nitro_service service,
      string name,
      string filter)
    {
      gslbdomain_gslbvserver_binding gslbvserverBinding = new gslbdomain_gslbvserver_binding();
      gslbvserverBinding.name = name;
      options option = new options();
      option.set_filter(filter);
      return (gslbdomain_gslbvserver_binding[]) gslbvserverBinding.getfiltered(service, option);
    }

    public static gslbdomain_gslbvserver_binding[] get_filtered(
      nitro_service service,
      string name,
      filtervalue[] filter)
    {
      gslbdomain_gslbvserver_binding gslbvserverBinding = new gslbdomain_gslbvserver_binding();
      gslbvserverBinding.name = name;
      options option = new options();
      option.set_filter(filter);
      return (gslbdomain_gslbvserver_binding[]) gslbvserverBinding.getfiltered(service, option);
    }

    public static uint count(nitro_service service, string name)
    {
      gslbdomain_gslbvserver_binding gslbvserverBinding = new gslbdomain_gslbvserver_binding();
      gslbvserverBinding.name = name;
      options option = new options();
      option.set_count(true);
      gslbdomain_gslbvserver_binding[] resources = (gslbdomain_gslbvserver_binding[]) gslbvserverBinding.get_resources(service, option);
      return resources != null && resources.Length > 0 ? resources[0].__count.Value : 0U;
    }

    public static uint count_filtered(nitro_service service, string name, string filter)
    {
      gslbdomain_gslbvserver_binding gslbvserverBinding = new gslbdomain_gslbvserver_binding();
      gslbvserverBinding.name = name;
      options option = new options();
      option.set_count(true);
      option.set_filter(filter);
      gslbdomain_gslbvserver_binding[] gslbvserverBindingArray = (gslbdomain_gslbvserver_binding[]) gslbvserverBinding.getfiltered(service, option);
      return gslbvserverBindingArray != null && gslbvserverBindingArray.Length > 0 ? gslbvserverBindingArray[0].__count.Value : 0U;
    }

    public static uint count_filtered(nitro_service service, string name, filtervalue[] filter)
    {
      gslbdomain_gslbvserver_binding gslbvserverBinding = new gslbdomain_gslbvserver_binding();
      gslbvserverBinding.name = name;
      options option = new options();
      option.set_count(true);
      option.set_filter(filter);
      gslbdomain_gslbvserver_binding[] gslbvserverBindingArray = (gslbdomain_gslbvserver_binding[]) gslbvserverBinding.getfiltered(service, option);
      return gslbvserverBindingArray != null && gslbvserverBindingArray.Length > 0 ? gslbvserverBindingArray[0].__count.Value : 0U;
    }

    private class gslbdomain_gslbvserver_binding_response : base_response
    {
      public gslbdomain_gslbvserver_binding[] gslbdomain_gslbvserver_binding = (gslbdomain_gslbvserver_binding[]) null;
    }

    public static class backuplbmethodEnum
    {
      public const string ROUNDROBIN = "ROUNDROBIN";
      public const string LEASTCONNECTION = "LEASTCONNECTION";
      public const string LEASTRESPONSETIME = "LEASTRESPONSETIME";
      public const string SOURCEIPHASH = "SOURCEIPHASH";
      public const string LEASTBANDWIDTH = "LEASTBANDWIDTH";
      public const string LEASTPACKETS = "LEASTPACKETS";
      public const string STATICPROXIMITY = "STATICPROXIMITY";
      public const string RTT = "RTT";
      public const string CUSTOMLOAD = "CUSTOMLOAD";
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

    public static class lbmethodEnum
    {
      public const string ROUNDROBIN = "ROUNDROBIN";
      public const string LEASTCONNECTION = "LEASTCONNECTION";
      public const string LEASTRESPONSETIME = "LEASTRESPONSETIME";
      public const string SOURCEIPHASH = "SOURCEIPHASH";
      public const string LEASTBANDWIDTH = "LEASTBANDWIDTH";
      public const string LEASTPACKETS = "LEASTPACKETS";
      public const string STATICPROXIMITY = "STATICPROXIMITY";
      public const string RTT = "RTT";
      public const string CUSTOMLOAD = "CUSTOMLOAD";
    }

    public static class edrEnum
    {
      public const string ENABLED = "ENABLED";
      public const string DISABLED = "DISABLED";
    }

    public static class cipEnum
    {
      public const string ENABLED = "ENABLED";
      public const string DISABLED = "DISABLED";
    }

    public static class persistencetypeEnum
    {
      public const string SOURCEIP = "SOURCEIP";
      public const string NONE = "NONE";
    }

    public static class dynamicweightEnum
    {
      public const string SERVICECOUNT = "SERVICECOUNT";
      public const string SERVICEWEIGHT = "SERVICEWEIGHT";
      public const string DISABLED = "DISABLED";
    }

    public static class dnsrecordtypeEnum
    {
      public const string A = "A";
      public const string AAAA = "AAAA";
      public const string CNAME = "CNAME";
      public const string NAPTR = "NAPTR";
    }

    public static class sitepersistenceEnum
    {
      public const string ConnectionProxy = "ConnectionProxy";
      public const string HTTPRedirect = "HTTPRedirect";
      public const string NONE = "NONE";
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
      public const string NNTP = "NNTP";
      public const string ANY = "ANY";
      public const string SIP_UDP = "SIP_UDP";
      public const string SIP_TCP = "SIP_TCP";
      public const string SIP_SSL = "SIP_SSL";
      public const string RADIUS = "RADIUS";
      public const string RDP = "RDP";
      public const string RTSP = "RTSP";
      public const string MYSQL = "MYSQL";
      public const string MSSQL = "MSSQL";
      public const string ORACLE = "ORACLE";
    }

    public static class mirEnum
    {
      public const string ENABLED = "ENABLED";
      public const string DISABLED = "DISABLED";
    }
  }
}
