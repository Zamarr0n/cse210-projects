using System;


public class Circle : Shape{
    private double _radius;


    public Circle (string _color , double radius):base(_color){
        _radius = radius;
    }
    public override double GetArea(){
        
        double pi = 3.14;
        double radius2 = _radius * _radius;
        return pi * radius2;
    }


}




