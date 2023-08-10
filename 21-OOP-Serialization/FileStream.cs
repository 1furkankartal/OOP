namespace _21_OOP_Serialization
{
    internal class FileStream : Stream
    {
        private string path;
        private FileMode create;
        private FileAccess write;

        public FileStream(string path, FileMode create, FileAccess write)
        {
            this.path = path;
            this.create = create;
            this.write = write;
        }
    }
}