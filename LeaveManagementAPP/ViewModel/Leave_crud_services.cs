using LeaveManagementAPP.Interface;
using LeaveManagementAPP.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeaveManagementAPP.ViewModel
{
    public class Leave_crud_services
    {
        private readonly IDataService<Leave> _crudServices;

        public Leave_crud_services()
        {
            _crudServices = new GenericDataService<Leave>(new Leave_DashboardContextFactory());
        }
        // Creating Add Function 
        public async Task<Leave> AddBrand(int lid ,string name, int id, string category, DateTime StartDate, DateTime EndDate)
        {
            try
            {
                if ((name == string.Empty) || (category == string.Empty))
                {
                    throw new Exception("Employee Name Cannot be Empty");
                }
                else
                {

                    Leave br = new Leave()
                    {
                        EmployeeID = id,
                        StartDate = StartDate.Date,
                        EndDate = EndDate.Date,
                        LeaveCategory = category,
                        Status = "Pending"

                    };
                    return await _crudServices.Create(br);
                }

            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
        // Creating Delete Function
        public async Task<bool> DeleteBrand(int lid)
        {
            try
            {
                Leave delete = await SearchBrandbyID(lid);

                return await _crudServices.Delete(delete);



            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
        //creating method for search by id method 
        public Task<Leave> SearchBrandbyID(int lid)
        {
            try
            {
                return _crudServices.Get(lid);
            }
            catch (Exception ex)
            {

                throw new Exception(ex.Message);
            }
        }
        //Creating method for search by Name 
        public async Task<ICollection<Leave>> SearchBrandByName(string name)
        {
            try
            {
                var listbrand = await ListBrands();
                return listbrand.Where(x => x.Employee.EmpName.StartsWith(name)).ToList();

            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);

            }
        }
        //Creating method for displaying list
        public async Task<ICollection<Leave>> ListBrands()
        {
            try
            {
                return (ICollection<Leave>)await _crudServices.GetAll();
            }
            catch (Exception ex)
            {

                throw new Exception(ex.Message);
            }
        }
        //Creating Update methode 
        public async Task<Leave> UpdateBrand(int lid, string category, DateTime startdate, DateTime enddate)
        {
            try
            {

                Leave br = await SearchBrandbyID(lid);
                //br.Employee.EmpName= name;
                br.LeaveCategory = category;
                br.StartDate = startdate;
                br.EndDate = enddate;

                return await _crudServices.Update(br);


            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);

            }
        }
    }
}
