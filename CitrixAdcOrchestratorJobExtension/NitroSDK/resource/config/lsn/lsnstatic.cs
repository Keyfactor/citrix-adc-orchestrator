// Decompiled with JetBrains decompiler
// Type: com.citrix.netscaler.nitro.resource.config.lsn.lsnstatic
// Assembly: nitro, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 6CF5DDEF-E052-4F9D-953F-6644F8378A66


using com.citrix.netscaler.nitro.exception;
using com.citrix.netscaler.nitro.resource.Base;
using com.citrix.netscaler.nitro.service;
using com.citrix.netscaler.nitro.util;

namespace com.citrix.netscaler.nitro.resource.config.lsn
{
  public class lsnstatic : base_resource
  {
    private string nameField = (string) null;
    private string transportprotocolField = (string) null;
    private string subscripField = (string) null;
    private ushort? subscrportField = new ushort?();
    private string network6Field = (string) null;
    private uint? tdField = new uint?();
    private string natipField = (string) null;
    private ushort? natportField = new ushort?();
    private string destipField = (string) null;
    private uint? dsttdField = new uint?();
    private string nattypeField = (string) null;
    private string statusField = (string) null;
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

    public string transportprotocol
    {
      get => this.transportprotocolField;
      set => this.transportprotocolField = value;
    }

    public string subscrip
    {
      get => this.subscripField;
      set => this.subscripField = value;
    }

    public ushort? subscrport
    {
      get => this.subscrportField;
      set => this.subscrportField = value;
    }

    public string network6
    {
      get => this.network6Field;
      set => this.network6Field = value;
    }

    public uint? td
    {
      get => this.tdField;
      set => this.tdField = value;
    }

    public string natip
    {
      get => this.natipField;
      set => this.natipField = value;
    }

    public ushort? natport
    {
      get => this.natportField;
      set => this.natportField = value;
    }

    public string destip
    {
      get => this.destipField;
      set => this.destipField = value;
    }

    public uint? dsttd
    {
      get => this.dsttdField;
      set => this.dsttdField = value;
    }

    public string nattype
    {
      get => this.nattypeField;
      set => this.nattypeField = value;
    }

    public string status
    {
      get => this.statusField;
      private set => this.statusField = value;
    }

    internal override base_resource[] get_nitro_response(
      nitro_service service,
      string response)
    {
      lsnstatic.lsnstatic_response lsnstaticResponse = new lsnstatic.lsnstatic_response();
      lsnstatic.lsnstatic_response resource = (lsnstatic.lsnstatic_response) service.get_payload_formatter().string_to_resource(lsnstaticResponse.GetType(), response);
      if (resource.errorcode != 0)
      {
        if (resource.errorcode == 444)
          service.clear_session();
        if (resource.severity == null)
          throw new nitro_exception(resource.message, resource.errorcode);
        if (resource.severity.Equals("ERROR"))
          throw new nitro_exception(resource.message, resource.errorcode);
      }
      return (base_resource[]) resource.lsnstatic;
    }

    internal override string get_object_name() => this.name;

    public static base_response add(nitro_service client, lsnstatic resource) => new lsnstatic()
    {
      name = resource.name,
      transportprotocol = resource.transportprotocol,
      subscrip = resource.subscrip,
      subscrport = resource.subscrport,
      network6 = resource.network6,
      td = resource.td,
      natip = resource.natip,
      natport = resource.natport,
      destip = resource.destip,
      dsttd = resource.dsttd
    }.add_resource(client);

    public static base_responses add(nitro_service client, lsnstatic[] resources)
    {
      base_responses baseResponses = (base_responses) null;
      if (resources != null && resources.Length > 0)
      {
        lsnstatic[] lsnstaticArray = new lsnstatic[resources.Length];
        for (int index = 0; index < resources.Length; ++index)
        {
          lsnstaticArray[index] = new lsnstatic();
          lsnstaticArray[index].name = resources[index].name;
          lsnstaticArray[index].transportprotocol = resources[index].transportprotocol;
          lsnstaticArray[index].subscrip = resources[index].subscrip;
          lsnstaticArray[index].subscrport = resources[index].subscrport;
          lsnstaticArray[index].network6 = resources[index].network6;
          lsnstaticArray[index].td = resources[index].td;
          lsnstaticArray[index].natip = resources[index].natip;
          lsnstaticArray[index].natport = resources[index].natport;
          lsnstaticArray[index].destip = resources[index].destip;
          lsnstaticArray[index].dsttd = resources[index].dsttd;
        }
        baseResponses = base_resource.add_bulk_request(client, (base_resource[]) lsnstaticArray);
      }
      return baseResponses;
    }

    public static base_response delete(nitro_service client, string name) => new lsnstatic()
    {
      name = name
    }.delete_resource(client);

    public static base_response delete(nitro_service client, lsnstatic resource) => new lsnstatic()
    {
      name = resource.name
    }.delete_resource(client);

    public static base_responses delete(nitro_service client, string[] name)
    {
      base_responses baseResponses = (base_responses) null;
      if (name != null && name.Length > 0)
      {
        lsnstatic[] lsnstaticArray = new lsnstatic[name.Length];
        for (int index = 0; index < name.Length; ++index)
        {
          lsnstaticArray[index] = new lsnstatic();
          lsnstaticArray[index].name = name[index];
        }
        baseResponses = base_resource.delete_bulk_request(client, (base_resource[]) lsnstaticArray);
      }
      return baseResponses;
    }

    public static base_responses delete(nitro_service client, lsnstatic[] resources)
    {
      base_responses baseResponses = (base_responses) null;
      if (resources != null && resources.Length > 0)
      {
        lsnstatic[] lsnstaticArray = new lsnstatic[resources.Length];
        for (int index = 0; index < resources.Length; ++index)
        {
          lsnstaticArray[index] = new lsnstatic();
          lsnstaticArray[index].name = resources[index].name;
        }
        baseResponses = base_resource.delete_bulk_request(client, (base_resource[]) lsnstaticArray);
      }
      return baseResponses;
    }

    public static lsnstatic[] get(nitro_service service) => (lsnstatic[]) new lsnstatic().get_resources(service, (options) null);

    public static lsnstatic[] get(nitro_service service, options option) => (lsnstatic[]) new lsnstatic().get_resources(service, option);

    public static lsnstatic[] get(nitro_service service, lsnstatic_args args)
    {
      lsnstatic lsnstatic = new lsnstatic();
      options option = new options();
      option.set_args(nitro_util.object_to_string_withoutquotes((object) args));
      return (lsnstatic[]) lsnstatic.get_resources(service, option);
    }

    public static lsnstatic get(nitro_service service, string name) => (lsnstatic) new lsnstatic()
    {
      name = name
    }.get_resource(service);

    public static lsnstatic[] get(nitro_service service, string[] name)
    {
      if (name == null || name.Length <= 0)
        return (lsnstatic[]) null;
      lsnstatic[] lsnstaticArray1 = new lsnstatic[name.Length];
      lsnstatic[] lsnstaticArray2 = new lsnstatic[name.Length];
      for (int index = 0; index < name.Length; ++index)
      {
        lsnstaticArray2[index] = new lsnstatic();
        lsnstaticArray2[index].name = name[index];
        lsnstaticArray1[index] = (lsnstatic) lsnstaticArray2[index].get_resource(service);
      }
      return lsnstaticArray1;
    }

    public static lsnstatic[] get_filtered(nitro_service service, string filter)
    {
      lsnstatic lsnstatic = new lsnstatic();
      options option = new options();
      option.set_filter(filter);
      return (lsnstatic[]) lsnstatic.getfiltered(service, option);
    }

    public static lsnstatic[] get_filtered(nitro_service service, filtervalue[] filter)
    {
      lsnstatic lsnstatic = new lsnstatic();
      options option = new options();
      option.set_filter(filter);
      return (lsnstatic[]) lsnstatic.getfiltered(service, option);
    }

    public static uint count(nitro_service service)
    {
      lsnstatic lsnstatic = new lsnstatic();
      options option = new options();
      option.set_count(true);
      lsnstatic[] resources = (lsnstatic[]) lsnstatic.get_resources(service, option);
      return resources != null && resources.Length > 0 ? resources[0].__count.Value : 0U;
    }

    public static uint count_filtered(nitro_service service, string filter)
    {
      lsnstatic lsnstatic = new lsnstatic();
      options option = new options();
      option.set_count(true);
      option.set_filter(filter);
      lsnstatic[] lsnstaticArray = (lsnstatic[]) lsnstatic.getfiltered(service, option);
      return lsnstaticArray != null && lsnstaticArray.Length > 0 ? lsnstaticArray[0].__count.Value : 0U;
    }

    public static uint count_filtered(nitro_service service, filtervalue[] filter)
    {
      lsnstatic lsnstatic = new lsnstatic();
      options option = new options();
      option.set_count(true);
      option.set_filter(filter);
      lsnstatic[] lsnstaticArray = (lsnstatic[]) lsnstatic.getfiltered(service, option);
      return lsnstaticArray != null && lsnstaticArray.Length > 0 ? lsnstaticArray[0].__count.Value : 0U;
    }

    private class lsnstatic_response : base_response
    {
      public lsnstatic[] lsnstatic = (lsnstatic[]) null;
    }

    public static class transportprotocolEnum
    {
      public const string TCP = "TCP";
      public const string UDP = "UDP";
      public const string ICMP = "ICMP";
    }

    public static class statusEnum
    {
      public const string ACTIVE = "ACTIVE";
      public const string INACTIVE = "INACTIVE";
    }

    public static class nattypeEnum
    {
      public const string NAT44 = "NAT44";
      public const string DS_Lite = "DS-Lite";
    }
  }
}
