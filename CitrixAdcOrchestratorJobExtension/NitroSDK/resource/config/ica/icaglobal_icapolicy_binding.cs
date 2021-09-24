// Decompiled with JetBrains decompiler
// Type: com.citrix.netscaler.nitro.resource.config.ica.icaglobal_icapolicy_binding
// Assembly: nitro, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 6CF5DDEF-E052-4F9D-953F-6644F8378A66


using com.citrix.netscaler.nitro.exception;
using com.citrix.netscaler.nitro.resource.Base;
using com.citrix.netscaler.nitro.service;
using com.citrix.netscaler.nitro.util;

namespace com.citrix.netscaler.nitro.resource.config.ica
{
  public class icaglobal_icapolicy_binding : base_resource
  {
    private string policynameField = (string) null;
    private string typeField = (string) null;
    private uint? priorityField = new uint?();
    private string gotopriorityexpressionField = (string) null;
    private uint? numpolField = new uint?();
    private uint? flowtypeField = new uint?();
    private string globalbindtypeField = (string) null;
    private uint? __countField = new uint?();

    public uint? __count
    {
      get => this.__countField;
      set => this.__countField = value;
    }

    public uint? priority
    {
      get => this.priorityField;
      set => this.priorityField = value;
    }

    public string globalbindtype
    {
      get => this.globalbindtypeField;
      set => this.globalbindtypeField = value;
    }

    public string gotopriorityexpression
    {
      get => this.gotopriorityexpressionField;
      set => this.gotopriorityexpressionField = value;
    }

    public string policyname
    {
      get => this.policynameField;
      set => this.policynameField = value;
    }

    public string type
    {
      get => this.typeField;
      set => this.typeField = value;
    }

    public uint? numpol
    {
      get => this.numpolField;
      private set => this.numpolField = value;
    }

    public uint? flowtype
    {
      get => this.flowtypeField;
      private set => this.flowtypeField = value;
    }

    internal override base_resource[] get_nitro_response(
      nitro_service service,
      string response)
    {
      icaglobal_icapolicy_binding.icaglobal_icapolicy_binding_response icapolicyBindingResponse = new icaglobal_icapolicy_binding.icaglobal_icapolicy_binding_response();
      icaglobal_icapolicy_binding.icaglobal_icapolicy_binding_response resource = (icaglobal_icapolicy_binding.icaglobal_icapolicy_binding_response) service.get_payload_formatter().string_to_resource(icapolicyBindingResponse.GetType(), response);
      if (resource.errorcode != 0)
      {
        if (resource.errorcode == 444)
          service.clear_session();
        if (resource.severity == null)
          throw new nitro_exception(resource.message, resource.errorcode);
        if (resource.severity.Equals("ERROR"))
          throw new nitro_exception(resource.message, resource.errorcode);
      }
      return (base_resource[]) resource.icaglobal_icapolicy_binding;
    }

    internal override string get_object_name() => (string) null;

    public static base_response add(
      nitro_service client,
      icaglobal_icapolicy_binding resource)
    {
      return new icaglobal_icapolicy_binding()
      {
        policyname = resource.policyname,
        priority = resource.priority,
        gotopriorityexpression = resource.gotopriorityexpression,
        type = resource.type
      }.update_resource(client);
    }

    public static base_responses add(
      nitro_service client,
      icaglobal_icapolicy_binding[] resources)
    {
      base_responses baseResponses = (base_responses) null;
      if (resources != null && resources.Length > 0)
      {
        icaglobal_icapolicy_binding[] icapolicyBindingArray = new icaglobal_icapolicy_binding[resources.Length];
        for (int index = 0; index < resources.Length; ++index)
        {
          icapolicyBindingArray[index] = new icaglobal_icapolicy_binding();
          icapolicyBindingArray[index].policyname = resources[index].policyname;
          icapolicyBindingArray[index].priority = resources[index].priority;
          icapolicyBindingArray[index].gotopriorityexpression = resources[index].gotopriorityexpression;
          icapolicyBindingArray[index].type = resources[index].type;
        }
        baseResponses = base_resource.update_bulk_request(client, (base_resource[]) icapolicyBindingArray);
      }
      return baseResponses;
    }

    public static base_response delete(
      nitro_service client,
      icaglobal_icapolicy_binding resource)
    {
      return new icaglobal_icapolicy_binding()
      {
        policyname = resource.policyname,
        type = resource.type,
        priority = resource.priority
      }.delete_resource(client);
    }

    public static base_responses delete(
      nitro_service client,
      icaglobal_icapolicy_binding[] resources)
    {
      base_responses baseResponses = (base_responses) null;
      if (resources != null && resources.Length > 0)
      {
        icaglobal_icapolicy_binding[] icapolicyBindingArray = new icaglobal_icapolicy_binding[resources.Length];
        for (int index = 0; index < resources.Length; ++index)
        {
          icapolicyBindingArray[index] = new icaglobal_icapolicy_binding();
          icapolicyBindingArray[index].policyname = resources[index].policyname;
          icapolicyBindingArray[index].type = resources[index].type;
          icapolicyBindingArray[index].priority = resources[index].priority;
        }
        baseResponses = base_resource.delete_bulk_request(client, (base_resource[]) icapolicyBindingArray);
      }
      return baseResponses;
    }

    public static icaglobal_icapolicy_binding[] get(nitro_service service) => (icaglobal_icapolicy_binding[]) new icaglobal_icapolicy_binding().get_resources(service, (options) null);

    public static icaglobal_icapolicy_binding[] get_filtered(
      nitro_service service,
      string filter)
    {
      icaglobal_icapolicy_binding icapolicyBinding = new icaglobal_icapolicy_binding();
      options option = new options();
      option.set_filter(filter);
      return (icaglobal_icapolicy_binding[]) icapolicyBinding.getfiltered(service, option);
    }

    public static icaglobal_icapolicy_binding[] get_filtered(
      nitro_service service,
      filtervalue[] filter)
    {
      icaglobal_icapolicy_binding icapolicyBinding = new icaglobal_icapolicy_binding();
      options option = new options();
      option.set_filter(filter);
      return (icaglobal_icapolicy_binding[]) icapolicyBinding.getfiltered(service, option);
    }

    public static uint count(nitro_service service)
    {
      icaglobal_icapolicy_binding icapolicyBinding = new icaglobal_icapolicy_binding();
      options option = new options();
      option.set_count(true);
      icaglobal_icapolicy_binding[] resources = (icaglobal_icapolicy_binding[]) icapolicyBinding.get_resources(service, option);
      return resources != null && resources.Length > 0 ? resources[0].__count.Value : 0U;
    }

    public static uint count_filtered(nitro_service service, string filter)
    {
      icaglobal_icapolicy_binding icapolicyBinding = new icaglobal_icapolicy_binding();
      options option = new options();
      option.set_count(true);
      option.set_filter(filter);
      icaglobal_icapolicy_binding[] icapolicyBindingArray = (icaglobal_icapolicy_binding[]) icapolicyBinding.getfiltered(service, option);
      return icapolicyBindingArray != null && icapolicyBindingArray.Length > 0 ? icapolicyBindingArray[0].__count.Value : 0U;
    }

    public static uint count_filtered(nitro_service service, filtervalue[] filter)
    {
      icaglobal_icapolicy_binding icapolicyBinding = new icaglobal_icapolicy_binding();
      options option = new options();
      option.set_count(true);
      option.set_filter(filter);
      icaglobal_icapolicy_binding[] icapolicyBindingArray = (icaglobal_icapolicy_binding[]) icapolicyBinding.getfiltered(service, option);
      return icapolicyBindingArray != null && icapolicyBindingArray.Length > 0 ? icapolicyBindingArray[0].__count.Value : 0U;
    }

    private class icaglobal_icapolicy_binding_response : base_response
    {
      public icaglobal_icapolicy_binding[] icaglobal_icapolicy_binding = (icaglobal_icapolicy_binding[]) null;
    }

    public static class globalbindtypeEnum
    {
      public const string SYSTEM_GLOBAL = "SYSTEM_GLOBAL";
      public const string VPN_GLOBAL = "VPN_GLOBAL";
      public const string RNAT_GLOBAL = "RNAT_GLOBAL";
    }

    public static class typeEnum
    {
      public const string ICA_REQ_OVERRIDE = "ICA_REQ_OVERRIDE";
      public const string ICA_REQ_DEFAULT = "ICA_REQ_DEFAULT";
    }
  }
}
