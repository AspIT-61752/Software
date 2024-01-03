namespace BIZ
{
    public class ClassBiz : Repository.ClassNotify
    {
        public ClassBiz()
        {
            CalckRes = new Repository.ClassCalckRes();
        }

        private Repository.ClassCalckRes _calckRes;

        public Repository.ClassCalckRes CalckRes
        {
            get => _calckRes;
            set
            {
                if (_calckRes == value) return;
                _calckRes = value;
                Notify("CalckRes");
            }
        }
    }
}