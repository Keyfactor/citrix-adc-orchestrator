// Decompiled with JetBrains decompiler
// Type: com.citrix.netscaler.nitro.resource.config.feo.feopolicy_csvserver_binding
// Assembly: nitro, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 6CF5DDEF-E052-4F9D-953F-6644F8378A66


using com.citrix.netscaler.nitro.exception;
using com.citrix.netscaler.nitro.resource.Base;
using com.citrix.netscaler.nitro.service;
using com.citrix.netscaler.nitro.util;

namespace com.citrix.netscaler.nitro.resource.config.feo
{
  public class feopolicy_csvserver_binding : base_resource
  {
    private string boundtoField = (string) null;
    private uint? priorityField = new uint?();
    private int? activepolicyField = new int?();
    private string gotopriorityexpressionField = (string) null;
    private string nameField = (string) null;
    private uint? __countField = new uint?();

    public uint? __count
    {
      get => this.__countField;
      set => this.__countField = value;
    }

    public string boundto
    {
      get => this.boundtoField;
      set => this.boundtoField = value;
    }

    public string name
    {
      get => this.nameField;
      set => this.nameField = value;
    }

    public uint? priority
    {
      get => this.priorityField;
      private set => this.priorityField = value;
    }

    public string gotopriorityexpression
    {
      get => this.gotopriorityexpressionField;
      private set => this.gotopriorityexpressionField = value;
    }

    public int? activepolicy
    {
      get => this.activepolicyField;
      private set => this.activepolicyField = value;
    }

    internal override base_resource[] get_nitro_response(
      nitro_service service,
      string response)
    {
      feopolicy_csvserver_binding.feopolicy_csvserver_binding_response csvserverBindingResponse = new feopolicy_csvserver_binding.feopolicy_csvserver_binding_response();
      feopolicy_csvserver_binding.feopolicy_csvserver_binding_response resource = (feopolicy_csvserver_binding.feopolicy_csvserver_binding_response) service.get_payload_formatter().string_to_resource(csvserverBindingResponse.GetType(), response);
      if (resource.errorcode != 0)
      {
        if (resource.errorcode == 444)
          service.clear_session();
        if (resource.severity == null)
          throw new nitro_exception(resource.message, resource.errorcode);
        if (resource.severity.Equals("ERROR"))
          throw new nitro_exception(resource.message, resource.errorcode);
      }
      return (base_resource[]) resource.feopolicy_csvserver_binding;
    }

    internal override string get_object_name() => this.name;

    public static feopolicy_csvserver_binding[] get(
      nitro_service service,
      string name)
    {
      return (feopolicy_csvserver_binding[]) new feopolicy_csvserver_binding()
      {
        name = name
      }.get_resources(service, (options) null);
    }

    public static feopolicy_csvserver_binding[] get_filtered(
      nitro_service service,
      string name,
      string filter)
    {
      feopolicy_csvserver_binding csvserverBinding = new feopolicy_csvserver_binding();
      csvserverBinding.name = name;
      options option = new options();
      option.set_filter(filter);
      return (feopolicy_csvserver_binding[]) csvserverBinding.getfiltered(service, option);
    }

    public static feopolicy_csvserver_binding[] get_filtered(
      nitro_service service,
      string name,
      filtervalue[] filter)
    {
      feopolicy_csvserver_binding csvserverBinding = new feopolicy_csvserver_binding();
      csvserverBinding.name = name;
      options option = new options();
      option.set_filter(filter);
      return (feopolicy_csvserver_binding[]) csvserverBinding.getfiltered(service, option);
    }

    public static uint count(nitro_service service, string name)
    {
      feopolicy_csvserver_binding csvserverBinding = new feopolicy_csvserver_binding();
      csvserverBinding.name = name;
      options option = new options();
      option.set_count(true);
      feopolicy_csvserver_binding[] resources = (feopolicy_csvserver_binding[]) csvserverBinding.get_resources(service, option);
      return resources != null && resources.Length > 0 ? resources[0].__count.Value : 0U;
    }

    public static uint count_filtered(nitro_service service, string name, string filter)
    {
      feopolicy_csvserver_binding csvserverBinding = new feopolicy_csvserver_binding();
      csvserverBinding.name = name;
      options option = new options();
      option.set_count(true);
      option.set_filter(filter);
      feopolicy_csvserver_binding[] csvserverBindingArray = (feopolicy_csvserver_binding[]) csvserverBinding.getfiltered(service, option);
      return csvserverBindingArray != null && csvserverBindingArray.Length > 0 ? csvserverBindingArray[0].__count.Value : 0U;
    }

    public static uint count_filtered(nitro_service service, string name, filtervalue[] filter)
    {
      feopolicy_csvserver_binding csvserverBinding = new feopolicy_csvserver_binding();
      csvserverBinding.name = name;
      options option = new options();
      option.set_count(true);
      option.set_filter(filter);
      feopolicy_csvserver_binding[] csvserverBindingArray = (feopolicy_csvserver_binding[]) csvserverBinding.getfiltered(service, option);
      return csvserverBindingArray != null && csvserverBindingArray.Length > 0 ? csvserverBindingArray[0].__count.Value : 0U;
    }

    private class feopolicy_csvserver_binding_response : base_response
    {
      public feopolicy_csvserver_binding[] feopolicy_csvserver_binding = (feopolicy_csvserver_binding[]) null;
    }
  }
}
