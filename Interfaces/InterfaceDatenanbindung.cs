﻿using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interfaces
{
    public interface InterfaceDatenanbindung
    {
        public void HoleTexte();

        public DataRow GibNächsteZeile(Boolean zufällig);
    }
}
