﻿using HomeNet.Data.Models;
using Iop.Homenode;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Linq.Expressions;
using Microsoft.EntityFrameworkCore;


namespace HomeNet.Data.Repositories
{
  /// <summary>
  /// Repository for identities hosted within this node's neighborhood.
  /// </summary>
  public class NeighborhoodIdentityRepository : IdentityRepository<NeighborIdentity>
  {
    /// <summary>
    /// Creates instance of the repository.
    /// </summary>
    /// <param name="context">Database context.</param>
    public NeighborhoodIdentityRepository(Context context)
      : base(context)
    {
    }
  }
}
