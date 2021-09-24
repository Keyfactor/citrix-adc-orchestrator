// Decompiled with JetBrains decompiler
// Type: com.citrix.netscaler.nitro.resource.config.lb.lbsipparameters
// Assembly: nitro, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 6CF5DDEF-E052-4F9D-953F-6644F8378A66


using com.citrix.netscaler.nitro.exception;
using com.citrix.netscaler.nitro.resource.Base;
using com.citrix.netscaler.nitro.service;

namespace com.citrix.netscaler.nitro.resource.config.lb
{
  public class lbsipparameters : base_resource
  {
    private ushort? rnatsrcportField = new ushort?();
    private ushort? rnatdstportField = new ushort?();
    private int? retrydurField = new int?();
    private string addrportvipField = (string) null;
    private uint? sip503ratethresholdField = new uint?();
    private ushort? rnatsecuresrcportField = new ushort?();
    private ushort? rnatsecuredstportField = new ushort?();

    public ushort? rnatsrcport
    {
      get => this.rnatsrcportField;
      set => this.rnatsrcportField = value;
    }

    public ushort? rnatdstport
    {
      get => this.rnatdstportField;
      set => this.rnatdstportField = value;
    }

    public int? retrydur
    {
      get => this.retrydurField;
      set => this.retrydurField = value;
    }

    public string addrportvip
    {
      get => this.addrportvipField;
      set => this.addrportvipField = value;
    }

    public uint? sip503ratethreshold
    {
      get => this.sip503ratethresholdField;
      set => this.sip503ratethresholdField = value;
    }

    public ushort? rnatsecuresrcport
    {
      get => this.rnatsecuresrcportField;
      set => this.rnatsecuresrcportField = value;
    }

    public ushort? rnatsecuredstport
    {
      get => this.rnatsecuredstportField;
      set => this.rnatsecuredstportField = value;
    }

    internal override base_resource[] get_nitro_response(
      nitro_service service,
      string response)
    {
      lbsipparameters[] lbsipparametersArray = new lbsipparameters[1];
      lbsipparameters.lbsipparameters_response lbsipparametersResponse = new lbsipparameters.lbsipparameters_response();
      lbsipparameters.lbsipparameters_response resource = (lbsipparameters.lbsipparameters_response) service.get_payload_formatter().string_to_resource(lbsipparametersResponse.GetType(), response);
      if (resource.errorcode != 0)
      {
        if (resource.errorcode == 444)
          service.clear_session();
        if (resource.severity == null)
          throw new nitro_exception(resource.message, resource.errorcode);
        if (resource.severity.Equals("ERROR"))
          throw new nitro_exception(resource.message, resource.errorcode);
      }
      lbsipparametersArray[0] = resource.lbsipparameters;
      return (base_resource[]) lbsipparametersArray;
    }

    internal override string get_object_name() => (string) null;

    public static base_response update(nitro_service client, lbsipparameters resource) => new lbsipparameters()
    {
      rnatsrcport = resource.rnatsrcport,
      rnatdstport = resource.rnatdstport,
      retrydur = resource.retrydur,
      addrportvip = resource.addrportvip,
      sip503ratethreshold = resource.sip503ratethreshold,
      rnatsecuresrcport = resource.rnatsecuresrcport,
      rnatsecuredstport = resource.rnatsecuredstport
    }.update_resource(client);

    public static base_response unset(
      nitro_service client,
      lbsipparameters resource,
      string[] args)
    {
      return new lbsipparameters().unset_resource(client, args);
    }

    public static lbsipparameters get(nitro_service service) => ((lbsipparameters[]) new lbsipparameters().get_resources(service, (options) null))[0];

    public static lbsipparameters get(nitro_service service, options option) => ((lbsipparameters[]) new lbsipparameters().get_resources(service, option))[0];

    private class lbsipparameters_response : base_response
    {
      public lbsipparameters lbsipparameters = (lbsipparameters) null;
    }

    public static class addrportvipEnum
    {
      public const string ENABLED = "ENABLED";
      public const string DISABLED = "DISABLED";
    }
  }
}
