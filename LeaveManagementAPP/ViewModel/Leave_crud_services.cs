using LeaveManagementAPP.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeaveManagementAPP.ViewModel
{
    internal class Leave_crud_services
    {
        //private readonly IDataservice<Leave_Dashboard> _crudServices;

        //public Leave_crud_services()
        //{
        //    _crudServices = new GenericDataService<Leave_Dashboard>(new Leave_DashboardContextFactory());
        //}
        //// Creating Add Function 
        //public async Task<Leave_Dashboard> AddBrand(string name, string category, DateTime StartDate, DateTime EndDate)
        //{
        //    try
        //    {
        //        if ((name == string.Empty) || (category == string.Empty))
        //        {
        //            throw new Exception("Employee Name Cannot be Empty");
        //        }
        //        else
        //        {

        //            Leave_Dashboard br = new Leave_Dashboard
        //            {
        //                Name = name,
        //                DateStart = StartDate.Date,
        //                DateEnd = EndDate.Date,
        //                Category = category,
        //                status = "Pending"

        //            };
        //            return await _crudServices.Create(br);
        //        }

        //    }
        //    catch (Exception ex)
        //    {
        //        throw new Exception(ex.Message);
        //    }
        //}
        //// Creating Delete Function
        //public async Task<bool> DeleteBrand(int id)
        //{
        //    try
        //    {
        //        Leave_Dashboard delete = await SearchBrandbyID(id);

        //        return await _crudServices.Delete(delete);



        //    }
        //    catch (Exception ex)
        //    {
        //        throw new Exception(ex.Message);
        //    }
        //}
        ////creating method for search by id method 
        //public Task<Leave_Dashboard> SearchBrandbyID(int ID)
        //{
        //    try
        //    {
        //        return _crudServices.Get(ID);
        //    }
        //    catch (Exception ex)
        //    {

        //        throw new Exception(ex.Message);
        //    }
        //}
        ////Creating method for search by Name 
        //public async Task<ICollection<Leave_Dashboard>> SearchBrandByName(string name)
        //{
        //    try
        //    {
        //        var listbrand = await ListBrands();
        //        return listbrand.Where(x => x.Name.StartsWith(name)).ToList();

        //    }
        //    catch (Exception ex)
        //    {
        //        throw new Exception(ex.Message);

        //    }
        //}
        ////Creating method for displaying list
        //public async Task<ICollection<Leave_Dashboard>> ListBrands()
        //{
        //    try
        //    {
        //        return (ICollection<Leave_Dashboard>)await _crudServices.GetAll();
        //    }
        //    catch (Exception ex)
        //    {

        //        throw new Exception(ex.Message);
        //    }
        //}
        ////Creating Update methode 
        //public async Task<Leave_Dashboard> UpdateBrand(int id, string name, string category, DateTime startdate, DateTime enddate)
        //{
        //    try
        //    {

        //        Leave_Dashboard br = await SearchBrandbyID(id);
        //        br.Name = name;
        //        return await _crudServices.Update(br);


        //    }
        //    catch (Exception ex)
        //    {
        //        throw new Exception(ex.Message);

        //    }
        //}
    }
}
