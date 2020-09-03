using System;

public interface Shape
{
    double getArea();
    double getPerimeter();
}

public abstract class AbstractShape : Shape
{
    public string colour;
    
    public AbstractShape(){
        
    }
    
    public abstract double getArea();
    public abstract double getPerimeter();

    AbstractShape(string colour){
        this.colour = colour;
    }
    
    public override string ToString(){
        return "colour=" + colour;
    }
}
public class Rectangle : AbstractShape
{
    public int length, breadth;
    
    public Rectangle(string colour, int length, int breadth){
        this.colour = colour;
        this.length = length;
        this.breadth = breadth;
    }
    
    public override double getArea(){
        return length * breadth;
    }
    
    public override double getPerimeter(){
        return 2 * (length + breadth);
    }
    
    public override string ToString(){
        return "Rectangle [colour=" + colour + ", length=" + length + ", breadth=" + breadth + "]";
    }
}

public class Circle : AbstractShape
{
    public int radius;
    
    public Circle(string colour, int radius){
        this.colour = colour;
        this.radius = radius;
    }
    
    public override double getArea(){
        return Math.PI * radius * radius;
    }
    
    public override double getPerimeter(){
        return 2 * Math.PI * radius;
    }
    
    public override string ToString(){
        return "Circle [colour=" + colour + ", radius=" + radius + "]";
    }
}

class ShapeDemo
{
    public static void printShape(Shape obj){
        Console.WriteLine("Area: "+ Math.Round(obj.getArea()) + ",Perimeter: " + Math.Round(obj.getPerimeter())); 
    }
    
    public static void getData(){
        string shape = Console.ReadLine();
        
        if(shape == "CIRCLE"){
            string colour = Console.ReadLine();
            int radius = Convert.ToInt32(Console.ReadLine());
            
            Circle circle = new Circle(colour, radius);
            printShape(circle);
        }
        else{
            string colour = Console.ReadLine();
            int length = Convert.ToInt32(Console.ReadLine());
            int breadth = Convert.ToInt32(Console.ReadLine());
            
            Rectangle rectangle = new Rectangle(colour, length, breadth);
            printShape(rectangle);
        }
    }
}
