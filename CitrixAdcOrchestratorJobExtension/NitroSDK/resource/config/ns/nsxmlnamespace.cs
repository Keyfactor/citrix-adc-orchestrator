// Decompiled with JetBrains decompiler
// Type: com.citrix.netscaler.nitro.resource.config.ns.nsxmlnamespace
// Assembly: nitro, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 6CF5DDEF-E052-4F9D-953F-6644F8378A66


using com.citrix.netscaler.nitro.exception;
using com.citrix.netscaler.nitro.resource.Base;
using com.citrix.netscaler.nitro.service;
using com.citrix.netscaler.nitro.util;

namespace com.citrix.netscaler.nitro.resource.config.ns
{
  public class nsxmlnamespace : base_resource
  {
    private string prefixField = (string) null;
    private string NamespaceField = (string) null;
    private string descriptionField = (string) null;
    private uint? __countField = new uint?();

    public uint? __count
    {
      get => this.__countField;
      private set => this.__countField = value;
    }

    public string prefix
    {
      get => this.prefixField;
      set => this.prefixField = value;
    }

    public string Namespace
    {
      get => this.NamespaceField;
      set => this.NamespaceField = value;
    }

    public string description
    {
      get => this.descriptionField;
      set => this.descriptionField = value;
    }

    internal override base_resource[] get_nitro_response(
      nitro_service service,
      string response)
    {
      nsxmlnamespace.nsxmlnamespace_response nsxmlnamespaceResponse = new nsxmlnamespace.nsxmlnamespace_response();
      nsxmlnamespace.nsxmlnamespace_response resource = (nsxmlnamespace.nsxmlnamespace_response) service.get_payload_formatter().string_to_resource(nsxmlnamespaceResponse.GetType(), response);
      if (resource.errorcode != 0)
      {
        if (resource.errorcode == 444)
          service.clear_session();
        if (resource.severity == null)
          throw new nitro_exception(resource.message, resource.errorcode);
        if (resource.severity.Equals("ERROR"))
          throw new nitro_exception(resource.message, resource.errorcode);
      }
      return (base_resource[]) resource.nsxmlnamespace;
    }

    internal override string get_object_name() => this.prefix;

    public static base_response add(nitro_service client, nsxmlnamespace resource) => new nsxmlnamespace()
    {
      prefix = resource.prefix,
      Namespace = resource.Namespace,
      description = resource.description
    }.add_resource(client);

    public static base_responses add(nitro_service client, nsxmlnamespace[] resources)
    {
      base_responses baseResponses = (base_responses) null;
      if (resources != null && resources.Length > 0)
      {
        nsxmlnamespace[] nsxmlnamespaceArray = new nsxmlnamespace[resources.Length];
        for (int index = 0; index < resources.Length; ++index)
        {
          nsxmlnamespaceArray[index] = new nsxmlnamespace();
          nsxmlnamespaceArray[index].prefix = resources[index].prefix;
          nsxmlnamespaceArray[index].Namespace = resources[index].Namespace;
          nsxmlnamespaceArray[index].description = resources[index].description;
        }
        baseResponses = base_resource.add_bulk_request(client, (base_resource[]) nsxmlnamespaceArray);
      }
      return baseResponses;
    }

    public static base_response delete(nitro_service client, string prefix) => new nsxmlnamespace()
    {
      prefix = prefix
    }.delete_resource(client);

    public static base_response delete(nitro_service client, nsxmlnamespace resource) => new nsxmlnamespace()
    {
      prefix = resource.prefix
    }.delete_resource(client);

    public static base_responses delete(nitro_service client, string[] prefix)
    {
      base_responses baseResponses = (base_responses) null;
      if (prefix != null && prefix.Length > 0)
      {
        nsxmlnamespace[] nsxmlnamespaceArray = new nsxmlnamespace[prefix.Length];
        for (int index = 0; index < prefix.Length; ++index)
        {
          nsxmlnamespaceArray[index] = new nsxmlnamespace();
          nsxmlnamespaceArray[index].prefix = prefix[index];
        }
        baseResponses = base_resource.delete_bulk_request(client, (base_resource[]) nsxmlnamespaceArray);
      }
      return baseResponses;
    }

    public static base_responses delete(
      nitro_service client,
      nsxmlnamespace[] resources)
    {
      base_responses baseResponses = (base_responses) null;
      if (resources != null && resources.Length > 0)
      {
        nsxmlnamespace[] nsxmlnamespaceArray = new nsxmlnamespace[resources.Length];
        for (int index = 0; index < resources.Length; ++index)
        {
          nsxmlnamespaceArray[index] = new nsxmlnamespace();
          nsxmlnamespaceArray[index].prefix = resources[index].prefix;
        }
        baseResponses = base_resource.delete_bulk_request(client, (base_resource[]) nsxmlnamespaceArray);
      }
      return baseResponses;
    }

    public static base_response update(nitro_service client, nsxmlnamespace resource) => new nsxmlnamespace()
    {
      prefix = resource.prefix,
      Namespace = resource.Namespace,
      description = resource.description
    }.update_resource(client);

    public static base_responses update(
      nitro_service client,
      nsxmlnamespace[] resources)
    {
      base_responses baseResponses = (base_responses) null;
      if (resources != null && resources.Length > 0)
      {
        nsxmlnamespace[] nsxmlnamespaceArray = new nsxmlnamespace[resources.Length];
        for (int index = 0; index < resources.Length; ++index)
        {
          nsxmlnamespaceArray[index] = new nsxmlnamespace();
          nsxmlnamespaceArray[index].prefix = resources[index].prefix;
          nsxmlnamespaceArray[index].Namespace = resources[index].Namespace;
          nsxmlnamespaceArray[index].description = resources[index].description;
        }
        baseResponses = base_resource.update_bulk_request(client, (base_resource[]) nsxmlnamespaceArray);
      }
      return baseResponses;
    }

    public static base_response unset(
      nitro_service client,
      string prefix,
      string[] args)
    {
      return new nsxmlnamespace() { prefix = prefix }.unset_resource(client, args);
    }

    public static base_response unset(
      nitro_service client,
      nsxmlnamespace resource,
      string[] args)
    {
      return new nsxmlnamespace()
      {
        prefix = resource.prefix
      }.unset_resource(client, args);
    }

    public static base_responses unset(
      nitro_service client,
      string[] prefix,
      string[] args)
    {
      base_responses baseResponses = (base_responses) null;
      if (prefix != null && prefix.Length > 0)
      {
        nsxmlnamespace[] nsxmlnamespaceArray = new nsxmlnamespace[prefix.Length];
        for (int index = 0; index < prefix.Length; ++index)
        {
          nsxmlnamespaceArray[index] = new nsxmlnamespace();
          nsxmlnamespaceArray[index].prefix = prefix[index];
        }
        baseResponses = base_resource.unset_bulk_request(client, (base_resource[]) nsxmlnamespaceArray, args);
      }
      return baseResponses;
    }

    public static base_responses unset(
      nitro_service client,
      nsxmlnamespace[] resources,
      string[] args)
    {
      base_responses baseResponses = (base_responses) null;
      if (resources != null && resources.Length > 0)
      {
        nsxmlnamespace[] nsxmlnamespaceArray = new nsxmlnamespace[resources.Length];
        for (int index = 0; index < resources.Length; ++index)
        {
          nsxmlnamespaceArray[index] = new nsxmlnamespace();
          nsxmlnamespaceArray[index].prefix = resources[index].prefix;
        }
        baseResponses = base_resource.unset_bulk_request(client, (base_resource[]) nsxmlnamespaceArray, args);
      }
      return baseResponses;
    }

    public static nsxmlnamespace[] get(nitro_service service) => (nsxmlnamespace[]) new nsxmlnamespace().get_resources(service, (options) null);

    public static nsxmlnamespace[] get(nitro_service service, options option) => (nsxmlnamespace[]) new nsxmlnamespace().get_resources(service, option);

    public static nsxmlnamespace get(nitro_service service, string prefix) => (nsxmlnamespace) new nsxmlnamespace()
    {
      prefix = prefix
    }.get_resource(service);

    public static nsxmlnamespace[] get(nitro_service service, string[] prefix)
    {
      if (prefix == null || prefix.Length <= 0)
        return (nsxmlnamespace[]) null;
      nsxmlnamespace[] nsxmlnamespaceArray1 = new nsxmlnamespace[prefix.Length];
      nsxmlnamespace[] nsxmlnamespaceArray2 = new nsxmlnamespace[prefix.Length];
      for (int index = 0; index < prefix.Length; ++index)
      {
        nsxmlnamespaceArray2[index] = new nsxmlnamespace();
        nsxmlnamespaceArray2[index].prefix = prefix[index];
        nsxmlnamespaceArray1[index] = (nsxmlnamespace) nsxmlnamespaceArray2[index].get_resource(service);
      }
      return nsxmlnamespaceArray1;
    }

    public static nsxmlnamespace[] get_filtered(nitro_service service, string filter)
    {
      nsxmlnamespace nsxmlnamespace = new nsxmlnamespace();
      options option = new options();
      option.set_filter(filter);
      return (nsxmlnamespace[]) nsxmlnamespace.getfiltered(service, option);
    }

    public static nsxmlnamespace[] get_filtered(
      nitro_service service,
      filtervalue[] filter)
    {
      nsxmlnamespace nsxmlnamespace = new nsxmlnamespace();
      options option = new options();
      option.set_filter(filter);
      return (nsxmlnamespace[]) nsxmlnamespace.getfiltered(service, option);
    }

    public static uint count(nitro_service service)
    {
      nsxmlnamespace nsxmlnamespace = new nsxmlnamespace();
      options option = new options();
      option.set_count(true);
      nsxmlnamespace[] resources = (nsxmlnamespace[]) nsxmlnamespace.get_resources(service, option);
      return resources != null && resources.Length > 0 ? resources[0].__count.Value : 0U;
    }

    public static uint count_filtered(nitro_service service, string filter)
    {
      nsxmlnamespace nsxmlnamespace = new nsxmlnamespace();
      options option = new options();
      option.set_count(true);
      option.set_filter(filter);
      nsxmlnamespace[] nsxmlnamespaceArray = (nsxmlnamespace[]) nsxmlnamespace.getfiltered(service, option);
      return nsxmlnamespaceArray != null && nsxmlnamespaceArray.Length > 0 ? nsxmlnamespaceArray[0].__count.Value : 0U;
    }

    public static uint count_filtered(nitro_service service, filtervalue[] filter)
    {
      nsxmlnamespace nsxmlnamespace = new nsxmlnamespace();
      options option = new options();
      option.set_count(true);
      option.set_filter(filter);
      nsxmlnamespace[] nsxmlnamespaceArray = (nsxmlnamespace[]) nsxmlnamespace.getfiltered(service, option);
      return nsxmlnamespaceArray != null && nsxmlnamespaceArray.Length > 0 ? nsxmlnamespaceArray[0].__count.Value : 0U;
    }

    private class nsxmlnamespace_response : base_response
    {
      public nsxmlnamespace[] nsxmlnamespace = (nsxmlnamespace[]) null;
    }
  }
}
