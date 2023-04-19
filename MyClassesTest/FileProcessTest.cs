using MyClasses;

namespace MyClassesTest;

    [TestClass]
    public class FileProcessTest
    {
        public TestContext? TestContext { get; set; }
        
        [TestMethod]
        public void FileNameDoesExist()
        {
        // Arrange
        FileProcess fp = new();
        string fileName = TestConstants.GOOD_FILE_NAME;
        bool fromCall;
        
        // Add messages to testoutput
        TestContext.WriteLine($"Checking for file '{TestConstants.GOOD_FILE_NAME}'");

        // Act
        fromCall = fp.FileExits(fileName);

        // Assert
        Assert.IsTrue(fromCall);

        }

        [TestMethod]
        public void FileNameDoesNotExist()
        {
        // Arrange
        FileProcess fp = new();
        string fileName = TestConstants.BAD_FILE_NAME;
        bool fromCall;

        // Add messages to testoutput
        TestContext.WriteLine($"Checking for file '{TestConstants.BAD_FILE_NAME}'");

        // Act
        fromCall = fp.FileExits(fileName);

        // Assert
        Assert.IsFalse(fromCall);

    }
        [TestMethod]
        public void FileNameNullOrEmpty_UsingTryCatch_ShouldThrowArgumentNullException()
        {
        // Arrange
        FileProcess fp;
        string fileName = string.Empty;
        //string fileName = @"C:\Windows\Regedit.exe";
        bool fromCall = false;

        try
        {
            // Act
            fp = new();

            // Add messages to testoutput
            TestContext.WriteLine($"Checking for file '{TestConstants.EMPTY_FILE_MSG}'");

            fromCall = fp.FileExits(fileName);

            // Assert
            Assert.Fail(TestConstants.EMPTY_FILE_FAIL_MSG);
        }
           catch (ArgumentNullException) { 
            // Assert
            Assert.IsFalse(fromCall); 
        }
        }
        [TestMethod]
        [ExpectedException(typeof(ArgumentNullException))]
        public void FileNameNullOrEmpty_UsingExpectedExceptionAttribute()
        {
        // Arrange
        FileProcess fp = new();
        string fileName = string.Empty;
        bool fromCall;

        // Add messages to testoutput
        TestContext.WriteLine($"Checking for file '{TestConstants.EMPTY_FILE_MSG}'");

        // Act
        fromCall = fp.FileExits(fileName);

        // Assert
        Assert.Fail(TestConstants.EMPTY_FILE_FAIL_MSG);
        }
    }