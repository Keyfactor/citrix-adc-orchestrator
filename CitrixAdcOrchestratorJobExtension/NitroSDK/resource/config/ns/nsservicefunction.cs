// Decompiled with JetBrains decompiler
// Type: com.citrix.netscaler.nitro.resource.config.ns.nsservicefunction
// Assembly: nitro, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 6CF5DDEF-E052-4F9D-953F-6644F8378A66


using com.citrix.netscaler.nitro.exception;
using com.citrix.netscaler.nitro.resource.Base;
using com.citrix.netscaler.nitro.service;
using com.citrix.netscaler.nitro.util;

namespace com.citrix.netscaler.nitro.resource.config.ns
{
  public class nsservicefunction : base_resource
  {
    private string servicefunctionnameField = (string) null;
    private uint? ingressvlanField = new uint?();
    private uint? __countField = new uint?();

    public uint? __count
    {
      get => this.__countField;
      private set => this.__countField = value;
    }

    public string servicefunctionname
    {
      get => this.servicefunctionnameField;
      set => this.servicefunctionnameField = value;
    }

    public uint? ingressvlan
    {
      get => this.ingressvlanField;
      set => this.ingressvlanField = value;
    }

    internal override base_resource[] get_nitro_response(
      nitro_service service,
      string response)
    {
      nsservicefunction.nsservicefunction_response nsservicefunctionResponse = new nsservicefunction.nsservicefunction_response();
      nsservicefunction.nsservicefunction_response resource = (nsservicefunction.nsservicefunction_response) service.get_payload_formatter().string_to_resource(nsservicefunctionResponse.GetType(), response);
      if (resource.errorcode != 0)
      {
        if (resource.errorcode == 444)
          service.clear_session();
        if (resource.severity == null)
          throw new nitro_exception(resource.message, resource.errorcode);
        if (resource.severity.Equals("ERROR"))
          throw new nitro_exception(resource.message, resource.errorcode);
      }
      return (base_resource[]) resource.nsservicefunction;
    }

    internal override string get_object_name() => this.servicefunctionname;

    public static base_response add(nitro_service client, nsservicefunction resource) => new nsservicefunction()
    {
      servicefunctionname = resource.servicefunctionname,
      ingressvlan = resource.ingressvlan
    }.add_resource(client);

    public static base_responses add(
      nitro_service client,
      nsservicefunction[] resources)
    {
      base_responses baseResponses = (base_responses) null;
      if (resources != null && resources.Length > 0)
      {
        nsservicefunction[] nsservicefunctionArray = new nsservicefunction[resources.Length];
        for (int index = 0; index < resources.Length; ++index)
        {
          nsservicefunctionArray[index] = new nsservicefunction();
          nsservicefunctionArray[index].servicefunctionname = resources[index].servicefunctionname;
          nsservicefunctionArray[index].ingressvlan = resources[index].ingressvlan;
        }
        baseResponses = base_resource.add_bulk_request(client, (base_resource[]) nsservicefunctionArray);
      }
      return baseResponses;
    }

    public static base_response update(
      nitro_service client,
      nsservicefunction resource)
    {
      return new nsservicefunction()
      {
        servicefunctionname = resource.servicefunctionname,
        ingressvlan = resource.ingressvlan
      }.update_resource(client);
    }

    public static base_responses update(
      nitro_service client,
      nsservicefunction[] resources)
    {
      base_responses baseResponses = (base_responses) null;
      if (resources != null && resources.Length > 0)
      {
        nsservicefunction[] nsservicefunctionArray = new nsservicefunction[resources.Length];
        for (int index = 0; index < resources.Length; ++index)
        {
          nsservicefunctionArray[index] = new nsservicefunction();
          nsservicefunctionArray[index].servicefunctionname = resources[index].servicefunctionname;
          nsservicefunctionArray[index].ingressvlan = resources[index].ingressvlan;
        }
        baseResponses = base_resource.update_bulk_request(client, (base_resource[]) nsservicefunctionArray);
      }
      return baseResponses;
    }

    public static base_response delete(
      nitro_service client,
      string servicefunctionname)
    {
      return new nsservicefunction()
      {
        servicefunctionname = servicefunctionname
      }.delete_resource(client);
    }

    public static base_response delete(
      nitro_service client,
      nsservicefunction resource)
    {
      return new nsservicefunction()
      {
        servicefunctionname = resource.servicefunctionname
      }.delete_resource(client);
    }

    public static base_responses delete(
      nitro_service client,
      string[] servicefunctionname)
    {
      base_responses baseResponses = (base_responses) null;
      if (servicefunctionname != null && servicefunctionname.Length > 0)
      {
        nsservicefunction[] nsservicefunctionArray = new nsservicefunction[servicefunctionname.Length];
        for (int index = 0; index < servicefunctionname.Length; ++index)
        {
          nsservicefunctionArray[index] = new nsservicefunction();
          nsservicefunctionArray[index].servicefunctionname = servicefunctionname[index];
        }
        baseResponses = base_resource.delete_bulk_request(client, (base_resource[]) nsservicefunctionArray);
      }
      return baseResponses;
    }

    public static base_responses delete(
      nitro_service client,
      nsservicefunction[] resources)
    {
      base_responses baseResponses = (base_responses) null;
      if (resources != null && resources.Length > 0)
      {
        nsservicefunction[] nsservicefunctionArray = new nsservicefunction[resources.Length];
        for (int index = 0; index < resources.Length; ++index)
        {
          nsservicefunctionArray[index] = new nsservicefunction();
          nsservicefunctionArray[index].servicefunctionname = resources[index].servicefunctionname;
        }
        baseResponses = base_resource.delete_bulk_request(client, (base_resource[]) nsservicefunctionArray);
      }
      return baseResponses;
    }

    public static nsservicefunction[] get(nitro_service service) => (nsservicefunction[]) new nsservicefunction().get_resources(service, (options) null);

    public static nsservicefunction[] get(nitro_service service, options option) => (nsservicefunction[]) new nsservicefunction().get_resources(service, option);

    public static nsservicefunction get(
      nitro_service service,
      string servicefunctionname)
    {
      return (nsservicefunction) new nsservicefunction()
      {
        servicefunctionname = servicefunctionname
      }.get_resource(service);
    }

    public static nsservicefunction[] get(
      nitro_service service,
      string[] servicefunctionname)
    {
      if (servicefunctionname == null || servicefunctionname.Length <= 0)
        return (nsservicefunction[]) null;
      nsservicefunction[] nsservicefunctionArray1 = new nsservicefunction[servicefunctionname.Length];
      nsservicefunction[] nsservicefunctionArray2 = new nsservicefunction[servicefunctionname.Length];
      for (int index = 0; index < servicefunctionname.Length; ++index)
      {
        nsservicefunctionArray2[index] = new nsservicefunction();
        nsservicefunctionArray2[index].servicefunctionname = servicefunctionname[index];
        nsservicefunctionArray1[index] = (nsservicefunction) nsservicefunctionArray2[index].get_resource(service);
      }
      return nsservicefunctionArray1;
    }

    public static nsservicefunction[] get_filtered(
      nitro_service service,
      string filter)
    {
      nsservicefunction nsservicefunction = new nsservicefunction();
      options option = new options();
      option.set_filter(filter);
      return (nsservicefunction[]) nsservicefunction.getfiltered(service, option);
    }

    public static nsservicefunction[] get_filtered(
      nitro_service service,
      filtervalue[] filter)
    {
      nsservicefunction nsservicefunction = new nsservicefunction();
      options option = new options();
      option.set_filter(filter);
      return (nsservicefunction[]) nsservicefunction.getfiltered(service, option);
    }

    public static uint count(nitro_service service)
    {
      nsservicefunction nsservicefunction = new nsservicefunction();
      options option = new options();
      option.set_count(true);
      nsservicefunction[] resources = (nsservicefunction[]) nsservicefunction.get_resources(service, option);
      return resources != null && resources.Length > 0 ? resources[0].__count.Value : 0U;
    }

    public static uint count_filtered(nitro_service service, string filter)
    {
      nsservicefunction nsservicefunction = new nsservicefunction();
      options option = new options();
      option.set_count(true);
      option.set_filter(filter);
      nsservicefunction[] nsservicefunctionArray = (nsservicefunction[]) nsservicefunction.getfiltered(service, option);
      return nsservicefunctionArray != null && nsservicefunctionArray.Length > 0 ? nsservicefunctionArray[0].__count.Value : 0U;
    }

    public static uint count_filtered(nitro_service service, filtervalue[] filter)
    {
      nsservicefunction nsservicefunction = new nsservicefunction();
      options option = new options();
      option.set_count(true);
      option.set_filter(filter);
      nsservicefunction[] nsservicefunctionArray = (nsservicefunction[]) nsservicefunction.getfiltered(service, option);
      return nsservicefunctionArray != null && nsservicefunctionArray.Length > 0 ? nsservicefunctionArray[0].__count.Value : 0U;
    }

    private class nsservicefunction_response : base_response
    {
      public nsservicefunction[] nsservicefunction = (nsservicefunction[]) null;
    }
  }
}
