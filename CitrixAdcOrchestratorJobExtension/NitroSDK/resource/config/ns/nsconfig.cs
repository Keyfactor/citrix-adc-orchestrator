// Decompiled with JetBrains decompiler
// Type: com.citrix.netscaler.nitro.resource.config.ns.nsconfig
// Assembly: nitro, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 6CF5DDEF-E052-4F9D-953F-6644F8378A66


using com.citrix.netscaler.nitro.exception;
using com.citrix.netscaler.nitro.resource.Base;
using com.citrix.netscaler.nitro.service;

namespace com.citrix.netscaler.nitro.resource.config.ns
{
  public class nsconfig : base_resource
  {
    private bool? forceField = new bool?();
    private string levelField = (string) null;
    private string ipaddressField = (string) null;
    private string netmaskField = (string) null;
    private uint? nsvlanField = new uint?();
    private string[] ifnumField = (string[]) null;
    private string taggedField = (string) null;
    private ushort?[] httpportField = (ushort?[]) null;
    private uint? maxconnField = new uint?();
    private uint? maxreqField = new uint?();
    private string cipField = (string) null;
    private string cipheaderField = (string) null;
    private string cookieversionField = (string) null;
    private string securecookieField = (string) null;
    private uint? pmtuminField = new uint?();
    private uint? pmtutimeoutField = new uint?();
    private string ftpportrangeField = (string) null;
    private string crportrangeField = (string) null;
    private string timezoneField = (string) null;
    private uint? grantquotamaxclientField = new uint?();
    private uint? exclusivequotamaxclientField = new uint?();
    private uint? grantquotaspilloverField = new uint?();
    private uint? exclusivequotaspilloverField = new uint?();
    private string config1Field = (string) null;
    private string config2Field = (string) null;
    private string outtypeField = (string) null;
    private bool? templateField = new bool?();
    private bool? ignoredevicespecificField = new bool?();
    private bool? weakpasswordField = new bool?();
    private string configField = (string) null;
    private string messageField = (string) null;
    private string mappedipField = (string) null;
    private uint? rangeField = new uint?();
    private string systemtypeField = (string) null;
    private string primaryipField = (string) null;
    private uint? flagsField = new uint?();
    private string lastconfigchangedtimeField = (string) null;
    private string lastconfigsavetimeField = (string) null;
    private string currentsytemtimeField = (string) null;
    private uint? systemtimeField = new uint?();
    private bool? configchangedField = new bool?();
    private string responseField = (string) null;

    public bool? force
    {
      get => this.forceField;
      set => this.forceField = value;
    }

    public string level
    {
      get => this.levelField;
      set => this.levelField = value;
    }

    public string ipaddress
    {
      get => this.ipaddressField;
      set => this.ipaddressField = value;
    }

    public string netmask
    {
      get => this.netmaskField;
      set => this.netmaskField = value;
    }

    public uint? nsvlan
    {
      get => this.nsvlanField;
      set => this.nsvlanField = value;
    }

    public string[] ifnum
    {
      get => this.ifnumField;
      set => this.ifnumField = value;
    }

    public string tagged
    {
      get => this.taggedField;
      set => this.taggedField = value;
    }

    public ushort?[] httpport
    {
      get => this.httpportField;
      set => this.httpportField = value;
    }

    public uint? maxconn
    {
      get => this.maxconnField;
      set => this.maxconnField = value;
    }

    public uint? maxreq
    {
      get => this.maxreqField;
      set => this.maxreqField = value;
    }

    public string cip
    {
      get => this.cipField;
      set => this.cipField = value;
    }

    public string cipheader
    {
      get => this.cipheaderField;
      set => this.cipheaderField = value;
    }

    public string cookieversion
    {
      get => this.cookieversionField;
      set => this.cookieversionField = value;
    }

    public string securecookie
    {
      get => this.securecookieField;
      set => this.securecookieField = value;
    }

    public uint? pmtumin
    {
      get => this.pmtuminField;
      set => this.pmtuminField = value;
    }

    public uint? pmtutimeout
    {
      get => this.pmtutimeoutField;
      set => this.pmtutimeoutField = value;
    }

    public string ftpportrange
    {
      get => this.ftpportrangeField;
      set => this.ftpportrangeField = value;
    }

    public string crportrange
    {
      get => this.crportrangeField;
      set => this.crportrangeField = value;
    }

    public string timezone
    {
      get => this.timezoneField;
      set => this.timezoneField = value;
    }

    public uint? grantquotamaxclient
    {
      get => this.grantquotamaxclientField;
      set => this.grantquotamaxclientField = value;
    }

    public uint? exclusivequotamaxclient
    {
      get => this.exclusivequotamaxclientField;
      set => this.exclusivequotamaxclientField = value;
    }

    public uint? grantquotaspillover
    {
      get => this.grantquotaspilloverField;
      set => this.grantquotaspilloverField = value;
    }

    public uint? exclusivequotaspillover
    {
      get => this.exclusivequotaspilloverField;
      set => this.exclusivequotaspilloverField = value;
    }

    public string config1
    {
      get => this.config1Field;
      set => this.config1Field = value;
    }

    public string config2
    {
      get => this.config2Field;
      set => this.config2Field = value;
    }

    public string outtype
    {
      get => this.outtypeField;
      set => this.outtypeField = value;
    }

    public bool? template
    {
      get => this.templateField;
      set => this.templateField = value;
    }

    public bool? ignoredevicespecific
    {
      get => this.ignoredevicespecificField;
      set => this.ignoredevicespecificField = value;
    }

    public bool? weakpassword
    {
      get => this.weakpasswordField;
      set => this.weakpasswordField = value;
    }

    public string config
    {
      get => this.configField;
      set => this.configField = value;
    }

    public string message
    {
      get => this.messageField;
      private set => this.messageField = value;
    }

    public string mappedip
    {
      get => this.mappedipField;
      private set => this.mappedipField = value;
    }

    public uint? range
    {
      get => this.rangeField;
      private set => this.rangeField = value;
    }

    public string systemtype
    {
      get => this.systemtypeField;
      private set => this.systemtypeField = value;
    }

    public string primaryip
    {
      get => this.primaryipField;
      private set => this.primaryipField = value;
    }

    public uint? flags
    {
      get => this.flagsField;
      private set => this.flagsField = value;
    }

    public string lastconfigchangedtime
    {
      get => this.lastconfigchangedtimeField;
      private set => this.lastconfigchangedtimeField = value;
    }

    public string lastconfigsavetime
    {
      get => this.lastconfigsavetimeField;
      private set => this.lastconfigsavetimeField = value;
    }

    public string currentsytemtime
    {
      get => this.currentsytemtimeField;
      private set => this.currentsytemtimeField = value;
    }

    public uint? systemtime
    {
      get => this.systemtimeField;
      private set => this.systemtimeField = value;
    }

    public bool? configchanged
    {
      get => this.configchangedField;
      private set => this.configchangedField = value;
    }

    public string response
    {
      get => this.responseField;
      private set => this.responseField = value;
    }

    internal override base_resource[] get_nitro_response(
      nitro_service service,
      string response)
    {
      nsconfig[] nsconfigArray = new nsconfig[1];
      nsconfig.nsconfig_response nsconfigResponse = new nsconfig.nsconfig_response();
      nsconfig.nsconfig_response resource = (nsconfig.nsconfig_response) service.get_payload_formatter().string_to_resource(nsconfigResponse.GetType(), response);
      if (resource.errorcode != 0)
      {
        if (resource.errorcode == 444)
          service.clear_session();
        if (resource.severity == null)
          throw new nitro_exception(resource.message, resource.errorcode);
        if (resource.severity.Equals("ERROR"))
          throw new nitro_exception(resource.message, resource.errorcode);
      }
      nsconfigArray[0] = resource.nsconfig;
      return (base_resource[]) nsconfigArray;
    }

    internal override string get_object_name() => (string) null;

    public static base_response clear(nitro_service client, nsconfig resource) => new nsconfig()
    {
      force = resource.force,
      level = resource.level
    }.perform_operation_byaction(client, nameof (clear));

    public static base_response update(nitro_service client, nsconfig resource) => new nsconfig()
    {
      ipaddress = resource.ipaddress,
      netmask = resource.netmask,
      nsvlan = resource.nsvlan,
      ifnum = resource.ifnum,
      tagged = resource.tagged,
      httpport = resource.httpport,
      maxconn = resource.maxconn,
      maxreq = resource.maxreq,
      cip = resource.cip,
      cipheader = resource.cipheader,
      cookieversion = resource.cookieversion,
      securecookie = resource.securecookie,
      pmtumin = resource.pmtumin,
      pmtutimeout = resource.pmtutimeout,
      ftpportrange = resource.ftpportrange,
      crportrange = resource.crportrange,
      timezone = resource.timezone,
      grantquotamaxclient = resource.grantquotamaxclient,
      exclusivequotamaxclient = resource.exclusivequotamaxclient,
      grantquotaspillover = resource.grantquotaspillover,
      exclusivequotaspillover = resource.exclusivequotaspillover
    }.update_resource(client);

    public static base_response unset(
      nitro_service client,
      nsconfig resource,
      string[] args)
    {
      return new nsconfig().unset_resource(client, args);
    }

    public static base_response save(nitro_service client) => new nsconfig().perform_operation_byaction(client, nameof (save));

    public static nsconfig diff(nitro_service client, nsconfig resource) => (nsconfig) new nsconfig()
    {
      config1 = resource.config1,
      config2 = resource.config2,
      outtype = resource.outtype,
      template = resource.template,
      ignoredevicespecific = resource.ignoredevicespecific
    }.perform_operation_byactionEx(client, nameof (diff));

    public static nsconfig get(nitro_service service) => ((nsconfig[]) new nsconfig().get_resources(service, (options) null))[0];

    public static nsconfig get(nitro_service service, options option) => ((nsconfig[]) new nsconfig().get_resources(service, option))[0];

    private class nsconfig_response : base_response
    {
      public nsconfig nsconfig = (nsconfig) null;
    }

    public static class outtypeEnum
    {
      public const string cli = "cli";
      public const string xml = "xml";
    }

    public static class timezoneEnum
    {
      public const string CoordinatedUniversalTime = "CoordinatedUniversalTime";
      public const string GMT_01_00_CET_Europe_Andorra = "GMT+01:00-CET-Europe/Andorra";
      public const string GMT_04_00_GST_Asia_Dubai = "GMT+04:00-GST-Asia/Dubai";
      public const string GMT_04_30_AFT_Asia_Kabul = "GMT+04:30-AFT-Asia/Kabul";
      public const string GMT_04_00_AST_America_Antigua = "GMT-04:00-AST-America/Antigua";
      public const string GMT_04_00_AST_America_Anguilla = "GMT-04:00-AST-America/Anguilla";
      public const string GMT_01_00_CET_Europe_Tirane = "GMT+01:00-CET-Europe/Tirane";
      public const string GMT_04_00_AMT_Asia_Yerevan = "GMT+04:00-AMT-Asia/Yerevan";
      public const string GMT_01_00_WAT_Africa_Luanda = "GMT+01:00-WAT-Africa/Luanda";
      public const string GMT_13_00_NZDT_Antarctica_McMurdo = "GMT+13:00-NZDT-Antarctica/McMurdo";
      public const string GMT_13_00_NZDT_Antarctica_South_Pole = "GMT+13:00-NZDT-Antarctica/South_Pole";
      public const string GMT_03_00_ROTT_Antarctica_Rothera = "GMT-03:00-ROTT-Antarctica/Rothera";
      public const string GMT_04_00_CLT_Antarctica_Palmer = "GMT-04:00-CLT-Antarctica/Palmer";
      public const string GMT_05_00_MAWT_Antarctica_Mawson = "GMT+05:00-MAWT-Antarctica/Mawson";
      public const string GMT_07_00_DAVT_Antarctica_Davis = "GMT+07:00-DAVT-Antarctica/Davis";
      public const string GMT_08_00_WST_Antarctica_Casey = "GMT+08:00-WST-Antarctica/Casey";
      public const string GMT_06_00_VOST_Antarctica_Vostok = "GMT+06:00-VOST-Antarctica/Vostok";
      public const string GMT_10_00_DDUT_Antarctica_DumontDUrville = "GMT+10:00-DDUT-Antarctica/DumontDUrville";
      public const string GMT_03_00_SYOT_Antarctica_Syowa = "GMT+03:00-SYOT-Antarctica/Syowa";
      public const string GMT_11_00_MIST_Antarctica_Macquarie = "GMT+11:00-MIST-Antarctica/Macquarie";
      public const string GMT_03_00_ART_America_Argentina_Buenos_Aires = "GMT-03:00-ART-America/Argentina/Buenos_Aires";
      public const string GMT_03_00_ART_America_Argentina_Cordoba = "GMT-03:00-ART-America/Argentina/Cordoba";
      public const string GMT_03_00_ART_America_Argentina_Salta = "GMT-03:00-ART-America/Argentina/Salta";
      public const string GMT_03_00_ART_America_Argentina_Jujuy = "GMT-03:00-ART-America/Argentina/Jujuy";
      public const string GMT_03_00_ART_America_Argentina_Tucuman = "GMT-03:00-ART-America/Argentina/Tucuman";
      public const string GMT_03_00_ART_America_Argentina_Catamarca = "GMT-03:00-ART-America/Argentina/Catamarca";
      public const string GMT_03_00_ART_America_Argentina_La_Rioja = "GMT-03:00-ART-America/Argentina/La_Rioja";
      public const string GMT_03_00_ART_America_Argentina_San_Juan = "GMT-03:00-ART-America/Argentina/San_Juan";
      public const string GMT_03_00_ART_America_Argentina_Mendoza = "GMT-03:00-ART-America/Argentina/Mendoza";
      public const string GMT_03_00_WARST_America_Argentina_San_Luis = "GMT-03:00-WARST-America/Argentina/San_Luis";
      public const string GMT_03_00_ART_America_Argentina_Rio_Gallegos = "GMT-03:00-ART-America/Argentina/Rio_Gallegos";
      public const string GMT_03_00_ART_America_Argentina_Ushuaia = "GMT-03:00-ART-America/Argentina/Ushuaia";
      public const string GMT_11_00_SST_Pacific_Pago_Pago = "GMT-11:00-SST-Pacific/Pago_Pago";
      public const string GMT_01_00_CET_Europe_Vienna = "GMT+01:00-CET-Europe/Vienna";
      public const string GMT_11_00_LHST_Australia_Lord_Howe = "GMT+11:00-LHST-Australia/Lord_Howe";
      public const string GMT_11_00_EST_Australia_Hobart = "GMT+11:00-EST-Australia/Hobart";
      public const string GMT_11_00_EST_Australia_Currie = "GMT+11:00-EST-Australia/Currie";
      public const string GMT_11_00_EST_Australia_Melbourne = "GMT+11:00-EST-Australia/Melbourne";
      public const string GMT_11_00_EST_Australia_Sydney = "GMT+11:00-EST-Australia/Sydney";
      public const string GMT_10_30_CST_Australia_Broken_Hill = "GMT+10:30-CST-Australia/Broken_Hill";
      public const string GMT_10_00_EST_Australia_Brisbane = "GMT+10:00-EST-Australia/Brisbane";
      public const string GMT_10_00_EST_Australia_Lindeman = "GMT+10:00-EST-Australia/Lindeman";
      public const string GMT_10_30_CST_Australia_Adelaide = "GMT+10:30-CST-Australia/Adelaide";
      public const string GMT_09_30_CST_Australia_Darwin = "GMT+09:30-CST-Australia/Darwin";
      public const string GMT_08_00_WST_Australia_Perth = "GMT+08:00-WST-Australia/Perth";
      public const string GMT_08_45_CWST_Australia_Eucla = "GMT+08:45-CWST-Australia/Eucla";
      public const string GMT_04_00_AST_America_Aruba = "GMT-04:00-AST-America/Aruba";
      public const string GMT_02_00_EET_Europe_Mariehamn = "GMT+02:00-EET-Europe/Mariehamn";
      public const string GMT_04_00_AZT_Asia_Baku = "GMT+04:00-AZT-Asia/Baku";
      public const string GMT_01_00_CET_Europe_Sarajevo = "GMT+01:00-CET-Europe/Sarajevo";
      public const string GMT_04_00_AST_America_Barbados = "GMT-04:00-AST-America/Barbados";
      public const string GMT_06_00_BDT_Asia_Dhaka = "GMT+06:00-BDT-Asia/Dhaka";
      public const string GMT_01_00_CET_Europe_Brussels = "GMT+01:00-CET-Europe/Brussels";
      public const string GMT_00_00_GMT_Africa_Ouagadougou = "GMT+00:00-GMT-Africa/Ouagadougou";
      public const string GMT_02_00_EET_Europe_Sofia = "GMT+02:00-EET-Europe/Sofia";
      public const string GMT_03_00_AST_Asia_Bahrain = "GMT+03:00-AST-Asia/Bahrain";
      public const string GMT_02_00_CAT_Africa_Bujumbura = "GMT+02:00-CAT-Africa/Bujumbura";
      public const string GMT_01_00_WAT_Africa_Porto_Novo = "GMT+01:00-WAT-Africa/Porto-Novo";
      public const string GMT_04_00_AST_America_St_Barthelemy = "GMT-04:00-AST-America/St_Barthelemy";
      public const string GMT_03_00_ADT_Atlantic_Bermuda = "GMT-03:00-ADT-Atlantic/Bermuda";
      public const string GMT_08_00_BNT_Asia_Brunei = "GMT+08:00-BNT-Asia/Brunei";
      public const string GMT_04_00_BOT_America_La_Paz = "GMT-04:00-BOT-America/La_Paz";
      public const string GMT_02_00_FNT_America_Noronha = "GMT-02:00-FNT-America/Noronha";
      public const string GMT_03_00_BRT_America_Belem = "GMT-03:00-BRT-America/Belem";
      public const string GMT_03_00_BRT_America_Fortaleza = "GMT-03:00-BRT-America/Fortaleza";
      public const string GMT_03_00_BRT_America_Recife = "GMT-03:00-BRT-America/Recife";
      public const string GMT_03_00_BRT_America_Araguaina = "GMT-03:00-BRT-America/Araguaina";
      public const string GMT_03_00_BRT_America_Maceio = "GMT-03:00-BRT-America/Maceio";
      public const string GMT_03_00_BRT_America_Bahia = "GMT-03:00-BRT-America/Bahia";
      public const string GMT_03_00_BRT_America_Sao_Paulo = "GMT-03:00-BRT-America/Sao_Paulo";
      public const string GMT_04_00_AMT_America_Campo_Grande = "GMT-04:00-AMT-America/Campo_Grande";
      public const string GMT_04_00_AMT_America_Cuiaba = "GMT-04:00-AMT-America/Cuiaba";
      public const string GMT_03_00_BRT_America_Santarem = "GMT-03:00-BRT-America/Santarem";
      public const string GMT_04_00_AMT_America_Porto_Velho = "GMT-04:00-AMT-America/Porto_Velho";
      public const string GMT_04_00_AMT_America_Boa_Vista = "GMT-04:00-AMT-America/Boa_Vista";
      public const string GMT_04_00_AMT_America_Manaus = "GMT-04:00-AMT-America/Manaus";
      public const string GMT_04_00_AMT_America_Eirunepe = "GMT-04:00-AMT-America/Eirunepe";
      public const string GMT_04_00_AMT_America_Rio_Branco = "GMT-04:00-AMT-America/Rio_Branco";
      public const string GMT_04_00_EDT_America_Nassau = "GMT-04:00-EDT-America/Nassau";
      public const string GMT_06_00_BTT_Asia_Thimphu = "GMT+06:00-BTT-Asia/Thimphu";
      public const string GMT_02_00_CAT_Africa_Gaborone = "GMT+02:00-CAT-Africa/Gaborone";
      public const string GMT_03_00_FET_Europe_Minsk = "GMT+03:00-FET-Europe/Minsk";
      public const string GMT_06_00_CST_America_Belize = "GMT-06:00-CST-America/Belize";
      public const string GMT_02_30_NDT_America_St_Johns = "GMT-02:30-NDT-America/St_Johns";
      public const string GMT_03_00_ADT_America_Halifax = "GMT-03:00-ADT-America/Halifax";
      public const string GMT_03_00_ADT_America_Glace_Bay = "GMT-03:00-ADT-America/Glace_Bay";
      public const string GMT_03_00_ADT_America_Moncton = "GMT-03:00-ADT-America/Moncton";
      public const string GMT_03_00_ADT_America_Goose_Bay = "GMT-03:00-ADT-America/Goose_Bay";
      public const string GMT_04_00_AST_America_Blanc_Sablon = "GMT-04:00-AST-America/Blanc-Sablon";
      public const string GMT_04_00_EDT_America_Montreal = "GMT-04:00-EDT-America/Montreal";
      public const string GMT_04_00_EDT_America_Toronto = "GMT-04:00-EDT-America/Toronto";
      public const string GMT_04_00_EDT_America_Nipigon = "GMT-04:00-EDT-America/Nipigon";
      public const string GMT_04_00_EDT_America_Thunder_Bay = "GMT-04:00-EDT-America/Thunder_Bay";
      public const string GMT_04_00_EDT_America_Iqaluit = "GMT-04:00-EDT-America/Iqaluit";
      public const string GMT_04_00_EDT_America_Pangnirtung = "GMT-04:00-EDT-America/Pangnirtung";
      public const string GMT_05_00_CDT_America_Resolute = "GMT-05:00-CDT-America/Resolute";
      public const string GMT_05_00_EST_America_Atikokan = "GMT-05:00-EST-America/Atikokan";
      public const string GMT_05_00_CDT_America_Rankin_Inlet = "GMT-05:00-CDT-America/Rankin_Inlet";
      public const string GMT_05_00_CDT_America_Winnipeg = "GMT-05:00-CDT-America/Winnipeg";
      public const string GMT_05_00_CDT_America_Rainy_River = "GMT-05:00-CDT-America/Rainy_River";
      public const string GMT_06_00_CST_America_Regina = "GMT-06:00-CST-America/Regina";
      public const string GMT_06_00_CST_America_Swift_Current = "GMT-06:00-CST-America/Swift_Current";
      public const string GMT_06_00_MDT_America_Edmonton = "GMT-06:00-MDT-America/Edmonton";
      public const string GMT_06_00_MDT_America_Cambridge_Bay = "GMT-06:00-MDT-America/Cambridge_Bay";
      public const string GMT_06_00_MDT_America_Yellowknife = "GMT-06:00-MDT-America/Yellowknife";
      public const string GMT_06_00_MDT_America_Inuvik = "GMT-06:00-MDT-America/Inuvik";
      public const string GMT_07_00_MST_America_Dawson_Creek = "GMT-07:00-MST-America/Dawson_Creek";
      public const string GMT_07_00_PDT_America_Vancouver = "GMT-07:00-PDT-America/Vancouver";
      public const string GMT_07_00_PDT_America_Whitehorse = "GMT-07:00-PDT-America/Whitehorse";
      public const string GMT_07_00_PDT_America_Dawson = "GMT-07:00-PDT-America/Dawson";
      public const string GMT_06_30_CCT_Indian_Cocos = "GMT+06:30-CCT-Indian/Cocos";
      public const string GMT_01_00_WAT_Africa_Kinshasa = "GMT+01:00-WAT-Africa/Kinshasa";
      public const string GMT_02_00_CAT_Africa_Lubumbashi = "GMT+02:00-CAT-Africa/Lubumbashi";
      public const string GMT_01_00_WAT_Africa_Bangui = "GMT+01:00-WAT-Africa/Bangui";
      public const string GMT_01_00_WAT_Africa_Brazzaville = "GMT+01:00-WAT-Africa/Brazzaville";
      public const string GMT_01_00_CET_Europe_Zurich = "GMT+01:00-CET-Europe/Zurich";
      public const string GMT_00_00_GMT_Africa_Abidjan = "GMT+00:00-GMT-Africa/Abidjan";
      public const string GMT_10_00_CKT_Pacific_Rarotonga = "GMT-10:00-CKT-Pacific/Rarotonga";
      public const string GMT_04_00_CLT_America_Santiago = "GMT-04:00-CLT-America/Santiago";
      public const string GMT_06_00_EAST_Pacific_Easter = "GMT-06:00-EAST-Pacific/Easter";
      public const string GMT_01_00_WAT_Africa_Douala = "GMT+01:00-WAT-Africa/Douala";
      public const string GMT_08_00_CST_Asia_Shanghai = "GMT+08:00-CST-Asia/Shanghai";
      public const string GMT_08_00_CST_Asia_Harbin = "GMT+08:00-CST-Asia/Harbin";
      public const string GMT_08_00_CST_Asia_Chongqing = "GMT+08:00-CST-Asia/Chongqing";
      public const string GMT_08_00_CST_Asia_Urumqi = "GMT+08:00-CST-Asia/Urumqi";
      public const string GMT_08_00_CST_Asia_Kashgar = "GMT+08:00-CST-Asia/Kashgar";
      public const string GMT_05_00_COT_America_Bogota = "GMT-05:00-COT-America/Bogota";
      public const string GMT_06_00_CST_America_Costa_Rica = "GMT-06:00-CST-America/Costa_Rica";
      public const string GMT_04_00_CDT_America_Havana = "GMT-04:00-CDT-America/Havana";
      public const string GMT_01_00_CVT_Atlantic_Cape_Verde = "GMT-01:00-CVT-Atlantic/Cape_Verde";
      public const string GMT_07_00_CXT_Indian_Christmas = "GMT+07:00-CXT-Indian/Christmas";
      public const string GMT_02_00_EET_Asia_Nicosia = "GMT+02:00-EET-Asia/Nicosia";
      public const string GMT_01_00_CET_Europe_Prague = "GMT+01:00-CET-Europe/Prague";
      public const string GMT_01_00_CET_Europe_Berlin = "GMT+01:00-CET-Europe/Berlin";
      public const string GMT_03_00_EAT_Africa_Djibouti = "GMT+03:00-EAT-Africa/Djibouti";
      public const string GMT_01_00_CET_Europe_Copenhagen = "GMT+01:00-CET-Europe/Copenhagen";
      public const string GMT_04_00_AST_America_Dominica = "GMT-04:00-AST-America/Dominica";
      public const string GMT_04_00_AST_America_Santo_Domingo = "GMT-04:00-AST-America/Santo_Domingo";
      public const string GMT_01_00_CET_Africa_Algiers = "GMT+01:00-CET-Africa/Algiers";
      public const string GMT_05_00_ECT_America_Guayaquil = "GMT-05:00-ECT-America/Guayaquil";
      public const string GMT_06_00_GALT_Pacific_Galapagos = "GMT-06:00-GALT-Pacific/Galapagos";
      public const string GMT_02_00_EET_Europe_Tallinn = "GMT+02:00-EET-Europe/Tallinn";
      public const string GMT_02_00_EET_Africa_Cairo = "GMT+02:00-EET-Africa/Cairo";
      public const string GMT_00_00_WET_Africa_El_Aaiun = "GMT+00:00-WET-Africa/El_Aaiun";
      public const string GMT_03_00_EAT_Africa_Asmara = "GMT+03:00-EAT-Africa/Asmara";
      public const string GMT_01_00_CET_Europe_Madrid = "GMT+01:00-CET-Europe/Madrid";
      public const string GMT_01_00_CET_Africa_Ceuta = "GMT+01:00-CET-Africa/Ceuta";
      public const string GMT_00_00_WET_Atlantic_Canary = "GMT+00:00-WET-Atlantic/Canary";
      public const string GMT_03_00_EAT_Africa_Addis_Ababa = "GMT+03:00-EAT-Africa/Addis_Ababa";
      public const string GMT_02_00_EET_Europe_Helsinki = "GMT+02:00-EET-Europe/Helsinki";
      public const string GMT_12_00_FJT_Pacific_Fiji = "GMT+12:00-FJT-Pacific/Fiji";
      public const string GMT_03_00_FKST_Atlantic_Stanley = "GMT-03:00-FKST-Atlantic/Stanley";
      public const string GMT_10_00_CHUT_Pacific_Chuuk = "GMT+10:00-CHUT-Pacific/Chuuk";
      public const string GMT_11_00_PONT_Pacific_Pohnpei = "GMT+11:00-PONT-Pacific/Pohnpei";
      public const string GMT_11_00_KOST_Pacific_Kosrae = "GMT+11:00-KOST-Pacific/Kosrae";
      public const string GMT_00_00_WET_Atlantic_Faroe = "GMT+00:00-WET-Atlantic/Faroe";
      public const string GMT_01_00_CET_Europe_Paris = "GMT+01:00-CET-Europe/Paris";
      public const string GMT_01_00_WAT_Africa_Libreville = "GMT+01:00-WAT-Africa/Libreville";
      public const string GMT_00_00_GMT_Europe_London = "GMT+00:00-GMT-Europe/London";
      public const string GMT_04_00_AST_America_Grenada = "GMT-04:00-AST-America/Grenada";
      public const string GMT_04_00_GET_Asia_Tbilisi = "GMT+04:00-GET-Asia/Tbilisi";
      public const string GMT_03_00_GFT_America_Cayenne = "GMT-03:00-GFT-America/Cayenne";
      public const string GMT_00_00_GMT_Europe_Guernsey = "GMT+00:00-GMT-Europe/Guernsey";
      public const string GMT_00_00_GMT_Africa_Accra = "GMT+00:00-GMT-Africa/Accra";
      public const string GMT_01_00_CET_Europe_Gibraltar = "GMT+01:00-CET-Europe/Gibraltar";
      public const string GMT_03_00_WGT_America_Godthab = "GMT-03:00-WGT-America/Godthab";
      public const string GMT_00_00_GMT_America_Danmarkshavn = "GMT+00:00-GMT-America/Danmarkshavn";
      public const string GMT_01_00_EGT_America_Scoresbysund = "GMT-01:00-EGT-America/Scoresbysund";
      public const string GMT_03_00_ADT_America_Thule = "GMT-03:00-ADT-America/Thule";
      public const string GMT_00_00_GMT_Africa_Banjul = "GMT+00:00-GMT-Africa/Banjul";
      public const string GMT_00_00_GMT_Africa_Conakry = "GMT+00:00-GMT-Africa/Conakry";
      public const string GMT_04_00_AST_America_Guadeloupe = "GMT-04:00-AST-America/Guadeloupe";
      public const string GMT_01_00_WAT_Africa_Malabo = "GMT+01:00-WAT-Africa/Malabo";
      public const string GMT_02_00_EET_Europe_Athens = "GMT+02:00-EET-Europe/Athens";
      public const string GMT_02_00_GST_Atlantic_South_Georgia = "GMT-02:00-GST-Atlantic/South_Georgia";
      public const string GMT_06_00_CST_America_Guatemala = "GMT-06:00-CST-America/Guatemala";
      public const string GMT_10_00_ChST_Pacific_Guam = "GMT+10:00-ChST-Pacific/Guam";
      public const string GMT_00_00_GMT_Africa_Bissau = "GMT+00:00-GMT-Africa/Bissau";
      public const string GMT_04_00_GYT_America_Guyana = "GMT-04:00-GYT-America/Guyana";
      public const string GMT_08_00_HKT_Asia_Hong_Kong = "GMT+08:00-HKT-Asia/Hong_Kong";
      public const string GMT_06_00_CST_America_Tegucigalpa = "GMT-06:00-CST-America/Tegucigalpa";
      public const string GMT_01_00_CET_Europe_Zagreb = "GMT+01:00-CET-Europe/Zagreb";
      public const string GMT_05_00_EST_America_Port_au_Prince = "GMT-05:00-EST-America/Port-au-Prince";
      public const string GMT_01_00_CET_Europe_Budapest = "GMT+01:00-CET-Europe/Budapest";
      public const string GMT_07_00_WIT_Asia_Jakarta = "GMT+07:00-WIT-Asia/Jakarta";
      public const string GMT_07_00_WIT_Asia_Pontianak = "GMT+07:00-WIT-Asia/Pontianak";
      public const string GMT_08_00_CIT_Asia_Makassar = "GMT+08:00-CIT-Asia/Makassar";
      public const string GMT_09_00_EIT_Asia_Jayapura = "GMT+09:00-EIT-Asia/Jayapura";
      public const string GMT_00_00_GMT_Europe_Dublin = "GMT+00:00-GMT-Europe/Dublin";
      public const string GMT_02_00_IST_Asia_Jerusalem = "GMT+02:00-IST-Asia/Jerusalem";
      public const string GMT_00_00_GMT_Europe_Isle_of_Man = "GMT+00:00-GMT-Europe/Isle_of_Man";
      public const string GMT_05_30_IST_Asia_Kolkata = "GMT+05:30-IST-Asia/Kolkata";
      public const string GMT_06_00_IOT_Indian_Chagos = "GMT+06:00-IOT-Indian/Chagos";
      public const string GMT_03_00_AST_Asia_Baghdad = "GMT+03:00-AST-Asia/Baghdad";
      public const string GMT_03_30_IRST_Asia_Tehran = "GMT+03:30-IRST-Asia/Tehran";
      public const string GMT_00_00_GMT_Atlantic_Reykjavik = "GMT+00:00-GMT-Atlantic/Reykjavik";
      public const string GMT_01_00_CET_Europe_Rome = "GMT+01:00-CET-Europe/Rome";
      public const string GMT_00_00_GMT_Europe_Jersey = "GMT+00:00-GMT-Europe/Jersey";
      public const string GMT_05_00_EST_America_Jamaica = "GMT-05:00-EST-America/Jamaica";
      public const string GMT_02_00_EET_Asia_Amman = "GMT+02:00-EET-Asia/Amman";
      public const string GMT_09_00_JST_Asia_Tokyo = "GMT+09:00-JST-Asia/Tokyo";
      public const string GMT_03_00_EAT_Africa_Nairobi = "GMT+03:00-EAT-Africa/Nairobi";
      public const string GMT_06_00_KGT_Asia_Bishkek = "GMT+06:00-KGT-Asia/Bishkek";
      public const string GMT_07_00_ICT_Asia_Phnom_Penh = "GMT+07:00-ICT-Asia/Phnom_Penh";
      public const string GMT_12_00_GILT_Pacific_Tarawa = "GMT+12:00-GILT-Pacific/Tarawa";
      public const string GMT_13_00_PHOT_Pacific_Enderbury = "GMT+13:00-PHOT-Pacific/Enderbury";
      public const string GMT_14_00_LINT_Pacific_Kiritimati = "GMT+14:00-LINT-Pacific/Kiritimati";
      public const string GMT_03_00_EAT_Indian_Comoro = "GMT+03:00-EAT-Indian/Comoro";
      public const string GMT_04_00_AST_America_St_Kitts = "GMT-04:00-AST-America/St_Kitts";
      public const string GMT_09_00_KST_Asia_Pyongyang = "GMT+09:00-KST-Asia/Pyongyang";
      public const string GMT_09_00_KST_Asia_Seoul = "GMT+09:00-KST-Asia/Seoul";
      public const string GMT_03_00_AST_Asia_Kuwait = "GMT+03:00-AST-Asia/Kuwait";
      public const string GMT_05_00_EST_America_Cayman = "GMT-05:00-EST-America/Cayman";
      public const string GMT_06_00_ALMT_Asia_Almaty = "GMT+06:00-ALMT-Asia/Almaty";
      public const string GMT_06_00_QYZT_Asia_Qyzylorda = "GMT+06:00-QYZT-Asia/Qyzylorda";
      public const string GMT_05_00_AQTT_Asia_Aqtobe = "GMT+05:00-AQTT-Asia/Aqtobe";
      public const string GMT_05_00_AQTT_Asia_Aqtau = "GMT+05:00-AQTT-Asia/Aqtau";
      public const string GMT_05_00_ORAT_Asia_Oral = "GMT+05:00-ORAT-Asia/Oral";
      public const string GMT_07_00_ICT_Asia_Vientiane = "GMT+07:00-ICT-Asia/Vientiane";
      public const string GMT_02_00_EET_Asia_Beirut = "GMT+02:00-EET-Asia/Beirut";
      public const string GMT_04_00_AST_America_St_Lucia = "GMT-04:00-AST-America/St_Lucia";
      public const string GMT_01_00_CET_Europe_Vaduz = "GMT+01:00-CET-Europe/Vaduz";
      public const string GMT_05_30_IST_Asia_Colombo = "GMT+05:30-IST-Asia/Colombo";
      public const string GMT_00_00_GMT_Africa_Monrovia = "GMT+00:00-GMT-Africa/Monrovia";
      public const string GMT_02_00_SAST_Africa_Maseru = "GMT+02:00-SAST-Africa/Maseru";
      public const string GMT_02_00_EET_Europe_Vilnius = "GMT+02:00-EET-Europe/Vilnius";
      public const string GMT_01_00_CET_Europe_Luxembourg = "GMT+01:00-CET-Europe/Luxembourg";
      public const string GMT_02_00_EET_Europe_Riga = "GMT+02:00-EET-Europe/Riga";
      public const string GMT_02_00_EET_Africa_Tripoli = "GMT+02:00-EET-Africa/Tripoli";
      public const string GMT_00_00_WET_Africa_Casablanca = "GMT+00:00-WET-Africa/Casablanca";
      public const string GMT_01_00_CET_Europe_Monaco = "GMT+01:00-CET-Europe/Monaco";
      public const string GMT_02_00_EET_Europe_Chisinau = "GMT+02:00-EET-Europe/Chisinau";
      public const string GMT_01_00_CET_Europe_Podgorica = "GMT+01:00-CET-Europe/Podgorica";
      public const string GMT_04_00_AST_America_Marigot = "GMT-04:00-AST-America/Marigot";
      public const string GMT_03_00_EAT_Indian_Antananarivo = "GMT+03:00-EAT-Indian/Antananarivo";
      public const string GMT_12_00_MHT_Pacific_Majuro = "GMT+12:00-MHT-Pacific/Majuro";
      public const string GMT_12_00_MHT_Pacific_Kwajalein = "GMT+12:00-MHT-Pacific/Kwajalein";
      public const string GMT_01_00_CET_Europe_Skopje = "GMT+01:00-CET-Europe/Skopje";
      public const string GMT_00_00_GMT_Africa_Bamako = "GMT+00:00-GMT-Africa/Bamako";
      public const string GMT_06_30_MMT_Asia_Rangoon = "GMT+06:30-MMT-Asia/Rangoon";
      public const string GMT_08_00_ULAT_Asia_Ulaanbaatar = "GMT+08:00-ULAT-Asia/Ulaanbaatar";
      public const string GMT_07_00_HOVT_Asia_Hovd = "GMT+07:00-HOVT-Asia/Hovd";
      public const string GMT_08_00_CHOT_Asia_Choibalsan = "GMT+08:00-CHOT-Asia/Choibalsan";
      public const string GMT_08_00_CST_Asia_Macau = "GMT+08:00-CST-Asia/Macau";
      public const string GMT_10_00_ChST_Pacific_Saipan = "GMT+10:00-ChST-Pacific/Saipan";
      public const string GMT_04_00_AST_America_Martinique = "GMT-04:00-AST-America/Martinique";
      public const string GMT_00_00_GMT_Africa_Nouakchott = "GMT+00:00-GMT-Africa/Nouakchott";
      public const string GMT_04_00_AST_America_Montserrat = "GMT-04:00-AST-America/Montserrat";
      public const string GMT_01_00_CET_Europe_Malta = "GMT+01:00-CET-Europe/Malta";
      public const string GMT_04_00_MUT_Indian_Mauritius = "GMT+04:00-MUT-Indian/Mauritius";
      public const string GMT_05_00_MVT_Indian_Maldives = "GMT+05:00-MVT-Indian/Maldives";
      public const string GMT_02_00_CAT_Africa_Blantyre = "GMT+02:00-CAT-Africa/Blantyre";
      public const string GMT_06_00_CST_America_Mexico_City = "GMT-06:00-CST-America/Mexico_City";
      public const string GMT_06_00_CST_America_Cancun = "GMT-06:00-CST-America/Cancun";
      public const string GMT_06_00_CST_America_Merida = "GMT-06:00-CST-America/Merida";
      public const string GMT_06_00_CST_America_Monterrey = "GMT-06:00-CST-America/Monterrey";
      public const string GMT_05_00_CDT_America_Matamoros = "GMT-05:00-CDT-America/Matamoros";
      public const string GMT_07_00_MST_America_Mazatlan = "GMT-07:00-MST-America/Mazatlan";
      public const string GMT_07_00_MST_America_Chihuahua = "GMT-07:00-MST-America/Chihuahua";
      public const string GMT_06_00_MDT_America_Ojinaga = "GMT-06:00-MDT-America/Ojinaga";
      public const string GMT_07_00_MST_America_Hermosillo = "GMT-07:00-MST-America/Hermosillo";
      public const string GMT_07_00_PDT_America_Tijuana = "GMT-07:00-PDT-America/Tijuana";
      public const string GMT_08_00_PST_America_Santa_Isabel = "GMT-08:00-PST-America/Santa_Isabel";
      public const string GMT_06_00_CST_America_Bahia_Banderas = "GMT-06:00-CST-America/Bahia_Banderas";
      public const string GMT_08_00_MYT_Asia_Kuala_Lumpur = "GMT+08:00-MYT-Asia/Kuala_Lumpur";
      public const string GMT_08_00_MYT_Asia_Kuching = "GMT+08:00-MYT-Asia/Kuching";
      public const string GMT_02_00_CAT_Africa_Maputo = "GMT+02:00-CAT-Africa/Maputo";
      public const string GMT_02_00_WAST_Africa_Windhoek = "GMT+02:00-WAST-Africa/Windhoek";
      public const string GMT_11_00_NCT_Pacific_Noumea = "GMT+11:00-NCT-Pacific/Noumea";
      public const string GMT_01_00_WAT_Africa_Niamey = "GMT+01:00-WAT-Africa/Niamey";
      public const string GMT_11_30_NFT_Pacific_Norfolk = "GMT+11:30-NFT-Pacific/Norfolk";
      public const string GMT_01_00_WAT_Africa_Lagos = "GMT+01:00-WAT-Africa/Lagos";
      public const string GMT_06_00_CST_America_Managua = "GMT-06:00-CST-America/Managua";
      public const string GMT_01_00_CET_Europe_Amsterdam = "GMT+01:00-CET-Europe/Amsterdam";
      public const string GMT_01_00_CET_Europe_Oslo = "GMT+01:00-CET-Europe/Oslo";
      public const string GMT_05_45_NPT_Asia_Kathmandu = "GMT+05:45-NPT-Asia/Kathmandu";
      public const string GMT_12_00_NRT_Pacific_Nauru = "GMT+12:00-NRT-Pacific/Nauru";
      public const string GMT_11_00_NUT_Pacific_Niue = "GMT-11:00-NUT-Pacific/Niue";
      public const string GMT_13_00_NZDT_Pacific_Auckland = "GMT+13:00-NZDT-Pacific/Auckland";
      public const string GMT_13_45_CHADT_Pacific_Chatham = "GMT+13:45-CHADT-Pacific/Chatham";
      public const string GMT_04_00_GST_Asia_Muscat = "GMT+04:00-GST-Asia/Muscat";
      public const string GMT_05_00_EST_America_Panama = "GMT-05:00-EST-America/Panama";
      public const string GMT_05_00_PET_America_Lima = "GMT-05:00-PET-America/Lima";
      public const string GMT_10_00_TAHT_Pacific_Tahiti = "GMT-10:00-TAHT-Pacific/Tahiti";
      public const string GMT_09_30_MART_Pacific_Marquesas = "GMT-09:30-MART-Pacific/Marquesas";
      public const string GMT_09_00_GAMT_Pacific_Gambier = "GMT-09:00-GAMT-Pacific/Gambier";
      public const string GMT_10_00_PGT_Pacific_Port_Moresby = "GMT+10:00-PGT-Pacific/Port_Moresby";
      public const string GMT_08_00_PHT_Asia_Manila = "GMT+08:00-PHT-Asia/Manila";
      public const string GMT_05_00_PKT_Asia_Karachi = "GMT+05:00-PKT-Asia/Karachi";
      public const string GMT_01_00_CET_Europe_Warsaw = "GMT+01:00-CET-Europe/Warsaw";
      public const string GMT_02_00_PMDT_America_Miquelon = "GMT-02:00-PMDT-America/Miquelon";
      public const string GMT_08_00_PST_Pacific_Pitcairn = "GMT-08:00-PST-Pacific/Pitcairn";
      public const string GMT_04_00_AST_America_Puerto_Rico = "GMT-04:00-AST-America/Puerto_Rico";
      public const string GMT_02_00_EET_Asia_Gaza = "GMT+02:00-EET-Asia/Gaza";
      public const string GMT_02_00_EET_Asia_Hebron = "GMT+02:00-EET-Asia/Hebron";
      public const string GMT_00_00_WET_Europe_Lisbon = "GMT+00:00-WET-Europe/Lisbon";
      public const string GMT_00_00_WET_Atlantic_Madeira = "GMT+00:00-WET-Atlantic/Madeira";
      public const string GMT_01_00_AZOT_Atlantic_Azores = "GMT-01:00-AZOT-Atlantic/Azores";
      public const string GMT_09_00_PWT_Pacific_Palau = "GMT+09:00-PWT-Pacific/Palau";
      public const string GMT_03_00_PYST_America_Asuncion = "GMT-03:00-PYST-America/Asuncion";
      public const string GMT_03_00_AST_Asia_Qatar = "GMT+03:00-AST-Asia/Qatar";
      public const string GMT_04_00_RET_Indian_Reunion = "GMT+04:00-RET-Indian/Reunion";
      public const string GMT_02_00_EET_Europe_Bucharest = "GMT+02:00-EET-Europe/Bucharest";
      public const string GMT_01_00_CET_Europe_Belgrade = "GMT+01:00-CET-Europe/Belgrade";
      public const string GMT_03_00_FET_Europe_Kaliningrad = "GMT+03:00-FET-Europe/Kaliningrad";
      public const string GMT_04_00_MSK_Europe_Moscow = "GMT+04:00-MSK-Europe/Moscow";
      public const string GMT_04_00_VOLT_Europe_Volgograd = "GMT+04:00-VOLT-Europe/Volgograd";
      public const string GMT_04_00_SAMT_Europe_Samara = "GMT+04:00-SAMT-Europe/Samara";
      public const string GMT_06_00_YEKT_Asia_Yekaterinburg = "GMT+06:00-YEKT-Asia/Yekaterinburg";
      public const string GMT_07_00_OMST_Asia_Omsk = "GMT+07:00-OMST-Asia/Omsk";
      public const string GMT_07_00_NOVT_Asia_Novosibirsk = "GMT+07:00-NOVT-Asia/Novosibirsk";
      public const string GMT_07_00_NOVT_Asia_Novokuznetsk = "GMT+07:00-NOVT-Asia/Novokuznetsk";
      public const string GMT_08_00_KRAT_Asia_Krasnoyarsk = "GMT+08:00-KRAT-Asia/Krasnoyarsk";
      public const string GMT_09_00_IRKT_Asia_Irkutsk = "GMT+09:00-IRKT-Asia/Irkutsk";
      public const string GMT_10_00_YAKT_Asia_Yakutsk = "GMT+10:00-YAKT-Asia/Yakutsk";
      public const string GMT_11_00_VLAT_Asia_Vladivostok = "GMT+11:00-VLAT-Asia/Vladivostok";
      public const string GMT_11_00_SAKT_Asia_Sakhalin = "GMT+11:00-SAKT-Asia/Sakhalin";
      public const string GMT_12_00_MAGT_Asia_Magadan = "GMT+12:00-MAGT-Asia/Magadan";
      public const string GMT_12_00_PETT_Asia_Kamchatka = "GMT+12:00-PETT-Asia/Kamchatka";
      public const string GMT_12_00_ANAT_Asia_Anadyr = "GMT+12:00-ANAT-Asia/Anadyr";
      public const string GMT_02_00_CAT_Africa_Kigali = "GMT+02:00-CAT-Africa/Kigali";
      public const string GMT_03_00_AST_Asia_Riyadh = "GMT+03:00-AST-Asia/Riyadh";
      public const string GMT_11_00_SBT_Pacific_Guadalcanal = "GMT+11:00-SBT-Pacific/Guadalcanal";
      public const string GMT_04_00_SCT_Indian_Mahe = "GMT+04:00-SCT-Indian/Mahe";
      public const string GMT_03_00_EAT_Africa_Khartoum = "GMT+03:00-EAT-Africa/Khartoum";
      public const string GMT_01_00_CET_Europe_Stockholm = "GMT+01:00-CET-Europe/Stockholm";
      public const string GMT_08_00_SGT_Asia_Singapore = "GMT+08:00-SGT-Asia/Singapore";
      public const string GMT_00_00_GMT_Atlantic_St_Helena = "GMT+00:00-GMT-Atlantic/St_Helena";
      public const string GMT_01_00_CET_Europe_Ljubljana = "GMT+01:00-CET-Europe/Ljubljana";
      public const string GMT_01_00_CET_Arctic_Longyearbyen = "GMT+01:00-CET-Arctic/Longyearbyen";
      public const string GMT_01_00_CET_Europe_Bratislava = "GMT+01:00-CET-Europe/Bratislava";
      public const string GMT_00_00_GMT_Africa_Freetown = "GMT+00:00-GMT-Africa/Freetown";
      public const string GMT_01_00_CET_Europe_San_Marino = "GMT+01:00-CET-Europe/San_Marino";
      public const string GMT_00_00_GMT_Africa_Dakar = "GMT+00:00-GMT-Africa/Dakar";
      public const string GMT_03_00_EAT_Africa_Mogadishu = "GMT+03:00-EAT-Africa/Mogadishu";
      public const string GMT_03_00_SRT_America_Paramaribo = "GMT-03:00-SRT-America/Paramaribo";
      public const string GMT_00_00_GMT_Africa_Sao_Tome = "GMT+00:00-GMT-Africa/Sao_Tome";
      public const string GMT_06_00_CST_America_El_Salvador = "GMT-06:00-CST-America/El_Salvador";
      public const string GMT_02_00_EET_Asia_Damascus = "GMT+02:00-EET-Asia/Damascus";
      public const string GMT_02_00_SAST_Africa_Mbabane = "GMT+02:00-SAST-Africa/Mbabane";
      public const string GMT_04_00_EDT_America_Grand_Turk = "GMT-04:00-EDT-America/Grand_Turk";
      public const string GMT_01_00_WAT_Africa_Ndjamena = "GMT+01:00-WAT-Africa/Ndjamena";
      public const string GMT_05_00_TFT_Indian_Kerguelen = "GMT+05:00-TFT-Indian/Kerguelen";
      public const string GMT_00_00_GMT_Africa_Lome = "GMT+00:00-GMT-Africa/Lome";
      public const string GMT_07_00_ICT_Asia_Bangkok = "GMT+07:00-ICT-Asia/Bangkok";
      public const string GMT_05_00_TJT_Asia_Dushanbe = "GMT+05:00-TJT-Asia/Dushanbe";
      public const string GMT_10_00_TKT_Pacific_Fakaofo = "GMT-10:00-TKT-Pacific/Fakaofo";
      public const string GMT_09_00_TLT_Asia_Dili = "GMT+09:00-TLT-Asia/Dili";
      public const string GMT_05_00_TMT_Asia_Ashgabat = "GMT+05:00-TMT-Asia/Ashgabat";
      public const string GMT_01_00_CET_Africa_Tunis = "GMT+01:00-CET-Africa/Tunis";
      public const string GMT_13_00_TOT_Pacific_Tongatapu = "GMT+13:00-TOT-Pacific/Tongatapu";
      public const string GMT_02_00_EET_Europe_Istanbul = "GMT+02:00-EET-Europe/Istanbul";
      public const string GMT_04_00_AST_America_Port_of_Spain = "GMT-04:00-AST-America/Port_of_Spain";
      public const string GMT_12_00_TVT_Pacific_Funafuti = "GMT+12:00-TVT-Pacific/Funafuti";
      public const string GMT_08_00_CST_Asia_Taipei = "GMT+08:00-CST-Asia/Taipei";
      public const string GMT_03_00_EAT_Africa_Dar_es_Salaam = "GMT+03:00-EAT-Africa/Dar_es_Salaam";
      public const string GMT_02_00_EET_Europe_Kiev = "GMT+02:00-EET-Europe/Kiev";
      public const string GMT_02_00_EET_Europe_Uzhgorod = "GMT+02:00-EET-Europe/Uzhgorod";
      public const string GMT_02_00_EET_Europe_Zaporozhye = "GMT+02:00-EET-Europe/Zaporozhye";
      public const string GMT_02_00_EET_Europe_Simferopol = "GMT+02:00-EET-Europe/Simferopol";
      public const string GMT_03_00_EAT_Africa_Kampala = "GMT+03:00-EAT-Africa/Kampala";
      public const string GMT_10_00_HST_Pacific_Johnston = "GMT-10:00-HST-Pacific/Johnston";
      public const string GMT_11_00_SST_Pacific_Midway = "GMT-11:00-SST-Pacific/Midway";
      public const string GMT_12_00_WAKT_Pacific_Wake = "GMT+12:00-WAKT-Pacific/Wake";
      public const string GMT_04_00_EDT_America_New_York = "GMT-04:00-EDT-America/New_York";
      public const string GMT_04_00_EDT_America_Detroit = "GMT-04:00-EDT-America/Detroit";
      public const string GMT_04_00_EDT_America_Kentucky_Louisville = "GMT-04:00-EDT-America/Kentucky/Louisville";
      public const string GMT_04_00_EDT_America_Kentucky_Monticello = "GMT-04:00-EDT-America/Kentucky/Monticello";
      public const string GMT_04_00_EDT_America_Indiana_Indianapolis = "GMT-04:00-EDT-America/Indiana/Indianapolis";
      public const string GMT_04_00_EDT_America_Indiana_Vincennes = "GMT-04:00-EDT-America/Indiana/Vincennes";
      public const string GMT_04_00_EDT_America_Indiana_Winamac = "GMT-04:00-EDT-America/Indiana/Winamac";
      public const string GMT_04_00_EDT_America_Indiana_Marengo = "GMT-04:00-EDT-America/Indiana/Marengo";
      public const string GMT_04_00_EDT_America_Indiana_Petersburg = "GMT-04:00-EDT-America/Indiana/Petersburg";
      public const string GMT_04_00_EDT_America_Indiana_Vevay = "GMT-04:00-EDT-America/Indiana/Vevay";
      public const string GMT_05_00_CDT_America_Chicago = "GMT-05:00-CDT-America/Chicago";
      public const string GMT_05_00_CDT_America_Indiana_Tell_City = "GMT-05:00-CDT-America/Indiana/Tell_City";
      public const string GMT_05_00_CDT_America_Indiana_Knox = "GMT-05:00-CDT-America/Indiana/Knox";
      public const string GMT_05_00_CDT_America_Menominee = "GMT-05:00-CDT-America/Menominee";
      public const string GMT_05_00_CDT_America_North_Dakota_Center = "GMT-05:00-CDT-America/North_Dakota/Center";
      public const string GMT_05_00_CDT_America_North_Dakota_New_Salem = "GMT-05:00-CDT-America/North_Dakota/New_Salem";
      public const string GMT_05_00_CDT_America_North_Dakota_Beulah = "GMT-05:00-CDT-America/North_Dakota/Beulah";
      public const string GMT_06_00_MDT_America_Denver = "GMT-06:00-MDT-America/Denver";
      public const string GMT_06_00_MDT_America_Boise = "GMT-06:00-MDT-America/Boise";
      public const string GMT_06_00_MDT_America_Shiprock = "GMT-06:00-MDT-America/Shiprock";
      public const string GMT_07_00_MST_America_Phoenix = "GMT-07:00-MST-America/Phoenix";
      public const string GMT_07_00_PDT_America_Los_Angeles = "GMT-07:00-PDT-America/Los_Angeles";
      public const string GMT_08_00_AKDT_America_Anchorage = "GMT-08:00-AKDT-America/Anchorage";
      public const string GMT_08_00_AKDT_America_Juneau = "GMT-08:00-AKDT-America/Juneau";
      public const string GMT_08_00_AKDT_America_Sitka = "GMT-08:00-AKDT-America/Sitka";
      public const string GMT_08_00_AKDT_America_Yakutat = "GMT-08:00-AKDT-America/Yakutat";
      public const string GMT_08_00_AKDT_America_Nome = "GMT-08:00-AKDT-America/Nome";
      public const string GMT_09_00_HADT_America_Adak = "GMT-09:00-HADT-America/Adak";
      public const string GMT_08_00_MeST_America_Metlakatla = "GMT-08:00-MeST-America/Metlakatla";
      public const string GMT_10_00_HST_Pacific_Honolulu = "GMT-10:00-HST-Pacific/Honolulu";
      public const string GMT_03_00_UYT_America_Montevideo = "GMT-03:00-UYT-America/Montevideo";
      public const string GMT_05_00_UZT_Asia_Samarkand = "GMT+05:00-UZT-Asia/Samarkand";
      public const string GMT_05_00_UZT_Asia_Tashkent = "GMT+05:00-UZT-Asia/Tashkent";
      public const string GMT_01_00_CET_Europe_Vatican = "GMT+01:00-CET-Europe/Vatican";
      public const string GMT_04_00_AST_America_St_Vincent = "GMT-04:00-AST-America/St_Vincent";
      public const string GMT_04_30_VET_America_Caracas = "GMT-04:30-VET-America/Caracas";
      public const string GMT_04_00_AST_America_Tortola = "GMT-04:00-AST-America/Tortola";
      public const string GMT_04_00_AST_America_St_Thomas = "GMT-04:00-AST-America/St_Thomas";
      public const string GMT_07_00_ICT_Asia_Ho_Chi_Minh = "GMT+07:00-ICT-Asia/Ho_Chi_Minh";
      public const string GMT_11_00_VUT_Pacific_Efate = "GMT+11:00-VUT-Pacific/Efate";
      public const string GMT_12_00_WFT_Pacific_Wallis = "GMT+12:00-WFT-Pacific/Wallis";
      public const string GMT_14_00_WSDT_Pacific_Apia = "GMT+14:00-WSDT-Pacific/Apia";
      public const string GMT_03_00_AST_Asia_Aden = "GMT+03:00-AST-Asia/Aden";
      public const string GMT_03_00_EAT_Indian_Mayotte = "GMT+03:00-EAT-Indian/Mayotte";
      public const string GMT_02_00_SAST_Africa_Johannesburg = "GMT+02:00-SAST-Africa/Johannesburg";
      public const string GMT_02_00_CAT_Africa_Lusaka = "GMT+02:00-CAT-Africa/Lusaka";
      public const string GMT_02_00_CAT_Africa_Harare = "GMT+02:00-CAT-Africa/Harare";
    }

    public static class systemtypeEnum
    {
      public const string Stand_alone = "Stand-alone";
      public const string HA = "HA";
      public const string Cluster = "Cluster";
    }

    public static class securecookieEnum
    {
      public const string ENABLED = "ENABLED";
      public const string DISABLED = "DISABLED";
    }

    public static class levelEnum
    {
      public const string basic = "basic";
      public const string extended = "extended";
      public const string full = "full";
    }

    public static class cipEnum
    {
      public const string ENABLED = "ENABLED";
      public const string DISABLED = "DISABLED";
    }

    public static class taggedEnum
    {
      public const string YES = "YES";
      public const string NO = "NO";
    }

    public static class cookieversionEnum
    {
      public const string _0 = "0";
      public const string _1 = "1";
    }
  }
}
