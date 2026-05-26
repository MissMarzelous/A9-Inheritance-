using System;
using System.Collections.Generic;
using System.Text;

namespace Assignment9_Inheritance
{
    class DSC
    {
        public virtual string giveAddress()
        {
            return "1200 W. International Speedway Blvd., Daytona Beach, Florida 32114";
        }

        public void set_schoolName(string sName)
        { nameOfSchool = sName; }
        private string nameOfSchool = "Daytona State College";
        public string TheSchoolNme()
        {
            return nameOfSchool;
          
        }
    }

}
