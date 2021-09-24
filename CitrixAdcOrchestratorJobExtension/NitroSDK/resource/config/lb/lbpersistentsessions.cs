// Decompiled with JetBrains decompiler
// Type: com.citrix.netscaler.nitro.resource.config.lb.lbpersistentsessions
// Assembly: nitro, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 6CF5DDEF-E052-4F9D-953F-6644F8378A66


using com.citrix.netscaler.nitro.exception;
using com.citrix.netscaler.nitro.resource.Base;
using com.citrix.netscaler.nitro.service;
using com.citrix.netscaler.nitro.util;

namespace com.citrix.netscaler.nitro.resource.config.lb
{
  public class lbpersistentsessions : base_resource
  {
    private string vserverField = (string) null;
    private string persistenceparameterField = (string) null;
    private uint? typeField = new uint?();
    private string typestringField = (string) null;
    private string srcipField = (string) null;
    private string srcipv6Field = (string) null;
    private string destipField = (string) null;
    private string destipv6Field = (string) null;
    private bool? flagsField = new bool?();
    private ushort? destportField = new ushort?();
    private string vservernameField = (string) null;
    private uint? timeoutField = new uint?();
    private uint? referencecountField = new uint?();
    private string persistenceparamField = (string) null;
    private string cnamepersparamField = (string) null;
    private uint? __countField = new uint?();

    public uint? __count
    {
      get => this.__countField;
      private set => this.__countField = value;
    }

    public string vserver
    {
      get => this.vserverField;
      set => this.vserverField = value;
    }

    public string persistenceparameter
    {
      get => this.persistenceparameterField;
      set => this.persistenceparameterField = value;
    }

    public uint? type
    {
      get => this.typeField;
      private set => this.typeField = value;
    }

    public string typestring
    {
      get => this.typestringField;
      private set => this.typestringField = value;
    }

    public string srcip
    {
      get => this.srcipField;
      private set => this.srcipField = value;
    }

    public string srcipv6
    {
      get => this.srcipv6Field;
      private set => this.srcipv6Field = value;
    }

    public string destip
    {
      get => this.destipField;
      private set => this.destipField = value;
    }

    public string destipv6
    {
      get => this.destipv6Field;
      private set => this.destipv6Field = value;
    }

    public bool? flags
    {
      get => this.flagsField;
      private set => this.flagsField = value;
    }

    public ushort? destport
    {
      get => this.destportField;
      private set => this.destportField = value;
    }

    public string vservername
    {
      get => this.vservernameField;
      private set => this.vservernameField = value;
    }

    public uint? timeout
    {
      get => this.timeoutField;
      private set => this.timeoutField = value;
    }

    public uint? referencecount
    {
      get => this.referencecountField;
      private set => this.referencecountField = value;
    }

    public string persistenceparam
    {
      get => this.persistenceparamField;
      private set => this.persistenceparamField = value;
    }

    public string cnamepersparam
    {
      get => this.cnamepersparamField;
      private set => this.cnamepersparamField = value;
    }

    internal override base_resource[] get_nitro_response(
      nitro_service service,
      string response)
    {
      lbpersistentsessions.lbpersistentsessions_response lbpersistentsessionsResponse = new lbpersistentsessions.lbpersistentsessions_response();
      lbpersistentsessions.lbpersistentsessions_response resource = (lbpersistentsessions.lbpersistentsessions_response) service.get_payload_formatter().string_to_resource(lbpersistentsessionsResponse.GetType(), response);
      if (resource.errorcode != 0)
      {
        if (resource.errorcode == 444)
          service.clear_session();
        if (resource.severity == null)
          throw new nitro_exception(resource.message, resource.errorcode);
        if (resource.severity.Equals("ERROR"))
          throw new nitro_exception(resource.message, resource.errorcode);
      }
      return (base_resource[]) resource.lbpersistentsessions;
    }

    internal override string get_object_name() => (string) null;

    public static base_response clear(
      nitro_service client,
      lbpersistentsessions resource)
    {
      return new lbpersistentsessions()
      {
        vserver = resource.vserver,
        persistenceparameter = resource.persistenceparameter
      }.perform_operation_byaction(client, nameof (clear));
    }

    public static base_responses clear(
      nitro_service client,
      lbpersistentsessions[] resources)
    {
      base_responses baseResponses = (base_responses) null;
      if (resources != null && resources.Length > 0)
      {
        lbpersistentsessions[] lbpersistentsessionsArray = new lbpersistentsessions[resources.Length];
        for (int index = 0; index < resources.Length; ++index)
        {
          lbpersistentsessionsArray[index] = new lbpersistentsessions();
          lbpersistentsessionsArray[index].vserver = resources[index].vserver;
          lbpersistentsessionsArray[index].persistenceparameter = resources[index].persistenceparameter;
        }
        baseResponses = base_resource.perform_operation_bulk_request(client, (base_resource[]) lbpersistentsessionsArray, nameof (clear));
      }
      return baseResponses;
    }

    public static lbpersistentsessions[] get(nitro_service service) => (lbpersistentsessions[]) new lbpersistentsessions().get_resources(service, (options) null);

    public static lbpersistentsessions[] get(
      nitro_service service,
      options option)
    {
      return (lbpersistentsessions[]) new lbpersistentsessions().get_resources(service, option);
    }

    public static lbpersistentsessions[] get(
      nitro_service service,
      lbpersistentsessions_args args)
    {
      lbpersistentsessions lbpersistentsessions = new lbpersistentsessions();
      options option = new options();
      option.set_args(nitro_util.object_to_string_withoutquotes((object) args));
      return (lbpersistentsessions[]) lbpersistentsessions.get_resources(service, option);
    }

    public static lbpersistentsessions[] get_filtered(
      nitro_service service,
      string filter)
    {
      lbpersistentsessions lbpersistentsessions = new lbpersistentsessions();
      options option = new options();
      option.set_filter(filter);
      return (lbpersistentsessions[]) lbpersistentsessions.getfiltered(service, option);
    }

    public static lbpersistentsessions[] get_filtered(
      nitro_service service,
      filtervalue[] filter)
    {
      lbpersistentsessions lbpersistentsessions = new lbpersistentsessions();
      options option = new options();
      option.set_filter(filter);
      return (lbpersistentsessions[]) lbpersistentsessions.getfiltered(service, option);
    }

    public static uint count(nitro_service service)
    {
      lbpersistentsessions lbpersistentsessions = new lbpersistentsessions();
      options option = new options();
      option.set_count(true);
      lbpersistentsessions[] resources = (lbpersistentsessions[]) lbpersistentsessions.get_resources(service, option);
      return resources != null && resources.Length > 0 ? resources[0].__count.Value : 0U;
    }

    public static uint count_filtered(nitro_service service, string filter)
    {
      lbpersistentsessions lbpersistentsessions = new lbpersistentsessions();
      options option = new options();
      option.set_count(true);
      option.set_filter(filter);
      lbpersistentsessions[] lbpersistentsessionsArray = (lbpersistentsessions[]) lbpersistentsessions.getfiltered(service, option);
      return lbpersistentsessionsArray != null && lbpersistentsessionsArray.Length > 0 ? lbpersistentsessionsArray[0].__count.Value : 0U;
    }

    public static uint count_filtered(nitro_service service, filtervalue[] filter)
    {
      lbpersistentsessions lbpersistentsessions = new lbpersistentsessions();
      options option = new options();
      option.set_count(true);
      option.set_filter(filter);
      lbpersistentsessions[] lbpersistentsessionsArray = (lbpersistentsessions[]) lbpersistentsessions.getfiltered(service, option);
      return lbpersistentsessionsArray != null && lbpersistentsessionsArray.Length > 0 ? lbpersistentsessionsArray[0].__count.Value : 0U;
    }

    private class lbpersistentsessions_response : base_response
    {
      public lbpersistentsessions[] lbpersistentsessions = (lbpersistentsessions[]) null;
    }
  }
}
