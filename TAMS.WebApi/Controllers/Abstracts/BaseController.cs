using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace TAMS.WebApi.Controllers.Abstracts
{
    public class BaseController : ControllerBase
    {
        protected readonly IMapper _mapper;
        private readonly ILogger<ControllerBase> _logger;

        public BaseController(IMapper mapper, ILogger<ControllerBase> logger)
        {
            _mapper = mapper;
            _logger = logger;
        }
    }
}
