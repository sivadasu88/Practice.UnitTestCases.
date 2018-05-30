using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace LogingSystem
{
	public class LogFile : ILogFile
	{
		public void WriteMessage(string message)
		{
			StreamWriter sw = new StreamWriter(@"D:\Logs\logfile.txt");
			sw.WriteLine(message);
		}
		public void WriteException(string exmessage)
		{
			StreamWriter sw = new StreamWriter(@"D:\Logs\logfile.txt");
			sw.WriteLine(exmessage);
		}
	}
}
