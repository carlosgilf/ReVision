﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace System.Windows.Forms
{
    public class ListViewItem
    {
        [Bridge.Name("SubItems")]
        public object[] SubItems;
    }
}
