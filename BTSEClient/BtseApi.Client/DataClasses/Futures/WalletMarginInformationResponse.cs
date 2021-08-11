using System;
using System.Collections.Generic;
using System.Text;

namespace BtseApi.Client.DataClasses.Futures
{
    public class Asset
    {
        public decimal Ballance { get; set; }
        public decimal AssetPrice { get; set; }
        public string Currency { get; set; }
    }

    public class WalletMarginInformationResponse
    {
        public long TrackingID { get; set; }
        public int QueryType { get; set; }
        public string ActiveWalletName { get; set; }
        public string Wallet { get; set; }
        public string UserName { get; set; }
        public decimal WalletTotalValue { get; set; }
        public decimal TotalValue { get; set; }
        public decimal MarginBalance { get; set; }
        public decimal AvailableBalance { get; set; }
        public decimal UnrealisedProfitLoss { get; set; }
        public decimal MaintenanceMargin { get; set; }
        public decimal Leverage { get; set; }
        public decimal OpenMargin { get; set; }
        public List<Asset> Assets { get; set; }
        public List<Asset> AssetsInUse { get; set; }
    }
}
