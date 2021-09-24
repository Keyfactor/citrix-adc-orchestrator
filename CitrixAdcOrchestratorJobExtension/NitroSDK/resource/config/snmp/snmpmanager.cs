// Decompiled with JetBrains decompiler
// Type: com.citrix.netscaler.nitro.resource.config.snmp.snmpmanager
// Assembly: nitro, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 6CF5DDEF-E052-4F9D-953F-6644F8378A66


using com.citrix.netscaler.nitro.exception;
using com.citrix.netscaler.nitro.resource.Base;
using com.citrix.netscaler.nitro.service;
using com.citrix.netscaler.nitro.util;

namespace com.citrix.netscaler.nitro.resource.config.snmp
{
  public class snmpmanager : base_resource
  {
    private string ipaddressField = (string) null;
    private string netmaskField = (string) null;
    private int? domainresolveretryField = new int?();
    private string ipField = (string) null;
    private string domainField = (string) null;
    private uint? __countField = new uint?();

    public uint? __count
    {
      get => this.__countField;
      private set => this.__countField = value;
    }

    public string ipaddress
    {
      get => this.ipaddressField;
      set => this.ipaddressField = value;
    }

    public string netmask
    {
      get => this.netmaskField;
      set => this.netmaskField = value;
    }

    public int? domainresolveretry
    {
      get => this.domainresolveretryField;
      set => this.domainresolveretryField = value;
    }

    public string ip
    {
      get => this.ipField;
      private set => this.ipField = value;
    }

    public string domain
    {
      get => this.domainField;
      private set => this.domainField = value;
    }

    internal override base_resource[] get_nitro_response(
      nitro_service service,
      string response)
    {
      snmpmanager.snmpmanager_response snmpmanagerResponse = new snmpmanager.snmpmanager_response();
      snmpmanager.snmpmanager_response resource = (snmpmanager.snmpmanager_response) service.get_payload_formatter().string_to_resource(snmpmanagerResponse.GetType(), response);
      if (resource.errorcode != 0)
      {
        if (resource.errorcode == 444)
          service.clear_session();
        if (resource.severity == null)
          throw new nitro_exception(resource.message, resource.errorcode);
        if (resource.severity.Equals("ERROR"))
          throw new nitro_exception(resource.message, resource.errorcode);
      }
      return (base_resource[]) resource.snmpmanager;
    }

    internal override string get_object_name() => this.ipaddress;

    public static base_response add(nitro_service client, snmpmanager resource) => new snmpmanager()
    {
      ipaddress = resource.ipaddress,
      netmask = resource.netmask,
      domainresolveretry = resource.domainresolveretry
    }.add_resource(client);

    public static base_responses add(nitro_service client, snmpmanager[] resources)
    {
      base_responses baseResponses = (base_responses) null;
      if (resources != null && resources.Length > 0)
      {
        snmpmanager[] snmpmanagerArray = new snmpmanager[resources.Length];
        for (int index = 0; index < resources.Length; ++index)
        {
          snmpmanagerArray[index] = new snmpmanager();
          snmpmanagerArray[index].ipaddress = resources[index].ipaddress;
          snmpmanagerArray[index].netmask = resources[index].netmask;
          snmpmanagerArray[index].domainresolveretry = resources[index].domainresolveretry;
        }
        baseResponses = base_resource.add_bulk_request(client, (base_resource[]) snmpmanagerArray);
      }
      return baseResponses;
    }

    public static base_response delete(nitro_service client, string ipaddress) => new snmpmanager()
    {
      ipaddress = ipaddress
    }.delete_resource(client);

    public static base_response delete(nitro_service client, snmpmanager resource) => new snmpmanager()
    {
      ipaddress = resource.ipaddress,
      netmask = resource.netmask
    }.delete_resource(client);

    public static base_responses delete(nitro_service client, string[] ipaddress)
    {
      base_responses baseResponses = (base_responses) null;
      if (ipaddress != null && ipaddress.Length > 0)
      {
        snmpmanager[] snmpmanagerArray = new snmpmanager[ipaddress.Length];
        for (int index = 0; index < ipaddress.Length; ++index)
        {
          snmpmanagerArray[index] = new snmpmanager();
          snmpmanagerArray[index].ipaddress = ipaddress[index];
        }
        baseResponses = base_resource.delete_bulk_request(client, (base_resource[]) snmpmanagerArray);
      }
      return baseResponses;
    }

    public static base_responses delete(nitro_service client, snmpmanager[] resources)
    {
      base_responses baseResponses = (base_responses) null;
      if (resources != null && resources.Length > 0)
      {
        snmpmanager[] snmpmanagerArray = new snmpmanager[resources.Length];
        for (int index = 0; index < resources.Length; ++index)
        {
          snmpmanagerArray[index] = new snmpmanager();
          snmpmanagerArray[index].ipaddress = resources[index].ipaddress;
          snmpmanagerArray[index].netmask = resources[index].netmask;
        }
        baseResponses = base_resource.delete_bulk_request(client, (base_resource[]) snmpmanagerArray);
      }
      return baseResponses;
    }

    public static base_response update(nitro_service client, snmpmanager resource) => new snmpmanager()
    {
      ipaddress = resource.ipaddress,
      netmask = resource.netmask,
      domainresolveretry = resource.domainresolveretry
    }.update_resource(client);

    public static base_responses update(nitro_service client, snmpmanager[] resources)
    {
      base_responses baseResponses = (base_responses) null;
      if (resources != null && resources.Length > 0)
      {
        snmpmanager[] snmpmanagerArray = new snmpmanager[resources.Length];
        for (int index = 0; index < resources.Length; ++index)
        {
          snmpmanagerArray[index] = new snmpmanager();
          snmpmanagerArray[index].ipaddress = resources[index].ipaddress;
          snmpmanagerArray[index].netmask = resources[index].netmask;
          snmpmanagerArray[index].domainresolveretry = resources[index].domainresolveretry;
        }
        baseResponses = base_resource.update_bulk_request(client, (base_resource[]) snmpmanagerArray);
      }
      return baseResponses;
    }

    public static base_response unset(
      nitro_service client,
      snmpmanager resource,
      string[] args)
    {
      return new snmpmanager()
      {
        ipaddress = resource.ipaddress,
        netmask = resource.netmask
      }.unset_resource(client, args);
    }

    public static base_responses unset(
      nitro_service client,
      snmpmanager[] resources,
      string[] args)
    {
      base_responses baseResponses = (base_responses) null;
      if (resources != null && resources.Length > 0)
      {
        snmpmanager[] snmpmanagerArray = new snmpmanager[resources.Length];
        for (int index = 0; index < resources.Length; ++index)
        {
          snmpmanagerArray[index] = new snmpmanager();
          snmpmanagerArray[index].ipaddress = resources[index].ipaddress;
          snmpmanagerArray[index].netmask = resources[index].netmask;
        }
        baseResponses = base_resource.unset_bulk_request(client, (base_resource[]) snmpmanagerArray, args);
      }
      return baseResponses;
    }

    public static snmpmanager[] get(nitro_service service) => (snmpmanager[]) new snmpmanager().get_resources(service, (options) null);

    public static snmpmanager[] get(nitro_service service, options option) => (snmpmanager[]) new snmpmanager().get_resources(service, option);

    public static snmpmanager get(nitro_service service, snmpmanager obj)
    {
      options option = new options();
      option.set_args(nitro_util.object_to_string_withoutquotes((object) obj));
      return (snmpmanager) obj.get_resource(service, option);
    }

    public static snmpmanager[] get(nitro_service service, snmpmanager[] obj)
    {
      if (obj == null || obj.Length <= 0)
        return (snmpmanager[]) null;
      snmpmanager[] snmpmanagerArray = new snmpmanager[obj.Length];
      for (int index = 0; index < obj.Length; ++index)
      {
        options option = new options();
        option.set_args(nitro_util.object_to_string_withoutquotes((object) obj[index]));
        snmpmanagerArray[index] = (snmpmanager) obj[index].get_resource(service, option);
      }
      return snmpmanagerArray;
    }

    public static snmpmanager[] get_filtered(nitro_service service, string filter)
    {
      snmpmanager snmpmanager = new snmpmanager();
      options option = new options();
      option.set_filter(filter);
      return (snmpmanager[]) snmpmanager.getfiltered(service, option);
    }

    public static snmpmanager[] get_filtered(nitro_service service, filtervalue[] filter)
    {
      snmpmanager snmpmanager = new snmpmanager();
      options option = new options();
      option.set_filter(filter);
      return (snmpmanager[]) snmpmanager.getfiltered(service, option);
    }

    public static uint count(nitro_service service)
    {
      snmpmanager snmpmanager = new snmpmanager();
      options option = new options();
      option.set_count(true);
      snmpmanager[] resources = (snmpmanager[]) snmpmanager.get_resources(service, option);
      return resources != null && resources.Length > 0 ? resources[0].__count.Value : 0U;
    }

    public static uint count_filtered(nitro_service service, string filter)
    {
      snmpmanager snmpmanager = new snmpmanager();
      options option = new options();
      option.set_count(true);
      option.set_filter(filter);
      snmpmanager[] snmpmanagerArray = (snmpmanager[]) snmpmanager.getfiltered(service, option);
      return snmpmanagerArray != null && snmpmanagerArray.Length > 0 ? snmpmanagerArray[0].__count.Value : 0U;
    }

    public static uint count_filtered(nitro_service service, filtervalue[] filter)
    {
      snmpmanager snmpmanager = new snmpmanager();
      options option = new options();
      option.set_count(true);
      option.set_filter(filter);
      snmpmanager[] snmpmanagerArray = (snmpmanager[]) snmpmanager.getfiltered(service, option);
      return snmpmanagerArray != null && snmpmanagerArray.Length > 0 ? snmpmanagerArray[0].__count.Value : 0U;
    }

    private class snmpmanager_response : base_response
    {
      public snmpmanager[] snmpmanager = (snmpmanager[]) null;
    }
  }
}
