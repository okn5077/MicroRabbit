using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MicroRabbit.MVC.Models.DTO
{
    public class TransferDto
    {
        public int SourceAccount { get; set; }
        public int TargetAccount { get; set; }
        public decimal TransferAmounth { get; set; }
    }
}
