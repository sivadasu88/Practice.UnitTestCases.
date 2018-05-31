using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogSystem
{
	public interface ILogFile
	{
		void WriteMessage(string message);
		void WriteExceptionMessage(string exmessage);
	}
}
