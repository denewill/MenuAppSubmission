using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    public class Report
    {
        //SINGLETON CLASS
        private static Report instance = null;
        private static readonly object padlock = new object();
        private List<SaleInvoice> _sales;

        Report()
        {
            _sales = new List<SaleInvoice>();
        }

        public static Report GetReport
        {
            get
            {
                lock (padlock)
                {
                    if (instance == null)
                    {
                        instance = new Report();
                    }
                    return instance;
                }
            }
        }


        //CREATE INVENTORY WITH SALEINVOICES
        public void AddSalesInvoice(SaleInvoice sale)
        {
            _sales.Add(sale);
        }
        
        public void DeleteInvoice(int InvoiceID)
        {
            if (_sales.Contains(GetInvoice(InvoiceID)))
            {
                _sales.Remove(GetInvoice(InvoiceID));
            }
        }

        public SaleInvoice GetInvoice(int InvoiceID)
        {
            if (_sales.Count != 0)
            {
                foreach (SaleInvoice sale in _sales)
                {
                    if (sale.AreYou(InvoiceID))
                    {
                        return sale;
                    }
                    return null;
                }
            }            
            return null;
        }

        public int NumberOfInvoices()
        {
            return _sales.Count;
        }

        public string ReportSales()
        {
            string text = String.Empty;
            if (_sales.Count != 0)
            {
                text = "\n SALES REPORT"
                + "\n ==============================================================";
                foreach (SaleInvoice invoice in _sales)
                {
                    text = text + invoice.PrintInvoice();
                }
            }
            else
            {
                text = "There are no invoices to be reported. \n";
            }
            
            return text;
        }
    }
}
