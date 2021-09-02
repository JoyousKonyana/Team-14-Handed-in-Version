﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BMW_ONBOARDING_SYSTEM.Models
{
    public partial class EmployeeCalendar
    {
        public EmployeeCalendar()
        {
            Employee = new HashSet<Employee>();
        }

        [Key]
        [Column("EmployeeCalendarID")]
        public int EmployeeCalendarId { get; set; }
        [StringLength(200)]
        public string EmployeeCalendarLink { get; set; }

        [InverseProperty("EmployeeCalendar")]
        public virtual ICollection<Employee> Employee { get; set; }
    }
}
