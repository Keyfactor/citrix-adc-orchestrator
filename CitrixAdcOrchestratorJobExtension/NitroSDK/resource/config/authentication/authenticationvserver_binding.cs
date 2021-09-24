// Decompiled with JetBrains decompiler
// Type: com.citrix.netscaler.nitro.resource.config.authentication.authenticationvserver_binding
// Assembly: nitro, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 6CF5DDEF-E052-4F9D-953F-6644F8378A66


using com.citrix.netscaler.nitro.exception;
using com.citrix.netscaler.nitro.resource.Base;
using com.citrix.netscaler.nitro.service;

namespace com.citrix.netscaler.nitro.resource.config.authentication
{
  public class authenticationvserver_binding : base_resource
  {
    private string nameField = (string) null;
    private com.citrix.netscaler.nitro.resource.config.authentication.authenticationvserver_auditnslogpolicy_binding[] authenticationvserver_auditnslogpolicy_bindingField = (com.citrix.netscaler.nitro.resource.config.authentication.authenticationvserver_auditnslogpolicy_binding[]) null;
    private com.citrix.netscaler.nitro.resource.config.authentication.authenticationvserver_authenticationpolicy_binding[] authenticationvserver_authenticationpolicy_bindingField = (com.citrix.netscaler.nitro.resource.config.authentication.authenticationvserver_authenticationpolicy_binding[]) null;
    private com.citrix.netscaler.nitro.resource.config.authentication.authenticationvserver_authenticationradiuspolicy_binding[] authenticationvserver_authenticationradiuspolicy_bindingField = (com.citrix.netscaler.nitro.resource.config.authentication.authenticationvserver_authenticationradiuspolicy_binding[]) null;
    private com.citrix.netscaler.nitro.resource.config.authentication.authenticationvserver_authenticationldappolicy_binding[] authenticationvserver_authenticationldappolicy_bindingField = (com.citrix.netscaler.nitro.resource.config.authentication.authenticationvserver_authenticationldappolicy_binding[]) null;
    private com.citrix.netscaler.nitro.resource.config.authentication.authenticationvserver_authenticationsamlidppolicy_binding[] authenticationvserver_authenticationsamlidppolicy_bindingField = (com.citrix.netscaler.nitro.resource.config.authentication.authenticationvserver_authenticationsamlidppolicy_binding[]) null;
    private com.citrix.netscaler.nitro.resource.config.authentication.authenticationvserver_authenticationwebauthpolicy_binding[] authenticationvserver_authenticationwebauthpolicy_bindingField = (com.citrix.netscaler.nitro.resource.config.authentication.authenticationvserver_authenticationwebauthpolicy_binding[]) null;
    private com.citrix.netscaler.nitro.resource.config.authentication.authenticationvserver_authenticationlocalpolicy_binding[] authenticationvserver_authenticationlocalpolicy_bindingField = (com.citrix.netscaler.nitro.resource.config.authentication.authenticationvserver_authenticationlocalpolicy_binding[]) null;
    private com.citrix.netscaler.nitro.resource.config.authentication.authenticationvserver_authenticationnegotiatepolicy_binding[] authenticationvserver_authenticationnegotiatepolicy_bindingField = (com.citrix.netscaler.nitro.resource.config.authentication.authenticationvserver_authenticationnegotiatepolicy_binding[]) null;
    private com.citrix.netscaler.nitro.resource.config.authentication.authenticationvserver_authenticationtacacspolicy_binding[] authenticationvserver_authenticationtacacspolicy_bindingField = (com.citrix.netscaler.nitro.resource.config.authentication.authenticationvserver_authenticationtacacspolicy_binding[]) null;
    private com.citrix.netscaler.nitro.resource.config.authentication.authenticationvserver_authenticationsamlpolicy_binding[] authenticationvserver_authenticationsamlpolicy_bindingField = (com.citrix.netscaler.nitro.resource.config.authentication.authenticationvserver_authenticationsamlpolicy_binding[]) null;
    private com.citrix.netscaler.nitro.resource.config.authentication.authenticationvserver_cspolicy_binding[] authenticationvserver_cspolicy_bindingField = (com.citrix.netscaler.nitro.resource.config.authentication.authenticationvserver_cspolicy_binding[]) null;
    private com.citrix.netscaler.nitro.resource.config.authentication.authenticationvserver_auditsyslogpolicy_binding[] authenticationvserver_auditsyslogpolicy_bindingField = (com.citrix.netscaler.nitro.resource.config.authentication.authenticationvserver_auditsyslogpolicy_binding[]) null;
    private com.citrix.netscaler.nitro.resource.config.authentication.authenticationvserver_authenticationloginschemapolicy_binding[] authenticationvserver_authenticationloginschemapolicy_bindingField = (com.citrix.netscaler.nitro.resource.config.authentication.authenticationvserver_authenticationloginschemapolicy_binding[]) null;
    private com.citrix.netscaler.nitro.resource.config.authentication.authenticationvserver_authenticationcertpolicy_binding[] authenticationvserver_authenticationcertpolicy_bindingField = (com.citrix.netscaler.nitro.resource.config.authentication.authenticationvserver_authenticationcertpolicy_binding[]) null;
    private com.citrix.netscaler.nitro.resource.config.authentication.authenticationvserver_tmsessionpolicy_binding[] authenticationvserver_tmsessionpolicy_bindingField = (com.citrix.netscaler.nitro.resource.config.authentication.authenticationvserver_tmsessionpolicy_binding[]) null;

    public string name
    {
      get => this.nameField;
      set => this.nameField = value;
    }

    public com.citrix.netscaler.nitro.resource.config.authentication.authenticationvserver_authenticationlocalpolicy_binding[] authenticationvserver_authenticationlocalpolicy_binding
    {
      get => this.authenticationvserver_authenticationlocalpolicy_bindingField;
      private set => this.authenticationvserver_authenticationlocalpolicy_bindingField = value;
    }

    public com.citrix.netscaler.nitro.resource.config.authentication.authenticationvserver_tmsessionpolicy_binding[] authenticationvserver_tmsessionpolicy_binding
    {
      get => this.authenticationvserver_tmsessionpolicy_bindingField;
      private set => this.authenticationvserver_tmsessionpolicy_bindingField = value;
    }

    public com.citrix.netscaler.nitro.resource.config.authentication.authenticationvserver_cspolicy_binding[] authenticationvserver_cspolicy_binding
    {
      get => this.authenticationvserver_cspolicy_bindingField;
      private set => this.authenticationvserver_cspolicy_bindingField = value;
    }

    public com.citrix.netscaler.nitro.resource.config.authentication.authenticationvserver_auditsyslogpolicy_binding[] authenticationvserver_auditsyslogpolicy_binding
    {
      get => this.authenticationvserver_auditsyslogpolicy_bindingField;
      private set => this.authenticationvserver_auditsyslogpolicy_bindingField = value;
    }

    public com.citrix.netscaler.nitro.resource.config.authentication.authenticationvserver_authenticationsamlidppolicy_binding[] authenticationvserver_authenticationsamlidppolicy_binding
    {
      get => this.authenticationvserver_authenticationsamlidppolicy_bindingField;
      private set => this.authenticationvserver_authenticationsamlidppolicy_bindingField = value;
    }

    public com.citrix.netscaler.nitro.resource.config.authentication.authenticationvserver_auditnslogpolicy_binding[] authenticationvserver_auditnslogpolicy_binding
    {
      get => this.authenticationvserver_auditnslogpolicy_bindingField;
      private set => this.authenticationvserver_auditnslogpolicy_bindingField = value;
    }

    public com.citrix.netscaler.nitro.resource.config.authentication.authenticationvserver_authenticationldappolicy_binding[] authenticationvserver_authenticationldappolicy_binding
    {
      get => this.authenticationvserver_authenticationldappolicy_bindingField;
      private set => this.authenticationvserver_authenticationldappolicy_bindingField = value;
    }

    public com.citrix.netscaler.nitro.resource.config.authentication.authenticationvserver_authenticationcertpolicy_binding[] authenticationvserver_authenticationcertpolicy_binding
    {
      get => this.authenticationvserver_authenticationcertpolicy_bindingField;
      private set => this.authenticationvserver_authenticationcertpolicy_bindingField = value;
    }

    public com.citrix.netscaler.nitro.resource.config.authentication.authenticationvserver_authenticationsamlpolicy_binding[] authenticationvserver_authenticationsamlpolicy_binding
    {
      get => this.authenticationvserver_authenticationsamlpolicy_bindingField;
      private set => this.authenticationvserver_authenticationsamlpolicy_bindingField = value;
    }

    public com.citrix.netscaler.nitro.resource.config.authentication.authenticationvserver_authenticationpolicy_binding[] authenticationvserver_authenticationpolicy_binding
    {
      get => this.authenticationvserver_authenticationpolicy_bindingField;
      private set => this.authenticationvserver_authenticationpolicy_bindingField = value;
    }

    public com.citrix.netscaler.nitro.resource.config.authentication.authenticationvserver_authenticationradiuspolicy_binding[] authenticationvserver_authenticationradiuspolicy_binding
    {
      get => this.authenticationvserver_authenticationradiuspolicy_bindingField;
      private set => this.authenticationvserver_authenticationradiuspolicy_bindingField = value;
    }

    public com.citrix.netscaler.nitro.resource.config.authentication.authenticationvserver_authenticationloginschemapolicy_binding[] authenticationvserver_authenticationloginschemapolicy_binding
    {
      get => this.authenticationvserver_authenticationloginschemapolicy_bindingField;
      private set => this.authenticationvserver_authenticationloginschemapolicy_bindingField = value;
    }

    public com.citrix.netscaler.nitro.resource.config.authentication.authenticationvserver_authenticationtacacspolicy_binding[] authenticationvserver_authenticationtacacspolicy_binding
    {
      get => this.authenticationvserver_authenticationtacacspolicy_bindingField;
      private set => this.authenticationvserver_authenticationtacacspolicy_bindingField = value;
    }

    public com.citrix.netscaler.nitro.resource.config.authentication.authenticationvserver_authenticationwebauthpolicy_binding[] authenticationvserver_authenticationwebauthpolicy_binding
    {
      get => this.authenticationvserver_authenticationwebauthpolicy_bindingField;
      private set => this.authenticationvserver_authenticationwebauthpolicy_bindingField = value;
    }

    public com.citrix.netscaler.nitro.resource.config.authentication.authenticationvserver_authenticationnegotiatepolicy_binding[] authenticationvserver_authenticationnegotiatepolicy_binding
    {
      get => this.authenticationvserver_authenticationnegotiatepolicy_bindingField;
      private set => this.authenticationvserver_authenticationnegotiatepolicy_bindingField = value;
    }

    internal override base_resource[] get_nitro_response(
      nitro_service service,
      string response)
    {
      authenticationvserver_binding.authenticationvserver_binding_response authenticationvserverBindingResponse = new authenticationvserver_binding.authenticationvserver_binding_response();
      authenticationvserver_binding.authenticationvserver_binding_response resource = (authenticationvserver_binding.authenticationvserver_binding_response) service.get_payload_formatter().string_to_resource(authenticationvserverBindingResponse.GetType(), response);
      if (resource.errorcode != 0)
      {
        if (resource.errorcode == 444)
          service.clear_session();
        if (resource.severity == null)
          throw new nitro_exception(resource.message, resource.errorcode);
        if (resource.severity.Equals("ERROR"))
          throw new nitro_exception(resource.message, resource.errorcode);
      }
      return (base_resource[]) resource.authenticationvserver_binding;
    }

    internal override string get_object_name() => this.name;

    public static authenticationvserver_binding get(
      nitro_service service,
      string name)
    {
      return (authenticationvserver_binding) new authenticationvserver_binding()
      {
        name = name
      }.get_resource(service);
    }

    public static authenticationvserver_binding[] get(
      nitro_service service,
      string[] name)
    {
      if (name == null || name.Length <= 0)
        return (authenticationvserver_binding[]) null;
      authenticationvserver_binding[] authenticationvserverBindingArray1 = new authenticationvserver_binding[name.Length];
      authenticationvserver_binding[] authenticationvserverBindingArray2 = new authenticationvserver_binding[name.Length];
      for (int index = 0; index < name.Length; ++index)
      {
        authenticationvserverBindingArray2[index] = new authenticationvserver_binding();
        authenticationvserverBindingArray2[index].name = name[index];
        authenticationvserverBindingArray1[index] = (authenticationvserver_binding) authenticationvserverBindingArray2[index].get_resource(service);
      }
      return authenticationvserverBindingArray1;
    }

    private class authenticationvserver_binding_response : base_response
    {
      public authenticationvserver_binding[] authenticationvserver_binding = (authenticationvserver_binding[]) null;
    }
  }
}
