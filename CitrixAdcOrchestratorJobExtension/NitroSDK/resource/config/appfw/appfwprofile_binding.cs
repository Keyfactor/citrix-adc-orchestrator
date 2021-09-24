// Decompiled with JetBrains decompiler
// Type: com.citrix.netscaler.nitro.resource.config.appfw.appfwprofile_binding
// Assembly: nitro, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 6CF5DDEF-E052-4F9D-953F-6644F8378A66


using com.citrix.netscaler.nitro.exception;
using com.citrix.netscaler.nitro.resource.Base;
using com.citrix.netscaler.nitro.service;

namespace com.citrix.netscaler.nitro.resource.config.appfw
{
  public class appfwprofile_binding : base_resource
  {
    private string nameField = (string) null;
    private com.citrix.netscaler.nitro.resource.config.appfw.appfwprofile_excluderescontenttype_binding[] appfwprofile_excluderescontenttype_bindingField = (com.citrix.netscaler.nitro.resource.config.appfw.appfwprofile_excluderescontenttype_binding[]) null;
    private com.citrix.netscaler.nitro.resource.config.appfw.appfwprofile_xmlattachmenturl_binding[] appfwprofile_xmlattachmenturl_bindingField = (com.citrix.netscaler.nitro.resource.config.appfw.appfwprofile_xmlattachmenturl_binding[]) null;
    private com.citrix.netscaler.nitro.resource.config.appfw.appfwprofile_crosssitescripting_binding[] appfwprofile_crosssitescripting_bindingField = (com.citrix.netscaler.nitro.resource.config.appfw.appfwprofile_crosssitescripting_binding[]) null;
    private com.citrix.netscaler.nitro.resource.config.appfw.appfwprofile_xmlwsiurl_binding[] appfwprofile_xmlwsiurl_bindingField = (com.citrix.netscaler.nitro.resource.config.appfw.appfwprofile_xmlwsiurl_binding[]) null;
    private com.citrix.netscaler.nitro.resource.config.appfw.appfwprofile_xmldosurl_binding[] appfwprofile_xmldosurl_bindingField = (com.citrix.netscaler.nitro.resource.config.appfw.appfwprofile_xmldosurl_binding[]) null;
    private com.citrix.netscaler.nitro.resource.config.appfw.appfwprofile_fieldconsistency_binding[] appfwprofile_fieldconsistency_bindingField = (com.citrix.netscaler.nitro.resource.config.appfw.appfwprofile_fieldconsistency_binding[]) null;
    private com.citrix.netscaler.nitro.resource.config.appfw.appfwprofile_safeobject_binding[] appfwprofile_safeobject_bindingField = (com.citrix.netscaler.nitro.resource.config.appfw.appfwprofile_safeobject_binding[]) null;
    private com.citrix.netscaler.nitro.resource.config.appfw.appfwprofile_sqlinjection_binding[] appfwprofile_sqlinjection_bindingField = (com.citrix.netscaler.nitro.resource.config.appfw.appfwprofile_sqlinjection_binding[]) null;
    private com.citrix.netscaler.nitro.resource.config.appfw.appfwprofile_denyurl_binding[] appfwprofile_denyurl_bindingField = (com.citrix.netscaler.nitro.resource.config.appfw.appfwprofile_denyurl_binding[]) null;
    private com.citrix.netscaler.nitro.resource.config.appfw.appfwprofile_trustedlearningclients_binding[] appfwprofile_trustedlearningclients_bindingField = (com.citrix.netscaler.nitro.resource.config.appfw.appfwprofile_trustedlearningclients_binding[]) null;
    private com.citrix.netscaler.nitro.resource.config.appfw.appfwprofile_csrftag_binding[] appfwprofile_csrftag_bindingField = (com.citrix.netscaler.nitro.resource.config.appfw.appfwprofile_csrftag_binding[]) null;
    private com.citrix.netscaler.nitro.resource.config.appfw.appfwprofile_cookieconsistency_binding[] appfwprofile_cookieconsistency_bindingField = (com.citrix.netscaler.nitro.resource.config.appfw.appfwprofile_cookieconsistency_binding[]) null;
    private com.citrix.netscaler.nitro.resource.config.appfw.appfwprofile_starturl_binding[] appfwprofile_starturl_bindingField = (com.citrix.netscaler.nitro.resource.config.appfw.appfwprofile_starturl_binding[]) null;
    private com.citrix.netscaler.nitro.resource.config.appfw.appfwprofile_xmlsqlinjection_binding[] appfwprofile_xmlsqlinjection_bindingField = (com.citrix.netscaler.nitro.resource.config.appfw.appfwprofile_xmlsqlinjection_binding[]) null;
    private com.citrix.netscaler.nitro.resource.config.appfw.appfwprofile_creditcardnumber_binding[] appfwprofile_creditcardnumber_bindingField = (com.citrix.netscaler.nitro.resource.config.appfw.appfwprofile_creditcardnumber_binding[]) null;
    private com.citrix.netscaler.nitro.resource.config.appfw.appfwprofile_xmlxss_binding[] appfwprofile_xmlxss_bindingField = (com.citrix.netscaler.nitro.resource.config.appfw.appfwprofile_xmlxss_binding[]) null;
    private com.citrix.netscaler.nitro.resource.config.appfw.appfwprofile_contenttype_binding[] appfwprofile_contenttype_bindingField = (com.citrix.netscaler.nitro.resource.config.appfw.appfwprofile_contenttype_binding[]) null;
    private com.citrix.netscaler.nitro.resource.config.appfw.appfwprofile_fieldformat_binding[] appfwprofile_fieldformat_bindingField = (com.citrix.netscaler.nitro.resource.config.appfw.appfwprofile_fieldformat_binding[]) null;
    private com.citrix.netscaler.nitro.resource.config.appfw.appfwprofile_xmlvalidationurl_binding[] appfwprofile_xmlvalidationurl_bindingField = (com.citrix.netscaler.nitro.resource.config.appfw.appfwprofile_xmlvalidationurl_binding[]) null;

    public string name
    {
      get => this.nameField;
      set => this.nameField = value;
    }

    public com.citrix.netscaler.nitro.resource.config.appfw.appfwprofile_csrftag_binding[] appfwprofile_csrftag_binding
    {
      get => this.appfwprofile_csrftag_bindingField;
      private set => this.appfwprofile_csrftag_bindingField = value;
    }

    public com.citrix.netscaler.nitro.resource.config.appfw.appfwprofile_starturl_binding[] appfwprofile_starturl_binding
    {
      get => this.appfwprofile_starturl_bindingField;
      private set => this.appfwprofile_starturl_bindingField = value;
    }

    public com.citrix.netscaler.nitro.resource.config.appfw.appfwprofile_xmlvalidationurl_binding[] appfwprofile_xmlvalidationurl_binding
    {
      get => this.appfwprofile_xmlvalidationurl_bindingField;
      private set => this.appfwprofile_xmlvalidationurl_bindingField = value;
    }

    public com.citrix.netscaler.nitro.resource.config.appfw.appfwprofile_xmlattachmenturl_binding[] appfwprofile_xmlattachmenturl_binding
    {
      get => this.appfwprofile_xmlattachmenturl_bindingField;
      private set => this.appfwprofile_xmlattachmenturl_bindingField = value;
    }

    public com.citrix.netscaler.nitro.resource.config.appfw.appfwprofile_safeobject_binding[] appfwprofile_safeobject_binding
    {
      get => this.appfwprofile_safeobject_bindingField;
      private set => this.appfwprofile_safeobject_bindingField = value;
    }

    public com.citrix.netscaler.nitro.resource.config.appfw.appfwprofile_cookieconsistency_binding[] appfwprofile_cookieconsistency_binding
    {
      get => this.appfwprofile_cookieconsistency_bindingField;
      private set => this.appfwprofile_cookieconsistency_bindingField = value;
    }

    public com.citrix.netscaler.nitro.resource.config.appfw.appfwprofile_fieldconsistency_binding[] appfwprofile_fieldconsistency_binding
    {
      get => this.appfwprofile_fieldconsistency_bindingField;
      private set => this.appfwprofile_fieldconsistency_bindingField = value;
    }

    public com.citrix.netscaler.nitro.resource.config.appfw.appfwprofile_xmlwsiurl_binding[] appfwprofile_xmlwsiurl_binding
    {
      get => this.appfwprofile_xmlwsiurl_bindingField;
      private set => this.appfwprofile_xmlwsiurl_bindingField = value;
    }

    public com.citrix.netscaler.nitro.resource.config.appfw.appfwprofile_xmlsqlinjection_binding[] appfwprofile_xmlsqlinjection_binding
    {
      get => this.appfwprofile_xmlsqlinjection_bindingField;
      private set => this.appfwprofile_xmlsqlinjection_bindingField = value;
    }

    public com.citrix.netscaler.nitro.resource.config.appfw.appfwprofile_sqlinjection_binding[] appfwprofile_sqlinjection_binding
    {
      get => this.appfwprofile_sqlinjection_bindingField;
      private set => this.appfwprofile_sqlinjection_bindingField = value;
    }

    public com.citrix.netscaler.nitro.resource.config.appfw.appfwprofile_trustedlearningclients_binding[] appfwprofile_trustedlearningclients_binding
    {
      get => this.appfwprofile_trustedlearningclients_bindingField;
      private set => this.appfwprofile_trustedlearningclients_bindingField = value;
    }

    public com.citrix.netscaler.nitro.resource.config.appfw.appfwprofile_crosssitescripting_binding[] appfwprofile_crosssitescripting_binding
    {
      get => this.appfwprofile_crosssitescripting_bindingField;
      private set => this.appfwprofile_crosssitescripting_bindingField = value;
    }

    public com.citrix.netscaler.nitro.resource.config.appfw.appfwprofile_excluderescontenttype_binding[] appfwprofile_excluderescontenttype_binding
    {
      get => this.appfwprofile_excluderescontenttype_bindingField;
      private set => this.appfwprofile_excluderescontenttype_bindingField = value;
    }

    public com.citrix.netscaler.nitro.resource.config.appfw.appfwprofile_contenttype_binding[] appfwprofile_contenttype_binding
    {
      get => this.appfwprofile_contenttype_bindingField;
      private set => this.appfwprofile_contenttype_bindingField = value;
    }

    public com.citrix.netscaler.nitro.resource.config.appfw.appfwprofile_denyurl_binding[] appfwprofile_denyurl_binding
    {
      get => this.appfwprofile_denyurl_bindingField;
      private set => this.appfwprofile_denyurl_bindingField = value;
    }

    public com.citrix.netscaler.nitro.resource.config.appfw.appfwprofile_xmlxss_binding[] appfwprofile_xmlxss_binding
    {
      get => this.appfwprofile_xmlxss_bindingField;
      private set => this.appfwprofile_xmlxss_bindingField = value;
    }

    public com.citrix.netscaler.nitro.resource.config.appfw.appfwprofile_fieldformat_binding[] appfwprofile_fieldformat_binding
    {
      get => this.appfwprofile_fieldformat_bindingField;
      private set => this.appfwprofile_fieldformat_bindingField = value;
    }

    public com.citrix.netscaler.nitro.resource.config.appfw.appfwprofile_creditcardnumber_binding[] appfwprofile_creditcardnumber_binding
    {
      get => this.appfwprofile_creditcardnumber_bindingField;
      private set => this.appfwprofile_creditcardnumber_bindingField = value;
    }

    public com.citrix.netscaler.nitro.resource.config.appfw.appfwprofile_xmldosurl_binding[] appfwprofile_xmldosurl_binding
    {
      get => this.appfwprofile_xmldosurl_bindingField;
      private set => this.appfwprofile_xmldosurl_bindingField = value;
    }

    internal override base_resource[] get_nitro_response(
      nitro_service service,
      string response)
    {
      appfwprofile_binding.appfwprofile_binding_response appfwprofileBindingResponse = new appfwprofile_binding.appfwprofile_binding_response();
      appfwprofile_binding.appfwprofile_binding_response resource = (appfwprofile_binding.appfwprofile_binding_response) service.get_payload_formatter().string_to_resource(appfwprofileBindingResponse.GetType(), response);
      if (resource.errorcode != 0)
      {
        if (resource.errorcode == 444)
          service.clear_session();
        if (resource.severity == null)
          throw new nitro_exception(resource.message, resource.errorcode);
        if (resource.severity.Equals("ERROR"))
          throw new nitro_exception(resource.message, resource.errorcode);
      }
      return (base_resource[]) resource.appfwprofile_binding;
    }

    internal override string get_object_name() => this.name;

    public static appfwprofile_binding get(nitro_service service, string name) => (appfwprofile_binding) new appfwprofile_binding()
    {
      name = name
    }.get_resource(service);

    public static appfwprofile_binding[] get(
      nitro_service service,
      string[] name)
    {
      if (name == null || name.Length <= 0)
        return (appfwprofile_binding[]) null;
      appfwprofile_binding[] appfwprofileBindingArray1 = new appfwprofile_binding[name.Length];
      appfwprofile_binding[] appfwprofileBindingArray2 = new appfwprofile_binding[name.Length];
      for (int index = 0; index < name.Length; ++index)
      {
        appfwprofileBindingArray2[index] = new appfwprofile_binding();
        appfwprofileBindingArray2[index].name = name[index];
        appfwprofileBindingArray1[index] = (appfwprofile_binding) appfwprofileBindingArray2[index].get_resource(service);
      }
      return appfwprofileBindingArray1;
    }

    private class appfwprofile_binding_response : base_response
    {
      public appfwprofile_binding[] appfwprofile_binding = (appfwprofile_binding[]) null;
    }
  }
}
