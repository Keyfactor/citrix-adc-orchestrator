// Decompiled with JetBrains decompiler
// Type: com.citrix.netscaler.nitro.resource.config.cache.cacheobject
// Assembly: nitro, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 6CF5DDEF-E052-4F9D-953F-6644F8378A66


using com.citrix.netscaler.nitro.exception;
using com.citrix.netscaler.nitro.resource.Base;
using com.citrix.netscaler.nitro.service;
using com.citrix.netscaler.nitro.util;

namespace com.citrix.netscaler.nitro.resource.config.cache
{
  public class cacheobject : base_resource
  {
    private string urlField = (string) null;
    private long? locatorField = new long?();
    private uint? httpstatusField = new uint?();
    private string hostField = (string) null;
    private ushort? portField = new ushort?();
    private string groupnameField = (string) null;
    private string httpmethodField = (string) null;
    private string groupField = (string) null;
    private string ignoremarkerobjectsField = (string) null;
    private string includenotreadyobjectsField = (string) null;
    private string tosecondaryField = (string) null;
    private uint? cacheressizeField = new uint?();
    private uint? cachereshdrsizeField = new uint?();
    private string cacheetagField = (string) null;
    private uint? httpstatusoutputField = new uint?();
    private string cachereslastmodField = (string) null;
    private string cachecontrolField = (string) null;
    private string cacheresdateField = (string) null;
    private string contentgroupField = (string) null;
    private string destipv46Field = (string) null;
    private ushort? destportField = new ushort?();
    private string cachecellcomplexField = (string) null;
    private string[] hitparamsField = (string[]) null;
    private string[] hitvaluesField = (string[]) null;
    private long? cachecellreqtimeField = new long?();
    private long? cachecellrestimeField = new long?();
    private long? cachecurageField = new long?();
    private long? cachecellexpiresField = new long?();
    private long? cachecellexpiresmillisecField = new long?();
    private string flushedField = (string) null;
    private string prefetchField = (string) null;
    private long? prefetchperiodField = new long?();
    private long? prefetchperiodmillisecField = new long?();
    private uint? cachecellcurreadersField = new uint?();
    private uint? cachecellcurmissesField = new uint?();
    private uint? cachecellhitsField = new uint?();
    private uint? cachecellmissesField = new uint?();
    private uint? cachecelldhitsField = new uint?();
    private string cachecellcompressionformatField = (string) null;
    private string cachecellappfwmetadataexistsField = (string) null;
    private string cachecellhttp11Field = (string) null;
    private string cachecellweaketagField = (string) null;
    private string cachecellresbadsizeField = (string) null;
    private string markerreasonField = (string) null;
    private string cachecellpolleverytimeField = (string) null;
    private string cachecelletaginsertedField = (string) null;
    private string cachecellreadywithlastbyteField = (string) null;
    private string cacheinmemoryField = (string) null;
    private string cacheindiskField = (string) null;
    private string cacheinsecondaryField = (string) null;
    private string cachedirnameField = (string) null;
    private string cachefilenameField = (string) null;
    private string cachecelldestipverifiedField = (string) null;
    private string cachecellfwpxyobjField = (string) null;
    private string cachecellbasefileField = (string) null;
    private string cachecellminhitflagField = (string) null;
    private int? cachecellminhitField = new int?();
    private int? policyField = new int?();
    private string policynameField = (string) null;
    private string[] selectornameField = (string[]) null;
    private string[] ruleField = (string[]) null;
    private string[] selectorvalueField = (string[]) null;
    private string cacheurlsField = (string) null;
    private uint? warnbucketskipField = new uint?();
    private uint? totalobjsField = new uint?();
    private string httpcalloutcellField = (string) null;
    private string httpcalloutnameField = (string) null;
    private string returntypeField = (string) null;
    private string httpcalloutresultField = (string) null;
    private long? locatorshowField = new long?();
    private uint? ceflagsField = new uint?();
    private uint? __countField = new uint?();

    public uint? __count
    {
      get => this.__countField;
      private set => this.__countField = value;
    }

    public string url
    {
      get => this.urlField;
      set => this.urlField = value;
    }

    public long? locator
    {
      get => this.locatorField;
      set => this.locatorField = value;
    }

    public uint? httpstatus
    {
      get => this.httpstatusField;
      set => this.httpstatusField = value;
    }

    public string host
    {
      get => this.hostField;
      set => this.hostField = value;
    }

    public ushort? port
    {
      get => this.portField;
      set => this.portField = value;
    }

    public string groupname
    {
      get => this.groupnameField;
      set => this.groupnameField = value;
    }

    public string httpmethod
    {
      get => this.httpmethodField;
      set => this.httpmethodField = value;
    }

    public string group
    {
      get => this.groupField;
      set => this.groupField = value;
    }

    public string ignoremarkerobjects
    {
      get => this.ignoremarkerobjectsField;
      set => this.ignoremarkerobjectsField = value;
    }

    public string includenotreadyobjects
    {
      get => this.includenotreadyobjectsField;
      set => this.includenotreadyobjectsField = value;
    }

    public string tosecondary
    {
      get => this.tosecondaryField;
      set => this.tosecondaryField = value;
    }

    public uint? cacheressize
    {
      get => this.cacheressizeField;
      private set => this.cacheressizeField = value;
    }

    public uint? cachereshdrsize
    {
      get => this.cachereshdrsizeField;
      private set => this.cachereshdrsizeField = value;
    }

    public string cacheetag
    {
      get => this.cacheetagField;
      private set => this.cacheetagField = value;
    }

    public uint? httpstatusoutput
    {
      get => this.httpstatusoutputField;
      private set => this.httpstatusoutputField = value;
    }

    public string cachereslastmod
    {
      get => this.cachereslastmodField;
      private set => this.cachereslastmodField = value;
    }

    public string cachecontrol
    {
      get => this.cachecontrolField;
      private set => this.cachecontrolField = value;
    }

    public string cacheresdate
    {
      get => this.cacheresdateField;
      private set => this.cacheresdateField = value;
    }

    public string contentgroup
    {
      get => this.contentgroupField;
      private set => this.contentgroupField = value;
    }

    public string destipv46
    {
      get => this.destipv46Field;
      private set => this.destipv46Field = value;
    }

    public ushort? destport
    {
      get => this.destportField;
      private set => this.destportField = value;
    }

    public string cachecellcomplex
    {
      get => this.cachecellcomplexField;
      private set => this.cachecellcomplexField = value;
    }

    public string[] hitparams
    {
      get => this.hitparamsField;
      private set => this.hitparamsField = value;
    }

    public string[] hitvalues
    {
      get => this.hitvaluesField;
      private set => this.hitvaluesField = value;
    }

    public long? cachecellreqtime
    {
      get => this.cachecellreqtimeField;
      private set => this.cachecellreqtimeField = value;
    }

    public long? cachecellrestime
    {
      get => this.cachecellrestimeField;
      private set => this.cachecellrestimeField = value;
    }

    public long? cachecurage
    {
      get => this.cachecurageField;
      private set => this.cachecurageField = value;
    }

    public long? cachecellexpires
    {
      get => this.cachecellexpiresField;
      private set => this.cachecellexpiresField = value;
    }

    public long? cachecellexpiresmillisec
    {
      get => this.cachecellexpiresmillisecField;
      private set => this.cachecellexpiresmillisecField = value;
    }

    public string flushed
    {
      get => this.flushedField;
      private set => this.flushedField = value;
    }

    public string prefetch
    {
      get => this.prefetchField;
      private set => this.prefetchField = value;
    }

    public long? prefetchperiod
    {
      get => this.prefetchperiodField;
      private set => this.prefetchperiodField = value;
    }

    public long? prefetchperiodmillisec
    {
      get => this.prefetchperiodmillisecField;
      private set => this.prefetchperiodmillisecField = value;
    }

    public uint? cachecellcurreaders
    {
      get => this.cachecellcurreadersField;
      private set => this.cachecellcurreadersField = value;
    }

    public uint? cachecellcurmisses
    {
      get => this.cachecellcurmissesField;
      private set => this.cachecellcurmissesField = value;
    }

    public uint? cachecellhits
    {
      get => this.cachecellhitsField;
      private set => this.cachecellhitsField = value;
    }

    public uint? cachecellmisses
    {
      get => this.cachecellmissesField;
      private set => this.cachecellmissesField = value;
    }

    public uint? cachecelldhits
    {
      get => this.cachecelldhitsField;
      private set => this.cachecelldhitsField = value;
    }

    public string cachecellcompressionformat
    {
      get => this.cachecellcompressionformatField;
      private set => this.cachecellcompressionformatField = value;
    }

    public string cachecellappfwmetadataexists
    {
      get => this.cachecellappfwmetadataexistsField;
      private set => this.cachecellappfwmetadataexistsField = value;
    }

    public string cachecellhttp11
    {
      get => this.cachecellhttp11Field;
      private set => this.cachecellhttp11Field = value;
    }

    public string cachecellweaketag
    {
      get => this.cachecellweaketagField;
      private set => this.cachecellweaketagField = value;
    }

    public string cachecellresbadsize
    {
      get => this.cachecellresbadsizeField;
      private set => this.cachecellresbadsizeField = value;
    }

    public string markerreason
    {
      get => this.markerreasonField;
      private set => this.markerreasonField = value;
    }

    public string cachecellpolleverytime
    {
      get => this.cachecellpolleverytimeField;
      private set => this.cachecellpolleverytimeField = value;
    }

    public string cachecelletaginserted
    {
      get => this.cachecelletaginsertedField;
      private set => this.cachecelletaginsertedField = value;
    }

    public string cachecellreadywithlastbyte
    {
      get => this.cachecellreadywithlastbyteField;
      private set => this.cachecellreadywithlastbyteField = value;
    }

    public string cacheinmemory
    {
      get => this.cacheinmemoryField;
      private set => this.cacheinmemoryField = value;
    }

    public string cacheindisk
    {
      get => this.cacheindiskField;
      private set => this.cacheindiskField = value;
    }

    public string cacheinsecondary
    {
      get => this.cacheinsecondaryField;
      private set => this.cacheinsecondaryField = value;
    }

    public string cachedirname
    {
      get => this.cachedirnameField;
      private set => this.cachedirnameField = value;
    }

    public string cachefilename
    {
      get => this.cachefilenameField;
      private set => this.cachefilenameField = value;
    }

    public string cachecelldestipverified
    {
      get => this.cachecelldestipverifiedField;
      private set => this.cachecelldestipverifiedField = value;
    }

    public string cachecellfwpxyobj
    {
      get => this.cachecellfwpxyobjField;
      private set => this.cachecellfwpxyobjField = value;
    }

    public string cachecellbasefile
    {
      get => this.cachecellbasefileField;
      private set => this.cachecellbasefileField = value;
    }

    public string cachecellminhitflag
    {
      get => this.cachecellminhitflagField;
      private set => this.cachecellminhitflagField = value;
    }

    public int? cachecellminhit
    {
      get => this.cachecellminhitField;
      private set => this.cachecellminhitField = value;
    }

    public int? policy
    {
      get => this.policyField;
      private set => this.policyField = value;
    }

    public string policyname
    {
      get => this.policynameField;
      private set => this.policynameField = value;
    }

    public string[] selectorname
    {
      get => this.selectornameField;
      private set => this.selectornameField = value;
    }

    public string[] rule
    {
      get => this.ruleField;
      private set => this.ruleField = value;
    }

    public string[] selectorvalue
    {
      get => this.selectorvalueField;
      private set => this.selectorvalueField = value;
    }

    public string cacheurls
    {
      get => this.cacheurlsField;
      private set => this.cacheurlsField = value;
    }

    public uint? warnbucketskip
    {
      get => this.warnbucketskipField;
      private set => this.warnbucketskipField = value;
    }

    public uint? totalobjs
    {
      get => this.totalobjsField;
      private set => this.totalobjsField = value;
    }

    public string httpcalloutcell
    {
      get => this.httpcalloutcellField;
      private set => this.httpcalloutcellField = value;
    }

    public string httpcalloutname
    {
      get => this.httpcalloutnameField;
      private set => this.httpcalloutnameField = value;
    }

    public string returntype
    {
      get => this.returntypeField;
      private set => this.returntypeField = value;
    }

    public string httpcalloutresult
    {
      get => this.httpcalloutresultField;
      private set => this.httpcalloutresultField = value;
    }

    public long? locatorshow
    {
      get => this.locatorshowField;
      private set => this.locatorshowField = value;
    }

    public uint? ceflags
    {
      get => this.ceflagsField;
      private set => this.ceflagsField = value;
    }

    internal override base_resource[] get_nitro_response(
      nitro_service service,
      string response)
    {
      cacheobject.cacheobject_response cacheobjectResponse = new cacheobject.cacheobject_response();
      cacheobject.cacheobject_response resource = (cacheobject.cacheobject_response) service.get_payload_formatter().string_to_resource(cacheobjectResponse.GetType(), response);
      if (resource.errorcode != 0)
      {
        if (resource.errorcode == 444)
          service.clear_session();
        if (resource.severity == null)
          throw new nitro_exception(resource.message, resource.errorcode);
        if (resource.severity.Equals("ERROR"))
          throw new nitro_exception(resource.message, resource.errorcode);
      }
      return (base_resource[]) resource.cacheobject;
    }

    internal override string get_object_name() => (string) null;

    public static base_response expire(nitro_service client, cacheobject resource) => new cacheobject()
    {
      locator = resource.locator,
      url = resource.url,
      host = resource.host,
      port = resource.port,
      groupname = resource.groupname,
      httpmethod = resource.httpmethod
    }.perform_operation_byaction(client, nameof (expire));

    public static base_responses expire(nitro_service client, cacheobject[] resources)
    {
      base_responses baseResponses = (base_responses) null;
      if (resources != null && resources.Length > 0)
      {
        cacheobject[] cacheobjectArray = new cacheobject[resources.Length];
        for (int index = 0; index < resources.Length; ++index)
        {
          cacheobjectArray[index] = new cacheobject();
          cacheobjectArray[index].locator = resources[index].locator;
          cacheobjectArray[index].url = resources[index].url;
          cacheobjectArray[index].host = resources[index].host;
          cacheobjectArray[index].port = resources[index].port;
          cacheobjectArray[index].groupname = resources[index].groupname;
          cacheobjectArray[index].httpmethod = resources[index].httpmethod;
        }
        baseResponses = base_resource.perform_operation_bulk_request(client, (base_resource[]) cacheobjectArray, nameof (expire));
      }
      return baseResponses;
    }

    public static base_response flush(nitro_service client, cacheobject resource) => new cacheobject()
    {
      locator = resource.locator,
      url = resource.url,
      host = resource.host,
      port = resource.port,
      groupname = resource.groupname,
      httpmethod = resource.httpmethod
    }.perform_operation_byaction(client, nameof (flush));

    public static base_responses flush(nitro_service client, cacheobject[] resources)
    {
      base_responses baseResponses = (base_responses) null;
      if (resources != null && resources.Length > 0)
      {
        cacheobject[] cacheobjectArray = new cacheobject[resources.Length];
        for (int index = 0; index < resources.Length; ++index)
        {
          cacheobjectArray[index] = new cacheobject();
          cacheobjectArray[index].locator = resources[index].locator;
          cacheobjectArray[index].url = resources[index].url;
          cacheobjectArray[index].host = resources[index].host;
          cacheobjectArray[index].port = resources[index].port;
          cacheobjectArray[index].groupname = resources[index].groupname;
          cacheobjectArray[index].httpmethod = resources[index].httpmethod;
        }
        baseResponses = base_resource.perform_operation_bulk_request(client, (base_resource[]) cacheobjectArray, nameof (flush));
      }
      return baseResponses;
    }

    public static base_response save(nitro_service client, cacheobject resource) => new cacheobject()
    {
      locator = resource.locator,
      tosecondary = resource.tosecondary
    }.perform_operation_byaction(client, nameof (save));

    public static base_responses save(nitro_service client, cacheobject[] resources)
    {
      base_responses baseResponses = (base_responses) null;
      if (resources != null && resources.Length > 0)
      {
        cacheobject[] cacheobjectArray = new cacheobject[resources.Length];
        for (int index = 0; index < resources.Length; ++index)
        {
          cacheobjectArray[index] = new cacheobject();
          cacheobjectArray[index].locator = resources[index].locator;
          cacheobjectArray[index].tosecondary = resources[index].tosecondary;
        }
        baseResponses = base_resource.perform_operation_bulk_request(client, (base_resource[]) cacheobjectArray, nameof (save));
      }
      return baseResponses;
    }

    public static cacheobject[] get(nitro_service service) => (cacheobject[]) new cacheobject().get_resources(service, (options) null);

    public static cacheobject[] get(nitro_service service, options option) => (cacheobject[]) new cacheobject().get_resources(service, option);

    public static cacheobject[] get(nitro_service service, cacheobject_args args)
    {
      cacheobject cacheobject = new cacheobject();
      options option = new options();
      option.set_args(nitro_util.object_to_string_withoutquotes((object) args));
      return (cacheobject[]) cacheobject.get_resources(service, option);
    }

    public static cacheobject[] get_filtered(nitro_service service, string filter)
    {
      cacheobject cacheobject = new cacheobject();
      options option = new options();
      option.set_filter(filter);
      return (cacheobject[]) cacheobject.getfiltered(service, option);
    }

    public static cacheobject[] get_filtered(nitro_service service, filtervalue[] filter)
    {
      cacheobject cacheobject = new cacheobject();
      options option = new options();
      option.set_filter(filter);
      return (cacheobject[]) cacheobject.getfiltered(service, option);
    }

    public static uint count(nitro_service service)
    {
      cacheobject cacheobject = new cacheobject();
      options option = new options();
      option.set_count(true);
      cacheobject[] resources = (cacheobject[]) cacheobject.get_resources(service, option);
      return resources != null && resources.Length > 0 ? resources[0].__count.Value : 0U;
    }

    public static uint count_filtered(nitro_service service, string filter)
    {
      cacheobject cacheobject = new cacheobject();
      options option = new options();
      option.set_count(true);
      option.set_filter(filter);
      cacheobject[] cacheobjectArray = (cacheobject[]) cacheobject.getfiltered(service, option);
      return cacheobjectArray != null && cacheobjectArray.Length > 0 ? cacheobjectArray[0].__count.Value : 0U;
    }

    public static uint count_filtered(nitro_service service, filtervalue[] filter)
    {
      cacheobject cacheobject = new cacheobject();
      options option = new options();
      option.set_count(true);
      option.set_filter(filter);
      cacheobject[] cacheobjectArray = (cacheobject[]) cacheobject.getfiltered(service, option);
      return cacheobjectArray != null && cacheobjectArray.Length > 0 ? cacheobjectArray[0].__count.Value : 0U;
    }

    private class cacheobject_response : base_response
    {
      public cacheobject[] cacheobject = (cacheobject[]) null;
    }

    public static class cachecellfwpxyobjEnum
    {
      public const string YES = "YES";
      public const string NO = "NO";
    }

    public static class tosecondaryEnum
    {
      public const string YES = "YES";
      public const string NO = "NO";
    }

    public static class cachecellbasefileEnum
    {
      public const string YES = "YES";
      public const string NO = "NO";
    }

    public static class cachecellcomplexEnum
    {
      public const string YES = "YES";
      public const string NO = "NO";
    }

    public static class cachecellweaketagEnum
    {
      public const string YES = "YES";
      public const string NO = "NO";
    }

    public static class ignoremarkerobjectsEnum
    {
      public const string ON = "ON";
      public const string OFF = "OFF";
    }

    public static class cachecellreadywithlastbyteEnum
    {
      public const string YES = "YES";
      public const string NO = "NO";
    }

    public static class flushedEnum
    {
      public const string YES = "YES";
      public const string NO = "NO";
    }

    public static class cachecelldestipverifiedEnum
    {
      public const string YES = "YES";
      public const string NO = "NO";
    }

    public static class cachecellhttp11Enum
    {
      public const string YES = "YES";
      public const string NO = "NO";
    }

    public static class includenotreadyobjectsEnum
    {
      public const string ON = "ON";
      public const string OFF = "OFF";
    }

    public static class cachecellminhitflagEnum
    {
      public const string YES = "YES";
      public const string NO = "NO";
    }

    public static class cacheindiskEnum
    {
      public const string YES = "YES";
      public const string NO = "NO";
    }

    public static class markerreasonEnum
    {
      public const string Waiting_for_min_hit = "Waiting for min hit";
      public const string Response_header_is_too_big = "Response header is too big";
      public const string Content_length_header_said_response_size_is_not_in_group_size_limit = "Content-length header said response size is not in group size limit";
      public const string Content_length_response_received_more_data = "Content-length response received more data";
      public const string Content_length_response_received_less_data = "Content-length response received less data";
      public const string Content_length_response_data_is_not_in_group_size_limit = "Content-length response data is not in group size limit";
      public const string Chunk_response_received_more_data = "Chunk response received more data";
      public const string Chunk_response_data_is_not_in_group_size_limit = "Chunk response data is not in group size limit";
      public const string Bad_chunk_format = "Bad chunk format";
      public const string Fin_terminated_response_data_is_not_in_group_size_limit = "Fin terminated response data is not in group size limit";
    }

    public static class cachecellpolleverytimeEnum
    {
      public const string YES = "YES";
      public const string NO = "NO";
    }

    public static class httpmethodEnum
    {
      public const string GET = "GET";
      public const string POST = "POST";
    }

    public static class returntypeEnum
    {
      public const string BOOL = "BOOL";
      public const string NUM = "NUM";
      public const string TEXT = "TEXT";
    }

    public static class httpcalloutcellEnum
    {
      public const string YES = "YES";
      public const string NO = "NO";
    }

    public static class cachecelletaginsertedEnum
    {
      public const string YES = "YES";
      public const string NO = "NO";
    }

    public static class cacheinmemoryEnum
    {
      public const string YES = "YES";
      public const string NO = "NO";
    }

    public static class cachecellappfwmetadataexistsEnum
    {
      public const string YES = "YES";
      public const string NO = "NO";
    }

    public static class cachecellresbadsizeEnum
    {
      public const string YES = "YES";
      public const string NO = "NO";
    }

    public static class prefetchEnum
    {
      public const string YES = "YES";
      public const string NO = "NO";
    }

    public static class cacheinsecondaryEnum
    {
      public const string YES = "YES";
      public const string NO = "NO";
    }
  }
}
