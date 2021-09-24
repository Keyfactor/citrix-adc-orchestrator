// Decompiled with JetBrains decompiler
// Type: com.citrix.netscaler.nitro.resource.config.policy.policymap
// Assembly: nitro, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 6CF5DDEF-E052-4F9D-953F-6644F8378A66


using com.citrix.netscaler.nitro.exception;
using com.citrix.netscaler.nitro.resource.Base;
using com.citrix.netscaler.nitro.service;
using com.citrix.netscaler.nitro.util;

namespace com.citrix.netscaler.nitro.resource.config.policy
{
  public class policymap : base_resource
  {
    private string mappolicynameField = (string) null;
    private string sdField = (string) null;
    private string suField = (string) null;
    private string tdField = (string) null;
    private string tuField = (string) null;
    private string targetnameField = (string) null;
    private uint? __countField = new uint?();

    public uint? __count
    {
      get => this.__countField;
      private set => this.__countField = value;
    }

    public string mappolicyname
    {
      get => this.mappolicynameField;
      set => this.mappolicynameField = value;
    }

    public string sd
    {
      get => this.sdField;
      set => this.sdField = value;
    }

    public string su
    {
      get => this.suField;
      set => this.suField = value;
    }

    public string td
    {
      get => this.tdField;
      set => this.tdField = value;
    }

    public string tu
    {
      get => this.tuField;
      set => this.tuField = value;
    }

    public string targetname
    {
      get => this.targetnameField;
      private set => this.targetnameField = value;
    }

    internal override base_resource[] get_nitro_response(
      nitro_service service,
      string response)
    {
      policymap.policymap_response policymapResponse = new policymap.policymap_response();
      policymap.policymap_response resource = (policymap.policymap_response) service.get_payload_formatter().string_to_resource(policymapResponse.GetType(), response);
      if (resource.errorcode != 0)
      {
        if (resource.errorcode == 444)
          service.clear_session();
        if (resource.severity == null)
          throw new nitro_exception(resource.message, resource.errorcode);
        if (resource.severity.Equals("ERROR"))
          throw new nitro_exception(resource.message, resource.errorcode);
      }
      return (base_resource[]) resource.policymap;
    }

    internal override string get_object_name() => this.mappolicyname;

    public static base_response add(nitro_service client, policymap resource) => new policymap()
    {
      mappolicyname = resource.mappolicyname,
      sd = resource.sd,
      su = resource.su,
      td = resource.td,
      tu = resource.tu
    }.add_resource(client);

    public static base_responses add(nitro_service client, policymap[] resources)
    {
      base_responses baseResponses = (base_responses) null;
      if (resources != null && resources.Length > 0)
      {
        policymap[] policymapArray = new policymap[resources.Length];
        for (int index = 0; index < resources.Length; ++index)
        {
          policymapArray[index] = new policymap();
          policymapArray[index].mappolicyname = resources[index].mappolicyname;
          policymapArray[index].sd = resources[index].sd;
          policymapArray[index].su = resources[index].su;
          policymapArray[index].td = resources[index].td;
          policymapArray[index].tu = resources[index].tu;
        }
        baseResponses = base_resource.add_bulk_request(client, (base_resource[]) policymapArray);
      }
      return baseResponses;
    }

    public static base_response delete(nitro_service client, string mappolicyname) => new policymap()
    {
      mappolicyname = mappolicyname
    }.delete_resource(client);

    public static base_response delete(nitro_service client, policymap resource) => new policymap()
    {
      mappolicyname = resource.mappolicyname
    }.delete_resource(client);

    public static base_responses delete(nitro_service client, string[] mappolicyname)
    {
      base_responses baseResponses = (base_responses) null;
      if (mappolicyname != null && mappolicyname.Length > 0)
      {
        policymap[] policymapArray = new policymap[mappolicyname.Length];
        for (int index = 0; index < mappolicyname.Length; ++index)
        {
          policymapArray[index] = new policymap();
          policymapArray[index].mappolicyname = mappolicyname[index];
        }
        baseResponses = base_resource.delete_bulk_request(client, (base_resource[]) policymapArray);
      }
      return baseResponses;
    }

    public static base_responses delete(nitro_service client, policymap[] resources)
    {
      base_responses baseResponses = (base_responses) null;
      if (resources != null && resources.Length > 0)
      {
        policymap[] policymapArray = new policymap[resources.Length];
        for (int index = 0; index < resources.Length; ++index)
        {
          policymapArray[index] = new policymap();
          policymapArray[index].mappolicyname = resources[index].mappolicyname;
        }
        baseResponses = base_resource.delete_bulk_request(client, (base_resource[]) policymapArray);
      }
      return baseResponses;
    }

    public static policymap[] get(nitro_service service) => (policymap[]) new policymap().get_resources(service, (options) null);

    public static policymap[] get(nitro_service service, options option) => (policymap[]) new policymap().get_resources(service, option);

    public static policymap get(nitro_service service, string mappolicyname) => (policymap) new policymap()
    {
      mappolicyname = mappolicyname
    }.get_resource(service);

    public static policymap[] get(nitro_service service, string[] mappolicyname)
    {
      if (mappolicyname == null || mappolicyname.Length <= 0)
        return (policymap[]) null;
      policymap[] policymapArray1 = new policymap[mappolicyname.Length];
      policymap[] policymapArray2 = new policymap[mappolicyname.Length];
      for (int index = 0; index < mappolicyname.Length; ++index)
      {
        policymapArray2[index] = new policymap();
        policymapArray2[index].mappolicyname = mappolicyname[index];
        policymapArray1[index] = (policymap) policymapArray2[index].get_resource(service);
      }
      return policymapArray1;
    }

    public static policymap[] get_filtered(nitro_service service, string filter)
    {
      policymap policymap = new policymap();
      options option = new options();
      option.set_filter(filter);
      return (policymap[]) policymap.getfiltered(service, option);
    }

    public static policymap[] get_filtered(nitro_service service, filtervalue[] filter)
    {
      policymap policymap = new policymap();
      options option = new options();
      option.set_filter(filter);
      return (policymap[]) policymap.getfiltered(service, option);
    }

    public static uint count(nitro_service service)
    {
      policymap policymap = new policymap();
      options option = new options();
      option.set_count(true);
      policymap[] resources = (policymap[]) policymap.get_resources(service, option);
      return resources != null && resources.Length > 0 ? resources[0].__count.Value : 0U;
    }

    public static uint count_filtered(nitro_service service, string filter)
    {
      policymap policymap = new policymap();
      options option = new options();
      option.set_count(true);
      option.set_filter(filter);
      policymap[] policymapArray = (policymap[]) policymap.getfiltered(service, option);
      return policymapArray != null && policymapArray.Length > 0 ? policymapArray[0].__count.Value : 0U;
    }

    public static uint count_filtered(nitro_service service, filtervalue[] filter)
    {
      policymap policymap = new policymap();
      options option = new options();
      option.set_count(true);
      option.set_filter(filter);
      policymap[] policymapArray = (policymap[]) policymap.getfiltered(service, option);
      return policymapArray != null && policymapArray.Length > 0 ? policymapArray[0].__count.Value : 0U;
    }

    private class policymap_response : base_response
    {
      public policymap[] policymap = (policymap[]) null;
    }
  }
}
