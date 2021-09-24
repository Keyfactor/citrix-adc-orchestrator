// Decompiled with JetBrains decompiler
// Type: com.citrix.netscaler.nitro.resource.config.ssl.sslservice
// Assembly: nitro, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 6CF5DDEF-E052-4F9D-953F-6644F8378A66


using com.citrix.netscaler.nitro.exception;
using com.citrix.netscaler.nitro.resource.Base;
using com.citrix.netscaler.nitro.service;
using com.citrix.netscaler.nitro.util;

namespace com.citrix.netscaler.nitro.resource.config.ssl
{
  public class sslservice : base_resource
  {
    private string servicenameField = (string) null;
    private string dhField = (string) null;
    private string dhfileField = (string) null;
    private uint? dhcountField = new uint?();
    private string dhkeyexpsizelimitField = (string) null;
    private string ersaField = (string) null;
    private uint? ersacountField = new uint?();
    private string sessreuseField = (string) null;
    private uint? sesstimeoutField = new uint?();
    private string cipherredirectField = (string) null;
    private string cipherurlField = (string) null;
    private string sslv2redirectField = (string) null;
    private string sslv2urlField = (string) null;
    private string clientauthField = (string) null;
    private string clientcertField = (string) null;
    private string sslredirectField = (string) null;
    private string redirectportrewriteField = (string) null;
    private string nonfipsciphersField = (string) null;
    private string ssl2Field = (string) null;
    private string ssl3Field = (string) null;
    private string tls1Field = (string) null;
    private string tls11Field = (string) null;
    private string tls12Field = (string) null;
    private string snienableField = (string) null;
    private string serverauthField = (string) null;
    private string commonnameField = (string) null;
    private string pushenctriggerField = (string) null;
    private string sendclosenotifyField = (string) null;
    private string dtlsprofilenameField = (string) null;
    private string sslprofileField = (string) null;
    private bool? cipherdetailsField = new bool?();
    private uint? serviceField = new uint?();
    private bool? skipcanameField = new bool?();
    private bool? dtlsflagField = new bool?();
    private uint? __countField = new uint?();

    public uint? __count
    {
      get => this.__countField;
      private set => this.__countField = value;
    }

    public string servicename
    {
      get => this.servicenameField;
      set => this.servicenameField = value;
    }

    public string dh
    {
      get => this.dhField;
      set => this.dhField = value;
    }

    public string dhfile
    {
      get => this.dhfileField;
      set => this.dhfileField = value;
    }

    public uint? dhcount
    {
      get => this.dhcountField;
      set => this.dhcountField = value;
    }

    public string dhkeyexpsizelimit
    {
      get => this.dhkeyexpsizelimitField;
      set => this.dhkeyexpsizelimitField = value;
    }

    public string ersa
    {
      get => this.ersaField;
      set => this.ersaField = value;
    }

    public uint? ersacount
    {
      get => this.ersacountField;
      set => this.ersacountField = value;
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

    public string cipherredirect
    {
      get => this.cipherredirectField;
      set => this.cipherredirectField = value;
    }

    public string cipherurl
    {
      get => this.cipherurlField;
      set => this.cipherurlField = value;
    }

    public string sslv2redirect
    {
      get => this.sslv2redirectField;
      set => this.sslv2redirectField = value;
    }

    public string sslv2url
    {
      get => this.sslv2urlField;
      set => this.sslv2urlField = value;
    }

    public string clientauth
    {
      get => this.clientauthField;
      set => this.clientauthField = value;
    }

    public string clientcert
    {
      get => this.clientcertField;
      set => this.clientcertField = value;
    }

    public string sslredirect
    {
      get => this.sslredirectField;
      set => this.sslredirectField = value;
    }

    public string redirectportrewrite
    {
      get => this.redirectportrewriteField;
      set => this.redirectportrewriteField = value;
    }

    public string nonfipsciphers
    {
      get => this.nonfipsciphersField;
      set => this.nonfipsciphersField = value;
    }

    public string ssl2
    {
      get => this.ssl2Field;
      set => this.ssl2Field = value;
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

    public string snienable
    {
      get => this.snienableField;
      set => this.snienableField = value;
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

    public string pushenctrigger
    {
      get => this.pushenctriggerField;
      set => this.pushenctriggerField = value;
    }

    public string sendclosenotify
    {
      get => this.sendclosenotifyField;
      set => this.sendclosenotifyField = value;
    }

    public string dtlsprofilename
    {
      get => this.dtlsprofilenameField;
      set => this.dtlsprofilenameField = value;
    }

    public string sslprofile
    {
      get => this.sslprofileField;
      set => this.sslprofileField = value;
    }

    public bool? cipherdetails
    {
      get => this.cipherdetailsField;
      set => this.cipherdetailsField = value;
    }

    public uint? service
    {
      get => this.serviceField;
      private set => this.serviceField = value;
    }

    public bool? skipcaname
    {
      get => this.skipcanameField;
      private set => this.skipcanameField = value;
    }

    public bool? dtlsflag
    {
      get => this.dtlsflagField;
      private set => this.dtlsflagField = value;
    }

    internal override base_resource[] get_nitro_response(
      nitro_service service,
      string response)
    {
      sslservice.sslservice_response sslserviceResponse = new sslservice.sslservice_response();
      sslservice.sslservice_response resource = (sslservice.sslservice_response) service.get_payload_formatter().string_to_resource(sslserviceResponse.GetType(), response);
      if (resource.errorcode != 0)
      {
        if (resource.errorcode == 444)
          service.clear_session();
        if (resource.severity == null)
          throw new nitro_exception(resource.message, resource.errorcode);
        if (resource.severity.Equals("ERROR"))
          throw new nitro_exception(resource.message, resource.errorcode);
      }
      return (base_resource[]) resource.sslservice;
    }

    internal override string get_object_name() => this.servicename;

    public static base_response update(nitro_service client, sslservice resource) => new sslservice()
    {
      servicename = resource.servicename,
      dh = resource.dh,
      dhfile = resource.dhfile,
      dhcount = resource.dhcount,
      dhkeyexpsizelimit = resource.dhkeyexpsizelimit,
      ersa = resource.ersa,
      ersacount = resource.ersacount,
      sessreuse = resource.sessreuse,
      sesstimeout = resource.sesstimeout,
      cipherredirect = resource.cipherredirect,
      cipherurl = resource.cipherurl,
      sslv2redirect = resource.sslv2redirect,
      sslv2url = resource.sslv2url,
      clientauth = resource.clientauth,
      clientcert = resource.clientcert,
      sslredirect = resource.sslredirect,
      redirectportrewrite = resource.redirectportrewrite,
      nonfipsciphers = resource.nonfipsciphers,
      ssl2 = resource.ssl2,
      ssl3 = resource.ssl3,
      tls1 = resource.tls1,
      tls11 = resource.tls11,
      tls12 = resource.tls12,
      snienable = resource.snienable,
      serverauth = resource.serverauth,
      commonname = resource.commonname,
      pushenctrigger = resource.pushenctrigger,
      sendclosenotify = resource.sendclosenotify,
      dtlsprofilename = resource.dtlsprofilename,
      sslprofile = resource.sslprofile
    }.update_resource(client);

    public static base_responses update(nitro_service client, sslservice[] resources)
    {
      base_responses baseResponses = (base_responses) null;
      if (resources != null && resources.Length > 0)
      {
        sslservice[] sslserviceArray = new sslservice[resources.Length];
        for (int index = 0; index < resources.Length; ++index)
        {
          sslserviceArray[index] = new sslservice();
          sslserviceArray[index].servicename = resources[index].servicename;
          sslserviceArray[index].dh = resources[index].dh;
          sslserviceArray[index].dhfile = resources[index].dhfile;
          sslserviceArray[index].dhcount = resources[index].dhcount;
          sslserviceArray[index].dhkeyexpsizelimit = resources[index].dhkeyexpsizelimit;
          sslserviceArray[index].ersa = resources[index].ersa;
          sslserviceArray[index].ersacount = resources[index].ersacount;
          sslserviceArray[index].sessreuse = resources[index].sessreuse;
          sslserviceArray[index].sesstimeout = resources[index].sesstimeout;
          sslserviceArray[index].cipherredirect = resources[index].cipherredirect;
          sslserviceArray[index].cipherurl = resources[index].cipherurl;
          sslserviceArray[index].sslv2redirect = resources[index].sslv2redirect;
          sslserviceArray[index].sslv2url = resources[index].sslv2url;
          sslserviceArray[index].clientauth = resources[index].clientauth;
          sslserviceArray[index].clientcert = resources[index].clientcert;
          sslserviceArray[index].sslredirect = resources[index].sslredirect;
          sslserviceArray[index].redirectportrewrite = resources[index].redirectportrewrite;
          sslserviceArray[index].nonfipsciphers = resources[index].nonfipsciphers;
          sslserviceArray[index].ssl2 = resources[index].ssl2;
          sslserviceArray[index].ssl3 = resources[index].ssl3;
          sslserviceArray[index].tls1 = resources[index].tls1;
          sslserviceArray[index].tls11 = resources[index].tls11;
          sslserviceArray[index].tls12 = resources[index].tls12;
          sslserviceArray[index].snienable = resources[index].snienable;
          sslserviceArray[index].serverauth = resources[index].serverauth;
          sslserviceArray[index].commonname = resources[index].commonname;
          sslserviceArray[index].pushenctrigger = resources[index].pushenctrigger;
          sslserviceArray[index].sendclosenotify = resources[index].sendclosenotify;
          sslserviceArray[index].dtlsprofilename = resources[index].dtlsprofilename;
          sslserviceArray[index].sslprofile = resources[index].sslprofile;
        }
        baseResponses = base_resource.update_bulk_request(client, (base_resource[]) sslserviceArray);
      }
      return baseResponses;
    }

    public static base_response unset(
      nitro_service client,
      string servicename,
      string[] args)
    {
      return new sslservice() { servicename = servicename }.unset_resource(client, args);
    }

    public static base_response unset(
      nitro_service client,
      sslservice resource,
      string[] args)
    {
      return new sslservice()
      {
        servicename = resource.servicename
      }.unset_resource(client, args);
    }

    public static base_responses unset(
      nitro_service client,
      string[] servicename,
      string[] args)
    {
      base_responses baseResponses = (base_responses) null;
      if (servicename != null && servicename.Length > 0)
      {
        sslservice[] sslserviceArray = new sslservice[servicename.Length];
        for (int index = 0; index < servicename.Length; ++index)
        {
          sslserviceArray[index] = new sslservice();
          sslserviceArray[index].servicename = servicename[index];
        }
        baseResponses = base_resource.unset_bulk_request(client, (base_resource[]) sslserviceArray, args);
      }
      return baseResponses;
    }

    public static base_responses unset(
      nitro_service client,
      sslservice[] resources,
      string[] args)
    {
      base_responses baseResponses = (base_responses) null;
      if (resources != null && resources.Length > 0)
      {
        sslservice[] sslserviceArray = new sslservice[resources.Length];
        for (int index = 0; index < resources.Length; ++index)
        {
          sslserviceArray[index] = new sslservice();
          sslserviceArray[index].servicename = resources[index].servicename;
        }
        baseResponses = base_resource.unset_bulk_request(client, (base_resource[]) sslserviceArray, args);
      }
      return baseResponses;
    }

    public static sslservice[] get(nitro_service service) => (sslservice[]) new sslservice().get_resources(service, (options) null);

    public static sslservice[] get(nitro_service service, options option) => (sslservice[]) new sslservice().get_resources(service, option);

    public static sslservice[] get(nitro_service service, sslservice_args args)
    {
      sslservice sslservice = new sslservice();
      options option = new options();
      option.set_args(nitro_util.object_to_string_withoutquotes((object) args));
      return (sslservice[]) sslservice.get_resources(service, option);
    }

    public static sslservice get(nitro_service service, string servicename) => (sslservice) new sslservice()
    {
      servicename = servicename
    }.get_resource(service);

    public static sslservice[] get(nitro_service service, string[] servicename)
    {
      if (servicename == null || servicename.Length <= 0)
        return (sslservice[]) null;
      sslservice[] sslserviceArray1 = new sslservice[servicename.Length];
      sslservice[] sslserviceArray2 = new sslservice[servicename.Length];
      for (int index = 0; index < servicename.Length; ++index)
      {
        sslserviceArray2[index] = new sslservice();
        sslserviceArray2[index].servicename = servicename[index];
        sslserviceArray1[index] = (sslservice) sslserviceArray2[index].get_resource(service);
      }
      return sslserviceArray1;
    }

    public static sslservice[] get_filtered(nitro_service service, string filter)
    {
      sslservice sslservice = new sslservice();
      options option = new options();
      option.set_filter(filter);
      return (sslservice[]) sslservice.getfiltered(service, option);
    }

    public static sslservice[] get_filtered(nitro_service service, filtervalue[] filter)
    {
      sslservice sslservice = new sslservice();
      options option = new options();
      option.set_filter(filter);
      return (sslservice[]) sslservice.getfiltered(service, option);
    }

    public static uint count(nitro_service service)
    {
      sslservice sslservice = new sslservice();
      options option = new options();
      option.set_count(true);
      sslservice[] resources = (sslservice[]) sslservice.get_resources(service, option);
      return resources != null && resources.Length > 0 ? resources[0].__count.Value : 0U;
    }

    public static uint count_filtered(nitro_service service, string filter)
    {
      sslservice sslservice = new sslservice();
      options option = new options();
      option.set_count(true);
      option.set_filter(filter);
      sslservice[] sslserviceArray = (sslservice[]) sslservice.getfiltered(service, option);
      return sslserviceArray != null && sslserviceArray.Length > 0 ? sslserviceArray[0].__count.Value : 0U;
    }

    public static uint count_filtered(nitro_service service, filtervalue[] filter)
    {
      sslservice sslservice = new sslservice();
      options option = new options();
      option.set_count(true);
      option.set_filter(filter);
      sslservice[] sslserviceArray = (sslservice[]) sslservice.getfiltered(service, option);
      return sslserviceArray != null && sslserviceArray.Length > 0 ? sslserviceArray[0].__count.Value : 0U;
    }

    private class sslservice_response : base_response
    {
      public sslservice[] sslservice = (sslservice[]) null;
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

    public static class snienableEnum
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

    public static class pushenctriggerEnum
    {
      public const string Always = "Always";
      public const string Merge = "Merge";
      public const string Ignore = "Ignore";
      public const string Timer = "Timer";
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
  }
}
