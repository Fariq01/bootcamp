using carClass;

car car1 = new car();

body body1 = new body(4);

car1.setBody(body1);
// Console.WriteLine(car1.getBody());
// car1.displayCar();

body bodyMobil = car1.getBody();

Console.WriteLine(bodyMobil);

