using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using Moq;
using NUnit.Framework.Internal;
using System.Net.NetworkInformation;

namespace Assign_Testing
{
    public interface IInsuranceService
    {
        int GetDiscount();
    }
    public class InsuranceService
    {
        private readonly IInsuranceService _insuranceService;
        public InsuranceService(IInsuranceService insuranceService)
        {
            _insuranceService = insuranceService;
        }
        public double CalcPremium(int age, string location)
        {
            double premium;
            
            //a
            if (location == "rural")
                //b
                if ((age >= 18) && (age < 30))
                    premium = 5.0;
                //c
                else
                    //c1
                    if (age >= 31)
                    premium = 2.50;
                //d
                else
                    premium = 0.0;
                //e
                else
            //f
            if (location == "urban")
                //g
                if ((age >= 18) && (age <= 35))
                    premium = 6.0;
                //h
                else
                //i
                if (age >= 36)
                    premium = 5.0;

                //j
                else
                    premium = 0.0;
                //k
           else
                premium = 0.0;

            double discount = _insuranceService.GetDiscount();
            //l
            if (age >= 50)
                 premium *= 1 - (discount / 100);

            return premium;
        }
    } 
}

