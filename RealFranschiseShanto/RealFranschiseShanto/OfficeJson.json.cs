using Starcounter;
using System;
namespace RealFranschiseShanto
{
    partial class OfficeJson : Json, IBound<Office>
    {
        protected override void OnData()
        {
            base.OnData();
            this.OfficeEditLink = "/RealFranschiseShanto/partial/office/" + this.Data.GetObjectID();
        }
        void Handle(Input.EditOfficeTrigger inAction)
        {
            
        }
    }
}

