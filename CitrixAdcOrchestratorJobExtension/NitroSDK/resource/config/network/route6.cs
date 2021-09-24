// Decompiled with JetBrains decompiler
// Type: com.citrix.netscaler.nitro.resource.config.network.route6
// Assembly: nitro, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 6CF5DDEF-E052-4F9D-953F-6644F8378A66


using com.citrix.netscaler.nitro.exception;
using com.citrix.netscaler.nitro.resource.Base;
using com.citrix.netscaler.nitro.service;
using com.citrix.netscaler.nitro.util;

namespace com.citrix.netscaler.nitro.resource.config.network
{
  public class route6 : base_resource
  {
    private string networkField = (string) null;
    private string gatewayField = (string) null;
    private uint? vlanField = new uint?();
    private uint? vxlanField = new uint?();
    private uint? weightField = new uint?();
    private uint? distanceField = new uint?();
    private uint? costField = new uint?();
    private string advertiseField = (string) null;
    private string msrField = (string) null;
    private string monitorField = (string) null;
    private uint? tdField = new uint?();
    private string ownergroupField = (string) null;
    private string routetypeField = (string) null;
    private bool? detailField = new bool?();
    private string gatewaynameField = (string) null;
    private bool? typeField = new bool?();
    private bool? dynamicField = new bool?();
    private bool? dataField = new bool?();
    private bool? flagsField = new bool?();
    private uint? stateField = new uint?();
    private uint? totalprobesField = new uint?();
    private uint? totalfailedprobesField = new uint?();
    private uint? failedprobesField = new uint?();
    private int? monstatcodeField = new int?();
    private int? monstatparam1Field = new int?();
    private int? monstatparam2Field = new int?();
    private int? monstatparam3Field = new int?();
    private string data1Field = (string) null;
    private string[] routeownersField = (string[]) null;
    private int? retainField = new int?();
    private bool? StaticField = new bool?();
    private bool? permanentField = new bool?();
    private bool? connectedField = new bool?();
    private bool? ospfv3Field = new bool?();
    private bool? isisField = new bool?();
    private bool? activeField = new bool?();
    private bool? bgpField = new bool?();
    private bool? ripField = new bool?();
    private bool? rarouteField = new bool?();
    private uint? __countField = new uint?();

    public uint? __count
    {
      get => this.__countField;
      private set => this.__countField = value;
    }

    public string network
    {
      get => this.networkField;
      set => this.networkField = value;
    }

    public string gateway
    {
      get => this.gatewayField;
      set => this.gatewayField = value;
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

    public uint? weight
    {
      get => this.weightField;
      set => this.weightField = value;
    }

    public uint? distance
    {
      get => this.distanceField;
      set => this.distanceField = value;
    }

    public uint? cost
    {
      get => this.costField;
      set => this.costField = value;
    }

    public string advertise
    {
      get => this.advertiseField;
      set => this.advertiseField = value;
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

    public uint? td
    {
      get => this.tdField;
      set => this.tdField = value;
    }

    public string ownergroup
    {
      get => this.ownergroupField;
      set => this.ownergroupField = value;
    }

    public string routetype
    {
      get => this.routetypeField;
      set => this.routetypeField = value;
    }

    public bool? detail
    {
      get => this.detailField;
      set => this.detailField = value;
    }

    public string gatewayname
    {
      get => this.gatewaynameField;
      private set => this.gatewaynameField = value;
    }

    public bool? type
    {
      get => this.typeField;
      private set => this.typeField = value;
    }

    public bool? dynamic
    {
      get => this.dynamicField;
      private set => this.dynamicField = value;
    }

    public bool? data
    {
      get => this.dataField;
      private set => this.dataField = value;
    }

    public bool? flags
    {
      get => this.flagsField;
      private set => this.flagsField = value;
    }

    public uint? state
    {
      get => this.stateField;
      private set => this.stateField = value;
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

    public string data1
    {
      get => this.data1Field;
      private set => this.data1Field = value;
    }

    public string[] routeowners
    {
      get => this.routeownersField;
      private set => this.routeownersField = value;
    }

    public int? retain
    {
      get => this.retainField;
      private set => this.retainField = value;
    }

    public bool? Static
    {
      get => this.StaticField;
      private set => this.StaticField = value;
    }

    public bool? permanent
    {
      get => this.permanentField;
      private set => this.permanentField = value;
    }

    public bool? connected
    {
      get => this.connectedField;
      private set => this.connectedField = value;
    }

    public bool? ospfv3
    {
      get => this.ospfv3Field;
      private set => this.ospfv3Field = value;
    }

    public bool? isis
    {
      get => this.isisField;
      private set => this.isisField = value;
    }

    public bool? active
    {
      get => this.activeField;
      private set => this.activeField = value;
    }

    public bool? bgp
    {
      get => this.bgpField;
      private set => this.bgpField = value;
    }

    public bool? rip
    {
      get => this.ripField;
      private set => this.ripField = value;
    }

    public bool? raroute
    {
      get => this.rarouteField;
      private set => this.rarouteField = value;
    }

    internal override base_resource[] get_nitro_response(
      nitro_service service,
      string response)
    {
      route6.route6_response route6Response = new route6.route6_response();
      route6.route6_response resource = (route6.route6_response) service.get_payload_formatter().string_to_resource(route6Response.GetType(), response);
      if (resource.errorcode != 0)
      {
        if (resource.errorcode == 444)
          service.clear_session();
        if (resource.severity == null)
          throw new nitro_exception(resource.message, resource.errorcode);
        if (resource.severity.Equals("ERROR"))
          throw new nitro_exception(resource.message, resource.errorcode);
      }
      return (base_resource[]) resource.route6;
    }

    internal override string get_object_name() => this.network;

    public static base_response add(nitro_service client, route6 resource) => new route6()
    {
      network = resource.network,
      gateway = resource.gateway,
      vlan = resource.vlan,
      vxlan = resource.vxlan,
      weight = resource.weight,
      distance = resource.distance,
      cost = resource.cost,
      advertise = resource.advertise,
      msr = resource.msr,
      monitor = resource.monitor,
      td = resource.td,
      ownergroup = resource.ownergroup
    }.add_resource(client);

    public static base_responses add(nitro_service client, route6[] resources)
    {
      base_responses baseResponses = (base_responses) null;
      if (resources != null && resources.Length > 0)
      {
        route6[] route6Array = new route6[resources.Length];
        for (int index = 0; index < resources.Length; ++index)
        {
          route6Array[index] = new route6();
          route6Array[index].network = resources[index].network;
          route6Array[index].gateway = resources[index].gateway;
          route6Array[index].vlan = resources[index].vlan;
          route6Array[index].vxlan = resources[index].vxlan;
          route6Array[index].weight = resources[index].weight;
          route6Array[index].distance = resources[index].distance;
          route6Array[index].cost = resources[index].cost;
          route6Array[index].advertise = resources[index].advertise;
          route6Array[index].msr = resources[index].msr;
          route6Array[index].monitor = resources[index].monitor;
          route6Array[index].td = resources[index].td;
          route6Array[index].ownergroup = resources[index].ownergroup;
        }
        baseResponses = base_resource.add_bulk_request(client, (base_resource[]) route6Array);
      }
      return baseResponses;
    }

    public static base_response clear(nitro_service client, route6 resource) => new route6()
    {
      routetype = resource.routetype
    }.perform_operation_byaction(client, nameof (clear));

    public static base_responses clear(nitro_service client, route6[] resources)
    {
      base_responses baseResponses = (base_responses) null;
      if (resources != null && resources.Length > 0)
      {
        route6[] route6Array = new route6[resources.Length];
        for (int index = 0; index < resources.Length; ++index)
        {
          route6Array[index] = new route6();
          route6Array[index].routetype = resources[index].routetype;
        }
        baseResponses = base_resource.perform_operation_bulk_request(client, (base_resource[]) route6Array, nameof (clear));
      }
      return baseResponses;
    }

    public static base_response delete(nitro_service client, string network) => new route6()
    {
      network = network
    }.delete_resource(client);

    public static base_response delete(nitro_service client, route6 resource) => new route6()
    {
      network = resource.network,
      gateway = resource.gateway,
      vlan = resource.vlan,
      vxlan = resource.vxlan,
      td = resource.td,
      ownergroup = resource.ownergroup
    }.delete_resource(client);

    public static base_responses delete(nitro_service client, string[] network)
    {
      base_responses baseResponses = (base_responses) null;
      if (network != null && network.Length > 0)
      {
        route6[] route6Array = new route6[network.Length];
        for (int index = 0; index < network.Length; ++index)
        {
          route6Array[index] = new route6();
          route6Array[index].network = network[index];
        }
        baseResponses = base_resource.delete_bulk_request(client, (base_resource[]) route6Array);
      }
      return baseResponses;
    }

    public static base_responses delete(nitro_service client, route6[] resources)
    {
      base_responses baseResponses = (base_responses) null;
      if (resources != null && resources.Length > 0)
      {
        route6[] route6Array = new route6[resources.Length];
        for (int index = 0; index < resources.Length; ++index)
        {
          route6Array[index] = new route6();
          route6Array[index].network = resources[index].network;
          route6Array[index].gateway = resources[index].gateway;
          route6Array[index].vlan = resources[index].vlan;
          route6Array[index].vxlan = resources[index].vxlan;
          route6Array[index].td = resources[index].td;
          route6Array[index].ownergroup = resources[index].ownergroup;
        }
        baseResponses = base_resource.delete_bulk_request(client, (base_resource[]) route6Array);
      }
      return baseResponses;
    }

    public static base_response update(nitro_service client, route6 resource) => new route6()
    {
      network = resource.network,
      gateway = resource.gateway,
      vlan = resource.vlan,
      vxlan = resource.vxlan,
      weight = resource.weight,
      distance = resource.distance,
      cost = resource.cost,
      advertise = resource.advertise,
      msr = resource.msr,
      monitor = resource.monitor,
      td = resource.td
    }.update_resource(client);

    public static base_responses update(nitro_service client, route6[] resources)
    {
      base_responses baseResponses = (base_responses) null;
      if (resources != null && resources.Length > 0)
      {
        route6[] route6Array = new route6[resources.Length];
        for (int index = 0; index < resources.Length; ++index)
        {
          route6Array[index] = new route6();
          route6Array[index].network = resources[index].network;
          route6Array[index].gateway = resources[index].gateway;
          route6Array[index].vlan = resources[index].vlan;
          route6Array[index].vxlan = resources[index].vxlan;
          route6Array[index].weight = resources[index].weight;
          route6Array[index].distance = resources[index].distance;
          route6Array[index].cost = resources[index].cost;
          route6Array[index].advertise = resources[index].advertise;
          route6Array[index].msr = resources[index].msr;
          route6Array[index].monitor = resources[index].monitor;
          route6Array[index].td = resources[index].td;
        }
        baseResponses = base_resource.update_bulk_request(client, (base_resource[]) route6Array);
      }
      return baseResponses;
    }

    public static base_response unset(
      nitro_service client,
      string network,
      string[] args)
    {
      return new route6() { network = network }.unset_resource(client, args);
    }

    public static base_response unset(
      nitro_service client,
      route6 resource,
      string[] args)
    {
      return new route6()
      {
        network = resource.network,
        gateway = resource.gateway,
        vlan = resource.vlan,
        vxlan = resource.vxlan,
        td = resource.td
      }.unset_resource(client, args);
    }

    public static base_responses unset(
      nitro_service client,
      string[] network,
      string[] args)
    {
      base_responses baseResponses = (base_responses) null;
      if (network != null && network.Length > 0)
      {
        route6[] route6Array = new route6[network.Length];
        for (int index = 0; index < network.Length; ++index)
        {
          route6Array[index] = new route6();
          route6Array[index].network = network[index];
        }
        baseResponses = base_resource.unset_bulk_request(client, (base_resource[]) route6Array, args);
      }
      return baseResponses;
    }

    public static base_responses unset(
      nitro_service client,
      route6[] resources,
      string[] args)
    {
      base_responses baseResponses = (base_responses) null;
      if (resources != null && resources.Length > 0)
      {
        route6[] route6Array = new route6[resources.Length];
        for (int index = 0; index < resources.Length; ++index)
        {
          route6Array[index] = new route6();
          route6Array[index].network = resources[index].network;
          route6Array[index].gateway = resources[index].gateway;
          route6Array[index].vlan = resources[index].vlan;
          route6Array[index].vxlan = resources[index].vxlan;
          route6Array[index].td = resources[index].td;
        }
        baseResponses = base_resource.unset_bulk_request(client, (base_resource[]) route6Array, args);
      }
      return baseResponses;
    }

    public static route6[] get(nitro_service service) => (route6[]) new route6().get_resources(service, (options) null);

    public static route6[] get(nitro_service service, options option) => (route6[]) new route6().get_resources(service, option);

    public static route6 get(nitro_service service, route6 obj)
    {
      options option = new options();
      option.set_args(nitro_util.object_to_string_withoutquotes((object) obj));
      return (route6) obj.get_resource(service, option);
    }

    public static route6[] get(nitro_service service, route6[] obj)
    {
      if (obj == null || obj.Length <= 0)
        return (route6[]) null;
      route6[] route6Array = new route6[obj.Length];
      for (int index = 0; index < obj.Length; ++index)
      {
        options option = new options();
        option.set_args(nitro_util.object_to_string_withoutquotes((object) obj[index]));
        route6Array[index] = (route6) obj[index].get_resource(service, option);
      }
      return route6Array;
    }

    public static route6[] get(nitro_service service, route6_args args)
    {
      route6 route6 = new route6();
      options option = new options();
      option.set_args(nitro_util.object_to_string_withoutquotes((object) args));
      return (route6[]) route6.get_resources(service, option);
    }

    public static route6[] get_filtered(nitro_service service, string filter)
    {
      route6 route6 = new route6();
      options option = new options();
      option.set_filter(filter);
      return (route6[]) route6.getfiltered(service, option);
    }

    public static route6[] get_filtered(nitro_service service, filtervalue[] filter)
    {
      route6 route6 = new route6();
      options option = new options();
      option.set_filter(filter);
      return (route6[]) route6.getfiltered(service, option);
    }

    public static uint count(nitro_service service)
    {
      route6 route6 = new route6();
      options option = new options();
      option.set_count(true);
      route6[] resources = (route6[]) route6.get_resources(service, option);
      return resources != null && resources.Length > 0 ? resources[0].__count.Value : 0U;
    }

    public static uint count_filtered(nitro_service service, string filter)
    {
      route6 route6 = new route6();
      options option = new options();
      option.set_count(true);
      option.set_filter(filter);
      route6[] route6Array = (route6[]) route6.getfiltered(service, option);
      return route6Array != null && route6Array.Length > 0 ? route6Array[0].__count.Value : 0U;
    }

    public static uint count_filtered(nitro_service service, filtervalue[] filter)
    {
      route6 route6 = new route6();
      options option = new options();
      option.set_count(true);
      option.set_filter(filter);
      route6[] route6Array = (route6[]) route6.getfiltered(service, option);
      return route6Array != null && route6Array.Length > 0 ? route6Array[0].__count.Value : 0U;
    }

    private class route6_response : base_response
    {
      public route6[] route6 = (route6[]) null;
    }

    public static class advertiseEnum
    {
      public const string DISABLED = "DISABLED";
      public const string ENABLED = "ENABLED";
    }

    public static class routetypeEnum
    {
      public const string CONNECTED = "CONNECTED";
      public const string STATIC = "STATIC";
      public const string DYNAMIC = "DYNAMIC";
      public const string OSPF = "OSPF";
      public const string ISIS = "ISIS";
      public const string BGP = "BGP";
      public const string RIP = "RIP";
      public const string ND_RA_ROUTE = "ND-RA-ROUTE";
      public const string FIB6 = "FIB6";
    }

    public static class msrEnum
    {
      public const string ENABLED = "ENABLED";
      public const string DISABLED = "DISABLED";
    }

    public static class data1Enum
    {
      public const string ENABLED = "ENABLED";
      public const string DISABLED = "DISABLED";
    }

    public static class routeownersEnum
    {
      public const string _0 = "0";
      public const string _1 = "1";
      public const string _2 = "2";
      public const string _3 = "3";
      public const string _4 = "4";
      public const string _5 = "5";
      public const string _6 = "6";
      public const string _7 = "7";
      public const string _8 = "8";
      public const string _9 = "9";
      public const string _10 = "10";
      public const string _11 = "11";
      public const string _12 = "12";
      public const string _13 = "13";
      public const string _14 = "14";
      public const string _15 = "15";
      public const string _16 = "16";
      public const string _17 = "17";
      public const string _18 = "18";
      public const string _19 = "19";
      public const string _20 = "20";
      public const string _21 = "21";
      public const string _22 = "22";
      public const string _23 = "23";
      public const string _24 = "24";
      public const string _25 = "25";
      public const string _26 = "26";
      public const string _27 = "27";
      public const string _28 = "28";
      public const string _29 = "29";
      public const string _30 = "30";
      public const string _31 = "31";
    }
  }
}
