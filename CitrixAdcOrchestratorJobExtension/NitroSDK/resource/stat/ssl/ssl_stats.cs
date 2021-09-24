// Decompiled with JetBrains decompiler
// Type: com.citrix.netscaler.nitro.resource.stat.ssl.ssl_stats
// Assembly: nitro, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 6CF5DDEF-E052-4F9D-953F-6644F8378A66


using com.citrix.netscaler.nitro.exception;
using com.citrix.netscaler.nitro.resource.Base;
using com.citrix.netscaler.nitro.service;

namespace com.citrix.netscaler.nitro.resource.stat.ssl
{
  public class ssl_stats : base_resource
  {
    private string clearstatsField = (string) null;
    private double sslcryptoutilizationstatField = 0.0;
    private long sslnumcardsupField = 0;
    private long sslcardstatusField = 0;
    private long sslcardsField = 0;
    private long sslenginestatusField = 0;
    private long ssltotsessionsField = 0;
    private long sslsessionsrateField = 0;
    private long ssltottransactionsField = 0;
    private long ssltransactionsrateField = 0;
    private long ssltotsslv2transactionsField = 0;
    private long sslsslv2transactionsrateField = 0;
    private long ssltotsslv3transactionsField = 0;
    private long sslsslv3transactionsrateField = 0;
    private long ssltottlsv1transactionsField = 0;
    private long ssltlsv1transactionsrateField = 0;
    private long ssltottlsv11transactionsField = 0;
    private long ssltlsv11transactionsrateField = 0;
    private long ssltottlsv12transactionsField = 0;
    private long ssltlsv12transactionsrateField = 0;
    private long ssltotsslv2sessionsField = 0;
    private long sslsslv2sessionsrateField = 0;
    private long ssltotsslv3sessionsField = 0;
    private long sslsslv3sessionsrateField = 0;
    private long ssltottlsv1sessionsField = 0;
    private long ssltlsv1sessionsrateField = 0;
    private long ssltottlsv11sessionsField = 0;
    private long ssltlsv11sessionsrateField = 0;
    private long ssltottlsv12sessionsField = 0;
    private long ssltlsv12sessionsrateField = 0;
    private long ssltotnewsessionsField = 0;
    private long sslnewsessionsrateField = 0;
    private long ssltotsessionmissField = 0;
    private long sslsessionmissrateField = 0;
    private long ssltotsessionhitsField = 0;
    private long sslsessionhitsrateField = 0;
    private long sslbetotsessionsField = 0;
    private long sslbesessionsrateField = 0;
    private long sslbetotsslv3sessionsField = 0;
    private long sslbesslv3sessionsrateField = 0;
    private long sslbetottlsv1sessionsField = 0;
    private long sslbetlsv1sessionsrateField = 0;
    private long sslbetottlsv11sessionsField = 0;
    private long sslbetlsv11sessionsrateField = 0;
    private long sslbetottlsv12sessionsField = 0;
    private long sslbetlsv12sessionsrateField = 0;
    private long sslbetotsessionmultiplexattemptsField = 0;
    private long sslbesessionmultiplexattemptsrateField = 0;
    private long sslbetotsessionmultiplexattemptsuccessField = 0;
    private long sslbesessionmultiplexattemptsuccessrateField = 0;
    private long sslbetotsessionmultiplexattemptfailsField = 0;
    private long sslbesessionmultiplexattemptfailsrateField = 0;
    private long ssltotencField = 0;
    private long sslencrateField = 0;
    private long ssltotdecField = 0;
    private long ssldecrateField = 0;
    private long ssltotrenegsessionsField = 0;
    private long sslrenegsessionsrateField = 0;
    private long ssltotsslv3renegsessionsField = 0;
    private long sslsslv3renegsessionsrateField = 0;
    private long ssltottlsv1renegsessionsField = 0;
    private long ssltlsv1renegsessionsrateField = 0;
    private long ssltottlsv11renegsessionsField = 0;
    private long ssltlsv11renegsessionsrateField = 0;
    private long ssltottlsv12renegsessionsField = 0;
    private long ssltlsv12renegsessionsrateField = 0;
    private long ssltotrsa512keyexchangesField = 0;
    private long sslrsa512keyexchangesrateField = 0;
    private long ssltotrsa1024keyexchangesField = 0;
    private long sslrsa1024keyexchangesrateField = 0;
    private long ssltotrsa2048keyexchangesField = 0;
    private long sslrsa2048keyexchangesrateField = 0;
    private long ssltotrsa4096keyexchangesField = 0;
    private long sslrsa4096keyexchangesrateField = 0;
    private long ssltotdh512keyexchangesField = 0;
    private long ssldh512keyexchangesrateField = 0;
    private long ssltotdh1024keyexchangesField = 0;
    private long ssldh1024keyexchangesrateField = 0;
    private long ssltotdh2048keyexchangesField = 0;
    private long ssldh2048keyexchangesrateField = 0;
    private long ssltotecdhe521keyexchangesField = 0;
    private long sslecdhe521keyexchangesrateField = 0;
    private long ssltotecdhe384keyexchangesField = 0;
    private long sslecdhe384keyexchangesrateField = 0;
    private long ssltotecdhe256keyexchangesField = 0;
    private long sslecdhe256keyexchangesrateField = 0;
    private long ssltotecdhe224keyexchangesField = 0;
    private long sslecdhe224keyexchangesrateField = 0;
    private long ssltot40bitrc4ciphersField = 0;
    private long ssl40bitrc4ciphersrateField = 0;
    private long ssltot56bitrc4ciphersField = 0;
    private long ssl56bitrc4ciphersrateField = 0;
    private long ssltot64bitrc4ciphersField = 0;
    private long ssl64bitrc4ciphersrateField = 0;
    private long ssltot128bitrc4ciphersField = 0;
    private long ssl128bitrc4ciphersrateField = 0;
    private long ssltot40bitdesciphersField = 0;
    private long ssl40bitdesciphersrateField = 0;
    private long ssltot56bitdesciphersField = 0;
    private long ssl56bitdesciphersrateField = 0;
    private long ssltot168bit3desciphersField = 0;
    private long ssl168bit3desciphersrateField = 0;
    private long ssltotcipheraes128Field = 0;
    private long sslcipheraes128rateField = 0;
    private long ssltotcipheraes256Field = 0;
    private long sslcipheraes256rateField = 0;
    private long ssltot40bitrc2ciphersField = 0;
    private long ssl40bitrc2ciphersrateField = 0;
    private long ssltot56bitrc2ciphersField = 0;
    private long ssl56bitrc2ciphersrateField = 0;
    private long ssltot128bitrc2ciphersField = 0;
    private long ssl128bitrc2ciphersrateField = 0;
    private long ssltot128bitaesgcmciphersField = 0;
    private long ssl128bitaesgcmciphersrateField = 0;
    private long ssltot256bitaesgcmciphersField = 0;
    private long ssl256bitaesgcmciphersrateField = 0;
    private long ssltotnullciphersField = 0;
    private long sslnullciphersrateField = 0;
    private long ssltotmd5macField = 0;
    private long sslmd5macrateField = 0;
    private long ssltotshamacField = 0;
    private long sslshamacrateField = 0;
    private long ssltotsslv2handshakesField = 0;
    private long sslsslv2handshakesrateField = 0;
    private long ssltotsslv3handshakesField = 0;
    private long sslsslv3handshakesrateField = 0;
    private long ssltottlsv1handshakesField = 0;
    private long ssltlsv1handshakesrateField = 0;
    private long ssltottlsv11handshakesField = 0;
    private long ssltlsv11handshakesrateField = 0;
    private long ssltottlsv12handshakesField = 0;
    private long ssltlsv12handshakesrateField = 0;
    private long ssltotsslv2clientauthenticationsField = 0;
    private long sslsslv2clientauthenticationsrateField = 0;
    private long ssltotsslv3clientauthenticationsField = 0;
    private long sslsslv3clientauthenticationsrateField = 0;
    private long ssltottlsv1clientauthenticationsField = 0;
    private long ssltlsv1clientauthenticationsrateField = 0;
    private long ssltottlsv11clientauthenticationsField = 0;
    private long ssltlsv11clientauthenticationsrateField = 0;
    private long ssltottlsv12clientauthenticationsField = 0;
    private long ssltlsv12clientauthenticationsrateField = 0;
    private long ssltotrsaauthorizationsField = 0;
    private long sslrsaauthorizationsrateField = 0;
    private long ssltotdhauthorizationsField = 0;
    private long ssldhauthorizationsrateField = 0;
    private long ssltotdssauthorizationsField = 0;
    private long ssldssauthorizationsrateField = 0;
    private long ssltotnullauthorizationsField = 0;
    private long sslnullauthorizationsrateField = 0;
    private long ssltotbkendsessionrenegotiateField = 0;
    private long sslbkendsessionrenegotiaterateField = 0;
    private long ssltotbkendsslv3renegoField = 0;
    private long sslbkendsslv3renegorateField = 0;
    private long ssltotbkendtlsvlrenegoField = 0;
    private long sslbkendtlsvlrenegorateField = 0;
    private long ssltotbkendtlsv11renegoField = 0;
    private long sslbkendtlsv11renegorateField = 0;
    private long ssltotbkendtlsv12renegoField = 0;
    private long sslbkendtlsv12renegorateField = 0;
    private long sslbetotrsa512keyexchangesField = 0;
    private long sslbersa512keyexchangesrateField = 0;
    private long sslbetotrsa1024keyexchangesField = 0;
    private long sslbersa1024keyexchangesrateField = 0;
    private long sslbetotrsa2048keyexchangesField = 0;
    private long sslbersa2048keyexchangesrateField = 0;
    private long sslbetotdh512keyexchangesField = 0;
    private long sslbedh512keyexchangesrateField = 0;
    private long sslbetotdh1024keyexchangesField = 0;
    private long sslbedh1024keyexchangesrateField = 0;
    private long sslbetotdh2048keyexchangesField = 0;
    private long sslbedh2048keyexchangesrateField = 0;
    private long sslbetotecdhecurve521Field = 0;
    private long sslbeecdhecurve521rateField = 0;
    private long sslbetotecdhecurve384Field = 0;
    private long sslbeecdhecurve384rateField = 0;
    private long sslbetotecdhecurve256Field = 0;
    private long sslbeecdhecurve256rateField = 0;
    private long sslbetotecdhecurve224Field = 0;
    private long sslbeecdhecurve224rateField = 0;
    private long sslbetot40bitrc4ciphersField = 0;
    private long sslbe40bitrc4ciphersrateField = 0;
    private long sslbetot56bitrc4ciphersField = 0;
    private long sslbe56bitrc4ciphersrateField = 0;
    private long sslbetot64bitrc4ciphersField = 0;
    private long sslbe64bitrc4ciphersrateField = 0;
    private long sslbetot128bitrc4ciphersField = 0;
    private long sslbe128bitrc4ciphersrateField = 0;
    private long sslbetot40bitdesciphersField = 0;
    private long sslbe40bitdesciphersrateField = 0;
    private long sslbetot56bitdesciphersField = 0;
    private long sslbe56bitdesciphersrateField = 0;
    private long sslbetot168bit3desciphersField = 0;
    private long sslbe168bit3desciphersrateField = 0;
    private long ssltotbkendcipheraes128Field = 0;
    private long sslbkendcipheraes128rateField = 0;
    private long ssltotbkendcipheraes256Field = 0;
    private long sslbkendcipheraes256rateField = 0;
    private long sslbetot40bitrc2ciphersField = 0;
    private long sslbe40bitrc2ciphersrateField = 0;
    private long sslbetot56bitrc2ciphersField = 0;
    private long sslbe56bitrc2ciphersrateField = 0;
    private long sslbetot128bitrc2ciphersField = 0;
    private long sslbe128bitrc2ciphersrateField = 0;
    private long sslbetotnullciphersField = 0;
    private long sslbenullciphersrateField = 0;
    private long sslbetotmd5macField = 0;
    private long sslbemd5macrateField = 0;
    private long sslbetotshamacField = 0;
    private long sslbeshamacrateField = 0;
    private long sslbetotsslv3handshakesField = 0;
    private long sslbesslv3handshakesrateField = 0;
    private long sslbetottlsv1handshakesField = 0;
    private long sslbetlsv1handshakesrateField = 0;
    private long sslbetotsslv3clientauthenticationsField = 0;
    private long sslbesslv3clientauthenticationsrateField = 0;
    private long sslbetottlsv1clientauthenticationsField = 0;
    private long sslbetlsv1clientauthenticationsrateField = 0;
    private long sslbetotrsaauthorizationsField = 0;
    private long sslbersaauthorizationsrateField = 0;
    private long sslbetotdhauthorizationsField = 0;
    private long sslbedhauthorizationsrateField = 0;
    private long sslbetotdssauthorizationsField = 0;
    private long sslbedssauthorizationsrateField = 0;
    private long sslbetotnullauthorizationsField = 0;
    private long sslbenullauthorizationsrateField = 0;
    private long ssltotoffloadrsakeyexchangesField = 0;
    private long ssloffloadrsakeyexchangesrateField = 0;
    private long ssltotoffloadsignrsaField = 0;
    private long ssloffloadsignrsarateField = 0;
    private long ssltotoffloaddhkeyexchangesField = 0;
    private long ssloffloaddhkeyexchangesrateField = 0;
    private long ssltotoffloadbulkrc4Field = 0;
    private long ssloffloadbulkrc4rateField = 0;
    private long ssltotoffloadbulkdesField = 0;
    private long ssloffloadbulkdesrateField = 0;
    private long ssltotoffloadbulkaesField = 0;
    private long ssloffloadbulkaesrateField = 0;
    private long ssltotoffloadbulkaesgcm128Field = 0;
    private long ssloffloadbulkaesgcm128rateField = 0;
    private long ssltotoffloadbulkaesgcm256Field = 0;
    private long ssloffloadbulkaesgcm256rateField = 0;
    private long ssltotenchwField = 0;
    private long sslenchwrateField = 0;
    private long ssltotencswField = 0;
    private long sslencswrateField = 0;
    private long ssltotencfeField = 0;
    private long sslencferateField = 0;
    private long ssltothwencfeField = 0;
    private long sslhwencferateField = 0;
    private long ssltotswencfeField = 0;
    private long sslswencferateField = 0;
    private long ssltotencbeField = 0;
    private long sslencberateField = 0;
    private long ssltothwencbeField = 0;
    private long sslhwencberateField = 0;
    private long ssltotswencbeField = 0;
    private long sslswencberateField = 0;
    private long ssltotdechwField = 0;
    private long ssldechwrateField = 0;
    private long ssltotdecswField = 0;
    private long ssldecswrateField = 0;
    private long ssltotdecfeField = 0;
    private long ssldecferateField = 0;
    private long ssltothwdecfeField = 0;
    private long sslhwdecferateField = 0;
    private long ssltotswdecfeField = 0;
    private long sslswdecferateField = 0;
    private long ssltotdecbeField = 0;
    private long ssldecberateField = 0;
    private long ssltothwdecbeField = 0;
    private long sslhwdecberateField = 0;
    private long ssltotswdecbeField = 0;
    private long sslswdecberateField = 0;
    private long sslbemaxmultiplexedsessionsField = 0;
    private long sslbemaxmultiplexedsessionsrateField = 0;
    private long ssltot128bitideaciphersField = 0;
    private long ssl128bitideaciphersrateField = 0;
    private long sslbetot128bitideaciphersField = 0;
    private long sslbe128bitideaciphersrateField = 0;

    public string clearstats
    {
      get => this.clearstatsField;
      set => this.clearstatsField = value;
    }

    public long ssltlsv11handshakesrate
    {
      get => this.ssltlsv11handshakesrateField;
      private set => this.ssltlsv11handshakesrateField = value;
    }

    public long ssldh512keyexchangesrate
    {
      get => this.ssldh512keyexchangesrateField;
      private set => this.ssldh512keyexchangesrateField = value;
    }

    public long sslbetottlsv1handshakes
    {
      get => this.sslbetottlsv1handshakesField;
      private set => this.sslbetottlsv1handshakesField = value;
    }

    public long sslswdecberate
    {
      get => this.sslswdecberateField;
      private set => this.sslswdecberateField = value;
    }

    public long ssltottransactions
    {
      get => this.ssltottransactionsField;
      private set => this.ssltottransactionsField = value;
    }

    public long sslbetot40bitrc4ciphers
    {
      get => this.sslbetot40bitrc4ciphersField;
      private set => this.sslbetot40bitrc4ciphersField = value;
    }

    public long sslnumcardsup
    {
      get => this.sslnumcardsupField;
      private set => this.sslnumcardsupField = value;
    }

    public long sslbetlsv1clientauthenticationsrate
    {
      get => this.sslbetlsv1clientauthenticationsrateField;
      private set => this.sslbetlsv1clientauthenticationsrateField = value;
    }

    public long sslrenegsessionsrate
    {
      get => this.sslrenegsessionsrateField;
      private set => this.sslrenegsessionsrateField = value;
    }

    public long ssltottlsv11handshakes
    {
      get => this.ssltottlsv11handshakesField;
      private set => this.ssltottlsv11handshakesField = value;
    }

    public long sslbetotsessions
    {
      get => this.sslbetotsessionsField;
      private set => this.sslbetotsessionsField = value;
    }

    public long sslbetot64bitrc4ciphers
    {
      get => this.sslbetot64bitrc4ciphersField;
      private set => this.sslbetot64bitrc4ciphersField = value;
    }

    public long sslbersa2048keyexchangesrate
    {
      get => this.sslbersa2048keyexchangesrateField;
      private set => this.sslbersa2048keyexchangesrateField = value;
    }

    public long sslbetottlsv1clientauthentications
    {
      get => this.sslbetottlsv1clientauthenticationsField;
      private set => this.sslbetottlsv1clientauthenticationsField = value;
    }

    public long ssltothwencbe
    {
      get => this.ssltothwencbeField;
      private set => this.ssltothwencbeField = value;
    }

    public long sslbetotdh512keyexchanges
    {
      get => this.sslbetotdh512keyexchangesField;
      private set => this.sslbetotdh512keyexchangesField = value;
    }

    public long ssltotrsaauthorizations
    {
      get => this.ssltotrsaauthorizationsField;
      private set => this.ssltotrsaauthorizationsField = value;
    }

    public long sslecdhe384keyexchangesrate
    {
      get => this.sslecdhe384keyexchangesrateField;
      private set => this.sslecdhe384keyexchangesrateField = value;
    }

    public long sslcipheraes128rate
    {
      get => this.sslcipheraes128rateField;
      private set => this.sslcipheraes128rateField = value;
    }

    public long ssltotsslv2sessions
    {
      get => this.ssltotsslv2sessionsField;
      private set => this.ssltotsslv2sessionsField = value;
    }

    public long ssltothwdecfe
    {
      get => this.ssltothwdecfeField;
      private set => this.ssltothwdecfeField = value;
    }

    public long ssloffloadbulkrc4rate
    {
      get => this.ssloffloadbulkrc4rateField;
      private set => this.ssloffloadbulkrc4rateField = value;
    }

    public long ssltotbkendtlsv11renego
    {
      get => this.ssltotbkendtlsv11renegoField;
      private set => this.ssltotbkendtlsv11renegoField = value;
    }

    public long sslbe128bitrc4ciphersrate
    {
      get => this.sslbe128bitrc4ciphersrateField;
      private set => this.sslbe128bitrc4ciphersrateField = value;
    }

    public long ssltotdecsw
    {
      get => this.ssltotdecswField;
      private set => this.ssltotdecswField = value;
    }

    public long ssl128bitrc2ciphersrate
    {
      get => this.ssl128bitrc2ciphersrateField;
      private set => this.ssl128bitrc2ciphersrateField = value;
    }

    public long ssloffloadbulkaesrate
    {
      get => this.ssloffloadbulkaesrateField;
      private set => this.ssloffloadbulkaesrateField = value;
    }

    public long sslrsa512keyexchangesrate
    {
      get => this.sslrsa512keyexchangesrateField;
      private set => this.sslrsa512keyexchangesrateField = value;
    }

    public long sslbe56bitrc2ciphersrate
    {
      get => this.sslbe56bitrc2ciphersrateField;
      private set => this.sslbe56bitrc2ciphersrateField = value;
    }

    public long ssltotrsa4096keyexchanges
    {
      get => this.ssltotrsa4096keyexchangesField;
      private set => this.ssltotrsa4096keyexchangesField = value;
    }

    public long sslbetotsslv3clientauthentications
    {
      get => this.sslbetotsslv3clientauthenticationsField;
      private set => this.sslbetotsslv3clientauthenticationsField = value;
    }

    public long sslbeecdhecurve256rate
    {
      get => this.sslbeecdhecurve256rateField;
      private set => this.sslbeecdhecurve256rateField = value;
    }

    public long ssltotsslv2clientauthentications
    {
      get => this.ssltotsslv2clientauthenticationsField;
      private set => this.ssltotsslv2clientauthenticationsField = value;
    }

    public long sslbetlsv11sessionsrate
    {
      get => this.sslbetlsv11sessionsrateField;
      private set => this.sslbetlsv11sessionsrateField = value;
    }

    public long sslbkendtlsv11renegorate
    {
      get => this.sslbkendtlsv11renegorateField;
      private set => this.sslbkendtlsv11renegorateField = value;
    }

    public long ssldh1024keyexchangesrate
    {
      get => this.ssldh1024keyexchangesrateField;
      private set => this.ssldh1024keyexchangesrateField = value;
    }

    public long ssltotmd5mac
    {
      get => this.ssltotmd5macField;
      private set => this.ssltotmd5macField = value;
    }

    public long sslbetotnullauthorizations
    {
      get => this.sslbetotnullauthorizationsField;
      private set => this.sslbetotnullauthorizationsField = value;
    }

    public long sslbesessionmultiplexattemptsrate
    {
      get => this.sslbesessionmultiplexattemptsrateField;
      private set => this.sslbesessionmultiplexattemptsrateField = value;
    }

    public long sslsslv2handshakesrate
    {
      get => this.sslsslv2handshakesrateField;
      private set => this.sslsslv2handshakesrateField = value;
    }

    public long ssldssauthorizationsrate
    {
      get => this.ssldssauthorizationsrateField;
      private set => this.ssldssauthorizationsrateField = value;
    }

    public long sslbemaxmultiplexedsessionsrate
    {
      get => this.sslbemaxmultiplexedsessionsrateField;
      private set => this.sslbemaxmultiplexedsessionsrateField = value;
    }

    public long sslbkendsessionrenegotiaterate
    {
      get => this.sslbkendsessionrenegotiaterateField;
      private set => this.sslbkendsessionrenegotiaterateField = value;
    }

    public long sslbetotrsa512keyexchanges
    {
      get => this.sslbetotrsa512keyexchangesField;
      private set => this.sslbetotrsa512keyexchangesField = value;
    }

    public long ssltlsv1renegsessionsrate
    {
      get => this.ssltlsv1renegsessionsrateField;
      private set => this.ssltlsv1renegsessionsrateField = value;
    }

    public long ssltot168bit3desciphers
    {
      get => this.ssltot168bit3desciphersField;
      private set => this.ssltot168bit3desciphersField = value;
    }

    public long ssltottlsv1handshakes
    {
      get => this.ssltottlsv1handshakesField;
      private set => this.ssltottlsv1handshakesField = value;
    }

    public long sslbetot56bitdesciphers
    {
      get => this.sslbetot56bitdesciphersField;
      private set => this.sslbetot56bitdesciphersField = value;
    }

    public long sslbe128bitrc2ciphersrate
    {
      get => this.sslbe128bitrc2ciphersrateField;
      private set => this.sslbe128bitrc2ciphersrateField = value;
    }

    public long ssltottlsv12handshakes
    {
      get => this.ssltottlsv12handshakesField;
      private set => this.ssltottlsv12handshakesField = value;
    }

    public long sslrsa2048keyexchangesrate
    {
      get => this.sslrsa2048keyexchangesrateField;
      private set => this.sslrsa2048keyexchangesrateField = value;
    }

    public long ssltotsessionhits
    {
      get => this.ssltotsessionhitsField;
      private set => this.ssltotsessionhitsField = value;
    }

    public long ssl40bitdesciphersrate
    {
      get => this.ssl40bitdesciphersrateField;
      private set => this.ssl40bitdesciphersrateField = value;
    }

    public long ssltotencfe
    {
      get => this.ssltotencfeField;
      private set => this.ssltotencfeField = value;
    }

    public long ssl40bitrc4ciphersrate
    {
      get => this.ssl40bitrc4ciphersrateField;
      private set => this.ssl40bitrc4ciphersrateField = value;
    }

    public long sslbe56bitrc4ciphersrate
    {
      get => this.sslbe56bitrc4ciphersrateField;
      private set => this.sslbe56bitrc4ciphersrateField = value;
    }

    public long ssltottlsv11renegsessions
    {
      get => this.ssltottlsv11renegsessionsField;
      private set => this.ssltottlsv11renegsessionsField = value;
    }

    public long ssldecferate
    {
      get => this.ssldecferateField;
      private set => this.ssldecferateField = value;
    }

    public long ssltottlsv12sessions
    {
      get => this.ssltottlsv12sessionsField;
      private set => this.ssltottlsv12sessionsField = value;
    }

    public long ssltotrsa2048keyexchanges
    {
      get => this.ssltotrsa2048keyexchangesField;
      private set => this.ssltotrsa2048keyexchangesField = value;
    }

    public long sslbetotsessionmultiplexattemptfails
    {
      get => this.sslbetotsessionmultiplexattemptfailsField;
      private set => this.sslbetotsessionmultiplexattemptfailsField = value;
    }

    public long ssltotoffloadbulkdes
    {
      get => this.ssltotoffloadbulkdesField;
      private set => this.ssltotoffloadbulkdesField = value;
    }

    public long ssltotnullciphers
    {
      get => this.ssltotnullciphersField;
      private set => this.ssltotnullciphersField = value;
    }

    public long ssltlsv12sessionsrate
    {
      get => this.ssltlsv12sessionsrateField;
      private set => this.ssltlsv12sessionsrateField = value;
    }

    public long ssltothwdecbe
    {
      get => this.ssltothwdecbeField;
      private set => this.ssltothwdecbeField = value;
    }

    public long ssltotoffloadsignrsa
    {
      get => this.ssltotoffloadsignrsaField;
      private set => this.ssltotoffloadsignrsaField = value;
    }

    public long sslswencferate
    {
      get => this.sslswencferateField;
      private set => this.sslswencferateField = value;
    }

    public long sslbeecdhecurve224rate
    {
      get => this.sslbeecdhecurve224rateField;
      private set => this.sslbeecdhecurve224rateField = value;
    }

    public long sslbetotshamac
    {
      get => this.sslbetotshamacField;
      private set => this.sslbetotshamacField = value;
    }

    public long ssltotcipheraes128
    {
      get => this.ssltotcipheraes128Field;
      private set => this.ssltotcipheraes128Field = value;
    }

    public long ssltotbkendsslv3renego
    {
      get => this.ssltotbkendsslv3renegoField;
      private set => this.ssltotbkendsslv3renegoField = value;
    }

    public long ssltot128bitrc4ciphers
    {
      get => this.ssltot128bitrc4ciphersField;
      private set => this.ssltot128bitrc4ciphersField = value;
    }

    public long sslbetotdssauthorizations
    {
      get => this.sslbetotdssauthorizationsField;
      private set => this.sslbetotdssauthorizationsField = value;
    }

    public long sslbetot56bitrc4ciphers
    {
      get => this.sslbetot56bitrc4ciphersField;
      private set => this.sslbetot56bitrc4ciphersField = value;
    }

    public long sslbetot40bitdesciphers
    {
      get => this.sslbetot40bitdesciphersField;
      private set => this.sslbetot40bitdesciphersField = value;
    }

    public long ssltotsslv3renegsessions
    {
      get => this.ssltotsslv3renegsessionsField;
      private set => this.ssltotsslv3renegsessionsField = value;
    }

    public long sslbersaauthorizationsrate
    {
      get => this.sslbersaauthorizationsrateField;
      private set => this.sslbersaauthorizationsrateField = value;
    }

    public long ssltot128bitaesgcmciphers
    {
      get => this.ssltot128bitaesgcmciphersField;
      private set => this.ssltot128bitaesgcmciphersField = value;
    }

    public long ssltotsslv2transactions
    {
      get => this.ssltotsslv2transactionsField;
      private set => this.ssltotsslv2transactionsField = value;
    }

    public long sslbedh1024keyexchangesrate
    {
      get => this.sslbedh1024keyexchangesrateField;
      private set => this.sslbedh1024keyexchangesrateField = value;
    }

    public long ssl64bitrc4ciphersrate
    {
      get => this.ssl64bitrc4ciphersrateField;
      private set => this.ssl64bitrc4ciphersrateField = value;
    }

    public long sslsslv3clientauthenticationsrate
    {
      get => this.sslsslv3clientauthenticationsrateField;
      private set => this.sslsslv3clientauthenticationsrateField = value;
    }

    public long sslbetottlsv11sessions
    {
      get => this.sslbetottlsv11sessionsField;
      private set => this.sslbetottlsv11sessionsField = value;
    }

    public long sslsessionmissrate
    {
      get => this.sslsessionmissrateField;
      private set => this.sslsessionmissrateField = value;
    }

    public long sslbetotdhauthorizations
    {
      get => this.sslbetotdhauthorizationsField;
      private set => this.sslbetotdhauthorizationsField = value;
    }

    public long sslbemd5macrate
    {
      get => this.sslbemd5macrateField;
      private set => this.sslbemd5macrateField = value;
    }

    public long sslecdhe256keyexchangesrate
    {
      get => this.sslecdhe256keyexchangesrateField;
      private set => this.sslecdhe256keyexchangesrateField = value;
    }

    public long sslbetotmd5mac
    {
      get => this.sslbetotmd5macField;
      private set => this.sslbetotmd5macField = value;
    }

    public long ssldhauthorizationsrate
    {
      get => this.ssldhauthorizationsrateField;
      private set => this.ssldhauthorizationsrateField = value;
    }

    public long ssloffloadbulkaesgcm128rate
    {
      get => this.ssloffloadbulkaesgcm128rateField;
      private set => this.ssloffloadbulkaesgcm128rateField = value;
    }

    public long sslshamacrate
    {
      get => this.sslshamacrateField;
      private set => this.sslshamacrateField = value;
    }

    public long sslhwdecberate
    {
      get => this.sslhwdecberateField;
      private set => this.sslhwdecberateField = value;
    }

    public long sslnullauthorizationsrate
    {
      get => this.sslnullauthorizationsrateField;
      private set => this.sslnullauthorizationsrateField = value;
    }

    public long sslbetot128bitrc2ciphers
    {
      get => this.sslbetot128bitrc2ciphersField;
      private set => this.sslbetot128bitrc2ciphersField = value;
    }

    public long sslsslv3sessionsrate
    {
      get => this.sslsslv3sessionsrateField;
      private set => this.sslsslv3sessionsrateField = value;
    }

    public long ssltotdh1024keyexchanges
    {
      get => this.ssltotdh1024keyexchangesField;
      private set => this.ssltotdh1024keyexchangesField = value;
    }

    public long ssltotbkendsessionrenegotiate
    {
      get => this.ssltotbkendsessionrenegotiateField;
      private set => this.ssltotbkendsessionrenegotiateField = value;
    }

    public long sslbkendtlsv12renegorate
    {
      get => this.sslbkendtlsv12renegorateField;
      private set => this.sslbkendtlsv12renegorateField = value;
    }

    public long sslsessionhitsrate
    {
      get => this.sslsessionhitsrateField;
      private set => this.sslsessionhitsrateField = value;
    }

    public long sslsslv3renegsessionsrate
    {
      get => this.sslsslv3renegsessionsrateField;
      private set => this.sslsslv3renegsessionsrateField = value;
    }

    public long ssldechwrate
    {
      get => this.ssldechwrateField;
      private set => this.ssldechwrateField = value;
    }

    public long ssltotsslv3clientauthentications
    {
      get => this.ssltotsslv3clientauthenticationsField;
      private set => this.ssltotsslv3clientauthenticationsField = value;
    }

    public long ssldecrate
    {
      get => this.ssldecrateField;
      private set => this.ssldecrateField = value;
    }

    public long ssltlsv11clientauthenticationsrate
    {
      get => this.ssltlsv11clientauthenticationsrateField;
      private set => this.ssltlsv11clientauthenticationsrateField = value;
    }

    public long ssldh2048keyexchangesrate
    {
      get => this.ssldh2048keyexchangesrateField;
      private set => this.ssldh2048keyexchangesrateField = value;
    }

    public long sslbesslv3sessionsrate
    {
      get => this.sslbesslv3sessionsrateField;
      private set => this.sslbesslv3sessionsrateField = value;
    }

    public long ssltotoffloadbulkaesgcm256
    {
      get => this.ssltotoffloadbulkaesgcm256Field;
      private set => this.ssltotoffloadbulkaesgcm256Field = value;
    }

    public long ssl40bitrc2ciphersrate
    {
      get => this.ssl40bitrc2ciphersrateField;
      private set => this.ssl40bitrc2ciphersrateField = value;
    }

    public long sslbe40bitdesciphersrate
    {
      get => this.sslbe40bitdesciphersrateField;
      private set => this.sslbe40bitdesciphersrateField = value;
    }

    public long sslbetotsessionmultiplexattemptsuccess
    {
      get => this.sslbetotsessionmultiplexattemptsuccessField;
      private set => this.sslbetotsessionmultiplexattemptsuccessField = value;
    }

    public long ssloffloadrsakeyexchangesrate
    {
      get => this.ssloffloadrsakeyexchangesrateField;
      private set => this.ssloffloadrsakeyexchangesrateField = value;
    }

    public long sslbetotdh2048keyexchanges
    {
      get => this.sslbetotdh2048keyexchangesField;
      private set => this.sslbetotdh2048keyexchangesField = value;
    }

    public long sslbesessionmultiplexattemptsuccessrate
    {
      get => this.sslbesessionmultiplexattemptsuccessrateField;
      private set => this.sslbesessionmultiplexattemptsuccessrateField = value;
    }

    public long sslbe40bitrc4ciphersrate
    {
      get => this.sslbe40bitrc4ciphersrateField;
      private set => this.sslbe40bitrc4ciphersrateField = value;
    }

    public long ssltotoffloadbulkaes
    {
      get => this.ssltotoffloadbulkaesField;
      private set => this.ssltotoffloadbulkaesField = value;
    }

    public long sslbetot168bit3desciphers
    {
      get => this.sslbetot168bit3desciphersField;
      private set => this.sslbetot168bit3desciphersField = value;
    }

    public long ssltottlsv12renegsessions
    {
      get => this.ssltottlsv12renegsessionsField;
      private set => this.ssltottlsv12renegsessionsField = value;
    }

    public long ssltotrenegsessions
    {
      get => this.ssltotrenegsessionsField;
      private set => this.ssltotrenegsessionsField = value;
    }

    public long sslbkendsslv3renegorate
    {
      get => this.sslbkendsslv3renegorateField;
      private set => this.sslbkendsslv3renegorateField = value;
    }

    public long sslsslv3transactionsrate
    {
      get => this.sslsslv3transactionsrateField;
      private set => this.sslsslv3transactionsrateField = value;
    }

    public long sslecdhe521keyexchangesrate
    {
      get => this.sslecdhe521keyexchangesrateField;
      private set => this.sslecdhe521keyexchangesrateField = value;
    }

    public long ssltottlsv11clientauthentications
    {
      get => this.ssltottlsv11clientauthenticationsField;
      private set => this.ssltottlsv11clientauthenticationsField = value;
    }

    public long sslsslv2clientauthenticationsrate
    {
      get => this.sslsslv2clientauthenticationsrateField;
      private set => this.sslsslv2clientauthenticationsrateField = value;
    }

    public long sslbetotrsa2048keyexchanges
    {
      get => this.sslbetotrsa2048keyexchangesField;
      private set => this.sslbetotrsa2048keyexchangesField = value;
    }

    public long sslrsaauthorizationsrate
    {
      get => this.sslrsaauthorizationsrateField;
      private set => this.sslrsaauthorizationsrateField = value;
    }

    public long ssltot40bitrc2ciphers
    {
      get => this.ssltot40bitrc2ciphersField;
      private set => this.ssltot40bitrc2ciphersField = value;
    }

    public long ssltot56bitrc2ciphers
    {
      get => this.ssltot56bitrc2ciphersField;
      private set => this.ssltot56bitrc2ciphersField = value;
    }

    public long ssl128bitrc4ciphersrate
    {
      get => this.ssl128bitrc4ciphersrateField;
      private set => this.ssl128bitrc4ciphersrateField = value;
    }

    public long ssltothwencfe
    {
      get => this.ssltothwencfeField;
      private set => this.ssltothwencfeField = value;
    }

    public long ssltot40bitdesciphers
    {
      get => this.ssltot40bitdesciphersField;
      private set => this.ssltot40bitdesciphersField = value;
    }

    public long sslbeshamacrate
    {
      get => this.sslbeshamacrateField;
      private set => this.sslbeshamacrateField = value;
    }

    public long sslbkendcipheraes128rate
    {
      get => this.sslbkendcipheraes128rateField;
      private set => this.sslbkendcipheraes128rateField = value;
    }

    public long ssltottlsv1transactions
    {
      get => this.ssltottlsv1transactionsField;
      private set => this.ssltottlsv1transactionsField = value;
    }

    public long ssltotrsa512keyexchanges
    {
      get => this.ssltotrsa512keyexchangesField;
      private set => this.ssltotrsa512keyexchangesField = value;
    }

    public long ssltlsv12renegsessionsrate
    {
      get => this.ssltlsv12renegsessionsrateField;
      private set => this.ssltlsv12renegsessionsrateField = value;
    }

    public long sslbetotecdhecurve224
    {
      get => this.sslbetotecdhecurve224Field;
      private set => this.sslbetotecdhecurve224Field = value;
    }

    public long sslbetotnullciphers
    {
      get => this.sslbetotnullciphersField;
      private set => this.sslbetotnullciphersField = value;
    }

    public long sslencrate
    {
      get => this.sslencrateField;
      private set => this.sslencrateField = value;
    }

    public long ssltotencsw
    {
      get => this.ssltotencswField;
      private set => this.ssltotencswField = value;
    }

    public long ssltottlsv1renegsessions
    {
      get => this.ssltottlsv1renegsessionsField;
      private set => this.ssltottlsv1renegsessionsField = value;
    }

    public long ssltotbkendcipheraes128
    {
      get => this.ssltotbkendcipheraes128Field;
      private set => this.ssltotbkendcipheraes128Field = value;
    }

    public long ssltlsv11transactionsrate
    {
      get => this.ssltlsv11transactionsrateField;
      private set => this.ssltlsv11transactionsrateField = value;
    }

    public long ssltlsv12clientauthenticationsrate
    {
      get => this.ssltlsv12clientauthenticationsrateField;
      private set => this.ssltlsv12clientauthenticationsrateField = value;
    }

    public long ssltotcipheraes256
    {
      get => this.ssltotcipheraes256Field;
      private set => this.ssltotcipheraes256Field = value;
    }

    public long ssltotsslv3transactions
    {
      get => this.ssltotsslv3transactionsField;
      private set => this.ssltotsslv3transactionsField = value;
    }

    public long ssltotdecbe
    {
      get => this.ssltotdecbeField;
      private set => this.ssltotdecbeField = value;
    }

    public long ssloffloadbulkdesrate
    {
      get => this.ssloffloadbulkdesrateField;
      private set => this.ssloffloadbulkdesrateField = value;
    }

    public long ssltotbkendtlsv12renego
    {
      get => this.ssltotbkendtlsv12renegoField;
      private set => this.ssltotbkendtlsv12renegoField = value;
    }

    public long sslbesessionsrate
    {
      get => this.sslbesessionsrateField;
      private set => this.sslbesessionsrateField = value;
    }

    public long ssltot128bitideaciphers
    {
      get => this.ssltot128bitideaciphersField;
      private set => this.ssltot128bitideaciphersField = value;
    }

    public long ssltotdec
    {
      get => this.ssltotdecField;
      private set => this.ssltotdecField = value;
    }

    public long ssl56bitdesciphersrate
    {
      get => this.ssl56bitdesciphersrateField;
      private set => this.ssl56bitdesciphersrateField = value;
    }

    public long sslbetot56bitrc2ciphers
    {
      get => this.sslbetot56bitrc2ciphersField;
      private set => this.sslbetot56bitrc2ciphersField = value;
    }

    public long sslbkendcipheraes256rate
    {
      get => this.sslbkendcipheraes256rateField;
      private set => this.sslbkendcipheraes256rateField = value;
    }

    public long sslbetotrsaauthorizations
    {
      get => this.sslbetotrsaauthorizationsField;
      private set => this.sslbetotrsaauthorizationsField = value;
    }

    public long sslbedh2048keyexchangesrate
    {
      get => this.sslbedh2048keyexchangesrateField;
      private set => this.sslbedh2048keyexchangesrateField = value;
    }

    public long sslbe168bit3desciphersrate
    {
      get => this.sslbe168bit3desciphersrateField;
      private set => this.sslbe168bit3desciphersrateField = value;
    }

    public long sslsslv2transactionsrate
    {
      get => this.sslsslv2transactionsrateField;
      private set => this.sslsslv2transactionsrateField = value;
    }

    public long sslrsa1024keyexchangesrate
    {
      get => this.sslrsa1024keyexchangesrateField;
      private set => this.sslrsa1024keyexchangesrateField = value;
    }

    public long sslbedh512keyexchangesrate
    {
      get => this.sslbedh512keyexchangesrateField;
      private set => this.sslbedh512keyexchangesrateField = value;
    }

    public long ssltottlsv1clientauthentications
    {
      get => this.ssltottlsv1clientauthenticationsField;
      private set => this.ssltottlsv1clientauthenticationsField = value;
    }

    public long sslbetot40bitrc2ciphers
    {
      get => this.sslbetot40bitrc2ciphersField;
      private set => this.sslbetot40bitrc2ciphersField = value;
    }

    public long ssl168bit3desciphersrate
    {
      get => this.ssl168bit3desciphersrateField;
      private set => this.ssl168bit3desciphersrateField = value;
    }

    public long ssltot64bitrc4ciphers
    {
      get => this.ssltot64bitrc4ciphersField;
      private set => this.ssltot64bitrc4ciphersField = value;
    }

    public long ssltotswencfe
    {
      get => this.ssltotswencfeField;
      private set => this.ssltotswencfeField = value;
    }

    public long ssldecswrate
    {
      get => this.ssldecswrateField;
      private set => this.ssldecswrateField = value;
    }

    public long ssltot256bitaesgcmciphers
    {
      get => this.ssltot256bitaesgcmciphersField;
      private set => this.ssltot256bitaesgcmciphersField = value;
    }

    public long ssltotdhauthorizations
    {
      get => this.ssltotdhauthorizationsField;
      private set => this.ssltotdhauthorizationsField = value;
    }

    public long ssltotsessionmiss
    {
      get => this.ssltotsessionmissField;
      private set => this.ssltotsessionmissField = value;
    }

    public long ssltotdecfe
    {
      get => this.ssltotdecfeField;
      private set => this.ssltotdecfeField = value;
    }

    public long sslbesslv3handshakesrate
    {
      get => this.sslbesslv3handshakesrateField;
      private set => this.sslbesslv3handshakesrateField = value;
    }

    public long sslbeecdhecurve521rate
    {
      get => this.sslbeecdhecurve521rateField;
      private set => this.sslbeecdhecurve521rateField = value;
    }

    public long sslencswrate
    {
      get => this.sslencswrateField;
      private set => this.sslencswrateField = value;
    }

    public long sslhwencferate
    {
      get => this.sslhwencferateField;
      private set => this.sslhwencferateField = value;
    }

    public long sslbesessionmultiplexattemptfailsrate
    {
      get => this.sslbesessionmultiplexattemptfailsrateField;
      private set => this.sslbesessionmultiplexattemptfailsrateField = value;
    }

    public long sslbe128bitideaciphersrate
    {
      get => this.sslbe128bitideaciphersrateField;
      private set => this.sslbe128bitideaciphersrateField = value;
    }

    public long ssltotecdhe224keyexchanges
    {
      get => this.ssltotecdhe224keyexchangesField;
      private set => this.ssltotecdhe224keyexchangesField = value;
    }

    public long ssltotoffloaddhkeyexchanges
    {
      get => this.ssltotoffloaddhkeyexchangesField;
      private set => this.ssltotoffloaddhkeyexchangesField = value;
    }

    public long ssltlsv1clientauthenticationsrate
    {
      get => this.ssltlsv1clientauthenticationsrateField;
      private set => this.ssltlsv1clientauthenticationsrateField = value;
    }

    public long ssltot56bitrc4ciphers
    {
      get => this.ssltot56bitrc4ciphersField;
      private set => this.ssltot56bitrc4ciphersField = value;
    }

    public long sslbe40bitrc2ciphersrate
    {
      get => this.sslbe40bitrc2ciphersrateField;
      private set => this.sslbe40bitrc2ciphersrateField = value;
    }

    public long sslenchwrate
    {
      get => this.sslenchwrateField;
      private set => this.sslenchwrateField = value;
    }

    public long sslbetlsv1handshakesrate
    {
      get => this.sslbetlsv1handshakesrateField;
      private set => this.sslbetlsv1handshakesrateField = value;
    }

    public long ssltotsslv3handshakes
    {
      get => this.ssltotsslv3handshakesField;
      private set => this.ssltotsslv3handshakesField = value;
    }

    public long sslbenullciphersrate
    {
      get => this.sslbenullciphersrateField;
      private set => this.sslbenullciphersrateField = value;
    }

    public long sslsessionsrate
    {
      get => this.sslsessionsrateField;
      private set => this.sslsessionsrateField = value;
    }

    public long ssltottlsv12transactions
    {
      get => this.ssltottlsv12transactionsField;
      private set => this.ssltottlsv12transactionsField = value;
    }

    public long ssltottlsv11sessions
    {
      get => this.ssltottlsv11sessionsField;
      private set => this.ssltottlsv11sessionsField = value;
    }

    public long ssl56bitrc4ciphersrate
    {
      get => this.ssl56bitrc4ciphersrateField;
      private set => this.ssl56bitrc4ciphersrateField = value;
    }

    public long ssldecberate
    {
      get => this.ssldecberateField;
      private set => this.ssldecberateField = value;
    }

    public long sslbedssauthorizationsrate
    {
      get => this.sslbedssauthorizationsrateField;
      private set => this.sslbedssauthorizationsrateField = value;
    }

    public long ssltot56bitdesciphers
    {
      get => this.ssltot56bitdesciphersField;
      private set => this.ssltot56bitdesciphersField = value;
    }

    public long sslbkendtlsvlrenegorate
    {
      get => this.sslbkendtlsvlrenegorateField;
      private set => this.sslbkendtlsvlrenegorateField = value;
    }

    public long sslbenullauthorizationsrate
    {
      get => this.sslbenullauthorizationsrateField;
      private set => this.sslbenullauthorizationsrateField = value;
    }

    public long ssltotenchw
    {
      get => this.ssltotenchwField;
      private set => this.ssltotenchwField = value;
    }

    public long ssltlsv11sessionsrate
    {
      get => this.ssltlsv11sessionsrateField;
      private set => this.ssltlsv11sessionsrateField = value;
    }

    public long sslbetotecdhecurve256
    {
      get => this.sslbetotecdhecurve256Field;
      private set => this.sslbetotecdhecurve256Field = value;
    }

    public long ssltotdh512keyexchanges
    {
      get => this.ssltotdh512keyexchangesField;
      private set => this.ssltotdh512keyexchangesField = value;
    }

    public long ssltlsv1sessionsrate
    {
      get => this.ssltlsv1sessionsrateField;
      private set => this.ssltlsv1sessionsrateField = value;
    }

    public long ssltotencbe
    {
      get => this.ssltotencbeField;
      private set => this.ssltotencbeField = value;
    }

    public double sslcryptoutilizationstat
    {
      get => this.sslcryptoutilizationstatField;
      private set => this.sslcryptoutilizationstatField = value;
    }

    public long ssltotecdhe384keyexchanges
    {
      get => this.ssltotecdhe384keyexchangesField;
      private set => this.ssltotecdhe384keyexchangesField = value;
    }

    public long sslcipheraes256rate
    {
      get => this.sslcipheraes256rateField;
      private set => this.sslcipheraes256rateField = value;
    }

    public long ssltotsslv2handshakes
    {
      get => this.ssltotsslv2handshakesField;
      private set => this.ssltotsslv2handshakesField = value;
    }

    public long ssltotenc
    {
      get => this.ssltotencField;
      private set => this.ssltotencField = value;
    }

    public long sslbetotsslv3sessions
    {
      get => this.sslbetotsslv3sessionsField;
      private set => this.sslbetotsslv3sessionsField = value;
    }

    public long sslencberate
    {
      get => this.sslencberateField;
      private set => this.sslencberateField = value;
    }

    public long ssltottlsv11transactions
    {
      get => this.ssltottlsv11transactionsField;
      private set => this.ssltottlsv11transactionsField = value;
    }

    public long sslbemaxmultiplexedsessions
    {
      get => this.sslbemaxmultiplexedsessionsField;
      private set => this.sslbemaxmultiplexedsessionsField = value;
    }

    public long ssl128bitaesgcmciphersrate
    {
      get => this.ssl128bitaesgcmciphersrateField;
      private set => this.ssl128bitaesgcmciphersrateField = value;
    }

    public long sslbetotecdhecurve384
    {
      get => this.sslbetotecdhecurve384Field;
      private set => this.sslbetotecdhecurve384Field = value;
    }

    public long ssltotsessions
    {
      get => this.ssltotsessionsField;
      private set => this.ssltotsessionsField = value;
    }

    public long ssltot40bitrc4ciphers
    {
      get => this.ssltot40bitrc4ciphersField;
      private set => this.ssltot40bitrc4ciphersField = value;
    }

    public long ssloffloadbulkaesgcm256rate
    {
      get => this.ssloffloadbulkaesgcm256rateField;
      private set => this.ssloffloadbulkaesgcm256rateField = value;
    }

    public long ssltotecdhe256keyexchanges
    {
      get => this.ssltotecdhe256keyexchangesField;
      private set => this.ssltotecdhe256keyexchangesField = value;
    }

    public long sslcardstatus
    {
      get => this.sslcardstatusField;
      private set => this.sslcardstatusField = value;
    }

    public long sslnewsessionsrate
    {
      get => this.sslnewsessionsrateField;
      private set => this.sslnewsessionsrateField = value;
    }

    public long sslbetot128bitideaciphers
    {
      get => this.sslbetot128bitideaciphersField;
      private set => this.sslbetot128bitideaciphersField = value;
    }

    public long ssltransactionsrate
    {
      get => this.ssltransactionsrateField;
      private set => this.ssltransactionsrateField = value;
    }

    public long ssltotdechw
    {
      get => this.ssltotdechwField;
      private set => this.ssltotdechwField = value;
    }

    public long sslhwdecferate
    {
      get => this.sslhwdecferateField;
      private set => this.sslhwdecferateField = value;
    }

    public long ssltotbkendtlsvlrenego
    {
      get => this.ssltotbkendtlsvlrenegoField;
      private set => this.ssltotbkendtlsvlrenegoField = value;
    }

    public long sslbetlsv1sessionsrate
    {
      get => this.sslbetlsv1sessionsrateField;
      private set => this.sslbetlsv1sessionsrateField = value;
    }

    public long sslbetotsslv3handshakes
    {
      get => this.sslbetotsslv3handshakesField;
      private set => this.sslbetotsslv3handshakesField = value;
    }

    public long ssltlsv12transactionsrate
    {
      get => this.ssltlsv12transactionsrateField;
      private set => this.ssltlsv12transactionsrateField = value;
    }

    public long sslbetlsv12sessionsrate
    {
      get => this.sslbetlsv12sessionsrateField;
      private set => this.sslbetlsv12sessionsrateField = value;
    }

    public long sslsslv3handshakesrate
    {
      get => this.sslsslv3handshakesrateField;
      private set => this.sslsslv3handshakesrateField = value;
    }

    public long sslbetotsessionmultiplexattempts
    {
      get => this.sslbetotsessionmultiplexattemptsField;
      private set => this.sslbetotsessionmultiplexattemptsField = value;
    }

    public long ssltotdssauthorizations
    {
      get => this.ssltotdssauthorizationsField;
      private set => this.ssltotdssauthorizationsField = value;
    }

    public long ssltotshamac
    {
      get => this.ssltotshamacField;
      private set => this.ssltotshamacField = value;
    }

    public long sslrsa4096keyexchangesrate
    {
      get => this.sslrsa4096keyexchangesrateField;
      private set => this.sslrsa4096keyexchangesrateField = value;
    }

    public long ssltotswdecfe
    {
      get => this.ssltotswdecfeField;
      private set => this.ssltotswdecfeField = value;
    }

    public long ssltotrsa1024keyexchanges
    {
      get => this.ssltotrsa1024keyexchangesField;
      private set => this.ssltotrsa1024keyexchangesField = value;
    }

    public long ssltotnullauthorizations
    {
      get => this.ssltotnullauthorizationsField;
      private set => this.ssltotnullauthorizationsField = value;
    }

    public long ssltotoffloadrsakeyexchanges
    {
      get => this.ssltotoffloadrsakeyexchangesField;
      private set => this.ssltotoffloadrsakeyexchangesField = value;
    }

    public long sslbedhauthorizationsrate
    {
      get => this.sslbedhauthorizationsrateField;
      private set => this.sslbedhauthorizationsrateField = value;
    }

    public long ssltotecdhe521keyexchanges
    {
      get => this.ssltotecdhe521keyexchangesField;
      private set => this.ssltotecdhe521keyexchangesField = value;
    }

    public long sslmd5macrate
    {
      get => this.sslmd5macrateField;
      private set => this.sslmd5macrateField = value;
    }

    public long sslswdecferate
    {
      get => this.sslswdecferateField;
      private set => this.sslswdecferateField = value;
    }

    public long sslcards
    {
      get => this.sslcardsField;
      private set => this.sslcardsField = value;
    }

    public long sslhwencberate
    {
      get => this.sslhwencberateField;
      private set => this.sslhwencberateField = value;
    }

    public long ssltotoffloadbulkaesgcm128
    {
      get => this.ssltotoffloadbulkaesgcm128Field;
      private set => this.ssltotoffloadbulkaesgcm128Field = value;
    }

    public long sslnullciphersrate
    {
      get => this.sslnullciphersrateField;
      private set => this.sslnullciphersrateField = value;
    }

    public long sslbetot128bitrc4ciphers
    {
      get => this.sslbetot128bitrc4ciphersField;
      private set => this.sslbetot128bitrc4ciphersField = value;
    }

    public long ssltotsslv3sessions
    {
      get => this.ssltotsslv3sessionsField;
      private set => this.ssltotsslv3sessionsField = value;
    }

    public long ssltotdh2048keyexchanges
    {
      get => this.ssltotdh2048keyexchangesField;
      private set => this.ssltotdh2048keyexchangesField = value;
    }

    public long ssltlsv1handshakesrate
    {
      get => this.ssltlsv1handshakesrateField;
      private set => this.ssltlsv1handshakesrateField = value;
    }

    public long sslbetotdh1024keyexchanges
    {
      get => this.sslbetotdh1024keyexchangesField;
      private set => this.sslbetotdh1024keyexchangesField = value;
    }

    public long ssltotswdecbe
    {
      get => this.ssltotswdecbeField;
      private set => this.ssltotswdecbeField = value;
    }

    public long ssltotnewsessions
    {
      get => this.ssltotnewsessionsField;
      private set => this.ssltotnewsessionsField = value;
    }

    public long sslecdhe224keyexchangesrate
    {
      get => this.sslecdhe224keyexchangesrateField;
      private set => this.sslecdhe224keyexchangesrateField = value;
    }

    public long ssltottlsv1sessions
    {
      get => this.ssltottlsv1sessionsField;
      private set => this.ssltottlsv1sessionsField = value;
    }

    public long ssltot128bitrc2ciphers
    {
      get => this.ssltot128bitrc2ciphersField;
      private set => this.ssltot128bitrc2ciphersField = value;
    }

    public long sslbe64bitrc4ciphersrate
    {
      get => this.sslbe64bitrc4ciphersrateField;
      private set => this.sslbe64bitrc4ciphersrateField = value;
    }

    public long sslbetotrsa1024keyexchanges
    {
      get => this.sslbetotrsa1024keyexchangesField;
      private set => this.sslbetotrsa1024keyexchangesField = value;
    }

    public long sslbetottlsv1sessions
    {
      get => this.sslbetottlsv1sessionsField;
      private set => this.sslbetottlsv1sessionsField = value;
    }

    public long sslbersa1024keyexchangesrate
    {
      get => this.sslbersa1024keyexchangesrateField;
      private set => this.sslbersa1024keyexchangesrateField = value;
    }

    public long ssltotbkendcipheraes256
    {
      get => this.ssltotbkendcipheraes256Field;
      private set => this.ssltotbkendcipheraes256Field = value;
    }

    public long sslenginestatus
    {
      get => this.sslenginestatusField;
      private set => this.sslenginestatusField = value;
    }

    public long ssltotswencbe
    {
      get => this.ssltotswencbeField;
      private set => this.ssltotswencbeField = value;
    }

    public long sslbersa512keyexchangesrate
    {
      get => this.sslbersa512keyexchangesrateField;
      private set => this.sslbersa512keyexchangesrateField = value;
    }

    public long sslbetottlsv12sessions
    {
      get => this.sslbetottlsv12sessionsField;
      private set => this.sslbetottlsv12sessionsField = value;
    }

    public long ssltlsv1transactionsrate
    {
      get => this.ssltlsv1transactionsrateField;
      private set => this.ssltlsv1transactionsrateField = value;
    }

    public long sslbetotecdhecurve521
    {
      get => this.sslbetotecdhecurve521Field;
      private set => this.sslbetotecdhecurve521Field = value;
    }

    public long sslbe56bitdesciphersrate
    {
      get => this.sslbe56bitdesciphersrateField;
      private set => this.sslbe56bitdesciphersrateField = value;
    }

    public long ssltlsv11renegsessionsrate
    {
      get => this.ssltlsv11renegsessionsrateField;
      private set => this.ssltlsv11renegsessionsrateField = value;
    }

    public long ssltlsv12handshakesrate
    {
      get => this.ssltlsv12handshakesrateField;
      private set => this.ssltlsv12handshakesrateField = value;
    }

    public long sslbeecdhecurve384rate
    {
      get => this.sslbeecdhecurve384rateField;
      private set => this.sslbeecdhecurve384rateField = value;
    }

    public long ssl56bitrc2ciphersrate
    {
      get => this.ssl56bitrc2ciphersrateField;
      private set => this.ssl56bitrc2ciphersrateField = value;
    }

    public long ssloffloaddhkeyexchangesrate
    {
      get => this.ssloffloaddhkeyexchangesrateField;
      private set => this.ssloffloaddhkeyexchangesrateField = value;
    }

    public long sslsslv2sessionsrate
    {
      get => this.sslsslv2sessionsrateField;
      private set => this.sslsslv2sessionsrateField = value;
    }

    public long sslswencberate
    {
      get => this.sslswencberateField;
      private set => this.sslswencberateField = value;
    }

    public long ssl256bitaesgcmciphersrate
    {
      get => this.ssl256bitaesgcmciphersrateField;
      private set => this.ssl256bitaesgcmciphersrateField = value;
    }

    public long ssltottlsv12clientauthentications
    {
      get => this.ssltottlsv12clientauthenticationsField;
      private set => this.ssltottlsv12clientauthenticationsField = value;
    }

    public long ssloffloadsignrsarate
    {
      get => this.ssloffloadsignrsarateField;
      private set => this.ssloffloadsignrsarateField = value;
    }

    public long sslencferate
    {
      get => this.sslencferateField;
      private set => this.sslencferateField = value;
    }

    public long sslbesslv3clientauthenticationsrate
    {
      get => this.sslbesslv3clientauthenticationsrateField;
      private set => this.sslbesslv3clientauthenticationsrateField = value;
    }

    public long ssltotoffloadbulkrc4
    {
      get => this.ssltotoffloadbulkrc4Field;
      private set => this.ssltotoffloadbulkrc4Field = value;
    }

    public long ssl128bitideaciphersrate
    {
      get => this.ssl128bitideaciphersrateField;
      private set => this.ssl128bitideaciphersrateField = value;
    }

    internal override base_resource[] get_nitro_response(
      nitro_service service,
      string response)
    {
      ssl_stats[] sslStatsArray = new ssl_stats[1];
      ssl_stats.ssl_response sslResponse = new ssl_stats.ssl_response();
      ssl_stats.ssl_response resource = (ssl_stats.ssl_response) service.get_payload_formatter().string_to_resource(sslResponse.GetType(), response);
      if (resource.errorcode != 0)
      {
        if (resource.errorcode == 444)
          service.clear_session();
        if (resource.severity == null)
          throw new nitro_exception(resource.message, resource.errorcode);
        if (resource.severity.Equals("ERROR"))
          throw new nitro_exception(resource.message, resource.errorcode);
      }
      sslStatsArray[0] = resource.ssl;
      return (base_resource[]) sslStatsArray;
    }

    internal override string get_object_name() => (string) null;

    public static ssl_stats get(nitro_service service) => ((ssl_stats[]) new ssl_stats().stat_resources(service, (options) null))[0];

    public static ssl_stats get(nitro_service service, options option) => ((ssl_stats[]) new ssl_stats().stat_resources(service, option))[0];

    private class ssl_response : base_response
    {
      public ssl_stats ssl = (ssl_stats) null;
    }

    public static class clearstatsEnum
    {
      public const string basic = "basic";
      public const string full = "full";
    }
  }
}
