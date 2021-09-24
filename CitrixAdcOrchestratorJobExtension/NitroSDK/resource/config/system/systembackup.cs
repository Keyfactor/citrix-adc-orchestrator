// Decompiled with JetBrains decompiler
// Type: com.citrix.netscaler.nitro.resource.config.system.systembackup
// Assembly: nitro, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 6CF5DDEF-E052-4F9D-953F-6644F8378A66


using com.citrix.netscaler.nitro.exception;
using com.citrix.netscaler.nitro.resource.Base;
using com.citrix.netscaler.nitro.service;
using com.citrix.netscaler.nitro.util;

namespace com.citrix.netscaler.nitro.resource.config.system
{
  public class systembackup : base_resource
  {
    private string filenameField = (string) null;
    private string levelField = (string) null;
    private string commentField = (string) null;
    private bool? skipbackupField = new bool?();
    private long? sizeField = new long?();
    private string creationtimeField = (string) null;
    private string versionField = (string) null;
    private string createdbyField = (string) null;
    private string ipaddressField = (string) null;
    private uint? __countField = new uint?();

    public uint? __count
    {
      get => this.__countField;
      private set => this.__countField = value;
    }

    public string filename
    {
      get => this.filenameField;
      set => this.filenameField = value;
    }

    public string level
    {
      get => this.levelField;
      set => this.levelField = value;
    }

    public string comment
    {
      get => this.commentField;
      set => this.commentField = value;
    }

    public bool? skipbackup
    {
      get => this.skipbackupField;
      set => this.skipbackupField = value;
    }

    public long? size
    {
      get => this.sizeField;
      private set => this.sizeField = value;
    }

    public string creationtime
    {
      get => this.creationtimeField;
      private set => this.creationtimeField = value;
    }

    public string version
    {
      get => this.versionField;
      private set => this.versionField = value;
    }

    public string createdby
    {
      get => this.createdbyField;
      private set => this.createdbyField = value;
    }

    public string ipaddress
    {
      get => this.ipaddressField;
      private set => this.ipaddressField = value;
    }

    internal override base_resource[] get_nitro_response(
      nitro_service service,
      string response)
    {
      systembackup.systembackup_response systembackupResponse = new systembackup.systembackup_response();
      systembackup.systembackup_response resource = (systembackup.systembackup_response) service.get_payload_formatter().string_to_resource(systembackupResponse.GetType(), response);
      if (resource.errorcode != 0)
      {
        if (resource.errorcode == 444)
          service.clear_session();
        if (resource.severity == null)
          throw new nitro_exception(resource.message, resource.errorcode);
        if (resource.severity.Equals("ERROR"))
          throw new nitro_exception(resource.message, resource.errorcode);
      }
      return (base_resource[]) resource.systembackup;
    }

    internal override string get_object_name() => this.filename;

    public static base_response create(nitro_service client, systembackup resource) => new systembackup()
    {
      filename = resource.filename,
      level = resource.level,
      comment = resource.comment
    }.perform_operation_byaction(client, nameof (create));

    public static base_responses create(
      nitro_service client,
      systembackup[] resources)
    {
      base_responses baseResponses = (base_responses) null;
      if (resources != null && resources.Length > 0)
      {
        systembackup[] systembackupArray = new systembackup[resources.Length];
        for (int index = 0; index < resources.Length; ++index)
        {
          systembackupArray[index] = new systembackup();
          systembackupArray[index].filename = resources[index].filename;
          systembackupArray[index].level = resources[index].level;
          systembackupArray[index].comment = resources[index].comment;
        }
        baseResponses = base_resource.perform_operation_bulk_request(client, (base_resource[]) systembackupArray, nameof (create));
      }
      return baseResponses;
    }

    public static base_response restore(nitro_service client, systembackup resource) => new systembackup()
    {
      filename = resource.filename,
      skipbackup = resource.skipbackup
    }.perform_operation_byaction(client, nameof (restore));

    public static base_responses restore(
      nitro_service client,
      systembackup[] resources)
    {
      base_responses baseResponses = (base_responses) null;
      if (resources != null && resources.Length > 0)
      {
        systembackup[] systembackupArray = new systembackup[resources.Length];
        for (int index = 0; index < resources.Length; ++index)
        {
          systembackupArray[index] = new systembackup();
          systembackupArray[index].filename = resources[index].filename;
          systembackupArray[index].skipbackup = resources[index].skipbackup;
        }
        baseResponses = base_resource.perform_operation_bulk_request(client, (base_resource[]) systembackupArray, nameof (restore));
      }
      return baseResponses;
    }

    public static base_response add(nitro_service client, systembackup resource) => new systembackup()
    {
      filename = resource.filename
    }.add_resource(client);

    public static base_responses add(nitro_service client, systembackup[] resources)
    {
      base_responses baseResponses = (base_responses) null;
      if (resources != null && resources.Length > 0)
      {
        systembackup[] systembackupArray = new systembackup[resources.Length];
        for (int index = 0; index < resources.Length; ++index)
        {
          systembackupArray[index] = new systembackup();
          systembackupArray[index].filename = resources[index].filename;
        }
        baseResponses = base_resource.add_bulk_request(client, (base_resource[]) systembackupArray);
      }
      return baseResponses;
    }

    public static base_response delete(nitro_service client, string filename) => new systembackup()
    {
      filename = filename
    }.delete_resource(client);

    public static base_response delete(nitro_service client, systembackup resource) => new systembackup()
    {
      filename = resource.filename
    }.delete_resource(client);

    public static base_responses delete(nitro_service client, string[] filename)
    {
      base_responses baseResponses = (base_responses) null;
      if (filename != null && filename.Length > 0)
      {
        systembackup[] systembackupArray = new systembackup[filename.Length];
        for (int index = 0; index < filename.Length; ++index)
        {
          systembackupArray[index] = new systembackup();
          systembackupArray[index].filename = filename[index];
        }
        baseResponses = base_resource.delete_bulk_request(client, (base_resource[]) systembackupArray);
      }
      return baseResponses;
    }

    public static base_responses delete(
      nitro_service client,
      systembackup[] resources)
    {
      base_responses baseResponses = (base_responses) null;
      if (resources != null && resources.Length > 0)
      {
        systembackup[] systembackupArray = new systembackup[resources.Length];
        for (int index = 0; index < resources.Length; ++index)
        {
          systembackupArray[index] = new systembackup();
          systembackupArray[index].filename = resources[index].filename;
        }
        baseResponses = base_resource.delete_bulk_request(client, (base_resource[]) systembackupArray);
      }
      return baseResponses;
    }

    public static systembackup[] get(nitro_service service) => (systembackup[]) new systembackup().get_resources(service, (options) null);

    public static systembackup[] get(nitro_service service, options option) => (systembackup[]) new systembackup().get_resources(service, option);

    public static systembackup get(nitro_service service, string filename) => (systembackup) new systembackup()
    {
      filename = filename
    }.get_resource(service);

    public static systembackup[] get(nitro_service service, string[] filename)
    {
      if (filename == null || filename.Length <= 0)
        return (systembackup[]) null;
      systembackup[] systembackupArray1 = new systembackup[filename.Length];
      systembackup[] systembackupArray2 = new systembackup[filename.Length];
      for (int index = 0; index < filename.Length; ++index)
      {
        systembackupArray2[index] = new systembackup();
        systembackupArray2[index].filename = filename[index];
        systembackupArray1[index] = (systembackup) systembackupArray2[index].get_resource(service);
      }
      return systembackupArray1;
    }

    public static systembackup[] get_filtered(nitro_service service, string filter)
    {
      systembackup systembackup = new systembackup();
      options option = new options();
      option.set_filter(filter);
      return (systembackup[]) systembackup.getfiltered(service, option);
    }

    public static systembackup[] get_filtered(
      nitro_service service,
      filtervalue[] filter)
    {
      systembackup systembackup = new systembackup();
      options option = new options();
      option.set_filter(filter);
      return (systembackup[]) systembackup.getfiltered(service, option);
    }

    public static uint count(nitro_service service)
    {
      systembackup systembackup = new systembackup();
      options option = new options();
      option.set_count(true);
      systembackup[] resources = (systembackup[]) systembackup.get_resources(service, option);
      return resources != null && resources.Length > 0 ? resources[0].__count.Value : 0U;
    }

    public static uint count_filtered(nitro_service service, string filter)
    {
      systembackup systembackup = new systembackup();
      options option = new options();
      option.set_count(true);
      option.set_filter(filter);
      systembackup[] systembackupArray = (systembackup[]) systembackup.getfiltered(service, option);
      return systembackupArray != null && systembackupArray.Length > 0 ? systembackupArray[0].__count.Value : 0U;
    }

    public static uint count_filtered(nitro_service service, filtervalue[] filter)
    {
      systembackup systembackup = new systembackup();
      options option = new options();
      option.set_count(true);
      option.set_filter(filter);
      systembackup[] systembackupArray = (systembackup[]) systembackup.getfiltered(service, option);
      return systembackupArray != null && systembackupArray.Length > 0 ? systembackupArray[0].__count.Value : 0U;
    }

    private class systembackup_response : base_response
    {
      public systembackup[] systembackup = (systembackup[]) null;
    }

    public static class levelEnum
    {
      public const string basic = "basic";
      public const string full = "full";
    }
  }
}
