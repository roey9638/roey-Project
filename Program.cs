using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using Newtonsoft.Json;
using System.Text.Json;

namespace IO_Files_And_Directories
{
    class Program
    {
        static void Main(string[] args)
        {
            IO_Files_And_Directories io = new IO_Files_And_Directories();

            #region Qst 01
            //io.Qst01();
            #endregion

            #region Qst 02
            //io.Qst02();
            #endregion

            #region Qst 03
            //io.Qst03();
            #endregion

            #region Qst 04

            #endregion

            #region Qst 05
            //File.Create(@"myCSV.csv");
            //io.Qst05();
            #endregion         

            #region Qst 06
            //io.Qst06();
            #endregion
        }
    }

    class IO_Files_And_Directories
    {
        #region Qst 01
        public void Qst01()
        {
            var direct = Directory.GetLogicalDrives();
            var arr = Directory.GetDirectories(direct[0]);

            foreach (var item in arr.Take(10))
            {
                Console.WriteLine(item);
            }
        }
        #endregion

        #region Qst 02
        public void Qst02()
        {
            DirectoryInfo fileInfo = new DirectoryInfo(@"C:\Windows\");
            var bigFiles = fileInfo.GetFiles().OrderByDescending(file => file.Length).Take(5);
            foreach (var file in bigFiles)
            {
                Console.WriteLine($" Name: {file.Name} :: Latest Change: {file.LastWriteTime}");
            }

        }
        #endregion

        #region Qst 03
        public void Qst03()
        {
            Book b = new Book();
            var books = b.BooksList();
            var stringStudentJson = JsonConvert.SerializeObject(books);
            File.WriteAllText(@"C:\Users\roey1\Desktop\שעורי בית גמורים\Net. מתקדם\שיעור 11\IO Files And Directories\IO Files And Directories\bin\Debug\net5.0\myJasonFile", stringStudentJson);
        }
        #endregion

        #region Qst 04

        #endregion

        #region Qst 05
        public void Qst05()
        {
            Book b = new Book();
            string str = "";
            foreach (var book in b.BooksList())
            {
                str += book.ToCSV() + Environment.NewLine;
            }
            File.WriteAllText(@"C:\Users\roey1\Desktop\שעורי בית גמורים\Net. מתקדם\שיעור 11\IO Files And Directories\IO Files And Directories\bin\Debug\net5.0\myCSV" , str);
        }
        #endregion

        #region Qst 06
        public void Qst06()
        {
            List<Book> newBooks = new List<Book>();

            var jsonSTR = File.ReadAllText(@"myJasonFile");

            newBooks = System.Text.Json.JsonSerializer.Deserialize<List<Book>>(jsonSTR);
        }
        #endregion
    }
}
