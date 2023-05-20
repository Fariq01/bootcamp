namespace shapeClass;

abstract class shape
    {
        public float height;
        public float width;
        public float length;
        public float radius;
        public const float pi = 3.14F;


       public abstract float getVolume();

    }

class cube : shape
{

    public cube(float height, float width, float length)
    {
        this.height = height;
        this.width = width;
        this.length = length;
    }  

    public override float getVolume()
    {
        return height * width * length;
    }
}

class sphere : shape
{

    public sphere(float radius)
    {
        this.radius = radius;
    }

    public override float getVolume()
    {
        return ((3F / 4F) * pi * (radius * radius * radius));
    }
}




