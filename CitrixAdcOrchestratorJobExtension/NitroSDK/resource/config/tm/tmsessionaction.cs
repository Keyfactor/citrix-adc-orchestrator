// Decompiled with JetBrains decompiler
// Type: com.citrix.netscaler.nitro.resource.config.tm.tmsessionaction
// Assembly: nitro, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 6CF5DDEF-E052-4F9D-953F-6644F8378A66


using com.citrix.netscaler.nitro.exception;
using com.citrix.netscaler.nitro.resource.Base;
using com.citrix.netscaler.nitro.service;
using com.citrix.netscaler.nitro.util;

namespace com.citrix.netscaler.nitro.resource.config.tm
{
  public class tmsessionaction : base_resource
  {
    private string nameField = (string) null;
    private uint? sesstimeoutField = new uint?();
    private string defaultauthorizationactionField = (string) null;
    private string ssoField = (string) null;
    private string ssocredentialField = (string) null;
    private string ssodomainField = (string) null;
    private string httponlycookieField = (string) null;
    private string kcdaccountField = (string) null;
    private string persistentcookieField = (string) null;
    private uint? persistentcookievalidityField = new uint?();
    private string homepageField = (string) null;
    private string[] builtinField = (string[]) null;
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

    public uint? sesstimeout
    {
      get => this.sesstimeoutField;
      set => this.sesstimeoutField = value;
    }

    public string defaultauthorizationaction
    {
      get => this.defaultauthorizationactionField;
      set => this.defaultauthorizationactionField = value;
    }

    public string sso
    {
      get => this.ssoField;
      set => this.ssoField = value;
    }

    public string ssocredential
    {
      get => this.ssocredentialField;
      set => this.ssocredentialField = value;
    }

    public string ssodomain
    {
      get => this.ssodomainField;
      set => this.ssodomainField = value;
    }

    public string httponlycookie
    {
      get => this.httponlycookieField;
      set => this.httponlycookieField = value;
    }

    public string kcdaccount
    {
      get => this.kcdaccountField;
      set => this.kcdaccountField = value;
    }

    public string persistentcookie
    {
      get => this.persistentcookieField;
      set => this.persistentcookieField = value;
    }

    public uint? persistentcookievalidity
    {
      get => this.persistentcookievalidityField;
      set => this.persistentcookievalidityField = value;
    }

    public string homepage
    {
      get => this.homepageField;
      set => this.homepageField = value;
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
      tmsessionaction.tmsessionaction_response tmsessionactionResponse = new tmsessionaction.tmsessionaction_response();
      tmsessionaction.tmsessionaction_response resource = (tmsessionaction.tmsessionaction_response) service.get_payload_formatter().string_to_resource(tmsessionactionResponse.GetType(), response);
      if (resource.errorcode != 0)
      {
        if (resource.errorcode == 444)
          service.clear_session();
        if (resource.severity == null)
          throw new nitro_exception(resource.message, resource.errorcode);
        if (resource.severity.Equals("ERROR"))
          throw new nitro_exception(resource.message, resource.errorcode);
      }
      return (base_resource[]) resource.tmsessionaction;
    }

    internal override string get_object_name() => this.name;

    public static base_response add(nitro_service client, tmsessionaction resource) => new tmsessionaction()
    {
      name = resource.name,
      sesstimeout = resource.sesstimeout,
      defaultauthorizationaction = resource.defaultauthorizationaction,
      sso = resource.sso,
      ssocredential = resource.ssocredential,
      ssodomain = resource.ssodomain,
      httponlycookie = resource.httponlycookie,
      kcdaccount = resource.kcdaccount,
      persistentcookie = resource.persistentcookie,
      persistentcookievalidity = resource.persistentcookievalidity,
      homepage = resource.homepage
    }.add_resource(client);

    public static base_responses add(
      nitro_service client,
      tmsessionaction[] resources)
    {
      base_responses baseResponses = (base_responses) null;
      if (resources != null && resources.Length > 0)
      {
        tmsessionaction[] tmsessionactionArray = new tmsessionaction[resources.Length];
        for (int index = 0; index < resources.Length; ++index)
        {
          tmsessionactionArray[index] = new tmsessionaction();
          tmsessionactionArray[index].name = resources[index].name;
          tmsessionactionArray[index].sesstimeout = resources[index].sesstimeout;
          tmsessionactionArray[index].defaultauthorizationaction = resources[index].defaultauthorizationaction;
          tmsessionactionArray[index].sso = resources[index].sso;
          tmsessionactionArray[index].ssocredential = resources[index].ssocredential;
          tmsessionactionArray[index].ssodomain = resources[index].ssodomain;
          tmsessionactionArray[index].httponlycookie = resources[index].httponlycookie;
          tmsessionactionArray[index].kcdaccount = resources[index].kcdaccount;
          tmsessionactionArray[index].persistentcookie = resources[index].persistentcookie;
          tmsessionactionArray[index].persistentcookievalidity = resources[index].persistentcookievalidity;
          tmsessionactionArray[index].homepage = resources[index].homepage;
        }
        baseResponses = base_resource.add_bulk_request(client, (base_resource[]) tmsessionactionArray);
      }
      return baseResponses;
    }

    public static base_response delete(nitro_service client, string name) => new tmsessionaction()
    {
      name = name
    }.delete_resource(client);

    public static base_response delete(nitro_service client, tmsessionaction resource) => new tmsessionaction()
    {
      name = resource.name
    }.delete_resource(client);

    public static base_responses delete(nitro_service client, string[] name)
    {
      base_responses baseResponses = (base_responses) null;
      if (name != null && name.Length > 0)
      {
        tmsessionaction[] tmsessionactionArray = new tmsessionaction[name.Length];
        for (int index = 0; index < name.Length; ++index)
        {
          tmsessionactionArray[index] = new tmsessionaction();
          tmsessionactionArray[index].name = name[index];
        }
        baseResponses = base_resource.delete_bulk_request(client, (base_resource[]) tmsessionactionArray);
      }
      return baseResponses;
    }

    public static base_responses delete(
      nitro_service client,
      tmsessionaction[] resources)
    {
      base_responses baseResponses = (base_responses) null;
      if (resources != null && resources.Length > 0)
      {
        tmsessionaction[] tmsessionactionArray = new tmsessionaction[resources.Length];
        for (int index = 0; index < resources.Length; ++index)
        {
          tmsessionactionArray[index] = new tmsessionaction();
          tmsessionactionArray[index].name = resources[index].name;
        }
        baseResponses = base_resource.delete_bulk_request(client, (base_resource[]) tmsessionactionArray);
      }
      return baseResponses;
    }

    public static base_response update(nitro_service client, tmsessionaction resource) => new tmsessionaction()
    {
      name = resource.name,
      sesstimeout = resource.sesstimeout,
      defaultauthorizationaction = resource.defaultauthorizationaction,
      sso = resource.sso,
      ssocredential = resource.ssocredential,
      ssodomain = resource.ssodomain,
      kcdaccount = resource.kcdaccount,
      httponlycookie = resource.httponlycookie,
      persistentcookie = resource.persistentcookie,
      persistentcookievalidity = resource.persistentcookievalidity,
      homepage = resource.homepage
    }.update_resource(client);

    public static base_responses update(
      nitro_service client,
      tmsessionaction[] resources)
    {
      base_responses baseResponses = (base_responses) null;
      if (resources != null && resources.Length > 0)
      {
        tmsessionaction[] tmsessionactionArray = new tmsessionaction[resources.Length];
        for (int index = 0; index < resources.Length; ++index)
        {
          tmsessionactionArray[index] = new tmsessionaction();
          tmsessionactionArray[index].name = resources[index].name;
          tmsessionactionArray[index].sesstimeout = resources[index].sesstimeout;
          tmsessionactionArray[index].defaultauthorizationaction = resources[index].defaultauthorizationaction;
          tmsessionactionArray[index].sso = resources[index].sso;
          tmsessionactionArray[index].ssocredential = resources[index].ssocredential;
          tmsessionactionArray[index].ssodomain = resources[index].ssodomain;
          tmsessionactionArray[index].kcdaccount = resources[index].kcdaccount;
          tmsessionactionArray[index].httponlycookie = resources[index].httponlycookie;
          tmsessionactionArray[index].persistentcookie = resources[index].persistentcookie;
          tmsessionactionArray[index].persistentcookievalidity = resources[index].persistentcookievalidity;
          tmsessionactionArray[index].homepage = resources[index].homepage;
        }
        baseResponses = base_resource.update_bulk_request(client, (base_resource[]) tmsessionactionArray);
      }
      return baseResponses;
    }

    public static base_response unset(
      nitro_service client,
      string name,
      string[] args)
    {
      return new tmsessionaction() { name = name }.unset_resource(client, args);
    }

    public static base_response unset(
      nitro_service client,
      tmsessionaction resource,
      string[] args)
    {
      return new tmsessionaction() { name = resource.name }.unset_resource(client, args);
    }

    public static base_responses unset(
      nitro_service client,
      string[] name,
      string[] args)
    {
      base_responses baseResponses = (base_responses) null;
      if (name != null && name.Length > 0)
      {
        tmsessionaction[] tmsessionactionArray = new tmsessionaction[name.Length];
        for (int index = 0; index < name.Length; ++index)
        {
          tmsessionactionArray[index] = new tmsessionaction();
          tmsessionactionArray[index].name = name[index];
        }
        baseResponses = base_resource.unset_bulk_request(client, (base_resource[]) tmsessionactionArray, args);
      }
      return baseResponses;
    }

    public static base_responses unset(
      nitro_service client,
      tmsessionaction[] resources,
      string[] args)
    {
      base_responses baseResponses = (base_responses) null;
      if (resources != null && resources.Length > 0)
      {
        tmsessionaction[] tmsessionactionArray = new tmsessionaction[resources.Length];
        for (int index = 0; index < resources.Length; ++index)
        {
          tmsessionactionArray[index] = new tmsessionaction();
          tmsessionactionArray[index].name = resources[index].name;
        }
        baseResponses = base_resource.unset_bulk_request(client, (base_resource[]) tmsessionactionArray, args);
      }
      return baseResponses;
    }

    public static tmsessionaction[] get(nitro_service service) => (tmsessionaction[]) new tmsessionaction().get_resources(service, (options) null);

    public static tmsessionaction[] get(nitro_service service, options option) => (tmsessionaction[]) new tmsessionaction().get_resources(service, option);

    public static tmsessionaction get(nitro_service service, string name) => (tmsessionaction) new tmsessionaction()
    {
      name = name
    }.get_resource(service);

    public static tmsessionaction[] get(nitro_service service, string[] name)
    {
      if (name == null || name.Length <= 0)
        return (tmsessionaction[]) null;
      tmsessionaction[] tmsessionactionArray1 = new tmsessionaction[name.Length];
      tmsessionaction[] tmsessionactionArray2 = new tmsessionaction[name.Length];
      for (int index = 0; index < name.Length; ++index)
      {
        tmsessionactionArray2[index] = new tmsessionaction();
        tmsessionactionArray2[index].name = name[index];
        tmsessionactionArray1[index] = (tmsessionaction) tmsessionactionArray2[index].get_resource(service);
      }
      return tmsessionactionArray1;
    }

    public static tmsessionaction[] get_filtered(
      nitro_service service,
      string filter)
    {
      tmsessionaction tmsessionaction = new tmsessionaction();
      options option = new options();
      option.set_filter(filter);
      return (tmsessionaction[]) tmsessionaction.getfiltered(service, option);
    }

    public static tmsessionaction[] get_filtered(
      nitro_service service,
      filtervalue[] filter)
    {
      tmsessionaction tmsessionaction = new tmsessionaction();
      options option = new options();
      option.set_filter(filter);
      return (tmsessionaction[]) tmsessionaction.getfiltered(service, option);
    }

    public static uint count(nitro_service service)
    {
      tmsessionaction tmsessionaction = new tmsessionaction();
      options option = new options();
      option.set_count(true);
      tmsessionaction[] resources = (tmsessionaction[]) tmsessionaction.get_resources(service, option);
      return resources != null && resources.Length > 0 ? resources[0].__count.Value : 0U;
    }

    public static uint count_filtered(nitro_service service, string filter)
    {
      tmsessionaction tmsessionaction = new tmsessionaction();
      options option = new options();
      option.set_count(true);
      option.set_filter(filter);
      tmsessionaction[] tmsessionactionArray = (tmsessionaction[]) tmsessionaction.getfiltered(service, option);
      return tmsessionactionArray != null && tmsessionactionArray.Length > 0 ? tmsessionactionArray[0].__count.Value : 0U;
    }

    public static uint count_filtered(nitro_service service, filtervalue[] filter)
    {
      tmsessionaction tmsessionaction = new tmsessionaction();
      options option = new options();
      option.set_count(true);
      option.set_filter(filter);
      tmsessionaction[] tmsessionactionArray = (tmsessionaction[]) tmsessionaction.getfiltered(service, option);
      return tmsessionactionArray != null && tmsessionactionArray.Length > 0 ? tmsessionactionArray[0].__count.Value : 0U;
    }

    private class tmsessionaction_response : base_response
    {
      public tmsessionaction[] tmsessionaction = (tmsessionaction[]) null;
    }

    public static class persistentcookieEnum
    {
      public const string ON = "ON";
      public const string OFF = "OFF";
    }

    public static class builtinEnum
    {
      public const string MODIFIABLE = "MODIFIABLE";
      public const string DELETABLE = "DELETABLE";
      public const string IMMUTABLE = "IMMUTABLE";
      public const string PARTITION_ALL = "PARTITION_ALL";
    }

    public static class httponlycookieEnum
    {
      public const string YES = "YES";
      public const string NO = "NO";
    }

    public static class defaultauthorizationactionEnum
    {
      public const string ALLOW = "ALLOW";
      public const string DENY = "DENY";
    }

    public static class ssocredentialEnum
    {
      public const string PRIMARY = "PRIMARY";
      public const string SECONDARY = "SECONDARY";
    }

    public static class ssoEnum
    {
      public const string ON = "ON";
      public const string OFF = "OFF";
    }
  }
}
