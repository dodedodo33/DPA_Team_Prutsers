﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DPA_Musicsheets.Models
{
    class Repetition
    {
        public Note Start { get; set; }
        public Note End { get; set; }
        public Note Alternative { get; set; }
    }
}