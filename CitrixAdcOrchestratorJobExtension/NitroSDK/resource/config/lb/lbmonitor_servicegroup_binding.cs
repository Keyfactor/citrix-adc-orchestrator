// Decompiled with JetBrains decompiler
// Type: com.citrix.netscaler.nitro.resource.config.lb.lbmonitor_servicegroup_binding
// Assembly: nitro, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 6CF5DDEF-E052-4F9D-953F-6644F8378A66


using com.citrix.netscaler.nitro.exception;
using com.citrix.netscaler.nitro.resource.Base;
using com.citrix.netscaler.nitro.service;

namespace com.citrix.netscaler.nitro.resource.config.lb
{
  public class lbmonitor_servicegroup_binding : base_resource
  {
    private string monitornameField = (string) null;
    private string servicenameField = (string) null;
    private string dup_stateField = (string) null;
    private uint? dup_weightField = new uint?();
    private string servicegroupnameField = (string) null;
    private string stateField = (string) null;
    private uint? weightField = new uint?();

    public string servicegroupname
    {
      get => this.servicegroupnameField;
      set => this.servicegroupnameField = value;
    }

    public string dup_state
    {
      get => this.dup_stateField;
      set => this.dup_stateField = value;
    }

    public string servicename
    {
      get => this.servicenameField;
      set => this.servicenameField = value;
    }

    public string state
    {
      get => this.stateField;
      set => this.stateField = value;
    }

    public uint? dup_weight
    {
      get => this.dup_weightField;
      set => this.dup_weightField = value;
    }

    public string monitorname
    {
      get => this.monitornameField;
      set => this.monitornameField = value;
    }

    public uint? weight
    {
      get => this.weightField;
      set => this.weightField = value;
    }

    internal override base_resource[] get_nitro_response(
      nitro_service service,
      string response)
    {
      lbmonitor_servicegroup_binding.lbmonitor_servicegroup_binding_response servicegroupBindingResponse = new lbmonitor_servicegroup_binding.lbmonitor_servicegroup_binding_response();
      lbmonitor_servicegroup_binding.lbmonitor_servicegroup_binding_response resource = (lbmonitor_servicegroup_binding.lbmonitor_servicegroup_binding_response) service.get_payload_formatter().string_to_resource(servicegroupBindingResponse.GetType(), response);
      if (resource.errorcode != 0)
      {
        if (resource.errorcode == 444)
          service.clear_session();
        if (resource.severity == null)
          throw new nitro_exception(resource.message, resource.errorcode);
        if (resource.severity.Equals("ERROR"))
          throw new nitro_exception(resource.message, resource.errorcode);
      }
      return (base_resource[]) resource.lbmonitor_servicegroup_binding;
    }

    internal override string get_object_name() => this.monitorname;

    public static base_response add(
      nitro_service client,
      lbmonitor_servicegroup_binding resource)
    {
      return new lbmonitor_servicegroup_binding()
      {
        monitorname = resource.monitorname,
        servicename = resource.servicename,
        dup_state = resource.dup_state,
        dup_weight = resource.dup_weight,
        servicegroupname = resource.servicegroupname,
        state = resource.state,
        weight = resource.weight
      }.update_resource(client);
    }

    public static base_responses add(
      nitro_service client,
      lbmonitor_servicegroup_binding[] resources)
    {
      base_responses baseResponses = (base_responses) null;
      if (resources != null && resources.Length > 0)
      {
        lbmonitor_servicegroup_binding[] servicegroupBindingArray = new lbmonitor_servicegroup_binding[resources.Length];
        for (int index = 0; index < resources.Length; ++index)
        {
          servicegroupBindingArray[index] = new lbmonitor_servicegroup_binding();
          servicegroupBindingArray[index].monitorname = resources[index].monitorname;
          servicegroupBindingArray[index].servicename = resources[index].servicename;
          servicegroupBindingArray[index].dup_state = resources[index].dup_state;
          servicegroupBindingArray[index].dup_weight = resources[index].dup_weight;
          servicegroupBindingArray[index].servicegroupname = resources[index].servicegroupname;
          servicegroupBindingArray[index].state = resources[index].state;
          servicegroupBindingArray[index].weight = resources[index].weight;
        }
        baseResponses = base_resource.update_bulk_request(client, (base_resource[]) servicegroupBindingArray);
      }
      return baseResponses;
    }

    public static base_response delete(
      nitro_service client,
      lbmonitor_servicegroup_binding resource)
    {
      return new lbmonitor_servicegroup_binding()
      {
        monitorname = resource.monitorname,
        servicename = resource.servicename,
        servicegroupname = resource.servicegroupname
      }.delete_resource(client);
    }

    public static base_responses delete(
      nitro_service client,
      lbmonitor_servicegroup_binding[] resources)
    {
      base_responses baseResponses = (base_responses) null;
      if (resources != null && resources.Length > 0)
      {
        lbmonitor_servicegroup_binding[] servicegroupBindingArray = new lbmonitor_servicegroup_binding[resources.Length];
        for (int index = 0; index < resources.Length; ++index)
        {
          servicegroupBindingArray[index] = new lbmonitor_servicegroup_binding();
          servicegroupBindingArray[index].monitorname = resources[index].monitorname;
          servicegroupBindingArray[index].servicename = resources[index].servicename;
          servicegroupBindingArray[index].servicegroupname = resources[index].servicegroupname;
        }
        baseResponses = base_resource.delete_bulk_request(client, (base_resource[]) servicegroupBindingArray);
      }
      return baseResponses;
    }

    private class lbmonitor_servicegroup_binding_response : base_response
    {
      public lbmonitor_servicegroup_binding[] lbmonitor_servicegroup_binding = (lbmonitor_servicegroup_binding[]) null;
    }

    public static class dup_stateEnum
    {
      public const string ENABLED = "ENABLED";
      public const string DISABLED = "DISABLED";
    }

    public static class stateEnum
    {
      public const string ENABLED = "ENABLED";
      public const string DISABLED = "DISABLED";
    }
  }
}
