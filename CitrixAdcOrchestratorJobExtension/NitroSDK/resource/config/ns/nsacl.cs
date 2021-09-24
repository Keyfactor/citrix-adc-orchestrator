// Decompiled with JetBrains decompiler
// Type: com.citrix.netscaler.nitro.resource.config.ns.nsacl
// Assembly: nitro, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 6CF5DDEF-E052-4F9D-953F-6644F8378A66


using com.citrix.netscaler.nitro.exception;
using com.citrix.netscaler.nitro.resource.Base;
using com.citrix.netscaler.nitro.service;
using com.citrix.netscaler.nitro.util;

namespace com.citrix.netscaler.nitro.resource.config.ns
{
  public class nsacl : base_resource
  {
    private string aclnameField = (string) null;
    private string aclactionField = (string) null;
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
    private uint? ttlField = new uint?();
    private string srcmacField = (string) null;
    private string srcmacmaskField = (string) null;
    private string protocolField = (string) null;
    private uint? protocolnumberField = new uint?();
    private uint? vlanField = new uint?();
    private uint? vxlanField = new uint?();
    private string InterfaceField = (string) null;
    private bool? establishedField = new bool?();
    private uint? icmptypeField = new uint?();
    private uint? icmpcodeField = new uint?();
    private uint? priorityField = new uint?();
    private string stateField = (string) null;
    private string logstateField = (string) null;
    private uint? ratelimitField = new uint?();
    private string newnameField = (string) null;
    private long? hitsField = new long?();
    private string kernelstateField = (string) null;
    private uint? __countField = new uint?();

    public uint? __count
    {
      get => this.__countField;
      private set => this.__countField = value;
    }

    public string aclname
    {
      get => this.aclnameField;
      set => this.aclnameField = value;
    }

    public string aclaction
    {
      get => this.aclactionField;
      set => this.aclactionField = value;
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

    public uint? ttl
    {
      get => this.ttlField;
      set => this.ttlField = value;
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

    public bool? established
    {
      get => this.establishedField;
      set => this.establishedField = value;
    }

    public uint? icmptype
    {
      get => this.icmptypeField;
      set => this.icmptypeField = value;
    }

    public uint? icmpcode
    {
      get => this.icmpcodeField;
      set => this.icmpcodeField = value;
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

    public string logstate
    {
      get => this.logstateField;
      set => this.logstateField = value;
    }

    public uint? ratelimit
    {
      get => this.ratelimitField;
      set => this.ratelimitField = value;
    }

    public string newname
    {
      get => this.newnameField;
      set => this.newnameField = value;
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

    internal override base_resource[] get_nitro_response(
      nitro_service service,
      string response)
    {
      nsacl.nsacl_response nsaclResponse = new nsacl.nsacl_response();
      nsacl.nsacl_response resource = (nsacl.nsacl_response) service.get_payload_formatter().string_to_resource(nsaclResponse.GetType(), response);
      if (resource.errorcode != 0)
      {
        if (resource.errorcode == 444)
          service.clear_session();
        if (resource.severity == null)
          throw new nitro_exception(resource.message, resource.errorcode);
        if (resource.severity.Equals("ERROR"))
          throw new nitro_exception(resource.message, resource.errorcode);
      }
      return (base_resource[]) resource.nsacl;
    }

    internal override string get_object_name() => this.aclname;

    public static base_response add(nitro_service client, nsacl resource) => new nsacl()
    {
      aclname = resource.aclname,
      aclaction = resource.aclaction,
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
      ttl = resource.ttl,
      srcmac = resource.srcmac,
      srcmacmask = resource.srcmacmask,
      protocol = resource.protocol,
      protocolnumber = resource.protocolnumber,
      vlan = resource.vlan,
      vxlan = resource.vxlan,
      Interface = resource.Interface,
      established = resource.established,
      icmptype = resource.icmptype,
      icmpcode = resource.icmpcode,
      priority = resource.priority,
      state = resource.state,
      logstate = resource.logstate,
      ratelimit = resource.ratelimit
    }.add_resource(client);

    public static base_responses add(nitro_service client, nsacl[] resources)
    {
      base_responses baseResponses = (base_responses) null;
      if (resources != null && resources.Length > 0)
      {
        nsacl[] nsaclArray = new nsacl[resources.Length];
        for (int index = 0; index < resources.Length; ++index)
        {
          nsaclArray[index] = new nsacl();
          nsaclArray[index].aclname = resources[index].aclname;
          nsaclArray[index].aclaction = resources[index].aclaction;
          nsaclArray[index].td = resources[index].td;
          nsaclArray[index].srcip = resources[index].srcip;
          nsaclArray[index].srcipop = resources[index].srcipop;
          nsaclArray[index].srcipval = resources[index].srcipval;
          nsaclArray[index].srcport = resources[index].srcport;
          nsaclArray[index].srcportop = resources[index].srcportop;
          nsaclArray[index].srcportval = resources[index].srcportval;
          nsaclArray[index].destip = resources[index].destip;
          nsaclArray[index].destipop = resources[index].destipop;
          nsaclArray[index].destipval = resources[index].destipval;
          nsaclArray[index].destport = resources[index].destport;
          nsaclArray[index].destportop = resources[index].destportop;
          nsaclArray[index].destportval = resources[index].destportval;
          nsaclArray[index].ttl = resources[index].ttl;
          nsaclArray[index].srcmac = resources[index].srcmac;
          nsaclArray[index].srcmacmask = resources[index].srcmacmask;
          nsaclArray[index].protocol = resources[index].protocol;
          nsaclArray[index].protocolnumber = resources[index].protocolnumber;
          nsaclArray[index].vlan = resources[index].vlan;
          nsaclArray[index].vxlan = resources[index].vxlan;
          nsaclArray[index].Interface = resources[index].Interface;
          nsaclArray[index].established = resources[index].established;
          nsaclArray[index].icmptype = resources[index].icmptype;
          nsaclArray[index].icmpcode = resources[index].icmpcode;
          nsaclArray[index].priority = resources[index].priority;
          nsaclArray[index].state = resources[index].state;
          nsaclArray[index].logstate = resources[index].logstate;
          nsaclArray[index].ratelimit = resources[index].ratelimit;
        }
        baseResponses = base_resource.add_bulk_request(client, (base_resource[]) nsaclArray);
      }
      return baseResponses;
    }

    public static base_response delete(nitro_service client, string aclname) => new nsacl()
    {
      aclname = aclname
    }.delete_resource(client);

    public static base_response delete(nitro_service client, nsacl resource) => new nsacl()
    {
      aclname = resource.aclname
    }.delete_resource(client);

    public static base_responses delete(nitro_service client, string[] aclname)
    {
      base_responses baseResponses = (base_responses) null;
      if (aclname != null && aclname.Length > 0)
      {
        nsacl[] nsaclArray = new nsacl[aclname.Length];
        for (int index = 0; index < aclname.Length; ++index)
        {
          nsaclArray[index] = new nsacl();
          nsaclArray[index].aclname = aclname[index];
        }
        baseResponses = base_resource.delete_bulk_request(client, (base_resource[]) nsaclArray);
      }
      return baseResponses;
    }

    public static base_responses delete(nitro_service client, nsacl[] resources)
    {
      base_responses baseResponses = (base_responses) null;
      if (resources != null && resources.Length > 0)
      {
        nsacl[] nsaclArray = new nsacl[resources.Length];
        for (int index = 0; index < resources.Length; ++index)
        {
          nsaclArray[index] = new nsacl();
          nsaclArray[index].aclname = resources[index].aclname;
        }
        baseResponses = base_resource.delete_bulk_request(client, (base_resource[]) nsaclArray);
      }
      return baseResponses;
    }

    public static base_response update(nitro_service client, nsacl resource) => new nsacl()
    {
      aclname = resource.aclname,
      aclaction = resource.aclaction,
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
      srcmac = resource.srcmac,
      srcmacmask = resource.srcmacmask,
      protocol = resource.protocol,
      protocolnumber = resource.protocolnumber,
      icmptype = resource.icmptype,
      icmpcode = resource.icmpcode,
      vlan = resource.vlan,
      vxlan = resource.vxlan,
      Interface = resource.Interface,
      priority = resource.priority,
      logstate = resource.logstate,
      ratelimit = resource.ratelimit,
      established = resource.established
    }.update_resource(client);

    public static base_responses update(nitro_service client, nsacl[] resources)
    {
      base_responses baseResponses = (base_responses) null;
      if (resources != null && resources.Length > 0)
      {
        nsacl[] nsaclArray = new nsacl[resources.Length];
        for (int index = 0; index < resources.Length; ++index)
        {
          nsaclArray[index] = new nsacl();
          nsaclArray[index].aclname = resources[index].aclname;
          nsaclArray[index].aclaction = resources[index].aclaction;
          nsaclArray[index].srcip = resources[index].srcip;
          nsaclArray[index].srcipop = resources[index].srcipop;
          nsaclArray[index].srcipval = resources[index].srcipval;
          nsaclArray[index].srcport = resources[index].srcport;
          nsaclArray[index].srcportop = resources[index].srcportop;
          nsaclArray[index].srcportval = resources[index].srcportval;
          nsaclArray[index].destip = resources[index].destip;
          nsaclArray[index].destipop = resources[index].destipop;
          nsaclArray[index].destipval = resources[index].destipval;
          nsaclArray[index].destport = resources[index].destport;
          nsaclArray[index].destportop = resources[index].destportop;
          nsaclArray[index].destportval = resources[index].destportval;
          nsaclArray[index].srcmac = resources[index].srcmac;
          nsaclArray[index].srcmacmask = resources[index].srcmacmask;
          nsaclArray[index].protocol = resources[index].protocol;
          nsaclArray[index].protocolnumber = resources[index].protocolnumber;
          nsaclArray[index].icmptype = resources[index].icmptype;
          nsaclArray[index].icmpcode = resources[index].icmpcode;
          nsaclArray[index].vlan = resources[index].vlan;
          nsaclArray[index].vxlan = resources[index].vxlan;
          nsaclArray[index].Interface = resources[index].Interface;
          nsaclArray[index].priority = resources[index].priority;
          nsaclArray[index].logstate = resources[index].logstate;
          nsaclArray[index].ratelimit = resources[index].ratelimit;
          nsaclArray[index].established = resources[index].established;
        }
        baseResponses = base_resource.update_bulk_request(client, (base_resource[]) nsaclArray);
      }
      return baseResponses;
    }

    public static base_response unset(
      nitro_service client,
      string aclname,
      string[] args)
    {
      return new nsacl() { aclname = aclname }.unset_resource(client, args);
    }

    public static base_response unset(
      nitro_service client,
      nsacl resource,
      string[] args)
    {
      return new nsacl() { aclname = resource.aclname }.unset_resource(client, args);
    }

    public static base_responses unset(
      nitro_service client,
      string[] aclname,
      string[] args)
    {
      base_responses baseResponses = (base_responses) null;
      if (aclname != null && aclname.Length > 0)
      {
        nsacl[] nsaclArray = new nsacl[aclname.Length];
        for (int index = 0; index < aclname.Length; ++index)
        {
          nsaclArray[index] = new nsacl();
          nsaclArray[index].aclname = aclname[index];
        }
        baseResponses = base_resource.unset_bulk_request(client, (base_resource[]) nsaclArray, args);
      }
      return baseResponses;
    }

    public static base_responses unset(
      nitro_service client,
      nsacl[] resources,
      string[] args)
    {
      base_responses baseResponses = (base_responses) null;
      if (resources != null && resources.Length > 0)
      {
        nsacl[] nsaclArray = new nsacl[resources.Length];
        for (int index = 0; index < resources.Length; ++index)
        {
          nsaclArray[index] = new nsacl();
          nsaclArray[index].aclname = resources[index].aclname;
        }
        baseResponses = base_resource.unset_bulk_request(client, (base_resource[]) nsaclArray, args);
      }
      return baseResponses;
    }

    public static base_response enable(nitro_service client, string aclname) => new nsacl()
    {
      aclname = aclname
    }.perform_operation_byaction(client, nameof (enable));

    public static base_response enable(nitro_service client, nsacl resource) => new nsacl()
    {
      aclname = resource.aclname
    }.perform_operation_byaction(client, nameof (enable));

    public static base_responses enable(nitro_service client, string[] aclname)
    {
      base_responses baseResponses = (base_responses) null;
      if (aclname != null && aclname.Length > 0)
      {
        nsacl[] nsaclArray = new nsacl[aclname.Length];
        for (int index = 0; index < aclname.Length; ++index)
        {
          nsaclArray[index] = new nsacl();
          nsaclArray[index].aclname = aclname[index];
        }
        baseResponses = base_resource.perform_operation_bulk_request(client, (base_resource[]) nsaclArray, nameof (enable));
      }
      return baseResponses;
    }

    public static base_responses enable(nitro_service client, nsacl[] resources)
    {
      base_responses baseResponses = (base_responses) null;
      if (resources != null && resources.Length > 0)
      {
        nsacl[] nsaclArray = new nsacl[resources.Length];
        for (int index = 0; index < resources.Length; ++index)
        {
          nsaclArray[index] = new nsacl();
          nsaclArray[index].aclname = resources[index].aclname;
        }
        baseResponses = base_resource.perform_operation_bulk_request(client, (base_resource[]) nsaclArray, nameof (enable));
      }
      return baseResponses;
    }

    public static base_response disable(nitro_service client, string aclname) => new nsacl()
    {
      aclname = aclname
    }.perform_operation_byaction(client, nameof (disable));

    public static base_response disable(nitro_service client, nsacl resource) => new nsacl()
    {
      aclname = resource.aclname
    }.perform_operation_byaction(client, nameof (disable));

    public static base_responses disable(nitro_service client, string[] aclname)
    {
      base_responses baseResponses = (base_responses) null;
      if (aclname != null && aclname.Length > 0)
      {
        nsacl[] nsaclArray = new nsacl[aclname.Length];
        for (int index = 0; index < aclname.Length; ++index)
        {
          nsaclArray[index] = new nsacl();
          nsaclArray[index].aclname = aclname[index];
        }
        baseResponses = base_resource.perform_operation_bulk_request(client, (base_resource[]) nsaclArray, nameof (disable));
      }
      return baseResponses;
    }

    public static base_responses disable(nitro_service client, nsacl[] resources)
    {
      base_responses baseResponses = (base_responses) null;
      if (resources != null && resources.Length > 0)
      {
        nsacl[] nsaclArray = new nsacl[resources.Length];
        for (int index = 0; index < resources.Length; ++index)
        {
          nsaclArray[index] = new nsacl();
          nsaclArray[index].aclname = resources[index].aclname;
        }
        baseResponses = base_resource.perform_operation_bulk_request(client, (base_resource[]) nsaclArray, nameof (disable));
      }
      return baseResponses;
    }

    public static base_response rename(
      nitro_service client,
      nsacl resource,
      string new_aclname)
    {
      return new nsacl()
      {
        aclname = resource.aclname,
        newname = new_aclname
      }.rename_resource(client);
    }

    public static base_response rename(
      nitro_service client,
      string aclname,
      string new_aclname)
    {
      return new nsacl()
      {
        aclname = aclname,
        newname = new_aclname
      }.rename_resource(client);
    }

    public static nsacl[] get(nitro_service service) => (nsacl[]) new nsacl().get_resources(service, (options) null);

    public static nsacl[] get(nitro_service service, options option) => (nsacl[]) new nsacl().get_resources(service, option);

    public static nsacl get(nitro_service service, string aclname) => (nsacl) new nsacl()
    {
      aclname = aclname
    }.get_resource(service);

    public static nsacl[] get(nitro_service service, string[] aclname)
    {
      if (aclname == null || aclname.Length <= 0)
        return (nsacl[]) null;
      nsacl[] nsaclArray1 = new nsacl[aclname.Length];
      nsacl[] nsaclArray2 = new nsacl[aclname.Length];
      for (int index = 0; index < aclname.Length; ++index)
      {
        nsaclArray2[index] = new nsacl();
        nsaclArray2[index].aclname = aclname[index];
        nsaclArray1[index] = (nsacl) nsaclArray2[index].get_resource(service);
      }
      return nsaclArray1;
    }

    public static nsacl[] get_filtered(nitro_service service, string filter)
    {
      nsacl nsacl = new nsacl();
      options option = new options();
      option.set_filter(filter);
      return (nsacl[]) nsacl.getfiltered(service, option);
    }

    public static nsacl[] get_filtered(nitro_service service, filtervalue[] filter)
    {
      nsacl nsacl = new nsacl();
      options option = new options();
      option.set_filter(filter);
      return (nsacl[]) nsacl.getfiltered(service, option);
    }

    public static uint count(nitro_service service)
    {
      nsacl nsacl = new nsacl();
      options option = new options();
      option.set_count(true);
      nsacl[] resources = (nsacl[]) nsacl.get_resources(service, option);
      return resources != null && resources.Length > 0 ? resources[0].__count.Value : 0U;
    }

    public static uint count_filtered(nitro_service service, string filter)
    {
      nsacl nsacl = new nsacl();
      options option = new options();
      option.set_count(true);
      option.set_filter(filter);
      nsacl[] nsaclArray = (nsacl[]) nsacl.getfiltered(service, option);
      return nsaclArray != null && nsaclArray.Length > 0 ? nsaclArray[0].__count.Value : 0U;
    }

    public static uint count_filtered(nitro_service service, filtervalue[] filter)
    {
      nsacl nsacl = new nsacl();
      options option = new options();
      option.set_count(true);
      option.set_filter(filter);
      nsacl[] nsaclArray = (nsacl[]) nsacl.getfiltered(service, option);
      return nsaclArray != null && nsaclArray.Length > 0 ? nsaclArray[0].__count.Value : 0U;
    }

    private class nsacl_response : base_response
    {
      public nsacl[] nsacl = (nsacl[]) null;
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

    public static class aclactionEnum
    {
      public const string BRIDGE = "BRIDGE";
      public const string DENY = "DENY";
      public const string ALLOW = "ALLOW";
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

    public static class logstateEnum
    {
      public const string ENABLED = "ENABLED";
      public const string DISABLED = "DISABLED";
    }

    public static class destportopEnum
    {
      public const string _EQ = "=";
      public const string _NEQ = "!=";
      public const string EQ = "EQ";
      public const string NEQ = "NEQ";
    }
  }
}
