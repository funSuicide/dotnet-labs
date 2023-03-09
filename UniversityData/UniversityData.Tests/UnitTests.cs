namespace UniversityData.Tests;
using System.Linq;

public class UnitTests : IClassFixture<UnitFixture>
{
    private UnitFixture _fixture;
    public UnitTests(UnitFixture unitFixture)
    {
        _fixture = unitFixture;
    }
    /// <summary>
    /// ������ 1 - ������� ���������� � ��������� ����.
    /// </summary>
    [Fact]
    public void InformaionOfUniversity()
    {
        var result = (from university in _fixture.Universities
                      where university.UniversityNumber == "12345"
                      select university).ToList();
        Assert.Equal("��������� �����������", result[0].UniversityName);
    }
    /// <summary>
    /// ������ 2 - ������� ���������� � �����������, �������� � �������������� ������� ����.
    /// </summary>
    [Fact]
    public void InformaionOfStructure()
    {
        var result = (from university in _fixture.Universities
                      where (university.UniversityNumber == "45678")
                      select university).ToList();
        Assert.Equal(1, result[0].UniversityFacultiesData.Count());
        Assert.Equal(1, result[0].UniversityDepartmentsData.Count());
        Assert.Equal(4, result[0].UniversitySpecialtyTable.Count());
    }
    /// <summary>
    /// ������ 3 - ������� ���������� � ��� 5 ���������� �������������� (� ������������ ����������� �����).
    /// </summary>
    [Fact]
    public void TopFiveSpecialties()
    {
        var l = new List<string> { "10.05.03", "09.03.03", "09.03.02", "09.03.01", "01.03.02" };
        var result = (from specialtyNode in _fixture.SpecialtyTableNodes
                      group specialtyNode by specialtyNode.Specialty.SpecialtyCode into specialtyGroup
                      orderby specialtyGroup.Count() descending
                      select new
                      {
                          specialty = specialtyGroup.Key,
                          numRequests = specialtyGroup.Count()
                      }).Take(5).ToList();
        for (var i = 0; i < 5; i++)
            Assert.Equal(l[i], result[i].specialty);
    }
    /// <summary>
    /// ������ 4 - ������� ���������� � ����� � ������������ ����������� ������, ����������� �� ��������.
    /// </summary>
    [Fact]
    public void MaxCountDepartments()
    {
        var result = (from university in _fixture.Universities
                      where university.UniversityDepartmentsData.Count() == _fixture.Universities.Max(x => x.UniversityDepartmentsData.Count())
                      select university).ToList();
        Assert.Equal(1, result.Count);
    }
    /// <summary>
    /// ������ 5 - ������� ���������� � ����� � �������� �������������� ����������, � ���������� ����� � ����.
    /// </summary>
    [Fact]
    public void UniversityWithProperty()
    {
        var result = (from university in _fixture.Universities
                      where (university.UniversityProperty == "�������������")
                      where (university.UniversitySpecialtyTable.Sum(x => x.CountGroups) == 27)
                      select university).ToList();
        Assert.Equal(1, result.Count);
    }
    /// <summary>
    /// ������ 6 - ������� ���������� � ���������� �����������, ������, �������������� �� ������� ���� ������������� ���������� � ������������� ������.
    /// </summary>
    [Fact]
    public void CountDepartments()
    {
        var result = (from university in _fixture.Universities
                      group university by university.UniversityConstructionProperty into universityConstGroup
                      from universityPropGroup in (
                          from university in universityConstGroup
                          group university by university.UniversityProperty into universityPropGroup
                          select new { })
                      select new
                      {
                          faculties = universityConstGroup.Sum(x => x.UniversityFacultiesData.Count()),
                          departments = universityConstGroup.Sum(x => x.UniversityDepartmentsData.Count()),
                          specialities = universityConstGroup.Sum(x => x.UniversitySpecialtyTable.Count())
                      }
                          ).ToList();
        Assert.Equal(5, result[0].faculties);
        Assert.Equal(1, result[1].faculties);
        Assert.Equal(3, result[0].departments);
        Assert.Equal(1, result[1].departments);
        Assert.Equal(7, result[0].specialities);
        Assert.Equal(4, result[1].specialities);
    }
}