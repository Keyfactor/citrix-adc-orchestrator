// Decompiled with JetBrains decompiler
// Type: com.citrix.netscaler.nitro.resource.config.cluster.clusterinstance_clusternode_binding
// Assembly: nitro, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 6CF5DDEF-E052-4F9D-953F-6644F8378A66


using com.citrix.netscaler.nitro.exception;
using com.citrix.netscaler.nitro.resource.Base;
using com.citrix.netscaler.nitro.service;
using com.citrix.netscaler.nitro.util;

namespace com.citrix.netscaler.nitro.resource.config.cluster
{
  public class clusterinstance_clusternode_binding : base_resource
  {
    private uint? nodeidField = new uint?();
    private string ipaddressField = (string) null;
    private string healthField = (string) null;
    private string clusterhealthField = (string) null;
    private string effectivestateField = (string) null;
    private string masterstateField = (string) null;
    private string stateField = (string) null;
    private bool? isconfigurationcoordinatorField = new bool?();
    private bool? islocalnodeField = new bool?();
    private bool? nodersskeymismatchField = new bool?();
    private bool? nodelicensemismatchField = new bool?();
    private bool? nodejumbonotsupportedField = new bool?();
    private uint? clidField = new uint?();
    private uint? __countField = new uint?();

    public uint? __count
    {
      get => this.__countField;
      set => this.__countField = value;
    }

    public uint? nodeid
    {
      get => this.nodeidField;
      set => this.nodeidField = value;
    }

    public uint? clid
    {
      get => this.clidField;
      set => this.clidField = value;
    }

    public string state
    {
      get => this.stateField;
      private set => this.stateField = value;
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

    public string effectivestate
    {
      get => this.effectivestateField;
      private set => this.effectivestateField = value;
    }

    public bool? islocalnode
    {
      get => this.islocalnodeField;
      private set => this.islocalnodeField = value;
    }

    public bool? isconfigurationcoordinator
    {
      get => this.isconfigurationcoordinatorField;
      private set => this.isconfigurationcoordinatorField = value;
    }

    public bool? nodejumbonotsupported
    {
      get => this.nodejumbonotsupportedField;
      private set => this.nodejumbonotsupportedField = value;
    }

    public string health
    {
      get => this.healthField;
      private set => this.healthField = value;
    }

    public string clusterhealth
    {
      get => this.clusterhealthField;
      private set => this.clusterhealthField = value;
    }

    public string masterstate
    {
      get => this.masterstateField;
      private set => this.masterstateField = value;
    }

    public string ipaddress
    {
      get => this.ipaddressField;
      private set => this.ipaddressField = value;
    }

    internal override base_resource[] get_nitro_response(
      nitro_service service,
      string response)
    {
      clusterinstance_clusternode_binding.clusterinstance_clusternode_binding_response clusternodeBindingResponse = new clusterinstance_clusternode_binding.clusterinstance_clusternode_binding_response();
      clusterinstance_clusternode_binding.clusterinstance_clusternode_binding_response resource = (clusterinstance_clusternode_binding.clusterinstance_clusternode_binding_response) service.get_payload_formatter().string_to_resource(clusternodeBindingResponse.GetType(), response);
      if (resource.errorcode != 0)
      {
        if (resource.errorcode == 444)
          service.clear_session();
        if (resource.severity == null)
          throw new nitro_exception(resource.message, resource.errorcode);
        if (resource.severity.Equals("ERROR"))
          throw new nitro_exception(resource.message, resource.errorcode);
      }
      return (base_resource[]) resource.clusterinstance_clusternode_binding;
    }

    internal override string get_object_name() => this.clid.HasValue ? this.clid.ToString() : (string) null;

    public static clusterinstance_clusternode_binding[] get(
      nitro_service service,
      uint? clid)
    {
      return (clusterinstance_clusternode_binding[]) new clusterinstance_clusternode_binding()
      {
        clid = clid
      }.get_resources(service, (options) null);
    }

    public static clusterinstance_clusternode_binding[] get_filtered(
      nitro_service service,
      uint? clid,
      string filter)
    {
      clusterinstance_clusternode_binding clusternodeBinding = new clusterinstance_clusternode_binding();
      clusternodeBinding.clid = clid;
      options option = new options();
      option.set_filter(filter);
      return (clusterinstance_clusternode_binding[]) clusternodeBinding.getfiltered(service, option);
    }

    public static clusterinstance_clusternode_binding[] get_filtered(
      nitro_service service,
      uint? clid,
      filtervalue[] filter)
    {
      clusterinstance_clusternode_binding clusternodeBinding = new clusterinstance_clusternode_binding();
      clusternodeBinding.clid = clid;
      options option = new options();
      option.set_filter(filter);
      return (clusterinstance_clusternode_binding[]) clusternodeBinding.getfiltered(service, option);
    }

    public static uint count(nitro_service service, uint? clid)
    {
      clusterinstance_clusternode_binding clusternodeBinding = new clusterinstance_clusternode_binding();
      clusternodeBinding.clid = clid;
      options option = new options();
      option.set_count(true);
      clusterinstance_clusternode_binding[] resources = (clusterinstance_clusternode_binding[]) clusternodeBinding.get_resources(service, option);
      return resources != null && resources.Length > 0 ? resources[0].__count.Value : 0U;
    }

    public static uint count_filtered(nitro_service service, uint? clid, string filter)
    {
      clusterinstance_clusternode_binding clusternodeBinding = new clusterinstance_clusternode_binding();
      clusternodeBinding.clid = clid;
      options option = new options();
      option.set_count(true);
      option.set_filter(filter);
      clusterinstance_clusternode_binding[] clusternodeBindingArray = (clusterinstance_clusternode_binding[]) clusternodeBinding.getfiltered(service, option);
      return clusternodeBindingArray != null && clusternodeBindingArray.Length > 0 ? clusternodeBindingArray[0].__count.Value : 0U;
    }

    public static uint count_filtered(nitro_service service, uint? clid, filtervalue[] filter)
    {
      clusterinstance_clusternode_binding clusternodeBinding = new clusterinstance_clusternode_binding();
      clusternodeBinding.clid = clid;
      options option = new options();
      option.set_count(true);
      option.set_filter(filter);
      clusterinstance_clusternode_binding[] clusternodeBindingArray = (clusterinstance_clusternode_binding[]) clusternodeBinding.getfiltered(service, option);
      return clusternodeBindingArray != null && clusternodeBindingArray.Length > 0 ? clusternodeBindingArray[0].__count.Value : 0U;
    }

    private class clusterinstance_clusternode_binding_response : base_response
    {
      public clusterinstance_clusternode_binding[] clusterinstance_clusternode_binding = (clusterinstance_clusternode_binding[]) null;
    }

    public static class stateEnum
    {
      public const string ACTIVE = "ACTIVE";
      public const string SPARE = "SPARE";
      public const string PASSIVE = "PASSIVE";
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
