// Decompiled with JetBrains decompiler
// Type: com.citrix.netscaler.nitro.resource.config.network.l3param
// Assembly: nitro, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 6CF5DDEF-E052-4F9D-953F-6644F8378A66


using com.citrix.netscaler.nitro.exception;
using com.citrix.netscaler.nitro.resource.Base;
using com.citrix.netscaler.nitro.service;

namespace com.citrix.netscaler.nitro.resource.config.network
{
  public class l3param : base_resource
  {
    private string srcnatField = (string) null;
    private uint? icmpgenratethresholdField = new uint?();
    private string overridernatField = (string) null;
    private string dropdfflagField = (string) null;
    private string miproundrobinField = (string) null;
    private string externalloopbackField = (string) null;
    private string tnlpmtuwoconnField = (string) null;
    private string usipserverstraypktField = (string) null;
    private string forwardicmpfragmentsField = (string) null;
    private string dropipfragmentsField = (string) null;
    private uint? acllogtimeField = new uint?();
    private string icmperrgenerateField = (string) null;
    private string overridelsnField = (string) null;
    private string implicitaclallowField = (string) null;
    private string dynamicroutingField = (string) null;

    public string srcnat
    {
      get => this.srcnatField;
      set => this.srcnatField = value;
    }

    public uint? icmpgenratethreshold
    {
      get => this.icmpgenratethresholdField;
      set => this.icmpgenratethresholdField = value;
    }

    public string overridernat
    {
      get => this.overridernatField;
      set => this.overridernatField = value;
    }

    public string dropdfflag
    {
      get => this.dropdfflagField;
      set => this.dropdfflagField = value;
    }

    public string miproundrobin
    {
      get => this.miproundrobinField;
      set => this.miproundrobinField = value;
    }

    public string externalloopback
    {
      get => this.externalloopbackField;
      set => this.externalloopbackField = value;
    }

    public string tnlpmtuwoconn
    {
      get => this.tnlpmtuwoconnField;
      set => this.tnlpmtuwoconnField = value;
    }

    public string usipserverstraypkt
    {
      get => this.usipserverstraypktField;
      set => this.usipserverstraypktField = value;
    }

    public string forwardicmpfragments
    {
      get => this.forwardicmpfragmentsField;
      set => this.forwardicmpfragmentsField = value;
    }

    public string dropipfragments
    {
      get => this.dropipfragmentsField;
      set => this.dropipfragmentsField = value;
    }

    public uint? acllogtime
    {
      get => this.acllogtimeField;
      set => this.acllogtimeField = value;
    }

    public string icmperrgenerate
    {
      get => this.icmperrgenerateField;
      set => this.icmperrgenerateField = value;
    }

    public string overridelsn
    {
      get => this.overridelsnField;
      set => this.overridelsnField = value;
    }

    public string implicitaclallow
    {
      get => this.implicitaclallowField;
      set => this.implicitaclallowField = value;
    }

    public string dynamicrouting
    {
      get => this.dynamicroutingField;
      set => this.dynamicroutingField = value;
    }

    internal override base_resource[] get_nitro_response(
      nitro_service service,
      string response)
    {
      l3param[] l3paramArray = new l3param[1];
      l3param.l3param_response l3paramResponse = new l3param.l3param_response();
      l3param.l3param_response resource = (l3param.l3param_response) service.get_payload_formatter().string_to_resource(l3paramResponse.GetType(), response);
      if (resource.errorcode != 0)
      {
        if (resource.errorcode == 444)
          service.clear_session();
        if (resource.severity == null)
          throw new nitro_exception(resource.message, resource.errorcode);
        if (resource.severity.Equals("ERROR"))
          throw new nitro_exception(resource.message, resource.errorcode);
      }
      l3paramArray[0] = resource.l3param;
      return (base_resource[]) l3paramArray;
    }

    internal override string get_object_name() => (string) null;

    public static base_response update(nitro_service client, l3param resource) => new l3param()
    {
      srcnat = resource.srcnat,
      icmpgenratethreshold = resource.icmpgenratethreshold,
      overridernat = resource.overridernat,
      dropdfflag = resource.dropdfflag,
      miproundrobin = resource.miproundrobin,
      externalloopback = resource.externalloopback,
      tnlpmtuwoconn = resource.tnlpmtuwoconn,
      usipserverstraypkt = resource.usipserverstraypkt,
      forwardicmpfragments = resource.forwardicmpfragments,
      dropipfragments = resource.dropipfragments,
      acllogtime = resource.acllogtime,
      icmperrgenerate = resource.icmperrgenerate,
      overridelsn = resource.overridelsn,
      implicitaclallow = resource.implicitaclallow,
      dynamicrouting = resource.dynamicrouting
    }.update_resource(client);

    public static base_response unset(
      nitro_service client,
      l3param resource,
      string[] args)
    {
      return new l3param().unset_resource(client, args);
    }

    public static l3param get(nitro_service service) => ((l3param[]) new l3param().get_resources(service, (options) null))[0];

    public static l3param get(nitro_service service, options option) => ((l3param[]) new l3param().get_resources(service, option))[0];

    private class l3param_response : base_response
    {
      public l3param l3param = (l3param) null;
    }

    public static class icmperrgenerateEnum
    {
      public const string ENABLED = "ENABLED";
      public const string DISABLED = "DISABLED";
    }

    public static class dropipfragmentsEnum
    {
      public const string ENABLED = "ENABLED";
      public const string DISABLED = "DISABLED";
    }

    public static class overridernatEnum
    {
      public const string ENABLED = "ENABLED";
      public const string DISABLED = "DISABLED";
    }

    public static class tnlpmtuwoconnEnum
    {
      public const string ENABLED = "ENABLED";
      public const string DISABLED = "DISABLED";
    }

    public static class usipserverstraypktEnum
    {
      public const string ENABLED = "ENABLED";
      public const string DISABLED = "DISABLED";
    }

    public static class srcnatEnum
    {
      public const string ENABLED = "ENABLED";
      public const string DISABLED = "DISABLED";
    }

    public static class implicitaclallowEnum
    {
      public const string ENABLED = "ENABLED";
      public const string DISABLED = "DISABLED";
    }

    public static class dynamicroutingEnum
    {
      public const string ENABLED = "ENABLED";
      public const string DISABLED = "DISABLED";
    }

    public static class externalloopbackEnum
    {
      public const string ENABLED = "ENABLED";
      public const string DISABLED = "DISABLED";
    }

    public static class forwardicmpfragmentsEnum
    {
      public const string ENABLED = "ENABLED";
      public const string DISABLED = "DISABLED";
    }

    public static class dropdfflagEnum
    {
      public const string ENABLED = "ENABLED";
      public const string DISABLED = "DISABLED";
    }

    public static class overridelsnEnum
    {
      public const string ENABLED = "ENABLED";
      public const string DISABLED = "DISABLED";
    }

    public static class miproundrobinEnum
    {
      public const string ENABLED = "ENABLED";
      public const string DISABLED = "DISABLED";
    }
  }
}
