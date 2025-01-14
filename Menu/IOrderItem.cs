﻿using System;
using System.Collections.Generic;
using System.Text;
/* IOrderItem.cs
 * Author: Anthony Garvalena
 */

namespace DinoDiner.Menu
{

    public interface IOrderItem
    {

        double Price { get; }

        string Description { get; }

        string[] Special { get; }
    }
}
