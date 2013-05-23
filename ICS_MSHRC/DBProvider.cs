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
                var table = new DataTable();
                da.Fill(table);
                return table;
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
                var table = new DataTable();
                da.Fill(table);
                return table;
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
                var table = new DataTable();
                da.Fill(table);
                return table;
            }
        }

        public static DataTable Instructors()
        {
            using (var conn = new SQLiteConnection(connectionstring))
            {
                conn.Open();
                var cmd = new SQLiteCommand("select * from InstructorsView", conn);
                var da = new SQLiteDataAdapter(cmd);
                var table = new DataTable();
                da.Fill(table);
                return table;
            }
        }

        public static DataTable Subjects()
        {
            using (var conn = new SQLiteConnection(connectionstring))
            {
                conn.Open();
                var cmd = new SQLiteCommand("select Name from Subjects", conn);
                var da = new SQLiteDataAdapter(cmd);
                var table = new DataTable();
                da.Fill(table);
                return table;
            }
        }

        public static DataTable Instructors(int department)
        {
            using (var conn = new SQLiteConnection(connectionstring))
            {
                conn.Open();
                var cmd = new SQLiteCommand(string.Format("select * from InstructorsView where [Кафедра] = {0}", department), conn);
                var da = new SQLiteDataAdapter(cmd);
                var table = new DataTable();
                da.Fill(table);
                return table;
            }
        }

        public static DataTable Groups()
        {
            using (var conn = new SQLiteConnection(connectionstring))
            {
                conn.Open();
                var cmd = new SQLiteCommand("select Code from Groups", conn);
                var da = new SQLiteDataAdapter(cmd);
                var table = new DataTable();
                da.Fill(table);
                return table;
            }
        }
    }                                           
}
