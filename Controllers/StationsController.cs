using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using MTR.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace API_Test.Controllers
{

    public class StationsController : ControllerBase
    {
        private readonly IStationService _stationService;

        public StationsController(IStationService stationService)
        {
            _stationService = stationService;
        }
        [HttpPost]
        [Route("v1/station/getstation/{firstCoordinate}")]
        public async Task<IActionResult> GetStation(string firstCoordinate)
        {
            var result = await _stationService.GetStationBasedOnCoordinate(firstCoordinate);

            return Ok(result);
        }
    }
}
