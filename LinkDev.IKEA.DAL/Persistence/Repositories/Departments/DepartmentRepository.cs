﻿using LinkDev.IKEA.DAL.Models.Departments;
using LinkDev.IKEA.DAL.Persistence.Data;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinkDev.IKEA.DAL.Persistence.Repositories.Departments
{
    internal class DepartmentRepository : IDepartmentRepository
    {


        private readonly ApplicationDbContext _dbContext;

        private DepartmentRepository(ApplicationDbContext dbContext)
        {
            _dbContext = new ApplicationDbContext();
        }

        public IEnumerable<Department> GetAll(bool withAsNoTracking = true)
        {
            if (withAsNoTracking)
               return _dbContext.Departments.AsNoTracking().ToList();

            return _dbContext.Departments.ToList();

        }

        public Department? GetById(int id)
        {

            return _dbContext.Departments.Find(id);
           // return _dbContext.Find<Department>(id);


            ///var department = _dbContext.Departments.FirstOrDefault(D => D.Id == id);
            ///if (department == null)
            ///    department = _dbContext.Departments.FirstOrDefault(D => D.Id == id);
            ///return department;

        }
        public int Add(Department entity)
        {
           _dbContext.Departments.Add(entity);
            return _dbContext.SaveChanges();
        }
        public int Update(Department entity)
        {
            _dbContext.Departments.Update(entity);
            return _dbContext.SaveChanges();
        }
        public int Delete(Department entity)
        {
            _dbContext.Departments.Remove(entity);
            return _dbContext.SaveChanges();
        }
     

      
    }
}