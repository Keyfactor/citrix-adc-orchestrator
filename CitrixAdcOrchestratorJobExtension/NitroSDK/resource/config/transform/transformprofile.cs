// Decompiled with JetBrains decompiler
// Type: com.citrix.netscaler.nitro.resource.config.transform.transformprofile
// Assembly: nitro, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 6CF5DDEF-E052-4F9D-953F-6644F8378A66


using com.citrix.netscaler.nitro.exception;
using com.citrix.netscaler.nitro.resource.Base;
using com.citrix.netscaler.nitro.service;
using com.citrix.netscaler.nitro.util;

namespace com.citrix.netscaler.nitro.resource.config.transform
{
  public class transformprofile : base_resource
  {
    private string nameField = (string) null;
    private string typeField = (string) null;
    private string onlytransformabsurlinbodyField = (string) null;
    private string commentField = (string) null;
    private string regexforfindingurlinjavascriptField = (string) null;
    private string regexforfindingurlincssField = (string) null;
    private string regexforfindingurlinxcomponentField = (string) null;
    private string regexforfindingurlinxmlField = (string) null;
    private string additionalreqheaderslistField = (string) null;
    private string additionalrespheaderslistField = (string) null;
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

    public string type
    {
      get => this.typeField;
      set => this.typeField = value;
    }

    public string onlytransformabsurlinbody
    {
      get => this.onlytransformabsurlinbodyField;
      set => this.onlytransformabsurlinbodyField = value;
    }

    public string comment
    {
      get => this.commentField;
      set => this.commentField = value;
    }

    public string regexforfindingurlinjavascript
    {
      get => this.regexforfindingurlinjavascriptField;
      private set => this.regexforfindingurlinjavascriptField = value;
    }

    public string regexforfindingurlincss
    {
      get => this.regexforfindingurlincssField;
      private set => this.regexforfindingurlincssField = value;
    }

    public string regexforfindingurlinxcomponent
    {
      get => this.regexforfindingurlinxcomponentField;
      private set => this.regexforfindingurlinxcomponentField = value;
    }

    public string regexforfindingurlinxml
    {
      get => this.regexforfindingurlinxmlField;
      private set => this.regexforfindingurlinxmlField = value;
    }

    public string additionalreqheaderslist
    {
      get => this.additionalreqheaderslistField;
      private set => this.additionalreqheaderslistField = value;
    }

    public string additionalrespheaderslist
    {
      get => this.additionalrespheaderslistField;
      private set => this.additionalrespheaderslistField = value;
    }

    internal override base_resource[] get_nitro_response(
      nitro_service service,
      string response)
    {
      transformprofile.transformprofile_response transformprofileResponse = new transformprofile.transformprofile_response();
      transformprofile.transformprofile_response resource = (transformprofile.transformprofile_response) service.get_payload_formatter().string_to_resource(transformprofileResponse.GetType(), response);
      if (resource.errorcode != 0)
      {
        if (resource.errorcode == 444)
          service.clear_session();
        if (resource.severity == null)
          throw new nitro_exception(resource.message, resource.errorcode);
        if (resource.severity.Equals("ERROR"))
          throw new nitro_exception(resource.message, resource.errorcode);
      }
      return (base_resource[]) resource.transformprofile;
    }

    internal override string get_object_name() => this.name;

    public static base_response add(nitro_service client, transformprofile resource) => new transformprofile()
    {
      name = resource.name,
      type = resource.type
    }.add_resource(client);

    public static base_responses add(
      nitro_service client,
      transformprofile[] resources)
    {
      base_responses baseResponses = (base_responses) null;
      if (resources != null && resources.Length > 0)
      {
        transformprofile[] transformprofileArray = new transformprofile[resources.Length];
        for (int index = 0; index < resources.Length; ++index)
        {
          transformprofileArray[index] = new transformprofile();
          transformprofileArray[index].name = resources[index].name;
          transformprofileArray[index].type = resources[index].type;
        }
        baseResponses = base_resource.add_bulk_request(client, (base_resource[]) transformprofileArray);
      }
      return baseResponses;
    }

    public static base_response delete(nitro_service client, string name) => new transformprofile()
    {
      name = name
    }.delete_resource(client);

    public static base_response delete(nitro_service client, transformprofile resource) => new transformprofile()
    {
      name = resource.name
    }.delete_resource(client);

    public static base_responses delete(nitro_service client, string[] name)
    {
      base_responses baseResponses = (base_responses) null;
      if (name != null && name.Length > 0)
      {
        transformprofile[] transformprofileArray = new transformprofile[name.Length];
        for (int index = 0; index < name.Length; ++index)
        {
          transformprofileArray[index] = new transformprofile();
          transformprofileArray[index].name = name[index];
        }
        baseResponses = base_resource.delete_bulk_request(client, (base_resource[]) transformprofileArray);
      }
      return baseResponses;
    }

    public static base_responses delete(
      nitro_service client,
      transformprofile[] resources)
    {
      base_responses baseResponses = (base_responses) null;
      if (resources != null && resources.Length > 0)
      {
        transformprofile[] transformprofileArray = new transformprofile[resources.Length];
        for (int index = 0; index < resources.Length; ++index)
        {
          transformprofileArray[index] = new transformprofile();
          transformprofileArray[index].name = resources[index].name;
        }
        baseResponses = base_resource.delete_bulk_request(client, (base_resource[]) transformprofileArray);
      }
      return baseResponses;
    }

    public static base_response update(nitro_service client, transformprofile resource) => new transformprofile()
    {
      name = resource.name,
      type = resource.type,
      onlytransformabsurlinbody = resource.onlytransformabsurlinbody,
      comment = resource.comment
    }.update_resource(client);

    public static base_responses update(
      nitro_service client,
      transformprofile[] resources)
    {
      base_responses baseResponses = (base_responses) null;
      if (resources != null && resources.Length > 0)
      {
        transformprofile[] transformprofileArray = new transformprofile[resources.Length];
        for (int index = 0; index < resources.Length; ++index)
        {
          transformprofileArray[index] = new transformprofile();
          transformprofileArray[index].name = resources[index].name;
          transformprofileArray[index].type = resources[index].type;
          transformprofileArray[index].onlytransformabsurlinbody = resources[index].onlytransformabsurlinbody;
          transformprofileArray[index].comment = resources[index].comment;
        }
        baseResponses = base_resource.update_bulk_request(client, (base_resource[]) transformprofileArray);
      }
      return baseResponses;
    }

    public static base_response unset(
      nitro_service client,
      string name,
      string[] args)
    {
      return new transformprofile() { name = name }.unset_resource(client, args);
    }

    public static base_response unset(
      nitro_service client,
      transformprofile resource,
      string[] args)
    {
      return new transformprofile() { name = resource.name }.unset_resource(client, args);
    }

    public static base_responses unset(
      nitro_service client,
      string[] name,
      string[] args)
    {
      base_responses baseResponses = (base_responses) null;
      if (name != null && name.Length > 0)
      {
        transformprofile[] transformprofileArray = new transformprofile[name.Length];
        for (int index = 0; index < name.Length; ++index)
        {
          transformprofileArray[index] = new transformprofile();
          transformprofileArray[index].name = name[index];
        }
        baseResponses = base_resource.unset_bulk_request(client, (base_resource[]) transformprofileArray, args);
      }
      return baseResponses;
    }

    public static base_responses unset(
      nitro_service client,
      transformprofile[] resources,
      string[] args)
    {
      base_responses baseResponses = (base_responses) null;
      if (resources != null && resources.Length > 0)
      {
        transformprofile[] transformprofileArray = new transformprofile[resources.Length];
        for (int index = 0; index < resources.Length; ++index)
        {
          transformprofileArray[index] = new transformprofile();
          transformprofileArray[index].name = resources[index].name;
        }
        baseResponses = base_resource.unset_bulk_request(client, (base_resource[]) transformprofileArray, args);
      }
      return baseResponses;
    }

    public static transformprofile[] get(nitro_service service) => (transformprofile[]) new transformprofile().get_resources(service, (options) null);

    public static transformprofile[] get(nitro_service service, options option) => (transformprofile[]) new transformprofile().get_resources(service, option);

    public static transformprofile get(nitro_service service, string name) => (transformprofile) new transformprofile()
    {
      name = name
    }.get_resource(service);

    public static transformprofile[] get(nitro_service service, string[] name)
    {
      if (name == null || name.Length <= 0)
        return (transformprofile[]) null;
      transformprofile[] transformprofileArray1 = new transformprofile[name.Length];
      transformprofile[] transformprofileArray2 = new transformprofile[name.Length];
      for (int index = 0; index < name.Length; ++index)
      {
        transformprofileArray2[index] = new transformprofile();
        transformprofileArray2[index].name = name[index];
        transformprofileArray1[index] = (transformprofile) transformprofileArray2[index].get_resource(service);
      }
      return transformprofileArray1;
    }

    public static transformprofile[] get_filtered(
      nitro_service service,
      string filter)
    {
      transformprofile transformprofile = new transformprofile();
      options option = new options();
      option.set_filter(filter);
      return (transformprofile[]) transformprofile.getfiltered(service, option);
    }

    public static transformprofile[] get_filtered(
      nitro_service service,
      filtervalue[] filter)
    {
      transformprofile transformprofile = new transformprofile();
      options option = new options();
      option.set_filter(filter);
      return (transformprofile[]) transformprofile.getfiltered(service, option);
    }

    public static uint count(nitro_service service)
    {
      transformprofile transformprofile = new transformprofile();
      options option = new options();
      option.set_count(true);
      transformprofile[] resources = (transformprofile[]) transformprofile.get_resources(service, option);
      return resources != null && resources.Length > 0 ? resources[0].__count.Value : 0U;
    }

    public static uint count_filtered(nitro_service service, string filter)
    {
      transformprofile transformprofile = new transformprofile();
      options option = new options();
      option.set_count(true);
      option.set_filter(filter);
      transformprofile[] transformprofileArray = (transformprofile[]) transformprofile.getfiltered(service, option);
      return transformprofileArray != null && transformprofileArray.Length > 0 ? transformprofileArray[0].__count.Value : 0U;
    }

    public static uint count_filtered(nitro_service service, filtervalue[] filter)
    {
      transformprofile transformprofile = new transformprofile();
      options option = new options();
      option.set_count(true);
      option.set_filter(filter);
      transformprofile[] transformprofileArray = (transformprofile[]) transformprofile.getfiltered(service, option);
      return transformprofileArray != null && transformprofileArray.Length > 0 ? transformprofileArray[0].__count.Value : 0U;
    }

    private class transformprofile_response : base_response
    {
      public transformprofile[] transformprofile = (transformprofile[]) null;
    }

    public static class onlytransformabsurlinbodyEnum
    {
      public const string ON = "ON";
      public const string OFF = "OFF";
    }

    public static class typeEnum
    {
      public const string URL = "URL";
    }
  }
}
