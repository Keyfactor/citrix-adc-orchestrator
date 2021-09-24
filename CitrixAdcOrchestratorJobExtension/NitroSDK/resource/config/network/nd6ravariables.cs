// Decompiled with JetBrains decompiler
// Type: com.citrix.netscaler.nitro.resource.config.network.nd6ravariables
// Assembly: nitro, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 6CF5DDEF-E052-4F9D-953F-6644F8378A66


using com.citrix.netscaler.nitro.exception;
using com.citrix.netscaler.nitro.resource.Base;
using com.citrix.netscaler.nitro.service;
using com.citrix.netscaler.nitro.util;

namespace com.citrix.netscaler.nitro.resource.config.network
{
  public class nd6ravariables : base_resource
  {
    private uint? vlanField = new uint?();
    private string ceaserouteradvField = (string) null;
    private string sendrouteradvField = (string) null;
    private string srclinklayeraddroptionField = (string) null;
    private string onlyunicastrtadvresponseField = (string) null;
    private string managedaddrconfigField = (string) null;
    private string otheraddrconfigField = (string) null;
    private uint? currhoplimitField = new uint?();
    private uint? maxrtadvintervalField = new uint?();
    private uint? minrtadvintervalField = new uint?();
    private uint? linkmtuField = new uint?();
    private uint? reachabletimeField = new uint?();
    private uint? retranstimeField = new uint?();
    private int? defaultlifetimeField = new int?();
    private uint? lastrtadvtimeField = new uint?();
    private uint? nextrtadvdelayField = new uint?();
    private uint? __countField = new uint?();

    public uint? __count
    {
      get => this.__countField;
      private set => this.__countField = value;
    }

    public uint? vlan
    {
      get => this.vlanField;
      set => this.vlanField = value;
    }

    public string ceaserouteradv
    {
      get => this.ceaserouteradvField;
      set => this.ceaserouteradvField = value;
    }

    public string sendrouteradv
    {
      get => this.sendrouteradvField;
      set => this.sendrouteradvField = value;
    }

    public string srclinklayeraddroption
    {
      get => this.srclinklayeraddroptionField;
      set => this.srclinklayeraddroptionField = value;
    }

    public string onlyunicastrtadvresponse
    {
      get => this.onlyunicastrtadvresponseField;
      set => this.onlyunicastrtadvresponseField = value;
    }

    public string managedaddrconfig
    {
      get => this.managedaddrconfigField;
      set => this.managedaddrconfigField = value;
    }

    public string otheraddrconfig
    {
      get => this.otheraddrconfigField;
      set => this.otheraddrconfigField = value;
    }

    public uint? currhoplimit
    {
      get => this.currhoplimitField;
      set => this.currhoplimitField = value;
    }

    public uint? maxrtadvinterval
    {
      get => this.maxrtadvintervalField;
      set => this.maxrtadvintervalField = value;
    }

    public uint? minrtadvinterval
    {
      get => this.minrtadvintervalField;
      set => this.minrtadvintervalField = value;
    }

    public uint? linkmtu
    {
      get => this.linkmtuField;
      set => this.linkmtuField = value;
    }

    public uint? reachabletime
    {
      get => this.reachabletimeField;
      set => this.reachabletimeField = value;
    }

    public uint? retranstime
    {
      get => this.retranstimeField;
      set => this.retranstimeField = value;
    }

    public int? defaultlifetime
    {
      get => this.defaultlifetimeField;
      set => this.defaultlifetimeField = value;
    }

    public uint? lastrtadvtime
    {
      get => this.lastrtadvtimeField;
      private set => this.lastrtadvtimeField = value;
    }

    public uint? nextrtadvdelay
    {
      get => this.nextrtadvdelayField;
      private set => this.nextrtadvdelayField = value;
    }

    internal override base_resource[] get_nitro_response(
      nitro_service service,
      string response)
    {
      nd6ravariables.nd6ravariables_response nd6ravariablesResponse = new nd6ravariables.nd6ravariables_response();
      nd6ravariables.nd6ravariables_response resource = (nd6ravariables.nd6ravariables_response) service.get_payload_formatter().string_to_resource(nd6ravariablesResponse.GetType(), response);
      if (resource.errorcode != 0)
      {
        if (resource.errorcode == 444)
          service.clear_session();
        if (resource.severity == null)
          throw new nitro_exception(resource.message, resource.errorcode);
        if (resource.severity.Equals("ERROR"))
          throw new nitro_exception(resource.message, resource.errorcode);
      }
      return (base_resource[]) resource.nd6ravariables;
    }

    internal override string get_object_name() => this.vlan.HasValue ? this.vlan.ToString() : (string) null;

    public static base_response update(nitro_service client, nd6ravariables resource) => new nd6ravariables()
    {
      vlan = resource.vlan,
      ceaserouteradv = resource.ceaserouteradv,
      sendrouteradv = resource.sendrouteradv,
      srclinklayeraddroption = resource.srclinklayeraddroption,
      onlyunicastrtadvresponse = resource.onlyunicastrtadvresponse,
      managedaddrconfig = resource.managedaddrconfig,
      otheraddrconfig = resource.otheraddrconfig,
      currhoplimit = resource.currhoplimit,
      maxrtadvinterval = resource.maxrtadvinterval,
      minrtadvinterval = resource.minrtadvinterval,
      linkmtu = resource.linkmtu,
      reachabletime = resource.reachabletime,
      retranstime = resource.retranstime,
      defaultlifetime = resource.defaultlifetime
    }.update_resource(client);

    public static base_responses update(
      nitro_service client,
      nd6ravariables[] resources)
    {
      base_responses baseResponses = (base_responses) null;
      if (resources != null && resources.Length > 0)
      {
        nd6ravariables[] nd6ravariablesArray = new nd6ravariables[resources.Length];
        for (int index = 0; index < resources.Length; ++index)
        {
          nd6ravariablesArray[index] = new nd6ravariables();
          nd6ravariablesArray[index].vlan = resources[index].vlan;
          nd6ravariablesArray[index].ceaserouteradv = resources[index].ceaserouteradv;
          nd6ravariablesArray[index].sendrouteradv = resources[index].sendrouteradv;
          nd6ravariablesArray[index].srclinklayeraddroption = resources[index].srclinklayeraddroption;
          nd6ravariablesArray[index].onlyunicastrtadvresponse = resources[index].onlyunicastrtadvresponse;
          nd6ravariablesArray[index].managedaddrconfig = resources[index].managedaddrconfig;
          nd6ravariablesArray[index].otheraddrconfig = resources[index].otheraddrconfig;
          nd6ravariablesArray[index].currhoplimit = resources[index].currhoplimit;
          nd6ravariablesArray[index].maxrtadvinterval = resources[index].maxrtadvinterval;
          nd6ravariablesArray[index].minrtadvinterval = resources[index].minrtadvinterval;
          nd6ravariablesArray[index].linkmtu = resources[index].linkmtu;
          nd6ravariablesArray[index].reachabletime = resources[index].reachabletime;
          nd6ravariablesArray[index].retranstime = resources[index].retranstime;
          nd6ravariablesArray[index].defaultlifetime = resources[index].defaultlifetime;
        }
        baseResponses = base_resource.update_bulk_request(client, (base_resource[]) nd6ravariablesArray);
      }
      return baseResponses;
    }

    public static base_response unset(nitro_service client, uint? vlan, string[] args) => new nd6ravariables()
    {
      vlan = vlan
    }.unset_resource(client, args);

    public static base_response unset(
      nitro_service client,
      nd6ravariables resource,
      string[] args)
    {
      return new nd6ravariables() { vlan = resource.vlan }.unset_resource(client, args);
    }

    public static base_responses unset(
      nitro_service client,
      uint?[] vlan,
      string[] args)
    {
      base_responses baseResponses = (base_responses) null;
      if (vlan != null && vlan.Length > 0)
      {
        nd6ravariables[] nd6ravariablesArray = new nd6ravariables[vlan.Length];
        for (int index = 0; index < vlan.Length; ++index)
        {
          nd6ravariablesArray[index] = new nd6ravariables();
          nd6ravariablesArray[index].vlan = vlan[index];
        }
        baseResponses = base_resource.unset_bulk_request(client, (base_resource[]) nd6ravariablesArray, args);
      }
      return baseResponses;
    }

    public static base_responses unset(
      nitro_service client,
      nd6ravariables[] resources,
      string[] args)
    {
      base_responses baseResponses = (base_responses) null;
      if (resources != null && resources.Length > 0)
      {
        nd6ravariables[] nd6ravariablesArray = new nd6ravariables[resources.Length];
        for (int index = 0; index < resources.Length; ++index)
        {
          nd6ravariablesArray[index] = new nd6ravariables();
          nd6ravariablesArray[index].vlan = resources[index].vlan;
        }
        baseResponses = base_resource.unset_bulk_request(client, (base_resource[]) nd6ravariablesArray, args);
      }
      return baseResponses;
    }

    public static nd6ravariables[] get(nitro_service service) => (nd6ravariables[]) new nd6ravariables().get_resources(service, (options) null);

    public static nd6ravariables[] get(nitro_service service, options option) => (nd6ravariables[]) new nd6ravariables().get_resources(service, option);

    public static nd6ravariables get(nitro_service service, uint? vlan) => (nd6ravariables) new nd6ravariables()
    {
      vlan = vlan
    }.get_resource(service);

    public static nd6ravariables[] get(nitro_service service, uint?[] vlan)
    {
      if (vlan == null || vlan.Length <= 0)
        return (nd6ravariables[]) null;
      nd6ravariables[] nd6ravariablesArray1 = new nd6ravariables[vlan.Length];
      nd6ravariables[] nd6ravariablesArray2 = new nd6ravariables[vlan.Length];
      for (int index = 0; index < vlan.Length; ++index)
      {
        nd6ravariablesArray2[index] = new nd6ravariables();
        nd6ravariablesArray2[index].vlan = vlan[index];
        nd6ravariablesArray1[index] = (nd6ravariables) nd6ravariablesArray2[index].get_resource(service);
      }
      return nd6ravariablesArray1;
    }

    public static nd6ravariables[] get_filtered(nitro_service service, string filter)
    {
      nd6ravariables nd6ravariables = new nd6ravariables();
      options option = new options();
      option.set_filter(filter);
      return (nd6ravariables[]) nd6ravariables.getfiltered(service, option);
    }

    public static nd6ravariables[] get_filtered(
      nitro_service service,
      filtervalue[] filter)
    {
      nd6ravariables nd6ravariables = new nd6ravariables();
      options option = new options();
      option.set_filter(filter);
      return (nd6ravariables[]) nd6ravariables.getfiltered(service, option);
    }

    public static uint count(nitro_service service)
    {
      nd6ravariables nd6ravariables = new nd6ravariables();
      options option = new options();
      option.set_count(true);
      nd6ravariables[] resources = (nd6ravariables[]) nd6ravariables.get_resources(service, option);
      return resources != null && resources.Length > 0 ? resources[0].__count.Value : 0U;
    }

    public static uint count_filtered(nitro_service service, string filter)
    {
      nd6ravariables nd6ravariables = new nd6ravariables();
      options option = new options();
      option.set_count(true);
      option.set_filter(filter);
      nd6ravariables[] nd6ravariablesArray = (nd6ravariables[]) nd6ravariables.getfiltered(service, option);
      return nd6ravariablesArray != null && nd6ravariablesArray.Length > 0 ? nd6ravariablesArray[0].__count.Value : 0U;
    }

    public static uint count_filtered(nitro_service service, filtervalue[] filter)
    {
      nd6ravariables nd6ravariables = new nd6ravariables();
      options option = new options();
      option.set_count(true);
      option.set_filter(filter);
      nd6ravariables[] nd6ravariablesArray = (nd6ravariables[]) nd6ravariables.getfiltered(service, option);
      return nd6ravariablesArray != null && nd6ravariablesArray.Length > 0 ? nd6ravariablesArray[0].__count.Value : 0U;
    }

    private class nd6ravariables_response : base_response
    {
      public nd6ravariables[] nd6ravariables = (nd6ravariables[]) null;
    }

    public static class managedaddrconfigEnum
    {
      public const string YES = "YES";
      public const string NO = "NO";
    }

    public static class onlyunicastrtadvresponseEnum
    {
      public const string YES = "YES";
      public const string NO = "NO";
    }

    public static class sendrouteradvEnum
    {
      public const string YES = "YES";
      public const string NO = "NO";
    }

    public static class otheraddrconfigEnum
    {
      public const string YES = "YES";
      public const string NO = "NO";
    }

    public static class srclinklayeraddroptionEnum
    {
      public const string YES = "YES";
      public const string NO = "NO";
    }

    public static class ceaserouteradvEnum
    {
      public const string YES = "YES";
      public const string NO = "NO";
    }
  }
}
