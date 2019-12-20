#region Copyright Syncfusion Inc. 2001-2019.
// Copyright Syncfusion Inc. 2001-2019. All rights reserved.
// Use of this code is subject to the terms of our license.
// A copy of the current license can be obtained at any time by e-mailing
// licensing@syncfusion.com. Any infringement will be prosecuted under
// applicable laws. 
#endregion
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ScatterDataEditing
{
    public class Model
    {
        private DateTime month;

        public DateTime Month
        {
            get { return month; }
            set { month = value; }
        }
        
        private double saleCount;

        public double SaleCount
        {
            get { return saleCount; }
            set { saleCount = value; }
        }

        public Model(DateTime actualMonth, double actualSaleCount)
        {
            month = actualMonth;
            saleCount = actualSaleCount;
        }
    }
}
