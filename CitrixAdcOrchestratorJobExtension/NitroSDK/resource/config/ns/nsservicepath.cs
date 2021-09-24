// Decompiled with JetBrains decompiler
// Type: com.citrix.netscaler.nitro.resource.config.ns.nsservicepath
// Assembly: nitro, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 6CF5DDEF-E052-4F9D-953F-6644F8378A66


using com.citrix.netscaler.nitro.exception;
using com.citrix.netscaler.nitro.resource.Base;
using com.citrix.netscaler.nitro.service;
using com.citrix.netscaler.nitro.util;

namespace com.citrix.netscaler.nitro.resource.config.ns
{
  public class nsservicepath : base_resource
  {
    private string servicepathnameField = (string) null;
    private uint? __countField = new uint?();

    public uint? __count
    {
      get => this.__countField;
      private set => this.__countField = value;
    }

    public string servicepathname
    {
      get => this.servicepathnameField;
      set => this.servicepathnameField = value;
    }

    internal override base_resource[] get_nitro_response(
      nitro_service service,
      string response)
    {
      nsservicepath.nsservicepath_response nsservicepathResponse = new nsservicepath.nsservicepath_response();
      nsservicepath.nsservicepath_response resource = (nsservicepath.nsservicepath_response) service.get_payload_formatter().string_to_resource(nsservicepathResponse.GetType(), response);
      if (resource.errorcode != 0)
      {
        if (resource.errorcode == 444)
          service.clear_session();
        if (resource.severity == null)
          throw new nitro_exception(resource.message, resource.errorcode);
        if (resource.severity.Equals("ERROR"))
          throw new nitro_exception(resource.message, resource.errorcode);
      }
      return (base_resource[]) resource.nsservicepath;
    }

    internal override string get_object_name() => this.servicepathname;

    public static base_response add(nitro_service client, nsservicepath resource) => new nsservicepath()
    {
      servicepathname = resource.servicepathname
    }.add_resource(client);

    public static base_responses add(nitro_service client, nsservicepath[] resources)
    {
      base_responses baseResponses = (base_responses) null;
      if (resources != null && resources.Length > 0)
      {
        nsservicepath[] nsservicepathArray = new nsservicepath[resources.Length];
        for (int index = 0; index < resources.Length; ++index)
        {
          nsservicepathArray[index] = new nsservicepath();
          nsservicepathArray[index].servicepathname = resources[index].servicepathname;
        }
        baseResponses = base_resource.add_bulk_request(client, (base_resource[]) nsservicepathArray);
      }
      return baseResponses;
    }

    public static base_response delete(nitro_service client, string servicepathname) => new nsservicepath()
    {
      servicepathname = servicepathname
    }.delete_resource(client);

    public static base_response delete(nitro_service client, nsservicepath resource) => new nsservicepath()
    {
      servicepathname = resource.servicepathname
    }.delete_resource(client);

    public static base_responses delete(
      nitro_service client,
      string[] servicepathname)
    {
      base_responses baseResponses = (base_responses) null;
      if (servicepathname != null && servicepathname.Length > 0)
      {
        nsservicepath[] nsservicepathArray = new nsservicepath[servicepathname.Length];
        for (int index = 0; index < servicepathname.Length; ++index)
        {
          nsservicepathArray[index] = new nsservicepath();
          nsservicepathArray[index].servicepathname = servicepathname[index];
        }
        baseResponses = base_resource.delete_bulk_request(client, (base_resource[]) nsservicepathArray);
      }
      return baseResponses;
    }

    public static base_responses delete(
      nitro_service client,
      nsservicepath[] resources)
    {
      base_responses baseResponses = (base_responses) null;
      if (resources != null && resources.Length > 0)
      {
        nsservicepath[] nsservicepathArray = new nsservicepath[resources.Length];
        for (int index = 0; index < resources.Length; ++index)
        {
          nsservicepathArray[index] = new nsservicepath();
          nsservicepathArray[index].servicepathname = resources[index].servicepathname;
        }
        baseResponses = base_resource.delete_bulk_request(client, (base_resource[]) nsservicepathArray);
      }
      return baseResponses;
    }

    public static nsservicepath[] get(nitro_service service) => (nsservicepath[]) new nsservicepath().get_resources(service, (options) null);

    public static nsservicepath[] get(nitro_service service, options option) => (nsservicepath[]) new nsservicepath().get_resources(service, option);

    public static nsservicepath get(nitro_service service, string servicepathname) => (nsservicepath) new nsservicepath()
    {
      servicepathname = servicepathname
    }.get_resource(service);

    public static nsservicepath[] get(nitro_service service, string[] servicepathname)
    {
      if (servicepathname == null || servicepathname.Length <= 0)
        return (nsservicepath[]) null;
      nsservicepath[] nsservicepathArray1 = new nsservicepath[servicepathname.Length];
      nsservicepath[] nsservicepathArray2 = new nsservicepath[servicepathname.Length];
      for (int index = 0; index < servicepathname.Length; ++index)
      {
        nsservicepathArray2[index] = new nsservicepath();
        nsservicepathArray2[index].servicepathname = servicepathname[index];
        nsservicepathArray1[index] = (nsservicepath) nsservicepathArray2[index].get_resource(service);
      }
      return nsservicepathArray1;
    }

    public static nsservicepath[] get_filtered(nitro_service service, string filter)
    {
      nsservicepath nsservicepath = new nsservicepath();
      options option = new options();
      option.set_filter(filter);
      return (nsservicepath[]) nsservicepath.getfiltered(service, option);
    }

    public static nsservicepath[] get_filtered(
      nitro_service service,
      filtervalue[] filter)
    {
      nsservicepath nsservicepath = new nsservicepath();
      options option = new options();
      option.set_filter(filter);
      return (nsservicepath[]) nsservicepath.getfiltered(service, option);
    }

    public static uint count(nitro_service service)
    {
      nsservicepath nsservicepath = new nsservicepath();
      options option = new options();
      option.set_count(true);
      nsservicepath[] resources = (nsservicepath[]) nsservicepath.get_resources(service, option);
      return resources != null && resources.Length > 0 ? resources[0].__count.Value : 0U;
    }

    public static uint count_filtered(nitro_service service, string filter)
    {
      nsservicepath nsservicepath = new nsservicepath();
      options option = new options();
      option.set_count(true);
      option.set_filter(filter);
      nsservicepath[] nsservicepathArray = (nsservicepath[]) nsservicepath.getfiltered(service, option);
      return nsservicepathArray != null && nsservicepathArray.Length > 0 ? nsservicepathArray[0].__count.Value : 0U;
    }

    public static uint count_filtered(nitro_service service, filtervalue[] filter)
    {
      nsservicepath nsservicepath = new nsservicepath();
      options option = new options();
      option.set_count(true);
      option.set_filter(filter);
      nsservicepath[] nsservicepathArray = (nsservicepath[]) nsservicepath.getfiltered(service, option);
      return nsservicepathArray != null && nsservicepathArray.Length > 0 ? nsservicepathArray[0].__count.Value : 0U;
    }

    private class nsservicepath_response : base_response
    {
      public nsservicepath[] nsservicepath = (nsservicepath[]) null;
    }
  }
}
