// Decompiled with JetBrains decompiler
// Type: com.citrix.netscaler.nitro.resource.config.ns.nssimpleacl6
// Assembly: nitro, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 6CF5DDEF-E052-4F9D-953F-6644F8378A66


using com.citrix.netscaler.nitro.exception;
using com.citrix.netscaler.nitro.resource.Base;
using com.citrix.netscaler.nitro.service;
using com.citrix.netscaler.nitro.util;

namespace com.citrix.netscaler.nitro.resource.config.ns
{
  public class nssimpleacl6 : base_resource
  {
    private string aclnameField = (string) null;
    private uint? tdField = new uint?();
    private string aclactionField = (string) null;
    private string srcipv6Field = (string) null;
    private ushort? destportField = new ushort?();
    private string protocolField = (string) null;
    private uint? ttlField = new uint?();
    private bool? estsessionsField = new bool?();
    private long? hitsField = new long?();
    private uint? __countField = new uint?();

    public uint? __count
    {
      get => this.__countField;
      private set => this.__countField = value;
    }

    public string aclname
    {
      get => this.aclnameField;
      set => this.aclnameField = value;
    }

    public uint? td
    {
      get => this.tdField;
      set => this.tdField = value;
    }

    public string aclaction
    {
      get => this.aclactionField;
      set => this.aclactionField = value;
    }

    public string srcipv6
    {
      get => this.srcipv6Field;
      set => this.srcipv6Field = value;
    }

    public ushort? destport
    {
      get => this.destportField;
      set => this.destportField = value;
    }

    public string protocol
    {
      get => this.protocolField;
      set => this.protocolField = value;
    }

    public uint? ttl
    {
      get => this.ttlField;
      set => this.ttlField = value;
    }

    public bool? estsessions
    {
      get => this.estsessionsField;
      set => this.estsessionsField = value;
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
      nssimpleacl6.nssimpleacl6_response nssimpleacl6Response = new nssimpleacl6.nssimpleacl6_response();
      nssimpleacl6.nssimpleacl6_response resource = (nssimpleacl6.nssimpleacl6_response) service.get_payload_formatter().string_to_resource(nssimpleacl6Response.GetType(), response);
      if (resource.errorcode != 0)
      {
        if (resource.errorcode == 444)
          service.clear_session();
        if (resource.severity == null)
          throw new nitro_exception(resource.message, resource.errorcode);
        if (resource.severity.Equals("ERROR"))
          throw new nitro_exception(resource.message, resource.errorcode);
      }
      return (base_resource[]) resource.nssimpleacl6;
    }

    internal override string get_object_name() => this.aclname;

    public static base_response add(nitro_service client, nssimpleacl6 resource) => new nssimpleacl6()
    {
      aclname = resource.aclname,
      td = resource.td,
      aclaction = resource.aclaction,
      srcipv6 = resource.srcipv6,
      destport = resource.destport,
      protocol = resource.protocol,
      ttl = resource.ttl
    }.add_resource(client);

    public static base_responses add(nitro_service client, nssimpleacl6[] resources)
    {
      base_responses baseResponses = (base_responses) null;
      if (resources != null && resources.Length > 0)
      {
        nssimpleacl6[] nssimpleacl6Array = new nssimpleacl6[resources.Length];
        for (int index = 0; index < resources.Length; ++index)
        {
          nssimpleacl6Array[index] = new nssimpleacl6();
          nssimpleacl6Array[index].aclname = resources[index].aclname;
          nssimpleacl6Array[index].td = resources[index].td;
          nssimpleacl6Array[index].aclaction = resources[index].aclaction;
          nssimpleacl6Array[index].srcipv6 = resources[index].srcipv6;
          nssimpleacl6Array[index].destport = resources[index].destport;
          nssimpleacl6Array[index].protocol = resources[index].protocol;
          nssimpleacl6Array[index].ttl = resources[index].ttl;
        }
        baseResponses = base_resource.add_bulk_request(client, (base_resource[]) nssimpleacl6Array);
      }
      return baseResponses;
    }

    public static base_response clear(nitro_service client) => new nssimpleacl6().perform_operation_byaction(client, nameof (clear));

    public static base_responses clear(nitro_service client, nssimpleacl6[] resources)
    {
      base_responses baseResponses = (base_responses) null;
      if (resources != null && resources.Length > 0)
      {
        nssimpleacl6[] nssimpleacl6Array = new nssimpleacl6[resources.Length];
        for (int index = 0; index < resources.Length; ++index)
          nssimpleacl6Array[index] = new nssimpleacl6();
        baseResponses = base_resource.perform_operation_bulk_request(client, (base_resource[]) nssimpleacl6Array, nameof (clear));
      }
      return baseResponses;
    }

    public static base_response flush(nitro_service client, nssimpleacl6 resource) => new nssimpleacl6()
    {
      estsessions = resource.estsessions
    }.perform_operation_byaction(client, nameof (flush));

    public static base_responses flush(nitro_service client, nssimpleacl6[] resources)
    {
      base_responses baseResponses = (base_responses) null;
      if (resources != null && resources.Length > 0)
      {
        nssimpleacl6[] nssimpleacl6Array = new nssimpleacl6[resources.Length];
        for (int index = 0; index < resources.Length; ++index)
        {
          nssimpleacl6Array[index] = new nssimpleacl6();
          nssimpleacl6Array[index].estsessions = resources[index].estsessions;
        }
        baseResponses = base_resource.perform_operation_bulk_request(client, (base_resource[]) nssimpleacl6Array, nameof (flush));
      }
      return baseResponses;
    }

    public static base_response delete(nitro_service client, string aclname) => new nssimpleacl6()
    {
      aclname = aclname
    }.delete_resource(client);

    public static base_response delete(nitro_service client, nssimpleacl6 resource) => new nssimpleacl6()
    {
      aclname = resource.aclname
    }.delete_resource(client);

    public static base_responses delete(nitro_service client, string[] aclname)
    {
      base_responses baseResponses = (base_responses) null;
      if (aclname != null && aclname.Length > 0)
      {
        nssimpleacl6[] nssimpleacl6Array = new nssimpleacl6[aclname.Length];
        for (int index = 0; index < aclname.Length; ++index)
        {
          nssimpleacl6Array[index] = new nssimpleacl6();
          nssimpleacl6Array[index].aclname = aclname[index];
        }
        baseResponses = base_resource.delete_bulk_request(client, (base_resource[]) nssimpleacl6Array);
      }
      return baseResponses;
    }

    public static base_responses delete(
      nitro_service client,
      nssimpleacl6[] resources)
    {
      base_responses baseResponses = (base_responses) null;
      if (resources != null && resources.Length > 0)
      {
        nssimpleacl6[] nssimpleacl6Array = new nssimpleacl6[resources.Length];
        for (int index = 0; index < resources.Length; ++index)
        {
          nssimpleacl6Array[index] = new nssimpleacl6();
          nssimpleacl6Array[index].aclname = resources[index].aclname;
        }
        baseResponses = base_resource.delete_bulk_request(client, (base_resource[]) nssimpleacl6Array);
      }
      return baseResponses;
    }

    public static nssimpleacl6[] get(nitro_service service) => (nssimpleacl6[]) new nssimpleacl6().get_resources(service, (options) null);

    public static nssimpleacl6[] get(nitro_service service, options option) => (nssimpleacl6[]) new nssimpleacl6().get_resources(service, option);

    public static nssimpleacl6 get(nitro_service service, string aclname) => (nssimpleacl6) new nssimpleacl6()
    {
      aclname = aclname
    }.get_resource(service);

    public static nssimpleacl6[] get(nitro_service service, string[] aclname)
    {
      if (aclname == null || aclname.Length <= 0)
        return (nssimpleacl6[]) null;
      nssimpleacl6[] nssimpleacl6Array1 = new nssimpleacl6[aclname.Length];
      nssimpleacl6[] nssimpleacl6Array2 = new nssimpleacl6[aclname.Length];
      for (int index = 0; index < aclname.Length; ++index)
      {
        nssimpleacl6Array2[index] = new nssimpleacl6();
        nssimpleacl6Array2[index].aclname = aclname[index];
        nssimpleacl6Array1[index] = (nssimpleacl6) nssimpleacl6Array2[index].get_resource(service);
      }
      return nssimpleacl6Array1;
    }

    public static nssimpleacl6[] get_filtered(nitro_service service, string filter)
    {
      nssimpleacl6 nssimpleacl6 = new nssimpleacl6();
      options option = new options();
      option.set_filter(filter);
      return (nssimpleacl6[]) nssimpleacl6.getfiltered(service, option);
    }

    public static nssimpleacl6[] get_filtered(
      nitro_service service,
      filtervalue[] filter)
    {
      nssimpleacl6 nssimpleacl6 = new nssimpleacl6();
      options option = new options();
      option.set_filter(filter);
      return (nssimpleacl6[]) nssimpleacl6.getfiltered(service, option);
    }

    public static uint count(nitro_service service)
    {
      nssimpleacl6 nssimpleacl6 = new nssimpleacl6();
      options option = new options();
      option.set_count(true);
      nssimpleacl6[] resources = (nssimpleacl6[]) nssimpleacl6.get_resources(service, option);
      return resources != null && resources.Length > 0 ? resources[0].__count.Value : 0U;
    }

    public static uint count_filtered(nitro_service service, string filter)
    {
      nssimpleacl6 nssimpleacl6 = new nssimpleacl6();
      options option = new options();
      option.set_count(true);
      option.set_filter(filter);
      nssimpleacl6[] nssimpleacl6Array = (nssimpleacl6[]) nssimpleacl6.getfiltered(service, option);
      return nssimpleacl6Array != null && nssimpleacl6Array.Length > 0 ? nssimpleacl6Array[0].__count.Value : 0U;
    }

    public static uint count_filtered(nitro_service service, filtervalue[] filter)
    {
      nssimpleacl6 nssimpleacl6 = new nssimpleacl6();
      options option = new options();
      option.set_count(true);
      option.set_filter(filter);
      nssimpleacl6[] nssimpleacl6Array = (nssimpleacl6[]) nssimpleacl6.getfiltered(service, option);
      return nssimpleacl6Array != null && nssimpleacl6Array.Length > 0 ? nssimpleacl6Array[0].__count.Value : 0U;
    }

    private class nssimpleacl6_response : base_response
    {
      public nssimpleacl6[] nssimpleacl6 = (nssimpleacl6[]) null;
    }

    public static class protocolEnum
    {
      public const string TCP = "TCP";
      public const string UDP = "UDP";
    }

    public static class aclactionEnum
    {
      public const string DENY = "DENY";
    }
  }
}
