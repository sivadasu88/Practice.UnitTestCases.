using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Data;

namespace LogSystem
{
	public class FileSystemInformation
	{
		public string path = @"D:";
		public static string sourcepath = @"D:\NewMyFile\MyTest\";
		public  static string filename = "Test.txt";
		string sourcepathex = Path.Combine(sourcepath, filename);

		public void GetDriveInformation()
		{

			string sourcepathex = Path.Combine(sourcepath, filename);
			DriveInfo driveInfo = new DriveInfo(path);
			var res=driveInfo.AvailableFreeSpace;
			DirectoryInfo directory = new DirectoryInfo(sourcepath);

			if (directory.Exists)
			{
				Console.WriteLine("already exist");
			}
			else
			{
				directory.Create();
			}
			List<FileInfo> fileInfos = directory.GetFiles("*.*").ToList();
			//
			StringBuilder sb = new StringBuilder();
			foreach (var file in fileInfos)
			{
				Console.WriteLine(file.Name);
				sb.Append("");
				
			}
			List<DirectoryInfo> directoryInfos = directory.GetDirectories().ToList();
			foreach (var dir in directoryInfos)
			{
				Console.WriteLine(dir.Name);
			}



		}

		public void FileInformation()
		{
			if (Directory.Exists(sourcepathex))
			{
				Console.WriteLine("file exist");
			}
			else
			{
				Directory.CreateDirectory(sourcepathex);
			}
		}
		public List<string> GetFileNames()
		{
			List<string> lists = new List<string>();
			string[] infos = Directory.GetFiles(sourcepath);
			foreach (var item in infos)
			{
				lists.Add(item);
			}
			return lists;
		}
		public void WriteTextTofile()
		{
			string content = "Sravani|Siva|Dasu";
			File.WriteAllText(sourcepathex, content);
		}
		public DataTable ReadText()
		{
			DataTable dt = new DataTable();
			dt.Columns.Add("FirstName");
			dt.Columns.Add("SecondName");
			dt.Columns.Add("MiddleName");
			string[] lines = File.ReadAllLines(sourcepathex);
			foreach (var line in lines)
			{
				DataRow dr = dt.NewRow();
				//var row = line.Split('|');
				var row = line.Split(new string[] { "|","," }, StringSplitOptions.RemoveEmptyEntries);
				if (row.Count() >= 2)
				{
					dr["FirstName"] = row[0];
					dr["SecondName"] = row[1];
					dr["MiddelName"] = row[3];
					dt.Rows.Add(dr);
				}

			}

				return dt;
		}
	

		//public FileInfo[] GetFilesFromFolder(string path)
		//{
		//	string[] extensions = new[] { ".txt", ".docx", ".xlsx",".jpg" };
		//	DirectoryInfo dInfo = new DirectoryInfo(path);

		//	FileInfo[] files = dInfo.GetFiles()
		//	  .Where(f => extensions.Contains(f.Extension.ToLower()))
		//	  .ToArray();
		//	return files;
		//}


		//public bool PushDataToDb()
		//{
		//	FileTestTable ft = new FileTestTable();
		//	//EntityContext

		//	DataTable dt = ReadText();
		//	foreach (DataRow dr in dt.Rows)
		//	{
		//		ft.firstnaame = dr["firstname"];
		//		ft.secondname = dr["secondname"];
		//		ft.middlename = dr["middlename"];
		//		Context.filetesttable.add(ft);
		//		Context.savechanges();
		//		return true;


		//	}


		//}
	}
}
