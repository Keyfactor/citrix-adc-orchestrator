// Decompiled with JetBrains decompiler
// Type: com.citrix.netscaler.nitro.resource.config.db.dbdbprofile
// Assembly: nitro, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 6CF5DDEF-E052-4F9D-953F-6644F8378A66


using com.citrix.netscaler.nitro.exception;
using com.citrix.netscaler.nitro.resource.Base;
using com.citrix.netscaler.nitro.service;
using com.citrix.netscaler.nitro.util;

namespace com.citrix.netscaler.nitro.resource.config.db
{
  public class dbdbprofile : base_resource
  {
    private string nameField = (string) null;
    private string interpretqueryField = (string) null;
    private string stickinessField = (string) null;
    private string kcdaccountField = (string) null;
    private string conmultiplexField = (string) null;
    private string enablecachingconmuxoffField = (string) null;
    private uint? refcntField = new uint?();
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

    public string interpretquery
    {
      get => this.interpretqueryField;
      set => this.interpretqueryField = value;
    }

    public string stickiness
    {
      get => this.stickinessField;
      set => this.stickinessField = value;
    }

    public string kcdaccount
    {
      get => this.kcdaccountField;
      set => this.kcdaccountField = value;
    }

    public string conmultiplex
    {
      get => this.conmultiplexField;
      set => this.conmultiplexField = value;
    }

    public string enablecachingconmuxoff
    {
      get => this.enablecachingconmuxoffField;
      set => this.enablecachingconmuxoffField = value;
    }

    public uint? refcnt
    {
      get => this.refcntField;
      private set => this.refcntField = value;
    }

    internal override base_resource[] get_nitro_response(
      nitro_service service,
      string response)
    {
      dbdbprofile.dbdbprofile_response dbdbprofileResponse = new dbdbprofile.dbdbprofile_response();
      dbdbprofile.dbdbprofile_response resource = (dbdbprofile.dbdbprofile_response) service.get_payload_formatter().string_to_resource(dbdbprofileResponse.GetType(), response);
      if (resource.errorcode != 0)
      {
        if (resource.errorcode == 444)
          service.clear_session();
        if (resource.severity == null)
          throw new nitro_exception(resource.message, resource.errorcode);
        if (resource.severity.Equals("ERROR"))
          throw new nitro_exception(resource.message, resource.errorcode);
      }
      return (base_resource[]) resource.dbdbprofile;
    }

    internal override string get_object_name() => this.name;

    public static base_response add(nitro_service client, dbdbprofile resource) => new dbdbprofile()
    {
      name = resource.name,
      interpretquery = resource.interpretquery,
      stickiness = resource.stickiness,
      kcdaccount = resource.kcdaccount,
      conmultiplex = resource.conmultiplex,
      enablecachingconmuxoff = resource.enablecachingconmuxoff
    }.add_resource(client);

    public static base_responses add(nitro_service client, dbdbprofile[] resources)
    {
      base_responses baseResponses = (base_responses) null;
      if (resources != null && resources.Length > 0)
      {
        dbdbprofile[] dbdbprofileArray = new dbdbprofile[resources.Length];
        for (int index = 0; index < resources.Length; ++index)
        {
          dbdbprofileArray[index] = new dbdbprofile();
          dbdbprofileArray[index].name = resources[index].name;
          dbdbprofileArray[index].interpretquery = resources[index].interpretquery;
          dbdbprofileArray[index].stickiness = resources[index].stickiness;
          dbdbprofileArray[index].kcdaccount = resources[index].kcdaccount;
          dbdbprofileArray[index].conmultiplex = resources[index].conmultiplex;
          dbdbprofileArray[index].enablecachingconmuxoff = resources[index].enablecachingconmuxoff;
        }
        baseResponses = base_resource.add_bulk_request(client, (base_resource[]) dbdbprofileArray);
      }
      return baseResponses;
    }

    public static base_response delete(nitro_service client, string name) => new dbdbprofile()
    {
      name = name
    }.delete_resource(client);

    public static base_response delete(nitro_service client, dbdbprofile resource) => new dbdbprofile()
    {
      name = resource.name
    }.delete_resource(client);

    public static base_responses delete(nitro_service client, string[] name)
    {
      base_responses baseResponses = (base_responses) null;
      if (name != null && name.Length > 0)
      {
        dbdbprofile[] dbdbprofileArray = new dbdbprofile[name.Length];
        for (int index = 0; index < name.Length; ++index)
        {
          dbdbprofileArray[index] = new dbdbprofile();
          dbdbprofileArray[index].name = name[index];
        }
        baseResponses = base_resource.delete_bulk_request(client, (base_resource[]) dbdbprofileArray);
      }
      return baseResponses;
    }

    public static base_responses delete(nitro_service client, dbdbprofile[] resources)
    {
      base_responses baseResponses = (base_responses) null;
      if (resources != null && resources.Length > 0)
      {
        dbdbprofile[] dbdbprofileArray = new dbdbprofile[resources.Length];
        for (int index = 0; index < resources.Length; ++index)
        {
          dbdbprofileArray[index] = new dbdbprofile();
          dbdbprofileArray[index].name = resources[index].name;
        }
        baseResponses = base_resource.delete_bulk_request(client, (base_resource[]) dbdbprofileArray);
      }
      return baseResponses;
    }

    public static base_response update(nitro_service client, dbdbprofile resource) => new dbdbprofile()
    {
      name = resource.name,
      interpretquery = resource.interpretquery,
      stickiness = resource.stickiness,
      kcdaccount = resource.kcdaccount,
      conmultiplex = resource.conmultiplex,
      enablecachingconmuxoff = resource.enablecachingconmuxoff
    }.update_resource(client);

    public static base_responses update(nitro_service client, dbdbprofile[] resources)
    {
      base_responses baseResponses = (base_responses) null;
      if (resources != null && resources.Length > 0)
      {
        dbdbprofile[] dbdbprofileArray = new dbdbprofile[resources.Length];
        for (int index = 0; index < resources.Length; ++index)
        {
          dbdbprofileArray[index] = new dbdbprofile();
          dbdbprofileArray[index].name = resources[index].name;
          dbdbprofileArray[index].interpretquery = resources[index].interpretquery;
          dbdbprofileArray[index].stickiness = resources[index].stickiness;
          dbdbprofileArray[index].kcdaccount = resources[index].kcdaccount;
          dbdbprofileArray[index].conmultiplex = resources[index].conmultiplex;
          dbdbprofileArray[index].enablecachingconmuxoff = resources[index].enablecachingconmuxoff;
        }
        baseResponses = base_resource.update_bulk_request(client, (base_resource[]) dbdbprofileArray);
      }
      return baseResponses;
    }

    public static base_response unset(
      nitro_service client,
      string name,
      string[] args)
    {
      return new dbdbprofile() { name = name }.unset_resource(client, args);
    }

    public static base_response unset(
      nitro_service client,
      dbdbprofile resource,
      string[] args)
    {
      return new dbdbprofile() { name = resource.name }.unset_resource(client, args);
    }

    public static base_responses unset(
      nitro_service client,
      string[] name,
      string[] args)
    {
      base_responses baseResponses = (base_responses) null;
      if (name != null && name.Length > 0)
      {
        dbdbprofile[] dbdbprofileArray = new dbdbprofile[name.Length];
        for (int index = 0; index < name.Length; ++index)
        {
          dbdbprofileArray[index] = new dbdbprofile();
          dbdbprofileArray[index].name = name[index];
        }
        baseResponses = base_resource.unset_bulk_request(client, (base_resource[]) dbdbprofileArray, args);
      }
      return baseResponses;
    }

    public static base_responses unset(
      nitro_service client,
      dbdbprofile[] resources,
      string[] args)
    {
      base_responses baseResponses = (base_responses) null;
      if (resources != null && resources.Length > 0)
      {
        dbdbprofile[] dbdbprofileArray = new dbdbprofile[resources.Length];
        for (int index = 0; index < resources.Length; ++index)
        {
          dbdbprofileArray[index] = new dbdbprofile();
          dbdbprofileArray[index].name = resources[index].name;
        }
        baseResponses = base_resource.unset_bulk_request(client, (base_resource[]) dbdbprofileArray, args);
      }
      return baseResponses;
    }

    public static dbdbprofile[] get(nitro_service service) => (dbdbprofile[]) new dbdbprofile().get_resources(service, (options) null);

    public static dbdbprofile[] get(nitro_service service, options option) => (dbdbprofile[]) new dbdbprofile().get_resources(service, option);

    public static dbdbprofile get(nitro_service service, string name) => (dbdbprofile) new dbdbprofile()
    {
      name = name
    }.get_resource(service);

    public static dbdbprofile[] get(nitro_service service, string[] name)
    {
      if (name == null || name.Length <= 0)
        return (dbdbprofile[]) null;
      dbdbprofile[] dbdbprofileArray1 = new dbdbprofile[name.Length];
      dbdbprofile[] dbdbprofileArray2 = new dbdbprofile[name.Length];
      for (int index = 0; index < name.Length; ++index)
      {
        dbdbprofileArray2[index] = new dbdbprofile();
        dbdbprofileArray2[index].name = name[index];
        dbdbprofileArray1[index] = (dbdbprofile) dbdbprofileArray2[index].get_resource(service);
      }
      return dbdbprofileArray1;
    }

    public static dbdbprofile[] get_filtered(nitro_service service, string filter)
    {
      dbdbprofile dbdbprofile = new dbdbprofile();
      options option = new options();
      option.set_filter(filter);
      return (dbdbprofile[]) dbdbprofile.getfiltered(service, option);
    }

    public static dbdbprofile[] get_filtered(nitro_service service, filtervalue[] filter)
    {
      dbdbprofile dbdbprofile = new dbdbprofile();
      options option = new options();
      option.set_filter(filter);
      return (dbdbprofile[]) dbdbprofile.getfiltered(service, option);
    }

    public static uint count(nitro_service service)
    {
      dbdbprofile dbdbprofile = new dbdbprofile();
      options option = new options();
      option.set_count(true);
      dbdbprofile[] resources = (dbdbprofile[]) dbdbprofile.get_resources(service, option);
      return resources != null && resources.Length > 0 ? resources[0].__count.Value : 0U;
    }

    public static uint count_filtered(nitro_service service, string filter)
    {
      dbdbprofile dbdbprofile = new dbdbprofile();
      options option = new options();
      option.set_count(true);
      option.set_filter(filter);
      dbdbprofile[] dbdbprofileArray = (dbdbprofile[]) dbdbprofile.getfiltered(service, option);
      return dbdbprofileArray != null && dbdbprofileArray.Length > 0 ? dbdbprofileArray[0].__count.Value : 0U;
    }

    public static uint count_filtered(nitro_service service, filtervalue[] filter)
    {
      dbdbprofile dbdbprofile = new dbdbprofile();
      options option = new options();
      option.set_count(true);
      option.set_filter(filter);
      dbdbprofile[] dbdbprofileArray = (dbdbprofile[]) dbdbprofile.getfiltered(service, option);
      return dbdbprofileArray != null && dbdbprofileArray.Length > 0 ? dbdbprofileArray[0].__count.Value : 0U;
    }

    private class dbdbprofile_response : base_response
    {
      public dbdbprofile[] dbdbprofile = (dbdbprofile[]) null;
    }

    public static class conmultiplexEnum
    {
      public const string ENABLED = "ENABLED";
      public const string DISABLED = "DISABLED";
    }

    public static class enablecachingconmuxoffEnum
    {
      public const string ENABLED = "ENABLED";
      public const string DISABLED = "DISABLED";
    }

    public static class stickinessEnum
    {
      public const string YES = "YES";
      public const string NO = "NO";
    }

    public static class interpretqueryEnum
    {
      public const string YES = "YES";
      public const string NO = "NO";
    }
  }
}
