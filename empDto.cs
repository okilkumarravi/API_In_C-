using System;
using System.Collections.Generic;
using System.Text;

namespace API_Core
{
    public class empDto
    {
        public string userId { get; set; }

        public string jobTitleName { get; set; }

        public string firstName { get; set; }

        public string lastName { get; set; }

        public string preferredFullName { get; set; }

        public string employeeCode { get; set; }

        public string region { get; set; }

        public string phoneNumber { get; set; }

        public string emailAddress { get; set; }

    }

    public class EmployeeSeedingData
    {
        public List<empDto> employees { get; }
        public EmployeeSeedingData()
        {
           
            employees = new List<empDto>()
            {
                new empDto()
                {
                userId="rirani",
                jobTitleName="Developer",
                firstName="Romin",
                lastName="Irani",
                preferredFullName = "Romin Irani",
                employeeCode = "E1",
                region ="CA",
                phoneNumber ="408-1234567",
                emailAddress ="romin.k.irani@gmail.com"
                },
                new empDto()
                {
                userId="SSinha",
                jobTitleName="Developer",
                firstName="Shiwam",
                lastName="Shinha",
                preferredFullName="Shiwam Sinha",
                employeeCode="E2",
                region="HYD",
                phoneNumber="408-1111111",
                emailAddress="sxxxxxxxxxxx@gmail.com"
                }
            };
        }
    }
}

