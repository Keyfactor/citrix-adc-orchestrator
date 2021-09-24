// Decompiled with JetBrains decompiler
// Type: com.citrix.netscaler.nitro.resource.config.ns.nslimitsessions
// Assembly: nitro, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 6CF5DDEF-E052-4F9D-953F-6644F8378A66


using com.citrix.netscaler.nitro.exception;
using com.citrix.netscaler.nitro.resource.Base;
using com.citrix.netscaler.nitro.service;
using com.citrix.netscaler.nitro.util;

namespace com.citrix.netscaler.nitro.resource.config.ns
{
  public class nslimitsessions : base_resource
  {
    private string limitidentifierField = (string) null;
    private bool? detailField = new bool?();
    private uint? timeoutField = new uint?();
    private uint? hitsField = new uint?();
    private uint? dropField = new uint?();
    private uint?[] numberField = (uint?[]) null;
    private string nameField = (string) null;
    private uint? unitField = new uint?();
    private uint? flagsField = new uint?();
    private uint? referencecountField = new uint?();
    private uint? maxbandwidthField = new uint?();
    private string selectoripv61Field = (string) null;
    private string selectoripv62Field = (string) null;
    private uint? flagField = new uint?();
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

    public bool? detail
    {
      get => this.detailField;
      set => this.detailField = value;
    }

    public uint? timeout
    {
      get => this.timeoutField;
      private set => this.timeoutField = value;
    }

    public uint? hits
    {
      get => this.hitsField;
      private set => this.hitsField = value;
    }

    public uint? drop
    {
      get => this.dropField;
      private set => this.dropField = value;
    }

    public uint?[] number
    {
      get => this.numberField;
      private set => this.numberField = value;
    }

    public string name
    {
      get => this.nameField;
      private set => this.nameField = value;
    }

    public uint? unit
    {
      get => this.unitField;
      private set => this.unitField = value;
    }

    public uint? flags
    {
      get => this.flagsField;
      private set => this.flagsField = value;
    }

    public uint? referencecount
    {
      get => this.referencecountField;
      private set => this.referencecountField = value;
    }

    public uint? maxbandwidth
    {
      get => this.maxbandwidthField;
      private set => this.maxbandwidthField = value;
    }

    public string selectoripv61
    {
      get => this.selectoripv61Field;
      private set => this.selectoripv61Field = value;
    }

    public string selectoripv62
    {
      get => this.selectoripv62Field;
      private set => this.selectoripv62Field = value;
    }

    public uint? flag
    {
      get => this.flagField;
      private set => this.flagField = value;
    }

    internal override base_resource[] get_nitro_response(
      nitro_service service,
      string response)
    {
      nslimitsessions.nslimitsessions_response nslimitsessionsResponse = new nslimitsessions.nslimitsessions_response();
      nslimitsessions.nslimitsessions_response resource = (nslimitsessions.nslimitsessions_response) service.get_payload_formatter().string_to_resource(nslimitsessionsResponse.GetType(), response);
      if (resource.errorcode != 0)
      {
        if (resource.errorcode == 444)
          service.clear_session();
        if (resource.severity == null)
          throw new nitro_exception(resource.message, resource.errorcode);
        if (resource.severity.Equals("ERROR"))
          throw new nitro_exception(resource.message, resource.errorcode);
      }
      return (base_resource[]) resource.nslimitsessions;
    }

    internal override string get_object_name() => (string) null;

    public static base_response clear(nitro_service client, nslimitsessions resource) => new nslimitsessions()
    {
      limitidentifier = resource.limitidentifier
    }.perform_operation_byaction(client, nameof (clear));

    public static base_responses clear(
      nitro_service client,
      nslimitsessions[] resources)
    {
      base_responses baseResponses = (base_responses) null;
      if (resources != null && resources.Length > 0)
      {
        nslimitsessions[] nslimitsessionsArray = new nslimitsessions[resources.Length];
        for (int index = 0; index < resources.Length; ++index)
        {
          nslimitsessionsArray[index] = new nslimitsessions();
          nslimitsessionsArray[index].limitidentifier = resources[index].limitidentifier;
        }
        baseResponses = base_resource.perform_operation_bulk_request(client, (base_resource[]) nslimitsessionsArray, nameof (clear));
      }
      return baseResponses;
    }

    public static nslimitsessions get(nitro_service service, nslimitsessions obj)
    {
      options option = new options();
      option.set_args(nitro_util.object_to_string_withoutquotes((object) obj));
      return (nslimitsessions) obj.get_resource(service, option);
    }

    public static nslimitsessions[] get(nitro_service service, nslimitsessions[] obj)
    {
      if (obj == null || obj.Length <= 0)
        return (nslimitsessions[]) null;
      nslimitsessions[] nslimitsessionsArray = new nslimitsessions[obj.Length];
      for (int index = 0; index < obj.Length; ++index)
      {
        options option = new options();
        option.set_args(nitro_util.object_to_string_withoutquotes((object) obj[index]));
        nslimitsessionsArray[index] = (nslimitsessions) obj[index].get_resource(service, option);
      }
      return nslimitsessionsArray;
    }

    public static nslimitsessions[] get(
      nitro_service service,
      nslimitsessions_args args)
    {
      nslimitsessions nslimitsessions = new nslimitsessions();
      options option = new options();
      option.set_args(nitro_util.object_to_string_withoutquotes((object) args));
      return (nslimitsessions[]) nslimitsessions.get_resources(service, option);
    }

    public static nslimitsessions[] get_filtered(
      nitro_service service,
      nslimitsessions obj,
      string filter)
    {
      options option = new options();
      option.set_filter(filter);
      option.set_args(nitro_util.object_to_string_withoutquotes((object) obj));
      return (nslimitsessions[]) obj.getfiltered(service, option);
    }

    public static nslimitsessions[] get_filtered(
      nitro_service service,
      nslimitsessions obj,
      filtervalue[] filter)
    {
      options option = new options();
      option.set_filter(filter);
      option.set_args(nitro_util.object_to_string_withoutquotes((object) obj));
      return (nslimitsessions[]) obj.getfiltered(service, option);
    }

    public static uint count(nitro_service service, nslimitsessions obj)
    {
      options option = new options();
      option.set_count(true);
      option.set_args(nitro_util.object_to_string_withoutquotes((object) obj));
      nslimitsessions[] resources = (nslimitsessions[]) obj.get_resources(service, option);
      return resources != null && resources.Length > 0 ? resources[0].__count.Value : 0U;
    }

    public static uint count_filtered(nitro_service service, nslimitsessions obj, string filter)
    {
      options option = new options();
      option.set_count(true);
      option.set_filter(filter);
      option.set_args(nitro_util.object_to_string_withoutquotes((object) obj));
      nslimitsessions[] nslimitsessionsArray = (nslimitsessions[]) obj.getfiltered(service, option);
      return nslimitsessionsArray != null && nslimitsessionsArray.Length > 0 ? nslimitsessionsArray[0].__count.Value : 0U;
    }

    public static uint count_filtered(
      nitro_service service,
      nslimitsessions obj,
      filtervalue[] filter)
    {
      options option = new options();
      option.set_count(true);
      option.set_filter(filter);
      option.set_args(nitro_util.object_to_string_withoutquotes((object) obj));
      nslimitsessions[] nslimitsessionsArray = (nslimitsessions[]) obj.getfiltered(service, option);
      return nslimitsessionsArray != null && nslimitsessionsArray.Length > 0 ? nslimitsessionsArray[0].__count.Value : 0U;
    }

    private class nslimitsessions_response : base_response
    {
      public nslimitsessions[] nslimitsessions = (nslimitsessions[]) null;
    }
  }
}
