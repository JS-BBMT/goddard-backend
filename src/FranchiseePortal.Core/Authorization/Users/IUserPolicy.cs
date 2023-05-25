﻿using System.Threading.Tasks;
using Abp.Domain.Policies;

namespace FranchiseePortal.Authorization.Users
{
    public interface IUserPolicy : IPolicy
    {
        Task CheckMaxUserCountAsync(int tenantId);
    }
}
