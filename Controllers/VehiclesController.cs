using System.Threading.Tasks;
using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using vega.Controllers.Resources;
using vega.Models;
using vega.Persistence;

namespace vega.Controllers
{
  [Route("/api/vehicles")]
  public class VehiclesController : Controller
  {
    private readonly IMapper mapper;
    private readonly VegaDbContext context;

    public VehiclesController(IMapper mapper, VegaDbContext context)
    {

      this.mapper = mapper;
      this.context = context;
    }

    [HttpPost]
    public async Task<IActionResult> CreateVehicleAsync([FromBody] VehicleResource vehicleResource)
    {
      if(!ModelState.IsValid){
        return BadRequest(ModelState);
      }

      var vehicle = mapper.Map<VehicleResource, Vehicle>(vehicleResource);
      vehicle.lastupdate  = System.DateTime.Now;

      context.Vehicles.Add(vehicle);
      await context.SaveChangesAsync();

      var result = mapper.Map<Vehicle, VehicleResource>(vehicle);
      return Ok(result);
    }

     [HttpPut("{id}")]
    public async Task<IActionResult> UpdateVehicleAsync(int id, [FromBody] VehicleResource vehicleResource)
    {
      if(!ModelState.IsValid){
        return BadRequest(ModelState);
      }

      var vehicle = await context.Vehicles.Include(v=> v.Features).SingleOrDefaultAsync(v=> v.Id ==id);

      mapper.Map<VehicleResource, Vehicle>(vehicleResource, vehicle);
      vehicle.lastupdate  = System.DateTime.Now;

      await context.SaveChangesAsync();

      var result = mapper.Map<Vehicle, VehicleResource>(vehicle);
      return Ok(result);
    }

    [HttpDelete("{id}")]
    public async Task<IActionResult> DeleteVehicle(int id)
    {

      var vehicle = await context.Vehicles.FindAsync(id);

      if (vehicle == null)
        return NotFound();

      context.Remove(vehicle);
      await context.SaveChangesAsync();
      return Ok(id);
    }


    [HttpGet("{id}")]
    public async Task<IActionResult> GetVehicle(int id)
    {
      var vehicle = await context.Vehicles.Include(v=> v.Features).SingleOrDefaultAsync(v=> v.Id ==id);

      if (vehicle == null)
        return NotFound();

      var vehicleResource = mapper.Map<Vehicle, VehicleResource>(vehicle);

      return Ok(vehicleResource);
    }

  }
}