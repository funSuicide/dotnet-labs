namespace UniversityData.Tests;
using UniversityData.Domain;
using System.Collections.Generic;

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
            data[0].SpecialtyName = "���������� �����������";
            data[0].SpecialtyCode = "09.03.03";
            data[1].SpecialtyName = "�������������� ������� � ����������";
            data[1].SpecialtyCode = "09.03.02";
            data[2].SpecialtyName = "����������� � �������������� �������";
            data[2].SpecialtyCode = "09.03.01";
            data[3].SpecialtyName = "���������� ���������� � �����������";
            data[3].SpecialtyCode = "01.03.02";
            data[4].SpecialtyName = "�������������� ������������ ������������������ ������";
            data[4].SpecialtyCode = "10.05.03";
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
            data[0].DepartmentName = "����";
            data[0].DepartmentSupervisorNumber = "890918734";
            data[1].DepartmentName = "������� ������� � ���������";
            data[1].DepartmentSupervisorNumber = "890918735";
            data[2].DepartmentName = "������� ������ ����������";
            data[2].DepartmentSupervisorNumber = "890918736";
            data[3].DepartmentName = "������� �������������� ����������";
            data[3].DepartmentSupervisorNumber = "890918737";
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
            data[0].RectorName = "��������";
            data[0].RectorSurname = "���������";
            data[0].RectorPatronymic = "����������";
            data[0].RectorDegree = "������ ������������� ����";
            data[0].RectorTitle = "���������";
            data[0].RectorPosition = "������";
            data[1].RectorName = "�������";
            data[1].RectorSurname = "�����";
            data[1].RectorPatronymic = "����������";
            data[1].RectorDegree = "������ ����������� ����";
            data[1].RectorTitle = "���������";
            data[1].RectorPosition = "������";
            data[2].RectorName = "�����";
            data[2].RectorSurname = "��������";
            data[2].RectorPatronymic = "�������������";
            data[2].RectorDegree = "�������� ����������� ����";
            data[2].RectorTitle = "������";
            data[2].RectorPosition = "������";
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
            data[0].FaculityName = "�������� ����������� � �����������";
            data[0].FaculityWorkersCount = 16;
            data[0].FaculityStudentsCount = 110;
            data[1].FaculityName = "�������� ��������� � ����������";
            data[1].FaculityWorkersCount = 22;
            data[1].FaculityStudentsCount = 81;
            data[2].FaculityName = "����������� ��������";
            data[2].FaculityWorkersCount = 11;
            data[2].FaculityStudentsCount = 65;
            data[3].FaculityName = "���������-������������� ��������";
            data[3].FaculityWorkersCount = 30;
            data[3].FaculityStudentsCount = 200;
            data[4].FaculityName = "�������� ���. �����������";
            data[4].FaculityWorkersCount = 22;
            data[4].FaculityStudentsCount = 62;
            data[5].FaculityName = "�������� ���������� � �������������� ���������";
            data[5].FaculityWorkersCount = 16;
            data[5].FaculityStudentsCount = 70;
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
            data[0].UniversityNumber = "12345";
            data[0].UniversityName = "��������� �����������";
            data[0].UniversityAddress = "������";
            data[0].UniversityRectorData = Rectors[0];
            data[0].UniversityProperty = "�������������";
            data[0].UniversityConstructionProperty = "�������������";
            data[1].UniversityNumber = "56789";
            data[1].UniversityName = "������";
            data[1].UniversityAddress = "������";
            data[1].UniversityRectorData = Rectors[1];
            data[1].UniversityProperty = "�������������";
            data[1].UniversityConstructionProperty = "�������������";
            data[2].UniversityNumber = "45678";
            data[2].UniversityName = "�����";
            data[2].UniversityAddress = "������";
            data[2].UniversityRectorData = Rectors[2];
            data[2].UniversityProperty = "�������������";
            data[2].UniversityConstructionProperty = "�����������";
            data[0].UniversityFacultiesData.AddRange(new[] { Faculties[0], Faculties[1], Faculties[2] });
            data[0].UniversityDepartmentsData.AddRange(new Department[] { Departments[0], Departments[1] });
            data[0].UniversitySpecialtyTable.AddRange(new SpecialtyTableNode[] { SpecialtyTableNodes[0], SpecialtyTableNodes[1], SpecialtyTableNodes[2] });
            data[1].UniversityFacultiesData.AddRange(new Faculty[] { Faculties[3], Faculties[4] });
            data[1].UniversityDepartmentsData.Add(Departments[2]);
            data[1].UniversitySpecialtyTable.AddRange(new SpecialtyTableNode[] { SpecialtyTableNodes[3], SpecialtyTableNodes[4], SpecialtyTableNodes[5], SpecialtyTableNodes[6] });
            data[2].UniversityFacultiesData.Add(Faculties[5]);
            data[2].UniversityDepartmentsData.Add(Departments[3]);
            data[2].UniversitySpecialtyTable.AddRange(new SpecialtyTableNode[] { SpecialtyTableNodes[7], SpecialtyTableNodes[8], SpecialtyTableNodes[9], SpecialtyTableNodes[10] });
            data[0].UniversitySpecialtyTable[0].TableNodeUniversity = data[0];
            data[0].UniversitySpecialtyTable[1].TableNodeUniversity = data[0];
            data[0].UniversitySpecialtyTable[2].TableNodeUniversity = data[0];
            data[1].UniversitySpecialtyTable[0].TableNodeUniversity = data[1];
            data[1].UniversitySpecialtyTable[1].TableNodeUniversity = data[1];
            data[1].UniversitySpecialtyTable[2].TableNodeUniversity = data[1];
            data[1].UniversitySpecialtyTable[3].TableNodeUniversity = data[1];
            data[2].UniversitySpecialtyTable[0].TableNodeUniversity = data[2];
            data[2].UniversitySpecialtyTable[1].TableNodeUniversity = data[2];
            data[2].UniversitySpecialtyTable[2].TableNodeUniversity = data[2];
            data[2].UniversitySpecialtyTable[3].TableNodeUniversity = data[2];
            return data;
        }
    }
}