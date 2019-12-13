using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Web_Template1.Models
{
    public class Account
    {
        public int Id { get; set; }

        public string AccountNo { get; set; }

        public string IdCard { get; set; }

        public string Title { get; set; }
        public string Name { get; set; }


        [DataType(DataType.Date)]
        public DateTime StartDate { get; set; }
       
        public decimal Capital { get; set; }

        public decimal Coin { get; set; }

        public string Status { get; set; }

        public int Ref_ID { get; set; }

    }
}
