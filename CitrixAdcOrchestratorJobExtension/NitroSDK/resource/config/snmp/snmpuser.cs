// Decompiled with JetBrains decompiler
// Type: com.citrix.netscaler.nitro.resource.config.snmp.snmpuser
// Assembly: nitro, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 6CF5DDEF-E052-4F9D-953F-6644F8378A66


using com.citrix.netscaler.nitro.exception;
using com.citrix.netscaler.nitro.resource.Base;
using com.citrix.netscaler.nitro.service;
using com.citrix.netscaler.nitro.util;

namespace com.citrix.netscaler.nitro.resource.config.snmp
{
  public class snmpuser : base_resource
  {
    private string nameField = (string) null;
    private string groupField = (string) null;
    private string authtypeField = (string) null;
    private string authpasswdField = (string) null;
    private string privtypeField = (string) null;
    private string privpasswdField = (string) null;
    private string engineidField = (string) null;
    private string storagetypeField = (string) null;
    private string statusField = (string) null;
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

    public string group
    {
      get => this.groupField;
      set => this.groupField = value;
    }

    public string authtype
    {
      get => this.authtypeField;
      set => this.authtypeField = value;
    }

    public string authpasswd
    {
      get => this.authpasswdField;
      set => this.authpasswdField = value;
    }

    public string privtype
    {
      get => this.privtypeField;
      set => this.privtypeField = value;
    }

    public string privpasswd
    {
      get => this.privpasswdField;
      set => this.privpasswdField = value;
    }

    public string engineid
    {
      get => this.engineidField;
      private set => this.engineidField = value;
    }

    public string storagetype
    {
      get => this.storagetypeField;
      private set => this.storagetypeField = value;
    }

    public string status
    {
      get => this.statusField;
      private set => this.statusField = value;
    }

    internal override base_resource[] get_nitro_response(
      nitro_service service,
      string response)
    {
      snmpuser.snmpuser_response snmpuserResponse = new snmpuser.snmpuser_response();
      snmpuser.snmpuser_response resource = (snmpuser.snmpuser_response) service.get_payload_formatter().string_to_resource(snmpuserResponse.GetType(), response);
      if (resource.errorcode != 0)
      {
        if (resource.errorcode == 444)
          service.clear_session();
        if (resource.severity == null)
          throw new nitro_exception(resource.message, resource.errorcode);
        if (resource.severity.Equals("ERROR"))
          throw new nitro_exception(resource.message, resource.errorcode);
      }
      return (base_resource[]) resource.snmpuser;
    }

    internal override string get_object_name() => this.name;

    public static base_response add(nitro_service client, snmpuser resource) => new snmpuser()
    {
      name = resource.name,
      group = resource.group,
      authtype = resource.authtype,
      authpasswd = resource.authpasswd,
      privtype = resource.privtype,
      privpasswd = resource.privpasswd
    }.add_resource(client);

    public static base_responses add(nitro_service client, snmpuser[] resources)
    {
      base_responses baseResponses = (base_responses) null;
      if (resources != null && resources.Length > 0)
      {
        snmpuser[] snmpuserArray = new snmpuser[resources.Length];
        for (int index = 0; index < resources.Length; ++index)
        {
          snmpuserArray[index] = new snmpuser();
          snmpuserArray[index].name = resources[index].name;
          snmpuserArray[index].group = resources[index].group;
          snmpuserArray[index].authtype = resources[index].authtype;
          snmpuserArray[index].authpasswd = resources[index].authpasswd;
          snmpuserArray[index].privtype = resources[index].privtype;
          snmpuserArray[index].privpasswd = resources[index].privpasswd;
        }
        baseResponses = base_resource.add_bulk_request(client, (base_resource[]) snmpuserArray);
      }
      return baseResponses;
    }

    public static base_response delete(nitro_service client, string name) => new snmpuser()
    {
      name = name
    }.delete_resource(client);

    public static base_response delete(nitro_service client, snmpuser resource) => new snmpuser()
    {
      name = resource.name
    }.delete_resource(client);

    public static base_responses delete(nitro_service client, string[] name)
    {
      base_responses baseResponses = (base_responses) null;
      if (name != null && name.Length > 0)
      {
        snmpuser[] snmpuserArray = new snmpuser[name.Length];
        for (int index = 0; index < name.Length; ++index)
        {
          snmpuserArray[index] = new snmpuser();
          snmpuserArray[index].name = name[index];
        }
        baseResponses = base_resource.delete_bulk_request(client, (base_resource[]) snmpuserArray);
      }
      return baseResponses;
    }

    public static base_responses delete(nitro_service client, snmpuser[] resources)
    {
      base_responses baseResponses = (base_responses) null;
      if (resources != null && resources.Length > 0)
      {
        snmpuser[] snmpuserArray = new snmpuser[resources.Length];
        for (int index = 0; index < resources.Length; ++index)
        {
          snmpuserArray[index] = new snmpuser();
          snmpuserArray[index].name = resources[index].name;
        }
        baseResponses = base_resource.delete_bulk_request(client, (base_resource[]) snmpuserArray);
      }
      return baseResponses;
    }

    public static base_response update(nitro_service client, snmpuser resource) => new snmpuser()
    {
      name = resource.name,
      group = resource.group,
      authtype = resource.authtype,
      authpasswd = resource.authpasswd,
      privtype = resource.privtype,
      privpasswd = resource.privpasswd
    }.update_resource(client);

    public static base_responses update(nitro_service client, snmpuser[] resources)
    {
      base_responses baseResponses = (base_responses) null;
      if (resources != null && resources.Length > 0)
      {
        snmpuser[] snmpuserArray = new snmpuser[resources.Length];
        for (int index = 0; index < resources.Length; ++index)
        {
          snmpuserArray[index] = new snmpuser();
          snmpuserArray[index].name = resources[index].name;
          snmpuserArray[index].group = resources[index].group;
          snmpuserArray[index].authtype = resources[index].authtype;
          snmpuserArray[index].authpasswd = resources[index].authpasswd;
          snmpuserArray[index].privtype = resources[index].privtype;
          snmpuserArray[index].privpasswd = resources[index].privpasswd;
        }
        baseResponses = base_resource.update_bulk_request(client, (base_resource[]) snmpuserArray);
      }
      return baseResponses;
    }

    public static base_response unset(
      nitro_service client,
      string name,
      string[] args)
    {
      return new snmpuser() { name = name }.unset_resource(client, args);
    }

    public static base_response unset(
      nitro_service client,
      snmpuser resource,
      string[] args)
    {
      return new snmpuser() { name = resource.name }.unset_resource(client, args);
    }

    public static base_responses unset(
      nitro_service client,
      string[] name,
      string[] args)
    {
      base_responses baseResponses = (base_responses) null;
      if (name != null && name.Length > 0)
      {
        snmpuser[] snmpuserArray = new snmpuser[name.Length];
        for (int index = 0; index < name.Length; ++index)
        {
          snmpuserArray[index] = new snmpuser();
          snmpuserArray[index].name = name[index];
        }
        baseResponses = base_resource.unset_bulk_request(client, (base_resource[]) snmpuserArray, args);
      }
      return baseResponses;
    }

    public static base_responses unset(
      nitro_service client,
      snmpuser[] resources,
      string[] args)
    {
      base_responses baseResponses = (base_responses) null;
      if (resources != null && resources.Length > 0)
      {
        snmpuser[] snmpuserArray = new snmpuser[resources.Length];
        for (int index = 0; index < resources.Length; ++index)
        {
          snmpuserArray[index] = new snmpuser();
          snmpuserArray[index].name = resources[index].name;
        }
        baseResponses = base_resource.unset_bulk_request(client, (base_resource[]) snmpuserArray, args);
      }
      return baseResponses;
    }

    public static snmpuser[] get(nitro_service service) => (snmpuser[]) new snmpuser().get_resources(service, (options) null);

    public static snmpuser[] get(nitro_service service, options option) => (snmpuser[]) new snmpuser().get_resources(service, option);

    public static snmpuser get(nitro_service service, string name) => (snmpuser) new snmpuser()
    {
      name = name
    }.get_resource(service);

    public static snmpuser[] get(nitro_service service, string[] name)
    {
      if (name == null || name.Length <= 0)
        return (snmpuser[]) null;
      snmpuser[] snmpuserArray1 = new snmpuser[name.Length];
      snmpuser[] snmpuserArray2 = new snmpuser[name.Length];
      for (int index = 0; index < name.Length; ++index)
      {
        snmpuserArray2[index] = new snmpuser();
        snmpuserArray2[index].name = name[index];
        snmpuserArray1[index] = (snmpuser) snmpuserArray2[index].get_resource(service);
      }
      return snmpuserArray1;
    }

    public static snmpuser[] get_filtered(nitro_service service, string filter)
    {
      snmpuser snmpuser = new snmpuser();
      options option = new options();
      option.set_filter(filter);
      return (snmpuser[]) snmpuser.getfiltered(service, option);
    }

    public static snmpuser[] get_filtered(nitro_service service, filtervalue[] filter)
    {
      snmpuser snmpuser = new snmpuser();
      options option = new options();
      option.set_filter(filter);
      return (snmpuser[]) snmpuser.getfiltered(service, option);
    }

    public static uint count(nitro_service service)
    {
      snmpuser snmpuser = new snmpuser();
      options option = new options();
      option.set_count(true);
      snmpuser[] resources = (snmpuser[]) snmpuser.get_resources(service, option);
      return resources != null && resources.Length > 0 ? resources[0].__count.Value : 0U;
    }

    public static uint count_filtered(nitro_service service, string filter)
    {
      snmpuser snmpuser = new snmpuser();
      options option = new options();
      option.set_count(true);
      option.set_filter(filter);
      snmpuser[] snmpuserArray = (snmpuser[]) snmpuser.getfiltered(service, option);
      return snmpuserArray != null && snmpuserArray.Length > 0 ? snmpuserArray[0].__count.Value : 0U;
    }

    public static uint count_filtered(nitro_service service, filtervalue[] filter)
    {
      snmpuser snmpuser = new snmpuser();
      options option = new options();
      option.set_count(true);
      option.set_filter(filter);
      snmpuser[] snmpuserArray = (snmpuser[]) snmpuser.getfiltered(service, option);
      return snmpuserArray != null && snmpuserArray.Length > 0 ? snmpuserArray[0].__count.Value : 0U;
    }

    private class snmpuser_response : base_response
    {
      public snmpuser[] snmpuser = (snmpuser[]) null;
    }

    public static class storagetypeEnum
    {
      public const string Volatile = "volatile";
      public const string nonVolatile = "nonVolatile";
    }

    public static class authtypeEnum
    {
      public const string MD5 = "MD5";
      public const string SHA = "SHA";
    }

    public static class statusEnum
    {
      public const string active = "active";
    }

    public static class privtypeEnum
    {
      public const string DES = "DES";
      public const string AES = "AES";
    }
  }
}
