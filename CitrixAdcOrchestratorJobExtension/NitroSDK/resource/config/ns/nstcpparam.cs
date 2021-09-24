// Decompiled with JetBrains decompiler
// Type: com.citrix.netscaler.nitro.resource.config.ns.nstcpparam
// Assembly: nitro, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 6CF5DDEF-E052-4F9D-953F-6644F8378A66


using com.citrix.netscaler.nitro.exception;
using com.citrix.netscaler.nitro.resource.Base;
using com.citrix.netscaler.nitro.service;

namespace com.citrix.netscaler.nitro.resource.config.ns
{
  public class nstcpparam : base_resource
  {
    private string wsField = (string) null;
    private uint? wsvalField = new uint?();
    private string sackField = (string) null;
    private string learnvsvrmssField = (string) null;
    private uint? maxburstField = new uint?();
    private uint? initialcwndField = new uint?();
    private uint? recvbuffsizeField = new uint?();
    private uint? delayedackField = new uint?();
    private string downstaterstField = (string) null;
    private string nagleField = (string) null;
    private string limitedpersistField = (string) null;
    private uint? oooqsizeField = new uint?();
    private string ackonpushField = (string) null;
    private int? maxpktpermssField = new int?();
    private int? pktperretxField = new int?();
    private int? minrtoField = new int?();
    private int? slowstartincrField = new int?();
    private uint? maxdynserverprobesField = new uint?();
    private uint? synholdfastgiveupField = new uint?();
    private uint? maxsynholdperprobeField = new uint?();
    private uint? maxsynholdField = new uint?();
    private uint? msslearnintervalField = new uint?();
    private uint? msslearndelayField = new uint?();
    private uint? maxtimewaitconnField = new uint?();
    private string kaprobeupdatelastactivityField = (string) null;
    private uint? maxsynackretxField = new uint?();
    private string synattackdetectionField = (string) null;
    private string connflushifnomemField = (string) null;
    private uint? connflushthresField = new uint?();
    private string mptcpconcloseonpassivesfField = (string) null;
    private string mptcpchecksumField = (string) null;
    private long? mptcpsftimeoutField = new long?();
    private long? mptcpsfreplacetimeoutField = new long?();
    private uint? mptcpmaxsfField = new uint?();
    private uint? mptcpmaxpendingsfField = new uint?();
    private uint? mptcppendingjointhresholdField = new uint?();
    private uint? mptcprtostoswitchsfField = new uint?();
    private string mptcpusebackupondssField = (string) null;
    private uint? tcpmaxretriesField = new uint?();
    private string mptcpimmediatesfcloseonfinField = (string) null;
    private string mptcpclosemptcpsessiononlastsfcloseField = (string) null;
    private string[] builtinField = (string[]) null;

    public string ws
    {
      get => this.wsField;
      set => this.wsField = value;
    }

    public uint? wsval
    {
      get => this.wsvalField;
      set => this.wsvalField = value;
    }

    public string sack
    {
      get => this.sackField;
      set => this.sackField = value;
    }

    public string learnvsvrmss
    {
      get => this.learnvsvrmssField;
      set => this.learnvsvrmssField = value;
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

    public uint? recvbuffsize
    {
      get => this.recvbuffsizeField;
      set => this.recvbuffsizeField = value;
    }

    public uint? delayedack
    {
      get => this.delayedackField;
      set => this.delayedackField = value;
    }

    public string downstaterst
    {
      get => this.downstaterstField;
      set => this.downstaterstField = value;
    }

    public string nagle
    {
      get => this.nagleField;
      set => this.nagleField = value;
    }

    public string limitedpersist
    {
      get => this.limitedpersistField;
      set => this.limitedpersistField = value;
    }

    public uint? oooqsize
    {
      get => this.oooqsizeField;
      set => this.oooqsizeField = value;
    }

    public string ackonpush
    {
      get => this.ackonpushField;
      set => this.ackonpushField = value;
    }

    public int? maxpktpermss
    {
      get => this.maxpktpermssField;
      set => this.maxpktpermssField = value;
    }

    public int? pktperretx
    {
      get => this.pktperretxField;
      set => this.pktperretxField = value;
    }

    public int? minrto
    {
      get => this.minrtoField;
      set => this.minrtoField = value;
    }

    public int? slowstartincr
    {
      get => this.slowstartincrField;
      set => this.slowstartincrField = value;
    }

    public uint? maxdynserverprobes
    {
      get => this.maxdynserverprobesField;
      set => this.maxdynserverprobesField = value;
    }

    public uint? synholdfastgiveup
    {
      get => this.synholdfastgiveupField;
      set => this.synholdfastgiveupField = value;
    }

    public uint? maxsynholdperprobe
    {
      get => this.maxsynholdperprobeField;
      set => this.maxsynholdperprobeField = value;
    }

    public uint? maxsynhold
    {
      get => this.maxsynholdField;
      set => this.maxsynholdField = value;
    }

    public uint? msslearninterval
    {
      get => this.msslearnintervalField;
      set => this.msslearnintervalField = value;
    }

    public uint? msslearndelay
    {
      get => this.msslearndelayField;
      set => this.msslearndelayField = value;
    }

    public uint? maxtimewaitconn
    {
      get => this.maxtimewaitconnField;
      set => this.maxtimewaitconnField = value;
    }

    public string kaprobeupdatelastactivity
    {
      get => this.kaprobeupdatelastactivityField;
      set => this.kaprobeupdatelastactivityField = value;
    }

    public uint? maxsynackretx
    {
      get => this.maxsynackretxField;
      set => this.maxsynackretxField = value;
    }

    public string synattackdetection
    {
      get => this.synattackdetectionField;
      set => this.synattackdetectionField = value;
    }

    public string connflushifnomem
    {
      get => this.connflushifnomemField;
      set => this.connflushifnomemField = value;
    }

    public uint? connflushthres
    {
      get => this.connflushthresField;
      set => this.connflushthresField = value;
    }

    public string mptcpconcloseonpassivesf
    {
      get => this.mptcpconcloseonpassivesfField;
      set => this.mptcpconcloseonpassivesfField = value;
    }

    public string mptcpchecksum
    {
      get => this.mptcpchecksumField;
      set => this.mptcpchecksumField = value;
    }

    public long? mptcpsftimeout
    {
      get => this.mptcpsftimeoutField;
      set => this.mptcpsftimeoutField = value;
    }

    public long? mptcpsfreplacetimeout
    {
      get => this.mptcpsfreplacetimeoutField;
      set => this.mptcpsfreplacetimeoutField = value;
    }

    public uint? mptcpmaxsf
    {
      get => this.mptcpmaxsfField;
      set => this.mptcpmaxsfField = value;
    }

    public uint? mptcpmaxpendingsf
    {
      get => this.mptcpmaxpendingsfField;
      set => this.mptcpmaxpendingsfField = value;
    }

    public uint? mptcppendingjointhreshold
    {
      get => this.mptcppendingjointhresholdField;
      set => this.mptcppendingjointhresholdField = value;
    }

    public uint? mptcprtostoswitchsf
    {
      get => this.mptcprtostoswitchsfField;
      set => this.mptcprtostoswitchsfField = value;
    }

    public string mptcpusebackupondss
    {
      get => this.mptcpusebackupondssField;
      set => this.mptcpusebackupondssField = value;
    }

    public uint? tcpmaxretries
    {
      get => this.tcpmaxretriesField;
      set => this.tcpmaxretriesField = value;
    }

    public string mptcpimmediatesfcloseonfin
    {
      get => this.mptcpimmediatesfcloseonfinField;
      set => this.mptcpimmediatesfcloseonfinField = value;
    }

    public string mptcpclosemptcpsessiononlastsfclose
    {
      get => this.mptcpclosemptcpsessiononlastsfcloseField;
      set => this.mptcpclosemptcpsessiononlastsfcloseField = value;
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
      nstcpparam[] nstcpparamArray = new nstcpparam[1];
      nstcpparam.nstcpparam_response nstcpparamResponse = new nstcpparam.nstcpparam_response();
      nstcpparam.nstcpparam_response resource = (nstcpparam.nstcpparam_response) service.get_payload_formatter().string_to_resource(nstcpparamResponse.GetType(), response);
      if (resource.errorcode != 0)
      {
        if (resource.errorcode == 444)
          service.clear_session();
        if (resource.severity == null)
          throw new nitro_exception(resource.message, resource.errorcode);
        if (resource.severity.Equals("ERROR"))
          throw new nitro_exception(resource.message, resource.errorcode);
      }
      nstcpparamArray[0] = resource.nstcpparam;
      return (base_resource[]) nstcpparamArray;
    }

    internal override string get_object_name() => (string) null;

    public static base_response update(nitro_service client, nstcpparam resource) => new nstcpparam()
    {
      ws = resource.ws,
      wsval = resource.wsval,
      sack = resource.sack,
      learnvsvrmss = resource.learnvsvrmss,
      maxburst = resource.maxburst,
      initialcwnd = resource.initialcwnd,
      recvbuffsize = resource.recvbuffsize,
      delayedack = resource.delayedack,
      downstaterst = resource.downstaterst,
      nagle = resource.nagle,
      limitedpersist = resource.limitedpersist,
      oooqsize = resource.oooqsize,
      ackonpush = resource.ackonpush,
      maxpktpermss = resource.maxpktpermss,
      pktperretx = resource.pktperretx,
      minrto = resource.minrto,
      slowstartincr = resource.slowstartincr,
      maxdynserverprobes = resource.maxdynserverprobes,
      synholdfastgiveup = resource.synholdfastgiveup,
      maxsynholdperprobe = resource.maxsynholdperprobe,
      maxsynhold = resource.maxsynhold,
      msslearninterval = resource.msslearninterval,
      msslearndelay = resource.msslearndelay,
      maxtimewaitconn = resource.maxtimewaitconn,
      kaprobeupdatelastactivity = resource.kaprobeupdatelastactivity,
      maxsynackretx = resource.maxsynackretx,
      synattackdetection = resource.synattackdetection,
      connflushifnomem = resource.connflushifnomem,
      connflushthres = resource.connflushthres,
      mptcpconcloseonpassivesf = resource.mptcpconcloseonpassivesf,
      mptcpchecksum = resource.mptcpchecksum,
      mptcpsftimeout = resource.mptcpsftimeout,
      mptcpsfreplacetimeout = resource.mptcpsfreplacetimeout,
      mptcpmaxsf = resource.mptcpmaxsf,
      mptcpmaxpendingsf = resource.mptcpmaxpendingsf,
      mptcppendingjointhreshold = resource.mptcppendingjointhreshold,
      mptcprtostoswitchsf = resource.mptcprtostoswitchsf,
      mptcpusebackupondss = resource.mptcpusebackupondss,
      tcpmaxretries = resource.tcpmaxretries,
      mptcpimmediatesfcloseonfin = resource.mptcpimmediatesfcloseonfin,
      mptcpclosemptcpsessiononlastsfclose = resource.mptcpclosemptcpsessiononlastsfclose
    }.update_resource(client);

    public static base_response unset(
      nitro_service client,
      nstcpparam resource,
      string[] args)
    {
      return new nstcpparam().unset_resource(client, args);
    }

    public static nstcpparam get(nitro_service service) => ((nstcpparam[]) new nstcpparam().get_resources(service, (options) null))[0];

    public static nstcpparam get(nitro_service service, options option) => ((nstcpparam[]) new nstcpparam().get_resources(service, option))[0];

    private class nstcpparam_response : base_response
    {
      public nstcpparam nstcpparam = (nstcpparam) null;
    }

    public static class kaprobeupdatelastactivityEnum
    {
      public const string ENABLED = "ENABLED";
      public const string DISABLED = "DISABLED";
    }

    public static class mptcpusebackupondssEnum
    {
      public const string ENABLED = "ENABLED";
      public const string DISABLED = "DISABLED";
    }

    public static class mptcpclosemptcpsessiononlastsfcloseEnum
    {
      public const string ENABLED = "ENABLED";
      public const string DISABLED = "DISABLED";
    }

    public static class connflushifnomemEnum
    {
      public const string NONE = "NONE";
      public const string HALFCLOSED_AND_IDLE = "HALFCLOSED_AND_IDLE";
      public const string FIFO = "FIFO";
    }

    public static class mptcpconcloseonpassivesfEnum
    {
      public const string ENABLED = "ENABLED";
      public const string DISABLED = "DISABLED";
    }

    public static class builtinEnum
    {
      public const string MODIFIABLE = "MODIFIABLE";
      public const string DELETABLE = "DELETABLE";
      public const string IMMUTABLE = "IMMUTABLE";
      public const string PARTITION_ALL = "PARTITION_ALL";
    }

    public static class learnvsvrmssEnum
    {
      public const string ENABLED = "ENABLED";
      public const string DISABLED = "DISABLED";
    }

    public static class synattackdetectionEnum
    {
      public const string ENABLED = "ENABLED";
      public const string DISABLED = "DISABLED";
    }

    public static class mptcpimmediatesfcloseonfinEnum
    {
      public const string ENABLED = "ENABLED";
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

    public static class ackonpushEnum
    {
      public const string ENABLED = "ENABLED";
      public const string DISABLED = "DISABLED";
    }

    public static class downstaterstEnum
    {
      public const string ENABLED = "ENABLED";
      public const string DISABLED = "DISABLED";
    }

    public static class nagleEnum
    {
      public const string ENABLED = "ENABLED";
      public const string DISABLED = "DISABLED";
    }

    public static class limitedpersistEnum
    {
      public const string ENABLED = "ENABLED";
      public const string DISABLED = "DISABLED";
    }

    public static class mptcpchecksumEnum
    {
      public const string ENABLED = "ENABLED";
      public const string DISABLED = "DISABLED";
    }
  }
}
