// This is a system generated file (G2). It reflects the Starcounter App Template defined in the file "TransactionJson.json"
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
using __TrDate__ = global::RealFranschiseShanto.TransactionJson.Input.Date;
using _ScTemplate_ = Starcounter.Templates.Template;
using st = Starcounter.Templates;
using s = Starcounter;
using __TrFullAddr__ = global::RealFranschiseShanto.TransactionJson.Input.FullAddress;
using __TrCountry__ = global::RealFranschiseShanto.TransactionJson.Input.Country;
using __TrCity__ = global::RealFranschiseShanto.TransactionJson.Input.City;
using __TrZipCode__ = global::RealFranschiseShanto.TransactionJson.Input.ZipCode;
using __TrNumber__ = global::RealFranschiseShanto.TransactionJson.Input.Number;
using __TrStreet__ = global::RealFranschiseShanto.TransactionJson.Input.Street;
using __TrCommissi__ = global::RealFranschiseShanto.TransactionJson.Input.Commission;
using __TrSalesPri__ = global::RealFranschiseShanto.TransactionJson.Input.SalesPrice;
using _GEN2_ = System.CodeDom.Compiler.GeneratedCodeAttribute;
using __TrHtml__ = global::RealFranschiseShanto.TransactionJson.Input.Html;
using __Transact2__ = global::RealFranschiseShanto.TransactionJson.Input;
using __Transact1__ = global::RealFranschiseShanto.TransactionJson.JsonByExample;
using __TLong__ = global::Starcounter.Templates.TLong;
using __TString__ = global::Starcounter.Templates.TString;
using __TrSchema__ = global::RealFranschiseShanto.TransactionJson.JsonByExample.Schema;
using __Json1__ = global::Starcounter.Json.JsonByExample;
using __TObject__ = global::Starcounter.Templates.TObject;
using __Json__ = global::Starcounter.Json;
using __Transact__ = global::RealFranschiseShanto.TransactionJson;
using _GEN1_ = System.Diagnostics.DebuggerNonUserCodeAttribute;

#line hidden
[_GEN1_][_GEN2_("Starcounter","2.0")]
public class TransactionJson_json : s::TemplateAttribute {
}
#line default

#line hidden
public partial class TransactionJson : __Json__ {
    #line hidden
    [_GEN2_("Starcounter","2.0")]
    public static __TrSchema__ DefaultTemplate = new __TrSchema__();
    [_GEN1_][_GEN2_("Starcounter","2.0")]
    public TransactionJson() { }
    [_GEN1_][_GEN2_("Starcounter","2.0")]
    public TransactionJson(__TrSchema__ template) { Template = template; }
    [_GEN1_][_GEN2_("Starcounter","2.0")]
    protected override _ScTemplate_ GetDefaultTemplate() { return DefaultTemplate; }
    [_GEN1_][_GEN2_("Starcounter","2.0")]
    public new __TrSchema__ Template { get { return (__TrSchema__)base.Template; } set { base.Template = value; } }
    public override bool IsCodegenerated { get { return true; } }
    #line default
    
    #line hidden
    [_GEN1_][_GEN2_("Starcounter","2.0")]
    public static class JsonByExample {
        
        #line hidden
        public class Schema : __TObject__ {
            public Schema()
                : base() {
                InstanceType = typeof(__Transact__);
                Properties.ClearExposed();
                Html = Add<__TString__>("Html");
                Html.DefaultValue = "/RealFranschiseShanto/TransactionView.html";
                Html.SetCustomAccessors((_p_) => { return ((__Transact__)_p_).__bf__Html__; }, (_p_, _v_) => { ((__Transact__)_p_).__bf__Html__ = (System.String)_v_; }, false);
                Date = Add<__TString__>("Date");
                Date.DefaultValue = "";
                Date.SetCustomAccessors((_p_) => { return ((__Transact__)_p_).__bf__Date__; }, (_p_, _v_) => { ((__Transact__)_p_).__bf__Date__ = (System.String)_v_; }, false);
                SalesPrice = Add<__TLong__>("SalesPrice");
                SalesPrice.DefaultValue = 0L;
                SalesPrice.SetCustomAccessors((_p_) => { return ((__Transact__)_p_).__bf__SalesPrice__; }, (_p_, _v_) => { ((__Transact__)_p_).__bf__SalesPrice__ = (System.Int64)_v_; }, false);
                Commission = Add<__TLong__>("Commission");
                Commission.DefaultValue = 0L;
                Commission.SetCustomAccessors((_p_) => { return ((__Transact__)_p_).__bf__Commission__; }, (_p_, _v_) => { ((__Transact__)_p_).__bf__Commission__ = (System.Int64)_v_; }, false);
                Office = Add<__TObject__>("Office");
                Office.SetCustomAccessors((_p_) => { return ((__Transact__)_p_).__bf__Office__; }, (_p_, _v_) => { ((__Transact__)_p_).__bf__Office__ = (__Json__)_v_; }, false);
                Street = Add<__TString__>("Street$");
                Street.DefaultValue = "";
                Street.Editable = true;
                Street.SetCustomAccessors((_p_) => { return ((__Transact__)_p_).__bf__Street__; }, (_p_, _v_) => { ((__Transact__)_p_).__bf__Street__ = (System.String)_v_; }, false);
                Number = Add<__TLong__>("Number$");
                Number.DefaultValue = 0L;
                Number.Editable = true;
                Number.SetCustomAccessors((_p_) => { return ((__Transact__)_p_).__bf__Number__; }, (_p_, _v_) => { ((__Transact__)_p_).__bf__Number__ = (System.Int64)_v_; }, false);
                ZipCode = Add<__TLong__>("ZipCode$");
                ZipCode.DefaultValue = 0L;
                ZipCode.Editable = true;
                ZipCode.SetCustomAccessors((_p_) => { return ((__Transact__)_p_).__bf__ZipCode__; }, (_p_, _v_) => { ((__Transact__)_p_).__bf__ZipCode__ = (System.Int64)_v_; }, false);
                City = Add<__TString__>("City$");
                City.DefaultValue = "";
                City.Editable = true;
                City.SetCustomAccessors((_p_) => { return ((__Transact__)_p_).__bf__City__; }, (_p_, _v_) => { ((__Transact__)_p_).__bf__City__ = (System.String)_v_; }, false);
                Country = Add<__TString__>("Country$");
                Country.DefaultValue = "";
                Country.Editable = true;
                Country.SetCustomAccessors((_p_) => { return ((__Transact__)_p_).__bf__Country__; }, (_p_, _v_) => { ((__Transact__)_p_).__bf__Country__ = (System.String)_v_; }, false);
                FullAddress = Add<__TString__>("FullAddress");
                FullAddress.DefaultValue = "";
                FullAddress.SetCustomAccessors((_p_) => { return ((__Transact__)_p_).__bf__FullAddress__; }, (_p_, _v_) => { ((__Transact__)_p_).__bf__FullAddress__ = (System.String)_v_; }, false);
            }
            public override object CreateInstance(s.Json parent) { return new __Transact__(this) { Parent = parent }; }
            public __TString__ Html;
            public __TString__ Date;
            public __TLong__ SalesPrice;
            public __TLong__ Commission;
            public __TObject__ Office;
            public __TString__ Street;
            public __TLong__ Number;
            public __TLong__ ZipCode;
            public __TString__ City;
            public __TString__ Country;
            public __TString__ FullAddress;
        }
        #line default
    }
    #line default
    #line hidden
    private System.String __bf__Html__;
    #line default
    [_GEN1_][_GEN2_("Starcounter","2.0")]
    public System.String Html {
    #line 2 "TransactionJson.json"
        get {
        #line hidden
            return Template.Html.Getter(this); }
        #line 2 "TransactionJson.json"
        set {
        #line hidden
            Template.Html.Setter(this, value); } }
        #line default
    #line hidden
    private System.String __bf__Date__;
    #line default
    [_GEN1_][_GEN2_("Starcounter","2.0")]
    public System.String Date {
    #line 3 "TransactionJson.json"
        get {
        #line hidden
            return Template.Date.Getter(this); }
        #line 3 "TransactionJson.json"
        set {
        #line hidden
            Template.Date.Setter(this, value); } }
        #line default
    #line hidden
    private System.Int64 __bf__SalesPrice__;
    #line default
    [_GEN1_][_GEN2_("Starcounter","2.0")]
    public System.Int64 SalesPrice {
    #line 4 "TransactionJson.json"
        get {
        #line hidden
            return Template.SalesPrice.Getter(this); }
        #line 4 "TransactionJson.json"
        set {
        #line hidden
            Template.SalesPrice.Setter(this, value); } }
        #line default
    #line hidden
    private System.Int64 __bf__Commission__;
    #line default
    [_GEN1_][_GEN2_("Starcounter","2.0")]
    public System.Int64 Commission {
    #line 5 "TransactionJson.json"
        get {
        #line hidden
            return Template.Commission.Getter(this); }
        #line 5 "TransactionJson.json"
        set {
        #line hidden
            Template.Commission.Setter(this, value); } }
        #line default
    #line hidden
    private __Json__ __bf__Office__;
    #line default
    [_GEN1_][_GEN2_("Starcounter","2.0")]
    public __Json__ Office {
    #line 6 "TransactionJson.json"
        get {
        #line hidden
            return (__Json__)Template.Office.Getter(this); }
        #line 6 "TransactionJson.json"
        set {
        #line hidden
            Template.Office.Setter(this, value); } }
        #line default
    #line hidden
    private System.String __bf__Street__;
    #line default
    [_GEN1_][_GEN2_("Starcounter","2.0")]
    public System.String Street {
    #line 7 "TransactionJson.json"
        get {
        #line hidden
            return Template.Street.Getter(this); }
        #line 7 "TransactionJson.json"
        set {
        #line hidden
            Template.Street.Setter(this, value); } }
        #line default
    #line hidden
    private System.Int64 __bf__Number__;
    #line default
    [_GEN1_][_GEN2_("Starcounter","2.0")]
    public System.Int64 Number {
    #line 8 "TransactionJson.json"
        get {
        #line hidden
            return Template.Number.Getter(this); }
        #line 8 "TransactionJson.json"
        set {
        #line hidden
            Template.Number.Setter(this, value); } }
        #line default
    #line hidden
    private System.Int64 __bf__ZipCode__;
    #line default
    [_GEN1_][_GEN2_("Starcounter","2.0")]
    public System.Int64 ZipCode {
    #line 9 "TransactionJson.json"
        get {
        #line hidden
            return Template.ZipCode.Getter(this); }
        #line 9 "TransactionJson.json"
        set {
        #line hidden
            Template.ZipCode.Setter(this, value); } }
        #line default
    #line hidden
    private System.String __bf__City__;
    #line default
    [_GEN1_][_GEN2_("Starcounter","2.0")]
    public System.String City {
    #line 10 "TransactionJson.json"
        get {
        #line hidden
            return Template.City.Getter(this); }
        #line 10 "TransactionJson.json"
        set {
        #line hidden
            Template.City.Setter(this, value); } }
        #line default
    #line hidden
    private System.String __bf__Country__;
    #line default
    [_GEN1_][_GEN2_("Starcounter","2.0")]
    public System.String Country {
    #line 11 "TransactionJson.json"
        get {
        #line hidden
            return Template.Country.Getter(this); }
        #line 11 "TransactionJson.json"
        set {
        #line hidden
            Template.Country.Setter(this, value); } }
        #line default
    #line hidden
    private System.String __bf__FullAddress__;
    #line default
    [_GEN1_][_GEN2_("Starcounter","2.0")]
    public System.String FullAddress {
    #line 12 "TransactionJson.json"
        get {
        #line hidden
            return Template.FullAddress.Getter(this); }
        #line 12 "TransactionJson.json"
        set {
        #line hidden
            Template.FullAddress.Setter(this, value); } }
        #line default
    
    #line hidden
    [_GEN1_][_GEN2_("Starcounter","2.0")]
    public static class Input {
        
        #line hidden
        public class Html : Input<__Transact__, __TString__, string> {
        }
        #line default
        
        #line hidden
        public class Date : Input<__Transact__, __TString__, string> {
        }
        #line default
        
        #line hidden
        public class SalesPrice : Input<__Transact__, __TLong__, long> {
        }
        #line default
        
        #line hidden
        public class Commission : Input<__Transact__, __TLong__, long> {
        }
        #line default
        
        #line hidden
        public class Street : Input<__Transact__, __TString__, string> {
        }
        #line default
        
        #line hidden
        public class Number : Input<__Transact__, __TLong__, long> {
        }
        #line default
        
        #line hidden
        public class ZipCode : Input<__Transact__, __TLong__, long> {
        }
        #line default
        
        #line hidden
        public class City : Input<__Transact__, __TString__, string> {
        }
        #line default
        
        #line hidden
        public class Country : Input<__Transact__, __TString__, string> {
        }
        #line default
        
        #line hidden
        public class FullAddress : Input<__Transact__, __TString__, string> {
        }
        #line default
    }
    #line default
}
#line default
}
#pragma warning restore 1591
#pragma warning restore 0108
