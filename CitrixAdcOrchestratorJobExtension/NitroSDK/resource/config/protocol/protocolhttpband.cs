// Decompiled with JetBrains decompiler
// Type: com.citrix.netscaler.nitro.resource.config.protocol.protocolhttpband
// Assembly: nitro, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 6CF5DDEF-E052-4F9D-953F-6644F8378A66


using com.citrix.netscaler.nitro.exception;
using com.citrix.netscaler.nitro.resource.Base;
using com.citrix.netscaler.nitro.service;
using com.citrix.netscaler.nitro.util;

namespace com.citrix.netscaler.nitro.resource.config.protocol
{
  public class protocolhttpband : base_resource
  {
    private int? reqbandsizeField = new int?();
    private int? respbandsizeField = new int?();
    private string typeField = (string) null;
    private int? bandrangeField = new int?();
    private int? numberofbandsField = new int?();
    private long?[] totalbandsizeField = (long?[]) null;
    private long?[] avgbandsizeField = (long?[]) null;
    private double?[] avgbandsizenewField = (double?[]) null;
    private long?[] banddataField = (long?[]) null;
    private double?[] banddatanewField = (double?[]) null;
    private long?[] accesscountField = (long?[]) null;
    private long?[] accessratioField = (long?[]) null;
    private double?[] accessrationewField = (double?[]) null;
    private int?[] totalsField = (int?[]) null;

    public int? reqbandsize
    {
      get => this.reqbandsizeField;
      set => this.reqbandsizeField = value;
    }

    public int? respbandsize
    {
      get => this.respbandsizeField;
      set => this.respbandsizeField = value;
    }

    public string type
    {
      get => this.typeField;
      set => this.typeField = value;
    }

    public int? bandrange
    {
      get => this.bandrangeField;
      private set => this.bandrangeField = value;
    }

    public int? numberofbands
    {
      get => this.numberofbandsField;
      private set => this.numberofbandsField = value;
    }

    public long?[] totalbandsize
    {
      get => this.totalbandsizeField;
      private set => this.totalbandsizeField = value;
    }

    public long?[] avgbandsize
    {
      get => this.avgbandsizeField;
      private set => this.avgbandsizeField = value;
    }

    public double?[] avgbandsizenew
    {
      get => this.avgbandsizenewField;
      private set => this.avgbandsizenewField = value;
    }

    public long?[] banddata
    {
      get => this.banddataField;
      private set => this.banddataField = value;
    }

    public double?[] banddatanew
    {
      get => this.banddatanewField;
      private set => this.banddatanewField = value;
    }

    public long?[] accesscount
    {
      get => this.accesscountField;
      private set => this.accesscountField = value;
    }

    public long?[] accessratio
    {
      get => this.accessratioField;
      private set => this.accessratioField = value;
    }

    public double?[] accessrationew
    {
      get => this.accessrationewField;
      private set => this.accessrationewField = value;
    }

    public int?[] totals
    {
      get => this.totalsField;
      private set => this.totalsField = value;
    }

    internal override base_resource[] get_nitro_response(
      nitro_service service,
      string response)
    {
      protocolhttpband[] protocolhttpbandArray = new protocolhttpband[1];
      protocolhttpband.protocolhttpband_response protocolhttpbandResponse = new protocolhttpband.protocolhttpband_response();
      protocolhttpband.protocolhttpband_response resource = (protocolhttpband.protocolhttpband_response) service.get_payload_formatter().string_to_resource(protocolhttpbandResponse.GetType(), response);
      if (resource.errorcode != 0)
      {
        if (resource.errorcode == 444)
          service.clear_session();
        if (resource.severity == null)
          throw new nitro_exception(resource.message, resource.errorcode);
        if (resource.severity.Equals("ERROR"))
          throw new nitro_exception(resource.message, resource.errorcode);
      }
      protocolhttpbandArray[0] = resource.protocolhttpband;
      return (base_resource[]) protocolhttpbandArray;
    }

    internal override string get_object_name() => (string) null;

    public static base_response update(nitro_service client, protocolhttpband resource) => new protocolhttpband()
    {
      reqbandsize = resource.reqbandsize,
      respbandsize = resource.respbandsize
    }.update_resource(client);

    public static base_response unset(
      nitro_service client,
      protocolhttpband resource,
      string[] args)
    {
      return new protocolhttpband().unset_resource(client, args);
    }

    public static protocolhttpband get(nitro_service service, protocolhttpband obj)
    {
      options option = new options();
      option.set_args(nitro_util.object_to_string_withoutquotes((object) obj));
      return (protocolhttpband) obj.get_resource(service, option);
    }

    public static protocolhttpband[] get(
      nitro_service service,
      protocolhttpband_args args)
    {
      protocolhttpband protocolhttpband = new protocolhttpband();
      options option = new options();
      option.set_args(nitro_util.object_to_string_withoutquotes((object) args));
      return (protocolhttpband[]) protocolhttpband.get_resources(service, option);
    }

    private class protocolhttpband_response : base_response
    {
      public protocolhttpband protocolhttpband = (protocolhttpband) null;
    }

    public static class typeEnum
    {
      public const string REQUEST = "REQUEST";
      public const string RESPONSE = "RESPONSE";
    }
  }
}
