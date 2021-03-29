﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Binance.Net.Enums
{
    /// <summary>
    /// Mining earnings type
    /// </summary>
    public enum BinanceEarningType
    {
        /// <summary>
        /// Mining wallet
        /// </summary>
        MiningWallet,
        /// <summary>
        /// Mining address
        /// </summary>
        MiningAddress,
        /// <summary>
        /// Pool savings
        /// </summary>
        PoolSavings,
        /// <summary>
        /// Transfered
        /// </summary>
        Transfered,
        /// <summary>
        /// Income transfer
        /// </summary>
        IncomeTransfer,
        /// <summary>
        /// Hashrate resale - mining wallet
        /// </summary>
        HashrateResaleMiningWallet,
        /// <summary>
        /// Hashrate resale - pool savings
        /// </summary>
        HashrateResalePoolSavings
    }
}
