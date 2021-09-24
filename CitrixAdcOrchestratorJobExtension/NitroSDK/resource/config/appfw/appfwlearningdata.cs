// Decompiled with JetBrains decompiler
// Type: com.citrix.netscaler.nitro.resource.config.appfw.appfwlearningdata
// Assembly: nitro, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 6CF5DDEF-E052-4F9D-953F-6644F8378A66


using com.citrix.netscaler.nitro.exception;
using com.citrix.netscaler.nitro.resource.Base;
using com.citrix.netscaler.nitro.service;
using com.citrix.netscaler.nitro.util;

namespace com.citrix.netscaler.nitro.resource.config.appfw
{
  public class appfwlearningdata : base_resource
  {
    private string profilenameField = (string) null;
    private string starturlField = (string) null;
    private string cookieconsistencyField = (string) null;
    private string fieldconsistencyField = (string) null;
    private string formactionurl_ffcField = (string) null;
    private string contenttypeField = (string) null;
    private string crosssitescriptingField = (string) null;
    private string formactionurl_xssField = (string) null;
    private string as_scan_location_xssField = (string) null;
    private string as_value_type_xssField = (string) null;
    private string as_value_expr_xssField = (string) null;
    private string sqlinjectionField = (string) null;
    private string formactionurl_sqlField = (string) null;
    private string as_scan_location_sqlField = (string) null;
    private string as_value_type_sqlField = (string) null;
    private string as_value_expr_sqlField = (string) null;
    private string fieldformatField = (string) null;
    private string formactionurl_ffField = (string) null;
    private string csrftagField = (string) null;
    private string csrfformoriginurlField = (string) null;
    private string creditcardnumberField = (string) null;
    private string creditcardnumberurlField = (string) null;
    private string xmldoscheckField = (string) null;
    private string xmlwsicheckField = (string) null;
    private string xmlattachmentcheckField = (string) null;
    private bool? totalxmlrequestsField = new bool?();
    private string securitycheckField = (string) null;
    private string targetField = (string) null;
    private string urlField = (string) null;
    private string nameField = (string) null;
    private string fieldtypeField = (string) null;
    private uint? fieldformatminlengthField = new uint?();
    private uint? fieldformatmaxlengthField = new uint?();
    private string fieldformatcharmappcreField = (string) null;
    private string value_typeField = (string) null;
    private string valueField = (string) null;
    private uint? hitsField = new uint?();
    private string dataField = (string) null;
    private uint? __countField = new uint?();

    public uint? __count
    {
      get => this.__countField;
      private set => this.__countField = value;
    }

    public string profilename
    {
      get => this.profilenameField;
      set => this.profilenameField = value;
    }

    public string starturl
    {
      get => this.starturlField;
      set => this.starturlField = value;
    }

    public string cookieconsistency
    {
      get => this.cookieconsistencyField;
      set => this.cookieconsistencyField = value;
    }

    public string fieldconsistency
    {
      get => this.fieldconsistencyField;
      set => this.fieldconsistencyField = value;
    }

    public string formactionurl_ffc
    {
      get => this.formactionurl_ffcField;
      set => this.formactionurl_ffcField = value;
    }

    public string contenttype
    {
      get => this.contenttypeField;
      set => this.contenttypeField = value;
    }

    public string crosssitescripting
    {
      get => this.crosssitescriptingField;
      set => this.crosssitescriptingField = value;
    }

    public string formactionurl_xss
    {
      get => this.formactionurl_xssField;
      set => this.formactionurl_xssField = value;
    }

    public string as_scan_location_xss
    {
      get => this.as_scan_location_xssField;
      set => this.as_scan_location_xssField = value;
    }

    public string as_value_type_xss
    {
      get => this.as_value_type_xssField;
      set => this.as_value_type_xssField = value;
    }

    public string as_value_expr_xss
    {
      get => this.as_value_expr_xssField;
      set => this.as_value_expr_xssField = value;
    }

    public string sqlinjection
    {
      get => this.sqlinjectionField;
      set => this.sqlinjectionField = value;
    }

    public string formactionurl_sql
    {
      get => this.formactionurl_sqlField;
      set => this.formactionurl_sqlField = value;
    }

    public string as_scan_location_sql
    {
      get => this.as_scan_location_sqlField;
      set => this.as_scan_location_sqlField = value;
    }

    public string as_value_type_sql
    {
      get => this.as_value_type_sqlField;
      set => this.as_value_type_sqlField = value;
    }

    public string as_value_expr_sql
    {
      get => this.as_value_expr_sqlField;
      set => this.as_value_expr_sqlField = value;
    }

    public string fieldformat
    {
      get => this.fieldformatField;
      set => this.fieldformatField = value;
    }

    public string formactionurl_ff
    {
      get => this.formactionurl_ffField;
      set => this.formactionurl_ffField = value;
    }

    public string csrftag
    {
      get => this.csrftagField;
      set => this.csrftagField = value;
    }

    public string csrfformoriginurl
    {
      get => this.csrfformoriginurlField;
      set => this.csrfformoriginurlField = value;
    }

    public string creditcardnumber
    {
      get => this.creditcardnumberField;
      set => this.creditcardnumberField = value;
    }

    public string creditcardnumberurl
    {
      get => this.creditcardnumberurlField;
      set => this.creditcardnumberurlField = value;
    }

    public string xmldoscheck
    {
      get => this.xmldoscheckField;
      set => this.xmldoscheckField = value;
    }

    public string xmlwsicheck
    {
      get => this.xmlwsicheckField;
      set => this.xmlwsicheckField = value;
    }

    public string xmlattachmentcheck
    {
      get => this.xmlattachmentcheckField;
      set => this.xmlattachmentcheckField = value;
    }

    public bool? totalxmlrequests
    {
      get => this.totalxmlrequestsField;
      set => this.totalxmlrequestsField = value;
    }

    public string securitycheck
    {
      get => this.securitycheckField;
      set => this.securitycheckField = value;
    }

    public string target
    {
      get => this.targetField;
      set => this.targetField = value;
    }

    public string url
    {
      get => this.urlField;
      private set => this.urlField = value;
    }

    public string name
    {
      get => this.nameField;
      private set => this.nameField = value;
    }

    public string fieldtype
    {
      get => this.fieldtypeField;
      private set => this.fieldtypeField = value;
    }

    public uint? fieldformatminlength
    {
      get => this.fieldformatminlengthField;
      private set => this.fieldformatminlengthField = value;
    }

    public uint? fieldformatmaxlength
    {
      get => this.fieldformatmaxlengthField;
      private set => this.fieldformatmaxlengthField = value;
    }

    public string fieldformatcharmappcre
    {
      get => this.fieldformatcharmappcreField;
      private set => this.fieldformatcharmappcreField = value;
    }

    public string value_type
    {
      get => this.value_typeField;
      private set => this.value_typeField = value;
    }

    public string value
    {
      get => this.valueField;
      private set => this.valueField = value;
    }

    public uint? hits
    {
      get => this.hitsField;
      private set => this.hitsField = value;
    }

    public string data
    {
      get => this.dataField;
      private set => this.dataField = value;
    }

    internal override base_resource[] get_nitro_response(
      nitro_service service,
      string response)
    {
      appfwlearningdata.appfwlearningdata_response appfwlearningdataResponse = new appfwlearningdata.appfwlearningdata_response();
      appfwlearningdata.appfwlearningdata_response resource = (appfwlearningdata.appfwlearningdata_response) service.get_payload_formatter().string_to_resource(appfwlearningdataResponse.GetType(), response);
      if (resource.errorcode != 0)
      {
        if (resource.errorcode == 444)
          service.clear_session();
        if (resource.severity == null)
          throw new nitro_exception(resource.message, resource.errorcode);
        if (resource.severity.Equals("ERROR"))
          throw new nitro_exception(resource.message, resource.errorcode);
      }
      return (base_resource[]) resource.appfwlearningdata;
    }

    internal override string get_object_name() => (string) null;

    public static base_response delete(
      nitro_service client,
      appfwlearningdata resource)
    {
      return new appfwlearningdata()
      {
        profilename = resource.profilename,
        starturl = resource.starturl,
        cookieconsistency = resource.cookieconsistency,
        fieldconsistency = resource.fieldconsistency,
        formactionurl_ffc = resource.formactionurl_ffc,
        contenttype = resource.contenttype,
        crosssitescripting = resource.crosssitescripting,
        formactionurl_xss = resource.formactionurl_xss,
        as_scan_location_xss = resource.as_scan_location_xss,
        as_value_type_xss = resource.as_value_type_xss,
        as_value_expr_xss = resource.as_value_expr_xss,
        sqlinjection = resource.sqlinjection,
        formactionurl_sql = resource.formactionurl_sql,
        as_scan_location_sql = resource.as_scan_location_sql,
        as_value_type_sql = resource.as_value_type_sql,
        as_value_expr_sql = resource.as_value_expr_sql,
        fieldformat = resource.fieldformat,
        formactionurl_ff = resource.formactionurl_ff,
        csrftag = resource.csrftag,
        csrfformoriginurl = resource.csrfformoriginurl,
        creditcardnumber = resource.creditcardnumber,
        creditcardnumberurl = resource.creditcardnumberurl,
        xmldoscheck = resource.xmldoscheck,
        xmlwsicheck = resource.xmlwsicheck,
        xmlattachmentcheck = resource.xmlattachmentcheck,
        totalxmlrequests = resource.totalxmlrequests
      }.delete_resource(client);
    }

    public static base_responses delete(
      nitro_service client,
      appfwlearningdata[] resources)
    {
      base_responses baseResponses = (base_responses) null;
      if (resources != null && resources.Length > 0)
      {
        appfwlearningdata[] appfwlearningdataArray = new appfwlearningdata[resources.Length];
        for (int index = 0; index < resources.Length; ++index)
        {
          appfwlearningdataArray[index] = new appfwlearningdata();
          appfwlearningdataArray[index].profilename = resources[index].profilename;
          appfwlearningdataArray[index].starturl = resources[index].starturl;
          appfwlearningdataArray[index].cookieconsistency = resources[index].cookieconsistency;
          appfwlearningdataArray[index].fieldconsistency = resources[index].fieldconsistency;
          appfwlearningdataArray[index].formactionurl_ffc = resources[index].formactionurl_ffc;
          appfwlearningdataArray[index].contenttype = resources[index].contenttype;
          appfwlearningdataArray[index].crosssitescripting = resources[index].crosssitescripting;
          appfwlearningdataArray[index].formactionurl_xss = resources[index].formactionurl_xss;
          appfwlearningdataArray[index].as_scan_location_xss = resources[index].as_scan_location_xss;
          appfwlearningdataArray[index].as_value_type_xss = resources[index].as_value_type_xss;
          appfwlearningdataArray[index].as_value_expr_xss = resources[index].as_value_expr_xss;
          appfwlearningdataArray[index].sqlinjection = resources[index].sqlinjection;
          appfwlearningdataArray[index].formactionurl_sql = resources[index].formactionurl_sql;
          appfwlearningdataArray[index].as_scan_location_sql = resources[index].as_scan_location_sql;
          appfwlearningdataArray[index].as_value_type_sql = resources[index].as_value_type_sql;
          appfwlearningdataArray[index].as_value_expr_sql = resources[index].as_value_expr_sql;
          appfwlearningdataArray[index].fieldformat = resources[index].fieldformat;
          appfwlearningdataArray[index].formactionurl_ff = resources[index].formactionurl_ff;
          appfwlearningdataArray[index].csrftag = resources[index].csrftag;
          appfwlearningdataArray[index].csrfformoriginurl = resources[index].csrfformoriginurl;
          appfwlearningdataArray[index].creditcardnumber = resources[index].creditcardnumber;
          appfwlearningdataArray[index].creditcardnumberurl = resources[index].creditcardnumberurl;
          appfwlearningdataArray[index].xmldoscheck = resources[index].xmldoscheck;
          appfwlearningdataArray[index].xmlwsicheck = resources[index].xmlwsicheck;
          appfwlearningdataArray[index].xmlattachmentcheck = resources[index].xmlattachmentcheck;
          appfwlearningdataArray[index].totalxmlrequests = resources[index].totalxmlrequests;
        }
        baseResponses = base_resource.delete_bulk_request(client, (base_resource[]) appfwlearningdataArray);
      }
      return baseResponses;
    }

    public static base_response reset(nitro_service client) => new appfwlearningdata().perform_operation_byaction(client, nameof (reset));

    public static base_responses reset(
      nitro_service client,
      appfwlearningdata[] resources)
    {
      base_responses baseResponses = (base_responses) null;
      if (resources != null && resources.Length > 0)
      {
        appfwlearningdata[] appfwlearningdataArray = new appfwlearningdata[resources.Length];
        for (int index = 0; index < resources.Length; ++index)
          appfwlearningdataArray[index] = new appfwlearningdata();
        baseResponses = base_resource.perform_operation_bulk_request(client, (base_resource[]) appfwlearningdataArray, nameof (reset));
      }
      return baseResponses;
    }

    public static base_response export(
      nitro_service client,
      appfwlearningdata resource)
    {
      return new appfwlearningdata()
      {
        profilename = resource.profilename,
        securitycheck = resource.securitycheck,
        target = resource.target
      }.perform_operation_byaction(client, nameof (export));
    }

    public static base_responses export(
      nitro_service client,
      appfwlearningdata[] resources)
    {
      base_responses baseResponses = (base_responses) null;
      if (resources != null && resources.Length > 0)
      {
        appfwlearningdata[] appfwlearningdataArray = new appfwlearningdata[resources.Length];
        for (int index = 0; index < resources.Length; ++index)
        {
          appfwlearningdataArray[index] = new appfwlearningdata();
          appfwlearningdataArray[index].profilename = resources[index].profilename;
          appfwlearningdataArray[index].securitycheck = resources[index].securitycheck;
          appfwlearningdataArray[index].target = resources[index].target;
        }
        baseResponses = base_resource.perform_operation_bulk_request(client, (base_resource[]) appfwlearningdataArray, nameof (export));
      }
      return baseResponses;
    }

    public static appfwlearningdata get(
      nitro_service service,
      appfwlearningdata obj)
    {
      options option = new options();
      option.set_args(nitro_util.object_to_string_withoutquotes((object) obj));
      return (appfwlearningdata) obj.get_resource(service, option);
    }

    public static appfwlearningdata[] get(
      nitro_service service,
      appfwlearningdata[] obj)
    {
      if (obj == null || obj.Length <= 0)
        return (appfwlearningdata[]) null;
      appfwlearningdata[] appfwlearningdataArray = new appfwlearningdata[obj.Length];
      for (int index = 0; index < obj.Length; ++index)
      {
        options option = new options();
        option.set_args(nitro_util.object_to_string_withoutquotes((object) obj[index]));
        appfwlearningdataArray[index] = (appfwlearningdata) obj[index].get_resource(service, option);
      }
      return appfwlearningdataArray;
    }

    public static appfwlearningdata[] get(
      nitro_service service,
      appfwlearningdata_args args)
    {
      appfwlearningdata appfwlearningdata = new appfwlearningdata();
      options option = new options();
      option.set_args(nitro_util.object_to_string_withoutquotes((object) args));
      return (appfwlearningdata[]) appfwlearningdata.get_resources(service, option);
    }

    public static appfwlearningdata[] get_filtered(
      nitro_service service,
      appfwlearningdata obj,
      string filter)
    {
      options option = new options();
      option.set_filter(filter);
      option.set_args(nitro_util.object_to_string_withoutquotes((object) obj));
      return (appfwlearningdata[]) obj.getfiltered(service, option);
    }

    public static appfwlearningdata[] get_filtered(
      nitro_service service,
      appfwlearningdata obj,
      filtervalue[] filter)
    {
      options option = new options();
      option.set_filter(filter);
      option.set_args(nitro_util.object_to_string_withoutquotes((object) obj));
      return (appfwlearningdata[]) obj.getfiltered(service, option);
    }

    public static uint count(nitro_service service, appfwlearningdata obj)
    {
      options option = new options();
      option.set_count(true);
      option.set_args(nitro_util.object_to_string_withoutquotes((object) obj));
      appfwlearningdata[] resources = (appfwlearningdata[]) obj.get_resources(service, option);
      return resources != null && resources.Length > 0 ? resources[0].__count.Value : 0U;
    }

    public static uint count_filtered(nitro_service service, appfwlearningdata obj, string filter)
    {
      options option = new options();
      option.set_count(true);
      option.set_filter(filter);
      option.set_args(nitro_util.object_to_string_withoutquotes((object) obj));
      appfwlearningdata[] appfwlearningdataArray = (appfwlearningdata[]) obj.getfiltered(service, option);
      return appfwlearningdataArray != null && appfwlearningdataArray.Length > 0 ? appfwlearningdataArray[0].__count.Value : 0U;
    }

    public static uint count_filtered(
      nitro_service service,
      appfwlearningdata obj,
      filtervalue[] filter)
    {
      options option = new options();
      option.set_count(true);
      option.set_filter(filter);
      option.set_args(nitro_util.object_to_string_withoutquotes((object) obj));
      appfwlearningdata[] appfwlearningdataArray = (appfwlearningdata[]) obj.getfiltered(service, option);
      return appfwlearningdataArray != null && appfwlearningdataArray.Length > 0 ? appfwlearningdataArray[0].__count.Value : 0U;
    }

    private class appfwlearningdata_response : base_response
    {
      public appfwlearningdata[] appfwlearningdata = (appfwlearningdata[]) null;
    }

    public static class as_scan_location_xssEnum
    {
      public const string FORMFIELD = "FORMFIELD";
      public const string HEADER = "HEADER";
      public const string COOKIE = "COOKIE";
    }

    public static class as_scan_location_sqlEnum
    {
      public const string FORMFIELD = "FORMFIELD";
      public const string HEADER = "HEADER";
      public const string COOKIE = "COOKIE";
    }

    public static class securitycheckEnum
    {
      public const string startURL = "startURL";
      public const string cookieConsistency = "cookieConsistency";
      public const string fieldConsistency = "fieldConsistency";
      public const string crossSiteScripting = "crossSiteScripting";
      public const string SQLInjection = "SQLInjection";
      public const string fieldFormat = "fieldFormat";
      public const string CSRFtag = "CSRFtag";
      public const string XMLDoSCheck = "XMLDoSCheck";
      public const string XMLWSICheck = "XMLWSICheck";
      public const string XMLAttachmentCheck = "XMLAttachmentCheck";
      public const string TotalXMLRequests = "TotalXMLRequests";
      public const string creditCardNumber = "creditCardNumber";
      public const string ContentType = "ContentType";
    }

    public static class as_value_type_sqlEnum
    {
      public const string Keyword = "Keyword";
      public const string SpecialString = "SpecialString";
      public const string Wildchar = "Wildchar";
    }

    public static class as_value_type_xssEnum
    {
      public const string Tag = "Tag";
      public const string Attribute = "Attribute";
      public const string Pattern = "Pattern";
    }
  }
}
