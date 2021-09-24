// Decompiled with JetBrains decompiler
// Type: com.citrix.netscaler.nitro.resource.config.tm.tmtrafficaction
// Assembly: nitro, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 6CF5DDEF-E052-4F9D-953F-6644F8378A66


using com.citrix.netscaler.nitro.exception;
using com.citrix.netscaler.nitro.resource.Base;
using com.citrix.netscaler.nitro.service;
using com.citrix.netscaler.nitro.util;

namespace com.citrix.netscaler.nitro.resource.config.tm
{
  public class tmtrafficaction : base_resource
  {
    private string nameField = (string) null;
    private uint? apptimeoutField = new uint?();
    private string ssoField = (string) null;
    private string formssoactionField = (string) null;
    private string persistentcookieField = (string) null;
    private string initiatelogoutField = (string) null;
    private string kcdaccountField = (string) null;
    private string samlssoprofileField = (string) null;
    private string forcedtimeoutField = (string) null;
    private uint? forcedtimeoutvalField = new uint?();
    private string userexpressionField = (string) null;
    private string passwdexpressionField = (string) null;
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

    public uint? apptimeout
    {
      get => this.apptimeoutField;
      set => this.apptimeoutField = value;
    }

    public string sso
    {
      get => this.ssoField;
      set => this.ssoField = value;
    }

    public string formssoaction
    {
      get => this.formssoactionField;
      set => this.formssoactionField = value;
    }

    public string persistentcookie
    {
      get => this.persistentcookieField;
      set => this.persistentcookieField = value;
    }

    public string initiatelogout
    {
      get => this.initiatelogoutField;
      set => this.initiatelogoutField = value;
    }

    public string kcdaccount
    {
      get => this.kcdaccountField;
      set => this.kcdaccountField = value;
    }

    public string samlssoprofile
    {
      get => this.samlssoprofileField;
      set => this.samlssoprofileField = value;
    }

    public string forcedtimeout
    {
      get => this.forcedtimeoutField;
      set => this.forcedtimeoutField = value;
    }

    public uint? forcedtimeoutval
    {
      get => this.forcedtimeoutvalField;
      set => this.forcedtimeoutvalField = value;
    }

    public string userexpression
    {
      get => this.userexpressionField;
      set => this.userexpressionField = value;
    }

    public string passwdexpression
    {
      get => this.passwdexpressionField;
      set => this.passwdexpressionField = value;
    }

    internal override base_resource[] get_nitro_response(
      nitro_service service,
      string response)
    {
      tmtrafficaction.tmtrafficaction_response tmtrafficactionResponse = new tmtrafficaction.tmtrafficaction_response();
      tmtrafficaction.tmtrafficaction_response resource = (tmtrafficaction.tmtrafficaction_response) service.get_payload_formatter().string_to_resource(tmtrafficactionResponse.GetType(), response);
      if (resource.errorcode != 0)
      {
        if (resource.errorcode == 444)
          service.clear_session();
        if (resource.severity == null)
          throw new nitro_exception(resource.message, resource.errorcode);
        if (resource.severity.Equals("ERROR"))
          throw new nitro_exception(resource.message, resource.errorcode);
      }
      return (base_resource[]) resource.tmtrafficaction;
    }

    internal override string get_object_name() => this.name;

    public static base_response add(nitro_service client, tmtrafficaction resource) => new tmtrafficaction()
    {
      name = resource.name,
      apptimeout = resource.apptimeout,
      sso = resource.sso,
      formssoaction = resource.formssoaction,
      persistentcookie = resource.persistentcookie,
      initiatelogout = resource.initiatelogout,
      kcdaccount = resource.kcdaccount,
      samlssoprofile = resource.samlssoprofile,
      forcedtimeout = resource.forcedtimeout,
      forcedtimeoutval = resource.forcedtimeoutval,
      userexpression = resource.userexpression,
      passwdexpression = resource.passwdexpression
    }.add_resource(client);

    public static base_responses add(
      nitro_service client,
      tmtrafficaction[] resources)
    {
      base_responses baseResponses = (base_responses) null;
      if (resources != null && resources.Length > 0)
      {
        tmtrafficaction[] tmtrafficactionArray = new tmtrafficaction[resources.Length];
        for (int index = 0; index < resources.Length; ++index)
        {
          tmtrafficactionArray[index] = new tmtrafficaction();
          tmtrafficactionArray[index].name = resources[index].name;
          tmtrafficactionArray[index].apptimeout = resources[index].apptimeout;
          tmtrafficactionArray[index].sso = resources[index].sso;
          tmtrafficactionArray[index].formssoaction = resources[index].formssoaction;
          tmtrafficactionArray[index].persistentcookie = resources[index].persistentcookie;
          tmtrafficactionArray[index].initiatelogout = resources[index].initiatelogout;
          tmtrafficactionArray[index].kcdaccount = resources[index].kcdaccount;
          tmtrafficactionArray[index].samlssoprofile = resources[index].samlssoprofile;
          tmtrafficactionArray[index].forcedtimeout = resources[index].forcedtimeout;
          tmtrafficactionArray[index].forcedtimeoutval = resources[index].forcedtimeoutval;
          tmtrafficactionArray[index].userexpression = resources[index].userexpression;
          tmtrafficactionArray[index].passwdexpression = resources[index].passwdexpression;
        }
        baseResponses = base_resource.add_bulk_request(client, (base_resource[]) tmtrafficactionArray);
      }
      return baseResponses;
    }

    public static base_response delete(nitro_service client, string name) => new tmtrafficaction()
    {
      name = name
    }.delete_resource(client);

    public static base_response delete(nitro_service client, tmtrafficaction resource) => new tmtrafficaction()
    {
      name = resource.name
    }.delete_resource(client);

    public static base_responses delete(nitro_service client, string[] name)
    {
      base_responses baseResponses = (base_responses) null;
      if (name != null && name.Length > 0)
      {
        tmtrafficaction[] tmtrafficactionArray = new tmtrafficaction[name.Length];
        for (int index = 0; index < name.Length; ++index)
        {
          tmtrafficactionArray[index] = new tmtrafficaction();
          tmtrafficactionArray[index].name = name[index];
        }
        baseResponses = base_resource.delete_bulk_request(client, (base_resource[]) tmtrafficactionArray);
      }
      return baseResponses;
    }

    public static base_responses delete(
      nitro_service client,
      tmtrafficaction[] resources)
    {
      base_responses baseResponses = (base_responses) null;
      if (resources != null && resources.Length > 0)
      {
        tmtrafficaction[] tmtrafficactionArray = new tmtrafficaction[resources.Length];
        for (int index = 0; index < resources.Length; ++index)
        {
          tmtrafficactionArray[index] = new tmtrafficaction();
          tmtrafficactionArray[index].name = resources[index].name;
        }
        baseResponses = base_resource.delete_bulk_request(client, (base_resource[]) tmtrafficactionArray);
      }
      return baseResponses;
    }

    public static base_response update(nitro_service client, tmtrafficaction resource) => new tmtrafficaction()
    {
      name = resource.name,
      apptimeout = resource.apptimeout,
      sso = resource.sso,
      formssoaction = resource.formssoaction,
      persistentcookie = resource.persistentcookie,
      initiatelogout = resource.initiatelogout,
      kcdaccount = resource.kcdaccount,
      samlssoprofile = resource.samlssoprofile,
      forcedtimeout = resource.forcedtimeout,
      forcedtimeoutval = resource.forcedtimeoutval,
      userexpression = resource.userexpression,
      passwdexpression = resource.passwdexpression
    }.update_resource(client);

    public static base_responses update(
      nitro_service client,
      tmtrafficaction[] resources)
    {
      base_responses baseResponses = (base_responses) null;
      if (resources != null && resources.Length > 0)
      {
        tmtrafficaction[] tmtrafficactionArray = new tmtrafficaction[resources.Length];
        for (int index = 0; index < resources.Length; ++index)
        {
          tmtrafficactionArray[index] = new tmtrafficaction();
          tmtrafficactionArray[index].name = resources[index].name;
          tmtrafficactionArray[index].apptimeout = resources[index].apptimeout;
          tmtrafficactionArray[index].sso = resources[index].sso;
          tmtrafficactionArray[index].formssoaction = resources[index].formssoaction;
          tmtrafficactionArray[index].persistentcookie = resources[index].persistentcookie;
          tmtrafficactionArray[index].initiatelogout = resources[index].initiatelogout;
          tmtrafficactionArray[index].kcdaccount = resources[index].kcdaccount;
          tmtrafficactionArray[index].samlssoprofile = resources[index].samlssoprofile;
          tmtrafficactionArray[index].forcedtimeout = resources[index].forcedtimeout;
          tmtrafficactionArray[index].forcedtimeoutval = resources[index].forcedtimeoutval;
          tmtrafficactionArray[index].userexpression = resources[index].userexpression;
          tmtrafficactionArray[index].passwdexpression = resources[index].passwdexpression;
        }
        baseResponses = base_resource.update_bulk_request(client, (base_resource[]) tmtrafficactionArray);
      }
      return baseResponses;
    }

    public static base_response unset(
      nitro_service client,
      string name,
      string[] args)
    {
      return new tmtrafficaction() { name = name }.unset_resource(client, args);
    }

    public static base_response unset(
      nitro_service client,
      tmtrafficaction resource,
      string[] args)
    {
      return new tmtrafficaction() { name = resource.name }.unset_resource(client, args);
    }

    public static base_responses unset(
      nitro_service client,
      string[] name,
      string[] args)
    {
      base_responses baseResponses = (base_responses) null;
      if (name != null && name.Length > 0)
      {
        tmtrafficaction[] tmtrafficactionArray = new tmtrafficaction[name.Length];
        for (int index = 0; index < name.Length; ++index)
        {
          tmtrafficactionArray[index] = new tmtrafficaction();
          tmtrafficactionArray[index].name = name[index];
        }
        baseResponses = base_resource.unset_bulk_request(client, (base_resource[]) tmtrafficactionArray, args);
      }
      return baseResponses;
    }

    public static base_responses unset(
      nitro_service client,
      tmtrafficaction[] resources,
      string[] args)
    {
      base_responses baseResponses = (base_responses) null;
      if (resources != null && resources.Length > 0)
      {
        tmtrafficaction[] tmtrafficactionArray = new tmtrafficaction[resources.Length];
        for (int index = 0; index < resources.Length; ++index)
        {
          tmtrafficactionArray[index] = new tmtrafficaction();
          tmtrafficactionArray[index].name = resources[index].name;
        }
        baseResponses = base_resource.unset_bulk_request(client, (base_resource[]) tmtrafficactionArray, args);
      }
      return baseResponses;
    }

    public static tmtrafficaction[] get(nitro_service service) => (tmtrafficaction[]) new tmtrafficaction().get_resources(service, (options) null);

    public static tmtrafficaction[] get(nitro_service service, options option) => (tmtrafficaction[]) new tmtrafficaction().get_resources(service, option);

    public static tmtrafficaction get(nitro_service service, string name) => (tmtrafficaction) new tmtrafficaction()
    {
      name = name
    }.get_resource(service);

    public static tmtrafficaction[] get(nitro_service service, string[] name)
    {
      if (name == null || name.Length <= 0)
        return (tmtrafficaction[]) null;
      tmtrafficaction[] tmtrafficactionArray1 = new tmtrafficaction[name.Length];
      tmtrafficaction[] tmtrafficactionArray2 = new tmtrafficaction[name.Length];
      for (int index = 0; index < name.Length; ++index)
      {
        tmtrafficactionArray2[index] = new tmtrafficaction();
        tmtrafficactionArray2[index].name = name[index];
        tmtrafficactionArray1[index] = (tmtrafficaction) tmtrafficactionArray2[index].get_resource(service);
      }
      return tmtrafficactionArray1;
    }

    public static tmtrafficaction[] get_filtered(
      nitro_service service,
      string filter)
    {
      tmtrafficaction tmtrafficaction = new tmtrafficaction();
      options option = new options();
      option.set_filter(filter);
      return (tmtrafficaction[]) tmtrafficaction.getfiltered(service, option);
    }

    public static tmtrafficaction[] get_filtered(
      nitro_service service,
      filtervalue[] filter)
    {
      tmtrafficaction tmtrafficaction = new tmtrafficaction();
      options option = new options();
      option.set_filter(filter);
      return (tmtrafficaction[]) tmtrafficaction.getfiltered(service, option);
    }

    public static uint count(nitro_service service)
    {
      tmtrafficaction tmtrafficaction = new tmtrafficaction();
      options option = new options();
      option.set_count(true);
      tmtrafficaction[] resources = (tmtrafficaction[]) tmtrafficaction.get_resources(service, option);
      return resources != null && resources.Length > 0 ? resources[0].__count.Value : 0U;
    }

    public static uint count_filtered(nitro_service service, string filter)
    {
      tmtrafficaction tmtrafficaction = new tmtrafficaction();
      options option = new options();
      option.set_count(true);
      option.set_filter(filter);
      tmtrafficaction[] tmtrafficactionArray = (tmtrafficaction[]) tmtrafficaction.getfiltered(service, option);
      return tmtrafficactionArray != null && tmtrafficactionArray.Length > 0 ? tmtrafficactionArray[0].__count.Value : 0U;
    }

    public static uint count_filtered(nitro_service service, filtervalue[] filter)
    {
      tmtrafficaction tmtrafficaction = new tmtrafficaction();
      options option = new options();
      option.set_count(true);
      option.set_filter(filter);
      tmtrafficaction[] tmtrafficactionArray = (tmtrafficaction[]) tmtrafficaction.getfiltered(service, option);
      return tmtrafficactionArray != null && tmtrafficactionArray.Length > 0 ? tmtrafficactionArray[0].__count.Value : 0U;
    }

    private class tmtrafficaction_response : base_response
    {
      public tmtrafficaction[] tmtrafficaction = (tmtrafficaction[]) null;
    }

    public static class persistentcookieEnum
    {
      public const string ON = "ON";
      public const string OFF = "OFF";
    }

    public static class forcedtimeoutEnum
    {
      public const string START = "START";
      public const string STOP = "STOP";
      public const string RESET = "RESET";
    }

    public static class initiatelogoutEnum
    {
      public const string ON = "ON";
      public const string OFF = "OFF";
    }

    public static class ssoEnum
    {
      public const string ON = "ON";
      public const string OFF = "OFF";
    }
  }
}
