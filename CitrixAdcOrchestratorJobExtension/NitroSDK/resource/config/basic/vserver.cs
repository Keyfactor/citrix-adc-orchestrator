// Decompiled with JetBrains decompiler
// Type: com.citrix.netscaler.nitro.resource.config.basic.vserver
// Assembly: nitro, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 6CF5DDEF-E052-4F9D-953F-6644F8378A66


using com.citrix.netscaler.nitro.exception;
using com.citrix.netscaler.nitro.resource.Base;
using com.citrix.netscaler.nitro.service;

namespace com.citrix.netscaler.nitro.resource.config.basic
{
  public class vserver : base_resource
  {
    private string nameField = (string) null;
    private string backupvserverField = (string) null;
    private string redirecturlField = (string) null;
    private string cacheableField = (string) null;
    private long? clttimeoutField = new long?();
    private string somethodField = (string) null;
    private string sopersistenceField = (string) null;
    private uint? sopersistencetimeoutField = new uint?();
    private uint? sothresholdField = new uint?();
    private string pushvserverField = (string) null;

    public string name
    {
      get => this.nameField;
      set => this.nameField = value;
    }

    public string backupvserver
    {
      get => this.backupvserverField;
      set => this.backupvserverField = value;
    }

    public string redirecturl
    {
      get => this.redirecturlField;
      set => this.redirecturlField = value;
    }

    public string cacheable
    {
      get => this.cacheableField;
      set => this.cacheableField = value;
    }

    public long? clttimeout
    {
      get => this.clttimeoutField;
      set => this.clttimeoutField = value;
    }

    public string somethod
    {
      get => this.somethodField;
      set => this.somethodField = value;
    }

    public string sopersistence
    {
      get => this.sopersistenceField;
      set => this.sopersistenceField = value;
    }

    public uint? sopersistencetimeout
    {
      get => this.sopersistencetimeoutField;
      set => this.sopersistencetimeoutField = value;
    }

    public uint? sothreshold
    {
      get => this.sothresholdField;
      set => this.sothresholdField = value;
    }

    public string pushvserver
    {
      get => this.pushvserverField;
      set => this.pushvserverField = value;
    }

    internal override base_resource[] get_nitro_response(
      nitro_service service,
      string response)
    {
      vserver[] vserverArray = new vserver[1];
      vserver.vserver_response vserverResponse = new vserver.vserver_response();
      vserver.vserver_response resource = (vserver.vserver_response) service.get_payload_formatter().string_to_resource(vserverResponse.GetType(), response);
      if (resource.errorcode != 0)
      {
        if (resource.errorcode == 444)
          service.clear_session();
        if (resource.severity == null)
          throw new nitro_exception(resource.message, resource.errorcode);
        if (resource.severity.Equals("ERROR"))
          throw new nitro_exception(resource.message, resource.errorcode);
      }
      vserverArray[0] = resource.vserver;
      return (base_resource[]) vserverArray;
    }

    internal override string get_object_name() => this.name;

    public static base_response delete(nitro_service client, string name) => new vserver()
    {
      name = name
    }.delete_resource(client);

    public static base_response delete(nitro_service client, vserver resource) => new vserver()
    {
      name = resource.name
    }.delete_resource(client);

    public static base_response update(nitro_service client, vserver resource) => new vserver()
    {
      name = resource.name,
      backupvserver = resource.backupvserver,
      redirecturl = resource.redirecturl,
      cacheable = resource.cacheable,
      clttimeout = resource.clttimeout,
      somethod = resource.somethod,
      sopersistence = resource.sopersistence,
      sopersistencetimeout = resource.sopersistencetimeout,
      sothreshold = resource.sothreshold,
      pushvserver = resource.pushvserver
    }.update_resource(client);

    public static base_response enable(nitro_service client, string name) => new vserver()
    {
      name = name
    }.perform_operation_byaction(client, nameof (enable));

    public static base_response enable(nitro_service client, vserver resource) => new vserver()
    {
      name = resource.name
    }.perform_operation_byaction(client, nameof (enable));

    public static base_response disable(nitro_service client, string name) => new vserver()
    {
      name = name
    }.perform_operation_byaction(client, nameof (disable));

    public static base_response disable(nitro_service client, vserver resource) => new vserver()
    {
      name = resource.name
    }.perform_operation_byaction(client, nameof (disable));

    private class vserver_response : base_response
    {
      public vserver vserver = (vserver) null;
    }

    public static class cacheableEnum
    {
      public const string YES = "YES";
      public const string NO = "NO";
    }

    public static class somethodEnum
    {
      public const string CONNECTION = "CONNECTION";
      public const string DYNAMICCONNECTION = "DYNAMICCONNECTION";
      public const string BANDWIDTH = "BANDWIDTH";
      public const string HEALTH = "HEALTH";
      public const string NONE = "NONE";
    }

    public static class sopersistenceEnum
    {
      public const string ENABLED = "ENABLED";
      public const string DISABLED = "DISABLED";
    }
  }
}
