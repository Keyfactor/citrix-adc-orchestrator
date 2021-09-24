// Decompiled with JetBrains decompiler
// Type: com.citrix.netscaler.nitro.resource.config.ns.nstimer
// Assembly: nitro, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 6CF5DDEF-E052-4F9D-953F-6644F8378A66


using com.citrix.netscaler.nitro.exception;
using com.citrix.netscaler.nitro.resource.Base;
using com.citrix.netscaler.nitro.service;
using com.citrix.netscaler.nitro.util;

namespace com.citrix.netscaler.nitro.resource.config.ns
{
  public class nstimer : base_resource
  {
    private string nameField = (string) null;
    private int? intervalField = new int?();
    private string unitField = (string) null;
    private string commentField = (string) null;
    private string newnameField = (string) null;
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

    public int? interval
    {
      get => this.intervalField;
      set => this.intervalField = value;
    }

    public string unit
    {
      get => this.unitField;
      set => this.unitField = value;
    }

    public string comment
    {
      get => this.commentField;
      set => this.commentField = value;
    }

    public string newname
    {
      get => this.newnameField;
      set => this.newnameField = value;
    }

    internal override base_resource[] get_nitro_response(
      nitro_service service,
      string response)
    {
      nstimer.nstimer_response nstimerResponse = new nstimer.nstimer_response();
      nstimer.nstimer_response resource = (nstimer.nstimer_response) service.get_payload_formatter().string_to_resource(nstimerResponse.GetType(), response);
      if (resource.errorcode != 0)
      {
        if (resource.errorcode == 444)
          service.clear_session();
        if (resource.severity == null)
          throw new nitro_exception(resource.message, resource.errorcode);
        if (resource.severity.Equals("ERROR"))
          throw new nitro_exception(resource.message, resource.errorcode);
      }
      return (base_resource[]) resource.nstimer;
    }

    internal override string get_object_name() => this.name;

    public static base_response add(nitro_service client, nstimer resource) => new nstimer()
    {
      name = resource.name,
      interval = resource.interval,
      unit = resource.unit,
      comment = resource.comment
    }.add_resource(client);

    public static base_responses add(nitro_service client, nstimer[] resources)
    {
      base_responses baseResponses = (base_responses) null;
      if (resources != null && resources.Length > 0)
      {
        nstimer[] nstimerArray = new nstimer[resources.Length];
        for (int index = 0; index < resources.Length; ++index)
        {
          nstimerArray[index] = new nstimer();
          nstimerArray[index].name = resources[index].name;
          nstimerArray[index].interval = resources[index].interval;
          nstimerArray[index].unit = resources[index].unit;
          nstimerArray[index].comment = resources[index].comment;
        }
        baseResponses = base_resource.add_bulk_request(client, (base_resource[]) nstimerArray);
      }
      return baseResponses;
    }

    public static base_response delete(nitro_service client, string name) => new nstimer()
    {
      name = name
    }.delete_resource(client);

    public static base_response delete(nitro_service client, nstimer resource) => new nstimer()
    {
      name = resource.name
    }.delete_resource(client);

    public static base_responses delete(nitro_service client, string[] name)
    {
      base_responses baseResponses = (base_responses) null;
      if (name != null && name.Length > 0)
      {
        nstimer[] nstimerArray = new nstimer[name.Length];
        for (int index = 0; index < name.Length; ++index)
        {
          nstimerArray[index] = new nstimer();
          nstimerArray[index].name = name[index];
        }
        baseResponses = base_resource.delete_bulk_request(client, (base_resource[]) nstimerArray);
      }
      return baseResponses;
    }

    public static base_responses delete(nitro_service client, nstimer[] resources)
    {
      base_responses baseResponses = (base_responses) null;
      if (resources != null && resources.Length > 0)
      {
        nstimer[] nstimerArray = new nstimer[resources.Length];
        for (int index = 0; index < resources.Length; ++index)
        {
          nstimerArray[index] = new nstimer();
          nstimerArray[index].name = resources[index].name;
        }
        baseResponses = base_resource.delete_bulk_request(client, (base_resource[]) nstimerArray);
      }
      return baseResponses;
    }

    public static base_response update(nitro_service client, nstimer resource) => new nstimer()
    {
      name = resource.name,
      interval = resource.interval,
      unit = resource.unit,
      comment = resource.comment
    }.update_resource(client);

    public static base_responses update(nitro_service client, nstimer[] resources)
    {
      base_responses baseResponses = (base_responses) null;
      if (resources != null && resources.Length > 0)
      {
        nstimer[] nstimerArray = new nstimer[resources.Length];
        for (int index = 0; index < resources.Length; ++index)
        {
          nstimerArray[index] = new nstimer();
          nstimerArray[index].name = resources[index].name;
          nstimerArray[index].interval = resources[index].interval;
          nstimerArray[index].unit = resources[index].unit;
          nstimerArray[index].comment = resources[index].comment;
        }
        baseResponses = base_resource.update_bulk_request(client, (base_resource[]) nstimerArray);
      }
      return baseResponses;
    }

    public static base_response unset(
      nitro_service client,
      string name,
      string[] args)
    {
      return new nstimer() { name = name }.unset_resource(client, args);
    }

    public static base_response unset(
      nitro_service client,
      nstimer resource,
      string[] args)
    {
      return new nstimer()
      {
        name = resource.name,
        interval = resource.interval,
        unit = resource.unit,
        comment = resource.comment
      }.unset_resource(client, args);
    }

    public static base_responses unset(
      nitro_service client,
      string[] name,
      string[] args)
    {
      base_responses baseResponses = (base_responses) null;
      if (name != null && name.Length > 0)
      {
        nstimer[] nstimerArray = new nstimer[name.Length];
        for (int index = 0; index < name.Length; ++index)
        {
          nstimerArray[index] = new nstimer();
          nstimerArray[index].name = name[index];
        }
        baseResponses = base_resource.unset_bulk_request(client, (base_resource[]) nstimerArray, args);
      }
      return baseResponses;
    }

    public static base_responses unset(
      nitro_service client,
      nstimer[] resources,
      string[] args)
    {
      base_responses baseResponses = (base_responses) null;
      if (resources != null && resources.Length > 0)
      {
        nstimer[] nstimerArray = new nstimer[resources.Length];
        for (int index = 0; index < resources.Length; ++index)
        {
          nstimerArray[index] = new nstimer();
          nstimerArray[index].name = resources[index].name;
          nstimerArray[index].interval = resources[index].interval;
          nstimerArray[index].unit = resources[index].unit;
          nstimerArray[index].comment = resources[index].comment;
        }
        baseResponses = base_resource.unset_bulk_request(client, (base_resource[]) nstimerArray, args);
      }
      return baseResponses;
    }

    public static base_response rename(
      nitro_service client,
      nstimer resource,
      string new_name)
    {
      return new nstimer()
      {
        name = resource.name,
        newname = new_name
      }.rename_resource(client);
    }

    public static base_response rename(
      nitro_service client,
      string name,
      string new_name)
    {
      return new nstimer()
      {
        name = name,
        newname = new_name
      }.rename_resource(client);
    }

    public static nstimer[] get(nitro_service service) => (nstimer[]) new nstimer().get_resources(service, (options) null);

    public static nstimer[] get(nitro_service service, options option) => (nstimer[]) new nstimer().get_resources(service, option);

    public static nstimer get(nitro_service service, string name) => (nstimer) new nstimer()
    {
      name = name
    }.get_resource(service);

    public static nstimer[] get(nitro_service service, string[] name)
    {
      if (name == null || name.Length <= 0)
        return (nstimer[]) null;
      nstimer[] nstimerArray1 = new nstimer[name.Length];
      nstimer[] nstimerArray2 = new nstimer[name.Length];
      for (int index = 0; index < name.Length; ++index)
      {
        nstimerArray2[index] = new nstimer();
        nstimerArray2[index].name = name[index];
        nstimerArray1[index] = (nstimer) nstimerArray2[index].get_resource(service);
      }
      return nstimerArray1;
    }

    public static nstimer[] get_filtered(nitro_service service, string filter)
    {
      nstimer nstimer = new nstimer();
      options option = new options();
      option.set_filter(filter);
      return (nstimer[]) nstimer.getfiltered(service, option);
    }

    public static nstimer[] get_filtered(nitro_service service, filtervalue[] filter)
    {
      nstimer nstimer = new nstimer();
      options option = new options();
      option.set_filter(filter);
      return (nstimer[]) nstimer.getfiltered(service, option);
    }

    public static uint count(nitro_service service)
    {
      nstimer nstimer = new nstimer();
      options option = new options();
      option.set_count(true);
      nstimer[] resources = (nstimer[]) nstimer.get_resources(service, option);
      return resources != null && resources.Length > 0 ? resources[0].__count.Value : 0U;
    }

    public static uint count_filtered(nitro_service service, string filter)
    {
      nstimer nstimer = new nstimer();
      options option = new options();
      option.set_count(true);
      option.set_filter(filter);
      nstimer[] nstimerArray = (nstimer[]) nstimer.getfiltered(service, option);
      return nstimerArray != null && nstimerArray.Length > 0 ? nstimerArray[0].__count.Value : 0U;
    }

    public static uint count_filtered(nitro_service service, filtervalue[] filter)
    {
      nstimer nstimer = new nstimer();
      options option = new options();
      option.set_count(true);
      option.set_filter(filter);
      nstimer[] nstimerArray = (nstimer[]) nstimer.getfiltered(service, option);
      return nstimerArray != null && nstimerArray.Length > 0 ? nstimerArray[0].__count.Value : 0U;
    }

    private class nstimer_response : base_response
    {
      public nstimer[] nstimer = (nstimer[]) null;
    }

    public static class unitEnum
    {
      public const string SEC = "SEC";
      public const string MIN = "MIN";
    }
  }
}
