// Decompiled with JetBrains decompiler
// Type: com.citrix.netscaler.nitro.resource.config.ns.nsservicepath_nsservicefunction_binding
// Assembly: nitro, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 6CF5DDEF-E052-4F9D-953F-6644F8378A66


using com.citrix.netscaler.nitro.exception;
using com.citrix.netscaler.nitro.resource.Base;
using com.citrix.netscaler.nitro.service;
using com.citrix.netscaler.nitro.util;

namespace com.citrix.netscaler.nitro.resource.config.ns
{
  public class nsservicepath_nsservicefunction_binding : base_resource
  {
    private string servicefunctionField = (string) null;
    private uint? indexField = new uint?();
    private string servicepathnameField = (string) null;
    private uint? __countField = new uint?();

    public uint? __count
    {
      get => this.__countField;
      set => this.__countField = value;
    }

    public string servicepathname
    {
      get => this.servicepathnameField;
      set => this.servicepathnameField = value;
    }

    public string servicefunction
    {
      get => this.servicefunctionField;
      set => this.servicefunctionField = value;
    }

    public uint? index
    {
      get => this.indexField;
      set => this.indexField = value;
    }

    internal override base_resource[] get_nitro_response(
      nitro_service service,
      string response)
    {
      nsservicepath_nsservicefunction_binding.nsservicepath_nsservicefunction_binding_response nsservicefunctionBindingResponse = new nsservicepath_nsservicefunction_binding.nsservicepath_nsservicefunction_binding_response();
      nsservicepath_nsservicefunction_binding.nsservicepath_nsservicefunction_binding_response resource = (nsservicepath_nsservicefunction_binding.nsservicepath_nsservicefunction_binding_response) service.get_payload_formatter().string_to_resource(nsservicefunctionBindingResponse.GetType(), response);
      if (resource.errorcode != 0)
      {
        if (resource.errorcode == 444)
          service.clear_session();
        if (resource.severity == null)
          throw new nitro_exception(resource.message, resource.errorcode);
        if (resource.severity.Equals("ERROR"))
          throw new nitro_exception(resource.message, resource.errorcode);
      }
      return (base_resource[]) resource.nsservicepath_nsservicefunction_binding;
    }

    internal override string get_object_name() => this.servicepathname;

    public static base_response add(
      nitro_service client,
      nsservicepath_nsservicefunction_binding resource)
    {
      return new nsservicepath_nsservicefunction_binding()
      {
        servicepathname = resource.servicepathname,
        servicefunction = resource.servicefunction,
        index = resource.index
      }.update_resource(client);
    }

    public static base_responses add(
      nitro_service client,
      nsservicepath_nsservicefunction_binding[] resources)
    {
      base_responses baseResponses = (base_responses) null;
      if (resources != null && resources.Length > 0)
      {
        nsservicepath_nsservicefunction_binding[] nsservicefunctionBindingArray = new nsservicepath_nsservicefunction_binding[resources.Length];
        for (int index = 0; index < resources.Length; ++index)
        {
          nsservicefunctionBindingArray[index] = new nsservicepath_nsservicefunction_binding();
          nsservicefunctionBindingArray[index].servicepathname = resources[index].servicepathname;
          nsservicefunctionBindingArray[index].servicefunction = resources[index].servicefunction;
          nsservicefunctionBindingArray[index].index = resources[index].index;
        }
        baseResponses = base_resource.update_bulk_request(client, (base_resource[]) nsservicefunctionBindingArray);
      }
      return baseResponses;
    }

    public static base_response delete(
      nitro_service client,
      nsservicepath_nsservicefunction_binding resource)
    {
      return new nsservicepath_nsservicefunction_binding()
      {
        servicepathname = resource.servicepathname,
        servicefunction = resource.servicefunction
      }.delete_resource(client);
    }

    public static base_responses delete(
      nitro_service client,
      nsservicepath_nsservicefunction_binding[] resources)
    {
      base_responses baseResponses = (base_responses) null;
      if (resources != null && resources.Length > 0)
      {
        nsservicepath_nsservicefunction_binding[] nsservicefunctionBindingArray = new nsservicepath_nsservicefunction_binding[resources.Length];
        for (int index = 0; index < resources.Length; ++index)
        {
          nsservicefunctionBindingArray[index] = new nsservicepath_nsservicefunction_binding();
          nsservicefunctionBindingArray[index].servicepathname = resources[index].servicepathname;
          nsservicefunctionBindingArray[index].servicefunction = resources[index].servicefunction;
        }
        baseResponses = base_resource.delete_bulk_request(client, (base_resource[]) nsservicefunctionBindingArray);
      }
      return baseResponses;
    }

    public static nsservicepath_nsservicefunction_binding[] get(
      nitro_service service,
      string servicepathname)
    {
      return (nsservicepath_nsservicefunction_binding[]) new nsservicepath_nsservicefunction_binding()
      {
        servicepathname = servicepathname
      }.get_resources(service, (options) null);
    }

    public static nsservicepath_nsservicefunction_binding[] get_filtered(
      nitro_service service,
      string servicepathname,
      string filter)
    {
      nsservicepath_nsservicefunction_binding nsservicefunctionBinding = new nsservicepath_nsservicefunction_binding();
      nsservicefunctionBinding.servicepathname = servicepathname;
      options option = new options();
      option.set_filter(filter);
      return (nsservicepath_nsservicefunction_binding[]) nsservicefunctionBinding.getfiltered(service, option);
    }

    public static nsservicepath_nsservicefunction_binding[] get_filtered(
      nitro_service service,
      string servicepathname,
      filtervalue[] filter)
    {
      nsservicepath_nsservicefunction_binding nsservicefunctionBinding = new nsservicepath_nsservicefunction_binding();
      nsservicefunctionBinding.servicepathname = servicepathname;
      options option = new options();
      option.set_filter(filter);
      return (nsservicepath_nsservicefunction_binding[]) nsservicefunctionBinding.getfiltered(service, option);
    }

    public static uint count(nitro_service service, string servicepathname)
    {
      nsservicepath_nsservicefunction_binding nsservicefunctionBinding = new nsservicepath_nsservicefunction_binding();
      nsservicefunctionBinding.servicepathname = servicepathname;
      options option = new options();
      option.set_count(true);
      nsservicepath_nsservicefunction_binding[] resources = (nsservicepath_nsservicefunction_binding[]) nsservicefunctionBinding.get_resources(service, option);
      return resources != null && resources.Length > 0 ? resources[0].__count.Value : 0U;
    }

    public static uint count_filtered(nitro_service service, string servicepathname, string filter)
    {
      nsservicepath_nsservicefunction_binding nsservicefunctionBinding = new nsservicepath_nsservicefunction_binding();
      nsservicefunctionBinding.servicepathname = servicepathname;
      options option = new options();
      option.set_count(true);
      option.set_filter(filter);
      nsservicepath_nsservicefunction_binding[] nsservicefunctionBindingArray = (nsservicepath_nsservicefunction_binding[]) nsservicefunctionBinding.getfiltered(service, option);
      return nsservicefunctionBindingArray != null && nsservicefunctionBindingArray.Length > 0 ? nsservicefunctionBindingArray[0].__count.Value : 0U;
    }

    public static uint count_filtered(
      nitro_service service,
      string servicepathname,
      filtervalue[] filter)
    {
      nsservicepath_nsservicefunction_binding nsservicefunctionBinding = new nsservicepath_nsservicefunction_binding();
      nsservicefunctionBinding.servicepathname = servicepathname;
      options option = new options();
      option.set_count(true);
      option.set_filter(filter);
      nsservicepath_nsservicefunction_binding[] nsservicefunctionBindingArray = (nsservicepath_nsservicefunction_binding[]) nsservicefunctionBinding.getfiltered(service, option);
      return nsservicefunctionBindingArray != null && nsservicefunctionBindingArray.Length > 0 ? nsservicefunctionBindingArray[0].__count.Value : 0U;
    }

    private class nsservicepath_nsservicefunction_binding_response : base_response
    {
      public nsservicepath_nsservicefunction_binding[] nsservicepath_nsservicefunction_binding = (nsservicepath_nsservicefunction_binding[]) null;
    }
  }
}
