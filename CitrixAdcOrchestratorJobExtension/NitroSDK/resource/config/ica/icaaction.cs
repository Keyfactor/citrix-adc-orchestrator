// Decompiled with JetBrains decompiler
// Type: com.citrix.netscaler.nitro.resource.config.ica.icaaction
// Assembly: nitro, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 6CF5DDEF-E052-4F9D-953F-6644F8378A66


using com.citrix.netscaler.nitro.exception;
using com.citrix.netscaler.nitro.resource.Base;
using com.citrix.netscaler.nitro.service;
using com.citrix.netscaler.nitro.util;

namespace com.citrix.netscaler.nitro.resource.config.ica
{
  public class icaaction : base_resource
  {
    private string nameField = (string) null;
    private string accessprofilenameField = (string) null;
    private string newnameField = (string) null;
    private long? hitsField = new long?();
    private uint? referencecountField = new uint?();
    private long? undefhitsField = new long?();
    private string[] builtinField = (string[]) null;
    private bool? isdefaultField = new bool?();
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

    public string accessprofilename
    {
      get => this.accessprofilenameField;
      set => this.accessprofilenameField = value;
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

    public long? undefhits
    {
      get => this.undefhitsField;
      private set => this.undefhitsField = value;
    }

    public string[] builtin
    {
      get => this.builtinField;
      private set => this.builtinField = value;
    }

    public bool? isdefault
    {
      get => this.isdefaultField;
      private set => this.isdefaultField = value;
    }

    internal override base_resource[] get_nitro_response(
      nitro_service service,
      string response)
    {
      icaaction.icaaction_response icaactionResponse = new icaaction.icaaction_response();
      icaaction.icaaction_response resource = (icaaction.icaaction_response) service.get_payload_formatter().string_to_resource(icaactionResponse.GetType(), response);
      if (resource.errorcode != 0)
      {
        if (resource.errorcode == 444)
          service.clear_session();
        if (resource.severity == null)
          throw new nitro_exception(resource.message, resource.errorcode);
        if (resource.severity.Equals("ERROR"))
          throw new nitro_exception(resource.message, resource.errorcode);
      }
      return (base_resource[]) resource.icaaction;
    }

    internal override string get_object_name() => this.name;

    public static base_response add(nitro_service client, icaaction resource) => new icaaction()
    {
      name = resource.name,
      accessprofilename = resource.accessprofilename
    }.add_resource(client);

    public static base_responses add(nitro_service client, icaaction[] resources)
    {
      base_responses baseResponses = (base_responses) null;
      if (resources != null && resources.Length > 0)
      {
        icaaction[] icaactionArray = new icaaction[resources.Length];
        for (int index = 0; index < resources.Length; ++index)
        {
          icaactionArray[index] = new icaaction();
          icaactionArray[index].name = resources[index].name;
          icaactionArray[index].accessprofilename = resources[index].accessprofilename;
        }
        baseResponses = base_resource.add_bulk_request(client, (base_resource[]) icaactionArray);
      }
      return baseResponses;
    }

    public static base_response delete(nitro_service client, string name) => new icaaction()
    {
      name = name
    }.delete_resource(client);

    public static base_response delete(nitro_service client, icaaction resource) => new icaaction()
    {
      name = resource.name
    }.delete_resource(client);

    public static base_responses delete(nitro_service client, string[] name)
    {
      base_responses baseResponses = (base_responses) null;
      if (name != null && name.Length > 0)
      {
        icaaction[] icaactionArray = new icaaction[name.Length];
        for (int index = 0; index < name.Length; ++index)
        {
          icaactionArray[index] = new icaaction();
          icaactionArray[index].name = name[index];
        }
        baseResponses = base_resource.delete_bulk_request(client, (base_resource[]) icaactionArray);
      }
      return baseResponses;
    }

    public static base_responses delete(nitro_service client, icaaction[] resources)
    {
      base_responses baseResponses = (base_responses) null;
      if (resources != null && resources.Length > 0)
      {
        icaaction[] icaactionArray = new icaaction[resources.Length];
        for (int index = 0; index < resources.Length; ++index)
        {
          icaactionArray[index] = new icaaction();
          icaactionArray[index].name = resources[index].name;
        }
        baseResponses = base_resource.delete_bulk_request(client, (base_resource[]) icaactionArray);
      }
      return baseResponses;
    }

    public static base_response update(nitro_service client, icaaction resource) => new icaaction()
    {
      name = resource.name,
      accessprofilename = resource.accessprofilename
    }.update_resource(client);

    public static base_responses update(nitro_service client, icaaction[] resources)
    {
      base_responses baseResponses = (base_responses) null;
      if (resources != null && resources.Length > 0)
      {
        icaaction[] icaactionArray = new icaaction[resources.Length];
        for (int index = 0; index < resources.Length; ++index)
        {
          icaactionArray[index] = new icaaction();
          icaactionArray[index].name = resources[index].name;
          icaactionArray[index].accessprofilename = resources[index].accessprofilename;
        }
        baseResponses = base_resource.update_bulk_request(client, (base_resource[]) icaactionArray);
      }
      return baseResponses;
    }

    public static base_response rename(
      nitro_service client,
      icaaction resource,
      string new_name)
    {
      return new icaaction()
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
      return new icaaction()
      {
        name = name,
        newname = new_name
      }.rename_resource(client);
    }

    public static icaaction[] get(nitro_service service) => (icaaction[]) new icaaction().get_resources(service, (options) null);

    public static icaaction[] get(nitro_service service, options option) => (icaaction[]) new icaaction().get_resources(service, option);

    public static icaaction get(nitro_service service, string name) => (icaaction) new icaaction()
    {
      name = name
    }.get_resource(service);

    public static icaaction[] get(nitro_service service, string[] name)
    {
      if (name == null || name.Length <= 0)
        return (icaaction[]) null;
      icaaction[] icaactionArray1 = new icaaction[name.Length];
      icaaction[] icaactionArray2 = new icaaction[name.Length];
      for (int index = 0; index < name.Length; ++index)
      {
        icaactionArray2[index] = new icaaction();
        icaactionArray2[index].name = name[index];
        icaactionArray1[index] = (icaaction) icaactionArray2[index].get_resource(service);
      }
      return icaactionArray1;
    }

    public static icaaction[] get_filtered(nitro_service service, string filter)
    {
      icaaction icaaction = new icaaction();
      options option = new options();
      option.set_filter(filter);
      return (icaaction[]) icaaction.getfiltered(service, option);
    }

    public static icaaction[] get_filtered(nitro_service service, filtervalue[] filter)
    {
      icaaction icaaction = new icaaction();
      options option = new options();
      option.set_filter(filter);
      return (icaaction[]) icaaction.getfiltered(service, option);
    }

    public static uint count(nitro_service service)
    {
      icaaction icaaction = new icaaction();
      options option = new options();
      option.set_count(true);
      icaaction[] resources = (icaaction[]) icaaction.get_resources(service, option);
      return resources != null && resources.Length > 0 ? resources[0].__count.Value : 0U;
    }

    public static uint count_filtered(nitro_service service, string filter)
    {
      icaaction icaaction = new icaaction();
      options option = new options();
      option.set_count(true);
      option.set_filter(filter);
      icaaction[] icaactionArray = (icaaction[]) icaaction.getfiltered(service, option);
      return icaactionArray != null && icaactionArray.Length > 0 ? icaactionArray[0].__count.Value : 0U;
    }

    public static uint count_filtered(nitro_service service, filtervalue[] filter)
    {
      icaaction icaaction = new icaaction();
      options option = new options();
      option.set_count(true);
      option.set_filter(filter);
      icaaction[] icaactionArray = (icaaction[]) icaaction.getfiltered(service, option);
      return icaactionArray != null && icaactionArray.Length > 0 ? icaactionArray[0].__count.Value : 0U;
    }

    private class icaaction_response : base_response
    {
      public icaaction[] icaaction = (icaaction[]) null;
    }

    public static class builtinEnum
    {
      public const string MODIFIABLE = "MODIFIABLE";
      public const string DELETABLE = "DELETABLE";
      public const string IMMUTABLE = "IMMUTABLE";
      public const string PARTITION_ALL = "PARTITION_ALL";
    }
  }
}
