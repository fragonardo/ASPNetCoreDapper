using ASPNetCoreDapper.Dto;
using ASPNetCoreDapper.Entities;

namespace ASPNetCoreDapper.Contracts
{
    public interface ICompanyRepository
    {
        public Task<IEnumerable<Company>> GetCompanies();
        public Task<Company> GetCompany(int id);
        public Task<Company> CreateCompany(CompanyForCreationDto company);
    }
}
