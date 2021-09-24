// Decompiled with JetBrains decompiler
// Type: com.citrix.netscaler.nitro.resource.config.appqoe.appqoeaction
// Assembly: nitro, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 6CF5DDEF-E052-4F9D-953F-6644F8378A66


using com.citrix.netscaler.nitro.exception;
using com.citrix.netscaler.nitro.resource.Base;
using com.citrix.netscaler.nitro.service;
using com.citrix.netscaler.nitro.util;

namespace com.citrix.netscaler.nitro.resource.config.appqoe
{
  public class appqoeaction : base_resource
  {
    private string nameField = (string) null;
    private string priorityField = (string) null;
    private string respondwithField = (string) null;
    private string customfileField = (string) null;
    private string altcontentsvcnameField = (string) null;
    private string altcontentpathField = (string) null;
    private uint? polqdepthField = new uint?();
    private uint? priqdepthField = new uint?();
    private uint? maxconnField = new uint?();
    private uint? delayField = new uint?();
    private string dostrigexpressionField = (string) null;
    private string dosactionField = (string) null;
    private long? hitsField = new long?();
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

    public string priority
    {
      get => this.priorityField;
      set => this.priorityField = value;
    }

    public string respondwith
    {
      get => this.respondwithField;
      set => this.respondwithField = value;
    }

    public string customfile
    {
      get => this.customfileField;
      set => this.customfileField = value;
    }

    public string altcontentsvcname
    {
      get => this.altcontentsvcnameField;
      set => this.altcontentsvcnameField = value;
    }

    public string altcontentpath
    {
      get => this.altcontentpathField;
      set => this.altcontentpathField = value;
    }

    public uint? polqdepth
    {
      get => this.polqdepthField;
      set => this.polqdepthField = value;
    }

    public uint? priqdepth
    {
      get => this.priqdepthField;
      set => this.priqdepthField = value;
    }

    public uint? maxconn
    {
      get => this.maxconnField;
      set => this.maxconnField = value;
    }

    public uint? delay
    {
      get => this.delayField;
      set => this.delayField = value;
    }

    public string dostrigexpression
    {
      get => this.dostrigexpressionField;
      set => this.dostrigexpressionField = value;
    }

    public string dosaction
    {
      get => this.dosactionField;
      set => this.dosactionField = value;
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
      appqoeaction.appqoeaction_response appqoeactionResponse = new appqoeaction.appqoeaction_response();
      appqoeaction.appqoeaction_response resource = (appqoeaction.appqoeaction_response) service.get_payload_formatter().string_to_resource(appqoeactionResponse.GetType(), response);
      if (resource.errorcode != 0)
      {
        if (resource.errorcode == 444)
          service.clear_session();
        if (resource.severity == null)
          throw new nitro_exception(resource.message, resource.errorcode);
        if (resource.severity.Equals("ERROR"))
          throw new nitro_exception(resource.message, resource.errorcode);
      }
      return (base_resource[]) resource.appqoeaction;
    }

    internal override string get_object_name() => this.name;

    public static base_response add(nitro_service client, appqoeaction resource) => new appqoeaction()
    {
      name = resource.name,
      priority = resource.priority,
      respondwith = resource.respondwith,
      customfile = resource.customfile,
      altcontentsvcname = resource.altcontentsvcname,
      altcontentpath = resource.altcontentpath,
      polqdepth = resource.polqdepth,
      priqdepth = resource.priqdepth,
      maxconn = resource.maxconn,
      delay = resource.delay,
      dostrigexpression = resource.dostrigexpression,
      dosaction = resource.dosaction
    }.add_resource(client);

    public static base_responses add(nitro_service client, appqoeaction[] resources)
    {
      base_responses baseResponses = (base_responses) null;
      if (resources != null && resources.Length > 0)
      {
        appqoeaction[] appqoeactionArray = new appqoeaction[resources.Length];
        for (int index = 0; index < resources.Length; ++index)
        {
          appqoeactionArray[index] = new appqoeaction();
          appqoeactionArray[index].name = resources[index].name;
          appqoeactionArray[index].priority = resources[index].priority;
          appqoeactionArray[index].respondwith = resources[index].respondwith;
          appqoeactionArray[index].customfile = resources[index].customfile;
          appqoeactionArray[index].altcontentsvcname = resources[index].altcontentsvcname;
          appqoeactionArray[index].altcontentpath = resources[index].altcontentpath;
          appqoeactionArray[index].polqdepth = resources[index].polqdepth;
          appqoeactionArray[index].priqdepth = resources[index].priqdepth;
          appqoeactionArray[index].maxconn = resources[index].maxconn;
          appqoeactionArray[index].delay = resources[index].delay;
          appqoeactionArray[index].dostrigexpression = resources[index].dostrigexpression;
          appqoeactionArray[index].dosaction = resources[index].dosaction;
        }
        baseResponses = base_resource.add_bulk_request(client, (base_resource[]) appqoeactionArray);
      }
      return baseResponses;
    }

    public static base_response delete(nitro_service client, string name) => new appqoeaction()
    {
      name = name
    }.delete_resource(client);

    public static base_response delete(nitro_service client, appqoeaction resource) => new appqoeaction()
    {
      name = resource.name
    }.delete_resource(client);

    public static base_responses delete(nitro_service client, string[] name)
    {
      base_responses baseResponses = (base_responses) null;
      if (name != null && name.Length > 0)
      {
        appqoeaction[] appqoeactionArray = new appqoeaction[name.Length];
        for (int index = 0; index < name.Length; ++index)
        {
          appqoeactionArray[index] = new appqoeaction();
          appqoeactionArray[index].name = name[index];
        }
        baseResponses = base_resource.delete_bulk_request(client, (base_resource[]) appqoeactionArray);
      }
      return baseResponses;
    }

    public static base_responses delete(
      nitro_service client,
      appqoeaction[] resources)
    {
      base_responses baseResponses = (base_responses) null;
      if (resources != null && resources.Length > 0)
      {
        appqoeaction[] appqoeactionArray = new appqoeaction[resources.Length];
        for (int index = 0; index < resources.Length; ++index)
        {
          appqoeactionArray[index] = new appqoeaction();
          appqoeactionArray[index].name = resources[index].name;
        }
        baseResponses = base_resource.delete_bulk_request(client, (base_resource[]) appqoeactionArray);
      }
      return baseResponses;
    }

    public static base_response update(nitro_service client, appqoeaction resource) => new appqoeaction()
    {
      name = resource.name,
      priority = resource.priority,
      altcontentsvcname = resource.altcontentsvcname,
      altcontentpath = resource.altcontentpath,
      polqdepth = resource.polqdepth,
      priqdepth = resource.priqdepth,
      maxconn = resource.maxconn,
      delay = resource.delay,
      dostrigexpression = resource.dostrigexpression,
      dosaction = resource.dosaction
    }.update_resource(client);

    public static base_responses update(
      nitro_service client,
      appqoeaction[] resources)
    {
      base_responses baseResponses = (base_responses) null;
      if (resources != null && resources.Length > 0)
      {
        appqoeaction[] appqoeactionArray = new appqoeaction[resources.Length];
        for (int index = 0; index < resources.Length; ++index)
        {
          appqoeactionArray[index] = new appqoeaction();
          appqoeactionArray[index].name = resources[index].name;
          appqoeactionArray[index].priority = resources[index].priority;
          appqoeactionArray[index].altcontentsvcname = resources[index].altcontentsvcname;
          appqoeactionArray[index].altcontentpath = resources[index].altcontentpath;
          appqoeactionArray[index].polqdepth = resources[index].polqdepth;
          appqoeactionArray[index].priqdepth = resources[index].priqdepth;
          appqoeactionArray[index].maxconn = resources[index].maxconn;
          appqoeactionArray[index].delay = resources[index].delay;
          appqoeactionArray[index].dostrigexpression = resources[index].dostrigexpression;
          appqoeactionArray[index].dosaction = resources[index].dosaction;
        }
        baseResponses = base_resource.update_bulk_request(client, (base_resource[]) appqoeactionArray);
      }
      return baseResponses;
    }

    public static base_response unset(
      nitro_service client,
      string name,
      string[] args)
    {
      return new appqoeaction() { name = name }.unset_resource(client, args);
    }

    public static base_response unset(
      nitro_service client,
      appqoeaction resource,
      string[] args)
    {
      return new appqoeaction() { name = resource.name }.unset_resource(client, args);
    }

    public static base_responses unset(
      nitro_service client,
      string[] name,
      string[] args)
    {
      base_responses baseResponses = (base_responses) null;
      if (name != null && name.Length > 0)
      {
        appqoeaction[] appqoeactionArray = new appqoeaction[name.Length];
        for (int index = 0; index < name.Length; ++index)
        {
          appqoeactionArray[index] = new appqoeaction();
          appqoeactionArray[index].name = name[index];
        }
        baseResponses = base_resource.unset_bulk_request(client, (base_resource[]) appqoeactionArray, args);
      }
      return baseResponses;
    }

    public static base_responses unset(
      nitro_service client,
      appqoeaction[] resources,
      string[] args)
    {
      base_responses baseResponses = (base_responses) null;
      if (resources != null && resources.Length > 0)
      {
        appqoeaction[] appqoeactionArray = new appqoeaction[resources.Length];
        for (int index = 0; index < resources.Length; ++index)
        {
          appqoeactionArray[index] = new appqoeaction();
          appqoeactionArray[index].name = resources[index].name;
        }
        baseResponses = base_resource.unset_bulk_request(client, (base_resource[]) appqoeactionArray, args);
      }
      return baseResponses;
    }

    public static appqoeaction[] get(nitro_service service) => (appqoeaction[]) new appqoeaction().get_resources(service, (options) null);

    public static appqoeaction[] get(nitro_service service, options option) => (appqoeaction[]) new appqoeaction().get_resources(service, option);

    public static appqoeaction get(nitro_service service, string name) => (appqoeaction) new appqoeaction()
    {
      name = name
    }.get_resource(service);

    public static appqoeaction[] get(nitro_service service, string[] name)
    {
      if (name == null || name.Length <= 0)
        return (appqoeaction[]) null;
      appqoeaction[] appqoeactionArray1 = new appqoeaction[name.Length];
      appqoeaction[] appqoeactionArray2 = new appqoeaction[name.Length];
      for (int index = 0; index < name.Length; ++index)
      {
        appqoeactionArray2[index] = new appqoeaction();
        appqoeactionArray2[index].name = name[index];
        appqoeactionArray1[index] = (appqoeaction) appqoeactionArray2[index].get_resource(service);
      }
      return appqoeactionArray1;
    }

    public static appqoeaction[] get_filtered(nitro_service service, string filter)
    {
      appqoeaction appqoeaction = new appqoeaction();
      options option = new options();
      option.set_filter(filter);
      return (appqoeaction[]) appqoeaction.getfiltered(service, option);
    }

    public static appqoeaction[] get_filtered(
      nitro_service service,
      filtervalue[] filter)
    {
      appqoeaction appqoeaction = new appqoeaction();
      options option = new options();
      option.set_filter(filter);
      return (appqoeaction[]) appqoeaction.getfiltered(service, option);
    }

    public static uint count(nitro_service service)
    {
      appqoeaction appqoeaction = new appqoeaction();
      options option = new options();
      option.set_count(true);
      appqoeaction[] resources = (appqoeaction[]) appqoeaction.get_resources(service, option);
      return resources != null && resources.Length > 0 ? resources[0].__count.Value : 0U;
    }

    public static uint count_filtered(nitro_service service, string filter)
    {
      appqoeaction appqoeaction = new appqoeaction();
      options option = new options();
      option.set_count(true);
      option.set_filter(filter);
      appqoeaction[] appqoeactionArray = (appqoeaction[]) appqoeaction.getfiltered(service, option);
      return appqoeactionArray != null && appqoeactionArray.Length > 0 ? appqoeactionArray[0].__count.Value : 0U;
    }

    public static uint count_filtered(nitro_service service, filtervalue[] filter)
    {
      appqoeaction appqoeaction = new appqoeaction();
      options option = new options();
      option.set_count(true);
      option.set_filter(filter);
      appqoeaction[] appqoeactionArray = (appqoeaction[]) appqoeaction.getfiltered(service, option);
      return appqoeactionArray != null && appqoeactionArray.Length > 0 ? appqoeactionArray[0].__count.Value : 0U;
    }

    private class appqoeaction_response : base_response
    {
      public appqoeaction[] appqoeaction = (appqoeaction[]) null;
    }

    public static class priorityEnum
    {
      public const string HIGH = "HIGH";
      public const string MEDIUM = "MEDIUM";
      public const string LOW = "LOW";
      public const string LOWEST = "LOWEST";
    }

    public static class dosactionEnum
    {
      public const string SimpleResponse = "SimpleResponse";
      public const string HICResponse = "HICResponse";
    }

    public static class respondwithEnum
    {
      public const string ACS = "ACS";
      public const string NS = "NS";
    }
  }
}
