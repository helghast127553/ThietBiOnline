//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace ThietBiOnline.Models.EF
{
    using System;
    using System.Collections.Generic;
    
    public partial class Tablet
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Tablet()
        {
            this.ChiTietDonHangTablets = new HashSet<ChiTietDonHangTablet>();
        }
    
        public int ID { get; set; }
        public string TenSanPham { get; set; }
        public Nullable<int> GiaSanPham { get; set; }
        public Nullable<int> SoLuong { get; set; }
        public string HinhAnhSanPham { get; set; }
        public string MoTaSanPham { get; set; }
        public string IDLoaiSanPham { get; set; }
        public string ManHinh { get; set; }
        public string CameraTruoc { get; set; }
        public string CameraSau { get; set; }
        public string CPU { get; set; }
        public string GPU { get; set; }
        public string RAM { get; set; }
        public string BoNhoTrong { get; set; }
        public string Connection { get; set; }
        public string Pin { get; set; }
        public string HDH { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ChiTietDonHangTablet> ChiTietDonHangTablets { get; set; }
        public virtual LoaiSanPham LoaiSanPham { get; set; }
    }
}
