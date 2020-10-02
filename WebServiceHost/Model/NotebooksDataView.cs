using System;

namespace WebServiceHost.Model
{
    /**
    * [NotebooksDataView] must be like the view script for data [vwAll_Notebooks] GetAllNotebooks List Model
    */

    public class NotebooksDataView
    {
        public int IDEquipmentStatus { get; set; }
        public string EquipmentStatus { get; set; }
        public int Id { get; set; }
        public string NotebooksName { get; set; }
        public string TagService { get; set; }
        public string IP { get; set; }
        public DateTime WarrantyDate { get; set; }
        public DateTime PurchaseDate { get; set; }
        public byte[] Barcode { get; set; }
        public byte[] QRCode { get; set; }
        public string Coments { get; set; }
        public string CompanyFixedAsset { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Job { get; set; }
        public string CPUVersion { get; set; }
        public string HardDriveVersion { get; set; }
        public string LocationName { get; set; }
        public string MicrosoftOfficeVersion { get; set; }
        public string ModelVersionNotebooks { get; set; }
        public string OperatingSystemVersion { get; set; }
        public string RAMVersion { get; set; }

    }
}

//dbo.Notebooks.IDEquipmentStatus                 ,
//dbo.EquipmentStatus.Status                      ,
//dbo.Notebooks.Id                                ,
//dbo.Notebooks.NotebooksName                     ,
//dbo.Notebooks.TagService                        ,
//dbo.Notebooks.IP                                ,
//dbo.Notebooks.WarrantyDate                      ,
//dbo.Notebooks.PurchaseDate                      ,
//dbo.Notebooks.Barcode                           ,
//dbo.Notebooks.QRCode                            ,
//dbo.Notebooks.Coments                           ,
//dbo.Notebooks.CompanyFixedAsset                 ,
//dbo.Users.FirstName                             ,
//dbo.Users.LastName                              ,
//dbo.Users.Job                                   ,				
//dbo.CPU.CPUVersion                              ,
//dbo.HardDrive.HardDriveVersion                  ,
//dbo.Location.LocationName                       ,
//dbo.MicrosoftOffice.MicrosoftOfficeVersion      ,
//dbo.ModelNotebooks.ModelVersionNotebooks        ,
//dbo.OperatingSystem.OperatingSystemVersion      ,
//dbo.RAM.RAMVersion                              