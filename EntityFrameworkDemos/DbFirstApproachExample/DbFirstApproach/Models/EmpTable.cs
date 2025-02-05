﻿using System;
using System.Collections.Generic;

namespace DbFirstApproach.Models;

public partial class EmpTable
{
    public int EmpId { get; set; }

    public string EmpName { get; set; } = null!;

    public string EmpAddress { get; set; } = null!;

    public decimal EmpSalary { get; set; }

    public int? DeptId { get; set; }

    public virtual DeptTable? Dept { get; set; }
}
