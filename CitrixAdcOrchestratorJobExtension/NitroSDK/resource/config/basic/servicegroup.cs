// Decompiled with JetBrains decompiler
// Type: com.citrix.netscaler.nitro.resource.config.basic.servicegroup
// Assembly: nitro, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 6CF5DDEF-E052-4F9D-953F-6644F8378A66


using com.citrix.netscaler.nitro.exception;
using com.citrix.netscaler.nitro.resource.Base;
using com.citrix.netscaler.nitro.service;
using com.citrix.netscaler.nitro.util;

namespace com.citrix.netscaler.nitro.resource.config.basic
{
  public class servicegroup : base_resource
  {
    private string servicegroupnameField = (string) null;
    private string servicetypeField = (string) null;
    private string cachetypeField = (string) null;
    private uint? tdField = new uint?();
    private uint? maxclientField = new uint?();
    private uint? maxreqField = new uint?();
    private string cacheableField = (string) null;
    private string cipField = (string) null;
    private string cipheaderField = (string) null;
    private string usipField = (string) null;
    private string pathmonitorField = (string) null;
    private string pathmonitorindvField = (string) null;
    private string useproxyportField = (string) null;
    private string healthmonitorField = (string) null;
    private string scField = (string) null;
    private string spField = (string) null;
    private string rtspsessionidremapField = (string) null;
    private long? clttimeoutField = new long?();
    private long? svrtimeoutField = new long?();
    private string ckaField = (string) null;
    private string tcpbField = (string) null;
    private string cmpField = (string) null;
    private uint? maxbandwidthField = new uint?();
    private uint? monthresholdField = new uint?();
    private string stateField = (string) null;
    private string downstateflushField = (string) null;
    private string tcpprofilenameField = (string) null;
    private string httpprofilenameField = (string) null;
    private string commentField = (string) null;
    private string appflowlogField = (string) null;
    private string netprofileField = (string) null;
    private string autoscaleField = (string) null;
    private ushort? memberportField = new ushort?();
    private string servernameField = (string) null;
    private ushort? portField = new ushort?();
    private uint? weightField = new uint?();
    private string customserveridField = (string) null;
    private uint? serveridField = new uint?();
    private uint? hashidField = new uint?();
    private string monitor_name_svcField = (string) null;
    private uint? dup_weightField = new uint?();
    private int? riseapbrstatsmsgcodeField = new int?();
    private long? delayField = new long?();
    private string gracefulField = (string) null;
    private bool? includemembersField = new bool?();
    private string newnameField = (string) null;
    private int? numofconnectionsField = new int?();
    private bool? serviceconftypeField = new bool?();
    private string valueField = (string) null;
    private string svrstateField = (string) null;
    private string ipField = (string) null;
    private int? monstatcodeField = new int?();
    private int? monstatparam1Field = new int?();
    private int? monstatparam2Field = new int?();
    private int? monstatparam3Field = new int?();
    private uint? statechangetimemsecField = new uint?();
    private uint? stateupdatereasonField = new uint?();
    private uint? clmonownerField = new uint?();
    private uint? clmonviewField = new uint?();
    private uint? groupcountField = new uint?();
    private int? riseapbrstatsmsgcode2Field = new int?();
    private string serviceipstrField = (string) null;
    private string servicegroupeffectivestateField = (string) null;
    private uint? __countField = new uint?();

    public uint? __count
    {
      get => this.__countField;
      private set => this.__countField = value;
    }

    public string servicegroupname
    {
      get => this.servicegroupnameField;
      set => this.servicegroupnameField = value;
    }

    public string servicetype
    {
      get => this.servicetypeField;
      set => this.servicetypeField = value;
    }

    public string cachetype
    {
      get => this.cachetypeField;
      set => this.cachetypeField = value;
    }

    public uint? td
    {
      get => this.tdField;
      set => this.tdField = value;
    }

    public uint? maxclient
    {
      get => this.maxclientField;
      set => this.maxclientField = value;
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

    public string healthmonitor
    {
      get => this.healthmonitorField;
      set => this.healthmonitorField = value;
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

    public string autoscale
    {
      get => this.autoscaleField;
      set => this.autoscaleField = value;
    }

    public ushort? memberport
    {
      get => this.memberportField;
      set => this.memberportField = value;
    }

    public string servername
    {
      get => this.servernameField;
      set => this.servernameField = value;
    }

    public ushort? port
    {
      get => this.portField;
      set => this.portField = value;
    }

    public uint? weight
    {
      get => this.weightField;
      set => this.weightField = value;
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

    public uint? hashid
    {
      get => this.hashidField;
      set => this.hashidField = value;
    }

    public string monitor_name_svc
    {
      get => this.monitor_name_svcField;
      set => this.monitor_name_svcField = value;
    }

    public uint? dup_weight
    {
      get => this.dup_weightField;
      set => this.dup_weightField = value;
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

    public bool? includemembers
    {
      get => this.includemembersField;
      set => this.includemembersField = value;
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

    public bool? serviceconftype
    {
      get => this.serviceconftypeField;
      private set => this.serviceconftypeField = value;
    }

    public string value
    {
      get => this.valueField;
      private set => this.valueField = value;
    }

    public string svrstate
    {
      get => this.svrstateField;
      private set => this.svrstateField = value;
    }

    public string ip
    {
      get => this.ipField;
      private set => this.ipField = value;
    }

    public int? monstatcode
    {
      get => this.monstatcodeField;
      private set => this.monstatcodeField = value;
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

    public uint? statechangetimemsec
    {
      get => this.statechangetimemsecField;
      private set => this.statechangetimemsecField = value;
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

    public uint? groupcount
    {
      get => this.groupcountField;
      private set => this.groupcountField = value;
    }

    public int? riseapbrstatsmsgcode2
    {
      get => this.riseapbrstatsmsgcode2Field;
      private set => this.riseapbrstatsmsgcode2Field = value;
    }

    public string serviceipstr
    {
      get => this.serviceipstrField;
      private set => this.serviceipstrField = value;
    }

    public string servicegroupeffectivestate
    {
      get => this.servicegroupeffectivestateField;
      private set => this.servicegroupeffectivestateField = value;
    }

    internal override base_resource[] get_nitro_response(
      nitro_service service,
      string response)
    {
      servicegroup.servicegroup_response servicegroupResponse = new servicegroup.servicegroup_response();
      servicegroup.servicegroup_response resource = (servicegroup.servicegroup_response) service.get_payload_formatter().string_to_resource(servicegroupResponse.GetType(), response);
      if (resource.errorcode != 0)
      {
        if (resource.errorcode == 444)
          service.clear_session();
        if (resource.severity == null)
          throw new nitro_exception(resource.message, resource.errorcode);
        if (resource.severity.Equals("ERROR"))
          throw new nitro_exception(resource.message, resource.errorcode);
      }
      return (base_resource[]) resource.servicegroup;
    }

    internal override string get_object_name() => this.servicegroupname;

    public static base_response add(nitro_service client, servicegroup resource) => new servicegroup()
    {
      servicegroupname = resource.servicegroupname,
      servicetype = resource.servicetype,
      cachetype = resource.cachetype,
      td = resource.td,
      maxclient = resource.maxclient,
      maxreq = resource.maxreq,
      cacheable = resource.cacheable,
      cip = resource.cip,
      cipheader = resource.cipheader,
      usip = resource.usip,
      pathmonitor = resource.pathmonitor,
      pathmonitorindv = resource.pathmonitorindv,
      useproxyport = resource.useproxyport,
      healthmonitor = resource.healthmonitor,
      sc = resource.sc,
      sp = resource.sp,
      rtspsessionidremap = resource.rtspsessionidremap,
      clttimeout = resource.clttimeout,
      svrtimeout = resource.svrtimeout,
      cka = resource.cka,
      tcpb = resource.tcpb,
      cmp = resource.cmp,
      maxbandwidth = resource.maxbandwidth,
      monthreshold = resource.monthreshold,
      state = resource.state,
      downstateflush = resource.downstateflush,
      tcpprofilename = resource.tcpprofilename,
      httpprofilename = resource.httpprofilename,
      comment = resource.comment,
      appflowlog = resource.appflowlog,
      netprofile = resource.netprofile,
      autoscale = resource.autoscale,
      memberport = resource.memberport
    }.add_resource(client);

    public static base_responses add(nitro_service client, servicegroup[] resources)
    {
      base_responses baseResponses = (base_responses) null;
      if (resources != null && resources.Length > 0)
      {
        servicegroup[] servicegroupArray = new servicegroup[resources.Length];
        for (int index = 0; index < resources.Length; ++index)
        {
          servicegroupArray[index] = new servicegroup();
          servicegroupArray[index].servicegroupname = resources[index].servicegroupname;
          servicegroupArray[index].servicetype = resources[index].servicetype;
          servicegroupArray[index].cachetype = resources[index].cachetype;
          servicegroupArray[index].td = resources[index].td;
          servicegroupArray[index].maxclient = resources[index].maxclient;
          servicegroupArray[index].maxreq = resources[index].maxreq;
          servicegroupArray[index].cacheable = resources[index].cacheable;
          servicegroupArray[index].cip = resources[index].cip;
          servicegroupArray[index].cipheader = resources[index].cipheader;
          servicegroupArray[index].usip = resources[index].usip;
          servicegroupArray[index].pathmonitor = resources[index].pathmonitor;
          servicegroupArray[index].pathmonitorindv = resources[index].pathmonitorindv;
          servicegroupArray[index].useproxyport = resources[index].useproxyport;
          servicegroupArray[index].healthmonitor = resources[index].healthmonitor;
          servicegroupArray[index].sc = resources[index].sc;
          servicegroupArray[index].sp = resources[index].sp;
          servicegroupArray[index].rtspsessionidremap = resources[index].rtspsessionidremap;
          servicegroupArray[index].clttimeout = resources[index].clttimeout;
          servicegroupArray[index].svrtimeout = resources[index].svrtimeout;
          servicegroupArray[index].cka = resources[index].cka;
          servicegroupArray[index].tcpb = resources[index].tcpb;
          servicegroupArray[index].cmp = resources[index].cmp;
          servicegroupArray[index].maxbandwidth = resources[index].maxbandwidth;
          servicegroupArray[index].monthreshold = resources[index].monthreshold;
          servicegroupArray[index].state = resources[index].state;
          servicegroupArray[index].downstateflush = resources[index].downstateflush;
          servicegroupArray[index].tcpprofilename = resources[index].tcpprofilename;
          servicegroupArray[index].httpprofilename = resources[index].httpprofilename;
          servicegroupArray[index].comment = resources[index].comment;
          servicegroupArray[index].appflowlog = resources[index].appflowlog;
          servicegroupArray[index].netprofile = resources[index].netprofile;
          servicegroupArray[index].autoscale = resources[index].autoscale;
          servicegroupArray[index].memberport = resources[index].memberport;
        }
        baseResponses = base_resource.add_bulk_request(client, (base_resource[]) servicegroupArray);
      }
      return baseResponses;
    }

    public static base_response delete(nitro_service client, string servicegroupname) => new servicegroup()
    {
      servicegroupname = servicegroupname
    }.delete_resource(client);

    public static base_response delete(nitro_service client, servicegroup resource) => new servicegroup()
    {
      servicegroupname = resource.servicegroupname
    }.delete_resource(client);

    public static base_responses delete(
      nitro_service client,
      string[] servicegroupname)
    {
      base_responses baseResponses = (base_responses) null;
      if (servicegroupname != null && servicegroupname.Length > 0)
      {
        servicegroup[] servicegroupArray = new servicegroup[servicegroupname.Length];
        for (int index = 0; index < servicegroupname.Length; ++index)
        {
          servicegroupArray[index] = new servicegroup();
          servicegroupArray[index].servicegroupname = servicegroupname[index];
        }
        baseResponses = base_resource.delete_bulk_request(client, (base_resource[]) servicegroupArray);
      }
      return baseResponses;
    }

    public static base_responses delete(
      nitro_service client,
      servicegroup[] resources)
    {
      base_responses baseResponses = (base_responses) null;
      if (resources != null && resources.Length > 0)
      {
        servicegroup[] servicegroupArray = new servicegroup[resources.Length];
        for (int index = 0; index < resources.Length; ++index)
        {
          servicegroupArray[index] = new servicegroup();
          servicegroupArray[index].servicegroupname = resources[index].servicegroupname;
        }
        baseResponses = base_resource.delete_bulk_request(client, (base_resource[]) servicegroupArray);
      }
      return baseResponses;
    }

    public static base_response update(nitro_service client, servicegroup resource) => new servicegroup()
    {
      servicegroupname = resource.servicegroupname,
      servername = resource.servername,
      port = resource.port,
      weight = resource.weight,
      customserverid = resource.customserverid,
      serverid = resource.serverid,
      hashid = resource.hashid,
      monitor_name_svc = resource.monitor_name_svc,
      dup_weight = resource.dup_weight,
      maxclient = resource.maxclient,
      maxreq = resource.maxreq,
      healthmonitor = resource.healthmonitor,
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
      cka = resource.cka,
      tcpb = resource.tcpb,
      cmp = resource.cmp,
      maxbandwidth = resource.maxbandwidth,
      monthreshold = resource.monthreshold,
      downstateflush = resource.downstateflush,
      tcpprofilename = resource.tcpprofilename,
      httpprofilename = resource.httpprofilename,
      comment = resource.comment,
      appflowlog = resource.appflowlog,
      netprofile = resource.netprofile
    }.update_resource(client);

    public static base_responses update(
      nitro_service client,
      servicegroup[] resources)
    {
      base_responses baseResponses = (base_responses) null;
      if (resources != null && resources.Length > 0)
      {
        servicegroup[] servicegroupArray = new servicegroup[resources.Length];
        for (int index = 0; index < resources.Length; ++index)
        {
          servicegroupArray[index] = new servicegroup();
          servicegroupArray[index].servicegroupname = resources[index].servicegroupname;
          servicegroupArray[index].servername = resources[index].servername;
          servicegroupArray[index].port = resources[index].port;
          servicegroupArray[index].weight = resources[index].weight;
          servicegroupArray[index].customserverid = resources[index].customserverid;
          servicegroupArray[index].serverid = resources[index].serverid;
          servicegroupArray[index].hashid = resources[index].hashid;
          servicegroupArray[index].monitor_name_svc = resources[index].monitor_name_svc;
          servicegroupArray[index].dup_weight = resources[index].dup_weight;
          servicegroupArray[index].maxclient = resources[index].maxclient;
          servicegroupArray[index].maxreq = resources[index].maxreq;
          servicegroupArray[index].healthmonitor = resources[index].healthmonitor;
          servicegroupArray[index].cacheable = resources[index].cacheable;
          servicegroupArray[index].cip = resources[index].cip;
          servicegroupArray[index].cipheader = resources[index].cipheader;
          servicegroupArray[index].usip = resources[index].usip;
          servicegroupArray[index].pathmonitor = resources[index].pathmonitor;
          servicegroupArray[index].pathmonitorindv = resources[index].pathmonitorindv;
          servicegroupArray[index].useproxyport = resources[index].useproxyport;
          servicegroupArray[index].sc = resources[index].sc;
          servicegroupArray[index].sp = resources[index].sp;
          servicegroupArray[index].rtspsessionidremap = resources[index].rtspsessionidremap;
          servicegroupArray[index].clttimeout = resources[index].clttimeout;
          servicegroupArray[index].svrtimeout = resources[index].svrtimeout;
          servicegroupArray[index].cka = resources[index].cka;
          servicegroupArray[index].tcpb = resources[index].tcpb;
          servicegroupArray[index].cmp = resources[index].cmp;
          servicegroupArray[index].maxbandwidth = resources[index].maxbandwidth;
          servicegroupArray[index].monthreshold = resources[index].monthreshold;
          servicegroupArray[index].downstateflush = resources[index].downstateflush;
          servicegroupArray[index].tcpprofilename = resources[index].tcpprofilename;
          servicegroupArray[index].httpprofilename = resources[index].httpprofilename;
          servicegroupArray[index].comment = resources[index].comment;
          servicegroupArray[index].appflowlog = resources[index].appflowlog;
          servicegroupArray[index].netprofile = resources[index].netprofile;
        }
        baseResponses = base_resource.update_bulk_request(client, (base_resource[]) servicegroupArray);
      }
      return baseResponses;
    }

    public static base_response unset(
      nitro_service client,
      string servicegroupname,
      string[] args)
    {
      return new servicegroup()
      {
        servicegroupname = servicegroupname
      }.unset_resource(client, args);
    }

    public static base_response unset(
      nitro_service client,
      servicegroup resource,
      string[] args)
    {
      return new servicegroup()
      {
        servicegroupname = resource.servicegroupname,
        servername = resource.servername,
        port = resource.port,
        weight = resource.weight,
        customserverid = resource.customserverid,
        serverid = resource.serverid,
        hashid = resource.hashid,
        riseapbrstatsmsgcode = resource.riseapbrstatsmsgcode
      }.unset_resource(client, args);
    }

    public static base_responses unset(
      nitro_service client,
      string[] servicegroupname,
      string[] args)
    {
      base_responses baseResponses = (base_responses) null;
      if (servicegroupname != null && servicegroupname.Length > 0)
      {
        servicegroup[] servicegroupArray = new servicegroup[servicegroupname.Length];
        for (int index = 0; index < servicegroupname.Length; ++index)
        {
          servicegroupArray[index] = new servicegroup();
          servicegroupArray[index].servicegroupname = servicegroupname[index];
        }
        baseResponses = base_resource.unset_bulk_request(client, (base_resource[]) servicegroupArray, args);
      }
      return baseResponses;
    }

    public static base_responses unset(
      nitro_service client,
      servicegroup[] resources,
      string[] args)
    {
      base_responses baseResponses = (base_responses) null;
      if (resources != null && resources.Length > 0)
      {
        servicegroup[] servicegroupArray = new servicegroup[resources.Length];
        for (int index = 0; index < resources.Length; ++index)
        {
          servicegroupArray[index] = new servicegroup();
          servicegroupArray[index].servicegroupname = resources[index].servicegroupname;
          servicegroupArray[index].servername = resources[index].servername;
          servicegroupArray[index].port = resources[index].port;
          servicegroupArray[index].weight = resources[index].weight;
          servicegroupArray[index].customserverid = resources[index].customserverid;
          servicegroupArray[index].serverid = resources[index].serverid;
          servicegroupArray[index].hashid = resources[index].hashid;
          servicegroupArray[index].riseapbrstatsmsgcode = resources[index].riseapbrstatsmsgcode;
        }
        baseResponses = base_resource.unset_bulk_request(client, (base_resource[]) servicegroupArray, args);
      }
      return baseResponses;
    }

    public static base_response enable(nitro_service client, string servicegroupname) => new servicegroup()
    {
      servicegroupname = servicegroupname
    }.perform_operation_byaction(client, nameof (enable));

    public static base_response enable(nitro_service client, servicegroup resource) => new servicegroup()
    {
      servicegroupname = resource.servicegroupname,
      servername = resource.servername,
      port = resource.port
    }.perform_operation_byaction(client, nameof (enable));

    public static base_responses enable(
      nitro_service client,
      string[] servicegroupname)
    {
      base_responses baseResponses = (base_responses) null;
      if (servicegroupname != null && servicegroupname.Length > 0)
      {
        servicegroup[] servicegroupArray = new servicegroup[servicegroupname.Length];
        for (int index = 0; index < servicegroupname.Length; ++index)
        {
          servicegroupArray[index] = new servicegroup();
          servicegroupArray[index].servicegroupname = servicegroupname[index];
        }
        baseResponses = base_resource.perform_operation_bulk_request(client, (base_resource[]) servicegroupArray, nameof (enable));
      }
      return baseResponses;
    }

    public static base_responses enable(
      nitro_service client,
      servicegroup[] resources)
    {
      base_responses baseResponses = (base_responses) null;
      if (resources != null && resources.Length > 0)
      {
        servicegroup[] servicegroupArray = new servicegroup[resources.Length];
        for (int index = 0; index < resources.Length; ++index)
        {
          servicegroupArray[index] = new servicegroup();
          servicegroupArray[index].servicegroupname = resources[index].servicegroupname;
          servicegroupArray[index].servername = resources[index].servername;
          servicegroupArray[index].port = resources[index].port;
        }
        baseResponses = base_resource.perform_operation_bulk_request(client, (base_resource[]) servicegroupArray, nameof (enable));
      }
      return baseResponses;
    }

    public static base_response disable(nitro_service client, string servicegroupname) => new servicegroup()
    {
      servicegroupname = servicegroupname
    }.perform_operation_byaction(client, nameof (disable));

    public static base_response disable(nitro_service client, servicegroup resource) => new servicegroup()
    {
      servicegroupname = resource.servicegroupname,
      servername = resource.servername,
      port = resource.port,
      delay = resource.delay,
      graceful = resource.graceful
    }.perform_operation_byaction(client, nameof (disable));

    public static base_responses disable(
      nitro_service client,
      string[] servicegroupname)
    {
      base_responses baseResponses = (base_responses) null;
      if (servicegroupname != null && servicegroupname.Length > 0)
      {
        servicegroup[] servicegroupArray = new servicegroup[servicegroupname.Length];
        for (int index = 0; index < servicegroupname.Length; ++index)
        {
          servicegroupArray[index] = new servicegroup();
          servicegroupArray[index].servicegroupname = servicegroupname[index];
        }
        baseResponses = base_resource.perform_operation_bulk_request(client, (base_resource[]) servicegroupArray, nameof (disable));
      }
      return baseResponses;
    }

    public static base_responses disable(
      nitro_service client,
      servicegroup[] resources)
    {
      base_responses baseResponses = (base_responses) null;
      if (resources != null && resources.Length > 0)
      {
        servicegroup[] servicegroupArray = new servicegroup[resources.Length];
        for (int index = 0; index < resources.Length; ++index)
        {
          servicegroupArray[index] = new servicegroup();
          servicegroupArray[index].servicegroupname = resources[index].servicegroupname;
          servicegroupArray[index].servername = resources[index].servername;
          servicegroupArray[index].port = resources[index].port;
          servicegroupArray[index].delay = resources[index].delay;
          servicegroupArray[index].graceful = resources[index].graceful;
        }
        baseResponses = base_resource.perform_operation_bulk_request(client, (base_resource[]) servicegroupArray, nameof (disable));
      }
      return baseResponses;
    }

    public static base_response rename(
      nitro_service client,
      servicegroup resource,
      string new_servicegroupname)
    {
      return new servicegroup()
      {
        servicegroupname = resource.servicegroupname,
        newname = new_servicegroupname
      }.rename_resource(client);
    }

    public static base_response rename(
      nitro_service client,
      string servicegroupname,
      string new_servicegroupname)
    {
      return new servicegroup()
      {
        servicegroupname = servicegroupname,
        newname = new_servicegroupname
      }.rename_resource(client);
    }

    public static servicegroup[] get(nitro_service service) => (servicegroup[]) new servicegroup().get_resources(service, (options) null);

    public static servicegroup[] get(nitro_service service, options option) => (servicegroup[]) new servicegroup().get_resources(service, option);

    public static servicegroup[] get(nitro_service service, servicegroup_args args)
    {
      servicegroup servicegroup = new servicegroup();
      options option = new options();
      option.set_args(nitro_util.object_to_string_withoutquotes((object) args));
      return (servicegroup[]) servicegroup.get_resources(service, option);
    }

    public static servicegroup get(nitro_service service, string servicegroupname) => (servicegroup) new servicegroup()
    {
      servicegroupname = servicegroupname
    }.get_resource(service);

    public static servicegroup[] get(nitro_service service, string[] servicegroupname)
    {
      if (servicegroupname == null || servicegroupname.Length <= 0)
        return (servicegroup[]) null;
      servicegroup[] servicegroupArray1 = new servicegroup[servicegroupname.Length];
      servicegroup[] servicegroupArray2 = new servicegroup[servicegroupname.Length];
      for (int index = 0; index < servicegroupname.Length; ++index)
      {
        servicegroupArray2[index] = new servicegroup();
        servicegroupArray2[index].servicegroupname = servicegroupname[index];
        servicegroupArray1[index] = (servicegroup) servicegroupArray2[index].get_resource(service);
      }
      return servicegroupArray1;
    }

    public static servicegroup[] get_filtered(nitro_service service, string filter)
    {
      servicegroup servicegroup = new servicegroup();
      options option = new options();
      option.set_filter(filter);
      return (servicegroup[]) servicegroup.getfiltered(service, option);
    }

    public static servicegroup[] get_filtered(
      nitro_service service,
      filtervalue[] filter)
    {
      servicegroup servicegroup = new servicegroup();
      options option = new options();
      option.set_filter(filter);
      return (servicegroup[]) servicegroup.getfiltered(service, option);
    }

    public static uint count(nitro_service service)
    {
      servicegroup servicegroup = new servicegroup();
      options option = new options();
      option.set_count(true);
      servicegroup[] resources = (servicegroup[]) servicegroup.get_resources(service, option);
      return resources != null && resources.Length > 0 ? resources[0].__count.Value : 0U;
    }

    public static uint count_filtered(nitro_service service, string filter)
    {
      servicegroup servicegroup = new servicegroup();
      options option = new options();
      option.set_count(true);
      option.set_filter(filter);
      servicegroup[] servicegroupArray = (servicegroup[]) servicegroup.getfiltered(service, option);
      return servicegroupArray != null && servicegroupArray.Length > 0 ? servicegroupArray[0].__count.Value : 0U;
    }

    public static uint count_filtered(nitro_service service, filtervalue[] filter)
    {
      servicegroup servicegroup = new servicegroup();
      options option = new options();
      option.set_count(true);
      option.set_filter(filter);
      servicegroup[] servicegroupArray = (servicegroup[]) servicegroup.getfiltered(service, option);
      return servicegroupArray != null && servicegroupArray.Length > 0 ? servicegroupArray[0].__count.Value : 0U;
    }

    private class servicegroup_response : base_response
    {
      public servicegroup[] servicegroup = (servicegroup[]) null;
    }

    public static class spEnum
    {
      public const string ON = "ON";
      public const string OFF = "OFF";
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

    public static class servicegroupeffectivestateEnum
    {
      public const string UP = "UP";
      public const string DOWN = "DOWN";
      public const string OUT_OF_SERVICE = "OUT OF SERVICE";
      public const string PARTIAL_UP = "PARTIAL-UP";
      public const string PARTIAL_DOWN = "PARTIAL-DOWN";
    }

    public static class pathmonitorEnum
    {
      public const string YES = "YES";
      public const string NO = "NO";
    }

    public static class autoscaleEnum
    {
      public const string DISABLED = "DISABLED";
      public const string DNS = "DNS";
      public const string POLICY = "POLICY";
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
