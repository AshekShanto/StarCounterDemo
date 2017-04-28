using System;
using Starcounter;

namespace RealFranschiseShanto
{
    [Database]
    public class Company
    {
        public string Name;
        public QueryResultRows<Office> OfficeList => Db.SQL<Office>(
            "select o from RealFranschiseShanto.Office o where o.Company = ?", this);
    }

    [Database]
    public class Office : Address
    {
        public string Name;
        public Company Company;

        public int NumberOfHomesSold
        {
            get
            {
                if(TransactionList == null) { return 0; }
                int _count = 0;
                foreach (var _transaction in TransactionList)
                {
                    ++_count;
                }
                return _count;
            }
        }

         public int TotalCommission
         {
             get
             {
                 if (TransactionList == null) { return 0; }
                 int _totalCommission = 0;
                 foreach (var _transaction in TransactionList)
                 {
                     _totalCommission += _transaction.Commission;
                 }
                 return _totalCommission;
             }
         }

        public double AverageCommission
        {
            get
            {
                if (TransactionList == null) { return 0.0; }
                int _totalCommission = 0, _commissionCount = 0;
                foreach (var _transaction in TransactionList)
                {
                    _totalCommission += _transaction.Commission;
                    ++_commissionCount;
                }
                if(_commissionCount == 0)
                {
                    return 0.0;
                }
                else
                {
                    return _totalCommission / (double)_commissionCount;
                }
            }
        }

        public int Trend
        {
            get
            {
                // need better function for positive trend
                return (int)(NumberOfHomesSold * AverageCommission);
            }
        }
      
        public QueryResultRows<Transaction> TransactionList => Db.SQL<Transaction>(
            "select t from RealFranschiseShanto.Transaction t where t.Office = ?", this);
    }

    [Database]
    public class Transaction : Address
    {
        public String Date;
        public int SalesPrice;
        public int Commission;
        public Office Office;
    }

    [Database]
    public class Address 
    {
        public string Street;
        public int Number;
        public int ZipCode;
        public string City;
        public string Country;
        public string FullAddress =>
            Street + "" + Number + "," + ZipCode + " " + City + "," + Country;
    }
    
    
    class Program
    {
        static void Main()
        {
            Application.Current.Use(new HtmlFromJsonProvider());
            Application.Current.Use(new PartialToStandaloneHtmlProvider());

            Starcounter.Handle.GET("/RealFranschiseShanto", () =>
            {
                return Db.Scope(() =>
                {
                    var _mainPageJson = new MainPageJson();
                    Db.Transact(() =>
                    {
                        _mainPageJson.Data = null;
                    });

                    if (Session.Current == null)
                    {
                        Session.Current = new Session(SessionOptions.PatchVersioning);
                    }
                    _mainPageJson.Session = Session.Current;
                    return _mainPageJson;
                });
            });

            Starcounter.Handle.GET("/RealFranschiseShanto/partial/office/{?}", 
                (string inOfficeId) =>
            {
                return Db.Scope(() =>
                {
                    var _mainPage2Json = new MainPage2Json();
                    if (Session.Current == null)
                    {
                        Session.Current = new Session(SessionOptions.PatchVersioning);
                    }
                    _mainPage2Json.Session = Session.Current;

                    var _office = (Office)DbHelper.FromID(DbHelper.Base64DecodeObjectID(inOfficeId));
                    _mainPage2Json.Data = _office;
                    return _mainPage2Json;
                });
            });
        }
    }
}