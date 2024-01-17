namespace Visitor
{
    public interface IEnemyVisitor
    {
        // Project Settings -> Other settings -> Api Compatibility Level* -> .NET Framework
        // void Visit(Enemy enemy);

        void Visit(Elf elf);
        void Visit(Ork ork);
        void Visit(Robot robot);
    }
}
