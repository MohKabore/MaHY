using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MaHY.API.Dtos;
using MaHY.API.Helpers;
using MaHY.API.Models;

namespace MaHY.API.Data
{
    public interface IEducNotesRepository
    {
        void Add<T>(T entity) where T : class;
        void Update<T>(T entity) where T : class;
        void Delete<T>(T entity) where T : class;
        void DeleteAll<T>(List<T> entities) where T : class;
        Task<bool> SaveAll();
         Task<User> GetUser(int id, bool isCurrentUser);
        // Task<PagedList<User>> GetUsers(UserParams userParams);
        // Task<IEnumerable<User>> GetChildren(int parentId);
        // Task<IEnumerable<User>> GetClassStudents(int classId);
        // Task<IEnumerable<Agenda>> GetClassAgenda(int classId, DateTime StartDate, DateTime EndDate);
        // Task<IEnumerable<Agenda>> GetClassAgendaTodayToNDays(int classId, int toNbDays);
        // Task<IEnumerable<Schedule>> GetClassSchedule(int classId);
        // Task<IEnumerable<ClassLevelSchedule>> GetClassLevelSchedule(int classLevelId);
        // Task<IEnumerable<CourseSkill>> GetCourseSkills(int courseId);
        // Task<Agenda> GetAgenda(int agendaId);
        // Task<Photo> GetPhoto(int id);
        // Task<Photo> GetMainPhotoForUser(int userId);
        // Task<Class> GetClass(int Id);
        // List<int> GetWeekDays(DateTime date);
        // Task<IEnumerable<Schedule>> GetScheduleDay(int classId, int day);
        // Task<Like> GetLike(int userId, int recipientId);
        // Task<bool> EmailExist(string email);
        // Task<bool> UserNameExist(string userName);


        // Task<bool> AddUserPreInscription(UserForRegisterDto userForRegister, int insertUserId);

        // Task<IEnumerable<User>> GetStudentsForClass(int classId);
        // Task<IEnumerable<Agenda>> GetClassAgenda(int classId);
        // Task<List<AgendaForListDto>> GetUserClassAgenda(int classId, DateTime startDate, DateTime endDate);
        // Task<IEnumerable<UserType>> getUserTypes();

        // //Task<List<coursClass>> GetTeacherCoursesAndClasses(int teacherId);
        // Task<Course> GetCourse(int Id);
        // Task<bool> SendEmail(EmailFormDto emailFormDto);
        // bool SendSms(List<string> phoneNumbers, string content);

        // Task<IEnumerable<City>> GetAllCities();
        // Task<IEnumerable<District>> GetAllGetDistrictsByCityIdCities(int id);

        // void AddInscription(int levelId, int userId);
        // void AddUserLink(int userId, int parentId);

        // Task<User> GetUserByEmail(string email);
        // Task<bool> SendResetPasswordLink(string email, string code);
        // Task<User> GetUserByCode(string code);
        // Task<User> GetSingleUser(string userName);
        // Task<List<UserEvalsDto>> GetUserGrades(int userId, int classId);
        // IEnumerable<ClassAgendaToReturnDto> GetAgendaListByDueDate(IEnumerable<Agenda> agendaItems);
        // // Task<IActionResult> GetTeacherSessions(int teacherId, int classId)

        // /////////////////////////////////////////////////////////////////////////////////////////////////////
        // /////////////////////////////// DATA FROM MOHAMED KABORE ////////////////////////////////////////////
        // /////////////////////////////////////////////////////////////////////////////////////////////////////
        // Task<IEnumerable<ClassType>> GetClassTypes();
        // Task<int> AddSelfRegister(User user, string roleName, bool sendLink, int currentUserId);
        // Task<List<string>> GetEmails();
        // Task<List<string>> GetUserNames();
        // Task<List<ClassLevel>> GetLevels();
        // Task sendOk(int userTypeId, int userId);
        // Task<List<UserSpaCodeDto>> ParentSelfInscription(int parentId, List<UserForUpdateDto> userToUpdate);

        // Task<int> GetAssignedChildrenCount(int parentId);
        // Task<bool> SaveProductSelection(int userPid, int userId,List<ServiceSelectionDto> products);

    }
}