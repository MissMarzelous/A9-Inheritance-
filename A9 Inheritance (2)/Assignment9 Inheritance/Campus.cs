using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
 

namespace Assignment9_Inheritance
{
    class Campus : DSC
    {
        private string campusNm;
        public Campus(string DscNm)
        {
            campusNm = DscNm;
        }
        public void setCampusName(string DscNm)
        { campusNm = DscNm; }
        public string getCampusName()
        { return campusNm; }

        public string DepartmentsOfDsc()
        {
            return "Computer Science, the Police Academy, and Emergency Care.";

        }
          
       
        public override string giveAddress()
        {
            return "1770 Williamson Blvd., Daytona Beach, Florida 32117";

        }
       
        public override string ToString() // this overrides the object ToString
        {
          
            return TheSchoolNme() + "  " + getCampusName() + "\nThe school is located at " + giveAddress() + "\nThe school offers departments in " + DepartmentsOfDsc();

        }

     
       
    }

}
    
    

