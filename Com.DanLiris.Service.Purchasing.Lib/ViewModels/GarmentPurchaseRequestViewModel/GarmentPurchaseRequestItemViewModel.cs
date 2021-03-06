﻿using Com.DanLiris.Service.Purchasing.Lib.Utilities;
using Com.DanLiris.Service.Purchasing.Lib.ViewModels.NewIntegrationViewModel;
using System;
using System.Collections.Generic;
using System.Text;

namespace Com.DanLiris.Service.Purchasing.Lib.ViewModels.GarmentPurchaseRequestViewModel
{
    public class GarmentPurchaseRequestItemViewModel : BaseViewModel
    {
        public string PO_SerialNumber { get; set; }

        public ProductViewModel Product { get; set; }

        public double Quantity { get; set; }
        public double BudgetPrice { get; set; }

        public UomViewModel Uom { get; set; }

        public CategoryViewModel Category { get; set; }

        public string ProductRemark { get; set; }

        public string Status { get; set; }

        public bool IsUsed { get; set; }
    }
}
