using System;
using System.Diagnostics;
using FakeAxeAndDummy.Contracts;
using Moq;

[DebuggerDisplay("{" + nameof(GetDebuggerDisplay) + "(),nq}")]
public class Dummy :ITarget
{
    private int health;
    private int experience;

    public Dummy(int health, int experience)
    {
        this.health = health;
        this.experience = experience;
    }

    public Dummy()
    {

    }

    public virtual int Health 
    {
        get { return this.health; }
    }

    public virtual void TakeAttack(int attackPoints)
    {
        if (this.IsDead())
        {
            throw new InvalidOperationException("Dummy is dead.");
        }

        this.health -= attackPoints;
    }

    public virtual int GiveExperience()
    {
        if (!this.IsDead())
        {
            throw new InvalidOperationException("Target is not dead.");
        }

        return this.experience;
    }

    public virtual bool IsDead()
    {
        return this.health <= 0;
    }

    private string GetDebuggerDisplay()
    {
        return ToString();
    }

    public static explicit operator Dummy(Mock<ITarget> v)
    {
        throw new NotImplementedException();
    }
}
