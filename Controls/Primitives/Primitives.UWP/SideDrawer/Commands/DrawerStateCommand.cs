﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Windows.UI.Xaml.Media.Animation;

namespace Telerik.UI.Xaml.Controls.Primitives.SideDrawer.Commands
{
    internal class DrawerStateCommand : SideDrawerCommand
    {
         /// <summary>
        /// Determines whether the command can be executed against the provided parameter.
        /// </summary>
        public override bool CanExecute(object parameter)
        {
            return true;
        }

        /// <summary>
        /// Performs the core action given the provided parameter.
        /// </summary>
        public override void Execute(object parameter)
        {
            base.Execute(parameter);
        }
    }
}
