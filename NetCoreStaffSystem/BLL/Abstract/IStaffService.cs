using DAL.Entity;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;

namespace BLL.Abstract
{
    public interface IStaffService
    {
        //Listing
        List<Staff> GetStaff(Expression<Func<Staff, bool>> exp);

        //ActiveListing
        List<Staff> GetActiveStaff();

        //Adding
        void Add(Staff staff);

        //Update
        void Update(Staff staff);

        //Delete
        void Remove(Guid id);

        //Get
        Staff GetById(Guid id);
    }
}
