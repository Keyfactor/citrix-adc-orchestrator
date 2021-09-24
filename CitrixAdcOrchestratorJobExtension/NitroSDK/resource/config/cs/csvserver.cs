// Decompiled with JetBrains decompiler
// Type: com.citrix.netscaler.nitro.resource.config.cs.csvserver
// Assembly: nitro, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 6CF5DDEF-E052-4F9D-953F-6644F8378A66


using com.citrix.netscaler.nitro.exception;
using com.citrix.netscaler.nitro.resource.Base;
using com.citrix.netscaler.nitro.service;
using com.citrix.netscaler.nitro.util;

namespace com.citrix.netscaler.nitro.resource.config.cs
{
  public class csvserver : base_resource
  {
    private string nameField = (string) null;
    private uint? tdField = new uint?();
    private string servicetypeField = (string) null;
    private string ipv46Field = (string) null;
    private string targettypeField = (string) null;
    private string dnsrecordtypeField = (string) null;
    private uint? persistenceidField = new uint?();
    private string ippatternField = (string) null;
    private string ipmaskField = (string) null;
    private uint? rangeField = new uint?();
    private ushort? portField = new ushort?();
    private string stateField = (string) null;
    private string stateupdateField = (string) null;
    private string cacheableField = (string) null;
    private string redirecturlField = (string) null;
    private long? clttimeoutField = new long?();
    private string precedenceField = (string) null;
    private string casesensitiveField = (string) null;
    private string somethodField = (string) null;
    private string sopersistenceField = (string) null;
    private uint? sopersistencetimeoutField = new uint?();
    private uint? sothresholdField = new uint?();
    private string sobackupactionField = (string) null;
    private string redirectportrewriteField = (string) null;
    private string downstateflushField = (string) null;
    private string backupvserverField = (string) null;
    private string disableprimaryondownField = (string) null;
    private string insertvserveripportField = (string) null;
    private string vipheaderField = (string) null;
    private string rtspnatField = (string) null;
    private string authenticationhostField = (string) null;
    private string authenticationField = (string) null;
    private string listenpolicyField = (string) null;
    private uint? listenpriorityField = new uint?();
    private string authn401Field = (string) null;
    private string authnvsnameField = (string) null;
    private string pushField = (string) null;
    private string pushvserverField = (string) null;
    private string pushlabelField = (string) null;
    private string pushmulticlientsField = (string) null;
    private string tcpprofilenameField = (string) null;
    private string httpprofilenameField = (string) null;
    private string dbprofilenameField = (string) null;
    private string oracleserverversionField = (string) null;
    private string commentField = (string) null;
    private string mssqlserverversionField = (string) null;
    private string l2connField = (string) null;
    private uint? mysqlprotocolversionField = new uint?();
    private string mysqlserverversionField = (string) null;
    private uint? mysqlcharactersetField = new uint?();
    private uint? mysqlservercapabilitiesField = new uint?();
    private string appflowlogField = (string) null;
    private string netprofileField = (string) null;
    private string icmpvsrresponseField = (string) null;
    private string rhistateField = (string) null;
    private string authnprofileField = (string) null;
    private string dnsprofilenameField = (string) null;
    private string domainnameField = (string) null;
    private long? ttlField = new long?();
    private string backupipField = (string) null;
    private string cookiedomainField = (string) null;
    private uint? cookietimeoutField = new uint?();
    private long? sitedomainttlField = new long?();
    private string newnameField = (string) null;
    private string ipField = (string) null;
    private string valueField = (string) null;
    private string ngnameField = (string) null;
    private string typeField = (string) null;
    private string curstateField = (string) null;
    private string scField = (string) null;
    private int? statusField = new int?();
    private string cachetypeField = (string) null;
    private string redirectField = (string) null;
    private string homepageField = (string) null;
    private string dnsvservernameField = (string) null;
    private string domainField = (string) null;
    private string policynameField = (string) null;
    private string servicenameField = (string) null;
    private uint? weightField = new uint?();
    private string cachevserverField = (string) null;
    private string targetvserverField = (string) null;
    private uint? priorityField = new uint?();
    private string urlField = (string) null;
    private string gotopriorityexpressionField = (string) null;
    private string bindpointField = (string) null;
    private bool? invokeField = new bool?();
    private string labeltypeField = (string) null;
    private string labelnameField = (string) null;
    private string gt2gbField = (string) null;
    private string statechangetimesecField = (string) null;
    private uint? statechangetimemsecField = new uint?();
    private uint? tickssincelaststatechangeField = new uint?();
    private uint? ruletypeField = new uint?();
    private string lbvserverField = (string) null;
    private string targetlbvserverField = (string) null;
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

    public string targettype
    {
      get => this.targettypeField;
      set => this.targettypeField = value;
    }

    public string dnsrecordtype
    {
      get => this.dnsrecordtypeField;
      set => this.dnsrecordtypeField = value;
    }

    public uint? persistenceid
    {
      get => this.persistenceidField;
      set => this.persistenceidField = value;
    }

    public string ippattern
    {
      get => this.ippatternField;
      set => this.ippatternField = value;
    }

    public string ipmask
    {
      get => this.ipmaskField;
      set => this.ipmaskField = value;
    }

    public uint? range
    {
      get => this.rangeField;
      set => this.rangeField = value;
    }

    public ushort? port
    {
      get => this.portField;
      set => this.portField = value;
    }

    public string state
    {
      get => this.stateField;
      set => this.stateField = value;
    }

    public string stateupdate
    {
      get => this.stateupdateField;
      set => this.stateupdateField = value;
    }

    public string cacheable
    {
      get => this.cacheableField;
      set => this.cacheableField = value;
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

    public string casesensitive
    {
      get => this.casesensitiveField;
      set => this.casesensitiveField = value;
    }

    public string somethod
    {
      get => this.somethodField;
      set => this.somethodField = value;
    }

    public string sopersistence
    {
      get => this.sopersistenceField;
      set => this.sopersistenceField = value;
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

    public string sobackupaction
    {
      get => this.sobackupactionField;
      set => this.sobackupactionField = value;
    }

    public string redirectportrewrite
    {
      get => this.redirectportrewriteField;
      set => this.redirectportrewriteField = value;
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

    public string insertvserveripport
    {
      get => this.insertvserveripportField;
      set => this.insertvserveripportField = value;
    }

    public string vipheader
    {
      get => this.vipheaderField;
      set => this.vipheaderField = value;
    }

    public string rtspnat
    {
      get => this.rtspnatField;
      set => this.rtspnatField = value;
    }

    public string authenticationhost
    {
      get => this.authenticationhostField;
      set => this.authenticationhostField = value;
    }

    public string authentication
    {
      get => this.authenticationField;
      set => this.authenticationField = value;
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

    public string authn401
    {
      get => this.authn401Field;
      set => this.authn401Field = value;
    }

    public string authnvsname
    {
      get => this.authnvsnameField;
      set => this.authnvsnameField = value;
    }

    public string push
    {
      get => this.pushField;
      set => this.pushField = value;
    }

    public string pushvserver
    {
      get => this.pushvserverField;
      set => this.pushvserverField = value;
    }

    public string pushlabel
    {
      get => this.pushlabelField;
      set => this.pushlabelField = value;
    }

    public string pushmulticlients
    {
      get => this.pushmulticlientsField;
      set => this.pushmulticlientsField = value;
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

    public string dbprofilename
    {
      get => this.dbprofilenameField;
      set => this.dbprofilenameField = value;
    }

    public string oracleserverversion
    {
      get => this.oracleserverversionField;
      set => this.oracleserverversionField = value;
    }

    public string comment
    {
      get => this.commentField;
      set => this.commentField = value;
    }

    public string mssqlserverversion
    {
      get => this.mssqlserverversionField;
      set => this.mssqlserverversionField = value;
    }

    public string l2conn
    {
      get => this.l2connField;
      set => this.l2connField = value;
    }

    public uint? mysqlprotocolversion
    {
      get => this.mysqlprotocolversionField;
      set => this.mysqlprotocolversionField = value;
    }

    public string mysqlserverversion
    {
      get => this.mysqlserverversionField;
      set => this.mysqlserverversionField = value;
    }

    public uint? mysqlcharacterset
    {
      get => this.mysqlcharactersetField;
      set => this.mysqlcharactersetField = value;
    }

    public uint? mysqlservercapabilities
    {
      get => this.mysqlservercapabilitiesField;
      set => this.mysqlservercapabilitiesField = value;
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

    public string authnprofile
    {
      get => this.authnprofileField;
      set => this.authnprofileField = value;
    }

    public string dnsprofilename
    {
      get => this.dnsprofilenameField;
      set => this.dnsprofilenameField = value;
    }

    public string domainname
    {
      get => this.domainnameField;
      set => this.domainnameField = value;
    }

    public long? ttl
    {
      get => this.ttlField;
      set => this.ttlField = value;
    }

    public string backupip
    {
      get => this.backupipField;
      set => this.backupipField = value;
    }

    public string cookiedomain
    {
      get => this.cookiedomainField;
      set => this.cookiedomainField = value;
    }

    public uint? cookietimeout
    {
      get => this.cookietimeoutField;
      set => this.cookietimeoutField = value;
    }

    public long? sitedomainttl
    {
      get => this.sitedomainttlField;
      set => this.sitedomainttlField = value;
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

    public string sc
    {
      get => this.scField;
      private set => this.scField = value;
    }

    public int? status
    {
      get => this.statusField;
      private set => this.statusField = value;
    }

    public string cachetype
    {
      get => this.cachetypeField;
      private set => this.cachetypeField = value;
    }

    public string redirect
    {
      get => this.redirectField;
      private set => this.redirectField = value;
    }

    public string homepage
    {
      get => this.homepageField;
      private set => this.homepageField = value;
    }

    public string dnsvservername
    {
      get => this.dnsvservernameField;
      private set => this.dnsvservernameField = value;
    }

    public string domain
    {
      get => this.domainField;
      private set => this.domainField = value;
    }

    public string policyname
    {
      get => this.policynameField;
      private set => this.policynameField = value;
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

    public string cachevserver
    {
      get => this.cachevserverField;
      private set => this.cachevserverField = value;
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

    public string url
    {
      get => this.urlField;
      private set => this.urlField = value;
    }

    public string gotopriorityexpression
    {
      get => this.gotopriorityexpressionField;
      private set => this.gotopriorityexpressionField = value;
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

    public string gt2gb
    {
      get => this.gt2gbField;
      private set => this.gt2gbField = value;
    }

    public string statechangetimesec
    {
      get => this.statechangetimesecField;
      private set => this.statechangetimesecField = value;
    }

    public uint? statechangetimemsec
    {
      get => this.statechangetimemsecField;
      private set => this.statechangetimemsecField = value;
    }

    public uint? tickssincelaststatechange
    {
      get => this.tickssincelaststatechangeField;
      private set => this.tickssincelaststatechangeField = value;
    }

    public uint? ruletype
    {
      get => this.ruletypeField;
      private set => this.ruletypeField = value;
    }

    public string lbvserver
    {
      get => this.lbvserverField;
      private set => this.lbvserverField = value;
    }

    public string targetlbvserver
    {
      get => this.targetlbvserverField;
      private set => this.targetlbvserverField = value;
    }

    internal override base_resource[] get_nitro_response(
      nitro_service service,
      string response)
    {
      csvserver.csvserver_response csvserverResponse = new csvserver.csvserver_response();
      csvserver.csvserver_response resource = (csvserver.csvserver_response) service.get_payload_formatter().string_to_resource(csvserverResponse.GetType(), response);
      if (resource.errorcode != 0)
      {
        if (resource.errorcode == 444)
          service.clear_session();
        if (resource.severity == null)
          throw new nitro_exception(resource.message, resource.errorcode);
        if (resource.severity.Equals("ERROR"))
          throw new nitro_exception(resource.message, resource.errorcode);
      }
      return (base_resource[]) resource.csvserver;
    }

    internal override string get_object_name() => this.name;

    public static base_response add(nitro_service client, csvserver resource) => new csvserver()
    {
      name = resource.name,
      td = resource.td,
      servicetype = resource.servicetype,
      ipv46 = resource.ipv46,
      targettype = resource.targettype,
      dnsrecordtype = resource.dnsrecordtype,
      persistenceid = resource.persistenceid,
      ippattern = resource.ippattern,
      ipmask = resource.ipmask,
      range = resource.range,
      port = resource.port,
      state = resource.state,
      stateupdate = resource.stateupdate,
      cacheable = resource.cacheable,
      redirecturl = resource.redirecturl,
      clttimeout = resource.clttimeout,
      precedence = resource.precedence,
      casesensitive = resource.casesensitive,
      somethod = resource.somethod,
      sopersistence = resource.sopersistence,
      sopersistencetimeout = resource.sopersistencetimeout,
      sothreshold = resource.sothreshold,
      sobackupaction = resource.sobackupaction,
      redirectportrewrite = resource.redirectportrewrite,
      downstateflush = resource.downstateflush,
      backupvserver = resource.backupvserver,
      disableprimaryondown = resource.disableprimaryondown,
      insertvserveripport = resource.insertvserveripport,
      vipheader = resource.vipheader,
      rtspnat = resource.rtspnat,
      authenticationhost = resource.authenticationhost,
      authentication = resource.authentication,
      listenpolicy = resource.listenpolicy,
      listenpriority = resource.listenpriority,
      authn401 = resource.authn401,
      authnvsname = resource.authnvsname,
      push = resource.push,
      pushvserver = resource.pushvserver,
      pushlabel = resource.pushlabel,
      pushmulticlients = resource.pushmulticlients,
      tcpprofilename = resource.tcpprofilename,
      httpprofilename = resource.httpprofilename,
      dbprofilename = resource.dbprofilename,
      oracleserverversion = resource.oracleserverversion,
      comment = resource.comment,
      mssqlserverversion = resource.mssqlserverversion,
      l2conn = resource.l2conn,
      mysqlprotocolversion = resource.mysqlprotocolversion,
      mysqlserverversion = resource.mysqlserverversion,
      mysqlcharacterset = resource.mysqlcharacterset,
      mysqlservercapabilities = resource.mysqlservercapabilities,
      appflowlog = resource.appflowlog,
      netprofile = resource.netprofile,
      icmpvsrresponse = resource.icmpvsrresponse,
      rhistate = resource.rhistate,
      authnprofile = resource.authnprofile,
      dnsprofilename = resource.dnsprofilename
    }.add_resource(client);

    public static base_responses add(nitro_service client, csvserver[] resources)
    {
      base_responses baseResponses = (base_responses) null;
      if (resources != null && resources.Length > 0)
      {
        csvserver[] csvserverArray = new csvserver[resources.Length];
        for (int index = 0; index < resources.Length; ++index)
        {
          csvserverArray[index] = new csvserver();
          csvserverArray[index].name = resources[index].name;
          csvserverArray[index].td = resources[index].td;
          csvserverArray[index].servicetype = resources[index].servicetype;
          csvserverArray[index].ipv46 = resources[index].ipv46;
          csvserverArray[index].targettype = resources[index].targettype;
          csvserverArray[index].dnsrecordtype = resources[index].dnsrecordtype;
          csvserverArray[index].persistenceid = resources[index].persistenceid;
          csvserverArray[index].ippattern = resources[index].ippattern;
          csvserverArray[index].ipmask = resources[index].ipmask;
          csvserverArray[index].range = resources[index].range;
          csvserverArray[index].port = resources[index].port;
          csvserverArray[index].state = resources[index].state;
          csvserverArray[index].stateupdate = resources[index].stateupdate;
          csvserverArray[index].cacheable = resources[index].cacheable;
          csvserverArray[index].redirecturl = resources[index].redirecturl;
          csvserverArray[index].clttimeout = resources[index].clttimeout;
          csvserverArray[index].precedence = resources[index].precedence;
          csvserverArray[index].casesensitive = resources[index].casesensitive;
          csvserverArray[index].somethod = resources[index].somethod;
          csvserverArray[index].sopersistence = resources[index].sopersistence;
          csvserverArray[index].sopersistencetimeout = resources[index].sopersistencetimeout;
          csvserverArray[index].sothreshold = resources[index].sothreshold;
          csvserverArray[index].sobackupaction = resources[index].sobackupaction;
          csvserverArray[index].redirectportrewrite = resources[index].redirectportrewrite;
          csvserverArray[index].downstateflush = resources[index].downstateflush;
          csvserverArray[index].backupvserver = resources[index].backupvserver;
          csvserverArray[index].disableprimaryondown = resources[index].disableprimaryondown;
          csvserverArray[index].insertvserveripport = resources[index].insertvserveripport;
          csvserverArray[index].vipheader = resources[index].vipheader;
          csvserverArray[index].rtspnat = resources[index].rtspnat;
          csvserverArray[index].authenticationhost = resources[index].authenticationhost;
          csvserverArray[index].authentication = resources[index].authentication;
          csvserverArray[index].listenpolicy = resources[index].listenpolicy;
          csvserverArray[index].listenpriority = resources[index].listenpriority;
          csvserverArray[index].authn401 = resources[index].authn401;
          csvserverArray[index].authnvsname = resources[index].authnvsname;
          csvserverArray[index].push = resources[index].push;
          csvserverArray[index].pushvserver = resources[index].pushvserver;
          csvserverArray[index].pushlabel = resources[index].pushlabel;
          csvserverArray[index].pushmulticlients = resources[index].pushmulticlients;
          csvserverArray[index].tcpprofilename = resources[index].tcpprofilename;
          csvserverArray[index].httpprofilename = resources[index].httpprofilename;
          csvserverArray[index].dbprofilename = resources[index].dbprofilename;
          csvserverArray[index].oracleserverversion = resources[index].oracleserverversion;
          csvserverArray[index].comment = resources[index].comment;
          csvserverArray[index].mssqlserverversion = resources[index].mssqlserverversion;
          csvserverArray[index].l2conn = resources[index].l2conn;
          csvserverArray[index].mysqlprotocolversion = resources[index].mysqlprotocolversion;
          csvserverArray[index].mysqlserverversion = resources[index].mysqlserverversion;
          csvserverArray[index].mysqlcharacterset = resources[index].mysqlcharacterset;
          csvserverArray[index].mysqlservercapabilities = resources[index].mysqlservercapabilities;
          csvserverArray[index].appflowlog = resources[index].appflowlog;
          csvserverArray[index].netprofile = resources[index].netprofile;
          csvserverArray[index].icmpvsrresponse = resources[index].icmpvsrresponse;
          csvserverArray[index].rhistate = resources[index].rhistate;
          csvserverArray[index].authnprofile = resources[index].authnprofile;
          csvserverArray[index].dnsprofilename = resources[index].dnsprofilename;
        }
        baseResponses = base_resource.add_bulk_request(client, (base_resource[]) csvserverArray);
      }
      return baseResponses;
    }

    public static base_response delete(nitro_service client, string name) => new csvserver()
    {
      name = name
    }.delete_resource(client);

    public static base_response delete(nitro_service client, csvserver resource) => new csvserver()
    {
      name = resource.name
    }.delete_resource(client);

    public static base_responses delete(nitro_service client, string[] name)
    {
      base_responses baseResponses = (base_responses) null;
      if (name != null && name.Length > 0)
      {
        csvserver[] csvserverArray = new csvserver[name.Length];
        for (int index = 0; index < name.Length; ++index)
        {
          csvserverArray[index] = new csvserver();
          csvserverArray[index].name = name[index];
        }
        baseResponses = base_resource.delete_bulk_request(client, (base_resource[]) csvserverArray);
      }
      return baseResponses;
    }

    public static base_responses delete(nitro_service client, csvserver[] resources)
    {
      base_responses baseResponses = (base_responses) null;
      if (resources != null && resources.Length > 0)
      {
        csvserver[] csvserverArray = new csvserver[resources.Length];
        for (int index = 0; index < resources.Length; ++index)
        {
          csvserverArray[index] = new csvserver();
          csvserverArray[index].name = resources[index].name;
        }
        baseResponses = base_resource.delete_bulk_request(client, (base_resource[]) csvserverArray);
      }
      return baseResponses;
    }

    public static base_response update(nitro_service client, csvserver resource) => new csvserver()
    {
      name = resource.name,
      ipv46 = resource.ipv46,
      ippattern = resource.ippattern,
      ipmask = resource.ipmask,
      stateupdate = resource.stateupdate,
      precedence = resource.precedence,
      casesensitive = resource.casesensitive,
      backupvserver = resource.backupvserver,
      redirecturl = resource.redirecturl,
      cacheable = resource.cacheable,
      clttimeout = resource.clttimeout,
      somethod = resource.somethod,
      sopersistence = resource.sopersistence,
      sopersistencetimeout = resource.sopersistencetimeout,
      sothreshold = resource.sothreshold,
      sobackupaction = resource.sobackupaction,
      redirectportrewrite = resource.redirectportrewrite,
      downstateflush = resource.downstateflush,
      disableprimaryondown = resource.disableprimaryondown,
      insertvserveripport = resource.insertvserveripport,
      vipheader = resource.vipheader,
      rtspnat = resource.rtspnat,
      authenticationhost = resource.authenticationhost,
      authentication = resource.authentication,
      listenpolicy = resource.listenpolicy,
      listenpriority = resource.listenpriority,
      authn401 = resource.authn401,
      authnvsname = resource.authnvsname,
      push = resource.push,
      pushvserver = resource.pushvserver,
      pushlabel = resource.pushlabel,
      pushmulticlients = resource.pushmulticlients,
      tcpprofilename = resource.tcpprofilename,
      httpprofilename = resource.httpprofilename,
      dbprofilename = resource.dbprofilename,
      comment = resource.comment,
      l2conn = resource.l2conn,
      mssqlserverversion = resource.mssqlserverversion,
      mysqlprotocolversion = resource.mysqlprotocolversion,
      oracleserverversion = resource.oracleserverversion,
      mysqlserverversion = resource.mysqlserverversion,
      mysqlcharacterset = resource.mysqlcharacterset,
      mysqlservercapabilities = resource.mysqlservercapabilities,
      appflowlog = resource.appflowlog,
      netprofile = resource.netprofile,
      authnprofile = resource.authnprofile,
      icmpvsrresponse = resource.icmpvsrresponse,
      rhistate = resource.rhistate,
      dnsprofilename = resource.dnsprofilename,
      dnsrecordtype = resource.dnsrecordtype,
      persistenceid = resource.persistenceid,
      domainname = resource.domainname,
      ttl = resource.ttl,
      backupip = resource.backupip,
      cookiedomain = resource.cookiedomain,
      cookietimeout = resource.cookietimeout,
      sitedomainttl = resource.sitedomainttl
    }.update_resource(client);

    public static base_responses update(nitro_service client, csvserver[] resources)
    {
      base_responses baseResponses = (base_responses) null;
      if (resources != null && resources.Length > 0)
      {
        csvserver[] csvserverArray = new csvserver[resources.Length];
        for (int index = 0; index < resources.Length; ++index)
        {
          csvserverArray[index] = new csvserver();
          csvserverArray[index].name = resources[index].name;
          csvserverArray[index].ipv46 = resources[index].ipv46;
          csvserverArray[index].ippattern = resources[index].ippattern;
          csvserverArray[index].ipmask = resources[index].ipmask;
          csvserverArray[index].stateupdate = resources[index].stateupdate;
          csvserverArray[index].precedence = resources[index].precedence;
          csvserverArray[index].casesensitive = resources[index].casesensitive;
          csvserverArray[index].backupvserver = resources[index].backupvserver;
          csvserverArray[index].redirecturl = resources[index].redirecturl;
          csvserverArray[index].cacheable = resources[index].cacheable;
          csvserverArray[index].clttimeout = resources[index].clttimeout;
          csvserverArray[index].somethod = resources[index].somethod;
          csvserverArray[index].sopersistence = resources[index].sopersistence;
          csvserverArray[index].sopersistencetimeout = resources[index].sopersistencetimeout;
          csvserverArray[index].sothreshold = resources[index].sothreshold;
          csvserverArray[index].sobackupaction = resources[index].sobackupaction;
          csvserverArray[index].redirectportrewrite = resources[index].redirectportrewrite;
          csvserverArray[index].downstateflush = resources[index].downstateflush;
          csvserverArray[index].disableprimaryondown = resources[index].disableprimaryondown;
          csvserverArray[index].insertvserveripport = resources[index].insertvserveripport;
          csvserverArray[index].vipheader = resources[index].vipheader;
          csvserverArray[index].rtspnat = resources[index].rtspnat;
          csvserverArray[index].authenticationhost = resources[index].authenticationhost;
          csvserverArray[index].authentication = resources[index].authentication;
          csvserverArray[index].listenpolicy = resources[index].listenpolicy;
          csvserverArray[index].listenpriority = resources[index].listenpriority;
          csvserverArray[index].authn401 = resources[index].authn401;
          csvserverArray[index].authnvsname = resources[index].authnvsname;
          csvserverArray[index].push = resources[index].push;
          csvserverArray[index].pushvserver = resources[index].pushvserver;
          csvserverArray[index].pushlabel = resources[index].pushlabel;
          csvserverArray[index].pushmulticlients = resources[index].pushmulticlients;
          csvserverArray[index].tcpprofilename = resources[index].tcpprofilename;
          csvserverArray[index].httpprofilename = resources[index].httpprofilename;
          csvserverArray[index].dbprofilename = resources[index].dbprofilename;
          csvserverArray[index].comment = resources[index].comment;
          csvserverArray[index].l2conn = resources[index].l2conn;
          csvserverArray[index].mssqlserverversion = resources[index].mssqlserverversion;
          csvserverArray[index].mysqlprotocolversion = resources[index].mysqlprotocolversion;
          csvserverArray[index].oracleserverversion = resources[index].oracleserverversion;
          csvserverArray[index].mysqlserverversion = resources[index].mysqlserverversion;
          csvserverArray[index].mysqlcharacterset = resources[index].mysqlcharacterset;
          csvserverArray[index].mysqlservercapabilities = resources[index].mysqlservercapabilities;
          csvserverArray[index].appflowlog = resources[index].appflowlog;
          csvserverArray[index].netprofile = resources[index].netprofile;
          csvserverArray[index].authnprofile = resources[index].authnprofile;
          csvserverArray[index].icmpvsrresponse = resources[index].icmpvsrresponse;
          csvserverArray[index].rhistate = resources[index].rhistate;
          csvserverArray[index].dnsprofilename = resources[index].dnsprofilename;
          csvserverArray[index].dnsrecordtype = resources[index].dnsrecordtype;
          csvserverArray[index].persistenceid = resources[index].persistenceid;
          csvserverArray[index].domainname = resources[index].domainname;
          csvserverArray[index].ttl = resources[index].ttl;
          csvserverArray[index].backupip = resources[index].backupip;
          csvserverArray[index].cookiedomain = resources[index].cookiedomain;
          csvserverArray[index].cookietimeout = resources[index].cookietimeout;
          csvserverArray[index].sitedomainttl = resources[index].sitedomainttl;
        }
        baseResponses = base_resource.update_bulk_request(client, (base_resource[]) csvserverArray);
      }
      return baseResponses;
    }

    public static base_response unset(
      nitro_service client,
      string name,
      string[] args)
    {
      return new csvserver() { name = name }.unset_resource(client, args);
    }

    public static base_response unset(
      nitro_service client,
      csvserver resource,
      string[] args)
    {
      return new csvserver() { name = resource.name }.unset_resource(client, args);
    }

    public static base_responses unset(
      nitro_service client,
      string[] name,
      string[] args)
    {
      base_responses baseResponses = (base_responses) null;
      if (name != null && name.Length > 0)
      {
        csvserver[] csvserverArray = new csvserver[name.Length];
        for (int index = 0; index < name.Length; ++index)
        {
          csvserverArray[index] = new csvserver();
          csvserverArray[index].name = name[index];
        }
        baseResponses = base_resource.unset_bulk_request(client, (base_resource[]) csvserverArray, args);
      }
      return baseResponses;
    }

    public static base_responses unset(
      nitro_service client,
      csvserver[] resources,
      string[] args)
    {
      base_responses baseResponses = (base_responses) null;
      if (resources != null && resources.Length > 0)
      {
        csvserver[] csvserverArray = new csvserver[resources.Length];
        for (int index = 0; index < resources.Length; ++index)
        {
          csvserverArray[index] = new csvserver();
          csvserverArray[index].name = resources[index].name;
        }
        baseResponses = base_resource.unset_bulk_request(client, (base_resource[]) csvserverArray, args);
      }
      return baseResponses;
    }

    public static base_response enable(nitro_service client, string name) => new csvserver()
    {
      name = name
    }.perform_operation_byaction(client, nameof (enable));

    public static base_response enable(nitro_service client, csvserver resource) => new csvserver()
    {
      name = resource.name
    }.perform_operation_byaction(client, nameof (enable));

    public static base_responses enable(nitro_service client, string[] name)
    {
      base_responses baseResponses = (base_responses) null;
      if (name != null && name.Length > 0)
      {
        csvserver[] csvserverArray = new csvserver[name.Length];
        for (int index = 0; index < name.Length; ++index)
        {
          csvserverArray[index] = new csvserver();
          csvserverArray[index].name = name[index];
        }
        baseResponses = base_resource.perform_operation_bulk_request(client, (base_resource[]) csvserverArray, nameof (enable));
      }
      return baseResponses;
    }

    public static base_responses enable(nitro_service client, csvserver[] resources)
    {
      base_responses baseResponses = (base_responses) null;
      if (resources != null && resources.Length > 0)
      {
        csvserver[] csvserverArray = new csvserver[resources.Length];
        for (int index = 0; index < resources.Length; ++index)
        {
          csvserverArray[index] = new csvserver();
          csvserverArray[index].name = resources[index].name;
        }
        baseResponses = base_resource.perform_operation_bulk_request(client, (base_resource[]) csvserverArray, nameof (enable));
      }
      return baseResponses;
    }

    public static base_response disable(nitro_service client, string name) => new csvserver()
    {
      name = name
    }.perform_operation_byaction(client, nameof (disable));

    public static base_response disable(nitro_service client, csvserver resource) => new csvserver()
    {
      name = resource.name
    }.perform_operation_byaction(client, nameof (disable));

    public static base_responses disable(nitro_service client, string[] name)
    {
      base_responses baseResponses = (base_responses) null;
      if (name != null && name.Length > 0)
      {
        csvserver[] csvserverArray = new csvserver[name.Length];
        for (int index = 0; index < name.Length; ++index)
        {
          csvserverArray[index] = new csvserver();
          csvserverArray[index].name = name[index];
        }
        baseResponses = base_resource.perform_operation_bulk_request(client, (base_resource[]) csvserverArray, nameof (disable));
      }
      return baseResponses;
    }

    public static base_responses disable(nitro_service client, csvserver[] resources)
    {
      base_responses baseResponses = (base_responses) null;
      if (resources != null && resources.Length > 0)
      {
        csvserver[] csvserverArray = new csvserver[resources.Length];
        for (int index = 0; index < resources.Length; ++index)
        {
          csvserverArray[index] = new csvserver();
          csvserverArray[index].name = resources[index].name;
        }
        baseResponses = base_resource.perform_operation_bulk_request(client, (base_resource[]) csvserverArray, nameof (disable));
      }
      return baseResponses;
    }

    public static base_response rename(
      nitro_service client,
      csvserver resource,
      string new_name)
    {
      return new csvserver()
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
      return new csvserver()
      {
        name = name,
        newname = new_name
      }.rename_resource(client);
    }

    public static csvserver[] get(nitro_service service) => (csvserver[]) new csvserver().get_resources(service, (options) null);

    public static csvserver[] get(nitro_service service, options option) => (csvserver[]) new csvserver().get_resources(service, option);

    public static csvserver get(nitro_service service, string name) => (csvserver) new csvserver()
    {
      name = name
    }.get_resource(service);

    public static csvserver[] get(nitro_service service, string[] name)
    {
      if (name == null || name.Length <= 0)
        return (csvserver[]) null;
      csvserver[] csvserverArray1 = new csvserver[name.Length];
      csvserver[] csvserverArray2 = new csvserver[name.Length];
      for (int index = 0; index < name.Length; ++index)
      {
        csvserverArray2[index] = new csvserver();
        csvserverArray2[index].name = name[index];
        csvserverArray1[index] = (csvserver) csvserverArray2[index].get_resource(service);
      }
      return csvserverArray1;
    }

    public static csvserver[] get_filtered(nitro_service service, string filter)
    {
      csvserver csvserver = new csvserver();
      options option = new options();
      option.set_filter(filter);
      return (csvserver[]) csvserver.getfiltered(service, option);
    }

    public static csvserver[] get_filtered(nitro_service service, filtervalue[] filter)
    {
      csvserver csvserver = new csvserver();
      options option = new options();
      option.set_filter(filter);
      return (csvserver[]) csvserver.getfiltered(service, option);
    }

    public static uint count(nitro_service service)
    {
      csvserver csvserver = new csvserver();
      options option = new options();
      option.set_count(true);
      csvserver[] resources = (csvserver[]) csvserver.get_resources(service, option);
      return resources != null && resources.Length > 0 ? resources[0].__count.Value : 0U;
    }

    public static uint count_filtered(nitro_service service, string filter)
    {
      csvserver csvserver = new csvserver();
      options option = new options();
      option.set_count(true);
      option.set_filter(filter);
      csvserver[] csvserverArray = (csvserver[]) csvserver.getfiltered(service, option);
      return csvserverArray != null && csvserverArray.Length > 0 ? csvserverArray[0].__count.Value : 0U;
    }

    public static uint count_filtered(nitro_service service, filtervalue[] filter)
    {
      csvserver csvserver = new csvserver();
      options option = new options();
      option.set_count(true);
      option.set_filter(filter);
      csvserver[] csvserverArray = (csvserver[]) csvserver.getfiltered(service, option);
      return csvserverArray != null && csvserverArray.Length > 0 ? csvserverArray[0].__count.Value : 0U;
    }

    private class csvserver_response : base_response
    {
      public csvserver[] csvserver = (csvserver[]) null;
    }

    public static class scEnum
    {
      public const string ON = "ON";
      public const string OFF = "OFF";
    }

    public static class oracleserverversionEnum
    {
      public const string _10G = "10G";
      public const string _11G = "11G";
    }

    public static class rhistateEnum
    {
      public const string PASSIVE = "PASSIVE";
      public const string ACTIVE = "ACTIVE";
    }

    public static class stateupdateEnum
    {
      public const string ENABLED = "ENABLED";
      public const string DISABLED = "DISABLED";
    }

    public static class authenticationEnum
    {
      public const string ON = "ON";
      public const string OFF = "OFF";
    }

    public static class redirectportrewriteEnum
    {
      public const string ENABLED = "ENABLED";
      public const string DISABLED = "DISABLED";
    }

    public static class stateEnum
    {
      public const string ENABLED = "ENABLED";
      public const string DISABLED = "DISABLED";
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

    public static class dnsrecordtypeEnum
    {
      public const string A = "A";
      public const string AAAA = "AAAA";
      public const string CNAME = "CNAME";
      public const string NAPTR = "NAPTR";
    }

    public static class targettypeEnum
    {
      public const string GSLB = "GSLB";
    }

    public static class servicetypeEnum
    {
      public const string HTTP = "HTTP";
      public const string SSL = "SSL";
      public const string TCP = "TCP";
      public const string FTP = "FTP";
      public const string RTSP = "RTSP";
      public const string SSL_TCP = "SSL_TCP";
      public const string UDP = "UDP";
      public const string DNS = "DNS";
      public const string SIP_UDP = "SIP_UDP";
      public const string SIP_TCP = "SIP_TCP";
      public const string SIP_SSL = "SIP_SSL";
      public const string ANY = "ANY";
      public const string RADIUS = "RADIUS";
      public const string RDP = "RDP";
      public const string MYSQL = "MYSQL";
      public const string MSSQL = "MSSQL";
      public const string DIAMETER = "DIAMETER";
      public const string SSL_DIAMETER = "SSL_DIAMETER";
      public const string DNS_TCP = "DNS_TCP";
      public const string ORACLE = "ORACLE";
      public const string SMPP = "SMPP";
    }

    public static class icmpvsrresponseEnum
    {
      public const string PASSIVE = "PASSIVE";
      public const string ACTIVE = "ACTIVE";
    }

    public static class casesensitiveEnum
    {
      public const string ON = "ON";
      public const string OFF = "OFF";
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

    public static class sobackupactionEnum
    {
      public const string DROP = "DROP";
      public const string ACCEPT = "ACCEPT";
      public const string REDIRECT = "REDIRECT";
    }

    public static class gt2gbEnum
    {
      public const string ENABLED = "ENABLED";
      public const string DISABLED = "DISABLED";
    }

    public static class pushEnum
    {
      public const string ENABLED = "ENABLED";
      public const string DISABLED = "DISABLED";
    }

    public static class typeEnum
    {
      public const string CONTENT = "CONTENT";
      public const string ADDRESS = "ADDRESS";
    }

    public static class rtspnatEnum
    {
      public const string ON = "ON";
      public const string OFF = "OFF";
    }

    public static class disableprimaryondownEnum
    {
      public const string ENABLED = "ENABLED";
      public const string DISABLED = "DISABLED";
    }

    public static class authn401Enum
    {
      public const string ON = "ON";
      public const string OFF = "OFF";
    }

    public static class cacheableEnum
    {
      public const string YES = "YES";
      public const string NO = "NO";
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
    }

    public static class sopersistenceEnum
    {
      public const string ENABLED = "ENABLED";
      public const string DISABLED = "DISABLED";
    }

    public static class redirectEnum
    {
      public const string CACHE = "CACHE";
      public const string POLICY = "POLICY";
      public const string ORIGIN = "ORIGIN";
    }

    public static class pushmulticlientsEnum
    {
      public const string YES = "YES";
      public const string NO = "NO";
    }

    public static class labeltypeEnum
    {
      public const string reqvserver = "reqvserver";
      public const string resvserver = "resvserver";
      public const string policylabel = "policylabel";
    }

    public static class appflowlogEnum
    {
      public const string ENABLED = "ENABLED";
      public const string DISABLED = "DISABLED";
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

    public static class insertvserveripportEnum
    {
      public const string OFF = "OFF";
      public const string VIPADDR = "VIPADDR";
      public const string V6TOV4MAPPING = "V6TOV4MAPPING";
    }

    public static class mssqlserverversionEnum
    {
      public const string _70 = "70";
      public const string _2000 = "2000";
      public const string _2000SP1 = "2000SP1";
      public const string _2005 = "2005";
      public const string _2008 = "2008";
      public const string _2008R2 = "2008R2";
      public const string _2012 = "2012";
      public const string _2014 = "2014";
    }
  }
}
