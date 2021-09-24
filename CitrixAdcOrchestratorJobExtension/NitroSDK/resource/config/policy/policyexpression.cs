// Decompiled with JetBrains decompiler
// Type: com.citrix.netscaler.nitro.resource.config.policy.policyexpression
// Assembly: nitro, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 6CF5DDEF-E052-4F9D-953F-6644F8378A66


using com.citrix.netscaler.nitro.exception;
using com.citrix.netscaler.nitro.resource.Base;
using com.citrix.netscaler.nitro.service;
using com.citrix.netscaler.nitro.util;

namespace com.citrix.netscaler.nitro.resource.config.policy
{
  public class policyexpression : base_resource
  {
    private string nameField = (string) null;
    private string valueField = (string) null;
    private string descriptionField = (string) null;
    private string commentField = (string) null;
    private string clientsecuritymessageField = (string) null;
    private string typeField = (string) null;
    private uint? hitsField = new uint?();
    private uint? pihitsField = new uint?();
    private string type1Field = (string) null;
    private bool? isdefaultField = new bool?();
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

    public string value
    {
      get => this.valueField;
      set => this.valueField = value;
    }

    public string description
    {
      get => this.descriptionField;
      set => this.descriptionField = value;
    }

    public string comment
    {
      get => this.commentField;
      set => this.commentField = value;
    }

    public string clientsecuritymessage
    {
      get => this.clientsecuritymessageField;
      set => this.clientsecuritymessageField = value;
    }

    public string type
    {
      get => this.typeField;
      set => this.typeField = value;
    }

    public uint? hits
    {
      get => this.hitsField;
      private set => this.hitsField = value;
    }

    public uint? pihits
    {
      get => this.pihitsField;
      private set => this.pihitsField = value;
    }

    public string type1
    {
      get => this.type1Field;
      private set => this.type1Field = value;
    }

    public bool? isdefault
    {
      get => this.isdefaultField;
      private set => this.isdefaultField = value;
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
      policyexpression.policyexpression_response policyexpressionResponse = new policyexpression.policyexpression_response();
      policyexpression.policyexpression_response resource = (policyexpression.policyexpression_response) service.get_payload_formatter().string_to_resource(policyexpressionResponse.GetType(), response);
      if (resource.errorcode != 0)
      {
        if (resource.errorcode == 444)
          service.clear_session();
        if (resource.severity == null)
          throw new nitro_exception(resource.message, resource.errorcode);
        if (resource.severity.Equals("ERROR"))
          throw new nitro_exception(resource.message, resource.errorcode);
      }
      return (base_resource[]) resource.policyexpression;
    }

    internal override string get_object_name() => this.name;

    public static base_response add(nitro_service client, policyexpression resource) => new policyexpression()
    {
      name = resource.name,
      value = resource.value,
      description = resource.description,
      comment = resource.comment,
      clientsecuritymessage = resource.clientsecuritymessage
    }.add_resource(client);

    public static base_responses add(
      nitro_service client,
      policyexpression[] resources)
    {
      base_responses baseResponses = (base_responses) null;
      if (resources != null && resources.Length > 0)
      {
        policyexpression[] policyexpressionArray = new policyexpression[resources.Length];
        for (int index = 0; index < resources.Length; ++index)
        {
          policyexpressionArray[index] = new policyexpression();
          policyexpressionArray[index].name = resources[index].name;
          policyexpressionArray[index].value = resources[index].value;
          policyexpressionArray[index].description = resources[index].description;
          policyexpressionArray[index].comment = resources[index].comment;
          policyexpressionArray[index].clientsecuritymessage = resources[index].clientsecuritymessage;
        }
        baseResponses = base_resource.add_bulk_request(client, (base_resource[]) policyexpressionArray);
      }
      return baseResponses;
    }

    public static base_response delete(nitro_service client, string name) => new policyexpression()
    {
      name = name
    }.delete_resource(client);

    public static base_response delete(nitro_service client, policyexpression resource) => new policyexpression()
    {
      name = resource.name
    }.delete_resource(client);

    public static base_responses delete(nitro_service client, string[] name)
    {
      base_responses baseResponses = (base_responses) null;
      if (name != null && name.Length > 0)
      {
        policyexpression[] policyexpressionArray = new policyexpression[name.Length];
        for (int index = 0; index < name.Length; ++index)
        {
          policyexpressionArray[index] = new policyexpression();
          policyexpressionArray[index].name = name[index];
        }
        baseResponses = base_resource.delete_bulk_request(client, (base_resource[]) policyexpressionArray);
      }
      return baseResponses;
    }

    public static base_responses delete(
      nitro_service client,
      policyexpression[] resources)
    {
      base_responses baseResponses = (base_responses) null;
      if (resources != null && resources.Length > 0)
      {
        policyexpression[] policyexpressionArray = new policyexpression[resources.Length];
        for (int index = 0; index < resources.Length; ++index)
        {
          policyexpressionArray[index] = new policyexpression();
          policyexpressionArray[index].name = resources[index].name;
        }
        baseResponses = base_resource.delete_bulk_request(client, (base_resource[]) policyexpressionArray);
      }
      return baseResponses;
    }

    public static base_response update(nitro_service client, policyexpression resource) => new policyexpression()
    {
      name = resource.name,
      value = resource.value,
      description = resource.description,
      comment = resource.comment,
      clientsecuritymessage = resource.clientsecuritymessage
    }.update_resource(client);

    public static base_responses update(
      nitro_service client,
      policyexpression[] resources)
    {
      base_responses baseResponses = (base_responses) null;
      if (resources != null && resources.Length > 0)
      {
        policyexpression[] policyexpressionArray = new policyexpression[resources.Length];
        for (int index = 0; index < resources.Length; ++index)
        {
          policyexpressionArray[index] = new policyexpression();
          policyexpressionArray[index].name = resources[index].name;
          policyexpressionArray[index].value = resources[index].value;
          policyexpressionArray[index].description = resources[index].description;
          policyexpressionArray[index].comment = resources[index].comment;
          policyexpressionArray[index].clientsecuritymessage = resources[index].clientsecuritymessage;
        }
        baseResponses = base_resource.update_bulk_request(client, (base_resource[]) policyexpressionArray);
      }
      return baseResponses;
    }

    public static base_response unset(
      nitro_service client,
      string name,
      string[] args)
    {
      return new policyexpression() { name = name }.unset_resource(client, args);
    }

    public static base_response unset(
      nitro_service client,
      policyexpression resource,
      string[] args)
    {
      return new policyexpression() { name = resource.name }.unset_resource(client, args);
    }

    public static base_responses unset(
      nitro_service client,
      string[] name,
      string[] args)
    {
      base_responses baseResponses = (base_responses) null;
      if (name != null && name.Length > 0)
      {
        policyexpression[] policyexpressionArray = new policyexpression[name.Length];
        for (int index = 0; index < name.Length; ++index)
        {
          policyexpressionArray[index] = new policyexpression();
          policyexpressionArray[index].name = name[index];
        }
        baseResponses = base_resource.unset_bulk_request(client, (base_resource[]) policyexpressionArray, args);
      }
      return baseResponses;
    }

    public static base_responses unset(
      nitro_service client,
      policyexpression[] resources,
      string[] args)
    {
      base_responses baseResponses = (base_responses) null;
      if (resources != null && resources.Length > 0)
      {
        policyexpression[] policyexpressionArray = new policyexpression[resources.Length];
        for (int index = 0; index < resources.Length; ++index)
        {
          policyexpressionArray[index] = new policyexpression();
          policyexpressionArray[index].name = resources[index].name;
        }
        baseResponses = base_resource.unset_bulk_request(client, (base_resource[]) policyexpressionArray, args);
      }
      return baseResponses;
    }

    public static policyexpression[] get(nitro_service service) => (policyexpression[]) new policyexpression().get_resources(service, (options) null);

    public static policyexpression[] get(nitro_service service, options option) => (policyexpression[]) new policyexpression().get_resources(service, option);

    public static policyexpression[] get(
      nitro_service service,
      policyexpression_args args)
    {
      policyexpression policyexpression = new policyexpression();
      options option = new options();
      option.set_args(nitro_util.object_to_string_withoutquotes((object) args));
      return (policyexpression[]) policyexpression.get_resources(service, option);
    }

    public static policyexpression get(nitro_service service, string name) => (policyexpression) new policyexpression()
    {
      name = name
    }.get_resource(service);

    public static policyexpression[] get(nitro_service service, string[] name)
    {
      if (name == null || name.Length <= 0)
        return (policyexpression[]) null;
      policyexpression[] policyexpressionArray1 = new policyexpression[name.Length];
      policyexpression[] policyexpressionArray2 = new policyexpression[name.Length];
      for (int index = 0; index < name.Length; ++index)
      {
        policyexpressionArray2[index] = new policyexpression();
        policyexpressionArray2[index].name = name[index];
        policyexpressionArray1[index] = (policyexpression) policyexpressionArray2[index].get_resource(service);
      }
      return policyexpressionArray1;
    }

    public static policyexpression[] get_filtered(
      nitro_service service,
      string filter)
    {
      policyexpression policyexpression = new policyexpression();
      options option = new options();
      option.set_filter(filter);
      return (policyexpression[]) policyexpression.getfiltered(service, option);
    }

    public static policyexpression[] get_filtered(
      nitro_service service,
      filtervalue[] filter)
    {
      policyexpression policyexpression = new policyexpression();
      options option = new options();
      option.set_filter(filter);
      return (policyexpression[]) policyexpression.getfiltered(service, option);
    }

    public static uint count(nitro_service service)
    {
      policyexpression policyexpression = new policyexpression();
      options option = new options();
      option.set_count(true);
      policyexpression[] resources = (policyexpression[]) policyexpression.get_resources(service, option);
      return resources != null && resources.Length > 0 ? resources[0].__count.Value : 0U;
    }

    public static uint count_filtered(nitro_service service, string filter)
    {
      policyexpression policyexpression = new policyexpression();
      options option = new options();
      option.set_count(true);
      option.set_filter(filter);
      policyexpression[] policyexpressionArray = (policyexpression[]) policyexpression.getfiltered(service, option);
      return policyexpressionArray != null && policyexpressionArray.Length > 0 ? policyexpressionArray[0].__count.Value : 0U;
    }

    public static uint count_filtered(nitro_service service, filtervalue[] filter)
    {
      policyexpression policyexpression = new policyexpression();
      options option = new options();
      option.set_count(true);
      option.set_filter(filter);
      policyexpression[] policyexpressionArray = (policyexpression[]) policyexpression.getfiltered(service, option);
      return policyexpressionArray != null && policyexpressionArray.Length > 0 ? policyexpressionArray[0].__count.Value : 0U;
    }

    private class policyexpression_response : base_response
    {
      public policyexpression[] policyexpression = (policyexpression[]) null;
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
      public const string CLASSIC = "CLASSIC";
      public const string ADVANCED = "ADVANCED";
    }

    public static class type1Enum
    {
      public const string CLASSIC = "CLASSIC";
      public const string ADVANCED = "ADVANCED";
    }
  }
}
