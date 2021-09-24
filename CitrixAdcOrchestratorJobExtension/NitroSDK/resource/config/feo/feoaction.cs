// Decompiled with JetBrains decompiler
// Type: com.citrix.netscaler.nitro.resource.config.feo.feoaction
// Assembly: nitro, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 6CF5DDEF-E052-4F9D-953F-6644F8378A66


using com.citrix.netscaler.nitro.exception;
using com.citrix.netscaler.nitro.resource.Base;
using com.citrix.netscaler.nitro.service;
using com.citrix.netscaler.nitro.util;

namespace com.citrix.netscaler.nitro.resource.config.feo
{
  public class feoaction : base_resource
  {
    private string nameField = (string) null;
    private bool? pageextendcacheField = new bool?();
    private bool? imgshrinktoattribField = new bool?();
    private bool? imggiftopngField = new bool?();
    private bool? imgtowebpField = new bool?();
    private bool? imgtojpegxrField = new bool?();
    private bool? imginlineField = new bool?();
    private bool? cssimginlineField = new bool?();
    private bool? jpgoptimizeField = new bool?();
    private bool? imglazyloadField = new bool?();
    private bool? cssminifyField = new bool?();
    private bool? cssinlineField = new bool?();
    private bool? csscombineField = new bool?();
    private bool? convertimporttolinkField = new bool?();
    private bool? jsminifyField = new bool?();
    private bool? jsinlineField = new bool?();
    private bool? htmlminifyField = new bool?();
    private bool? cssmovetoheadField = new bool?();
    private bool? jsmovetoendField = new bool?();
    private string domainshardingField = (string) null;
    private string[] dnsshardsField = (string[]) null;
    private bool? clientsidemeasurementsField = new bool?();
    private bool? imgadddimensionsField = new bool?();
    private bool? imgshrinkformobileField = new bool?();
    private bool? imgweakenField = new bool?();
    private bool? jpgprogressiveField = new bool?();
    private bool? cssflattenimportsField = new bool?();
    private bool? jscombineField = new bool?();
    private bool? htmlrmdefaultattribsField = new bool?();
    private bool? htmlrmattribquotesField = new bool?();
    private bool? htmltrimurlsField = new bool?();
    private long? hitsField = new long?();
    private long? undefhitsField = new long?();
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

    public bool? pageextendcache
    {
      get => this.pageextendcacheField;
      set => this.pageextendcacheField = value;
    }

    public bool? imgshrinktoattrib
    {
      get => this.imgshrinktoattribField;
      set => this.imgshrinktoattribField = value;
    }

    public bool? imggiftopng
    {
      get => this.imggiftopngField;
      set => this.imggiftopngField = value;
    }

    public bool? imgtowebp
    {
      get => this.imgtowebpField;
      set => this.imgtowebpField = value;
    }

    public bool? imgtojpegxr
    {
      get => this.imgtojpegxrField;
      set => this.imgtojpegxrField = value;
    }

    public bool? imginline
    {
      get => this.imginlineField;
      set => this.imginlineField = value;
    }

    public bool? cssimginline
    {
      get => this.cssimginlineField;
      set => this.cssimginlineField = value;
    }

    public bool? jpgoptimize
    {
      get => this.jpgoptimizeField;
      set => this.jpgoptimizeField = value;
    }

    public bool? imglazyload
    {
      get => this.imglazyloadField;
      set => this.imglazyloadField = value;
    }

    public bool? cssminify
    {
      get => this.cssminifyField;
      set => this.cssminifyField = value;
    }

    public bool? cssinline
    {
      get => this.cssinlineField;
      set => this.cssinlineField = value;
    }

    public bool? csscombine
    {
      get => this.csscombineField;
      set => this.csscombineField = value;
    }

    public bool? convertimporttolink
    {
      get => this.convertimporttolinkField;
      set => this.convertimporttolinkField = value;
    }

    public bool? jsminify
    {
      get => this.jsminifyField;
      set => this.jsminifyField = value;
    }

    public bool? jsinline
    {
      get => this.jsinlineField;
      set => this.jsinlineField = value;
    }

    public bool? htmlminify
    {
      get => this.htmlminifyField;
      set => this.htmlminifyField = value;
    }

    public bool? cssmovetohead
    {
      get => this.cssmovetoheadField;
      set => this.cssmovetoheadField = value;
    }

    public bool? jsmovetoend
    {
      get => this.jsmovetoendField;
      set => this.jsmovetoendField = value;
    }

    public string domainsharding
    {
      get => this.domainshardingField;
      set => this.domainshardingField = value;
    }

    public string[] dnsshards
    {
      get => this.dnsshardsField;
      set => this.dnsshardsField = value;
    }

    public bool? clientsidemeasurements
    {
      get => this.clientsidemeasurementsField;
      set => this.clientsidemeasurementsField = value;
    }

    public bool? imgadddimensions
    {
      get => this.imgadddimensionsField;
      private set => this.imgadddimensionsField = value;
    }

    public bool? imgshrinkformobile
    {
      get => this.imgshrinkformobileField;
      private set => this.imgshrinkformobileField = value;
    }

    public bool? imgweaken
    {
      get => this.imgweakenField;
      private set => this.imgweakenField = value;
    }

    public bool? jpgprogressive
    {
      get => this.jpgprogressiveField;
      private set => this.jpgprogressiveField = value;
    }

    public bool? cssflattenimports
    {
      get => this.cssflattenimportsField;
      private set => this.cssflattenimportsField = value;
    }

    public bool? jscombine
    {
      get => this.jscombineField;
      private set => this.jscombineField = value;
    }

    public bool? htmlrmdefaultattribs
    {
      get => this.htmlrmdefaultattribsField;
      private set => this.htmlrmdefaultattribsField = value;
    }

    public bool? htmlrmattribquotes
    {
      get => this.htmlrmattribquotesField;
      private set => this.htmlrmattribquotesField = value;
    }

    public bool? htmltrimurls
    {
      get => this.htmltrimurlsField;
      private set => this.htmltrimurlsField = value;
    }

    public long? hits
    {
      get => this.hitsField;
      private set => this.hitsField = value;
    }

    public long? undefhits
    {
      get => this.undefhitsField;
      private set => this.undefhitsField = value;
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
      feoaction.feoaction_response feoactionResponse = new feoaction.feoaction_response();
      feoaction.feoaction_response resource = (feoaction.feoaction_response) service.get_payload_formatter().string_to_resource(feoactionResponse.GetType(), response);
      if (resource.errorcode != 0)
      {
        if (resource.errorcode == 444)
          service.clear_session();
        if (resource.severity == null)
          throw new nitro_exception(resource.message, resource.errorcode);
        if (resource.severity.Equals("ERROR"))
          throw new nitro_exception(resource.message, resource.errorcode);
      }
      return (base_resource[]) resource.feoaction;
    }

    internal override string get_object_name() => this.name;

    public static base_response add(nitro_service client, feoaction resource) => new feoaction()
    {
      name = resource.name,
      pageextendcache = resource.pageextendcache,
      imgshrinktoattrib = resource.imgshrinktoattrib,
      imggiftopng = resource.imggiftopng,
      imgtowebp = resource.imgtowebp,
      imgtojpegxr = resource.imgtojpegxr,
      imginline = resource.imginline,
      cssimginline = resource.cssimginline,
      jpgoptimize = resource.jpgoptimize,
      imglazyload = resource.imglazyload,
      cssminify = resource.cssminify,
      cssinline = resource.cssinline,
      csscombine = resource.csscombine,
      convertimporttolink = resource.convertimporttolink,
      jsminify = resource.jsminify,
      jsinline = resource.jsinline,
      htmlminify = resource.htmlminify,
      cssmovetohead = resource.cssmovetohead,
      jsmovetoend = resource.jsmovetoend,
      domainsharding = resource.domainsharding,
      dnsshards = resource.dnsshards,
      clientsidemeasurements = resource.clientsidemeasurements
    }.add_resource(client);

    public static base_responses add(nitro_service client, feoaction[] resources)
    {
      base_responses baseResponses = (base_responses) null;
      if (resources != null && resources.Length > 0)
      {
        feoaction[] feoactionArray = new feoaction[resources.Length];
        for (int index = 0; index < resources.Length; ++index)
        {
          feoactionArray[index] = new feoaction();
          feoactionArray[index].name = resources[index].name;
          feoactionArray[index].pageextendcache = resources[index].pageextendcache;
          feoactionArray[index].imgshrinktoattrib = resources[index].imgshrinktoattrib;
          feoactionArray[index].imggiftopng = resources[index].imggiftopng;
          feoactionArray[index].imgtowebp = resources[index].imgtowebp;
          feoactionArray[index].imgtojpegxr = resources[index].imgtojpegxr;
          feoactionArray[index].imginline = resources[index].imginline;
          feoactionArray[index].cssimginline = resources[index].cssimginline;
          feoactionArray[index].jpgoptimize = resources[index].jpgoptimize;
          feoactionArray[index].imglazyload = resources[index].imglazyload;
          feoactionArray[index].cssminify = resources[index].cssminify;
          feoactionArray[index].cssinline = resources[index].cssinline;
          feoactionArray[index].csscombine = resources[index].csscombine;
          feoactionArray[index].convertimporttolink = resources[index].convertimporttolink;
          feoactionArray[index].jsminify = resources[index].jsminify;
          feoactionArray[index].jsinline = resources[index].jsinline;
          feoactionArray[index].htmlminify = resources[index].htmlminify;
          feoactionArray[index].cssmovetohead = resources[index].cssmovetohead;
          feoactionArray[index].jsmovetoend = resources[index].jsmovetoend;
          feoactionArray[index].domainsharding = resources[index].domainsharding;
          feoactionArray[index].dnsshards = resources[index].dnsshards;
          feoactionArray[index].clientsidemeasurements = resources[index].clientsidemeasurements;
        }
        baseResponses = base_resource.add_bulk_request(client, (base_resource[]) feoactionArray);
      }
      return baseResponses;
    }

    public static base_response update(nitro_service client, feoaction resource) => new feoaction()
    {
      name = resource.name,
      pageextendcache = resource.pageextendcache,
      imgshrinktoattrib = resource.imgshrinktoattrib,
      imggiftopng = resource.imggiftopng,
      imgtowebp = resource.imgtowebp,
      imgtojpegxr = resource.imgtojpegxr,
      imginline = resource.imginline,
      cssimginline = resource.cssimginline,
      jpgoptimize = resource.jpgoptimize,
      imglazyload = resource.imglazyload,
      cssminify = resource.cssminify,
      cssinline = resource.cssinline,
      csscombine = resource.csscombine,
      convertimporttolink = resource.convertimporttolink,
      jsminify = resource.jsminify,
      jsinline = resource.jsinline,
      htmlminify = resource.htmlminify,
      cssmovetohead = resource.cssmovetohead,
      jsmovetoend = resource.jsmovetoend,
      domainsharding = resource.domainsharding,
      dnsshards = resource.dnsshards,
      clientsidemeasurements = resource.clientsidemeasurements
    }.update_resource(client);

    public static base_responses update(nitro_service client, feoaction[] resources)
    {
      base_responses baseResponses = (base_responses) null;
      if (resources != null && resources.Length > 0)
      {
        feoaction[] feoactionArray = new feoaction[resources.Length];
        for (int index = 0; index < resources.Length; ++index)
        {
          feoactionArray[index] = new feoaction();
          feoactionArray[index].name = resources[index].name;
          feoactionArray[index].pageextendcache = resources[index].pageextendcache;
          feoactionArray[index].imgshrinktoattrib = resources[index].imgshrinktoattrib;
          feoactionArray[index].imggiftopng = resources[index].imggiftopng;
          feoactionArray[index].imgtowebp = resources[index].imgtowebp;
          feoactionArray[index].imgtojpegxr = resources[index].imgtojpegxr;
          feoactionArray[index].imginline = resources[index].imginline;
          feoactionArray[index].cssimginline = resources[index].cssimginline;
          feoactionArray[index].jpgoptimize = resources[index].jpgoptimize;
          feoactionArray[index].imglazyload = resources[index].imglazyload;
          feoactionArray[index].cssminify = resources[index].cssminify;
          feoactionArray[index].cssinline = resources[index].cssinline;
          feoactionArray[index].csscombine = resources[index].csscombine;
          feoactionArray[index].convertimporttolink = resources[index].convertimporttolink;
          feoactionArray[index].jsminify = resources[index].jsminify;
          feoactionArray[index].jsinline = resources[index].jsinline;
          feoactionArray[index].htmlminify = resources[index].htmlminify;
          feoactionArray[index].cssmovetohead = resources[index].cssmovetohead;
          feoactionArray[index].jsmovetoend = resources[index].jsmovetoend;
          feoactionArray[index].domainsharding = resources[index].domainsharding;
          feoactionArray[index].dnsshards = resources[index].dnsshards;
          feoactionArray[index].clientsidemeasurements = resources[index].clientsidemeasurements;
        }
        baseResponses = base_resource.update_bulk_request(client, (base_resource[]) feoactionArray);
      }
      return baseResponses;
    }

    public static base_response unset(
      nitro_service client,
      string name,
      string[] args)
    {
      return new feoaction() { name = name }.unset_resource(client, args);
    }

    public static base_response unset(
      nitro_service client,
      feoaction resource,
      string[] args)
    {
      return new feoaction() { name = resource.name }.unset_resource(client, args);
    }

    public static base_responses unset(
      nitro_service client,
      string[] name,
      string[] args)
    {
      base_responses baseResponses = (base_responses) null;
      if (name != null && name.Length > 0)
      {
        feoaction[] feoactionArray = new feoaction[name.Length];
        for (int index = 0; index < name.Length; ++index)
        {
          feoactionArray[index] = new feoaction();
          feoactionArray[index].name = name[index];
        }
        baseResponses = base_resource.unset_bulk_request(client, (base_resource[]) feoactionArray, args);
      }
      return baseResponses;
    }

    public static base_responses unset(
      nitro_service client,
      feoaction[] resources,
      string[] args)
    {
      base_responses baseResponses = (base_responses) null;
      if (resources != null && resources.Length > 0)
      {
        feoaction[] feoactionArray = new feoaction[resources.Length];
        for (int index = 0; index < resources.Length; ++index)
        {
          feoactionArray[index] = new feoaction();
          feoactionArray[index].name = resources[index].name;
        }
        baseResponses = base_resource.unset_bulk_request(client, (base_resource[]) feoactionArray, args);
      }
      return baseResponses;
    }

    public static base_response delete(nitro_service client, string name) => new feoaction()
    {
      name = name
    }.delete_resource(client);

    public static base_response delete(nitro_service client, feoaction resource) => new feoaction()
    {
      name = resource.name
    }.delete_resource(client);

    public static base_responses delete(nitro_service client, string[] name)
    {
      base_responses baseResponses = (base_responses) null;
      if (name != null && name.Length > 0)
      {
        feoaction[] feoactionArray = new feoaction[name.Length];
        for (int index = 0; index < name.Length; ++index)
        {
          feoactionArray[index] = new feoaction();
          feoactionArray[index].name = name[index];
        }
        baseResponses = base_resource.delete_bulk_request(client, (base_resource[]) feoactionArray);
      }
      return baseResponses;
    }

    public static base_responses delete(nitro_service client, feoaction[] resources)
    {
      base_responses baseResponses = (base_responses) null;
      if (resources != null && resources.Length > 0)
      {
        feoaction[] feoactionArray = new feoaction[resources.Length];
        for (int index = 0; index < resources.Length; ++index)
        {
          feoactionArray[index] = new feoaction();
          feoactionArray[index].name = resources[index].name;
        }
        baseResponses = base_resource.delete_bulk_request(client, (base_resource[]) feoactionArray);
      }
      return baseResponses;
    }

    public static feoaction[] get(nitro_service service) => (feoaction[]) new feoaction().get_resources(service, (options) null);

    public static feoaction[] get(nitro_service service, options option) => (feoaction[]) new feoaction().get_resources(service, option);

    public static feoaction get(nitro_service service, string name) => (feoaction) new feoaction()
    {
      name = name
    }.get_resource(service);

    public static feoaction[] get(nitro_service service, string[] name)
    {
      if (name == null || name.Length <= 0)
        return (feoaction[]) null;
      feoaction[] feoactionArray1 = new feoaction[name.Length];
      feoaction[] feoactionArray2 = new feoaction[name.Length];
      for (int index = 0; index < name.Length; ++index)
      {
        feoactionArray2[index] = new feoaction();
        feoactionArray2[index].name = name[index];
        feoactionArray1[index] = (feoaction) feoactionArray2[index].get_resource(service);
      }
      return feoactionArray1;
    }

    public static feoaction[] get_filtered(nitro_service service, string filter)
    {
      feoaction feoaction = new feoaction();
      options option = new options();
      option.set_filter(filter);
      return (feoaction[]) feoaction.getfiltered(service, option);
    }

    public static feoaction[] get_filtered(nitro_service service, filtervalue[] filter)
    {
      feoaction feoaction = new feoaction();
      options option = new options();
      option.set_filter(filter);
      return (feoaction[]) feoaction.getfiltered(service, option);
    }

    public static uint count(nitro_service service)
    {
      feoaction feoaction = new feoaction();
      options option = new options();
      option.set_count(true);
      feoaction[] resources = (feoaction[]) feoaction.get_resources(service, option);
      return resources != null && resources.Length > 0 ? resources[0].__count.Value : 0U;
    }

    public static uint count_filtered(nitro_service service, string filter)
    {
      feoaction feoaction = new feoaction();
      options option = new options();
      option.set_count(true);
      option.set_filter(filter);
      feoaction[] feoactionArray = (feoaction[]) feoaction.getfiltered(service, option);
      return feoactionArray != null && feoactionArray.Length > 0 ? feoactionArray[0].__count.Value : 0U;
    }

    public static uint count_filtered(nitro_service service, filtervalue[] filter)
    {
      feoaction feoaction = new feoaction();
      options option = new options();
      option.set_count(true);
      option.set_filter(filter);
      feoaction[] feoactionArray = (feoaction[]) feoaction.getfiltered(service, option);
      return feoactionArray != null && feoactionArray.Length > 0 ? feoactionArray[0].__count.Value : 0U;
    }

    private class feoaction_response : base_response
    {
      public feoaction[] feoaction = (feoaction[]) null;
    }

    public static class builtinEnum
    {
      public const string MODIFIABLE = "MODIFIABLE";
      public const string DELETABLE = "DELETABLE";
      public const string IMMUTABLE = "IMMUTABLE";
      public const string PARTITION_ALL = "PARTITION_ALL";
    }
  }
}
