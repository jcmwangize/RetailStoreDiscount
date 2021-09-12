using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace RetailStoreDiscounts
{
    public class ClsComputeDiscounts
    {



        public double FindNetPayableAmount(double billAmount, string userClassification, int customerYears, string itemType)
        {
            double discountbasedonusertype = 0;
            double discountonCustomerYears = 0;
            double discountper100dollars = 0;
            double totaldiscount = 0;

            if (itemType != "groceries")
            {
                //Compute discount based on user type/classification.
                if (userClassification == "employee")
                {
                    discountbasedonusertype = 0.03 * billAmount;
                }
                else if (userClassification == "affiliate")
                {
                    discountbasedonusertype = 0.01 * billAmount;
                }


                if (customerYears > 2)
                {

                    discountonCustomerYears = 0.02 * billAmount;
                }
            }

            //compute discount per $100 - floor the result to get whole numbers only.

            discountper100dollars = Math.Floor(billAmount / 100) * 5;
                        
            totaldiscount = discountbasedonusertype + discountonCustomerYears + discountper100dollars;
            return totaldiscount;
        }


    }
}