using System;
using System.Collections.Generic;
using System.Deployment.Internal;
using System.IO;
using System.Linq;
using System.Runtime.Remoting.Services;
using System.Security.Claims;
using System.Text;
using System.Threading.Tasks;
using static Feature_1_assignment.CustomerInput;

namespace Feature_1_assignment
{
    internal class CustomerInput//customer input details
    {
        public string firstname { get; set; }
         public string surname { get; set; }
            public string location { get; set; }
        public int plotno { get; set; }
        public string usertype { get; set; }
        public double AmountOfWaterUsed { get; set; }
        public double TotalWaterCost;
        /* Declaration of instance variables */

        //constructor with parameters
        public CustomerInput(string FirstName, string SurName, string LocaTion, int PlotNo, String UserType, double waterused)
        {
            firstname = FirstName;
            surname = SurName;
            location = LocaTion;
            plotno = PlotNo;
            usertype = UserType;
            AmountOfWaterUsed = waterused;
        }

        internal class DomesticCalculation//Calculates water bill fo Domestic User . Creation of separate calculation classes for easy readability and quick updates
        {
            public double TotalWaterCost(double AmountOfWaterUsed)
            {
                double costofwater;
                double VATexclude = 3.60 * 5;
                double wastewater;
                double TotalWaterCost;
                if (AmountOfWaterUsed <= 5 ) 
                {
                    
                    costofwater = (3.60 * AmountOfWaterUsed);
                    Console.WriteLine("Potable Water Cost : " + costofwater);
                   
                    wastewater = (0.65 * AmountOfWaterUsed);
                    Console.WriteLine("Waste Water Cost : " + wastewater);
                    
                    TotalWaterCost = costofwater + wastewater;
                    return TotalWaterCost;
                }

                else if (5 < AmountOfWaterUsed && 15 > AmountOfWaterUsed)
                {
                    costofwater = ((AmountOfWaterUsed - 5) * (13.43) + (VATexclude));
                    Console.WriteLine("Potable Water Cost : " + costofwater);

                    wastewater = ((AmountOfWaterUsed - 5) * (3.36)) + (0.65 * 5);
                    Console.WriteLine("Waste Water Cost : " + wastewater);

                    TotalWaterCost = costofwater + wastewater;
                    return TotalWaterCost;
                }


                else if (15 < AmountOfWaterUsed && 25 > AmountOfWaterUsed)
                {
                    costofwater = ((AmountOfWaterUsed - 15)) * (23.51) + (10 * 13.43) + (VATexclude);
                    Console.WriteLine("Potable Water Cost : " + costofwater);

                    wastewater = ((AmountOfWaterUsed - 25) * (6.71)) + (10 * 3.36) + (10 * 5.03) + (0.65 * 5);
                    Console.WriteLine("Waste Water Cost :" + wastewater);

                    TotalWaterCost = costofwater + wastewater;
                    return TotalWaterCost;
                }

                else if (25 < AmountOfWaterUsed && 40 > AmountOfWaterUsed)
                {
                    costofwater = ((AmountOfWaterUsed - 25) * (36.16)) + (10 * 13.43) + (10 * 23.51) + (VATexclude);
                    Console.WriteLine("Potable Water Cost : " + costofwater);

                    wastewater = ((AmountOfWaterUsed - 5) * (3.36)) + (0.65 * 5);
                    Console.WriteLine("Waste Water Cost : " + wastewater);

                    TotalWaterCost = costofwater + wastewater;
                    return TotalWaterCost;

                }
                else
                {
                    costofwater = (AmountOfWaterUsed - 40) * (45.21) + (10 * 13.43) + (10 * 23.51) + (15 * 36.16) + (VATexclude);
                    Console.WriteLine("Potable Water Cost : " + costofwater);

                    wastewater = ((AmountOfWaterUsed - 40) * (8.39)) + (10 * 3.36) + (10 * 5.03) + (15 * 6.71) + (0.65 * 5);
                    Console.WriteLine("Waste Water Cost : " + wastewater);

                    TotalWaterCost = costofwater + wastewater;
                    return TotalWaterCost;
                    
                }

                {
                    DomesticCalculation domesticCalculation = new DomesticCalculation();// object creation
                    
                    return TotalWaterCost;//method invoked
                }
            }

            internal class COMMERCIALCALCULATION// calculates water bill for commercial user 

            {

                public double TotalWaterCost(double AmountOfWaterUsed)

                {
                    double CostOfWater;
                    double wastewater;
                    double TotalWaterCost;


                    if (AmountOfWaterUsed <= 5)

                    {
                        CostOfWater = (4.92 * AmountOfWaterUsed);
                        Console.WriteLine("Potable Water Cost : " + CostOfWater);

                        wastewater = (0.65 * AmountOfWaterUsed);
                       Console.WriteLine("Waste Water Cost : " + wastewater);

                        TotalWaterCost = CostOfWater + wastewater;
                        return TotalWaterCost;

                    }

                    else if (AmountOfWaterUsed > 5 && AmountOfWaterUsed <= 15)

                    {
                        CostOfWater = ((AmountOfWaterUsed - 5) * (14.61)) + (5 * 4.92);
                        Console.WriteLine("Potable Water Cost : " + CostOfWater);

                        wastewater = ((AmountOfWaterUsed - 5) * (3.36)) + (5 * 0.74);
                        Console.WriteLine("Waste Water Cost : " + wastewater);

                        TotalWaterCost = CostOfWater + wastewater;
                        return TotalWaterCost;

                    }

                    else if (AmountOfWaterUsed > 15 && AmountOfWaterUsed <= 25)

                    {
                        CostOfWater = ((AmountOfWaterUsed - 15) * (25.58)) + (10 * 14.61) + (5 * 4.92);
                        Console.WriteLine("Potable Water Cost :" + CostOfWater);

                        wastewater = ((AmountOfWaterUsed - 15) * (5.03)) + (10 * 3.36) + (5 * 0.74);
                        Console.WriteLine("Waste Water Cost :" + wastewater);

                        TotalWaterCost = CostOfWater + wastewater;
                        return TotalWaterCost;
                    }

                    else if (AmountOfWaterUsed > 25 && AmountOfWaterUsed <= 40)

                    {
                        CostOfWater = ((AmountOfWaterUsed - 25) * (39.35)) + (5 * 4.92) + (10 * 14.61) + (10 * 25.58);
                        Console.WriteLine("Potable Water Cost :" + CostOfWater);

                        wastewater = ((AmountOfWaterUsed - 25) * (6.71)) + (10 * 3.36) + (10 * 5.03) + (5 * 0.74);
                        Console.WriteLine("Waste Water Cost :" + wastewater);

                        TotalWaterCost = CostOfWater + wastewater;
                        return TotalWaterCost;
                    }

                    else

                    {
                        CostOfWater = ((AmountOfWaterUsed - 40) * (49.20)) + (5 * 4.92) + (10 * 14.61) + (10 * 25.58) + (15 * 39.35);
                        Console.WriteLine("Potable Water Cost :" + CostOfWater);

                        wastewater = ((AmountOfWaterUsed - 40) * (8.39)) + (10 * 3.36) + (10 * 5.03) + (15 * 6.71) + (5 * 0.74);
                        Console.WriteLine("Waste Water Cost :" + wastewater);

                        TotalWaterCost = CostOfWater + wastewater;
                        return TotalWaterCost;
                    }

                    {
                        COMMERCIALCALCULATION cOMMERCIALCALCULATION = new COMMERCIALCALCULATION();// object creation
                       
                        return TotalWaterCost;//method invoked
                }   }

                    internal class CustomerInfo//tests the former classes(CustomerInput,Domestic Calculation,Commecial Calculation.
                    {
                        public static void Main()
                        {
                           StreamWriter outputFile;
                           StreamWriter recordFile;
                           outputFile = new StreamWriter("CustomerInfo.doc");
                           recordFile = File.AppendText("Report.doc");

                           CustomerInput Customer= new CustomerInput("Dee", "Nomsa", "Mosopa", 5431, "Domestic", 44.0);
                           Console.WriteLine("******************************************************************************");
                           Console.WriteLine("Enter Firstname and Surname");
                           Customer.firstname = Console.ReadLine();
                           Customer.surname = Console.ReadLine();
                           outputFile.WriteLine("Fullname :" + Customer.firstname + Customer.surname);

                           Console.WriteLine("Enter location");
                           Customer.location = Console.ReadLine();
                           outputFile.WriteLine("Location :" + Customer.location);

                          Console.WriteLine("Enter Plotno");
                          Customer.plotno =Convert.ToInt32(Console.ReadLine());
                          outputFile.WriteLine("Plotno : " + Customer.plotno);

                          Console.WriteLine("Enter Amount Of Water Used ");
                          Customer.AmountOfWaterUsed = Convert.ToDouble(Console.ReadLine());
                          outputFile.WriteLine("Amount of waterused :" + Customer.AmountOfWaterUsed);

                        Console.WriteLine("Enter Usertype");
                          Customer.usertype = Console.ReadLine();
                          if (Customer.usertype == "Domestic")
                          {
                             DomesticCalculation domesticCalculation = new DomesticCalculation();
                            Customer.TotalWaterCost = domesticCalculation.TotalWaterCost(Customer.AmountOfWaterUsed);
                           
                          }

                          else if (Customer.usertype == "Commercial")
                          {
                            COMMERCIALCALCULATION commerceCalculation = new COMMERCIALCALCULATION();
                            Customer.TotalWaterCost = commerceCalculation.TotalWaterCost(Customer.AmountOfWaterUsed);

                          }
                           else
                           {
                            Console.WriteLine("Null,Re-enter UserType ");
                           }
                          outputFile.WriteLine("Usertype : " + Customer.usertype);

                          outputFile.WriteLine();
                          Console.WriteLine("VAT:14 %");
                          Console.WriteLine("Total Water Cost:" + Customer.TotalWaterCost);

                          outputFile.Close();
                          recordFile.Close();

                        Console.WriteLine("**************************************************************************************");
                         






                        }












                    }


                    


















            }







        }


                






































































    }





































}




