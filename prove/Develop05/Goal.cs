using System;

public abstract class Goal{

    private string _type;
    private string _name;
    private string _description;
    private int _points;

    public Goal(string name, string description, string type, int points){
        _name = name;
        _description = description;
        _points = points;

        // Console.WriteLine($"{name} - {description} - points: {_points}");
    }
    public string GetType()
    {
        return _type;
    }
    public string GetName()
    {
        return _name;
    }
    public string GetDescription()
    {
        return _description;
    }
    public int GetPoints()
    {
        return _points;
    }


    // Methods
    public abstract void ListGoal(int i);
    public abstract string SaveGoal();
    public abstract string LoadGoal();
    public abstract void RecordGoalEvent(List<Goal> goals);

}