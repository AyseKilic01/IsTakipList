using DevExpress.XtraEditors;
using ITLDataAccess.Concrete.EntityFramework;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Common;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ITLBusiness.LoadList
{
    public class LoadFormList
    {
        public static DataTable Firm()
        {
            DataTable dt = null;
            return dt;
        }
        public static DataTable GetFirmList()
        {
            try
            {
                DataTable dt = DAL.getData("SELECT a.ID as FirmID, a.name as FirmName, a.author as FirmAuthor, a.phone as FirmPhone, a.mail as FirmMail, " +
                                    "a.sector as FirmSector, a.city as FirmCity, a.district as FirmDistrict, a.address as FirmAddress " +
                                    "FROM Firms a ");
                return dt;
            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.Message);
                return null;
            }
        }
        public static DataTable GetTaskList()
        {
            try
            {
                DataTable dt =  DAL.getData("SELECT a.ID as TaskID, a.commissioner as TaskCommissionerID, a.employee as TaskEmployeeID, " +
                    "a.statement as TaskStatement, a.statu as TaskStatu, a.date as TaskDate, " +
                    "a.passive as TaskPassive, b.name as TaskCommissioner, c.name as TaskEmployee " +
                    "FROM Tasks a " +
                    "LEFT OUTER JOIN TblEmployees b on b.ID = a.commissioner " +
                    "LEFT OUTER JOIN TblEmployees c on c.ID = a.employee ");
                return dt;
            }
            catch (Exception e)
            {
                XtraMessageBox.Show("Veri yok !!!", "Bilgi");
                return null;
            }
        }

        public static DataTable GetDepartmentList()
        {
            try
            {
                DataTable dt = DAL.getData("SELECT a.ID as DepartmentID, a.departcode as DepartmentCode FROM TblDepartments a");
                return dt;
            }
            catch (Exception e)
            {
                XtraMessageBox.Show("Veri yok !!!", "Bilgi");
                return null;
            }
        }
        public static DataTable GetEmployeeList()
        {
            try
            { 
                DataTable dt = DAL.getData("SELECT a.ID as EmployeeID, a.name as EmployeeName, a.surname as EmployeeSurname, " +
                            "a.mail as EmployeeMail, a.phone as EmployeePhone, a.image as EmployeeImage, a.departmentID as EmployeeDepartID, " +
                            "a.statu as EmployeeStatu, b.departcode as EmployeeDepartCode " +
                            "FROM TblEmployees a " +
                            "LEFT OUTER JOIN TblDepartments b on b.ID = a.departmentID");
                return dt;
            }
            catch (Exception)
            {
                XtraMessageBox.Show("Veri yok !!!", "Bilgi");
                return null;
            }
        }
    }
}
