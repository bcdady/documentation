using System;
using System.Security.AccessControl;
using System.Linq;
using System.Text;
using System.IO;

namespace CodeMaidDocumentation
{
    class Cleaning
    {
        #region Fields
        #endregion
        #region Methods
        void Method()
        {

            FileStream stream =   File.Create("test.txt" ,0,FileOptions.None,   new FileSecurity());


            stream.Write(new byte[] { 0x00, 0x02 }, 1, 1);   
        }
        #endregion
    }
}
