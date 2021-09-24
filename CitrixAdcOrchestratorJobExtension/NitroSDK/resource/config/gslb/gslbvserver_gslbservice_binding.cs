// Decompiled with JetBrains decompiler
// Type: com.citrix.netscaler.nitro.resource.config.gslb.gslbvserver_gslbservice_binding
// Assembly: nitro, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 6CF5DDEF-E052-4F9D-953F-6644F8378A66


using com.citrix.netscaler.nitro.exception;
using com.citrix.netscaler.nitro.resource.Base;
using com.citrix.netscaler.nitro.service;
using com.citrix.netscaler.nitro.util;

namespace com.citrix.netscaler.nitro.resource.config.gslb
{
  public class gslbvserver_gslbservice_binding : base_resource
  {
    private string servicenameField = (string) null;
    private uint? weightField = new uint?();
    private string cnameentryField = (string) null;
    private string ipaddressField = (string) null;
    private ushort? portField = new ushort?();
    private string gslbboundsvctypeField = (string) null;
    private string curstateField = (string) null;
    private uint? dynamicconfwtField = new uint?();
    private uint? cumulativeweightField = new uint?();
    private string svreffgslbstateField = (string) null;
    private int? gslbthresholdField = new int?();
    private string preferredlocationField = (string) null;
    private int? thresholdvalueField = new int?();
    private string iscnameField = (string) null;
    private string domainnameField = (string) null;
    private string sitepersistcookieField = (string) null;
    private string svcsitepersistenceField = (string) null;
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

    public string servicename
    {
      get => this.servicenameField;
      set => this.servicenameField = value;
    }

    public string domainname
    {
      get => this.domainnameField;
      set => this.domainnameField = value;
    }

    public string cnameentry
    {
      get => this.cnameentryField;
      private set => this.cnameentryField = value;
    }

    public string svcsitepersistence
    {
      get => this.svcsitepersistenceField;
      private set => this.svcsitepersistenceField = value;
    }

    public string gslbboundsvctype
    {
      get => this.gslbboundsvctypeField;
      private set => this.gslbboundsvctypeField = value;
    }

    public string preferredlocation
    {
      get => this.preferredlocationField;
      private set => this.preferredlocationField = value;
    }

    public uint? dynamicconfwt
    {
      get => this.dynamicconfwtField;
      private set => this.dynamicconfwtField = value;
    }

    public uint? cumulativeweight
    {
      get => this.cumulativeweightField;
      private set => this.cumulativeweightField = value;
    }

    public int? gslbthreshold
    {
      get => this.gslbthresholdField;
      private set => this.gslbthresholdField = value;
    }

    public string sitepersistcookie
    {
      get => this.sitepersistcookieField;
      private set => this.sitepersistcookieField = value;
    }

    public ushort? port
    {
      get => this.portField;
      private set => this.portField = value;
    }

    public string iscname
    {
      get => this.iscnameField;
      private set => this.iscnameField = value;
    }

    public string curstate
    {
      get => this.curstateField;
      private set => this.curstateField = value;
    }

    public string svreffgslbstate
    {
      get => this.svreffgslbstateField;
      private set => this.svreffgslbstateField = value;
    }

    public int? thresholdvalue
    {
      get => this.thresholdvalueField;
      private set => this.thresholdvalueField = value;
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
      gslbvserver_gslbservice_binding.gslbvserver_gslbservice_binding_response gslbserviceBindingResponse = new gslbvserver_gslbservice_binding.gslbvserver_gslbservice_binding_response();
      gslbvserver_gslbservice_binding.gslbvserver_gslbservice_binding_response resource = (gslbvserver_gslbservice_binding.gslbvserver_gslbservice_binding_response) service.get_payload_formatter().string_to_resource(gslbserviceBindingResponse.GetType(), response);
      if (resource.errorcode != 0)
      {
        if (resource.errorcode == 444)
          service.clear_session();
        if (resource.severity == null)
          throw new nitro_exception(resource.message, resource.errorcode);
        if (resource.severity.Equals("ERROR"))
          throw new nitro_exception(resource.message, resource.errorcode);
      }
      return (base_resource[]) resource.gslbvserver_gslbservice_binding;
    }

    internal override string get_object_name() => this.name;

    public static base_response add(
      nitro_service client,
      gslbvserver_gslbservice_binding resource)
    {
      return new gslbvserver_gslbservice_binding()
      {
        name = resource.name,
        servicename = resource.servicename,
        weight = resource.weight,
        domainname = resource.domainname
      }.update_resource(client);
    }

    public static base_responses add(
      nitro_service client,
      gslbvserver_gslbservice_binding[] resources)
    {
      base_responses baseResponses = (base_responses) null;
      if (resources != null && resources.Length > 0)
      {
        gslbvserver_gslbservice_binding[] gslbserviceBindingArray = new gslbvserver_gslbservice_binding[resources.Length];
        for (int index = 0; index < resources.Length; ++index)
        {
          gslbserviceBindingArray[index] = new gslbvserver_gslbservice_binding();
          gslbserviceBindingArray[index].name = resources[index].name;
          gslbserviceBindingArray[index].servicename = resources[index].servicename;
          gslbserviceBindingArray[index].weight = resources[index].weight;
          gslbserviceBindingArray[index].domainname = resources[index].domainname;
        }
        baseResponses = base_resource.update_bulk_request(client, (base_resource[]) gslbserviceBindingArray);
      }
      return baseResponses;
    }

    public static base_response delete(
      nitro_service client,
      gslbvserver_gslbservice_binding resource)
    {
      return new gslbvserver_gslbservice_binding()
      {
        name = resource.name,
        servicename = resource.servicename,
        domainname = resource.domainname
      }.delete_resource(client);
    }

    public static base_responses delete(
      nitro_service client,
      gslbvserver_gslbservice_binding[] resources)
    {
      base_responses baseResponses = (base_responses) null;
      if (resources != null && resources.Length > 0)
      {
        gslbvserver_gslbservice_binding[] gslbserviceBindingArray = new gslbvserver_gslbservice_binding[resources.Length];
        for (int index = 0; index < resources.Length; ++index)
        {
          gslbserviceBindingArray[index] = new gslbvserver_gslbservice_binding();
          gslbserviceBindingArray[index].name = resources[index].name;
          gslbserviceBindingArray[index].servicename = resources[index].servicename;
          gslbserviceBindingArray[index].domainname = resources[index].domainname;
        }
        baseResponses = base_resource.delete_bulk_request(client, (base_resource[]) gslbserviceBindingArray);
      }
      return baseResponses;
    }

    public static gslbvserver_gslbservice_binding[] get(
      nitro_service service,
      string name)
    {
      return (gslbvserver_gslbservice_binding[]) new gslbvserver_gslbservice_binding()
      {
        name = name
      }.get_resources(service, (options) null);
    }

    public static gslbvserver_gslbservice_binding[] get_filtered(
      nitro_service service,
      string name,
      string filter)
    {
      gslbvserver_gslbservice_binding gslbserviceBinding = new gslbvserver_gslbservice_binding();
      gslbserviceBinding.name = name;
      options option = new options();
      option.set_filter(filter);
      return (gslbvserver_gslbservice_binding[]) gslbserviceBinding.getfiltered(service, option);
    }

    public static gslbvserver_gslbservice_binding[] get_filtered(
      nitro_service service,
      string name,
      filtervalue[] filter)
    {
      gslbvserver_gslbservice_binding gslbserviceBinding = new gslbvserver_gslbservice_binding();
      gslbserviceBinding.name = name;
      options option = new options();
      option.set_filter(filter);
      return (gslbvserver_gslbservice_binding[]) gslbserviceBinding.getfiltered(service, option);
    }

    public static uint count(nitro_service service, string name)
    {
      gslbvserver_gslbservice_binding gslbserviceBinding = new gslbvserver_gslbservice_binding();
      gslbserviceBinding.name = name;
      options option = new options();
      option.set_count(true);
      gslbvserver_gslbservice_binding[] resources = (gslbvserver_gslbservice_binding[]) gslbserviceBinding.get_resources(service, option);
      return resources != null && resources.Length > 0 ? resources[0].__count.Value : 0U;
    }

    public static uint count_filtered(nitro_service service, string name, string filter)
    {
      gslbvserver_gslbservice_binding gslbserviceBinding = new gslbvserver_gslbservice_binding();
      gslbserviceBinding.name = name;
      options option = new options();
      option.set_count(true);
      option.set_filter(filter);
      gslbvserver_gslbservice_binding[] gslbserviceBindingArray = (gslbvserver_gslbservice_binding[]) gslbserviceBinding.getfiltered(service, option);
      return gslbserviceBindingArray != null && gslbserviceBindingArray.Length > 0 ? gslbserviceBindingArray[0].__count.Value : 0U;
    }

    public static uint count_filtered(nitro_service service, string name, filtervalue[] filter)
    {
      gslbvserver_gslbservice_binding gslbserviceBinding = new gslbvserver_gslbservice_binding();
      gslbserviceBinding.name = name;
      options option = new options();
      option.set_count(true);
      option.set_filter(filter);
      gslbvserver_gslbservice_binding[] gslbserviceBindingArray = (gslbvserver_gslbservice_binding[]) gslbserviceBinding.getfiltered(service, option);
      return gslbserviceBindingArray != null && gslbserviceBindingArray.Length > 0 ? gslbserviceBindingArray[0].__count.Value : 0U;
    }

    private class gslbvserver_gslbservice_binding_response : base_response
    {
      public gslbvserver_gslbservice_binding[] gslbvserver_gslbservice_binding = (gslbvserver_gslbservice_binding[]) null;
    }

    public static class svcsitepersistenceEnum
    {
      public const string ConnectionProxy = "ConnectionProxy";
      public const string HTTPRedirect = "HTTPRedirect";
      public const string NONE = "NONE";
    }

    public static class svreffgslbstateEnum
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

    public static class typeEnum
    {
      public const string REQUEST = "REQUEST";
      public const string RESPONSE = "RESPONSE";
    }

    public static class gslbboundsvctypeEnum
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

    public static class iscnameEnum
    {
      public const string ENABLED = "ENABLED";
      public const string DISABLED = "DISABLED";
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
