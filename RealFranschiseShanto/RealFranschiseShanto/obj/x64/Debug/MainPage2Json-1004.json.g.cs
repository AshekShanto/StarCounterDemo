// This is a system generated file (G2). It reflects the Starcounter App Template defined in the file "MainPage2Json.json"
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
using __MaStreet__ = global::RealFranschiseShanto.MainPage2Json.Input.Street;
using __MaCity__ = global::RealFranschiseShanto.MainPage2Json.Input.City;
using __MaCountry__ = global::RealFranschiseShanto.MainPage2Json.Input.Country;
using __MaFullAddr__ = global::RealFranschiseShanto.MainPage2Json.Input.FullAddress;
using __MaSaveOffi__ = global::RealFranschiseShanto.MainPage2Json.Input.SaveOfficeTrigger;
using __MaOfficeEd__ = global::RealFranschiseShanto.MainPage2Json.Input.OfficeEditLink;
using __MaTStreet__ = global::RealFranschiseShanto.MainPage2Json.Input.TStreet;
using __MaTNumber__ = global::RealFranschiseShanto.MainPage2Json.Input.TNumber;
using __MaTZipCode__ = global::RealFranschiseShanto.MainPage2Json.Input.TZipCode;
using __MaTCity__ = global::RealFranschiseShanto.MainPage2Json.Input.TCity;
using __MaTCountry__ = global::RealFranschiseShanto.MainPage2Json.Input.TCountry;
using __MaTDate__ = global::RealFranschiseShanto.MainPage2Json.Input.TDate;
using __MaTSalesPr__ = global::RealFranschiseShanto.MainPage2Json.Input.TSalesPrice;
using __MaTCommiss__ = global::RealFranschiseShanto.MainPage2Json.Input.TCommission;
using __MaRegister__ = global::RealFranschiseShanto.MainPage2Json.Input.RegisterTransactionTrigger;
using s = Starcounter;
using st = Starcounter.Templates;
using _ScTemplate_ = Starcounter.Templates.Template;
using __MaZipCode__ = global::RealFranschiseShanto.MainPage2Json.Input.ZipCode;
using __MaNumber__ = global::RealFranschiseShanto.MainPage2Json.Input.Number;
using _GEN2_ = System.CodeDom.Compiler.GeneratedCodeAttribute;
using __MaTrend__ = global::RealFranschiseShanto.MainPage2Json.Input.Trend;
using __MainPage__ = global::RealFranschiseShanto.MainPage2Json;
using __Json__ = global::Starcounter.Json;
using __TObject__ = global::Starcounter.Templates.TObject;
using __Json1__ = global::Starcounter.Json.JsonByExample;
using __MaSchema__ = global::RealFranschiseShanto.MainPage2Json.JsonByExample.Schema;
using __TString__ = global::Starcounter.Templates.TString;
using __TLong__ = global::Starcounter.Templates.TLong;
using _GEN1_ = System.Diagnostics.DebuggerNonUserCodeAttribute;
using __TDecimal__ = global::Starcounter.Templates.TDecimal;
using __MainPage1__ = global::RealFranschiseShanto.MainPage2Json.JsonByExample;
using __Arr__ = global::Starcounter.Arr<global::Starcounter.Json>;
using __MainPage2__ = global::RealFranschiseShanto.MainPage2Json.Input;
using __MaHtml__ = global::RealFranschiseShanto.MainPage2Json.Input.Html;
using __MaName__ = global::RealFranschiseShanto.MainPage2Json.Input.Name;
using __MaNumberOf__ = global::RealFranschiseShanto.MainPage2Json.Input.NumberOfHomesSold;
using __MaTotalCom__ = global::RealFranschiseShanto.MainPage2Json.Input.TotalCommission;
using __MaAverageC__ = global::RealFranschiseShanto.MainPage2Json.Input.AverageCommission;
using __TArray__ = global::Starcounter.Templates.TArray<global::Starcounter.Json>;

#line hidden
[_GEN1_][_GEN2_("Starcounter","2.0")]
public class MainPage2Json_json : s::TemplateAttribute {
}
#line default

#line hidden
public partial class MainPage2Json : __Json__ {
    #line hidden
    [_GEN2_("Starcounter","2.0")]
    public static __MaSchema__ DefaultTemplate = new __MaSchema__();
    [_GEN1_][_GEN2_("Starcounter","2.0")]
    public MainPage2Json() { }
    [_GEN1_][_GEN2_("Starcounter","2.0")]
    public MainPage2Json(__MaSchema__ template) { Template = template; }
    [_GEN1_][_GEN2_("Starcounter","2.0")]
    protected override _ScTemplate_ GetDefaultTemplate() { return DefaultTemplate; }
    [_GEN1_][_GEN2_("Starcounter","2.0")]
    public new __MaSchema__ Template { get { return (__MaSchema__)base.Template; } set { base.Template = value; } }
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
                InstanceType = typeof(__MainPage__);
                Properties.ClearExposed();
                Html = Add<__TString__>("Html");
                Html.DefaultValue = "/RealFranschiseShanto/MainPage2.html";
                Html.SetCustomAccessors((_p_) => { return ((__MainPage__)_p_).__bf__Html__; }, (_p_, _v_) => { ((__MainPage__)_p_).__bf__Html__ = (System.String)_v_; }, false);
                Name = Add<__TString__>("Name$");
                Name.DefaultValue = "";
                Name.Editable = true;
                Name.SetCustomAccessors((_p_) => { return ((__MainPage__)_p_).__bf__Name__; }, (_p_, _v_) => { ((__MainPage__)_p_).__bf__Name__ = (System.String)_v_; }, false);
                Company = Add<__TObject__>("Company");
                Company.SetCustomAccessors((_p_) => { return ((__MainPage__)_p_).__bf__Company__; }, (_p_, _v_) => { ((__MainPage__)_p_).__bf__Company__ = (__Json__)_v_; }, false);
                NumberOfHomesSold = Add<__TLong__>("NumberOfHomesSold");
                NumberOfHomesSold.DefaultValue = 0L;
                NumberOfHomesSold.SetCustomAccessors((_p_) => { return ((__MainPage__)_p_).__bf__NumberOfHomesSold__; }, (_p_, _v_) => { ((__MainPage__)_p_).__bf__NumberOfHomesSold__ = (System.Int64)_v_; }, false);
                TotalCommission = Add<__TLong__>("TotalCommission");
                TotalCommission.DefaultValue = 0L;
                TotalCommission.SetCustomAccessors((_p_) => { return ((__MainPage__)_p_).__bf__TotalCommission__; }, (_p_, _v_) => { ((__MainPage__)_p_).__bf__TotalCommission__ = (System.Int64)_v_; }, false);
                AverageCommission = Add<__TDecimal__>("AverageCommission");
                AverageCommission.DefaultValue = 0.0m;
                AverageCommission.SetCustomAccessors((_p_) => { return ((__MainPage__)_p_).__bf__AverageCommission__; }, (_p_, _v_) => { ((__MainPage__)_p_).__bf__AverageCommission__ = (System.Decimal)_v_; }, false);
                Trend = Add<__TLong__>("Trend");
                Trend.DefaultValue = 0L;
                Trend.SetCustomAccessors((_p_) => { return ((__MainPage__)_p_).__bf__Trend__; }, (_p_, _v_) => { ((__MainPage__)_p_).__bf__Trend__ = (System.Int64)_v_; }, false);
                Street = Add<__TString__>("Street$");
                Street.DefaultValue = "";
                Street.Editable = true;
                Street.SetCustomAccessors((_p_) => { return ((__MainPage__)_p_).__bf__Street__; }, (_p_, _v_) => { ((__MainPage__)_p_).__bf__Street__ = (System.String)_v_; }, false);
                Number = Add<__TLong__>("Number$");
                Number.DefaultValue = 0L;
                Number.Editable = true;
                Number.SetCustomAccessors((_p_) => { return ((__MainPage__)_p_).__bf__Number__; }, (_p_, _v_) => { ((__MainPage__)_p_).__bf__Number__ = (System.Int64)_v_; }, false);
                ZipCode = Add<__TLong__>("ZipCode$");
                ZipCode.DefaultValue = 0L;
                ZipCode.Editable = true;
                ZipCode.SetCustomAccessors((_p_) => { return ((__MainPage__)_p_).__bf__ZipCode__; }, (_p_, _v_) => { ((__MainPage__)_p_).__bf__ZipCode__ = (System.Int64)_v_; }, false);
                City = Add<__TString__>("City$");
                City.DefaultValue = "";
                City.Editable = true;
                City.SetCustomAccessors((_p_) => { return ((__MainPage__)_p_).__bf__City__; }, (_p_, _v_) => { ((__MainPage__)_p_).__bf__City__ = (System.String)_v_; }, false);
                Country = Add<__TString__>("Country$");
                Country.DefaultValue = "";
                Country.Editable = true;
                Country.SetCustomAccessors((_p_) => { return ((__MainPage__)_p_).__bf__Country__; }, (_p_, _v_) => { ((__MainPage__)_p_).__bf__Country__ = (System.String)_v_; }, false);
                FullAddress = Add<__TString__>("FullAddress");
                FullAddress.DefaultValue = "";
                FullAddress.SetCustomAccessors((_p_) => { return ((__MainPage__)_p_).__bf__FullAddress__; }, (_p_, _v_) => { ((__MainPage__)_p_).__bf__FullAddress__ = (System.String)_v_; }, false);
                SaveOfficeTrigger = Add<__TLong__>("SaveOfficeTrigger$");
                SaveOfficeTrigger.DefaultValue = 0L;
                SaveOfficeTrigger.Editable = true;
                SaveOfficeTrigger.SetCustomAccessors((_p_) => { return ((__MainPage__)_p_).__bf__SaveOfficeTrigger__; }, (_p_, _v_) => { ((__MainPage__)_p_).__bf__SaveOfficeTrigger__ = (System.Int64)_v_; }, false);
                SaveOfficeTrigger.AddHandler((Json pup, Property<Int64> prop, Int64 value) => { return (new Input.SaveOfficeTrigger() { App = (MainPage2Json)pup, Template = (TLong)prop, Value = value }); }, (Json pup, Starcounter.Input<Int64> input) => { ((MainPage2Json)pup).Handle((Input.SaveOfficeTrigger)input); });
                TransactionList = Add<__TArray__>("TransactionList");
                TransactionList.SetCustomAccessors((_p_) => { return ((__MainPage__)_p_).__bf__TransactionList__; }, (_p_, _v_) => { ((__MainPage__)_p_).__bf__TransactionList__ = (__Arr__)_v_; }, false);
                OfficeEditLink = Add<__TString__>("OfficeEditLink");
                OfficeEditLink.DefaultValue = "";
                OfficeEditLink.SetCustomAccessors((_p_) => { return ((__MainPage__)_p_).__bf__OfficeEditLink__; }, (_p_, _v_) => { ((__MainPage__)_p_).__bf__OfficeEditLink__ = (System.String)_v_; }, false);
                TStreet = Add<__TString__>("TStreet$");
                TStreet.DefaultValue = "";
                TStreet.Editable = true;
                TStreet.SetCustomAccessors((_p_) => { return ((__MainPage__)_p_).__bf__TStreet__; }, (_p_, _v_) => { ((__MainPage__)_p_).__bf__TStreet__ = (System.String)_v_; }, false);
                TNumber = Add<__TLong__>("TNumber$");
                TNumber.DefaultValue = 0L;
                TNumber.Editable = true;
                TNumber.SetCustomAccessors((_p_) => { return ((__MainPage__)_p_).__bf__TNumber__; }, (_p_, _v_) => { ((__MainPage__)_p_).__bf__TNumber__ = (System.Int64)_v_; }, false);
                TZipCode = Add<__TLong__>("TZipCode$");
                TZipCode.DefaultValue = 0L;
                TZipCode.Editable = true;
                TZipCode.SetCustomAccessors((_p_) => { return ((__MainPage__)_p_).__bf__TZipCode__; }, (_p_, _v_) => { ((__MainPage__)_p_).__bf__TZipCode__ = (System.Int64)_v_; }, false);
                TCity = Add<__TString__>("TCity$");
                TCity.DefaultValue = "";
                TCity.Editable = true;
                TCity.SetCustomAccessors((_p_) => { return ((__MainPage__)_p_).__bf__TCity__; }, (_p_, _v_) => { ((__MainPage__)_p_).__bf__TCity__ = (System.String)_v_; }, false);
                TCountry = Add<__TString__>("TCountry$");
                TCountry.DefaultValue = "";
                TCountry.Editable = true;
                TCountry.SetCustomAccessors((_p_) => { return ((__MainPage__)_p_).__bf__TCountry__; }, (_p_, _v_) => { ((__MainPage__)_p_).__bf__TCountry__ = (System.String)_v_; }, false);
                TDate = Add<__TString__>("TDate$");
                TDate.DefaultValue = "";
                TDate.Editable = true;
                TDate.SetCustomAccessors((_p_) => { return ((__MainPage__)_p_).__bf__TDate__; }, (_p_, _v_) => { ((__MainPage__)_p_).__bf__TDate__ = (System.String)_v_; }, false);
                TSalesPrice = Add<__TLong__>("TSalesPrice$");
                TSalesPrice.DefaultValue = 0L;
                TSalesPrice.Editable = true;
                TSalesPrice.SetCustomAccessors((_p_) => { return ((__MainPage__)_p_).__bf__TSalesPrice__; }, (_p_, _v_) => { ((__MainPage__)_p_).__bf__TSalesPrice__ = (System.Int64)_v_; }, false);
                TCommission = Add<__TLong__>("TCommission$");
                TCommission.DefaultValue = 0L;
                TCommission.Editable = true;
                TCommission.SetCustomAccessors((_p_) => { return ((__MainPage__)_p_).__bf__TCommission__; }, (_p_, _v_) => { ((__MainPage__)_p_).__bf__TCommission__ = (System.Int64)_v_; }, false);
                RegisterTransactionTrigger = Add<__TLong__>("RegisterTransactionTrigger$");
                RegisterTransactionTrigger.DefaultValue = 0L;
                RegisterTransactionTrigger.Editable = true;
                RegisterTransactionTrigger.SetCustomAccessors((_p_) => { return ((__MainPage__)_p_).__bf__RegisterTransactionTrigger__; }, (_p_, _v_) => { ((__MainPage__)_p_).__bf__RegisterTransactionTrigger__ = (System.Int64)_v_; }, false);
                RegisterTransactionTrigger.AddHandler((Json pup, Property<Int64> prop, Int64 value) => { return (new Input.RegisterTransactionTrigger() { App = (MainPage2Json)pup, Template = (TLong)prop, Value = value }); }, (Json pup, Starcounter.Input<Int64> input) => { ((MainPage2Json)pup).Handle((Input.RegisterTransactionTrigger)input); });
            }
            public override object CreateInstance(s.Json parent) { return new __MainPage__(this) { Parent = parent }; }
            public __TString__ Html;
            public __TString__ Name;
            public __TObject__ Company;
            public __TLong__ NumberOfHomesSold;
            public __TLong__ TotalCommission;
            public __TDecimal__ AverageCommission;
            public __TLong__ Trend;
            public __TString__ Street;
            public __TLong__ Number;
            public __TLong__ ZipCode;
            public __TString__ City;
            public __TString__ Country;
            public __TString__ FullAddress;
            public __TLong__ SaveOfficeTrigger;
            public __TArray__ TransactionList;
            public __TString__ OfficeEditLink;
            public __TString__ TStreet;
            public __TLong__ TNumber;
            public __TLong__ TZipCode;
            public __TString__ TCity;
            public __TString__ TCountry;
            public __TString__ TDate;
            public __TLong__ TSalesPrice;
            public __TLong__ TCommission;
            public __TLong__ RegisterTransactionTrigger;
        }
        #line default
    }
    #line default
    #line hidden
    private System.String __bf__Html__;
    #line default
    [_GEN1_][_GEN2_("Starcounter","2.0")]
    public System.String Html {
    #line 2 "MainPage2Json.json"
        get {
        #line hidden
            return Template.Html.Getter(this); }
        #line 2 "MainPage2Json.json"
        set {
        #line hidden
            Template.Html.Setter(this, value); } }
        #line default
    #line hidden
    private System.String __bf__Name__;
    #line default
    [_GEN1_][_GEN2_("Starcounter","2.0")]
    public System.String Name {
    #line 3 "MainPage2Json.json"
        get {
        #line hidden
            return Template.Name.Getter(this); }
        #line 3 "MainPage2Json.json"
        set {
        #line hidden
            Template.Name.Setter(this, value); } }
        #line default
    #line hidden
    private __Json__ __bf__Company__;
    #line default
    [_GEN1_][_GEN2_("Starcounter","2.0")]
    public __Json__ Company {
    #line 4 "MainPage2Json.json"
        get {
        #line hidden
            return (__Json__)Template.Company.Getter(this); }
        #line 4 "MainPage2Json.json"
        set {
        #line hidden
            Template.Company.Setter(this, value); } }
        #line default
    #line hidden
    private System.Int64 __bf__NumberOfHomesSold__;
    #line default
    [_GEN1_][_GEN2_("Starcounter","2.0")]
    public System.Int64 NumberOfHomesSold {
    #line 5 "MainPage2Json.json"
        get {
        #line hidden
            return Template.NumberOfHomesSold.Getter(this); }
        #line 5 "MainPage2Json.json"
        set {
        #line hidden
            Template.NumberOfHomesSold.Setter(this, value); } }
        #line default
    #line hidden
    private System.Int64 __bf__TotalCommission__;
    #line default
    [_GEN1_][_GEN2_("Starcounter","2.0")]
    public System.Int64 TotalCommission {
    #line 6 "MainPage2Json.json"
        get {
        #line hidden
            return Template.TotalCommission.Getter(this); }
        #line 6 "MainPage2Json.json"
        set {
        #line hidden
            Template.TotalCommission.Setter(this, value); } }
        #line default
    #line hidden
    private System.Decimal __bf__AverageCommission__;
    #line default
    [_GEN1_][_GEN2_("Starcounter","2.0")]
    public System.Decimal AverageCommission {
    #line 7 "MainPage2Json.json"
        get {
        #line hidden
            return Template.AverageCommission.Getter(this); }
        #line 7 "MainPage2Json.json"
        set {
        #line hidden
            Template.AverageCommission.Setter(this, value); } }
        #line default
    #line hidden
    private System.Int64 __bf__Trend__;
    #line default
    [_GEN1_][_GEN2_("Starcounter","2.0")]
    public System.Int64 Trend {
    #line 8 "MainPage2Json.json"
        get {
        #line hidden
            return Template.Trend.Getter(this); }
        #line 8 "MainPage2Json.json"
        set {
        #line hidden
            Template.Trend.Setter(this, value); } }
        #line default
    #line hidden
    private System.String __bf__Street__;
    #line default
    [_GEN1_][_GEN2_("Starcounter","2.0")]
    public System.String Street {
    #line 9 "MainPage2Json.json"
        get {
        #line hidden
            return Template.Street.Getter(this); }
        #line 9 "MainPage2Json.json"
        set {
        #line hidden
            Template.Street.Setter(this, value); } }
        #line default
    #line hidden
    private System.Int64 __bf__Number__;
    #line default
    [_GEN1_][_GEN2_("Starcounter","2.0")]
    public System.Int64 Number {
    #line 10 "MainPage2Json.json"
        get {
        #line hidden
            return Template.Number.Getter(this); }
        #line 10 "MainPage2Json.json"
        set {
        #line hidden
            Template.Number.Setter(this, value); } }
        #line default
    #line hidden
    private System.Int64 __bf__ZipCode__;
    #line default
    [_GEN1_][_GEN2_("Starcounter","2.0")]
    public System.Int64 ZipCode {
    #line 11 "MainPage2Json.json"
        get {
        #line hidden
            return Template.ZipCode.Getter(this); }
        #line 11 "MainPage2Json.json"
        set {
        #line hidden
            Template.ZipCode.Setter(this, value); } }
        #line default
    #line hidden
    private System.String __bf__City__;
    #line default
    [_GEN1_][_GEN2_("Starcounter","2.0")]
    public System.String City {
    #line 12 "MainPage2Json.json"
        get {
        #line hidden
            return Template.City.Getter(this); }
        #line 12 "MainPage2Json.json"
        set {
        #line hidden
            Template.City.Setter(this, value); } }
        #line default
    #line hidden
    private System.String __bf__Country__;
    #line default
    [_GEN1_][_GEN2_("Starcounter","2.0")]
    public System.String Country {
    #line 13 "MainPage2Json.json"
        get {
        #line hidden
            return Template.Country.Getter(this); }
        #line 13 "MainPage2Json.json"
        set {
        #line hidden
            Template.Country.Setter(this, value); } }
        #line default
    #line hidden
    private System.String __bf__FullAddress__;
    #line default
    [_GEN1_][_GEN2_("Starcounter","2.0")]
    public System.String FullAddress {
    #line 14 "MainPage2Json.json"
        get {
        #line hidden
            return Template.FullAddress.Getter(this); }
        #line 14 "MainPage2Json.json"
        set {
        #line hidden
            Template.FullAddress.Setter(this, value); } }
        #line default
    #line hidden
    private System.Int64 __bf__SaveOfficeTrigger__;
    #line default
    [_GEN1_][_GEN2_("Starcounter","2.0")]
    public System.Int64 SaveOfficeTrigger {
    #line 15 "MainPage2Json.json"
        get {
        #line hidden
            return Template.SaveOfficeTrigger.Getter(this); }
        #line 15 "MainPage2Json.json"
        set {
        #line hidden
            Template.SaveOfficeTrigger.Setter(this, value); } }
        #line default
    #line hidden
    private __Arr__ __bf__TransactionList__;
    #line default
    [_GEN1_][_GEN2_("Starcounter","2.0")]
    public __Arr__ TransactionList {
    #line 16 "MainPage2Json.json"
        get {
        #line hidden
            return Template.TransactionList.Getter(this); }
        #line 16 "MainPage2Json.json"
        set {
        #line hidden
            Template.TransactionList.Setter(this, value); } }
        #line default
    #line hidden
    private System.String __bf__OfficeEditLink__;
    #line default
    [_GEN1_][_GEN2_("Starcounter","2.0")]
    public System.String OfficeEditLink {
    #line 17 "MainPage2Json.json"
        get {
        #line hidden
            return Template.OfficeEditLink.Getter(this); }
        #line 17 "MainPage2Json.json"
        set {
        #line hidden
            Template.OfficeEditLink.Setter(this, value); } }
        #line default
    #line hidden
    private System.String __bf__TStreet__;
    #line default
    [_GEN1_][_GEN2_("Starcounter","2.0")]
    public System.String TStreet {
    #line 19 "MainPage2Json.json"
        get {
        #line hidden
            return Template.TStreet.Getter(this); }
        #line 19 "MainPage2Json.json"
        set {
        #line hidden
            Template.TStreet.Setter(this, value); } }
        #line default
    #line hidden
    private System.Int64 __bf__TNumber__;
    #line default
    [_GEN1_][_GEN2_("Starcounter","2.0")]
    public System.Int64 TNumber {
    #line 20 "MainPage2Json.json"
        get {
        #line hidden
            return Template.TNumber.Getter(this); }
        #line 20 "MainPage2Json.json"
        set {
        #line hidden
            Template.TNumber.Setter(this, value); } }
        #line default
    #line hidden
    private System.Int64 __bf__TZipCode__;
    #line default
    [_GEN1_][_GEN2_("Starcounter","2.0")]
    public System.Int64 TZipCode {
    #line 21 "MainPage2Json.json"
        get {
        #line hidden
            return Template.TZipCode.Getter(this); }
        #line 21 "MainPage2Json.json"
        set {
        #line hidden
            Template.TZipCode.Setter(this, value); } }
        #line default
    #line hidden
    private System.String __bf__TCity__;
    #line default
    [_GEN1_][_GEN2_("Starcounter","2.0")]
    public System.String TCity {
    #line 22 "MainPage2Json.json"
        get {
        #line hidden
            return Template.TCity.Getter(this); }
        #line 22 "MainPage2Json.json"
        set {
        #line hidden
            Template.TCity.Setter(this, value); } }
        #line default
    #line hidden
    private System.String __bf__TCountry__;
    #line default
    [_GEN1_][_GEN2_("Starcounter","2.0")]
    public System.String TCountry {
    #line 23 "MainPage2Json.json"
        get {
        #line hidden
            return Template.TCountry.Getter(this); }
        #line 23 "MainPage2Json.json"
        set {
        #line hidden
            Template.TCountry.Setter(this, value); } }
        #line default
    #line hidden
    private System.String __bf__TDate__;
    #line default
    [_GEN1_][_GEN2_("Starcounter","2.0")]
    public System.String TDate {
    #line 24 "MainPage2Json.json"
        get {
        #line hidden
            return Template.TDate.Getter(this); }
        #line 24 "MainPage2Json.json"
        set {
        #line hidden
            Template.TDate.Setter(this, value); } }
        #line default
    #line hidden
    private System.Int64 __bf__TSalesPrice__;
    #line default
    [_GEN1_][_GEN2_("Starcounter","2.0")]
    public System.Int64 TSalesPrice {
    #line 25 "MainPage2Json.json"
        get {
        #line hidden
            return Template.TSalesPrice.Getter(this); }
        #line 25 "MainPage2Json.json"
        set {
        #line hidden
            Template.TSalesPrice.Setter(this, value); } }
        #line default
    #line hidden
    private System.Int64 __bf__TCommission__;
    #line default
    [_GEN1_][_GEN2_("Starcounter","2.0")]
    public System.Int64 TCommission {
    #line 26 "MainPage2Json.json"
        get {
        #line hidden
            return Template.TCommission.Getter(this); }
        #line 26 "MainPage2Json.json"
        set {
        #line hidden
            Template.TCommission.Setter(this, value); } }
        #line default
    #line hidden
    private System.Int64 __bf__RegisterTransactionTrigger__;
    #line default
    [_GEN1_][_GEN2_("Starcounter","2.0")]
    public System.Int64 RegisterTransactionTrigger {
    #line 27 "MainPage2Json.json"
        get {
        #line hidden
            return Template.RegisterTransactionTrigger.Getter(this); }
        #line 27 "MainPage2Json.json"
        set {
        #line hidden
            Template.RegisterTransactionTrigger.Setter(this, value); } }
        #line default
    
    #line hidden
    [_GEN1_][_GEN2_("Starcounter","2.0")]
    public static class Input {
        
        #line hidden
        public class Html : Input<__MainPage__, __TString__, string> {
        }
        #line default
        
        #line hidden
        public class Name : Input<__MainPage__, __TString__, string> {
        }
        #line default
        
        #line hidden
        public class NumberOfHomesSold : Input<__MainPage__, __TLong__, long> {
        }
        #line default
        
        #line hidden
        public class TotalCommission : Input<__MainPage__, __TLong__, long> {
        }
        #line default
        
        #line hidden
        public class AverageCommission : Input<__MainPage__, __TDecimal__, Decimal> {
        }
        #line default
        
        #line hidden
        public class Trend : Input<__MainPage__, __TLong__, long> {
        }
        #line default
        
        #line hidden
        public class Street : Input<__MainPage__, __TString__, string> {
        }
        #line default
        
        #line hidden
        public class Number : Input<__MainPage__, __TLong__, long> {
        }
        #line default
        
        #line hidden
        public class ZipCode : Input<__MainPage__, __TLong__, long> {
        }
        #line default
        
        #line hidden
        public class City : Input<__MainPage__, __TString__, string> {
        }
        #line default
        
        #line hidden
        public class Country : Input<__MainPage__, __TString__, string> {
        }
        #line default
        
        #line hidden
        public class FullAddress : Input<__MainPage__, __TString__, string> {
        }
        #line default
        
        #line hidden
        public class SaveOfficeTrigger : Input<__MainPage__, __TLong__, long> {
        }
        #line default
        
        #line hidden
        public class OfficeEditLink : Input<__MainPage__, __TString__, string> {
        }
        #line default
        
        #line hidden
        public class TStreet : Input<__MainPage__, __TString__, string> {
        }
        #line default
        
        #line hidden
        public class TNumber : Input<__MainPage__, __TLong__, long> {
        }
        #line default
        
        #line hidden
        public class TZipCode : Input<__MainPage__, __TLong__, long> {
        }
        #line default
        
        #line hidden
        public class TCity : Input<__MainPage__, __TString__, string> {
        }
        #line default
        
        #line hidden
        public class TCountry : Input<__MainPage__, __TString__, string> {
        }
        #line default
        
        #line hidden
        public class TDate : Input<__MainPage__, __TString__, string> {
        }
        #line default
        
        #line hidden
        public class TSalesPrice : Input<__MainPage__, __TLong__, long> {
        }
        #line default
        
        #line hidden
        public class TCommission : Input<__MainPage__, __TLong__, long> {
        }
        #line default
        
        #line hidden
        public class RegisterTransactionTrigger : Input<__MainPage__, __TLong__, long> {
        }
        #line default
    }
    #line default
}
#line default
}
#pragma warning restore 1591
#pragma warning restore 0108
