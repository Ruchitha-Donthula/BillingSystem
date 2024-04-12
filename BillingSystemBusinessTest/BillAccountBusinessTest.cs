﻿using System;
using System.Collections.Generic;
using BillingSystemDataModel;
using BillingSystemBusiness;

namespace BillingSystemBusinessTest
{
    class BillAccountBusinessTest
    {
        public void TestCreateBillAccount()
        {
            Console.WriteLine("Testing AddBillAccount:");
            var newBillAccount = new BillAccount
            {
                BillingType = "Agent",
                Status = "Active",
                PayorName = "Mahalaxmi",
                PayorAddress = "Ramnagar",
                PaymentMethod = "Credit Card",
                DueDay = 21,
                AccountTotal = 0.0,
                AccountPaid = 0.0,
                AccountBalance = 0.0,
                LastPaymentDate = null,
                LastPaymentAmount = 0.0,
                PastDue = 0.0,
                FutureDue = 0.0
            };
            new BillAccountBusiness().CreateBillAccount(newBillAccount);
            Console.WriteLine("BillAccount added successfully.");
        }

        public void TestAssociateBillAccountWithPolicy()
        {
            var billAccount = new BillAccount
            {
                BillAccountId = 9,
            };
            List<string> policyNumbers = new List<string> { "POL123" };
            string payplan = "Monthly";
            new BillAccountBusiness().AssociateBillAccountWithPolicy(billAccount, policyNumbers, payplan);
            Console.WriteLine("BillAccountPolicies added successfully.");

        }

        public void TestGetBillAccountById()
        {
            BillAccount billAccount = new BillAccountBusiness().GetBillAccountById(5);
            Console.WriteLine(billAccount.BillAccountId + " " + billAccount.BillAccountNumber + " " + billAccount.PayorName);
        }

        public void TestGetBillAccountByNumber()
        {
            BillAccount billAccount = new BillAccountBusiness().GetBillAccountByNumber("BA000001");
            Console.WriteLine(billAccount.BillAccountId + " " + billAccount.BillAccountNumber + " " + billAccount.PayorName);
        }

        public void TestUpdateBillAccount()
        {
            var billAccount = new BillAccount
            {
                BillAccountNumber = "BA123457",
            };
            new BillAccountBusiness().UpdateBillAccount(billAccount);
            Console.WriteLine("BillAccount updated Successfully");
        }

        public void TestSuspendBillAccount()
        {
            var billAccount = new BillAccount
            {
                BillAccountId = 7,
            };
            new BillAccountBusiness().SuspendBillAccount(billAccount);
            Console.WriteLine("BillAccount suspended Successfully");
        }

        public void TestReleaseBillAccount()
        {
            var billAccount = new BillAccount
            {
                BillAccountId = 7,
            };
            new BillAccountBusiness().ReleaseBillAccount(billAccount);
            Console.WriteLine("BillAccount released Successfully");
        }
    }
}
