// Decompiled with JetBrains decompiler
// Type: com.citrix.netscaler.nitro.resource.config.lb.lbvserver
// Assembly: nitro, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 6CF5DDEF-E052-4F9D-953F-6644F8378A66


using com.citrix.netscaler.nitro.exception;
using com.citrix.netscaler.nitro.resource.Base;
using com.citrix.netscaler.nitro.service;
using com.citrix.netscaler.nitro.util;

namespace com.citrix.netscaler.nitro.resource.config.lb
{
  public class lbvserver : base_resource
  {
    private string nameField = (string) null;
    private string servicetypeField = (string) null;
    private string ipv46Field = (string) null;
    private string ippatternField = (string) null;
    private string ipmaskField = (string) null;
    private ushort? portField = new ushort?();
    private uint? rangeField = new uint?();
    private string persistencetypeField = (string) null;
    private uint? timeoutField = new uint?();
    private string persistencebackupField = (string) null;
    private uint? backuppersistencetimeoutField = new uint?();
    private string lbmethodField = (string) null;
    private uint? hashlengthField = new uint?();
    private string netmaskField = (string) null;
    private uint? v6netmasklenField = new uint?();
    private string backuplbmethodField = (string) null;
    private string cookienameField = (string) null;
    private string ruleField = (string) null;
    private string listenpolicyField = (string) null;
    private uint? listenpriorityField = new uint?();
    private string resruleField = (string) null;
    private string persistmaskField = (string) null;
    private uint? v6persistmasklenField = new uint?();
    private string pqField = (string) null;
    private string scField = (string) null;
    private string rtspnatField = (string) null;
    private string mField = (string) null;
    private uint? tosidField = new uint?();
    private uint? datalengthField = new uint?();
    private uint? dataoffsetField = new uint?();
    private string sessionlessField = (string) null;
    private string stateField = (string) null;
    private string connfailoverField = (string) null;
    private string redirurlField = (string) null;
    private string cacheableField = (string) null;
    private long? clttimeoutField = new long?();
    private string somethodField = (string) null;
    private string sopersistenceField = (string) null;
    private uint? sopersistencetimeoutField = new uint?();
    private uint? healththresholdField = new uint?();
    private uint? sothresholdField = new uint?();
    private string sobackupactionField = (string) null;
    private string redirectportrewriteField = (string) null;
    private string downstateflushField = (string) null;
    private string backupvserverField = (string) null;
    private string disableprimaryondownField = (string) null;
    private string insertvserveripportField = (string) null;
    private string vipheaderField = (string) null;
    private string authenticationhostField = (string) null;
    private string authenticationField = (string) null;
    private string authn401Field = (string) null;
    private string authnvsnameField = (string) null;
    private string pushField = (string) null;
    private string pushvserverField = (string) null;
    private string pushlabelField = (string) null;
    private string pushmulticlientsField = (string) null;
    private string tcpprofilenameField = (string) null;
    private string httpprofilenameField = (string) null;
    private string dbprofilenameField = (string) null;
    private string commentField = (string) null;
    private string l2connField = (string) null;
    private string oracleserverversionField = (string) null;
    private string mssqlserverversionField = (string) null;
    private uint? mysqlprotocolversionField = new uint?();
    private string mysqlserverversionField = (string) null;
    private uint? mysqlcharactersetField = new uint?();
    private uint? mysqlservercapabilitiesField = new uint?();
    private string appflowlogField = (string) null;
    private string netprofileField = (string) null;
    private string icmpvsrresponseField = (string) null;
    private string rhistateField = (string) null;
    private uint? newservicerequestField = new uint?();
    private string newservicerequestunitField = (string) null;
    private uint? newservicerequestincrementintervalField = new uint?();
    private uint? minautoscalemembersField = new uint?();
    private uint? maxautoscalemembersField = new uint?();
    private uint?[] persistavpnoField = (uint?[]) null;
    private string skippersistencyField = (string) null;
    private uint? tdField = new uint?();
    private string authnprofileField = (string) null;
    private string macmoderetainvlanField = (string) null;
    private string dbslbField = (string) null;
    private string dns64Field = (string) null;
    private string bypassaaaaField = (string) null;
    private string recursionavailableField = (string) null;
    private string processlocalField = (string) null;
    private string dnsprofilenameField = (string) null;
    private uint? weightField = new uint?();
    private string servicenameField = (string) null;
    private bool? redirurlflagsField = new bool?();
    private string newnameField = (string) null;
    private string valueField = (string) null;
    private string ipmappingField = (string) null;
    private string ngnameField = (string) null;
    private string typeField = (string) null;
    private string curstateField = (string) null;
    private string effectivestateField = (string) null;
    private int? statusField = new int?();
    private int? lbrrreasonField = new int?();
    private string redirectField = (string) null;
    private string precedenceField = (string) null;
    private string homepageField = (string) null;
    private string dnsvservernameField = (string) null;
    private string domainField = (string) null;
    private string policynameField = (string) null;
    private string cachevserverField = (string) null;
    private uint? healthField = new uint?();
    private string gotopriorityexpressionField = (string) null;
    private uint? ruletypeField = new uint?();
    private string groupnameField = (string) null;
    private string cookiedomainField = (string) null;
    private string mapField = (string) null;
    private string gt2gbField = (string) null;
    private string consolidatedlconnField = (string) null;
    private string consolidatedlconngblField = (string) null;
    private int? thresholdvalueField = new int?();
    private string bindpointField = (string) null;
    private bool? invokeField = new bool?();
    private string labeltypeField = (string) null;
    private string labelnameField = (string) null;
    private int? versionField = new int?();
    private uint? totalservicesField = new uint?();
    private uint? activeservicesField = new uint?();
    private string statechangetimesecField = (string) null;
    private uint? statechangetimesecondsField = new uint?();
    private uint? statechangetimemsecField = new uint?();
    private uint? tickssincelaststatechangeField = new uint?();
    private bool? isgslbField = new bool?();
    private uint? vsvrdynconnsothresholdField = new uint?();
    private string backupvserverstatusField = (string) null;
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

    public string persistencetype
    {
      get => this.persistencetypeField;
      set => this.persistencetypeField = value;
    }

    public uint? timeout
    {
      get => this.timeoutField;
      set => this.timeoutField = value;
    }

    public string persistencebackup
    {
      get => this.persistencebackupField;
      set => this.persistencebackupField = value;
    }

    public uint? backuppersistencetimeout
    {
      get => this.backuppersistencetimeoutField;
      set => this.backuppersistencetimeoutField = value;
    }

    public string lbmethod
    {
      get => this.lbmethodField;
      set => this.lbmethodField = value;
    }

    public uint? hashlength
    {
      get => this.hashlengthField;
      set => this.hashlengthField = value;
    }

    public string netmask
    {
      get => this.netmaskField;
      set => this.netmaskField = value;
    }

    public uint? v6netmasklen
    {
      get => this.v6netmasklenField;
      set => this.v6netmasklenField = value;
    }

    public string backuplbmethod
    {
      get => this.backuplbmethodField;
      set => this.backuplbmethodField = value;
    }

    public string cookiename
    {
      get => this.cookienameField;
      set => this.cookienameField = value;
    }

    public string rule
    {
      get => this.ruleField;
      set => this.ruleField = value;
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

    public string resrule
    {
      get => this.resruleField;
      set => this.resruleField = value;
    }

    public string persistmask
    {
      get => this.persistmaskField;
      set => this.persistmaskField = value;
    }

    public uint? v6persistmasklen
    {
      get => this.v6persistmasklenField;
      set => this.v6persistmasklenField = value;
    }

    public string pq
    {
      get => this.pqField;
      set => this.pqField = value;
    }

    public string sc
    {
      get => this.scField;
      set => this.scField = value;
    }

    public string rtspnat
    {
      get => this.rtspnatField;
      set => this.rtspnatField = value;
    }

    public string m
    {
      get => this.mField;
      set => this.mField = value;
    }

    public uint? tosid
    {
      get => this.tosidField;
      set => this.tosidField = value;
    }

    public uint? datalength
    {
      get => this.datalengthField;
      set => this.datalengthField = value;
    }

    public uint? dataoffset
    {
      get => this.dataoffsetField;
      set => this.dataoffsetField = value;
    }

    public string sessionless
    {
      get => this.sessionlessField;
      set => this.sessionlessField = value;
    }

    public string state
    {
      get => this.stateField;
      set => this.stateField = value;
    }

    public string connfailover
    {
      get => this.connfailoverField;
      set => this.connfailoverField = value;
    }

    public string redirurl
    {
      get => this.redirurlField;
      set => this.redirurlField = value;
    }

    public string cacheable
    {
      get => this.cacheableField;
      set => this.cacheableField = value;
    }

    public long? clttimeout
    {
      get => this.clttimeoutField;
      set => this.clttimeoutField = value;
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

    public uint? healththreshold
    {
      get => this.healththresholdField;
      set => this.healththresholdField = value;
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

    public string comment
    {
      get => this.commentField;
      set => this.commentField = value;
    }

    public string l2conn
    {
      get => this.l2connField;
      set => this.l2connField = value;
    }

    public string oracleserverversion
    {
      get => this.oracleserverversionField;
      set => this.oracleserverversionField = value;
    }

    public string mssqlserverversion
    {
      get => this.mssqlserverversionField;
      set => this.mssqlserverversionField = value;
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

    public uint? newservicerequest
    {
      get => this.newservicerequestField;
      set => this.newservicerequestField = value;
    }

    public string newservicerequestunit
    {
      get => this.newservicerequestunitField;
      set => this.newservicerequestunitField = value;
    }

    public uint? newservicerequestincrementinterval
    {
      get => this.newservicerequestincrementintervalField;
      set => this.newservicerequestincrementintervalField = value;
    }

    public uint? minautoscalemembers
    {
      get => this.minautoscalemembersField;
      set => this.minautoscalemembersField = value;
    }

    public uint? maxautoscalemembers
    {
      get => this.maxautoscalemembersField;
      set => this.maxautoscalemembersField = value;
    }

    public uint?[] persistavpno
    {
      get => this.persistavpnoField;
      set => this.persistavpnoField = value;
    }

    public string skippersistency
    {
      get => this.skippersistencyField;
      set => this.skippersistencyField = value;
    }

    public uint? td
    {
      get => this.tdField;
      set => this.tdField = value;
    }

    public string authnprofile
    {
      get => this.authnprofileField;
      set => this.authnprofileField = value;
    }

    public string macmoderetainvlan
    {
      get => this.macmoderetainvlanField;
      set => this.macmoderetainvlanField = value;
    }

    public string dbslb
    {
      get => this.dbslbField;
      set => this.dbslbField = value;
    }

    public string dns64
    {
      get => this.dns64Field;
      set => this.dns64Field = value;
    }

    public string bypassaaaa
    {
      get => this.bypassaaaaField;
      set => this.bypassaaaaField = value;
    }

    public string recursionavailable
    {
      get => this.recursionavailableField;
      set => this.recursionavailableField = value;
    }

    public string processlocal
    {
      get => this.processlocalField;
      set => this.processlocalField = value;
    }

    public string dnsprofilename
    {
      get => this.dnsprofilenameField;
      set => this.dnsprofilenameField = value;
    }

    public uint? weight
    {
      get => this.weightField;
      set => this.weightField = value;
    }

    public string servicename
    {
      get => this.servicenameField;
      set => this.servicenameField = value;
    }

    public bool? redirurlflags
    {
      get => this.redirurlflagsField;
      set => this.redirurlflagsField = value;
    }

    public string newname
    {
      get => this.newnameField;
      set => this.newnameField = value;
    }

    public string value
    {
      get => this.valueField;
      private set => this.valueField = value;
    }

    public string ipmapping
    {
      get => this.ipmappingField;
      private set => this.ipmappingField = value;
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

    public string effectivestate
    {
      get => this.effectivestateField;
      private set => this.effectivestateField = value;
    }

    public int? status
    {
      get => this.statusField;
      private set => this.statusField = value;
    }

    public int? lbrrreason
    {
      get => this.lbrrreasonField;
      private set => this.lbrrreasonField = value;
    }

    public string redirect
    {
      get => this.redirectField;
      private set => this.redirectField = value;
    }

    public string precedence
    {
      get => this.precedenceField;
      private set => this.precedenceField = value;
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

    public string cachevserver
    {
      get => this.cachevserverField;
      private set => this.cachevserverField = value;
    }

    public uint? health
    {
      get => this.healthField;
      private set => this.healthField = value;
    }

    public string gotopriorityexpression
    {
      get => this.gotopriorityexpressionField;
      private set => this.gotopriorityexpressionField = value;
    }

    public uint? ruletype
    {
      get => this.ruletypeField;
      private set => this.ruletypeField = value;
    }

    public string groupname
    {
      get => this.groupnameField;
      private set => this.groupnameField = value;
    }

    public string cookiedomain
    {
      get => this.cookiedomainField;
      private set => this.cookiedomainField = value;
    }

    public string map
    {
      get => this.mapField;
      private set => this.mapField = value;
    }

    public string gt2gb
    {
      get => this.gt2gbField;
      private set => this.gt2gbField = value;
    }

    public string consolidatedlconn
    {
      get => this.consolidatedlconnField;
      private set => this.consolidatedlconnField = value;
    }

    public string consolidatedlconngbl
    {
      get => this.consolidatedlconngblField;
      private set => this.consolidatedlconngblField = value;
    }

    public int? thresholdvalue
    {
      get => this.thresholdvalueField;
      private set => this.thresholdvalueField = value;
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

    public int? version
    {
      get => this.versionField;
      private set => this.versionField = value;
    }

    public uint? totalservices
    {
      get => this.totalservicesField;
      private set => this.totalservicesField = value;
    }

    public uint? activeservices
    {
      get => this.activeservicesField;
      private set => this.activeservicesField = value;
    }

    public string statechangetimesec
    {
      get => this.statechangetimesecField;
      private set => this.statechangetimesecField = value;
    }

    public uint? statechangetimeseconds
    {
      get => this.statechangetimesecondsField;
      private set => this.statechangetimesecondsField = value;
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

    public bool? isgslb
    {
      get => this.isgslbField;
      private set => this.isgslbField = value;
    }

    public uint? vsvrdynconnsothreshold
    {
      get => this.vsvrdynconnsothresholdField;
      private set => this.vsvrdynconnsothresholdField = value;
    }

    public string backupvserverstatus
    {
      get => this.backupvserverstatusField;
      private set => this.backupvserverstatusField = value;
    }

    internal override base_resource[] get_nitro_response(
      nitro_service service,
      string response)
    {
      lbvserver.lbvserver_response lbvserverResponse = new lbvserver.lbvserver_response();
      lbvserver.lbvserver_response resource = (lbvserver.lbvserver_response) service.get_payload_formatter().string_to_resource(lbvserverResponse.GetType(), response);
      if (resource.errorcode != 0)
      {
        if (resource.errorcode == 444)
          service.clear_session();
        if (resource.severity == null)
          throw new nitro_exception(resource.message, resource.errorcode);
        if (resource.severity.Equals("ERROR"))
          throw new nitro_exception(resource.message, resource.errorcode);
      }
      return (base_resource[]) resource.lbvserver;
    }

    internal override string get_object_name() => this.name;

    public static base_response add(nitro_service client, lbvserver resource) => new lbvserver()
    {
      name = resource.name,
      servicetype = resource.servicetype,
      ipv46 = resource.ipv46,
      ippattern = resource.ippattern,
      ipmask = resource.ipmask,
      port = resource.port,
      range = resource.range,
      persistencetype = resource.persistencetype,
      timeout = resource.timeout,
      persistencebackup = resource.persistencebackup,
      backuppersistencetimeout = resource.backuppersistencetimeout,
      lbmethod = resource.lbmethod,
      hashlength = resource.hashlength,
      netmask = resource.netmask,
      v6netmasklen = resource.v6netmasklen,
      backuplbmethod = resource.backuplbmethod,
      cookiename = resource.cookiename,
      rule = resource.rule,
      listenpolicy = resource.listenpolicy,
      listenpriority = resource.listenpriority,
      resrule = resource.resrule,
      persistmask = resource.persistmask,
      v6persistmasklen = resource.v6persistmasklen,
      pq = resource.pq,
      sc = resource.sc,
      rtspnat = resource.rtspnat,
      m = resource.m,
      tosid = resource.tosid,
      datalength = resource.datalength,
      dataoffset = resource.dataoffset,
      sessionless = resource.sessionless,
      state = resource.state,
      connfailover = resource.connfailover,
      redirurl = resource.redirurl,
      cacheable = resource.cacheable,
      clttimeout = resource.clttimeout,
      somethod = resource.somethod,
      sopersistence = resource.sopersistence,
      sopersistencetimeout = resource.sopersistencetimeout,
      healththreshold = resource.healththreshold,
      sothreshold = resource.sothreshold,
      sobackupaction = resource.sobackupaction,
      redirectportrewrite = resource.redirectportrewrite,
      downstateflush = resource.downstateflush,
      backupvserver = resource.backupvserver,
      disableprimaryondown = resource.disableprimaryondown,
      insertvserveripport = resource.insertvserveripport,
      vipheader = resource.vipheader,
      authenticationhost = resource.authenticationhost,
      authentication = resource.authentication,
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
      oracleserverversion = resource.oracleserverversion,
      mssqlserverversion = resource.mssqlserverversion,
      mysqlprotocolversion = resource.mysqlprotocolversion,
      mysqlserverversion = resource.mysqlserverversion,
      mysqlcharacterset = resource.mysqlcharacterset,
      mysqlservercapabilities = resource.mysqlservercapabilities,
      appflowlog = resource.appflowlog,
      netprofile = resource.netprofile,
      icmpvsrresponse = resource.icmpvsrresponse,
      rhistate = resource.rhistate,
      newservicerequest = resource.newservicerequest,
      newservicerequestunit = resource.newservicerequestunit,
      newservicerequestincrementinterval = resource.newservicerequestincrementinterval,
      minautoscalemembers = resource.minautoscalemembers,
      maxautoscalemembers = resource.maxautoscalemembers,
      persistavpno = resource.persistavpno,
      skippersistency = resource.skippersistency,
      td = resource.td,
      authnprofile = resource.authnprofile,
      macmoderetainvlan = resource.macmoderetainvlan,
      dbslb = resource.dbslb,
      dns64 = resource.dns64,
      bypassaaaa = resource.bypassaaaa,
      recursionavailable = resource.recursionavailable,
      processlocal = resource.processlocal,
      dnsprofilename = resource.dnsprofilename
    }.add_resource(client);

    public static base_responses add(nitro_service client, lbvserver[] resources)
    {
      base_responses baseResponses = (base_responses) null;
      if (resources != null && resources.Length > 0)
      {
        lbvserver[] lbvserverArray = new lbvserver[resources.Length];
        for (int index = 0; index < resources.Length; ++index)
        {
          lbvserverArray[index] = new lbvserver();
          lbvserverArray[index].name = resources[index].name;
          lbvserverArray[index].servicetype = resources[index].servicetype;
          lbvserverArray[index].ipv46 = resources[index].ipv46;
          lbvserverArray[index].ippattern = resources[index].ippattern;
          lbvserverArray[index].ipmask = resources[index].ipmask;
          lbvserverArray[index].port = resources[index].port;
          lbvserverArray[index].range = resources[index].range;
          lbvserverArray[index].persistencetype = resources[index].persistencetype;
          lbvserverArray[index].timeout = resources[index].timeout;
          lbvserverArray[index].persistencebackup = resources[index].persistencebackup;
          lbvserverArray[index].backuppersistencetimeout = resources[index].backuppersistencetimeout;
          lbvserverArray[index].lbmethod = resources[index].lbmethod;
          lbvserverArray[index].hashlength = resources[index].hashlength;
          lbvserverArray[index].netmask = resources[index].netmask;
          lbvserverArray[index].v6netmasklen = resources[index].v6netmasklen;
          lbvserverArray[index].backuplbmethod = resources[index].backuplbmethod;
          lbvserverArray[index].cookiename = resources[index].cookiename;
          lbvserverArray[index].rule = resources[index].rule;
          lbvserverArray[index].listenpolicy = resources[index].listenpolicy;
          lbvserverArray[index].listenpriority = resources[index].listenpriority;
          lbvserverArray[index].resrule = resources[index].resrule;
          lbvserverArray[index].persistmask = resources[index].persistmask;
          lbvserverArray[index].v6persistmasklen = resources[index].v6persistmasklen;
          lbvserverArray[index].pq = resources[index].pq;
          lbvserverArray[index].sc = resources[index].sc;
          lbvserverArray[index].rtspnat = resources[index].rtspnat;
          lbvserverArray[index].m = resources[index].m;
          lbvserverArray[index].tosid = resources[index].tosid;
          lbvserverArray[index].datalength = resources[index].datalength;
          lbvserverArray[index].dataoffset = resources[index].dataoffset;
          lbvserverArray[index].sessionless = resources[index].sessionless;
          lbvserverArray[index].state = resources[index].state;
          lbvserverArray[index].connfailover = resources[index].connfailover;
          lbvserverArray[index].redirurl = resources[index].redirurl;
          lbvserverArray[index].cacheable = resources[index].cacheable;
          lbvserverArray[index].clttimeout = resources[index].clttimeout;
          lbvserverArray[index].somethod = resources[index].somethod;
          lbvserverArray[index].sopersistence = resources[index].sopersistence;
          lbvserverArray[index].sopersistencetimeout = resources[index].sopersistencetimeout;
          lbvserverArray[index].healththreshold = resources[index].healththreshold;
          lbvserverArray[index].sothreshold = resources[index].sothreshold;
          lbvserverArray[index].sobackupaction = resources[index].sobackupaction;
          lbvserverArray[index].redirectportrewrite = resources[index].redirectportrewrite;
          lbvserverArray[index].downstateflush = resources[index].downstateflush;
          lbvserverArray[index].backupvserver = resources[index].backupvserver;
          lbvserverArray[index].disableprimaryondown = resources[index].disableprimaryondown;
          lbvserverArray[index].insertvserveripport = resources[index].insertvserveripport;
          lbvserverArray[index].vipheader = resources[index].vipheader;
          lbvserverArray[index].authenticationhost = resources[index].authenticationhost;
          lbvserverArray[index].authentication = resources[index].authentication;
          lbvserverArray[index].authn401 = resources[index].authn401;
          lbvserverArray[index].authnvsname = resources[index].authnvsname;
          lbvserverArray[index].push = resources[index].push;
          lbvserverArray[index].pushvserver = resources[index].pushvserver;
          lbvserverArray[index].pushlabel = resources[index].pushlabel;
          lbvserverArray[index].pushmulticlients = resources[index].pushmulticlients;
          lbvserverArray[index].tcpprofilename = resources[index].tcpprofilename;
          lbvserverArray[index].httpprofilename = resources[index].httpprofilename;
          lbvserverArray[index].dbprofilename = resources[index].dbprofilename;
          lbvserverArray[index].comment = resources[index].comment;
          lbvserverArray[index].l2conn = resources[index].l2conn;
          lbvserverArray[index].oracleserverversion = resources[index].oracleserverversion;
          lbvserverArray[index].mssqlserverversion = resources[index].mssqlserverversion;
          lbvserverArray[index].mysqlprotocolversion = resources[index].mysqlprotocolversion;
          lbvserverArray[index].mysqlserverversion = resources[index].mysqlserverversion;
          lbvserverArray[index].mysqlcharacterset = resources[index].mysqlcharacterset;
          lbvserverArray[index].mysqlservercapabilities = resources[index].mysqlservercapabilities;
          lbvserverArray[index].appflowlog = resources[index].appflowlog;
          lbvserverArray[index].netprofile = resources[index].netprofile;
          lbvserverArray[index].icmpvsrresponse = resources[index].icmpvsrresponse;
          lbvserverArray[index].rhistate = resources[index].rhistate;
          lbvserverArray[index].newservicerequest = resources[index].newservicerequest;
          lbvserverArray[index].newservicerequestunit = resources[index].newservicerequestunit;
          lbvserverArray[index].newservicerequestincrementinterval = resources[index].newservicerequestincrementinterval;
          lbvserverArray[index].minautoscalemembers = resources[index].minautoscalemembers;
          lbvserverArray[index].maxautoscalemembers = resources[index].maxautoscalemembers;
          lbvserverArray[index].persistavpno = resources[index].persistavpno;
          lbvserverArray[index].skippersistency = resources[index].skippersistency;
          lbvserverArray[index].td = resources[index].td;
          lbvserverArray[index].authnprofile = resources[index].authnprofile;
          lbvserverArray[index].macmoderetainvlan = resources[index].macmoderetainvlan;
          lbvserverArray[index].dbslb = resources[index].dbslb;
          lbvserverArray[index].dns64 = resources[index].dns64;
          lbvserverArray[index].bypassaaaa = resources[index].bypassaaaa;
          lbvserverArray[index].recursionavailable = resources[index].recursionavailable;
          lbvserverArray[index].processlocal = resources[index].processlocal;
          lbvserverArray[index].dnsprofilename = resources[index].dnsprofilename;
        }
        baseResponses = base_resource.add_bulk_request(client, (base_resource[]) lbvserverArray);
      }
      return baseResponses;
    }

    public static base_response delete(nitro_service client, string name) => new lbvserver()
    {
      name = name
    }.delete_resource(client);

    public static base_response delete(nitro_service client, lbvserver resource) => new lbvserver()
    {
      name = resource.name
    }.delete_resource(client);

    public static base_responses delete(nitro_service client, string[] name)
    {
      base_responses baseResponses = (base_responses) null;
      if (name != null && name.Length > 0)
      {
        lbvserver[] lbvserverArray = new lbvserver[name.Length];
        for (int index = 0; index < name.Length; ++index)
        {
          lbvserverArray[index] = new lbvserver();
          lbvserverArray[index].name = name[index];
        }
        baseResponses = base_resource.delete_bulk_request(client, (base_resource[]) lbvserverArray);
      }
      return baseResponses;
    }

    public static base_responses delete(nitro_service client, lbvserver[] resources)
    {
      base_responses baseResponses = (base_responses) null;
      if (resources != null && resources.Length > 0)
      {
        lbvserver[] lbvserverArray = new lbvserver[resources.Length];
        for (int index = 0; index < resources.Length; ++index)
        {
          lbvserverArray[index] = new lbvserver();
          lbvserverArray[index].name = resources[index].name;
        }
        baseResponses = base_resource.delete_bulk_request(client, (base_resource[]) lbvserverArray);
      }
      return baseResponses;
    }

    public static base_response update(nitro_service client, lbvserver resource) => new lbvserver()
    {
      name = resource.name,
      ipv46 = resource.ipv46,
      ippattern = resource.ippattern,
      ipmask = resource.ipmask,
      weight = resource.weight,
      servicename = resource.servicename,
      persistencetype = resource.persistencetype,
      timeout = resource.timeout,
      persistencebackup = resource.persistencebackup,
      backuppersistencetimeout = resource.backuppersistencetimeout,
      lbmethod = resource.lbmethod,
      hashlength = resource.hashlength,
      netmask = resource.netmask,
      v6netmasklen = resource.v6netmasklen,
      backuplbmethod = resource.backuplbmethod,
      rule = resource.rule,
      cookiename = resource.cookiename,
      resrule = resource.resrule,
      persistmask = resource.persistmask,
      v6persistmasklen = resource.v6persistmasklen,
      pq = resource.pq,
      sc = resource.sc,
      rtspnat = resource.rtspnat,
      m = resource.m,
      tosid = resource.tosid,
      datalength = resource.datalength,
      dataoffset = resource.dataoffset,
      sessionless = resource.sessionless,
      connfailover = resource.connfailover,
      backupvserver = resource.backupvserver,
      redirurl = resource.redirurl,
      cacheable = resource.cacheable,
      clttimeout = resource.clttimeout,
      somethod = resource.somethod,
      sothreshold = resource.sothreshold,
      sopersistence = resource.sopersistence,
      sopersistencetimeout = resource.sopersistencetimeout,
      healththreshold = resource.healththreshold,
      sobackupaction = resource.sobackupaction,
      redirectportrewrite = resource.redirectportrewrite,
      downstateflush = resource.downstateflush,
      insertvserveripport = resource.insertvserveripport,
      vipheader = resource.vipheader,
      disableprimaryondown = resource.disableprimaryondown,
      authenticationhost = resource.authenticationhost,
      authentication = resource.authentication,
      authn401 = resource.authn401,
      authnvsname = resource.authnvsname,
      push = resource.push,
      pushvserver = resource.pushvserver,
      pushlabel = resource.pushlabel,
      pushmulticlients = resource.pushmulticlients,
      listenpolicy = resource.listenpolicy,
      listenpriority = resource.listenpriority,
      tcpprofilename = resource.tcpprofilename,
      httpprofilename = resource.httpprofilename,
      dbprofilename = resource.dbprofilename,
      comment = resource.comment,
      l2conn = resource.l2conn,
      oracleserverversion = resource.oracleserverversion,
      mssqlserverversion = resource.mssqlserverversion,
      mysqlprotocolversion = resource.mysqlprotocolversion,
      mysqlserverversion = resource.mysqlserverversion,
      mysqlcharacterset = resource.mysqlcharacterset,
      mysqlservercapabilities = resource.mysqlservercapabilities,
      appflowlog = resource.appflowlog,
      netprofile = resource.netprofile,
      icmpvsrresponse = resource.icmpvsrresponse,
      rhistate = resource.rhistate,
      newservicerequest = resource.newservicerequest,
      newservicerequestunit = resource.newservicerequestunit,
      newservicerequestincrementinterval = resource.newservicerequestincrementinterval,
      minautoscalemembers = resource.minautoscalemembers,
      maxautoscalemembers = resource.maxautoscalemembers,
      persistavpno = resource.persistavpno,
      skippersistency = resource.skippersistency,
      authnprofile = resource.authnprofile,
      macmoderetainvlan = resource.macmoderetainvlan,
      dbslb = resource.dbslb,
      dns64 = resource.dns64,
      bypassaaaa = resource.bypassaaaa,
      recursionavailable = resource.recursionavailable,
      processlocal = resource.processlocal,
      dnsprofilename = resource.dnsprofilename
    }.update_resource(client);

    public static base_responses update(nitro_service client, lbvserver[] resources)
    {
      base_responses baseResponses = (base_responses) null;
      if (resources != null && resources.Length > 0)
      {
        lbvserver[] lbvserverArray = new lbvserver[resources.Length];
        for (int index = 0; index < resources.Length; ++index)
        {
          lbvserverArray[index] = new lbvserver();
          lbvserverArray[index].name = resources[index].name;
          lbvserverArray[index].ipv46 = resources[index].ipv46;
          lbvserverArray[index].ippattern = resources[index].ippattern;
          lbvserverArray[index].ipmask = resources[index].ipmask;
          lbvserverArray[index].weight = resources[index].weight;
          lbvserverArray[index].servicename = resources[index].servicename;
          lbvserverArray[index].persistencetype = resources[index].persistencetype;
          lbvserverArray[index].timeout = resources[index].timeout;
          lbvserverArray[index].persistencebackup = resources[index].persistencebackup;
          lbvserverArray[index].backuppersistencetimeout = resources[index].backuppersistencetimeout;
          lbvserverArray[index].lbmethod = resources[index].lbmethod;
          lbvserverArray[index].hashlength = resources[index].hashlength;
          lbvserverArray[index].netmask = resources[index].netmask;
          lbvserverArray[index].v6netmasklen = resources[index].v6netmasklen;
          lbvserverArray[index].backuplbmethod = resources[index].backuplbmethod;
          lbvserverArray[index].rule = resources[index].rule;
          lbvserverArray[index].cookiename = resources[index].cookiename;
          lbvserverArray[index].resrule = resources[index].resrule;
          lbvserverArray[index].persistmask = resources[index].persistmask;
          lbvserverArray[index].v6persistmasklen = resources[index].v6persistmasklen;
          lbvserverArray[index].pq = resources[index].pq;
          lbvserverArray[index].sc = resources[index].sc;
          lbvserverArray[index].rtspnat = resources[index].rtspnat;
          lbvserverArray[index].m = resources[index].m;
          lbvserverArray[index].tosid = resources[index].tosid;
          lbvserverArray[index].datalength = resources[index].datalength;
          lbvserverArray[index].dataoffset = resources[index].dataoffset;
          lbvserverArray[index].sessionless = resources[index].sessionless;
          lbvserverArray[index].connfailover = resources[index].connfailover;
          lbvserverArray[index].backupvserver = resources[index].backupvserver;
          lbvserverArray[index].redirurl = resources[index].redirurl;
          lbvserverArray[index].cacheable = resources[index].cacheable;
          lbvserverArray[index].clttimeout = resources[index].clttimeout;
          lbvserverArray[index].somethod = resources[index].somethod;
          lbvserverArray[index].sothreshold = resources[index].sothreshold;
          lbvserverArray[index].sopersistence = resources[index].sopersistence;
          lbvserverArray[index].sopersistencetimeout = resources[index].sopersistencetimeout;
          lbvserverArray[index].healththreshold = resources[index].healththreshold;
          lbvserverArray[index].sobackupaction = resources[index].sobackupaction;
          lbvserverArray[index].redirectportrewrite = resources[index].redirectportrewrite;
          lbvserverArray[index].downstateflush = resources[index].downstateflush;
          lbvserverArray[index].insertvserveripport = resources[index].insertvserveripport;
          lbvserverArray[index].vipheader = resources[index].vipheader;
          lbvserverArray[index].disableprimaryondown = resources[index].disableprimaryondown;
          lbvserverArray[index].authenticationhost = resources[index].authenticationhost;
          lbvserverArray[index].authentication = resources[index].authentication;
          lbvserverArray[index].authn401 = resources[index].authn401;
          lbvserverArray[index].authnvsname = resources[index].authnvsname;
          lbvserverArray[index].push = resources[index].push;
          lbvserverArray[index].pushvserver = resources[index].pushvserver;
          lbvserverArray[index].pushlabel = resources[index].pushlabel;
          lbvserverArray[index].pushmulticlients = resources[index].pushmulticlients;
          lbvserverArray[index].listenpolicy = resources[index].listenpolicy;
          lbvserverArray[index].listenpriority = resources[index].listenpriority;
          lbvserverArray[index].tcpprofilename = resources[index].tcpprofilename;
          lbvserverArray[index].httpprofilename = resources[index].httpprofilename;
          lbvserverArray[index].dbprofilename = resources[index].dbprofilename;
          lbvserverArray[index].comment = resources[index].comment;
          lbvserverArray[index].l2conn = resources[index].l2conn;
          lbvserverArray[index].oracleserverversion = resources[index].oracleserverversion;
          lbvserverArray[index].mssqlserverversion = resources[index].mssqlserverversion;
          lbvserverArray[index].mysqlprotocolversion = resources[index].mysqlprotocolversion;
          lbvserverArray[index].mysqlserverversion = resources[index].mysqlserverversion;
          lbvserverArray[index].mysqlcharacterset = resources[index].mysqlcharacterset;
          lbvserverArray[index].mysqlservercapabilities = resources[index].mysqlservercapabilities;
          lbvserverArray[index].appflowlog = resources[index].appflowlog;
          lbvserverArray[index].netprofile = resources[index].netprofile;
          lbvserverArray[index].icmpvsrresponse = resources[index].icmpvsrresponse;
          lbvserverArray[index].rhistate = resources[index].rhistate;
          lbvserverArray[index].newservicerequest = resources[index].newservicerequest;
          lbvserverArray[index].newservicerequestunit = resources[index].newservicerequestunit;
          lbvserverArray[index].newservicerequestincrementinterval = resources[index].newservicerequestincrementinterval;
          lbvserverArray[index].minautoscalemembers = resources[index].minautoscalemembers;
          lbvserverArray[index].maxautoscalemembers = resources[index].maxautoscalemembers;
          lbvserverArray[index].persistavpno = resources[index].persistavpno;
          lbvserverArray[index].skippersistency = resources[index].skippersistency;
          lbvserverArray[index].authnprofile = resources[index].authnprofile;
          lbvserverArray[index].macmoderetainvlan = resources[index].macmoderetainvlan;
          lbvserverArray[index].dbslb = resources[index].dbslb;
          lbvserverArray[index].dns64 = resources[index].dns64;
          lbvserverArray[index].bypassaaaa = resources[index].bypassaaaa;
          lbvserverArray[index].recursionavailable = resources[index].recursionavailable;
          lbvserverArray[index].processlocal = resources[index].processlocal;
          lbvserverArray[index].dnsprofilename = resources[index].dnsprofilename;
        }
        baseResponses = base_resource.update_bulk_request(client, (base_resource[]) lbvserverArray);
      }
      return baseResponses;
    }

    public static base_response unset(
      nitro_service client,
      string name,
      string[] args)
    {
      return new lbvserver() { name = name }.unset_resource(client, args);
    }

    public static base_response unset(
      nitro_service client,
      lbvserver resource,
      string[] args)
    {
      return new lbvserver() { name = resource.name }.unset_resource(client, args);
    }

    public static base_responses unset(
      nitro_service client,
      string[] name,
      string[] args)
    {
      base_responses baseResponses = (base_responses) null;
      if (name != null && name.Length > 0)
      {
        lbvserver[] lbvserverArray = new lbvserver[name.Length];
        for (int index = 0; index < name.Length; ++index)
        {
          lbvserverArray[index] = new lbvserver();
          lbvserverArray[index].name = name[index];
        }
        baseResponses = base_resource.unset_bulk_request(client, (base_resource[]) lbvserverArray, args);
      }
      return baseResponses;
    }

    public static base_responses unset(
      nitro_service client,
      lbvserver[] resources,
      string[] args)
    {
      base_responses baseResponses = (base_responses) null;
      if (resources != null && resources.Length > 0)
      {
        lbvserver[] lbvserverArray = new lbvserver[resources.Length];
        for (int index = 0; index < resources.Length; ++index)
        {
          lbvserverArray[index] = new lbvserver();
          lbvserverArray[index].name = resources[index].name;
        }
        baseResponses = base_resource.unset_bulk_request(client, (base_resource[]) lbvserverArray, args);
      }
      return baseResponses;
    }

    public static base_response enable(nitro_service client, string name) => new lbvserver()
    {
      name = name
    }.perform_operation_byaction(client, nameof (enable));

    public static base_response enable(nitro_service client, lbvserver resource) => new lbvserver()
    {
      name = resource.name
    }.perform_operation_byaction(client, nameof (enable));

    public static base_responses enable(nitro_service client, string[] name)
    {
      base_responses baseResponses = (base_responses) null;
      if (name != null && name.Length > 0)
      {
        lbvserver[] lbvserverArray = new lbvserver[name.Length];
        for (int index = 0; index < name.Length; ++index)
        {
          lbvserverArray[index] = new lbvserver();
          lbvserverArray[index].name = name[index];
        }
        baseResponses = base_resource.perform_operation_bulk_request(client, (base_resource[]) lbvserverArray, nameof (enable));
      }
      return baseResponses;
    }

    public static base_responses enable(nitro_service client, lbvserver[] resources)
    {
      base_responses baseResponses = (base_responses) null;
      if (resources != null && resources.Length > 0)
      {
        lbvserver[] lbvserverArray = new lbvserver[resources.Length];
        for (int index = 0; index < resources.Length; ++index)
        {
          lbvserverArray[index] = new lbvserver();
          lbvserverArray[index].name = resources[index].name;
        }
        baseResponses = base_resource.perform_operation_bulk_request(client, (base_resource[]) lbvserverArray, nameof (enable));
      }
      return baseResponses;
    }

    public static base_response disable(nitro_service client, string name) => new lbvserver()
    {
      name = name
    }.perform_operation_byaction(client, nameof (disable));

    public static base_response disable(nitro_service client, lbvserver resource) => new lbvserver()
    {
      name = resource.name
    }.perform_operation_byaction(client, nameof (disable));

    public static base_responses disable(nitro_service client, string[] name)
    {
      base_responses baseResponses = (base_responses) null;
      if (name != null && name.Length > 0)
      {
        lbvserver[] lbvserverArray = new lbvserver[name.Length];
        for (int index = 0; index < name.Length; ++index)
        {
          lbvserverArray[index] = new lbvserver();
          lbvserverArray[index].name = name[index];
        }
        baseResponses = base_resource.perform_operation_bulk_request(client, (base_resource[]) lbvserverArray, nameof (disable));
      }
      return baseResponses;
    }

    public static base_responses disable(nitro_service client, lbvserver[] resources)
    {
      base_responses baseResponses = (base_responses) null;
      if (resources != null && resources.Length > 0)
      {
        lbvserver[] lbvserverArray = new lbvserver[resources.Length];
        for (int index = 0; index < resources.Length; ++index)
        {
          lbvserverArray[index] = new lbvserver();
          lbvserverArray[index].name = resources[index].name;
        }
        baseResponses = base_resource.perform_operation_bulk_request(client, (base_resource[]) lbvserverArray, nameof (disable));
      }
      return baseResponses;
    }

    public static base_response rename(
      nitro_service client,
      lbvserver resource,
      string new_name)
    {
      return new lbvserver()
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
      return new lbvserver()
      {
        name = name,
        newname = new_name
      }.rename_resource(client);
    }

    public static lbvserver[] get(nitro_service service) => (lbvserver[]) new lbvserver().get_resources(service, (options) null);

    public static lbvserver[] get(nitro_service service, options option) => (lbvserver[]) new lbvserver().get_resources(service, option);

    public static lbvserver get(nitro_service service, string name) => (lbvserver) new lbvserver()
    {
      name = name
    }.get_resource(service);

    public static lbvserver[] get(nitro_service service, string[] name)
    {
      if (name == null || name.Length <= 0)
        return (lbvserver[]) null;
      lbvserver[] lbvserverArray1 = new lbvserver[name.Length];
      lbvserver[] lbvserverArray2 = new lbvserver[name.Length];
      for (int index = 0; index < name.Length; ++index)
      {
        lbvserverArray2[index] = new lbvserver();
        lbvserverArray2[index].name = name[index];
        lbvserverArray1[index] = (lbvserver) lbvserverArray2[index].get_resource(service);
      }
      return lbvserverArray1;
    }

    public static lbvserver[] get_filtered(nitro_service service, string filter)
    {
      lbvserver lbvserver = new lbvserver();
      options option = new options();
      option.set_filter(filter);
      return (lbvserver[]) lbvserver.getfiltered(service, option);
    }

    public static lbvserver[] get_filtered(nitro_service service, filtervalue[] filter)
    {
      lbvserver lbvserver = new lbvserver();
      options option = new options();
      option.set_filter(filter);
      return (lbvserver[]) lbvserver.getfiltered(service, option);
    }

    public static uint count(nitro_service service)
    {
      lbvserver lbvserver = new lbvserver();
      options option = new options();
      option.set_count(true);
      lbvserver[] resources = (lbvserver[]) lbvserver.get_resources(service, option);
      return resources != null && resources.Length > 0 ? resources[0].__count.Value : 0U;
    }

    public static uint count_filtered(nitro_service service, string filter)
    {
      lbvserver lbvserver = new lbvserver();
      options option = new options();
      option.set_count(true);
      option.set_filter(filter);
      lbvserver[] lbvserverArray = (lbvserver[]) lbvserver.getfiltered(service, option);
      return lbvserverArray != null && lbvserverArray.Length > 0 ? lbvserverArray[0].__count.Value : 0U;
    }

    public static uint count_filtered(nitro_service service, filtervalue[] filter)
    {
      lbvserver lbvserver = new lbvserver();
      options option = new options();
      option.set_count(true);
      option.set_filter(filter);
      lbvserver[] lbvserverArray = (lbvserver[]) lbvserver.getfiltered(service, option);
      return lbvserverArray != null && lbvserverArray.Length > 0 ? lbvserverArray[0].__count.Value : 0U;
    }

    private class lbvserver_response : base_response
    {
      public lbvserver[] lbvserver = (lbvserver[]) null;
    }

    public static class oracleserverversionEnum
    {
      public const string _10G = "10G";
      public const string _11G = "11G";
    }

    public static class scEnum
    {
      public const string ON = "ON";
      public const string OFF = "OFF";
    }

    public static class pqEnum
    {
      public const string ON = "ON";
      public const string OFF = "OFF";
    }

    public static class rhistateEnum
    {
      public const string PASSIVE = "PASSIVE";
      public const string ACTIVE = "ACTIVE";
    }

    public static class backuplbmethodEnum
    {
      public const string ROUNDROBIN = "ROUNDROBIN";
      public const string LEASTCONNECTION = "LEASTCONNECTION";
      public const string LEASTRESPONSETIME = "LEASTRESPONSETIME";
      public const string SOURCEIPHASH = "SOURCEIPHASH";
      public const string LEASTBANDWIDTH = "LEASTBANDWIDTH";
      public const string LEASTPACKETS = "LEASTPACKETS";
      public const string CUSTOMLOAD = "CUSTOMLOAD";
    }

    public static class macmoderetainvlanEnum
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

    public static class mapEnum
    {
      public const string ON = "ON";
      public const string OFF = "OFF";
    }

    public static class skippersistencyEnum
    {
      public const string Bypass = "Bypass";
      public const string ReLb = "ReLb";
      public const string None = "None";
    }

    public static class dbslbEnum
    {
      public const string ENABLED = "ENABLED";
      public const string DISABLED = "DISABLED";
    }

    public static class newservicerequestunitEnum
    {
      public const string PER_SECOND = "PER_SECOND";
      public const string PERCENT = "PERCENT";
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

    public static class icmpvsrresponseEnum
    {
      public const string PASSIVE = "PASSIVE";
      public const string ACTIVE = "ACTIVE";
    }

    public static class sessionlessEnum
    {
      public const string ENABLED = "ENABLED";
      public const string DISABLED = "DISABLED";
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

    public static class disableprimaryondownEnum
    {
      public const string ENABLED = "ENABLED";
      public const string DISABLED = "DISABLED";
    }

    public static class rtspnatEnum
    {
      public const string ON = "ON";
      public const string OFF = "OFF";
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

    public static class processlocalEnum
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
    }

    public static class consolidatedlconnEnum
    {
      public const string GLOBAL = "GLOBAL";
      public const string NO = "NO";
      public const string YES = "YES";
    }

    public static class sopersistenceEnum
    {
      public const string ENABLED = "ENABLED";
      public const string DISABLED = "DISABLED";
    }

    public static class lbmethodEnum
    {
      public const string ROUNDROBIN = "ROUNDROBIN";
      public const string LEASTCONNECTION = "LEASTCONNECTION";
      public const string LEASTRESPONSETIME = "LEASTRESPONSETIME";
      public const string URLHASH = "URLHASH";
      public const string DOMAINHASH = "DOMAINHASH";
      public const string DESTINATIONIPHASH = "DESTINATIONIPHASH";
      public const string SOURCEIPHASH = "SOURCEIPHASH";
      public const string SRCIPDESTIPHASH = "SRCIPDESTIPHASH";
      public const string LEASTBANDWIDTH = "LEASTBANDWIDTH";
      public const string LEASTPACKETS = "LEASTPACKETS";
      public const string TOKEN = "TOKEN";
      public const string SRCIPSRCPORTHASH = "SRCIPSRCPORTHASH";
      public const string LRTM = "LRTM";
      public const string CALLIDHASH = "CALLIDHASH";
      public const string CUSTOMLOAD = "CUSTOMLOAD";
      public const string LEASTREQUEST = "LEASTREQUEST";
      public const string AUDITLOGHASH = "AUDITLOGHASH";
      public const string STATICPROXIMITY = "STATICPROXIMITY";
    }

    public static class consolidatedlconngblEnum
    {
      public const string YES = "YES";
      public const string NO = "NO";
    }

    public static class redirectEnum
    {
      public const string CACHE = "CACHE";
      public const string POLICY = "POLICY";
      public const string ORIGIN = "ORIGIN";
    }

    public static class effectivestateEnum
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

    public static class bypassaaaaEnum
    {
      public const string YES = "YES";
      public const string NO = "NO";
    }

    public static class connfailoverEnum
    {
      public const string DISABLED = "DISABLED";
      public const string STATEFUL = "STATEFUL";
      public const string STATELESS = "STATELESS";
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

    public static class persistencebackupEnum
    {
      public const string SOURCEIP = "SOURCEIP";
      public const string NONE = "NONE";
    }

    public static class appflowlogEnum
    {
      public const string ENABLED = "ENABLED";
      public const string DISABLED = "DISABLED";
    }

    public static class mEnum
    {
      public const string IP = "IP";
      public const string MAC = "MAC";
      public const string IPTUNNEL = "IPTUNNEL";
      public const string TOS = "TOS";
    }

    public static class precedenceEnum
    {
      public const string RULE = "RULE";
      public const string URL = "URL";
    }

    public static class dns64Enum
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

    public static class persistencetypeEnum
    {
      public const string SOURCEIP = "SOURCEIP";
      public const string COOKIEINSERT = "COOKIEINSERT";
      public const string SSLSESSION = "SSLSESSION";
      public const string RULE = "RULE";
      public const string URLPASSIVE = "URLPASSIVE";
      public const string CUSTOMSERVERID = "CUSTOMSERVERID";
      public const string DESTIP = "DESTIP";
      public const string SRCIPDESTIP = "SRCIPDESTIP";
      public const string CALLID = "CALLID";
      public const string RTSPSID = "RTSPSID";
      public const string DIAMETER = "DIAMETER";
      public const string FIXSESSION = "FIXSESSION";
      public const string NONE = "NONE";
    }

    public static class insertvserveripportEnum
    {
      public const string OFF = "OFF";
      public const string VIPADDR = "VIPADDR";
      public const string V6TOV4MAPPING = "V6TOV4MAPPING";
    }

    public static class recursionavailableEnum
    {
      public const string YES = "YES";
      public const string NO = "NO";
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
