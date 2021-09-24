// Decompiled with JetBrains decompiler
// Type: com.citrix.netscaler.nitro.resource.config.ssl.sslvserver
// Assembly: nitro, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 6CF5DDEF-E052-4F9D-953F-6644F8378A66


using com.citrix.netscaler.nitro.exception;
using com.citrix.netscaler.nitro.resource.Base;
using com.citrix.netscaler.nitro.service;
using com.citrix.netscaler.nitro.util;

namespace com.citrix.netscaler.nitro.resource.config.ssl
{
  public class sslvserver : base_resource
  {
    private string vservernameField = (string) null;
    private ushort? cleartextportField = new ushort?();
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
    private string pushenctriggerField = (string) null;
    private string sendclosenotifyField = (string) null;
    private string dtlsprofilenameField = (string) null;
    private string sslprofileField = (string) null;
    private bool? cipherdetailsField = new bool?();
    private string crlcheckField = (string) null;
    private uint? serviceField = new uint?();
    private string servicenameField = (string) null;
    private string ocspcheckField = (string) null;
    private bool? caField = new bool?();
    private bool? snicertField = new bool?();
    private bool? skipcanameField = new bool?();
    private bool? dtlsflagField = new bool?();
    private uint? __countField = new uint?();

    public uint? __count
    {
      get => this.__countField;
      private set => this.__countField = value;
    }

    public string vservername
    {
      get => this.vservernameField;
      set => this.vservernameField = value;
    }

    public ushort? cleartextport
    {
      get => this.cleartextportField;
      set => this.cleartextportField = value;
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

    public string crlcheck
    {
      get => this.crlcheckField;
      private set => this.crlcheckField = value;
    }

    public uint? service
    {
      get => this.serviceField;
      private set => this.serviceField = value;
    }

    public string servicename
    {
      get => this.servicenameField;
      private set => this.servicenameField = value;
    }

    public string ocspcheck
    {
      get => this.ocspcheckField;
      private set => this.ocspcheckField = value;
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
      sslvserver.sslvserver_response sslvserverResponse = new sslvserver.sslvserver_response();
      sslvserver.sslvserver_response resource = (sslvserver.sslvserver_response) service.get_payload_formatter().string_to_resource(sslvserverResponse.GetType(), response);
      if (resource.errorcode != 0)
      {
        if (resource.errorcode == 444)
          service.clear_session();
        if (resource.severity == null)
          throw new nitro_exception(resource.message, resource.errorcode);
        if (resource.severity.Equals("ERROR"))
          throw new nitro_exception(resource.message, resource.errorcode);
      }
      return (base_resource[]) resource.sslvserver;
    }

    internal override string get_object_name() => this.vservername;

    public static base_response update(nitro_service client, sslvserver resource) => new sslvserver()
    {
      vservername = resource.vservername,
      cleartextport = resource.cleartextport,
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
      pushenctrigger = resource.pushenctrigger,
      sendclosenotify = resource.sendclosenotify,
      dtlsprofilename = resource.dtlsprofilename,
      sslprofile = resource.sslprofile
    }.update_resource(client);

    public static base_responses update(nitro_service client, sslvserver[] resources)
    {
      base_responses baseResponses = (base_responses) null;
      if (resources != null && resources.Length > 0)
      {
        sslvserver[] sslvserverArray = new sslvserver[resources.Length];
        for (int index = 0; index < resources.Length; ++index)
        {
          sslvserverArray[index] = new sslvserver();
          sslvserverArray[index].vservername = resources[index].vservername;
          sslvserverArray[index].cleartextport = resources[index].cleartextport;
          sslvserverArray[index].dh = resources[index].dh;
          sslvserverArray[index].dhfile = resources[index].dhfile;
          sslvserverArray[index].dhcount = resources[index].dhcount;
          sslvserverArray[index].dhkeyexpsizelimit = resources[index].dhkeyexpsizelimit;
          sslvserverArray[index].ersa = resources[index].ersa;
          sslvserverArray[index].ersacount = resources[index].ersacount;
          sslvserverArray[index].sessreuse = resources[index].sessreuse;
          sslvserverArray[index].sesstimeout = resources[index].sesstimeout;
          sslvserverArray[index].cipherredirect = resources[index].cipherredirect;
          sslvserverArray[index].cipherurl = resources[index].cipherurl;
          sslvserverArray[index].sslv2redirect = resources[index].sslv2redirect;
          sslvserverArray[index].sslv2url = resources[index].sslv2url;
          sslvserverArray[index].clientauth = resources[index].clientauth;
          sslvserverArray[index].clientcert = resources[index].clientcert;
          sslvserverArray[index].sslredirect = resources[index].sslredirect;
          sslvserverArray[index].redirectportrewrite = resources[index].redirectportrewrite;
          sslvserverArray[index].nonfipsciphers = resources[index].nonfipsciphers;
          sslvserverArray[index].ssl2 = resources[index].ssl2;
          sslvserverArray[index].ssl3 = resources[index].ssl3;
          sslvserverArray[index].tls1 = resources[index].tls1;
          sslvserverArray[index].tls11 = resources[index].tls11;
          sslvserverArray[index].tls12 = resources[index].tls12;
          sslvserverArray[index].snienable = resources[index].snienable;
          sslvserverArray[index].pushenctrigger = resources[index].pushenctrigger;
          sslvserverArray[index].sendclosenotify = resources[index].sendclosenotify;
          sslvserverArray[index].dtlsprofilename = resources[index].dtlsprofilename;
          sslvserverArray[index].sslprofile = resources[index].sslprofile;
        }
        baseResponses = base_resource.update_bulk_request(client, (base_resource[]) sslvserverArray);
      }
      return baseResponses;
    }

    public static base_response unset(
      nitro_service client,
      string vservername,
      string[] args)
    {
      return new sslvserver() { vservername = vservername }.unset_resource(client, args);
    }

    public static base_response unset(
      nitro_service client,
      sslvserver resource,
      string[] args)
    {
      return new sslvserver()
      {
        vservername = resource.vservername
      }.unset_resource(client, args);
    }

    public static base_responses unset(
      nitro_service client,
      string[] vservername,
      string[] args)
    {
      base_responses baseResponses = (base_responses) null;
      if (vservername != null && vservername.Length > 0)
      {
        sslvserver[] sslvserverArray = new sslvserver[vservername.Length];
        for (int index = 0; index < vservername.Length; ++index)
        {
          sslvserverArray[index] = new sslvserver();
          sslvserverArray[index].vservername = vservername[index];
        }
        baseResponses = base_resource.unset_bulk_request(client, (base_resource[]) sslvserverArray, args);
      }
      return baseResponses;
    }

    public static base_responses unset(
      nitro_service client,
      sslvserver[] resources,
      string[] args)
    {
      base_responses baseResponses = (base_responses) null;
      if (resources != null && resources.Length > 0)
      {
        sslvserver[] sslvserverArray = new sslvserver[resources.Length];
        for (int index = 0; index < resources.Length; ++index)
        {
          sslvserverArray[index] = new sslvserver();
          sslvserverArray[index].vservername = resources[index].vservername;
        }
        baseResponses = base_resource.unset_bulk_request(client, (base_resource[]) sslvserverArray, args);
      }
      return baseResponses;
    }

    public static sslvserver[] get(nitro_service service) => (sslvserver[]) new sslvserver().get_resources(service, (options) null);

    public static sslvserver[] get(nitro_service service, options option) => (sslvserver[]) new sslvserver().get_resources(service, option);

    public static sslvserver[] get(nitro_service service, sslvserver_args args)
    {
      sslvserver sslvserver = new sslvserver();
      options option = new options();
      option.set_args(nitro_util.object_to_string_withoutquotes((object) args));
      return (sslvserver[]) sslvserver.get_resources(service, option);
    }

    public static sslvserver get(nitro_service service, string vservername) => (sslvserver) new sslvserver()
    {
      vservername = vservername
    }.get_resource(service);

    public static sslvserver[] get(nitro_service service, string[] vservername)
    {
      if (vservername == null || vservername.Length <= 0)
        return (sslvserver[]) null;
      sslvserver[] sslvserverArray1 = new sslvserver[vservername.Length];
      sslvserver[] sslvserverArray2 = new sslvserver[vservername.Length];
      for (int index = 0; index < vservername.Length; ++index)
      {
        sslvserverArray2[index] = new sslvserver();
        sslvserverArray2[index].vservername = vservername[index];
        sslvserverArray1[index] = (sslvserver) sslvserverArray2[index].get_resource(service);
      }
      return sslvserverArray1;
    }

    public static sslvserver[] get_filtered(nitro_service service, string filter)
    {
      sslvserver sslvserver = new sslvserver();
      options option = new options();
      option.set_filter(filter);
      return (sslvserver[]) sslvserver.getfiltered(service, option);
    }

    public static sslvserver[] get_filtered(nitro_service service, filtervalue[] filter)
    {
      sslvserver sslvserver = new sslvserver();
      options option = new options();
      option.set_filter(filter);
      return (sslvserver[]) sslvserver.getfiltered(service, option);
    }

    public static uint count(nitro_service service)
    {
      sslvserver sslvserver = new sslvserver();
      options option = new options();
      option.set_count(true);
      sslvserver[] resources = (sslvserver[]) sslvserver.get_resources(service, option);
      return resources != null && resources.Length > 0 ? resources[0].__count.Value : 0U;
    }

    public static uint count_filtered(nitro_service service, string filter)
    {
      sslvserver sslvserver = new sslvserver();
      options option = new options();
      option.set_count(true);
      option.set_filter(filter);
      sslvserver[] sslvserverArray = (sslvserver[]) sslvserver.getfiltered(service, option);
      return sslvserverArray != null && sslvserverArray.Length > 0 ? sslvserverArray[0].__count.Value : 0U;
    }

    public static uint count_filtered(nitro_service service, filtervalue[] filter)
    {
      sslvserver sslvserver = new sslvserver();
      options option = new options();
      option.set_count(true);
      option.set_filter(filter);
      sslvserver[] sslvserverArray = (sslvserver[]) sslvserver.getfiltered(service, option);
      return sslvserverArray != null && sslvserverArray.Length > 0 ? sslvserverArray[0].__count.Value : 0U;
    }

    private class sslvserver_response : base_response
    {
      public sslvserver[] sslvserver = (sslvserver[]) null;
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
