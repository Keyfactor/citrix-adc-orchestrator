// Decompiled with JetBrains decompiler
// Type: com.citrix.netscaler.nitro.resource.config.ns.nstrafficdomain
// Assembly: nitro, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 6CF5DDEF-E052-4F9D-953F-6644F8378A66


using com.citrix.netscaler.nitro.exception;
using com.citrix.netscaler.nitro.resource.Base;
using com.citrix.netscaler.nitro.service;
using com.citrix.netscaler.nitro.util;

namespace com.citrix.netscaler.nitro.resource.config.ns
{
  public class nstrafficdomain : base_resource
  {
    private uint? tdField = new uint?();
    private string aliasnameField = (string) null;
    private string vmacField = (string) null;
    private string stateField = (string) null;
    private uint? __countField = new uint?();

    public uint? __count
    {
      get => this.__countField;
      private set => this.__countField = value;
    }

    public uint? td
    {
      get => this.tdField;
      set => this.tdField = value;
    }

    public string aliasname
    {
      get => this.aliasnameField;
      set => this.aliasnameField = value;
    }

    public string vmac
    {
      get => this.vmacField;
      set => this.vmacField = value;
    }

    public string state
    {
      get => this.stateField;
      private set => this.stateField = value;
    }

    internal override base_resource[] get_nitro_response(
      nitro_service service,
      string response)
    {
      nstrafficdomain.nstrafficdomain_response nstrafficdomainResponse = new nstrafficdomain.nstrafficdomain_response();
      nstrafficdomain.nstrafficdomain_response resource = (nstrafficdomain.nstrafficdomain_response) service.get_payload_formatter().string_to_resource(nstrafficdomainResponse.GetType(), response);
      if (resource.errorcode != 0)
      {
        if (resource.errorcode == 444)
          service.clear_session();
        if (resource.severity == null)
          throw new nitro_exception(resource.message, resource.errorcode);
        if (resource.severity.Equals("ERROR"))
          throw new nitro_exception(resource.message, resource.errorcode);
      }
      return (base_resource[]) resource.nstrafficdomain;
    }

    internal override string get_object_name() => this.td.HasValue ? this.td.ToString() : (string) null;

    public static base_response add(nitro_service client, nstrafficdomain resource) => new nstrafficdomain()
    {
      td = resource.td,
      aliasname = resource.aliasname,
      vmac = resource.vmac
    }.add_resource(client);

    public static base_responses add(
      nitro_service client,
      nstrafficdomain[] resources)
    {
      base_responses baseResponses = (base_responses) null;
      if (resources != null && resources.Length > 0)
      {
        nstrafficdomain[] nstrafficdomainArray = new nstrafficdomain[resources.Length];
        for (int index = 0; index < resources.Length; ++index)
        {
          nstrafficdomainArray[index] = new nstrafficdomain();
          nstrafficdomainArray[index].td = resources[index].td;
          nstrafficdomainArray[index].aliasname = resources[index].aliasname;
          nstrafficdomainArray[index].vmac = resources[index].vmac;
        }
        baseResponses = base_resource.add_bulk_request(client, (base_resource[]) nstrafficdomainArray);
      }
      return baseResponses;
    }

    public static base_response delete(nitro_service client, uint? td) => new nstrafficdomain()
    {
      td = td
    }.delete_resource(client);

    public static base_response delete(nitro_service client, nstrafficdomain resource) => new nstrafficdomain()
    {
      td = resource.td
    }.delete_resource(client);

    public static base_responses delete(nitro_service client, uint?[] td)
    {
      base_responses baseResponses = (base_responses) null;
      if (td != null && td.Length > 0)
      {
        nstrafficdomain[] nstrafficdomainArray = new nstrafficdomain[td.Length];
        for (int index = 0; index < td.Length; ++index)
        {
          nstrafficdomainArray[index] = new nstrafficdomain();
          nstrafficdomainArray[index].td = td[index];
        }
        baseResponses = base_resource.delete_bulk_request(client, (base_resource[]) nstrafficdomainArray);
      }
      return baseResponses;
    }

    public static base_responses delete(
      nitro_service client,
      nstrafficdomain[] resources)
    {
      base_responses baseResponses = (base_responses) null;
      if (resources != null && resources.Length > 0)
      {
        nstrafficdomain[] nstrafficdomainArray = new nstrafficdomain[resources.Length];
        for (int index = 0; index < resources.Length; ++index)
        {
          nstrafficdomainArray[index] = new nstrafficdomain();
          nstrafficdomainArray[index].td = resources[index].td;
        }
        baseResponses = base_resource.delete_bulk_request(client, (base_resource[]) nstrafficdomainArray);
      }
      return baseResponses;
    }

    public static base_response clear(nitro_service client, nstrafficdomain resource) => new nstrafficdomain()
    {
      td = resource.td
    }.perform_operation_byaction(client, nameof (clear));

    public static base_responses clear(
      nitro_service client,
      nstrafficdomain[] resources)
    {
      base_responses baseResponses = (base_responses) null;
      if (resources != null && resources.Length > 0)
      {
        nstrafficdomain[] nstrafficdomainArray = new nstrafficdomain[resources.Length];
        for (int index = 0; index < resources.Length; ++index)
        {
          nstrafficdomainArray[index] = new nstrafficdomain();
          nstrafficdomainArray[index].td = resources[index].td;
        }
        baseResponses = base_resource.perform_operation_bulk_request(client, (base_resource[]) nstrafficdomainArray, nameof (clear));
      }
      return baseResponses;
    }

    public static base_response enable(nitro_service client, uint? td) => new nstrafficdomain()
    {
      td = td
    }.perform_operation_byaction(client, nameof (enable));

    public static base_response enable(nitro_service client, nstrafficdomain resource) => new nstrafficdomain()
    {
      td = resource.td
    }.perform_operation_byaction(client, nameof (enable));

    public static base_responses enable(nitro_service client, uint?[] td)
    {
      base_responses baseResponses = (base_responses) null;
      if (td != null && td.Length > 0)
      {
        nstrafficdomain[] nstrafficdomainArray = new nstrafficdomain[td.Length];
        for (int index = 0; index < td.Length; ++index)
        {
          nstrafficdomainArray[index] = new nstrafficdomain();
          nstrafficdomainArray[index].td = td[index];
        }
        baseResponses = base_resource.perform_operation_bulk_request(client, (base_resource[]) nstrafficdomainArray, nameof (enable));
      }
      return baseResponses;
    }

    public static base_responses enable(
      nitro_service client,
      nstrafficdomain[] resources)
    {
      base_responses baseResponses = (base_responses) null;
      if (resources != null && resources.Length > 0)
      {
        nstrafficdomain[] nstrafficdomainArray = new nstrafficdomain[resources.Length];
        for (int index = 0; index < resources.Length; ++index)
        {
          nstrafficdomainArray[index] = new nstrafficdomain();
          nstrafficdomainArray[index].td = resources[index].td;
        }
        baseResponses = base_resource.perform_operation_bulk_request(client, (base_resource[]) nstrafficdomainArray, nameof (enable));
      }
      return baseResponses;
    }

    public static base_response disable(nitro_service client, uint? td) => new nstrafficdomain()
    {
      td = td
    }.perform_operation_byaction(client, nameof (disable));

    public static base_response disable(nitro_service client, nstrafficdomain resource) => new nstrafficdomain()
    {
      td = resource.td
    }.perform_operation_byaction(client, nameof (disable));

    public static base_responses disable(nitro_service client, uint?[] td)
    {
      base_responses baseResponses = (base_responses) null;
      if (td != null && td.Length > 0)
      {
        nstrafficdomain[] nstrafficdomainArray = new nstrafficdomain[td.Length];
        for (int index = 0; index < td.Length; ++index)
        {
          nstrafficdomainArray[index] = new nstrafficdomain();
          nstrafficdomainArray[index].td = td[index];
        }
        baseResponses = base_resource.perform_operation_bulk_request(client, (base_resource[]) nstrafficdomainArray, nameof (disable));
      }
      return baseResponses;
    }

    public static base_responses disable(
      nitro_service client,
      nstrafficdomain[] resources)
    {
      base_responses baseResponses = (base_responses) null;
      if (resources != null && resources.Length > 0)
      {
        nstrafficdomain[] nstrafficdomainArray = new nstrafficdomain[resources.Length];
        for (int index = 0; index < resources.Length; ++index)
        {
          nstrafficdomainArray[index] = new nstrafficdomain();
          nstrafficdomainArray[index].td = resources[index].td;
        }
        baseResponses = base_resource.perform_operation_bulk_request(client, (base_resource[]) nstrafficdomainArray, nameof (disable));
      }
      return baseResponses;
    }

    public static nstrafficdomain[] get(nitro_service service) => (nstrafficdomain[]) new nstrafficdomain().get_resources(service, (options) null);

    public static nstrafficdomain[] get(nitro_service service, options option) => (nstrafficdomain[]) new nstrafficdomain().get_resources(service, option);

    public static nstrafficdomain get(nitro_service service, uint? td) => (nstrafficdomain) new nstrafficdomain()
    {
      td = td
    }.get_resource(service);

    public static nstrafficdomain[] get(nitro_service service, uint?[] td)
    {
      if (td == null || td.Length <= 0)
        return (nstrafficdomain[]) null;
      nstrafficdomain[] nstrafficdomainArray1 = new nstrafficdomain[td.Length];
      nstrafficdomain[] nstrafficdomainArray2 = new nstrafficdomain[td.Length];
      for (int index = 0; index < td.Length; ++index)
      {
        nstrafficdomainArray2[index] = new nstrafficdomain();
        nstrafficdomainArray2[index].td = td[index];
        nstrafficdomainArray1[index] = (nstrafficdomain) nstrafficdomainArray2[index].get_resource(service);
      }
      return nstrafficdomainArray1;
    }

    public static nstrafficdomain[] get_filtered(
      nitro_service service,
      string filter)
    {
      nstrafficdomain nstrafficdomain = new nstrafficdomain();
      options option = new options();
      option.set_filter(filter);
      return (nstrafficdomain[]) nstrafficdomain.getfiltered(service, option);
    }

    public static nstrafficdomain[] get_filtered(
      nitro_service service,
      filtervalue[] filter)
    {
      nstrafficdomain nstrafficdomain = new nstrafficdomain();
      options option = new options();
      option.set_filter(filter);
      return (nstrafficdomain[]) nstrafficdomain.getfiltered(service, option);
    }

    public static uint count(nitro_service service)
    {
      nstrafficdomain nstrafficdomain = new nstrafficdomain();
      options option = new options();
      option.set_count(true);
      nstrafficdomain[] resources = (nstrafficdomain[]) nstrafficdomain.get_resources(service, option);
      return resources != null && resources.Length > 0 ? resources[0].__count.Value : 0U;
    }

    public static uint count_filtered(nitro_service service, string filter)
    {
      nstrafficdomain nstrafficdomain = new nstrafficdomain();
      options option = new options();
      option.set_count(true);
      option.set_filter(filter);
      nstrafficdomain[] nstrafficdomainArray = (nstrafficdomain[]) nstrafficdomain.getfiltered(service, option);
      return nstrafficdomainArray != null && nstrafficdomainArray.Length > 0 ? nstrafficdomainArray[0].__count.Value : 0U;
    }

    public static uint count_filtered(nitro_service service, filtervalue[] filter)
    {
      nstrafficdomain nstrafficdomain = new nstrafficdomain();
      options option = new options();
      option.set_count(true);
      option.set_filter(filter);
      nstrafficdomain[] nstrafficdomainArray = (nstrafficdomain[]) nstrafficdomain.getfiltered(service, option);
      return nstrafficdomainArray != null && nstrafficdomainArray.Length > 0 ? nstrafficdomainArray[0].__count.Value : 0U;
    }

    private class nstrafficdomain_response : base_response
    {
      public nstrafficdomain[] nstrafficdomain = (nstrafficdomain[]) null;
    }

    public static class stateEnum
    {
      public const string ENABLED = "ENABLED";
      public const string DISABLED = "DISABLED";
    }

    public static class vmacEnum
    {
      public const string ENABLED = "ENABLED";
      public const string DISABLED = "DISABLED";
    }
  }
}
