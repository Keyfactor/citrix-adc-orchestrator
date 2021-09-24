// Decompiled with JetBrains decompiler
// Type: com.citrix.netscaler.nitro.resource.config.ns.nslimitidentifier
// Assembly: nitro, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 6CF5DDEF-E052-4F9D-953F-6644F8378A66


using com.citrix.netscaler.nitro.exception;
using com.citrix.netscaler.nitro.resource.Base;
using com.citrix.netscaler.nitro.service;
using com.citrix.netscaler.nitro.util;

namespace com.citrix.netscaler.nitro.resource.config.ns
{
  public class nslimitidentifier : base_resource
  {
    private string limitidentifierField = (string) null;
    private uint? thresholdField = new uint?();
    private uint? timesliceField = new uint?();
    private string modeField = (string) null;
    private string limittypeField = (string) null;
    private string selectornameField = (string) null;
    private uint? maxbandwidthField = new uint?();
    private uint? trapsintimesliceField = new uint?();
    private string ngnameField = (string) null;
    private long? hitsField = new long?();
    private long? dropField = new long?();
    private string[] ruleField = (string[]) null;
    private uint? timeField = new uint?();
    private uint? totalField = new uint?();
    private uint? trapscomputedintimesliceField = new uint?();
    private uint? computedtraptimesliceField = new uint?();
    private uint? referencecountField = new uint?();
    private uint? __countField = new uint?();

    public uint? __count
    {
      get => this.__countField;
      private set => this.__countField = value;
    }

    public string limitidentifier
    {
      get => this.limitidentifierField;
      set => this.limitidentifierField = value;
    }

    public uint? threshold
    {
      get => this.thresholdField;
      set => this.thresholdField = value;
    }

    public uint? timeslice
    {
      get => this.timesliceField;
      set => this.timesliceField = value;
    }

    public string mode
    {
      get => this.modeField;
      set => this.modeField = value;
    }

    public string limittype
    {
      get => this.limittypeField;
      set => this.limittypeField = value;
    }

    public string selectorname
    {
      get => this.selectornameField;
      set => this.selectornameField = value;
    }

    public uint? maxbandwidth
    {
      get => this.maxbandwidthField;
      set => this.maxbandwidthField = value;
    }

    public uint? trapsintimeslice
    {
      get => this.trapsintimesliceField;
      set => this.trapsintimesliceField = value;
    }

    public string ngname
    {
      get => this.ngnameField;
      private set => this.ngnameField = value;
    }

    public long? hits
    {
      get => this.hitsField;
      private set => this.hitsField = value;
    }

    public long? drop
    {
      get => this.dropField;
      private set => this.dropField = value;
    }

    public string[] rule
    {
      get => this.ruleField;
      private set => this.ruleField = value;
    }

    public uint? time
    {
      get => this.timeField;
      private set => this.timeField = value;
    }

    public uint? total
    {
      get => this.totalField;
      private set => this.totalField = value;
    }

    public uint? trapscomputedintimeslice
    {
      get => this.trapscomputedintimesliceField;
      private set => this.trapscomputedintimesliceField = value;
    }

    public uint? computedtraptimeslice
    {
      get => this.computedtraptimesliceField;
      private set => this.computedtraptimesliceField = value;
    }

    public uint? referencecount
    {
      get => this.referencecountField;
      private set => this.referencecountField = value;
    }

    internal override base_resource[] get_nitro_response(
      nitro_service service,
      string response)
    {
      nslimitidentifier.nslimitidentifier_response nslimitidentifierResponse = new nslimitidentifier.nslimitidentifier_response();
      nslimitidentifier.nslimitidentifier_response resource = (nslimitidentifier.nslimitidentifier_response) service.get_payload_formatter().string_to_resource(nslimitidentifierResponse.GetType(), response);
      if (resource.errorcode != 0)
      {
        if (resource.errorcode == 444)
          service.clear_session();
        if (resource.severity == null)
          throw new nitro_exception(resource.message, resource.errorcode);
        if (resource.severity.Equals("ERROR"))
          throw new nitro_exception(resource.message, resource.errorcode);
      }
      return (base_resource[]) resource.nslimitidentifier;
    }

    internal override string get_object_name() => this.limitidentifier;

    public static base_response add(nitro_service client, nslimitidentifier resource) => new nslimitidentifier()
    {
      limitidentifier = resource.limitidentifier,
      threshold = resource.threshold,
      timeslice = resource.timeslice,
      mode = resource.mode,
      limittype = resource.limittype,
      selectorname = resource.selectorname,
      maxbandwidth = resource.maxbandwidth,
      trapsintimeslice = resource.trapsintimeslice
    }.add_resource(client);

    public static base_responses add(
      nitro_service client,
      nslimitidentifier[] resources)
    {
      base_responses baseResponses = (base_responses) null;
      if (resources != null && resources.Length > 0)
      {
        nslimitidentifier[] nslimitidentifierArray = new nslimitidentifier[resources.Length];
        for (int index = 0; index < resources.Length; ++index)
        {
          nslimitidentifierArray[index] = new nslimitidentifier();
          nslimitidentifierArray[index].limitidentifier = resources[index].limitidentifier;
          nslimitidentifierArray[index].threshold = resources[index].threshold;
          nslimitidentifierArray[index].timeslice = resources[index].timeslice;
          nslimitidentifierArray[index].mode = resources[index].mode;
          nslimitidentifierArray[index].limittype = resources[index].limittype;
          nslimitidentifierArray[index].selectorname = resources[index].selectorname;
          nslimitidentifierArray[index].maxbandwidth = resources[index].maxbandwidth;
          nslimitidentifierArray[index].trapsintimeslice = resources[index].trapsintimeslice;
        }
        baseResponses = base_resource.add_bulk_request(client, (base_resource[]) nslimitidentifierArray);
      }
      return baseResponses;
    }

    public static base_response delete(nitro_service client, string limitidentifier) => new nslimitidentifier()
    {
      limitidentifier = limitidentifier
    }.delete_resource(client);

    public static base_response delete(
      nitro_service client,
      nslimitidentifier resource)
    {
      return new nslimitidentifier()
      {
        limitidentifier = resource.limitidentifier
      }.delete_resource(client);
    }

    public static base_responses delete(
      nitro_service client,
      string[] limitidentifier)
    {
      base_responses baseResponses = (base_responses) null;
      if (limitidentifier != null && limitidentifier.Length > 0)
      {
        nslimitidentifier[] nslimitidentifierArray = new nslimitidentifier[limitidentifier.Length];
        for (int index = 0; index < limitidentifier.Length; ++index)
        {
          nslimitidentifierArray[index] = new nslimitidentifier();
          nslimitidentifierArray[index].limitidentifier = limitidentifier[index];
        }
        baseResponses = base_resource.delete_bulk_request(client, (base_resource[]) nslimitidentifierArray);
      }
      return baseResponses;
    }

    public static base_responses delete(
      nitro_service client,
      nslimitidentifier[] resources)
    {
      base_responses baseResponses = (base_responses) null;
      if (resources != null && resources.Length > 0)
      {
        nslimitidentifier[] nslimitidentifierArray = new nslimitidentifier[resources.Length];
        for (int index = 0; index < resources.Length; ++index)
        {
          nslimitidentifierArray[index] = new nslimitidentifier();
          nslimitidentifierArray[index].limitidentifier = resources[index].limitidentifier;
        }
        baseResponses = base_resource.delete_bulk_request(client, (base_resource[]) nslimitidentifierArray);
      }
      return baseResponses;
    }

    public static base_response update(
      nitro_service client,
      nslimitidentifier resource)
    {
      return new nslimitidentifier()
      {
        limitidentifier = resource.limitidentifier,
        threshold = resource.threshold,
        timeslice = resource.timeslice,
        mode = resource.mode,
        limittype = resource.limittype,
        selectorname = resource.selectorname,
        maxbandwidth = resource.maxbandwidth,
        trapsintimeslice = resource.trapsintimeslice
      }.update_resource(client);
    }

    public static base_responses update(
      nitro_service client,
      nslimitidentifier[] resources)
    {
      base_responses baseResponses = (base_responses) null;
      if (resources != null && resources.Length > 0)
      {
        nslimitidentifier[] nslimitidentifierArray = new nslimitidentifier[resources.Length];
        for (int index = 0; index < resources.Length; ++index)
        {
          nslimitidentifierArray[index] = new nslimitidentifier();
          nslimitidentifierArray[index].limitidentifier = resources[index].limitidentifier;
          nslimitidentifierArray[index].threshold = resources[index].threshold;
          nslimitidentifierArray[index].timeslice = resources[index].timeslice;
          nslimitidentifierArray[index].mode = resources[index].mode;
          nslimitidentifierArray[index].limittype = resources[index].limittype;
          nslimitidentifierArray[index].selectorname = resources[index].selectorname;
          nslimitidentifierArray[index].maxbandwidth = resources[index].maxbandwidth;
          nslimitidentifierArray[index].trapsintimeslice = resources[index].trapsintimeslice;
        }
        baseResponses = base_resource.update_bulk_request(client, (base_resource[]) nslimitidentifierArray);
      }
      return baseResponses;
    }

    public static base_response unset(
      nitro_service client,
      string limitidentifier,
      string[] args)
    {
      return new nslimitidentifier()
      {
        limitidentifier = limitidentifier
      }.unset_resource(client, args);
    }

    public static base_response unset(
      nitro_service client,
      nslimitidentifier resource,
      string[] args)
    {
      return new nslimitidentifier()
      {
        limitidentifier = resource.limitidentifier
      }.unset_resource(client, args);
    }

    public static base_responses unset(
      nitro_service client,
      string[] limitidentifier,
      string[] args)
    {
      base_responses baseResponses = (base_responses) null;
      if (limitidentifier != null && limitidentifier.Length > 0)
      {
        nslimitidentifier[] nslimitidentifierArray = new nslimitidentifier[limitidentifier.Length];
        for (int index = 0; index < limitidentifier.Length; ++index)
        {
          nslimitidentifierArray[index] = new nslimitidentifier();
          nslimitidentifierArray[index].limitidentifier = limitidentifier[index];
        }
        baseResponses = base_resource.unset_bulk_request(client, (base_resource[]) nslimitidentifierArray, args);
      }
      return baseResponses;
    }

    public static base_responses unset(
      nitro_service client,
      nslimitidentifier[] resources,
      string[] args)
    {
      base_responses baseResponses = (base_responses) null;
      if (resources != null && resources.Length > 0)
      {
        nslimitidentifier[] nslimitidentifierArray = new nslimitidentifier[resources.Length];
        for (int index = 0; index < resources.Length; ++index)
        {
          nslimitidentifierArray[index] = new nslimitidentifier();
          nslimitidentifierArray[index].limitidentifier = resources[index].limitidentifier;
        }
        baseResponses = base_resource.unset_bulk_request(client, (base_resource[]) nslimitidentifierArray, args);
      }
      return baseResponses;
    }

    public static nslimitidentifier[] get(nitro_service service) => (nslimitidentifier[]) new nslimitidentifier().get_resources(service, (options) null);

    public static nslimitidentifier[] get(nitro_service service, options option) => (nslimitidentifier[]) new nslimitidentifier().get_resources(service, option);

    public static nslimitidentifier get(
      nitro_service service,
      string limitidentifier)
    {
      return (nslimitidentifier) new nslimitidentifier()
      {
        limitidentifier = limitidentifier
      }.get_resource(service);
    }

    public static nslimitidentifier[] get(
      nitro_service service,
      string[] limitidentifier)
    {
      if (limitidentifier == null || limitidentifier.Length <= 0)
        return (nslimitidentifier[]) null;
      nslimitidentifier[] nslimitidentifierArray1 = new nslimitidentifier[limitidentifier.Length];
      nslimitidentifier[] nslimitidentifierArray2 = new nslimitidentifier[limitidentifier.Length];
      for (int index = 0; index < limitidentifier.Length; ++index)
      {
        nslimitidentifierArray2[index] = new nslimitidentifier();
        nslimitidentifierArray2[index].limitidentifier = limitidentifier[index];
        nslimitidentifierArray1[index] = (nslimitidentifier) nslimitidentifierArray2[index].get_resource(service);
      }
      return nslimitidentifierArray1;
    }

    public static nslimitidentifier[] get_filtered(
      nitro_service service,
      string filter)
    {
      nslimitidentifier nslimitidentifier = new nslimitidentifier();
      options option = new options();
      option.set_filter(filter);
      return (nslimitidentifier[]) nslimitidentifier.getfiltered(service, option);
    }

    public static nslimitidentifier[] get_filtered(
      nitro_service service,
      filtervalue[] filter)
    {
      nslimitidentifier nslimitidentifier = new nslimitidentifier();
      options option = new options();
      option.set_filter(filter);
      return (nslimitidentifier[]) nslimitidentifier.getfiltered(service, option);
    }

    public static uint count(nitro_service service)
    {
      nslimitidentifier nslimitidentifier = new nslimitidentifier();
      options option = new options();
      option.set_count(true);
      nslimitidentifier[] resources = (nslimitidentifier[]) nslimitidentifier.get_resources(service, option);
      return resources != null && resources.Length > 0 ? resources[0].__count.Value : 0U;
    }

    public static uint count_filtered(nitro_service service, string filter)
    {
      nslimitidentifier nslimitidentifier = new nslimitidentifier();
      options option = new options();
      option.set_count(true);
      option.set_filter(filter);
      nslimitidentifier[] nslimitidentifierArray = (nslimitidentifier[]) nslimitidentifier.getfiltered(service, option);
      return nslimitidentifierArray != null && nslimitidentifierArray.Length > 0 ? nslimitidentifierArray[0].__count.Value : 0U;
    }

    public static uint count_filtered(nitro_service service, filtervalue[] filter)
    {
      nslimitidentifier nslimitidentifier = new nslimitidentifier();
      options option = new options();
      option.set_count(true);
      option.set_filter(filter);
      nslimitidentifier[] nslimitidentifierArray = (nslimitidentifier[]) nslimitidentifier.getfiltered(service, option);
      return nslimitidentifierArray != null && nslimitidentifierArray.Length > 0 ? nslimitidentifierArray[0].__count.Value : 0U;
    }

    private class nslimitidentifier_response : base_response
    {
      public nslimitidentifier[] nslimitidentifier = (nslimitidentifier[]) null;
    }

    public static class modeEnum
    {
      public const string CONNECTION = "CONNECTION";
      public const string REQUEST_RATE = "REQUEST_RATE";
      public const string NONE = "NONE";
    }

    public static class limittypeEnum
    {
      public const string BURSTY = "BURSTY";
      public const string SMOOTH = "SMOOTH";
    }
  }
}
