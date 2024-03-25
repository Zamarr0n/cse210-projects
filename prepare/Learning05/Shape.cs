using System;
using System.Drawing;

//Abstract so the shared class work
public abstract class Shape{
    private string _color;

    public string GetColor(){
        return _color;
    }

    public Shape( string color){
        _color = color;
    }

// Class shared among each figure
// Abstract access given because it doesn´t return anything
    public abstract double GetArea();




}




