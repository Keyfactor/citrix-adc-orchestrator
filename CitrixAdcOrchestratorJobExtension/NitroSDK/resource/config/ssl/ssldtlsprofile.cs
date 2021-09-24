// Decompiled with JetBrains decompiler
// Type: com.citrix.netscaler.nitro.resource.config.ssl.ssldtlsprofile
// Assembly: nitro, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 6CF5DDEF-E052-4F9D-953F-6644F8378A66


using com.citrix.netscaler.nitro.exception;
using com.citrix.netscaler.nitro.resource.Base;
using com.citrix.netscaler.nitro.service;
using com.citrix.netscaler.nitro.util;

namespace com.citrix.netscaler.nitro.resource.config.ssl
{
  public class ssldtlsprofile : base_resource
  {
    private string nameField = (string) null;
    private string pmtudiscoveryField = (string) null;
    private uint? maxrecordsizeField = new uint?();
    private uint? maxretrytimeField = new uint?();
    private string helloverifyrequestField = (string) null;
    private string terminatesessionField = (string) null;
    private uint? maxpacketsizeField = new uint?();
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

    public string pmtudiscovery
    {
      get => this.pmtudiscoveryField;
      set => this.pmtudiscoveryField = value;
    }

    public uint? maxrecordsize
    {
      get => this.maxrecordsizeField;
      set => this.maxrecordsizeField = value;
    }

    public uint? maxretrytime
    {
      get => this.maxretrytimeField;
      set => this.maxretrytimeField = value;
    }

    public string helloverifyrequest
    {
      get => this.helloverifyrequestField;
      set => this.helloverifyrequestField = value;
    }

    public string terminatesession
    {
      get => this.terminatesessionField;
      set => this.terminatesessionField = value;
    }

    public uint? maxpacketsize
    {
      get => this.maxpacketsizeField;
      set => this.maxpacketsizeField = value;
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
      ssldtlsprofile.ssldtlsprofile_response ssldtlsprofileResponse = new ssldtlsprofile.ssldtlsprofile_response();
      ssldtlsprofile.ssldtlsprofile_response resource = (ssldtlsprofile.ssldtlsprofile_response) service.get_payload_formatter().string_to_resource(ssldtlsprofileResponse.GetType(), response);
      if (resource.errorcode != 0)
      {
        if (resource.errorcode == 444)
          service.clear_session();
        if (resource.severity == null)
          throw new nitro_exception(resource.message, resource.errorcode);
        if (resource.severity.Equals("ERROR"))
          throw new nitro_exception(resource.message, resource.errorcode);
      }
      return (base_resource[]) resource.ssldtlsprofile;
    }

    internal override string get_object_name() => this.name;

    public static base_response add(nitro_service client, ssldtlsprofile resource) => new ssldtlsprofile()
    {
      name = resource.name,
      pmtudiscovery = resource.pmtudiscovery,
      maxrecordsize = resource.maxrecordsize,
      maxretrytime = resource.maxretrytime,
      helloverifyrequest = resource.helloverifyrequest,
      terminatesession = resource.terminatesession,
      maxpacketsize = resource.maxpacketsize
    }.add_resource(client);

    public static base_responses add(nitro_service client, ssldtlsprofile[] resources)
    {
      base_responses baseResponses = (base_responses) null;
      if (resources != null && resources.Length > 0)
      {
        ssldtlsprofile[] ssldtlsprofileArray = new ssldtlsprofile[resources.Length];
        for (int index = 0; index < resources.Length; ++index)
        {
          ssldtlsprofileArray[index] = new ssldtlsprofile();
          ssldtlsprofileArray[index].name = resources[index].name;
          ssldtlsprofileArray[index].pmtudiscovery = resources[index].pmtudiscovery;
          ssldtlsprofileArray[index].maxrecordsize = resources[index].maxrecordsize;
          ssldtlsprofileArray[index].maxretrytime = resources[index].maxretrytime;
          ssldtlsprofileArray[index].helloverifyrequest = resources[index].helloverifyrequest;
          ssldtlsprofileArray[index].terminatesession = resources[index].terminatesession;
          ssldtlsprofileArray[index].maxpacketsize = resources[index].maxpacketsize;
        }
        baseResponses = base_resource.add_bulk_request(client, (base_resource[]) ssldtlsprofileArray);
      }
      return baseResponses;
    }

    public static base_response delete(nitro_service client, string name) => new ssldtlsprofile()
    {
      name = name
    }.delete_resource(client);

    public static base_response delete(nitro_service client, ssldtlsprofile resource) => new ssldtlsprofile()
    {
      name = resource.name
    }.delete_resource(client);

    public static base_responses delete(nitro_service client, string[] name)
    {
      base_responses baseResponses = (base_responses) null;
      if (name != null && name.Length > 0)
      {
        ssldtlsprofile[] ssldtlsprofileArray = new ssldtlsprofile[name.Length];
        for (int index = 0; index < name.Length; ++index)
        {
          ssldtlsprofileArray[index] = new ssldtlsprofile();
          ssldtlsprofileArray[index].name = name[index];
        }
        baseResponses = base_resource.delete_bulk_request(client, (base_resource[]) ssldtlsprofileArray);
      }
      return baseResponses;
    }

    public static base_responses delete(
      nitro_service client,
      ssldtlsprofile[] resources)
    {
      base_responses baseResponses = (base_responses) null;
      if (resources != null && resources.Length > 0)
      {
        ssldtlsprofile[] ssldtlsprofileArray = new ssldtlsprofile[resources.Length];
        for (int index = 0; index < resources.Length; ++index)
        {
          ssldtlsprofileArray[index] = new ssldtlsprofile();
          ssldtlsprofileArray[index].name = resources[index].name;
        }
        baseResponses = base_resource.delete_bulk_request(client, (base_resource[]) ssldtlsprofileArray);
      }
      return baseResponses;
    }

    public static base_response update(nitro_service client, ssldtlsprofile resource) => new ssldtlsprofile()
    {
      name = resource.name,
      pmtudiscovery = resource.pmtudiscovery,
      maxrecordsize = resource.maxrecordsize,
      maxretrytime = resource.maxretrytime,
      helloverifyrequest = resource.helloverifyrequest,
      terminatesession = resource.terminatesession,
      maxpacketsize = resource.maxpacketsize
    }.update_resource(client);

    public static base_responses update(
      nitro_service client,
      ssldtlsprofile[] resources)
    {
      base_responses baseResponses = (base_responses) null;
      if (resources != null && resources.Length > 0)
      {
        ssldtlsprofile[] ssldtlsprofileArray = new ssldtlsprofile[resources.Length];
        for (int index = 0; index < resources.Length; ++index)
        {
          ssldtlsprofileArray[index] = new ssldtlsprofile();
          ssldtlsprofileArray[index].name = resources[index].name;
          ssldtlsprofileArray[index].pmtudiscovery = resources[index].pmtudiscovery;
          ssldtlsprofileArray[index].maxrecordsize = resources[index].maxrecordsize;
          ssldtlsprofileArray[index].maxretrytime = resources[index].maxretrytime;
          ssldtlsprofileArray[index].helloverifyrequest = resources[index].helloverifyrequest;
          ssldtlsprofileArray[index].terminatesession = resources[index].terminatesession;
          ssldtlsprofileArray[index].maxpacketsize = resources[index].maxpacketsize;
        }
        baseResponses = base_resource.update_bulk_request(client, (base_resource[]) ssldtlsprofileArray);
      }
      return baseResponses;
    }

    public static base_response unset(
      nitro_service client,
      string name,
      string[] args)
    {
      return new ssldtlsprofile() { name = name }.unset_resource(client, args);
    }

    public static base_response unset(
      nitro_service client,
      ssldtlsprofile resource,
      string[] args)
    {
      return new ssldtlsprofile() { name = resource.name }.unset_resource(client, args);
    }

    public static base_responses unset(
      nitro_service client,
      string[] name,
      string[] args)
    {
      base_responses baseResponses = (base_responses) null;
      if (name != null && name.Length > 0)
      {
        ssldtlsprofile[] ssldtlsprofileArray = new ssldtlsprofile[name.Length];
        for (int index = 0; index < name.Length; ++index)
        {
          ssldtlsprofileArray[index] = new ssldtlsprofile();
          ssldtlsprofileArray[index].name = name[index];
        }
        baseResponses = base_resource.unset_bulk_request(client, (base_resource[]) ssldtlsprofileArray, args);
      }
      return baseResponses;
    }

    public static base_responses unset(
      nitro_service client,
      ssldtlsprofile[] resources,
      string[] args)
    {
      base_responses baseResponses = (base_responses) null;
      if (resources != null && resources.Length > 0)
      {
        ssldtlsprofile[] ssldtlsprofileArray = new ssldtlsprofile[resources.Length];
        for (int index = 0; index < resources.Length; ++index)
        {
          ssldtlsprofileArray[index] = new ssldtlsprofile();
          ssldtlsprofileArray[index].name = resources[index].name;
        }
        baseResponses = base_resource.unset_bulk_request(client, (base_resource[]) ssldtlsprofileArray, args);
      }
      return baseResponses;
    }

    public static ssldtlsprofile[] get(nitro_service service) => (ssldtlsprofile[]) new ssldtlsprofile().get_resources(service, (options) null);

    public static ssldtlsprofile[] get(nitro_service service, options option) => (ssldtlsprofile[]) new ssldtlsprofile().get_resources(service, option);

    public static ssldtlsprofile get(nitro_service service, string name) => (ssldtlsprofile) new ssldtlsprofile()
    {
      name = name
    }.get_resource(service);

    public static ssldtlsprofile[] get(nitro_service service, string[] name)
    {
      if (name == null || name.Length <= 0)
        return (ssldtlsprofile[]) null;
      ssldtlsprofile[] ssldtlsprofileArray1 = new ssldtlsprofile[name.Length];
      ssldtlsprofile[] ssldtlsprofileArray2 = new ssldtlsprofile[name.Length];
      for (int index = 0; index < name.Length; ++index)
      {
        ssldtlsprofileArray2[index] = new ssldtlsprofile();
        ssldtlsprofileArray2[index].name = name[index];
        ssldtlsprofileArray1[index] = (ssldtlsprofile) ssldtlsprofileArray2[index].get_resource(service);
      }
      return ssldtlsprofileArray1;
    }

    public static ssldtlsprofile[] get_filtered(nitro_service service, string filter)
    {
      ssldtlsprofile ssldtlsprofile = new ssldtlsprofile();
      options option = new options();
      option.set_filter(filter);
      return (ssldtlsprofile[]) ssldtlsprofile.getfiltered(service, option);
    }

    public static ssldtlsprofile[] get_filtered(
      nitro_service service,
      filtervalue[] filter)
    {
      ssldtlsprofile ssldtlsprofile = new ssldtlsprofile();
      options option = new options();
      option.set_filter(filter);
      return (ssldtlsprofile[]) ssldtlsprofile.getfiltered(service, option);
    }

    public static uint count(nitro_service service)
    {
      ssldtlsprofile ssldtlsprofile = new ssldtlsprofile();
      options option = new options();
      option.set_count(true);
      ssldtlsprofile[] resources = (ssldtlsprofile[]) ssldtlsprofile.get_resources(service, option);
      return resources != null && resources.Length > 0 ? resources[0].__count.Value : 0U;
    }

    public static uint count_filtered(nitro_service service, string filter)
    {
      ssldtlsprofile ssldtlsprofile = new ssldtlsprofile();
      options option = new options();
      option.set_count(true);
      option.set_filter(filter);
      ssldtlsprofile[] ssldtlsprofileArray = (ssldtlsprofile[]) ssldtlsprofile.getfiltered(service, option);
      return ssldtlsprofileArray != null && ssldtlsprofileArray.Length > 0 ? ssldtlsprofileArray[0].__count.Value : 0U;
    }

    public static uint count_filtered(nitro_service service, filtervalue[] filter)
    {
      ssldtlsprofile ssldtlsprofile = new ssldtlsprofile();
      options option = new options();
      option.set_count(true);
      option.set_filter(filter);
      ssldtlsprofile[] ssldtlsprofileArray = (ssldtlsprofile[]) ssldtlsprofile.getfiltered(service, option);
      return ssldtlsprofileArray != null && ssldtlsprofileArray.Length > 0 ? ssldtlsprofileArray[0].__count.Value : 0U;
    }

    private class ssldtlsprofile_response : base_response
    {
      public ssldtlsprofile[] ssldtlsprofile = (ssldtlsprofile[]) null;
    }

    public static class terminatesessionEnum
    {
      public const string ENABLED = "ENABLED";
      public const string DISABLED = "DISABLED";
    }

    public static class builtinEnum
    {
      public const string MODIFIABLE = "MODIFIABLE";
      public const string DELETABLE = "DELETABLE";
      public const string IMMUTABLE = "IMMUTABLE";
      public const string PARTITION_ALL = "PARTITION_ALL";
    }

    public static class pmtudiscoveryEnum
    {
      public const string ENABLED = "ENABLED";
      public const string DISABLED = "DISABLED";
    }

    public static class helloverifyrequestEnum
    {
      public const string ENABLED = "ENABLED";
      public const string DISABLED = "DISABLED";
    }
  }
}
