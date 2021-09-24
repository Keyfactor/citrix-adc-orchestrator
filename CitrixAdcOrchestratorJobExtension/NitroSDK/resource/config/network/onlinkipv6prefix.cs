// Decompiled with JetBrains decompiler
// Type: com.citrix.netscaler.nitro.resource.config.network.onlinkipv6prefix
// Assembly: nitro, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 6CF5DDEF-E052-4F9D-953F-6644F8378A66


using com.citrix.netscaler.nitro.exception;
using com.citrix.netscaler.nitro.resource.Base;
using com.citrix.netscaler.nitro.service;
using com.citrix.netscaler.nitro.util;

namespace com.citrix.netscaler.nitro.resource.config.network
{
  public class onlinkipv6prefix : base_resource
  {
    private string ipv6prefixField = (string) null;
    private string onlinkprefixField = (string) null;
    private string autonomusprefixField = (string) null;
    private string depricateprefixField = (string) null;
    private string decrementprefixlifetimesField = (string) null;
    private uint? prefixvalidelifetimeField = new uint?();
    private uint? prefixpreferredlifetimeField = new uint?();
    private uint? prefixcurrvalidelftField = new uint?();
    private uint? prefixcurrpreferredlftField = new uint?();
    private uint? __countField = new uint?();

    public uint? __count
    {
      get => this.__countField;
      private set => this.__countField = value;
    }

    public string ipv6prefix
    {
      get => this.ipv6prefixField;
      set => this.ipv6prefixField = value;
    }

    public string onlinkprefix
    {
      get => this.onlinkprefixField;
      set => this.onlinkprefixField = value;
    }

    public string autonomusprefix
    {
      get => this.autonomusprefixField;
      set => this.autonomusprefixField = value;
    }

    public string depricateprefix
    {
      get => this.depricateprefixField;
      set => this.depricateprefixField = value;
    }

    public string decrementprefixlifetimes
    {
      get => this.decrementprefixlifetimesField;
      set => this.decrementprefixlifetimesField = value;
    }

    public uint? prefixvalidelifetime
    {
      get => this.prefixvalidelifetimeField;
      set => this.prefixvalidelifetimeField = value;
    }

    public uint? prefixpreferredlifetime
    {
      get => this.prefixpreferredlifetimeField;
      set => this.prefixpreferredlifetimeField = value;
    }

    public uint? prefixcurrvalidelft
    {
      get => this.prefixcurrvalidelftField;
      private set => this.prefixcurrvalidelftField = value;
    }

    public uint? prefixcurrpreferredlft
    {
      get => this.prefixcurrpreferredlftField;
      private set => this.prefixcurrpreferredlftField = value;
    }

    internal override base_resource[] get_nitro_response(
      nitro_service service,
      string response)
    {
      onlinkipv6prefix.onlinkipv6prefix_response onlinkipv6prefixResponse = new onlinkipv6prefix.onlinkipv6prefix_response();
      onlinkipv6prefix.onlinkipv6prefix_response resource = (onlinkipv6prefix.onlinkipv6prefix_response) service.get_payload_formatter().string_to_resource(onlinkipv6prefixResponse.GetType(), response);
      if (resource.errorcode != 0)
      {
        if (resource.errorcode == 444)
          service.clear_session();
        if (resource.severity == null)
          throw new nitro_exception(resource.message, resource.errorcode);
        if (resource.severity.Equals("ERROR"))
          throw new nitro_exception(resource.message, resource.errorcode);
      }
      return (base_resource[]) resource.onlinkipv6prefix;
    }

    internal override string get_object_name() => this.ipv6prefix;

    public static base_response add(nitro_service client, onlinkipv6prefix resource) => new onlinkipv6prefix()
    {
      ipv6prefix = resource.ipv6prefix,
      onlinkprefix = resource.onlinkprefix,
      autonomusprefix = resource.autonomusprefix,
      depricateprefix = resource.depricateprefix,
      decrementprefixlifetimes = resource.decrementprefixlifetimes,
      prefixvalidelifetime = resource.prefixvalidelifetime,
      prefixpreferredlifetime = resource.prefixpreferredlifetime
    }.add_resource(client);

    public static base_responses add(
      nitro_service client,
      onlinkipv6prefix[] resources)
    {
      base_responses baseResponses = (base_responses) null;
      if (resources != null && resources.Length > 0)
      {
        onlinkipv6prefix[] onlinkipv6prefixArray = new onlinkipv6prefix[resources.Length];
        for (int index = 0; index < resources.Length; ++index)
        {
          onlinkipv6prefixArray[index] = new onlinkipv6prefix();
          onlinkipv6prefixArray[index].ipv6prefix = resources[index].ipv6prefix;
          onlinkipv6prefixArray[index].onlinkprefix = resources[index].onlinkprefix;
          onlinkipv6prefixArray[index].autonomusprefix = resources[index].autonomusprefix;
          onlinkipv6prefixArray[index].depricateprefix = resources[index].depricateprefix;
          onlinkipv6prefixArray[index].decrementprefixlifetimes = resources[index].decrementprefixlifetimes;
          onlinkipv6prefixArray[index].prefixvalidelifetime = resources[index].prefixvalidelifetime;
          onlinkipv6prefixArray[index].prefixpreferredlifetime = resources[index].prefixpreferredlifetime;
        }
        baseResponses = base_resource.add_bulk_request(client, (base_resource[]) onlinkipv6prefixArray);
      }
      return baseResponses;
    }

    public static base_response delete(nitro_service client, string ipv6prefix) => new onlinkipv6prefix()
    {
      ipv6prefix = ipv6prefix
    }.delete_resource(client);

    public static base_response delete(nitro_service client, onlinkipv6prefix resource) => new onlinkipv6prefix()
    {
      ipv6prefix = resource.ipv6prefix
    }.delete_resource(client);

    public static base_responses delete(nitro_service client, string[] ipv6prefix)
    {
      base_responses baseResponses = (base_responses) null;
      if (ipv6prefix != null && ipv6prefix.Length > 0)
      {
        onlinkipv6prefix[] onlinkipv6prefixArray = new onlinkipv6prefix[ipv6prefix.Length];
        for (int index = 0; index < ipv6prefix.Length; ++index)
        {
          onlinkipv6prefixArray[index] = new onlinkipv6prefix();
          onlinkipv6prefixArray[index].ipv6prefix = ipv6prefix[index];
        }
        baseResponses = base_resource.delete_bulk_request(client, (base_resource[]) onlinkipv6prefixArray);
      }
      return baseResponses;
    }

    public static base_responses delete(
      nitro_service client,
      onlinkipv6prefix[] resources)
    {
      base_responses baseResponses = (base_responses) null;
      if (resources != null && resources.Length > 0)
      {
        onlinkipv6prefix[] onlinkipv6prefixArray = new onlinkipv6prefix[resources.Length];
        for (int index = 0; index < resources.Length; ++index)
        {
          onlinkipv6prefixArray[index] = new onlinkipv6prefix();
          onlinkipv6prefixArray[index].ipv6prefix = resources[index].ipv6prefix;
        }
        baseResponses = base_resource.delete_bulk_request(client, (base_resource[]) onlinkipv6prefixArray);
      }
      return baseResponses;
    }

    public static base_response update(nitro_service client, onlinkipv6prefix resource) => new onlinkipv6prefix()
    {
      ipv6prefix = resource.ipv6prefix,
      onlinkprefix = resource.onlinkprefix,
      autonomusprefix = resource.autonomusprefix,
      depricateprefix = resource.depricateprefix,
      decrementprefixlifetimes = resource.decrementprefixlifetimes,
      prefixvalidelifetime = resource.prefixvalidelifetime,
      prefixpreferredlifetime = resource.prefixpreferredlifetime
    }.update_resource(client);

    public static base_responses update(
      nitro_service client,
      onlinkipv6prefix[] resources)
    {
      base_responses baseResponses = (base_responses) null;
      if (resources != null && resources.Length > 0)
      {
        onlinkipv6prefix[] onlinkipv6prefixArray = new onlinkipv6prefix[resources.Length];
        for (int index = 0; index < resources.Length; ++index)
        {
          onlinkipv6prefixArray[index] = new onlinkipv6prefix();
          onlinkipv6prefixArray[index].ipv6prefix = resources[index].ipv6prefix;
          onlinkipv6prefixArray[index].onlinkprefix = resources[index].onlinkprefix;
          onlinkipv6prefixArray[index].autonomusprefix = resources[index].autonomusprefix;
          onlinkipv6prefixArray[index].depricateprefix = resources[index].depricateprefix;
          onlinkipv6prefixArray[index].decrementprefixlifetimes = resources[index].decrementprefixlifetimes;
          onlinkipv6prefixArray[index].prefixvalidelifetime = resources[index].prefixvalidelifetime;
          onlinkipv6prefixArray[index].prefixpreferredlifetime = resources[index].prefixpreferredlifetime;
        }
        baseResponses = base_resource.update_bulk_request(client, (base_resource[]) onlinkipv6prefixArray);
      }
      return baseResponses;
    }

    public static base_response unset(
      nitro_service client,
      string ipv6prefix,
      string[] args)
    {
      return new onlinkipv6prefix()
      {
        ipv6prefix = ipv6prefix
      }.unset_resource(client, args);
    }

    public static base_response unset(
      nitro_service client,
      onlinkipv6prefix resource,
      string[] args)
    {
      return new onlinkipv6prefix()
      {
        ipv6prefix = resource.ipv6prefix
      }.unset_resource(client, args);
    }

    public static base_responses unset(
      nitro_service client,
      string[] ipv6prefix,
      string[] args)
    {
      base_responses baseResponses = (base_responses) null;
      if (ipv6prefix != null && ipv6prefix.Length > 0)
      {
        onlinkipv6prefix[] onlinkipv6prefixArray = new onlinkipv6prefix[ipv6prefix.Length];
        for (int index = 0; index < ipv6prefix.Length; ++index)
        {
          onlinkipv6prefixArray[index] = new onlinkipv6prefix();
          onlinkipv6prefixArray[index].ipv6prefix = ipv6prefix[index];
        }
        baseResponses = base_resource.unset_bulk_request(client, (base_resource[]) onlinkipv6prefixArray, args);
      }
      return baseResponses;
    }

    public static base_responses unset(
      nitro_service client,
      onlinkipv6prefix[] resources,
      string[] args)
    {
      base_responses baseResponses = (base_responses) null;
      if (resources != null && resources.Length > 0)
      {
        onlinkipv6prefix[] onlinkipv6prefixArray = new onlinkipv6prefix[resources.Length];
        for (int index = 0; index < resources.Length; ++index)
        {
          onlinkipv6prefixArray[index] = new onlinkipv6prefix();
          onlinkipv6prefixArray[index].ipv6prefix = resources[index].ipv6prefix;
        }
        baseResponses = base_resource.unset_bulk_request(client, (base_resource[]) onlinkipv6prefixArray, args);
      }
      return baseResponses;
    }

    public static onlinkipv6prefix[] get(nitro_service service) => (onlinkipv6prefix[]) new onlinkipv6prefix().get_resources(service, (options) null);

    public static onlinkipv6prefix[] get(nitro_service service, options option) => (onlinkipv6prefix[]) new onlinkipv6prefix().get_resources(service, option);

    public static onlinkipv6prefix get(nitro_service service, string ipv6prefix) => (onlinkipv6prefix) new onlinkipv6prefix()
    {
      ipv6prefix = ipv6prefix
    }.get_resource(service);

    public static onlinkipv6prefix[] get(nitro_service service, string[] ipv6prefix)
    {
      if (ipv6prefix == null || ipv6prefix.Length <= 0)
        return (onlinkipv6prefix[]) null;
      onlinkipv6prefix[] onlinkipv6prefixArray1 = new onlinkipv6prefix[ipv6prefix.Length];
      onlinkipv6prefix[] onlinkipv6prefixArray2 = new onlinkipv6prefix[ipv6prefix.Length];
      for (int index = 0; index < ipv6prefix.Length; ++index)
      {
        onlinkipv6prefixArray2[index] = new onlinkipv6prefix();
        onlinkipv6prefixArray2[index].ipv6prefix = ipv6prefix[index];
        onlinkipv6prefixArray1[index] = (onlinkipv6prefix) onlinkipv6prefixArray2[index].get_resource(service);
      }
      return onlinkipv6prefixArray1;
    }

    public static onlinkipv6prefix[] get_filtered(
      nitro_service service,
      string filter)
    {
      onlinkipv6prefix onlinkipv6prefix = new onlinkipv6prefix();
      options option = new options();
      option.set_filter(filter);
      return (onlinkipv6prefix[]) onlinkipv6prefix.getfiltered(service, option);
    }

    public static onlinkipv6prefix[] get_filtered(
      nitro_service service,
      filtervalue[] filter)
    {
      onlinkipv6prefix onlinkipv6prefix = new onlinkipv6prefix();
      options option = new options();
      option.set_filter(filter);
      return (onlinkipv6prefix[]) onlinkipv6prefix.getfiltered(service, option);
    }

    public static uint count(nitro_service service)
    {
      onlinkipv6prefix onlinkipv6prefix = new onlinkipv6prefix();
      options option = new options();
      option.set_count(true);
      onlinkipv6prefix[] resources = (onlinkipv6prefix[]) onlinkipv6prefix.get_resources(service, option);
      return resources != null && resources.Length > 0 ? resources[0].__count.Value : 0U;
    }

    public static uint count_filtered(nitro_service service, string filter)
    {
      onlinkipv6prefix onlinkipv6prefix = new onlinkipv6prefix();
      options option = new options();
      option.set_count(true);
      option.set_filter(filter);
      onlinkipv6prefix[] onlinkipv6prefixArray = (onlinkipv6prefix[]) onlinkipv6prefix.getfiltered(service, option);
      return onlinkipv6prefixArray != null && onlinkipv6prefixArray.Length > 0 ? onlinkipv6prefixArray[0].__count.Value : 0U;
    }

    public static uint count_filtered(nitro_service service, filtervalue[] filter)
    {
      onlinkipv6prefix onlinkipv6prefix = new onlinkipv6prefix();
      options option = new options();
      option.set_count(true);
      option.set_filter(filter);
      onlinkipv6prefix[] onlinkipv6prefixArray = (onlinkipv6prefix[]) onlinkipv6prefix.getfiltered(service, option);
      return onlinkipv6prefixArray != null && onlinkipv6prefixArray.Length > 0 ? onlinkipv6prefixArray[0].__count.Value : 0U;
    }

    private class onlinkipv6prefix_response : base_response
    {
      public onlinkipv6prefix[] onlinkipv6prefix = (onlinkipv6prefix[]) null;
    }

    public static class depricateprefixEnum
    {
      public const string YES = "YES";
      public const string NO = "NO";
    }

    public static class decrementprefixlifetimesEnum
    {
      public const string YES = "YES";
      public const string NO = "NO";
    }

    public static class onlinkprefixEnum
    {
      public const string YES = "YES";
      public const string NO = "NO";
    }

    public static class autonomusprefixEnum
    {
      public const string YES = "YES";
      public const string NO = "NO";
    }
  }
}
