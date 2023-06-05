﻿namespace Repositories.Layer.Repositories.Abstracts
{
    public interface IRepositoryManager
    {
        ICourseRepository Course { get; }
        ICourseDetailRepository CourseDetail { get; }
        ICourseCalendarRepository CourseCalendar { get; }
        Task SaveAsync();
    }
}
