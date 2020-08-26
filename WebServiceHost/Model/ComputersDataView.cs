using System;

namespace WebServiceHost.Model
{
    /**
     * [ComputersDataView] must be like the view script for data [vwAll_Computers] GetAllComputers List Model
     */
    public class ComputersDataView
    {
        public int Id { get; set; }
        public string CompterName { get; set; }
        public string TagService { get; set; }
        public string IP { get; set; }
        public DateTime PurchaseDate { get; set; }
        public DateTime WarrantyDate { get; set; }
        public string Barcode { get; set; }
        public string Coments { get; set; }
        public string CompanyFixedAsset { get; set; }
        public string FirstName { get; set; }
        public string CPUVersion { get; set; }
        public string HardDriveVersion { get; set; }
        public string LocationName { get; set; }
        public string MicrosoftOfficeVersion { get; set; }
        public string ModelVersionComputer { get; set; }
        public string OperatingSystemVersion { get; set; }
        public string RAMVersion { get; set; }
    }
}
