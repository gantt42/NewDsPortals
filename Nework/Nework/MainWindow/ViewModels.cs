﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nework.Gui.ViewModels
{
    public class MainWindowViewModel
    {
        public WorldTabViewModel WorldViewModel { get; } = new WorldTabViewModel();
    }
}