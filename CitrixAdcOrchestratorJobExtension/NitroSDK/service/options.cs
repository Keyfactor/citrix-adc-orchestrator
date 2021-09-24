// Decompiled with JetBrains decompiler
// Type: com.citrix.netscaler.nitro.service.options
// Assembly: nitro, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 6CF5DDEF-E052-4F9D-953F-6644F8378A66


using com.citrix.netscaler.nitro.util;
using System.Web;

namespace com.citrix.netscaler.nitro.service
{
  public class options
  {
    private int pageno;
    private int pagesize;
    private bool detailview;
    private bool compression;
    private string action;
    private string args;
    private string filter;
    private bool count;
    public options.error onerror;

    public options()
    {
      this.compression = true;
      this.detailview = true;
      this.pageno = 0;
      this.pagesize = 0;
      this.action = (string) null;
      this.filter = (string) null;
      this.count = false;
    }

    public void set_pageno(int no) => this.pageno = no;

    public void set_pagesize(int size) => this.pagesize = size;

    public void set_onerror(options.error onerror) => this.onerror = onerror;

    public int get_pageno() => this.pageno;

    public options.error get_onerror() => this.onerror;

    public string get_action() => this.action;

    public void set_action(string action) => this.action = action;

    public void set_args(string args) => this.args = args;

    public void set_filter(string filter) => this.filter = filter;

    public void set_filter(filtervalue[] filter)
    {
      string str = (string) null;
      for (int index = 0; index < filter.Length; ++index)
      {
        if (str != null)
          str += ",";
        str = str != null ? str + filter[index].get_name() + ":" + HttpUtility.UrlEncode(filter[index].get_value()) : filter[index].get_name() + ":" + HttpUtility.UrlEncode(filter[index].get_value());
      }
      this.filter = str;
    }

    public string get_filter() => this.filter;

    public int get_pagesize() => this.pagesize;

    public bool get_compression() => this.compression;

    public void set_compression(bool flag) => this.compression = flag;

    public bool get_detailview() => this.detailview;

    public void set_detailview(bool flag) => this.detailview = flag;

    public bool get_count() => this.count;

    public void set_count(bool flag) => this.count = flag;

    public string to_string()
    {
      string str = "";
      if (this.pageno > 0)
        str = "pageno=" + (object) this.pageno;
      if (this.pagesize > 0)
      {
        if (str.Length > 0)
          str += "&";
        str = str + "pagesize=" + (object) this.pagesize;
      }
      if (this.detailview)
      {
        if (str.Length > 0)
          str += "&";
        str += "view=detail";
      }
      if (this.count)
      {
        if (str.Length > 0)
          str += "&";
        str += "count=yes";
      }
      if (this.args != null)
      {
        if (str.Length > 0)
          str += "&";
        str = str + "args=" + this.args;
      }
      if (this.filter != null)
      {
        if (str.Length > 0)
          str += "&";
        str = str + "filter=" + this.filter;
      }
      return str;
    }

    public enum error
    {
      ROLLBACK,
      EXIT,
    }
  }
}
