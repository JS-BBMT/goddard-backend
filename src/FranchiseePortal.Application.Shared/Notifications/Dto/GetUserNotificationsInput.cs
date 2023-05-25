﻿using System;
using Abp.Notifications;
using FranchiseePortal.Dto;

namespace FranchiseePortal.Notifications.Dto
{
    public class GetUserNotificationsInput : PagedInputDto
    {
        public UserNotificationState? State { get; set; }

        public DateTime? StartDate { get; set; }

        public DateTime? EndDate { get; set; }
    }
}