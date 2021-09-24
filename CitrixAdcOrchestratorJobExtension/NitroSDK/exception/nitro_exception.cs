// Decompiled with JetBrains decompiler
// Type: com.citrix.netscaler.nitro.exception.nitro_exception
// Assembly: nitro, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 6CF5DDEF-E052-4F9D-953F-6644F8378A66


using com.citrix.netscaler.nitro.resource.Base;
using System;

namespace com.citrix.netscaler.nitro.exception
{
  public class nitro_exception : Exception
  {
    private int errorcode;
    public base_response[] response;

    public nitro_exception() => this.errorcode = -1;

    public nitro_exception(string msg)
      : base(msg)
    {
      this.errorcode = -1;
    }

    public nitro_exception(string msg, int errcode)
      : base(msg)
    {
      this.errorcode = errcode;
    }

    public nitro_exception(string msg, int errcode, base_response[] response)
      : base(msg)
    {
      this.errorcode = errcode;
      this.response = response;
    }

    public int getErrorCode() => this.errorcode;
  }
}
