using Interface;

static class Program {

	static void Main() 
    {
        //variabel tipe data interface 
        IDrive drive;
        IStop stop;

        drive = new car();
        //manggil method dari interface bukan class
        drive.drive();

        stop = new car();
        stop.stop();



        car car1 = new car();
        car1.drive();
        car1.stop();
        car1.turn();

        plane plane1 = new plane();
        plane1.drive();

        

    }

}