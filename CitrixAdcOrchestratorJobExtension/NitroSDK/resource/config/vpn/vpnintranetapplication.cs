// Decompiled with JetBrains decompiler
// Type: com.citrix.netscaler.nitro.resource.config.vpn.vpnintranetapplication
// Assembly: nitro, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 6CF5DDEF-E052-4F9D-953F-6644F8378A66


using com.citrix.netscaler.nitro.exception;
using com.citrix.netscaler.nitro.resource.Base;
using com.citrix.netscaler.nitro.service;
using com.citrix.netscaler.nitro.util;

namespace com.citrix.netscaler.nitro.resource.config.vpn
{
  public class vpnintranetapplication : base_resource
  {
    private string intranetapplicationField = (string) null;
    private string protocolField = (string) null;
    private string destipField = (string) null;
    private string netmaskField = (string) null;
    private string iprangeField = (string) null;
    private string hostnameField = (string) null;
    private string[] clientapplicationField = (string[]) null;
    private string spoofiipField = (string) null;
    private string destportField = (string) null;
    private string interceptionField = (string) null;
    private string srcipField = (string) null;
    private ushort? srcportField = new ushort?();
    private string ipaddressField = (string) null;
    private uint? __countField = new uint?();

    public uint? __count
    {
      get => this.__countField;
      private set => this.__countField = value;
    }

    public string intranetapplication
    {
      get => this.intranetapplicationField;
      set => this.intranetapplicationField = value;
    }

    public string protocol
    {
      get => this.protocolField;
      set => this.protocolField = value;
    }

    public string destip
    {
      get => this.destipField;
      set => this.destipField = value;
    }

    public string netmask
    {
      get => this.netmaskField;
      set => this.netmaskField = value;
    }

    public string iprange
    {
      get => this.iprangeField;
      set => this.iprangeField = value;
    }

    public string hostname
    {
      get => this.hostnameField;
      set => this.hostnameField = value;
    }

    public string[] clientapplication
    {
      get => this.clientapplicationField;
      set => this.clientapplicationField = value;
    }

    public string spoofiip
    {
      get => this.spoofiipField;
      set => this.spoofiipField = value;
    }

    public string destport
    {
      get => this.destportField;
      set => this.destportField = value;
    }

    public string interception
    {
      get => this.interceptionField;
      set => this.interceptionField = value;
    }

    public string srcip
    {
      get => this.srcipField;
      set => this.srcipField = value;
    }

    public ushort? srcport
    {
      get => this.srcportField;
      set => this.srcportField = value;
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
      vpnintranetapplication.vpnintranetapplication_response vpnintranetapplicationResponse = new vpnintranetapplication.vpnintranetapplication_response();
      vpnintranetapplication.vpnintranetapplication_response resource = (vpnintranetapplication.vpnintranetapplication_response) service.get_payload_formatter().string_to_resource(vpnintranetapplicationResponse.GetType(), response);
      if (resource.errorcode != 0)
      {
        if (resource.errorcode == 444)
          service.clear_session();
        if (resource.severity == null)
          throw new nitro_exception(resource.message, resource.errorcode);
        if (resource.severity.Equals("ERROR"))
          throw new nitro_exception(resource.message, resource.errorcode);
      }
      return (base_resource[]) resource.vpnintranetapplication;
    }

    internal override string get_object_name() => this.intranetapplication;

    public static base_response add(
      nitro_service client,
      vpnintranetapplication resource)
    {
      return new vpnintranetapplication()
      {
        intranetapplication = resource.intranetapplication,
        protocol = resource.protocol,
        destip = resource.destip,
        netmask = resource.netmask,
        iprange = resource.iprange,
        hostname = resource.hostname,
        clientapplication = resource.clientapplication,
        spoofiip = resource.spoofiip,
        destport = resource.destport,
        interception = resource.interception,
        srcip = resource.srcip,
        srcport = resource.srcport
      }.add_resource(client);
    }

    public static base_responses add(
      nitro_service client,
      vpnintranetapplication[] resources)
    {
      base_responses baseResponses = (base_responses) null;
      if (resources != null && resources.Length > 0)
      {
        vpnintranetapplication[] vpnintranetapplicationArray = new vpnintranetapplication[resources.Length];
        for (int index = 0; index < resources.Length; ++index)
        {
          vpnintranetapplicationArray[index] = new vpnintranetapplication();
          vpnintranetapplicationArray[index].intranetapplication = resources[index].intranetapplication;
          vpnintranetapplicationArray[index].protocol = resources[index].protocol;
          vpnintranetapplicationArray[index].destip = resources[index].destip;
          vpnintranetapplicationArray[index].netmask = resources[index].netmask;
          vpnintranetapplicationArray[index].iprange = resources[index].iprange;
          vpnintranetapplicationArray[index].hostname = resources[index].hostname;
          vpnintranetapplicationArray[index].clientapplication = resources[index].clientapplication;
          vpnintranetapplicationArray[index].spoofiip = resources[index].spoofiip;
          vpnintranetapplicationArray[index].destport = resources[index].destport;
          vpnintranetapplicationArray[index].interception = resources[index].interception;
          vpnintranetapplicationArray[index].srcip = resources[index].srcip;
          vpnintranetapplicationArray[index].srcport = resources[index].srcport;
        }
        baseResponses = base_resource.add_bulk_request(client, (base_resource[]) vpnintranetapplicationArray);
      }
      return baseResponses;
    }

    public static base_response delete(
      nitro_service client,
      string intranetapplication)
    {
      return new vpnintranetapplication()
      {
        intranetapplication = intranetapplication
      }.delete_resource(client);
    }

    public static base_response delete(
      nitro_service client,
      vpnintranetapplication resource)
    {
      return new vpnintranetapplication()
      {
        intranetapplication = resource.intranetapplication
      }.delete_resource(client);
    }

    public static base_responses delete(
      nitro_service client,
      string[] intranetapplication)
    {
      base_responses baseResponses = (base_responses) null;
      if (intranetapplication != null && intranetapplication.Length > 0)
      {
        vpnintranetapplication[] vpnintranetapplicationArray = new vpnintranetapplication[intranetapplication.Length];
        for (int index = 0; index < intranetapplication.Length; ++index)
        {
          vpnintranetapplicationArray[index] = new vpnintranetapplication();
          vpnintranetapplicationArray[index].intranetapplication = intranetapplication[index];
        }
        baseResponses = base_resource.delete_bulk_request(client, (base_resource[]) vpnintranetapplicationArray);
      }
      return baseResponses;
    }

    public static base_responses delete(
      nitro_service client,
      vpnintranetapplication[] resources)
    {
      base_responses baseResponses = (base_responses) null;
      if (resources != null && resources.Length > 0)
      {
        vpnintranetapplication[] vpnintranetapplicationArray = new vpnintranetapplication[resources.Length];
        for (int index = 0; index < resources.Length; ++index)
        {
          vpnintranetapplicationArray[index] = new vpnintranetapplication();
          vpnintranetapplicationArray[index].intranetapplication = resources[index].intranetapplication;
        }
        baseResponses = base_resource.delete_bulk_request(client, (base_resource[]) vpnintranetapplicationArray);
      }
      return baseResponses;
    }

    public static vpnintranetapplication[] get(nitro_service service) => (vpnintranetapplication[]) new vpnintranetapplication().get_resources(service, (options) null);

    public static vpnintranetapplication[] get(
      nitro_service service,
      options option)
    {
      return (vpnintranetapplication[]) new vpnintranetapplication().get_resources(service, option);
    }

    public static vpnintranetapplication get(
      nitro_service service,
      string intranetapplication)
    {
      return (vpnintranetapplication) new vpnintranetapplication()
      {
        intranetapplication = intranetapplication
      }.get_resource(service);
    }

    public static vpnintranetapplication[] get(
      nitro_service service,
      string[] intranetapplication)
    {
      if (intranetapplication == null || intranetapplication.Length <= 0)
        return (vpnintranetapplication[]) null;
      vpnintranetapplication[] vpnintranetapplicationArray1 = new vpnintranetapplication[intranetapplication.Length];
      vpnintranetapplication[] vpnintranetapplicationArray2 = new vpnintranetapplication[intranetapplication.Length];
      for (int index = 0; index < intranetapplication.Length; ++index)
      {
        vpnintranetapplicationArray2[index] = new vpnintranetapplication();
        vpnintranetapplicationArray2[index].intranetapplication = intranetapplication[index];
        vpnintranetapplicationArray1[index] = (vpnintranetapplication) vpnintranetapplicationArray2[index].get_resource(service);
      }
      return vpnintranetapplicationArray1;
    }

    public static vpnintranetapplication[] get_filtered(
      nitro_service service,
      string filter)
    {
      vpnintranetapplication vpnintranetapplication = new vpnintranetapplication();
      options option = new options();
      option.set_filter(filter);
      return (vpnintranetapplication[]) vpnintranetapplication.getfiltered(service, option);
    }

    public static vpnintranetapplication[] get_filtered(
      nitro_service service,
      filtervalue[] filter)
    {
      vpnintranetapplication vpnintranetapplication = new vpnintranetapplication();
      options option = new options();
      option.set_filter(filter);
      return (vpnintranetapplication[]) vpnintranetapplication.getfiltered(service, option);
    }

    public static uint count(nitro_service service)
    {
      vpnintranetapplication vpnintranetapplication = new vpnintranetapplication();
      options option = new options();
      option.set_count(true);
      vpnintranetapplication[] resources = (vpnintranetapplication[]) vpnintranetapplication.get_resources(service, option);
      return resources != null && resources.Length > 0 ? resources[0].__count.Value : 0U;
    }

    public static uint count_filtered(nitro_service service, string filter)
    {
      vpnintranetapplication vpnintranetapplication = new vpnintranetapplication();
      options option = new options();
      option.set_count(true);
      option.set_filter(filter);
      vpnintranetapplication[] vpnintranetapplicationArray = (vpnintranetapplication[]) vpnintranetapplication.getfiltered(service, option);
      return vpnintranetapplicationArray != null && vpnintranetapplicationArray.Length > 0 ? vpnintranetapplicationArray[0].__count.Value : 0U;
    }

    public static uint count_filtered(nitro_service service, filtervalue[] filter)
    {
      vpnintranetapplication vpnintranetapplication = new vpnintranetapplication();
      options option = new options();
      option.set_count(true);
      option.set_filter(filter);
      vpnintranetapplication[] vpnintranetapplicationArray = (vpnintranetapplication[]) vpnintranetapplication.getfiltered(service, option);
      return vpnintranetapplicationArray != null && vpnintranetapplicationArray.Length > 0 ? vpnintranetapplicationArray[0].__count.Value : 0U;
    }

    private class vpnintranetapplication_response : base_response
    {
      public vpnintranetapplication[] vpnintranetapplication = (vpnintranetapplication[]) null;
    }

    public static class spoofiipEnum
    {
      public const string ON = "ON";
      public const string OFF = "OFF";
    }

    public static class protocolEnum
    {
      public const string TCP = "TCP";
      public const string UDP = "UDP";
      public const string ANY = "ANY";
    }

    public static class interceptionEnum
    {
      public const string PROXY = "PROXY";
      public const string TRANSPARENT = "TRANSPARENT";
    }
  }
}
