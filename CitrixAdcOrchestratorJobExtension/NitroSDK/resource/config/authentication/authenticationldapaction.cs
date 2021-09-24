// Decompiled with JetBrains decompiler
// Type: com.citrix.netscaler.nitro.resource.config.authentication.authenticationldapaction
// Assembly: nitro, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 6CF5DDEF-E052-4F9D-953F-6644F8378A66


using com.citrix.netscaler.nitro.exception;
using com.citrix.netscaler.nitro.resource.Base;
using com.citrix.netscaler.nitro.service;
using com.citrix.netscaler.nitro.util;

namespace com.citrix.netscaler.nitro.resource.config.authentication
{
  public class authenticationldapaction : base_resource
  {
    private string nameField = (string) null;
    private string serveripField = (string) null;
    private string servernameField = (string) null;
    private ushort? serverportField = new ushort?();
    private uint? authtimeoutField = new uint?();
    private string ldapbaseField = (string) null;
    private string ldapbinddnField = (string) null;
    private string ldapbinddnpasswordField = (string) null;
    private string ldaploginnameField = (string) null;
    private string searchfilterField = (string) null;
    private string groupattrnameField = (string) null;
    private string subattributenameField = (string) null;
    private string sectypeField = (string) null;
    private string svrtypeField = (string) null;
    private string ssonameattributeField = (string) null;
    private string authenticationField = (string) null;
    private string requireuserField = (string) null;
    private string passwdchangeField = (string) null;
    private string nestedgroupextractionField = (string) null;
    private uint? maxnestinglevelField = new uint?();
    private string followreferralsField = (string) null;
    private uint? maxldapreferralsField = new uint?();
    private string referraldnslookupField = (string) null;
    private string mssrvrecordlocationField = (string) null;
    private string validateservercertField = (string) null;
    private string ldaphostnameField = (string) null;
    private string groupnameidentifierField = (string) null;
    private string groupsearchattributeField = (string) null;
    private string groupsearchsubattributeField = (string) null;
    private string groupsearchfilterField = (string) null;
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
    private long? successField = new long?();
    private long? failureField = new long?();
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

    public string serverip
    {
      get => this.serveripField;
      set => this.serveripField = value;
    }

    public string servername
    {
      get => this.servernameField;
      set => this.servernameField = value;
    }

    public ushort? serverport
    {
      get => this.serverportField;
      set => this.serverportField = value;
    }

    public uint? authtimeout
    {
      get => this.authtimeoutField;
      set => this.authtimeoutField = value;
    }

    public string ldapbase
    {
      get => this.ldapbaseField;
      set => this.ldapbaseField = value;
    }

    public string ldapbinddn
    {
      get => this.ldapbinddnField;
      set => this.ldapbinddnField = value;
    }

    public string ldapbinddnpassword
    {
      get => this.ldapbinddnpasswordField;
      set => this.ldapbinddnpasswordField = value;
    }

    public string ldaploginname
    {
      get => this.ldaploginnameField;
      set => this.ldaploginnameField = value;
    }

    public string searchfilter
    {
      get => this.searchfilterField;
      set => this.searchfilterField = value;
    }

    public string groupattrname
    {
      get => this.groupattrnameField;
      set => this.groupattrnameField = value;
    }

    public string subattributename
    {
      get => this.subattributenameField;
      set => this.subattributenameField = value;
    }

    public string sectype
    {
      get => this.sectypeField;
      set => this.sectypeField = value;
    }

    public string svrtype
    {
      get => this.svrtypeField;
      set => this.svrtypeField = value;
    }

    public string ssonameattribute
    {
      get => this.ssonameattributeField;
      set => this.ssonameattributeField = value;
    }

    public string authentication
    {
      get => this.authenticationField;
      set => this.authenticationField = value;
    }

    public string requireuser
    {
      get => this.requireuserField;
      set => this.requireuserField = value;
    }

    public string passwdchange
    {
      get => this.passwdchangeField;
      set => this.passwdchangeField = value;
    }

    public string nestedgroupextraction
    {
      get => this.nestedgroupextractionField;
      set => this.nestedgroupextractionField = value;
    }

    public uint? maxnestinglevel
    {
      get => this.maxnestinglevelField;
      set => this.maxnestinglevelField = value;
    }

    public string followreferrals
    {
      get => this.followreferralsField;
      set => this.followreferralsField = value;
    }

    public uint? maxldapreferrals
    {
      get => this.maxldapreferralsField;
      set => this.maxldapreferralsField = value;
    }

    public string referraldnslookup
    {
      get => this.referraldnslookupField;
      set => this.referraldnslookupField = value;
    }

    public string mssrvrecordlocation
    {
      get => this.mssrvrecordlocationField;
      set => this.mssrvrecordlocationField = value;
    }

    public string validateservercert
    {
      get => this.validateservercertField;
      set => this.validateservercertField = value;
    }

    public string ldaphostname
    {
      get => this.ldaphostnameField;
      set => this.ldaphostnameField = value;
    }

    public string groupnameidentifier
    {
      get => this.groupnameidentifierField;
      set => this.groupnameidentifierField = value;
    }

    public string groupsearchattribute
    {
      get => this.groupsearchattributeField;
      set => this.groupsearchattributeField = value;
    }

    public string groupsearchsubattribute
    {
      get => this.groupsearchsubattributeField;
      set => this.groupsearchsubattributeField = value;
    }

    public string groupsearchfilter
    {
      get => this.groupsearchfilterField;
      set => this.groupsearchfilterField = value;
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

    public long? success
    {
      get => this.successField;
      private set => this.successField = value;
    }

    public long? failure
    {
      get => this.failureField;
      private set => this.failureField = value;
    }

    internal override base_resource[] get_nitro_response(
      nitro_service service,
      string response)
    {
      authenticationldapaction.authenticationldapaction_response authenticationldapactionResponse = new authenticationldapaction.authenticationldapaction_response();
      authenticationldapaction.authenticationldapaction_response resource = (authenticationldapaction.authenticationldapaction_response) service.get_payload_formatter().string_to_resource(authenticationldapactionResponse.GetType(), response);
      if (resource.errorcode != 0)
      {
        if (resource.errorcode == 444)
          service.clear_session();
        if (resource.severity == null)
          throw new nitro_exception(resource.message, resource.errorcode);
        if (resource.severity.Equals("ERROR"))
          throw new nitro_exception(resource.message, resource.errorcode);
      }
      return (base_resource[]) resource.authenticationldapaction;
    }

    internal override string get_object_name() => this.name;

    public static base_response add(
      nitro_service client,
      authenticationldapaction resource)
    {
      return new authenticationldapaction()
      {
        name = resource.name,
        serverip = resource.serverip,
        servername = resource.servername,
        serverport = resource.serverport,
        authtimeout = resource.authtimeout,
        ldapbase = resource.ldapbase,
        ldapbinddn = resource.ldapbinddn,
        ldapbinddnpassword = resource.ldapbinddnpassword,
        ldaploginname = resource.ldaploginname,
        searchfilter = resource.searchfilter,
        groupattrname = resource.groupattrname,
        subattributename = resource.subattributename,
        sectype = resource.sectype,
        svrtype = resource.svrtype,
        ssonameattribute = resource.ssonameattribute,
        authentication = resource.authentication,
        requireuser = resource.requireuser,
        passwdchange = resource.passwdchange,
        nestedgroupextraction = resource.nestedgroupextraction,
        maxnestinglevel = resource.maxnestinglevel,
        followreferrals = resource.followreferrals,
        maxldapreferrals = resource.maxldapreferrals,
        referraldnslookup = resource.referraldnslookup,
        mssrvrecordlocation = resource.mssrvrecordlocation,
        validateservercert = resource.validateservercert,
        ldaphostname = resource.ldaphostname,
        groupnameidentifier = resource.groupnameidentifier,
        groupsearchattribute = resource.groupsearchattribute,
        groupsearchsubattribute = resource.groupsearchsubattribute,
        groupsearchfilter = resource.groupsearchfilter,
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
        attribute16 = resource.attribute16
      }.add_resource(client);
    }

    public static base_responses add(
      nitro_service client,
      authenticationldapaction[] resources)
    {
      base_responses baseResponses = (base_responses) null;
      if (resources != null && resources.Length > 0)
      {
        authenticationldapaction[] authenticationldapactionArray = new authenticationldapaction[resources.Length];
        for (int index = 0; index < resources.Length; ++index)
        {
          authenticationldapactionArray[index] = new authenticationldapaction();
          authenticationldapactionArray[index].name = resources[index].name;
          authenticationldapactionArray[index].serverip = resources[index].serverip;
          authenticationldapactionArray[index].servername = resources[index].servername;
          authenticationldapactionArray[index].serverport = resources[index].serverport;
          authenticationldapactionArray[index].authtimeout = resources[index].authtimeout;
          authenticationldapactionArray[index].ldapbase = resources[index].ldapbase;
          authenticationldapactionArray[index].ldapbinddn = resources[index].ldapbinddn;
          authenticationldapactionArray[index].ldapbinddnpassword = resources[index].ldapbinddnpassword;
          authenticationldapactionArray[index].ldaploginname = resources[index].ldaploginname;
          authenticationldapactionArray[index].searchfilter = resources[index].searchfilter;
          authenticationldapactionArray[index].groupattrname = resources[index].groupattrname;
          authenticationldapactionArray[index].subattributename = resources[index].subattributename;
          authenticationldapactionArray[index].sectype = resources[index].sectype;
          authenticationldapactionArray[index].svrtype = resources[index].svrtype;
          authenticationldapactionArray[index].ssonameattribute = resources[index].ssonameattribute;
          authenticationldapactionArray[index].authentication = resources[index].authentication;
          authenticationldapactionArray[index].requireuser = resources[index].requireuser;
          authenticationldapactionArray[index].passwdchange = resources[index].passwdchange;
          authenticationldapactionArray[index].nestedgroupextraction = resources[index].nestedgroupextraction;
          authenticationldapactionArray[index].maxnestinglevel = resources[index].maxnestinglevel;
          authenticationldapactionArray[index].followreferrals = resources[index].followreferrals;
          authenticationldapactionArray[index].maxldapreferrals = resources[index].maxldapreferrals;
          authenticationldapactionArray[index].referraldnslookup = resources[index].referraldnslookup;
          authenticationldapactionArray[index].mssrvrecordlocation = resources[index].mssrvrecordlocation;
          authenticationldapactionArray[index].validateservercert = resources[index].validateservercert;
          authenticationldapactionArray[index].ldaphostname = resources[index].ldaphostname;
          authenticationldapactionArray[index].groupnameidentifier = resources[index].groupnameidentifier;
          authenticationldapactionArray[index].groupsearchattribute = resources[index].groupsearchattribute;
          authenticationldapactionArray[index].groupsearchsubattribute = resources[index].groupsearchsubattribute;
          authenticationldapactionArray[index].groupsearchfilter = resources[index].groupsearchfilter;
          authenticationldapactionArray[index].defaultauthenticationgroup = resources[index].defaultauthenticationgroup;
          authenticationldapactionArray[index].attribute1 = resources[index].attribute1;
          authenticationldapactionArray[index].attribute2 = resources[index].attribute2;
          authenticationldapactionArray[index].attribute3 = resources[index].attribute3;
          authenticationldapactionArray[index].attribute4 = resources[index].attribute4;
          authenticationldapactionArray[index].attribute5 = resources[index].attribute5;
          authenticationldapactionArray[index].attribute6 = resources[index].attribute6;
          authenticationldapactionArray[index].attribute7 = resources[index].attribute7;
          authenticationldapactionArray[index].attribute8 = resources[index].attribute8;
          authenticationldapactionArray[index].attribute9 = resources[index].attribute9;
          authenticationldapactionArray[index].attribute10 = resources[index].attribute10;
          authenticationldapactionArray[index].attribute11 = resources[index].attribute11;
          authenticationldapactionArray[index].attribute12 = resources[index].attribute12;
          authenticationldapactionArray[index].attribute13 = resources[index].attribute13;
          authenticationldapactionArray[index].attribute14 = resources[index].attribute14;
          authenticationldapactionArray[index].attribute15 = resources[index].attribute15;
          authenticationldapactionArray[index].attribute16 = resources[index].attribute16;
        }
        baseResponses = base_resource.add_bulk_request(client, (base_resource[]) authenticationldapactionArray);
      }
      return baseResponses;
    }

    public static base_response delete(nitro_service client, string name) => new authenticationldapaction()
    {
      name = name
    }.delete_resource(client);

    public static base_response delete(
      nitro_service client,
      authenticationldapaction resource)
    {
      return new authenticationldapaction()
      {
        name = resource.name
      }.delete_resource(client);
    }

    public static base_responses delete(nitro_service client, string[] name)
    {
      base_responses baseResponses = (base_responses) null;
      if (name != null && name.Length > 0)
      {
        authenticationldapaction[] authenticationldapactionArray = new authenticationldapaction[name.Length];
        for (int index = 0; index < name.Length; ++index)
        {
          authenticationldapactionArray[index] = new authenticationldapaction();
          authenticationldapactionArray[index].name = name[index];
        }
        baseResponses = base_resource.delete_bulk_request(client, (base_resource[]) authenticationldapactionArray);
      }
      return baseResponses;
    }

    public static base_responses delete(
      nitro_service client,
      authenticationldapaction[] resources)
    {
      base_responses baseResponses = (base_responses) null;
      if (resources != null && resources.Length > 0)
      {
        authenticationldapaction[] authenticationldapactionArray = new authenticationldapaction[resources.Length];
        for (int index = 0; index < resources.Length; ++index)
        {
          authenticationldapactionArray[index] = new authenticationldapaction();
          authenticationldapactionArray[index].name = resources[index].name;
        }
        baseResponses = base_resource.delete_bulk_request(client, (base_resource[]) authenticationldapactionArray);
      }
      return baseResponses;
    }

    public static base_response update(
      nitro_service client,
      authenticationldapaction resource)
    {
      return new authenticationldapaction()
      {
        name = resource.name,
        serverip = resource.serverip,
        servername = resource.servername,
        serverport = resource.serverport,
        authtimeout = resource.authtimeout,
        ldapbase = resource.ldapbase,
        ldapbinddn = resource.ldapbinddn,
        ldapbinddnpassword = resource.ldapbinddnpassword,
        ldaploginname = resource.ldaploginname,
        searchfilter = resource.searchfilter,
        groupattrname = resource.groupattrname,
        subattributename = resource.subattributename,
        sectype = resource.sectype,
        svrtype = resource.svrtype,
        ssonameattribute = resource.ssonameattribute,
        authentication = resource.authentication,
        requireuser = resource.requireuser,
        passwdchange = resource.passwdchange,
        validateservercert = resource.validateservercert,
        ldaphostname = resource.ldaphostname,
        nestedgroupextraction = resource.nestedgroupextraction,
        maxnestinglevel = resource.maxnestinglevel,
        groupnameidentifier = resource.groupnameidentifier,
        groupsearchattribute = resource.groupsearchattribute,
        groupsearchsubattribute = resource.groupsearchsubattribute,
        groupsearchfilter = resource.groupsearchfilter,
        followreferrals = resource.followreferrals,
        maxldapreferrals = resource.maxldapreferrals,
        referraldnslookup = resource.referraldnslookup,
        mssrvrecordlocation = resource.mssrvrecordlocation,
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
        attribute16 = resource.attribute16
      }.update_resource(client);
    }

    public static base_responses update(
      nitro_service client,
      authenticationldapaction[] resources)
    {
      base_responses baseResponses = (base_responses) null;
      if (resources != null && resources.Length > 0)
      {
        authenticationldapaction[] authenticationldapactionArray = new authenticationldapaction[resources.Length];
        for (int index = 0; index < resources.Length; ++index)
        {
          authenticationldapactionArray[index] = new authenticationldapaction();
          authenticationldapactionArray[index].name = resources[index].name;
          authenticationldapactionArray[index].serverip = resources[index].serverip;
          authenticationldapactionArray[index].servername = resources[index].servername;
          authenticationldapactionArray[index].serverport = resources[index].serverport;
          authenticationldapactionArray[index].authtimeout = resources[index].authtimeout;
          authenticationldapactionArray[index].ldapbase = resources[index].ldapbase;
          authenticationldapactionArray[index].ldapbinddn = resources[index].ldapbinddn;
          authenticationldapactionArray[index].ldapbinddnpassword = resources[index].ldapbinddnpassword;
          authenticationldapactionArray[index].ldaploginname = resources[index].ldaploginname;
          authenticationldapactionArray[index].searchfilter = resources[index].searchfilter;
          authenticationldapactionArray[index].groupattrname = resources[index].groupattrname;
          authenticationldapactionArray[index].subattributename = resources[index].subattributename;
          authenticationldapactionArray[index].sectype = resources[index].sectype;
          authenticationldapactionArray[index].svrtype = resources[index].svrtype;
          authenticationldapactionArray[index].ssonameattribute = resources[index].ssonameattribute;
          authenticationldapactionArray[index].authentication = resources[index].authentication;
          authenticationldapactionArray[index].requireuser = resources[index].requireuser;
          authenticationldapactionArray[index].passwdchange = resources[index].passwdchange;
          authenticationldapactionArray[index].validateservercert = resources[index].validateservercert;
          authenticationldapactionArray[index].ldaphostname = resources[index].ldaphostname;
          authenticationldapactionArray[index].nestedgroupextraction = resources[index].nestedgroupextraction;
          authenticationldapactionArray[index].maxnestinglevel = resources[index].maxnestinglevel;
          authenticationldapactionArray[index].groupnameidentifier = resources[index].groupnameidentifier;
          authenticationldapactionArray[index].groupsearchattribute = resources[index].groupsearchattribute;
          authenticationldapactionArray[index].groupsearchsubattribute = resources[index].groupsearchsubattribute;
          authenticationldapactionArray[index].groupsearchfilter = resources[index].groupsearchfilter;
          authenticationldapactionArray[index].followreferrals = resources[index].followreferrals;
          authenticationldapactionArray[index].maxldapreferrals = resources[index].maxldapreferrals;
          authenticationldapactionArray[index].referraldnslookup = resources[index].referraldnslookup;
          authenticationldapactionArray[index].mssrvrecordlocation = resources[index].mssrvrecordlocation;
          authenticationldapactionArray[index].defaultauthenticationgroup = resources[index].defaultauthenticationgroup;
          authenticationldapactionArray[index].attribute1 = resources[index].attribute1;
          authenticationldapactionArray[index].attribute2 = resources[index].attribute2;
          authenticationldapactionArray[index].attribute3 = resources[index].attribute3;
          authenticationldapactionArray[index].attribute4 = resources[index].attribute4;
          authenticationldapactionArray[index].attribute5 = resources[index].attribute5;
          authenticationldapactionArray[index].attribute6 = resources[index].attribute6;
          authenticationldapactionArray[index].attribute7 = resources[index].attribute7;
          authenticationldapactionArray[index].attribute8 = resources[index].attribute8;
          authenticationldapactionArray[index].attribute9 = resources[index].attribute9;
          authenticationldapactionArray[index].attribute10 = resources[index].attribute10;
          authenticationldapactionArray[index].attribute11 = resources[index].attribute11;
          authenticationldapactionArray[index].attribute12 = resources[index].attribute12;
          authenticationldapactionArray[index].attribute13 = resources[index].attribute13;
          authenticationldapactionArray[index].attribute14 = resources[index].attribute14;
          authenticationldapactionArray[index].attribute15 = resources[index].attribute15;
          authenticationldapactionArray[index].attribute16 = resources[index].attribute16;
        }
        baseResponses = base_resource.update_bulk_request(client, (base_resource[]) authenticationldapactionArray);
      }
      return baseResponses;
    }

    public static base_response unset(
      nitro_service client,
      string name,
      string[] args)
    {
      return new authenticationldapaction() { name = name }.unset_resource(client, args);
    }

    public static base_response unset(
      nitro_service client,
      authenticationldapaction resource,
      string[] args)
    {
      return new authenticationldapaction()
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
        authenticationldapaction[] authenticationldapactionArray = new authenticationldapaction[name.Length];
        for (int index = 0; index < name.Length; ++index)
        {
          authenticationldapactionArray[index] = new authenticationldapaction();
          authenticationldapactionArray[index].name = name[index];
        }
        baseResponses = base_resource.unset_bulk_request(client, (base_resource[]) authenticationldapactionArray, args);
      }
      return baseResponses;
    }

    public static base_responses unset(
      nitro_service client,
      authenticationldapaction[] resources,
      string[] args)
    {
      base_responses baseResponses = (base_responses) null;
      if (resources != null && resources.Length > 0)
      {
        authenticationldapaction[] authenticationldapactionArray = new authenticationldapaction[resources.Length];
        for (int index = 0; index < resources.Length; ++index)
        {
          authenticationldapactionArray[index] = new authenticationldapaction();
          authenticationldapactionArray[index].name = resources[index].name;
        }
        baseResponses = base_resource.unset_bulk_request(client, (base_resource[]) authenticationldapactionArray, args);
      }
      return baseResponses;
    }

    public static authenticationldapaction[] get(nitro_service service) => (authenticationldapaction[]) new authenticationldapaction().get_resources(service, (options) null);

    public static authenticationldapaction[] get(
      nitro_service service,
      options option)
    {
      return (authenticationldapaction[]) new authenticationldapaction().get_resources(service, option);
    }

    public static authenticationldapaction get(
      nitro_service service,
      string name)
    {
      return (authenticationldapaction) new authenticationldapaction()
      {
        name = name
      }.get_resource(service);
    }

    public static authenticationldapaction[] get(
      nitro_service service,
      string[] name)
    {
      if (name == null || name.Length <= 0)
        return (authenticationldapaction[]) null;
      authenticationldapaction[] authenticationldapactionArray1 = new authenticationldapaction[name.Length];
      authenticationldapaction[] authenticationldapactionArray2 = new authenticationldapaction[name.Length];
      for (int index = 0; index < name.Length; ++index)
      {
        authenticationldapactionArray2[index] = new authenticationldapaction();
        authenticationldapactionArray2[index].name = name[index];
        authenticationldapactionArray1[index] = (authenticationldapaction) authenticationldapactionArray2[index].get_resource(service);
      }
      return authenticationldapactionArray1;
    }

    public static authenticationldapaction[] get_filtered(
      nitro_service service,
      string filter)
    {
      authenticationldapaction authenticationldapaction = new authenticationldapaction();
      options option = new options();
      option.set_filter(filter);
      return (authenticationldapaction[]) authenticationldapaction.getfiltered(service, option);
    }

    public static authenticationldapaction[] get_filtered(
      nitro_service service,
      filtervalue[] filter)
    {
      authenticationldapaction authenticationldapaction = new authenticationldapaction();
      options option = new options();
      option.set_filter(filter);
      return (authenticationldapaction[]) authenticationldapaction.getfiltered(service, option);
    }

    public static uint count(nitro_service service)
    {
      authenticationldapaction authenticationldapaction = new authenticationldapaction();
      options option = new options();
      option.set_count(true);
      authenticationldapaction[] resources = (authenticationldapaction[]) authenticationldapaction.get_resources(service, option);
      return resources != null && resources.Length > 0 ? resources[0].__count.Value : 0U;
    }

    public static uint count_filtered(nitro_service service, string filter)
    {
      authenticationldapaction authenticationldapaction = new authenticationldapaction();
      options option = new options();
      option.set_count(true);
      option.set_filter(filter);
      authenticationldapaction[] authenticationldapactionArray = (authenticationldapaction[]) authenticationldapaction.getfiltered(service, option);
      return authenticationldapactionArray != null && authenticationldapactionArray.Length > 0 ? authenticationldapactionArray[0].__count.Value : 0U;
    }

    public static uint count_filtered(nitro_service service, filtervalue[] filter)
    {
      authenticationldapaction authenticationldapaction = new authenticationldapaction();
      options option = new options();
      option.set_count(true);
      option.set_filter(filter);
      authenticationldapaction[] authenticationldapactionArray = (authenticationldapaction[]) authenticationldapaction.getfiltered(service, option);
      return authenticationldapactionArray != null && authenticationldapactionArray.Length > 0 ? authenticationldapactionArray[0].__count.Value : 0U;
    }

    private class authenticationldapaction_response : base_response
    {
      public authenticationldapaction[] authenticationldapaction = (authenticationldapaction[]) null;
    }

    public static class passwdchangeEnum
    {
      public const string ENABLED = "ENABLED";
      public const string DISABLED = "DISABLED";
    }

    public static class sectypeEnum
    {
      public const string PLAINTEXT = "PLAINTEXT";
      public const string TLS = "TLS";
      public const string SSL = "SSL";
    }

    public static class authenticationEnum
    {
      public const string ENABLED = "ENABLED";
      public const string DISABLED = "DISABLED";
    }

    public static class requireuserEnum
    {
      public const string YES = "YES";
      public const string NO = "NO";
    }

    public static class validateservercertEnum
    {
      public const string YES = "YES";
      public const string NO = "NO";
    }

    public static class followreferralsEnum
    {
      public const string ON = "ON";
      public const string OFF = "OFF";
    }

    public static class referraldnslookupEnum
    {
      public const string A_REC = "A-REC";
      public const string SRV_REC = "SRV-REC";
      public const string MSSRV_REC = "MSSRV-REC";
    }

    public static class svrtypeEnum
    {
      public const string AD = "AD";
      public const string NDS = "NDS";
    }

    public static class nestedgroupextractionEnum
    {
      public const string ON = "ON";
      public const string OFF = "OFF";
    }
  }
}
