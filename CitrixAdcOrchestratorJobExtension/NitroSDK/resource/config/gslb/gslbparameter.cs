// Decompiled with JetBrains decompiler
// Type: com.citrix.netscaler.nitro.resource.config.gslb.gslbparameter
// Assembly: nitro, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 6CF5DDEF-E052-4F9D-953F-6644F8378A66


using com.citrix.netscaler.nitro.exception;
using com.citrix.netscaler.nitro.resource.Base;
using com.citrix.netscaler.nitro.service;

namespace com.citrix.netscaler.nitro.resource.config.gslb
{
  public class gslbparameter : base_resource
  {
    private long? ldnsentrytimeoutField = new long?();
    private uint? rtttoleranceField = new uint?();
    private string ldnsmaskField = (string) null;
    private uint? v6ldnsmasklenField = new uint?();
    private string[] ldnsprobeorderField = (string[]) null;
    private string dropldnsreqField = (string) null;
    private uint? flagsField = new uint?();

    public long? ldnsentrytimeout
    {
      get => this.ldnsentrytimeoutField;
      set => this.ldnsentrytimeoutField = value;
    }

    public uint? rtttolerance
    {
      get => this.rtttoleranceField;
      set => this.rtttoleranceField = value;
    }

    public string ldnsmask
    {
      get => this.ldnsmaskField;
      set => this.ldnsmaskField = value;
    }

    public uint? v6ldnsmasklen
    {
      get => this.v6ldnsmasklenField;
      set => this.v6ldnsmasklenField = value;
    }

    public string[] ldnsprobeorder
    {
      get => this.ldnsprobeorderField;
      set => this.ldnsprobeorderField = value;
    }

    public string dropldnsreq
    {
      get => this.dropldnsreqField;
      set => this.dropldnsreqField = value;
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
      gslbparameter[] gslbparameterArray = new gslbparameter[1];
      gslbparameter.gslbparameter_response gslbparameterResponse = new gslbparameter.gslbparameter_response();
      gslbparameter.gslbparameter_response resource = (gslbparameter.gslbparameter_response) service.get_payload_formatter().string_to_resource(gslbparameterResponse.GetType(), response);
      if (resource.errorcode != 0)
      {
        if (resource.errorcode == 444)
          service.clear_session();
        if (resource.severity == null)
          throw new nitro_exception(resource.message, resource.errorcode);
        if (resource.severity.Equals("ERROR"))
          throw new nitro_exception(resource.message, resource.errorcode);
      }
      gslbparameterArray[0] = resource.gslbparameter;
      return (base_resource[]) gslbparameterArray;
    }

    internal override string get_object_name() => (string) null;

    public static base_response update(nitro_service client, gslbparameter resource) => new gslbparameter()
    {
      ldnsentrytimeout = resource.ldnsentrytimeout,
      rtttolerance = resource.rtttolerance,
      ldnsmask = resource.ldnsmask,
      v6ldnsmasklen = resource.v6ldnsmasklen,
      ldnsprobeorder = resource.ldnsprobeorder,
      dropldnsreq = resource.dropldnsreq
    }.update_resource(client);

    public static base_response unset(
      nitro_service client,
      gslbparameter resource,
      string[] args)
    {
      return new gslbparameter().unset_resource(client, args);
    }

    public static gslbparameter get(nitro_service service) => ((gslbparameter[]) new gslbparameter().get_resources(service, (options) null))[0];

    public static gslbparameter get(nitro_service service, options option) => ((gslbparameter[]) new gslbparameter().get_resources(service, option))[0];

    private class gslbparameter_response : base_response
    {
      public gslbparameter gslbparameter = (gslbparameter) null;
    }

    public static class ldnsprobeorderEnum
    {
      public const string PING = "PING";
      public const string DNS = "DNS";
      public const string TCP = "TCP";
    }

    public static class dropldnsreqEnum
    {
      public const string ENABLED = "ENABLED";
      public const string DISABLED = "DISABLED";
    }
  }
}
