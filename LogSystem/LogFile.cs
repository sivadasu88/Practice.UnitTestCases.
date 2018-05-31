using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogSystem
{
	public class LogFile : ILogFile
	{
		public string path = @"D:\LogFile\Log.txt";
		public void WriteExceptionMessage(string exmessage)
		{
			StreamWriter sw = new StreamWriter(path);
			sw.WriteLine(exmessage);
		}

		public void WriteMessage(string message)
		{
			StreamWriter sw = new StreamWriter(path,true);
			sw.WriteLine(message);
			
			//File.WriteAllText(path, message);
		}
	}
}
