// Decompiled with JetBrains decompiler
// Type: com.citrix.netscaler.nitro.resource.config.policy.policypatset
// Assembly: nitro, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 6CF5DDEF-E052-4F9D-953F-6644F8378A66


using com.citrix.netscaler.nitro.exception;
using com.citrix.netscaler.nitro.resource.Base;
using com.citrix.netscaler.nitro.service;
using com.citrix.netscaler.nitro.util;

namespace com.citrix.netscaler.nitro.resource.config.policy
{
  public class policypatset : base_resource
  {
    private string nameField = (string) null;
    private string indextypeField = (string) null;
    private string commentField = (string) null;
    private string descriptionField = (string) null;
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

    public string indextype
    {
      get => this.indextypeField;
      set => this.indextypeField = value;
    }

    public string comment
    {
      get => this.commentField;
      set => this.commentField = value;
    }

    public string description
    {
      get => this.descriptionField;
      private set => this.descriptionField = value;
    }

    internal override base_resource[] get_nitro_response(
      nitro_service service,
      string response)
    {
      policypatset.policypatset_response policypatsetResponse = new policypatset.policypatset_response();
      policypatset.policypatset_response resource = (policypatset.policypatset_response) service.get_payload_formatter().string_to_resource(policypatsetResponse.GetType(), response);
      if (resource.errorcode != 0)
      {
        if (resource.errorcode == 444)
          service.clear_session();
        if (resource.severity == null)
          throw new nitro_exception(resource.message, resource.errorcode);
        if (resource.severity.Equals("ERROR"))
          throw new nitro_exception(resource.message, resource.errorcode);
      }
      return (base_resource[]) resource.policypatset;
    }

    internal override string get_object_name() => this.name;

    public static base_response add(nitro_service client, policypatset resource) => new policypatset()
    {
      name = resource.name,
      indextype = resource.indextype,
      comment = resource.comment
    }.add_resource(client);

    public static base_responses add(nitro_service client, policypatset[] resources)
    {
      base_responses baseResponses = (base_responses) null;
      if (resources != null && resources.Length > 0)
      {
        policypatset[] policypatsetArray = new policypatset[resources.Length];
        for (int index = 0; index < resources.Length; ++index)
        {
          policypatsetArray[index] = new policypatset();
          policypatsetArray[index].name = resources[index].name;
          policypatsetArray[index].indextype = resources[index].indextype;
          policypatsetArray[index].comment = resources[index].comment;
        }
        baseResponses = base_resource.add_bulk_request(client, (base_resource[]) policypatsetArray);
      }
      return baseResponses;
    }

    public static base_response delete(nitro_service client, string name) => new policypatset()
    {
      name = name
    }.delete_resource(client);

    public static base_response delete(nitro_service client, policypatset resource) => new policypatset()
    {
      name = resource.name
    }.delete_resource(client);

    public static base_responses delete(nitro_service client, string[] name)
    {
      base_responses baseResponses = (base_responses) null;
      if (name != null && name.Length > 0)
      {
        policypatset[] policypatsetArray = new policypatset[name.Length];
        for (int index = 0; index < name.Length; ++index)
        {
          policypatsetArray[index] = new policypatset();
          policypatsetArray[index].name = name[index];
        }
        baseResponses = base_resource.delete_bulk_request(client, (base_resource[]) policypatsetArray);
      }
      return baseResponses;
    }

    public static base_responses delete(
      nitro_service client,
      policypatset[] resources)
    {
      base_responses baseResponses = (base_responses) null;
      if (resources != null && resources.Length > 0)
      {
        policypatset[] policypatsetArray = new policypatset[resources.Length];
        for (int index = 0; index < resources.Length; ++index)
        {
          policypatsetArray[index] = new policypatset();
          policypatsetArray[index].name = resources[index].name;
        }
        baseResponses = base_resource.delete_bulk_request(client, (base_resource[]) policypatsetArray);
      }
      return baseResponses;
    }

    public static policypatset[] get(nitro_service service) => (policypatset[]) new policypatset().get_resources(service, (options) null);

    public static policypatset[] get(nitro_service service, options option) => (policypatset[]) new policypatset().get_resources(service, option);

    public static policypatset get(nitro_service service, string name) => (policypatset) new policypatset()
    {
      name = name
    }.get_resource(service);

    public static policypatset[] get(nitro_service service, string[] name)
    {
      if (name == null || name.Length <= 0)
        return (policypatset[]) null;
      policypatset[] policypatsetArray1 = new policypatset[name.Length];
      policypatset[] policypatsetArray2 = new policypatset[name.Length];
      for (int index = 0; index < name.Length; ++index)
      {
        policypatsetArray2[index] = new policypatset();
        policypatsetArray2[index].name = name[index];
        policypatsetArray1[index] = (policypatset) policypatsetArray2[index].get_resource(service);
      }
      return policypatsetArray1;
    }

    public static policypatset[] get_filtered(nitro_service service, string filter)
    {
      policypatset policypatset = new policypatset();
      options option = new options();
      option.set_filter(filter);
      return (policypatset[]) policypatset.getfiltered(service, option);
    }

    public static policypatset[] get_filtered(
      nitro_service service,
      filtervalue[] filter)
    {
      policypatset policypatset = new policypatset();
      options option = new options();
      option.set_filter(filter);
      return (policypatset[]) policypatset.getfiltered(service, option);
    }

    public static uint count(nitro_service service)
    {
      policypatset policypatset = new policypatset();
      options option = new options();
      option.set_count(true);
      policypatset[] resources = (policypatset[]) policypatset.get_resources(service, option);
      return resources != null && resources.Length > 0 ? resources[0].__count.Value : 0U;
    }

    public static uint count_filtered(nitro_service service, string filter)
    {
      policypatset policypatset = new policypatset();
      options option = new options();
      option.set_count(true);
      option.set_filter(filter);
      policypatset[] policypatsetArray = (policypatset[]) policypatset.getfiltered(service, option);
      return policypatsetArray != null && policypatsetArray.Length > 0 ? policypatsetArray[0].__count.Value : 0U;
    }

    public static uint count_filtered(nitro_service service, filtervalue[] filter)
    {
      policypatset policypatset = new policypatset();
      options option = new options();
      option.set_count(true);
      option.set_filter(filter);
      policypatset[] policypatsetArray = (policypatset[]) policypatset.getfiltered(service, option);
      return policypatsetArray != null && policypatsetArray.Length > 0 ? policypatsetArray[0].__count.Value : 0U;
    }

    private class policypatset_response : base_response
    {
      public policypatset[] policypatset = (policypatset[]) null;
    }

    public static class indextypeEnum
    {
      public const string Auto_generated = "Auto-generated";
      public const string User_defined = "User-defined";
    }
  }
}
