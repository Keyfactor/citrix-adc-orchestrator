// Decompiled with JetBrains decompiler
// Type: com.citrix.netscaler.nitro.resource.config.ns.nslicense
// Assembly: nitro, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 6CF5DDEF-E052-4F9D-953F-6644F8378A66


using com.citrix.netscaler.nitro.exception;
using com.citrix.netscaler.nitro.resource.Base;
using com.citrix.netscaler.nitro.service;

namespace com.citrix.netscaler.nitro.resource.config.ns
{
  public class nslicense : base_resource
  {
    private bool? wlField = new bool?();
    private bool? spField = new bool?();
    private bool? lbField = new bool?();
    private bool? csField = new bool?();
    private bool? crField = new bool?();
    private bool? scField = new bool?();
    private bool? cmpField = new bool?();
    private bool? deltaField = new bool?();
    private bool? pqField = new bool?();
    private bool? sslField = new bool?();
    private bool? gslbField = new bool?();
    private bool? gslbpField = new bool?();
    private bool? hdospField = new bool?();
    private bool? routingField = new bool?();
    private bool? cfField = new bool?();
    private bool? contentacceleratorField = new bool?();
    private bool? icField = new bool?();
    private bool? sslvpnField = new bool?();
    private uint? f_sslvpn_usersField = new uint?();
    private uint? f_ica_usersField = new uint?();
    private bool? aaaField = new bool?();
    private bool? ospfField = new bool?();
    private bool? ripField = new bool?();
    private bool? bgpField = new bool?();
    private bool? rewriteField = new bool?();
    private bool? ipv6ptField = new bool?();
    private bool? appfwField = new bool?();
    private bool? responderField = new bool?();
    private bool? ageeField = new bool?();
    private bool? nsxnField = new bool?();
    private bool? htmlinjectionField = new bool?();
    private uint? modelidField = new uint?();
    private bool? pushField = new bool?();
    private bool? wionnsField = new bool?();
    private bool? appflowField = new bool?();
    private bool? cloudbridgeField = new bool?();
    private bool? cloudbridgeapplianceField = new bool?();
    private bool? cloudextenderapplianceField = new bool?();
    private bool? isisField = new bool?();
    private bool? clusterField = new bool?();
    private bool? chField = new bool?();
    private bool? appqoeField = new bool?();
    private bool? appflowicaField = new bool?();
    private bool? isstandardlicField = new bool?();
    private bool? isenterpriselicField = new bool?();
    private bool? isplatinumlicField = new bool?();
    private bool? riseField = new bool?();
    private bool? vpathField = new bool?();
    private bool? feoField = new bool?();
    private bool? lsnField = new bool?();
    private bool? rdpproxyField = new bool?();
    private bool? repField = new bool?();

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

    public bool? delta
    {
      get => this.deltaField;
      private set => this.deltaField = value;
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

    public bool? gslbp
    {
      get => this.gslbpField;
      private set => this.gslbpField = value;
    }

    public bool? hdosp
    {
      get => this.hdospField;
      private set => this.hdospField = value;
    }

    public bool? routing
    {
      get => this.routingField;
      private set => this.routingField = value;
    }

    public bool? cf
    {
      get => this.cfField;
      private set => this.cfField = value;
    }

    public bool? contentaccelerator
    {
      get => this.contentacceleratorField;
      private set => this.contentacceleratorField = value;
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

    public uint? f_sslvpn_users
    {
      get => this.f_sslvpn_usersField;
      private set => this.f_sslvpn_usersField = value;
    }

    public uint? f_ica_users
    {
      get => this.f_ica_usersField;
      private set => this.f_ica_usersField = value;
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

    public bool? agee
    {
      get => this.ageeField;
      private set => this.ageeField = value;
    }

    public bool? nsxn
    {
      get => this.nsxnField;
      private set => this.nsxnField = value;
    }

    public bool? htmlinjection
    {
      get => this.htmlinjectionField;
      private set => this.htmlinjectionField = value;
    }

    public uint? modelid
    {
      get => this.modelidField;
      private set => this.modelidField = value;
    }

    public bool? push
    {
      get => this.pushField;
      private set => this.pushField = value;
    }

    public bool? wionns
    {
      get => this.wionnsField;
      private set => this.wionnsField = value;
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

    public bool? cloudbridgeappliance
    {
      get => this.cloudbridgeapplianceField;
      private set => this.cloudbridgeapplianceField = value;
    }

    public bool? cloudextenderappliance
    {
      get => this.cloudextenderapplianceField;
      private set => this.cloudextenderapplianceField = value;
    }

    public bool? isis
    {
      get => this.isisField;
      private set => this.isisField = value;
    }

    public bool? cluster
    {
      get => this.clusterField;
      private set => this.clusterField = value;
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

    public bool? appflowica
    {
      get => this.appflowicaField;
      private set => this.appflowicaField = value;
    }

    public bool? isstandardlic
    {
      get => this.isstandardlicField;
      private set => this.isstandardlicField = value;
    }

    public bool? isenterpriselic
    {
      get => this.isenterpriselicField;
      private set => this.isenterpriselicField = value;
    }

    public bool? isplatinumlic
    {
      get => this.isplatinumlicField;
      private set => this.isplatinumlicField = value;
    }

    public bool? rise
    {
      get => this.riseField;
      private set => this.riseField = value;
    }

    public bool? vpath
    {
      get => this.vpathField;
      private set => this.vpathField = value;
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
      nslicense[] nslicenseArray = new nslicense[1];
      nslicense.nslicense_response nslicenseResponse = new nslicense.nslicense_response();
      nslicense.nslicense_response resource = (nslicense.nslicense_response) service.get_payload_formatter().string_to_resource(nslicenseResponse.GetType(), response);
      if (resource.errorcode != 0)
      {
        if (resource.errorcode == 444)
          service.clear_session();
        if (resource.severity == null)
          throw new nitro_exception(resource.message, resource.errorcode);
        if (resource.severity.Equals("ERROR"))
          throw new nitro_exception(resource.message, resource.errorcode);
      }
      nslicenseArray[0] = resource.nslicense;
      return (base_resource[]) nslicenseArray;
    }

    internal override string get_object_name() => (string) null;

    public static nslicense get(nitro_service service) => ((nslicense[]) new nslicense().get_resources(service, (options) null))[0];

    public static nslicense get(nitro_service service, options option) => ((nslicense[]) new nslicense().get_resources(service, option))[0];

    private class nslicense_response : base_response
    {
      public nslicense nslicense = (nslicense) null;
    }
  }
}
