﻿namespace UniversityData.Domain;
/// <summary>
/// Информация о факультете 
/// </summary>
public class Faculty
{
    /// <summary>
    /// ID
    /// </summary>
    public int Id { get; set; }
    /// <summary>
    /// Название факультета
    /// </summary>
    public string Name { get; set; } = string.Empty;
    /// <summary>
    /// Количество сотрудников факультета
    /// </summary>
    public int WorkersCount { get; set; }
    /// <summary>
    /// Количество студентов факультета
    /// </summary>
    public int StudentsCount { get; set; }
    /// <summary>
    /// Ссылка на обратную связь
    /// </summary>
    public University? University { get; set; }
}
