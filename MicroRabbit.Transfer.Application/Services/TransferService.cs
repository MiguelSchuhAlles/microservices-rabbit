﻿using MicroRabbit.Transfer.Application.Interfaces;
using MicroRabbit.Transfer.Domain.Models;
using System.Collections.Generic;
using MicroRabbit.Domain.Core.Bus;
using MicroRabbit.Transfer.Domain.Interfaces;

namespace MicroRabbit.Transfer.Application.Services
{
    public class TransferService : ITransferService
    {
        private readonly ITransferRepository _transferRepository;
        private readonly IEventBus _eventBus;

        public TransferService(ITransferRepository transferRepository, IEventBus eventBus)
        {
            _transferRepository = transferRepository;
            _eventBus = eventBus;
        }

        public IEnumerable<TransferLog> GetTransferLogs()
        {
            return _transferRepository.GetTransferLogs();
        }

        public IEnumerable<decimal> GetTransferAmounts()
        {
            return _transferRepository.GetTransferAmounts();
        }
    }
}
