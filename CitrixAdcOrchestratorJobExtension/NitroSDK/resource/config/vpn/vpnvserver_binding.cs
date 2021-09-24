// Decompiled with JetBrains decompiler
// Type: com.citrix.netscaler.nitro.resource.config.vpn.vpnvserver_binding
// Assembly: nitro, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 6CF5DDEF-E052-4F9D-953F-6644F8378A66


using com.citrix.netscaler.nitro.exception;
using com.citrix.netscaler.nitro.resource.Base;
using com.citrix.netscaler.nitro.service;

namespace com.citrix.netscaler.nitro.resource.config.vpn
{
  public class vpnvserver_binding : base_resource
  {
    private string nameField = (string) null;
    private com.citrix.netscaler.nitro.resource.config.vpn.vpnvserver_intranetip6_binding[] vpnvserver_intranetip6_bindingField = (com.citrix.netscaler.nitro.resource.config.vpn.vpnvserver_intranetip6_binding[]) null;
    private com.citrix.netscaler.nitro.resource.config.vpn.vpnvserver_authenticationradiuspolicy_binding[] vpnvserver_authenticationradiuspolicy_bindingField = (com.citrix.netscaler.nitro.resource.config.vpn.vpnvserver_authenticationradiuspolicy_binding[]) null;
    private com.citrix.netscaler.nitro.resource.config.vpn.vpnvserver_vpnsessionpolicy_binding[] vpnvserver_vpnsessionpolicy_bindingField = (com.citrix.netscaler.nitro.resource.config.vpn.vpnvserver_vpnsessionpolicy_binding[]) null;
    private com.citrix.netscaler.nitro.resource.config.vpn.vpnvserver_vpnnexthopserver_binding[] vpnvserver_vpnnexthopserver_bindingField = (com.citrix.netscaler.nitro.resource.config.vpn.vpnvserver_vpnnexthopserver_binding[]) null;
    private com.citrix.netscaler.nitro.resource.config.vpn.vpnvserver_authenticationldappolicy_binding[] vpnvserver_authenticationldappolicy_bindingField = (com.citrix.netscaler.nitro.resource.config.vpn.vpnvserver_authenticationldappolicy_binding[]) null;
    private com.citrix.netscaler.nitro.resource.config.vpn.vpnvserver_authenticationsamlidppolicy_binding[] vpnvserver_authenticationsamlidppolicy_bindingField = (com.citrix.netscaler.nitro.resource.config.vpn.vpnvserver_authenticationsamlidppolicy_binding[]) null;
    private com.citrix.netscaler.nitro.resource.config.vpn.vpnvserver_authenticationwebauthpolicy_binding[] vpnvserver_authenticationwebauthpolicy_bindingField = (com.citrix.netscaler.nitro.resource.config.vpn.vpnvserver_authenticationwebauthpolicy_binding[]) null;
    private com.citrix.netscaler.nitro.resource.config.vpn.vpnvserver_sharefileserver_binding[] vpnvserver_sharefileserver_bindingField = (com.citrix.netscaler.nitro.resource.config.vpn.vpnvserver_sharefileserver_binding[]) null;
    private com.citrix.netscaler.nitro.resource.config.vpn.vpnvserver_authenticationlocalpolicy_binding[] vpnvserver_authenticationlocalpolicy_bindingField = (com.citrix.netscaler.nitro.resource.config.vpn.vpnvserver_authenticationlocalpolicy_binding[]) null;
    private com.citrix.netscaler.nitro.resource.config.vpn.vpnvserver_vpnintranetapplication_binding[] vpnvserver_vpnintranetapplication_bindingField = (com.citrix.netscaler.nitro.resource.config.vpn.vpnvserver_vpnintranetapplication_binding[]) null;
    private com.citrix.netscaler.nitro.resource.config.vpn.vpnvserver_appcontroller_binding[] vpnvserver_appcontroller_bindingField = (com.citrix.netscaler.nitro.resource.config.vpn.vpnvserver_appcontroller_binding[]) null;
    private com.citrix.netscaler.nitro.resource.config.vpn.vpnvserver_rewritepolicy_binding[] vpnvserver_rewritepolicy_bindingField = (com.citrix.netscaler.nitro.resource.config.vpn.vpnvserver_rewritepolicy_binding[]) null;
    private com.citrix.netscaler.nitro.resource.config.vpn.vpnvserver_vpnportaltheme_binding[] vpnvserver_vpnportaltheme_bindingField = (com.citrix.netscaler.nitro.resource.config.vpn.vpnvserver_vpnportaltheme_binding[]) null;
    private com.citrix.netscaler.nitro.resource.config.vpn.vpnvserver_cspolicy_binding[] vpnvserver_cspolicy_bindingField = (com.citrix.netscaler.nitro.resource.config.vpn.vpnvserver_cspolicy_binding[]) null;
    private com.citrix.netscaler.nitro.resource.config.vpn.vpnvserver_auditsyslogpolicy_binding[] vpnvserver_auditsyslogpolicy_bindingField = (com.citrix.netscaler.nitro.resource.config.vpn.vpnvserver_auditsyslogpolicy_binding[]) null;
    private com.citrix.netscaler.nitro.resource.config.vpn.vpnvserver_authenticationcertpolicy_binding[] vpnvserver_authenticationcertpolicy_bindingField = (com.citrix.netscaler.nitro.resource.config.vpn.vpnvserver_authenticationcertpolicy_binding[]) null;
    private com.citrix.netscaler.nitro.resource.config.vpn.vpnvserver_vpnepaprofile_binding[] vpnvserver_vpnepaprofile_bindingField = (com.citrix.netscaler.nitro.resource.config.vpn.vpnvserver_vpnepaprofile_binding[]) null;
    private com.citrix.netscaler.nitro.resource.config.vpn.vpnvserver_vpnurl_binding[] vpnvserver_vpnurl_bindingField = (com.citrix.netscaler.nitro.resource.config.vpn.vpnvserver_vpnurl_binding[]) null;
    private com.citrix.netscaler.nitro.resource.config.vpn.vpnvserver_auditnslogpolicy_binding[] vpnvserver_auditnslogpolicy_bindingField = (com.citrix.netscaler.nitro.resource.config.vpn.vpnvserver_auditnslogpolicy_binding[]) null;
    private com.citrix.netscaler.nitro.resource.config.vpn.vpnvserver_authenticationpolicy_binding[] vpnvserver_authenticationpolicy_bindingField = (com.citrix.netscaler.nitro.resource.config.vpn.vpnvserver_authenticationpolicy_binding[]) null;
    private com.citrix.netscaler.nitro.resource.config.vpn.vpnvserver_vpneula_binding[] vpnvserver_vpneula_bindingField = (com.citrix.netscaler.nitro.resource.config.vpn.vpnvserver_vpneula_binding[]) null;
    private com.citrix.netscaler.nitro.resource.config.vpn.vpnvserver_icapolicy_binding[] vpnvserver_icapolicy_bindingField = (com.citrix.netscaler.nitro.resource.config.vpn.vpnvserver_icapolicy_binding[]) null;
    private com.citrix.netscaler.nitro.resource.config.vpn.vpnvserver_vpnclientlessaccesspolicy_binding[] vpnvserver_vpnclientlessaccesspolicy_bindingField = (com.citrix.netscaler.nitro.resource.config.vpn.vpnvserver_vpnclientlessaccesspolicy_binding[]) null;
    private com.citrix.netscaler.nitro.resource.config.vpn.vpnvserver_intranetip_binding[] vpnvserver_intranetip_bindingField = (com.citrix.netscaler.nitro.resource.config.vpn.vpnvserver_intranetip_binding[]) null;
    private com.citrix.netscaler.nitro.resource.config.vpn.vpnvserver_appflowpolicy_binding[] vpnvserver_appflowpolicy_bindingField = (com.citrix.netscaler.nitro.resource.config.vpn.vpnvserver_appflowpolicy_binding[]) null;
    private com.citrix.netscaler.nitro.resource.config.vpn.vpnvserver_responderpolicy_binding[] vpnvserver_responderpolicy_bindingField = (com.citrix.netscaler.nitro.resource.config.vpn.vpnvserver_responderpolicy_binding[]) null;
    private com.citrix.netscaler.nitro.resource.config.vpn.vpnvserver_vpntrafficpolicy_binding[] vpnvserver_vpntrafficpolicy_bindingField = (com.citrix.netscaler.nitro.resource.config.vpn.vpnvserver_vpntrafficpolicy_binding[]) null;
    private com.citrix.netscaler.nitro.resource.config.vpn.vpnvserver_authenticationnegotiatepolicy_binding[] vpnvserver_authenticationnegotiatepolicy_bindingField = (com.citrix.netscaler.nitro.resource.config.vpn.vpnvserver_authenticationnegotiatepolicy_binding[]) null;
    private com.citrix.netscaler.nitro.resource.config.vpn.vpnvserver_aaapreauthenticationpolicy_binding[] vpnvserver_aaapreauthenticationpolicy_bindingField = (com.citrix.netscaler.nitro.resource.config.vpn.vpnvserver_aaapreauthenticationpolicy_binding[]) null;
    private com.citrix.netscaler.nitro.resource.config.vpn.vpnvserver_feopolicy_binding[] vpnvserver_feopolicy_bindingField = (com.citrix.netscaler.nitro.resource.config.vpn.vpnvserver_feopolicy_binding[]) null;
    private com.citrix.netscaler.nitro.resource.config.vpn.vpnvserver_authenticationtacacspolicy_binding[] vpnvserver_authenticationtacacspolicy_bindingField = (com.citrix.netscaler.nitro.resource.config.vpn.vpnvserver_authenticationtacacspolicy_binding[]) null;
    private com.citrix.netscaler.nitro.resource.config.vpn.vpnvserver_cachepolicy_binding[] vpnvserver_cachepolicy_bindingField = (com.citrix.netscaler.nitro.resource.config.vpn.vpnvserver_cachepolicy_binding[]) null;
    private com.citrix.netscaler.nitro.resource.config.vpn.vpnvserver_authenticationsamlpolicy_binding[] vpnvserver_authenticationsamlpolicy_bindingField = (com.citrix.netscaler.nitro.resource.config.vpn.vpnvserver_authenticationsamlpolicy_binding[]) null;
    private com.citrix.netscaler.nitro.resource.config.vpn.vpnvserver_authenticationdfapolicy_binding[] vpnvserver_authenticationdfapolicy_bindingField = (com.citrix.netscaler.nitro.resource.config.vpn.vpnvserver_authenticationdfapolicy_binding[]) null;
    private com.citrix.netscaler.nitro.resource.config.vpn.vpnvserver_staserver_binding[] vpnvserver_staserver_bindingField = (com.citrix.netscaler.nitro.resource.config.vpn.vpnvserver_staserver_binding[]) null;
    private com.citrix.netscaler.nitro.resource.config.vpn.vpnvserver_authenticationloginschemapolicy_binding[] vpnvserver_authenticationloginschemapolicy_bindingField = (com.citrix.netscaler.nitro.resource.config.vpn.vpnvserver_authenticationloginschemapolicy_binding[]) null;

    public string name
    {
      get => this.nameField;
      set => this.nameField = value;
    }

    public com.citrix.netscaler.nitro.resource.config.vpn.vpnvserver_authenticationloginschemapolicy_binding[] vpnvserver_authenticationloginschemapolicy_binding
    {
      get => this.vpnvserver_authenticationloginschemapolicy_bindingField;
      private set => this.vpnvserver_authenticationloginschemapolicy_bindingField = value;
    }

    public com.citrix.netscaler.nitro.resource.config.vpn.vpnvserver_authenticationsamlpolicy_binding[] vpnvserver_authenticationsamlpolicy_binding
    {
      get => this.vpnvserver_authenticationsamlpolicy_bindingField;
      private set => this.vpnvserver_authenticationsamlpolicy_bindingField = value;
    }

    public com.citrix.netscaler.nitro.resource.config.vpn.vpnvserver_cspolicy_binding[] vpnvserver_cspolicy_binding
    {
      get => this.vpnvserver_cspolicy_bindingField;
      private set => this.vpnvserver_cspolicy_bindingField = value;
    }

    public com.citrix.netscaler.nitro.resource.config.vpn.vpnvserver_icapolicy_binding[] vpnvserver_icapolicy_binding
    {
      get => this.vpnvserver_icapolicy_bindingField;
      private set => this.vpnvserver_icapolicy_bindingField = value;
    }

    public com.citrix.netscaler.nitro.resource.config.vpn.vpnvserver_vpnportaltheme_binding[] vpnvserver_vpnportaltheme_binding
    {
      get => this.vpnvserver_vpnportaltheme_bindingField;
      private set => this.vpnvserver_vpnportaltheme_bindingField = value;
    }

    public com.citrix.netscaler.nitro.resource.config.vpn.vpnvserver_appflowpolicy_binding[] vpnvserver_appflowpolicy_binding
    {
      get => this.vpnvserver_appflowpolicy_bindingField;
      private set => this.vpnvserver_appflowpolicy_bindingField = value;
    }

    public com.citrix.netscaler.nitro.resource.config.vpn.vpnvserver_intranetip_binding[] vpnvserver_intranetip_binding
    {
      get => this.vpnvserver_intranetip_bindingField;
      private set => this.vpnvserver_intranetip_bindingField = value;
    }

    public com.citrix.netscaler.nitro.resource.config.vpn.vpnvserver_vpntrafficpolicy_binding[] vpnvserver_vpntrafficpolicy_binding
    {
      get => this.vpnvserver_vpntrafficpolicy_bindingField;
      private set => this.vpnvserver_vpntrafficpolicy_bindingField = value;
    }

    public com.citrix.netscaler.nitro.resource.config.vpn.vpnvserver_vpnepaprofile_binding[] vpnvserver_vpnepaprofile_binding
    {
      get => this.vpnvserver_vpnepaprofile_bindingField;
      private set => this.vpnvserver_vpnepaprofile_bindingField = value;
    }

    public com.citrix.netscaler.nitro.resource.config.vpn.vpnvserver_authenticationtacacspolicy_binding[] vpnvserver_authenticationtacacspolicy_binding
    {
      get => this.vpnvserver_authenticationtacacspolicy_bindingField;
      private set => this.vpnvserver_authenticationtacacspolicy_bindingField = value;
    }

    public com.citrix.netscaler.nitro.resource.config.vpn.vpnvserver_vpnintranetapplication_binding[] vpnvserver_vpnintranetapplication_binding
    {
      get => this.vpnvserver_vpnintranetapplication_bindingField;
      private set => this.vpnvserver_vpnintranetapplication_bindingField = value;
    }

    public com.citrix.netscaler.nitro.resource.config.vpn.vpnvserver_authenticationradiuspolicy_binding[] vpnvserver_authenticationradiuspolicy_binding
    {
      get => this.vpnvserver_authenticationradiuspolicy_bindingField;
      private set => this.vpnvserver_authenticationradiuspolicy_bindingField = value;
    }

    public com.citrix.netscaler.nitro.resource.config.vpn.vpnvserver_authenticationpolicy_binding[] vpnvserver_authenticationpolicy_binding
    {
      get => this.vpnvserver_authenticationpolicy_bindingField;
      private set => this.vpnvserver_authenticationpolicy_bindingField = value;
    }

    public com.citrix.netscaler.nitro.resource.config.vpn.vpnvserver_aaapreauthenticationpolicy_binding[] vpnvserver_aaapreauthenticationpolicy_binding
    {
      get => this.vpnvserver_aaapreauthenticationpolicy_bindingField;
      private set => this.vpnvserver_aaapreauthenticationpolicy_bindingField = value;
    }

    public com.citrix.netscaler.nitro.resource.config.vpn.vpnvserver_feopolicy_binding[] vpnvserver_feopolicy_binding
    {
      get => this.vpnvserver_feopolicy_bindingField;
      private set => this.vpnvserver_feopolicy_bindingField = value;
    }

    public com.citrix.netscaler.nitro.resource.config.vpn.vpnvserver_authenticationlocalpolicy_binding[] vpnvserver_authenticationlocalpolicy_binding
    {
      get => this.vpnvserver_authenticationlocalpolicy_bindingField;
      private set => this.vpnvserver_authenticationlocalpolicy_bindingField = value;
    }

    public com.citrix.netscaler.nitro.resource.config.vpn.vpnvserver_intranetip6_binding[] vpnvserver_intranetip6_binding
    {
      get => this.vpnvserver_intranetip6_bindingField;
      private set => this.vpnvserver_intranetip6_bindingField = value;
    }

    public com.citrix.netscaler.nitro.resource.config.vpn.vpnvserver_vpnsessionpolicy_binding[] vpnvserver_vpnsessionpolicy_binding
    {
      get => this.vpnvserver_vpnsessionpolicy_bindingField;
      private set => this.vpnvserver_vpnsessionpolicy_bindingField = value;
    }

    public com.citrix.netscaler.nitro.resource.config.vpn.vpnvserver_staserver_binding[] vpnvserver_staserver_binding
    {
      get => this.vpnvserver_staserver_bindingField;
      private set => this.vpnvserver_staserver_bindingField = value;
    }

    public com.citrix.netscaler.nitro.resource.config.vpn.vpnvserver_authenticationcertpolicy_binding[] vpnvserver_authenticationcertpolicy_binding
    {
      get => this.vpnvserver_authenticationcertpolicy_bindingField;
      private set => this.vpnvserver_authenticationcertpolicy_bindingField = value;
    }

    public com.citrix.netscaler.nitro.resource.config.vpn.vpnvserver_authenticationsamlidppolicy_binding[] vpnvserver_authenticationsamlidppolicy_binding
    {
      get => this.vpnvserver_authenticationsamlidppolicy_bindingField;
      private set => this.vpnvserver_authenticationsamlidppolicy_bindingField = value;
    }

    public com.citrix.netscaler.nitro.resource.config.vpn.vpnvserver_vpnnexthopserver_binding[] vpnvserver_vpnnexthopserver_binding
    {
      get => this.vpnvserver_vpnnexthopserver_bindingField;
      private set => this.vpnvserver_vpnnexthopserver_bindingField = value;
    }

    public com.citrix.netscaler.nitro.resource.config.vpn.vpnvserver_auditnslogpolicy_binding[] vpnvserver_auditnslogpolicy_binding
    {
      get => this.vpnvserver_auditnslogpolicy_bindingField;
      private set => this.vpnvserver_auditnslogpolicy_bindingField = value;
    }

    public com.citrix.netscaler.nitro.resource.config.vpn.vpnvserver_auditsyslogpolicy_binding[] vpnvserver_auditsyslogpolicy_binding
    {
      get => this.vpnvserver_auditsyslogpolicy_bindingField;
      private set => this.vpnvserver_auditsyslogpolicy_bindingField = value;
    }

    public com.citrix.netscaler.nitro.resource.config.vpn.vpnvserver_sharefileserver_binding[] vpnvserver_sharefileserver_binding
    {
      get => this.vpnvserver_sharefileserver_bindingField;
      private set => this.vpnvserver_sharefileserver_bindingField = value;
    }

    public com.citrix.netscaler.nitro.resource.config.vpn.vpnvserver_responderpolicy_binding[] vpnvserver_responderpolicy_binding
    {
      get => this.vpnvserver_responderpolicy_bindingField;
      private set => this.vpnvserver_responderpolicy_bindingField = value;
    }

    public com.citrix.netscaler.nitro.resource.config.vpn.vpnvserver_vpnurl_binding[] vpnvserver_vpnurl_binding
    {
      get => this.vpnvserver_vpnurl_bindingField;
      private set => this.vpnvserver_vpnurl_bindingField = value;
    }

    public com.citrix.netscaler.nitro.resource.config.vpn.vpnvserver_cachepolicy_binding[] vpnvserver_cachepolicy_binding
    {
      get => this.vpnvserver_cachepolicy_bindingField;
      private set => this.vpnvserver_cachepolicy_bindingField = value;
    }

    public com.citrix.netscaler.nitro.resource.config.vpn.vpnvserver_authenticationldappolicy_binding[] vpnvserver_authenticationldappolicy_binding
    {
      get => this.vpnvserver_authenticationldappolicy_bindingField;
      private set => this.vpnvserver_authenticationldappolicy_bindingField = value;
    }

    public com.citrix.netscaler.nitro.resource.config.vpn.vpnvserver_authenticationwebauthpolicy_binding[] vpnvserver_authenticationwebauthpolicy_binding
    {
      get => this.vpnvserver_authenticationwebauthpolicy_bindingField;
      private set => this.vpnvserver_authenticationwebauthpolicy_bindingField = value;
    }

    public com.citrix.netscaler.nitro.resource.config.vpn.vpnvserver_rewritepolicy_binding[] vpnvserver_rewritepolicy_binding
    {
      get => this.vpnvserver_rewritepolicy_bindingField;
      private set => this.vpnvserver_rewritepolicy_bindingField = value;
    }

    public com.citrix.netscaler.nitro.resource.config.vpn.vpnvserver_authenticationnegotiatepolicy_binding[] vpnvserver_authenticationnegotiatepolicy_binding
    {
      get => this.vpnvserver_authenticationnegotiatepolicy_bindingField;
      private set => this.vpnvserver_authenticationnegotiatepolicy_bindingField = value;
    }

    public com.citrix.netscaler.nitro.resource.config.vpn.vpnvserver_appcontroller_binding[] vpnvserver_appcontroller_binding
    {
      get => this.vpnvserver_appcontroller_bindingField;
      private set => this.vpnvserver_appcontroller_bindingField = value;
    }

    public com.citrix.netscaler.nitro.resource.config.vpn.vpnvserver_vpnclientlessaccesspolicy_binding[] vpnvserver_vpnclientlessaccesspolicy_binding
    {
      get => this.vpnvserver_vpnclientlessaccesspolicy_bindingField;
      private set => this.vpnvserver_vpnclientlessaccesspolicy_bindingField = value;
    }

    public com.citrix.netscaler.nitro.resource.config.vpn.vpnvserver_authenticationdfapolicy_binding[] vpnvserver_authenticationdfapolicy_binding
    {
      get => this.vpnvserver_authenticationdfapolicy_bindingField;
      private set => this.vpnvserver_authenticationdfapolicy_bindingField = value;
    }

    public com.citrix.netscaler.nitro.resource.config.vpn.vpnvserver_vpneula_binding[] vpnvserver_vpneula_binding
    {
      get => this.vpnvserver_vpneula_bindingField;
      private set => this.vpnvserver_vpneula_bindingField = value;
    }

    internal override base_resource[] get_nitro_response(
      nitro_service service,
      string response)
    {
      vpnvserver_binding.vpnvserver_binding_response vpnvserverBindingResponse = new vpnvserver_binding.vpnvserver_binding_response();
      vpnvserver_binding.vpnvserver_binding_response resource = (vpnvserver_binding.vpnvserver_binding_response) service.get_payload_formatter().string_to_resource(vpnvserverBindingResponse.GetType(), response);
      if (resource.errorcode != 0)
      {
        if (resource.errorcode == 444)
          service.clear_session();
        if (resource.severity == null)
          throw new nitro_exception(resource.message, resource.errorcode);
        if (resource.severity.Equals("ERROR"))
          throw new nitro_exception(resource.message, resource.errorcode);
      }
      return (base_resource[]) resource.vpnvserver_binding;
    }

    internal override string get_object_name() => this.name;

    public static vpnvserver_binding get(nitro_service service, string name) => (vpnvserver_binding) new vpnvserver_binding()
    {
      name = name
    }.get_resource(service);

    public static vpnvserver_binding[] get(nitro_service service, string[] name)
    {
      if (name == null || name.Length <= 0)
        return (vpnvserver_binding[]) null;
      vpnvserver_binding[] vpnvserverBindingArray1 = new vpnvserver_binding[name.Length];
      vpnvserver_binding[] vpnvserverBindingArray2 = new vpnvserver_binding[name.Length];
      for (int index = 0; index < name.Length; ++index)
      {
        vpnvserverBindingArray2[index] = new vpnvserver_binding();
        vpnvserverBindingArray2[index].name = name[index];
        vpnvserverBindingArray1[index] = (vpnvserver_binding) vpnvserverBindingArray2[index].get_resource(service);
      }
      return vpnvserverBindingArray1;
    }

    private class vpnvserver_binding_response : base_response
    {
      public vpnvserver_binding[] vpnvserver_binding = (vpnvserver_binding[]) null;
    }
  }
}
