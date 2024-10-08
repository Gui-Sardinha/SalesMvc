﻿using SalesWebMvc1.Models.Enums;
using System;

namespace SalesWebMvc1.Models
{
    public class SalesRecord
    {
        public int Id { get; set; }
        public DateTime Date { get; set; }
        public double Amount { get; set; }
        public SaleStatus Status { get; set; }
        public Seller Seller { get; set; }

        public SalesRecord()
        {
        }

        public SalesRecord(int id, DateTime date, double amount,SaleStatus status, Seller seller)
        {
            Id = id;
            Date = date;
            Amount = amount;
            Seller = seller;
            Status = status;
        }
    }
}
