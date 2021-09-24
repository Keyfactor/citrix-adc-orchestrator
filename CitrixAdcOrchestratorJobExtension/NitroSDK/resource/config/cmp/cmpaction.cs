// Decompiled with JetBrains decompiler
// Type: com.citrix.netscaler.nitro.resource.config.cmp.cmpaction
// Assembly: nitro, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 6CF5DDEF-E052-4F9D-953F-6644F8378A66


using com.citrix.netscaler.nitro.exception;
using com.citrix.netscaler.nitro.resource.Base;
using com.citrix.netscaler.nitro.service;
using com.citrix.netscaler.nitro.util;

namespace com.citrix.netscaler.nitro.resource.config.cmp
{
  public class cmpaction : base_resource
  {
    private string nameField = (string) null;
    private string cmptypeField = (string) null;
    private string addvaryheaderField = (string) null;
    private string varyheadervalueField = (string) null;
    private string deltatypeField = (string) null;
    private string newnameField = (string) null;
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

    public string cmptype
    {
      get => this.cmptypeField;
      set => this.cmptypeField = value;
    }

    public string addvaryheader
    {
      get => this.addvaryheaderField;
      set => this.addvaryheaderField = value;
    }

    public string varyheadervalue
    {
      get => this.varyheadervalueField;
      set => this.varyheadervalueField = value;
    }

    public string deltatype
    {
      get => this.deltatypeField;
      set => this.deltatypeField = value;
    }

    public string newname
    {
      get => this.newnameField;
      set => this.newnameField = value;
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
      cmpaction.cmpaction_response cmpactionResponse = new cmpaction.cmpaction_response();
      cmpaction.cmpaction_response resource = (cmpaction.cmpaction_response) service.get_payload_formatter().string_to_resource(cmpactionResponse.GetType(), response);
      if (resource.errorcode != 0)
      {
        if (resource.errorcode == 444)
          service.clear_session();
        if (resource.severity == null)
          throw new nitro_exception(resource.message, resource.errorcode);
        if (resource.severity.Equals("ERROR"))
          throw new nitro_exception(resource.message, resource.errorcode);
      }
      return (base_resource[]) resource.cmpaction;
    }

    internal override string get_object_name() => this.name;

    public static base_response add(nitro_service client, cmpaction resource) => new cmpaction()
    {
      name = resource.name,
      cmptype = resource.cmptype,
      addvaryheader = resource.addvaryheader,
      varyheadervalue = resource.varyheadervalue,
      deltatype = resource.deltatype
    }.add_resource(client);

    public static base_responses add(nitro_service client, cmpaction[] resources)
    {
      base_responses baseResponses = (base_responses) null;
      if (resources != null && resources.Length > 0)
      {
        cmpaction[] cmpactionArray = new cmpaction[resources.Length];
        for (int index = 0; index < resources.Length; ++index)
        {
          cmpactionArray[index] = new cmpaction();
          cmpactionArray[index].name = resources[index].name;
          cmpactionArray[index].cmptype = resources[index].cmptype;
          cmpactionArray[index].addvaryheader = resources[index].addvaryheader;
          cmpactionArray[index].varyheadervalue = resources[index].varyheadervalue;
          cmpactionArray[index].deltatype = resources[index].deltatype;
        }
        baseResponses = base_resource.add_bulk_request(client, (base_resource[]) cmpactionArray);
      }
      return baseResponses;
    }

    public static base_response delete(nitro_service client, string name) => new cmpaction()
    {
      name = name
    }.delete_resource(client);

    public static base_response delete(nitro_service client, cmpaction resource) => new cmpaction()
    {
      name = resource.name
    }.delete_resource(client);

    public static base_responses delete(nitro_service client, string[] name)
    {
      base_responses baseResponses = (base_responses) null;
      if (name != null && name.Length > 0)
      {
        cmpaction[] cmpactionArray = new cmpaction[name.Length];
        for (int index = 0; index < name.Length; ++index)
        {
          cmpactionArray[index] = new cmpaction();
          cmpactionArray[index].name = name[index];
        }
        baseResponses = base_resource.delete_bulk_request(client, (base_resource[]) cmpactionArray);
      }
      return baseResponses;
    }

    public static base_responses delete(nitro_service client, cmpaction[] resources)
    {
      base_responses baseResponses = (base_responses) null;
      if (resources != null && resources.Length > 0)
      {
        cmpaction[] cmpactionArray = new cmpaction[resources.Length];
        for (int index = 0; index < resources.Length; ++index)
        {
          cmpactionArray[index] = new cmpaction();
          cmpactionArray[index].name = resources[index].name;
        }
        baseResponses = base_resource.delete_bulk_request(client, (base_resource[]) cmpactionArray);
      }
      return baseResponses;
    }

    public static base_response update(nitro_service client, cmpaction resource) => new cmpaction()
    {
      name = resource.name,
      cmptype = resource.cmptype,
      addvaryheader = resource.addvaryheader,
      varyheadervalue = resource.varyheadervalue
    }.update_resource(client);

    public static base_responses update(nitro_service client, cmpaction[] resources)
    {
      base_responses baseResponses = (base_responses) null;
      if (resources != null && resources.Length > 0)
      {
        cmpaction[] cmpactionArray = new cmpaction[resources.Length];
        for (int index = 0; index < resources.Length; ++index)
        {
          cmpactionArray[index] = new cmpaction();
          cmpactionArray[index].name = resources[index].name;
          cmpactionArray[index].cmptype = resources[index].cmptype;
          cmpactionArray[index].addvaryheader = resources[index].addvaryheader;
          cmpactionArray[index].varyheadervalue = resources[index].varyheadervalue;
        }
        baseResponses = base_resource.update_bulk_request(client, (base_resource[]) cmpactionArray);
      }
      return baseResponses;
    }

    public static base_response unset(
      nitro_service client,
      string name,
      string[] args)
    {
      return new cmpaction() { name = name }.unset_resource(client, args);
    }

    public static base_response unset(
      nitro_service client,
      cmpaction resource,
      string[] args)
    {
      return new cmpaction() { name = resource.name }.unset_resource(client, args);
    }

    public static base_responses unset(
      nitro_service client,
      string[] name,
      string[] args)
    {
      base_responses baseResponses = (base_responses) null;
      if (name != null && name.Length > 0)
      {
        cmpaction[] cmpactionArray = new cmpaction[name.Length];
        for (int index = 0; index < name.Length; ++index)
        {
          cmpactionArray[index] = new cmpaction();
          cmpactionArray[index].name = name[index];
        }
        baseResponses = base_resource.unset_bulk_request(client, (base_resource[]) cmpactionArray, args);
      }
      return baseResponses;
    }

    public static base_responses unset(
      nitro_service client,
      cmpaction[] resources,
      string[] args)
    {
      base_responses baseResponses = (base_responses) null;
      if (resources != null && resources.Length > 0)
      {
        cmpaction[] cmpactionArray = new cmpaction[resources.Length];
        for (int index = 0; index < resources.Length; ++index)
        {
          cmpactionArray[index] = new cmpaction();
          cmpactionArray[index].name = resources[index].name;
        }
        baseResponses = base_resource.unset_bulk_request(client, (base_resource[]) cmpactionArray, args);
      }
      return baseResponses;
    }

    public static base_response rename(
      nitro_service client,
      cmpaction resource,
      string new_name)
    {
      return new cmpaction()
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
      return new cmpaction()
      {
        name = name,
        newname = new_name
      }.rename_resource(client);
    }

    public static cmpaction[] get(nitro_service service) => (cmpaction[]) new cmpaction().get_resources(service, (options) null);

    public static cmpaction[] get(nitro_service service, options option) => (cmpaction[]) new cmpaction().get_resources(service, option);

    public static cmpaction get(nitro_service service, string name) => (cmpaction) new cmpaction()
    {
      name = name
    }.get_resource(service);

    public static cmpaction[] get(nitro_service service, string[] name)
    {
      if (name == null || name.Length <= 0)
        return (cmpaction[]) null;
      cmpaction[] cmpactionArray1 = new cmpaction[name.Length];
      cmpaction[] cmpactionArray2 = new cmpaction[name.Length];
      for (int index = 0; index < name.Length; ++index)
      {
        cmpactionArray2[index] = new cmpaction();
        cmpactionArray2[index].name = name[index];
        cmpactionArray1[index] = (cmpaction) cmpactionArray2[index].get_resource(service);
      }
      return cmpactionArray1;
    }

    public static cmpaction[] get_filtered(nitro_service service, string filter)
    {
      cmpaction cmpaction = new cmpaction();
      options option = new options();
      option.set_filter(filter);
      return (cmpaction[]) cmpaction.getfiltered(service, option);
    }

    public static cmpaction[] get_filtered(nitro_service service, filtervalue[] filter)
    {
      cmpaction cmpaction = new cmpaction();
      options option = new options();
      option.set_filter(filter);
      return (cmpaction[]) cmpaction.getfiltered(service, option);
    }

    public static uint count(nitro_service service)
    {
      cmpaction cmpaction = new cmpaction();
      options option = new options();
      option.set_count(true);
      cmpaction[] resources = (cmpaction[]) cmpaction.get_resources(service, option);
      return resources != null && resources.Length > 0 ? resources[0].__count.Value : 0U;
    }

    public static uint count_filtered(nitro_service service, string filter)
    {
      cmpaction cmpaction = new cmpaction();
      options option = new options();
      option.set_count(true);
      option.set_filter(filter);
      cmpaction[] cmpactionArray = (cmpaction[]) cmpaction.getfiltered(service, option);
      return cmpactionArray != null && cmpactionArray.Length > 0 ? cmpactionArray[0].__count.Value : 0U;
    }

    public static uint count_filtered(nitro_service service, filtervalue[] filter)
    {
      cmpaction cmpaction = new cmpaction();
      options option = new options();
      option.set_count(true);
      option.set_filter(filter);
      cmpaction[] cmpactionArray = (cmpaction[]) cmpaction.getfiltered(service, option);
      return cmpactionArray != null && cmpactionArray.Length > 0 ? cmpactionArray[0].__count.Value : 0U;
    }

    private class cmpaction_response : base_response
    {
      public cmpaction[] cmpaction = (cmpaction[]) null;
    }

    public static class cmptypeEnum
    {
      public const string compress = "compress";
      public const string gzip = "gzip";
      public const string deflate = "deflate";
      public const string nocompress = "nocompress";
    }

    public static class builtinEnum
    {
      public const string MODIFIABLE = "MODIFIABLE";
      public const string DELETABLE = "DELETABLE";
      public const string IMMUTABLE = "IMMUTABLE";
      public const string PARTITION_ALL = "PARTITION_ALL";
    }

    public static class addvaryheaderEnum
    {
      public const string GLOBAL = "GLOBAL";
      public const string DISABLED = "DISABLED";
      public const string ENABLED = "ENABLED";
    }

    public static class deltatypeEnum
    {
      public const string PERURL = "PERURL";
      public const string PERPOLICY = "PERPOLICY";
    }
  }
}
