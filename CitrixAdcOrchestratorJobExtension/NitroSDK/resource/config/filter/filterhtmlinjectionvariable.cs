// Decompiled with JetBrains decompiler
// Type: com.citrix.netscaler.nitro.resource.config.filter.filterhtmlinjectionvariable
// Assembly: nitro, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 6CF5DDEF-E052-4F9D-953F-6644F8378A66


using com.citrix.netscaler.nitro.exception;
using com.citrix.netscaler.nitro.resource.Base;
using com.citrix.netscaler.nitro.service;
using com.citrix.netscaler.nitro.util;

namespace com.citrix.netscaler.nitro.resource.config.filter
{
  public class filterhtmlinjectionvariable : base_resource
  {
    private string variableField = (string) null;
    private string valueField = (string) null;
    private string[] builtinField = (string[]) null;
    private string typeField = (string) null;
    private uint? __countField = new uint?();

    public uint? __count
    {
      get => this.__countField;
      private set => this.__countField = value;
    }

    public string variable
    {
      get => this.variableField;
      set => this.variableField = value;
    }

    public string value
    {
      get => this.valueField;
      set => this.valueField = value;
    }

    public string[] builtin
    {
      get => this.builtinField;
      private set => this.builtinField = value;
    }

    public string type
    {
      get => this.typeField;
      private set => this.typeField = value;
    }

    internal override base_resource[] get_nitro_response(
      nitro_service service,
      string response)
    {
      filterhtmlinjectionvariable.filterhtmlinjectionvariable_response filterhtmlinjectionvariableResponse = new filterhtmlinjectionvariable.filterhtmlinjectionvariable_response();
      filterhtmlinjectionvariable.filterhtmlinjectionvariable_response resource = (filterhtmlinjectionvariable.filterhtmlinjectionvariable_response) service.get_payload_formatter().string_to_resource(filterhtmlinjectionvariableResponse.GetType(), response);
      if (resource.errorcode != 0)
      {
        if (resource.errorcode == 444)
          service.clear_session();
        if (resource.severity == null)
          throw new nitro_exception(resource.message, resource.errorcode);
        if (resource.severity.Equals("ERROR"))
          throw new nitro_exception(resource.message, resource.errorcode);
      }
      return (base_resource[]) resource.filterhtmlinjectionvariable;
    }

    internal override string get_object_name() => this.variable;

    public static base_response add(
      nitro_service client,
      filterhtmlinjectionvariable resource)
    {
      return new filterhtmlinjectionvariable()
      {
        variable = resource.variable,
        value = resource.value
      }.add_resource(client);
    }

    public static base_responses add(
      nitro_service client,
      filterhtmlinjectionvariable[] resources)
    {
      base_responses baseResponses = (base_responses) null;
      if (resources != null && resources.Length > 0)
      {
        filterhtmlinjectionvariable[] filterhtmlinjectionvariableArray = new filterhtmlinjectionvariable[resources.Length];
        for (int index = 0; index < resources.Length; ++index)
        {
          filterhtmlinjectionvariableArray[index] = new filterhtmlinjectionvariable();
          filterhtmlinjectionvariableArray[index].variable = resources[index].variable;
          filterhtmlinjectionvariableArray[index].value = resources[index].value;
        }
        baseResponses = base_resource.add_bulk_request(client, (base_resource[]) filterhtmlinjectionvariableArray);
      }
      return baseResponses;
    }

    public static base_response delete(nitro_service client, string variable) => new filterhtmlinjectionvariable()
    {
      variable = variable
    }.delete_resource(client);

    public static base_response delete(
      nitro_service client,
      filterhtmlinjectionvariable resource)
    {
      return new filterhtmlinjectionvariable()
      {
        variable = resource.variable
      }.delete_resource(client);
    }

    public static base_responses delete(nitro_service client, string[] variable)
    {
      base_responses baseResponses = (base_responses) null;
      if (variable != null && variable.Length > 0)
      {
        filterhtmlinjectionvariable[] filterhtmlinjectionvariableArray = new filterhtmlinjectionvariable[variable.Length];
        for (int index = 0; index < variable.Length; ++index)
        {
          filterhtmlinjectionvariableArray[index] = new filterhtmlinjectionvariable();
          filterhtmlinjectionvariableArray[index].variable = variable[index];
        }
        baseResponses = base_resource.delete_bulk_request(client, (base_resource[]) filterhtmlinjectionvariableArray);
      }
      return baseResponses;
    }

    public static base_responses delete(
      nitro_service client,
      filterhtmlinjectionvariable[] resources)
    {
      base_responses baseResponses = (base_responses) null;
      if (resources != null && resources.Length > 0)
      {
        filterhtmlinjectionvariable[] filterhtmlinjectionvariableArray = new filterhtmlinjectionvariable[resources.Length];
        for (int index = 0; index < resources.Length; ++index)
        {
          filterhtmlinjectionvariableArray[index] = new filterhtmlinjectionvariable();
          filterhtmlinjectionvariableArray[index].variable = resources[index].variable;
        }
        baseResponses = base_resource.delete_bulk_request(client, (base_resource[]) filterhtmlinjectionvariableArray);
      }
      return baseResponses;
    }

    public static base_response update(
      nitro_service client,
      filterhtmlinjectionvariable resource)
    {
      return new filterhtmlinjectionvariable()
      {
        variable = resource.variable,
        value = resource.value
      }.update_resource(client);
    }

    public static base_responses update(
      nitro_service client,
      filterhtmlinjectionvariable[] resources)
    {
      base_responses baseResponses = (base_responses) null;
      if (resources != null && resources.Length > 0)
      {
        filterhtmlinjectionvariable[] filterhtmlinjectionvariableArray = new filterhtmlinjectionvariable[resources.Length];
        for (int index = 0; index < resources.Length; ++index)
        {
          filterhtmlinjectionvariableArray[index] = new filterhtmlinjectionvariable();
          filterhtmlinjectionvariableArray[index].variable = resources[index].variable;
          filterhtmlinjectionvariableArray[index].value = resources[index].value;
        }
        baseResponses = base_resource.update_bulk_request(client, (base_resource[]) filterhtmlinjectionvariableArray);
      }
      return baseResponses;
    }

    public static base_response unset(
      nitro_service client,
      string variable,
      string[] args)
    {
      return new filterhtmlinjectionvariable()
      {
        variable = variable
      }.unset_resource(client, args);
    }

    public static base_response unset(
      nitro_service client,
      filterhtmlinjectionvariable resource,
      string[] args)
    {
      return new filterhtmlinjectionvariable()
      {
        variable = resource.variable
      }.unset_resource(client, args);
    }

    public static base_responses unset(
      nitro_service client,
      string[] variable,
      string[] args)
    {
      base_responses baseResponses = (base_responses) null;
      if (variable != null && variable.Length > 0)
      {
        filterhtmlinjectionvariable[] filterhtmlinjectionvariableArray = new filterhtmlinjectionvariable[variable.Length];
        for (int index = 0; index < variable.Length; ++index)
        {
          filterhtmlinjectionvariableArray[index] = new filterhtmlinjectionvariable();
          filterhtmlinjectionvariableArray[index].variable = variable[index];
        }
        baseResponses = base_resource.unset_bulk_request(client, (base_resource[]) filterhtmlinjectionvariableArray, args);
      }
      return baseResponses;
    }

    public static base_responses unset(
      nitro_service client,
      filterhtmlinjectionvariable[] resources,
      string[] args)
    {
      base_responses baseResponses = (base_responses) null;
      if (resources != null && resources.Length > 0)
      {
        filterhtmlinjectionvariable[] filterhtmlinjectionvariableArray = new filterhtmlinjectionvariable[resources.Length];
        for (int index = 0; index < resources.Length; ++index)
        {
          filterhtmlinjectionvariableArray[index] = new filterhtmlinjectionvariable();
          filterhtmlinjectionvariableArray[index].variable = resources[index].variable;
        }
        baseResponses = base_resource.unset_bulk_request(client, (base_resource[]) filterhtmlinjectionvariableArray, args);
      }
      return baseResponses;
    }

    public static filterhtmlinjectionvariable[] get(nitro_service service) => (filterhtmlinjectionvariable[]) new filterhtmlinjectionvariable().get_resources(service, (options) null);

    public static filterhtmlinjectionvariable[] get(
      nitro_service service,
      options option)
    {
      return (filterhtmlinjectionvariable[]) new filterhtmlinjectionvariable().get_resources(service, option);
    }

    public static filterhtmlinjectionvariable get(
      nitro_service service,
      string variable)
    {
      return (filterhtmlinjectionvariable) new filterhtmlinjectionvariable()
      {
        variable = variable
      }.get_resource(service);
    }

    public static filterhtmlinjectionvariable[] get(
      nitro_service service,
      string[] variable)
    {
      if (variable == null || variable.Length <= 0)
        return (filterhtmlinjectionvariable[]) null;
      filterhtmlinjectionvariable[] filterhtmlinjectionvariableArray1 = new filterhtmlinjectionvariable[variable.Length];
      filterhtmlinjectionvariable[] filterhtmlinjectionvariableArray2 = new filterhtmlinjectionvariable[variable.Length];
      for (int index = 0; index < variable.Length; ++index)
      {
        filterhtmlinjectionvariableArray2[index] = new filterhtmlinjectionvariable();
        filterhtmlinjectionvariableArray2[index].variable = variable[index];
        filterhtmlinjectionvariableArray1[index] = (filterhtmlinjectionvariable) filterhtmlinjectionvariableArray2[index].get_resource(service);
      }
      return filterhtmlinjectionvariableArray1;
    }

    public static filterhtmlinjectionvariable[] get_filtered(
      nitro_service service,
      string filter)
    {
      filterhtmlinjectionvariable filterhtmlinjectionvariable = new filterhtmlinjectionvariable();
      options option = new options();
      option.set_filter(filter);
      return (filterhtmlinjectionvariable[]) filterhtmlinjectionvariable.getfiltered(service, option);
    }

    public static filterhtmlinjectionvariable[] get_filtered(
      nitro_service service,
      filtervalue[] filter)
    {
      filterhtmlinjectionvariable filterhtmlinjectionvariable = new filterhtmlinjectionvariable();
      options option = new options();
      option.set_filter(filter);
      return (filterhtmlinjectionvariable[]) filterhtmlinjectionvariable.getfiltered(service, option);
    }

    public static uint count(nitro_service service)
    {
      filterhtmlinjectionvariable filterhtmlinjectionvariable = new filterhtmlinjectionvariable();
      options option = new options();
      option.set_count(true);
      filterhtmlinjectionvariable[] resources = (filterhtmlinjectionvariable[]) filterhtmlinjectionvariable.get_resources(service, option);
      return resources != null && resources.Length > 0 ? resources[0].__count.Value : 0U;
    }

    public static uint count_filtered(nitro_service service, string filter)
    {
      filterhtmlinjectionvariable filterhtmlinjectionvariable = new filterhtmlinjectionvariable();
      options option = new options();
      option.set_count(true);
      option.set_filter(filter);
      filterhtmlinjectionvariable[] filterhtmlinjectionvariableArray = (filterhtmlinjectionvariable[]) filterhtmlinjectionvariable.getfiltered(service, option);
      return filterhtmlinjectionvariableArray != null && filterhtmlinjectionvariableArray.Length > 0 ? filterhtmlinjectionvariableArray[0].__count.Value : 0U;
    }

    public static uint count_filtered(nitro_service service, filtervalue[] filter)
    {
      filterhtmlinjectionvariable filterhtmlinjectionvariable = new filterhtmlinjectionvariable();
      options option = new options();
      option.set_count(true);
      option.set_filter(filter);
      filterhtmlinjectionvariable[] filterhtmlinjectionvariableArray = (filterhtmlinjectionvariable[]) filterhtmlinjectionvariable.getfiltered(service, option);
      return filterhtmlinjectionvariableArray != null && filterhtmlinjectionvariableArray.Length > 0 ? filterhtmlinjectionvariableArray[0].__count.Value : 0U;
    }

    private class filterhtmlinjectionvariable_response : base_response
    {
      public filterhtmlinjectionvariable[] filterhtmlinjectionvariable = (filterhtmlinjectionvariable[]) null;
    }

    public static class builtinEnum
    {
      public const string MODIFIABLE = "MODIFIABLE";
      public const string DELETABLE = "DELETABLE";
      public const string IMMUTABLE = "IMMUTABLE";
      public const string PARTITION_ALL = "PARTITION_ALL";
    }

    public static class typeEnum
    {
      public const string System_internal = "System internal";
      public const string User_defined = "User defined";
    }
  }
}
