// Decompiled with JetBrains decompiler
// Type: com.citrix.netscaler.nitro.resource.config.basic.nstrace
// Assembly: nitro, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 6CF5DDEF-E052-4F9D-953F-6644F8378A66


using com.citrix.netscaler.nitro.exception;
using com.citrix.netscaler.nitro.resource.Base;
using com.citrix.netscaler.nitro.service;

namespace com.citrix.netscaler.nitro.resource.config.basic
{
  public class nstrace : base_resource
  {
    private uint? nfField = new uint?();
    private uint? timeField = new uint?();
    private uint? sizeField = new uint?();
    private string[] modeField = (string[]) null;
    private string pernicField = (string) null;
    private string filenameField = (string) null;
    private string fileidField = (string) null;
    private string filterField = (string) null;
    private string linkField = (string) null;
    private uint?[] nodesField = (uint?[]) null;
    private uint? filesizeField = new uint?();
    private string traceformatField = (string) null;
    private string mergeField = (string) null;
    private string doruntimecleanupField = (string) null;
    private uint? tracebuffersField = new uint?();
    private string skiprpcField = (string) null;
    private string inmemorytraceField = (string) null;
    private string stateField = (string) null;
    private string scopeField = (string) null;
    private string tracelocationField = (string) null;

    public uint? nf
    {
      get => this.nfField;
      set => this.nfField = value;
    }

    public uint? time
    {
      get => this.timeField;
      set => this.timeField = value;
    }

    public uint? size
    {
      get => this.sizeField;
      set => this.sizeField = value;
    }

    public string[] mode
    {
      get => this.modeField;
      set => this.modeField = value;
    }

    public string pernic
    {
      get => this.pernicField;
      set => this.pernicField = value;
    }

    public string filename
    {
      get => this.filenameField;
      set => this.filenameField = value;
    }

    public string fileid
    {
      get => this.fileidField;
      set => this.fileidField = value;
    }

    public string filter
    {
      get => this.filterField;
      set => this.filterField = value;
    }

    public string link
    {
      get => this.linkField;
      set => this.linkField = value;
    }

    public uint?[] nodes
    {
      get => this.nodesField;
      set => this.nodesField = value;
    }

    public uint? filesize
    {
      get => this.filesizeField;
      set => this.filesizeField = value;
    }

    public string traceformat
    {
      get => this.traceformatField;
      set => this.traceformatField = value;
    }

    public string merge
    {
      get => this.mergeField;
      set => this.mergeField = value;
    }

    public string doruntimecleanup
    {
      get => this.doruntimecleanupField;
      set => this.doruntimecleanupField = value;
    }

    public uint? tracebuffers
    {
      get => this.tracebuffersField;
      set => this.tracebuffersField = value;
    }

    public string skiprpc
    {
      get => this.skiprpcField;
      set => this.skiprpcField = value;
    }

    public string inmemorytrace
    {
      get => this.inmemorytraceField;
      set => this.inmemorytraceField = value;
    }

    public string state
    {
      get => this.stateField;
      private set => this.stateField = value;
    }

    public string scope
    {
      get => this.scopeField;
      private set => this.scopeField = value;
    }

    public string tracelocation
    {
      get => this.tracelocationField;
      private set => this.tracelocationField = value;
    }

    internal override base_resource[] get_nitro_response(
      nitro_service service,
      string response)
    {
      nstrace[] nstraceArray = new nstrace[1];
      nstrace.nstrace_response nstraceResponse = new nstrace.nstrace_response();
      nstrace.nstrace_response resource = (nstrace.nstrace_response) service.get_payload_formatter().string_to_resource(nstraceResponse.GetType(), response);
      if (resource.errorcode != 0)
      {
        if (resource.errorcode == 444)
          service.clear_session();
        if (resource.severity == null)
          throw new nitro_exception(resource.message, resource.errorcode);
        if (resource.severity.Equals("ERROR"))
          throw new nitro_exception(resource.message, resource.errorcode);
      }
      nstraceArray[0] = resource.nstrace;
      return (base_resource[]) nstraceArray;
    }

    internal override string get_object_name() => (string) null;

    public static nstrace get(nitro_service service) => ((nstrace[]) new nstrace().get_resources(service, (options) null))[0];

    public static nstrace get(nitro_service service, options option) => ((nstrace[]) new nstrace().get_resources(service, option))[0];

    private class nstrace_response : base_response
    {
      public nstrace nstrace = (nstrace) null;
    }

    public static class skiprpcEnum
    {
      public const string ENABLED = "ENABLED";
      public const string DISABLED = "DISABLED";
    }

    public static class modeEnum
    {
      public const string TX = "TX";
      public const string TXB = "TXB";
      public const string RX = "RX";
      public const string IPV6 = "IPV6";
      public const string NEW_RX = "NEW_RX";
      public const string C2C = "C2C";
      public const string NS_FR_TX = "NS_FR_TX";
      public const string APPFW = "APPFW";
      public const string SSLPLAIN = "SSLPLAIN";
      public const string MPTCP = "MPTCP";
    }

    public static class stateEnum
    {
      public const string RUNNING = "RUNNING";
      public const string STOPPED = "STOPPED";
    }

    public static class traceformatEnum
    {
      public const string NSCAP = "NSCAP";
      public const string PCAP = "PCAP";
    }

    public static class scopeEnum
    {
      public const string CLUSTER = "CLUSTER";
      public const string LOCAL = "LOCAL";
    }

    public static class doruntimecleanupEnum
    {
      public const string ENABLED = "ENABLED";
      public const string DISABLED = "DISABLED";
    }

    public static class pernicEnum
    {
      public const string ENABLED = "ENABLED";
      public const string DISABLED = "DISABLED";
    }

    public static class mergeEnum
    {
      public const string ONSTOP = "ONSTOP";
      public const string ONTHEFLY = "ONTHEFLY";
      public const string NOMERGE = "NOMERGE";
    }

    public static class linkEnum
    {
      public const string ENABLED = "ENABLED";
      public const string DISABLED = "DISABLED";
    }

    public static class inmemorytraceEnum
    {
      public const string ENABLED = "ENABLED";
      public const string DISABLED = "DISABLED";
    }
  }
}
