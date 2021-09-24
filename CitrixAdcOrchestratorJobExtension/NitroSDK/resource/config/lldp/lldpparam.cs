// Decompiled with JetBrains decompiler
// Type: com.citrix.netscaler.nitro.resource.config.lldp.lldpparam
// Assembly: nitro, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 6CF5DDEF-E052-4F9D-953F-6644F8378A66


using com.citrix.netscaler.nitro.exception;
using com.citrix.netscaler.nitro.resource.Base;
using com.citrix.netscaler.nitro.service;

namespace com.citrix.netscaler.nitro.resource.config.lldp
{
  public class lldpparam : base_resource
  {
    private uint? holdtimetxmultField = new uint?();
    private uint? timerField = new uint?();
    private string modeField = (string) null;

    public uint? holdtimetxmult
    {
      get => this.holdtimetxmultField;
      set => this.holdtimetxmultField = value;
    }

    public uint? timer
    {
      get => this.timerField;
      set => this.timerField = value;
    }

    public string mode
    {
      get => this.modeField;
      set => this.modeField = value;
    }

    internal override base_resource[] get_nitro_response(
      nitro_service service,
      string response)
    {
      lldpparam[] lldpparamArray = new lldpparam[1];
      lldpparam.lldpparam_response lldpparamResponse = new lldpparam.lldpparam_response();
      lldpparam.lldpparam_response resource = (lldpparam.lldpparam_response) service.get_payload_formatter().string_to_resource(lldpparamResponse.GetType(), response);
      if (resource.errorcode != 0)
      {
        if (resource.errorcode == 444)
          service.clear_session();
        if (resource.severity == null)
          throw new nitro_exception(resource.message, resource.errorcode);
        if (resource.severity.Equals("ERROR"))
          throw new nitro_exception(resource.message, resource.errorcode);
      }
      lldpparamArray[0] = resource.lldpparam;
      return (base_resource[]) lldpparamArray;
    }

    internal override string get_object_name() => (string) null;

    public static base_response update(nitro_service client, lldpparam resource) => new lldpparam()
    {
      holdtimetxmult = resource.holdtimetxmult,
      timer = resource.timer,
      mode = resource.mode
    }.update_resource(client);

    public static base_response unset(
      nitro_service client,
      lldpparam resource,
      string[] args)
    {
      return new lldpparam().unset_resource(client, args);
    }

    public static lldpparam get(nitro_service service) => ((lldpparam[]) new lldpparam().get_resources(service, (options) null))[0];

    public static lldpparam get(nitro_service service, options option) => ((lldpparam[]) new lldpparam().get_resources(service, option))[0];

    private class lldpparam_response : base_response
    {
      public lldpparam lldpparam = (lldpparam) null;
    }

    public static class modeEnum
    {
      public const string NONE = "NONE";
      public const string TRANSMITTER = "TRANSMITTER";
      public const string RECEIVER = "RECEIVER";
      public const string TRANSCEIVER = "TRANSCEIVER";
    }
  }
}
