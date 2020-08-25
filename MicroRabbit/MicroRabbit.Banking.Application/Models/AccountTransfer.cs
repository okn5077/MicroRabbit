using System;
using System.Collections.Generic;
using System.Text;

namespace MicroRabbit.Banking.Application.Models
{
    public class AccountTransfer
    {
        public int SourceAccount { get; set; }
        public int TargetAccount { get; set; }
        public decimal TransferAmounth { get; set; }
    }
}
