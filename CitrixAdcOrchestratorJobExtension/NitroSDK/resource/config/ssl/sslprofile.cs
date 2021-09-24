// Decompiled with JetBrains decompiler
// Type: com.citrix.netscaler.nitro.resource.config.ssl.sslprofile
// Assembly: nitro, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 6CF5DDEF-E052-4F9D-953F-6644F8378A66


using com.citrix.netscaler.nitro.exception;
using com.citrix.netscaler.nitro.resource.Base;
using com.citrix.netscaler.nitro.service;
using com.citrix.netscaler.nitro.util;

namespace com.citrix.netscaler.nitro.resource.config.ssl
{
  public class sslprofile : base_resource
  {
    private string nameField = (string) null;
    private string sslprofiletypeField = (string) null;
    private uint? dhcountField = new uint?();
    private string dhField = (string) null;
    private string dhfileField = (string) null;
    private string ersaField = (string) null;
    private uint? ersacountField = new uint?();
    private string sessreuseField = (string) null;
    private uint? sesstimeoutField = new uint?();
    private string cipherredirectField = (string) null;
    private string cipherurlField = (string) null;
    private string clientauthField = (string) null;
    private string clientcertField = (string) null;
    private string dhkeyexpsizelimitField = (string) null;
    private string sslredirectField = (string) null;
    private string redirectportrewriteField = (string) null;
    private string nonfipsciphersField = (string) null;
    private string ssl3Field = (string) null;
    private string tls1Field = (string) null;
    private string tls11Field = (string) null;
    private string tls12Field = (string) null;
    private string snienableField = (string) null;
    private string serverauthField = (string) null;
    private string commonnameField = (string) null;
    private string pushenctriggerField = (string) null;
    private string sendclosenotifyField = (string) null;
    private ushort? cleartextportField = new ushort?();
    private string insertionencodingField = (string) null;
    private string denysslrenegField = (string) null;
    private string quantumsizeField = (string) null;
    private string strictcachecksField = (string) null;
    private uint? encrypttriggerpktcountField = new uint?();
    private uint? pushflagField = new uint?();
    private string dropreqwithnohostheaderField = (string) null;
    private uint? pushenctriggertimeoutField = new uint?();
    private uint? ssltriggertimeoutField = new uint?();
    private string clientauthuseboundcachainField = (string) null;
    private string ciphernameField = (string) null;
    private uint? cipherpriorityField = new uint?();
    private string crlcheckField = (string) null;
    private string ocspcheckField = (string) null;
    private bool? snicertField = new bool?();
    private bool? skipcanameField = new bool?();
    private bool? invokeField = new bool?();
    private string labeltypeField = (string) null;
    private uint? serviceField = new uint?();
    private string[] builtinField = (string[]) null;
    private uint? __countField = new uint?();

    public uint? __count
    {
      get => this.__countField;
      private set => this.__countField = value;
    }

    public string name
    {
      get => this.nameField;
      set => this.nameField = value;
    }

    public string sslprofiletype
    {
      get => this.sslprofiletypeField;
      set => this.sslprofiletypeField = value;
    }

    public uint? dhcount
    {
      get => this.dhcountField;
      set => this.dhcountField = value;
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

    public string dhkeyexpsizelimit
    {
      get => this.dhkeyexpsizelimitField;
      set => this.dhkeyexpsizelimitField = value;
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

    public ushort? cleartextport
    {
      get => this.cleartextportField;
      set => this.cleartextportField = value;
    }

    public string insertionencoding
    {
      get => this.insertionencodingField;
      set => this.insertionencodingField = value;
    }

    public string denysslreneg
    {
      get => this.denysslrenegField;
      set => this.denysslrenegField = value;
    }

    public string quantumsize
    {
      get => this.quantumsizeField;
      set => this.quantumsizeField = value;
    }

    public string strictcachecks
    {
      get => this.strictcachecksField;
      set => this.strictcachecksField = value;
    }

    public uint? encrypttriggerpktcount
    {
      get => this.encrypttriggerpktcountField;
      set => this.encrypttriggerpktcountField = value;
    }

    public uint? pushflag
    {
      get => this.pushflagField;
      set => this.pushflagField = value;
    }

    public string dropreqwithnohostheader
    {
      get => this.dropreqwithnohostheaderField;
      set => this.dropreqwithnohostheaderField = value;
    }

    public uint? pushenctriggertimeout
    {
      get => this.pushenctriggertimeoutField;
      set => this.pushenctriggertimeoutField = value;
    }

    public uint? ssltriggertimeout
    {
      get => this.ssltriggertimeoutField;
      set => this.ssltriggertimeoutField = value;
    }

    public string clientauthuseboundcachain
    {
      get => this.clientauthuseboundcachainField;
      set => this.clientauthuseboundcachainField = value;
    }

    public string ciphername
    {
      get => this.ciphernameField;
      set => this.ciphernameField = value;
    }

    public uint? cipherpriority
    {
      get => this.cipherpriorityField;
      set => this.cipherpriorityField = value;
    }

    public string crlcheck
    {
      get => this.crlcheckField;
      private set => this.crlcheckField = value;
    }

    public string ocspcheck
    {
      get => this.ocspcheckField;
      private set => this.ocspcheckField = value;
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

    public bool? invoke
    {
      get => this.invokeField;
      private set => this.invokeField = value;
    }

    public string labeltype
    {
      get => this.labeltypeField;
      private set => this.labeltypeField = value;
    }

    public uint? service
    {
      get => this.serviceField;
      private set => this.serviceField = value;
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
      sslprofile.sslprofile_response sslprofileResponse = new sslprofile.sslprofile_response();
      sslprofile.sslprofile_response resource = (sslprofile.sslprofile_response) service.get_payload_formatter().string_to_resource(sslprofileResponse.GetType(), response);
      if (resource.errorcode != 0)
      {
        if (resource.errorcode == 444)
          service.clear_session();
        if (resource.severity == null)
          throw new nitro_exception(resource.message, resource.errorcode);
        if (resource.severity.Equals("ERROR"))
          throw new nitro_exception(resource.message, resource.errorcode);
      }
      return (base_resource[]) resource.sslprofile;
    }

    internal override string get_object_name() => this.name;

    public static base_response add(nitro_service client, sslprofile resource) => new sslprofile()
    {
      name = resource.name,
      sslprofiletype = resource.sslprofiletype,
      dhcount = resource.dhcount,
      dh = resource.dh,
      dhfile = resource.dhfile,
      ersa = resource.ersa,
      ersacount = resource.ersacount,
      sessreuse = resource.sessreuse,
      sesstimeout = resource.sesstimeout,
      cipherredirect = resource.cipherredirect,
      cipherurl = resource.cipherurl,
      clientauth = resource.clientauth,
      clientcert = resource.clientcert,
      dhkeyexpsizelimit = resource.dhkeyexpsizelimit,
      sslredirect = resource.sslredirect,
      redirectportrewrite = resource.redirectportrewrite,
      nonfipsciphers = resource.nonfipsciphers,
      ssl3 = resource.ssl3,
      tls1 = resource.tls1,
      tls11 = resource.tls11,
      tls12 = resource.tls12,
      snienable = resource.snienable,
      serverauth = resource.serverauth,
      commonname = resource.commonname,
      pushenctrigger = resource.pushenctrigger,
      sendclosenotify = resource.sendclosenotify,
      cleartextport = resource.cleartextport,
      insertionencoding = resource.insertionencoding,
      denysslreneg = resource.denysslreneg,
      quantumsize = resource.quantumsize,
      strictcachecks = resource.strictcachecks,
      encrypttriggerpktcount = resource.encrypttriggerpktcount,
      pushflag = resource.pushflag,
      dropreqwithnohostheader = resource.dropreqwithnohostheader,
      pushenctriggertimeout = resource.pushenctriggertimeout,
      ssltriggertimeout = resource.ssltriggertimeout,
      clientauthuseboundcachain = resource.clientauthuseboundcachain
    }.add_resource(client);

    public static base_responses add(nitro_service client, sslprofile[] resources)
    {
      base_responses baseResponses = (base_responses) null;
      if (resources != null && resources.Length > 0)
      {
        sslprofile[] sslprofileArray = new sslprofile[resources.Length];
        for (int index = 0; index < resources.Length; ++index)
        {
          sslprofileArray[index] = new sslprofile();
          sslprofileArray[index].name = resources[index].name;
          sslprofileArray[index].sslprofiletype = resources[index].sslprofiletype;
          sslprofileArray[index].dhcount = resources[index].dhcount;
          sslprofileArray[index].dh = resources[index].dh;
          sslprofileArray[index].dhfile = resources[index].dhfile;
          sslprofileArray[index].ersa = resources[index].ersa;
          sslprofileArray[index].ersacount = resources[index].ersacount;
          sslprofileArray[index].sessreuse = resources[index].sessreuse;
          sslprofileArray[index].sesstimeout = resources[index].sesstimeout;
          sslprofileArray[index].cipherredirect = resources[index].cipherredirect;
          sslprofileArray[index].cipherurl = resources[index].cipherurl;
          sslprofileArray[index].clientauth = resources[index].clientauth;
          sslprofileArray[index].clientcert = resources[index].clientcert;
          sslprofileArray[index].dhkeyexpsizelimit = resources[index].dhkeyexpsizelimit;
          sslprofileArray[index].sslredirect = resources[index].sslredirect;
          sslprofileArray[index].redirectportrewrite = resources[index].redirectportrewrite;
          sslprofileArray[index].nonfipsciphers = resources[index].nonfipsciphers;
          sslprofileArray[index].ssl3 = resources[index].ssl3;
          sslprofileArray[index].tls1 = resources[index].tls1;
          sslprofileArray[index].tls11 = resources[index].tls11;
          sslprofileArray[index].tls12 = resources[index].tls12;
          sslprofileArray[index].snienable = resources[index].snienable;
          sslprofileArray[index].serverauth = resources[index].serverauth;
          sslprofileArray[index].commonname = resources[index].commonname;
          sslprofileArray[index].pushenctrigger = resources[index].pushenctrigger;
          sslprofileArray[index].sendclosenotify = resources[index].sendclosenotify;
          sslprofileArray[index].cleartextport = resources[index].cleartextport;
          sslprofileArray[index].insertionencoding = resources[index].insertionencoding;
          sslprofileArray[index].denysslreneg = resources[index].denysslreneg;
          sslprofileArray[index].quantumsize = resources[index].quantumsize;
          sslprofileArray[index].strictcachecks = resources[index].strictcachecks;
          sslprofileArray[index].encrypttriggerpktcount = resources[index].encrypttriggerpktcount;
          sslprofileArray[index].pushflag = resources[index].pushflag;
          sslprofileArray[index].dropreqwithnohostheader = resources[index].dropreqwithnohostheader;
          sslprofileArray[index].pushenctriggertimeout = resources[index].pushenctriggertimeout;
          sslprofileArray[index].ssltriggertimeout = resources[index].ssltriggertimeout;
          sslprofileArray[index].clientauthuseboundcachain = resources[index].clientauthuseboundcachain;
        }
        baseResponses = base_resource.add_bulk_request(client, (base_resource[]) sslprofileArray);
      }
      return baseResponses;
    }

    public static base_response delete(nitro_service client, string name) => new sslprofile()
    {
      name = name
    }.delete_resource(client);

    public static base_response delete(nitro_service client, sslprofile resource) => new sslprofile()
    {
      name = resource.name
    }.delete_resource(client);

    public static base_responses delete(nitro_service client, string[] name)
    {
      base_responses baseResponses = (base_responses) null;
      if (name != null && name.Length > 0)
      {
        sslprofile[] sslprofileArray = new sslprofile[name.Length];
        for (int index = 0; index < name.Length; ++index)
        {
          sslprofileArray[index] = new sslprofile();
          sslprofileArray[index].name = name[index];
        }
        baseResponses = base_resource.delete_bulk_request(client, (base_resource[]) sslprofileArray);
      }
      return baseResponses;
    }

    public static base_responses delete(nitro_service client, sslprofile[] resources)
    {
      base_responses baseResponses = (base_responses) null;
      if (resources != null && resources.Length > 0)
      {
        sslprofile[] sslprofileArray = new sslprofile[resources.Length];
        for (int index = 0; index < resources.Length; ++index)
        {
          sslprofileArray[index] = new sslprofile();
          sslprofileArray[index].name = resources[index].name;
        }
        baseResponses = base_resource.delete_bulk_request(client, (base_resource[]) sslprofileArray);
      }
      return baseResponses;
    }

    public static base_response update(nitro_service client, sslprofile resource) => new sslprofile()
    {
      name = resource.name,
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
      clientauth = resource.clientauth,
      clientcert = resource.clientcert,
      sslredirect = resource.sslredirect,
      redirectportrewrite = resource.redirectportrewrite,
      nonfipsciphers = resource.nonfipsciphers,
      ssl3 = resource.ssl3,
      tls1 = resource.tls1,
      tls11 = resource.tls11,
      tls12 = resource.tls12,
      snienable = resource.snienable,
      serverauth = resource.serverauth,
      commonname = resource.commonname,
      pushenctrigger = resource.pushenctrigger,
      sendclosenotify = resource.sendclosenotify,
      cleartextport = resource.cleartextport,
      insertionencoding = resource.insertionencoding,
      denysslreneg = resource.denysslreneg,
      quantumsize = resource.quantumsize,
      strictcachecks = resource.strictcachecks,
      encrypttriggerpktcount = resource.encrypttriggerpktcount,
      pushflag = resource.pushflag,
      dropreqwithnohostheader = resource.dropreqwithnohostheader,
      pushenctriggertimeout = resource.pushenctriggertimeout,
      ssltriggertimeout = resource.ssltriggertimeout,
      clientauthuseboundcachain = resource.clientauthuseboundcachain,
      ciphername = resource.ciphername,
      cipherpriority = resource.cipherpriority
    }.update_resource(client);

    public static base_responses update(nitro_service client, sslprofile[] resources)
    {
      base_responses baseResponses = (base_responses) null;
      if (resources != null && resources.Length > 0)
      {
        sslprofile[] sslprofileArray = new sslprofile[resources.Length];
        for (int index = 0; index < resources.Length; ++index)
        {
          sslprofileArray[index] = new sslprofile();
          sslprofileArray[index].name = resources[index].name;
          sslprofileArray[index].dh = resources[index].dh;
          sslprofileArray[index].dhfile = resources[index].dhfile;
          sslprofileArray[index].dhcount = resources[index].dhcount;
          sslprofileArray[index].dhkeyexpsizelimit = resources[index].dhkeyexpsizelimit;
          sslprofileArray[index].ersa = resources[index].ersa;
          sslprofileArray[index].ersacount = resources[index].ersacount;
          sslprofileArray[index].sessreuse = resources[index].sessreuse;
          sslprofileArray[index].sesstimeout = resources[index].sesstimeout;
          sslprofileArray[index].cipherredirect = resources[index].cipherredirect;
          sslprofileArray[index].cipherurl = resources[index].cipherurl;
          sslprofileArray[index].clientauth = resources[index].clientauth;
          sslprofileArray[index].clientcert = resources[index].clientcert;
          sslprofileArray[index].sslredirect = resources[index].sslredirect;
          sslprofileArray[index].redirectportrewrite = resources[index].redirectportrewrite;
          sslprofileArray[index].nonfipsciphers = resources[index].nonfipsciphers;
          sslprofileArray[index].ssl3 = resources[index].ssl3;
          sslprofileArray[index].tls1 = resources[index].tls1;
          sslprofileArray[index].tls11 = resources[index].tls11;
          sslprofileArray[index].tls12 = resources[index].tls12;
          sslprofileArray[index].snienable = resources[index].snienable;
          sslprofileArray[index].serverauth = resources[index].serverauth;
          sslprofileArray[index].commonname = resources[index].commonname;
          sslprofileArray[index].pushenctrigger = resources[index].pushenctrigger;
          sslprofileArray[index].sendclosenotify = resources[index].sendclosenotify;
          sslprofileArray[index].cleartextport = resources[index].cleartextport;
          sslprofileArray[index].insertionencoding = resources[index].insertionencoding;
          sslprofileArray[index].denysslreneg = resources[index].denysslreneg;
          sslprofileArray[index].quantumsize = resources[index].quantumsize;
          sslprofileArray[index].strictcachecks = resources[index].strictcachecks;
          sslprofileArray[index].encrypttriggerpktcount = resources[index].encrypttriggerpktcount;
          sslprofileArray[index].pushflag = resources[index].pushflag;
          sslprofileArray[index].dropreqwithnohostheader = resources[index].dropreqwithnohostheader;
          sslprofileArray[index].pushenctriggertimeout = resources[index].pushenctriggertimeout;
          sslprofileArray[index].ssltriggertimeout = resources[index].ssltriggertimeout;
          sslprofileArray[index].clientauthuseboundcachain = resources[index].clientauthuseboundcachain;
          sslprofileArray[index].ciphername = resources[index].ciphername;
          sslprofileArray[index].cipherpriority = resources[index].cipherpriority;
        }
        baseResponses = base_resource.update_bulk_request(client, (base_resource[]) sslprofileArray);
      }
      return baseResponses;
    }

    public static base_response unset(
      nitro_service client,
      string name,
      string[] args)
    {
      return new sslprofile() { name = name }.unset_resource(client, args);
    }

    public static base_response unset(
      nitro_service client,
      sslprofile resource,
      string[] args)
    {
      return new sslprofile() { name = resource.name }.unset_resource(client, args);
    }

    public static base_responses unset(
      nitro_service client,
      string[] name,
      string[] args)
    {
      base_responses baseResponses = (base_responses) null;
      if (name != null && name.Length > 0)
      {
        sslprofile[] sslprofileArray = new sslprofile[name.Length];
        for (int index = 0; index < name.Length; ++index)
        {
          sslprofileArray[index] = new sslprofile();
          sslprofileArray[index].name = name[index];
        }
        baseResponses = base_resource.unset_bulk_request(client, (base_resource[]) sslprofileArray, args);
      }
      return baseResponses;
    }

    public static base_responses unset(
      nitro_service client,
      sslprofile[] resources,
      string[] args)
    {
      base_responses baseResponses = (base_responses) null;
      if (resources != null && resources.Length > 0)
      {
        sslprofile[] sslprofileArray = new sslprofile[resources.Length];
        for (int index = 0; index < resources.Length; ++index)
        {
          sslprofileArray[index] = new sslprofile();
          sslprofileArray[index].name = resources[index].name;
        }
        baseResponses = base_resource.unset_bulk_request(client, (base_resource[]) sslprofileArray, args);
      }
      return baseResponses;
    }

    public static sslprofile[] get(nitro_service service) => (sslprofile[]) new sslprofile().get_resources(service, (options) null);

    public static sslprofile[] get(nitro_service service, options option) => (sslprofile[]) new sslprofile().get_resources(service, option);

    public static sslprofile get(nitro_service service, string name) => (sslprofile) new sslprofile()
    {
      name = name
    }.get_resource(service);

    public static sslprofile[] get(nitro_service service, string[] name)
    {
      if (name == null || name.Length <= 0)
        return (sslprofile[]) null;
      sslprofile[] sslprofileArray1 = new sslprofile[name.Length];
      sslprofile[] sslprofileArray2 = new sslprofile[name.Length];
      for (int index = 0; index < name.Length; ++index)
      {
        sslprofileArray2[index] = new sslprofile();
        sslprofileArray2[index].name = name[index];
        sslprofileArray1[index] = (sslprofile) sslprofileArray2[index].get_resource(service);
      }
      return sslprofileArray1;
    }

    public static sslprofile[] get_filtered(nitro_service service, string filter)
    {
      sslprofile sslprofile = new sslprofile();
      options option = new options();
      option.set_filter(filter);
      return (sslprofile[]) sslprofile.getfiltered(service, option);
    }

    public static sslprofile[] get_filtered(nitro_service service, filtervalue[] filter)
    {
      sslprofile sslprofile = new sslprofile();
      options option = new options();
      option.set_filter(filter);
      return (sslprofile[]) sslprofile.getfiltered(service, option);
    }

    public static uint count(nitro_service service)
    {
      sslprofile sslprofile = new sslprofile();
      options option = new options();
      option.set_count(true);
      sslprofile[] resources = (sslprofile[]) sslprofile.get_resources(service, option);
      return resources != null && resources.Length > 0 ? resources[0].__count.Value : 0U;
    }

    public static uint count_filtered(nitro_service service, string filter)
    {
      sslprofile sslprofile = new sslprofile();
      options option = new options();
      option.set_count(true);
      option.set_filter(filter);
      sslprofile[] sslprofileArray = (sslprofile[]) sslprofile.getfiltered(service, option);
      return sslprofileArray != null && sslprofileArray.Length > 0 ? sslprofileArray[0].__count.Value : 0U;
    }

    public static uint count_filtered(nitro_service service, filtervalue[] filter)
    {
      sslprofile sslprofile = new sslprofile();
      options option = new options();
      option.set_count(true);
      option.set_filter(filter);
      sslprofile[] sslprofileArray = (sslprofile[]) sslprofile.getfiltered(service, option);
      return sslprofileArray != null && sslprofileArray.Length > 0 ? sslprofileArray[0].__count.Value : 0U;
    }

    private class sslprofile_response : base_response
    {
      public sslprofile[] sslprofile = (sslprofile[]) null;
    }

    public static class denysslrenegEnum
    {
      public const string NO = "NO";
      public const string FRONTEND_CLIENT = "FRONTEND_CLIENT";
      public const string FRONTEND_CLIENTSERVER = "FRONTEND_CLIENTSERVER";
      public const string ALL = "ALL";
      public const string NONSECURE = "NONSECURE";
    }

    public static class insertionencodingEnum
    {
      public const string Unicode = "Unicode";
      public const string UTF_8 = "UTF-8";
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

    public static class strictcachecksEnum
    {
      public const string YES = "YES";
      public const string NO = "NO";
    }

    public static class quantumsizeEnum
    {
      public const string _4096 = "4096";
      public const string _8192 = "8192";
      public const string _16384 = "16384";
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

    public static class builtinEnum
    {
      public const string MODIFIABLE = "MODIFIABLE";
      public const string DELETABLE = "DELETABLE";
      public const string IMMUTABLE = "IMMUTABLE";
      public const string PARTITION_ALL = "PARTITION_ALL";
    }

    public static class clientauthuseboundcachainEnum
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

    public static class dropreqwithnohostheaderEnum
    {
      public const string YES = "YES";
      public const string NO = "NO";
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

    public static class labeltypeEnum
    {
      public const string vserver = "vserver";
      public const string service = "service";
      public const string policylabel = "policylabel";
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

    public static class ocspcheckEnum
    {
      public const string Mandatory = "Mandatory";
      public const string Optional = "Optional";
    }

    public static class sslprofiletypeEnum
    {
      public const string BackEnd = "BackEnd";
      public const string FrontEnd = "FrontEnd";
    }
  }
}
