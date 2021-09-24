// Decompiled with JetBrains decompiler
// Type: com.citrix.netscaler.nitro.resource.config.stream.streamidentifier
// Assembly: nitro, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 6CF5DDEF-E052-4F9D-953F-6644F8378A66


using com.citrix.netscaler.nitro.exception;
using com.citrix.netscaler.nitro.resource.Base;
using com.citrix.netscaler.nitro.service;
using com.citrix.netscaler.nitro.util;

namespace com.citrix.netscaler.nitro.resource.config.stream
{
  public class streamidentifier : base_resource
  {
    private string nameField = (string) null;
    private string selectornameField = (string) null;
    private uint? intervalField = new uint?();
    private uint? samplecountField = new uint?();
    private string sortField = (string) null;
    private string snmptrapField = (string) null;
    private string appflowlogField = (string) null;
    private string tracktransactionsField = (string) null;
    private uint? maxtransactionthresholdField = new uint?();
    private uint? mintransactionthresholdField = new uint?();
    private string acceptancethresholdField = (string) null;
    private uint? breachthresholdField = new uint?();
    private string[] ruleField = (string[]) null;
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

    public string selectorname
    {
      get => this.selectornameField;
      set => this.selectornameField = value;
    }

    public uint? interval
    {
      get => this.intervalField;
      set => this.intervalField = value;
    }

    public uint? samplecount
    {
      get => this.samplecountField;
      set => this.samplecountField = value;
    }

    public string sort
    {
      get => this.sortField;
      set => this.sortField = value;
    }

    public string snmptrap
    {
      get => this.snmptrapField;
      set => this.snmptrapField = value;
    }

    public string appflowlog
    {
      get => this.appflowlogField;
      set => this.appflowlogField = value;
    }

    public string tracktransactions
    {
      get => this.tracktransactionsField;
      set => this.tracktransactionsField = value;
    }

    public uint? maxtransactionthreshold
    {
      get => this.maxtransactionthresholdField;
      set => this.maxtransactionthresholdField = value;
    }

    public uint? mintransactionthreshold
    {
      get => this.mintransactionthresholdField;
      set => this.mintransactionthresholdField = value;
    }

    public string acceptancethreshold
    {
      get => this.acceptancethresholdField;
      set => this.acceptancethresholdField = value;
    }

    public uint? breachthreshold
    {
      get => this.breachthresholdField;
      set => this.breachthresholdField = value;
    }

    public string[] rule
    {
      get => this.ruleField;
      private set => this.ruleField = value;
    }

    internal override base_resource[] get_nitro_response(
      nitro_service service,
      string response)
    {
      streamidentifier.streamidentifier_response streamidentifierResponse = new streamidentifier.streamidentifier_response();
      streamidentifier.streamidentifier_response resource = (streamidentifier.streamidentifier_response) service.get_payload_formatter().string_to_resource(streamidentifierResponse.GetType(), response);
      if (resource.errorcode != 0)
      {
        if (resource.errorcode == 444)
          service.clear_session();
        if (resource.severity == null)
          throw new nitro_exception(resource.message, resource.errorcode);
        if (resource.severity.Equals("ERROR"))
          throw new nitro_exception(resource.message, resource.errorcode);
      }
      return (base_resource[]) resource.streamidentifier;
    }

    internal override string get_object_name() => this.name;

    public static base_response add(nitro_service client, streamidentifier resource) => new streamidentifier()
    {
      name = resource.name,
      selectorname = resource.selectorname,
      interval = resource.interval,
      samplecount = resource.samplecount,
      sort = resource.sort,
      snmptrap = resource.snmptrap,
      appflowlog = resource.appflowlog,
      tracktransactions = resource.tracktransactions,
      maxtransactionthreshold = resource.maxtransactionthreshold,
      mintransactionthreshold = resource.mintransactionthreshold,
      acceptancethreshold = resource.acceptancethreshold,
      breachthreshold = resource.breachthreshold
    }.add_resource(client);

    public static base_responses add(
      nitro_service client,
      streamidentifier[] resources)
    {
      base_responses baseResponses = (base_responses) null;
      if (resources != null && resources.Length > 0)
      {
        streamidentifier[] streamidentifierArray = new streamidentifier[resources.Length];
        for (int index = 0; index < resources.Length; ++index)
        {
          streamidentifierArray[index] = new streamidentifier();
          streamidentifierArray[index].name = resources[index].name;
          streamidentifierArray[index].selectorname = resources[index].selectorname;
          streamidentifierArray[index].interval = resources[index].interval;
          streamidentifierArray[index].samplecount = resources[index].samplecount;
          streamidentifierArray[index].sort = resources[index].sort;
          streamidentifierArray[index].snmptrap = resources[index].snmptrap;
          streamidentifierArray[index].appflowlog = resources[index].appflowlog;
          streamidentifierArray[index].tracktransactions = resources[index].tracktransactions;
          streamidentifierArray[index].maxtransactionthreshold = resources[index].maxtransactionthreshold;
          streamidentifierArray[index].mintransactionthreshold = resources[index].mintransactionthreshold;
          streamidentifierArray[index].acceptancethreshold = resources[index].acceptancethreshold;
          streamidentifierArray[index].breachthreshold = resources[index].breachthreshold;
        }
        baseResponses = base_resource.add_bulk_request(client, (base_resource[]) streamidentifierArray);
      }
      return baseResponses;
    }

    public static base_response update(nitro_service client, streamidentifier resource) => new streamidentifier()
    {
      name = resource.name,
      selectorname = resource.selectorname,
      interval = resource.interval,
      samplecount = resource.samplecount,
      sort = resource.sort,
      snmptrap = resource.snmptrap,
      appflowlog = resource.appflowlog,
      tracktransactions = resource.tracktransactions,
      maxtransactionthreshold = resource.maxtransactionthreshold,
      mintransactionthreshold = resource.mintransactionthreshold,
      acceptancethreshold = resource.acceptancethreshold,
      breachthreshold = resource.breachthreshold
    }.update_resource(client);

    public static base_responses update(
      nitro_service client,
      streamidentifier[] resources)
    {
      base_responses baseResponses = (base_responses) null;
      if (resources != null && resources.Length > 0)
      {
        streamidentifier[] streamidentifierArray = new streamidentifier[resources.Length];
        for (int index = 0; index < resources.Length; ++index)
        {
          streamidentifierArray[index] = new streamidentifier();
          streamidentifierArray[index].name = resources[index].name;
          streamidentifierArray[index].selectorname = resources[index].selectorname;
          streamidentifierArray[index].interval = resources[index].interval;
          streamidentifierArray[index].samplecount = resources[index].samplecount;
          streamidentifierArray[index].sort = resources[index].sort;
          streamidentifierArray[index].snmptrap = resources[index].snmptrap;
          streamidentifierArray[index].appflowlog = resources[index].appflowlog;
          streamidentifierArray[index].tracktransactions = resources[index].tracktransactions;
          streamidentifierArray[index].maxtransactionthreshold = resources[index].maxtransactionthreshold;
          streamidentifierArray[index].mintransactionthreshold = resources[index].mintransactionthreshold;
          streamidentifierArray[index].acceptancethreshold = resources[index].acceptancethreshold;
          streamidentifierArray[index].breachthreshold = resources[index].breachthreshold;
        }
        baseResponses = base_resource.update_bulk_request(client, (base_resource[]) streamidentifierArray);
      }
      return baseResponses;
    }

    public static base_response unset(
      nitro_service client,
      string name,
      string[] args)
    {
      return new streamidentifier() { name = name }.unset_resource(client, args);
    }

    public static base_response unset(
      nitro_service client,
      streamidentifier resource,
      string[] args)
    {
      return new streamidentifier() { name = resource.name }.unset_resource(client, args);
    }

    public static base_responses unset(
      nitro_service client,
      string[] name,
      string[] args)
    {
      base_responses baseResponses = (base_responses) null;
      if (name != null && name.Length > 0)
      {
        streamidentifier[] streamidentifierArray = new streamidentifier[name.Length];
        for (int index = 0; index < name.Length; ++index)
        {
          streamidentifierArray[index] = new streamidentifier();
          streamidentifierArray[index].name = name[index];
        }
        baseResponses = base_resource.unset_bulk_request(client, (base_resource[]) streamidentifierArray, args);
      }
      return baseResponses;
    }

    public static base_responses unset(
      nitro_service client,
      streamidentifier[] resources,
      string[] args)
    {
      base_responses baseResponses = (base_responses) null;
      if (resources != null && resources.Length > 0)
      {
        streamidentifier[] streamidentifierArray = new streamidentifier[resources.Length];
        for (int index = 0; index < resources.Length; ++index)
        {
          streamidentifierArray[index] = new streamidentifier();
          streamidentifierArray[index].name = resources[index].name;
        }
        baseResponses = base_resource.unset_bulk_request(client, (base_resource[]) streamidentifierArray, args);
      }
      return baseResponses;
    }

    public static base_response delete(nitro_service client, string name) => new streamidentifier()
    {
      name = name
    }.delete_resource(client);

    public static base_response delete(nitro_service client, streamidentifier resource) => new streamidentifier()
    {
      name = resource.name
    }.delete_resource(client);

    public static base_responses delete(nitro_service client, string[] name)
    {
      base_responses baseResponses = (base_responses) null;
      if (name != null && name.Length > 0)
      {
        streamidentifier[] streamidentifierArray = new streamidentifier[name.Length];
        for (int index = 0; index < name.Length; ++index)
        {
          streamidentifierArray[index] = new streamidentifier();
          streamidentifierArray[index].name = name[index];
        }
        baseResponses = base_resource.delete_bulk_request(client, (base_resource[]) streamidentifierArray);
      }
      return baseResponses;
    }

    public static base_responses delete(
      nitro_service client,
      streamidentifier[] resources)
    {
      base_responses baseResponses = (base_responses) null;
      if (resources != null && resources.Length > 0)
      {
        streamidentifier[] streamidentifierArray = new streamidentifier[resources.Length];
        for (int index = 0; index < resources.Length; ++index)
        {
          streamidentifierArray[index] = new streamidentifier();
          streamidentifierArray[index].name = resources[index].name;
        }
        baseResponses = base_resource.delete_bulk_request(client, (base_resource[]) streamidentifierArray);
      }
      return baseResponses;
    }

    public static streamidentifier[] get(nitro_service service) => (streamidentifier[]) new streamidentifier().get_resources(service, (options) null);

    public static streamidentifier[] get(nitro_service service, options option) => (streamidentifier[]) new streamidentifier().get_resources(service, option);

    public static streamidentifier get(nitro_service service, string name) => (streamidentifier) new streamidentifier()
    {
      name = name
    }.get_resource(service);

    public static streamidentifier[] get(nitro_service service, string[] name)
    {
      if (name == null || name.Length <= 0)
        return (streamidentifier[]) null;
      streamidentifier[] streamidentifierArray1 = new streamidentifier[name.Length];
      streamidentifier[] streamidentifierArray2 = new streamidentifier[name.Length];
      for (int index = 0; index < name.Length; ++index)
      {
        streamidentifierArray2[index] = new streamidentifier();
        streamidentifierArray2[index].name = name[index];
        streamidentifierArray1[index] = (streamidentifier) streamidentifierArray2[index].get_resource(service);
      }
      return streamidentifierArray1;
    }

    public static streamidentifier[] get_filtered(
      nitro_service service,
      string filter)
    {
      streamidentifier streamidentifier = new streamidentifier();
      options option = new options();
      option.set_filter(filter);
      return (streamidentifier[]) streamidentifier.getfiltered(service, option);
    }

    public static streamidentifier[] get_filtered(
      nitro_service service,
      filtervalue[] filter)
    {
      streamidentifier streamidentifier = new streamidentifier();
      options option = new options();
      option.set_filter(filter);
      return (streamidentifier[]) streamidentifier.getfiltered(service, option);
    }

    public static uint count(nitro_service service)
    {
      streamidentifier streamidentifier = new streamidentifier();
      options option = new options();
      option.set_count(true);
      streamidentifier[] resources = (streamidentifier[]) streamidentifier.get_resources(service, option);
      return resources != null && resources.Length > 0 ? resources[0].__count.Value : 0U;
    }

    public static uint count_filtered(nitro_service service, string filter)
    {
      streamidentifier streamidentifier = new streamidentifier();
      options option = new options();
      option.set_count(true);
      option.set_filter(filter);
      streamidentifier[] streamidentifierArray = (streamidentifier[]) streamidentifier.getfiltered(service, option);
      return streamidentifierArray != null && streamidentifierArray.Length > 0 ? streamidentifierArray[0].__count.Value : 0U;
    }

    public static uint count_filtered(nitro_service service, filtervalue[] filter)
    {
      streamidentifier streamidentifier = new streamidentifier();
      options option = new options();
      option.set_count(true);
      option.set_filter(filter);
      streamidentifier[] streamidentifierArray = (streamidentifier[]) streamidentifier.getfiltered(service, option);
      return streamidentifierArray != null && streamidentifierArray.Length > 0 ? streamidentifierArray[0].__count.Value : 0U;
    }

    private class streamidentifier_response : base_response
    {
      public streamidentifier[] streamidentifier = (streamidentifier[]) null;
    }

    public static class snmptrapEnum
    {
      public const string ENABLED = "ENABLED";
      public const string DISABLED = "DISABLED";
    }

    public static class tracktransactionsEnum
    {
      public const string RESPTIME = "RESPTIME";
      public const string NONE = "NONE";
    }

    public static class appflowlogEnum
    {
      public const string ENABLED = "ENABLED";
      public const string DISABLED = "DISABLED";
    }

    public static class sortEnum
    {
      public const string REQUESTS = "REQUESTS";
      public const string CONNECTIONS = "CONNECTIONS";
      public const string RESPTIME = "RESPTIME";
      public const string BANDWIDTH = "BANDWIDTH";
      public const string RESPTIME_BREACHES = "RESPTIME_BREACHES";
      public const string NONE = "NONE";
    }
  }
}
