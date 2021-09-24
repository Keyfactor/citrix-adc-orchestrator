// Decompiled with JetBrains decompiler
// Type: com.citrix.netscaler.nitro.resource.config.cluster.clusterinstance
// Assembly: nitro, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 6CF5DDEF-E052-4F9D-953F-6644F8378A66


using com.citrix.netscaler.nitro.exception;
using com.citrix.netscaler.nitro.resource.Base;
using com.citrix.netscaler.nitro.service;
using com.citrix.netscaler.nitro.util;

namespace com.citrix.netscaler.nitro.resource.config.cluster
{
  public class clusterinstance : base_resource
  {
    private uint? clidField = new uint?();
    private long? deadintervalField = new long?();
    private uint? hellointervalField = new uint?();
    private string preemptionField = (string) null;
    private string quorumtypeField = (string) null;
    private string incField = (string) null;
    private string processlocalField = (string) null;
    private string nodegroupField = (string) null;
    private string adminstateField = (string) null;
    private string propstateField = (string) null;
    private string operationalstateField = (string) null;
    private string statusField = (string) null;
    private bool? rsskeymismatchField = new bool?();
    private bool? nodegroupstatewarningField = new bool?();
    private bool? licensemismatchField = new bool?();
    private bool? jumbonotsupportedField = new bool?();
    private bool? clusternoheartbeatonnodeField = new bool?();
    private bool? clusternolinksetmbfField = new bool?();
    private bool? clusternospottedipField = new bool?();
    private string operationalpropstateField = (string) null;
    private uint? __countField = new uint?();

    public uint? __count
    {
      get => this.__countField;
      private set => this.__countField = value;
    }

    public uint? clid
    {
      get => this.clidField;
      set => this.clidField = value;
    }

    public long? deadinterval
    {
      get => this.deadintervalField;
      set => this.deadintervalField = value;
    }

    public uint? hellointerval
    {
      get => this.hellointervalField;
      set => this.hellointervalField = value;
    }

    public string preemption
    {
      get => this.preemptionField;
      set => this.preemptionField = value;
    }

    public string quorumtype
    {
      get => this.quorumtypeField;
      set => this.quorumtypeField = value;
    }

    public string inc
    {
      get => this.incField;
      set => this.incField = value;
    }

    public string processlocal
    {
      get => this.processlocalField;
      set => this.processlocalField = value;
    }

    public string nodegroup
    {
      get => this.nodegroupField;
      set => this.nodegroupField = value;
    }

    public string adminstate
    {
      get => this.adminstateField;
      private set => this.adminstateField = value;
    }

    public string propstate
    {
      get => this.propstateField;
      private set => this.propstateField = value;
    }

    public string operationalstate
    {
      get => this.operationalstateField;
      private set => this.operationalstateField = value;
    }

    public string status
    {
      get => this.statusField;
      private set => this.statusField = value;
    }

    public bool? rsskeymismatch
    {
      get => this.rsskeymismatchField;
      private set => this.rsskeymismatchField = value;
    }

    public bool? nodegroupstatewarning
    {
      get => this.nodegroupstatewarningField;
      private set => this.nodegroupstatewarningField = value;
    }

    public bool? licensemismatch
    {
      get => this.licensemismatchField;
      private set => this.licensemismatchField = value;
    }

    public bool? jumbonotsupported
    {
      get => this.jumbonotsupportedField;
      private set => this.jumbonotsupportedField = value;
    }

    public bool? clusternoheartbeatonnode
    {
      get => this.clusternoheartbeatonnodeField;
      private set => this.clusternoheartbeatonnodeField = value;
    }

    public bool? clusternolinksetmbf
    {
      get => this.clusternolinksetmbfField;
      private set => this.clusternolinksetmbfField = value;
    }

    public bool? clusternospottedip
    {
      get => this.clusternospottedipField;
      private set => this.clusternospottedipField = value;
    }

    public string operationalpropstate
    {
      get => this.operationalpropstateField;
      private set => this.operationalpropstateField = value;
    }

    internal override base_resource[] get_nitro_response(
      nitro_service service,
      string response)
    {
      clusterinstance.clusterinstance_response clusterinstanceResponse = new clusterinstance.clusterinstance_response();
      clusterinstance.clusterinstance_response resource = (clusterinstance.clusterinstance_response) service.get_payload_formatter().string_to_resource(clusterinstanceResponse.GetType(), response);
      if (resource.errorcode != 0)
      {
        if (resource.errorcode == 444)
          service.clear_session();
        if (resource.severity == null)
          throw new nitro_exception(resource.message, resource.errorcode);
        if (resource.severity.Equals("ERROR"))
          throw new nitro_exception(resource.message, resource.errorcode);
      }
      return (base_resource[]) resource.clusterinstance;
    }

    internal override string get_object_name() => this.clid.HasValue ? this.clid.ToString() : (string) null;

    public static base_response add(nitro_service client, clusterinstance resource) => new clusterinstance()
    {
      clid = resource.clid,
      deadinterval = resource.deadinterval,
      hellointerval = resource.hellointerval,
      preemption = resource.preemption,
      quorumtype = resource.quorumtype,
      inc = resource.inc,
      processlocal = resource.processlocal
    }.add_resource(client);

    public static base_responses add(
      nitro_service client,
      clusterinstance[] resources)
    {
      base_responses baseResponses = (base_responses) null;
      if (resources != null && resources.Length > 0)
      {
        clusterinstance[] clusterinstanceArray = new clusterinstance[resources.Length];
        for (int index = 0; index < resources.Length; ++index)
        {
          clusterinstanceArray[index] = new clusterinstance();
          clusterinstanceArray[index].clid = resources[index].clid;
          clusterinstanceArray[index].deadinterval = resources[index].deadinterval;
          clusterinstanceArray[index].hellointerval = resources[index].hellointerval;
          clusterinstanceArray[index].preemption = resources[index].preemption;
          clusterinstanceArray[index].quorumtype = resources[index].quorumtype;
          clusterinstanceArray[index].inc = resources[index].inc;
          clusterinstanceArray[index].processlocal = resources[index].processlocal;
        }
        baseResponses = base_resource.add_bulk_request(client, (base_resource[]) clusterinstanceArray);
      }
      return baseResponses;
    }

    public static base_response delete(nitro_service client, uint? clid) => new clusterinstance()
    {
      clid = clid
    }.delete_resource(client);

    public static base_response delete(nitro_service client, clusterinstance resource) => new clusterinstance()
    {
      clid = resource.clid
    }.delete_resource(client);

    public static base_responses delete(nitro_service client, uint?[] clid)
    {
      base_responses baseResponses = (base_responses) null;
      if (clid != null && clid.Length > 0)
      {
        clusterinstance[] clusterinstanceArray = new clusterinstance[clid.Length];
        for (int index = 0; index < clid.Length; ++index)
        {
          clusterinstanceArray[index] = new clusterinstance();
          clusterinstanceArray[index].clid = clid[index];
        }
        baseResponses = base_resource.delete_bulk_request(client, (base_resource[]) clusterinstanceArray);
      }
      return baseResponses;
    }

    public static base_responses delete(
      nitro_service client,
      clusterinstance[] resources)
    {
      base_responses baseResponses = (base_responses) null;
      if (resources != null && resources.Length > 0)
      {
        clusterinstance[] clusterinstanceArray = new clusterinstance[resources.Length];
        for (int index = 0; index < resources.Length; ++index)
        {
          clusterinstanceArray[index] = new clusterinstance();
          clusterinstanceArray[index].clid = resources[index].clid;
        }
        baseResponses = base_resource.delete_bulk_request(client, (base_resource[]) clusterinstanceArray);
      }
      return baseResponses;
    }

    public static base_response update(nitro_service client, clusterinstance resource) => new clusterinstance()
    {
      clid = resource.clid,
      deadinterval = resource.deadinterval,
      hellointerval = resource.hellointerval,
      preemption = resource.preemption,
      quorumtype = resource.quorumtype,
      inc = resource.inc,
      processlocal = resource.processlocal,
      nodegroup = resource.nodegroup
    }.update_resource(client);

    public static base_responses update(
      nitro_service client,
      clusterinstance[] resources)
    {
      base_responses baseResponses = (base_responses) null;
      if (resources != null && resources.Length > 0)
      {
        clusterinstance[] clusterinstanceArray = new clusterinstance[resources.Length];
        for (int index = 0; index < resources.Length; ++index)
        {
          clusterinstanceArray[index] = new clusterinstance();
          clusterinstanceArray[index].clid = resources[index].clid;
          clusterinstanceArray[index].deadinterval = resources[index].deadinterval;
          clusterinstanceArray[index].hellointerval = resources[index].hellointerval;
          clusterinstanceArray[index].preemption = resources[index].preemption;
          clusterinstanceArray[index].quorumtype = resources[index].quorumtype;
          clusterinstanceArray[index].inc = resources[index].inc;
          clusterinstanceArray[index].processlocal = resources[index].processlocal;
          clusterinstanceArray[index].nodegroup = resources[index].nodegroup;
        }
        baseResponses = base_resource.update_bulk_request(client, (base_resource[]) clusterinstanceArray);
      }
      return baseResponses;
    }

    public static base_response unset(nitro_service client, uint? clid, string[] args) => new clusterinstance()
    {
      clid = clid
    }.unset_resource(client, args);

    public static base_response unset(
      nitro_service client,
      clusterinstance resource,
      string[] args)
    {
      return new clusterinstance() { clid = resource.clid }.unset_resource(client, args);
    }

    public static base_responses unset(
      nitro_service client,
      uint?[] clid,
      string[] args)
    {
      base_responses baseResponses = (base_responses) null;
      if (clid != null && clid.Length > 0)
      {
        clusterinstance[] clusterinstanceArray = new clusterinstance[clid.Length];
        for (int index = 0; index < clid.Length; ++index)
        {
          clusterinstanceArray[index] = new clusterinstance();
          clusterinstanceArray[index].clid = clid[index];
        }
        baseResponses = base_resource.unset_bulk_request(client, (base_resource[]) clusterinstanceArray, args);
      }
      return baseResponses;
    }

    public static base_responses unset(
      nitro_service client,
      clusterinstance[] resources,
      string[] args)
    {
      base_responses baseResponses = (base_responses) null;
      if (resources != null && resources.Length > 0)
      {
        clusterinstance[] clusterinstanceArray = new clusterinstance[resources.Length];
        for (int index = 0; index < resources.Length; ++index)
        {
          clusterinstanceArray[index] = new clusterinstance();
          clusterinstanceArray[index].clid = resources[index].clid;
        }
        baseResponses = base_resource.unset_bulk_request(client, (base_resource[]) clusterinstanceArray, args);
      }
      return baseResponses;
    }

    public static base_response enable(nitro_service client, uint? clid) => new clusterinstance()
    {
      clid = clid
    }.perform_operation_byaction(client, nameof (enable));

    public static base_response enable(nitro_service client, clusterinstance resource) => new clusterinstance()
    {
      clid = resource.clid
    }.perform_operation_byaction(client, nameof (enable));

    public static base_responses enable(nitro_service client, uint?[] clid)
    {
      base_responses baseResponses = (base_responses) null;
      if (clid != null && clid.Length > 0)
      {
        clusterinstance[] clusterinstanceArray = new clusterinstance[clid.Length];
        for (int index = 0; index < clid.Length; ++index)
        {
          clusterinstanceArray[index] = new clusterinstance();
          clusterinstanceArray[index].clid = clid[index];
        }
        baseResponses = base_resource.perform_operation_bulk_request(client, (base_resource[]) clusterinstanceArray, nameof (enable));
      }
      return baseResponses;
    }

    public static base_responses enable(
      nitro_service client,
      clusterinstance[] resources)
    {
      base_responses baseResponses = (base_responses) null;
      if (resources != null && resources.Length > 0)
      {
        clusterinstance[] clusterinstanceArray = new clusterinstance[resources.Length];
        for (int index = 0; index < resources.Length; ++index)
        {
          clusterinstanceArray[index] = new clusterinstance();
          clusterinstanceArray[index].clid = resources[index].clid;
        }
        baseResponses = base_resource.perform_operation_bulk_request(client, (base_resource[]) clusterinstanceArray, nameof (enable));
      }
      return baseResponses;
    }

    public static base_response disable(nitro_service client, uint? clid) => new clusterinstance()
    {
      clid = clid
    }.perform_operation_byaction(client, nameof (disable));

    public static base_response disable(nitro_service client, clusterinstance resource) => new clusterinstance()
    {
      clid = resource.clid
    }.perform_operation_byaction(client, nameof (disable));

    public static base_responses disable(nitro_service client, uint?[] clid)
    {
      base_responses baseResponses = (base_responses) null;
      if (clid != null && clid.Length > 0)
      {
        clusterinstance[] clusterinstanceArray = new clusterinstance[clid.Length];
        for (int index = 0; index < clid.Length; ++index)
        {
          clusterinstanceArray[index] = new clusterinstance();
          clusterinstanceArray[index].clid = clid[index];
        }
        baseResponses = base_resource.perform_operation_bulk_request(client, (base_resource[]) clusterinstanceArray, nameof (disable));
      }
      return baseResponses;
    }

    public static base_responses disable(
      nitro_service client,
      clusterinstance[] resources)
    {
      base_responses baseResponses = (base_responses) null;
      if (resources != null && resources.Length > 0)
      {
        clusterinstance[] clusterinstanceArray = new clusterinstance[resources.Length];
        for (int index = 0; index < resources.Length; ++index)
        {
          clusterinstanceArray[index] = new clusterinstance();
          clusterinstanceArray[index].clid = resources[index].clid;
        }
        baseResponses = base_resource.perform_operation_bulk_request(client, (base_resource[]) clusterinstanceArray, nameof (disable));
      }
      return baseResponses;
    }

    public static clusterinstance[] get(nitro_service service) => (clusterinstance[]) new clusterinstance().get_resources(service, (options) null);

    public static clusterinstance[] get(nitro_service service, options option) => (clusterinstance[]) new clusterinstance().get_resources(service, option);

    public static clusterinstance get(nitro_service service, uint? clid) => (clusterinstance) new clusterinstance()
    {
      clid = clid
    }.get_resource(service);

    public static clusterinstance[] get(nitro_service service, uint?[] clid)
    {
      if (clid == null || clid.Length <= 0)
        return (clusterinstance[]) null;
      clusterinstance[] clusterinstanceArray1 = new clusterinstance[clid.Length];
      clusterinstance[] clusterinstanceArray2 = new clusterinstance[clid.Length];
      for (int index = 0; index < clid.Length; ++index)
      {
        clusterinstanceArray2[index] = new clusterinstance();
        clusterinstanceArray2[index].clid = clid[index];
        clusterinstanceArray1[index] = (clusterinstance) clusterinstanceArray2[index].get_resource(service);
      }
      return clusterinstanceArray1;
    }

    public static clusterinstance[] get_filtered(
      nitro_service service,
      string filter)
    {
      clusterinstance clusterinstance = new clusterinstance();
      options option = new options();
      option.set_filter(filter);
      return (clusterinstance[]) clusterinstance.getfiltered(service, option);
    }

    public static clusterinstance[] get_filtered(
      nitro_service service,
      filtervalue[] filter)
    {
      clusterinstance clusterinstance = new clusterinstance();
      options option = new options();
      option.set_filter(filter);
      return (clusterinstance[]) clusterinstance.getfiltered(service, option);
    }

    public static uint count(nitro_service service)
    {
      clusterinstance clusterinstance = new clusterinstance();
      options option = new options();
      option.set_count(true);
      clusterinstance[] resources = (clusterinstance[]) clusterinstance.get_resources(service, option);
      return resources != null && resources.Length > 0 ? resources[0].__count.Value : 0U;
    }

    public static uint count_filtered(nitro_service service, string filter)
    {
      clusterinstance clusterinstance = new clusterinstance();
      options option = new options();
      option.set_count(true);
      option.set_filter(filter);
      clusterinstance[] clusterinstanceArray = (clusterinstance[]) clusterinstance.getfiltered(service, option);
      return clusterinstanceArray != null && clusterinstanceArray.Length > 0 ? clusterinstanceArray[0].__count.Value : 0U;
    }

    public static uint count_filtered(nitro_service service, filtervalue[] filter)
    {
      clusterinstance clusterinstance = new clusterinstance();
      options option = new options();
      option.set_count(true);
      option.set_filter(filter);
      clusterinstance[] clusterinstanceArray = (clusterinstance[]) clusterinstance.getfiltered(service, option);
      return clusterinstanceArray != null && clusterinstanceArray.Length > 0 ? clusterinstanceArray[0].__count.Value : 0U;
    }

    private class clusterinstance_response : base_response
    {
      public clusterinstance[] clusterinstance = (clusterinstance[]) null;
    }

    public static class operationalpropstateEnum
    {
      public const string UNKNOWN = "UNKNOWN";
      public const string ENABLED = "ENABLED";
      public const string DISABLED = "DISABLED";
      public const string AUTO_DISABLED = "AUTO DISABLED";
    }

    public static class propstateEnum
    {
      public const string ENABLED = "ENABLED";
      public const string DISABLED = "DISABLED";
    }

    public static class processlocalEnum
    {
      public const string ENABLED = "ENABLED";
      public const string DISABLED = "DISABLED";
    }

    public static class statusEnum
    {
      public const string DOWN = "DOWN";
      public const string UP = "UP";
      public const string PARTIAL_UP = "PARTIAL-UP";
      public const string UNKNOWN = "UNKNOWN";
    }

    public static class incEnum
    {
      public const string ENABLED = "ENABLED";
      public const string DISABLED = "DISABLED";
    }

    public static class adminstateEnum
    {
      public const string ENABLED = "ENABLED";
      public const string DISABLED = "DISABLED";
    }

    public static class preemptionEnum
    {
      public const string ENABLED = "ENABLED";
      public const string DISABLED = "DISABLED";
    }

    public static class operationalstateEnum
    {
      public const string ENABLED = "ENABLED";
      public const string DISABLED = "DISABLED";
    }

    public static class quorumtypeEnum
    {
      public const string MAJORITY = "MAJORITY";
      public const string NONE = "NONE";
    }
  }
}
