// Decompiled with JetBrains decompiler
// Type: com.citrix.netscaler.nitro.resource.config.basic.servicegroup_servicegroupentitymonbindings_binding
// Assembly: nitro, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 6CF5DDEF-E052-4F9D-953F-6644F8378A66


using com.citrix.netscaler.nitro.exception;
using com.citrix.netscaler.nitro.resource.Base;
using com.citrix.netscaler.nitro.service;
using com.citrix.netscaler.nitro.util;

namespace com.citrix.netscaler.nitro.resource.config.basic
{
  public class servicegroup_servicegroupentitymonbindings_binding : base_resource
  {
    private string servicegroupentname2Field = (string) null;
    private string monitor_nameField = (string) null;
    private string monitor_stateField = (string) null;
    private bool? passiveField = new bool?();
    private uint? monitortotalprobesField = new uint?();
    private uint? monitortotalfailedprobesField = new uint?();
    private uint? monitorcurrentfailedprobesField = new uint?();
    private string lastresponseField = (string) null;
    private string servicegroupnameField = (string) null;
    private ushort? portField = new ushort?();
    private uint? weightField = new uint?();
    private string customserveridField = (string) null;
    private uint? serveridField = new uint?();
    private string stateField = (string) null;
    private uint? hashidField = new uint?();
    private uint? __countField = new uint?();

    public uint? __count
    {
      get => this.__countField;
      set => this.__countField = value;
    }

    public string servicegroupname
    {
      get => this.servicegroupnameField;
      set => this.servicegroupnameField = value;
    }

    public string servicegroupentname2
    {
      get => this.servicegroupentname2Field;
      set => this.servicegroupentname2Field = value;
    }

    public ushort? port
    {
      get => this.portField;
      set => this.portField = value;
    }

    public string state
    {
      get => this.stateField;
      set => this.stateField = value;
    }

    public uint? hashid
    {
      get => this.hashidField;
      set => this.hashidField = value;
    }

    public uint? serverid
    {
      get => this.serveridField;
      set => this.serveridField = value;
    }

    public string customserverid
    {
      get => this.customserveridField;
      set => this.customserveridField = value;
    }

    public uint? weight
    {
      get => this.weightField;
      set => this.weightField = value;
    }

    public string monitor_name
    {
      get => this.monitor_nameField;
      set => this.monitor_nameField = value;
    }

    public bool? passive
    {
      get => this.passiveField;
      set => this.passiveField = value;
    }

    public string lastresponse
    {
      get => this.lastresponseField;
      private set => this.lastresponseField = value;
    }

    public string monitor_state
    {
      get => this.monitor_stateField;
      private set => this.monitor_stateField = value;
    }

    public uint? monitortotalprobes
    {
      get => this.monitortotalprobesField;
      private set => this.monitortotalprobesField = value;
    }

    public uint? monitortotalfailedprobes
    {
      get => this.monitortotalfailedprobesField;
      private set => this.monitortotalfailedprobesField = value;
    }

    public uint? monitorcurrentfailedprobes
    {
      get => this.monitorcurrentfailedprobesField;
      private set => this.monitorcurrentfailedprobesField = value;
    }

    internal override base_resource[] get_nitro_response(
      nitro_service service,
      string response)
    {
      servicegroup_servicegroupentitymonbindings_binding.servicegroup_servicegroupentitymonbindings_binding_response servicegroupentitymonbindingsBindingResponse = new servicegroup_servicegroupentitymonbindings_binding.servicegroup_servicegroupentitymonbindings_binding_response();
      servicegroup_servicegroupentitymonbindings_binding.servicegroup_servicegroupentitymonbindings_binding_response resource = (servicegroup_servicegroupentitymonbindings_binding.servicegroup_servicegroupentitymonbindings_binding_response) service.get_payload_formatter().string_to_resource(servicegroupentitymonbindingsBindingResponse.GetType(), response);
      if (resource.errorcode != 0)
      {
        if (resource.errorcode == 444)
          service.clear_session();
        if (resource.severity == null)
          throw new nitro_exception(resource.message, resource.errorcode);
        if (resource.severity.Equals("ERROR"))
          throw new nitro_exception(resource.message, resource.errorcode);
      }
      return (base_resource[]) resource.servicegroup_servicegroupentitymonbindings_binding;
    }

    internal override string get_object_name() => this.servicegroupname;

    public static servicegroup_servicegroupentitymonbindings_binding[] get(
      nitro_service service,
      string servicegroupname)
    {
      return (servicegroup_servicegroupentitymonbindings_binding[]) new servicegroup_servicegroupentitymonbindings_binding()
      {
        servicegroupname = servicegroupname
      }.get_resources(service, (options) null);
    }

    public static servicegroup_servicegroupentitymonbindings_binding[] get_filtered(
      nitro_service service,
      string servicegroupname,
      string filter)
    {
      servicegroup_servicegroupentitymonbindings_binding servicegroupentitymonbindingsBinding = new servicegroup_servicegroupentitymonbindings_binding();
      servicegroupentitymonbindingsBinding.servicegroupname = servicegroupname;
      options option = new options();
      option.set_filter(filter);
      return (servicegroup_servicegroupentitymonbindings_binding[]) servicegroupentitymonbindingsBinding.getfiltered(service, option);
    }

    public static servicegroup_servicegroupentitymonbindings_binding[] get_filtered(
      nitro_service service,
      string servicegroupname,
      filtervalue[] filter)
    {
      servicegroup_servicegroupentitymonbindings_binding servicegroupentitymonbindingsBinding = new servicegroup_servicegroupentitymonbindings_binding();
      servicegroupentitymonbindingsBinding.servicegroupname = servicegroupname;
      options option = new options();
      option.set_filter(filter);
      return (servicegroup_servicegroupentitymonbindings_binding[]) servicegroupentitymonbindingsBinding.getfiltered(service, option);
    }

    public static uint count(nitro_service service, string servicegroupname)
    {
      servicegroup_servicegroupentitymonbindings_binding servicegroupentitymonbindingsBinding = new servicegroup_servicegroupentitymonbindings_binding();
      servicegroupentitymonbindingsBinding.servicegroupname = servicegroupname;
      options option = new options();
      option.set_count(true);
      servicegroup_servicegroupentitymonbindings_binding[] resources = (servicegroup_servicegroupentitymonbindings_binding[]) servicegroupentitymonbindingsBinding.get_resources(service, option);
      return resources != null && resources.Length > 0 ? resources[0].__count.Value : 0U;
    }

    public static uint count_filtered(
      nitro_service service,
      string servicegroupname,
      string filter)
    {
      servicegroup_servicegroupentitymonbindings_binding servicegroupentitymonbindingsBinding = new servicegroup_servicegroupentitymonbindings_binding();
      servicegroupentitymonbindingsBinding.servicegroupname = servicegroupname;
      options option = new options();
      option.set_count(true);
      option.set_filter(filter);
      servicegroup_servicegroupentitymonbindings_binding[] servicegroupentitymonbindingsBindingArray = (servicegroup_servicegroupentitymonbindings_binding[]) servicegroupentitymonbindingsBinding.getfiltered(service, option);
      return servicegroupentitymonbindingsBindingArray != null && servicegroupentitymonbindingsBindingArray.Length > 0 ? servicegroupentitymonbindingsBindingArray[0].__count.Value : 0U;
    }

    public static uint count_filtered(
      nitro_service service,
      string servicegroupname,
      filtervalue[] filter)
    {
      servicegroup_servicegroupentitymonbindings_binding servicegroupentitymonbindingsBinding = new servicegroup_servicegroupentitymonbindings_binding();
      servicegroupentitymonbindingsBinding.servicegroupname = servicegroupname;
      options option = new options();
      option.set_count(true);
      option.set_filter(filter);
      servicegroup_servicegroupentitymonbindings_binding[] servicegroupentitymonbindingsBindingArray = (servicegroup_servicegroupentitymonbindings_binding[]) servicegroupentitymonbindingsBinding.getfiltered(service, option);
      return servicegroupentitymonbindingsBindingArray != null && servicegroupentitymonbindingsBindingArray.Length > 0 ? servicegroupentitymonbindingsBindingArray[0].__count.Value : 0U;
    }

    private class servicegroup_servicegroupentitymonbindings_binding_response : base_response
    {
      public servicegroup_servicegroupentitymonbindings_binding[] servicegroup_servicegroupentitymonbindings_binding = (servicegroup_servicegroupentitymonbindings_binding[]) null;
    }

    public static class monitor_stateEnum
    {
      public const string UP = "UP";
      public const string DOWN = "DOWN";
      public const string UNKNOWN = "UNKNOWN";
      public const string BUSY = "BUSY";
      public const string OUT_OF_SERVICE = "OUT OF SERVICE";
      public const string GOING_OUT_OF_SERVICE = "GOING OUT OF SERVICE";
      public const string DOWN_WHEN_GOING_OUT_OF_SERVICE = "DOWN WHEN GOING OUT OF SERVICE";
      public const string NS_EMPTY_STR = "NS_EMPTY_STR";
      public const string Unknown = "Unknown";
      public const string DISABLED = "DISABLED";
    }

    public static class stateEnum
    {
      public const string ENABLED = "ENABLED";
      public const string DISABLED = "DISABLED";
    }

    public static class monstateEnum
    {
      public const string ENABLED = "ENABLED";
      public const string DISABLED = "DISABLED";
    }
  }
}
