// Decompiled with JetBrains decompiler
// Type: com.citrix.netscaler.nitro.resource.config.subscriber.subscribersessions
// Assembly: nitro, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 6CF5DDEF-E052-4F9D-953F-6644F8378A66


using com.citrix.netscaler.nitro.exception;
using com.citrix.netscaler.nitro.resource.Base;
using com.citrix.netscaler.nitro.service;
using com.citrix.netscaler.nitro.util;

namespace com.citrix.netscaler.nitro.resource.config.subscriber
{
  public class subscribersessions : base_resource
  {
    private string ipField = (string) null;
    private string subscriptionidtypeField = (string) null;
    private string subscriptionidvalueField = (string) null;
    private string[] subscriberrulesField = (string[]) null;
    private uint? flagsField = new uint?();
    private uint? ttlField = new uint?();
    private uint? idlettlField = new uint?();
    private string avpdisplaybufferField = (string) null;
    private string servicepathField = (string) null;
    private uint? __countField = new uint?();

    public uint? __count
    {
      get => this.__countField;
      private set => this.__countField = value;
    }

    public string ip
    {
      get => this.ipField;
      set => this.ipField = value;
    }

    public string subscriptionidtype
    {
      get => this.subscriptionidtypeField;
      private set => this.subscriptionidtypeField = value;
    }

    public string subscriptionidvalue
    {
      get => this.subscriptionidvalueField;
      private set => this.subscriptionidvalueField = value;
    }

    public string[] subscriberrules
    {
      get => this.subscriberrulesField;
      private set => this.subscriberrulesField = value;
    }

    public uint? flags
    {
      get => this.flagsField;
      private set => this.flagsField = value;
    }

    public uint? ttl
    {
      get => this.ttlField;
      private set => this.ttlField = value;
    }

    public uint? idlettl
    {
      get => this.idlettlField;
      private set => this.idlettlField = value;
    }

    public string avpdisplaybuffer
    {
      get => this.avpdisplaybufferField;
      private set => this.avpdisplaybufferField = value;
    }

    public string servicepath
    {
      get => this.servicepathField;
      private set => this.servicepathField = value;
    }

    internal override base_resource[] get_nitro_response(
      nitro_service service,
      string response)
    {
      subscribersessions.subscribersessions_response subscribersessionsResponse = new subscribersessions.subscribersessions_response();
      subscribersessions.subscribersessions_response resource = (subscribersessions.subscribersessions_response) service.get_payload_formatter().string_to_resource(subscribersessionsResponse.GetType(), response);
      if (resource.errorcode != 0)
      {
        if (resource.errorcode == 444)
          service.clear_session();
        if (resource.severity == null)
          throw new nitro_exception(resource.message, resource.errorcode);
        if (resource.severity.Equals("ERROR"))
          throw new nitro_exception(resource.message, resource.errorcode);
      }
      return (base_resource[]) resource.subscribersessions;
    }

    internal override string get_object_name() => (string) null;

    public static base_response clear(
      nitro_service client,
      subscribersessions resource)
    {
      return new subscribersessions() { ip = resource.ip }.perform_operation_byaction(client, nameof (clear));
    }

    public static base_responses clear(
      nitro_service client,
      subscribersessions[] resources)
    {
      base_responses baseResponses = (base_responses) null;
      if (resources != null && resources.Length > 0)
      {
        subscribersessions[] subscribersessionsArray = new subscribersessions[resources.Length];
        for (int index = 0; index < resources.Length; ++index)
        {
          subscribersessionsArray[index] = new subscribersessions();
          subscribersessionsArray[index].ip = resources[index].ip;
        }
        baseResponses = base_resource.perform_operation_bulk_request(client, (base_resource[]) subscribersessionsArray, nameof (clear));
      }
      return baseResponses;
    }

    public static subscribersessions[] get(nitro_service service) => (subscribersessions[]) new subscribersessions().get_resources(service, (options) null);

    public static subscribersessions[] get(nitro_service service, options option) => (subscribersessions[]) new subscribersessions().get_resources(service, option);

    public static subscribersessions[] get(
      nitro_service service,
      subscribersessions_args args)
    {
      subscribersessions subscribersessions = new subscribersessions();
      options option = new options();
      option.set_args(nitro_util.object_to_string_withoutquotes((object) args));
      return (subscribersessions[]) subscribersessions.get_resources(service, option);
    }

    public static subscribersessions[] get_filtered(
      nitro_service service,
      string filter)
    {
      subscribersessions subscribersessions = new subscribersessions();
      options option = new options();
      option.set_filter(filter);
      return (subscribersessions[]) subscribersessions.getfiltered(service, option);
    }

    public static subscribersessions[] get_filtered(
      nitro_service service,
      filtervalue[] filter)
    {
      subscribersessions subscribersessions = new subscribersessions();
      options option = new options();
      option.set_filter(filter);
      return (subscribersessions[]) subscribersessions.getfiltered(service, option);
    }

    public static uint count(nitro_service service)
    {
      subscribersessions subscribersessions = new subscribersessions();
      options option = new options();
      option.set_count(true);
      subscribersessions[] resources = (subscribersessions[]) subscribersessions.get_resources(service, option);
      return resources != null && resources.Length > 0 ? resources[0].__count.Value : 0U;
    }

    public static uint count_filtered(nitro_service service, string filter)
    {
      subscribersessions subscribersessions = new subscribersessions();
      options option = new options();
      option.set_count(true);
      option.set_filter(filter);
      subscribersessions[] subscribersessionsArray = (subscribersessions[]) subscribersessions.getfiltered(service, option);
      return subscribersessionsArray != null && subscribersessionsArray.Length > 0 ? subscribersessionsArray[0].__count.Value : 0U;
    }

    public static uint count_filtered(nitro_service service, filtervalue[] filter)
    {
      subscribersessions subscribersessions = new subscribersessions();
      options option = new options();
      option.set_count(true);
      option.set_filter(filter);
      subscribersessions[] subscribersessionsArray = (subscribersessions[]) subscribersessions.getfiltered(service, option);
      return subscribersessionsArray != null && subscribersessionsArray.Length > 0 ? subscribersessionsArray[0].__count.Value : 0U;
    }

    private class subscribersessions_response : base_response
    {
      public subscribersessions[] subscribersessions = (subscribersessions[]) null;
    }

    public static class subscriptionidtypeEnum
    {
      public const string E164 = "E164";
      public const string IMSI = "IMSI";
      public const string SIP_URI = "SIP_URI";
      public const string NAI = "NAI";
      public const string PRIVATE = "PRIVATE";
    }
  }
}
