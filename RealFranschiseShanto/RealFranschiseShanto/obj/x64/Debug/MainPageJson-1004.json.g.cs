// This is a system generated file (G2). It reflects the Starcounter App Template defined in the file "MainPageJson.json"
// Version: 1004
// DO NOT MODIFY DIRECTLY - CHANGES WILL BE OVERWRITTEN

using System;
using System.Collections;
using System.Collections.Generic;
using Starcounter.Advanced;
using Starcounter;
using Starcounter.Internal;
using Starcounter.Templates;
using Starcounter.XSON;
#pragma warning disable 0108
#pragma warning disable 1591

namespace RealFranschiseShanto {
using __MainPage1__ = global::RealFranschiseShanto.MainPageJson.JsonByExample;
using _ScTemplate_ = Starcounter.Templates.Template;
using st = Starcounter.Templates;
using s = Starcounter;
using __MaAddCompa__ = global::RealFranschiseShanto.MainPageJson.Input.AddCompanyTrigger;
using __MaCompanyN__ = global::RealFranschiseShanto.MainPageJson.Input.CompanyNameToCreate;
using __MaHtml__ = global::RealFranschiseShanto.MainPageJson.Input.Html;
using __MainPage2__ = global::RealFranschiseShanto.MainPageJson.Input;
using __Arr__ = global::Starcounter.Arr<global::Starcounter.Json>;
using _GEN1_ = System.Diagnostics.DebuggerNonUserCodeAttribute;
using _GEN2_ = System.CodeDom.Compiler.GeneratedCodeAttribute;
using __TLong__ = global::Starcounter.Templates.TLong;
using __TString__ = global::Starcounter.Templates.TString;
using __MaSchema__ = global::RealFranschiseShanto.MainPageJson.JsonByExample.Schema;
using __Json1__ = global::Starcounter.Json.JsonByExample;
using __TObject__ = global::Starcounter.Templates.TObject;
using __Json__ = global::Starcounter.Json;
using __MainPage__ = global::RealFranschiseShanto.MainPageJson;
using __TArray__ = global::Starcounter.Templates.TArray<global::Starcounter.Json>;

#line hidden
[_GEN1_][_GEN2_("Starcounter","2.0")]
public class MainPageJson_json : s::TemplateAttribute {
}
#line default

#line hidden
public partial class MainPageJson : __Json__ {
    #line hidden
    [_GEN2_("Starcounter","2.0")]
    public static __MaSchema__ DefaultTemplate = new __MaSchema__();
    [_GEN1_][_GEN2_("Starcounter","2.0")]
    public MainPageJson() { }
    [_GEN1_][_GEN2_("Starcounter","2.0")]
    public MainPageJson(__MaSchema__ template) { Template = template; }
    [_GEN1_][_GEN2_("Starcounter","2.0")]
    protected override _ScTemplate_ GetDefaultTemplate() { return DefaultTemplate; }
    [_GEN1_][_GEN2_("Starcounter","2.0")]
    public new __MaSchema__ Template { get { return (__MaSchema__)base.Template; } set { base.Template = value; } }
    public override bool IsCodegenerated { get { return true; } }
    #line default
    
    #line hidden
    [_GEN1_][_GEN2_("Starcounter","2.0")]
    public static class JsonByExample {
        
        #line hidden
        public class Schema : __TObject__ {
            public Schema()
                : base() {
                InstanceType = typeof(__MainPage__);
                Properties.ClearExposed();
                Html = Add<__TString__>("Html");
                Html.DefaultValue = "/RealFranschiseShanto/MainPageView.html";
                Html.SetCustomAccessors((_p_) => { return ((__MainPage__)_p_).__bf__Html__; }, (_p_, _v_) => { ((__MainPage__)_p_).__bf__Html__ = (System.String)_v_; }, false);
                CompanyNameToCreate = Add<__TString__>("CompanyNameToCreate$");
                CompanyNameToCreate.DefaultValue = "";
                CompanyNameToCreate.Editable = true;
                CompanyNameToCreate.SetCustomAccessors((_p_) => { return ((__MainPage__)_p_).__bf__CompanyNameToCreate__; }, (_p_, _v_) => { ((__MainPage__)_p_).__bf__CompanyNameToCreate__ = (System.String)_v_; }, false);
                AddCompanyTrigger = Add<__TLong__>("AddCompanyTrigger$");
                AddCompanyTrigger.DefaultValue = 0L;
                AddCompanyTrigger.Editable = true;
                AddCompanyTrigger.SetCustomAccessors((_p_) => { return ((__MainPage__)_p_).__bf__AddCompanyTrigger__; }, (_p_, _v_) => { ((__MainPage__)_p_).__bf__AddCompanyTrigger__ = (System.Int64)_v_; }, false);
                AddCompanyTrigger.AddHandler((Json pup, Property<Int64> prop, Int64 value) => { return (new Input.AddCompanyTrigger() { App = (MainPageJson)pup, Template = (TLong)prop, Value = value }); }, (Json pup, Starcounter.Input<Int64> input) => { ((MainPageJson)pup).Handle((Input.AddCompanyTrigger)input); });
                CompanyList = Add<__TArray__>("CompanyList");
                CompanyList.SetCustomAccessors((_p_) => { return ((__MainPage__)_p_).__bf__CompanyList__; }, (_p_, _v_) => { ((__MainPage__)_p_).__bf__CompanyList__ = (__Arr__)_v_; }, false);
            }
            public override object CreateInstance(s.Json parent) { return new __MainPage__(this) { Parent = parent }; }
            public __TString__ Html;
            public __TString__ CompanyNameToCreate;
            public __TLong__ AddCompanyTrigger;
            public __TArray__ CompanyList;
        }
        #line default
    }
    #line default
    #line hidden
    private System.String __bf__Html__;
    #line default
    [_GEN1_][_GEN2_("Starcounter","2.0")]
    public System.String Html {
    #line 2 "MainPageJson.json"
        get {
        #line hidden
            return Template.Html.Getter(this); }
        #line 2 "MainPageJson.json"
        set {
        #line hidden
            Template.Html.Setter(this, value); } }
        #line default
    #line hidden
    private System.String __bf__CompanyNameToCreate__;
    #line default
    [_GEN1_][_GEN2_("Starcounter","2.0")]
    public System.String CompanyNameToCreate {
    #line 3 "MainPageJson.json"
        get {
        #line hidden
            return Template.CompanyNameToCreate.Getter(this); }
        #line 3 "MainPageJson.json"
        set {
        #line hidden
            Template.CompanyNameToCreate.Setter(this, value); } }
        #line default
    #line hidden
    private System.Int64 __bf__AddCompanyTrigger__;
    #line default
    [_GEN1_][_GEN2_("Starcounter","2.0")]
    public System.Int64 AddCompanyTrigger {
    #line 4 "MainPageJson.json"
        get {
        #line hidden
            return Template.AddCompanyTrigger.Getter(this); }
        #line 4 "MainPageJson.json"
        set {
        #line hidden
            Template.AddCompanyTrigger.Setter(this, value); } }
        #line default
    #line hidden
    private __Arr__ __bf__CompanyList__;
    #line default
    [_GEN1_][_GEN2_("Starcounter","2.0")]
    public __Arr__ CompanyList {
    #line 5 "MainPageJson.json"
        get {
        #line hidden
            return Template.CompanyList.Getter(this); }
        #line 5 "MainPageJson.json"
        set {
        #line hidden
            Template.CompanyList.Setter(this, value); } }
        #line default
    
    #line hidden
    [_GEN1_][_GEN2_("Starcounter","2.0")]
    public static class Input {
        
        #line hidden
        public class Html : Input<__MainPage__, __TString__, string> {
        }
        #line default
        
        #line hidden
        public class CompanyNameToCreate : Input<__MainPage__, __TString__, string> {
        }
        #line default
        
        #line hidden
        public class AddCompanyTrigger : Input<__MainPage__, __TLong__, long> {
        }
        #line default
    }
    #line default
}
#line default
}
#pragma warning restore 1591
#pragma warning restore 0108
