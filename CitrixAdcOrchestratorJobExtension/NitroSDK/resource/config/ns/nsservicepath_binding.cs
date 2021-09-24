// Decompiled with JetBrains decompiler
// Type: com.citrix.netscaler.nitro.resource.config.ns.nsservicepath_binding
// Assembly: nitro, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 6CF5DDEF-E052-4F9D-953F-6644F8378A66


using com.citrix.netscaler.nitro.exception;
using com.citrix.netscaler.nitro.resource.Base;
using com.citrix.netscaler.nitro.service;

namespace com.citrix.netscaler.nitro.resource.config.ns
{
  public class nsservicepath_binding : base_resource
  {
    private string servicepathnameField = (string) null;
    private com.citrix.netscaler.nitro.resource.config.ns.nsservicepath_nsservicefunction_binding[] nsservicepath_nsservicefunction_bindingField = (com.citrix.netscaler.nitro.resource.config.ns.nsservicepath_nsservicefunction_binding[]) null;

    public string servicepathname
    {
      get => this.servicepathnameField;
      set => this.servicepathnameField = value;
    }

    public com.citrix.netscaler.nitro.resource.config.ns.nsservicepath_nsservicefunction_binding[] nsservicepath_nsservicefunction_binding
    {
      get => this.nsservicepath_nsservicefunction_bindingField;
      private set => this.nsservicepath_nsservicefunction_bindingField = value;
    }

    internal override base_resource[] get_nitro_response(
      nitro_service service,
      string response)
    {
      nsservicepath_binding.nsservicepath_binding_response nsservicepathBindingResponse = new nsservicepath_binding.nsservicepath_binding_response();
      nsservicepath_binding.nsservicepath_binding_response resource = (nsservicepath_binding.nsservicepath_binding_response) service.get_payload_formatter().string_to_resource(nsservicepathBindingResponse.GetType(), response);
      if (resource.errorcode != 0)
      {
        if (resource.errorcode == 444)
          service.clear_session();
        if (resource.severity == null)
          throw new nitro_exception(resource.message, resource.errorcode);
        if (resource.severity.Equals("ERROR"))
          throw new nitro_exception(resource.message, resource.errorcode);
      }
      return (base_resource[]) resource.nsservicepath_binding;
    }

    internal override string get_object_name() => this.servicepathname;

    public static nsservicepath_binding get(
      nitro_service service,
      string servicepathname)
    {
      return (nsservicepath_binding) new nsservicepath_binding()
      {
        servicepathname = servicepathname
      }.get_resource(service);
    }

    public static nsservicepath_binding[] get(
      nitro_service service,
      string[] servicepathname)
    {
      if (servicepathname == null || servicepathname.Length <= 0)
        return (nsservicepath_binding[]) null;
      nsservicepath_binding[] nsservicepathBindingArray1 = new nsservicepath_binding[servicepathname.Length];
      nsservicepath_binding[] nsservicepathBindingArray2 = new nsservicepath_binding[servicepathname.Length];
      for (int index = 0; index < servicepathname.Length; ++index)
      {
        nsservicepathBindingArray2[index] = new nsservicepath_binding();
        nsservicepathBindingArray2[index].servicepathname = servicepathname[index];
        nsservicepathBindingArray1[index] = (nsservicepath_binding) nsservicepathBindingArray2[index].get_resource(service);
      }
      return nsservicepathBindingArray1;
    }

    private class nsservicepath_binding_response : base_response
    {
      public nsservicepath_binding[] nsservicepath_binding = (nsservicepath_binding[]) null;
    }
  }
}
