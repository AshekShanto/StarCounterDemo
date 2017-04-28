// This is a system generated file (G2). It reflects the Starcounter App Template defined in the file "OfficeJson.json"
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
using __OfNumberOf__ = global::RealFranschiseShanto.OfficeJson.Input.NumberOfHomesSold;
using _ScTemplate_ = Starcounter.Templates.Template;
using st = Starcounter.Templates;
using s = Starcounter;
using __OfEditOffi__ = global::RealFranschiseShanto.OfficeJson.Input.EditOfficeTrigger;
using __OfFullAddr__ = global::RealFranschiseShanto.OfficeJson.Input.FullAddress;
using __OfCountry__ = global::RealFranschiseShanto.OfficeJson.Input.Country;
using __OfCity__ = global::RealFranschiseShanto.OfficeJson.Input.City;
using __OfZipCode__ = global::RealFranschiseShanto.OfficeJson.Input.ZipCode;
using __OfNumber__ = global::RealFranschiseShanto.OfficeJson.Input.Number;
using __OfStreet__ = global::RealFranschiseShanto.OfficeJson.Input.Street;
using __OfOfficeEd__ = global::RealFranschiseShanto.OfficeJson.Input.OfficeEditLink;
using __OfTrend__ = global::RealFranschiseShanto.OfficeJson.Input.Trend;
using __OfAverageC__ = global::RealFranschiseShanto.OfficeJson.Input.AverageCommission;
using __OfTotalCom__ = global::RealFranschiseShanto.OfficeJson.Input.TotalCommission;
using _GEN1_ = System.Diagnostics.DebuggerNonUserCodeAttribute;
using _GEN2_ = System.CodeDom.Compiler.GeneratedCodeAttribute;
using __OfHtml__ = global::RealFranschiseShanto.OfficeJson.Input.Html;
using __OfficeJs2__ = global::RealFranschiseShanto.OfficeJson.Input;
using __Arr__ = global::Starcounter.Arr<global::Starcounter.Json>;
using __OfficeJs1__ = global::RealFranschiseShanto.OfficeJson.JsonByExample;
using __TArray__ = global::Starcounter.Templates.TArray<global::Starcounter.Json>;
using __TDecimal__ = global::Starcounter.Templates.TDecimal;
using __TLong__ = global::Starcounter.Templates.TLong;
using __TString__ = global::Starcounter.Templates.TString;
using __OfSchema__ = global::RealFranschiseShanto.OfficeJson.JsonByExample.Schema;
using __Json1__ = global::Starcounter.Json.JsonByExample;
using __TObject__ = global::Starcounter.Templates.TObject;
using __Json__ = global::Starcounter.Json;
using __OfficeJs__ = global::RealFranschiseShanto.OfficeJson;
using __OfName__ = global::RealFranschiseShanto.OfficeJson.Input.Name;

#line hidden
[_GEN1_][_GEN2_("Starcounter","2.0")]
public class OfficeJson_json : s::TemplateAttribute {
}
#line default

#line hidden
public partial class OfficeJson : __Json__ {
    #line hidden
    [_GEN2_("Starcounter","2.0")]
    public static __OfSchema__ DefaultTemplate = new __OfSchema__();
    [_GEN1_][_GEN2_("Starcounter","2.0")]
    public OfficeJson() { }
    [_GEN1_][_GEN2_("Starcounter","2.0")]
    public OfficeJson(__OfSchema__ template) { Template = template; }
    [_GEN1_][_GEN2_("Starcounter","2.0")]
    protected override _ScTemplate_ GetDefaultTemplate() { return DefaultTemplate; }
    [_GEN1_][_GEN2_("Starcounter","2.0")]
    public new __OfSchema__ Template { get { return (__OfSchema__)base.Template; } set { base.Template = value; } }
    [_GEN1_][_GEN2_("Starcounter","2.0")]
    public new Office Data { get { return (Office)base.Data; } set { base.Data = value; } }
    public override bool IsCodegenerated { get { return true; } }
    #line default
    
    #line hidden
    [_GEN1_][_GEN2_("Starcounter","2.0")]
    public static class JsonByExample {
        
        #line hidden
        public class Schema : __TObject__ {
            public Schema()
                : base() {
                InstanceType = typeof(__OfficeJs__);
                Properties.ClearExposed();
                Html = Add<__TString__>("Html");
                Html.DefaultValue = "/RealFranschiseShanto/OfficeView.html";
                Html.SetCustomAccessors((_p_) => { return ((__OfficeJs__)_p_).__bf__Html__; }, (_p_, _v_) => { ((__OfficeJs__)_p_).__bf__Html__ = (System.String)_v_; }, false);
                Name = Add<__TString__>("Name$");
                Name.DefaultValue = "";
                Name.Editable = true;
                Name.SetCustomAccessors((_p_) => { return ((__OfficeJs__)_p_).__bf__Name__; }, (_p_, _v_) => { ((__OfficeJs__)_p_).__bf__Name__ = (System.String)_v_; }, false);
                Company = Add<__TObject__>("Company");
                Company.SetCustomAccessors((_p_) => { return ((__OfficeJs__)_p_).__bf__Company__; }, (_p_, _v_) => { ((__OfficeJs__)_p_).__bf__Company__ = (__Json__)_v_; }, false);
                NumberOfHomesSold = Add<__TLong__>("NumberOfHomesSold");
                NumberOfHomesSold.DefaultValue = 0L;
                NumberOfHomesSold.SetCustomAccessors((_p_) => { return ((__OfficeJs__)_p_).__bf__NumberOfHomesSold__; }, (_p_, _v_) => { ((__OfficeJs__)_p_).__bf__NumberOfHomesSold__ = (System.Int64)_v_; }, false);
                TotalCommission = Add<__TLong__>("TotalCommission");
                TotalCommission.DefaultValue = 0L;
                TotalCommission.SetCustomAccessors((_p_) => { return ((__OfficeJs__)_p_).__bf__TotalCommission__; }, (_p_, _v_) => { ((__OfficeJs__)_p_).__bf__TotalCommission__ = (System.Int64)_v_; }, false);
                AverageCommission = Add<__TDecimal__>("AverageCommission");
                AverageCommission.DefaultValue = 0.0m;
                AverageCommission.SetCustomAccessors((_p_) => { return ((__OfficeJs__)_p_).__bf__AverageCommission__; }, (_p_, _v_) => { ((__OfficeJs__)_p_).__bf__AverageCommission__ = (System.Decimal)_v_; }, false);
                Trend = Add<__TLong__>("Trend");
                Trend.DefaultValue = 0L;
                Trend.SetCustomAccessors((_p_) => { return ((__OfficeJs__)_p_).__bf__Trend__; }, (_p_, _v_) => { ((__OfficeJs__)_p_).__bf__Trend__ = (System.Int64)_v_; }, false);
                OfficeEditLink = Add<__TString__>("OfficeEditLink");
                OfficeEditLink.DefaultValue = "";
                OfficeEditLink.SetCustomAccessors((_p_) => { return ((__OfficeJs__)_p_).__bf__OfficeEditLink__; }, (_p_, _v_) => { ((__OfficeJs__)_p_).__bf__OfficeEditLink__ = (System.String)_v_; }, false);
                Street = Add<__TString__>("Street$");
                Street.DefaultValue = "";
                Street.Editable = true;
                Street.SetCustomAccessors((_p_) => { return ((__OfficeJs__)_p_).__bf__Street__; }, (_p_, _v_) => { ((__OfficeJs__)_p_).__bf__Street__ = (System.String)_v_; }, false);
                Number = Add<__TLong__>("Number$");
                Number.DefaultValue = 0L;
                Number.Editable = true;
                Number.SetCustomAccessors((_p_) => { return ((__OfficeJs__)_p_).__bf__Number__; }, (_p_, _v_) => { ((__OfficeJs__)_p_).__bf__Number__ = (System.Int64)_v_; }, false);
                ZipCode = Add<__TLong__>("ZipCode$");
                ZipCode.DefaultValue = 0L;
                ZipCode.Editable = true;
                ZipCode.SetCustomAccessors((_p_) => { return ((__OfficeJs__)_p_).__bf__ZipCode__; }, (_p_, _v_) => { ((__OfficeJs__)_p_).__bf__ZipCode__ = (System.Int64)_v_; }, false);
                City = Add<__TString__>("City$");
                City.DefaultValue = "";
                City.Editable = true;
                City.SetCustomAccessors((_p_) => { return ((__OfficeJs__)_p_).__bf__City__; }, (_p_, _v_) => { ((__OfficeJs__)_p_).__bf__City__ = (System.String)_v_; }, false);
                Country = Add<__TString__>("Country$");
                Country.DefaultValue = "";
                Country.Editable = true;
                Country.SetCustomAccessors((_p_) => { return ((__OfficeJs__)_p_).__bf__Country__; }, (_p_, _v_) => { ((__OfficeJs__)_p_).__bf__Country__ = (System.String)_v_; }, false);
                FullAddress = Add<__TString__>("FullAddress");
                FullAddress.DefaultValue = "";
                FullAddress.SetCustomAccessors((_p_) => { return ((__OfficeJs__)_p_).__bf__FullAddress__; }, (_p_, _v_) => { ((__OfficeJs__)_p_).__bf__FullAddress__ = (System.String)_v_; }, false);
                TransactionList = Add<__TArray__>("TransactionList");
                TransactionList.SetCustomAccessors((_p_) => { return ((__OfficeJs__)_p_).__bf__TransactionList__; }, (_p_, _v_) => { ((__OfficeJs__)_p_).__bf__TransactionList__ = (__Arr__)_v_; }, false);
                EditOfficeTrigger = Add<__TLong__>("EditOfficeTrigger$");
                EditOfficeTrigger.DefaultValue = 0L;
                EditOfficeTrigger.Editable = true;
                EditOfficeTrigger.SetCustomAccessors((_p_) => { return ((__OfficeJs__)_p_).__bf__EditOfficeTrigger__; }, (_p_, _v_) => { ((__OfficeJs__)_p_).__bf__EditOfficeTrigger__ = (System.Int64)_v_; }, false);
                EditOfficeTrigger.AddHandler((Json pup, Property<Int64> prop, Int64 value) => { return (new Input.EditOfficeTrigger() { App = (OfficeJson)pup, Template = (TLong)prop, Value = value }); }, (Json pup, Starcounter.Input<Int64> input) => { ((OfficeJson)pup).Handle((Input.EditOfficeTrigger)input); });
            }
            public override object CreateInstance(s.Json parent) { return new __OfficeJs__(this) { Parent = parent }; }
            public __TString__ Html;
            public __TString__ Name;
            public __TObject__ Company;
            public __TLong__ NumberOfHomesSold;
            public __TLong__ TotalCommission;
            public __TDecimal__ AverageCommission;
            public __TLong__ Trend;
            public __TString__ OfficeEditLink;
            public __TString__ Street;
            public __TLong__ Number;
            public __TLong__ ZipCode;
            public __TString__ City;
            public __TString__ Country;
            public __TString__ FullAddress;
            public __TArray__ TransactionList;
            public __TLong__ EditOfficeTrigger;
        }
        #line default
    }
    #line default
    #line hidden
    private System.String __bf__Html__;
    #line default
    [_GEN1_][_GEN2_("Starcounter","2.0")]
    public System.String Html {
    #line 2 "OfficeJson.json"
        get {
        #line hidden
            return Template.Html.Getter(this); }
        #line 2 "OfficeJson.json"
        set {
        #line hidden
            Template.Html.Setter(this, value); } }
        #line default
    #line hidden
    private System.String __bf__Name__;
    #line default
    [_GEN1_][_GEN2_("Starcounter","2.0")]
    public System.String Name {
    #line 3 "OfficeJson.json"
        get {
        #line hidden
            return Template.Name.Getter(this); }
        #line 3 "OfficeJson.json"
        set {
        #line hidden
            Template.Name.Setter(this, value); } }
        #line default
    #line hidden
    private __Json__ __bf__Company__;
    #line default
    [_GEN1_][_GEN2_("Starcounter","2.0")]
    public __Json__ Company {
    #line 4 "OfficeJson.json"
        get {
        #line hidden
            return (__Json__)Template.Company.Getter(this); }
        #line 4 "OfficeJson.json"
        set {
        #line hidden
            Template.Company.Setter(this, value); } }
        #line default
    #line hidden
    private System.Int64 __bf__NumberOfHomesSold__;
    #line default
    [_GEN1_][_GEN2_("Starcounter","2.0")]
    public System.Int64 NumberOfHomesSold {
    #line 5 "OfficeJson.json"
        get {
        #line hidden
            return Template.NumberOfHomesSold.Getter(this); }
        #line 5 "OfficeJson.json"
        set {
        #line hidden
            Template.NumberOfHomesSold.Setter(this, value); } }
        #line default
    #line hidden
    private System.Int64 __bf__TotalCommission__;
    #line default
    [_GEN1_][_GEN2_("Starcounter","2.0")]
    public System.Int64 TotalCommission {
    #line 6 "OfficeJson.json"
        get {
        #line hidden
            return Template.TotalCommission.Getter(this); }
        #line 6 "OfficeJson.json"
        set {
        #line hidden
            Template.TotalCommission.Setter(this, value); } }
        #line default
    #line hidden
    private System.Decimal __bf__AverageCommission__;
    #line default
    [_GEN1_][_GEN2_("Starcounter","2.0")]
    public System.Decimal AverageCommission {
    #line 7 "OfficeJson.json"
        get {
        #line hidden
            return Template.AverageCommission.Getter(this); }
        #line 7 "OfficeJson.json"
        set {
        #line hidden
            Template.AverageCommission.Setter(this, value); } }
        #line default
    #line hidden
    private System.Int64 __bf__Trend__;
    #line default
    [_GEN1_][_GEN2_("Starcounter","2.0")]
    public System.Int64 Trend {
    #line 8 "OfficeJson.json"
        get {
        #line hidden
            return Template.Trend.Getter(this); }
        #line 8 "OfficeJson.json"
        set {
        #line hidden
            Template.Trend.Setter(this, value); } }
        #line default
    #line hidden
    private System.String __bf__OfficeEditLink__;
    #line default
    [_GEN1_][_GEN2_("Starcounter","2.0")]
    public System.String OfficeEditLink {
    #line 9 "OfficeJson.json"
        get {
        #line hidden
            return Template.OfficeEditLink.Getter(this); }
        #line 9 "OfficeJson.json"
        set {
        #line hidden
            Template.OfficeEditLink.Setter(this, value); } }
        #line default
    #line hidden
    private System.String __bf__Street__;
    #line default
    [_GEN1_][_GEN2_("Starcounter","2.0")]
    public System.String Street {
    #line 10 "OfficeJson.json"
        get {
        #line hidden
            return Template.Street.Getter(this); }
        #line 10 "OfficeJson.json"
        set {
        #line hidden
            Template.Street.Setter(this, value); } }
        #line default
    #line hidden
    private System.Int64 __bf__Number__;
    #line default
    [_GEN1_][_GEN2_("Starcounter","2.0")]
    public System.Int64 Number {
    #line 11 "OfficeJson.json"
        get {
        #line hidden
            return Template.Number.Getter(this); }
        #line 11 "OfficeJson.json"
        set {
        #line hidden
            Template.Number.Setter(this, value); } }
        #line default
    #line hidden
    private System.Int64 __bf__ZipCode__;
    #line default
    [_GEN1_][_GEN2_("Starcounter","2.0")]
    public System.Int64 ZipCode {
    #line 12 "OfficeJson.json"
        get {
        #line hidden
            return Template.ZipCode.Getter(this); }
        #line 12 "OfficeJson.json"
        set {
        #line hidden
            Template.ZipCode.Setter(this, value); } }
        #line default
    #line hidden
    private System.String __bf__City__;
    #line default
    [_GEN1_][_GEN2_("Starcounter","2.0")]
    public System.String City {
    #line 13 "OfficeJson.json"
        get {
        #line hidden
            return Template.City.Getter(this); }
        #line 13 "OfficeJson.json"
        set {
        #line hidden
            Template.City.Setter(this, value); } }
        #line default
    #line hidden
    private System.String __bf__Country__;
    #line default
    [_GEN1_][_GEN2_("Starcounter","2.0")]
    public System.String Country {
    #line 14 "OfficeJson.json"
        get {
        #line hidden
            return Template.Country.Getter(this); }
        #line 14 "OfficeJson.json"
        set {
        #line hidden
            Template.Country.Setter(this, value); } }
        #line default
    #line hidden
    private System.String __bf__FullAddress__;
    #line default
    [_GEN1_][_GEN2_("Starcounter","2.0")]
    public System.String FullAddress {
    #line 15 "OfficeJson.json"
        get {
        #line hidden
            return Template.FullAddress.Getter(this); }
        #line 15 "OfficeJson.json"
        set {
        #line hidden
            Template.FullAddress.Setter(this, value); } }
        #line default
    #line hidden
    private __Arr__ __bf__TransactionList__;
    #line default
    [_GEN1_][_GEN2_("Starcounter","2.0")]
    public __Arr__ TransactionList {
    #line 16 "OfficeJson.json"
        get {
        #line hidden
            return Template.TransactionList.Getter(this); }
        #line 16 "OfficeJson.json"
        set {
        #line hidden
            Template.TransactionList.Setter(this, value); } }
        #line default
    #line hidden
    private System.Int64 __bf__EditOfficeTrigger__;
    #line default
    [_GEN1_][_GEN2_("Starcounter","2.0")]
    public System.Int64 EditOfficeTrigger {
    #line 17 "OfficeJson.json"
        get {
        #line hidden
            return Template.EditOfficeTrigger.Getter(this); }
        #line 17 "OfficeJson.json"
        set {
        #line hidden
            Template.EditOfficeTrigger.Setter(this, value); } }
        #line default
    
    #line hidden
    [_GEN1_][_GEN2_("Starcounter","2.0")]
    public static class Input {
        
        #line hidden
        public class Html : Input<__OfficeJs__, __TString__, string> {
        }
        #line default
        
        #line hidden
        public class Name : Input<__OfficeJs__, __TString__, string> {
        }
        #line default
        
        #line hidden
        public class NumberOfHomesSold : Input<__OfficeJs__, __TLong__, long> {
        }
        #line default
        
        #line hidden
        public class TotalCommission : Input<__OfficeJs__, __TLong__, long> {
        }
        #line default
        
        #line hidden
        public class AverageCommission : Input<__OfficeJs__, __TDecimal__, Decimal> {
        }
        #line default
        
        #line hidden
        public class Trend : Input<__OfficeJs__, __TLong__, long> {
        }
        #line default
        
        #line hidden
        public class OfficeEditLink : Input<__OfficeJs__, __TString__, string> {
        }
        #line default
        
        #line hidden
        public class Street : Input<__OfficeJs__, __TString__, string> {
        }
        #line default
        
        #line hidden
        public class Number : Input<__OfficeJs__, __TLong__, long> {
        }
        #line default
        
        #line hidden
        public class ZipCode : Input<__OfficeJs__, __TLong__, long> {
        }
        #line default
        
        #line hidden
        public class City : Input<__OfficeJs__, __TString__, string> {
        }
        #line default
        
        #line hidden
        public class Country : Input<__OfficeJs__, __TString__, string> {
        }
        #line default
        
        #line hidden
        public class FullAddress : Input<__OfficeJs__, __TString__, string> {
        }
        #line default
        
        #line hidden
        public class EditOfficeTrigger : Input<__OfficeJs__, __TLong__, long> {
        }
        #line default
    }
    #line default
}
#line default
}
#pragma warning restore 1591
#pragma warning restore 0108
