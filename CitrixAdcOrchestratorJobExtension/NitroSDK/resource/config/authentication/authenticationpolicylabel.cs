// Decompiled with JetBrains decompiler
// Type: com.citrix.netscaler.nitro.resource.config.authentication.authenticationpolicylabel
// Assembly: nitro, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 6CF5DDEF-E052-4F9D-953F-6644F8378A66


using com.citrix.netscaler.nitro.exception;
using com.citrix.netscaler.nitro.resource.Base;
using com.citrix.netscaler.nitro.service;
using com.citrix.netscaler.nitro.util;

namespace com.citrix.netscaler.nitro.resource.config.authentication
{
  public class authenticationpolicylabel : base_resource
  {
    private string labelnameField = (string) null;
    private string commentField = (string) null;
    private string loginschemaField = (string) null;
    private string newnameField = (string) null;
    private uint? numpolField = new uint?();
    private long? hitsField = new long?();
    private string policynameField = (string) null;
    private uint? priorityField = new uint?();
    private string gotopriorityexpressionField = (string) null;
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

    public string comment
    {
      get => this.commentField;
      set => this.commentField = value;
    }

    public string loginschema
    {
      get => this.loginschemaField;
      set => this.loginschemaField = value;
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
      authenticationpolicylabel.authenticationpolicylabel_response authenticationpolicylabelResponse = new authenticationpolicylabel.authenticationpolicylabel_response();
      authenticationpolicylabel.authenticationpolicylabel_response resource = (authenticationpolicylabel.authenticationpolicylabel_response) service.get_payload_formatter().string_to_resource(authenticationpolicylabelResponse.GetType(), response);
      if (resource.errorcode != 0)
      {
        if (resource.errorcode == 444)
          service.clear_session();
        if (resource.severity == null)
          throw new nitro_exception(resource.message, resource.errorcode);
        if (resource.severity.Equals("ERROR"))
          throw new nitro_exception(resource.message, resource.errorcode);
      }
      return (base_resource[]) resource.authenticationpolicylabel;
    }

    internal override string get_object_name() => this.labelname;

    public static base_response add(
      nitro_service client,
      authenticationpolicylabel resource)
    {
      return new authenticationpolicylabel()
      {
        labelname = resource.labelname,
        comment = resource.comment,
        loginschema = resource.loginschema
      }.add_resource(client);
    }

    public static base_responses add(
      nitro_service client,
      authenticationpolicylabel[] resources)
    {
      base_responses baseResponses = (base_responses) null;
      if (resources != null && resources.Length > 0)
      {
        authenticationpolicylabel[] authenticationpolicylabelArray = new authenticationpolicylabel[resources.Length];
        for (int index = 0; index < resources.Length; ++index)
        {
          authenticationpolicylabelArray[index] = new authenticationpolicylabel();
          authenticationpolicylabelArray[index].labelname = resources[index].labelname;
          authenticationpolicylabelArray[index].comment = resources[index].comment;
          authenticationpolicylabelArray[index].loginschema = resources[index].loginschema;
        }
        baseResponses = base_resource.add_bulk_request(client, (base_resource[]) authenticationpolicylabelArray);
      }
      return baseResponses;
    }

    public static base_response delete(nitro_service client, string labelname) => new authenticationpolicylabel()
    {
      labelname = labelname
    }.delete_resource(client);

    public static base_response delete(
      nitro_service client,
      authenticationpolicylabel resource)
    {
      return new authenticationpolicylabel()
      {
        labelname = resource.labelname
      }.delete_resource(client);
    }

    public static base_responses delete(nitro_service client, string[] labelname)
    {
      base_responses baseResponses = (base_responses) null;
      if (labelname != null && labelname.Length > 0)
      {
        authenticationpolicylabel[] authenticationpolicylabelArray = new authenticationpolicylabel[labelname.Length];
        for (int index = 0; index < labelname.Length; ++index)
        {
          authenticationpolicylabelArray[index] = new authenticationpolicylabel();
          authenticationpolicylabelArray[index].labelname = labelname[index];
        }
        baseResponses = base_resource.delete_bulk_request(client, (base_resource[]) authenticationpolicylabelArray);
      }
      return baseResponses;
    }

    public static base_responses delete(
      nitro_service client,
      authenticationpolicylabel[] resources)
    {
      base_responses baseResponses = (base_responses) null;
      if (resources != null && resources.Length > 0)
      {
        authenticationpolicylabel[] authenticationpolicylabelArray = new authenticationpolicylabel[resources.Length];
        for (int index = 0; index < resources.Length; ++index)
        {
          authenticationpolicylabelArray[index] = new authenticationpolicylabel();
          authenticationpolicylabelArray[index].labelname = resources[index].labelname;
        }
        baseResponses = base_resource.delete_bulk_request(client, (base_resource[]) authenticationpolicylabelArray);
      }
      return baseResponses;
    }

    public static base_response rename(
      nitro_service client,
      authenticationpolicylabel resource,
      string new_labelname)
    {
      return new authenticationpolicylabel()
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
      return new authenticationpolicylabel()
      {
        labelname = labelname,
        newname = new_labelname
      }.rename_resource(client);
    }

    public static authenticationpolicylabel[] get(nitro_service service) => (authenticationpolicylabel[]) new authenticationpolicylabel().get_resources(service, (options) null);

    public static authenticationpolicylabel[] get(
      nitro_service service,
      options option)
    {
      return (authenticationpolicylabel[]) new authenticationpolicylabel().get_resources(service, option);
    }

    public static authenticationpolicylabel get(
      nitro_service service,
      string labelname)
    {
      return (authenticationpolicylabel) new authenticationpolicylabel()
      {
        labelname = labelname
      }.get_resource(service);
    }

    public static authenticationpolicylabel[] get(
      nitro_service service,
      string[] labelname)
    {
      if (labelname == null || labelname.Length <= 0)
        return (authenticationpolicylabel[]) null;
      authenticationpolicylabel[] authenticationpolicylabelArray1 = new authenticationpolicylabel[labelname.Length];
      authenticationpolicylabel[] authenticationpolicylabelArray2 = new authenticationpolicylabel[labelname.Length];
      for (int index = 0; index < labelname.Length; ++index)
      {
        authenticationpolicylabelArray2[index] = new authenticationpolicylabel();
        authenticationpolicylabelArray2[index].labelname = labelname[index];
        authenticationpolicylabelArray1[index] = (authenticationpolicylabel) authenticationpolicylabelArray2[index].get_resource(service);
      }
      return authenticationpolicylabelArray1;
    }

    public static authenticationpolicylabel[] get_filtered(
      nitro_service service,
      string filter)
    {
      authenticationpolicylabel authenticationpolicylabel = new authenticationpolicylabel();
      options option = new options();
      option.set_filter(filter);
      return (authenticationpolicylabel[]) authenticationpolicylabel.getfiltered(service, option);
    }

    public static authenticationpolicylabel[] get_filtered(
      nitro_service service,
      filtervalue[] filter)
    {
      authenticationpolicylabel authenticationpolicylabel = new authenticationpolicylabel();
      options option = new options();
      option.set_filter(filter);
      return (authenticationpolicylabel[]) authenticationpolicylabel.getfiltered(service, option);
    }

    public static uint count(nitro_service service)
    {
      authenticationpolicylabel authenticationpolicylabel = new authenticationpolicylabel();
      options option = new options();
      option.set_count(true);
      authenticationpolicylabel[] resources = (authenticationpolicylabel[]) authenticationpolicylabel.get_resources(service, option);
      return resources != null && resources.Length > 0 ? resources[0].__count.Value : 0U;
    }

    public static uint count_filtered(nitro_service service, string filter)
    {
      authenticationpolicylabel authenticationpolicylabel = new authenticationpolicylabel();
      options option = new options();
      option.set_count(true);
      option.set_filter(filter);
      authenticationpolicylabel[] authenticationpolicylabelArray = (authenticationpolicylabel[]) authenticationpolicylabel.getfiltered(service, option);
      return authenticationpolicylabelArray != null && authenticationpolicylabelArray.Length > 0 ? authenticationpolicylabelArray[0].__count.Value : 0U;
    }

    public static uint count_filtered(nitro_service service, filtervalue[] filter)
    {
      authenticationpolicylabel authenticationpolicylabel = new authenticationpolicylabel();
      options option = new options();
      option.set_count(true);
      option.set_filter(filter);
      authenticationpolicylabel[] authenticationpolicylabelArray = (authenticationpolicylabel[]) authenticationpolicylabel.getfiltered(service, option);
      return authenticationpolicylabelArray != null && authenticationpolicylabelArray.Length > 0 ? authenticationpolicylabelArray[0].__count.Value : 0U;
    }

    private class authenticationpolicylabel_response : base_response
    {
      public authenticationpolicylabel[] authenticationpolicylabel = (authenticationpolicylabel[]) null;
    }
  }
}
