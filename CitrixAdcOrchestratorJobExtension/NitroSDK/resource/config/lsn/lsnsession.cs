// Decompiled with JetBrains decompiler
// Type: com.citrix.netscaler.nitro.resource.config.lsn.lsnsession
// Assembly: nitro, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 6CF5DDEF-E052-4F9D-953F-6644F8378A66


using com.citrix.netscaler.nitro.exception;
using com.citrix.netscaler.nitro.resource.Base;
using com.citrix.netscaler.nitro.service;
using com.citrix.netscaler.nitro.util;

namespace com.citrix.netscaler.nitro.resource.config.lsn
{
  public class lsnsession : base_resource
  {
    private string nattypeField = (string) null;
    private string clientnameField = (string) null;
    private string networkField = (string) null;
    private string netmaskField = (string) null;
    private string network6Field = (string) null;
    private uint? tdField = new uint?();
    private string natipField = (string) null;
    private ushort? natport2Field = new ushort?();
    private string natprefixField = (string) null;
    private string subscripField = (string) null;
    private ushort? subscrportField = new ushort?();
    private string destipField = (string) null;
    private ushort? destportField = new ushort?();
    private ushort? natportField = new ushort?();
    private string transportprotocolField = (string) null;
    private string sessionestdirField = (string) null;
    private uint? dsttdField = new uint?();
    private uint? srctdField = new uint?();
    private uint? __countField = new uint?();

    public uint? __count
    {
      get => this.__countField;
      private set => this.__countField = value;
    }

    public string nattype
    {
      get => this.nattypeField;
      set => this.nattypeField = value;
    }

    public string clientname
    {
      get => this.clientnameField;
      set => this.clientnameField = value;
    }

    public string network
    {
      get => this.networkField;
      set => this.networkField = value;
    }

    public string netmask
    {
      get => this.netmaskField;
      set => this.netmaskField = value;
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

    public ushort? natport2
    {
      get => this.natport2Field;
      set => this.natport2Field = value;
    }

    public string natprefix
    {
      get => this.natprefixField;
      private set => this.natprefixField = value;
    }

    public string subscrip
    {
      get => this.subscripField;
      private set => this.subscripField = value;
    }

    public ushort? subscrport
    {
      get => this.subscrportField;
      private set => this.subscrportField = value;
    }

    public string destip
    {
      get => this.destipField;
      private set => this.destipField = value;
    }

    public ushort? destport
    {
      get => this.destportField;
      private set => this.destportField = value;
    }

    public ushort? natport
    {
      get => this.natportField;
      private set => this.natportField = value;
    }

    public string transportprotocol
    {
      get => this.transportprotocolField;
      private set => this.transportprotocolField = value;
    }

    public string sessionestdir
    {
      get => this.sessionestdirField;
      private set => this.sessionestdirField = value;
    }

    public uint? dsttd
    {
      get => this.dsttdField;
      private set => this.dsttdField = value;
    }

    public uint? srctd
    {
      get => this.srctdField;
      private set => this.srctdField = value;
    }

    internal override base_resource[] get_nitro_response(
      nitro_service service,
      string response)
    {
      lsnsession.lsnsession_response lsnsessionResponse = new lsnsession.lsnsession_response();
      lsnsession.lsnsession_response resource = (lsnsession.lsnsession_response) service.get_payload_formatter().string_to_resource(lsnsessionResponse.GetType(), response);
      if (resource.errorcode != 0)
      {
        if (resource.errorcode == 444)
          service.clear_session();
        if (resource.severity == null)
          throw new nitro_exception(resource.message, resource.errorcode);
        if (resource.severity.Equals("ERROR"))
          throw new nitro_exception(resource.message, resource.errorcode);
      }
      return (base_resource[]) resource.lsnsession;
    }

    internal override string get_object_name() => (string) null;

    public static base_response flush(nitro_service client, lsnsession resource) => new lsnsession()
    {
      nattype = resource.nattype,
      clientname = resource.clientname,
      network = resource.network,
      netmask = resource.netmask,
      network6 = resource.network6,
      td = resource.td,
      natip = resource.natip,
      natport2 = resource.natport2
    }.perform_operation_byaction(client, nameof (flush));

    public static base_responses flush(nitro_service client, lsnsession[] resources)
    {
      base_responses baseResponses = (base_responses) null;
      if (resources != null && resources.Length > 0)
      {
        lsnsession[] lsnsessionArray = new lsnsession[resources.Length];
        for (int index = 0; index < resources.Length; ++index)
        {
          lsnsessionArray[index] = new lsnsession();
          lsnsessionArray[index].nattype = resources[index].nattype;
          lsnsessionArray[index].clientname = resources[index].clientname;
          lsnsessionArray[index].network = resources[index].network;
          lsnsessionArray[index].netmask = resources[index].netmask;
          lsnsessionArray[index].network6 = resources[index].network6;
          lsnsessionArray[index].td = resources[index].td;
          lsnsessionArray[index].natip = resources[index].natip;
          lsnsessionArray[index].natport2 = resources[index].natport2;
        }
        baseResponses = base_resource.perform_operation_bulk_request(client, (base_resource[]) lsnsessionArray, nameof (flush));
      }
      return baseResponses;
    }

    public static lsnsession[] get(nitro_service service) => (lsnsession[]) new lsnsession().get_resources(service, (options) null);

    public static lsnsession[] get(nitro_service service, options option) => (lsnsession[]) new lsnsession().get_resources(service, option);

    public static lsnsession[] get(nitro_service service, lsnsession_args args)
    {
      lsnsession lsnsession = new lsnsession();
      options option = new options();
      option.set_args(nitro_util.object_to_string_withoutquotes((object) args));
      return (lsnsession[]) lsnsession.get_resources(service, option);
    }

    public static lsnsession[] get_filtered(nitro_service service, string filter)
    {
      lsnsession lsnsession = new lsnsession();
      options option = new options();
      option.set_filter(filter);
      return (lsnsession[]) lsnsession.getfiltered(service, option);
    }

    public static lsnsession[] get_filtered(nitro_service service, filtervalue[] filter)
    {
      lsnsession lsnsession = new lsnsession();
      options option = new options();
      option.set_filter(filter);
      return (lsnsession[]) lsnsession.getfiltered(service, option);
    }

    public static uint count(nitro_service service)
    {
      lsnsession lsnsession = new lsnsession();
      options option = new options();
      option.set_count(true);
      lsnsession[] resources = (lsnsession[]) lsnsession.get_resources(service, option);
      return resources != null && resources.Length > 0 ? resources[0].__count.Value : 0U;
    }

    public static uint count_filtered(nitro_service service, string filter)
    {
      lsnsession lsnsession = new lsnsession();
      options option = new options();
      option.set_count(true);
      option.set_filter(filter);
      lsnsession[] lsnsessionArray = (lsnsession[]) lsnsession.getfiltered(service, option);
      return lsnsessionArray != null && lsnsessionArray.Length > 0 ? lsnsessionArray[0].__count.Value : 0U;
    }

    public static uint count_filtered(nitro_service service, filtervalue[] filter)
    {
      lsnsession lsnsession = new lsnsession();
      options option = new options();
      option.set_count(true);
      option.set_filter(filter);
      lsnsession[] lsnsessionArray = (lsnsession[]) lsnsession.getfiltered(service, option);
      return lsnsessionArray != null && lsnsessionArray.Length > 0 ? lsnsessionArray[0].__count.Value : 0U;
    }

    private class lsnsession_response : base_response
    {
      public lsnsession[] lsnsession = (lsnsession[]) null;
    }

    public static class transportprotocolEnum
    {
      public const string TCP = "TCP";
      public const string UDP = "UDP";
      public const string ICMP = "ICMP";
    }

    public static class sessionestdirEnum
    {
      public const string OUT = "OUT";
      public const string IN = "IN";
    }

    public static class nattypeEnum
    {
      public const string NAT44 = "NAT44";
      public const string DS_Lite = "DS-Lite";
    }
  }
}
