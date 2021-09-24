// Decompiled with JetBrains decompiler
// Type: com.citrix.netscaler.nitro.resource.config.utility.callhome
// Assembly: nitro, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 6CF5DDEF-E052-4F9D-953F-6644F8378A66


using com.citrix.netscaler.nitro.exception;
using com.citrix.netscaler.nitro.resource.Base;
using com.citrix.netscaler.nitro.service;

namespace com.citrix.netscaler.nitro.resource.config.utility
{
  public class callhome : base_resource
  {
    private string emailaddressField = (string) null;
    private string proxymodeField = (string) null;
    private string ipaddressField = (string) null;
    private ushort? portField = new ushort?();
    private string sslcardfirstfailureField = (string) null;
    private string sslcardlatestfailureField = (string) null;
    private string powfirstfailField = (string) null;
    private string powlatestfailureField = (string) null;
    private string hddfirstfailField = (string) null;
    private string hddlatestfailureField = (string) null;
    private string flashfirstfailField = (string) null;
    private string flashlatestfailureField = (string) null;
    private string restartlatestfailField = (string) null;
    private string[] callhomestatusField = (string[]) null;

    public string emailaddress
    {
      get => this.emailaddressField;
      set => this.emailaddressField = value;
    }

    public string proxymode
    {
      get => this.proxymodeField;
      set => this.proxymodeField = value;
    }

    public string ipaddress
    {
      get => this.ipaddressField;
      set => this.ipaddressField = value;
    }

    public ushort? port
    {
      get => this.portField;
      set => this.portField = value;
    }

    public string sslcardfirstfailure
    {
      get => this.sslcardfirstfailureField;
      private set => this.sslcardfirstfailureField = value;
    }

    public string sslcardlatestfailure
    {
      get => this.sslcardlatestfailureField;
      private set => this.sslcardlatestfailureField = value;
    }

    public string powfirstfail
    {
      get => this.powfirstfailField;
      private set => this.powfirstfailField = value;
    }

    public string powlatestfailure
    {
      get => this.powlatestfailureField;
      private set => this.powlatestfailureField = value;
    }

    public string hddfirstfail
    {
      get => this.hddfirstfailField;
      private set => this.hddfirstfailField = value;
    }

    public string hddlatestfailure
    {
      get => this.hddlatestfailureField;
      private set => this.hddlatestfailureField = value;
    }

    public string flashfirstfail
    {
      get => this.flashfirstfailField;
      private set => this.flashfirstfailField = value;
    }

    public string flashlatestfailure
    {
      get => this.flashlatestfailureField;
      private set => this.flashlatestfailureField = value;
    }

    public string restartlatestfail
    {
      get => this.restartlatestfailField;
      private set => this.restartlatestfailField = value;
    }

    public string[] callhomestatus
    {
      get => this.callhomestatusField;
      private set => this.callhomestatusField = value;
    }

    internal override base_resource[] get_nitro_response(
      nitro_service service,
      string response)
    {
      callhome[] callhomeArray = new callhome[1];
      callhome.callhome_response callhomeResponse = new callhome.callhome_response();
      callhome.callhome_response resource = (callhome.callhome_response) service.get_payload_formatter().string_to_resource(callhomeResponse.GetType(), response);
      if (resource.errorcode != 0)
      {
        if (resource.errorcode == 444)
          service.clear_session();
        if (resource.severity == null)
          throw new nitro_exception(resource.message, resource.errorcode);
        if (resource.severity.Equals("ERROR"))
          throw new nitro_exception(resource.message, resource.errorcode);
      }
      callhomeArray[0] = resource.callhome;
      return (base_resource[]) callhomeArray;
    }

    internal override string get_object_name() => (string) null;

    public static base_response update(nitro_service client, callhome resource) => new callhome()
    {
      emailaddress = resource.emailaddress,
      proxymode = resource.proxymode,
      ipaddress = resource.ipaddress,
      port = resource.port
    }.update_resource(client);

    public static base_response unset(
      nitro_service client,
      callhome resource,
      string[] args)
    {
      return new callhome().unset_resource(client, args);
    }

    public static callhome get(nitro_service service) => ((callhome[]) new callhome().get_resources(service, (options) null))[0];

    public static callhome get(nitro_service service, options option) => ((callhome[]) new callhome().get_resources(service, option))[0];

    private class callhome_response : base_response
    {
      public callhome callhome = (callhome) null;
    }

    public static class callhomestatusEnum
    {
      public const string ENABLED = "ENABLED";
      public const string DISABLED = "DISABLED";
      public const string SUCCESSFUL = "SUCCESSFUL";
      public const string FAILED = "FAILED";
    }

    public static class proxymodeEnum
    {
      public const string YES = "YES";
      public const string NO = "NO";
    }
  }
}
