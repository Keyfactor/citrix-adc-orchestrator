// Decompiled with JetBrains decompiler
// Type: com.citrix.netscaler.nitro.resource.config.network.iptunnelparam
// Assembly: nitro, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 6CF5DDEF-E052-4F9D-953F-6644F8378A66


using com.citrix.netscaler.nitro.exception;
using com.citrix.netscaler.nitro.resource.Base;
using com.citrix.netscaler.nitro.service;

namespace com.citrix.netscaler.nitro.resource.config.network
{
  public class iptunnelparam : base_resource
  {
    private string srcipField = (string) null;
    private string dropfragField = (string) null;
    private uint? dropfragcputhresholdField = new uint?();
    private string srciproundrobinField = (string) null;
    private string enablestrictrxField = (string) null;
    private string enablestricttxField = (string) null;

    public string srcip
    {
      get => this.srcipField;
      set => this.srcipField = value;
    }

    public string dropfrag
    {
      get => this.dropfragField;
      set => this.dropfragField = value;
    }

    public uint? dropfragcputhreshold
    {
      get => this.dropfragcputhresholdField;
      set => this.dropfragcputhresholdField = value;
    }

    public string srciproundrobin
    {
      get => this.srciproundrobinField;
      set => this.srciproundrobinField = value;
    }

    public string enablestrictrx
    {
      get => this.enablestrictrxField;
      set => this.enablestrictrxField = value;
    }

    public string enablestricttx
    {
      get => this.enablestricttxField;
      set => this.enablestricttxField = value;
    }

    internal override base_resource[] get_nitro_response(
      nitro_service service,
      string response)
    {
      iptunnelparam[] iptunnelparamArray = new iptunnelparam[1];
      iptunnelparam.iptunnelparam_response iptunnelparamResponse = new iptunnelparam.iptunnelparam_response();
      iptunnelparam.iptunnelparam_response resource = (iptunnelparam.iptunnelparam_response) service.get_payload_formatter().string_to_resource(iptunnelparamResponse.GetType(), response);
      if (resource.errorcode != 0)
      {
        if (resource.errorcode == 444)
          service.clear_session();
        if (resource.severity == null)
          throw new nitro_exception(resource.message, resource.errorcode);
        if (resource.severity.Equals("ERROR"))
          throw new nitro_exception(resource.message, resource.errorcode);
      }
      iptunnelparamArray[0] = resource.iptunnelparam;
      return (base_resource[]) iptunnelparamArray;
    }

    internal override string get_object_name() => (string) null;

    public static base_response update(nitro_service client, iptunnelparam resource) => new iptunnelparam()
    {
      srcip = resource.srcip,
      dropfrag = resource.dropfrag,
      dropfragcputhreshold = resource.dropfragcputhreshold,
      srciproundrobin = resource.srciproundrobin,
      enablestrictrx = resource.enablestrictrx,
      enablestricttx = resource.enablestricttx
    }.update_resource(client);

    public static base_response unset(
      nitro_service client,
      iptunnelparam resource,
      string[] args)
    {
      return new iptunnelparam().unset_resource(client, args);
    }

    public static iptunnelparam get(nitro_service service) => ((iptunnelparam[]) new iptunnelparam().get_resources(service, (options) null))[0];

    public static iptunnelparam get(nitro_service service, options option) => ((iptunnelparam[]) new iptunnelparam().get_resources(service, option))[0];

    private class iptunnelparam_response : base_response
    {
      public iptunnelparam iptunnelparam = (iptunnelparam) null;
    }

    public static class enablestrictrxEnum
    {
      public const string YES = "YES";
      public const string NO = "NO";
    }

    public static class enablestricttxEnum
    {
      public const string YES = "YES";
      public const string NO = "NO";
    }

    public static class dropfragEnum
    {
      public const string YES = "YES";
      public const string NO = "NO";
    }

    public static class srciproundrobinEnum
    {
      public const string YES = "YES";
      public const string NO = "NO";
    }
  }
}
