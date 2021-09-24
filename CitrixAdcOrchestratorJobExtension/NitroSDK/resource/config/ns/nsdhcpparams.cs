// Decompiled with JetBrains decompiler
// Type: com.citrix.netscaler.nitro.resource.config.ns.nsdhcpparams
// Assembly: nitro, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 6CF5DDEF-E052-4F9D-953F-6644F8378A66


using com.citrix.netscaler.nitro.exception;
using com.citrix.netscaler.nitro.resource.Base;
using com.citrix.netscaler.nitro.service;

namespace com.citrix.netscaler.nitro.resource.config.ns
{
  public class nsdhcpparams : base_resource
  {
    private string dhcpclientField = (string) null;
    private string saverouteField = (string) null;
    private string ipaddressField = (string) null;
    private string netmaskField = (string) null;
    private string hostrtgwField = (string) null;
    private bool? runningField = new bool?();

    public string dhcpclient
    {
      get => this.dhcpclientField;
      set => this.dhcpclientField = value;
    }

    public string saveroute
    {
      get => this.saverouteField;
      set => this.saverouteField = value;
    }

    public string ipaddress
    {
      get => this.ipaddressField;
      private set => this.ipaddressField = value;
    }

    public string netmask
    {
      get => this.netmaskField;
      private set => this.netmaskField = value;
    }

    public string hostrtgw
    {
      get => this.hostrtgwField;
      private set => this.hostrtgwField = value;
    }

    public bool? running
    {
      get => this.runningField;
      private set => this.runningField = value;
    }

    internal override base_resource[] get_nitro_response(
      nitro_service service,
      string response)
    {
      nsdhcpparams[] nsdhcpparamsArray = new nsdhcpparams[1];
      nsdhcpparams.nsdhcpparams_response nsdhcpparamsResponse = new nsdhcpparams.nsdhcpparams_response();
      nsdhcpparams.nsdhcpparams_response resource = (nsdhcpparams.nsdhcpparams_response) service.get_payload_formatter().string_to_resource(nsdhcpparamsResponse.GetType(), response);
      if (resource.errorcode != 0)
      {
        if (resource.errorcode == 444)
          service.clear_session();
        if (resource.severity == null)
          throw new nitro_exception(resource.message, resource.errorcode);
        if (resource.severity.Equals("ERROR"))
          throw new nitro_exception(resource.message, resource.errorcode);
      }
      nsdhcpparamsArray[0] = resource.nsdhcpparams;
      return (base_resource[]) nsdhcpparamsArray;
    }

    internal override string get_object_name() => (string) null;

    public static base_response update(nitro_service client, nsdhcpparams resource) => new nsdhcpparams()
    {
      dhcpclient = resource.dhcpclient,
      saveroute = resource.saveroute
    }.update_resource(client);

    public static base_response unset(
      nitro_service client,
      nsdhcpparams resource,
      string[] args)
    {
      return new nsdhcpparams().unset_resource(client, args);
    }

    public static nsdhcpparams get(nitro_service service) => ((nsdhcpparams[]) new nsdhcpparams().get_resources(service, (options) null))[0];

    public static nsdhcpparams get(nitro_service service, options option) => ((nsdhcpparams[]) new nsdhcpparams().get_resources(service, option))[0];

    private class nsdhcpparams_response : base_response
    {
      public nsdhcpparams nsdhcpparams = (nsdhcpparams) null;
    }

    public static class dhcpclientEnum
    {
      public const string ON = "ON";
      public const string OFF = "OFF";
    }

    public static class saverouteEnum
    {
      public const string ON = "ON";
      public const string OFF = "OFF";
    }
  }
}
