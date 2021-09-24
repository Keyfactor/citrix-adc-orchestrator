﻿// Decompiled with JetBrains decompiler
// Type: com.citrix.netscaler.nitro.resource.config.authentication.authenticationsamlidpprofile
// Assembly: nitro, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 6CF5DDEF-E052-4F9D-953F-6644F8378A66


using com.citrix.netscaler.nitro.exception;
using com.citrix.netscaler.nitro.resource.Base;
using com.citrix.netscaler.nitro.service;
using com.citrix.netscaler.nitro.util;

namespace com.citrix.netscaler.nitro.resource.config.authentication
{
  public class authenticationsamlidpprofile : base_resource
  {
    private string nameField = (string) null;
    private string samlspcertnameField = (string) null;
    private string samlidpcertnameField = (string) null;
    private string assertionconsumerserviceurlField = (string) null;
    private string sendpasswordField = (string) null;
    private string samlissuernameField = (string) null;
    private string rejectunsignedrequestsField = (string) null;
    private string signaturealgField = (string) null;
    private string digestmethodField = (string) null;
    private string audienceField = (string) null;
    private string nameidformatField = (string) null;
    private string nameidexprField = (string) null;
    private string attribute1Field = (string) null;
    private string attribute1exprField = (string) null;
    private string attribute1friendlynameField = (string) null;
    private string attribute1formatField = (string) null;
    private string attribute2Field = (string) null;
    private string attribute2exprField = (string) null;
    private string attribute2friendlynameField = (string) null;
    private string attribute2formatField = (string) null;
    private string attribute3Field = (string) null;
    private string attribute3exprField = (string) null;
    private string attribute3friendlynameField = (string) null;
    private string attribute3formatField = (string) null;
    private string attribute4Field = (string) null;
    private string attribute4exprField = (string) null;
    private string attribute4friendlynameField = (string) null;
    private string attribute4formatField = (string) null;
    private string attribute5Field = (string) null;
    private string attribute5exprField = (string) null;
    private string attribute5friendlynameField = (string) null;
    private string attribute5formatField = (string) null;
    private string attribute6Field = (string) null;
    private string attribute6exprField = (string) null;
    private string attribute6friendlynameField = (string) null;
    private string attribute6formatField = (string) null;
    private string attribute7Field = (string) null;
    private string attribute7exprField = (string) null;
    private string attribute7friendlynameField = (string) null;
    private string attribute7formatField = (string) null;
    private string attribute8Field = (string) null;
    private string attribute8exprField = (string) null;
    private string attribute8friendlynameField = (string) null;
    private string attribute8formatField = (string) null;
    private string attribute9Field = (string) null;
    private string attribute9exprField = (string) null;
    private string attribute9friendlynameField = (string) null;
    private string attribute9formatField = (string) null;
    private string attribute10Field = (string) null;
    private string attribute10exprField = (string) null;
    private string attribute10friendlynameField = (string) null;
    private string attribute10formatField = (string) null;
    private string attribute11Field = (string) null;
    private string attribute11exprField = (string) null;
    private string attribute11friendlynameField = (string) null;
    private string attribute11formatField = (string) null;
    private string attribute12Field = (string) null;
    private string attribute12exprField = (string) null;
    private string attribute12friendlynameField = (string) null;
    private string attribute12formatField = (string) null;
    private string attribute13Field = (string) null;
    private string attribute13exprField = (string) null;
    private string attribute13friendlynameField = (string) null;
    private string attribute13formatField = (string) null;
    private string attribute14Field = (string) null;
    private string attribute14exprField = (string) null;
    private string attribute14friendlynameField = (string) null;
    private string attribute14formatField = (string) null;
    private string attribute15Field = (string) null;
    private string attribute15exprField = (string) null;
    private string attribute15friendlynameField = (string) null;
    private string attribute15formatField = (string) null;
    private string attribute16Field = (string) null;
    private string attribute16exprField = (string) null;
    private string attribute16friendlynameField = (string) null;
    private string attribute16formatField = (string) null;
    private string encryptassertionField = (string) null;
    private string encryptionalgorithmField = (string) null;
    private string samlbindingField = (string) null;
    private uint? skewtimeField = new uint?();
    private string serviceprovideridField = (string) null;
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

    public string samlspcertname
    {
      get => this.samlspcertnameField;
      set => this.samlspcertnameField = value;
    }

    public string samlidpcertname
    {
      get => this.samlidpcertnameField;
      set => this.samlidpcertnameField = value;
    }

    public string assertionconsumerserviceurl
    {
      get => this.assertionconsumerserviceurlField;
      set => this.assertionconsumerserviceurlField = value;
    }

    public string sendpassword
    {
      get => this.sendpasswordField;
      set => this.sendpasswordField = value;
    }

    public string samlissuername
    {
      get => this.samlissuernameField;
      set => this.samlissuernameField = value;
    }

    public string rejectunsignedrequests
    {
      get => this.rejectunsignedrequestsField;
      set => this.rejectunsignedrequestsField = value;
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

    public string audience
    {
      get => this.audienceField;
      set => this.audienceField = value;
    }

    public string nameidformat
    {
      get => this.nameidformatField;
      set => this.nameidformatField = value;
    }

    public string nameidexpr
    {
      get => this.nameidexprField;
      set => this.nameidexprField = value;
    }

    public string attribute1
    {
      get => this.attribute1Field;
      set => this.attribute1Field = value;
    }

    public string attribute1expr
    {
      get => this.attribute1exprField;
      set => this.attribute1exprField = value;
    }

    public string attribute1friendlyname
    {
      get => this.attribute1friendlynameField;
      set => this.attribute1friendlynameField = value;
    }

    public string attribute1format
    {
      get => this.attribute1formatField;
      set => this.attribute1formatField = value;
    }

    public string attribute2
    {
      get => this.attribute2Field;
      set => this.attribute2Field = value;
    }

    public string attribute2expr
    {
      get => this.attribute2exprField;
      set => this.attribute2exprField = value;
    }

    public string attribute2friendlyname
    {
      get => this.attribute2friendlynameField;
      set => this.attribute2friendlynameField = value;
    }

    public string attribute2format
    {
      get => this.attribute2formatField;
      set => this.attribute2formatField = value;
    }

    public string attribute3
    {
      get => this.attribute3Field;
      set => this.attribute3Field = value;
    }

    public string attribute3expr
    {
      get => this.attribute3exprField;
      set => this.attribute3exprField = value;
    }

    public string attribute3friendlyname
    {
      get => this.attribute3friendlynameField;
      set => this.attribute3friendlynameField = value;
    }

    public string attribute3format
    {
      get => this.attribute3formatField;
      set => this.attribute3formatField = value;
    }

    public string attribute4
    {
      get => this.attribute4Field;
      set => this.attribute4Field = value;
    }

    public string attribute4expr
    {
      get => this.attribute4exprField;
      set => this.attribute4exprField = value;
    }

    public string attribute4friendlyname
    {
      get => this.attribute4friendlynameField;
      set => this.attribute4friendlynameField = value;
    }

    public string attribute4format
    {
      get => this.attribute4formatField;
      set => this.attribute4formatField = value;
    }

    public string attribute5
    {
      get => this.attribute5Field;
      set => this.attribute5Field = value;
    }

    public string attribute5expr
    {
      get => this.attribute5exprField;
      set => this.attribute5exprField = value;
    }

    public string attribute5friendlyname
    {
      get => this.attribute5friendlynameField;
      set => this.attribute5friendlynameField = value;
    }

    public string attribute5format
    {
      get => this.attribute5formatField;
      set => this.attribute5formatField = value;
    }

    public string attribute6
    {
      get => this.attribute6Field;
      set => this.attribute6Field = value;
    }

    public string attribute6expr
    {
      get => this.attribute6exprField;
      set => this.attribute6exprField = value;
    }

    public string attribute6friendlyname
    {
      get => this.attribute6friendlynameField;
      set => this.attribute6friendlynameField = value;
    }

    public string attribute6format
    {
      get => this.attribute6formatField;
      set => this.attribute6formatField = value;
    }

    public string attribute7
    {
      get => this.attribute7Field;
      set => this.attribute7Field = value;
    }

    public string attribute7expr
    {
      get => this.attribute7exprField;
      set => this.attribute7exprField = value;
    }

    public string attribute7friendlyname
    {
      get => this.attribute7friendlynameField;
      set => this.attribute7friendlynameField = value;
    }

    public string attribute7format
    {
      get => this.attribute7formatField;
      set => this.attribute7formatField = value;
    }

    public string attribute8
    {
      get => this.attribute8Field;
      set => this.attribute8Field = value;
    }

    public string attribute8expr
    {
      get => this.attribute8exprField;
      set => this.attribute8exprField = value;
    }

    public string attribute8friendlyname
    {
      get => this.attribute8friendlynameField;
      set => this.attribute8friendlynameField = value;
    }

    public string attribute8format
    {
      get => this.attribute8formatField;
      set => this.attribute8formatField = value;
    }

    public string attribute9
    {
      get => this.attribute9Field;
      set => this.attribute9Field = value;
    }

    public string attribute9expr
    {
      get => this.attribute9exprField;
      set => this.attribute9exprField = value;
    }

    public string attribute9friendlyname
    {
      get => this.attribute9friendlynameField;
      set => this.attribute9friendlynameField = value;
    }

    public string attribute9format
    {
      get => this.attribute9formatField;
      set => this.attribute9formatField = value;
    }

    public string attribute10
    {
      get => this.attribute10Field;
      set => this.attribute10Field = value;
    }

    public string attribute10expr
    {
      get => this.attribute10exprField;
      set => this.attribute10exprField = value;
    }

    public string attribute10friendlyname
    {
      get => this.attribute10friendlynameField;
      set => this.attribute10friendlynameField = value;
    }

    public string attribute10format
    {
      get => this.attribute10formatField;
      set => this.attribute10formatField = value;
    }

    public string attribute11
    {
      get => this.attribute11Field;
      set => this.attribute11Field = value;
    }

    public string attribute11expr
    {
      get => this.attribute11exprField;
      set => this.attribute11exprField = value;
    }

    public string attribute11friendlyname
    {
      get => this.attribute11friendlynameField;
      set => this.attribute11friendlynameField = value;
    }

    public string attribute11format
    {
      get => this.attribute11formatField;
      set => this.attribute11formatField = value;
    }

    public string attribute12
    {
      get => this.attribute12Field;
      set => this.attribute12Field = value;
    }

    public string attribute12expr
    {
      get => this.attribute12exprField;
      set => this.attribute12exprField = value;
    }

    public string attribute12friendlyname
    {
      get => this.attribute12friendlynameField;
      set => this.attribute12friendlynameField = value;
    }

    public string attribute12format
    {
      get => this.attribute12formatField;
      set => this.attribute12formatField = value;
    }

    public string attribute13
    {
      get => this.attribute13Field;
      set => this.attribute13Field = value;
    }

    public string attribute13expr
    {
      get => this.attribute13exprField;
      set => this.attribute13exprField = value;
    }

    public string attribute13friendlyname
    {
      get => this.attribute13friendlynameField;
      set => this.attribute13friendlynameField = value;
    }

    public string attribute13format
    {
      get => this.attribute13formatField;
      set => this.attribute13formatField = value;
    }

    public string attribute14
    {
      get => this.attribute14Field;
      set => this.attribute14Field = value;
    }

    public string attribute14expr
    {
      get => this.attribute14exprField;
      set => this.attribute14exprField = value;
    }

    public string attribute14friendlyname
    {
      get => this.attribute14friendlynameField;
      set => this.attribute14friendlynameField = value;
    }

    public string attribute14format
    {
      get => this.attribute14formatField;
      set => this.attribute14formatField = value;
    }

    public string attribute15
    {
      get => this.attribute15Field;
      set => this.attribute15Field = value;
    }

    public string attribute15expr
    {
      get => this.attribute15exprField;
      set => this.attribute15exprField = value;
    }

    public string attribute15friendlyname
    {
      get => this.attribute15friendlynameField;
      set => this.attribute15friendlynameField = value;
    }

    public string attribute15format
    {
      get => this.attribute15formatField;
      set => this.attribute15formatField = value;
    }

    public string attribute16
    {
      get => this.attribute16Field;
      set => this.attribute16Field = value;
    }

    public string attribute16expr
    {
      get => this.attribute16exprField;
      set => this.attribute16exprField = value;
    }

    public string attribute16friendlyname
    {
      get => this.attribute16friendlynameField;
      set => this.attribute16friendlynameField = value;
    }

    public string attribute16format
    {
      get => this.attribute16formatField;
      set => this.attribute16formatField = value;
    }

    public string encryptassertion
    {
      get => this.encryptassertionField;
      set => this.encryptassertionField = value;
    }

    public string encryptionalgorithm
    {
      get => this.encryptionalgorithmField;
      set => this.encryptionalgorithmField = value;
    }

    public string samlbinding
    {
      get => this.samlbindingField;
      set => this.samlbindingField = value;
    }

    public uint? skewtime
    {
      get => this.skewtimeField;
      set => this.skewtimeField = value;
    }

    public string serviceproviderid
    {
      get => this.serviceprovideridField;
      set => this.serviceprovideridField = value;
    }

    internal override base_resource[] get_nitro_response(
      nitro_service service,
      string response)
    {
      authenticationsamlidpprofile.authenticationsamlidpprofile_response authenticationsamlidpprofileResponse = new authenticationsamlidpprofile.authenticationsamlidpprofile_response();
      authenticationsamlidpprofile.authenticationsamlidpprofile_response resource = (authenticationsamlidpprofile.authenticationsamlidpprofile_response) service.get_payload_formatter().string_to_resource(authenticationsamlidpprofileResponse.GetType(), response);
      if (resource.errorcode != 0)
      {
        if (resource.errorcode == 444)
          service.clear_session();
        if (resource.severity == null)
          throw new nitro_exception(resource.message, resource.errorcode);
        if (resource.severity.Equals("ERROR"))
          throw new nitro_exception(resource.message, resource.errorcode);
      }
      return (base_resource[]) resource.authenticationsamlidpprofile;
    }

    internal override string get_object_name() => this.name;

    public static base_response add(
      nitro_service client,
      authenticationsamlidpprofile resource)
    {
      return new authenticationsamlidpprofile()
      {
        name = resource.name,
        samlspcertname = resource.samlspcertname,
        samlidpcertname = resource.samlidpcertname,
        assertionconsumerserviceurl = resource.assertionconsumerserviceurl,
        sendpassword = resource.sendpassword,
        samlissuername = resource.samlissuername,
        rejectunsignedrequests = resource.rejectunsignedrequests,
        signaturealg = resource.signaturealg,
        digestmethod = resource.digestmethod,
        audience = resource.audience,
        nameidformat = resource.nameidformat,
        nameidexpr = resource.nameidexpr,
        attribute1 = resource.attribute1,
        attribute1expr = resource.attribute1expr,
        attribute1friendlyname = resource.attribute1friendlyname,
        attribute1format = resource.attribute1format,
        attribute2 = resource.attribute2,
        attribute2expr = resource.attribute2expr,
        attribute2friendlyname = resource.attribute2friendlyname,
        attribute2format = resource.attribute2format,
        attribute3 = resource.attribute3,
        attribute3expr = resource.attribute3expr,
        attribute3friendlyname = resource.attribute3friendlyname,
        attribute3format = resource.attribute3format,
        attribute4 = resource.attribute4,
        attribute4expr = resource.attribute4expr,
        attribute4friendlyname = resource.attribute4friendlyname,
        attribute4format = resource.attribute4format,
        attribute5 = resource.attribute5,
        attribute5expr = resource.attribute5expr,
        attribute5friendlyname = resource.attribute5friendlyname,
        attribute5format = resource.attribute5format,
        attribute6 = resource.attribute6,
        attribute6expr = resource.attribute6expr,
        attribute6friendlyname = resource.attribute6friendlyname,
        attribute6format = resource.attribute6format,
        attribute7 = resource.attribute7,
        attribute7expr = resource.attribute7expr,
        attribute7friendlyname = resource.attribute7friendlyname,
        attribute7format = resource.attribute7format,
        attribute8 = resource.attribute8,
        attribute8expr = resource.attribute8expr,
        attribute8friendlyname = resource.attribute8friendlyname,
        attribute8format = resource.attribute8format,
        attribute9 = resource.attribute9,
        attribute9expr = resource.attribute9expr,
        attribute9friendlyname = resource.attribute9friendlyname,
        attribute9format = resource.attribute9format,
        attribute10 = resource.attribute10,
        attribute10expr = resource.attribute10expr,
        attribute10friendlyname = resource.attribute10friendlyname,
        attribute10format = resource.attribute10format,
        attribute11 = resource.attribute11,
        attribute11expr = resource.attribute11expr,
        attribute11friendlyname = resource.attribute11friendlyname,
        attribute11format = resource.attribute11format,
        attribute12 = resource.attribute12,
        attribute12expr = resource.attribute12expr,
        attribute12friendlyname = resource.attribute12friendlyname,
        attribute12format = resource.attribute12format,
        attribute13 = resource.attribute13,
        attribute13expr = resource.attribute13expr,
        attribute13friendlyname = resource.attribute13friendlyname,
        attribute13format = resource.attribute13format,
        attribute14 = resource.attribute14,
        attribute14expr = resource.attribute14expr,
        attribute14friendlyname = resource.attribute14friendlyname,
        attribute14format = resource.attribute14format,
        attribute15 = resource.attribute15,
        attribute15expr = resource.attribute15expr,
        attribute15friendlyname = resource.attribute15friendlyname,
        attribute15format = resource.attribute15format,
        attribute16 = resource.attribute16,
        attribute16expr = resource.attribute16expr,
        attribute16friendlyname = resource.attribute16friendlyname,
        attribute16format = resource.attribute16format,
        encryptassertion = resource.encryptassertion,
        encryptionalgorithm = resource.encryptionalgorithm,
        samlbinding = resource.samlbinding,
        skewtime = resource.skewtime,
        serviceproviderid = resource.serviceproviderid
      }.add_resource(client);
    }

    public static base_responses add(
      nitro_service client,
      authenticationsamlidpprofile[] resources)
    {
      base_responses baseResponses = (base_responses) null;
      if (resources != null && resources.Length > 0)
      {
        authenticationsamlidpprofile[] authenticationsamlidpprofileArray = new authenticationsamlidpprofile[resources.Length];
        for (int index = 0; index < resources.Length; ++index)
        {
          authenticationsamlidpprofileArray[index] = new authenticationsamlidpprofile();
          authenticationsamlidpprofileArray[index].name = resources[index].name;
          authenticationsamlidpprofileArray[index].samlspcertname = resources[index].samlspcertname;
          authenticationsamlidpprofileArray[index].samlidpcertname = resources[index].samlidpcertname;
          authenticationsamlidpprofileArray[index].assertionconsumerserviceurl = resources[index].assertionconsumerserviceurl;
          authenticationsamlidpprofileArray[index].sendpassword = resources[index].sendpassword;
          authenticationsamlidpprofileArray[index].samlissuername = resources[index].samlissuername;
          authenticationsamlidpprofileArray[index].rejectunsignedrequests = resources[index].rejectunsignedrequests;
          authenticationsamlidpprofileArray[index].signaturealg = resources[index].signaturealg;
          authenticationsamlidpprofileArray[index].digestmethod = resources[index].digestmethod;
          authenticationsamlidpprofileArray[index].audience = resources[index].audience;
          authenticationsamlidpprofileArray[index].nameidformat = resources[index].nameidformat;
          authenticationsamlidpprofileArray[index].nameidexpr = resources[index].nameidexpr;
          authenticationsamlidpprofileArray[index].attribute1 = resources[index].attribute1;
          authenticationsamlidpprofileArray[index].attribute1expr = resources[index].attribute1expr;
          authenticationsamlidpprofileArray[index].attribute1friendlyname = resources[index].attribute1friendlyname;
          authenticationsamlidpprofileArray[index].attribute1format = resources[index].attribute1format;
          authenticationsamlidpprofileArray[index].attribute2 = resources[index].attribute2;
          authenticationsamlidpprofileArray[index].attribute2expr = resources[index].attribute2expr;
          authenticationsamlidpprofileArray[index].attribute2friendlyname = resources[index].attribute2friendlyname;
          authenticationsamlidpprofileArray[index].attribute2format = resources[index].attribute2format;
          authenticationsamlidpprofileArray[index].attribute3 = resources[index].attribute3;
          authenticationsamlidpprofileArray[index].attribute3expr = resources[index].attribute3expr;
          authenticationsamlidpprofileArray[index].attribute3friendlyname = resources[index].attribute3friendlyname;
          authenticationsamlidpprofileArray[index].attribute3format = resources[index].attribute3format;
          authenticationsamlidpprofileArray[index].attribute4 = resources[index].attribute4;
          authenticationsamlidpprofileArray[index].attribute4expr = resources[index].attribute4expr;
          authenticationsamlidpprofileArray[index].attribute4friendlyname = resources[index].attribute4friendlyname;
          authenticationsamlidpprofileArray[index].attribute4format = resources[index].attribute4format;
          authenticationsamlidpprofileArray[index].attribute5 = resources[index].attribute5;
          authenticationsamlidpprofileArray[index].attribute5expr = resources[index].attribute5expr;
          authenticationsamlidpprofileArray[index].attribute5friendlyname = resources[index].attribute5friendlyname;
          authenticationsamlidpprofileArray[index].attribute5format = resources[index].attribute5format;
          authenticationsamlidpprofileArray[index].attribute6 = resources[index].attribute6;
          authenticationsamlidpprofileArray[index].attribute6expr = resources[index].attribute6expr;
          authenticationsamlidpprofileArray[index].attribute6friendlyname = resources[index].attribute6friendlyname;
          authenticationsamlidpprofileArray[index].attribute6format = resources[index].attribute6format;
          authenticationsamlidpprofileArray[index].attribute7 = resources[index].attribute7;
          authenticationsamlidpprofileArray[index].attribute7expr = resources[index].attribute7expr;
          authenticationsamlidpprofileArray[index].attribute7friendlyname = resources[index].attribute7friendlyname;
          authenticationsamlidpprofileArray[index].attribute7format = resources[index].attribute7format;
          authenticationsamlidpprofileArray[index].attribute8 = resources[index].attribute8;
          authenticationsamlidpprofileArray[index].attribute8expr = resources[index].attribute8expr;
          authenticationsamlidpprofileArray[index].attribute8friendlyname = resources[index].attribute8friendlyname;
          authenticationsamlidpprofileArray[index].attribute8format = resources[index].attribute8format;
          authenticationsamlidpprofileArray[index].attribute9 = resources[index].attribute9;
          authenticationsamlidpprofileArray[index].attribute9expr = resources[index].attribute9expr;
          authenticationsamlidpprofileArray[index].attribute9friendlyname = resources[index].attribute9friendlyname;
          authenticationsamlidpprofileArray[index].attribute9format = resources[index].attribute9format;
          authenticationsamlidpprofileArray[index].attribute10 = resources[index].attribute10;
          authenticationsamlidpprofileArray[index].attribute10expr = resources[index].attribute10expr;
          authenticationsamlidpprofileArray[index].attribute10friendlyname = resources[index].attribute10friendlyname;
          authenticationsamlidpprofileArray[index].attribute10format = resources[index].attribute10format;
          authenticationsamlidpprofileArray[index].attribute11 = resources[index].attribute11;
          authenticationsamlidpprofileArray[index].attribute11expr = resources[index].attribute11expr;
          authenticationsamlidpprofileArray[index].attribute11friendlyname = resources[index].attribute11friendlyname;
          authenticationsamlidpprofileArray[index].attribute11format = resources[index].attribute11format;
          authenticationsamlidpprofileArray[index].attribute12 = resources[index].attribute12;
          authenticationsamlidpprofileArray[index].attribute12expr = resources[index].attribute12expr;
          authenticationsamlidpprofileArray[index].attribute12friendlyname = resources[index].attribute12friendlyname;
          authenticationsamlidpprofileArray[index].attribute12format = resources[index].attribute12format;
          authenticationsamlidpprofileArray[index].attribute13 = resources[index].attribute13;
          authenticationsamlidpprofileArray[index].attribute13expr = resources[index].attribute13expr;
          authenticationsamlidpprofileArray[index].attribute13friendlyname = resources[index].attribute13friendlyname;
          authenticationsamlidpprofileArray[index].attribute13format = resources[index].attribute13format;
          authenticationsamlidpprofileArray[index].attribute14 = resources[index].attribute14;
          authenticationsamlidpprofileArray[index].attribute14expr = resources[index].attribute14expr;
          authenticationsamlidpprofileArray[index].attribute14friendlyname = resources[index].attribute14friendlyname;
          authenticationsamlidpprofileArray[index].attribute14format = resources[index].attribute14format;
          authenticationsamlidpprofileArray[index].attribute15 = resources[index].attribute15;
          authenticationsamlidpprofileArray[index].attribute15expr = resources[index].attribute15expr;
          authenticationsamlidpprofileArray[index].attribute15friendlyname = resources[index].attribute15friendlyname;
          authenticationsamlidpprofileArray[index].attribute15format = resources[index].attribute15format;
          authenticationsamlidpprofileArray[index].attribute16 = resources[index].attribute16;
          authenticationsamlidpprofileArray[index].attribute16expr = resources[index].attribute16expr;
          authenticationsamlidpprofileArray[index].attribute16friendlyname = resources[index].attribute16friendlyname;
          authenticationsamlidpprofileArray[index].attribute16format = resources[index].attribute16format;
          authenticationsamlidpprofileArray[index].encryptassertion = resources[index].encryptassertion;
          authenticationsamlidpprofileArray[index].encryptionalgorithm = resources[index].encryptionalgorithm;
          authenticationsamlidpprofileArray[index].samlbinding = resources[index].samlbinding;
          authenticationsamlidpprofileArray[index].skewtime = resources[index].skewtime;
          authenticationsamlidpprofileArray[index].serviceproviderid = resources[index].serviceproviderid;
        }
        baseResponses = base_resource.add_bulk_request(client, (base_resource[]) authenticationsamlidpprofileArray);
      }
      return baseResponses;
    }

    public static base_response delete(nitro_service client, string name) => new authenticationsamlidpprofile()
    {
      name = name
    }.delete_resource(client);

    public static base_response delete(
      nitro_service client,
      authenticationsamlidpprofile resource)
    {
      return new authenticationsamlidpprofile()
      {
        name = resource.name
      }.delete_resource(client);
    }

    public static base_responses delete(nitro_service client, string[] name)
    {
      base_responses baseResponses = (base_responses) null;
      if (name != null && name.Length > 0)
      {
        authenticationsamlidpprofile[] authenticationsamlidpprofileArray = new authenticationsamlidpprofile[name.Length];
        for (int index = 0; index < name.Length; ++index)
        {
          authenticationsamlidpprofileArray[index] = new authenticationsamlidpprofile();
          authenticationsamlidpprofileArray[index].name = name[index];
        }
        baseResponses = base_resource.delete_bulk_request(client, (base_resource[]) authenticationsamlidpprofileArray);
      }
      return baseResponses;
    }

    public static base_responses delete(
      nitro_service client,
      authenticationsamlidpprofile[] resources)
    {
      base_responses baseResponses = (base_responses) null;
      if (resources != null && resources.Length > 0)
      {
        authenticationsamlidpprofile[] authenticationsamlidpprofileArray = new authenticationsamlidpprofile[resources.Length];
        for (int index = 0; index < resources.Length; ++index)
        {
          authenticationsamlidpprofileArray[index] = new authenticationsamlidpprofile();
          authenticationsamlidpprofileArray[index].name = resources[index].name;
        }
        baseResponses = base_resource.delete_bulk_request(client, (base_resource[]) authenticationsamlidpprofileArray);
      }
      return baseResponses;
    }

    public static base_response update(
      nitro_service client,
      authenticationsamlidpprofile resource)
    {
      return new authenticationsamlidpprofile()
      {
        name = resource.name,
        samlspcertname = resource.samlspcertname,
        samlidpcertname = resource.samlidpcertname,
        assertionconsumerserviceurl = resource.assertionconsumerserviceurl,
        sendpassword = resource.sendpassword,
        samlissuername = resource.samlissuername,
        rejectunsignedrequests = resource.rejectunsignedrequests,
        signaturealg = resource.signaturealg,
        digestmethod = resource.digestmethod,
        audience = resource.audience,
        nameidformat = resource.nameidformat,
        nameidexpr = resource.nameidexpr,
        attribute1 = resource.attribute1,
        attribute1expr = resource.attribute1expr,
        attribute1friendlyname = resource.attribute1friendlyname,
        attribute1format = resource.attribute1format,
        attribute2 = resource.attribute2,
        attribute2expr = resource.attribute2expr,
        attribute2friendlyname = resource.attribute2friendlyname,
        attribute2format = resource.attribute2format,
        attribute3 = resource.attribute3,
        attribute3expr = resource.attribute3expr,
        attribute3friendlyname = resource.attribute3friendlyname,
        attribute3format = resource.attribute3format,
        attribute4 = resource.attribute4,
        attribute4expr = resource.attribute4expr,
        attribute4friendlyname = resource.attribute4friendlyname,
        attribute4format = resource.attribute4format,
        attribute5 = resource.attribute5,
        attribute5expr = resource.attribute5expr,
        attribute5friendlyname = resource.attribute5friendlyname,
        attribute5format = resource.attribute5format,
        attribute6 = resource.attribute6,
        attribute6expr = resource.attribute6expr,
        attribute6friendlyname = resource.attribute6friendlyname,
        attribute6format = resource.attribute6format,
        attribute7 = resource.attribute7,
        attribute7expr = resource.attribute7expr,
        attribute7friendlyname = resource.attribute7friendlyname,
        attribute7format = resource.attribute7format,
        attribute8 = resource.attribute8,
        attribute8expr = resource.attribute8expr,
        attribute8friendlyname = resource.attribute8friendlyname,
        attribute8format = resource.attribute8format,
        attribute9 = resource.attribute9,
        attribute9expr = resource.attribute9expr,
        attribute9friendlyname = resource.attribute9friendlyname,
        attribute9format = resource.attribute9format,
        attribute10 = resource.attribute10,
        attribute10expr = resource.attribute10expr,
        attribute10friendlyname = resource.attribute10friendlyname,
        attribute10format = resource.attribute10format,
        attribute11 = resource.attribute11,
        attribute11expr = resource.attribute11expr,
        attribute11friendlyname = resource.attribute11friendlyname,
        attribute11format = resource.attribute11format,
        attribute12 = resource.attribute12,
        attribute12expr = resource.attribute12expr,
        attribute12friendlyname = resource.attribute12friendlyname,
        attribute12format = resource.attribute12format,
        attribute13 = resource.attribute13,
        attribute13expr = resource.attribute13expr,
        attribute13friendlyname = resource.attribute13friendlyname,
        attribute13format = resource.attribute13format,
        attribute14 = resource.attribute14,
        attribute14expr = resource.attribute14expr,
        attribute14friendlyname = resource.attribute14friendlyname,
        attribute14format = resource.attribute14format,
        attribute15 = resource.attribute15,
        attribute15expr = resource.attribute15expr,
        attribute15friendlyname = resource.attribute15friendlyname,
        attribute15format = resource.attribute15format,
        attribute16 = resource.attribute16,
        attribute16expr = resource.attribute16expr,
        attribute16friendlyname = resource.attribute16friendlyname,
        attribute16format = resource.attribute16format,
        encryptassertion = resource.encryptassertion,
        encryptionalgorithm = resource.encryptionalgorithm,
        samlbinding = resource.samlbinding,
        skewtime = resource.skewtime,
        serviceproviderid = resource.serviceproviderid
      }.update_resource(client);
    }

    public static base_responses update(
      nitro_service client,
      authenticationsamlidpprofile[] resources)
    {
      base_responses baseResponses = (base_responses) null;
      if (resources != null && resources.Length > 0)
      {
        authenticationsamlidpprofile[] authenticationsamlidpprofileArray = new authenticationsamlidpprofile[resources.Length];
        for (int index = 0; index < resources.Length; ++index)
        {
          authenticationsamlidpprofileArray[index] = new authenticationsamlidpprofile();
          authenticationsamlidpprofileArray[index].name = resources[index].name;
          authenticationsamlidpprofileArray[index].samlspcertname = resources[index].samlspcertname;
          authenticationsamlidpprofileArray[index].samlidpcertname = resources[index].samlidpcertname;
          authenticationsamlidpprofileArray[index].assertionconsumerserviceurl = resources[index].assertionconsumerserviceurl;
          authenticationsamlidpprofileArray[index].sendpassword = resources[index].sendpassword;
          authenticationsamlidpprofileArray[index].samlissuername = resources[index].samlissuername;
          authenticationsamlidpprofileArray[index].rejectunsignedrequests = resources[index].rejectunsignedrequests;
          authenticationsamlidpprofileArray[index].signaturealg = resources[index].signaturealg;
          authenticationsamlidpprofileArray[index].digestmethod = resources[index].digestmethod;
          authenticationsamlidpprofileArray[index].audience = resources[index].audience;
          authenticationsamlidpprofileArray[index].nameidformat = resources[index].nameidformat;
          authenticationsamlidpprofileArray[index].nameidexpr = resources[index].nameidexpr;
          authenticationsamlidpprofileArray[index].attribute1 = resources[index].attribute1;
          authenticationsamlidpprofileArray[index].attribute1expr = resources[index].attribute1expr;
          authenticationsamlidpprofileArray[index].attribute1friendlyname = resources[index].attribute1friendlyname;
          authenticationsamlidpprofileArray[index].attribute1format = resources[index].attribute1format;
          authenticationsamlidpprofileArray[index].attribute2 = resources[index].attribute2;
          authenticationsamlidpprofileArray[index].attribute2expr = resources[index].attribute2expr;
          authenticationsamlidpprofileArray[index].attribute2friendlyname = resources[index].attribute2friendlyname;
          authenticationsamlidpprofileArray[index].attribute2format = resources[index].attribute2format;
          authenticationsamlidpprofileArray[index].attribute3 = resources[index].attribute3;
          authenticationsamlidpprofileArray[index].attribute3expr = resources[index].attribute3expr;
          authenticationsamlidpprofileArray[index].attribute3friendlyname = resources[index].attribute3friendlyname;
          authenticationsamlidpprofileArray[index].attribute3format = resources[index].attribute3format;
          authenticationsamlidpprofileArray[index].attribute4 = resources[index].attribute4;
          authenticationsamlidpprofileArray[index].attribute4expr = resources[index].attribute4expr;
          authenticationsamlidpprofileArray[index].attribute4friendlyname = resources[index].attribute4friendlyname;
          authenticationsamlidpprofileArray[index].attribute4format = resources[index].attribute4format;
          authenticationsamlidpprofileArray[index].attribute5 = resources[index].attribute5;
          authenticationsamlidpprofileArray[index].attribute5expr = resources[index].attribute5expr;
          authenticationsamlidpprofileArray[index].attribute5friendlyname = resources[index].attribute5friendlyname;
          authenticationsamlidpprofileArray[index].attribute5format = resources[index].attribute5format;
          authenticationsamlidpprofileArray[index].attribute6 = resources[index].attribute6;
          authenticationsamlidpprofileArray[index].attribute6expr = resources[index].attribute6expr;
          authenticationsamlidpprofileArray[index].attribute6friendlyname = resources[index].attribute6friendlyname;
          authenticationsamlidpprofileArray[index].attribute6format = resources[index].attribute6format;
          authenticationsamlidpprofileArray[index].attribute7 = resources[index].attribute7;
          authenticationsamlidpprofileArray[index].attribute7expr = resources[index].attribute7expr;
          authenticationsamlidpprofileArray[index].attribute7friendlyname = resources[index].attribute7friendlyname;
          authenticationsamlidpprofileArray[index].attribute7format = resources[index].attribute7format;
          authenticationsamlidpprofileArray[index].attribute8 = resources[index].attribute8;
          authenticationsamlidpprofileArray[index].attribute8expr = resources[index].attribute8expr;
          authenticationsamlidpprofileArray[index].attribute8friendlyname = resources[index].attribute8friendlyname;
          authenticationsamlidpprofileArray[index].attribute8format = resources[index].attribute8format;
          authenticationsamlidpprofileArray[index].attribute9 = resources[index].attribute9;
          authenticationsamlidpprofileArray[index].attribute9expr = resources[index].attribute9expr;
          authenticationsamlidpprofileArray[index].attribute9friendlyname = resources[index].attribute9friendlyname;
          authenticationsamlidpprofileArray[index].attribute9format = resources[index].attribute9format;
          authenticationsamlidpprofileArray[index].attribute10 = resources[index].attribute10;
          authenticationsamlidpprofileArray[index].attribute10expr = resources[index].attribute10expr;
          authenticationsamlidpprofileArray[index].attribute10friendlyname = resources[index].attribute10friendlyname;
          authenticationsamlidpprofileArray[index].attribute10format = resources[index].attribute10format;
          authenticationsamlidpprofileArray[index].attribute11 = resources[index].attribute11;
          authenticationsamlidpprofileArray[index].attribute11expr = resources[index].attribute11expr;
          authenticationsamlidpprofileArray[index].attribute11friendlyname = resources[index].attribute11friendlyname;
          authenticationsamlidpprofileArray[index].attribute11format = resources[index].attribute11format;
          authenticationsamlidpprofileArray[index].attribute12 = resources[index].attribute12;
          authenticationsamlidpprofileArray[index].attribute12expr = resources[index].attribute12expr;
          authenticationsamlidpprofileArray[index].attribute12friendlyname = resources[index].attribute12friendlyname;
          authenticationsamlidpprofileArray[index].attribute12format = resources[index].attribute12format;
          authenticationsamlidpprofileArray[index].attribute13 = resources[index].attribute13;
          authenticationsamlidpprofileArray[index].attribute13expr = resources[index].attribute13expr;
          authenticationsamlidpprofileArray[index].attribute13friendlyname = resources[index].attribute13friendlyname;
          authenticationsamlidpprofileArray[index].attribute13format = resources[index].attribute13format;
          authenticationsamlidpprofileArray[index].attribute14 = resources[index].attribute14;
          authenticationsamlidpprofileArray[index].attribute14expr = resources[index].attribute14expr;
          authenticationsamlidpprofileArray[index].attribute14friendlyname = resources[index].attribute14friendlyname;
          authenticationsamlidpprofileArray[index].attribute14format = resources[index].attribute14format;
          authenticationsamlidpprofileArray[index].attribute15 = resources[index].attribute15;
          authenticationsamlidpprofileArray[index].attribute15expr = resources[index].attribute15expr;
          authenticationsamlidpprofileArray[index].attribute15friendlyname = resources[index].attribute15friendlyname;
          authenticationsamlidpprofileArray[index].attribute15format = resources[index].attribute15format;
          authenticationsamlidpprofileArray[index].attribute16 = resources[index].attribute16;
          authenticationsamlidpprofileArray[index].attribute16expr = resources[index].attribute16expr;
          authenticationsamlidpprofileArray[index].attribute16friendlyname = resources[index].attribute16friendlyname;
          authenticationsamlidpprofileArray[index].attribute16format = resources[index].attribute16format;
          authenticationsamlidpprofileArray[index].encryptassertion = resources[index].encryptassertion;
          authenticationsamlidpprofileArray[index].encryptionalgorithm = resources[index].encryptionalgorithm;
          authenticationsamlidpprofileArray[index].samlbinding = resources[index].samlbinding;
          authenticationsamlidpprofileArray[index].skewtime = resources[index].skewtime;
          authenticationsamlidpprofileArray[index].serviceproviderid = resources[index].serviceproviderid;
        }
        baseResponses = base_resource.update_bulk_request(client, (base_resource[]) authenticationsamlidpprofileArray);
      }
      return baseResponses;
    }

    public static base_response unset(
      nitro_service client,
      string name,
      string[] args)
    {
      return new authenticationsamlidpprofile()
      {
        name = name
      }.unset_resource(client, args);
    }

    public static base_response unset(
      nitro_service client,
      authenticationsamlidpprofile resource,
      string[] args)
    {
      return new authenticationsamlidpprofile()
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
        authenticationsamlidpprofile[] authenticationsamlidpprofileArray = new authenticationsamlidpprofile[name.Length];
        for (int index = 0; index < name.Length; ++index)
        {
          authenticationsamlidpprofileArray[index] = new authenticationsamlidpprofile();
          authenticationsamlidpprofileArray[index].name = name[index];
        }
        baseResponses = base_resource.unset_bulk_request(client, (base_resource[]) authenticationsamlidpprofileArray, args);
      }
      return baseResponses;
    }

    public static base_responses unset(
      nitro_service client,
      authenticationsamlidpprofile[] resources,
      string[] args)
    {
      base_responses baseResponses = (base_responses) null;
      if (resources != null && resources.Length > 0)
      {
        authenticationsamlidpprofile[] authenticationsamlidpprofileArray = new authenticationsamlidpprofile[resources.Length];
        for (int index = 0; index < resources.Length; ++index)
        {
          authenticationsamlidpprofileArray[index] = new authenticationsamlidpprofile();
          authenticationsamlidpprofileArray[index].name = resources[index].name;
        }
        baseResponses = base_resource.unset_bulk_request(client, (base_resource[]) authenticationsamlidpprofileArray, args);
      }
      return baseResponses;
    }

    public static authenticationsamlidpprofile[] get(
      nitro_service service)
    {
      return (authenticationsamlidpprofile[]) new authenticationsamlidpprofile().get_resources(service, (options) null);
    }

    public static authenticationsamlidpprofile[] get(
      nitro_service service,
      options option)
    {
      return (authenticationsamlidpprofile[]) new authenticationsamlidpprofile().get_resources(service, option);
    }

    public static authenticationsamlidpprofile get(
      nitro_service service,
      string name)
    {
      return (authenticationsamlidpprofile) new authenticationsamlidpprofile()
      {
        name = name
      }.get_resource(service);
    }

    public static authenticationsamlidpprofile[] get(
      nitro_service service,
      string[] name)
    {
      if (name == null || name.Length <= 0)
        return (authenticationsamlidpprofile[]) null;
      authenticationsamlidpprofile[] authenticationsamlidpprofileArray1 = new authenticationsamlidpprofile[name.Length];
      authenticationsamlidpprofile[] authenticationsamlidpprofileArray2 = new authenticationsamlidpprofile[name.Length];
      for (int index = 0; index < name.Length; ++index)
      {
        authenticationsamlidpprofileArray2[index] = new authenticationsamlidpprofile();
        authenticationsamlidpprofileArray2[index].name = name[index];
        authenticationsamlidpprofileArray1[index] = (authenticationsamlidpprofile) authenticationsamlidpprofileArray2[index].get_resource(service);
      }
      return authenticationsamlidpprofileArray1;
    }

    public static authenticationsamlidpprofile[] get_filtered(
      nitro_service service,
      string filter)
    {
      authenticationsamlidpprofile authenticationsamlidpprofile = new authenticationsamlidpprofile();
      options option = new options();
      option.set_filter(filter);
      return (authenticationsamlidpprofile[]) authenticationsamlidpprofile.getfiltered(service, option);
    }

    public static authenticationsamlidpprofile[] get_filtered(
      nitro_service service,
      filtervalue[] filter)
    {
      authenticationsamlidpprofile authenticationsamlidpprofile = new authenticationsamlidpprofile();
      options option = new options();
      option.set_filter(filter);
      return (authenticationsamlidpprofile[]) authenticationsamlidpprofile.getfiltered(service, option);
    }

    public static uint count(nitro_service service)
    {
      authenticationsamlidpprofile authenticationsamlidpprofile = new authenticationsamlidpprofile();
      options option = new options();
      option.set_count(true);
      authenticationsamlidpprofile[] resources = (authenticationsamlidpprofile[]) authenticationsamlidpprofile.get_resources(service, option);
      return resources != null && resources.Length > 0 ? resources[0].__count.Value : 0U;
    }

    public static uint count_filtered(nitro_service service, string filter)
    {
      authenticationsamlidpprofile authenticationsamlidpprofile = new authenticationsamlidpprofile();
      options option = new options();
      option.set_count(true);
      option.set_filter(filter);
      authenticationsamlidpprofile[] authenticationsamlidpprofileArray = (authenticationsamlidpprofile[]) authenticationsamlidpprofile.getfiltered(service, option);
      return authenticationsamlidpprofileArray != null && authenticationsamlidpprofileArray.Length > 0 ? authenticationsamlidpprofileArray[0].__count.Value : 0U;
    }

    public static uint count_filtered(nitro_service service, filtervalue[] filter)
    {
      authenticationsamlidpprofile authenticationsamlidpprofile = new authenticationsamlidpprofile();
      options option = new options();
      option.set_count(true);
      option.set_filter(filter);
      authenticationsamlidpprofile[] authenticationsamlidpprofileArray = (authenticationsamlidpprofile[]) authenticationsamlidpprofile.getfiltered(service, option);
      return authenticationsamlidpprofileArray != null && authenticationsamlidpprofileArray.Length > 0 ? authenticationsamlidpprofileArray[0].__count.Value : 0U;
    }

    private class authenticationsamlidpprofile_response : base_response
    {
      public authenticationsamlidpprofile[] authenticationsamlidpprofile = (authenticationsamlidpprofile[]) null;
    }

    public static class attribute3formatEnum
    {
      public const string URI = "URI";
      public const string Basic = "Basic";
    }

    public static class encryptassertionEnum
    {
      public const string ON = "ON";
      public const string OFF = "OFF";
    }

    public static class sendpasswordEnum
    {
      public const string ON = "ON";
      public const string OFF = "OFF";
    }

    public static class attribute6formatEnum
    {
      public const string URI = "URI";
      public const string Basic = "Basic";
    }

    public static class attribute10formatEnum
    {
      public const string URI = "URI";
      public const string Basic = "Basic";
    }

    public static class attribute9formatEnum
    {
      public const string URI = "URI";
      public const string Basic = "Basic";
    }

    public static class nameidformatEnum
    {
      public const string Unspecified = "Unspecified";
      public const string emailAddress = "emailAddress";
      public const string X509SubjectName = "X509SubjectName";
      public const string WindowsDomainQualifiedName = "WindowsDomainQualifiedName";
      public const string kerberos = "kerberos";
      public const string entity = "entity";
      public const string persistent = "persistent";
      public const string Transient = "transient";
    }

    public static class signaturealgEnum
    {
      public const string RSA_SHA1 = "RSA-SHA1";
      public const string RSA_SHA256 = "RSA-SHA256";
    }

    public static class attribute1formatEnum
    {
      public const string URI = "URI";
      public const string Basic = "Basic";
    }

    public static class attribute12formatEnum
    {
      public const string URI = "URI";
      public const string Basic = "Basic";
    }

    public static class attribute8formatEnum
    {
      public const string URI = "URI";
      public const string Basic = "Basic";
    }

    public static class attribute5formatEnum
    {
      public const string URI = "URI";
      public const string Basic = "Basic";
    }

    public static class samlbindingEnum
    {
      public const string REDIRECT = "REDIRECT";
      public const string POST = "POST";
      public const string ARTIFACT = "ARTIFACT";
    }

    public static class attribute7formatEnum
    {
      public const string URI = "URI";
      public const string Basic = "Basic";
    }

    public static class attribute15formatEnum
    {
      public const string URI = "URI";
      public const string Basic = "Basic";
    }

    public static class digestmethodEnum
    {
      public const string SHA1 = "SHA1";
      public const string SHA256 = "SHA256";
    }

    public static class attribute2formatEnum
    {
      public const string URI = "URI";
      public const string Basic = "Basic";
    }

    public static class rejectunsignedrequestsEnum
    {
      public const string ON = "ON";
      public const string OFF = "OFF";
    }

    public static class attribute4formatEnum
    {
      public const string URI = "URI";
      public const string Basic = "Basic";
    }

    public static class attribute13formatEnum
    {
      public const string URI = "URI";
      public const string Basic = "Basic";
    }

    public static class attribute14formatEnum
    {
      public const string URI = "URI";
      public const string Basic = "Basic";
    }

    public static class attribute16formatEnum
    {
      public const string URI = "URI";
      public const string Basic = "Basic";
    }

    public static class attribute11formatEnum
    {
      public const string URI = "URI";
      public const string Basic = "Basic";
    }

    public static class encryptionalgorithmEnum
    {
      public const string DES3 = "DES3";
      public const string AES128 = "AES128";
      public const string AES192 = "AES192";
      public const string AES256 = "AES256";
    }
  }
}
