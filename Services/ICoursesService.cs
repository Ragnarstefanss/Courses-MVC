using System;
using System.Collections.Generic;
using CoursesApi.Models.DTOModels;
using CoursesApi.Models.ViewModels;

namespace CoursesApi.Services
{
    public interface ICoursesService
    {
        IEnumerable<CoursesListItemDTO> GetCourses(string semester);
        CourseDetailsDTO GetCourseById(int courseId);
        IEnumerable<StudentDTO> GetStudentsByCourseId(int courseId);
        IEnumerable<StudentDTO> GetStudentsByWaitingList(int courseId);
        CourseDetailsDTO AddCourse(CourseViewModel newCourse);
        CourseDetailsDTO UpdateCourse(int courseId, CourseViewModel updatedCourse);
        StudentDTO CheckIfInCourse(int courseId, StudentViewModel newStudent);
        StudentDTO CheckIfInWaitinglist(int courseId, StudentViewModel newStudent);
        StudentDTO AddStudentToWaitinglist(int courseId, StudentViewModel newStudent);
        StudentDTO AddStudentToCourse(int courseId, StudentViewModel newStudent);
        bool DeleteCourseById(int courseId);
    }
}
