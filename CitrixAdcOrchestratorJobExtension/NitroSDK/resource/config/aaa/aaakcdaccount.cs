// Decompiled with JetBrains decompiler
// Type: com.citrix.netscaler.nitro.resource.config.aaa.aaakcdaccount
// Assembly: nitro, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 6CF5DDEF-E052-4F9D-953F-6644F8378A66


using com.citrix.netscaler.nitro.exception;
using com.citrix.netscaler.nitro.resource.Base;
using com.citrix.netscaler.nitro.service;
using com.citrix.netscaler.nitro.util;

namespace com.citrix.netscaler.nitro.resource.config.aaa
{
  public class aaakcdaccount : base_resource
  {
    private string kcdaccountField = (string) null;
    private string keytabField = (string) null;
    private string realmstrField = (string) null;
    private string delegateduserField = (string) null;
    private string kcdpasswordField = (string) null;
    private string usercertField = (string) null;
    private string cacertField = (string) null;
    private string userrealmField = (string) null;
    private string enterpriserealmField = (string) null;
    private string servicespnField = (string) null;
    private string principleField = (string) null;
    private string kcdspnField = (string) null;
    private uint? __countField = new uint?();

    public uint? __count
    {
      get => this.__countField;
      private set => this.__countField = value;
    }

    public string kcdaccount
    {
      get => this.kcdaccountField;
      set => this.kcdaccountField = value;
    }

    public string keytab
    {
      get => this.keytabField;
      set => this.keytabField = value;
    }

    public string realmstr
    {
      get => this.realmstrField;
      set => this.realmstrField = value;
    }

    public string delegateduser
    {
      get => this.delegateduserField;
      set => this.delegateduserField = value;
    }

    public string kcdpassword
    {
      get => this.kcdpasswordField;
      set => this.kcdpasswordField = value;
    }

    public string usercert
    {
      get => this.usercertField;
      set => this.usercertField = value;
    }

    public string cacert
    {
      get => this.cacertField;
      set => this.cacertField = value;
    }

    public string userrealm
    {
      get => this.userrealmField;
      set => this.userrealmField = value;
    }

    public string enterpriserealm
    {
      get => this.enterpriserealmField;
      set => this.enterpriserealmField = value;
    }

    public string servicespn
    {
      get => this.servicespnField;
      set => this.servicespnField = value;
    }

    public string principle
    {
      get => this.principleField;
      private set => this.principleField = value;
    }

    public string kcdspn
    {
      get => this.kcdspnField;
      private set => this.kcdspnField = value;
    }

    internal override base_resource[] get_nitro_response(
      nitro_service service,
      string response)
    {
      aaakcdaccount.aaakcdaccount_response aaakcdaccountResponse = new aaakcdaccount.aaakcdaccount_response();
      aaakcdaccount.aaakcdaccount_response resource = (aaakcdaccount.aaakcdaccount_response) service.get_payload_formatter().string_to_resource(aaakcdaccountResponse.GetType(), response);
      if (resource.errorcode != 0)
      {
        if (resource.errorcode == 444)
          service.clear_session();
        if (resource.severity == null)
          throw new nitro_exception(resource.message, resource.errorcode);
        if (resource.severity.Equals("ERROR"))
          throw new nitro_exception(resource.message, resource.errorcode);
      }
      return (base_resource[]) resource.aaakcdaccount;
    }

    internal override string get_object_name() => this.kcdaccount;

    public static base_response add(nitro_service client, aaakcdaccount resource) => new aaakcdaccount()
    {
      kcdaccount = resource.kcdaccount,
      keytab = resource.keytab,
      realmstr = resource.realmstr,
      delegateduser = resource.delegateduser,
      kcdpassword = resource.kcdpassword,
      usercert = resource.usercert,
      cacert = resource.cacert,
      userrealm = resource.userrealm,
      enterpriserealm = resource.enterpriserealm,
      servicespn = resource.servicespn
    }.add_resource(client);

    public static base_responses add(nitro_service client, aaakcdaccount[] resources)
    {
      base_responses baseResponses = (base_responses) null;
      if (resources != null && resources.Length > 0)
      {
        aaakcdaccount[] aaakcdaccountArray = new aaakcdaccount[resources.Length];
        for (int index = 0; index < resources.Length; ++index)
        {
          aaakcdaccountArray[index] = new aaakcdaccount();
          aaakcdaccountArray[index].kcdaccount = resources[index].kcdaccount;
          aaakcdaccountArray[index].keytab = resources[index].keytab;
          aaakcdaccountArray[index].realmstr = resources[index].realmstr;
          aaakcdaccountArray[index].delegateduser = resources[index].delegateduser;
          aaakcdaccountArray[index].kcdpassword = resources[index].kcdpassword;
          aaakcdaccountArray[index].usercert = resources[index].usercert;
          aaakcdaccountArray[index].cacert = resources[index].cacert;
          aaakcdaccountArray[index].userrealm = resources[index].userrealm;
          aaakcdaccountArray[index].enterpriserealm = resources[index].enterpriserealm;
          aaakcdaccountArray[index].servicespn = resources[index].servicespn;
        }
        baseResponses = base_resource.add_bulk_request(client, (base_resource[]) aaakcdaccountArray);
      }
      return baseResponses;
    }

    public static base_response delete(nitro_service client, string kcdaccount) => new aaakcdaccount()
    {
      kcdaccount = kcdaccount
    }.delete_resource(client);

    public static base_response delete(nitro_service client, aaakcdaccount resource) => new aaakcdaccount()
    {
      kcdaccount = resource.kcdaccount
    }.delete_resource(client);

    public static base_responses delete(nitro_service client, string[] kcdaccount)
    {
      base_responses baseResponses = (base_responses) null;
      if (kcdaccount != null && kcdaccount.Length > 0)
      {
        aaakcdaccount[] aaakcdaccountArray = new aaakcdaccount[kcdaccount.Length];
        for (int index = 0; index < kcdaccount.Length; ++index)
        {
          aaakcdaccountArray[index] = new aaakcdaccount();
          aaakcdaccountArray[index].kcdaccount = kcdaccount[index];
        }
        baseResponses = base_resource.delete_bulk_request(client, (base_resource[]) aaakcdaccountArray);
      }
      return baseResponses;
    }

    public static base_responses delete(
      nitro_service client,
      aaakcdaccount[] resources)
    {
      base_responses baseResponses = (base_responses) null;
      if (resources != null && resources.Length > 0)
      {
        aaakcdaccount[] aaakcdaccountArray = new aaakcdaccount[resources.Length];
        for (int index = 0; index < resources.Length; ++index)
        {
          aaakcdaccountArray[index] = new aaakcdaccount();
          aaakcdaccountArray[index].kcdaccount = resources[index].kcdaccount;
        }
        baseResponses = base_resource.delete_bulk_request(client, (base_resource[]) aaakcdaccountArray);
      }
      return baseResponses;
    }

    public static base_response update(nitro_service client, aaakcdaccount resource) => new aaakcdaccount()
    {
      kcdaccount = resource.kcdaccount,
      keytab = resource.keytab,
      realmstr = resource.realmstr,
      delegateduser = resource.delegateduser,
      kcdpassword = resource.kcdpassword,
      usercert = resource.usercert,
      cacert = resource.cacert,
      userrealm = resource.userrealm,
      enterpriserealm = resource.enterpriserealm,
      servicespn = resource.servicespn
    }.update_resource(client);

    public static base_responses update(
      nitro_service client,
      aaakcdaccount[] resources)
    {
      base_responses baseResponses = (base_responses) null;
      if (resources != null && resources.Length > 0)
      {
        aaakcdaccount[] aaakcdaccountArray = new aaakcdaccount[resources.Length];
        for (int index = 0; index < resources.Length; ++index)
        {
          aaakcdaccountArray[index] = new aaakcdaccount();
          aaakcdaccountArray[index].kcdaccount = resources[index].kcdaccount;
          aaakcdaccountArray[index].keytab = resources[index].keytab;
          aaakcdaccountArray[index].realmstr = resources[index].realmstr;
          aaakcdaccountArray[index].delegateduser = resources[index].delegateduser;
          aaakcdaccountArray[index].kcdpassword = resources[index].kcdpassword;
          aaakcdaccountArray[index].usercert = resources[index].usercert;
          aaakcdaccountArray[index].cacert = resources[index].cacert;
          aaakcdaccountArray[index].userrealm = resources[index].userrealm;
          aaakcdaccountArray[index].enterpriserealm = resources[index].enterpriserealm;
          aaakcdaccountArray[index].servicespn = resources[index].servicespn;
        }
        baseResponses = base_resource.update_bulk_request(client, (base_resource[]) aaakcdaccountArray);
      }
      return baseResponses;
    }

    public static base_response unset(
      nitro_service client,
      string kcdaccount,
      string[] args)
    {
      return new aaakcdaccount() { kcdaccount = kcdaccount }.unset_resource(client, args);
    }

    public static base_response unset(
      nitro_service client,
      aaakcdaccount resource,
      string[] args)
    {
      return new aaakcdaccount()
      {
        kcdaccount = resource.kcdaccount,
        keytab = resource.keytab
      }.unset_resource(client, args);
    }

    public static base_responses unset(
      nitro_service client,
      string[] kcdaccount,
      string[] args)
    {
      base_responses baseResponses = (base_responses) null;
      if (kcdaccount != null && kcdaccount.Length > 0)
      {
        aaakcdaccount[] aaakcdaccountArray = new aaakcdaccount[kcdaccount.Length];
        for (int index = 0; index < kcdaccount.Length; ++index)
        {
          aaakcdaccountArray[index] = new aaakcdaccount();
          aaakcdaccountArray[index].kcdaccount = kcdaccount[index];
        }
        baseResponses = base_resource.unset_bulk_request(client, (base_resource[]) aaakcdaccountArray, args);
      }
      return baseResponses;
    }

    public static base_responses unset(
      nitro_service client,
      aaakcdaccount[] resources,
      string[] args)
    {
      base_responses baseResponses = (base_responses) null;
      if (resources != null && resources.Length > 0)
      {
        aaakcdaccount[] aaakcdaccountArray = new aaakcdaccount[resources.Length];
        for (int index = 0; index < resources.Length; ++index)
        {
          aaakcdaccountArray[index] = new aaakcdaccount();
          aaakcdaccountArray[index].kcdaccount = resources[index].kcdaccount;
          aaakcdaccountArray[index].keytab = resources[index].keytab;
        }
        baseResponses = base_resource.unset_bulk_request(client, (base_resource[]) aaakcdaccountArray, args);
      }
      return baseResponses;
    }

    public static aaakcdaccount[] get(nitro_service service) => (aaakcdaccount[]) new aaakcdaccount().get_resources(service, (options) null);

    public static aaakcdaccount[] get(nitro_service service, options option) => (aaakcdaccount[]) new aaakcdaccount().get_resources(service, option);

    public static aaakcdaccount get(nitro_service service, string kcdaccount) => (aaakcdaccount) new aaakcdaccount()
    {
      kcdaccount = kcdaccount
    }.get_resource(service);

    public static aaakcdaccount[] get(nitro_service service, string[] kcdaccount)
    {
      if (kcdaccount == null || kcdaccount.Length <= 0)
        return (aaakcdaccount[]) null;
      aaakcdaccount[] aaakcdaccountArray1 = new aaakcdaccount[kcdaccount.Length];
      aaakcdaccount[] aaakcdaccountArray2 = new aaakcdaccount[kcdaccount.Length];
      for (int index = 0; index < kcdaccount.Length; ++index)
      {
        aaakcdaccountArray2[index] = new aaakcdaccount();
        aaakcdaccountArray2[index].kcdaccount = kcdaccount[index];
        aaakcdaccountArray1[index] = (aaakcdaccount) aaakcdaccountArray2[index].get_resource(service);
      }
      return aaakcdaccountArray1;
    }

    public static aaakcdaccount[] get_filtered(nitro_service service, string filter)
    {
      aaakcdaccount aaakcdaccount = new aaakcdaccount();
      options option = new options();
      option.set_filter(filter);
      return (aaakcdaccount[]) aaakcdaccount.getfiltered(service, option);
    }

    public static aaakcdaccount[] get_filtered(
      nitro_service service,
      filtervalue[] filter)
    {
      aaakcdaccount aaakcdaccount = new aaakcdaccount();
      options option = new options();
      option.set_filter(filter);
      return (aaakcdaccount[]) aaakcdaccount.getfiltered(service, option);
    }

    public static uint count(nitro_service service)
    {
      aaakcdaccount aaakcdaccount = new aaakcdaccount();
      options option = new options();
      option.set_count(true);
      aaakcdaccount[] resources = (aaakcdaccount[]) aaakcdaccount.get_resources(service, option);
      return resources != null && resources.Length > 0 ? resources[0].__count.Value : 0U;
    }

    public static uint count_filtered(nitro_service service, string filter)
    {
      aaakcdaccount aaakcdaccount = new aaakcdaccount();
      options option = new options();
      option.set_count(true);
      option.set_filter(filter);
      aaakcdaccount[] aaakcdaccountArray = (aaakcdaccount[]) aaakcdaccount.getfiltered(service, option);
      return aaakcdaccountArray != null && aaakcdaccountArray.Length > 0 ? aaakcdaccountArray[0].__count.Value : 0U;
    }

    public static uint count_filtered(nitro_service service, filtervalue[] filter)
    {
      aaakcdaccount aaakcdaccount = new aaakcdaccount();
      options option = new options();
      option.set_count(true);
      option.set_filter(filter);
      aaakcdaccount[] aaakcdaccountArray = (aaakcdaccount[]) aaakcdaccount.getfiltered(service, option);
      return aaakcdaccountArray != null && aaakcdaccountArray.Length > 0 ? aaakcdaccountArray[0].__count.Value : 0U;
    }

    private class aaakcdaccount_response : base_response
    {
      public aaakcdaccount[] aaakcdaccount = (aaakcdaccount[]) null;
    }
  }
}
