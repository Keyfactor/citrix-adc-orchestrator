// Decompiled with JetBrains decompiler
// Type: com.citrix.netscaler.nitro.resource.stat.mediaclassification.mediaclassification_stats
// Assembly: nitro, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 6CF5DDEF-E052-4F9D-953F-6644F8378A66


using com.citrix.netscaler.nitro.exception;
using com.citrix.netscaler.nitro.resource.Base;
using com.citrix.netscaler.nitro.service;

namespace com.citrix.netscaler.nitro.resource.stat.mediaclassification
{
  public class mediaclassification_stats : base_resource
  {
    private string clearstatsField = (string) null;
    private long mcencvideoField = 0;
    private long mcencvideorateField = 0;
    private long mctototherField = 0;
    private long mctoherrateField = 0;
    private long mctotvideoField = 0;
    private long mcvideorateField = 0;
    private long mctotaudioField = 0;
    private long mcaudiorateField = 0;
    private long mcmssmthstrmvidField = 0;
    private long mcmssmthstrmvidrateField = 0;
    private long mcmssmthstrvidplField = 0;
    private long mcmssmthstrvidplrateField = 0;
    private long mccaplelivestrmngvidField = 0;
    private long mccaplelivestrmngvidrateField = 0;
    private long mccapplelivestrmngvidplField = 0;
    private long mccapplelivestrmngvidplrateField = 0;
    private long mcadtsaudioField = 0;
    private long mcadtsaudiorateField = 0;
    private long mcaacaudioField = 0;
    private long mcaacaudiorateField = 0;
    private long mcflvvidField = 0;
    private long mcflvvidrateField = 0;
    private long mcmp4vidField = 0;
    private long mcmp4vidrateField = 0;
    private long mc3pvidField = 0;
    private long mc3pvidrateField = 0;
    private long mcyoutubedashField = 0;
    private long mcyoutubedashrateField = 0;
    private long mcmssmthstrmvidbytesField = 0;
    private long mcmssmthstrmvidbytesrateField = 0;
    private long mcmssmthstrmplvidbytesplField = 0;
    private long mcmssmthstrmplvidbytesplrateField = 0;
    private long mcapplelivestreamingvidbytesField = 0;
    private long mcapplelivestreamingvidbytesrateField = 0;
    private long mcapplelivestreamingplaylistvidbytesplField = 0;
    private long mcapplelivestreamingplaylistvidbytesplrateField = 0;
    private long mcadtsaudiobytesField = 0;
    private long mcadtsaudiobytesrateField = 0;
    private long mcaacaudiobytesField = 0;
    private long mcaacaudiobytesrateField = 0;
    private long mcflvvidbytesField = 0;
    private long mcflvvidbytesrateField = 0;
    private long mcmp4vidbytesField = 0;
    private long mcmp4vidbytesrateField = 0;
    private long mc3gpvidbytesField = 0;
    private long mc3gpvidbytesrateField = 0;
    private long mcyoutubedashbytesField = 0;
    private long mcyoutubedashbytesrateField = 0;
    private long mcandroidField = 0;
    private long mcandroidrateField = 0;
    private long mclaptopdesktpField = 0;
    private long mclaptopdesktprateField = 0;
    private long mciosField = 0;
    private long mciosrateField = 0;
    private long mcotherField = 0;
    private long mcotherrateField = 0;
    private long mcunidentifiedField = 0;
    private long mcunidentifiedrateField = 0;
    private long mcenchlsField = 0;
    private long mcenchlsrateField = 0;
    private long mcencdashField = 0;
    private long mcencdashrateField = 0;
    private long mcencandroidField = 0;
    private long mcencandroidrateField = 0;
    private long mcenciosField = 0;
    private long mcenciosrateField = 0;
    private long mcencotherField = 0;
    private long mcencotherrateField = 0;

    public string clearstats
    {
      get => this.clearstatsField;
      set => this.clearstatsField = value;
    }

    public long mcmp4vid
    {
      get => this.mcmp4vidField;
      private set => this.mcmp4vidField = value;
    }

    public long mcvideorate
    {
      get => this.mcvideorateField;
      private set => this.mcvideorateField = value;
    }

    public long mc3pvid
    {
      get => this.mc3pvidField;
      private set => this.mc3pvidField = value;
    }

    public long mcencandroid
    {
      get => this.mcencandroidField;
      private set => this.mcencandroidField = value;
    }

    public long mcflvvid
    {
      get => this.mcflvvidField;
      private set => this.mcflvvidField = value;
    }

    public long mcunidentifiedrate
    {
      get => this.mcunidentifiedrateField;
      private set => this.mcunidentifiedrateField = value;
    }

    public long mcencvideo
    {
      get => this.mcencvideoField;
      private set => this.mcencvideoField = value;
    }

    public long mclaptopdesktprate
    {
      get => this.mclaptopdesktprateField;
      private set => this.mclaptopdesktprateField = value;
    }

    public long mcyoutubedash
    {
      get => this.mcyoutubedashField;
      private set => this.mcyoutubedashField = value;
    }

    public long mccaplelivestrmngvidrate
    {
      get => this.mccaplelivestrmngvidrateField;
      private set => this.mccaplelivestrmngvidrateField = value;
    }

    public long mcaacaudiobytes
    {
      get => this.mcaacaudiobytesField;
      private set => this.mcaacaudiobytesField = value;
    }

    public long mcenchls
    {
      get => this.mcenchlsField;
      private set => this.mcenchlsField = value;
    }

    public long mcother
    {
      get => this.mcotherField;
      private set => this.mcotherField = value;
    }

    public long mcflvvidbytesrate
    {
      get => this.mcflvvidbytesrateField;
      private set => this.mcflvvidbytesrateField = value;
    }

    public long mc3gpvidbytes
    {
      get => this.mc3gpvidbytesField;
      private set => this.mc3gpvidbytesField = value;
    }

    public long mcencvideorate
    {
      get => this.mcencvideorateField;
      private set => this.mcencvideorateField = value;
    }

    public long mctotaudio
    {
      get => this.mctotaudioField;
      private set => this.mctotaudioField = value;
    }

    public long mcenciosrate
    {
      get => this.mcenciosrateField;
      private set => this.mcenciosrateField = value;
    }

    public long mcadtsaudiobytes
    {
      get => this.mcadtsaudiobytesField;
      private set => this.mcadtsaudiobytesField = value;
    }

    public long mcaacaudiobytesrate
    {
      get => this.mcaacaudiobytesrateField;
      private set => this.mcaacaudiobytesrateField = value;
    }

    public long mcandroid
    {
      get => this.mcandroidField;
      private set => this.mcandroidField = value;
    }

    public long mccaplelivestrmngvid
    {
      get => this.mccaplelivestrmngvidField;
      private set => this.mccaplelivestrmngvidField = value;
    }

    public long mciosrate
    {
      get => this.mciosrateField;
      private set => this.mciosrateField = value;
    }

    public long mctotvideo
    {
      get => this.mctotvideoField;
      private set => this.mctotvideoField = value;
    }

    public long mcmssmthstrvidplrate
    {
      get => this.mcmssmthstrvidplrateField;
      private set => this.mcmssmthstrvidplrateField = value;
    }

    public long mcapplelivestreamingvidbytesrate
    {
      get => this.mcapplelivestreamingvidbytesrateField;
      private set => this.mcapplelivestreamingvidbytesrateField = value;
    }

    public long mcyoutubedashbytesrate
    {
      get => this.mcyoutubedashbytesrateField;
      private set => this.mcyoutubedashbytesrateField = value;
    }

    public long mcapplelivestreamingplaylistvidbytespl
    {
      get => this.mcapplelivestreamingplaylistvidbytesplField;
      private set => this.mcapplelivestreamingplaylistvidbytesplField = value;
    }

    public long mcmp4vidbytes
    {
      get => this.mcmp4vidbytesField;
      private set => this.mcmp4vidbytesField = value;
    }

    public long mcmssmthstrmvidbytesrate
    {
      get => this.mcmssmthstrmvidbytesrateField;
      private set => this.mcmssmthstrmvidbytesrateField = value;
    }

    public long mc3gpvidbytesrate
    {
      get => this.mc3gpvidbytesrateField;
      private set => this.mc3gpvidbytesrateField = value;
    }

    public long mcaudiorate
    {
      get => this.mcaudiorateField;
      private set => this.mcaudiorateField = value;
    }

    public long mcyoutubedashbytes
    {
      get => this.mcyoutubedashbytesField;
      private set => this.mcyoutubedashbytesField = value;
    }

    public long mcmp4vidrate
    {
      get => this.mcmp4vidrateField;
      private set => this.mcmp4vidrateField = value;
    }

    public long mcmp4vidbytesrate
    {
      get => this.mcmp4vidbytesrateField;
      private set => this.mcmp4vidbytesrateField = value;
    }

    public long mcunidentified
    {
      get => this.mcunidentifiedField;
      private set => this.mcunidentifiedField = value;
    }

    public long mcios
    {
      get => this.mciosField;
      private set => this.mciosField = value;
    }

    public long mc3pvidrate
    {
      get => this.mc3pvidrateField;
      private set => this.mc3pvidrateField = value;
    }

    public long mccapplelivestrmngvidplrate
    {
      get => this.mccapplelivestrmngvidplrateField;
      private set => this.mccapplelivestrmngvidplrateField = value;
    }

    public long mctoherrate
    {
      get => this.mctoherrateField;
      private set => this.mctoherrateField = value;
    }

    public long mcotherrate
    {
      get => this.mcotherrateField;
      private set => this.mcotherrateField = value;
    }

    public long mcenchlsrate
    {
      get => this.mcenchlsrateField;
      private set => this.mcenchlsrateField = value;
    }

    public long mcmssmthstrmplvidbytesplrate
    {
      get => this.mcmssmthstrmplvidbytesplrateField;
      private set => this.mcmssmthstrmplvidbytesplrateField = value;
    }

    public long mccapplelivestrmngvidpl
    {
      get => this.mccapplelivestrmngvidplField;
      private set => this.mccapplelivestrmngvidplField = value;
    }

    public long mcencandroidrate
    {
      get => this.mcencandroidrateField;
      private set => this.mcencandroidrateField = value;
    }

    public long mcmssmthstrmvid
    {
      get => this.mcmssmthstrmvidField;
      private set => this.mcmssmthstrmvidField = value;
    }

    public long mcencdash
    {
      get => this.mcencdashField;
      private set => this.mcencdashField = value;
    }

    public long mcandroidrate
    {
      get => this.mcandroidrateField;
      private set => this.mcandroidrateField = value;
    }

    public long mcaacaudiorate
    {
      get => this.mcaacaudiorateField;
      private set => this.mcaacaudiorateField = value;
    }

    public long mctotother
    {
      get => this.mctototherField;
      private set => this.mctototherField = value;
    }

    public long mcencdashrate
    {
      get => this.mcencdashrateField;
      private set => this.mcencdashrateField = value;
    }

    public long mcmssmthstrmvidbytes
    {
      get => this.mcmssmthstrmvidbytesField;
      private set => this.mcmssmthstrmvidbytesField = value;
    }

    public long mcencios
    {
      get => this.mcenciosField;
      private set => this.mcenciosField = value;
    }

    public long mcadtsaudiorate
    {
      get => this.mcadtsaudiorateField;
      private set => this.mcadtsaudiorateField = value;
    }

    public long mcaacaudio
    {
      get => this.mcaacaudioField;
      private set => this.mcaacaudioField = value;
    }

    public long mcflvvidrate
    {
      get => this.mcflvvidrateField;
      private set => this.mcflvvidrateField = value;
    }

    public long mcencotherrate
    {
      get => this.mcencotherrateField;
      private set => this.mcencotherrateField = value;
    }

    public long mcapplelivestreamingplaylistvidbytesplrate
    {
      get => this.mcapplelivestreamingplaylistvidbytesplrateField;
      private set => this.mcapplelivestreamingplaylistvidbytesplrateField = value;
    }

    public long mcmssmthstrvidpl
    {
      get => this.mcmssmthstrvidplField;
      private set => this.mcmssmthstrvidplField = value;
    }

    public long mcflvvidbytes
    {
      get => this.mcflvvidbytesField;
      private set => this.mcflvvidbytesField = value;
    }

    public long mcmssmthstrmvidrate
    {
      get => this.mcmssmthstrmvidrateField;
      private set => this.mcmssmthstrmvidrateField = value;
    }

    public long mcyoutubedashrate
    {
      get => this.mcyoutubedashrateField;
      private set => this.mcyoutubedashrateField = value;
    }

    public long mcapplelivestreamingvidbytes
    {
      get => this.mcapplelivestreamingvidbytesField;
      private set => this.mcapplelivestreamingvidbytesField = value;
    }

    public long mcadtsaudiobytesrate
    {
      get => this.mcadtsaudiobytesrateField;
      private set => this.mcadtsaudiobytesrateField = value;
    }

    public long mcmssmthstrmplvidbytespl
    {
      get => this.mcmssmthstrmplvidbytesplField;
      private set => this.mcmssmthstrmplvidbytesplField = value;
    }

    public long mcadtsaudio
    {
      get => this.mcadtsaudioField;
      private set => this.mcadtsaudioField = value;
    }

    public long mclaptopdesktp
    {
      get => this.mclaptopdesktpField;
      private set => this.mclaptopdesktpField = value;
    }

    public long mcencother
    {
      get => this.mcencotherField;
      private set => this.mcencotherField = value;
    }

    internal override base_resource[] get_nitro_response(
      nitro_service service,
      string response)
    {
      mediaclassification_stats[] mediaclassificationStatsArray = new mediaclassification_stats[1];
      mediaclassification_stats.mediaclassification_response mediaclassificationResponse = new mediaclassification_stats.mediaclassification_response();
      mediaclassification_stats.mediaclassification_response resource = (mediaclassification_stats.mediaclassification_response) service.get_payload_formatter().string_to_resource(mediaclassificationResponse.GetType(), response);
      if (resource.errorcode != 0)
      {
        if (resource.errorcode == 444)
          service.clear_session();
        if (resource.severity == null)
          throw new nitro_exception(resource.message, resource.errorcode);
        if (resource.severity.Equals("ERROR"))
          throw new nitro_exception(resource.message, resource.errorcode);
      }
      mediaclassificationStatsArray[0] = resource.mediaclassification;
      return (base_resource[]) mediaclassificationStatsArray;
    }

    internal override string get_object_name() => (string) null;

    public static mediaclassification_stats get(nitro_service service) => ((mediaclassification_stats[]) new mediaclassification_stats().stat_resources(service, (options) null))[0];

    public static mediaclassification_stats get(
      nitro_service service,
      options option)
    {
      return ((mediaclassification_stats[]) new mediaclassification_stats().stat_resources(service, option))[0];
    }

    private class mediaclassification_response : base_response
    {
      public mediaclassification_stats mediaclassification = (mediaclassification_stats) null;
    }

    public static class clearstatsEnum
    {
      public const string basic = "basic";
      public const string full = "full";
    }
  }
}
