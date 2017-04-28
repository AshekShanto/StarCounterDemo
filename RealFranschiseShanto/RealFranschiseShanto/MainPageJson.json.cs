using Starcounter;
using System;

namespace RealFranschiseShanto
{
    partial class MainPageJson : Json
    {
        protected override void OnData()
        {
            base.OnData();
            refreshCompanyList();
        }
        void Handle(Input.AddCompanyTrigger inAction)
        {
            if(this.CompanyNameToCreate != "")
            {
                Db.Transact(() =>
                {
                    new Company()
                    {
                        Name = this.CompanyNameToCreate
                    };
                });
                this.CompanyNameToCreate = "";
            }
            refreshCompanyList();
        }

        void refreshCompanyList()
        {
            if(this.CompanyList != null)
            {
                this.CompanyList.Clear();
            }            
            var _companyList = Db.SQL<Company>("select c from RealFranschiseShanto.Company c");
            if (_companyList == null)
            {
                return;
            }
            foreach(Company _company in _companyList)
            {
                var _companyJson = new CompanyJson();
                _companyJson.Data = _company;
                this.CompanyList.Add(_companyJson);
            }
        }
    }
}
