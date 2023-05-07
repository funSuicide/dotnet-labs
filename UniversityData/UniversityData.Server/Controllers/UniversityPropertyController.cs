﻿using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using UniversityData.Domain;
using UniversityData.Server.Dto;
using UniversityData.Server.Repository;
using static Microsoft.EntityFrameworkCore.DbLoggerCategory.Database;

namespace UniversityData.Server.Controllers;

/// <summary>
/// Контроллер факультета
/// </summary>
[Route("api/[controller]")]
[ApiController]
public class UniversityPropertyController : ControllerBase
{
    /// <summary>
    /// Хранение логгера
    /// </summary>
    private readonly ILogger<FacultyController> _logger;
    /// <summary>
    /// Хранение ContextFactory
    /// </summary>
    private readonly IDbContextFactory<UniversityDataDbContext> _contextFactory;
    /// <summary>
    /// Хранение маппера
    /// </summary>
    private readonly IMapper _mapper;
    public UniversityPropertyController(ILogger<FacultyController> logger, IDbContextFactory<UniversityDataDbContext> contextFactory, IMapper mapper)
    {
        _logger = logger;
        _contextFactory = contextFactory;
        _mapper = mapper;
    }
    /// <summary>
    /// GET-запрос на получение всех элементов коллекции
    /// </summary>
    /// <returns></returns>
    [HttpGet]
    public async Task<IEnumerable<UniversityProperty>> Get()
    {
        await using UniversityDataDbContext ctx = await _contextFactory.CreateDbContextAsync();
        _logger.LogInformation("Get all university properties");
        return ctx.UniversityProperties;
    }
    /// <summary>
    /// GET-запрос на получение элемента в соответствии с ID
    /// </summary>
    /// <param name="id"></param>
    /// <returns></returns>
    [HttpGet("{id}")]
    public async Task<ActionResult<UniversityProperty?>> Get(int id)
    {
        await using UniversityDataDbContext ctx = await _contextFactory.CreateDbContextAsync();
        var universityProperty = ctx.UniversityProperties.FirstOrDefault(universityProperty => universityProperty.Id == id);
        if (universityProperty == null)
        {
            _logger.LogInformation("Not found university property with id: {0}", id);
            return NotFound();
        }
        else
        {
            _logger.LogInformation("Get university property with id {0}", id);
            return Ok(universityProperty);
        }
    }
    /// <summary>
    /// POST-запрос на добавление нового элемента в коллекцию
    /// </summary>
    /// <param name="universityProperty"></param>
    [HttpPost]
    public async Task<ActionResult> Post([FromBody] UniversityPropertyDto universityProperty)
    {
        await using UniversityDataDbContext ctx = await _contextFactory.CreateDbContextAsync();
        await ctx.UniversityProperties.AddAsync(_mapper.Map<UniversityProperty>(universityProperty));
        await ctx.SaveChangesAsync();
        _logger.LogInformation("Add new university property");
        return Ok();
    }
    /// <summary>
    /// PUT-запрос на замену существующего элемента коллекции
    /// </summary>
    /// <param name="id"></param>
    /// <param name="universityPropertyToPut"></param>
    /// <returns></returns>
    [HttpPut("{id}")]
    public async Task<IActionResult> Put(int id, [FromBody] UniversityPropertyDto universityPropertyToPut)
    {
        await using UniversityDataDbContext ctx = await _contextFactory.CreateDbContextAsync();
        var universityProperty = ctx.UniversityProperties.FirstOrDefault(universityProperty => universityProperty.Id == id);
        if (universityProperty == null)
        {
            _logger.LogInformation("Not found university property with id: {0}", id);
            return NotFound();
        }
        else
        {
            _mapper.Map<UniversityPropertyDto, UniversityProperty>(universityPropertyToPut, universityProperty);
            await ctx.SaveChangesAsync();
            _logger.LogInformation("Update university property with id: {0}", id);
            return Ok();
        }
    }
    /// <summary>
    /// DELETE-запрос на удаление элемента из коллекции
    /// </summary>
    /// <param name="id"></param>
    /// <returns></returns>
    [HttpDelete("{id}")]
    public async Task<IActionResult> Delete(int id)
    {
        await using UniversityDataDbContext ctx = await _contextFactory.CreateDbContextAsync();
        var universityProperty = ctx.UniversityProperties.FirstOrDefault(universityProperty => universityProperty.Id == id);
        if (universityProperty == null)
        {
            _logger.LogInformation("Not found university property with id: {0}", id);
            return NotFound();
        }
        else
        {
            ctx.UniversityProperties.Remove(universityProperty);
            await ctx.SaveChangesAsync();
            _logger.LogInformation("Delete university property with id: {0}", id);
            return Ok();
        }
    }
}
