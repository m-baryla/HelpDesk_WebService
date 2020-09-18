using System;

namespace WebServiceHost.Model
{
    /**
    * [Monitors] must be like the stored procedures script for data [spAdd_New_Monitors.sql]
    */
    public class Monitors
    {
        public int Id { get; set; }
        public string CompanyFixedAsset { get; set; }
        public string TagService { get; set; }
        public string Location { get; set; }
        public string User { get; set; }
        public string ModelMonitors { get; set; }
        public string Coments { get; set; }
        public DateTime WarrantyDate { get; set; }
        public DateTime PurchaseDate { get; set; }
        public byte[] Barcode { get; set; }
        public byte[] QRCode { get; set; }

    }
}