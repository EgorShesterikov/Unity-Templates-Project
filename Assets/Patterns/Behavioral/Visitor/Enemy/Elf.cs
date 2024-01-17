namespace Visitor
{
    public class Elf : Enemy
    {
        public override void Accept(IEnemyVisitor visitor)
            => visitor.Visit(this);
    }
}
