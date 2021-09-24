// Decompiled with JetBrains decompiler
// Type: com.citrix.netscaler.nitro.resource.config.ns.nsevents
// Assembly: nitro, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 6CF5DDEF-E052-4F9D-953F-6644F8378A66


using com.citrix.netscaler.nitro.exception;
using com.citrix.netscaler.nitro.resource.Base;
using com.citrix.netscaler.nitro.service;
using com.citrix.netscaler.nitro.util;

namespace com.citrix.netscaler.nitro.resource.config.ns
{
  public class nsevents : base_resource
  {
    private uint? eventnoField = new uint?();
    private uint? timeField = new uint?();
    private uint? eventcodeField = new uint?();
    private uint? devidField = new uint?();
    private string devnameField = (string) null;
    private string textField = (string) null;
    private uint? data0Field = new uint?();
    private uint? data1Field = new uint?();
    private uint? data2Field = new uint?();
    private uint? data3Field = new uint?();
    private uint? __countField = new uint?();

    public uint? __count
    {
      get => this.__countField;
      private set => this.__countField = value;
    }

    public uint? eventno
    {
      get => this.eventnoField;
      set => this.eventnoField = value;
    }

    public uint? time
    {
      get => this.timeField;
      private set => this.timeField = value;
    }

    public uint? eventcode
    {
      get => this.eventcodeField;
      private set => this.eventcodeField = value;
    }

    public uint? devid
    {
      get => this.devidField;
      private set => this.devidField = value;
    }

    public string devname
    {
      get => this.devnameField;
      private set => this.devnameField = value;
    }

    public string text
    {
      get => this.textField;
      private set => this.textField = value;
    }

    public uint? data0
    {
      get => this.data0Field;
      private set => this.data0Field = value;
    }

    public uint? data1
    {
      get => this.data1Field;
      private set => this.data1Field = value;
    }

    public uint? data2
    {
      get => this.data2Field;
      private set => this.data2Field = value;
    }

    public uint? data3
    {
      get => this.data3Field;
      private set => this.data3Field = value;
    }

    internal override base_resource[] get_nitro_response(
      nitro_service service,
      string response)
    {
      nsevents.nsevents_response nseventsResponse = new nsevents.nsevents_response();
      nsevents.nsevents_response resource = (nsevents.nsevents_response) service.get_payload_formatter().string_to_resource(nseventsResponse.GetType(), response);
      if (resource.errorcode != 0)
      {
        if (resource.errorcode == 444)
          service.clear_session();
        if (resource.severity == null)
          throw new nitro_exception(resource.message, resource.errorcode);
        if (resource.severity.Equals("ERROR"))
          throw new nitro_exception(resource.message, resource.errorcode);
      }
      return (base_resource[]) resource.nsevents;
    }

    internal override string get_object_name() => (string) null;

    public static nsevents[] get(nitro_service service) => (nsevents[]) new nsevents().get_resources(service, (options) null);

    public static nsevents[] get(nitro_service service, options option) => (nsevents[]) new nsevents().get_resources(service, option);

    public static nsevents[] get(nitro_service service, nsevents_args args)
    {
      nsevents nsevents = new nsevents();
      options option = new options();
      option.set_args(nitro_util.object_to_string_withoutquotes((object) args));
      return (nsevents[]) nsevents.get_resources(service, option);
    }

    public static nsevents[] get_filtered(nitro_service service, string filter)
    {
      nsevents nsevents = new nsevents();
      options option = new options();
      option.set_filter(filter);
      return (nsevents[]) nsevents.getfiltered(service, option);
    }

    public static nsevents[] get_filtered(nitro_service service, filtervalue[] filter)
    {
      nsevents nsevents = new nsevents();
      options option = new options();
      option.set_filter(filter);
      return (nsevents[]) nsevents.getfiltered(service, option);
    }

    public static uint count(nitro_service service)
    {
      nsevents nsevents = new nsevents();
      options option = new options();
      option.set_count(true);
      nsevents[] resources = (nsevents[]) nsevents.get_resources(service, option);
      return resources != null && resources.Length > 0 ? resources[0].__count.Value : 0U;
    }

    public static uint count_filtered(nitro_service service, string filter)
    {
      nsevents nsevents = new nsevents();
      options option = new options();
      option.set_count(true);
      option.set_filter(filter);
      nsevents[] nseventsArray = (nsevents[]) nsevents.getfiltered(service, option);
      return nseventsArray != null && nseventsArray.Length > 0 ? nseventsArray[0].__count.Value : 0U;
    }

    public static uint count_filtered(nitro_service service, filtervalue[] filter)
    {
      nsevents nsevents = new nsevents();
      options option = new options();
      option.set_count(true);
      option.set_filter(filter);
      nsevents[] nseventsArray = (nsevents[]) nsevents.getfiltered(service, option);
      return nseventsArray != null && nseventsArray.Length > 0 ? nseventsArray[0].__count.Value : 0U;
    }

    private class nsevents_response : base_response
    {
      public nsevents[] nsevents = (nsevents[]) null;
    }
  }
}
