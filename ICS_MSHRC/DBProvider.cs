using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SQLite;
using System.Linq;
using System.Text;

namespace ICS_MSHRC
{
    static class DBProvider
    {
        private static readonly string connectionstring = @"Data Source=C:\Users\Тимми\Desktop\MSHRC.db";// + System.IO.Directory.GetCurrentDirectory() + "\\MSHRC.db";

        public static DataTable Students()
        {
            using (var conn = new SQLiteConnection(connectionstring))
            {
                conn.Open();
                var cmd = new SQLiteCommand("select * from StudentsView", conn);
                var da = new SQLiteDataAdapter(cmd);
                var ds = new DataSet();
                da.Fill(ds, "Students");
                return ds.Tables["Students"];
            }
        }

        public static DataTable Students(string faculty)
        {
            using (var conn = new SQLiteConnection(connectionstring))
            {
                conn.Open();
                var cmd = new SQLiteCommand(string.Format("select * from StudentsView where [Группа] in" + 
                    " (select Code from Groups where SpecialtyId in (select Id from Specialties where Faculty = '{0}'))", faculty), conn);
                var da = new SQLiteDataAdapter(cmd);
                var ds = new DataSet();
                da.Fill(ds, "Students");
                return ds.Tables["Students"];
            }
        }

        public static DataTable Students(int specialty)
        {
            using (var conn = new SQLiteConnection(connectionstring))
            {
                conn.Open();
                var cmd = new SQLiteCommand(string.Format("select * from StudentsView where [Группа] in" +
                    " (select Code from Groups where SpecialtyId = {0})", specialty), conn);
                var da = new SQLiteDataAdapter(cmd);
                var ds = new DataSet();
                da.Fill(ds, "Students");
                return ds.Tables["Students"];
            }
        }

        public static DataTable Instructors()
        {
            using (var conn = new SQLiteConnection(connectionstring))
            {
                conn.Open();
                var cmd = new SQLiteCommand("select * from InstructorsView", conn);
                var da = new SQLiteDataAdapter(cmd);
                var ds = new DataSet();
                da.Fill(ds, "Instructors");
                return ds.Tables["Instructors"];
            }
        }

        public static DataTable Subjects()
        {
            using (var conn = new SQLiteConnection(connectionstring))
            {
                conn.Open();
                var cmd = new SQLiteCommand("select Name from Subjects", conn);
                var da = new SQLiteDataAdapter(cmd);
                var ds = new DataSet();
                da.Fill(ds, "Subjects");
                return ds.Tables["Subjects"];
            }
        }
    }                                           
}
