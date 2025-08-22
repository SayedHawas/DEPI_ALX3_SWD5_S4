using System;
using System.Collections.Generic;

namespace Day11CssDay1Lab;

public partial class Employee
{
    public int EmployeeId { get; set; }

    public string Name { get; set; } = null!;

    public string? Email { get; set; }

    public string JobTitle { get; set; } = null!;

    public decimal Salary { get; set; }

    public int? DepartmentId { get; set; }

    public virtual Department? Department { get; set; }
}
