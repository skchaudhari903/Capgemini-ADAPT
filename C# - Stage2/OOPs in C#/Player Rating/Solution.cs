using System;

public abstract class Player
{
    public string firstName, lastName;
    
    public Player(){
        
    }
    
    Player(string firstName, string lastName){
        this.firstName = firstName;
        this.lastName = lastName;
    }
    
    public string getName(){
        return firstName + " " + lastName;
    }
    
    public abstract int getRating();
}

class CricketPlayer : Player
{
    double averageRuns;
    
    public CricketPlayer(string firstName, string lastName, double averageRuns){
        this.firstName = firstName;
        this.lastName = lastName;
        this.averageRuns = averageRuns;
    }
    
    public override int getRating(){
        if(averageRuns > 55) return 7;
        else if(averageRuns > 50) return 6;
        else if(averageRuns > 40) return 5;
        else if(averageRuns > 30) return 3;
        else if(averageRuns > 20) return 2;
        else return 1;
    }
}

class FootballPlayer : Player{
    int goals;
    
    public FootballPlayer(string firstName, string lastName, int goals){
        this.firstName = firstName;
        this.lastName = lastName;
        this.goals = goals;
    }
    
    public override int getRating(){
        if(goals > 20) return 5;
        else if(goals > 15) return 4;
        else if(goals > 10) return 3;
        else if(goals > 5) return 2;
        else return 1;
    }
}