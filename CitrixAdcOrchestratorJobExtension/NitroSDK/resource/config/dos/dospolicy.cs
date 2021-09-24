// Decompiled with JetBrains decompiler
// Type: com.citrix.netscaler.nitro.resource.config.dos.dospolicy
// Assembly: nitro, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 6CF5DDEF-E052-4F9D-953F-6644F8378A66


using com.citrix.netscaler.nitro.exception;
using com.citrix.netscaler.nitro.resource.Base;
using com.citrix.netscaler.nitro.service;
using com.citrix.netscaler.nitro.util;

namespace com.citrix.netscaler.nitro.resource.config.dos
{
  public class dospolicy : base_resource
  {
    private string nameField = (string) null;
    private uint? qdepthField = new uint?();
    private uint? cltdetectrateField = new uint?();
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

    public uint? qdepth
    {
      get => this.qdepthField;
      set => this.qdepthField = value;
    }

    public uint? cltdetectrate
    {
      get => this.cltdetectrateField;
      set => this.cltdetectrateField = value;
    }

    internal override base_resource[] get_nitro_response(
      nitro_service service,
      string response)
    {
      dospolicy.dospolicy_response dospolicyResponse = new dospolicy.dospolicy_response();
      dospolicy.dospolicy_response resource = (dospolicy.dospolicy_response) service.get_payload_formatter().string_to_resource(dospolicyResponse.GetType(), response);
      if (resource.errorcode != 0)
      {
        if (resource.errorcode == 444)
          service.clear_session();
        if (resource.severity == null)
          throw new nitro_exception(resource.message, resource.errorcode);
        if (resource.severity.Equals("ERROR"))
          throw new nitro_exception(resource.message, resource.errorcode);
      }
      return (base_resource[]) resource.dospolicy;
    }

    internal override string get_object_name() => this.name;

    public static base_response add(nitro_service client, dospolicy resource) => new dospolicy()
    {
      name = resource.name,
      qdepth = resource.qdepth,
      cltdetectrate = resource.cltdetectrate
    }.add_resource(client);

    public static base_responses add(nitro_service client, dospolicy[] resources)
    {
      base_responses baseResponses = (base_responses) null;
      if (resources != null && resources.Length > 0)
      {
        dospolicy[] dospolicyArray = new dospolicy[resources.Length];
        for (int index = 0; index < resources.Length; ++index)
        {
          dospolicyArray[index] = new dospolicy();
          dospolicyArray[index].name = resources[index].name;
          dospolicyArray[index].qdepth = resources[index].qdepth;
          dospolicyArray[index].cltdetectrate = resources[index].cltdetectrate;
        }
        baseResponses = base_resource.add_bulk_request(client, (base_resource[]) dospolicyArray);
      }
      return baseResponses;
    }

    public static base_response delete(nitro_service client, string name) => new dospolicy()
    {
      name = name
    }.delete_resource(client);

    public static base_response delete(nitro_service client, dospolicy resource) => new dospolicy()
    {
      name = resource.name
    }.delete_resource(client);

    public static base_responses delete(nitro_service client, string[] name)
    {
      base_responses baseResponses = (base_responses) null;
      if (name != null && name.Length > 0)
      {
        dospolicy[] dospolicyArray = new dospolicy[name.Length];
        for (int index = 0; index < name.Length; ++index)
        {
          dospolicyArray[index] = new dospolicy();
          dospolicyArray[index].name = name[index];
        }
        baseResponses = base_resource.delete_bulk_request(client, (base_resource[]) dospolicyArray);
      }
      return baseResponses;
    }

    public static base_responses delete(nitro_service client, dospolicy[] resources)
    {
      base_responses baseResponses = (base_responses) null;
      if (resources != null && resources.Length > 0)
      {
        dospolicy[] dospolicyArray = new dospolicy[resources.Length];
        for (int index = 0; index < resources.Length; ++index)
        {
          dospolicyArray[index] = new dospolicy();
          dospolicyArray[index].name = resources[index].name;
        }
        baseResponses = base_resource.delete_bulk_request(client, (base_resource[]) dospolicyArray);
      }
      return baseResponses;
    }

    public static base_response update(nitro_service client, dospolicy resource) => new dospolicy()
    {
      name = resource.name,
      qdepth = resource.qdepth,
      cltdetectrate = resource.cltdetectrate
    }.update_resource(client);

    public static base_responses update(nitro_service client, dospolicy[] resources)
    {
      base_responses baseResponses = (base_responses) null;
      if (resources != null && resources.Length > 0)
      {
        dospolicy[] dospolicyArray = new dospolicy[resources.Length];
        for (int index = 0; index < resources.Length; ++index)
        {
          dospolicyArray[index] = new dospolicy();
          dospolicyArray[index].name = resources[index].name;
          dospolicyArray[index].qdepth = resources[index].qdepth;
          dospolicyArray[index].cltdetectrate = resources[index].cltdetectrate;
        }
        baseResponses = base_resource.update_bulk_request(client, (base_resource[]) dospolicyArray);
      }
      return baseResponses;
    }

    public static base_response unset(
      nitro_service client,
      string name,
      string[] args)
    {
      return new dospolicy() { name = name }.unset_resource(client, args);
    }

    public static base_response unset(
      nitro_service client,
      dospolicy resource,
      string[] args)
    {
      return new dospolicy() { name = resource.name }.unset_resource(client, args);
    }

    public static base_responses unset(
      nitro_service client,
      string[] name,
      string[] args)
    {
      base_responses baseResponses = (base_responses) null;
      if (name != null && name.Length > 0)
      {
        dospolicy[] dospolicyArray = new dospolicy[name.Length];
        for (int index = 0; index < name.Length; ++index)
        {
          dospolicyArray[index] = new dospolicy();
          dospolicyArray[index].name = name[index];
        }
        baseResponses = base_resource.unset_bulk_request(client, (base_resource[]) dospolicyArray, args);
      }
      return baseResponses;
    }

    public static base_responses unset(
      nitro_service client,
      dospolicy[] resources,
      string[] args)
    {
      base_responses baseResponses = (base_responses) null;
      if (resources != null && resources.Length > 0)
      {
        dospolicy[] dospolicyArray = new dospolicy[resources.Length];
        for (int index = 0; index < resources.Length; ++index)
        {
          dospolicyArray[index] = new dospolicy();
          dospolicyArray[index].name = resources[index].name;
        }
        baseResponses = base_resource.unset_bulk_request(client, (base_resource[]) dospolicyArray, args);
      }
      return baseResponses;
    }

    public static dospolicy[] get(nitro_service service) => (dospolicy[]) new dospolicy().get_resources(service, (options) null);

    public static dospolicy[] get(nitro_service service, options option) => (dospolicy[]) new dospolicy().get_resources(service, option);

    public static dospolicy get(nitro_service service, string name) => (dospolicy) new dospolicy()
    {
      name = name
    }.get_resource(service);

    public static dospolicy[] get(nitro_service service, string[] name)
    {
      if (name == null || name.Length <= 0)
        return (dospolicy[]) null;
      dospolicy[] dospolicyArray1 = new dospolicy[name.Length];
      dospolicy[] dospolicyArray2 = new dospolicy[name.Length];
      for (int index = 0; index < name.Length; ++index)
      {
        dospolicyArray2[index] = new dospolicy();
        dospolicyArray2[index].name = name[index];
        dospolicyArray1[index] = (dospolicy) dospolicyArray2[index].get_resource(service);
      }
      return dospolicyArray1;
    }

    public static dospolicy[] get_filtered(nitro_service service, string filter)
    {
      dospolicy dospolicy = new dospolicy();
      options option = new options();
      option.set_filter(filter);
      return (dospolicy[]) dospolicy.getfiltered(service, option);
    }

    public static dospolicy[] get_filtered(nitro_service service, filtervalue[] filter)
    {
      dospolicy dospolicy = new dospolicy();
      options option = new options();
      option.set_filter(filter);
      return (dospolicy[]) dospolicy.getfiltered(service, option);
    }

    public static uint count(nitro_service service)
    {
      dospolicy dospolicy = new dospolicy();
      options option = new options();
      option.set_count(true);
      dospolicy[] resources = (dospolicy[]) dospolicy.get_resources(service, option);
      return resources != null && resources.Length > 0 ? resources[0].__count.Value : 0U;
    }

    public static uint count_filtered(nitro_service service, string filter)
    {
      dospolicy dospolicy = new dospolicy();
      options option = new options();
      option.set_count(true);
      option.set_filter(filter);
      dospolicy[] dospolicyArray = (dospolicy[]) dospolicy.getfiltered(service, option);
      return dospolicyArray != null && dospolicyArray.Length > 0 ? dospolicyArray[0].__count.Value : 0U;
    }

    public static uint count_filtered(nitro_service service, filtervalue[] filter)
    {
      dospolicy dospolicy = new dospolicy();
      options option = new options();
      option.set_count(true);
      option.set_filter(filter);
      dospolicy[] dospolicyArray = (dospolicy[]) dospolicy.getfiltered(service, option);
      return dospolicyArray != null && dospolicyArray.Length > 0 ? dospolicyArray[0].__count.Value : 0U;
    }

    private class dospolicy_response : base_response
    {
      public dospolicy[] dospolicy = (dospolicy[]) null;
    }
  }
}
