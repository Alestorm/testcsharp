﻿using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using tutorial.services;
using tutorial.models;

namespace tutorial
{
    internal class Program
    {
        static void Main(string[] args)
        {

            EmployeeService employeeService = new EmployeeService();
            
            foreach(var emp in employeeService.GetEmployeeProjects())
            {
                Console.WriteLine("Project name:");
                Console.WriteLine(emp.Project.project_name);
                Console.WriteLine($"Employee: {emp.Employee.emp_fname} {emp.Employee.emp_lname}");
                
            }

            Console.WriteLine("DEPARTMENTS");
            DepartmentService departmentService = new DepartmentService();
            foreach (var dep in departmentService.GetAll())
            {
                Console.WriteLine($"ID: {dep.dept_no}");
                Console.WriteLine($"Deparment name: {dep.dept_name} - Location: {dep.location}");
            }

            Console.WriteLine("Insertar nuevo departamento");
            department department = new department();
            department.dept_no = Console.ReadLine();
            department.dept_name = Console.ReadLine();
            department.location = Console.ReadLine();

            Console.WriteLine("Id departamento insertado: "+ departmentService.AddDepartment(department));



            Console.ReadKey();
        }
    }
}
