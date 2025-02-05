using System;
using System.Collections.Generic;

namespace DbFirstApproach.Models;

public partial class DeptTable
{
    public int DeptId { get; set; }

    public string DeptName { get; set; } = null!;

    public virtual ICollection<EmpTable> EmpTables { get; set; } = new List<EmpTable>();
}
