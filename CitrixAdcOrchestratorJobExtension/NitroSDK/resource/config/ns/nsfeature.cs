// Decompiled with JetBrains decompiler
// Type: com.citrix.netscaler.nitro.resource.config.ns.nsfeature
// Assembly: nitro, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 6CF5DDEF-E052-4F9D-953F-6644F8378A66


using com.citrix.netscaler.nitro.exception;
using com.citrix.netscaler.nitro.resource.Base;
using com.citrix.netscaler.nitro.service;

namespace com.citrix.netscaler.nitro.resource.config.ns
{
  public class nsfeature : base_resource
  {
    private string[] featureField = (string[]) null;
    private bool? wlField = new bool?();
    private bool? spField = new bool?();
    private bool? lbField = new bool?();
    private bool? csField = new bool?();
    private bool? crField = new bool?();
    private bool? scField = new bool?();
    private bool? cmpField = new bool?();
    private bool? pqField = new bool?();
    private bool? sslField = new bool?();
    private bool? gslbField = new bool?();
    private bool? hdospField = new bool?();
    private bool? cfField = new bool?();
    private bool? icField = new bool?();
    private bool? sslvpnField = new bool?();
    private bool? aaaField = new bool?();
    private bool? ospfField = new bool?();
    private bool? ripField = new bool?();
    private bool? bgpField = new bool?();
    private bool? rewriteField = new bool?();
    private bool? ipv6ptField = new bool?();
    private bool? appfwField = new bool?();
    private bool? responderField = new bool?();
    private bool? htmlinjectionField = new bool?();
    private bool? pushField = new bool?();
    private bool? appflowField = new bool?();
    private bool? cloudbridgeField = new bool?();
    private bool? isisField = new bool?();
    private bool? chField = new bool?();
    private bool? appqoeField = new bool?();
    private bool? vpathField = new bool?();
    private bool? contentacceleratorField = new bool?();
    private bool? riseField = new bool?();
    private bool? feoField = new bool?();
    private bool? lsnField = new bool?();
    private bool? rdpproxyField = new bool?();
    private bool? repField = new bool?();

    public string[] feature
    {
      get => this.featureField;
      set => this.featureField = value;
    }

    public bool? wl
    {
      get => this.wlField;
      private set => this.wlField = value;
    }

    public bool? sp
    {
      get => this.spField;
      private set => this.spField = value;
    }

    public bool? lb
    {
      get => this.lbField;
      private set => this.lbField = value;
    }

    public bool? cs
    {
      get => this.csField;
      private set => this.csField = value;
    }

    public bool? cr
    {
      get => this.crField;
      private set => this.crField = value;
    }

    public bool? sc
    {
      get => this.scField;
      private set => this.scField = value;
    }

    public bool? cmp
    {
      get => this.cmpField;
      private set => this.cmpField = value;
    }

    public bool? pq
    {
      get => this.pqField;
      private set => this.pqField = value;
    }

    public bool? ssl
    {
      get => this.sslField;
      private set => this.sslField = value;
    }

    public bool? gslb
    {
      get => this.gslbField;
      private set => this.gslbField = value;
    }

    public bool? hdosp
    {
      get => this.hdospField;
      private set => this.hdospField = value;
    }

    public bool? cf
    {
      get => this.cfField;
      private set => this.cfField = value;
    }

    public bool? ic
    {
      get => this.icField;
      private set => this.icField = value;
    }

    public bool? sslvpn
    {
      get => this.sslvpnField;
      private set => this.sslvpnField = value;
    }

    public bool? aaa
    {
      get => this.aaaField;
      private set => this.aaaField = value;
    }

    public bool? ospf
    {
      get => this.ospfField;
      private set => this.ospfField = value;
    }

    public bool? rip
    {
      get => this.ripField;
      private set => this.ripField = value;
    }

    public bool? bgp
    {
      get => this.bgpField;
      private set => this.bgpField = value;
    }

    public bool? rewrite
    {
      get => this.rewriteField;
      private set => this.rewriteField = value;
    }

    public bool? ipv6pt
    {
      get => this.ipv6ptField;
      private set => this.ipv6ptField = value;
    }

    public bool? appfw
    {
      get => this.appfwField;
      private set => this.appfwField = value;
    }

    public bool? responder
    {
      get => this.responderField;
      private set => this.responderField = value;
    }

    public bool? htmlinjection
    {
      get => this.htmlinjectionField;
      private set => this.htmlinjectionField = value;
    }

    public bool? push
    {
      get => this.pushField;
      private set => this.pushField = value;
    }

    public bool? appflow
    {
      get => this.appflowField;
      private set => this.appflowField = value;
    }

    public bool? cloudbridge
    {
      get => this.cloudbridgeField;
      private set => this.cloudbridgeField = value;
    }

    public bool? isis
    {
      get => this.isisField;
      private set => this.isisField = value;
    }

    public bool? ch
    {
      get => this.chField;
      private set => this.chField = value;
    }

    public bool? appqoe
    {
      get => this.appqoeField;
      private set => this.appqoeField = value;
    }

    public bool? vpath
    {
      get => this.vpathField;
      private set => this.vpathField = value;
    }

    public bool? contentaccelerator
    {
      get => this.contentacceleratorField;
      private set => this.contentacceleratorField = value;
    }

    public bool? rise
    {
      get => this.riseField;
      private set => this.riseField = value;
    }

    public bool? feo
    {
      get => this.feoField;
      private set => this.feoField = value;
    }

    public bool? lsn
    {
      get => this.lsnField;
      private set => this.lsnField = value;
    }

    public bool? rdpproxy
    {
      get => this.rdpproxyField;
      private set => this.rdpproxyField = value;
    }

    public bool? rep
    {
      get => this.repField;
      private set => this.repField = value;
    }

    internal override base_resource[] get_nitro_response(
      nitro_service service,
      string response)
    {
      nsfeature[] nsfeatureArray = new nsfeature[1];
      nsfeature.nsfeature_response nsfeatureResponse = new nsfeature.nsfeature_response();
      nsfeature.nsfeature_response resource = (nsfeature.nsfeature_response) service.get_payload_formatter().string_to_resource(nsfeatureResponse.GetType(), response);
      if (resource.errorcode != 0)
      {
        if (resource.errorcode == 444)
          service.clear_session();
        if (resource.severity == null)
          throw new nitro_exception(resource.message, resource.errorcode);
        if (resource.severity.Equals("ERROR"))
          throw new nitro_exception(resource.message, resource.errorcode);
      }
      nsfeatureArray[0] = resource.nsfeature;
      return (base_resource[]) nsfeatureArray;
    }

    internal override string get_object_name() => (string) null;

    public static base_response enable(nitro_service client, nsfeature resource) => new nsfeature()
    {
      feature = resource.feature
    }.perform_operation_byaction(client, nameof (enable));

    public static base_response disable(nitro_service client, nsfeature resource) => new nsfeature()
    {
      feature = resource.feature
    }.perform_operation_byaction(client, nameof (disable));

    public static nsfeature get(nitro_service service) => ((nsfeature[]) new nsfeature().get_resources(service, (options) null))[0];

    public static nsfeature get(nitro_service service, options option) => ((nsfeature[]) new nsfeature().get_resources(service, option))[0];

    private class nsfeature_response : base_response
    {
      public nsfeature nsfeature = (nsfeature) null;
    }

    public static class featureEnum
    {
      public const string WL = "WL";
      public const string WebLogging = "WebLogging";
      public const string SP = "SP";
      public const string SurgeProtection = "SurgeProtection";
      public const string LB = "LB";
      public const string LoadBalancing = "LoadBalancing";
      public const string CS = "CS";
      public const string ContentSwitching = "ContentSwitching";
      public const string CR = "CR";
      public const string CacheRedirection = "CacheRedirection";
      public const string SC = "SC";
      public const string SureConnect = "SureConnect";
      public const string CMP = "CMP";
      public const string CMPcntl = "CMPcntl";
      public const string CompressionControl = "CompressionControl";
      public const string PQ = "PQ";
      public const string PriorityQueuing = "PriorityQueuing";
      public const string HDOSP = "HDOSP";
      public const string HttpDoSProtection = "HttpDoSProtection";
      public const string SSLVPN = "SSLVPN";
      public const string AAA = "AAA";
      public const string GSLB = "GSLB";
      public const string GlobalServerLoadBalancing = "GlobalServerLoadBalancing";
      public const string SSL = "SSL";
      public const string SSLOffload = "SSLOffload";
      public const string SSLOffloading = "SSLOffloading";
      public const string CF = "CF";
      public const string ContentFiltering = "ContentFiltering";
      public const string IC = "IC";
      public const string IntegratedCaching = "IntegratedCaching";
      public const string OSPF = "OSPF";
      public const string OSPFRouting = "OSPFRouting";
      public const string RIP = "RIP";
      public const string RIPRouting = "RIPRouting";
      public const string BGP = "BGP";
      public const string BGPRouting = "BGPRouting";
      public const string REWRITE = "REWRITE";
      public const string IPv6PT = "IPv6PT";
      public const string IPv6protocoltranslation = "IPv6protocoltranslation";
      public const string AppFw = "AppFw";
      public const string ApplicationFirewall = "ApplicationFirewall";
      public const string RESPONDER = "RESPONDER";
      public const string HTMLInjection = "HTMLInjection";
      public const string push = "push";
      public const string NSPush = "NSPush";
      public const string NetScalerPush = "NetScalerPush";
      public const string AppFlow = "AppFlow";
      public const string CloudBridge = "CloudBridge";
      public const string ISIS = "ISIS";
      public const string ISISRouting = "ISISRouting";
      public const string CH = "CH";
      public const string CallHome = "CallHome";
      public const string AppQoE = "AppQoE";
      public const string vPath = "vPath";
      public const string ContentAccelerator = "ContentAccelerator";
      public const string RISE = "RISE";
      public const string FEO = "FEO";
      public const string LSN = "LSN";
      public const string LargeScaleNAT = "LargeScaleNAT";
      public const string RDPProxy = "RDPProxy";
      public const string Rep = "Rep";
      public const string Reputation = "Reputation";
    }
  }
}
