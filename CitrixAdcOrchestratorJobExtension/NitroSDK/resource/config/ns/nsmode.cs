// Decompiled with JetBrains decompiler
// Type: com.citrix.netscaler.nitro.resource.config.ns.nsmode
// Assembly: nitro, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 6CF5DDEF-E052-4F9D-953F-6644F8378A66


using com.citrix.netscaler.nitro.exception;
using com.citrix.netscaler.nitro.resource.Base;
using com.citrix.netscaler.nitro.service;

namespace com.citrix.netscaler.nitro.resource.config.ns
{
  public class nsmode : base_resource
  {
    private string[] modeField = (string[]) null;
    private bool? frField = new bool?();
    private bool? l2Field = new bool?();
    private bool? usipField = new bool?();
    private bool? ckaField = new bool?();
    private bool? tcpbField = new bool?();
    private bool? mbfField = new bool?();
    private bool? edgeField = new bool?();
    private bool? usnipField = new bool?();
    private bool? l3Field = new bool?();
    private bool? pmtudField = new bool?();
    private bool? mediaclassificationField = new bool?();
    private bool? sradvField = new bool?();
    private bool? dradvField = new bool?();
    private bool? iradvField = new bool?();
    private bool? sradv6Field = new bool?();
    private bool? dradv6Field = new bool?();
    private bool? bridgebpdusField = new bool?();
    private bool? rise_apbrField = new bool?();
    private bool? rise_rhiField = new bool?();

    public string[] mode
    {
      get => this.modeField;
      set => this.modeField = value;
    }

    public bool? fr
    {
      get => this.frField;
      private set => this.frField = value;
    }

    public bool? l2
    {
      get => this.l2Field;
      private set => this.l2Field = value;
    }

    public bool? usip
    {
      get => this.usipField;
      private set => this.usipField = value;
    }

    public bool? cka
    {
      get => this.ckaField;
      private set => this.ckaField = value;
    }

    public bool? tcpb
    {
      get => this.tcpbField;
      private set => this.tcpbField = value;
    }

    public bool? mbf
    {
      get => this.mbfField;
      private set => this.mbfField = value;
    }

    public bool? edge
    {
      get => this.edgeField;
      private set => this.edgeField = value;
    }

    public bool? usnip
    {
      get => this.usnipField;
      private set => this.usnipField = value;
    }

    public bool? l3
    {
      get => this.l3Field;
      private set => this.l3Field = value;
    }

    public bool? pmtud
    {
      get => this.pmtudField;
      private set => this.pmtudField = value;
    }

    public bool? mediaclassification
    {
      get => this.mediaclassificationField;
      private set => this.mediaclassificationField = value;
    }

    public bool? sradv
    {
      get => this.sradvField;
      private set => this.sradvField = value;
    }

    public bool? dradv
    {
      get => this.dradvField;
      private set => this.dradvField = value;
    }

    public bool? iradv
    {
      get => this.iradvField;
      private set => this.iradvField = value;
    }

    public bool? sradv6
    {
      get => this.sradv6Field;
      private set => this.sradv6Field = value;
    }

    public bool? dradv6
    {
      get => this.dradv6Field;
      private set => this.dradv6Field = value;
    }

    public bool? bridgebpdus
    {
      get => this.bridgebpdusField;
      private set => this.bridgebpdusField = value;
    }

    public bool? rise_apbr
    {
      get => this.rise_apbrField;
      private set => this.rise_apbrField = value;
    }

    public bool? rise_rhi
    {
      get => this.rise_rhiField;
      private set => this.rise_rhiField = value;
    }

    internal override base_resource[] get_nitro_response(
      nitro_service service,
      string response)
    {
      nsmode[] nsmodeArray = new nsmode[1];
      nsmode.nsmode_response nsmodeResponse = new nsmode.nsmode_response();
      nsmode.nsmode_response resource = (nsmode.nsmode_response) service.get_payload_formatter().string_to_resource(nsmodeResponse.GetType(), response);
      if (resource.errorcode != 0)
      {
        if (resource.errorcode == 444)
          service.clear_session();
        if (resource.severity == null)
          throw new nitro_exception(resource.message, resource.errorcode);
        if (resource.severity.Equals("ERROR"))
          throw new nitro_exception(resource.message, resource.errorcode);
      }
      nsmodeArray[0] = resource.nsmode;
      return (base_resource[]) nsmodeArray;
    }

    internal override string get_object_name() => (string) null;

    public static base_response enable(nitro_service client, nsmode resource) => new nsmode()
    {
      mode = resource.mode
    }.perform_operation_byaction(client, nameof (enable));

    public static base_response disable(nitro_service client, nsmode resource) => new nsmode()
    {
      mode = resource.mode
    }.perform_operation_byaction(client, nameof (disable));

    public static nsmode get(nitro_service service) => ((nsmode[]) new nsmode().get_resources(service, (options) null))[0];

    public static nsmode get(nitro_service service, options option) => ((nsmode[]) new nsmode().get_resources(service, option))[0];

    private class nsmode_response : base_response
    {
      public nsmode nsmode = (nsmode) null;
    }

    public static class modeEnum
    {
      public const string FR = "FR";
      public const string FastRamp = "FastRamp";
      public const string L2 = "L2";
      public const string L2mode = "L2mode";
      public const string L3 = "L3";
      public const string L3mode = "L3mode";
      public const string USIP = "USIP";
      public const string UseSourceIP = "UseSourceIP";
      public const string CKA = "CKA";
      public const string ClientKeepAlive = "ClientKeepAlive";
      public const string TCPB = "TCPB";
      public const string TCPBuffering = "TCPBuffering";
      public const string MBF = "MBF";
      public const string MACbasedforwarding = "MACbasedforwarding";
      public const string Edge = "Edge";
      public const string USNIP = "USNIP";
      public const string SRADV = "SRADV";
      public const string DRADV = "DRADV";
      public const string IRADV = "IRADV";
      public const string SRADV6 = "SRADV6";
      public const string DRADV6 = "DRADV6";
      public const string PMTUD = "PMTUD";
      public const string RISE_APBR = "RISE_APBR";
      public const string RISE_RHI = "RISE_RHI";
      public const string BridgeBPDUs = "BridgeBPDUs";
      public const string Mediaclassification = "Mediaclassification";
    }
  }
}
