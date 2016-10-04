using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Frontend_SercuIntegraded.Models
{
    public class TblPrivateNew
    {
        public int TblPrivateNewId { get; set; } // Id (Primary key)
        public string Title { get; set; } // Title (length: 1000)
        public string NewsContent { get; set; } // NewsContent
        public string Address { get; set; } // Address (length: 1000)
        public string Dientich { get; set; } // Dientich (length: 50)
        public string Price { get; set; } // Price (length: 50)
        public string PhoneNumber { get; set; } // PhoneNumber (length: 50)
        public int? MenuId { get; set; } // MenuId
        public int? TinhThanhId { get; set; } // TinhThanhId
        public int? QuanHuyenId { get; set; } // QuanHuyenId
        public int? UserId { get; set; } // UserId
        public decimal? OrgPrice { get; set; } // Org_Price
        public int? Status { get; set; } // Status
        public System.DateTime? CreateDate { get; set; } // CreateDate
        public short Active { get; set; } // Active
        public bool Reup { get; set; } // Reup

        public List<SearchTblPrivateNewsReturnModel> ListHouseFiltered { get; set; }

        public TblPrivateNew()
        {
            MenuId = 0;
            TinhThanhId = 0;
            Active = 1;
            Reup = false;
        }

        public class SearchTblPrivateNewsReturnModel
        {
            public long? NUMBER { get; set; }
            public int Id { get; set; }
            public string Title { get; set; }
            public System.String Price { get; set; }
            public System.String PhoneNumber { get; set; }
            public int? Status { get; set; }
            public System.DateTime? CreateDate { get; set; }
            public System.String NewsContent { get; set; }
            public System.Boolean ReUp { get; set; }
        }

        public class GetAreaReturnModel
        {
            public int Id { get; set; }
            public System.String Name { get; set; }
            public int? ParentId { get; set; }
        }
    }
}