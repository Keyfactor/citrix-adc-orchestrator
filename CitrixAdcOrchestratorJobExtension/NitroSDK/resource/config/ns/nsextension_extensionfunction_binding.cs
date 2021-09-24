// Decompiled with JetBrains decompiler
// Type: com.citrix.netscaler.nitro.resource.config.ns.nsextension_extensionfunction_binding
// Assembly: nitro, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 6CF5DDEF-E052-4F9D-953F-6644F8378A66


using com.citrix.netscaler.nitro.exception;
using com.citrix.netscaler.nitro.resource.Base;
using com.citrix.netscaler.nitro.service;
using com.citrix.netscaler.nitro.util;

namespace com.citrix.netscaler.nitro.resource.config.ns
{
  public class nsextension_extensionfunction_binding : base_resource
  {
    private string extensionfunctionnameField = (string) null;
    private uint? extensionfunctionlinenumberField = new uint?();
    private string extensionfunctionclasstypeField = (string) null;
    private string extensionfunctionreturntypeField = (string) null;
    private int? activeextensionfunctionField = new int?();
    private string[] extensionfunctionargtypeField = (string[]) null;
    private string extensionfuncdescriptionField = (string) null;
    private uint? extensionfunctionargcountField = new uint?();
    private string[] extensionfunctionclassesField = (string[]) null;
    private uint? extensionfunctionclassescountField = new uint?();
    private string[] extensionfunctionallparamsField = (string[]) null;
    private uint? extensionfunctionallparamscountField = new uint?();
    private string nameField = (string) null;
    private uint? __countField = new uint?();

    public uint? __count
    {
      get => this.__countField;
      set => this.__countField = value;
    }

    public string name
    {
      get => this.nameField;
      set => this.nameField = value;
    }

    public uint? extensionfunctionlinenumber
    {
      get => this.extensionfunctionlinenumberField;
      private set => this.extensionfunctionlinenumberField = value;
    }

    public string[] extensionfunctionclasses
    {
      get => this.extensionfunctionclassesField;
      private set => this.extensionfunctionclassesField = value;
    }

    public string[] extensionfunctionargtype
    {
      get => this.extensionfunctionargtypeField;
      private set => this.extensionfunctionargtypeField = value;
    }

    public int? activeextensionfunction
    {
      get => this.activeextensionfunctionField;
      private set => this.activeextensionfunctionField = value;
    }

    public string extensionfunctionname
    {
      get => this.extensionfunctionnameField;
      private set => this.extensionfunctionnameField = value;
    }

    public string extensionfunctionclasstype
    {
      get => this.extensionfunctionclasstypeField;
      private set => this.extensionfunctionclasstypeField = value;
    }

    public string extensionfuncdescription
    {
      get => this.extensionfuncdescriptionField;
      private set => this.extensionfuncdescriptionField = value;
    }

    public string[] extensionfunctionallparams
    {
      get => this.extensionfunctionallparamsField;
      private set => this.extensionfunctionallparamsField = value;
    }

    public uint? extensionfunctionargcount
    {
      get => this.extensionfunctionargcountField;
      private set => this.extensionfunctionargcountField = value;
    }

    public string extensionfunctionreturntype
    {
      get => this.extensionfunctionreturntypeField;
      private set => this.extensionfunctionreturntypeField = value;
    }

    public uint? extensionfunctionclassescount
    {
      get => this.extensionfunctionclassescountField;
      private set => this.extensionfunctionclassescountField = value;
    }

    public uint? extensionfunctionallparamscount
    {
      get => this.extensionfunctionallparamscountField;
      private set => this.extensionfunctionallparamscountField = value;
    }

    internal override base_resource[] get_nitro_response(
      nitro_service service,
      string response)
    {
      nsextension_extensionfunction_binding.nsextension_extensionfunction_binding_response extensionfunctionBindingResponse = new nsextension_extensionfunction_binding.nsextension_extensionfunction_binding_response();
      nsextension_extensionfunction_binding.nsextension_extensionfunction_binding_response resource = (nsextension_extensionfunction_binding.nsextension_extensionfunction_binding_response) service.get_payload_formatter().string_to_resource(extensionfunctionBindingResponse.GetType(), response);
      if (resource.errorcode != 0)
      {
        if (resource.errorcode == 444)
          service.clear_session();
        if (resource.severity == null)
          throw new nitro_exception(resource.message, resource.errorcode);
        if (resource.severity.Equals("ERROR"))
          throw new nitro_exception(resource.message, resource.errorcode);
      }
      return (base_resource[]) resource.nsextension_extensionfunction_binding;
    }

    internal override string get_object_name() => this.name;

    public static nsextension_extensionfunction_binding[] get(
      nitro_service service,
      string name)
    {
      return (nsextension_extensionfunction_binding[]) new nsextension_extensionfunction_binding()
      {
        name = name
      }.get_resources(service, (options) null);
    }

    public static nsextension_extensionfunction_binding[] get_filtered(
      nitro_service service,
      string name,
      string filter)
    {
      nsextension_extensionfunction_binding extensionfunctionBinding = new nsextension_extensionfunction_binding();
      extensionfunctionBinding.name = name;
      options option = new options();
      option.set_filter(filter);
      return (nsextension_extensionfunction_binding[]) extensionfunctionBinding.getfiltered(service, option);
    }

    public static nsextension_extensionfunction_binding[] get_filtered(
      nitro_service service,
      string name,
      filtervalue[] filter)
    {
      nsextension_extensionfunction_binding extensionfunctionBinding = new nsextension_extensionfunction_binding();
      extensionfunctionBinding.name = name;
      options option = new options();
      option.set_filter(filter);
      return (nsextension_extensionfunction_binding[]) extensionfunctionBinding.getfiltered(service, option);
    }

    public static uint count(nitro_service service, string name)
    {
      nsextension_extensionfunction_binding extensionfunctionBinding = new nsextension_extensionfunction_binding();
      extensionfunctionBinding.name = name;
      options option = new options();
      option.set_count(true);
      nsextension_extensionfunction_binding[] resources = (nsextension_extensionfunction_binding[]) extensionfunctionBinding.get_resources(service, option);
      return resources != null && resources.Length > 0 ? resources[0].__count.Value : 0U;
    }

    public static uint count_filtered(nitro_service service, string name, string filter)
    {
      nsextension_extensionfunction_binding extensionfunctionBinding = new nsextension_extensionfunction_binding();
      extensionfunctionBinding.name = name;
      options option = new options();
      option.set_count(true);
      option.set_filter(filter);
      nsextension_extensionfunction_binding[] extensionfunctionBindingArray = (nsextension_extensionfunction_binding[]) extensionfunctionBinding.getfiltered(service, option);
      return extensionfunctionBindingArray != null && extensionfunctionBindingArray.Length > 0 ? extensionfunctionBindingArray[0].__count.Value : 0U;
    }

    public static uint count_filtered(nitro_service service, string name, filtervalue[] filter)
    {
      nsextension_extensionfunction_binding extensionfunctionBinding = new nsextension_extensionfunction_binding();
      extensionfunctionBinding.name = name;
      options option = new options();
      option.set_count(true);
      option.set_filter(filter);
      nsextension_extensionfunction_binding[] extensionfunctionBindingArray = (nsextension_extensionfunction_binding[]) extensionfunctionBinding.getfiltered(service, option);
      return extensionfunctionBindingArray != null && extensionfunctionBindingArray.Length > 0 ? extensionfunctionBindingArray[0].__count.Value : 0U;
    }

    private class nsextension_extensionfunction_binding_response : base_response
    {
      public nsextension_extensionfunction_binding[] nsextension_extensionfunction_binding = (nsextension_extensionfunction_binding[]) null;
    }
  }
}
