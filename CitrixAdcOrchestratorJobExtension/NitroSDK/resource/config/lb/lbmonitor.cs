// Decompiled with JetBrains decompiler
// Type: com.citrix.netscaler.nitro.resource.config.lb.lbmonitor
// Assembly: nitro, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 6CF5DDEF-E052-4F9D-953F-6644F8378A66


using com.citrix.netscaler.nitro.exception;
using com.citrix.netscaler.nitro.resource.Base;
using com.citrix.netscaler.nitro.service;
using com.citrix.netscaler.nitro.util;

namespace com.citrix.netscaler.nitro.resource.config.lb
{
  public class lbmonitor : base_resource
  {
    private string monitornameField = (string) null;
    private string typeField = (string) null;
    private string actionField = (string) null;
    private string[] respcodeField = (string[]) null;
    private string httprequestField = (string) null;
    private string rtsprequestField = (string) null;
    private string customheadersField = (string) null;
    private uint? maxforwardsField = new uint?();
    private string sipmethodField = (string) null;
    private string sipuriField = (string) null;
    private string sipreguriField = (string) null;
    private string sendField = (string) null;
    private string recvField = (string) null;
    private string queryField = (string) null;
    private string querytypeField = (string) null;
    private string scriptnameField = (string) null;
    private string scriptargsField = (string) null;
    private string dispatcheripField = (string) null;
    private ushort? dispatcherportField = new ushort?();
    private string usernameField = (string) null;
    private string passwordField = (string) null;
    private string secondarypasswordField = (string) null;
    private string logonpointnameField = (string) null;
    private string lasversionField = (string) null;
    private string radkeyField = (string) null;
    private string radnasidField = (string) null;
    private string radnasipField = (string) null;
    private uint? radaccounttypeField = new uint?();
    private string radframedipField = (string) null;
    private string radapnField = (string) null;
    private string radmsisdnField = (string) null;
    private string radaccountsessionField = (string) null;
    private string lrtmField = (string) null;
    private uint? deviationField = new uint?();
    private string units1Field = (string) null;
    private int? intervalField = new int?();
    private string units3Field = (string) null;
    private int? resptimeoutField = new int?();
    private string units4Field = (string) null;
    private uint? resptimeoutthreshField = new uint?();
    private int? retriesField = new int?();
    private int? failureretriesField = new int?();
    private int? alertretriesField = new int?();
    private int? successretriesField = new int?();
    private int? downtimeField = new int?();
    private string units2Field = (string) null;
    private string destipField = (string) null;
    private ushort? destportField = new ushort?();
    private string stateField = (string) null;
    private string reverseField = (string) null;
    private string transparentField = (string) null;
    private string iptunnelField = (string) null;
    private string tosField = (string) null;
    private uint? tosidField = new uint?();
    private string secureField = (string) null;
    private string validatecredField = (string) null;
    private string domainField = (string) null;
    private string[] ipaddressField = (string[]) null;
    private string groupField = (string) null;
    private string filenameField = (string) null;
    private string basednField = (string) null;
    private string binddnField = (string) null;
    private string filterField = (string) null;
    private string attributeField = (string) null;
    private string databaseField = (string) null;
    private string oraclesidField = (string) null;
    private string sqlqueryField = (string) null;
    private string evalruleField = (string) null;
    private string mssqlprotocolversionField = (string) null;
    private string SnmpoidField = (string) null;
    private string snmpcommunityField = (string) null;
    private string snmpthresholdField = (string) null;
    private string snmpversionField = (string) null;
    private string metrictableField = (string) null;
    private string applicationField = (string) null;
    private string sitepathField = (string) null;
    private string storenameField = (string) null;
    private string storefrontacctserviceField = (string) null;
    private string hostnameField = (string) null;
    private string netprofileField = (string) null;
    private string originhostField = (string) null;
    private string originrealmField = (string) null;
    private string hostipaddressField = (string) null;
    private uint? vendoridField = new uint?();
    private string productnameField = (string) null;
    private uint? firmwarerevisionField = new uint?();
    private uint?[] authapplicationidField = (uint?[]) null;
    private uint?[] acctapplicationidField = (uint?[]) null;
    private string inbandsecurityidField = (string) null;
    private uint?[] supportedvendoridsField = (uint?[]) null;
    private uint? vendorspecificvendoridField = new uint?();
    private uint?[] vendorspecificauthapplicationidsField = (uint?[]) null;
    private uint?[] vendorspecificacctapplicationidsField = (uint?[]) null;
    private string kcdaccountField = (string) null;
    private string storedbField = (string) null;
    private string storefrontcheckbackendservicesField = (string) null;
    private uint? trofscodeField = new uint?();
    private string trofsstringField = (string) null;
    private string metricField = (string) null;
    private long? metricthresholdField = new long?();
    private uint? metricweightField = new uint?();
    private string servicenameField = (string) null;
    private string servicegroupnameField = (string) null;
    private int? lrtmconfField = new int?();
    private string lrtmconfstrField = (string) null;
    private int? dynamicresponsetimeoutField = new int?();
    private int? dynamicintervalField = new int?();
    private string[] multimetrictableField = (string[]) null;
    private string dup_stateField = (string) null;
    private uint? dup_weightField = new uint?();
    private uint? weightField = new uint?();
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
      set => this.typeField = value;
    }

    public string action
    {
      get => this.actionField;
      set => this.actionField = value;
    }

    public string[] respcode
    {
      get => this.respcodeField;
      set => this.respcodeField = value;
    }

    public string httprequest
    {
      get => this.httprequestField;
      set => this.httprequestField = value;
    }

    public string rtsprequest
    {
      get => this.rtsprequestField;
      set => this.rtsprequestField = value;
    }

    public string customheaders
    {
      get => this.customheadersField;
      set => this.customheadersField = value;
    }

    public uint? maxforwards
    {
      get => this.maxforwardsField;
      set => this.maxforwardsField = value;
    }

    public string sipmethod
    {
      get => this.sipmethodField;
      set => this.sipmethodField = value;
    }

    public string sipuri
    {
      get => this.sipuriField;
      set => this.sipuriField = value;
    }

    public string sipreguri
    {
      get => this.sipreguriField;
      set => this.sipreguriField = value;
    }

    public string send
    {
      get => this.sendField;
      set => this.sendField = value;
    }

    public string recv
    {
      get => this.recvField;
      set => this.recvField = value;
    }

    public string query
    {
      get => this.queryField;
      set => this.queryField = value;
    }

    public string querytype
    {
      get => this.querytypeField;
      set => this.querytypeField = value;
    }

    public string scriptname
    {
      get => this.scriptnameField;
      set => this.scriptnameField = value;
    }

    public string scriptargs
    {
      get => this.scriptargsField;
      set => this.scriptargsField = value;
    }

    public string dispatcherip
    {
      get => this.dispatcheripField;
      set => this.dispatcheripField = value;
    }

    public ushort? dispatcherport
    {
      get => this.dispatcherportField;
      set => this.dispatcherportField = value;
    }

    public string username
    {
      get => this.usernameField;
      set => this.usernameField = value;
    }

    public string password
    {
      get => this.passwordField;
      set => this.passwordField = value;
    }

    public string secondarypassword
    {
      get => this.secondarypasswordField;
      set => this.secondarypasswordField = value;
    }

    public string logonpointname
    {
      get => this.logonpointnameField;
      set => this.logonpointnameField = value;
    }

    public string lasversion
    {
      get => this.lasversionField;
      set => this.lasversionField = value;
    }

    public string radkey
    {
      get => this.radkeyField;
      set => this.radkeyField = value;
    }

    public string radnasid
    {
      get => this.radnasidField;
      set => this.radnasidField = value;
    }

    public string radnasip
    {
      get => this.radnasipField;
      set => this.radnasipField = value;
    }

    public uint? radaccounttype
    {
      get => this.radaccounttypeField;
      set => this.radaccounttypeField = value;
    }

    public string radframedip
    {
      get => this.radframedipField;
      set => this.radframedipField = value;
    }

    public string radapn
    {
      get => this.radapnField;
      set => this.radapnField = value;
    }

    public string radmsisdn
    {
      get => this.radmsisdnField;
      set => this.radmsisdnField = value;
    }

    public string radaccountsession
    {
      get => this.radaccountsessionField;
      set => this.radaccountsessionField = value;
    }

    public string lrtm
    {
      get => this.lrtmField;
      set => this.lrtmField = value;
    }

    public uint? deviation
    {
      get => this.deviationField;
      set => this.deviationField = value;
    }

    public string units1
    {
      get => this.units1Field;
      set => this.units1Field = value;
    }

    public int? interval
    {
      get => this.intervalField;
      set => this.intervalField = value;
    }

    public string units3
    {
      get => this.units3Field;
      set => this.units3Field = value;
    }

    public int? resptimeout
    {
      get => this.resptimeoutField;
      set => this.resptimeoutField = value;
    }

    public string units4
    {
      get => this.units4Field;
      set => this.units4Field = value;
    }

    public uint? resptimeoutthresh
    {
      get => this.resptimeoutthreshField;
      set => this.resptimeoutthreshField = value;
    }

    public int? retries
    {
      get => this.retriesField;
      set => this.retriesField = value;
    }

    public int? failureretries
    {
      get => this.failureretriesField;
      set => this.failureretriesField = value;
    }

    public int? alertretries
    {
      get => this.alertretriesField;
      set => this.alertretriesField = value;
    }

    public int? successretries
    {
      get => this.successretriesField;
      set => this.successretriesField = value;
    }

    public int? downtime
    {
      get => this.downtimeField;
      set => this.downtimeField = value;
    }

    public string units2
    {
      get => this.units2Field;
      set => this.units2Field = value;
    }

    public string destip
    {
      get => this.destipField;
      set => this.destipField = value;
    }

    public ushort? destport
    {
      get => this.destportField;
      set => this.destportField = value;
    }

    public string state
    {
      get => this.stateField;
      set => this.stateField = value;
    }

    public string reverse
    {
      get => this.reverseField;
      set => this.reverseField = value;
    }

    public string transparent
    {
      get => this.transparentField;
      set => this.transparentField = value;
    }

    public string iptunnel
    {
      get => this.iptunnelField;
      set => this.iptunnelField = value;
    }

    public string tos
    {
      get => this.tosField;
      set => this.tosField = value;
    }

    public uint? tosid
    {
      get => this.tosidField;
      set => this.tosidField = value;
    }

    public string secure
    {
      get => this.secureField;
      set => this.secureField = value;
    }

    public string validatecred
    {
      get => this.validatecredField;
      set => this.validatecredField = value;
    }

    public string domain
    {
      get => this.domainField;
      set => this.domainField = value;
    }

    public string[] ipaddress
    {
      get => this.ipaddressField;
      set => this.ipaddressField = value;
    }

    public string group
    {
      get => this.groupField;
      set => this.groupField = value;
    }

    public string filename
    {
      get => this.filenameField;
      set => this.filenameField = value;
    }

    public string basedn
    {
      get => this.basednField;
      set => this.basednField = value;
    }

    public string binddn
    {
      get => this.binddnField;
      set => this.binddnField = value;
    }

    public string filter
    {
      get => this.filterField;
      set => this.filterField = value;
    }

    public string attribute
    {
      get => this.attributeField;
      set => this.attributeField = value;
    }

    public string database
    {
      get => this.databaseField;
      set => this.databaseField = value;
    }

    public string oraclesid
    {
      get => this.oraclesidField;
      set => this.oraclesidField = value;
    }

    public string sqlquery
    {
      get => this.sqlqueryField;
      set => this.sqlqueryField = value;
    }

    public string evalrule
    {
      get => this.evalruleField;
      set => this.evalruleField = value;
    }

    public string mssqlprotocolversion
    {
      get => this.mssqlprotocolversionField;
      set => this.mssqlprotocolversionField = value;
    }

    public string Snmpoid
    {
      get => this.SnmpoidField;
      set => this.SnmpoidField = value;
    }

    public string snmpcommunity
    {
      get => this.snmpcommunityField;
      set => this.snmpcommunityField = value;
    }

    public string snmpthreshold
    {
      get => this.snmpthresholdField;
      set => this.snmpthresholdField = value;
    }

    public string snmpversion
    {
      get => this.snmpversionField;
      set => this.snmpversionField = value;
    }

    public string metrictable
    {
      get => this.metrictableField;
      set => this.metrictableField = value;
    }

    public string application
    {
      get => this.applicationField;
      set => this.applicationField = value;
    }

    public string sitepath
    {
      get => this.sitepathField;
      set => this.sitepathField = value;
    }

    public string storename
    {
      get => this.storenameField;
      set => this.storenameField = value;
    }

    public string storefrontacctservice
    {
      get => this.storefrontacctserviceField;
      set => this.storefrontacctserviceField = value;
    }

    public string hostname
    {
      get => this.hostnameField;
      set => this.hostnameField = value;
    }

    public string netprofile
    {
      get => this.netprofileField;
      set => this.netprofileField = value;
    }

    public string originhost
    {
      get => this.originhostField;
      set => this.originhostField = value;
    }

    public string originrealm
    {
      get => this.originrealmField;
      set => this.originrealmField = value;
    }

    public string hostipaddress
    {
      get => this.hostipaddressField;
      set => this.hostipaddressField = value;
    }

    public uint? vendorid
    {
      get => this.vendoridField;
      set => this.vendoridField = value;
    }

    public string productname
    {
      get => this.productnameField;
      set => this.productnameField = value;
    }

    public uint? firmwarerevision
    {
      get => this.firmwarerevisionField;
      set => this.firmwarerevisionField = value;
    }

    public uint?[] authapplicationid
    {
      get => this.authapplicationidField;
      set => this.authapplicationidField = value;
    }

    public uint?[] acctapplicationid
    {
      get => this.acctapplicationidField;
      set => this.acctapplicationidField = value;
    }

    public string inbandsecurityid
    {
      get => this.inbandsecurityidField;
      set => this.inbandsecurityidField = value;
    }

    public uint?[] supportedvendorids
    {
      get => this.supportedvendoridsField;
      set => this.supportedvendoridsField = value;
    }

    public uint? vendorspecificvendorid
    {
      get => this.vendorspecificvendoridField;
      set => this.vendorspecificvendoridField = value;
    }

    public uint?[] vendorspecificauthapplicationids
    {
      get => this.vendorspecificauthapplicationidsField;
      set => this.vendorspecificauthapplicationidsField = value;
    }

    public uint?[] vendorspecificacctapplicationids
    {
      get => this.vendorspecificacctapplicationidsField;
      set => this.vendorspecificacctapplicationidsField = value;
    }

    public string kcdaccount
    {
      get => this.kcdaccountField;
      set => this.kcdaccountField = value;
    }

    public string storedb
    {
      get => this.storedbField;
      set => this.storedbField = value;
    }

    public string storefrontcheckbackendservices
    {
      get => this.storefrontcheckbackendservicesField;
      set => this.storefrontcheckbackendservicesField = value;
    }

    public uint? trofscode
    {
      get => this.trofscodeField;
      set => this.trofscodeField = value;
    }

    public string trofsstring
    {
      get => this.trofsstringField;
      set => this.trofsstringField = value;
    }

    public string metric
    {
      get => this.metricField;
      set => this.metricField = value;
    }

    public long? metricthreshold
    {
      get => this.metricthresholdField;
      set => this.metricthresholdField = value;
    }

    public uint? metricweight
    {
      get => this.metricweightField;
      set => this.metricweightField = value;
    }

    public string servicename
    {
      get => this.servicenameField;
      set => this.servicenameField = value;
    }

    public string servicegroupname
    {
      get => this.servicegroupnameField;
      set => this.servicegroupnameField = value;
    }

    public int? lrtmconf
    {
      get => this.lrtmconfField;
      private set => this.lrtmconfField = value;
    }

    public string lrtmconfstr
    {
      get => this.lrtmconfstrField;
      private set => this.lrtmconfstrField = value;
    }

    public int? dynamicresponsetimeout
    {
      get => this.dynamicresponsetimeoutField;
      private set => this.dynamicresponsetimeoutField = value;
    }

    public int? dynamicinterval
    {
      get => this.dynamicintervalField;
      private set => this.dynamicintervalField = value;
    }

    public string[] multimetrictable
    {
      get => this.multimetrictableField;
      private set => this.multimetrictableField = value;
    }

    public string dup_state
    {
      get => this.dup_stateField;
      private set => this.dup_stateField = value;
    }

    public uint? dup_weight
    {
      get => this.dup_weightField;
      private set => this.dup_weightField = value;
    }

    public uint? weight
    {
      get => this.weightField;
      private set => this.weightField = value;
    }

    internal override base_resource[] get_nitro_response(
      nitro_service service,
      string response)
    {
      lbmonitor.lbmonitor_response lbmonitorResponse = new lbmonitor.lbmonitor_response();
      lbmonitor.lbmonitor_response resource = (lbmonitor.lbmonitor_response) service.get_payload_formatter().string_to_resource(lbmonitorResponse.GetType(), response);
      if (resource.errorcode != 0)
      {
        if (resource.errorcode == 444)
          service.clear_session();
        if (resource.severity == null)
          throw new nitro_exception(resource.message, resource.errorcode);
        if (resource.severity.Equals("ERROR"))
          throw new nitro_exception(resource.message, resource.errorcode);
      }
      return (base_resource[]) resource.lbmonitor;
    }

    internal override string get_object_name() => this.monitorname;

    public static base_response add(nitro_service client, lbmonitor resource) => new lbmonitor()
    {
      monitorname = resource.monitorname,
      type = resource.type,
      action = resource.action,
      respcode = resource.respcode,
      httprequest = resource.httprequest,
      rtsprequest = resource.rtsprequest,
      customheaders = resource.customheaders,
      maxforwards = resource.maxforwards,
      sipmethod = resource.sipmethod,
      sipuri = resource.sipuri,
      sipreguri = resource.sipreguri,
      send = resource.send,
      recv = resource.recv,
      query = resource.query,
      querytype = resource.querytype,
      scriptname = resource.scriptname,
      scriptargs = resource.scriptargs,
      dispatcherip = resource.dispatcherip,
      dispatcherport = resource.dispatcherport,
      username = resource.username,
      password = resource.password,
      secondarypassword = resource.secondarypassword,
      logonpointname = resource.logonpointname,
      lasversion = resource.lasversion,
      radkey = resource.radkey,
      radnasid = resource.radnasid,
      radnasip = resource.radnasip,
      radaccounttype = resource.radaccounttype,
      radframedip = resource.radframedip,
      radapn = resource.radapn,
      radmsisdn = resource.radmsisdn,
      radaccountsession = resource.radaccountsession,
      lrtm = resource.lrtm,
      deviation = resource.deviation,
      units1 = resource.units1,
      interval = resource.interval,
      units3 = resource.units3,
      resptimeout = resource.resptimeout,
      units4 = resource.units4,
      resptimeoutthresh = resource.resptimeoutthresh,
      retries = resource.retries,
      failureretries = resource.failureretries,
      alertretries = resource.alertretries,
      successretries = resource.successretries,
      downtime = resource.downtime,
      units2 = resource.units2,
      destip = resource.destip,
      destport = resource.destport,
      state = resource.state,
      reverse = resource.reverse,
      transparent = resource.transparent,
      iptunnel = resource.iptunnel,
      tos = resource.tos,
      tosid = resource.tosid,
      secure = resource.secure,
      validatecred = resource.validatecred,
      domain = resource.domain,
      ipaddress = resource.ipaddress,
      group = resource.group,
      filename = resource.filename,
      basedn = resource.basedn,
      binddn = resource.binddn,
      filter = resource.filter,
      attribute = resource.attribute,
      database = resource.database,
      oraclesid = resource.oraclesid,
      sqlquery = resource.sqlquery,
      evalrule = resource.evalrule,
      mssqlprotocolversion = resource.mssqlprotocolversion,
      Snmpoid = resource.Snmpoid,
      snmpcommunity = resource.snmpcommunity,
      snmpthreshold = resource.snmpthreshold,
      snmpversion = resource.snmpversion,
      metrictable = resource.metrictable,
      application = resource.application,
      sitepath = resource.sitepath,
      storename = resource.storename,
      storefrontacctservice = resource.storefrontacctservice,
      hostname = resource.hostname,
      netprofile = resource.netprofile,
      originhost = resource.originhost,
      originrealm = resource.originrealm,
      hostipaddress = resource.hostipaddress,
      vendorid = resource.vendorid,
      productname = resource.productname,
      firmwarerevision = resource.firmwarerevision,
      authapplicationid = resource.authapplicationid,
      acctapplicationid = resource.acctapplicationid,
      inbandsecurityid = resource.inbandsecurityid,
      supportedvendorids = resource.supportedvendorids,
      vendorspecificvendorid = resource.vendorspecificvendorid,
      vendorspecificauthapplicationids = resource.vendorspecificauthapplicationids,
      vendorspecificacctapplicationids = resource.vendorspecificacctapplicationids,
      kcdaccount = resource.kcdaccount,
      storedb = resource.storedb,
      storefrontcheckbackendservices = resource.storefrontcheckbackendservices,
      trofscode = resource.trofscode,
      trofsstring = resource.trofsstring
    }.add_resource(client);

    public static base_responses add(nitro_service client, lbmonitor[] resources)
    {
      base_responses baseResponses = (base_responses) null;
      if (resources != null && resources.Length > 0)
      {
        lbmonitor[] lbmonitorArray = new lbmonitor[resources.Length];
        for (int index = 0; index < resources.Length; ++index)
        {
          lbmonitorArray[index] = new lbmonitor();
          lbmonitorArray[index].monitorname = resources[index].monitorname;
          lbmonitorArray[index].type = resources[index].type;
          lbmonitorArray[index].action = resources[index].action;
          lbmonitorArray[index].respcode = resources[index].respcode;
          lbmonitorArray[index].httprequest = resources[index].httprequest;
          lbmonitorArray[index].rtsprequest = resources[index].rtsprequest;
          lbmonitorArray[index].customheaders = resources[index].customheaders;
          lbmonitorArray[index].maxforwards = resources[index].maxforwards;
          lbmonitorArray[index].sipmethod = resources[index].sipmethod;
          lbmonitorArray[index].sipuri = resources[index].sipuri;
          lbmonitorArray[index].sipreguri = resources[index].sipreguri;
          lbmonitorArray[index].send = resources[index].send;
          lbmonitorArray[index].recv = resources[index].recv;
          lbmonitorArray[index].query = resources[index].query;
          lbmonitorArray[index].querytype = resources[index].querytype;
          lbmonitorArray[index].scriptname = resources[index].scriptname;
          lbmonitorArray[index].scriptargs = resources[index].scriptargs;
          lbmonitorArray[index].dispatcherip = resources[index].dispatcherip;
          lbmonitorArray[index].dispatcherport = resources[index].dispatcherport;
          lbmonitorArray[index].username = resources[index].username;
          lbmonitorArray[index].password = resources[index].password;
          lbmonitorArray[index].secondarypassword = resources[index].secondarypassword;
          lbmonitorArray[index].logonpointname = resources[index].logonpointname;
          lbmonitorArray[index].lasversion = resources[index].lasversion;
          lbmonitorArray[index].radkey = resources[index].radkey;
          lbmonitorArray[index].radnasid = resources[index].radnasid;
          lbmonitorArray[index].radnasip = resources[index].radnasip;
          lbmonitorArray[index].radaccounttype = resources[index].radaccounttype;
          lbmonitorArray[index].radframedip = resources[index].radframedip;
          lbmonitorArray[index].radapn = resources[index].radapn;
          lbmonitorArray[index].radmsisdn = resources[index].radmsisdn;
          lbmonitorArray[index].radaccountsession = resources[index].radaccountsession;
          lbmonitorArray[index].lrtm = resources[index].lrtm;
          lbmonitorArray[index].deviation = resources[index].deviation;
          lbmonitorArray[index].units1 = resources[index].units1;
          lbmonitorArray[index].interval = resources[index].interval;
          lbmonitorArray[index].units3 = resources[index].units3;
          lbmonitorArray[index].resptimeout = resources[index].resptimeout;
          lbmonitorArray[index].units4 = resources[index].units4;
          lbmonitorArray[index].resptimeoutthresh = resources[index].resptimeoutthresh;
          lbmonitorArray[index].retries = resources[index].retries;
          lbmonitorArray[index].failureretries = resources[index].failureretries;
          lbmonitorArray[index].alertretries = resources[index].alertretries;
          lbmonitorArray[index].successretries = resources[index].successretries;
          lbmonitorArray[index].downtime = resources[index].downtime;
          lbmonitorArray[index].units2 = resources[index].units2;
          lbmonitorArray[index].destip = resources[index].destip;
          lbmonitorArray[index].destport = resources[index].destport;
          lbmonitorArray[index].state = resources[index].state;
          lbmonitorArray[index].reverse = resources[index].reverse;
          lbmonitorArray[index].transparent = resources[index].transparent;
          lbmonitorArray[index].iptunnel = resources[index].iptunnel;
          lbmonitorArray[index].tos = resources[index].tos;
          lbmonitorArray[index].tosid = resources[index].tosid;
          lbmonitorArray[index].secure = resources[index].secure;
          lbmonitorArray[index].validatecred = resources[index].validatecred;
          lbmonitorArray[index].domain = resources[index].domain;
          lbmonitorArray[index].ipaddress = resources[index].ipaddress;
          lbmonitorArray[index].group = resources[index].group;
          lbmonitorArray[index].filename = resources[index].filename;
          lbmonitorArray[index].basedn = resources[index].basedn;
          lbmonitorArray[index].binddn = resources[index].binddn;
          lbmonitorArray[index].filter = resources[index].filter;
          lbmonitorArray[index].attribute = resources[index].attribute;
          lbmonitorArray[index].database = resources[index].database;
          lbmonitorArray[index].oraclesid = resources[index].oraclesid;
          lbmonitorArray[index].sqlquery = resources[index].sqlquery;
          lbmonitorArray[index].evalrule = resources[index].evalrule;
          lbmonitorArray[index].mssqlprotocolversion = resources[index].mssqlprotocolversion;
          lbmonitorArray[index].Snmpoid = resources[index].Snmpoid;
          lbmonitorArray[index].snmpcommunity = resources[index].snmpcommunity;
          lbmonitorArray[index].snmpthreshold = resources[index].snmpthreshold;
          lbmonitorArray[index].snmpversion = resources[index].snmpversion;
          lbmonitorArray[index].metrictable = resources[index].metrictable;
          lbmonitorArray[index].application = resources[index].application;
          lbmonitorArray[index].sitepath = resources[index].sitepath;
          lbmonitorArray[index].storename = resources[index].storename;
          lbmonitorArray[index].storefrontacctservice = resources[index].storefrontacctservice;
          lbmonitorArray[index].hostname = resources[index].hostname;
          lbmonitorArray[index].netprofile = resources[index].netprofile;
          lbmonitorArray[index].originhost = resources[index].originhost;
          lbmonitorArray[index].originrealm = resources[index].originrealm;
          lbmonitorArray[index].hostipaddress = resources[index].hostipaddress;
          lbmonitorArray[index].vendorid = resources[index].vendorid;
          lbmonitorArray[index].productname = resources[index].productname;
          lbmonitorArray[index].firmwarerevision = resources[index].firmwarerevision;
          lbmonitorArray[index].authapplicationid = resources[index].authapplicationid;
          lbmonitorArray[index].acctapplicationid = resources[index].acctapplicationid;
          lbmonitorArray[index].inbandsecurityid = resources[index].inbandsecurityid;
          lbmonitorArray[index].supportedvendorids = resources[index].supportedvendorids;
          lbmonitorArray[index].vendorspecificvendorid = resources[index].vendorspecificvendorid;
          lbmonitorArray[index].vendorspecificauthapplicationids = resources[index].vendorspecificauthapplicationids;
          lbmonitorArray[index].vendorspecificacctapplicationids = resources[index].vendorspecificacctapplicationids;
          lbmonitorArray[index].kcdaccount = resources[index].kcdaccount;
          lbmonitorArray[index].storedb = resources[index].storedb;
          lbmonitorArray[index].storefrontcheckbackendservices = resources[index].storefrontcheckbackendservices;
          lbmonitorArray[index].trofscode = resources[index].trofscode;
          lbmonitorArray[index].trofsstring = resources[index].trofsstring;
        }
        baseResponses = base_resource.add_bulk_request(client, (base_resource[]) lbmonitorArray);
      }
      return baseResponses;
    }

    public static base_response delete(nitro_service client, string monitorname) => new lbmonitor()
    {
      monitorname = monitorname
    }.delete_resource(client);

    public static base_response delete(nitro_service client, lbmonitor resource) => new lbmonitor()
    {
      monitorname = resource.monitorname,
      type = resource.type,
      respcode = resource.respcode
    }.delete_resource(client);

    public static base_responses delete(nitro_service client, string[] monitorname)
    {
      base_responses baseResponses = (base_responses) null;
      if (monitorname != null && monitorname.Length > 0)
      {
        lbmonitor[] lbmonitorArray = new lbmonitor[monitorname.Length];
        for (int index = 0; index < monitorname.Length; ++index)
        {
          lbmonitorArray[index] = new lbmonitor();
          lbmonitorArray[index].monitorname = monitorname[index];
        }
        baseResponses = base_resource.delete_bulk_request(client, (base_resource[]) lbmonitorArray);
      }
      return baseResponses;
    }

    public static base_responses delete(nitro_service client, lbmonitor[] resources)
    {
      base_responses baseResponses = (base_responses) null;
      if (resources != null && resources.Length > 0)
      {
        lbmonitor[] lbmonitorArray = new lbmonitor[resources.Length];
        for (int index = 0; index < resources.Length; ++index)
        {
          lbmonitorArray[index] = new lbmonitor();
          lbmonitorArray[index].monitorname = resources[index].monitorname;
          lbmonitorArray[index].type = resources[index].type;
          lbmonitorArray[index].respcode = resources[index].respcode;
        }
        baseResponses = base_resource.delete_bulk_request(client, (base_resource[]) lbmonitorArray);
      }
      return baseResponses;
    }

    public static base_response update(nitro_service client, lbmonitor resource) => new lbmonitor()
    {
      monitorname = resource.monitorname,
      type = resource.type,
      action = resource.action,
      respcode = resource.respcode,
      httprequest = resource.httprequest,
      rtsprequest = resource.rtsprequest,
      customheaders = resource.customheaders,
      maxforwards = resource.maxforwards,
      sipmethod = resource.sipmethod,
      sipreguri = resource.sipreguri,
      sipuri = resource.sipuri,
      send = resource.send,
      recv = resource.recv,
      query = resource.query,
      querytype = resource.querytype,
      username = resource.username,
      password = resource.password,
      secondarypassword = resource.secondarypassword,
      logonpointname = resource.logonpointname,
      lasversion = resource.lasversion,
      radkey = resource.radkey,
      radnasid = resource.radnasid,
      radnasip = resource.radnasip,
      radaccounttype = resource.radaccounttype,
      radframedip = resource.radframedip,
      radapn = resource.radapn,
      radmsisdn = resource.radmsisdn,
      radaccountsession = resource.radaccountsession,
      lrtm = resource.lrtm,
      deviation = resource.deviation,
      units1 = resource.units1,
      scriptname = resource.scriptname,
      scriptargs = resource.scriptargs,
      validatecred = resource.validatecred,
      domain = resource.domain,
      dispatcherip = resource.dispatcherip,
      dispatcherport = resource.dispatcherport,
      interval = resource.interval,
      units3 = resource.units3,
      resptimeout = resource.resptimeout,
      units4 = resource.units4,
      resptimeoutthresh = resource.resptimeoutthresh,
      retries = resource.retries,
      failureretries = resource.failureretries,
      alertretries = resource.alertretries,
      successretries = resource.successretries,
      downtime = resource.downtime,
      units2 = resource.units2,
      destip = resource.destip,
      destport = resource.destport,
      state = resource.state,
      reverse = resource.reverse,
      transparent = resource.transparent,
      iptunnel = resource.iptunnel,
      tos = resource.tos,
      tosid = resource.tosid,
      secure = resource.secure,
      ipaddress = resource.ipaddress,
      group = resource.group,
      filename = resource.filename,
      basedn = resource.basedn,
      binddn = resource.binddn,
      filter = resource.filter,
      attribute = resource.attribute,
      database = resource.database,
      oraclesid = resource.oraclesid,
      sqlquery = resource.sqlquery,
      evalrule = resource.evalrule,
      Snmpoid = resource.Snmpoid,
      snmpcommunity = resource.snmpcommunity,
      snmpthreshold = resource.snmpthreshold,
      snmpversion = resource.snmpversion,
      metrictable = resource.metrictable,
      metric = resource.metric,
      metricthreshold = resource.metricthreshold,
      metricweight = resource.metricweight,
      application = resource.application,
      sitepath = resource.sitepath,
      storename = resource.storename,
      storefrontacctservice = resource.storefrontacctservice,
      storefrontcheckbackendservices = resource.storefrontcheckbackendservices,
      hostname = resource.hostname,
      netprofile = resource.netprofile,
      mssqlprotocolversion = resource.mssqlprotocolversion,
      originhost = resource.originhost,
      originrealm = resource.originrealm,
      hostipaddress = resource.hostipaddress,
      vendorid = resource.vendorid,
      productname = resource.productname,
      firmwarerevision = resource.firmwarerevision,
      authapplicationid = resource.authapplicationid,
      acctapplicationid = resource.acctapplicationid,
      inbandsecurityid = resource.inbandsecurityid,
      supportedvendorids = resource.supportedvendorids,
      vendorspecificvendorid = resource.vendorspecificvendorid,
      vendorspecificauthapplicationids = resource.vendorspecificauthapplicationids,
      vendorspecificacctapplicationids = resource.vendorspecificacctapplicationids,
      kcdaccount = resource.kcdaccount,
      storedb = resource.storedb,
      trofscode = resource.trofscode,
      trofsstring = resource.trofsstring
    }.update_resource(client);

    public static base_responses update(nitro_service client, lbmonitor[] resources)
    {
      base_responses baseResponses = (base_responses) null;
      if (resources != null && resources.Length > 0)
      {
        lbmonitor[] lbmonitorArray = new lbmonitor[resources.Length];
        for (int index = 0; index < resources.Length; ++index)
        {
          lbmonitorArray[index] = new lbmonitor();
          lbmonitorArray[index].monitorname = resources[index].monitorname;
          lbmonitorArray[index].type = resources[index].type;
          lbmonitorArray[index].action = resources[index].action;
          lbmonitorArray[index].respcode = resources[index].respcode;
          lbmonitorArray[index].httprequest = resources[index].httprequest;
          lbmonitorArray[index].rtsprequest = resources[index].rtsprequest;
          lbmonitorArray[index].customheaders = resources[index].customheaders;
          lbmonitorArray[index].maxforwards = resources[index].maxforwards;
          lbmonitorArray[index].sipmethod = resources[index].sipmethod;
          lbmonitorArray[index].sipreguri = resources[index].sipreguri;
          lbmonitorArray[index].sipuri = resources[index].sipuri;
          lbmonitorArray[index].send = resources[index].send;
          lbmonitorArray[index].recv = resources[index].recv;
          lbmonitorArray[index].query = resources[index].query;
          lbmonitorArray[index].querytype = resources[index].querytype;
          lbmonitorArray[index].username = resources[index].username;
          lbmonitorArray[index].password = resources[index].password;
          lbmonitorArray[index].secondarypassword = resources[index].secondarypassword;
          lbmonitorArray[index].logonpointname = resources[index].logonpointname;
          lbmonitorArray[index].lasversion = resources[index].lasversion;
          lbmonitorArray[index].radkey = resources[index].radkey;
          lbmonitorArray[index].radnasid = resources[index].radnasid;
          lbmonitorArray[index].radnasip = resources[index].radnasip;
          lbmonitorArray[index].radaccounttype = resources[index].radaccounttype;
          lbmonitorArray[index].radframedip = resources[index].radframedip;
          lbmonitorArray[index].radapn = resources[index].radapn;
          lbmonitorArray[index].radmsisdn = resources[index].radmsisdn;
          lbmonitorArray[index].radaccountsession = resources[index].radaccountsession;
          lbmonitorArray[index].lrtm = resources[index].lrtm;
          lbmonitorArray[index].deviation = resources[index].deviation;
          lbmonitorArray[index].units1 = resources[index].units1;
          lbmonitorArray[index].scriptname = resources[index].scriptname;
          lbmonitorArray[index].scriptargs = resources[index].scriptargs;
          lbmonitorArray[index].validatecred = resources[index].validatecred;
          lbmonitorArray[index].domain = resources[index].domain;
          lbmonitorArray[index].dispatcherip = resources[index].dispatcherip;
          lbmonitorArray[index].dispatcherport = resources[index].dispatcherport;
          lbmonitorArray[index].interval = resources[index].interval;
          lbmonitorArray[index].units3 = resources[index].units3;
          lbmonitorArray[index].resptimeout = resources[index].resptimeout;
          lbmonitorArray[index].units4 = resources[index].units4;
          lbmonitorArray[index].resptimeoutthresh = resources[index].resptimeoutthresh;
          lbmonitorArray[index].retries = resources[index].retries;
          lbmonitorArray[index].failureretries = resources[index].failureretries;
          lbmonitorArray[index].alertretries = resources[index].alertretries;
          lbmonitorArray[index].successretries = resources[index].successretries;
          lbmonitorArray[index].downtime = resources[index].downtime;
          lbmonitorArray[index].units2 = resources[index].units2;
          lbmonitorArray[index].destip = resources[index].destip;
          lbmonitorArray[index].destport = resources[index].destport;
          lbmonitorArray[index].state = resources[index].state;
          lbmonitorArray[index].reverse = resources[index].reverse;
          lbmonitorArray[index].transparent = resources[index].transparent;
          lbmonitorArray[index].iptunnel = resources[index].iptunnel;
          lbmonitorArray[index].tos = resources[index].tos;
          lbmonitorArray[index].tosid = resources[index].tosid;
          lbmonitorArray[index].secure = resources[index].secure;
          lbmonitorArray[index].ipaddress = resources[index].ipaddress;
          lbmonitorArray[index].group = resources[index].group;
          lbmonitorArray[index].filename = resources[index].filename;
          lbmonitorArray[index].basedn = resources[index].basedn;
          lbmonitorArray[index].binddn = resources[index].binddn;
          lbmonitorArray[index].filter = resources[index].filter;
          lbmonitorArray[index].attribute = resources[index].attribute;
          lbmonitorArray[index].database = resources[index].database;
          lbmonitorArray[index].oraclesid = resources[index].oraclesid;
          lbmonitorArray[index].sqlquery = resources[index].sqlquery;
          lbmonitorArray[index].evalrule = resources[index].evalrule;
          lbmonitorArray[index].Snmpoid = resources[index].Snmpoid;
          lbmonitorArray[index].snmpcommunity = resources[index].snmpcommunity;
          lbmonitorArray[index].snmpthreshold = resources[index].snmpthreshold;
          lbmonitorArray[index].snmpversion = resources[index].snmpversion;
          lbmonitorArray[index].metrictable = resources[index].metrictable;
          lbmonitorArray[index].metric = resources[index].metric;
          lbmonitorArray[index].metricthreshold = resources[index].metricthreshold;
          lbmonitorArray[index].metricweight = resources[index].metricweight;
          lbmonitorArray[index].application = resources[index].application;
          lbmonitorArray[index].sitepath = resources[index].sitepath;
          lbmonitorArray[index].storename = resources[index].storename;
          lbmonitorArray[index].storefrontacctservice = resources[index].storefrontacctservice;
          lbmonitorArray[index].storefrontcheckbackendservices = resources[index].storefrontcheckbackendservices;
          lbmonitorArray[index].hostname = resources[index].hostname;
          lbmonitorArray[index].netprofile = resources[index].netprofile;
          lbmonitorArray[index].mssqlprotocolversion = resources[index].mssqlprotocolversion;
          lbmonitorArray[index].originhost = resources[index].originhost;
          lbmonitorArray[index].originrealm = resources[index].originrealm;
          lbmonitorArray[index].hostipaddress = resources[index].hostipaddress;
          lbmonitorArray[index].vendorid = resources[index].vendorid;
          lbmonitorArray[index].productname = resources[index].productname;
          lbmonitorArray[index].firmwarerevision = resources[index].firmwarerevision;
          lbmonitorArray[index].authapplicationid = resources[index].authapplicationid;
          lbmonitorArray[index].acctapplicationid = resources[index].acctapplicationid;
          lbmonitorArray[index].inbandsecurityid = resources[index].inbandsecurityid;
          lbmonitorArray[index].supportedvendorids = resources[index].supportedvendorids;
          lbmonitorArray[index].vendorspecificvendorid = resources[index].vendorspecificvendorid;
          lbmonitorArray[index].vendorspecificauthapplicationids = resources[index].vendorspecificauthapplicationids;
          lbmonitorArray[index].vendorspecificacctapplicationids = resources[index].vendorspecificacctapplicationids;
          lbmonitorArray[index].kcdaccount = resources[index].kcdaccount;
          lbmonitorArray[index].storedb = resources[index].storedb;
          lbmonitorArray[index].trofscode = resources[index].trofscode;
          lbmonitorArray[index].trofsstring = resources[index].trofsstring;
        }
        baseResponses = base_resource.update_bulk_request(client, (base_resource[]) lbmonitorArray);
      }
      return baseResponses;
    }

    public static base_response unset(
      nitro_service client,
      lbmonitor resource,
      string[] args)
    {
      return new lbmonitor()
      {
        monitorname = resource.monitorname,
        type = resource.type,
        ipaddress = resource.ipaddress
      }.unset_resource(client, args);
    }

    public static base_responses unset(
      nitro_service client,
      lbmonitor[] resources,
      string[] args)
    {
      base_responses baseResponses = (base_responses) null;
      if (resources != null && resources.Length > 0)
      {
        lbmonitor[] lbmonitorArray = new lbmonitor[resources.Length];
        for (int index = 0; index < resources.Length; ++index)
        {
          lbmonitorArray[index] = new lbmonitor();
          lbmonitorArray[index].monitorname = resources[index].monitorname;
          lbmonitorArray[index].type = resources[index].type;
          lbmonitorArray[index].ipaddress = resources[index].ipaddress;
        }
        baseResponses = base_resource.unset_bulk_request(client, (base_resource[]) lbmonitorArray, args);
      }
      return baseResponses;
    }

    public static base_response enable(nitro_service client, string monitorname) => new lbmonitor()
    {
      monitorname = monitorname
    }.perform_operation_byaction(client, nameof (enable));

    public static base_response enable(nitro_service client, lbmonitor resource) => new lbmonitor()
    {
      servicename = resource.servicename,
      servicegroupname = resource.servicegroupname,
      monitorname = resource.monitorname
    }.perform_operation_byaction(client, nameof (enable));

    public static base_responses enable(nitro_service client, string[] monitorname)
    {
      base_responses baseResponses = (base_responses) null;
      if (monitorname != null && monitorname.Length > 0)
      {
        lbmonitor[] lbmonitorArray = new lbmonitor[monitorname.Length];
        for (int index = 0; index < monitorname.Length; ++index)
        {
          lbmonitorArray[index] = new lbmonitor();
          lbmonitorArray[index].monitorname = monitorname[index];
        }
        baseResponses = base_resource.perform_operation_bulk_request(client, (base_resource[]) lbmonitorArray, nameof (enable));
      }
      return baseResponses;
    }

    public static base_responses enable(nitro_service client, lbmonitor[] resources)
    {
      base_responses baseResponses = (base_responses) null;
      if (resources != null && resources.Length > 0)
      {
        lbmonitor[] lbmonitorArray = new lbmonitor[resources.Length];
        for (int index = 0; index < resources.Length; ++index)
        {
          lbmonitorArray[index] = new lbmonitor();
          lbmonitorArray[index].servicename = resources[index].servicename;
          lbmonitorArray[index].servicegroupname = resources[index].servicegroupname;
          lbmonitorArray[index].monitorname = resources[index].monitorname;
        }
        baseResponses = base_resource.perform_operation_bulk_request(client, (base_resource[]) lbmonitorArray, nameof (enable));
      }
      return baseResponses;
    }

    public static base_response disable(nitro_service client, string monitorname) => new lbmonitor()
    {
      monitorname = monitorname
    }.perform_operation_byaction(client, nameof (disable));

    public static base_response disable(nitro_service client, lbmonitor resource) => new lbmonitor()
    {
      servicename = resource.servicename,
      servicegroupname = resource.servicegroupname,
      monitorname = resource.monitorname
    }.perform_operation_byaction(client, nameof (disable));

    public static base_responses disable(nitro_service client, string[] monitorname)
    {
      base_responses baseResponses = (base_responses) null;
      if (monitorname != null && monitorname.Length > 0)
      {
        lbmonitor[] lbmonitorArray = new lbmonitor[monitorname.Length];
        for (int index = 0; index < monitorname.Length; ++index)
        {
          lbmonitorArray[index] = new lbmonitor();
          lbmonitorArray[index].monitorname = monitorname[index];
        }
        baseResponses = base_resource.perform_operation_bulk_request(client, (base_resource[]) lbmonitorArray, nameof (disable));
      }
      return baseResponses;
    }

    public static base_responses disable(nitro_service client, lbmonitor[] resources)
    {
      base_responses baseResponses = (base_responses) null;
      if (resources != null && resources.Length > 0)
      {
        lbmonitor[] lbmonitorArray = new lbmonitor[resources.Length];
        for (int index = 0; index < resources.Length; ++index)
        {
          lbmonitorArray[index] = new lbmonitor();
          lbmonitorArray[index].servicename = resources[index].servicename;
          lbmonitorArray[index].servicegroupname = resources[index].servicegroupname;
          lbmonitorArray[index].monitorname = resources[index].monitorname;
        }
        baseResponses = base_resource.perform_operation_bulk_request(client, (base_resource[]) lbmonitorArray, nameof (disable));
      }
      return baseResponses;
    }

    public static lbmonitor[] get(nitro_service service) => (lbmonitor[]) new lbmonitor().get_resources(service, (options) null);

    public static lbmonitor[] get(nitro_service service, options option) => (lbmonitor[]) new lbmonitor().get_resources(service, option);

    public static lbmonitor[] get(nitro_service service, lbmonitor_args args)
    {
      lbmonitor lbmonitor = new lbmonitor();
      options option = new options();
      option.set_args(nitro_util.object_to_string_withoutquotes((object) args));
      return (lbmonitor[]) lbmonitor.get_resources(service, option);
    }

    public static lbmonitor get(nitro_service service, string monitorname) => (lbmonitor) new lbmonitor()
    {
      monitorname = monitorname
    }.get_resource(service);

    public static lbmonitor[] get(nitro_service service, string[] monitorname)
    {
      if (monitorname == null || monitorname.Length <= 0)
        return (lbmonitor[]) null;
      lbmonitor[] lbmonitorArray1 = new lbmonitor[monitorname.Length];
      lbmonitor[] lbmonitorArray2 = new lbmonitor[monitorname.Length];
      for (int index = 0; index < monitorname.Length; ++index)
      {
        lbmonitorArray2[index] = new lbmonitor();
        lbmonitorArray2[index].monitorname = monitorname[index];
        lbmonitorArray1[index] = (lbmonitor) lbmonitorArray2[index].get_resource(service);
      }
      return lbmonitorArray1;
    }

    public static lbmonitor[] get_filtered(nitro_service service, string filter)
    {
      lbmonitor lbmonitor = new lbmonitor();
      options option = new options();
      option.set_filter(filter);
      return (lbmonitor[]) lbmonitor.getfiltered(service, option);
    }

    public static lbmonitor[] get_filtered(nitro_service service, filtervalue[] filter)
    {
      lbmonitor lbmonitor = new lbmonitor();
      options option = new options();
      option.set_filter(filter);
      return (lbmonitor[]) lbmonitor.getfiltered(service, option);
    }

    public static uint count(nitro_service service)
    {
      lbmonitor lbmonitor = new lbmonitor();
      options option = new options();
      option.set_count(true);
      lbmonitor[] resources = (lbmonitor[]) lbmonitor.get_resources(service, option);
      return resources != null && resources.Length > 0 ? resources[0].__count.Value : 0U;
    }

    public static uint count_filtered(nitro_service service, string filter)
    {
      lbmonitor lbmonitor = new lbmonitor();
      options option = new options();
      option.set_count(true);
      option.set_filter(filter);
      lbmonitor[] lbmonitorArray = (lbmonitor[]) lbmonitor.getfiltered(service, option);
      return lbmonitorArray != null && lbmonitorArray.Length > 0 ? lbmonitorArray[0].__count.Value : 0U;
    }

    public static uint count_filtered(nitro_service service, filtervalue[] filter)
    {
      lbmonitor lbmonitor = new lbmonitor();
      options option = new options();
      option.set_count(true);
      option.set_filter(filter);
      lbmonitor[] lbmonitorArray = (lbmonitor[]) lbmonitor.getfiltered(service, option);
      return lbmonitorArray != null && lbmonitorArray.Length > 0 ? lbmonitorArray[0].__count.Value : 0U;
    }

    private class lbmonitor_response : base_response
    {
      public lbmonitor[] lbmonitor = (lbmonitor[]) null;
    }

    public static class secureEnum
    {
      public const string YES = "YES";
      public const string NO = "NO";
    }

    public static class stateEnum
    {
      public const string ENABLED = "ENABLED";
      public const string DISABLED = "DISABLED";
    }

    public static class validatecredEnum
    {
      public const string YES = "YES";
      public const string NO = "NO";
    }

    public static class inbandsecurityidEnum
    {
      public const string NO_INBAND_SECURITY = "NO_INBAND_SECURITY";
      public const string TLS = "TLS";
    }

    public static class reverseEnum
    {
      public const string YES = "YES";
      public const string NO = "NO";
    }

    public static class sipmethodEnum
    {
      public const string OPTIONS = "OPTIONS";
      public const string INVITE = "INVITE";
      public const string REGISTER = "REGISTER";
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

    public static class lrtmEnum
    {
      public const string ENABLED = "ENABLED";
      public const string DISABLED = "DISABLED";
    }

    public static class iptunnelEnum
    {
      public const string YES = "YES";
      public const string NO = "NO";
    }

    public static class tosEnum
    {
      public const string YES = "YES";
      public const string NO = "NO";
    }

    public static class units3Enum
    {
      public const string SEC = "SEC";
      public const string MSEC = "MSEC";
      public const string MIN = "MIN";
    }

    public static class storedbEnum
    {
      public const string ENABLED = "ENABLED";
      public const string DISABLED = "DISABLED";
    }

    public static class transparentEnum
    {
      public const string YES = "YES";
      public const string NO = "NO";
    }

    public static class lrtmconfstrEnum
    {
      public const string ENABLED = "ENABLED";
      public const string DISABLED = "DISABLED";
    }

    public static class units1Enum
    {
      public const string SEC = "SEC";
      public const string MSEC = "MSEC";
      public const string MIN = "MIN";
    }

    public static class dup_stateEnum
    {
      public const string ENABLED = "ENABLED";
      public const string DISABLED = "DISABLED";
    }

    public static class storefrontacctserviceEnum
    {
      public const string YES = "YES";
      public const string NO = "NO";
    }

    public static class storefrontcheckbackendservicesEnum
    {
      public const string YES = "YES";
      public const string NO = "NO";
    }

    public static class units2Enum
    {
      public const string SEC = "SEC";
      public const string MSEC = "MSEC";
      public const string MIN = "MIN";
    }

    public static class units4Enum
    {
      public const string SEC = "SEC";
      public const string MSEC = "MSEC";
      public const string MIN = "MIN";
    }

    public static class actionEnum
    {
      public const string NONE = "NONE";
      public const string LOG = "LOG";
      public const string DOWN = "DOWN";
    }

    public static class mssqlprotocolversionEnum
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

    public static class snmpversionEnum
    {
      public const string V1 = "V1";
      public const string V2 = "V2";
    }

    public static class querytypeEnum
    {
      public const string Address = "Address";
      public const string Zone = "Zone";
      public const string AAAA = "AAAA";
    }
  }
}
