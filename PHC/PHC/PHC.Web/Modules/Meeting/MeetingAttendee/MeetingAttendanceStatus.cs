﻿
using Serenity.ComponentModel;
using System.ComponentModel;

namespace PHC.Meeting
{
    [EnumKey("Meeting.MeetingAttendanceStatus")]
    public enum MeetingAttendanceStatus
    {
        [Description("Not Set")]
        NotSet = 0,
        [Description("Attended")]
        Attended = 1,
        [Description("Absent")]
        Absent = 2,
        [Description("Absent with Permission")]
        AbsentWithPermission = 3
    }
}