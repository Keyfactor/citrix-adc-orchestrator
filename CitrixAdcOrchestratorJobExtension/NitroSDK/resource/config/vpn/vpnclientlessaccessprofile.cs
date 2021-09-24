// Decompiled with JetBrains decompiler
// Type: com.citrix.netscaler.nitro.resource.config.vpn.vpnclientlessaccessprofile
// Assembly: nitro, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 6CF5DDEF-E052-4F9D-953F-6644F8378A66


using com.citrix.netscaler.nitro.exception;
using com.citrix.netscaler.nitro.resource.Base;
using com.citrix.netscaler.nitro.service;
using com.citrix.netscaler.nitro.util;

namespace com.citrix.netscaler.nitro.resource.config.vpn
{
  public class vpnclientlessaccessprofile : base_resource
  {
    private string profilenameField = (string) null;
    private string urlrewritepolicylabelField = (string) null;
    private string javascriptrewritepolicylabelField = (string) null;
    private string reqhdrrewritepolicylabelField = (string) null;
    private string reshdrrewritepolicylabelField = (string) null;
    private string regexforfindingurlinjavascriptField = (string) null;
    private string regexforfindingurlincssField = (string) null;
    private string regexforfindingurlinxcomponentField = (string) null;
    private string regexforfindingurlinxmlField = (string) null;
    private string regexforfindingcustomurlsField = (string) null;
    private string clientconsumedcookiesField = (string) null;
    private string requirepersistentcookieField = (string) null;
    private string cssrewritepolicylabelField = (string) null;
    private string xmlrewritepolicylabelField = (string) null;
    private string xcomponentrewritepolicylabelField = (string) null;
    private bool? isdefaultField = new bool?();
    private string descriptionField = (string) null;
    private string[] builtinField = (string[]) null;
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

    public string urlrewritepolicylabel
    {
      get => this.urlrewritepolicylabelField;
      set => this.urlrewritepolicylabelField = value;
    }

    public string javascriptrewritepolicylabel
    {
      get => this.javascriptrewritepolicylabelField;
      set => this.javascriptrewritepolicylabelField = value;
    }

    public string reqhdrrewritepolicylabel
    {
      get => this.reqhdrrewritepolicylabelField;
      set => this.reqhdrrewritepolicylabelField = value;
    }

    public string reshdrrewritepolicylabel
    {
      get => this.reshdrrewritepolicylabelField;
      set => this.reshdrrewritepolicylabelField = value;
    }

    public string regexforfindingurlinjavascript
    {
      get => this.regexforfindingurlinjavascriptField;
      set => this.regexforfindingurlinjavascriptField = value;
    }

    public string regexforfindingurlincss
    {
      get => this.regexforfindingurlincssField;
      set => this.regexforfindingurlincssField = value;
    }

    public string regexforfindingurlinxcomponent
    {
      get => this.regexforfindingurlinxcomponentField;
      set => this.regexforfindingurlinxcomponentField = value;
    }

    public string regexforfindingurlinxml
    {
      get => this.regexforfindingurlinxmlField;
      set => this.regexforfindingurlinxmlField = value;
    }

    public string regexforfindingcustomurls
    {
      get => this.regexforfindingcustomurlsField;
      set => this.regexforfindingcustomurlsField = value;
    }

    public string clientconsumedcookies
    {
      get => this.clientconsumedcookiesField;
      set => this.clientconsumedcookiesField = value;
    }

    public string requirepersistentcookie
    {
      get => this.requirepersistentcookieField;
      set => this.requirepersistentcookieField = value;
    }

    public string cssrewritepolicylabel
    {
      get => this.cssrewritepolicylabelField;
      private set => this.cssrewritepolicylabelField = value;
    }

    public string xmlrewritepolicylabel
    {
      get => this.xmlrewritepolicylabelField;
      private set => this.xmlrewritepolicylabelField = value;
    }

    public string xcomponentrewritepolicylabel
    {
      get => this.xcomponentrewritepolicylabelField;
      private set => this.xcomponentrewritepolicylabelField = value;
    }

    public bool? isdefault
    {
      get => this.isdefaultField;
      private set => this.isdefaultField = value;
    }

    public string description
    {
      get => this.descriptionField;
      private set => this.descriptionField = value;
    }

    public string[] builtin
    {
      get => this.builtinField;
      private set => this.builtinField = value;
    }

    internal override base_resource[] get_nitro_response(
      nitro_service service,
      string response)
    {
      vpnclientlessaccessprofile.vpnclientlessaccessprofile_response vpnclientlessaccessprofileResponse = new vpnclientlessaccessprofile.vpnclientlessaccessprofile_response();
      vpnclientlessaccessprofile.vpnclientlessaccessprofile_response resource = (vpnclientlessaccessprofile.vpnclientlessaccessprofile_response) service.get_payload_formatter().string_to_resource(vpnclientlessaccessprofileResponse.GetType(), response);
      if (resource.errorcode != 0)
      {
        if (resource.errorcode == 444)
          service.clear_session();
        if (resource.severity == null)
          throw new nitro_exception(resource.message, resource.errorcode);
        if (resource.severity.Equals("ERROR"))
          throw new nitro_exception(resource.message, resource.errorcode);
      }
      return (base_resource[]) resource.vpnclientlessaccessprofile;
    }

    internal override string get_object_name() => this.profilename;

    public static base_response add(
      nitro_service client,
      vpnclientlessaccessprofile resource)
    {
      return new vpnclientlessaccessprofile()
      {
        profilename = resource.profilename
      }.add_resource(client);
    }

    public static base_responses add(
      nitro_service client,
      vpnclientlessaccessprofile[] resources)
    {
      base_responses baseResponses = (base_responses) null;
      if (resources != null && resources.Length > 0)
      {
        vpnclientlessaccessprofile[] vpnclientlessaccessprofileArray = new vpnclientlessaccessprofile[resources.Length];
        for (int index = 0; index < resources.Length; ++index)
        {
          vpnclientlessaccessprofileArray[index] = new vpnclientlessaccessprofile();
          vpnclientlessaccessprofileArray[index].profilename = resources[index].profilename;
        }
        baseResponses = base_resource.add_bulk_request(client, (base_resource[]) vpnclientlessaccessprofileArray);
      }
      return baseResponses;
    }

    public static base_response delete(nitro_service client, string profilename) => new vpnclientlessaccessprofile()
    {
      profilename = profilename
    }.delete_resource(client);

    public static base_response delete(
      nitro_service client,
      vpnclientlessaccessprofile resource)
    {
      return new vpnclientlessaccessprofile()
      {
        profilename = resource.profilename
      }.delete_resource(client);
    }

    public static base_responses delete(nitro_service client, string[] profilename)
    {
      base_responses baseResponses = (base_responses) null;
      if (profilename != null && profilename.Length > 0)
      {
        vpnclientlessaccessprofile[] vpnclientlessaccessprofileArray = new vpnclientlessaccessprofile[profilename.Length];
        for (int index = 0; index < profilename.Length; ++index)
        {
          vpnclientlessaccessprofileArray[index] = new vpnclientlessaccessprofile();
          vpnclientlessaccessprofileArray[index].profilename = profilename[index];
        }
        baseResponses = base_resource.delete_bulk_request(client, (base_resource[]) vpnclientlessaccessprofileArray);
      }
      return baseResponses;
    }

    public static base_responses delete(
      nitro_service client,
      vpnclientlessaccessprofile[] resources)
    {
      base_responses baseResponses = (base_responses) null;
      if (resources != null && resources.Length > 0)
      {
        vpnclientlessaccessprofile[] vpnclientlessaccessprofileArray = new vpnclientlessaccessprofile[resources.Length];
        for (int index = 0; index < resources.Length; ++index)
        {
          vpnclientlessaccessprofileArray[index] = new vpnclientlessaccessprofile();
          vpnclientlessaccessprofileArray[index].profilename = resources[index].profilename;
        }
        baseResponses = base_resource.delete_bulk_request(client, (base_resource[]) vpnclientlessaccessprofileArray);
      }
      return baseResponses;
    }

    public static base_response update(
      nitro_service client,
      vpnclientlessaccessprofile resource)
    {
      return new vpnclientlessaccessprofile()
      {
        profilename = resource.profilename,
        urlrewritepolicylabel = resource.urlrewritepolicylabel,
        javascriptrewritepolicylabel = resource.javascriptrewritepolicylabel,
        reqhdrrewritepolicylabel = resource.reqhdrrewritepolicylabel,
        reshdrrewritepolicylabel = resource.reshdrrewritepolicylabel,
        regexforfindingurlinjavascript = resource.regexforfindingurlinjavascript,
        regexforfindingurlincss = resource.regexforfindingurlincss,
        regexforfindingurlinxcomponent = resource.regexforfindingurlinxcomponent,
        regexforfindingurlinxml = resource.regexforfindingurlinxml,
        regexforfindingcustomurls = resource.regexforfindingcustomurls,
        clientconsumedcookies = resource.clientconsumedcookies,
        requirepersistentcookie = resource.requirepersistentcookie
      }.update_resource(client);
    }

    public static base_responses update(
      nitro_service client,
      vpnclientlessaccessprofile[] resources)
    {
      base_responses baseResponses = (base_responses) null;
      if (resources != null && resources.Length > 0)
      {
        vpnclientlessaccessprofile[] vpnclientlessaccessprofileArray = new vpnclientlessaccessprofile[resources.Length];
        for (int index = 0; index < resources.Length; ++index)
        {
          vpnclientlessaccessprofileArray[index] = new vpnclientlessaccessprofile();
          vpnclientlessaccessprofileArray[index].profilename = resources[index].profilename;
          vpnclientlessaccessprofileArray[index].urlrewritepolicylabel = resources[index].urlrewritepolicylabel;
          vpnclientlessaccessprofileArray[index].javascriptrewritepolicylabel = resources[index].javascriptrewritepolicylabel;
          vpnclientlessaccessprofileArray[index].reqhdrrewritepolicylabel = resources[index].reqhdrrewritepolicylabel;
          vpnclientlessaccessprofileArray[index].reshdrrewritepolicylabel = resources[index].reshdrrewritepolicylabel;
          vpnclientlessaccessprofileArray[index].regexforfindingurlinjavascript = resources[index].regexforfindingurlinjavascript;
          vpnclientlessaccessprofileArray[index].regexforfindingurlincss = resources[index].regexforfindingurlincss;
          vpnclientlessaccessprofileArray[index].regexforfindingurlinxcomponent = resources[index].regexforfindingurlinxcomponent;
          vpnclientlessaccessprofileArray[index].regexforfindingurlinxml = resources[index].regexforfindingurlinxml;
          vpnclientlessaccessprofileArray[index].regexforfindingcustomurls = resources[index].regexforfindingcustomurls;
          vpnclientlessaccessprofileArray[index].clientconsumedcookies = resources[index].clientconsumedcookies;
          vpnclientlessaccessprofileArray[index].requirepersistentcookie = resources[index].requirepersistentcookie;
        }
        baseResponses = base_resource.update_bulk_request(client, (base_resource[]) vpnclientlessaccessprofileArray);
      }
      return baseResponses;
    }

    public static base_response unset(
      nitro_service client,
      string profilename,
      string[] args)
    {
      return new vpnclientlessaccessprofile()
      {
        profilename = profilename
      }.unset_resource(client, args);
    }

    public static base_response unset(
      nitro_service client,
      vpnclientlessaccessprofile resource,
      string[] args)
    {
      return new vpnclientlessaccessprofile()
      {
        profilename = resource.profilename
      }.unset_resource(client, args);
    }

    public static base_responses unset(
      nitro_service client,
      string[] profilename,
      string[] args)
    {
      base_responses baseResponses = (base_responses) null;
      if (profilename != null && profilename.Length > 0)
      {
        vpnclientlessaccessprofile[] vpnclientlessaccessprofileArray = new vpnclientlessaccessprofile[profilename.Length];
        for (int index = 0; index < profilename.Length; ++index)
        {
          vpnclientlessaccessprofileArray[index] = new vpnclientlessaccessprofile();
          vpnclientlessaccessprofileArray[index].profilename = profilename[index];
        }
        baseResponses = base_resource.unset_bulk_request(client, (base_resource[]) vpnclientlessaccessprofileArray, args);
      }
      return baseResponses;
    }

    public static base_responses unset(
      nitro_service client,
      vpnclientlessaccessprofile[] resources,
      string[] args)
    {
      base_responses baseResponses = (base_responses) null;
      if (resources != null && resources.Length > 0)
      {
        vpnclientlessaccessprofile[] vpnclientlessaccessprofileArray = new vpnclientlessaccessprofile[resources.Length];
        for (int index = 0; index < resources.Length; ++index)
        {
          vpnclientlessaccessprofileArray[index] = new vpnclientlessaccessprofile();
          vpnclientlessaccessprofileArray[index].profilename = resources[index].profilename;
        }
        baseResponses = base_resource.unset_bulk_request(client, (base_resource[]) vpnclientlessaccessprofileArray, args);
      }
      return baseResponses;
    }

    public static vpnclientlessaccessprofile[] get(nitro_service service) => (vpnclientlessaccessprofile[]) new vpnclientlessaccessprofile().get_resources(service, (options) null);

    public static vpnclientlessaccessprofile[] get(
      nitro_service service,
      options option)
    {
      return (vpnclientlessaccessprofile[]) new vpnclientlessaccessprofile().get_resources(service, option);
    }

    public static vpnclientlessaccessprofile get(
      nitro_service service,
      string profilename)
    {
      return (vpnclientlessaccessprofile) new vpnclientlessaccessprofile()
      {
        profilename = profilename
      }.get_resource(service);
    }

    public static vpnclientlessaccessprofile[] get(
      nitro_service service,
      string[] profilename)
    {
      if (profilename == null || profilename.Length <= 0)
        return (vpnclientlessaccessprofile[]) null;
      vpnclientlessaccessprofile[] vpnclientlessaccessprofileArray1 = new vpnclientlessaccessprofile[profilename.Length];
      vpnclientlessaccessprofile[] vpnclientlessaccessprofileArray2 = new vpnclientlessaccessprofile[profilename.Length];
      for (int index = 0; index < profilename.Length; ++index)
      {
        vpnclientlessaccessprofileArray2[index] = new vpnclientlessaccessprofile();
        vpnclientlessaccessprofileArray2[index].profilename = profilename[index];
        vpnclientlessaccessprofileArray1[index] = (vpnclientlessaccessprofile) vpnclientlessaccessprofileArray2[index].get_resource(service);
      }
      return vpnclientlessaccessprofileArray1;
    }

    public static vpnclientlessaccessprofile[] get_filtered(
      nitro_service service,
      string filter)
    {
      vpnclientlessaccessprofile vpnclientlessaccessprofile = new vpnclientlessaccessprofile();
      options option = new options();
      option.set_filter(filter);
      return (vpnclientlessaccessprofile[]) vpnclientlessaccessprofile.getfiltered(service, option);
    }

    public static vpnclientlessaccessprofile[] get_filtered(
      nitro_service service,
      filtervalue[] filter)
    {
      vpnclientlessaccessprofile vpnclientlessaccessprofile = new vpnclientlessaccessprofile();
      options option = new options();
      option.set_filter(filter);
      return (vpnclientlessaccessprofile[]) vpnclientlessaccessprofile.getfiltered(service, option);
    }

    public static uint count(nitro_service service)
    {
      vpnclientlessaccessprofile vpnclientlessaccessprofile = new vpnclientlessaccessprofile();
      options option = new options();
      option.set_count(true);
      vpnclientlessaccessprofile[] resources = (vpnclientlessaccessprofile[]) vpnclientlessaccessprofile.get_resources(service, option);
      return resources != null && resources.Length > 0 ? resources[0].__count.Value : 0U;
    }

    public static uint count_filtered(nitro_service service, string filter)
    {
      vpnclientlessaccessprofile vpnclientlessaccessprofile = new vpnclientlessaccessprofile();
      options option = new options();
      option.set_count(true);
      option.set_filter(filter);
      vpnclientlessaccessprofile[] vpnclientlessaccessprofileArray = (vpnclientlessaccessprofile[]) vpnclientlessaccessprofile.getfiltered(service, option);
      return vpnclientlessaccessprofileArray != null && vpnclientlessaccessprofileArray.Length > 0 ? vpnclientlessaccessprofileArray[0].__count.Value : 0U;
    }

    public static uint count_filtered(nitro_service service, filtervalue[] filter)
    {
      vpnclientlessaccessprofile vpnclientlessaccessprofile = new vpnclientlessaccessprofile();
      options option = new options();
      option.set_count(true);
      option.set_filter(filter);
      vpnclientlessaccessprofile[] vpnclientlessaccessprofileArray = (vpnclientlessaccessprofile[]) vpnclientlessaccessprofile.getfiltered(service, option);
      return vpnclientlessaccessprofileArray != null && vpnclientlessaccessprofileArray.Length > 0 ? vpnclientlessaccessprofileArray[0].__count.Value : 0U;
    }

    private class vpnclientlessaccessprofile_response : base_response
    {
      public vpnclientlessaccessprofile[] vpnclientlessaccessprofile = (vpnclientlessaccessprofile[]) null;
    }

    public static class builtinEnum
    {
      public const string MODIFIABLE = "MODIFIABLE";
      public const string DELETABLE = "DELETABLE";
      public const string IMMUTABLE = "IMMUTABLE";
      public const string PARTITION_ALL = "PARTITION_ALL";
    }

    public static class requirepersistentcookieEnum
    {
      public const string ON = "ON";
      public const string OFF = "OFF";
    }
  }
}
