// Decompiled with JetBrains decompiler
// Type: com.citrix.netscaler.nitro.resource.config.network.Interface
// Assembly: nitro, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 6CF5DDEF-E052-4F9D-953F-6644F8378A66


using com.citrix.netscaler.nitro.exception;
using com.citrix.netscaler.nitro.resource.Base;
using com.citrix.netscaler.nitro.service;
using com.citrix.netscaler.nitro.util;

namespace com.citrix.netscaler.nitro.resource.config.network
{
  public class Interface : base_resource
  {
    private string idField = (string) null;
    private string speedField = (string) null;
    private string duplexField = (string) null;
    private string flowctlField = (string) null;
    private string autonegField = (string) null;
    private string hamonitorField = (string) null;
    private uint? mtuField = new uint?();
    private string tagallField = (string) null;
    private string trunkField = (string) null;
    private string lacpmodeField = (string) null;
    private uint? lacpkeyField = new uint?();
    private string lagtypeField = (string) null;
    private uint? lacppriorityField = new uint?();
    private string lacptimeoutField = (string) null;
    private string ifaliasField = (string) null;
    private uint? throughputField = new uint?();
    private string linkredundancyField = (string) null;
    private uint? bandwidthhighField = new uint?();
    private uint? bandwidthnormalField = new uint?();
    private string lldpmodeField = (string) null;
    private uint? lrsetpriorityField = new uint?();
    private string devicenameField = (string) null;
    private uint? unitField = new uint?();
    private string descriptionField = (string) null;
    private uint? flagsField = new uint?();
    private uint? actualmtuField = new uint?();
    private uint? vlanField = new uint?();
    private string macField = (string) null;
    private uint? uptimeField = new uint?();
    private uint? downtimeField = new uint?();
    private string reqmediaField = (string) null;
    private string reqspeedField = (string) null;
    private string reqduplexField = (string) null;
    private string reqflowcontrolField = (string) null;
    private string actmediaField = (string) null;
    private string actspeedField = (string) null;
    private string actduplexField = (string) null;
    private string actflowctlField = (string) null;
    private string conndistrField = (string) null;
    private string macdistrField = (string) null;
    private string modeField = (string) null;
    private string stateField = (string) null;
    private uint? autonegresultField = new uint?();
    private uint? taggedField = new uint?();
    private uint? taggedanyField = new uint?();
    private uint? taggedautolearnField = new uint?();
    private uint? hangdetectField = new uint?();
    private uint? hangresetField = new uint?();
    private uint? linkstateField = new uint?();
    private uint? intfstateField = new uint?();
    private long? rxpacketsField = new long?();
    private long? rxbytesField = new long?();
    private long? rxerrorsField = new long?();
    private long? rxdropsField = new long?();
    private long? txpacketsField = new long?();
    private long? txbytesField = new long?();
    private long? txerrorsField = new long?();
    private long? txdropsField = new long?();
    private long? indiscField = new long?();
    private long? outdiscField = new long?();
    private long? fctlsField = new long?();
    private uint? hangsField = new uint?();
    private uint? stsstallsField = new uint?();
    private uint? txstallsField = new uint?();
    private uint? rxstallsField = new uint?();
    private long? bdgmacmovedField = new long?();
    private uint? bdgmutedField = new uint?();
    private string vmacField = (string) null;
    private string vmac6Field = (string) null;
    private uint? reqthroughputField = new uint?();
    private uint? actthroughputField = new uint?();
    private string backplaneField = (string) null;
    private string[] ifnumField = (string[]) null;
    private uint? cleartimeField = new uint?();
    private uint? slavestateField = new uint?();
    private uint? slavemediaField = new uint?();
    private uint? slavespeedField = new uint?();
    private uint? slaveduplexField = new uint?();
    private uint? slaveflowctlField = new uint?();
    private uint? slavetimeField = new uint?();
    private string intftypeField = (string) null;
    private string lacpactormodeField = (string) null;
    private string lacpactortimeoutField = (string) null;
    private uint? lacpactorpriorityField = new uint?();
    private uint? lacpactorportnoField = new uint?();
    private string lacppartnerstateField = (string) null;
    private string lacppartnertimeoutField = (string) null;
    private string lacppartneraggregationField = (string) null;
    private string lacppartnerinsyncField = (string) null;
    private string lacppartnercollectingField = (string) null;
    private string lacppartnerdistributingField = (string) null;
    private string lacppartnerdefaultedField = (string) null;
    private string lacppartnerexpiredField = (string) null;
    private uint? lacppartnerpriorityField = new uint?();
    private string lacppartnersystemmacField = (string) null;
    private uint? lacppartnersystempriorityField = new uint?();
    private uint? lacppartnerportnoField = new uint?();
    private uint? lacppartnerkeyField = new uint?();
    private string lacpactoraggregationField = (string) null;
    private string lacpactorinsyncField = (string) null;
    private string lacpactorcollectingField = (string) null;
    private string lacpactordistributingField = (string) null;
    private string lacpportmuxstateField = (string) null;
    private string lacpportrxstatField = (string) null;
    private string lacpportselectstateField = (string) null;
    private bool? lractiveintfField = new bool?();
    private uint? __countField = new uint?();

    public uint? __count
    {
      get => this.__countField;
      private set => this.__countField = value;
    }

    public string id
    {
      get => this.idField;
      set => this.idField = value;
    }

    public string speed
    {
      get => this.speedField;
      set => this.speedField = value;
    }

    public string duplex
    {
      get => this.duplexField;
      set => this.duplexField = value;
    }

    public string flowctl
    {
      get => this.flowctlField;
      set => this.flowctlField = value;
    }

    public string autoneg
    {
      get => this.autonegField;
      set => this.autonegField = value;
    }

    public string hamonitor
    {
      get => this.hamonitorField;
      set => this.hamonitorField = value;
    }

    public uint? mtu
    {
      get => this.mtuField;
      set => this.mtuField = value;
    }

    public string tagall
    {
      get => this.tagallField;
      set => this.tagallField = value;
    }

    public string trunk
    {
      get => this.trunkField;
      set => this.trunkField = value;
    }

    public string lacpmode
    {
      get => this.lacpmodeField;
      set => this.lacpmodeField = value;
    }

    public uint? lacpkey
    {
      get => this.lacpkeyField;
      set => this.lacpkeyField = value;
    }

    public string lagtype
    {
      get => this.lagtypeField;
      set => this.lagtypeField = value;
    }

    public uint? lacppriority
    {
      get => this.lacppriorityField;
      set => this.lacppriorityField = value;
    }

    public string lacptimeout
    {
      get => this.lacptimeoutField;
      set => this.lacptimeoutField = value;
    }

    public string ifalias
    {
      get => this.ifaliasField;
      set => this.ifaliasField = value;
    }

    public uint? throughput
    {
      get => this.throughputField;
      set => this.throughputField = value;
    }

    public string linkredundancy
    {
      get => this.linkredundancyField;
      set => this.linkredundancyField = value;
    }

    public uint? bandwidthhigh
    {
      get => this.bandwidthhighField;
      set => this.bandwidthhighField = value;
    }

    public uint? bandwidthnormal
    {
      get => this.bandwidthnormalField;
      set => this.bandwidthnormalField = value;
    }

    public string lldpmode
    {
      get => this.lldpmodeField;
      set => this.lldpmodeField = value;
    }

    public uint? lrsetpriority
    {
      get => this.lrsetpriorityField;
      set => this.lrsetpriorityField = value;
    }

    public string devicename
    {
      get => this.devicenameField;
      private set => this.devicenameField = value;
    }

    public uint? unit
    {
      get => this.unitField;
      private set => this.unitField = value;
    }

    public string description
    {
      get => this.descriptionField;
      private set => this.descriptionField = value;
    }

    public uint? flags
    {
      get => this.flagsField;
      private set => this.flagsField = value;
    }

    public uint? actualmtu
    {
      get => this.actualmtuField;
      private set => this.actualmtuField = value;
    }

    public uint? vlan
    {
      get => this.vlanField;
      private set => this.vlanField = value;
    }

    public string mac
    {
      get => this.macField;
      private set => this.macField = value;
    }

    public uint? uptime
    {
      get => this.uptimeField;
      private set => this.uptimeField = value;
    }

    public uint? downtime
    {
      get => this.downtimeField;
      private set => this.downtimeField = value;
    }

    public string reqmedia
    {
      get => this.reqmediaField;
      private set => this.reqmediaField = value;
    }

    public string reqspeed
    {
      get => this.reqspeedField;
      private set => this.reqspeedField = value;
    }

    public string reqduplex
    {
      get => this.reqduplexField;
      private set => this.reqduplexField = value;
    }

    public string reqflowcontrol
    {
      get => this.reqflowcontrolField;
      private set => this.reqflowcontrolField = value;
    }

    public string actmedia
    {
      get => this.actmediaField;
      private set => this.actmediaField = value;
    }

    public string actspeed
    {
      get => this.actspeedField;
      private set => this.actspeedField = value;
    }

    public string actduplex
    {
      get => this.actduplexField;
      private set => this.actduplexField = value;
    }

    public string actflowctl
    {
      get => this.actflowctlField;
      private set => this.actflowctlField = value;
    }

    public string conndistr
    {
      get => this.conndistrField;
      private set => this.conndistrField = value;
    }

    public string macdistr
    {
      get => this.macdistrField;
      private set => this.macdistrField = value;
    }

    public string mode
    {
      get => this.modeField;
      private set => this.modeField = value;
    }

    public string state
    {
      get => this.stateField;
      private set => this.stateField = value;
    }

    public uint? autonegresult
    {
      get => this.autonegresultField;
      private set => this.autonegresultField = value;
    }

    public uint? tagged
    {
      get => this.taggedField;
      private set => this.taggedField = value;
    }

    public uint? taggedany
    {
      get => this.taggedanyField;
      private set => this.taggedanyField = value;
    }

    public uint? taggedautolearn
    {
      get => this.taggedautolearnField;
      private set => this.taggedautolearnField = value;
    }

    public uint? hangdetect
    {
      get => this.hangdetectField;
      private set => this.hangdetectField = value;
    }

    public uint? hangreset
    {
      get => this.hangresetField;
      private set => this.hangresetField = value;
    }

    public uint? linkstate
    {
      get => this.linkstateField;
      private set => this.linkstateField = value;
    }

    public uint? intfstate
    {
      get => this.intfstateField;
      private set => this.intfstateField = value;
    }

    public long? rxpackets
    {
      get => this.rxpacketsField;
      private set => this.rxpacketsField = value;
    }

    public long? rxbytes
    {
      get => this.rxbytesField;
      private set => this.rxbytesField = value;
    }

    public long? rxerrors
    {
      get => this.rxerrorsField;
      private set => this.rxerrorsField = value;
    }

    public long? rxdrops
    {
      get => this.rxdropsField;
      private set => this.rxdropsField = value;
    }

    public long? txpackets
    {
      get => this.txpacketsField;
      private set => this.txpacketsField = value;
    }

    public long? txbytes
    {
      get => this.txbytesField;
      private set => this.txbytesField = value;
    }

    public long? txerrors
    {
      get => this.txerrorsField;
      private set => this.txerrorsField = value;
    }

    public long? txdrops
    {
      get => this.txdropsField;
      private set => this.txdropsField = value;
    }

    public long? indisc
    {
      get => this.indiscField;
      private set => this.indiscField = value;
    }

    public long? outdisc
    {
      get => this.outdiscField;
      private set => this.outdiscField = value;
    }

    public long? fctls
    {
      get => this.fctlsField;
      private set => this.fctlsField = value;
    }

    public uint? hangs
    {
      get => this.hangsField;
      private set => this.hangsField = value;
    }

    public uint? stsstalls
    {
      get => this.stsstallsField;
      private set => this.stsstallsField = value;
    }

    public uint? txstalls
    {
      get => this.txstallsField;
      private set => this.txstallsField = value;
    }

    public uint? rxstalls
    {
      get => this.rxstallsField;
      private set => this.rxstallsField = value;
    }

    public long? bdgmacmoved
    {
      get => this.bdgmacmovedField;
      private set => this.bdgmacmovedField = value;
    }

    public uint? bdgmuted
    {
      get => this.bdgmutedField;
      private set => this.bdgmutedField = value;
    }

    public string vmac
    {
      get => this.vmacField;
      private set => this.vmacField = value;
    }

    public string vmac6
    {
      get => this.vmac6Field;
      private set => this.vmac6Field = value;
    }

    public uint? reqthroughput
    {
      get => this.reqthroughputField;
      private set => this.reqthroughputField = value;
    }

    public uint? actthroughput
    {
      get => this.actthroughputField;
      private set => this.actthroughputField = value;
    }

    public string backplane
    {
      get => this.backplaneField;
      private set => this.backplaneField = value;
    }

    public string[] ifnum
    {
      get => this.ifnumField;
      private set => this.ifnumField = value;
    }

    public uint? cleartime
    {
      get => this.cleartimeField;
      private set => this.cleartimeField = value;
    }

    public uint? slavestate
    {
      get => this.slavestateField;
      private set => this.slavestateField = value;
    }

    public uint? slavemedia
    {
      get => this.slavemediaField;
      private set => this.slavemediaField = value;
    }

    public uint? slavespeed
    {
      get => this.slavespeedField;
      private set => this.slavespeedField = value;
    }

    public uint? slaveduplex
    {
      get => this.slaveduplexField;
      private set => this.slaveduplexField = value;
    }

    public uint? slaveflowctl
    {
      get => this.slaveflowctlField;
      private set => this.slaveflowctlField = value;
    }

    public uint? slavetime
    {
      get => this.slavetimeField;
      private set => this.slavetimeField = value;
    }

    public string intftype
    {
      get => this.intftypeField;
      private set => this.intftypeField = value;
    }

    public string lacpactormode
    {
      get => this.lacpactormodeField;
      private set => this.lacpactormodeField = value;
    }

    public string lacpactortimeout
    {
      get => this.lacpactortimeoutField;
      private set => this.lacpactortimeoutField = value;
    }

    public uint? lacpactorpriority
    {
      get => this.lacpactorpriorityField;
      private set => this.lacpactorpriorityField = value;
    }

    public uint? lacpactorportno
    {
      get => this.lacpactorportnoField;
      private set => this.lacpactorportnoField = value;
    }

    public string lacppartnerstate
    {
      get => this.lacppartnerstateField;
      private set => this.lacppartnerstateField = value;
    }

    public string lacppartnertimeout
    {
      get => this.lacppartnertimeoutField;
      private set => this.lacppartnertimeoutField = value;
    }

    public string lacppartneraggregation
    {
      get => this.lacppartneraggregationField;
      private set => this.lacppartneraggregationField = value;
    }

    public string lacppartnerinsync
    {
      get => this.lacppartnerinsyncField;
      private set => this.lacppartnerinsyncField = value;
    }

    public string lacppartnercollecting
    {
      get => this.lacppartnercollectingField;
      private set => this.lacppartnercollectingField = value;
    }

    public string lacppartnerdistributing
    {
      get => this.lacppartnerdistributingField;
      private set => this.lacppartnerdistributingField = value;
    }

    public string lacppartnerdefaulted
    {
      get => this.lacppartnerdefaultedField;
      private set => this.lacppartnerdefaultedField = value;
    }

    public string lacppartnerexpired
    {
      get => this.lacppartnerexpiredField;
      private set => this.lacppartnerexpiredField = value;
    }

    public uint? lacppartnerpriority
    {
      get => this.lacppartnerpriorityField;
      private set => this.lacppartnerpriorityField = value;
    }

    public string lacppartnersystemmac
    {
      get => this.lacppartnersystemmacField;
      private set => this.lacppartnersystemmacField = value;
    }

    public uint? lacppartnersystempriority
    {
      get => this.lacppartnersystempriorityField;
      private set => this.lacppartnersystempriorityField = value;
    }

    public uint? lacppartnerportno
    {
      get => this.lacppartnerportnoField;
      private set => this.lacppartnerportnoField = value;
    }

    public uint? lacppartnerkey
    {
      get => this.lacppartnerkeyField;
      private set => this.lacppartnerkeyField = value;
    }

    public string lacpactoraggregation
    {
      get => this.lacpactoraggregationField;
      private set => this.lacpactoraggregationField = value;
    }

    public string lacpactorinsync
    {
      get => this.lacpactorinsyncField;
      private set => this.lacpactorinsyncField = value;
    }

    public string lacpactorcollecting
    {
      get => this.lacpactorcollectingField;
      private set => this.lacpactorcollectingField = value;
    }

    public string lacpactordistributing
    {
      get => this.lacpactordistributingField;
      private set => this.lacpactordistributingField = value;
    }

    public string lacpportmuxstate
    {
      get => this.lacpportmuxstateField;
      private set => this.lacpportmuxstateField = value;
    }

    public string lacpportrxstat
    {
      get => this.lacpportrxstatField;
      private set => this.lacpportrxstatField = value;
    }

    public string lacpportselectstate
    {
      get => this.lacpportselectstateField;
      private set => this.lacpportselectstateField = value;
    }

    public bool? lractiveintf
    {
      get => this.lractiveintfField;
      private set => this.lractiveintfField = value;
    }

    internal override base_resource[] get_nitro_response(
      nitro_service service,
      string response)
    {
      Interface.Interface_response interfaceResponse = new Interface.Interface_response();
      Interface.Interface_response resource = (Interface.Interface_response) service.get_payload_formatter().string_to_resource(interfaceResponse.GetType(), response);
      if (resource.errorcode != 0)
      {
        if (resource.errorcode == 444)
          service.clear_session();
        if (resource.severity == null)
          throw new nitro_exception(resource.message, resource.errorcode);
        if (resource.severity.Equals("ERROR"))
          throw new nitro_exception(resource.message, resource.errorcode);
      }
      return (base_resource[]) resource.Interface;
    }

    internal override string get_object_name() => this.id;

    public static base_response clear(nitro_service client, Interface resource) => new Interface()
    {
      id = resource.id
    }.perform_operation_byaction(client, nameof (clear));

    public static base_responses clear(nitro_service client, Interface[] resources)
    {
      base_responses baseResponses = (base_responses) null;
      if (resources != null && resources.Length > 0)
      {
        Interface[] interfaceArray = new Interface[resources.Length];
        for (int index = 0; index < resources.Length; ++index)
        {
          interfaceArray[index] = new Interface();
          interfaceArray[index].id = resources[index].id;
        }
        baseResponses = base_resource.perform_operation_bulk_request(client, (base_resource[]) interfaceArray, nameof (clear));
      }
      return baseResponses;
    }

    public static base_response update(nitro_service client, Interface resource) => new Interface()
    {
      id = resource.id,
      speed = resource.speed,
      duplex = resource.duplex,
      flowctl = resource.flowctl,
      autoneg = resource.autoneg,
      hamonitor = resource.hamonitor,
      mtu = resource.mtu,
      tagall = resource.tagall,
      trunk = resource.trunk,
      lacpmode = resource.lacpmode,
      lacpkey = resource.lacpkey,
      lagtype = resource.lagtype,
      lacppriority = resource.lacppriority,
      lacptimeout = resource.lacptimeout,
      ifalias = resource.ifalias,
      throughput = resource.throughput,
      linkredundancy = resource.linkredundancy,
      bandwidthhigh = resource.bandwidthhigh,
      bandwidthnormal = resource.bandwidthnormal,
      lldpmode = resource.lldpmode,
      lrsetpriority = resource.lrsetpriority
    }.update_resource(client);

    public static base_responses update(nitro_service client, Interface[] resources)
    {
      base_responses baseResponses = (base_responses) null;
      if (resources != null && resources.Length > 0)
      {
        Interface[] interfaceArray = new Interface[resources.Length];
        for (int index = 0; index < resources.Length; ++index)
        {
          interfaceArray[index] = new Interface();
          interfaceArray[index].id = resources[index].id;
          interfaceArray[index].speed = resources[index].speed;
          interfaceArray[index].duplex = resources[index].duplex;
          interfaceArray[index].flowctl = resources[index].flowctl;
          interfaceArray[index].autoneg = resources[index].autoneg;
          interfaceArray[index].hamonitor = resources[index].hamonitor;
          interfaceArray[index].mtu = resources[index].mtu;
          interfaceArray[index].tagall = resources[index].tagall;
          interfaceArray[index].trunk = resources[index].trunk;
          interfaceArray[index].lacpmode = resources[index].lacpmode;
          interfaceArray[index].lacpkey = resources[index].lacpkey;
          interfaceArray[index].lagtype = resources[index].lagtype;
          interfaceArray[index].lacppriority = resources[index].lacppriority;
          interfaceArray[index].lacptimeout = resources[index].lacptimeout;
          interfaceArray[index].ifalias = resources[index].ifalias;
          interfaceArray[index].throughput = resources[index].throughput;
          interfaceArray[index].linkredundancy = resources[index].linkredundancy;
          interfaceArray[index].bandwidthhigh = resources[index].bandwidthhigh;
          interfaceArray[index].bandwidthnormal = resources[index].bandwidthnormal;
          interfaceArray[index].lldpmode = resources[index].lldpmode;
          interfaceArray[index].lrsetpriority = resources[index].lrsetpriority;
        }
        baseResponses = base_resource.update_bulk_request(client, (base_resource[]) interfaceArray);
      }
      return baseResponses;
    }

    public static base_response unset(nitro_service client, string id, string[] args) => new Interface()
    {
      id = id
    }.unset_resource(client, args);

    public static base_response unset(
      nitro_service client,
      Interface resource,
      string[] args)
    {
      return new Interface() { id = resource.id }.unset_resource(client, args);
    }

    public static base_responses unset(
      nitro_service client,
      string[] id,
      string[] args)
    {
      base_responses baseResponses = (base_responses) null;
      if (id != null && id.Length > 0)
      {
        Interface[] interfaceArray = new Interface[id.Length];
        for (int index = 0; index < id.Length; ++index)
        {
          interfaceArray[index] = new Interface();
          interfaceArray[index].id = id[index];
        }
        baseResponses = base_resource.unset_bulk_request(client, (base_resource[]) interfaceArray, args);
      }
      return baseResponses;
    }

    public static base_responses unset(
      nitro_service client,
      Interface[] resources,
      string[] args)
    {
      base_responses baseResponses = (base_responses) null;
      if (resources != null && resources.Length > 0)
      {
        Interface[] interfaceArray = new Interface[resources.Length];
        for (int index = 0; index < resources.Length; ++index)
        {
          interfaceArray[index] = new Interface();
          interfaceArray[index].id = resources[index].id;
        }
        baseResponses = base_resource.unset_bulk_request(client, (base_resource[]) interfaceArray, args);
      }
      return baseResponses;
    }

    public static base_response enable(nitro_service client, string id) => new Interface()
    {
      id = id
    }.perform_operation_byaction(client, nameof (enable));

    public static base_response enable(nitro_service client, Interface resource) => new Interface()
    {
      id = resource.id
    }.perform_operation_byaction(client, nameof (enable));

    public static base_responses enable(nitro_service client, string[] id)
    {
      base_responses baseResponses = (base_responses) null;
      if (id != null && id.Length > 0)
      {
        Interface[] interfaceArray = new Interface[id.Length];
        for (int index = 0; index < id.Length; ++index)
        {
          interfaceArray[index] = new Interface();
          interfaceArray[index].id = id[index];
        }
        baseResponses = base_resource.perform_operation_bulk_request(client, (base_resource[]) interfaceArray, nameof (enable));
      }
      return baseResponses;
    }

    public static base_responses enable(nitro_service client, Interface[] resources)
    {
      base_responses baseResponses = (base_responses) null;
      if (resources != null && resources.Length > 0)
      {
        Interface[] interfaceArray = new Interface[resources.Length];
        for (int index = 0; index < resources.Length; ++index)
        {
          interfaceArray[index] = new Interface();
          interfaceArray[index].id = resources[index].id;
        }
        baseResponses = base_resource.perform_operation_bulk_request(client, (base_resource[]) interfaceArray, nameof (enable));
      }
      return baseResponses;
    }

    public static base_response disable(nitro_service client, string id) => new Interface()
    {
      id = id
    }.perform_operation_byaction(client, nameof (disable));

    public static base_response disable(nitro_service client, Interface resource) => new Interface()
    {
      id = resource.id
    }.perform_operation_byaction(client, nameof (disable));

    public static base_responses disable(nitro_service client, string[] id)
    {
      base_responses baseResponses = (base_responses) null;
      if (id != null && id.Length > 0)
      {
        Interface[] interfaceArray = new Interface[id.Length];
        for (int index = 0; index < id.Length; ++index)
        {
          interfaceArray[index] = new Interface();
          interfaceArray[index].id = id[index];
        }
        baseResponses = base_resource.perform_operation_bulk_request(client, (base_resource[]) interfaceArray, nameof (disable));
      }
      return baseResponses;
    }

    public static base_responses disable(nitro_service client, Interface[] resources)
    {
      base_responses baseResponses = (base_responses) null;
      if (resources != null && resources.Length > 0)
      {
        Interface[] interfaceArray = new Interface[resources.Length];
        for (int index = 0; index < resources.Length; ++index)
        {
          interfaceArray[index] = new Interface();
          interfaceArray[index].id = resources[index].id;
        }
        baseResponses = base_resource.perform_operation_bulk_request(client, (base_resource[]) interfaceArray, nameof (disable));
      }
      return baseResponses;
    }

    public static base_response reset(nitro_service client, Interface resource) => new Interface()
    {
      id = resource.id
    }.perform_operation_byaction(client, nameof (reset));

    public static base_responses reset(nitro_service client, Interface[] resources)
    {
      base_responses baseResponses = (base_responses) null;
      if (resources != null && resources.Length > 0)
      {
        Interface[] interfaceArray = new Interface[resources.Length];
        for (int index = 0; index < resources.Length; ++index)
        {
          interfaceArray[index] = new Interface();
          interfaceArray[index].id = resources[index].id;
        }
        baseResponses = base_resource.perform_operation_bulk_request(client, (base_resource[]) interfaceArray, nameof (reset));
      }
      return baseResponses;
    }

    public static Interface[] get(nitro_service service) => (Interface[]) new Interface().get_resources(service, (options) null);

    public static Interface[] get(nitro_service service, options option) => (Interface[]) new Interface().get_resources(service, option);

    public static Interface get(nitro_service service, string id) => (Interface) new Interface()
    {
      id = id
    }.get_resource(service);

    public static Interface[] get(nitro_service service, string[] id)
    {
      if (id == null || id.Length <= 0)
        return (Interface[]) null;
      Interface[] interfaceArray1 = new Interface[id.Length];
      Interface[] interfaceArray2 = new Interface[id.Length];
      for (int index = 0; index < id.Length; ++index)
      {
        interfaceArray2[index] = new Interface();
        interfaceArray2[index].id = id[index];
        interfaceArray1[index] = (Interface) interfaceArray2[index].get_resource(service);
      }
      return interfaceArray1;
    }

    public static Interface[] get_filtered(nitro_service service, string filter)
    {
      Interface @interface = new Interface();
      options option = new options();
      option.set_filter(filter);
      return (Interface[]) @interface.getfiltered(service, option);
    }

    public static Interface[] get_filtered(nitro_service service, filtervalue[] filter)
    {
      Interface @interface = new Interface();
      options option = new options();
      option.set_filter(filter);
      return (Interface[]) @interface.getfiltered(service, option);
    }

    public static uint count(nitro_service service)
    {
      Interface @interface = new Interface();
      options option = new options();
      option.set_count(true);
      Interface[] resources = (Interface[]) @interface.get_resources(service, option);
      return resources != null && resources.Length > 0 ? resources[0].__count.Value : 0U;
    }

    public static uint count_filtered(nitro_service service, string filter)
    {
      Interface @interface = new Interface();
      options option = new options();
      option.set_count(true);
      option.set_filter(filter);
      Interface[] interfaceArray = (Interface[]) @interface.getfiltered(service, option);
      return interfaceArray != null && interfaceArray.Length > 0 ? interfaceArray[0].__count.Value : 0U;
    }

    public static uint count_filtered(nitro_service service, filtervalue[] filter)
    {
      Interface @interface = new Interface();
      options option = new options();
      option.set_count(true);
      option.set_filter(filter);
      Interface[] interfaceArray = (Interface[]) @interface.getfiltered(service, option);
      return interfaceArray != null && interfaceArray.Length > 0 ? interfaceArray[0].__count.Value : 0U;
    }

    private class Interface_response : base_response
    {
      public Interface[] Interface = (Interface[]) null;
    }

    public static class lacpportselectstateEnum
    {
      public const string UNSELECTED = "UNSELECTED";
      public const string SELECTED = "SELECTED";
      public const string STANDBY = "STANDBY";
    }

    public static class reqduplexEnum
    {
      public const string AUTO = "AUTO";
      public const string HALF = "HALF";
      public const string FULL = "FULL";
    }

    public static class backplaneEnum
    {
      public const string ENABLED = "ENABLED";
      public const string DISABLED = "DISABLED";
    }

    public static class modeEnum
    {
      public const string MANUAL = "MANUAL";
      public const string AUTO = "AUTO";
    }

    public static class lacpportrxstatEnum
    {
      public const string INIT = "INIT";
      public const string PORT_DISABLED = "PORT_DISABLED";
      public const string LACP_DISABLED = "LACP_DISABLED";
      public const string EXPIRED = "EXPIRED";
      public const string DEFAULTED = "DEFAULTED";
      public const string CURRENT = "CURRENT";
    }

    public static class stateEnum
    {
      public const string ENABLED = "ENABLED";
      public const string DISABLED = "DISABLED";
    }

    public static class lacppartnerinsyncEnum
    {
      public const string NS_EMPTY_STR = "NS_EMPTY_STR";
      public const string SYNC = "SYNC";
    }

    public static class actduplexEnum
    {
      public const string AUTO = "AUTO";
      public const string HALF = "HALF";
      public const string FULL = "FULL";
    }

    public static class hamonitorEnum
    {
      public const string ON = "ON";
      public const string OFF = "OFF";
    }

    public static class lacppartnerdistributingEnum
    {
      public const string NS_EMPTY_STR = "NS_EMPTY_STR";
      public const string DISTRIBUTING = "DISTRIBUTING";
    }

    public static class lacppartnercollectingEnum
    {
      public const string NS_EMPTY_STR = "NS_EMPTY_STR";
      public const string COLLECTING = "COLLECTING";
    }

    public static class conndistrEnum
    {
      public const string DISABLED = "DISABLED";
      public const string ENABLED = "ENABLED";
    }

    public static class reqspeedEnum
    {
      public const string AUTO = "AUTO";
      public const string _10 = "10";
      public const string _100 = "100";
      public const string _1000 = "1000";
      public const string _10000 = "10000";
      public const string _40000 = "40000";
    }

    public static class duplexEnum
    {
      public const string AUTO = "AUTO";
      public const string HALF = "HALF";
      public const string FULL = "FULL";
    }

    public static class actspeedEnum
    {
      public const string AUTO = "AUTO";
      public const string _10 = "10";
      public const string _100 = "100";
      public const string _1000 = "1000";
      public const string _10000 = "10000";
      public const string _40000 = "40000";
    }

    public static class reqmediaEnum
    {
      public const string AUTO = "AUTO";
      public const string UTP = "UTP";
      public const string FIBER = "FIBER";
    }

    public static class lacppartnertimeoutEnum
    {
      public const string LONG = "LONG";
      public const string SHORT = "SHORT";
    }

    public static class intftypeEnum
    {
      public const string BROADCOM_5700_5701 = "BROADCOM 5700/5701";
      public const string TIGON1_TIGON2 = "TIGON1/TIGON2";
      public const string INTEL_82546 = "INTEL 82546";
      public const string INTEL_8255X_PRO_ = "INTEL 8255X(PRO)";
      public const string Link_Aggregate = "Link Aggregate";
      public const string Loopback = "Loopback";
      public const string Intel_82541_47 = "Intel 82541/47";
      public const string Broadcom_5704 = "Broadcom 5704";
      public const string Chelsio_1G = "Chelsio 1G";
      public const string Intel_8247X = "Intel 8247X";
      public const string Intel_82576_VF = "Intel 82576 VF";
      public const string Xen_Virtual = "Xen Virtual";
      public const string Intel_10G = "Intel 10G";
      public const string Intel_82599_VF = "Intel 82599 VF";
      public const string Hyper_v = "Hyper v";
      public const string Cluster_LAG = "Cluster LAG";
      public const string Intel_8247X_SFP = "Intel 8247X SFP";
      public const string XEN_Interface = "XEN Interface";
      public const string Chelsio_10G = "Chelsio 10G";
      public const string KVM_Virtio = "KVM Virtio";
    }

    public static class lldpmodeEnum
    {
      public const string NONE = "NONE";
      public const string TRANSMITTER = "TRANSMITTER";
      public const string RECEIVER = "RECEIVER";
      public const string TRANSCEIVER = "TRANSCEIVER";
    }

    public static class autonegEnum
    {
      public const string DISABLED = "DISABLED";
      public const string ENABLED = "ENABLED";
    }

    public static class lacppartnerexpiredEnum
    {
      public const string NS_EMPTY_STR = "NS_EMPTY_STR";
      public const string EXPIRED = "EXPIRED";
    }

    public static class macdistrEnum
    {
      public const string SOURCE = "SOURCE";
      public const string DESTINATION = "DESTINATION";
      public const string BOTH = "BOTH";
    }

    public static class lacppartnerstateEnum
    {
      public const string MANUAL = "MANUAL";
      public const string AUTO = "AUTO";
    }

    public static class lacpportmuxstateEnum
    {
      public const string DETACHED = "DETACHED";
      public const string WAITING = "WAITING";
      public const string ATTACHED = "ATTACHED";
      public const string COLLECTING = "COLLECTING";
      public const string DISTRIBUTING = "DISTRIBUTING";
    }

    public static class lacpactordistributingEnum
    {
      public const string NS_EMPTY_STR = "NS_EMPTY_STR";
      public const string DISTRIBUTING = "DISTRIBUTING";
    }

    public static class lacpactorinsyncEnum
    {
      public const string NS_EMPTY_STR = "NS_EMPTY_STR";
      public const string SYNC = "SYNC";
    }

    public static class lacppartnerdefaultedEnum
    {
      public const string NS_EMPTY_STR = "NS_EMPTY_STR";
      public const string DEFAULTED = "DEFAULTED";
    }

    public static class actmediaEnum
    {
      public const string AUTO = "AUTO";
      public const string UTP = "UTP";
      public const string FIBER = "FIBER";
    }

    public static class actflowctlEnum
    {
      public const string OFF = "OFF";
      public const string RX = "RX";
      public const string TX = "TX";
      public const string RXTX = "RXTX";
    }

    public static class lacpactormodeEnum
    {
      public const string DISABLED = "DISABLED";
      public const string ACTIVE = "ACTIVE";
      public const string PASSIVE = "PASSIVE";
    }

    public static class speedEnum
    {
      public const string AUTO = "AUTO";
      public const string _10 = "10";
      public const string _100 = "100";
      public const string _1000 = "1000";
      public const string _10000 = "10000";
      public const string _40000 = "40000";
    }

    public static class lacptimeoutEnum
    {
      public const string LONG = "LONG";
      public const string SHORT = "SHORT";
    }

    public static class tagallEnum
    {
      public const string ON = "ON";
      public const string OFF = "OFF";
    }

    public static class lacppartneraggregationEnum
    {
      public const string NS_EMPTY_STR = "NS_EMPTY_STR";
      public const string AGG = "AGG";
    }

    public static class lacpactortimeoutEnum
    {
      public const string LONG = "LONG";
      public const string SHORT = "SHORT";
    }

    public static class trunkEnum
    {
      public const string ON = "ON";
      public const string OFF = "OFF";
    }

    public static class lacpmodeEnum
    {
      public const string DISABLED = "DISABLED";
      public const string ACTIVE = "ACTIVE";
      public const string PASSIVE = "PASSIVE";
    }

    public static class reqflowcontrolEnum
    {
      public const string OFF = "OFF";
      public const string RX = "RX";
      public const string TX = "TX";
      public const string RXTX = "RXTX";
    }

    public static class lacpactorcollectingEnum
    {
      public const string NS_EMPTY_STR = "NS_EMPTY_STR";
      public const string COLLECTING = "COLLECTING";
    }

    public static class lacpactoraggregationEnum
    {
      public const string NS_EMPTY_STR = "NS_EMPTY_STR";
      public const string AGG = "AGG";
    }

    public static class linkredundancyEnum
    {
      public const string ON = "ON";
      public const string OFF = "OFF";
    }

    public static class flowctlEnum
    {
      public const string OFF = "OFF";
      public const string RX = "RX";
      public const string TX = "TX";
      public const string RXTX = "RXTX";
    }

    public static class lagtypeEnum
    {
      public const string NODE = "NODE";
      public const string CLUSTER = "CLUSTER";
    }
  }
}
