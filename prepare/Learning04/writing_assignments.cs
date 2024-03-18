using System;

public class Writing_assignments : Assignment{
    private string _title;


    public Writing_assignments(string name, string topic, string title) : base(name,topic){
        _title = title;
    }
    public string GetWritingInformation(){
        return _title + " by " + GetName();
    }
}





