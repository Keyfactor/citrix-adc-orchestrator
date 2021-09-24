// Decompiled with JetBrains decompiler
// Type: com.citrix.netscaler.nitro.resource.stat.ca.ca_stats
// Assembly: nitro, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 6CF5DDEF-E052-4F9D-953F-6644F8378A66


using com.citrix.netscaler.nitro.exception;
using com.citrix.netscaler.nitro.resource.Base;
using com.citrix.netscaler.nitro.service;

namespace com.citrix.netscaler.nitro.resource.stat.ca
{
  public class ca_stats : base_resource
  {
    private string clearstatsField = (string) null;
    private long caaunindentifiedbyteshrField = 0;
    private long caiosbyteshrField = 0;
    private long caotherbyteshrField = 0;
    private long calaptpdsktpbyteshrField = 0;
    private long caandroidbyteshrField = 0;
    private long ca3gpvidcachebyteshrField = 0;
    private long camp4vidcachebyteshrField = 0;
    private long caflvvidcachebyteshrField = 0;
    private long caaacaudiocachebyteshrField = 0;
    private long caadtsaudiocachebyteshrField = 0;
    private long caaplelivestrmngplvidcachebyteshrField = 0;
    private long caapplelivestrmngvidcachebyteshrField = 0;
    private long camsftsmthstrmngplvidcabyteshrField = 0;
    private long camsftsmthstrmngvidcabyteshrField = 0;
    private long caunidentifiedhrField = 0;
    private long caioshrField = 0;
    private long caotherhrField = 0;
    private long calaptopdesktphrField = 0;
    private long caandroidhrField = 0;
    private long ca3gpvidhrField = 0;
    private long cacmp4vidhrField = 0;
    private long cacflvvidhrField = 0;
    private long cacaacaudiohrField = 0;
    private long cacadtsaudiohrField = 0;
    private long cacapplelivestreamingplaylistvidhrField = 0;
    private long cacapplelivestreamingvidhrField = 0;
    private long cacmsftsmthstrmplvidhrField = 0;
    private long camsftsmthstrmvidhrField = 0;
    private long catototherField = 0;
    private long catoherrateField = 0;
    private long catotvideoField = 0;
    private long cavideorateField = 0;
    private long catotaudioField = 0;
    private long caaudiorateField = 0;
    private long catotobjstoredField = 0;
    private long catotlookuphitField = 0;
    private long calookuphitrateField = 0;
    private long catotgetobjreqField = 0;
    private long cagetobjreqrateField = 0;
    private long catotrequestsField = 0;
    private long carequestsrateField = 0;
    private long camsftsmthstrmvidField = 0;
    private long camsftsmthstrmvidrateField = 0;
    private long cacmsftsmthstrmvidField = 0;
    private long cacmsftsmthstrmvidrateField = 0;
    private long camsftsmthstrvidField = 0;
    private long camsftsmthstrvidrateField = 0;
    private long cacmsftsmthstrmplvidField = 0;
    private long cacmsftsmthstrmplvidrateField = 0;
    private long cacaplelivestrmngvidField = 0;
    private long cacaplelivestrmngvidrateField = 0;
    private long cacapplelivestreamingvidField = 0;
    private long cacapplelivestreamingvidrateField = 0;
    private long cacapplelivestrmngvidField = 0;
    private long cacapplelivestrmngvidrateField = 0;
    private long cacapplelivestreamingplaylistvidField = 0;
    private long cacapplelivestreamingplaylistvidrateField = 0;
    private long caadtsaudioField = 0;
    private long caadtsaudiorateField = 0;
    private long cacadtsaudioField = 0;
    private long cacadtsaudiorateField = 0;
    private long caaacaudioField = 0;
    private long caaacaudiorateField = 0;
    private long cacaacaudioField = 0;
    private long cacaacaudiorateField = 0;
    private long caflvvidField = 0;
    private long caflvvidrateField = 0;
    private long cacflvvidField = 0;
    private long cacflvvidrateField = 0;
    private long camp4vidField = 0;
    private long camp4vidrateField = 0;
    private long cacmp4vidField = 0;
    private long cacmp4vidrateField = 0;
    private long ca3pvidField = 0;
    private long ca3pvidrateField = 0;
    private long ca3gpvidField = 0;
    private long ca3gpvidrateField = 0;
    private long camsftsmthstrmvidbytesField = 0;
    private long camsftsmthstrmvidbytesrateField = 0;
    private long camicrosoftsmoothstreamingvidcachebytesField = 0;
    private long camicrosoftsmoothstreamingvidcachebytesrateField = 0;
    private long camsftsmthstrmplvidbytesField = 0;
    private long camsftsmthstrmplvidbytesrateField = 0;
    private long camicrosoftsmoothstreamingplaylistvidcachebytesField = 0;
    private long camicrosoftsmoothstreamingplaylistvidcachebytesrateField = 0;
    private long caapplelivestreamingvidbytesField = 0;
    private long caapplelivestreamingvidbytesrateField = 0;
    private long caapplelivestreamingvidcachebytesField = 0;
    private long caapplelivestreamingvidcachebytesrateField = 0;
    private long caapplelivestreamingplaylistvidbytesField = 0;
    private long caapplelivestreamingplaylistvidbytesrateField = 0;
    private long caapplelivestreamingplaylistvidcachebytesField = 0;
    private long caapplelivestreamingplaylistvidcachebytesrateField = 0;
    private long caadtsaudiobytesField = 0;
    private long caadtsaudiobytesrateField = 0;
    private long caadtsaudiocachebytesField = 0;
    private long caadtsaudiocachebytesrateField = 0;
    private long caaacaudiobytesField = 0;
    private long caaacaudiobytesrateField = 0;
    private long caaacaudiocachebytesField = 0;
    private long caaacaudiocachebytesrateField = 0;
    private long caflvvidbytesField = 0;
    private long caflvvidbytesrateField = 0;
    private long caflvvidcachebytesField = 0;
    private long caflvvidcachebytesrateField = 0;
    private long camp4vidbytesField = 0;
    private long camp4vidbytesrateField = 0;
    private long camp4vidcachebytesField = 0;
    private long camp4vidcachebytesrateField = 0;
    private long ca3gpvidbytesField = 0;
    private long ca3gpvidbytesrateField = 0;
    private long ca3gpvidcachebytesField = 0;
    private long ca3gpvidcachebytesrateField = 0;
    private long caandroidField = 0;
    private long caandroidrateField = 0;
    private long calaptopdesktpField = 0;
    private long calaptopdesktprateField = 0;
    private long caiosField = 0;
    private long caiosrateField = 0;
    private long caotherField = 0;
    private long caotherrateField = 0;
    private long caunidentifiedField = 0;
    private long caunidentifiedrateField = 0;
    private long caandroidcacheField = 0;
    private long caandroidcacherateField = 0;
    private long caioscacheField = 0;
    private long caioscacherateField = 0;
    private long caothercacheField = 0;
    private long caothercacherateField = 0;
    private long calaptopdesktpcacheField = 0;
    private long calaptopdesktpcacherateField = 0;
    private long caunidentifiedcacheField = 0;
    private long caunidentifiedcacherateField = 0;
    private long caandroidbytesField = 0;
    private long caandroidbytesrateField = 0;
    private long caiosbytesField = 0;
    private long caiosbytesrateField = 0;
    private long caotherbytesField = 0;
    private long caotherbytesrateField = 0;
    private long caalptopdsktpbytesField = 0;
    private long caalptopdsktpbytesrateField = 0;
    private long caunidentifiedbytesField = 0;
    private long caunidentifiedbytesrateField = 0;
    private long caandroididcachebytesField = 0;
    private long caandroididcachebytesrateField = 0;
    private long caiosidcachebytesField = 0;
    private long caiosidcachebytesrateField = 0;
    private long caotherididcachebytesField = 0;
    private long caotherididcachebytesrateField = 0;
    private long calaptpdektpbytesField = 0;
    private long calaptpdektpbytesrateField = 0;
    private long caaunindentifiedbytesField = 0;
    private long caaunindentifiedbytesrateField = 0;

    public string clearstats
    {
      get => this.clearstatsField;
      set => this.clearstatsField = value;
    }

    public long caaacaudiocachebytes
    {
      get => this.caaacaudiocachebytesField;
      private set => this.caaacaudiocachebytesField = value;
    }

    public long camsftsmthstrmvidhr
    {
      get => this.camsftsmthstrmvidhrField;
      private set => this.camsftsmthstrmvidhrField = value;
    }

    public long caflvvidrate
    {
      get => this.caflvvidrateField;
      private set => this.caflvvidrateField = value;
    }

    public long cacmsftsmthstrmplvid
    {
      get => this.cacmsftsmthstrmplvidField;
      private set => this.cacmsftsmthstrmplvidField = value;
    }

    public long camp4vidbytesrate
    {
      get => this.camp4vidbytesrateField;
      private set => this.camp4vidbytesrateField = value;
    }

    public long camsftsmthstrmngplvidcabyteshr
    {
      get => this.camsftsmthstrmngplvidcabyteshrField;
      private set => this.camsftsmthstrmngplvidcabyteshrField = value;
    }

    public long caapplelivestreamingplaylistvidbytesrate
    {
      get => this.caapplelivestreamingplaylistvidbytesrateField;
      private set => this.caapplelivestreamingplaylistvidbytesrateField = value;
    }

    public long catotvideo
    {
      get => this.catotvideoField;
      private set => this.catotvideoField = value;
    }

    public long caaacaudiobytes
    {
      get => this.caaacaudiobytesField;
      private set => this.caaacaudiobytesField = value;
    }

    public long calookuphitrate
    {
      get => this.calookuphitrateField;
      private set => this.calookuphitrateField = value;
    }

    public long cacapplelivestreamingplaylistvid
    {
      get => this.cacapplelivestreamingplaylistvidField;
      private set => this.cacapplelivestreamingplaylistvidField = value;
    }

    public long cacmp4vidhr
    {
      get => this.cacmp4vidhrField;
      private set => this.cacmp4vidhrField = value;
    }

    public long cacapplelivestreamingvidhr
    {
      get => this.cacapplelivestreamingvidhrField;
      private set => this.cacapplelivestreamingvidhrField = value;
    }

    public long caflvvidbytesrate
    {
      get => this.caflvvidbytesrateField;
      private set => this.caflvvidbytesrateField = value;
    }

    public long catotobjstored
    {
      get => this.catotobjstoredField;
      private set => this.catotobjstoredField = value;
    }

    public long ca3gpvidcachebytesrate
    {
      get => this.ca3gpvidcachebytesrateField;
      private set => this.ca3gpvidcachebytesrateField = value;
    }

    public long caaacaudiocachebyteshr
    {
      get => this.caaacaudiocachebyteshrField;
      private set => this.caaacaudiocachebyteshrField = value;
    }

    public long caadtsaudiobytes
    {
      get => this.caadtsaudiobytesField;
      private set => this.caadtsaudiobytesField = value;
    }

    public long cacadtsaudio
    {
      get => this.cacadtsaudioField;
      private set => this.cacadtsaudioField = value;
    }

    public long caaudiorate
    {
      get => this.caaudiorateField;
      private set => this.caaudiorateField = value;
    }

    public long cacapplelivestreamingplaylistvidrate
    {
      get => this.cacapplelivestreamingplaylistvidrateField;
      private set => this.cacapplelivestreamingplaylistvidrateField = value;
    }

    public long caaplelivestrmngplvidcachebyteshr
    {
      get => this.caaplelivestrmngplvidcachebyteshrField;
      private set => this.caaplelivestrmngplvidcachebyteshrField = value;
    }

    public long caotherididcachebytes
    {
      get => this.caotherididcachebytesField;
      private set => this.caotherididcachebytesField = value;
    }

    public long calaptpdsktpbyteshr
    {
      get => this.calaptpdsktpbyteshrField;
      private set => this.calaptpdsktpbyteshrField = value;
    }

    public long caflvvidcachebytes
    {
      get => this.caflvvidcachebytesField;
      private set => this.caflvvidcachebytesField = value;
    }

    public long caalptopdsktpbytesrate
    {
      get => this.caalptopdsktpbytesrateField;
      private set => this.caalptopdsktpbytesrateField = value;
    }

    public long cacflvvidrate
    {
      get => this.cacflvvidrateField;
      private set => this.cacflvvidrateField = value;
    }

    public long caaunindentifiedbyteshr
    {
      get => this.caaunindentifiedbyteshrField;
      private set => this.caaunindentifiedbyteshrField = value;
    }

    public long caapplelivestreamingplaylistvidcachebytes
    {
      get => this.caapplelivestreamingplaylistvidcachebytesField;
      private set => this.caapplelivestreamingplaylistvidcachebytesField = value;
    }

    public long catotrequests
    {
      get => this.catotrequestsField;
      private set => this.catotrequestsField = value;
    }

    public long cacflvvidhr
    {
      get => this.cacflvvidhrField;
      private set => this.cacflvvidhrField = value;
    }

    public long caadtsaudiocachebyteshr
    {
      get => this.caadtsaudiocachebyteshrField;
      private set => this.caadtsaudiocachebyteshrField = value;
    }

    public long caiosbytesrate
    {
      get => this.caiosbytesrateField;
      private set => this.caiosbytesrateField = value;
    }

    public long cacmp4vidrate
    {
      get => this.cacmp4vidrateField;
      private set => this.cacmp4vidrateField = value;
    }

    public long catotlookuphit
    {
      get => this.catotlookuphitField;
      private set => this.catotlookuphitField = value;
    }

    public long caadtsaudiobytesrate
    {
      get => this.caadtsaudiobytesrateField;
      private set => this.caadtsaudiobytesrateField = value;
    }

    public long ca3pvid
    {
      get => this.ca3pvidField;
      private set => this.ca3pvidField = value;
    }

    public long calaptopdesktpcache
    {
      get => this.calaptopdesktpcacheField;
      private set => this.calaptopdesktpcacheField = value;
    }

    public long camsftsmthstrmplvidbytes
    {
      get => this.camsftsmthstrmplvidbytesField;
      private set => this.camsftsmthstrmplvidbytesField = value;
    }

    public long caiosidcachebytesrate
    {
      get => this.caiosidcachebytesrateField;
      private set => this.caiosidcachebytesrateField = value;
    }

    public long ca3gpvidbytesrate
    {
      get => this.ca3gpvidbytesrateField;
      private set => this.ca3gpvidbytesrateField = value;
    }

    public long caunidentifiedcache
    {
      get => this.caunidentifiedcacheField;
      private set => this.caunidentifiedcacheField = value;
    }

    public long caapplelivestreamingvidcachebytesrate
    {
      get => this.caapplelivestreamingvidcachebytesrateField;
      private set => this.caapplelivestreamingvidcachebytesrateField = value;
    }

    public long caapplelivestreamingvidbytes
    {
      get => this.caapplelivestreamingvidbytesField;
      private set => this.caapplelivestreamingvidbytesField = value;
    }

    public long caflvvidcachebyteshr
    {
      get => this.caflvvidcachebyteshrField;
      private set => this.caflvvidcachebyteshrField = value;
    }

    public long caaunindentifiedbytesrate
    {
      get => this.caaunindentifiedbytesrateField;
      private set => this.caaunindentifiedbytesrateField = value;
    }

    public long caios
    {
      get => this.caiosField;
      private set => this.caiosField = value;
    }

    public long caiosrate
    {
      get => this.caiosrateField;
      private set => this.caiosrateField = value;
    }

    public long caandroidbytes
    {
      get => this.caandroidbytesField;
      private set => this.caandroidbytesField = value;
    }

    public long caotherrate
    {
      get => this.caotherrateField;
      private set => this.caotherrateField = value;
    }

    public long caflvvidbytes
    {
      get => this.caflvvidbytesField;
      private set => this.caflvvidbytesField = value;
    }

    public long calaptpdektpbytes
    {
      get => this.calaptpdektpbytesField;
      private set => this.calaptpdektpbytesField = value;
    }

    public long caapplelivestreamingplaylistvidcachebytesrate
    {
      get => this.caapplelivestreamingplaylistvidcachebytesrateField;
      private set => this.caapplelivestreamingplaylistvidcachebytesrateField = value;
    }

    public long camsftsmthstrmplvidbytesrate
    {
      get => this.camsftsmthstrmplvidbytesrateField;
      private set => this.camsftsmthstrmplvidbytesrateField = value;
    }

    public long caaacaudiorate
    {
      get => this.caaacaudiorateField;
      private set => this.caaacaudiorateField = value;
    }

    public long ca3gpvidhr
    {
      get => this.ca3gpvidhrField;
      private set => this.ca3gpvidhrField = value;
    }

    public long calaptopdesktprate
    {
      get => this.calaptopdesktprateField;
      private set => this.calaptopdesktprateField = value;
    }

    public long camp4vidrate
    {
      get => this.camp4vidrateField;
      private set => this.camp4vidrateField = value;
    }

    public long cacadtsaudiohr
    {
      get => this.cacadtsaudiohrField;
      private set => this.cacadtsaudiohrField = value;
    }

    public long cacapplelivestrmngvid
    {
      get => this.cacapplelivestrmngvidField;
      private set => this.cacapplelivestrmngvidField = value;
    }

    public long caaacaudiocachebytesrate
    {
      get => this.caaacaudiocachebytesrateField;
      private set => this.caaacaudiocachebytesrateField = value;
    }

    public long caapplelivestreamingvidbytesrate
    {
      get => this.caapplelivestreamingvidbytesrateField;
      private set => this.caapplelivestreamingvidbytesrateField = value;
    }

    public long cacaplelivestrmngvidrate
    {
      get => this.cacaplelivestrmngvidrateField;
      private set => this.cacaplelivestrmngvidrateField = value;
    }

    public long caunidentifiedhr
    {
      get => this.caunidentifiedhrField;
      private set => this.caunidentifiedhrField = value;
    }

    public long cagetobjreqrate
    {
      get => this.cagetobjreqrateField;
      private set => this.cagetobjreqrateField = value;
    }

    public long camp4vidcachebyteshr
    {
      get => this.camp4vidcachebyteshrField;
      private set => this.camp4vidcachebyteshrField = value;
    }

    public long calaptopdesktphr
    {
      get => this.calaptopdesktphrField;
      private set => this.calaptopdesktphrField = value;
    }

    public long camsftsmthstrmvidbytesrate
    {
      get => this.camsftsmthstrmvidbytesrateField;
      private set => this.camsftsmthstrmvidbytesrateField = value;
    }

    public long camsftsmthstrmngvidcabyteshr
    {
      get => this.camsftsmthstrmngvidcabyteshrField;
      private set => this.camsftsmthstrmngvidcabyteshrField = value;
    }

    public long camicrosoftsmoothstreamingplaylistvidcachebytes
    {
      get => this.camicrosoftsmoothstreamingplaylistvidcachebytesField;
      private set => this.camicrosoftsmoothstreamingplaylistvidcachebytesField = value;
    }

    public long caiosbytes
    {
      get => this.caiosbytesField;
      private set => this.caiosbytesField = value;
    }

    public long calaptopdesktp
    {
      get => this.calaptopdesktpField;
      private set => this.calaptopdesktpField = value;
    }

    public long caothercacherate
    {
      get => this.caothercacherateField;
      private set => this.caothercacherateField = value;
    }

    public long camp4vidcachebytesrate
    {
      get => this.camp4vidcachebytesrateField;
      private set => this.camp4vidcachebytesrateField = value;
    }

    public long cacaacaudiohr
    {
      get => this.cacaacaudiohrField;
      private set => this.cacaacaudiohrField = value;
    }

    public long caotherididcachebytesrate
    {
      get => this.caotherididcachebytesrateField;
      private set => this.caotherididcachebytesrateField = value;
    }

    public long camsftsmthstrmvidbytes
    {
      get => this.camsftsmthstrmvidbytesField;
      private set => this.camsftsmthstrmvidbytesField = value;
    }

    public long cacmsftsmthstrmplvidhr
    {
      get => this.cacmsftsmthstrmplvidhrField;
      private set => this.cacmsftsmthstrmplvidhrField = value;
    }

    public long calaptopdesktpcacherate
    {
      get => this.calaptopdesktpcacherateField;
      private set => this.calaptopdesktpcacherateField = value;
    }

    public long ca3gpvidbytes
    {
      get => this.ca3gpvidbytesField;
      private set => this.ca3gpvidbytesField = value;
    }

    public long caotherbytes
    {
      get => this.caotherbytesField;
      private set => this.caotherbytesField = value;
    }

    public long carequestsrate
    {
      get => this.carequestsrateField;
      private set => this.carequestsrateField = value;
    }

    public long caunidentifiedbytesrate
    {
      get => this.caunidentifiedbytesrateField;
      private set => this.caunidentifiedbytesrateField = value;
    }

    public long ca3gpvidcachebyteshr
    {
      get => this.ca3gpvidcachebyteshrField;
      private set => this.ca3gpvidcachebyteshrField = value;
    }

    public long caadtsaudiocachebytes
    {
      get => this.caadtsaudiocachebytesField;
      private set => this.caadtsaudiocachebytesField = value;
    }

    public long caadtsaudio
    {
      get => this.caadtsaudioField;
      private set => this.caadtsaudioField = value;
    }

    public long caadtsaudiocachebytesrate
    {
      get => this.caadtsaudiocachebytesrateField;
      private set => this.caadtsaudiocachebytesrateField = value;
    }

    public long ca3gpvidrate
    {
      get => this.ca3gpvidrateField;
      private set => this.ca3gpvidrateField = value;
    }

    public long caioscache
    {
      get => this.caioscacheField;
      private set => this.caioscacheField = value;
    }

    public long caaunindentifiedbytes
    {
      get => this.caaunindentifiedbytesField;
      private set => this.caaunindentifiedbytesField = value;
    }

    public long cacapplelivestreamingplaylistvidhr
    {
      get => this.cacapplelivestreamingplaylistvidhrField;
      private set => this.cacapplelivestreamingplaylistvidhrField = value;
    }

    public long caunidentified
    {
      get => this.caunidentifiedField;
      private set => this.caunidentifiedField = value;
    }

    public long caandroid
    {
      get => this.caandroidField;
      private set => this.caandroidField = value;
    }

    public long caapplelivestreamingplaylistvidbytes
    {
      get => this.caapplelivestreamingplaylistvidbytesField;
      private set => this.caapplelivestreamingplaylistvidbytesField = value;
    }

    public long camp4vidbytes
    {
      get => this.camp4vidbytesField;
      private set => this.camp4vidbytesField = value;
    }

    public long caunidentifiedrate
    {
      get => this.caunidentifiedrateField;
      private set => this.caunidentifiedrateField = value;
    }

    public long cacaacaudio
    {
      get => this.cacaacaudioField;
      private set => this.cacaacaudioField = value;
    }

    public long cacflvvid
    {
      get => this.cacflvvidField;
      private set => this.cacflvvidField = value;
    }

    public long catotgetobjreq
    {
      get => this.catotgetobjreqField;
      private set => this.catotgetobjreqField = value;
    }

    public long caotherbyteshr
    {
      get => this.caotherbyteshrField;
      private set => this.caotherbyteshrField = value;
    }

    public long caioshr
    {
      get => this.caioshrField;
      private set => this.caioshrField = value;
    }

    public long calaptpdektpbytesrate
    {
      get => this.calaptpdektpbytesrateField;
      private set => this.calaptpdektpbytesrateField = value;
    }

    public long caandroididcachebytes
    {
      get => this.caandroididcachebytesField;
      private set => this.caandroididcachebytesField = value;
    }

    public long caflvvid
    {
      get => this.caflvvidField;
      private set => this.caflvvidField = value;
    }

    public long cacadtsaudiorate
    {
      get => this.cacadtsaudiorateField;
      private set => this.cacadtsaudiorateField = value;
    }

    public long caandroidbyteshr
    {
      get => this.caandroidbyteshrField;
      private set => this.caandroidbyteshrField = value;
    }

    public long caandroididcachebytesrate
    {
      get => this.caandroididcachebytesrateField;
      private set => this.caandroididcachebytesrateField = value;
    }

    public long cacmp4vid
    {
      get => this.cacmp4vidField;
      private set => this.cacmp4vidField = value;
    }

    public long caandroidbytesrate
    {
      get => this.caandroidbytesrateField;
      private set => this.caandroidbytesrateField = value;
    }

    public long cacmsftsmthstrmplvidrate
    {
      get => this.cacmsftsmthstrmplvidrateField;
      private set => this.cacmsftsmthstrmplvidrateField = value;
    }

    public long caadtsaudiorate
    {
      get => this.caadtsaudiorateField;
      private set => this.caadtsaudiorateField = value;
    }

    public long camp4vid
    {
      get => this.camp4vidField;
      private set => this.camp4vidField = value;
    }

    public long caunidentifiedcacherate
    {
      get => this.caunidentifiedcacherateField;
      private set => this.caunidentifiedcacherateField = value;
    }

    public long caandroidcacherate
    {
      get => this.caandroidcacherateField;
      private set => this.caandroidcacherateField = value;
    }

    public long cavideorate
    {
      get => this.cavideorateField;
      private set => this.cavideorateField = value;
    }

    public long camicrosoftsmoothstreamingplaylistvidcachebytesrate
    {
      get => this.camicrosoftsmoothstreamingplaylistvidcachebytesrateField;
      private set => this.camicrosoftsmoothstreamingplaylistvidcachebytesrateField = value;
    }

    public long caaacaudio
    {
      get => this.caaacaudioField;
      private set => this.caaacaudioField = value;
    }

    public long catotother
    {
      get => this.catototherField;
      private set => this.catototherField = value;
    }

    public long cacapplelivestreamingvidrate
    {
      get => this.cacapplelivestreamingvidrateField;
      private set => this.cacapplelivestreamingvidrateField = value;
    }

    public long cacapplelivestreamingvid
    {
      get => this.cacapplelivestreamingvidField;
      private set => this.cacapplelivestreamingvidField = value;
    }

    public long caandroidhr
    {
      get => this.caandroidhrField;
      private set => this.caandroidhrField = value;
    }

    public long cacmsftsmthstrmvidrate
    {
      get => this.cacmsftsmthstrmvidrateField;
      private set => this.cacmsftsmthstrmvidrateField = value;
    }

    public long caioscacherate
    {
      get => this.caioscacherateField;
      private set => this.caioscacherateField = value;
    }

    public long caunidentifiedbytes
    {
      get => this.caunidentifiedbytesField;
      private set => this.caunidentifiedbytesField = value;
    }

    public long caandroidrate
    {
      get => this.caandroidrateField;
      private set => this.caandroidrateField = value;
    }

    public long cacaacaudiorate
    {
      get => this.cacaacaudiorateField;
      private set => this.cacaacaudiorateField = value;
    }

    public long cacmsftsmthstrmvid
    {
      get => this.cacmsftsmthstrmvidField;
      private set => this.cacmsftsmthstrmvidField = value;
    }

    public long camicrosoftsmoothstreamingvidcachebytes
    {
      get => this.camicrosoftsmoothstreamingvidcachebytesField;
      private set => this.camicrosoftsmoothstreamingvidcachebytesField = value;
    }

    public long caother
    {
      get => this.caotherField;
      private set => this.caotherField = value;
    }

    public long caalptopdsktpbytes
    {
      get => this.caalptopdsktpbytesField;
      private set => this.caalptopdsktpbytesField = value;
    }

    public long caothercache
    {
      get => this.caothercacheField;
      private set => this.caothercacheField = value;
    }

    public long camsftsmthstrvid
    {
      get => this.camsftsmthstrvidField;
      private set => this.camsftsmthstrvidField = value;
    }

    public long camp4vidcachebytes
    {
      get => this.camp4vidcachebytesField;
      private set => this.camp4vidcachebytesField = value;
    }

    public long ca3gpvid
    {
      get => this.ca3gpvidField;
      private set => this.ca3gpvidField = value;
    }

    public long cacapplelivestrmngvidrate
    {
      get => this.cacapplelivestrmngvidrateField;
      private set => this.cacapplelivestrmngvidrateField = value;
    }

    public long camicrosoftsmoothstreamingvidcachebytesrate
    {
      get => this.camicrosoftsmoothstreamingvidcachebytesrateField;
      private set => this.camicrosoftsmoothstreamingvidcachebytesrateField = value;
    }

    public long catoherrate
    {
      get => this.catoherrateField;
      private set => this.catoherrateField = value;
    }

    public long caotherhr
    {
      get => this.caotherhrField;
      private set => this.caotherhrField = value;
    }

    public long camsftsmthstrmvidrate
    {
      get => this.camsftsmthstrmvidrateField;
      private set => this.camsftsmthstrmvidrateField = value;
    }

    public long camsftsmthstrvidrate
    {
      get => this.camsftsmthstrvidrateField;
      private set => this.camsftsmthstrvidrateField = value;
    }

    public long ca3gpvidcachebytes
    {
      get => this.ca3gpvidcachebytesField;
      private set => this.ca3gpvidcachebytesField = value;
    }

    public long caaacaudiobytesrate
    {
      get => this.caaacaudiobytesrateField;
      private set => this.caaacaudiobytesrateField = value;
    }

    public long camsftsmthstrmvid
    {
      get => this.camsftsmthstrmvidField;
      private set => this.camsftsmthstrmvidField = value;
    }

    public long cacaplelivestrmngvid
    {
      get => this.cacaplelivestrmngvidField;
      private set => this.cacaplelivestrmngvidField = value;
    }

    public long caapplelivestrmngvidcachebyteshr
    {
      get => this.caapplelivestrmngvidcachebyteshrField;
      private set => this.caapplelivestrmngvidcachebyteshrField = value;
    }

    public long ca3pvidrate
    {
      get => this.ca3pvidrateField;
      private set => this.ca3pvidrateField = value;
    }

    public long caandroidcache
    {
      get => this.caandroidcacheField;
      private set => this.caandroidcacheField = value;
    }

    public long caflvvidcachebytesrate
    {
      get => this.caflvvidcachebytesrateField;
      private set => this.caflvvidcachebytesrateField = value;
    }

    public long caiosidcachebytes
    {
      get => this.caiosidcachebytesField;
      private set => this.caiosidcachebytesField = value;
    }

    public long caotherbytesrate
    {
      get => this.caotherbytesrateField;
      private set => this.caotherbytesrateField = value;
    }

    public long caapplelivestreamingvidcachebytes
    {
      get => this.caapplelivestreamingvidcachebytesField;
      private set => this.caapplelivestreamingvidcachebytesField = value;
    }

    public long caiosbyteshr
    {
      get => this.caiosbyteshrField;
      private set => this.caiosbyteshrField = value;
    }

    public long catotaudio
    {
      get => this.catotaudioField;
      private set => this.catotaudioField = value;
    }

    internal override base_resource[] get_nitro_response(
      nitro_service service,
      string response)
    {
      ca_stats[] caStatsArray = new ca_stats[1];
      ca_stats.ca_response caResponse = new ca_stats.ca_response();
      ca_stats.ca_response resource = (ca_stats.ca_response) service.get_payload_formatter().string_to_resource(caResponse.GetType(), response);
      if (resource.errorcode != 0)
      {
        if (resource.errorcode == 444)
          service.clear_session();
        if (resource.severity == null)
          throw new nitro_exception(resource.message, resource.errorcode);
        if (resource.severity.Equals("ERROR"))
          throw new nitro_exception(resource.message, resource.errorcode);
      }
      caStatsArray[0] = resource.ca;
      return (base_resource[]) caStatsArray;
    }

    internal override string get_object_name() => (string) null;

    public static ca_stats get(nitro_service service) => ((ca_stats[]) new ca_stats().stat_resources(service, (options) null))[0];

    public static ca_stats get(nitro_service service, options option) => ((ca_stats[]) new ca_stats().stat_resources(service, option))[0];

    private class ca_response : base_response
    {
      public ca_stats ca = (ca_stats) null;
    }

    public static class clearstatsEnum
    {
      public const string basic = "basic";
      public const string full = "full";
    }
  }
}
