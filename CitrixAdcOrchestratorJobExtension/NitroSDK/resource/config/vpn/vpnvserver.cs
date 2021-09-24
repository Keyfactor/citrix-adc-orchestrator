// Decompiled with JetBrains decompiler
// Type: com.citrix.netscaler.nitro.resource.config.vpn.vpnvserver
// Assembly: nitro, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 6CF5DDEF-E052-4F9D-953F-6644F8378A66


using com.citrix.netscaler.nitro.exception;
using com.citrix.netscaler.nitro.resource.Base;
using com.citrix.netscaler.nitro.service;
using com.citrix.netscaler.nitro.util;

namespace com.citrix.netscaler.nitro.resource.config.vpn
{
  public class vpnvserver : base_resource
  {
    private string nameField = (string) null;
    private string servicetypeField = (string) null;
    private string ipv46Field = (string) null;
    private uint? rangeField = new uint?();
    private ushort? portField = new ushort?();
    private string stateField = (string) null;
    private string authenticationField = (string) null;
    private string doublehopField = (string) null;
    private uint? maxaaausersField = new uint?();
    private string icaonlyField = (string) null;
    private string icaproxysessionmigrationField = (string) null;
    private string dtlsField = (string) null;
    private string loginonceField = (string) null;
    private string advancedepaField = (string) null;
    private string devicecertField = (string) null;
    private string certkeynamesField = (string) null;
    private string downstateflushField = (string) null;
    private string listenpolicyField = (string) null;
    private uint? listenpriorityField = new uint?();
    private string tcpprofilenameField = (string) null;
    private string httpprofilenameField = (string) null;
    private string commentField = (string) null;
    private string appflowlogField = (string) null;
    private string icmpvsrresponseField = (string) null;
    private string rhistateField = (string) null;
    private string netprofileField = (string) null;
    private string cginfrahomepageredirectField = (string) null;
    private uint? maxloginattemptsField = new uint?();
    private uint? failedlogintimeoutField = new uint?();
    private string l2connField = (string) null;
    private string deploymenttypeField = (string) null;
    private string rdpserverprofilenameField = (string) null;
    private string windowsepapluginupgradeField = (string) null;
    private string linuxepapluginupgradeField = (string) null;
    private string macepapluginupgradeField = (string) null;
    private string userdomainsField = (string) null;
    private string newnameField = (string) null;
    private string ipField = (string) null;
    private string valueField = (string) null;
    private string typeField = (string) null;
    private string curstateField = (string) null;
    private int? statusField = new int?();
    private string cachetypeField = (string) null;
    private string redirectField = (string) null;
    private string precedenceField = (string) null;
    private string redirecturlField = (string) null;
    private uint? curaaausersField = new uint?();
    private uint? curtotalusersField = new uint?();
    private string domainField = (string) null;
    private string ruleField = (string) null;
    private string policyField = (string) null;
    private string servicenameField = (string) null;
    private uint? weightField = new uint?();
    private string cachevserverField = (string) null;
    private string backupvserverField = (string) null;
    private uint? priorityField = new uint?();
    private uint? clttimeoutField = new uint?();
    private string somethodField = (string) null;
    private uint? sothresholdField = new uint?();
    private string sopersistenceField = (string) null;
    private uint? sopersistencetimeoutField = new uint?();
    private string usemipField = (string) null;
    private string mapField = (string) null;
    private string bindpointField = (string) null;
    private string gotopriorityexpressionField = (string) null;
    private string disableprimaryondownField = (string) null;
    private bool? secondaryField = new bool?();
    private bool? groupextractionField = new bool?();
    private bool? epaprofileoptionalField = new bool?();
    private string ngnameField = (string) null;
    private string csvserverField = (string) null;
    private string responseField = (string) null;
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

    public string authentication
    {
      get => this.authenticationField;
      set => this.authenticationField = value;
    }

    public string doublehop
    {
      get => this.doublehopField;
      set => this.doublehopField = value;
    }

    public uint? maxaaausers
    {
      get => this.maxaaausersField;
      set => this.maxaaausersField = value;
    }

    public string icaonly
    {
      get => this.icaonlyField;
      set => this.icaonlyField = value;
    }

    public string icaproxysessionmigration
    {
      get => this.icaproxysessionmigrationField;
      set => this.icaproxysessionmigrationField = value;
    }

    public string dtls
    {
      get => this.dtlsField;
      set => this.dtlsField = value;
    }

    public string loginonce
    {
      get => this.loginonceField;
      set => this.loginonceField = value;
    }

    public string advancedepa
    {
      get => this.advancedepaField;
      set => this.advancedepaField = value;
    }

    public string devicecert
    {
      get => this.devicecertField;
      set => this.devicecertField = value;
    }

    public string certkeynames
    {
      get => this.certkeynamesField;
      set => this.certkeynamesField = value;
    }

    public string downstateflush
    {
      get => this.downstateflushField;
      set => this.downstateflushField = value;
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

    public string appflowlog
    {
      get => this.appflowlogField;
      set => this.appflowlogField = value;
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

    public string netprofile
    {
      get => this.netprofileField;
      set => this.netprofileField = value;
    }

    public string cginfrahomepageredirect
    {
      get => this.cginfrahomepageredirectField;
      set => this.cginfrahomepageredirectField = value;
    }

    public uint? maxloginattempts
    {
      get => this.maxloginattemptsField;
      set => this.maxloginattemptsField = value;
    }

    public uint? failedlogintimeout
    {
      get => this.failedlogintimeoutField;
      set => this.failedlogintimeoutField = value;
    }

    public string l2conn
    {
      get => this.l2connField;
      set => this.l2connField = value;
    }

    public string deploymenttype
    {
      get => this.deploymenttypeField;
      set => this.deploymenttypeField = value;
    }

    public string rdpserverprofilename
    {
      get => this.rdpserverprofilenameField;
      set => this.rdpserverprofilenameField = value;
    }

    public string windowsepapluginupgrade
    {
      get => this.windowsepapluginupgradeField;
      set => this.windowsepapluginupgradeField = value;
    }

    public string linuxepapluginupgrade
    {
      get => this.linuxepapluginupgradeField;
      set => this.linuxepapluginupgradeField = value;
    }

    public string macepapluginupgrade
    {
      get => this.macepapluginupgradeField;
      set => this.macepapluginupgradeField = value;
    }

    public string userdomains
    {
      get => this.userdomainsField;
      set => this.userdomainsField = value;
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

    public string precedence
    {
      get => this.precedenceField;
      private set => this.precedenceField = value;
    }

    public string redirecturl
    {
      get => this.redirecturlField;
      private set => this.redirecturlField = value;
    }

    public uint? curaaausers
    {
      get => this.curaaausersField;
      private set => this.curaaausersField = value;
    }

    public uint? curtotalusers
    {
      get => this.curtotalusersField;
      private set => this.curtotalusersField = value;
    }

    public string domain
    {
      get => this.domainField;
      private set => this.domainField = value;
    }

    public string rule
    {
      get => this.ruleField;
      private set => this.ruleField = value;
    }

    public string policy
    {
      get => this.policyField;
      private set => this.policyField = value;
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

    public string backupvserver
    {
      get => this.backupvserverField;
      private set => this.backupvserverField = value;
    }

    public uint? priority
    {
      get => this.priorityField;
      private set => this.priorityField = value;
    }

    public uint? clttimeout
    {
      get => this.clttimeoutField;
      private set => this.clttimeoutField = value;
    }

    public string somethod
    {
      get => this.somethodField;
      private set => this.somethodField = value;
    }

    public uint? sothreshold
    {
      get => this.sothresholdField;
      private set => this.sothresholdField = value;
    }

    public string sopersistence
    {
      get => this.sopersistenceField;
      private set => this.sopersistenceField = value;
    }

    public uint? sopersistencetimeout
    {
      get => this.sopersistencetimeoutField;
      private set => this.sopersistencetimeoutField = value;
    }

    public string usemip
    {
      get => this.usemipField;
      private set => this.usemipField = value;
    }

    public string map
    {
      get => this.mapField;
      private set => this.mapField = value;
    }

    public string bindpoint
    {
      get => this.bindpointField;
      private set => this.bindpointField = value;
    }

    public string gotopriorityexpression
    {
      get => this.gotopriorityexpressionField;
      private set => this.gotopriorityexpressionField = value;
    }

    public string disableprimaryondown
    {
      get => this.disableprimaryondownField;
      private set => this.disableprimaryondownField = value;
    }

    public bool? secondary
    {
      get => this.secondaryField;
      private set => this.secondaryField = value;
    }

    public bool? groupextraction
    {
      get => this.groupextractionField;
      private set => this.groupextractionField = value;
    }

    public bool? epaprofileoptional
    {
      get => this.epaprofileoptionalField;
      private set => this.epaprofileoptionalField = value;
    }

    public string ngname
    {
      get => this.ngnameField;
      private set => this.ngnameField = value;
    }

    public string csvserver
    {
      get => this.csvserverField;
      private set => this.csvserverField = value;
    }

    public string response
    {
      get => this.responseField;
      private set => this.responseField = value;
    }

    internal override base_resource[] get_nitro_response(
      nitro_service service,
      string response)
    {
      vpnvserver.vpnvserver_response vpnvserverResponse = new vpnvserver.vpnvserver_response();
      vpnvserver.vpnvserver_response resource = (vpnvserver.vpnvserver_response) service.get_payload_formatter().string_to_resource(vpnvserverResponse.GetType(), response);
      if (resource.errorcode != 0)
      {
        if (resource.errorcode == 444)
          service.clear_session();
        if (resource.severity == null)
          throw new nitro_exception(resource.message, resource.errorcode);
        if (resource.severity.Equals("ERROR"))
          throw new nitro_exception(resource.message, resource.errorcode);
      }
      return (base_resource[]) resource.vpnvserver;
    }

    internal override string get_object_name() => this.name;

    public static base_response add(nitro_service client, vpnvserver resource) => new vpnvserver()
    {
      name = resource.name,
      servicetype = resource.servicetype,
      ipv46 = resource.ipv46,
      range = resource.range,
      port = resource.port,
      state = resource.state,
      authentication = resource.authentication,
      doublehop = resource.doublehop,
      maxaaausers = resource.maxaaausers,
      icaonly = resource.icaonly,
      icaproxysessionmigration = resource.icaproxysessionmigration,
      dtls = resource.dtls,
      loginonce = resource.loginonce,
      advancedepa = resource.advancedepa,
      devicecert = resource.devicecert,
      certkeynames = resource.certkeynames,
      downstateflush = resource.downstateflush,
      listenpolicy = resource.listenpolicy,
      listenpriority = resource.listenpriority,
      tcpprofilename = resource.tcpprofilename,
      httpprofilename = resource.httpprofilename,
      comment = resource.comment,
      appflowlog = resource.appflowlog,
      icmpvsrresponse = resource.icmpvsrresponse,
      rhistate = resource.rhistate,
      netprofile = resource.netprofile,
      cginfrahomepageredirect = resource.cginfrahomepageredirect,
      maxloginattempts = resource.maxloginattempts,
      failedlogintimeout = resource.failedlogintimeout,
      l2conn = resource.l2conn,
      deploymenttype = resource.deploymenttype,
      rdpserverprofilename = resource.rdpserverprofilename,
      windowsepapluginupgrade = resource.windowsepapluginupgrade,
      linuxepapluginupgrade = resource.linuxepapluginupgrade,
      macepapluginupgrade = resource.macepapluginupgrade,
      userdomains = resource.userdomains
    }.add_resource(client);

    public static base_responses add(nitro_service client, vpnvserver[] resources)
    {
      base_responses baseResponses = (base_responses) null;
      if (resources != null && resources.Length > 0)
      {
        vpnvserver[] vpnvserverArray = new vpnvserver[resources.Length];
        for (int index = 0; index < resources.Length; ++index)
        {
          vpnvserverArray[index] = new vpnvserver();
          vpnvserverArray[index].name = resources[index].name;
          vpnvserverArray[index].servicetype = resources[index].servicetype;
          vpnvserverArray[index].ipv46 = resources[index].ipv46;
          vpnvserverArray[index].range = resources[index].range;
          vpnvserverArray[index].port = resources[index].port;
          vpnvserverArray[index].state = resources[index].state;
          vpnvserverArray[index].authentication = resources[index].authentication;
          vpnvserverArray[index].doublehop = resources[index].doublehop;
          vpnvserverArray[index].maxaaausers = resources[index].maxaaausers;
          vpnvserverArray[index].icaonly = resources[index].icaonly;
          vpnvserverArray[index].icaproxysessionmigration = resources[index].icaproxysessionmigration;
          vpnvserverArray[index].dtls = resources[index].dtls;
          vpnvserverArray[index].loginonce = resources[index].loginonce;
          vpnvserverArray[index].advancedepa = resources[index].advancedepa;
          vpnvserverArray[index].devicecert = resources[index].devicecert;
          vpnvserverArray[index].certkeynames = resources[index].certkeynames;
          vpnvserverArray[index].downstateflush = resources[index].downstateflush;
          vpnvserverArray[index].listenpolicy = resources[index].listenpolicy;
          vpnvserverArray[index].listenpriority = resources[index].listenpriority;
          vpnvserverArray[index].tcpprofilename = resources[index].tcpprofilename;
          vpnvserverArray[index].httpprofilename = resources[index].httpprofilename;
          vpnvserverArray[index].comment = resources[index].comment;
          vpnvserverArray[index].appflowlog = resources[index].appflowlog;
          vpnvserverArray[index].icmpvsrresponse = resources[index].icmpvsrresponse;
          vpnvserverArray[index].rhistate = resources[index].rhistate;
          vpnvserverArray[index].netprofile = resources[index].netprofile;
          vpnvserverArray[index].cginfrahomepageredirect = resources[index].cginfrahomepageredirect;
          vpnvserverArray[index].maxloginattempts = resources[index].maxloginattempts;
          vpnvserverArray[index].failedlogintimeout = resources[index].failedlogintimeout;
          vpnvserverArray[index].l2conn = resources[index].l2conn;
          vpnvserverArray[index].deploymenttype = resources[index].deploymenttype;
          vpnvserverArray[index].rdpserverprofilename = resources[index].rdpserverprofilename;
          vpnvserverArray[index].windowsepapluginupgrade = resources[index].windowsepapluginupgrade;
          vpnvserverArray[index].linuxepapluginupgrade = resources[index].linuxepapluginupgrade;
          vpnvserverArray[index].macepapluginupgrade = resources[index].macepapluginupgrade;
          vpnvserverArray[index].userdomains = resources[index].userdomains;
        }
        baseResponses = base_resource.add_bulk_request(client, (base_resource[]) vpnvserverArray);
      }
      return baseResponses;
    }

    public static base_response delete(nitro_service client, string name) => new vpnvserver()
    {
      name = name
    }.delete_resource(client);

    public static base_response delete(nitro_service client, vpnvserver resource) => new vpnvserver()
    {
      name = resource.name
    }.delete_resource(client);

    public static base_responses delete(nitro_service client, string[] name)
    {
      base_responses baseResponses = (base_responses) null;
      if (name != null && name.Length > 0)
      {
        vpnvserver[] vpnvserverArray = new vpnvserver[name.Length];
        for (int index = 0; index < name.Length; ++index)
        {
          vpnvserverArray[index] = new vpnvserver();
          vpnvserverArray[index].name = name[index];
        }
        baseResponses = base_resource.delete_bulk_request(client, (base_resource[]) vpnvserverArray);
      }
      return baseResponses;
    }

    public static base_responses delete(nitro_service client, vpnvserver[] resources)
    {
      base_responses baseResponses = (base_responses) null;
      if (resources != null && resources.Length > 0)
      {
        vpnvserver[] vpnvserverArray = new vpnvserver[resources.Length];
        for (int index = 0; index < resources.Length; ++index)
        {
          vpnvserverArray[index] = new vpnvserver();
          vpnvserverArray[index].name = resources[index].name;
        }
        baseResponses = base_resource.delete_bulk_request(client, (base_resource[]) vpnvserverArray);
      }
      return baseResponses;
    }

    public static base_response update(nitro_service client, vpnvserver resource) => new vpnvserver()
    {
      name = resource.name,
      ipv46 = resource.ipv46,
      authentication = resource.authentication,
      doublehop = resource.doublehop,
      icaonly = resource.icaonly,
      icaproxysessionmigration = resource.icaproxysessionmigration,
      dtls = resource.dtls,
      loginonce = resource.loginonce,
      advancedepa = resource.advancedepa,
      devicecert = resource.devicecert,
      certkeynames = resource.certkeynames,
      maxaaausers = resource.maxaaausers,
      downstateflush = resource.downstateflush,
      listenpolicy = resource.listenpolicy,
      listenpriority = resource.listenpriority,
      tcpprofilename = resource.tcpprofilename,
      httpprofilename = resource.httpprofilename,
      comment = resource.comment,
      appflowlog = resource.appflowlog,
      icmpvsrresponse = resource.icmpvsrresponse,
      rhistate = resource.rhistate,
      netprofile = resource.netprofile,
      cginfrahomepageredirect = resource.cginfrahomepageredirect,
      maxloginattempts = resource.maxloginattempts,
      rdpserverprofilename = resource.rdpserverprofilename,
      failedlogintimeout = resource.failedlogintimeout,
      l2conn = resource.l2conn,
      windowsepapluginupgrade = resource.windowsepapluginupgrade,
      macepapluginupgrade = resource.macepapluginupgrade,
      linuxepapluginupgrade = resource.linuxepapluginupgrade,
      userdomains = resource.userdomains
    }.update_resource(client);

    public static base_responses update(nitro_service client, vpnvserver[] resources)
    {
      base_responses baseResponses = (base_responses) null;
      if (resources != null && resources.Length > 0)
      {
        vpnvserver[] vpnvserverArray = new vpnvserver[resources.Length];
        for (int index = 0; index < resources.Length; ++index)
        {
          vpnvserverArray[index] = new vpnvserver();
          vpnvserverArray[index].name = resources[index].name;
          vpnvserverArray[index].ipv46 = resources[index].ipv46;
          vpnvserverArray[index].authentication = resources[index].authentication;
          vpnvserverArray[index].doublehop = resources[index].doublehop;
          vpnvserverArray[index].icaonly = resources[index].icaonly;
          vpnvserverArray[index].icaproxysessionmigration = resources[index].icaproxysessionmigration;
          vpnvserverArray[index].dtls = resources[index].dtls;
          vpnvserverArray[index].loginonce = resources[index].loginonce;
          vpnvserverArray[index].advancedepa = resources[index].advancedepa;
          vpnvserverArray[index].devicecert = resources[index].devicecert;
          vpnvserverArray[index].certkeynames = resources[index].certkeynames;
          vpnvserverArray[index].maxaaausers = resources[index].maxaaausers;
          vpnvserverArray[index].downstateflush = resources[index].downstateflush;
          vpnvserverArray[index].listenpolicy = resources[index].listenpolicy;
          vpnvserverArray[index].listenpriority = resources[index].listenpriority;
          vpnvserverArray[index].tcpprofilename = resources[index].tcpprofilename;
          vpnvserverArray[index].httpprofilename = resources[index].httpprofilename;
          vpnvserverArray[index].comment = resources[index].comment;
          vpnvserverArray[index].appflowlog = resources[index].appflowlog;
          vpnvserverArray[index].icmpvsrresponse = resources[index].icmpvsrresponse;
          vpnvserverArray[index].rhistate = resources[index].rhistate;
          vpnvserverArray[index].netprofile = resources[index].netprofile;
          vpnvserverArray[index].cginfrahomepageredirect = resources[index].cginfrahomepageredirect;
          vpnvserverArray[index].maxloginattempts = resources[index].maxloginattempts;
          vpnvserverArray[index].rdpserverprofilename = resources[index].rdpserverprofilename;
          vpnvserverArray[index].failedlogintimeout = resources[index].failedlogintimeout;
          vpnvserverArray[index].l2conn = resources[index].l2conn;
          vpnvserverArray[index].windowsepapluginupgrade = resources[index].windowsepapluginupgrade;
          vpnvserverArray[index].macepapluginupgrade = resources[index].macepapluginupgrade;
          vpnvserverArray[index].linuxepapluginupgrade = resources[index].linuxepapluginupgrade;
          vpnvserverArray[index].userdomains = resources[index].userdomains;
        }
        baseResponses = base_resource.update_bulk_request(client, (base_resource[]) vpnvserverArray);
      }
      return baseResponses;
    }

    public static base_response unset(
      nitro_service client,
      string name,
      string[] args)
    {
      return new vpnvserver() { name = name }.unset_resource(client, args);
    }

    public static base_response unset(
      nitro_service client,
      vpnvserver resource,
      string[] args)
    {
      return new vpnvserver() { name = resource.name }.unset_resource(client, args);
    }

    public static base_responses unset(
      nitro_service client,
      string[] name,
      string[] args)
    {
      base_responses baseResponses = (base_responses) null;
      if (name != null && name.Length > 0)
      {
        vpnvserver[] vpnvserverArray = new vpnvserver[name.Length];
        for (int index = 0; index < name.Length; ++index)
        {
          vpnvserverArray[index] = new vpnvserver();
          vpnvserverArray[index].name = name[index];
        }
        baseResponses = base_resource.unset_bulk_request(client, (base_resource[]) vpnvserverArray, args);
      }
      return baseResponses;
    }

    public static base_responses unset(
      nitro_service client,
      vpnvserver[] resources,
      string[] args)
    {
      base_responses baseResponses = (base_responses) null;
      if (resources != null && resources.Length > 0)
      {
        vpnvserver[] vpnvserverArray = new vpnvserver[resources.Length];
        for (int index = 0; index < resources.Length; ++index)
        {
          vpnvserverArray[index] = new vpnvserver();
          vpnvserverArray[index].name = resources[index].name;
        }
        baseResponses = base_resource.unset_bulk_request(client, (base_resource[]) vpnvserverArray, args);
      }
      return baseResponses;
    }

    public static base_response enable(nitro_service client, string name) => new vpnvserver()
    {
      name = name
    }.perform_operation_byaction(client, nameof (enable));

    public static base_response enable(nitro_service client, vpnvserver resource) => new vpnvserver()
    {
      name = resource.name
    }.perform_operation_byaction(client, nameof (enable));

    public static base_responses enable(nitro_service client, string[] name)
    {
      base_responses baseResponses = (base_responses) null;
      if (name != null && name.Length > 0)
      {
        vpnvserver[] vpnvserverArray = new vpnvserver[name.Length];
        for (int index = 0; index < name.Length; ++index)
        {
          vpnvserverArray[index] = new vpnvserver();
          vpnvserverArray[index].name = name[index];
        }
        baseResponses = base_resource.perform_operation_bulk_request(client, (base_resource[]) vpnvserverArray, nameof (enable));
      }
      return baseResponses;
    }

    public static base_responses enable(nitro_service client, vpnvserver[] resources)
    {
      base_responses baseResponses = (base_responses) null;
      if (resources != null && resources.Length > 0)
      {
        vpnvserver[] vpnvserverArray = new vpnvserver[resources.Length];
        for (int index = 0; index < resources.Length; ++index)
        {
          vpnvserverArray[index] = new vpnvserver();
          vpnvserverArray[index].name = resources[index].name;
        }
        baseResponses = base_resource.perform_operation_bulk_request(client, (base_resource[]) vpnvserverArray, nameof (enable));
      }
      return baseResponses;
    }

    public static base_response disable(nitro_service client, string name) => new vpnvserver()
    {
      name = name
    }.perform_operation_byaction(client, nameof (disable));

    public static base_response disable(nitro_service client, vpnvserver resource) => new vpnvserver()
    {
      name = resource.name
    }.perform_operation_byaction(client, nameof (disable));

    public static base_responses disable(nitro_service client, string[] name)
    {
      base_responses baseResponses = (base_responses) null;
      if (name != null && name.Length > 0)
      {
        vpnvserver[] vpnvserverArray = new vpnvserver[name.Length];
        for (int index = 0; index < name.Length; ++index)
        {
          vpnvserverArray[index] = new vpnvserver();
          vpnvserverArray[index].name = name[index];
        }
        baseResponses = base_resource.perform_operation_bulk_request(client, (base_resource[]) vpnvserverArray, nameof (disable));
      }
      return baseResponses;
    }

    public static base_responses disable(nitro_service client, vpnvserver[] resources)
    {
      base_responses baseResponses = (base_responses) null;
      if (resources != null && resources.Length > 0)
      {
        vpnvserver[] vpnvserverArray = new vpnvserver[resources.Length];
        for (int index = 0; index < resources.Length; ++index)
        {
          vpnvserverArray[index] = new vpnvserver();
          vpnvserverArray[index].name = resources[index].name;
        }
        baseResponses = base_resource.perform_operation_bulk_request(client, (base_resource[]) vpnvserverArray, nameof (disable));
      }
      return baseResponses;
    }

    public static base_response rename(
      nitro_service client,
      vpnvserver resource,
      string new_name)
    {
      return new vpnvserver()
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
      return new vpnvserver()
      {
        name = name,
        newname = new_name
      }.rename_resource(client);
    }

    public static vpnvserver check(nitro_service client, vpnvserver resource) => (vpnvserver) new vpnvserver()
    {
      name = resource.name
    }.perform_operation_byactionEx(client, nameof (check));

    public static base_responses check(nitro_service client, vpnvserver[] resources)
    {
      base_responses baseResponses = (base_responses) null;
      if (resources != null && resources.Length > 0)
      {
        vpnvserver[] vpnvserverArray = new vpnvserver[resources.Length];
        for (int index = 0; index < resources.Length; ++index)
        {
          vpnvserverArray[index] = new vpnvserver();
          vpnvserverArray[index].name = resources[index].name;
        }
        baseResponses = base_resource.perform_operation_bulk_request(client, (base_resource[]) vpnvserverArray, nameof (check));
      }
      return baseResponses;
    }

    public static vpnvserver[] get(nitro_service service) => (vpnvserver[]) new vpnvserver().get_resources(service, (options) null);

    public static vpnvserver[] get(nitro_service service, options option) => (vpnvserver[]) new vpnvserver().get_resources(service, option);

    public static vpnvserver get(nitro_service service, string name) => (vpnvserver) new vpnvserver()
    {
      name = name
    }.get_resource(service);

    public static vpnvserver[] get(nitro_service service, string[] name)
    {
      if (name == null || name.Length <= 0)
        return (vpnvserver[]) null;
      vpnvserver[] vpnvserverArray1 = new vpnvserver[name.Length];
      vpnvserver[] vpnvserverArray2 = new vpnvserver[name.Length];
      for (int index = 0; index < name.Length; ++index)
      {
        vpnvserverArray2[index] = new vpnvserver();
        vpnvserverArray2[index].name = name[index];
        vpnvserverArray1[index] = (vpnvserver) vpnvserverArray2[index].get_resource(service);
      }
      return vpnvserverArray1;
    }

    public static vpnvserver[] get_filtered(nitro_service service, string filter)
    {
      vpnvserver vpnvserver = new vpnvserver();
      options option = new options();
      option.set_filter(filter);
      return (vpnvserver[]) vpnvserver.getfiltered(service, option);
    }

    public static vpnvserver[] get_filtered(nitro_service service, filtervalue[] filter)
    {
      vpnvserver vpnvserver = new vpnvserver();
      options option = new options();
      option.set_filter(filter);
      return (vpnvserver[]) vpnvserver.getfiltered(service, option);
    }

    public static uint count(nitro_service service)
    {
      vpnvserver vpnvserver = new vpnvserver();
      options option = new options();
      option.set_count(true);
      vpnvserver[] resources = (vpnvserver[]) vpnvserver.get_resources(service, option);
      return resources != null && resources.Length > 0 ? resources[0].__count.Value : 0U;
    }

    public static uint count_filtered(nitro_service service, string filter)
    {
      vpnvserver vpnvserver = new vpnvserver();
      options option = new options();
      option.set_count(true);
      option.set_filter(filter);
      vpnvserver[] vpnvserverArray = (vpnvserver[]) vpnvserver.getfiltered(service, option);
      return vpnvserverArray != null && vpnvserverArray.Length > 0 ? vpnvserverArray[0].__count.Value : 0U;
    }

    public static uint count_filtered(nitro_service service, filtervalue[] filter)
    {
      vpnvserver vpnvserver = new vpnvserver();
      options option = new options();
      option.set_count(true);
      option.set_filter(filter);
      vpnvserver[] vpnvserverArray = (vpnvserver[]) vpnvserver.getfiltered(service, option);
      return vpnvserverArray != null && vpnvserverArray.Length > 0 ? vpnvserverArray[0].__count.Value : 0U;
    }

    private class vpnvserver_response : base_response
    {
      public vpnvserver[] vpnvserver = (vpnvserver[]) null;
    }

    public static class icaonlyEnum
    {
      public const string ON = "ON";
      public const string OFF = "OFF";
    }

    public static class cginfrahomepageredirectEnum
    {
      public const string ENABLED = "ENABLED";
      public const string DISABLED = "DISABLED";
    }

    public static class rhistateEnum
    {
      public const string PASSIVE = "PASSIVE";
      public const string ACTIVE = "ACTIVE";
    }

    public static class deploymenttypeEnum
    {
      public const string NONE = "NONE";
      public const string ICA_WEBINTERFACE = "ICA_WEBINTERFACE";
      public const string ICA_STOREFRONT = "ICA_STOREFRONT";
      public const string MOBILITY = "MOBILITY";
      public const string WIONNS = "WIONNS";
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

    public static class devicecertEnum
    {
      public const string ON = "ON";
      public const string OFF = "OFF";
    }

    public static class loginonceEnum
    {
      public const string ON = "ON";
      public const string OFF = "OFF";
    }

    public static class downstateflushEnum
    {
      public const string ENABLED = "ENABLED";
      public const string DISABLED = "DISABLED";
    }

    public static class servicetypeEnum
    {
      public const string SSL = "SSL";
    }

    public static class icmpvsrresponseEnum
    {
      public const string PASSIVE = "PASSIVE";
      public const string ACTIVE = "ACTIVE";
    }

    public static class usemipEnum
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

    public static class icaproxysessionmigrationEnum
    {
      public const string ON = "ON";
      public const string OFF = "OFF";
    }

    public static class disableprimaryondownEnum
    {
      public const string ENABLED = "ENABLED";
      public const string DISABLED = "DISABLED";
    }

    public static class typeEnum
    {
      public const string CONTENT = "CONTENT";
      public const string ADDRESS = "ADDRESS";
    }

    public static class macepapluginupgradeEnum
    {
      public const string Always = "Always";
      public const string Essential = "Essential";
      public const string Never = "Never";
    }

    public static class advancedepaEnum
    {
      public const string ON = "ON";
      public const string OFF = "OFF";
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
      public const string OTHERTCP_REQUEST = "OTHERTCP_REQUEST";
    }

    public static class sopersistenceEnum
    {
      public const string ENABLED = "ENABLED";
      public const string DISABLED = "DISABLED";
    }

    public static class linuxepapluginupgradeEnum
    {
      public const string Always = "Always";
      public const string Essential = "Essential";
      public const string Never = "Never";
    }

    public static class redirectEnum
    {
      public const string CACHE = "CACHE";
      public const string POLICY = "POLICY";
      public const string ORIGIN = "ORIGIN";
    }

    public static class windowsepapluginupgradeEnum
    {
      public const string Always = "Always";
      public const string Essential = "Essential";
      public const string Never = "Never";
    }

    public static class dtlsEnum
    {
      public const string ON = "ON";
      public const string OFF = "OFF";
    }

    public static class doublehopEnum
    {
      public const string ENABLED = "ENABLED";
      public const string DISABLED = "DISABLED";
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
  }
}
