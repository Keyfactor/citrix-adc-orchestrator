// Decompiled with JetBrains decompiler
// Type: com.citrix.netscaler.nitro.resource.config.policy.policyexpression_args
// Assembly: nitro, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 6CF5DDEF-E052-4F9D-953F-6644F8378A66


namespace com.citrix.netscaler.nitro.resource.config.policy
{
  public class policyexpression_args
  {
    private string typeField = (string) null;

    public string type
    {
      get => this.typeField;
      set => this.typeField = value;
    }

    public static class typeEnum
    {
      public const string CLASSIC = "CLASSIC";
      public const string ADVANCED = "ADVANCED";
    }
  }
}
