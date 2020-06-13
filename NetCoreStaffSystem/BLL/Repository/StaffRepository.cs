using BLL.Abstract;
using DAL.Context;
using DAL.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;

namespace BLL.Repository
{
    public class StaffRepository : IStaffService
    {
        private readonly AppDbContext context;

        public StaffRepository(AppDbContext context)
        {
            this.context = context;
        }

        public void Add(Staff staff)
        {
            context.Staffs.Add(staff);
            context.SaveChanges();
        }

        public List<Staff> GetActiveStaff()
        {
            return context.Staffs.Where(x => x.Status == DAL.Entity.Enum.Status.Active).ToList();
        }

        public Staff GetById(Guid id)
        {
            return context.Staffs.FirstOrDefault(x => x.ID == id);
        }

        public List<Staff> GetStaff(Expression<Func<Staff, bool>> exp)
        {
            return context.Staffs.Where(exp).ToList();
        }

        public void Remove(Guid id)
        {
            Staff staff = GetById(id);
            staff.Status = DAL.Entity.Enum.Status.Deleted;
            Update(staff);
        }

        public void Update(Staff staff)
        {
            context.Entry(staff).State = Microsoft.EntityFrameworkCore.EntityState.Modified;
            context.SaveChanges();
        }
    }
}
