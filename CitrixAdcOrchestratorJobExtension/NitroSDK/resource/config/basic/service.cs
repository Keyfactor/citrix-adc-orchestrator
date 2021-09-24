// Decompiled with JetBrains decompiler
// Type: com.citrix.netscaler.nitro.resource.config.basic.service
// Assembly: nitro, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 6CF5DDEF-E052-4F9D-953F-6644F8378A66


using com.citrix.netscaler.nitro.exception;
using com.citrix.netscaler.nitro.resource.Base;
using com.citrix.netscaler.nitro.service;
using com.citrix.netscaler.nitro.util;

namespace com.citrix.netscaler.nitro.resource.config.basic
{
  public class service : base_resource
  {
    private string nameField = (string) null;
    private string ipField = (string) null;
    private string servernameField = (string) null;
    private string servicetypeField = (string) null;
    private ushort? portField = new ushort?();
    private ushort? cleartextportField = new ushort?();
    private string cachetypeField = (string) null;
    private uint? maxclientField = new uint?();
    private string healthmonitorField = (string) null;
    private uint? maxreqField = new uint?();
    private string cacheableField = (string) null;
    private string cipField = (string) null;
    private string cipheaderField = (string) null;
    private string usipField = (string) null;
    private string pathmonitorField = (string) null;
    private string pathmonitorindvField = (string) null;
    private string useproxyportField = (string) null;
    private string scField = (string) null;
    private string spField = (string) null;
    private string rtspsessionidremapField = (string) null;
    private long? clttimeoutField = new long?();
    private long? svrtimeoutField = new long?();
    private string customserveridField = (string) null;
    private uint? serveridField = new uint?();
    private string ckaField = (string) null;
    private string tcpbField = (string) null;
    private string cmpField = (string) null;
    private uint? maxbandwidthField = new uint?();
    private string accessdownField = (string) null;
    private uint? monthresholdField = new uint?();
    private string stateField = (string) null;
    private string downstateflushField = (string) null;
    private string tcpprofilenameField = (string) null;
    private string httpprofilenameField = (string) null;
    private uint? hashidField = new uint?();
    private string commentField = (string) null;
    private string appflowlogField = (string) null;
    private string netprofileField = (string) null;
    private uint? tdField = new uint?();
    private string processlocalField = (string) null;
    private string dnsprofilenameField = (string) null;
    private string ipaddressField = (string) null;
    private uint? weightField = new uint?();
    private string monitor_name_svcField = (string) null;
    private int? riseapbrstatsmsgcodeField = new int?();
    private long? delayField = new long?();
    private string gracefulField = (string) null;
    private bool? allField = new bool?();
    private bool? InternalField = new bool?();
    private string newnameField = (string) null;
    private int? numofconnectionsField = new int?();
    private string policynameField = (string) null;
    private bool? serviceconftypeField = new bool?();
    private string serviceconftype2Field = (string) null;
    private string valueField = (string) null;
    private string gslbField = (string) null;
    private string dup_stateField = (string) null;
    private string publicipField = (string) null;
    private ushort? publicportField = new ushort?();
    private string svrstateField = (string) null;
    private string monitor_stateField = (string) null;
    private int? monstatcodeField = new int?();
    private string lastresponseField = (string) null;
    private long? responsetimeField = new long?();
    private int? riseapbrstatsmsgcode2Field = new int?();
    private int? monstatparam1Field = new int?();
    private int? monstatparam2Field = new int?();
    private int? monstatparam3Field = new int?();
    private string statechangetimesecField = (string) null;
    private uint? statechangetimemsecField = new uint?();
    private uint? tickssincelaststatechangeField = new uint?();
    private uint? stateupdatereasonField = new uint?();
    private uint? clmonownerField = new uint?();
    private uint? clmonviewField = new uint?();
    private string serviceipstrField = (string) null;
    private string oracleserverversionField = (string) null;
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

    public ushort? cleartextport
    {
      get => this.cleartextportField;
      set => this.cleartextportField = value;
    }

    public string cachetype
    {
      get => this.cachetypeField;
      set => this.cachetypeField = value;
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

    public uint? maxreq
    {
      get => this.maxreqField;
      set => this.maxreqField = value;
    }

    public string cacheable
    {
      get => this.cacheableField;
      set => this.cacheableField = value;
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

    public string usip
    {
      get => this.usipField;
      set => this.usipField = value;
    }

    public string pathmonitor
    {
      get => this.pathmonitorField;
      set => this.pathmonitorField = value;
    }

    public string pathmonitorindv
    {
      get => this.pathmonitorindvField;
      set => this.pathmonitorindvField = value;
    }

    public string useproxyport
    {
      get => this.useproxyportField;
      set => this.useproxyportField = value;
    }

    public string sc
    {
      get => this.scField;
      set => this.scField = value;
    }

    public string sp
    {
      get => this.spField;
      set => this.spField = value;
    }

    public string rtspsessionidremap
    {
      get => this.rtspsessionidremapField;
      set => this.rtspsessionidremapField = value;
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

    public string customserverid
    {
      get => this.customserveridField;
      set => this.customserveridField = value;
    }

    public uint? serverid
    {
      get => this.serveridField;
      set => this.serveridField = value;
    }

    public string cka
    {
      get => this.ckaField;
      set => this.ckaField = value;
    }

    public string tcpb
    {
      get => this.tcpbField;
      set => this.tcpbField = value;
    }

    public string cmp
    {
      get => this.cmpField;
      set => this.cmpField = value;
    }

    public uint? maxbandwidth
    {
      get => this.maxbandwidthField;
      set => this.maxbandwidthField = value;
    }

    public string accessdown
    {
      get => this.accessdownField;
      set => this.accessdownField = value;
    }

    public uint? monthreshold
    {
      get => this.monthresholdField;
      set => this.monthresholdField = value;
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

    public string netprofile
    {
      get => this.netprofileField;
      set => this.netprofileField = value;
    }

    public uint? td
    {
      get => this.tdField;
      set => this.tdField = value;
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

    public string ipaddress
    {
      get => this.ipaddressField;
      set => this.ipaddressField = value;
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

    public int? riseapbrstatsmsgcode
    {
      get => this.riseapbrstatsmsgcodeField;
      set => this.riseapbrstatsmsgcodeField = value;
    }

    public long? delay
    {
      get => this.delayField;
      set => this.delayField = value;
    }

    public string graceful
    {
      get => this.gracefulField;
      set => this.gracefulField = value;
    }

    public bool? all
    {
      get => this.allField;
      set => this.allField = value;
    }

    public bool? Internal
    {
      get => this.InternalField;
      set => this.InternalField = value;
    }

    public string newname
    {
      get => this.newnameField;
      set => this.newnameField = value;
    }

    public int? numofconnections
    {
      get => this.numofconnectionsField;
      private set => this.numofconnectionsField = value;
    }

    public string policyname
    {
      get => this.policynameField;
      private set => this.policynameField = value;
    }

    public bool? serviceconftype
    {
      get => this.serviceconftypeField;
      private set => this.serviceconftypeField = value;
    }

    public string serviceconftype2
    {
      get => this.serviceconftype2Field;
      private set => this.serviceconftype2Field = value;
    }

    public string value
    {
      get => this.valueField;
      private set => this.valueField = value;
    }

    public string gslb
    {
      get => this.gslbField;
      private set => this.gslbField = value;
    }

    public string dup_state
    {
      get => this.dup_stateField;
      private set => this.dup_stateField = value;
    }

    public string publicip
    {
      get => this.publicipField;
      private set => this.publicipField = value;
    }

    public ushort? publicport
    {
      get => this.publicportField;
      private set => this.publicportField = value;
    }

    public string svrstate
    {
      get => this.svrstateField;
      private set => this.svrstateField = value;
    }

    public string monitor_state
    {
      get => this.monitor_stateField;
      private set => this.monitor_stateField = value;
    }

    public int? monstatcode
    {
      get => this.monstatcodeField;
      private set => this.monstatcodeField = value;
    }

    public string lastresponse
    {
      get => this.lastresponseField;
      private set => this.lastresponseField = value;
    }

    public long? responsetime
    {
      get => this.responsetimeField;
      private set => this.responsetimeField = value;
    }

    public int? riseapbrstatsmsgcode2
    {
      get => this.riseapbrstatsmsgcode2Field;
      private set => this.riseapbrstatsmsgcode2Field = value;
    }

    public int? monstatparam1
    {
      get => this.monstatparam1Field;
      private set => this.monstatparam1Field = value;
    }

    public int? monstatparam2
    {
      get => this.monstatparam2Field;
      private set => this.monstatparam2Field = value;
    }

    public int? monstatparam3
    {
      get => this.monstatparam3Field;
      private set => this.monstatparam3Field = value;
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

    public uint? stateupdatereason
    {
      get => this.stateupdatereasonField;
      private set => this.stateupdatereasonField = value;
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

    public string serviceipstr
    {
      get => this.serviceipstrField;
      private set => this.serviceipstrField = value;
    }

    public string oracleserverversion
    {
      get => this.oracleserverversionField;
      private set => this.oracleserverversionField = value;
    }

    internal override base_resource[] get_nitro_response(
      nitro_service service,
      string response)
    {
      com.citrix.netscaler.nitro.resource.config.basic.service.service_response serviceResponse = new com.citrix.netscaler.nitro.resource.config.basic.service.service_response();
      com.citrix.netscaler.nitro.resource.config.basic.service.service_response resource = (com.citrix.netscaler.nitro.resource.config.basic.service.service_response) service.get_payload_formatter().string_to_resource(serviceResponse.GetType(), response);
      if (resource.errorcode != 0)
      {
        if (resource.errorcode == 444)
          service.clear_session();
        if (resource.severity == null)
          throw new nitro_exception(resource.message, resource.errorcode);
        if (resource.severity.Equals("ERROR"))
          throw new nitro_exception(resource.message, resource.errorcode);
      }
      return (base_resource[]) resource.service;
    }

    internal override string get_object_name() => this.name;

    public static base_response add(nitro_service client, com.citrix.netscaler.nitro.resource.config.basic.service resource) => new com.citrix.netscaler.nitro.resource.config.basic.service()
    {
      name = resource.name,
      ip = resource.ip,
      servername = resource.servername,
      servicetype = resource.servicetype,
      port = resource.port,
      cleartextport = resource.cleartextport,
      cachetype = resource.cachetype,
      maxclient = resource.maxclient,
      healthmonitor = resource.healthmonitor,
      maxreq = resource.maxreq,
      cacheable = resource.cacheable,
      cip = resource.cip,
      cipheader = resource.cipheader,
      usip = resource.usip,
      pathmonitor = resource.pathmonitor,
      pathmonitorindv = resource.pathmonitorindv,
      useproxyport = resource.useproxyport,
      sc = resource.sc,
      sp = resource.sp,
      rtspsessionidremap = resource.rtspsessionidremap,
      clttimeout = resource.clttimeout,
      svrtimeout = resource.svrtimeout,
      customserverid = resource.customserverid,
      serverid = resource.serverid,
      cka = resource.cka,
      tcpb = resource.tcpb,
      cmp = resource.cmp,
      maxbandwidth = resource.maxbandwidth,
      accessdown = resource.accessdown,
      monthreshold = resource.monthreshold,
      state = resource.state,
      downstateflush = resource.downstateflush,
      tcpprofilename = resource.tcpprofilename,
      httpprofilename = resource.httpprofilename,
      hashid = resource.hashid,
      comment = resource.comment,
      appflowlog = resource.appflowlog,
      netprofile = resource.netprofile,
      td = resource.td,
      processlocal = resource.processlocal,
      dnsprofilename = resource.dnsprofilename
    }.add_resource(client);

    public static base_responses add(nitro_service client, com.citrix.netscaler.nitro.resource.config.basic.service[] resources)
    {
      base_responses baseResponses = (base_responses) null;
      if (resources != null && resources.Length > 0)
      {
        com.citrix.netscaler.nitro.resource.config.basic.service[] serviceArray = new com.citrix.netscaler.nitro.resource.config.basic.service[resources.Length];
        for (int index = 0; index < resources.Length; ++index)
        {
          serviceArray[index] = new com.citrix.netscaler.nitro.resource.config.basic.service();
          serviceArray[index].name = resources[index].name;
          serviceArray[index].ip = resources[index].ip;
          serviceArray[index].servername = resources[index].servername;
          serviceArray[index].servicetype = resources[index].servicetype;
          serviceArray[index].port = resources[index].port;
          serviceArray[index].cleartextport = resources[index].cleartextport;
          serviceArray[index].cachetype = resources[index].cachetype;
          serviceArray[index].maxclient = resources[index].maxclient;
          serviceArray[index].healthmonitor = resources[index].healthmonitor;
          serviceArray[index].maxreq = resources[index].maxreq;
          serviceArray[index].cacheable = resources[index].cacheable;
          serviceArray[index].cip = resources[index].cip;
          serviceArray[index].cipheader = resources[index].cipheader;
          serviceArray[index].usip = resources[index].usip;
          serviceArray[index].pathmonitor = resources[index].pathmonitor;
          serviceArray[index].pathmonitorindv = resources[index].pathmonitorindv;
          serviceArray[index].useproxyport = resources[index].useproxyport;
          serviceArray[index].sc = resources[index].sc;
          serviceArray[index].sp = resources[index].sp;
          serviceArray[index].rtspsessionidremap = resources[index].rtspsessionidremap;
          serviceArray[index].clttimeout = resources[index].clttimeout;
          serviceArray[index].svrtimeout = resources[index].svrtimeout;
          serviceArray[index].customserverid = resources[index].customserverid;
          serviceArray[index].serverid = resources[index].serverid;
          serviceArray[index].cka = resources[index].cka;
          serviceArray[index].tcpb = resources[index].tcpb;
          serviceArray[index].cmp = resources[index].cmp;
          serviceArray[index].maxbandwidth = resources[index].maxbandwidth;
          serviceArray[index].accessdown = resources[index].accessdown;
          serviceArray[index].monthreshold = resources[index].monthreshold;
          serviceArray[index].state = resources[index].state;
          serviceArray[index].downstateflush = resources[index].downstateflush;
          serviceArray[index].tcpprofilename = resources[index].tcpprofilename;
          serviceArray[index].httpprofilename = resources[index].httpprofilename;
          serviceArray[index].hashid = resources[index].hashid;
          serviceArray[index].comment = resources[index].comment;
          serviceArray[index].appflowlog = resources[index].appflowlog;
          serviceArray[index].netprofile = resources[index].netprofile;
          serviceArray[index].td = resources[index].td;
          serviceArray[index].processlocal = resources[index].processlocal;
          serviceArray[index].dnsprofilename = resources[index].dnsprofilename;
        }
        baseResponses = base_resource.add_bulk_request(client, (base_resource[]) serviceArray);
      }
      return baseResponses;
    }

    public static base_response delete(nitro_service client, string name) => new com.citrix.netscaler.nitro.resource.config.basic.service()
    {
      name = name
    }.delete_resource(client);

    public static base_response delete(nitro_service client, com.citrix.netscaler.nitro.resource.config.basic.service resource) => new com.citrix.netscaler.nitro.resource.config.basic.service()
    {
      name = resource.name
    }.delete_resource(client);

    public static base_responses delete(nitro_service client, string[] name)
    {
      base_responses baseResponses = (base_responses) null;
      if (name != null && name.Length > 0)
      {
        com.citrix.netscaler.nitro.resource.config.basic.service[] serviceArray = new com.citrix.netscaler.nitro.resource.config.basic.service[name.Length];
        for (int index = 0; index < name.Length; ++index)
        {
          serviceArray[index] = new com.citrix.netscaler.nitro.resource.config.basic.service();
          serviceArray[index].name = name[index];
        }
        baseResponses = base_resource.delete_bulk_request(client, (base_resource[]) serviceArray);
      }
      return baseResponses;
    }

    public static base_responses delete(nitro_service client, com.citrix.netscaler.nitro.resource.config.basic.service[] resources)
    {
      base_responses baseResponses = (base_responses) null;
      if (resources != null && resources.Length > 0)
      {
        com.citrix.netscaler.nitro.resource.config.basic.service[] serviceArray = new com.citrix.netscaler.nitro.resource.config.basic.service[resources.Length];
        for (int index = 0; index < resources.Length; ++index)
        {
          serviceArray[index] = new com.citrix.netscaler.nitro.resource.config.basic.service();
          serviceArray[index].name = resources[index].name;
        }
        baseResponses = base_resource.delete_bulk_request(client, (base_resource[]) serviceArray);
      }
      return baseResponses;
    }

    public static base_response update(nitro_service client, com.citrix.netscaler.nitro.resource.config.basic.service resource) => new com.citrix.netscaler.nitro.resource.config.basic.service()
    {
      name = resource.name,
      ipaddress = resource.ipaddress,
      maxclient = resource.maxclient,
      maxreq = resource.maxreq,
      cacheable = resource.cacheable,
      cip = resource.cip,
      cipheader = resource.cipheader,
      usip = resource.usip,
      pathmonitor = resource.pathmonitor,
      pathmonitorindv = resource.pathmonitorindv,
      useproxyport = resource.useproxyport,
      sc = resource.sc,
      sp = resource.sp,
      rtspsessionidremap = resource.rtspsessionidremap,
      healthmonitor = resource.healthmonitor,
      clttimeout = resource.clttimeout,
      svrtimeout = resource.svrtimeout,
      customserverid = resource.customserverid,
      serverid = resource.serverid,
      cka = resource.cka,
      tcpb = resource.tcpb,
      cmp = resource.cmp,
      maxbandwidth = resource.maxbandwidth,
      accessdown = resource.accessdown,
      monthreshold = resource.monthreshold,
      weight = resource.weight,
      monitor_name_svc = resource.monitor_name_svc,
      downstateflush = resource.downstateflush,
      tcpprofilename = resource.tcpprofilename,
      httpprofilename = resource.httpprofilename,
      hashid = resource.hashid,
      comment = resource.comment,
      appflowlog = resource.appflowlog,
      netprofile = resource.netprofile,
      processlocal = resource.processlocal,
      dnsprofilename = resource.dnsprofilename
    }.update_resource(client);

    public static base_responses update(nitro_service client, com.citrix.netscaler.nitro.resource.config.basic.service[] resources)
    {
      base_responses baseResponses = (base_responses) null;
      if (resources != null && resources.Length > 0)
      {
        com.citrix.netscaler.nitro.resource.config.basic.service[] serviceArray = new com.citrix.netscaler.nitro.resource.config.basic.service[resources.Length];
        for (int index = 0; index < resources.Length; ++index)
        {
          serviceArray[index] = new com.citrix.netscaler.nitro.resource.config.basic.service();
          serviceArray[index].name = resources[index].name;
          serviceArray[index].ipaddress = resources[index].ipaddress;
          serviceArray[index].maxclient = resources[index].maxclient;
          serviceArray[index].maxreq = resources[index].maxreq;
          serviceArray[index].cacheable = resources[index].cacheable;
          serviceArray[index].cip = resources[index].cip;
          serviceArray[index].cipheader = resources[index].cipheader;
          serviceArray[index].usip = resources[index].usip;
          serviceArray[index].pathmonitor = resources[index].pathmonitor;
          serviceArray[index].pathmonitorindv = resources[index].pathmonitorindv;
          serviceArray[index].useproxyport = resources[index].useproxyport;
          serviceArray[index].sc = resources[index].sc;
          serviceArray[index].sp = resources[index].sp;
          serviceArray[index].rtspsessionidremap = resources[index].rtspsessionidremap;
          serviceArray[index].healthmonitor = resources[index].healthmonitor;
          serviceArray[index].clttimeout = resources[index].clttimeout;
          serviceArray[index].svrtimeout = resources[index].svrtimeout;
          serviceArray[index].customserverid = resources[index].customserverid;
          serviceArray[index].serverid = resources[index].serverid;
          serviceArray[index].cka = resources[index].cka;
          serviceArray[index].tcpb = resources[index].tcpb;
          serviceArray[index].cmp = resources[index].cmp;
          serviceArray[index].maxbandwidth = resources[index].maxbandwidth;
          serviceArray[index].accessdown = resources[index].accessdown;
          serviceArray[index].monthreshold = resources[index].monthreshold;
          serviceArray[index].weight = resources[index].weight;
          serviceArray[index].monitor_name_svc = resources[index].monitor_name_svc;
          serviceArray[index].downstateflush = resources[index].downstateflush;
          serviceArray[index].tcpprofilename = resources[index].tcpprofilename;
          serviceArray[index].httpprofilename = resources[index].httpprofilename;
          serviceArray[index].hashid = resources[index].hashid;
          serviceArray[index].comment = resources[index].comment;
          serviceArray[index].appflowlog = resources[index].appflowlog;
          serviceArray[index].netprofile = resources[index].netprofile;
          serviceArray[index].processlocal = resources[index].processlocal;
          serviceArray[index].dnsprofilename = resources[index].dnsprofilename;
        }
        baseResponses = base_resource.update_bulk_request(client, (base_resource[]) serviceArray);
      }
      return baseResponses;
    }

    public static base_response unset(
      nitro_service client,
      string name,
      string[] args)
    {
      return new com.citrix.netscaler.nitro.resource.config.basic.service() { name = name }.unset_resource(client, args);
    }

    public static base_response unset(
      nitro_service client,
      com.citrix.netscaler.nitro.resource.config.basic.service resource,
      string[] args)
    {
      return new com.citrix.netscaler.nitro.resource.config.basic.service() { name = resource.name }.unset_resource(client, args);
    }

    public static base_responses unset(
      nitro_service client,
      string[] name,
      string[] args)
    {
      base_responses baseResponses = (base_responses) null;
      if (name != null && name.Length > 0)
      {
        com.citrix.netscaler.nitro.resource.config.basic.service[] serviceArray = new com.citrix.netscaler.nitro.resource.config.basic.service[name.Length];
        for (int index = 0; index < name.Length; ++index)
        {
          serviceArray[index] = new com.citrix.netscaler.nitro.resource.config.basic.service();
          serviceArray[index].name = name[index];
        }
        baseResponses = base_resource.unset_bulk_request(client, (base_resource[]) serviceArray, args);
      }
      return baseResponses;
    }

    public static base_responses unset(
      nitro_service client,
      com.citrix.netscaler.nitro.resource.config.basic.service[] resources,
      string[] args)
    {
      base_responses baseResponses = (base_responses) null;
      if (resources != null && resources.Length > 0)
      {
        com.citrix.netscaler.nitro.resource.config.basic.service[] serviceArray = new com.citrix.netscaler.nitro.resource.config.basic.service[resources.Length];
        for (int index = 0; index < resources.Length; ++index)
        {
          serviceArray[index] = new com.citrix.netscaler.nitro.resource.config.basic.service();
          serviceArray[index].name = resources[index].name;
        }
        baseResponses = base_resource.unset_bulk_request(client, (base_resource[]) serviceArray, args);
      }
      return baseResponses;
    }

    public static base_response enable(nitro_service client, string name) => new com.citrix.netscaler.nitro.resource.config.basic.service()
    {
      name = name
    }.perform_operation_byaction(client, nameof (enable));

    public static base_response enable(nitro_service client, com.citrix.netscaler.nitro.resource.config.basic.service resource) => new com.citrix.netscaler.nitro.resource.config.basic.service()
    {
      name = resource.name
    }.perform_operation_byaction(client, nameof (enable));

    public static base_responses enable(nitro_service client, string[] name)
    {
      base_responses baseResponses = (base_responses) null;
      if (name != null && name.Length > 0)
      {
        com.citrix.netscaler.nitro.resource.config.basic.service[] serviceArray = new com.citrix.netscaler.nitro.resource.config.basic.service[name.Length];
        for (int index = 0; index < name.Length; ++index)
        {
          serviceArray[index] = new com.citrix.netscaler.nitro.resource.config.basic.service();
          serviceArray[index].name = name[index];
        }
        baseResponses = base_resource.perform_operation_bulk_request(client, (base_resource[]) serviceArray, nameof (enable));
      }
      return baseResponses;
    }

    public static base_responses enable(nitro_service client, com.citrix.netscaler.nitro.resource.config.basic.service[] resources)
    {
      base_responses baseResponses = (base_responses) null;
      if (resources != null && resources.Length > 0)
      {
        com.citrix.netscaler.nitro.resource.config.basic.service[] serviceArray = new com.citrix.netscaler.nitro.resource.config.basic.service[resources.Length];
        for (int index = 0; index < resources.Length; ++index)
        {
          serviceArray[index] = new com.citrix.netscaler.nitro.resource.config.basic.service();
          serviceArray[index].name = resources[index].name;
        }
        baseResponses = base_resource.perform_operation_bulk_request(client, (base_resource[]) serviceArray, nameof (enable));
      }
      return baseResponses;
    }

    public static base_response disable(nitro_service client, string name) => new com.citrix.netscaler.nitro.resource.config.basic.service()
    {
      name = name
    }.perform_operation_byaction(client, nameof (disable));

    public static base_response disable(nitro_service client, com.citrix.netscaler.nitro.resource.config.basic.service resource) => new com.citrix.netscaler.nitro.resource.config.basic.service()
    {
      name = resource.name,
      delay = resource.delay,
      graceful = resource.graceful
    }.perform_operation_byaction(client, nameof (disable));

    public static base_responses disable(nitro_service client, string[] name)
    {
      base_responses baseResponses = (base_responses) null;
      if (name != null && name.Length > 0)
      {
        com.citrix.netscaler.nitro.resource.config.basic.service[] serviceArray = new com.citrix.netscaler.nitro.resource.config.basic.service[name.Length];
        for (int index = 0; index < name.Length; ++index)
        {
          serviceArray[index] = new com.citrix.netscaler.nitro.resource.config.basic.service();
          serviceArray[index].name = name[index];
        }
        baseResponses = base_resource.perform_operation_bulk_request(client, (base_resource[]) serviceArray, nameof (disable));
      }
      return baseResponses;
    }

    public static base_responses disable(nitro_service client, com.citrix.netscaler.nitro.resource.config.basic.service[] resources)
    {
      base_responses baseResponses = (base_responses) null;
      if (resources != null && resources.Length > 0)
      {
        com.citrix.netscaler.nitro.resource.config.basic.service[] serviceArray = new com.citrix.netscaler.nitro.resource.config.basic.service[resources.Length];
        for (int index = 0; index < resources.Length; ++index)
        {
          serviceArray[index] = new com.citrix.netscaler.nitro.resource.config.basic.service();
          serviceArray[index].name = resources[index].name;
          serviceArray[index].delay = resources[index].delay;
          serviceArray[index].graceful = resources[index].graceful;
        }
        baseResponses = base_resource.perform_operation_bulk_request(client, (base_resource[]) serviceArray, nameof (disable));
      }
      return baseResponses;
    }

    public static base_response rename(
      nitro_service client,
      com.citrix.netscaler.nitro.resource.config.basic.service resource,
      string new_name)
    {
      return new com.citrix.netscaler.nitro.resource.config.basic.service()
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
      return new com.citrix.netscaler.nitro.resource.config.basic.service()
      {
        name = name,
        newname = new_name
      }.rename_resource(client);
    }

    public static com.citrix.netscaler.nitro.resource.config.basic.service[] get(
      nitro_service service)
    {
      return (com.citrix.netscaler.nitro.resource.config.basic.service[]) new com.citrix.netscaler.nitro.resource.config.basic.service().get_resources(service, (options) null);
    }

    public static com.citrix.netscaler.nitro.resource.config.basic.service[] get(
      nitro_service service,
      options option)
    {
      return (com.citrix.netscaler.nitro.resource.config.basic.service[]) new com.citrix.netscaler.nitro.resource.config.basic.service().get_resources(service, option);
    }

    public static com.citrix.netscaler.nitro.resource.config.basic.service[] get(
      nitro_service service,
      service_args args)
    {
      com.citrix.netscaler.nitro.resource.config.basic.service service1 = new com.citrix.netscaler.nitro.resource.config.basic.service();
      options option = new options();
      option.set_args(nitro_util.object_to_string_withoutquotes((object) args));
      return (com.citrix.netscaler.nitro.resource.config.basic.service[]) service1.get_resources(service, option);
    }

    public static com.citrix.netscaler.nitro.resource.config.basic.service get(
      nitro_service service,
      string name)
    {
      return (com.citrix.netscaler.nitro.resource.config.basic.service) new com.citrix.netscaler.nitro.resource.config.basic.service()
      {
        name = name
      }.get_resource(service);
    }

    public static com.citrix.netscaler.nitro.resource.config.basic.service[] get(
      nitro_service service,
      string[] name)
    {
      if (name == null || name.Length <= 0)
        return (com.citrix.netscaler.nitro.resource.config.basic.service[]) null;
      com.citrix.netscaler.nitro.resource.config.basic.service[] serviceArray1 = new com.citrix.netscaler.nitro.resource.config.basic.service[name.Length];
      com.citrix.netscaler.nitro.resource.config.basic.service[] serviceArray2 = new com.citrix.netscaler.nitro.resource.config.basic.service[name.Length];
      for (int index = 0; index < name.Length; ++index)
      {
        serviceArray2[index] = new com.citrix.netscaler.nitro.resource.config.basic.service();
        serviceArray2[index].name = name[index];
        serviceArray1[index] = (com.citrix.netscaler.nitro.resource.config.basic.service) serviceArray2[index].get_resource(service);
      }
      return serviceArray1;
    }

    public static com.citrix.netscaler.nitro.resource.config.basic.service[] get_filtered(
      nitro_service service,
      string filter)
    {
      com.citrix.netscaler.nitro.resource.config.basic.service service1 = new com.citrix.netscaler.nitro.resource.config.basic.service();
      options option = new options();
      option.set_filter(filter);
      return (com.citrix.netscaler.nitro.resource.config.basic.service[]) service1.getfiltered(service, option);
    }

    public static com.citrix.netscaler.nitro.resource.config.basic.service[] get_filtered(
      nitro_service service,
      filtervalue[] filter)
    {
      com.citrix.netscaler.nitro.resource.config.basic.service service1 = new com.citrix.netscaler.nitro.resource.config.basic.service();
      options option = new options();
      option.set_filter(filter);
      return (com.citrix.netscaler.nitro.resource.config.basic.service[]) service1.getfiltered(service, option);
    }

    public static uint count(nitro_service service)
    {
      com.citrix.netscaler.nitro.resource.config.basic.service service1 = new com.citrix.netscaler.nitro.resource.config.basic.service();
      options option = new options();
      option.set_count(true);
      com.citrix.netscaler.nitro.resource.config.basic.service[] resources = (com.citrix.netscaler.nitro.resource.config.basic.service[]) service1.get_resources(service, option);
      return resources != null && resources.Length > 0 ? resources[0].__count.Value : 0U;
    }

    public static uint count_filtered(nitro_service service, string filter)
    {
      com.citrix.netscaler.nitro.resource.config.basic.service service1 = new com.citrix.netscaler.nitro.resource.config.basic.service();
      options option = new options();
      option.set_count(true);
      option.set_filter(filter);
      com.citrix.netscaler.nitro.resource.config.basic.service[] serviceArray = (com.citrix.netscaler.nitro.resource.config.basic.service[]) service1.getfiltered(service, option);
      return serviceArray != null && serviceArray.Length > 0 ? serviceArray[0].__count.Value : 0U;
    }

    public static uint count_filtered(nitro_service service, filtervalue[] filter)
    {
      com.citrix.netscaler.nitro.resource.config.basic.service service1 = new com.citrix.netscaler.nitro.resource.config.basic.service();
      options option = new options();
      option.set_count(true);
      option.set_filter(filter);
      com.citrix.netscaler.nitro.resource.config.basic.service[] serviceArray = (com.citrix.netscaler.nitro.resource.config.basic.service[]) service1.getfiltered(service, option);
      return serviceArray != null && serviceArray.Length > 0 ? serviceArray[0].__count.Value : 0U;
    }

    private class service_response : base_response
    {
      public com.citrix.netscaler.nitro.resource.config.basic.service[] service = (com.citrix.netscaler.nitro.resource.config.basic.service[]) null;
    }

    public static class spEnum
    {
      public const string ON = "ON";
      public const string OFF = "OFF";
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

    public static class valueEnum
    {
      public const string Certkey_not_bound = "Certkey not bound";
      public const string SSL_feature_disabled = "SSL feature disabled";
    }

    public static class useproxyportEnum
    {
      public const string YES = "YES";
      public const string NO = "NO";
    }

    public static class gslbEnum
    {
      public const string REMOTE = "REMOTE";
      public const string LOCAL = "LOCAL";
    }

    public static class usipEnum
    {
      public const string YES = "YES";
      public const string NO = "NO";
    }

    public static class cacheableEnum
    {
      public const string YES = "YES";
      public const string NO = "NO";
    }

    public static class serviceconftype2Enum
    {
      public const string Configured = "Configured";
      public const string Dynamic = "Dynamic";
      public const string Internal = "Internal";
    }

    public static class processlocalEnum
    {
      public const string ENABLED = "ENABLED";
      public const string DISABLED = "DISABLED";
    }

    public static class pathmonitorEnum
    {
      public const string YES = "YES";
      public const string NO = "NO";
    }

    public static class tcpbEnum
    {
      public const string YES = "YES";
      public const string NO = "NO";
    }

    public static class cipEnum
    {
      public const string ENABLED = "ENABLED";
      public const string DISABLED = "DISABLED";
    }

    public static class pathmonitorindvEnum
    {
      public const string YES = "YES";
      public const string NO = "NO";
    }

    public static class healthmonitorEnum
    {
      public const string YES = "YES";
      public const string NO = "NO";
    }

    public static class ckaEnum
    {
      public const string YES = "YES";
      public const string NO = "NO";
    }

    public static class appflowlogEnum
    {
      public const string ENABLED = "ENABLED";
      public const string DISABLED = "DISABLED";
    }

    public static class dup_stateEnum
    {
      public const string ENABLED = "ENABLED";
      public const string DISABLED = "DISABLED";
    }

    public static class accessdownEnum
    {
      public const string YES = "YES";
      public const string NO = "NO";
    }

    public static class cmpEnum
    {
      public const string YES = "YES";
      public const string NO = "NO";
    }

    public static class rtspsessionidremapEnum
    {
      public const string ON = "ON";
      public const string OFF = "OFF";
    }

    public static class gracefulEnum
    {
      public const string YES = "YES";
      public const string NO = "NO";
    }
  }
}
