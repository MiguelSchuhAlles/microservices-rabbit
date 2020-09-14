using MicroRabbit.Domain.Core.Commands;
using System.Collections.Generic;
using System.Text;
using System;

namespace MicroRabbit.Banking.Domain.Commands
{
    public class TransferCommand : Command
    {
        public int From { get; protected set; }
        public int To { get; protected set; }
        public decimal Amount { get; protected set; }
    }
}
