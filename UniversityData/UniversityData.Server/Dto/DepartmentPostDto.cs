﻿namespace UniversityData.Server.Dto;
/// <summary>
/// PostDto кафедры
/// </summary>
public class DepartmentPostDto
{
    /// <summary>
    /// Название кафедры
    /// </summary>
    public string Name { get; set; }
    /// <summary>
    /// Контактный телефон заведущего кафедрой
    /// </summary>
    public string SupervisorNumber { get; set; }
    /// <summary>
    /// ID университета
    /// </summary>
    public int UniversityId { get; set; }
}
