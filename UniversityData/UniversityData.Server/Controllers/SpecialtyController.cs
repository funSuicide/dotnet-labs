﻿using UniversityData.Domain;
using UniversityData.Server.Dto;
using Microsoft.AspNetCore.Mvc;
namespace UniversityData.Server.Controllers;

[Route("api/[controller]")]
[ApiController]
public class SpecialtyController : ControllerBase
{
    private readonly ILogger<SpecialtyController> _logger;
    private readonly IUniversityDataRepository _universityDataRepository;
    public SpecialtyController(ILogger<SpecialtyController> logger, IUniversityDataRepository universityDataRepository)
    {
        _logger = logger;
        _universityDataRepository = universityDataRepository;
    }

    [HttpGet]
    public IEnumerable<Specialty> Get()
    {
        _logger.LogInformation("Get all departments");
        return _universityDataRepository.Specialties;
    }

    [HttpGet("{id}")]
    public ActionResult<Specialty?> Get(int id)
    {
        var specialty = _universityDataRepository.Specialties.FirstOrDefault(specialty => specialty.Id == id);
        if (specialty == null)
        {
            _logger.LogInformation($"Not found specialty with id: {id}");
            return NotFound();
        }
        else
        {
            _logger.LogInformation($"Get specialty with id {id}");
            return Ok(specialty);
        }
    }

    [HttpPost]
    public void Post([FromBody] SpecialtyPostDto specialty)
    {
        _universityDataRepository.Specialties.Add(new Specialty()
        {
            Name = specialty.Name,
            Code = specialty.Code
        });
    }

    [HttpPut("{id}")]
    public IActionResult Put(int id, [FromBody] SpecialtyPostDto specialtyToPut)
    {
        var specialty = _universityDataRepository.Specialties.FirstOrDefault(specialty => specialty.Id == id);
        if (specialty == null)
        {
            _logger.LogInformation($"Not found specialty with id: {id}");
            return NotFound();
        }
        else
        {
            specialty.Name = specialtyToPut.Name;
            specialty.Code = specialtyToPut.Code;
            return Ok();
        }
    }

    [HttpDelete("{id}")]
    public IActionResult Delete(int id)
    {
        var specialty = _universityDataRepository.Specialties.FirstOrDefault(specialty => specialty.Id == id);
        if (specialty == null)
        {
            _logger.LogInformation($"Not found specialty with id: {id}");
            return NotFound();
        }
        else
        {
            _universityDataRepository.Specialties.Remove(specialty);
            return Ok();
        }
    }
}
