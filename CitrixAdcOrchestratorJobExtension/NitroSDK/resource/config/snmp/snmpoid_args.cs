// Decompiled with JetBrains decompiler
// Type: com.citrix.netscaler.nitro.resource.config.snmp.snmpoid_args
// Assembly: nitro, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 6CF5DDEF-E052-4F9D-953F-6644F8378A66


namespace com.citrix.netscaler.nitro.resource.config.snmp
{
  public class snmpoid_args
  {
    private string entitytypeField = (string) null;

    public string entitytype
    {
      get => this.entitytypeField;
      set => this.entitytypeField = value;
    }

    public static class entitytypeEnum
    {
      public const string VSERVER = "VSERVER";
      public const string SERVICE = "SERVICE";
      public const string SERVICEGROUP = "SERVICEGROUP";
    }
  }
}
