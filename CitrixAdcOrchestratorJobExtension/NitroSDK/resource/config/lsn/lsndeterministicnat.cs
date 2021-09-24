// Decompiled with JetBrains decompiler
// Type: com.citrix.netscaler.nitro.resource.config.lsn.lsndeterministicnat
// Assembly: nitro, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 6CF5DDEF-E052-4F9D-953F-6644F8378A66


using com.citrix.netscaler.nitro.exception;
using com.citrix.netscaler.nitro.resource.Base;
using com.citrix.netscaler.nitro.service;
using com.citrix.netscaler.nitro.util;

namespace com.citrix.netscaler.nitro.resource.config.lsn
{
  public class lsndeterministicnat : base_resource
  {
    private string clientnameField = (string) null;
    private string network6Field = (string) null;
    private string subscripField = (string) null;
    private uint? tdField = new uint?();
    private string natipField = (string) null;
    private string natprefixField = (string) null;
    private string subscrip2Field = (string) null;
    private string natip2Field = (string) null;
    private ushort? firstportField = new ushort?();
    private ushort? lastportField = new ushort?();
    private uint? srctdField = new uint?();
    private string nattypeField = (string) null;
    private uint? __countField = new uint?();

    public uint? __count
    {
      get => this.__countField;
      private set => this.__countField = value;
    }

    public string clientname
    {
      get => this.clientnameField;
      set => this.clientnameField = value;
    }

    public string network6
    {
      get => this.network6Field;
      set => this.network6Field = value;
    }

    public string subscrip
    {
      get => this.subscripField;
      set => this.subscripField = value;
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

    public string natprefix
    {
      get => this.natprefixField;
      private set => this.natprefixField = value;
    }

    public string subscrip2
    {
      get => this.subscrip2Field;
      private set => this.subscrip2Field = value;
    }

    public string natip2
    {
      get => this.natip2Field;
      private set => this.natip2Field = value;
    }

    public ushort? firstport
    {
      get => this.firstportField;
      private set => this.firstportField = value;
    }

    public ushort? lastport
    {
      get => this.lastportField;
      private set => this.lastportField = value;
    }

    public uint? srctd
    {
      get => this.srctdField;
      private set => this.srctdField = value;
    }

    public string nattype
    {
      get => this.nattypeField;
      private set => this.nattypeField = value;
    }

    internal override base_resource[] get_nitro_response(
      nitro_service service,
      string response)
    {
      lsndeterministicnat.lsndeterministicnat_response lsndeterministicnatResponse = new lsndeterministicnat.lsndeterministicnat_response();
      lsndeterministicnat.lsndeterministicnat_response resource = (lsndeterministicnat.lsndeterministicnat_response) service.get_payload_formatter().string_to_resource(lsndeterministicnatResponse.GetType(), response);
      if (resource.errorcode != 0)
      {
        if (resource.errorcode == 444)
          service.clear_session();
        if (resource.severity == null)
          throw new nitro_exception(resource.message, resource.errorcode);
        if (resource.severity.Equals("ERROR"))
          throw new nitro_exception(resource.message, resource.errorcode);
      }
      return (base_resource[]) resource.lsndeterministicnat;
    }

    internal override string get_object_name() => (string) null;

    public static lsndeterministicnat[] get(nitro_service service) => (lsndeterministicnat[]) new lsndeterministicnat().get_resources(service, (options) null);

    public static lsndeterministicnat[] get(
      nitro_service service,
      options option)
    {
      return (lsndeterministicnat[]) new lsndeterministicnat().get_resources(service, option);
    }

    public static lsndeterministicnat[] get(
      nitro_service service,
      lsndeterministicnat_args args)
    {
      lsndeterministicnat lsndeterministicnat = new lsndeterministicnat();
      options option = new options();
      option.set_args(nitro_util.object_to_string_withoutquotes((object) args));
      return (lsndeterministicnat[]) lsndeterministicnat.get_resources(service, option);
    }

    public static lsndeterministicnat[] get_filtered(
      nitro_service service,
      string filter)
    {
      lsndeterministicnat lsndeterministicnat = new lsndeterministicnat();
      options option = new options();
      option.set_filter(filter);
      return (lsndeterministicnat[]) lsndeterministicnat.getfiltered(service, option);
    }

    public static lsndeterministicnat[] get_filtered(
      nitro_service service,
      filtervalue[] filter)
    {
      lsndeterministicnat lsndeterministicnat = new lsndeterministicnat();
      options option = new options();
      option.set_filter(filter);
      return (lsndeterministicnat[]) lsndeterministicnat.getfiltered(service, option);
    }

    public static uint count(nitro_service service)
    {
      lsndeterministicnat lsndeterministicnat = new lsndeterministicnat();
      options option = new options();
      option.set_count(true);
      lsndeterministicnat[] resources = (lsndeterministicnat[]) lsndeterministicnat.get_resources(service, option);
      return resources != null && resources.Length > 0 ? resources[0].__count.Value : 0U;
    }

    public static uint count_filtered(nitro_service service, string filter)
    {
      lsndeterministicnat lsndeterministicnat = new lsndeterministicnat();
      options option = new options();
      option.set_count(true);
      option.set_filter(filter);
      lsndeterministicnat[] lsndeterministicnatArray = (lsndeterministicnat[]) lsndeterministicnat.getfiltered(service, option);
      return lsndeterministicnatArray != null && lsndeterministicnatArray.Length > 0 ? lsndeterministicnatArray[0].__count.Value : 0U;
    }

    public static uint count_filtered(nitro_service service, filtervalue[] filter)
    {
      lsndeterministicnat lsndeterministicnat = new lsndeterministicnat();
      options option = new options();
      option.set_count(true);
      option.set_filter(filter);
      lsndeterministicnat[] lsndeterministicnatArray = (lsndeterministicnat[]) lsndeterministicnat.getfiltered(service, option);
      return lsndeterministicnatArray != null && lsndeterministicnatArray.Length > 0 ? lsndeterministicnatArray[0].__count.Value : 0U;
    }

    private class lsndeterministicnat_response : base_response
    {
      public lsndeterministicnat[] lsndeterministicnat = (lsndeterministicnat[]) null;
    }

    public static class nattypeEnum
    {
      public const string NAT44 = "NAT44";
      public const string DS_Lite = "DS-Lite";
    }
  }
}
