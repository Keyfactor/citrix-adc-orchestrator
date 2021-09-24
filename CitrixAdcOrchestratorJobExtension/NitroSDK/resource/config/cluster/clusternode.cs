// Decompiled with JetBrains decompiler
// Type: com.citrix.netscaler.nitro.resource.config.cluster.clusternode
// Assembly: nitro, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 6CF5DDEF-E052-4F9D-953F-6644F8378A66


using com.citrix.netscaler.nitro.exception;
using com.citrix.netscaler.nitro.resource.Base;
using com.citrix.netscaler.nitro.service;
using com.citrix.netscaler.nitro.util;

namespace com.citrix.netscaler.nitro.resource.config.cluster
{
  public class clusternode : base_resource
  {
    private uint? nodeidField = new uint?();
    private string ipaddressField = (string) null;
    private string stateField = (string) null;
    private string backplaneField = (string) null;
    private uint? priorityField = new uint?();
    private string nodegroupField = (string) null;
    private string clearnodegroupconfigField = (string) null;
    private string clusterhealthField = (string) null;
    private string effectivestateField = (string) null;
    private string operationalsyncstateField = (string) null;
    private string masterstateField = (string) null;
    private string healthField = (string) null;
    private bool? isconfigurationcoordinatorField = new bool?();
    private bool? islocalnodeField = new bool?();
    private bool? nodersskeymismatchField = new bool?();
    private bool? nodelicensemismatchField = new bool?();
    private bool? nodejumbonotsupportedField = new bool?();
    private uint?[] nodelistField = (uint?[]) null;
    private string[] ifaceslistField = (string[]) null;
    private string enabledifacesField = (string) null;
    private string disabledifacesField = (string) null;
    private string partialfailifacesField = (string) null;
    private string hamonifacesField = (string) null;
    private string nameField = (string) null;
    private uint? cfgflagsField = new uint?();
    private uint? __countField = new uint?();

    public uint? __count
    {
      get => this.__countField;
      private set => this.__countField = value;
    }

    public uint? nodeid
    {
      get => this.nodeidField;
      set => this.nodeidField = value;
    }

    public string ipaddress
    {
      get => this.ipaddressField;
      set => this.ipaddressField = value;
    }

    public string state
    {
      get => this.stateField;
      set => this.stateField = value;
    }

    public string backplane
    {
      get => this.backplaneField;
      set => this.backplaneField = value;
    }

    public uint? priority
    {
      get => this.priorityField;
      set => this.priorityField = value;
    }

    public string nodegroup
    {
      get => this.nodegroupField;
      set => this.nodegroupField = value;
    }

    public string clearnodegroupconfig
    {
      get => this.clearnodegroupconfigField;
      set => this.clearnodegroupconfigField = value;
    }

    public string clusterhealth
    {
      get => this.clusterhealthField;
      private set => this.clusterhealthField = value;
    }

    public string effectivestate
    {
      get => this.effectivestateField;
      private set => this.effectivestateField = value;
    }

    public string operationalsyncstate
    {
      get => this.operationalsyncstateField;
      private set => this.operationalsyncstateField = value;
    }

    public string masterstate
    {
      get => this.masterstateField;
      private set => this.masterstateField = value;
    }

    public string health
    {
      get => this.healthField;
      private set => this.healthField = value;
    }

    public bool? isconfigurationcoordinator
    {
      get => this.isconfigurationcoordinatorField;
      private set => this.isconfigurationcoordinatorField = value;
    }

    public bool? islocalnode
    {
      get => this.islocalnodeField;
      private set => this.islocalnodeField = value;
    }

    public bool? nodersskeymismatch
    {
      get => this.nodersskeymismatchField;
      private set => this.nodersskeymismatchField = value;
    }

    public bool? nodelicensemismatch
    {
      get => this.nodelicensemismatchField;
      private set => this.nodelicensemismatchField = value;
    }

    public bool? nodejumbonotsupported
    {
      get => this.nodejumbonotsupportedField;
      private set => this.nodejumbonotsupportedField = value;
    }

    public uint?[] nodelist
    {
      get => this.nodelistField;
      private set => this.nodelistField = value;
    }

    public string[] ifaceslist
    {
      get => this.ifaceslistField;
      private set => this.ifaceslistField = value;
    }

    public string enabledifaces
    {
      get => this.enabledifacesField;
      private set => this.enabledifacesField = value;
    }

    public string disabledifaces
    {
      get => this.disabledifacesField;
      private set => this.disabledifacesField = value;
    }

    public string partialfailifaces
    {
      get => this.partialfailifacesField;
      private set => this.partialfailifacesField = value;
    }

    public string hamonifaces
    {
      get => this.hamonifacesField;
      private set => this.hamonifacesField = value;
    }

    public string name
    {
      get => this.nameField;
      private set => this.nameField = value;
    }

    public uint? cfgflags
    {
      get => this.cfgflagsField;
      private set => this.cfgflagsField = value;
    }

    internal override base_resource[] get_nitro_response(
      nitro_service service,
      string response)
    {
      clusternode.clusternode_response clusternodeResponse = new clusternode.clusternode_response();
      clusternode.clusternode_response resource = (clusternode.clusternode_response) service.get_payload_formatter().string_to_resource(clusternodeResponse.GetType(), response);
      if (resource.errorcode != 0)
      {
        if (resource.errorcode == 444)
          service.clear_session();
        if (resource.severity == null)
          throw new nitro_exception(resource.message, resource.errorcode);
        if (resource.severity.Equals("ERROR"))
          throw new nitro_exception(resource.message, resource.errorcode);
      }
      return (base_resource[]) resource.clusternode;
    }

    internal override string get_object_name() => this.nodeid.HasValue ? this.nodeid.ToString() : (string) null;

    public static base_response add(nitro_service client, clusternode resource) => new clusternode()
    {
      nodeid = resource.nodeid,
      ipaddress = resource.ipaddress,
      state = resource.state,
      backplane = resource.backplane,
      priority = resource.priority,
      nodegroup = resource.nodegroup
    }.add_resource(client);

    public static base_responses add(nitro_service client, clusternode[] resources)
    {
      base_responses baseResponses = (base_responses) null;
      if (resources != null && resources.Length > 0)
      {
        clusternode[] clusternodeArray = new clusternode[resources.Length];
        for (int index = 0; index < resources.Length; ++index)
        {
          clusternodeArray[index] = new clusternode();
          clusternodeArray[index].nodeid = resources[index].nodeid;
          clusternodeArray[index].ipaddress = resources[index].ipaddress;
          clusternodeArray[index].state = resources[index].state;
          clusternodeArray[index].backplane = resources[index].backplane;
          clusternodeArray[index].priority = resources[index].priority;
          clusternodeArray[index].nodegroup = resources[index].nodegroup;
        }
        baseResponses = base_resource.add_bulk_request(client, (base_resource[]) clusternodeArray);
      }
      return baseResponses;
    }

    public static base_response update(nitro_service client, clusternode resource) => new clusternode()
    {
      nodeid = resource.nodeid,
      state = resource.state,
      backplane = resource.backplane,
      priority = resource.priority
    }.update_resource(client);

    public static base_responses update(nitro_service client, clusternode[] resources)
    {
      base_responses baseResponses = (base_responses) null;
      if (resources != null && resources.Length > 0)
      {
        clusternode[] clusternodeArray = new clusternode[resources.Length];
        for (int index = 0; index < resources.Length; ++index)
        {
          clusternodeArray[index] = new clusternode();
          clusternodeArray[index].nodeid = resources[index].nodeid;
          clusternodeArray[index].state = resources[index].state;
          clusternodeArray[index].backplane = resources[index].backplane;
          clusternodeArray[index].priority = resources[index].priority;
        }
        baseResponses = base_resource.update_bulk_request(client, (base_resource[]) clusternodeArray);
      }
      return baseResponses;
    }

    public static base_response unset(
      nitro_service client,
      uint? nodeid,
      string[] args)
    {
      return new clusternode() { nodeid = nodeid }.unset_resource(client, args);
    }

    public static base_response unset(
      nitro_service client,
      clusternode resource,
      string[] args)
    {
      return new clusternode() { nodeid = resource.nodeid }.unset_resource(client, args);
    }

    public static base_responses unset(
      nitro_service client,
      uint?[] nodeid,
      string[] args)
    {
      base_responses baseResponses = (base_responses) null;
      if (nodeid != null && nodeid.Length > 0)
      {
        clusternode[] clusternodeArray = new clusternode[nodeid.Length];
        for (int index = 0; index < nodeid.Length; ++index)
        {
          clusternodeArray[index] = new clusternode();
          clusternodeArray[index].nodeid = nodeid[index];
        }
        baseResponses = base_resource.unset_bulk_request(client, (base_resource[]) clusternodeArray, args);
      }
      return baseResponses;
    }

    public static base_responses unset(
      nitro_service client,
      clusternode[] resources,
      string[] args)
    {
      base_responses baseResponses = (base_responses) null;
      if (resources != null && resources.Length > 0)
      {
        clusternode[] clusternodeArray = new clusternode[resources.Length];
        for (int index = 0; index < resources.Length; ++index)
        {
          clusternodeArray[index] = new clusternode();
          clusternodeArray[index].nodeid = resources[index].nodeid;
        }
        baseResponses = base_resource.unset_bulk_request(client, (base_resource[]) clusternodeArray, args);
      }
      return baseResponses;
    }

    public static base_response delete(nitro_service client, uint? nodeid) => new clusternode()
    {
      nodeid = nodeid
    }.delete_resource(client);

    public static base_response delete(nitro_service client, clusternode resource) => new clusternode()
    {
      nodeid = resource.nodeid,
      clearnodegroupconfig = resource.clearnodegroupconfig
    }.delete_resource(client);

    public static base_responses delete(nitro_service client, uint?[] nodeid)
    {
      base_responses baseResponses = (base_responses) null;
      if (nodeid != null && nodeid.Length > 0)
      {
        clusternode[] clusternodeArray = new clusternode[nodeid.Length];
        for (int index = 0; index < nodeid.Length; ++index)
        {
          clusternodeArray[index] = new clusternode();
          clusternodeArray[index].nodeid = nodeid[index];
        }
        baseResponses = base_resource.delete_bulk_request(client, (base_resource[]) clusternodeArray);
      }
      return baseResponses;
    }

    public static base_responses delete(nitro_service client, clusternode[] resources)
    {
      base_responses baseResponses = (base_responses) null;
      if (resources != null && resources.Length > 0)
      {
        clusternode[] clusternodeArray = new clusternode[resources.Length];
        for (int index = 0; index < resources.Length; ++index)
        {
          clusternodeArray[index] = new clusternode();
          clusternodeArray[index].nodeid = resources[index].nodeid;
          clusternodeArray[index].clearnodegroupconfig = resources[index].clearnodegroupconfig;
        }
        baseResponses = base_resource.delete_bulk_request(client, (base_resource[]) clusternodeArray);
      }
      return baseResponses;
    }

    public static clusternode[] get(nitro_service service) => (clusternode[]) new clusternode().get_resources(service, (options) null);

    public static clusternode[] get(nitro_service service, options option) => (clusternode[]) new clusternode().get_resources(service, option);

    public static clusternode get(nitro_service service, uint? nodeid) => (clusternode) new clusternode()
    {
      nodeid = nodeid
    }.get_resource(service);

    public static clusternode[] get(nitro_service service, uint?[] nodeid)
    {
      if (nodeid == null || nodeid.Length <= 0)
        return (clusternode[]) null;
      clusternode[] clusternodeArray1 = new clusternode[nodeid.Length];
      clusternode[] clusternodeArray2 = new clusternode[nodeid.Length];
      for (int index = 0; index < nodeid.Length; ++index)
      {
        clusternodeArray2[index] = new clusternode();
        clusternodeArray2[index].nodeid = nodeid[index];
        clusternodeArray1[index] = (clusternode) clusternodeArray2[index].get_resource(service);
      }
      return clusternodeArray1;
    }

    public static clusternode[] get_filtered(nitro_service service, string filter)
    {
      clusternode clusternode = new clusternode();
      options option = new options();
      option.set_filter(filter);
      return (clusternode[]) clusternode.getfiltered(service, option);
    }

    public static clusternode[] get_filtered(nitro_service service, filtervalue[] filter)
    {
      clusternode clusternode = new clusternode();
      options option = new options();
      option.set_filter(filter);
      return (clusternode[]) clusternode.getfiltered(service, option);
    }

    public static uint count(nitro_service service)
    {
      clusternode clusternode = new clusternode();
      options option = new options();
      option.set_count(true);
      clusternode[] resources = (clusternode[]) clusternode.get_resources(service, option);
      return resources != null && resources.Length > 0 ? resources[0].__count.Value : 0U;
    }

    public static uint count_filtered(nitro_service service, string filter)
    {
      clusternode clusternode = new clusternode();
      options option = new options();
      option.set_count(true);
      option.set_filter(filter);
      clusternode[] clusternodeArray = (clusternode[]) clusternode.getfiltered(service, option);
      return clusternodeArray != null && clusternodeArray.Length > 0 ? clusternodeArray[0].__count.Value : 0U;
    }

    public static uint count_filtered(nitro_service service, filtervalue[] filter)
    {
      clusternode clusternode = new clusternode();
      options option = new options();
      option.set_count(true);
      option.set_filter(filter);
      clusternode[] clusternodeArray = (clusternode[]) clusternode.getfiltered(service, option);
      return clusternodeArray != null && clusternodeArray.Length > 0 ? clusternodeArray[0].__count.Value : 0U;
    }

    private class clusternode_response : base_response
    {
      public clusternode[] clusternode = (clusternode[]) null;
    }

    public static class stateEnum
    {
      public const string ACTIVE = "ACTIVE";
      public const string SPARE = "SPARE";
      public const string PASSIVE = "PASSIVE";
    }

    public static class clearnodegroupconfigEnum
    {
      public const string YES = "YES";
      public const string NO = "NO";
    }

    public static class operationalsyncstateEnum
    {
      public const string ENABLED = "ENABLED";
      public const string SUCCESS = "SUCCESS";
      public const string IN_PROGRESS = "IN PROGRESS";
      public const string FAILED = "FAILED";
      public const string INCREMENTAL_SYNC_DISABLED = "INCREMENTAL SYNC DISABLED";
      public const string DISABLED = "DISABLED";
      public const string UNKNOWN = "UNKNOWN";
    }

    public static class effectivestateEnum
    {
      public const string UP = "UP";
      public const string NOT_UP = "NOT UP";
      public const string UNKNOWN = "UNKNOWN";
      public const string INIT = "INIT";
    }

    public static class healthEnum
    {
      public const string UNKNOWN = "UNKNOWN";
      public const string INIT = "INIT";
      public const string DOWN = "DOWN";
      public const string UP = "UP";
      public const string Some_enabled_and_HAMON_interfaces_of_the_node_are_down = "Some enabled and HAMON interfaces of the node are down";
      public const string All_interfaces_of_the_node_are_down_or_disabled = "All interfaces of the node are down or disabled";
      public const string SSL_card_s__of_the_node_have_failed = "SSL card(s) of the node have failed";
      public const string Route_Monitor_s__of_the_node_have_failed = "Route Monitor(s) of the node have failed";
      public const string Service_state_is_being_synchronized_with_the_cluster = "Service state is being synchronized with the cluster";
      public const string The_backplane_interface_is_not_set = "The backplane interface is not set";
      public const string _is_down = " is down";
      public const string _or_is_disabled = " or is disabled";
      public const string The_CLAG_member_s__of_the_node_are_down = "The CLAG member(s) of the node are down";
      public const string Persistence_sessions_are_being_synchronized_with_the_cluster = "Persistence sessions are being synchronized with the cluster";
      public const string The_Syn_Cookie_is_being_synchronized_with_the_cluster = "The Syn Cookie is being synchronized with the cluster";
      public const string Unknown_Health = "Unknown Health";
      public const string AAA_keys_are_being_sychronized_with_the_cluster = "AAA keys are being sychronized with the cluster";
    }

    public static class clusterhealthEnum
    {
      public const string UP = "UP";
      public const string Configurations_of_the_node_are_lagging_behind_the_cluster_by_more_than_256_commands = "Configurations of the node are lagging behind the cluster by more than 256 commands";
      public const string The_config_sync_operation_has_exceeded_the_time_limit_of_60_seconds = "The config sync operation has exceeded the time limit of 60 seconds";
      public const string The_config_sync_operation__full_sync__is_in_progress = "The config sync operation (full sync) is in progress";
      public const string The_node_is_not_in_sync_with_the_cluster_configurations_as_sync_is_disabled_on_this_node = "The node is not in sync with the cluster configurations as sync is disabled on this node";
      public const string The_execution_of_a_configuration_command_has_failed_on_this_node = "The execution of a configuration command has failed on this node";
      public const string UNKNOWN = "UNKNOWN";
    }

    public static class masterstateEnum
    {
      public const string INACTIVE = "INACTIVE";
      public const string ACTIVE = "ACTIVE";
      public const string UNKNOWN = "UNKNOWN";
    }
  }
}
