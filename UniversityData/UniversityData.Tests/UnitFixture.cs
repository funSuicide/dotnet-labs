namespace UniversityData.Tests;
using System.Collections.Generic;
using UniversityData.Domain;

public class UnitFixture
{
    public List<Specialty> Specialties
    {
        get
        {
            var data = new List<Specialty>();
            for (var i = 0; i < 5; ++i)
            {
                data.Add(new Specialty());
            }
            data[0].Name = "���������� �����������";
            data[0].Code = "09.03.03";
            data[1].Name = "�������������� ������� � ����������";
            data[1].Code = "09.03.02";
            data[2].Name = "����������� � �������������� �������";
            data[2].Code = "09.03.01";
            data[3].Name = "���������� ���������� � �����������";
            data[3].Code = "01.03.02";
            data[4].Name = "�������������� ������������ ������������������ ������";
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
            }
            data[0].Name = "����";
            data[0].SupervisorNumber = "890918734";
            data[1].Name = "������� ������� � ���������";
            data[1].SupervisorNumber = "890918735";
            data[2].Name = "������� ������ ����������";
            data[2].SupervisorNumber = "890918736";
            data[3].Name = "������� �������������� ����������";
            data[3].SupervisorNumber = "890918737";
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
            }
            data[0].Name = "��������";
            data[0].Surname = "���������";
            data[0].Patronymic = "����������";
            data[0].Degree = "������ ������������� ����";
            data[0].Title = "���������";
            data[0].Position = "������";
            data[1].Name = "�������";
            data[1].Surname = "�����";
            data[1].Patronymic = "����������";
            data[1].Degree = "������ ����������� ����";
            data[1].Title = "���������";
            data[1].Position = "������";
            data[2].Name = "�����";
            data[2].Surname = "��������";
            data[2].Patronymic = "�������������";
            data[2].Degree = "�������� ����������� ����";
            data[2].Title = "������";
            data[2].Position = "������";
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
            }
            data[0].Name = "�������� ����������� � �����������";
            data[0].WorkersCount = 16;
            data[0].StudentsCount = 110;
            data[1].Name = "�������� ��������� � ����������";
            data[1].WorkersCount = 22;
            data[1].StudentsCount = 81;
            data[2].Name = "����������� ��������";
            data[2].WorkersCount = 11;
            data[2].StudentsCount = 65;
            data[3].Name = "���������-������������� ��������";
            data[3].WorkersCount = 30;
            data[3].StudentsCount = 200;
            data[4].Name = "�������� ���. �����������";
            data[4].WorkersCount = 22;
            data[4].StudentsCount = 62;
            data[5].Name = "�������� ���������� � �������������� ���������";
            data[5].WorkersCount = 16;
            data[5].StudentsCount = 70;
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
            }
            data[0].Specialty = Specialties[0];
            data[0].CountGroups = 8;
            data[1].Specialty = Specialties[0];
            data[1].CountGroups = 17;
            data[2].Specialty = Specialties[1];
            data[2].CountGroups = 6;
            data[3].Specialty = Specialties[1];
            data[3].CountGroups = 6;
            data[4].Specialty = Specialties[2];
            data[4].CountGroups = 9;
            data[5].Specialty = Specialties[2];
            data[5].CountGroups = 4;
            data[6].Specialty = Specialties[3];
            data[6].CountGroups = 8;
            data[7].Specialty = Specialties[3];
            data[7].CountGroups = 8;
            data[8].Specialty = Specialties[4];
            data[8].CountGroups = 10;
            data[9].Specialty = Specialties[4];
            data[9].CountGroups = 8;
            data[10].Specialty = Specialties[4];
            data[10].CountGroups = 8;
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
            }
            data[0].Number = "12345";
            data[0].Name = "��������� �����������";
            data[0].Address = "������";
            data[0].RectorData = Rectors[0];
            data[0].UniversityProperty = "�������������";
            data[0].ConstructionProperty = "�������������";
            data[1].Number = "56789";
            data[1].Name = "������";
            data[1].Address = "������";
            data[1].RectorData = Rectors[1];
            data[1].UniversityProperty = "�������������";
            data[1].ConstructionProperty = "�������������";
            data[2].Number = "45678";
            data[2].Name = "�����";
            data[2].Address = "������";
            data[2].RectorData = Rectors[2];
            data[2].UniversityProperty = "�������������";
            data[2].ConstructionProperty = "�����������";
            data[0].FacultiesData.AddRange(new[] { Faculties[0], Faculties[1], Faculties[2] });
            data[0].DepartmentsData.AddRange(new Department[] { Departments[0], Departments[1] });
            data[0].SpecialtyTable.AddRange(new SpecialtyTableNode[] { SpecialtyTableNodes[0], SpecialtyTableNodes[1], SpecialtyTableNodes[2] });
            data[1].FacultiesData.AddRange(new Faculty[] { Faculties[3], Faculties[4] });
            data[1].DepartmentsData.Add(Departments[2]);
            data[1].SpecialtyTable.AddRange(new SpecialtyTableNode[] { SpecialtyTableNodes[3], SpecialtyTableNodes[4], SpecialtyTableNodes[5], SpecialtyTableNodes[6] });
            data[2].FacultiesData.Add(Faculties[5]);
            data[2].DepartmentsData.Add(Departments[3]);
            data[2].SpecialtyTable.AddRange(new SpecialtyTableNode[] { SpecialtyTableNodes[7], SpecialtyTableNodes[8], SpecialtyTableNodes[9], SpecialtyTableNodes[10] });
            data[0].SpecialtyTable[0].TableNodeUniversity = data[0];
            data[0].SpecialtyTable[1].TableNodeUniversity = data[0];
            data[0].SpecialtyTable[2].TableNodeUniversity = data[0];
            data[1].SpecialtyTable[0].TableNodeUniversity = data[1];
            data[1].SpecialtyTable[1].TableNodeUniversity = data[1];
            data[1].SpecialtyTable[2].TableNodeUniversity = data[1];
            data[1].SpecialtyTable[3].TableNodeUniversity = data[1];
            data[2].SpecialtyTable[0].TableNodeUniversity = data[2];
            data[2].SpecialtyTable[1].TableNodeUniversity = data[2];
            data[2].SpecialtyTable[2].TableNodeUniversity = data[2];
            data[2].SpecialtyTable[3].TableNodeUniversity = data[2];
            return data;
        }
    }
}