namespace CodeMaidDocumentation
{
    internal class Joining
    {
        public Joining()
        {
            _isInitialized = true;
        }

        private bool _isInitialized;

        public bool IsInitialized
        {
            get
            {
                return _isInitialized;
            }
        }
    }
}