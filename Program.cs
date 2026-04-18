using System;
public interface ITalkable
{
    void Talk();
}
public interface IWalkable
{
    void Walk();
}

public interface IFlyable
{
    void Fly();
}
public class FlyWithJet:IFlyable
{
    public void Fly()
    {
        System.Console.WriteLine("I Can Fly With Jet");
    }
}
public class NormalFlyable:IFlyable
{
    public void Fly()
    {
        System.Console.WriteLine("I Can Fly Normally");
    }
}

public class NonFlayable : IFlyable
{
    public void Fly()
    {
        System.Console.WriteLine("I Can't Fly Normally");
    }
}
public class NormalWalk:IWalkable
{
    public void Walk()
    {
        System.Console.WriteLine("I Can Walk Normally");
    }
}

public class NonWalkable : IWalkable
{
    public void Walk()
    {
        System.Console.WriteLine("I Can't Walk Normally");
    }
}


public class NormalTalk:ITalkable
{
    public void Talk()
    {
        Console.WriteLine("I am Talking Normally");
    }
}
public class NoTalk:ITalkable
{
    public void Talk()
    {
        Console.WriteLine("I Can't Talk");
    }
}
public abstract class Robot
{

    ITalkable Talkable;
    IWalkable Walkable;
    IFlyable Flyable;

    public Robot(ITalkable talkable,IWalkable walkable,IFlyable flyable)
    {
        Talkable=talkable;
        Walkable=walkable;
        Flyable=flyable;
    }
    public void SetTalk(ITalkable talkable)
    {
        talkable.Talk();
    }
    public void SetWalk(IWalkable walkable)
    {
        walkable.Walk();
    }
    public void SetFly(IFlyable flyable)
    {
        flyable.Fly();
    }
    public abstract void Projection();
}

public class CompanionRobot:Robot
{
    public CompanionRobot():base(new NormalTalk(),new NormalWalk(),new NonFlayable())
    {
        
    }
    public override void Projection()
    {
        System.Console.WriteLine(" I am a Companion Robot");
    }

    public static void Main()
    {
        CompanionRobot companionRobot=new CompanionRobot();
        companionRobot.Projection();

        companionRobot.SetWalk(new NormalWalk());
        companionRobot.SetTalk(new NormalTalk());
        companionRobot.SetFly(new FlyWithJet());
    }
}