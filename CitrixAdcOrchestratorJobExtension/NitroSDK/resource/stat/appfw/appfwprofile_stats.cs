// Decompiled with JetBrains decompiler
// Type: com.citrix.netscaler.nitro.resource.stat.appfw.appfwprofile_stats
// Assembly: nitro, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 6CF5DDEF-E052-4F9D-953F-6644F8378A66


using com.citrix.netscaler.nitro.exception;
using com.citrix.netscaler.nitro.resource.Base;
using com.citrix.netscaler.nitro.service;

namespace com.citrix.netscaler.nitro.resource.stat.appfw
{
  public class appfwprofile_stats : base_resource
  {
    private string nameField = (string) null;
    private string clearstatsField = (string) null;
    private long appfirewallrequestsperprofileField = 0;
    private long appfirewallrequestsperprofilerateField = 0;
    private long appfirewallreqbytesperprofileField = 0;
    private long appfirewallreqbytesperprofilerateField = 0;
    private long appfirewallresponsesperprofileField = 0;
    private long appfirewallresponsesperprofilerateField = 0;
    private long appfirewallresbytesperprofileField = 0;
    private long appfirewallresbytesperprofilerateField = 0;
    private long appfirewallabortsperprofileField = 0;
    private long appfirewallabortsperprofilerateField = 0;
    private long appfirewallredirectsperprofileField = 0;
    private long appfirewallredirectsperprofilerateField = 0;
    private long appfirewalllongavgresptimeperprofileField = 0;
    private long appfirewallshortavgresptimeperprofileField = 0;
    private long appfirewallviolstarturlperprofileField = 0;
    private long appfirewallviolstarturlperprofilerateField = 0;
    private long appfirewallvioldenyurlperprofileField = 0;
    private long appfirewallvioldenyurlperprofilerateField = 0;
    private long appfirewallviolrefererheaderperprofileField = 0;
    private long appfirewallviolrefererheaderperprofilerateField = 0;
    private long appfirewallviolbufferoverflowperprofileField = 0;
    private long appfirewallviolbufferoverflowperprofilerateField = 0;
    private long appfirewallviolcookieperprofileField = 0;
    private long appfirewallviolcookieperprofilerateField = 0;
    private long appfirewallviolcsrftagperprofileField = 0;
    private long appfirewallviolcsrftagperprofilerateField = 0;
    private long appfirewallviolxssperprofileField = 0;
    private long appfirewallviolxssperprofilerateField = 0;
    private long appfirewallviolsqlperprofileField = 0;
    private long appfirewallviolsqlperprofilerateField = 0;
    private long appfirewallviolfieldformatperprofileField = 0;
    private long appfirewallviolfieldformatperprofilerateField = 0;
    private long appfirewallviolfieldconsistencyperprofileField = 0;
    private long appfirewallviolfieldconsistencyperprofilerateField = 0;
    private long appfirewallviolcreditcardperprofileField = 0;
    private long appfirewallviolcreditcardperprofilerateField = 0;
    private long appfirewallviolsafeobjectperprofileField = 0;
    private long appfirewallviolsafeobjectperprofilerateField = 0;
    private long appfirewallviolsignatureperprofileField = 0;
    private long appfirewallviolsignatureperprofilerateField = 0;
    private long appfirewallviolcontenttypeperprofileField = 0;
    private long appfirewallviolcontenttypeperprofilerateField = 0;
    private long appfirewallviolwellformednessviolationsperprofileField = 0;
    private long appfirewallviolwellformednessviolationsperprofilerateField = 0;
    private long appfirewallviolxdosviolationsperprofileField = 0;
    private long appfirewallviolxdosviolationsperprofilerateField = 0;
    private long appfirewallviolmsgvalviolationsperprofileField = 0;
    private long appfirewallviolmsgvalviolationsperprofilerateField = 0;
    private long appfirewallviolwsiviolationsperprofileField = 0;
    private long appfirewallviolwsiviolationsperprofilerateField = 0;
    private long appfirewallviolxmlsqlviolationsperprofileField = 0;
    private long appfirewallviolxmlsqlviolationsperprofilerateField = 0;
    private long appfirewallviolxmlxssviolationsperprofileField = 0;
    private long appfirewallviolxmlxssviolationsperprofilerateField = 0;
    private long appfirewallviolxmlattachmentviolationsperprofileField = 0;
    private long appfirewallviolxmlattachmentviolationsperprofilerateField = 0;
    private long appfirewallviolxmlsoapfaultviolationsperprofileField = 0;
    private long appfirewallviolxmlsoapfaultviolationsperprofilerateField = 0;
    private long appfirewallviolxmlgenericviolationsperprofileField = 0;
    private long appfirewallviolxmlgenericviolationsperprofilerateField = 0;
    private long appfirewalltotalviolperprofileField = 0;
    private long appfirewallviolperprofilerateField = 0;
    private long appfirewalllogstarturlperprofileField = 0;
    private long appfirewalllogstarturlperprofilerateField = 0;
    private long appfirewalllogdenyurlperprofileField = 0;
    private long appfirewalllogdenyurlperprofilerateField = 0;
    private long appfirewalllogrefererheaderperprofileField = 0;
    private long appfirewalllogrefererheaderperprofilerateField = 0;
    private long appfirewalllogbufferoverflowperprofileField = 0;
    private long appfirewalllogbufferoverflowperprofilerateField = 0;
    private long appfirewalllogcookieperprofileField = 0;
    private long appfirewalllogcookieperprofilerateField = 0;
    private long appfirewalllogcsrftagperprofileField = 0;
    private long appfirewalllogcsrftagperprofilerateField = 0;
    private long appfirewalllogxssperprofileField = 0;
    private long appfirewalllogxssperprofilerateField = 0;
    private long appfirewalllogxformxssperprofileField = 0;
    private long appfirewalllogxformxssperprofilerateField = 0;
    private long appfirewalllogsqlperprofileField = 0;
    private long appfirewalllogsqlperprofilerateField = 0;
    private long appfirewalllogxformsqlperprofileField = 0;
    private long appfirewalllogxformsqlperprofilerateField = 0;
    private long appfirewalllogfieldformatperprofileField = 0;
    private long appfirewalllogfieldformatperprofilerateField = 0;
    private long appfirewalllogfieldconsistencyperprofileField = 0;
    private long appfirewalllogfieldconsistencyperprofilerateField = 0;
    private long appfirewalllogcreditcardperprofileField = 0;
    private long appfirewalllogcreditcardperprofilerateField = 0;
    private long appfirewallxformlogcreditcardperprofileField = 0;
    private long appfirewallxformlogcreditcardperprofilerateField = 0;
    private long appfirewalllogsafeobjectperprofileField = 0;
    private long appfirewalllogsafeobjectperprofilerateField = 0;
    private long appfirewalllogcontenttypeperprofileField = 0;
    private long appfirewalllogcontenttypeperprofilerateField = 0;
    private long appfirewallwellformednesslogsperprofileField = 0;
    private long appfirewallwellformednesslogsperprofilerateField = 0;
    private long appfirewallxdoslogsperprofileField = 0;
    private long appfirewallxdoslogsperprofilerateField = 0;
    private long appfirewallmsgvallogsperprofileField = 0;
    private long appfirewallmsgvallogsperprofilerateField = 0;
    private long appfirewallwsilogsperprofileField = 0;
    private long appfirewallwsilogsperprofilerateField = 0;
    private long appfirewallxmlsqllogsperprofileField = 0;
    private long appfirewallxmlsqllogsperprofilerateField = 0;
    private long appfirewallxmlxsslogsperprofileField = 0;
    private long appfirewallxmlxsslogsperprofilerateField = 0;
    private long appfirewallxmlattachmentlogsperprofileField = 0;
    private long appfirewallxmlattachmentlogsperprofilerateField = 0;
    private long appfirewallxmlsoapfaultlogsperprofileField = 0;
    private long appfirewallxmlsoapfaultlogsperprofilerateField = 0;
    private long appfirewallxmlgenericlogsperprofileField = 0;
    private long appfirewallxmlgenericlogsperprofilerateField = 0;
    private long appfirewalltotallogperprofileField = 0;
    private long appfirewalllogperprofilerateField = 0;
    private long appfirewallret4xxperprofileField = 0;
    private long appfirewallret4xxperprofilerateField = 0;
    private long appfirewallret5xxperprofileField = 0;
    private long appfirewallret5xxperprofilerateField = 0;

    public string name
    {
      get => this.nameField;
      set => this.nameField = value;
    }

    public string clearstats
    {
      get => this.clearstatsField;
      set => this.clearstatsField = value;
    }

    public long appfirewallxmlxsslogsperprofilerate
    {
      get => this.appfirewallxmlxsslogsperprofilerateField;
      private set => this.appfirewallxmlxsslogsperprofilerateField = value;
    }

    public long appfirewallviolmsgvalviolationsperprofile
    {
      get => this.appfirewallviolmsgvalviolationsperprofileField;
      private set => this.appfirewallviolmsgvalviolationsperprofileField = value;
    }

    public long appfirewalllogcontenttypeperprofile
    {
      get => this.appfirewalllogcontenttypeperprofileField;
      private set => this.appfirewalllogcontenttypeperprofileField = value;
    }

    public long appfirewallviolperprofilerate
    {
      get => this.appfirewallviolperprofilerateField;
      private set => this.appfirewallviolperprofilerateField = value;
    }

    public long appfirewallviolstarturlperprofile
    {
      get => this.appfirewallviolstarturlperprofileField;
      private set => this.appfirewallviolstarturlperprofileField = value;
    }

    public long appfirewalltotalviolperprofile
    {
      get => this.appfirewalltotalviolperprofileField;
      private set => this.appfirewalltotalviolperprofileField = value;
    }

    public long appfirewallret5xxperprofile
    {
      get => this.appfirewallret5xxperprofileField;
      private set => this.appfirewallret5xxperprofileField = value;
    }

    public long appfirewallviolcontenttypeperprofile
    {
      get => this.appfirewallviolcontenttypeperprofileField;
      private set => this.appfirewallviolcontenttypeperprofileField = value;
    }

    public long appfirewallredirectsperprofile
    {
      get => this.appfirewallredirectsperprofileField;
      private set => this.appfirewallredirectsperprofileField = value;
    }

    public long appfirewallresponsesperprofile
    {
      get => this.appfirewallresponsesperprofileField;
      private set => this.appfirewallresponsesperprofileField = value;
    }

    public long appfirewallxmlsqllogsperprofile
    {
      get => this.appfirewallxmlsqllogsperprofileField;
      private set => this.appfirewallxmlsqllogsperprofileField = value;
    }

    public long appfirewallwsilogsperprofile
    {
      get => this.appfirewallwsilogsperprofileField;
      private set => this.appfirewallwsilogsperprofileField = value;
    }

    public long appfirewallrequestsperprofilerate
    {
      get => this.appfirewallrequestsperprofilerateField;
      private set => this.appfirewallrequestsperprofilerateField = value;
    }

    public long appfirewallviolxmlsoapfaultviolationsperprofile
    {
      get => this.appfirewallviolxmlsoapfaultviolationsperprofileField;
      private set => this.appfirewallviolxmlsoapfaultviolationsperprofileField = value;
    }

    public long appfirewalllogbufferoverflowperprofile
    {
      get => this.appfirewalllogbufferoverflowperprofileField;
      private set => this.appfirewalllogbufferoverflowperprofileField = value;
    }

    public long appfirewallviolwsiviolationsperprofilerate
    {
      get => this.appfirewallviolwsiviolationsperprofilerateField;
      private set => this.appfirewallviolwsiviolationsperprofilerateField = value;
    }

    public long appfirewallviolwellformednessviolationsperprofile
    {
      get => this.appfirewallviolwellformednessviolationsperprofileField;
      private set => this.appfirewallviolwellformednessviolationsperprofileField = value;
    }

    public long appfirewallviolfieldformatperprofile
    {
      get => this.appfirewallviolfieldformatperprofileField;
      private set => this.appfirewallviolfieldformatperprofileField = value;
    }

    public long appfirewallviolcookieperprofilerate
    {
      get => this.appfirewallviolcookieperprofilerateField;
      private set => this.appfirewallviolcookieperprofilerateField = value;
    }

    public long appfirewallresbytesperprofilerate
    {
      get => this.appfirewallresbytesperprofilerateField;
      private set => this.appfirewallresbytesperprofilerateField = value;
    }

    public long appfirewalllogxformxssperprofile
    {
      get => this.appfirewalllogxformxssperprofileField;
      private set => this.appfirewalllogxformxssperprofileField = value;
    }

    public long appfirewalllogcookieperprofile
    {
      get => this.appfirewalllogcookieperprofileField;
      private set => this.appfirewalllogcookieperprofileField = value;
    }

    public long appfirewallviolcreditcardperprofilerate
    {
      get => this.appfirewallviolcreditcardperprofilerateField;
      private set => this.appfirewallviolcreditcardperprofilerateField = value;
    }

    public long appfirewallxmlsoapfaultlogsperprofilerate
    {
      get => this.appfirewallxmlsoapfaultlogsperprofilerateField;
      private set => this.appfirewallxmlsoapfaultlogsperprofilerateField = value;
    }

    public long appfirewalllogfieldconsistencyperprofilerate
    {
      get => this.appfirewalllogfieldconsistencyperprofilerateField;
      private set => this.appfirewalllogfieldconsistencyperprofilerateField = value;
    }

    public long appfirewalllogdenyurlperprofile
    {
      get => this.appfirewalllogdenyurlperprofileField;
      private set => this.appfirewalllogdenyurlperprofileField = value;
    }

    public long appfirewallresbytesperprofile
    {
      get => this.appfirewallresbytesperprofileField;
      private set => this.appfirewallresbytesperprofileField = value;
    }

    public long appfirewallviolxssperprofile
    {
      get => this.appfirewallviolxssperprofileField;
      private set => this.appfirewallviolxssperprofileField = value;
    }

    public long appfirewallmsgvallogsperprofilerate
    {
      get => this.appfirewallmsgvallogsperprofilerateField;
      private set => this.appfirewallmsgvallogsperprofilerateField = value;
    }

    public long appfirewallviolxmlsoapfaultviolationsperprofilerate
    {
      get => this.appfirewallviolxmlsoapfaultviolationsperprofilerateField;
      private set => this.appfirewallviolxmlsoapfaultviolationsperprofilerateField = value;
    }

    public long appfirewalllogcsrftagperprofile
    {
      get => this.appfirewalllogcsrftagperprofileField;
      private set => this.appfirewalllogcsrftagperprofileField = value;
    }

    public long appfirewallviolcontenttypeperprofilerate
    {
      get => this.appfirewallviolcontenttypeperprofilerateField;
      private set => this.appfirewallviolcontenttypeperprofilerateField = value;
    }

    public long appfirewallxmlsoapfaultlogsperprofile
    {
      get => this.appfirewallxmlsoapfaultlogsperprofileField;
      private set => this.appfirewallxmlsoapfaultlogsperprofileField = value;
    }

    public long appfirewallxformlogcreditcardperprofilerate
    {
      get => this.appfirewallxformlogcreditcardperprofilerateField;
      private set => this.appfirewallxformlogcreditcardperprofilerateField = value;
    }

    public long appfirewallreqbytesperprofilerate
    {
      get => this.appfirewallreqbytesperprofilerateField;
      private set => this.appfirewallreqbytesperprofilerateField = value;
    }

    public long appfirewallviolmsgvalviolationsperprofilerate
    {
      get => this.appfirewallviolmsgvalviolationsperprofilerateField;
      private set => this.appfirewallviolmsgvalviolationsperprofilerateField = value;
    }

    public long appfirewallxdoslogsperprofile
    {
      get => this.appfirewallxdoslogsperprofileField;
      private set => this.appfirewallxdoslogsperprofileField = value;
    }

    public long appfirewallviolfieldconsistencyperprofilerate
    {
      get => this.appfirewallviolfieldconsistencyperprofilerateField;
      private set => this.appfirewallviolfieldconsistencyperprofilerateField = value;
    }

    public long appfirewalllogrefererheaderperprofilerate
    {
      get => this.appfirewalllogrefererheaderperprofilerateField;
      private set => this.appfirewalllogrefererheaderperprofilerateField = value;
    }

    public long appfirewallxmlattachmentlogsperprofilerate
    {
      get => this.appfirewallxmlattachmentlogsperprofilerateField;
      private set => this.appfirewallxmlattachmentlogsperprofilerateField = value;
    }

    public long appfirewallviolxmlxssviolationsperprofilerate
    {
      get => this.appfirewallviolxmlxssviolationsperprofilerateField;
      private set => this.appfirewallviolxmlxssviolationsperprofilerateField = value;
    }

    public long appfirewallxdoslogsperprofilerate
    {
      get => this.appfirewallxdoslogsperprofilerateField;
      private set => this.appfirewallxdoslogsperprofilerateField = value;
    }

    public long appfirewallxmlxsslogsperprofile
    {
      get => this.appfirewallxmlxsslogsperprofileField;
      private set => this.appfirewallxmlxsslogsperprofileField = value;
    }

    public long appfirewallxmlsqllogsperprofilerate
    {
      get => this.appfirewallxmlsqllogsperprofilerateField;
      private set => this.appfirewallxmlsqllogsperprofilerateField = value;
    }

    public long appfirewallrequestsperprofile
    {
      get => this.appfirewallrequestsperprofileField;
      private set => this.appfirewallrequestsperprofileField = value;
    }

    public long appfirewallviolsignatureperprofile
    {
      get => this.appfirewallviolsignatureperprofileField;
      private set => this.appfirewallviolsignatureperprofileField = value;
    }

    public long appfirewallviolxmlattachmentviolationsperprofilerate
    {
      get => this.appfirewallviolxmlattachmentviolationsperprofilerateField;
      private set => this.appfirewallviolxmlattachmentviolationsperprofilerateField = value;
    }

    public long appfirewallviolsqlperprofilerate
    {
      get => this.appfirewallviolsqlperprofilerateField;
      private set => this.appfirewallviolsqlperprofilerateField = value;
    }

    public long appfirewallviolcsrftagperprofilerate
    {
      get => this.appfirewallviolcsrftagperprofilerateField;
      private set => this.appfirewallviolcsrftagperprofilerateField = value;
    }

    public long appfirewallviolstarturlperprofilerate
    {
      get => this.appfirewallviolstarturlperprofilerateField;
      private set => this.appfirewallviolstarturlperprofilerateField = value;
    }

    public long appfirewalllogxformxssperprofilerate
    {
      get => this.appfirewalllogxformxssperprofilerateField;
      private set => this.appfirewalllogxformxssperprofilerateField = value;
    }

    public long appfirewallviolxmlsqlviolationsperprofile
    {
      get => this.appfirewallviolxmlsqlviolationsperprofileField;
      private set => this.appfirewallviolxmlsqlviolationsperprofileField = value;
    }

    public long appfirewalllogsqlperprofile
    {
      get => this.appfirewalllogsqlperprofileField;
      private set => this.appfirewalllogsqlperprofileField = value;
    }

    public long appfirewallvioldenyurlperprofile
    {
      get => this.appfirewallvioldenyurlperprofileField;
      private set => this.appfirewallvioldenyurlperprofileField = value;
    }

    public long appfirewallredirectsperprofilerate
    {
      get => this.appfirewallredirectsperprofilerateField;
      private set => this.appfirewallredirectsperprofilerateField = value;
    }

    public long appfirewalllogstarturlperprofilerate
    {
      get => this.appfirewalllogstarturlperprofilerateField;
      private set => this.appfirewalllogstarturlperprofilerateField = value;
    }

    public long appfirewallviolcsrftagperprofile
    {
      get => this.appfirewallviolcsrftagperprofileField;
      private set => this.appfirewallviolcsrftagperprofileField = value;
    }

    public long appfirewallwellformednesslogsperprofile
    {
      get => this.appfirewallwellformednesslogsperprofileField;
      private set => this.appfirewallwellformednesslogsperprofileField = value;
    }

    public long appfirewalllogdenyurlperprofilerate
    {
      get => this.appfirewalllogdenyurlperprofilerateField;
      private set => this.appfirewalllogdenyurlperprofilerateField = value;
    }

    public long appfirewallviolwsiviolationsperprofile
    {
      get => this.appfirewallviolwsiviolationsperprofileField;
      private set => this.appfirewallviolwsiviolationsperprofileField = value;
    }

    public long appfirewallshortavgresptimeperprofile
    {
      get => this.appfirewallshortavgresptimeperprofileField;
      private set => this.appfirewallshortavgresptimeperprofileField = value;
    }

    public long appfirewallviolsafeobjectperprofile
    {
      get => this.appfirewallviolsafeobjectperprofileField;
      private set => this.appfirewallviolsafeobjectperprofileField = value;
    }

    public long appfirewallresponsesperprofilerate
    {
      get => this.appfirewallresponsesperprofilerateField;
      private set => this.appfirewallresponsesperprofilerateField = value;
    }

    public long appfirewallviolrefererheaderperprofilerate
    {
      get => this.appfirewallviolrefererheaderperprofilerateField;
      private set => this.appfirewallviolrefererheaderperprofilerateField = value;
    }

    public long appfirewallvioldenyurlperprofilerate
    {
      get => this.appfirewallvioldenyurlperprofilerateField;
      private set => this.appfirewallvioldenyurlperprofilerateField = value;
    }

    public long appfirewallabortsperprofile
    {
      get => this.appfirewallabortsperprofileField;
      private set => this.appfirewallabortsperprofileField = value;
    }

    public long appfirewallviolcookieperprofile
    {
      get => this.appfirewallviolcookieperprofileField;
      private set => this.appfirewallviolcookieperprofileField = value;
    }

    public long appfirewalllogcreditcardperprofile
    {
      get => this.appfirewalllogcreditcardperprofileField;
      private set => this.appfirewalllogcreditcardperprofileField = value;
    }

    public long appfirewalllogbufferoverflowperprofilerate
    {
      get => this.appfirewalllogbufferoverflowperprofilerateField;
      private set => this.appfirewalllogbufferoverflowperprofilerateField = value;
    }

    public long appfirewallxmlgenericlogsperprofilerate
    {
      get => this.appfirewallxmlgenericlogsperprofilerateField;
      private set => this.appfirewallxmlgenericlogsperprofilerateField = value;
    }

    public long appfirewallret4xxperprofile
    {
      get => this.appfirewallret4xxperprofileField;
      private set => this.appfirewallret4xxperprofileField = value;
    }

    public long appfirewallviolfieldformatperprofilerate
    {
      get => this.appfirewallviolfieldformatperprofilerateField;
      private set => this.appfirewallviolfieldformatperprofilerateField = value;
    }

    public long appfirewalllogxformsqlperprofile
    {
      get => this.appfirewalllogxformsqlperprofileField;
      private set => this.appfirewalllogxformsqlperprofileField = value;
    }

    public long appfirewallviolbufferoverflowperprofilerate
    {
      get => this.appfirewallviolbufferoverflowperprofilerateField;
      private set => this.appfirewallviolbufferoverflowperprofilerateField = value;
    }

    public long appfirewallmsgvallogsperprofile
    {
      get => this.appfirewallmsgvallogsperprofileField;
      private set => this.appfirewallmsgvallogsperprofileField = value;
    }

    public long appfirewallwsilogsperprofilerate
    {
      get => this.appfirewallwsilogsperprofilerateField;
      private set => this.appfirewallwsilogsperprofilerateField = value;
    }

    public long appfirewallviolsqlperprofile
    {
      get => this.appfirewallviolsqlperprofileField;
      private set => this.appfirewallviolsqlperprofileField = value;
    }

    public long appfirewallviolxssperprofilerate
    {
      get => this.appfirewallviolxssperprofilerateField;
      private set => this.appfirewallviolxssperprofilerateField = value;
    }

    public long appfirewallxmlgenericlogsperprofile
    {
      get => this.appfirewallxmlgenericlogsperprofileField;
      private set => this.appfirewallxmlgenericlogsperprofileField = value;
    }

    public long appfirewalllogperprofilerate
    {
      get => this.appfirewalllogperprofilerateField;
      private set => this.appfirewalllogperprofilerateField = value;
    }

    public long appfirewallviolcreditcardperprofile
    {
      get => this.appfirewallviolcreditcardperprofileField;
      private set => this.appfirewallviolcreditcardperprofileField = value;
    }

    public long appfirewallxmlattachmentlogsperprofile
    {
      get => this.appfirewallxmlattachmentlogsperprofileField;
      private set => this.appfirewallxmlattachmentlogsperprofileField = value;
    }

    public long appfirewallviolfieldconsistencyperprofile
    {
      get => this.appfirewallviolfieldconsistencyperprofileField;
      private set => this.appfirewallviolfieldconsistencyperprofileField = value;
    }

    public long appfirewalllogcsrftagperprofilerate
    {
      get => this.appfirewalllogcsrftagperprofilerateField;
      private set => this.appfirewalllogcsrftagperprofilerateField = value;
    }

    public long appfirewallret4xxperprofilerate
    {
      get => this.appfirewallret4xxperprofilerateField;
      private set => this.appfirewallret4xxperprofilerateField = value;
    }

    public long appfirewalllogfieldformatperprofilerate
    {
      get => this.appfirewalllogfieldformatperprofilerateField;
      private set => this.appfirewalllogfieldformatperprofilerateField = value;
    }

    public long appfirewallviolsafeobjectperprofilerate
    {
      get => this.appfirewallviolsafeobjectperprofilerateField;
      private set => this.appfirewallviolsafeobjectperprofilerateField = value;
    }

    public long appfirewalllogxssperprofile
    {
      get => this.appfirewalllogxssperprofileField;
      private set => this.appfirewalllogxssperprofileField = value;
    }

    public long appfirewallviolxmlgenericviolationsperprofile
    {
      get => this.appfirewallviolxmlgenericviolationsperprofileField;
      private set => this.appfirewallviolxmlgenericviolationsperprofileField = value;
    }

    public long appfirewallviolsignatureperprofilerate
    {
      get => this.appfirewallviolsignatureperprofilerateField;
      private set => this.appfirewallviolsignatureperprofilerateField = value;
    }

    public long appfirewalllongavgresptimeperprofile
    {
      get => this.appfirewalllongavgresptimeperprofileField;
      private set => this.appfirewalllongavgresptimeperprofileField = value;
    }

    public long appfirewalllogfieldformatperprofile
    {
      get => this.appfirewalllogfieldformatperprofileField;
      private set => this.appfirewalllogfieldformatperprofileField = value;
    }

    public long appfirewallabortsperprofilerate
    {
      get => this.appfirewallabortsperprofilerateField;
      private set => this.appfirewallabortsperprofilerateField = value;
    }

    public long appfirewalllogcreditcardperprofilerate
    {
      get => this.appfirewalllogcreditcardperprofilerateField;
      private set => this.appfirewalllogcreditcardperprofilerateField = value;
    }

    public long appfirewalllogsqlperprofilerate
    {
      get => this.appfirewalllogsqlperprofilerateField;
      private set => this.appfirewalllogsqlperprofilerateField = value;
    }

    public long appfirewallviolbufferoverflowperprofile
    {
      get => this.appfirewallviolbufferoverflowperprofileField;
      private set => this.appfirewallviolbufferoverflowperprofileField = value;
    }

    public long appfirewalllogsafeobjectperprofilerate
    {
      get => this.appfirewalllogsafeobjectperprofilerateField;
      private set => this.appfirewalllogsafeobjectperprofilerateField = value;
    }

    public long appfirewalllogfieldconsistencyperprofile
    {
      get => this.appfirewalllogfieldconsistencyperprofileField;
      private set => this.appfirewalllogfieldconsistencyperprofileField = value;
    }

    public long appfirewalllogstarturlperprofile
    {
      get => this.appfirewalllogstarturlperprofileField;
      private set => this.appfirewalllogstarturlperprofileField = value;
    }

    public long appfirewallviolxmlsqlviolationsperprofilerate
    {
      get => this.appfirewallviolxmlsqlviolationsperprofilerateField;
      private set => this.appfirewallviolxmlsqlviolationsperprofilerateField = value;
    }

    public long appfirewalllogxssperprofilerate
    {
      get => this.appfirewalllogxssperprofilerateField;
      private set => this.appfirewalllogxssperprofilerateField = value;
    }

    public long appfirewalllogcontenttypeperprofilerate
    {
      get => this.appfirewalllogcontenttypeperprofilerateField;
      private set => this.appfirewalllogcontenttypeperprofilerateField = value;
    }

    public long appfirewallwellformednesslogsperprofilerate
    {
      get => this.appfirewallwellformednesslogsperprofilerateField;
      private set => this.appfirewallwellformednesslogsperprofilerateField = value;
    }

    public long appfirewallreqbytesperprofile
    {
      get => this.appfirewallreqbytesperprofileField;
      private set => this.appfirewallreqbytesperprofileField = value;
    }

    public long appfirewalllogsafeobjectperprofile
    {
      get => this.appfirewalllogsafeobjectperprofileField;
      private set => this.appfirewalllogsafeobjectperprofileField = value;
    }

    public long appfirewallviolxmlgenericviolationsperprofilerate
    {
      get => this.appfirewallviolxmlgenericviolationsperprofilerateField;
      private set => this.appfirewallviolxmlgenericviolationsperprofilerateField = value;
    }

    public long appfirewallviolxmlattachmentviolationsperprofile
    {
      get => this.appfirewallviolxmlattachmentviolationsperprofileField;
      private set => this.appfirewallviolxmlattachmentviolationsperprofileField = value;
    }

    public long appfirewalllogrefererheaderperprofile
    {
      get => this.appfirewalllogrefererheaderperprofileField;
      private set => this.appfirewalllogrefererheaderperprofileField = value;
    }

    public long appfirewallviolxdosviolationsperprofilerate
    {
      get => this.appfirewallviolxdosviolationsperprofilerateField;
      private set => this.appfirewallviolxdosviolationsperprofilerateField = value;
    }

    public long appfirewallviolwellformednessviolationsperprofilerate
    {
      get => this.appfirewallviolwellformednessviolationsperprofilerateField;
      private set => this.appfirewallviolwellformednessviolationsperprofilerateField = value;
    }

    public long appfirewallviolxdosviolationsperprofile
    {
      get => this.appfirewallviolxdosviolationsperprofileField;
      private set => this.appfirewallviolxdosviolationsperprofileField = value;
    }

    public long appfirewalllogxformsqlperprofilerate
    {
      get => this.appfirewalllogxformsqlperprofilerateField;
      private set => this.appfirewalllogxformsqlperprofilerateField = value;
    }

    public long appfirewallviolxmlxssviolationsperprofile
    {
      get => this.appfirewallviolxmlxssviolationsperprofileField;
      private set => this.appfirewallviolxmlxssviolationsperprofileField = value;
    }

    public long appfirewalltotallogperprofile
    {
      get => this.appfirewalltotallogperprofileField;
      private set => this.appfirewalltotallogperprofileField = value;
    }

    public long appfirewalllogcookieperprofilerate
    {
      get => this.appfirewalllogcookieperprofilerateField;
      private set => this.appfirewalllogcookieperprofilerateField = value;
    }

    public long appfirewallret5xxperprofilerate
    {
      get => this.appfirewallret5xxperprofilerateField;
      private set => this.appfirewallret5xxperprofilerateField = value;
    }

    public long appfirewallviolrefererheaderperprofile
    {
      get => this.appfirewallviolrefererheaderperprofileField;
      private set => this.appfirewallviolrefererheaderperprofileField = value;
    }

    public long appfirewallxformlogcreditcardperprofile
    {
      get => this.appfirewallxformlogcreditcardperprofileField;
      private set => this.appfirewallxformlogcreditcardperprofileField = value;
    }

    internal override base_resource[] get_nitro_response(
      nitro_service service,
      string response)
    {
      appfwprofile_stats.appfwprofile_response appfwprofileResponse = new appfwprofile_stats.appfwprofile_response();
      appfwprofile_stats.appfwprofile_response resource = (appfwprofile_stats.appfwprofile_response) service.get_payload_formatter().string_to_resource(appfwprofileResponse.GetType(), response);
      if (resource.errorcode != 0)
      {
        if (resource.errorcode == 444)
          service.clear_session();
        if (resource.severity == null)
          throw new nitro_exception(resource.message, resource.errorcode);
        if (resource.severity.Equals("ERROR"))
          throw new nitro_exception(resource.message, resource.errorcode);
      }
      return (base_resource[]) resource.appfwprofile;
    }

    internal override string get_object_name() => this.name;

    public static appfwprofile_stats[] get(nitro_service service) => (appfwprofile_stats[]) new appfwprofile_stats().stat_resources(service, (options) null);

    public static appfwprofile_stats[] get(nitro_service service, options option) => (appfwprofile_stats[]) new appfwprofile_stats().stat_resources(service, option);

    public static appfwprofile_stats get(nitro_service service, string name) => (appfwprofile_stats) new appfwprofile_stats()
    {
      name = name
    }.stat_resource(service);

    private class appfwprofile_response : base_response
    {
      public appfwprofile_stats[] appfwprofile = (appfwprofile_stats[]) null;
    }

    public static class clearstatsEnum
    {
      public const string basic = "basic";
      public const string full = "full";
    }
  }
}
