// Decompiled with JetBrains decompiler
// Type: com.citrix.netscaler.nitro.resource.config.appfw.appfwprofile_xmldosurl_binding
// Assembly: nitro, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 6CF5DDEF-E052-4F9D-953F-6644F8378A66


using com.citrix.netscaler.nitro.exception;
using com.citrix.netscaler.nitro.resource.Base;
using com.citrix.netscaler.nitro.service;
using com.citrix.netscaler.nitro.util;

namespace com.citrix.netscaler.nitro.resource.config.appfw
{
  public class appfwprofile_xmldosurl_binding : base_resource
  {
    private string xmldosurlField = (string) null;
    private string xmlmaxelementdepthcheckField = (string) null;
    private uint? xmlmaxelementdepthField = new uint?();
    private string xmlmaxelementnamelengthcheckField = (string) null;
    private uint? xmlmaxelementnamelengthField = new uint?();
    private string xmlmaxelementscheckField = (string) null;
    private uint? xmlmaxelementsField = new uint?();
    private string xmlmaxelementchildrencheckField = (string) null;
    private uint? xmlmaxelementchildrenField = new uint?();
    private string xmlmaxnodescheckField = (string) null;
    private uint? xmlmaxnodesField = new uint?();
    private string xmlmaxentityexpansionscheckField = (string) null;
    private uint? xmlmaxentityexpansionsField = new uint?();
    private string xmlmaxentityexpansiondepthcheckField = (string) null;
    private uint? xmlmaxentityexpansiondepthField = new uint?();
    private string xmlmaxattributescheckField = (string) null;
    private uint? xmlmaxattributesField = new uint?();
    private string xmlmaxattributenamelengthcheckField = (string) null;
    private uint? xmlmaxattributenamelengthField = new uint?();
    private string xmlmaxattributevaluelengthcheckField = (string) null;
    private uint? xmlmaxattributevaluelengthField = new uint?();
    private string xmlmaxnamespacescheckField = (string) null;
    private uint? xmlmaxnamespacesField = new uint?();
    private string xmlmaxnamespaceurilengthcheckField = (string) null;
    private uint? xmlmaxnamespaceurilengthField = new uint?();
    private string xmlmaxchardatalengthcheckField = (string) null;
    private uint? xmlmaxchardatalengthField = new uint?();
    private string xmlmaxfilesizecheckField = (string) null;
    private uint? xmlmaxfilesizeField = new uint?();
    private string xmlminfilesizecheckField = (string) null;
    private uint? xmlminfilesizeField = new uint?();
    private string xmlblockpiField = (string) null;
    private string xmlblockdtdField = (string) null;
    private string xmlblockexternalentitiesField = (string) null;
    private string xmlsoaparraycheckField = (string) null;
    private uint? xmlmaxsoaparraysizeField = new uint?();
    private uint? xmlmaxsoaparrayrankField = new uint?();
    private string stateField = (string) null;
    private string commentField = (string) null;
    private string nameField = (string) null;
    private uint? __countField = new uint?();

    public uint? __count
    {
      get => this.__countField;
      set => this.__countField = value;
    }

    public string xmlmaxelementdepthcheck
    {
      get => this.xmlmaxelementdepthcheckField;
      set => this.xmlmaxelementdepthcheckField = value;
    }

    public uint? xmlmaxfilesize
    {
      get => this.xmlmaxfilesizeField;
      set => this.xmlmaxfilesizeField = value;
    }

    public uint? xmlmaxnamespaceurilength
    {
      get => this.xmlmaxnamespaceurilengthField;
      set => this.xmlmaxnamespaceurilengthField = value;
    }

    public string xmldosurl
    {
      get => this.xmldosurlField;
      set => this.xmldosurlField = value;
    }

    public string state
    {
      get => this.stateField;
      set => this.stateField = value;
    }

    public string xmlsoaparraycheck
    {
      get => this.xmlsoaparraycheckField;
      set => this.xmlsoaparraycheckField = value;
    }

    public string xmlmaxelementnamelengthcheck
    {
      get => this.xmlmaxelementnamelengthcheckField;
      set => this.xmlmaxelementnamelengthcheckField = value;
    }

    public string xmlmaxelementscheck
    {
      get => this.xmlmaxelementscheckField;
      set => this.xmlmaxelementscheckField = value;
    }

    public uint? xmlmaxentityexpansions
    {
      get => this.xmlmaxentityexpansionsField;
      set => this.xmlmaxentityexpansionsField = value;
    }

    public uint? xmlmaxattributes
    {
      get => this.xmlmaxattributesField;
      set => this.xmlmaxattributesField = value;
    }

    public string xmlmaxfilesizecheck
    {
      get => this.xmlmaxfilesizecheckField;
      set => this.xmlmaxfilesizecheckField = value;
    }

    public uint? xmlmaxchardatalength
    {
      get => this.xmlmaxchardatalengthField;
      set => this.xmlmaxchardatalengthField = value;
    }

    public string xmlmaxnamespacescheck
    {
      get => this.xmlmaxnamespacescheckField;
      set => this.xmlmaxnamespacescheckField = value;
    }

    public uint? xmlmaxnamespaces
    {
      get => this.xmlmaxnamespacesField;
      set => this.xmlmaxnamespacesField = value;
    }

    public string xmlmaxattributenamelengthcheck
    {
      get => this.xmlmaxattributenamelengthcheckField;
      set => this.xmlmaxattributenamelengthcheckField = value;
    }

    public string xmlblockdtd
    {
      get => this.xmlblockdtdField;
      set => this.xmlblockdtdField = value;
    }

    public uint? xmlmaxattributevaluelength
    {
      get => this.xmlmaxattributevaluelengthField;
      set => this.xmlmaxattributevaluelengthField = value;
    }

    public uint? xmlmaxelementdepth
    {
      get => this.xmlmaxelementdepthField;
      set => this.xmlmaxelementdepthField = value;
    }

    public uint? xmlmaxelementnamelength
    {
      get => this.xmlmaxelementnamelengthField;
      set => this.xmlmaxelementnamelengthField = value;
    }

    public string name
    {
      get => this.nameField;
      set => this.nameField = value;
    }

    public string xmlblockpi
    {
      get => this.xmlblockpiField;
      set => this.xmlblockpiField = value;
    }

    public string xmlmaxelementchildrencheck
    {
      get => this.xmlmaxelementchildrencheckField;
      set => this.xmlmaxelementchildrencheckField = value;
    }

    public uint? xmlmaxelements
    {
      get => this.xmlmaxelementsField;
      set => this.xmlmaxelementsField = value;
    }

    public string xmlmaxentityexpansionscheck
    {
      get => this.xmlmaxentityexpansionscheckField;
      set => this.xmlmaxentityexpansionscheckField = value;
    }

    public string xmlmaxnamespaceurilengthcheck
    {
      get => this.xmlmaxnamespaceurilengthcheckField;
      set => this.xmlmaxnamespaceurilengthcheckField = value;
    }

    public string xmlmaxentityexpansiondepthcheck
    {
      get => this.xmlmaxentityexpansiondepthcheckField;
      set => this.xmlmaxentityexpansiondepthcheckField = value;
    }

    public string xmlmaxattributevaluelengthcheck
    {
      get => this.xmlmaxattributevaluelengthcheckField;
      set => this.xmlmaxattributevaluelengthcheckField = value;
    }

    public uint? xmlmaxsoaparraysize
    {
      get => this.xmlmaxsoaparraysizeField;
      set => this.xmlmaxsoaparraysizeField = value;
    }

    public uint? xmlmaxentityexpansiondepth
    {
      get => this.xmlmaxentityexpansiondepthField;
      set => this.xmlmaxentityexpansiondepthField = value;
    }

    public string xmlmaxnodescheck
    {
      get => this.xmlmaxnodescheckField;
      set => this.xmlmaxnodescheckField = value;
    }

    public uint? xmlmaxattributenamelength
    {
      get => this.xmlmaxattributenamelengthField;
      set => this.xmlmaxattributenamelengthField = value;
    }

    public string xmlmaxchardatalengthcheck
    {
      get => this.xmlmaxchardatalengthcheckField;
      set => this.xmlmaxchardatalengthcheckField = value;
    }

    public string xmlminfilesizecheck
    {
      get => this.xmlminfilesizecheckField;
      set => this.xmlminfilesizecheckField = value;
    }

    public uint? xmlmaxelementchildren
    {
      get => this.xmlmaxelementchildrenField;
      set => this.xmlmaxelementchildrenField = value;
    }

    public uint? xmlminfilesize
    {
      get => this.xmlminfilesizeField;
      set => this.xmlminfilesizeField = value;
    }

    public uint? xmlmaxnodes
    {
      get => this.xmlmaxnodesField;
      set => this.xmlmaxnodesField = value;
    }

    public string comment
    {
      get => this.commentField;
      set => this.commentField = value;
    }

    public string xmlmaxattributescheck
    {
      get => this.xmlmaxattributescheckField;
      set => this.xmlmaxattributescheckField = value;
    }

    public uint? xmlmaxsoaparrayrank
    {
      get => this.xmlmaxsoaparrayrankField;
      set => this.xmlmaxsoaparrayrankField = value;
    }

    public string xmlblockexternalentities
    {
      get => this.xmlblockexternalentitiesField;
      set => this.xmlblockexternalentitiesField = value;
    }

    internal override base_resource[] get_nitro_response(
      nitro_service service,
      string response)
    {
      appfwprofile_xmldosurl_binding.appfwprofile_xmldosurl_binding_response xmldosurlBindingResponse = new appfwprofile_xmldosurl_binding.appfwprofile_xmldosurl_binding_response();
      appfwprofile_xmldosurl_binding.appfwprofile_xmldosurl_binding_response resource = (appfwprofile_xmldosurl_binding.appfwprofile_xmldosurl_binding_response) service.get_payload_formatter().string_to_resource(xmldosurlBindingResponse.GetType(), response);
      if (resource.errorcode != 0)
      {
        if (resource.errorcode == 444)
          service.clear_session();
        if (resource.severity == null)
          throw new nitro_exception(resource.message, resource.errorcode);
        if (resource.severity.Equals("ERROR"))
          throw new nitro_exception(resource.message, resource.errorcode);
      }
      return (base_resource[]) resource.appfwprofile_xmldosurl_binding;
    }

    internal override string get_object_name() => this.name;

    public static base_response add(
      nitro_service client,
      appfwprofile_xmldosurl_binding resource)
    {
      return new appfwprofile_xmldosurl_binding()
      {
        name = resource.name,
        comment = resource.comment,
        state = resource.state,
        xmldosurl = resource.xmldosurl,
        xmlmaxelementdepthcheck = resource.xmlmaxelementdepthcheck,
        xmlmaxelementdepth = resource.xmlmaxelementdepth,
        xmlmaxelementnamelengthcheck = resource.xmlmaxelementnamelengthcheck,
        xmlmaxelementnamelength = resource.xmlmaxelementnamelength,
        xmlmaxelementscheck = resource.xmlmaxelementscheck,
        xmlmaxelements = resource.xmlmaxelements,
        xmlmaxelementchildrencheck = resource.xmlmaxelementchildrencheck,
        xmlmaxelementchildren = resource.xmlmaxelementchildren,
        xmlmaxattributescheck = resource.xmlmaxattributescheck,
        xmlmaxattributes = resource.xmlmaxattributes,
        xmlmaxattributenamelengthcheck = resource.xmlmaxattributenamelengthcheck,
        xmlmaxattributenamelength = resource.xmlmaxattributenamelength,
        xmlmaxattributevaluelengthcheck = resource.xmlmaxattributevaluelengthcheck,
        xmlmaxattributevaluelength = resource.xmlmaxattributevaluelength,
        xmlmaxchardatalengthcheck = resource.xmlmaxchardatalengthcheck,
        xmlmaxchardatalength = resource.xmlmaxchardatalength,
        xmlmaxfilesizecheck = resource.xmlmaxfilesizecheck,
        xmlmaxfilesize = resource.xmlmaxfilesize,
        xmlminfilesizecheck = resource.xmlminfilesizecheck,
        xmlminfilesize = resource.xmlminfilesize,
        xmlblockpi = resource.xmlblockpi,
        xmlblockdtd = resource.xmlblockdtd,
        xmlblockexternalentities = resource.xmlblockexternalentities,
        xmlmaxentityexpansionscheck = resource.xmlmaxentityexpansionscheck,
        xmlmaxentityexpansions = resource.xmlmaxentityexpansions,
        xmlmaxentityexpansiondepthcheck = resource.xmlmaxentityexpansiondepthcheck,
        xmlmaxentityexpansiondepth = resource.xmlmaxentityexpansiondepth,
        xmlmaxnamespacescheck = resource.xmlmaxnamespacescheck,
        xmlmaxnamespaces = resource.xmlmaxnamespaces,
        xmlmaxnamespaceurilengthcheck = resource.xmlmaxnamespaceurilengthcheck,
        xmlmaxnamespaceurilength = resource.xmlmaxnamespaceurilength,
        xmlsoaparraycheck = resource.xmlsoaparraycheck,
        xmlmaxsoaparraysize = resource.xmlmaxsoaparraysize,
        xmlmaxsoaparrayrank = resource.xmlmaxsoaparrayrank
      }.update_resource(client);
    }

    public static base_responses add(
      nitro_service client,
      appfwprofile_xmldosurl_binding[] resources)
    {
      base_responses baseResponses = (base_responses) null;
      if (resources != null && resources.Length > 0)
      {
        appfwprofile_xmldosurl_binding[] xmldosurlBindingArray = new appfwprofile_xmldosurl_binding[resources.Length];
        for (int index = 0; index < resources.Length; ++index)
        {
          xmldosurlBindingArray[index] = new appfwprofile_xmldosurl_binding();
          xmldosurlBindingArray[index].name = resources[index].name;
          xmldosurlBindingArray[index].comment = resources[index].comment;
          xmldosurlBindingArray[index].state = resources[index].state;
          xmldosurlBindingArray[index].xmldosurl = resources[index].xmldosurl;
          xmldosurlBindingArray[index].xmlmaxelementdepthcheck = resources[index].xmlmaxelementdepthcheck;
          xmldosurlBindingArray[index].xmlmaxelementdepth = resources[index].xmlmaxelementdepth;
          xmldosurlBindingArray[index].xmlmaxelementnamelengthcheck = resources[index].xmlmaxelementnamelengthcheck;
          xmldosurlBindingArray[index].xmlmaxelementnamelength = resources[index].xmlmaxelementnamelength;
          xmldosurlBindingArray[index].xmlmaxelementscheck = resources[index].xmlmaxelementscheck;
          xmldosurlBindingArray[index].xmlmaxelements = resources[index].xmlmaxelements;
          xmldosurlBindingArray[index].xmlmaxelementchildrencheck = resources[index].xmlmaxelementchildrencheck;
          xmldosurlBindingArray[index].xmlmaxelementchildren = resources[index].xmlmaxelementchildren;
          xmldosurlBindingArray[index].xmlmaxattributescheck = resources[index].xmlmaxattributescheck;
          xmldosurlBindingArray[index].xmlmaxattributes = resources[index].xmlmaxattributes;
          xmldosurlBindingArray[index].xmlmaxattributenamelengthcheck = resources[index].xmlmaxattributenamelengthcheck;
          xmldosurlBindingArray[index].xmlmaxattributenamelength = resources[index].xmlmaxattributenamelength;
          xmldosurlBindingArray[index].xmlmaxattributevaluelengthcheck = resources[index].xmlmaxattributevaluelengthcheck;
          xmldosurlBindingArray[index].xmlmaxattributevaluelength = resources[index].xmlmaxattributevaluelength;
          xmldosurlBindingArray[index].xmlmaxchardatalengthcheck = resources[index].xmlmaxchardatalengthcheck;
          xmldosurlBindingArray[index].xmlmaxchardatalength = resources[index].xmlmaxchardatalength;
          xmldosurlBindingArray[index].xmlmaxfilesizecheck = resources[index].xmlmaxfilesizecheck;
          xmldosurlBindingArray[index].xmlmaxfilesize = resources[index].xmlmaxfilesize;
          xmldosurlBindingArray[index].xmlminfilesizecheck = resources[index].xmlminfilesizecheck;
          xmldosurlBindingArray[index].xmlminfilesize = resources[index].xmlminfilesize;
          xmldosurlBindingArray[index].xmlblockpi = resources[index].xmlblockpi;
          xmldosurlBindingArray[index].xmlblockdtd = resources[index].xmlblockdtd;
          xmldosurlBindingArray[index].xmlblockexternalentities = resources[index].xmlblockexternalentities;
          xmldosurlBindingArray[index].xmlmaxentityexpansionscheck = resources[index].xmlmaxentityexpansionscheck;
          xmldosurlBindingArray[index].xmlmaxentityexpansions = resources[index].xmlmaxentityexpansions;
          xmldosurlBindingArray[index].xmlmaxentityexpansiondepthcheck = resources[index].xmlmaxentityexpansiondepthcheck;
          xmldosurlBindingArray[index].xmlmaxentityexpansiondepth = resources[index].xmlmaxentityexpansiondepth;
          xmldosurlBindingArray[index].xmlmaxnamespacescheck = resources[index].xmlmaxnamespacescheck;
          xmldosurlBindingArray[index].xmlmaxnamespaces = resources[index].xmlmaxnamespaces;
          xmldosurlBindingArray[index].xmlmaxnamespaceurilengthcheck = resources[index].xmlmaxnamespaceurilengthcheck;
          xmldosurlBindingArray[index].xmlmaxnamespaceurilength = resources[index].xmlmaxnamespaceurilength;
          xmldosurlBindingArray[index].xmlsoaparraycheck = resources[index].xmlsoaparraycheck;
          xmldosurlBindingArray[index].xmlmaxsoaparraysize = resources[index].xmlmaxsoaparraysize;
          xmldosurlBindingArray[index].xmlmaxsoaparrayrank = resources[index].xmlmaxsoaparrayrank;
        }
        baseResponses = base_resource.update_bulk_request(client, (base_resource[]) xmldosurlBindingArray);
      }
      return baseResponses;
    }

    public static base_response delete(
      nitro_service client,
      appfwprofile_xmldosurl_binding resource)
    {
      return new appfwprofile_xmldosurl_binding()
      {
        name = resource.name,
        xmldosurl = resource.xmldosurl
      }.delete_resource(client);
    }

    public static base_responses delete(
      nitro_service client,
      appfwprofile_xmldosurl_binding[] resources)
    {
      base_responses baseResponses = (base_responses) null;
      if (resources != null && resources.Length > 0)
      {
        appfwprofile_xmldosurl_binding[] xmldosurlBindingArray = new appfwprofile_xmldosurl_binding[resources.Length];
        for (int index = 0; index < resources.Length; ++index)
        {
          xmldosurlBindingArray[index] = new appfwprofile_xmldosurl_binding();
          xmldosurlBindingArray[index].name = resources[index].name;
          xmldosurlBindingArray[index].xmldosurl = resources[index].xmldosurl;
        }
        baseResponses = base_resource.delete_bulk_request(client, (base_resource[]) xmldosurlBindingArray);
      }
      return baseResponses;
    }

    public static appfwprofile_xmldosurl_binding[] get(
      nitro_service service,
      string name)
    {
      return (appfwprofile_xmldosurl_binding[]) new appfwprofile_xmldosurl_binding()
      {
        name = name
      }.get_resources(service, (options) null);
    }

    public static appfwprofile_xmldosurl_binding[] get_filtered(
      nitro_service service,
      string name,
      string filter)
    {
      appfwprofile_xmldosurl_binding xmldosurlBinding = new appfwprofile_xmldosurl_binding();
      xmldosurlBinding.name = name;
      options option = new options();
      option.set_filter(filter);
      return (appfwprofile_xmldosurl_binding[]) xmldosurlBinding.getfiltered(service, option);
    }

    public static appfwprofile_xmldosurl_binding[] get_filtered(
      nitro_service service,
      string name,
      filtervalue[] filter)
    {
      appfwprofile_xmldosurl_binding xmldosurlBinding = new appfwprofile_xmldosurl_binding();
      xmldosurlBinding.name = name;
      options option = new options();
      option.set_filter(filter);
      return (appfwprofile_xmldosurl_binding[]) xmldosurlBinding.getfiltered(service, option);
    }

    public static uint count(nitro_service service, string name)
    {
      appfwprofile_xmldosurl_binding xmldosurlBinding = new appfwprofile_xmldosurl_binding();
      xmldosurlBinding.name = name;
      options option = new options();
      option.set_count(true);
      appfwprofile_xmldosurl_binding[] resources = (appfwprofile_xmldosurl_binding[]) xmldosurlBinding.get_resources(service, option);
      return resources != null && resources.Length > 0 ? resources[0].__count.Value : 0U;
    }

    public static uint count_filtered(nitro_service service, string name, string filter)
    {
      appfwprofile_xmldosurl_binding xmldosurlBinding = new appfwprofile_xmldosurl_binding();
      xmldosurlBinding.name = name;
      options option = new options();
      option.set_count(true);
      option.set_filter(filter);
      appfwprofile_xmldosurl_binding[] xmldosurlBindingArray = (appfwprofile_xmldosurl_binding[]) xmldosurlBinding.getfiltered(service, option);
      return xmldosurlBindingArray != null && xmldosurlBindingArray.Length > 0 ? xmldosurlBindingArray[0].__count.Value : 0U;
    }

    public static uint count_filtered(nitro_service service, string name, filtervalue[] filter)
    {
      appfwprofile_xmldosurl_binding xmldosurlBinding = new appfwprofile_xmldosurl_binding();
      xmldosurlBinding.name = name;
      options option = new options();
      option.set_count(true);
      option.set_filter(filter);
      appfwprofile_xmldosurl_binding[] xmldosurlBindingArray = (appfwprofile_xmldosurl_binding[]) xmldosurlBinding.getfiltered(service, option);
      return xmldosurlBindingArray != null && xmldosurlBindingArray.Length > 0 ? xmldosurlBindingArray[0].__count.Value : 0U;
    }

    private class appfwprofile_xmldosurl_binding_response : base_response
    {
      public appfwprofile_xmldosurl_binding[] appfwprofile_xmldosurl_binding = (appfwprofile_xmldosurl_binding[]) null;
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

    public static class stateEnum
    {
      public const string ENABLED = "ENABLED";
      public const string DISABLED = "DISABLED";
    }

    public static class xmlsoaparraycheckEnum
    {
      public const string ON = "ON";
      public const string OFF = "OFF";
    }

    public static class isregex_ffEnum
    {
      public const string REGEX = "REGEX";
      public const string NOTREGEX = "NOTREGEX";
    }

    public static class xmlmaxelementnamelengthcheckEnum
    {
      public const string ON = "ON";
      public const string OFF = "OFF";
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

    public static class xmlmaxfilesizecheckEnum
    {
      public const string ON = "ON";
      public const string OFF = "OFF";
    }

    public static class xmlmaxnamespacescheckEnum
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

    public static class isregex_sqlEnum
    {
      public const string REGEX = "REGEX";
      public const string NOTREGEX = "NOTREGEX";
    }

    public static class xmlblockpiEnum
    {
      public const string ON = "ON";
      public const string OFF = "OFF";
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

    public static class as_scan_location_xssEnum
    {
      public const string FORMFIELD = "FORMFIELD";
      public const string HEADER = "HEADER";
      public const string COOKIE = "COOKIE";
    }

    public static class xmlmaxnamespaceurilengthcheckEnum
    {
      public const string ON = "ON";
      public const string OFF = "OFF";
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

    public static class xmlmaxattributevaluelengthcheckEnum
    {
      public const string ON = "ON";
      public const string OFF = "OFF";
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

    public static class xmlmaxnodescheckEnum
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
