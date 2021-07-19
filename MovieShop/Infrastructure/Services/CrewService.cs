using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ApplicationCore.Entities;
using ApplicationCore.Models.Response;
using ApplicationCore.RepositoryInterfaces;
using ApplicationCore.ServiceInterfaces;

namespace Infrastructure.Services
{
    public class CrewService : ICrewService
    {
        private readonly IAsyncRepository<Crew> _crewRepository;

        public CrewService(IAsyncRepository<Crew> crewRepository)
        {
            _crewRepository = crewRepository;
        }

        public async Task<IEnumerable<CrewResponseModel>> GetAllCrews()
        {
            var crews = await _crewRepository.ListAllAsync();

            var crewsList = new List<CrewResponseModel>();
            foreach (var crew in crews)
            {
                crewsList.Add(new CrewResponseModel { Gender = crew.Gender, Id = crew.Id, Name = crew.Name, ProfilePath = crew.ProfilePath, TmdbUrl = crew.TmdbUrl });
            }

            return crewsList;
        }

    }
}
