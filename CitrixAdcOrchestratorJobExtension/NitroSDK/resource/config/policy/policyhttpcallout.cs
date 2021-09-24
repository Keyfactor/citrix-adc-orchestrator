// Decompiled with JetBrains decompiler
// Type: com.citrix.netscaler.nitro.resource.config.policy.policyhttpcallout
// Assembly: nitro, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 6CF5DDEF-E052-4F9D-953F-6644F8378A66


using com.citrix.netscaler.nitro.exception;
using com.citrix.netscaler.nitro.resource.Base;
using com.citrix.netscaler.nitro.service;
using com.citrix.netscaler.nitro.util;

namespace com.citrix.netscaler.nitro.resource.config.policy
{
  public class policyhttpcallout : base_resource
  {
    private string nameField = (string) null;
    private string ipaddressField = (string) null;
    private ushort? portField = new ushort?();
    private string vserverField = (string) null;
    private string returntypeField = (string) null;
    private string httpmethodField = (string) null;
    private string hostexprField = (string) null;
    private string urlstemexprField = (string) null;
    private string[] headersField = (string[]) null;
    private string[] parametersField = (string[]) null;
    private string bodyexprField = (string) null;
    private string fullreqexprField = (string) null;
    private string schemeField = (string) null;
    private string resultexprField = (string) null;
    private long? cacheforsecsField = new long?();
    private string commentField = (string) null;
    private long? hitsField = new long?();
    private long? undefhitsField = new long?();
    private string svrstateField = (string) null;
    private string effectivestateField = (string) null;
    private string undefreasonField = (string) null;
    private long? recursivecalloutField = new long?();
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

    public string ipaddress
    {
      get => this.ipaddressField;
      set => this.ipaddressField = value;
    }

    public ushort? port
    {
      get => this.portField;
      set => this.portField = value;
    }

    public string vserver
    {
      get => this.vserverField;
      set => this.vserverField = value;
    }

    public string returntype
    {
      get => this.returntypeField;
      set => this.returntypeField = value;
    }

    public string httpmethod
    {
      get => this.httpmethodField;
      set => this.httpmethodField = value;
    }

    public string hostexpr
    {
      get => this.hostexprField;
      set => this.hostexprField = value;
    }

    public string urlstemexpr
    {
      get => this.urlstemexprField;
      set => this.urlstemexprField = value;
    }

    public string[] headers
    {
      get => this.headersField;
      set => this.headersField = value;
    }

    public string[] parameters
    {
      get => this.parametersField;
      set => this.parametersField = value;
    }

    public string bodyexpr
    {
      get => this.bodyexprField;
      set => this.bodyexprField = value;
    }

    public string fullreqexpr
    {
      get => this.fullreqexprField;
      set => this.fullreqexprField = value;
    }

    public string scheme
    {
      get => this.schemeField;
      set => this.schemeField = value;
    }

    public string resultexpr
    {
      get => this.resultexprField;
      set => this.resultexprField = value;
    }

    public long? cacheforsecs
    {
      get => this.cacheforsecsField;
      set => this.cacheforsecsField = value;
    }

    public string comment
    {
      get => this.commentField;
      set => this.commentField = value;
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

    public string svrstate
    {
      get => this.svrstateField;
      private set => this.svrstateField = value;
    }

    public string effectivestate
    {
      get => this.effectivestateField;
      private set => this.effectivestateField = value;
    }

    public string undefreason
    {
      get => this.undefreasonField;
      private set => this.undefreasonField = value;
    }

    public long? recursivecallout
    {
      get => this.recursivecalloutField;
      private set => this.recursivecalloutField = value;
    }

    internal override base_resource[] get_nitro_response(
      nitro_service service,
      string response)
    {
      policyhttpcallout.policyhttpcallout_response policyhttpcalloutResponse = new policyhttpcallout.policyhttpcallout_response();
      policyhttpcallout.policyhttpcallout_response resource = (policyhttpcallout.policyhttpcallout_response) service.get_payload_formatter().string_to_resource(policyhttpcalloutResponse.GetType(), response);
      if (resource.errorcode != 0)
      {
        if (resource.errorcode == 444)
          service.clear_session();
        if (resource.severity == null)
          throw new nitro_exception(resource.message, resource.errorcode);
        if (resource.severity.Equals("ERROR"))
          throw new nitro_exception(resource.message, resource.errorcode);
      }
      return (base_resource[]) resource.policyhttpcallout;
    }

    internal override string get_object_name() => this.name;

    public static base_response add(nitro_service client, policyhttpcallout resource) => new policyhttpcallout()
    {
      name = resource.name,
      ipaddress = resource.ipaddress,
      port = resource.port,
      vserver = resource.vserver,
      returntype = resource.returntype,
      httpmethod = resource.httpmethod,
      hostexpr = resource.hostexpr,
      urlstemexpr = resource.urlstemexpr,
      headers = resource.headers,
      parameters = resource.parameters,
      bodyexpr = resource.bodyexpr,
      fullreqexpr = resource.fullreqexpr,
      scheme = resource.scheme,
      resultexpr = resource.resultexpr,
      cacheforsecs = resource.cacheforsecs,
      comment = resource.comment
    }.add_resource(client);

    public static base_responses add(
      nitro_service client,
      policyhttpcallout[] resources)
    {
      base_responses baseResponses = (base_responses) null;
      if (resources != null && resources.Length > 0)
      {
        policyhttpcallout[] policyhttpcalloutArray = new policyhttpcallout[resources.Length];
        for (int index = 0; index < resources.Length; ++index)
        {
          policyhttpcalloutArray[index] = new policyhttpcallout();
          policyhttpcalloutArray[index].name = resources[index].name;
          policyhttpcalloutArray[index].ipaddress = resources[index].ipaddress;
          policyhttpcalloutArray[index].port = resources[index].port;
          policyhttpcalloutArray[index].vserver = resources[index].vserver;
          policyhttpcalloutArray[index].returntype = resources[index].returntype;
          policyhttpcalloutArray[index].httpmethod = resources[index].httpmethod;
          policyhttpcalloutArray[index].hostexpr = resources[index].hostexpr;
          policyhttpcalloutArray[index].urlstemexpr = resources[index].urlstemexpr;
          policyhttpcalloutArray[index].headers = resources[index].headers;
          policyhttpcalloutArray[index].parameters = resources[index].parameters;
          policyhttpcalloutArray[index].bodyexpr = resources[index].bodyexpr;
          policyhttpcalloutArray[index].fullreqexpr = resources[index].fullreqexpr;
          policyhttpcalloutArray[index].scheme = resources[index].scheme;
          policyhttpcalloutArray[index].resultexpr = resources[index].resultexpr;
          policyhttpcalloutArray[index].cacheforsecs = resources[index].cacheforsecs;
          policyhttpcalloutArray[index].comment = resources[index].comment;
        }
        baseResponses = base_resource.add_bulk_request(client, (base_resource[]) policyhttpcalloutArray);
      }
      return baseResponses;
    }

    public static base_response delete(nitro_service client, string name) => new policyhttpcallout()
    {
      name = name
    }.delete_resource(client);

    public static base_response delete(
      nitro_service client,
      policyhttpcallout resource)
    {
      return new policyhttpcallout()
      {
        name = resource.name
      }.delete_resource(client);
    }

    public static base_responses delete(nitro_service client, string[] name)
    {
      base_responses baseResponses = (base_responses) null;
      if (name != null && name.Length > 0)
      {
        policyhttpcallout[] policyhttpcalloutArray = new policyhttpcallout[name.Length];
        for (int index = 0; index < name.Length; ++index)
        {
          policyhttpcalloutArray[index] = new policyhttpcallout();
          policyhttpcalloutArray[index].name = name[index];
        }
        baseResponses = base_resource.delete_bulk_request(client, (base_resource[]) policyhttpcalloutArray);
      }
      return baseResponses;
    }

    public static base_responses delete(
      nitro_service client,
      policyhttpcallout[] resources)
    {
      base_responses baseResponses = (base_responses) null;
      if (resources != null && resources.Length > 0)
      {
        policyhttpcallout[] policyhttpcalloutArray = new policyhttpcallout[resources.Length];
        for (int index = 0; index < resources.Length; ++index)
        {
          policyhttpcalloutArray[index] = new policyhttpcallout();
          policyhttpcalloutArray[index].name = resources[index].name;
        }
        baseResponses = base_resource.delete_bulk_request(client, (base_resource[]) policyhttpcalloutArray);
      }
      return baseResponses;
    }

    public static base_response update(
      nitro_service client,
      policyhttpcallout resource)
    {
      return new policyhttpcallout()
      {
        name = resource.name,
        ipaddress = resource.ipaddress,
        port = resource.port,
        vserver = resource.vserver,
        returntype = resource.returntype,
        httpmethod = resource.httpmethod,
        hostexpr = resource.hostexpr,
        urlstemexpr = resource.urlstemexpr,
        headers = resource.headers,
        parameters = resource.parameters,
        bodyexpr = resource.bodyexpr,
        fullreqexpr = resource.fullreqexpr,
        scheme = resource.scheme,
        resultexpr = resource.resultexpr,
        cacheforsecs = resource.cacheforsecs,
        comment = resource.comment
      }.update_resource(client);
    }

    public static base_responses update(
      nitro_service client,
      policyhttpcallout[] resources)
    {
      base_responses baseResponses = (base_responses) null;
      if (resources != null && resources.Length > 0)
      {
        policyhttpcallout[] policyhttpcalloutArray = new policyhttpcallout[resources.Length];
        for (int index = 0; index < resources.Length; ++index)
        {
          policyhttpcalloutArray[index] = new policyhttpcallout();
          policyhttpcalloutArray[index].name = resources[index].name;
          policyhttpcalloutArray[index].ipaddress = resources[index].ipaddress;
          policyhttpcalloutArray[index].port = resources[index].port;
          policyhttpcalloutArray[index].vserver = resources[index].vserver;
          policyhttpcalloutArray[index].returntype = resources[index].returntype;
          policyhttpcalloutArray[index].httpmethod = resources[index].httpmethod;
          policyhttpcalloutArray[index].hostexpr = resources[index].hostexpr;
          policyhttpcalloutArray[index].urlstemexpr = resources[index].urlstemexpr;
          policyhttpcalloutArray[index].headers = resources[index].headers;
          policyhttpcalloutArray[index].parameters = resources[index].parameters;
          policyhttpcalloutArray[index].bodyexpr = resources[index].bodyexpr;
          policyhttpcalloutArray[index].fullreqexpr = resources[index].fullreqexpr;
          policyhttpcalloutArray[index].scheme = resources[index].scheme;
          policyhttpcalloutArray[index].resultexpr = resources[index].resultexpr;
          policyhttpcalloutArray[index].cacheforsecs = resources[index].cacheforsecs;
          policyhttpcalloutArray[index].comment = resources[index].comment;
        }
        baseResponses = base_resource.update_bulk_request(client, (base_resource[]) policyhttpcalloutArray);
      }
      return baseResponses;
    }

    public static base_response unset(
      nitro_service client,
      string name,
      string[] args)
    {
      return new policyhttpcallout() { name = name }.unset_resource(client, args);
    }

    public static base_response unset(
      nitro_service client,
      policyhttpcallout resource,
      string[] args)
    {
      return new policyhttpcallout()
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
        policyhttpcallout[] policyhttpcalloutArray = new policyhttpcallout[name.Length];
        for (int index = 0; index < name.Length; ++index)
        {
          policyhttpcalloutArray[index] = new policyhttpcallout();
          policyhttpcalloutArray[index].name = name[index];
        }
        baseResponses = base_resource.unset_bulk_request(client, (base_resource[]) policyhttpcalloutArray, args);
      }
      return baseResponses;
    }

    public static base_responses unset(
      nitro_service client,
      policyhttpcallout[] resources,
      string[] args)
    {
      base_responses baseResponses = (base_responses) null;
      if (resources != null && resources.Length > 0)
      {
        policyhttpcallout[] policyhttpcalloutArray = new policyhttpcallout[resources.Length];
        for (int index = 0; index < resources.Length; ++index)
        {
          policyhttpcalloutArray[index] = new policyhttpcallout();
          policyhttpcalloutArray[index].name = resources[index].name;
        }
        baseResponses = base_resource.unset_bulk_request(client, (base_resource[]) policyhttpcalloutArray, args);
      }
      return baseResponses;
    }

    public static policyhttpcallout[] get(nitro_service service) => (policyhttpcallout[]) new policyhttpcallout().get_resources(service, (options) null);

    public static policyhttpcallout[] get(nitro_service service, options option) => (policyhttpcallout[]) new policyhttpcallout().get_resources(service, option);

    public static policyhttpcallout get(nitro_service service, string name) => (policyhttpcallout) new policyhttpcallout()
    {
      name = name
    }.get_resource(service);

    public static policyhttpcallout[] get(nitro_service service, string[] name)
    {
      if (name == null || name.Length <= 0)
        return (policyhttpcallout[]) null;
      policyhttpcallout[] policyhttpcalloutArray1 = new policyhttpcallout[name.Length];
      policyhttpcallout[] policyhttpcalloutArray2 = new policyhttpcallout[name.Length];
      for (int index = 0; index < name.Length; ++index)
      {
        policyhttpcalloutArray2[index] = new policyhttpcallout();
        policyhttpcalloutArray2[index].name = name[index];
        policyhttpcalloutArray1[index] = (policyhttpcallout) policyhttpcalloutArray2[index].get_resource(service);
      }
      return policyhttpcalloutArray1;
    }

    public static policyhttpcallout[] get_filtered(
      nitro_service service,
      string filter)
    {
      policyhttpcallout policyhttpcallout = new policyhttpcallout();
      options option = new options();
      option.set_filter(filter);
      return (policyhttpcallout[]) policyhttpcallout.getfiltered(service, option);
    }

    public static policyhttpcallout[] get_filtered(
      nitro_service service,
      filtervalue[] filter)
    {
      policyhttpcallout policyhttpcallout = new policyhttpcallout();
      options option = new options();
      option.set_filter(filter);
      return (policyhttpcallout[]) policyhttpcallout.getfiltered(service, option);
    }

    public static uint count(nitro_service service)
    {
      policyhttpcallout policyhttpcallout = new policyhttpcallout();
      options option = new options();
      option.set_count(true);
      policyhttpcallout[] resources = (policyhttpcallout[]) policyhttpcallout.get_resources(service, option);
      return resources != null && resources.Length > 0 ? resources[0].__count.Value : 0U;
    }

    public static uint count_filtered(nitro_service service, string filter)
    {
      policyhttpcallout policyhttpcallout = new policyhttpcallout();
      options option = new options();
      option.set_count(true);
      option.set_filter(filter);
      policyhttpcallout[] policyhttpcalloutArray = (policyhttpcallout[]) policyhttpcallout.getfiltered(service, option);
      return policyhttpcalloutArray != null && policyhttpcalloutArray.Length > 0 ? policyhttpcalloutArray[0].__count.Value : 0U;
    }

    public static uint count_filtered(nitro_service service, filtervalue[] filter)
    {
      policyhttpcallout policyhttpcallout = new policyhttpcallout();
      options option = new options();
      option.set_count(true);
      option.set_filter(filter);
      policyhttpcallout[] policyhttpcalloutArray = (policyhttpcallout[]) policyhttpcallout.getfiltered(service, option);
      return policyhttpcalloutArray != null && policyhttpcalloutArray.Length > 0 ? policyhttpcalloutArray[0].__count.Value : 0U;
    }

    private class policyhttpcallout_response : base_response
    {
      public policyhttpcallout[] policyhttpcallout = (policyhttpcallout[]) null;
    }

    public static class svrstateEnum
    {
      public const string UP = "UP";
      public const string DOWN = "DOWN";
      public const string UNKNOWN = "UNKNOWN";
      public const string BUSY = "BUSY";
      public const string OUT_OF_SERVICE = "OUT OF SERVICE";
      public const string GOING_OUT_OF_SERVICE = "GOING OUT OF SERVICE";
      public const string DOWN_WHEN_GOING_OUT_OF_SERVICE = "DOWN WHEN GOING OUT OF SERVICE";
      public const string NS_EMPTY_STR = "NS_EMPTY_STR";
      public const string Unknown = "Unknown";
      public const string DISABLED = "DISABLED";
    }

    public static class schemeEnum
    {
      public const string http = "http";
      public const string https = "https";
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

    public static class effectivestateEnum
    {
      public const string UP = "UP";
      public const string DOWN = "DOWN";
      public const string UNKNOWN = "UNKNOWN";
      public const string BUSY = "BUSY";
      public const string OUT_OF_SERVICE = "OUT OF SERVICE";
      public const string GOING_OUT_OF_SERVICE = "GOING OUT OF SERVICE";
      public const string DOWN_WHEN_GOING_OUT_OF_SERVICE = "DOWN WHEN GOING OUT OF SERVICE";
      public const string NS_EMPTY_STR = "NS_EMPTY_STR";
      public const string Unknown = "Unknown";
      public const string DISABLED = "DISABLED";
    }

    public static class undefreasonEnum
    {
      public const string Failed_to_add_service = "Failed to add service";
      public const string Vserver_not_found = "Vserver not found";
      public const string Not_a_HTTP_or_SSL_vserver = "Not a HTTP or SSL vserver";
      public const string Generated_callout_request_is_invalid = "Generated callout request is invalid";
      public const string Content_Length_header_not_found_in_callout_request = "Content-Length header not found in callout request";
      public const string Not_enough_space_to_put_Content_Length_value = "Not enough space to put Content-Length value";
      public const string Config_incomplete = "Config incomplete";
      public const string Server_is_DOWN = "Server is DOWN";
      public const string Creating_callout_connection_failed = "Creating callout connection failed";
      public const string No_memory_to_generate_callout_request_packets = "No memory to generate callout request packets";
      public const string No_memory_to_create_callout_task = "No memory to create callout task";
      public const string No_memory_to_create_callout_async = "No memory to create callout async";
      public const string Callout_request_expression_undef = "Callout request expression undef";
      public const string No_callout_response_expression = "No callout response expression";
      public const string Skipped_callout_response_eval = "Skipped callout response eval";
      public const string Callout_response_pixl_init_undef = "Callout response pixl init undef";
      public const string Callout_response_expression_undef = "Callout response expression undef";
    }
  }
}
