using DAL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoBL.ViewModels
{
    public class usp_CustOrdersDetails_ResultViewModel
    {
        public string ProductName { get; set; }
        public List<usp_CustOrdersDetails_Result> orderDetailsVM { get; set; }

    }
}
