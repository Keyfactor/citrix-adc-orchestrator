// Decompiled with JetBrains decompiler
// Type: com.citrix.netscaler.nitro.resource.config.appflow.appflowaction
// Assembly: nitro, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 6CF5DDEF-E052-4F9D-953F-6644F8378A66


using com.citrix.netscaler.nitro.exception;
using com.citrix.netscaler.nitro.resource.Base;
using com.citrix.netscaler.nitro.service;
using com.citrix.netscaler.nitro.util;

namespace com.citrix.netscaler.nitro.resource.config.appflow
{
  public class appflowaction : base_resource
  {
    private string nameField = (string) null;
    private string[] collectorsField = (string[]) null;
    private string clientsidemeasurementsField = (string) null;
    private string pagetrackingField = (string) null;
    private string commentField = (string) null;
    private string newnameField = (string) null;
    private long? hitsField = new long?();
    private uint? referencecountField = new uint?();
    private string descriptionField = (string) null;
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

    public string[] collectors
    {
      get => this.collectorsField;
      set => this.collectorsField = value;
    }

    public string clientsidemeasurements
    {
      get => this.clientsidemeasurementsField;
      set => this.clientsidemeasurementsField = value;
    }

    public string pagetracking
    {
      get => this.pagetrackingField;
      set => this.pagetrackingField = value;
    }

    public string comment
    {
      get => this.commentField;
      set => this.commentField = value;
    }

    public string newname
    {
      get => this.newnameField;
      set => this.newnameField = value;
    }

    public long? hits
    {
      get => this.hitsField;
      private set => this.hitsField = value;
    }

    public uint? referencecount
    {
      get => this.referencecountField;
      private set => this.referencecountField = value;
    }

    public string description
    {
      get => this.descriptionField;
      private set => this.descriptionField = value;
    }

    internal override base_resource[] get_nitro_response(
      nitro_service service,
      string response)
    {
      appflowaction.appflowaction_response appflowactionResponse = new appflowaction.appflowaction_response();
      appflowaction.appflowaction_response resource = (appflowaction.appflowaction_response) service.get_payload_formatter().string_to_resource(appflowactionResponse.GetType(), response);
      if (resource.errorcode != 0)
      {
        if (resource.errorcode == 444)
          service.clear_session();
        if (resource.severity == null)
          throw new nitro_exception(resource.message, resource.errorcode);
        if (resource.severity.Equals("ERROR"))
          throw new nitro_exception(resource.message, resource.errorcode);
      }
      return (base_resource[]) resource.appflowaction;
    }

    internal override string get_object_name() => this.name;

    public static base_response add(nitro_service client, appflowaction resource) => new appflowaction()
    {
      name = resource.name,
      collectors = resource.collectors,
      clientsidemeasurements = resource.clientsidemeasurements,
      pagetracking = resource.pagetracking,
      comment = resource.comment
    }.add_resource(client);

    public static base_responses add(nitro_service client, appflowaction[] resources)
    {
      base_responses baseResponses = (base_responses) null;
      if (resources != null && resources.Length > 0)
      {
        appflowaction[] appflowactionArray = new appflowaction[resources.Length];
        for (int index = 0; index < resources.Length; ++index)
        {
          appflowactionArray[index] = new appflowaction();
          appflowactionArray[index].name = resources[index].name;
          appflowactionArray[index].collectors = resources[index].collectors;
          appflowactionArray[index].clientsidemeasurements = resources[index].clientsidemeasurements;
          appflowactionArray[index].pagetracking = resources[index].pagetracking;
          appflowactionArray[index].comment = resources[index].comment;
        }
        baseResponses = base_resource.add_bulk_request(client, (base_resource[]) appflowactionArray);
      }
      return baseResponses;
    }

    public static base_response delete(nitro_service client, string name) => new appflowaction()
    {
      name = name
    }.delete_resource(client);

    public static base_response delete(nitro_service client, appflowaction resource) => new appflowaction()
    {
      name = resource.name
    }.delete_resource(client);

    public static base_responses delete(nitro_service client, string[] name)
    {
      base_responses baseResponses = (base_responses) null;
      if (name != null && name.Length > 0)
      {
        appflowaction[] appflowactionArray = new appflowaction[name.Length];
        for (int index = 0; index < name.Length; ++index)
        {
          appflowactionArray[index] = new appflowaction();
          appflowactionArray[index].name = name[index];
        }
        baseResponses = base_resource.delete_bulk_request(client, (base_resource[]) appflowactionArray);
      }
      return baseResponses;
    }

    public static base_responses delete(
      nitro_service client,
      appflowaction[] resources)
    {
      base_responses baseResponses = (base_responses) null;
      if (resources != null && resources.Length > 0)
      {
        appflowaction[] appflowactionArray = new appflowaction[resources.Length];
        for (int index = 0; index < resources.Length; ++index)
        {
          appflowactionArray[index] = new appflowaction();
          appflowactionArray[index].name = resources[index].name;
        }
        baseResponses = base_resource.delete_bulk_request(client, (base_resource[]) appflowactionArray);
      }
      return baseResponses;
    }

    public static base_response update(nitro_service client, appflowaction resource) => new appflowaction()
    {
      name = resource.name,
      collectors = resource.collectors,
      clientsidemeasurements = resource.clientsidemeasurements,
      pagetracking = resource.pagetracking,
      comment = resource.comment
    }.update_resource(client);

    public static base_responses update(
      nitro_service client,
      appflowaction[] resources)
    {
      base_responses baseResponses = (base_responses) null;
      if (resources != null && resources.Length > 0)
      {
        appflowaction[] appflowactionArray = new appflowaction[resources.Length];
        for (int index = 0; index < resources.Length; ++index)
        {
          appflowactionArray[index] = new appflowaction();
          appflowactionArray[index].name = resources[index].name;
          appflowactionArray[index].collectors = resources[index].collectors;
          appflowactionArray[index].clientsidemeasurements = resources[index].clientsidemeasurements;
          appflowactionArray[index].pagetracking = resources[index].pagetracking;
          appflowactionArray[index].comment = resources[index].comment;
        }
        baseResponses = base_resource.update_bulk_request(client, (base_resource[]) appflowactionArray);
      }
      return baseResponses;
    }

    public static base_response unset(
      nitro_service client,
      string name,
      string[] args)
    {
      return new appflowaction() { name = name }.unset_resource(client, args);
    }

    public static base_response unset(
      nitro_service client,
      appflowaction resource,
      string[] args)
    {
      return new appflowaction() { name = resource.name }.unset_resource(client, args);
    }

    public static base_responses unset(
      nitro_service client,
      string[] name,
      string[] args)
    {
      base_responses baseResponses = (base_responses) null;
      if (name != null && name.Length > 0)
      {
        appflowaction[] appflowactionArray = new appflowaction[name.Length];
        for (int index = 0; index < name.Length; ++index)
        {
          appflowactionArray[index] = new appflowaction();
          appflowactionArray[index].name = name[index];
        }
        baseResponses = base_resource.unset_bulk_request(client, (base_resource[]) appflowactionArray, args);
      }
      return baseResponses;
    }

    public static base_responses unset(
      nitro_service client,
      appflowaction[] resources,
      string[] args)
    {
      base_responses baseResponses = (base_responses) null;
      if (resources != null && resources.Length > 0)
      {
        appflowaction[] appflowactionArray = new appflowaction[resources.Length];
        for (int index = 0; index < resources.Length; ++index)
        {
          appflowactionArray[index] = new appflowaction();
          appflowactionArray[index].name = resources[index].name;
        }
        baseResponses = base_resource.unset_bulk_request(client, (base_resource[]) appflowactionArray, args);
      }
      return baseResponses;
    }

    public static base_response rename(
      nitro_service client,
      appflowaction resource,
      string new_name)
    {
      return new appflowaction()
      {
        name = resource.name,
        newname = new_name
      }.rename_resource(client);
    }

    public static base_response rename(
      nitro_service client,
      string name,
      string new_name)
    {
      return new appflowaction()
      {
        name = name,
        newname = new_name
      }.rename_resource(client);
    }

    public static appflowaction[] get(nitro_service service) => (appflowaction[]) new appflowaction().get_resources(service, (options) null);

    public static appflowaction[] get(nitro_service service, options option) => (appflowaction[]) new appflowaction().get_resources(service, option);

    public static appflowaction get(nitro_service service, string name) => (appflowaction) new appflowaction()
    {
      name = name
    }.get_resource(service);

    public static appflowaction[] get(nitro_service service, string[] name)
    {
      if (name == null || name.Length <= 0)
        return (appflowaction[]) null;
      appflowaction[] appflowactionArray1 = new appflowaction[name.Length];
      appflowaction[] appflowactionArray2 = new appflowaction[name.Length];
      for (int index = 0; index < name.Length; ++index)
      {
        appflowactionArray2[index] = new appflowaction();
        appflowactionArray2[index].name = name[index];
        appflowactionArray1[index] = (appflowaction) appflowactionArray2[index].get_resource(service);
      }
      return appflowactionArray1;
    }

    public static appflowaction[] get_filtered(nitro_service service, string filter)
    {
      appflowaction appflowaction = new appflowaction();
      options option = new options();
      option.set_filter(filter);
      return (appflowaction[]) appflowaction.getfiltered(service, option);
    }

    public static appflowaction[] get_filtered(
      nitro_service service,
      filtervalue[] filter)
    {
      appflowaction appflowaction = new appflowaction();
      options option = new options();
      option.set_filter(filter);
      return (appflowaction[]) appflowaction.getfiltered(service, option);
    }

    public static uint count(nitro_service service)
    {
      appflowaction appflowaction = new appflowaction();
      options option = new options();
      option.set_count(true);
      appflowaction[] resources = (appflowaction[]) appflowaction.get_resources(service, option);
      return resources != null && resources.Length > 0 ? resources[0].__count.Value : 0U;
    }

    public static uint count_filtered(nitro_service service, string filter)
    {
      appflowaction appflowaction = new appflowaction();
      options option = new options();
      option.set_count(true);
      option.set_filter(filter);
      appflowaction[] appflowactionArray = (appflowaction[]) appflowaction.getfiltered(service, option);
      return appflowactionArray != null && appflowactionArray.Length > 0 ? appflowactionArray[0].__count.Value : 0U;
    }

    public static uint count_filtered(nitro_service service, filtervalue[] filter)
    {
      appflowaction appflowaction = new appflowaction();
      options option = new options();
      option.set_count(true);
      option.set_filter(filter);
      appflowaction[] appflowactionArray = (appflowaction[]) appflowaction.getfiltered(service, option);
      return appflowactionArray != null && appflowactionArray.Length > 0 ? appflowactionArray[0].__count.Value : 0U;
    }

    private class appflowaction_response : base_response
    {
      public appflowaction[] appflowaction = (appflowaction[]) null;
    }

    public static class pagetrackingEnum
    {
      public const string ENABLED = "ENABLED";
      public const string DISABLED = "DISABLED";
    }

    public static class clientsidemeasurementsEnum
    {
      public const string ENABLED = "ENABLED";
      public const string DISABLED = "DISABLED";
    }
  }
}
