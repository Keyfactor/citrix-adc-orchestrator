// Decompiled with JetBrains decompiler
// Type: com.citrix.netscaler.nitro.resource.config.network.route
// Assembly: nitro, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 6CF5DDEF-E052-4F9D-953F-6644F8378A66


using com.citrix.netscaler.nitro.exception;
using com.citrix.netscaler.nitro.resource.Base;
using com.citrix.netscaler.nitro.service;
using com.citrix.netscaler.nitro.util;

namespace com.citrix.netscaler.nitro.resource.config.network
{
  public class route : base_resource
  {
    private string networkField = (string) null;
    private string netmaskField = (string) null;
    private string gatewayField = (string) null;
    private uint? costField = new uint?();
    private uint? tdField = new uint?();
    private uint? distanceField = new uint?();
    private uint? cost1Field = new uint?();
    private uint? weightField = new uint?();
    private string advertiseField = (string) null;
    private string[] protocolField = (string[]) null;
    private string msrField = (string) null;
    private string monitorField = (string) null;
    private string ownergroupField = (string) null;
    private string routetypeField = (string) null;
    private bool? detailField = new bool?();
    private string gatewaynameField = (string) null;
    private bool? typeField = new bool?();
    private bool? dynamicField = new bool?();
    private bool? StaticField = new bool?();
    private bool? permanentField = new bool?();
    private bool? directField = new bool?();
    private bool? natField = new bool?();
    private bool? lbrouteField = new bool?();
    private bool? advField = new bool?();
    private bool? tunnelField = new bool?();
    private bool? dataField = new bool?();
    private bool? data0Field = new bool?();
    private bool? flagsField = new bool?();
    private string[] routeownersField = (string[]) null;
    private int? retainField = new int?();
    private bool? ospfField = new bool?();
    private bool? isisField = new bool?();
    private bool? ripField = new bool?();
    private bool? bgpField = new bool?();
    private bool? dhcpField = new bool?();
    private bool? advospfField = new bool?();
    private bool? advisisField = new bool?();
    private bool? advripField = new bool?();
    private bool? advbgpField = new bool?();
    private uint? stateField = new uint?();
    private uint? totalprobesField = new uint?();
    private uint? totalfailedprobesField = new uint?();
    private uint? failedprobesField = new uint?();
    private int? monstatcodeField = new int?();
    private int? monstatparam1Field = new int?();
    private int? monstatparam2Field = new int?();
    private int? monstatparam3Field = new int?();
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

    public string netmask
    {
      get => this.netmaskField;
      set => this.netmaskField = value;
    }

    public string gateway
    {
      get => this.gatewayField;
      set => this.gatewayField = value;
    }

    public uint? cost
    {
      get => this.costField;
      set => this.costField = value;
    }

    public uint? td
    {
      get => this.tdField;
      set => this.tdField = value;
    }

    public uint? distance
    {
      get => this.distanceField;
      set => this.distanceField = value;
    }

    public uint? cost1
    {
      get => this.cost1Field;
      set => this.cost1Field = value;
    }

    public uint? weight
    {
      get => this.weightField;
      set => this.weightField = value;
    }

    public string advertise
    {
      get => this.advertiseField;
      set => this.advertiseField = value;
    }

    public string[] protocol
    {
      get => this.protocolField;
      set => this.protocolField = value;
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

    public bool? direct
    {
      get => this.directField;
      private set => this.directField = value;
    }

    public bool? nat
    {
      get => this.natField;
      private set => this.natField = value;
    }

    public bool? lbroute
    {
      get => this.lbrouteField;
      private set => this.lbrouteField = value;
    }

    public bool? adv
    {
      get => this.advField;
      private set => this.advField = value;
    }

    public bool? tunnel
    {
      get => this.tunnelField;
      private set => this.tunnelField = value;
    }

    public bool? data
    {
      get => this.dataField;
      private set => this.dataField = value;
    }

    public bool? data0
    {
      get => this.data0Field;
      private set => this.data0Field = value;
    }

    public bool? flags
    {
      get => this.flagsField;
      private set => this.flagsField = value;
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

    public bool? ospf
    {
      get => this.ospfField;
      private set => this.ospfField = value;
    }

    public bool? isis
    {
      get => this.isisField;
      private set => this.isisField = value;
    }

    public bool? rip
    {
      get => this.ripField;
      private set => this.ripField = value;
    }

    public bool? bgp
    {
      get => this.bgpField;
      private set => this.bgpField = value;
    }

    public bool? dhcp
    {
      get => this.dhcpField;
      private set => this.dhcpField = value;
    }

    public bool? advospf
    {
      get => this.advospfField;
      private set => this.advospfField = value;
    }

    public bool? advisis
    {
      get => this.advisisField;
      private set => this.advisisField = value;
    }

    public bool? advrip
    {
      get => this.advripField;
      private set => this.advripField = value;
    }

    public bool? advbgp
    {
      get => this.advbgpField;
      private set => this.advbgpField = value;
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

    internal override base_resource[] get_nitro_response(
      nitro_service service,
      string response)
    {
      route.route_response routeResponse = new route.route_response();
      route.route_response resource = (route.route_response) service.get_payload_formatter().string_to_resource(routeResponse.GetType(), response);
      if (resource.errorcode != 0)
      {
        if (resource.errorcode == 444)
          service.clear_session();
        if (resource.severity == null)
          throw new nitro_exception(resource.message, resource.errorcode);
        if (resource.severity.Equals("ERROR"))
          throw new nitro_exception(resource.message, resource.errorcode);
      }
      return (base_resource[]) resource.route;
    }

    internal override string get_object_name() => this.network;

    public static base_response add(nitro_service client, route resource) => new route()
    {
      network = resource.network,
      netmask = resource.netmask,
      gateway = resource.gateway,
      cost = resource.cost,
      td = resource.td,
      distance = resource.distance,
      cost1 = resource.cost1,
      weight = resource.weight,
      advertise = resource.advertise,
      protocol = resource.protocol,
      msr = resource.msr,
      monitor = resource.monitor,
      ownergroup = resource.ownergroup
    }.add_resource(client);

    public static base_responses add(nitro_service client, route[] resources)
    {
      base_responses baseResponses = (base_responses) null;
      if (resources != null && resources.Length > 0)
      {
        route[] routeArray = new route[resources.Length];
        for (int index = 0; index < resources.Length; ++index)
        {
          routeArray[index] = new route();
          routeArray[index].network = resources[index].network;
          routeArray[index].netmask = resources[index].netmask;
          routeArray[index].gateway = resources[index].gateway;
          routeArray[index].cost = resources[index].cost;
          routeArray[index].td = resources[index].td;
          routeArray[index].distance = resources[index].distance;
          routeArray[index].cost1 = resources[index].cost1;
          routeArray[index].weight = resources[index].weight;
          routeArray[index].advertise = resources[index].advertise;
          routeArray[index].protocol = resources[index].protocol;
          routeArray[index].msr = resources[index].msr;
          routeArray[index].monitor = resources[index].monitor;
          routeArray[index].ownergroup = resources[index].ownergroup;
        }
        baseResponses = base_resource.add_bulk_request(client, (base_resource[]) routeArray);
      }
      return baseResponses;
    }

    public static base_response clear(nitro_service client, route resource) => new route()
    {
      routetype = resource.routetype
    }.perform_operation_byaction(client, nameof (clear));

    public static base_responses clear(nitro_service client, route[] resources)
    {
      base_responses baseResponses = (base_responses) null;
      if (resources != null && resources.Length > 0)
      {
        route[] routeArray = new route[resources.Length];
        for (int index = 0; index < resources.Length; ++index)
        {
          routeArray[index] = new route();
          routeArray[index].routetype = resources[index].routetype;
        }
        baseResponses = base_resource.perform_operation_bulk_request(client, (base_resource[]) routeArray, nameof (clear));
      }
      return baseResponses;
    }

    public static base_response delete(nitro_service client, string network) => new route()
    {
      network = network
    }.delete_resource(client);

    public static base_response delete(nitro_service client, route resource) => new route()
    {
      network = resource.network,
      netmask = resource.netmask,
      gateway = resource.gateway,
      td = resource.td,
      ownergroup = resource.ownergroup
    }.delete_resource(client);

    public static base_responses delete(nitro_service client, string[] network)
    {
      base_responses baseResponses = (base_responses) null;
      if (network != null && network.Length > 0)
      {
        route[] routeArray = new route[network.Length];
        for (int index = 0; index < network.Length; ++index)
        {
          routeArray[index] = new route();
          routeArray[index].network = network[index];
        }
        baseResponses = base_resource.delete_bulk_request(client, (base_resource[]) routeArray);
      }
      return baseResponses;
    }

    public static base_responses delete(nitro_service client, route[] resources)
    {
      base_responses baseResponses = (base_responses) null;
      if (resources != null && resources.Length > 0)
      {
        route[] routeArray = new route[resources.Length];
        for (int index = 0; index < resources.Length; ++index)
        {
          routeArray[index] = new route();
          routeArray[index].network = resources[index].network;
          routeArray[index].netmask = resources[index].netmask;
          routeArray[index].gateway = resources[index].gateway;
          routeArray[index].td = resources[index].td;
          routeArray[index].ownergroup = resources[index].ownergroup;
        }
        baseResponses = base_resource.delete_bulk_request(client, (base_resource[]) routeArray);
      }
      return baseResponses;
    }

    public static base_response update(nitro_service client, route resource) => new route()
    {
      network = resource.network,
      netmask = resource.netmask,
      gateway = resource.gateway,
      td = resource.td,
      distance = resource.distance,
      cost1 = resource.cost1,
      weight = resource.weight,
      advertise = resource.advertise,
      protocol = resource.protocol,
      msr = resource.msr,
      monitor = resource.monitor
    }.update_resource(client);

    public static base_responses update(nitro_service client, route[] resources)
    {
      base_responses baseResponses = (base_responses) null;
      if (resources != null && resources.Length > 0)
      {
        route[] routeArray = new route[resources.Length];
        for (int index = 0; index < resources.Length; ++index)
        {
          routeArray[index] = new route();
          routeArray[index].network = resources[index].network;
          routeArray[index].netmask = resources[index].netmask;
          routeArray[index].gateway = resources[index].gateway;
          routeArray[index].td = resources[index].td;
          routeArray[index].distance = resources[index].distance;
          routeArray[index].cost1 = resources[index].cost1;
          routeArray[index].weight = resources[index].weight;
          routeArray[index].advertise = resources[index].advertise;
          routeArray[index].protocol = resources[index].protocol;
          routeArray[index].msr = resources[index].msr;
          routeArray[index].monitor = resources[index].monitor;
        }
        baseResponses = base_resource.update_bulk_request(client, (base_resource[]) routeArray);
      }
      return baseResponses;
    }

    public static base_response unset(
      nitro_service client,
      route resource,
      string[] args)
    {
      return new route()
      {
        network = resource.network,
        netmask = resource.netmask,
        gateway = resource.gateway,
        td = resource.td
      }.unset_resource(client, args);
    }

    public static base_responses unset(
      nitro_service client,
      route[] resources,
      string[] args)
    {
      base_responses baseResponses = (base_responses) null;
      if (resources != null && resources.Length > 0)
      {
        route[] routeArray = new route[resources.Length];
        for (int index = 0; index < resources.Length; ++index)
        {
          routeArray[index] = new route();
          routeArray[index].network = resources[index].network;
          routeArray[index].netmask = resources[index].netmask;
          routeArray[index].gateway = resources[index].gateway;
          routeArray[index].td = resources[index].td;
        }
        baseResponses = base_resource.unset_bulk_request(client, (base_resource[]) routeArray, args);
      }
      return baseResponses;
    }

    public static route[] get(nitro_service service) => (route[]) new route().get_resources(service, (options) null);

    public static route[] get(nitro_service service, options option) => (route[]) new route().get_resources(service, option);

    public static route get(nitro_service service, route obj)
    {
      options option = new options();
      option.set_args(nitro_util.object_to_string_withoutquotes((object) obj));
      return (route) obj.get_resource(service, option);
    }

    public static route[] get(nitro_service service, route[] obj)
    {
      if (obj == null || obj.Length <= 0)
        return (route[]) null;
      route[] routeArray = new route[obj.Length];
      for (int index = 0; index < obj.Length; ++index)
      {
        options option = new options();
        option.set_args(nitro_util.object_to_string_withoutquotes((object) obj[index]));
        routeArray[index] = (route) obj[index].get_resource(service, option);
      }
      return routeArray;
    }

    public static route[] get(nitro_service service, route_args args)
    {
      route route = new route();
      options option = new options();
      option.set_args(nitro_util.object_to_string_withoutquotes((object) args));
      return (route[]) route.get_resources(service, option);
    }

    public static route[] get_filtered(nitro_service service, string filter)
    {
      route route = new route();
      options option = new options();
      option.set_filter(filter);
      return (route[]) route.getfiltered(service, option);
    }

    public static route[] get_filtered(nitro_service service, filtervalue[] filter)
    {
      route route = new route();
      options option = new options();
      option.set_filter(filter);
      return (route[]) route.getfiltered(service, option);
    }

    public static uint count(nitro_service service)
    {
      route route = new route();
      options option = new options();
      option.set_count(true);
      route[] resources = (route[]) route.get_resources(service, option);
      return resources != null && resources.Length > 0 ? resources[0].__count.Value : 0U;
    }

    public static uint count_filtered(nitro_service service, string filter)
    {
      route route = new route();
      options option = new options();
      option.set_count(true);
      option.set_filter(filter);
      route[] routeArray = (route[]) route.getfiltered(service, option);
      return routeArray != null && routeArray.Length > 0 ? routeArray[0].__count.Value : 0U;
    }

    public static uint count_filtered(nitro_service service, filtervalue[] filter)
    {
      route route = new route();
      options option = new options();
      option.set_count(true);
      option.set_filter(filter);
      route[] routeArray = (route[]) route.getfiltered(service, option);
      return routeArray != null && routeArray.Length > 0 ? routeArray[0].__count.Value : 0U;
    }

    private class route_response : base_response
    {
      public route[] route = (route[]) null;
    }

    public static class protocolEnum
    {
      public const string OSPF = "OSPF";
      public const string ISIS = "ISIS";
      public const string RIP = "RIP";
      public const string BGP = "BGP";
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
      public const string RIP = "RIP";
      public const string BGP = "BGP";
      public const string VPATH = "VPATH";
    }

    public static class msrEnum
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
