// Decompiled with JetBrains decompiler
// Type: com.citrix.netscaler.nitro.resource.config.lsn.lsnstatic_args
// Assembly: nitro, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 6CF5DDEF-E052-4F9D-953F-6644F8378A66


namespace com.citrix.netscaler.nitro.resource.config.lsn
{
  public class lsnstatic_args
  {
    private string nattypeField = (string) null;

    public string nattype
    {
      get => this.nattypeField;
      set => this.nattypeField = value;
    }

    public static class nattypeEnum
    {
      public const string NAT44 = "NAT44";
      public const string DS_Lite = "DS-Lite";
    }
  }
}
