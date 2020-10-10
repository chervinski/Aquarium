using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using System.Drawing;

namespace Aquarium
{
	class Fish
	{
		private PictureBox picture;
		private Random random;
		private int maxVelocity = 3;
		private bool foundFeed;
		private int xVelocity, vy;
		private int vx
		{
			get { return xVelocity; }
			set
			{ 
				if (value < 0 && xVelocity >= 0 || value >= 0 && xVelocity < 0)
					picture.Image.RotateFlip(RotateFlipType.RotateNoneFlipX);
				xVelocity = value;
			}
		}
		public Fish(PictureBox picture, Random random)
		{
			this.picture = picture;
			this.random = random;

			picture.Location = new Point(
				random.Next(picture.Parent.Width - picture.Width),
				random.Next(picture.Parent.Height - picture.Height));
			RandomDirection();
		}
		private void RandomDirection()
		{
			do vx = random.Next(-maxVelocity, maxVelocity + 1);
			while (vx == 0);
			do vy = random.Next(-maxVelocity, maxVelocity + 1);
			while (vy == 0);
		}
		public void Move(List<Feed> feed)
		{
			if (feed.Count != 0)
			{
				foundFeed = true;
				Point leftMouth = new Point(picture.Location.X, picture.Location.Y + picture.Height / 2),
					rightMouth = new Point(picture.Location.X + picture.Width, leftMouth.Y);

				Feed priority = feed.OrderBy(f => (int)Math.Round(Math.Min(
					Math.Sqrt(Math.Pow(leftMouth.X - f.Location.X, 2) + Math.Pow(leftMouth.Y - f.Location.Y, 2)),
					Math.Sqrt(Math.Pow(rightMouth.X - f.Location.X, 2) + Math.Pow(rightMouth.Y - f.Location.Y, 2))))).First();

				Point target = new Point(priority.Location.X + priority.Side / 2, priority.Location.Y + priority.Side / 2),
					mouth = 
						Math.Pow(leftMouth.X - priority.Location.X, 2) <
						Math.Pow(rightMouth.X - priority.Location.X, 2) ? leftMouth : rightMouth;

				int dx = Math.Abs(target.X - mouth.X), dy = Math.Abs(target.Y - mouth.Y);
				vx = dx < maxVelocity ? dx : maxVelocity;
				vy = dy < maxVelocity ? dy : maxVelocity;
				vx *= target.X < mouth.X ? -1 : 1;
				vy *= target.Y < mouth.Y ? -1 : 1;

				if (mouth.X + vx == target.X && mouth.Y + vy == target.Y)
				{
					priority.Dispose();
					feed.Remove(priority);
					foundFeed = false;
					RandomDirection();
				}
			}
			else
			{
				if (foundFeed)
				{
					foundFeed = false;
					RandomDirection();
					return;
				}
				if (random.NextDouble() < maxVelocity * 0.004)
					RandomDirection();
				if (picture.Location.X + picture.Width >= picture.Parent.Width || picture.Location.X <= 0)
				{
					picture.Location = new Point(picture.Location.X <= 0 ? 0 : picture.Parent.Width - picture.Width, picture.Location.Y);
					vx = vx < 0 ? random.Next(1, maxVelocity + 1) : random.Next(-maxVelocity, 0);
				}
				if (picture.Location.Y + picture.Height >= picture.Parent.Height || picture.Location.Y <= 0)
				{
					picture.Location = new Point(picture.Location.X, picture.Location.Y <= 0 ? 0 : picture.Parent.Height - picture.Height);
					vy = vy < 0 ? random.Next(1, maxVelocity + 1) : random.Next(-maxVelocity, 0);
				}
			}
			picture.Location = new Point(picture.Location.X + vx, picture.Location.Y + vy);
		}
	}
}
