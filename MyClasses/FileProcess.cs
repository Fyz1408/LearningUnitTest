﻿namespace MyClasses
{
    public class FileProcess
    {
        public bool FileExits(string fileName)
        {

            if (string.IsNullOrEmpty(fileName))
            {
                throw new ArgumentNullException(nameof(fileName));
            }
            return File.Exists(fileName);
        }
    }
}