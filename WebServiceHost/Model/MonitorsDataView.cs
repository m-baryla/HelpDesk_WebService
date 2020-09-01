using System;

namespace WebServiceHost.Model
{
    /**
    * [MonitorsDataView] must be like the view script for data [vwAll_Monitors] GetAllMonitors List Model
    */
    public class MonitorsDataView
    {
        public int Id { get; set; }
        public string TagService { get; set; }
        public DateTime PurchaseDate { get; set; }
        public DateTime WarrantyDate { get; set; }
        public string Barcode { get; set; }
        public string Coments { get; set; }
        public string CompanyFixedAsset { get; set; }
        public string FirstName { get; set; }
        public string LocationName { get; set; }
        public string ModelVersionMonitors { get; set; }

    }
}
