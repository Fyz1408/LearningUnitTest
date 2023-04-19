using MyClasses;

namespace MyClassesTest;

    [TestClass]
    public class FileProcessTest
    {
        [TestMethod]
        public void FileNameDoesExist()
        {
        // Arrange
        FileProcess fp = new();
        string fileName = TestConstants.GOOD_FILE_NAME;
        bool fromCall;

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

        // Act
        fromCall = fp.FileExits(fileName);

        // Assert
        Assert.Fail(TestConstants.EMPTY_FILE_FAIL_MSG);
        }
    }