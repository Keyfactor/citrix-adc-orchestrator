// Decompiled with JetBrains decompiler
// Type: com.citrix.netscaler.nitro.resource.config.authentication.authenticationsamlaction
// Assembly: nitro, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 6CF5DDEF-E052-4F9D-953F-6644F8378A66


using com.citrix.netscaler.nitro.exception;
using com.citrix.netscaler.nitro.resource.Base;
using com.citrix.netscaler.nitro.service;
using com.citrix.netscaler.nitro.util;

namespace com.citrix.netscaler.nitro.resource.config.authentication
{
  public class authenticationsamlaction : base_resource
  {
    private string nameField = (string) null;
    private string samlidpcertnameField = (string) null;
    private string samlsigningcertnameField = (string) null;
    private string samlredirecturlField = (string) null;
    private uint? samlacsindexField = new uint?();
    private string samluserfieldField = (string) null;
    private string samlrejectunsignedassertionField = (string) null;
    private string samlissuernameField = (string) null;
    private string samltwofactorField = (string) null;
    private string defaultauthenticationgroupField = (string) null;
    private string attribute1Field = (string) null;
    private string attribute2Field = (string) null;
    private string attribute3Field = (string) null;
    private string attribute4Field = (string) null;
    private string attribute5Field = (string) null;
    private string attribute6Field = (string) null;
    private string attribute7Field = (string) null;
    private string attribute8Field = (string) null;
    private string attribute9Field = (string) null;
    private string attribute10Field = (string) null;
    private string attribute11Field = (string) null;
    private string attribute12Field = (string) null;
    private string attribute13Field = (string) null;
    private string attribute14Field = (string) null;
    private string attribute15Field = (string) null;
    private string attribute16Field = (string) null;
    private string signaturealgField = (string) null;
    private string digestmethodField = (string) null;
    private string requestedauthncontextField = (string) null;
    private string[] authnctxclassrefField = (string[]) null;
    private string samlbindingField = (string) null;
    private uint? attributeconsumingserviceindexField = new uint?();
    private string sendthumbprintField = (string) null;
    private string enforceusernameField = (string) null;
    private string logouturlField = (string) null;
    private string artifactresolutionserviceurlField = (string) null;
    private uint? skewtimeField = new uint?();
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

    public string samlidpcertname
    {
      get => this.samlidpcertnameField;
      set => this.samlidpcertnameField = value;
    }

    public string samlsigningcertname
    {
      get => this.samlsigningcertnameField;
      set => this.samlsigningcertnameField = value;
    }

    public string samlredirecturl
    {
      get => this.samlredirecturlField;
      set => this.samlredirecturlField = value;
    }

    public uint? samlacsindex
    {
      get => this.samlacsindexField;
      set => this.samlacsindexField = value;
    }

    public string samluserfield
    {
      get => this.samluserfieldField;
      set => this.samluserfieldField = value;
    }

    public string samlrejectunsignedassertion
    {
      get => this.samlrejectunsignedassertionField;
      set => this.samlrejectunsignedassertionField = value;
    }

    public string samlissuername
    {
      get => this.samlissuernameField;
      set => this.samlissuernameField = value;
    }

    public string samltwofactor
    {
      get => this.samltwofactorField;
      set => this.samltwofactorField = value;
    }

    public string defaultauthenticationgroup
    {
      get => this.defaultauthenticationgroupField;
      set => this.defaultauthenticationgroupField = value;
    }

    public string attribute1
    {
      get => this.attribute1Field;
      set => this.attribute1Field = value;
    }

    public string attribute2
    {
      get => this.attribute2Field;
      set => this.attribute2Field = value;
    }

    public string attribute3
    {
      get => this.attribute3Field;
      set => this.attribute3Field = value;
    }

    public string attribute4
    {
      get => this.attribute4Field;
      set => this.attribute4Field = value;
    }

    public string attribute5
    {
      get => this.attribute5Field;
      set => this.attribute5Field = value;
    }

    public string attribute6
    {
      get => this.attribute6Field;
      set => this.attribute6Field = value;
    }

    public string attribute7
    {
      get => this.attribute7Field;
      set => this.attribute7Field = value;
    }

    public string attribute8
    {
      get => this.attribute8Field;
      set => this.attribute8Field = value;
    }

    public string attribute9
    {
      get => this.attribute9Field;
      set => this.attribute9Field = value;
    }

    public string attribute10
    {
      get => this.attribute10Field;
      set => this.attribute10Field = value;
    }

    public string attribute11
    {
      get => this.attribute11Field;
      set => this.attribute11Field = value;
    }

    public string attribute12
    {
      get => this.attribute12Field;
      set => this.attribute12Field = value;
    }

    public string attribute13
    {
      get => this.attribute13Field;
      set => this.attribute13Field = value;
    }

    public string attribute14
    {
      get => this.attribute14Field;
      set => this.attribute14Field = value;
    }

    public string attribute15
    {
      get => this.attribute15Field;
      set => this.attribute15Field = value;
    }

    public string attribute16
    {
      get => this.attribute16Field;
      set => this.attribute16Field = value;
    }

    public string signaturealg
    {
      get => this.signaturealgField;
      set => this.signaturealgField = value;
    }

    public string digestmethod
    {
      get => this.digestmethodField;
      set => this.digestmethodField = value;
    }

    public string requestedauthncontext
    {
      get => this.requestedauthncontextField;
      set => this.requestedauthncontextField = value;
    }

    public string[] authnctxclassref
    {
      get => this.authnctxclassrefField;
      set => this.authnctxclassrefField = value;
    }

    public string samlbinding
    {
      get => this.samlbindingField;
      set => this.samlbindingField = value;
    }

    public uint? attributeconsumingserviceindex
    {
      get => this.attributeconsumingserviceindexField;
      set => this.attributeconsumingserviceindexField = value;
    }

    public string sendthumbprint
    {
      get => this.sendthumbprintField;
      set => this.sendthumbprintField = value;
    }

    public string enforceusername
    {
      get => this.enforceusernameField;
      set => this.enforceusernameField = value;
    }

    public string logouturl
    {
      get => this.logouturlField;
      set => this.logouturlField = value;
    }

    public string artifactresolutionserviceurl
    {
      get => this.artifactresolutionserviceurlField;
      set => this.artifactresolutionserviceurlField = value;
    }

    public uint? skewtime
    {
      get => this.skewtimeField;
      set => this.skewtimeField = value;
    }

    internal override base_resource[] get_nitro_response(
      nitro_service service,
      string response)
    {
      authenticationsamlaction.authenticationsamlaction_response authenticationsamlactionResponse = new authenticationsamlaction.authenticationsamlaction_response();
      authenticationsamlaction.authenticationsamlaction_response resource = (authenticationsamlaction.authenticationsamlaction_response) service.get_payload_formatter().string_to_resource(authenticationsamlactionResponse.GetType(), response);
      if (resource.errorcode != 0)
      {
        if (resource.errorcode == 444)
          service.clear_session();
        if (resource.severity == null)
          throw new nitro_exception(resource.message, resource.errorcode);
        if (resource.severity.Equals("ERROR"))
          throw new nitro_exception(resource.message, resource.errorcode);
      }
      return (base_resource[]) resource.authenticationsamlaction;
    }

    internal override string get_object_name() => this.name;

    public static base_response add(
      nitro_service client,
      authenticationsamlaction resource)
    {
      return new authenticationsamlaction()
      {
        name = resource.name,
        samlidpcertname = resource.samlidpcertname,
        samlsigningcertname = resource.samlsigningcertname,
        samlredirecturl = resource.samlredirecturl,
        samlacsindex = resource.samlacsindex,
        samluserfield = resource.samluserfield,
        samlrejectunsignedassertion = resource.samlrejectunsignedassertion,
        samlissuername = resource.samlissuername,
        samltwofactor = resource.samltwofactor,
        defaultauthenticationgroup = resource.defaultauthenticationgroup,
        attribute1 = resource.attribute1,
        attribute2 = resource.attribute2,
        attribute3 = resource.attribute3,
        attribute4 = resource.attribute4,
        attribute5 = resource.attribute5,
        attribute6 = resource.attribute6,
        attribute7 = resource.attribute7,
        attribute8 = resource.attribute8,
        attribute9 = resource.attribute9,
        attribute10 = resource.attribute10,
        attribute11 = resource.attribute11,
        attribute12 = resource.attribute12,
        attribute13 = resource.attribute13,
        attribute14 = resource.attribute14,
        attribute15 = resource.attribute15,
        attribute16 = resource.attribute16,
        signaturealg = resource.signaturealg,
        digestmethod = resource.digestmethod,
        requestedauthncontext = resource.requestedauthncontext,
        authnctxclassref = resource.authnctxclassref,
        samlbinding = resource.samlbinding,
        attributeconsumingserviceindex = resource.attributeconsumingserviceindex,
        sendthumbprint = resource.sendthumbprint,
        enforceusername = resource.enforceusername,
        logouturl = resource.logouturl,
        artifactresolutionserviceurl = resource.artifactresolutionserviceurl,
        skewtime = resource.skewtime
      }.add_resource(client);
    }

    public static base_responses add(
      nitro_service client,
      authenticationsamlaction[] resources)
    {
      base_responses baseResponses = (base_responses) null;
      if (resources != null && resources.Length > 0)
      {
        authenticationsamlaction[] authenticationsamlactionArray = new authenticationsamlaction[resources.Length];
        for (int index = 0; index < resources.Length; ++index)
        {
          authenticationsamlactionArray[index] = new authenticationsamlaction();
          authenticationsamlactionArray[index].name = resources[index].name;
          authenticationsamlactionArray[index].samlidpcertname = resources[index].samlidpcertname;
          authenticationsamlactionArray[index].samlsigningcertname = resources[index].samlsigningcertname;
          authenticationsamlactionArray[index].samlredirecturl = resources[index].samlredirecturl;
          authenticationsamlactionArray[index].samlacsindex = resources[index].samlacsindex;
          authenticationsamlactionArray[index].samluserfield = resources[index].samluserfield;
          authenticationsamlactionArray[index].samlrejectunsignedassertion = resources[index].samlrejectunsignedassertion;
          authenticationsamlactionArray[index].samlissuername = resources[index].samlissuername;
          authenticationsamlactionArray[index].samltwofactor = resources[index].samltwofactor;
          authenticationsamlactionArray[index].defaultauthenticationgroup = resources[index].defaultauthenticationgroup;
          authenticationsamlactionArray[index].attribute1 = resources[index].attribute1;
          authenticationsamlactionArray[index].attribute2 = resources[index].attribute2;
          authenticationsamlactionArray[index].attribute3 = resources[index].attribute3;
          authenticationsamlactionArray[index].attribute4 = resources[index].attribute4;
          authenticationsamlactionArray[index].attribute5 = resources[index].attribute5;
          authenticationsamlactionArray[index].attribute6 = resources[index].attribute6;
          authenticationsamlactionArray[index].attribute7 = resources[index].attribute7;
          authenticationsamlactionArray[index].attribute8 = resources[index].attribute8;
          authenticationsamlactionArray[index].attribute9 = resources[index].attribute9;
          authenticationsamlactionArray[index].attribute10 = resources[index].attribute10;
          authenticationsamlactionArray[index].attribute11 = resources[index].attribute11;
          authenticationsamlactionArray[index].attribute12 = resources[index].attribute12;
          authenticationsamlactionArray[index].attribute13 = resources[index].attribute13;
          authenticationsamlactionArray[index].attribute14 = resources[index].attribute14;
          authenticationsamlactionArray[index].attribute15 = resources[index].attribute15;
          authenticationsamlactionArray[index].attribute16 = resources[index].attribute16;
          authenticationsamlactionArray[index].signaturealg = resources[index].signaturealg;
          authenticationsamlactionArray[index].digestmethod = resources[index].digestmethod;
          authenticationsamlactionArray[index].requestedauthncontext = resources[index].requestedauthncontext;
          authenticationsamlactionArray[index].authnctxclassref = resources[index].authnctxclassref;
          authenticationsamlactionArray[index].samlbinding = resources[index].samlbinding;
          authenticationsamlactionArray[index].attributeconsumingserviceindex = resources[index].attributeconsumingserviceindex;
          authenticationsamlactionArray[index].sendthumbprint = resources[index].sendthumbprint;
          authenticationsamlactionArray[index].enforceusername = resources[index].enforceusername;
          authenticationsamlactionArray[index].logouturl = resources[index].logouturl;
          authenticationsamlactionArray[index].artifactresolutionserviceurl = resources[index].artifactresolutionserviceurl;
          authenticationsamlactionArray[index].skewtime = resources[index].skewtime;
        }
        baseResponses = base_resource.add_bulk_request(client, (base_resource[]) authenticationsamlactionArray);
      }
      return baseResponses;
    }

    public static base_response delete(nitro_service client, string name) => new authenticationsamlaction()
    {
      name = name
    }.delete_resource(client);

    public static base_response delete(
      nitro_service client,
      authenticationsamlaction resource)
    {
      return new authenticationsamlaction()
      {
        name = resource.name
      }.delete_resource(client);
    }

    public static base_responses delete(nitro_service client, string[] name)
    {
      base_responses baseResponses = (base_responses) null;
      if (name != null && name.Length > 0)
      {
        authenticationsamlaction[] authenticationsamlactionArray = new authenticationsamlaction[name.Length];
        for (int index = 0; index < name.Length; ++index)
        {
          authenticationsamlactionArray[index] = new authenticationsamlaction();
          authenticationsamlactionArray[index].name = name[index];
        }
        baseResponses = base_resource.delete_bulk_request(client, (base_resource[]) authenticationsamlactionArray);
      }
      return baseResponses;
    }

    public static base_responses delete(
      nitro_service client,
      authenticationsamlaction[] resources)
    {
      base_responses baseResponses = (base_responses) null;
      if (resources != null && resources.Length > 0)
      {
        authenticationsamlaction[] authenticationsamlactionArray = new authenticationsamlaction[resources.Length];
        for (int index = 0; index < resources.Length; ++index)
        {
          authenticationsamlactionArray[index] = new authenticationsamlaction();
          authenticationsamlactionArray[index].name = resources[index].name;
        }
        baseResponses = base_resource.delete_bulk_request(client, (base_resource[]) authenticationsamlactionArray);
      }
      return baseResponses;
    }

    public static base_response update(
      nitro_service client,
      authenticationsamlaction resource)
    {
      return new authenticationsamlaction()
      {
        name = resource.name,
        samlidpcertname = resource.samlidpcertname,
        samlsigningcertname = resource.samlsigningcertname,
        samlredirecturl = resource.samlredirecturl,
        samlacsindex = resource.samlacsindex,
        samluserfield = resource.samluserfield,
        samlrejectunsignedassertion = resource.samlrejectunsignedassertion,
        samlissuername = resource.samlissuername,
        samltwofactor = resource.samltwofactor,
        defaultauthenticationgroup = resource.defaultauthenticationgroup,
        attribute1 = resource.attribute1,
        attribute2 = resource.attribute2,
        attribute3 = resource.attribute3,
        attribute4 = resource.attribute4,
        attribute5 = resource.attribute5,
        attribute6 = resource.attribute6,
        attribute7 = resource.attribute7,
        attribute8 = resource.attribute8,
        attribute9 = resource.attribute9,
        attribute10 = resource.attribute10,
        attribute11 = resource.attribute11,
        attribute12 = resource.attribute12,
        attribute13 = resource.attribute13,
        attribute14 = resource.attribute14,
        attribute15 = resource.attribute15,
        attribute16 = resource.attribute16,
        signaturealg = resource.signaturealg,
        digestmethod = resource.digestmethod,
        requestedauthncontext = resource.requestedauthncontext,
        authnctxclassref = resource.authnctxclassref,
        samlbinding = resource.samlbinding,
        attributeconsumingserviceindex = resource.attributeconsumingserviceindex,
        sendthumbprint = resource.sendthumbprint,
        enforceusername = resource.enforceusername,
        logouturl = resource.logouturl,
        artifactresolutionserviceurl = resource.artifactresolutionserviceurl,
        skewtime = resource.skewtime
      }.update_resource(client);
    }

    public static base_responses update(
      nitro_service client,
      authenticationsamlaction[] resources)
    {
      base_responses baseResponses = (base_responses) null;
      if (resources != null && resources.Length > 0)
      {
        authenticationsamlaction[] authenticationsamlactionArray = new authenticationsamlaction[resources.Length];
        for (int index = 0; index < resources.Length; ++index)
        {
          authenticationsamlactionArray[index] = new authenticationsamlaction();
          authenticationsamlactionArray[index].name = resources[index].name;
          authenticationsamlactionArray[index].samlidpcertname = resources[index].samlidpcertname;
          authenticationsamlactionArray[index].samlsigningcertname = resources[index].samlsigningcertname;
          authenticationsamlactionArray[index].samlredirecturl = resources[index].samlredirecturl;
          authenticationsamlactionArray[index].samlacsindex = resources[index].samlacsindex;
          authenticationsamlactionArray[index].samluserfield = resources[index].samluserfield;
          authenticationsamlactionArray[index].samlrejectunsignedassertion = resources[index].samlrejectunsignedassertion;
          authenticationsamlactionArray[index].samlissuername = resources[index].samlissuername;
          authenticationsamlactionArray[index].samltwofactor = resources[index].samltwofactor;
          authenticationsamlactionArray[index].defaultauthenticationgroup = resources[index].defaultauthenticationgroup;
          authenticationsamlactionArray[index].attribute1 = resources[index].attribute1;
          authenticationsamlactionArray[index].attribute2 = resources[index].attribute2;
          authenticationsamlactionArray[index].attribute3 = resources[index].attribute3;
          authenticationsamlactionArray[index].attribute4 = resources[index].attribute4;
          authenticationsamlactionArray[index].attribute5 = resources[index].attribute5;
          authenticationsamlactionArray[index].attribute6 = resources[index].attribute6;
          authenticationsamlactionArray[index].attribute7 = resources[index].attribute7;
          authenticationsamlactionArray[index].attribute8 = resources[index].attribute8;
          authenticationsamlactionArray[index].attribute9 = resources[index].attribute9;
          authenticationsamlactionArray[index].attribute10 = resources[index].attribute10;
          authenticationsamlactionArray[index].attribute11 = resources[index].attribute11;
          authenticationsamlactionArray[index].attribute12 = resources[index].attribute12;
          authenticationsamlactionArray[index].attribute13 = resources[index].attribute13;
          authenticationsamlactionArray[index].attribute14 = resources[index].attribute14;
          authenticationsamlactionArray[index].attribute15 = resources[index].attribute15;
          authenticationsamlactionArray[index].attribute16 = resources[index].attribute16;
          authenticationsamlactionArray[index].signaturealg = resources[index].signaturealg;
          authenticationsamlactionArray[index].digestmethod = resources[index].digestmethod;
          authenticationsamlactionArray[index].requestedauthncontext = resources[index].requestedauthncontext;
          authenticationsamlactionArray[index].authnctxclassref = resources[index].authnctxclassref;
          authenticationsamlactionArray[index].samlbinding = resources[index].samlbinding;
          authenticationsamlactionArray[index].attributeconsumingserviceindex = resources[index].attributeconsumingserviceindex;
          authenticationsamlactionArray[index].sendthumbprint = resources[index].sendthumbprint;
          authenticationsamlactionArray[index].enforceusername = resources[index].enforceusername;
          authenticationsamlactionArray[index].logouturl = resources[index].logouturl;
          authenticationsamlactionArray[index].artifactresolutionserviceurl = resources[index].artifactresolutionserviceurl;
          authenticationsamlactionArray[index].skewtime = resources[index].skewtime;
        }
        baseResponses = base_resource.update_bulk_request(client, (base_resource[]) authenticationsamlactionArray);
      }
      return baseResponses;
    }

    public static base_response unset(
      nitro_service client,
      string name,
      string[] args)
    {
      return new authenticationsamlaction() { name = name }.unset_resource(client, args);
    }

    public static base_response unset(
      nitro_service client,
      authenticationsamlaction resource,
      string[] args)
    {
      return new authenticationsamlaction()
      {
        name = resource.name
      }.unset_resource(client, args);
    }

    public static base_responses unset(
      nitro_service client,
      string[] name,
      string[] args)
    {
      base_responses baseResponses = (base_responses) null;
      if (name != null && name.Length > 0)
      {
        authenticationsamlaction[] authenticationsamlactionArray = new authenticationsamlaction[name.Length];
        for (int index = 0; index < name.Length; ++index)
        {
          authenticationsamlactionArray[index] = new authenticationsamlaction();
          authenticationsamlactionArray[index].name = name[index];
        }
        baseResponses = base_resource.unset_bulk_request(client, (base_resource[]) authenticationsamlactionArray, args);
      }
      return baseResponses;
    }

    public static base_responses unset(
      nitro_service client,
      authenticationsamlaction[] resources,
      string[] args)
    {
      base_responses baseResponses = (base_responses) null;
      if (resources != null && resources.Length > 0)
      {
        authenticationsamlaction[] authenticationsamlactionArray = new authenticationsamlaction[resources.Length];
        for (int index = 0; index < resources.Length; ++index)
        {
          authenticationsamlactionArray[index] = new authenticationsamlaction();
          authenticationsamlactionArray[index].name = resources[index].name;
        }
        baseResponses = base_resource.unset_bulk_request(client, (base_resource[]) authenticationsamlactionArray, args);
      }
      return baseResponses;
    }

    public static authenticationsamlaction[] get(nitro_service service) => (authenticationsamlaction[]) new authenticationsamlaction().get_resources(service, (options) null);

    public static authenticationsamlaction[] get(
      nitro_service service,
      options option)
    {
      return (authenticationsamlaction[]) new authenticationsamlaction().get_resources(service, option);
    }

    public static authenticationsamlaction get(
      nitro_service service,
      string name)
    {
      return (authenticationsamlaction) new authenticationsamlaction()
      {
        name = name
      }.get_resource(service);
    }

    public static authenticationsamlaction[] get(
      nitro_service service,
      string[] name)
    {
      if (name == null || name.Length <= 0)
        return (authenticationsamlaction[]) null;
      authenticationsamlaction[] authenticationsamlactionArray1 = new authenticationsamlaction[name.Length];
      authenticationsamlaction[] authenticationsamlactionArray2 = new authenticationsamlaction[name.Length];
      for (int index = 0; index < name.Length; ++index)
      {
        authenticationsamlactionArray2[index] = new authenticationsamlaction();
        authenticationsamlactionArray2[index].name = name[index];
        authenticationsamlactionArray1[index] = (authenticationsamlaction) authenticationsamlactionArray2[index].get_resource(service);
      }
      return authenticationsamlactionArray1;
    }

    public static authenticationsamlaction[] get_filtered(
      nitro_service service,
      string filter)
    {
      authenticationsamlaction authenticationsamlaction = new authenticationsamlaction();
      options option = new options();
      option.set_filter(filter);
      return (authenticationsamlaction[]) authenticationsamlaction.getfiltered(service, option);
    }

    public static authenticationsamlaction[] get_filtered(
      nitro_service service,
      filtervalue[] filter)
    {
      authenticationsamlaction authenticationsamlaction = new authenticationsamlaction();
      options option = new options();
      option.set_filter(filter);
      return (authenticationsamlaction[]) authenticationsamlaction.getfiltered(service, option);
    }

    public static uint count(nitro_service service)
    {
      authenticationsamlaction authenticationsamlaction = new authenticationsamlaction();
      options option = new options();
      option.set_count(true);
      authenticationsamlaction[] resources = (authenticationsamlaction[]) authenticationsamlaction.get_resources(service, option);
      return resources != null && resources.Length > 0 ? resources[0].__count.Value : 0U;
    }

    public static uint count_filtered(nitro_service service, string filter)
    {
      authenticationsamlaction authenticationsamlaction = new authenticationsamlaction();
      options option = new options();
      option.set_count(true);
      option.set_filter(filter);
      authenticationsamlaction[] authenticationsamlactionArray = (authenticationsamlaction[]) authenticationsamlaction.getfiltered(service, option);
      return authenticationsamlactionArray != null && authenticationsamlactionArray.Length > 0 ? authenticationsamlactionArray[0].__count.Value : 0U;
    }

    public static uint count_filtered(nitro_service service, filtervalue[] filter)
    {
      authenticationsamlaction authenticationsamlaction = new authenticationsamlaction();
      options option = new options();
      option.set_count(true);
      option.set_filter(filter);
      authenticationsamlaction[] authenticationsamlactionArray = (authenticationsamlaction[]) authenticationsamlaction.getfiltered(service, option);
      return authenticationsamlactionArray != null && authenticationsamlactionArray.Length > 0 ? authenticationsamlactionArray[0].__count.Value : 0U;
    }

    private class authenticationsamlaction_response : base_response
    {
      public authenticationsamlaction[] authenticationsamlaction = (authenticationsamlaction[]) null;
    }

    public static class signaturealgEnum
    {
      public const string RSA_SHA1 = "RSA-SHA1";
      public const string RSA_SHA256 = "RSA-SHA256";
    }

    public static class samltwofactorEnum
    {
      public const string ON = "ON";
      public const string OFF = "OFF";
    }

    public static class samlbindingEnum
    {
      public const string REDIRECT = "REDIRECT";
      public const string POST = "POST";
      public const string ARTIFACT = "ARTIFACT";
    }

    public static class samlrejectunsignedassertionEnum
    {
      public const string ON = "ON";
      public const string OFF = "OFF";
      public const string STRICT = "STRICT";
    }

    public static class digestmethodEnum
    {
      public const string SHA1 = "SHA1";
      public const string SHA256 = "SHA256";
    }

    public static class authnctxclassrefEnum
    {
      public const string InternetProtocol = "InternetProtocol";
      public const string InternetProtocolPassword = "InternetProtocolPassword";
      public const string Kerberos = "Kerberos";
      public const string MobileOneFactorUnregistered = "MobileOneFactorUnregistered";
      public const string MobileTwoFactorUnregistered = "MobileTwoFactorUnregistered";
      public const string MobileOneFactorContract = "MobileOneFactorContract";
      public const string MobileTwoFactorContract = "MobileTwoFactorContract";
      public const string Password = "Password";
      public const string PasswordProtectedTransport = "PasswordProtectedTransport";
      public const string PreviousSession = "PreviousSession";
      public const string X509 = "X509";
      public const string PGP = "PGP";
      public const string SPKI = "SPKI";
      public const string XMLDSig = "XMLDSig";
      public const string Smartcard = "Smartcard";
      public const string SmartcardPKI = "SmartcardPKI";
      public const string SoftwarePKI = "SoftwarePKI";
      public const string Telephony = "Telephony";
      public const string NomadTelephony = "NomadTelephony";
      public const string PersonalTelephony = "PersonalTelephony";
      public const string AuthenticatedTelephony = "AuthenticatedTelephony";
      public const string SecureRemotePassword = "SecureRemotePassword";
      public const string TLSClient = "TLSClient";
      public const string TimeSyncToken = "TimeSyncToken";
      public const string Unspecified = "Unspecified";
      public const string Windows = "Windows";
    }

    public static class requestedauthncontextEnum
    {
      public const string exact = "exact";
      public const string minimum = "minimum";
      public const string maximum = "maximum";
      public const string better = "better";
    }

    public static class sendthumbprintEnum
    {
      public const string ON = "ON";
      public const string OFF = "OFF";
    }

    public static class enforceusernameEnum
    {
      public const string ON = "ON";
      public const string OFF = "OFF";
    }
  }
}
