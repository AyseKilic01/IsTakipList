using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ITLBusiness.BLC
{
    public class GetDataList
    {

        public static DataTable getFirmList()
        {
            return LoadList.LoadFormList.GetFirmList();
        }
        public static DataTable getDepartmentList()
        {
            return LoadList.LoadFormList.GetDepartmentList();
        }
        public static DataTable getEmployeeList()
        {
            return LoadList.LoadFormList.GetEmployeeList();
        }
        public static DataTable getTaskList()
        {
            return LoadList.LoadFormList.GetTaskList();
        }
    }
}
