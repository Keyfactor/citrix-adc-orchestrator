// Decompiled with JetBrains decompiler
// Type: com.citrix.netscaler.nitro.resource.config.ns.nsvariable
// Assembly: nitro, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 6CF5DDEF-E052-4F9D-953F-6644F8378A66


using com.citrix.netscaler.nitro.exception;
using com.citrix.netscaler.nitro.resource.Base;
using com.citrix.netscaler.nitro.service;
using com.citrix.netscaler.nitro.util;

namespace com.citrix.netscaler.nitro.resource.config.ns
{
  public class nsvariable : base_resource
  {
    private string nameField = (string) null;
    private string typeField = (string) null;
    private string scopeField = (string) null;
    private string iffullField = (string) null;
    private string ifvaluetoobigField = (string) null;
    private string ifnovalueField = (string) null;
    private string initField = (string) null;
    private uint? expiresField = new uint?();
    private string commentField = (string) null;
    private uint? referencecountField = new uint?();
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

    public string scope
    {
      get => this.scopeField;
      set => this.scopeField = value;
    }

    public string iffull
    {
      get => this.iffullField;
      set => this.iffullField = value;
    }

    public string ifvaluetoobig
    {
      get => this.ifvaluetoobigField;
      set => this.ifvaluetoobigField = value;
    }

    public string ifnovalue
    {
      get => this.ifnovalueField;
      set => this.ifnovalueField = value;
    }

    public string init
    {
      get => this.initField;
      set => this.initField = value;
    }

    public uint? expires
    {
      get => this.expiresField;
      set => this.expiresField = value;
    }

    public string comment
    {
      get => this.commentField;
      set => this.commentField = value;
    }

    public uint? referencecount
    {
      get => this.referencecountField;
      private set => this.referencecountField = value;
    }

    internal override base_resource[] get_nitro_response(
      nitro_service service,
      string response)
    {
      nsvariable.nsvariable_response nsvariableResponse = new nsvariable.nsvariable_response();
      nsvariable.nsvariable_response resource = (nsvariable.nsvariable_response) service.get_payload_formatter().string_to_resource(nsvariableResponse.GetType(), response);
      if (resource.errorcode != 0)
      {
        if (resource.errorcode == 444)
          service.clear_session();
        if (resource.severity == null)
          throw new nitro_exception(resource.message, resource.errorcode);
        if (resource.severity.Equals("ERROR"))
          throw new nitro_exception(resource.message, resource.errorcode);
      }
      return (base_resource[]) resource.nsvariable;
    }

    internal override string get_object_name() => this.name;

    public static base_response add(nitro_service client, nsvariable resource) => new nsvariable()
    {
      name = resource.name,
      type = resource.type,
      scope = resource.scope,
      iffull = resource.iffull,
      ifvaluetoobig = resource.ifvaluetoobig,
      ifnovalue = resource.ifnovalue,
      init = resource.init,
      expires = resource.expires,
      comment = resource.comment
    }.add_resource(client);

    public static base_responses add(nitro_service client, nsvariable[] resources)
    {
      base_responses baseResponses = (base_responses) null;
      if (resources != null && resources.Length > 0)
      {
        nsvariable[] nsvariableArray = new nsvariable[resources.Length];
        for (int index = 0; index < resources.Length; ++index)
        {
          nsvariableArray[index] = new nsvariable();
          nsvariableArray[index].name = resources[index].name;
          nsvariableArray[index].type = resources[index].type;
          nsvariableArray[index].scope = resources[index].scope;
          nsvariableArray[index].iffull = resources[index].iffull;
          nsvariableArray[index].ifvaluetoobig = resources[index].ifvaluetoobig;
          nsvariableArray[index].ifnovalue = resources[index].ifnovalue;
          nsvariableArray[index].init = resources[index].init;
          nsvariableArray[index].expires = resources[index].expires;
          nsvariableArray[index].comment = resources[index].comment;
        }
        baseResponses = base_resource.add_bulk_request(client, (base_resource[]) nsvariableArray);
      }
      return baseResponses;
    }

    public static base_response update(nitro_service client, nsvariable resource) => new nsvariable()
    {
      name = resource.name,
      type = resource.type,
      iffull = resource.iffull,
      ifvaluetoobig = resource.ifvaluetoobig,
      ifnovalue = resource.ifnovalue,
      init = resource.init,
      expires = resource.expires,
      comment = resource.comment
    }.update_resource(client);

    public static base_responses update(nitro_service client, nsvariable[] resources)
    {
      base_responses baseResponses = (base_responses) null;
      if (resources != null && resources.Length > 0)
      {
        nsvariable[] nsvariableArray = new nsvariable[resources.Length];
        for (int index = 0; index < resources.Length; ++index)
        {
          nsvariableArray[index] = new nsvariable();
          nsvariableArray[index].name = resources[index].name;
          nsvariableArray[index].type = resources[index].type;
          nsvariableArray[index].iffull = resources[index].iffull;
          nsvariableArray[index].ifvaluetoobig = resources[index].ifvaluetoobig;
          nsvariableArray[index].ifnovalue = resources[index].ifnovalue;
          nsvariableArray[index].init = resources[index].init;
          nsvariableArray[index].expires = resources[index].expires;
          nsvariableArray[index].comment = resources[index].comment;
        }
        baseResponses = base_resource.update_bulk_request(client, (base_resource[]) nsvariableArray);
      }
      return baseResponses;
    }

    public static base_response unset(
      nitro_service client,
      string name,
      string[] args)
    {
      return new nsvariable() { name = name }.unset_resource(client, args);
    }

    public static base_response unset(
      nitro_service client,
      nsvariable resource,
      string[] args)
    {
      return new nsvariable() { name = resource.name }.unset_resource(client, args);
    }

    public static base_responses unset(
      nitro_service client,
      string[] name,
      string[] args)
    {
      base_responses baseResponses = (base_responses) null;
      if (name != null && name.Length > 0)
      {
        nsvariable[] nsvariableArray = new nsvariable[name.Length];
        for (int index = 0; index < name.Length; ++index)
        {
          nsvariableArray[index] = new nsvariable();
          nsvariableArray[index].name = name[index];
        }
        baseResponses = base_resource.unset_bulk_request(client, (base_resource[]) nsvariableArray, args);
      }
      return baseResponses;
    }

    public static base_responses unset(
      nitro_service client,
      nsvariable[] resources,
      string[] args)
    {
      base_responses baseResponses = (base_responses) null;
      if (resources != null && resources.Length > 0)
      {
        nsvariable[] nsvariableArray = new nsvariable[resources.Length];
        for (int index = 0; index < resources.Length; ++index)
        {
          nsvariableArray[index] = new nsvariable();
          nsvariableArray[index].name = resources[index].name;
        }
        baseResponses = base_resource.unset_bulk_request(client, (base_resource[]) nsvariableArray, args);
      }
      return baseResponses;
    }

    public static base_response delete(nitro_service client, string name) => new nsvariable()
    {
      name = name
    }.delete_resource(client);

    public static base_response delete(nitro_service client, nsvariable resource) => new nsvariable()
    {
      name = resource.name
    }.delete_resource(client);

    public static base_responses delete(nitro_service client, string[] name)
    {
      base_responses baseResponses = (base_responses) null;
      if (name != null && name.Length > 0)
      {
        nsvariable[] nsvariableArray = new nsvariable[name.Length];
        for (int index = 0; index < name.Length; ++index)
        {
          nsvariableArray[index] = new nsvariable();
          nsvariableArray[index].name = name[index];
        }
        baseResponses = base_resource.delete_bulk_request(client, (base_resource[]) nsvariableArray);
      }
      return baseResponses;
    }

    public static base_responses delete(nitro_service client, nsvariable[] resources)
    {
      base_responses baseResponses = (base_responses) null;
      if (resources != null && resources.Length > 0)
      {
        nsvariable[] nsvariableArray = new nsvariable[resources.Length];
        for (int index = 0; index < resources.Length; ++index)
        {
          nsvariableArray[index] = new nsvariable();
          nsvariableArray[index].name = resources[index].name;
        }
        baseResponses = base_resource.delete_bulk_request(client, (base_resource[]) nsvariableArray);
      }
      return baseResponses;
    }

    public static nsvariable[] get(nitro_service service) => (nsvariable[]) new nsvariable().get_resources(service, (options) null);

    public static nsvariable[] get(nitro_service service, options option) => (nsvariable[]) new nsvariable().get_resources(service, option);

    public static nsvariable get(nitro_service service, string name) => (nsvariable) new nsvariable()
    {
      name = name
    }.get_resource(service);

    public static nsvariable[] get(nitro_service service, string[] name)
    {
      if (name == null || name.Length <= 0)
        return (nsvariable[]) null;
      nsvariable[] nsvariableArray1 = new nsvariable[name.Length];
      nsvariable[] nsvariableArray2 = new nsvariable[name.Length];
      for (int index = 0; index < name.Length; ++index)
      {
        nsvariableArray2[index] = new nsvariable();
        nsvariableArray2[index].name = name[index];
        nsvariableArray1[index] = (nsvariable) nsvariableArray2[index].get_resource(service);
      }
      return nsvariableArray1;
    }

    public static nsvariable[] get_filtered(nitro_service service, string filter)
    {
      nsvariable nsvariable = new nsvariable();
      options option = new options();
      option.set_filter(filter);
      return (nsvariable[]) nsvariable.getfiltered(service, option);
    }

    public static nsvariable[] get_filtered(nitro_service service, filtervalue[] filter)
    {
      nsvariable nsvariable = new nsvariable();
      options option = new options();
      option.set_filter(filter);
      return (nsvariable[]) nsvariable.getfiltered(service, option);
    }

    public static uint count(nitro_service service)
    {
      nsvariable nsvariable = new nsvariable();
      options option = new options();
      option.set_count(true);
      nsvariable[] resources = (nsvariable[]) nsvariable.get_resources(service, option);
      return resources != null && resources.Length > 0 ? resources[0].__count.Value : 0U;
    }

    public static uint count_filtered(nitro_service service, string filter)
    {
      nsvariable nsvariable = new nsvariable();
      options option = new options();
      option.set_count(true);
      option.set_filter(filter);
      nsvariable[] nsvariableArray = (nsvariable[]) nsvariable.getfiltered(service, option);
      return nsvariableArray != null && nsvariableArray.Length > 0 ? nsvariableArray[0].__count.Value : 0U;
    }

    public static uint count_filtered(nitro_service service, filtervalue[] filter)
    {
      nsvariable nsvariable = new nsvariable();
      options option = new options();
      option.set_count(true);
      option.set_filter(filter);
      nsvariable[] nsvariableArray = (nsvariable[]) nsvariable.getfiltered(service, option);
      return nsvariableArray != null && nsvariableArray.Length > 0 ? nsvariableArray[0].__count.Value : 0U;
    }

    private class nsvariable_response : base_response
    {
      public nsvariable[] nsvariable = (nsvariable[]) null;
    }

    public static class iffullEnum
    {
      public const string undef = "undef";
      public const string lru = "lru";
    }

    public static class scopeEnum
    {
      public const string global = "global";
      public const string transaction = "transaction";
    }

    public static class ifvaluetoobigEnum
    {
      public const string undef = "undef";
      public const string truncate = "truncate";
    }

    public static class ifnovalueEnum
    {
      public const string undef = "undef";
      public const string init = "init";
    }
  }
}
