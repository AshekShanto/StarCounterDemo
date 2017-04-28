using Starcounter;
using System;

namespace RealFranschiseShanto
{
    partial class CompanyJson : Json, IBound<Company>
    {
        enum sortingType
        {
            None,
            ByNumberOfHomes,
            ByTotalComission,
            ByAverageCommission,
            ByTrend
        }

        sortingType mSortingType = sortingType.None;
        protected override void OnData()
        {
            base.OnData();
            refreshOfficeList();
        }
        void Handle(Input.AddOfficeTrigger inAction)
        {
            if (this.OfficeNameToCreate != "")
            {
                Db.Transact(() =>
                {
                    new Office()
                    {
                        Name = this.OfficeNameToCreate,
                        Company = this.Data
                    };
                });
                refreshOfficeList();
                this.OfficeNameToCreate = "";
            }
        }

        void refreshOfficeList()
        {
            if(this.OfficeList != null)
            {
                this.OfficeList.Clear();
            }

            QueryResultRows<Office> _offices;
            switch(mSortingType)
            {
                case sortingType.ByAverageCommission:
                    _offices = Db.SQL<Office>("select o from RealFranschiseShanto.Office o where o.Company = ? ORDER BY o.AverageCommission", this.Data);
                    break;
                case sortingType.ByNumberOfHomes:
                    _offices = Db.SQL<Office>("select o from RealFranschiseShanto.Office o where o.Company = ? ORDER BY o.NumberOfHomesSold", this.Data);
                    break;
                case sortingType.ByTotalComission:
                    _offices = Db.SQL<Office>("select o from RealFranschiseShanto.Office o where o.Company = ? ORDER BY o.TotalCommission", this.Data);
                    break;
                case sortingType.ByTrend:
                    _offices = Db.SQL<Office>("select o from RealFranschiseShanto.Office o where o.Company = ? ORDER BY o.Trend", this.Data);
                    break;
                default:
                    _offices = this.Data.OfficeList;
                    break;
            };

            if(_offices == null)
            {
                return;
            }
            foreach(var _office in _offices)
            {
                var _officeJson = new OfficeJson();
                _officeJson.Data = _office;
                this.OfficeList.Add(_officeJson);
            }
        }

        void Handle(Input.SortByAverageComissionTrigger inAction)
        {
            mSortingType = sortingType.ByAverageCommission;
            refreshOfficeList();
        }

        void Handle(Input.SortByNumberOfHomesTrigger inAction)
        {
            mSortingType = sortingType.ByNumberOfHomes;
            refreshOfficeList();
        }

        void Handle(Input.SortByTotalCommisionTrigger inAction)
        {
            mSortingType = sortingType.ByTotalComission;
            refreshOfficeList();
        }

        void Handle(Input.SortByTrendTrigger inAction)
        {
            mSortingType = sortingType.ByTrend;
            refreshOfficeList();
        }
    }
}
