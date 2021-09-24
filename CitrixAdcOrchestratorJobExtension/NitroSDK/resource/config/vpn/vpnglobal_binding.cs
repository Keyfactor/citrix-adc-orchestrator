// Decompiled with JetBrains decompiler
// Type: com.citrix.netscaler.nitro.resource.config.vpn.vpnglobal_binding
// Assembly: nitro, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 6CF5DDEF-E052-4F9D-953F-6644F8378A66


using com.citrix.netscaler.nitro.exception;
using com.citrix.netscaler.nitro.resource.Base;
using com.citrix.netscaler.nitro.service;

namespace com.citrix.netscaler.nitro.resource.config.vpn
{
  public class vpnglobal_binding : base_resource
  {
    private com.citrix.netscaler.nitro.resource.config.vpn.vpnglobal_intranetip6_binding[] vpnglobal_intranetip6_bindingField = (com.citrix.netscaler.nitro.resource.config.vpn.vpnglobal_intranetip6_binding[]) null;
    private com.citrix.netscaler.nitro.resource.config.vpn.vpnglobal_auditnslogpolicy_binding[] vpnglobal_auditnslogpolicy_bindingField = (com.citrix.netscaler.nitro.resource.config.vpn.vpnglobal_auditnslogpolicy_binding[]) null;
    private com.citrix.netscaler.nitro.resource.config.vpn.vpnglobal_authenticationpolicy_binding[] vpnglobal_authenticationpolicy_bindingField = (com.citrix.netscaler.nitro.resource.config.vpn.vpnglobal_authenticationpolicy_binding[]) null;
    private com.citrix.netscaler.nitro.resource.config.vpn.vpnglobal_authenticationradiuspolicy_binding[] vpnglobal_authenticationradiuspolicy_bindingField = (com.citrix.netscaler.nitro.resource.config.vpn.vpnglobal_authenticationradiuspolicy_binding[]) null;
    private com.citrix.netscaler.nitro.resource.config.vpn.vpnglobal_vpnsessionpolicy_binding[] vpnglobal_vpnsessionpolicy_bindingField = (com.citrix.netscaler.nitro.resource.config.vpn.vpnglobal_vpnsessionpolicy_binding[]) null;
    private com.citrix.netscaler.nitro.resource.config.vpn.vpnglobal_domain_binding[] vpnglobal_domain_bindingField = (com.citrix.netscaler.nitro.resource.config.vpn.vpnglobal_domain_binding[]) null;
    private com.citrix.netscaler.nitro.resource.config.vpn.vpnglobal_vpneula_binding[] vpnglobal_vpneula_bindingField = (com.citrix.netscaler.nitro.resource.config.vpn.vpnglobal_vpneula_binding[]) null;
    private com.citrix.netscaler.nitro.resource.config.vpn.vpnglobal_vpnclientlessaccesspolicy_binding[] vpnglobal_vpnclientlessaccesspolicy_bindingField = (com.citrix.netscaler.nitro.resource.config.vpn.vpnglobal_vpnclientlessaccesspolicy_binding[]) null;
    private com.citrix.netscaler.nitro.resource.config.vpn.vpnglobal_intranetip_binding[] vpnglobal_intranetip_bindingField = (com.citrix.netscaler.nitro.resource.config.vpn.vpnglobal_intranetip_binding[]) null;
    private com.citrix.netscaler.nitro.resource.config.vpn.vpnglobal_vpnnexthopserver_binding[] vpnglobal_vpnnexthopserver_bindingField = (com.citrix.netscaler.nitro.resource.config.vpn.vpnglobal_vpnnexthopserver_binding[]) null;
    private com.citrix.netscaler.nitro.resource.config.vpn.vpnglobal_authenticationldappolicy_binding[] vpnglobal_authenticationldappolicy_bindingField = (com.citrix.netscaler.nitro.resource.config.vpn.vpnglobal_authenticationldappolicy_binding[]) null;
    private com.citrix.netscaler.nitro.resource.config.vpn.vpnglobal_sharefileserver_binding[] vpnglobal_sharefileserver_bindingField = (com.citrix.netscaler.nitro.resource.config.vpn.vpnglobal_sharefileserver_binding[]) null;
    private com.citrix.netscaler.nitro.resource.config.vpn.vpnglobal_vpntrafficpolicy_binding[] vpnglobal_vpntrafficpolicy_bindingField = (com.citrix.netscaler.nitro.resource.config.vpn.vpnglobal_vpntrafficpolicy_binding[]) null;
    private com.citrix.netscaler.nitro.resource.config.vpn.vpnglobal_authenticationlocalpolicy_binding[] vpnglobal_authenticationlocalpolicy_bindingField = (com.citrix.netscaler.nitro.resource.config.vpn.vpnglobal_authenticationlocalpolicy_binding[]) null;
    private com.citrix.netscaler.nitro.resource.config.vpn.vpnglobal_vpnintranetapplication_binding[] vpnglobal_vpnintranetapplication_bindingField = (com.citrix.netscaler.nitro.resource.config.vpn.vpnglobal_vpnintranetapplication_binding[]) null;
    private com.citrix.netscaler.nitro.resource.config.vpn.vpnglobal_appcontroller_binding[] vpnglobal_appcontroller_bindingField = (com.citrix.netscaler.nitro.resource.config.vpn.vpnglobal_appcontroller_binding[]) null;
    private com.citrix.netscaler.nitro.resource.config.vpn.vpnglobal_authenticationnegotiatepolicy_binding[] vpnglobal_authenticationnegotiatepolicy_bindingField = (com.citrix.netscaler.nitro.resource.config.vpn.vpnglobal_authenticationnegotiatepolicy_binding[]) null;
    private com.citrix.netscaler.nitro.resource.config.vpn.vpnglobal_authenticationtacacspolicy_binding[] vpnglobal_authenticationtacacspolicy_bindingField = (com.citrix.netscaler.nitro.resource.config.vpn.vpnglobal_authenticationtacacspolicy_binding[]) null;
    private com.citrix.netscaler.nitro.resource.config.vpn.vpnglobal_vpnportaltheme_binding[] vpnglobal_vpnportaltheme_bindingField = (com.citrix.netscaler.nitro.resource.config.vpn.vpnglobal_vpnportaltheme_binding[]) null;
    private com.citrix.netscaler.nitro.resource.config.vpn.vpnglobal_authenticationsamlpolicy_binding[] vpnglobal_authenticationsamlpolicy_bindingField = (com.citrix.netscaler.nitro.resource.config.vpn.vpnglobal_authenticationsamlpolicy_binding[]) null;
    private com.citrix.netscaler.nitro.resource.config.vpn.vpnglobal_staserver_binding[] vpnglobal_staserver_bindingField = (com.citrix.netscaler.nitro.resource.config.vpn.vpnglobal_staserver_binding[]) null;
    private com.citrix.netscaler.nitro.resource.config.vpn.vpnglobal_auditsyslogpolicy_binding[] vpnglobal_auditsyslogpolicy_bindingField = (com.citrix.netscaler.nitro.resource.config.vpn.vpnglobal_auditsyslogpolicy_binding[]) null;
    private com.citrix.netscaler.nitro.resource.config.vpn.vpnglobal_authenticationcertpolicy_binding[] vpnglobal_authenticationcertpolicy_bindingField = (com.citrix.netscaler.nitro.resource.config.vpn.vpnglobal_authenticationcertpolicy_binding[]) null;
    private com.citrix.netscaler.nitro.resource.config.vpn.vpnglobal_vpnurl_binding[] vpnglobal_vpnurl_bindingField = (com.citrix.netscaler.nitro.resource.config.vpn.vpnglobal_vpnurl_binding[]) null;

    public com.citrix.netscaler.nitro.resource.config.vpn.vpnglobal_vpnintranetapplication_binding[] vpnglobal_vpnintranetapplication_binding
    {
      get => this.vpnglobal_vpnintranetapplication_bindingField;
      private set => this.vpnglobal_vpnintranetapplication_bindingField = value;
    }

    public com.citrix.netscaler.nitro.resource.config.vpn.vpnglobal_authenticationsamlpolicy_binding[] vpnglobal_authenticationsamlpolicy_binding
    {
      get => this.vpnglobal_authenticationsamlpolicy_bindingField;
      private set => this.vpnglobal_authenticationsamlpolicy_bindingField = value;
    }

    public com.citrix.netscaler.nitro.resource.config.vpn.vpnglobal_intranetip_binding[] vpnglobal_intranetip_binding
    {
      get => this.vpnglobal_intranetip_bindingField;
      private set => this.vpnglobal_intranetip_bindingField = value;
    }

    public com.citrix.netscaler.nitro.resource.config.vpn.vpnglobal_authenticationradiuspolicy_binding[] vpnglobal_authenticationradiuspolicy_binding
    {
      get => this.vpnglobal_authenticationradiuspolicy_bindingField;
      private set => this.vpnglobal_authenticationradiuspolicy_bindingField = value;
    }

    public com.citrix.netscaler.nitro.resource.config.vpn.vpnglobal_staserver_binding[] vpnglobal_staserver_binding
    {
      get => this.vpnglobal_staserver_bindingField;
      private set => this.vpnglobal_staserver_bindingField = value;
    }

    public com.citrix.netscaler.nitro.resource.config.vpn.vpnglobal_sharefileserver_binding[] vpnglobal_sharefileserver_binding
    {
      get => this.vpnglobal_sharefileserver_bindingField;
      private set => this.vpnglobal_sharefileserver_bindingField = value;
    }

    public com.citrix.netscaler.nitro.resource.config.vpn.vpnglobal_intranetip6_binding[] vpnglobal_intranetip6_binding
    {
      get => this.vpnglobal_intranetip6_bindingField;
      private set => this.vpnglobal_intranetip6_bindingField = value;
    }

    public com.citrix.netscaler.nitro.resource.config.vpn.vpnglobal_appcontroller_binding[] vpnglobal_appcontroller_binding
    {
      get => this.vpnglobal_appcontroller_bindingField;
      private set => this.vpnglobal_appcontroller_bindingField = value;
    }

    public com.citrix.netscaler.nitro.resource.config.vpn.vpnglobal_authenticationtacacspolicy_binding[] vpnglobal_authenticationtacacspolicy_binding
    {
      get => this.vpnglobal_authenticationtacacspolicy_bindingField;
      private set => this.vpnglobal_authenticationtacacspolicy_bindingField = value;
    }

    public com.citrix.netscaler.nitro.resource.config.vpn.vpnglobal_authenticationpolicy_binding[] vpnglobal_authenticationpolicy_binding
    {
      get => this.vpnglobal_authenticationpolicy_bindingField;
      private set => this.vpnglobal_authenticationpolicy_bindingField = value;
    }

    public com.citrix.netscaler.nitro.resource.config.vpn.vpnglobal_vpntrafficpolicy_binding[] vpnglobal_vpntrafficpolicy_binding
    {
      get => this.vpnglobal_vpntrafficpolicy_bindingField;
      private set => this.vpnglobal_vpntrafficpolicy_bindingField = value;
    }

    public com.citrix.netscaler.nitro.resource.config.vpn.vpnglobal_domain_binding[] vpnglobal_domain_binding
    {
      get => this.vpnglobal_domain_bindingField;
      private set => this.vpnglobal_domain_bindingField = value;
    }

    public com.citrix.netscaler.nitro.resource.config.vpn.vpnglobal_vpnnexthopserver_binding[] vpnglobal_vpnnexthopserver_binding
    {
      get => this.vpnglobal_vpnnexthopserver_bindingField;
      private set => this.vpnglobal_vpnnexthopserver_bindingField = value;
    }

    public com.citrix.netscaler.nitro.resource.config.vpn.vpnglobal_authenticationldappolicy_binding[] vpnglobal_authenticationldappolicy_binding
    {
      get => this.vpnglobal_authenticationldappolicy_bindingField;
      private set => this.vpnglobal_authenticationldappolicy_bindingField = value;
    }

    public com.citrix.netscaler.nitro.resource.config.vpn.vpnglobal_vpnsessionpolicy_binding[] vpnglobal_vpnsessionpolicy_binding
    {
      get => this.vpnglobal_vpnsessionpolicy_bindingField;
      private set => this.vpnglobal_vpnsessionpolicy_bindingField = value;
    }

    public com.citrix.netscaler.nitro.resource.config.vpn.vpnglobal_authenticationcertpolicy_binding[] vpnglobal_authenticationcertpolicy_binding
    {
      get => this.vpnglobal_authenticationcertpolicy_bindingField;
      private set => this.vpnglobal_authenticationcertpolicy_bindingField = value;
    }

    public com.citrix.netscaler.nitro.resource.config.vpn.vpnglobal_authenticationnegotiatepolicy_binding[] vpnglobal_authenticationnegotiatepolicy_binding
    {
      get => this.vpnglobal_authenticationnegotiatepolicy_bindingField;
      private set => this.vpnglobal_authenticationnegotiatepolicy_bindingField = value;
    }

    public com.citrix.netscaler.nitro.resource.config.vpn.vpnglobal_auditsyslogpolicy_binding[] vpnglobal_auditsyslogpolicy_binding
    {
      get => this.vpnglobal_auditsyslogpolicy_bindingField;
      private set => this.vpnglobal_auditsyslogpolicy_bindingField = value;
    }

    public com.citrix.netscaler.nitro.resource.config.vpn.vpnglobal_vpneula_binding[] vpnglobal_vpneula_binding
    {
      get => this.vpnglobal_vpneula_bindingField;
      private set => this.vpnglobal_vpneula_bindingField = value;
    }

    public com.citrix.netscaler.nitro.resource.config.vpn.vpnglobal_vpnurl_binding[] vpnglobal_vpnurl_binding
    {
      get => this.vpnglobal_vpnurl_bindingField;
      private set => this.vpnglobal_vpnurl_bindingField = value;
    }

    public com.citrix.netscaler.nitro.resource.config.vpn.vpnglobal_vpnportaltheme_binding[] vpnglobal_vpnportaltheme_binding
    {
      get => this.vpnglobal_vpnportaltheme_bindingField;
      private set => this.vpnglobal_vpnportaltheme_bindingField = value;
    }

    public com.citrix.netscaler.nitro.resource.config.vpn.vpnglobal_vpnclientlessaccesspolicy_binding[] vpnglobal_vpnclientlessaccesspolicy_binding
    {
      get => this.vpnglobal_vpnclientlessaccesspolicy_bindingField;
      private set => this.vpnglobal_vpnclientlessaccesspolicy_bindingField = value;
    }

    public com.citrix.netscaler.nitro.resource.config.vpn.vpnglobal_authenticationlocalpolicy_binding[] vpnglobal_authenticationlocalpolicy_binding
    {
      get => this.vpnglobal_authenticationlocalpolicy_bindingField;
      private set => this.vpnglobal_authenticationlocalpolicy_bindingField = value;
    }

    public com.citrix.netscaler.nitro.resource.config.vpn.vpnglobal_auditnslogpolicy_binding[] vpnglobal_auditnslogpolicy_binding
    {
      get => this.vpnglobal_auditnslogpolicy_bindingField;
      private set => this.vpnglobal_auditnslogpolicy_bindingField = value;
    }

    internal override base_resource[] get_nitro_response(
      nitro_service service,
      string response)
    {
      vpnglobal_binding.vpnglobal_binding_response vpnglobalBindingResponse = new vpnglobal_binding.vpnglobal_binding_response();
      vpnglobal_binding.vpnglobal_binding_response resource = (vpnglobal_binding.vpnglobal_binding_response) service.get_payload_formatter().string_to_resource(vpnglobalBindingResponse.GetType(), response);
      if (resource.errorcode != 0)
      {
        if (resource.errorcode == 444)
          service.clear_session();
        if (resource.severity == null)
          throw new nitro_exception(resource.message, resource.errorcode);
        if (resource.severity.Equals("ERROR"))
          throw new nitro_exception(resource.message, resource.errorcode);
      }
      return (base_resource[]) resource.vpnglobal_binding;
    }

    internal override string get_object_name() => (string) null;

    public static vpnglobal_binding get(nitro_service service) => (vpnglobal_binding) new vpnglobal_binding().get_resource(service);

    private class vpnglobal_binding_response : base_response
    {
      public vpnglobal_binding[] vpnglobal_binding = (vpnglobal_binding[]) null;
    }
  }
}
