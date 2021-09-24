// Decompiled with JetBrains decompiler
// Type: com.citrix.netscaler.nitro.resource.config.network.iptunnel
// Assembly: nitro, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 6CF5DDEF-E052-4F9D-953F-6644F8378A66


using com.citrix.netscaler.nitro.exception;
using com.citrix.netscaler.nitro.resource.Base;
using com.citrix.netscaler.nitro.service;
using com.citrix.netscaler.nitro.util;

namespace com.citrix.netscaler.nitro.resource.config.network
{
  public class iptunnel : base_resource
  {
    private string nameField = (string) null;
    private string remoteField = (string) null;
    private string remotesubnetmaskField = (string) null;
    private string localField = (string) null;
    private string protocolField = (string) null;
    private string grepayloadField = (string) null;
    private string ipsecprofilenameField = (string) null;
    private uint? vlanField = new uint?();
    private string ownergroupField = (string) null;
    private string sysnameField = (string) null;
    private uint? typeField = new uint?();
    private string encapipField = (string) null;
    private uint? channelField = new uint?();
    private string[] tunneltypeField = (string[]) null;
    private string ipsectunnelstatusField = (string) null;
    private string pbrnameField = (string) null;
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

    public string remote
    {
      get => this.remoteField;
      set => this.remoteField = value;
    }

    public string remotesubnetmask
    {
      get => this.remotesubnetmaskField;
      set => this.remotesubnetmaskField = value;
    }

    public string local
    {
      get => this.localField;
      set => this.localField = value;
    }

    public string protocol
    {
      get => this.protocolField;
      set => this.protocolField = value;
    }

    public string grepayload
    {
      get => this.grepayloadField;
      set => this.grepayloadField = value;
    }

    public string ipsecprofilename
    {
      get => this.ipsecprofilenameField;
      set => this.ipsecprofilenameField = value;
    }

    public uint? vlan
    {
      get => this.vlanField;
      set => this.vlanField = value;
    }

    public string ownergroup
    {
      get => this.ownergroupField;
      set => this.ownergroupField = value;
    }

    public string sysname
    {
      get => this.sysnameField;
      private set => this.sysnameField = value;
    }

    public uint? type
    {
      get => this.typeField;
      private set => this.typeField = value;
    }

    public string encapip
    {
      get => this.encapipField;
      private set => this.encapipField = value;
    }

    public uint? channel
    {
      get => this.channelField;
      private set => this.channelField = value;
    }

    public string[] tunneltype
    {
      get => this.tunneltypeField;
      private set => this.tunneltypeField = value;
    }

    public string ipsectunnelstatus
    {
      get => this.ipsectunnelstatusField;
      private set => this.ipsectunnelstatusField = value;
    }

    public string pbrname
    {
      get => this.pbrnameField;
      private set => this.pbrnameField = value;
    }

    internal override base_resource[] get_nitro_response(
      nitro_service service,
      string response)
    {
      iptunnel.iptunnel_response iptunnelResponse = new iptunnel.iptunnel_response();
      iptunnel.iptunnel_response resource = (iptunnel.iptunnel_response) service.get_payload_formatter().string_to_resource(iptunnelResponse.GetType(), response);
      if (resource.errorcode != 0)
      {
        if (resource.errorcode == 444)
          service.clear_session();
        if (resource.severity == null)
          throw new nitro_exception(resource.message, resource.errorcode);
        if (resource.severity.Equals("ERROR"))
          throw new nitro_exception(resource.message, resource.errorcode);
      }
      return (base_resource[]) resource.iptunnel;
    }

    internal override string get_object_name() => this.name;

    public static base_response add(nitro_service client, iptunnel resource) => new iptunnel()
    {
      name = resource.name,
      remote = resource.remote,
      remotesubnetmask = resource.remotesubnetmask,
      local = resource.local,
      protocol = resource.protocol,
      grepayload = resource.grepayload,
      ipsecprofilename = resource.ipsecprofilename,
      vlan = resource.vlan,
      ownergroup = resource.ownergroup
    }.add_resource(client);

    public static base_responses add(nitro_service client, iptunnel[] resources)
    {
      base_responses baseResponses = (base_responses) null;
      if (resources != null && resources.Length > 0)
      {
        iptunnel[] iptunnelArray = new iptunnel[resources.Length];
        for (int index = 0; index < resources.Length; ++index)
        {
          iptunnelArray[index] = new iptunnel();
          iptunnelArray[index].name = resources[index].name;
          iptunnelArray[index].remote = resources[index].remote;
          iptunnelArray[index].remotesubnetmask = resources[index].remotesubnetmask;
          iptunnelArray[index].local = resources[index].local;
          iptunnelArray[index].protocol = resources[index].protocol;
          iptunnelArray[index].grepayload = resources[index].grepayload;
          iptunnelArray[index].ipsecprofilename = resources[index].ipsecprofilename;
          iptunnelArray[index].vlan = resources[index].vlan;
          iptunnelArray[index].ownergroup = resources[index].ownergroup;
        }
        baseResponses = base_resource.add_bulk_request(client, (base_resource[]) iptunnelArray);
      }
      return baseResponses;
    }

    public static base_response delete(nitro_service client, string name) => new iptunnel()
    {
      name = name
    }.delete_resource(client);

    public static base_response delete(nitro_service client, iptunnel resource) => new iptunnel()
    {
      name = resource.name
    }.delete_resource(client);

    public static base_responses delete(nitro_service client, string[] name)
    {
      base_responses baseResponses = (base_responses) null;
      if (name != null && name.Length > 0)
      {
        iptunnel[] iptunnelArray = new iptunnel[name.Length];
        for (int index = 0; index < name.Length; ++index)
        {
          iptunnelArray[index] = new iptunnel();
          iptunnelArray[index].name = name[index];
        }
        baseResponses = base_resource.delete_bulk_request(client, (base_resource[]) iptunnelArray);
      }
      return baseResponses;
    }

    public static base_responses delete(nitro_service client, iptunnel[] resources)
    {
      base_responses baseResponses = (base_responses) null;
      if (resources != null && resources.Length > 0)
      {
        iptunnel[] iptunnelArray = new iptunnel[resources.Length];
        for (int index = 0; index < resources.Length; ++index)
        {
          iptunnelArray[index] = new iptunnel();
          iptunnelArray[index].name = resources[index].name;
        }
        baseResponses = base_resource.delete_bulk_request(client, (base_resource[]) iptunnelArray);
      }
      return baseResponses;
    }

    public static iptunnel[] get(nitro_service service) => (iptunnel[]) new iptunnel().get_resources(service, (options) null);

    public static iptunnel[] get(nitro_service service, options option) => (iptunnel[]) new iptunnel().get_resources(service, option);

    public static iptunnel[] get(nitro_service service, iptunnel_args args)
    {
      iptunnel iptunnel = new iptunnel();
      options option = new options();
      option.set_args(nitro_util.object_to_string_withoutquotes((object) args));
      return (iptunnel[]) iptunnel.get_resources(service, option);
    }

    public static iptunnel get(nitro_service service, string name) => (iptunnel) new iptunnel()
    {
      name = name
    }.get_resource(service);

    public static iptunnel[] get(nitro_service service, string[] name)
    {
      if (name == null || name.Length <= 0)
        return (iptunnel[]) null;
      iptunnel[] iptunnelArray1 = new iptunnel[name.Length];
      iptunnel[] iptunnelArray2 = new iptunnel[name.Length];
      for (int index = 0; index < name.Length; ++index)
      {
        iptunnelArray2[index] = new iptunnel();
        iptunnelArray2[index].name = name[index];
        iptunnelArray1[index] = (iptunnel) iptunnelArray2[index].get_resource(service);
      }
      return iptunnelArray1;
    }

    public static iptunnel[] get_filtered(nitro_service service, string filter)
    {
      iptunnel iptunnel = new iptunnel();
      options option = new options();
      option.set_filter(filter);
      return (iptunnel[]) iptunnel.getfiltered(service, option);
    }

    public static iptunnel[] get_filtered(nitro_service service, filtervalue[] filter)
    {
      iptunnel iptunnel = new iptunnel();
      options option = new options();
      option.set_filter(filter);
      return (iptunnel[]) iptunnel.getfiltered(service, option);
    }

    public static uint count(nitro_service service)
    {
      iptunnel iptunnel = new iptunnel();
      options option = new options();
      option.set_count(true);
      iptunnel[] resources = (iptunnel[]) iptunnel.get_resources(service, option);
      return resources != null && resources.Length > 0 ? resources[0].__count.Value : 0U;
    }

    public static uint count_filtered(nitro_service service, string filter)
    {
      iptunnel iptunnel = new iptunnel();
      options option = new options();
      option.set_count(true);
      option.set_filter(filter);
      iptunnel[] iptunnelArray = (iptunnel[]) iptunnel.getfiltered(service, option);
      return iptunnelArray != null && iptunnelArray.Length > 0 ? iptunnelArray[0].__count.Value : 0U;
    }

    public static uint count_filtered(nitro_service service, filtervalue[] filter)
    {
      iptunnel iptunnel = new iptunnel();
      options option = new options();
      option.set_count(true);
      option.set_filter(filter);
      iptunnel[] iptunnelArray = (iptunnel[]) iptunnel.getfiltered(service, option);
      return iptunnelArray != null && iptunnelArray.Length > 0 ? iptunnelArray[0].__count.Value : 0U;
    }

    private class iptunnel_response : base_response
    {
      public iptunnel[] iptunnel = (iptunnel[]) null;
    }

    public static class protocolEnum
    {
      public const string IPIP = "IPIP";
      public const string GRE = "GRE";
      public const string IPSEC = "IPSEC";
      public const string VXLAN = "VXLAN";
    }

    public static class tunneltypeEnum
    {
      public const string Configured = "Configured";
      public const string Delete_In_Progress = "Delete-In-Progress";
    }

    public static class ipsectunnelstatusEnum
    {
      public const string DOWN = "DOWN";
      public const string UP = "UP";
      public const string PARTIAL_UP = "PARTIAL-UP";
      public const string UNKNOWN = "UNKNOWN";
    }

    public static class grepayloadEnum
    {
      public const string ETHERNETwithDOT1Q = "ETHERNETwithDOT1Q";
      public const string ETHERNET = "ETHERNET";
      public const string IP = "IP";
    }
  }
}
