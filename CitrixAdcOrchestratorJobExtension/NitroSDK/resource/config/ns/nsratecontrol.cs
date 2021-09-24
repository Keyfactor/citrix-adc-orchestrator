// Decompiled with JetBrains decompiler
// Type: com.citrix.netscaler.nitro.resource.config.ns.nsratecontrol
// Assembly: nitro, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 6CF5DDEF-E052-4F9D-953F-6644F8378A66


using com.citrix.netscaler.nitro.exception;
using com.citrix.netscaler.nitro.resource.Base;
using com.citrix.netscaler.nitro.service;

namespace com.citrix.netscaler.nitro.resource.config.ns
{
  public class nsratecontrol : base_resource
  {
    private uint? tcpthresholdField = new uint?();
    private uint? udpthresholdField = new uint?();
    private uint? icmpthresholdField = new uint?();
    private uint? tcprstthresholdField = new uint?();

    public uint? tcpthreshold
    {
      get => this.tcpthresholdField;
      set => this.tcpthresholdField = value;
    }

    public uint? udpthreshold
    {
      get => this.udpthresholdField;
      set => this.udpthresholdField = value;
    }

    public uint? icmpthreshold
    {
      get => this.icmpthresholdField;
      set => this.icmpthresholdField = value;
    }

    public uint? tcprstthreshold
    {
      get => this.tcprstthresholdField;
      set => this.tcprstthresholdField = value;
    }

    internal override base_resource[] get_nitro_response(
      nitro_service service,
      string response)
    {
      nsratecontrol[] nsratecontrolArray = new nsratecontrol[1];
      nsratecontrol.nsratecontrol_response nsratecontrolResponse = new nsratecontrol.nsratecontrol_response();
      nsratecontrol.nsratecontrol_response resource = (nsratecontrol.nsratecontrol_response) service.get_payload_formatter().string_to_resource(nsratecontrolResponse.GetType(), response);
      if (resource.errorcode != 0)
      {
        if (resource.errorcode == 444)
          service.clear_session();
        if (resource.severity == null)
          throw new nitro_exception(resource.message, resource.errorcode);
        if (resource.severity.Equals("ERROR"))
          throw new nitro_exception(resource.message, resource.errorcode);
      }
      nsratecontrolArray[0] = resource.nsratecontrol;
      return (base_resource[]) nsratecontrolArray;
    }

    internal override string get_object_name() => (string) null;

    public static base_response update(nitro_service client, nsratecontrol resource) => new nsratecontrol()
    {
      tcpthreshold = resource.tcpthreshold,
      udpthreshold = resource.udpthreshold,
      icmpthreshold = resource.icmpthreshold,
      tcprstthreshold = resource.tcprstthreshold
    }.update_resource(client);

    public static base_response unset(
      nitro_service client,
      nsratecontrol resource,
      string[] args)
    {
      return new nsratecontrol().unset_resource(client, args);
    }

    public static nsratecontrol get(nitro_service service) => ((nsratecontrol[]) new nsratecontrol().get_resources(service, (options) null))[0];

    public static nsratecontrol get(nitro_service service, options option) => ((nsratecontrol[]) new nsratecontrol().get_resources(service, option))[0];

    private class nsratecontrol_response : base_response
    {
      public nsratecontrol nsratecontrol = (nsratecontrol) null;
    }
  }
}
