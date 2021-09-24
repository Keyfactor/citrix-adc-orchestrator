// Decompiled with JetBrains decompiler
// Type: com.citrix.netscaler.nitro.resource.config.ssl.sslcipher
// Assembly: nitro, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 6CF5DDEF-E052-4F9D-953F-6644F8378A66


using com.citrix.netscaler.nitro.exception;
using com.citrix.netscaler.nitro.resource.Base;
using com.citrix.netscaler.nitro.service;
using com.citrix.netscaler.nitro.util;

namespace com.citrix.netscaler.nitro.resource.config.ssl
{
  public class sslcipher : base_resource
  {
    private string ciphergroupnameField = (string) null;
    private string ciphgrpaliasField = (string) null;
    private string ciphernameField = (string) null;
    private uint? cipherpriorityField = new uint?();
    private string sslprofileField = (string) null;
    private uint? __countField = new uint?();

    public uint? __count
    {
      get => this.__countField;
      private set => this.__countField = value;
    }

    public string ciphergroupname
    {
      get => this.ciphergroupnameField;
      set => this.ciphergroupnameField = value;
    }

    public string ciphgrpalias
    {
      get => this.ciphgrpaliasField;
      set => this.ciphgrpaliasField = value;
    }

    public string ciphername
    {
      get => this.ciphernameField;
      set => this.ciphernameField = value;
    }

    public uint? cipherpriority
    {
      get => this.cipherpriorityField;
      set => this.cipherpriorityField = value;
    }

    public string sslprofile
    {
      get => this.sslprofileField;
      set => this.sslprofileField = value;
    }

    internal override base_resource[] get_nitro_response(
      nitro_service service,
      string response)
    {
      sslcipher.sslcipher_response sslcipherResponse = new sslcipher.sslcipher_response();
      sslcipher.sslcipher_response resource = (sslcipher.sslcipher_response) service.get_payload_formatter().string_to_resource(sslcipherResponse.GetType(), response);
      if (resource.errorcode != 0)
      {
        if (resource.errorcode == 444)
          service.clear_session();
        if (resource.severity == null)
          throw new nitro_exception(resource.message, resource.errorcode);
        if (resource.severity.Equals("ERROR"))
          throw new nitro_exception(resource.message, resource.errorcode);
      }
      return (base_resource[]) resource.sslcipher;
    }

    internal override string get_object_name() => this.ciphergroupname;

    public static base_response add(nitro_service client, sslcipher resource) => new sslcipher()
    {
      ciphergroupname = resource.ciphergroupname,
      ciphgrpalias = resource.ciphgrpalias
    }.add_resource(client);

    public static base_responses add(nitro_service client, sslcipher[] resources)
    {
      base_responses baseResponses = (base_responses) null;
      if (resources != null && resources.Length > 0)
      {
        sslcipher[] sslcipherArray = new sslcipher[resources.Length];
        for (int index = 0; index < resources.Length; ++index)
        {
          sslcipherArray[index] = new sslcipher();
          sslcipherArray[index].ciphergroupname = resources[index].ciphergroupname;
          sslcipherArray[index].ciphgrpalias = resources[index].ciphgrpalias;
        }
        baseResponses = base_resource.add_bulk_request(client, (base_resource[]) sslcipherArray);
      }
      return baseResponses;
    }

    public static base_response update(nitro_service client, sslcipher resource) => new sslcipher()
    {
      ciphergroupname = resource.ciphergroupname,
      ciphername = resource.ciphername,
      cipherpriority = resource.cipherpriority
    }.update_resource(client);

    public static base_responses update(nitro_service client, sslcipher[] resources)
    {
      base_responses baseResponses = (base_responses) null;
      if (resources != null && resources.Length > 0)
      {
        sslcipher[] sslcipherArray = new sslcipher[resources.Length];
        for (int index = 0; index < resources.Length; ++index)
        {
          sslcipherArray[index] = new sslcipher();
          sslcipherArray[index].ciphergroupname = resources[index].ciphergroupname;
          sslcipherArray[index].ciphername = resources[index].ciphername;
          sslcipherArray[index].cipherpriority = resources[index].cipherpriority;
        }
        baseResponses = base_resource.update_bulk_request(client, (base_resource[]) sslcipherArray);
      }
      return baseResponses;
    }

    public static base_response unset(
      nitro_service client,
      sslcipher resource,
      string[] args)
    {
      return new sslcipher()
      {
        ciphergroupname = resource.ciphergroupname
      }.unset_resource(client, args);
    }

    public static base_responses unset(
      nitro_service client,
      sslcipher[] resources,
      string[] args)
    {
      base_responses baseResponses = (base_responses) null;
      if (resources != null && resources.Length > 0)
      {
        sslcipher[] sslcipherArray = new sslcipher[resources.Length];
        for (int index = 0; index < resources.Length; ++index)
        {
          sslcipherArray[index] = new sslcipher();
          sslcipherArray[index].ciphergroupname = resources[index].ciphergroupname;
        }
        baseResponses = base_resource.unset_bulk_request(client, (base_resource[]) sslcipherArray, args);
      }
      return baseResponses;
    }

    public static base_response delete(nitro_service client, string ciphergroupname) => new sslcipher()
    {
      ciphergroupname = ciphergroupname
    }.delete_resource(client);

    public static base_response delete(nitro_service client, sslcipher resource) => new sslcipher()
    {
      ciphergroupname = resource.ciphergroupname,
      ciphername = resource.ciphername
    }.delete_resource(client);

    public static base_responses delete(
      nitro_service client,
      string[] ciphergroupname)
    {
      base_responses baseResponses = (base_responses) null;
      if (ciphergroupname != null && ciphergroupname.Length > 0)
      {
        sslcipher[] sslcipherArray = new sslcipher[ciphergroupname.Length];
        for (int index = 0; index < ciphergroupname.Length; ++index)
        {
          sslcipherArray[index] = new sslcipher();
          sslcipherArray[index].ciphergroupname = ciphergroupname[index];
        }
        baseResponses = base_resource.delete_bulk_request(client, (base_resource[]) sslcipherArray);
      }
      return baseResponses;
    }

    public static base_responses delete(nitro_service client, sslcipher[] resources)
    {
      base_responses baseResponses = (base_responses) null;
      if (resources != null && resources.Length > 0)
      {
        sslcipher[] sslcipherArray = new sslcipher[resources.Length];
        for (int index = 0; index < resources.Length; ++index)
        {
          sslcipherArray[index] = new sslcipher();
          sslcipherArray[index].ciphergroupname = resources[index].ciphergroupname;
          sslcipherArray[index].ciphername = resources[index].ciphername;
        }
        baseResponses = base_resource.delete_bulk_request(client, (base_resource[]) sslcipherArray);
      }
      return baseResponses;
    }

    public static sslcipher[] get(nitro_service service) => (sslcipher[]) new sslcipher().get_resources(service, (options) null);

    public static sslcipher[] get(nitro_service service, options option) => (sslcipher[]) new sslcipher().get_resources(service, option);

    public static sslcipher[] get(nitro_service service, sslcipher_args args)
    {
      sslcipher sslcipher = new sslcipher();
      options option = new options();
      option.set_args(nitro_util.object_to_string_withoutquotes((object) args));
      return (sslcipher[]) sslcipher.get_resources(service, option);
    }

    public static sslcipher get(nitro_service service, string ciphergroupname) => (sslcipher) new sslcipher()
    {
      ciphergroupname = ciphergroupname
    }.get_resource(service);

    public static sslcipher[] get(nitro_service service, string[] ciphergroupname)
    {
      if (ciphergroupname == null || ciphergroupname.Length <= 0)
        return (sslcipher[]) null;
      sslcipher[] sslcipherArray1 = new sslcipher[ciphergroupname.Length];
      sslcipher[] sslcipherArray2 = new sslcipher[ciphergroupname.Length];
      for (int index = 0; index < ciphergroupname.Length; ++index)
      {
        sslcipherArray2[index] = new sslcipher();
        sslcipherArray2[index].ciphergroupname = ciphergroupname[index];
        sslcipherArray1[index] = (sslcipher) sslcipherArray2[index].get_resource(service);
      }
      return sslcipherArray1;
    }

    public static sslcipher[] get_filtered(nitro_service service, string filter)
    {
      sslcipher sslcipher = new sslcipher();
      options option = new options();
      option.set_filter(filter);
      return (sslcipher[]) sslcipher.getfiltered(service, option);
    }

    public static sslcipher[] get_filtered(nitro_service service, filtervalue[] filter)
    {
      sslcipher sslcipher = new sslcipher();
      options option = new options();
      option.set_filter(filter);
      return (sslcipher[]) sslcipher.getfiltered(service, option);
    }

    public static uint count(nitro_service service)
    {
      sslcipher sslcipher = new sslcipher();
      options option = new options();
      option.set_count(true);
      sslcipher[] resources = (sslcipher[]) sslcipher.get_resources(service, option);
      return resources != null && resources.Length > 0 ? resources[0].__count.Value : 0U;
    }

    public static uint count_filtered(nitro_service service, string filter)
    {
      sslcipher sslcipher = new sslcipher();
      options option = new options();
      option.set_count(true);
      option.set_filter(filter);
      sslcipher[] sslcipherArray = (sslcipher[]) sslcipher.getfiltered(service, option);
      return sslcipherArray != null && sslcipherArray.Length > 0 ? sslcipherArray[0].__count.Value : 0U;
    }

    public static uint count_filtered(nitro_service service, filtervalue[] filter)
    {
      sslcipher sslcipher = new sslcipher();
      options option = new options();
      option.set_count(true);
      option.set_filter(filter);
      sslcipher[] sslcipherArray = (sslcipher[]) sslcipher.getfiltered(service, option);
      return sslcipherArray != null && sslcipherArray.Length > 0 ? sslcipherArray[0].__count.Value : 0U;
    }

    private class sslcipher_response : base_response
    {
      public sslcipher[] sslcipher = (sslcipher[]) null;
    }
  }
}
