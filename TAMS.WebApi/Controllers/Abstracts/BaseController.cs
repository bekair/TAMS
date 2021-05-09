using AutoMapper;
using Microsoft.AspNetCore.Mvc;

namespace TAMS.WebApi.Controllers.Abstracts
{
    public class BaseController : ControllerBase
    {
        protected readonly IMapper _mapper;

        public BaseController(IMapper mapper)
        {
            _mapper = mapper;
        }
    }
}
