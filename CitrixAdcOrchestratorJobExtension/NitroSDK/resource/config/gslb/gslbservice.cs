// Decompiled with JetBrains decompiler
// Type: com.citrix.netscaler.nitro.resource.config.gslb.gslbservice
// Assembly: nitro, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 6CF5DDEF-E052-4F9D-953F-6644F8378A66


using com.citrix.netscaler.nitro.exception;
using com.citrix.netscaler.nitro.resource.Base;
using com.citrix.netscaler.nitro.service;
using com.citrix.netscaler.nitro.util;

namespace com.citrix.netscaler.nitro.resource.config.gslb
{
  public class gslbservice : base_resource
  {
    private string servicenameField = (string) null;
    private string cnameentryField = (string) null;
    private string ipField = (string) null;
    private string servernameField = (string) null;
    private string servicetypeField = (string) null;
    private ushort? portField = new ushort?();
    private string publicipField = (string) null;
    private ushort? publicportField = new ushort?();
    private uint? maxclientField = new uint?();
    private string healthmonitorField = (string) null;
    private string sitenameField = (string) null;
    private string stateField = (string) null;
    private string cipField = (string) null;
    private string cipheaderField = (string) null;
    private string sitepersistenceField = (string) null;
    private uint? cookietimeoutField = new uint?();
    private string siteprefixField = (string) null;
    private long? clttimeoutField = new long?();
    private long? svrtimeoutField = new long?();
    private uint? maxbandwidthField = new uint?();
    private string downstateflushField = (string) null;
    private uint? maxaaausersField = new uint?();
    private uint? monthresholdField = new uint?();
    private uint? hashidField = new uint?();
    private string commentField = (string) null;
    private string appflowlogField = (string) null;
    private string naptrreplacementField = (string) null;
    private uint? naptrorderField = new uint?();
    private string naptrservicesField = (string) null;
    private long? naptrdomainttlField = new long?();
    private uint? naptrpreferenceField = new uint?();
    private string ipaddressField = (string) null;
    private string viewnameField = (string) null;
    private string viewipField = (string) null;
    private uint? weightField = new uint?();
    private string monitor_name_svcField = (string) null;
    private string newnameField = (string) null;
    private string gslbField = (string) null;
    private string svrstateField = (string) null;
    private string svreffgslbstateField = (string) null;
    private int? gslbthresholdField = new int?();
    private int? gslbsvcstatsField = new int?();
    private string monstateField = (string) null;
    private string preferredlocationField = (string) null;
    private string monitor_stateField = (string) null;
    private string statechangetimesecField = (string) null;
    private uint? tickssincelaststatechangeField = new uint?();
    private string thresholdField = (string) null;
    private uint? clmonownerField = new uint?();
    private uint? clmonviewField = new uint?();
    private uint? __countField = new uint?();

    public uint? __count
    {
      get => this.__countField;
      private set => this.__countField = value;
    }

    public string servicename
    {
      get => this.servicenameField;
      set => this.servicenameField = value;
    }

    public string cnameentry
    {
      get => this.cnameentryField;
      set => this.cnameentryField = value;
    }

    public string ip
    {
      get => this.ipField;
      set => this.ipField = value;
    }

    public string servername
    {
      get => this.servernameField;
      set => this.servernameField = value;
    }

    public string servicetype
    {
      get => this.servicetypeField;
      set => this.servicetypeField = value;
    }

    public ushort? port
    {
      get => this.portField;
      set => this.portField = value;
    }

    public string publicip
    {
      get => this.publicipField;
      set => this.publicipField = value;
    }

    public ushort? publicport
    {
      get => this.publicportField;
      set => this.publicportField = value;
    }

    public uint? maxclient
    {
      get => this.maxclientField;
      set => this.maxclientField = value;
    }

    public string healthmonitor
    {
      get => this.healthmonitorField;
      set => this.healthmonitorField = value;
    }

    public string sitename
    {
      get => this.sitenameField;
      set => this.sitenameField = value;
    }

    public string state
    {
      get => this.stateField;
      set => this.stateField = value;
    }

    public string cip
    {
      get => this.cipField;
      set => this.cipField = value;
    }

    public string cipheader
    {
      get => this.cipheaderField;
      set => this.cipheaderField = value;
    }

    public string sitepersistence
    {
      get => this.sitepersistenceField;
      set => this.sitepersistenceField = value;
    }

    public uint? cookietimeout
    {
      get => this.cookietimeoutField;
      set => this.cookietimeoutField = value;
    }

    public string siteprefix
    {
      get => this.siteprefixField;
      set => this.siteprefixField = value;
    }

    public long? clttimeout
    {
      get => this.clttimeoutField;
      set => this.clttimeoutField = value;
    }

    public long? svrtimeout
    {
      get => this.svrtimeoutField;
      set => this.svrtimeoutField = value;
    }

    public uint? maxbandwidth
    {
      get => this.maxbandwidthField;
      set => this.maxbandwidthField = value;
    }

    public string downstateflush
    {
      get => this.downstateflushField;
      set => this.downstateflushField = value;
    }

    public uint? maxaaausers
    {
      get => this.maxaaausersField;
      set => this.maxaaausersField = value;
    }

    public uint? monthreshold
    {
      get => this.monthresholdField;
      set => this.monthresholdField = value;
    }

    public uint? hashid
    {
      get => this.hashidField;
      set => this.hashidField = value;
    }

    public string comment
    {
      get => this.commentField;
      set => this.commentField = value;
    }

    public string appflowlog
    {
      get => this.appflowlogField;
      set => this.appflowlogField = value;
    }

    public string naptrreplacement
    {
      get => this.naptrreplacementField;
      set => this.naptrreplacementField = value;
    }

    public uint? naptrorder
    {
      get => this.naptrorderField;
      set => this.naptrorderField = value;
    }

    public string naptrservices
    {
      get => this.naptrservicesField;
      set => this.naptrservicesField = value;
    }

    public long? naptrdomainttl
    {
      get => this.naptrdomainttlField;
      set => this.naptrdomainttlField = value;
    }

    public uint? naptrpreference
    {
      get => this.naptrpreferenceField;
      set => this.naptrpreferenceField = value;
    }

    public string ipaddress
    {
      get => this.ipaddressField;
      set => this.ipaddressField = value;
    }

    public string viewname
    {
      get => this.viewnameField;
      set => this.viewnameField = value;
    }

    public string viewip
    {
      get => this.viewipField;
      set => this.viewipField = value;
    }

    public uint? weight
    {
      get => this.weightField;
      set => this.weightField = value;
    }

    public string monitor_name_svc
    {
      get => this.monitor_name_svcField;
      set => this.monitor_name_svcField = value;
    }

    public string newname
    {
      get => this.newnameField;
      set => this.newnameField = value;
    }

    public string gslb
    {
      get => this.gslbField;
      private set => this.gslbField = value;
    }

    public string svrstate
    {
      get => this.svrstateField;
      private set => this.svrstateField = value;
    }

    public string svreffgslbstate
    {
      get => this.svreffgslbstateField;
      private set => this.svreffgslbstateField = value;
    }

    public int? gslbthreshold
    {
      get => this.gslbthresholdField;
      private set => this.gslbthresholdField = value;
    }

    public int? gslbsvcstats
    {
      get => this.gslbsvcstatsField;
      private set => this.gslbsvcstatsField = value;
    }

    public string monstate
    {
      get => this.monstateField;
      private set => this.monstateField = value;
    }

    public string preferredlocation
    {
      get => this.preferredlocationField;
      private set => this.preferredlocationField = value;
    }

    public string monitor_state
    {
      get => this.monitor_stateField;
      private set => this.monitor_stateField = value;
    }

    public string statechangetimesec
    {
      get => this.statechangetimesecField;
      private set => this.statechangetimesecField = value;
    }

    public uint? tickssincelaststatechange
    {
      get => this.tickssincelaststatechangeField;
      private set => this.tickssincelaststatechangeField = value;
    }

    public string threshold
    {
      get => this.thresholdField;
      private set => this.thresholdField = value;
    }

    public uint? clmonowner
    {
      get => this.clmonownerField;
      private set => this.clmonownerField = value;
    }

    public uint? clmonview
    {
      get => this.clmonviewField;
      private set => this.clmonviewField = value;
    }

    internal override base_resource[] get_nitro_response(
      nitro_service service,
      string response)
    {
      gslbservice.gslbservice_response gslbserviceResponse = new gslbservice.gslbservice_response();
      gslbservice.gslbservice_response resource = (gslbservice.gslbservice_response) service.get_payload_formatter().string_to_resource(gslbserviceResponse.GetType(), response);
      if (resource.errorcode != 0)
      {
        if (resource.errorcode == 444)
          service.clear_session();
        if (resource.severity == null)
          throw new nitro_exception(resource.message, resource.errorcode);
        if (resource.severity.Equals("ERROR"))
          throw new nitro_exception(resource.message, resource.errorcode);
      }
      return (base_resource[]) resource.gslbservice;
    }

    internal override string get_object_name() => this.servicename;

    public static base_response add(nitro_service client, gslbservice resource) => new gslbservice()
    {
      servicename = resource.servicename,
      cnameentry = resource.cnameentry,
      ip = resource.ip,
      servername = resource.servername,
      servicetype = resource.servicetype,
      port = resource.port,
      publicip = resource.publicip,
      publicport = resource.publicport,
      maxclient = resource.maxclient,
      healthmonitor = resource.healthmonitor,
      sitename = resource.sitename,
      state = resource.state,
      cip = resource.cip,
      cipheader = resource.cipheader,
      sitepersistence = resource.sitepersistence,
      cookietimeout = resource.cookietimeout,
      siteprefix = resource.siteprefix,
      clttimeout = resource.clttimeout,
      svrtimeout = resource.svrtimeout,
      maxbandwidth = resource.maxbandwidth,
      downstateflush = resource.downstateflush,
      maxaaausers = resource.maxaaausers,
      monthreshold = resource.monthreshold,
      hashid = resource.hashid,
      comment = resource.comment,
      appflowlog = resource.appflowlog,
      naptrreplacement = resource.naptrreplacement,
      naptrorder = resource.naptrorder,
      naptrservices = resource.naptrservices,
      naptrdomainttl = resource.naptrdomainttl,
      naptrpreference = resource.naptrpreference
    }.add_resource(client);

    public static base_responses add(nitro_service client, gslbservice[] resources)
    {
      base_responses baseResponses = (base_responses) null;
      if (resources != null && resources.Length > 0)
      {
        gslbservice[] gslbserviceArray = new gslbservice[resources.Length];
        for (int index = 0; index < resources.Length; ++index)
        {
          gslbserviceArray[index] = new gslbservice();
          gslbserviceArray[index].servicename = resources[index].servicename;
          gslbserviceArray[index].cnameentry = resources[index].cnameentry;
          gslbserviceArray[index].ip = resources[index].ip;
          gslbserviceArray[index].servername = resources[index].servername;
          gslbserviceArray[index].servicetype = resources[index].servicetype;
          gslbserviceArray[index].port = resources[index].port;
          gslbserviceArray[index].publicip = resources[index].publicip;
          gslbserviceArray[index].publicport = resources[index].publicport;
          gslbserviceArray[index].maxclient = resources[index].maxclient;
          gslbserviceArray[index].healthmonitor = resources[index].healthmonitor;
          gslbserviceArray[index].sitename = resources[index].sitename;
          gslbserviceArray[index].state = resources[index].state;
          gslbserviceArray[index].cip = resources[index].cip;
          gslbserviceArray[index].cipheader = resources[index].cipheader;
          gslbserviceArray[index].sitepersistence = resources[index].sitepersistence;
          gslbserviceArray[index].cookietimeout = resources[index].cookietimeout;
          gslbserviceArray[index].siteprefix = resources[index].siteprefix;
          gslbserviceArray[index].clttimeout = resources[index].clttimeout;
          gslbserviceArray[index].svrtimeout = resources[index].svrtimeout;
          gslbserviceArray[index].maxbandwidth = resources[index].maxbandwidth;
          gslbserviceArray[index].downstateflush = resources[index].downstateflush;
          gslbserviceArray[index].maxaaausers = resources[index].maxaaausers;
          gslbserviceArray[index].monthreshold = resources[index].monthreshold;
          gslbserviceArray[index].hashid = resources[index].hashid;
          gslbserviceArray[index].comment = resources[index].comment;
          gslbserviceArray[index].appflowlog = resources[index].appflowlog;
          gslbserviceArray[index].naptrreplacement = resources[index].naptrreplacement;
          gslbserviceArray[index].naptrorder = resources[index].naptrorder;
          gslbserviceArray[index].naptrservices = resources[index].naptrservices;
          gslbserviceArray[index].naptrdomainttl = resources[index].naptrdomainttl;
          gslbserviceArray[index].naptrpreference = resources[index].naptrpreference;
        }
        baseResponses = base_resource.add_bulk_request(client, (base_resource[]) gslbserviceArray);
      }
      return baseResponses;
    }

    public static base_response delete(nitro_service client, string servicename) => new gslbservice()
    {
      servicename = servicename
    }.delete_resource(client);

    public static base_response delete(nitro_service client, gslbservice resource) => new gslbservice()
    {
      servicename = resource.servicename
    }.delete_resource(client);

    public static base_responses delete(nitro_service client, string[] servicename)
    {
      base_responses baseResponses = (base_responses) null;
      if (servicename != null && servicename.Length > 0)
      {
        gslbservice[] gslbserviceArray = new gslbservice[servicename.Length];
        for (int index = 0; index < servicename.Length; ++index)
        {
          gslbserviceArray[index] = new gslbservice();
          gslbserviceArray[index].servicename = servicename[index];
        }
        baseResponses = base_resource.delete_bulk_request(client, (base_resource[]) gslbserviceArray);
      }
      return baseResponses;
    }

    public static base_responses delete(nitro_service client, gslbservice[] resources)
    {
      base_responses baseResponses = (base_responses) null;
      if (resources != null && resources.Length > 0)
      {
        gslbservice[] gslbserviceArray = new gslbservice[resources.Length];
        for (int index = 0; index < resources.Length; ++index)
        {
          gslbserviceArray[index] = new gslbservice();
          gslbserviceArray[index].servicename = resources[index].servicename;
        }
        baseResponses = base_resource.delete_bulk_request(client, (base_resource[]) gslbserviceArray);
      }
      return baseResponses;
    }

    public static base_response update(nitro_service client, gslbservice resource) => new gslbservice()
    {
      servicename = resource.servicename,
      ipaddress = resource.ipaddress,
      publicip = resource.publicip,
      publicport = resource.publicport,
      cip = resource.cip,
      cipheader = resource.cipheader,
      sitepersistence = resource.sitepersistence,
      siteprefix = resource.siteprefix,
      maxclient = resource.maxclient,
      healthmonitor = resource.healthmonitor,
      maxbandwidth = resource.maxbandwidth,
      downstateflush = resource.downstateflush,
      maxaaausers = resource.maxaaausers,
      viewname = resource.viewname,
      viewip = resource.viewip,
      monthreshold = resource.monthreshold,
      weight = resource.weight,
      monitor_name_svc = resource.monitor_name_svc,
      hashid = resource.hashid,
      comment = resource.comment,
      appflowlog = resource.appflowlog,
      naptrorder = resource.naptrorder,
      naptrpreference = resource.naptrpreference,
      naptrservices = resource.naptrservices,
      naptrreplacement = resource.naptrreplacement,
      naptrdomainttl = resource.naptrdomainttl
    }.update_resource(client);

    public static base_responses update(nitro_service client, gslbservice[] resources)
    {
      base_responses baseResponses = (base_responses) null;
      if (resources != null && resources.Length > 0)
      {
        gslbservice[] gslbserviceArray = new gslbservice[resources.Length];
        for (int index = 0; index < resources.Length; ++index)
        {
          gslbserviceArray[index] = new gslbservice();
          gslbserviceArray[index].servicename = resources[index].servicename;
          gslbserviceArray[index].ipaddress = resources[index].ipaddress;
          gslbserviceArray[index].publicip = resources[index].publicip;
          gslbserviceArray[index].publicport = resources[index].publicport;
          gslbserviceArray[index].cip = resources[index].cip;
          gslbserviceArray[index].cipheader = resources[index].cipheader;
          gslbserviceArray[index].sitepersistence = resources[index].sitepersistence;
          gslbserviceArray[index].siteprefix = resources[index].siteprefix;
          gslbserviceArray[index].maxclient = resources[index].maxclient;
          gslbserviceArray[index].healthmonitor = resources[index].healthmonitor;
          gslbserviceArray[index].maxbandwidth = resources[index].maxbandwidth;
          gslbserviceArray[index].downstateflush = resources[index].downstateflush;
          gslbserviceArray[index].maxaaausers = resources[index].maxaaausers;
          gslbserviceArray[index].viewname = resources[index].viewname;
          gslbserviceArray[index].viewip = resources[index].viewip;
          gslbserviceArray[index].monthreshold = resources[index].monthreshold;
          gslbserviceArray[index].weight = resources[index].weight;
          gslbserviceArray[index].monitor_name_svc = resources[index].monitor_name_svc;
          gslbserviceArray[index].hashid = resources[index].hashid;
          gslbserviceArray[index].comment = resources[index].comment;
          gslbserviceArray[index].appflowlog = resources[index].appflowlog;
          gslbserviceArray[index].naptrorder = resources[index].naptrorder;
          gslbserviceArray[index].naptrpreference = resources[index].naptrpreference;
          gslbserviceArray[index].naptrservices = resources[index].naptrservices;
          gslbserviceArray[index].naptrreplacement = resources[index].naptrreplacement;
          gslbserviceArray[index].naptrdomainttl = resources[index].naptrdomainttl;
        }
        baseResponses = base_resource.update_bulk_request(client, (base_resource[]) gslbserviceArray);
      }
      return baseResponses;
    }

    public static base_response unset(
      nitro_service client,
      string servicename,
      string[] args)
    {
      return new gslbservice() { servicename = servicename }.unset_resource(client, args);
    }

    public static base_response unset(
      nitro_service client,
      gslbservice resource,
      string[] args)
    {
      return new gslbservice()
      {
        servicename = resource.servicename
      }.unset_resource(client, args);
    }

    public static base_responses unset(
      nitro_service client,
      string[] servicename,
      string[] args)
    {
      base_responses baseResponses = (base_responses) null;
      if (servicename != null && servicename.Length > 0)
      {
        gslbservice[] gslbserviceArray = new gslbservice[servicename.Length];
        for (int index = 0; index < servicename.Length; ++index)
        {
          gslbserviceArray[index] = new gslbservice();
          gslbserviceArray[index].servicename = servicename[index];
        }
        baseResponses = base_resource.unset_bulk_request(client, (base_resource[]) gslbserviceArray, args);
      }
      return baseResponses;
    }

    public static base_responses unset(
      nitro_service client,
      gslbservice[] resources,
      string[] args)
    {
      base_responses baseResponses = (base_responses) null;
      if (resources != null && resources.Length > 0)
      {
        gslbservice[] gslbserviceArray = new gslbservice[resources.Length];
        for (int index = 0; index < resources.Length; ++index)
        {
          gslbserviceArray[index] = new gslbservice();
          gslbserviceArray[index].servicename = resources[index].servicename;
        }
        baseResponses = base_resource.unset_bulk_request(client, (base_resource[]) gslbserviceArray, args);
      }
      return baseResponses;
    }

    public static base_response rename(
      nitro_service client,
      gslbservice resource,
      string new_servicename)
    {
      return new gslbservice()
      {
        servicename = resource.servicename,
        newname = new_servicename
      }.rename_resource(client);
    }

    public static base_response rename(
      nitro_service client,
      string servicename,
      string new_servicename)
    {
      return new gslbservice()
      {
        servicename = servicename,
        newname = new_servicename
      }.rename_resource(client);
    }

    public static gslbservice[] get(nitro_service service) => (gslbservice[]) new gslbservice().get_resources(service, (options) null);

    public static gslbservice[] get(nitro_service service, options option) => (gslbservice[]) new gslbservice().get_resources(service, option);

    public static gslbservice get(nitro_service service, string servicename) => (gslbservice) new gslbservice()
    {
      servicename = servicename
    }.get_resource(service);

    public static gslbservice[] get(nitro_service service, string[] servicename)
    {
      if (servicename == null || servicename.Length <= 0)
        return (gslbservice[]) null;
      gslbservice[] gslbserviceArray1 = new gslbservice[servicename.Length];
      gslbservice[] gslbserviceArray2 = new gslbservice[servicename.Length];
      for (int index = 0; index < servicename.Length; ++index)
      {
        gslbserviceArray2[index] = new gslbservice();
        gslbserviceArray2[index].servicename = servicename[index];
        gslbserviceArray1[index] = (gslbservice) gslbserviceArray2[index].get_resource(service);
      }
      return gslbserviceArray1;
    }

    public static gslbservice[] get_filtered(nitro_service service, string filter)
    {
      gslbservice gslbservice = new gslbservice();
      options option = new options();
      option.set_filter(filter);
      return (gslbservice[]) gslbservice.getfiltered(service, option);
    }

    public static gslbservice[] get_filtered(nitro_service service, filtervalue[] filter)
    {
      gslbservice gslbservice = new gslbservice();
      options option = new options();
      option.set_filter(filter);
      return (gslbservice[]) gslbservice.getfiltered(service, option);
    }

    public static uint count(nitro_service service)
    {
      gslbservice gslbservice = new gslbservice();
      options option = new options();
      option.set_count(true);
      gslbservice[] resources = (gslbservice[]) gslbservice.get_resources(service, option);
      return resources != null && resources.Length > 0 ? resources[0].__count.Value : 0U;
    }

    public static uint count_filtered(nitro_service service, string filter)
    {
      gslbservice gslbservice = new gslbservice();
      options option = new options();
      option.set_count(true);
      option.set_filter(filter);
      gslbservice[] gslbserviceArray = (gslbservice[]) gslbservice.getfiltered(service, option);
      return gslbserviceArray != null && gslbserviceArray.Length > 0 ? gslbserviceArray[0].__count.Value : 0U;
    }

    public static uint count_filtered(nitro_service service, filtervalue[] filter)
    {
      gslbservice gslbservice = new gslbservice();
      options option = new options();
      option.set_count(true);
      option.set_filter(filter);
      gslbservice[] gslbserviceArray = (gslbservice[]) gslbservice.getfiltered(service, option);
      return gslbserviceArray != null && gslbserviceArray.Length > 0 ? gslbserviceArray[0].__count.Value : 0U;
    }

    private class gslbservice_response : base_response
    {
      public gslbservice[] gslbservice = (gslbservice[]) null;
    }

    public static class stateEnum
    {
      public const string ENABLED = "ENABLED";
      public const string DISABLED = "DISABLED";
    }

    public static class downstateflushEnum
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

    public static class monitor_stateEnum
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

    public static class gslbEnum
    {
      public const string REMOTE = "REMOTE";
      public const string LOCAL = "LOCAL";
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

    public static class thresholdEnum
    {
      public const string ABOVE = "ABOVE";
      public const string BELOW = "BELOW";
    }

    public static class cipEnum
    {
      public const string ENABLED = "ENABLED";
      public const string DISABLED = "DISABLED";
    }

    public static class monstateEnum
    {
      public const string ENABLED = "ENABLED";
      public const string DISABLED = "DISABLED";
    }

    public static class sitepersistenceEnum
    {
      public const string ConnectionProxy = "ConnectionProxy";
      public const string HTTPRedirect = "HTTPRedirect";
      public const string NONE = "NONE";
    }

    public static class healthmonitorEnum
    {
      public const string YES = "YES";
      public const string NO = "NO";
    }

    public static class appflowlogEnum
    {
      public const string ENABLED = "ENABLED";
      public const string DISABLED = "DISABLED";
    }
  }
}
