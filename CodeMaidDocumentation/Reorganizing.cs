namespace CodeMaidDocumentation
{
    internal class Reorganizing
    {
        private bool _isInitialized;

        private void PrivateMethod()
        {
        }

        private int _field1;

        public void PublicMethod()
        {
        }

        public static void PublicStaticMethod()
        {
        }

        private int PrivateProperty
        {
            get { return _field2; }
            set { _field2 = value; }
        }

        private int _field2;

        public event PublicDelegate PublicEvent;

        public delegate void PublicDelegate(int one, int two);

        ~Reorganizing()
        {
        }

        public int PublicProperty
        {
            get { return _field1; }
            set { _field1 = value; }
        }

        public Reorganizing()
        {
            PrivateMethod();
        }

        public void PublicMethod2()
        {
        }

        private void InternalMethod()
        {
        }
    }
}