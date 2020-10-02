using System;

namespace WebServiceHost.Model
{
    /**
     * [ComputersDataView] must be like the view script for data [vwAll_Computers] GetAllComputers List Model
     */
    public class ComputersDataView
    {
        public int IDEquipmentStatus { get; set; }
        public string EquipmentStatus { get; set; }
        public int Id { get; set; }
        public string CompterName { get; set; }
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
        public string ModelVersionComputer { get; set; }
        public string OperatingSystemVersion { get; set; }
        public string RAMVersion { get; set; }

    }
}

//dbo.Computers.IDEquipmentStatus                   ,
//dbo.EquipmentStatus.Status                      ,
//dbo.Computers.Id                                ,
//dbo.Computers.CompterName                       ,
//dbo.Computers.TagService                        ,
//dbo.Computers.IP                                ,
//dbo.Computers.WarrantyDate                      ,
//dbo.Computers.PurchaseDate                      ,
//dbo.Computers.Barcode                           ,
//dbo.Computers.QRCode                            ,
//dbo.Computers.Coments                           ,
//dbo.Computers.CompanyFixedAsset                 ,
//dbo.Users.FirstName                             ,
//dbo.Users.LastName                              ,
//dbo.Users.Job                                   ,
//dbo.CPU.CPUVersion                              ,
//dbo.HardDrive.HardDriveVersion                  ,
//dbo.Location.LocationName                       ,
//dbo.MicrosoftOffice.MicrosoftOfficeVersion      ,
//dbo.ModelComputer.ModelVersionComputer          ,
//dbo.OperatingSystem.OperatingSystemVersion      ,
//dbo.RAM.RAMVersion                              