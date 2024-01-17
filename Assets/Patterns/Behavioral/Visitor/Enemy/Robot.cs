namespace Visitor
{
    public class Robot : Enemy
    {
        public override void Accept(IEnemyVisitor visitor)
            => visitor.Visit(this);
    }
}
