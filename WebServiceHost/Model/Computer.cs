using System;

namespace WebServiceHost.Model
{
    /**
    * [Computers] must be like the stored procedures script for data [spAdd_New_Computer.sql] 
    */
    public class Computers
    {
        public int Id { get; set; }
        public string CompterName { get; set; }
        public string OperatingSystem { get; set; }
        public string CompanyFixedAsset { get; set; }
        public string TagService { get; set; }
        public string Location { get; set; }
        public string User { get; set; }
        public string Office { get; set; }
        public string IP { get; set; }
        public string ModelComputer { get; set; }
        public string CPU { get; set; }
        public string RAM { get; set; }
        public string HardDrive { get; set; }
        public string Coments { get; set; }
        public DateTime WarrantyDate { get; set; }
        public DateTime PurchaseDate { get; set; }
        public byte [] Barcode { get; set; }
        public byte[] QRCode { get; set; }
        public string EquipmentStatus { get; set; }



    }

}