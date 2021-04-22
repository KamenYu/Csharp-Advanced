using FakeAxeAndDummy.Contracts;
using Moq;

public class StartUp
{
    static void Main(string[] args)
    {
        //IWeapon weapon = new Axe(10, 10);
        //ITarget target = new Dummy(300, 8);

        //Hero hero = new Hero("K", weapon);
        //hero.Attack(target);

        Mock<IWeapon> weapon = new Mock<IWeapon>();
        Mock<ITarget> dummy = new Mock<ITarget>();
        //---------------------------------------\\
        //------IMPI-----\\
        //---------------------------------------\\
        dummy.Setup(d => d.TakeAttack(30)).Verifiable();
        weapon.Setup(w => w.Attack(It.IsAny<ITarget>()))
            .Callback(() =>
            {
                dummy.Object.TakeAttack(30);
            });

        weapon.Object.Attack(dummy.Object);
        dummy.Verify(d => d.TakeAttack(30), Times.Once());
        //---------------------------------------\\

        weapon.Setup(t => t.AttackPoints).Returns(34);
        //all values are by default , so when a change is needed use Setup(x => x.TheMethod()).ChooseWhatToDo(); 
        dummy.Setup(d => d.GiveExperience()).Returns(20);
        Hero hero = new Hero("K", weapon.Object);
        hero.Attack(dummy.Object);
    }
}
