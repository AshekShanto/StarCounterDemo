// This is a system generated file (G2). It reflects the Starcounter App Template defined in the file "CompanyJson.json"
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
using __CompanyJ2__ = global::RealFranschiseShanto.CompanyJson.Input;
using _ScTemplate_ = Starcounter.Templates.Template;
using st = Starcounter.Templates;
using s = Starcounter;
using __CoSortByTr__ = global::RealFranschiseShanto.CompanyJson.Input.SortByTrendTrigger;
using __CoSortByAv__ = global::RealFranschiseShanto.CompanyJson.Input.SortByAverageComissionTrigger;
using __CoSortByTo__ = global::RealFranschiseShanto.CompanyJson.Input.SortByTotalCommisionTrigger;
using __CoSortByNu__ = global::RealFranschiseShanto.CompanyJson.Input.SortByNumberOfHomesTrigger;
using __CoOfficeNa__ = global::RealFranschiseShanto.CompanyJson.Input.OfficeNameToCreate;
using __CoAddOffic__ = global::RealFranschiseShanto.CompanyJson.Input.AddOfficeTrigger;
using __CoName__ = global::RealFranschiseShanto.CompanyJson.Input.Name;
using __CoHtml__ = global::RealFranschiseShanto.CompanyJson.Input.Html;
using _GEN2_ = System.CodeDom.Compiler.GeneratedCodeAttribute;
using __Arr__ = global::Starcounter.Arr<global::Starcounter.Json>;
using __CompanyJ1__ = global::RealFranschiseShanto.CompanyJson.JsonByExample;
using __TLong__ = global::Starcounter.Templates.TLong;
using __TArray__ = global::Starcounter.Templates.TArray<global::Starcounter.Json>;
using __TString__ = global::Starcounter.Templates.TString;
using __CoSchema__ = global::RealFranschiseShanto.CompanyJson.JsonByExample.Schema;
using __Json1__ = global::Starcounter.Json.JsonByExample;
using __TObject__ = global::Starcounter.Templates.TObject;
using __Json__ = global::Starcounter.Json;
using __CompanyJ__ = global::RealFranschiseShanto.CompanyJson;
using _GEN1_ = System.Diagnostics.DebuggerNonUserCodeAttribute;

#line hidden
[_GEN1_][_GEN2_("Starcounter","2.0")]
public class CompanyJson_json : s::TemplateAttribute {
}
#line default

#line hidden
public partial class CompanyJson : __Json__ {
    #line hidden
    [_GEN2_("Starcounter","2.0")]
    public static __CoSchema__ DefaultTemplate = new __CoSchema__();
    [_GEN1_][_GEN2_("Starcounter","2.0")]
    public CompanyJson() { }
    [_GEN1_][_GEN2_("Starcounter","2.0")]
    public CompanyJson(__CoSchema__ template) { Template = template; }
    [_GEN1_][_GEN2_("Starcounter","2.0")]
    protected override _ScTemplate_ GetDefaultTemplate() { return DefaultTemplate; }
    [_GEN1_][_GEN2_("Starcounter","2.0")]
    public new __CoSchema__ Template { get { return (__CoSchema__)base.Template; } set { base.Template = value; } }
    [_GEN1_][_GEN2_("Starcounter","2.0")]
    public new Company Data { get { return (Company)base.Data; } set { base.Data = value; } }
    public override bool IsCodegenerated { get { return true; } }
    #line default
    
    #line hidden
    [_GEN1_][_GEN2_("Starcounter","2.0")]
    public static class JsonByExample {
        
        #line hidden
        public class Schema : __TObject__ {
            public Schema()
                : base() {
                InstanceType = typeof(__CompanyJ__);
                Properties.ClearExposed();
                Html = Add<__TString__>("Html");
                Html.DefaultValue = "/RealFranschiseShanto/CompanyView.html";
                Html.SetCustomAccessors((_p_) => { return ((__CompanyJ__)_p_).__bf__Html__; }, (_p_, _v_) => { ((__CompanyJ__)_p_).__bf__Html__ = (System.String)_v_; }, false);
                Name = Add<__TString__>("Name");
                Name.DefaultValue = "";
                Name.SetCustomAccessors((_p_) => { return ((__CompanyJ__)_p_).__bf__Name__; }, (_p_, _v_) => { ((__CompanyJ__)_p_).__bf__Name__ = (System.String)_v_; }, false);
                OfficeList = Add<__TArray__>("OfficeList");
                OfficeList.SetCustomAccessors((_p_) => { return ((__CompanyJ__)_p_).__bf__OfficeList__; }, (_p_, _v_) => { ((__CompanyJ__)_p_).__bf__OfficeList__ = (__Arr__)_v_; }, false);
                AddOfficeTrigger = Add<__TLong__>("AddOfficeTrigger$");
                AddOfficeTrigger.DefaultValue = 0L;
                AddOfficeTrigger.Editable = true;
                AddOfficeTrigger.SetCustomAccessors((_p_) => { return ((__CompanyJ__)_p_).__bf__AddOfficeTrigger__; }, (_p_, _v_) => { ((__CompanyJ__)_p_).__bf__AddOfficeTrigger__ = (System.Int64)_v_; }, false);
                AddOfficeTrigger.AddHandler((Json pup, Property<Int64> prop, Int64 value) => { return (new Input.AddOfficeTrigger() { App = (CompanyJson)pup, Template = (TLong)prop, Value = value }); }, (Json pup, Starcounter.Input<Int64> input) => { ((CompanyJson)pup).Handle((Input.AddOfficeTrigger)input); });
                OfficeNameToCreate = Add<__TString__>("OfficeNameToCreate$");
                OfficeNameToCreate.DefaultValue = "";
                OfficeNameToCreate.Editable = true;
                OfficeNameToCreate.SetCustomAccessors((_p_) => { return ((__CompanyJ__)_p_).__bf__OfficeNameToCreate__; }, (_p_, _v_) => { ((__CompanyJ__)_p_).__bf__OfficeNameToCreate__ = (System.String)_v_; }, false);
                SortByNumberOfHomesTrigger = Add<__TLong__>("SortByNumberOfHomesTrigger$");
                SortByNumberOfHomesTrigger.DefaultValue = 0L;
                SortByNumberOfHomesTrigger.Editable = true;
                SortByNumberOfHomesTrigger.SetCustomAccessors((_p_) => { return ((__CompanyJ__)_p_).__bf__SortByNumberOfHomesTrigger__; }, (_p_, _v_) => { ((__CompanyJ__)_p_).__bf__SortByNumberOfHomesTrigger__ = (System.Int64)_v_; }, false);
                SortByNumberOfHomesTrigger.AddHandler((Json pup, Property<Int64> prop, Int64 value) => { return (new Input.SortByNumberOfHomesTrigger() { App = (CompanyJson)pup, Template = (TLong)prop, Value = value }); }, (Json pup, Starcounter.Input<Int64> input) => { ((CompanyJson)pup).Handle((Input.SortByNumberOfHomesTrigger)input); });
                SortByTotalCommisionTrigger = Add<__TLong__>("SortByTotalCommisionTrigger$");
                SortByTotalCommisionTrigger.DefaultValue = 0L;
                SortByTotalCommisionTrigger.Editable = true;
                SortByTotalCommisionTrigger.SetCustomAccessors((_p_) => { return ((__CompanyJ__)_p_).__bf__SortByTotalCommisionTrigger__; }, (_p_, _v_) => { ((__CompanyJ__)_p_).__bf__SortByTotalCommisionTrigger__ = (System.Int64)_v_; }, false);
                SortByTotalCommisionTrigger.AddHandler((Json pup, Property<Int64> prop, Int64 value) => { return (new Input.SortByTotalCommisionTrigger() { App = (CompanyJson)pup, Template = (TLong)prop, Value = value }); }, (Json pup, Starcounter.Input<Int64> input) => { ((CompanyJson)pup).Handle((Input.SortByTotalCommisionTrigger)input); });
                SortByAverageComissionTrigger = Add<__TLong__>("SortByAverageComissionTrigger$");
                SortByAverageComissionTrigger.DefaultValue = 0L;
                SortByAverageComissionTrigger.Editable = true;
                SortByAverageComissionTrigger.SetCustomAccessors((_p_) => { return ((__CompanyJ__)_p_).__bf__SortByAverageComissionTrigger__; }, (_p_, _v_) => { ((__CompanyJ__)_p_).__bf__SortByAverageComissionTrigger__ = (System.Int64)_v_; }, false);
                SortByAverageComissionTrigger.AddHandler((Json pup, Property<Int64> prop, Int64 value) => { return (new Input.SortByAverageComissionTrigger() { App = (CompanyJson)pup, Template = (TLong)prop, Value = value }); }, (Json pup, Starcounter.Input<Int64> input) => { ((CompanyJson)pup).Handle((Input.SortByAverageComissionTrigger)input); });
                SortByTrendTrigger = Add<__TLong__>("SortByTrendTrigger$");
                SortByTrendTrigger.DefaultValue = 0L;
                SortByTrendTrigger.Editable = true;
                SortByTrendTrigger.SetCustomAccessors((_p_) => { return ((__CompanyJ__)_p_).__bf__SortByTrendTrigger__; }, (_p_, _v_) => { ((__CompanyJ__)_p_).__bf__SortByTrendTrigger__ = (System.Int64)_v_; }, false);
                SortByTrendTrigger.AddHandler((Json pup, Property<Int64> prop, Int64 value) => { return (new Input.SortByTrendTrigger() { App = (CompanyJson)pup, Template = (TLong)prop, Value = value }); }, (Json pup, Starcounter.Input<Int64> input) => { ((CompanyJson)pup).Handle((Input.SortByTrendTrigger)input); });
            }
            public override object CreateInstance(s.Json parent) { return new __CompanyJ__(this) { Parent = parent }; }
            public __TString__ Html;
            public __TString__ Name;
            public __TArray__ OfficeList;
            public __TLong__ AddOfficeTrigger;
            public __TString__ OfficeNameToCreate;
            public __TLong__ SortByNumberOfHomesTrigger;
            public __TLong__ SortByTotalCommisionTrigger;
            public __TLong__ SortByAverageComissionTrigger;
            public __TLong__ SortByTrendTrigger;
        }
        #line default
    }
    #line default
    #line hidden
    private System.String __bf__Html__;
    #line default
    [_GEN1_][_GEN2_("Starcounter","2.0")]
    public System.String Html {
    #line 2 "CompanyJson.json"
        get {
        #line hidden
            return Template.Html.Getter(this); }
        #line 2 "CompanyJson.json"
        set {
        #line hidden
            Template.Html.Setter(this, value); } }
        #line default
    #line hidden
    private System.String __bf__Name__;
    #line default
    [_GEN1_][_GEN2_("Starcounter","2.0")]
    public System.String Name {
    #line 3 "CompanyJson.json"
        get {
        #line hidden
            return Template.Name.Getter(this); }
        #line 3 "CompanyJson.json"
        set {
        #line hidden
            Template.Name.Setter(this, value); } }
        #line default
    #line hidden
    private __Arr__ __bf__OfficeList__;
    #line default
    [_GEN1_][_GEN2_("Starcounter","2.0")]
    public __Arr__ OfficeList {
    #line 4 "CompanyJson.json"
        get {
        #line hidden
            return Template.OfficeList.Getter(this); }
        #line 4 "CompanyJson.json"
        set {
        #line hidden
            Template.OfficeList.Setter(this, value); } }
        #line default
    #line hidden
    private System.Int64 __bf__AddOfficeTrigger__;
    #line default
    [_GEN1_][_GEN2_("Starcounter","2.0")]
    public System.Int64 AddOfficeTrigger {
    #line 5 "CompanyJson.json"
        get {
        #line hidden
            return Template.AddOfficeTrigger.Getter(this); }
        #line 5 "CompanyJson.json"
        set {
        #line hidden
            Template.AddOfficeTrigger.Setter(this, value); } }
        #line default
    #line hidden
    private System.String __bf__OfficeNameToCreate__;
    #line default
    [_GEN1_][_GEN2_("Starcounter","2.0")]
    public System.String OfficeNameToCreate {
    #line 6 "CompanyJson.json"
        get {
        #line hidden
            return Template.OfficeNameToCreate.Getter(this); }
        #line 6 "CompanyJson.json"
        set {
        #line hidden
            Template.OfficeNameToCreate.Setter(this, value); } }
        #line default
    #line hidden
    private System.Int64 __bf__SortByNumberOfHomesTrigger__;
    #line default
    [_GEN1_][_GEN2_("Starcounter","2.0")]
    public System.Int64 SortByNumberOfHomesTrigger {
    #line 7 "CompanyJson.json"
        get {
        #line hidden
            return Template.SortByNumberOfHomesTrigger.Getter(this); }
        #line 7 "CompanyJson.json"
        set {
        #line hidden
            Template.SortByNumberOfHomesTrigger.Setter(this, value); } }
        #line default
    #line hidden
    private System.Int64 __bf__SortByTotalCommisionTrigger__;
    #line default
    [_GEN1_][_GEN2_("Starcounter","2.0")]
    public System.Int64 SortByTotalCommisionTrigger {
    #line 8 "CompanyJson.json"
        get {
        #line hidden
            return Template.SortByTotalCommisionTrigger.Getter(this); }
        #line 8 "CompanyJson.json"
        set {
        #line hidden
            Template.SortByTotalCommisionTrigger.Setter(this, value); } }
        #line default
    #line hidden
    private System.Int64 __bf__SortByAverageComissionTrigger__;
    #line default
    [_GEN1_][_GEN2_("Starcounter","2.0")]
    public System.Int64 SortByAverageComissionTrigger {
    #line 9 "CompanyJson.json"
        get {
        #line hidden
            return Template.SortByAverageComissionTrigger.Getter(this); }
        #line 9 "CompanyJson.json"
        set {
        #line hidden
            Template.SortByAverageComissionTrigger.Setter(this, value); } }
        #line default
    #line hidden
    private System.Int64 __bf__SortByTrendTrigger__;
    #line default
    [_GEN1_][_GEN2_("Starcounter","2.0")]
    public System.Int64 SortByTrendTrigger {
    #line 10 "CompanyJson.json"
        get {
        #line hidden
            return Template.SortByTrendTrigger.Getter(this); }
        #line 10 "CompanyJson.json"
        set {
        #line hidden
            Template.SortByTrendTrigger.Setter(this, value); } }
        #line default
    
    #line hidden
    [_GEN1_][_GEN2_("Starcounter","2.0")]
    public static class Input {
        
        #line hidden
        public class Html : Input<__CompanyJ__, __TString__, string> {
        }
        #line default
        
        #line hidden
        public class Name : Input<__CompanyJ__, __TString__, string> {
        }
        #line default
        
        #line hidden
        public class AddOfficeTrigger : Input<__CompanyJ__, __TLong__, long> {
        }
        #line default
        
        #line hidden
        public class OfficeNameToCreate : Input<__CompanyJ__, __TString__, string> {
        }
        #line default
        
        #line hidden
        public class SortByNumberOfHomesTrigger : Input<__CompanyJ__, __TLong__, long> {
        }
        #line default
        
        #line hidden
        public class SortByTotalCommisionTrigger : Input<__CompanyJ__, __TLong__, long> {
        }
        #line default
        
        #line hidden
        public class SortByAverageComissionTrigger : Input<__CompanyJ__, __TLong__, long> {
        }
        #line default
        
        #line hidden
        public class SortByTrendTrigger : Input<__CompanyJ__, __TLong__, long> {
        }
        #line default
    }
    #line default
}
#line default
}
#pragma warning restore 1591
#pragma warning restore 0108
