// Decompiled with JetBrains decompiler
// Type: com.citrix.netscaler.nitro.resource.config.dns.dnszone
// Assembly: nitro, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 6CF5DDEF-E052-4F9D-953F-6644F8378A66


using com.citrix.netscaler.nitro.exception;
using com.citrix.netscaler.nitro.resource.Base;
using com.citrix.netscaler.nitro.service;
using com.citrix.netscaler.nitro.util;

namespace com.citrix.netscaler.nitro.resource.config.dns
{
  public class dnszone : base_resource
  {
    private string zonenameField = (string) null;
    private string proxymodeField = (string) null;
    private string dnssecoffloadField = (string) null;
    private string nsecField = (string) null;
    private string[] keynameField = (string[]) null;
    private string typeField = (string) null;
    private uint? flagsField = new uint?();
    private uint? __countField = new uint?();

    public uint? __count
    {
      get => this.__countField;
      private set => this.__countField = value;
    }

    public string zonename
    {
      get => this.zonenameField;
      set => this.zonenameField = value;
    }

    public string proxymode
    {
      get => this.proxymodeField;
      set => this.proxymodeField = value;
    }

    public string dnssecoffload
    {
      get => this.dnssecoffloadField;
      set => this.dnssecoffloadField = value;
    }

    public string nsec
    {
      get => this.nsecField;
      set => this.nsecField = value;
    }

    public string[] keyname
    {
      get => this.keynameField;
      set => this.keynameField = value;
    }

    public string type
    {
      get => this.typeField;
      set => this.typeField = value;
    }

    public uint? flags
    {
      get => this.flagsField;
      private set => this.flagsField = value;
    }

    internal override base_resource[] get_nitro_response(
      nitro_service service,
      string response)
    {
      dnszone.dnszone_response dnszoneResponse = new dnszone.dnszone_response();
      dnszone.dnszone_response resource = (dnszone.dnszone_response) service.get_payload_formatter().string_to_resource(dnszoneResponse.GetType(), response);
      if (resource.errorcode != 0)
      {
        if (resource.errorcode == 444)
          service.clear_session();
        if (resource.severity == null)
          throw new nitro_exception(resource.message, resource.errorcode);
        if (resource.severity.Equals("ERROR"))
          throw new nitro_exception(resource.message, resource.errorcode);
      }
      return (base_resource[]) resource.dnszone;
    }

    internal override string get_object_name() => this.zonename;

    public static base_response add(nitro_service client, dnszone resource) => new dnszone()
    {
      zonename = resource.zonename,
      proxymode = resource.proxymode,
      dnssecoffload = resource.dnssecoffload,
      nsec = resource.nsec
    }.add_resource(client);

    public static base_responses add(nitro_service client, dnszone[] resources)
    {
      base_responses baseResponses = (base_responses) null;
      if (resources != null && resources.Length > 0)
      {
        dnszone[] dnszoneArray = new dnszone[resources.Length];
        for (int index = 0; index < resources.Length; ++index)
        {
          dnszoneArray[index] = new dnszone();
          dnszoneArray[index].zonename = resources[index].zonename;
          dnszoneArray[index].proxymode = resources[index].proxymode;
          dnszoneArray[index].dnssecoffload = resources[index].dnssecoffload;
          dnszoneArray[index].nsec = resources[index].nsec;
        }
        baseResponses = base_resource.add_bulk_request(client, (base_resource[]) dnszoneArray);
      }
      return baseResponses;
    }

    public static base_response update(nitro_service client, dnszone resource) => new dnszone()
    {
      zonename = resource.zonename,
      proxymode = resource.proxymode,
      dnssecoffload = resource.dnssecoffload,
      nsec = resource.nsec
    }.update_resource(client);

    public static base_responses update(nitro_service client, dnszone[] resources)
    {
      base_responses baseResponses = (base_responses) null;
      if (resources != null && resources.Length > 0)
      {
        dnszone[] dnszoneArray = new dnszone[resources.Length];
        for (int index = 0; index < resources.Length; ++index)
        {
          dnszoneArray[index] = new dnszone();
          dnszoneArray[index].zonename = resources[index].zonename;
          dnszoneArray[index].proxymode = resources[index].proxymode;
          dnszoneArray[index].dnssecoffload = resources[index].dnssecoffload;
          dnszoneArray[index].nsec = resources[index].nsec;
        }
        baseResponses = base_resource.update_bulk_request(client, (base_resource[]) dnszoneArray);
      }
      return baseResponses;
    }

    public static base_response unset(
      nitro_service client,
      string zonename,
      string[] args)
    {
      return new dnszone() { zonename = zonename }.unset_resource(client, args);
    }

    public static base_response unset(
      nitro_service client,
      dnszone resource,
      string[] args)
    {
      return new dnszone() { zonename = resource.zonename }.unset_resource(client, args);
    }

    public static base_responses unset(
      nitro_service client,
      string[] zonename,
      string[] args)
    {
      base_responses baseResponses = (base_responses) null;
      if (zonename != null && zonename.Length > 0)
      {
        dnszone[] dnszoneArray = new dnszone[zonename.Length];
        for (int index = 0; index < zonename.Length; ++index)
        {
          dnszoneArray[index] = new dnszone();
          dnszoneArray[index].zonename = zonename[index];
        }
        baseResponses = base_resource.unset_bulk_request(client, (base_resource[]) dnszoneArray, args);
      }
      return baseResponses;
    }

    public static base_responses unset(
      nitro_service client,
      dnszone[] resources,
      string[] args)
    {
      base_responses baseResponses = (base_responses) null;
      if (resources != null && resources.Length > 0)
      {
        dnszone[] dnszoneArray = new dnszone[resources.Length];
        for (int index = 0; index < resources.Length; ++index)
        {
          dnszoneArray[index] = new dnszone();
          dnszoneArray[index].zonename = resources[index].zonename;
        }
        baseResponses = base_resource.unset_bulk_request(client, (base_resource[]) dnszoneArray, args);
      }
      return baseResponses;
    }

    public static base_response delete(nitro_service client, string zonename) => new dnszone()
    {
      zonename = zonename
    }.delete_resource(client);

    public static base_response delete(nitro_service client, dnszone resource) => new dnszone()
    {
      zonename = resource.zonename
    }.delete_resource(client);

    public static base_responses delete(nitro_service client, string[] zonename)
    {
      base_responses baseResponses = (base_responses) null;
      if (zonename != null && zonename.Length > 0)
      {
        dnszone[] dnszoneArray = new dnszone[zonename.Length];
        for (int index = 0; index < zonename.Length; ++index)
        {
          dnszoneArray[index] = new dnszone();
          dnszoneArray[index].zonename = zonename[index];
        }
        baseResponses = base_resource.delete_bulk_request(client, (base_resource[]) dnszoneArray);
      }
      return baseResponses;
    }

    public static base_responses delete(nitro_service client, dnszone[] resources)
    {
      base_responses baseResponses = (base_responses) null;
      if (resources != null && resources.Length > 0)
      {
        dnszone[] dnszoneArray = new dnszone[resources.Length];
        for (int index = 0; index < resources.Length; ++index)
        {
          dnszoneArray[index] = new dnszone();
          dnszoneArray[index].zonename = resources[index].zonename;
        }
        baseResponses = base_resource.delete_bulk_request(client, (base_resource[]) dnszoneArray);
      }
      return baseResponses;
    }

    public static base_response sign(nitro_service client, dnszone resource) => new dnszone()
    {
      zonename = resource.zonename,
      keyname = resource.keyname
    }.perform_operation_byaction(client, nameof (sign));

    public static base_responses sign(nitro_service client, dnszone[] resources)
    {
      base_responses baseResponses = (base_responses) null;
      if (resources != null && resources.Length > 0)
      {
        dnszone[] dnszoneArray = new dnszone[resources.Length];
        for (int index = 0; index < resources.Length; ++index)
        {
          dnszoneArray[index] = new dnszone();
          dnszoneArray[index].zonename = resources[index].zonename;
          dnszoneArray[index].keyname = resources[index].keyname;
        }
        baseResponses = base_resource.perform_operation_bulk_request(client, (base_resource[]) dnszoneArray, nameof (sign));
      }
      return baseResponses;
    }

    public static base_response unsign(nitro_service client, dnszone resource) => new dnszone()
    {
      zonename = resource.zonename,
      keyname = resource.keyname
    }.perform_operation_byaction(client, nameof (unsign));

    public static base_responses unsign(nitro_service client, dnszone[] resources)
    {
      base_responses baseResponses = (base_responses) null;
      if (resources != null && resources.Length > 0)
      {
        dnszone[] dnszoneArray = new dnszone[resources.Length];
        for (int index = 0; index < resources.Length; ++index)
        {
          dnszoneArray[index] = new dnszone();
          dnszoneArray[index].zonename = resources[index].zonename;
          dnszoneArray[index].keyname = resources[index].keyname;
        }
        baseResponses = base_resource.perform_operation_bulk_request(client, (base_resource[]) dnszoneArray, nameof (unsign));
      }
      return baseResponses;
    }

    public static dnszone[] get(nitro_service service) => (dnszone[]) new dnszone().get_resources(service, (options) null);

    public static dnszone[] get(nitro_service service, options option) => (dnszone[]) new dnszone().get_resources(service, option);

    public static dnszone[] get(nitro_service service, dnszone_args args)
    {
      dnszone dnszone = new dnszone();
      options option = new options();
      option.set_args(nitro_util.object_to_string_withoutquotes((object) args));
      return (dnszone[]) dnszone.get_resources(service, option);
    }

    public static dnszone get(nitro_service service, string zonename) => (dnszone) new dnszone()
    {
      zonename = zonename
    }.get_resource(service);

    public static dnszone[] get(nitro_service service, string[] zonename)
    {
      if (zonename == null || zonename.Length <= 0)
        return (dnszone[]) null;
      dnszone[] dnszoneArray1 = new dnszone[zonename.Length];
      dnszone[] dnszoneArray2 = new dnszone[zonename.Length];
      for (int index = 0; index < zonename.Length; ++index)
      {
        dnszoneArray2[index] = new dnszone();
        dnszoneArray2[index].zonename = zonename[index];
        dnszoneArray1[index] = (dnszone) dnszoneArray2[index].get_resource(service);
      }
      return dnszoneArray1;
    }

    public static dnszone[] get_filtered(nitro_service service, string filter)
    {
      dnszone dnszone = new dnszone();
      options option = new options();
      option.set_filter(filter);
      return (dnszone[]) dnszone.getfiltered(service, option);
    }

    public static dnszone[] get_filtered(nitro_service service, filtervalue[] filter)
    {
      dnszone dnszone = new dnszone();
      options option = new options();
      option.set_filter(filter);
      return (dnszone[]) dnszone.getfiltered(service, option);
    }

    public static uint count(nitro_service service)
    {
      dnszone dnszone = new dnszone();
      options option = new options();
      option.set_count(true);
      dnszone[] resources = (dnszone[]) dnszone.get_resources(service, option);
      return resources != null && resources.Length > 0 ? resources[0].__count.Value : 0U;
    }

    public static uint count_filtered(nitro_service service, string filter)
    {
      dnszone dnszone = new dnszone();
      options option = new options();
      option.set_count(true);
      option.set_filter(filter);
      dnszone[] dnszoneArray = (dnszone[]) dnszone.getfiltered(service, option);
      return dnszoneArray != null && dnszoneArray.Length > 0 ? dnszoneArray[0].__count.Value : 0U;
    }

    public static uint count_filtered(nitro_service service, filtervalue[] filter)
    {
      dnszone dnszone = new dnszone();
      options option = new options();
      option.set_count(true);
      option.set_filter(filter);
      dnszone[] dnszoneArray = (dnszone[]) dnszone.getfiltered(service, option);
      return dnszoneArray != null && dnszoneArray.Length > 0 ? dnszoneArray[0].__count.Value : 0U;
    }

    private class dnszone_response : base_response
    {
      public dnszone[] dnszone = (dnszone[]) null;
    }

    public static class typeEnum
    {
      public const string ALL = "ALL";
      public const string ADNS = "ADNS";
      public const string PROXY = "PROXY";
    }

    public static class proxymodeEnum
    {
      public const string YES = "YES";
      public const string NO = "NO";
    }

    public static class nsecEnum
    {
      public const string ENABLED = "ENABLED";
      public const string DISABLED = "DISABLED";
    }

    public static class dnssecoffloadEnum
    {
      public const string ENABLED = "ENABLED";
      public const string DISABLED = "DISABLED";
    }
  }
}
