using System;
using System.Collections.Generic;

namespace _09_Portfolio {
    internal class Portfolio {
        private List<IAsset> stocks;

        public Portfolio() {
        }

        public Portfolio(List<IAsset> stocks) {
            this.stocks = stocks;
        }

        internal double GetTotalValue() {
            return ;
        }

        internal void AddAsset(IAsset stockHP) {
            throw new NotImplementedException();
        }
    }
}