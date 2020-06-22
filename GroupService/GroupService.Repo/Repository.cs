using AutoMapper;
using GroupService.Core.Dto;
using GroupService.Core.Interfaces.Repositories;
using System;
using System.Threading.Tasks;

namespace GroupService.Repo
{
    public class Repository : IRepository
    {
        private readonly ApplicationDbContext _context;
        private readonly IMapper _mapper;

        public Repository(ApplicationDbContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }
    }
}
