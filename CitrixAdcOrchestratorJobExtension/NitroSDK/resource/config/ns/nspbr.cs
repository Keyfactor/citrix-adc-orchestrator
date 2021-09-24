// Decompiled with JetBrains decompiler
// Type: com.citrix.netscaler.nitro.resource.config.ns.nspbr
// Assembly: nitro, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 6CF5DDEF-E052-4F9D-953F-6644F8378A66


using com.citrix.netscaler.nitro.exception;
using com.citrix.netscaler.nitro.resource.Base;
using com.citrix.netscaler.nitro.service;
using com.citrix.netscaler.nitro.util;

namespace com.citrix.netscaler.nitro.resource.config.ns
{
  public class nspbr : base_resource
  {
    private string nameField = (string) null;
    private string actionField = (string) null;
    private uint? tdField = new uint?();
    private bool? srcipField = new bool?();
    private string srcipopField = (string) null;
    private string srcipvalField = (string) null;
    private bool? srcportField = new bool?();
    private string srcportopField = (string) null;
    private string srcportvalField = (string) null;
    private bool? destipField = new bool?();
    private string destipopField = (string) null;
    private string destipvalField = (string) null;
    private bool? destportField = new bool?();
    private string destportopField = (string) null;
    private string destportvalField = (string) null;
    private bool? nexthopField = new bool?();
    private string nexthopvalField = (string) null;
    private bool? iptunnelField = new bool?();
    private string iptunnelnameField = (string) null;
    private string srcmacField = (string) null;
    private string srcmacmaskField = (string) null;
    private string protocolField = (string) null;
    private uint? protocolnumberField = new uint?();
    private uint? vlanField = new uint?();
    private uint? vxlanField = new uint?();
    private string InterfaceField = (string) null;
    private uint? priorityField = new uint?();
    private string msrField = (string) null;
    private string monitorField = (string) null;
    private string stateField = (string) null;
    private bool? detailField = new bool?();
    private long? hitsField = new long?();
    private string kernelstateField = (string) null;
    private uint? curstateField = new uint?();
    private uint? totalprobesField = new uint?();
    private uint? totalfailedprobesField = new uint?();
    private uint? failedprobesField = new uint?();
    private int? monstatcodeField = new int?();
    private int? monstatparam1Field = new int?();
    private int? monstatparam2Field = new int?();
    private int? monstatparam3Field = new int?();
    private bool? dataField = new bool?();
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

    public string action
    {
      get => this.actionField;
      set => this.actionField = value;
    }

    public uint? td
    {
      get => this.tdField;
      set => this.tdField = value;
    }

    public bool? srcip
    {
      get => this.srcipField;
      set => this.srcipField = value;
    }

    public string srcipop
    {
      get => this.srcipopField;
      set => this.srcipopField = value;
    }

    public string srcipval
    {
      get => this.srcipvalField;
      set => this.srcipvalField = value;
    }

    public bool? srcport
    {
      get => this.srcportField;
      set => this.srcportField = value;
    }

    public string srcportop
    {
      get => this.srcportopField;
      set => this.srcportopField = value;
    }

    public string srcportval
    {
      get => this.srcportvalField;
      set => this.srcportvalField = value;
    }

    public bool? destip
    {
      get => this.destipField;
      set => this.destipField = value;
    }

    public string destipop
    {
      get => this.destipopField;
      set => this.destipopField = value;
    }

    public string destipval
    {
      get => this.destipvalField;
      set => this.destipvalField = value;
    }

    public bool? destport
    {
      get => this.destportField;
      set => this.destportField = value;
    }

    public string destportop
    {
      get => this.destportopField;
      set => this.destportopField = value;
    }

    public string destportval
    {
      get => this.destportvalField;
      set => this.destportvalField = value;
    }

    public bool? nexthop
    {
      get => this.nexthopField;
      set => this.nexthopField = value;
    }

    public string nexthopval
    {
      get => this.nexthopvalField;
      set => this.nexthopvalField = value;
    }

    public bool? iptunnel
    {
      get => this.iptunnelField;
      set => this.iptunnelField = value;
    }

    public string iptunnelname
    {
      get => this.iptunnelnameField;
      set => this.iptunnelnameField = value;
    }

    public string srcmac
    {
      get => this.srcmacField;
      set => this.srcmacField = value;
    }

    public string srcmacmask
    {
      get => this.srcmacmaskField;
      set => this.srcmacmaskField = value;
    }

    public string protocol
    {
      get => this.protocolField;
      set => this.protocolField = value;
    }

    public uint? protocolnumber
    {
      get => this.protocolnumberField;
      set => this.protocolnumberField = value;
    }

    public uint? vlan
    {
      get => this.vlanField;
      set => this.vlanField = value;
    }

    public uint? vxlan
    {
      get => this.vxlanField;
      set => this.vxlanField = value;
    }

    public string Interface
    {
      get => this.InterfaceField;
      set => this.InterfaceField = value;
    }

    public uint? priority
    {
      get => this.priorityField;
      set => this.priorityField = value;
    }

    public string msr
    {
      get => this.msrField;
      set => this.msrField = value;
    }

    public string monitor
    {
      get => this.monitorField;
      set => this.monitorField = value;
    }

    public string state
    {
      get => this.stateField;
      set => this.stateField = value;
    }

    public bool? detail
    {
      get => this.detailField;
      set => this.detailField = value;
    }

    public long? hits
    {
      get => this.hitsField;
      private set => this.hitsField = value;
    }

    public string kernelstate
    {
      get => this.kernelstateField;
      private set => this.kernelstateField = value;
    }

    public uint? curstate
    {
      get => this.curstateField;
      private set => this.curstateField = value;
    }

    public uint? totalprobes
    {
      get => this.totalprobesField;
      private set => this.totalprobesField = value;
    }

    public uint? totalfailedprobes
    {
      get => this.totalfailedprobesField;
      private set => this.totalfailedprobesField = value;
    }

    public uint? failedprobes
    {
      get => this.failedprobesField;
      private set => this.failedprobesField = value;
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

    public bool? data
    {
      get => this.dataField;
      private set => this.dataField = value;
    }

    internal override base_resource[] get_nitro_response(
      nitro_service service,
      string response)
    {
      nspbr.nspbr_response nspbrResponse = new nspbr.nspbr_response();
      nspbr.nspbr_response resource = (nspbr.nspbr_response) service.get_payload_formatter().string_to_resource(nspbrResponse.GetType(), response);
      if (resource.errorcode != 0)
      {
        if (resource.errorcode == 444)
          service.clear_session();
        if (resource.severity == null)
          throw new nitro_exception(resource.message, resource.errorcode);
        if (resource.severity.Equals("ERROR"))
          throw new nitro_exception(resource.message, resource.errorcode);
      }
      return (base_resource[]) resource.nspbr;
    }

    internal override string get_object_name() => this.name;

    public static base_response add(nitro_service client, nspbr resource) => new nspbr()
    {
      name = resource.name,
      action = resource.action,
      td = resource.td,
      srcip = resource.srcip,
      srcipop = resource.srcipop,
      srcipval = resource.srcipval,
      srcport = resource.srcport,
      srcportop = resource.srcportop,
      srcportval = resource.srcportval,
      destip = resource.destip,
      destipop = resource.destipop,
      destipval = resource.destipval,
      destport = resource.destport,
      destportop = resource.destportop,
      destportval = resource.destportval,
      nexthop = resource.nexthop,
      nexthopval = resource.nexthopval,
      iptunnel = resource.iptunnel,
      iptunnelname = resource.iptunnelname,
      srcmac = resource.srcmac,
      srcmacmask = resource.srcmacmask,
      protocol = resource.protocol,
      protocolnumber = resource.protocolnumber,
      vlan = resource.vlan,
      vxlan = resource.vxlan,
      Interface = resource.Interface,
      priority = resource.priority,
      msr = resource.msr,
      monitor = resource.monitor,
      state = resource.state
    }.add_resource(client);

    public static base_responses add(nitro_service client, nspbr[] resources)
    {
      base_responses baseResponses = (base_responses) null;
      if (resources != null && resources.Length > 0)
      {
        nspbr[] nspbrArray = new nspbr[resources.Length];
        for (int index = 0; index < resources.Length; ++index)
        {
          nspbrArray[index] = new nspbr();
          nspbrArray[index].name = resources[index].name;
          nspbrArray[index].action = resources[index].action;
          nspbrArray[index].td = resources[index].td;
          nspbrArray[index].srcip = resources[index].srcip;
          nspbrArray[index].srcipop = resources[index].srcipop;
          nspbrArray[index].srcipval = resources[index].srcipval;
          nspbrArray[index].srcport = resources[index].srcport;
          nspbrArray[index].srcportop = resources[index].srcportop;
          nspbrArray[index].srcportval = resources[index].srcportval;
          nspbrArray[index].destip = resources[index].destip;
          nspbrArray[index].destipop = resources[index].destipop;
          nspbrArray[index].destipval = resources[index].destipval;
          nspbrArray[index].destport = resources[index].destport;
          nspbrArray[index].destportop = resources[index].destportop;
          nspbrArray[index].destportval = resources[index].destportval;
          nspbrArray[index].nexthop = resources[index].nexthop;
          nspbrArray[index].nexthopval = resources[index].nexthopval;
          nspbrArray[index].iptunnel = resources[index].iptunnel;
          nspbrArray[index].iptunnelname = resources[index].iptunnelname;
          nspbrArray[index].srcmac = resources[index].srcmac;
          nspbrArray[index].srcmacmask = resources[index].srcmacmask;
          nspbrArray[index].protocol = resources[index].protocol;
          nspbrArray[index].protocolnumber = resources[index].protocolnumber;
          nspbrArray[index].vlan = resources[index].vlan;
          nspbrArray[index].vxlan = resources[index].vxlan;
          nspbrArray[index].Interface = resources[index].Interface;
          nspbrArray[index].priority = resources[index].priority;
          nspbrArray[index].msr = resources[index].msr;
          nspbrArray[index].monitor = resources[index].monitor;
          nspbrArray[index].state = resources[index].state;
        }
        baseResponses = base_resource.add_bulk_request(client, (base_resource[]) nspbrArray);
      }
      return baseResponses;
    }

    public static base_response delete(nitro_service client, string name) => new nspbr()
    {
      name = name
    }.delete_resource(client);

    public static base_response delete(nitro_service client, nspbr resource) => new nspbr()
    {
      name = resource.name
    }.delete_resource(client);

    public static base_responses delete(nitro_service client, string[] name)
    {
      base_responses baseResponses = (base_responses) null;
      if (name != null && name.Length > 0)
      {
        nspbr[] nspbrArray = new nspbr[name.Length];
        for (int index = 0; index < name.Length; ++index)
        {
          nspbrArray[index] = new nspbr();
          nspbrArray[index].name = name[index];
        }
        baseResponses = base_resource.delete_bulk_request(client, (base_resource[]) nspbrArray);
      }
      return baseResponses;
    }

    public static base_responses delete(nitro_service client, nspbr[] resources)
    {
      base_responses baseResponses = (base_responses) null;
      if (resources != null && resources.Length > 0)
      {
        nspbr[] nspbrArray = new nspbr[resources.Length];
        for (int index = 0; index < resources.Length; ++index)
        {
          nspbrArray[index] = new nspbr();
          nspbrArray[index].name = resources[index].name;
        }
        baseResponses = base_resource.delete_bulk_request(client, (base_resource[]) nspbrArray);
      }
      return baseResponses;
    }

    public static base_response update(nitro_service client, nspbr resource) => new nspbr()
    {
      name = resource.name,
      action = resource.action,
      srcip = resource.srcip,
      srcipop = resource.srcipop,
      srcipval = resource.srcipval,
      srcport = resource.srcport,
      srcportop = resource.srcportop,
      srcportval = resource.srcportval,
      destip = resource.destip,
      destipop = resource.destipop,
      destipval = resource.destipval,
      destport = resource.destport,
      destportop = resource.destportop,
      destportval = resource.destportval,
      nexthop = resource.nexthop,
      nexthopval = resource.nexthopval,
      iptunnel = resource.iptunnel,
      iptunnelname = resource.iptunnelname,
      srcmac = resource.srcmac,
      srcmacmask = resource.srcmacmask,
      protocol = resource.protocol,
      protocolnumber = resource.protocolnumber,
      vlan = resource.vlan,
      vxlan = resource.vxlan,
      Interface = resource.Interface,
      priority = resource.priority,
      msr = resource.msr,
      monitor = resource.monitor
    }.update_resource(client);

    public static base_responses update(nitro_service client, nspbr[] resources)
    {
      base_responses baseResponses = (base_responses) null;
      if (resources != null && resources.Length > 0)
      {
        nspbr[] nspbrArray = new nspbr[resources.Length];
        for (int index = 0; index < resources.Length; ++index)
        {
          nspbrArray[index] = new nspbr();
          nspbrArray[index].name = resources[index].name;
          nspbrArray[index].action = resources[index].action;
          nspbrArray[index].srcip = resources[index].srcip;
          nspbrArray[index].srcipop = resources[index].srcipop;
          nspbrArray[index].srcipval = resources[index].srcipval;
          nspbrArray[index].srcport = resources[index].srcport;
          nspbrArray[index].srcportop = resources[index].srcportop;
          nspbrArray[index].srcportval = resources[index].srcportval;
          nspbrArray[index].destip = resources[index].destip;
          nspbrArray[index].destipop = resources[index].destipop;
          nspbrArray[index].destipval = resources[index].destipval;
          nspbrArray[index].destport = resources[index].destport;
          nspbrArray[index].destportop = resources[index].destportop;
          nspbrArray[index].destportval = resources[index].destportval;
          nspbrArray[index].nexthop = resources[index].nexthop;
          nspbrArray[index].nexthopval = resources[index].nexthopval;
          nspbrArray[index].iptunnel = resources[index].iptunnel;
          nspbrArray[index].iptunnelname = resources[index].iptunnelname;
          nspbrArray[index].srcmac = resources[index].srcmac;
          nspbrArray[index].srcmacmask = resources[index].srcmacmask;
          nspbrArray[index].protocol = resources[index].protocol;
          nspbrArray[index].protocolnumber = resources[index].protocolnumber;
          nspbrArray[index].vlan = resources[index].vlan;
          nspbrArray[index].vxlan = resources[index].vxlan;
          nspbrArray[index].Interface = resources[index].Interface;
          nspbrArray[index].priority = resources[index].priority;
          nspbrArray[index].msr = resources[index].msr;
          nspbrArray[index].monitor = resources[index].monitor;
        }
        baseResponses = base_resource.update_bulk_request(client, (base_resource[]) nspbrArray);
      }
      return baseResponses;
    }

    public static base_response unset(
      nitro_service client,
      string name,
      string[] args)
    {
      return new nspbr() { name = name }.unset_resource(client, args);
    }

    public static base_response unset(
      nitro_service client,
      nspbr resource,
      string[] args)
    {
      return new nspbr() { name = resource.name }.unset_resource(client, args);
    }

    public static base_responses unset(
      nitro_service client,
      string[] name,
      string[] args)
    {
      base_responses baseResponses = (base_responses) null;
      if (name != null && name.Length > 0)
      {
        nspbr[] nspbrArray = new nspbr[name.Length];
        for (int index = 0; index < name.Length; ++index)
        {
          nspbrArray[index] = new nspbr();
          nspbrArray[index].name = name[index];
        }
        baseResponses = base_resource.unset_bulk_request(client, (base_resource[]) nspbrArray, args);
      }
      return baseResponses;
    }

    public static base_responses unset(
      nitro_service client,
      nspbr[] resources,
      string[] args)
    {
      base_responses baseResponses = (base_responses) null;
      if (resources != null && resources.Length > 0)
      {
        nspbr[] nspbrArray = new nspbr[resources.Length];
        for (int index = 0; index < resources.Length; ++index)
        {
          nspbrArray[index] = new nspbr();
          nspbrArray[index].name = resources[index].name;
        }
        baseResponses = base_resource.unset_bulk_request(client, (base_resource[]) nspbrArray, args);
      }
      return baseResponses;
    }

    public static base_response enable(nitro_service client, string name) => new nspbr()
    {
      name = name
    }.perform_operation_byaction(client, nameof (enable));

    public static base_response enable(nitro_service client, nspbr resource) => new nspbr()
    {
      name = resource.name
    }.perform_operation_byaction(client, nameof (enable));

    public static base_responses enable(nitro_service client, string[] name)
    {
      base_responses baseResponses = (base_responses) null;
      if (name != null && name.Length > 0)
      {
        nspbr[] nspbrArray = new nspbr[name.Length];
        for (int index = 0; index < name.Length; ++index)
        {
          nspbrArray[index] = new nspbr();
          nspbrArray[index].name = name[index];
        }
        baseResponses = base_resource.perform_operation_bulk_request(client, (base_resource[]) nspbrArray, nameof (enable));
      }
      return baseResponses;
    }

    public static base_responses enable(nitro_service client, nspbr[] resources)
    {
      base_responses baseResponses = (base_responses) null;
      if (resources != null && resources.Length > 0)
      {
        nspbr[] nspbrArray = new nspbr[resources.Length];
        for (int index = 0; index < resources.Length; ++index)
        {
          nspbrArray[index] = new nspbr();
          nspbrArray[index].name = resources[index].name;
        }
        baseResponses = base_resource.perform_operation_bulk_request(client, (base_resource[]) nspbrArray, nameof (enable));
      }
      return baseResponses;
    }

    public static base_response disable(nitro_service client, string name) => new nspbr()
    {
      name = name
    }.perform_operation_byaction(client, nameof (disable));

    public static base_response disable(nitro_service client, nspbr resource) => new nspbr()
    {
      name = resource.name
    }.perform_operation_byaction(client, nameof (disable));

    public static base_responses disable(nitro_service client, string[] name)
    {
      base_responses baseResponses = (base_responses) null;
      if (name != null && name.Length > 0)
      {
        nspbr[] nspbrArray = new nspbr[name.Length];
        for (int index = 0; index < name.Length; ++index)
        {
          nspbrArray[index] = new nspbr();
          nspbrArray[index].name = name[index];
        }
        baseResponses = base_resource.perform_operation_bulk_request(client, (base_resource[]) nspbrArray, nameof (disable));
      }
      return baseResponses;
    }

    public static base_responses disable(nitro_service client, nspbr[] resources)
    {
      base_responses baseResponses = (base_responses) null;
      if (resources != null && resources.Length > 0)
      {
        nspbr[] nspbrArray = new nspbr[resources.Length];
        for (int index = 0; index < resources.Length; ++index)
        {
          nspbrArray[index] = new nspbr();
          nspbrArray[index].name = resources[index].name;
        }
        baseResponses = base_resource.perform_operation_bulk_request(client, (base_resource[]) nspbrArray, nameof (disable));
      }
      return baseResponses;
    }

    public static nspbr[] get(nitro_service service) => (nspbr[]) new nspbr().get_resources(service, (options) null);

    public static nspbr[] get(nitro_service service, options option) => (nspbr[]) new nspbr().get_resources(service, option);

    public static nspbr[] get(nitro_service service, nspbr_args args)
    {
      nspbr nspbr = new nspbr();
      options option = new options();
      option.set_args(nitro_util.object_to_string_withoutquotes((object) args));
      return (nspbr[]) nspbr.get_resources(service, option);
    }

    public static nspbr get(nitro_service service, string name) => (nspbr) new nspbr()
    {
      name = name
    }.get_resource(service);

    public static nspbr[] get(nitro_service service, string[] name)
    {
      if (name == null || name.Length <= 0)
        return (nspbr[]) null;
      nspbr[] nspbrArray1 = new nspbr[name.Length];
      nspbr[] nspbrArray2 = new nspbr[name.Length];
      for (int index = 0; index < name.Length; ++index)
      {
        nspbrArray2[index] = new nspbr();
        nspbrArray2[index].name = name[index];
        nspbrArray1[index] = (nspbr) nspbrArray2[index].get_resource(service);
      }
      return nspbrArray1;
    }

    public static nspbr[] get_filtered(nitro_service service, string filter)
    {
      nspbr nspbr = new nspbr();
      options option = new options();
      option.set_filter(filter);
      return (nspbr[]) nspbr.getfiltered(service, option);
    }

    public static nspbr[] get_filtered(nitro_service service, filtervalue[] filter)
    {
      nspbr nspbr = new nspbr();
      options option = new options();
      option.set_filter(filter);
      return (nspbr[]) nspbr.getfiltered(service, option);
    }

    public static uint count(nitro_service service)
    {
      nspbr nspbr = new nspbr();
      options option = new options();
      option.set_count(true);
      nspbr[] resources = (nspbr[]) nspbr.get_resources(service, option);
      return resources != null && resources.Length > 0 ? resources[0].__count.Value : 0U;
    }

    public static uint count_filtered(nitro_service service, string filter)
    {
      nspbr nspbr = new nspbr();
      options option = new options();
      option.set_count(true);
      option.set_filter(filter);
      nspbr[] nspbrArray = (nspbr[]) nspbr.getfiltered(service, option);
      return nspbrArray != null && nspbrArray.Length > 0 ? nspbrArray[0].__count.Value : 0U;
    }

    public static uint count_filtered(nitro_service service, filtervalue[] filter)
    {
      nspbr nspbr = new nspbr();
      options option = new options();
      option.set_count(true);
      option.set_filter(filter);
      nspbr[] nspbrArray = (nspbr[]) nspbr.getfiltered(service, option);
      return nspbrArray != null && nspbrArray.Length > 0 ? nspbrArray[0].__count.Value : 0U;
    }

    private class nspbr_response : base_response
    {
      public nspbr[] nspbr = (nspbr[]) null;
    }

    public static class protocolEnum
    {
      public const string ICMP = "ICMP";
      public const string IGMP = "IGMP";
      public const string TCP = "TCP";
      public const string EGP = "EGP";
      public const string IGP = "IGP";
      public const string ARGUS = "ARGUS";
      public const string UDP = "UDP";
      public const string RDP = "RDP";
      public const string RSVP = "RSVP";
      public const string EIGRP = "EIGRP";
      public const string L2TP = "L2TP";
      public const string ISIS = "ISIS";
    }

    public static class destipopEnum
    {
      public const string _EQ = "=";
      public const string _NEQ = "!=";
      public const string EQ = "EQ";
      public const string NEQ = "NEQ";
    }

    public static class stateEnum
    {
      public const string ENABLED = "ENABLED";
      public const string DISABLED = "DISABLED";
    }

    public static class kernelstateEnum
    {
      public const string APPLIED = "APPLIED";
      public const string NOTAPPLIED = "NOTAPPLIED";
      public const string RE_APPLY = "RE-APPLY";
      public const string SFAPPLIED = "SFAPPLIED";
      public const string SFNOTAPPLIED = "SFNOTAPPLIED";
      public const string SFAPPLIED61 = "SFAPPLIED61";
      public const string SFNOTAPPLIED61 = "SFNOTAPPLIED61";
    }

    public static class msrEnum
    {
      public const string ENABLED = "ENABLED";
      public const string DISABLED = "DISABLED";
    }

    public static class srcportopEnum
    {
      public const string _EQ = "=";
      public const string _NEQ = "!=";
      public const string EQ = "EQ";
      public const string NEQ = "NEQ";
    }

    public static class srcipopEnum
    {
      public const string _EQ = "=";
      public const string _NEQ = "!=";
      public const string EQ = "EQ";
      public const string NEQ = "NEQ";
    }

    public static class destportopEnum
    {
      public const string _EQ = "=";
      public const string _NEQ = "!=";
      public const string EQ = "EQ";
      public const string NEQ = "NEQ";
    }

    public static class actionEnum
    {
      public const string ALLOW = "ALLOW";
      public const string DENY = "DENY";
    }
  }
}
