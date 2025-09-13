using LibraryManagement.Models;
using LibraryManagement.Models.Repositories;
using System.Runtime.CompilerServices;

namespace LibraryManagement
{
    internal static class Program
    {
        public static MemberRepository memberRepository = new MemberRepository();
        public static BookRepository bookRepository = new BookRepository();
        public static string connectionString = "Server=localhost;Database=librarymanagementdb;Uid=root;Pwd=;";
        public static Home homeForm;
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            ApplicationConfiguration.Initialize();
            homeForm = new Home();
            Application.Run(homeForm);
        }
    }
}