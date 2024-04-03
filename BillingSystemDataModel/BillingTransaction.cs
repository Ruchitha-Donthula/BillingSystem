//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace BillingSystemDataModel
{
    using System;
    using System.Collections.Generic;
    
    public partial class BillingTransaction
    {
        public int Id { get; set; }
        public int BillingTransactionId { get; set; }
        public System.DateTime ActivityDate { get; set; }
        public string TransactionType { get; set; }
        public Nullable<double> TransactionAmount { get; set; }
        public Nullable<int> InvoiceId { get; set; }
        public Nullable<int> PaymentId { get; set; }
        public int BillAccountId { get; set; }
    
        public virtual BillAccount BillAccount { get; set; }
    }
}