
using MicroRabbit.Transfer.Domain.Interfaces;
using MicroRabbit.Transfer.Domain.Models;
using MicroRabbit.Domain.Core.Bus;
using System;
using System.Collections.Generic;
using System.Text;
using MicroRabbit.Transfer.Application.Interfaces;

namespace MicroRabbit.Transfer.Application.Services
{
    public class TransferService : ITransferService
    {
        private readonly IEventBus _bus;
        private readonly ITransferRepository _TransferRepository;

        public TransferService(ITransferRepository TransferRepository, IEventBus bus)
        {
            _TransferRepository = TransferRepository;
            _bus = bus;
        }

        public IEnumerable<TransferLog> GetTransferLogs()
        {
            return _TransferRepository.GetTransferLogs();
        }
    }
}
