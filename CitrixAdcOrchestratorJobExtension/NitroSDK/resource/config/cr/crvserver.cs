// Decompiled with JetBrains decompiler
// Type: com.citrix.netscaler.nitro.resource.config.cr.crvserver
// Assembly: nitro, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 6CF5DDEF-E052-4F9D-953F-6644F8378A66


using com.citrix.netscaler.nitro.exception;
using com.citrix.netscaler.nitro.resource.Base;
using com.citrix.netscaler.nitro.service;
using com.citrix.netscaler.nitro.util;

namespace com.citrix.netscaler.nitro.resource.config.cr
{
  public class crvserver : base_resource
  {
    private string nameField = (string) null;
    private uint? tdField = new uint?();
    private string servicetypeField = (string) null;
    private string ipv46Field = (string) null;
    private ushort? portField = new ushort?();
    private uint? rangeField = new uint?();
    private string cachetypeField = (string) null;
    private string redirectField = (string) null;
    private string onpolicymatchField = (string) null;
    private string redirecturlField = (string) null;
    private long? clttimeoutField = new long?();
    private string precedenceField = (string) null;
    private string arpField = (string) null;
    private string ghostField = (string) null;
    private string mapField = (string) null;
    private string formatField = (string) null;
    private string viaField = (string) null;
    private string cachevserverField = (string) null;
    private string dnsvservernameField = (string) null;
    private string destinationvserverField = (string) null;
    private string domainField = (string) null;
    private uint? sopersistencetimeoutField = new uint?();
    private uint? sothresholdField = new uint?();
    private string reuseField = (string) null;
    private string stateField = (string) null;
    private string downstateflushField = (string) null;
    private string backupvserverField = (string) null;
    private string disableprimaryondownField = (string) null;
    private string l2connField = (string) null;
    private string backendsslField = (string) null;
    private string listenpolicyField = (string) null;
    private uint? listenpriorityField = new uint?();
    private string tcpprofilenameField = (string) null;
    private string httpprofilenameField = (string) null;
    private string commentField = (string) null;
    private string srcipexprField = (string) null;
    private string originusipField = (string) null;
    private string useportrangeField = (string) null;
    private string appflowlogField = (string) null;
    private string netprofileField = (string) null;
    private string icmpvsrresponseField = (string) null;
    private string rhistateField = (string) null;
    private string newnameField = (string) null;
    private string ipField = (string) null;
    private string valueField = (string) null;
    private string ngnameField = (string) null;
    private string typeField = (string) null;
    private string curstateField = (string) null;
    private int? statusField = new int?();
    private string scField = (string) null;
    private string authenticationField = (string) null;
    private string homepageField = (string) null;
    private string ruleField = (string) null;
    private string policynameField = (string) null;
    private uint? pipolicyhitsField = new uint?();
    private string servicenameField = (string) null;
    private uint? weightField = new uint?();
    private string targetvserverField = (string) null;
    private uint? priorityField = new uint?();
    private string somethodField = (string) null;
    private string sopersistenceField = (string) null;
    private string lbvserverField = (string) null;
    private string bindpointField = (string) null;
    private bool? invokeField = new bool?();
    private string labeltypeField = (string) null;
    private string labelnameField = (string) null;
    private string gotopriorityexpressionField = (string) null;
    private uint? __countField = new uint?();

    public uint? __count
    {
      get => this.__countField;
      private set => this.__countField = value;
    }

    public string name
    {
      get => this.nameField;
      set => this.nameField = value;
    }

    public uint? td
    {
      get => this.tdField;
      set => this.tdField = value;
    }

    public string servicetype
    {
      get => this.servicetypeField;
      set => this.servicetypeField = value;
    }

    public string ipv46
    {
      get => this.ipv46Field;
      set => this.ipv46Field = value;
    }

    public ushort? port
    {
      get => this.portField;
      set => this.portField = value;
    }

    public uint? range
    {
      get => this.rangeField;
      set => this.rangeField = value;
    }

    public string cachetype
    {
      get => this.cachetypeField;
      set => this.cachetypeField = value;
    }

    public string redirect
    {
      get => this.redirectField;
      set => this.redirectField = value;
    }

    public string onpolicymatch
    {
      get => this.onpolicymatchField;
      set => this.onpolicymatchField = value;
    }

    public string redirecturl
    {
      get => this.redirecturlField;
      set => this.redirecturlField = value;
    }

    public long? clttimeout
    {
      get => this.clttimeoutField;
      set => this.clttimeoutField = value;
    }

    public string precedence
    {
      get => this.precedenceField;
      set => this.precedenceField = value;
    }

    public string arp
    {
      get => this.arpField;
      set => this.arpField = value;
    }

    public string ghost
    {
      get => this.ghostField;
      set => this.ghostField = value;
    }

    public string map
    {
      get => this.mapField;
      set => this.mapField = value;
    }

    public string format
    {
      get => this.formatField;
      set => this.formatField = value;
    }

    public string via
    {
      get => this.viaField;
      set => this.viaField = value;
    }

    public string cachevserver
    {
      get => this.cachevserverField;
      set => this.cachevserverField = value;
    }

    public string dnsvservername
    {
      get => this.dnsvservernameField;
      set => this.dnsvservernameField = value;
    }

    public string destinationvserver
    {
      get => this.destinationvserverField;
      set => this.destinationvserverField = value;
    }

    public string domain
    {
      get => this.domainField;
      set => this.domainField = value;
    }

    public uint? sopersistencetimeout
    {
      get => this.sopersistencetimeoutField;
      set => this.sopersistencetimeoutField = value;
    }

    public uint? sothreshold
    {
      get => this.sothresholdField;
      set => this.sothresholdField = value;
    }

    public string reuse
    {
      get => this.reuseField;
      set => this.reuseField = value;
    }

    public string state
    {
      get => this.stateField;
      set => this.stateField = value;
    }

    public string downstateflush
    {
      get => this.downstateflushField;
      set => this.downstateflushField = value;
    }

    public string backupvserver
    {
      get => this.backupvserverField;
      set => this.backupvserverField = value;
    }

    public string disableprimaryondown
    {
      get => this.disableprimaryondownField;
      set => this.disableprimaryondownField = value;
    }

    public string l2conn
    {
      get => this.l2connField;
      set => this.l2connField = value;
    }

    public string backendssl
    {
      get => this.backendsslField;
      set => this.backendsslField = value;
    }

    public string listenpolicy
    {
      get => this.listenpolicyField;
      set => this.listenpolicyField = value;
    }

    public uint? listenpriority
    {
      get => this.listenpriorityField;
      set => this.listenpriorityField = value;
    }

    public string tcpprofilename
    {
      get => this.tcpprofilenameField;
      set => this.tcpprofilenameField = value;
    }

    public string httpprofilename
    {
      get => this.httpprofilenameField;
      set => this.httpprofilenameField = value;
    }

    public string comment
    {
      get => this.commentField;
      set => this.commentField = value;
    }

    public string srcipexpr
    {
      get => this.srcipexprField;
      set => this.srcipexprField = value;
    }

    public string originusip
    {
      get => this.originusipField;
      set => this.originusipField = value;
    }

    public string useportrange
    {
      get => this.useportrangeField;
      set => this.useportrangeField = value;
    }

    public string appflowlog
    {
      get => this.appflowlogField;
      set => this.appflowlogField = value;
    }

    public string netprofile
    {
      get => this.netprofileField;
      set => this.netprofileField = value;
    }

    public string icmpvsrresponse
    {
      get => this.icmpvsrresponseField;
      set => this.icmpvsrresponseField = value;
    }

    public string rhistate
    {
      get => this.rhistateField;
      set => this.rhistateField = value;
    }

    public string newname
    {
      get => this.newnameField;
      set => this.newnameField = value;
    }

    public string ip
    {
      get => this.ipField;
      private set => this.ipField = value;
    }

    public string value
    {
      get => this.valueField;
      private set => this.valueField = value;
    }

    public string ngname
    {
      get => this.ngnameField;
      private set => this.ngnameField = value;
    }

    public string type
    {
      get => this.typeField;
      private set => this.typeField = value;
    }

    public string curstate
    {
      get => this.curstateField;
      private set => this.curstateField = value;
    }

    public int? status
    {
      get => this.statusField;
      private set => this.statusField = value;
    }

    public string sc
    {
      get => this.scField;
      private set => this.scField = value;
    }

    public string authentication
    {
      get => this.authenticationField;
      private set => this.authenticationField = value;
    }

    public string homepage
    {
      get => this.homepageField;
      private set => this.homepageField = value;
    }

    public string rule
    {
      get => this.ruleField;
      private set => this.ruleField = value;
    }

    public string policyname
    {
      get => this.policynameField;
      private set => this.policynameField = value;
    }

    public uint? pipolicyhits
    {
      get => this.pipolicyhitsField;
      private set => this.pipolicyhitsField = value;
    }

    public string servicename
    {
      get => this.servicenameField;
      private set => this.servicenameField = value;
    }

    public uint? weight
    {
      get => this.weightField;
      private set => this.weightField = value;
    }

    public string targetvserver
    {
      get => this.targetvserverField;
      private set => this.targetvserverField = value;
    }

    public uint? priority
    {
      get => this.priorityField;
      private set => this.priorityField = value;
    }

    public string somethod
    {
      get => this.somethodField;
      private set => this.somethodField = value;
    }

    public string sopersistence
    {
      get => this.sopersistenceField;
      private set => this.sopersistenceField = value;
    }

    public string lbvserver
    {
      get => this.lbvserverField;
      private set => this.lbvserverField = value;
    }

    public string bindpoint
    {
      get => this.bindpointField;
      private set => this.bindpointField = value;
    }

    public bool? invoke
    {
      get => this.invokeField;
      private set => this.invokeField = value;
    }

    public string labeltype
    {
      get => this.labeltypeField;
      private set => this.labeltypeField = value;
    }

    public string labelname
    {
      get => this.labelnameField;
      private set => this.labelnameField = value;
    }

    public string gotopriorityexpression
    {
      get => this.gotopriorityexpressionField;
      private set => this.gotopriorityexpressionField = value;
    }

    internal override base_resource[] get_nitro_response(
      nitro_service service,
      string response)
    {
      crvserver.crvserver_response crvserverResponse = new crvserver.crvserver_response();
      crvserver.crvserver_response resource = (crvserver.crvserver_response) service.get_payload_formatter().string_to_resource(crvserverResponse.GetType(), response);
      if (resource.errorcode != 0)
      {
        if (resource.errorcode == 444)
          service.clear_session();
        if (resource.severity == null)
          throw new nitro_exception(resource.message, resource.errorcode);
        if (resource.severity.Equals("ERROR"))
          throw new nitro_exception(resource.message, resource.errorcode);
      }
      return (base_resource[]) resource.crvserver;
    }

    internal override string get_object_name() => this.name;

    public static base_response add(nitro_service client, crvserver resource) => new crvserver()
    {
      name = resource.name,
      td = resource.td,
      servicetype = resource.servicetype,
      ipv46 = resource.ipv46,
      port = resource.port,
      range = resource.range,
      cachetype = resource.cachetype,
      redirect = resource.redirect,
      onpolicymatch = resource.onpolicymatch,
      redirecturl = resource.redirecturl,
      clttimeout = resource.clttimeout,
      precedence = resource.precedence,
      arp = resource.arp,
      ghost = resource.ghost,
      map = resource.map,
      format = resource.format,
      via = resource.via,
      cachevserver = resource.cachevserver,
      dnsvservername = resource.dnsvservername,
      destinationvserver = resource.destinationvserver,
      domain = resource.domain,
      sopersistencetimeout = resource.sopersistencetimeout,
      sothreshold = resource.sothreshold,
      reuse = resource.reuse,
      state = resource.state,
      downstateflush = resource.downstateflush,
      backupvserver = resource.backupvserver,
      disableprimaryondown = resource.disableprimaryondown,
      l2conn = resource.l2conn,
      backendssl = resource.backendssl,
      listenpolicy = resource.listenpolicy,
      listenpriority = resource.listenpriority,
      tcpprofilename = resource.tcpprofilename,
      httpprofilename = resource.httpprofilename,
      comment = resource.comment,
      srcipexpr = resource.srcipexpr,
      originusip = resource.originusip,
      useportrange = resource.useportrange,
      appflowlog = resource.appflowlog,
      netprofile = resource.netprofile,
      icmpvsrresponse = resource.icmpvsrresponse,
      rhistate = resource.rhistate
    }.add_resource(client);

    public static base_responses add(nitro_service client, crvserver[] resources)
    {
      base_responses baseResponses = (base_responses) null;
      if (resources != null && resources.Length > 0)
      {
        crvserver[] crvserverArray = new crvserver[resources.Length];
        for (int index = 0; index < resources.Length; ++index)
        {
          crvserverArray[index] = new crvserver();
          crvserverArray[index].name = resources[index].name;
          crvserverArray[index].td = resources[index].td;
          crvserverArray[index].servicetype = resources[index].servicetype;
          crvserverArray[index].ipv46 = resources[index].ipv46;
          crvserverArray[index].port = resources[index].port;
          crvserverArray[index].range = resources[index].range;
          crvserverArray[index].cachetype = resources[index].cachetype;
          crvserverArray[index].redirect = resources[index].redirect;
          crvserverArray[index].onpolicymatch = resources[index].onpolicymatch;
          crvserverArray[index].redirecturl = resources[index].redirecturl;
          crvserverArray[index].clttimeout = resources[index].clttimeout;
          crvserverArray[index].precedence = resources[index].precedence;
          crvserverArray[index].arp = resources[index].arp;
          crvserverArray[index].ghost = resources[index].ghost;
          crvserverArray[index].map = resources[index].map;
          crvserverArray[index].format = resources[index].format;
          crvserverArray[index].via = resources[index].via;
          crvserverArray[index].cachevserver = resources[index].cachevserver;
          crvserverArray[index].dnsvservername = resources[index].dnsvservername;
          crvserverArray[index].destinationvserver = resources[index].destinationvserver;
          crvserverArray[index].domain = resources[index].domain;
          crvserverArray[index].sopersistencetimeout = resources[index].sopersistencetimeout;
          crvserverArray[index].sothreshold = resources[index].sothreshold;
          crvserverArray[index].reuse = resources[index].reuse;
          crvserverArray[index].state = resources[index].state;
          crvserverArray[index].downstateflush = resources[index].downstateflush;
          crvserverArray[index].backupvserver = resources[index].backupvserver;
          crvserverArray[index].disableprimaryondown = resources[index].disableprimaryondown;
          crvserverArray[index].l2conn = resources[index].l2conn;
          crvserverArray[index].backendssl = resources[index].backendssl;
          crvserverArray[index].listenpolicy = resources[index].listenpolicy;
          crvserverArray[index].listenpriority = resources[index].listenpriority;
          crvserverArray[index].tcpprofilename = resources[index].tcpprofilename;
          crvserverArray[index].httpprofilename = resources[index].httpprofilename;
          crvserverArray[index].comment = resources[index].comment;
          crvserverArray[index].srcipexpr = resources[index].srcipexpr;
          crvserverArray[index].originusip = resources[index].originusip;
          crvserverArray[index].useportrange = resources[index].useportrange;
          crvserverArray[index].appflowlog = resources[index].appflowlog;
          crvserverArray[index].netprofile = resources[index].netprofile;
          crvserverArray[index].icmpvsrresponse = resources[index].icmpvsrresponse;
          crvserverArray[index].rhistate = resources[index].rhistate;
        }
        baseResponses = base_resource.add_bulk_request(client, (base_resource[]) crvserverArray);
      }
      return baseResponses;
    }

    public static base_response delete(nitro_service client, string name) => new crvserver()
    {
      name = name
    }.delete_resource(client);

    public static base_response delete(nitro_service client, crvserver resource) => new crvserver()
    {
      name = resource.name
    }.delete_resource(client);

    public static base_responses delete(nitro_service client, string[] name)
    {
      base_responses baseResponses = (base_responses) null;
      if (name != null && name.Length > 0)
      {
        crvserver[] crvserverArray = new crvserver[name.Length];
        for (int index = 0; index < name.Length; ++index)
        {
          crvserverArray[index] = new crvserver();
          crvserverArray[index].name = name[index];
        }
        baseResponses = base_resource.delete_bulk_request(client, (base_resource[]) crvserverArray);
      }
      return baseResponses;
    }

    public static base_responses delete(nitro_service client, crvserver[] resources)
    {
      base_responses baseResponses = (base_responses) null;
      if (resources != null && resources.Length > 0)
      {
        crvserver[] crvserverArray = new crvserver[resources.Length];
        for (int index = 0; index < resources.Length; ++index)
        {
          crvserverArray[index] = new crvserver();
          crvserverArray[index].name = resources[index].name;
        }
        baseResponses = base_resource.delete_bulk_request(client, (base_resource[]) crvserverArray);
      }
      return baseResponses;
    }

    public static base_response update(nitro_service client, crvserver resource) => new crvserver()
    {
      name = resource.name,
      ipv46 = resource.ipv46,
      redirect = resource.redirect,
      onpolicymatch = resource.onpolicymatch,
      precedence = resource.precedence,
      arp = resource.arp,
      via = resource.via,
      cachevserver = resource.cachevserver,
      dnsvservername = resource.dnsvservername,
      destinationvserver = resource.destinationvserver,
      domain = resource.domain,
      reuse = resource.reuse,
      backupvserver = resource.backupvserver,
      disableprimaryondown = resource.disableprimaryondown,
      redirecturl = resource.redirecturl,
      clttimeout = resource.clttimeout,
      downstateflush = resource.downstateflush,
      l2conn = resource.l2conn,
      backendssl = resource.backendssl,
      listenpolicy = resource.listenpolicy,
      listenpriority = resource.listenpriority,
      tcpprofilename = resource.tcpprofilename,
      httpprofilename = resource.httpprofilename,
      netprofile = resource.netprofile,
      comment = resource.comment,
      srcipexpr = resource.srcipexpr,
      originusip = resource.originusip,
      useportrange = resource.useportrange,
      appflowlog = resource.appflowlog,
      icmpvsrresponse = resource.icmpvsrresponse,
      rhistate = resource.rhistate
    }.update_resource(client);

    public static base_responses update(nitro_service client, crvserver[] resources)
    {
      base_responses baseResponses = (base_responses) null;
      if (resources != null && resources.Length > 0)
      {
        crvserver[] crvserverArray = new crvserver[resources.Length];
        for (int index = 0; index < resources.Length; ++index)
        {
          crvserverArray[index] = new crvserver();
          crvserverArray[index].name = resources[index].name;
          crvserverArray[index].ipv46 = resources[index].ipv46;
          crvserverArray[index].redirect = resources[index].redirect;
          crvserverArray[index].onpolicymatch = resources[index].onpolicymatch;
          crvserverArray[index].precedence = resources[index].precedence;
          crvserverArray[index].arp = resources[index].arp;
          crvserverArray[index].via = resources[index].via;
          crvserverArray[index].cachevserver = resources[index].cachevserver;
          crvserverArray[index].dnsvservername = resources[index].dnsvservername;
          crvserverArray[index].destinationvserver = resources[index].destinationvserver;
          crvserverArray[index].domain = resources[index].domain;
          crvserverArray[index].reuse = resources[index].reuse;
          crvserverArray[index].backupvserver = resources[index].backupvserver;
          crvserverArray[index].disableprimaryondown = resources[index].disableprimaryondown;
          crvserverArray[index].redirecturl = resources[index].redirecturl;
          crvserverArray[index].clttimeout = resources[index].clttimeout;
          crvserverArray[index].downstateflush = resources[index].downstateflush;
          crvserverArray[index].l2conn = resources[index].l2conn;
          crvserverArray[index].backendssl = resources[index].backendssl;
          crvserverArray[index].listenpolicy = resources[index].listenpolicy;
          crvserverArray[index].listenpriority = resources[index].listenpriority;
          crvserverArray[index].tcpprofilename = resources[index].tcpprofilename;
          crvserverArray[index].httpprofilename = resources[index].httpprofilename;
          crvserverArray[index].netprofile = resources[index].netprofile;
          crvserverArray[index].comment = resources[index].comment;
          crvserverArray[index].srcipexpr = resources[index].srcipexpr;
          crvserverArray[index].originusip = resources[index].originusip;
          crvserverArray[index].useportrange = resources[index].useportrange;
          crvserverArray[index].appflowlog = resources[index].appflowlog;
          crvserverArray[index].icmpvsrresponse = resources[index].icmpvsrresponse;
          crvserverArray[index].rhistate = resources[index].rhistate;
        }
        baseResponses = base_resource.update_bulk_request(client, (base_resource[]) crvserverArray);
      }
      return baseResponses;
    }

    public static base_response unset(
      nitro_service client,
      string name,
      string[] args)
    {
      return new crvserver() { name = name }.unset_resource(client, args);
    }

    public static base_response unset(
      nitro_service client,
      crvserver resource,
      string[] args)
    {
      return new crvserver() { name = resource.name }.unset_resource(client, args);
    }

    public static base_responses unset(
      nitro_service client,
      string[] name,
      string[] args)
    {
      base_responses baseResponses = (base_responses) null;
      if (name != null && name.Length > 0)
      {
        crvserver[] crvserverArray = new crvserver[name.Length];
        for (int index = 0; index < name.Length; ++index)
        {
          crvserverArray[index] = new crvserver();
          crvserverArray[index].name = name[index];
        }
        baseResponses = base_resource.unset_bulk_request(client, (base_resource[]) crvserverArray, args);
      }
      return baseResponses;
    }

    public static base_responses unset(
      nitro_service client,
      crvserver[] resources,
      string[] args)
    {
      base_responses baseResponses = (base_responses) null;
      if (resources != null && resources.Length > 0)
      {
        crvserver[] crvserverArray = new crvserver[resources.Length];
        for (int index = 0; index < resources.Length; ++index)
        {
          crvserverArray[index] = new crvserver();
          crvserverArray[index].name = resources[index].name;
        }
        baseResponses = base_resource.unset_bulk_request(client, (base_resource[]) crvserverArray, args);
      }
      return baseResponses;
    }

    public static base_response enable(nitro_service client, string name) => new crvserver()
    {
      name = name
    }.perform_operation_byaction(client, nameof (enable));

    public static base_response enable(nitro_service client, crvserver resource) => new crvserver()
    {
      name = resource.name
    }.perform_operation_byaction(client, nameof (enable));

    public static base_responses enable(nitro_service client, string[] name)
    {
      base_responses baseResponses = (base_responses) null;
      if (name != null && name.Length > 0)
      {
        crvserver[] crvserverArray = new crvserver[name.Length];
        for (int index = 0; index < name.Length; ++index)
        {
          crvserverArray[index] = new crvserver();
          crvserverArray[index].name = name[index];
        }
        baseResponses = base_resource.perform_operation_bulk_request(client, (base_resource[]) crvserverArray, nameof (enable));
      }
      return baseResponses;
    }

    public static base_responses enable(nitro_service client, crvserver[] resources)
    {
      base_responses baseResponses = (base_responses) null;
      if (resources != null && resources.Length > 0)
      {
        crvserver[] crvserverArray = new crvserver[resources.Length];
        for (int index = 0; index < resources.Length; ++index)
        {
          crvserverArray[index] = new crvserver();
          crvserverArray[index].name = resources[index].name;
        }
        baseResponses = base_resource.perform_operation_bulk_request(client, (base_resource[]) crvserverArray, nameof (enable));
      }
      return baseResponses;
    }

    public static base_response disable(nitro_service client, string name) => new crvserver()
    {
      name = name
    }.perform_operation_byaction(client, nameof (disable));

    public static base_response disable(nitro_service client, crvserver resource) => new crvserver()
    {
      name = resource.name
    }.perform_operation_byaction(client, nameof (disable));

    public static base_responses disable(nitro_service client, string[] name)
    {
      base_responses baseResponses = (base_responses) null;
      if (name != null && name.Length > 0)
      {
        crvserver[] crvserverArray = new crvserver[name.Length];
        for (int index = 0; index < name.Length; ++index)
        {
          crvserverArray[index] = new crvserver();
          crvserverArray[index].name = name[index];
        }
        baseResponses = base_resource.perform_operation_bulk_request(client, (base_resource[]) crvserverArray, nameof (disable));
      }
      return baseResponses;
    }

    public static base_responses disable(nitro_service client, crvserver[] resources)
    {
      base_responses baseResponses = (base_responses) null;
      if (resources != null && resources.Length > 0)
      {
        crvserver[] crvserverArray = new crvserver[resources.Length];
        for (int index = 0; index < resources.Length; ++index)
        {
          crvserverArray[index] = new crvserver();
          crvserverArray[index].name = resources[index].name;
        }
        baseResponses = base_resource.perform_operation_bulk_request(client, (base_resource[]) crvserverArray, nameof (disable));
      }
      return baseResponses;
    }

    public static base_response rename(
      nitro_service client,
      crvserver resource,
      string new_name)
    {
      return new crvserver()
      {
        name = resource.name,
        newname = new_name
      }.rename_resource(client);
    }

    public static base_response rename(
      nitro_service client,
      string name,
      string new_name)
    {
      return new crvserver()
      {
        name = name,
        newname = new_name
      }.rename_resource(client);
    }

    public static crvserver[] get(nitro_service service) => (crvserver[]) new crvserver().get_resources(service, (options) null);

    public static crvserver[] get(nitro_service service, options option) => (crvserver[]) new crvserver().get_resources(service, option);

    public static crvserver get(nitro_service service, string name) => (crvserver) new crvserver()
    {
      name = name
    }.get_resource(service);

    public static crvserver[] get(nitro_service service, string[] name)
    {
      if (name == null || name.Length <= 0)
        return (crvserver[]) null;
      crvserver[] crvserverArray1 = new crvserver[name.Length];
      crvserver[] crvserverArray2 = new crvserver[name.Length];
      for (int index = 0; index < name.Length; ++index)
      {
        crvserverArray2[index] = new crvserver();
        crvserverArray2[index].name = name[index];
        crvserverArray1[index] = (crvserver) crvserverArray2[index].get_resource(service);
      }
      return crvserverArray1;
    }

    public static crvserver[] get_filtered(nitro_service service, string filter)
    {
      crvserver crvserver = new crvserver();
      options option = new options();
      option.set_filter(filter);
      return (crvserver[]) crvserver.getfiltered(service, option);
    }

    public static crvserver[] get_filtered(nitro_service service, filtervalue[] filter)
    {
      crvserver crvserver = new crvserver();
      options option = new options();
      option.set_filter(filter);
      return (crvserver[]) crvserver.getfiltered(service, option);
    }

    public static uint count(nitro_service service)
    {
      crvserver crvserver = new crvserver();
      options option = new options();
      option.set_count(true);
      crvserver[] resources = (crvserver[]) crvserver.get_resources(service, option);
      return resources != null && resources.Length > 0 ? resources[0].__count.Value : 0U;
    }

    public static uint count_filtered(nitro_service service, string filter)
    {
      crvserver crvserver = new crvserver();
      options option = new options();
      option.set_count(true);
      option.set_filter(filter);
      crvserver[] crvserverArray = (crvserver[]) crvserver.getfiltered(service, option);
      return crvserverArray != null && crvserverArray.Length > 0 ? crvserverArray[0].__count.Value : 0U;
    }

    public static uint count_filtered(nitro_service service, filtervalue[] filter)
    {
      crvserver crvserver = new crvserver();
      options option = new options();
      option.set_count(true);
      option.set_filter(filter);
      crvserver[] crvserverArray = (crvserver[]) crvserver.getfiltered(service, option);
      return crvserverArray != null && crvserverArray.Length > 0 ? crvserverArray[0].__count.Value : 0U;
    }

    private class crvserver_response : base_response
    {
      public crvserver[] crvserver = (crvserver[]) null;
    }

    public static class scEnum
    {
      public const string ON = "ON";
      public const string OFF = "OFF";
    }

    public static class rhistateEnum
    {
      public const string PASSIVE = "PASSIVE";
      public const string ACTIVE = "ACTIVE";
    }

    public static class authenticationEnum
    {
      public const string ON = "ON";
      public const string OFF = "OFF";
    }

    public static class stateEnum
    {
      public const string ENABLED = "ENABLED";
      public const string DISABLED = "DISABLED";
    }

    public static class mapEnum
    {
      public const string ON = "ON";
      public const string OFF = "OFF";
    }

    public static class cachetypeEnum
    {
      public const string TRANSPARENT = "TRANSPARENT";
      public const string REVERSE = "REVERSE";
      public const string FORWARD = "FORWARD";
    }

    public static class downstateflushEnum
    {
      public const string ENABLED = "ENABLED";
      public const string DISABLED = "DISABLED";
    }

    public static class servicetypeEnum
    {
      public const string HTTP = "HTTP";
      public const string SSL = "SSL";
      public const string NNTP = "NNTP";
      public const string HDX = "HDX";
    }

    public static class icmpvsrresponseEnum
    {
      public const string PASSIVE = "PASSIVE";
      public const string ACTIVE = "ACTIVE";
    }

    public static class valueEnum
    {
      public const string Certkey_not_bound = "Certkey not bound";
      public const string SSL_feature_disabled = "SSL feature disabled";
    }

    public static class l2connEnum
    {
      public const string ON = "ON";
      public const string OFF = "OFF";
    }

    public static class typeEnum
    {
      public const string CONTENT = "CONTENT";
      public const string ADDRESS = "ADDRESS";
    }

    public static class useportrangeEnum
    {
      public const string ON = "ON";
      public const string OFF = "OFF";
    }

    public static class disableprimaryondownEnum
    {
      public const string ENABLED = "ENABLED";
      public const string DISABLED = "DISABLED";
    }

    public static class somethodEnum
    {
      public const string CONNECTION = "CONNECTION";
      public const string DYNAMICCONNECTION = "DYNAMICCONNECTION";
      public const string BANDWIDTH = "BANDWIDTH";
      public const string HEALTH = "HEALTH";
      public const string NONE = "NONE";
    }

    public static class bindpointEnum
    {
      public const string REQUEST = "REQUEST";
      public const string RESPONSE = "RESPONSE";
      public const string ICA_REQUEST = "ICA_REQUEST";
    }

    public static class sopersistenceEnum
    {
      public const string ENABLED = "ENABLED";
      public const string DISABLED = "DISABLED";
    }

    public static class arpEnum
    {
      public const string ON = "ON";
      public const string OFF = "OFF";
    }

    public static class redirectEnum
    {
      public const string CACHE = "CACHE";
      public const string POLICY = "POLICY";
      public const string ORIGIN = "ORIGIN";
    }

    public static class labeltypeEnum
    {
      public const string reqvserver = "reqvserver";
      public const string resvserver = "resvserver";
      public const string policylabel = "policylabel";
    }

    public static class onpolicymatchEnum
    {
      public const string CACHE = "CACHE";
      public const string ORIGIN = "ORIGIN";
    }

    public static class ghostEnum
    {
      public const string ON = "ON";
      public const string OFF = "OFF";
    }

    public static class appflowlogEnum
    {
      public const string ENABLED = "ENABLED";
      public const string DISABLED = "DISABLED";
    }

    public static class originusipEnum
    {
      public const string ON = "ON";
      public const string OFF = "OFF";
    }

    public static class precedenceEnum
    {
      public const string RULE = "RULE";
      public const string URL = "URL";
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

    public static class reuseEnum
    {
      public const string ON = "ON";
      public const string OFF = "OFF";
    }

    public static class viaEnum
    {
      public const string ON = "ON";
      public const string OFF = "OFF";
    }

    public static class formatEnum
    {
      public const string ON = "ON";
      public const string OFF = "OFF";
    }

    public static class backendsslEnum
    {
      public const string ENABLED = "ENABLED";
      public const string DISABLED = "DISABLED";
    }
  }
}
