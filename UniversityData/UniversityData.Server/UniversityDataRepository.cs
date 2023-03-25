﻿using UniversityData.Domain;

namespace UniversityData.Server;

public class UniversityDataRepository
{
    public List<Specialty> Specialties
    {
        get
        {
            var data = new List<Specialty>();
            for (var i = 0; i < 5; ++i)
            {
                data.Add(new Specialty());
                data[i].Id = i;
            }
            data[0].Name = "Прикладная информатика";
            data[0].Code = "09.03.03";
            data[1].Name = "Информационные системы и технологии";
            data[1].Code = "09.03.02";
            data[2].Name = "Информатика и вычислительная техника";
            data[2].Code = "09.03.01";
            data[3].Name = "Прикладная математика и информатика";
            data[3].Code = "01.03.02";
            data[4].Name = "Информационная безопасность автоматизированных систем";
            data[4].Code = "10.05.03";
            return data;
        }
    }

    public List<Department> Departments
    {
        get
        {
            var data = new List<Department>();
            for (var i = 0; i < 4; ++i)
            {
                data.Add(new Department());
                data[i].Id = i;
            }
            data[0].Name = "ГИиБ";
            data[0].SupervisorNumber = "890918734";
            data[0].UniversityId = 0;
            data[1].Name = "Кафедры алгебры и геометрии";
            data[1].SupervisorNumber = "890918735";
            data[1].UniversityId = 0;
            data[2].Name = "Кафедра высшей математики";
            data[2].SupervisorNumber = "890918736";
            data[2].UniversityId = 1;
            data[3].Name = "Кафедра информационных технологий";
            data[3].SupervisorNumber = "890918737";
            data[3].UniversityId = 2;
            return data;
        }
    }

    public List<Rector> Rectors
    {
        get
        {
            var data = new List<Rector>();
            for (var i = 0; i < 3; ++i)
            {
                data.Add(new Rector());
                data[i].Id = i;
            }
            data[0].Name = "Владимир";
            data[0].Surname = "Богатырев";
            data[0].Patronymic = "Дмитриевич";
            data[0].Degree = "Доктор экономических наук";
            data[0].Title = "Профессор";
            data[0].Position = "Ректор";
            data[0].UniversityiId = 0;
            data[1].Name = "Дмитрий";
            data[1].Surname = "Быков";
            data[1].Patronymic = "Евгеньевич";
            data[1].Degree = "Доктор технических наук";
            data[1].Title = "Профессор";
            data[1].Position = "Ректор";
            data[1].UniversityiId = 1;
            data[2].Name = "Вадим";
            data[2].Surname = "Ружников";
            data[2].Patronymic = "Александрович";
            data[2].Degree = "Кандидат технических наук";
            data[2].Title = "Доцент";
            data[2].Position = "Ректор";
            data[2].UniversityiId = 2;
            return data;
        }
    }

    public List<Faculty> Faculties
    {
        get
        {
            var data = new List<Faculty>();
            for (var i = 0; i < 6; ++i)
            {
                data.Add(new Faculty());
                data[i].Id = i;
            }
            data[0].Name = "Институт информатики и кибернетики";
            data[0].WorkersCount = 16;
            data[0].StudentsCount = 110;
            data[0].UniversityId = 0;
            data[1].Name = "Институт экономики и управления";
            data[1].WorkersCount = 22;
            data[1].StudentsCount = 81;
            data[1].UniversityId = 0;
            data[2].Name = "Юридический институт";
            data[2].WorkersCount = 11;
            data[2].StudentsCount = 65;
            data[2].UniversityId = 0;
            data[3].Name = "Социально-гумманитарный институт";
            data[3].WorkersCount = 30;
            data[3].UniversityId = 1;
            data[3].StudentsCount = 200;
            data[4].Name = "Институт доп. образования";
            data[4].WorkersCount = 22;
            data[4].StudentsCount = 62;
            data[4].UniversityId = 1;
            data[5].Name = "Институт двигателей и энергетических установок";
            data[5].WorkersCount = 16;
            data[5].StudentsCount = 70;
            data[5].UniversityId = 2;
            return data;
        }
    }

    public List<SpecialtyTableNode> SpecialtyTableNodes
    {
        get
        {
            var data = new List<SpecialtyTableNode>();
            for (var i = 0; i < 11; ++i)
            {
                data.Add(new SpecialtyTableNode());
                data[i].Id = i;
            }
            data[0].Specialty = Specialties[0];
            data[0].CountGroups = 8;
            data[0].UniversityId = 0;
            data[0].SpecialtyID = 0;
            data[1].Specialty = Specialties[0];
            data[1].CountGroups = 17;
            data[1].UniversityId = 0;
            data[1].SpecialtyID = 0;
            data[2].Specialty = Specialties[1];
            data[2].CountGroups = 6;
            data[2].UniversityId = 0;
            data[2].SpecialtyID = 1;
            data[3].Specialty = Specialties[1];
            data[3].CountGroups = 6;
            data[3].UniversityId = 1;
            data[3].SpecialtyID = 1;
            data[4].Specialty = Specialties[2];
            data[4].CountGroups = 9;
            data[4].UniversityId = 1;
            data[4].SpecialtyID = 2;
            data[5].Specialty = Specialties[2];
            data[5].CountGroups = 4;
            data[5].UniversityId = 1;
            data[5].SpecialtyID = 2;
            data[6].Specialty = Specialties[3];
            data[6].CountGroups = 8;
            data[6].UniversityId = 1;
            data[6].SpecialtyID = 3;
            data[7].Specialty = Specialties[3];
            data[7].CountGroups = 8;
            data[7].UniversityId = 2;
            data[7].SpecialtyID = 3;
            data[8].Specialty = Specialties[4];
            data[8].CountGroups = 10;
            data[8].UniversityId = 2;
            data[8].SpecialtyID = 4;
            data[9].Specialty = Specialties[4];
            data[9].CountGroups = 8;
            data[9].UniversityId = 2;
            data[9].SpecialtyID = 4;
            data[10].Specialty = Specialties[4];
            data[10].CountGroups = 8;
            data[10].UniversityId = 2;
            data[10].SpecialtyID = 4;
            return data;
        }
    }

    public List<University> Universities
    {
        get
        {
            var data = new List<University>();
            for (var i = 0; i < 3; ++i)
            {
                data.Add(new University());
                data[i].Id = i;
            }
            data[0].Number = "12345";
            data[0].Name = "Самарский университет";
            data[0].Address = "Самара";
            data[0].RectorData = Rectors[0];
            data[0].UniversityProperty = "муниципальная";
            data[0].ConstructionProperty = "муниципальная";
            data[0].RectorId = 0;
            data[1].Number = "56789";
            data[1].Name = "СамГТУ";
            data[1].Address = "Самара";
            data[1].RectorData = Rectors[1];
            data[1].UniversityProperty = "муниципальная";
            data[1].ConstructionProperty = "муниципальная";
            data[1].RectorId = 1;
            data[2].Number = "45678";
            data[2].Name = "ПГУТИ";
            data[2].Address = "Самара";
            data[2].RectorData = Rectors[2];
            data[2].UniversityProperty = "муниципальная";
            data[2].ConstructionProperty = "федеральная";
            data[2].RectorId = 2;
            data[0].FacultiesData.AddRange(new Faculty[] { Faculties[0], Faculties[1], Faculties[2] });
            data[0].DepartmentsData.AddRange(new Department[] { Departments[0], Departments[1] });
            data[0].SpecialtyTable.AddRange(new SpecialtyTableNode[] { SpecialtyTableNodes[0], SpecialtyTableNodes[1], SpecialtyTableNodes[2] });
            data[1].FacultiesData.AddRange(new Faculty[] { Faculties[3], Faculties[4] });
            data[1].DepartmentsData.Add(Departments[2]);
            data[1].SpecialtyTable.AddRange(new SpecialtyTableNode[] { SpecialtyTableNodes[3], SpecialtyTableNodes[4], SpecialtyTableNodes[5], SpecialtyTableNodes[6] });
            data[2].FacultiesData.Add(Faculties[5]);
            data[2].DepartmentsData.Add(Departments[3]);
            data[2].SpecialtyTable.AddRange(new SpecialtyTableNode[] { SpecialtyTableNodes[7], SpecialtyTableNodes[8], SpecialtyTableNodes[9], SpecialtyTableNodes[10] });
            return data;
        }
    }
}
