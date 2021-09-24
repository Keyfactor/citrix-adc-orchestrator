// Decompiled with JetBrains decompiler
// Type: com.citrix.netscaler.nitro.resource.config.policy.policyevaluation
// Assembly: nitro, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 6CF5DDEF-E052-4F9D-953F-6644F8378A66


using com.citrix.netscaler.nitro.exception;
using com.citrix.netscaler.nitro.resource.Base;
using com.citrix.netscaler.nitro.service;
using com.citrix.netscaler.nitro.util;

namespace com.citrix.netscaler.nitro.resource.config.policy
{
  public class policyevaluation : base_resource
  {
    private string expressionField = (string) null;
    private string actionField = (string) null;
    private string typeField = (string) null;
    private string inputField = (string) null;
    private string pitmodifiedinputdataField = (string) null;
    private bool? pitboolresultField = new bool?();
    private uint? pitnumresultField = new uint?();
    private double? pitdoubleresultField = new double?();
    private long? pitulongresultField = new long?();
    private string pitrefresultField = (string) null;
    private uint? pitoffsetresultField = new uint?();
    private uint? pitoffsetresultlenField = new uint?();
    private bool? istruncatedrefresultField = new bool?();
    private long? pitboolevaltimeField = new long?();
    private long? pitnumevaltimeField = new long?();
    private long? pitdoubleevaltimeField = new long?();
    private long? pitulongevaltimeField = new long?();
    private long? pitrefevaltimeField = new long?();
    private long? pitoffsetevaltimeField = new long?();
    private long? pitactionevaltimeField = new long?();
    private string[] pitoperationperformerarrayField = (string[]) null;
    private uint?[] pitoldoffsetarrayField = (uint?[]) null;
    private uint?[] pitnewoffsetarrayField = (uint?[]) null;
    private int?[] pitoffsetlengtharrayField = (int?[]) null;
    private string pitboolerrorresultField = (string) null;
    private string pitnumerrorresultField = (string) null;
    private string pitdoubleerrorresultField = (string) null;
    private string pitulongerrorresultField = (string) null;
    private string pitreferrorresultField = (string) null;
    private string pitoffseterrorresultField = (string) null;
    private string pitactionerrorresultField = (string) null;
    private uint? __countField = new uint?();

    public uint? __count
    {
      get => this.__countField;
      private set => this.__countField = value;
    }

    public string expression
    {
      get => this.expressionField;
      set => this.expressionField = value;
    }

    public string action
    {
      get => this.actionField;
      set => this.actionField = value;
    }

    public string type
    {
      get => this.typeField;
      set => this.typeField = value;
    }

    public string input
    {
      get => this.inputField;
      set => this.inputField = value;
    }

    public string pitmodifiedinputdata
    {
      get => this.pitmodifiedinputdataField;
      private set => this.pitmodifiedinputdataField = value;
    }

    public bool? pitboolresult
    {
      get => this.pitboolresultField;
      private set => this.pitboolresultField = value;
    }

    public uint? pitnumresult
    {
      get => this.pitnumresultField;
      private set => this.pitnumresultField = value;
    }

    public double? pitdoubleresult
    {
      get => this.pitdoubleresultField;
      private set => this.pitdoubleresultField = value;
    }

    public long? pitulongresult
    {
      get => this.pitulongresultField;
      private set => this.pitulongresultField = value;
    }

    public string pitrefresult
    {
      get => this.pitrefresultField;
      private set => this.pitrefresultField = value;
    }

    public uint? pitoffsetresult
    {
      get => this.pitoffsetresultField;
      private set => this.pitoffsetresultField = value;
    }

    public uint? pitoffsetresultlen
    {
      get => this.pitoffsetresultlenField;
      private set => this.pitoffsetresultlenField = value;
    }

    public bool? istruncatedrefresult
    {
      get => this.istruncatedrefresultField;
      private set => this.istruncatedrefresultField = value;
    }

    public long? pitboolevaltime
    {
      get => this.pitboolevaltimeField;
      private set => this.pitboolevaltimeField = value;
    }

    public long? pitnumevaltime
    {
      get => this.pitnumevaltimeField;
      private set => this.pitnumevaltimeField = value;
    }

    public long? pitdoubleevaltime
    {
      get => this.pitdoubleevaltimeField;
      private set => this.pitdoubleevaltimeField = value;
    }

    public long? pitulongevaltime
    {
      get => this.pitulongevaltimeField;
      private set => this.pitulongevaltimeField = value;
    }

    public long? pitrefevaltime
    {
      get => this.pitrefevaltimeField;
      private set => this.pitrefevaltimeField = value;
    }

    public long? pitoffsetevaltime
    {
      get => this.pitoffsetevaltimeField;
      private set => this.pitoffsetevaltimeField = value;
    }

    public long? pitactionevaltime
    {
      get => this.pitactionevaltimeField;
      private set => this.pitactionevaltimeField = value;
    }

    public string[] pitoperationperformerarray
    {
      get => this.pitoperationperformerarrayField;
      private set => this.pitoperationperformerarrayField = value;
    }

    public uint?[] pitoldoffsetarray
    {
      get => this.pitoldoffsetarrayField;
      private set => this.pitoldoffsetarrayField = value;
    }

    public uint?[] pitnewoffsetarray
    {
      get => this.pitnewoffsetarrayField;
      private set => this.pitnewoffsetarrayField = value;
    }

    public int?[] pitoffsetlengtharray
    {
      get => this.pitoffsetlengtharrayField;
      private set => this.pitoffsetlengtharrayField = value;
    }

    public string pitboolerrorresult
    {
      get => this.pitboolerrorresultField;
      private set => this.pitboolerrorresultField = value;
    }

    public string pitnumerrorresult
    {
      get => this.pitnumerrorresultField;
      private set => this.pitnumerrorresultField = value;
    }

    public string pitdoubleerrorresult
    {
      get => this.pitdoubleerrorresultField;
      private set => this.pitdoubleerrorresultField = value;
    }

    public string pitulongerrorresult
    {
      get => this.pitulongerrorresultField;
      private set => this.pitulongerrorresultField = value;
    }

    public string pitreferrorresult
    {
      get => this.pitreferrorresultField;
      private set => this.pitreferrorresultField = value;
    }

    public string pitoffseterrorresult
    {
      get => this.pitoffseterrorresultField;
      private set => this.pitoffseterrorresultField = value;
    }

    public string pitactionerrorresult
    {
      get => this.pitactionerrorresultField;
      private set => this.pitactionerrorresultField = value;
    }

    internal override base_resource[] get_nitro_response(
      nitro_service service,
      string response)
    {
      policyevaluation.policyevaluation_response policyevaluationResponse = new policyevaluation.policyevaluation_response();
      policyevaluation.policyevaluation_response resource = (policyevaluation.policyevaluation_response) service.get_payload_formatter().string_to_resource(policyevaluationResponse.GetType(), response);
      if (resource.errorcode != 0)
      {
        if (resource.errorcode == 444)
          service.clear_session();
        if (resource.severity == null)
          throw new nitro_exception(resource.message, resource.errorcode);
        if (resource.severity.Equals("ERROR"))
          throw new nitro_exception(resource.message, resource.errorcode);
      }
      return (base_resource[]) resource.policyevaluation;
    }

    internal override string get_object_name() => (string) null;

    public static policyevaluation get(nitro_service service, policyevaluation obj)
    {
      options option = new options();
      option.set_args(nitro_util.object_to_string_withoutquotes((object) obj));
      return (policyevaluation) obj.get_resource(service, option);
    }

    public static policyevaluation[] get(
      nitro_service service,
      policyevaluation[] obj)
    {
      if (obj == null || obj.Length <= 0)
        return (policyevaluation[]) null;
      policyevaluation[] policyevaluationArray = new policyevaluation[obj.Length];
      for (int index = 0; index < obj.Length; ++index)
      {
        options option = new options();
        option.set_args(nitro_util.object_to_string_withoutquotes((object) obj[index]));
        policyevaluationArray[index] = (policyevaluation) obj[index].get_resource(service, option);
      }
      return policyevaluationArray;
    }

    public static policyevaluation[] get(
      nitro_service service,
      policyevaluation_args args)
    {
      policyevaluation policyevaluation = new policyevaluation();
      options option = new options();
      option.set_args(nitro_util.object_to_string_withoutquotes((object) args));
      return (policyevaluation[]) policyevaluation.get_resources(service, option);
    }

    public static policyevaluation[] get_filtered(
      nitro_service service,
      policyevaluation obj,
      string filter)
    {
      options option = new options();
      option.set_filter(filter);
      option.set_args(nitro_util.object_to_string_withoutquotes((object) obj));
      return (policyevaluation[]) obj.getfiltered(service, option);
    }

    public static policyevaluation[] get_filtered(
      nitro_service service,
      policyevaluation obj,
      filtervalue[] filter)
    {
      options option = new options();
      option.set_filter(filter);
      option.set_args(nitro_util.object_to_string_withoutquotes((object) obj));
      return (policyevaluation[]) obj.getfiltered(service, option);
    }

    public static uint count(nitro_service service, policyevaluation obj)
    {
      options option = new options();
      option.set_count(true);
      option.set_args(nitro_util.object_to_string_withoutquotes((object) obj));
      policyevaluation[] resources = (policyevaluation[]) obj.get_resources(service, option);
      return resources != null && resources.Length > 0 ? resources[0].__count.Value : 0U;
    }

    public static uint count_filtered(nitro_service service, policyevaluation obj, string filter)
    {
      options option = new options();
      option.set_count(true);
      option.set_filter(filter);
      option.set_args(nitro_util.object_to_string_withoutquotes((object) obj));
      policyevaluation[] policyevaluationArray = (policyevaluation[]) obj.getfiltered(service, option);
      return policyevaluationArray != null && policyevaluationArray.Length > 0 ? policyevaluationArray[0].__count.Value : 0U;
    }

    public static uint count_filtered(
      nitro_service service,
      policyevaluation obj,
      filtervalue[] filter)
    {
      options option = new options();
      option.set_count(true);
      option.set_filter(filter);
      option.set_args(nitro_util.object_to_string_withoutquotes((object) obj));
      policyevaluation[] policyevaluationArray = (policyevaluation[]) obj.getfiltered(service, option);
      return policyevaluationArray != null && policyevaluationArray.Length > 0 ? policyevaluationArray[0].__count.Value : 0U;
    }

    private class policyevaluation_response : base_response
    {
      public policyevaluation[] policyevaluation = (policyevaluation[]) null;
    }

    public static class pitoperationperformerarrayEnum
    {
      public const string INSERT = "INSERT";
      public const string MODIFY = "MODIFY";
      public const string DELETE = "DELETE";
    }

    public static class typeEnum
    {
      public const string HTTP_REQ = "HTTP_REQ";
      public const string HTTP_RES = "HTTP_RES";
      public const string TEXT = "TEXT";
    }
  }
}
