using Starcounter;

namespace RealFranschiseShanto
{
    partial class MainPage2Json : Json, IBound<Office>
    {
        protected override void OnData()
        {
            base.OnData();
            refreshTransactionList();
        }
        void Handle(Input.SaveOfficeTrigger inAction)
        {
            Transaction.Commit();
        }

        void Handle(Input.RegisterTransactionTrigger inAction)
        {
            Db.Transact(() =>
            {
                new Transaction()
                {
                    Date=this.TDate,
                    SalesPrice = (int)this.TSalesPrice,
                    Commission = (int)this.TCommission,
                    Office = this.Data,
                    Street = this.TStreet,
                    Number = (int)this.TNumber,
                    ZipCode = (int)this.TZipCode,
                    City = this.TCity,
                    Country = this.TCountry
                };
            });
            refreshTransactionList();
        }

        void refreshTransactionList()
        {
            if(this.TransactionList != null)
            {
                this.TransactionList.Clear();
            }            
            var _transactionList = this.Data.TransactionList;

            if (_transactionList == null)
            {
                return;
            }

            foreach (RealFranschiseShanto.Transaction _transactionData in _transactionList)
            {
                var _transactionJson = new TransactionJson();
                _transactionJson.Data = _transactionData;
                this.TransactionList.Add(_transactionJson);
            }
        }
    }
}
;