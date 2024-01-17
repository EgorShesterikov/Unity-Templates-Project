namespace Visitor
{
    public abstract class Enemy
    { 
        public abstract void Accept(IEnemyVisitor visitor);
    }
}
