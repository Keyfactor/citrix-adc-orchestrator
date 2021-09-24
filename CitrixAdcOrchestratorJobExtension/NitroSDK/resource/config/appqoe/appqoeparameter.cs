// Decompiled with JetBrains decompiler
// Type: com.citrix.netscaler.nitro.resource.config.appqoe.appqoeparameter
// Assembly: nitro, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 6CF5DDEF-E052-4F9D-953F-6644F8378A66


using com.citrix.netscaler.nitro.exception;
using com.citrix.netscaler.nitro.resource.Base;
using com.citrix.netscaler.nitro.service;

namespace com.citrix.netscaler.nitro.resource.config.appqoe
{
  public class appqoeparameter : base_resource
  {
    private long? sessionlifeField = new long?();
    private uint? avgwaitingclientField = new uint?();
    private uint? maxaltrespbandwidthField = new uint?();
    private uint? dosattackthreshField = new uint?();

    public long? sessionlife
    {
      get => this.sessionlifeField;
      set => this.sessionlifeField = value;
    }

    public uint? avgwaitingclient
    {
      get => this.avgwaitingclientField;
      set => this.avgwaitingclientField = value;
    }

    public uint? maxaltrespbandwidth
    {
      get => this.maxaltrespbandwidthField;
      set => this.maxaltrespbandwidthField = value;
    }

    public uint? dosattackthresh
    {
      get => this.dosattackthreshField;
      set => this.dosattackthreshField = value;
    }

    internal override base_resource[] get_nitro_response(
      nitro_service service,
      string response)
    {
      appqoeparameter[] appqoeparameterArray = new appqoeparameter[1];
      appqoeparameter.appqoeparameter_response appqoeparameterResponse = new appqoeparameter.appqoeparameter_response();
      appqoeparameter.appqoeparameter_response resource = (appqoeparameter.appqoeparameter_response) service.get_payload_formatter().string_to_resource(appqoeparameterResponse.GetType(), response);
      if (resource.errorcode != 0)
      {
        if (resource.errorcode == 444)
          service.clear_session();
        if (resource.severity == null)
          throw new nitro_exception(resource.message, resource.errorcode);
        if (resource.severity.Equals("ERROR"))
          throw new nitro_exception(resource.message, resource.errorcode);
      }
      appqoeparameterArray[0] = resource.appqoeparameter;
      return (base_resource[]) appqoeparameterArray;
    }

    internal override string get_object_name() => (string) null;

    public static base_response update(nitro_service client, appqoeparameter resource) => new appqoeparameter()
    {
      sessionlife = resource.sessionlife,
      avgwaitingclient = resource.avgwaitingclient,
      maxaltrespbandwidth = resource.maxaltrespbandwidth,
      dosattackthresh = resource.dosattackthresh
    }.update_resource(client);

    public static base_response unset(
      nitro_service client,
      appqoeparameter resource,
      string[] args)
    {
      return new appqoeparameter().unset_resource(client, args);
    }

    public static appqoeparameter get(nitro_service service) => ((appqoeparameter[]) new appqoeparameter().get_resources(service, (options) null))[0];

    public static appqoeparameter get(nitro_service service, options option) => ((appqoeparameter[]) new appqoeparameter().get_resources(service, option))[0];

    private class appqoeparameter_response : base_response
    {
      public appqoeparameter appqoeparameter = (appqoeparameter) null;
    }
  }
}
