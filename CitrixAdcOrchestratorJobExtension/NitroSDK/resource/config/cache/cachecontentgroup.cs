// Decompiled with JetBrains decompiler
// Type: com.citrix.netscaler.nitro.resource.config.cache.cachecontentgroup
// Assembly: nitro, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 6CF5DDEF-E052-4F9D-953F-6644F8378A66


using com.citrix.netscaler.nitro.exception;
using com.citrix.netscaler.nitro.resource.Base;
using com.citrix.netscaler.nitro.service;
using com.citrix.netscaler.nitro.util;

namespace com.citrix.netscaler.nitro.resource.config.cache
{
  public class cachecontentgroup : base_resource
  {
    private string nameField = (string) null;
    private long? weakposrelexpiryField = new long?();
    private uint? heurexpiryparamField = new uint?();
    private long? relexpiryField = new long?();
    private uint? relexpirymillisecField = new uint?();
    private string[] absexpiryField = (string[]) null;
    private string[] absexpirygmtField = (string[]) null;
    private long? weaknegrelexpiryField = new long?();
    private string[] hitparamsField = (string[]) null;
    private string[] invalparamsField = (string[]) null;
    private string ignoreparamvaluecaseField = (string) null;
    private string matchcookiesField = (string) null;
    private string invalrestrictedtohostField = (string) null;
    private string polleverytimeField = (string) null;
    private string ignorereloadreqField = (string) null;
    private string removecookiesField = (string) null;
    private string prefetchField = (string) null;
    private long? prefetchperiodField = new long?();
    private uint? prefetchperiodmillisecField = new uint?();
    private uint? prefetchmaxpendingField = new uint?();
    private string flashcacheField = (string) null;
    private string expireatlastbyteField = (string) null;
    private string insertviaField = (string) null;
    private string insertageField = (string) null;
    private string insertetagField = (string) null;
    private string cachecontrolField = (string) null;
    private long? quickabortsizeField = new long?();
    private long? minressizeField = new long?();
    private long? maxressizeField = new long?();
    private long? memlimitField = new long?();
    private string ignorereqcachinghdrsField = (string) null;
    private int? minhitsField = new int?();
    private string alwaysevalpoliciesField = (string) null;
    private string persisthaField = (string) null;
    private string pinnedField = (string) null;
    private string lazydnsresolveField = (string) null;
    private string hitselectorField = (string) null;
    private string invalselectorField = (string) null;
    private string typeField = (string) null;
    private string queryField = (string) null;
    private string hostField = (string) null;
    private string selectorvalueField = (string) null;
    private string tosecondaryField = (string) null;
    private uint? flagsField = new uint?();
    private uint? prefetchcurField = new uint?();
    private long? memusageField = new long?();
    private long? memdusageField = new long?();
    private long? disklimitField = new long?();
    private long? cachenon304hitsField = new long?();
    private long? cache304hitsField = new long?();
    private uint? cachecellsField = new uint?();
    private uint? cachegroupincarnationField = new uint?();
    private string persistField = (string) null;
    private string[] policynameField = (string[]) null;
    private uint? cachenuminvalpolicyField = new uint?();
    private uint? markercellsField = new uint?();
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

    public long? weakposrelexpiry
    {
      get => this.weakposrelexpiryField;
      set => this.weakposrelexpiryField = value;
    }

    public uint? heurexpiryparam
    {
      get => this.heurexpiryparamField;
      set => this.heurexpiryparamField = value;
    }

    public long? relexpiry
    {
      get => this.relexpiryField;
      set => this.relexpiryField = value;
    }

    public uint? relexpirymillisec
    {
      get => this.relexpirymillisecField;
      set => this.relexpirymillisecField = value;
    }

    public string[] absexpiry
    {
      get => this.absexpiryField;
      set => this.absexpiryField = value;
    }

    public string[] absexpirygmt
    {
      get => this.absexpirygmtField;
      set => this.absexpirygmtField = value;
    }

    public long? weaknegrelexpiry
    {
      get => this.weaknegrelexpiryField;
      set => this.weaknegrelexpiryField = value;
    }

    public string[] hitparams
    {
      get => this.hitparamsField;
      set => this.hitparamsField = value;
    }

    public string[] invalparams
    {
      get => this.invalparamsField;
      set => this.invalparamsField = value;
    }

    public string ignoreparamvaluecase
    {
      get => this.ignoreparamvaluecaseField;
      set => this.ignoreparamvaluecaseField = value;
    }

    public string matchcookies
    {
      get => this.matchcookiesField;
      set => this.matchcookiesField = value;
    }

    public string invalrestrictedtohost
    {
      get => this.invalrestrictedtohostField;
      set => this.invalrestrictedtohostField = value;
    }

    public string polleverytime
    {
      get => this.polleverytimeField;
      set => this.polleverytimeField = value;
    }

    public string ignorereloadreq
    {
      get => this.ignorereloadreqField;
      set => this.ignorereloadreqField = value;
    }

    public string removecookies
    {
      get => this.removecookiesField;
      set => this.removecookiesField = value;
    }

    public string prefetch
    {
      get => this.prefetchField;
      set => this.prefetchField = value;
    }

    public long? prefetchperiod
    {
      get => this.prefetchperiodField;
      set => this.prefetchperiodField = value;
    }

    public uint? prefetchperiodmillisec
    {
      get => this.prefetchperiodmillisecField;
      set => this.prefetchperiodmillisecField = value;
    }

    public uint? prefetchmaxpending
    {
      get => this.prefetchmaxpendingField;
      set => this.prefetchmaxpendingField = value;
    }

    public string flashcache
    {
      get => this.flashcacheField;
      set => this.flashcacheField = value;
    }

    public string expireatlastbyte
    {
      get => this.expireatlastbyteField;
      set => this.expireatlastbyteField = value;
    }

    public string insertvia
    {
      get => this.insertviaField;
      set => this.insertviaField = value;
    }

    public string insertage
    {
      get => this.insertageField;
      set => this.insertageField = value;
    }

    public string insertetag
    {
      get => this.insertetagField;
      set => this.insertetagField = value;
    }

    public string cachecontrol
    {
      get => this.cachecontrolField;
      set => this.cachecontrolField = value;
    }

    public long? quickabortsize
    {
      get => this.quickabortsizeField;
      set => this.quickabortsizeField = value;
    }

    public long? minressize
    {
      get => this.minressizeField;
      set => this.minressizeField = value;
    }

    public long? maxressize
    {
      get => this.maxressizeField;
      set => this.maxressizeField = value;
    }

    public long? memlimit
    {
      get => this.memlimitField;
      set => this.memlimitField = value;
    }

    public string ignorereqcachinghdrs
    {
      get => this.ignorereqcachinghdrsField;
      set => this.ignorereqcachinghdrsField = value;
    }

    public int? minhits
    {
      get => this.minhitsField;
      set => this.minhitsField = value;
    }

    public string alwaysevalpolicies
    {
      get => this.alwaysevalpoliciesField;
      set => this.alwaysevalpoliciesField = value;
    }

    public string persistha
    {
      get => this.persisthaField;
      set => this.persisthaField = value;
    }

    public string pinned
    {
      get => this.pinnedField;
      set => this.pinnedField = value;
    }

    public string lazydnsresolve
    {
      get => this.lazydnsresolveField;
      set => this.lazydnsresolveField = value;
    }

    public string hitselector
    {
      get => this.hitselectorField;
      set => this.hitselectorField = value;
    }

    public string invalselector
    {
      get => this.invalselectorField;
      set => this.invalselectorField = value;
    }

    public string type
    {
      get => this.typeField;
      set => this.typeField = value;
    }

    public string query
    {
      get => this.queryField;
      set => this.queryField = value;
    }

    public string host
    {
      get => this.hostField;
      set => this.hostField = value;
    }

    public string selectorvalue
    {
      get => this.selectorvalueField;
      set => this.selectorvalueField = value;
    }

    public string tosecondary
    {
      get => this.tosecondaryField;
      set => this.tosecondaryField = value;
    }

    public uint? flags
    {
      get => this.flagsField;
      private set => this.flagsField = value;
    }

    public uint? prefetchcur
    {
      get => this.prefetchcurField;
      private set => this.prefetchcurField = value;
    }

    public long? memusage
    {
      get => this.memusageField;
      private set => this.memusageField = value;
    }

    public long? memdusage
    {
      get => this.memdusageField;
      private set => this.memdusageField = value;
    }

    public long? disklimit
    {
      get => this.disklimitField;
      private set => this.disklimitField = value;
    }

    public long? cachenon304hits
    {
      get => this.cachenon304hitsField;
      private set => this.cachenon304hitsField = value;
    }

    public long? cache304hits
    {
      get => this.cache304hitsField;
      private set => this.cache304hitsField = value;
    }

    public uint? cachecells
    {
      get => this.cachecellsField;
      private set => this.cachecellsField = value;
    }

    public uint? cachegroupincarnation
    {
      get => this.cachegroupincarnationField;
      private set => this.cachegroupincarnationField = value;
    }

    public string persist
    {
      get => this.persistField;
      private set => this.persistField = value;
    }

    public string[] policyname
    {
      get => this.policynameField;
      private set => this.policynameField = value;
    }

    public uint? cachenuminvalpolicy
    {
      get => this.cachenuminvalpolicyField;
      private set => this.cachenuminvalpolicyField = value;
    }

    public uint? markercells
    {
      get => this.markercellsField;
      private set => this.markercellsField = value;
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
      cachecontentgroup.cachecontentgroup_response cachecontentgroupResponse = new cachecontentgroup.cachecontentgroup_response();
      cachecontentgroup.cachecontentgroup_response resource = (cachecontentgroup.cachecontentgroup_response) service.get_payload_formatter().string_to_resource(cachecontentgroupResponse.GetType(), response);
      if (resource.errorcode != 0)
      {
        if (resource.errorcode == 444)
          service.clear_session();
        if (resource.severity == null)
          throw new nitro_exception(resource.message, resource.errorcode);
        if (resource.severity.Equals("ERROR"))
          throw new nitro_exception(resource.message, resource.errorcode);
      }
      return (base_resource[]) resource.cachecontentgroup;
    }

    internal override string get_object_name() => this.name;

    public static base_response add(nitro_service client, cachecontentgroup resource) => new cachecontentgroup()
    {
      name = resource.name,
      weakposrelexpiry = resource.weakposrelexpiry,
      heurexpiryparam = resource.heurexpiryparam,
      relexpiry = resource.relexpiry,
      relexpirymillisec = resource.relexpirymillisec,
      absexpiry = resource.absexpiry,
      absexpirygmt = resource.absexpirygmt,
      weaknegrelexpiry = resource.weaknegrelexpiry,
      hitparams = resource.hitparams,
      invalparams = resource.invalparams,
      ignoreparamvaluecase = resource.ignoreparamvaluecase,
      matchcookies = resource.matchcookies,
      invalrestrictedtohost = resource.invalrestrictedtohost,
      polleverytime = resource.polleverytime,
      ignorereloadreq = resource.ignorereloadreq,
      removecookies = resource.removecookies,
      prefetch = resource.prefetch,
      prefetchperiod = resource.prefetchperiod,
      prefetchperiodmillisec = resource.prefetchperiodmillisec,
      prefetchmaxpending = resource.prefetchmaxpending,
      flashcache = resource.flashcache,
      expireatlastbyte = resource.expireatlastbyte,
      insertvia = resource.insertvia,
      insertage = resource.insertage,
      insertetag = resource.insertetag,
      cachecontrol = resource.cachecontrol,
      quickabortsize = resource.quickabortsize,
      minressize = resource.minressize,
      maxressize = resource.maxressize,
      memlimit = resource.memlimit,
      ignorereqcachinghdrs = resource.ignorereqcachinghdrs,
      minhits = resource.minhits,
      alwaysevalpolicies = resource.alwaysevalpolicies,
      persistha = resource.persistha,
      pinned = resource.pinned,
      lazydnsresolve = resource.lazydnsresolve,
      hitselector = resource.hitselector,
      invalselector = resource.invalselector,
      type = resource.type
    }.add_resource(client);

    public static base_responses add(
      nitro_service client,
      cachecontentgroup[] resources)
    {
      base_responses baseResponses = (base_responses) null;
      if (resources != null && resources.Length > 0)
      {
        cachecontentgroup[] cachecontentgroupArray = new cachecontentgroup[resources.Length];
        for (int index = 0; index < resources.Length; ++index)
        {
          cachecontentgroupArray[index] = new cachecontentgroup();
          cachecontentgroupArray[index].name = resources[index].name;
          cachecontentgroupArray[index].weakposrelexpiry = resources[index].weakposrelexpiry;
          cachecontentgroupArray[index].heurexpiryparam = resources[index].heurexpiryparam;
          cachecontentgroupArray[index].relexpiry = resources[index].relexpiry;
          cachecontentgroupArray[index].relexpirymillisec = resources[index].relexpirymillisec;
          cachecontentgroupArray[index].absexpiry = resources[index].absexpiry;
          cachecontentgroupArray[index].absexpirygmt = resources[index].absexpirygmt;
          cachecontentgroupArray[index].weaknegrelexpiry = resources[index].weaknegrelexpiry;
          cachecontentgroupArray[index].hitparams = resources[index].hitparams;
          cachecontentgroupArray[index].invalparams = resources[index].invalparams;
          cachecontentgroupArray[index].ignoreparamvaluecase = resources[index].ignoreparamvaluecase;
          cachecontentgroupArray[index].matchcookies = resources[index].matchcookies;
          cachecontentgroupArray[index].invalrestrictedtohost = resources[index].invalrestrictedtohost;
          cachecontentgroupArray[index].polleverytime = resources[index].polleverytime;
          cachecontentgroupArray[index].ignorereloadreq = resources[index].ignorereloadreq;
          cachecontentgroupArray[index].removecookies = resources[index].removecookies;
          cachecontentgroupArray[index].prefetch = resources[index].prefetch;
          cachecontentgroupArray[index].prefetchperiod = resources[index].prefetchperiod;
          cachecontentgroupArray[index].prefetchperiodmillisec = resources[index].prefetchperiodmillisec;
          cachecontentgroupArray[index].prefetchmaxpending = resources[index].prefetchmaxpending;
          cachecontentgroupArray[index].flashcache = resources[index].flashcache;
          cachecontentgroupArray[index].expireatlastbyte = resources[index].expireatlastbyte;
          cachecontentgroupArray[index].insertvia = resources[index].insertvia;
          cachecontentgroupArray[index].insertage = resources[index].insertage;
          cachecontentgroupArray[index].insertetag = resources[index].insertetag;
          cachecontentgroupArray[index].cachecontrol = resources[index].cachecontrol;
          cachecontentgroupArray[index].quickabortsize = resources[index].quickabortsize;
          cachecontentgroupArray[index].minressize = resources[index].minressize;
          cachecontentgroupArray[index].maxressize = resources[index].maxressize;
          cachecontentgroupArray[index].memlimit = resources[index].memlimit;
          cachecontentgroupArray[index].ignorereqcachinghdrs = resources[index].ignorereqcachinghdrs;
          cachecontentgroupArray[index].minhits = resources[index].minhits;
          cachecontentgroupArray[index].alwaysevalpolicies = resources[index].alwaysevalpolicies;
          cachecontentgroupArray[index].persistha = resources[index].persistha;
          cachecontentgroupArray[index].pinned = resources[index].pinned;
          cachecontentgroupArray[index].lazydnsresolve = resources[index].lazydnsresolve;
          cachecontentgroupArray[index].hitselector = resources[index].hitselector;
          cachecontentgroupArray[index].invalselector = resources[index].invalselector;
          cachecontentgroupArray[index].type = resources[index].type;
        }
        baseResponses = base_resource.add_bulk_request(client, (base_resource[]) cachecontentgroupArray);
      }
      return baseResponses;
    }

    public static base_response delete(nitro_service client, string name) => new cachecontentgroup()
    {
      name = name
    }.delete_resource(client);

    public static base_response delete(
      nitro_service client,
      cachecontentgroup resource)
    {
      return new cachecontentgroup()
      {
        name = resource.name
      }.delete_resource(client);
    }

    public static base_responses delete(nitro_service client, string[] name)
    {
      base_responses baseResponses = (base_responses) null;
      if (name != null && name.Length > 0)
      {
        cachecontentgroup[] cachecontentgroupArray = new cachecontentgroup[name.Length];
        for (int index = 0; index < name.Length; ++index)
        {
          cachecontentgroupArray[index] = new cachecontentgroup();
          cachecontentgroupArray[index].name = name[index];
        }
        baseResponses = base_resource.delete_bulk_request(client, (base_resource[]) cachecontentgroupArray);
      }
      return baseResponses;
    }

    public static base_responses delete(
      nitro_service client,
      cachecontentgroup[] resources)
    {
      base_responses baseResponses = (base_responses) null;
      if (resources != null && resources.Length > 0)
      {
        cachecontentgroup[] cachecontentgroupArray = new cachecontentgroup[resources.Length];
        for (int index = 0; index < resources.Length; ++index)
        {
          cachecontentgroupArray[index] = new cachecontentgroup();
          cachecontentgroupArray[index].name = resources[index].name;
        }
        baseResponses = base_resource.delete_bulk_request(client, (base_resource[]) cachecontentgroupArray);
      }
      return baseResponses;
    }

    public static base_response update(
      nitro_service client,
      cachecontentgroup resource)
    {
      return new cachecontentgroup()
      {
        name = resource.name,
        weakposrelexpiry = resource.weakposrelexpiry,
        heurexpiryparam = resource.heurexpiryparam,
        relexpiry = resource.relexpiry,
        relexpirymillisec = resource.relexpirymillisec,
        absexpiry = resource.absexpiry,
        absexpirygmt = resource.absexpirygmt,
        weaknegrelexpiry = resource.weaknegrelexpiry,
        hitparams = resource.hitparams,
        invalparams = resource.invalparams,
        ignoreparamvaluecase = resource.ignoreparamvaluecase,
        matchcookies = resource.matchcookies,
        invalrestrictedtohost = resource.invalrestrictedtohost,
        polleverytime = resource.polleverytime,
        ignorereloadreq = resource.ignorereloadreq,
        removecookies = resource.removecookies,
        prefetch = resource.prefetch,
        prefetchperiod = resource.prefetchperiod,
        prefetchperiodmillisec = resource.prefetchperiodmillisec,
        prefetchmaxpending = resource.prefetchmaxpending,
        flashcache = resource.flashcache,
        expireatlastbyte = resource.expireatlastbyte,
        insertvia = resource.insertvia,
        insertage = resource.insertage,
        insertetag = resource.insertetag,
        cachecontrol = resource.cachecontrol,
        quickabortsize = resource.quickabortsize,
        minressize = resource.minressize,
        maxressize = resource.maxressize,
        memlimit = resource.memlimit,
        ignorereqcachinghdrs = resource.ignorereqcachinghdrs,
        minhits = resource.minhits,
        alwaysevalpolicies = resource.alwaysevalpolicies,
        persistha = resource.persistha,
        pinned = resource.pinned,
        lazydnsresolve = resource.lazydnsresolve,
        hitselector = resource.hitselector,
        invalselector = resource.invalselector
      }.update_resource(client);
    }

    public static base_responses update(
      nitro_service client,
      cachecontentgroup[] resources)
    {
      base_responses baseResponses = (base_responses) null;
      if (resources != null && resources.Length > 0)
      {
        cachecontentgroup[] cachecontentgroupArray = new cachecontentgroup[resources.Length];
        for (int index = 0; index < resources.Length; ++index)
        {
          cachecontentgroupArray[index] = new cachecontentgroup();
          cachecontentgroupArray[index].name = resources[index].name;
          cachecontentgroupArray[index].weakposrelexpiry = resources[index].weakposrelexpiry;
          cachecontentgroupArray[index].heurexpiryparam = resources[index].heurexpiryparam;
          cachecontentgroupArray[index].relexpiry = resources[index].relexpiry;
          cachecontentgroupArray[index].relexpirymillisec = resources[index].relexpirymillisec;
          cachecontentgroupArray[index].absexpiry = resources[index].absexpiry;
          cachecontentgroupArray[index].absexpirygmt = resources[index].absexpirygmt;
          cachecontentgroupArray[index].weaknegrelexpiry = resources[index].weaknegrelexpiry;
          cachecontentgroupArray[index].hitparams = resources[index].hitparams;
          cachecontentgroupArray[index].invalparams = resources[index].invalparams;
          cachecontentgroupArray[index].ignoreparamvaluecase = resources[index].ignoreparamvaluecase;
          cachecontentgroupArray[index].matchcookies = resources[index].matchcookies;
          cachecontentgroupArray[index].invalrestrictedtohost = resources[index].invalrestrictedtohost;
          cachecontentgroupArray[index].polleverytime = resources[index].polleverytime;
          cachecontentgroupArray[index].ignorereloadreq = resources[index].ignorereloadreq;
          cachecontentgroupArray[index].removecookies = resources[index].removecookies;
          cachecontentgroupArray[index].prefetch = resources[index].prefetch;
          cachecontentgroupArray[index].prefetchperiod = resources[index].prefetchperiod;
          cachecontentgroupArray[index].prefetchperiodmillisec = resources[index].prefetchperiodmillisec;
          cachecontentgroupArray[index].prefetchmaxpending = resources[index].prefetchmaxpending;
          cachecontentgroupArray[index].flashcache = resources[index].flashcache;
          cachecontentgroupArray[index].expireatlastbyte = resources[index].expireatlastbyte;
          cachecontentgroupArray[index].insertvia = resources[index].insertvia;
          cachecontentgroupArray[index].insertage = resources[index].insertage;
          cachecontentgroupArray[index].insertetag = resources[index].insertetag;
          cachecontentgroupArray[index].cachecontrol = resources[index].cachecontrol;
          cachecontentgroupArray[index].quickabortsize = resources[index].quickabortsize;
          cachecontentgroupArray[index].minressize = resources[index].minressize;
          cachecontentgroupArray[index].maxressize = resources[index].maxressize;
          cachecontentgroupArray[index].memlimit = resources[index].memlimit;
          cachecontentgroupArray[index].ignorereqcachinghdrs = resources[index].ignorereqcachinghdrs;
          cachecontentgroupArray[index].minhits = resources[index].minhits;
          cachecontentgroupArray[index].alwaysevalpolicies = resources[index].alwaysevalpolicies;
          cachecontentgroupArray[index].persistha = resources[index].persistha;
          cachecontentgroupArray[index].pinned = resources[index].pinned;
          cachecontentgroupArray[index].lazydnsresolve = resources[index].lazydnsresolve;
          cachecontentgroupArray[index].hitselector = resources[index].hitselector;
          cachecontentgroupArray[index].invalselector = resources[index].invalselector;
        }
        baseResponses = base_resource.update_bulk_request(client, (base_resource[]) cachecontentgroupArray);
      }
      return baseResponses;
    }

    public static base_response unset(
      nitro_service client,
      string name,
      string[] args)
    {
      return new cachecontentgroup() { name = name }.unset_resource(client, args);
    }

    public static base_response unset(
      nitro_service client,
      cachecontentgroup resource,
      string[] args)
    {
      return new cachecontentgroup()
      {
        name = resource.name
      }.unset_resource(client, args);
    }

    public static base_responses unset(
      nitro_service client,
      string[] name,
      string[] args)
    {
      base_responses baseResponses = (base_responses) null;
      if (name != null && name.Length > 0)
      {
        cachecontentgroup[] cachecontentgroupArray = new cachecontentgroup[name.Length];
        for (int index = 0; index < name.Length; ++index)
        {
          cachecontentgroupArray[index] = new cachecontentgroup();
          cachecontentgroupArray[index].name = name[index];
        }
        baseResponses = base_resource.unset_bulk_request(client, (base_resource[]) cachecontentgroupArray, args);
      }
      return baseResponses;
    }

    public static base_responses unset(
      nitro_service client,
      cachecontentgroup[] resources,
      string[] args)
    {
      base_responses baseResponses = (base_responses) null;
      if (resources != null && resources.Length > 0)
      {
        cachecontentgroup[] cachecontentgroupArray = new cachecontentgroup[resources.Length];
        for (int index = 0; index < resources.Length; ++index)
        {
          cachecontentgroupArray[index] = new cachecontentgroup();
          cachecontentgroupArray[index].name = resources[index].name;
        }
        baseResponses = base_resource.unset_bulk_request(client, (base_resource[]) cachecontentgroupArray, args);
      }
      return baseResponses;
    }

    public static base_response expire(
      nitro_service client,
      cachecontentgroup resource)
    {
      return new cachecontentgroup()
      {
        name = resource.name
      }.perform_operation_byaction(client, nameof (expire));
    }

    public static base_responses expire(
      nitro_service client,
      cachecontentgroup[] resources)
    {
      base_responses baseResponses = (base_responses) null;
      if (resources != null && resources.Length > 0)
      {
        cachecontentgroup[] cachecontentgroupArray = new cachecontentgroup[resources.Length];
        for (int index = 0; index < resources.Length; ++index)
        {
          cachecontentgroupArray[index] = new cachecontentgroup();
          cachecontentgroupArray[index].name = resources[index].name;
        }
        baseResponses = base_resource.perform_operation_bulk_request(client, (base_resource[]) cachecontentgroupArray, nameof (expire));
      }
      return baseResponses;
    }

    public static base_response flush(nitro_service client, cachecontentgroup resource) => new cachecontentgroup()
    {
      name = resource.name,
      query = resource.query,
      host = resource.host,
      selectorvalue = resource.selectorvalue
    }.perform_operation_byaction(client, nameof (flush));

    public static base_responses flush(
      nitro_service client,
      cachecontentgroup[] resources)
    {
      base_responses baseResponses = (base_responses) null;
      if (resources != null && resources.Length > 0)
      {
        cachecontentgroup[] cachecontentgroupArray = new cachecontentgroup[resources.Length];
        for (int index = 0; index < resources.Length; ++index)
        {
          cachecontentgroupArray[index] = new cachecontentgroup();
          cachecontentgroupArray[index].name = resources[index].name;
          cachecontentgroupArray[index].query = resources[index].query;
          cachecontentgroupArray[index].host = resources[index].host;
          cachecontentgroupArray[index].selectorvalue = resources[index].selectorvalue;
        }
        baseResponses = base_resource.perform_operation_bulk_request(client, (base_resource[]) cachecontentgroupArray, nameof (flush));
      }
      return baseResponses;
    }

    public static base_response save(nitro_service client, cachecontentgroup resource) => new cachecontentgroup()
    {
      name = resource.name,
      tosecondary = resource.tosecondary
    }.perform_operation_byaction(client, nameof (save));

    public static base_responses save(
      nitro_service client,
      cachecontentgroup[] resources)
    {
      base_responses baseResponses = (base_responses) null;
      if (resources != null && resources.Length > 0)
      {
        cachecontentgroup[] cachecontentgroupArray = new cachecontentgroup[resources.Length];
        for (int index = 0; index < resources.Length; ++index)
        {
          cachecontentgroupArray[index] = new cachecontentgroup();
          cachecontentgroupArray[index].name = resources[index].name;
          cachecontentgroupArray[index].tosecondary = resources[index].tosecondary;
        }
        baseResponses = base_resource.perform_operation_bulk_request(client, (base_resource[]) cachecontentgroupArray, nameof (save));
      }
      return baseResponses;
    }

    public static cachecontentgroup[] get(nitro_service service) => (cachecontentgroup[]) new cachecontentgroup().get_resources(service, (options) null);

    public static cachecontentgroup[] get(nitro_service service, options option) => (cachecontentgroup[]) new cachecontentgroup().get_resources(service, option);

    public static cachecontentgroup get(nitro_service service, string name) => (cachecontentgroup) new cachecontentgroup()
    {
      name = name
    }.get_resource(service);

    public static cachecontentgroup[] get(nitro_service service, string[] name)
    {
      if (name == null || name.Length <= 0)
        return (cachecontentgroup[]) null;
      cachecontentgroup[] cachecontentgroupArray1 = new cachecontentgroup[name.Length];
      cachecontentgroup[] cachecontentgroupArray2 = new cachecontentgroup[name.Length];
      for (int index = 0; index < name.Length; ++index)
      {
        cachecontentgroupArray2[index] = new cachecontentgroup();
        cachecontentgroupArray2[index].name = name[index];
        cachecontentgroupArray1[index] = (cachecontentgroup) cachecontentgroupArray2[index].get_resource(service);
      }
      return cachecontentgroupArray1;
    }

    public static cachecontentgroup[] get_filtered(
      nitro_service service,
      string filter)
    {
      cachecontentgroup cachecontentgroup = new cachecontentgroup();
      options option = new options();
      option.set_filter(filter);
      return (cachecontentgroup[]) cachecontentgroup.getfiltered(service, option);
    }

    public static cachecontentgroup[] get_filtered(
      nitro_service service,
      filtervalue[] filter)
    {
      cachecontentgroup cachecontentgroup = new cachecontentgroup();
      options option = new options();
      option.set_filter(filter);
      return (cachecontentgroup[]) cachecontentgroup.getfiltered(service, option);
    }

    public static uint count(nitro_service service)
    {
      cachecontentgroup cachecontentgroup = new cachecontentgroup();
      options option = new options();
      option.set_count(true);
      cachecontentgroup[] resources = (cachecontentgroup[]) cachecontentgroup.get_resources(service, option);
      return resources != null && resources.Length > 0 ? resources[0].__count.Value : 0U;
    }

    public static uint count_filtered(nitro_service service, string filter)
    {
      cachecontentgroup cachecontentgroup = new cachecontentgroup();
      options option = new options();
      option.set_count(true);
      option.set_filter(filter);
      cachecontentgroup[] cachecontentgroupArray = (cachecontentgroup[]) cachecontentgroup.getfiltered(service, option);
      return cachecontentgroupArray != null && cachecontentgroupArray.Length > 0 ? cachecontentgroupArray[0].__count.Value : 0U;
    }

    public static uint count_filtered(nitro_service service, filtervalue[] filter)
    {
      cachecontentgroup cachecontentgroup = new cachecontentgroup();
      options option = new options();
      option.set_count(true);
      option.set_filter(filter);
      cachecontentgroup[] cachecontentgroupArray = (cachecontentgroup[]) cachecontentgroup.getfiltered(service, option);
      return cachecontentgroupArray != null && cachecontentgroupArray.Length > 0 ? cachecontentgroupArray[0].__count.Value : 0U;
    }

    private class cachecontentgroup_response : base_response
    {
      public cachecontentgroup[] cachecontentgroup = (cachecontentgroup[]) null;
    }

    public static class tosecondaryEnum
    {
      public const string YES = "YES";
      public const string NO = "NO";
    }

    public static class persisthaEnum
    {
      public const string YES = "YES";
      public const string NO = "NO";
    }

    public static class alwaysevalpoliciesEnum
    {
      public const string YES = "YES";
      public const string NO = "NO";
    }

    public static class persistEnum
    {
      public const string YES = "YES";
      public const string NO = "NO";
    }

    public static class pinnedEnum
    {
      public const string YES = "YES";
      public const string NO = "NO";
    }

    public static class ignoreparamvaluecaseEnum
    {
      public const string YES = "YES";
      public const string NO = "NO";
    }

    public static class expireatlastbyteEnum
    {
      public const string YES = "YES";
      public const string NO = "NO";
    }

    public static class removecookiesEnum
    {
      public const string YES = "YES";
      public const string NO = "NO";
    }

    public static class ignorereloadreqEnum
    {
      public const string YES = "YES";
      public const string NO = "NO";
    }

    public static class builtinEnum
    {
      public const string MODIFIABLE = "MODIFIABLE";
      public const string DELETABLE = "DELETABLE";
      public const string IMMUTABLE = "IMMUTABLE";
      public const string PARTITION_ALL = "PARTITION_ALL";
    }

    public static class flashcacheEnum
    {
      public const string YES = "YES";
      public const string NO = "NO";
    }

    public static class invalrestrictedtohostEnum
    {
      public const string YES = "YES";
      public const string NO = "NO";
    }

    public static class typeEnum
    {
      public const string HTTP = "HTTP";
      public const string MYSQL = "MYSQL";
      public const string MSSQL = "MSSQL";
    }

    public static class polleverytimeEnum
    {
      public const string YES = "YES";
      public const string NO = "NO";
    }

    public static class ignorereqcachinghdrsEnum
    {
      public const string YES = "YES";
      public const string NO = "NO";
    }

    public static class insertviaEnum
    {
      public const string YES = "YES";
      public const string NO = "NO";
    }

    public static class matchcookiesEnum
    {
      public const string YES = "YES";
      public const string NO = "NO";
    }

    public static class insertetagEnum
    {
      public const string YES = "YES";
      public const string NO = "NO";
    }

    public static class lazydnsresolveEnum
    {
      public const string YES = "YES";
      public const string NO = "NO";
    }

    public static class insertageEnum
    {
      public const string YES = "YES";
      public const string NO = "NO";
    }

    public static class prefetchEnum
    {
      public const string YES = "YES";
      public const string NO = "NO";
    }
  }
}
