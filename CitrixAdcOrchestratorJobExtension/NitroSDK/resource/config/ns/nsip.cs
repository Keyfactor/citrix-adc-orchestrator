// Decompiled with JetBrains decompiler
// Type: com.citrix.netscaler.nitro.resource.config.ns.nsip
// Assembly: nitro, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 6CF5DDEF-E052-4F9D-953F-6644F8378A66


using com.citrix.netscaler.nitro.exception;
using com.citrix.netscaler.nitro.resource.Base;
using com.citrix.netscaler.nitro.service;
using com.citrix.netscaler.nitro.util;

namespace com.citrix.netscaler.nitro.resource.config.ns
{
  public class nsip : base_resource
  {
    private string ipaddressField = (string) null;
    private string netmaskField = (string) null;
    private string typeField = (string) null;
    private string arpField = (string) null;
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
    private string ospfField = (string) null;
    private string bgpField = (string) null;
    private string ripField = (string) null;
    private string hostrouteField = (string) null;
    private string hostrtgwField = (string) null;
    private int? metricField = new int?();
    private string vserverrhilevelField = (string) null;
    private string vserverrhimodeField = (string) null;
    private string ospflsatypeField = (string) null;
    private uint? ospfareaField = new uint?();
    private string stateField = (string) null;
    private uint? vridField = new uint?();
    private string icmpresponseField = (string) null;
    private uint? ownernodeField = new uint?();
    private string arpresponseField = (string) null;
    private uint? tdField = new uint?();
    private uint? flagsField = new uint?();
    private string hostrtgwactField = (string) null;
    private uint? ospfareavalField = new uint?();
    private bool? viprtadv2bsdField = new bool?();
    private uint? vipvsercountField = new uint?();
    private uint? vipvserdowncountField = new uint?();
    private uint? vipvsrvrrhiactivecountField = new uint?();
    private uint? vipvsrvrrhiactiveupcountField = new uint?();
    private uint? freeportsField = new uint?();
    private int? riserhimsgcodeField = new int?();
    private string[] iptypeField = (string[]) null;
    private uint? __countField = new uint?();

    public uint? __count
    {
      get => this.__countField;
      private set => this.__countField = value;
    }

    public string ipaddress
    {
      get => this.ipaddressField;
      set => this.ipaddressField = value;
    }

    public string netmask
    {
      get => this.netmaskField;
      set => this.netmaskField = value;
    }

    public string type
    {
      get => this.typeField;
      set => this.typeField = value;
    }

    public string arp
    {
      get => this.arpField;
      set => this.arpField = value;
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

    public string ospf
    {
      get => this.ospfField;
      set => this.ospfField = value;
    }

    public string bgp
    {
      get => this.bgpField;
      set => this.bgpField = value;
    }

    public string rip
    {
      get => this.ripField;
      set => this.ripField = value;
    }

    public string hostroute
    {
      get => this.hostrouteField;
      set => this.hostrouteField = value;
    }

    public string hostrtgw
    {
      get => this.hostrtgwField;
      set => this.hostrtgwField = value;
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

    public string vserverrhimode
    {
      get => this.vserverrhimodeField;
      set => this.vserverrhimodeField = value;
    }

    public string ospflsatype
    {
      get => this.ospflsatypeField;
      set => this.ospflsatypeField = value;
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

    public uint? vrid
    {
      get => this.vridField;
      set => this.vridField = value;
    }

    public string icmpresponse
    {
      get => this.icmpresponseField;
      set => this.icmpresponseField = value;
    }

    public uint? ownernode
    {
      get => this.ownernodeField;
      set => this.ownernodeField = value;
    }

    public string arpresponse
    {
      get => this.arpresponseField;
      set => this.arpresponseField = value;
    }

    public uint? td
    {
      get => this.tdField;
      set => this.tdField = value;
    }

    public uint? flags
    {
      get => this.flagsField;
      private set => this.flagsField = value;
    }

    public string hostrtgwact
    {
      get => this.hostrtgwactField;
      private set => this.hostrtgwactField = value;
    }

    public uint? ospfareaval
    {
      get => this.ospfareavalField;
      private set => this.ospfareavalField = value;
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

    public uint? vipvsrvrrhiactivecount
    {
      get => this.vipvsrvrrhiactivecountField;
      private set => this.vipvsrvrrhiactivecountField = value;
    }

    public uint? vipvsrvrrhiactiveupcount
    {
      get => this.vipvsrvrrhiactiveupcountField;
      private set => this.vipvsrvrrhiactiveupcountField = value;
    }

    public uint? freeports
    {
      get => this.freeportsField;
      private set => this.freeportsField = value;
    }

    public int? riserhimsgcode
    {
      get => this.riserhimsgcodeField;
      private set => this.riserhimsgcodeField = value;
    }

    public string[] iptype
    {
      get => this.iptypeField;
      private set => this.iptypeField = value;
    }

    internal override base_resource[] get_nitro_response(
      nitro_service service,
      string response)
    {
      nsip.nsip_response nsipResponse = new nsip.nsip_response();
      nsip.nsip_response resource = (nsip.nsip_response) service.get_payload_formatter().string_to_resource(nsipResponse.GetType(), response);
      if (resource.errorcode != 0)
      {
        if (resource.errorcode == 444)
          service.clear_session();
        if (resource.severity == null)
          throw new nitro_exception(resource.message, resource.errorcode);
        if (resource.severity.Equals("ERROR"))
          throw new nitro_exception(resource.message, resource.errorcode);
      }
      return (base_resource[]) resource.nsip;
    }

    internal override string get_object_name() => this.ipaddress;

    public static base_response add(nitro_service client, nsip resource) => new nsip()
    {
      ipaddress = resource.ipaddress,
      netmask = resource.netmask,
      type = resource.type,
      arp = resource.arp,
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
      ospf = resource.ospf,
      bgp = resource.bgp,
      rip = resource.rip,
      hostroute = resource.hostroute,
      hostrtgw = resource.hostrtgw,
      metric = resource.metric,
      vserverrhilevel = resource.vserverrhilevel,
      vserverrhimode = resource.vserverrhimode,
      ospflsatype = resource.ospflsatype,
      ospfarea = resource.ospfarea,
      state = resource.state,
      vrid = resource.vrid,
      icmpresponse = resource.icmpresponse,
      ownernode = resource.ownernode,
      arpresponse = resource.arpresponse,
      td = resource.td
    }.add_resource(client);

    public static base_responses add(nitro_service client, nsip[] resources)
    {
      base_responses baseResponses = (base_responses) null;
      if (resources != null && resources.Length > 0)
      {
        nsip[] nsipArray = new nsip[resources.Length];
        for (int index = 0; index < resources.Length; ++index)
        {
          nsipArray[index] = new nsip();
          nsipArray[index].ipaddress = resources[index].ipaddress;
          nsipArray[index].netmask = resources[index].netmask;
          nsipArray[index].type = resources[index].type;
          nsipArray[index].arp = resources[index].arp;
          nsipArray[index].icmp = resources[index].icmp;
          nsipArray[index].vserver = resources[index].vserver;
          nsipArray[index].telnet = resources[index].telnet;
          nsipArray[index].ftp = resources[index].ftp;
          nsipArray[index].gui = resources[index].gui;
          nsipArray[index].ssh = resources[index].ssh;
          nsipArray[index].snmp = resources[index].snmp;
          nsipArray[index].mgmtaccess = resources[index].mgmtaccess;
          nsipArray[index].restrictaccess = resources[index].restrictaccess;
          nsipArray[index].dynamicrouting = resources[index].dynamicrouting;
          nsipArray[index].ospf = resources[index].ospf;
          nsipArray[index].bgp = resources[index].bgp;
          nsipArray[index].rip = resources[index].rip;
          nsipArray[index].hostroute = resources[index].hostroute;
          nsipArray[index].hostrtgw = resources[index].hostrtgw;
          nsipArray[index].metric = resources[index].metric;
          nsipArray[index].vserverrhilevel = resources[index].vserverrhilevel;
          nsipArray[index].vserverrhimode = resources[index].vserverrhimode;
          nsipArray[index].ospflsatype = resources[index].ospflsatype;
          nsipArray[index].ospfarea = resources[index].ospfarea;
          nsipArray[index].state = resources[index].state;
          nsipArray[index].vrid = resources[index].vrid;
          nsipArray[index].icmpresponse = resources[index].icmpresponse;
          nsipArray[index].ownernode = resources[index].ownernode;
          nsipArray[index].arpresponse = resources[index].arpresponse;
          nsipArray[index].td = resources[index].td;
        }
        baseResponses = base_resource.add_bulk_request(client, (base_resource[]) nsipArray);
      }
      return baseResponses;
    }

    public static base_response delete(nitro_service client, string ipaddress) => new nsip()
    {
      ipaddress = ipaddress
    }.delete_resource(client);

    public static base_response delete(nitro_service client, nsip resource) => new nsip()
    {
      ipaddress = resource.ipaddress,
      td = resource.td
    }.delete_resource(client);

    public static base_responses delete(nitro_service client, string[] ipaddress)
    {
      base_responses baseResponses = (base_responses) null;
      if (ipaddress != null && ipaddress.Length > 0)
      {
        nsip[] nsipArray = new nsip[ipaddress.Length];
        for (int index = 0; index < ipaddress.Length; ++index)
        {
          nsipArray[index] = new nsip();
          nsipArray[index].ipaddress = ipaddress[index];
        }
        baseResponses = base_resource.delete_bulk_request(client, (base_resource[]) nsipArray);
      }
      return baseResponses;
    }

    public static base_responses delete(nitro_service client, nsip[] resources)
    {
      base_responses baseResponses = (base_responses) null;
      if (resources != null && resources.Length > 0)
      {
        nsip[] nsipArray = new nsip[resources.Length];
        for (int index = 0; index < resources.Length; ++index)
        {
          nsipArray[index] = new nsip();
          nsipArray[index].ipaddress = resources[index].ipaddress;
          nsipArray[index].td = resources[index].td;
        }
        baseResponses = base_resource.delete_bulk_request(client, (base_resource[]) nsipArray);
      }
      return baseResponses;
    }

    public static base_response update(nitro_service client, nsip resource) => new nsip()
    {
      ipaddress = resource.ipaddress,
      td = resource.td,
      netmask = resource.netmask,
      arp = resource.arp,
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
      ospf = resource.ospf,
      bgp = resource.bgp,
      rip = resource.rip,
      hostroute = resource.hostroute,
      hostrtgw = resource.hostrtgw,
      metric = resource.metric,
      vserverrhilevel = resource.vserverrhilevel,
      vserverrhimode = resource.vserverrhimode,
      ospflsatype = resource.ospflsatype,
      ospfarea = resource.ospfarea,
      vrid = resource.vrid,
      icmpresponse = resource.icmpresponse,
      arpresponse = resource.arpresponse
    }.update_resource(client);

    public static base_responses update(nitro_service client, nsip[] resources)
    {
      base_responses baseResponses = (base_responses) null;
      if (resources != null && resources.Length > 0)
      {
        nsip[] nsipArray = new nsip[resources.Length];
        for (int index = 0; index < resources.Length; ++index)
        {
          nsipArray[index] = new nsip();
          nsipArray[index].ipaddress = resources[index].ipaddress;
          nsipArray[index].td = resources[index].td;
          nsipArray[index].netmask = resources[index].netmask;
          nsipArray[index].arp = resources[index].arp;
          nsipArray[index].icmp = resources[index].icmp;
          nsipArray[index].vserver = resources[index].vserver;
          nsipArray[index].telnet = resources[index].telnet;
          nsipArray[index].ftp = resources[index].ftp;
          nsipArray[index].gui = resources[index].gui;
          nsipArray[index].ssh = resources[index].ssh;
          nsipArray[index].snmp = resources[index].snmp;
          nsipArray[index].mgmtaccess = resources[index].mgmtaccess;
          nsipArray[index].restrictaccess = resources[index].restrictaccess;
          nsipArray[index].dynamicrouting = resources[index].dynamicrouting;
          nsipArray[index].ospf = resources[index].ospf;
          nsipArray[index].bgp = resources[index].bgp;
          nsipArray[index].rip = resources[index].rip;
          nsipArray[index].hostroute = resources[index].hostroute;
          nsipArray[index].hostrtgw = resources[index].hostrtgw;
          nsipArray[index].metric = resources[index].metric;
          nsipArray[index].vserverrhilevel = resources[index].vserverrhilevel;
          nsipArray[index].vserverrhimode = resources[index].vserverrhimode;
          nsipArray[index].ospflsatype = resources[index].ospflsatype;
          nsipArray[index].ospfarea = resources[index].ospfarea;
          nsipArray[index].vrid = resources[index].vrid;
          nsipArray[index].icmpresponse = resources[index].icmpresponse;
          nsipArray[index].arpresponse = resources[index].arpresponse;
        }
        baseResponses = base_resource.update_bulk_request(client, (base_resource[]) nsipArray);
      }
      return baseResponses;
    }

    public static base_response unset(
      nitro_service client,
      string ipaddress,
      string[] args)
    {
      return new nsip() { ipaddress = ipaddress }.unset_resource(client, args);
    }

    public static base_response unset(
      nitro_service client,
      nsip resource,
      string[] args)
    {
      return new nsip()
      {
        ipaddress = resource.ipaddress,
        td = resource.td
      }.unset_resource(client, args);
    }

    public static base_responses unset(
      nitro_service client,
      string[] ipaddress,
      string[] args)
    {
      base_responses baseResponses = (base_responses) null;
      if (ipaddress != null && ipaddress.Length > 0)
      {
        nsip[] nsipArray = new nsip[ipaddress.Length];
        for (int index = 0; index < ipaddress.Length; ++index)
        {
          nsipArray[index] = new nsip();
          nsipArray[index].ipaddress = ipaddress[index];
        }
        baseResponses = base_resource.unset_bulk_request(client, (base_resource[]) nsipArray, args);
      }
      return baseResponses;
    }

    public static base_responses unset(
      nitro_service client,
      nsip[] resources,
      string[] args)
    {
      base_responses baseResponses = (base_responses) null;
      if (resources != null && resources.Length > 0)
      {
        nsip[] nsipArray = new nsip[resources.Length];
        for (int index = 0; index < resources.Length; ++index)
        {
          nsipArray[index] = new nsip();
          nsipArray[index].ipaddress = resources[index].ipaddress;
          nsipArray[index].td = resources[index].td;
        }
        baseResponses = base_resource.unset_bulk_request(client, (base_resource[]) nsipArray, args);
      }
      return baseResponses;
    }

    public static base_response enable(nitro_service client, string ipaddress) => new nsip()
    {
      ipaddress = ipaddress
    }.perform_operation_byaction(client, nameof (enable));

    public static base_response enable(nitro_service client, nsip resource) => new nsip()
    {
      ipaddress = resource.ipaddress,
      td = resource.td
    }.perform_operation_byaction(client, nameof (enable));

    public static base_responses enable(nitro_service client, string[] ipaddress)
    {
      base_responses baseResponses = (base_responses) null;
      if (ipaddress != null && ipaddress.Length > 0)
      {
        nsip[] nsipArray = new nsip[ipaddress.Length];
        for (int index = 0; index < ipaddress.Length; ++index)
        {
          nsipArray[index] = new nsip();
          nsipArray[index].ipaddress = ipaddress[index];
        }
        baseResponses = base_resource.perform_operation_bulk_request(client, (base_resource[]) nsipArray, nameof (enable));
      }
      return baseResponses;
    }

    public static base_responses enable(nitro_service client, nsip[] resources)
    {
      base_responses baseResponses = (base_responses) null;
      if (resources != null && resources.Length > 0)
      {
        nsip[] nsipArray = new nsip[resources.Length];
        for (int index = 0; index < resources.Length; ++index)
        {
          nsipArray[index] = new nsip();
          nsipArray[index].ipaddress = resources[index].ipaddress;
          nsipArray[index].td = resources[index].td;
        }
        baseResponses = base_resource.perform_operation_bulk_request(client, (base_resource[]) nsipArray, nameof (enable));
      }
      return baseResponses;
    }

    public static base_response disable(nitro_service client, string ipaddress) => new nsip()
    {
      ipaddress = ipaddress
    }.perform_operation_byaction(client, nameof (disable));

    public static base_response disable(nitro_service client, nsip resource) => new nsip()
    {
      ipaddress = resource.ipaddress,
      td = resource.td
    }.perform_operation_byaction(client, nameof (disable));

    public static base_responses disable(nitro_service client, string[] ipaddress)
    {
      base_responses baseResponses = (base_responses) null;
      if (ipaddress != null && ipaddress.Length > 0)
      {
        nsip[] nsipArray = new nsip[ipaddress.Length];
        for (int index = 0; index < ipaddress.Length; ++index)
        {
          nsipArray[index] = new nsip();
          nsipArray[index].ipaddress = ipaddress[index];
        }
        baseResponses = base_resource.perform_operation_bulk_request(client, (base_resource[]) nsipArray, nameof (disable));
      }
      return baseResponses;
    }

    public static base_responses disable(nitro_service client, nsip[] resources)
    {
      base_responses baseResponses = (base_responses) null;
      if (resources != null && resources.Length > 0)
      {
        nsip[] nsipArray = new nsip[resources.Length];
        for (int index = 0; index < resources.Length; ++index)
        {
          nsipArray[index] = new nsip();
          nsipArray[index].ipaddress = resources[index].ipaddress;
          nsipArray[index].td = resources[index].td;
        }
        baseResponses = base_resource.perform_operation_bulk_request(client, (base_resource[]) nsipArray, nameof (disable));
      }
      return baseResponses;
    }

    public static nsip[] get(nitro_service service) => (nsip[]) new nsip().get_resources(service, (options) null);

    public static nsip[] get(nitro_service service, options option) => (nsip[]) new nsip().get_resources(service, option);

    public static nsip get(nitro_service service, nsip obj)
    {
      options option = new options();
      option.set_args(nitro_util.object_to_string_withoutquotes((object) obj));
      return (nsip) obj.get_resource(service, option);
    }

    public static nsip[] get(nitro_service service, nsip[] obj)
    {
      if (obj == null || obj.Length <= 0)
        return (nsip[]) null;
      nsip[] nsipArray = new nsip[obj.Length];
      for (int index = 0; index < obj.Length; ++index)
      {
        options option = new options();
        option.set_args(nitro_util.object_to_string_withoutquotes((object) obj[index]));
        nsipArray[index] = (nsip) obj[index].get_resource(service, option);
      }
      return nsipArray;
    }

    public static nsip[] get(nitro_service service, nsip_args args)
    {
      nsip nsip = new nsip();
      options option = new options();
      option.set_args(nitro_util.object_to_string_withoutquotes((object) args));
      return (nsip[]) nsip.get_resources(service, option);
    }

    public static nsip[] get_filtered(nitro_service service, string filter)
    {
      nsip nsip = new nsip();
      options option = new options();
      option.set_filter(filter);
      return (nsip[]) nsip.getfiltered(service, option);
    }

    public static nsip[] get_filtered(nitro_service service, filtervalue[] filter)
    {
      nsip nsip = new nsip();
      options option = new options();
      option.set_filter(filter);
      return (nsip[]) nsip.getfiltered(service, option);
    }

    public static uint count(nitro_service service)
    {
      nsip nsip = new nsip();
      options option = new options();
      option.set_count(true);
      nsip[] resources = (nsip[]) nsip.get_resources(service, option);
      return resources != null && resources.Length > 0 ? resources[0].__count.Value : 0U;
    }

    public static uint count_filtered(nitro_service service, string filter)
    {
      nsip nsip = new nsip();
      options option = new options();
      option.set_count(true);
      option.set_filter(filter);
      nsip[] nsipArray = (nsip[]) nsip.getfiltered(service, option);
      return nsipArray != null && nsipArray.Length > 0 ? nsipArray[0].__count.Value : 0U;
    }

    public static uint count_filtered(nitro_service service, filtervalue[] filter)
    {
      nsip nsip = new nsip();
      options option = new options();
      option.set_count(true);
      option.set_filter(filter);
      nsip[] nsipArray = (nsip[]) nsip.getfiltered(service, option);
      return nsipArray != null && nsipArray.Length > 0 ? nsipArray[0].__count.Value : 0U;
    }

    private class nsip_response : base_response
    {
      public nsip[] nsip = (nsip[]) null;
    }

    public static class arpresponseEnum
    {
      public const string NONE = "NONE";
      public const string ONE_VSERVER = "ONE_VSERVER";
      public const string ALL_VSERVERS = "ALL_VSERVERS";
    }

    public static class iptypeEnum
    {
      public const string SNIP = "SNIP";
      public const string VIP = "VIP";
      public const string NSIP = "NSIP";
      public const string GSLBsiteIP = "GSLBsiteIP";
      public const string CLIP = "CLIP";
    }

    public static class sshEnum
    {
      public const string ENABLED = "ENABLED";
      public const string DISABLED = "DISABLED";
    }

    public static class stateEnum
    {
      public const string ENABLED = "ENABLED";
      public const string DISABLED = "DISABLED";
    }

    public static class ripEnum
    {
      public const string ENABLED = "ENABLED";
      public const string DISABLED = "DISABLED";
    }

    public static class guiEnum
    {
      public const string ENABLED = "ENABLED";
      public const string SECUREONLY = "SECUREONLY";
      public const string DISABLED = "DISABLED";
    }

    public static class ospfEnum
    {
      public const string ENABLED = "ENABLED";
      public const string DISABLED = "DISABLED";
    }

    public static class dynamicroutingEnum
    {
      public const string ENABLED = "ENABLED";
      public const string DISABLED = "DISABLED";
    }

    public static class typeEnum
    {
      public const string SNIP = "SNIP";
      public const string VIP = "VIP";
      public const string NSIP = "NSIP";
      public const string GSLBsiteIP = "GSLBsiteIP";
      public const string CLIP = "CLIP";
    }

    public static class ospflsatypeEnum
    {
      public const string TYPE1 = "TYPE1";
      public const string TYPE5 = "TYPE5";
    }

    public static class bgpEnum
    {
      public const string ENABLED = "ENABLED";
      public const string DISABLED = "DISABLED";
    }

    public static class arpEnum
    {
      public const string ENABLED = "ENABLED";
      public const string DISABLED = "DISABLED";
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

    public static class icmpresponseEnum
    {
      public const string NONE = "NONE";
      public const string ONE_VSERVER = "ONE_VSERVER";
      public const string ALL_VSERVERS = "ALL_VSERVERS";
      public const string VSVR_CNTRLD = "VSVR_CNTRLD";
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

    public static class restrictaccessEnum
    {
      public const string ENABLED = "ENABLED";
      public const string DISABLED = "DISABLED";
    }

    public static class vserverrhimodeEnum
    {
      public const string DYNAMIC_ROUTING = "DYNAMIC_ROUTING";
      public const string RISE = "RISE";
    }

    public static class telnetEnum
    {
      public const string ENABLED = "ENABLED";
      public const string DISABLED = "DISABLED";
    }
  }
}
