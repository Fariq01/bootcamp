namespace refClass;

    public class person
    {
        public int umur;
        public string nama;

        public person()
        {
            umur = 30;
            nama = "Udin";
        }

        public void identity(person obj)
        {
            obj.umur = 100;
            obj.nama = "iLHAM";
        }

        public void identity2(ref person obj)
        {
            obj.umur = 100;
            obj.nama = "iLHAM";
        }

    }
