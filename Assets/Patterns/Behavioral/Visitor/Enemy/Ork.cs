namespace Visitor
{
    public class Ork : Enemy
    {
        public override void Accept(IEnemyVisitor visitor)
            => visitor.Visit(this);
    }
}
