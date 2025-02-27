﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Sopping.Domain.Common;

namespace Sopping.Domain;
public class Category : BaseDomainEntity
{
    public string Name { get; set; }
    public string Image { get; set; }
    public List<Clock> Clock { get; set; }
}
