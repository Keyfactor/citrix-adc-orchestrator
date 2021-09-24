// Decompiled with JetBrains decompiler
// Type: com.citrix.netscaler.nitro.resource.config.ns.nspbr6
// Assembly: nitro, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 6CF5DDEF-E052-4F9D-953F-6644F8378A66


using com.citrix.netscaler.nitro.exception;
using com.citrix.netscaler.nitro.resource.Base;
using com.citrix.netscaler.nitro.service;
using com.citrix.netscaler.nitro.util;

namespace com.citrix.netscaler.nitro.resource.config.ns
{
  public class nspbr6 : base_resource
  {
    private string nameField = (string) null;
    private uint? tdField = new uint?();
    private string actionField = (string) null;
    private bool? srcipv6Field = new bool?();
    private string srcipopField = (string) null;
    private string srcipv6valField = (string) null;
    private bool? srcportField = new bool?();
    private string srcportopField = (string) null;
    private string srcportvalField = (string) null;
    private bool? destipv6Field = new bool?();
    private string destipopField = (string) null;
    private string destipv6valField = (string) null;
    private bool? destportField = new bool?();
    private string destportopField = (string) null;
    private string destportvalField = (string) null;
    private string srcmacField = (string) null;
    private string srcmacmaskField = (string) null;
    private string protocolField = (string) null;
    private uint? protocolnumberField = new uint?();
    private uint? vlanField = new uint?();
    private uint? vxlanField = new uint?();
    private string InterfaceField = (string) null;
    private uint? priorityField = new uint?();
    private string stateField = (string) null;
    private string msrField = (string) null;
    private string monitorField = (string) null;
    private bool? nexthopField = new bool?();
    private string nexthopvalField = (string) null;
    private string iptunnelField = (string) null;
    private uint? nexthopvlanField = new uint?();
    private bool? detailField = new bool?();
    private string kernelstateField = (string) null;
    private long? hitsField = new long?();
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

    public uint? td
    {
      get => this.tdField;
      set => this.tdField = value;
    }

    public string action
    {
      get => this.actionField;
      set => this.actionField = value;
    }

    public bool? srcipv6
    {
      get => this.srcipv6Field;
      set => this.srcipv6Field = value;
    }

    public string srcipop
    {
      get => this.srcipopField;
      set => this.srcipopField = value;
    }

    public string srcipv6val
    {
      get => this.srcipv6valField;
      set => this.srcipv6valField = value;
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

    public bool? destipv6
    {
      get => this.destipv6Field;
      set => this.destipv6Field = value;
    }

    public string destipop
    {
      get => this.destipopField;
      set => this.destipopField = value;
    }

    public string destipv6val
    {
      get => this.destipv6valField;
      set => this.destipv6valField = value;
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

    public string state
    {
      get => this.stateField;
      set => this.stateField = value;
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

    public string iptunnel
    {
      get => this.iptunnelField;
      set => this.iptunnelField = value;
    }

    public uint? nexthopvlan
    {
      get => this.nexthopvlanField;
      set => this.nexthopvlanField = value;
    }

    public bool? detail
    {
      get => this.detailField;
      set => this.detailField = value;
    }

    public string kernelstate
    {
      get => this.kernelstateField;
      private set => this.kernelstateField = value;
    }

    public long? hits
    {
      get => this.hitsField;
      private set => this.hitsField = value;
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
      nspbr6.nspbr6_response nspbr6Response = new nspbr6.nspbr6_response();
      nspbr6.nspbr6_response resource = (nspbr6.nspbr6_response) service.get_payload_formatter().string_to_resource(nspbr6Response.GetType(), response);
      if (resource.errorcode != 0)
      {
        if (resource.errorcode == 444)
          service.clear_session();
        if (resource.severity == null)
          throw new nitro_exception(resource.message, resource.errorcode);
        if (resource.severity.Equals("ERROR"))
          throw new nitro_exception(resource.message, resource.errorcode);
      }
      return (base_resource[]) resource.nspbr6;
    }

    internal override string get_object_name() => this.name;

    public static base_response add(nitro_service client, nspbr6 resource) => new nspbr6()
    {
      name = resource.name,
      td = resource.td,
      action = resource.action,
      srcipv6 = resource.srcipv6,
      srcipop = resource.srcipop,
      srcipv6val = resource.srcipv6val,
      srcport = resource.srcport,
      srcportop = resource.srcportop,
      srcportval = resource.srcportval,
      destipv6 = resource.destipv6,
      destipop = resource.destipop,
      destipv6val = resource.destipv6val,
      destport = resource.destport,
      destportop = resource.destportop,
      destportval = resource.destportval,
      srcmac = resource.srcmac,
      srcmacmask = resource.srcmacmask,
      protocol = resource.protocol,
      protocolnumber = resource.protocolnumber,
      vlan = resource.vlan,
      vxlan = resource.vxlan,
      Interface = resource.Interface,
      priority = resource.priority,
      state = resource.state,
      msr = resource.msr,
      monitor = resource.monitor,
      nexthop = resource.nexthop,
      nexthopval = resource.nexthopval,
      iptunnel = resource.iptunnel,
      nexthopvlan = resource.nexthopvlan
    }.add_resource(client);

    public static base_responses add(nitro_service client, nspbr6[] resources)
    {
      base_responses baseResponses = (base_responses) null;
      if (resources != null && resources.Length > 0)
      {
        nspbr6[] nspbr6Array = new nspbr6[resources.Length];
        for (int index = 0; index < resources.Length; ++index)
        {
          nspbr6Array[index] = new nspbr6();
          nspbr6Array[index].name = resources[index].name;
          nspbr6Array[index].td = resources[index].td;
          nspbr6Array[index].action = resources[index].action;
          nspbr6Array[index].srcipv6 = resources[index].srcipv6;
          nspbr6Array[index].srcipop = resources[index].srcipop;
          nspbr6Array[index].srcipv6val = resources[index].srcipv6val;
          nspbr6Array[index].srcport = resources[index].srcport;
          nspbr6Array[index].srcportop = resources[index].srcportop;
          nspbr6Array[index].srcportval = resources[index].srcportval;
          nspbr6Array[index].destipv6 = resources[index].destipv6;
          nspbr6Array[index].destipop = resources[index].destipop;
          nspbr6Array[index].destipv6val = resources[index].destipv6val;
          nspbr6Array[index].destport = resources[index].destport;
          nspbr6Array[index].destportop = resources[index].destportop;
          nspbr6Array[index].destportval = resources[index].destportval;
          nspbr6Array[index].srcmac = resources[index].srcmac;
          nspbr6Array[index].srcmacmask = resources[index].srcmacmask;
          nspbr6Array[index].protocol = resources[index].protocol;
          nspbr6Array[index].protocolnumber = resources[index].protocolnumber;
          nspbr6Array[index].vlan = resources[index].vlan;
          nspbr6Array[index].vxlan = resources[index].vxlan;
          nspbr6Array[index].Interface = resources[index].Interface;
          nspbr6Array[index].priority = resources[index].priority;
          nspbr6Array[index].state = resources[index].state;
          nspbr6Array[index].msr = resources[index].msr;
          nspbr6Array[index].monitor = resources[index].monitor;
          nspbr6Array[index].nexthop = resources[index].nexthop;
          nspbr6Array[index].nexthopval = resources[index].nexthopval;
          nspbr6Array[index].iptunnel = resources[index].iptunnel;
          nspbr6Array[index].nexthopvlan = resources[index].nexthopvlan;
        }
        baseResponses = base_resource.add_bulk_request(client, (base_resource[]) nspbr6Array);
      }
      return baseResponses;
    }

    public static base_response renumber(nitro_service client) => new nspbr6().perform_operation_byaction(client, nameof (renumber));

    public static base_responses renumber(nitro_service client, nspbr6[] resources)
    {
      base_responses baseResponses = (base_responses) null;
      if (resources != null && resources.Length > 0)
      {
        nspbr6[] nspbr6Array = new nspbr6[resources.Length];
        for (int index = 0; index < resources.Length; ++index)
          nspbr6Array[index] = new nspbr6();
        baseResponses = base_resource.perform_operation_bulk_request(client, (base_resource[]) nspbr6Array, nameof (renumber));
      }
      return baseResponses;
    }

    public static base_response delete(nitro_service client, string name) => new nspbr6()
    {
      name = name
    }.delete_resource(client);

    public static base_response delete(nitro_service client, nspbr6 resource) => new nspbr6()
    {
      name = resource.name
    }.delete_resource(client);

    public static base_responses delete(nitro_service client, string[] name)
    {
      base_responses baseResponses = (base_responses) null;
      if (name != null && name.Length > 0)
      {
        nspbr6[] nspbr6Array = new nspbr6[name.Length];
        for (int index = 0; index < name.Length; ++index)
        {
          nspbr6Array[index] = new nspbr6();
          nspbr6Array[index].name = name[index];
        }
        baseResponses = base_resource.delete_bulk_request(client, (base_resource[]) nspbr6Array);
      }
      return baseResponses;
    }

    public static base_responses delete(nitro_service client, nspbr6[] resources)
    {
      base_responses baseResponses = (base_responses) null;
      if (resources != null && resources.Length > 0)
      {
        nspbr6[] nspbr6Array = new nspbr6[resources.Length];
        for (int index = 0; index < resources.Length; ++index)
        {
          nspbr6Array[index] = new nspbr6();
          nspbr6Array[index].name = resources[index].name;
        }
        baseResponses = base_resource.delete_bulk_request(client, (base_resource[]) nspbr6Array);
      }
      return baseResponses;
    }

    public static base_response update(nitro_service client, nspbr6 resource) => new nspbr6()
    {
      name = resource.name,
      action = resource.action,
      srcipv6 = resource.srcipv6,
      srcipop = resource.srcipop,
      srcipv6val = resource.srcipv6val,
      srcport = resource.srcport,
      srcportop = resource.srcportop,
      srcportval = resource.srcportval,
      destipv6 = resource.destipv6,
      destipop = resource.destipop,
      destipv6val = resource.destipv6val,
      destport = resource.destport,
      destportop = resource.destportop,
      destportval = resource.destportval,
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
      nexthop = resource.nexthop,
      nexthopval = resource.nexthopval,
      iptunnel = resource.iptunnel,
      nexthopvlan = resource.nexthopvlan
    }.update_resource(client);

    public static base_responses update(nitro_service client, nspbr6[] resources)
    {
      base_responses baseResponses = (base_responses) null;
      if (resources != null && resources.Length > 0)
      {
        nspbr6[] nspbr6Array = new nspbr6[resources.Length];
        for (int index = 0; index < resources.Length; ++index)
        {
          nspbr6Array[index] = new nspbr6();
          nspbr6Array[index].name = resources[index].name;
          nspbr6Array[index].action = resources[index].action;
          nspbr6Array[index].srcipv6 = resources[index].srcipv6;
          nspbr6Array[index].srcipop = resources[index].srcipop;
          nspbr6Array[index].srcipv6val = resources[index].srcipv6val;
          nspbr6Array[index].srcport = resources[index].srcport;
          nspbr6Array[index].srcportop = resources[index].srcportop;
          nspbr6Array[index].srcportval = resources[index].srcportval;
          nspbr6Array[index].destipv6 = resources[index].destipv6;
          nspbr6Array[index].destipop = resources[index].destipop;
          nspbr6Array[index].destipv6val = resources[index].destipv6val;
          nspbr6Array[index].destport = resources[index].destport;
          nspbr6Array[index].destportop = resources[index].destportop;
          nspbr6Array[index].destportval = resources[index].destportval;
          nspbr6Array[index].srcmac = resources[index].srcmac;
          nspbr6Array[index].srcmacmask = resources[index].srcmacmask;
          nspbr6Array[index].protocol = resources[index].protocol;
          nspbr6Array[index].protocolnumber = resources[index].protocolnumber;
          nspbr6Array[index].vlan = resources[index].vlan;
          nspbr6Array[index].vxlan = resources[index].vxlan;
          nspbr6Array[index].Interface = resources[index].Interface;
          nspbr6Array[index].priority = resources[index].priority;
          nspbr6Array[index].msr = resources[index].msr;
          nspbr6Array[index].monitor = resources[index].monitor;
          nspbr6Array[index].nexthop = resources[index].nexthop;
          nspbr6Array[index].nexthopval = resources[index].nexthopval;
          nspbr6Array[index].iptunnel = resources[index].iptunnel;
          nspbr6Array[index].nexthopvlan = resources[index].nexthopvlan;
        }
        baseResponses = base_resource.update_bulk_request(client, (base_resource[]) nspbr6Array);
      }
      return baseResponses;
    }

    public static base_response unset(
      nitro_service client,
      string name,
      string[] args)
    {
      return new nspbr6() { name = name }.unset_resource(client, args);
    }

    public static base_response unset(
      nitro_service client,
      nspbr6 resource,
      string[] args)
    {
      return new nspbr6() { name = resource.name }.unset_resource(client, args);
    }

    public static base_responses unset(
      nitro_service client,
      string[] name,
      string[] args)
    {
      base_responses baseResponses = (base_responses) null;
      if (name != null && name.Length > 0)
      {
        nspbr6[] nspbr6Array = new nspbr6[name.Length];
        for (int index = 0; index < name.Length; ++index)
        {
          nspbr6Array[index] = new nspbr6();
          nspbr6Array[index].name = name[index];
        }
        baseResponses = base_resource.unset_bulk_request(client, (base_resource[]) nspbr6Array, args);
      }
      return baseResponses;
    }

    public static base_responses unset(
      nitro_service client,
      nspbr6[] resources,
      string[] args)
    {
      base_responses baseResponses = (base_responses) null;
      if (resources != null && resources.Length > 0)
      {
        nspbr6[] nspbr6Array = new nspbr6[resources.Length];
        for (int index = 0; index < resources.Length; ++index)
        {
          nspbr6Array[index] = new nspbr6();
          nspbr6Array[index].name = resources[index].name;
        }
        baseResponses = base_resource.unset_bulk_request(client, (base_resource[]) nspbr6Array, args);
      }
      return baseResponses;
    }

    public static base_response enable(nitro_service client, string name) => new nspbr6()
    {
      name = name
    }.perform_operation_byaction(client, nameof (enable));

    public static base_response enable(nitro_service client, nspbr6 resource) => new nspbr6()
    {
      name = resource.name
    }.perform_operation_byaction(client, nameof (enable));

    public static base_responses enable(nitro_service client, string[] name)
    {
      base_responses baseResponses = (base_responses) null;
      if (name != null && name.Length > 0)
      {
        nspbr6[] nspbr6Array = new nspbr6[name.Length];
        for (int index = 0; index < name.Length; ++index)
        {
          nspbr6Array[index] = new nspbr6();
          nspbr6Array[index].name = name[index];
        }
        baseResponses = base_resource.perform_operation_bulk_request(client, (base_resource[]) nspbr6Array, nameof (enable));
      }
      return baseResponses;
    }

    public static base_responses enable(nitro_service client, nspbr6[] resources)
    {
      base_responses baseResponses = (base_responses) null;
      if (resources != null && resources.Length > 0)
      {
        nspbr6[] nspbr6Array = new nspbr6[resources.Length];
        for (int index = 0; index < resources.Length; ++index)
        {
          nspbr6Array[index] = new nspbr6();
          nspbr6Array[index].name = resources[index].name;
        }
        baseResponses = base_resource.perform_operation_bulk_request(client, (base_resource[]) nspbr6Array, nameof (enable));
      }
      return baseResponses;
    }

    public static base_response disable(nitro_service client, string name) => new nspbr6()
    {
      name = name
    }.perform_operation_byaction(client, nameof (disable));

    public static base_response disable(nitro_service client, nspbr6 resource) => new nspbr6()
    {
      name = resource.name
    }.perform_operation_byaction(client, nameof (disable));

    public static base_responses disable(nitro_service client, string[] name)
    {
      base_responses baseResponses = (base_responses) null;
      if (name != null && name.Length > 0)
      {
        nspbr6[] nspbr6Array = new nspbr6[name.Length];
        for (int index = 0; index < name.Length; ++index)
        {
          nspbr6Array[index] = new nspbr6();
          nspbr6Array[index].name = name[index];
        }
        baseResponses = base_resource.perform_operation_bulk_request(client, (base_resource[]) nspbr6Array, nameof (disable));
      }
      return baseResponses;
    }

    public static base_responses disable(nitro_service client, nspbr6[] resources)
    {
      base_responses baseResponses = (base_responses) null;
      if (resources != null && resources.Length > 0)
      {
        nspbr6[] nspbr6Array = new nspbr6[resources.Length];
        for (int index = 0; index < resources.Length; ++index)
        {
          nspbr6Array[index] = new nspbr6();
          nspbr6Array[index].name = resources[index].name;
        }
        baseResponses = base_resource.perform_operation_bulk_request(client, (base_resource[]) nspbr6Array, nameof (disable));
      }
      return baseResponses;
    }

    public static base_response clear(nitro_service client) => new nspbr6().perform_operation_byaction(client, nameof (clear));

    public static base_responses clear(nitro_service client, nspbr6[] resources)
    {
      base_responses baseResponses = (base_responses) null;
      if (resources != null && resources.Length > 0)
      {
        nspbr6[] nspbr6Array = new nspbr6[resources.Length];
        for (int index = 0; index < resources.Length; ++index)
          nspbr6Array[index] = new nspbr6();
        baseResponses = base_resource.perform_operation_bulk_request(client, (base_resource[]) nspbr6Array, nameof (clear));
      }
      return baseResponses;
    }

    public static base_response apply(nitro_service client, nspbr6 resource) => new nspbr6().perform_operation_byaction(client, nameof (apply));

    public static base_responses apply(nitro_service client, nspbr6[] resources)
    {
      base_responses baseResponses = (base_responses) null;
      if (resources != null && resources.Length > 0)
      {
        nspbr6[] nspbr6Array = new nspbr6[resources.Length];
        for (int index = 0; index < resources.Length; ++index)
          nspbr6Array[index] = new nspbr6();
        baseResponses = base_resource.perform_operation_bulk_request(client, (base_resource[]) nspbr6Array, nameof (apply));
      }
      return baseResponses;
    }

    public static nspbr6[] get(nitro_service service) => (nspbr6[]) new nspbr6().get_resources(service, (options) null);

    public static nspbr6[] get(nitro_service service, options option) => (nspbr6[]) new nspbr6().get_resources(service, option);

    public static nspbr6[] get(nitro_service service, nspbr6_args args)
    {
      nspbr6 nspbr6 = new nspbr6();
      options option = new options();
      option.set_args(nitro_util.object_to_string_withoutquotes((object) args));
      return (nspbr6[]) nspbr6.get_resources(service, option);
    }

    public static nspbr6 get(nitro_service service, string name) => (nspbr6) new nspbr6()
    {
      name = name
    }.get_resource(service);

    public static nspbr6[] get(nitro_service service, string[] name)
    {
      if (name == null || name.Length <= 0)
        return (nspbr6[]) null;
      nspbr6[] nspbr6Array1 = new nspbr6[name.Length];
      nspbr6[] nspbr6Array2 = new nspbr6[name.Length];
      for (int index = 0; index < name.Length; ++index)
      {
        nspbr6Array2[index] = new nspbr6();
        nspbr6Array2[index].name = name[index];
        nspbr6Array1[index] = (nspbr6) nspbr6Array2[index].get_resource(service);
      }
      return nspbr6Array1;
    }

    public static nspbr6[] get_filtered(nitro_service service, string filter)
    {
      nspbr6 nspbr6 = new nspbr6();
      options option = new options();
      option.set_filter(filter);
      return (nspbr6[]) nspbr6.getfiltered(service, option);
    }

    public static nspbr6[] get_filtered(nitro_service service, filtervalue[] filter)
    {
      nspbr6 nspbr6 = new nspbr6();
      options option = new options();
      option.set_filter(filter);
      return (nspbr6[]) nspbr6.getfiltered(service, option);
    }

    public static uint count(nitro_service service)
    {
      nspbr6 nspbr6 = new nspbr6();
      options option = new options();
      option.set_count(true);
      nspbr6[] resources = (nspbr6[]) nspbr6.get_resources(service, option);
      return resources != null && resources.Length > 0 ? resources[0].__count.Value : 0U;
    }

    public static uint count_filtered(nitro_service service, string filter)
    {
      nspbr6 nspbr6 = new nspbr6();
      options option = new options();
      option.set_count(true);
      option.set_filter(filter);
      nspbr6[] nspbr6Array = (nspbr6[]) nspbr6.getfiltered(service, option);
      return nspbr6Array != null && nspbr6Array.Length > 0 ? nspbr6Array[0].__count.Value : 0U;
    }

    public static uint count_filtered(nitro_service service, filtervalue[] filter)
    {
      nspbr6 nspbr6 = new nspbr6();
      options option = new options();
      option.set_count(true);
      option.set_filter(filter);
      nspbr6[] nspbr6Array = (nspbr6[]) nspbr6.getfiltered(service, option);
      return nspbr6Array != null && nspbr6Array.Length > 0 ? nspbr6Array[0].__count.Value : 0U;
    }

    private class nspbr6_response : base_response
    {
      public nspbr6[] nspbr6 = (nspbr6[]) null;
    }

    public static class protocolEnum
    {
      public const string ICMPV6 = "ICMPV6";
      public const string TCP = "TCP";
      public const string UDP = "UDP";
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
