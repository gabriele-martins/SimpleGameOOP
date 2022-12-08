using System.Drawing;

namespace ArenaDeBatalha.GameLogic
{
    public class Enemy : GameObject
    {
        public Enemy(Size bounds, Graphics screenPainter, Point position) : base(bounds,screenPainter)
        {
            this.Left = position.X;
            this.Top = position.Y;
            this.Speed = 5;
            this.Sound = Media.ExploshionShort;
        }
        public override Bitmap GetSprite()
        {
            return Media.Enemy;
        }
        public override void UpdadeObject()
        {
            this.MoveDown();
            base.UpdadeObject();
        }
    }
}
