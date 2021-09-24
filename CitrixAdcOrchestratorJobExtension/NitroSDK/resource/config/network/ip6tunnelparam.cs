// Decompiled with JetBrains decompiler
// Type: com.citrix.netscaler.nitro.resource.config.network.ip6tunnelparam
// Assembly: nitro, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 6CF5DDEF-E052-4F9D-953F-6644F8378A66


using com.citrix.netscaler.nitro.exception;
using com.citrix.netscaler.nitro.resource.Base;
using com.citrix.netscaler.nitro.service;

namespace com.citrix.netscaler.nitro.resource.config.network
{
  public class ip6tunnelparam : base_resource
  {
    private string srcipField = (string) null;
    private string dropfragField = (string) null;
    private uint? dropfragcputhresholdField = new uint?();
    private string srciproundrobinField = (string) null;

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

    internal override base_resource[] get_nitro_response(
      nitro_service service,
      string response)
    {
      ip6tunnelparam[] ip6tunnelparamArray = new ip6tunnelparam[1];
      ip6tunnelparam.ip6tunnelparam_response ip6tunnelparamResponse = new ip6tunnelparam.ip6tunnelparam_response();
      ip6tunnelparam.ip6tunnelparam_response resource = (ip6tunnelparam.ip6tunnelparam_response) service.get_payload_formatter().string_to_resource(ip6tunnelparamResponse.GetType(), response);
      if (resource.errorcode != 0)
      {
        if (resource.errorcode == 444)
          service.clear_session();
        if (resource.severity == null)
          throw new nitro_exception(resource.message, resource.errorcode);
        if (resource.severity.Equals("ERROR"))
          throw new nitro_exception(resource.message, resource.errorcode);
      }
      ip6tunnelparamArray[0] = resource.ip6tunnelparam;
      return (base_resource[]) ip6tunnelparamArray;
    }

    internal override string get_object_name() => (string) null;

    public static base_response update(nitro_service client, ip6tunnelparam resource) => new ip6tunnelparam()
    {
      srcip = resource.srcip,
      dropfrag = resource.dropfrag,
      dropfragcputhreshold = resource.dropfragcputhreshold,
      srciproundrobin = resource.srciproundrobin
    }.update_resource(client);

    public static base_response unset(
      nitro_service client,
      ip6tunnelparam resource,
      string[] args)
    {
      return new ip6tunnelparam().unset_resource(client, args);
    }

    public static ip6tunnelparam get(nitro_service service) => ((ip6tunnelparam[]) new ip6tunnelparam().get_resources(service, (options) null))[0];

    public static ip6tunnelparam get(nitro_service service, options option) => ((ip6tunnelparam[]) new ip6tunnelparam().get_resources(service, option))[0];

    private class ip6tunnelparam_response : base_response
    {
      public ip6tunnelparam ip6tunnelparam = (ip6tunnelparam) null;
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
