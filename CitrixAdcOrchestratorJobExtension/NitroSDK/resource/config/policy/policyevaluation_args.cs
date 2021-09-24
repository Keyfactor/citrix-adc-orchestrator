// Decompiled with JetBrains decompiler
// Type: com.citrix.netscaler.nitro.resource.config.policy.policyevaluation_args
// Assembly: nitro, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 6CF5DDEF-E052-4F9D-953F-6644F8378A66


namespace com.citrix.netscaler.nitro.resource.config.policy
{
  public class policyevaluation_args
  {
    private string expressionField = (string) null;
    private string actionField = (string) null;
    private string typeField = (string) null;
    private string inputField = (string) null;

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

    public static class typeEnum
    {
      public const string HTTP_REQ = "HTTP_REQ";
      public const string HTTP_RES = "HTTP_RES";
      public const string TEXT = "TEXT";
    }
  }
}
