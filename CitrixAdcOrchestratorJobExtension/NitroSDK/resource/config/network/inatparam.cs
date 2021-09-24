// Decompiled with JetBrains decompiler
// Type: com.citrix.netscaler.nitro.resource.config.network.inatparam
// Assembly: nitro, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 6CF5DDEF-E052-4F9D-953F-6644F8378A66


using com.citrix.netscaler.nitro.exception;
using com.citrix.netscaler.nitro.resource.Base;
using com.citrix.netscaler.nitro.service;
using com.citrix.netscaler.nitro.util;

namespace com.citrix.netscaler.nitro.resource.config.network
{
  public class inatparam : base_resource
  {
    private string nat46v6prefixField = (string) null;
    private uint? tdField = new uint?();
    private string nat46ignoretosField = (string) null;
    private string nat46zerochecksumField = (string) null;
    private uint? nat46v6mtuField = new uint?();
    private string nat46fragheaderField = (string) null;
    private uint? __countField = new uint?();

    public uint? __count
    {
      get => this.__countField;
      private set => this.__countField = value;
    }

    public string nat46v6prefix
    {
      get => this.nat46v6prefixField;
      set => this.nat46v6prefixField = value;
    }

    public uint? td
    {
      get => this.tdField;
      set => this.tdField = value;
    }

    public string nat46ignoretos
    {
      get => this.nat46ignoretosField;
      set => this.nat46ignoretosField = value;
    }

    public string nat46zerochecksum
    {
      get => this.nat46zerochecksumField;
      set => this.nat46zerochecksumField = value;
    }

    public uint? nat46v6mtu
    {
      get => this.nat46v6mtuField;
      set => this.nat46v6mtuField = value;
    }

    public string nat46fragheader
    {
      get => this.nat46fragheaderField;
      set => this.nat46fragheaderField = value;
    }

    internal override base_resource[] get_nitro_response(
      nitro_service service,
      string response)
    {
      inatparam.inatparam_response inatparamResponse = new inatparam.inatparam_response();
      inatparam.inatparam_response resource = (inatparam.inatparam_response) service.get_payload_formatter().string_to_resource(inatparamResponse.GetType(), response);
      if (resource.errorcode != 0)
      {
        if (resource.errorcode == 444)
          service.clear_session();
        if (resource.severity == null)
          throw new nitro_exception(resource.message, resource.errorcode);
        if (resource.severity.Equals("ERROR"))
          throw new nitro_exception(resource.message, resource.errorcode);
      }
      return (base_resource[]) resource.inatparam;
    }

    internal override string get_object_name() => this.td.HasValue ? this.td.ToString() : (string) null;

    public static base_response update(nitro_service client, inatparam resource) => new inatparam()
    {
      nat46v6prefix = resource.nat46v6prefix,
      td = resource.td,
      nat46ignoretos = resource.nat46ignoretos,
      nat46zerochecksum = resource.nat46zerochecksum,
      nat46v6mtu = resource.nat46v6mtu,
      nat46fragheader = resource.nat46fragheader
    }.update_resource(client);

    public static base_responses update(nitro_service client, inatparam[] resources)
    {
      base_responses baseResponses = (base_responses) null;
      if (resources != null && resources.Length > 0)
      {
        inatparam[] inatparamArray = new inatparam[resources.Length];
        for (int index = 0; index < resources.Length; ++index)
        {
          inatparamArray[index] = new inatparam();
          inatparamArray[index].nat46v6prefix = resources[index].nat46v6prefix;
          inatparamArray[index].td = resources[index].td;
          inatparamArray[index].nat46ignoretos = resources[index].nat46ignoretos;
          inatparamArray[index].nat46zerochecksum = resources[index].nat46zerochecksum;
          inatparamArray[index].nat46v6mtu = resources[index].nat46v6mtu;
          inatparamArray[index].nat46fragheader = resources[index].nat46fragheader;
        }
        baseResponses = base_resource.update_bulk_request(client, (base_resource[]) inatparamArray);
      }
      return baseResponses;
    }

    public static base_response unset(nitro_service client, uint? td, string[] args) => new inatparam()
    {
      td = td
    }.unset_resource(client, args);

    public static base_response unset(
      nitro_service client,
      inatparam resource,
      string[] args)
    {
      return new inatparam().unset_resource(client, args);
    }

    public static base_responses unset(
      nitro_service client,
      uint?[] td,
      string[] args)
    {
      base_responses baseResponses = (base_responses) null;
      if (td != null && td.Length > 0)
      {
        inatparam[] inatparamArray = new inatparam[td.Length];
        for (int index = 0; index < td.Length; ++index)
        {
          inatparamArray[index] = new inatparam();
          inatparamArray[index].td = td[index];
        }
        baseResponses = base_resource.unset_bulk_request(client, (base_resource[]) inatparamArray, args);
      }
      return baseResponses;
    }

    public static base_responses unset(
      nitro_service client,
      inatparam[] resources,
      string[] args)
    {
      base_responses baseResponses = (base_responses) null;
      if (resources != null && resources.Length > 0)
      {
        inatparam[] inatparamArray = new inatparam[resources.Length];
        for (int index = 0; index < resources.Length; ++index)
        {
          inatparamArray[index] = new inatparam();
          inatparamArray[index].td = resources[index].td;
        }
        baseResponses = base_resource.unset_bulk_request(client, (base_resource[]) inatparamArray, args);
      }
      return baseResponses;
    }

    public static inatparam[] get(nitro_service service) => (inatparam[]) new inatparam().get_resources(service, (options) null);

    public static inatparam[] get(nitro_service service, options option) => (inatparam[]) new inatparam().get_resources(service, option);

    public static inatparam get(nitro_service service, uint? td) => (inatparam) new inatparam()
    {
      td = td
    }.get_resource(service);

    public static inatparam[] get(nitro_service service, uint?[] td)
    {
      if (td == null || td.Length <= 0)
        return (inatparam[]) null;
      inatparam[] inatparamArray1 = new inatparam[td.Length];
      inatparam[] inatparamArray2 = new inatparam[td.Length];
      for (int index = 0; index < td.Length; ++index)
      {
        inatparamArray2[index] = new inatparam();
        inatparamArray2[index].td = td[index];
        inatparamArray1[index] = (inatparam) inatparamArray2[index].get_resource(service);
      }
      return inatparamArray1;
    }

    public static inatparam[] get_filtered(nitro_service service, string filter)
    {
      inatparam inatparam = new inatparam();
      options option = new options();
      option.set_filter(filter);
      return (inatparam[]) inatparam.getfiltered(service, option);
    }

    public static inatparam[] get_filtered(nitro_service service, filtervalue[] filter)
    {
      inatparam inatparam = new inatparam();
      options option = new options();
      option.set_filter(filter);
      return (inatparam[]) inatparam.getfiltered(service, option);
    }

    public static uint count(nitro_service service)
    {
      inatparam inatparam = new inatparam();
      options option = new options();
      option.set_count(true);
      inatparam[] resources = (inatparam[]) inatparam.get_resources(service, option);
      return resources != null && resources.Length > 0 ? resources[0].__count.Value : 0U;
    }

    public static uint count_filtered(nitro_service service, string filter)
    {
      inatparam inatparam = new inatparam();
      options option = new options();
      option.set_count(true);
      option.set_filter(filter);
      inatparam[] inatparamArray = (inatparam[]) inatparam.getfiltered(service, option);
      return inatparamArray != null && inatparamArray.Length > 0 ? inatparamArray[0].__count.Value : 0U;
    }

    public static uint count_filtered(nitro_service service, filtervalue[] filter)
    {
      inatparam inatparam = new inatparam();
      options option = new options();
      option.set_count(true);
      option.set_filter(filter);
      inatparam[] inatparamArray = (inatparam[]) inatparam.getfiltered(service, option);
      return inatparamArray != null && inatparamArray.Length > 0 ? inatparamArray[0].__count.Value : 0U;
    }

    private class inatparam_response : base_response
    {
      public inatparam[] inatparam = (inatparam[]) null;
    }

    public static class nat46zerochecksumEnum
    {
      public const string ENABLED = "ENABLED";
      public const string DISABLED = "DISABLED";
    }

    public static class nat46ignoretosEnum
    {
      public const string YES = "YES";
      public const string NO = "NO";
    }

    public static class nat46fragheaderEnum
    {
      public const string ENABLED = "ENABLED";
      public const string DISABLED = "DISABLED";
    }
  }
}
