﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfApp10
{
    internal class Obraz
    {
        public string UrlObrazka { get; set; }
        public int licznikPolubien { get; set; }

        public Obraz(string urlObrazka)
        {
            UrlObrazka = urlObrazka;
            licznikPolubien = 0;
        }
    }
}