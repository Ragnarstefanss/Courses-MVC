using System.Collections.Generic;
using CoursesApi.Models.DTOModels;
using CoursesApi.Models.ViewModels;

namespace CoursesApi.Repositories
{
    public interface ICoursesRepository
    {
        IEnumerable<CoursesListItemDTO> GetCourses(string semsester);
        CourseDetailsDTO GetCourseById(int courseId);
        CourseDetailsDTO AddCourse(CourseViewModel newCourse);
        CourseDetailsDTO UpdateCourse(int courseId, CourseViewModel updatedCourse);
        IEnumerable<StudentDTO> GetStudentsByCourseId(int courseId);
        IEnumerable<StudentDTO> GetStudentsByWaitingList(int courseId);

        StudentDTO CheckIfInCourse(int courseId, StudentViewModel newStudent);
        StudentDTO CheckIfInWaitinglist(int courseId, StudentViewModel newStudent);
        StudentDTO AddStudentToWaitinglist(int courseId, StudentViewModel newStudent);
        StudentDTO AddStudentToCourse(int courseId, StudentViewModel newStudent);

        bool DeleteCourseById(int courseId);
    }
}


