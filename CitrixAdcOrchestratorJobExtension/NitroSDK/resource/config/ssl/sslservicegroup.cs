// Decompiled with JetBrains decompiler
// Type: com.citrix.netscaler.nitro.resource.config.ssl.sslservicegroup
// Assembly: nitro, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 6CF5DDEF-E052-4F9D-953F-6644F8378A66


using com.citrix.netscaler.nitro.exception;
using com.citrix.netscaler.nitro.resource.Base;
using com.citrix.netscaler.nitro.service;
using com.citrix.netscaler.nitro.util;

namespace com.citrix.netscaler.nitro.resource.config.ssl
{
  public class sslservicegroup : base_resource
  {
    private string servicegroupnameField = (string) null;
    private string sslprofileField = (string) null;
    private string sessreuseField = (string) null;
    private uint? sesstimeoutField = new uint?();
    private string nonfipsciphersField = (string) null;
    private string ssl3Field = (string) null;
    private string tls1Field = (string) null;
    private string tls11Field = (string) null;
    private string tls12Field = (string) null;
    private string serverauthField = (string) null;
    private string commonnameField = (string) null;
    private string sendclosenotifyField = (string) null;
    private bool? cipherdetailsField = new bool?();
    private string dhField = (string) null;
    private string dhfileField = (string) null;
    private uint? dhcountField = new uint?();
    private string dhkeyexpsizelimitField = (string) null;
    private string ersaField = (string) null;
    private uint? ersacountField = new uint?();
    private string cipherredirectField = (string) null;
    private string cipherurlField = (string) null;
    private string sslv2redirectField = (string) null;
    private string sslv2urlField = (string) null;
    private string clientauthField = (string) null;
    private string clientcertField = (string) null;
    private string sslredirectField = (string) null;
    private string redirectportrewriteField = (string) null;
    private string ssl2Field = (string) null;
    private string ocspcheckField = (string) null;
    private string crlcheckField = (string) null;
    private ushort? cleartextportField = new ushort?();
    private string servicenameField = (string) null;
    private bool? caField = new bool?();
    private bool? snicertField = new bool?();
    private uint? __countField = new uint?();

    public uint? __count
    {
      get => this.__countField;
      private set => this.__countField = value;
    }

    public string servicegroupname
    {
      get => this.servicegroupnameField;
      set => this.servicegroupnameField = value;
    }

    public string sslprofile
    {
      get => this.sslprofileField;
      set => this.sslprofileField = value;
    }

    public string sessreuse
    {
      get => this.sessreuseField;
      set => this.sessreuseField = value;
    }

    public uint? sesstimeout
    {
      get => this.sesstimeoutField;
      set => this.sesstimeoutField = value;
    }

    public string nonfipsciphers
    {
      get => this.nonfipsciphersField;
      set => this.nonfipsciphersField = value;
    }

    public string ssl3
    {
      get => this.ssl3Field;
      set => this.ssl3Field = value;
    }

    public string tls1
    {
      get => this.tls1Field;
      set => this.tls1Field = value;
    }

    public string tls11
    {
      get => this.tls11Field;
      set => this.tls11Field = value;
    }

    public string tls12
    {
      get => this.tls12Field;
      set => this.tls12Field = value;
    }

    public string serverauth
    {
      get => this.serverauthField;
      set => this.serverauthField = value;
    }

    public string commonname
    {
      get => this.commonnameField;
      set => this.commonnameField = value;
    }

    public string sendclosenotify
    {
      get => this.sendclosenotifyField;
      set => this.sendclosenotifyField = value;
    }

    public bool? cipherdetails
    {
      get => this.cipherdetailsField;
      set => this.cipherdetailsField = value;
    }

    public string dh
    {
      get => this.dhField;
      private set => this.dhField = value;
    }

    public string dhfile
    {
      get => this.dhfileField;
      private set => this.dhfileField = value;
    }

    public uint? dhcount
    {
      get => this.dhcountField;
      private set => this.dhcountField = value;
    }

    public string dhkeyexpsizelimit
    {
      get => this.dhkeyexpsizelimitField;
      private set => this.dhkeyexpsizelimitField = value;
    }

    public string ersa
    {
      get => this.ersaField;
      private set => this.ersaField = value;
    }

    public uint? ersacount
    {
      get => this.ersacountField;
      private set => this.ersacountField = value;
    }

    public string cipherredirect
    {
      get => this.cipherredirectField;
      private set => this.cipherredirectField = value;
    }

    public string cipherurl
    {
      get => this.cipherurlField;
      private set => this.cipherurlField = value;
    }

    public string sslv2redirect
    {
      get => this.sslv2redirectField;
      private set => this.sslv2redirectField = value;
    }

    public string sslv2url
    {
      get => this.sslv2urlField;
      private set => this.sslv2urlField = value;
    }

    public string clientauth
    {
      get => this.clientauthField;
      private set => this.clientauthField = value;
    }

    public string clientcert
    {
      get => this.clientcertField;
      private set => this.clientcertField = value;
    }

    public string sslredirect
    {
      get => this.sslredirectField;
      private set => this.sslredirectField = value;
    }

    public string redirectportrewrite
    {
      get => this.redirectportrewriteField;
      private set => this.redirectportrewriteField = value;
    }

    public string ssl2
    {
      get => this.ssl2Field;
      private set => this.ssl2Field = value;
    }

    public string ocspcheck
    {
      get => this.ocspcheckField;
      private set => this.ocspcheckField = value;
    }

    public string crlcheck
    {
      get => this.crlcheckField;
      private set => this.crlcheckField = value;
    }

    public ushort? cleartextport
    {
      get => this.cleartextportField;
      private set => this.cleartextportField = value;
    }

    public string servicename
    {
      get => this.servicenameField;
      private set => this.servicenameField = value;
    }

    public bool? ca
    {
      get => this.caField;
      private set => this.caField = value;
    }

    public bool? snicert
    {
      get => this.snicertField;
      private set => this.snicertField = value;
    }

    internal override base_resource[] get_nitro_response(
      nitro_service service,
      string response)
    {
      sslservicegroup.sslservicegroup_response sslservicegroupResponse = new sslservicegroup.sslservicegroup_response();
      sslservicegroup.sslservicegroup_response resource = (sslservicegroup.sslservicegroup_response) service.get_payload_formatter().string_to_resource(sslservicegroupResponse.GetType(), response);
      if (resource.errorcode != 0)
      {
        if (resource.errorcode == 444)
          service.clear_session();
        if (resource.severity == null)
          throw new nitro_exception(resource.message, resource.errorcode);
        if (resource.severity.Equals("ERROR"))
          throw new nitro_exception(resource.message, resource.errorcode);
      }
      return (base_resource[]) resource.sslservicegroup;
    }

    internal override string get_object_name() => this.servicegroupname;

    public static base_response update(nitro_service client, sslservicegroup resource) => new sslservicegroup()
    {
      servicegroupname = resource.servicegroupname,
      sslprofile = resource.sslprofile,
      sessreuse = resource.sessreuse,
      sesstimeout = resource.sesstimeout,
      nonfipsciphers = resource.nonfipsciphers,
      ssl3 = resource.ssl3,
      tls1 = resource.tls1,
      tls11 = resource.tls11,
      tls12 = resource.tls12,
      serverauth = resource.serverauth,
      commonname = resource.commonname,
      sendclosenotify = resource.sendclosenotify
    }.update_resource(client);

    public static base_responses update(
      nitro_service client,
      sslservicegroup[] resources)
    {
      base_responses baseResponses = (base_responses) null;
      if (resources != null && resources.Length > 0)
      {
        sslservicegroup[] sslservicegroupArray = new sslservicegroup[resources.Length];
        for (int index = 0; index < resources.Length; ++index)
        {
          sslservicegroupArray[index] = new sslservicegroup();
          sslservicegroupArray[index].servicegroupname = resources[index].servicegroupname;
          sslservicegroupArray[index].sslprofile = resources[index].sslprofile;
          sslservicegroupArray[index].sessreuse = resources[index].sessreuse;
          sslservicegroupArray[index].sesstimeout = resources[index].sesstimeout;
          sslservicegroupArray[index].nonfipsciphers = resources[index].nonfipsciphers;
          sslservicegroupArray[index].ssl3 = resources[index].ssl3;
          sslservicegroupArray[index].tls1 = resources[index].tls1;
          sslservicegroupArray[index].tls11 = resources[index].tls11;
          sslservicegroupArray[index].tls12 = resources[index].tls12;
          sslservicegroupArray[index].serverauth = resources[index].serverauth;
          sslservicegroupArray[index].commonname = resources[index].commonname;
          sslservicegroupArray[index].sendclosenotify = resources[index].sendclosenotify;
        }
        baseResponses = base_resource.update_bulk_request(client, (base_resource[]) sslservicegroupArray);
      }
      return baseResponses;
    }

    public static base_response unset(
      nitro_service client,
      string servicegroupname,
      string[] args)
    {
      return new sslservicegroup()
      {
        servicegroupname = servicegroupname
      }.unset_resource(client, args);
    }

    public static base_response unset(
      nitro_service client,
      sslservicegroup resource,
      string[] args)
    {
      return new sslservicegroup()
      {
        servicegroupname = resource.servicegroupname
      }.unset_resource(client, args);
    }

    public static base_responses unset(
      nitro_service client,
      string[] servicegroupname,
      string[] args)
    {
      base_responses baseResponses = (base_responses) null;
      if (servicegroupname != null && servicegroupname.Length > 0)
      {
        sslservicegroup[] sslservicegroupArray = new sslservicegroup[servicegroupname.Length];
        for (int index = 0; index < servicegroupname.Length; ++index)
        {
          sslservicegroupArray[index] = new sslservicegroup();
          sslservicegroupArray[index].servicegroupname = servicegroupname[index];
        }
        baseResponses = base_resource.unset_bulk_request(client, (base_resource[]) sslservicegroupArray, args);
      }
      return baseResponses;
    }

    public static base_responses unset(
      nitro_service client,
      sslservicegroup[] resources,
      string[] args)
    {
      base_responses baseResponses = (base_responses) null;
      if (resources != null && resources.Length > 0)
      {
        sslservicegroup[] sslservicegroupArray = new sslservicegroup[resources.Length];
        for (int index = 0; index < resources.Length; ++index)
        {
          sslservicegroupArray[index] = new sslservicegroup();
          sslservicegroupArray[index].servicegroupname = resources[index].servicegroupname;
        }
        baseResponses = base_resource.unset_bulk_request(client, (base_resource[]) sslservicegroupArray, args);
      }
      return baseResponses;
    }

    public static sslservicegroup[] get(nitro_service service) => (sslservicegroup[]) new sslservicegroup().get_resources(service, (options) null);

    public static sslservicegroup[] get(nitro_service service, options option) => (sslservicegroup[]) new sslservicegroup().get_resources(service, option);

    public static sslservicegroup[] get(
      nitro_service service,
      sslservicegroup_args args)
    {
      sslservicegroup sslservicegroup = new sslservicegroup();
      options option = new options();
      option.set_args(nitro_util.object_to_string_withoutquotes((object) args));
      return (sslservicegroup[]) sslservicegroup.get_resources(service, option);
    }

    public static sslservicegroup get(nitro_service service, string servicegroupname) => (sslservicegroup) new sslservicegroup()
    {
      servicegroupname = servicegroupname
    }.get_resource(service);

    public static sslservicegroup[] get(
      nitro_service service,
      string[] servicegroupname)
    {
      if (servicegroupname == null || servicegroupname.Length <= 0)
        return (sslservicegroup[]) null;
      sslservicegroup[] sslservicegroupArray1 = new sslservicegroup[servicegroupname.Length];
      sslservicegroup[] sslservicegroupArray2 = new sslservicegroup[servicegroupname.Length];
      for (int index = 0; index < servicegroupname.Length; ++index)
      {
        sslservicegroupArray2[index] = new sslservicegroup();
        sslservicegroupArray2[index].servicegroupname = servicegroupname[index];
        sslservicegroupArray1[index] = (sslservicegroup) sslservicegroupArray2[index].get_resource(service);
      }
      return sslservicegroupArray1;
    }

    public static sslservicegroup[] get_filtered(
      nitro_service service,
      string filter)
    {
      sslservicegroup sslservicegroup = new sslservicegroup();
      options option = new options();
      option.set_filter(filter);
      return (sslservicegroup[]) sslservicegroup.getfiltered(service, option);
    }

    public static sslservicegroup[] get_filtered(
      nitro_service service,
      filtervalue[] filter)
    {
      sslservicegroup sslservicegroup = new sslservicegroup();
      options option = new options();
      option.set_filter(filter);
      return (sslservicegroup[]) sslservicegroup.getfiltered(service, option);
    }

    public static uint count(nitro_service service)
    {
      sslservicegroup sslservicegroup = new sslservicegroup();
      options option = new options();
      option.set_count(true);
      sslservicegroup[] resources = (sslservicegroup[]) sslservicegroup.get_resources(service, option);
      return resources != null && resources.Length > 0 ? resources[0].__count.Value : 0U;
    }

    public static uint count_filtered(nitro_service service, string filter)
    {
      sslservicegroup sslservicegroup = new sslservicegroup();
      options option = new options();
      option.set_count(true);
      option.set_filter(filter);
      sslservicegroup[] sslservicegroupArray = (sslservicegroup[]) sslservicegroup.getfiltered(service, option);
      return sslservicegroupArray != null && sslservicegroupArray.Length > 0 ? sslservicegroupArray[0].__count.Value : 0U;
    }

    public static uint count_filtered(nitro_service service, filtervalue[] filter)
    {
      sslservicegroup sslservicegroup = new sslservicegroup();
      options option = new options();
      option.set_count(true);
      option.set_filter(filter);
      sslservicegroup[] sslservicegroupArray = (sslservicegroup[]) sslservicegroup.getfiltered(service, option);
      return sslservicegroupArray != null && sslservicegroupArray.Length > 0 ? sslservicegroupArray[0].__count.Value : 0U;
    }

    private class sslservicegroup_response : base_response
    {
      public sslservicegroup[] sslservicegroup = (sslservicegroup[]) null;
    }

    public static class sslredirectEnum
    {
      public const string ENABLED = "ENABLED";
      public const string DISABLED = "DISABLED";
    }

    public static class ersaEnum
    {
      public const string ENABLED = "ENABLED";
      public const string DISABLED = "DISABLED";
    }

    public static class redirectportrewriteEnum
    {
      public const string ENABLED = "ENABLED";
      public const string DISABLED = "DISABLED";
    }

    public static class sessreuseEnum
    {
      public const string ENABLED = "ENABLED";
      public const string DISABLED = "DISABLED";
    }

    public static class ssl3Enum
    {
      public const string ENABLED = "ENABLED";
      public const string DISABLED = "DISABLED";
    }

    public static class tls1Enum
    {
      public const string ENABLED = "ENABLED";
      public const string DISABLED = "DISABLED";
    }

    public static class sslv2redirectEnum
    {
      public const string ENABLED = "ENABLED";
      public const string DISABLED = "DISABLED";
    }

    public static class sendclosenotifyEnum
    {
      public const string YES = "YES";
      public const string NO = "NO";
    }

    public static class tls11Enum
    {
      public const string ENABLED = "ENABLED";
      public const string DISABLED = "DISABLED";
    }

    public static class dhEnum
    {
      public const string ENABLED = "ENABLED";
      public const string DISABLED = "DISABLED";
    }

    public static class tls12Enum
    {
      public const string ENABLED = "ENABLED";
      public const string DISABLED = "DISABLED";
    }

    public static class serverauthEnum
    {
      public const string ENABLED = "ENABLED";
      public const string DISABLED = "DISABLED";
    }

    public static class nonfipsciphersEnum
    {
      public const string ENABLED = "ENABLED";
      public const string DISABLED = "DISABLED";
    }

    public static class cipherredirectEnum
    {
      public const string ENABLED = "ENABLED";
      public const string DISABLED = "DISABLED";
    }

    public static class clientcertEnum
    {
      public const string Mandatory = "Mandatory";
      public const string Optional = "Optional";
    }

    public static class dhkeyexpsizelimitEnum
    {
      public const string ENABLED = "ENABLED";
      public const string DISABLED = "DISABLED";
    }

    public static class crlcheckEnum
    {
      public const string Mandatory = "Mandatory";
      public const string Optional = "Optional";
    }

    public static class clientauthEnum
    {
      public const string ENABLED = "ENABLED";
      public const string DISABLED = "DISABLED";
    }

    public static class ssl2Enum
    {
      public const string ENABLED = "ENABLED";
      public const string DISABLED = "DISABLED";
    }

    public static class ocspcheckEnum
    {
      public const string Mandatory = "Mandatory";
      public const string Optional = "Optional";
    }
  }
}
