﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Model
{
    public class Reader
    {
        public string ReaderId { get; set; }
        public string ReaderName { get; set; }
        public DateTime TimeIn { get; set; }
        public DateTime TimeOut { get; set; }
        public int ReaderTypeId { get; set; }
        public int DepartmentId { get; set; }
        public int ClassId { get; set; }
        public string IdentityCard { get; set; }
        public string Gender { get; set; }
    }
}
