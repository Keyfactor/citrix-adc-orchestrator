// Decompiled with JetBrains decompiler
// Type: com.citrix.netscaler.nitro.resource.config.ns.nstcpprofile
// Assembly: nitro, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 6CF5DDEF-E052-4F9D-953F-6644F8378A66


using com.citrix.netscaler.nitro.exception;
using com.citrix.netscaler.nitro.resource.Base;
using com.citrix.netscaler.nitro.service;
using com.citrix.netscaler.nitro.util;

namespace com.citrix.netscaler.nitro.resource.config.ns
{
  public class nstcpprofile : base_resource
  {
    private string nameField = (string) null;
    private string wsField = (string) null;
    private string sackField = (string) null;
    private uint? wsvalField = new uint?();
    private string nagleField = (string) null;
    private string ackonpushField = (string) null;
    private uint? mssField = new uint?();
    private uint? maxburstField = new uint?();
    private uint? initialcwndField = new uint?();
    private uint? delayedackField = new uint?();
    private uint? oooqsizeField = new uint?();
    private uint? maxpktpermssField = new uint?();
    private uint? pktperretxField = new uint?();
    private uint? minrtoField = new uint?();
    private uint? slowstartincrField = new uint?();
    private uint? buffersizeField = new uint?();
    private string syncookieField = (string) null;
    private string kaprobeupdatelastactivityField = (string) null;
    private string flavorField = (string) null;
    private string dynamicreceivebufferingField = (string) null;
    private string kaField = (string) null;
    private uint? kaconnidletimeField = new uint?();
    private uint? kamaxprobesField = new uint?();
    private uint? kaprobeintervalField = new uint?();
    private uint? sendbuffsizeField = new uint?();
    private string mptcpField = (string) null;
    private string establishclientconnField = (string) null;
    private string tcpsegoffloadField = (string) null;
    private string rstwindowattenuateField = (string) null;
    private string rstmaxackField = (string) null;
    private string spoofsyndropField = (string) null;
    private string ecnField = (string) null;
    private string mptcpdropdataonpreestsfField = (string) null;
    private string mptcpfastopenField = (string) null;
    private uint? mptcpsessiontimeoutField = new uint?();
    private string timestampField = (string) null;
    private string dsackField = (string) null;
    private string ackaggregationField = (string) null;
    private string frtoField = (string) null;
    private uint? maxcwndField = new uint?();
    private string fackField = (string) null;
    private string tcpmodeField = (string) null;
    private uint? refcntField = new uint?();
    private string[] builtinField = (string[]) null;
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

    public string ws
    {
      get => this.wsField;
      set => this.wsField = value;
    }

    public string sack
    {
      get => this.sackField;
      set => this.sackField = value;
    }

    public uint? wsval
    {
      get => this.wsvalField;
      set => this.wsvalField = value;
    }

    public string nagle
    {
      get => this.nagleField;
      set => this.nagleField = value;
    }

    public string ackonpush
    {
      get => this.ackonpushField;
      set => this.ackonpushField = value;
    }

    public uint? mss
    {
      get => this.mssField;
      set => this.mssField = value;
    }

    public uint? maxburst
    {
      get => this.maxburstField;
      set => this.maxburstField = value;
    }

    public uint? initialcwnd
    {
      get => this.initialcwndField;
      set => this.initialcwndField = value;
    }

    public uint? delayedack
    {
      get => this.delayedackField;
      set => this.delayedackField = value;
    }

    public uint? oooqsize
    {
      get => this.oooqsizeField;
      set => this.oooqsizeField = value;
    }

    public uint? maxpktpermss
    {
      get => this.maxpktpermssField;
      set => this.maxpktpermssField = value;
    }

    public uint? pktperretx
    {
      get => this.pktperretxField;
      set => this.pktperretxField = value;
    }

    public uint? minrto
    {
      get => this.minrtoField;
      set => this.minrtoField = value;
    }

    public uint? slowstartincr
    {
      get => this.slowstartincrField;
      set => this.slowstartincrField = value;
    }

    public uint? buffersize
    {
      get => this.buffersizeField;
      set => this.buffersizeField = value;
    }

    public string syncookie
    {
      get => this.syncookieField;
      set => this.syncookieField = value;
    }

    public string kaprobeupdatelastactivity
    {
      get => this.kaprobeupdatelastactivityField;
      set => this.kaprobeupdatelastactivityField = value;
    }

    public string flavor
    {
      get => this.flavorField;
      set => this.flavorField = value;
    }

    public string dynamicreceivebuffering
    {
      get => this.dynamicreceivebufferingField;
      set => this.dynamicreceivebufferingField = value;
    }

    public string ka
    {
      get => this.kaField;
      set => this.kaField = value;
    }

    public uint? kaconnidletime
    {
      get => this.kaconnidletimeField;
      set => this.kaconnidletimeField = value;
    }

    public uint? kamaxprobes
    {
      get => this.kamaxprobesField;
      set => this.kamaxprobesField = value;
    }

    public uint? kaprobeinterval
    {
      get => this.kaprobeintervalField;
      set => this.kaprobeintervalField = value;
    }

    public uint? sendbuffsize
    {
      get => this.sendbuffsizeField;
      set => this.sendbuffsizeField = value;
    }

    public string mptcp
    {
      get => this.mptcpField;
      set => this.mptcpField = value;
    }

    public string establishclientconn
    {
      get => this.establishclientconnField;
      set => this.establishclientconnField = value;
    }

    public string tcpsegoffload
    {
      get => this.tcpsegoffloadField;
      set => this.tcpsegoffloadField = value;
    }

    public string rstwindowattenuate
    {
      get => this.rstwindowattenuateField;
      set => this.rstwindowattenuateField = value;
    }

    public string rstmaxack
    {
      get => this.rstmaxackField;
      set => this.rstmaxackField = value;
    }

    public string spoofsyndrop
    {
      get => this.spoofsyndropField;
      set => this.spoofsyndropField = value;
    }

    public string ecn
    {
      get => this.ecnField;
      set => this.ecnField = value;
    }

    public string mptcpdropdataonpreestsf
    {
      get => this.mptcpdropdataonpreestsfField;
      set => this.mptcpdropdataonpreestsfField = value;
    }

    public string mptcpfastopen
    {
      get => this.mptcpfastopenField;
      set => this.mptcpfastopenField = value;
    }

    public uint? mptcpsessiontimeout
    {
      get => this.mptcpsessiontimeoutField;
      set => this.mptcpsessiontimeoutField = value;
    }

    public string timestamp
    {
      get => this.timestampField;
      set => this.timestampField = value;
    }

    public string dsack
    {
      get => this.dsackField;
      set => this.dsackField = value;
    }

    public string ackaggregation
    {
      get => this.ackaggregationField;
      set => this.ackaggregationField = value;
    }

    public string frto
    {
      get => this.frtoField;
      set => this.frtoField = value;
    }

    public uint? maxcwnd
    {
      get => this.maxcwndField;
      set => this.maxcwndField = value;
    }

    public string fack
    {
      get => this.fackField;
      set => this.fackField = value;
    }

    public string tcpmode
    {
      get => this.tcpmodeField;
      set => this.tcpmodeField = value;
    }

    public uint? refcnt
    {
      get => this.refcntField;
      private set => this.refcntField = value;
    }

    public string[] builtin
    {
      get => this.builtinField;
      private set => this.builtinField = value;
    }

    internal override base_resource[] get_nitro_response(
      nitro_service service,
      string response)
    {
      nstcpprofile.nstcpprofile_response nstcpprofileResponse = new nstcpprofile.nstcpprofile_response();
      nstcpprofile.nstcpprofile_response resource = (nstcpprofile.nstcpprofile_response) service.get_payload_formatter().string_to_resource(nstcpprofileResponse.GetType(), response);
      if (resource.errorcode != 0)
      {
        if (resource.errorcode == 444)
          service.clear_session();
        if (resource.severity == null)
          throw new nitro_exception(resource.message, resource.errorcode);
        if (resource.severity.Equals("ERROR"))
          throw new nitro_exception(resource.message, resource.errorcode);
      }
      return (base_resource[]) resource.nstcpprofile;
    }

    internal override string get_object_name() => this.name;

    public static base_response add(nitro_service client, nstcpprofile resource) => new nstcpprofile()
    {
      name = resource.name,
      ws = resource.ws,
      sack = resource.sack,
      wsval = resource.wsval,
      nagle = resource.nagle,
      ackonpush = resource.ackonpush,
      mss = resource.mss,
      maxburst = resource.maxburst,
      initialcwnd = resource.initialcwnd,
      delayedack = resource.delayedack,
      oooqsize = resource.oooqsize,
      maxpktpermss = resource.maxpktpermss,
      pktperretx = resource.pktperretx,
      minrto = resource.minrto,
      slowstartincr = resource.slowstartincr,
      buffersize = resource.buffersize,
      syncookie = resource.syncookie,
      kaprobeupdatelastactivity = resource.kaprobeupdatelastactivity,
      flavor = resource.flavor,
      dynamicreceivebuffering = resource.dynamicreceivebuffering,
      ka = resource.ka,
      kaconnidletime = resource.kaconnidletime,
      kamaxprobes = resource.kamaxprobes,
      kaprobeinterval = resource.kaprobeinterval,
      sendbuffsize = resource.sendbuffsize,
      mptcp = resource.mptcp,
      establishclientconn = resource.establishclientconn,
      tcpsegoffload = resource.tcpsegoffload,
      rstwindowattenuate = resource.rstwindowattenuate,
      rstmaxack = resource.rstmaxack,
      spoofsyndrop = resource.spoofsyndrop,
      ecn = resource.ecn,
      mptcpdropdataonpreestsf = resource.mptcpdropdataonpreestsf,
      mptcpfastopen = resource.mptcpfastopen,
      mptcpsessiontimeout = resource.mptcpsessiontimeout,
      timestamp = resource.timestamp,
      dsack = resource.dsack,
      ackaggregation = resource.ackaggregation,
      frto = resource.frto,
      maxcwnd = resource.maxcwnd,
      fack = resource.fack,
      tcpmode = resource.tcpmode
    }.add_resource(client);

    public static base_responses add(nitro_service client, nstcpprofile[] resources)
    {
      base_responses baseResponses = (base_responses) null;
      if (resources != null && resources.Length > 0)
      {
        nstcpprofile[] nstcpprofileArray = new nstcpprofile[resources.Length];
        for (int index = 0; index < resources.Length; ++index)
        {
          nstcpprofileArray[index] = new nstcpprofile();
          nstcpprofileArray[index].name = resources[index].name;
          nstcpprofileArray[index].ws = resources[index].ws;
          nstcpprofileArray[index].sack = resources[index].sack;
          nstcpprofileArray[index].wsval = resources[index].wsval;
          nstcpprofileArray[index].nagle = resources[index].nagle;
          nstcpprofileArray[index].ackonpush = resources[index].ackonpush;
          nstcpprofileArray[index].mss = resources[index].mss;
          nstcpprofileArray[index].maxburst = resources[index].maxburst;
          nstcpprofileArray[index].initialcwnd = resources[index].initialcwnd;
          nstcpprofileArray[index].delayedack = resources[index].delayedack;
          nstcpprofileArray[index].oooqsize = resources[index].oooqsize;
          nstcpprofileArray[index].maxpktpermss = resources[index].maxpktpermss;
          nstcpprofileArray[index].pktperretx = resources[index].pktperretx;
          nstcpprofileArray[index].minrto = resources[index].minrto;
          nstcpprofileArray[index].slowstartincr = resources[index].slowstartincr;
          nstcpprofileArray[index].buffersize = resources[index].buffersize;
          nstcpprofileArray[index].syncookie = resources[index].syncookie;
          nstcpprofileArray[index].kaprobeupdatelastactivity = resources[index].kaprobeupdatelastactivity;
          nstcpprofileArray[index].flavor = resources[index].flavor;
          nstcpprofileArray[index].dynamicreceivebuffering = resources[index].dynamicreceivebuffering;
          nstcpprofileArray[index].ka = resources[index].ka;
          nstcpprofileArray[index].kaconnidletime = resources[index].kaconnidletime;
          nstcpprofileArray[index].kamaxprobes = resources[index].kamaxprobes;
          nstcpprofileArray[index].kaprobeinterval = resources[index].kaprobeinterval;
          nstcpprofileArray[index].sendbuffsize = resources[index].sendbuffsize;
          nstcpprofileArray[index].mptcp = resources[index].mptcp;
          nstcpprofileArray[index].establishclientconn = resources[index].establishclientconn;
          nstcpprofileArray[index].tcpsegoffload = resources[index].tcpsegoffload;
          nstcpprofileArray[index].rstwindowattenuate = resources[index].rstwindowattenuate;
          nstcpprofileArray[index].rstmaxack = resources[index].rstmaxack;
          nstcpprofileArray[index].spoofsyndrop = resources[index].spoofsyndrop;
          nstcpprofileArray[index].ecn = resources[index].ecn;
          nstcpprofileArray[index].mptcpdropdataonpreestsf = resources[index].mptcpdropdataonpreestsf;
          nstcpprofileArray[index].mptcpfastopen = resources[index].mptcpfastopen;
          nstcpprofileArray[index].mptcpsessiontimeout = resources[index].mptcpsessiontimeout;
          nstcpprofileArray[index].timestamp = resources[index].timestamp;
          nstcpprofileArray[index].dsack = resources[index].dsack;
          nstcpprofileArray[index].ackaggregation = resources[index].ackaggregation;
          nstcpprofileArray[index].frto = resources[index].frto;
          nstcpprofileArray[index].maxcwnd = resources[index].maxcwnd;
          nstcpprofileArray[index].fack = resources[index].fack;
          nstcpprofileArray[index].tcpmode = resources[index].tcpmode;
        }
        baseResponses = base_resource.add_bulk_request(client, (base_resource[]) nstcpprofileArray);
      }
      return baseResponses;
    }

    public static base_response delete(nitro_service client, string name) => new nstcpprofile()
    {
      name = name
    }.delete_resource(client);

    public static base_response delete(nitro_service client, nstcpprofile resource) => new nstcpprofile()
    {
      name = resource.name
    }.delete_resource(client);

    public static base_responses delete(nitro_service client, string[] name)
    {
      base_responses baseResponses = (base_responses) null;
      if (name != null && name.Length > 0)
      {
        nstcpprofile[] nstcpprofileArray = new nstcpprofile[name.Length];
        for (int index = 0; index < name.Length; ++index)
        {
          nstcpprofileArray[index] = new nstcpprofile();
          nstcpprofileArray[index].name = name[index];
        }
        baseResponses = base_resource.delete_bulk_request(client, (base_resource[]) nstcpprofileArray);
      }
      return baseResponses;
    }

    public static base_responses delete(
      nitro_service client,
      nstcpprofile[] resources)
    {
      base_responses baseResponses = (base_responses) null;
      if (resources != null && resources.Length > 0)
      {
        nstcpprofile[] nstcpprofileArray = new nstcpprofile[resources.Length];
        for (int index = 0; index < resources.Length; ++index)
        {
          nstcpprofileArray[index] = new nstcpprofile();
          nstcpprofileArray[index].name = resources[index].name;
        }
        baseResponses = base_resource.delete_bulk_request(client, (base_resource[]) nstcpprofileArray);
      }
      return baseResponses;
    }

    public static base_response update(nitro_service client, nstcpprofile resource) => new nstcpprofile()
    {
      name = resource.name,
      ws = resource.ws,
      sack = resource.sack,
      wsval = resource.wsval,
      nagle = resource.nagle,
      ackonpush = resource.ackonpush,
      mss = resource.mss,
      maxburst = resource.maxburst,
      initialcwnd = resource.initialcwnd,
      delayedack = resource.delayedack,
      oooqsize = resource.oooqsize,
      maxpktpermss = resource.maxpktpermss,
      pktperretx = resource.pktperretx,
      minrto = resource.minrto,
      slowstartincr = resource.slowstartincr,
      buffersize = resource.buffersize,
      syncookie = resource.syncookie,
      kaprobeupdatelastactivity = resource.kaprobeupdatelastactivity,
      flavor = resource.flavor,
      dynamicreceivebuffering = resource.dynamicreceivebuffering,
      ka = resource.ka,
      kaconnidletime = resource.kaconnidletime,
      kamaxprobes = resource.kamaxprobes,
      kaprobeinterval = resource.kaprobeinterval,
      sendbuffsize = resource.sendbuffsize,
      mptcp = resource.mptcp,
      establishclientconn = resource.establishclientconn,
      tcpsegoffload = resource.tcpsegoffload,
      rstwindowattenuate = resource.rstwindowattenuate,
      rstmaxack = resource.rstmaxack,
      spoofsyndrop = resource.spoofsyndrop,
      ecn = resource.ecn,
      mptcpdropdataonpreestsf = resource.mptcpdropdataonpreestsf,
      mptcpfastopen = resource.mptcpfastopen,
      mptcpsessiontimeout = resource.mptcpsessiontimeout,
      timestamp = resource.timestamp,
      dsack = resource.dsack,
      ackaggregation = resource.ackaggregation,
      frto = resource.frto,
      maxcwnd = resource.maxcwnd,
      fack = resource.fack,
      tcpmode = resource.tcpmode
    }.update_resource(client);

    public static base_responses update(
      nitro_service client,
      nstcpprofile[] resources)
    {
      base_responses baseResponses = (base_responses) null;
      if (resources != null && resources.Length > 0)
      {
        nstcpprofile[] nstcpprofileArray = new nstcpprofile[resources.Length];
        for (int index = 0; index < resources.Length; ++index)
        {
          nstcpprofileArray[index] = new nstcpprofile();
          nstcpprofileArray[index].name = resources[index].name;
          nstcpprofileArray[index].ws = resources[index].ws;
          nstcpprofileArray[index].sack = resources[index].sack;
          nstcpprofileArray[index].wsval = resources[index].wsval;
          nstcpprofileArray[index].nagle = resources[index].nagle;
          nstcpprofileArray[index].ackonpush = resources[index].ackonpush;
          nstcpprofileArray[index].mss = resources[index].mss;
          nstcpprofileArray[index].maxburst = resources[index].maxburst;
          nstcpprofileArray[index].initialcwnd = resources[index].initialcwnd;
          nstcpprofileArray[index].delayedack = resources[index].delayedack;
          nstcpprofileArray[index].oooqsize = resources[index].oooqsize;
          nstcpprofileArray[index].maxpktpermss = resources[index].maxpktpermss;
          nstcpprofileArray[index].pktperretx = resources[index].pktperretx;
          nstcpprofileArray[index].minrto = resources[index].minrto;
          nstcpprofileArray[index].slowstartincr = resources[index].slowstartincr;
          nstcpprofileArray[index].buffersize = resources[index].buffersize;
          nstcpprofileArray[index].syncookie = resources[index].syncookie;
          nstcpprofileArray[index].kaprobeupdatelastactivity = resources[index].kaprobeupdatelastactivity;
          nstcpprofileArray[index].flavor = resources[index].flavor;
          nstcpprofileArray[index].dynamicreceivebuffering = resources[index].dynamicreceivebuffering;
          nstcpprofileArray[index].ka = resources[index].ka;
          nstcpprofileArray[index].kaconnidletime = resources[index].kaconnidletime;
          nstcpprofileArray[index].kamaxprobes = resources[index].kamaxprobes;
          nstcpprofileArray[index].kaprobeinterval = resources[index].kaprobeinterval;
          nstcpprofileArray[index].sendbuffsize = resources[index].sendbuffsize;
          nstcpprofileArray[index].mptcp = resources[index].mptcp;
          nstcpprofileArray[index].establishclientconn = resources[index].establishclientconn;
          nstcpprofileArray[index].tcpsegoffload = resources[index].tcpsegoffload;
          nstcpprofileArray[index].rstwindowattenuate = resources[index].rstwindowattenuate;
          nstcpprofileArray[index].rstmaxack = resources[index].rstmaxack;
          nstcpprofileArray[index].spoofsyndrop = resources[index].spoofsyndrop;
          nstcpprofileArray[index].ecn = resources[index].ecn;
          nstcpprofileArray[index].mptcpdropdataonpreestsf = resources[index].mptcpdropdataonpreestsf;
          nstcpprofileArray[index].mptcpfastopen = resources[index].mptcpfastopen;
          nstcpprofileArray[index].mptcpsessiontimeout = resources[index].mptcpsessiontimeout;
          nstcpprofileArray[index].timestamp = resources[index].timestamp;
          nstcpprofileArray[index].dsack = resources[index].dsack;
          nstcpprofileArray[index].ackaggregation = resources[index].ackaggregation;
          nstcpprofileArray[index].frto = resources[index].frto;
          nstcpprofileArray[index].maxcwnd = resources[index].maxcwnd;
          nstcpprofileArray[index].fack = resources[index].fack;
          nstcpprofileArray[index].tcpmode = resources[index].tcpmode;
        }
        baseResponses = base_resource.update_bulk_request(client, (base_resource[]) nstcpprofileArray);
      }
      return baseResponses;
    }

    public static base_response unset(
      nitro_service client,
      string name,
      string[] args)
    {
      return new nstcpprofile() { name = name }.unset_resource(client, args);
    }

    public static base_response unset(
      nitro_service client,
      nstcpprofile resource,
      string[] args)
    {
      return new nstcpprofile() { name = resource.name }.unset_resource(client, args);
    }

    public static base_responses unset(
      nitro_service client,
      string[] name,
      string[] args)
    {
      base_responses baseResponses = (base_responses) null;
      if (name != null && name.Length > 0)
      {
        nstcpprofile[] nstcpprofileArray = new nstcpprofile[name.Length];
        for (int index = 0; index < name.Length; ++index)
        {
          nstcpprofileArray[index] = new nstcpprofile();
          nstcpprofileArray[index].name = name[index];
        }
        baseResponses = base_resource.unset_bulk_request(client, (base_resource[]) nstcpprofileArray, args);
      }
      return baseResponses;
    }

    public static base_responses unset(
      nitro_service client,
      nstcpprofile[] resources,
      string[] args)
    {
      base_responses baseResponses = (base_responses) null;
      if (resources != null && resources.Length > 0)
      {
        nstcpprofile[] nstcpprofileArray = new nstcpprofile[resources.Length];
        for (int index = 0; index < resources.Length; ++index)
        {
          nstcpprofileArray[index] = new nstcpprofile();
          nstcpprofileArray[index].name = resources[index].name;
        }
        baseResponses = base_resource.unset_bulk_request(client, (base_resource[]) nstcpprofileArray, args);
      }
      return baseResponses;
    }

    public static nstcpprofile[] get(nitro_service service) => (nstcpprofile[]) new nstcpprofile().get_resources(service, (options) null);

    public static nstcpprofile[] get(nitro_service service, options option) => (nstcpprofile[]) new nstcpprofile().get_resources(service, option);

    public static nstcpprofile get(nitro_service service, string name) => (nstcpprofile) new nstcpprofile()
    {
      name = name
    }.get_resource(service);

    public static nstcpprofile[] get(nitro_service service, string[] name)
    {
      if (name == null || name.Length <= 0)
        return (nstcpprofile[]) null;
      nstcpprofile[] nstcpprofileArray1 = new nstcpprofile[name.Length];
      nstcpprofile[] nstcpprofileArray2 = new nstcpprofile[name.Length];
      for (int index = 0; index < name.Length; ++index)
      {
        nstcpprofileArray2[index] = new nstcpprofile();
        nstcpprofileArray2[index].name = name[index];
        nstcpprofileArray1[index] = (nstcpprofile) nstcpprofileArray2[index].get_resource(service);
      }
      return nstcpprofileArray1;
    }

    public static nstcpprofile[] get_filtered(nitro_service service, string filter)
    {
      nstcpprofile nstcpprofile = new nstcpprofile();
      options option = new options();
      option.set_filter(filter);
      return (nstcpprofile[]) nstcpprofile.getfiltered(service, option);
    }

    public static nstcpprofile[] get_filtered(
      nitro_service service,
      filtervalue[] filter)
    {
      nstcpprofile nstcpprofile = new nstcpprofile();
      options option = new options();
      option.set_filter(filter);
      return (nstcpprofile[]) nstcpprofile.getfiltered(service, option);
    }

    public static uint count(nitro_service service)
    {
      nstcpprofile nstcpprofile = new nstcpprofile();
      options option = new options();
      option.set_count(true);
      nstcpprofile[] resources = (nstcpprofile[]) nstcpprofile.get_resources(service, option);
      return resources != null && resources.Length > 0 ? resources[0].__count.Value : 0U;
    }

    public static uint count_filtered(nitro_service service, string filter)
    {
      nstcpprofile nstcpprofile = new nstcpprofile();
      options option = new options();
      option.set_count(true);
      option.set_filter(filter);
      nstcpprofile[] nstcpprofileArray = (nstcpprofile[]) nstcpprofile.getfiltered(service, option);
      return nstcpprofileArray != null && nstcpprofileArray.Length > 0 ? nstcpprofileArray[0].__count.Value : 0U;
    }

    public static uint count_filtered(nitro_service service, filtervalue[] filter)
    {
      nstcpprofile nstcpprofile = new nstcpprofile();
      options option = new options();
      option.set_count(true);
      option.set_filter(filter);
      nstcpprofile[] nstcpprofileArray = (nstcpprofile[]) nstcpprofile.getfiltered(service, option);
      return nstcpprofileArray != null && nstcpprofileArray.Length > 0 ? nstcpprofileArray[0].__count.Value : 0U;
    }

    private class nstcpprofile_response : base_response
    {
      public nstcpprofile[] nstcpprofile = (nstcpprofile[]) null;
    }

    public static class kaprobeupdatelastactivityEnum
    {
      public const string ENABLED = "ENABLED";
      public const string DISABLED = "DISABLED";
    }

    public static class mptcpdropdataonpreestsfEnum
    {
      public const string ENABLED = "ENABLED";
      public const string DISABLED = "DISABLED";
    }

    public static class ecnEnum
    {
      public const string ENABLED = "ENABLED";
      public const string DISABLED = "DISABLED";
    }

    public static class spoofsyndropEnum
    {
      public const string ENABLED = "ENABLED";
      public const string DISABLED = "DISABLED";
    }

    public static class dsackEnum
    {
      public const string ENABLED = "ENABLED";
      public const string DISABLED = "DISABLED";
    }

    public static class mptcpEnum
    {
      public const string ENABLED = "ENABLED";
      public const string DISABLED = "DISABLED";
    }

    public static class frtoEnum
    {
      public const string ENABLED = "ENABLED";
      public const string DISABLED = "DISABLED";
    }

    public static class establishclientconnEnum
    {
      public const string AUTOMATIC = "AUTOMATIC";
      public const string CONN_ESTABLISHED = "CONN_ESTABLISHED";
      public const string ON_FIRST_DATA = "ON_FIRST_DATA";
    }

    public static class flavorEnum
    {
      public const string Default = "Default";
      public const string Westwood = "Westwood";
      public const string BIC = "BIC";
      public const string CUBIC = "CUBIC";
      public const string Nile = "Nile";
    }

    public static class builtinEnum
    {
      public const string MODIFIABLE = "MODIFIABLE";
      public const string DELETABLE = "DELETABLE";
      public const string IMMUTABLE = "IMMUTABLE";
      public const string PARTITION_ALL = "PARTITION_ALL";
    }

    public static class tcpmodeEnum
    {
      public const string TRANSPARENT = "TRANSPARENT";
      public const string ENDPOINT = "ENDPOINT";
    }

    public static class mptcpfastopenEnum
    {
      public const string ENABLED = "ENABLED";
      public const string DISABLED = "DISABLED";
    }

    public static class dynamicreceivebufferingEnum
    {
      public const string ENABLED = "ENABLED";
      public const string DISABLED = "DISABLED";
    }

    public static class tcpsegoffloadEnum
    {
      public const string AUTOMATIC = "AUTOMATIC";
      public const string DISABLED = "DISABLED";
    }

    public static class sackEnum
    {
      public const string ENABLED = "ENABLED";
      public const string DISABLED = "DISABLED";
    }

    public static class wsEnum
    {
      public const string ENABLED = "ENABLED";
      public const string DISABLED = "DISABLED";
    }

    public static class syncookieEnum
    {
      public const string ENABLED = "ENABLED";
      public const string DISABLED = "DISABLED";
    }

    public static class ackonpushEnum
    {
      public const string ENABLED = "ENABLED";
      public const string DISABLED = "DISABLED";
    }

    public static class timestampEnum
    {
      public const string ENABLED = "ENABLED";
      public const string DISABLED = "DISABLED";
    }

    public static class kaEnum
    {
      public const string ENABLED = "ENABLED";
      public const string DISABLED = "DISABLED";
    }

    public static class rstmaxackEnum
    {
      public const string ENABLED = "ENABLED";
      public const string DISABLED = "DISABLED";
    }

    public static class rstwindowattenuateEnum
    {
      public const string ENABLED = "ENABLED";
      public const string DISABLED = "DISABLED";
    }

    public static class ackaggregationEnum
    {
      public const string ENABLED = "ENABLED";
      public const string DISABLED = "DISABLED";
    }

    public static class nagleEnum
    {
      public const string ENABLED = "ENABLED";
      public const string DISABLED = "DISABLED";
    }

    public static class fackEnum
    {
      public const string ENABLED = "ENABLED";
      public const string DISABLED = "DISABLED";
    }
  }
}
