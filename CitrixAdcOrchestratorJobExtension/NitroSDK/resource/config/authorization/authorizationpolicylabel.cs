// Decompiled with JetBrains decompiler
// Type: com.citrix.netscaler.nitro.resource.config.authorization.authorizationpolicylabel
// Assembly: nitro, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 6CF5DDEF-E052-4F9D-953F-6644F8378A66


using com.citrix.netscaler.nitro.exception;
using com.citrix.netscaler.nitro.resource.Base;
using com.citrix.netscaler.nitro.service;
using com.citrix.netscaler.nitro.util;

namespace com.citrix.netscaler.nitro.resource.config.authorization
{
  public class authorizationpolicylabel : base_resource
  {
    private string labelnameField = (string) null;
    private string newnameField = (string) null;
    private uint? numpolField = new uint?();
    private long? hitsField = new long?();
    private string policynameField = (string) null;
    private uint? priorityField = new uint?();
    private string gotopriorityexpressionField = (string) null;
    private string labeltypeField = (string) null;
    private string invoke_labelnameField = (string) null;
    private uint? flowtypeField = new uint?();
    private string descriptionField = (string) null;
    private uint? __countField = new uint?();

    public uint? __count
    {
      get => this.__countField;
      private set => this.__countField = value;
    }

    public string labelname
    {
      get => this.labelnameField;
      set => this.labelnameField = value;
    }

    public string newname
    {
      get => this.newnameField;
      set => this.newnameField = value;
    }

    public uint? numpol
    {
      get => this.numpolField;
      private set => this.numpolField = value;
    }

    public long? hits
    {
      get => this.hitsField;
      private set => this.hitsField = value;
    }

    public string policyname
    {
      get => this.policynameField;
      private set => this.policynameField = value;
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

    public string labeltype
    {
      get => this.labeltypeField;
      private set => this.labeltypeField = value;
    }

    public string invoke_labelname
    {
      get => this.invoke_labelnameField;
      private set => this.invoke_labelnameField = value;
    }

    public uint? flowtype
    {
      get => this.flowtypeField;
      private set => this.flowtypeField = value;
    }

    public string description
    {
      get => this.descriptionField;
      private set => this.descriptionField = value;
    }

    internal override base_resource[] get_nitro_response(
      nitro_service service,
      string response)
    {
      authorizationpolicylabel.authorizationpolicylabel_response authorizationpolicylabelResponse = new authorizationpolicylabel.authorizationpolicylabel_response();
      authorizationpolicylabel.authorizationpolicylabel_response resource = (authorizationpolicylabel.authorizationpolicylabel_response) service.get_payload_formatter().string_to_resource(authorizationpolicylabelResponse.GetType(), response);
      if (resource.errorcode != 0)
      {
        if (resource.errorcode == 444)
          service.clear_session();
        if (resource.severity == null)
          throw new nitro_exception(resource.message, resource.errorcode);
        if (resource.severity.Equals("ERROR"))
          throw new nitro_exception(resource.message, resource.errorcode);
      }
      return (base_resource[]) resource.authorizationpolicylabel;
    }

    internal override string get_object_name() => this.labelname;

    public static base_response add(
      nitro_service client,
      authorizationpolicylabel resource)
    {
      return new authorizationpolicylabel()
      {
        labelname = resource.labelname
      }.add_resource(client);
    }

    public static base_responses add(
      nitro_service client,
      authorizationpolicylabel[] resources)
    {
      base_responses baseResponses = (base_responses) null;
      if (resources != null && resources.Length > 0)
      {
        authorizationpolicylabel[] authorizationpolicylabelArray = new authorizationpolicylabel[resources.Length];
        for (int index = 0; index < resources.Length; ++index)
        {
          authorizationpolicylabelArray[index] = new authorizationpolicylabel();
          authorizationpolicylabelArray[index].labelname = resources[index].labelname;
        }
        baseResponses = base_resource.add_bulk_request(client, (base_resource[]) authorizationpolicylabelArray);
      }
      return baseResponses;
    }

    public static base_response delete(nitro_service client, string labelname) => new authorizationpolicylabel()
    {
      labelname = labelname
    }.delete_resource(client);

    public static base_response delete(
      nitro_service client,
      authorizationpolicylabel resource)
    {
      return new authorizationpolicylabel()
      {
        labelname = resource.labelname
      }.delete_resource(client);
    }

    public static base_responses delete(nitro_service client, string[] labelname)
    {
      base_responses baseResponses = (base_responses) null;
      if (labelname != null && labelname.Length > 0)
      {
        authorizationpolicylabel[] authorizationpolicylabelArray = new authorizationpolicylabel[labelname.Length];
        for (int index = 0; index < labelname.Length; ++index)
        {
          authorizationpolicylabelArray[index] = new authorizationpolicylabel();
          authorizationpolicylabelArray[index].labelname = labelname[index];
        }
        baseResponses = base_resource.delete_bulk_request(client, (base_resource[]) authorizationpolicylabelArray);
      }
      return baseResponses;
    }

    public static base_responses delete(
      nitro_service client,
      authorizationpolicylabel[] resources)
    {
      base_responses baseResponses = (base_responses) null;
      if (resources != null && resources.Length > 0)
      {
        authorizationpolicylabel[] authorizationpolicylabelArray = new authorizationpolicylabel[resources.Length];
        for (int index = 0; index < resources.Length; ++index)
        {
          authorizationpolicylabelArray[index] = new authorizationpolicylabel();
          authorizationpolicylabelArray[index].labelname = resources[index].labelname;
        }
        baseResponses = base_resource.delete_bulk_request(client, (base_resource[]) authorizationpolicylabelArray);
      }
      return baseResponses;
    }

    public static base_response rename(
      nitro_service client,
      authorizationpolicylabel resource,
      string new_labelname)
    {
      return new authorizationpolicylabel()
      {
        labelname = resource.labelname,
        newname = new_labelname
      }.rename_resource(client);
    }

    public static base_response rename(
      nitro_service client,
      string labelname,
      string new_labelname)
    {
      return new authorizationpolicylabel()
      {
        labelname = labelname,
        newname = new_labelname
      }.rename_resource(client);
    }

    public static authorizationpolicylabel[] get(nitro_service service) => (authorizationpolicylabel[]) new authorizationpolicylabel().get_resources(service, (options) null);

    public static authorizationpolicylabel[] get(
      nitro_service service,
      options option)
    {
      return (authorizationpolicylabel[]) new authorizationpolicylabel().get_resources(service, option);
    }

    public static authorizationpolicylabel get(
      nitro_service service,
      string labelname)
    {
      return (authorizationpolicylabel) new authorizationpolicylabel()
      {
        labelname = labelname
      }.get_resource(service);
    }

    public static authorizationpolicylabel[] get(
      nitro_service service,
      string[] labelname)
    {
      if (labelname == null || labelname.Length <= 0)
        return (authorizationpolicylabel[]) null;
      authorizationpolicylabel[] authorizationpolicylabelArray1 = new authorizationpolicylabel[labelname.Length];
      authorizationpolicylabel[] authorizationpolicylabelArray2 = new authorizationpolicylabel[labelname.Length];
      for (int index = 0; index < labelname.Length; ++index)
      {
        authorizationpolicylabelArray2[index] = new authorizationpolicylabel();
        authorizationpolicylabelArray2[index].labelname = labelname[index];
        authorizationpolicylabelArray1[index] = (authorizationpolicylabel) authorizationpolicylabelArray2[index].get_resource(service);
      }
      return authorizationpolicylabelArray1;
    }

    public static authorizationpolicylabel[] get_filtered(
      nitro_service service,
      string filter)
    {
      authorizationpolicylabel authorizationpolicylabel = new authorizationpolicylabel();
      options option = new options();
      option.set_filter(filter);
      return (authorizationpolicylabel[]) authorizationpolicylabel.getfiltered(service, option);
    }

    public static authorizationpolicylabel[] get_filtered(
      nitro_service service,
      filtervalue[] filter)
    {
      authorizationpolicylabel authorizationpolicylabel = new authorizationpolicylabel();
      options option = new options();
      option.set_filter(filter);
      return (authorizationpolicylabel[]) authorizationpolicylabel.getfiltered(service, option);
    }

    public static uint count(nitro_service service)
    {
      authorizationpolicylabel authorizationpolicylabel = new authorizationpolicylabel();
      options option = new options();
      option.set_count(true);
      authorizationpolicylabel[] resources = (authorizationpolicylabel[]) authorizationpolicylabel.get_resources(service, option);
      return resources != null && resources.Length > 0 ? resources[0].__count.Value : 0U;
    }

    public static uint count_filtered(nitro_service service, string filter)
    {
      authorizationpolicylabel authorizationpolicylabel = new authorizationpolicylabel();
      options option = new options();
      option.set_count(true);
      option.set_filter(filter);
      authorizationpolicylabel[] authorizationpolicylabelArray = (authorizationpolicylabel[]) authorizationpolicylabel.getfiltered(service, option);
      return authorizationpolicylabelArray != null && authorizationpolicylabelArray.Length > 0 ? authorizationpolicylabelArray[0].__count.Value : 0U;
    }

    public static uint count_filtered(nitro_service service, filtervalue[] filter)
    {
      authorizationpolicylabel authorizationpolicylabel = new authorizationpolicylabel();
      options option = new options();
      option.set_count(true);
      option.set_filter(filter);
      authorizationpolicylabel[] authorizationpolicylabelArray = (authorizationpolicylabel[]) authorizationpolicylabel.getfiltered(service, option);
      return authorizationpolicylabelArray != null && authorizationpolicylabelArray.Length > 0 ? authorizationpolicylabelArray[0].__count.Value : 0U;
    }

    private class authorizationpolicylabel_response : base_response
    {
      public authorizationpolicylabel[] authorizationpolicylabel = (authorizationpolicylabel[]) null;
    }

    public static class labeltypeEnum
    {
      public const string reqvserver = "reqvserver";
      public const string resvserver = "resvserver";
      public const string policylabel = "policylabel";
    }
  }
}
