// Decompiled with JetBrains decompiler
// Type: com.citrix.netscaler.nitro.resource.config.ns.nshttpprofile
// Assembly: nitro, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 6CF5DDEF-E052-4F9D-953F-6644F8378A66


using com.citrix.netscaler.nitro.exception;
using com.citrix.netscaler.nitro.resource.Base;
using com.citrix.netscaler.nitro.service;
using com.citrix.netscaler.nitro.util;

namespace com.citrix.netscaler.nitro.resource.config.ns
{
  public class nshttpprofile : base_resource
  {
    private string nameField = (string) null;
    private string dropinvalreqsField = (string) null;
    private string markhttp09invalField = (string) null;
    private string markconnreqinvalField = (string) null;
    private string cmponpushField = (string) null;
    private string conmultiplexField = (string) null;
    private uint? maxreusepoolField = new uint?();
    private string dropextracrlfField = (string) null;
    private uint? incomphdrdelayField = new uint?();
    private string websocketField = (string) null;
    private string rtsptunnelField = (string) null;
    private uint? reqtimeoutField = new uint?();
    private string adpttimeoutField = (string) null;
    private string reqtimeoutactionField = (string) null;
    private string dropextradataField = (string) null;
    private string weblogField = (string) null;
    private string clientiphdrexprField = (string) null;
    private uint? maxreqField = new uint?();
    private string persistentetagField = (string) null;
    private string spdyField = (string) null;
    private string http2Field = (string) null;
    private uint? reusepooltimeoutField = new uint?();
    private uint? maxheaderlenField = new uint?();
    private uint? minreusepoolField = new uint?();
    private uint? http2maxheaderlistsizeField = new uint?();
    private uint? http2maxframesizeField = new uint?();
    private uint? http2maxconcurrentstreamsField = new uint?();
    private uint? http2initialwindowsizeField = new uint?();
    private uint? http2headertablesizeField = new uint?();
    private uint? refcntField = new uint?();
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

    public string dropinvalreqs
    {
      get => this.dropinvalreqsField;
      set => this.dropinvalreqsField = value;
    }

    public string markhttp09inval
    {
      get => this.markhttp09invalField;
      set => this.markhttp09invalField = value;
    }

    public string markconnreqinval
    {
      get => this.markconnreqinvalField;
      set => this.markconnreqinvalField = value;
    }

    public string cmponpush
    {
      get => this.cmponpushField;
      set => this.cmponpushField = value;
    }

    public string conmultiplex
    {
      get => this.conmultiplexField;
      set => this.conmultiplexField = value;
    }

    public uint? maxreusepool
    {
      get => this.maxreusepoolField;
      set => this.maxreusepoolField = value;
    }

    public string dropextracrlf
    {
      get => this.dropextracrlfField;
      set => this.dropextracrlfField = value;
    }

    public uint? incomphdrdelay
    {
      get => this.incomphdrdelayField;
      set => this.incomphdrdelayField = value;
    }

    public string websocket
    {
      get => this.websocketField;
      set => this.websocketField = value;
    }

    public string rtsptunnel
    {
      get => this.rtsptunnelField;
      set => this.rtsptunnelField = value;
    }

    public uint? reqtimeout
    {
      get => this.reqtimeoutField;
      set => this.reqtimeoutField = value;
    }

    public string adpttimeout
    {
      get => this.adpttimeoutField;
      set => this.adpttimeoutField = value;
    }

    public string reqtimeoutaction
    {
      get => this.reqtimeoutactionField;
      set => this.reqtimeoutactionField = value;
    }

    public string dropextradata
    {
      get => this.dropextradataField;
      set => this.dropextradataField = value;
    }

    public string weblog
    {
      get => this.weblogField;
      set => this.weblogField = value;
    }

    public string clientiphdrexpr
    {
      get => this.clientiphdrexprField;
      set => this.clientiphdrexprField = value;
    }

    public uint? maxreq
    {
      get => this.maxreqField;
      set => this.maxreqField = value;
    }

    public string persistentetag
    {
      get => this.persistentetagField;
      set => this.persistentetagField = value;
    }

    public string spdy
    {
      get => this.spdyField;
      set => this.spdyField = value;
    }

    public string http2
    {
      get => this.http2Field;
      set => this.http2Field = value;
    }

    public uint? reusepooltimeout
    {
      get => this.reusepooltimeoutField;
      set => this.reusepooltimeoutField = value;
    }

    public uint? maxheaderlen
    {
      get => this.maxheaderlenField;
      set => this.maxheaderlenField = value;
    }

    public uint? minreusepool
    {
      get => this.minreusepoolField;
      set => this.minreusepoolField = value;
    }

    public uint? http2maxheaderlistsize
    {
      get => this.http2maxheaderlistsizeField;
      set => this.http2maxheaderlistsizeField = value;
    }

    public uint? http2maxframesize
    {
      get => this.http2maxframesizeField;
      set => this.http2maxframesizeField = value;
    }

    public uint? http2maxconcurrentstreams
    {
      get => this.http2maxconcurrentstreamsField;
      set => this.http2maxconcurrentstreamsField = value;
    }

    public uint? http2initialwindowsize
    {
      get => this.http2initialwindowsizeField;
      set => this.http2initialwindowsizeField = value;
    }

    public uint? http2headertablesize
    {
      get => this.http2headertablesizeField;
      set => this.http2headertablesizeField = value;
    }

    public uint? refcnt
    {
      get => this.refcntField;
      private set => this.refcntField = value;
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
      nshttpprofile.nshttpprofile_response nshttpprofileResponse = new nshttpprofile.nshttpprofile_response();
      nshttpprofile.nshttpprofile_response resource = (nshttpprofile.nshttpprofile_response) service.get_payload_formatter().string_to_resource(nshttpprofileResponse.GetType(), response);
      if (resource.errorcode != 0)
      {
        if (resource.errorcode == 444)
          service.clear_session();
        if (resource.severity == null)
          throw new nitro_exception(resource.message, resource.errorcode);
        if (resource.severity.Equals("ERROR"))
          throw new nitro_exception(resource.message, resource.errorcode);
      }
      return (base_resource[]) resource.nshttpprofile;
    }

    internal override string get_object_name() => this.name;

    public static base_response add(nitro_service client, nshttpprofile resource) => new nshttpprofile()
    {
      name = resource.name,
      dropinvalreqs = resource.dropinvalreqs,
      markhttp09inval = resource.markhttp09inval,
      markconnreqinval = resource.markconnreqinval,
      cmponpush = resource.cmponpush,
      conmultiplex = resource.conmultiplex,
      maxreusepool = resource.maxreusepool,
      dropextracrlf = resource.dropextracrlf,
      incomphdrdelay = resource.incomphdrdelay,
      websocket = resource.websocket,
      rtsptunnel = resource.rtsptunnel,
      reqtimeout = resource.reqtimeout,
      adpttimeout = resource.adpttimeout,
      reqtimeoutaction = resource.reqtimeoutaction,
      dropextradata = resource.dropextradata,
      weblog = resource.weblog,
      clientiphdrexpr = resource.clientiphdrexpr,
      maxreq = resource.maxreq,
      persistentetag = resource.persistentetag,
      spdy = resource.spdy,
      http2 = resource.http2,
      reusepooltimeout = resource.reusepooltimeout,
      maxheaderlen = resource.maxheaderlen,
      minreusepool = resource.minreusepool,
      http2maxheaderlistsize = resource.http2maxheaderlistsize,
      http2maxframesize = resource.http2maxframesize,
      http2maxconcurrentstreams = resource.http2maxconcurrentstreams,
      http2initialwindowsize = resource.http2initialwindowsize,
      http2headertablesize = resource.http2headertablesize
    }.add_resource(client);

    public static base_responses add(nitro_service client, nshttpprofile[] resources)
    {
      base_responses baseResponses = (base_responses) null;
      if (resources != null && resources.Length > 0)
      {
        nshttpprofile[] nshttpprofileArray = new nshttpprofile[resources.Length];
        for (int index = 0; index < resources.Length; ++index)
        {
          nshttpprofileArray[index] = new nshttpprofile();
          nshttpprofileArray[index].name = resources[index].name;
          nshttpprofileArray[index].dropinvalreqs = resources[index].dropinvalreqs;
          nshttpprofileArray[index].markhttp09inval = resources[index].markhttp09inval;
          nshttpprofileArray[index].markconnreqinval = resources[index].markconnreqinval;
          nshttpprofileArray[index].cmponpush = resources[index].cmponpush;
          nshttpprofileArray[index].conmultiplex = resources[index].conmultiplex;
          nshttpprofileArray[index].maxreusepool = resources[index].maxreusepool;
          nshttpprofileArray[index].dropextracrlf = resources[index].dropextracrlf;
          nshttpprofileArray[index].incomphdrdelay = resources[index].incomphdrdelay;
          nshttpprofileArray[index].websocket = resources[index].websocket;
          nshttpprofileArray[index].rtsptunnel = resources[index].rtsptunnel;
          nshttpprofileArray[index].reqtimeout = resources[index].reqtimeout;
          nshttpprofileArray[index].adpttimeout = resources[index].adpttimeout;
          nshttpprofileArray[index].reqtimeoutaction = resources[index].reqtimeoutaction;
          nshttpprofileArray[index].dropextradata = resources[index].dropextradata;
          nshttpprofileArray[index].weblog = resources[index].weblog;
          nshttpprofileArray[index].clientiphdrexpr = resources[index].clientiphdrexpr;
          nshttpprofileArray[index].maxreq = resources[index].maxreq;
          nshttpprofileArray[index].persistentetag = resources[index].persistentetag;
          nshttpprofileArray[index].spdy = resources[index].spdy;
          nshttpprofileArray[index].http2 = resources[index].http2;
          nshttpprofileArray[index].reusepooltimeout = resources[index].reusepooltimeout;
          nshttpprofileArray[index].maxheaderlen = resources[index].maxheaderlen;
          nshttpprofileArray[index].minreusepool = resources[index].minreusepool;
          nshttpprofileArray[index].http2maxheaderlistsize = resources[index].http2maxheaderlistsize;
          nshttpprofileArray[index].http2maxframesize = resources[index].http2maxframesize;
          nshttpprofileArray[index].http2maxconcurrentstreams = resources[index].http2maxconcurrentstreams;
          nshttpprofileArray[index].http2initialwindowsize = resources[index].http2initialwindowsize;
          nshttpprofileArray[index].http2headertablesize = resources[index].http2headertablesize;
        }
        baseResponses = base_resource.add_bulk_request(client, (base_resource[]) nshttpprofileArray);
      }
      return baseResponses;
    }

    public static base_response delete(nitro_service client, string name) => new nshttpprofile()
    {
      name = name
    }.delete_resource(client);

    public static base_response delete(nitro_service client, nshttpprofile resource) => new nshttpprofile()
    {
      name = resource.name
    }.delete_resource(client);

    public static base_responses delete(nitro_service client, string[] name)
    {
      base_responses baseResponses = (base_responses) null;
      if (name != null && name.Length > 0)
      {
        nshttpprofile[] nshttpprofileArray = new nshttpprofile[name.Length];
        for (int index = 0; index < name.Length; ++index)
        {
          nshttpprofileArray[index] = new nshttpprofile();
          nshttpprofileArray[index].name = name[index];
        }
        baseResponses = base_resource.delete_bulk_request(client, (base_resource[]) nshttpprofileArray);
      }
      return baseResponses;
    }

    public static base_responses delete(
      nitro_service client,
      nshttpprofile[] resources)
    {
      base_responses baseResponses = (base_responses) null;
      if (resources != null && resources.Length > 0)
      {
        nshttpprofile[] nshttpprofileArray = new nshttpprofile[resources.Length];
        for (int index = 0; index < resources.Length; ++index)
        {
          nshttpprofileArray[index] = new nshttpprofile();
          nshttpprofileArray[index].name = resources[index].name;
        }
        baseResponses = base_resource.delete_bulk_request(client, (base_resource[]) nshttpprofileArray);
      }
      return baseResponses;
    }

    public static base_response update(nitro_service client, nshttpprofile resource) => new nshttpprofile()
    {
      name = resource.name,
      dropinvalreqs = resource.dropinvalreqs,
      markhttp09inval = resource.markhttp09inval,
      markconnreqinval = resource.markconnreqinval,
      cmponpush = resource.cmponpush,
      conmultiplex = resource.conmultiplex,
      maxreusepool = resource.maxreusepool,
      dropextracrlf = resource.dropextracrlf,
      incomphdrdelay = resource.incomphdrdelay,
      websocket = resource.websocket,
      rtsptunnel = resource.rtsptunnel,
      reqtimeout = resource.reqtimeout,
      adpttimeout = resource.adpttimeout,
      reqtimeoutaction = resource.reqtimeoutaction,
      dropextradata = resource.dropextradata,
      weblog = resource.weblog,
      clientiphdrexpr = resource.clientiphdrexpr,
      maxreq = resource.maxreq,
      persistentetag = resource.persistentetag,
      spdy = resource.spdy,
      http2 = resource.http2,
      http2maxheaderlistsize = resource.http2maxheaderlistsize,
      http2maxframesize = resource.http2maxframesize,
      http2maxconcurrentstreams = resource.http2maxconcurrentstreams,
      http2initialwindowsize = resource.http2initialwindowsize,
      http2headertablesize = resource.http2headertablesize,
      reusepooltimeout = resource.reusepooltimeout,
      maxheaderlen = resource.maxheaderlen,
      minreusepool = resource.minreusepool
    }.update_resource(client);

    public static base_responses update(
      nitro_service client,
      nshttpprofile[] resources)
    {
      base_responses baseResponses = (base_responses) null;
      if (resources != null && resources.Length > 0)
      {
        nshttpprofile[] nshttpprofileArray = new nshttpprofile[resources.Length];
        for (int index = 0; index < resources.Length; ++index)
        {
          nshttpprofileArray[index] = new nshttpprofile();
          nshttpprofileArray[index].name = resources[index].name;
          nshttpprofileArray[index].dropinvalreqs = resources[index].dropinvalreqs;
          nshttpprofileArray[index].markhttp09inval = resources[index].markhttp09inval;
          nshttpprofileArray[index].markconnreqinval = resources[index].markconnreqinval;
          nshttpprofileArray[index].cmponpush = resources[index].cmponpush;
          nshttpprofileArray[index].conmultiplex = resources[index].conmultiplex;
          nshttpprofileArray[index].maxreusepool = resources[index].maxreusepool;
          nshttpprofileArray[index].dropextracrlf = resources[index].dropextracrlf;
          nshttpprofileArray[index].incomphdrdelay = resources[index].incomphdrdelay;
          nshttpprofileArray[index].websocket = resources[index].websocket;
          nshttpprofileArray[index].rtsptunnel = resources[index].rtsptunnel;
          nshttpprofileArray[index].reqtimeout = resources[index].reqtimeout;
          nshttpprofileArray[index].adpttimeout = resources[index].adpttimeout;
          nshttpprofileArray[index].reqtimeoutaction = resources[index].reqtimeoutaction;
          nshttpprofileArray[index].dropextradata = resources[index].dropextradata;
          nshttpprofileArray[index].weblog = resources[index].weblog;
          nshttpprofileArray[index].clientiphdrexpr = resources[index].clientiphdrexpr;
          nshttpprofileArray[index].maxreq = resources[index].maxreq;
          nshttpprofileArray[index].persistentetag = resources[index].persistentetag;
          nshttpprofileArray[index].spdy = resources[index].spdy;
          nshttpprofileArray[index].http2 = resources[index].http2;
          nshttpprofileArray[index].http2maxheaderlistsize = resources[index].http2maxheaderlistsize;
          nshttpprofileArray[index].http2maxframesize = resources[index].http2maxframesize;
          nshttpprofileArray[index].http2maxconcurrentstreams = resources[index].http2maxconcurrentstreams;
          nshttpprofileArray[index].http2initialwindowsize = resources[index].http2initialwindowsize;
          nshttpprofileArray[index].http2headertablesize = resources[index].http2headertablesize;
          nshttpprofileArray[index].reusepooltimeout = resources[index].reusepooltimeout;
          nshttpprofileArray[index].maxheaderlen = resources[index].maxheaderlen;
          nshttpprofileArray[index].minreusepool = resources[index].minreusepool;
        }
        baseResponses = base_resource.update_bulk_request(client, (base_resource[]) nshttpprofileArray);
      }
      return baseResponses;
    }

    public static base_response unset(
      nitro_service client,
      string name,
      string[] args)
    {
      return new nshttpprofile() { name = name }.unset_resource(client, args);
    }

    public static base_response unset(
      nitro_service client,
      nshttpprofile resource,
      string[] args)
    {
      return new nshttpprofile() { name = resource.name }.unset_resource(client, args);
    }

    public static base_responses unset(
      nitro_service client,
      string[] name,
      string[] args)
    {
      base_responses baseResponses = (base_responses) null;
      if (name != null && name.Length > 0)
      {
        nshttpprofile[] nshttpprofileArray = new nshttpprofile[name.Length];
        for (int index = 0; index < name.Length; ++index)
        {
          nshttpprofileArray[index] = new nshttpprofile();
          nshttpprofileArray[index].name = name[index];
        }
        baseResponses = base_resource.unset_bulk_request(client, (base_resource[]) nshttpprofileArray, args);
      }
      return baseResponses;
    }

    public static base_responses unset(
      nitro_service client,
      nshttpprofile[] resources,
      string[] args)
    {
      base_responses baseResponses = (base_responses) null;
      if (resources != null && resources.Length > 0)
      {
        nshttpprofile[] nshttpprofileArray = new nshttpprofile[resources.Length];
        for (int index = 0; index < resources.Length; ++index)
        {
          nshttpprofileArray[index] = new nshttpprofile();
          nshttpprofileArray[index].name = resources[index].name;
        }
        baseResponses = base_resource.unset_bulk_request(client, (base_resource[]) nshttpprofileArray, args);
      }
      return baseResponses;
    }

    public static nshttpprofile[] get(nitro_service service) => (nshttpprofile[]) new nshttpprofile().get_resources(service, (options) null);

    public static nshttpprofile[] get(nitro_service service, options option) => (nshttpprofile[]) new nshttpprofile().get_resources(service, option);

    public static nshttpprofile get(nitro_service service, string name) => (nshttpprofile) new nshttpprofile()
    {
      name = name
    }.get_resource(service);

    public static nshttpprofile[] get(nitro_service service, string[] name)
    {
      if (name == null || name.Length <= 0)
        return (nshttpprofile[]) null;
      nshttpprofile[] nshttpprofileArray1 = new nshttpprofile[name.Length];
      nshttpprofile[] nshttpprofileArray2 = new nshttpprofile[name.Length];
      for (int index = 0; index < name.Length; ++index)
      {
        nshttpprofileArray2[index] = new nshttpprofile();
        nshttpprofileArray2[index].name = name[index];
        nshttpprofileArray1[index] = (nshttpprofile) nshttpprofileArray2[index].get_resource(service);
      }
      return nshttpprofileArray1;
    }

    public static nshttpprofile[] get_filtered(nitro_service service, string filter)
    {
      nshttpprofile nshttpprofile = new nshttpprofile();
      options option = new options();
      option.set_filter(filter);
      return (nshttpprofile[]) nshttpprofile.getfiltered(service, option);
    }

    public static nshttpprofile[] get_filtered(
      nitro_service service,
      filtervalue[] filter)
    {
      nshttpprofile nshttpprofile = new nshttpprofile();
      options option = new options();
      option.set_filter(filter);
      return (nshttpprofile[]) nshttpprofile.getfiltered(service, option);
    }

    public static uint count(nitro_service service)
    {
      nshttpprofile nshttpprofile = new nshttpprofile();
      options option = new options();
      option.set_count(true);
      nshttpprofile[] resources = (nshttpprofile[]) nshttpprofile.get_resources(service, option);
      return resources != null && resources.Length > 0 ? resources[0].__count.Value : 0U;
    }

    public static uint count_filtered(nitro_service service, string filter)
    {
      nshttpprofile nshttpprofile = new nshttpprofile();
      options option = new options();
      option.set_count(true);
      option.set_filter(filter);
      nshttpprofile[] nshttpprofileArray = (nshttpprofile[]) nshttpprofile.getfiltered(service, option);
      return nshttpprofileArray != null && nshttpprofileArray.Length > 0 ? nshttpprofileArray[0].__count.Value : 0U;
    }

    public static uint count_filtered(nitro_service service, filtervalue[] filter)
    {
      nshttpprofile nshttpprofile = new nshttpprofile();
      options option = new options();
      option.set_count(true);
      option.set_filter(filter);
      nshttpprofile[] nshttpprofileArray = (nshttpprofile[]) nshttpprofile.getfiltered(service, option);
      return nshttpprofileArray != null && nshttpprofileArray.Length > 0 ? nshttpprofileArray[0].__count.Value : 0U;
    }

    private class nshttpprofile_response : base_response
    {
      public nshttpprofile[] nshttpprofile = (nshttpprofile[]) null;
    }

    public static class conmultiplexEnum
    {
      public const string ENABLED = "ENABLED";
      public const string DISABLED = "DISABLED";
    }

    public static class markhttp09invalEnum
    {
      public const string ENABLED = "ENABLED";
      public const string DISABLED = "DISABLED";
    }

    public static class adpttimeoutEnum
    {
      public const string ENABLED = "ENABLED";
      public const string DISABLED = "DISABLED";
    }

    public static class builtinEnum
    {
      public const string MODIFIABLE = "MODIFIABLE";
      public const string DELETABLE = "DELETABLE";
      public const string IMMUTABLE = "IMMUTABLE";
      public const string PARTITION_ALL = "PARTITION_ALL";
    }

    public static class markconnreqinvalEnum
    {
      public const string ENABLED = "ENABLED";
      public const string DISABLED = "DISABLED";
    }

    public static class spdyEnum
    {
      public const string DISABLED = "DISABLED";
      public const string ENABLED = "ENABLED";
      public const string V2 = "V2";
      public const string V3 = "V3";
    }

    public static class persistentetagEnum
    {
      public const string ENABLED = "ENABLED";
      public const string DISABLED = "DISABLED";
    }

    public static class rtsptunnelEnum
    {
      public const string ENABLED = "ENABLED";
      public const string DISABLED = "DISABLED";
    }

    public static class dropinvalreqsEnum
    {
      public const string ENABLED = "ENABLED";
      public const string DISABLED = "DISABLED";
    }

    public static class dropextracrlfEnum
    {
      public const string ENABLED = "ENABLED";
      public const string DISABLED = "DISABLED";
    }

    public static class http2Enum
    {
      public const string ENABLED = "ENABLED";
      public const string DISABLED = "DISABLED";
    }

    public static class dropextradataEnum
    {
      public const string ENABLED = "ENABLED";
      public const string DISABLED = "DISABLED";
    }

    public static class websocketEnum
    {
      public const string ENABLED = "ENABLED";
      public const string DISABLED = "DISABLED";
    }

    public static class cmponpushEnum
    {
      public const string ENABLED = "ENABLED";
      public const string DISABLED = "DISABLED";
    }

    public static class weblogEnum
    {
      public const string ENABLED = "ENABLED";
      public const string DISABLED = "DISABLED";
    }
  }
}
