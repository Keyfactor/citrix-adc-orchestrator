// Decompiled with JetBrains decompiler
// Type: com.citrix.netscaler.nitro.resource.config.system.systemfile
// Assembly: nitro, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 6CF5DDEF-E052-4F9D-953F-6644F8378A66


using com.citrix.netscaler.nitro.exception;
using com.citrix.netscaler.nitro.resource.Base;
using com.citrix.netscaler.nitro.service;
using com.citrix.netscaler.nitro.util;

namespace com.citrix.netscaler.nitro.resource.config.system
{
  public class systemfile : base_resource
  {
    private string filenameField = (string) null;
    private string filecontentField = (string) null;
    private string filelocationField = (string) null;
    private string fileencodingField = (string) null;
    private string fileaccesstimeField = (string) null;
    private string filemodifiedtimeField = (string) null;
    private string[] filemodeField = (string[]) null;
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

    public string filecontent
    {
      get => this.filecontentField;
      set => this.filecontentField = value;
    }

    public string filelocation
    {
      get => this.filelocationField;
      set => this.filelocationField = value;
    }

    public string fileencoding
    {
      get => this.fileencodingField;
      set => this.fileencodingField = value;
    }

    public string fileaccesstime
    {
      get => this.fileaccesstimeField;
      private set => this.fileaccesstimeField = value;
    }

    public string filemodifiedtime
    {
      get => this.filemodifiedtimeField;
      private set => this.filemodifiedtimeField = value;
    }

    public string[] filemode
    {
      get => this.filemodeField;
      private set => this.filemodeField = value;
    }

    internal override base_resource[] get_nitro_response(
      nitro_service service,
      string response)
    {
      systemfile.systemfile_response systemfileResponse = new systemfile.systemfile_response();
      systemfile.systemfile_response resource = (systemfile.systemfile_response) service.get_payload_formatter().string_to_resource(systemfileResponse.GetType(), response);
      if (resource.errorcode != 0)
      {
        if (resource.errorcode == 444)
          service.clear_session();
        if (resource.severity == null)
          throw new nitro_exception(resource.message, resource.errorcode);
        if (resource.severity.Equals("ERROR"))
          throw new nitro_exception(resource.message, resource.errorcode);
      }
      return (base_resource[]) resource.systemfile;
    }

    internal override string get_object_name() => this.filename;

    public static base_response add(nitro_service client, systemfile resource) => new systemfile()
    {
      filename = resource.filename,
      filecontent = resource.filecontent,
      filelocation = resource.filelocation,
      fileencoding = resource.fileencoding
    }.add_resource(client);

    public static base_responses add(nitro_service client, systemfile[] resources)
    {
      base_responses baseResponses = (base_responses) null;
      if (resources != null && resources.Length > 0)
      {
        systemfile[] systemfileArray = new systemfile[resources.Length];
        for (int index = 0; index < resources.Length; ++index)
        {
          systemfileArray[index] = new systemfile();
          systemfileArray[index].filename = resources[index].filename;
          systemfileArray[index].filecontent = resources[index].filecontent;
          systemfileArray[index].filelocation = resources[index].filelocation;
          systemfileArray[index].fileencoding = resources[index].fileencoding;
        }
        baseResponses = base_resource.add_bulk_request(client, (base_resource[]) systemfileArray);
      }
      return baseResponses;
    }

    public static base_response delete(nitro_service client, string filename) => new systemfile()
    {
      filename = filename
    }.delete_resource(client);

    public static base_response delete(nitro_service client, systemfile resource) => new systemfile()
    {
      filename = resource.filename,
      filelocation = resource.filelocation
    }.delete_resource(client);

    public static base_responses delete(nitro_service client, string[] filename)
    {
      base_responses baseResponses = (base_responses) null;
      if (filename != null && filename.Length > 0)
      {
        systemfile[] systemfileArray = new systemfile[filename.Length];
        for (int index = 0; index < filename.Length; ++index)
        {
          systemfileArray[index] = new systemfile();
          systemfileArray[index].filename = filename[index];
        }
        baseResponses = base_resource.delete_bulk_request(client, (base_resource[]) systemfileArray);
      }
      return baseResponses;
    }

    public static base_responses delete(nitro_service client, systemfile[] resources)
    {
      base_responses baseResponses = (base_responses) null;
      if (resources != null && resources.Length > 0)
      {
        systemfile[] systemfileArray = new systemfile[resources.Length];
        for (int index = 0; index < resources.Length; ++index)
        {
          systemfileArray[index] = new systemfile();
          systemfileArray[index].filename = resources[index].filename;
          systemfileArray[index].filelocation = resources[index].filelocation;
        }
        baseResponses = base_resource.delete_bulk_request(client, (base_resource[]) systemfileArray);
      }
      return baseResponses;
    }

    public static systemfile[] get(nitro_service service) => (systemfile[]) new systemfile().get_resources(service, (options) null);

    public static systemfile[] get(nitro_service service, options option) => (systemfile[]) new systemfile().get_resources(service, option);

    public static systemfile[] get(nitro_service service, systemfile_args args)
    {
      systemfile systemfile = new systemfile();
      options option = new options();
      option.set_args(nitro_util.object_to_string_withoutquotes((object) args));
      return (systemfile[]) systemfile.get_resources(service, option);
    }

    public static systemfile get(nitro_service service, string filename) => (systemfile) new systemfile()
    {
      filename = filename
    }.get_resource(service);

    public static systemfile[] get(nitro_service service, string[] filename)
    {
      if (filename == null || filename.Length <= 0)
        return (systemfile[]) null;
      systemfile[] systemfileArray1 = new systemfile[filename.Length];
      systemfile[] systemfileArray2 = new systemfile[filename.Length];
      for (int index = 0; index < filename.Length; ++index)
      {
        systemfileArray2[index] = new systemfile();
        systemfileArray2[index].filename = filename[index];
        systemfileArray1[index] = (systemfile) systemfileArray2[index].get_resource(service);
      }
      return systemfileArray1;
    }

    private class systemfile_response : base_response
    {
      public systemfile[] systemfile = (systemfile[]) null;
    }

    public static class filemodeEnum
    {
      public const string DIRECTORY = "DIRECTORY";
    }
  }
}
