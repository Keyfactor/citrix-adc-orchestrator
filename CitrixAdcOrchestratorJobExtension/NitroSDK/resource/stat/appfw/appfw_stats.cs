// Decompiled with JetBrains decompiler
// Type: com.citrix.netscaler.nitro.resource.stat.appfw.appfw_stats
// Assembly: nitro, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 6CF5DDEF-E052-4F9D-953F-6644F8378A66


using com.citrix.netscaler.nitro.exception;
using com.citrix.netscaler.nitro.resource.Base;
using com.citrix.netscaler.nitro.service;

namespace com.citrix.netscaler.nitro.resource.stat.appfw
{
  public class appfw_stats : base_resource
  {
    private string clearstatsField = (string) null;
    private long appfirewalltotallogField = 0;
    private long appfirewalllograteField = 0;
    private long appfirewalltotalviolField = 0;
    private long appfirewallviolrateField = 0;
    private long appfirewallshortavgresptimeField = 0;
    private long appfirewalllongavgresptimeField = 0;
    private long appfirewallrequestsField = 0;
    private long appfirewallrequestsrateField = 0;
    private long appfirewallreqbytesField = 0;
    private long appfirewallreqbytesrateField = 0;
    private long appfirewallresponsesField = 0;
    private long appfirewallresponsesrateField = 0;
    private long appfirewallresbytesField = 0;
    private long appfirewallresbytesrateField = 0;
    private long appfirewallabortsField = 0;
    private long appfirewallabortsrateField = 0;
    private long appfirewallredirectsField = 0;
    private long appfirewallredirectsrateField = 0;
    private long appfirewalltrapsdroppedField = 0;
    private long appfirewallviolstarturlField = 0;
    private long appfirewallviolstarturlrateField = 0;
    private long appfirewallvioldenyurlField = 0;
    private long appfirewallvioldenyurlrateField = 0;
    private long appfirewallviolrefererheaderField = 0;
    private long appfirewallviolrefererheaderrateField = 0;
    private long appfirewallviolbufferoverflowField = 0;
    private long appfirewallviolbufferoverflowrateField = 0;
    private long appfirewallviolcookieField = 0;
    private long appfirewallviolcookierateField = 0;
    private long appfirewallviolcsrftagField = 0;
    private long appfirewallviolcsrftagrateField = 0;
    private long appfirewallviolxssField = 0;
    private long appfirewallviolxssrateField = 0;
    private long appfirewallviolsqlField = 0;
    private long appfirewallviolsqlrateField = 0;
    private long appfirewallviolfieldformatField = 0;
    private long appfirewallviolfieldformatrateField = 0;
    private long appfirewallviolfieldconsistencyField = 0;
    private long appfirewallviolfieldconsistencyrateField = 0;
    private long appfirewallviolcreditcardField = 0;
    private long appfirewallviolcreditcardrateField = 0;
    private long appfirewallviolsafeobjectField = 0;
    private long appfirewallviolsafeobjectrateField = 0;
    private long appfirewallviolsignatureField = 0;
    private long appfirewallviolsignaturerateField = 0;
    private long appfirewallviolcontenttypeField = 0;
    private long appfirewallviolcontenttyperateField = 0;
    private long appfirewallviolwellformednessviolationsField = 0;
    private long appfirewallviolwellformednessviolationsrateField = 0;
    private long appfirewallviolxdosviolationsField = 0;
    private long appfirewallviolxdosviolationsrateField = 0;
    private long appfirewallviolmsgvalviolationsField = 0;
    private long appfirewallviolmsgvalviolationsrateField = 0;
    private long appfirewallviolwsiviolationsField = 0;
    private long appfirewallviolwsiviolationsrateField = 0;
    private long appfirewallviolxmlsqlviolationsField = 0;
    private long appfirewallviolxmlsqlviolationsrateField = 0;
    private long appfirewallviolxmlxssviolationsField = 0;
    private long appfirewallviolxmlxssviolationsrateField = 0;
    private long appfirewallviolxmlattachmentviolationsField = 0;
    private long appfirewallviolxmlattachmentviolationsrateField = 0;
    private long appfirewallviolxmlsoapfaultviolationsField = 0;
    private long appfirewallviolxmlsoapfaultviolationsrateField = 0;
    private long appfirewallviolxmlgenviolationsField = 0;
    private long appfirewallviolxmlgenviolationsrateField = 0;
    private long appfirewalllogstarturlField = 0;
    private long appfirewalllogstarturlrateField = 0;
    private long appfirewalllogdenyurlField = 0;
    private long appfirewalllogdenyurlrateField = 0;
    private long appfirewalllogrefererheaderField = 0;
    private long appfirewalllogrefererheaderrateField = 0;
    private long appfirewalllogbufferoverflowField = 0;
    private long appfirewalllogbufferoverflowrateField = 0;
    private long appfirewalllogcookieField = 0;
    private long appfirewalllogcookierateField = 0;
    private long appfirewalllogcsrftagField = 0;
    private long appfirewalllogcsrftagrateField = 0;
    private long appfirewalllogxssField = 0;
    private long appfirewalllogxssrateField = 0;
    private long appfirewalllogtransformxssField = 0;
    private long appfirewalllogtransformxssrateField = 0;
    private long appfirewalllogsqlField = 0;
    private long appfirewalllogsqlrateField = 0;
    private long appfirewalllogtransformsqlField = 0;
    private long appfirewalllogtransformsqlrateField = 0;
    private long appfirewalllogfieldformatField = 0;
    private long appfirewalllogfieldformatrateField = 0;
    private long appfirewalllogfieldconsistencyField = 0;
    private long appfirewalllogfieldconsistencyrateField = 0;
    private long appfirewalllogcreditcardField = 0;
    private long appfirewalllogcreditcardrateField = 0;
    private long appfirewalllogsafeobjectField = 0;
    private long appfirewalllogsafeobjectrateField = 0;
    private long appfirewallsignaturelogsField = 0;
    private long appfirewallsignaturelogsrateField = 0;
    private long appfirewalllogcontenttypeField = 0;
    private long appfirewalllogcontenttyperateField = 0;
    private long appfirewallwellformednesslogsField = 0;
    private long appfirewallwellformednesslogsrateField = 0;
    private long appfirewallxdoslogsField = 0;
    private long appfirewallxdoslogsrateField = 0;
    private long appfirewallmsgvallogsField = 0;
    private long appfirewallmsgvallogsrateField = 0;
    private long appfirewallwsilogsField = 0;
    private long appfirewallwsilogsrateField = 0;
    private long appfirewallxmlsqllogsField = 0;
    private long appfirewallxmlsqllogsrateField = 0;
    private long appfirewallxmlxsslogsField = 0;
    private long appfirewallxmlxsslogsrateField = 0;
    private long appfirewallxmlattachmentlogsField = 0;
    private long appfirewallxmlattachmentlogsrateField = 0;
    private long appfirewallxmlsoapfaultlogsField = 0;
    private long appfirewallxmlsoapfaultlogsrateField = 0;
    private long appfirewallxmlgenlogsField = 0;
    private long appfirewallxmlgenlogsrateField = 0;
    private long appfirewallret4xxField = 0;
    private long appfirewallret4xxrateField = 0;
    private long appfirewallret5xxField = 0;
    private long appfirewallret5xxrateField = 0;

    public string clearstats
    {
      get => this.clearstatsField;
      set => this.clearstatsField = value;
    }

    public long appfirewallredirectsrate
    {
      get => this.appfirewallredirectsrateField;
      private set => this.appfirewallredirectsrateField = value;
    }

    public long appfirewallviolcookierate
    {
      get => this.appfirewallviolcookierateField;
      private set => this.appfirewallviolcookierateField = value;
    }

    public long appfirewallsignaturelogs
    {
      get => this.appfirewallsignaturelogsField;
      private set => this.appfirewallsignaturelogsField = value;
    }

    public long appfirewalllogdenyurl
    {
      get => this.appfirewalllogdenyurlField;
      private set => this.appfirewalllogdenyurlField = value;
    }

    public long appfirewalllogsqlrate
    {
      get => this.appfirewalllogsqlrateField;
      private set => this.appfirewalllogsqlrateField = value;
    }

    public long appfirewallviolfieldconsistency
    {
      get => this.appfirewallviolfieldconsistencyField;
      private set => this.appfirewallviolfieldconsistencyField = value;
    }

    public long appfirewallviolbufferoverflowrate
    {
      get => this.appfirewallviolbufferoverflowrateField;
      private set => this.appfirewallviolbufferoverflowrateField = value;
    }

    public long appfirewalllogtransformsql
    {
      get => this.appfirewalllogtransformsqlField;
      private set => this.appfirewalllogtransformsqlField = value;
    }

    public long appfirewallviolxssrate
    {
      get => this.appfirewallviolxssrateField;
      private set => this.appfirewallviolxssrateField = value;
    }

    public long appfirewalllogtransformsqlrate
    {
      get => this.appfirewalllogtransformsqlrateField;
      private set => this.appfirewalllogtransformsqlrateField = value;
    }

    public long appfirewalltotalviol
    {
      get => this.appfirewalltotalviolField;
      private set => this.appfirewalltotalviolField = value;
    }

    public long appfirewallwellformednesslogs
    {
      get => this.appfirewallwellformednesslogsField;
      private set => this.appfirewallwellformednesslogsField = value;
    }

    public long appfirewallviolsafeobjectrate
    {
      get => this.appfirewallviolsafeobjectrateField;
      private set => this.appfirewallviolsafeobjectrateField = value;
    }

    public long appfirewallresponsesrate
    {
      get => this.appfirewallresponsesrateField;
      private set => this.appfirewallresponsesrateField = value;
    }

    public long appfirewallviolxmlxssviolations
    {
      get => this.appfirewallviolxmlxssviolationsField;
      private set => this.appfirewallviolxmlxssviolationsField = value;
    }

    public long appfirewallresponses
    {
      get => this.appfirewallresponsesField;
      private set => this.appfirewallresponsesField = value;
    }

    public long appfirewallviolsignature
    {
      get => this.appfirewallviolsignatureField;
      private set => this.appfirewallviolsignatureField = value;
    }

    public long appfirewalllogbufferoverflow
    {
      get => this.appfirewalllogbufferoverflowField;
      private set => this.appfirewalllogbufferoverflowField = value;
    }

    public long appfirewallviolxmlgenviolationsrate
    {
      get => this.appfirewallviolxmlgenviolationsrateField;
      private set => this.appfirewallviolxmlgenviolationsrateField = value;
    }

    public long appfirewallviolrate
    {
      get => this.appfirewallviolrateField;
      private set => this.appfirewallviolrateField = value;
    }

    public long appfirewallabortsrate
    {
      get => this.appfirewallabortsrateField;
      private set => this.appfirewallabortsrateField = value;
    }

    public long appfirewallviolxmlsoapfaultviolationsrate
    {
      get => this.appfirewallviolxmlsoapfaultviolationsrateField;
      private set => this.appfirewallviolxmlsoapfaultviolationsrateField = value;
    }

    public long appfirewallrequestsrate
    {
      get => this.appfirewallrequestsrateField;
      private set => this.appfirewallrequestsrateField = value;
    }

    public long appfirewallwsilogs
    {
      get => this.appfirewallwsilogsField;
      private set => this.appfirewallwsilogsField = value;
    }

    public long appfirewallredirects
    {
      get => this.appfirewallredirectsField;
      private set => this.appfirewallredirectsField = value;
    }

    public long appfirewallsignaturelogsrate
    {
      get => this.appfirewallsignaturelogsrateField;
      private set => this.appfirewallsignaturelogsrateField = value;
    }

    public long appfirewallxdoslogsrate
    {
      get => this.appfirewallxdoslogsrateField;
      private set => this.appfirewallxdoslogsrateField = value;
    }

    public long appfirewalllogtransformxss
    {
      get => this.appfirewalllogtransformxssField;
      private set => this.appfirewalllogtransformxssField = value;
    }

    public long appfirewallxmlattachmentlogsrate
    {
      get => this.appfirewallxmlattachmentlogsrateField;
      private set => this.appfirewallxmlattachmentlogsrateField = value;
    }

    public long appfirewalllogrefererheaderrate
    {
      get => this.appfirewalllogrefererheaderrateField;
      private set => this.appfirewalllogrefererheaderrateField = value;
    }

    public long appfirewalllogcookie
    {
      get => this.appfirewalllogcookieField;
      private set => this.appfirewalllogcookieField = value;
    }

    public long appfirewallviolcreditcardrate
    {
      get => this.appfirewallviolcreditcardrateField;
      private set => this.appfirewallviolcreditcardrateField = value;
    }

    public long appfirewallret5xx
    {
      get => this.appfirewallret5xxField;
      private set => this.appfirewallret5xxField = value;
    }

    public long appfirewallviolmsgvalviolations
    {
      get => this.appfirewallviolmsgvalviolationsField;
      private set => this.appfirewallviolmsgvalviolationsField = value;
    }

    public long appfirewalllongavgresptime
    {
      get => this.appfirewalllongavgresptimeField;
      private set => this.appfirewalllongavgresptimeField = value;
    }

    public long appfirewalllogstarturl
    {
      get => this.appfirewalllogstarturlField;
      private set => this.appfirewalllogstarturlField = value;
    }

    public long appfirewallviolxmlgenviolations
    {
      get => this.appfirewallviolxmlgenviolationsField;
      private set => this.appfirewallviolxmlgenviolationsField = value;
    }

    public long appfirewallviolxmlsoapfaultviolations
    {
      get => this.appfirewallviolxmlsoapfaultviolationsField;
      private set => this.appfirewallviolxmlsoapfaultviolationsField = value;
    }

    public long appfirewallviolsafeobject
    {
      get => this.appfirewallviolsafeobjectField;
      private set => this.appfirewallviolsafeobjectField = value;
    }

    public long appfirewalllogxssrate
    {
      get => this.appfirewalllogxssrateField;
      private set => this.appfirewalllogxssrateField = value;
    }

    public long appfirewallviolsql
    {
      get => this.appfirewallviolsqlField;
      private set => this.appfirewallviolsqlField = value;
    }

    public long appfirewallviolxdosviolationsrate
    {
      get => this.appfirewallviolxdosviolationsrateField;
      private set => this.appfirewallviolxdosviolationsrateField = value;
    }

    public long appfirewalllogcreditcardrate
    {
      get => this.appfirewalllogcreditcardrateField;
      private set => this.appfirewalllogcreditcardrateField = value;
    }

    public long appfirewalllogsql
    {
      get => this.appfirewalllogsqlField;
      private set => this.appfirewalllogsqlField = value;
    }

    public long appfirewalllogdenyurlrate
    {
      get => this.appfirewalllogdenyurlrateField;
      private set => this.appfirewalllogdenyurlrateField = value;
    }

    public long appfirewallxmlsoapfaultlogs
    {
      get => this.appfirewallxmlsoapfaultlogsField;
      private set => this.appfirewallxmlsoapfaultlogsField = value;
    }

    public long appfirewalllogcontenttyperate
    {
      get => this.appfirewalllogcontenttyperateField;
      private set => this.appfirewalllogcontenttyperateField = value;
    }

    public long appfirewallviolxmlattachmentviolationsrate
    {
      get => this.appfirewallviolxmlattachmentviolationsrateField;
      private set => this.appfirewallviolxmlattachmentviolationsrateField = value;
    }

    public long appfirewalllogbufferoverflowrate
    {
      get => this.appfirewalllogbufferoverflowrateField;
      private set => this.appfirewalllogbufferoverflowrateField = value;
    }

    public long appfirewallret5xxrate
    {
      get => this.appfirewallret5xxrateField;
      private set => this.appfirewallret5xxrateField = value;
    }

    public long appfirewalltotallog
    {
      get => this.appfirewalltotallogField;
      private set => this.appfirewalltotallogField = value;
    }

    public long appfirewalllogcookierate
    {
      get => this.appfirewalllogcookierateField;
      private set => this.appfirewalllogcookierateField = value;
    }

    public long appfirewalllogcsrftag
    {
      get => this.appfirewalllogcsrftagField;
      private set => this.appfirewalllogcsrftagField = value;
    }

    public long appfirewallviolxss
    {
      get => this.appfirewallviolxssField;
      private set => this.appfirewallviolxssField = value;
    }

    public long appfirewallviolwellformednessviolations
    {
      get => this.appfirewallviolwellformednessviolationsField;
      private set => this.appfirewallviolwellformednessviolationsField = value;
    }

    public long appfirewallreqbytes
    {
      get => this.appfirewallreqbytesField;
      private set => this.appfirewallreqbytesField = value;
    }

    public long appfirewallxmlattachmentlogs
    {
      get => this.appfirewallxmlattachmentlogsField;
      private set => this.appfirewallxmlattachmentlogsField = value;
    }

    public long appfirewalllogcsrftagrate
    {
      get => this.appfirewalllogcsrftagrateField;
      private set => this.appfirewalllogcsrftagrateField = value;
    }

    public long appfirewallviolmsgvalviolationsrate
    {
      get => this.appfirewallviolmsgvalviolationsrateField;
      private set => this.appfirewallviolmsgvalviolationsrateField = value;
    }

    public long appfirewallviolcontenttyperate
    {
      get => this.appfirewallviolcontenttyperateField;
      private set => this.appfirewallviolcontenttyperateField = value;
    }

    public long appfirewalllograte
    {
      get => this.appfirewalllograteField;
      private set => this.appfirewalllograteField = value;
    }

    public long appfirewallxmlsqllogsrate
    {
      get => this.appfirewallxmlsqllogsrateField;
      private set => this.appfirewallxmlsqllogsrateField = value;
    }

    public long appfirewallxmlgenlogs
    {
      get => this.appfirewallxmlgenlogsField;
      private set => this.appfirewallxmlgenlogsField = value;
    }

    public long appfirewallreqbytesrate
    {
      get => this.appfirewallreqbytesrateField;
      private set => this.appfirewallreqbytesrateField = value;
    }

    public long appfirewalllogsafeobject
    {
      get => this.appfirewalllogsafeobjectField;
      private set => this.appfirewalllogsafeobjectField = value;
    }

    public long appfirewallviolcreditcard
    {
      get => this.appfirewallviolcreditcardField;
      private set => this.appfirewallviolcreditcardField = value;
    }

    public long appfirewalllogrefererheader
    {
      get => this.appfirewalllogrefererheaderField;
      private set => this.appfirewalllogrefererheaderField = value;
    }

    public long appfirewallviolxmlsqlviolationsrate
    {
      get => this.appfirewallviolxmlsqlviolationsrateField;
      private set => this.appfirewallviolxmlsqlviolationsrateField = value;
    }

    public long appfirewallaborts
    {
      get => this.appfirewallabortsField;
      private set => this.appfirewallabortsField = value;
    }

    public long appfirewallviolcsrftagrate
    {
      get => this.appfirewallviolcsrftagrateField;
      private set => this.appfirewallviolcsrftagrateField = value;
    }

    public long appfirewalllogstarturlrate
    {
      get => this.appfirewalllogstarturlrateField;
      private set => this.appfirewalllogstarturlrateField = value;
    }

    public long appfirewallviolcookie
    {
      get => this.appfirewallviolcookieField;
      private set => this.appfirewallviolcookieField = value;
    }

    public long appfirewallxmlxsslogs
    {
      get => this.appfirewallxmlxsslogsField;
      private set => this.appfirewallxmlxsslogsField = value;
    }

    public long appfirewallmsgvallogs
    {
      get => this.appfirewallmsgvallogsField;
      private set => this.appfirewallmsgvallogsField = value;
    }

    public long appfirewallviolwsiviolations
    {
      get => this.appfirewallviolwsiviolationsField;
      private set => this.appfirewallviolwsiviolationsField = value;
    }

    public long appfirewallviolcsrftag
    {
      get => this.appfirewallviolcsrftagField;
      private set => this.appfirewallviolcsrftagField = value;
    }

    public long appfirewallrequests
    {
      get => this.appfirewallrequestsField;
      private set => this.appfirewallrequestsField = value;
    }

    public long appfirewallresbytes
    {
      get => this.appfirewallresbytesField;
      private set => this.appfirewallresbytesField = value;
    }

    public long appfirewallviolbufferoverflow
    {
      get => this.appfirewallviolbufferoverflowField;
      private set => this.appfirewallviolbufferoverflowField = value;
    }

    public long appfirewallviolsignaturerate
    {
      get => this.appfirewallviolsignaturerateField;
      private set => this.appfirewallviolsignaturerateField = value;
    }

    public long appfirewallviolxmlxssviolationsrate
    {
      get => this.appfirewallviolxmlxssviolationsrateField;
      private set => this.appfirewallviolxmlxssviolationsrateField = value;
    }

    public long appfirewallviolxdosviolations
    {
      get => this.appfirewallviolxdosviolationsField;
      private set => this.appfirewallviolxdosviolationsField = value;
    }

    public long appfirewalllogsafeobjectrate
    {
      get => this.appfirewalllogsafeobjectrateField;
      private set => this.appfirewalllogsafeobjectrateField = value;
    }

    public long appfirewallxdoslogs
    {
      get => this.appfirewallxdoslogsField;
      private set => this.appfirewallxdoslogsField = value;
    }

    public long appfirewallviolcontenttype
    {
      get => this.appfirewallviolcontenttypeField;
      private set => this.appfirewallviolcontenttypeField = value;
    }

    public long appfirewallviolfieldconsistencyrate
    {
      get => this.appfirewallviolfieldconsistencyrateField;
      private set => this.appfirewallviolfieldconsistencyrateField = value;
    }

    public long appfirewalllogtransformxssrate
    {
      get => this.appfirewalllogtransformxssrateField;
      private set => this.appfirewalllogtransformxssrateField = value;
    }

    public long appfirewalllogfieldformatrate
    {
      get => this.appfirewalllogfieldformatrateField;
      private set => this.appfirewalllogfieldformatrateField = value;
    }

    public long appfirewallwellformednesslogsrate
    {
      get => this.appfirewallwellformednesslogsrateField;
      private set => this.appfirewallwellformednesslogsrateField = value;
    }

    public long appfirewallviolwsiviolationsrate
    {
      get => this.appfirewallviolwsiviolationsrateField;
      private set => this.appfirewallviolwsiviolationsrateField = value;
    }

    public long appfirewalllogcreditcard
    {
      get => this.appfirewalllogcreditcardField;
      private set => this.appfirewalllogcreditcardField = value;
    }

    public long appfirewallviolwellformednessviolationsrate
    {
      get => this.appfirewallviolwellformednessviolationsrateField;
      private set => this.appfirewallviolwellformednessviolationsrateField = value;
    }

    public long appfirewallviolfieldformatrate
    {
      get => this.appfirewallviolfieldformatrateField;
      private set => this.appfirewallviolfieldformatrateField = value;
    }

    public long appfirewalllogfieldconsistencyrate
    {
      get => this.appfirewalllogfieldconsistencyrateField;
      private set => this.appfirewalllogfieldconsistencyrateField = value;
    }

    public long appfirewallvioldenyurl
    {
      get => this.appfirewallvioldenyurlField;
      private set => this.appfirewallvioldenyurlField = value;
    }

    public long appfirewallviolxmlattachmentviolations
    {
      get => this.appfirewallviolxmlattachmentviolationsField;
      private set => this.appfirewallviolxmlattachmentviolationsField = value;
    }

    public long appfirewallviolsqlrate
    {
      get => this.appfirewallviolsqlrateField;
      private set => this.appfirewallviolsqlrateField = value;
    }

    public long appfirewallviolstarturlrate
    {
      get => this.appfirewallviolstarturlrateField;
      private set => this.appfirewallviolstarturlrateField = value;
    }

    public long appfirewallviolxmlsqlviolations
    {
      get => this.appfirewallviolxmlsqlviolationsField;
      private set => this.appfirewallviolxmlsqlviolationsField = value;
    }

    public long appfirewallshortavgresptime
    {
      get => this.appfirewallshortavgresptimeField;
      private set => this.appfirewallshortavgresptimeField = value;
    }

    public long appfirewallxmlgenlogsrate
    {
      get => this.appfirewallxmlgenlogsrateField;
      private set => this.appfirewallxmlgenlogsrateField = value;
    }

    public long appfirewalllogfieldformat
    {
      get => this.appfirewalllogfieldformatField;
      private set => this.appfirewalllogfieldformatField = value;
    }

    public long appfirewallxmlxsslogsrate
    {
      get => this.appfirewallxmlxsslogsrateField;
      private set => this.appfirewallxmlxsslogsrateField = value;
    }

    public long appfirewallresbytesrate
    {
      get => this.appfirewallresbytesrateField;
      private set => this.appfirewallresbytesrateField = value;
    }

    public long appfirewallviolrefererheader
    {
      get => this.appfirewallviolrefererheaderField;
      private set => this.appfirewallviolrefererheaderField = value;
    }

    public long appfirewallviolrefererheaderrate
    {
      get => this.appfirewallviolrefererheaderrateField;
      private set => this.appfirewallviolrefererheaderrateField = value;
    }

    public long appfirewalllogxss
    {
      get => this.appfirewalllogxssField;
      private set => this.appfirewalllogxssField = value;
    }

    public long appfirewalltrapsdropped
    {
      get => this.appfirewalltrapsdroppedField;
      private set => this.appfirewalltrapsdroppedField = value;
    }

    public long appfirewallviolstarturl
    {
      get => this.appfirewallviolstarturlField;
      private set => this.appfirewallviolstarturlField = value;
    }

    public long appfirewallret4xxrate
    {
      get => this.appfirewallret4xxrateField;
      private set => this.appfirewallret4xxrateField = value;
    }

    public long appfirewallxmlsqllogs
    {
      get => this.appfirewallxmlsqllogsField;
      private set => this.appfirewallxmlsqllogsField = value;
    }

    public long appfirewallwsilogsrate
    {
      get => this.appfirewallwsilogsrateField;
      private set => this.appfirewallwsilogsrateField = value;
    }

    public long appfirewallxmlsoapfaultlogsrate
    {
      get => this.appfirewallxmlsoapfaultlogsrateField;
      private set => this.appfirewallxmlsoapfaultlogsrateField = value;
    }

    public long appfirewallvioldenyurlrate
    {
      get => this.appfirewallvioldenyurlrateField;
      private set => this.appfirewallvioldenyurlrateField = value;
    }

    public long appfirewalllogcontenttype
    {
      get => this.appfirewalllogcontenttypeField;
      private set => this.appfirewalllogcontenttypeField = value;
    }

    public long appfirewallmsgvallogsrate
    {
      get => this.appfirewallmsgvallogsrateField;
      private set => this.appfirewallmsgvallogsrateField = value;
    }

    public long appfirewallret4xx
    {
      get => this.appfirewallret4xxField;
      private set => this.appfirewallret4xxField = value;
    }

    public long appfirewallviolfieldformat
    {
      get => this.appfirewallviolfieldformatField;
      private set => this.appfirewallviolfieldformatField = value;
    }

    public long appfirewalllogfieldconsistency
    {
      get => this.appfirewalllogfieldconsistencyField;
      private set => this.appfirewalllogfieldconsistencyField = value;
    }

    internal override base_resource[] get_nitro_response(
      nitro_service service,
      string response)
    {
      appfw_stats[] appfwStatsArray = new appfw_stats[1];
      appfw_stats.appfw_response appfwResponse = new appfw_stats.appfw_response();
      appfw_stats.appfw_response resource = (appfw_stats.appfw_response) service.get_payload_formatter().string_to_resource(appfwResponse.GetType(), response);
      if (resource.errorcode != 0)
      {
        if (resource.errorcode == 444)
          service.clear_session();
        if (resource.severity == null)
          throw new nitro_exception(resource.message, resource.errorcode);
        if (resource.severity.Equals("ERROR"))
          throw new nitro_exception(resource.message, resource.errorcode);
      }
      appfwStatsArray[0] = resource.appfw;
      return (base_resource[]) appfwStatsArray;
    }

    internal override string get_object_name() => (string) null;

    public static appfw_stats get(nitro_service service) => ((appfw_stats[]) new appfw_stats().stat_resources(service, (options) null))[0];

    public static appfw_stats get(nitro_service service, options option) => ((appfw_stats[]) new appfw_stats().stat_resources(service, option))[0];

    private class appfw_response : base_response
    {
      public appfw_stats appfw = (appfw_stats) null;
    }

    public static class clearstatsEnum
    {
      public const string basic = "basic";
      public const string full = "full";
    }
  }
}
