﻿// Decompiled with JetBrains decompiler
// Type: com.citrix.netscaler.nitro.resource.config.appfw.appfwprofile_denyurl_binding
// Assembly: nitro, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 6CF5DDEF-E052-4F9D-953F-6644F8378A66


using com.citrix.netscaler.nitro.exception;
using com.citrix.netscaler.nitro.resource.Base;
using com.citrix.netscaler.nitro.service;
using com.citrix.netscaler.nitro.util;

namespace com.citrix.netscaler.nitro.resource.config.appfw
{
  public class appfwprofile_denyurl_binding : base_resource
  {
    private string denyurlField = (string) null;
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

    public string denyurl
    {
      get => this.denyurlField;
      set => this.denyurlField = value;
    }

    public string name
    {
      get => this.nameField;
      set => this.nameField = value;
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
      appfwprofile_denyurl_binding.appfwprofile_denyurl_binding_response denyurlBindingResponse = new appfwprofile_denyurl_binding.appfwprofile_denyurl_binding_response();
      appfwprofile_denyurl_binding.appfwprofile_denyurl_binding_response resource = (appfwprofile_denyurl_binding.appfwprofile_denyurl_binding_response) service.get_payload_formatter().string_to_resource(denyurlBindingResponse.GetType(), response);
      if (resource.errorcode != 0)
      {
        if (resource.errorcode == 444)
          service.clear_session();
        if (resource.severity == null)
          throw new nitro_exception(resource.message, resource.errorcode);
        if (resource.severity.Equals("ERROR"))
          throw new nitro_exception(resource.message, resource.errorcode);
      }
      return (base_resource[]) resource.appfwprofile_denyurl_binding;
    }

    internal override string get_object_name() => this.name;

    public static base_response add(
      nitro_service client,
      appfwprofile_denyurl_binding resource)
    {
      return new appfwprofile_denyurl_binding()
      {
        name = resource.name,
        denyurl = resource.denyurl,
        comment = resource.comment,
        state = resource.state
      }.update_resource(client);
    }

    public static base_responses add(
      nitro_service client,
      appfwprofile_denyurl_binding[] resources)
    {
      base_responses baseResponses = (base_responses) null;
      if (resources != null && resources.Length > 0)
      {
        appfwprofile_denyurl_binding[] appfwprofileDenyurlBindingArray = new appfwprofile_denyurl_binding[resources.Length];
        for (int index = 0; index < resources.Length; ++index)
        {
          appfwprofileDenyurlBindingArray[index] = new appfwprofile_denyurl_binding();
          appfwprofileDenyurlBindingArray[index].name = resources[index].name;
          appfwprofileDenyurlBindingArray[index].denyurl = resources[index].denyurl;
          appfwprofileDenyurlBindingArray[index].comment = resources[index].comment;
          appfwprofileDenyurlBindingArray[index].state = resources[index].state;
        }
        baseResponses = base_resource.update_bulk_request(client, (base_resource[]) appfwprofileDenyurlBindingArray);
      }
      return baseResponses;
    }

    public static base_response delete(
      nitro_service client,
      appfwprofile_denyurl_binding resource)
    {
      return new appfwprofile_denyurl_binding()
      {
        name = resource.name,
        denyurl = resource.denyurl
      }.delete_resource(client);
    }

    public static base_responses delete(
      nitro_service client,
      appfwprofile_denyurl_binding[] resources)
    {
      base_responses baseResponses = (base_responses) null;
      if (resources != null && resources.Length > 0)
      {
        appfwprofile_denyurl_binding[] appfwprofileDenyurlBindingArray = new appfwprofile_denyurl_binding[resources.Length];
        for (int index = 0; index < resources.Length; ++index)
        {
          appfwprofileDenyurlBindingArray[index] = new appfwprofile_denyurl_binding();
          appfwprofileDenyurlBindingArray[index].name = resources[index].name;
          appfwprofileDenyurlBindingArray[index].denyurl = resources[index].denyurl;
        }
        baseResponses = base_resource.delete_bulk_request(client, (base_resource[]) appfwprofileDenyurlBindingArray);
      }
      return baseResponses;
    }

    public static appfwprofile_denyurl_binding[] get(
      nitro_service service,
      string name)
    {
      return (appfwprofile_denyurl_binding[]) new appfwprofile_denyurl_binding()
      {
        name = name
      }.get_resources(service, (options) null);
    }

    public static appfwprofile_denyurl_binding[] get_filtered(
      nitro_service service,
      string name,
      string filter)
    {
      appfwprofile_denyurl_binding appfwprofileDenyurlBinding = new appfwprofile_denyurl_binding();
      appfwprofileDenyurlBinding.name = name;
      options option = new options();
      option.set_filter(filter);
      return (appfwprofile_denyurl_binding[]) appfwprofileDenyurlBinding.getfiltered(service, option);
    }

    public static appfwprofile_denyurl_binding[] get_filtered(
      nitro_service service,
      string name,
      filtervalue[] filter)
    {
      appfwprofile_denyurl_binding appfwprofileDenyurlBinding = new appfwprofile_denyurl_binding();
      appfwprofileDenyurlBinding.name = name;
      options option = new options();
      option.set_filter(filter);
      return (appfwprofile_denyurl_binding[]) appfwprofileDenyurlBinding.getfiltered(service, option);
    }

    public static uint count(nitro_service service, string name)
    {
      appfwprofile_denyurl_binding appfwprofileDenyurlBinding = new appfwprofile_denyurl_binding();
      appfwprofileDenyurlBinding.name = name;
      options option = new options();
      option.set_count(true);
      appfwprofile_denyurl_binding[] resources = (appfwprofile_denyurl_binding[]) appfwprofileDenyurlBinding.get_resources(service, option);
      return resources != null && resources.Length > 0 ? resources[0].__count.Value : 0U;
    }

    public static uint count_filtered(nitro_service service, string name, string filter)
    {
      appfwprofile_denyurl_binding appfwprofileDenyurlBinding = new appfwprofile_denyurl_binding();
      appfwprofileDenyurlBinding.name = name;
      options option = new options();
      option.set_count(true);
      option.set_filter(filter);
      appfwprofile_denyurl_binding[] appfwprofileDenyurlBindingArray = (appfwprofile_denyurl_binding[]) appfwprofileDenyurlBinding.getfiltered(service, option);
      return appfwprofileDenyurlBindingArray != null && appfwprofileDenyurlBindingArray.Length > 0 ? appfwprofileDenyurlBindingArray[0].__count.Value : 0U;
    }

    public static uint count_filtered(nitro_service service, string name, filtervalue[] filter)
    {
      appfwprofile_denyurl_binding appfwprofileDenyurlBinding = new appfwprofile_denyurl_binding();
      appfwprofileDenyurlBinding.name = name;
      options option = new options();
      option.set_count(true);
      option.set_filter(filter);
      appfwprofile_denyurl_binding[] appfwprofileDenyurlBindingArray = (appfwprofile_denyurl_binding[]) appfwprofileDenyurlBinding.getfiltered(service, option);
      return appfwprofileDenyurlBindingArray != null && appfwprofileDenyurlBindingArray.Length > 0 ? appfwprofileDenyurlBindingArray[0].__count.Value : 0U;
    }

    private class appfwprofile_denyurl_binding_response : base_response
    {
      public appfwprofile_denyurl_binding[] appfwprofile_denyurl_binding = (appfwprofile_denyurl_binding[]) null;
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
