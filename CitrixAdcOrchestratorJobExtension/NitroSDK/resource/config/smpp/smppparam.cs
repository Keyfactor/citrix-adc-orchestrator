// Decompiled with JetBrains decompiler
// Type: com.citrix.netscaler.nitro.resource.config.smpp.smppparam
// Assembly: nitro, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 6CF5DDEF-E052-4F9D-953F-6644F8378A66


using com.citrix.netscaler.nitro.exception;
using com.citrix.netscaler.nitro.resource.Base;
using com.citrix.netscaler.nitro.service;

namespace com.citrix.netscaler.nitro.resource.config.smpp
{
  public class smppparam : base_resource
  {
    private string clientmodeField = (string) null;
    private string msgqueueField = (string) null;
    private uint? msgqueuesizeField = new uint?();
    private uint? addrtonField = new uint?();
    private uint? addrnpiField = new uint?();
    private string addrrangeField = (string) null;

    public string clientmode
    {
      get => this.clientmodeField;
      set => this.clientmodeField = value;
    }

    public string msgqueue
    {
      get => this.msgqueueField;
      set => this.msgqueueField = value;
    }

    public uint? msgqueuesize
    {
      get => this.msgqueuesizeField;
      set => this.msgqueuesizeField = value;
    }

    public uint? addrton
    {
      get => this.addrtonField;
      set => this.addrtonField = value;
    }

    public uint? addrnpi
    {
      get => this.addrnpiField;
      set => this.addrnpiField = value;
    }

    public string addrrange
    {
      get => this.addrrangeField;
      set => this.addrrangeField = value;
    }

    internal override base_resource[] get_nitro_response(
      nitro_service service,
      string response)
    {
      smppparam[] smppparamArray = new smppparam[1];
      smppparam.smppparam_response smppparamResponse = new smppparam.smppparam_response();
      smppparam.smppparam_response resource = (smppparam.smppparam_response) service.get_payload_formatter().string_to_resource(smppparamResponse.GetType(), response);
      if (resource.errorcode != 0)
      {
        if (resource.errorcode == 444)
          service.clear_session();
        if (resource.severity == null)
          throw new nitro_exception(resource.message, resource.errorcode);
        if (resource.severity.Equals("ERROR"))
          throw new nitro_exception(resource.message, resource.errorcode);
      }
      smppparamArray[0] = resource.smppparam;
      return (base_resource[]) smppparamArray;
    }

    internal override string get_object_name() => (string) null;

    public static base_response update(nitro_service client, smppparam resource) => new smppparam()
    {
      clientmode = resource.clientmode,
      msgqueue = resource.msgqueue,
      msgqueuesize = resource.msgqueuesize,
      addrton = resource.addrton,
      addrnpi = resource.addrnpi,
      addrrange = resource.addrrange
    }.update_resource(client);

    public static base_response unset(
      nitro_service client,
      smppparam resource,
      string[] args)
    {
      return new smppparam().unset_resource(client, args);
    }

    public static smppparam get(nitro_service service) => ((smppparam[]) new smppparam().get_resources(service, (options) null))[0];

    public static smppparam get(nitro_service service, options option) => ((smppparam[]) new smppparam().get_resources(service, option))[0];

    private class smppparam_response : base_response
    {
      public smppparam smppparam = (smppparam) null;
    }

    public static class clientmodeEnum
    {
      public const string TRANSCEIVER = "TRANSCEIVER";
      public const string TRANSMITTERONLY = "TRANSMITTERONLY";
      public const string RECEIVERONLY = "RECEIVERONLY";
    }

    public static class msgqueueEnum
    {
      public const string ON = "ON";
      public const string OFF = "OFF";
    }
  }
}
