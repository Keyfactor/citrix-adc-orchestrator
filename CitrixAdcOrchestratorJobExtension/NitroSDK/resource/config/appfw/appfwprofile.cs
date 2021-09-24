// Decompiled with JetBrains decompiler
// Type: com.citrix.netscaler.nitro.resource.config.appfw.appfwprofile
// Assembly: nitro, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 6CF5DDEF-E052-4F9D-953F-6644F8378A66


using com.citrix.netscaler.nitro.exception;
using com.citrix.netscaler.nitro.resource.Base;
using com.citrix.netscaler.nitro.service;
using com.citrix.netscaler.nitro.util;

namespace com.citrix.netscaler.nitro.resource.config.appfw
{
  public class appfwprofile : base_resource
  {
    private string nameField = (string) null;
    private string defaultsField = (string) null;
    private string[] starturlactionField = (string[]) null;
    private string[] contenttypeactionField = (string[]) null;
    private string[] inspectcontenttypesField = (string[]) null;
    private string starturlclosureField = (string) null;
    private string[] denyurlactionField = (string[]) null;
    private string refererheadercheckField = (string) null;
    private string[] cookieconsistencyactionField = (string[]) null;
    private string cookietransformsField = (string) null;
    private string cookieencryptionField = (string) null;
    private string cookieproxyingField = (string) null;
    private string addcookieflagsField = (string) null;
    private string[] fieldconsistencyactionField = (string[]) null;
    private string[] csrftagactionField = (string[]) null;
    private string[] crosssitescriptingactionField = (string[]) null;
    private string crosssitescriptingtransformunsafehtmlField = (string) null;
    private string crosssitescriptingcheckcompleteurlsField = (string) null;
    private string[] sqlinjectionactionField = (string[]) null;
    private string sqlinjectiontransformspecialcharsField = (string) null;
    private string sqlinjectiononlycheckfieldswithsqlcharsField = (string) null;
    private string sqlinjectiontypeField = (string) null;
    private string sqlinjectionchecksqlwildcharsField = (string) null;
    private string[] fieldformatactionField = (string[]) null;
    private string defaultfieldformattypeField = (string) null;
    private uint? defaultfieldformatminlengthField = new uint?();
    private uint? defaultfieldformatmaxlengthField = new uint?();
    private string[] bufferoverflowactionField = (string[]) null;
    private uint? bufferoverflowmaxurllengthField = new uint?();
    private uint? bufferoverflowmaxheaderlengthField = new uint?();
    private uint? bufferoverflowmaxcookielengthField = new uint?();
    private string[] creditcardactionField = (string[]) null;
    private string[] creditcardField = (string[]) null;
    private uint? creditcardmaxallowedField = new uint?();
    private string creditcardxoutField = (string) null;
    private string dosecurecreditcardloggingField = (string) null;
    private string streamingField = (string) null;
    private string traceField = (string) null;
    private string requestcontenttypeField = (string) null;
    private string responsecontenttypeField = (string) null;
    private string[] xmldosactionField = (string[]) null;
    private string[] xmlformatactionField = (string[]) null;
    private string[] xmlsqlinjectionactionField = (string[]) null;
    private string xmlsqlinjectiononlycheckfieldswithsqlcharsField = (string) null;
    private string xmlsqlinjectiontypeField = (string) null;
    private string xmlsqlinjectionchecksqlwildcharsField = (string) null;
    private string xmlsqlinjectionparsecommentsField = (string) null;
    private string[] xmlxssactionField = (string[]) null;
    private string[] xmlwsiactionField = (string[]) null;
    private string[] xmlattachmentactionField = (string[]) null;
    private string[] xmlvalidationactionField = (string[]) null;
    private string xmlerrorobjectField = (string) null;
    private string customsettingsField = (string) null;
    private string signaturesField = (string) null;
    private string[] xmlsoapfaultactionField = (string[]) null;
    private string usehtmlerrorobjectField = (string) null;
    private string errorurlField = (string) null;
    private string htmlerrorobjectField = (string) null;
    private string logeverypolicyhitField = (string) null;
    private string stripcommentsField = (string) null;
    private string striphtmlcommentsField = (string) null;
    private string stripxmlcommentsField = (string) null;
    private string exemptclosureurlsfromsecuritychecksField = (string) null;
    private string defaultcharsetField = (string) null;
    private uint? postbodylimitField = new uint?();
    private uint? fileuploadmaxnumField = new uint?();
    private string canonicalizehtmlresponseField = (string) null;
    private string enableformtaggingField = (string) null;
    private string sessionlessfieldconsistencyField = (string) null;
    private string sessionlessurlclosureField = (string) null;
    private string semicolonfieldseparatorField = (string) null;
    private string excludefileuploadfromchecksField = (string) null;
    private string sqlinjectionparsecommentsField = (string) null;
    private string invalidpercenthandlingField = (string) null;
    private string[] typeField = (string[]) null;
    private string checkrequestheadersField = (string) null;
    private string optimizepartialreqsField = (string) null;
    private string urldecoderequestcookiesField = (string) null;
    private string commentField = (string) null;
    private string archivenameField = (string) null;
    private string csrftagField = (string) null;
    private string stateField = (string) null;
    private bool? builtinField = new bool?();
    private uint? __countField = new uint?();

    public uint? __count
    {
      get => this.__countField;
      private set => this.__countField = value;
    }

    public string name
    {
      get => this.nameField;
      set => this.nameField = value;
    }

    public string defaults
    {
      get => this.defaultsField;
      set => this.defaultsField = value;
    }

    public string[] starturlaction
    {
      get => this.starturlactionField;
      set => this.starturlactionField = value;
    }

    public string[] contenttypeaction
    {
      get => this.contenttypeactionField;
      set => this.contenttypeactionField = value;
    }

    public string[] inspectcontenttypes
    {
      get => this.inspectcontenttypesField;
      set => this.inspectcontenttypesField = value;
    }

    public string starturlclosure
    {
      get => this.starturlclosureField;
      set => this.starturlclosureField = value;
    }

    public string[] denyurlaction
    {
      get => this.denyurlactionField;
      set => this.denyurlactionField = value;
    }

    public string refererheadercheck
    {
      get => this.refererheadercheckField;
      set => this.refererheadercheckField = value;
    }

    public string[] cookieconsistencyaction
    {
      get => this.cookieconsistencyactionField;
      set => this.cookieconsistencyactionField = value;
    }

    public string cookietransforms
    {
      get => this.cookietransformsField;
      set => this.cookietransformsField = value;
    }

    public string cookieencryption
    {
      get => this.cookieencryptionField;
      set => this.cookieencryptionField = value;
    }

    public string cookieproxying
    {
      get => this.cookieproxyingField;
      set => this.cookieproxyingField = value;
    }

    public string addcookieflags
    {
      get => this.addcookieflagsField;
      set => this.addcookieflagsField = value;
    }

    public string[] fieldconsistencyaction
    {
      get => this.fieldconsistencyactionField;
      set => this.fieldconsistencyactionField = value;
    }

    public string[] csrftagaction
    {
      get => this.csrftagactionField;
      set => this.csrftagactionField = value;
    }

    public string[] crosssitescriptingaction
    {
      get => this.crosssitescriptingactionField;
      set => this.crosssitescriptingactionField = value;
    }

    public string crosssitescriptingtransformunsafehtml
    {
      get => this.crosssitescriptingtransformunsafehtmlField;
      set => this.crosssitescriptingtransformunsafehtmlField = value;
    }

    public string crosssitescriptingcheckcompleteurls
    {
      get => this.crosssitescriptingcheckcompleteurlsField;
      set => this.crosssitescriptingcheckcompleteurlsField = value;
    }

    public string[] sqlinjectionaction
    {
      get => this.sqlinjectionactionField;
      set => this.sqlinjectionactionField = value;
    }

    public string sqlinjectiontransformspecialchars
    {
      get => this.sqlinjectiontransformspecialcharsField;
      set => this.sqlinjectiontransformspecialcharsField = value;
    }

    public string sqlinjectiononlycheckfieldswithsqlchars
    {
      get => this.sqlinjectiononlycheckfieldswithsqlcharsField;
      set => this.sqlinjectiononlycheckfieldswithsqlcharsField = value;
    }

    public string sqlinjectiontype
    {
      get => this.sqlinjectiontypeField;
      set => this.sqlinjectiontypeField = value;
    }

    public string sqlinjectionchecksqlwildchars
    {
      get => this.sqlinjectionchecksqlwildcharsField;
      set => this.sqlinjectionchecksqlwildcharsField = value;
    }

    public string[] fieldformataction
    {
      get => this.fieldformatactionField;
      set => this.fieldformatactionField = value;
    }

    public string defaultfieldformattype
    {
      get => this.defaultfieldformattypeField;
      set => this.defaultfieldformattypeField = value;
    }

    public uint? defaultfieldformatminlength
    {
      get => this.defaultfieldformatminlengthField;
      set => this.defaultfieldformatminlengthField = value;
    }

    public uint? defaultfieldformatmaxlength
    {
      get => this.defaultfieldformatmaxlengthField;
      set => this.defaultfieldformatmaxlengthField = value;
    }

    public string[] bufferoverflowaction
    {
      get => this.bufferoverflowactionField;
      set => this.bufferoverflowactionField = value;
    }

    public uint? bufferoverflowmaxurllength
    {
      get => this.bufferoverflowmaxurllengthField;
      set => this.bufferoverflowmaxurllengthField = value;
    }

    public uint? bufferoverflowmaxheaderlength
    {
      get => this.bufferoverflowmaxheaderlengthField;
      set => this.bufferoverflowmaxheaderlengthField = value;
    }

    public uint? bufferoverflowmaxcookielength
    {
      get => this.bufferoverflowmaxcookielengthField;
      set => this.bufferoverflowmaxcookielengthField = value;
    }

    public string[] creditcardaction
    {
      get => this.creditcardactionField;
      set => this.creditcardactionField = value;
    }

    public string[] creditcard
    {
      get => this.creditcardField;
      set => this.creditcardField = value;
    }

    public uint? creditcardmaxallowed
    {
      get => this.creditcardmaxallowedField;
      set => this.creditcardmaxallowedField = value;
    }

    public string creditcardxout
    {
      get => this.creditcardxoutField;
      set => this.creditcardxoutField = value;
    }

    public string dosecurecreditcardlogging
    {
      get => this.dosecurecreditcardloggingField;
      set => this.dosecurecreditcardloggingField = value;
    }

    public string streaming
    {
      get => this.streamingField;
      set => this.streamingField = value;
    }

    public string trace
    {
      get => this.traceField;
      set => this.traceField = value;
    }

    public string requestcontenttype
    {
      get => this.requestcontenttypeField;
      set => this.requestcontenttypeField = value;
    }

    public string responsecontenttype
    {
      get => this.responsecontenttypeField;
      set => this.responsecontenttypeField = value;
    }

    public string[] xmldosaction
    {
      get => this.xmldosactionField;
      set => this.xmldosactionField = value;
    }

    public string[] xmlformataction
    {
      get => this.xmlformatactionField;
      set => this.xmlformatactionField = value;
    }

    public string[] xmlsqlinjectionaction
    {
      get => this.xmlsqlinjectionactionField;
      set => this.xmlsqlinjectionactionField = value;
    }

    public string xmlsqlinjectiononlycheckfieldswithsqlchars
    {
      get => this.xmlsqlinjectiononlycheckfieldswithsqlcharsField;
      set => this.xmlsqlinjectiononlycheckfieldswithsqlcharsField = value;
    }

    public string xmlsqlinjectiontype
    {
      get => this.xmlsqlinjectiontypeField;
      set => this.xmlsqlinjectiontypeField = value;
    }

    public string xmlsqlinjectionchecksqlwildchars
    {
      get => this.xmlsqlinjectionchecksqlwildcharsField;
      set => this.xmlsqlinjectionchecksqlwildcharsField = value;
    }

    public string xmlsqlinjectionparsecomments
    {
      get => this.xmlsqlinjectionparsecommentsField;
      set => this.xmlsqlinjectionparsecommentsField = value;
    }

    public string[] xmlxssaction
    {
      get => this.xmlxssactionField;
      set => this.xmlxssactionField = value;
    }

    public string[] xmlwsiaction
    {
      get => this.xmlwsiactionField;
      set => this.xmlwsiactionField = value;
    }

    public string[] xmlattachmentaction
    {
      get => this.xmlattachmentactionField;
      set => this.xmlattachmentactionField = value;
    }

    public string[] xmlvalidationaction
    {
      get => this.xmlvalidationactionField;
      set => this.xmlvalidationactionField = value;
    }

    public string xmlerrorobject
    {
      get => this.xmlerrorobjectField;
      set => this.xmlerrorobjectField = value;
    }

    public string customsettings
    {
      get => this.customsettingsField;
      set => this.customsettingsField = value;
    }

    public string signatures
    {
      get => this.signaturesField;
      set => this.signaturesField = value;
    }

    public string[] xmlsoapfaultaction
    {
      get => this.xmlsoapfaultactionField;
      set => this.xmlsoapfaultactionField = value;
    }

    public string usehtmlerrorobject
    {
      get => this.usehtmlerrorobjectField;
      set => this.usehtmlerrorobjectField = value;
    }

    public string errorurl
    {
      get => this.errorurlField;
      set => this.errorurlField = value;
    }

    public string htmlerrorobject
    {
      get => this.htmlerrorobjectField;
      set => this.htmlerrorobjectField = value;
    }

    public string logeverypolicyhit
    {
      get => this.logeverypolicyhitField;
      set => this.logeverypolicyhitField = value;
    }

    public string stripcomments
    {
      get => this.stripcommentsField;
      set => this.stripcommentsField = value;
    }

    public string striphtmlcomments
    {
      get => this.striphtmlcommentsField;
      set => this.striphtmlcommentsField = value;
    }

    public string stripxmlcomments
    {
      get => this.stripxmlcommentsField;
      set => this.stripxmlcommentsField = value;
    }

    public string exemptclosureurlsfromsecuritychecks
    {
      get => this.exemptclosureurlsfromsecuritychecksField;
      set => this.exemptclosureurlsfromsecuritychecksField = value;
    }

    public string defaultcharset
    {
      get => this.defaultcharsetField;
      set => this.defaultcharsetField = value;
    }

    public uint? postbodylimit
    {
      get => this.postbodylimitField;
      set => this.postbodylimitField = value;
    }

    public uint? fileuploadmaxnum
    {
      get => this.fileuploadmaxnumField;
      set => this.fileuploadmaxnumField = value;
    }

    public string canonicalizehtmlresponse
    {
      get => this.canonicalizehtmlresponseField;
      set => this.canonicalizehtmlresponseField = value;
    }

    public string enableformtagging
    {
      get => this.enableformtaggingField;
      set => this.enableformtaggingField = value;
    }

    public string sessionlessfieldconsistency
    {
      get => this.sessionlessfieldconsistencyField;
      set => this.sessionlessfieldconsistencyField = value;
    }

    public string sessionlessurlclosure
    {
      get => this.sessionlessurlclosureField;
      set => this.sessionlessurlclosureField = value;
    }

    public string semicolonfieldseparator
    {
      get => this.semicolonfieldseparatorField;
      set => this.semicolonfieldseparatorField = value;
    }

    public string excludefileuploadfromchecks
    {
      get => this.excludefileuploadfromchecksField;
      set => this.excludefileuploadfromchecksField = value;
    }

    public string sqlinjectionparsecomments
    {
      get => this.sqlinjectionparsecommentsField;
      set => this.sqlinjectionparsecommentsField = value;
    }

    public string invalidpercenthandling
    {
      get => this.invalidpercenthandlingField;
      set => this.invalidpercenthandlingField = value;
    }

    public string[] type
    {
      get => this.typeField;
      set => this.typeField = value;
    }

    public string checkrequestheaders
    {
      get => this.checkrequestheadersField;
      set => this.checkrequestheadersField = value;
    }

    public string optimizepartialreqs
    {
      get => this.optimizepartialreqsField;
      set => this.optimizepartialreqsField = value;
    }

    public string urldecoderequestcookies
    {
      get => this.urldecoderequestcookiesField;
      set => this.urldecoderequestcookiesField = value;
    }

    public string comment
    {
      get => this.commentField;
      set => this.commentField = value;
    }

    public string archivename
    {
      get => this.archivenameField;
      set => this.archivenameField = value;
    }

    public string csrftag
    {
      get => this.csrftagField;
      private set => this.csrftagField = value;
    }

    public string state
    {
      get => this.stateField;
      private set => this.stateField = value;
    }

    public bool? builtin
    {
      get => this.builtinField;
      private set => this.builtinField = value;
    }

    internal override base_resource[] get_nitro_response(
      nitro_service service,
      string response)
    {
      appfwprofile.appfwprofile_response appfwprofileResponse = new appfwprofile.appfwprofile_response();
      appfwprofile.appfwprofile_response resource = (appfwprofile.appfwprofile_response) service.get_payload_formatter().string_to_resource(appfwprofileResponse.GetType(), response);
      if (resource.errorcode != 0)
      {
        if (resource.errorcode == 444)
          service.clear_session();
        if (resource.severity == null)
          throw new nitro_exception(resource.message, resource.errorcode);
        if (resource.severity.Equals("ERROR"))
          throw new nitro_exception(resource.message, resource.errorcode);
      }
      return (base_resource[]) resource.appfwprofile;
    }

    internal override string get_object_name() => this.name;

    public static base_response add(nitro_service client, appfwprofile resource) => new appfwprofile()
    {
      name = resource.name,
      defaults = resource.defaults,
      starturlaction = resource.starturlaction,
      contenttypeaction = resource.contenttypeaction,
      inspectcontenttypes = resource.inspectcontenttypes,
      starturlclosure = resource.starturlclosure,
      denyurlaction = resource.denyurlaction,
      refererheadercheck = resource.refererheadercheck,
      cookieconsistencyaction = resource.cookieconsistencyaction,
      cookietransforms = resource.cookietransforms,
      cookieencryption = resource.cookieencryption,
      cookieproxying = resource.cookieproxying,
      addcookieflags = resource.addcookieflags,
      fieldconsistencyaction = resource.fieldconsistencyaction,
      csrftagaction = resource.csrftagaction,
      crosssitescriptingaction = resource.crosssitescriptingaction,
      crosssitescriptingtransformunsafehtml = resource.crosssitescriptingtransformunsafehtml,
      crosssitescriptingcheckcompleteurls = resource.crosssitescriptingcheckcompleteurls,
      sqlinjectionaction = resource.sqlinjectionaction,
      sqlinjectiontransformspecialchars = resource.sqlinjectiontransformspecialchars,
      sqlinjectiononlycheckfieldswithsqlchars = resource.sqlinjectiononlycheckfieldswithsqlchars,
      sqlinjectiontype = resource.sqlinjectiontype,
      sqlinjectionchecksqlwildchars = resource.sqlinjectionchecksqlwildchars,
      fieldformataction = resource.fieldformataction,
      defaultfieldformattype = resource.defaultfieldformattype,
      defaultfieldformatminlength = resource.defaultfieldformatminlength,
      defaultfieldformatmaxlength = resource.defaultfieldformatmaxlength,
      bufferoverflowaction = resource.bufferoverflowaction,
      bufferoverflowmaxurllength = resource.bufferoverflowmaxurllength,
      bufferoverflowmaxheaderlength = resource.bufferoverflowmaxheaderlength,
      bufferoverflowmaxcookielength = resource.bufferoverflowmaxcookielength,
      creditcardaction = resource.creditcardaction,
      creditcard = resource.creditcard,
      creditcardmaxallowed = resource.creditcardmaxallowed,
      creditcardxout = resource.creditcardxout,
      dosecurecreditcardlogging = resource.dosecurecreditcardlogging,
      streaming = resource.streaming,
      trace = resource.trace,
      requestcontenttype = resource.requestcontenttype,
      responsecontenttype = resource.responsecontenttype,
      xmldosaction = resource.xmldosaction,
      xmlformataction = resource.xmlformataction,
      xmlsqlinjectionaction = resource.xmlsqlinjectionaction,
      xmlsqlinjectiononlycheckfieldswithsqlchars = resource.xmlsqlinjectiononlycheckfieldswithsqlchars,
      xmlsqlinjectiontype = resource.xmlsqlinjectiontype,
      xmlsqlinjectionchecksqlwildchars = resource.xmlsqlinjectionchecksqlwildchars,
      xmlsqlinjectionparsecomments = resource.xmlsqlinjectionparsecomments,
      xmlxssaction = resource.xmlxssaction,
      xmlwsiaction = resource.xmlwsiaction,
      xmlattachmentaction = resource.xmlattachmentaction,
      xmlvalidationaction = resource.xmlvalidationaction,
      xmlerrorobject = resource.xmlerrorobject,
      customsettings = resource.customsettings,
      signatures = resource.signatures,
      xmlsoapfaultaction = resource.xmlsoapfaultaction,
      usehtmlerrorobject = resource.usehtmlerrorobject,
      errorurl = resource.errorurl,
      htmlerrorobject = resource.htmlerrorobject,
      logeverypolicyhit = resource.logeverypolicyhit,
      stripcomments = resource.stripcomments,
      striphtmlcomments = resource.striphtmlcomments,
      stripxmlcomments = resource.stripxmlcomments,
      exemptclosureurlsfromsecuritychecks = resource.exemptclosureurlsfromsecuritychecks,
      defaultcharset = resource.defaultcharset,
      postbodylimit = resource.postbodylimit,
      fileuploadmaxnum = resource.fileuploadmaxnum,
      canonicalizehtmlresponse = resource.canonicalizehtmlresponse,
      enableformtagging = resource.enableformtagging,
      sessionlessfieldconsistency = resource.sessionlessfieldconsistency,
      sessionlessurlclosure = resource.sessionlessurlclosure,
      semicolonfieldseparator = resource.semicolonfieldseparator,
      excludefileuploadfromchecks = resource.excludefileuploadfromchecks,
      sqlinjectionparsecomments = resource.sqlinjectionparsecomments,
      invalidpercenthandling = resource.invalidpercenthandling,
      type = resource.type,
      checkrequestheaders = resource.checkrequestheaders,
      optimizepartialreqs = resource.optimizepartialreqs,
      urldecoderequestcookies = resource.urldecoderequestcookies,
      comment = resource.comment
    }.add_resource(client);

    public static base_responses add(nitro_service client, appfwprofile[] resources)
    {
      base_responses baseResponses = (base_responses) null;
      if (resources != null && resources.Length > 0)
      {
        appfwprofile[] appfwprofileArray = new appfwprofile[resources.Length];
        for (int index = 0; index < resources.Length; ++index)
        {
          appfwprofileArray[index] = new appfwprofile();
          appfwprofileArray[index].name = resources[index].name;
          appfwprofileArray[index].defaults = resources[index].defaults;
          appfwprofileArray[index].starturlaction = resources[index].starturlaction;
          appfwprofileArray[index].contenttypeaction = resources[index].contenttypeaction;
          appfwprofileArray[index].inspectcontenttypes = resources[index].inspectcontenttypes;
          appfwprofileArray[index].starturlclosure = resources[index].starturlclosure;
          appfwprofileArray[index].denyurlaction = resources[index].denyurlaction;
          appfwprofileArray[index].refererheadercheck = resources[index].refererheadercheck;
          appfwprofileArray[index].cookieconsistencyaction = resources[index].cookieconsistencyaction;
          appfwprofileArray[index].cookietransforms = resources[index].cookietransforms;
          appfwprofileArray[index].cookieencryption = resources[index].cookieencryption;
          appfwprofileArray[index].cookieproxying = resources[index].cookieproxying;
          appfwprofileArray[index].addcookieflags = resources[index].addcookieflags;
          appfwprofileArray[index].fieldconsistencyaction = resources[index].fieldconsistencyaction;
          appfwprofileArray[index].csrftagaction = resources[index].csrftagaction;
          appfwprofileArray[index].crosssitescriptingaction = resources[index].crosssitescriptingaction;
          appfwprofileArray[index].crosssitescriptingtransformunsafehtml = resources[index].crosssitescriptingtransformunsafehtml;
          appfwprofileArray[index].crosssitescriptingcheckcompleteurls = resources[index].crosssitescriptingcheckcompleteurls;
          appfwprofileArray[index].sqlinjectionaction = resources[index].sqlinjectionaction;
          appfwprofileArray[index].sqlinjectiontransformspecialchars = resources[index].sqlinjectiontransformspecialchars;
          appfwprofileArray[index].sqlinjectiononlycheckfieldswithsqlchars = resources[index].sqlinjectiononlycheckfieldswithsqlchars;
          appfwprofileArray[index].sqlinjectiontype = resources[index].sqlinjectiontype;
          appfwprofileArray[index].sqlinjectionchecksqlwildchars = resources[index].sqlinjectionchecksqlwildchars;
          appfwprofileArray[index].fieldformataction = resources[index].fieldformataction;
          appfwprofileArray[index].defaultfieldformattype = resources[index].defaultfieldformattype;
          appfwprofileArray[index].defaultfieldformatminlength = resources[index].defaultfieldformatminlength;
          appfwprofileArray[index].defaultfieldformatmaxlength = resources[index].defaultfieldformatmaxlength;
          appfwprofileArray[index].bufferoverflowaction = resources[index].bufferoverflowaction;
          appfwprofileArray[index].bufferoverflowmaxurllength = resources[index].bufferoverflowmaxurllength;
          appfwprofileArray[index].bufferoverflowmaxheaderlength = resources[index].bufferoverflowmaxheaderlength;
          appfwprofileArray[index].bufferoverflowmaxcookielength = resources[index].bufferoverflowmaxcookielength;
          appfwprofileArray[index].creditcardaction = resources[index].creditcardaction;
          appfwprofileArray[index].creditcard = resources[index].creditcard;
          appfwprofileArray[index].creditcardmaxallowed = resources[index].creditcardmaxallowed;
          appfwprofileArray[index].creditcardxout = resources[index].creditcardxout;
          appfwprofileArray[index].dosecurecreditcardlogging = resources[index].dosecurecreditcardlogging;
          appfwprofileArray[index].streaming = resources[index].streaming;
          appfwprofileArray[index].trace = resources[index].trace;
          appfwprofileArray[index].requestcontenttype = resources[index].requestcontenttype;
          appfwprofileArray[index].responsecontenttype = resources[index].responsecontenttype;
          appfwprofileArray[index].xmldosaction = resources[index].xmldosaction;
          appfwprofileArray[index].xmlformataction = resources[index].xmlformataction;
          appfwprofileArray[index].xmlsqlinjectionaction = resources[index].xmlsqlinjectionaction;
          appfwprofileArray[index].xmlsqlinjectiononlycheckfieldswithsqlchars = resources[index].xmlsqlinjectiononlycheckfieldswithsqlchars;
          appfwprofileArray[index].xmlsqlinjectiontype = resources[index].xmlsqlinjectiontype;
          appfwprofileArray[index].xmlsqlinjectionchecksqlwildchars = resources[index].xmlsqlinjectionchecksqlwildchars;
          appfwprofileArray[index].xmlsqlinjectionparsecomments = resources[index].xmlsqlinjectionparsecomments;
          appfwprofileArray[index].xmlxssaction = resources[index].xmlxssaction;
          appfwprofileArray[index].xmlwsiaction = resources[index].xmlwsiaction;
          appfwprofileArray[index].xmlattachmentaction = resources[index].xmlattachmentaction;
          appfwprofileArray[index].xmlvalidationaction = resources[index].xmlvalidationaction;
          appfwprofileArray[index].xmlerrorobject = resources[index].xmlerrorobject;
          appfwprofileArray[index].customsettings = resources[index].customsettings;
          appfwprofileArray[index].signatures = resources[index].signatures;
          appfwprofileArray[index].xmlsoapfaultaction = resources[index].xmlsoapfaultaction;
          appfwprofileArray[index].usehtmlerrorobject = resources[index].usehtmlerrorobject;
          appfwprofileArray[index].errorurl = resources[index].errorurl;
          appfwprofileArray[index].htmlerrorobject = resources[index].htmlerrorobject;
          appfwprofileArray[index].logeverypolicyhit = resources[index].logeverypolicyhit;
          appfwprofileArray[index].stripcomments = resources[index].stripcomments;
          appfwprofileArray[index].striphtmlcomments = resources[index].striphtmlcomments;
          appfwprofileArray[index].stripxmlcomments = resources[index].stripxmlcomments;
          appfwprofileArray[index].exemptclosureurlsfromsecuritychecks = resources[index].exemptclosureurlsfromsecuritychecks;
          appfwprofileArray[index].defaultcharset = resources[index].defaultcharset;
          appfwprofileArray[index].postbodylimit = resources[index].postbodylimit;
          appfwprofileArray[index].fileuploadmaxnum = resources[index].fileuploadmaxnum;
          appfwprofileArray[index].canonicalizehtmlresponse = resources[index].canonicalizehtmlresponse;
          appfwprofileArray[index].enableformtagging = resources[index].enableformtagging;
          appfwprofileArray[index].sessionlessfieldconsistency = resources[index].sessionlessfieldconsistency;
          appfwprofileArray[index].sessionlessurlclosure = resources[index].sessionlessurlclosure;
          appfwprofileArray[index].semicolonfieldseparator = resources[index].semicolonfieldseparator;
          appfwprofileArray[index].excludefileuploadfromchecks = resources[index].excludefileuploadfromchecks;
          appfwprofileArray[index].sqlinjectionparsecomments = resources[index].sqlinjectionparsecomments;
          appfwprofileArray[index].invalidpercenthandling = resources[index].invalidpercenthandling;
          appfwprofileArray[index].type = resources[index].type;
          appfwprofileArray[index].checkrequestheaders = resources[index].checkrequestheaders;
          appfwprofileArray[index].optimizepartialreqs = resources[index].optimizepartialreqs;
          appfwprofileArray[index].urldecoderequestcookies = resources[index].urldecoderequestcookies;
          appfwprofileArray[index].comment = resources[index].comment;
        }
        baseResponses = base_resource.add_bulk_request(client, (base_resource[]) appfwprofileArray);
      }
      return baseResponses;
    }

    public static base_response delete(nitro_service client, string name) => new appfwprofile()
    {
      name = name
    }.delete_resource(client);

    public static base_response delete(nitro_service client, appfwprofile resource) => new appfwprofile()
    {
      name = resource.name
    }.delete_resource(client);

    public static base_responses delete(nitro_service client, string[] name)
    {
      base_responses baseResponses = (base_responses) null;
      if (name != null && name.Length > 0)
      {
        appfwprofile[] appfwprofileArray = new appfwprofile[name.Length];
        for (int index = 0; index < name.Length; ++index)
        {
          appfwprofileArray[index] = new appfwprofile();
          appfwprofileArray[index].name = name[index];
        }
        baseResponses = base_resource.delete_bulk_request(client, (base_resource[]) appfwprofileArray);
      }
      return baseResponses;
    }

    public static base_responses delete(
      nitro_service client,
      appfwprofile[] resources)
    {
      base_responses baseResponses = (base_responses) null;
      if (resources != null && resources.Length > 0)
      {
        appfwprofile[] appfwprofileArray = new appfwprofile[resources.Length];
        for (int index = 0; index < resources.Length; ++index)
        {
          appfwprofileArray[index] = new appfwprofile();
          appfwprofileArray[index].name = resources[index].name;
        }
        baseResponses = base_resource.delete_bulk_request(client, (base_resource[]) appfwprofileArray);
      }
      return baseResponses;
    }

    public static base_response update(nitro_service client, appfwprofile resource) => new appfwprofile()
    {
      name = resource.name,
      starturlaction = resource.starturlaction,
      contenttypeaction = resource.contenttypeaction,
      inspectcontenttypes = resource.inspectcontenttypes,
      starturlclosure = resource.starturlclosure,
      denyurlaction = resource.denyurlaction,
      refererheadercheck = resource.refererheadercheck,
      cookieconsistencyaction = resource.cookieconsistencyaction,
      cookietransforms = resource.cookietransforms,
      cookieencryption = resource.cookieencryption,
      cookieproxying = resource.cookieproxying,
      addcookieflags = resource.addcookieflags,
      fieldconsistencyaction = resource.fieldconsistencyaction,
      csrftagaction = resource.csrftagaction,
      crosssitescriptingaction = resource.crosssitescriptingaction,
      crosssitescriptingtransformunsafehtml = resource.crosssitescriptingtransformunsafehtml,
      crosssitescriptingcheckcompleteurls = resource.crosssitescriptingcheckcompleteurls,
      sqlinjectionaction = resource.sqlinjectionaction,
      sqlinjectiontransformspecialchars = resource.sqlinjectiontransformspecialchars,
      sqlinjectiononlycheckfieldswithsqlchars = resource.sqlinjectiononlycheckfieldswithsqlchars,
      sqlinjectiontype = resource.sqlinjectiontype,
      sqlinjectionchecksqlwildchars = resource.sqlinjectionchecksqlwildchars,
      fieldformataction = resource.fieldformataction,
      defaultfieldformattype = resource.defaultfieldformattype,
      defaultfieldformatminlength = resource.defaultfieldformatminlength,
      defaultfieldformatmaxlength = resource.defaultfieldformatmaxlength,
      bufferoverflowaction = resource.bufferoverflowaction,
      bufferoverflowmaxurllength = resource.bufferoverflowmaxurllength,
      bufferoverflowmaxheaderlength = resource.bufferoverflowmaxheaderlength,
      bufferoverflowmaxcookielength = resource.bufferoverflowmaxcookielength,
      creditcardaction = resource.creditcardaction,
      creditcard = resource.creditcard,
      creditcardmaxallowed = resource.creditcardmaxallowed,
      creditcardxout = resource.creditcardxout,
      dosecurecreditcardlogging = resource.dosecurecreditcardlogging,
      streaming = resource.streaming,
      trace = resource.trace,
      requestcontenttype = resource.requestcontenttype,
      responsecontenttype = resource.responsecontenttype,
      xmldosaction = resource.xmldosaction,
      xmlformataction = resource.xmlformataction,
      xmlsqlinjectionaction = resource.xmlsqlinjectionaction,
      xmlsqlinjectiononlycheckfieldswithsqlchars = resource.xmlsqlinjectiononlycheckfieldswithsqlchars,
      xmlsqlinjectiontype = resource.xmlsqlinjectiontype,
      xmlsqlinjectionchecksqlwildchars = resource.xmlsqlinjectionchecksqlwildchars,
      xmlsqlinjectionparsecomments = resource.xmlsqlinjectionparsecomments,
      xmlxssaction = resource.xmlxssaction,
      xmlwsiaction = resource.xmlwsiaction,
      xmlattachmentaction = resource.xmlattachmentaction,
      xmlvalidationaction = resource.xmlvalidationaction,
      xmlerrorobject = resource.xmlerrorobject,
      customsettings = resource.customsettings,
      signatures = resource.signatures,
      xmlsoapfaultaction = resource.xmlsoapfaultaction,
      usehtmlerrorobject = resource.usehtmlerrorobject,
      errorurl = resource.errorurl,
      htmlerrorobject = resource.htmlerrorobject,
      logeverypolicyhit = resource.logeverypolicyhit,
      stripcomments = resource.stripcomments,
      striphtmlcomments = resource.striphtmlcomments,
      stripxmlcomments = resource.stripxmlcomments,
      exemptclosureurlsfromsecuritychecks = resource.exemptclosureurlsfromsecuritychecks,
      defaultcharset = resource.defaultcharset,
      postbodylimit = resource.postbodylimit,
      fileuploadmaxnum = resource.fileuploadmaxnum,
      canonicalizehtmlresponse = resource.canonicalizehtmlresponse,
      enableformtagging = resource.enableformtagging,
      sessionlessfieldconsistency = resource.sessionlessfieldconsistency,
      sessionlessurlclosure = resource.sessionlessurlclosure,
      semicolonfieldseparator = resource.semicolonfieldseparator,
      excludefileuploadfromchecks = resource.excludefileuploadfromchecks,
      sqlinjectionparsecomments = resource.sqlinjectionparsecomments,
      invalidpercenthandling = resource.invalidpercenthandling,
      type = resource.type,
      checkrequestheaders = resource.checkrequestheaders,
      optimizepartialreqs = resource.optimizepartialreqs,
      urldecoderequestcookies = resource.urldecoderequestcookies,
      comment = resource.comment
    }.update_resource(client);

    public static base_responses update(
      nitro_service client,
      appfwprofile[] resources)
    {
      base_responses baseResponses = (base_responses) null;
      if (resources != null && resources.Length > 0)
      {
        appfwprofile[] appfwprofileArray = new appfwprofile[resources.Length];
        for (int index = 0; index < resources.Length; ++index)
        {
          appfwprofileArray[index] = new appfwprofile();
          appfwprofileArray[index].name = resources[index].name;
          appfwprofileArray[index].starturlaction = resources[index].starturlaction;
          appfwprofileArray[index].contenttypeaction = resources[index].contenttypeaction;
          appfwprofileArray[index].inspectcontenttypes = resources[index].inspectcontenttypes;
          appfwprofileArray[index].starturlclosure = resources[index].starturlclosure;
          appfwprofileArray[index].denyurlaction = resources[index].denyurlaction;
          appfwprofileArray[index].refererheadercheck = resources[index].refererheadercheck;
          appfwprofileArray[index].cookieconsistencyaction = resources[index].cookieconsistencyaction;
          appfwprofileArray[index].cookietransforms = resources[index].cookietransforms;
          appfwprofileArray[index].cookieencryption = resources[index].cookieencryption;
          appfwprofileArray[index].cookieproxying = resources[index].cookieproxying;
          appfwprofileArray[index].addcookieflags = resources[index].addcookieflags;
          appfwprofileArray[index].fieldconsistencyaction = resources[index].fieldconsistencyaction;
          appfwprofileArray[index].csrftagaction = resources[index].csrftagaction;
          appfwprofileArray[index].crosssitescriptingaction = resources[index].crosssitescriptingaction;
          appfwprofileArray[index].crosssitescriptingtransformunsafehtml = resources[index].crosssitescriptingtransformunsafehtml;
          appfwprofileArray[index].crosssitescriptingcheckcompleteurls = resources[index].crosssitescriptingcheckcompleteurls;
          appfwprofileArray[index].sqlinjectionaction = resources[index].sqlinjectionaction;
          appfwprofileArray[index].sqlinjectiontransformspecialchars = resources[index].sqlinjectiontransformspecialchars;
          appfwprofileArray[index].sqlinjectiononlycheckfieldswithsqlchars = resources[index].sqlinjectiononlycheckfieldswithsqlchars;
          appfwprofileArray[index].sqlinjectiontype = resources[index].sqlinjectiontype;
          appfwprofileArray[index].sqlinjectionchecksqlwildchars = resources[index].sqlinjectionchecksqlwildchars;
          appfwprofileArray[index].fieldformataction = resources[index].fieldformataction;
          appfwprofileArray[index].defaultfieldformattype = resources[index].defaultfieldformattype;
          appfwprofileArray[index].defaultfieldformatminlength = resources[index].defaultfieldformatminlength;
          appfwprofileArray[index].defaultfieldformatmaxlength = resources[index].defaultfieldformatmaxlength;
          appfwprofileArray[index].bufferoverflowaction = resources[index].bufferoverflowaction;
          appfwprofileArray[index].bufferoverflowmaxurllength = resources[index].bufferoverflowmaxurllength;
          appfwprofileArray[index].bufferoverflowmaxheaderlength = resources[index].bufferoverflowmaxheaderlength;
          appfwprofileArray[index].bufferoverflowmaxcookielength = resources[index].bufferoverflowmaxcookielength;
          appfwprofileArray[index].creditcardaction = resources[index].creditcardaction;
          appfwprofileArray[index].creditcard = resources[index].creditcard;
          appfwprofileArray[index].creditcardmaxallowed = resources[index].creditcardmaxallowed;
          appfwprofileArray[index].creditcardxout = resources[index].creditcardxout;
          appfwprofileArray[index].dosecurecreditcardlogging = resources[index].dosecurecreditcardlogging;
          appfwprofileArray[index].streaming = resources[index].streaming;
          appfwprofileArray[index].trace = resources[index].trace;
          appfwprofileArray[index].requestcontenttype = resources[index].requestcontenttype;
          appfwprofileArray[index].responsecontenttype = resources[index].responsecontenttype;
          appfwprofileArray[index].xmldosaction = resources[index].xmldosaction;
          appfwprofileArray[index].xmlformataction = resources[index].xmlformataction;
          appfwprofileArray[index].xmlsqlinjectionaction = resources[index].xmlsqlinjectionaction;
          appfwprofileArray[index].xmlsqlinjectiononlycheckfieldswithsqlchars = resources[index].xmlsqlinjectiononlycheckfieldswithsqlchars;
          appfwprofileArray[index].xmlsqlinjectiontype = resources[index].xmlsqlinjectiontype;
          appfwprofileArray[index].xmlsqlinjectionchecksqlwildchars = resources[index].xmlsqlinjectionchecksqlwildchars;
          appfwprofileArray[index].xmlsqlinjectionparsecomments = resources[index].xmlsqlinjectionparsecomments;
          appfwprofileArray[index].xmlxssaction = resources[index].xmlxssaction;
          appfwprofileArray[index].xmlwsiaction = resources[index].xmlwsiaction;
          appfwprofileArray[index].xmlattachmentaction = resources[index].xmlattachmentaction;
          appfwprofileArray[index].xmlvalidationaction = resources[index].xmlvalidationaction;
          appfwprofileArray[index].xmlerrorobject = resources[index].xmlerrorobject;
          appfwprofileArray[index].customsettings = resources[index].customsettings;
          appfwprofileArray[index].signatures = resources[index].signatures;
          appfwprofileArray[index].xmlsoapfaultaction = resources[index].xmlsoapfaultaction;
          appfwprofileArray[index].usehtmlerrorobject = resources[index].usehtmlerrorobject;
          appfwprofileArray[index].errorurl = resources[index].errorurl;
          appfwprofileArray[index].htmlerrorobject = resources[index].htmlerrorobject;
          appfwprofileArray[index].logeverypolicyhit = resources[index].logeverypolicyhit;
          appfwprofileArray[index].stripcomments = resources[index].stripcomments;
          appfwprofileArray[index].striphtmlcomments = resources[index].striphtmlcomments;
          appfwprofileArray[index].stripxmlcomments = resources[index].stripxmlcomments;
          appfwprofileArray[index].exemptclosureurlsfromsecuritychecks = resources[index].exemptclosureurlsfromsecuritychecks;
          appfwprofileArray[index].defaultcharset = resources[index].defaultcharset;
          appfwprofileArray[index].postbodylimit = resources[index].postbodylimit;
          appfwprofileArray[index].fileuploadmaxnum = resources[index].fileuploadmaxnum;
          appfwprofileArray[index].canonicalizehtmlresponse = resources[index].canonicalizehtmlresponse;
          appfwprofileArray[index].enableformtagging = resources[index].enableformtagging;
          appfwprofileArray[index].sessionlessfieldconsistency = resources[index].sessionlessfieldconsistency;
          appfwprofileArray[index].sessionlessurlclosure = resources[index].sessionlessurlclosure;
          appfwprofileArray[index].semicolonfieldseparator = resources[index].semicolonfieldseparator;
          appfwprofileArray[index].excludefileuploadfromchecks = resources[index].excludefileuploadfromchecks;
          appfwprofileArray[index].sqlinjectionparsecomments = resources[index].sqlinjectionparsecomments;
          appfwprofileArray[index].invalidpercenthandling = resources[index].invalidpercenthandling;
          appfwprofileArray[index].type = resources[index].type;
          appfwprofileArray[index].checkrequestheaders = resources[index].checkrequestheaders;
          appfwprofileArray[index].optimizepartialreqs = resources[index].optimizepartialreqs;
          appfwprofileArray[index].urldecoderequestcookies = resources[index].urldecoderequestcookies;
          appfwprofileArray[index].comment = resources[index].comment;
        }
        baseResponses = base_resource.update_bulk_request(client, (base_resource[]) appfwprofileArray);
      }
      return baseResponses;
    }

    public static base_response unset(
      nitro_service client,
      string name,
      string[] args)
    {
      return new appfwprofile() { name = name }.unset_resource(client, args);
    }

    public static base_response unset(
      nitro_service client,
      appfwprofile resource,
      string[] args)
    {
      return new appfwprofile() { name = resource.name }.unset_resource(client, args);
    }

    public static base_responses unset(
      nitro_service client,
      string[] name,
      string[] args)
    {
      base_responses baseResponses = (base_responses) null;
      if (name != null && name.Length > 0)
      {
        appfwprofile[] appfwprofileArray = new appfwprofile[name.Length];
        for (int index = 0; index < name.Length; ++index)
        {
          appfwprofileArray[index] = new appfwprofile();
          appfwprofileArray[index].name = name[index];
        }
        baseResponses = base_resource.unset_bulk_request(client, (base_resource[]) appfwprofileArray, args);
      }
      return baseResponses;
    }

    public static base_responses unset(
      nitro_service client,
      appfwprofile[] resources,
      string[] args)
    {
      base_responses baseResponses = (base_responses) null;
      if (resources != null && resources.Length > 0)
      {
        appfwprofile[] appfwprofileArray = new appfwprofile[resources.Length];
        for (int index = 0; index < resources.Length; ++index)
        {
          appfwprofileArray[index] = new appfwprofile();
          appfwprofileArray[index].name = resources[index].name;
        }
        baseResponses = base_resource.unset_bulk_request(client, (base_resource[]) appfwprofileArray, args);
      }
      return baseResponses;
    }

    public static base_response restore(nitro_service client, appfwprofile resource) => new appfwprofile()
    {
      archivename = resource.archivename
    }.perform_operation_byaction(client, nameof (restore));

    public static base_responses restore(
      nitro_service client,
      appfwprofile[] resources)
    {
      base_responses baseResponses = (base_responses) null;
      if (resources != null && resources.Length > 0)
      {
        appfwprofile[] appfwprofileArray = new appfwprofile[resources.Length];
        for (int index = 0; index < resources.Length; ++index)
        {
          appfwprofileArray[index] = new appfwprofile();
          appfwprofileArray[index].archivename = resources[index].archivename;
        }
        baseResponses = base_resource.perform_operation_bulk_request(client, (base_resource[]) appfwprofileArray, nameof (restore));
      }
      return baseResponses;
    }

    public static appfwprofile[] get(nitro_service service) => (appfwprofile[]) new appfwprofile().get_resources(service, (options) null);

    public static appfwprofile[] get(nitro_service service, options option) => (appfwprofile[]) new appfwprofile().get_resources(service, option);

    public static appfwprofile get(nitro_service service, string name) => (appfwprofile) new appfwprofile()
    {
      name = name
    }.get_resource(service);

    public static appfwprofile[] get(nitro_service service, string[] name)
    {
      if (name == null || name.Length <= 0)
        return (appfwprofile[]) null;
      appfwprofile[] appfwprofileArray1 = new appfwprofile[name.Length];
      appfwprofile[] appfwprofileArray2 = new appfwprofile[name.Length];
      for (int index = 0; index < name.Length; ++index)
      {
        appfwprofileArray2[index] = new appfwprofile();
        appfwprofileArray2[index].name = name[index];
        appfwprofileArray1[index] = (appfwprofile) appfwprofileArray2[index].get_resource(service);
      }
      return appfwprofileArray1;
    }

    public static appfwprofile[] get_filtered(nitro_service service, string filter)
    {
      appfwprofile appfwprofile = new appfwprofile();
      options option = new options();
      option.set_filter(filter);
      return (appfwprofile[]) appfwprofile.getfiltered(service, option);
    }

    public static appfwprofile[] get_filtered(
      nitro_service service,
      filtervalue[] filter)
    {
      appfwprofile appfwprofile = new appfwprofile();
      options option = new options();
      option.set_filter(filter);
      return (appfwprofile[]) appfwprofile.getfiltered(service, option);
    }

    public static uint count(nitro_service service)
    {
      appfwprofile appfwprofile = new appfwprofile();
      options option = new options();
      option.set_count(true);
      appfwprofile[] resources = (appfwprofile[]) appfwprofile.get_resources(service, option);
      return resources != null && resources.Length > 0 ? resources[0].__count.Value : 0U;
    }

    public static uint count_filtered(nitro_service service, string filter)
    {
      appfwprofile appfwprofile = new appfwprofile();
      options option = new options();
      option.set_count(true);
      option.set_filter(filter);
      appfwprofile[] appfwprofileArray = (appfwprofile[]) appfwprofile.getfiltered(service, option);
      return appfwprofileArray != null && appfwprofileArray.Length > 0 ? appfwprofileArray[0].__count.Value : 0U;
    }

    public static uint count_filtered(nitro_service service, filtervalue[] filter)
    {
      appfwprofile appfwprofile = new appfwprofile();
      options option = new options();
      option.set_count(true);
      option.set_filter(filter);
      appfwprofile[] appfwprofileArray = (appfwprofile[]) appfwprofile.getfiltered(service, option);
      return appfwprofileArray != null && appfwprofileArray.Length > 0 ? appfwprofileArray[0].__count.Value : 0U;
    }

    private class appfwprofile_response : base_response
    {
      public appfwprofile[] appfwprofile = (appfwprofile[]) null;
    }

    public static class cookieconsistencyactionEnum
    {
      public const string none = "none";
      public const string block = "block";
      public const string learn = "learn";
      public const string log = "log";
      public const string stats = "stats";
    }

    public static class denyurlactionEnum
    {
      public const string none = "none";
      public const string block = "block";
      public const string learn = "learn";
      public const string log = "log";
      public const string stats = "stats";
    }

    public static class urldecoderequestcookiesEnum
    {
      public const string ON = "ON";
      public const string OFF = "OFF";
    }

    public static class xmlsqlinjectionparsecommentsEnum
    {
      public const string checkall = "checkall";
      public const string ansi = "ansi";
      public const string nested = "nested";
      public const string ansinested = "ansinested";
    }

    public static class sessionlessfieldconsistencyEnum
    {
      public const string OFF = "OFF";
      public const string ON = "ON";
      public const string postOnly = "postOnly";
    }

    public static class checkrequestheadersEnum
    {
      public const string ON = "ON";
      public const string OFF = "OFF";
    }

    public static class xmlsqlinjectiontypeEnum
    {
      public const string SQLSplChar = "SQLSplChar";
      public const string SQLKeyword = "SQLKeyword";
      public const string SQLSplCharORKeyword = "SQLSplCharORKeyword";
      public const string SQLSplCharANDKeyword = "SQLSplCharANDKeyword";
    }

    public static class creditcardactionEnum
    {
      public const string none = "none";
      public const string block = "block";
      public const string learn = "learn";
      public const string log = "log";
      public const string stats = "stats";
    }

    public static class stateEnum
    {
      public const string ENABLED = "ENABLED";
      public const string DISABLED = "DISABLED";
    }

    public static class stripxmlcommentsEnum
    {
      public const string none = "none";
      public const string all = "all";
    }

    public static class sqlinjectionchecksqlwildcharsEnum
    {
      public const string ON = "ON";
      public const string OFF = "OFF";
    }

    public static class sqlinjectiononlycheckfieldswithsqlcharsEnum
    {
      public const string ON = "ON";
      public const string OFF = "OFF";
    }

    public static class traceEnum
    {
      public const string ON = "ON";
      public const string OFF = "OFF";
    }

    public static class striphtmlcommentsEnum
    {
      public const string none = "none";
      public const string all = "all";
      public const string exclude_script_tag = "exclude_script_tag";
    }

    public static class starturlactionEnum
    {
      public const string none = "none";
      public const string block = "block";
      public const string learn = "learn";
      public const string log = "log";
      public const string stats = "stats";
    }

    public static class sqlinjectiontransformspecialcharsEnum
    {
      public const string ON = "ON";
      public const string OFF = "OFF";
    }

    public static class enableformtaggingEnum
    {
      public const string ON = "ON";
      public const string OFF = "OFF";
    }

    public static class fieldconsistencyactionEnum
    {
      public const string none = "none";
      public const string block = "block";
      public const string learn = "learn";
      public const string log = "log";
      public const string stats = "stats";
    }

    public static class dosecurecreditcardloggingEnum
    {
      public const string ON = "ON";
      public const string OFF = "OFF";
    }

    public static class excludefileuploadfromchecksEnum
    {
      public const string ON = "ON";
      public const string OFF = "OFF";
    }

    public static class refererheadercheckEnum
    {
      public const string OFF = "OFF";
      public const string if_present = "if_present";
      public const string AlwaysExceptStartURLs = "AlwaysExceptStartURLs";
      public const string AlwaysExceptFirstRequest = "AlwaysExceptFirstRequest";
    }

    public static class exemptclosureurlsfromsecuritychecksEnum
    {
      public const string ON = "ON";
      public const string OFF = "OFF";
    }

    public static class usehtmlerrorobjectEnum
    {
      public const string ON = "ON";
      public const string OFF = "OFF";
    }

    public static class creditcardxoutEnum
    {
      public const string ON = "ON";
      public const string OFF = "OFF";
    }

    public static class xmlwsiactionEnum
    {
      public const string none = "none";
      public const string block = "block";
      public const string learn = "learn";
      public const string log = "log";
      public const string stats = "stats";
    }

    public static class canonicalizehtmlresponseEnum
    {
      public const string ON = "ON";
      public const string OFF = "OFF";
    }

    public static class xmlattachmentactionEnum
    {
      public const string none = "none";
      public const string block = "block";
      public const string learn = "learn";
      public const string log = "log";
      public const string stats = "stats";
    }

    public static class csrftagactionEnum
    {
      public const string none = "none";
      public const string block = "block";
      public const string learn = "learn";
      public const string log = "log";
      public const string stats = "stats";
    }

    public static class cookieproxyingEnum
    {
      public const string none = "none";
      public const string sessionOnly = "sessionOnly";
    }

    public static class fieldformatactionEnum
    {
      public const string none = "none";
      public const string block = "block";
      public const string learn = "learn";
      public const string log = "log";
      public const string stats = "stats";
    }

    public static class cookietransformsEnum
    {
      public const string ON = "ON";
      public const string OFF = "OFF";
    }

    public static class logeverypolicyhitEnum
    {
      public const string ON = "ON";
      public const string OFF = "OFF";
    }

    public static class typeEnum
    {
      public const string HTML = "HTML";
      public const string XML = "XML";
    }

    public static class crosssitescriptingtransformunsafehtmlEnum
    {
      public const string ON = "ON";
      public const string OFF = "OFF";
    }

    public static class stripcommentsEnum
    {
      public const string ON = "ON";
      public const string OFF = "OFF";
    }

    public static class xmlsqlinjectionactionEnum
    {
      public const string none = "none";
      public const string block = "block";
      public const string learn = "learn";
      public const string log = "log";
      public const string stats = "stats";
    }

    public static class defaultsEnum
    {
      public const string basic = "basic";
      public const string advanced = "advanced";
    }

    public static class inspectcontenttypesEnum
    {
      public const string none = "none";
      public const string application_x_www_form_urlencoded = "application/x-www-form-urlencoded";
      public const string multipart_form_data = "multipart/form-data";
      public const string text_x_gwt_rpc = "text/x-gwt-rpc";
    }

    public static class semicolonfieldseparatorEnum
    {
      public const string ON = "ON";
      public const string OFF = "OFF";
    }

    public static class streamingEnum
    {
      public const string ON = "ON";
      public const string OFF = "OFF";
    }

    public static class xmlvalidationactionEnum
    {
      public const string none = "none";
      public const string block = "block";
      public const string learn = "learn";
      public const string log = "log";
      public const string stats = "stats";
    }

    public static class xmlxssactionEnum
    {
      public const string none = "none";
      public const string block = "block";
      public const string learn = "learn";
      public const string log = "log";
      public const string stats = "stats";
    }

    public static class xmldosactionEnum
    {
      public const string none = "none";
      public const string block = "block";
      public const string learn = "learn";
      public const string log = "log";
      public const string stats = "stats";
    }

    public static class crosssitescriptingcheckcompleteurlsEnum
    {
      public const string ON = "ON";
      public const string OFF = "OFF";
    }

    public static class sqlinjectionactionEnum
    {
      public const string none = "none";
      public const string block = "block";
      public const string learn = "learn";
      public const string log = "log";
      public const string stats = "stats";
    }

    public static class xmlformatactionEnum
    {
      public const string none = "none";
      public const string block = "block";
      public const string learn = "learn";
      public const string log = "log";
      public const string stats = "stats";
    }

    public static class optimizepartialreqsEnum
    {
      public const string ON = "ON";
      public const string OFF = "OFF";
    }

    public static class creditcardEnum
    {
      public const string visa = "visa";
      public const string mastercard = "mastercard";
      public const string discover = "discover";
      public const string amex = "amex";
      public const string jcb = "jcb";
      public const string dinersclub = "dinersclub";
    }

    public static class starturlclosureEnum
    {
      public const string ON = "ON";
      public const string OFF = "OFF";
    }

    public static class bufferoverflowactionEnum
    {
      public const string none = "none";
      public const string block = "block";
      public const string learn = "learn";
      public const string log = "log";
      public const string stats = "stats";
    }

    public static class xmlsqlinjectiononlycheckfieldswithsqlcharsEnum
    {
      public const string ON = "ON";
      public const string OFF = "OFF";
    }

    public static class addcookieflagsEnum
    {
      public const string none = "none";
      public const string httpOnly = "httpOnly";
      public const string secure = "secure";
      public const string all = "all";
    }

    public static class sessionlessurlclosureEnum
    {
      public const string ON = "ON";
      public const string OFF = "OFF";
    }

    public static class sqlinjectionparsecommentsEnum
    {
      public const string checkall = "checkall";
      public const string ansi = "ansi";
      public const string nested = "nested";
      public const string ansinested = "ansinested";
    }

    public static class cookieencryptionEnum
    {
      public const string none = "none";
      public const string decryptOnly = "decryptOnly";
      public const string encryptSessionOnly = "encryptSessionOnly";
      public const string encryptAll = "encryptAll";
    }

    public static class xmlsoapfaultactionEnum
    {
      public const string none = "none";
      public const string block = "block";
      public const string log = "log";
      public const string remove = "remove";
      public const string stats = "stats";
    }

    public static class xmlsqlinjectionchecksqlwildcharsEnum
    {
      public const string ON = "ON";
      public const string OFF = "OFF";
    }

    public static class sqlinjectiontypeEnum
    {
      public const string SQLSplChar = "SQLSplChar";
      public const string SQLKeyword = "SQLKeyword";
      public const string SQLSplCharORKeyword = "SQLSplCharORKeyword";
      public const string SQLSplCharANDKeyword = "SQLSplCharANDKeyword";
    }

    public static class crosssitescriptingactionEnum
    {
      public const string none = "none";
      public const string block = "block";
      public const string learn = "learn";
      public const string log = "log";
      public const string stats = "stats";
    }

    public static class invalidpercenthandlingEnum
    {
      public const string apache_mode = "apache_mode";
      public const string asp_mode = "asp_mode";
      public const string secure_mode = "secure_mode";
    }

    public static class contenttypeactionEnum
    {
      public const string none = "none";
      public const string block = "block";
      public const string learn = "learn";
      public const string log = "log";
      public const string stats = "stats";
    }
  }
}
