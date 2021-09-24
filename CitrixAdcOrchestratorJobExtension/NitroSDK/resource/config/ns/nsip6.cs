// Decompiled with JetBrains decompiler
// Type: com.citrix.netscaler.nitro.resource.config.ns.nsip6
// Assembly: nitro, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 6CF5DDEF-E052-4F9D-953F-6644F8378A66


using com.citrix.netscaler.nitro.exception;
using com.citrix.netscaler.nitro.resource.Base;
using com.citrix.netscaler.nitro.service;
using com.citrix.netscaler.nitro.util;

namespace com.citrix.netscaler.nitro.resource.config.ns
{
  public class nsip6 : base_resource
  {
    private string ipv6addressField = (string) null;
    private string scopeField = (string) null;
    private string typeField = (string) null;
    private uint? vlanField = new uint?();
    private string ndField = (string) null;
    private string icmpField = (string) null;
    private string vserverField = (string) null;
    private string telnetField = (string) null;
    private string ftpField = (string) null;
    private string guiField = (string) null;
    private string sshField = (string) null;
    private string snmpField = (string) null;
    private string mgmtaccessField = (string) null;
    private string restrictaccessField = (string) null;
    private string dynamicroutingField = (string) null;
    private string hostrouteField = (string) null;
    private string ip6hostrtgwField = (string) null;
    private int? metricField = new int?();
    private string vserverrhilevelField = (string) null;
    private string ospf6lsatypeField = (string) null;
    private uint? ospfareaField = new uint?();
    private string stateField = (string) null;
    private string mapField = (string) null;
    private uint? ownernodeField = new uint?();
    private uint? tdField = new uint?();
    private string[] iptypeField = (string[]) null;
    private string curstateField = (string) null;
    private bool? viprtadv2bsdField = new bool?();
    private uint? vipvsercountField = new uint?();
    private uint? vipvserdowncountField = new uint?();
    private string systemtypeField = (string) null;
    private uint? __countField = new uint?();

    public uint? __count
    {
      get => this.__countField;
      private set => this.__countField = value;
    }

    public string ipv6address
    {
      get => this.ipv6addressField;
      set => this.ipv6addressField = value;
    }

    public string scope
    {
      get => this.scopeField;
      set => this.scopeField = value;
    }

    public string type
    {
      get => this.typeField;
      set => this.typeField = value;
    }

    public uint? vlan
    {
      get => this.vlanField;
      set => this.vlanField = value;
    }

    public string nd
    {
      get => this.ndField;
      set => this.ndField = value;
    }

    public string icmp
    {
      get => this.icmpField;
      set => this.icmpField = value;
    }

    public string vserver
    {
      get => this.vserverField;
      set => this.vserverField = value;
    }

    public string telnet
    {
      get => this.telnetField;
      set => this.telnetField = value;
    }

    public string ftp
    {
      get => this.ftpField;
      set => this.ftpField = value;
    }

    public string gui
    {
      get => this.guiField;
      set => this.guiField = value;
    }

    public string ssh
    {
      get => this.sshField;
      set => this.sshField = value;
    }

    public string snmp
    {
      get => this.snmpField;
      set => this.snmpField = value;
    }

    public string mgmtaccess
    {
      get => this.mgmtaccessField;
      set => this.mgmtaccessField = value;
    }

    public string restrictaccess
    {
      get => this.restrictaccessField;
      set => this.restrictaccessField = value;
    }

    public string dynamicrouting
    {
      get => this.dynamicroutingField;
      set => this.dynamicroutingField = value;
    }

    public string hostroute
    {
      get => this.hostrouteField;
      set => this.hostrouteField = value;
    }

    public string ip6hostrtgw
    {
      get => this.ip6hostrtgwField;
      set => this.ip6hostrtgwField = value;
    }

    public int? metric
    {
      get => this.metricField;
      set => this.metricField = value;
    }

    public string vserverrhilevel
    {
      get => this.vserverrhilevelField;
      set => this.vserverrhilevelField = value;
    }

    public string ospf6lsatype
    {
      get => this.ospf6lsatypeField;
      set => this.ospf6lsatypeField = value;
    }

    public uint? ospfarea
    {
      get => this.ospfareaField;
      set => this.ospfareaField = value;
    }

    public string state
    {
      get => this.stateField;
      set => this.stateField = value;
    }

    public string map
    {
      get => this.mapField;
      set => this.mapField = value;
    }

    public uint? ownernode
    {
      get => this.ownernodeField;
      set => this.ownernodeField = value;
    }

    public uint? td
    {
      get => this.tdField;
      set => this.tdField = value;
    }

    public string[] iptype
    {
      get => this.iptypeField;
      private set => this.iptypeField = value;
    }

    public string curstate
    {
      get => this.curstateField;
      private set => this.curstateField = value;
    }

    public bool? viprtadv2bsd
    {
      get => this.viprtadv2bsdField;
      private set => this.viprtadv2bsdField = value;
    }

    public uint? vipvsercount
    {
      get => this.vipvsercountField;
      private set => this.vipvsercountField = value;
    }

    public uint? vipvserdowncount
    {
      get => this.vipvserdowncountField;
      private set => this.vipvserdowncountField = value;
    }

    public string systemtype
    {
      get => this.systemtypeField;
      private set => this.systemtypeField = value;
    }

    internal override base_resource[] get_nitro_response(
      nitro_service service,
      string response)
    {
      nsip6.nsip6_response nsip6Response = new nsip6.nsip6_response();
      nsip6.nsip6_response resource = (nsip6.nsip6_response) service.get_payload_formatter().string_to_resource(nsip6Response.GetType(), response);
      if (resource.errorcode != 0)
      {
        if (resource.errorcode == 444)
          service.clear_session();
        if (resource.severity == null)
          throw new nitro_exception(resource.message, resource.errorcode);
        if (resource.severity.Equals("ERROR"))
          throw new nitro_exception(resource.message, resource.errorcode);
      }
      return (base_resource[]) resource.nsip6;
    }

    internal override string get_object_name() => this.ipv6address;

    public static base_response add(nitro_service client, nsip6 resource) => new nsip6()
    {
      ipv6address = resource.ipv6address,
      scope = resource.scope,
      type = resource.type,
      vlan = resource.vlan,
      nd = resource.nd,
      icmp = resource.icmp,
      vserver = resource.vserver,
      telnet = resource.telnet,
      ftp = resource.ftp,
      gui = resource.gui,
      ssh = resource.ssh,
      snmp = resource.snmp,
      mgmtaccess = resource.mgmtaccess,
      restrictaccess = resource.restrictaccess,
      dynamicrouting = resource.dynamicrouting,
      hostroute = resource.hostroute,
      ip6hostrtgw = resource.ip6hostrtgw,
      metric = resource.metric,
      vserverrhilevel = resource.vserverrhilevel,
      ospf6lsatype = resource.ospf6lsatype,
      ospfarea = resource.ospfarea,
      state = resource.state,
      map = resource.map,
      ownernode = resource.ownernode,
      td = resource.td
    }.add_resource(client);

    public static base_responses add(nitro_service client, nsip6[] resources)
    {
      base_responses baseResponses = (base_responses) null;
      if (resources != null && resources.Length > 0)
      {
        nsip6[] nsip6Array = new nsip6[resources.Length];
        for (int index = 0; index < resources.Length; ++index)
        {
          nsip6Array[index] = new nsip6();
          nsip6Array[index].ipv6address = resources[index].ipv6address;
          nsip6Array[index].scope = resources[index].scope;
          nsip6Array[index].type = resources[index].type;
          nsip6Array[index].vlan = resources[index].vlan;
          nsip6Array[index].nd = resources[index].nd;
          nsip6Array[index].icmp = resources[index].icmp;
          nsip6Array[index].vserver = resources[index].vserver;
          nsip6Array[index].telnet = resources[index].telnet;
          nsip6Array[index].ftp = resources[index].ftp;
          nsip6Array[index].gui = resources[index].gui;
          nsip6Array[index].ssh = resources[index].ssh;
          nsip6Array[index].snmp = resources[index].snmp;
          nsip6Array[index].mgmtaccess = resources[index].mgmtaccess;
          nsip6Array[index].restrictaccess = resources[index].restrictaccess;
          nsip6Array[index].dynamicrouting = resources[index].dynamicrouting;
          nsip6Array[index].hostroute = resources[index].hostroute;
          nsip6Array[index].ip6hostrtgw = resources[index].ip6hostrtgw;
          nsip6Array[index].metric = resources[index].metric;
          nsip6Array[index].vserverrhilevel = resources[index].vserverrhilevel;
          nsip6Array[index].ospf6lsatype = resources[index].ospf6lsatype;
          nsip6Array[index].ospfarea = resources[index].ospfarea;
          nsip6Array[index].state = resources[index].state;
          nsip6Array[index].map = resources[index].map;
          nsip6Array[index].ownernode = resources[index].ownernode;
          nsip6Array[index].td = resources[index].td;
        }
        baseResponses = base_resource.add_bulk_request(client, (base_resource[]) nsip6Array);
      }
      return baseResponses;
    }

    public static base_response delete(nitro_service client, string ipv6address) => new nsip6()
    {
      ipv6address = ipv6address
    }.delete_resource(client);

    public static base_response delete(nitro_service client, nsip6 resource) => new nsip6()
    {
      ipv6address = resource.ipv6address,
      td = resource.td
    }.delete_resource(client);

    public static base_responses delete(nitro_service client, string[] ipv6address)
    {
      base_responses baseResponses = (base_responses) null;
      if (ipv6address != null && ipv6address.Length > 0)
      {
        nsip6[] nsip6Array = new nsip6[ipv6address.Length];
        for (int index = 0; index < ipv6address.Length; ++index)
        {
          nsip6Array[index] = new nsip6();
          nsip6Array[index].ipv6address = ipv6address[index];
        }
        baseResponses = base_resource.delete_bulk_request(client, (base_resource[]) nsip6Array);
      }
      return baseResponses;
    }

    public static base_responses delete(nitro_service client, nsip6[] resources)
    {
      base_responses baseResponses = (base_responses) null;
      if (resources != null && resources.Length > 0)
      {
        nsip6[] nsip6Array = new nsip6[resources.Length];
        for (int index = 0; index < resources.Length; ++index)
        {
          nsip6Array[index] = new nsip6();
          nsip6Array[index].ipv6address = resources[index].ipv6address;
          nsip6Array[index].td = resources[index].td;
        }
        baseResponses = base_resource.delete_bulk_request(client, (base_resource[]) nsip6Array);
      }
      return baseResponses;
    }

    public static base_response update(nitro_service client, nsip6 resource) => new nsip6()
    {
      ipv6address = resource.ipv6address,
      td = resource.td,
      nd = resource.nd,
      icmp = resource.icmp,
      vserver = resource.vserver,
      telnet = resource.telnet,
      ftp = resource.ftp,
      gui = resource.gui,
      ssh = resource.ssh,
      snmp = resource.snmp,
      mgmtaccess = resource.mgmtaccess,
      restrictaccess = resource.restrictaccess,
      state = resource.state,
      map = resource.map,
      dynamicrouting = resource.dynamicrouting,
      hostroute = resource.hostroute,
      ip6hostrtgw = resource.ip6hostrtgw,
      metric = resource.metric,
      vserverrhilevel = resource.vserverrhilevel,
      ospf6lsatype = resource.ospf6lsatype,
      ospfarea = resource.ospfarea
    }.update_resource(client);

    public static base_responses update(nitro_service client, nsip6[] resources)
    {
      base_responses baseResponses = (base_responses) null;
      if (resources != null && resources.Length > 0)
      {
        nsip6[] nsip6Array = new nsip6[resources.Length];
        for (int index = 0; index < resources.Length; ++index)
        {
          nsip6Array[index] = new nsip6();
          nsip6Array[index].ipv6address = resources[index].ipv6address;
          nsip6Array[index].td = resources[index].td;
          nsip6Array[index].nd = resources[index].nd;
          nsip6Array[index].icmp = resources[index].icmp;
          nsip6Array[index].vserver = resources[index].vserver;
          nsip6Array[index].telnet = resources[index].telnet;
          nsip6Array[index].ftp = resources[index].ftp;
          nsip6Array[index].gui = resources[index].gui;
          nsip6Array[index].ssh = resources[index].ssh;
          nsip6Array[index].snmp = resources[index].snmp;
          nsip6Array[index].mgmtaccess = resources[index].mgmtaccess;
          nsip6Array[index].restrictaccess = resources[index].restrictaccess;
          nsip6Array[index].state = resources[index].state;
          nsip6Array[index].map = resources[index].map;
          nsip6Array[index].dynamicrouting = resources[index].dynamicrouting;
          nsip6Array[index].hostroute = resources[index].hostroute;
          nsip6Array[index].ip6hostrtgw = resources[index].ip6hostrtgw;
          nsip6Array[index].metric = resources[index].metric;
          nsip6Array[index].vserverrhilevel = resources[index].vserverrhilevel;
          nsip6Array[index].ospf6lsatype = resources[index].ospf6lsatype;
          nsip6Array[index].ospfarea = resources[index].ospfarea;
        }
        baseResponses = base_resource.update_bulk_request(client, (base_resource[]) nsip6Array);
      }
      return baseResponses;
    }

    public static base_response unset(
      nitro_service client,
      string ipv6address,
      string[] args)
    {
      return new nsip6() { ipv6address = ipv6address }.unset_resource(client, args);
    }

    public static base_response unset(
      nitro_service client,
      nsip6 resource,
      string[] args)
    {
      return new nsip6()
      {
        ipv6address = resource.ipv6address,
        td = resource.td
      }.unset_resource(client, args);
    }

    public static base_responses unset(
      nitro_service client,
      string[] ipv6address,
      string[] args)
    {
      base_responses baseResponses = (base_responses) null;
      if (ipv6address != null && ipv6address.Length > 0)
      {
        nsip6[] nsip6Array = new nsip6[ipv6address.Length];
        for (int index = 0; index < ipv6address.Length; ++index)
        {
          nsip6Array[index] = new nsip6();
          nsip6Array[index].ipv6address = ipv6address[index];
        }
        baseResponses = base_resource.unset_bulk_request(client, (base_resource[]) nsip6Array, args);
      }
      return baseResponses;
    }

    public static base_responses unset(
      nitro_service client,
      nsip6[] resources,
      string[] args)
    {
      base_responses baseResponses = (base_responses) null;
      if (resources != null && resources.Length > 0)
      {
        nsip6[] nsip6Array = new nsip6[resources.Length];
        for (int index = 0; index < resources.Length; ++index)
        {
          nsip6Array[index] = new nsip6();
          nsip6Array[index].ipv6address = resources[index].ipv6address;
          nsip6Array[index].td = resources[index].td;
        }
        baseResponses = base_resource.unset_bulk_request(client, (base_resource[]) nsip6Array, args);
      }
      return baseResponses;
    }

    public static nsip6[] get(nitro_service service) => (nsip6[]) new nsip6().get_resources(service, (options) null);

    public static nsip6[] get(nitro_service service, options option) => (nsip6[]) new nsip6().get_resources(service, option);

    public static nsip6 get(nitro_service service, nsip6 obj)
    {
      options option = new options();
      option.set_args(nitro_util.object_to_string_withoutquotes((object) obj));
      return (nsip6) obj.get_resource(service, option);
    }

    public static nsip6[] get(nitro_service service, nsip6[] obj)
    {
      if (obj == null || obj.Length <= 0)
        return (nsip6[]) null;
      nsip6[] nsip6Array = new nsip6[obj.Length];
      for (int index = 0; index < obj.Length; ++index)
      {
        options option = new options();
        option.set_args(nitro_util.object_to_string_withoutquotes((object) obj[index]));
        nsip6Array[index] = (nsip6) obj[index].get_resource(service, option);
      }
      return nsip6Array;
    }

    public static nsip6[] get_filtered(nitro_service service, string filter)
    {
      nsip6 nsip6 = new nsip6();
      options option = new options();
      option.set_filter(filter);
      return (nsip6[]) nsip6.getfiltered(service, option);
    }

    public static nsip6[] get_filtered(nitro_service service, filtervalue[] filter)
    {
      nsip6 nsip6 = new nsip6();
      options option = new options();
      option.set_filter(filter);
      return (nsip6[]) nsip6.getfiltered(service, option);
    }

    public static uint count(nitro_service service)
    {
      nsip6 nsip6 = new nsip6();
      options option = new options();
      option.set_count(true);
      nsip6[] resources = (nsip6[]) nsip6.get_resources(service, option);
      return resources != null && resources.Length > 0 ? resources[0].__count.Value : 0U;
    }

    public static uint count_filtered(nitro_service service, string filter)
    {
      nsip6 nsip6 = new nsip6();
      options option = new options();
      option.set_count(true);
      option.set_filter(filter);
      nsip6[] nsip6Array = (nsip6[]) nsip6.getfiltered(service, option);
      return nsip6Array != null && nsip6Array.Length > 0 ? nsip6Array[0].__count.Value : 0U;
    }

    public static uint count_filtered(nitro_service service, filtervalue[] filter)
    {
      nsip6 nsip6 = new nsip6();
      options option = new options();
      option.set_count(true);
      option.set_filter(filter);
      nsip6[] nsip6Array = (nsip6[]) nsip6.getfiltered(service, option);
      return nsip6Array != null && nsip6Array.Length > 0 ? nsip6Array[0].__count.Value : 0U;
    }

    private class nsip6_response : base_response
    {
      public nsip6[] nsip6 = (nsip6[]) null;
    }

    public static class iptypeEnum
    {
      public const string NSIP = "NSIP";
      public const string VIP = "VIP";
      public const string SNIP = "SNIP";
      public const string GSLBsiteIP = "GSLBsiteIP";
      public const string ADNSsvcIP = "ADNSsvcIP";
      public const string RADIUSListenersvcIP = "RADIUSListenersvcIP";
      public const string CLIP = "CLIP";
    }

    public static class sshEnum
    {
      public const string ENABLED = "ENABLED";
      public const string DISABLED = "DISABLED";
    }

    public static class stateEnum
    {
      public const string DISABLED = "DISABLED";
      public const string ENABLED = "ENABLED";
    }

    public static class ospf6lsatypeEnum
    {
      public const string INTRA_AREA = "INTRA_AREA";
      public const string EXTERNAL = "EXTERNAL";
    }

    public static class scopeEnum
    {
      public const string global = "global";
      public const string link_local = "link-local";
    }

    public static class ndEnum
    {
      public const string ENABLED = "ENABLED";
      public const string DISABLED = "DISABLED";
    }

    public static class systemtypeEnum
    {
      public const string Stand_alone = "Stand-alone";
      public const string HA = "HA";
      public const string Cluster = "Cluster";
    }

    public static class guiEnum
    {
      public const string ENABLED = "ENABLED";
      public const string SECUREONLY = "SECUREONLY";
      public const string DISABLED = "DISABLED";
    }

    public static class dynamicroutingEnum
    {
      public const string ENABLED = "ENABLED";
      public const string DISABLED = "DISABLED";
    }

    public static class typeEnum
    {
      public const string NSIP = "NSIP";
      public const string VIP = "VIP";
      public const string SNIP = "SNIP";
      public const string GSLBsiteIP = "GSLBsiteIP";
      public const string ADNSsvcIP = "ADNSsvcIP";
      public const string RADIUSListenersvcIP = "RADIUSListenersvcIP";
      public const string CLIP = "CLIP";
    }

    public static class mgmtaccessEnum
    {
      public const string ENABLED = "ENABLED";
      public const string DISABLED = "DISABLED";
    }

    public static class hostrouteEnum
    {
      public const string ENABLED = "ENABLED";
      public const string DISABLED = "DISABLED";
    }

    public static class ftpEnum
    {
      public const string ENABLED = "ENABLED";
      public const string DISABLED = "DISABLED";
    }

    public static class vserverrhilevelEnum
    {
      public const string ONE_VSERVER = "ONE_VSERVER";
      public const string ALL_VSERVERS = "ALL_VSERVERS";
      public const string NONE = "NONE";
      public const string VSVR_CNTRLD = "VSVR_CNTRLD";
    }

    public static class icmpEnum
    {
      public const string ENABLED = "ENABLED";
      public const string DISABLED = "DISABLED";
    }

    public static class vserverEnum
    {
      public const string ENABLED = "ENABLED";
      public const string DISABLED = "DISABLED";
    }

    public static class snmpEnum
    {
      public const string ENABLED = "ENABLED";
      public const string DISABLED = "DISABLED";
    }

    public static class curstateEnum
    {
      public const string DISABLED = "DISABLED";
      public const string ENABLED = "ENABLED";
    }

    public static class restrictaccessEnum
    {
      public const string ENABLED = "ENABLED";
      public const string DISABLED = "DISABLED";
    }

    public static class telnetEnum
    {
      public const string ENABLED = "ENABLED";
      public const string DISABLED = "DISABLED";
    }
  }
}
