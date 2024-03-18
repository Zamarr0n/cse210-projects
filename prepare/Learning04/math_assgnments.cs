using System;

public class Math_assignments : Assignment{
    private string _textBookSection;
    private string _problems;


    public Math_assignments(string name , string topic, string title, string problem_name) : base (name, topic){
        _textBookSection = title;
        _problems = problem_name;
    }
public string GetHomeworkList(double section , string pages){
    return "section: " + section + "Problems: " + pages; 
}
}





