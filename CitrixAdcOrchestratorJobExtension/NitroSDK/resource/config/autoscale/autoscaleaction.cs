// Decompiled with JetBrains decompiler
// Type: com.citrix.netscaler.nitro.resource.config.autoscale.autoscaleaction
// Assembly: nitro, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 6CF5DDEF-E052-4F9D-953F-6644F8378A66


using com.citrix.netscaler.nitro.exception;
using com.citrix.netscaler.nitro.resource.Base;
using com.citrix.netscaler.nitro.service;
using com.citrix.netscaler.nitro.util;

namespace com.citrix.netscaler.nitro.resource.config.autoscale
{
  public class autoscaleaction : base_resource
  {
    private string nameField = (string) null;
    private string typeField = (string) null;
    private string profilenameField = (string) null;
    private string parametersField = (string) null;
    private uint? vmdestroygraceperiodField = new uint?();
    private uint? quiettimeField = new uint?();
    private string vserverField = (string) null;
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

    public string profilename
    {
      get => this.profilenameField;
      set => this.profilenameField = value;
    }

    public string parameters
    {
      get => this.parametersField;
      set => this.parametersField = value;
    }

    public uint? vmdestroygraceperiod
    {
      get => this.vmdestroygraceperiodField;
      set => this.vmdestroygraceperiodField = value;
    }

    public uint? quiettime
    {
      get => this.quiettimeField;
      set => this.quiettimeField = value;
    }

    public string vserver
    {
      get => this.vserverField;
      set => this.vserverField = value;
    }

    internal override base_resource[] get_nitro_response(
      nitro_service service,
      string response)
    {
      autoscaleaction.autoscaleaction_response autoscaleactionResponse = new autoscaleaction.autoscaleaction_response();
      autoscaleaction.autoscaleaction_response resource = (autoscaleaction.autoscaleaction_response) service.get_payload_formatter().string_to_resource(autoscaleactionResponse.GetType(), response);
      if (resource.errorcode != 0)
      {
        if (resource.errorcode == 444)
          service.clear_session();
        if (resource.severity == null)
          throw new nitro_exception(resource.message, resource.errorcode);
        if (resource.severity.Equals("ERROR"))
          throw new nitro_exception(resource.message, resource.errorcode);
      }
      return (base_resource[]) resource.autoscaleaction;
    }

    internal override string get_object_name() => this.name;

    public static base_response add(nitro_service client, autoscaleaction resource) => new autoscaleaction()
    {
      name = resource.name,
      type = resource.type,
      profilename = resource.profilename,
      parameters = resource.parameters,
      vmdestroygraceperiod = resource.vmdestroygraceperiod,
      quiettime = resource.quiettime,
      vserver = resource.vserver
    }.add_resource(client);

    public static base_responses add(
      nitro_service client,
      autoscaleaction[] resources)
    {
      base_responses baseResponses = (base_responses) null;
      if (resources != null && resources.Length > 0)
      {
        autoscaleaction[] autoscaleactionArray = new autoscaleaction[resources.Length];
        for (int index = 0; index < resources.Length; ++index)
        {
          autoscaleactionArray[index] = new autoscaleaction();
          autoscaleactionArray[index].name = resources[index].name;
          autoscaleactionArray[index].type = resources[index].type;
          autoscaleactionArray[index].profilename = resources[index].profilename;
          autoscaleactionArray[index].parameters = resources[index].parameters;
          autoscaleactionArray[index].vmdestroygraceperiod = resources[index].vmdestroygraceperiod;
          autoscaleactionArray[index].quiettime = resources[index].quiettime;
          autoscaleactionArray[index].vserver = resources[index].vserver;
        }
        baseResponses = base_resource.add_bulk_request(client, (base_resource[]) autoscaleactionArray);
      }
      return baseResponses;
    }

    public static base_response delete(nitro_service client, string name) => new autoscaleaction()
    {
      name = name
    }.delete_resource(client);

    public static base_response delete(nitro_service client, autoscaleaction resource) => new autoscaleaction()
    {
      name = resource.name
    }.delete_resource(client);

    public static base_responses delete(nitro_service client, string[] name)
    {
      base_responses baseResponses = (base_responses) null;
      if (name != null && name.Length > 0)
      {
        autoscaleaction[] autoscaleactionArray = new autoscaleaction[name.Length];
        for (int index = 0; index < name.Length; ++index)
        {
          autoscaleactionArray[index] = new autoscaleaction();
          autoscaleactionArray[index].name = name[index];
        }
        baseResponses = base_resource.delete_bulk_request(client, (base_resource[]) autoscaleactionArray);
      }
      return baseResponses;
    }

    public static base_responses delete(
      nitro_service client,
      autoscaleaction[] resources)
    {
      base_responses baseResponses = (base_responses) null;
      if (resources != null && resources.Length > 0)
      {
        autoscaleaction[] autoscaleactionArray = new autoscaleaction[resources.Length];
        for (int index = 0; index < resources.Length; ++index)
        {
          autoscaleactionArray[index] = new autoscaleaction();
          autoscaleactionArray[index].name = resources[index].name;
        }
        baseResponses = base_resource.delete_bulk_request(client, (base_resource[]) autoscaleactionArray);
      }
      return baseResponses;
    }

    public static base_response update(nitro_service client, autoscaleaction resource) => new autoscaleaction()
    {
      name = resource.name,
      profilename = resource.profilename,
      parameters = resource.parameters,
      vmdestroygraceperiod = resource.vmdestroygraceperiod,
      quiettime = resource.quiettime,
      vserver = resource.vserver
    }.update_resource(client);

    public static base_responses update(
      nitro_service client,
      autoscaleaction[] resources)
    {
      base_responses baseResponses = (base_responses) null;
      if (resources != null && resources.Length > 0)
      {
        autoscaleaction[] autoscaleactionArray = new autoscaleaction[resources.Length];
        for (int index = 0; index < resources.Length; ++index)
        {
          autoscaleactionArray[index] = new autoscaleaction();
          autoscaleactionArray[index].name = resources[index].name;
          autoscaleactionArray[index].profilename = resources[index].profilename;
          autoscaleactionArray[index].parameters = resources[index].parameters;
          autoscaleactionArray[index].vmdestroygraceperiod = resources[index].vmdestroygraceperiod;
          autoscaleactionArray[index].quiettime = resources[index].quiettime;
          autoscaleactionArray[index].vserver = resources[index].vserver;
        }
        baseResponses = base_resource.update_bulk_request(client, (base_resource[]) autoscaleactionArray);
      }
      return baseResponses;
    }

    public static base_response unset(
      nitro_service client,
      string name,
      string[] args)
    {
      return new autoscaleaction() { name = name }.unset_resource(client, args);
    }

    public static base_response unset(
      nitro_service client,
      autoscaleaction resource,
      string[] args)
    {
      return new autoscaleaction() { name = resource.name }.unset_resource(client, args);
    }

    public static base_responses unset(
      nitro_service client,
      string[] name,
      string[] args)
    {
      base_responses baseResponses = (base_responses) null;
      if (name != null && name.Length > 0)
      {
        autoscaleaction[] autoscaleactionArray = new autoscaleaction[name.Length];
        for (int index = 0; index < name.Length; ++index)
        {
          autoscaleactionArray[index] = new autoscaleaction();
          autoscaleactionArray[index].name = name[index];
        }
        baseResponses = base_resource.unset_bulk_request(client, (base_resource[]) autoscaleactionArray, args);
      }
      return baseResponses;
    }

    public static base_responses unset(
      nitro_service client,
      autoscaleaction[] resources,
      string[] args)
    {
      base_responses baseResponses = (base_responses) null;
      if (resources != null && resources.Length > 0)
      {
        autoscaleaction[] autoscaleactionArray = new autoscaleaction[resources.Length];
        for (int index = 0; index < resources.Length; ++index)
        {
          autoscaleactionArray[index] = new autoscaleaction();
          autoscaleactionArray[index].name = resources[index].name;
        }
        baseResponses = base_resource.unset_bulk_request(client, (base_resource[]) autoscaleactionArray, args);
      }
      return baseResponses;
    }

    public static autoscaleaction[] get(nitro_service service) => (autoscaleaction[]) new autoscaleaction().get_resources(service, (options) null);

    public static autoscaleaction[] get(nitro_service service, options option) => (autoscaleaction[]) new autoscaleaction().get_resources(service, option);

    public static autoscaleaction get(nitro_service service, string name) => (autoscaleaction) new autoscaleaction()
    {
      name = name
    }.get_resource(service);

    public static autoscaleaction[] get(nitro_service service, string[] name)
    {
      if (name == null || name.Length <= 0)
        return (autoscaleaction[]) null;
      autoscaleaction[] autoscaleactionArray1 = new autoscaleaction[name.Length];
      autoscaleaction[] autoscaleactionArray2 = new autoscaleaction[name.Length];
      for (int index = 0; index < name.Length; ++index)
      {
        autoscaleactionArray2[index] = new autoscaleaction();
        autoscaleactionArray2[index].name = name[index];
        autoscaleactionArray1[index] = (autoscaleaction) autoscaleactionArray2[index].get_resource(service);
      }
      return autoscaleactionArray1;
    }

    public static autoscaleaction[] get_filtered(
      nitro_service service,
      string filter)
    {
      autoscaleaction autoscaleaction = new autoscaleaction();
      options option = new options();
      option.set_filter(filter);
      return (autoscaleaction[]) autoscaleaction.getfiltered(service, option);
    }

    public static autoscaleaction[] get_filtered(
      nitro_service service,
      filtervalue[] filter)
    {
      autoscaleaction autoscaleaction = new autoscaleaction();
      options option = new options();
      option.set_filter(filter);
      return (autoscaleaction[]) autoscaleaction.getfiltered(service, option);
    }

    public static uint count(nitro_service service)
    {
      autoscaleaction autoscaleaction = new autoscaleaction();
      options option = new options();
      option.set_count(true);
      autoscaleaction[] resources = (autoscaleaction[]) autoscaleaction.get_resources(service, option);
      return resources != null && resources.Length > 0 ? resources[0].__count.Value : 0U;
    }

    public static uint count_filtered(nitro_service service, string filter)
    {
      autoscaleaction autoscaleaction = new autoscaleaction();
      options option = new options();
      option.set_count(true);
      option.set_filter(filter);
      autoscaleaction[] autoscaleactionArray = (autoscaleaction[]) autoscaleaction.getfiltered(service, option);
      return autoscaleactionArray != null && autoscaleactionArray.Length > 0 ? autoscaleactionArray[0].__count.Value : 0U;
    }

    public static uint count_filtered(nitro_service service, filtervalue[] filter)
    {
      autoscaleaction autoscaleaction = new autoscaleaction();
      options option = new options();
      option.set_count(true);
      option.set_filter(filter);
      autoscaleaction[] autoscaleactionArray = (autoscaleaction[]) autoscaleaction.getfiltered(service, option);
      return autoscaleactionArray != null && autoscaleactionArray.Length > 0 ? autoscaleactionArray[0].__count.Value : 0U;
    }

    private class autoscaleaction_response : base_response
    {
      public autoscaleaction[] autoscaleaction = (autoscaleaction[]) null;
    }

    public static class typeEnum
    {
      public const string SCALE_UP = "SCALE_UP";
      public const string SCALE_DOWN = "SCALE_DOWN";
    }
  }
}
