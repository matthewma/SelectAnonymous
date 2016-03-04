using SelectAnonymous.DatabaseSpecific;
using SelectAnonymous.EntityClasses;
using SelectAnonymous.Linq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Solution
{
	class Program
	{
		//CREATE DATABASE SelectAnonymous

		//USE SelectAnonymous

		//CREATE TABLE Student(
		//id INT NOT NULL IDENTITY(1,1) PRIMARY KEY,
		//name nvarchar(127),
		//morningTeacherId int,
		//afternoonTeacherId int
		//);

		//CREATE TABLE Teacher(
		//id INT NOT NULL IDENTITY(1,1) PRIMARY KEY,
		//name nvarchar(127)
		//);

		//insert into Student values('Amy', 1, 2);
		//insert into Student values('Joe', 2, 2);
		//insert into Student values('Mike', 1, 1);

		//insert into teacher values('Mr Jones');
		//insert into teacher values('Mr Wang');

		static void Main(string[] args)
		{
			DataAccessAdapter adapter = new DataAccessAdapter(@"Data Source=127.0.0.1\fullserver;Initial Catalog=SelectAnonymous;UID=sa;Password=password;");
			LinqMetaData linq = new LinqMetaData(adapter);
			var query = from student in linq.Student
						join morningTeacher in linq.Teacher on student.MorningTeacherId equals morningTeacher.Id
						join afternoonTeacher in linq.Teacher on student.AfternoonTeacherId equals afternoonTeacher.Id
						select new
						{
							student = student,
							morningTeacher = morningTeacher,
							afternoonTeacher = afternoonTeacher,
						};
			var result = query
				.Select(c => new { studentId = c.student.Id, morningTeacherId = c.morningTeacher.Id, afternoonTeacherId = c.afternoonTeacher.Id })
				.ToList();

			//This should be false 
			Console.WriteLine(result[0].studentId == result[0].afternoonTeacherId);

			Console.ReadKey();

		}

		//This is the profiler outputs
		//exec sp_executesql N'SELECT [LPA_L1].[Id] AS [studentId], [LPA_L1].[Id] AS [morningTeacherId], [LPA_L1].[Id] AS [afternoonTeacherId] FROM (SELECT [LPA_L3].[afternoonTeacherId] AS [AfternoonTeacherId], [LPA_L3].[id] AS [Id], [LPA_L3].[morningTeacherId] AS [MorningTeacherId], [LPA_L3].[name] AS [Name], @p2 AS [LPFA_8], [LPA_L4].[id] AS [Id0], [LPA_L4].[name] AS [Name1], @p4 AS [LPFA_9], [LPA_L5].[id] AS [Id2], [LPA_L5].[name] AS [Name3], @p6 AS [LPFA_10] FROM (( [SelectAnonymous].[dbo].[Student] [LPA_L3]  INNER JOIN [SelectAnonymous].[dbo].[Teacher] [LPA_L4]  ON  [LPA_L3].[morningTeacherId] = [LPA_L4].[id]) INNER JOIN [SelectAnonymous].[dbo].[Teacher] [LPA_L5]  ON  [LPA_L3].[afternoonTeacherId] = [LPA_L5].[id])) [LPA_L1]',N'@p2 int,@p4 int,@p6 int',@p2=1,@p4=1,@p6=1


		//public class STT
		//{
		//	public StudentEntity student;
		//	public TeacherEntity morningTeacher;
		//	public TeacherEntity afternoonTeacher;
		//}
	}
}
