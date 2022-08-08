using ASPNetCoreDapper.Dto;
using ASPNetCoreDapper.Entities;

namespace ASPNetCoreDapper.Contracts
{
    public interface ICompanyRepository
    {
         Task<IEnumerable<Company>> GetCompanies();
         Task<Company> GetCompany(int id);
         Task<Company> CreateCompany(CompanyForCreationDto company);
         Task UpdateCompany(int id, CompanyForUpdateDto company);
         Task DeleteCompany(int id);
         Task<Company> GetCompanyByEmployeeId(int id);
         Task<Company> GetCompanyEmployeesMultipleResults(int id);
         Task<List<Company>> GetCompaniesEmployeesMultipleMapping();

    }
}
