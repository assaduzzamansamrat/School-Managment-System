﻿using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolManagementRepository
{
    public class SchoolDBContext: DbContext
    {
        public DbSet<Student> Students { get; set; }
    }
}