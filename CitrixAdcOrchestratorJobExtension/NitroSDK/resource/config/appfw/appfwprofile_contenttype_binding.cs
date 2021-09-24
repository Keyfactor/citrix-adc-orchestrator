// Decompiled with JetBrains decompiler
// Type: com.citrix.netscaler.nitro.resource.config.appfw.appfwprofile_contenttype_binding
// Assembly: nitro, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 6CF5DDEF-E052-4F9D-953F-6644F8378A66


using com.citrix.netscaler.nitro.exception;
using com.citrix.netscaler.nitro.resource.Base;
using com.citrix.netscaler.nitro.service;
using com.citrix.netscaler.nitro.util;

namespace com.citrix.netscaler.nitro.resource.config.appfw
{
  public class appfwprofile_contenttype_binding : base_resource
  {
    private string contenttypeField = (string) null;
    private string stateField = (string) null;
    private string commentField = (string) null;
    private string nameField = (string) null;
    private uint? __countField = new uint?();

    public uint? __count
    {
      get => this.__countField;
      set => this.__countField = value;
    }

    public string state
    {
      get => this.stateField;
      set => this.stateField = value;
    }

    public string name
    {
      get => this.nameField;
      set => this.nameField = value;
    }

    public string contenttype
    {
      get => this.contenttypeField;
      set => this.contenttypeField = value;
    }

    public string comment
    {
      get => this.commentField;
      set => this.commentField = value;
    }

    internal override base_resource[] get_nitro_response(
      nitro_service service,
      string response)
    {
      appfwprofile_contenttype_binding.appfwprofile_contenttype_binding_response contenttypeBindingResponse = new appfwprofile_contenttype_binding.appfwprofile_contenttype_binding_response();
      appfwprofile_contenttype_binding.appfwprofile_contenttype_binding_response resource = (appfwprofile_contenttype_binding.appfwprofile_contenttype_binding_response) service.get_payload_formatter().string_to_resource(contenttypeBindingResponse.GetType(), response);
      if (resource.errorcode != 0)
      {
        if (resource.errorcode == 444)
          service.clear_session();
        if (resource.severity == null)
          throw new nitro_exception(resource.message, resource.errorcode);
        if (resource.severity.Equals("ERROR"))
          throw new nitro_exception(resource.message, resource.errorcode);
      }
      return (base_resource[]) resource.appfwprofile_contenttype_binding;
    }

    internal override string get_object_name() => this.name;

    public static base_response add(
      nitro_service client,
      appfwprofile_contenttype_binding resource)
    {
      return new appfwprofile_contenttype_binding()
      {
        name = resource.name,
        comment = resource.comment,
        state = resource.state,
        contenttype = resource.contenttype
      }.update_resource(client);
    }

    public static base_responses add(
      nitro_service client,
      appfwprofile_contenttype_binding[] resources)
    {
      base_responses baseResponses = (base_responses) null;
      if (resources != null && resources.Length > 0)
      {
        appfwprofile_contenttype_binding[] contenttypeBindingArray = new appfwprofile_contenttype_binding[resources.Length];
        for (int index = 0; index < resources.Length; ++index)
        {
          contenttypeBindingArray[index] = new appfwprofile_contenttype_binding();
          contenttypeBindingArray[index].name = resources[index].name;
          contenttypeBindingArray[index].comment = resources[index].comment;
          contenttypeBindingArray[index].state = resources[index].state;
          contenttypeBindingArray[index].contenttype = resources[index].contenttype;
        }
        baseResponses = base_resource.update_bulk_request(client, (base_resource[]) contenttypeBindingArray);
      }
      return baseResponses;
    }

    public static base_response delete(
      nitro_service client,
      appfwprofile_contenttype_binding resource)
    {
      return new appfwprofile_contenttype_binding()
      {
        name = resource.name,
        contenttype = resource.contenttype
      }.delete_resource(client);
    }

    public static base_responses delete(
      nitro_service client,
      appfwprofile_contenttype_binding[] resources)
    {
      base_responses baseResponses = (base_responses) null;
      if (resources != null && resources.Length > 0)
      {
        appfwprofile_contenttype_binding[] contenttypeBindingArray = new appfwprofile_contenttype_binding[resources.Length];
        for (int index = 0; index < resources.Length; ++index)
        {
          contenttypeBindingArray[index] = new appfwprofile_contenttype_binding();
          contenttypeBindingArray[index].name = resources[index].name;
          contenttypeBindingArray[index].contenttype = resources[index].contenttype;
        }
        baseResponses = base_resource.delete_bulk_request(client, (base_resource[]) contenttypeBindingArray);
      }
      return baseResponses;
    }

    public static appfwprofile_contenttype_binding[] get(
      nitro_service service,
      string name)
    {
      return (appfwprofile_contenttype_binding[]) new appfwprofile_contenttype_binding()
      {
        name = name
      }.get_resources(service, (options) null);
    }

    public static appfwprofile_contenttype_binding[] get_filtered(
      nitro_service service,
      string name,
      string filter)
    {
      appfwprofile_contenttype_binding contenttypeBinding = new appfwprofile_contenttype_binding();
      contenttypeBinding.name = name;
      options option = new options();
      option.set_filter(filter);
      return (appfwprofile_contenttype_binding[]) contenttypeBinding.getfiltered(service, option);
    }

    public static appfwprofile_contenttype_binding[] get_filtered(
      nitro_service service,
      string name,
      filtervalue[] filter)
    {
      appfwprofile_contenttype_binding contenttypeBinding = new appfwprofile_contenttype_binding();
      contenttypeBinding.name = name;
      options option = new options();
      option.set_filter(filter);
      return (appfwprofile_contenttype_binding[]) contenttypeBinding.getfiltered(service, option);
    }

    public static uint count(nitro_service service, string name)
    {
      appfwprofile_contenttype_binding contenttypeBinding = new appfwprofile_contenttype_binding();
      contenttypeBinding.name = name;
      options option = new options();
      option.set_count(true);
      appfwprofile_contenttype_binding[] resources = (appfwprofile_contenttype_binding[]) contenttypeBinding.get_resources(service, option);
      return resources != null && resources.Length > 0 ? resources[0].__count.Value : 0U;
    }

    public static uint count_filtered(nitro_service service, string name, string filter)
    {
      appfwprofile_contenttype_binding contenttypeBinding = new appfwprofile_contenttype_binding();
      contenttypeBinding.name = name;
      options option = new options();
      option.set_count(true);
      option.set_filter(filter);
      appfwprofile_contenttype_binding[] contenttypeBindingArray = (appfwprofile_contenttype_binding[]) contenttypeBinding.getfiltered(service, option);
      return contenttypeBindingArray != null && contenttypeBindingArray.Length > 0 ? contenttypeBindingArray[0].__count.Value : 0U;
    }

    public static uint count_filtered(nitro_service service, string name, filtervalue[] filter)
    {
      appfwprofile_contenttype_binding contenttypeBinding = new appfwprofile_contenttype_binding();
      contenttypeBinding.name = name;
      options option = new options();
      option.set_count(true);
      option.set_filter(filter);
      appfwprofile_contenttype_binding[] contenttypeBindingArray = (appfwprofile_contenttype_binding[]) contenttypeBinding.getfiltered(service, option);
      return contenttypeBindingArray != null && contenttypeBindingArray.Length > 0 ? contenttypeBindingArray[0].__count.Value : 0U;
    }

    private class appfwprofile_contenttype_binding_response : base_response
    {
      public appfwprofile_contenttype_binding[] appfwprofile_contenttype_binding = (appfwprofile_contenttype_binding[]) null;
    }

    public static class as_scan_location_xmlsqlEnum
    {
      public const string ELEMENT = "ELEMENT";
      public const string ATTRIBUTE = "ATTRIBUTE";
    }

    public static class xmlmaxelementdepthcheckEnum
    {
      public const string ON = "ON";
      public const string OFF = "OFF";
    }

    public static class xmlmaxattachmentsizecheckEnum
    {
      public const string ON = "ON";
      public const string OFF = "OFF";
    }

    public static class xmlsoaparraycheckEnum
    {
      public const string ON = "ON";
      public const string OFF = "OFF";
    }

    public static class stateEnum
    {
      public const string ENABLED = "ENABLED";
      public const string DISABLED = "DISABLED";
    }

    public static class xmlmaxelementnamelengthcheckEnum
    {
      public const string ON = "ON";
      public const string OFF = "OFF";
    }

    public static class isregex_ffEnum
    {
      public const string REGEX = "REGEX";
      public const string NOTREGEX = "NOTREGEX";
    }

    public static class xmlmaxelementscheckEnum
    {
      public const string ON = "ON";
      public const string OFF = "OFF";
    }

    public static class xmlendpointcheckEnum
    {
      public const string ABSOLUTE = "ABSOLUTE";
      public const string RELATIVE = "RELATIVE";
    }

    public static class xmlmaxnamespacescheckEnum
    {
      public const string ON = "ON";
      public const string OFF = "OFF";
    }

    public static class xmlmaxfilesizecheckEnum
    {
      public const string ON = "ON";
      public const string OFF = "OFF";
    }

    public static class xmlmaxattributenamelengthcheckEnum
    {
      public const string ON = "ON";
      public const string OFF = "OFF";
    }

    public static class isvalueregex_xssEnum
    {
      public const string REGEX = "REGEX";
      public const string NOTREGEX = "NOTREGEX";
    }

    public static class xmlblockdtdEnum
    {
      public const string ON = "ON";
      public const string OFF = "OFF";
    }

    public static class xmlblockpiEnum
    {
      public const string ON = "ON";
      public const string OFF = "OFF";
    }

    public static class isregex_sqlEnum
    {
      public const string REGEX = "REGEX";
      public const string NOTREGEX = "NOTREGEX";
    }

    public static class xmlvalidateresponseEnum
    {
      public const string ON = "ON";
      public const string OFF = "OFF";
    }

    public static class xmlmaxelementchildrencheckEnum
    {
      public const string ON = "ON";
      public const string OFF = "OFF";
    }

    public static class isregexEnum
    {
      public const string REGEX = "REGEX";
      public const string NOTREGEX = "NOTREGEX";
    }

    public static class xmlmaxentityexpansionscheckEnum
    {
      public const string ON = "ON";
      public const string OFF = "OFF";
    }

    public static class xmlmaxnamespaceurilengthcheckEnum
    {
      public const string ON = "ON";
      public const string OFF = "OFF";
    }

    public static class as_scan_location_xssEnum
    {
      public const string FORMFIELD = "FORMFIELD";
      public const string HEADER = "HEADER";
      public const string COOKIE = "COOKIE";
    }

    public static class xmlmaxentityexpansiondepthcheckEnum
    {
      public const string ON = "ON";
      public const string OFF = "OFF";
    }

    public static class as_scan_location_xmlxssEnum
    {
      public const string ELEMENT = "ELEMENT";
      public const string ATTRIBUTE = "ATTRIBUTE";
    }

    public static class xmlmaxattributevaluelengthcheckEnum
    {
      public const string ON = "ON";
      public const string OFF = "OFF";
    }

    public static class isvalueregex_sqlEnum
    {
      public const string REGEX = "REGEX";
      public const string NOTREGEX = "NOTREGEX";
    }

    public static class as_scan_location_sqlEnum
    {
      public const string FORMFIELD = "FORMFIELD";
      public const string HEADER = "HEADER";
      public const string COOKIE = "COOKIE";
    }

    public static class isregex_ffcEnum
    {
      public const string REGEX = "REGEX";
      public const string NOTREGEX = "NOTREGEX";
    }

    public static class xmlattachmentcontenttypecheckEnum
    {
      public const string ON = "ON";
      public const string OFF = "OFF";
    }

    public static class isregex_xmlsqlEnum
    {
      public const string REGEX = "REGEX";
      public const string NOTREGEX = "NOTREGEX";
    }

    public static class xmlvalidatesoapenvelopeEnum
    {
      public const string ON = "ON";
      public const string OFF = "OFF";
    }

    public static class xmlmaxchardatalengthcheckEnum
    {
      public const string ON = "ON";
      public const string OFF = "OFF";
    }

    public static class xmlminfilesizecheckEnum
    {
      public const string ON = "ON";
      public const string OFF = "OFF";
    }

    public static class isregex_xssEnum
    {
      public const string REGEX = "REGEX";
      public const string NOTREGEX = "NOTREGEX";
    }

    public static class as_value_type_sqlEnum
    {
      public const string Keyword = "Keyword";
      public const string SpecialString = "SpecialString";
      public const string Wildchar = "Wildchar";
    }

    public static class isregex_xmlxssEnum
    {
      public const string REGEX = "REGEX";
      public const string NOTREGEX = "NOTREGEX";
    }

    public static class xmladditionalsoapheadersEnum
    {
      public const string ON = "ON";
      public const string OFF = "OFF";
    }

    public static class xmlmaxattributescheckEnum
    {
      public const string ON = "ON";
      public const string OFF = "OFF";
    }

    public static class actionEnum
    {
      public const string none = "none";
      public const string block = "block";
      public const string log = "log";
      public const string remove = "remove";
      public const string stats = "stats";
      public const string xout = "xout";
    }

    public static class as_value_type_xssEnum
    {
      public const string Tag = "Tag";
      public const string Attribute = "Attribute";
      public const string Pattern = "Pattern";
    }

    public static class xmlblockexternalentitiesEnum
    {
      public const string ON = "ON";
      public const string OFF = "OFF";
    }
  }
}
