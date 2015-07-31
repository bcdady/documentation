namespace CodeMaidDocumentation
{
    internal class Regions
    {
        private int _field1;
        private int _field2;
        private bool _isInitialized;

        public Regions()
        {
            PrivateMethod();
        }

        ~Regions()
        {
        }

        public delegate void PublicDelegate(int one, int two);

        public event PublicDelegate PublicEvent;

        public int PublicProperty
        {
            get { return _field1; }
            set { _field1 = value; }
        }

        private int PrivateProperty
        {
            get { return _field2; }
            set { _field2 = value; }
        }

        public static void PublicStaticMethod()
        {
        }

        public void PublicMethod()
        {
        }

        public void PublicMethod2()
        {
        }

        private void InternalMethod()
        {
        }

        private void PrivateMethod()
        {
        }
    }
}