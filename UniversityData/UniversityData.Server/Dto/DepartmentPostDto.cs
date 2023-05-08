﻿namespace UniversityData.Server.Dto;
/// <summary>
/// Информация о кафедре
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
}
