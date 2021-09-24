// Decompiled with JetBrains decompiler
// Type: com.citrix.netscaler.nitro.resource.config.dns.dnssuffix
// Assembly: nitro, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 6CF5DDEF-E052-4F9D-953F-6644F8378A66


using com.citrix.netscaler.nitro.exception;
using com.citrix.netscaler.nitro.resource.Base;
using com.citrix.netscaler.nitro.service;
using com.citrix.netscaler.nitro.util;

namespace com.citrix.netscaler.nitro.resource.config.dns
{
  public class dnssuffix : base_resource
  {
    private string DnssuffixField = (string) null;
    private uint? __countField = new uint?();

    public uint? __count
    {
      get => this.__countField;
      private set => this.__countField = value;
    }

    public string Dnssuffix
    {
      get => this.DnssuffixField;
      set => this.DnssuffixField = value;
    }

    internal override base_resource[] get_nitro_response(
      nitro_service service,
      string response)
    {
      dnssuffix.dnssuffix_response dnssuffixResponse = new dnssuffix.dnssuffix_response();
      dnssuffix.dnssuffix_response resource = (dnssuffix.dnssuffix_response) service.get_payload_formatter().string_to_resource(dnssuffixResponse.GetType(), response);
      if (resource.errorcode != 0)
      {
        if (resource.errorcode == 444)
          service.clear_session();
        if (resource.severity == null)
          throw new nitro_exception(resource.message, resource.errorcode);
        if (resource.severity.Equals("ERROR"))
          throw new nitro_exception(resource.message, resource.errorcode);
      }
      return (base_resource[]) resource.dnssuffix;
    }

    internal override string get_object_name() => this.Dnssuffix;

    public static base_response add(nitro_service client, dnssuffix resource) => new dnssuffix()
    {
      Dnssuffix = resource.Dnssuffix
    }.add_resource(client);

    public static base_responses add(nitro_service client, dnssuffix[] resources)
    {
      base_responses baseResponses = (base_responses) null;
      if (resources != null && resources.Length > 0)
      {
        dnssuffix[] dnssuffixArray = new dnssuffix[resources.Length];
        for (int index = 0; index < resources.Length; ++index)
        {
          dnssuffixArray[index] = new dnssuffix();
          dnssuffixArray[index].Dnssuffix = resources[index].Dnssuffix;
        }
        baseResponses = base_resource.add_bulk_request(client, (base_resource[]) dnssuffixArray);
      }
      return baseResponses;
    }

    public static base_response delete(nitro_service client, string Dnssuffix) => new dnssuffix()
    {
      Dnssuffix = Dnssuffix
    }.delete_resource(client);

    public static base_response delete(nitro_service client, dnssuffix resource) => new dnssuffix()
    {
      Dnssuffix = resource.Dnssuffix
    }.delete_resource(client);

    public static base_responses delete(nitro_service client, string[] Dnssuffix)
    {
      base_responses baseResponses = (base_responses) null;
      if (Dnssuffix != null && Dnssuffix.Length > 0)
      {
        dnssuffix[] dnssuffixArray = new dnssuffix[Dnssuffix.Length];
        for (int index = 0; index < Dnssuffix.Length; ++index)
        {
          dnssuffixArray[index] = new dnssuffix();
          dnssuffixArray[index].Dnssuffix = Dnssuffix[index];
        }
        baseResponses = base_resource.delete_bulk_request(client, (base_resource[]) dnssuffixArray);
      }
      return baseResponses;
    }

    public static base_responses delete(nitro_service client, dnssuffix[] resources)
    {
      base_responses baseResponses = (base_responses) null;
      if (resources != null && resources.Length > 0)
      {
        dnssuffix[] dnssuffixArray = new dnssuffix[resources.Length];
        for (int index = 0; index < resources.Length; ++index)
        {
          dnssuffixArray[index] = new dnssuffix();
          dnssuffixArray[index].Dnssuffix = resources[index].Dnssuffix;
        }
        baseResponses = base_resource.delete_bulk_request(client, (base_resource[]) dnssuffixArray);
      }
      return baseResponses;
    }

    public static dnssuffix[] get(nitro_service service) => (dnssuffix[]) new dnssuffix().get_resources(service, (options) null);

    public static dnssuffix[] get(nitro_service service, options option) => (dnssuffix[]) new dnssuffix().get_resources(service, option);

    public static dnssuffix get(nitro_service service, string Dnssuffix) => (dnssuffix) new dnssuffix()
    {
      Dnssuffix = Dnssuffix
    }.get_resource(service);

    public static dnssuffix[] get(nitro_service service, string[] Dnssuffix)
    {
      if (Dnssuffix == null || Dnssuffix.Length <= 0)
        return (dnssuffix[]) null;
      dnssuffix[] dnssuffixArray1 = new dnssuffix[Dnssuffix.Length];
      dnssuffix[] dnssuffixArray2 = new dnssuffix[Dnssuffix.Length];
      for (int index = 0; index < Dnssuffix.Length; ++index)
      {
        dnssuffixArray2[index] = new dnssuffix();
        dnssuffixArray2[index].Dnssuffix = Dnssuffix[index];
        dnssuffixArray1[index] = (dnssuffix) dnssuffixArray2[index].get_resource(service);
      }
      return dnssuffixArray1;
    }

    public static dnssuffix[] get_filtered(nitro_service service, string filter)
    {
      dnssuffix dnssuffix = new dnssuffix();
      options option = new options();
      option.set_filter(filter);
      return (dnssuffix[]) dnssuffix.getfiltered(service, option);
    }

    public static dnssuffix[] get_filtered(nitro_service service, filtervalue[] filter)
    {
      dnssuffix dnssuffix = new dnssuffix();
      options option = new options();
      option.set_filter(filter);
      return (dnssuffix[]) dnssuffix.getfiltered(service, option);
    }

    public static uint count(nitro_service service)
    {
      dnssuffix dnssuffix = new dnssuffix();
      options option = new options();
      option.set_count(true);
      dnssuffix[] resources = (dnssuffix[]) dnssuffix.get_resources(service, option);
      return resources != null && resources.Length > 0 ? resources[0].__count.Value : 0U;
    }

    public static uint count_filtered(nitro_service service, string filter)
    {
      dnssuffix dnssuffix = new dnssuffix();
      options option = new options();
      option.set_count(true);
      option.set_filter(filter);
      dnssuffix[] dnssuffixArray = (dnssuffix[]) dnssuffix.getfiltered(service, option);
      return dnssuffixArray != null && dnssuffixArray.Length > 0 ? dnssuffixArray[0].__count.Value : 0U;
    }

    public static uint count_filtered(nitro_service service, filtervalue[] filter)
    {
      dnssuffix dnssuffix = new dnssuffix();
      options option = new options();
      option.set_count(true);
      option.set_filter(filter);
      dnssuffix[] dnssuffixArray = (dnssuffix[]) dnssuffix.getfiltered(service, option);
      return dnssuffixArray != null && dnssuffixArray.Length > 0 ? dnssuffixArray[0].__count.Value : 0U;
    }

    private class dnssuffix_response : base_response
    {
      public dnssuffix[] dnssuffix = (dnssuffix[]) null;
    }
  }
}
