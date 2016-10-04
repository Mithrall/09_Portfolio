using System;
using System.Globalization;

namespace _09_Portfolio {
    internal class Stock : IAsset {
        public double NumShares;
        public double PricePerShare;
        public string Symbol;

        public Stock() {
        }

        public Stock(string name, double price, double number) {
            Symbol = name;
            PricePerShare = price;
            NumShares = number;
        }

        public double GetValue() {
            return PricePerShare * NumShares;
        }

        public static double TotalValue(IAsset[] stocks) {
            double res = 0;
            for (int i = 0; i < stocks.Length; i++) {
                res += stocks[i].GetValue();
            }
            return res;
        }

        public override string ToString() {
            return "Stock[symbol=" + Symbol + ",pricePerShare=" + PricePerShare.ToString(CultureInfo.CreateSpecificCulture("en-GB")) + ",numShares=" + NumShares + "]";
        }

        public bool Equals(Stock obj) {
            if (this.Symbol == obj.Symbol && this.NumShares == obj.NumShares && this.PricePerShare == obj.PricePerShare) {
                return true;
            } else {
                return false;
            }  
        }
        public override int GetHashCode() {
            return base.GetHashCode();
        }
    }
}