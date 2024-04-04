﻿using System;
using BillingSystemDataAccess;
using BillingSystemDataModel;

namespace BillingSystemDataAccessTest
{
    public class InstallmentDataAccessTest
    {
       public void TestAddInstallment(InstallmentDataAccess installmentDataAccess)
        {
            // Test adding a new installment

            Console.WriteLine("Testing AddInstallment:");

            // Create a new Installment object
            var newInstallment = new Installment
            {
                InstallmentId = 1,
                InstallmentSequenceNumber = 1,
                InstallmentSendDate = DateTime.Now,
                InstallmentDueDate = DateTime.Now.AddDays(30),
                DueAmount = 500.0,
                PaidAmount = null,
                BalanceAmount = null,
                InvoiceStatus = "Pending",
                InstallmentSummaryId = 8,
                // Set other properties as needed
            };

            // Add the new Installment
            installmentDataAccess.AddInstallment(newInstallment);
            Console.WriteLine("Installment added successfully.");
        }

       public void TestGetInstallmentById(InstallmentDataAccess installmentDataAccess)
        {
            // Test getting an installment by ID

            Console.WriteLine("\nTesting GetInstallmentById:");

            int installmentId = 12; // Assuming there's an installment with this ID in the database

            // Get the installment by ID
            var installment = installmentDataAccess.GetInstallmentById(installmentId);

            if (installment != null)
            {
                Console.WriteLine($"Installment found: Id = {installment.InstallmentId}, SequenceNumber = {installment.InstallmentSequenceNumber}");
                Console.WriteLine($"SendDate = {installment.InstallmentSendDate}, DueDate = {installment.InstallmentDueDate}");
                Console.WriteLine($"DueAmount = {installment.DueAmount}, PaidAmount = {installment.PaidAmount}, BalanceAmount = {installment.BalanceAmount}");
                Console.WriteLine($"InvoiceStatus = {installment.InvoiceStatus}");
            }
            else
            {
                Console.WriteLine("Installment not found.");
            }
        }

        public void TestUpdateInstallment(InstallmentDataAccess installmentDataAccess)
        {
            // Test updating an installment

            Console.WriteLine("\nTesting UpdateInstallment:");

            // Get an existing installment by Id
            int installmentId = 12; // Assuming there's an installment with this ID in the database
            var installment = installmentDataAccess.GetInstallmentById(installmentId);

            if (installment != null)
            {
                // Update installment properties
                installment.DueAmount = 600.0;
                installment.InvoiceStatus = "Paid";

                // Update the installment
                installmentDataAccess.UpdateInstallment(installment);
                Console.WriteLine("Installment updated successfully.");
            }
            else
            {
                Console.WriteLine("Installment not found.");
            }
        }

        public void TestDeleteInstallment(InstallmentDataAccess installmentDataAccess)
        {
            // Test deleting an installment

            Console.WriteLine("\nTesting DeleteInstallment:");

            int installmentId = 1; // Assuming there's an installment with this ID in the database

            // Delete the installment
            installmentDataAccess.DeleteInstallmentById(installmentId);
            Console.WriteLine("Installment deleted successfully.");
        }
    }
}