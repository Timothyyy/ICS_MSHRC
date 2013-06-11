using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SQLite;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace ICS_MSHRC
{
    [SQLiteFunction(Arguments = 1, FuncType = FunctionType.Scalar, Name = "ToUpper")]
    public class SQLiteToUpper : SQLiteFunction
    {
        public override object Invoke(object[] args)
        {
            var column = /*System.Threading.Thread.CurrentThread.CurrentCulture.TextInfo.ToUpper(*/args[0].ToString().ToUpper();
            return column;
        }
    }

    public static class DBProvider
    {
        public class Student
        {
            public Student(string fullName, string sex, string address, string phone, string email, string birth, string education, string medical, string nationality, string hobby, bool dormitory, string group, string other)
            {
                FullName = fullName;
                Sex = sex;
                Address = address;
                Phone = phone;
                Email = email;
                Birth = birth;
                Education = education;
                Medical = medical;
                Nationality = nationality;
                Hobby = hobby;
                Dormitory = dormitory;
                Group = group;
                Other = other;
            }

            public Student(DataGridViewCellCollection studentInfo)
            {
                FullName = studentInfo[1].Value.ToString();
                Sex = studentInfo[2].Value.ToString();
                Address = studentInfo[3].Value.ToString();
                Phone = studentInfo[4].Value.ToString();
                Email = studentInfo[5].Value.ToString();
                Birth = studentInfo[6].Value.ToString();
                Education = studentInfo[7].Value.ToString();
                Medical = studentInfo[8].Value.ToString();
                Nationality = studentInfo[9].Value.ToString();
                Hobby = studentInfo[10].Value.ToString();
                Dormitory = (bool)studentInfo[11].Value;
                Group = studentInfo[12].Value.ToString();
                Other = studentInfo[13].Value.ToString();
            }

            public string FullName { get; set; }
            public string Sex { get; set; }
            public string Address { get; set; }
            public string Phone { get; set; }
            public string Email { get; set; }
            public string Birth { get; set; }
            public string Education { get; set; }
            public string Medical { get; set; }
            public string Nationality { get; set; }
            public string Hobby { get; set; }
            public bool Dormitory { get; set; }
            public string Group { get; set; }
            public string Other { get; set; }
        }

        public class Instructor
        {
            public Instructor(string fullName, string sex, string address, string phone, string email, string education, string department, string post, string start, string other)
            {
                FullName = fullName;
                Sex = sex;
                Address = address;
                Phone = phone;
                Email = email;
                Education = education;
                Department = department;
                Post = post;
                Start = start;
                Other = other;
            }

            public Instructor(DataGridViewCellCollection instructorInfo)
            {
                FullName = instructorInfo[1].Value.ToString();
                Sex = instructorInfo[2].Value.ToString();
                Address = instructorInfo[3].Value.ToString();
                Phone = instructorInfo[4].Value.ToString();
                Email = instructorInfo[5].Value.ToString();
                Education = instructorInfo[6].Value.ToString();
                Department = instructorInfo[7].Value.ToString();
                Post = instructorInfo[8].Value.ToString();
                Start = instructorInfo[9].Value.ToString();
                Other = instructorInfo[10].Value.ToString();
            }

            public string FullName { get; set; }
            public string Sex { get; set; }
            public string Address { get; set; }
            public string Phone { get; set; }
            public string Email { get; set; }
            public string Education { get; set; }
            public string Department { get; set; }
            public string Post { get; set; }
            public string Start { get; set; }
            public string Other { get; set; }
        }

        public class Group
        {
            public Group(string code, string specialty, string studyForm, string curator)
            {
                Code = code;
                Specialty = specialty;
                StudyForm = studyForm;
                Curator = curator;
            }

            public Group(DataGridViewCellCollection groupInfo)
            {
                Code = groupInfo[1].Value.ToString();
                Specialty = groupInfo[2].Value.ToString();
                StudyForm = groupInfo[3].Value.ToString();
                Curator = groupInfo[4].Value.ToString();
            }

            public string Code { get; set; }
            public string Specialty { get; set; }
            public string StudyForm { get; set; }
            public string Curator { get; set; }
        }

        public class Schedule
        {
            public Schedule(string subject, string group, string instructor, string day, int pair, string week)
            {
                Subject = subject;
                Group = group;
                Instructor = instructor;
                Day = day;
                Pair = pair;
                Week = week;
            }

            public string Subject { get; set; }
            public string Group { get; set; }
            public string Instructor { get; set; }
            public string Day { get; set; }
            public int Pair { get; set; }
            public string Week { get; set; }
        }

        #region SQL parameters

        private const string Studparam =
            "(Name, Sex, Address, Phone, Email, Birth, Education, Medical, Nationality, Hobby, Dormitory, GroupId, Other)"
            + " values(@1, @2, @3, @4, @5, @6, @7, @8, @9, @10, @11, (select Id from Groups where Code = @12), @13)";

        private const string Studset =
            "Name=@1, Sex=@2, Address=@3, Phone=@4, Email=@5, Birth=@6, Education=@7, Medical=@8,"
            +
            " Nationality=@9, Hobby=@10, Dormitory=@11, GroupId=(select Id from Groups where Code = @12), Other=@13 where Id=@14";

        private const string Instparam =
            "(Name, Sex, Address, Phone, Email, Education, DepartmentId, Post, Start, Other)"
            + " values(@1, @2, @3, @4, @5, @6, (select Id from Departments where Name = @7), @8, @9, @10)";

        private const string Instset = "Name=@1, Sex=@2, Address=@3, Phone=@4, Email=@5, Education=@6," +
                                       " DepartmentId=(select Id from Departments where Name = @7), Post=@8, Start=@9, Other=@10 where Id=@11";

        private const string Schedparam = "(IdSub, IdGroup, IdInst, Day, Pair, Week)"
                                          +
                                          " values((select Id from Subjects where Name=@1), (select Id from Groups where Code=@2), (select Id from Instructors where Name=@3), @4, @5, @6)";

        private const string Schedset = "IdSub=(select Id from Subjects where Name=@1), IdGroup=(select Id from Groups where Code=@2), IdInst=(select Id from Instructors where Name=@3), " +
            "Day=@4, Pair=@5, Week=@6 where Id=@7";

        #endregion

        private static readonly string ConnectionString = @"Data Source=C:\Users\Тимми\Desktop\MSHRC.db;foreign keys=True";
        //"Data Source=" + System.IO.Directory.GetCurrentDirectory() + "\\MSHRC.db;foreign keys=True";
        
        public static DataTable Students()
        {
            using (var conn = new SQLiteConnection(ConnectionString))
            {
                conn.Open();
                var cmd = new SQLiteCommand("select * from StudentsView", conn);
                var da = new SQLiteDataAdapter(cmd);
                var table = new DataTable();
                da.Fill(table);
                return table;
            }
        }

        public static DataTable Students(string faculty)
        {
            using (var conn = new SQLiteConnection(ConnectionString))
            {
                conn.Open();
                var cmd = new SQLiteCommand(string.Format("select * from StudentsView where [Группа] in" + 
                    " (select Code from Groups where SpecialtyId in (select Id from Specialties where Faculty = '{0}'))", faculty), conn);
                var da = new SQLiteDataAdapter(cmd);
                var table = new DataTable();
                da.Fill(table);
                return table;
            }
        }

        public static DataTable Students(int specialty)
        {
            using (var conn = new SQLiteConnection(ConnectionString))
            {
                conn.Open();
                var cmd = new SQLiteCommand(string.Format("select * from StudentsView where [Группа] in" +
                    " (select Code from Groups where SpecialtyId = {0})", specialty), conn);
                var da = new SQLiteDataAdapter(cmd);
                var table = new DataTable();
                da.Fill(table);
                return table;
            }
        }

        public static DataTable Instructors()
        {
            using (var conn = new SQLiteConnection(ConnectionString))
            {
                conn.Open();
                var cmd = new SQLiteCommand("select * from InstructorsView", conn);
                var da = new SQLiteDataAdapter(cmd);
                var table = new DataTable();
                da.Fill(table);
                return table;
            }
        }

        public static DataTable Instructors(int department)
        {
            using (var conn = new SQLiteConnection(ConnectionString))
            {
                conn.Open();
                var cmd = new SQLiteCommand(string.Format("select * from InstructorsView where [Кафедра] =" +
                    " (select Name from Departments where Id = {0})", department), conn);
                var da = new SQLiteDataAdapter(cmd);
                var table = new DataTable();
                da.Fill(table);
                return table;
            }
        }

        public static DataTable Groups()
        {
            using (var conn = new SQLiteConnection(ConnectionString))
            {
                conn.Open();
                var cmd = new SQLiteCommand("select * from GroupsView", conn);
                var da = new SQLiteDataAdapter(cmd);
                var table = new DataTable();
                da.Fill(table);
                return table;
            }
        }

        public static DataTable Groups(string faculty)
        {
            using (var conn = new SQLiteConnection(ConnectionString))
            {
                conn.Open();
                var cmd = new SQLiteCommand(string.Format("select * from GroupsView where [Специальность] in" +
                    " (select Name from Specialties where Faculty = '{0}')", faculty), conn);
                var da = new SQLiteDataAdapter(cmd);
                var table = new DataTable();
                da.Fill(table);
                return table;
            }
        }

        public static DataTable Groups(int specialty)
        {
            using (var conn = new SQLiteConnection(ConnectionString))
            {
                conn.Open();
                var cmd = new SQLiteCommand(string.Format("select * from GroupsView where [Специальность] =" +
                    " (select Name from Specialties where Id = {0})", specialty), conn);
                var da = new SQLiteDataAdapter(cmd);
                var table = new DataTable();
                da.Fill(table);
                return table;
            }
        }

        public static DataTable Subjects()
        {
            using (var conn = new SQLiteConnection(ConnectionString))
            {
                conn.Open();
                var cmd = new SQLiteCommand("select * from SubjectsView", conn);
                var da = new SQLiteDataAdapter(cmd);
                var table = new DataTable();
                da.Fill(table);
                return table;
            }
        }

        public static DataTable Subjects(int department)
        {
            using (var conn = new SQLiteConnection(ConnectionString))
            {
                conn.Open();
                var cmd = new SQLiteCommand(string.Format("select * from SubjectsView where [Кафедра] =" +
                    " (select Name from Departments where Id = {0})", department), conn);
                var da = new SQLiteDataAdapter(cmd);
                var table = new DataTable();
                da.Fill(table);
                return table;
            }
        }

        public static DataTable Schedules(string group)
        {
            using (var conn = new SQLiteConnection(ConnectionString))
            {
                conn.Open();
                var cmd = new SQLiteCommand("select * from ScheduleView where [Группа]=@1", conn);
                cmd.Parameters.AddWithValue("@1", group);
                var da = new SQLiteDataAdapter(cmd);
                var table = new DataTable();
                da.Fill(table);
                return table;
            }
        }

        public static DataTable GroupCodes()
        {
            using (var conn = new SQLiteConnection(ConnectionString))
            {
                conn.Open();
                var cmd = new SQLiteCommand("select Code from Groups", conn);
                var da = new SQLiteDataAdapter(cmd);
                var table = new DataTable();
                da.Fill(table);
                return table;
            }
        }

        public static void AddStudent(Student student)
        {
            using (var conn = new SQLiteConnection(ConnectionString))
            {
                conn.Open();
                var cmd = new SQLiteCommand("insert into Students" + Studparam, conn);
                cmd.Parameters.AddWithValue("@1", student.FullName);
                cmd.Parameters.AddWithValue("@2", student.Sex);
                cmd.Parameters.AddWithValue("@3", student.Address);
                cmd.Parameters.AddWithValue("@4", student.Phone);
                cmd.Parameters.AddWithValue("@5", student.Email);
                cmd.Parameters.AddWithValue("@6", student.Birth);
                cmd.Parameters.AddWithValue("@7", student.Education);
                cmd.Parameters.AddWithValue("@8", student.Medical);
                cmd.Parameters.AddWithValue("@9", student.Nationality);
                cmd.Parameters.AddWithValue("@10", student.Hobby);
                cmd.Parameters.AddWithValue("@11", student.Dormitory);
                cmd.Parameters.AddWithValue("@12", student.Group);
                cmd.Parameters.AddWithValue("@13", student.Other);
                cmd.ExecuteNonQuery();
            }
        }

        public static void UpdateStudent(Student student, int id)
        {
            using (var conn = new SQLiteConnection(ConnectionString))
            {
                conn.Open();
                var cmd = new SQLiteCommand("update Students set " + Studset, conn);
                cmd.Parameters.AddWithValue("@1", student.FullName);
                cmd.Parameters.AddWithValue("@2", student.Sex);
                cmd.Parameters.AddWithValue("@3", student.Address);
                cmd.Parameters.AddWithValue("@4", student.Phone);
                cmd.Parameters.AddWithValue("@5", student.Email);
                cmd.Parameters.AddWithValue("@6", student.Birth);
                cmd.Parameters.AddWithValue("@7", student.Education);
                cmd.Parameters.AddWithValue("@8", student.Medical);
                cmd.Parameters.AddWithValue("@9", student.Nationality);
                cmd.Parameters.AddWithValue("@10", student.Hobby);
                cmd.Parameters.AddWithValue("@11", student.Dormitory);
                cmd.Parameters.AddWithValue("@12", student.Group);
                cmd.Parameters.AddWithValue("@13", student.Other);
                cmd.Parameters.AddWithValue("@14", id);
                cmd.ExecuteNonQuery();
            }
        }

        public static DataTable Departments()
        {
            using (var conn = new SQLiteConnection(ConnectionString))
            {
                conn.Open();
                var cmd = new SQLiteCommand("select Name from Departments", conn);
                var da = new SQLiteDataAdapter(cmd);
                var table = new DataTable();
                da.Fill(table);
                return table;
            }
        }

        public static void AddInstructor(Instructor instructor)
        {
            using (var conn = new SQLiteConnection(ConnectionString))
            {
                conn.Open();
                var cmd = new SQLiteCommand("insert into Instructors" + Instparam, conn);
                cmd.Parameters.AddWithValue("@1", instructor.FullName);
                cmd.Parameters.AddWithValue("@2", instructor.Sex);
                cmd.Parameters.AddWithValue("@3", instructor.Address);
                cmd.Parameters.AddWithValue("@4", instructor.Phone);
                cmd.Parameters.AddWithValue("@5", instructor.Email);
                cmd.Parameters.AddWithValue("@6", instructor.Education);
                cmd.Parameters.AddWithValue("@7", instructor.Department);
                cmd.Parameters.AddWithValue("@8", instructor.Post);
                cmd.Parameters.AddWithValue("@9", instructor.Start);
                cmd.Parameters.AddWithValue("@10", instructor.Other);
                cmd.ExecuteNonQuery();
            }
        }

        public static void UpdateInstructor(Instructor instructor, int id)
        {
            using (var conn = new SQLiteConnection(ConnectionString))
            {
                conn.Open();
                var cmd = new SQLiteCommand("update Instructors set " + Instset, conn);
                cmd.Parameters.AddWithValue("@1", instructor.FullName);
                cmd.Parameters.AddWithValue("@2", instructor.Sex);
                cmd.Parameters.AddWithValue("@3", instructor.Address);
                cmd.Parameters.AddWithValue("@4", instructor.Phone);
                cmd.Parameters.AddWithValue("@5", instructor.Email);
                cmd.Parameters.AddWithValue("@6", instructor.Education);
                cmd.Parameters.AddWithValue("@7", instructor.Department);
                cmd.Parameters.AddWithValue("@8", instructor.Post);
                cmd.Parameters.AddWithValue("@9", instructor.Start);
                cmd.Parameters.AddWithValue("@10", instructor.Other);
                cmd.Parameters.AddWithValue("@11", id);
                cmd.ExecuteNonQuery();
            }
        }

        public static DataTable Specialties()
        {
            using (var conn = new SQLiteConnection(ConnectionString))
            {
                conn.Open();
                var cmd = new SQLiteCommand("select Name from Specialties", conn);
                var da = new SQLiteDataAdapter(cmd);
                var table = new DataTable();
                da.Fill(table);
                return table;
            }
        }

        public static DataTable Curators()
        {
            using (var conn = new SQLiteConnection(ConnectionString))
            {
                conn.Open();
                var cmd = new SQLiteCommand("select Name from Instructors", conn);
                var da = new SQLiteDataAdapter(cmd);
                var table = new DataTable();
                da.Fill(table);
                return table;
            }
        }

        public static void AddGroup(Group group)
        {
            using (var conn = new SQLiteConnection(ConnectionString))
            {
                conn.Open();
                var cmd = new SQLiteCommand("insert into Groups(Code, SpecialtyId, StudyForm, Curator) values(@1," + 
                    " (select Id from Specialties where Name = @2), @3, (select Id from Instructors where Name = @4))", conn);
                cmd.Parameters.AddWithValue("@1", group.Code);
                cmd.Parameters.AddWithValue("@2", group.Specialty);
                cmd.Parameters.AddWithValue("@3", group.StudyForm);
                cmd.Parameters.AddWithValue("@4", group.Curator);
                cmd.ExecuteNonQuery();
            }
        }

        public static void UpdateGroup(Group group, int id)
        {
            using (var conn = new SQLiteConnection(ConnectionString))
            {
                conn.Open();
                var cmd = new SQLiteCommand("update Groups set Code=@1, SpecialtyId=(select Id from Specialties where Name=@2)," + 
                    " StudyForm=@3, Curator=(select Id from Instructors where Name=@4) where Id=@5", conn);
                cmd.Parameters.AddWithValue("@1", group.Code);
                cmd.Parameters.AddWithValue("@2", group.Specialty);
                cmd.Parameters.AddWithValue("@3", group.StudyForm);
                cmd.Parameters.AddWithValue("@4", group.Curator);
                cmd.Parameters.AddWithValue("@5", id);
                cmd.ExecuteNonQuery();
            }
        }

        public static void AddSubject(string name, int department)
        {
            using (var conn = new SQLiteConnection(ConnectionString))
            {
                conn.Open();
                var cmd = new SQLiteCommand("insert into Subjects(Name, IdDep) values(@1, @2)", conn);
                cmd.Parameters.AddWithValue("@1", name);
                cmd.Parameters.AddWithValue("@2", department);
                cmd.ExecuteNonQuery();
            }
        }

        public static void UpdateSubject(string subject, int department, int id)
        {
            using (var conn = new SQLiteConnection(ConnectionString))
            {
                conn.Open();
                var cmd = new SQLiteCommand("update Subjects set Name=@1, IdDep=@2 where Id=@3", conn);
                cmd.Parameters.AddWithValue("@1", subject);
                cmd.Parameters.AddWithValue("@2", department);
                cmd.Parameters.AddWithValue("@3", id);
                cmd.ExecuteNonQuery();
            }
        }

        public static void AddSchedule(Schedule schedule)
        {
            using (var conn = new SQLiteConnection(ConnectionString))
            {
                conn.Open();
                var cmd = new SQLiteCommand("insert into Schedule" + Schedparam, conn);
                cmd.Parameters.AddWithValue("@1", schedule.Subject);
                cmd.Parameters.AddWithValue("@2", schedule.Group);
                cmd.Parameters.AddWithValue("@3", schedule.Instructor);
                cmd.Parameters.AddWithValue("@4", schedule.Day);
                cmd.Parameters.AddWithValue("@5", schedule.Pair);
                cmd.Parameters.AddWithValue("@6", schedule.Week);
                cmd.ExecuteNonQuery();
            }
        }

        public static void UpdateSchedule(Schedule schedule, int id)
        {
            using (var conn = new SQLiteConnection(ConnectionString))
            {
                conn.Open();
                var cmd = new SQLiteCommand("update Schedule set " + Schedset, conn);
                cmd.Parameters.AddWithValue("@1", schedule.Subject);
                cmd.Parameters.AddWithValue("@2", schedule.Group);
                cmd.Parameters.AddWithValue("@3", schedule.Instructor);
                cmd.Parameters.AddWithValue("@4", schedule.Day);
                cmd.Parameters.AddWithValue("@5", schedule.Pair);
                cmd.Parameters.AddWithValue("@6", schedule.Week);
                cmd.Parameters.AddWithValue("@7", id);
                cmd.ExecuteNonQuery();
            }
        }

        public static DataTable Choice(string view)
        {
            using (var conn = new SQLiteConnection(ConnectionString))
            {
                conn.Open();
                var column = view == "Groups" ? "Code" : "Name";
                var cmd = new SQLiteCommand(string.Format("select {0} from {1}", column, view), conn);
                var da = new SQLiteDataAdapter(cmd);
                var table = new DataTable();
                da.Fill(table);
                return table;
            }
        }

        public static DataTable TodaySchedule(string column, string value, string week)
        {
            using (var conn = new SQLiteConnection(ConnectionString))
            {
                conn.Open();
                var str = DateTime.Now.ToString("dddd");
                str = str.Replace(str[0].ToString(), str[0].ToString().ToUpper());
                var cmd = new SQLiteCommand(string.Format("select [Пара], [Предмет], [Группа], [Преподаватель] from TodaySchedule where " +
                    "[{0}]='{1}' and [День]='{2}' and ([Неделя]='Всегда' or [Неделя]='{3}')", column, value, str, week), conn);
                var da = new SQLiteDataAdapter(cmd);
                var table = new DataTable();
                da.Fill(table);
                return table;
            }
        }

        public static void DeleteRow(string table, int id)
        {
            using (var conn = new SQLiteConnection(ConnectionString))
            {
                conn.Open();
                var cmd = new SQLiteCommand(string.Format("delete from {0} where Id={1}", table, id), conn);
                cmd.ExecuteNonQuery();
            }
        }

        public static DataTable Search(string tableName, string column, string value)
        {
            using (var conn = new SQLiteConnection(ConnectionString))
            {
                conn.Open();
                var cmd = new SQLiteCommand(string.Format("select * from {0} where ToUpper([{1}]) like ToUpper('%{2}%')", tableName, column, value), conn);
                var da = new SQLiteDataAdapter(cmd);
                var table = new DataTable();
                da.Fill(table);
                return table;
            }
        }

        public static DataTable Filter(string tableName, string SQL)
        {
            using (var conn = new SQLiteConnection(ConnectionString))
            {
                conn.Open();
                var cmd = new SQLiteCommand(string.Format("select * from {0} where {1}", tableName, SQL), conn);
                var da = new SQLiteDataAdapter(cmd);
                var table = new DataTable();
                da.Fill(table);
                return table;
            }
        }
    }                                           
}