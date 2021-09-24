// Decompiled with JetBrains decompiler
// Type: com.citrix.netscaler.nitro.resource.config.ns.nssimpleacl
// Assembly: nitro, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 6CF5DDEF-E052-4F9D-953F-6644F8378A66


using com.citrix.netscaler.nitro.exception;
using com.citrix.netscaler.nitro.resource.Base;
using com.citrix.netscaler.nitro.service;
using com.citrix.netscaler.nitro.util;

namespace com.citrix.netscaler.nitro.resource.config.ns
{
  public class nssimpleacl : base_resource
  {
    private string aclnameField = (string) null;
    private string aclactionField = (string) null;
    private uint? tdField = new uint?();
    private string srcipField = (string) null;
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

    public string aclaction
    {
      get => this.aclactionField;
      set => this.aclactionField = value;
    }

    public uint? td
    {
      get => this.tdField;
      set => this.tdField = value;
    }

    public string srcip
    {
      get => this.srcipField;
      set => this.srcipField = value;
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
      nssimpleacl.nssimpleacl_response nssimpleaclResponse = new nssimpleacl.nssimpleacl_response();
      nssimpleacl.nssimpleacl_response resource = (nssimpleacl.nssimpleacl_response) service.get_payload_formatter().string_to_resource(nssimpleaclResponse.GetType(), response);
      if (resource.errorcode != 0)
      {
        if (resource.errorcode == 444)
          service.clear_session();
        if (resource.severity == null)
          throw new nitro_exception(resource.message, resource.errorcode);
        if (resource.severity.Equals("ERROR"))
          throw new nitro_exception(resource.message, resource.errorcode);
      }
      return (base_resource[]) resource.nssimpleacl;
    }

    internal override string get_object_name() => this.aclname;

    public static base_response add(nitro_service client, nssimpleacl resource) => new nssimpleacl()
    {
      aclname = resource.aclname,
      aclaction = resource.aclaction,
      td = resource.td,
      srcip = resource.srcip,
      destport = resource.destport,
      protocol = resource.protocol,
      ttl = resource.ttl
    }.add_resource(client);

    public static base_responses add(nitro_service client, nssimpleacl[] resources)
    {
      base_responses baseResponses = (base_responses) null;
      if (resources != null && resources.Length > 0)
      {
        nssimpleacl[] nssimpleaclArray = new nssimpleacl[resources.Length];
        for (int index = 0; index < resources.Length; ++index)
        {
          nssimpleaclArray[index] = new nssimpleacl();
          nssimpleaclArray[index].aclname = resources[index].aclname;
          nssimpleaclArray[index].aclaction = resources[index].aclaction;
          nssimpleaclArray[index].td = resources[index].td;
          nssimpleaclArray[index].srcip = resources[index].srcip;
          nssimpleaclArray[index].destport = resources[index].destport;
          nssimpleaclArray[index].protocol = resources[index].protocol;
          nssimpleaclArray[index].ttl = resources[index].ttl;
        }
        baseResponses = base_resource.add_bulk_request(client, (base_resource[]) nssimpleaclArray);
      }
      return baseResponses;
    }

    public static base_response clear(nitro_service client) => new nssimpleacl().perform_operation_byaction(client, nameof (clear));

    public static base_responses clear(nitro_service client, nssimpleacl[] resources)
    {
      base_responses baseResponses = (base_responses) null;
      if (resources != null && resources.Length > 0)
      {
        nssimpleacl[] nssimpleaclArray = new nssimpleacl[resources.Length];
        for (int index = 0; index < resources.Length; ++index)
          nssimpleaclArray[index] = new nssimpleacl();
        baseResponses = base_resource.perform_operation_bulk_request(client, (base_resource[]) nssimpleaclArray, nameof (clear));
      }
      return baseResponses;
    }

    public static base_response delete(nitro_service client, string aclname) => new nssimpleacl()
    {
      aclname = aclname
    }.delete_resource(client);

    public static base_response delete(nitro_service client, nssimpleacl resource) => new nssimpleacl()
    {
      aclname = resource.aclname
    }.delete_resource(client);

    public static base_responses delete(nitro_service client, string[] aclname)
    {
      base_responses baseResponses = (base_responses) null;
      if (aclname != null && aclname.Length > 0)
      {
        nssimpleacl[] nssimpleaclArray = new nssimpleacl[aclname.Length];
        for (int index = 0; index < aclname.Length; ++index)
        {
          nssimpleaclArray[index] = new nssimpleacl();
          nssimpleaclArray[index].aclname = aclname[index];
        }
        baseResponses = base_resource.delete_bulk_request(client, (base_resource[]) nssimpleaclArray);
      }
      return baseResponses;
    }

    public static base_responses delete(nitro_service client, nssimpleacl[] resources)
    {
      base_responses baseResponses = (base_responses) null;
      if (resources != null && resources.Length > 0)
      {
        nssimpleacl[] nssimpleaclArray = new nssimpleacl[resources.Length];
        for (int index = 0; index < resources.Length; ++index)
        {
          nssimpleaclArray[index] = new nssimpleacl();
          nssimpleaclArray[index].aclname = resources[index].aclname;
        }
        baseResponses = base_resource.delete_bulk_request(client, (base_resource[]) nssimpleaclArray);
      }
      return baseResponses;
    }

    public static base_response flush(nitro_service client, nssimpleacl resource) => new nssimpleacl()
    {
      estsessions = resource.estsessions
    }.perform_operation_byaction(client, nameof (flush));

    public static base_responses flush(nitro_service client, nssimpleacl[] resources)
    {
      base_responses baseResponses = (base_responses) null;
      if (resources != null && resources.Length > 0)
      {
        nssimpleacl[] nssimpleaclArray = new nssimpleacl[resources.Length];
        for (int index = 0; index < resources.Length; ++index)
        {
          nssimpleaclArray[index] = new nssimpleacl();
          nssimpleaclArray[index].estsessions = resources[index].estsessions;
        }
        baseResponses = base_resource.perform_operation_bulk_request(client, (base_resource[]) nssimpleaclArray, nameof (flush));
      }
      return baseResponses;
    }

    public static nssimpleacl[] get(nitro_service service) => (nssimpleacl[]) new nssimpleacl().get_resources(service, (options) null);

    public static nssimpleacl[] get(nitro_service service, options option) => (nssimpleacl[]) new nssimpleacl().get_resources(service, option);

    public static nssimpleacl get(nitro_service service, string aclname) => (nssimpleacl) new nssimpleacl()
    {
      aclname = aclname
    }.get_resource(service);

    public static nssimpleacl[] get(nitro_service service, string[] aclname)
    {
      if (aclname == null || aclname.Length <= 0)
        return (nssimpleacl[]) null;
      nssimpleacl[] nssimpleaclArray1 = new nssimpleacl[aclname.Length];
      nssimpleacl[] nssimpleaclArray2 = new nssimpleacl[aclname.Length];
      for (int index = 0; index < aclname.Length; ++index)
      {
        nssimpleaclArray2[index] = new nssimpleacl();
        nssimpleaclArray2[index].aclname = aclname[index];
        nssimpleaclArray1[index] = (nssimpleacl) nssimpleaclArray2[index].get_resource(service);
      }
      return nssimpleaclArray1;
    }

    public static nssimpleacl[] get_filtered(nitro_service service, string filter)
    {
      nssimpleacl nssimpleacl = new nssimpleacl();
      options option = new options();
      option.set_filter(filter);
      return (nssimpleacl[]) nssimpleacl.getfiltered(service, option);
    }

    public static nssimpleacl[] get_filtered(nitro_service service, filtervalue[] filter)
    {
      nssimpleacl nssimpleacl = new nssimpleacl();
      options option = new options();
      option.set_filter(filter);
      return (nssimpleacl[]) nssimpleacl.getfiltered(service, option);
    }

    public static uint count(nitro_service service)
    {
      nssimpleacl nssimpleacl = new nssimpleacl();
      options option = new options();
      option.set_count(true);
      nssimpleacl[] resources = (nssimpleacl[]) nssimpleacl.get_resources(service, option);
      return resources != null && resources.Length > 0 ? resources[0].__count.Value : 0U;
    }

    public static uint count_filtered(nitro_service service, string filter)
    {
      nssimpleacl nssimpleacl = new nssimpleacl();
      options option = new options();
      option.set_count(true);
      option.set_filter(filter);
      nssimpleacl[] nssimpleaclArray = (nssimpleacl[]) nssimpleacl.getfiltered(service, option);
      return nssimpleaclArray != null && nssimpleaclArray.Length > 0 ? nssimpleaclArray[0].__count.Value : 0U;
    }

    public static uint count_filtered(nitro_service service, filtervalue[] filter)
    {
      nssimpleacl nssimpleacl = new nssimpleacl();
      options option = new options();
      option.set_count(true);
      option.set_filter(filter);
      nssimpleacl[] nssimpleaclArray = (nssimpleacl[]) nssimpleacl.getfiltered(service, option);
      return nssimpleaclArray != null && nssimpleaclArray.Length > 0 ? nssimpleaclArray[0].__count.Value : 0U;
    }

    private class nssimpleacl_response : base_response
    {
      public nssimpleacl[] nssimpleacl = (nssimpleacl[]) null;
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
