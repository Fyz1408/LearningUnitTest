using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyClassesTest
{
    internal class TestConstants
    {
        public const string GOOD_FILE_NAME = @"C:\Windows\Regedit.exe";
        public const string BAD_FILE_NAME = @"C:\NotExists.txt";
        public const string EMPTY_FILE_FAIL_MSG = "The call to the FileExists() method NOT throw an ArgumentNullException and it SHOULD have";
    }
}
