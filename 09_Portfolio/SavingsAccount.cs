using System;
using System.Globalization;

namespace _09_Portfolio {
    internal class SavingsAccount : IAsset {
        public string AccName;
        public double Value;
        public double InterestRate;

        public SavingsAccount(string name, double value, double interest) {
            AccName = name;
            Value = value;
            InterestRate = interest;
        }

        public double GetValue() {
            return Value;
        }

        internal void ApplyInterest() {
            Value += InterestRate*Value/100;
        }
        public override string ToString() {
            return "SavingsAccount[value=" + Value.ToString("##.0", CultureInfo.CreateSpecificCulture("en-GB")) + ",interestRate=" + InterestRate.ToString(CultureInfo.CreateSpecificCulture("en-GB")) + "]";
        }
    }
}