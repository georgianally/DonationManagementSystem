using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TheSarreWindmillTrust_Assignment1
{
    public class Donor
    {
        //attributes
        private String mDonorName;
        private String mUniqueID;
        private Decimal mTotalAmount;
        private Decimal mLastAmount;
        private DateTime mLastDate;
        private DateTime mFirstDate;

        private Int32 mNumericRating;
        private String mAdjectiveRating = "Bronze";

        //constructor
        public Donor(String donorName, Decimal amount, DateTime date, Int32 id)
        {
            mDonorName = donorName;
            mUniqueID = mDonorName.Substring(0, 1).ToUpper() + id + DateTime.Now.ToString("yyyyMMdd");
            mTotalAmount = amount;
            mLastAmount = amount;
            mLastDate = date;
            mFirstDate = date;
        }

        //methods
        public String GetName()
        {
                return mDonorName;
        }

        public String GetID()
        {

                return mUniqueID;
        }

        public Decimal GetTotalAmount()
        {
                return mTotalAmount;
        }

        public Decimal GetLastAmount()
        {

            return mLastAmount;
        }

        public DateTime GetFirstDate()
        {

            return mFirstDate;
        }

        public DateTime GetLastDate()
        {

            return mLastDate;
        }

        public Int32 GetNumRating()
        {
                return mNumericRating;
        }

        public String GetAdjRating()
        {
                return mAdjectiveRating;
        }

        public void Deposit(Decimal Amount, DateTime Date)
        {
            mTotalAmount += Amount;
            mLastAmount = Amount;
            mLastDate = Date;
            if (mFirstDate.ToShortDateString() == "01/01/0001" || DateTime.Compare(mFirstDate, Date) > 0)
            {
                mFirstDate = Date;
            }
        }

        public void RatingSystem()
        {
            mNumericRating = 1;
            //Numeric
            DateTime pastDate = Convert.ToDateTime("2010/01/01");
            if  (mLastAmount >= 10.0m && mLastAmount <= 50.0m && mLastDate.Date > DateTime.Now.AddYears(-1))
            {
                mNumericRating += 1;
            }
            if (mTotalAmount >= 1000.0m && mLastAmount >= 500.0m)
            {
                decimal i = (mTotalAmount - 1000) / 500;
                i = Math.Floor(i);
                mNumericRating += Convert.ToInt32(i);
            }
            if (mLastAmount >= 50.0m && mLastDate.Date > DateTime.Now.AddYears(-1))
            {
                mNumericRating += 2;
            }
            if (mFirstDate < pastDate)
            {
                mNumericRating += 2;
            }
            if (mTotalAmount > 500.0m)
            {
                mNumericRating += 5;
            }

            //Adjective
            if (mNumericRating > 5 && mNumericRating <= 7)
            {
                mAdjectiveRating = "Silver";
            }
            else if (mNumericRating > 7 && mNumericRating <= 12)
            {
                mAdjectiveRating = "Gold";
            }
            else if (mNumericRating > 12)
            {
                mAdjectiveRating = "Diamond";
            }
        }
    }
}
    


