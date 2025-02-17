﻿using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
namespace DatabaseProgramming.Data
{
    public class Dept
    {
        public int DeptId { get; set; }
        public string DeptName { get; set; }
    }

    class Employee
    {
        public int EmpId { get; set; }
        public string EmpName { get; set; }
        public string EmpAddress { get; set; }
        public int EmpSalary { get; set; }
        public int DeptId { get; set; }
    }

    interface IEmployeeDbAccess
    {
        List<Employee> GetAll();
    }

    class EmployeeDbAccess : IEmployeeDbAccess
    {
        #region Members
        SqlConnection sqlCon;
        SqlCommand cmd;
        #endregion

        #region Constants
        const string STRCONNECTION = "Data Source=PHANI-PC\\SQLEXPRESS;Initial Catalog=CapgeminiDb;Integrated Security=True;Encrypt=False";
        const string SELECTSTATEMENT = "SELECT * FROM EMPTABLE";
        #endregion
        public List<Employee> GetAll()
        {
            List<Employee> empList = new List<Employee>();
            using(sqlCon = new SqlConnection(STRCONNECTION))
            {
                cmd = new SqlCommand(SELECTSTATEMENT, sqlCon);
                sqlCon.Open();
                var reader = cmd.ExecuteReader();
                while(reader.Read())
                {
                    var emp = new Employee();
                    emp.EmpId =Convert.ToInt32(reader[0]);
                    emp.EmpName = reader[1].ToString();
                    emp.EmpAddress = reader[2].ToString();
                    emp.EmpSalary = Convert.ToInt32(reader[3]);
                    int deptId;
                    if(int.TryParse(reader[4].ToString(), out deptId))
                    emp.DeptId = deptId;
                    else 
                        emp.DeptId = 0;
                    empList.Add(emp);
                }
                sqlCon.Close();
            }
            return empList;
        }
    }

    interface IDeptDbAccess
    {
        void AddDept(Dept dept);

        void UpdateDept(Dept dept);

        List<Dept> GetAllDepts();
    }

    class DeptDbAccess : IDeptDbAccess
    {
        #region Members
        SqlConnection sqlCon;
        SqlCommand cmd;
        #endregion

        #region Constants
        const string STRCONNECTION = "Data Source=PHANI-PC\\SQLEXPRESS;Initial Catalog=CapgeminiDb;Integrated Security=True;Encrypt=False";

        const string INSERTSTATEMENT = "Insert into DeptTable values(@deptName)";
        const string UPDATESTATEMENT = "Update DeptTable set DeptName = @name where DeptId = @id";
        const string SELECTSTATEMENT = "SELECT * FROM DEPTTABLE";
        #endregion

        public void AddDept(Dept dept)
        {
            if(dept.DeptId != 0)
            {
                throw new Exception("U should not set DeptId");
            }
            using(sqlCon = new SqlConnection(STRCONNECTION)) {
                cmd = new SqlCommand(INSERTSTATEMENT, sqlCon);
                cmd.Parameters.AddWithValue("@deptName", dept.DeptName);
                try
                {
                    sqlCon.Open();
                    cmd.ExecuteNonQuery(); 
                }
                catch(Exception)
                {
                    throw;
                }
            }
        }

        public List<Dept> GetAllDepts()
        {
            List<Dept> depts = new List<Dept>();
            using(sqlCon = new SqlConnection(STRCONNECTION))
            {
                cmd = new SqlCommand(SELECTSTATEMENT, sqlCon);
                sqlCon.Open();
                var reader = cmd.ExecuteReader();
                while(reader.Read())
                {
                    var dept = new Dept();
                    dept.DeptId = Convert.ToInt32(reader[0]);
                    dept.DeptName = reader[1].ToString();
                    depts.Add(dept);
                }
            }
            return depts;
        }

        public void UpdateDept(Dept dept)
        {
            using(sqlCon = new SqlConnection(STRCONNECTION))
            {
                cmd = new SqlCommand(UPDATESTATEMENT, sqlCon);
                cmd.Parameters.AddWithValue("@name", dept.DeptName);
                cmd.Parameters.AddWithValue("@id", dept.DeptId);
                try
                {
                    sqlCon.Open();
                    cmd.ExecuteNonQuery();
                }
                catch(Exception)
                {
                    throw;
                }
            }
        }
    }
}