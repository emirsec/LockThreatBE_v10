﻿using System.Threading.Tasks;
using Abp.Dependency;

namespace Lockthreat.MultiTenancy.Accounting
{
    public interface IInvoiceNumberGenerator : ITransientDependency
    {
        Task<string> GetNewInvoiceNumber();
    }
}