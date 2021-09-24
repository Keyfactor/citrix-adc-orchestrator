// Decompiled with JetBrains decompiler
// Type: com.citrix.netscaler.nitro.resource.config.pq.pqbinding
// Assembly: nitro, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 6CF5DDEF-E052-4F9D-953F-6644F8378A66


using com.citrix.netscaler.nitro.exception;
using com.citrix.netscaler.nitro.resource.Base;
using com.citrix.netscaler.nitro.service;
using com.citrix.netscaler.nitro.util;

namespace com.citrix.netscaler.nitro.resource.config.pq
{
  public class pqbinding : base_resource
  {
    private string vservernameField = (string) null;
    private string policynameField = (string) null;
    private string ruleField = (string) null;
    private uint? priorityField = new uint?();
    private uint? weightField = new uint?();
    private uint? qdepthField = new uint?();
    private uint? polqdepthField = new uint?();
    private long? hitsField = new long?();
    private uint? __countField = new uint?();

    public uint? __count
    {
      get => this.__countField;
      private set => this.__countField = value;
    }

    public string vservername
    {
      get => this.vservernameField;
      set => this.vservernameField = value;
    }

    public string policyname
    {
      get => this.policynameField;
      private set => this.policynameField = value;
    }

    public string rule
    {
      get => this.ruleField;
      private set => this.ruleField = value;
    }

    public uint? priority
    {
      get => this.priorityField;
      private set => this.priorityField = value;
    }

    public uint? weight
    {
      get => this.weightField;
      private set => this.weightField = value;
    }

    public uint? qdepth
    {
      get => this.qdepthField;
      private set => this.qdepthField = value;
    }

    public uint? polqdepth
    {
      get => this.polqdepthField;
      private set => this.polqdepthField = value;
    }

    public long? hits
    {
      get => this.hitsField;
      private set => this.hitsField = value;
    }

    internal override base_resource[] get_nitro_response(
      nitro_service service,
      string response)
    {
      pqbinding.pqbinding_response pqbindingResponse = new pqbinding.pqbinding_response();
      pqbinding.pqbinding_response resource = (pqbinding.pqbinding_response) service.get_payload_formatter().string_to_resource(pqbindingResponse.GetType(), response);
      if (resource.errorcode != 0)
      {
        if (resource.errorcode == 444)
          service.clear_session();
        if (resource.severity == null)
          throw new nitro_exception(resource.message, resource.errorcode);
        if (resource.severity.Equals("ERROR"))
          throw new nitro_exception(resource.message, resource.errorcode);
      }
      return (base_resource[]) resource.pqbinding;
    }

    internal override string get_object_name() => (string) null;

    public static pqbinding get(nitro_service service, pqbinding obj)
    {
      options option = new options();
      option.set_args(nitro_util.object_to_string_withoutquotes((object) obj));
      return (pqbinding) obj.get_resource(service, option);
    }

    public static pqbinding[] get(nitro_service service, pqbinding[] obj)
    {
      if (obj == null || obj.Length <= 0)
        return (pqbinding[]) null;
      pqbinding[] pqbindingArray = new pqbinding[obj.Length];
      for (int index = 0; index < obj.Length; ++index)
      {
        options option = new options();
        option.set_args(nitro_util.object_to_string_withoutquotes((object) obj[index]));
        pqbindingArray[index] = (pqbinding) obj[index].get_resource(service, option);
      }
      return pqbindingArray;
    }

    public static pqbinding[] get(nitro_service service, pqbinding_args args)
    {
      pqbinding pqbinding = new pqbinding();
      options option = new options();
      option.set_args(nitro_util.object_to_string_withoutquotes((object) args));
      return (pqbinding[]) pqbinding.get_resources(service, option);
    }

    public static pqbinding[] get_filtered(
      nitro_service service,
      pqbinding obj,
      string filter)
    {
      options option = new options();
      option.set_filter(filter);
      option.set_args(nitro_util.object_to_string_withoutquotes((object) obj));
      return (pqbinding[]) obj.getfiltered(service, option);
    }

    public static pqbinding[] get_filtered(
      nitro_service service,
      pqbinding obj,
      filtervalue[] filter)
    {
      options option = new options();
      option.set_filter(filter);
      option.set_args(nitro_util.object_to_string_withoutquotes((object) obj));
      return (pqbinding[]) obj.getfiltered(service, option);
    }

    public static uint count(nitro_service service, pqbinding obj)
    {
      options option = new options();
      option.set_count(true);
      option.set_args(nitro_util.object_to_string_withoutquotes((object) obj));
      pqbinding[] resources = (pqbinding[]) obj.get_resources(service, option);
      return resources != null && resources.Length > 0 ? resources[0].__count.Value : 0U;
    }

    public static uint count_filtered(nitro_service service, pqbinding obj, string filter)
    {
      options option = new options();
      option.set_count(true);
      option.set_filter(filter);
      option.set_args(nitro_util.object_to_string_withoutquotes((object) obj));
      pqbinding[] pqbindingArray = (pqbinding[]) obj.getfiltered(service, option);
      return pqbindingArray != null && pqbindingArray.Length > 0 ? pqbindingArray[0].__count.Value : 0U;
    }

    public static uint count_filtered(nitro_service service, pqbinding obj, filtervalue[] filter)
    {
      options option = new options();
      option.set_count(true);
      option.set_filter(filter);
      option.set_args(nitro_util.object_to_string_withoutquotes((object) obj));
      pqbinding[] pqbindingArray = (pqbinding[]) obj.getfiltered(service, option);
      return pqbindingArray != null && pqbindingArray.Length > 0 ? pqbindingArray[0].__count.Value : 0U;
    }

    private class pqbinding_response : base_response
    {
      public pqbinding[] pqbinding = (pqbinding[]) null;
    }
  }
}
