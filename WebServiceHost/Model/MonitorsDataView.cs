using System;

namespace WebServiceHost.Model
{
    /**
    * [MonitorsDataView] must be like the view script for data [vwAll_Monitors] GetAllMonitors List Model
    */
    public class MonitorsDataView
    {
        public int IDEquipmentStatus { get; set; }
        public string EquipmentStatus { get; set; }
        public int Id { get; set; }
        public string TagService { get; set; }
        public DateTime WarrantyDate { get; set; }
        public DateTime PurchaseDate { get; set; }
        public string Barcode { get; set; }
        public string Coments { get; set; }
        public string CompanyFixedAsset { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Job { get; set; }
        public string LocationName { get; set; }
        public string ModelVersionMonitors { get; set; }

    }
}
//dbo.Monitors.IDEquipmentStatus                  ,
//dbo.EquipmentStatus.Status                      ,
//dbo.Monitors.Id                                 ,
//dbo.Monitors.TagService                         ,
//dbo.Monitors.WarrantyDate                       ,
//dbo.Monitors.PurchaseDate                       ,
//dbo.Monitors.Barcode                            ,
//dbo.Monitors.QRCode                             ,
//dbo.Monitors.Coments                            ,
//dbo.Monitors.CompanyFixedAsset                  ,
//dbo.Users.FirstName                             ,
//dbo.Users.LastName                              ,
//dbo.Users.Job                                   ,			
//dbo.Location.LocationName                       ,
//dbo.ModelMonitors.ModelVersionMonitors          