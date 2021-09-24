// Decompiled with JetBrains decompiler
// Type: com.citrix.netscaler.nitro.resource.config.aaa.aaauser_binding
// Assembly: nitro, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 6CF5DDEF-E052-4F9D-953F-6644F8378A66


using com.citrix.netscaler.nitro.exception;
using com.citrix.netscaler.nitro.resource.Base;
using com.citrix.netscaler.nitro.service;

namespace com.citrix.netscaler.nitro.resource.config.aaa
{
  public class aaauser_binding : base_resource
  {
    private string usernameField = (string) null;
    private com.citrix.netscaler.nitro.resource.config.aaa.aaauser_auditnslogpolicy_binding[] aaauser_auditnslogpolicy_bindingField = (com.citrix.netscaler.nitro.resource.config.aaa.aaauser_auditnslogpolicy_binding[]) null;
    private com.citrix.netscaler.nitro.resource.config.aaa.aaauser_intranetip6_binding[] aaauser_intranetip6_bindingField = (com.citrix.netscaler.nitro.resource.config.aaa.aaauser_intranetip6_binding[]) null;
    private com.citrix.netscaler.nitro.resource.config.aaa.aaauser_vpnsessionpolicy_binding[] aaauser_vpnsessionpolicy_bindingField = (com.citrix.netscaler.nitro.resource.config.aaa.aaauser_vpnsessionpolicy_binding[]) null;
    private com.citrix.netscaler.nitro.resource.config.aaa.aaauser_intranetip_binding[] aaauser_intranetip_bindingField = (com.citrix.netscaler.nitro.resource.config.aaa.aaauser_intranetip_binding[]) null;
    private com.citrix.netscaler.nitro.resource.config.aaa.aaauser_vpntrafficpolicy_binding[] aaauser_vpntrafficpolicy_bindingField = (com.citrix.netscaler.nitro.resource.config.aaa.aaauser_vpntrafficpolicy_binding[]) null;
    private com.citrix.netscaler.nitro.resource.config.aaa.aaauser_vpnintranetapplication_binding[] aaauser_vpnintranetapplication_bindingField = (com.citrix.netscaler.nitro.resource.config.aaa.aaauser_vpnintranetapplication_binding[]) null;
    private com.citrix.netscaler.nitro.resource.config.aaa.aaauser_authorizationpolicy_binding[] aaauser_authorizationpolicy_bindingField = (com.citrix.netscaler.nitro.resource.config.aaa.aaauser_authorizationpolicy_binding[]) null;
    private com.citrix.netscaler.nitro.resource.config.aaa.aaauser_auditsyslogpolicy_binding[] aaauser_auditsyslogpolicy_bindingField = (com.citrix.netscaler.nitro.resource.config.aaa.aaauser_auditsyslogpolicy_binding[]) null;
    private com.citrix.netscaler.nitro.resource.config.aaa.aaauser_aaagroup_binding[] aaauser_aaagroup_bindingField = (com.citrix.netscaler.nitro.resource.config.aaa.aaauser_aaagroup_binding[]) null;
    private com.citrix.netscaler.nitro.resource.config.aaa.aaauser_vpnurl_binding[] aaauser_vpnurl_bindingField = (com.citrix.netscaler.nitro.resource.config.aaa.aaauser_vpnurl_binding[]) null;
    private com.citrix.netscaler.nitro.resource.config.aaa.aaauser_tmsessionpolicy_binding[] aaauser_tmsessionpolicy_bindingField = (com.citrix.netscaler.nitro.resource.config.aaa.aaauser_tmsessionpolicy_binding[]) null;

    public string username
    {
      get => this.usernameField;
      set => this.usernameField = value;
    }

    public com.citrix.netscaler.nitro.resource.config.aaa.aaauser_intranetip_binding[] aaauser_intranetip_binding
    {
      get => this.aaauser_intranetip_bindingField;
      private set => this.aaauser_intranetip_bindingField = value;
    }

    public com.citrix.netscaler.nitro.resource.config.aaa.aaauser_auditsyslogpolicy_binding[] aaauser_auditsyslogpolicy_binding
    {
      get => this.aaauser_auditsyslogpolicy_bindingField;
      private set => this.aaauser_auditsyslogpolicy_bindingField = value;
    }

    public com.citrix.netscaler.nitro.resource.config.aaa.aaauser_vpnintranetapplication_binding[] aaauser_vpnintranetapplication_binding
    {
      get => this.aaauser_vpnintranetapplication_bindingField;
      private set => this.aaauser_vpnintranetapplication_bindingField = value;
    }

    public com.citrix.netscaler.nitro.resource.config.aaa.aaauser_authorizationpolicy_binding[] aaauser_authorizationpolicy_binding
    {
      get => this.aaauser_authorizationpolicy_bindingField;
      private set => this.aaauser_authorizationpolicy_bindingField = value;
    }

    public com.citrix.netscaler.nitro.resource.config.aaa.aaauser_vpnurl_binding[] aaauser_vpnurl_binding
    {
      get => this.aaauser_vpnurl_bindingField;
      private set => this.aaauser_vpnurl_bindingField = value;
    }

    public com.citrix.netscaler.nitro.resource.config.aaa.aaauser_vpntrafficpolicy_binding[] aaauser_vpntrafficpolicy_binding
    {
      get => this.aaauser_vpntrafficpolicy_bindingField;
      private set => this.aaauser_vpntrafficpolicy_bindingField = value;
    }

    public com.citrix.netscaler.nitro.resource.config.aaa.aaauser_aaagroup_binding[] aaauser_aaagroup_binding
    {
      get => this.aaauser_aaagroup_bindingField;
      private set => this.aaauser_aaagroup_bindingField = value;
    }

    public com.citrix.netscaler.nitro.resource.config.aaa.aaauser_vpnsessionpolicy_binding[] aaauser_vpnsessionpolicy_binding
    {
      get => this.aaauser_vpnsessionpolicy_bindingField;
      private set => this.aaauser_vpnsessionpolicy_bindingField = value;
    }

    public com.citrix.netscaler.nitro.resource.config.aaa.aaauser_intranetip6_binding[] aaauser_intranetip6_binding
    {
      get => this.aaauser_intranetip6_bindingField;
      private set => this.aaauser_intranetip6_bindingField = value;
    }

    public com.citrix.netscaler.nitro.resource.config.aaa.aaauser_tmsessionpolicy_binding[] aaauser_tmsessionpolicy_binding
    {
      get => this.aaauser_tmsessionpolicy_bindingField;
      private set => this.aaauser_tmsessionpolicy_bindingField = value;
    }

    public com.citrix.netscaler.nitro.resource.config.aaa.aaauser_auditnslogpolicy_binding[] aaauser_auditnslogpolicy_binding
    {
      get => this.aaauser_auditnslogpolicy_bindingField;
      private set => this.aaauser_auditnslogpolicy_bindingField = value;
    }

    internal override base_resource[] get_nitro_response(
      nitro_service service,
      string response)
    {
      aaauser_binding.aaauser_binding_response aaauserBindingResponse = new aaauser_binding.aaauser_binding_response();
      aaauser_binding.aaauser_binding_response resource = (aaauser_binding.aaauser_binding_response) service.get_payload_formatter().string_to_resource(aaauserBindingResponse.GetType(), response);
      if (resource.errorcode != 0)
      {
        if (resource.errorcode == 444)
          service.clear_session();
        if (resource.severity == null)
          throw new nitro_exception(resource.message, resource.errorcode);
        if (resource.severity.Equals("ERROR"))
          throw new nitro_exception(resource.message, resource.errorcode);
      }
      return (base_resource[]) resource.aaauser_binding;
    }

    internal override string get_object_name() => this.username;

    public static aaauser_binding get(nitro_service service, string username) => (aaauser_binding) new aaauser_binding()
    {
      username = username
    }.get_resource(service);

    public static aaauser_binding[] get(nitro_service service, string[] username)
    {
      if (username == null || username.Length <= 0)
        return (aaauser_binding[]) null;
      aaauser_binding[] aaauserBindingArray1 = new aaauser_binding[username.Length];
      aaauser_binding[] aaauserBindingArray2 = new aaauser_binding[username.Length];
      for (int index = 0; index < username.Length; ++index)
      {
        aaauserBindingArray2[index] = new aaauser_binding();
        aaauserBindingArray2[index].username = username[index];
        aaauserBindingArray1[index] = (aaauser_binding) aaauserBindingArray2[index].get_resource(service);
      }
      return aaauserBindingArray1;
    }

    private class aaauser_binding_response : base_response
    {
      public aaauser_binding[] aaauser_binding = (aaauser_binding[]) null;
    }
  }
}
