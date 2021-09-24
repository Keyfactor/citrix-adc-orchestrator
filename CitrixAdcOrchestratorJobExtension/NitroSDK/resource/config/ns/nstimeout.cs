// Decompiled with JetBrains decompiler
// Type: com.citrix.netscaler.nitro.resource.config.ns.nstimeout
// Assembly: nitro, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 6CF5DDEF-E052-4F9D-953F-6644F8378A66


using com.citrix.netscaler.nitro.exception;
using com.citrix.netscaler.nitro.resource.Base;
using com.citrix.netscaler.nitro.service;

namespace com.citrix.netscaler.nitro.resource.config.ns
{
  public class nstimeout : base_resource
  {
    private uint? zombieField = new uint?();
    private uint? clientField = new uint?();
    private uint? serverField = new uint?();
    private uint? httpclientField = new uint?();
    private uint? httpserverField = new uint?();
    private uint? tcpclientField = new uint?();
    private uint? tcpserverField = new uint?();
    private uint? anyclientField = new uint?();
    private uint? anyserverField = new uint?();
    private uint? anytcpclientField = new uint?();
    private uint? anytcpserverField = new uint?();
    private uint? halfcloseField = new uint?();
    private uint? nontcpzombieField = new uint?();
    private uint? reducedfintimeoutField = new uint?();
    private uint? reducedrsttimeoutField = new uint?();
    private uint? newconnidletimeoutField = new uint?();

    public uint? zombie
    {
      get => this.zombieField;
      set => this.zombieField = value;
    }

    public uint? client
    {
      get => this.clientField;
      set => this.clientField = value;
    }

    public uint? server
    {
      get => this.serverField;
      set => this.serverField = value;
    }

    public uint? httpclient
    {
      get => this.httpclientField;
      set => this.httpclientField = value;
    }

    public uint? httpserver
    {
      get => this.httpserverField;
      set => this.httpserverField = value;
    }

    public uint? tcpclient
    {
      get => this.tcpclientField;
      set => this.tcpclientField = value;
    }

    public uint? tcpserver
    {
      get => this.tcpserverField;
      set => this.tcpserverField = value;
    }

    public uint? anyclient
    {
      get => this.anyclientField;
      set => this.anyclientField = value;
    }

    public uint? anyserver
    {
      get => this.anyserverField;
      set => this.anyserverField = value;
    }

    public uint? anytcpclient
    {
      get => this.anytcpclientField;
      set => this.anytcpclientField = value;
    }

    public uint? anytcpserver
    {
      get => this.anytcpserverField;
      set => this.anytcpserverField = value;
    }

    public uint? halfclose
    {
      get => this.halfcloseField;
      set => this.halfcloseField = value;
    }

    public uint? nontcpzombie
    {
      get => this.nontcpzombieField;
      set => this.nontcpzombieField = value;
    }

    public uint? reducedfintimeout
    {
      get => this.reducedfintimeoutField;
      set => this.reducedfintimeoutField = value;
    }

    public uint? reducedrsttimeout
    {
      get => this.reducedrsttimeoutField;
      set => this.reducedrsttimeoutField = value;
    }

    public uint? newconnidletimeout
    {
      get => this.newconnidletimeoutField;
      set => this.newconnidletimeoutField = value;
    }

    internal override base_resource[] get_nitro_response(
      nitro_service service,
      string response)
    {
      nstimeout[] nstimeoutArray = new nstimeout[1];
      nstimeout.nstimeout_response nstimeoutResponse = new nstimeout.nstimeout_response();
      nstimeout.nstimeout_response resource = (nstimeout.nstimeout_response) service.get_payload_formatter().string_to_resource(nstimeoutResponse.GetType(), response);
      if (resource.errorcode != 0)
      {
        if (resource.errorcode == 444)
          service.clear_session();
        if (resource.severity == null)
          throw new nitro_exception(resource.message, resource.errorcode);
        if (resource.severity.Equals("ERROR"))
          throw new nitro_exception(resource.message, resource.errorcode);
      }
      nstimeoutArray[0] = resource.nstimeout;
      return (base_resource[]) nstimeoutArray;
    }

    internal override string get_object_name() => (string) null;

    public static base_response update(nitro_service client, nstimeout resource) => new nstimeout()
    {
      zombie = resource.zombie,
      client = resource.client,
      server = resource.server,
      httpclient = resource.httpclient,
      httpserver = resource.httpserver,
      tcpclient = resource.tcpclient,
      tcpserver = resource.tcpserver,
      anyclient = resource.anyclient,
      anyserver = resource.anyserver,
      anytcpclient = resource.anytcpclient,
      anytcpserver = resource.anytcpserver,
      halfclose = resource.halfclose,
      nontcpzombie = resource.nontcpzombie,
      reducedfintimeout = resource.reducedfintimeout,
      reducedrsttimeout = resource.reducedrsttimeout,
      newconnidletimeout = resource.newconnidletimeout
    }.update_resource(client);

    public static base_response unset(
      nitro_service client,
      nstimeout resource,
      string[] args)
    {
      return new nstimeout().unset_resource(client, args);
    }

    public static nstimeout get(nitro_service service) => ((nstimeout[]) new nstimeout().get_resources(service, (options) null))[0];

    public static nstimeout get(nitro_service service, options option) => ((nstimeout[]) new nstimeout().get_resources(service, option))[0];

    private class nstimeout_response : base_response
    {
      public nstimeout nstimeout = (nstimeout) null;
    }
  }
}
