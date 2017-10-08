﻿namespace MvcForum.Core.Interfaces.Services
{
    using System;
    using System.Collections.Generic;
    using DomainModel.Entities;
    using MVCForum.Domain.DomainModel;

    public partial interface IGlobalPermissionForRoleService
    {
        GlobalPermissionForRole Add(GlobalPermissionForRole permissionForRole);
        void Delete(GlobalPermissionForRole permissionForRole);
        GlobalPermissionForRole CheckExists(GlobalPermissionForRole permissionForRole);
        Dictionary<Permission, GlobalPermissionForRole> GetAll(MembershipRole role);
        Dictionary<Permission, GlobalPermissionForRole> GetAll();
        GlobalPermissionForRole Get(Guid permId, Guid roleId);
        GlobalPermissionForRole Get(Guid permId);
        void UpdateOrCreateNew(GlobalPermissionForRole globalPermissionForRole);
    }
}
