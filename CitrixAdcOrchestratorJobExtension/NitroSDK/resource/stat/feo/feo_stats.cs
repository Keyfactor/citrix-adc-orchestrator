// Decompiled with JetBrains decompiler
// Type: com.citrix.netscaler.nitro.resource.stat.feo.feo_stats
// Assembly: nitro, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 6CF5DDEF-E052-4F9D-953F-6644F8378A66


using com.citrix.netscaler.nitro.exception;
using com.citrix.netscaler.nitro.resource.Base;
using com.citrix.netscaler.nitro.service;

namespace com.citrix.netscaler.nitro.resource.stat.feo
{
  public class feo_stats : base_resource
  {
    private string clearstatsField = (string) null;
    private long optcacheobjectsField = 0;
    private long optcacheobjectsrateField = 0;
    private long origcacheobjectsField = 0;
    private long origcacheobjectsrateField = 0;
    private long totalimgsdomainshardedField = 0;
    private long imgsdomainshardedrateField = 0;
    private long totalimgslazyloadedField = 0;
    private long imgslazyloadedrateField = 0;
    private long toturireplacedField = 0;
    private long urireplacedrateField = 0;
    private long totalimgsinlinedincssField = 0;
    private long imgsinlinedincssrateField = 0;
    private long totalinlinedjsField = 0;
    private long inlinedjsrateField = 0;
    private long totalinlinedcssField = 0;
    private long inlinedcssrateField = 0;
    private long totalinlinedimgsField = 0;
    private long inlinedimgsrateField = 0;
    private long totaldatasavingsField = 0;
    private long datasavingsrateField = 0;
    private long htmlcommentsremovedField = 0;
    private long htmlcommentsremovedrateField = 0;
    private long totalcacheextendedField = 0;
    private long cacheextendedrateField = 0;
    private long totalcsscombinedField = 0;
    private long csscombinedrateField = 0;
    private long totalimporttolinkField = 0;
    private long importtolinkrateField = 0;
    private long totaljsmovedField = 0;
    private long jsmovedrateField = 0;
    private long totalcssmovedField = 0;
    private long cssmovedrateField = 0;
    private long totaljsminField = 0;
    private long jsminrateField = 0;
    private long totalcssminField = 0;
    private long cssminrateField = 0;
    private long totalimgstojxrField = 0;
    private long imgstojxrrateField = 0;
    private long totalimgstowebpField = 0;
    private long imgstowebprateField = 0;
    private long totaljpegsoptimizedField = 0;
    private long jpegsoptimizedrateField = 0;
    private long totalgifstopngField = 0;
    private long gifstopngrateField = 0;
    private long totalimgsresizedField = 0;
    private long imgsresizedrateField = 0;

    public string clearstats
    {
      get => this.clearstatsField;
      set => this.clearstatsField = value;
    }

    public long totaljsmoved
    {
      get => this.totaljsmovedField;
      private set => this.totaljsmovedField = value;
    }

    public long totalimgslazyloaded
    {
      get => this.totalimgslazyloadedField;
      private set => this.totalimgslazyloadedField = value;
    }

    public long htmlcommentsremovedrate
    {
      get => this.htmlcommentsremovedrateField;
      private set => this.htmlcommentsremovedrateField = value;
    }

    public long urireplacedrate
    {
      get => this.urireplacedrateField;
      private set => this.urireplacedrateField = value;
    }

    public long cssmovedrate
    {
      get => this.cssmovedrateField;
      private set => this.cssmovedrateField = value;
    }

    public long htmlcommentsremoved
    {
      get => this.htmlcommentsremovedField;
      private set => this.htmlcommentsremovedField = value;
    }

    public long jsmovedrate
    {
      get => this.jsmovedrateField;
      private set => this.jsmovedrateField = value;
    }

    public long totalimgsinlinedincss
    {
      get => this.totalimgsinlinedincssField;
      private set => this.totalimgsinlinedincssField = value;
    }

    public long totalinlinedcss
    {
      get => this.totalinlinedcssField;
      private set => this.totalinlinedcssField = value;
    }

    public long inlinedimgsrate
    {
      get => this.inlinedimgsrateField;
      private set => this.inlinedimgsrateField = value;
    }

    public long toturireplaced
    {
      get => this.toturireplacedField;
      private set => this.toturireplacedField = value;
    }

    public long imgstowebprate
    {
      get => this.imgstowebprateField;
      private set => this.imgstowebprateField = value;
    }

    public long totalinlinedjs
    {
      get => this.totalinlinedjsField;
      private set => this.totalinlinedjsField = value;
    }

    public long totalcssmoved
    {
      get => this.totalcssmovedField;
      private set => this.totalcssmovedField = value;
    }

    public long csscombinedrate
    {
      get => this.csscombinedrateField;
      private set => this.csscombinedrateField = value;
    }

    public long imgslazyloadedrate
    {
      get => this.imgslazyloadedrateField;
      private set => this.imgslazyloadedrateField = value;
    }

    public long totaljsmin
    {
      get => this.totaljsminField;
      private set => this.totaljsminField = value;
    }

    public long optcacheobjects
    {
      get => this.optcacheobjectsField;
      private set => this.optcacheobjectsField = value;
    }

    public long totalgifstopng
    {
      get => this.totalgifstopngField;
      private set => this.totalgifstopngField = value;
    }

    public long totalimgsresized
    {
      get => this.totalimgsresizedField;
      private set => this.totalimgsresizedField = value;
    }

    public long imgsinlinedincssrate
    {
      get => this.imgsinlinedincssrateField;
      private set => this.imgsinlinedincssrateField = value;
    }

    public long inlinedcssrate
    {
      get => this.inlinedcssrateField;
      private set => this.inlinedcssrateField = value;
    }

    public long totalimgstowebp
    {
      get => this.totalimgstowebpField;
      private set => this.totalimgstowebpField = value;
    }

    public long inlinedjsrate
    {
      get => this.inlinedjsrateField;
      private set => this.inlinedjsrateField = value;
    }

    public long origcacheobjectsrate
    {
      get => this.origcacheobjectsrateField;
      private set => this.origcacheobjectsrateField = value;
    }

    public long cssminrate
    {
      get => this.cssminrateField;
      private set => this.cssminrateField = value;
    }

    public long totalimgsdomainsharded
    {
      get => this.totalimgsdomainshardedField;
      private set => this.totalimgsdomainshardedField = value;
    }

    public long imgsdomainshardedrate
    {
      get => this.imgsdomainshardedrateField;
      private set => this.imgsdomainshardedrateField = value;
    }

    public long gifstopngrate
    {
      get => this.gifstopngrateField;
      private set => this.gifstopngrateField = value;
    }

    public long importtolinkrate
    {
      get => this.importtolinkrateField;
      private set => this.importtolinkrateField = value;
    }

    public long totalcsscombined
    {
      get => this.totalcsscombinedField;
      private set => this.totalcsscombinedField = value;
    }

    public long totalimgstojxr
    {
      get => this.totalimgstojxrField;
      private set => this.totalimgstojxrField = value;
    }

    public long imgsresizedrate
    {
      get => this.imgsresizedrateField;
      private set => this.imgsresizedrateField = value;
    }

    public long optcacheobjectsrate
    {
      get => this.optcacheobjectsrateField;
      private set => this.optcacheobjectsrateField = value;
    }

    public long totaljpegsoptimized
    {
      get => this.totaljpegsoptimizedField;
      private set => this.totaljpegsoptimizedField = value;
    }

    public long totalcacheextended
    {
      get => this.totalcacheextendedField;
      private set => this.totalcacheextendedField = value;
    }

    public long origcacheobjects
    {
      get => this.origcacheobjectsField;
      private set => this.origcacheobjectsField = value;
    }

    public long jsminrate
    {
      get => this.jsminrateField;
      private set => this.jsminrateField = value;
    }

    public long jpegsoptimizedrate
    {
      get => this.jpegsoptimizedrateField;
      private set => this.jpegsoptimizedrateField = value;
    }

    public long totaldatasavings
    {
      get => this.totaldatasavingsField;
      private set => this.totaldatasavingsField = value;
    }

    public long imgstojxrrate
    {
      get => this.imgstojxrrateField;
      private set => this.imgstojxrrateField = value;
    }

    public long datasavingsrate
    {
      get => this.datasavingsrateField;
      private set => this.datasavingsrateField = value;
    }

    public long cacheextendedrate
    {
      get => this.cacheextendedrateField;
      private set => this.cacheextendedrateField = value;
    }

    public long totalcssmin
    {
      get => this.totalcssminField;
      private set => this.totalcssminField = value;
    }

    public long totalinlinedimgs
    {
      get => this.totalinlinedimgsField;
      private set => this.totalinlinedimgsField = value;
    }

    public long totalimporttolink
    {
      get => this.totalimporttolinkField;
      private set => this.totalimporttolinkField = value;
    }

    internal override base_resource[] get_nitro_response(
      nitro_service service,
      string response)
    {
      feo_stats[] feoStatsArray = new feo_stats[1];
      feo_stats.feo_response feoResponse = new feo_stats.feo_response();
      feo_stats.feo_response resource = (feo_stats.feo_response) service.get_payload_formatter().string_to_resource(feoResponse.GetType(), response);
      if (resource.errorcode != 0)
      {
        if (resource.errorcode == 444)
          service.clear_session();
        if (resource.severity == null)
          throw new nitro_exception(resource.message, resource.errorcode);
        if (resource.severity.Equals("ERROR"))
          throw new nitro_exception(resource.message, resource.errorcode);
      }
      feoStatsArray[0] = resource.feo;
      return (base_resource[]) feoStatsArray;
    }

    internal override string get_object_name() => (string) null;

    public static feo_stats get(nitro_service service) => ((feo_stats[]) new feo_stats().stat_resources(service, (options) null))[0];

    public static feo_stats get(nitro_service service, options option) => ((feo_stats[]) new feo_stats().stat_resources(service, option))[0];

    private class feo_response : base_response
    {
      public feo_stats feo = (feo_stats) null;
    }

    public static class clearstatsEnum
    {
      public const string basic = "basic";
      public const string full = "full";
    }
  }
}
