// Decompiled with JetBrains decompiler
// Type: com.citrix.netscaler.nitro.resource.config.ns.nsacl6
// Assembly: nitro, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 6CF5DDEF-E052-4F9D-953F-6644F8378A66


using com.citrix.netscaler.nitro.exception;
using com.citrix.netscaler.nitro.resource.Base;
using com.citrix.netscaler.nitro.service;
using com.citrix.netscaler.nitro.util;

namespace com.citrix.netscaler.nitro.resource.config.ns
{
  public class nsacl6 : base_resource
  {
    private string acl6nameField = (string) null;
    private string acl6actionField = (string) null;
    private uint? tdField = new uint?();
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
    private string aclactionField = (string) null;
    private string newnameField = (string) null;
    private string kernelstateField = (string) null;
    private long? hitsField = new long?();
    private uint? __countField = new uint?();

    public uint? __count
    {
      get => this.__countField;
      private set => this.__countField = value;
    }

    public string acl6name
    {
      get => this.acl6nameField;
      set => this.acl6nameField = value;
    }

    public string acl6action
    {
      get => this.acl6actionField;
      set => this.acl6actionField = value;
    }

    public uint? td
    {
      get => this.tdField;
      set => this.tdField = value;
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

    public string aclaction
    {
      get => this.aclactionField;
      set => this.aclactionField = value;
    }

    public string newname
    {
      get => this.newnameField;
      set => this.newnameField = value;
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

    internal override base_resource[] get_nitro_response(
      nitro_service service,
      string response)
    {
      nsacl6.nsacl6_response nsacl6Response = new nsacl6.nsacl6_response();
      nsacl6.nsacl6_response resource = (nsacl6.nsacl6_response) service.get_payload_formatter().string_to_resource(nsacl6Response.GetType(), response);
      if (resource.errorcode != 0)
      {
        if (resource.errorcode == 444)
          service.clear_session();
        if (resource.severity == null)
          throw new nitro_exception(resource.message, resource.errorcode);
        if (resource.severity.Equals("ERROR"))
          throw new nitro_exception(resource.message, resource.errorcode);
      }
      return (base_resource[]) resource.nsacl6;
    }

    internal override string get_object_name() => this.acl6name;

    public static base_response add(nitro_service client, nsacl6 resource) => new nsacl6()
    {
      acl6name = resource.acl6name,
      acl6action = resource.acl6action,
      td = resource.td,
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
      state = resource.state
    }.add_resource(client);

    public static base_responses add(nitro_service client, nsacl6[] resources)
    {
      base_responses baseResponses = (base_responses) null;
      if (resources != null && resources.Length > 0)
      {
        nsacl6[] nsacl6Array = new nsacl6[resources.Length];
        for (int index = 0; index < resources.Length; ++index)
        {
          nsacl6Array[index] = new nsacl6();
          nsacl6Array[index].acl6name = resources[index].acl6name;
          nsacl6Array[index].acl6action = resources[index].acl6action;
          nsacl6Array[index].td = resources[index].td;
          nsacl6Array[index].srcipv6 = resources[index].srcipv6;
          nsacl6Array[index].srcipop = resources[index].srcipop;
          nsacl6Array[index].srcipv6val = resources[index].srcipv6val;
          nsacl6Array[index].srcport = resources[index].srcport;
          nsacl6Array[index].srcportop = resources[index].srcportop;
          nsacl6Array[index].srcportval = resources[index].srcportval;
          nsacl6Array[index].destipv6 = resources[index].destipv6;
          nsacl6Array[index].destipop = resources[index].destipop;
          nsacl6Array[index].destipv6val = resources[index].destipv6val;
          nsacl6Array[index].destport = resources[index].destport;
          nsacl6Array[index].destportop = resources[index].destportop;
          nsacl6Array[index].destportval = resources[index].destportval;
          nsacl6Array[index].ttl = resources[index].ttl;
          nsacl6Array[index].srcmac = resources[index].srcmac;
          nsacl6Array[index].srcmacmask = resources[index].srcmacmask;
          nsacl6Array[index].protocol = resources[index].protocol;
          nsacl6Array[index].protocolnumber = resources[index].protocolnumber;
          nsacl6Array[index].vlan = resources[index].vlan;
          nsacl6Array[index].vxlan = resources[index].vxlan;
          nsacl6Array[index].Interface = resources[index].Interface;
          nsacl6Array[index].established = resources[index].established;
          nsacl6Array[index].icmptype = resources[index].icmptype;
          nsacl6Array[index].icmpcode = resources[index].icmpcode;
          nsacl6Array[index].priority = resources[index].priority;
          nsacl6Array[index].state = resources[index].state;
        }
        baseResponses = base_resource.add_bulk_request(client, (base_resource[]) nsacl6Array);
      }
      return baseResponses;
    }

    public static base_response delete(nitro_service client, string acl6name) => new nsacl6()
    {
      acl6name = acl6name
    }.delete_resource(client);

    public static base_response delete(nitro_service client, nsacl6 resource) => new nsacl6()
    {
      acl6name = resource.acl6name
    }.delete_resource(client);

    public static base_responses delete(nitro_service client, string[] acl6name)
    {
      base_responses baseResponses = (base_responses) null;
      if (acl6name != null && acl6name.Length > 0)
      {
        nsacl6[] nsacl6Array = new nsacl6[acl6name.Length];
        for (int index = 0; index < acl6name.Length; ++index)
        {
          nsacl6Array[index] = new nsacl6();
          nsacl6Array[index].acl6name = acl6name[index];
        }
        baseResponses = base_resource.delete_bulk_request(client, (base_resource[]) nsacl6Array);
      }
      return baseResponses;
    }

    public static base_responses delete(nitro_service client, nsacl6[] resources)
    {
      base_responses baseResponses = (base_responses) null;
      if (resources != null && resources.Length > 0)
      {
        nsacl6[] nsacl6Array = new nsacl6[resources.Length];
        for (int index = 0; index < resources.Length; ++index)
        {
          nsacl6Array[index] = new nsacl6();
          nsacl6Array[index].acl6name = resources[index].acl6name;
        }
        baseResponses = base_resource.delete_bulk_request(client, (base_resource[]) nsacl6Array);
      }
      return baseResponses;
    }

    public static base_response update(nitro_service client, nsacl6 resource) => new nsacl6()
    {
      acl6name = resource.acl6name,
      aclaction = resource.aclaction,
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
      icmptype = resource.icmptype,
      icmpcode = resource.icmpcode,
      vlan = resource.vlan,
      vxlan = resource.vxlan,
      Interface = resource.Interface,
      priority = resource.priority,
      established = resource.established
    }.update_resource(client);

    public static base_responses update(nitro_service client, nsacl6[] resources)
    {
      base_responses baseResponses = (base_responses) null;
      if (resources != null && resources.Length > 0)
      {
        nsacl6[] nsacl6Array = new nsacl6[resources.Length];
        for (int index = 0; index < resources.Length; ++index)
        {
          nsacl6Array[index] = new nsacl6();
          nsacl6Array[index].acl6name = resources[index].acl6name;
          nsacl6Array[index].aclaction = resources[index].aclaction;
          nsacl6Array[index].srcipv6 = resources[index].srcipv6;
          nsacl6Array[index].srcipop = resources[index].srcipop;
          nsacl6Array[index].srcipv6val = resources[index].srcipv6val;
          nsacl6Array[index].srcport = resources[index].srcport;
          nsacl6Array[index].srcportop = resources[index].srcportop;
          nsacl6Array[index].srcportval = resources[index].srcportval;
          nsacl6Array[index].destipv6 = resources[index].destipv6;
          nsacl6Array[index].destipop = resources[index].destipop;
          nsacl6Array[index].destipv6val = resources[index].destipv6val;
          nsacl6Array[index].destport = resources[index].destport;
          nsacl6Array[index].destportop = resources[index].destportop;
          nsacl6Array[index].destportval = resources[index].destportval;
          nsacl6Array[index].srcmac = resources[index].srcmac;
          nsacl6Array[index].srcmacmask = resources[index].srcmacmask;
          nsacl6Array[index].protocol = resources[index].protocol;
          nsacl6Array[index].protocolnumber = resources[index].protocolnumber;
          nsacl6Array[index].icmptype = resources[index].icmptype;
          nsacl6Array[index].icmpcode = resources[index].icmpcode;
          nsacl6Array[index].vlan = resources[index].vlan;
          nsacl6Array[index].vxlan = resources[index].vxlan;
          nsacl6Array[index].Interface = resources[index].Interface;
          nsacl6Array[index].priority = resources[index].priority;
          nsacl6Array[index].established = resources[index].established;
        }
        baseResponses = base_resource.update_bulk_request(client, (base_resource[]) nsacl6Array);
      }
      return baseResponses;
    }

    public static base_response unset(
      nitro_service client,
      string acl6name,
      string[] args)
    {
      return new nsacl6() { acl6name = acl6name }.unset_resource(client, args);
    }

    public static base_response unset(
      nitro_service client,
      nsacl6 resource,
      string[] args)
    {
      return new nsacl6() { acl6name = resource.acl6name }.unset_resource(client, args);
    }

    public static base_responses unset(
      nitro_service client,
      string[] acl6name,
      string[] args)
    {
      base_responses baseResponses = (base_responses) null;
      if (acl6name != null && acl6name.Length > 0)
      {
        nsacl6[] nsacl6Array = new nsacl6[acl6name.Length];
        for (int index = 0; index < acl6name.Length; ++index)
        {
          nsacl6Array[index] = new nsacl6();
          nsacl6Array[index].acl6name = acl6name[index];
        }
        baseResponses = base_resource.unset_bulk_request(client, (base_resource[]) nsacl6Array, args);
      }
      return baseResponses;
    }

    public static base_responses unset(
      nitro_service client,
      nsacl6[] resources,
      string[] args)
    {
      base_responses baseResponses = (base_responses) null;
      if (resources != null && resources.Length > 0)
      {
        nsacl6[] nsacl6Array = new nsacl6[resources.Length];
        for (int index = 0; index < resources.Length; ++index)
        {
          nsacl6Array[index] = new nsacl6();
          nsacl6Array[index].acl6name = resources[index].acl6name;
        }
        baseResponses = base_resource.unset_bulk_request(client, (base_resource[]) nsacl6Array, args);
      }
      return baseResponses;
    }

    public static base_response enable(nitro_service client, string acl6name) => new nsacl6()
    {
      acl6name = acl6name
    }.perform_operation_byaction(client, nameof (enable));

    public static base_response enable(nitro_service client, nsacl6 resource) => new nsacl6()
    {
      acl6name = resource.acl6name
    }.perform_operation_byaction(client, nameof (enable));

    public static base_responses enable(nitro_service client, string[] acl6name)
    {
      base_responses baseResponses = (base_responses) null;
      if (acl6name != null && acl6name.Length > 0)
      {
        nsacl6[] nsacl6Array = new nsacl6[acl6name.Length];
        for (int index = 0; index < acl6name.Length; ++index)
        {
          nsacl6Array[index] = new nsacl6();
          nsacl6Array[index].acl6name = acl6name[index];
        }
        baseResponses = base_resource.perform_operation_bulk_request(client, (base_resource[]) nsacl6Array, nameof (enable));
      }
      return baseResponses;
    }

    public static base_responses enable(nitro_service client, nsacl6[] resources)
    {
      base_responses baseResponses = (base_responses) null;
      if (resources != null && resources.Length > 0)
      {
        nsacl6[] nsacl6Array = new nsacl6[resources.Length];
        for (int index = 0; index < resources.Length; ++index)
        {
          nsacl6Array[index] = new nsacl6();
          nsacl6Array[index].acl6name = resources[index].acl6name;
        }
        baseResponses = base_resource.perform_operation_bulk_request(client, (base_resource[]) nsacl6Array, nameof (enable));
      }
      return baseResponses;
    }

    public static base_response disable(nitro_service client, string acl6name) => new nsacl6()
    {
      acl6name = acl6name
    }.perform_operation_byaction(client, nameof (disable));

    public static base_response disable(nitro_service client, nsacl6 resource) => new nsacl6()
    {
      acl6name = resource.acl6name
    }.perform_operation_byaction(client, nameof (disable));

    public static base_responses disable(nitro_service client, string[] acl6name)
    {
      base_responses baseResponses = (base_responses) null;
      if (acl6name != null && acl6name.Length > 0)
      {
        nsacl6[] nsacl6Array = new nsacl6[acl6name.Length];
        for (int index = 0; index < acl6name.Length; ++index)
        {
          nsacl6Array[index] = new nsacl6();
          nsacl6Array[index].acl6name = acl6name[index];
        }
        baseResponses = base_resource.perform_operation_bulk_request(client, (base_resource[]) nsacl6Array, nameof (disable));
      }
      return baseResponses;
    }

    public static base_responses disable(nitro_service client, nsacl6[] resources)
    {
      base_responses baseResponses = (base_responses) null;
      if (resources != null && resources.Length > 0)
      {
        nsacl6[] nsacl6Array = new nsacl6[resources.Length];
        for (int index = 0; index < resources.Length; ++index)
        {
          nsacl6Array[index] = new nsacl6();
          nsacl6Array[index].acl6name = resources[index].acl6name;
        }
        baseResponses = base_resource.perform_operation_bulk_request(client, (base_resource[]) nsacl6Array, nameof (disable));
      }
      return baseResponses;
    }

    public static base_response rename(
      nitro_service client,
      nsacl6 resource,
      string new_acl6name)
    {
      return new nsacl6()
      {
        acl6name = resource.acl6name,
        newname = new_acl6name
      }.rename_resource(client);
    }

    public static base_response rename(
      nitro_service client,
      string acl6name,
      string new_acl6name)
    {
      return new nsacl6()
      {
        acl6name = acl6name,
        newname = new_acl6name
      }.rename_resource(client);
    }

    public static nsacl6[] get(nitro_service service) => (nsacl6[]) new nsacl6().get_resources(service, (options) null);

    public static nsacl6[] get(nitro_service service, options option) => (nsacl6[]) new nsacl6().get_resources(service, option);

    public static nsacl6 get(nitro_service service, string acl6name) => (nsacl6) new nsacl6()
    {
      acl6name = acl6name
    }.get_resource(service);

    public static nsacl6[] get(nitro_service service, string[] acl6name)
    {
      if (acl6name == null || acl6name.Length <= 0)
        return (nsacl6[]) null;
      nsacl6[] nsacl6Array1 = new nsacl6[acl6name.Length];
      nsacl6[] nsacl6Array2 = new nsacl6[acl6name.Length];
      for (int index = 0; index < acl6name.Length; ++index)
      {
        nsacl6Array2[index] = new nsacl6();
        nsacl6Array2[index].acl6name = acl6name[index];
        nsacl6Array1[index] = (nsacl6) nsacl6Array2[index].get_resource(service);
      }
      return nsacl6Array1;
    }

    public static nsacl6[] get_filtered(nitro_service service, string filter)
    {
      nsacl6 nsacl6 = new nsacl6();
      options option = new options();
      option.set_filter(filter);
      return (nsacl6[]) nsacl6.getfiltered(service, option);
    }

    public static nsacl6[] get_filtered(nitro_service service, filtervalue[] filter)
    {
      nsacl6 nsacl6 = new nsacl6();
      options option = new options();
      option.set_filter(filter);
      return (nsacl6[]) nsacl6.getfiltered(service, option);
    }

    public static uint count(nitro_service service)
    {
      nsacl6 nsacl6 = new nsacl6();
      options option = new options();
      option.set_count(true);
      nsacl6[] resources = (nsacl6[]) nsacl6.get_resources(service, option);
      return resources != null && resources.Length > 0 ? resources[0].__count.Value : 0U;
    }

    public static uint count_filtered(nitro_service service, string filter)
    {
      nsacl6 nsacl6 = new nsacl6();
      options option = new options();
      option.set_count(true);
      option.set_filter(filter);
      nsacl6[] nsacl6Array = (nsacl6[]) nsacl6.getfiltered(service, option);
      return nsacl6Array != null && nsacl6Array.Length > 0 ? nsacl6Array[0].__count.Value : 0U;
    }

    public static uint count_filtered(nitro_service service, filtervalue[] filter)
    {
      nsacl6 nsacl6 = new nsacl6();
      options option = new options();
      option.set_count(true);
      option.set_filter(filter);
      nsacl6[] nsacl6Array = (nsacl6[]) nsacl6.getfiltered(service, option);
      return nsacl6Array != null && nsacl6Array.Length > 0 ? nsacl6Array[0].__count.Value : 0U;
    }

    private class nsacl6_response : base_response
    {
      public nsacl6[] nsacl6 = (nsacl6[]) null;
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

    public static class acl6actionEnum
    {
      public const string BRIDGE = "BRIDGE";
      public const string DENY = "DENY";
      public const string ALLOW = "ALLOW";
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

    public static class destportopEnum
    {
      public const string _EQ = "=";
      public const string _NEQ = "!=";
      public const string EQ = "EQ";
      public const string NEQ = "NEQ";
    }
  }
}
