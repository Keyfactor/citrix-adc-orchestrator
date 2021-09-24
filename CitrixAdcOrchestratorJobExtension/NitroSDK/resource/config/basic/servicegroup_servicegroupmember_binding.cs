// Decompiled with JetBrains decompiler
// Type: com.citrix.netscaler.nitro.resource.config.basic.servicegroup_servicegroupmember_binding
// Assembly: nitro, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 6CF5DDEF-E052-4F9D-953F-6644F8378A66


using com.citrix.netscaler.nitro.exception;
using com.citrix.netscaler.nitro.resource.Base;
using com.citrix.netscaler.nitro.service;
using com.citrix.netscaler.nitro.util;

namespace com.citrix.netscaler.nitro.resource.config.basic
{
  public class servicegroup_servicegroupmember_binding : base_resource
  {
    private string ipField = (string) null;
    private ushort? portField = new ushort?();
    private string svrstateField = (string) null;
    private string statechangetimesecField = (string) null;
    private uint? tickssincelaststatechangeField = new uint?();
    private uint? weightField = new uint?();
    private string servernameField = (string) null;
    private string customserveridField = (string) null;
    private uint? serveridField = new uint?();
    private string stateField = (string) null;
    private uint? hashidField = new uint?();
    private string gracefulField = (string) null;
    private long? delayField = new long?();
    private string servicegroupnameField = (string) null;
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

    public string ip
    {
      get => this.ipField;
      set => this.ipField = value;
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

    public string servername
    {
      get => this.servernameField;
      set => this.servernameField = value;
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

    public long? delay
    {
      get => this.delayField;
      private set => this.delayField = value;
    }

    public string statechangetimesec
    {
      get => this.statechangetimesecField;
      private set => this.statechangetimesecField = value;
    }

    public string svrstate
    {
      get => this.svrstateField;
      private set => this.svrstateField = value;
    }

    public uint? tickssincelaststatechange
    {
      get => this.tickssincelaststatechangeField;
      private set => this.tickssincelaststatechangeField = value;
    }

    public string graceful
    {
      get => this.gracefulField;
      private set => this.gracefulField = value;
    }

    internal override base_resource[] get_nitro_response(
      nitro_service service,
      string response)
    {
      servicegroup_servicegroupmember_binding.servicegroup_servicegroupmember_binding_response servicegroupmemberBindingResponse = new servicegroup_servicegroupmember_binding.servicegroup_servicegroupmember_binding_response();
      servicegroup_servicegroupmember_binding.servicegroup_servicegroupmember_binding_response resource = (servicegroup_servicegroupmember_binding.servicegroup_servicegroupmember_binding_response) service.get_payload_formatter().string_to_resource(servicegroupmemberBindingResponse.GetType(), response);
      if (resource.errorcode != 0)
      {
        if (resource.errorcode == 444)
          service.clear_session();
        if (resource.severity == null)
          throw new nitro_exception(resource.message, resource.errorcode);
        if (resource.severity.Equals("ERROR"))
          throw new nitro_exception(resource.message, resource.errorcode);
      }
      return (base_resource[]) resource.servicegroup_servicegroupmember_binding;
    }

    internal override string get_object_name() => this.servicegroupname;

    public static base_response add(
      nitro_service client,
      servicegroup_servicegroupmember_binding resource)
    {
      return new servicegroup_servicegroupmember_binding()
      {
        servicegroupname = resource.servicegroupname,
        ip = resource.ip,
        servername = resource.servername,
        port = resource.port,
        weight = resource.weight,
        customserverid = resource.customserverid,
        serverid = resource.serverid,
        state = resource.state,
        hashid = resource.hashid
      }.update_resource(client);
    }

    public static base_responses add(
      nitro_service client,
      servicegroup_servicegroupmember_binding[] resources)
    {
      base_responses baseResponses = (base_responses) null;
      if (resources != null && resources.Length > 0)
      {
        servicegroup_servicegroupmember_binding[] servicegroupmemberBindingArray = new servicegroup_servicegroupmember_binding[resources.Length];
        for (int index = 0; index < resources.Length; ++index)
        {
          servicegroupmemberBindingArray[index] = new servicegroup_servicegroupmember_binding();
          servicegroupmemberBindingArray[index].servicegroupname = resources[index].servicegroupname;
          servicegroupmemberBindingArray[index].ip = resources[index].ip;
          servicegroupmemberBindingArray[index].servername = resources[index].servername;
          servicegroupmemberBindingArray[index].port = resources[index].port;
          servicegroupmemberBindingArray[index].weight = resources[index].weight;
          servicegroupmemberBindingArray[index].customserverid = resources[index].customserverid;
          servicegroupmemberBindingArray[index].serverid = resources[index].serverid;
          servicegroupmemberBindingArray[index].state = resources[index].state;
          servicegroupmemberBindingArray[index].hashid = resources[index].hashid;
        }
        baseResponses = base_resource.update_bulk_request(client, (base_resource[]) servicegroupmemberBindingArray);
      }
      return baseResponses;
    }

    public static base_response delete(
      nitro_service client,
      servicegroup_servicegroupmember_binding resource)
    {
      return new servicegroup_servicegroupmember_binding()
      {
        servicegroupname = resource.servicegroupname,
        ip = resource.ip,
        servername = resource.servername,
        port = resource.port
      }.delete_resource(client);
    }

    public static base_responses delete(
      nitro_service client,
      servicegroup_servicegroupmember_binding[] resources)
    {
      base_responses baseResponses = (base_responses) null;
      if (resources != null && resources.Length > 0)
      {
        servicegroup_servicegroupmember_binding[] servicegroupmemberBindingArray = new servicegroup_servicegroupmember_binding[resources.Length];
        for (int index = 0; index < resources.Length; ++index)
        {
          servicegroupmemberBindingArray[index] = new servicegroup_servicegroupmember_binding();
          servicegroupmemberBindingArray[index].servicegroupname = resources[index].servicegroupname;
          servicegroupmemberBindingArray[index].ip = resources[index].ip;
          servicegroupmemberBindingArray[index].servername = resources[index].servername;
          servicegroupmemberBindingArray[index].port = resources[index].port;
        }
        baseResponses = base_resource.delete_bulk_request(client, (base_resource[]) servicegroupmemberBindingArray);
      }
      return baseResponses;
    }

    public static servicegroup_servicegroupmember_binding[] get(
      nitro_service service,
      string servicegroupname)
    {
      return (servicegroup_servicegroupmember_binding[]) new servicegroup_servicegroupmember_binding()
      {
        servicegroupname = servicegroupname
      }.get_resources(service, (options) null);
    }

    public static servicegroup_servicegroupmember_binding[] get_filtered(
      nitro_service service,
      string servicegroupname,
      string filter)
    {
      servicegroup_servicegroupmember_binding servicegroupmemberBinding = new servicegroup_servicegroupmember_binding();
      servicegroupmemberBinding.servicegroupname = servicegroupname;
      options option = new options();
      option.set_filter(filter);
      return (servicegroup_servicegroupmember_binding[]) servicegroupmemberBinding.getfiltered(service, option);
    }

    public static servicegroup_servicegroupmember_binding[] get_filtered(
      nitro_service service,
      string servicegroupname,
      filtervalue[] filter)
    {
      servicegroup_servicegroupmember_binding servicegroupmemberBinding = new servicegroup_servicegroupmember_binding();
      servicegroupmemberBinding.servicegroupname = servicegroupname;
      options option = new options();
      option.set_filter(filter);
      return (servicegroup_servicegroupmember_binding[]) servicegroupmemberBinding.getfiltered(service, option);
    }

    public static uint count(nitro_service service, string servicegroupname)
    {
      servicegroup_servicegroupmember_binding servicegroupmemberBinding = new servicegroup_servicegroupmember_binding();
      servicegroupmemberBinding.servicegroupname = servicegroupname;
      options option = new options();
      option.set_count(true);
      servicegroup_servicegroupmember_binding[] resources = (servicegroup_servicegroupmember_binding[]) servicegroupmemberBinding.get_resources(service, option);
      return resources != null && resources.Length > 0 ? resources[0].__count.Value : 0U;
    }

    public static uint count_filtered(
      nitro_service service,
      string servicegroupname,
      string filter)
    {
      servicegroup_servicegroupmember_binding servicegroupmemberBinding = new servicegroup_servicegroupmember_binding();
      servicegroupmemberBinding.servicegroupname = servicegroupname;
      options option = new options();
      option.set_count(true);
      option.set_filter(filter);
      servicegroup_servicegroupmember_binding[] servicegroupmemberBindingArray = (servicegroup_servicegroupmember_binding[]) servicegroupmemberBinding.getfiltered(service, option);
      return servicegroupmemberBindingArray != null && servicegroupmemberBindingArray.Length > 0 ? servicegroupmemberBindingArray[0].__count.Value : 0U;
    }

    public static uint count_filtered(
      nitro_service service,
      string servicegroupname,
      filtervalue[] filter)
    {
      servicegroup_servicegroupmember_binding servicegroupmemberBinding = new servicegroup_servicegroupmember_binding();
      servicegroupmemberBinding.servicegroupname = servicegroupname;
      options option = new options();
      option.set_count(true);
      option.set_filter(filter);
      servicegroup_servicegroupmember_binding[] servicegroupmemberBindingArray = (servicegroup_servicegroupmember_binding[]) servicegroupmemberBinding.getfiltered(service, option);
      return servicegroupmemberBindingArray != null && servicegroupmemberBindingArray.Length > 0 ? servicegroupmemberBindingArray[0].__count.Value : 0U;
    }

    private class servicegroup_servicegroupmember_binding_response : base_response
    {
      public servicegroup_servicegroupmember_binding[] servicegroup_servicegroupmember_binding = (servicegroup_servicegroupmember_binding[]) null;
    }

    public static class svrstateEnum
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

    public static class gracefulEnum
    {
      public const string YES = "YES";
      public const string NO = "NO";
    }
  }
}
