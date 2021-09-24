// Decompiled with JetBrains decompiler
// Type: com.citrix.netscaler.nitro.resource.config.subscriber.subscriberparam
// Assembly: nitro, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 6CF5DDEF-E052-4F9D-953F-6644F8378A66


using com.citrix.netscaler.nitro.exception;
using com.citrix.netscaler.nitro.resource.Base;
using com.citrix.netscaler.nitro.service;

namespace com.citrix.netscaler.nitro.resource.config.subscriber
{
  public class subscriberparam : base_resource
  {
    private string keytypeField = (string) null;
    private string interfacetypeField = (string) null;
    private uint? idlettlField = new uint?();
    private string idleactionField = (string) null;
    private uint?[] ipv6prefixlookuplistField = (uint?[]) null;
    private string[] builtinField = (string[]) null;

    public string keytype
    {
      get => this.keytypeField;
      set => this.keytypeField = value;
    }

    public string interfacetype
    {
      get => this.interfacetypeField;
      set => this.interfacetypeField = value;
    }

    public uint? idlettl
    {
      get => this.idlettlField;
      set => this.idlettlField = value;
    }

    public string idleaction
    {
      get => this.idleactionField;
      set => this.idleactionField = value;
    }

    public uint?[] ipv6prefixlookuplist
    {
      get => this.ipv6prefixlookuplistField;
      set => this.ipv6prefixlookuplistField = value;
    }

    public string[] builtin
    {
      get => this.builtinField;
      private set => this.builtinField = value;
    }

    internal override base_resource[] get_nitro_response(
      nitro_service service,
      string response)
    {
      subscriberparam[] subscriberparamArray = new subscriberparam[1];
      subscriberparam.subscriberparam_response subscriberparamResponse = new subscriberparam.subscriberparam_response();
      subscriberparam.subscriberparam_response resource = (subscriberparam.subscriberparam_response) service.get_payload_formatter().string_to_resource(subscriberparamResponse.GetType(), response);
      if (resource.errorcode != 0)
      {
        if (resource.errorcode == 444)
          service.clear_session();
        if (resource.severity == null)
          throw new nitro_exception(resource.message, resource.errorcode);
        if (resource.severity.Equals("ERROR"))
          throw new nitro_exception(resource.message, resource.errorcode);
      }
      subscriberparamArray[0] = resource.subscriberparam;
      return (base_resource[]) subscriberparamArray;
    }

    internal override string get_object_name() => (string) null;

    public static base_response update(nitro_service client, subscriberparam resource) => new subscriberparam()
    {
      keytype = resource.keytype,
      interfacetype = resource.interfacetype,
      idlettl = resource.idlettl,
      idleaction = resource.idleaction,
      ipv6prefixlookuplist = resource.ipv6prefixlookuplist
    }.update_resource(client);

    public static base_response unset(
      nitro_service client,
      subscriberparam resource,
      string[] args)
    {
      return new subscriberparam().unset_resource(client, args);
    }

    public static subscriberparam get(nitro_service service) => ((subscriberparam[]) new subscriberparam().get_resources(service, (options) null))[0];

    public static subscriberparam get(nitro_service service, options option) => ((subscriberparam[]) new subscriberparam().get_resources(service, option))[0];

    private class subscriberparam_response : base_response
    {
      public subscriberparam subscriberparam = (subscriberparam) null;
    }

    public static class interfacetypeEnum
    {
      public const string None = "None";
      public const string RadiusOnly = "RadiusOnly";
      public const string RadiusAndGx = "RadiusAndGx";
      public const string GxOnly = "GxOnly";
    }

    public static class builtinEnum
    {
      public const string MODIFIABLE = "MODIFIABLE";
      public const string DELETABLE = "DELETABLE";
      public const string IMMUTABLE = "IMMUTABLE";
      public const string PARTITION_ALL = "PARTITION_ALL";
    }

    public static class keytypeEnum
    {
      public const string IP = "IP";
    }

    public static class idleactionEnum
    {
      public const string ccrTerminate = "ccrTerminate";
      public const string delete = "delete";
      public const string ccrUpdate = "ccrUpdate";
    }
  }
}
