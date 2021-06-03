using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    public class Item
    {
        private int _ItemID;
        private string _ItemName;
        private string _ItemDetail;
        private double _ItemPrice;

        public Item (int ItemID, string ItemName, string ItemDetail, double ItemPrice)
        {
            _ItemID = ItemID;
            _ItemName = ItemName;
            _ItemDetail = ItemDetail;
            _ItemPrice = ItemPrice;
        }

        //GET SET METHODS FOR CLASS KNOWLEDGE
        public int GetItemID
        {
            get { return _ItemID; }
            set { _ItemID = value; }
        }

        public string GetItemName
        {
            get { return _ItemName; }
            set { _ItemName = value; }
        }

        public string GetItemDetail
        {
            get { return _ItemDetail; }
            set { _ItemDetail = value; }
        }

        public double GetItemPrice
        {
            get { return _ItemPrice; }
            set { _ItemPrice = value; }
        }

        public bool AreYou(int ItemID)
        {
            return (_ItemID == ItemID);
        }
    }
}
