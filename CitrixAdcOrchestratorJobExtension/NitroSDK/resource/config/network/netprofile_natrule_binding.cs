// Decompiled with JetBrains decompiler
// Type: com.citrix.netscaler.nitro.resource.config.network.netprofile_natrule_binding
// Assembly: nitro, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 6CF5DDEF-E052-4F9D-953F-6644F8378A66


using com.citrix.netscaler.nitro.exception;
using com.citrix.netscaler.nitro.resource.Base;
using com.citrix.netscaler.nitro.service;
using com.citrix.netscaler.nitro.util;

namespace com.citrix.netscaler.nitro.resource.config.network
{
  public class netprofile_natrule_binding : base_resource
  {
    private string natruleField = (string) null;
    private string netmaskField = (string) null;
    private string rewriteipField = (string) null;
    private string nameField = (string) null;
    private uint? __countField = new uint?();

    public uint? __count
    {
      get => this.__countField;
      set => this.__countField = value;
    }

    public string rewriteip
    {
      get => this.rewriteipField;
      set => this.rewriteipField = value;
    }

    public string name
    {
      get => this.nameField;
      set => this.nameField = value;
    }

    public string netmask
    {
      get => this.netmaskField;
      set => this.netmaskField = value;
    }

    public string natrule
    {
      get => this.natruleField;
      set => this.natruleField = value;
    }

    internal override base_resource[] get_nitro_response(
      nitro_service service,
      string response)
    {
      netprofile_natrule_binding.netprofile_natrule_binding_response natruleBindingResponse = new netprofile_natrule_binding.netprofile_natrule_binding_response();
      netprofile_natrule_binding.netprofile_natrule_binding_response resource = (netprofile_natrule_binding.netprofile_natrule_binding_response) service.get_payload_formatter().string_to_resource(natruleBindingResponse.GetType(), response);
      if (resource.errorcode != 0)
      {
        if (resource.errorcode == 444)
          service.clear_session();
        if (resource.severity == null)
          throw new nitro_exception(resource.message, resource.errorcode);
        if (resource.severity.Equals("ERROR"))
          throw new nitro_exception(resource.message, resource.errorcode);
      }
      return (base_resource[]) resource.netprofile_natrule_binding;
    }

    internal override string get_object_name() => this.name;

    public static base_response add(
      nitro_service client,
      netprofile_natrule_binding resource)
    {
      return new netprofile_natrule_binding()
      {
        name = resource.name,
        natrule = resource.natrule,
        netmask = resource.netmask,
        rewriteip = resource.rewriteip
      }.update_resource(client);
    }

    public static base_responses add(
      nitro_service client,
      netprofile_natrule_binding[] resources)
    {
      base_responses baseResponses = (base_responses) null;
      if (resources != null && resources.Length > 0)
      {
        netprofile_natrule_binding[] netprofileNatruleBindingArray = new netprofile_natrule_binding[resources.Length];
        for (int index = 0; index < resources.Length; ++index)
        {
          netprofileNatruleBindingArray[index] = new netprofile_natrule_binding();
          netprofileNatruleBindingArray[index].name = resources[index].name;
          netprofileNatruleBindingArray[index].natrule = resources[index].natrule;
          netprofileNatruleBindingArray[index].netmask = resources[index].netmask;
          netprofileNatruleBindingArray[index].rewriteip = resources[index].rewriteip;
        }
        baseResponses = base_resource.update_bulk_request(client, (base_resource[]) netprofileNatruleBindingArray);
      }
      return baseResponses;
    }

    public static base_response delete(
      nitro_service client,
      netprofile_natrule_binding resource)
    {
      return new netprofile_natrule_binding()
      {
        name = resource.name,
        natrule = resource.natrule,
        netmask = resource.netmask
      }.delete_resource(client);
    }

    public static base_responses delete(
      nitro_service client,
      netprofile_natrule_binding[] resources)
    {
      base_responses baseResponses = (base_responses) null;
      if (resources != null && resources.Length > 0)
      {
        netprofile_natrule_binding[] netprofileNatruleBindingArray = new netprofile_natrule_binding[resources.Length];
        for (int index = 0; index < resources.Length; ++index)
        {
          netprofileNatruleBindingArray[index] = new netprofile_natrule_binding();
          netprofileNatruleBindingArray[index].name = resources[index].name;
          netprofileNatruleBindingArray[index].natrule = resources[index].natrule;
          netprofileNatruleBindingArray[index].netmask = resources[index].netmask;
        }
        baseResponses = base_resource.delete_bulk_request(client, (base_resource[]) netprofileNatruleBindingArray);
      }
      return baseResponses;
    }

    public static netprofile_natrule_binding[] get(
      nitro_service service,
      string name)
    {
      return (netprofile_natrule_binding[]) new netprofile_natrule_binding()
      {
        name = name
      }.get_resources(service, (options) null);
    }

    public static netprofile_natrule_binding[] get_filtered(
      nitro_service service,
      string name,
      string filter)
    {
      netprofile_natrule_binding netprofileNatruleBinding = new netprofile_natrule_binding();
      netprofileNatruleBinding.name = name;
      options option = new options();
      option.set_filter(filter);
      return (netprofile_natrule_binding[]) netprofileNatruleBinding.getfiltered(service, option);
    }

    public static netprofile_natrule_binding[] get_filtered(
      nitro_service service,
      string name,
      filtervalue[] filter)
    {
      netprofile_natrule_binding netprofileNatruleBinding = new netprofile_natrule_binding();
      netprofileNatruleBinding.name = name;
      options option = new options();
      option.set_filter(filter);
      return (netprofile_natrule_binding[]) netprofileNatruleBinding.getfiltered(service, option);
    }

    public static uint count(nitro_service service, string name)
    {
      netprofile_natrule_binding netprofileNatruleBinding = new netprofile_natrule_binding();
      netprofileNatruleBinding.name = name;
      options option = new options();
      option.set_count(true);
      netprofile_natrule_binding[] resources = (netprofile_natrule_binding[]) netprofileNatruleBinding.get_resources(service, option);
      return resources != null && resources.Length > 0 ? resources[0].__count.Value : 0U;
    }

    public static uint count_filtered(nitro_service service, string name, string filter)
    {
      netprofile_natrule_binding netprofileNatruleBinding = new netprofile_natrule_binding();
      netprofileNatruleBinding.name = name;
      options option = new options();
      option.set_count(true);
      option.set_filter(filter);
      netprofile_natrule_binding[] netprofileNatruleBindingArray = (netprofile_natrule_binding[]) netprofileNatruleBinding.getfiltered(service, option);
      return netprofileNatruleBindingArray != null && netprofileNatruleBindingArray.Length > 0 ? netprofileNatruleBindingArray[0].__count.Value : 0U;
    }

    public static uint count_filtered(nitro_service service, string name, filtervalue[] filter)
    {
      netprofile_natrule_binding netprofileNatruleBinding = new netprofile_natrule_binding();
      netprofileNatruleBinding.name = name;
      options option = new options();
      option.set_count(true);
      option.set_filter(filter);
      netprofile_natrule_binding[] netprofileNatruleBindingArray = (netprofile_natrule_binding[]) netprofileNatruleBinding.getfiltered(service, option);
      return netprofileNatruleBindingArray != null && netprofileNatruleBindingArray.Length > 0 ? netprofileNatruleBindingArray[0].__count.Value : 0U;
    }

    private class netprofile_natrule_binding_response : base_response
    {
      public netprofile_natrule_binding[] netprofile_natrule_binding = (netprofile_natrule_binding[]) null;
    }
  }
}
