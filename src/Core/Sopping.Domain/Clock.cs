using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Sopping.Domain.Common;

namespace Sopping.Domain;
public class Clock : BaseDomainEntity
{
    public string Name { get; set; }
    public string Description { get; set; }
    public long Price { get; set; }
    public string Image { get; set; }
    public Category Category { get; set; }
}
