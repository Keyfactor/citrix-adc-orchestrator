// Decompiled with JetBrains decompiler
// Type: com.citrix.netscaler.nitro.resource.config.aaa.aaagroup_binding
// Assembly: nitro, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 6CF5DDEF-E052-4F9D-953F-6644F8378A66


using com.citrix.netscaler.nitro.exception;
using com.citrix.netscaler.nitro.resource.Base;
using com.citrix.netscaler.nitro.service;

namespace com.citrix.netscaler.nitro.resource.config.aaa
{
  public class aaagroup_binding : base_resource
  {
    private string groupnameField = (string) null;
    private com.citrix.netscaler.nitro.resource.config.aaa.aaagroup_auditnslogpolicy_binding[] aaagroup_auditnslogpolicy_bindingField = (com.citrix.netscaler.nitro.resource.config.aaa.aaagroup_auditnslogpolicy_binding[]) null;
    private com.citrix.netscaler.nitro.resource.config.aaa.aaagroup_intranetip6_binding[] aaagroup_intranetip6_bindingField = (com.citrix.netscaler.nitro.resource.config.aaa.aaagroup_intranetip6_binding[]) null;
    private com.citrix.netscaler.nitro.resource.config.aaa.aaagroup_vpnsessionpolicy_binding[] aaagroup_vpnsessionpolicy_bindingField = (com.citrix.netscaler.nitro.resource.config.aaa.aaagroup_vpnsessionpolicy_binding[]) null;
    private com.citrix.netscaler.nitro.resource.config.aaa.aaagroup_intranetip_binding[] aaagroup_intranetip_bindingField = (com.citrix.netscaler.nitro.resource.config.aaa.aaagroup_intranetip_binding[]) null;
    private com.citrix.netscaler.nitro.resource.config.aaa.aaagroup_aaauser_binding[] aaagroup_aaauser_bindingField = (com.citrix.netscaler.nitro.resource.config.aaa.aaagroup_aaauser_binding[]) null;
    private com.citrix.netscaler.nitro.resource.config.aaa.aaagroup_vpntrafficpolicy_binding[] aaagroup_vpntrafficpolicy_bindingField = (com.citrix.netscaler.nitro.resource.config.aaa.aaagroup_vpntrafficpolicy_binding[]) null;
    private com.citrix.netscaler.nitro.resource.config.aaa.aaagroup_vpnintranetapplication_binding[] aaagroup_vpnintranetapplication_bindingField = (com.citrix.netscaler.nitro.resource.config.aaa.aaagroup_vpnintranetapplication_binding[]) null;
    private com.citrix.netscaler.nitro.resource.config.aaa.aaagroup_authorizationpolicy_binding[] aaagroup_authorizationpolicy_bindingField = (com.citrix.netscaler.nitro.resource.config.aaa.aaagroup_authorizationpolicy_binding[]) null;
    private com.citrix.netscaler.nitro.resource.config.aaa.aaagroup_auditsyslogpolicy_binding[] aaagroup_auditsyslogpolicy_bindingField = (com.citrix.netscaler.nitro.resource.config.aaa.aaagroup_auditsyslogpolicy_binding[]) null;
    private com.citrix.netscaler.nitro.resource.config.aaa.aaagroup_vpnurl_binding[] aaagroup_vpnurl_bindingField = (com.citrix.netscaler.nitro.resource.config.aaa.aaagroup_vpnurl_binding[]) null;
    private com.citrix.netscaler.nitro.resource.config.aaa.aaagroup_tmsessionpolicy_binding[] aaagroup_tmsessionpolicy_bindingField = (com.citrix.netscaler.nitro.resource.config.aaa.aaagroup_tmsessionpolicy_binding[]) null;

    public string groupname
    {
      get => this.groupnameField;
      set => this.groupnameField = value;
    }

    public com.citrix.netscaler.nitro.resource.config.aaa.aaagroup_vpntrafficpolicy_binding[] aaagroup_vpntrafficpolicy_binding
    {
      get => this.aaagroup_vpntrafficpolicy_bindingField;
      private set => this.aaagroup_vpntrafficpolicy_bindingField = value;
    }

    public com.citrix.netscaler.nitro.resource.config.aaa.aaagroup_authorizationpolicy_binding[] aaagroup_authorizationpolicy_binding
    {
      get => this.aaagroup_authorizationpolicy_bindingField;
      private set => this.aaagroup_authorizationpolicy_bindingField = value;
    }

    public com.citrix.netscaler.nitro.resource.config.aaa.aaagroup_intranetip_binding[] aaagroup_intranetip_binding
    {
      get => this.aaagroup_intranetip_bindingField;
      private set => this.aaagroup_intranetip_bindingField = value;
    }

    public com.citrix.netscaler.nitro.resource.config.aaa.aaagroup_intranetip6_binding[] aaagroup_intranetip6_binding
    {
      get => this.aaagroup_intranetip6_bindingField;
      private set => this.aaagroup_intranetip6_bindingField = value;
    }

    public com.citrix.netscaler.nitro.resource.config.aaa.aaagroup_auditnslogpolicy_binding[] aaagroup_auditnslogpolicy_binding
    {
      get => this.aaagroup_auditnslogpolicy_bindingField;
      private set => this.aaagroup_auditnslogpolicy_bindingField = value;
    }

    public com.citrix.netscaler.nitro.resource.config.aaa.aaagroup_vpnurl_binding[] aaagroup_vpnurl_binding
    {
      get => this.aaagroup_vpnurl_bindingField;
      private set => this.aaagroup_vpnurl_bindingField = value;
    }

    public com.citrix.netscaler.nitro.resource.config.aaa.aaagroup_auditsyslogpolicy_binding[] aaagroup_auditsyslogpolicy_binding
    {
      get => this.aaagroup_auditsyslogpolicy_bindingField;
      private set => this.aaagroup_auditsyslogpolicy_bindingField = value;
    }

    public com.citrix.netscaler.nitro.resource.config.aaa.aaagroup_aaauser_binding[] aaagroup_aaauser_binding
    {
      get => this.aaagroup_aaauser_bindingField;
      private set => this.aaagroup_aaauser_bindingField = value;
    }

    public com.citrix.netscaler.nitro.resource.config.aaa.aaagroup_tmsessionpolicy_binding[] aaagroup_tmsessionpolicy_binding
    {
      get => this.aaagroup_tmsessionpolicy_bindingField;
      private set => this.aaagroup_tmsessionpolicy_bindingField = value;
    }

    public com.citrix.netscaler.nitro.resource.config.aaa.aaagroup_vpnsessionpolicy_binding[] aaagroup_vpnsessionpolicy_binding
    {
      get => this.aaagroup_vpnsessionpolicy_bindingField;
      private set => this.aaagroup_vpnsessionpolicy_bindingField = value;
    }

    public com.citrix.netscaler.nitro.resource.config.aaa.aaagroup_vpnintranetapplication_binding[] aaagroup_vpnintranetapplication_binding
    {
      get => this.aaagroup_vpnintranetapplication_bindingField;
      private set => this.aaagroup_vpnintranetapplication_bindingField = value;
    }

    internal override base_resource[] get_nitro_response(
      nitro_service service,
      string response)
    {
      aaagroup_binding.aaagroup_binding_response aaagroupBindingResponse = new aaagroup_binding.aaagroup_binding_response();
      aaagroup_binding.aaagroup_binding_response resource = (aaagroup_binding.aaagroup_binding_response) service.get_payload_formatter().string_to_resource(aaagroupBindingResponse.GetType(), response);
      if (resource.errorcode != 0)
      {
        if (resource.errorcode == 444)
          service.clear_session();
        if (resource.severity == null)
          throw new nitro_exception(resource.message, resource.errorcode);
        if (resource.severity.Equals("ERROR"))
          throw new nitro_exception(resource.message, resource.errorcode);
      }
      return (base_resource[]) resource.aaagroup_binding;
    }

    internal override string get_object_name() => this.groupname;

    public static aaagroup_binding get(nitro_service service, string groupname) => (aaagroup_binding) new aaagroup_binding()
    {
      groupname = groupname
    }.get_resource(service);

    public static aaagroup_binding[] get(nitro_service service, string[] groupname)
    {
      if (groupname == null || groupname.Length <= 0)
        return (aaagroup_binding[]) null;
      aaagroup_binding[] aaagroupBindingArray1 = new aaagroup_binding[groupname.Length];
      aaagroup_binding[] aaagroupBindingArray2 = new aaagroup_binding[groupname.Length];
      for (int index = 0; index < groupname.Length; ++index)
      {
        aaagroupBindingArray2[index] = new aaagroup_binding();
        aaagroupBindingArray2[index].groupname = groupname[index];
        aaagroupBindingArray1[index] = (aaagroup_binding) aaagroupBindingArray2[index].get_resource(service);
      }
      return aaagroupBindingArray1;
    }

    private class aaagroup_binding_response : base_response
    {
      public aaagroup_binding[] aaagroup_binding = (aaagroup_binding[]) null;
    }
  }
}
